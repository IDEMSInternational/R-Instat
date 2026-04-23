#!/usr/bin/env node
/**
 * Prune Orphans - Delete unreferenced EN JSON keys, safely.
 *
 * Orphans = keys in the EN JSON files that the static extract pipeline
 * never encountered in code. "Never encountered" is conservative: the
 * extract pipeline matches only 5 syntactic patterns, so an orphan might
 * still be alive through MsgBox, exception messages, dynamic control calls,
 * concatenations, etc.
 *
 * Safety net: before a key is considered prune-eligible it must also be
 * absent from a broader index (every string literal in every .vb file).
 * This catches strings invisible to pattern-based analysis.
 *
 * Usage:
 *   npm run prune-orphans               # Dry-run, writes candidate list to JSON
 *   npm run prune-orphans:write         # Actually delete (requires --write --yes)
 *
 * Options:
 *   --dry-run     Default. Report candidates, write no files.
 *   --write       Write deletions. Must be combined with --yes.
 *   --yes         Confirm destructive deletion. No effect without --write.
 *   --verbose     Show detailed scan logs
 *   --help        Show help
 */

import * as fs from 'fs/promises';
import * as path from 'path';

import { getProjectRoot } from './lib/project-root.js';
import { runScan } from './lib/scan.js';
import { findOrphans } from './lib/orphan-finder.js';
import { removeOrphans } from './lib/translation-writer.js';
import { indexAllVBStringLiterals, indexHas } from './lib/string-indexer.js';

interface CliOptions {
  dryRun: boolean;
  write: boolean;
  yes: boolean;
  verbose: boolean;
  help: boolean;
}

function parseArgs(args: string[]): CliOptions {
  const options: CliOptions = {
    dryRun: true,
    write: false,
    yes: false,
    verbose: false,
    help: false
  };
  for (const arg of args) {
    switch (arg) {
      case '--dry-run':
        options.dryRun = true;
        break;
      case '--write':
        options.write = true;
        options.dryRun = false;
        break;
      case '--yes':
        options.yes = true;
        break;
      case '--verbose':
      case '-v':
        options.verbose = true;
        break;
      case '--help':
      case '-h':
        options.help = true;
        break;
    }
  }
  return options;
}

function printHelp(): void {
  console.log(`
Prune Orphans - Delete unreferenced EN JSON keys, safely.

Usage:
  npx ts-node prune-orphans.ts [options]

Options:
  --dry-run     Default. Report candidates, write no files.
  --write       Write deletions (requires --yes).
  --yes         Confirm destructive deletion.
  --verbose     Show detailed scan logs
  --help        Show this help message

An orphan is eligible for prune only if it's absent from BOTH the
pattern-based scan AND the broad VB string-literal index.
`);
}

function preview(title: string, items: string[]): void {
  console.log(`${title}: ${items.length}`);
  const slice = items.slice(0, 5);
  for (const item of slice) {
    const truncated = item.length > 70 ? item.slice(0, 70) + '...' : item;
    console.log(`  - "${truncated}"`);
  }
  if (items.length > slice.length) {
    console.log(`  ... (${items.length - slice.length} more)`);
  }
}

async function main(): Promise<void> {
  const options = parseArgs(process.argv.slice(2));

  if (options.help) {
    printHelp();
    process.exit(0);
  }

  if (options.write && !options.yes) {
    console.error('Refusing to write: --write must be paired with --yes.');
    console.error('Run without --write to preview, or add --yes to confirm.');
    process.exit(2);
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
    console.log(`Mode: ${options.write ? 'write' : 'dry-run'}`);
  }

  const { extractedStrings, translations, stats } = await runScan(baseDir, {
    ciMode: false,
    verbose: options.verbose
  });

  const orphans = findOrphans(extractedStrings, translations);

  console.log('');
  console.log('Scan results:');
  console.log(`  Files scanned:       ${stats.totalFilesChecked}`);
  console.log(`  Strings extracted:   ${stats.totalStringsExtracted}`);
  console.log(`  Orphans (narrow):    ${orphans.total}`);

  if (orphans.total === 0) {
    console.log('✅ No orphans found.');
    process.exit(0);
  }

  console.log('');
  console.log('Building broad VB string-literal index...');
  const broadIndex = await indexAllVBStringLiterals(baseDir);
  console.log(`  Indexed ${broadIndex.size} distinct literals from .vb files.`);

  const eligibleMenus = orphans.orphanMenus.filter(k => !indexHas(broadIndex, k));
  const eligibleNotMenus = orphans.orphanNotMenus.filter(k => !indexHas(broadIndex, k));
  const keptMenus = orphans.orphanMenus.length - eligibleMenus.length;
  const keptNotMenus = orphans.orphanNotMenus.length - eligibleNotMenus.length;
  const totalEligible = eligibleMenus.length + eligibleNotMenus.length;

  console.log('');
  console.log('Orphan filtering:');
  console.log(`  Kept (seen in broad index):  ${keptMenus + keptNotMenus}`);
  console.log(`  Eligible to prune:           ${totalEligible}`);
  console.log('');

  const candidatesPath = path.join(baseDir, 'scripts', 'orphan-prune-candidates.json');
  await fs.writeFile(
    candidatesPath,
    JSON.stringify(
      {
        timestamp: new Date().toISOString(),
        eligibleMenus,
        eligibleNotMenus,
        keptMenusCount: keptMenus,
        keptNotMenusCount: keptNotMenus
      },
      null,
      2
    ) + '\n',
    'utf-8'
  );
  console.log(`Candidate list written to: ${candidatesPath}`);
  console.log('');

  preview('Eligible from r_instat_menus.json', eligibleMenus);
  console.log('');
  preview('Eligible from r_instat_not_menus.json', eligibleNotMenus);
  console.log('');

  if (options.dryRun || !options.write) {
    console.log('Dry-run — no files written.');
    console.log('Re-run with --write --yes to actually delete.');
    process.exit(0);
  }

  if (totalEligible === 0) {
    console.log('Nothing to delete.');
    process.exit(0);
  }

  const { removed } = await removeOrphans(baseDir, {
    menus: eligibleMenus,
    notMenus: eligibleNotMenus
  });

  console.log('🗑  Wrote EN JSON deletions.');
  console.log(`  Removed from r_instat_menus.json:     ${removed.menus.length}`);
  console.log(`  Removed from r_instat_not_menus.json: ${removed.notMenus.length}`);
  console.log('');
  console.log('Next: review the diff and commit.');

  process.exit(0);
}

main().catch(error => {
  console.error('Error:', error);
  process.exit(1);
});
