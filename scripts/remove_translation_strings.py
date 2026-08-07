#!/usr/bin/env python3
"""Remove translation strings that are no longer referenced by code.

This is a safer orphan-prune flow. A key is eligible only if it is absent from
both the narrow pattern scan and a broad index of all VB string literals.
"""

from __future__ import annotations

import argparse
import json
import sys
from datetime import datetime, timezone

from translation_common import (
    find_orphans,
    find_project_root,
    index_all_vb_string_literals,
    index_has,
    remove_orphans,
    run_scan,
)


def parse_args(argv: list[str]) -> argparse.Namespace:
    parser = argparse.ArgumentParser(
        description="Remove Translation Strings - Delete unreferenced EN JSON keys, safely"
    )
    parser.add_argument(
        "--dry-run",
        action="store_true",
        help="Default mode. Report candidates without writing files.",
    )
    parser.add_argument(
        "--write",
        action="store_true",
        help="Write deletions. Must be paired with --yes.",
    )
    parser.add_argument(
        "--yes",
        action="store_true",
        help="Confirm destructive deletion (only used with --write).",
    )
    parser.add_argument(
        "--verbose",
        "-v",
        action="store_true",
        help="Show detailed scan logs",
    )
    return parser.parse_args(argv)


def preview(title: str, items: list[str]) -> None:
    print(f"{title}: {len(items)}")
    for item in items[:5]:
        truncated = item[:70] + "..." if len(item) > 70 else item
        print(f'  - "{truncated}"')
    if len(items) > 5:
        print(f"  ... ({len(items) - 5} more)")


def run_remove_translation_strings(
    base_dir,
    *,
    dry_run: bool = True,
    verbose: bool = False,
    scan_result: dict | None = None,
) -> dict[str, object]:
    """Run orphan-removal analysis and optionally delete eligible keys."""
    local_scan = scan_result or run_scan(base_dir, ci_mode=False, verbose=verbose)
    extracted_strings = local_scan["extractedStrings"]
    translations = local_scan["translations"]
    stats = local_scan["stats"]

    orphans = find_orphans(extracted_strings, translations)

    broad_index = index_all_vb_string_literals(base_dir)

    orphan_menus = list(orphans["orphanMenus"])
    orphan_not_menus = list(orphans["orphanNotMenus"])

    eligible_menus = [k for k in orphan_menus if not index_has(broad_index, k)]
    eligible_not_menus = [k for k in orphan_not_menus if not index_has(broad_index, k)]

    kept_menus = len(orphan_menus) - len(eligible_menus)
    kept_not_menus = len(orphan_not_menus) - len(eligible_not_menus)

    candidates_path = base_dir / "scripts" / "orphan-prune-candidates.json"
    candidates_path.write_text(
        json.dumps(
            {
                "timestamp": datetime.now(timezone.utc).isoformat(),
                "eligibleMenus": eligible_menus,
                "eligibleNotMenus": eligible_not_menus,
                "keptMenusCount": kept_menus,
                "keptNotMenusCount": kept_not_menus,
            },
            indent=2,
        )
        + "\n",
        encoding="utf-8",
    )

    removed = {"menus": [], "notMenus": []}
    if not dry_run and (eligible_menus or eligible_not_menus):
        removed = remove_orphans(
            base_dir,
            {"menus": eligible_menus, "notMenus": eligible_not_menus},
        )

    return {
        "stats": stats,
        "orphans": orphans,
        "broadIndexSize": len(broad_index),
        "keptCount": kept_menus + kept_not_menus,
        "eligibleMenus": eligible_menus,
        "eligibleNotMenus": eligible_not_menus,
        "removed": removed,
        "candidatesPath": candidates_path,
    }


def main(argv: list[str]) -> int:
    options = parse_args(argv)

    dry_run = not options.write
    if options.dry_run:
        dry_run = True

    if options.write and not options.yes:
        print("Refusing to write: --write must be paired with --yes.", file=sys.stderr)
        print("Run without --write to preview, or add --yes to confirm.", file=sys.stderr)
        return 2

    try:
        base_dir = find_project_root()
    except RuntimeError as exc:
        print(str(exc), file=sys.stderr)
        return 1

    if options.verbose:
        mode = "write" if options.write else "dry-run"
        print(f"Base directory: {base_dir}")
        print(f"Mode: {mode}")

    result = run_remove_translation_strings(
        base_dir,
        dry_run=dry_run,
        verbose=options.verbose,
    )

    stats = result["stats"]
    orphans = result["orphans"]
    eligible_menus = result["eligibleMenus"]
    eligible_not_menus = result["eligibleNotMenus"]
    removed = result["removed"]

    print("")
    print("Scan results:")
    print(f"  Files scanned:       {stats['totalFilesChecked']}")
    print(f"  Strings extracted:   {stats['totalStringsExtracted']}")
    print(f"  Orphans (narrow):    {orphans['total']}")

    print("")
    print("Orphan filtering:")
    print(f"  Indexed literals:            {result['broadIndexSize']}")
    print(f"  Kept (seen in broad index):  {result['keptCount']}")
    print(f"  Eligible to prune:           {len(eligible_menus) + len(eligible_not_menus)}")
    print("")

    print(f"Candidate list written to: {result['candidatesPath']}")
    print("")
    preview("Eligible from r_instat_menus.json", eligible_menus)
    print("")
    preview("Eligible from r_instat_not_menus.json", eligible_not_menus)
    print("")

    if dry_run:
        print("Dry-run - no files written.")
        print("Re-run with --write --yes to actually delete.")
        return 0

    if not eligible_menus and not eligible_not_menus:
        print("Nothing to delete.")
        return 0

    print("Wrote EN JSON deletions.")
    print(f"  Removed from r_instat_menus.json:     {len(removed['menus'])}")
    print(f"  Removed from r_instat_not_menus.json: {len(removed['notMenus'])}")
    print("")
    print("Next: review the diff and commit.")

    return 0


if __name__ == "__main__":
    sys.exit(main(sys.argv[1:]))
