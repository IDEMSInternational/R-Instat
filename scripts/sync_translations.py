#!/usr/bin/env python3
"""Sync translations entry point.

Appends missing strings from VB.NET scan results into the EN translation JSON
files under instat/translations/en/.
"""

from __future__ import annotations

import argparse
import sys

from remove_translation_strings import run_remove_translation_strings

from translation_common import (
    append_missing_strings,
    find_project_root,
    load_translation_file,
    MENUS_REL,
    NOT_MENUS_REL,
    remove_text_ignored_strings,
    run_scan,
    should_ignore_text,
    summarize_items,
)


def parse_args(argv: list[str]) -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Sync Translations - Append missing strings to the EN JSON files"
    )
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Report changes without writing files",
    )
    parser.add_argument(
        "--verbose",
        "-v",
        action="store_true",
        help="Show detailed scan logs",
    )
    parser.add_argument(
        "--remove_orphan_strings",
        action="store_true",
        help="Run remove_translation_strings as part of sync",
    )
    return parser.parse_args(argv)


def main(argv: list[str]) -> int:
    options = parse_args(argv)

    try:
        base_dir = find_project_root()
    except RuntimeError as exc:
        print(str(exc), file=sys.stderr)
        return 1

    if options.verbose:
        mode = "dry-run" if options.dry_run else "write"
        print(f"Base directory: {base_dir}")
        print(f"Mode: {mode}")

    scan_result = run_scan(base_dir, ci_mode=False, verbose=options.verbose)
    classified_missing = scan_result["classifiedMissing"]
    ignore_patterns = scan_result["ignorePatterns"]
    stats = scan_result["stats"]

    print("")
    print("Scan results:")
    print(f"  Files scanned:       {stats['totalFilesChecked']}")
    print(f"  Strings extracted:   {stats['totalStringsExtracted']}")
    print(f"  Strings ignored:     {stats['totalStringsIgnored']}")
    print(f"  Missing in EN JSON:  {len(classified_missing)}")
    print("")

    auto_removed = {"menus": [], "notMenus": []}
    if options.remove_orphan_strings:
        remove_result = run_remove_translation_strings(
            base_dir,
            dry_run=options.dry_run,
            verbose=options.verbose,
            scan_result=scan_result,
        )
        auto_removed = remove_result["removed"]
        print(
            summarize_items(
                "Auto remove_translation_strings from r_instat_menus.json",
                auto_removed["menus"],
            )
        )
        print("")
        print(
            summarize_items(
                "Auto remove_translation_strings from r_instat_not_menus.json",
                auto_removed["notMenus"],
            )
        )
        print("")

    if options.dry_run:
        menus_data, _ = load_translation_file(base_dir / MENUS_REL)
        not_menus_data, _ = load_translation_file(base_dir / NOT_MENUS_REL)
        would_remove_menus = [k for k in menus_data if should_ignore_text(k, ignore_patterns)]
        would_remove_not_menus = [k for k in not_menus_data if should_ignore_text(k, ignore_patterns)]

        would_add_menus = [k for k, v in classified_missing.items() if v == "menus"]
        would_add_not_menus = [k for k, v in classified_missing.items() if v != "menus"]

        print("Dry-run - no files written.")
        print("")
        if would_remove_menus or would_remove_not_menus:
            print(summarize_items("Would remove from r_instat_menus.json (text: rules)", would_remove_menus))
            print("")
            print(summarize_items("Would remove from r_instat_not_menus.json (text: rules)", would_remove_not_menus))
            print("")
        print(summarize_items("Would append to r_instat_menus.json", would_add_menus))
        print("")
        print(summarize_items("Would append to r_instat_not_menus.json", would_add_not_menus))
        return 0

    removed = remove_text_ignored_strings(base_dir, ignore_patterns)

    if removed["menus"] or removed["notMenus"]:
        print(summarize_items("Removed from r_instat_menus.json (text: rules)", removed["menus"]))
        print("")
        print(summarize_items("Removed from r_instat_not_menus.json (text: rules)", removed["notMenus"]))
        print("")

    if (
        len(classified_missing) == 0
        and not removed["menus"]
        and not removed["notMenus"]
        and not auto_removed["menus"]
        and not auto_removed["notMenus"]
    ):
        print("Nothing to sync - all extracted strings exist in EN JSON.")
        return 0

    added = append_missing_strings(base_dir, classified_missing)

    print("Wrote EN JSON updates.")
    print("")
    print(summarize_items("Appended to r_instat_menus.json", added["menus"]))
    print("")
    print(summarize_items("Appended to r_instat_not_menus.json", added["notMenus"]))
    print("")
    print("Next: review the diff and commit the EN JSON changes along with your VB edits.")

    return 0


if __name__ == "__main__":
    sys.exit(main(sys.argv[1:]))
