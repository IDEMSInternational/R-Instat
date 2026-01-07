/**
 * Translation Checker Module
 * 
 * Provides JSON translation file loading and string existence checking.
 * Loads and checks against the English translation JSON files.
 */

import * as fs from 'fs';
import * as path from 'path';

/** Represents loaded translation data */
export interface TranslationData {
  filePath: string;
  translations: Record<string, string>;
  loadError: string | null;
}

/** Result of checking a string against translations */
export interface TranslationCheckResult {
  string: string;
  foundInMenus: boolean;
  foundInNotMenus: boolean;
  found: boolean;
  matchedKey: string | null;
}

/** Combined translation data from both JSON files */
export interface CombinedTranslations {
  menus: TranslationData;
  notMenus: TranslationData;
  allKeys: Set<string>;
}

/**
 * Loads a JSON translation file.
 * 
 * @param filePath - Path to the JSON file
 * @returns Loaded translation data
 */
export function loadTranslationFile(filePath: string): TranslationData {
  try {
    if (!fs.existsSync(filePath)) {
      return {
        filePath,
        translations: {},
        loadError: `File not found: ${filePath}`
      };
    }

    const content = fs.readFileSync(filePath, 'utf-8');
    const translations = JSON.parse(content) as Record<string, string>;

    return {
      filePath,
      translations,
      loadError: null
    };
  } catch (error) {
    return {
      filePath,
      translations: {},
      loadError: `Error loading file: ${error}`
    };
  }
}

/**
 * Loads the English translation JSON files from the translations folder.
 * 
 * @param baseDir - Base directory of the R-Instat project
 * @returns Combined translation data
 */
export function loadEnglishTranslations(baseDir: string): CombinedTranslations {
  const translationsDir = path.join(baseDir, 'instat', 'translations', 'en');
  
  const menus = loadTranslationFile(path.join(translationsDir, 'r_instat_menus.json'));
  const notMenus = loadTranslationFile(path.join(translationsDir, 'r_instat_not_menus.json'));

  // Combine all keys
  const allKeys = new Set<string>();
  
  for (const key of Object.keys(menus.translations)) {
    allKeys.add(key);
  }
  
  for (const key of Object.keys(notMenus.translations)) {
    allKeys.add(key);
  }

  return { menus, notMenus, allKeys };
}

/**
 * Normalizes a string for comparison.
 * Handles common differences in whitespace and casing.
 * 
 * @param str - String to normalize
 * @returns Normalized string
 */
export function normalizeString(str: string): string {
  // Trim and normalize whitespace
  return str.trim().replace(/\s+/g, ' ');
}

/**
 * Checks if a string exists in the translation files.
 * Uses exact match first, then tries normalized match.
 * 
 * @param searchString - String to search for
 * @param translations - Combined translation data
 * @returns Check result
 */
export function checkStringInTranslations(
  searchString: string,
  translations: CombinedTranslations
): TranslationCheckResult {
  const normalized = normalizeString(searchString);

  // Check exact match first
  const foundInMenusExact = searchString in translations.menus.translations;
  const foundInNotMenusExact = searchString in translations.notMenus.translations;

  if (foundInMenusExact || foundInNotMenusExact) {
    return {
      string: searchString,
      foundInMenus: foundInMenusExact,
      foundInNotMenus: foundInNotMenusExact,
      found: true,
      matchedKey: searchString
    };
  }

  // Try normalized match
  for (const key of translations.allKeys) {
    if (normalizeString(key) === normalized) {
      return {
        string: searchString,
        foundInMenus: key in translations.menus.translations,
        foundInNotMenus: key in translations.notMenus.translations,
        found: true,
        matchedKey: key
      };
    }
  }

  // Not found
  return {
    string: searchString,
    foundInMenus: false,
    foundInNotMenus: false,
    found: false,
    matchedKey: null
  };
}

/**
 * Checks multiple strings against translation files.
 * 
 * @param strings - Array of strings to check
 * @param translations - Combined translation data
 * @returns Array of check results
 */
export function checkStringsInTranslations(
  strings: string[],
  translations: CombinedTranslations
): TranslationCheckResult[] {
  return strings.map(s => checkStringInTranslations(s, translations));
}

/**
 * Gets statistics about the translation files.
 * 
 * @param translations - Combined translation data
 * @returns Statistics object
 */
export function getTranslationStats(translations: CombinedTranslations): {
  menusCount: number;
  notMenusCount: number;
  totalCount: number;
  duplicateCount: number;
} {
  const menusKeys = new Set(Object.keys(translations.menus.translations));
  const notMenusKeys = new Set(Object.keys(translations.notMenus.translations));
  
  // Find duplicates (keys in both files)
  let duplicateCount = 0;
  for (const key of menusKeys) {
    if (notMenusKeys.has(key)) {
      duplicateCount++;
    }
  }

  return {
    menusCount: menusKeys.size,
    notMenusCount: notMenusKeys.size,
    totalCount: translations.allKeys.size,
    duplicateCount
  };
}
