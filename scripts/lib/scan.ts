/**
 * Scan Pipeline Module
 *
 * Pure composition of the existing extract/filter/ignore/classify flow.
 * Produces the set of extracted strings, the list of missing-translation
 * violations, and a route classification for each missing string.
 *
 * No file writes. No process.exit. No CLI concerns.
 */

import * as fs from 'fs/promises';
import * as path from 'path';

import { loadTranslateIgnore } from './pattern-matcher.js';
import { inferFullControlName, isDynamicControl } from './control-name-inference.js';
import { parseVBNetFile, filterStrings } from './vbnet-parser.js';
import {
  loadEnglishTranslations,
  checkStringInTranslations,
  CombinedTranslations
} from './translation-checker.js';
import { createViolation, Violation } from './reporter.js';
import { getChangedVBNetFiles, resolveFilePath } from './git-utils.js';
import { classifyRoute } from './translation-writer.js';

export interface ScanOptions {
  ciMode?: boolean;
  verbose?: boolean;
  /** Explicit file list. If set, takes precedence over ciMode. Paths may be relative. */
  files?: string[];
}

export interface ScanStats {
  totalFilesChecked: number;
  totalStringsExtracted: number;
  totalStringsIgnored: number;
}

export interface ScanResult {
  /** Every string that survived ignore/dynamic-control filters. */
  extractedStrings: Set<string>;
  /** One entry per extracted string that's missing from the EN JSON. */
  violations: Violation[];
  /**
   * For each missing string value, the route it should be written to.
   * Keyed by the original extracted string value (matches violation.string).
   */
  classifiedMissing: Map<string, 'menus' | 'notMenus'>;
  translations: CombinedTranslations;
  stats: ScanStats;
}

/** Async existence check. */
async function fileExists(filePath: string): Promise<boolean> {
  try {
    await fs.access(filePath);
    return true;
  } catch {
    return false;
  }
}

/**
 * Recursively finds all .vb files in a directory using async I/O.
 * Breadth-first batched traversal for speed on large trees.
 */
async function findVBNetFiles(dir: string): Promise<string[]> {
  const files: string[] = [];
  const dirsToProcess: string[] = [dir];
  const skipDirs = new Set(['node_modules', 'bin', 'obj', '.git']);

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
              if (!skipDirs.has(entry.name)) {
                localDirs.push(fullPath);
              }
            } else if (entry.isFile() && entry.name.toLowerCase().endsWith('.vb')) {
              localFiles.push(fullPath);
            }
          }
        } catch {
          // Skip unreadable dirs silently.
        }

        return { files: localFiles, dirs: localDirs };
      })
    );

    for (const result of batchResults) {
      files.push(...result.files);
      dirsToProcess.push(...result.dirs);
    }
  }

  return files;
}

/** Resolves the list of VB files to scan based on options. */
async function resolveFilesToScan(baseDir: string, opts: ScanOptions): Promise<string[]> {
  if (opts.files && opts.files.length > 0) {
    return opts.files.map(f => resolveFilePath(f, baseDir));
  }

  if (opts.ciMode) {
    const result = getChangedVBNetFiles(baseDir);
    if (result.error) {
      console.warn(`Warning: ${result.error}`);
      console.warn('Falling back to checking all files...');
    } else if (result.files.length > 0) {
      if (opts.verbose) {
        console.log(`CI mode: checking ${result.files.length} changed files (base: ${result.baseBranch})`);
      }
      return result.files.map(f => resolveFilePath(f, baseDir));
    } else {
      if (opts.verbose) {
        console.log('CI mode: no VB.NET files changed');
      }
      return [];
    }
  }

  return findVBNetFiles(path.join(baseDir, 'instat'));
}

/**
 * Runs the full scan pipeline and returns structured results.
 * Pure — no writes, no process.exit.
 */
export async function runScan(baseDir: string, opts: ScanOptions = {}): Promise<ScanResult> {
  const violations: Violation[] = [];
  const extractedStrings = new Set<string>();
  const classifiedMissing = new Map<string, 'menus' | 'notMenus'>();
  let totalFilesChecked = 0;
  let totalStringsExtracted = 0;
  let totalStringsIgnored = 0;

  const [ignorePatterns, translations] = await Promise.all([
    loadTranslateIgnore(baseDir),
    loadEnglishTranslations(baseDir)
  ]);

  if (opts.verbose) {
    console.log(`Loaded ${ignorePatterns.patterns.length} ignore patterns`);
    console.log(`Loaded ${translations.allKeys.size} translation keys`);
  }

  const files = await resolveFilesToScan(baseDir, opts);

  if (files.length === 0) {
    return {
      violations,
      extractedStrings,
      classifiedMissing,
      translations,
      stats: { totalFilesChecked, totalStringsExtracted, totalStringsIgnored }
    };
  }

  // Lazy-load pattern-matcher to avoid circular types; shouldIgnore imported inline.
  const { shouldIgnore } = await import('./pattern-matcher.js');

  const BATCH_SIZE = 20;

  for (let i = 0; i < files.length; i += BATCH_SIZE) {
    const batch = files.slice(i, i + BATCH_SIZE);

    const parseResults = await Promise.all(
      batch.map(async (filePath) => {
        if (!(await fileExists(filePath))) {
          if (opts.verbose) {
            console.log(`Skipping non-existent file: ${filePath}`);
          }
          return null;
        }
        return parseVBNetFile(filePath);
      })
    );

    for (const parseResult of parseResults) {
      if (!parseResult) continue;

      totalFilesChecked++;

      if (parseResult.errors.length > 0 && opts.verbose) {
        for (const error of parseResult.errors) {
          console.warn(`Warning: ${error}`);
        }
      }

      const filteredStrings = filterStrings(parseResult.strings, {
        minLength: 2,
        excludeEmpty: true,
        excludeWhitespaceOnly: true,
        excludeNumericOnly: true,
        excludePunctuationOnly: true
      });

      totalStringsExtracted += filteredStrings.length;

      for (const extracted of filteredStrings) {
        const controlInfo = inferFullControlName(parseResult.filePath, extracted.rawLine);
        const fullPattern = controlInfo.fullPattern;
        let patternMatch = null;

        if (fullPattern) {
          patternMatch = shouldIgnore(fullPattern, ignorePatterns);
          if (patternMatch.shouldIgnore) {
            totalStringsIgnored++;
            if (opts.verbose) {
              console.log(`Ignored: "${extracted.value}" (pattern: ${patternMatch.matchedPattern?.pattern})`);
            }
            continue;
          }
        }

        if (extracted.controlName && isDynamicControl(extracted.controlName)) {
          totalStringsIgnored++;
          if (opts.verbose) {
            console.log(`Ignored (dynamic control): "${extracted.value}" (${extracted.controlName})`);
          }
          continue;
        }

        extractedStrings.add(extracted.value);

        const translationCheck = checkStringInTranslations(extracted.value, translations);

        if (!translationCheck.found) {
          const violation = createViolation(
            extracted,
            parseResult.filePath,
            controlInfo,
            patternMatch,
            translationCheck
          );
          violations.push(violation);

          // Classify route for sync. First occurrence wins — menu controls
          // are distinct from non-menu ones in this codebase, so collisions
          // across files for the same string are rare and non-contentious.
          if (!classifiedMissing.has(extracted.value)) {
            classifiedMissing.set(extracted.value, classifyRoute(extracted.controlName));
          }
        }
      }
    }
  }

  return {
    violations,
    extractedStrings,
    classifiedMissing,
    translations,
    stats: { totalFilesChecked, totalStringsExtracted, totalStringsIgnored }
  };
}
