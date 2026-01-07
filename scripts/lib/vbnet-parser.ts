/**
 * VB.NET Parser Module
 * 
 * Provides regex-based string extraction from VB.NET files.
 * Handles line continuation and various string assignment patterns.
 * Returns structured data that can be reused for other VB.NET static analysis.
 */

import * as fs from 'fs';

/** Represents an extracted string from VB.NET code */
export interface ExtractedString {
  value: string;
  lineNumber: number;
  columnStart: number;
  columnEnd: number;
  pattern: StringPattern;
  controlName: string | null;
  rawLine: string;
}

/** Types of string patterns we look for */
export type StringPattern = 
  | 'Text'           // .Text = "..."
  | 'ToolTipText'    // .ToolTipText = "..."
  | 'SetText'        // SetText("...")
  | 'SetLabel'       // SetLabel("...")
  | 'SetLabelText'   // SetLabelText("...")
  | 'MenuItem';      // Menu item .Text

/** Result of parsing a VB.NET file */
export interface ParseResult {
  filePath: string;
  strings: ExtractedString[];
  errors: string[];
}

/**
 * Joins VB.NET lines that use line continuation (`_` at end of line).
 * 
 * @param lines - Array of source lines
 * @returns Array of joined lines with original line numbers
 */
function joinContinuedLines(lines: string[]): Array<{ content: string; lineNumber: number }> {
  const result: Array<{ content: string; lineNumber: number }> = [];
  let current = '';
  let startLine = 1;

  for (let i = 0; i < lines.length; i++) {
    const line = lines[i];
    const trimmed = line.trimEnd();

    if (current === '') {
      startLine = i + 1;
    }

    // Check for line continuation
    if (trimmed.endsWith(' _') || trimmed.endsWith('\t_')) {
      // Remove the continuation character and add space
      current += trimmed.slice(0, -1) + ' ';
    } else {
      current += line;
      result.push({ content: current, lineNumber: startLine });
      current = '';
    }
  }

  // Handle any remaining content
  if (current !== '') {
    result.push({ content: current, lineNumber: startLine });
  }

  return result;
}

/**
 * Extracts VB.NET string literals from a line.
 * Handles both regular strings and escaped quotes ("").
 * 
 * @param line - Line of VB.NET code
 * @returns Extracted string value and position info
 */
function extractStringLiteral(line: string, startIndex: number): { value: string; endIndex: number } | null {
  // VB.NET strings use double quotes, with "" for escaped quotes
  if (line[startIndex] !== '"') {
    return null;
  }

  let value = '';
  let i = startIndex + 1;
  
  while (i < line.length) {
    if (line[i] === '"') {
      if (i + 1 < line.length && line[i + 1] === '"') {
        // Escaped quote
        value += '"';
        i += 2;
      } else {
        // End of string
        return { value, endIndex: i };
      }
    } else {
      value += line[i];
      i++;
    }
  }

  // Unclosed string
  return null;
}

/**
 * Extracts strings matching `.Text = "..."` pattern.
 */
function extractTextAssignments(line: string, lineNumber: number): ExtractedString[] {
  const results: ExtractedString[] = [];
  
  // Pattern: [Me.]controlName.Text = "..."
  const regex = /(?:Me\.)?(\w+)\.Text\s*=\s*"/gi;
  let match;

  while ((match = regex.exec(line)) !== null) {
    const controlName = match[1];
    const stringStart = match.index + match[0].length - 1; // Position of opening quote
    const extracted = extractStringLiteral(line, stringStart);
    
    if (extracted) {
      results.push({
        value: extracted.value,
        lineNumber,
        columnStart: stringStart,
        columnEnd: extracted.endIndex,
        pattern: 'Text',
        controlName,
        rawLine: line
      });
    }
  }

  return results;
}

/**
 * Extracts strings matching `.ToolTipText = "..."` pattern.
 */
function extractToolTipTextAssignments(line: string, lineNumber: number): ExtractedString[] {
  const results: ExtractedString[] = [];
  
  const regex = /(?:Me\.)?(\w+)\.ToolTipText\s*=\s*"/gi;
  let match;

  while ((match = regex.exec(line)) !== null) {
    const controlName = match[1];
    const stringStart = match.index + match[0].length - 1;
    const extracted = extractStringLiteral(line, stringStart);
    
    if (extracted) {
      results.push({
        value: extracted.value,
        lineNumber,
        columnStart: stringStart,
        columnEnd: extracted.endIndex,
        pattern: 'ToolTipText',
        controlName,
        rawLine: line
      });
    }
  }

  return results;
}

/**
 * Extracts strings matching `SetText("...")` pattern.
 */
function extractSetTextCalls(line: string, lineNumber: number): ExtractedString[] {
  const results: ExtractedString[] = [];
  
  // Pattern: [controlName.]SetText("...")
  const regex = /(\w+)\.SetText\s*\(\s*"/gi;
  let match;

  while ((match = regex.exec(line)) !== null) {
    const controlName = match[1];
    const stringStart = line.indexOf('"', match.index + match[0].length - 1);
    
    if (stringStart !== -1) {
      const extracted = extractStringLiteral(line, stringStart);
      
      if (extracted) {
        results.push({
          value: extracted.value,
          lineNumber,
          columnStart: stringStart,
          columnEnd: extracted.endIndex,
          pattern: 'SetText',
          controlName,
          rawLine: line
        });
      }
    }
  }

  return results;
}

/**
 * Extracts strings matching `SetLabel("...")` pattern.
 */
function extractSetLabelCalls(line: string, lineNumber: number): ExtractedString[] {
  const results: ExtractedString[] = [];
  
  const regex = /(\w+)\.SetLabel\s*\(\s*"/gi;
  let match;

  while ((match = regex.exec(line)) !== null) {
    const controlName = match[1];
    const stringStart = line.indexOf('"', match.index + match[0].length - 1);
    
    if (stringStart !== -1) {
      const extracted = extractStringLiteral(line, stringStart);
      
      if (extracted) {
        results.push({
          value: extracted.value,
          lineNumber,
          columnStart: stringStart,
          columnEnd: extracted.endIndex,
          pattern: 'SetLabel',
          controlName,
          rawLine: line
        });
      }
    }
  }

  return results;
}

/**
 * Extracts strings matching `SetLabelText("...")` pattern.
 */
function extractSetLabelTextCalls(line: string, lineNumber: number): ExtractedString[] {
  const results: ExtractedString[] = [];
  
  const regex = /(\w+)\.SetLabelText\s*\(\s*"/gi;
  let match;

  while ((match = regex.exec(line)) !== null) {
    const controlName = match[1];
    const stringStart = line.indexOf('"', match.index + match[0].length - 1);
    
    if (stringStart !== -1) {
      const extracted = extractStringLiteral(line, stringStart);
      
      if (extracted) {
        results.push({
          value: extracted.value,
          lineNumber,
          columnStart: stringStart,
          columnEnd: extracted.endIndex,
          pattern: 'SetLabelText',
          controlName,
          rawLine: line
        });
      }
    }
  }

  return results;
}

/**
 * Parses a VB.NET file and extracts all translatable strings.
 * 
 * @param filePath - Path to the VB.NET file
 * @returns Parse result with extracted strings and any errors
 */
export function parseVBNetFile(filePath: string): ParseResult {
  const strings: ExtractedString[] = [];
  const errors: string[] = [];

  try {
    const content = fs.readFileSync(filePath, 'utf-8');
    const lines = content.split(/\r?\n/);
    
    // Join continued lines
    const joinedLines = joinContinuedLines(lines);

    for (const { content: line, lineNumber } of joinedLines) {
      // Skip empty lines and comments
      const trimmed = line.trim();
      if (trimmed === '' || trimmed.startsWith("'")) {
        continue;
      }

      // Extract strings from various patterns
      strings.push(...extractTextAssignments(line, lineNumber));
      strings.push(...extractToolTipTextAssignments(line, lineNumber));
      strings.push(...extractSetTextCalls(line, lineNumber));
      strings.push(...extractSetLabelCalls(line, lineNumber));
      strings.push(...extractSetLabelTextCalls(line, lineNumber));
    }
  } catch (error) {
    errors.push(`Error reading file ${filePath}: ${error}`);
  }

  return { filePath, strings, errors };
}

/**
 * Parses multiple VB.NET files.
 * 
 * @param filePaths - Array of file paths to parse
 * @returns Array of parse results
 */
export function parseVBNetFiles(filePaths: string[]): ParseResult[] {
  return filePaths.map(parseVBNetFile);
}

/**
 * Filters extracted strings based on common exclusion criteria.
 * 
 * @param strings - Array of extracted strings
 * @param options - Filtering options
 * @returns Filtered strings
 */
export function filterStrings(
  strings: ExtractedString[],
  options: {
    minLength?: number;
    excludeEmpty?: boolean;
    excludeWhitespaceOnly?: boolean;
    excludeNumericOnly?: boolean;
    excludePunctuationOnly?: boolean;
  } = {}
): ExtractedString[] {
  const {
    minLength = 1,
    excludeEmpty = true,
    excludeWhitespaceOnly = true,
    excludeNumericOnly = true,
    excludePunctuationOnly = true
  } = options;

  return strings.filter(s => {
    const value = s.value;

    // Exclude empty strings
    if (excludeEmpty && value === '') {
      return false;
    }

    // Exclude whitespace-only strings
    if (excludeWhitespaceOnly && value.trim() === '') {
      return false;
    }

    // Exclude strings shorter than minLength
    if (value.length < minLength) {
      return false;
    }

    // Exclude numeric-only strings
    if (excludeNumericOnly && /^[\d.,\-+%]+$/.test(value.trim())) {
      return false;
    }

    // Exclude punctuation-only strings
    if (excludePunctuationOnly && /^[^\w\s]+$/.test(value)) {
      return false;
    }

    return true;
  });
}
