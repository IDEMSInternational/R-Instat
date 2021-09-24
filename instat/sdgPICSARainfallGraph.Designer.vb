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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPICSARainfallGraph))
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
        resources.ApplyResources(Me.lblXTo, "lblXTo")
        Me.lblXTo.Name = "lblXTo"
        '
        'lblXFrom
        '
        resources.ApplyResources(Me.lblXFrom, "lblXFrom")
        Me.lblXFrom.Name = "lblXFrom"
        '
        'lblXInStepsOf
        '
        resources.ApplyResources(Me.lblXInStepsOf, "lblXInStepsOf")
        Me.lblXInStepsOf.Name = "lblXInStepsOf"
        '
        'tbPICSA
        '
        Me.tbPICSA.Controls.Add(Me.tpTitles)
        Me.tbPICSA.Controls.Add(Me.tpXAxis)
        Me.tbPICSA.Controls.Add(Me.tpYAxis)
        Me.tbPICSA.Controls.Add(Me.tpLines)
        Me.tbPICSA.Controls.Add(Me.tpPanel)
        Me.tbPICSA.Controls.Add(Me.tpRug)
        resources.ApplyResources(Me.tbPICSA, "tbPICSA")
        Me.tbPICSA.Name = "tbPICSA"
        Me.tbPICSA.SelectedIndex = 0
        '
        'tpTitles
        '
        Me.tpTitles.Controls.Add(Me.grpGraphTitles)
        Me.tpTitles.Controls.Add(Me.grpAxes)
        Me.tpTitles.Controls.Add(Me.grpyAxisTitle)
        resources.ApplyResources(Me.tpTitles, "tpTitles")
        Me.tpTitles.Name = "tpTitles"
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
        resources.ApplyResources(Me.grpGraphTitles, "grpGraphTitles")
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.TabStop = False
        '
        'lblCaptionSize
        '
        resources.ApplyResources(Me.lblCaptionSize, "lblCaptionSize")
        Me.lblCaptionSize.Name = "lblCaptionSize"
        '
        'lblSubTitleSize
        '
        resources.ApplyResources(Me.lblSubTitleSize, "lblSubTitleSize")
        Me.lblSubTitleSize.Name = "lblSubTitleSize"
        '
        'lblTitleSize
        '
        resources.ApplyResources(Me.lblTitleSize, "lblTitleSize")
        Me.lblTitleSize.Name = "lblTitleSize"
        '
        'lblCaption
        '
        resources.ApplyResources(Me.lblCaption, "lblCaption")
        Me.lblCaption.Name = "lblCaption"
        '
        'lblSubTitle
        '
        resources.ApplyResources(Me.lblSubTitle, "lblSubTitle")
        Me.lblSubTitle.Name = "lblSubTitle"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'ucrNudCaptionSize
        '
        Me.ucrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudCaptionSize, "ucrNudCaptionSize")
        Me.ucrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Name = "ucrNudCaptionSize"
        Me.ucrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSubTitleSize
        '
        Me.ucrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudSubTitleSize, "ucrNudSubTitleSize")
        Me.ucrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Name = "ucrNudSubTitleSize"
        Me.ucrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudTitleSize, "ucrNudTitleSize")
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.IsMultiline = True
        Me.ucrInputGraphcCaption.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphcCaption, "ucrInputGraphcCaption")
        Me.ucrInputGraphcCaption.Name = "ucrInputGraphcCaption"
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphTitle, "ucrInputGraphTitle")
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputGraphSubTitle, "ucrInputGraphSubTitle")
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
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
        resources.ApplyResources(Me.grpAxes, "grpAxes")
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.TabStop = False
        '
        'lblXAxisTitleSize
        '
        resources.ApplyResources(Me.lblXAxisTitleSize, "lblXAxisTitleSize")
        Me.lblXAxisTitleSize.Name = "lblXAxisTitleSize"
        '
        'rdoAutoXAxis
        '
        resources.ApplyResources(Me.rdoAutoXAxis, "rdoAutoXAxis")
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXAxisTitle, "ucrInputXAxisTitle")
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        '
        'rdoNoTitleXAxisTitle
        '
        resources.ApplyResources(Me.rdoNoTitleXAxisTitle, "rdoNoTitleXAxisTitle")
        Me.rdoNoTitleXAxisTitle.Name = "rdoNoTitleXAxisTitle"
        Me.rdoNoTitleXAxisTitle.TabStop = True
        Me.rdoNoTitleXAxisTitle.UseVisualStyleBackColor = True
        '
        'rdoSpecifyXAxisTitle
        '
        resources.ApplyResources(Me.rdoSpecifyXAxisTitle, "rdoSpecifyXAxisTitle")
        Me.rdoSpecifyXAxisTitle.Name = "rdoSpecifyXAxisTitle"
        Me.rdoSpecifyXAxisTitle.TabStop = True
        Me.rdoSpecifyXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudXAxisTitleSize
        '
        Me.ucrNudXAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXAxisTitleSize, "ucrNudXAxisTitleSize")
        Me.ucrNudXAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisTitleSize.Name = "ucrNudXAxisTitleSize"
        Me.ucrNudXAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlXAxisTitle
        '
        resources.ApplyResources(Me.ucrPnlXAxisTitle, "ucrPnlXAxisTitle")
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
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
        resources.ApplyResources(Me.grpyAxisTitle, "grpyAxisTitle")
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.TabStop = False
        '
        'rdoAutoYAxis
        '
        resources.ApplyResources(Me.rdoAutoYAxis, "rdoAutoYAxis")
        Me.rdoAutoYAxis.Name = "rdoAutoYAxis"
        Me.rdoAutoYAxis.TabStop = True
        Me.rdoAutoYAxis.UseVisualStyleBackColor = True
        '
        'ucrInputYAxisTitle
        '
        Me.ucrInputYAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputYAxisTitle.IsMultiline = False
        Me.ucrInputYAxisTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYAxisTitle, "ucrInputYAxisTitle")
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        '
        'rdoNoYAxisTitle
        '
        resources.ApplyResources(Me.rdoNoYAxisTitle, "rdoNoYAxisTitle")
        Me.rdoNoYAxisTitle.Name = "rdoNoYAxisTitle"
        Me.rdoNoYAxisTitle.TabStop = True
        Me.rdoNoYAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudYAxisTitleSize
        '
        Me.ucrNudYAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisTitleSize, "ucrNudYAxisTitleSize")
        Me.ucrNudYAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Name = "ucrNudYAxisTitleSize"
        Me.ucrNudYAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecifyYAxisTitle
        '
        resources.ApplyResources(Me.rdoSpecifyYAxisTitle, "rdoSpecifyYAxisTitle")
        Me.rdoSpecifyYAxisTitle.Name = "rdoSpecifyYAxisTitle"
        Me.rdoSpecifyYAxisTitle.TabStop = True
        Me.rdoSpecifyYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrPnlYAxisTitle
        '
        resources.ApplyResources(Me.UcrPnlYAxisTitle, "UcrPnlYAxisTitle")
        Me.UcrPnlYAxisTitle.Name = "UcrPnlYAxisTitle"
        '
        'lblYAxisTitleSize
        '
        resources.ApplyResources(Me.lblYAxisTitleSize, "lblYAxisTitleSize")
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
        '
        'tpXAxis
        '
        Me.tpXAxis.Controls.Add(Me.grpXAxisLabels)
        resources.ApplyResources(Me.tpXAxis, "tpXAxis")
        Me.tpXAxis.Name = "tpXAxis"
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
        resources.ApplyResources(Me.grpXAxisLabels, "grpXAxisLabels")
        Me.grpXAxisLabels.Name = "grpXAxisLabels"
        Me.grpXAxisLabels.TabStop = False
        '
        'ucrChkXAxisLabelSize
        '
        Me.ucrChkXAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisLabelSize, "ucrChkXAxisLabelSize")
        Me.ucrChkXAxisLabelSize.Name = "ucrChkXAxisLabelSize"
        '
        'ucrChkXAxisAngle
        '
        Me.ucrChkXAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisAngle, "ucrChkXAxisAngle")
        Me.ucrChkXAxisAngle.Name = "ucrChkXAxisAngle"
        '
        'ucrChkSpecifyXAxisTickMarks
        '
        Me.ucrChkSpecifyXAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyXAxisTickMarks, "ucrChkSpecifyXAxisTickMarks")
        Me.ucrChkSpecifyXAxisTickMarks.Name = "ucrChkSpecifyXAxisTickMarks"
        '
        'ucrInputXFrom
        '
        Me.ucrInputXFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputXFrom.IsMultiline = False
        Me.ucrInputXFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXFrom, "ucrInputXFrom")
        Me.ucrInputXFrom.Name = "ucrInputXFrom"
        '
        'ucrInputXInStepsOf
        '
        Me.ucrInputXInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputXInStepsOf.IsMultiline = False
        Me.ucrInputXInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXInStepsOf, "ucrInputXInStepsOf")
        Me.ucrInputXInStepsOf.Name = "ucrInputXInStepsOf"
        '
        'ucrNudXaxisLabelSize
        '
        Me.ucrNudXaxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXaxisLabelSize, "ucrNudXaxisLabelSize")
        Me.ucrNudXaxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisLabelSize.Name = "ucrNudXaxisLabelSize"
        Me.ucrNudXaxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputXTo
        '
        Me.ucrInputXTo.AddQuotesIfUnrecognised = True
        Me.ucrInputXTo.IsMultiline = False
        Me.ucrInputXTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXTo, "ucrInputXTo")
        Me.ucrInputXTo.Name = "ucrInputXTo"
        '
        'ucrNudXAxisAngle
        '
        Me.ucrNudXAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXAxisAngle, "ucrNudXAxisAngle")
        Me.ucrNudXAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Name = "ucrNudXAxisAngle"
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
        resources.ApplyResources(Me.tpYAxis, "tpYAxis")
        Me.tpYAxis.Name = "tpYAxis"
        Me.tpYAxis.UseVisualStyleBackColor = True
        '
        'ucrNudUpperLimit
        '
        Me.ucrNudUpperLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudUpperLimit, "ucrNudUpperLimit")
        Me.ucrNudUpperLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudUpperLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudUpperLimit.Name = "ucrNudUpperLimit"
        Me.ucrNudUpperLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudLowerLimit
        '
        Me.ucrNudLowerLimit.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerLimit.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLowerLimit, "ucrNudLowerLimit")
        Me.ucrNudLowerLimit.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLowerLimit.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLowerLimit.Name = "ucrNudLowerLimit"
        Me.ucrNudLowerLimit.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblDateDisplayFormat
        '
        resources.ApplyResources(Me.lblDateDisplayFormat, "lblDateDisplayFormat")
        Me.lblDateDisplayFormat.Name = "lblDateDisplayFormat"
        '
        'rdoYDate
        '
        resources.ApplyResources(Me.rdoYDate, "rdoYDate")
        Me.rdoYDate.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYDate.FlatAppearance.BorderSize = 2
        Me.rdoYDate.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYDate.Name = "rdoYDate"
        Me.rdoYDate.TabStop = True
        Me.rdoYDate.UseVisualStyleBackColor = True
        '
        'rdoYNumeric
        '
        resources.ApplyResources(Me.rdoYNumeric, "rdoYNumeric")
        Me.rdoYNumeric.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYNumeric.FlatAppearance.BorderSize = 2
        Me.rdoYNumeric.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoYNumeric.Name = "rdoYNumeric"
        Me.rdoYNumeric.TabStop = True
        Me.rdoYNumeric.UseVisualStyleBackColor = True
        '
        'lblStartMonth
        '
        resources.ApplyResources(Me.lblStartMonth, "lblStartMonth")
        Me.lblStartMonth.Name = "lblStartMonth"
        '
        'lblYInStepsOf
        '
        resources.ApplyResources(Me.lblYInStepsOf, "lblYInStepsOf")
        Me.lblYInStepsOf.Name = "lblYInStepsOf"
        '
        'lblYTo
        '
        resources.ApplyResources(Me.lblYTo, "lblYTo")
        Me.lblYTo.Name = "lblYTo"
        '
        'lblYFrom
        '
        resources.ApplyResources(Me.lblYFrom, "lblYFrom")
        Me.lblYFrom.Name = "lblYFrom"
        '
        'ucrInputYSpecifyUpperLimitDateMonth
        '
        Me.ucrInputYSpecifyUpperLimitDateMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyUpperLimitDateMonth.GetSetSelectedIndex = -1
        Me.ucrInputYSpecifyUpperLimitDateMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYSpecifyUpperLimitDateMonth, "ucrInputYSpecifyUpperLimitDateMonth")
        Me.ucrInputYSpecifyUpperLimitDateMonth.Name = "ucrInputYSpecifyUpperLimitDateMonth"
        '
        'ucrInputYSpecifyUpperLimitNumeric
        '
        Me.ucrInputYSpecifyUpperLimitNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyUpperLimitNumeric.IsMultiline = False
        Me.ucrInputYSpecifyUpperLimitNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYSpecifyUpperLimitNumeric, "ucrInputYSpecifyUpperLimitNumeric")
        Me.ucrInputYSpecifyUpperLimitNumeric.Name = "ucrInputYSpecifyUpperLimitNumeric"
        '
        'ucrInputYSpecifyLowerLimitDateMonth
        '
        Me.ucrInputYSpecifyLowerLimitDateMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyLowerLimitDateMonth.GetSetSelectedIndex = -1
        Me.ucrInputYSpecifyLowerLimitDateMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYSpecifyLowerLimitDateMonth, "ucrInputYSpecifyLowerLimitDateMonth")
        Me.ucrInputYSpecifyLowerLimitDateMonth.Name = "ucrInputYSpecifyLowerLimitDateMonth"
        '
        'ucrChkYSpecifyUpperLimit
        '
        Me.ucrChkYSpecifyUpperLimit.Checked = False
        resources.ApplyResources(Me.ucrChkYSpecifyUpperLimit, "ucrChkYSpecifyUpperLimit")
        Me.ucrChkYSpecifyUpperLimit.Name = "ucrChkYSpecifyUpperLimit"
        '
        'ucrInputYSpecifyLowerLimitNumeric
        '
        Me.ucrInputYSpecifyLowerLimitNumeric.AddQuotesIfUnrecognised = True
        Me.ucrInputYSpecifyLowerLimitNumeric.IsMultiline = False
        Me.ucrInputYSpecifyLowerLimitNumeric.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYSpecifyLowerLimitNumeric, "ucrInputYSpecifyLowerLimitNumeric")
        Me.ucrInputYSpecifyLowerLimitNumeric.Name = "ucrInputYSpecifyLowerLimitNumeric"
        '
        'ucrChkYSpecifyLowerLimit
        '
        Me.ucrChkYSpecifyLowerLimit.Checked = False
        resources.ApplyResources(Me.ucrChkYSpecifyLowerLimit, "ucrChkYSpecifyLowerLimit")
        Me.ucrChkYSpecifyLowerLimit.Name = "ucrChkYSpecifyLowerLimit"
        '
        'ucrPnlYAxisType
        '
        resources.ApplyResources(Me.ucrPnlYAxisType, "ucrPnlYAxisType")
        Me.ucrPnlYAxisType.Name = "ucrPnlYAxisType"
        '
        'ucrInputStartMonth
        '
        Me.ucrInputStartMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputStartMonth.GetSetSelectedIndex = -1
        Me.ucrInputStartMonth.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStartMonth, "ucrInputStartMonth")
        Me.ucrInputStartMonth.Name = "ucrInputStartMonth"
        '
        'ucrChkSpecifyYAxisTickMarks
        '
        Me.ucrChkSpecifyYAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyYAxisTickMarks, "ucrChkSpecifyYAxisTickMarks")
        Me.ucrChkSpecifyYAxisTickMarks.Name = "ucrChkSpecifyYAxisTickMarks"
        '
        'ucrNudDateBreakNumber
        '
        Me.ucrNudDateBreakNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudDateBreakNumber, "ucrNudDateBreakNumber")
        Me.ucrNudDateBreakNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Name = "ucrNudDateBreakNumber"
        Me.ucrNudDateBreakNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputYInStepsOf
        '
        Me.ucrInputYInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputYInStepsOf.IsMultiline = False
        Me.ucrInputYInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYInStepsOf, "ucrInputYInStepsOf")
        Me.ucrInputYInStepsOf.Name = "ucrInputYInStepsOf"
        '
        'ucrInputDateBreakTime
        '
        Me.ucrInputDateBreakTime.AddQuotesIfUnrecognised = True
        Me.ucrInputDateBreakTime.GetSetSelectedIndex = -1
        Me.ucrInputDateBreakTime.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDateBreakTime, "ucrInputDateBreakTime")
        Me.ucrInputDateBreakTime.Name = "ucrInputDateBreakTime"
        '
        'ucrChkSpecifyDateBreaks
        '
        Me.ucrChkSpecifyDateBreaks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyDateBreaks, "ucrChkSpecifyDateBreaks")
        Me.ucrChkSpecifyDateBreaks.Name = "ucrChkSpecifyDateBreaks"
        '
        'ucrInputDateDisplayFormat
        '
        Me.ucrInputDateDisplayFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateDisplayFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateDisplayFormat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDateDisplayFormat, "ucrInputDateDisplayFormat")
        Me.ucrInputDateDisplayFormat.Name = "ucrInputDateDisplayFormat"
        '
        'ucrInputYTo
        '
        Me.ucrInputYTo.AddQuotesIfUnrecognised = True
        Me.ucrInputYTo.IsMultiline = False
        Me.ucrInputYTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYTo, "ucrInputYTo")
        Me.ucrInputYTo.Name = "ucrInputYTo"
        '
        'ucrNudYAxisAngle
        '
        Me.ucrNudYAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisAngle, "ucrNudYAxisAngle")
        Me.ucrNudYAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Name = "ucrNudYAxisAngle"
        Me.ucrNudYAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYAxisLabelSize
        '
        Me.ucrNudYAxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudYAxisLabelSize, "ucrNudYAxisLabelSize")
        Me.ucrNudYAxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Name = "ucrNudYAxisLabelSize"
        Me.ucrNudYAxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisAngle, "ucrChkYAxisAngle")
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
        '
        'ucrInputYFrom
        '
        Me.ucrInputYFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputYFrom.IsMultiline = False
        Me.ucrInputYFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYFrom, "ucrInputYFrom")
        Me.ucrInputYFrom.Name = "ucrInputYFrom"
        '
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisLabelSize, "ucrChkYAxisLabelSize")
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
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
        resources.ApplyResources(Me.tpLines, "tpLines")
        Me.tpLines.Name = "tpLines"
        Me.tpLines.UseVisualStyleBackColor = True
        '
        'ucrInputTercilesLineLabelTextUpper
        '
        Me.ucrInputTercilesLineLabelTextUpper.AddQuotesIfUnrecognised = True
        Me.ucrInputTercilesLineLabelTextUpper.IsMultiline = False
        Me.ucrInputTercilesLineLabelTextUpper.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTercilesLineLabelTextUpper, "ucrInputTercilesLineLabelTextUpper")
        Me.ucrInputTercilesLineLabelTextUpper.Name = "ucrInputTercilesLineLabelTextUpper"
        '
        'lblTercilesLineLabelTextUpper
        '
        resources.ApplyResources(Me.lblTercilesLineLabelTextUpper, "lblTercilesLineLabelTextUpper")
        Me.lblTercilesLineLabelTextUpper.Name = "lblTercilesLineLabelTextUpper"
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
        resources.ApplyResources(Me.grpLinesFormat, "grpLinesFormat")
        Me.grpLinesFormat.Name = "grpLinesFormat"
        Me.grpLinesFormat.TabStop = False
        '
        'ucrNudLabelTransparency
        '
        Me.ucrNudLabelTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLabelTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudLabelTransparency, "ucrNudLabelTransparency")
        Me.ucrNudLabelTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudLabelTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudLabelTransparency.Name = "ucrNudLabelTransparency"
        Me.ucrNudLabelTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblLabelTransparency
        '
        resources.ApplyResources(Me.lblLabelTransparency, "lblLabelTransparency")
        Me.lblLabelTransparency.Name = "lblLabelTransparency"
        '
        'ucrNudHLineSize
        '
        Me.ucrNudHLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudHLineSize, "ucrNudHLineSize")
        Me.ucrNudHLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudHLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudHLineSize.Name = "ucrNudHLineSize"
        Me.ucrNudHLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkHLineSize
        '
        Me.ucrChkHLineSize.Checked = False
        resources.ApplyResources(Me.ucrChkHLineSize, "ucrChkHLineSize")
        Me.ucrChkHLineSize.Name = "ucrChkHLineSize"
        '
        'ucrInputHLineType
        '
        Me.ucrInputHLineType.AddQuotesIfUnrecognised = True
        Me.ucrInputHLineType.GetSetSelectedIndex = -1
        Me.ucrInputHLineType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHLineType, "ucrInputHLineType")
        Me.ucrInputHLineType.Name = "ucrInputHLineType"
        '
        'ucrInputHLineColour
        '
        Me.ucrInputHLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputHLineColour.GetSetSelectedIndex = -1
        Me.ucrInputHLineColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputHLineColour, "ucrInputHLineColour")
        Me.ucrInputHLineColour.Name = "ucrInputHLineColour"
        '
        'ucrChkHLineType
        '
        Me.ucrChkHLineType.Checked = False
        resources.ApplyResources(Me.ucrChkHLineType, "ucrChkHLineType")
        Me.ucrChkHLineType.Name = "ucrChkHLineType"
        '
        'ucrChkHLineColour
        '
        Me.ucrChkHLineColour.Checked = False
        resources.ApplyResources(Me.ucrChkHLineColour, "ucrChkHLineColour")
        Me.ucrChkHLineColour.Name = "ucrChkHLineColour"
        '
        'lblTercilesLineLabelTextLower
        '
        resources.ApplyResources(Me.lblTercilesLineLabelTextLower, "lblTercilesLineLabelTextLower")
        Me.lblTercilesLineLabelTextLower.Name = "lblTercilesLineLabelTextLower"
        '
        'lblTercilesLineType
        '
        resources.ApplyResources(Me.lblTercilesLineType, "lblTercilesLineType")
        Me.lblTercilesLineType.Name = "lblTercilesLineType"
        '
        'lblMedianLineLabelText
        '
        resources.ApplyResources(Me.lblMedianLineLabelText, "lblMedianLineLabelText")
        Me.lblMedianLineLabelText.Name = "lblMedianLineLabelText"
        '
        'lblMedianLineType
        '
        resources.ApplyResources(Me.lblMedianLineType, "lblMedianLineType")
        Me.lblMedianLineType.Name = "lblMedianLineType"
        '
        'lblMeanLineLabelText
        '
        resources.ApplyResources(Me.lblMeanLineLabelText, "lblMeanLineLabelText")
        Me.lblMeanLineLabelText.Name = "lblMeanLineLabelText"
        '
        'lblMeanLineType
        '
        resources.ApplyResources(Me.lblMeanLineType, "lblMeanLineType")
        Me.lblMeanLineType.Name = "lblMeanLineType"
        '
        'ucrChkTercilesLineLabelIncludeValue
        '
        Me.ucrChkTercilesLineLabelIncludeValue.Checked = False
        resources.ApplyResources(Me.ucrChkTercilesLineLabelIncludeValue, "ucrChkTercilesLineLabelIncludeValue")
        Me.ucrChkTercilesLineLabelIncludeValue.Name = "ucrChkTercilesLineLabelIncludeValue"
        '
        'ucrChkMedianLineLabelIncludeValue
        '
        Me.ucrChkMedianLineLabelIncludeValue.Checked = False
        resources.ApplyResources(Me.ucrChkMedianLineLabelIncludeValue, "ucrChkMedianLineLabelIncludeValue")
        Me.ucrChkMedianLineLabelIncludeValue.Name = "ucrChkMedianLineLabelIncludeValue"
        '
        'ucrChkMeanLineLabelIncludeValue
        '
        Me.ucrChkMeanLineLabelIncludeValue.Checked = False
        resources.ApplyResources(Me.ucrChkMeanLineLabelIncludeValue, "ucrChkMeanLineLabelIncludeValue")
        Me.ucrChkMeanLineLabelIncludeValue.Name = "ucrChkMeanLineLabelIncludeValue"
        '
        'ucrInputTercilesLineLabelTextLower
        '
        Me.ucrInputTercilesLineLabelTextLower.AddQuotesIfUnrecognised = True
        Me.ucrInputTercilesLineLabelTextLower.IsMultiline = False
        Me.ucrInputTercilesLineLabelTextLower.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTercilesLineLabelTextLower, "ucrInputTercilesLineLabelTextLower")
        Me.ucrInputTercilesLineLabelTextLower.Name = "ucrInputTercilesLineLabelTextLower"
        '
        'ucrInputTercilesLabelType
        '
        Me.ucrInputTercilesLabelType.AddQuotesIfUnrecognised = True
        Me.ucrInputTercilesLabelType.GetSetSelectedIndex = -1
        Me.ucrInputTercilesLabelType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTercilesLabelType, "ucrInputTercilesLabelType")
        Me.ucrInputTercilesLabelType.Name = "ucrInputTercilesLabelType"
        '
        'ucrInputMedianLineLabelText
        '
        Me.ucrInputMedianLineLabelText.AddQuotesIfUnrecognised = True
        Me.ucrInputMedianLineLabelText.IsMultiline = False
        Me.ucrInputMedianLineLabelText.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMedianLineLabelText, "ucrInputMedianLineLabelText")
        Me.ucrInputMedianLineLabelText.Name = "ucrInputMedianLineLabelText"
        '
        'ucrInputMedianLabelType
        '
        Me.ucrInputMedianLabelType.AddQuotesIfUnrecognised = True
        Me.ucrInputMedianLabelType.GetSetSelectedIndex = -1
        Me.ucrInputMedianLabelType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMedianLabelType, "ucrInputMedianLabelType")
        Me.ucrInputMedianLabelType.Name = "ucrInputMedianLabelType"
        '
        'ucrInputMeanLineLabelText
        '
        Me.ucrInputMeanLineLabelText.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanLineLabelText.IsMultiline = False
        Me.ucrInputMeanLineLabelText.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMeanLineLabelText, "ucrInputMeanLineLabelText")
        Me.ucrInputMeanLineLabelText.Name = "ucrInputMeanLineLabelText"
        '
        'ucrChkAddTercilesLabel
        '
        Me.ucrChkAddTercilesLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddTercilesLabel, "ucrChkAddTercilesLabel")
        Me.ucrChkAddTercilesLabel.Name = "ucrChkAddTercilesLabel"
        '
        'ucrChkAddMedianLabel
        '
        Me.ucrChkAddMedianLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddMedianLabel, "ucrChkAddMedianLabel")
        Me.ucrChkAddMedianLabel.Name = "ucrChkAddMedianLabel"
        '
        'ucrInputMeanLabelType
        '
        Me.ucrInputMeanLabelType.AddQuotesIfUnrecognised = True
        Me.ucrInputMeanLabelType.GetSetSelectedIndex = -1
        Me.ucrInputMeanLabelType.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMeanLabelType, "ucrInputMeanLabelType")
        Me.ucrInputMeanLabelType.Name = "ucrInputMeanLabelType"
        '
        'ucrChkAddMean
        '
        Me.ucrChkAddMean.Checked = False
        resources.ApplyResources(Me.ucrChkAddMean, "ucrChkAddMean")
        Me.ucrChkAddMean.Name = "ucrChkAddMean"
        '
        'ucrChkAddMeanLabel
        '
        Me.ucrChkAddMeanLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddMeanLabel, "ucrChkAddMeanLabel")
        Me.ucrChkAddMeanLabel.Name = "ucrChkAddMeanLabel"
        '
        'ucrChkAddMedian
        '
        Me.ucrChkAddMedian.Checked = False
        resources.ApplyResources(Me.ucrChkAddMedian, "ucrChkAddMedian")
        Me.ucrChkAddMedian.Name = "ucrChkAddMedian"
        '
        'ucrChkAddTerciles
        '
        Me.ucrChkAddTerciles.Checked = False
        resources.ApplyResources(Me.ucrChkAddTerciles, "ucrChkAddTerciles")
        Me.ucrChkAddTerciles.Name = "ucrChkAddTerciles"
        '
        'tpPanel
        '
        Me.tpPanel.Controls.Add(Me.grpMinorGridLine)
        Me.tpPanel.Controls.Add(Me.grpPnlBorder)
        Me.tpPanel.Controls.Add(Me.grpMajorGridLines)
        Me.tpPanel.Controls.Add(Me.grpPnlBackground)
        resources.ApplyResources(Me.tpPanel, "tpPanel")
        Me.tpPanel.Name = "tpPanel"
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
        resources.ApplyResources(Me.grpMinorGridLine, "grpMinorGridLine")
        Me.grpMinorGridLine.Name = "grpMinorGridLine"
        Me.grpMinorGridLine.TabStop = False
        '
        'lblMinorGridLineSize
        '
        resources.ApplyResources(Me.lblMinorGridLineSize, "lblMinorGridLineSize")
        Me.lblMinorGridLineSize.Name = "lblMinorGridLineSize"
        '
        'ucrChkIncludeMinorGridLines
        '
        Me.ucrChkIncludeMinorGridLines.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeMinorGridLines, "ucrChkIncludeMinorGridLines")
        Me.ucrChkIncludeMinorGridLines.Name = "ucrChkIncludeMinorGridLines"
        '
        'lblMinorGridLineLinetype
        '
        resources.ApplyResources(Me.lblMinorGridLineLinetype, "lblMinorGridLineLinetype")
        Me.lblMinorGridLineLinetype.Name = "lblMinorGridLineLinetype"
        '
        'ucrNudMinorGridLineSize
        '
        Me.ucrNudMinorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinorGridLineSize, "ucrNudMinorGridLineSize")
        Me.ucrNudMinorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinorGridLineSize.Name = "ucrNudMinorGridLineSize"
        Me.ucrNudMinorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinorGridLineColour
        '
        resources.ApplyResources(Me.lblMinorGridLineColour, "lblMinorGridLineColour")
        Me.lblMinorGridLineColour.Name = "lblMinorGridLineColour"
        '
        'ucrInputMinorGridLineLinetype
        '
        Me.ucrInputMinorGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorGridLineLinetype.GetSetSelectedIndex = -1
        Me.ucrInputMinorGridLineLinetype.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinorGridLineLinetype, "ucrInputMinorGridLineLinetype")
        Me.ucrInputMinorGridLineLinetype.Name = "ucrInputMinorGridLineLinetype"
        '
        'ucrInputMinorGridLineColour
        '
        Me.ucrInputMinorGridLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputMinorGridLineColour.GetSetSelectedIndex = -1
        Me.ucrInputMinorGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMinorGridLineColour, "ucrInputMinorGridLineColour")
        Me.ucrInputMinorGridLineColour.Name = "ucrInputMinorGridLineColour"
        '
        'grpPnlBorder
        '
        Me.grpPnlBorder.Controls.Add(Me.ucrNudBorderSize)
        Me.grpPnlBorder.Controls.Add(Me.UcrChkBorderSize)
        Me.grpPnlBorder.Controls.Add(Me.ucrInputBorderLinetype)
        Me.grpPnlBorder.Controls.Add(Me.ucrInputBorderColour)
        Me.grpPnlBorder.Controls.Add(Me.ucrChkBorderLineType)
        Me.grpPnlBorder.Controls.Add(Me.ucrChkBorderColour)
        resources.ApplyResources(Me.grpPnlBorder, "grpPnlBorder")
        Me.grpPnlBorder.Name = "grpPnlBorder"
        Me.grpPnlBorder.TabStop = False
        '
        'ucrNudBorderSize
        '
        Me.ucrNudBorderSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBorderSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudBorderSize, "ucrNudBorderSize")
        Me.ucrNudBorderSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBorderSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBorderSize.Name = "ucrNudBorderSize"
        Me.ucrNudBorderSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkBorderSize
        '
        Me.UcrChkBorderSize.Checked = False
        resources.ApplyResources(Me.UcrChkBorderSize, "UcrChkBorderSize")
        Me.UcrChkBorderSize.Name = "UcrChkBorderSize"
        '
        'ucrInputBorderLinetype
        '
        Me.ucrInputBorderLinetype.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderLinetype.GetSetSelectedIndex = -1
        Me.ucrInputBorderLinetype.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBorderLinetype, "ucrInputBorderLinetype")
        Me.ucrInputBorderLinetype.Name = "ucrInputBorderLinetype"
        '
        'ucrInputBorderColour
        '
        Me.ucrInputBorderColour.AddQuotesIfUnrecognised = True
        Me.ucrInputBorderColour.GetSetSelectedIndex = -1
        Me.ucrInputBorderColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBorderColour, "ucrInputBorderColour")
        Me.ucrInputBorderColour.Name = "ucrInputBorderColour"
        '
        'ucrChkBorderLineType
        '
        Me.ucrChkBorderLineType.Checked = False
        resources.ApplyResources(Me.ucrChkBorderLineType, "ucrChkBorderLineType")
        Me.ucrChkBorderLineType.Name = "ucrChkBorderLineType"
        '
        'ucrChkBorderColour
        '
        Me.ucrChkBorderColour.Checked = False
        resources.ApplyResources(Me.ucrChkBorderColour, "ucrChkBorderColour")
        Me.ucrChkBorderColour.Name = "ucrChkBorderColour"
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
        resources.ApplyResources(Me.grpMajorGridLines, "grpMajorGridLines")
        Me.grpMajorGridLines.Name = "grpMajorGridLines"
        Me.grpMajorGridLines.TabStop = False
        '
        'lblMajorGridLineSize
        '
        resources.ApplyResources(Me.lblMajorGridLineSize, "lblMajorGridLineSize")
        Me.lblMajorGridLineSize.Name = "lblMajorGridLineSize"
        '
        'lblMajorGridLineLinetype
        '
        resources.ApplyResources(Me.lblMajorGridLineLinetype, "lblMajorGridLineLinetype")
        Me.lblMajorGridLineLinetype.Name = "lblMajorGridLineLinetype"
        '
        'lblMajorGridLineColour
        '
        resources.ApplyResources(Me.lblMajorGridLineColour, "lblMajorGridLineColour")
        Me.lblMajorGridLineColour.Name = "lblMajorGridLineColour"
        '
        'ucrChkIncludeMajorGridLines
        '
        Me.ucrChkIncludeMajorGridLines.Checked = False
        resources.ApplyResources(Me.ucrChkIncludeMajorGridLines, "ucrChkIncludeMajorGridLines")
        Me.ucrChkIncludeMajorGridLines.Name = "ucrChkIncludeMajorGridLines"
        '
        'ucrNudMajorGridLineSize
        '
        Me.ucrNudMajorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMajorGridLineSize, "ucrNudMajorGridLineSize")
        Me.ucrNudMajorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMajorGridLineSize.Name = "ucrNudMajorGridLineSize"
        Me.ucrNudMajorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputMajorGridLineLinetype
        '
        Me.ucrInputMajorGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorGridLineLinetype.GetSetSelectedIndex = -1
        Me.ucrInputMajorGridLineLinetype.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorGridLineLinetype, "ucrInputMajorGridLineLinetype")
        Me.ucrInputMajorGridLineLinetype.Name = "ucrInputMajorGridLineLinetype"
        '
        'ucrInputMajorGridLineColour
        '
        Me.ucrInputMajorGridLineColour.AddQuotesIfUnrecognised = True
        Me.ucrInputMajorGridLineColour.GetSetSelectedIndex = -1
        Me.ucrInputMajorGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputMajorGridLineColour, "ucrInputMajorGridLineColour")
        Me.ucrInputMajorGridLineColour.Name = "ucrInputMajorGridLineColour"
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
        resources.ApplyResources(Me.grpPnlBackground, "grpPnlBackground")
        Me.grpPnlBackground.Name = "grpPnlBackground"
        Me.grpPnlBackground.TabStop = False
        '
        'ucrNudPnlBackgroundSize
        '
        Me.ucrNudPnlBackgroundSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudPnlBackgroundSize, "ucrNudPnlBackgroundSize")
        Me.ucrNudPnlBackgroundSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPnlBackgroundSize.Name = "ucrNudPnlBackgroundSize"
        Me.ucrNudPnlBackgroundSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrInputPnlBackgroundFill
        '
        Me.UcrInputPnlBackgroundFill.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundFill.GetSetSelectedIndex = -1
        Me.UcrInputPnlBackgroundFill.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundFill, "UcrInputPnlBackgroundFill")
        Me.UcrInputPnlBackgroundFill.Name = "UcrInputPnlBackgroundFill"
        '
        'UcrInputPnlBackgroundLinetype
        '
        Me.UcrInputPnlBackgroundLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundLinetype.GetSetSelectedIndex = -1
        Me.UcrInputPnlBackgroundLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundLinetype, "UcrInputPnlBackgroundLinetype")
        Me.UcrInputPnlBackgroundLinetype.Name = "UcrInputPnlBackgroundLinetype"
        '
        'UcrInputPnlBackgroundColour
        '
        Me.UcrInputPnlBackgroundColour.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundColour.GetSetSelectedIndex = -1
        Me.UcrInputPnlBackgroundColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundColour, "UcrInputPnlBackgroundColour")
        Me.UcrInputPnlBackgroundColour.Name = "UcrInputPnlBackgroundColour"
        '
        'UcrChkPnlBackgroundSize
        '
        Me.UcrChkPnlBackgroundSize.Checked = False
        resources.ApplyResources(Me.UcrChkPnlBackgroundSize, "UcrChkPnlBackgroundSize")
        Me.UcrChkPnlBackgroundSize.Name = "UcrChkPnlBackgroundSize"
        '
        'UcrChkPnlBackgroundLineType
        '
        Me.UcrChkPnlBackgroundLineType.Checked = False
        resources.ApplyResources(Me.UcrChkPnlBackgroundLineType, "UcrChkPnlBackgroundLineType")
        Me.UcrChkPnlBackgroundLineType.Name = "UcrChkPnlBackgroundLineType"
        '
        'UcrChkPnlBackgroundFill
        '
        Me.UcrChkPnlBackgroundFill.Checked = False
        resources.ApplyResources(Me.UcrChkPnlBackgroundFill, "UcrChkPnlBackgroundFill")
        Me.UcrChkPnlBackgroundFill.Name = "UcrChkPnlBackgroundFill"
        '
        'ucrChkPnlBackgroundColour
        '
        Me.ucrChkPnlBackgroundColour.Checked = False
        resources.ApplyResources(Me.ucrChkPnlBackgroundColour, "ucrChkPnlBackgroundColour")
        Me.ucrChkPnlBackgroundColour.Name = "ucrChkPnlBackgroundColour"
        '
        'tpRug
        '
        Me.tpRug.Controls.Add(Me.ucrInputXaxisOptions)
        Me.tpRug.Controls.Add(Me.lblXaxisOptions)
        Me.tpRug.Controls.Add(Me.lblYaxisOptions)
        Me.tpRug.Controls.Add(Me.ucrChkXaxis)
        Me.tpRug.Controls.Add(Me.ucrInputYaxisOptions)
        Me.tpRug.Controls.Add(Me.ucrChkYaxis)
        resources.ApplyResources(Me.tpRug, "tpRug")
        Me.tpRug.Name = "tpRug"
        Me.tpRug.UseVisualStyleBackColor = True
        '
        'ucrInputXaxisOptions
        '
        Me.ucrInputXaxisOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputXaxisOptions.GetSetSelectedIndex = -1
        Me.ucrInputXaxisOptions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXaxisOptions, "ucrInputXaxisOptions")
        Me.ucrInputXaxisOptions.Name = "ucrInputXaxisOptions"
        '
        'lblXaxisOptions
        '
        resources.ApplyResources(Me.lblXaxisOptions, "lblXaxisOptions")
        Me.lblXaxisOptions.Name = "lblXaxisOptions"
        '
        'lblYaxisOptions
        '
        resources.ApplyResources(Me.lblYaxisOptions, "lblYaxisOptions")
        Me.lblYaxisOptions.Name = "lblYaxisOptions"
        '
        'ucrChkXaxis
        '
        Me.ucrChkXaxis.Checked = False
        resources.ApplyResources(Me.ucrChkXaxis, "ucrChkXaxis")
        Me.ucrChkXaxis.Name = "ucrChkXaxis"
        '
        'ucrInputYaxisOptions
        '
        Me.ucrInputYaxisOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputYaxisOptions.GetSetSelectedIndex = -1
        Me.ucrInputYaxisOptions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYaxisOptions, "ucrInputYaxisOptions")
        Me.ucrInputYaxisOptions.Name = "ucrInputYaxisOptions"
        '
        'ucrChkYaxis
        '
        Me.ucrChkYaxis.Checked = False
        resources.ApplyResources(Me.ucrChkYaxis, "ucrChkYaxis")
        Me.ucrChkYaxis.Name = "ucrChkYaxis"
        '
        'ttPICSARainfallGraph
        '
        Me.ttPICSARainfallGraph.AutoPopDelay = 10000
        Me.ttPICSARainfallGraph.InitialDelay = 500
        Me.ttPICSARainfallGraph.ReshowDelay = 100
        '
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        '
        'sdgPICSARainfallGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.Controls.Add(Me.tbPICSA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
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
        Me.grpMajorGridLines.ResumeLayout(False)
        Me.grpMajorGridLines.PerformLayout()
        Me.grpPnlBackground.ResumeLayout(False)
        Me.tpRug.ResumeLayout(False)
        Me.tpRug.PerformLayout()
        Me.ResumeLayout(False)

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
