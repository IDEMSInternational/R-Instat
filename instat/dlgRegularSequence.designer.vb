<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgRegularSequence
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
        Me.grpSequenceType = New System.Windows.Forms.GroupBox()
        Me.rdoDates = New System.Windows.Forms.RadioButton()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.grpSequenceDefinition = New System.Windows.Forms.GroupBox()
        Me.lblNumberDecimalPlaces = New System.Windows.Forms.Label()
        Me.nudNumberofDecimalPlaces = New System.Windows.Forms.NumericUpDown()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudRepeatValues = New System.Windows.Forms.NumericUpDown()
        Me.ucrDataFrameLengthForRegularSequence = New instat.ucrDataFrameLength()
        Me.dtpSelectorB = New System.Windows.Forms.DateTimePicker()
        Me.nudInStepsOf = New System.Windows.Forms.NumericUpDown()
        Me.dtpSelectorA = New System.Windows.Forms.DateTimePicker()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.chkDefineAsFactor = New System.Windows.Forms.CheckBox()
        Me.lblTimes1 = New System.Windows.Forms.Label()
        Me.lblRepeatValues = New System.Windows.Forms.Label()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.txtGetPreview = New System.Windows.Forms.RichTextBox()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.ucrNewColumnName = New instat.ucrInputComboBox()
        Me.ucrSelectDataFrameRegularSequence = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSequenceType.SuspendLayout()
        Me.grpSequenceDefinition.SuspendLayout()
        CType(Me.nudNumberofDecimalPlaces, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRepeatValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInStepsOf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdoDates)
        Me.grpSequenceType.Controls.Add(Me.rdoNumeric)
        Me.grpSequenceType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSequenceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceType.Location = New System.Drawing.Point(10, 61)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(195, 39)
        Me.grpSequenceType.TabIndex = 3
        Me.grpSequenceType.TabStop = False
        Me.grpSequenceType.Tag = "Sequence_type"
        Me.grpSequenceType.Text = "Sequence Type"
        '
        'rdoDates
        '
        Me.rdoDates.AutoSize = True
        Me.rdoDates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDates.Location = New System.Drawing.Point(103, 15)
        Me.rdoDates.Name = "rdoDates"
        Me.rdoDates.Size = New System.Drawing.Size(59, 18)
        Me.rdoDates.TabIndex = 1
        Me.rdoDates.Tag = "Dates"
        Me.rdoDates.Text = "Dates"
        Me.rdoDates.UseVisualStyleBackColor = True
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNumeric.Location = New System.Drawing.Point(6, 15)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(70, 18)
        Me.rdoNumeric.TabIndex = 0
        Me.rdoNumeric.Tag = "Numeric"
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'grpSequenceDefinition
        '
        Me.grpSequenceDefinition.Controls.Add(Me.lblNumberDecimalPlaces)
        Me.grpSequenceDefinition.Controls.Add(Me.nudNumberofDecimalPlaces)
        Me.grpSequenceDefinition.Controls.Add(Me.nudTo)
        Me.grpSequenceDefinition.Controls.Add(Me.nudFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.nudRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDataFrameLengthForRegularSequence)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorB)
        Me.grpSequenceDefinition.Controls.Add(Me.nudInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorA)
        Me.grpSequenceDefinition.Controls.Add(Me.lblLength)
        Me.grpSequenceDefinition.Controls.Add(Me.chkDefineAsFactor)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTimes1)
        Me.grpSequenceDefinition.Controls.Add(Me.lblRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.lblSteps)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTo)
        Me.grpSequenceDefinition.Controls.Add(Me.lblFrom)
        Me.grpSequenceDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceDefinition.Location = New System.Drawing.Point(10, 111)
        Me.grpSequenceDefinition.Name = "grpSequenceDefinition"
        Me.grpSequenceDefinition.Size = New System.Drawing.Size(205, 204)
        Me.grpSequenceDefinition.TabIndex = 4
        Me.grpSequenceDefinition.TabStop = False
        Me.grpSequenceDefinition.Tag = "Sequence_definition"
        Me.grpSequenceDefinition.Text = "Sequence Definition"
        Me.grpSequenceDefinition.UseCompatibleTextRendering = True
        '
        'lblNumberDecimalPlaces
        '
        Me.lblNumberDecimalPlaces.AutoSize = True
        Me.lblNumberDecimalPlaces.Location = New System.Drawing.Point(12, 183)
        Me.lblNumberDecimalPlaces.Name = "lblNumberDecimalPlaces"
        Me.lblNumberDecimalPlaces.Size = New System.Drawing.Size(132, 13)
        Me.lblNumberDecimalPlaces.TabIndex = 16
        Me.lblNumberDecimalPlaces.Text = "Number of Decimal Places"
        '
        'nudNumberofDecimalPlaces
        '
        Me.nudNumberofDecimalPlaces.Location = New System.Drawing.Point(150, 180)
        Me.nudNumberofDecimalPlaces.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudNumberofDecimalPlaces.Name = "nudNumberofDecimalPlaces"
        Me.nudNumberofDecimalPlaces.Size = New System.Drawing.Size(45, 20)
        Me.nudNumberofDecimalPlaces.TabIndex = 15
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(98, 51)
        Me.nudTo.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudTo.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(51, 20)
        Me.nudTo.TabIndex = 14
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(98, 24)
        Me.nudFrom.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudFrom.Minimum = New Decimal(New Integer() {2147483647, 0, 0, -2147483648})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(51, 20)
        Me.nudFrom.TabIndex = 13
        '
        'nudRepeatValues
        '
        Me.nudRepeatValues.Location = New System.Drawing.Point(98, 104)
        Me.nudRepeatValues.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudRepeatValues.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudRepeatValues.Name = "nudRepeatValues"
        Me.nudRepeatValues.Size = New System.Drawing.Size(51, 20)
        Me.nudRepeatValues.TabIndex = 12
        Me.nudRepeatValues.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ucrDataFrameLengthForRegularSequence
        '
        Me.ucrDataFrameLengthForRegularSequence.clsDataFrameSelector = Nothing
        Me.ucrDataFrameLengthForRegularSequence.Location = New System.Drawing.Point(98, 130)
        Me.ucrDataFrameLengthForRegularSequence.Name = "ucrDataFrameLengthForRegularSequence"
        Me.ucrDataFrameLengthForRegularSequence.Size = New System.Drawing.Size(51, 23)
        Me.ucrDataFrameLengthForRegularSequence.TabIndex = 10
        '
        'dtpSelectorB
        '
        Me.dtpSelectorB.Location = New System.Drawing.Point(98, 51)
        Me.dtpSelectorB.Name = "dtpSelectorB"
        Me.dtpSelectorB.Size = New System.Drawing.Size(87, 20)
        Me.dtpSelectorB.TabIndex = 5
        '
        'nudInStepsOf
        '
        Me.nudInStepsOf.Location = New System.Drawing.Point(98, 78)
        Me.nudInStepsOf.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.nudInStepsOf.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudInStepsOf.Name = "nudInStepsOf"
        Me.nudInStepsOf.Size = New System.Drawing.Size(51, 20)
        Me.nudInStepsOf.TabIndex = 10
        Me.nudInStepsOf.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpSelectorA
        '
        Me.dtpSelectorA.Location = New System.Drawing.Point(98, 24)
        Me.dtpSelectorA.Name = "dtpSelectorA"
        Me.dtpSelectorA.Size = New System.Drawing.Size(91, 20)
        Me.dtpSelectorA.TabIndex = 2
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(12, 133)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Tag = "Length"
        Me.lblLength.Text = "Length"
        '
        'chkDefineAsFactor
        '
        Me.chkDefineAsFactor.AutoSize = True
        Me.chkDefineAsFactor.Checked = True
        Me.chkDefineAsFactor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefineAsFactor.Location = New System.Drawing.Point(15, 159)
        Me.chkDefineAsFactor.Name = "chkDefineAsFactor"
        Me.chkDefineAsFactor.Size = New System.Drawing.Size(104, 17)
        Me.chkDefineAsFactor.TabIndex = 11
        Me.chkDefineAsFactor.Tag = "Define_as_factor"
        Me.chkDefineAsFactor.Text = "Define as Factor"
        Me.chkDefineAsFactor.UseVisualStyleBackColor = True
        '
        'lblTimes1
        '
        Me.lblTimes1.AutoSize = True
        Me.lblTimes1.Location = New System.Drawing.Point(148, 108)
        Me.lblTimes1.Name = "lblTimes1"
        Me.lblTimes1.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes1.TabIndex = 10
        Me.lblTimes1.Tag = "Times"
        Me.lblTimes1.Text = "Time(s)"
        '
        'lblRepeatValues
        '
        Me.lblRepeatValues.AutoSize = True
        Me.lblRepeatValues.Location = New System.Drawing.Point(12, 108)
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Size = New System.Drawing.Size(77, 13)
        Me.lblRepeatValues.TabIndex = 8
        Me.lblRepeatValues.Tag = "Repeat_values"
        Me.lblRepeatValues.Text = "Repeat Values"
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteps.Location = New System.Drawing.Point(12, 82)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(58, 13)
        Me.lblSteps.TabIndex = 6
        Me.lblSteps.Tag = "In_steps_of"
        Me.lblSteps.Text = "In Steps of"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(12, 56)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Tag = "To"
        Me.lblTo.Text = "To"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(12, 30)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Tag = "From"
        Me.lblFrom.Text = "From"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(255, 25)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(97, 13)
        Me.lblPreview.TabIndex = 7
        Me.lblPreview.Tag = "Preview"
        Me.lblPreview.Text = "Sequence Preview"
        '
        'txtGetPreview
        '
        Me.txtGetPreview.Location = New System.Drawing.Point(238, 44)
        Me.txtGetPreview.Name = "txtGetPreview"
        Me.txtGetPreview.Size = New System.Drawing.Size(171, 172)
        Me.txtGetPreview.TabIndex = 8
        Me.txtGetPreview.Text = ""
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(7, 325)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(98, 13)
        Me.lblNewColumnName.TabIndex = 12
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name"
        '
        'txtMessage
        '
        Me.txtMessage.Enabled = False
        Me.txtMessage.Location = New System.Drawing.Point(238, 232)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(171, 58)
        Me.txtMessage.TabIndex = 14
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.IsReadOnly = False
        Me.ucrNewColumnName.Location = New System.Drawing.Point(113, 321)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(141, 21)
        Me.ucrNewColumnName.TabIndex = 11
        '
        'ucrSelectDataFrameRegularSequence
        '
        Me.ucrSelectDataFrameRegularSequence.Location = New System.Drawing.Point(10, 10)
        Me.ucrSelectDataFrameRegularSequence.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectDataFrameRegularSequence.Name = "ucrSelectDataFrameRegularSequence"
        Me.ucrSelectDataFrameRegularSequence.Size = New System.Drawing.Size(120, 40)
        Me.ucrSelectDataFrameRegularSequence.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 348)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 412)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.txtGetPreview)
        Me.Controls.Add(Me.grpSequenceDefinition)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrSelectDataFrameRegularSequence)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.grpSequenceType)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegularSequence"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Entry_of_regular_sequence"
        Me.Text = "Entry of regular sequence"
        Me.grpSequenceType.ResumeLayout(False)
        Me.grpSequenceType.PerformLayout()
        Me.grpSequenceDefinition.ResumeLayout(False)
        Me.grpSequenceDefinition.PerformLayout()
        CType(Me.nudNumberofDecimalPlaces, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRepeatValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInStepsOf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSequenceType As GroupBox
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents grpSequenceDefinition As GroupBox
    Friend WithEvents rdoDates As RadioButton
    Friend WithEvents lblSteps As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectDataFrameRegularSequence As ucrDataFrame
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents lblTimes1 As Label
    Friend WithEvents lblRepeatValues As Label
    Friend WithEvents chkDefineAsFactor As CheckBox
    Friend WithEvents dtpSelectorA As DateTimePicker
    Friend WithEvents dtpSelectorB As DateTimePicker
    Friend WithEvents txtGetPreview As RichTextBox
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents nudRepeatValues As NumericUpDown
    Friend WithEvents nudInStepsOf As NumericUpDown
    Friend WithEvents ucrDataFrameLengthForRegularSequence As ucrDataFrameLength
    Friend WithEvents ucrNewColumnName As ucrInputComboBox
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents lblNumberDecimalPlaces As Label
    Friend WithEvents nudNumberofDecimalPlaces As NumericUpDown
End Class
