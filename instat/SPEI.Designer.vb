<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SPI
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
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rdoPET = New System.Windows.Forms.RadioButton()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.LblMonth = New System.Windows.Forms.Label()
        Me.LblData = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ucrChkOmitMissingValues = New instat.ucrCheck()
        Me.UcrBase = New instat.ucrButtons()
        Me.UcrInputTextBox1 = New instat.ucrInputTextBox()
        Me.UcrReceiverData = New instat.ucrReceiverSingle()
        Me.UcrReceiverMonth = New instat.ucrReceiverSingle()
        Me.UcrReceiverYear = New instat.ucrReceiverSingle()
        Me.UcrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrSelectorVariable = New instat.ucrSelectorByDataFrameAddRemove()
        Me.TimeScale = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TimeScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(70, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 23)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "SPI/SPEI"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(130, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(47, 23)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Kernal"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdoPET
        '
        Me.rdoPET.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPET.AutoSize = True
        Me.rdoPET.Location = New System.Drawing.Point(172, 17)
        Me.rdoPET.Name = "rdoPET"
        Me.rdoPET.Size = New System.Drawing.Size(38, 23)
        Me.rdoPET.TabIndex = 3
        Me.rdoPET.TabStop = True
        Me.rdoPET.Text = "PET"
        Me.rdoPET.UseVisualStyleBackColor = True
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Location = New System.Drawing.Point(258, 95)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(30, 13)
        Me.LblDate.TabIndex = 9
        Me.LblDate.Text = "Date"
        '
        'LblYear
        '
        Me.LblYear.AutoSize = True
        Me.LblYear.Location = New System.Drawing.Point(258, 138)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(29, 13)
        Me.LblYear.TabIndex = 10
        Me.LblYear.Text = "Year"
        '
        'LblMonth
        '
        Me.LblMonth.AutoSize = True
        Me.LblMonth.Location = New System.Drawing.Point(258, 179)
        Me.LblMonth.Name = "LblMonth"
        Me.LblMonth.Size = New System.Drawing.Size(37, 13)
        Me.LblMonth.TabIndex = 11
        Me.LblMonth.Text = "Month"
        '
        'LblData
        '
        Me.LblData.AutoSize = True
        Me.LblData.Location = New System.Drawing.Point(258, 225)
        Me.LblData.Name = "LblData"
        Me.LblData.Size = New System.Drawing.Size(30, 13)
        Me.LblData.TabIndex = 12
        Me.LblData.Text = "Data"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 238)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(149, 52)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Index"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(65, 20)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "SPEI"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton4.TabIndex = 0
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "SPI"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(13, 293)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(60, 13)
        Me.lblTime.TabIndex = 15
        Me.lblTime.Text = "Time Scale"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Save index into"
        '
        'ucrChkOmitMissingValues
        '
        Me.ucrChkOmitMissingValues.Checked = False
        Me.ucrChkOmitMissingValues.Location = New System.Drawing.Point(23, 334)
        Me.ucrChkOmitMissingValues.Name = "ucrChkOmitMissingValues"
        Me.ucrChkOmitMissingValues.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOmitMissingValues.TabIndex = 20
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(9, 387)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 69)
        Me.UcrBase.TabIndex = 19
        '
        'UcrInputTextBox1
        '
        Me.UcrInputTextBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputTextBox1.IsMultiline = False
        Me.UcrInputTextBox1.IsReadOnly = False
        Me.UcrInputTextBox1.Location = New System.Drawing.Point(98, 360)
        Me.UcrInputTextBox1.Name = "UcrInputTextBox1"
        Me.UcrInputTextBox1.Size = New System.Drawing.Size(79, 31)
        Me.UcrInputTextBox1.TabIndex = 18
        '
        'UcrReceiverData
        '
        Me.UcrReceiverData.frmParent = Me
        Me.UcrReceiverData.Location = New System.Drawing.Point(261, 238)
        Me.UcrReceiverData.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverData.Name = "UcrReceiverData"
        Me.UcrReceiverData.Selector = Nothing
        Me.UcrReceiverData.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverData.strNcFilePath = ""
        Me.UcrReceiverData.TabIndex = 8
        Me.UcrReceiverData.ucrSelector = Nothing
        '
        'UcrReceiverMonth
        '
        Me.UcrReceiverMonth.frmParent = Me
        Me.UcrReceiverMonth.Location = New System.Drawing.Point(261, 192)
        Me.UcrReceiverMonth.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverMonth.Name = "UcrReceiverMonth"
        Me.UcrReceiverMonth.Selector = Nothing
        Me.UcrReceiverMonth.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverMonth.strNcFilePath = ""
        Me.UcrReceiverMonth.TabIndex = 7
        Me.UcrReceiverMonth.ucrSelector = Nothing
        '
        'UcrReceiverYear
        '
        Me.UcrReceiverYear.frmParent = Me
        Me.UcrReceiverYear.Location = New System.Drawing.Point(261, 151)
        Me.UcrReceiverYear.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverYear.Name = "UcrReceiverYear"
        Me.UcrReceiverYear.Selector = Nothing
        Me.UcrReceiverYear.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverYear.strNcFilePath = ""
        Me.UcrReceiverYear.TabIndex = 6
        Me.UcrReceiverYear.ucrSelector = Nothing
        '
        'UcrReceiverDate
        '
        Me.UcrReceiverDate.frmParent = Me
        Me.UcrReceiverDate.Location = New System.Drawing.Point(261, 108)
        Me.UcrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverDate.Name = "UcrReceiverDate"
        Me.UcrReceiverDate.Selector = Nothing
        Me.UcrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverDate.strNcFilePath = ""
        Me.UcrReceiverDate.TabIndex = 5
        Me.UcrReceiverDate.ucrSelector = Nothing
        '
        'ucrSelectorVariable
        '
        Me.ucrSelectorVariable.bShowHiddenColumns = False
        Me.ucrSelectorVariable.bUseCurrentFilter = True
        Me.ucrSelectorVariable.Location = New System.Drawing.Point(9, 43)
        Me.ucrSelectorVariable.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorVariable.Name = "ucrSelectorVariable"
        Me.ucrSelectorVariable.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorVariable.TabIndex = 4
        '
        'TimeScale
        '
        Me.TimeScale.Location = New System.Drawing.Point(79, 291)
        Me.TimeScale.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.TimeScale.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeScale.Name = "TimeScale"
        Me.TimeScale.Size = New System.Drawing.Size(63, 20)
        Me.TimeScale.TabIndex = 22
        Me.TimeScale.Value = New Decimal(New Integer() {1, 0, 0, 0})


        'SPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 451)
        Me.Controls.Add(Me.TimeScale)
        Me.Controls.Add(Me.ucrChkOmitMissingValues)
        Me.Controls.Add(Me.UcrBase)
        Me.Controls.Add(Me.UcrInputTextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LblData)
        Me.Controls.Add(Me.LblMonth)
        Me.Controls.Add(Me.LblYear)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.UcrReceiverData)
        Me.Controls.Add(Me.UcrReceiverMonth)
        Me.Controls.Add(Me.UcrReceiverYear)
        Me.Controls.Add(Me.UcrReceiverDate)
        Me.Controls.Add(Me.ucrSelectorVariable)
        Me.Controls.Add(Me.rdoPET)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Name = "SPI"
        Me.Text = "SPI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TimeScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rdoPET As RadioButton
    Friend WithEvents ucrSelectorVariable As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiverDate As ucrReceiverSingle
    Friend WithEvents LblDate As Label
    Friend WithEvents UcrReceiverData As ucrReceiverSingle
    Friend WithEvents UcrReceiverMonth As ucrReceiverSingle
    Friend WithEvents UcrReceiverYear As ucrReceiverSingle
    Friend WithEvents LblData As Label
    Friend WithEvents LblMonth As Label
    Friend WithEvents LblYear As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents UcrInputTextBox1 As ucrInputTextBox
    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents ucrChkOmitMissingValues As ucrCheck
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TimeScale As NumericUpDown
End Class
