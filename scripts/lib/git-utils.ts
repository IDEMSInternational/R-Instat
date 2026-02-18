/**
 * Git Utilities Module
 * 
 * Provides git operations for CI mode support.
 * Gets changed files, base branch info, etc.
 */

import { execSync } from 'child_process';
import * as path from 'path';

/** Result of getting changed files */
export interface ChangedFilesResult {
  files: string[];
  baseBranch: string;
  error: string | null;
}

/**
 * Executes a git command and returns the output.
 * Logs errors to stderr for debugging in CI environments.
 * 
 * @param command - Git command to execute (without 'git' prefix)
 * @param cwd - Working directory
 * @returns Command output or null on error
 */
function execGit(command: string, cwd: string): string | null {
  try {
    const output = execSync(`git ${command}`, {
      cwd,
      encoding: 'utf-8',
      stdio: ['pipe', 'pipe', 'pipe']
    });
    return output.trim();
  } catch (error) {
    // Log error details to stderr for debugging
    const errorMessage = error instanceof Error ? error.message : String(error);
    const stderr = (error as { stderr?: Buffer | string })?.stderr;
    const stderrText = stderr instanceof Buffer ? stderr.toString() : stderr;
    
    console.error(`[git-utils] Command failed: git ${command}`);
    console.error(`[git-utils] Error: ${errorMessage}`);
    if (stderrText) {
      console.error(`[git-utils] stderr: ${stderrText}`);
    }
    
    return null;
  }
}

/**
 * Gets the current branch name.
 * 
 * @param cwd - Working directory
 * @returns Current branch name or null
 */
export function getCurrentBranch(cwd: string): string | null {
  return execGit('rev-parse --abbrev-ref HEAD', cwd);
}

/**
 * Gets the base branch for comparison (typically 'master' or 'main').
 * In GitHub Actions, uses GITHUB_BASE_REF if available.
 * 
 * @param cwd - Working directory
 * @returns Base branch name
 */
export function getBaseBranch(cwd: string): string {
  // Check GitHub Actions environment variable first
  if (process.env.GITHUB_BASE_REF) {
    return process.env.GITHUB_BASE_REF;
  }

  // Default to 'master'
  return 'master';
}

/**
 * Gets list of files changed between current branch and base branch.
 * 
 * @param cwd - Working directory
 * @param baseBranch - Base branch to compare against
 * @returns Changed files result
 */
export function getChangedFiles(cwd: string, baseBranch?: string): ChangedFilesResult {
  const base = baseBranch || getBaseBranch(cwd);

  try {
    // Get merge base to properly handle branch divergence
    const mergeBase = execGit(`merge-base ${base} HEAD`, cwd);
    
    if (!mergeBase) {
      // Fallback: compare directly with base
      const output = execGit(`diff --name-only ${base}...HEAD`, cwd);
      
      if (output === null) {
        return {
          files: [],
          baseBranch: base,
          error: `Could not get changed files from ${base}`
        };
      }

      return {
        files: output.split('\n').filter(f => f !== ''),
        baseBranch: base,
        error: null
      };
    }

    // Get changed files from merge base to HEAD
    const output = execGit(`diff --name-only ${mergeBase} HEAD`, cwd);
    
    if (output === null) {
      return {
        files: [],
        baseBranch: base,
        error: 'Could not get changed files'
      };
    }

    return {
      files: output.split('\n').filter(f => f !== ''),
      baseBranch: base,
      error: null
    };
  } catch (error) {
    return {
      files: [],
      baseBranch: base,
      error: `Error getting changed files: ${error}`
    };
  }
}

/**
 * Filters changed files to only include VB.NET files in the instat directory.
 * 
 * @param files - Array of file paths
 * @returns Filtered array of VB.NET files
 */
export function filterVBNetFiles(files: string[]): string[] {
  return files.filter(f => {
    const lower = f.toLowerCase();
    return lower.endsWith('.vb') && lower.includes('instat/');
  });
}

/**
 * Gets changed VB.NET files for the current PR.
 * Combines getChangedFiles and filterVBNetFiles.
 * 
 * @param cwd - Working directory
 * @param baseBranch - Optional base branch
 * @returns Changed VB.NET files
 */
export function getChangedVBNetFiles(cwd: string, baseBranch?: string): ChangedFilesResult {
  const result = getChangedFiles(cwd, baseBranch);
  
  if (result.error) {
    return result;
  }

  return {
    files: filterVBNetFiles(result.files),
    baseBranch: result.baseBranch,
    error: null
  };
}

/**
 * Checks if we're running in a CI environment.
 * 
 * @returns true if running in CI
 */
export function isCI(): boolean {
  return process.env.CI === 'true' || 
         process.env.GITHUB_ACTIONS === 'true' ||
         !!process.env.GITHUB_RUN_ID;
}

/**
 * Gets the pull request number from GitHub Actions environment.
 * 
 * @returns PR number or null
 */
export function getPRNumber(): number | null {
  // GITHUB_REF format for PRs: refs/pull/{pr_number}/merge
  const ref = process.env.GITHUB_REF;
  if (ref) {
    const match = ref.match(/refs\/pull\/(\d+)\/merge/);
    if (match) {
      return parseInt(match[1], 10);
    }
  }

  // Try GITHUB_EVENT_NUMBER (set by some actions)
  const eventNumber = process.env.GITHUB_EVENT_NUMBER;
  if (eventNumber) {
    return parseInt(eventNumber, 10);
  }

  return null;
}

/**
 * Resolves a file path relative to the working directory.
 * 
 * @param filePath - File path (possibly relative)
 * @param cwd - Working directory
 * @returns Absolute file path
 */
export function resolveFilePath(filePath: string, cwd: string): string {
  if (path.isAbsolute(filePath)) {
    return filePath;
  }
  return path.join(cwd, filePath);
}
