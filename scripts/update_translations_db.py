from __future__ import annotations

import json
import sqlite3
from pathlib import Path


REPO_ROOT = Path(__file__).resolve().parents[1]
TRANSLATIONS_ROOT = REPO_ROOT / "instat" / "translations"
DATABASE_PATH = TRANSLATIONS_ROOT / "rInstatTranslations.db"


def iter_translation_rows() -> list[tuple[str, str, str]]:
    rows: list[tuple[str, str, str]] = []
    seen_keys: set[tuple[str, str]] = set()

    for language_dir in sorted(path for path in TRANSLATIONS_ROOT.iterdir() if path.is_dir()):
        language_code = language_dir.name

        for json_path in sorted(language_dir.glob("*.json")):
            with json_path.open(encoding="utf-8") as json_file:
                contents = json.load(json_file)

            if not isinstance(contents, dict):
                raise ValueError(f"Expected top-level object in {json_path}")

            for id_text, translation in contents.items():
                if not isinstance(id_text, str) or not isinstance(translation, str):
                    raise ValueError(
                        f"Expected string key/value pairs in {json_path}, got {type(id_text)} -> {type(translation)}"
                    )
                translation_key = (id_text, language_code)
                if translation_key in seen_keys:
                    continue

                seen_keys.add(translation_key)
                rows.append((id_text, language_code, translation))

    return rows


def refresh_database() -> int:
    rows = iter_translation_rows()

    with sqlite3.connect(DATABASE_PATH) as connection:
        cursor = connection.cursor()
        cursor.execute("DELETE FROM translations")
        cursor.executemany(
            "INSERT INTO translations (id_text, language_code, translation) VALUES (?, ?, ?)",
            rows,
        )
        connection.commit()

    return len(rows)


if __name__ == "__main__":
    inserted_rows = refresh_database()
    print(f"Refreshed translations table with {inserted_rows} rows.")