﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ucrInputNAStrings = New instat.ucrInputTextBox()
        Me.ucrInputDecimal = New instat.ucrInputComboBox()
        Me.ucrInputSeparator = New instat.ucrInputComboBox()
        Me.ucrInputEncoding = New instat.ucrInputComboBox()
        Me.lblEncoding = New System.Windows.Forms.Label()
        Me.nudSkip = New System.Windows.Forms.NumericUpDown()
        Me.lblSeparator = New System.Windows.Forms.Label()
        Me.lblLinesToSkip = New System.Windows.Forms.Label()
        Me.lblDecimal = New System.Windows.Forms.Label()
        Me.lblNAStrings = New System.Windows.Forms.Label()
        Me.chkStringsAsFactors = New System.Windows.Forms.CheckBox()
        Me.nudDataFrom = New System.Windows.Forms.NumericUpDown()
        Me.lblDataFromRow = New System.Windows.Forms.Label()
        Me.ucrInputFilePath = New instat.ucrInputTextBox()
        Me.ucrInputName = New instat.ucrInputTextBox()
        Me.ucrBaseOpenSST = New instat.ucrButtons()
        Me.grpCSV.SuspendLayout()
        CType(Me.nudSkip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDataFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOpenDataSet
        '
        Me.cmdOpenDataSet.Location = New System.Drawing.Point(206, 14)
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
        Me.lblFileOpenPath.Location = New System.Drawing.Point(10, 17)
        Me.lblFileOpenPath.Name = "lblFileOpenPath"
        Me.lblFileOpenPath.Size = New System.Drawing.Size(26, 13)
        Me.lblFileOpenPath.TabIndex = 40
        Me.lblFileOpenPath.Text = "File:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(10, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(115, 13)
        Me.lblName.TabIndex = 38
        Me.lblName.Tag = "New Dataframe Name:"
        Me.lblName.Text = "New Dataframe Name:"
        '
        'grpCSV
        '
        Me.grpCSV.AutoSize = True
        Me.grpCSV.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.grpCSV.Controls.Add(Me.ucrInputNAStrings)
        Me.grpCSV.Controls.Add(Me.ucrInputDecimal)
        Me.grpCSV.Controls.Add(Me.ucrInputSeparator)
        Me.grpCSV.Controls.Add(Me.ucrInputEncoding)
        Me.grpCSV.Controls.Add(Me.lblEncoding)
        Me.grpCSV.Controls.Add(Me.nudSkip)
        Me.grpCSV.Controls.Add(Me.lblSeparator)
        Me.grpCSV.Controls.Add(Me.lblLinesToSkip)
        Me.grpCSV.Controls.Add(Me.lblDecimal)
        Me.grpCSV.Controls.Add(Me.lblNAStrings)
        Me.grpCSV.Controls.Add(Me.chkStringsAsFactors)
        Me.grpCSV.Location = New System.Drawing.Point(13, 107)
        Me.grpCSV.Name = "grpCSV"
        Me.grpCSV.Size = New System.Drawing.Size(261, 195)
        Me.grpCSV.TabIndex = 43
        Me.grpCSV.TabStop = False
        Me.grpCSV.Text = "Import csv Options"
        Me.grpCSV.Visible = False
        '
        'ucrInputNAStrings
        '
        Me.ucrInputNAStrings.IsReadOnly = False
        Me.ucrInputNAStrings.Location = New System.Drawing.Point(118, 106)
        Me.ucrInputNAStrings.Name = "ucrInputNAStrings"
        Me.ucrInputNAStrings.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputNAStrings.TabIndex = 39
        '
        'ucrInputDecimal
        '
        Me.ucrInputDecimal.IsReadOnly = False
        Me.ucrInputDecimal.Location = New System.Drawing.Point(118, 79)
        Me.ucrInputDecimal.Name = "ucrInputDecimal"
        Me.ucrInputDecimal.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputDecimal.TabIndex = 36
        '
        'ucrInputSeparator
        '
        Me.ucrInputSeparator.IsReadOnly = False
        Me.ucrInputSeparator.Location = New System.Drawing.Point(118, 52)
        Me.ucrInputSeparator.Name = "ucrInputSeparator"
        Me.ucrInputSeparator.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSeparator.TabIndex = 35
        '
        'ucrInputEncoding
        '
        Me.ucrInputEncoding.IsReadOnly = False
        Me.ucrInputEncoding.Location = New System.Drawing.Point(118, 25)
        Me.ucrInputEncoding.Name = "ucrInputEncoding"
        Me.ucrInputEncoding.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputEncoding.TabIndex = 33
        '
        'lblEncoding
        '
        Me.lblEncoding.AutoSize = True
        Me.lblEncoding.Location = New System.Drawing.Point(6, 28)
        Me.lblEncoding.Name = "lblEncoding"
        Me.lblEncoding.Size = New System.Drawing.Size(55, 13)
        Me.lblEncoding.TabIndex = 3
        Me.lblEncoding.Tag = "Encoding:"
        Me.lblEncoding.Text = "Encoding:"
        '
        'nudSkip
        '
        Me.nudSkip.Location = New System.Drawing.Point(118, 133)
        Me.nudSkip.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudSkip.Name = "nudSkip"
        Me.nudSkip.Size = New System.Drawing.Size(59, 20)
        Me.nudSkip.TabIndex = 32
        '
        'lblSeparator
        '
        Me.lblSeparator.AutoSize = True
        Me.lblSeparator.Location = New System.Drawing.Point(6, 55)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(56, 13)
        Me.lblSeparator.TabIndex = 6
        Me.lblSeparator.Tag = "Separator:"
        Me.lblSeparator.Text = "Separator:"
        '
        'lblLinesToSkip
        '
        Me.lblLinesToSkip.AutoSize = True
        Me.lblLinesToSkip.Location = New System.Drawing.Point(6, 136)
        Me.lblLinesToSkip.Name = "lblLinesToSkip"
        Me.lblLinesToSkip.Size = New System.Drawing.Size(75, 13)
        Me.lblLinesToSkip.TabIndex = 30
        Me.lblLinesToSkip.Text = "Lines To Skip:"
        '
        'lblDecimal
        '
        Me.lblDecimal.AutoSize = True
        Me.lblDecimal.Location = New System.Drawing.Point(6, 82)
        Me.lblDecimal.Name = "lblDecimal"
        Me.lblDecimal.Size = New System.Drawing.Size(48, 13)
        Me.lblDecimal.TabIndex = 7
        Me.lblDecimal.Tag = "Decimal:"
        Me.lblDecimal.Text = "Decimal:"
        '
        'lblNAStrings
        '
        Me.lblNAStrings.AutoSize = True
        Me.lblNAStrings.Location = New System.Drawing.Point(6, 109)
        Me.lblNAStrings.Name = "lblNAStrings"
        Me.lblNAStrings.Size = New System.Drawing.Size(105, 13)
        Me.lblNAStrings.TabIndex = 10
        Me.lblNAStrings.Text = "Missing Value String:"
        '
        'chkStringsAsFactors
        '
        Me.chkStringsAsFactors.AutoSize = True
        Me.chkStringsAsFactors.Location = New System.Drawing.Point(6, 159)
        Me.chkStringsAsFactors.Name = "chkStringsAsFactors"
        Me.chkStringsAsFactors.Size = New System.Drawing.Size(186, 17)
        Me.chkStringsAsFactors.TabIndex = 26
        Me.chkStringsAsFactors.Tag = "Strings_as_factors"
        Me.chkStringsAsFactors.Text = "Convert Strings to Factor Columns"
        Me.chkStringsAsFactors.UseVisualStyleBackColor = True
        '
        'nudDataFrom
        '
        Me.nudDataFrom.Location = New System.Drawing.Point(131, 75)
        Me.nudDataFrom.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudDataFrom.Name = "nudDataFrom"
        Me.nudDataFrom.Size = New System.Drawing.Size(59, 20)
        Me.nudDataFrom.TabIndex = 45
        Me.nudDataFrom.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDataFromRow
        '
        Me.lblDataFromRow.AutoSize = True
        Me.lblDataFromRow.Location = New System.Drawing.Point(10, 79)
        Me.lblDataFromRow.Name = "lblDataFromRow"
        Me.lblDataFromRow.Size = New System.Drawing.Size(84, 13)
        Me.lblDataFromRow.TabIndex = 44
        Me.lblDataFromRow.Tag = "Data_From_Row:"
        Me.lblDataFromRow.Text = "Data From Row:"
        '
        'ucrInputFilePath
        '
        Me.ucrInputFilePath.IsReadOnly = False
        Me.ucrInputFilePath.Location = New System.Drawing.Point(39, 14)
        Me.ucrInputFilePath.Name = "ucrInputFilePath"
        Me.ucrInputFilePath.Size = New System.Drawing.Size(161, 21)
        Me.ucrInputFilePath.TabIndex = 42
        '
        'ucrInputName
        '
        Me.ucrInputName.IsReadOnly = False
        Me.ucrInputName.Location = New System.Drawing.Point(131, 44)
        Me.ucrInputName.Name = "ucrInputName"
        Me.ucrInputName.Size = New System.Drawing.Size(142, 21)
        Me.ucrInputName.TabIndex = 39
        '
        'ucrBaseOpenSST
        '
        Me.ucrBaseOpenSST.Location = New System.Drawing.Point(12, 308)
        Me.ucrBaseOpenSST.Name = "ucrBaseOpenSST"
        Me.ucrBaseOpenSST.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseOpenSST.TabIndex = 0
        '
        'dlgOpenSST
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 368)
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
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOpenSST"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Open_SST"
        Me.Text = "Open SST"
        Me.grpCSV.ResumeLayout(False)
        Me.grpCSV.PerformLayout()
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
    Friend WithEvents ucrInputNAStrings As ucrInputTextBox
    Friend WithEvents ucrInputDecimal As ucrInputComboBox
    Friend WithEvents ucrInputSeparator As ucrInputComboBox
    Friend WithEvents ucrInputEncoding As ucrInputComboBox
    Friend WithEvents lblEncoding As Label
    Friend WithEvents nudSkip As NumericUpDown
    Friend WithEvents lblSeparator As Label
    Friend WithEvents lblLinesToSkip As Label
    Friend WithEvents lblDecimal As Label
    Friend WithEvents lblNAStrings As Label
    Friend WithEvents chkStringsAsFactors As CheckBox
    Friend WithEvents nudDataFrom As NumericUpDown
    Friend WithEvents lblDataFromRow As Label
End Class
