#!/usr/bin/env python3
"""Shared translation tooling for check/sync scripts.

This module handles the shared Python implementation for:
- Parse VB.NET files for candidate translatable strings.
- Apply translateIgnore.txt SQLite-like patterns with negation.
- Exclude known dynamic controls.
- Check against EN JSON translation keys.
- Classify missing strings into menus vs not_menus routes.
"""

from __future__ import annotations

import json
import os
import re
import subprocess
import sys
from dataclasses import dataclass
from datetime import datetime, timezone
from pathlib import Path
from typing import Dict, Iterable, List, Optional, Sequence, Set, Tuple


PROJECT_MARKERS: Tuple[str, ...] = (".git", "instat", "Instat.sln")
SKIP_DIRS: Set[str] = {"bin", "obj", ".git"}
MENUS_REL = Path("instat/translations/en/r_instat_menus.json")
NOT_MENUS_REL = Path("instat/translations/en/r_instat_not_menus.json")
IGNORE_REL = Path("instat/translations/translateIgnore.txt")


@dataclass
class Pattern:
    pattern: str
    is_negation: bool
    original_line: str


@dataclass
class PatternFile:
    patterns: List[Pattern]
    negations: List[Pattern]
    text_ignores: Set[str]
    text_negations: Set[str]
    normalized_text_ignores: Set[str]
    normalized_text_negations: Set[str]
    file_path: Path


@dataclass
class ExtractedString:
    value: str
    line_number: int
    column_start: int
    column_end: int
    pattern: str
    control_name: Optional[str]
    raw_line: str


@dataclass
class ParseResult:
    file_path: str
    strings: List[ExtractedString]
    errors: List[str]


@dataclass
class InferredControl:
    form_name: Optional[str]
    control_name: Optional[str]
    full_pattern: Optional[str]
    confidence: str


@dataclass
class CombinedTranslations:
    menus: Dict[str, str]
    not_menus: Dict[str, str]
    all_keys: Set[str]
    normalized_key_map: Dict[str, str]


def find_project_root(start_dir: Optional[Path] = None, max_depth: int = 20) -> Path:
    current = (start_dir or Path.cwd()).resolve()
    for _ in range(max_depth):
        for marker in PROJECT_MARKERS:
            if (current / marker).exists():
                return current
        if current.parent == current:
            break
        current = current.parent
    markers = ", ".join(PROJECT_MARKERS)
    raise RuntimeError(
        "Could not find R-Instat project root. "
        f"Searched upward from: {start_dir or Path.cwd()} Looking for markers: {markers}"
    )


def load_patterns(file_path: Path) -> PatternFile:
    patterns: List[Pattern] = []
    negations: List[Pattern] = []
    text_ignores: Set[str] = set()
    text_negations: Set[str] = set()
    normalized_text_ignores: Set[str] = set()
    normalized_text_negations: Set[str] = set()

    if not file_path.exists():
        return PatternFile(
            patterns=patterns,
            negations=negations,
            text_ignores=text_ignores,
            text_negations=text_negations,
            normalized_text_ignores=normalized_text_ignores,
            normalized_text_negations=normalized_text_negations,
            file_path=file_path,
        )

    for line in file_path.read_text(encoding="utf-8-sig").splitlines():
        trimmed = line.strip()
        if not trimmed or trimmed.startswith("#"):
            continue

        is_negation = trimmed.startswith("!")
        body = trimmed[1:].lstrip() if is_negation else trimmed

        if body.lower().startswith("text:"):
            payload = body[5:]
            parsed_text = payload.strip()

            if parsed_text.startswith('"') and parsed_text.endswith('"'):
                try:
                    parsed_value = json.loads(parsed_text)
                    if isinstance(parsed_value, str):
                        parsed_text = parsed_value
                except Exception:
                    pass

            if parsed_text == "":
                continue

            if is_negation:
                text_negations.add(parsed_text)
                normalized_text_negations.add(normalize_string(parsed_text))
            else:
                text_ignores.add(parsed_text)
                normalized_text_ignores.add(normalize_string(parsed_text))
        elif is_negation:
            pattern_text = body
            if pattern_text:
                negations.append(
                    Pattern(pattern=pattern_text, is_negation=True, original_line=line)
                )
        else:
            patterns.append(Pattern(pattern=body, is_negation=False, original_line=line))

    return PatternFile(
        patterns=patterns,
        negations=negations,
        text_ignores=text_ignores,
        text_negations=text_negations,
        normalized_text_ignores=normalized_text_ignores,
        normalized_text_negations=normalized_text_negations,
        file_path=file_path,
    )


def load_translate_ignore(base_dir: Path) -> PatternFile:
    return load_patterns(base_dir / IGNORE_REL)


def pattern_to_regex(pattern: str) -> re.Pattern[str]:
    regex_parts: List[str] = []
    i = 0
    while i < len(pattern):
        ch = pattern[i]
        nxt = pattern[i + 1] if i + 1 < len(pattern) else ""

        if ch == "\\" and nxt == "_":
            regex_parts.append("_")
            i += 2
        elif ch == "%":
            regex_parts.append(".*")
            i += 1
        elif ch == "_":
            regex_parts.append(".")
            i += 1
        else:
            regex_parts.append(re.escape(ch))
            i += 1

    return re.compile(r"^" + "".join(regex_parts) + r"$", re.IGNORECASE)


def matches_pattern(control_name: str, pattern: str) -> bool:
    return bool(pattern_to_regex(pattern).match(control_name))


def find_matching_pattern(control_name: str, patterns: Sequence[Pattern]) -> Optional[Pattern]:
    for pattern in patterns:
        if matches_pattern(control_name, pattern.pattern):
            return pattern
    return None


def should_ignore(control_name: str, pattern_file: PatternFile) -> Tuple[bool, Optional[Pattern], Optional[Pattern]]:
    matched_pattern = find_matching_pattern(control_name, pattern_file.patterns)
    if not matched_pattern:
        return False, None, None

    matched_negation = find_matching_pattern(control_name, pattern_file.negations)
    if matched_negation:
        return False, matched_pattern, matched_negation

    return True, matched_pattern, None


def should_ignore_text(value: str, pattern_file: PatternFile) -> bool:
    if value in pattern_file.text_ignores:
        return value not in pattern_file.text_negations

    normalized = normalize_string(value)
    if normalized in pattern_file.normalized_text_ignores:
        return normalized not in pattern_file.normalized_text_negations

    return False


def join_continued_lines(lines: Sequence[str]) -> List[Tuple[str, int]]:
    joined: List[Tuple[str, int]] = []
    current = ""
    start_line = 1

    for index, line in enumerate(lines, start=1):
        trimmed = line.rstrip()

        if not current:
            start_line = index

        if trimmed.endswith(" _") or trimmed.endswith("\t_"):
            current += trimmed[:-1] + " "
        else:
            current += line
            joined.append((current, start_line))
            current = ""

    if current:
        joined.append((current, start_line))

    return joined


def extract_string_literal(line: str, start_index: int) -> Optional[Tuple[str, int]]:
    if start_index < 0 or start_index >= len(line) or line[start_index] != '"':
        return None

    chars: List[str] = []
    i = start_index + 1
    while i < len(line):
        if line[i] == '"':
            if i + 1 < len(line) and line[i + 1] == '"':
                chars.append('"')
                i += 2
            else:
                return "".join(chars), i
        else:
            chars.append(line[i])
            i += 1

    return None


TEXT_RE = re.compile(r"(?:Me\.)?(\w+)\.Text\s*=\s*\"", re.IGNORECASE)
TOOLTIP_RE = re.compile(r"(?:Me\.)?(\w+)\.ToolTipText\s*=\s*\"", re.IGNORECASE)
SETTEXT_RE = re.compile(r"(\w+)\.SetText\s*\(\s*\"", re.IGNORECASE)
SETLABEL_RE = re.compile(r"(\w+)\.SetLabel\s*\(\s*\"", re.IGNORECASE)
SETLABELTEXT_RE = re.compile(r"(\w+)\.SetLabelText\s*\(\s*\"", re.IGNORECASE)
SETCHECKBOXTEXT_RE = re.compile(r"(\w+)\.SetCheckBoxText\s*\(\s*\"", re.IGNORECASE)

# Method names whose first string-literal argument IS extracted for translation.
# Update alongside the regexes above when adding a new UI text setter.
KNOWN_TEXT_SETTERS = frozenset({"SetText", "SetLabelText", "SetCheckBoxText"})
_TEXT_SETTER_FAMILY_RE = re.compile(r"\.(Set\w+Text)\s*\(")


def _extract_by_regex(line: str, line_number: int, regex: re.Pattern[str], pattern_name: str) -> List[ExtractedString]:
    results: List[ExtractedString] = []
    for match in regex.finditer(line):
        control_name = match.group(1)
        string_start = match.start() + len(match.group(0)) - 1
        extracted = extract_string_literal(line, string_start)
        if extracted:
            value, end_idx = extracted
            results.append(
                ExtractedString(
                    value=value,
                    line_number=line_number,
                    column_start=string_start,
                    column_end=end_idx,
                    pattern=pattern_name,
                    control_name=control_name,
                    raw_line=line,
                )
            )
    return results


def parse_vbnet_content(content: str, file_path: str) -> ParseResult:
    strings: List[ExtractedString] = []
    errors: List[str] = []

    try:
        joined_lines = join_continued_lines(content.splitlines())
        for line, line_number in joined_lines:
            trimmed = line.strip()
            if not trimmed or trimmed.startswith("'"):
                continue

            strings.extend(_extract_by_regex(line, line_number, TEXT_RE, "Text"))
            strings.extend(_extract_by_regex(line, line_number, TOOLTIP_RE, "ToolTipText"))
            strings.extend(_extract_by_regex(line, line_number, SETTEXT_RE, "SetText"))
            strings.extend(_extract_by_regex(line, line_number, SETLABEL_RE, "SetLabel"))
            strings.extend(_extract_by_regex(line, line_number, SETLABELTEXT_RE, "SetLabelText"))
            strings.extend(_extract_by_regex(line, line_number, SETCHECKBOXTEXT_RE, "SetCheckBoxText"))
    except Exception as exc:  # pragma: no cover - defensive
        errors.append(f"Error parsing content: {exc}")

    return ParseResult(file_path=file_path, strings=strings, errors=errors)


def parse_vbnet_file(file_path: Path) -> ParseResult:
    try:
        content = file_path.read_text(encoding="utf-8")
        return parse_vbnet_content(content, str(file_path))
    except Exception as exc:
        return ParseResult(
            file_path=str(file_path),
            strings=[],
            errors=[f"Error reading file {file_path}: {exc}"],
        )


def filter_strings(strings: Sequence[ExtractedString]) -> List[ExtractedString]:
    filtered: List[ExtractedString] = []
    for item in strings:
        value = item.value
        if value == "":
            continue
        if value.strip() == "":
            continue
        if re.fullmatch(r"[_\s]+", value):
            continue
        if len(value) < 2:
            continue
        if re.fullmatch(r"[\d.,\-+%]+", value.strip()):
            continue
        if re.fullmatch(r"[^\w\s]+", value):
            continue
        filtered.append(item)
    return filtered


def infer_form_name(file_path: str) -> Optional[str]:
    base = Path(file_path).name
    lower = base.lower()
    if lower.endswith(".designer.vb"):
        return base[: -len(".Designer.vb")]
    if lower.endswith(".vb"):
        return base[: -len(".vb")]
    return None


def infer_control_name(code_line: str) -> Optional[str]:
    patterns = (
        r"Me\.(\w+)\.Text\s*=",
        r"(\w+)\.Text\s*=",
        r"Me\.(\w+)\.ToolTipText\s*=",
        r"(\w+)\.ToolTipText\s*=",
        r"(\w+)\.SetText\s*\(",
        r"(\w+)\.SetLabel\s*\(",
        r"(\w+)\.SetLabelText\s*\(",
        r"(\w+)\.SetCheckBoxText\s*\(",
    )
    for pat in patterns:
        match = re.search(pat, code_line, re.IGNORECASE)
        if match:
            return match.group(1)
    return None


def build_control_pattern(form_name: Optional[str], control_name: Optional[str]) -> Optional[str]:
    if not form_name and not control_name:
        return None
    if form_name and control_name:
        return f"{form_name}_{control_name}"
    return control_name or form_name


def infer_full_control_name(file_path: str, code_line: str) -> InferredControl:
    form_name = infer_form_name(file_path)
    control_name = infer_control_name(code_line)
    full_pattern = build_control_pattern(form_name, control_name)

    if form_name and control_name and re.match(r"^(dlg|frm|sdg)", form_name, re.IGNORECASE):
        confidence = "high"
    elif form_name and control_name:
        confidence = "medium"
    else:
        confidence = "low"

    return InferredControl(
        form_name=form_name,
        control_name=control_name,
        full_pattern=full_pattern,
        confidence=confidence,
    )


def is_dynamic_control(control_name: Optional[str]) -> bool:
    if not control_name:
        return False
    lower = control_name.lower()
    return lower.startswith("ucrinput") or lower.startswith("ucrcheck")


def normalize_string(value: str) -> str:
    return " ".join(value.strip().split())


def load_translation_file(file_path: Path) -> Tuple[Dict[str, str], Optional[str]]:
    if not file_path.exists():
        return {}, f"File not found: {file_path}"

    try:
        raw = json.loads(file_path.read_text(encoding="utf-8-sig"))
        if not isinstance(raw, dict):
            return {}, f"Invalid JSON object in: {file_path}"
        translations = {str(k): str(v) for k, v in raw.items()}
        return translations, None
    except Exception as exc:
        return {}, f"Error loading file {file_path}: {exc}"


def load_english_translations(base_dir: Path) -> CombinedTranslations:
    menus_path = base_dir / MENUS_REL
    not_menus_path = base_dir / NOT_MENUS_REL

    menus, menus_err = load_translation_file(menus_path)
    not_menus, not_menus_err = load_translation_file(not_menus_path)

    if menus_err:
        raise RuntimeError(f"Cannot load menus JSON: {menus_err}")
    if not_menus_err:
        raise RuntimeError(f"Cannot load not_menus JSON: {not_menus_err}")

    all_keys: Set[str] = set()
    normalized_key_map: Dict[str, str] = {}

    for key in menus.keys():
        all_keys.add(key)
        normalized_key_map.setdefault(normalize_string(key), key)

    for key in not_menus.keys():
        all_keys.add(key)
        normalized_key_map.setdefault(normalize_string(key), key)

    return CombinedTranslations(
        menus=menus,
        not_menus=not_menus,
        all_keys=all_keys,
        normalized_key_map=normalized_key_map,
    )


def check_string_in_translations(search_string: str, translations: CombinedTranslations) -> Dict[str, object]:
    if search_string in translations.all_keys:
        return {
            "string": search_string,
            "foundInMenus": search_string in translations.menus,
            "foundInNotMenus": search_string in translations.not_menus,
            "found": True,
            "matchedKey": search_string,
        }

    normalized = normalize_string(search_string)
    matched_key = translations.normalized_key_map.get(normalized)
    if matched_key:
        return {
            "string": search_string,
            "foundInMenus": matched_key in translations.menus,
            "foundInNotMenus": matched_key in translations.not_menus,
            "found": True,
            "matchedKey": matched_key,
        }

    return {
        "string": search_string,
        "foundInMenus": False,
        "foundInNotMenus": False,
        "found": False,
        "matchedKey": None,
    }


def classify_route(control_name: Optional[str]) -> str:
    if control_name and re.match(r"^mnu", control_name, re.IGNORECASE):
        return "menus"
    return "notMenus"


def _exec_git(args: Sequence[str], cwd: Path) -> Optional[str]:
    try:
        result = subprocess.run(
            ["git", *args],
            cwd=str(cwd),
            check=True,
            capture_output=True,
            text=True,
        )
        return result.stdout.strip()
    except Exception:
        return None


def get_base_branch() -> str:
    return os.getenv("GITHUB_BASE_REF", "master")


REMOTE_CANDIDATES: Tuple[str, ...] = ("origin", "upstream")


def _resolve_base_ref(base: str, base_dir: Path) -> Optional[str]:
    """Return the first ref that exists locally.

    Tries <base>, then <remote>/<base> for each remote in REMOTE_CANDIDATES.
    Locally devs typically have only origin/<base> (or upstream/<base> on a
    fork); on GitHub Actions with fetch-depth:0, <base> is a local branch.
    """
    candidates = (base, *(f"{r}/{base}" for r in REMOTE_CANDIDATES))
    for candidate in candidates:
        if _exec_git(["rev-parse", "--verify", "--quiet", candidate], base_dir):
            return candidate
    return None


def _strip_remote_prefix(ref: str) -> str:
    for remote in REMOTE_CANDIDATES:
        prefix = f"{remote}/"
        if ref.startswith(prefix):
            return ref[len(prefix):]
    return ref


def get_changed_vbnet_files(base_dir: Path, base_branch: Optional[str] = None) -> Tuple[List[str], str, Optional[str]]:
    base = base_branch or get_base_branch()
    resolved = _resolve_base_ref(base, base_dir)
    if not resolved:
        hint_base = _strip_remote_prefix(base)
        tried = ", ".join(f"'{c}'" for c in (base, *(f"{r}/{base}" for r in REMOTE_CANDIDATES)))
        return [], base, (
            f"Could not resolve base ref '{base}' (tried {tried}). "
            f"Fetch the base branch (e.g. `git fetch origin {hint_base}`) or pass --base=<ref>."
        )

    merge_base = _exec_git(["merge-base", resolved, "HEAD"], base_dir)
    if merge_base:
        output = _exec_git(["diff", "--name-only", merge_base, "HEAD"], base_dir)
    else:
        output = _exec_git(["diff", "--name-only", f"{resolved}...HEAD"], base_dir)

    if output is None:
        hint_base = _strip_remote_prefix(resolved)
        return [], resolved, (
            f"git diff against '{resolved}' failed. "
            f"On a shallow clone, deepen with `git fetch --deepen=50 origin {hint_base}`."
        )

    files = [line.strip() for line in output.splitlines() if line.strip()]
    vb_files: List[str] = []
    for file_path in files:
        lowered = file_path.lower().replace("\\", "/")
        if lowered.endswith(".vb") and "instat/" in lowered:
            vb_files.append(file_path)

    return vb_files, resolved, None


def find_uncovered_text_setters(base_dir: Path, threshold: int = 5) -> List[Tuple[str, int]]:
    """Return Set*Text method names used in VB code but missing an extractor regex.

    Catches the next SetCheckBoxText-style coverage gap: any new `.Set\\w+Text(`
    call site that isn't in KNOWN_TEXT_SETTERS will surface here once it crosses
    the threshold (avoids noise from one-off helpers).
    """
    counts: Dict[str, int] = {}
    for vb_file in find_vbnet_files(base_dir / "instat"):
        try:
            content = vb_file.read_text(encoding="utf-8")
        except Exception:
            continue
        for line in content.splitlines():
            stripped = line.lstrip()
            if stripped.startswith("'") or stripped[:4].lower() == "rem ":
                continue
            for match in _TEXT_SETTER_FAMILY_RE.finditer(line):
                name = match.group(1)
                if name not in KNOWN_TEXT_SETTERS:
                    counts[name] = counts.get(name, 0) + 1
    return sorted(
        ((name, count) for name, count in counts.items() if count >= threshold),
        key=lambda item: (-item[1], item[0]),
    )


def is_ci() -> bool:
    return (
        os.getenv("CI") == "true"
        or os.getenv("GITHUB_ACTIONS") == "true"
        or bool(os.getenv("GITHUB_RUN_ID"))
    )


def find_vbnet_files(instat_dir: Path) -> List[Path]:
    files: List[Path] = []

    for root, dirs, filenames in os.walk(instat_dir):
        dirs[:] = [d for d in dirs if d not in SKIP_DIRS]
        for name in filenames:
            if name.lower().endswith(".vb"):
                files.append(Path(root) / name)

    return files


def resolve_files_to_scan(
    base_dir: Path,
    ci_mode: bool,
    explicit_files: Sequence[str],
    base_branch: Optional[str] = None,
) -> Tuple[List[Path], Optional[str]]:
    if explicit_files:
        paths: List[Path] = []
        for item in explicit_files:
            p = Path(item)
            if not p.is_absolute():
                p = (base_dir / p).resolve()
            paths.append(p)
        return paths, None

    if ci_mode:
        changed, resolved_base, error = get_changed_vbnet_files(base_dir, base_branch)
        if error:
            print(
                f"warning: --ci could not determine changed files: {error}\n"
                f"warning: falling back to whole-repo scan.",
                file=sys.stderr,
            )
            return find_vbnet_files(base_dir / "instat"), error
        return [(base_dir / p).resolve() for p in changed], f"CI mode base ref: {resolved_base}"

    return find_vbnet_files(base_dir / "instat"), None


def run_scan(
    base_dir: Path,
    *,
    ci_mode: bool = False,
    verbose: bool = False,
    files: Optional[Sequence[str]] = None,
    base_branch: Optional[str] = None,
) -> Dict[str, object]:
    ignore_patterns = load_translate_ignore(base_dir)
    translations = load_english_translations(base_dir)

    files_to_scan, ci_info = resolve_files_to_scan(base_dir, ci_mode, files or [], base_branch)

    if verbose:
        print(f"Loaded {len(ignore_patterns.patterns)} ignore patterns")
        print(f"Loaded {len(ignore_patterns.text_ignores)} text ignore rules")
        print(f"Loaded {len(translations.all_keys)} translation keys")
        if ci_info:
            print(ci_info)

    violations: List[Dict[str, object]] = []
    extracted_strings: Set[str] = set()
    classified_missing: Dict[str, str] = {}

    total_files_checked = 0
    total_strings_extracted = 0
    total_strings_ignored = 0

    for file_path in files_to_scan:
        if not file_path.exists():
            if verbose:
                print(f"Skipping non-existent file: {file_path}")
            continue

        parse_result = parse_vbnet_file(file_path)
        total_files_checked += 1

        if parse_result.errors and verbose:
            for err in parse_result.errors:
                print(f"Warning: {err}")

        filtered = filter_strings(parse_result.strings)
        total_strings_extracted += len(filtered)

        for extracted in filtered:
            if should_ignore_text(extracted.value, ignore_patterns):
                total_strings_ignored += 1
                if verbose:
                    print(f"Ignored (text rule): \"{extracted.value}\"")
                continue

            control_info = infer_full_control_name(parse_result.file_path, extracted.raw_line)
            full_pattern = control_info.full_pattern

            pattern_should_ignore = False
            matched_pattern: Optional[Pattern] = None
            matched_negation: Optional[Pattern] = None

            if full_pattern:
                pattern_should_ignore, matched_pattern, matched_negation = should_ignore(
                    full_pattern, ignore_patterns
                )
                if pattern_should_ignore:
                    total_strings_ignored += 1
                    if verbose:
                        print(
                            f"Ignored: \"{extracted.value}\" "
                            f"(pattern: {matched_pattern.pattern if matched_pattern else 'n/a'})"
                        )
                    continue

            if is_dynamic_control(extracted.control_name):
                total_strings_ignored += 1
                if verbose:
                    print(
                        f"Ignored (dynamic control): \"{extracted.value}\" "
                        f"({extracted.control_name})"
                    )
                continue

            extracted_strings.add(extracted.value)
            extracted_strings.add(normalize_string(extracted.value))

            translation_check = check_string_in_translations(extracted.value, translations)
            if not bool(translation_check["found"]):
                violation = {
                    "filePath": parse_result.file_path,
                    "lineNumber": extracted.line_number,
                    "string": extracted.value,
                    "controlName": extracted.control_name,
                    "fullControlPattern": full_pattern,
                    "patternMatch": {
                        "shouldIgnore": pattern_should_ignore,
                        "matchedPattern": matched_pattern.pattern if matched_pattern else None,
                        "matchedNegation": matched_negation.pattern if matched_negation else None,
                    },
                    "translationCheck": translation_check,
                }
                violations.append(violation)

                if extracted.value not in classified_missing:
                    classified_missing[extracted.value] = classify_route(extracted.control_name)

    return {
        "violations": violations,
        "extractedStrings": extracted_strings,
        "classifiedMissing": classified_missing,
        "translations": translations,
        "ignorePatterns": ignore_patterns,
        "stats": {
            "totalFilesChecked": total_files_checked,
            "totalStringsExtracted": total_strings_extracted,
            "totalStringsIgnored": total_strings_ignored,
        },
    }


def find_orphans(extracted_strings: Set[str], translations: CombinedTranslations) -> Dict[str, object]:
    orphan_menus = [key for key in translations.menus.keys() if key not in extracted_strings]
    orphan_not_menus = [key for key in translations.not_menus.keys() if key not in extracted_strings]
    return {
        "orphanMenus": orphan_menus,
        "orphanNotMenus": orphan_not_menus,
        "total": len(orphan_menus) + len(orphan_not_menus),
    }


def create_summary(
    violations: List[Dict[str, object]],
    stats: Dict[str, int],
    ci_mode: bool,
    orphan_analysis: Dict[str, object],
    total_translation_keys: int,
) -> Dict[str, object]:
    return {
        "totalFilesChecked": stats["totalFilesChecked"],
        "totalStringsExtracted": stats["totalStringsExtracted"],
        "totalStringsIgnored": stats["totalStringsIgnored"],
        "totalMissingTranslations": len(violations),
        "totalTranslationKeys": total_translation_keys,
        "totalOrphanTranslations": int(orphan_analysis["total"]),
        "violations": violations,
        "orphanAnalysis": orphan_analysis,
        "timestamp": datetime.now(timezone.utc).isoformat(),
        "ciMode": ci_mode,
    }


def write_report_to_file(summary: Dict[str, object], output_path: Path) -> None:
    output_path.write_text(json.dumps(summary, indent=2) + "\n", encoding="utf-8")


def _truncate(value: str, max_len: int) -> str:
    if len(value) <= max_len:
        return value
    return value[:max_len] + "..."


def _md_escape_cell(value: str) -> str:
    """Escape characters that would break a markdown table cell."""
    return value.replace("\\", "\\\\").replace("|", "\\|").replace("`", "\\`")


def generate_console_summary(summary: Dict[str, object], report_path: Path) -> str:
    lines: List[str] = []
    lines.append("╔═══════════════════════════════════════════════════════════════╗")
    lines.append("║            Translation Check Summary                          ║")
    lines.append("╚═══════════════════════════════════════════════════════════════╝")
    lines.append("")
    lines.append("📊 Extraction Statistics:")
    lines.append(f"   Files checked:         {summary['totalFilesChecked']}")
    lines.append(f"   Strings extracted:     {summary['totalStringsExtracted']}")
    lines.append(f"   Strings ignored:       {summary['totalStringsIgnored']}")
    lines.append("")
    lines.append("📊 Translation Coverage:")
    lines.append(f"   Translation keys:      {summary['totalTranslationKeys']}")
    lines.append(f"   Missing in JSON:       {summary['totalMissingTranslations']} (code → JSON)")
    lines.append(f"   Orphan translations:   {summary['totalOrphanTranslations']} (JSON → code)")
    lines.append("")

    if summary["totalMissingTranslations"] > 0:
        lines.append(
            f"❌ Found {summary['totalMissingTranslations']} strings in code missing from translations."
        )
    else:
        lines.append("✅ All extracted strings exist in translation files!")

    if summary["totalOrphanTranslations"] > 0:
        lines.append(
            f"⚠️  Found {summary['totalOrphanTranslations']} translations not found in extracted code."
        )
        lines.append("   (Could be orphaned or not captured by static analysis)")

    lines.append("")
    lines.append(f"📄 Full report written to: {report_path}")
    lines.append("")
    lines.append(f"Report generated: {summary['timestamp']}")
    lines.append("(CI mode)" if summary["ciMode"] else "(Local mode)")
    return "\n".join(lines)


REPORT_START_MARKER = "<!-- translation-check-report:start -->"
REPORT_END_MARKER = "<!-- translation-check-report:end -->"
TABLE_ROW_CAP = 20
ANNOTATION_CAP = 50


def generate_github_report(summary: Dict[str, object]) -> str:
    lines: List[str] = []
    lines.append(REPORT_START_MARKER)
    lines.append("## Translation Check Results")
    lines.append("")
    lines.append("| Metric | Value |")
    lines.append("|--------|-------|")
    lines.append(f"| Files checked | {summary['totalFilesChecked']} |")
    lines.append(f"| Strings extracted | {summary['totalStringsExtracted']} |")
    lines.append(f"| Strings ignored | {summary['totalStringsIgnored']} |")
    lines.append(
        f"| **Missing translations** | **{summary['totalMissingTranslations']}** |"
    )
    lines.append("")

    violations = summary.get("violations", [])
    if violations:
        lines.append("### Missing Translations")
        lines.append("")
        lines.append("| File | Line | String |")
        lines.append("|------|------|--------|")

        for violation in violations[:TABLE_ROW_CAP]:
            file_path = str(violation["filePath"])  # type: ignore[index]
            line_number = int(violation["lineNumber"])  # type: ignore[index]
            value = _md_escape_cell(_truncate(str(violation["string"]), 40))  # type: ignore[index]
            lines.append(f"| `{file_path}` | {line_number} | \"{value}\" |")

        if len(violations) > TABLE_ROW_CAP:
            remaining = len(violations) - TABLE_ROW_CAP
            lines.append(f"| ... | ... | ... ({remaining} more) |")

        lines.append("")
        lines.append("---")
        lines.append("")

        for violation in violations[:ANNOTATION_CAP]:
            file_path = str(violation["filePath"])  # type: ignore[index]
            line_number = int(violation["lineNumber"])  # type: ignore[index]
            value = _truncate(str(violation["string"]), 80)  # type: ignore[index]
            lines.append(
                f"::warning file={file_path},line={line_number}::Missing translation: \"{value}\""
            )
        if len(violations) > ANNOTATION_CAP:
            lines.append(
                f"::warning::{len(violations) - ANNOTATION_CAP} additional missing strings omitted from annotations (see report)."
            )
    else:
        lines.append("✅ **No missing translations found!**")

    lines.append(REPORT_END_MARKER)
    return "\n".join(lines)


def summarize_items(title: str, items: Iterable[str]) -> str:
    values = list(items)
    lines = [f"{title}: {len(values)}"]
    preview = values[:5]
    for item in preview:
        lines.append(f'  + "{_truncate(item, 70)}"')
    if len(values) > len(preview):
        lines.append(f"  ... ({len(values) - len(preview)} more)")
    return "\n".join(lines)


def extract_all_literals_from_line(line: str) -> List[str]:
    literals: List[str] = []
    i = 0
    while i < len(line):
        ch = line[i]
        if ch == "'":
            break
        if ch == '"':
            extracted = extract_string_literal(line, i)
            if extracted:
                value, end_idx = extracted
                literals.append(value)
                i = end_idx + 1
                continue
        i += 1
    return literals


def index_all_vb_string_literals(base_dir: Path) -> Set[str]:
    index: Set[str] = set()
    vb_files = find_vbnet_files(base_dir / "instat")

    for file_path in vb_files:
        try:
            content = file_path.read_text(encoding="utf-8")
        except Exception:
            continue

        for line in content.splitlines():
            stripped = line.lstrip()
            if not stripped or stripped.startswith("'"):
                continue

            for literal in extract_all_literals_from_line(line):
                if literal == "":
                    continue
                index.add(literal)
                normalized = normalize_string(literal)
                if normalized != literal:
                    index.add(normalized)

    return index


def index_has(index: Set[str], key: str) -> bool:
    if key in index:
        return True
    return normalize_string(key) in index


def remove_text_ignored_strings(base_dir: Path, pattern_file: PatternFile) -> Dict[str, List[str]]:
    """Remove keys from the EN JSON files that match text: ignore rules."""
    menus_path = base_dir / MENUS_REL
    not_menus_path = base_dir / NOT_MENUS_REL

    menus_data, menus_err = load_translation_file(menus_path)
    not_menus_data, not_menus_err = load_translation_file(not_menus_path)
    if menus_err:
        raise RuntimeError(f"Cannot load menus JSON: {menus_err}")
    if not_menus_err:
        raise RuntimeError(f"Cannot load not_menus JSON: {not_menus_err}")

    menus: Dict[str, str] = {}
    removed_menus: List[str] = []
    for k, v in menus_data.items():
        if should_ignore_text(k, pattern_file):
            removed_menus.append(k)
        else:
            menus[k] = v

    not_menus: Dict[str, str] = {}
    removed_not_menus: List[str] = []
    for k, v in not_menus_data.items():
        if should_ignore_text(k, pattern_file):
            removed_not_menus.append(k)
        else:
            not_menus[k] = v

    if removed_menus:
        menus_path.write_text(
            json.dumps(menus, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )

    if removed_not_menus:
        not_menus_path.write_text(
            json.dumps(not_menus, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )

    return {"menus": removed_menus, "notMenus": removed_not_menus}


def append_missing_strings(base_dir: Path, classified_missing: Dict[str, str]) -> Dict[str, List[str]]:
    menus_path = base_dir / MENUS_REL
    not_menus_path = base_dir / NOT_MENUS_REL

    menus_data, menus_err = load_translation_file(menus_path)
    not_menus_data, not_menus_err = load_translation_file(not_menus_path)
    if menus_err:
        raise RuntimeError(f"Cannot load menus JSON: {menus_err}")
    if not_menus_err:
        raise RuntimeError(f"Cannot load not_menus JSON: {not_menus_err}")

    menus = dict(menus_data)
    not_menus = dict(not_menus_data)

    added_menus: List[str] = []
    added_not_menus: List[str] = []

    for key, route in classified_missing.items():
        if key in menus or key in not_menus:
            continue

        if route == "menus":
            menus[key] = key
            added_menus.append(key)
        else:
            not_menus[key] = key
            added_not_menus.append(key)

    if added_menus:
        menus_path.write_text(
            json.dumps(menus, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )

    if added_not_menus:
        not_menus_path.write_text(
            json.dumps(not_menus, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )

    return {"menus": added_menus, "notMenus": added_not_menus}


def remove_orphans(base_dir: Path, keys_to_remove: Dict[str, List[str]]) -> Dict[str, List[str]]:
    menus_path = base_dir / MENUS_REL
    not_menus_path = base_dir / NOT_MENUS_REL

    menus_data, menus_err = load_translation_file(menus_path)
    not_menus_data, not_menus_err = load_translation_file(not_menus_path)
    if menus_err:
        raise RuntimeError(f"Cannot load menus JSON: {menus_err}")
    if not_menus_err:
        raise RuntimeError(f"Cannot load not_menus JSON: {not_menus_err}")

    menus = dict(menus_data)
    not_menus = dict(not_menus_data)

    removed_menus: List[str] = []
    removed_not_menus: List[str] = []

    for key in keys_to_remove.get("menus", []):
        if key in menus:
            del menus[key]
            removed_menus.append(key)

    for key in keys_to_remove.get("notMenus", []):
        if key in not_menus:
            del not_menus[key]
            removed_not_menus.append(key)

    if removed_menus:
        menus_path.write_text(
            json.dumps(menus, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )

    if removed_not_menus:
        not_menus_path.write_text(
            json.dumps(not_menus, indent=2, ensure_ascii=False) + "\n", encoding="utf-8"
        )

    return {"menus": removed_menus, "notMenus": removed_not_menus}
