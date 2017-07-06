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
        Me.rdoRowNamesNoCSV = New System.Windows.Forms.RadioButton()
        Me.rdoRowNamesYesCSV = New System.Windows.Forms.RadioButton()
        Me.grpExcel = New System.Windows.Forms.GroupBox()
        Me.lblMissingValueStringExcel = New System.Windows.Forms.Label()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.lblRowToSkipExcel = New System.Windows.Forms.Label()
        Me.lblSelectSheetExcel = New System.Windows.Forms.Label()
        Me.grpRDS = New System.Windows.Forms.GroupBox()
        Me.lblCannotImport = New System.Windows.Forms.Label()
        Me.lblNoPreview = New System.Windows.Forms.Label()
        Me.lblLinesToPreview = New System.Windows.Forms.Label()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.ucrChkMaxRowsExcel = New instat.ucrCheck()
        Me.ucrChkTrimWSExcel = New instat.ucrCheck()
        Me.ucrNudRowsToSkipExcel = New instat.ucrNud()
        Me.ucrInputMaxRowsExcel = New instat.ucrInputTextBox()
        Me.ucrInputMissingValueStringExcel = New instat.ucrInputTextBox()
        Me.ucrInputNamedRegions = New instat.ucrInputComboBox()
        Me.ucrInputSelectSheetExcel = New instat.ucrInputComboBox()
        Me.ucrSaveFile = New instat.ucrSave()
        Me.ucrChkOverwriteRDS = New instat.ucrCheck()
        Me.ucrChkImportObjectsRDS = New instat.ucrCheck()
        Me.ucrChkImportCalculationsRDS = New instat.ucrCheck()
        Me.ucrChkImportChangesLogRDS = New instat.ucrCheck()
        Me.ucrChkImportFiltersRDS = New instat.ucrCheck()
        Me.ucrChkImportMetadataRDS = New instat.ucrCheck()
        Me.ucrChkKeepExistingDataRDS = New instat.ucrCheck()
        Me.ucrChkStringsAsFactorsCSV = New instat.ucrCheck()
        Me.ucrNudLinesToSkipCSV = New instat.ucrNud()
        Me.ucrPnlRowNamesCSV = New instat.UcrPanel()
        Me.ucrInputHeadersCSV = New instat.ucrInputComboBox()
        Me.ucrInputNAStringsCSV = New instat.ucrInputTextBox()
        Me.ucrInputDecimalCSV = New instat.ucrInputComboBox()
        Me.ucrInputSeparatorCSV = New instat.ucrInputComboBox()
        Me.ucrInputEncodingCSV = New instat.ucrInputComboBox()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpCSV.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        Me.grpRDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTextFilePreview
        '
        Me.lblTextFilePreview.AutoSize = True
        Me.lblTextFilePreview.Location = New System.Drawing.Point(238, 9)
        Me.lblTextFilePreview.Name = "lblTextFilePreview"
        Me.lblTextFilePreview.Size = New System.Drawing.Size(91, 13)
        Me.lblTextFilePreview.TabIndex = 0
        Me.lblTextFilePreview.Tag = "Input_File_Preview"
        Me.lblTextFilePreview.Text = "Text File Preview:"
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.Location = New System.Drawing.Point(238, 239)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(106, 13)
        Me.lblDataFrame.TabIndex = 1
        Me.lblDataFrame.Tag = "Data_Frame_Preview"
        Me.lblDataFrame.Text = "Data Frame Preview:"
        '
        'lblEncodingCSV
        '
        Me.lblEncodingCSV.AutoSize = True
        Me.lblEncodingCSV.Location = New System.Drawing.Point(6, 27)
        Me.lblEncodingCSV.Name = "lblEncodingCSV"
        Me.lblEncodingCSV.Size = New System.Drawing.Size(52, 13)
        Me.lblEncodingCSV.TabIndex = 3
        Me.lblEncodingCSV.Tag = "Encoding"
        Me.lblEncodingCSV.Text = "Encoding"
        '
        'lblHeadersCSV
        '
        Me.lblHeadersCSV.AutoSize = True
        Me.lblHeadersCSV.Location = New System.Drawing.Point(6, 63)
        Me.lblHeadersCSV.Name = "lblHeadersCSV"
        Me.lblHeadersCSV.Size = New System.Drawing.Size(142, 13)
        Me.lblHeadersCSV.TabIndex = 4
        Me.lblHeadersCSV.Tag = "Heading"
        Me.lblHeadersCSV.Text = "First Row is Column Headers"
        '
        'lblRowNamesCSV
        '
        Me.lblRowNamesCSV.AutoSize = True
        Me.lblRowNamesCSV.Location = New System.Drawing.Point(6, 108)
        Me.lblRowNamesCSV.Name = "lblRowNamesCSV"
        Me.lblRowNamesCSV.Size = New System.Drawing.Size(133, 13)
        Me.lblRowNamesCSV.TabIndex = 5
        Me.lblRowNamesCSV.Tag = "Row_names"
        Me.lblRowNamesCSV.Text = "First Column is Row names"
        '
        'lblSeparatorCSV
        '
        Me.lblSeparatorCSV.AutoSize = True
        Me.lblSeparatorCSV.Location = New System.Drawing.Point(8, 160)
        Me.lblSeparatorCSV.Name = "lblSeparatorCSV"
        Me.lblSeparatorCSV.Size = New System.Drawing.Size(53, 13)
        Me.lblSeparatorCSV.TabIndex = 6
        Me.lblSeparatorCSV.Tag = "Separator"
        Me.lblSeparatorCSV.Text = "Separator"
        '
        'lblDecimalCSV
        '
        Me.lblDecimalCSV.AutoSize = True
        Me.lblDecimalCSV.Location = New System.Drawing.Point(8, 199)
        Me.lblDecimalCSV.Name = "lblDecimalCSV"
        Me.lblDecimalCSV.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimalCSV.TabIndex = 7
        Me.lblDecimalCSV.Tag = "Decimal"
        Me.lblDecimalCSV.Text = "Decimal"
        '
        'txtTextFilePreview
        '
        Me.txtTextFilePreview.Location = New System.Drawing.Point(241, 25)
        Me.txtTextFilePreview.Multiline = True
        Me.txtTextFilePreview.Name = "txtTextFilePreview"
        Me.txtTextFilePreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextFilePreview.Size = New System.Drawing.Size(422, 205)
        Me.txtTextFilePreview.TabIndex = 22
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(241, 263)
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabVisible = True
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.ShowScrollEndSpacing = True
        Me.grdDataPreview.Size = New System.Drawing.Size(422, 174)
        Me.grdDataPreview.TabIndex = 28
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.AutoSize = True
        Me.lblFileOpenPath.Location = New System.Drawing.Point(10, 25)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(26, 13)
        Me.lblFileOpenPath.TabIndex = 29
        Me.lblFileOpenPath.Text = "File:"
        '
        'lblLinesToSkipCSV
        '
        Me.lblLinesToSkipCSV.AutoSize = True
        Me.lblLinesToSkipCSV.Location = New System.Drawing.Point(8, 277)
        Me.lblLinesToSkipCSV.Name = "lblLinesToSkipCSV"
        Me.lblLinesToSkipCSV.Size = New System.Drawing.Size(72, 13)
        Me.lblLinesToSkipCSV.TabIndex = 30
        Me.lblLinesToSkipCSV.Text = "Lines To Skip"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.Location = New System.Drawing.Point(164, 22)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(66, 23)
        Me.cmdBrowse.TabIndex = 33
        Me.cmdBrowse.Tag = "browse"
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = True
        '
        'grpCSV
        '
        Me.grpCSV.AutoSize = True
        Me.grpCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
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
        Me.grpCSV.Location = New System.Drawing.Point(10, 85)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(220, 346)
        Me.grpCSV.TabIndex = 34
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "Import csv Options"
        Me.grpCSV.Visible = False
        '
        'lblNAStringsCSV
        '
        Me.lblNAStringsCSV.AutoSize = True
        Me.lblNAStringsCSV.Location = New System.Drawing.Point(8, 239)
        Me.lblNAStringsCSV.Name = "lblNAStringsCSV"
        Me.lblNAStringsCSV.Size = New System.Drawing.Size(102, 13)
        Me.lblNAStringsCSV.TabIndex = 48
        Me.lblNAStringsCSV.Text = "Missing Value String"
        '
        'rdoRowNamesNoCSV
        '
        Me.rdoRowNamesNoCSV.AutoSize = True
        Me.rdoRowNamesNoCSV.Location = New System.Drawing.Point(70, 130)
        Me.rdoRowNamesNoCSV.Name = "rdoRowNamesNoCSV"
        Me.rdoRowNamesNoCSV.Size = New System.Drawing.Size(39, 17)
        Me.rdoRowNamesNoCSV.TabIndex = 46
        Me.rdoRowNamesNoCSV.TabStop = True
        Me.rdoRowNamesNoCSV.Tag = "No"
        Me.rdoRowNamesNoCSV.Text = "No"
        Me.rdoRowNamesNoCSV.UseVisualStyleBackColor = True
        '
        'rdoRowNamesYesCSV
        '
        Me.rdoRowNamesYesCSV.AutoSize = True
        Me.rdoRowNamesYesCSV.Location = New System.Drawing.Point(21, 131)
        Me.rdoRowNamesYesCSV.Name = "rdoRowNamesYesCSV"
        Me.rdoRowNamesYesCSV.Size = New System.Drawing.Size(43, 17)
        Me.rdoRowNamesYesCSV.TabIndex = 45
        Me.rdoRowNamesYesCSV.TabStop = True
        Me.rdoRowNamesYesCSV.Tag = "Yes"
        Me.rdoRowNamesYesCSV.Text = "Yes"
        Me.rdoRowNamesYesCSV.UseVisualStyleBackColor = True
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
        Me.grpExcel.Location = New System.Drawing.Point(10, 85)
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.Size = New System.Drawing.Size(217, 392)
        Me.grpExcel.TabIndex = 35
        Me.grpExcel.TabStop = False
        Me.grpExcel.Text = "Import Excel options"
        Me.grpExcel.Visible = False
        '
        'lblMissingValueStringExcel
        '
        Me.lblMissingValueStringExcel.AutoSize = True
        Me.lblMissingValueStringExcel.Location = New System.Drawing.Point(6, 73)
        Me.lblMissingValueStringExcel.Name = "lblMissingValueStringExcel"
        Me.lblMissingValueStringExcel.Size = New System.Drawing.Size(102, 13)
        Me.lblMissingValueStringExcel.TabIndex = 19
        Me.lblMissingValueStringExcel.Text = "Missing Value String"
        '
        'lblNamedRegion
        '
        Me.lblNamedRegion.AutoSize = True
        Me.lblNamedRegion.Location = New System.Drawing.Point(6, 73)
        Me.lblNamedRegion.Name = "lblNamedRegion"
        Me.lblNamedRegion.Size = New System.Drawing.Size(90, 13)
        Me.lblNamedRegion.TabIndex = 17
        Me.lblNamedRegion.Text = "or Named Region"
        '
        'lblRowToSkipExcel
        '
        Me.lblRowToSkipExcel.AutoSize = True
        Me.lblRowToSkipExcel.Location = New System.Drawing.Point(3, 140)
        Me.lblRowToSkipExcel.Name = "lblRowToSkipExcel"
        Me.lblRowToSkipExcel.Size = New System.Drawing.Size(70, 13)
        Me.lblRowToSkipExcel.TabIndex = 7
        Me.lblRowToSkipExcel.Text = "Rows to Skip"
        '
        'lblSelectSheetExcel
        '
        Me.lblSelectSheetExcel.AutoSize = True
        Me.lblSelectSheetExcel.Location = New System.Drawing.Point(6, 27)
        Me.lblSelectSheetExcel.Name = "lblSelectSheetExcel"
        Me.lblSelectSheetExcel.Size = New System.Drawing.Size(68, 13)
        Me.lblSelectSheetExcel.TabIndex = 6
        Me.lblSelectSheetExcel.Text = "Select Sheet"
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
        Me.grpRDS.Location = New System.Drawing.Point(10, 85)
        Me.grpRDS.Name = "grpRDS"
        Me.grpRDS.Size = New System.Drawing.Size(217, 166)
        Me.grpRDS.TabIndex = 37
        Me.grpRDS.TabStop = False
        Me.grpRDS.Text = "Import RDS options"
        Me.grpRDS.Visible = False
        '
        'lblCannotImport
        '
        Me.lblCannotImport.AutoSize = True
        Me.lblCannotImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCannotImport.Location = New System.Drawing.Point(262, 316)
        Me.lblCannotImport.Name = "lblCannotImport"
        Me.lblCannotImport.Size = New System.Drawing.Size(389, 40)
        Me.lblCannotImport.TabIndex = 33
        Me.lblCannotImport.Text = "Cannot import this file with the current options. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Modify options or select a di" &
    "fferent file."
        Me.lblCannotImport.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCannotImport.Visible = False
        '
        'lblNoPreview
        '
        Me.lblNoPreview.AutoSize = True
        Me.lblNoPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoPreview.Location = New System.Drawing.Point(298, 318)
        Me.lblNoPreview.Name = "lblNoPreview"
        Me.lblNoPreview.Size = New System.Drawing.Size(302, 18)
        Me.lblNoPreview.TabIndex = 38
        Me.lblNoPreview.Text = "Preview not yet implemented for this file type."
        Me.lblNoPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNoPreview.Visible = False
        '
        'lblLinesToPreview
        '
        Me.lblLinesToPreview.AutoSize = True
        Me.lblLinesToPreview.Location = New System.Drawing.Point(519, 239)
        Me.lblLinesToPreview.Name = "lblLinesToPreview"
        Me.lblLinesToPreview.Size = New System.Drawing.Size(88, 13)
        Me.lblLinesToPreview.TabIndex = 41
        Me.lblLinesToPreview.Text = "Lines to Preview:"
        '
        'ucrNudPreviewLines
        '
        Me.ucrNudPreviewLines.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewLines.Location = New System.Drawing.Point(613, 236)
        Me.ucrNudPreviewLines.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewLines.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Name = "ucrNudPreviewLines"
        Me.ucrNudPreviewLines.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewLines.TabIndex = 40
        Me.ucrNudPreviewLines.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxRowsExcel
        '
        Me.ucrChkMaxRowsExcel.Checked = False
        Me.ucrChkMaxRowsExcel.Location = New System.Drawing.Point(6, 168)
        Me.ucrChkMaxRowsExcel.Name = "ucrChkMaxRowsExcel"
        Me.ucrChkMaxRowsExcel.Size = New System.Drawing.Size(173, 20)
        Me.ucrChkMaxRowsExcel.TabIndex = 50
        '
        'ucrChkTrimWSExcel
        '
        Me.ucrChkTrimWSExcel.Checked = False
        Me.ucrChkTrimWSExcel.Location = New System.Drawing.Point(9, 116)
        Me.ucrChkTrimWSExcel.Name = "ucrChkTrimWSExcel"
        Me.ucrChkTrimWSExcel.Size = New System.Drawing.Size(170, 20)
        Me.ucrChkTrimWSExcel.TabIndex = 39
        '
        'ucrNudRowsToSkipExcel
        '
        Me.ucrNudRowsToSkipExcel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Location = New System.Drawing.Point(84, 138)
        Me.ucrNudRowsToSkipExcel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Name = "ucrNudRowsToSkipExcel"
        Me.ucrNudRowsToSkipExcel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRowsToSkipExcel.TabIndex = 42
        Me.ucrNudRowsToSkipExcel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMaxRowsExcel
        '
        Me.ucrInputMaxRowsExcel.IsMultiline = False
        Me.ucrInputMaxRowsExcel.IsReadOnly = False
        Me.ucrInputMaxRowsExcel.Location = New System.Drawing.Point(6, 194)
        Me.ucrInputMaxRowsExcel.Name = "ucrInputMaxRowsExcel"
        Me.ucrInputMaxRowsExcel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMaxRowsExcel.TabIndex = 40
        '
        'ucrInputMissingValueStringExcel
        '
        Me.ucrInputMissingValueStringExcel.IsMultiline = False
        Me.ucrInputMissingValueStringExcel.IsReadOnly = False
        Me.ucrInputMissingValueStringExcel.Location = New System.Drawing.Point(10, 90)
        Me.ucrInputMissingValueStringExcel.Name = "ucrInputMissingValueStringExcel"
        Me.ucrInputMissingValueStringExcel.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMissingValueStringExcel.TabIndex = 18
        '
        'ucrInputNamedRegions
        '
        Me.ucrInputNamedRegions.IsReadOnly = False
        Me.ucrInputNamedRegions.Location = New System.Drawing.Point(10, 90)
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        Me.ucrInputNamedRegions.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputNamedRegions.TabIndex = 16
        '
        'ucrInputSelectSheetExcel
        '
        Me.ucrInputSelectSheetExcel.IsReadOnly = False
        Me.ucrInputSelectSheetExcel.Location = New System.Drawing.Point(6, 43)
        Me.ucrInputSelectSheetExcel.Name = "ucrInputSelectSheetExcel"
        Me.ucrInputSelectSheetExcel.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputSelectSheetExcel.TabIndex = 15
        '
        'ucrSaveFile
        '
        Me.ucrSaveFile.Location = New System.Drawing.Point(10, 52)
        Me.ucrSaveFile.Name = "ucrSaveFile"
        Me.ucrSaveFile.Size = New System.Drawing.Size(220, 24)
        Me.ucrSaveFile.TabIndex = 39
        '
        'ucrChkOverwriteRDS
        '
        Me.ucrChkOverwriteRDS.Checked = False
        Me.ucrChkOverwriteRDS.Location = New System.Drawing.Point(6, 134)
        Me.ucrChkOverwriteRDS.Name = "ucrChkOverwriteRDS"
        Me.ucrChkOverwriteRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkOverwriteRDS.TabIndex = 49
        '
        'ucrChkImportObjectsRDS
        '
        Me.ucrChkImportObjectsRDS.Checked = False
        Me.ucrChkImportObjectsRDS.Location = New System.Drawing.Point(6, 54)
        Me.ucrChkImportObjectsRDS.Name = "ucrChkImportObjectsRDS"
        Me.ucrChkImportObjectsRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportObjectsRDS.TabIndex = 48
        '
        'ucrChkImportCalculationsRDS
        '
        Me.ucrChkImportCalculationsRDS.Checked = False
        Me.ucrChkImportCalculationsRDS.Location = New System.Drawing.Point(6, 94)
        Me.ucrChkImportCalculationsRDS.Name = "ucrChkImportCalculationsRDS"
        Me.ucrChkImportCalculationsRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportCalculationsRDS.TabIndex = 47
        '
        'ucrChkImportChangesLogRDS
        '
        Me.ucrChkImportChangesLogRDS.Checked = False
        Me.ucrChkImportChangesLogRDS.Location = New System.Drawing.Point(6, 114)
        Me.ucrChkImportChangesLogRDS.Name = "ucrChkImportChangesLogRDS"
        Me.ucrChkImportChangesLogRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportChangesLogRDS.TabIndex = 46
        '
        'ucrChkImportFiltersRDS
        '
        Me.ucrChkImportFiltersRDS.Checked = False
        Me.ucrChkImportFiltersRDS.Location = New System.Drawing.Point(6, 74)
        Me.ucrChkImportFiltersRDS.Name = "ucrChkImportFiltersRDS"
        Me.ucrChkImportFiltersRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportFiltersRDS.TabIndex = 45
        '
        'ucrChkImportMetadataRDS
        '
        Me.ucrChkImportMetadataRDS.Checked = False
        Me.ucrChkImportMetadataRDS.Location = New System.Drawing.Point(6, 34)
        Me.ucrChkImportMetadataRDS.Name = "ucrChkImportMetadataRDS"
        Me.ucrChkImportMetadataRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportMetadataRDS.TabIndex = 44
        '
        'ucrChkKeepExistingDataRDS
        '
        Me.ucrChkKeepExistingDataRDS.Checked = False
        Me.ucrChkKeepExistingDataRDS.Location = New System.Drawing.Point(6, 14)
        Me.ucrChkKeepExistingDataRDS.Name = "ucrChkKeepExistingDataRDS"
        Me.ucrChkKeepExistingDataRDS.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkKeepExistingDataRDS.TabIndex = 43
        '
        'ucrChkStringsAsFactorsCSV
        '
        Me.ucrChkStringsAsFactorsCSV.Checked = False
        Me.ucrChkStringsAsFactorsCSV.Location = New System.Drawing.Point(8, 307)
        Me.ucrChkStringsAsFactorsCSV.Name = "ucrChkStringsAsFactorsCSV"
        Me.ucrChkStringsAsFactorsCSV.Size = New System.Drawing.Size(206, 20)
        Me.ucrChkStringsAsFactorsCSV.TabIndex = 43
        '
        'ucrNudLinesToSkipCSV
        '
        Me.ucrNudLinesToSkipCSV.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Location = New System.Drawing.Point(86, 275)
        Me.ucrNudLinesToSkipCSV.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLinesToSkipCSV.Name = "ucrNudLinesToSkipCSV"
        Me.ucrNudLinesToSkipCSV.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudLinesToSkipCSV.TabIndex = 47
        Me.ucrNudLinesToSkipCSV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlRowNamesCSV
        '
        Me.ucrPnlRowNamesCSV.Location = New System.Drawing.Point(15, 124)
        Me.ucrPnlRowNamesCSV.Name = "ucrPnlRowNamesCSV"
        Me.ucrPnlRowNamesCSV.Size = New System.Drawing.Size(113, 24)
        Me.ucrPnlRowNamesCSV.TabIndex = 44
        '
        'ucrInputHeadersCSV
        '
        Me.ucrInputHeadersCSV.IsReadOnly = False
        Me.ucrInputHeadersCSV.Location = New System.Drawing.Point(9, 82)
        Me.ucrInputHeadersCSV.Name = "ucrInputHeadersCSV"
        Me.ucrInputHeadersCSV.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputHeadersCSV.TabIndex = 43
        '
        'ucrInputNAStringsCSV
        '
        Me.ucrInputNAStringsCSV.IsMultiline = False
        Me.ucrInputNAStringsCSV.IsReadOnly = False
        Me.ucrInputNAStringsCSV.Location = New System.Drawing.Point(117, 236)
        Me.ucrInputNAStringsCSV.Name = "ucrInputNAStringsCSV"
        Me.ucrInputNAStringsCSV.Size = New System.Drawing.Size(94, 21)
        Me.ucrInputNAStringsCSV.TabIndex = 39
        '
        'ucrInputDecimalCSV
        '
        Me.ucrInputDecimalCSV.IsReadOnly = False
        Me.ucrInputDecimalCSV.Location = New System.Drawing.Point(74, 196)
        Me.ucrInputDecimalCSV.Name = "ucrInputDecimalCSV"
        Me.ucrInputDecimalCSV.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDecimalCSV.TabIndex = 36
        '
        'ucrInputSeparatorCSV
        '
        Me.ucrInputSeparatorCSV.IsReadOnly = False
        Me.ucrInputSeparatorCSV.Location = New System.Drawing.Point(74, 154)
        Me.ucrInputSeparatorCSV.Name = "ucrInputSeparatorCSV"
        Me.ucrInputSeparatorCSV.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeparatorCSV.TabIndex = 35
        '
        'ucrInputEncodingCSV
        '
        Me.ucrInputEncodingCSV.IsReadOnly = False
        Me.ucrInputEncodingCSV.Location = New System.Drawing.Point(62, 25)
        Me.ucrInputEncodingCSV.Name = "ucrInputEncodingCSV"
        Me.ucrInputEncodingCSV.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputEncodingCSV.TabIndex = 33
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(39, 23)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputFilePath.TabIndex = 37
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(241, 445)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 27
        '
        'dlgImportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 499)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Import_Dataset"
        Me.Text = "Import Dataset"
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
End Class
