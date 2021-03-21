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
        Me.lblSeparatorCSV = New System.Windows.Forms.Label()
        Me.lblDecimalCSV = New System.Windows.Forms.Label()
        Me.txtTextFilePreview = New System.Windows.Forms.TextBox()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblLinesToSkipCSV = New System.Windows.Forms.Label()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.ucrNudMaxRowsCSV = New instat.ucrNud()
        Me.ucrChkMaxRowsCSV = New instat.ucrCheck()
        Me.lblNAStringsCSV = New System.Windows.Forms.Label()
        Me.ucrChkStringsAsFactorsCSV = New instat.ucrCheck()
        Me.ucrNudRowsToSkipCSV = New instat.ucrNud()
        Me.ucrInputHeadersCSV = New instat.ucrInputComboBox()
        Me.ucrInputMissingValueStringCSV = New instat.ucrInputTextBox()
        Me.ucrInputDecimalCSV = New instat.ucrInputComboBox()
        Me.ucrInputSeparatorCSV = New instat.ucrInputComboBox()
        Me.ucrInputEncodingCSV = New instat.ucrInputComboBox()
        Me.grpExcel = New System.Windows.Forms.GroupBox()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.ucrChkRange = New instat.ucrCheck()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.ucrInputTextTo = New instat.ucrInputTextBox()
        Me.ucrInputTextFrom = New instat.ucrInputTextBox()
        Me.ucrNudMaxRowsExcel = New instat.ucrNud()
        Me.ucrChkColumnNamesExcel = New instat.ucrCheck()
        Me.ucrChkMaxRowsExcel = New instat.ucrCheck()
        Me.ucrChkTrimWSExcel = New instat.ucrCheck()
        Me.ucrNudRowsToSkipExcel = New instat.ucrNud()
        Me.lblMissingValueStringExcel = New System.Windows.Forms.Label()
        Me.ucrInputMissingValueStringExcel = New instat.ucrInputTextBox()
        Me.ucrInputNamedRegions = New instat.ucrInputComboBox()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.lblRowToSkipExcel = New System.Windows.Forms.Label()
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
        Me.cmdRefreshPreview = New System.Windows.Forms.Button()
        Me.grpText = New System.Windows.Forms.GroupBox()
        Me.ucrNudMaxRowsText = New instat.ucrNud()
        Me.ucrChkMaxRowsText = New instat.ucrCheck()
        Me.ucrChkColumnNamesText = New instat.ucrCheck()
        Me.lblMissingValueStringText = New System.Windows.Forms.Label()
        Me.ucrNudRowsToSkipText = New instat.ucrNud()
        Me.ucrInputMissingValueStringText = New instat.ucrInputTextBox()
        Me.lblLinesToSkipText = New System.Windows.Forms.Label()
        Me.rdoSeparatortext = New System.Windows.Forms.RadioButton()
        Me.rdoFixedWidthText = New System.Windows.Forms.RadioButton()
        Me.rdoFixedWidthWhiteSpacesText = New System.Windows.Forms.RadioButton()
        Me.clbSheets = New System.Windows.Forms.CheckedListBox()
        Me.lblSelectSheets = New System.Windows.Forms.Label()
        Me.lblImportingSheets = New System.Windows.Forms.Label()
        Me.ucrChkSheetsCheckAll = New instat.ucrCheck()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.ucrPanelFixedWidthText = New instat.UcrPanel()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSaveFile = New instat.ucrSave()
        Me.grpCSV.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        Me.grpRDS.SuspendLayout()
        Me.grpText.SuspendLayout()
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
        Me.grpCSV.Controls.Add(Me.ucrNudMaxRowsCSV)
        Me.grpCSV.Controls.Add(Me.ucrChkMaxRowsCSV)
        Me.grpCSV.Controls.Add(Me.lblNAStringsCSV)
        Me.grpCSV.Controls.Add(Me.ucrChkStringsAsFactorsCSV)
        Me.grpCSV.Controls.Add(Me.ucrNudRowsToSkipCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputHeadersCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputMissingValueStringCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimalCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparatorCSV)
        Me.grpCSV.Controls.Add(Me.ucrInputEncodingCSV)
        Me.grpCSV.Controls.Add(Me.lblEncodingCSV)
        Me.grpCSV.Controls.Add(Me.lblHeadersCSV)
        Me.grpCSV.Controls.Add(Me.lblSeparatorCSV)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkipCSV)
        Me.grpCSV.Controls.Add(Me.lblDecimalCSV)
        resources.ApplyResources(Me.grpCSV, "grpCSV")
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.TabStop = False
        '
        'ucrNudMaxRowsCSV
        '
        Me.ucrNudMaxRowsCSV.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxRowsCSV, "ucrNudMaxRowsCSV")
        Me.ucrNudMaxRowsCSV.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Name = "ucrNudMaxRowsCSV"
        Me.ucrNudMaxRowsCSV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxRowsCSV
        '
        Me.ucrChkMaxRowsCSV.Checked = False
        resources.ApplyResources(Me.ucrChkMaxRowsCSV, "ucrChkMaxRowsCSV")
        Me.ucrChkMaxRowsCSV.Name = "ucrChkMaxRowsCSV"
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
        'ucrNudRowsToSkipCSV
        '
        Me.ucrNudRowsToSkipCSV.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRowsToSkipCSV, "ucrNudRowsToSkipCSV")
        Me.ucrNudRowsToSkipCSV.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Name = "ucrNudRowsToSkipCSV"
        Me.ucrNudRowsToSkipCSV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputHeadersCSV
        '
        Me.ucrInputHeadersCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputHeadersCSV.GetSetSelectedIndex = -1
        Me.ucrInputHeadersCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHeadersCSV, "ucrInputHeadersCSV")
        Me.ucrInputHeadersCSV.Name = "ucrInputHeadersCSV"
        '
        'ucrInputMissingValueStringCSV
        '
        Me.ucrInputMissingValueStringCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingValueStringCSV.IsMultiline = False
        Me.ucrInputMissingValueStringCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMissingValueStringCSV, "ucrInputMissingValueStringCSV")
        Me.ucrInputMissingValueStringCSV.Name = "ucrInputMissingValueStringCSV"
        '
        'ucrInputDecimalCSV
        '
        Me.ucrInputDecimalCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputDecimalCSV.GetSetSelectedIndex = -1
        Me.ucrInputDecimalCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDecimalCSV, "ucrInputDecimalCSV")
        Me.ucrInputDecimalCSV.Name = "ucrInputDecimalCSV"
        '
        'ucrInputSeparatorCSV
        '
        Me.ucrInputSeparatorCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparatorCSV.GetSetSelectedIndex = -1
        Me.ucrInputSeparatorCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSeparatorCSV, "ucrInputSeparatorCSV")
        Me.ucrInputSeparatorCSV.Name = "ucrInputSeparatorCSV"
        '
        'ucrInputEncodingCSV
        '
        Me.ucrInputEncodingCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputEncodingCSV.GetSetSelectedIndex = -1
        Me.ucrInputEncodingCSV.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputEncodingCSV, "ucrInputEncodingCSV")
        Me.ucrInputEncodingCSV.Name = "ucrInputEncodingCSV"
        '
        'grpExcel
        '
        Me.grpExcel.Controls.Add(Me.lblTo)
        Me.grpExcel.Controls.Add(Me.ucrChkRange)
        Me.grpExcel.Controls.Add(Me.lblFrom)
        Me.grpExcel.Controls.Add(Me.ucrInputTextTo)
        Me.grpExcel.Controls.Add(Me.ucrInputTextFrom)
        Me.grpExcel.Controls.Add(Me.ucrNudMaxRowsExcel)
        Me.grpExcel.Controls.Add(Me.ucrChkColumnNamesExcel)
        Me.grpExcel.Controls.Add(Me.ucrChkMaxRowsExcel)
        Me.grpExcel.Controls.Add(Me.ucrChkTrimWSExcel)
        Me.grpExcel.Controls.Add(Me.ucrNudRowsToSkipExcel)
        Me.grpExcel.Controls.Add(Me.lblMissingValueStringExcel)
        Me.grpExcel.Controls.Add(Me.ucrInputMissingValueStringExcel)
        Me.grpExcel.Controls.Add(Me.ucrInputNamedRegions)
        Me.grpExcel.Controls.Add(Me.lblNamedRegion)
        Me.grpExcel.Controls.Add(Me.lblRowToSkipExcel)
        resources.ApplyResources(Me.grpExcel, "grpExcel")
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.TabStop = False
        '
        'lblTo
        '
        resources.ApplyResources(Me.lblTo, "lblTo")
        Me.lblTo.Name = "lblTo"
        '
        'ucrChkRange
        '
        Me.ucrChkRange.Checked = False
        resources.ApplyResources(Me.ucrChkRange, "ucrChkRange")
        Me.ucrChkRange.Name = "ucrChkRange"
        '
        'lblFrom
        '
        resources.ApplyResources(Me.lblFrom, "lblFrom")
        Me.lblFrom.Name = "lblFrom"
        '
        'ucrInputTextTo
        '
        Me.ucrInputTextTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTextTo.IsMultiline = False
        Me.ucrInputTextTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextTo, "ucrInputTextTo")
        Me.ucrInputTextTo.Name = "ucrInputTextTo"
        '
        'ucrInputTextFrom
        '
        Me.ucrInputTextFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputTextFrom.IsMultiline = False
        Me.ucrInputTextFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTextFrom, "ucrInputTextFrom")
        Me.ucrInputTextFrom.Name = "ucrInputTextFrom"
        '
        'ucrNudMaxRowsExcel
        '
        Me.ucrNudMaxRowsExcel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxRowsExcel, "ucrNudMaxRowsExcel")
        Me.ucrNudMaxRowsExcel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Name = "ucrNudMaxRowsExcel"
        Me.ucrNudMaxRowsExcel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColumnNamesExcel
        '
        Me.ucrChkColumnNamesExcel.Checked = False
        resources.ApplyResources(Me.ucrChkColumnNamesExcel, "ucrChkColumnNamesExcel")
        Me.ucrChkColumnNamesExcel.Name = "ucrChkColumnNamesExcel"
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
        Me.ucrInputNamedRegions.GetSetSelectedIndex = -1
        Me.ucrInputNamedRegions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputNamedRegions, "ucrInputNamedRegions")
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        '
        'lblNamedRegion
        '
        resources.ApplyResources(Me.lblNamedRegion, "lblNamedRegion")
        Me.lblNamedRegion.Name = "lblNamedRegion"
        '
        'lblRowToSkipExcel
        '
        resources.ApplyResources(Me.lblRowToSkipExcel, "lblRowToSkipExcel")
        Me.lblRowToSkipExcel.Name = "lblRowToSkipExcel"
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
        'cmdRefreshPreview
        '
        resources.ApplyResources(Me.cmdRefreshPreview, "cmdRefreshPreview")
        Me.cmdRefreshPreview.Name = "cmdRefreshPreview"
        Me.cmdRefreshPreview.UseVisualStyleBackColor = True
        '
        'grpText
        '
        Me.grpText.Controls.Add(Me.ucrNudMaxRowsText)
        Me.grpText.Controls.Add(Me.ucrChkMaxRowsText)
        Me.grpText.Controls.Add(Me.ucrChkColumnNamesText)
        Me.grpText.Controls.Add(Me.lblMissingValueStringText)
        Me.grpText.Controls.Add(Me.ucrNudRowsToSkipText)
        Me.grpText.Controls.Add(Me.ucrInputMissingValueStringText)
        Me.grpText.Controls.Add(Me.lblLinesToSkipText)
        resources.ApplyResources(Me.grpText, "grpText")
        Me.grpText.Name = "grpText"
        Me.grpText.TabStop = False
        '
        'ucrNudMaxRowsText
        '
        Me.ucrNudMaxRowsText.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsText.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaxRowsText, "ucrNudMaxRowsText")
        Me.ucrNudMaxRowsText.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRowsText.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsText.Name = "ucrNudMaxRowsText"
        Me.ucrNudMaxRowsText.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxRowsText
        '
        Me.ucrChkMaxRowsText.Checked = False
        resources.ApplyResources(Me.ucrChkMaxRowsText, "ucrChkMaxRowsText")
        Me.ucrChkMaxRowsText.Name = "ucrChkMaxRowsText"
        '
        'ucrChkColumnNamesText
        '
        Me.ucrChkColumnNamesText.Checked = False
        resources.ApplyResources(Me.ucrChkColumnNamesText, "ucrChkColumnNamesText")
        Me.ucrChkColumnNamesText.Name = "ucrChkColumnNamesText"
        '
        'lblMissingValueStringText
        '
        resources.ApplyResources(Me.lblMissingValueStringText, "lblMissingValueStringText")
        Me.lblMissingValueStringText.Name = "lblMissingValueStringText"
        '
        'ucrNudRowsToSkipText
        '
        Me.ucrNudRowsToSkipText.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudRowsToSkipText, "ucrNudRowsToSkipText")
        Me.ucrNudRowsToSkipText.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Name = "ucrNudRowsToSkipText"
        Me.ucrNudRowsToSkipText.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMissingValueStringText
        '
        Me.ucrInputMissingValueStringText.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingValueStringText.IsMultiline = False
        Me.ucrInputMissingValueStringText.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMissingValueStringText, "ucrInputMissingValueStringText")
        Me.ucrInputMissingValueStringText.Name = "ucrInputMissingValueStringText"
        '
        'lblLinesToSkipText
        '
        resources.ApplyResources(Me.lblLinesToSkipText, "lblLinesToSkipText")
        Me.lblLinesToSkipText.Name = "lblLinesToSkipText"
        '
        'rdoSeparatortext
        '
        resources.ApplyResources(Me.rdoSeparatortext, "rdoSeparatortext")
        Me.rdoSeparatortext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSeparatortext.FlatAppearance.BorderSize = 2
        Me.rdoSeparatortext.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSeparatortext.Name = "rdoSeparatortext"
        Me.rdoSeparatortext.TabStop = True
        Me.rdoSeparatortext.UseVisualStyleBackColor = True
        '
        'rdoFixedWidthText
        '
        resources.ApplyResources(Me.rdoFixedWidthText, "rdoFixedWidthText")
        Me.rdoFixedWidthText.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthText.FlatAppearance.BorderSize = 2
        Me.rdoFixedWidthText.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthText.Name = "rdoFixedWidthText"
        Me.rdoFixedWidthText.TabStop = True
        Me.rdoFixedWidthText.UseVisualStyleBackColor = True
        '
        'rdoFixedWidthWhiteSpacesText
        '
        resources.ApplyResources(Me.rdoFixedWidthWhiteSpacesText, "rdoFixedWidthWhiteSpacesText")
        Me.rdoFixedWidthWhiteSpacesText.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthWhiteSpacesText.FlatAppearance.BorderSize = 2
        Me.rdoFixedWidthWhiteSpacesText.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthWhiteSpacesText.Name = "rdoFixedWidthWhiteSpacesText"
        Me.rdoFixedWidthWhiteSpacesText.TabStop = True
        Me.rdoFixedWidthWhiteSpacesText.UseVisualStyleBackColor = True
        '
        'clbSheets
        '
        Me.clbSheets.CheckOnClick = True
        Me.clbSheets.FormattingEnabled = True
        resources.ApplyResources(Me.clbSheets, "clbSheets")
        Me.clbSheets.Name = "clbSheets"
        '
        'lblSelectSheets
        '
        resources.ApplyResources(Me.lblSelectSheets, "lblSelectSheets")
        Me.lblSelectSheets.Name = "lblSelectSheets"
        Me.lblSelectSheets.Tag = ""
        '
        'lblImportingSheets
        '
        resources.ApplyResources(Me.lblImportingSheets, "lblImportingSheets")
        Me.lblImportingSheets.Name = "lblImportingSheets"
        '
        'ucrChkSheetsCheckAll
        '
        Me.ucrChkSheetsCheckAll.Checked = False
        resources.ApplyResources(Me.ucrChkSheetsCheckAll, "ucrChkSheetsCheckAll")
        Me.ucrChkSheetsCheckAll.Name = "ucrChkSheetsCheckAll"
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
        'ucrPanelFixedWidthText
        '
        resources.ApplyResources(Me.ucrPanelFixedWidthText, "ucrPanelFixedWidthText")
        Me.ucrPanelFixedWidthText.Name = "ucrPanelFixedWidthText"
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
        'ucrSaveFile
        '
        resources.ApplyResources(Me.ucrSaveFile, "ucrSaveFile")
        Me.ucrSaveFile.Name = "ucrSaveFile"
        '
        'dlgImportDataset
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveFile)
        Me.Controls.Add(Me.lblImportingSheets)
        Me.Controls.Add(Me.ucrChkSheetsCheckAll)
        Me.Controls.Add(Me.lblSelectSheets)
        Me.Controls.Add(Me.clbSheets)
        Me.Controls.Add(Me.rdoFixedWidthWhiteSpacesText)
        Me.Controls.Add(Me.rdoSeparatortext)
        Me.Controls.Add(Me.rdoFixedWidthText)
        Me.Controls.Add(Me.grpText)
        Me.Controls.Add(Me.cmdRefreshPreview)
        Me.Controls.Add(Me.lblLinesToPreview)
        Me.Controls.Add(Me.ucrNudPreviewLines)
        Me.Controls.Add(Me.ucrPanelFixedWidthText)
        Me.Controls.Add(Me.grpExcel)
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
        Me.grpText.ResumeLayout(False)
        Me.grpText.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTextFilePreview As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblEncodingCSV As Label
    Friend WithEvents lblHeadersCSV As Label
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
    Friend WithEvents lblNamedRegion As Label
    Friend WithEvents ucrInputNamedRegions As ucrInputComboBox
    Friend WithEvents lblCannotImport As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputEncodingCSV As ucrInputComboBox
    Friend WithEvents ucrInputSeparatorCSV As ucrInputComboBox
    Friend WithEvents ucrInputMissingValueStringCSV As ucrInputTextBox
    Friend WithEvents ucrInputDecimalCSV As ucrInputComboBox
    Friend WithEvents ucrInputHeadersCSV As ucrInputComboBox
    Friend WithEvents lblMissingValueStringExcel As Label
    Friend WithEvents ucrInputMissingValueStringExcel As ucrInputTextBox
    Friend WithEvents lblNoPreview As Label
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
    Friend WithEvents ucrNudRowsToSkipCSV As ucrNud
    Friend WithEvents ucrChkStringsAsFactorsCSV As ucrCheck
    Friend WithEvents ucrChkMaxRowsExcel As ucrCheck
    Friend WithEvents lblNAStringsCSV As Label
    Friend WithEvents ucrNudPreviewLines As ucrNud
    Friend WithEvents lblLinesToPreview As Label
    Friend WithEvents cmdRefreshPreview As Button
    Friend WithEvents ucrChkColumnNamesExcel As ucrCheck
    Friend WithEvents grpText As GroupBox
    Friend WithEvents ucrChkColumnNamesText As ucrCheck
    Friend WithEvents lblMissingValueStringText As Label
    Friend WithEvents ucrNudRowsToSkipText As ucrNud
    Friend WithEvents ucrInputMissingValueStringText As ucrInputTextBox
    Friend WithEvents lblLinesToSkipText As Label
    Friend WithEvents ucrPanelFixedWidthText As UcrPanel
    Friend WithEvents ucrChkMaxRowsText As ucrCheck
    Friend WithEvents ucrChkMaxRowsCSV As ucrCheck
    Friend WithEvents ucrNudMaxRowsText As ucrNud
    Friend WithEvents ucrNudMaxRowsCSV As ucrNud
    Friend WithEvents ucrNudMaxRowsExcel As ucrNud
    Friend WithEvents rdoSeparatortext As RadioButton
    Friend WithEvents rdoFixedWidthText As RadioButton
    Friend WithEvents rdoFixedWidthWhiteSpacesText As RadioButton
    Friend WithEvents clbSheets As CheckedListBox
    Friend WithEvents lblSelectSheets As Label
    Friend WithEvents ucrChkSheetsCheckAll As ucrCheck
    Friend WithEvents lblImportingSheets As Label
    Friend WithEvents ucrChkRange As ucrCheck
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrInputTextTo As ucrInputTextBox
    Friend WithEvents ucrInputTextFrom As ucrInputTextBox
    Friend WithEvents ucrSaveFile As ucrSave
End Class
