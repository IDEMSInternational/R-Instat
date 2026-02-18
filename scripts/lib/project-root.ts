/**
 * Project Root Finder
 * 
 * Robustly locates the R-Instat project root by searching upward from
 * the current directory for known project markers.
 */

import * as fs from 'fs/promises';
import * as path from 'path';

/** Markers that indicate the project root */
const PROJECT_MARKERS = [
  '.git',           // Git repository root
  'instat',         // Main VB.NET project directory
  'Instat.sln'      // Solution file
] as const;

/**
 * Checks if a directory contains any project marker.
 * 
 * @param dir - Directory to check
 * @returns The marker found, or null if none
 */
async function hasProjectMarker(dir: string): Promise<string | null> {
  for (const marker of PROJECT_MARKERS) {
    const markerPath = path.join(dir, marker);
    try {
      await fs.access(markerPath);
      return marker;
    } catch {
      // Marker doesn't exist, continue
    }
  }
  return null;
}

/**
 * Finds the project root by searching upward from a starting directory.
 * 
 * Algorithm:
 * 1. Start from the given directory (or cwd)
 * 2. Check for project markers in current directory
 * 3. If found, return the directory
 * 4. If not, move to parent directory
 * 5. Repeat until root is reached
 * 
 * @param startDir - Starting directory (defaults to cwd)
 * @param maxDepth - Maximum directories to traverse up (prevents infinite loops)
 * @returns Project root path, or null if not found
 */
export async function findProjectRoot(
  startDir?: string,
  maxDepth: number = 20
): Promise<{ root: string; marker: string } | null> {
  let currentDir = startDir ? path.resolve(startDir) : process.cwd();
  let depth = 0;

  while (depth < maxDepth) {
    const marker = await hasProjectMarker(currentDir);
    
    if (marker) {
      return { root: currentDir, marker };
    }

    // Move to parent directory
    const parentDir = path.dirname(currentDir);
    
    // Check if we've reached the filesystem root
    if (parentDir === currentDir) {
      break;
    }

    currentDir = parentDir;
    depth++;
  }

  return null;
}

/**
 * Gets the project root, throwing an error if not found.
 * This is the preferred method for scripts that require a valid project root.
 * 
 * @param startDir - Starting directory (defaults to cwd)
 * @returns Project root path
 * @throws Error if project root cannot be found
 */
export async function getProjectRoot(startDir?: string): Promise<string> {
  const result = await findProjectRoot(startDir);
  
  if (!result) {
    const searchedFrom = startDir || process.cwd();
    throw new Error(
      `Could not find R-Instat project root.\n` +
      `Searched upward from: ${searchedFrom}\n` +
      `Looking for markers: ${PROJECT_MARKERS.join(', ')}\n` +
      `Make sure you're running this script from within the R-Instat project.`
    );
  }

  return result.root;
}

/**
 * Validates that a directory is the project root by checking multiple markers.
 * Useful for additional validation after finding a potential root.
 * 
 * @param dir - Directory to validate
 * @returns Validation result with details
 */
export async function validateProjectRoot(dir: string): Promise<{
  valid: boolean;
  foundMarkers: string[];
  missingMarkers: string[];
}> {
  const foundMarkers: string[] = [];
  const missingMarkers: string[] = [];

  for (const marker of PROJECT_MARKERS) {
    const markerPath = path.join(dir, marker);
    try {
      await fs.access(markerPath);
      foundMarkers.push(marker);
    } catch {
      missingMarkers.push(marker);
    }
  }

  // Consider valid if we found at least the 'instat' directory
  const valid = foundMarkers.includes('instat');

  return { valid, foundMarkers, missingMarkers };
}
