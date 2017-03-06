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
        Me.grpSequenceDefinition = New System.Windows.Forms.GroupBox()
        Me.ucrNudNumberOfDecimalPlaces = New instat.ucrNud()
        Me.ucrNudRepeatValues = New instat.ucrNud()
        Me.ucrNudInStepsOf = New instat.ucrNud()
        Me.ucrNudTo = New instat.ucrNud()
        Me.ucrNudFrom = New instat.ucrNud()
        Me.lblNumberDecimalPlaces = New System.Windows.Forms.Label()
        Me.ucrDataFrameLengthForRegularSequence = New instat.ucrDataFrameLength()
        Me.dtpSelectorB = New System.Windows.Forms.DateTimePicker()
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
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.grpSequenceType = New System.Windows.Forms.GroupBox()
        Me.rdoNumeric = New System.Windows.Forms.RadioButton()
        Me.rdoDates = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSequenceType = New instat.UcrPanel()
        Me.ucrNewColumnName = New instat.ucrSave()
        Me.ucrSelectDataFrameRegularSequence = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSequenceDefinition.SuspendLayout()
        Me.grpSequenceType.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSequenceDefinition
        '
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudNumberOfDecimalPlaces)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudInStepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudTo)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrNudFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.lblNumberDecimalPlaces)
        Me.grpSequenceDefinition.Controls.Add(Me.ucrDataFrameLengthForRegularSequence)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorB)
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
        Me.grpSequenceDefinition.TabIndex = 2
        Me.grpSequenceDefinition.TabStop = False
        Me.grpSequenceDefinition.Tag = "Sequence_definition"
        Me.grpSequenceDefinition.Text = "Sequence Definition"
        Me.grpSequenceDefinition.UseCompatibleTextRendering = True
        '
        'ucrNudNumberOfDecimalPlaces
        '
        Me.ucrNudNumberOfDecimalPlaces.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfDecimalPlaces.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberOfDecimalPlaces.Location = New System.Drawing.Point(142, 178)
        Me.ucrNudNumberOfDecimalPlaces.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberOfDecimalPlaces.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberOfDecimalPlaces.Name = "ucrNudNumberOfDecimalPlaces"
        Me.ucrNudNumberOfDecimalPlaces.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNumberOfDecimalPlaces.TabIndex = 24
        Me.ucrNudNumberOfDecimalPlaces.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRepeatValues
        '
        Me.ucrNudRepeatValues.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRepeatValues.Location = New System.Drawing.Point(99, 101)
        Me.ucrNudRepeatValues.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRepeatValues.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRepeatValues.Name = "ucrNudRepeatValues"
        Me.ucrNudRepeatValues.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRepeatValues.TabIndex = 20
        Me.ucrNudRepeatValues.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudInStepsOf
        '
        Me.ucrNudInStepsOf.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudInStepsOf.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudInStepsOf.Location = New System.Drawing.Point(99, 75)
        Me.ucrNudInStepsOf.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudInStepsOf.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudInStepsOf.Name = "ucrNudInStepsOf"
        Me.ucrNudInStepsOf.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudInStepsOf.TabIndex = 19
        Me.ucrNudInStepsOf.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTo
        '
        Me.ucrNudTo.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTo.Location = New System.Drawing.Point(99, 51)
        Me.ucrNudTo.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTo.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTo.Name = "ucrNudTo"
        Me.ucrNudTo.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTo.TabIndex = 18
        Me.ucrNudTo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudFrom
        '
        Me.ucrNudFrom.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFrom.Location = New System.Drawing.Point(99, 25)
        Me.ucrNudFrom.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFrom.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFrom.Name = "ucrNudFrom"
        Me.ucrNudFrom.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFrom.TabIndex = 17
        Me.ucrNudFrom.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumberDecimalPlaces
        '
        Me.lblNumberDecimalPlaces.AutoSize = True
        Me.lblNumberDecimalPlaces.Location = New System.Drawing.Point(10, 183)
        Me.lblNumberDecimalPlaces.Name = "lblNumberDecimalPlaces"
        Me.lblNumberDecimalPlaces.Size = New System.Drawing.Size(135, 13)
        Me.lblNumberDecimalPlaces.TabIndex = 14
        Me.lblNumberDecimalPlaces.Text = "Number of Decimal Places:"
        '
        'ucrDataFrameLengthForRegularSequence
        '
        Me.ucrDataFrameLengthForRegularSequence.Location = New System.Drawing.Point(98, 130)
        Me.ucrDataFrameLengthForRegularSequence.Name = "ucrDataFrameLengthForRegularSequence"
        Me.ucrDataFrameLengthForRegularSequence.Size = New System.Drawing.Size(51, 23)
        Me.ucrDataFrameLengthForRegularSequence.TabIndex = 12
        Me.ucrDataFrameLengthForRegularSequence.ucrDataFrameSelector = Nothing
        '
        'dtpSelectorB
        '
        Me.dtpSelectorB.Location = New System.Drawing.Point(98, 51)
        Me.dtpSelectorB.Name = "dtpSelectorB"
        Me.dtpSelectorB.Size = New System.Drawing.Size(87, 20)
        Me.dtpSelectorB.TabIndex = 5
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
        Me.lblLength.Location = New System.Drawing.Point(10, 133)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(43, 13)
        Me.lblLength.TabIndex = 11
        Me.lblLength.Tag = "Length"
        Me.lblLength.Text = "Length:"
        '
        'chkDefineAsFactor
        '
        Me.chkDefineAsFactor.AutoSize = True
        Me.chkDefineAsFactor.Checked = True
        Me.chkDefineAsFactor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefineAsFactor.Location = New System.Drawing.Point(10, 159)
        Me.chkDefineAsFactor.Name = "chkDefineAsFactor"
        Me.chkDefineAsFactor.Size = New System.Drawing.Size(104, 17)
        Me.chkDefineAsFactor.TabIndex = 13
        Me.chkDefineAsFactor.Tag = "Define_as_factor"
        Me.chkDefineAsFactor.Text = "Define as Factor"
        Me.chkDefineAsFactor.UseVisualStyleBackColor = True
        '
        'lblTimes1
        '
        Me.lblTimes1.AutoSize = True
        Me.lblTimes1.Location = New System.Drawing.Point(151, 108)
        Me.lblTimes1.Name = "lblTimes1"
        Me.lblTimes1.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes1.TabIndex = 10
        Me.lblTimes1.Tag = "Times"
        Me.lblTimes1.Text = "Time(s)"
        '
        'lblRepeatValues
        '
        Me.lblRepeatValues.AutoSize = True
        Me.lblRepeatValues.Location = New System.Drawing.Point(10, 108)
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Size = New System.Drawing.Size(80, 13)
        Me.lblRepeatValues.TabIndex = 8
        Me.lblRepeatValues.Tag = "Repeat_values"
        Me.lblRepeatValues.Text = "Repeat Values:"
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteps.Location = New System.Drawing.Point(10, 82)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(61, 13)
        Me.lblSteps.TabIndex = 6
        Me.lblSteps.Tag = "In_steps_of"
        Me.lblSteps.Text = "In Steps of:"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(10, 56)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(23, 13)
        Me.lblTo.TabIndex = 3
        Me.lblTo.Tag = "To"
        Me.lblTo.Text = "To:"
        '
        'lblFrom
        '
        Me.lblFrom.AutoSize = True
        Me.lblFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.Location = New System.Drawing.Point(10, 30)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Tag = "From:"
        Me.lblFrom.Text = "From:"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(239, 28)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(100, 13)
        Me.lblPreview.TabIndex = 3
        Me.lblPreview.Tag = "Preview"
        Me.lblPreview.Text = "Sequence Preview:"
        '
        'txtGetPreview
        '
        Me.txtGetPreview.Location = New System.Drawing.Point(238, 44)
        Me.txtGetPreview.Name = "txtGetPreview"
        Me.txtGetPreview.Size = New System.Drawing.Size(171, 172)
        Me.txtGetPreview.TabIndex = 4
        Me.txtGetPreview.Text = ""
        '
        'txtMessage
        '
        Me.txtMessage.Enabled = False
        Me.txtMessage.Location = New System.Drawing.Point(238, 232)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.ReadOnly = True
        Me.txtMessage.Size = New System.Drawing.Size(171, 58)
        Me.txtMessage.TabIndex = 5
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdoNumeric)
        Me.grpSequenceType.Controls.Add(Me.rdoDates)
        Me.grpSequenceType.Controls.Add(Me.ucrPnlSequenceType)
        Me.grpSequenceType.Location = New System.Drawing.Point(16, 53)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(199, 52)
        Me.grpSequenceType.TabIndex = 16
        Me.grpSequenceType.TabStop = False
        Me.grpSequenceType.Text = "Sequence Type"
        '
        'rdoNumeric
        '
        Me.rdoNumeric.AutoSize = True
        Me.rdoNumeric.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoNumeric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoNumeric.Location = New System.Drawing.Point(10, 19)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(70, 18)
        Me.rdoNumeric.TabIndex = 1
        Me.rdoNumeric.Tag = "Numeric"
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'rdoDates
        '
        Me.rdoDates.AutoSize = True
        Me.rdoDates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDates.Location = New System.Drawing.Point(93, 20)
        Me.rdoDates.Name = "rdoDates"
        Me.rdoDates.Size = New System.Drawing.Size(59, 18)
        Me.rdoDates.TabIndex = 2
        Me.rdoDates.Tag = "Dates"
        Me.rdoDates.Text = "Dates"
        Me.rdoDates.UseVisualStyleBackColor = True
        '
        'ucrPnlSequenceType
        '
        Me.ucrPnlSequenceType.Location = New System.Drawing.Point(4, 9)
        Me.ucrPnlSequenceType.Name = "ucrPnlSequenceType"
        Me.ucrPnlSequenceType.Size = New System.Drawing.Size(189, 29)
        Me.ucrPnlSequenceType.TabIndex = 0
        '
        'ucrNewColumnName
        '
        Me.ucrNewColumnName.Location = New System.Drawing.Point(11, 321)
        Me.ucrNewColumnName.Name = "ucrNewColumnName"
        Me.ucrNewColumnName.Size = New System.Drawing.Size(294, 24)
        Me.ucrNewColumnName.TabIndex = 9
        '
        'ucrSelectDataFrameRegularSequence
        '
        Me.ucrSelectDataFrameRegularSequence.bUseCurrentFilter = True
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
        Me.ucrBase.TabIndex = 8
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 412)
        Me.Controls.Add(Me.grpSequenceType)
        Me.Controls.Add(Me.ucrNewColumnName)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtGetPreview)
        Me.Controls.Add(Me.grpSequenceDefinition)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrSelectDataFrameRegularSequence)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgRegularSequence"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Entry_of_regular_sequence"
        Me.Text = "Regular Sequence"
        Me.grpSequenceDefinition.ResumeLayout(False)
        Me.grpSequenceDefinition.PerformLayout()
        Me.grpSequenceType.ResumeLayout(False)
        Me.grpSequenceType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpSequenceDefinition As GroupBox
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
    Friend WithEvents ucrDataFrameLengthForRegularSequence As ucrDataFrameLength
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents ucrNudRepeatValues As ucrNud
    Friend WithEvents ucrNudInStepsOf As ucrNud
    Friend WithEvents ucrNudTo As ucrNud
    Friend WithEvents ucrNudFrom As ucrNud
    Friend WithEvents lblNumberDecimalPlaces As Label
    Friend WithEvents ucrNewColumnName As ucrSave
    Friend WithEvents grpSequenceType As GroupBox
    Friend WithEvents rdoNumeric As RadioButton
    Friend WithEvents rdoDates As RadioButton
    Friend WithEvents ucrPnlSequenceType As UcrPanel
    Friend WithEvents ucrNudNumberOfDecimalPlaces As ucrNud
End Class
