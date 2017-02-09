<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCliBoxplot
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.lblThreshold = New System.Windows.Forms.Label()
        Me.lblWhiskLineType = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblVariable = New System.Windows.Forms.Label()
        Me.lblYLabel = New System.Windows.Forms.Label()
        Me.lblXLabel = New System.Windows.Forms.Label()
        Me.lblDataPeriodLabel = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblBorder = New System.Windows.Forms.Label()
        Me.lblAT = New System.Windows.Forms.Label()
        Me.lblLog = New System.Windows.Forms.Label()
        Me.lblpars = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputDataPeriod = New instat.ucrInputTextBox()
        Me.ucrInputVariable = New instat.ucrInputTextBox()
        Me.ucrInputXLabel = New instat.ucrInputTextBox()
        Me.ucrInputWidth = New instat.ucrInputTextBox()
        Me.ucrInputYLabel = New instat.ucrInputTextBox()
        Me.ucrInputFactorLab = New instat.ucrInputTextBox()
        Me.ucrInputColour = New instat.ucrInputTextBox()
        Me.ucrInputLog = New instat.ucrInputTextBox()
        Me.ucrInputAt = New instat.ucrInputTextBox()
        Me.ucrInputBorder = New instat.ucrInputTextBox()
        Me.ucrInputPars = New instat.ucrInputTextBox()
        Me.ucrNudWhiskLineType = New instat.ucrNud()
        Me.ucrNudThreshold = New instat.ucrNud()
        Me.ucrNudRange = New instat.ucrNud()
        Me.ucrChkVariableWidth = New instat.ucrCheck()
        Me.ucrChkPlot = New instat.ucrCheck()
        Me.ucrChkNotch = New instat.ucrCheck()
        Me.ucrChkOutline = New instat.ucrCheck()
        Me.ucrChkMonthAbbreviations = New instat.ucrCheck()
        Me.ucrChkHorizontal = New instat.ucrCheck()
        Me.ucrChkFactorLevel = New instat.ucrCheck()
        Me.ucrChkAdd = New instat.ucrCheck()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Data list not implemented"
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkVariableWidth)
        Me.grpOptions.Controls.Add(Me.ucrChkPlot)
        Me.grpOptions.Controls.Add(Me.ucrChkNotch)
        Me.grpOptions.Controls.Add(Me.ucrChkOutline)
        Me.grpOptions.Controls.Add(Me.ucrChkMonthAbbreviations)
        Me.grpOptions.Controls.Add(Me.ucrChkHorizontal)
        Me.grpOptions.Controls.Add(Me.ucrChkFactorLevel)
        Me.grpOptions.Controls.Add(Me.ucrChkAdd)
        Me.grpOptions.Location = New System.Drawing.Point(256, 148)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(251, 124)
        Me.grpOptions.TabIndex = 9
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(355, 277)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(39, 13)
        Me.lblRange.TabIndex = 14
        Me.lblRange.Tag = "Range"
        Me.lblRange.Text = "Range"
        '
        'lblThreshold
        '
        Me.lblThreshold.AutoSize = True
        Me.lblThreshold.Location = New System.Drawing.Point(206, 278)
        Me.lblThreshold.Name = "lblThreshold"
        Me.lblThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblThreshold.TabIndex = 15
        Me.lblThreshold.Tag = "Threshold"
        Me.lblThreshold.Text = "Threshold"
        '
        'lblWhiskLineType
        '
        Me.lblWhiskLineType.AutoSize = True
        Me.lblWhiskLineType.Location = New System.Drawing.Point(25, 277)
        Me.lblWhiskLineType.Name = "lblWhiskLineType"
        Me.lblWhiskLineType.Size = New System.Drawing.Size(87, 13)
        Me.lblWhiskLineType.TabIndex = 16
        Me.lblWhiskLineType.Tag = "Whisk_line_type"
        Me.lblWhiskLineType.Text = "Whisk Line Type"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(30, 43)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(27, 13)
        Me.lblTitle.TabIndex = 14
        Me.lblTitle.Tag = "Title"
        Me.lblTitle.Text = "Title"
        '
        'lblVariable
        '
        Me.lblVariable.AutoSize = True
        Me.lblVariable.Location = New System.Drawing.Point(30, 69)
        Me.lblVariable.Name = "lblVariable"
        Me.lblVariable.Size = New System.Drawing.Size(45, 13)
        Me.lblVariable.TabIndex = 15
        Me.lblVariable.Tag = "Variable"
        Me.lblVariable.Text = "Variable"
        '
        'lblYLabel
        '
        Me.lblYLabel.AutoSize = True
        Me.lblYLabel.Location = New System.Drawing.Point(30, 95)
        Me.lblYLabel.Name = "lblYLabel"
        Me.lblYLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblYLabel.TabIndex = 16
        Me.lblYLabel.Tag = "Y_Label"
        Me.lblYLabel.Text = "Y Label"
        '
        'lblXLabel
        '
        Me.lblXLabel.AutoSize = True
        Me.lblXLabel.Location = New System.Drawing.Point(32, 121)
        Me.lblXLabel.Name = "lblXLabel"
        Me.lblXLabel.Size = New System.Drawing.Size(43, 13)
        Me.lblXLabel.TabIndex = 17
        Me.lblXLabel.Tag = "X_Label"
        Me.lblXLabel.Text = "X Label"
        '
        'lblDataPeriodLabel
        '
        Me.lblDataPeriodLabel.AutoSize = True
        Me.lblDataPeriodLabel.Location = New System.Drawing.Point(25, 148)
        Me.lblDataPeriodLabel.Name = "lblDataPeriodLabel"
        Me.lblDataPeriodLabel.Size = New System.Drawing.Size(92, 13)
        Me.lblDataPeriodLabel.TabIndex = 18
        Me.lblDataPeriodLabel.Tag = "Data_Period_Label"
        Me.lblDataPeriodLabel.Text = "Data Period Label"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(30, 174)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 19
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(30, 201)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(35, 13)
        Me.lblWidth.TabIndex = 20
        Me.lblWidth.Tag = "Width"
        Me.lblWidth.Text = "Width"
        '
        'lblColour
        '
        Me.lblColour.AutoSize = True
        Me.lblColour.Location = New System.Drawing.Point(30, 229)
        Me.lblColour.Name = "lblColour"
        Me.lblColour.Size = New System.Drawing.Size(37, 13)
        Me.lblColour.TabIndex = 21
        Me.lblColour.Tag = "Colour"
        Me.lblColour.Text = "Colour"
        '
        'lblBorder
        '
        Me.lblBorder.AutoSize = True
        Me.lblBorder.Location = New System.Drawing.Point(241, 95)
        Me.lblBorder.Name = "lblBorder"
        Me.lblBorder.Size = New System.Drawing.Size(38, 13)
        Me.lblBorder.TabIndex = 22
        Me.lblBorder.Tag = "Border"
        Me.lblBorder.Text = "Border"
        '
        'lblAT
        '
        Me.lblAT.AutoSize = True
        Me.lblAT.Location = New System.Drawing.Point(241, 69)
        Me.lblAT.Name = "lblAT"
        Me.lblAT.Size = New System.Drawing.Size(21, 13)
        Me.lblAT.TabIndex = 23
        Me.lblAT.Tag = "AT"
        Me.lblAT.Text = "AT"
        '
        'lblLog
        '
        Me.lblLog.AutoSize = True
        Me.lblLog.Location = New System.Drawing.Point(241, 43)
        Me.lblLog.Name = "lblLog"
        Me.lblLog.Size = New System.Drawing.Size(25, 13)
        Me.lblLog.TabIndex = 24
        Me.lblLog.Tag = "Log"
        Me.lblLog.Text = "Log"
        '
        'lblpars
        '
        Me.lblpars.AutoSize = True
        Me.lblpars.Location = New System.Drawing.Point(241, 121)
        Me.lblpars.Name = "lblpars"
        Me.lblpars.Size = New System.Drawing.Size(28, 13)
        Me.lblpars.TabIndex = 25
        Me.lblpars.Tag = "pars"
        Me.lblpars.Text = "Pars"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 301)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 62)
        Me.ucrBase.TabIndex = 0
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.bAddRemoveParameter = True
        Me.ucrInputTitle.bChangeParameterValue = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(128, 36)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputTitle.TabIndex = 27
        '
        'ucrInputDataPeriod
        '
        Me.ucrInputDataPeriod.bAddRemoveParameter = True
        Me.ucrInputDataPeriod.bChangeParameterValue = True
        Me.ucrInputDataPeriod.IsMultiline = False
        Me.ucrInputDataPeriod.IsReadOnly = False
        Me.ucrInputDataPeriod.Location = New System.Drawing.Point(128, 140)
        Me.ucrInputDataPeriod.Name = "ucrInputDataPeriod"
        Me.ucrInputDataPeriod.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputDataPeriod.TabIndex = 27
        '
        'ucrInputVariable
        '
        Me.ucrInputVariable.bAddRemoveParameter = True
        Me.ucrInputVariable.bChangeParameterValue = True
        Me.ucrInputVariable.IsMultiline = False
        Me.ucrInputVariable.IsReadOnly = False
        Me.ucrInputVariable.Location = New System.Drawing.Point(128, 61)
        Me.ucrInputVariable.Name = "ucrInputVariable"
        Me.ucrInputVariable.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputVariable.TabIndex = 27
        '
        'ucrInputXLabel
        '
        Me.ucrInputXLabel.bAddRemoveParameter = True
        Me.ucrInputXLabel.bChangeParameterValue = True
        Me.ucrInputXLabel.IsMultiline = False
        Me.ucrInputXLabel.IsReadOnly = False
        Me.ucrInputXLabel.Location = New System.Drawing.Point(128, 113)
        Me.ucrInputXLabel.Name = "ucrInputXLabel"
        Me.ucrInputXLabel.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputXLabel.TabIndex = 27
        '
        'ucrInputWidth
        '
        Me.ucrInputWidth.bAddRemoveParameter = True
        Me.ucrInputWidth.bChangeParameterValue = True
        Me.ucrInputWidth.IsMultiline = False
        Me.ucrInputWidth.IsReadOnly = False
        Me.ucrInputWidth.Location = New System.Drawing.Point(128, 193)
        Me.ucrInputWidth.Name = "ucrInputWidth"
        Me.ucrInputWidth.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputWidth.TabIndex = 28
        '
        'ucrInputYLabel
        '
        Me.ucrInputYLabel.bAddRemoveParameter = True
        Me.ucrInputYLabel.bChangeParameterValue = True
        Me.ucrInputYLabel.IsMultiline = False
        Me.ucrInputYLabel.IsReadOnly = False
        Me.ucrInputYLabel.Location = New System.Drawing.Point(128, 87)
        Me.ucrInputYLabel.Name = "ucrInputYLabel"
        Me.ucrInputYLabel.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputYLabel.TabIndex = 29
        '
        'ucrInputFactorLab
        '
        Me.ucrInputFactorLab.bAddRemoveParameter = True
        Me.ucrInputFactorLab.bChangeParameterValue = True
        Me.ucrInputFactorLab.IsMultiline = False
        Me.ucrInputFactorLab.IsReadOnly = False
        Me.ucrInputFactorLab.Location = New System.Drawing.Point(128, 166)
        Me.ucrInputFactorLab.Name = "ucrInputFactorLab"
        Me.ucrInputFactorLab.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputFactorLab.TabIndex = 30
        '
        'ucrInputColour
        '
        Me.ucrInputColour.bAddRemoveParameter = True
        Me.ucrInputColour.bChangeParameterValue = True
        Me.ucrInputColour.IsMultiline = False
        Me.ucrInputColour.IsReadOnly = False
        Me.ucrInputColour.Location = New System.Drawing.Point(128, 221)
        Me.ucrInputColour.Name = "ucrInputColour"
        Me.ucrInputColour.Size = New System.Drawing.Size(107, 21)
        Me.ucrInputColour.TabIndex = 31
        '
        'ucrInputLog
        '
        Me.ucrInputLog.bAddRemoveParameter = True
        Me.ucrInputLog.bChangeParameterValue = True
        Me.ucrInputLog.IsMultiline = False
        Me.ucrInputLog.IsReadOnly = False
        Me.ucrInputLog.Location = New System.Drawing.Point(282, 35)
        Me.ucrInputLog.Name = "ucrInputLog"
        Me.ucrInputLog.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputLog.TabIndex = 32
        '
        'ucrInputAt
        '
        Me.ucrInputAt.bAddRemoveParameter = True
        Me.ucrInputAt.bChangeParameterValue = True
        Me.ucrInputAt.IsMultiline = False
        Me.ucrInputAt.IsReadOnly = False
        Me.ucrInputAt.Location = New System.Drawing.Point(282, 63)
        Me.ucrInputAt.Name = "ucrInputAt"
        Me.ucrInputAt.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputAt.TabIndex = 33
        '
        'ucrInputBorder
        '
        Me.ucrInputBorder.bAddRemoveParameter = True
        Me.ucrInputBorder.bChangeParameterValue = True
        Me.ucrInputBorder.IsMultiline = False
        Me.ucrInputBorder.IsReadOnly = False
        Me.ucrInputBorder.Location = New System.Drawing.Point(282, 86)
        Me.ucrInputBorder.Name = "ucrInputBorder"
        Me.ucrInputBorder.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputBorder.TabIndex = 34
        '
        'ucrInputPars
        '
        Me.ucrInputPars.bAddRemoveParameter = True
        Me.ucrInputPars.bChangeParameterValue = True
        Me.ucrInputPars.IsMultiline = False
        Me.ucrInputPars.IsReadOnly = False
        Me.ucrInputPars.Location = New System.Drawing.Point(282, 112)
        Me.ucrInputPars.Name = "ucrInputPars"
        Me.ucrInputPars.Size = New System.Drawing.Size(91, 21)
        Me.ucrInputPars.TabIndex = 35
        '
        'ucrNudWhiskLineType
        '
        Me.ucrNudWhiskLineType.bAddRemoveParameter = True
        Me.ucrNudWhiskLineType.bChangeParameterValue = True
        Me.ucrNudWhiskLineType.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWhiskLineType.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWhiskLineType.Location = New System.Drawing.Point(117, 275)
        Me.ucrNudWhiskLineType.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudWhiskLineType.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWhiskLineType.Name = "ucrNudWhiskLineType"
        Me.ucrNudWhiskLineType.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudWhiskLineType.TabIndex = 36
        Me.ucrNudWhiskLineType.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudThreshold
        '
        Me.ucrNudThreshold.bAddRemoveParameter = True
        Me.ucrNudThreshold.bChangeParameterValue = True
        Me.ucrNudThreshold.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudThreshold.Location = New System.Drawing.Point(262, 275)
        Me.ucrNudThreshold.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudThreshold.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudThreshold.Name = "ucrNudThreshold"
        Me.ucrNudThreshold.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudThreshold.TabIndex = 37
        Me.ucrNudThreshold.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudRange
        '
        Me.ucrNudRange.bAddRemoveParameter = True
        Me.ucrNudRange.bChangeParameterValue = True
        Me.ucrNudRange.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRange.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudRange.Location = New System.Drawing.Point(400, 275)
        Me.ucrNudRange.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudRange.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudRange.Name = "ucrNudRange"
        Me.ucrNudRange.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudRange.TabIndex = 38
        Me.ucrNudRange.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkVariableWidth
        '
        Me.ucrChkVariableWidth.bAddRemoveParameter = True
        Me.ucrChkVariableWidth.bChangeParameterValue = True
        Me.ucrChkVariableWidth.Checked = False
        Me.ucrChkVariableWidth.Location = New System.Drawing.Point(6, 68)
        Me.ucrChkVariableWidth.Name = "ucrChkVariableWidth"
        Me.ucrChkVariableWidth.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkVariableWidth.TabIndex = 40
        '
        'ucrChkPlot
        '
        Me.ucrChkPlot.bAddRemoveParameter = True
        Me.ucrChkPlot.bChangeParameterValue = True
        Me.ucrChkPlot.Checked = False
        Me.ucrChkPlot.Location = New System.Drawing.Point(6, 42)
        Me.ucrChkPlot.Name = "ucrChkPlot"
        Me.ucrChkPlot.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPlot.TabIndex = 41
        '
        'ucrChkNotch
        '
        Me.ucrChkNotch.bAddRemoveParameter = True
        Me.ucrChkNotch.bChangeParameterValue = True
        Me.ucrChkNotch.Checked = False
        Me.ucrChkNotch.Location = New System.Drawing.Point(6, 94)
        Me.ucrChkNotch.Name = "ucrChkNotch"
        Me.ucrChkNotch.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkNotch.TabIndex = 42
        '
        'ucrChkOutline
        '
        Me.ucrChkOutline.bAddRemoveParameter = True
        Me.ucrChkOutline.bChangeParameterValue = True
        Me.ucrChkOutline.Checked = False
        Me.ucrChkOutline.Location = New System.Drawing.Point(131, 16)
        Me.ucrChkOutline.Name = "ucrChkOutline"
        Me.ucrChkOutline.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkOutline.TabIndex = 43
        '
        'ucrChkMonthAbbreviations
        '
        Me.ucrChkMonthAbbreviations.bAddRemoveParameter = True
        Me.ucrChkMonthAbbreviations.bChangeParameterValue = True
        Me.ucrChkMonthAbbreviations.Checked = False
        Me.ucrChkMonthAbbreviations.Location = New System.Drawing.Point(131, 42)
        Me.ucrChkMonthAbbreviations.Name = "ucrChkMonthAbbreviations"
        Me.ucrChkMonthAbbreviations.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMonthAbbreviations.TabIndex = 44
        '
        'ucrChkHorizontal
        '
        Me.ucrChkHorizontal.bAddRemoveParameter = True
        Me.ucrChkHorizontal.bChangeParameterValue = True
        Me.ucrChkHorizontal.Checked = False
        Me.ucrChkHorizontal.Location = New System.Drawing.Point(131, 68)
        Me.ucrChkHorizontal.Name = "ucrChkHorizontal"
        Me.ucrChkHorizontal.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkHorizontal.TabIndex = 45
        '
        'ucrChkFactorLevel
        '
        Me.ucrChkFactorLevel.bAddRemoveParameter = True
        Me.ucrChkFactorLevel.bChangeParameterValue = True
        Me.ucrChkFactorLevel.Checked = False
        Me.ucrChkFactorLevel.Location = New System.Drawing.Point(131, 94)
        Me.ucrChkFactorLevel.Name = "ucrChkFactorLevel"
        Me.ucrChkFactorLevel.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkFactorLevel.TabIndex = 46
        '
        'ucrChkAdd
        '
        Me.ucrChkAdd.bAddRemoveParameter = True
        Me.ucrChkAdd.bChangeParameterValue = True
        Me.ucrChkAdd.Checked = False
        Me.ucrChkAdd.Location = New System.Drawing.Point(6, 16)
        Me.ucrChkAdd.Name = "ucrChkAdd"
        Me.ucrChkAdd.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkAdd.TabIndex = 47
        '
        'dlgCliBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 359)
        Me.Controls.Add(Me.ucrNudRange)
        Me.Controls.Add(Me.ucrNudThreshold)
        Me.Controls.Add(Me.ucrNudWhiskLineType)
        Me.Controls.Add(Me.ucrInputPars)
        Me.Controls.Add(Me.ucrInputBorder)
        Me.Controls.Add(Me.ucrInputAt)
        Me.Controls.Add(Me.ucrInputLog)
        Me.Controls.Add(Me.ucrInputColour)
        Me.Controls.Add(Me.ucrInputFactorLab)
        Me.Controls.Add(Me.ucrInputYLabel)
        Me.Controls.Add(Me.ucrInputWidth)
        Me.Controls.Add(Me.ucrInputVariable)
        Me.Controls.Add(Me.ucrInputXLabel)
        Me.Controls.Add(Me.ucrInputDataPeriod)
        Me.Controls.Add(Me.ucrInputTitle)
        Me.Controls.Add(Me.lblpars)
        Me.Controls.Add(Me.lblLog)
        Me.Controls.Add(Me.lblAT)
        Me.Controls.Add(Me.lblBorder)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblVariable)
        Me.Controls.Add(Me.lblYLabel)
        Me.Controls.Add(Me.lblXLabel)
        Me.Controls.Add(Me.lblDataPeriodLabel)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblColour)
        Me.Controls.Add(Me.lblWhiskLineType)
        Me.Controls.Add(Me.lblThreshold)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgCliBoxplot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliboxplot"
        Me.grpOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents lblRange As Label
    Friend WithEvents lblThreshold As Label
    Friend WithEvents lblWhiskLineType As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblVariable As Label
    Friend WithEvents lblYLabel As Label
    Friend WithEvents lblXLabel As Label
    Friend WithEvents lblDataPeriodLabel As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblColour As Label
    Friend WithEvents lblBorder As Label
    Friend WithEvents lblAT As Label
    Friend WithEvents lblLog As Label
    Friend WithEvents lblpars As Label
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents ucrInputDataPeriod As ucrInputTextBox
    Friend WithEvents ucrInputVariable As ucrInputTextBox
    Friend WithEvents ucrInputXLabel As ucrInputTextBox
    Friend WithEvents ucrInputWidth As ucrInputTextBox
    Friend WithEvents ucrInputYLabel As ucrInputTextBox
    Friend WithEvents ucrInputFactorLab As ucrInputTextBox
    Friend WithEvents ucrInputColour As ucrInputTextBox
    Friend WithEvents ucrInputLog As ucrInputTextBox
    Friend WithEvents ucrInputAt As ucrInputTextBox
    Friend WithEvents ucrInputBorder As ucrInputTextBox
    Friend WithEvents ucrInputPars As ucrInputTextBox
    Friend WithEvents ucrChkVariableWidth As ucrCheck
    Friend WithEvents ucrChkPlot As ucrCheck
    Friend WithEvents ucrChkNotch As ucrCheck
    Friend WithEvents ucrChkOutline As ucrCheck
    Friend WithEvents ucrChkMonthAbbreviations As ucrCheck
    Friend WithEvents ucrChkHorizontal As ucrCheck
    Friend WithEvents ucrChkFactorLevel As ucrCheck
    Friend WithEvents ucrChkAdd As ucrCheck
    Friend WithEvents ucrNudWhiskLineType As ucrNud
    Friend WithEvents ucrNudThreshold As ucrNud
    Friend WithEvents ucrNudRange As ucrNud
End Class
