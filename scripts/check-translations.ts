#!/usr/bin/env node
/**
 * Translation Check - Main Entry Point
 *
 * Static analysis tool that detects missing translations in the R-Instat
 * VB.NET codebase. Read-only: reports drift and exits non-zero when any
 * strings in code are missing from the EN JSON files.
 *
 * Usage:
 *   npm run check-translations              # Check all VB.NET files, exit 1 if any missing
 *   npm run check-translations:ci           # Check only changed files, GitHub annotations
 *   npm run check-translations:verbose      # Verbose output
 *
 * Options:
 *   --ci          CI mode: only check changed files, use GitHub-friendly output
 *   --verbose     Show detailed information including pattern matches
 *   --json        Output as JSON
 *   --help        Show help
 *
 * To resolve missing translations locally: npm run sync-translations
 */

import * as path from 'path';

import { getProjectRoot } from './lib/project-root.js';
import { isCI } from './lib/git-utils.js';
import { runScan } from './lib/scan.js';
import { findOrphans } from './lib/orphan-finder.js';
import {
  createSummary,
  generateReport,
  writeReportToFile,
  generateConsoleSummary,
  ReportOptions
} from './lib/reporter.js';

interface CliOptions {
  ciMode: boolean;
  verbose: boolean;
  jsonOutput: boolean;
  help: boolean;
  files: string[];
}

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

  if (isCI()) {
    options.ciMode = true;
  }

  return options;
}

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

Exits non-zero if any strings are missing from the EN JSON files.
Run \`npm run sync-translations\` locally to append missing strings.
`);
}

async function main(): Promise<void> {
  const args = process.argv.slice(2);
  const options = parseArgs(args);

  if (options.help) {
    printHelp();
    process.exit(0);
  }

  let baseDir: string;
  try {
    baseDir = await getProjectRoot();
  } catch (error) {
    console.error((error as Error).message);
    process.exit(1);
  }

  if (options.verbose) {
    console.log(`Base directory: ${baseDir}`);
    console.log(`CI mode: ${options.ciMode}`);
  }

  const { violations, stats, extractedStrings, translations } = await runScan(baseDir, {
    ciMode: options.ciMode,
    verbose: options.verbose,
    files: options.files
  });

  const orphanAnalysis = findOrphans(extractedStrings, translations);
  const totalTranslationKeys = translations.allKeys.size;

  const summary = createSummary(
    violations,
    stats,
    options.ciMode,
    orphanAnalysis,
    totalTranslationKeys
  );

  const reportPath = path.join(baseDir, 'scripts', 'translation-report.json');
  writeReportToFile(summary, reportPath);

  if (options.jsonOutput) {
    console.log(JSON.stringify(summary, null, 2));
  } else if (options.ciMode) {
    const reportOptions: ReportOptions = { format: 'github', verbose: options.verbose };
    console.log(generateReport(summary, reportOptions));
  } else {
    console.log(generateConsoleSummary(summary, reportPath));
    if (violations.length > 0) {
      console.log('');
      console.log('To append missing strings to the EN JSON files, run:');
      console.log('  npm run sync-translations');
    }
  }

  // Unified behavior: fail on any missing translation, local or CI.
  // Dev workflow: run `npm run sync-translations` to resolve, then re-run.
  if (violations.length > 0) {
    process.exit(1);
  }

  process.exit(0);
}

main().catch(error => {
  console.error('Error:', error);
  process.exit(1);
});
