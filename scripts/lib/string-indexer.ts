/**
 * String Indexer Module
 *
 * Builds a broad index of user-facing-candidate string literals by scanning
 * every `.vb` file in the `instat/` tree. Unlike the extract/filter pipeline
 * in vbnet-parser.ts which only matches 5 syntactic patterns (.Text=, SetText,
 * etc.), this indexer picks up ANY string literal: MsgBox arguments, exception
 * messages, .AddItem calls, concatenations, Dim/Const initializers, etc.
 *
 * Use case: cross-checking orphan prune candidates. A JSON key that looks like
 * an orphan via static pattern analysis may actually be live in a MsgBox or
 * dynamic control. The broad index catches those.
 *
 * Phase 1 scope: .vb files only. Stubs for .R and .resx are declared for
 * phase-2 expansion without API churn.
 */

import * as fs from 'fs/promises';
import * as path from 'path';

import { extractStringLiteral } from './vbnet-parser.js';
import { normalizeString } from './translation-checker.js';

const SKIP_DIRS = new Set(['node_modules', 'bin', 'obj', '.git']);

async function findFilesByExt(dir: string, extLower: string): Promise<string[]> {
  const files: string[] = [];
  const dirsToProcess: string[] = [dir];

  while (dirsToProcess.length > 0) {
    const batch = dirsToProcess.splice(0, 10);
    const batchResults = await Promise.all(
      batch.map(async (currentDir) => {
        const localFiles: string[] = [];
        const localDirs: string[] = [];
        try {
          const entries = await fs.readdir(currentDir, { withFileTypes: true });
          for (const entry of entries) {
            const fullPath = path.join(currentDir, entry.name);
            if (entry.isDirectory()) {
              if (!SKIP_DIRS.has(entry.name)) localDirs.push(fullPath);
            } else if (entry.isFile() && entry.name.toLowerCase().endsWith(extLower)) {
              localFiles.push(fullPath);
            }
          }
        } catch {
          // Skip unreadable.
        }
        return { files: localFiles, dirs: localDirs };
      })
    );
    for (const r of batchResults) {
      files.push(...r.files);
      dirsToProcess.push(...r.dirs);
    }
  }

  return files;
}

/**
 * Walks a line character-by-character, finding every `"..."` literal and
 * calling the existing extractStringLiteral parser (which handles escaped
 * quotes `""`). Comments starting with `'` end literal-scanning for that line.
 */
function extractAllLiteralsFromLine(line: string): string[] {
  const results: string[] = [];
  let i = 0;
  while (i < line.length) {
    const ch = line[i];
    // VB comment — rest of line is commentary, no more literals.
    if (ch === "'") {
      break;
    }
    if (ch === '"') {
      const extracted = extractStringLiteral(line, i);
      if (extracted) {
        results.push(extracted.value);
        i = extracted.endIndex + 1;
        continue;
      }
    }
    i++;
  }
  return results;
}

/**
 * Builds a Set of every string literal appearing in any .vb file under the
 * project. Both raw and normalized forms are added so consumers can look up
 * either way (`has(raw)` OR `has(normalize(raw))`).
 */
export async function indexAllVBStringLiterals(baseDir: string): Promise<Set<string>> {
  const index = new Set<string>();
  const instatDir = path.join(baseDir, 'instat');
  const files = await findFilesByExt(instatDir, '.vb');

  const BATCH_SIZE = 20;
  for (let i = 0; i < files.length; i += BATCH_SIZE) {
    const batch = files.slice(i, i + BATCH_SIZE);
    const contents = await Promise.all(
      batch.map(async (filePath) => {
        try {
          return await fs.readFile(filePath, 'utf-8');
        } catch {
          return '';
        }
      })
    );

    for (const content of contents) {
      if (!content) continue;
      const lines = content.split(/\r?\n/);
      for (const line of lines) {
        const trimmed = line.trimStart();
        if (trimmed === '' || trimmed.startsWith("'")) continue;
        const literals = extractAllLiteralsFromLine(line);
        for (const v of literals) {
          if (v === '') continue;
          index.add(v);
          const normalized = normalizeString(v);
          if (normalized !== v) index.add(normalized);
        }
      }
    }
  }

  return index;
}

/**
 * Tests whether a key is present in the broad index, with the same
 * normalize-fallback behavior used by translation-checker.
 */
export function indexHas(index: Set<string>, key: string): boolean {
  if (index.has(key)) return true;
  const normalized = normalizeString(key);
  return index.has(normalized);
}

// --- Phase 2 stubs (not yet wired in; provided to avoid API churn later) ---

export async function indexRScriptStrings(_baseDir: string): Promise<Set<string>> {
  // Phase 2: scan instat/static/InstatObject/R/*.R for user-facing strings.
  return new Set<string>();
}

export async function indexResxStrings(_baseDir: string): Promise<Set<string>> {
  // Phase 2: parse <data name="..."><value>...</value></data> nodes in *.resx.
  return new Set<string>();
}
