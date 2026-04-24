#!/usr/bin/env node
/**
 * Sync Translations - Append missing strings to the EN JSON files.
 *
 * Runs the full code scan and appends any strings found in code but
 * absent from the EN JSON files. Menu items (controls prefixed `mnu*`)
 * go to r_instat_menus.json; everything else goes to r_instat_not_menus.json.
 *
 * Usage:
 *   npm run sync-translations              # Append missing, write files
 *   npm run sync-translations:dry-run      # Print what would be added, no writes
 *
 * Options:
 *   --dry-run     Report changes without writing files
 *   --verbose     Show detailed scan logs
 *   --help        Show help
 */

import { getProjectRoot } from './lib/project-root.js';
import { runScan } from './lib/scan.js';
import { appendMissingStrings } from './lib/translation-writer.js';

interface CliOptions {
  dryRun: boolean;
  verbose: boolean;
  help: boolean;
}

function parseArgs(args: string[]): CliOptions {
  const options: CliOptions = { dryRun: false, verbose: false, help: false };
  for (const arg of args) {
    switch (arg) {
      case '--dry-run':
        options.dryRun = true;
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
Sync Translations - Append missing strings to the EN JSON files.

Usage:
  npx ts-node sync-translations.ts [options]

Options:
  --dry-run     Report changes without writing files
  --verbose     Show detailed scan logs
  --help        Show this help message

Menu items (controls prefixed mnu*) go to r_instat_menus.json.
All other strings go to r_instat_not_menus.json.
`);
}

function summarize(title: string, items: string[]): void {
  console.log(`${title}: ${items.length}`);
  const preview = items.slice(0, 5);
  for (const item of preview) {
    const truncated = item.length > 70 ? item.slice(0, 70) + '...' : item;
    console.log(`  + "${truncated}"`);
  }
  if (items.length > preview.length) {
    console.log(`  ... (${items.length - preview.length} more)`);
  }
}

async function main(): Promise<void> {
  const options = parseArgs(process.argv.slice(2));

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
    console.log(`Mode: ${options.dryRun ? 'dry-run' : 'write'}`);
  }

  const { classifiedMissing, stats } = await runScan(baseDir, {
    ciMode: false,
    verbose: options.verbose
  });

  console.log('');
  console.log('Scan results:');
  console.log(`  Files scanned:       ${stats.totalFilesChecked}`);
  console.log(`  Strings extracted:   ${stats.totalStringsExtracted}`);
  console.log(`  Strings ignored:     ${stats.totalStringsIgnored}`);
  console.log(`  Missing in EN JSON:  ${classifiedMissing.size}`);
  console.log('');

  if (classifiedMissing.size === 0) {
    console.log('✅ Nothing to sync — all extracted strings exist in EN JSON.');
    process.exit(0);
  }

  // Partition for reporting.
  const wouldAddMenus: string[] = [];
  const wouldAddNotMenus: string[] = [];
  for (const [key, route] of classifiedMissing.entries()) {
    if (route === 'menus') wouldAddMenus.push(key);
    else wouldAddNotMenus.push(key);
  }

  if (options.dryRun) {
    console.log('Dry-run — no files written.');
    console.log('');
    summarize('Would append to r_instat_menus.json', wouldAddMenus);
    console.log('');
    summarize('Would append to r_instat_not_menus.json', wouldAddNotMenus);
    process.exit(0);
  }

  const { added } = await appendMissingStrings(baseDir, classifiedMissing);

  console.log('✍️  Wrote EN JSON updates.');
  console.log('');
  summarize('Appended to r_instat_menus.json', added.menus);
  console.log('');
  summarize('Appended to r_instat_not_menus.json', added.notMenus);
  console.log('');
  console.log('Next: review the diff and commit the EN JSON changes along with your VB edits.');

  process.exit(0);
}

main().catch(error => {
  console.error('Error:', error);
  process.exit(1);
});
