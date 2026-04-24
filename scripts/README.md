# R-Instat Translation Tools

Static analysis + maintenance tools for the R-Instat VB.NET translation system.

## Overview

Three scripts keep the VB.NET code and the English source JSON
(`instat/translations/en/r_instat_menus.json`,
`r_instat_not_menus.json`) in sync:

- **`check-translations`** — read-only. Reports strings present in code but missing from the EN JSON. Exits non-zero if any missing. Used by CI to fail PRs.
- **`sync-translations`** — appends missing strings into the correct EN JSON file (menus vs. not_menus). Run locally before committing.
- **`prune-orphans`** — removes EN JSON keys that are absent from both the pattern-based scan AND a broad scan of every string literal in the `.vb` codebase. Opt-in, destructive, dry-run by default.

The EN JSON is the single source of truth. CI enforces that any new VB string has a matching key in the JSON before a PR merges.

## Quick Start

```bash
# Install dependencies
npm install

# Build TypeScript
npm run build

# Report what's missing (exits 1 if any)
npm run check-translations

# Append missing strings to the EN JSON
npm run sync-translations

# Preview sync without writing
npm run sync-translations:dry-run

# Preview orphan prune candidates (dry-run by default)
npm run prune-orphans

# Actually delete prune-eligible orphans
npm run prune-orphans:write

# CI mode: changed files only, GitHub annotations
npm run check-translations:ci
```

## Developer workflow

1. Edit VB, add new UI string.
2. `npm run sync-translations` — EN JSON files get the new keys appended.
3. Review the JSON diff and commit it alongside the VB edits.
4. Push. CI runs `check-translations:ci` → passes.

If step 2 is skipped: CI fails, the PR comment points at `npm run sync-translations`. Fix locally, push fix commit.

## Architecture

### System Context

This tool is an **early warning gate** in the translation workflow, complementing (not replacing) the existing runtime reflection system:

```
┌─────────────────────────────────────────────────────────────────────────────┐
│                        R-Instat Translation Workflow                         │
├─────────────────────────────────────────────────────────────────────────────┤
│                                                                              │
│  ┌──────────────┐      ┌──────────────┐      ┌──────────────┐               │
│  │   VB.NET     │      │    JSON      │      │   SQLite     │               │
│  │   Source     │─────▶│  (English)   │─────▶│   Database   │               │
│  │   Code       │      │              │      │              │               │
│  └──────────────┘      └──────────────┘      └──────────────┘               │
│         │                     │                     │                        │
│         │                     ▼                     │                        │
│         │              ┌──────────────┐             │                        │
│         │              │   Crowdin    │             │                        │
│         │              │ (Translation │             │                        │
│         │              │   Platform)  │             │                        │
│         │              └──────────────┘             │                        │
│         │                     │                     │                        │
│         │                     ▼                     │                        │
│         │              ┌──────────────┐             │                        │
│         │              │  Translated  │─────────────┘                        │
│         │              │    JSONs     │                                      │
│         │              └──────────────┘                                      │
│         │                                                                    │
│         │  ╔═══════════════════════════════════════════════════════╗        │
│         │  ║         THIS TOOL (Static Analysis)                   ║        │
│         └──╫────────────────────────────────────────────────────────╫────┐   │
│            ║  Detects drift BEFORE merge:                          ║    │   │
│            ║  • Code → JSON: Missing translations                  ║    │   │
│            ║  • JSON → Code: Orphan translations                   ║    │   │
│            ╚═══════════════════════════════════════════════════════╝    │   │
│                                                                         │   │
│  ┌──────────────────────────────────────────────────────────────────────┘   │
│  │                                                                          │
│  │  ┌─────────────────────────────────────────────────────────────────┐     │
│  │  │              Runtime Reflection (Translations.vb)               │     │
│  └──│  • Authoritative generation of form_controls.csv               │     │
│     │  • Requires running the app                                     │     │
│     │  • Used pre-release to update translation DB                    │     │
│     └─────────────────────────────────────────────────────────────────┘     │
│                                                                              │
└─────────────────────────────────────────────────────────────────────────────┘
```

### Module Architecture

```
┌─────────────────────────────────────────────────────────────────────────────┐
│                         check-translations.ts                                │
│                         (Orchestrator ~150 LOC)                              │
├─────────────────────────────────────────────────────────────────────────────┤
│                                                                              │
│   ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐        │
│   │  CLI Args   │  │  File       │  │   Run       │  │  Output     │        │
│   │  Parsing    │─▶│  Discovery  │─▶│   Check     │─▶│  Report     │        │
│   └─────────────┘  └─────────────┘  └─────────────┘  └─────────────┘        │
│                                                                              │
└───────────────────────────────┬─────────────────────────────────────────────┘
                                │
                    Composes these modules:
                                │
        ┌───────────────────────┼───────────────────────┐
        │                       │                       │
        ▼                       ▼                       ▼
┌───────────────┐      ┌───────────────┐      ┌───────────────┐
│ vbnet-parser  │      │  translation  │      │   reporter    │
│    (.ts)      │      │   -checker    │      │    (.ts)      │
├───────────────┤      │    (.ts)      │      ├───────────────┤
│ • Parse .vb   │      ├───────────────┤      │ • Console     │
│ • Extract     │      │ • Load JSONs  │      │ • JSON file   │
│   strings     │      │ • Check keys  │      │ • GitHub      │
│ • Filter      │      │ • Normalize   │      │   annotations │
└───────────────┘      └───────────────┘      └───────────────┘
        │                                              ▲
        │                                              │
        ▼                                              │
┌───────────────┐      ┌───────────────┐              │
│ control-name  │      │    pattern    │              │
│  -inference   │◀────▶│   -matcher    │              │
│    (.ts)      │      │    (.ts)      │              │
├───────────────┤      ├───────────────┤              │
│ • Form name   │      │ • Load        │              │
│   from path   │      │   translateIgnore.txt       │
│ • Control     │      │ • SQLite LIKE │              │
│   from code   │      │   patterns    │              │
└───────────────┘      └───────────────┘              │
                                                      │
                       ┌───────────────┐              │
                       │   git-utils   │──────────────┘
                       │    (.ts)      │   (CI mode: changed files)
                       ├───────────────┤
                       │ • Get changed │
                       │   files       │
                       │ • Detect CI   │
                       └───────────────┘
```

### Data Flow (Detailed)

```
                              INPUT SOURCES
    ┌─────────────────────────────────────────────────────────────────┐
    │                                                                 │
    │  ┌─────────────────┐  ┌─────────────────┐  ┌─────────────────┐ │
    │  │   VB.NET Files  │  │ translateIgnore │  │  English JSON   │ │
    │  │  instat/**/*.vb │  │      .txt       │  │ r_instat_*.json │ │
    │  └────────┬────────┘  └────────┬────────┘  └────────┬────────┘ │
    │           │                    │                    │          │
    └───────────┼────────────────────┼────────────────────┼──────────┘
                │                    │                    │
                ▼                    ▼                    ▼
    ┌───────────────────┐  ┌─────────────────┐  ┌─────────────────────┐
    │   vbnet-parser    │  │ pattern-matcher │  │ translation-checker │
    │                   │  │                 │  │                     │
    │ Regex patterns:   │  │ SQLite LIKE:    │  │ Load & index:       │
    │ • .Text = "..."   │  │ • % = wildcard  │  │ • menus.json        │
    │ • SetText("...")  │  │ • \_ = literal  │  │ • not_menus.json    │
    │ • SetLabel("...") │  │ • ! = negation  │  │                     │
    │ • .ToolTipText    │  │                 │  │                     │
    └─────────┬─────────┘  └────────┬────────┘  └──────────┬──────────┘
              │                     │                      │
              ▼                     │                      │
    ┌───────────────────────────────┼──────────────────────┼──────────┐
    │                   PROCESSING PIPELINE                │          │
    │                               │                      │          │
    │  ┌────────────────────────────┼──────────────────────┼───────┐  │
    │  │         For each extracted string:                │       │  │
    │  │                            │                      │       │  │
    │  │  1. Infer control name ────┘                      │       │  │
    │  │     dlgOptions.Designer.vb + Me.cmdOk.Text        │       │  │
    │  │     → "dlgOptions_cmdOk"                          │       │  │
    │  │                            │                      │       │  │
    │  │  2. Check ignore patterns ◀┘                      │       │  │
    │  │     Does "dlgOptions_cmdOk" match any pattern?    │       │  │
    │  │     → If yes: skip (ignored)                      │       │  │
    │  │                                                   │       │  │
    │  │  3. Check dynamic controls                        │       │  │
    │  │     Is controlName ucrInput* or ucrCheck*?        │       │  │
    │  │     → If yes: skip (dynamic at runtime)           │       │  │
    │  │                                                   │       │  │
    │  │  4. Check translation exists ◀────────────────────┘       │  │
    │  │     Is string in menus.json OR not_menus.json?            │  │
    │  │     → If no: VIOLATION (missing translation)              │  │
    │  │                                                           │  │
    │  └───────────────────────────────────────────────────────────┘  │
    │                                                                 │
    └─────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
    ┌─────────────────────────────────────────────────────────────────┐
    │                    BIDIRECTIONAL ANALYSIS                       │
    │                                                                 │
    │  ┌─────────────────────────┐    ┌─────────────────────────────┐ │
    │  │   Code → JSON           │    │   JSON → Code               │ │
    │  │   (Missing)             │    │   (Orphans)                 │ │
    │  ├─────────────────────────┤    ├─────────────────────────────┤ │
    │  │                         │    │                             │ │
    │  │  Extracted strings      │    │  Translation keys           │ │
    │  │  NOT in JSON            │    │  NOT in extracted strings   │ │
    │  │                         │    │                             │ │
    │  │  = New UI text needs    │    │  = Either:                  │ │
    │  │    to be added to       │    │    • Orphaned (removed UI)  │ │
    │  │    translation files    │    │    • Not captured by        │ │
    │  │                         │    │      static analysis        │ │
    │  │                         │    │      (MsgBox, dynamic)      │ │
    │  └─────────────────────────┘    └─────────────────────────────┘ │
    │                                                                 │
    └─────────────────────────────────────────────────────────────────┘
                                    │
                                    ▼
    ┌─────────────────────────────────────────────────────────────────┐
    │                         OUTPUT                                   │
    │                                                                 │
    │  ┌─────────────────────────┐    ┌─────────────────────────────┐ │
    │  │   Console Summary       │    │   translation-report.json   │ │
    │  ├─────────────────────────┤    ├─────────────────────────────┤ │
    │  │                         │    │                             │ │
    │  │  📊 Extraction Stats    │    │  Full details:              │ │
    │  │  📊 Coverage Stats      │    │  • All violations           │ │
    │  │  ❌ Missing count       │    │  • File:line locations      │ │
    │  │  ⚠️ Orphan count        │    │  • Control patterns         │ │
    │  │                         │    │  • Orphan lists             │ │
    │  └─────────────────────────┘    └─────────────────────────────┘ │
    │                                                                 │
    │  CI Mode also outputs:                                          │
    │  • GitHub annotations (::warning file=...,line=...)             │
    │  • PR comment with markdown table                               │
    │  • Non-zero exit code → fails the PR check                      │
    │                                                                 │
    └─────────────────────────────────────────────────────────────────┘
```

### File Structure

```
scripts/
├── check-translations.ts    # Read-only. Reports drift, exits 1 on missing.
├── sync-translations.ts     # Write. Appends missing strings to EN JSON.
├── prune-orphans.ts         # Write. Deletes orphans (broad-index safeguard).
├── lib/
│   ├── pattern-matcher.ts         # SQLite LIKE pattern matching
│   ├── control-name-inference.ts  # Form/control name inference
│   ├── vbnet-parser.ts            # VB.NET string extraction
│   ├── translation-checker.ts     # JSON loading/checking
│   ├── translation-writer.ts      # JSON append/remove + menu route classifier
│   ├── string-indexer.ts          # Broad VB string-literal index (prune safety)
│   ├── scan.ts                    # Shared pure scan pipeline
│   ├── orphan-finder.ts           # Finds JSON keys not seen by static analysis
│   ├── reporter.ts                # Output formatting (console/JSON/GitHub)
│   ├── git-utils.ts               # Git operations (changed files, CI detection)
│   └── project-root.ts            # Project root discovery
├── package.json             # Dependencies (TypeScript only)
├── tsconfig.json            # TypeScript config
├── .gitignore               # Ignores dist/, node_modules/, report
└── README.md                # This file

.github/
└── workflows/
    └── translation-check.yml  # CI workflow

## How It Works

### String Extraction

The tool extracts strings from these patterns:
- `.Text = "..."` assignments (Designer files)
- `SetText("...")` method calls
- `SetLabel("...")` method calls
- `SetLabelText("...")` method calls
- `.ToolTipText = "..."` assignments

### Control Name Inference

Aligns with the runtime reflection system:
- Form name from file path: `dlgOptions.Designer.vb` → `dlgOptions`
- Control name from assignment: `Me.cmdOptions.Text = "..."` → `cmdOptions`
- Full pattern: `dlgOptions_cmdOptions`

### Ignore Patterns

Uses the existing `translateIgnore.txt` file to exclude controls:
- `%\_ucrInput%` - Excludes all ucrInput controls
- `%\_txtReceiverSingle` - Excludes single receivers
- `frmMain` - Excludes main form version text

### Filtering

Automatically filters out:
- Empty strings
- Strings < 2 characters
- Whitespace-only strings
- Numeric-only strings (e.g., "123")
- Punctuation-only strings

## CLI Options

### `check-translations`
```
--ci          CI mode: only check changed files, use GitHub-friendly output
--verbose     Show detailed information including pattern matches
--json        Output as JSON
--help        Show help message
```

### `sync-translations`
```
--dry-run     Report what would be added; write nothing
--verbose     Show detailed scan logs
--help        Show help message
```

### `prune-orphans`
```
--dry-run     (Default) Report candidates, write nothing
--write       Write deletions (requires --yes)
--yes         Confirm destructive deletion
--verbose     Show detailed scan logs
--help        Show help message
```

### Routing rule (sync-translations)

Missing strings are routed by the VB control-name prefix:
- `mnu*` → `r_instat_menus.json`
- anything else → `r_instat_not_menus.json`

### Safety rule (prune-orphans)

An orphan is eligible to prune only if it is absent from BOTH:
1. The pattern-based scan (`.Text=`, `SetText`, `SetLabel`, `SetLabelText`, `ToolTipText`), AND
2. A broad index of every string literal in every `.vb` file under `instat/`.

This catches strings invisible to pattern analysis (e.g. `MsgBox("...")`, `Throw New Exception("...")`, `.Items.Add("...")`, dynamic control calls).

## CI Integration

The `.github/workflows/translation-check.yml` workflow:
1. Triggers on PRs that modify VB.NET files
2. Checks only changed files for missing translations (`check-translations:ci`)
3. Posts a summary comment on the PR
4. **Fails the PR check** if any strings in code are missing from EN JSON

The EN JSON is the single source of truth. A failing check tells the author to run `npm run sync-translations` locally and commit the updated JSON.

## Output Formats

### Console (Default)

Shows a summary and writes full details to `translation-report.json`:

```
╔═══════════════════════════════════════════════════════════════╗
║            Translation Check Summary                          ║
╚═══════════════════════════════════════════════════════════════╝

📊 Extraction Statistics:
   Files checked:         1100
   Strings extracted:     7965
   Strings ignored:       62

📊 Translation Coverage:
   Translation keys:      6148
   Missing in JSON:       1077 (code → JSON)
   Orphan translations:   2304 (JSON → code)

❌ Found 1077 strings in code missing from translations.
⚠️  Found 2304 translations not found in extracted code.
   (Could be orphaned or not captured by static analysis)

📄 Full report written to: /path/to/scripts/translation-report.json
```

### GitHub (CI Mode)

Outputs GitHub workflow annotations and a markdown summary suitable for PR comments.

### JSON Report (translation-report.json)

```json
{
  "totalFilesChecked": 1100,
  "totalStringsExtracted": 7965,
  "totalStringsIgnored": 62,
  "totalMissingTranslations": 1077,
  "totalTranslationKeys": 6148,
  "totalOrphanTranslations": 2304,
  "violations": [
    {
      "filePath": "/path/to/file.vb",
      "lineNumber": 123,
      "string": "Missing text",
      "controlName": "lblControl",
      "fullControlPattern": "dlgExample_lblControl"
    }
  ],
  "orphanAnalysis": {
    "orphanMenus": ["Menu item not in code", ...],
    "orphanNotMenus": ["Dialog text not in code", ...],
    "total": 2304
  }
}
```

## Extending

### Adding New String Patterns

Edit `lib/vbnet-parser.ts` to add new extraction functions.

### Adding New Ignore Patterns

Edit `instat/translations/translateIgnore.txt` following the existing format.

### Custom Filtering

Edit the `filterStrings` function in `lib/vbnet-parser.ts`.

## License

GPL-3.0 (same as R-Instat)
