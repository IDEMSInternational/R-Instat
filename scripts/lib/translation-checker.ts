/**
 * Translation Checker Module
 * 
 * Provides JSON translation file loading and string existence checking.
 * Loads and checks against the English translation JSON files.
 */

import * as fs from 'fs/promises';
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
  /** Pre-computed map of normalized keys to original keys for O(1) lookup */
  normalizedKeyMap: Map<string, string>;
}

/**
 * Checks if a file exists using async fs.
 */
async function fileExists(filePath: string): Promise<boolean> {
  try {
    await fs.access(filePath);
    return true;
  } catch {
    return false;
  }
}

/**
 * Loads a JSON translation file asynchronously.
 * 
 * @param filePath - Path to the JSON file
 * @returns Loaded translation data
 */
export async function loadTranslationFile(filePath: string): Promise<TranslationData> {
  try {
    if (!(await fileExists(filePath))) {
      return {
        filePath,
        translations: {},
        loadError: `File not found: ${filePath}`
      };
    }

    const content = await fs.readFile(filePath, 'utf-8');
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
 * Uses parallel loading for better performance.
 * Pre-computes a normalized key map for O(1) lookups during string checking.
 * 
 * @param baseDir - Base directory of the R-Instat project
 * @returns Combined translation data
 */
export async function loadEnglishTranslations(baseDir: string): Promise<CombinedTranslations> {
  const translationsDir = path.join(baseDir, 'instat', 'translations', 'en');
  
  // Load both files in parallel
  const [menus, notMenus] = await Promise.all([
    loadTranslationFile(path.join(translationsDir, 'r_instat_menus.json')),
    loadTranslationFile(path.join(translationsDir, 'r_instat_not_menus.json'))
  ]);

  // Combine all keys and pre-compute normalized key map
  const allKeys = new Set<string>();
  const normalizedKeyMap = new Map<string, string>();
  
  // Process menus keys
  for (const key of Object.keys(menus.translations)) {
    allKeys.add(key);
    const normalized = normalizeString(key);
    // Only store first occurrence if there are collisions
    if (!normalizedKeyMap.has(normalized)) {
      normalizedKeyMap.set(normalized, key);
    }
  }
  
  // Process notMenus keys
  for (const key of Object.keys(notMenus.translations)) {
    allKeys.add(key);
    const normalized = normalizeString(key);
    // Only store first occurrence if there are collisions
    if (!normalizedKeyMap.has(normalized)) {
      normalizedKeyMap.set(normalized, key);
    }
  }

  return { menus, notMenus, allKeys, normalizedKeyMap };
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
 * Uses exact match first (O(1) via Set), then tries normalized match (O(1) via Map).
 * 
 * @param searchString - String to search for
 * @param translations - Combined translation data
 * @returns Check result
 */
export function checkStringInTranslations(
  searchString: string,
  translations: CombinedTranslations
): TranslationCheckResult {
  // Check exact match first using Set (O(1))
  if (translations.allKeys.has(searchString)) {
    return {
      string: searchString,
      foundInMenus: searchString in translations.menus.translations,
      foundInNotMenus: searchString in translations.notMenus.translations,
      found: true,
      matchedKey: searchString
    };
  }

  // Try normalized match using pre-computed map (O(1))
  const normalized = normalizeString(searchString);
  const matchedKey = translations.normalizedKeyMap.get(normalized);

  if (matchedKey) {
    return {
      string: searchString,
      foundInMenus: matchedKey in translations.menus.translations,
      foundInNotMenus: matchedKey in translations.notMenus.translations,
      found: true,
      matchedKey: matchedKey
    };
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
