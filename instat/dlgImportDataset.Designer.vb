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
        Me.components = New System.ComponentModel.Container()
        Me.lblInputFile = New System.Windows.Forms.Label()
        Me.lblDataFrame = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEncoding = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblRowNames = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblQuote = New System.Windows.Forms.Label()
        Me.lblComment = New System.Windows.Forms.Label()
        Me.lblNAStrings = New System.Windows.Forms.Label()
        Me.rdoHeadingsYes = New System.Windows.Forms.RadioButton()
        Me.rdoHeadingsNo = New System.Windows.Forms.RadioButton()
        Me.txtInputFile = New System.Windows.Forms.TextBox()
        Me.chlStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.nudSkips = New System.Windows.Forms.NumericUpDown()
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputRowNames = New instat.ucrInputComboBox()
        Me.ucrInputEncoding = New instat.ucrInputComboBox()
        Me.grpExcel = New System.Windows.Forms.GroupBox()
        Me.ucrInputColsToRead = New instat.ucrInputTextBox()
        Me.ucrInputRowsToRead = New instat.ucrInputTextBox()
        Me.chkRowNames = New System.Windows.Forms.CheckBox()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.ucrInputNamedRegions = New instat.ucrInputComboBox()
        Me.ucrInputSheets = New instat.ucrInputComboBox()
        Me.lblColsToRead = New System.Windows.Forms.Label()
        Me.lblRowsToRead = New System.Windows.Forms.Label()
        Me.lblStartRow = New System.Windows.Forms.Label()
        Me.lblSheets = New System.Windows.Forms.Label()
        Me.nudStartRow = New System.Windows.Forms.NumericUpDown()
        Me.chkDates = New System.Windows.Forms.CheckBox()
        Me.chkSkipEmptyRows = New System.Windows.Forms.CheckBox()
        Me.chkColumnNames = New System.Windows.Forms.CheckBox()
        Me.chkValidateColumnNames = New System.Windows.Forms.CheckBox()
        Me.ttRowsCols = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpRDS = New System.Windows.Forms.GroupBox()
        Me.chkLogs = New System.Windows.Forms.CheckBox()
        Me.chkOverWrite = New System.Windows.Forms.CheckBox()
        Me.chkGraphics = New System.Windows.Forms.CheckBox()
        Me.chkMetadata = New System.Windows.Forms.CheckBox()
        Me.chkModel = New System.Windows.Forms.CheckBox()
        Me.chkExisting = New System.Windows.Forms.CheckBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.lblCannotImport = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputDecimal = New instat.ucrInputComboBox()
        Me.ucrInputQuote = New instat.ucrInputComboBox()
        Me.ucrInputComment = New instat.ucrInputComboBox()
        Me.ucrInputNAStrings = New instat.ucrInputTextBox()
        CType(Me.nudSkips, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCSV.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        CType(Me.nudStartRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRDS.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInputFile
        '
        Me.lblInputFile.AutoSize = True
        Me.lblInputFile.Location = New System.Drawing.Point(238, 9)
        Me.lblInputFile.Name = "lblInputFile"
        Me.lblInputFile.Size = New System.Drawing.Size(91, 13)
        Me.lblInputFile.TabIndex = 0
        Me.lblInputFile.Tag = "Input_File_Preview"
        Me.lblInputFile.Text = "Input File Preview"
        '
        'lblDataFrame
        '
        Me.lblDataFrame.AutoSize = True
        Me.lblDataFrame.Location = New System.Drawing.Point(238, 239)
        Me.lblDataFrame.Name = "lblDataFrame"
        Me.lblDataFrame.Size = New System.Drawing.Size(103, 13)
        Me.lblDataFrame.TabIndex = 1
        Me.lblDataFrame.Tag = "Data_Frame_Preview"
        Me.lblDataFrame.Text = "Data Frame Preview"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Tag = "Name"
        Me.lblName.Text = "Name"
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
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Location = New System.Drawing.Point(6, 63)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(47, 13)
        Me.lblHeading.TabIndex = 4
        Me.lblHeading.Tag = "Heading"
        Me.lblHeading.Text = "Heading"
        '
        'lblRowNames
        '
        Me.lblRowNames.AutoSize = True
        Me.lblRowNames.Location = New System.Drawing.Point(6, 99)
        Me.lblRowNames.Name = "lblRowNames"
        Me.lblRowNames.Size = New System.Drawing.Size(63, 13)
        Me.lblRowNames.TabIndex = 5
        Me.lblRowNames.Tag = "Row_names"
        Me.lblRowNames.Text = "Row names"
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(6, 146)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(53, 13)
        Me.lblSeparator.TabIndex = 6
        Me.lblSeparator.Tag = "Separator"
        Me.lblSeparator.Text = "Separator"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.Location = New System.Drawing.Point(6, 190)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(45, 13)
        Me.lblDecimal.TabIndex = 7
        Me.lblDecimal.Tag = "Decimal"
        Me.lblDecimal.Text = "Decimal"
        '
        'lblQuote
        '
        Me.lblQuote.AutoSize = True
        Me.lblQuote.Location = New System.Drawing.Point(6, 239)
        Me.lblQuote.Name = "lblQuote"
        Me.lblQuote.Size = New System.Drawing.Size(36, 13)
        Me.lblQuote.TabIndex = 8
        Me.lblQuote.Tag = "Quote"
        Me.lblQuote.Text = "Quote"
        '
        'lblComment
        '
        Me.lblComment.AutoSize = True
        Me.lblComment.Location = New System.Drawing.Point(6, 287)
        Me.lblComment.Name = "lblComment"
        Me.lblComment.Size = New System.Drawing.Size(51, 13)
        Me.lblComment.TabIndex = 9
        Me.lblComment.Tag = "Comment"
        Me.lblComment.Text = "Comment"
        '
        'lblNAStrings
        '
        Me.lblNAStrings.AutoSize = True
        Me.lblNAStrings.Location = New System.Drawing.Point(6, 320)
        Me.lblNAStrings.Name = "lblNAStrings"
        Me.lblNAStrings.Size = New System.Drawing.Size(52, 13)
        Me.lblNAStrings.TabIndex = 10
        Me.lblNAStrings.Text = "na.strings"
        '
        'rdoHeadingsYes
        '
        Me.rdoHeadingsYes.AutoSize = True
        Me.rdoHeadingsYes.Location = New System.Drawing.Point(66, 58)
        Me.rdoHeadingsYes.Name = "rdoHeadingsYes"
        Me.rdoHeadingsYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoHeadingsYes.TabIndex = 20
        Me.rdoHeadingsYes.TabStop = True
        Me.rdoHeadingsYes.Tag = "Yes"
        Me.rdoHeadingsYes.Text = "Yes"
        Me.rdoHeadingsYes.UseVisualStyleBackColor = True
        '
        'rdoHeadingsNo
        '
        Me.rdoHeadingsNo.AutoSize = True
        Me.rdoHeadingsNo.Location = New System.Drawing.Point(131, 58)
        Me.rdoHeadingsNo.Name = "rdoHeadingsNo"
        Me.rdoHeadingsNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoHeadingsNo.TabIndex = 21
        Me.rdoHeadingsNo.TabStop = True
        Me.rdoHeadingsNo.Tag = "No"
        Me.rdoHeadingsNo.Text = "No"
        Me.rdoHeadingsNo.UseVisualStyleBackColor = True
        '
        'txtInputFile
        '
        Me.txtInputFile.Location = New System.Drawing.Point(241, 25)
        Me.txtInputFile.Multiline = True
        Me.txtInputFile.Name = "txtInputFile"
        Me.txtInputFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInputFile.Size = New System.Drawing.Size(422, 205)
        Me.txtInputFile.TabIndex = 22
        '
        'chlStringsAsFactors
        '
        Me.chlStringsAsFactors.AutoSize = True
        Me.chlStringsAsFactors.Location = New System.Drawing.Point(9, 379)
        Me.chlStringsAsFactors.Name = "chlStringsAsFactors"
        Me.chlStringsAsFactors.Size = New System.Drawing.Size(107, 17)
        Me.chlStringsAsFactors.TabIndex = 26
        Me.chlStringsAsFactors.Tag = "Strings_as_factors"
        Me.chlStringsAsFactors.Text = "Strings as factors"
        Me.chlStringsAsFactors.UseVisualStyleBackColor = True
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
        Me.grdDataPreview.Size = New System.Drawing.Size(422, 174)
        Me.grdDataPreview.TabIndex = 28
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.AutoSize = True
        Me.lblFileOpenPath.Location = New System.Drawing.Point(12, 28)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(23, 13)
        Me.lblFileOpenPath.TabIndex = 29
        Me.lblFileOpenPath.Text = "File"
        '
        'lblLinesToSkip
        '
        Me.lblLinesToSkip.AutoSize = True
        Me.lblLinesToSkip.Location = New System.Drawing.Point(6, 346)
        Me.lblLinesToSkip.Name = "lblLinesToSkip"
        Me.lblLinesToSkip.Size = New System.Drawing.Size(72, 13)
        Me.lblLinesToSkip.TabIndex = 30
        Me.lblLinesToSkip.Text = "Lines To Skip"
        '
        'nudSkips
        '
        Me.nudSkips.Location = New System.Drawing.Point(152, 339)
        Me.nudSkips.Name = "nudSkips"
        Me.nudSkips.Size = New System.Drawing.Size(59, 20)
        Me.nudSkips.TabIndex = 32
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(167, 25)
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Size = New System.Drawing.Size(66, 23)
        Me.cmdOpenDataSet.TabIndex = 33
        Me.cmdOpenDataSet.Tag = "select_file"
        Me.cmdOpenDataSet.Text = "Select File"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'grpCSV
        '
        Me.grpCSV.AutoSize = True
        Me.grpCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpCSV.Controls.Add(Me.ucrInputNAStrings)
        Me.grpCSV.Controls.Add(Me.ucrInputComment)
        Me.grpCSV.Controls.Add(Me.ucrInputQuote)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimal)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparator)
        Me.grpCSV.Controls.Add(Me.ucrInputRowNames)
        Me.grpCSV.Controls.Add(Me.ucrInputEncoding)
        Me.grpCSV.Controls.Add(Me.lblEncoding)
        Me.grpCSV.Controls.Add(Me.lblHeading)
        Me.grpCSV.Controls.Add(Me.nudSkips)
        Me.grpCSV.Controls.Add(Me.lblRowNames)
        Me.grpCSV.Controls.Add(Me.lblSeparator)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkip)
        Me.grpCSV.Controls.Add(Me.lblDecimal)
        Me.grpCSV.Controls.Add(Me.lblQuote)
        Me.grpCSV.Controls.Add(Me.lblComment)
        Me.grpCSV.Controls.Add(Me.lblNAStrings)
        Me.grpCSV.Controls.Add(Me.chlStringsAsFactors)
        Me.grpCSV.Controls.Add(Me.rdoHeadingsNo)
        Me.grpCSV.Controls.Add(Me.rdoHeadingsYes)
        Me.grpCSV.Location = New System.Drawing.Point(15, 87)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(217, 415)
        Me.grpCSV.TabIndex = 34
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "Import csv Options"
        Me.grpCSV.Visible = False
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.Location = New System.Drawing.Point(74, 140)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeparator.TabIndex = 35
        '
        'ucrInputRowNames
        '
        Me.ucrInputRowNames.Location = New System.Drawing.Point(74, 96)
        Me.ucrInputRowNames.Name = "ucrInputRowNames"
        Me.ucrInputRowNames.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputRowNames.TabIndex = 34
        '
        'ucrInputEncoding
        '
        Me.ucrInputEncoding.Location = New System.Drawing.Point(62, 25)
        Me.ucrInputEncoding.Name = "ucrInputEncoding"
        Me.ucrInputEncoding.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputEncoding.TabIndex = 33
        '
        'grpExcel
        '
        Me.grpExcel.Controls.Add(Me.ucrInputColsToRead)
        Me.grpExcel.Controls.Add(Me.ucrInputRowsToRead)
        Me.grpExcel.Controls.Add(Me.chkRowNames)
        Me.grpExcel.Controls.Add(Me.lblNamedRegion)
        Me.grpExcel.Controls.Add(Me.ucrInputNamedRegions)
        Me.grpExcel.Controls.Add(Me.ucrInputSheets)
        Me.grpExcel.Controls.Add(Me.lblColsToRead)
        Me.grpExcel.Controls.Add(Me.lblRowsToRead)
        Me.grpExcel.Controls.Add(Me.lblStartRow)
        Me.grpExcel.Controls.Add(Me.lblSheets)
        Me.grpExcel.Controls.Add(Me.nudStartRow)
        Me.grpExcel.Controls.Add(Me.chkDates)
        Me.grpExcel.Controls.Add(Me.chkSkipEmptyRows)
        Me.grpExcel.Controls.Add(Me.chkColumnNames)
        Me.grpExcel.Controls.Add(Me.chkValidateColumnNames)
        Me.grpExcel.Location = New System.Drawing.Point(15, 87)
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.Size = New System.Drawing.Size(217, 392)
        Me.grpExcel.TabIndex = 35
        Me.grpExcel.TabStop = False
        Me.grpExcel.Text = "Import Excel options"
        Me.grpExcel.Visible = False
        '
        'ucrInputColsToRead
        '
        Me.ucrInputColsToRead.Location = New System.Drawing.Point(6, 358)
        Me.ucrInputColsToRead.Name = "ucrInputColsToRead"
        Me.ucrInputColsToRead.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputColsToRead.TabIndex = 38
        '
        'ucrInputRowsToRead
        '
        Me.ucrInputRowsToRead.Location = New System.Drawing.Point(6, 306)
        Me.ucrInputRowsToRead.Name = "ucrInputRowsToRead"
        Me.ucrInputRowsToRead.Size = New System.Drawing.Size(47, 21)
        Me.ucrInputRowsToRead.TabIndex = 37
        '
        'chkRowNames
        '
        Me.chkRowNames.AutoSize = True
        Me.chkRowNames.Location = New System.Drawing.Point(6, 171)
        Me.chkRowNames.Name = "chkRowNames"
        Me.chkRowNames.Size = New System.Drawing.Size(154, 17)
        Me.chkRowNames.TabIndex = 18
        Me.chkRowNames.Text = "First Column is Row Names"
        Me.chkRowNames.UseVisualStyleBackColor = True
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
        'ucrInputNamedRegions
        '
        Me.ucrInputNamedRegions.Location = New System.Drawing.Point(6, 90)
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        Me.ucrInputNamedRegions.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputNamedRegions.TabIndex = 16
        '
        'ucrInputSheets
        '
        Me.ucrInputSheets.Location = New System.Drawing.Point(6, 43)
        Me.ucrInputSheets.Name = "ucrInputSheets"
        Me.ucrInputSheets.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputSheets.TabIndex = 15
        '
        'lblColsToRead
        '
        Me.lblColsToRead.AutoSize = True
        Me.lblColsToRead.Location = New System.Drawing.Point(6, 341)
        Me.lblColsToRead.Name = "lblColsToRead"
        Me.lblColsToRead.Size = New System.Drawing.Size(136, 13)
        Me.lblColsToRead.TabIndex = 12
        Me.lblColsToRead.Text = "Columns to Read, e.g. 1:10"
        '
        'lblRowsToRead
        '
        Me.lblRowsToRead.AutoSize = True
        Me.lblRowsToRead.Location = New System.Drawing.Point(3, 287)
        Me.lblRowsToRead.Name = "lblRowsToRead"
        Me.lblRowsToRead.Size = New System.Drawing.Size(123, 13)
        Me.lblRowsToRead.TabIndex = 11
        Me.lblRowsToRead.Text = "Rows to Read, e.g. 1:10"
        '
        'lblStartRow
        '
        Me.lblStartRow.AutoSize = True
        Me.lblStartRow.Location = New System.Drawing.Point(3, 241)
        Me.lblStartRow.Name = "lblStartRow"
        Me.lblStartRow.Size = New System.Drawing.Size(54, 13)
        Me.lblStartRow.TabIndex = 7
        Me.lblStartRow.Text = "Start Row"
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
        'nudStartRow
        '
        Me.nudStartRow.Location = New System.Drawing.Point(6, 257)
        Me.nudStartRow.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudStartRow.Name = "nudStartRow"
        Me.nudStartRow.Size = New System.Drawing.Size(49, 20)
        Me.nudStartRow.TabIndex = 5
        Me.nudStartRow.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'chkDates
        '
        Me.chkDates.AutoSize = True
        Me.chkDates.Location = New System.Drawing.Point(6, 215)
        Me.chkDates.Name = "chkDates"
        Me.chkDates.Size = New System.Drawing.Size(87, 17)
        Me.chkDates.TabIndex = 4
        Me.chkDates.Text = "Detect dates"
        Me.chkDates.UseVisualStyleBackColor = True
        '
        'chkSkipEmptyRows
        '
        Me.chkSkipEmptyRows.AutoSize = True
        Me.chkSkipEmptyRows.Location = New System.Drawing.Point(6, 194)
        Me.chkSkipEmptyRows.Name = "chkSkipEmptyRows"
        Me.chkSkipEmptyRows.Size = New System.Drawing.Size(109, 17)
        Me.chkSkipEmptyRows.TabIndex = 3
        Me.chkSkipEmptyRows.Text = "Skip Empty Rows"
        Me.chkSkipEmptyRows.UseVisualStyleBackColor = True
        '
        'chkColumnNames
        '
        Me.chkColumnNames.AutoSize = True
        Me.chkColumnNames.Location = New System.Drawing.Point(6, 149)
        Me.chkColumnNames.Name = "chkColumnNames"
        Me.chkColumnNames.Size = New System.Drawing.Size(154, 17)
        Me.chkColumnNames.TabIndex = 2
        Me.chkColumnNames.Text = "First Row is Column Names"
        Me.chkColumnNames.UseVisualStyleBackColor = True
        '
        'chkValidateColumnNames
        '
        Me.chkValidateColumnNames.AutoSize = True
        Me.chkValidateColumnNames.Location = New System.Drawing.Point(6, 126)
        Me.chkValidateColumnNames.Name = "chkValidateColumnNames"
        Me.chkValidateColumnNames.Size = New System.Drawing.Size(138, 17)
        Me.chkValidateColumnNames.TabIndex = 1
        Me.chkValidateColumnNames.Text = "Validate Column Names"
        Me.chkValidateColumnNames.UseVisualStyleBackColor = True
        '
        'grpRDS
        '
        Me.grpRDS.Controls.Add(Me.chkLogs)
        Me.grpRDS.Controls.Add(Me.chkOverWrite)
        Me.grpRDS.Controls.Add(Me.chkGraphics)
        Me.grpRDS.Controls.Add(Me.chkMetadata)
        Me.grpRDS.Controls.Add(Me.chkModel)
        Me.grpRDS.Controls.Add(Me.chkExisting)
        Me.grpRDS.Location = New System.Drawing.Point(15, 87)
        Me.grpRDS.Name = "grpRDS"
        Me.grpRDS.Size = New System.Drawing.Size(148, 131)
        Me.grpRDS.TabIndex = 36
        Me.grpRDS.TabStop = False
        Me.grpRDS.Text = "Import RDS options"
        Me.grpRDS.Visible = False
        '
        'chkLogs
        '
        Me.chkLogs.AutoSize = True
        Me.chkLogs.Location = New System.Drawing.Point(3, 90)
        Me.chkLogs.Name = "chkLogs"
        Me.chkLogs.Size = New System.Drawing.Size(111, 17)
        Me.chkLogs.TabIndex = 5
        Me.chkLogs.Text = "Keep existing logs"
        Me.chkLogs.UseVisualStyleBackColor = True
        '
        'chkOverWrite
        '
        Me.chkOverWrite.AutoSize = True
        Me.chkOverWrite.Location = New System.Drawing.Point(3, 109)
        Me.chkOverWrite.Name = "chkOverWrite"
        Me.chkOverWrite.Size = New System.Drawing.Size(109, 17)
        Me.chkOverWrite.TabIndex = 4
        Me.chkOverWrite.Text = "Overwrite existing"
        Me.chkOverWrite.UseVisualStyleBackColor = True
        '
        'chkGraphics
        '
        Me.chkGraphics.AutoSize = True
        Me.chkGraphics.Location = New System.Drawing.Point(3, 73)
        Me.chkGraphics.Name = "chkGraphics"
        Me.chkGraphics.Size = New System.Drawing.Size(132, 17)
        Me.chkGraphics.TabIndex = 3
        Me.chkGraphics.Text = "Keep existing graphics"
        Me.chkGraphics.UseVisualStyleBackColor = True
        '
        'chkMetadata
        '
        Me.chkMetadata.AutoSize = True
        Me.chkMetadata.Location = New System.Drawing.Point(3, 36)
        Me.chkMetadata.Name = "chkMetadata"
        Me.chkMetadata.Size = New System.Drawing.Size(136, 17)
        Me.chkMetadata.TabIndex = 2
        Me.chkMetadata.Text = "Keep existing metadata"
        Me.chkMetadata.UseVisualStyleBackColor = True
        '
        'chkModel
        '
        Me.chkModel.AutoSize = True
        Me.chkModel.Location = New System.Drawing.Point(3, 55)
        Me.chkModel.Name = "chkModel"
        Me.chkModel.Size = New System.Drawing.Size(120, 17)
        Me.chkModel.TabIndex = 1
        Me.chkModel.Text = "Keep existing model"
        Me.chkModel.UseVisualStyleBackColor = True
        '
        'chkExisting
        '
        Me.chkExisting.AutoSize = True
        Me.chkExisting.Location = New System.Drawing.Point(3, 19)
        Me.chkExisting.Name = "chkExisting"
        Me.chkExisting.Size = New System.Drawing.Size(113, 17)
        Me.chkExisting.TabIndex = 0
        Me.chkExisting.Text = "Keep existing data"
        Me.chkExisting.UseVisualStyleBackColor = True
        '
        'ucrInputName
        '
        Me.ucrInputName.Location = New System.Drawing.Point(50, 56)
        Me.ucrInputName.Name = "ucrInputName"
        Me.ucrInputName.Size = New System.Drawing.Size(182, 21)
        Me.ucrInputName.TabIndex = 15
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(241, 445)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 53)
        Me.ucrBase.TabIndex = 27
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
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.Location = New System.Drawing.Point(39, 25)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputFilePath.TabIndex = 37
        '
        'ucrInputDecimal
        '
        Me.ucrInputDecimal.Location = New System.Drawing.Point(74, 182)
        Me.ucrInputDecimal.Name = "ucrInputDecimal"
        Me.ucrInputDecimal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDecimal.TabIndex = 36
        '
        'ucrInputQuote
        '
        Me.ucrInputQuote.Location = New System.Drawing.Point(74, 229)
        Me.ucrInputQuote.Name = "ucrInputQuote"
        Me.ucrInputQuote.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputQuote.TabIndex = 37
        '
        'ucrInputComment
        '
        Me.ucrInputComment.Location = New System.Drawing.Point(74, 280)
        Me.ucrInputComment.Name = "ucrInputComment"
        Me.ucrInputComment.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputComment.TabIndex = 38
        '
        'ucrInputNAStrings
        '
        Me.ucrInputNAStrings.Location = New System.Drawing.Point(74, 311)
        Me.ucrInputNAStrings.Name = "ucrInputNAStrings"
        Me.ucrInputNAStrings.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNAStrings.TabIndex = 39
        '
        'dlgImportDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 499)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.lblCannotImport)
        Me.Controls.Add(Me.grpCSV)
        Me.Controls.Add(Me.ucrInputName)
        Me.Controls.Add(Me.grpExcel)
        Me.Controls.Add(Me.grpRDS)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.grdDataPreview)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.txtInputFile)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblDataFrame)
        Me.Controls.Add(Me.lblInputFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgImportDataset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Import_Dataset"
        Me.Text = "Import Dataset"
        CType(Me.nudSkips, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
        Me.grpExcel.ResumeLayout(False)
        Me.grpExcel.PerformLayout()
        CType(Me.nudStartRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRDS.ResumeLayout(False)
        Me.grpRDS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInputFile As Label
    Friend WithEvents lblDataFrame As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEncoding As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblRowNames As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblQuote As Label
    Friend WithEvents lblComment As Label
    Friend WithEvents lblNAStrings As Label
    Friend WithEvents rdoHeadingsYes As RadioButton
    Friend WithEvents rdoHeadingsNo As RadioButton
    Friend WithEvents txtInputFile As TextBox
    Friend WithEvents chlStringsAsFactors As CheckBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents nudSkips As NumericUpDown
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents grpCSV As GroupBox
    Friend WithEvents grpExcel As GroupBox
    Friend WithEvents nudStartRow As NumericUpDown
    Friend WithEvents chkDates As CheckBox
    Friend WithEvents chkSkipEmptyRows As CheckBox
    Friend WithEvents chkColumnNames As CheckBox
    Friend WithEvents chkValidateColumnNames As CheckBox
    Friend WithEvents lblStartRow As Label
    Friend WithEvents lblSheets As Label
    Friend WithEvents lblColsToRead As Label
    Friend WithEvents lblRowsToRead As Label
    Friend WithEvents ttRowsCols As ToolTip
    Friend WithEvents grpRDS As GroupBox
    Friend WithEvents chkMetadata As CheckBox
    Friend WithEvents chkModel As CheckBox
    Friend WithEvents chkExisting As CheckBox
    Friend WithEvents chkOverWrite As CheckBox
    Friend WithEvents chkGraphics As CheckBox
    Friend WithEvents chkLogs As CheckBox
    Friend WithEvents ucrInputName As ucrInputTextBox
    Friend WithEvents ucrInputSheets As ucrInputComboBox
    Friend WithEvents lblNamedRegion As Label
    Friend WithEvents ucrInputNamedRegions As ucrInputComboBox
    Friend WithEvents chkRowNames As CheckBox
    Friend WithEvents ucrInputColsToRead As ucrInputTextBox
    Friend WithEvents ucrInputRowsToRead As ucrInputTextBox
    Friend WithEvents lblCannotImport As Label
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputEncoding As ucrInputComboBox
    Friend WithEvents ucrInputRowNames As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrInputNAStrings As ucrInputTextBox
    Friend WithEvents ucrInputComment As ucrInputComboBox
    Friend WithEvents ucrInputQuote As ucrInputComboBox
    Friend WithEvents ucrInputDecimal As ucrInputComboBox
End Class
