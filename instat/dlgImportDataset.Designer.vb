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
        Me.chkStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.grdDataPreview = New unvell.ReoGrid.ReoGridControl()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.nudSkip = New System.Windows.Forms.NumericUpDown()
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.ucrInputHeaders = New instat.ucrInputComboBox()
        Me.pnlRowNames = New System.Windows.Forms.Panel()
        Me.rdoRowNamesNo = New System.Windows.Forms.RadioButton()
        Me.rdoRowNamesYes = New System.Windows.Forms.RadioButton()
        Me.ucrInputNAStrings = New instat.ucrInputTextBox()
        Me.ucrInputDecimal = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputEncoding = New instat.ucrInputComboBox()
        Me.grpExcel = New System.Windows.Forms.GroupBox()
        Me.lblMissingValueString = New System.Windows.Forms.Label()
        Me.ucrInputXlMissingValueString = New instat.ucrInputTextBox()
        Me.lblNamedRegion = New System.Windows.Forms.Label()
        Me.ucrInputNamedRegions = New instat.ucrInputComboBox()
        Me.ucrInputSheets = New instat.ucrInputComboBox()
        Me.lblRowToSkip = New System.Windows.Forms.Label()
        Me.lblSheets = New System.Windows.Forms.Label()
        Me.nudxlRowsToSkip = New System.Windows.Forms.NumericUpDown()
        Me.chkColumnNames = New System.Windows.Forms.CheckBox()
        Me.grpRDS = New System.Windows.Forms.GroupBox()
        Me.chkImportCalculations = New System.Windows.Forms.CheckBox()
        Me.chkImportFilters = New System.Windows.Forms.CheckBox()
        Me.chkImportChangesLog = New System.Windows.Forms.CheckBox()
        Me.chkOverWrite = New System.Windows.Forms.CheckBox()
        Me.chkImportMetadata = New System.Windows.Forms.CheckBox()
        Me.chkImportObjects = New System.Windows.Forms.CheckBox()
        Me.chkExistingData = New System.Windows.Forms.CheckBox()
        Me.lblCannotImport = New System.Windows.Forms.Label()
        Me.lblNoPreview = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrBase = New instat.ucrButtons()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCSV.SuspendLayout()
        Me.pnlRowNames.SuspendLayout()
        Me.grpExcel.SuspendLayout()
        CType(Me.nudxlRowsToSkip, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'chkStringsAsFactors
        '
        Me.chkStringsAsFactors.AutoSize = True
        Me.chkStringsAsFactors.Location = New System.Drawing.Point(5, 306)
        Me.chkStringsAsFactors.Name = "chkStringsAsFactors"
        Me.chkStringsAsFactors.Size = New System.Drawing.Size(186, 17)
        Me.chkStringsAsFactors.TabIndex = 26
        Me.chkStringsAsFactors.Tag = "Strings_as_factors"
        Me.chkStringsAsFactors.Text = "Convert Strings to Factor Columns"
        Me.chkStringsAsFactors.UseVisualStyleBackColor = True
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
        'nudSkip
        '
        Me.nudSkip.Location = New System.Drawing.Point(83, 278)
        Me.nudSkip.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSkip.Name = "nudSkip"
        Me.nudSkip.Size = New System.Drawing.Size(59, 20)
        Me.nudSkip.TabIndex = 32
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(164, 22)
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
        Me.grpCSV.Controls.Add(Me.ucrInputHeaders)
        Me.grpCSV.Controls.Add(Me.pnlRowNames)
        Me.grpCSV.Controls.Add(Me.ucrInputNAStrings)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimal)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparator)
        Me.grpCSV.Controls.Add(Me.ucrInputEncoding)
        Me.grpCSV.Controls.Add(Me.lblEncoding)
        Me.grpCSV.Controls.Add(Me.lblHeaders)
        Me.grpCSV.Controls.Add(Me.nudSkip)
        Me.grpCSV.Controls.Add(Me.lblRowNames)
        Me.grpCSV.Controls.Add(Me.lblSeparator)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkip)
        Me.grpCSV.Controls.Add(Me.lblDecimal)
        Me.grpCSV.Controls.Add(Me.lblNAStrings)
        Me.grpCSV.Controls.Add(Me.chkStringsAsFactors)
        Me.grpCSV.Location = New System.Drawing.Point(15, 87)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(217, 342)
        Me.grpCSV.TabIndex = 34
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "Import csv Options"
        Me.grpCSV.Visible = False
        '
        'ucrInputHeaders
        '
        Me.ucrInputHeaders.IsReadOnly = False
        Me.ucrInputHeaders.Location = New System.Drawing.Point(9, 82)
        Me.ucrInputHeaders.Name = "ucrInputHeaders"
        Me.ucrInputHeaders.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputHeaders.TabIndex = 43
        '
        'pnlRowNames
        '
        Me.pnlRowNames.Controls.Add(Me.rdoRowNamesNo)
        Me.pnlRowNames.Controls.Add(Me.rdoRowNamesYes)
        Me.pnlRowNames.Location = New System.Drawing.Point(9, 126)
        Me.pnlRowNames.Name = "pnlRowNames"
        Me.pnlRowNames.Size = New System.Drawing.Size(106, 24)
        Me.pnlRowNames.TabIndex = 42
        '
        'rdoRowNamesNo
        '
        Me.rdoRowNamesNo.AutoSize = True
        Me.rdoRowNamesNo.Location = New System.Drawing.Point(55, 3)
        Me.rdoRowNamesNo.Name = "rdoRowNamesNo"
        Me.rdoRowNamesNo.Size = New System.Drawing.Size(39, 17)
        Me.rdoRowNamesNo.TabIndex = 41
        Me.rdoRowNamesNo.TabStop = True
        Me.rdoRowNamesNo.Tag = "No"
        Me.rdoRowNamesNo.Text = "No"
        Me.rdoRowNamesNo.UseVisualStyleBackColor = True
        '
        'rdoRowNamesYes
        '
        Me.rdoRowNamesYes.AutoSize = True
        Me.rdoRowNamesYes.Location = New System.Drawing.Point(6, 4)
        Me.rdoRowNamesYes.Name = "rdoRowNamesYes"
        Me.rdoRowNamesYes.Size = New System.Drawing.Size(43, 17)
        Me.rdoRowNamesYes.TabIndex = 40
        Me.rdoRowNamesYes.TabStop = True
        Me.rdoRowNamesYes.Tag = "Yes"
        Me.rdoRowNamesYes.Text = "Yes"
        Me.rdoRowNamesYes.UseVisualStyleBackColor = True
        '
        'ucrInputNAStrings
        '
        Me.ucrInputNAStrings.IsReadOnly = False
        Me.ucrInputNAStrings.Location = New System.Drawing.Point(5, 247)
        Me.ucrInputNAStrings.Name = "ucrInputNAStrings"
        Me.ucrInputNAStrings.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNAStrings.TabIndex = 39
        '
        'ucrInputDecimal
        '
        Me.ucrInputDecimal.IsReadOnly = False
        Me.ucrInputDecimal.Location = New System.Drawing.Point(74, 196)
        Me.ucrInputDecimal.Name = "ucrInputDecimal"
        Me.ucrInputDecimal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDecimal.TabIndex = 36
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(74, 154)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeparator.TabIndex = 35
        '
        'ucrInputEncoding
        '
        Me.ucrInputEncoding.IsReadOnly = False
        Me.ucrInputEncoding.Location = New System.Drawing.Point(62, 25)
        Me.ucrInputEncoding.Name = "ucrInputEncoding"
        Me.ucrInputEncoding.Size = New System.Drawing.Size(149, 21)
        Me.ucrInputEncoding.TabIndex = 33
        '
        'grpExcel
        '
        Me.grpExcel.Controls.Add(Me.lblMissingValueString)
        Me.grpExcel.Controls.Add(Me.ucrInputXlMissingValueString)
        Me.grpExcel.Controls.Add(Me.lblNamedRegion)
        Me.grpExcel.Controls.Add(Me.ucrInputNamedRegions)
        Me.grpExcel.Controls.Add(Me.ucrInputSheets)
        Me.grpExcel.Controls.Add(Me.lblRowToSkip)
        Me.grpExcel.Controls.Add(Me.lblSheets)
        Me.grpExcel.Controls.Add(Me.nudxlRowsToSkip)
        Me.grpExcel.Controls.Add(Me.chkColumnNames)
        Me.grpExcel.Location = New System.Drawing.Point(15, 87)
        Me.grpExcel.Name = "grpExcel"
        Me.grpExcel.Size = New System.Drawing.Size(217, 392)
        Me.grpExcel.TabIndex = 35
        Me.grpExcel.TabStop = False
        Me.grpExcel.Text = "Import Excel options"
        Me.grpExcel.Visible = False
        '
        'lblMissingValueString
        '
        Me.lblMissingValueString.AutoSize = True
        Me.lblMissingValueString.Location = New System.Drawing.Point(6, 126)
        Me.lblMissingValueString.Name = "lblMissingValueString"
        Me.lblMissingValueString.Size = New System.Drawing.Size(102, 13)
        Me.lblMissingValueString.TabIndex = 19
        Me.lblMissingValueString.Text = "Missing Value String"
        '
        'ucrInputXlMissingValueString
        '
        Me.ucrInputXlMissingValueString.IsReadOnly = False
        Me.ucrInputXlMissingValueString.Location = New System.Drawing.Point(5, 144)
        Me.ucrInputXlMissingValueString.Name = "ucrInputXlMissingValueString"
        Me.ucrInputXlMissingValueString.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputXlMissingValueString.TabIndex = 18
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
        Me.ucrInputNamedRegions.IsReadOnly = False
        Me.ucrInputNamedRegions.Location = New System.Drawing.Point(4, 96)
        Me.ucrInputNamedRegions.Name = "ucrInputNamedRegions"
        Me.ucrInputNamedRegions.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputNamedRegions.TabIndex = 16
        '
        'ucrInputSheets
        '
        Me.ucrInputSheets.IsReadOnly = False
        Me.ucrInputSheets.Location = New System.Drawing.Point(6, 43)
        Me.ucrInputSheets.Name = "ucrInputSheets"
        Me.ucrInputSheets.Size = New System.Drawing.Size(154, 21)
        Me.ucrInputSheets.TabIndex = 15
        '
        'lblRowToSkip
        '
        Me.lblRowToSkip.AutoSize = True
        Me.lblRowToSkip.Location = New System.Drawing.Point(3, 96)
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
        'nudxlRowsToSkip
        '
        Me.nudxlRowsToSkip.Location = New System.Drawing.Point(77, 94)
        Me.nudxlRowsToSkip.Name = "nudxlRowsToSkip"
        Me.nudxlRowsToSkip.Size = New System.Drawing.Size(49, 20)
        Me.nudxlRowsToSkip.TabIndex = 5
        '
        'chkColumnNames
        '
        Me.chkColumnNames.AutoSize = True
        Me.chkColumnNames.Location = New System.Drawing.Point(5, 73)
        Me.chkColumnNames.Name = "chkColumnNames"
        Me.chkColumnNames.Size = New System.Drawing.Size(154, 17)
        Me.chkColumnNames.TabIndex = 2
        Me.chkColumnNames.Text = "First Row is Column Names"
        Me.chkColumnNames.UseVisualStyleBackColor = True
        '
        'grpRDS
        '
        Me.grpRDS.Controls.Add(Me.chkImportCalculations)
        Me.grpRDS.Controls.Add(Me.chkImportFilters)
        Me.grpRDS.Controls.Add(Me.chkImportChangesLog)
        Me.grpRDS.Controls.Add(Me.chkOverWrite)
        Me.grpRDS.Controls.Add(Me.chkImportMetadata)
        Me.grpRDS.Controls.Add(Me.chkImportObjects)
        Me.grpRDS.Controls.Add(Me.chkExistingData)
        Me.grpRDS.Location = New System.Drawing.Point(16, 88)
        Me.grpRDS.Name = "grpRDS"
        Me.grpRDS.Size = New System.Drawing.Size(217, 150)
        Me.grpRDS.TabIndex = 36
        Me.grpRDS.TabStop = False
        Me.grpRDS.Text = "Import RDS options"
        Me.grpRDS.Visible = False
        '
        'chkImportCalculations
        '
        Me.chkImportCalculations.AutoSize = True
        Me.chkImportCalculations.Location = New System.Drawing.Point(3, 91)
        Me.chkImportCalculations.Name = "chkImportCalculations"
        Me.chkImportCalculations.Size = New System.Drawing.Size(114, 17)
        Me.chkImportCalculations.TabIndex = 7
        Me.chkImportCalculations.Text = "Import calculations"
        Me.chkImportCalculations.UseVisualStyleBackColor = True
        '
        'chkImportFilters
        '
        Me.chkImportFilters.AutoSize = True
        Me.chkImportFilters.Location = New System.Drawing.Point(3, 73)
        Me.chkImportFilters.Name = "chkImportFilters"
        Me.chkImportFilters.Size = New System.Drawing.Size(82, 17)
        Me.chkImportFilters.TabIndex = 6
        Me.chkImportFilters.Text = "Import filters"
        Me.chkImportFilters.UseVisualStyleBackColor = True
        '
        'chkImportChangesLog
        '
        Me.chkImportChangesLog.AutoSize = True
        Me.chkImportChangesLog.Location = New System.Drawing.Point(3, 109)
        Me.chkImportChangesLog.Name = "chkImportChangesLog"
        Me.chkImportChangesLog.Size = New System.Drawing.Size(116, 17)
        Me.chkImportChangesLog.TabIndex = 5
        Me.chkImportChangesLog.Text = "Import changes log"
        Me.chkImportChangesLog.UseVisualStyleBackColor = True
        '
        'chkOverWrite
        '
        Me.chkOverWrite.AutoSize = True
        Me.chkOverWrite.Location = New System.Drawing.Point(3, 127)
        Me.chkOverWrite.Name = "chkOverWrite"
        Me.chkOverWrite.Size = New System.Drawing.Size(198, 17)
        Me.chkOverWrite.TabIndex = 4
        Me.chkOverWrite.Text = "Overwrite existing if duplicates found"
        Me.chkOverWrite.UseVisualStyleBackColor = True
        '
        'chkImportMetadata
        '
        Me.chkImportMetadata.AutoSize = True
        Me.chkImportMetadata.Location = New System.Drawing.Point(3, 37)
        Me.chkImportMetadata.Name = "chkImportMetadata"
        Me.chkImportMetadata.Size = New System.Drawing.Size(102, 17)
        Me.chkImportMetadata.TabIndex = 2
        Me.chkImportMetadata.Text = "Import metadata"
        Me.chkImportMetadata.UseVisualStyleBackColor = True
        '
        'chkImportObjects
        '
        Me.chkImportObjects.AutoSize = True
        Me.chkImportObjects.Location = New System.Drawing.Point(3, 55)
        Me.chkImportObjects.Name = "chkImportObjects"
        Me.chkImportObjects.Size = New System.Drawing.Size(92, 17)
        Me.chkImportObjects.TabIndex = 1
        Me.chkImportObjects.Text = "Import objects"
        Me.chkImportObjects.UseVisualStyleBackColor = True
        '
        'chkExistingData
        '
        Me.chkExistingData.AutoSize = True
        Me.chkExistingData.Location = New System.Drawing.Point(3, 19)
        Me.chkExistingData.Name = "chkExistingData"
        Me.chkExistingData.Size = New System.Drawing.Size(147, 17)
        Me.chkExistingData.TabIndex = 0
        Me.chkExistingData.Text = "Keep existing data frames"
        Me.chkExistingData.UseVisualStyleBackColor = True
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
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(39, 23)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputFilePath.TabIndex = 37
        '
        'ucrInputName
        '
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
        Me.ClientSize = New System.Drawing.Size(668, 499)
        Me.Controls.Add(Me.lblNoPreview)
        Me.Controls.Add(Me.grpRDS)
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
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
        Me.pnlRowNames.ResumeLayout(False)
        Me.pnlRowNames.PerformLayout()
        Me.grpExcel.ResumeLayout(False)
        Me.grpExcel.PerformLayout()
        CType(Me.nudxlRowsToSkip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRDS.ResumeLayout(False)
        Me.grpRDS.PerformLayout()
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
    Friend WithEvents chkStringsAsFactors As CheckBox
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grdDataPreview As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents nudSkip As NumericUpDown
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents grpCSV As GroupBox
    Friend WithEvents grpExcel As GroupBox
    Friend WithEvents nudxlRowsToSkip As NumericUpDown
    Friend WithEvents chkColumnNames As CheckBox
    Friend WithEvents lblRowToSkip As Label
    Friend WithEvents lblSheets As Label
    Friend WithEvents grpRDS As GroupBox
    Friend WithEvents chkImportMetadata As CheckBox
    Friend WithEvents chkImportObjects As CheckBox
    Friend WithEvents chkExistingData As CheckBox
    Friend WithEvents chkOverWrite As CheckBox
    Friend WithEvents chkImportChangesLog As CheckBox
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
    Friend WithEvents pnlRowNames As Panel
    Friend WithEvents rdoRowNamesNo As RadioButton
    Friend WithEvents rdoRowNamesYes As RadioButton
    Friend WithEvents ucrInputHeaders As ucrInputComboBox
    Friend WithEvents lblMissingValueString As Label
    Friend WithEvents ucrInputXlMissingValueString As ucrInputTextBox
    Friend WithEvents chkImportFilters As CheckBox
    Friend WithEvents chkImportCalculations As CheckBox
    Friend WithEvents lblNoPreview As Label
End Class
