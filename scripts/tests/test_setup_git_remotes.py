import contextlib
import io
import subprocess
import tempfile
import unittest
from pathlib import Path

from scripts import setup_git_remotes as migration


def git(repo: Path, *args: str) -> str:
    result = subprocess.run(
        ["git", *args],
        cwd=repo,
        check=True,
        text=True,
        stdout=subprocess.PIPE,
        stderr=subprocess.PIPE,
    )
    return result.stdout.strip()


class RepositoryFixture(unittest.TestCase):
    def setUp(self) -> None:
        self.temporary_directory = tempfile.TemporaryDirectory()
        self.repo = Path(self.temporary_directory.name)
        git(self.repo, "init", "--initial-branch=master")
        git(self.repo, "config", "user.name", "Migration Test")
        git(self.repo, "config", "user.email", "migration@example.invalid")
        self.base = self.commit("base")

    def tearDown(self) -> None:
        self.temporary_directory.cleanup()

    def commit(self, message: str) -> str:
        git(self.repo, "commit", "--allow-empty", "-m", message)
        return git(self.repo, "rev-parse", "HEAD")

    def test_equal_master_is_accepted(self) -> None:
        self.assertEqual(
            migration.classify_fork_master(self.repo, self.base, self.base),
            "equal",
        )

    def test_fork_behind_is_accepted(self) -> None:
        main = self.commit("main change")
        self.assertEqual(
            migration.classify_fork_master(self.repo, self.base, main),
            "behind",
        )

    def test_fork_ahead_fails(self) -> None:
        fork = self.commit("fork-only change")
        with self.assertRaisesRegex(migration.MigrationError, "commits absent"):
            migration.classify_fork_master(self.repo, fork, self.base)

    def test_diverged_fork_fails(self) -> None:
        main = self.commit("main change")
        git(self.repo, "checkout", "--detach", self.base)
        fork = self.commit("fork change")
        with self.assertRaisesRegex(migration.MigrationError, "diverged"):
            migration.classify_fork_master(self.repo, fork, main)

    def test_publish_rejects_noncanonical_push_url(self) -> None:
        git(self.repo, "checkout", "-b", "feature/test")
        git(self.repo, "remote", "add", "origin", migration.CANONICAL_URL)
        git(
            self.repo,
            "remote",
            "set-url",
            "--push",
            "origin",
            "https://github.com/person/R-Instat.git",
        )
        with self.assertRaisesRegex(migration.MigrationError, "push URL"):
            migration.publish_current(
                self.repo, migration.CANONICAL_URL, migration.DEFAULT_BRANCH, False
            )

    def test_publish_rejects_multiple_push_urls(self) -> None:
        git(self.repo, "checkout", "-b", "feature/test")
        git(self.repo, "remote", "add", "origin", migration.CANONICAL_URL)
        git(
            self.repo,
            "remote",
            "set-url",
            "--add",
            "--push",
            "origin",
            "git@github.com:IDEMSInternational/R-Instat.git",
        )
        git(
            self.repo,
            "remote",
            "set-url",
            "--add",
            "--push",
            "origin",
            migration.CANONICAL_URL,
        )
        with self.assertRaisesRegex(migration.MigrationError, "exactly one"):
            migration.publish_current(
                self.repo, migration.CANONICAL_URL, migration.DEFAULT_BRANCH, False
            )

    def test_migration_normalizes_push_urls_and_preserves_dirty_state(self) -> None:
        canonical_directory = tempfile.TemporaryDirectory()
        extra_directory = tempfile.TemporaryDirectory()
        self.addCleanup(canonical_directory.cleanup)
        self.addCleanup(extra_directory.cleanup)
        canonical = Path(canonical_directory.name)
        extra = Path(extra_directory.name)
        git(canonical, "init", "--bare")
        git(extra, "init", "--bare")

        git(self.repo, "remote", "add", "origin", str(canonical))
        git(self.repo, "push", "origin", "master")
        git(self.repo, "remote", "set-url", "--add", "--push", "origin", str(extra))

        dirty_file = self.repo / "dirty.txt"
        dirty_file.write_text("staged\n", encoding="utf-8")
        git(self.repo, "add", "dirty.txt")
        dirty_file.write_text("staged\nunstaged\n", encoding="utf-8")
        status_before = git(self.repo, "status", "--porcelain=v2")

        with contextlib.redirect_stdout(io.StringIO()):
            self.assertEqual(
                migration.migrate(
                    self.repo, str(canonical), migration.DEFAULT_BRANCH, True
                ),
                0,
            )

        self.assertEqual(git(self.repo, "status", "--porcelain=v2"), status_before)
        self.assertEqual(
            git(self.repo, "remote", "get-url", "--push", "--all", "origin"),
            str(canonical),
        )

    def test_validation_fetch_does_not_persist_partial_clone_config(self) -> None:
        canonical_directory = tempfile.TemporaryDirectory()
        self.addCleanup(canonical_directory.cleanup)
        canonical = Path(canonical_directory.name)
        git(canonical, "init", "--bare")
        git(self.repo, "remote", "add", "seed", str(canonical))
        git(self.repo, "push", "seed", "master")

        migration.fetch_tip(self.repo, str(canonical), migration.DEFAULT_BRANCH)

        result = subprocess.run(
            ["git", "config", "--local", "--get", "extensions.partialClone"],
            cwd=self.repo,
            check=False,
            text=True,
            stdout=subprocess.PIPE,
            stderr=subprocess.PIPE,
        )
        self.assertEqual(result.returncode, 1)
        self.assertEqual(result.stdout, "")


class RemoteTests(unittest.TestCase):
    def test_parses_https_and_ssh_github_urls(self) -> None:
        expected = "IDEMSInternational/R-Instat"
        self.assertEqual(
            migration.github_repository(
                "https://github.com/IDEMSInternational/R-Instat.git"
            ),
            expected,
        )
        self.assertEqual(
            migration.github_repository(
                "git@github.com:IDEMSInternational/R-Instat.git"
            ),
            expected,
        )

    def test_typical_fork_layout_is_renamed(self) -> None:
        remotes = [
            migration.Remote("origin", "https://github.com/person/R-Instat.git"),
            migration.Remote("upstream", migration.CANONICAL_URL),
        ]
        canonical, fork = migration.identify_remotes(
            remotes, migration.CANONICAL_URL
        )
        self.assertEqual(
            migration.planned_remote_commands(
                remotes, canonical, fork, migration.CANONICAL_URL
            ),
            [
                ["remote", "rename", "origin", "fork"],
                ["remote", "rename", "upstream", "origin"],
            ],
        )

    def test_preserves_canonical_ssh_push_transport(self) -> None:
        remote = migration.Remote(
            "upstream",
            migration.CANONICAL_URL,
            ("git@github.com:IDEMSInternational/R-Instat.git",),
        )
        self.assertEqual(
            migration.canonical_transport_urls(remote, migration.CANONICAL_URL),
            (
                migration.CANONICAL_URL,
                "git@github.com:IDEMSInternational/R-Instat.git",
            ),
        )

    def test_requires_exactly_one_canonical_push_url(self) -> None:
        canonical = "git@github.com:IDEMSInternational/R-Instat.git"
        self.assertTrue(
            migration.has_single_canonical_push_url(
                migration.Remote("origin", migration.CANONICAL_URL, (canonical,)),
                migration.CANONICAL_URL,
            )
        )
        self.assertFalse(
            migration.has_single_canonical_push_url(
                migration.Remote(
                    "origin",
                    migration.CANONICAL_URL,
                    (canonical, migration.CANONICAL_URL),
                ),
                migration.CANONICAL_URL,
            )
        )


if __name__ == "__main__":
    unittest.main()
