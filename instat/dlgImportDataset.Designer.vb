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
        Me.lblInputFile = New System.Windows.Forms.Label()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEncoding = New System.Windows.Forms.Label()
        Me.lblHeaders = New System.Windows.Forms.Label()
        Me.lblRowNames = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblNAStrings = New System.Windows.Forms.Label()
        Me.txtPreview = New System.Windows.Forms.TextBox()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.ucrChkStringsAsFactors = New instat.ucrCheck()
        Me.ucrNudSkip = New instat.ucrNud()
        Me.rdoRowNamesNo = New System.Windows.Forms.RadioButton()
        Me.rdoRowNamesYes = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRowNames = New instat.UcrPanel()
        Me.ucrInputHeaders = New instat.ucrInputComboBox()
        Me.ucrInputNAStrings = New instat.ucrInputTextBox()
        Me.ucrInputDecimal = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputEncoding = New instat.ucrInputComboBox()
        Me.grpExcel = New System.Windows.Forms.GroupBox()
        Me.grpRDS = New System.Windows.Forms.GroupBox()
        Me.ucrChkOverWrite = New instat.ucrCheck()
        Me.ucrChkImportObjects = New instat.ucrCheck()
        Me.ucrChkImportCalculations = New instat.ucrCheck()
        Me.ucrChkImportChangesLog = New instat.ucrCheck()
        Me.ucrChkImportFilters = New instat.ucrCheck()
        Me.ucrChkImportMetadata = New instat.ucrCheck()
        Me.ucrChkExistingData = New instat.ucrCheck()
        Me.ucrchkColumnNames = New instat.ucrCheck()
        Me.ucrNudxlRowsToSkip = New instat.ucrNud()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ucrInputMaximumDataSize = New instat.ucrInputTextBox()
        Me.lblMissingValueString = New System.Windows.Forms.Label()
        Me.ucrInputXlMissingValueString = New instat.ucrInputTextBox()
        Me.ucrInputNamedRegions = New instat.ucrInputComboBox()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.ucrInputSheets = New instat.ucrInputComboBox()
        Me.lblRowToSkip = New System.Windows.Forms.Label()
        Me.lblSheets = New System.Windows.Forms.Label()
        Me.lblCannotImport = New System.Windows.Forms.Label()
        Me.lblNoPreview = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpCSV.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        Me.grpRDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInputFile
        '
        Me.lblInputFile.AutoSize = True
        Me.lblInputFile.Location = New System.Drawing.Point(238, 9)
        Me.lblInputFile.Name = "lblInputFile"
        Me.lblInputFile.Size = New System.Drawing.Size(94, 13)
        Me.lblInputFile.TabIndex = 0
        Me.lblInputFile.Tag = "Input_File_Preview"
        Me.lblInputFile.Text = "Input File Preview:"
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(8, 61)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(115, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Tag = "New Dataframe  Name"
        Me.lblName.Text = "New Dataframe Name:"
        '
        'lblEncoding
        '
        Me.lblEncoding.AutoSize = True
        Me.lblEncoding.Location = New System.Drawing.Point(6, 27)
        Me.lblEncoding.Name = "lblEncoding"
        Me.lblEncoding.Size = New System.Drawing.Size(52, 13)
        Me.lblEncoding.TabIndex = 3
        Me.lblEncoding.Tag = "Encoding"
        Me.lblEncoding.Text = "Encoding"
        '
        'lblHeaders
        '
        Me.lblHeaders.AutoSize = True
        Me.lblHeaders.Location = New System.Drawing.Point(6, 63)
        Me.lblHeaders.Name = "lblHeaders"
        Me.lblHeaders.Size = New System.Drawing.Size(142, 13)
        Me.lblHeaders.TabIndex = 4
        Me.lblHeaders.Tag = "Heading"
        Me.lblHeaders.Text = "First Row is Column Headers"
        '
        'lblRowNames
        '
        Me.lblRowNames.AutoSize = True
        Me.lblRowNames.Location = New System.Drawing.Point(6, 108)
        Me.lblRowNames.Name = "lblRowNames"
        Me.lblRowNames.Size = New System.Drawing.Size(133, 13)
        Me.lblRowNames.TabIndex = 5
        Me.lblRowNames.Tag = "Row_names"
        Me.lblRowNames.Text = "First Column is Row names"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(6, 160)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(53, 13)
        Me.lblSeparator.TabIndex = 6
        Me.lblSeparator.Tag = "Separator"
        Me.lblSeparator.Text = "Separator"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.Location = New System.Drawing.Point(8, 199)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimal.TabIndex = 7
        Me.lblDecimal.Tag = "Decimal"
        Me.lblDecimal.Text = "Decimal"
        '
        'lblNAStrings
        '
        Me.lblNAStrings.AutoSize = True
        Me.lblNAStrings.Location = New System.Drawing.Point(6, 231)
        Me.lblNAStrings.Name = "lblNAStrings"
        Me.lblNAStrings.Size = New System.Drawing.Size(102, 13)
        Me.lblNAStrings.TabIndex = 10
        Me.lblNAStrings.Text = "Missing Value String"
        '
        'txtPreview
        '
        Me.txtPreview.Location = New System.Drawing.Point(241, 25)
        Me.txtPreview.Multiline = True
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPreview.Size = New System.Drawing.Size(422, 205)
        Me.txtPreview.TabIndex = 22
        '
        'grdDataPreview
        '
        Me.grdDataPreview.BackColor = System.Drawing.Color.White
        Me.grdDataPreview.ColumnHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.LeadHeaderContextMenuStrip = Nothing
        Me.grdDataPreview.Location = New System.Drawing.Point(241, 256)
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
        'lblLinesToSkip
        '
        Me.lblLinesToSkip.AutoSize = True
        Me.lblLinesToSkip.Location = New System.Drawing.Point(3, 280)
        Me.lblLinesToSkip.Name = "lblLinesToSkip"
        Me.lblLinesToSkip.Size = New System.Drawing.Size(72, 13)
        Me.lblLinesToSkip.TabIndex = 30
        Me.lblLinesToSkip.Text = "Lines To Skip"
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(164, 22)
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Size = New System.Drawing.Size(66, 23)
        Me.cmdOpenDataSet.TabIndex = 33
        Me.cmdOpenDataSet.Tag = "browse"
        Me.cmdOpenDataSet.Text = "Browse"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'grpCSV
        '
        Me.grpCSV.AutoSize = True
        Me.grpCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpCSV.Controls.Add(Me.ucrChkStringsAsFactors)
        Me.grpCSV.Controls.Add(Me.ucrNudSkip)
        Me.grpCSV.Controls.Add(Me.rdoRowNamesNo)
        Me.grpCSV.Controls.Add(Me.rdoRowNamesYes)
        Me.grpCSV.Controls.Add(Me.ucrPnlRowNames)
        Me.grpCSV.Controls.Add(Me.ucrInputHeaders)
        Me.grpCSV.Controls.Add(Me.ucrInputNAStrings)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimal)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparator)
        Me.grpCSV.Controls.Add(Me.ucrInputEncoding)
        Me.grpCSV.Controls.Add(Me.lblEncoding)
        Me.grpCSV.Controls.Add(Me.lblHeaders)
        Me.grpCSV.Controls.Add(Me.lblRowNames)
        Me.grpCSV.Controls.Add(Me.lblSeparator)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkip)
        Me.grpCSV.Controls.Add(Me.lblDecimal)
        Me.grpCSV.Controls.Add(Me.lblNAStrings)
        Me.grpCSV.Location = New System.Drawing.Point(9, 88)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(219, 346)
        Me.grpCSV.TabIndex = 34
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "Import csv Options"
        Me.grpCSV.Visible = False
        '
        'ucrChkStringsAsFactors
        '
        Me.ucrChkStringsAsFactors.Checked = False
        Me.ucrChkStringsAsFactors.Location = New System.Drawing.Point(7, 307)
        Me.ucrChkStringsAsFactors.Name = "ucrChkStringsAsFactors"
        Me.ucrChkStringsAsFactors.Size = New System.Drawing.Size(206, 20)
        Me.ucrChkStringsAsFactors.TabIndex = 43
        '
        'ucrNudSkip
        '
        Me.ucrNudSkip.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSkip.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSkip.Location = New System.Drawing.Point(81, 277)
        Me.ucrNudSkip.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.ucrNudSkip.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSkip.Name = "ucrNudSkip"
        Me.ucrNudSkip.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSkip.TabIndex = 47
        Me.ucrNudSkip.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoRowNamesNo
        '
        Me.rdoRowNamesNo.AutoSize = True
        Me.rdoRowNamesNo.Location = New System.Drawing.Point(70, 130)
        Me.rdoRowNamesNo.Name = "rdoRowNamesNo"
        Me.rdoRowNamesNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoRowNamesNo.TabIndex = 46
        Me.rdoRowNamesNo.TabStop = True
        Me.rdoRowNamesNo.Tag = "No"
        Me.rdoRowNamesNo.Text = "No"
        Me.rdoRowNamesNo.UseVisualStyleBackColor = True
        '
        'rdoRowNamesYes
        '
        Me.rdoRowNamesYes.AutoSize = True
        Me.rdoRowNamesYes.Location = New System.Drawing.Point(21, 131)
        Me.rdoRowNamesYes.Name = "rdoRowNamesYes"
        Me.rdoRowNamesYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoRowNamesYes.TabIndex = 45
        Me.rdoRowNamesYes.TabStop = True
        Me.rdoRowNamesYes.Tag = "Yes"
        Me.rdoRowNamesYes.Text = "Yes"
        Me.rdoRowNamesYes.UseVisualStyleBackColor = True
        '
        'ucrPnlRowNames
        '
        Me.ucrPnlRowNames.Location = New System.Drawing.Point(15, 124)
        Me.ucrPnlRowNames.Name = "ucrPnlRowNames"
        Me.ucrPnlRowNames.Size = New System.Drawing.Size(113, 24)
        Me.ucrPnlRowNames.TabIndex = 44
        '
        'ucrInputHeaders
        '
        Me.ucrInputHeaders.AddQuotesIfUnrecognised = True
        Me.ucrInputHeaders.IsReadOnly = False
        Me.ucrInputHeaders.Location = New System.Drawing.Point(9, 82)
        Me.ucrInputHeaders.Name = "ucrInputHeaders"
        Me.ucrInputHeaders.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputHeaders.TabIndex = 43
        '
        'ucrInputNAStrings
        '
        Me.ucrInputNAStrings.AddQuotesIfUnrecognised = True
        Me.ucrInputNAStrings.IsMultiline = False
        Me.ucrInputNAStrings.IsReadOnly = False
        Me.ucrInputNAStrings.Location = New System.Drawing.Point(5, 247)
        Me.ucrInputNAStrings.Name = "ucrInputNAStrings"
        Me.ucrInputNAStrings.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNAStrings.TabIndex = 39
        '
        'ucrInputDecimal
        '
        Me.ucrInputDecimal.AddQuotesIfUnrecognised = True
        Me.ucrInputDecimal.IsReadOnly = False
        Me.ucrInputDecimal.Location = New System.Drawing.Point(74, 196)
        Me.ucrInputDecimal.Name = "ucrInputDecimal"
        Me.ucrInputDecimal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDecimal.TabIndex = 36
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.AddQuotesIfUnrecognised = True
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(74, 154)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeparator.TabIndex = 35
        '
        'ucrInputEncoding
        '
        Me.ucrInputEncoding.AddQuotesIfUnrecognised = True
        Me.ucrInputEncoding.IsReadOnly = False
        Me.ucrInputEncoding.Location = New System.Drawing.Point(62, 25)
        Me.ucrInputEncoding.Name = "ucrInputEncoding"
        Me.ucrInputEncoding.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputEncoding.TabIndex = 33
        '
        'grpExcel
        '
        Me.grpExcel.Controls.Add(Me.ucrchkColumnNames)
        Me.grpExcel.Controls.Add(Me.ucrNudxlRowsToSkip)
        Me.grpExcel.Controls.Add(Me.Label1)
        Me.grpExcel.Controls.Add(Me.ucrInputMaximumDataSize)
        Me.grpExcel.Controls.Add(Me.lblMissingValueString)
        Me.grpExcel.Controls.Add(Me.ucrInputXlMissingValueString)
        Me.grpExcel.Controls.Add(Me.ucrInputNamedRegions)
        Me.grpExcel.Controls.Add(Me.lblNamedRegion)
        Me.grpExcel.Controls.Add(Me.ucrInputSheets)
        Me.grpExcel.Controls.Add(Me.lblRowToSkip)
        Me.grpExcel.Controls.Add(Me.lblSheets)
        Me.grpExcel.Location = New System.Drawing.Point(11, 88)
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.Size = New System.Drawing.Size(217, 392)
        Me.grpExcel.TabIndex = 35
        Me.grpExcel.TabStop = False
        Me.grpExcel.Text = "Import Excel options"
        Me.grpExcel.Visible = False
        '
        'grpRDS
        '
        Me.grpRDS.Controls.Add(Me.ucrChkOverWrite)
        Me.grpRDS.Controls.Add(Me.ucrChkImportObjects)
        Me.grpRDS.Controls.Add(Me.ucrChkImportCalculations)
        Me.grpRDS.Controls.Add(Me.ucrChkImportChangesLog)
        Me.grpRDS.Controls.Add(Me.ucrChkImportFilters)
        Me.grpRDS.Controls.Add(Me.ucrChkImportMetadata)
        Me.grpRDS.Controls.Add(Me.ucrChkExistingData)
        Me.grpRDS.Location = New System.Drawing.Point(13, 88)
        Me.grpRDS.Name = "grpRDS"
        Me.grpRDS.Size = New System.Drawing.Size(217, 166)
        Me.grpRDS.TabIndex = 37
        Me.grpRDS.TabStop = False
        Me.grpRDS.Text = "Import RDS options"
        Me.grpRDS.Visible = False
        '
        'ucrChkOverWrite
        '
        Me.ucrChkOverWrite.Checked = False
        Me.ucrChkOverWrite.Location = New System.Drawing.Point(6, 134)
        Me.ucrChkOverWrite.Name = "ucrChkOverWrite"
        Me.ucrChkOverWrite.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkOverWrite.TabIndex = 49
        '
        'ucrChkImportObjects
        '
        Me.ucrChkImportObjects.Checked = False
        Me.ucrChkImportObjects.Location = New System.Drawing.Point(6, 54)
        Me.ucrChkImportObjects.Name = "ucrChkImportObjects"
        Me.ucrChkImportObjects.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportObjects.TabIndex = 48
        '
        'ucrChkImportCalculations
        '
        Me.ucrChkImportCalculations.Checked = False
        Me.ucrChkImportCalculations.Location = New System.Drawing.Point(6, 94)
        Me.ucrChkImportCalculations.Name = "ucrChkImportCalculations"
        Me.ucrChkImportCalculations.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportCalculations.TabIndex = 47
        '
        'ucrChkImportChangesLog
        '
        Me.ucrChkImportChangesLog.Checked = False
        Me.ucrChkImportChangesLog.Location = New System.Drawing.Point(6, 114)
        Me.ucrChkImportChangesLog.Name = "ucrChkImportChangesLog"
        Me.ucrChkImportChangesLog.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportChangesLog.TabIndex = 46
        '
        'ucrChkImportFilters
        '
        Me.ucrChkImportFilters.Checked = False
        Me.ucrChkImportFilters.Location = New System.Drawing.Point(6, 74)
        Me.ucrChkImportFilters.Name = "ucrChkImportFilters"
        Me.ucrChkImportFilters.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportFilters.TabIndex = 45
        '
        'ucrChkImportMetadata
        '
        Me.ucrChkImportMetadata.Checked = False
        Me.ucrChkImportMetadata.Location = New System.Drawing.Point(6, 34)
        Me.ucrChkImportMetadata.Name = "ucrChkImportMetadata"
        Me.ucrChkImportMetadata.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkImportMetadata.TabIndex = 44
        '
        'ucrChkExistingData
        '
        Me.ucrChkExistingData.Checked = False
        Me.ucrChkExistingData.Location = New System.Drawing.Point(6, 14)
        Me.ucrChkExistingData.Name = "ucrChkExistingData"
        Me.ucrChkExistingData.Size = New System.Drawing.Size(205, 20)
        Me.ucrChkExistingData.TabIndex = 43
        '
        'ucrchkColumnNames
        '
        Me.ucrchkColumnNames.Checked = False
        Me.ucrchkColumnNames.Location = New System.Drawing.Point(9, 116)
        Me.ucrchkColumnNames.Name = "ucrchkColumnNames"
        Me.ucrchkColumnNames.Size = New System.Drawing.Size(170, 20)
        Me.ucrchkColumnNames.TabIndex = 39
        '
        'ucrNudxlRowsToSkip
        '
        Me.ucrNudxlRowsToSkip.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudxlRowsToSkip.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudxlRowsToSkip.Location = New System.Drawing.Point(84, 138)
        Me.ucrNudxlRowsToSkip.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudxlRowsToSkip.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudxlRowsToSkip.Name = "ucrNudxlRowsToSkip"
        Me.ucrNudxlRowsToSkip.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudxlRowsToSkip.TabIndex = 42
        Me.ucrNudxlRowsToSkip.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Maximum Data Size"
        '
        'ucrInputMaximumDataSize
        '
        Me.ucrInputMaximumDataSize.AddQuotesIfUnrecognised = True
        Me.ucrInputMaximumDataSize.IsMultiline = False
        Me.ucrInputMaximumDataSize.IsReadOnly = False
        Me.ucrInputMaximumDataSize.Location = New System.Drawing.Point(2, 180)
        Me.ucrInputMaximumDataSize.Name = "ucrInputMaximumDataSize"
        Me.ucrInputMaximumDataSize.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMaximumDataSize.TabIndex = 40
        '
        'lblMissingValueString
        '
        Me.lblMissingValueString.AutoSize = True
        Me.lblMissingValueString.Location = New System.Drawing.Point(6, 73)
        Me.lblMissingValueString.Name = "lblMissingValueString"
        Me.lblMissingValueString.Size = New System.Drawing.Size(102, 13)
        Me.lblMissingValueString.TabIndex = 19
        Me.lblMissingValueString.Text = "Missing Value String"
        '
        'ucrInputXlMissingValueString
        '
        Me.ucrInputXlMissingValueString.AddQuotesIfUnrecognised = True
        Me.ucrInputXlMissingValueString.IsMultiline = False
        Me.ucrInputXlMissingValueString.IsReadOnly = False
        Me.ucrInputXlMissingValueString.Location = New System.Drawing.Point(10, 90)
        Me.ucrInputXlMissingValueString.Name = "ucrInputXlMissingValueString"
        Me.ucrInputXlMissingValueString.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputXlMissingValueString.TabIndex = 18
        '
        'ucrInputNamedRegions
        '
        Me.ucrInputNamedRegions.AddQuotesIfUnrecognised = True
        Me.ucrInputNamedRegions.IsReadOnly = False
        Me.ucrInputNamedRegions.Location = New System.Drawing.Point(10, 90)
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        Me.ucrInputNamedRegions.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputNamedRegions.TabIndex = 16
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
        'ucrInputSheets
        '
        Me.ucrInputSheets.AddQuotesIfUnrecognised = True
        Me.ucrInputSheets.IsReadOnly = False
        Me.ucrInputSheets.Location = New System.Drawing.Point(6, 43)
        Me.ucrInputSheets.Name = "ucrInputSheets"
        Me.ucrInputSheets.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputSheets.TabIndex = 15
        '
        'lblRowToSkip
        '
        Me.lblRowToSkip.AutoSize = True
        Me.lblRowToSkip.Location = New System.Drawing.Point(3, 140)
        Me.lblRowToSkip.Name = "lblRowToSkip"
        Me.lblRowToSkip.Size = New System.Drawing.Size(70, 13)
        Me.lblRowToSkip.TabIndex = 7
        Me.lblRowToSkip.Text = "Rows to Skip"
        '
        'lblSheets
        '
        Me.lblSheets.AutoSize = True
        Me.lblSheets.Location = New System.Drawing.Point(6, 27)
        Me.lblSheets.Name = "lblSheets"
        Me.lblSheets.Size = New System.Drawing.Size(68, 13)
        Me.lblSheets.TabIndex = 6
        Me.lblSheets.Text = "Select Sheet"
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
        Me.lblNoPreview.Size = New System.Drawing.Size(333, 18)
        Me.lblNoPreview.TabIndex = 38
        Me.lblNoPreview.Text = "Data Frame Preview not available for this file type."
        Me.lblNoPreview.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblNoPreview.Visible = False
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.AddQuotesIfUnrecognised = True
        Me.ucrInputFilePath.IsMultiline = False
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(39, 23)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputFilePath.TabIndex = 37
        '
        'ucrInputName
        '
        Me.ucrInputName.AddQuotesIfUnrecognised = True
        Me.ucrInputName.IsMultiline = False
        Me.ucrInputName.IsReadOnly = False
        Me.ucrInputName.Location = New System.Drawing.Point(128, 58)
        Me.ucrInputName.Name = "ucrInputName"
        Me.ucrInputName.Size = New System.Drawing.Size(102, 21)
        Me.ucrInputName.TabIndex = 15
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
        Me.Controls.Add(Me.grpRDS)
        Me.Controls.Add(Me.lblNoPreview)
        Me.Controls.Add(Me.grpExcel)
        Me.Controls.Add(Me.grpCSV)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblCannotImport)
        Me.Controls.Add(Me.ucrInputName)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.grdDataPreview)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.txtPreview)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.lblInputFile)
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

    Friend WithEvents lblInputFile As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEncoding As Label
    Friend WithEvents lblHeaders As Label
    Friend WithEvents lblRowNames As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblNAStrings As Label
    Friend WithEvents txtPreview As TextBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents grpCSV As GroupBox
    Friend WithEvents grpExcel As GroupBox
    Friend WithEvents lblRowToSkip As Label
    Friend WithEvents lblSheets As Label
    Friend WithEvents ucrInputName As ucrInputTextBox
    Friend WithEvents ucrInputSheets As ucrInputComboBox
    Friend WithEvents lblNamedRegion As Label
    Friend WithEvents ucrInputNamedRegions As ucrInputComboBox
    Friend WithEvents lblCannotImport As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputEncoding As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrInputNAStrings As ucrInputTextBox
    Friend WithEvents ucrInputDecimal As ucrInputComboBox
    Friend WithEvents ucrInputHeaders As ucrInputComboBox
    Friend WithEvents lblMissingValueString As Label
    Friend WithEvents ucrInputXlMissingValueString As ucrInputTextBox
    Friend WithEvents lblNoPreview As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ucrInputMaximumDataSize As ucrInputTextBox
    Friend WithEvents ucrNudxlRowsToSkip As ucrNud
    Friend WithEvents grpRDS As GroupBox
    Friend WithEvents ucrchkColumnNames As ucrCheck
    Friend WithEvents ucrChkExistingData As ucrCheck
    Friend WithEvents ucrChkOverWrite As ucrCheck
    Friend WithEvents ucrChkImportObjects As ucrCheck
    Friend WithEvents ucrChkImportCalculations As ucrCheck
    Friend WithEvents ucrChkImportChangesLog As ucrCheck
    Friend WithEvents ucrChkImportFilters As ucrCheck
    Friend WithEvents ucrChkImportMetadata As ucrCheck
    Friend WithEvents rdoRowNamesNo As RadioButton
    Friend WithEvents rdoRowNamesYes As RadioButton
    Friend WithEvents ucrPnlRowNames As UcrPanel
    Friend WithEvents ucrNudSkip As ucrNud
    Friend WithEvents ucrChkStringsAsFactors As ucrCheck
End Class
