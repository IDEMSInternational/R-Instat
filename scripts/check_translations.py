#!/usr/bin/env python3
"""Translation check entry point.

Read-only static analysis that fails when any strings in VB.NET code are
missing from EN translation JSON files.
"""

from __future__ import annotations

import argparse
import json
import sys
from pathlib import Path

from translation_common import (
    REPORT_END_MARKER,
    REPORT_START_MARKER,
    create_summary,
    find_orphans,
    find_project_root,
    find_uncovered_text_setters,
    generate_console_summary,
    generate_github_report,
    is_ci,
    run_scan,
    write_report_to_file,
)


def parse_args(argv: list[str]) -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Translation Check - Static analysis for missing translations"
    )
    parser.add_argument(
        "--ci",
        action="store_true",
        help="CI mode: check changed files and emit GitHub-friendly output",
    )
    parser.add_argument(
        "--verbose",
        "-v",
        action="store_true",
        help="Show detailed information",
    )
    parser.add_argument("--json", action="store_true", help="Output summary as JSON")
    parser.add_argument(
        "--base",
        default=None,
        help="Base ref for --ci diff (default: $GITHUB_BASE_REF or master). "
             "Use e.g. --base=origin/master locally to reproduce CI.",
    )
    parser.add_argument("files", nargs="*", help="Optional explicit VB files to scan")
    return parser.parse_args(argv)


def main(argv: list[str]) -> int:
    options = parse_args(argv)
    ci_mode = options.ci or is_ci()

    try:
        base_dir = find_project_root()
    except RuntimeError as exc:
        print(str(exc), file=sys.stderr)
        return 1

    if options.verbose:
        print(f"Base directory: {base_dir}")
        print(f"CI mode: {ci_mode}")

    try:
        scan_result = run_scan(
            base_dir,
            ci_mode=ci_mode,
            verbose=options.verbose,
            files=options.files,
            base_branch=options.base,
        )
    except RuntimeError as exc:
        if ci_mode:
            print(REPORT_START_MARKER)
            print("## Translation Check Results")
            print("")
            print("❌ **Translation check failed before scan completed.**")
            print("")
            print(f"Error: `{str(exc)}`")
            print(REPORT_END_MARKER)
        else:
            print(str(exc), file=sys.stderr)
        return 1

    violations = scan_result["violations"]
    stats = scan_result["stats"]
    extracted_strings = scan_result["extractedStrings"]
    translations = scan_result["translations"]

    orphan_analysis = find_orphans(extracted_strings, translations)
    total_translation_keys = len(translations.all_keys)

    summary = create_summary(
        violations,
        stats,
        ci_mode,
        orphan_analysis,
        total_translation_keys,
    )

    report_path = base_dir / "scripts" / "translation-report.json"
    write_report_to_file(summary, report_path)

    if options.json:
        print(json.dumps(summary, indent=2))
    elif ci_mode:
        print(generate_github_report(summary))
    else:
        print(generate_console_summary(summary, report_path))
        if summary["totalMissingTranslations"] > 0:
            print("")
            print("To append missing strings to the EN JSON files, run:")
            print("  python scripts/sync_translations.py")

    uncovered = find_uncovered_text_setters(base_dir)
    if uncovered:
        print("", file=sys.stderr)
        print("error: extractor coverage gap detected.", file=sys.stderr)
        print(
            "The following Set*Text(...) methods are used in VB code but have no "
            "extractor regex in translation_common.py. Strings passed to them are "
            "silently invisible to check/sync. Add a regex and update KNOWN_TEXT_SETTERS:",
            file=sys.stderr,
        )
        for name, count in uncovered:
            print(f"  - {name} ({count} call sites)", file=sys.stderr)
        return 1

    if summary["totalMissingTranslations"] > 0:
        return 1

    return 0


if __name__ == "__main__":
    sys.exit(main(sys.argv[1:]))
