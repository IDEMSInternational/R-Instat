﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPICSARainfallGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgPICSARainfallGraph))
        Me.lblYInStepsOf = New System.Windows.Forms.Label()
        Me.lblYFrom = New System.Windows.Forms.Label()
        Me.lblYTo = New System.Windows.Forms.Label()
        Me.lblXTo = New System.Windows.Forms.Label()
        Me.lblXFrom = New System.Windows.Forms.Label()
        Me.lblXInStepsOf = New System.Windows.Forms.Label()
        Me.tbPICSA = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.rdoSpecifyYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.lblXAxisTitleSize = New System.Windows.Forms.Label()
        Me.rdoAutoXAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoTitleXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlXAxisTitle = New instat.UcrPanel()
        Me.ucrNudXAxisTitleSize = New instat.ucrNud()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.grpXAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.ucrChkSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.ucrInputXFrom = New instat.ucrInputTextBox()
        Me.ucrInputXInStepsOf = New instat.ucrInputTextBox()
        Me.ucrNudXaxisLabelSize = New instat.ucrNud()
        Me.ucrInputXTo = New instat.ucrInputTextBox()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.grpYAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrNudDateBreakNumber = New instat.ucrNud()
        Me.ucrInputDateBreakTime = New instat.ucrInputComboBox()
        Me.ucrChkSpecifyDateBreaks = New instat.ucrCheck()
        Me.ucrInputLabelForDays = New instat.ucrInputComboBox()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.ucrChkLabelForDays = New instat.ucrCheck()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrChkYAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkSpecifyYAxisTickMarks = New instat.ucrCheck()
        Me.ucrInputYFrom = New instat.ucrInputTextBox()
        Me.ucrNudYAxisLabelSize = New instat.ucrNud()
        Me.ucrInputYTo = New instat.ucrInputTextBox()
        Me.ucrInputYInStepsOf = New instat.ucrInputTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ucrChkAddTercilesLabel = New instat.ucrCheck()
        Me.ucrChkAddMedianLabel = New instat.ucrCheck()
        Me.ucrChkAddMeanLabel = New instat.ucrCheck()
        Me.ucrChkAddMean = New instat.ucrCheck()
        Me.ucrChkAddMedian = New instat.ucrCheck()
        Me.ucrChkAddTerciles = New instat.ucrCheck()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.grpMinorGridLine = New System.Windows.Forms.GroupBox()
        Me.UcrNudMinorGridLineSize = New instat.ucrNud()
        Me.UcrChkMinorGridLineSize = New instat.ucrCheck()
        Me.UcrInputMinorGridLineTpe = New instat.ucrInputComboBox()
        Me.UcrInputMinorGridLineColour = New instat.ucrInputComboBox()
        Me.UcrChkMinorGridLineType = New instat.ucrCheck()
        Me.UcrChkMinorGridLineColour = New instat.ucrCheck()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrNudBorderSize = New instat.ucrNud()
        Me.UcrChkBorderSize = New instat.ucrCheck()
        Me.ucrInputBorderLinetype = New instat.ucrInputComboBox()
        Me.ucrInputBorderColour = New instat.ucrInputComboBox()
        Me.ucrChkBorderLineType = New instat.ucrCheck()
        Me.ucrChkBorderColour = New instat.ucrCheck()
        Me.grpMajorGridLines = New System.Windows.Forms.GroupBox()
        Me.UcrNudMajorGridLineSize = New instat.ucrNud()
        Me.UcrChkMajorGridLineSize = New instat.ucrCheck()
        Me.UcrInputMajorGridLineLinetype = New instat.ucrInputComboBox()
        Me.UcrInputMajorGridLineColour = New instat.ucrInputComboBox()
        Me.UcrChkMajorGridLinetype = New instat.ucrCheck()
        Me.UcrChkMajorGridLineColour = New instat.ucrCheck()
        Me.grpPnlBackground = New System.Windows.Forms.GroupBox()
        Me.ucrNudPnlBackgroundSize = New instat.ucrNud()
        Me.UcrInputPnlBackgroundFill = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundLinetype = New instat.ucrInputComboBox()
        Me.UcrInputPnlBackgroundColour = New instat.ucrInputComboBox()
        Me.UcrChkPnlBackgroundSize = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundLineType = New instat.ucrCheck()
        Me.UcrChkPnlBackgroundFill = New instat.ucrCheck()
        Me.ucrChkPnlBackgroundColour = New instat.ucrCheck()
        Me.ucrSdgPICSARainfalbuttons = New instat.ucrButtonsSubdialogue()
        Me.tbPICSA.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.grpYAxisLabels.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.grpMinorGridLine.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpMajorGridLines.SuspendLayout()
        Me.grpPnlBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblYInStepsOf
        '
        resources.ApplyResources(Me.lblYInStepsOf, "lblYInStepsOf")
        Me.lblYInStepsOf.Name = "lblYInStepsOf"
        '
        'lblYFrom
        '
        resources.ApplyResources(Me.lblYFrom, "lblYFrom")
        Me.lblYFrom.Name = "lblYFrom"
        '
        'lblYTo
        '
        resources.ApplyResources(Me.lblYTo, "lblYTo")
        Me.lblYTo.Name = "lblYTo"
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
        Me.tbPICSA.Controls.Add(Me.TabPage1)
        Me.tbPICSA.Controls.Add(Me.TabPage2)
        Me.tbPICSA.Controls.Add(Me.TabPage3)
        Me.tbPICSA.Controls.Add(Me.TabPage4)
        resources.ApplyResources(Me.tbPICSA, "tbPICSA")
        Me.tbPICSA.Name = "tbPICSA"
        Me.tbPICSA.SelectedIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpyAxisTitle)
        Me.TabPage1.Controls.Add(Me.grpAxes)
        Me.TabPage1.Controls.Add(Me.grpGraphTitles)
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpyAxisTitle
        '
        Me.grpyAxisTitle.Controls.Add(Me.Label1)
        Me.grpyAxisTitle.Controls.Add(Me.rdoAutoYAxis)
        Me.grpyAxisTitle.Controls.Add(Me.ucrInputYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.rdoNoYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.ucrNudYAxisTitleSize)
        Me.grpyAxisTitle.Controls.Add(Me.rdoSpecifyYAxisTitle)
        Me.grpyAxisTitle.Controls.Add(Me.UcrPnlYAxisTitle)
        resources.ApplyResources(Me.grpyAxisTitle, "grpyAxisTitle")
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
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
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.lblXAxisTitleSize)
        Me.grpAxes.Controls.Add(Me.rdoAutoXAxis)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoNoTitleXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoSpecifyXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrPnlXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrNudXAxisTitleSize)
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
        'ucrPnlXAxisTitle
        '
        resources.ApplyResources(Me.ucrPnlXAxisTitle, "ucrPnlXAxisTitle")
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
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
        Me.ucrInputGraphcCaption.IsMultiline = False
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpXAxisLabels)
        Me.TabPage2.Controls.Add(Me.grpYAxisLabels)
        resources.ApplyResources(Me.TabPage2, "TabPage2")
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
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
        'grpYAxisLabels
        '
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudDateBreakNumber)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputDateBreakTime)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkSpecifyDateBreaks)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputLabelForDays)
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudYAxisAngle)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkLabelForDays)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkYAxisAngle)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkYAxisLabelSize)
        Me.grpYAxisLabels.Controls.Add(Me.ucrChkSpecifyYAxisTickMarks)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYFrom)
        Me.grpYAxisLabels.Controls.Add(Me.lblYFrom)
        Me.grpYAxisLabels.Controls.Add(Me.ucrNudYAxisLabelSize)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYTo)
        Me.grpYAxisLabels.Controls.Add(Me.lblYTo)
        Me.grpYAxisLabels.Controls.Add(Me.lblYInStepsOf)
        Me.grpYAxisLabels.Controls.Add(Me.ucrInputYInStepsOf)
        resources.ApplyResources(Me.grpYAxisLabels, "grpYAxisLabels")
        Me.grpYAxisLabels.Name = "grpYAxisLabels"
        Me.grpYAxisLabels.TabStop = False
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
        'ucrInputDateBreakTime
        '
        Me.ucrInputDateBreakTime.AddQuotesIfUnrecognised = True
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
        'ucrInputLabelForDays
        '
        Me.ucrInputLabelForDays.AddQuotesIfUnrecognised = True
        Me.ucrInputLabelForDays.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLabelForDays, "ucrInputLabelForDays")
        Me.ucrInputLabelForDays.Name = "ucrInputLabelForDays"
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
        'ucrChkLabelForDays
        '
        Me.ucrChkLabelForDays.Checked = False
        resources.ApplyResources(Me.ucrChkLabelForDays, "ucrChkLabelForDays")
        Me.ucrChkLabelForDays.Name = "ucrChkLabelForDays"
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisAngle, "ucrChkYAxisAngle")
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
        '
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisLabelSize, "ucrChkYAxisLabelSize")
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
        '
        'ucrChkSpecifyYAxisTickMarks
        '
        Me.ucrChkSpecifyYAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyYAxisTickMarks, "ucrChkSpecifyYAxisTickMarks")
        Me.ucrChkSpecifyYAxisTickMarks.Name = "ucrChkSpecifyYAxisTickMarks"
        '
        'ucrInputYFrom
        '
        Me.ucrInputYFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputYFrom.IsMultiline = False
        Me.ucrInputYFrom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYFrom, "ucrInputYFrom")
        Me.ucrInputYFrom.Name = "ucrInputYFrom"
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
        'ucrInputYTo
        '
        Me.ucrInputYTo.AddQuotesIfUnrecognised = True
        Me.ucrInputYTo.IsMultiline = False
        Me.ucrInputYTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYTo, "ucrInputYTo")
        Me.ucrInputYTo.Name = "ucrInputYTo"
        '
        'ucrInputYInStepsOf
        '
        Me.ucrInputYInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputYInStepsOf.IsMultiline = False
        Me.ucrInputYInStepsOf.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputYInStepsOf, "ucrInputYInStepsOf")
        Me.ucrInputYInStepsOf.Name = "ucrInputYInStepsOf"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ucrChkAddTercilesLabel)
        Me.TabPage3.Controls.Add(Me.ucrChkAddMedianLabel)
        Me.TabPage3.Controls.Add(Me.ucrChkAddMeanLabel)
        Me.TabPage3.Controls.Add(Me.ucrChkAddMean)
        Me.TabPage3.Controls.Add(Me.ucrChkAddMedian)
        Me.TabPage3.Controls.Add(Me.ucrChkAddTerciles)
        resources.ApplyResources(Me.TabPage3, "TabPage3")
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
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
        'ucrChkAddMeanLabel
        '
        Me.ucrChkAddMeanLabel.Checked = False
        resources.ApplyResources(Me.ucrChkAddMeanLabel, "ucrChkAddMeanLabel")
        Me.ucrChkAddMeanLabel.Name = "ucrChkAddMeanLabel"
        '
        'ucrChkAddMean
        '
        Me.ucrChkAddMean.Checked = False
        resources.ApplyResources(Me.ucrChkAddMean, "ucrChkAddMean")
        Me.ucrChkAddMean.Name = "ucrChkAddMean"
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.grpMinorGridLine)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Controls.Add(Me.grpMajorGridLines)
        Me.TabPage4.Controls.Add(Me.grpPnlBackground)
        resources.ApplyResources(Me.TabPage4, "TabPage4")
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'grpMinorGridLine
        '
        Me.grpMinorGridLine.Controls.Add(Me.UcrNudMinorGridLineSize)
        Me.grpMinorGridLine.Controls.Add(Me.UcrChkMinorGridLineSize)
        Me.grpMinorGridLine.Controls.Add(Me.UcrInputMinorGridLineTpe)
        Me.grpMinorGridLine.Controls.Add(Me.UcrInputMinorGridLineColour)
        Me.grpMinorGridLine.Controls.Add(Me.UcrChkMinorGridLineType)
        Me.grpMinorGridLine.Controls.Add(Me.UcrChkMinorGridLineColour)
        resources.ApplyResources(Me.grpMinorGridLine, "grpMinorGridLine")
        Me.grpMinorGridLine.Name = "grpMinorGridLine"
        Me.grpMinorGridLine.TabStop = False
        '
        'UcrNudMinorGridLineSize
        '
        Me.UcrNudMinorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMinorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudMinorGridLineSize, "UcrNudMinorGridLineSize")
        Me.UcrNudMinorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudMinorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMinorGridLineSize.Name = "UcrNudMinorGridLineSize"
        Me.UcrNudMinorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkMinorGridLineSize
        '
        Me.UcrChkMinorGridLineSize.Checked = False
        resources.ApplyResources(Me.UcrChkMinorGridLineSize, "UcrChkMinorGridLineSize")
        Me.UcrChkMinorGridLineSize.Name = "UcrChkMinorGridLineSize"
        '
        'UcrInputMinorGridLineTpe
        '
        Me.UcrInputMinorGridLineTpe.AddQuotesIfUnrecognised = True
        Me.UcrInputMinorGridLineTpe.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMinorGridLineTpe, "UcrInputMinorGridLineTpe")
        Me.UcrInputMinorGridLineTpe.Name = "UcrInputMinorGridLineTpe"
        '
        'UcrInputMinorGridLineColour
        '
        Me.UcrInputMinorGridLineColour.AddQuotesIfUnrecognised = True
        Me.UcrInputMinorGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMinorGridLineColour, "UcrInputMinorGridLineColour")
        Me.UcrInputMinorGridLineColour.Name = "UcrInputMinorGridLineColour"
        '
        'UcrChkMinorGridLineType
        '
        Me.UcrChkMinorGridLineType.Checked = False
        resources.ApplyResources(Me.UcrChkMinorGridLineType, "UcrChkMinorGridLineType")
        Me.UcrChkMinorGridLineType.Name = "UcrChkMinorGridLineType"
        '
        'UcrChkMinorGridLineColour
        '
        Me.UcrChkMinorGridLineColour.Checked = False
        resources.ApplyResources(Me.UcrChkMinorGridLineColour, "UcrChkMinorGridLineColour")
        Me.UcrChkMinorGridLineColour.Name = "UcrChkMinorGridLineColour"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucrNudBorderSize)
        Me.GroupBox1.Controls.Add(Me.UcrChkBorderSize)
        Me.GroupBox1.Controls.Add(Me.ucrInputBorderLinetype)
        Me.GroupBox1.Controls.Add(Me.ucrInputBorderColour)
        Me.GroupBox1.Controls.Add(Me.ucrChkBorderLineType)
        Me.GroupBox1.Controls.Add(Me.ucrChkBorderColour)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
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
        Me.ucrInputBorderLinetype.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputBorderLinetype, "ucrInputBorderLinetype")
        Me.ucrInputBorderLinetype.Name = "ucrInputBorderLinetype"
        '
        'ucrInputBorderColour
        '
        Me.ucrInputBorderColour.AddQuotesIfUnrecognised = True
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
        Me.grpMajorGridLines.Controls.Add(Me.UcrNudMajorGridLineSize)
        Me.grpMajorGridLines.Controls.Add(Me.UcrChkMajorGridLineSize)
        Me.grpMajorGridLines.Controls.Add(Me.UcrInputMajorGridLineLinetype)
        Me.grpMajorGridLines.Controls.Add(Me.UcrInputMajorGridLineColour)
        Me.grpMajorGridLines.Controls.Add(Me.UcrChkMajorGridLinetype)
        Me.grpMajorGridLines.Controls.Add(Me.UcrChkMajorGridLineColour)
        resources.ApplyResources(Me.grpMajorGridLines, "grpMajorGridLines")
        Me.grpMajorGridLines.Name = "grpMajorGridLines"
        Me.grpMajorGridLines.TabStop = False
        '
        'UcrNudMajorGridLineSize
        '
        Me.UcrNudMajorGridLineSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMajorGridLineSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.UcrNudMajorGridLineSize, "UcrNudMajorGridLineSize")
        Me.UcrNudMajorGridLineSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.UcrNudMajorGridLineSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.UcrNudMajorGridLineSize.Name = "UcrNudMajorGridLineSize"
        Me.UcrNudMajorGridLineSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'UcrChkMajorGridLineSize
        '
        Me.UcrChkMajorGridLineSize.Checked = False
        resources.ApplyResources(Me.UcrChkMajorGridLineSize, "UcrChkMajorGridLineSize")
        Me.UcrChkMajorGridLineSize.Name = "UcrChkMajorGridLineSize"
        '
        'UcrInputMajorGridLineLinetype
        '
        Me.UcrInputMajorGridLineLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputMajorGridLineLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMajorGridLineLinetype, "UcrInputMajorGridLineLinetype")
        Me.UcrInputMajorGridLineLinetype.Name = "UcrInputMajorGridLineLinetype"
        '
        'UcrInputMajorGridLineColour
        '
        Me.UcrInputMajorGridLineColour.AddQuotesIfUnrecognised = True
        Me.UcrInputMajorGridLineColour.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputMajorGridLineColour, "UcrInputMajorGridLineColour")
        Me.UcrInputMajorGridLineColour.Name = "UcrInputMajorGridLineColour"
        '
        'UcrChkMajorGridLinetype
        '
        Me.UcrChkMajorGridLinetype.Checked = False
        resources.ApplyResources(Me.UcrChkMajorGridLinetype, "UcrChkMajorGridLinetype")
        Me.UcrChkMajorGridLinetype.Name = "UcrChkMajorGridLinetype"
        '
        'UcrChkMajorGridLineColour
        '
        Me.UcrChkMajorGridLineColour.Checked = False
        resources.ApplyResources(Me.UcrChkMajorGridLineColour, "UcrChkMajorGridLineColour")
        Me.UcrChkMajorGridLineColour.Name = "UcrChkMajorGridLineColour"
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
        Me.UcrInputPnlBackgroundFill.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundFill, "UcrInputPnlBackgroundFill")
        Me.UcrInputPnlBackgroundFill.Name = "UcrInputPnlBackgroundFill"
        '
        'UcrInputPnlBackgroundLinetype
        '
        Me.UcrInputPnlBackgroundLinetype.AddQuotesIfUnrecognised = True
        Me.UcrInputPnlBackgroundLinetype.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputPnlBackgroundLinetype, "UcrInputPnlBackgroundLinetype")
        Me.UcrInputPnlBackgroundLinetype.Name = "UcrInputPnlBackgroundLinetype"
        '
        'UcrInputPnlBackgroundColour
        '
        Me.UcrInputPnlBackgroundColour.AddQuotesIfUnrecognised = True
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
        'ucrSdgPICSARainfalbuttons
        '
        resources.ApplyResources(Me.ucrSdgPICSARainfalbuttons, "ucrSdgPICSARainfalbuttons")
        Me.ucrSdgPICSARainfalbuttons.Name = "ucrSdgPICSARainfalbuttons"
        '
        'sdgPICSARainfallGraph
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbPICSA)
        Me.Controls.Add(Me.ucrSdgPICSARainfalbuttons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgPICSARainfallGraph"
        Me.tbPICSA.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.grpXAxisLabels.ResumeLayout(False)
        Me.grpXAxisLabels.PerformLayout()
        Me.grpYAxisLabels.ResumeLayout(False)
        Me.grpYAxisLabels.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.grpMinorGridLine.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpMajorGridLines.ResumeLayout(False)
        Me.grpPnlBackground.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgPICSARainfalbuttons As ucrButtonsSubdialogue
    Friend WithEvents ucrChkAddMean As ucrCheck
    Friend WithEvents ucrChkAddMedian As ucrCheck
    Friend WithEvents ucrChkAddTerciles As ucrCheck
    Friend WithEvents ucrNudYAxisLabelSize As ucrNud
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents ucrNudXaxisLabelSize As ucrNud
    Friend WithEvents ucrInputYInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputYTo As ucrInputTextBox
    Friend WithEvents ucrInputYFrom As ucrInputTextBox
    Friend WithEvents lblYInStepsOf As Label
    Friend WithEvents lblYFrom As Label
    Friend WithEvents lblYTo As Label
    Friend WithEvents lblXTo As Label
    Friend WithEvents lblXFrom As Label
    Friend WithEvents lblXInStepsOf As Label
    Friend WithEvents ucrInputXFrom As ucrInputTextBox
    Friend WithEvents ucrInputXTo As ucrInputTextBox
    Friend WithEvents ucrInputXInStepsOf As ucrInputTextBox
    Friend WithEvents tbPICSA As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents grpGraphTitles As GroupBox
    Friend WithEvents ucrInputGraphcCaption As ucrInputTextBox
    Friend WithEvents grpYAxisLabels As GroupBox
    Friend WithEvents grpXAxisLabels As GroupBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ucrChkXAxisLabelSize As ucrCheck
    Friend WithEvents ucrChkSpecifyXAxisTickMarks As ucrCheck
    Friend WithEvents ucrNudYAxisAngle As ucrNud
    Friend WithEvents ucrChkYAxisAngle As ucrCheck
    Friend WithEvents ucrChkYAxisLabelSize As ucrCheck
    Friend WithEvents ucrChkSpecifyYAxisTickMarks As ucrCheck
    Friend WithEvents grpPnlBackground As GroupBox
    Friend WithEvents grpMajorGridLines As GroupBox
    Friend WithEvents UcrChkMajorGridLineColour As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundSize As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundLineType As ucrCheck
    Friend WithEvents UcrChkPnlBackgroundFill As ucrCheck
    Friend WithEvents ucrChkPnlBackgroundColour As ucrCheck
    Friend WithEvents UcrChkMajorGridLinetype As ucrCheck
    Friend WithEvents ucrInputLabelForDays As ucrInputComboBox
    Friend WithEvents ucrChkLabelForDays As ucrCheck
    Friend WithEvents UcrInputMajorGridLineLinetype As ucrInputComboBox
    Friend WithEvents UcrInputMajorGridLineColour As ucrInputComboBox
    Friend WithEvents ucrNudPnlBackgroundSize As ucrNud
    Friend WithEvents UcrInputPnlBackgroundFill As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundLinetype As ucrInputComboBox
    Friend WithEvents UcrInputPnlBackgroundColour As ucrInputComboBox
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents ucrNudCaptionSize As ucrNud
    Friend WithEvents ucrNudSubTitleSize As ucrNud
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents grpyAxisTitle As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrInputBorderLinetype As ucrInputComboBox
    Friend WithEvents ucrInputBorderColour As ucrInputComboBox
    Friend WithEvents ucrChkBorderLineType As ucrCheck
    Friend WithEvents ucrChkBorderColour As ucrCheck
    Friend WithEvents grpMinorGridLine As GroupBox
    Friend WithEvents UcrInputMinorGridLineTpe As ucrInputComboBox
    Friend WithEvents UcrInputMinorGridLineColour As ucrInputComboBox
    Friend WithEvents UcrChkMinorGridLineType As ucrCheck
    Friend WithEvents UcrChkMinorGridLineColour As ucrCheck
    Friend WithEvents ucrNudBorderSize As ucrNud
    Friend WithEvents UcrChkBorderSize As ucrCheck
    Friend WithEvents UcrNudMajorGridLineSize As ucrNud
    Friend WithEvents UcrChkMajorGridLineSize As ucrCheck
    Friend WithEvents UcrNudMinorGridLineSize As ucrNud
    Friend WithEvents UcrChkMinorGridLineSize As ucrCheck
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
    Friend WithEvents Label1 As Label
    Friend WithEvents lblXAxisTitleSize As Label
    Friend WithEvents ucrChkXAxisAngle As ucrCheck
    Friend WithEvents ucrChkSpecifyDateBreaks As ucrCheck
    Friend WithEvents ucrNudDateBreakNumber As ucrNud
    Friend WithEvents ucrInputDateBreakTime As ucrInputComboBox
End Class
