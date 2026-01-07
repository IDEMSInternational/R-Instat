#!/usr/bin/env node
/**
 * Translation Check - Main Entry Point
 * 
 * Static analysis tool to detect missing translations in R-Instat VB.NET codebase.
 * Composes all modules together with a CLI interface.
 * 
 * Usage:
 *   npm run check-translations              # Check all VB.NET files
 *   npm run check-translations:ci           # Check only changed files (CI mode)
 *   npm run check-translations:verbose      # Verbose output
 * 
 * Options:
 *   --ci          CI mode: only check changed files, use GitHub-friendly output
 *   --verbose     Show detailed information including pattern matches
 *   --json        Output as JSON
 *   --help        Show help
 */

import * as fs from 'fs';
import * as path from 'path';

// Import library modules
import { loadTranslateIgnore, shouldIgnore, PatternFile } from './lib/pattern-matcher.js';
import { inferFullControlName, isFormFile, isDesignerFile, isDynamicControl } from './lib/control-name-inference.js';
import { parseVBNetFile, filterStrings, ExtractedString } from './lib/vbnet-parser.js';
import { loadEnglishTranslations, checkStringInTranslations, CombinedTranslations } from './lib/translation-checker.js';
import { createViolation, createSummary, generateReport, writeReportToFile, generateConsoleSummary, Violation, ReportOptions, OrphanAnalysis } from './lib/reporter.js';
import { getChangedVBNetFiles, isCI, resolveFilePath } from './lib/git-utils.js';

/** CLI options */
interface CliOptions {
  ciMode: boolean;
  verbose: boolean;
  jsonOutput: boolean;
  help: boolean;
  files: string[];
}

/**
 * Parses command-line arguments.
 */
function parseArgs(args: string[]): CliOptions {
  const options: CliOptions = {
    ciMode: false,
    verbose: false,
    jsonOutput: false,
    help: false,
    files: []
  };

  for (const arg of args) {
    switch (arg) {
      case '--ci':
        options.ciMode = true;
        break;
      case '--verbose':
      case '-v':
        options.verbose = true;
        break;
      case '--json':
        options.jsonOutput = true;
        break;
      case '--help':
      case '-h':
        options.help = true;
        break;
      default:
        if (!arg.startsWith('-')) {
          options.files.push(arg);
        }
        break;
    }
  }

  // Auto-detect CI mode
  if (isCI()) {
    options.ciMode = true;
  }

  return options;
}

/**
 * Prints help message.
 */
function printHelp(): void {
  console.log(`
Translation Check - Static analysis for missing translations

Usage:
  npx ts-node check-translations.ts [options] [files...]

Options:
  --ci          CI mode: only check changed files, use GitHub-friendly output
  --verbose     Show detailed information including pattern matches
  --json        Output as JSON
  --help        Show this help message

Examples:
  npx ts-node check-translations.ts                    # Check all VB.NET files
  npx ts-node check-translations.ts --ci               # CI mode
  npx ts-node check-translations.ts instat/dlgOptions.vb  # Check specific file
`);
}

/**
 * Gets VB.NET files to check.
 */
function getFilesToCheck(baseDir: string, options: CliOptions): string[] {
  // If specific files provided, use those
  if (options.files.length > 0) {
    return options.files.map(f => resolveFilePath(f, baseDir));
  }

  // CI mode: get changed files
  if (options.ciMode) {
    const result = getChangedVBNetFiles(baseDir);
    if (result.error) {
      console.warn(`Warning: ${result.error}`);
      console.warn('Falling back to checking all files...');
    } else if (result.files.length > 0) {
      console.log(`CI mode: checking ${result.files.length} changed files (base: ${result.baseBranch})`);
      return result.files.map(f => resolveFilePath(f, baseDir));
    } else {
      console.log('CI mode: no VB.NET files changed');
      return [];
    }
  }

  // Default: find all VB.NET files in instat directory
  const instatDir = path.join(baseDir, 'instat');
  return findVBNetFiles(instatDir);
}

/**
 * Recursively finds all VB.NET files in a directory.
 */
function findVBNetFiles(dir: string): string[] {
  const files: string[] = [];

  if (!fs.existsSync(dir)) {
    return files;
  }

  const entries = fs.readdirSync(dir, { withFileTypes: true });

  for (const entry of entries) {
    const fullPath = path.join(dir, entry.name);

    if (entry.isDirectory()) {
      // Skip node_modules and other non-relevant directories
      if (entry.name !== 'node_modules' && entry.name !== 'bin' && entry.name !== 'obj') {
        files.push(...findVBNetFiles(fullPath));
      }
    } else if (entry.isFile() && entry.name.toLowerCase().endsWith('.vb')) {
      files.push(fullPath);
    }
  }

  return files;
}

/** Result of the check including orphan analysis */
interface CheckResult {
  violations: Violation[];
  stats: {
    totalFilesChecked: number;
    totalStringsExtracted: number;
    totalStringsIgnored: number;
  };
  extractedStrings: Set<string>;
  translations: CombinedTranslations;
}

/**
 * Main check function.
 */
function runCheck(baseDir: string, options: CliOptions): CheckResult {
  const violations: Violation[] = [];
  const extractedStrings = new Set<string>();
  let totalFilesChecked = 0;
  let totalStringsExtracted = 0;
  let totalStringsIgnored = 0;

  // Load patterns and translations
  const ignorePatterns = loadTranslateIgnore(baseDir);
  const translations = loadEnglishTranslations(baseDir);

  if (options.verbose) {
    console.log(`Loaded ${ignorePatterns.patterns.length} ignore patterns`);
    console.log(`Loaded ${translations.allKeys.size} translation keys`);
  }

  // Get files to check
  const files = getFilesToCheck(baseDir, options);

  if (files.length === 0) {
    if (options.verbose) {
      console.log('No files to check');
    }
    return { 
      violations, 
      stats: { totalFilesChecked, totalStringsExtracted, totalStringsIgnored },
      extractedStrings,
      translations
    };
  }

  // Process each file
  for (const filePath of files) {
    if (!fs.existsSync(filePath)) {
      if (options.verbose) {
        console.log(`Skipping non-existent file: ${filePath}`);
      }
      continue;
    }

    // Parse the file
    const parseResult = parseVBNetFile(filePath);
    totalFilesChecked++;

    if (parseResult.errors.length > 0 && options.verbose) {
      for (const error of parseResult.errors) {
        console.warn(`Warning: ${error}`);
      }
    }

    // Filter strings
    const filteredStrings = filterStrings(parseResult.strings, {
      minLength: 2,
      excludeEmpty: true,
      excludeWhitespaceOnly: true,
      excludeNumericOnly: true,
      excludePunctuationOnly: true
    });

    totalStringsExtracted += filteredStrings.length;

    // Check each string
    for (const extracted of filteredStrings) {
      // Track all extracted strings (before any filtering)
      extractedStrings.add(extracted.value);

      // Infer control name
      const controlInfo = inferFullControlName(filePath, extracted.rawLine);

      // Check if control should be ignored based on patterns
      const fullPattern = controlInfo.fullPattern;
      let patternMatch = null;

      if (fullPattern) {
        patternMatch = shouldIgnore(fullPattern, ignorePatterns);
        
        if (patternMatch.shouldIgnore) {
          totalStringsIgnored++;
          if (options.verbose) {
            console.log(`Ignored: "${extracted.value}" (pattern: ${patternMatch.matchedPattern?.pattern})`);
          }
          continue;
        }
      }

      // Check if control is a dynamic control type (ucrInput, ucrCheck)
      if (extracted.controlName && isDynamicControl(extracted.controlName)) {
        totalStringsIgnored++;
        if (options.verbose) {
          console.log(`Ignored (dynamic control): "${extracted.value}" (${extracted.controlName})`);
        }
        continue;
      }

      // Check if string exists in translations
      const translationCheck = checkStringInTranslations(extracted.value, translations);

      if (!translationCheck.found) {
        // Missing translation - create violation
        const violation = createViolation(
          extracted,
          filePath,
          controlInfo,
          patternMatch,
          translationCheck
        );
        violations.push(violation);
      }
    }
  }

  return {
    violations,
    stats: {
      totalFilesChecked,
      totalStringsExtracted,
      totalStringsIgnored
    },
    extractedStrings,
    translations
  };
}

/**
 * Finds translations that exist in JSON but were not extracted from code.
 * These could be orphaned translations or strings not captured by static analysis.
 */
function findOrphanTranslations(
  extractedStrings: Set<string>,
  translations: CombinedTranslations
): { orphanMenus: string[]; orphanNotMenus: string[]; total: number } {
  const orphanMenus: string[] = [];
  const orphanNotMenus: string[] = [];

  // Check menus JSON
  for (const key of Object.keys(translations.menus.translations)) {
    if (!extractedStrings.has(key)) {
      orphanMenus.push(key);
    }
  }

  // Check not_menus JSON
  for (const key of Object.keys(translations.notMenus.translations)) {
    if (!extractedStrings.has(key)) {
      orphanNotMenus.push(key);
    }
  }

  return {
    orphanMenus,
    orphanNotMenus,
    total: orphanMenus.length + orphanNotMenus.length
  };
}

/**
 * Main entry point.
 */
async function main(): Promise<void> {
  const args = process.argv.slice(2);
  const options = parseArgs(args);

  if (options.help) {
    printHelp();
    process.exit(0);
  }

  // Determine base directory (project root)
  // If running from scripts/, go up one level. Otherwise use cwd.
  let baseDir = process.cwd();
  if (baseDir.endsWith('scripts')) {
    baseDir = path.dirname(baseDir);
  }
  // Also check if we're in the dist folder
  if (baseDir.endsWith('dist')) {
    baseDir = path.dirname(path.dirname(baseDir));
  }

  if (options.verbose) {
    console.log(`Base directory: ${baseDir}`);
    console.log(`CI mode: ${options.ciMode}`);
  }

  // Run the check
  const { violations, stats, extractedStrings, translations } = runCheck(baseDir, options);

  // Find orphan translations (in JSON but not extracted from code)
  const orphanAnalysis = findOrphanTranslations(extractedStrings, translations);
  const totalTranslationKeys = translations.allKeys.size;

  // Create summary
  const summary = createSummary(violations, stats, options.ciMode, orphanAnalysis, totalTranslationKeys);

  // Write full report to JSON file
  const reportPath = path.join(baseDir, 'scripts', 'translation-report.json');
  writeReportToFile(summary, reportPath);

  // Print output based on mode
  if (options.jsonOutput) {
    // If JSON output explicitly requested, print full JSON to stdout
    console.log(JSON.stringify(summary, null, 2));
  } else if (options.ciMode) {
    // CI mode: use GitHub format with annotations
    const reportOptions: ReportOptions = {
      format: 'github',
      verbose: options.verbose
    };
    console.log(generateReport(summary, reportOptions));
  } else {
    // Local mode: just show summary, full report is in the file
    console.log(generateConsoleSummary(summary, reportPath));
  }

  // Exit with appropriate code
  // In CI mode, we don't fail - we just report and let the review request handle it
  if (!options.ciMode && violations.length > 0) {
    process.exit(1);
  }

  process.exit(0);
}

// Run main
main().catch(error => {
  console.error('Error:', error);
  process.exit(1);
});
