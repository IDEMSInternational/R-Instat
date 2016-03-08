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
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudRepeatValues = New System.Windows.Forms.NumericUpDown()
        Me.dtpSelectorB = New System.Windows.Forms.DateTimePicker()
        Me.nudInstepsOf = New System.Windows.Forms.NumericUpDown()
        Me.dtpSelectorA = New System.Windows.Forms.DateTimePicker()
        Me.chkDefineAsFactor = New System.Windows.Forms.CheckBox()
        Me.lblTimes1 = New System.Windows.Forms.Label()
        Me.lblRepeatValues = New System.Windows.Forms.Label()
        Me.lblSteps = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.lblFrom = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.cmdRefreshPreview = New System.Windows.Forms.Button()
        Me.txtGetPreview = New System.Windows.Forms.RichTextBox()
        Me.nudLength = New System.Windows.Forms.NumericUpDown()
        Me.ucrNewColumnNameSelectorRegularSequence = New instat.ucrNewColumnName()
        Me.ucrSelectDataFrame = New instat.ucrDataFrame()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpSequenceType.SuspendLayout()
        Me.grpSequenceDefinition.SuspendLayout()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudRepeatValues, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudInstepsOf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSequenceType
        '
        Me.grpSequenceType.Controls.Add(Me.rdoDates)
        Me.grpSequenceType.Controls.Add(Me.rdoNumeric)
        Me.grpSequenceType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpSequenceType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceType.Location = New System.Drawing.Point(12, 51)
        Me.grpSequenceType.Name = "grpSequenceType"
        Me.grpSequenceType.Size = New System.Drawing.Size(195, 39)
        Me.grpSequenceType.TabIndex = 3
        Me.grpSequenceType.TabStop = False
        Me.grpSequenceType.Tag = "Sequence_type"
        Me.grpSequenceType.Text = "Sequence type"
        '
        'rdoDates
        '
        Me.rdoDates.AutoSize = True
        Me.rdoDates.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rdoDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoDates.Location = New System.Drawing.Point(103, 13)
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
        Me.rdoNumeric.Location = New System.Drawing.Point(6, 13)
        Me.rdoNumeric.Name = "rdoNumeric"
        Me.rdoNumeric.Size = New System.Drawing.Size(70, 18)
        Me.rdoNumeric.TabIndex = 0
        Me.rdoNumeric.Tag = "Numeric"
        Me.rdoNumeric.Text = "Numeric"
        Me.rdoNumeric.UseVisualStyleBackColor = True
        '
        'grpSequenceDefinition
        '
        Me.grpSequenceDefinition.Controls.Add(Me.nudTo)
        Me.grpSequenceDefinition.Controls.Add(Me.nudFrom)
        Me.grpSequenceDefinition.Controls.Add(Me.nudRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorB)
        Me.grpSequenceDefinition.Controls.Add(Me.nudInstepsOf)
        Me.grpSequenceDefinition.Controls.Add(Me.dtpSelectorA)
        Me.grpSequenceDefinition.Controls.Add(Me.chkDefineAsFactor)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTimes1)
        Me.grpSequenceDefinition.Controls.Add(Me.lblRepeatValues)
        Me.grpSequenceDefinition.Controls.Add(Me.lblSteps)
        Me.grpSequenceDefinition.Controls.Add(Me.lblTo)
        Me.grpSequenceDefinition.Controls.Add(Me.lblFrom)
        Me.grpSequenceDefinition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSequenceDefinition.Location = New System.Drawing.Point(12, 100)
        Me.grpSequenceDefinition.Name = "grpSequenceDefinition"
        Me.grpSequenceDefinition.Size = New System.Drawing.Size(195, 152)
        Me.grpSequenceDefinition.TabIndex = 4
        Me.grpSequenceDefinition.TabStop = False
        Me.grpSequenceDefinition.Tag = "Sequence_definition"
        Me.grpSequenceDefinition.Text = "Sequence definition"
        Me.grpSequenceDefinition.UseCompatibleTextRendering = True
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(138, 48)
        Me.nudTo.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(51, 20)
        Me.nudTo.TabIndex = 14
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(138, 20)
        Me.nudFrom.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(51, 20)
        Me.nudFrom.TabIndex = 13
        '
        'nudRepeatValues
        '
        Me.nudRepeatValues.Location = New System.Drawing.Point(98, 103)
        Me.nudRepeatValues.Name = "nudRepeatValues"
        Me.nudRepeatValues.Size = New System.Drawing.Size(44, 20)
        Me.nudRepeatValues.TabIndex = 12
        '
        'dtpSelectorB
        '
        Me.dtpSelectorB.Location = New System.Drawing.Point(98, 48)
        Me.dtpSelectorB.Name = "dtpSelectorB"
        Me.dtpSelectorB.Size = New System.Drawing.Size(87, 20)
        Me.dtpSelectorB.TabIndex = 5
        '
        'nudInstepsOf
        '
        Me.nudInstepsOf.Location = New System.Drawing.Point(98, 74)
        Me.nudInstepsOf.Name = "nudInstepsOf"
        Me.nudInstepsOf.Size = New System.Drawing.Size(47, 20)
        Me.nudInstepsOf.TabIndex = 10
        '
        'dtpSelectorA
        '
        Me.dtpSelectorA.Location = New System.Drawing.Point(98, 20)
        Me.dtpSelectorA.Name = "dtpSelectorA"
        Me.dtpSelectorA.Size = New System.Drawing.Size(91, 20)
        Me.dtpSelectorA.TabIndex = 2
        '
        'chkDefineAsFactor
        '
        Me.chkDefineAsFactor.AutoSize = True
        Me.chkDefineAsFactor.Checked = True
        Me.chkDefineAsFactor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDefineAsFactor.Enabled = False
        Me.chkDefineAsFactor.Location = New System.Drawing.Point(9, 129)
        Me.chkDefineAsFactor.Name = "chkDefineAsFactor"
        Me.chkDefineAsFactor.Size = New System.Drawing.Size(101, 17)
        Me.chkDefineAsFactor.TabIndex = 11
        Me.chkDefineAsFactor.Tag = "Define_as_factor"
        Me.chkDefineAsFactor.Text = "Define as factor"
        Me.chkDefineAsFactor.UseVisualStyleBackColor = True
        '
        'lblTimes1
        '
        Me.lblTimes1.AutoSize = True
        Me.lblTimes1.Location = New System.Drawing.Point(144, 108)
        Me.lblTimes1.Name = "lblTimes1"
        Me.lblTimes1.Size = New System.Drawing.Size(41, 13)
        Me.lblTimes1.TabIndex = 10
        Me.lblTimes1.Tag = "Times"
        Me.lblTimes1.Text = "Time(s)"
        '
        'lblRepeatValues
        '
        Me.lblRepeatValues.AutoSize = True
        Me.lblRepeatValues.Location = New System.Drawing.Point(6, 108)
        Me.lblRepeatValues.Name = "lblRepeatValues"
        Me.lblRepeatValues.Size = New System.Drawing.Size(76, 13)
        Me.lblRepeatValues.TabIndex = 8
        Me.lblRepeatValues.Tag = "Repeat_values"
        Me.lblRepeatValues.Text = "Repeat values"
        '
        'lblSteps
        '
        Me.lblSteps.AutoSize = True
        Me.lblSteps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSteps.Location = New System.Drawing.Point(6, 82)
        Me.lblSteps.Name = "lblSteps"
        Me.lblSteps.Size = New System.Drawing.Size(56, 13)
        Me.lblSteps.TabIndex = 6
        Me.lblSteps.Tag = "In_steps_of"
        Me.lblSteps.Text = "In steps of"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTo.Location = New System.Drawing.Point(6, 56)
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
        Me.lblFrom.Location = New System.Drawing.Point(6, 30)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblFrom.TabIndex = 0
        Me.lblFrom.Tag = "From"
        Me.lblFrom.Text = "From"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Location = New System.Drawing.Point(235, 48)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(64, 13)
        Me.lblPreview.TabIndex = 7
        Me.lblPreview.Tag = "Get_preview"
        Me.lblPreview.Text = "Get preview"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(157, 9)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(40, 13)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Tag = "Length"
        Me.lblLength.Text = "Length"
        '
        'cmdRefreshPreview
        '
        Me.cmdRefreshPreview.Location = New System.Drawing.Point(238, 22)
        Me.cmdRefreshPreview.Name = "cmdRefreshPreview"
        Me.cmdRefreshPreview.Size = New System.Drawing.Size(176, 23)
        Me.cmdRefreshPreview.TabIndex = 6
        Me.cmdRefreshPreview.Tag = "Refresh_Preview"
        Me.cmdRefreshPreview.Text = "Refresh Preview"
        Me.cmdRefreshPreview.UseVisualStyleBackColor = True
        '
        'txtGetPreview
        '
        Me.txtGetPreview.Location = New System.Drawing.Point(238, 74)
        Me.txtGetPreview.Name = "txtGetPreview"
        Me.txtGetPreview.Size = New System.Drawing.Size(171, 172)
        Me.txtGetPreview.TabIndex = 8
        Me.txtGetPreview.Text = ""
        '
        'nudLength
        '
        Me.nudLength.Location = New System.Drawing.Point(144, 25)
        Me.nudLength.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.nudLength.Name = "nudLength"
        Me.nudLength.Size = New System.Drawing.Size(57, 20)
        Me.nudLength.TabIndex = 10
        '
        'ucrNewColumnNameSelectorRegularSequence
        '
        Me.ucrNewColumnNameSelectorRegularSequence.Location = New System.Drawing.Point(12, 258)
        Me.ucrNewColumnNameSelectorRegularSequence.Name = "ucrNewColumnNameSelectorRegularSequence"
        Me.ucrNewColumnNameSelectorRegularSequence.Size = New System.Drawing.Size(402, 35)
        Me.ucrNewColumnNameSelectorRegularSequence.TabIndex = 5
        Me.ucrNewColumnNameSelectorRegularSequence.ucrDataFrameSelector = Nothing
        '
        'ucrSelectDataFrame
        '
        Me.ucrSelectDataFrame.Location = New System.Drawing.Point(12, 9)
        Me.ucrSelectDataFrame.Name = "ucrSelectDataFrame"
        Me.ucrSelectDataFrame.Size = New System.Drawing.Size(126, 39)
        Me.ucrSelectDataFrame.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 296)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(402, 55)
        Me.ucrBase.TabIndex = 9
        '
        'dlgRegularSequence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 351)
        Me.Controls.Add(Me.nudLength)
        Me.Controls.Add(Me.txtGetPreview)
        Me.Controls.Add(Me.cmdRefreshPreview)
        Me.Controls.Add(Me.grpSequenceDefinition)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.ucrNewColumnNameSelectorRegularSequence)
        Me.Controls.Add(Me.ucrSelectDataFrame)
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
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudRepeatValues, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudInstepsOf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLength, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ucrSelectDataFrame As ucrDataFrame
    Friend WithEvents ucrNewColumnNameSelectorRegularSequence As ucrNewColumnName
    Friend WithEvents lblPreview As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents cmdRefreshPreview As Button
    Friend WithEvents lblTimes1 As Label
    Friend WithEvents lblRepeatValues As Label
    Friend WithEvents chkDefineAsFactor As CheckBox
    Friend WithEvents dtpSelectorA As DateTimePicker
    Friend WithEvents dtpSelectorB As DateTimePicker
    Friend WithEvents txtGetPreview As RichTextBox
    Friend WithEvents nudTo As NumericUpDown
    Friend WithEvents nudFrom As NumericUpDown
    Friend WithEvents nudRepeatValues As NumericUpDown
    Friend WithEvents nudInstepsOf As NumericUpDown
    Friend WithEvents nudLength As NumericUpDown
End Class
