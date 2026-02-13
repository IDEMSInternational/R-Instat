/**
 * Reporter Module
 * 
 * Provides output formatting for translation check results.
 * Supports multiple output formats: JSON, console, and GitHub annotations.
 */

import * as fs from 'fs';
import { ExtractedString } from './vbnet-parser.js';
import { TranslationCheckResult } from './translation-checker.js';
import { InferredControlName } from './control-name-inference.js';
import { Pattern } from './pattern-matcher.js';

/** A single violation (missing translation) */
export interface Violation {
  filePath: string;
  lineNumber: number;
  string: string;
  controlName: string | null;
  fullControlPattern: string | null;
  patternMatch: {
    shouldIgnore: boolean;
    matchedPattern: string | null;
    matchedNegation: string | null;
  } | null;
  translationCheck: TranslationCheckResult;
}

/** Orphan analysis result */
export interface OrphanAnalysis {
  orphanMenus: string[];
  orphanNotMenus: string[];
  total: number;
}

/** Summary of the translation check */
export interface CheckSummary {
  totalFilesChecked: number;
  totalStringsExtracted: number;
  totalStringsIgnored: number;
  totalMissingTranslations: number;
  totalTranslationKeys: number;
  totalOrphanTranslations: number;
  violations: Violation[];
  orphanAnalysis: OrphanAnalysis | null;
  timestamp: string;
  ciMode: boolean;
}

/** Report output options */
export interface ReportOptions {
  format: 'json' | 'console' | 'github';
  verbose?: boolean;
  showIgnored?: boolean;
}

/**
 * Formats a violation for console output.
 */
function formatViolationConsole(violation: Violation, verbose: boolean): string {
  const location = `${violation.filePath}:${violation.lineNumber}`;
  const stringPreview = violation.string.length > 50 
    ? violation.string.substring(0, 50) + '...'
    : violation.string;
  
  let output = `  ${location}\n`;
  output += `    String: "${stringPreview}"\n`;
  
  if (violation.controlName) {
    output += `    Control: ${violation.controlName}\n`;
  }
  
  if (verbose && violation.fullControlPattern) {
    output += `    Pattern: ${violation.fullControlPattern}\n`;
  }

  return output;
}

/**
 * Formats a GitHub annotation for a violation.
 * Uses GitHub Actions workflow command syntax.
 * 
 * @see https://docs.github.com/en/actions/using-workflows/workflow-commands-for-github-actions
 */
function formatViolationGitHub(violation: Violation): string {
  const file = violation.filePath;
  const line = violation.lineNumber;
  const stringPreview = violation.string.length > 80
    ? violation.string.substring(0, 80) + '...'
    : violation.string;
  
  const message = `Missing translation: "${stringPreview}"`;
  
  // GitHub annotation format: ::warning file={name},line={line}::{message}
  return `::warning file=${file},line=${line}::${message}`;
}

/**
 * Generates a report in the specified format.
 * 
 * @param summary - Check summary
 * @param options - Report options
 * @returns Formatted report string
 */
export function generateReport(summary: CheckSummary, options: ReportOptions): string {
  const { format, verbose = false, showIgnored = false } = options;

  switch (format) {
    case 'json':
      return JSON.stringify(summary, null, 2);

    case 'github':
      return generateGitHubReport(summary);

    case 'console':
    default:
      return generateConsoleReport(summary, verbose, showIgnored);
  }
}

/**
 * Generates a console-friendly report.
 */
function generateConsoleReport(summary: CheckSummary, verbose: boolean, showIgnored: boolean): string {
  const lines: string[] = [];

  lines.push('╔═══════════════════════════════════════════════════════════════╗');
  lines.push('║            Translation Check Report                           ║');
  lines.push('╚═══════════════════════════════════════════════════════════════╝');
  lines.push('');

  // Statistics
  lines.push('📊 Statistics:');
  lines.push(`   Files checked:         ${summary.totalFilesChecked}`);
  lines.push(`   Strings extracted:     ${summary.totalStringsExtracted}`);
  lines.push(`   Strings ignored:       ${summary.totalStringsIgnored}`);
  lines.push(`   Missing translations:  ${summary.totalMissingTranslations}`);
  lines.push('');

  // Violations
  if (summary.violations.length > 0) {
    lines.push('❌ Missing Translations:');
    lines.push('');

    for (const violation of summary.violations) {
      lines.push(formatViolationConsole(violation, verbose));
    }
  } else {
    lines.push('✅ No missing translations found!');
  }

  lines.push('');
  lines.push(`Report generated: ${summary.timestamp}`);
  lines.push(summary.ciMode ? '(CI mode)' : '(Local mode)');

  return lines.join('\n');
}

/**
 * Generates a GitHub Actions-friendly report with annotations.
 */
function generateGitHubReport(summary: CheckSummary): string {
  const lines: string[] = [];

  // GitHub step summary (markdown)
  lines.push('## Translation Check Results');
  lines.push('');
  lines.push('| Metric | Value |');
  lines.push('|--------|-------|');
  lines.push(`| Files checked | ${summary.totalFilesChecked} |`);
  lines.push(`| Strings extracted | ${summary.totalStringsExtracted} |`);
  lines.push(`| Strings ignored | ${summary.totalStringsIgnored} |`);
  lines.push(`| **Missing translations** | **${summary.totalMissingTranslations}** |`);
  lines.push('');

  if (summary.violations.length > 0) {
    lines.push('### Missing Translations');
    lines.push('');
    lines.push('| File | Line | String |');
    lines.push('|------|------|--------|');

    for (const violation of summary.violations.slice(0, 20)) { // Limit to 20 for readability
      const stringPreview = violation.string.length > 40
        ? violation.string.substring(0, 40) + '...'
        : violation.string;
      lines.push(`| \`${violation.filePath}\` | ${violation.lineNumber} | "${stringPreview}" |`);
    }

    if (summary.violations.length > 20) {
      lines.push(`| ... | ... | ... (${summary.violations.length - 20} more) |`);
    }

    lines.push('');
    lines.push('---');
    lines.push('');

    // GitHub annotations
    for (const violation of summary.violations) {
      lines.push(formatViolationGitHub(violation));
    }
  } else {
    lines.push('✅ **No missing translations found!**');
  }

  return lines.join('\n');
}

/**
 * Creates a violation object from extracted data.
 */
export function createViolation(
  extracted: ExtractedString,
  filePath: string,
  controlInfo: InferredControlName | null,
  patternMatch: { shouldIgnore: boolean; matchedPattern: Pattern | null; matchedNegation: Pattern | null } | null,
  translationCheck: TranslationCheckResult
): Violation {
  return {
    filePath,
    lineNumber: extracted.lineNumber,
    string: extracted.value,
    controlName: extracted.controlName,
    fullControlPattern: controlInfo?.fullPattern || null,
    patternMatch: patternMatch ? {
      shouldIgnore: patternMatch.shouldIgnore,
      matchedPattern: patternMatch.matchedPattern?.pattern || null,
      matchedNegation: patternMatch.matchedNegation?.pattern || null
    } : null,
    translationCheck
  };
}

/**
 * Creates a summary object from check results.
 */
export function createSummary(
  violations: Violation[],
  stats: {
    totalFilesChecked: number;
    totalStringsExtracted: number;
    totalStringsIgnored: number;
  },
  ciMode: boolean,
  orphanAnalysis: OrphanAnalysis | null = null,
  totalTranslationKeys: number = 0
): CheckSummary {
  return {
    totalFilesChecked: stats.totalFilesChecked,
    totalStringsExtracted: stats.totalStringsExtracted,
    totalStringsIgnored: stats.totalStringsIgnored,
    totalMissingTranslations: violations.length,
    totalTranslationKeys,
    totalOrphanTranslations: orphanAnalysis?.total || 0,
    violations,
    orphanAnalysis,
    timestamp: new Date().toISOString(),
    ciMode
  };
}

/**
 * Prints a report to stdout.
 */
export function printReport(summary: CheckSummary, options: ReportOptions): void {
  const report = generateReport(summary, options);
  console.log(report);
}

/**
 * Writes the full report to a JSON file.
 * 
 * @param summary - Check summary
 * @param outputPath - Path to write the report
 */
export function writeReportToFile(summary: CheckSummary, outputPath: string): void {
  const content = JSON.stringify(summary, null, 2);
  fs.writeFileSync(outputPath, content, 'utf-8');
}

/**
 * Generates a brief summary for console output (no violation details).
 */
export function generateConsoleSummary(summary: CheckSummary, reportPath: string): string {
  const lines: string[] = [];

  lines.push('╔═══════════════════════════════════════════════════════════════╗');
  lines.push('║            Translation Check Summary                          ║');
  lines.push('╚═══════════════════════════════════════════════════════════════╝');
  lines.push('');
  lines.push('📊 Extraction Statistics:');
  lines.push(`   Files checked:         ${summary.totalFilesChecked}`);
  lines.push(`   Strings extracted:     ${summary.totalStringsExtracted}`);
  lines.push(`   Strings ignored:       ${summary.totalStringsIgnored}`);
  lines.push('');

  lines.push('📊 Translation Coverage:');
  lines.push(`   Translation keys:      ${summary.totalTranslationKeys}`);
  lines.push(`   Missing in JSON:       ${summary.totalMissingTranslations} (code → JSON)`);
  lines.push(`   Orphan translations:   ${summary.totalOrphanTranslations} (JSON → code)`);
  lines.push('');

  // Missing translations (code has strings not in JSON)
  if (summary.violations.length > 0) {
    lines.push(`❌ Found ${summary.violations.length} strings in code missing from translations.`);
  } else {
    lines.push('✅ All extracted strings exist in translation files!');
  }

  // Orphan translations (JSON has strings not in code)
  if (summary.totalOrphanTranslations > 0) {
    lines.push(`⚠️  Found ${summary.totalOrphanTranslations} translations not found in extracted code.`);
    lines.push('   (Could be orphaned or not captured by static analysis)');
  }

  lines.push('');
  lines.push(`📄 Full report written to: ${reportPath}`);
  lines.push('');
  lines.push(`Report generated: ${summary.timestamp}`);
  lines.push(summary.ciMode ? '(CI mode)' : '(Local mode)');

  return lines.join('\n');
}
