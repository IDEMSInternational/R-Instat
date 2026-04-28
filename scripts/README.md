# R-Instat Translation Tools

Python static-analysis and maintenance tools for the R-Instat VB.NET translation system.

## Overview

These scripts keep VB.NET UI strings and the English source JSON files in sync:

- `check_translations.py` (read-only): reports strings in code that are missing from EN JSON. Exits non-zero if missing strings are found.
- `sync_translations.py` (write): appends missing strings to the correct EN JSON file (menus vs not_menus), and applies `text:` ignore cleanup.
- `remove_translation_strings.py` (write): safely removes orphan EN keys by requiring absence from both the narrow pattern scan and a broad all-literals index.
- `translation_common.py`: shared scanning, parsing, filtering, reporting, and JSON helpers.

EN JSON files:

- `instat/translations/en/r_instat_menus.json`
- `instat/translations/en/r_instat_not_menus.json`

## Quick Start

Run from the repository root:

```bash
# Check all VB files (fails if any strings are missing in EN JSON)
python scripts/check_translations.py

# Check changed files in CI mode
python scripts/check_translations.py --ci

# Sync EN JSON files
python scripts/sync_translations.py

# Preview sync without writing
python scripts/sync_translations.py --dry-run

# Also run orphan removal as part of sync
python scripts/sync_translations.py --remove_orphan_strings

# Preview orphan-removal candidates
python scripts/remove_translation_strings.py --dry-run

# Apply orphan-removal candidates
python scripts/remove_translation_strings.py --write --yes
```

## Developer Workflow

1. Edit VB and add/update UI text.
2. Run `python scripts/sync_translations.py`.
3. Review JSON changes and commit them with your VB changes.
4. Push; CI runs `python scripts/check_translations.py --ci`.

## File Structure

```text
scripts/
├── check_translations.py
├── sync_translations.py
├── remove_translation_strings.py
├── translation_common.py
├── update_translations_db.py
├── translation-report.json
├── orphan-prune-candidates.json
└── .gitignore
```

## CLI Options

### `check_translations.py`

```text
--ci           CI mode: changed files and GitHub-friendly output
--base=<ref>   Base ref for --ci diff (default: $GITHUB_BASE_REF or master).
               Use --base=origin/master locally to reproduce CI behavior.
--verbose      Detailed logs
--json         JSON summary output
files...       Optional explicit VB file list
```

### `sync_translations.py`

```text
--dry-run                 Report changes, write nothing
--remove_orphan_strings   Also run remove_translation_strings as part of sync
--verbose                 Detailed logs
```

### `remove_translation_strings.py`

```text
--dry-run     Report candidates, write nothing
--write       Write deletions (requires --yes)
--yes         Confirm destructive deletion
--verbose     Detailed logs
```

## Ignore Rules

`instat/translations/translateIgnore.txt` supports:

- control-based patterns (SQLite-like `%` and `_`, with `!` negation)
- string-based rules via `text:` (with optional negation, e.g. `!text:n:`)

Examples:

- `text:n:`
- `text:"ww "`
- `%\_ucrInput%`

## What gets extracted

The scanner only sees strings passed via these patterns (defined in `translation_common.py`):

- `<control>.Text = "..."` and `Me.<control>.Text = "..."` (Designer property assignments)
- `<control>.ToolTipText = "..."`
- `<control>.SetText("...")`
- `<control>.SetLabel("...")`
- `<control>.SetLabelText("...")`
- `<control>.SetCheckBoxText("...")`

Strings passed to other methods are invisible to both check and sync. To prevent silent gaps when new UI text setters are added, `check_translations.py` runs an extractor-coverage check that fails CI if any `Set\w+Text(...)` method appears in `instat/**/*.vb` more than 5 times without a matching extractor regex. Add the regex and update `KNOWN_TEXT_SETTERS` together.

## CI Integration

The translation workflow runs `python scripts/check_translations.py --ci` on PRs touching VB files and fails the check if strings are missing from EN JSON.

To reproduce a failing CI run locally for a PR you don't own:

```bash
gh pr checkout <PR-number>
python scripts/check_translations.py --ci --base=origin/master
```

The `--base=origin/master` flag is important: locally `master` usually doesn't exist as a local branch, only `origin/master` does. CI runs against a checkout where `master` is available locally (via `fetch-depth: 0`), so it doesn't need this flag.
