/**
 * Orphan Finder Module
 *
 * Pure function that identifies translation keys present in the EN JSON
 * files but never seen by static analysis of the VB.NET codebase.
 *
 * Note: "orphan" here means "not captured by the extract/filter pipeline".
 * An orphan is not guaranteed to be dead — it may simply be a string the
 * parser can't see (MsgBox, runtime concatenation, dynamic controls).
 * Callers that act on orphans (e.g. prune) should cross-check against a
 * broader source index.
 */

import { CombinedTranslations } from './translation-checker.js';

export interface OrphanAnalysis {
  orphanMenus: string[];
  orphanNotMenus: string[];
  total: number;
}

export function findOrphans(
  extractedStrings: Set<string>,
  translations: CombinedTranslations
): OrphanAnalysis {
  const orphanMenus: string[] = [];
  const orphanNotMenus: string[] = [];

  for (const key of Object.keys(translations.menus.translations)) {
    if (!extractedStrings.has(key)) {
      orphanMenus.push(key);
    }
  }

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
