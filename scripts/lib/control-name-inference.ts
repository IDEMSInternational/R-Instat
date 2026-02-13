/**
 * Control Name Inference Module
 * 
 * Provides pure functions for inferring control names from VB.NET code context.
 * Aligns with the runtime reflection system's control naming convention:
 * - Form name from file path: `dlgOptions.Designer.vb` → `dlgOptions`
 * - Control name from assignment: `Me.cmdOptions.Text = "..."` → `cmdOptions`
 * - Full pattern: `{formName}_{controlName}` or `{formName}_{parentControl}_{controlName}`
 */

import * as path from 'path';

/** Result of inferring a control name */
export interface InferredControlName {
  formName: string | null;
  controlName: string | null;
  fullPattern: string | null;
  confidence: 'high' | 'medium' | 'low';
}

/**
 * Infers the form name from a VB.NET file path.
 * 
 * Examples:
 * - `dlgOptions.Designer.vb` → `dlgOptions`
 * - `dlgOptions.vb` → `dlgOptions`
 * - `frmMain.Designer.vb` → `frmMain`
 * - `ucrDataViewer.vb` → `ucrDataViewer`
 * 
 * @param filePath - Path to the VB.NET file
 * @returns Form name or null if cannot be inferred
 */
export function inferFormName(filePath: string): string | null {
  const basename = path.basename(filePath);
  
  // Remove .Designer.vb or .vb extension
  let formName = basename;
  
  if (formName.endsWith('.Designer.vb')) {
    formName = formName.slice(0, -'.Designer.vb'.length);
  } else if (formName.endsWith('.vb')) {
    formName = formName.slice(0, -'.vb'.length);
  } else {
    return null;
  }

  // Validate: form names typically start with dlg, frm, sdg, ucr
  if (/^(dlg|frm|sdg|ucr)/i.test(formName)) {
    return formName;
  }

  // Return anyway but with lower confidence (handled by caller)
  return formName;
}

/**
 * Infers the control name from a VB.NET code line.
 * 
 * Examples:
 * - `Me.cmdOptions.Text = "Options"` → `cmdOptions`
 * - `Me.lblTitle.Text = "Title"` → `lblTitle`
 * - `cmdOk.Text = "OK"` → `cmdOk`
 * - `ucrInput.SetText("Value")` → `ucrInput`
 * 
 * @param codeLine - Line of VB.NET code
 * @returns Control name or null if cannot be inferred
 */
export function inferControlName(codeLine: string): string | null {
  // Pattern: Me.controlName.Text = "..."
  const meTextMatch = codeLine.match(/Me\.(\w+)\.Text\s*=/i);
  if (meTextMatch) {
    return meTextMatch[1];
  }

  // Pattern: controlName.Text = "..."
  const textMatch = codeLine.match(/(\w+)\.Text\s*=/i);
  if (textMatch) {
    return textMatch[1];
  }

  // Pattern: Me.controlName.ToolTipText = "..."
  const meTooltipMatch = codeLine.match(/Me\.(\w+)\.ToolTipText\s*=/i);
  if (meTooltipMatch) {
    return meTooltipMatch[1];
  }

  // Pattern: controlName.ToolTipText = "..."
  const tooltipMatch = codeLine.match(/(\w+)\.ToolTipText\s*=/i);
  if (tooltipMatch) {
    return tooltipMatch[1];
  }

  // Pattern: ucrControl.SetText("...")
  const setTextMatch = codeLine.match(/(\w+)\.SetText\s*\(/i);
  if (setTextMatch) {
    return setTextMatch[1];
  }

  // Pattern: ucrControl.SetLabel("...")
  const setLabelMatch = codeLine.match(/(\w+)\.SetLabel\s*\(/i);
  if (setLabelMatch) {
    return setLabelMatch[1];
  }

  // Pattern: ucrControl.SetLabelText("...")
  const setLabelTextMatch = codeLine.match(/(\w+)\.SetLabelText\s*\(/i);
  if (setLabelTextMatch) {
    return setLabelTextMatch[1];
  }

  return null;
}

/**
 * Builds a full control name pattern from form name and control name.
 * 
 * Examples:
 * - `dlgOptions`, `cmdOk` → `dlgOptions_cmdOk`
 * - `frmMain`, `mnuFile` → `frmMain_mnuFile`
 * 
 * @param formName - Form name
 * @param controlName - Control name
 * @returns Full control pattern
 */
export function buildControlPattern(formName: string | null, controlName: string | null): string | null {
  if (!formName && !controlName) {
    return null;
  }

  if (formName && controlName) {
    return `${formName}_${controlName}`;
  }

  // Just control name if no form name
  return controlName || formName;
}

/**
 * Infers the full control name from file path and code line.
 * 
 * @param filePath - Path to the VB.NET file
 * @param codeLine - Line of VB.NET code
 * @returns Inferred control name with confidence
 */
export function inferFullControlName(filePath: string, codeLine: string): InferredControlName {
  const formName = inferFormName(filePath);
  const controlName = inferControlName(codeLine);
  const fullPattern = buildControlPattern(formName, controlName);

  // Determine confidence
  let confidence: 'high' | 'medium' | 'low';
  
  if (formName && controlName && /^(dlg|frm|sdg)/i.test(formName)) {
    // High confidence: known form prefix + control name
    confidence = 'high';
  } else if (formName && controlName) {
    // Medium confidence: form name + control name (unknown form type)
    confidence = 'medium';
  } else if (controlName) {
    // Low confidence: only control name
    confidence = 'low';
  } else {
    confidence = 'low';
  }

  return {
    formName,
    controlName,
    fullPattern,
    confidence
  };
}

/**
 * Checks if a file path is a Form file (dialog, form, subdialog).
 * 
 * @param filePath - Path to the VB.NET file
 * @returns true if the file is likely a Form
 */
export function isFormFile(filePath: string): boolean {
  const formName = inferFormName(filePath);
  if (!formName) {
    return false;
  }

  // Known form prefixes
  return /^(dlg|frm|sdg)/i.test(formName);
}

/**
 * Checks if a file path is a Designer file.
 * 
 * @param filePath - Path to the VB.NET file
 * @returns true if the file is a Designer file
 */
export function isDesignerFile(filePath: string): boolean {
  return filePath.toLowerCase().endsWith('.designer.vb');
}

/**
 * Checks if a control name is for a control type that is dynamically set at runtime.
 * These controls should typically be excluded from static analysis.
 * 
 * Based on Translations.vb: "ucrCheck and ucrInput controls are specifically excluded"
 * 
 * @param controlName - Control name to check
 * @returns true if the control is dynamically set
 */
export function isDynamicControl(controlName: string): boolean {
  if (!controlName) {
    return false;
  }

  // Known dynamic control prefixes
  const dynamicPrefixes = ['ucrInput', 'ucrCheck'];
  
  return dynamicPrefixes.some(prefix => 
    controlName.toLowerCase().startsWith(prefix.toLowerCase())
  );
}
