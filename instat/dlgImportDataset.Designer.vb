' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgImportDataset
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgImportDataset))
        Me.lblTextFilePreview = New System.Windows.Forms.Label()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.lblEncodingCSV = New System.Windows.Forms.Label()
        Me.lblHeadersCSV = New System.Windows.Forms.Label()
        Me.lblRowNamesCSV = New System.Windows.Forms.Label()
        Me.lblSeparatorCSV = New System.Windows.Forms.Label()
        Me.lblDecimalCSV = New System.Windows.Forms.Label()
        Me.txtTextFilePreview = New System.Windows.Forms.TextBox()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblLinesToSkipCSV = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.lblNAStringsCSV = New System.Windows.Forms.Label()
        Me.ucrChkStringsAsFactorsCSV = New instat.ucrCheck()
        Me.ucrNudLinesToSkipCSV = New instat.ucrNud()
        Me.rdoRowNamesNoCSV = New System.Windows.Forms.RadioButton()
        Me.rdoRowNamesYesCSV = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRowNamesCSV = New instat.UcrPanel()
        Me.ucrInputHeadersCSV = New instat.ucrInputComboBox()
        Me.ucrInputNAStringsCSV = New instat.ucrInputTextBox()
        Me.ucrInputDecimalCSV = New instat.ucrInputComboBox()
        Me.ucrInputSeparatorCSV = New instat.ucrInputComboBox()
        Me.ucrInputEncodingCSV = New instat.ucrInputComboBox()
        Me.grpExcel = New System.Windows.Forms.GroupBox()
        Me.ucrChkMaxRowsExcel = New instat.ucrCheck()
        Me.ucrChkTrimWSExcel = New instat.ucrCheck()
        Me.ucrNudRowsToSkipExcel = New instat.ucrNud()
        Me.ucrInputMaxRowsExcel = New instat.ucrInputTextBox()
        Me.lblMissingValueStringExcel = New System.Windows.Forms.Label()
        Me.ucrInputMissingValueStringExcel = New instat.ucrInputTextBox()
        Me.ucrInputNamedRegions = New instat.ucrInputComboBox()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.ucrInputSelectSheetExcel = New instat.ucrInputComboBox()
        Me.lblRowToSkipExcel = New System.Windows.Forms.Label()
        Me.lblSelectSheetExcel = New System.Windows.Forms.Label()
        Me.grpRDS = New System.Windows.Forms.GroupBox()
        Me.ucrChkOverwriteRDS = New instat.ucrCheck()
        Me.ucrChkImportObjectsRDS = New instat.ucrCheck()
        Me.ucrChkImportCalculationsRDS = New instat.ucrCheck()
        Me.ucrChkImportChangesLogRDS = New instat.ucrCheck()
        Me.ucrChkImportFiltersRDS = New instat.ucrCheck()
        Me.ucrChkImportMetadataRDS = New instat.ucrCheck()
        Me.ucrChkKeepExistingDataRDS = New instat.ucrCheck()
        Me.lblCannotImport = New System.Windows.Forms.Label()
        Me.lblNoPreview = New System.Windows.Forms.Label()
        Me.lblLinesToPreview = New System.Windows.Forms.Label()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.ucrSaveFile = New instat.ucrSave()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.cmdRefreshPreview = New System.Windows.Forms.Button()
        Me.grpCSV.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        Me.grpRDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTextFilePreview
        '
        resources.ApplyResources(Me.lblTextFilePreview, "lblTextFilePreview")
        Me.lblTextFilePreview.Name = "lblTextFilePreview"
        Me.lblTextFilePreview.Tag = "Input_File_Preview"
        '
        'lblDataFrame
        '
        resources.ApplyResources(Me.lblDataFrame, "lblDataFrame")
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Tag = "Data_Frame_Preview"
        '
        'lblEncodingCSV
        '
        resources.ApplyResources(Me.lblEncodingCSV, "lblEncodingCSV")
        Me.lblEncodingCSV.Name = "lblEncodingCSV"
        Me.lblEncodingCSV.Tag = "Encoding:"
        '
        'lblHeadersCSV
        '
        resources.ApplyResources(Me.lblHeadersCSV, "lblHeadersCSV")
        Me.lblHeadersCSV.Name = "lblHeadersCSV"
        Me.lblHeadersCSV.Tag = "Heading:"
        '
        'lblRowNamesCSV
        '
        resources.ApplyResources(Me.lblRowNamesCSV, "lblRowNamesCSV")
        Me.lblRowNamesCSV.Name = "lblRowNamesCSV"
        Me.lblRowNamesCSV.Tag = "Row_Names"
        '
        'lblSeparatorCSV
        '
        resources.ApplyResources(Me.lblSeparatorCSV, "lblSeparatorCSV")
        Me.lblSeparatorCSV.Name = "lblSeparatorCSV"
        Me.lblSeparatorCSV.Tag = "Separator:"
        '
        'lblDecimalCSV
        '
        resources.ApplyResources(Me.lblDecimalCSV, "lblDecimalCSV")
        Me.lblDecimalCSV.Name = "lblDecimalCSV"
        Me.lblDecimalCSV.Tag = "Decimal:"
        '
        'txtTextFilePreview
        '
        resources.ApplyResources(Me.txtTextFilePreview, "txtTextFilePreview")
        Me.txtTextFilePreview.Name = "txtTextFilePreview"
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        resources.ApplyResources(Me.grdDataPreview, "grdDataPreview")
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabVisible = True
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.ShowScrollEndSpacing = True
        '
        'lblFileOpenPath
        '
        resources.ApplyResources(Me.lblFileOpenPath, "lblFileOpenPath")
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        '
        'lblLinesToSkipCSV
        '
        resources.ApplyResources(Me.lblLinesToSkipCSV, "lblLinesToSkipCSV")
        Me.lblLinesToSkipCSV.Name = "lblLinesToSkipCSV"
        '
        'cmdBrowse
        '
        resources.ApplyResources(Me.cmdBrowse, "cmdBrowse")
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Tag = "browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'grpCSV
        '
        resources.ApplyResources(Me.grpCSV, "grpCSV")
        Me.grpCSV.Controls.Add(Me.lblNAStringsCSV)
        Me.grpCSV.Controls.Add(Me.ucrChkStringsAsFactorsCSV)
        Me.grpCSV.Controls.Add(Me.ucrNudLinesToSkipCSV)
        Me.grpCSV.Controls.Add(Me.rdoRowNamesNoCSV)
        Me.grpCSV.Controls.Add(Me.rdoRowNamesYesCSV)
        Me.grpCSV.Controls.Add(Me.ucrPnlRowNamesCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputHeadersCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputNAStringsCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimalCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparatorCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputEncodingCSV)
        Me.grpCSV.Controls.Add(Me.lblEncodingCSV)
        Me.grpCSV.Controls.Add(Me.lblHeadersCSV)
        Me.grpCSV.Controls.Add(Me.lblRowNamesCSV)
        Me.grpCSV.Controls.Add(Me.lblSeparatorCSV)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkipCSV)
        Me.grpCSV.Controls.Add(Me.lblDecimalCSV)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.TabStop = False
        '
        'lblNAStringsCSV
        '
        resources.ApplyResources(Me.lblNAStringsCSV, "lblNAStringsCSV")
        Me.lblNAStringsCSV.Name = "lblNAStringsCSV"
        '
        'ucrChkStringsAsFactorsCSV
        '
        Me.ucrChkStringsAsFactorsCSV.Checked = False
        resources.ApplyResources(Me.ucrChkStringsAsFactorsCSV, "ucrChkStringsAsFactorsCSV")
        Me.ucrChkStringsAsFactorsCSV.Name = "ucrChkStringsAsFactorsCSV"
        '
        'ucrNudLinesToSkipCSV
        '
        Me.ucrNudLinesToSkipCSV.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLinesToSkipCSV, "ucrNudLinesToSkipCSV")
        Me.ucrNudLinesToSkipCSV.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Name = "ucrNudLinesToSkipCSV"
        Me.ucrNudLinesToSkipCSV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoRowNamesNoCSV
        '
        resources.ApplyResources(Me.rdoRowNamesNoCSV, "rdoRowNamesNoCSV")
        Me.rdoRowNamesNoCSV.Name = "rdoRowNamesNoCSV"
        Me.rdoRowNamesNoCSV.TabStop = True
        Me.rdoRowNamesNoCSV.Tag = "No"
        Me.rdoRowNamesNoCSV.UseVisualStyleBackColor = True
        '
        'rdoRowNamesYesCSV
        '
        resources.ApplyResources(Me.rdoRowNamesYesCSV, "rdoRowNamesYesCSV")
        Me.rdoRowNamesYesCSV.Name = "rdoRowNamesYesCSV"
        Me.rdoRowNamesYesCSV.TabStop = True
        Me.rdoRowNamesYesCSV.Tag = "Yes"
        Me.rdoRowNamesYesCSV.UseVisualStyleBackColor = True
        '
        'ucrPnlRowNamesCSV
        '
        resources.ApplyResources(Me.ucrPnlRowNamesCSV, "ucrPnlRowNamesCSV")
        Me.ucrPnlRowNamesCSV.Name = "ucrPnlRowNamesCSV"
        '
        'ucrInputHeadersCSV
        '
        Me.ucrInputHeadersCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputHeadersCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHeadersCSV, "ucrInputHeadersCSV")
        Me.ucrInputHeadersCSV.Name = "ucrInputHeadersCSV"
        '
        'ucrInputNAStringsCSV
        '
        Me.ucrInputNAStringsCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputNAStringsCSV.IsMultiline = False
        Me.ucrInputNAStringsCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNAStringsCSV, "ucrInputNAStringsCSV")
        Me.ucrInputNAStringsCSV.Name = "ucrInputNAStringsCSV"
        '
        'ucrInputDecimalCSV
        '
        Me.ucrInputDecimalCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputDecimalCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDecimalCSV, "ucrInputDecimalCSV")
        Me.ucrInputDecimalCSV.Name = "ucrInputDecimalCSV"
        '
        'ucrInputSeparatorCSV
        '
        Me.ucrInputSeparatorCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparatorCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSeparatorCSV, "ucrInputSeparatorCSV")
        Me.ucrInputSeparatorCSV.Name = "ucrInputSeparatorCSV"
        '
        'ucrInputEncodingCSV
        '
        Me.ucrInputEncodingCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputEncodingCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputEncodingCSV, "ucrInputEncodingCSV")
        Me.ucrInputEncodingCSV.Name = "ucrInputEncodingCSV"
        '
        'grpExcel
        '
        Me.grpExcel.Controls.Add(Me.ucrChkMaxRowsExcel)
        Me.grpExcel.Controls.Add(Me.ucrChkTrimWSExcel)
        Me.grpExcel.Controls.Add(Me.ucrNudRowsToSkipExcel)
        Me.grpExcel.Controls.Add(Me.ucrInputMaxRowsExcel)
        Me.grpExcel.Controls.Add(Me.lblMissingValueStringExcel)
        Me.grpExcel.Controls.Add(Me.ucrInputMissingValueStringExcel)
        Me.grpExcel.Controls.Add(Me.ucrInputNamedRegions)
        Me.grpExcel.Controls.Add(Me.lblNamedRegion)
        Me.grpExcel.Controls.Add(Me.ucrInputSelectSheetExcel)
        Me.grpExcel.Controls.Add(Me.lblRowToSkipExcel)
        Me.grpExcel.Controls.Add(Me.lblSelectSheetExcel)
        resources.ApplyResources(Me.grpExcel, "grpExcel")
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.TabStop = False
        '
        'ucrChkMaxRowsExcel
        '
        Me.ucrChkMaxRowsExcel.Checked = False
        resources.ApplyResources(Me.ucrChkMaxRowsExcel, "ucrChkMaxRowsExcel")
        Me.ucrChkMaxRowsExcel.Name = "ucrChkMaxRowsExcel"
        '
        'ucrChkTrimWSExcel
        '
        Me.ucrChkTrimWSExcel.Checked = False
        resources.ApplyResources(Me.ucrChkTrimWSExcel, "ucrChkTrimWSExcel")
        Me.ucrChkTrimWSExcel.Name = "ucrChkTrimWSExcel"
        '
        'ucrNudRowsToSkipExcel
        '
        Me.ucrNudRowsToSkipExcel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRowsToSkipExcel, "ucrNudRowsToSkipExcel")
        Me.ucrNudRowsToSkipExcel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Name = "ucrNudRowsToSkipExcel"
        Me.ucrNudRowsToSkipExcel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMaxRowsExcel
        '
        Me.ucrInputMaxRowsExcel.AddQuotesIfUnrecognised = True
        Me.ucrInputMaxRowsExcel.IsMultiline = False
        Me.ucrInputMaxRowsExcel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMaxRowsExcel, "ucrInputMaxRowsExcel")
        Me.ucrInputMaxRowsExcel.Name = "ucrInputMaxRowsExcel"
        '
        'lblMissingValueStringExcel
        '
        resources.ApplyResources(Me.lblMissingValueStringExcel, "lblMissingValueStringExcel")
        Me.lblMissingValueStringExcel.Name = "lblMissingValueStringExcel"
        '
        'ucrInputMissingValueStringExcel
        '
        Me.ucrInputMissingValueStringExcel.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingValueStringExcel.IsMultiline = False
        Me.ucrInputMissingValueStringExcel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMissingValueStringExcel, "ucrInputMissingValueStringExcel")
        Me.ucrInputMissingValueStringExcel.Name = "ucrInputMissingValueStringExcel"
        '
        'ucrInputNamedRegions
        '
        Me.ucrInputNamedRegions.AddQuotesIfUnrecognised = True
        Me.ucrInputNamedRegions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNamedRegions, "ucrInputNamedRegions")
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        '
        'lblNamedRegion
        '
        resources.ApplyResources(Me.lblNamedRegion, "lblNamedRegion")
        Me.lblNamedRegion.Name = "lblNamedRegion"
        '
        'ucrInputSelectSheetExcel
        '
        Me.ucrInputSelectSheetExcel.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectSheetExcel.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSelectSheetExcel, "ucrInputSelectSheetExcel")
        Me.ucrInputSelectSheetExcel.Name = "ucrInputSelectSheetExcel"
        '
        'lblRowToSkipExcel
        '
        resources.ApplyResources(Me.lblRowToSkipExcel, "lblRowToSkipExcel")
        Me.lblRowToSkipExcel.Name = "lblRowToSkipExcel"
        '
        'lblSelectSheetExcel
        '
        resources.ApplyResources(Me.lblSelectSheetExcel, "lblSelectSheetExcel")
        Me.lblSelectSheetExcel.Name = "lblSelectSheetExcel"
        '
        'grpRDS
        '
        Me.grpRDS.Controls.Add(Me.ucrChkOverwriteRDS)
        Me.grpRDS.Controls.Add(Me.ucrChkImportObjectsRDS)
        Me.grpRDS.Controls.Add(Me.ucrChkImportCalculationsRDS)
        Me.grpRDS.Controls.Add(Me.ucrChkImportChangesLogRDS)
        Me.grpRDS.Controls.Add(Me.ucrChkImportFiltersRDS)
        Me.grpRDS.Controls.Add(Me.ucrChkImportMetadataRDS)
        Me.grpRDS.Controls.Add(Me.ucrChkKeepExistingDataRDS)
        resources.ApplyResources(Me.grpRDS, "grpRDS")
        Me.grpRDS.Name = "grpRDS"
        Me.grpRDS.TabStop = False
        '
        'ucrChkOverwriteRDS
        '
        Me.ucrChkOverwriteRDS.Checked = False
        resources.ApplyResources(Me.ucrChkOverwriteRDS, "ucrChkOverwriteRDS")
        Me.ucrChkOverwriteRDS.Name = "ucrChkOverwriteRDS"
        '
        'ucrChkImportObjectsRDS
        '
        Me.ucrChkImportObjectsRDS.Checked = False
        resources.ApplyResources(Me.ucrChkImportObjectsRDS, "ucrChkImportObjectsRDS")
        Me.ucrChkImportObjectsRDS.Name = "ucrChkImportObjectsRDS"
        '
        'ucrChkImportCalculationsRDS
        '
        Me.ucrChkImportCalculationsRDS.Checked = False
        resources.ApplyResources(Me.ucrChkImportCalculationsRDS, "ucrChkImportCalculationsRDS")
        Me.ucrChkImportCalculationsRDS.Name = "ucrChkImportCalculationsRDS"
        '
        'ucrChkImportChangesLogRDS
        '
        Me.ucrChkImportChangesLogRDS.Checked = False
        resources.ApplyResources(Me.ucrChkImportChangesLogRDS, "ucrChkImportChangesLogRDS")
        Me.ucrChkImportChangesLogRDS.Name = "ucrChkImportChangesLogRDS"
        '
        'ucrChkImportFiltersRDS
        '
        Me.ucrChkImportFiltersRDS.Checked = False
        resources.ApplyResources(Me.ucrChkImportFiltersRDS, "ucrChkImportFiltersRDS")
        Me.ucrChkImportFiltersRDS.Name = "ucrChkImportFiltersRDS"
        '
        'ucrChkImportMetadataRDS
        '
        Me.ucrChkImportMetadataRDS.Checked = False
        resources.ApplyResources(Me.ucrChkImportMetadataRDS, "ucrChkImportMetadataRDS")
        Me.ucrChkImportMetadataRDS.Name = "ucrChkImportMetadataRDS"
        '
        'ucrChkKeepExistingDataRDS
        '
        Me.ucrChkKeepExistingDataRDS.Checked = False
        resources.ApplyResources(Me.ucrChkKeepExistingDataRDS, "ucrChkKeepExistingDataRDS")
        Me.ucrChkKeepExistingDataRDS.Name = "ucrChkKeepExistingDataRDS"
        '
        'lblCannotImport
        '
        resources.ApplyResources(Me.lblCannotImport, "lblCannotImport")
        Me.lblCannotImport.Name = "lblCannotImport"
        '
        'lblNoPreview
        '
        resources.ApplyResources(Me.lblNoPreview, "lblNoPreview")
        Me.lblNoPreview.Name = "lblNoPreview"
        '
        'lblLinesToPreview
        '
        resources.ApplyResources(Me.lblLinesToPreview, "lblLinesToPreview")
        Me.lblLinesToPreview.Name = "lblLinesToPreview"
        '
        'ucrNudPreviewLines
        '
        Me.ucrNudPreviewLines.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPreviewLines, "ucrNudPreviewLines")
        Me.ucrNudPreviewLines.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewLines.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Name = "ucrNudPreviewLines"
        Me.ucrNudPreviewLines.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrSaveFile
        '
        resources.ApplyResources(Me.ucrSaveFile, "ucrSaveFile")
        Me.ucrSaveFile.Name = "ucrSaveFile"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFilePath, "ucrInputFilePath")
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'cmdRefreshPreview
        '
        resources.ApplyResources(Me.cmdRefreshPreview, "cmdRefreshPreview")
        Me.cmdRefreshPreview.Name = "cmdRefreshPreview"
        Me.cmdRefreshPreview.UseVisualStyleBackColor = True
        '
        'dlgImportDataset
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdRefreshPreview)
        Me.Controls.Add(Me.lblLinesToPreview)
        Me.Controls.Add(Me.ucrNudPreviewLines)
        Me.Controls.Add(Me.grpExcel)
        Me.Controls.Add(Me.ucrSaveFile)
        Me.Controls.Add(Me.grpRDS)
        Me.Controls.Add(Me.lblNoPreview)
        Me.Controls.Add(Me.grpCSV)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblCannotImport)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.grdDataPreview)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.txtTextFilePreview)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.lblTextFilePreview)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgImportDataset"
        Me.Tag = "Import_Dataset"
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
        Me.grpExcel.ResumeLayout(False)
        Me.grpExcel.PerformLayout()
        Me.grpRDS.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTextFilePreview As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblEncodingCSV As Label
    Friend WithEvents lblHeadersCSV As Label
    Friend WithEvents lblRowNamesCSV As Label
    Friend WithEvents lblSeparatorCSV As Label
    Friend WithEvents lblDecimalCSV As Label
    Friend WithEvents txtTextFilePreview As TextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblLinesToSkipCSV As Label
    Friend WithEvents cmdBrowse As Button
    Friend WithEvents grpCSV As GroupBox
    Friend WithEvents grpExcel As GroupBox
    Friend WithEvents lblRowToSkipExcel As Label
    Friend WithEvents lblSelectSheetExcel As Label
    Friend WithEvents ucrInputSelectSheetExcel As ucrInputComboBox
    Friend WithEvents lblNamedRegion As Label
    Friend WithEvents ucrInputNamedRegions As ucrInputComboBox
    Friend WithEvents lblCannotImport As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputEncodingCSV As ucrInputComboBox
    Friend WithEvents ucrInputSeparatorCSV As ucrInputComboBox
    Friend WithEvents ucrInputNAStringsCSV As ucrInputTextBox
    Friend WithEvents ucrInputDecimalCSV As ucrInputComboBox
    Friend WithEvents ucrInputHeadersCSV As ucrInputComboBox
    Friend WithEvents lblMissingValueStringExcel As Label
    Friend WithEvents ucrInputMissingValueStringExcel As ucrInputTextBox
    Friend WithEvents lblNoPreview As Label
    Friend WithEvents ucrInputMaxRowsExcel As ucrInputTextBox
    Friend WithEvents ucrNudRowsToSkipExcel As ucrNud
    Friend WithEvents grpRDS As GroupBox
    Friend WithEvents ucrChkTrimWSExcel As ucrCheck
    Friend WithEvents ucrChkKeepExistingDataRDS As ucrCheck
    Friend WithEvents ucrChkOverwriteRDS As ucrCheck
    Friend WithEvents ucrChkImportObjectsRDS As ucrCheck
    Friend WithEvents ucrChkImportCalculationsRDS As ucrCheck
    Friend WithEvents ucrChkImportChangesLogRDS As ucrCheck
    Friend WithEvents ucrChkImportFiltersRDS As ucrCheck
    Friend WithEvents ucrChkImportMetadataRDS As ucrCheck
    Friend WithEvents rdoRowNamesNoCSV As RadioButton
    Friend WithEvents rdoRowNamesYesCSV As RadioButton
    Friend WithEvents ucrPnlRowNamesCSV As UcrPanel
    Friend WithEvents ucrNudLinesToSkipCSV As ucrNud
    Friend WithEvents ucrChkStringsAsFactorsCSV As ucrCheck
    Friend WithEvents ucrChkMaxRowsExcel As ucrCheck
    Friend WithEvents ucrSaveFile As ucrSave
    Friend WithEvents lblNAStringsCSV As Label
    Friend WithEvents ucrNudPreviewLines As ucrNud
    Friend WithEvents lblLinesToPreview As Label
    Friend WithEvents cmdRefreshPreview As Button
End Class
