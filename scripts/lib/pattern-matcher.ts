/**
 * Pattern Matcher Module
 * 
 * Provides SQLite-like LIKE pattern matching for control names.
 * Reuses the existing translateIgnore.txt and translateDynamic.txt file formats.
 * 
 * Pattern syntax (SQLite LIKE):
 * - `%` matches any sequence of characters (including empty)
 * - `_` matches any single character (but we escape it with `\_` for literal underscore)
 * - `\_` is an escaped underscore (literal match)
 * - `!` at start of line negates the pattern
 * - `#` at start of line is a comment
 * - Blank lines are ignored
 */

import * as fs from 'fs';
import * as path from 'path';

/** Represents a pattern with its negation status */
export interface Pattern {
  pattern: string;
  isNegation: boolean;
  originalLine: string;
}

/** Result of loading patterns from a file */
export interface PatternFile {
  patterns: Pattern[];
  negations: Pattern[];
  filePath: string;
}

/**
 * Loads patterns from a translateIgnore.txt or translateDynamic.txt file.
 * Parses comments, blank lines, and negation patterns.
 * 
 * @param filePath - Path to the pattern file
 * @returns Parsed patterns and negations
 */
export function loadPatterns(filePath: string): PatternFile {
  const patterns: Pattern[] = [];
  const negations: Pattern[] = [];

  if (!fs.existsSync(filePath)) {
    return { patterns, negations, filePath };
  }

  const content = fs.readFileSync(filePath, 'utf-8');
  const lines = content.split(/\r?\n/);

  for (const line of lines) {
    const trimmed = line.trim();

    // Skip empty lines
    if (trimmed === '') {
      continue;
    }

    // Skip comments
    if (trimmed.startsWith('#')) {
      continue;
    }

    // Check for negation
    if (trimmed.startsWith('!')) {
      const pattern = trimmed.substring(1); // Remove leading '!'
      negations.push({
        pattern,
        isNegation: true,
        originalLine: line
      });
    } else {
      patterns.push({
        pattern: trimmed,
        isNegation: false,
        originalLine: line
      });
    }
  }

  return { patterns, negations, filePath };
}

/**
 * Converts a SQLite LIKE pattern to a JavaScript RegExp.
 * 
 * SQLite LIKE syntax:
 * - `%` matches any sequence of characters
 * - `_` matches any single character
 * - `\_` is an escaped underscore (literal underscore)
 * 
 * @param pattern - SQLite LIKE pattern
 * @returns RegExp for matching
 */
export function patternToRegex(pattern: string): RegExp {
  // First, escape all regex special characters except our LIKE wildcards
  let regex = '';
  let i = 0;
  
  while (i < pattern.length) {
    const char = pattern[i];
    const nextChar = pattern[i + 1];

    if (char === '\\' && nextChar === '_') {
      // Escaped underscore - literal underscore
      regex += '_';
      i += 2;
    } else if (char === '%') {
      // Percent matches any sequence
      regex += '.*';
      i += 1;
    } else if (char === '_') {
      // Unescaped underscore matches single character
      regex += '.';
      i += 1;
    } else if (/[.*+?^${}()|[\]\\]/.test(char)) {
      // Escape regex special characters
      regex += '\\' + char;
      i += 1;
    } else {
      regex += char;
      i += 1;
    }
  }

  return new RegExp(`^${regex}$`, 'i'); // Case-insensitive, full match
}

/**
 * Checks if a control name matches a pattern.
 * 
 * @param controlName - The control name to check
 * @param pattern - The pattern to match against
 * @returns true if the control name matches the pattern
 */
export function matchesPattern(controlName: string, pattern: string): boolean {
  const regex = patternToRegex(pattern);
  return regex.test(controlName);
}

/**
 * Checks if a control name matches any of the patterns.
 * 
 * @param controlName - The control name to check
 * @param patterns - Array of patterns to check against
 * @returns The first matching pattern, or null if no match
 */
export function findMatchingPattern(controlName: string, patterns: Pattern[]): Pattern | null {
  for (const pattern of patterns) {
    if (matchesPattern(controlName, pattern.pattern)) {
      return pattern;
    }
  }
  return null;
}

/**
 * Determines if a control should be ignored based on patterns and negations.
 * 
 * Logic:
 * 1. Check if control matches any ignore pattern
 * 2. If it matches, check if it also matches any negation pattern
 * 3. If it matches a negation, it should NOT be ignored (negation cancels the ignore)
 * 
 * @param controlName - The control name to check
 * @param patternFile - Loaded patterns and negations
 * @returns Object with shouldIgnore flag and matched patterns
 */
export function shouldIgnore(
  controlName: string,
  patternFile: PatternFile
): { shouldIgnore: boolean; matchedPattern: Pattern | null; matchedNegation: Pattern | null } {
  // Check if it matches any pattern
  const matchedPattern = findMatchingPattern(controlName, patternFile.patterns);
  
  if (!matchedPattern) {
    // No pattern match - should not ignore
    return { shouldIgnore: false, matchedPattern: null, matchedNegation: null };
  }

  // Check if it matches any negation
  const matchedNegation = findMatchingPattern(controlName, patternFile.negations);
  
  if (matchedNegation) {
    // Negation cancels the ignore
    return { shouldIgnore: false, matchedPattern, matchedNegation };
  }

  // Pattern matched, no negation - should ignore
  return { shouldIgnore: true, matchedPattern, matchedNegation: null };
}

/**
 * Loads the default translateIgnore.txt file from the translations folder.
 * 
 * @param baseDir - Base directory of the R-Instat project
 * @returns Loaded pattern file
 */
export function loadTranslateIgnore(baseDir: string): PatternFile {
  const filePath = path.join(baseDir, 'instat', 'translations', 'translateIgnore.txt');
  return loadPatterns(filePath);
}

/**
 * Loads the default translateDynamic.txt file from the translations folder.
 * 
 * @param baseDir - Base directory of the R-Instat project
 * @returns Loaded pattern file
 */
export function loadTranslateDynamic(baseDir: string): PatternFile {
  const filePath = path.join(baseDir, 'instat', 'translations', 'translateDynamic.txt');
  return loadPatterns(filePath);
}
