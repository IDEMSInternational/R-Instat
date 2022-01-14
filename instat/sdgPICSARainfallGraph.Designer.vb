<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgPICSARainfallGraph
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
        Me.lblXTo = New System.Windows.Forms.Label()
        Me.lblXFrom = New System.Windows.Forms.Label()
        Me.lblXInStepsOf = New System.Windows.Forms.Label()
        Me.tbPICSA = New System.Windows.Forms.TabControl()
        Me.tpTitles = New System.Windows.Forms.TabPage()
        Me.grpGraphTitles = New System.Windows.Forms.GroupBox()
        Me.lblCaptionSize = New System.Windows.Forms.Label()
        Me.lblSubTitleSize = New System.Windows.Forms.Label()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ucrNudCaptionSize = New instat.ucrNud()
        Me.ucrNudSubTitleSize = New instat.ucrNud()
        Me.ucrNudTitleSize = New instat.ucrNud()
        Me.ucrInputGraphcCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.lblXAxisTitleSize = New System.Windows.Forms.Label()
        Me.rdoAutoXAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoTitleXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudXAxisTitleSize = New instat.ucrNud()
        Me.ucrPnlXAxisTitle = New instat.UcrPanel()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.rdoSpecifyYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
        Me.tpXAxis = New System.Windows.Forms.TabPage()
        Me.grpXAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.ucrChkSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.ucrInputXFrom = New instat.ucrInputTextBox()
        Me.ucrInputXInStepsOf = New instat.ucrInputTextBox()
        Me.ucrNudXaxisLabelSize = New instat.ucrNud()
        Me.ucrInputXTo = New instat.ucrInputTextBox()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.tpYAxis = New System.Windows.Forms.TabPage()
        Me.ucrNudUpperLimit = New instat.ucrNud()
        Me.ucrNudLowerLimit = New instat.ucrNud()
        Me.lblDateDisplayFormat = New System.Windows.Forms.Label()
        Me.rdoYDate = New System.Windows.Forms.RadioButton()
        Me.rdoYNumeric = New System.Windows.Forms.RadioButton()
        Me.lblStartMonth = New System.Windows.Forms.Label()
        Me.lblYInStepsOf = New System.Windows.Forms.Label()
        Me.lblYTo = New System.Windows.Forms.Label()
        Me.lblYFrom = New System.Windows.Forms.Label()
        Me.ucrInputYSpecifyUpperLimitDateMonth = New instat.ucrInputComboBox()
        Me.ucrInputYSpecifyUpperLimitNumeric = New instat.ucrInputTextBox()
        Me.ucrInputYSpecifyLowerLimitDateMonth = New instat.ucrInputComboBox()
        Me.ucrChkYSpecifyUpperLimit = New instat.ucrCheck()
        Me.ucrInputYSpecifyLowerLimitNumeric = New instat.ucrInputTextBox()
        Me.ucrChkYSpecifyLowerLimit = New instat.ucrCheck()
        Me.ucrPnlYAxisType = New instat.UcrPanel()
        Me.ucrInputStartMonth = New instat.ucrInputComboBox()
        Me.ucrChkSpecifyYAxisTickMarks = New instat.ucrCheck()
        Me.ucrNudDateBreakNumber = New instat.ucrNud()
        Me.ucrInputYInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputDateBreakTime = New instat.ucrInputComboBox()
        Me.ucrChkSpecifyDateBreaks = New instat.ucrCheck()
        Me.ucrInputDateDisplayFormat = New instat.ucrInputComboBox()
        Me.ucrInputYTo = New instat.ucrInputTextBox()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.ucrNudYAxisLabelSize = New instat.ucrNud()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrInputYFrom = New instat.ucrInputTextBox()
        Me.ucrChkYAxisLabelSize = New instat.ucrCheck()
        Me.tpLines = New System.Windows.Forms.TabPage()
        Me.ucrInputTercilesLineLabelTextUpper = New instat.ucrInputTextBox()
        Me.lblTercilesLineLabelTextUpper = New System.Windows.Forms.Label()
        Me.grpLinesFormat = New System.Windows.Forms.GroupBox()
        Me.ucrNudLabelTransparency = New instat.ucrNud()
        Me.lblLabelTransparency = New System.Windows.Forms.Label()
        Me.ucrNudHLineSize = New instat.ucrNud()
        Me.ucrChkHLineSize = New instat.ucrCheck()
        Me.ucrInputHLineType = New instat.ucrInputComboBox()
        Me.ucrInputHLineColour = New instat.ucrInputComboBox()
        Me.ucrChkHLineType = New instat.ucrCheck()
        Me.ucrChkHLineColour = New instat.ucrCheck()
        Me.lblTercilesLineLabelTextLower = New System.Windows.Forms.Label()
        Me.lblTercilesLineType = New System.Windows.Forms.Label()
        Me.lblMedianLineLabelText = New System.Windows.Forms.Label()
        Me.lblMedianLineType = New System.Windows.Forms.Label()
        Me.lblMeanLineLabelText = New System.Windows.Forms.Label()
        Me.lblMeanLineType = New System.Windows.Forms.Label()
        Me.ucrChkTercilesLineLabelIncludeValue = New instat.ucrCheck()
        Me.ucrChkMedianLineLabelIncludeValue = New instat.ucrCheck()
        Me.ucrChkMeanLineLabelIncludeValue = New instat.ucrCheck()
        Me.ucrInputTercilesLineLabelTextLower = New instat.ucrInputTextBox()
        Me.ucrInputTercilesLabelType = New instat.ucrInputComboBox()
        Me.ucrInputMedianLineLabelText = New instat.ucrInputTextBox()
        Me.ucrInputMedianLabelType = New instat.ucrInputComboBox()
        Me.ucrInputMeanLineLabelText = New instat.ucrInputTextBox()
        Me.ucrChkAddTercilesLabel = New instat.ucrCheck()
        Me.ucrChkAddMedianLabel = New instat.ucrCheck()
        Me.ucrInputMeanLabelType = New instat.ucrInputComboBox()
        Me.ucrChkAddMean = New instat.ucrCheck()
        Me.ucrChkAddMeanLabel = New instat.ucrCheck()
        Me.ucrChkAddMedian = New instat.ucrCheck()
        Me.ucrChkAddTerciles = New instat.ucrCheck()
        Me.tpPanel = New System.Windows.Forms.TabPage()
        Me.grpMinorGridLine = New System.Windows.Forms.GroupBox()
        Me.lblMinorGridLineSize = New System.Windows.Forms.Label()
        Me.ucrChkIncludeMinorGridLines = New instat.ucrCheck()
        Me.lblMinorGridLineLinetype = New System.Windows.Forms.Label()
        Me.ucrNudMinorGridLineSize = New instat.ucrNud()
        Me.lblMinorGridLineColour = New System.Windows.Forms.Label()
        Me.ucrInputMinorGridLineLinetype = New instat.ucrInputComboBox()
        Me.ucrInputMinorGridLineColour = New instat.ucrInputComboBox()
        Me.grpPnlBorder = New System.Windows.Forms.GroupBox()
        Me.ucrNudBorderSize = New instat.ucrNud()
        Me.UcrChkBorderSize = New instat.ucrCheck()
        Me.ucrInputBorderLinetype = New instat.ucrInputComboBox()
        Me.ucrInputBorderColour = New instat.ucrInputComboBox()
        Me.ucrChkBorderLineType = New instat.ucrCheck()
        Me.ucrChkBorderColour = New instat.ucrCheck()
        Me.grpMajorGridLines = New System.Windows.Forms.GroupBox()
        Me.lblMajorGridLineSize = New System.Windows.Forms.Label()
        Me.lblMajorGridLineLinetype = New System.Windows.Forms.Label()
        Me.lblMajorGridLineColour = New System.Windows.Forms.Label()
        Me.ucrChkIncludeMajorGridLines = New instat.ucrCheck()
        Me.ucrNudMajorGridLineSize = New instat.ucrNud()
        Me.ucrInputMajorGridLineLinetype = New instat.ucrInputComboBox()
        Me.ucrInputMajorGridLineColour = New instat.ucrInputComboBox()
        Me.grpPnlBackground = New System.Windows.Forms.GroupBox()
        Me.ucrNudPnlBackgroundSize = New instat.ucrNud()
        Me.UcrInputPnlBackgroundFill = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundLinetype = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundColour = New instat.ucrInputComboBox()
        Me.UcrChkPnlBackgroundSize = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundLineType = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundFill = New instat.ucrCheck()
        Me.ucrChkPnlBackgroundColour = New instat.ucrCheck()
        Me.tpRug = New System.Windows.Forms.TabPage()
        Me.ucrInputXaxisOptions = New instat.ucrInputComboBox()
        Me.lblXaxisOptions = New System.Windows.Forms.Label()
        Me.lblYaxisOptions = New System.Windows.Forms.Label()
        Me.ucrChkXaxis = New instat.ucrCheck()
        Me.ucrInputYaxisOptions = New instat.ucrInputComboBox()
        Me.ucrChkYaxis = New instat.ucrCheck()
        Me.ttPICSARainfallGraph = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.tbPICSA.SuspendLayout()
        Me.tpTitles.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.tpXAxis.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.tpYAxis.SuspendLayout()
        Me.tpLines.SuspendLayout()
        Me.grpLinesFormat.SuspendLayout()
        Me.tpPanel.SuspendLayout()
        Me.grpMinorGridLine.SuspendLayout()
        Me.grpPnlBorder.SuspendLayout()
        Me.grpMajorGridLines.SuspendLayout()
        Me.grpPnlBackground.SuspendLayout()
        Me.tpRug.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblXTo
        '
        Me.lblXTo.AutoSize = True
        Me.lblXTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXTo.Location = New System.Drawing.Point(248, 24)
        Me.lblXTo.Name = "lblXTo"
        Me.lblXTo.Size = New System.Drawing.Size(23, 13)
        Me.lblXTo.TabIndex = 21
        Me.lblXTo.Text = "To:"
        '
        'lblXFrom
        '
        Me.lblXFrom.AutoSize = True
        Me.lblXFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXFrom.Location = New System.Drawing.Point(122, 24)
        Me.lblXFrom.Name = "lblXFrom"
        Me.lblXFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblXFrom.TabIndex = 20
        Me.lblXFrom.Text = "From:"
        '
        'lblXInStepsOf
        '
        Me.lblXInStepsOf.AutoSize = True
        Me.lblXInStepsOf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXInStepsOf.Location = New System.Drawing.Point(368, 24)
        Me.lblXInStepsOf.Name = "lblXInStepsOf"
        Me.lblXInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblXInStepsOf.TabIndex = 22
        Me.lblXInStepsOf.Text = "In Steps of:"
        '
        'tbPICSA
        '
        Me.tbPICSA.Controls.Add(Me.tpTitles)
        Me.tbPICSA.Controls.Add(Me.tpXAxis)
        Me.tbPICSA.Controls.Add(Me.tpYAxis)
        Me.tbPICSA.Controls.Add(Me.tpLines)
        Me.tbPICSA.Controls.Add(Me.tpPanel)
        Me.tbPICSA.Controls.Add(Me.tpRug)
        Me.tbPICSA.Location = New System.Drawing.Point(8, 6)
        Me.tbPICSA.Name = "tbPICSA"
        Me.tbPICSA.SelectedIndex = 0
        Me.tbPICSA.Size = New System.Drawing.Size(589, 335)
        Me.tbPICSA.TabIndex = 26
        '
        'tpTitles
        '
        Me.tpTitles.Controls.Add(Me.grpGraphTitles)
        Me.tpTitles.Controls.Add(Me.grpAxes)
        Me.tpTitles.Controls.Add(Me.grpyAxisTitle)
        Me.tpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tpTitles.Name = "tpTitles"
        Me.tpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTitles.Size = New System.Drawing.Size(581, 309)
        Me.tpTitles.TabIndex = 0
        Me.tpTitles.Text = "Titles "
        Me.tpTitles.UseVisualStyleBackColor = True
        '
        'grpGraphTitles
        '
        Me.grpGraphTitles.Controls.Add(Me.lblCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblCaption)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitle)
        Me.grpGraphTitles.Controls.Add(Me.lblTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphcCaption)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        Me.grpGraphTitles.Location = New System.Drawing.Point(9, 10)
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.Size = New System.Drawing.Size(525, 136)
        Me.grpGraphTitles.TabIndex = 17
        Me.grpGraphTitles.TabStop = False
        Me.grpGraphTitles.Text = "Graph"
        '
        'lblCaptionSize
        '
        Me.lblCaptionSize.AutoSize = True
        Me.lblCaptionSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaptionSize.Location = New System.Drawing.Point(347, 83)
        Me.lblCaptionSize.Name = "lblCaptionSize"
        Me.lblCaptionSize.Size = New System.Drawing.Size(69, 13)
        Me.lblCaptionSize.TabIndex = 26
        Me.lblCaptionSize.Text = "Caption Size:"
        '
        'lblSubTitleSize
        '
        Me.lblSubTitleSize.AutoSize = True
        Me.lblSubTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitleSize.Location = New System.Drawing.Point(347, 53)
        Me.lblSubTitleSize.Name = "lblSubTitleSize"
        Me.lblSubTitleSize.Size = New System.Drawing.Size(75, 13)
        Me.lblSubTitleSize.TabIndex = 27
        Me.lblSubTitleSize.Text = "Sub Title Size:"
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(348, 23)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(53, 13)
        Me.lblTitleSize.TabIndex = 28
        Me.lblTitleSize.Text = "Title Size:"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(5, 83)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(78, 13)
        Me.lblCaption.TabIndex = 23
        Me.lblCaption.Text = "Graph Caption:"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(5, 53)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(84, 13)
        Me.lblSubTitle.TabIndex = 24
        Me.lblSubTitle.Text = "Graph Sub Title:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(6, 23)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 25
        Me.lblTitle.Text = "Graph Title:"
        '
        'ucrNudCaptionSize
        '
        Me.ucrNudCaptionSize.AutoSize = True
        Me.ucrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCaptionSize.Location = New System.Drawing.Point(463, 78)
        Me.ucrNudCaptionSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Name = "ucrNudCaptionSize"
        Me.ucrNudCaptionSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCaptionSize.TabIndex = 22
        Me.ucrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSubTitleSize
        '
        Me.ucrNudSubTitleSize.AutoSize = True
        Me.ucrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSubTitleSize.Location = New System.Drawing.Point(463, 48)
        Me.ucrNudSubTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Name = "ucrNudSubTitleSize"
        Me.ucrNudSubTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSubTitleSize.TabIndex = 21
        Me.ucrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.AutoSize = True
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTitleSize.Location = New System.Drawing.Point(463, 18)
        Me.ucrNudTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTitleSize.TabIndex = 20
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.AutoSize = True
        Me.ucrInputGraphcCaption.IsMultiline = True
        Me.ucrInputGraphcCaption.IsReadOnly = False
        Me.ucrInputGraphcCaption.Location = New System.Drawing.Point(150, 78)
        Me.ucrInputGraphcCaption.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphcCaption.Name = "ucrInputGraphcCaption"
        Me.ucrInputGraphcCaption.Size = New System.Drawing.Size(181, 53)
        Me.ucrInputGraphcCaption.TabIndex = 16
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.AutoSize = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(150, 18)
        Me.ucrInputGraphTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputGraphTitle.TabIndex = 12
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.AutoSize = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(150, 48)
        Me.ucrInputGraphSubTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 14
        '
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.lblXAxisTitleSize)
        Me.grpAxes.Controls.Add(Me.rdoAutoXAxis)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoNoTitleXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoSpecifyXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrNudXAxisTitleSize)
        Me.grpAxes.Controls.Add(Me.ucrPnlXAxisTitle)
        Me.grpAxes.Location = New System.Drawing.Point(9, 153)
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.Size = New System.Drawing.Size(228, 105)
        Me.grpAxes.TabIndex = 18
        Me.grpAxes.TabStop = False
        Me.grpAxes.Text = "X-Axis Title"
        '
        'lblXAxisTitleSize
        '
        Me.lblXAxisTitleSize.AutoSize = True
        Me.lblXAxisTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXAxisTitleSize.Location = New System.Drawing.Point(6, 82)
        Me.lblXAxisTitleSize.Name = "lblXAxisTitleSize"
        Me.lblXAxisTitleSize.Size = New System.Drawing.Size(30, 13)
        Me.lblXAxisTitleSize.TabIndex = 44
        Me.lblXAxisTitleSize.Text = "Size:"
        '
        'rdoAutoXAxis
        '
        Me.rdoAutoXAxis.AutoSize = True
        Me.rdoAutoXAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAutoXAxis.Location = New System.Drawing.Point(6, 21)
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.Size = New System.Drawing.Size(50, 17)
        Me.rdoAutoXAxis.TabIndex = 43
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.Text = "Auto "
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.AutoSize = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        Me.ucrInputXAxisTitle.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputXAxisTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        Me.ucrInputXAxisTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputXAxisTitle.TabIndex = 42
        '
        'rdoNoTitleXAxisTitle
        '
        Me.rdoNoTitleXAxisTitle.AutoSize = True
        Me.rdoNoTitleXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoTitleXAxisTitle.Location = New System.Drawing.Point(132, 21)
        Me.rdoNoTitleXAxisTitle.Name = "rdoNoTitleXAxisTitle"
        Me.rdoNoTitleXAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitleXAxisTitle.TabIndex = 41
        Me.rdoNoTitleXAxisTitle.TabStop = True
        Me.rdoNoTitleXAxisTitle.Text = "No Title"
        Me.rdoNoTitleXAxisTitle.UseVisualStyleBackColor = True
        '
        'rdoSpecifyXAxisTitle
        '
        Me.rdoSpecifyXAxisTitle.AutoSize = True
        Me.rdoSpecifyXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyXAxisTitle.Location = New System.Drawing.Point(57, 21)
        Me.rdoSpecifyXAxisTitle.Name = "rdoSpecifyXAxisTitle"
        Me.rdoSpecifyXAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoSpecifyXAxisTitle.TabIndex = 40
        Me.rdoSpecifyXAxisTitle.TabStop = True
        Me.rdoSpecifyXAxisTitle.Text = "Specifiy"
        Me.rdoSpecifyXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudXAxisTitleSize
        '
        Me.ucrNudXAxisTitleSize.AutoSize = True
        Me.ucrNudXAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Location = New System.Drawing.Point(43, 80)
        Me.ucrNudXAxisTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudXAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Name = "ucrNudXAxisTitleSize"
        Me.ucrNudXAxisTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisTitleSize.TabIndex = 23
        Me.ucrNudXAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlXAxisTitle
        '
        Me.ucrPnlXAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlXAxisTitle.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlXAxisTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
        Me.ucrPnlXAxisTitle.Size = New System.Drawing.Size(215, 57)
        Me.ucrPnlXAxisTitle.TabIndex = 36
        '
        'grpyAxisTitle
        '
        Me.grpyAxisTitle.Controls.Add(Me.rdoAutoYAxis)
        Me.grpyAxisTitle.Controls.Add(Me.ucrInputYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.rdoNoYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.grpyAxisTitle.Controls.Add(Me.rdoSpecifyYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrPnlYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.lblYAxisTitleSize)
        Me.grpyAxisTitle.Location = New System.Drawing.Point(306, 149)
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.Size = New System.Drawing.Size(228, 105)
        Me.grpyAxisTitle.TabIndex = 36
        Me.grpyAxisTitle.TabStop = False
        Me.grpyAxisTitle.Text = "Y-Axis Title"
        '
        'rdoAutoYAxis
        '
        Me.rdoAutoYAxis.AutoSize = True
        Me.rdoAutoYAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAutoYAxis.Location = New System.Drawing.Point(6, 21)
        Me.rdoAutoYAxis.Name = "rdoAutoYAxis"
        Me.rdoAutoYAxis.Size = New System.Drawing.Size(50, 17)
        Me.rdoAutoYAxis.TabIndex = 44
        Me.rdoAutoYAxis.TabStop = True
        Me.rdoAutoYAxis.Text = "Auto "
        Me.rdoAutoYAxis.UseVisualStyleBackColor = True
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.AutoSize = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        Me.ucrInputYAxisTitle.Location = New System.Drawing.Point(6, 44)
        Me.ucrInputYAxisTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        Me.ucrInputYAxisTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputYAxisTitle.TabIndex = 14
        '
        'rdoNoYAxisTitle
        '
        Me.rdoNoYAxisTitle.AutoSize = True
        Me.rdoNoYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoYAxisTitle.Location = New System.Drawing.Point(131, 21)
        Me.rdoNoYAxisTitle.Name = "rdoNoYAxisTitle"
        Me.rdoNoYAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoYAxisTitle.TabIndex = 42
        Me.rdoNoYAxisTitle.TabStop = True
        Me.rdoNoYAxisTitle.Text = "No Title"
        Me.rdoNoYAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudYAxisTitleSize
        '
        Me.ucrNudYAxisTitleSize.AutoSize = True
        Me.ucrNudYAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Location = New System.Drawing.Point(43, 79)
        Me.ucrNudYAxisTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Name = "ucrNudYAxisTitleSize"
        Me.ucrNudYAxisTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisTitleSize.TabIndex = 22
        Me.ucrNudYAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecifyYAxisTitle
        '
        Me.rdoSpecifyYAxisTitle.AutoSize = True
        Me.rdoSpecifyYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyYAxisTitle.Location = New System.Drawing.Point(56, 21)
        Me.rdoSpecifyYAxisTitle.Name = "rdoSpecifyYAxisTitle"
        Me.rdoSpecifyYAxisTitle.Size = New System.Drawing.Size(60, 17)
        Me.rdoSpecifyYAxisTitle.TabIndex = 41
        Me.rdoSpecifyYAxisTitle.TabStop = True
        Me.rdoSpecifyYAxisTitle.Text = "Specify"
        Me.rdoSpecifyYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrPnlYAxisTitle
        '
        Me.UcrPnlYAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrPnlYAxisTitle.Location = New System.Drawing.Point(6, 15)
        Me.UcrPnlYAxisTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrPnlYAxisTitle.Name = "UcrPnlYAxisTitle"
        Me.UcrPnlYAxisTitle.Size = New System.Drawing.Size(214, 57)
        Me.UcrPnlYAxisTitle.TabIndex = 37
        '
        'lblYAxisTitleSize
        '
        Me.lblYAxisTitleSize.AutoSize = True
        Me.lblYAxisTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYAxisTitleSize.Location = New System.Drawing.Point(6, 82)
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
        Me.lblYAxisTitleSize.Size = New System.Drawing.Size(30, 13)
        Me.lblYAxisTitleSize.TabIndex = 45
        Me.lblYAxisTitleSize.Text = "Size:"
        '
        'tpXAxis
        '
        Me.tpXAxis.Controls.Add(Me.grpXAxisLabels)
        Me.tpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tpXAxis.Name = "tpXAxis"
        Me.tpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tpXAxis.Size = New System.Drawing.Size(581, 309)
        Me.tpXAxis.TabIndex = 1
        Me.tpXAxis.Text = "X-Axis"
        Me.tpXAxis.UseVisualStyleBackColor = True
        '
        'grpXAxisLabels
        '
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkSpecifyXAxisTickMarks)
        Me.grpXAxisLabels.Controls.Add(Me.lblXFrom)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXFrom)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXInStepsOf)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXaxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXTo)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.lblXInStepsOf)
        Me.grpXAxisLabels.Controls.Add(Me.lblXTo)
        Me.grpXAxisLabels.Location = New System.Drawing.Point(6, 8)
        Me.grpXAxisLabels.Name = "grpXAxisLabels"
        Me.grpXAxisLabels.Size = New System.Drawing.Size(504, 93)
        Me.grpXAxisLabels.TabIndex = 27
        Me.grpXAxisLabels.TabStop = False
        Me.grpXAxisLabels.Text = "X-Axis"
        '
        'ucrChkXAxisLabelSize
        '
        Me.ucrChkXAxisLabelSize.AutoSize = True
        Me.ucrChkXAxisLabelSize.Checked = False
        Me.ucrChkXAxisLabelSize.Location = New System.Drawing.Point(162, 57)
        Me.ucrChkXAxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkXAxisLabelSize.Name = "ucrChkXAxisLabelSize"
        Me.ucrChkXAxisLabelSize.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkXAxisLabelSize.TabIndex = 30
        '
        'ucrChkXAxisAngle
        '
        Me.ucrChkXAxisAngle.AutoSize = True
        Me.ucrChkXAxisAngle.Checked = False
        Me.ucrChkXAxisAngle.Location = New System.Drawing.Point(6, 57)
        Me.ucrChkXAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkXAxisAngle.Name = "ucrChkXAxisAngle"
        Me.ucrChkXAxisAngle.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkXAxisAngle.TabIndex = 29
        '
        'ucrChkSpecifyXAxisTickMarks
        '
        Me.ucrChkSpecifyXAxisTickMarks.AutoSize = True
        Me.ucrChkSpecifyXAxisTickMarks.Checked = False
        Me.ucrChkSpecifyXAxisTickMarks.Location = New System.Drawing.Point(6, 22)
        Me.ucrChkSpecifyXAxisTickMarks.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSpecifyXAxisTickMarks.Name = "ucrChkSpecifyXAxisTickMarks"
        Me.ucrChkSpecifyXAxisTickMarks.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkSpecifyXAxisTickMarks.TabIndex = 28
        '
        'ucrInputXFrom
        '
        Me.ucrInputXFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputXFrom.AutoSize = True
        Me.ucrInputXFrom.IsMultiline = False
        Me.ucrInputXFrom.IsReadOnly = False
        Me.ucrInputXFrom.Location = New System.Drawing.Point(160, 21)
        Me.ucrInputXFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXFrom.Name = "ucrInputXFrom"
        Me.ucrInputXFrom.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputXFrom.TabIndex = 25
        '
        'ucrInputXInStepsOf
        '
        Me.ucrInputXInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputXInStepsOf.AutoSize = True
        Me.ucrInputXInStepsOf.IsMultiline = False
        Me.ucrInputXInStepsOf.IsReadOnly = False
        Me.ucrInputXInStepsOf.Location = New System.Drawing.Point(433, 21)
        Me.ucrInputXInStepsOf.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXInStepsOf.Name = "ucrInputXInStepsOf"
        Me.ucrInputXInStepsOf.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputXInStepsOf.TabIndex = 23
        '
        'ucrNudXaxisLabelSize
        '
        Me.ucrNudXaxisLabelSize.AutoSize = True
        Me.ucrNudXaxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Location = New System.Drawing.Point(241, 57)
        Me.ucrNudXaxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudXaxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Name = "ucrNudXaxisLabelSize"
        Me.ucrNudXaxisLabelSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXaxisLabelSize.TabIndex = 4
        Me.ucrNudXaxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputXTo
        '
        Me.ucrInputXTo.AddQuotesIfUnrecognised = True
        Me.ucrInputXTo.AutoSize = True
        Me.ucrInputXTo.IsMultiline = False
        Me.ucrInputXTo.IsReadOnly = False
        Me.ucrInputXTo.Location = New System.Drawing.Point(275, 21)
        Me.ucrInputXTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXTo.Name = "ucrInputXTo"
        Me.ucrInputXTo.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputXTo.TabIndex = 24
        '
        'ucrNudXAxisAngle
        '
        Me.ucrNudXAxisAngle.AutoSize = True
        Me.ucrNudXAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisAngle.Location = New System.Drawing.Point(86, 57)
        Me.ucrNudXAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudXAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Name = "ucrNudXAxisAngle"
        Me.ucrNudXAxisAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisAngle.TabIndex = 4
        Me.ucrNudXAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'tpYAxis
        '
        Me.tpYAxis.Controls.Add(Me.ucrNudUpperLimit)
        Me.tpYAxis.Controls.Add(Me.ucrNudLowerLimit)
        Me.tpYAxis.Controls.Add(Me.lblDateDisplayFormat)
        Me.tpYAxis.Controls.Add(Me.rdoYDate)
        Me.tpYAxis.Controls.Add(Me.rdoYNumeric)
        Me.tpYAxis.Controls.Add(Me.lblStartMonth)
        Me.tpYAxis.Controls.Add(Me.lblYInStepsOf)
        Me.tpYAxis.Controls.Add(Me.lblYTo)
        Me.tpYAxis.Controls.Add(Me.lblYFrom)
        Me.tpYAxis.Controls.Add(Me.ucrInputYSpecifyUpperLimitDateMonth)
        Me.tpYAxis.Controls.Add(Me.ucrInputYSpecifyUpperLimitNumeric)
        Me.tpYAxis.Controls.Add(Me.ucrInputYSpecifyLowerLimitDateMonth)
        Me.tpYAxis.Controls.Add(Me.ucrChkYSpecifyUpperLimit)
        Me.tpYAxis.Controls.Add(Me.ucrInputYSpecifyLowerLimitNumeric)
        Me.tpYAxis.Controls.Add(Me.ucrChkYSpecifyLowerLimit)
        Me.tpYAxis.Controls.Add(Me.ucrPnlYAxisType)
        Me.tpYAxis.Controls.Add(Me.ucrInputStartMonth)
        Me.tpYAxis.Controls.Add(Me.ucrChkSpecifyYAxisTickMarks)
        Me.tpYAxis.Controls.Add(Me.ucrNudDateBreakNumber)
        Me.tpYAxis.Controls.Add(Me.ucrInputYInStepsOf)
        Me.tpYAxis.Controls.Add(Me.ucrInputDateBreakTime)
        Me.tpYAxis.Controls.Add(Me.ucrChkSpecifyDateBreaks)
        Me.tpYAxis.Controls.Add(Me.ucrInputDateDisplayFormat)
        Me.tpYAxis.Controls.Add(Me.ucrInputYTo)
        Me.tpYAxis.Controls.Add(Me.ucrNudYAxisAngle)
        Me.tpYAxis.Controls.Add(Me.ucrNudYAxisLabelSize)
        Me.tpYAxis.Controls.Add(Me.ucrChkYAxisAngle)
        Me.tpYAxis.Controls.Add(Me.ucrInputYFrom)
        Me.tpYAxis.Controls.Add(Me.ucrChkYAxisLabelSize)
        Me.tpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tpYAxis.Name = "tpYAxis"
        Me.tpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tpYAxis.Size = New System.Drawing.Size(581, 309)
        Me.tpYAxis.TabIndex = 4
        Me.tpYAxis.Text = "Y-Axis"
        Me.tpYAxis.UseVisualStyleBackColor = True
        '
        'ucrNudUpperLimit
        '
        Me.ucrNudUpperLimit.AutoSize = True
        Me.ucrNudUpperLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudUpperLimit.Location = New System.Drawing.Point(209, 158)
        Me.ucrNudUpperLimit.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudUpperLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperLimit.Name = "ucrNudUpperLimit"
        Me.ucrNudUpperLimit.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudUpperLimit.TabIndex = 52
        Me.ucrNudUpperLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLowerLimit
        '
        Me.ucrNudLowerLimit.AutoSize = True
        Me.ucrNudLowerLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLowerLimit.Location = New System.Drawing.Point(209, 127)
        Me.ucrNudLowerLimit.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudLowerLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLowerLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerLimit.Name = "ucrNudLowerLimit"
        Me.ucrNudLowerLimit.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudLowerLimit.TabIndex = 51
        Me.ucrNudLowerLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDateDisplayFormat
        '
        Me.lblDateDisplayFormat.AutoSize = True
        Me.lblDateDisplayFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDateDisplayFormat.Location = New System.Drawing.Point(8, 94)
        Me.lblDateDisplayFormat.Name = "lblDateDisplayFormat"
        Me.lblDateDisplayFormat.Size = New System.Drawing.Size(79, 13)
        Me.lblDateDisplayFormat.TabIndex = 50
        Me.lblDateDisplayFormat.Text = "Display Format:"
        '
        'rdoYDate
        '
        Me.rdoYDate.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoYDate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYDate.FlatAppearance.BorderSize = 2
        Me.rdoYDate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoYDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYDate.Location = New System.Drawing.Point(282, 16)
        Me.rdoYDate.Name = "rdoYDate"
        Me.rdoYDate.Size = New System.Drawing.Size(98, 27)
        Me.rdoYDate.TabIndex = 43
        Me.rdoYDate.TabStop = True
        Me.rdoYDate.Text = "Date"
        Me.rdoYDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYDate.UseVisualStyleBackColor = True
        '
        'rdoYNumeric
        '
        Me.rdoYNumeric.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoYNumeric.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYNumeric.FlatAppearance.BorderSize = 2
        Me.rdoYNumeric.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYNumeric.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoYNumeric.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoYNumeric.Location = New System.Drawing.Point(186, 16)
        Me.rdoYNumeric.Name = "rdoYNumeric"
        Me.rdoYNumeric.Size = New System.Drawing.Size(98, 27)
        Me.rdoYNumeric.TabIndex = 42
        Me.rdoYNumeric.TabStop = True
        Me.rdoYNumeric.Text = "Numeric"
        Me.rdoYNumeric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoYNumeric.UseVisualStyleBackColor = True
        '
        'lblStartMonth
        '
        Me.lblStartMonth.AutoSize = True
        Me.lblStartMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStartMonth.Location = New System.Drawing.Point(8, 63)
        Me.lblStartMonth.Name = "lblStartMonth"
        Me.lblStartMonth.Size = New System.Drawing.Size(65, 13)
        Me.lblStartMonth.TabIndex = 37
        Me.lblStartMonth.Text = "Start Month:"
        '
        'lblYInStepsOf
        '
        Me.lblYInStepsOf.AutoSize = True
        Me.lblYInStepsOf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYInStepsOf.Location = New System.Drawing.Point(387, 64)
        Me.lblYInStepsOf.Name = "lblYInStepsOf"
        Me.lblYInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblYInStepsOf.TabIndex = 22
        Me.lblYInStepsOf.Text = "In Steps of:"
        '
        'lblYTo
        '
        Me.lblYTo.AutoSize = True
        Me.lblYTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYTo.Location = New System.Drawing.Point(268, 64)
        Me.lblYTo.Name = "lblYTo"
        Me.lblYTo.Size = New System.Drawing.Size(23, 13)
        Me.lblYTo.TabIndex = 21
        Me.lblYTo.Text = "To:"
        '
        'lblYFrom
        '
        Me.lblYFrom.AutoSize = True
        Me.lblYFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYFrom.Location = New System.Drawing.Point(162, 64)
        Me.lblYFrom.Name = "lblYFrom"
        Me.lblYFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblYFrom.TabIndex = 20
        Me.lblYFrom.Text = "From:"
        '
        'ucrInputYSpecifyUpperLimitDateMonth
        '
        Me.ucrInputYSpecifyUpperLimitDateMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyUpperLimitDateMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYSpecifyUpperLimitDateMonth.GetSetSelectedIndex = -1
        Me.ucrInputYSpecifyUpperLimitDateMonth.IsReadOnly = False
        Me.ucrInputYSpecifyUpperLimitDateMonth.Location = New System.Drawing.Point(269, 156)
        Me.ucrInputYSpecifyUpperLimitDateMonth.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYSpecifyUpperLimitDateMonth.Name = "ucrInputYSpecifyUpperLimitDateMonth"
        Me.ucrInputYSpecifyUpperLimitDateMonth.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputYSpecifyUpperLimitDateMonth.TabIndex = 49
        '
        'ucrInputYSpecifyUpperLimitNumeric
        '
        Me.ucrInputYSpecifyUpperLimitNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyUpperLimitNumeric.AutoSize = True
        Me.ucrInputYSpecifyUpperLimitNumeric.IsMultiline = False
        Me.ucrInputYSpecifyUpperLimitNumeric.IsReadOnly = False
        Me.ucrInputYSpecifyUpperLimitNumeric.Location = New System.Drawing.Point(195, 157)
        Me.ucrInputYSpecifyUpperLimitNumeric.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYSpecifyUpperLimitNumeric.Name = "ucrInputYSpecifyUpperLimitNumeric"
        Me.ucrInputYSpecifyUpperLimitNumeric.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputYSpecifyUpperLimitNumeric.TabIndex = 48
        '
        'ucrInputYSpecifyLowerLimitDateMonth
        '
        Me.ucrInputYSpecifyLowerLimitDateMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyLowerLimitDateMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYSpecifyLowerLimitDateMonth.GetSetSelectedIndex = -1
        Me.ucrInputYSpecifyLowerLimitDateMonth.IsReadOnly = False
        Me.ucrInputYSpecifyLowerLimitDateMonth.Location = New System.Drawing.Point(269, 126)
        Me.ucrInputYSpecifyLowerLimitDateMonth.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYSpecifyLowerLimitDateMonth.Name = "ucrInputYSpecifyLowerLimitDateMonth"
        Me.ucrInputYSpecifyLowerLimitDateMonth.Size = New System.Drawing.Size(93, 21)
        Me.ucrInputYSpecifyLowerLimitDateMonth.TabIndex = 46
        '
        'ucrChkYSpecifyUpperLimit
        '
        Me.ucrChkYSpecifyUpperLimit.AutoSize = True
        Me.ucrChkYSpecifyUpperLimit.Checked = False
        Me.ucrChkYSpecifyUpperLimit.Location = New System.Drawing.Point(11, 157)
        Me.ucrChkYSpecifyUpperLimit.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYSpecifyUpperLimit.Name = "ucrChkYSpecifyUpperLimit"
        Me.ucrChkYSpecifyUpperLimit.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkYSpecifyUpperLimit.TabIndex = 47
        '
        'ucrInputYSpecifyLowerLimitNumeric
        '
        Me.ucrInputYSpecifyLowerLimitNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyLowerLimitNumeric.AutoSize = True
        Me.ucrInputYSpecifyLowerLimitNumeric.IsMultiline = False
        Me.ucrInputYSpecifyLowerLimitNumeric.IsReadOnly = False
        Me.ucrInputYSpecifyLowerLimitNumeric.Location = New System.Drawing.Point(195, 127)
        Me.ucrInputYSpecifyLowerLimitNumeric.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYSpecifyLowerLimitNumeric.Name = "ucrInputYSpecifyLowerLimitNumeric"
        Me.ucrInputYSpecifyLowerLimitNumeric.Size = New System.Drawing.Size(59, 21)
        Me.ucrInputYSpecifyLowerLimitNumeric.TabIndex = 45
        '
        'ucrChkYSpecifyLowerLimit
        '
        Me.ucrChkYSpecifyLowerLimit.AutoSize = True
        Me.ucrChkYSpecifyLowerLimit.Checked = False
        Me.ucrChkYSpecifyLowerLimit.Location = New System.Drawing.Point(11, 127)
        Me.ucrChkYSpecifyLowerLimit.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYSpecifyLowerLimit.Name = "ucrChkYSpecifyLowerLimit"
        Me.ucrChkYSpecifyLowerLimit.Size = New System.Drawing.Size(180, 23)
        Me.ucrChkYSpecifyLowerLimit.TabIndex = 44
        '
        'ucrPnlYAxisType
        '
        Me.ucrPnlYAxisType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlYAxisType.Location = New System.Drawing.Point(161, 7)
        Me.ucrPnlYAxisType.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlYAxisType.Name = "ucrPnlYAxisType"
        Me.ucrPnlYAxisType.Size = New System.Drawing.Size(243, 48)
        Me.ucrPnlYAxisType.TabIndex = 39
        '
        'ucrInputStartMonth
        '
        Me.ucrInputStartMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputStartMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStartMonth.GetSetSelectedIndex = -1
        Me.ucrInputStartMonth.IsReadOnly = False
        Me.ucrInputStartMonth.Location = New System.Drawing.Point(157, 60)
        Me.ucrInputStartMonth.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputStartMonth.Name = "ucrInputStartMonth"
        Me.ucrInputStartMonth.Size = New System.Drawing.Size(96, 21)
        Me.ucrInputStartMonth.TabIndex = 38
        '
        'ucrChkSpecifyYAxisTickMarks
        '
        Me.ucrChkSpecifyYAxisTickMarks.AutoSize = True
        Me.ucrChkSpecifyYAxisTickMarks.Checked = False
        Me.ucrChkSpecifyYAxisTickMarks.Location = New System.Drawing.Point(11, 61)
        Me.ucrChkSpecifyYAxisTickMarks.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSpecifyYAxisTickMarks.Name = "ucrChkSpecifyYAxisTickMarks"
        Me.ucrChkSpecifyYAxisTickMarks.Size = New System.Drawing.Size(149, 23)
        Me.ucrChkSpecifyYAxisTickMarks.TabIndex = 29
        '
        'ucrNudDateBreakNumber
        '
        Me.ucrNudDateBreakNumber.AutoSize = True
        Me.ucrNudDateBreakNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Location = New System.Drawing.Point(431, 89)
        Me.ucrNudDateBreakNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudDateBreakNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Name = "ucrNudDateBreakNumber"
        Me.ucrNudDateBreakNumber.Size = New System.Drawing.Size(45, 20)
        Me.ucrNudDateBreakNumber.TabIndex = 36
        Me.ucrNudDateBreakNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputYInStepsOf
        '
        Me.ucrInputYInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputYInStepsOf.AutoSize = True
        Me.ucrInputYInStepsOf.IsMultiline = False
        Me.ucrInputYInStepsOf.IsReadOnly = False
        Me.ucrInputYInStepsOf.Location = New System.Drawing.Point(503, 61)
        Me.ucrInputYInStepsOf.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYInStepsOf.Name = "ucrInputYInStepsOf"
        Me.ucrInputYInStepsOf.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputYInStepsOf.TabIndex = 23
        '
        'ucrInputDateBreakTime
        '
        Me.ucrInputDateBreakTime.AddQuotesIfUnrecognised = True
        Me.ucrInputDateBreakTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateBreakTime.GetSetSelectedIndex = -1
        Me.ucrInputDateBreakTime.IsReadOnly = False
        Me.ucrInputDateBreakTime.Location = New System.Drawing.Point(482, 88)
        Me.ucrInputDateBreakTime.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputDateBreakTime.Name = "ucrInputDateBreakTime"
        Me.ucrInputDateBreakTime.Size = New System.Drawing.Size(70, 21)
        Me.ucrInputDateBreakTime.TabIndex = 35
        '
        'ucrChkSpecifyDateBreaks
        '
        Me.ucrChkSpecifyDateBreaks.AutoSize = True
        Me.ucrChkSpecifyDateBreaks.Checked = False
        Me.ucrChkSpecifyDateBreaks.Location = New System.Drawing.Point(268, 90)
        Me.ucrChkSpecifyDateBreaks.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSpecifyDateBreaks.Name = "ucrChkSpecifyDateBreaks"
        Me.ucrChkSpecifyDateBreaks.Size = New System.Drawing.Size(161, 23)
        Me.ucrChkSpecifyDateBreaks.TabIndex = 34
        '
        'ucrInputDateDisplayFormat
        '
        Me.ucrInputDateDisplayFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateDisplayFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateDisplayFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateDisplayFormat.IsReadOnly = False
        Me.ucrInputDateDisplayFormat.Location = New System.Drawing.Point(139, 90)
        Me.ucrInputDateDisplayFormat.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputDateDisplayFormat.Name = "ucrInputDateDisplayFormat"
        Me.ucrInputDateDisplayFormat.Size = New System.Drawing.Size(114, 21)
        Me.ucrInputDateDisplayFormat.TabIndex = 32
        '
        'ucrInputYTo
        '
        Me.ucrInputYTo.AddQuotesIfUnrecognised = True
        Me.ucrInputYTo.AutoSize = True
        Me.ucrInputYTo.IsMultiline = False
        Me.ucrInputYTo.IsReadOnly = False
        Me.ucrInputYTo.Location = New System.Drawing.Point(297, 61)
        Me.ucrInputYTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYTo.Name = "ucrInputYTo"
        Me.ucrInputYTo.Size = New System.Drawing.Size(52, 21)
        Me.ucrInputYTo.TabIndex = 24
        '
        'ucrNudYAxisAngle
        '
        Me.ucrNudYAxisAngle.AutoSize = True
        Me.ucrNudYAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisAngle.Location = New System.Drawing.Point(97, 195)
        Me.ucrNudYAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Name = "ucrNudYAxisAngle"
        Me.ucrNudYAxisAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisAngle.TabIndex = 33
        Me.ucrNudYAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYAxisLabelSize
        '
        Me.ucrNudYAxisLabelSize.AutoSize = True
        Me.ucrNudYAxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Location = New System.Drawing.Point(252, 195)
        Me.ucrNudYAxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Name = "ucrNudYAxisLabelSize"
        Me.ucrNudYAxisLabelSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisLabelSize.TabIndex = 4
        Me.ucrNudYAxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.AutoSize = True
        Me.ucrChkYAxisAngle.Checked = False
        Me.ucrChkYAxisAngle.Location = New System.Drawing.Point(11, 195)
        Me.ucrChkYAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
        Me.ucrChkYAxisAngle.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkYAxisAngle.TabIndex = 32
        '
        'ucrInputYFrom
        '
        Me.ucrInputYFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputYFrom.AutoSize = True
        Me.ucrInputYFrom.IsMultiline = False
        Me.ucrInputYFrom.IsReadOnly = False
        Me.ucrInputYFrom.Location = New System.Drawing.Point(199, 61)
        Me.ucrInputYFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYFrom.Name = "ucrInputYFrom"
        Me.ucrInputYFrom.Size = New System.Drawing.Size(50, 21)
        Me.ucrInputYFrom.TabIndex = 25
        '
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.AutoSize = True
        Me.ucrChkYAxisLabelSize.Checked = False
        Me.ucrChkYAxisLabelSize.Location = New System.Drawing.Point(173, 195)
        Me.ucrChkYAxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
        Me.ucrChkYAxisLabelSize.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkYAxisLabelSize.TabIndex = 31
        '
        'tpLines
        '
        Me.tpLines.Controls.Add(Me.ucrInputTercilesLineLabelTextUpper)
        Me.tpLines.Controls.Add(Me.lblTercilesLineLabelTextUpper)
        Me.tpLines.Controls.Add(Me.grpLinesFormat)
        Me.tpLines.Controls.Add(Me.lblTercilesLineLabelTextLower)
        Me.tpLines.Controls.Add(Me.lblTercilesLineType)
        Me.tpLines.Controls.Add(Me.lblMedianLineLabelText)
        Me.tpLines.Controls.Add(Me.lblMedianLineType)
        Me.tpLines.Controls.Add(Me.lblMeanLineLabelText)
        Me.tpLines.Controls.Add(Me.lblMeanLineType)
        Me.tpLines.Controls.Add(Me.ucrChkTercilesLineLabelIncludeValue)
        Me.tpLines.Controls.Add(Me.ucrChkMedianLineLabelIncludeValue)
        Me.tpLines.Controls.Add(Me.ucrChkMeanLineLabelIncludeValue)
        Me.tpLines.Controls.Add(Me.ucrInputTercilesLineLabelTextLower)
        Me.tpLines.Controls.Add(Me.ucrInputTercilesLabelType)
        Me.tpLines.Controls.Add(Me.ucrInputMedianLineLabelText)
        Me.tpLines.Controls.Add(Me.ucrInputMedianLabelType)
        Me.tpLines.Controls.Add(Me.ucrInputMeanLineLabelText)
        Me.tpLines.Controls.Add(Me.ucrChkAddTercilesLabel)
        Me.tpLines.Controls.Add(Me.ucrChkAddMedianLabel)
        Me.tpLines.Controls.Add(Me.ucrInputMeanLabelType)
        Me.tpLines.Controls.Add(Me.ucrChkAddMean)
        Me.tpLines.Controls.Add(Me.ucrChkAddMeanLabel)
        Me.tpLines.Controls.Add(Me.ucrChkAddMedian)
        Me.tpLines.Controls.Add(Me.ucrChkAddTerciles)
        Me.tpLines.Location = New System.Drawing.Point(4, 22)
        Me.tpLines.Name = "tpLines"
        Me.tpLines.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLines.Size = New System.Drawing.Size(581, 309)
        Me.tpLines.TabIndex = 2
        Me.tpLines.Text = "Lines"
        Me.tpLines.UseVisualStyleBackColor = True
        '
        'ucrInputTercilesLineLabelTextUpper
        '
        Me.ucrInputTercilesLineLabelTextUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputTercilesLineLabelTextUpper.AutoSize = True
        Me.ucrInputTercilesLineLabelTextUpper.IsMultiline = False
        Me.ucrInputTercilesLineLabelTextUpper.IsReadOnly = False
        Me.ucrInputTercilesLineLabelTextUpper.Location = New System.Drawing.Point(264, 201)
        Me.ucrInputTercilesLineLabelTextUpper.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputTercilesLineLabelTextUpper.Name = "ucrInputTercilesLineLabelTextUpper"
        Me.ucrInputTercilesLineLabelTextUpper.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputTercilesLineLabelTextUpper.TabIndex = 22
        '
        'lblTercilesLineLabelTextUpper
        '
        Me.lblTercilesLineLabelTextUpper.AutoSize = True
        Me.lblTercilesLineLabelTextUpper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTercilesLineLabelTextUpper.Location = New System.Drawing.Point(103, 205)
        Me.lblTercilesLineLabelTextUpper.Name = "lblTercilesLineLabelTextUpper"
        Me.lblTercilesLineLabelTextUpper.Size = New System.Drawing.Size(98, 13)
        Me.lblTercilesLineLabelTextUpper.TabIndex = 21
        Me.lblTercilesLineLabelTextUpper.Text = "Label Text (Upper):"
        '
        'grpLinesFormat
        '
        Me.grpLinesFormat.Controls.Add(Me.ucrNudLabelTransparency)
        Me.grpLinesFormat.Controls.Add(Me.lblLabelTransparency)
        Me.grpLinesFormat.Controls.Add(Me.ucrNudHLineSize)
        Me.grpLinesFormat.Controls.Add(Me.ucrChkHLineSize)
        Me.grpLinesFormat.Controls.Add(Me.ucrInputHLineType)
        Me.grpLinesFormat.Controls.Add(Me.ucrInputHLineColour)
        Me.grpLinesFormat.Controls.Add(Me.ucrChkHLineType)
        Me.grpLinesFormat.Controls.Add(Me.ucrChkHLineColour)
        Me.grpLinesFormat.Location = New System.Drawing.Point(9, 230)
        Me.grpLinesFormat.Name = "grpLinesFormat"
        Me.grpLinesFormat.Size = New System.Drawing.Size(487, 75)
        Me.grpLinesFormat.TabIndex = 20
        Me.grpLinesFormat.TabStop = False
        Me.grpLinesFormat.Text = "Line Format"
        '
        'ucrNudLabelTransparency
        '
        Me.ucrNudLabelTransparency.AutoSize = True
        Me.ucrNudLabelTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLabelTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudLabelTransparency.Location = New System.Drawing.Point(364, 50)
        Me.ucrNudLabelTransparency.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudLabelTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLabelTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLabelTransparency.Name = "ucrNudLabelTransparency"
        Me.ucrNudLabelTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudLabelTransparency.TabIndex = 24
        Me.ucrNudLabelTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLabelTransparency
        '
        Me.lblLabelTransparency.AutoSize = True
        Me.lblLabelTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblLabelTransparency.Location = New System.Drawing.Point(224, 53)
        Me.lblLabelTransparency.Name = "lblLabelTransparency"
        Me.lblLabelTransparency.Size = New System.Drawing.Size(104, 13)
        Me.lblLabelTransparency.TabIndex = 23
        Me.lblLabelTransparency.Text = "Label Transparency:"
        '
        'ucrNudHLineSize
        '
        Me.ucrNudHLineSize.AutoSize = True
        Me.ucrNudHLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudHLineSize.Location = New System.Drawing.Point(95, 50)
        Me.ucrNudHLineSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudHLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHLineSize.Name = "ucrNudHLineSize"
        Me.ucrNudHLineSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudHLineSize.TabIndex = 7
        Me.ucrNudHLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkHLineSize
        '
        Me.ucrChkHLineSize.AutoSize = True
        Me.ucrChkHLineSize.Checked = False
        Me.ucrChkHLineSize.Location = New System.Drawing.Point(6, 50)
        Me.ucrChkHLineSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkHLineSize.Name = "ucrChkHLineSize"
        Me.ucrChkHLineSize.Size = New System.Drawing.Size(83, 23)
        Me.ucrChkHLineSize.TabIndex = 6
        '
        'ucrInputHLineType
        '
        Me.ucrInputHLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputHLineType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputHLineType.GetSetSelectedIndex = -1
        Me.ucrInputHLineType.IsReadOnly = False
        Me.ucrInputHLineType.Location = New System.Drawing.Point(312, 23)
        Me.ucrInputHLineType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputHLineType.Name = "ucrInputHLineType"
        Me.ucrInputHLineType.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputHLineType.TabIndex = 4
        '
        'ucrInputHLineColour
        '
        Me.ucrInputHLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputHLineColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputHLineColour.GetSetSelectedIndex = -1
        Me.ucrInputHLineColour.IsReadOnly = False
        Me.ucrInputHLineColour.Location = New System.Drawing.Point(94, 23)
        Me.ucrInputHLineColour.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputHLineColour.Name = "ucrInputHLineColour"
        Me.ucrInputHLineColour.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputHLineColour.TabIndex = 3
        '
        'ucrChkHLineType
        '
        Me.ucrChkHLineType.AutoSize = True
        Me.ucrChkHLineType.Checked = False
        Me.ucrChkHLineType.Location = New System.Drawing.Point(224, 23)
        Me.ucrChkHLineType.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkHLineType.Name = "ucrChkHLineType"
        Me.ucrChkHLineType.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkHLineType.TabIndex = 2
        '
        'ucrChkHLineColour
        '
        Me.ucrChkHLineColour.AutoSize = True
        Me.ucrChkHLineColour.Checked = False
        Me.ucrChkHLineColour.Location = New System.Drawing.Point(6, 23)
        Me.ucrChkHLineColour.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkHLineColour.Name = "ucrChkHLineColour"
        Me.ucrChkHLineColour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkHLineColour.TabIndex = 1
        '
        'lblTercilesLineLabelTextLower
        '
        Me.lblTercilesLineLabelTextLower.AutoSize = True
        Me.lblTercilesLineLabelTextLower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTercilesLineLabelTextLower.Location = New System.Drawing.Point(103, 176)
        Me.lblTercilesLineLabelTextLower.Name = "lblTercilesLineLabelTextLower"
        Me.lblTercilesLineLabelTextLower.Size = New System.Drawing.Size(98, 13)
        Me.lblTercilesLineLabelTextLower.TabIndex = 15
        Me.lblTercilesLineLabelTextLower.Text = "Label Text (Lower):"
        '
        'lblTercilesLineType
        '
        Me.lblTercilesLineType.AutoSize = True
        Me.lblTercilesLineType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTercilesLineType.Location = New System.Drawing.Point(307, 148)
        Me.lblTercilesLineType.Name = "lblTercilesLineType"
        Me.lblTercilesLineType.Size = New System.Drawing.Size(63, 13)
        Me.lblTercilesLineType.TabIndex = 14
        Me.lblTercilesLineType.Text = "Label Type:"
        '
        'lblMedianLineLabelText
        '
        Me.lblMedianLineLabelText.AutoSize = True
        Me.lblMedianLineLabelText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMedianLineLabelText.Location = New System.Drawing.Point(132, 107)
        Me.lblMedianLineLabelText.Name = "lblMedianLineLabelText"
        Me.lblMedianLineLabelText.Size = New System.Drawing.Size(60, 13)
        Me.lblMedianLineLabelText.TabIndex = 10
        Me.lblMedianLineLabelText.Text = "Label Text:"
        '
        'lblMedianLineType
        '
        Me.lblMedianLineType.AutoSize = True
        Me.lblMedianLineType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMedianLineType.Location = New System.Drawing.Point(307, 78)
        Me.lblMedianLineType.Name = "lblMedianLineType"
        Me.lblMedianLineType.Size = New System.Drawing.Size(63, 13)
        Me.lblMedianLineType.TabIndex = 9
        Me.lblMedianLineType.Text = "Label Type:"
        '
        'lblMeanLineLabelText
        '
        Me.lblMeanLineLabelText.AutoSize = True
        Me.lblMeanLineLabelText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeanLineLabelText.Location = New System.Drawing.Point(132, 42)
        Me.lblMeanLineLabelText.Name = "lblMeanLineLabelText"
        Me.lblMeanLineLabelText.Size = New System.Drawing.Size(60, 13)
        Me.lblMeanLineLabelText.TabIndex = 5
        Me.lblMeanLineLabelText.Text = "Label Text:"
        '
        'lblMeanLineType
        '
        Me.lblMeanLineType.AutoSize = True
        Me.lblMeanLineType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMeanLineType.Location = New System.Drawing.Point(307, 13)
        Me.lblMeanLineType.Name = "lblMeanLineType"
        Me.lblMeanLineType.Size = New System.Drawing.Size(63, 13)
        Me.lblMeanLineType.TabIndex = 4
        Me.lblMeanLineType.Text = "Label Type:"
        '
        'ucrChkTercilesLineLabelIncludeValue
        '
        Me.ucrChkTercilesLineLabelIncludeValue.AutoSize = True
        Me.ucrChkTercilesLineLabelIncludeValue.Checked = False
        Me.ucrChkTercilesLineLabelIncludeValue.Location = New System.Drawing.Point(390, 188)
        Me.ucrChkTercilesLineLabelIncludeValue.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkTercilesLineLabelIncludeValue.Name = "ucrChkTercilesLineLabelIncludeValue"
        Me.ucrChkTercilesLineLabelIncludeValue.Size = New System.Drawing.Size(186, 23)
        Me.ucrChkTercilesLineLabelIncludeValue.TabIndex = 19
        '
        'ucrChkMedianLineLabelIncludeValue
        '
        Me.ucrChkMedianLineLabelIncludeValue.AutoSize = True
        Me.ucrChkMedianLineLabelIncludeValue.Checked = False
        Me.ucrChkMedianLineLabelIncludeValue.Location = New System.Drawing.Point(390, 106)
        Me.ucrChkMedianLineLabelIncludeValue.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMedianLineLabelIncludeValue.Name = "ucrChkMedianLineLabelIncludeValue"
        Me.ucrChkMedianLineLabelIncludeValue.Size = New System.Drawing.Size(186, 23)
        Me.ucrChkMedianLineLabelIncludeValue.TabIndex = 18
        '
        'ucrChkMeanLineLabelIncludeValue
        '
        Me.ucrChkMeanLineLabelIncludeValue.AutoSize = True
        Me.ucrChkMeanLineLabelIncludeValue.Checked = False
        Me.ucrChkMeanLineLabelIncludeValue.Location = New System.Drawing.Point(390, 41)
        Me.ucrChkMeanLineLabelIncludeValue.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkMeanLineLabelIncludeValue.Name = "ucrChkMeanLineLabelIncludeValue"
        Me.ucrChkMeanLineLabelIncludeValue.Size = New System.Drawing.Size(185, 23)
        Me.ucrChkMeanLineLabelIncludeValue.TabIndex = 17
        '
        'ucrInputTercilesLineLabelTextLower
        '
        Me.ucrInputTercilesLineLabelTextLower.AddQuotesIfUnrecognised = True
        Me.ucrInputTercilesLineLabelTextLower.AutoSize = True
        Me.ucrInputTercilesLineLabelTextLower.IsMultiline = False
        Me.ucrInputTercilesLineLabelTextLower.IsReadOnly = False
        Me.ucrInputTercilesLineLabelTextLower.Location = New System.Drawing.Point(264, 174)
        Me.ucrInputTercilesLineLabelTextLower.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputTercilesLineLabelTextLower.Name = "ucrInputTercilesLineLabelTextLower"
        Me.ucrInputTercilesLineLabelTextLower.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputTercilesLineLabelTextLower.TabIndex = 16
        '
        'ucrInputTercilesLabelType
        '
        Me.ucrInputTercilesLabelType.AddQuotesIfUnrecognised = True
        Me.ucrInputTercilesLabelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputTercilesLabelType.GetSetSelectedIndex = -1
        Me.ucrInputTercilesLabelType.IsReadOnly = False
        Me.ucrInputTercilesLabelType.Location = New System.Drawing.Point(426, 144)
        Me.ucrInputTercilesLabelType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputTercilesLabelType.Name = "ucrInputTercilesLabelType"
        Me.ucrInputTercilesLabelType.Size = New System.Drawing.Size(95, 21)
        Me.ucrInputTercilesLabelType.TabIndex = 13
        '
        'ucrInputMedianLineLabelText
        '
        Me.ucrInputMedianLineLabelText.AddQuotesIfUnrecognised = True
        Me.ucrInputMedianLineLabelText.AutoSize = True
        Me.ucrInputMedianLineLabelText.IsMultiline = False
        Me.ucrInputMedianLineLabelText.IsReadOnly = False
        Me.ucrInputMedianLineLabelText.Location = New System.Drawing.Point(264, 105)
        Me.ucrInputMedianLineLabelText.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMedianLineLabelText.Name = "ucrInputMedianLineLabelText"
        Me.ucrInputMedianLineLabelText.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputMedianLineLabelText.TabIndex = 11
        '
        'ucrInputMedianLabelType
        '
        Me.ucrInputMedianLabelType.AddQuotesIfUnrecognised = True
        Me.ucrInputMedianLabelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMedianLabelType.GetSetSelectedIndex = -1
        Me.ucrInputMedianLabelType.IsReadOnly = False
        Me.ucrInputMedianLabelType.Location = New System.Drawing.Point(426, 74)
        Me.ucrInputMedianLabelType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMedianLabelType.Name = "ucrInputMedianLabelType"
        Me.ucrInputMedianLabelType.Size = New System.Drawing.Size(95, 21)
        Me.ucrInputMedianLabelType.TabIndex = 8
        '
        'ucrInputMeanLineLabelText
        '
        Me.ucrInputMeanLineLabelText.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanLineLabelText.AutoSize = True
        Me.ucrInputMeanLineLabelText.IsMultiline = False
        Me.ucrInputMeanLineLabelText.IsReadOnly = False
        Me.ucrInputMeanLineLabelText.Location = New System.Drawing.Point(264, 40)
        Me.ucrInputMeanLineLabelText.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMeanLineLabelText.Name = "ucrInputMeanLineLabelText"
        Me.ucrInputMeanLineLabelText.Size = New System.Drawing.Size(123, 21)
        Me.ucrInputMeanLineLabelText.TabIndex = 6
        '
        'ucrChkAddTercilesLabel
        '
        Me.ucrChkAddTercilesLabel.AutoSize = True
        Me.ucrChkAddTercilesLabel.Checked = False
        Me.ucrChkAddTercilesLabel.Location = New System.Drawing.Point(132, 144)
        Me.ucrChkAddTercilesLabel.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAddTercilesLabel.Name = "ucrChkAddTercilesLabel"
        Me.ucrChkAddTercilesLabel.Size = New System.Drawing.Size(146, 23)
        Me.ucrChkAddTercilesLabel.TabIndex = 2
        '
        'ucrChkAddMedianLabel
        '
        Me.ucrChkAddMedianLabel.AutoSize = True
        Me.ucrChkAddMedianLabel.Checked = False
        Me.ucrChkAddMedianLabel.Location = New System.Drawing.Point(132, 75)
        Me.ucrChkAddMedianLabel.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAddMedianLabel.Name = "ucrChkAddMedianLabel"
        Me.ucrChkAddMedianLabel.Size = New System.Drawing.Size(146, 23)
        Me.ucrChkAddMedianLabel.TabIndex = 2
        '
        'ucrInputMeanLabelType
        '
        Me.ucrInputMeanLabelType.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanLabelType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMeanLabelType.GetSetSelectedIndex = -1
        Me.ucrInputMeanLabelType.IsReadOnly = False
        Me.ucrInputMeanLabelType.Location = New System.Drawing.Point(426, 9)
        Me.ucrInputMeanLabelType.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMeanLabelType.Name = "ucrInputMeanLabelType"
        Me.ucrInputMeanLabelType.Size = New System.Drawing.Size(95, 21)
        Me.ucrInputMeanLabelType.TabIndex = 3
        '
        'ucrChkAddMean
        '
        Me.ucrChkAddMean.AutoSize = True
        Me.ucrChkAddMean.Checked = False
        Me.ucrChkAddMean.Location = New System.Drawing.Point(9, 10)
        Me.ucrChkAddMean.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAddMean.Name = "ucrChkAddMean"
        Me.ucrChkAddMean.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkAddMean.TabIndex = 1
        '
        'ucrChkAddMeanLabel
        '
        Me.ucrChkAddMeanLabel.AutoSize = True
        Me.ucrChkAddMeanLabel.Checked = False
        Me.ucrChkAddMeanLabel.Location = New System.Drawing.Point(132, 10)
        Me.ucrChkAddMeanLabel.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAddMeanLabel.Name = "ucrChkAddMeanLabel"
        Me.ucrChkAddMeanLabel.Size = New System.Drawing.Size(146, 23)
        Me.ucrChkAddMeanLabel.TabIndex = 2
        '
        'ucrChkAddMedian
        '
        Me.ucrChkAddMedian.AutoSize = True
        Me.ucrChkAddMedian.Checked = False
        Me.ucrChkAddMedian.Location = New System.Drawing.Point(9, 77)
        Me.ucrChkAddMedian.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAddMedian.Name = "ucrChkAddMedian"
        Me.ucrChkAddMedian.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkAddMedian.TabIndex = 1
        '
        'ucrChkAddTerciles
        '
        Me.ucrChkAddTerciles.AutoSize = True
        Me.ucrChkAddTerciles.Checked = False
        Me.ucrChkAddTerciles.Location = New System.Drawing.Point(9, 144)
        Me.ucrChkAddTerciles.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkAddTerciles.Name = "ucrChkAddTerciles"
        Me.ucrChkAddTerciles.Size = New System.Drawing.Size(119, 23)
        Me.ucrChkAddTerciles.TabIndex = 1
        '
        'tpPanel
        '
        Me.tpPanel.Controls.Add(Me.grpMinorGridLine)
        Me.tpPanel.Controls.Add(Me.grpPnlBorder)
        Me.tpPanel.Controls.Add(Me.grpMajorGridLines)
        Me.tpPanel.Controls.Add(Me.grpPnlBackground)
        Me.tpPanel.Location = New System.Drawing.Point(4, 22)
        Me.tpPanel.Name = "tpPanel"
        Me.tpPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPanel.Size = New System.Drawing.Size(581, 309)
        Me.tpPanel.TabIndex = 3
        Me.tpPanel.Text = "Panel"
        Me.tpPanel.UseVisualStyleBackColor = True
        '
        'grpMinorGridLine
        '
        Me.grpMinorGridLine.Controls.Add(Me.lblMinorGridLineSize)
        Me.grpMinorGridLine.Controls.Add(Me.ucrChkIncludeMinorGridLines)
        Me.grpMinorGridLine.Controls.Add(Me.lblMinorGridLineLinetype)
        Me.grpMinorGridLine.Controls.Add(Me.ucrNudMinorGridLineSize)
        Me.grpMinorGridLine.Controls.Add(Me.lblMinorGridLineColour)
        Me.grpMinorGridLine.Controls.Add(Me.ucrInputMinorGridLineLinetype)
        Me.grpMinorGridLine.Controls.Add(Me.ucrInputMinorGridLineColour)
        Me.grpMinorGridLine.Location = New System.Drawing.Point(264, 166)
        Me.grpMinorGridLine.Name = "grpMinorGridLine"
        Me.grpMinorGridLine.Size = New System.Drawing.Size(226, 140)
        Me.grpMinorGridLine.TabIndex = 3
        Me.grpMinorGridLine.TabStop = False
        Me.grpMinorGridLine.Text = "Minor Grid Lines"
        '
        'lblMinorGridLineSize
        '
        Me.lblMinorGridLineSize.AutoSize = True
        Me.lblMinorGridLineSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinorGridLineSize.Location = New System.Drawing.Point(6, 114)
        Me.lblMinorGridLineSize.Name = "lblMinorGridLineSize"
        Me.lblMinorGridLineSize.Size = New System.Drawing.Size(30, 13)
        Me.lblMinorGridLineSize.TabIndex = 14
        Me.lblMinorGridLineSize.Text = "Size:"
        '
        'ucrChkIncludeMinorGridLines
        '
        Me.ucrChkIncludeMinorGridLines.AutoSize = True
        Me.ucrChkIncludeMinorGridLines.Checked = False
        Me.ucrChkIncludeMinorGridLines.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkIncludeMinorGridLines.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkIncludeMinorGridLines.Name = "ucrChkIncludeMinorGridLines"
        Me.ucrChkIncludeMinorGridLines.Size = New System.Drawing.Size(194, 23)
        Me.ucrChkIncludeMinorGridLines.TabIndex = 9
        '
        'lblMinorGridLineLinetype
        '
        Me.lblMinorGridLineLinetype.AutoSize = True
        Me.lblMinorGridLineLinetype.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinorGridLineLinetype.Location = New System.Drawing.Point(6, 83)
        Me.lblMinorGridLineLinetype.Name = "lblMinorGridLineLinetype"
        Me.lblMinorGridLineLinetype.Size = New System.Drawing.Size(57, 13)
        Me.lblMinorGridLineLinetype.TabIndex = 13
        Me.lblMinorGridLineLinetype.Text = "Line Type:"
        '
        'ucrNudMinorGridLineSize
        '
        Me.ucrNudMinorGridLineSize.AutoSize = True
        Me.ucrNudMinorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Location = New System.Drawing.Point(94, 110)
        Me.ucrNudMinorGridLineSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMinorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Name = "ucrNudMinorGridLineSize"
        Me.ucrNudMinorGridLineSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinorGridLineSize.TabIndex = 8
        Me.ucrNudMinorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinorGridLineColour
        '
        Me.lblMinorGridLineColour.AutoSize = True
        Me.lblMinorGridLineColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMinorGridLineColour.Location = New System.Drawing.Point(6, 52)
        Me.lblMinorGridLineColour.Name = "lblMinorGridLineColour"
        Me.lblMinorGridLineColour.Size = New System.Drawing.Size(40, 13)
        Me.lblMinorGridLineColour.TabIndex = 12
        Me.lblMinorGridLineColour.Text = "Colour:"
        '
        'ucrInputMinorGridLineLinetype
        '
        Me.ucrInputMinorGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorGridLineLinetype.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMinorGridLineLinetype.GetSetSelectedIndex = -1
        Me.ucrInputMinorGridLineLinetype.IsReadOnly = False
        Me.ucrInputMinorGridLineLinetype.Location = New System.Drawing.Point(94, 79)
        Me.ucrInputMinorGridLineLinetype.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMinorGridLineLinetype.Name = "ucrInputMinorGridLineLinetype"
        Me.ucrInputMinorGridLineLinetype.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputMinorGridLineLinetype.TabIndex = 4
        '
        'ucrInputMinorGridLineColour
        '
        Me.ucrInputMinorGridLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorGridLineColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMinorGridLineColour.GetSetSelectedIndex = -1
        Me.ucrInputMinorGridLineColour.IsReadOnly = False
        Me.ucrInputMinorGridLineColour.Location = New System.Drawing.Point(94, 48)
        Me.ucrInputMinorGridLineColour.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMinorGridLineColour.Name = "ucrInputMinorGridLineColour"
        Me.ucrInputMinorGridLineColour.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputMinorGridLineColour.TabIndex = 3
        '
        'grpPnlBorder
        '
        Me.grpPnlBorder.Controls.Add(Me.ucrNudBorderSize)
        Me.grpPnlBorder.Controls.Add(Me.UcrChkBorderSize)
        Me.grpPnlBorder.Controls.Add(Me.ucrInputBorderLinetype)
        Me.grpPnlBorder.Controls.Add(Me.ucrInputBorderColour)
        Me.grpPnlBorder.Controls.Add(Me.ucrChkBorderLineType)
        Me.grpPnlBorder.Controls.Add(Me.ucrChkBorderColour)
        Me.grpPnlBorder.Location = New System.Drawing.Point(264, 9)
        Me.grpPnlBorder.Name = "grpPnlBorder"
        Me.grpPnlBorder.Size = New System.Drawing.Size(226, 117)
        Me.grpPnlBorder.TabIndex = 2
        Me.grpPnlBorder.TabStop = False
        Me.grpPnlBorder.Text = "Border"
        '
        'ucrNudBorderSize
        '
        Me.ucrNudBorderSize.AutoSize = True
        Me.ucrNudBorderSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBorderSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBorderSize.Location = New System.Drawing.Point(95, 86)
        Me.ucrNudBorderSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudBorderSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBorderSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBorderSize.Name = "ucrNudBorderSize"
        Me.ucrNudBorderSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudBorderSize.TabIndex = 6
        Me.ucrNudBorderSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkBorderSize
        '
        Me.UcrChkBorderSize.AutoSize = True
        Me.UcrChkBorderSize.Checked = False
        Me.UcrChkBorderSize.Location = New System.Drawing.Point(6, 88)
        Me.UcrChkBorderSize.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrChkBorderSize.Name = "UcrChkBorderSize"
        Me.UcrChkBorderSize.Size = New System.Drawing.Size(83, 23)
        Me.UcrChkBorderSize.TabIndex = 5
        '
        'ucrInputBorderLinetype
        '
        Me.ucrInputBorderLinetype.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderLinetype.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBorderLinetype.GetSetSelectedIndex = -1
        Me.ucrInputBorderLinetype.IsReadOnly = False
        Me.ucrInputBorderLinetype.Location = New System.Drawing.Point(94, 56)
        Me.ucrInputBorderLinetype.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputBorderLinetype.Name = "ucrInputBorderLinetype"
        Me.ucrInputBorderLinetype.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputBorderLinetype.TabIndex = 4
        '
        'ucrInputBorderColour
        '
        Me.ucrInputBorderColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBorderColour.GetSetSelectedIndex = -1
        Me.ucrInputBorderColour.IsReadOnly = False
        Me.ucrInputBorderColour.Location = New System.Drawing.Point(94, 23)
        Me.ucrInputBorderColour.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputBorderColour.Name = "ucrInputBorderColour"
        Me.ucrInputBorderColour.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputBorderColour.TabIndex = 3
        '
        'ucrChkBorderLineType
        '
        Me.ucrChkBorderLineType.AutoSize = True
        Me.ucrChkBorderLineType.Checked = False
        Me.ucrChkBorderLineType.Location = New System.Drawing.Point(6, 56)
        Me.ucrChkBorderLineType.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkBorderLineType.Name = "ucrChkBorderLineType"
        Me.ucrChkBorderLineType.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderLineType.TabIndex = 2
        '
        'ucrChkBorderColour
        '
        Me.ucrChkBorderColour.AutoSize = True
        Me.ucrChkBorderColour.Checked = False
        Me.ucrChkBorderColour.Location = New System.Drawing.Point(6, 23)
        Me.ucrChkBorderColour.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkBorderColour.Name = "ucrChkBorderColour"
        Me.ucrChkBorderColour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkBorderColour.TabIndex = 1
        '
        'grpMajorGridLines
        '
        Me.grpMajorGridLines.Controls.Add(Me.lblMajorGridLineSize)
        Me.grpMajorGridLines.Controls.Add(Me.lblMajorGridLineLinetype)
        Me.grpMajorGridLines.Controls.Add(Me.lblMajorGridLineColour)
        Me.grpMajorGridLines.Controls.Add(Me.ucrChkIncludeMajorGridLines)
        Me.grpMajorGridLines.Controls.Add(Me.ucrNudMajorGridLineSize)
        Me.grpMajorGridLines.Controls.Add(Me.ucrInputMajorGridLineLinetype)
        Me.grpMajorGridLines.Controls.Add(Me.ucrInputMajorGridLineColour)
        Me.grpMajorGridLines.Location = New System.Drawing.Point(6, 166)
        Me.grpMajorGridLines.Name = "grpMajorGridLines"
        Me.grpMajorGridLines.Size = New System.Drawing.Size(236, 140)
        Me.grpMajorGridLines.TabIndex = 1
        Me.grpMajorGridLines.TabStop = False
        Me.grpMajorGridLines.Text = "Major Grid Lines"
        '
        'lblMajorGridLineSize
        '
        Me.lblMajorGridLineSize.AutoSize = True
        Me.lblMajorGridLineSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMajorGridLineSize.Location = New System.Drawing.Point(6, 114)
        Me.lblMajorGridLineSize.Name = "lblMajorGridLineSize"
        Me.lblMajorGridLineSize.Size = New System.Drawing.Size(30, 13)
        Me.lblMajorGridLineSize.TabIndex = 11
        Me.lblMajorGridLineSize.Text = "Size:"
        '
        'lblMajorGridLineLinetype
        '
        Me.lblMajorGridLineLinetype.AutoSize = True
        Me.lblMajorGridLineLinetype.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMajorGridLineLinetype.Location = New System.Drawing.Point(6, 83)
        Me.lblMajorGridLineLinetype.Name = "lblMajorGridLineLinetype"
        Me.lblMajorGridLineLinetype.Size = New System.Drawing.Size(57, 13)
        Me.lblMajorGridLineLinetype.TabIndex = 10
        Me.lblMajorGridLineLinetype.Text = "Line Type:"
        '
        'lblMajorGridLineColour
        '
        Me.lblMajorGridLineColour.AutoSize = True
        Me.lblMajorGridLineColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblMajorGridLineColour.Location = New System.Drawing.Point(6, 52)
        Me.lblMajorGridLineColour.Name = "lblMajorGridLineColour"
        Me.lblMajorGridLineColour.Size = New System.Drawing.Size(40, 13)
        Me.lblMajorGridLineColour.TabIndex = 9
        Me.lblMajorGridLineColour.Text = "Colour:"
        '
        'ucrChkIncludeMajorGridLines
        '
        Me.ucrChkIncludeMajorGridLines.AutoSize = True
        Me.ucrChkIncludeMajorGridLines.Checked = False
        Me.ucrChkIncludeMajorGridLines.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkIncludeMajorGridLines.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkIncludeMajorGridLines.Name = "ucrChkIncludeMajorGridLines"
        Me.ucrChkIncludeMajorGridLines.Size = New System.Drawing.Size(223, 23)
        Me.ucrChkIncludeMajorGridLines.TabIndex = 8
        '
        'ucrNudMajorGridLineSize
        '
        Me.ucrNudMajorGridLineSize.AutoSize = True
        Me.ucrNudMajorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Location = New System.Drawing.Point(94, 110)
        Me.ucrNudMajorGridLineSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudMajorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Name = "ucrNudMajorGridLineSize"
        Me.ucrNudMajorGridLineSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMajorGridLineSize.TabIndex = 7
        Me.ucrNudMajorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMajorGridLineLinetype
        '
        Me.ucrInputMajorGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorGridLineLinetype.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMajorGridLineLinetype.GetSetSelectedIndex = -1
        Me.ucrInputMajorGridLineLinetype.IsReadOnly = False
        Me.ucrInputMajorGridLineLinetype.Location = New System.Drawing.Point(94, 79)
        Me.ucrInputMajorGridLineLinetype.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMajorGridLineLinetype.Name = "ucrInputMajorGridLineLinetype"
        Me.ucrInputMajorGridLineLinetype.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputMajorGridLineLinetype.TabIndex = 4
        '
        'ucrInputMajorGridLineColour
        '
        Me.ucrInputMajorGridLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorGridLineColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputMajorGridLineColour.GetSetSelectedIndex = -1
        Me.ucrInputMajorGridLineColour.IsReadOnly = False
        Me.ucrInputMajorGridLineColour.Location = New System.Drawing.Point(94, 48)
        Me.ucrInputMajorGridLineColour.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputMajorGridLineColour.Name = "ucrInputMajorGridLineColour"
        Me.ucrInputMajorGridLineColour.Size = New System.Drawing.Size(106, 21)
        Me.ucrInputMajorGridLineColour.TabIndex = 3
        '
        'grpPnlBackground
        '
        Me.grpPnlBackground.Controls.Add(Me.ucrNudPnlBackgroundSize)
        Me.grpPnlBackground.Controls.Add(Me.UcrInputPnlBackgroundFill)
        Me.grpPnlBackground.Controls.Add(Me.UcrInputPnlBackgroundLinetype)
        Me.grpPnlBackground.Controls.Add(Me.UcrInputPnlBackgroundColour)
        Me.grpPnlBackground.Controls.Add(Me.UcrChkPnlBackgroundSize)
        Me.grpPnlBackground.Controls.Add(Me.UcrChkPnlBackgroundLineType)
        Me.grpPnlBackground.Controls.Add(Me.UcrChkPnlBackgroundFill)
        Me.grpPnlBackground.Controls.Add(Me.ucrChkPnlBackgroundColour)
        Me.grpPnlBackground.Location = New System.Drawing.Point(6, 9)
        Me.grpPnlBackground.Name = "grpPnlBackground"
        Me.grpPnlBackground.Size = New System.Drawing.Size(236, 154)
        Me.grpPnlBackground.TabIndex = 0
        Me.grpPnlBackground.TabStop = False
        Me.grpPnlBackground.Text = "Background"
        '
        'ucrNudPnlBackgroundSize
        '
        Me.ucrNudPnlBackgroundSize.AutoSize = True
        Me.ucrNudPnlBackgroundSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Location = New System.Drawing.Point(94, 120)
        Me.ucrNudPnlBackgroundSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudPnlBackgroundSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Name = "ucrNudPnlBackgroundSize"
        Me.ucrNudPnlBackgroundSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPnlBackgroundSize.TabIndex = 2
        Me.ucrNudPnlBackgroundSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrInputPnlBackgroundFill
        '
        Me.UcrInputPnlBackgroundFill.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundFill.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputPnlBackgroundFill.GetSetSelectedIndex = -1
        Me.UcrInputPnlBackgroundFill.IsReadOnly = False
        Me.UcrInputPnlBackgroundFill.Location = New System.Drawing.Point(94, 86)
        Me.UcrInputPnlBackgroundFill.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UcrInputPnlBackgroundFill.Name = "UcrInputPnlBackgroundFill"
        Me.UcrInputPnlBackgroundFill.Size = New System.Drawing.Size(106, 21)
        Me.UcrInputPnlBackgroundFill.TabIndex = 5
        '
        'UcrInputPnlBackgroundLinetype
        '
        Me.UcrInputPnlBackgroundLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundLinetype.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputPnlBackgroundLinetype.GetSetSelectedIndex = -1
        Me.UcrInputPnlBackgroundLinetype.IsReadOnly = False
        Me.UcrInputPnlBackgroundLinetype.Location = New System.Drawing.Point(94, 54)
        Me.UcrInputPnlBackgroundLinetype.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UcrInputPnlBackgroundLinetype.Name = "UcrInputPnlBackgroundLinetype"
        Me.UcrInputPnlBackgroundLinetype.Size = New System.Drawing.Size(106, 21)
        Me.UcrInputPnlBackgroundLinetype.TabIndex = 4
        '
        'UcrInputPnlBackgroundColour
        '
        Me.UcrInputPnlBackgroundColour.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundColour.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrInputPnlBackgroundColour.GetSetSelectedIndex = -1
        Me.UcrInputPnlBackgroundColour.IsReadOnly = False
        Me.UcrInputPnlBackgroundColour.Location = New System.Drawing.Point(94, 22)
        Me.UcrInputPnlBackgroundColour.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.UcrInputPnlBackgroundColour.Name = "UcrInputPnlBackgroundColour"
        Me.UcrInputPnlBackgroundColour.Size = New System.Drawing.Size(106, 21)
        Me.UcrInputPnlBackgroundColour.TabIndex = 2
        '
        'UcrChkPnlBackgroundSize
        '
        Me.UcrChkPnlBackgroundSize.AutoSize = True
        Me.UcrChkPnlBackgroundSize.Checked = False
        Me.UcrChkPnlBackgroundSize.Location = New System.Drawing.Point(9, 120)
        Me.UcrChkPnlBackgroundSize.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrChkPnlBackgroundSize.Name = "UcrChkPnlBackgroundSize"
        Me.UcrChkPnlBackgroundSize.Size = New System.Drawing.Size(83, 23)
        Me.UcrChkPnlBackgroundSize.TabIndex = 3
        '
        'UcrChkPnlBackgroundLineType
        '
        Me.UcrChkPnlBackgroundLineType.AutoSize = True
        Me.UcrChkPnlBackgroundLineType.Checked = False
        Me.UcrChkPnlBackgroundLineType.Location = New System.Drawing.Point(9, 55)
        Me.UcrChkPnlBackgroundLineType.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrChkPnlBackgroundLineType.Name = "UcrChkPnlBackgroundLineType"
        Me.UcrChkPnlBackgroundLineType.Size = New System.Drawing.Size(100, 23)
        Me.UcrChkPnlBackgroundLineType.TabIndex = 2
        '
        'UcrChkPnlBackgroundFill
        '
        Me.UcrChkPnlBackgroundFill.AutoSize = True
        Me.UcrChkPnlBackgroundFill.Checked = False
        Me.UcrChkPnlBackgroundFill.Location = New System.Drawing.Point(9, 88)
        Me.UcrChkPnlBackgroundFill.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrChkPnlBackgroundFill.Name = "UcrChkPnlBackgroundFill"
        Me.UcrChkPnlBackgroundFill.Size = New System.Drawing.Size(83, 23)
        Me.UcrChkPnlBackgroundFill.TabIndex = 1
        '
        'ucrChkPnlBackgroundColour
        '
        Me.ucrChkPnlBackgroundColour.AutoSize = True
        Me.ucrChkPnlBackgroundColour.Checked = False
        Me.ucrChkPnlBackgroundColour.Location = New System.Drawing.Point(9, 23)
        Me.ucrChkPnlBackgroundColour.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkPnlBackgroundColour.Name = "ucrChkPnlBackgroundColour"
        Me.ucrChkPnlBackgroundColour.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkPnlBackgroundColour.TabIndex = 0
        '
        'tpRug
        '
        Me.tpRug.Controls.Add(Me.ucrInputXaxisOptions)
        Me.tpRug.Controls.Add(Me.lblXaxisOptions)
        Me.tpRug.Controls.Add(Me.lblYaxisOptions)
        Me.tpRug.Controls.Add(Me.ucrChkXaxis)
        Me.tpRug.Controls.Add(Me.ucrInputYaxisOptions)
        Me.tpRug.Controls.Add(Me.ucrChkYaxis)
        Me.tpRug.Location = New System.Drawing.Point(4, 22)
        Me.tpRug.Name = "tpRug"
        Me.tpRug.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRug.Size = New System.Drawing.Size(581, 309)
        Me.tpRug.TabIndex = 5
        Me.tpRug.Text = "Rug"
        Me.tpRug.UseVisualStyleBackColor = True
        '
        'ucrInputXaxisOptions
        '
        Me.ucrInputXaxisOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputXaxisOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputXaxisOptions.GetSetSelectedIndex = -1
        Me.ucrInputXaxisOptions.IsReadOnly = False
        Me.ucrInputXaxisOptions.Location = New System.Drawing.Point(225, 69)
        Me.ucrInputXaxisOptions.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXaxisOptions.Name = "ucrInputXaxisOptions"
        Me.ucrInputXaxisOptions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputXaxisOptions.TabIndex = 5
        '
        'lblXaxisOptions
        '
        Me.lblXaxisOptions.AutoSize = True
        Me.lblXaxisOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXaxisOptions.Location = New System.Drawing.Point(135, 69)
        Me.lblXaxisOptions.Name = "lblXaxisOptions"
        Me.lblXaxisOptions.Size = New System.Drawing.Size(77, 13)
        Me.lblXaxisOptions.TabIndex = 4
        Me.lblXaxisOptions.Text = "X-axis Options:"
        '
        'lblYaxisOptions
        '
        Me.lblYaxisOptions.AutoSize = True
        Me.lblYaxisOptions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYaxisOptions.Location = New System.Drawing.Point(135, 25)
        Me.lblYaxisOptions.Name = "lblYaxisOptions"
        Me.lblYaxisOptions.Size = New System.Drawing.Size(77, 13)
        Me.lblYaxisOptions.TabIndex = 1
        Me.lblYaxisOptions.Text = "Y-axis Options:"
        '
        'ucrChkXaxis
        '
        Me.ucrChkXaxis.AutoSize = True
        Me.ucrChkXaxis.Checked = False
        Me.ucrChkXaxis.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkXaxis.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkXaxis.Name = "ucrChkXaxis"
        Me.ucrChkXaxis.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkXaxis.TabIndex = 3
        '
        'ucrInputYaxisOptions
        '
        Me.ucrInputYaxisOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputYaxisOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputYaxisOptions.GetSetSelectedIndex = -1
        Me.ucrInputYaxisOptions.IsReadOnly = False
        Me.ucrInputYaxisOptions.Location = New System.Drawing.Point(225, 25)
        Me.ucrInputYaxisOptions.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYaxisOptions.Name = "ucrInputYaxisOptions"
        Me.ucrInputYaxisOptions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputYaxisOptions.TabIndex = 2
        '
        'ucrChkYaxis
        '
        Me.ucrChkYaxis.AutoSize = True
        Me.ucrChkYaxis.Checked = False
        Me.ucrChkYaxis.Location = New System.Drawing.Point(6, 25)
        Me.ucrChkYaxis.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYaxis.Name = "ucrChkYaxis"
        Me.ucrChkYaxis.Size = New System.Drawing.Size(100, 23)
        Me.ucrChkYaxis.TabIndex = 0
        '
        'ttPICSARainfallGraph
        '
        Me.ttPICSARainfallGraph.AutoPopDelay = 10000
        Me.ttPICSARainfallGraph.InitialDelay = 500
        Me.ttPICSARainfallGraph.ReshowDelay = 100
        '
        'ucrSdgPICSARainfalbuttons
        '
        Me.ucrSdgPICSARainfalbuttons.AutoSize = True
        Me.ucrSdgPICSARainfalbuttons.Location = New System.Drawing.Point(217, 338)
        Me.ucrSdgPICSARainfalbuttons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        Me.ucrSdgPICSARainfalbuttons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgPICSARainfalbuttons.TabIndex = 0
        '
        'sdgPICSARainfallGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(597, 367)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.Controls.Add(Me.tbPICSA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PICSA Rainfall Graph"
        Me.tbPICSA.ResumeLayout(False)
        Me.tpTitles.ResumeLayout(False)
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
        Me.tpXAxis.ResumeLayout(False)
        Me.grpXAxisLabels.ResumeLayout(False)
        Me.grpXAxisLabels.PerformLayout()
        Me.tpYAxis.ResumeLayout(False)
        Me.tpYAxis.PerformLayout()
        Me.tpLines.ResumeLayout(False)
        Me.tpLines.PerformLayout()
        Me.grpLinesFormat.ResumeLayout(False)
        Me.grpLinesFormat.PerformLayout()
        Me.tpPanel.ResumeLayout(False)
        Me.grpMinorGridLine.ResumeLayout(False)
        Me.grpMinorGridLine.PerformLayout()
        Me.grpPnlBorder.ResumeLayout(False)
        Me.grpPnlBorder.PerformLayout()
        Me.grpMajorGridLines.ResumeLayout(False)
        Me.grpMajorGridLines.PerformLayout()
        Me.grpPnlBackground.ResumeLayout(False)
        Me.grpPnlBackground.PerformLayout()
        Me.tpRug.ResumeLayout(False)
        Me.tpRug.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkAddMean As ucrCheck
    Friend WithEvents ucrChkAddMedian As ucrCheck
    Friend WithEvents ucrChkAddTerciles As ucrCheck
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents ucrNudXaxisLabelSize As ucrNud
    Friend WithEvents lblXTo As Label
    Friend WithEvents lblXFrom As Label
    Friend WithEvents lblXInStepsOf As Label
    Friend WithEvents ucrInputXFrom As ucrInputTextBox
    Friend WithEvents ucrInputXTo As ucrInputTextBox
    Friend WithEvents ucrInputXInStepsOf As ucrInputTextBox
    Friend WithEvents tbPICSA As TabControl
    Friend WithEvents tpTitles As TabPage
    Friend WithEvents tpXAxis As TabPage
    Friend WithEvents tpLines As TabPage
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents grpGraphTitles As GroupBox
    Friend WithEvents ucrInputGraphcCaption As ucrInputTextBox
    Friend WithEvents grpXAxisLabels As GroupBox
    Friend WithEvents tpPanel As TabPage
    Friend WithEvents ucrChkXAxisLabelSize As ucrCheck
    Friend WithEvents ucrChkSpecifyXAxisTickMarks As ucrCheck
    Friend WithEvents grpPnlBackground As GroupBox
    Friend WithEvents grpMajorGridLines As GroupBox
    Friend WithEvents UcrChkPnlBackgroundSize As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundLineType As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundFill As ucrCheck
    Friend WithEvents ucrChkPnlBackgroundColour As ucrCheck
    Friend WithEvents ucrInputMajorGridLineLinetype As ucrInputComboBox
    Friend WithEvents ucrInputMajorGridLineColour As ucrInputComboBox
    Friend WithEvents ucrNudPnlBackgroundSize As ucrNud
    Friend WithEvents UcrInputPnlBackgroundFill As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundLinetype As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundColour As ucrInputComboBox
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents ucrNudCaptionSize As ucrNud
    Friend WithEvents ucrNudSubTitleSize As ucrNud
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents grpyAxisTitle As GroupBox
    Friend WithEvents grpPnlBorder As GroupBox
    Friend WithEvents ucrInputBorderLinetype As ucrInputComboBox
    Friend WithEvents ucrInputBorderColour As ucrInputComboBox
    Friend WithEvents ucrChkBorderLineType As ucrCheck
    Friend WithEvents ucrChkBorderColour As ucrCheck
    Friend WithEvents grpMinorGridLine As GroupBox
    Friend WithEvents ucrInputMinorGridLineLinetype As ucrInputComboBox
    Friend WithEvents ucrInputMinorGridLineColour As ucrInputComboBox
    Friend WithEvents ucrNudBorderSize As ucrNud
    Friend WithEvents UcrChkBorderSize As ucrCheck
    Friend WithEvents ucrNudMinorGridLineSize As ucrNud
    Friend WithEvents UcrPnlYAxisTitle As UcrPanel
    Friend WithEvents rdoNoYAxisTitle As RadioButton
    Friend WithEvents rdoSpecifyYAxisTitle As RadioButton
    Friend WithEvents grpAxes As GroupBox
    Friend WithEvents ucrInputXAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoTitleXAxisTitle As RadioButton
    Friend WithEvents rdoSpecifyXAxisTitle As RadioButton
    Friend WithEvents ucrPnlXAxisTitle As UcrPanel
    Friend WithEvents ucrNudXAxisTitleSize As ucrNud
    Friend WithEvents rdoAutoYAxis As RadioButton
    Friend WithEvents rdoAutoXAxis As RadioButton
    Friend WithEvents ucrChkAddTercilesLabel As ucrCheck
    Friend WithEvents ucrChkAddMedianLabel As ucrCheck
    Friend WithEvents ucrChkAddMeanLabel As ucrCheck
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCaptionSize As Label
    Friend WithEvents lblSubTitleSize As Label
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents lblYAxisTitleSize As Label
    Friend WithEvents lblXAxisTitleSize As Label
    Friend WithEvents ucrChkXAxisAngle As ucrCheck
    Friend WithEvents ucrChkTercilesLineLabelIncludeValue As ucrCheck
    Friend WithEvents ucrChkMedianLineLabelIncludeValue As ucrCheck
    Friend WithEvents ucrChkMeanLineLabelIncludeValue As ucrCheck
    Friend WithEvents ucrInputTercilesLineLabelTextLower As ucrInputTextBox
    Friend WithEvents lblTercilesLineLabelTextLower As Label
    Friend WithEvents lblTercilesLineType As Label
    Friend WithEvents ucrInputTercilesLabelType As ucrInputComboBox
    Friend WithEvents ucrInputMedianLineLabelText As ucrInputTextBox
    Friend WithEvents lblMedianLineLabelText As Label
    Friend WithEvents lblMedianLineType As Label
    Friend WithEvents ucrInputMedianLabelType As ucrInputComboBox
    Friend WithEvents ucrInputMeanLineLabelText As ucrInputTextBox
    Friend WithEvents lblMeanLineLabelText As Label
    Friend WithEvents lblMeanLineType As Label
    Friend WithEvents ucrInputMeanLabelType As ucrInputComboBox
    Friend WithEvents grpLinesFormat As GroupBox
    Friend WithEvents ucrNudHLineSize As ucrNud
    Friend WithEvents ucrChkHLineSize As ucrCheck
    Friend WithEvents ucrInputHLineType As ucrInputComboBox
    Friend WithEvents ucrInputHLineColour As ucrInputComboBox
    Friend WithEvents ucrChkHLineType As ucrCheck
    Friend WithEvents ucrChkHLineColour As ucrCheck
    Friend WithEvents ucrInputTercilesLineLabelTextUpper As ucrInputTextBox
    Friend WithEvents lblTercilesLineLabelTextUpper As Label
    Friend WithEvents tpYAxis As TabPage
    Friend WithEvents ucrPnlYAxisType As UcrPanel
    Friend WithEvents ucrInputStartMonth As ucrInputComboBox
    Friend WithEvents lblStartMonth As Label
    Friend WithEvents ucrChkSpecifyYAxisTickMarks As ucrCheck
    Friend WithEvents ucrNudDateBreakNumber As ucrNud
    Friend WithEvents ucrInputYInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputDateBreakTime As ucrInputComboBox
    Friend WithEvents lblYInStepsOf As Label
    Friend WithEvents ucrChkSpecifyDateBreaks As ucrCheck
    Friend WithEvents lblYTo As Label
    Friend WithEvents ucrInputDateDisplayFormat As ucrInputComboBox
    Friend WithEvents ucrInputYTo As ucrInputTextBox
    Friend WithEvents ucrNudYAxisAngle As ucrNud
    Friend WithEvents ucrNudYAxisLabelSize As ucrNud
    Friend WithEvents lblYFrom As Label
    Friend WithEvents ucrChkYAxisAngle As ucrCheck
    Friend WithEvents ucrInputYFrom As ucrInputTextBox
    Friend WithEvents ucrChkYAxisLabelSize As ucrCheck
    Friend WithEvents rdoYDate As RadioButton
    Friend WithEvents rdoYNumeric As RadioButton
    Friend WithEvents ucrInputYSpecifyUpperLimitNumeric As ucrInputTextBox
    Friend WithEvents ucrChkYSpecifyUpperLimit As ucrCheck
    Friend WithEvents ucrInputYSpecifyLowerLimitNumeric As ucrInputTextBox
    Friend WithEvents ucrChkYSpecifyLowerLimit As ucrCheck
    Friend WithEvents lblDateDisplayFormat As Label
    Friend WithEvents ucrNudLabelTransparency As ucrNud
    Friend WithEvents lblLabelTransparency As Label
    Friend WithEvents ucrChkIncludeMajorGridLines As ucrCheck
    Friend WithEvents ucrChkIncludeMinorGridLines As ucrCheck
    Friend WithEvents lblMajorGridLineSize As Label
    Friend WithEvents lblMajorGridLineLinetype As Label
    Friend WithEvents ucrNudMajorGridLineSize As ucrNud
    Friend WithEvents lblMinorGridLineSize As Label
    Friend WithEvents lblMinorGridLineLinetype As Label
    Friend WithEvents lblMinorGridLineColour As Label
    Friend WithEvents lblMajorGridLineColour As Label
    Friend WithEvents ucrInputYSpecifyUpperLimitDateMonth As ucrInputComboBox
    Friend WithEvents ucrInputYSpecifyLowerLimitDateMonth As ucrInputComboBox
    Friend WithEvents ucrNudUpperLimit As ucrNud
    Friend WithEvents ucrNudLowerLimit As ucrNud
    Friend WithEvents tpRug As TabPage
    Friend WithEvents ucrChkYaxis As ucrCheck
    Friend WithEvents lblYaxisOptions As Label
    Friend WithEvents ucrInputYaxisOptions As ucrInputComboBox
    Friend WithEvents ucrInputXaxisOptions As ucrInputComboBox
    Friend WithEvents lblXaxisOptions As Label
    Friend WithEvents ucrChkXaxis As ucrCheck
    Friend WithEvents ttPICSARainfallGraph As ToolTip
End Class
