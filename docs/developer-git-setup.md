# Developer Git Setup

R-Instat contributors with write access work from the shared
`IDEMSInternational/R-Instat` repository. The shared repository is named
`origin`; an optional personal fork is named `fork`.

## Reuse an existing fork clone

Do not clone R-Instat again merely because an existing checkout uses a personal
fork as `origin`. The migration helper reuses all Git objects and working files
already on disk.

From anywhere inside the existing checkout, preview the migration:

```bash
python scripts/setup_git_remotes.py migrate
```

The preview fetches the reachable `master` commit and tree history needed for
validation. Historical file contents and tags are omitted to reduce transfer
size. It does not push or change remote configuration.

The migration accepts only these fork states:

- fork `master` equals canonical `master`; or
- fork `master` is provably behind canonical `master` and can be fast-forwarded.

It fails before pushing or changing remotes when the fork is ahead, has
diverged, or a shallow checkout prevents Git from proving the relationship.
Resolve that situation manually so fork-only work is not lost.

After reviewing the preview, apply it:

```bash
python scripts/setup_git_remotes.py migrate --apply
```

The migration preserves an existing canonical SSH or HTTPS transport. When no
canonical remote exists yet, SSH users can select it explicitly:

```bash
python scripts/setup_git_remotes.py migrate --canonical-url git@github.com:IDEMSInternational/R-Instat.git
```

This fast-forwards the fork first when necessary, renames the canonical remote
to `origin`, preserves the personal fork as `fork`, and makes local `master`
track `origin/master`. It never checks out or resets a branch, force-pushes, or
deletes a remote. Existing feature branches are not published automatically.

Check an existing setup at any time:

```bash
python scripts/setup_git_remotes.py doctor
```

## Publish a feature branch

Preview and then publish the currently checked-out feature branch directly to
the shared repository:

```bash
python scripts/setup_git_remotes.py publish
python scripts/setup_git_remotes.py publish --apply
```

Publishing fails on `master` and when the working tree is not clean. The push is
never forced.

## New clone

Only developers without an existing checkout need a new clone. Use a blobless
clone to avoid downloading historical contents of large files:

```bash
git clone --filter=blob:none --no-tags https://github.com/IDEMSInternational/R-Instat.git
```

Git downloads files required by the checked-out version, but retrieves other
file contents only when needed. Avoid a shallow clone by default: truncated
history makes rebasing, merge-base checks, blame, and older-branch work less
reliable.
