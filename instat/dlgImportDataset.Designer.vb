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
        Me.ucrChkDropEmptyCols = New instat.ucrCheck()
        Me.ucrChkMultipleFiles = New instat.ucrCheck()
        Me.ucrSaveFile = New instat.ucrSave()
        Me.ucrNudPreviewLines = New instat.ucrNud()
        Me.ucrPanelFixedWidthText = New instat.UcrPanel()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrChkSheetsCheckAll = New instat.ucrCheck()
        Me.grpCSV.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        Me.grpRDS.SuspendLayout()
        Me.grpText.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTextFilePreview
        '
        Me.lblTextFilePreview.AutoSize = True
        Me.lblTextFilePreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTextFilePreview.Location = New System.Drawing.Point(264, 49)
        Me.lblTextFilePreview.Name = "lblTextFilePreview"
        Me.lblTextFilePreview.Size = New System.Drawing.Size(91, 13)
        Me.lblTextFilePreview.TabIndex = 7
        Me.lblTextFilePreview.Tag = "Input_File_Preview"
        Me.lblTextFilePreview.Text = "Text File Preview:"
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDataFrame.Location = New System.Drawing.Point(264, 230)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(106, 13)
        Me.lblDataFrame.TabIndex = 9
        Me.lblDataFrame.Tag = "Data_Frame_Preview"
        Me.lblDataFrame.Text = "Data Frame Preview:"
        '
        'lblEncodingCSV
        '
        Me.lblEncodingCSV.AutoSize = True
        Me.lblEncodingCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblEncodingCSV.Location = New System.Drawing.Point(3, 24)
        Me.lblEncodingCSV.Name = "lblEncodingCSV"
        Me.lblEncodingCSV.Size = New System.Drawing.Size(55, 13)
        Me.lblEncodingCSV.TabIndex = 0
        Me.lblEncodingCSV.Tag = "Encoding:"
        Me.lblEncodingCSV.Text = "Encoding:"
        '
        'lblHeadersCSV
        '
        Me.lblHeadersCSV.AutoSize = True
        Me.lblHeadersCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHeadersCSV.Location = New System.Drawing.Point(3, 55)
        Me.lblHeadersCSV.Name = "lblHeadersCSV"
        Me.lblHeadersCSV.Size = New System.Drawing.Size(143, 13)
        Me.lblHeadersCSV.TabIndex = 2
        Me.lblHeadersCSV.Tag = "Heading:"
        Me.lblHeadersCSV.Text = "First Line is Column Headers:"
        '
        'lblSeparatorCSV
        '
        Me.lblSeparatorCSV.AutoSize = True
        Me.lblSeparatorCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSeparatorCSV.Location = New System.Drawing.Point(3, 86)
        Me.lblSeparatorCSV.Name = "lblSeparatorCSV"
        Me.lblSeparatorCSV.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparatorCSV.TabIndex = 8
        Me.lblSeparatorCSV.Tag = "Separator:"
        Me.lblSeparatorCSV.Text = "Separator:"
        '
        'lblDecimalCSV
        '
        Me.lblDecimalCSV.AutoSize = True
        Me.lblDecimalCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDecimalCSV.Location = New System.Drawing.Point(3, 117)
        Me.lblDecimalCSV.Name = "lblDecimalCSV"
        Me.lblDecimalCSV.Size = New System.Drawing.Size(48, 13)
        Me.lblDecimalCSV.TabIndex = 10
        Me.lblDecimalCSV.Tag = "Decimal:"
        Me.lblDecimalCSV.Text = "Decimal:"
        '
        'txtTextFilePreview
        '
        Me.txtTextFilePreview.Location = New System.Drawing.Point(267, 66)
        Me.txtTextFilePreview.Multiline = True
        Me.txtTextFilePreview.Name = "txtTextFilePreview"
        Me.txtTextFilePreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtTextFilePreview.Size = New System.Drawing.Size(338, 150)
        Me.txtTextFilePreview.TabIndex = 8
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(267, 251)
        Me.grdDataPreview.Name = "grdDataPreview"
        Me.grdDataPreview.Readonly = True
        Me.grdDataPreview.RowHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Script = Nothing
        Me.grdDataPreview.SheetTabContextMenuStrip = Nothing
        Me.grdDataPreview.SheetTabNewButtonVisible = False
        Me.grdDataPreview.SheetTabVisible = True
        Me.grdDataPreview.SheetTabWidth = 60
        Me.grdDataPreview.ShowScrollEndSpacing = True
        Me.grdDataPreview.Size = New System.Drawing.Size(338, 153)
        Me.grdDataPreview.TabIndex = 12
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFileOpenPath.Location = New System.Drawing.Point(10, 20)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(38, 13)
        Me.lblFileOpenPath.TabIndex = 0
        Me.lblFileOpenPath.Text = "File:"
        '
        'lblLinesToSkipCSV
        '
        Me.lblLinesToSkipCSV.AutoSize = True
        Me.lblLinesToSkipCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinesToSkipCSV.Location = New System.Drawing.Point(3, 209)
        Me.lblLinesToSkipCSV.Name = "lblLinesToSkipCSV"
        Me.lblLinesToSkipCSV.Size = New System.Drawing.Size(75, 13)
        Me.lblLinesToSkipCSV.TabIndex = 14
        Me.lblLinesToSkipCSV.Text = "Lines To Skip:"
        '
        'cmdBrowse
        '
        Me.cmdBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrowse.Location = New System.Drawing.Point(408, 18)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(66, 23)
        Me.cmdBrowse.TabIndex = 2
        Me.cmdBrowse.Tag = "browse"
        Me.cmdBrowse.Text = "Browse"
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
        Me.grpCSV.Location = New System.Drawing.Point(9, 99)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(239, 268)
        Me.grpCSV.TabIndex = 4
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "Import csv Options"
        Me.grpCSV.Visible = False
        '
        'ucrNudMaxRowsCSV
        '
        Me.ucrNudMaxRowsCSV.AutoSize = True
        Me.ucrNudMaxRowsCSV.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Location = New System.Drawing.Point(158, 237)
        Me.ucrNudMaxRowsCSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudMaxRowsCSV.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsCSV.Name = "ucrNudMaxRowsCSV"
        Me.ucrNudMaxRowsCSV.Size = New System.Drawing.Size(70, 20)
        Me.ucrNudMaxRowsCSV.TabIndex = 19
        Me.ucrNudMaxRowsCSV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxRowsCSV
        '
        Me.ucrChkMaxRowsCSV.AutoSize = True
        Me.ucrChkMaxRowsCSV.Checked = False
        Me.ucrChkMaxRowsCSV.Location = New System.Drawing.Point(4, 237)
        Me.ucrChkMaxRowsCSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkMaxRowsCSV.Name = "ucrChkMaxRowsCSV"
        Me.ucrChkMaxRowsCSV.Size = New System.Drawing.Size(173, 23)
        Me.ucrChkMaxRowsCSV.TabIndex = 17
        '
        'lblNAStringsCSV
        '
        Me.lblNAStringsCSV.AutoSize = True
        Me.lblNAStringsCSV.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNAStringsCSV.Location = New System.Drawing.Point(3, 148)
        Me.lblNAStringsCSV.Name = "lblNAStringsCSV"
        Me.lblNAStringsCSV.Size = New System.Drawing.Size(105, 13)
        Me.lblNAStringsCSV.TabIndex = 12
        Me.lblNAStringsCSV.Text = "Missing Value String:"
        '
        'ucrChkStringsAsFactorsCSV
        '
        Me.ucrChkStringsAsFactorsCSV.AutoSize = True
        Me.ucrChkStringsAsFactorsCSV.Checked = False
        Me.ucrChkStringsAsFactorsCSV.Location = New System.Drawing.Point(4, 180)
        Me.ucrChkStringsAsFactorsCSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkStringsAsFactorsCSV.Name = "ucrChkStringsAsFactorsCSV"
        Me.ucrChkStringsAsFactorsCSV.Size = New System.Drawing.Size(206, 23)
        Me.ucrChkStringsAsFactorsCSV.TabIndex = 16
        '
        'ucrNudRowsToSkipCSV
        '
        Me.ucrNudRowsToSkipCSV.AutoSize = True
        Me.ucrNudRowsToSkipCSV.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Location = New System.Drawing.Point(111, 207)
        Me.ucrNudRowsToSkipCSV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudRowsToSkipCSV.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipCSV.Name = "ucrNudRowsToSkipCSV"
        Me.ucrNudRowsToSkipCSV.Size = New System.Drawing.Size(70, 20)
        Me.ucrNudRowsToSkipCSV.TabIndex = 15
        Me.ucrNudRowsToSkipCSV.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputHeadersCSV
        '
        Me.ucrInputHeadersCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputHeadersCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputHeadersCSV.GetSetSelectedIndex = -1
        Me.ucrInputHeadersCSV.IsReadOnly = False
        Me.ucrInputHeadersCSV.Location = New System.Drawing.Point(147, 52)
        Me.ucrInputHeadersCSV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputHeadersCSV.Name = "ucrInputHeadersCSV"
        Me.ucrInputHeadersCSV.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputHeadersCSV.TabIndex = 3
        '
        'ucrInputMissingValueStringCSV
        '
        Me.ucrInputMissingValueStringCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingValueStringCSV.AutoSize = True
        Me.ucrInputMissingValueStringCSV.IsMultiline = False
        Me.ucrInputMissingValueStringCSV.IsReadOnly = False
        Me.ucrInputMissingValueStringCSV.Location = New System.Drawing.Point(111, 145)
        Me.ucrInputMissingValueStringCSV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputMissingValueStringCSV.Name = "ucrInputMissingValueStringCSV"
        Me.ucrInputMissingValueStringCSV.Size = New System.Drawing.Size(117, 21)
        Me.ucrInputMissingValueStringCSV.TabIndex = 13
        '
        'ucrInputDecimalCSV
        '
        Me.ucrInputDecimalCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputDecimalCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDecimalCSV.GetSetSelectedIndex = -1
        Me.ucrInputDecimalCSV.IsReadOnly = False
        Me.ucrInputDecimalCSV.Location = New System.Drawing.Point(71, 115)
        Me.ucrInputDecimalCSV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputDecimalCSV.Name = "ucrInputDecimalCSV"
        Me.ucrInputDecimalCSV.Size = New System.Drawing.Size(157, 21)
        Me.ucrInputDecimalCSV.TabIndex = 11
        '
        'ucrInputSeparatorCSV
        '
        Me.ucrInputSeparatorCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparatorCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSeparatorCSV.GetSetSelectedIndex = -1
        Me.ucrInputSeparatorCSV.IsReadOnly = False
        Me.ucrInputSeparatorCSV.Location = New System.Drawing.Point(71, 83)
        Me.ucrInputSeparatorCSV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputSeparatorCSV.Name = "ucrInputSeparatorCSV"
        Me.ucrInputSeparatorCSV.Size = New System.Drawing.Size(157, 21)
        Me.ucrInputSeparatorCSV.TabIndex = 9
        '
        'ucrInputEncodingCSV
        '
        Me.ucrInputEncodingCSV.AddQuotesIfUnrecognised = True
        Me.ucrInputEncodingCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputEncodingCSV.GetSetSelectedIndex = -1
        Me.ucrInputEncodingCSV.IsReadOnly = False
        Me.ucrInputEncodingCSV.Location = New System.Drawing.Point(71, 20)
        Me.ucrInputEncodingCSV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputEncodingCSV.Name = "ucrInputEncodingCSV"
        Me.ucrInputEncodingCSV.Size = New System.Drawing.Size(157, 21)
        Me.ucrInputEncodingCSV.TabIndex = 1
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
        Me.grpExcel.Location = New System.Drawing.Point(9, 50)
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.Size = New System.Drawing.Size(239, 241)
        Me.grpExcel.TabIndex = 5
        Me.grpExcel.TabStop = False
        Me.grpExcel.Text = "Import Excel Options"
        Me.grpExcel.Visible = False
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTo.Location = New System.Drawing.Point(107, 168)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 32
        Me.lblTo.Text = "To:"
        '
        'ucrChkRange
        '
        Me.ucrChkRange.AutoSize = True
        Me.ucrChkRange.Checked = False
        Me.ucrChkRange.Location = New System.Drawing.Point(8, 139)
        Me.ucrChkRange.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkRange.Name = "ucrChkRange"
        Me.ucrChkRange.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkRange.TabIndex = 7
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFrom.Location = New System.Drawing.Point(7, 168)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 31
        Me.lblFrom.Text = "From:"
        '
        'ucrInputTextTo
        '
        Me.ucrInputTextTo.AddQuotesIfUnrecognised = True
        Me.ucrInputTextTo.AutoSize = True
        Me.ucrInputTextTo.IsMultiline = False
        Me.ucrInputTextTo.IsReadOnly = False
        Me.ucrInputTextTo.Location = New System.Drawing.Point(109, 184)
        Me.ucrInputTextTo.Name = "ucrInputTextTo"
        Me.ucrInputTextTo.Size = New System.Drawing.Size(62, 20)
        Me.ucrInputTextTo.TabIndex = 30
        '
        'ucrInputTextFrom
        '
        Me.ucrInputTextFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputTextFrom.AutoSize = True
        Me.ucrInputTextFrom.IsMultiline = False
        Me.ucrInputTextFrom.IsReadOnly = False
        Me.ucrInputTextFrom.Location = New System.Drawing.Point(8, 183)
        Me.ucrInputTextFrom.Name = "ucrInputTextFrom"
        Me.ucrInputTextFrom.Size = New System.Drawing.Size(62, 20)
        Me.ucrInputTextFrom.TabIndex = 29
        '
        'ucrNudMaxRowsExcel
        '
        Me.ucrNudMaxRowsExcel.AutoSize = True
        Me.ucrNudMaxRowsExcel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Location = New System.Drawing.Point(168, 214)
        Me.ucrNudMaxRowsExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudMaxRowsExcel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsExcel.Name = "ucrNudMaxRowsExcel"
        Me.ucrNudMaxRowsExcel.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudMaxRowsExcel.TabIndex = 13
        Me.ucrNudMaxRowsExcel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkColumnNamesExcel
        '
        Me.ucrChkColumnNamesExcel.AutoSize = True
        Me.ucrChkColumnNamesExcel.Checked = False
        Me.ucrChkColumnNamesExcel.Location = New System.Drawing.Point(8, 52)
        Me.ucrChkColumnNamesExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkColumnNamesExcel.Name = "ucrChkColumnNamesExcel"
        Me.ucrChkColumnNamesExcel.Size = New System.Drawing.Size(173, 23)
        Me.ucrChkColumnNamesExcel.TabIndex = 11
        '
        'ucrChkMaxRowsExcel
        '
        Me.ucrChkMaxRowsExcel.AutoSize = True
        Me.ucrChkMaxRowsExcel.Checked = False
        Me.ucrChkMaxRowsExcel.Location = New System.Drawing.Point(8, 214)
        Me.ucrChkMaxRowsExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkMaxRowsExcel.Name = "ucrChkMaxRowsExcel"
        Me.ucrChkMaxRowsExcel.Size = New System.Drawing.Size(173, 23)
        Me.ucrChkMaxRowsExcel.TabIndex = 9
        '
        'ucrChkTrimWSExcel
        '
        Me.ucrChkTrimWSExcel.AutoSize = True
        Me.ucrChkTrimWSExcel.Checked = False
        Me.ucrChkTrimWSExcel.Location = New System.Drawing.Point(8, 82)
        Me.ucrChkTrimWSExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkTrimWSExcel.Name = "ucrChkTrimWSExcel"
        Me.ucrChkTrimWSExcel.Size = New System.Drawing.Size(170, 23)
        Me.ucrChkTrimWSExcel.TabIndex = 6
        '
        'ucrNudRowsToSkipExcel
        '
        Me.ucrNudRowsToSkipExcel.AutoSize = True
        Me.ucrNudRowsToSkipExcel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Location = New System.Drawing.Point(109, 110)
        Me.ucrNudRowsToSkipExcel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudRowsToSkipExcel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipExcel.Name = "ucrNudRowsToSkipExcel"
        Me.ucrNudRowsToSkipExcel.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudRowsToSkipExcel.TabIndex = 8
        Me.ucrNudRowsToSkipExcel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMissingValueStringExcel
        '
        Me.lblMissingValueStringExcel.AutoSize = True
        Me.lblMissingValueStringExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingValueStringExcel.Location = New System.Drawing.Point(2, 29)
        Me.lblMissingValueStringExcel.Name = "lblMissingValueStringExcel"
        Me.lblMissingValueStringExcel.Size = New System.Drawing.Size(105, 13)
        Me.lblMissingValueStringExcel.TabIndex = 3
        Me.lblMissingValueStringExcel.Text = "Missing Value String:"
        '
        'ucrInputMissingValueStringExcel
        '
        Me.ucrInputMissingValueStringExcel.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingValueStringExcel.AutoSize = True
        Me.ucrInputMissingValueStringExcel.IsMultiline = False
        Me.ucrInputMissingValueStringExcel.IsReadOnly = False
        Me.ucrInputMissingValueStringExcel.Location = New System.Drawing.Point(109, 25)
        Me.ucrInputMissingValueStringExcel.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputMissingValueStringExcel.Name = "ucrInputMissingValueStringExcel"
        Me.ucrInputMissingValueStringExcel.Size = New System.Drawing.Size(121, 21)
        Me.ucrInputMissingValueStringExcel.TabIndex = 5
        '
        'ucrInputNamedRegions
        '
        Me.ucrInputNamedRegions.AddQuotesIfUnrecognised = True
        Me.ucrInputNamedRegions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputNamedRegions.GetSetSelectedIndex = -1
        Me.ucrInputNamedRegions.IsReadOnly = False
        Me.ucrInputNamedRegions.Location = New System.Drawing.Point(109, 25)
        Me.ucrInputNamedRegions.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        Me.ucrInputNamedRegions.Size = New System.Drawing.Size(121, 21)
        Me.ucrInputNamedRegions.TabIndex = 4
        '
        'lblNamedRegion
        '
        Me.lblNamedRegion.AutoSize = True
        Me.lblNamedRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNamedRegion.Location = New System.Drawing.Point(7, 29)
        Me.lblNamedRegion.Name = "lblNamedRegion"
        Me.lblNamedRegion.Size = New System.Drawing.Size(93, 13)
        Me.lblNamedRegion.TabIndex = 2
        Me.lblNamedRegion.Text = "or Named Region:"
        '
        'lblRowToSkipExcel
        '
        Me.lblRowToSkipExcel.AutoSize = True
        Me.lblRowToSkipExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRowToSkipExcel.Location = New System.Drawing.Point(3, 113)
        Me.lblRowToSkipExcel.Name = "lblRowToSkipExcel"
        Me.lblRowToSkipExcel.Size = New System.Drawing.Size(73, 13)
        Me.lblRowToSkipExcel.TabIndex = 7
        Me.lblRowToSkipExcel.Text = "Rows to Skip:"
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
        Me.grpRDS.Location = New System.Drawing.Point(9, 50)
        Me.grpRDS.Name = "grpRDS"
        Me.grpRDS.Size = New System.Drawing.Size(239, 218)
        Me.grpRDS.TabIndex = 6
        Me.grpRDS.TabStop = False
        Me.grpRDS.Text = "Import RDS Options"
        Me.grpRDS.Visible = False
        '
        'ucrChkOverwriteRDS
        '
        Me.ucrChkOverwriteRDS.AutoSize = True
        Me.ucrChkOverwriteRDS.Checked = False
        Me.ucrChkOverwriteRDS.Location = New System.Drawing.Point(8, 175)
        Me.ucrChkOverwriteRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkOverwriteRDS.Name = "ucrChkOverwriteRDS"
        Me.ucrChkOverwriteRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkOverwriteRDS.TabIndex = 6
        '
        'ucrChkImportObjectsRDS
        '
        Me.ucrChkImportObjectsRDS.AutoSize = True
        Me.ucrChkImportObjectsRDS.Checked = False
        Me.ucrChkImportObjectsRDS.Location = New System.Drawing.Point(8, 71)
        Me.ucrChkImportObjectsRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkImportObjectsRDS.Name = "ucrChkImportObjectsRDS"
        Me.ucrChkImportObjectsRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkImportObjectsRDS.TabIndex = 2
        '
        'ucrChkImportCalculationsRDS
        '
        Me.ucrChkImportCalculationsRDS.AutoSize = True
        Me.ucrChkImportCalculationsRDS.Checked = False
        Me.ucrChkImportCalculationsRDS.Location = New System.Drawing.Point(8, 123)
        Me.ucrChkImportCalculationsRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkImportCalculationsRDS.Name = "ucrChkImportCalculationsRDS"
        Me.ucrChkImportCalculationsRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkImportCalculationsRDS.TabIndex = 4
        '
        'ucrChkImportChangesLogRDS
        '
        Me.ucrChkImportChangesLogRDS.AutoSize = True
        Me.ucrChkImportChangesLogRDS.Checked = False
        Me.ucrChkImportChangesLogRDS.Location = New System.Drawing.Point(8, 149)
        Me.ucrChkImportChangesLogRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkImportChangesLogRDS.Name = "ucrChkImportChangesLogRDS"
        Me.ucrChkImportChangesLogRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkImportChangesLogRDS.TabIndex = 5
        '
        'ucrChkImportFiltersRDS
        '
        Me.ucrChkImportFiltersRDS.AutoSize = True
        Me.ucrChkImportFiltersRDS.Checked = False
        Me.ucrChkImportFiltersRDS.Location = New System.Drawing.Point(8, 97)
        Me.ucrChkImportFiltersRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkImportFiltersRDS.Name = "ucrChkImportFiltersRDS"
        Me.ucrChkImportFiltersRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkImportFiltersRDS.TabIndex = 3
        '
        'ucrChkImportMetadataRDS
        '
        Me.ucrChkImportMetadataRDS.AutoSize = True
        Me.ucrChkImportMetadataRDS.Checked = False
        Me.ucrChkImportMetadataRDS.Location = New System.Drawing.Point(8, 45)
        Me.ucrChkImportMetadataRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkImportMetadataRDS.Name = "ucrChkImportMetadataRDS"
        Me.ucrChkImportMetadataRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkImportMetadataRDS.TabIndex = 1
        '
        'ucrChkKeepExistingDataRDS
        '
        Me.ucrChkKeepExistingDataRDS.AutoSize = True
        Me.ucrChkKeepExistingDataRDS.Checked = False
        Me.ucrChkKeepExistingDataRDS.Location = New System.Drawing.Point(8, 21)
        Me.ucrChkKeepExistingDataRDS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkKeepExistingDataRDS.Name = "ucrChkKeepExistingDataRDS"
        Me.ucrChkKeepExistingDataRDS.Size = New System.Drawing.Size(205, 23)
        Me.ucrChkKeepExistingDataRDS.TabIndex = 0
        '
        'lblCannotImport
        '
        Me.lblCannotImport.AutoSize = True
        Me.lblCannotImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblCannotImport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCannotImport.Location = New System.Drawing.Point(253, 289)
        Me.lblCannotImport.Name = "lblCannotImport"
        Me.lblCannotImport.Size = New System.Drawing.Size(366, 36)
        Me.lblCannotImport.TabIndex = 13
        Me.lblCannotImport.Text = "Cannot import this file with the current options. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Modify options or select a di" &
    "fferent file."
        Me.lblCannotImport.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblCannotImport.Visible = False
        '
        'lblNoPreview
        '
        Me.lblNoPreview.AutoSize = True
        Me.lblNoPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblNoPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblNoPreview.Location = New System.Drawing.Point(286, 290)
        Me.lblNoPreview.Name = "lblNoPreview"
        Me.lblNoPreview.Size = New System.Drawing.Size(302, 18)
        Me.lblNoPreview.TabIndex = 14
        Me.lblNoPreview.Text = "Preview not yet implemented for this file type."
        Me.lblNoPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNoPreview.Visible = False
        '
        'lblLinesToPreview
        '
        Me.lblLinesToPreview.AutoSize = True
        Me.lblLinesToPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinesToPreview.Location = New System.Drawing.Point(467, 230)
        Me.lblLinesToPreview.Name = "lblLinesToPreview"
        Me.lblLinesToPreview.Size = New System.Drawing.Size(88, 13)
        Me.lblLinesToPreview.TabIndex = 10
        Me.lblLinesToPreview.Text = "Lines to Preview:"
        '
        'cmdRefreshPreview
        '
        Me.cmdRefreshPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRefreshPreview.Location = New System.Drawing.Point(511, 412)
        Me.cmdRefreshPreview.Name = "cmdRefreshPreview"
        Me.cmdRefreshPreview.Size = New System.Drawing.Size(94, 23)
        Me.cmdRefreshPreview.TabIndex = 16
        Me.cmdRefreshPreview.Text = "Refresh Preview"
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
        Me.grpText.Location = New System.Drawing.Point(9, 99)
        Me.grpText.Name = "grpText"
        Me.grpText.Size = New System.Drawing.Size(239, 132)
        Me.grpText.TabIndex = 17
        Me.grpText.TabStop = False
        Me.grpText.Text = "Import Text Options"
        Me.grpText.Visible = False
        '
        'ucrNudMaxRowsText
        '
        Me.ucrNudMaxRowsText.AutoSize = True
        Me.ucrNudMaxRowsText.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsText.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaxRowsText.Location = New System.Drawing.Point(168, 104)
        Me.ucrNudMaxRowsText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudMaxRowsText.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaxRowsText.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaxRowsText.Name = "ucrNudMaxRowsText"
        Me.ucrNudMaxRowsText.Size = New System.Drawing.Size(62, 20)
        Me.ucrNudMaxRowsText.TabIndex = 12
        Me.ucrNudMaxRowsText.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMaxRowsText
        '
        Me.ucrChkMaxRowsText.AutoSize = True
        Me.ucrChkMaxRowsText.Checked = False
        Me.ucrChkMaxRowsText.Location = New System.Drawing.Point(8, 104)
        Me.ucrChkMaxRowsText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkMaxRowsText.Name = "ucrChkMaxRowsText"
        Me.ucrChkMaxRowsText.Size = New System.Drawing.Size(173, 23)
        Me.ucrChkMaxRowsText.TabIndex = 21
        '
        'ucrChkColumnNamesText
        '
        Me.ucrChkColumnNamesText.AutoSize = True
        Me.ucrChkColumnNamesText.Checked = False
        Me.ucrChkColumnNamesText.Location = New System.Drawing.Point(8, 21)
        Me.ucrChkColumnNamesText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkColumnNamesText.Name = "ucrChkColumnNamesText"
        Me.ucrChkColumnNamesText.Size = New System.Drawing.Size(206, 23)
        Me.ucrChkColumnNamesText.TabIndex = 17
        '
        'lblMissingValueStringText
        '
        Me.lblMissingValueStringText.AutoSize = True
        Me.lblMissingValueStringText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMissingValueStringText.Location = New System.Drawing.Point(4, 47)
        Me.lblMissingValueStringText.Name = "lblMissingValueStringText"
        Me.lblMissingValueStringText.Size = New System.Drawing.Size(105, 13)
        Me.lblMissingValueStringText.TabIndex = 12
        Me.lblMissingValueStringText.Text = "Missing Value String:"
        '
        'ucrNudRowsToSkipText
        '
        Me.ucrNudRowsToSkipText.AutoSize = True
        Me.ucrNudRowsToSkipText.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Location = New System.Drawing.Point(118, 74)
        Me.ucrNudRowsToSkipText.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudRowsToSkipText.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRowsToSkipText.Name = "ucrNudRowsToSkipText"
        Me.ucrNudRowsToSkipText.Size = New System.Drawing.Size(63, 20)
        Me.ucrNudRowsToSkipText.TabIndex = 15
        Me.ucrNudRowsToSkipText.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMissingValueStringText
        '
        Me.ucrInputMissingValueStringText.AddQuotesIfUnrecognised = True
        Me.ucrInputMissingValueStringText.AutoSize = True
        Me.ucrInputMissingValueStringText.IsMultiline = False
        Me.ucrInputMissingValueStringText.IsReadOnly = False
        Me.ucrInputMissingValueStringText.Location = New System.Drawing.Point(118, 44)
        Me.ucrInputMissingValueStringText.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputMissingValueStringText.Name = "ucrInputMissingValueStringText"
        Me.ucrInputMissingValueStringText.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputMissingValueStringText.TabIndex = 13
        '
        'lblLinesToSkipText
        '
        Me.lblLinesToSkipText.AutoSize = True
        Me.lblLinesToSkipText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLinesToSkipText.Location = New System.Drawing.Point(4, 79)
        Me.lblLinesToSkipText.Name = "lblLinesToSkipText"
        Me.lblLinesToSkipText.Size = New System.Drawing.Size(75, 13)
        Me.lblLinesToSkipText.TabIndex = 14
        Me.lblLinesToSkipText.Text = "Lines To Skip:"
        '
        'rdoSeparatortext
        '
        Me.rdoSeparatortext.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSeparatortext.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSeparatortext.FlatAppearance.BorderSize = 2
        Me.rdoSeparatortext.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSeparatortext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSeparatortext.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSeparatortext.Location = New System.Drawing.Point(9, 50)
        Me.rdoSeparatortext.Name = "rdoSeparatortext"
        Me.rdoSeparatortext.Size = New System.Drawing.Size(81, 40)
        Me.rdoSeparatortext.TabIndex = 23
        Me.rdoSeparatortext.TabStop = True
        Me.rdoSeparatortext.Text = "Separator"
        Me.rdoSeparatortext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSeparatortext.UseVisualStyleBackColor = True
        '
        'rdoFixedWidthText
        '
        Me.rdoFixedWidthText.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFixedWidthText.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthText.FlatAppearance.BorderSize = 2
        Me.rdoFixedWidthText.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFixedWidthText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFixedWidthText.Location = New System.Drawing.Point(88, 50)
        Me.rdoFixedWidthText.Name = "rdoFixedWidthText"
        Me.rdoFixedWidthText.Size = New System.Drawing.Size(81, 40)
        Me.rdoFixedWidthText.TabIndex = 24
        Me.rdoFixedWidthText.TabStop = True
        Me.rdoFixedWidthText.Text = "Fixed width"
        Me.rdoFixedWidthText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFixedWidthText.UseVisualStyleBackColor = True
        '
        'rdoFixedWidthWhiteSpacesText
        '
        Me.rdoFixedWidthWhiteSpacesText.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFixedWidthWhiteSpacesText.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthWhiteSpacesText.FlatAppearance.BorderSize = 2
        Me.rdoFixedWidthWhiteSpacesText.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFixedWidthWhiteSpacesText.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFixedWidthWhiteSpacesText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFixedWidthWhiteSpacesText.Location = New System.Drawing.Point(167, 50)
        Me.rdoFixedWidthWhiteSpacesText.Name = "rdoFixedWidthWhiteSpacesText"
        Me.rdoFixedWidthWhiteSpacesText.Size = New System.Drawing.Size(81, 40)
        Me.rdoFixedWidthWhiteSpacesText.TabIndex = 25
        Me.rdoFixedWidthWhiteSpacesText.TabStop = True
        Me.rdoFixedWidthWhiteSpacesText.Text = "Fixed width" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "white spaces"
        Me.rdoFixedWidthWhiteSpacesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFixedWidthWhiteSpacesText.UseVisualStyleBackColor = True
        '
        'clbSheets
        '
        Me.clbSheets.CheckOnClick = True
        Me.clbSheets.FormattingEnabled = True
        Me.clbSheets.HorizontalScrollbar = True
        Me.clbSheets.Location = New System.Drawing.Point(267, 94)
        Me.clbSheets.Name = "clbSheets"
        Me.clbSheets.Size = New System.Drawing.Size(255, 124)
        Me.clbSheets.TabIndex = 26
        '
        'lblSelectSheets
        '
        Me.lblSelectSheets.AutoSize = True
        Me.lblSelectSheets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSelectSheets.Location = New System.Drawing.Point(267, 50)
        Me.lblSelectSheets.Name = "lblSelectSheets"
        Me.lblSelectSheets.Size = New System.Drawing.Size(76, 13)
        Me.lblSelectSheets.TabIndex = 27
        Me.lblSelectSheets.Tag = ""
        Me.lblSelectSheets.Text = "Select Sheets:"
        '
        'lblImportingSheets
        '
        Me.lblImportingSheets.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblImportingSheets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblImportingSheets.Location = New System.Drawing.Point(267, 263)
        Me.lblImportingSheets.Name = "lblImportingSheets"
        Me.lblImportingSheets.Size = New System.Drawing.Size(338, 114)
        Me.lblImportingSheets.TabIndex = 28
        Me.lblImportingSheets.Text = "Importing the following sheets:"
        Me.lblImportingSheets.Visible = False
        '
        'ucrChkDropEmptyCols
        '
        Me.ucrChkDropEmptyCols.AutoSize = True
        Me.ucrChkDropEmptyCols.Checked = False
        Me.ucrChkDropEmptyCols.Location = New System.Drawing.Point(8, 377)
        Me.ucrChkDropEmptyCols.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkDropEmptyCols.Name = "ucrChkDropEmptyCols"
        Me.ucrChkDropEmptyCols.Size = New System.Drawing.Size(250, 23)
        Me.ucrChkDropEmptyCols.TabIndex = 31
        '
        'ucrChkMultipleFiles
        '
        Me.ucrChkMultipleFiles.AutoSize = True
        Me.ucrChkMultipleFiles.Checked = False
        Me.ucrChkMultipleFiles.Location = New System.Drawing.Point(480, 20)
        Me.ucrChkMultipleFiles.Name = "ucrChkMultipleFiles"
        Me.ucrChkMultipleFiles.Size = New System.Drawing.Size(189, 23)
        Me.ucrChkMultipleFiles.TabIndex = 30
        '
        'ucrSaveFile
        '
        Me.ucrSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveFile.Location = New System.Drawing.Point(9, 412)
        Me.ucrSaveFile.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveFile.Name = "ucrSaveFile"
        Me.ucrSaveFile.Size = New System.Drawing.Size(410, 22)
        Me.ucrSaveFile.TabIndex = 29
        '
        'ucrNudPreviewLines
        '
        Me.ucrNudPreviewLines.AutoSize = True
        Me.ucrNudPreviewLines.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPreviewLines.Location = New System.Drawing.Point(555, 227)
        Me.ucrNudPreviewLines.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrNudPreviewLines.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPreviewLines.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPreviewLines.Name = "ucrNudPreviewLines"
        Me.ucrNudPreviewLines.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPreviewLines.TabIndex = 11
        Me.ucrNudPreviewLines.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPanelFixedWidthText
        '
        Me.ucrPanelFixedWidthText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPanelFixedWidthText.Location = New System.Drawing.Point(5, 47)
        Me.ucrPanelFixedWidthText.Name = "ucrPanelFixedWidthText"
        Me.ucrPanelFixedWidthText.Size = New System.Drawing.Size(253, 45)
        Me.ucrPanelFixedWidthText.TabIndex = 22
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.AutoSize = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(47, 17)
        Me.ucrInputFilePath.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ucrInputFilePath.Size = New System.Drawing.Size(352, 21)
        Me.ucrInputFilePath.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(9, 445)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(405, 52)
        Me.ucrBase.TabIndex = 15
        '
        'ucrChkSheetsCheckAll
        '
        Me.ucrChkSheetsCheckAll.AutoSize = True
        Me.ucrChkSheetsCheckAll.Checked = False
        Me.ucrChkSheetsCheckAll.Location = New System.Drawing.Point(270, 66)
        Me.ucrChkSheetsCheckAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrChkSheetsCheckAll.Name = "ucrChkSheetsCheckAll"
        Me.ucrChkSheetsCheckAll.Size = New System.Drawing.Size(129, 23)
        Me.ucrChkSheetsCheckAll.TabIndex = 22
        '
        'dlgImportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(673, 502)
        Me.Controls.Add(Me.ucrChkDropEmptyCols)
        Me.Controls.Add(Me.ucrChkMultipleFiles)
        Me.Controls.Add(Me.ucrSaveFile)
        Me.Controls.Add(Me.lblImportingSheets)
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
        Me.Controls.Add(Me.ucrChkSheetsCheckAll)
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
        Me.grpRDS.PerformLayout()
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
    Friend WithEvents ucrChkMultipleFiles As ucrCheck
    Friend WithEvents ucrChkDropEmptyCols As ucrCheck
End Class
