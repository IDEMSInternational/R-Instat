/**
 * Translation Writer Module
 *
 * Mutates the English source JSON files (menus / not_menus) while
 * preserving their on-disk format:
 *   - insertion order (existing keys stay put; new keys append at end)
 *   - 2-space indent
 *   - trailing newline
 *
 * The English source convention is: value === key.
 */

import * as fs from 'fs/promises';
import * as path from 'path';

import { loadTranslationFile } from './translation-checker.js';

export type Route = 'menus' | 'notMenus';

export interface AppendResult {
  added: { menus: string[]; notMenus: string[] };
}

export interface RemoveResult {
  removed: { menus: string[]; notMenus: string[] };
}

const MENUS_REL = path.join('instat', 'translations', 'en', 'r_instat_menus.json');
const NOT_MENUS_REL = path.join('instat', 'translations', 'en', 'r_instat_not_menus.json');

/**
 * Routes a missing string to the correct EN JSON file based on its
 * VB control name prefix. Menu items in this codebase follow the
 * `mnu*` naming convention (e.g. `mnuFileOpen`, `mnuDescribe`).
 */
export function classifyRoute(controlName: string | null): Route {
  if (controlName && /^mnu/i.test(controlName)) {
    return 'menus';
  }
  return 'notMenus';
}

function routeToRelPath(route: Route): string {
  return route === 'menus' ? MENUS_REL : NOT_MENUS_REL;
}

/** Serializes with the repo's chosen format. */
function serialize(obj: Record<string, string>): string {
  return JSON.stringify(obj, null, 2) + '\n';
}

/**
 * Appends missing strings to the correct EN JSON file.
 * Preserves existing key order; new keys append at end.
 * Idempotent: keys already present are skipped.
 */
export async function appendMissingStrings(
  baseDir: string,
  classifiedMissing: Map<string, Route>
): Promise<AppendResult> {
  const addedMenus: string[] = [];
  const addedNotMenus: string[] = [];

  const menusPath = path.join(baseDir, MENUS_REL);
  const notMenusPath = path.join(baseDir, NOT_MENUS_REL);

  const [menusData, notMenusData] = await Promise.all([
    loadTranslationFile(menusPath),
    loadTranslationFile(notMenusPath)
  ]);

  if (menusData.loadError) {
    throw new Error(`Cannot load menus JSON: ${menusData.loadError}`);
  }
  if (notMenusData.loadError) {
    throw new Error(`Cannot load not_menus JSON: ${notMenusData.loadError}`);
  }

  const menus: Record<string, string> = { ...menusData.translations };
  const notMenus: Record<string, string> = { ...notMenusData.translations };

  for (const [key, route] of classifiedMissing.entries()) {
    // Skip if present in either file — treat the combined EN source as
    // one surface for idempotency, even if routing would pick a different
    // file on this run.
    const alreadyPresent = key in menus || key in notMenus;
    if (alreadyPresent) {
      continue;
    }

    if (route === 'menus') {
      menus[key] = key;
      addedMenus.push(key);
    } else {
      notMenus[key] = key;
      addedNotMenus.push(key);
    }
  }

  await Promise.all([
    addedMenus.length > 0 ? fs.writeFile(menusPath, serialize(menus), 'utf-8') : Promise.resolve(),
    addedNotMenus.length > 0 ? fs.writeFile(notMenusPath, serialize(notMenus), 'utf-8') : Promise.resolve()
  ]);

  return { added: { menus: addedMenus, notMenus: addedNotMenus } };
}

/**
 * Removes the given keys from the EN JSON files.
 * Silently skips keys that aren't present.
 */
export async function removeOrphans(
  baseDir: string,
  keysToRemove: { menus: string[]; notMenus: string[] }
): Promise<RemoveResult> {
  const menusPath = path.join(baseDir, MENUS_REL);
  const notMenusPath = path.join(baseDir, NOT_MENUS_REL);

  const [menusData, notMenusData] = await Promise.all([
    loadTranslationFile(menusPath),
    loadTranslationFile(notMenusPath)
  ]);

  if (menusData.loadError) {
    throw new Error(`Cannot load menus JSON: ${menusData.loadError}`);
  }
  if (notMenusData.loadError) {
    throw new Error(`Cannot load not_menus JSON: ${notMenusData.loadError}`);
  }

  const menus: Record<string, string> = { ...menusData.translations };
  const notMenus: Record<string, string> = { ...notMenusData.translations };

  const removedMenus: string[] = [];
  const removedNotMenus: string[] = [];

  for (const key of keysToRemove.menus) {
    if (key in menus) {
      delete menus[key];
      removedMenus.push(key);
    }
  }
  for (const key of keysToRemove.notMenus) {
    if (key in notMenus) {
      delete notMenus[key];
      removedNotMenus.push(key);
    }
  }

  await Promise.all([
    removedMenus.length > 0 ? fs.writeFile(menusPath, serialize(menus), 'utf-8') : Promise.resolve(),
    removedNotMenus.length > 0 ? fs.writeFile(notMenusPath, serialize(notMenus), 'utf-8') : Promise.resolve()
  ]);

  return { removed: { menus: removedMenus, notMenus: removedNotMenus } };
}

export { MENUS_REL, NOT_MENUS_REL };
