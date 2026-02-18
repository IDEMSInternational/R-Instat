# R-Instat Translation Check

Static analysis tool to detect missing translations in R-Instat VB.NET codebase.

## Overview

This tool scans VB.NET files for user-facing strings (`.Text = "..."`, `SetText("...")`, etc.) and verifies they exist in the English translation JSON files. It's designed to run both locally and in CI, aligning with the existing runtime reflection system used by R-Instat.

## Quick Start

```bash
# Install dependencies
npm install

# Build TypeScript
npm run build

# Run translation check on all files
npm run check-translations

# Run in CI mode (only changed files)
npm run check-translations:ci

# Run with verbose output
npm run check-translations:verbose
```

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
    │  • Review request to @ksiinga                                   │
    │                                                                 │
    └─────────────────────────────────────────────────────────────────┘
```

### File Structure

```
scripts/
├── check-translations.ts    # Main orchestrator (CLI, composition)
├── lib/
│   ├── pattern-matcher.ts   # SQLite LIKE pattern matching
│   ├── control-name-inference.ts  # Form/control name inference
│   ├── vbnet-parser.ts      # VB.NET string extraction
│   ├── translation-checker.ts    # JSON loading/checking
│   ├── reporter.ts          # Output formatting (console/JSON/GitHub)
│   └── git-utils.ts         # Git operations (changed files, CI detection)
├── package.json             # Dependencies (TypeScript only)
├── tsconfig.json            # TypeScript config
├── .gitignore               # Ignores dist/, node_modules/, report
└── README.md                # This file

.github/
├── CODEOWNERS               # @ksiinga for translation files
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

```
--ci          CI mode: only check changed files, use GitHub-friendly output
--verbose     Show detailed information including pattern matches
--json        Output as JSON
--help        Show help message
```

## CI Integration

The `.github/workflows/translation-check.yml` workflow:
1. Triggers on PRs that modify VB.NET files
2. Checks only changed files for missing translations
3. Posts a summary comment on the PR
4. Requests review from translation oversight (`@ksiinga`) if violations found
5. Adds `needs-translation-review` label to the PR

The workflow does NOT fail the PR - it only requests reviews to ensure translation oversight.

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
