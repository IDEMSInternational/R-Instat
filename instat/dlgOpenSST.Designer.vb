<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgOpenSST
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
        Me.cmdOpenDataSet = New System.Windows.Forms.Button()
        Me.lblFileOpenPath = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.grpCSV = New System.Windows.Forms.GroupBox()
        Me.ucrInputHeaders = New instat.ucrInputComboBox()
        Me.pnlRowNames = New System.Windows.Forms.Panel()
        Me.rdoRowNamesNo = New System.Windows.Forms.RadioButton()
        Me.rdoRowNamesYes = New System.Windows.Forms.RadioButton()
        Me.ucrInputNAStrings = New instat.ucrInputTextBox()
        Me.ucrInputDecimal = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputEncoding = New instat.ucrInputComboBox()
        Me.lblEncoding = New System.Windows.Forms.Label()
        Me.lblHeaders = New System.Windows.Forms.Label()
        Me.nudSkip = New System.Windows.Forms.NumericUpDown()
        Me.lblRowNames = New System.Windows.Forms.Label()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblNAStrings = New System.Windows.Forms.Label()
        Me.chkStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrBaseOpenSST = New instat.ucrButtons()
        Me.nudDataFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblDataFromRow = New System.Windows.Forms.Label()
        Me.grpCSV.SuspendLayout()
        Me.pnlRowNames.SuspendLayout()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDataFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(167, 6)
        Me.cmdOpenDataSet.Name = "cmdOpenDataSet"
        Me.cmdOpenDataSet.Size = New System.Drawing.Size(66, 23)
        Me.cmdOpenDataSet.TabIndex = 41
        Me.cmdOpenDataSet.Tag = "select_file"
        Me.cmdOpenDataSet.Text = "Select File"
        Me.cmdOpenDataSet.UseVisualStyleBackColor = True
        '
        'lblFileOpenPath
        '
        Me.lblFileOpenPath.AutoSize = True
        Me.lblFileOpenPath.Location = New System.Drawing.Point(12, 9)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(23, 13)
        Me.lblFileOpenPath.TabIndex = 40
        Me.lblFileOpenPath.Text = "File"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(112, 13)
        Me.lblName.TabIndex = 38
        Me.lblName.Tag = "New Dataframe  Name"
        Me.lblName.Text = "New Dataframe Name"
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
        Me.grpCSV.Location = New System.Drawing.Point(16, 100)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(217, 342)
        Me.grpCSV.TabIndex = 43
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
        'nudSkip
        '
        Me.nudSkip.Location = New System.Drawing.Point(83, 278)
        Me.nudSkip.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSkip.Name = "nudSkip"
        Me.nudSkip.Size = New System.Drawing.Size(59, 20)
        Me.nudSkip.TabIndex = 32
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
        'lblLinesToSkip
        '
        Me.lblLinesToSkip.AutoSize = True
        Me.lblLinesToSkip.Location = New System.Drawing.Point(3, 280)
        Me.lblLinesToSkip.Name = "lblLinesToSkip"
        Me.lblLinesToSkip.Size = New System.Drawing.Size(72, 13)
        Me.lblLinesToSkip.TabIndex = 30
        Me.lblLinesToSkip.Text = "Lines To Skip"
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
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(39, 6)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputFilePath.TabIndex = 42
        '
        'ucrInputName
        '
        Me.ucrInputName.IsReadOnly = False
        Me.ucrInputName.Location = New System.Drawing.Point(128, 42)
        Me.ucrInputName.Name = "ucrInputName"
        Me.ucrInputName.Size = New System.Drawing.Size(102, 21)
        Me.ucrInputName.TabIndex = 39
        '
        'ucrBaseOpenSST
        '
        Me.ucrBaseOpenSST.Location = New System.Drawing.Point(12, 447)
        Me.ucrBaseOpenSST.Name = "ucrBaseOpenSST"
        Me.ucrBaseOpenSST.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseOpenSST.TabIndex = 0
        '
        'nudDataFrom
        '
        Me.nudDataFrom.Location = New System.Drawing.Point(105, 73)
        Me.nudDataFrom.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudDataFrom.Name = "nudDataFrom"
        Me.nudDataFrom.Size = New System.Drawing.Size(59, 20)
        Me.nudDataFrom.TabIndex = 45
        Me.nudDataFrom.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDataFromRow
        '
        Me.lblDataFromRow.AutoSize = True
        Me.lblDataFromRow.Location = New System.Drawing.Point(12, 75)
        Me.lblDataFromRow.Name = "lblDataFromRow"
        Me.lblDataFromRow.Size = New System.Drawing.Size(81, 13)
        Me.lblDataFromRow.TabIndex = 44
        Me.lblDataFromRow.Tag = "Data_From_Row"
        Me.lblDataFromRow.Text = "Data From Row"
        '
        'dlgOpenSST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 502)
        Me.Controls.Add(Me.nudDataFrom)
        Me.Controls.Add(Me.lblDataFromRow)
        Me.Controls.Add(Me.grpCSV)
        Me.Controls.Add(Me.ucrInputFilePath)
        Me.Controls.Add(Me.ucrInputName)
        Me.Controls.Add(Me.cmdOpenDataSet)
        Me.Controls.Add(Me.lblFileOpenPath)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.ucrBaseOpenSST)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOpenSST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Open_SST"
        Me.Text = "Open SST"
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
        Me.pnlRowNames.ResumeLayout(False)
        Me.pnlRowNames.PerformLayout()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDataFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseOpenSST As ucrButtons
    Friend WithEvents ucrInputFilePath As ucrInputTextBox
    Friend WithEvents ucrInputName As ucrInputTextBox
    Friend WithEvents cmdOpenDataSet As Button
    Friend WithEvents lblFileOpenPath As Label
    Friend WithEvents lblName As Label
    Friend WithEvents grpCSV As GroupBox
    Friend WithEvents ucrInputHeaders As ucrInputComboBox
    Friend WithEvents pnlRowNames As Panel
    Friend WithEvents rdoRowNamesNo As RadioButton
    Friend WithEvents rdoRowNamesYes As RadioButton
    Friend WithEvents ucrInputNAStrings As ucrInputTextBox
    Friend WithEvents ucrInputDecimal As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrInputEncoding As ucrInputComboBox
    Friend WithEvents lblEncoding As Label
    Friend WithEvents lblHeaders As Label
    Friend WithEvents nudSkip As NumericUpDown
    Friend WithEvents lblRowNames As Label
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblNAStrings As Label
    Friend WithEvents chkStringsAsFactors As CheckBox
    Friend WithEvents nudDataFrom As NumericUpDown
    Friend WithEvents lblDataFromRow As Label
End Class
