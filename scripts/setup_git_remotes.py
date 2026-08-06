#!/usr/bin/env python3
"""Safely migrate an existing R-Instat fork clone to the canonical repository.

The migration deliberately reuses the existing Git object database. It never
checks out files, resets a branch, force-pushes, or deletes a remote. By default
it only reports the changes it would make; pass --apply to perform them.
"""

from __future__ import annotations

import argparse
import re
import subprocess
import sys
from dataclasses import dataclass
from pathlib import Path
from typing import Iterable, Optional


CANONICAL_URL = "https://github.com/IDEMSInternational/R-Instat.git"
DEFAULT_BRANCH = "master"


class MigrationError(RuntimeError):
    """A condition that makes an automatic migration unsafe."""


@dataclass(frozen=True)
class Remote:
    name: str
    url: str
    push_urls: tuple[str, ...] = ()


def run_git(
    args: Iterable[str],
    *,
    cwd: Path,
    check: bool = True,
    capture: bool = True,
) -> subprocess.CompletedProcess[str]:
    command = ["git", *args]
    result = subprocess.run(
        command,
        cwd=cwd,
        check=False,
        text=True,
        stdout=subprocess.PIPE if capture else None,
        stderr=subprocess.PIPE if capture else None,
    )
    if check and result.returncode != 0:
        detail = (result.stderr or result.stdout or "Git command failed").strip()
        raise MigrationError(f"{' '.join(command)}: {detail}")
    return result


def github_repository(url: str) -> Optional[str]:
    """Return owner/repository for common GitHub HTTPS and SSH URLs."""
    value = url.strip().rstrip("/")
    match = re.search(
        r"(?:github\.com[/:])(?P<owner>[^/]+?)/(?P<repo>[^/]+?)(?:\.git)?$",
        value,
        flags=re.IGNORECASE,
    )
    if not match:
        return None
    return f"{match.group('owner')}/{match.group('repo')}"


def same_repository(left: str, right: str) -> bool:
    left_repo = github_repository(left)
    right_repo = github_repository(right)
    if left_repo and right_repo:
        return left_repo.casefold() == right_repo.casefold()
    return left.rstrip("/").removesuffix(".git") == right.rstrip("/").removesuffix(".git")


def list_remotes(repo: Path) -> list[Remote]:
    names = run_git(["remote"], cwd=repo).stdout.splitlines()
    remotes = []
    for name in names:
        if not name.strip():
            continue
        url = run_git(["remote", "get-url", name], cwd=repo).stdout.strip()
        push_urls = tuple(
            run_git(["remote", "get-url", "--push", "--all", name], cwd=repo)
            .stdout.strip()
            .splitlines()
        )
        remotes.append(Remote(name, url, push_urls))
    return remotes


def canonical_transport_urls(
    canonical: Optional[Remote], canonical_url: str
) -> tuple[str, str]:
    """Preserve a valid existing fetch/push transport, including SSH."""
    if not canonical:
        return canonical_url, canonical_url
    fetch_url = canonical.url
    push_url = next(
        (
            url
            for url in canonical.push_urls
            if same_repository(url, canonical_url)
        ),
        fetch_url,
    )
    return fetch_url, push_url


def has_single_canonical_push_url(remote: Remote, canonical_url: str) -> bool:
    return len(remote.push_urls) == 1 and same_repository(
        remote.push_urls[0], canonical_url
    )


def remote_tip(repo: Path, url: str, branch: str) -> str:
    result = run_git(
        ["ls-remote", "--exit-code", url, f"refs/heads/{branch}"], cwd=repo
    )
    lines = result.stdout.splitlines()
    if len(lines) != 1:
        raise MigrationError(f"Expected exactly one {branch!r} branch at {url}")
    return lines[0].split()[0]


def fetch_tip(repo: Path, url: str, branch: str) -> None:
    # An explicit source without a destination downloads the objects without
    # modifying a remote-tracking ref. --no-write-fetch-head also leaves
    # FETCH_HEAD untouched. Command-scoped remote configuration prevents Git
    # from persisting a raw URL as the partial-clone remote during a dry run.
    run_git(
        [
            "-c",
            "extensions.partialClone=migration-source",
            "-c",
            f"remote.migration-source.url={url}",
            "-c",
            "remote.migration-source.promisor=true",
            "-c",
            "remote.migration-source.partialclonefilter=blob:none",
            "fetch",
            "--no-tags",
            "--filter=blob:none",
            "--no-write-fetch-head",
            "migration-source",
            f"refs/heads/{branch}",
        ],
        cwd=repo,
        capture=False,
    )


def is_ancestor(repo: Path, older: str, newer: str) -> bool:
    result = run_git(
        ["merge-base", "--is-ancestor", older, newer], cwd=repo, check=False
    )
    if result.returncode not in (0, 1):
        detail = (result.stderr or "merge-base failed").strip()
        raise MigrationError(detail)
    return result.returncode == 0


def classify_fork_master(repo: Path, fork_tip: str, main_tip: str) -> str:
    """Return equal/behind, otherwise fail closed."""
    if fork_tip == main_tip:
        return "equal"
    if is_ancestor(repo, fork_tip, main_tip):
        return "behind"
    if is_ancestor(repo, main_tip, fork_tip):
        raise MigrationError(
            "Fork master contains commits absent from canonical master. "
            "Move or merge those commits before migrating. No branch, remote, "
            "or working-tree state was changed."
        )

    shallow = run_git(["rev-parse", "--is-shallow-repository"], cwd=repo).stdout.strip()
    qualifier = " or the shallow clone cannot prove ancestry" if shallow == "true" else ""
    raise MigrationError(
        "Fork master and canonical master have diverged"
        f"{qualifier}. Automatic migration is unsafe. No branch, remote, or "
        "working-tree state was changed."
    )


def find_repository_root(start: Path) -> Path:
    result = run_git(["rev-parse", "--show-toplevel"], cwd=start)
    return Path(result.stdout.strip()).resolve()


def identify_remotes(
    remotes: list[Remote], canonical_url: str
) -> tuple[Optional[Remote], Optional[Remote]]:
    canonical = [remote for remote in remotes if same_repository(remote.url, canonical_url)]
    canonical_repo = github_repository(canonical_url)
    forks = [
        remote
        for remote in remotes
        if github_repository(remote.url)
        and canonical_repo
        and github_repository(remote.url).split("/", 1)[1].casefold()
        == canonical_repo.split("/", 1)[1].casefold()
        and not same_repository(remote.url, canonical_url)
    ]
    if len(canonical) > 1:
        raise MigrationError("Multiple remotes point to the canonical repository.")
    if len(forks) > 1:
        raise MigrationError("Multiple personal-fork remotes found; choose one manually.")
    return (canonical[0] if canonical else None, forks[0] if forks else None)


def planned_remote_commands(
    remotes: list[Remote],
    canonical: Optional[Remote],
    fork: Optional[Remote],
    canonical_url: str,
) -> list[list[str]]:
    by_name = {remote.name: remote for remote in remotes}
    commands: list[list[str]] = []

    if "origin" in by_name and canonical and canonical.name != "origin":
        if not fork or by_name["origin"].name != fork.name:
            raise MigrationError(
                "The existing origin is neither the canonical repository nor the detected fork."
            )
        if "fork" in by_name:
            raise MigrationError("Cannot rename origin to fork because remote 'fork' exists.")
        commands.append(["remote", "rename", "origin", "fork"])
        if canonical.name == "fork":
            raise MigrationError("Ambiguous remote names; migrate them manually.")
        commands.append(["remote", "rename", canonical.name, "origin"])
    elif "origin" in by_name and not canonical:
        if not fork or fork.name != "origin":
            raise MigrationError("Cannot safely repurpose the existing origin remote.")
        if "fork" in by_name:
            raise MigrationError("Cannot rename origin to fork because remote 'fork' exists.")
        commands.append(["remote", "rename", "origin", "fork"])
        commands.append(["remote", "add", "origin", canonical_url])
    elif "origin" not in by_name:
        if canonical:
            commands.append(["remote", "rename", canonical.name, "origin"])
        else:
            commands.append(["remote", "add", "origin", canonical_url])

    # If origin is already canonical, normalize the fork's conventional name.
    if canonical and canonical.name == "origin" and fork and fork.name != "fork":
        if "fork" in by_name:
            raise MigrationError("Cannot rename the personal fork because remote 'fork' exists.")
        commands.append(["remote", "rename", fork.name, "fork"])
    return commands


def show_command(args: Iterable[str]) -> None:
    print("  git " + " ".join(args))


def doctor(repo: Path, canonical_url: str, main_branch: str) -> int:
    remotes = list_remotes(repo)
    canonical, fork = identify_remotes(remotes, canonical_url)
    problems: list[str] = []
    if not canonical or canonical.name != "origin":
        problems.append("origin does not point to the canonical repository")
    if fork and fork.name != "fork":
        problems.append(f"personal fork is named {fork.name!r}, not 'fork'")

    if (
        canonical
        and canonical.name == "origin"
        and not has_single_canonical_push_url(canonical, canonical_url)
    ):
        problems.append("origin must have exactly one canonical push URL")

    master_remote = run_git(
        ["config", "--get", f"branch.{main_branch}.remote"], cwd=repo, check=False
    ).stdout.strip()
    local_master = run_git(
        ["show-ref", "--verify", "--quiet", f"refs/heads/{main_branch}"],
        cwd=repo,
        check=False,
    )
    if local_master.returncode == 0 and master_remote != "origin":
        problems.append(f"local {main_branch} tracks {master_remote}, not origin")

    print(f"Repository: {repo}")
    for remote in remotes:
        print(f"  {remote.name}: {remote.url}")
    if problems:
        print("Doctor found configuration problems:")
        for problem in problems:
            print(f"  - {problem}")
        return 1
    print("Git remotes follow the shared-repository convention.")
    return 0


def migrate(repo: Path, canonical_url: str, main_branch: str, apply: bool) -> int:
    remotes = list_remotes(repo)
    canonical, fork = identify_remotes(remotes, canonical_url)
    if not canonical and not fork:
        raise MigrationError("No canonical R-Instat remote or personal fork was detected.")
    main_fetch_url, main_push_url = canonical_transport_urls(canonical, canonical_url)

    # Validate the complete local rewrite plan before any network push. This
    # catches ambiguous/colliding remote names while all configuration remains
    # untouched.
    commands = planned_remote_commands(remotes, canonical, fork, canonical_url)
    commands.extend(
        [
            ["config", "--local", "--replace-all", "remote.origin.url", main_fetch_url],
            [
                "config",
                "--local",
                "--replace-all",
                "remote.origin.pushurl",
                main_push_url,
            ],
            ["config", "--local", "extensions.partialClone", "origin"],
            ["config", "--local", "remote.origin.promisor", "true"],
            ["config", "--local", "remote.origin.partialclonefilter", "blob:none"],
            ["config", "--local", "remote.origin.tagOpt", "--no-tags"],
        ]
    )
    if fork:
        commands.append(
            [
                "config",
                "--local",
                "--replace-all",
                "remote.fork.pushurl",
                fork.url,
            ]
        )

    print(f"Fetching only {main_branch} commit/tree data (historical blobs omitted)...")
    main_tip = remote_tip(repo, main_fetch_url, main_branch)
    fetch_tip(repo, main_fetch_url, main_branch)

    relationship = "no fork"
    if fork:
        fork_tip = remote_tip(repo, fork.url, main_branch)
        fetch_tip(repo, fork.url, main_branch)
        relationship = classify_fork_master(repo, fork_tip, main_tip)
        print(f"Fork {main_branch}: {relationship}")
        if relationship == "behind":
            # The validation fetch intentionally omitted historical blobs. Give
            # this one command an ephemeral promisor remote so Git can retrieve
            # a missing object from canonical if send-pack needs it. No local
            # configuration is changed before the fork is synchronized.
            push = [
                "-c",
                "extensions.partialClone=migration-main",
                "-c",
                f"remote.migration-main.url={main_fetch_url}",
                "-c",
                "remote.migration-main.promisor=true",
                "-c",
                "remote.migration-main.partialclonefilter=blob:none",
                "push",
                fork.url,
                f"{main_tip}:refs/heads/{main_branch}",
            ]
            if apply:
                print(f"Fast-forwarding fork {main_branch}...")
                run_git(push, cwd=repo, capture=False)
            else:
                print("Would fast-forward the fork:")
                show_command(push)

    print("Remote/configuration changes:" if apply else "Would make these changes:")
    for command in commands:
        show_command(command)
        if apply:
            run_git(command, cwd=repo)

    if apply:
        # Establish the canonical tracking ref without downloading file history.
        run_git(
            [
                "fetch",
                "--no-tags",
                "--filter=blob:none",
                "origin",
                f"+refs/heads/{main_branch}:refs/remotes/origin/{main_branch}",
            ],
            cwd=repo,
            capture=False,
        )
        local_master = run_git(
            ["show-ref", "--verify", "--quiet", f"refs/heads/{main_branch}"],
            cwd=repo,
            check=False,
        )
        if local_master.returncode == 0:
            run_git(
                ["branch", "--set-upstream-to", f"origin/{main_branch}", main_branch],
                cwd=repo,
            )
        print("Migration complete. Existing feature branches were not pushed or rewritten.")
    else:
        print("Dry run complete. Re-run with --apply after reviewing the plan.")
    return 0


def publish_current(repo: Path, canonical_url: str, main_branch: str, apply: bool) -> int:
    remotes = list_remotes(repo)
    canonical, _ = identify_remotes(remotes, canonical_url)
    if not canonical or canonical.name != "origin":
        raise MigrationError("Run the migration first: origin is not canonical.")
    if not has_single_canonical_push_url(canonical, canonical_url):
        raise MigrationError(
            "origin must have exactly one canonical push URL; run the migration first."
        )
    branch = run_git(["symbolic-ref", "--short", "HEAD"], cwd=repo).stdout.strip()
    if branch == main_branch:
        raise MigrationError(f"Refusing to publish protected branch {main_branch!r}.")
    status = run_git(["status", "--porcelain"], cwd=repo).stdout.strip()
    if status:
        raise MigrationError("Working tree is not clean; commit or stash changes first.")
    command = ["push", "--set-upstream", "origin", "HEAD"]
    if not apply:
        print(f"Would publish {branch!r} to the canonical repository:")
        show_command(command)
        print("Dry run complete. Re-run with --apply to push.")
        return 0
    run_git(command, cwd=repo, capture=False)
    print(f"Published {branch!r} to origin and configured tracking.")
    return 0


def parse_args() -> argparse.Namespace:
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument(
        "action", choices=("migrate", "doctor", "publish"), nargs="?", default="migrate"
    )
    parser.add_argument("--apply", action="store_true", help="perform pushes/config changes")
    parser.add_argument("--repo", type=Path, default=Path.cwd(), help="path inside the clone")
    parser.add_argument(
        "--canonical-url",
        default=CANONICAL_URL,
        help="canonical repository URL (use an SSH URL to select SSH transport)",
    )
    parser.add_argument("--main-branch", default=DEFAULT_BRANCH, help=argparse.SUPPRESS)
    return parser.parse_args()


def main() -> int:
    args = parse_args()
    try:
        repo = find_repository_root(args.repo.resolve())
        if args.action == "doctor":
            return doctor(repo, args.canonical_url, args.main_branch)
        if args.action == "publish":
            return publish_current(
                repo, args.canonical_url, args.main_branch, args.apply
            )
        return migrate(repo, args.canonical_url, args.main_branch, args.apply)
    except (MigrationError, FileNotFoundError) as error:
        print(f"ERROR: {error}", file=sys.stderr)
        return 2


if __name__ == "__main__":
    raise SystemExit(main())
