﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgInventoryPlot
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgInventoryPlot))
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.tbInventory = New System.Windows.Forms.TabControl()
        Me.tpFacets = New System.Windows.Forms.TabPage()
        Me.ucrChkFacetYSize = New instat.ucrCheck()
        Me.ucrNudFacetYSize = New instat.ucrNud()
        Me.ucrChkFacetXSize = New instat.ucrCheck()
        Me.ucrNudFacetXSize = New instat.ucrNud()
        Me.ucrNudNumberofRowsOrcolumns = New instat.ucrNud()
        Me.ucrChkNoOfRowsorColumns = New instat.ucrCheck()
        Me.ucrChkScales = New instat.ucrCheck()
        Me.ucrInputScale = New instat.ucrInputComboBox()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.ucrPnlHorizonatalVertical = New instat.UcrPanel()
        Me.tpTitles = New System.Windows.Forms.TabPage()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.rdoSpecifyYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoAutoXAxis = New System.Windows.Forms.RadioButton()
        Me.ucrNudXaxisTitleSize = New instat.ucrNud()
        Me.ucrInputXAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoTitleXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyXAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrPnlXAxisTitle = New instat.UcrPanel()
        Me.grpGraphTitles = New System.Windows.Forms.GroupBox()
        Me.ucrNudTitleSize = New instat.ucrNud()
        Me.lblCaptionSize = New System.Windows.Forms.Label()
        Me.lblSubTitleSize = New System.Windows.Forms.Label()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ucrNudCaptionSize = New instat.ucrNud()
        Me.ucrNudSubTitleSize = New instat.ucrNud()
        Me.ucrInputGraphcCaption = New instat.ucrInputTextBox()
        Me.ucrInputGraphTitle = New instat.ucrInputTextBox()
        Me.ucrInputGraphSubTitle = New instat.ucrInputTextBox()
        Me.tpXAxis = New System.Windows.Forms.TabPage()
        Me.grpXAxisLabels = New System.Windows.Forms.GroupBox()
        Me.ucrNudXAxisLabelSize = New instat.ucrNud()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.lblXFrom = New System.Windows.Forms.Label()
        Me.ucrInputXFrom = New instat.ucrInputTextBox()
        Me.ucrInputXInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputXTo = New instat.ucrInputTextBox()
        Me.lblXInStepsOf = New System.Windows.Forms.Label()
        Me.lblXTo = New System.Windows.Forms.Label()
        Me.tpYAxis = New System.Windows.Forms.TabPage()
        Me.lblDateDisplayFormat = New System.Windows.Forms.Label()
        Me.ucrNudDateBreakNumber = New instat.ucrNud()
        Me.ucrInputDateBreakTime = New instat.ucrInputComboBox()
        Me.ucrChkSpecifyDateBreaks = New instat.ucrCheck()
        Me.ucrInputDateDisplayFormat = New instat.ucrInputComboBox()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.ucrNudYAxisLabelSize = New instat.ucrNud()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrChkYAxisLabelSize = New instat.ucrCheck()
        Me.tpLegend = New System.Windows.Forms.TabPage()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.ttInventoryPlot = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbInventory.SuspendLayout()
        Me.tpFacets.SuspendLayout()
        Me.tpTitles.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.tpXAxis.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.tpYAxis.SuspendLayout()
        Me.tpLegend.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrButtonsInventoryplot
        '
        resources.ApplyResources(Me.ucrButtonsInventoryplot, "ucrButtonsInventoryplot")
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        '
        'tbInventory
        '
        Me.tbInventory.Controls.Add(Me.tpFacets)
        Me.tbInventory.Controls.Add(Me.tpTitles)
        Me.tbInventory.Controls.Add(Me.tpXAxis)
        Me.tbInventory.Controls.Add(Me.tpYAxis)
        Me.tbInventory.Controls.Add(Me.tpLegend)
        resources.ApplyResources(Me.tbInventory, "tbInventory")
        Me.tbInventory.Name = "tbInventory"
        Me.tbInventory.SelectedIndex = 0
        '
        'tpFacets
        '
        Me.tpFacets.Controls.Add(Me.ucrChkFacetYSize)
        Me.tpFacets.Controls.Add(Me.ucrNudFacetYSize)
        Me.tpFacets.Controls.Add(Me.ucrChkFacetXSize)
        Me.tpFacets.Controls.Add(Me.ucrNudFacetXSize)
        Me.tpFacets.Controls.Add(Me.ucrNudNumberofRowsOrcolumns)
        Me.tpFacets.Controls.Add(Me.ucrChkNoOfRowsorColumns)
        Me.tpFacets.Controls.Add(Me.ucrChkScales)
        Me.tpFacets.Controls.Add(Me.ucrInputScale)
        Me.tpFacets.Controls.Add(Me.rdoHorizontal)
        Me.tpFacets.Controls.Add(Me.rdoVertical)
        Me.tpFacets.Controls.Add(Me.ucrPnlHorizonatalVertical)
        resources.ApplyResources(Me.tpFacets, "tpFacets")
        Me.tpFacets.Name = "tpFacets"
        Me.tpFacets.UseVisualStyleBackColor = True
        '
        'ucrChkFacetYSize
        '
        Me.ucrChkFacetYSize.Checked = False
        resources.ApplyResources(Me.ucrChkFacetYSize, "ucrChkFacetYSize")
        Me.ucrChkFacetYSize.Name = "ucrChkFacetYSize"
        '
        'ucrNudFacetYSize
        '
        Me.ucrNudFacetYSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetYSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFacetYSize, "ucrNudFacetYSize")
        Me.ucrNudFacetYSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFacetYSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetYSize.Name = "ucrNudFacetYSize"
        Me.ucrNudFacetYSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFacetXSize
        '
        Me.ucrChkFacetXSize.Checked = False
        resources.ApplyResources(Me.ucrChkFacetXSize, "ucrChkFacetXSize")
        Me.ucrChkFacetXSize.Name = "ucrChkFacetXSize"
        '
        'ucrNudFacetXSize
        '
        Me.ucrNudFacetXSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetXSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudFacetXSize, "ucrNudFacetXSize")
        Me.ucrNudFacetXSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFacetXSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetXSize.Name = "ucrNudFacetXSize"
        Me.ucrNudFacetXSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudNumberofRowsOrcolumns
        '
        Me.ucrNudNumberofRowsOrcolumns.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRowsOrcolumns.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofRowsOrcolumns, "ucrNudNumberofRowsOrcolumns")
        Me.ucrNudNumberofRowsOrcolumns.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRowsOrcolumns.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRowsOrcolumns.Name = "ucrNudNumberofRowsOrcolumns"
        Me.ucrNudNumberofRowsOrcolumns.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsorColumns
        '
        Me.ucrChkNoOfRowsorColumns.Checked = False
        resources.ApplyResources(Me.ucrChkNoOfRowsorColumns, "ucrChkNoOfRowsorColumns")
        Me.ucrChkNoOfRowsorColumns.Name = "ucrChkNoOfRowsorColumns"
        '
        'ucrChkScales
        '
        Me.ucrChkScales.Checked = False
        resources.ApplyResources(Me.ucrChkScales, "ucrChkScales")
        Me.ucrChkScales.Name = "ucrChkScales"
        '
        'ucrInputScale
        '
        Me.ucrInputScale.AddQuotesIfUnrecognised = True
        Me.ucrInputScale.GetSetSelectedIndex = -1
        Me.ucrInputScale.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputScale, "ucrInputScale")
        Me.ucrInputScale.Name = "ucrInputScale"
        '
        'rdoHorizontal
        '
        resources.ApplyResources(Me.rdoHorizontal, "rdoHorizontal")
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        resources.ApplyResources(Me.rdoVertical, "rdoVertical")
        Me.rdoVertical.Checked = True
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'ucrPnlHorizonatalVertical
        '
        resources.ApplyResources(Me.ucrPnlHorizonatalVertical, "ucrPnlHorizonatalVertical")
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        '
        'tpTitles
        '
        Me.tpTitles.Controls.Add(Me.grpyAxisTitle)
        Me.tpTitles.Controls.Add(Me.grpAxes)
        Me.tpTitles.Controls.Add(Me.grpGraphTitles)
        resources.ApplyResources(Me.tpTitles, "tpTitles")
        Me.tpTitles.Name = "tpTitles"
        Me.tpTitles.UseVisualStyleBackColor = True
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
        'grpAxes
        '
        Me.grpAxes.Controls.Add(Me.Label1)
        Me.grpAxes.Controls.Add(Me.rdoAutoXAxis)
        Me.grpAxes.Controls.Add(Me.ucrNudXaxisTitleSize)
        Me.grpAxes.Controls.Add(Me.ucrInputXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoNoTitleXAxisTitle)
        Me.grpAxes.Controls.Add(Me.rdoSpecifyXAxisTitle)
        Me.grpAxes.Controls.Add(Me.ucrPnlXAxisTitle)
        resources.ApplyResources(Me.grpAxes, "grpAxes")
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'rdoAutoXAxis
        '
        resources.ApplyResources(Me.rdoAutoXAxis, "rdoAutoXAxis")
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrNudXaxisTitleSize
        '
        Me.ucrNudXaxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXaxisTitleSize, "ucrNudXaxisTitleSize")
        Me.ucrNudXaxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Name = "ucrNudXaxisTitleSize"
        Me.ucrNudXaxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
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
        'grpGraphTitles
        '
        Me.grpGraphTitles.Controls.Add(Me.ucrNudTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.lblCaption)
        Me.grpGraphTitles.Controls.Add(Me.lblSubTitle)
        Me.grpGraphTitles.Controls.Add(Me.lblTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudCaptionSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrNudSubTitleSize)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphcCaption)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphTitle)
        Me.grpGraphTitles.Controls.Add(Me.ucrInputGraphSubTitle)
        resources.ApplyResources(Me.grpGraphTitles, "grpGraphTitles")
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.TabStop = False
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
        'tpXAxis
        '
        Me.tpXAxis.Controls.Add(Me.grpXAxisLabels)
        resources.ApplyResources(Me.tpXAxis, "tpXAxis")
        Me.tpXAxis.Name = "tpXAxis"
        Me.tpXAxis.UseVisualStyleBackColor = True
        '
        'grpXAxisLabels
        '
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXAxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkSpecifyXAxisTickMarks)
        Me.grpXAxisLabels.Controls.Add(Me.lblXFrom)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXFrom)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXInStepsOf)
        Me.grpXAxisLabels.Controls.Add(Me.ucrInputXTo)
        Me.grpXAxisLabels.Controls.Add(Me.lblXInStepsOf)
        Me.grpXAxisLabels.Controls.Add(Me.lblXTo)
        resources.ApplyResources(Me.grpXAxisLabels, "grpXAxisLabels")
        Me.grpXAxisLabels.Name = "grpXAxisLabels"
        Me.grpXAxisLabels.TabStop = False
        '
        'ucrNudXAxisLabelSize
        '
        Me.ucrNudXAxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudXAxisLabelSize, "ucrNudXAxisLabelSize")
        Me.ucrNudXAxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Name = "ucrNudXAxisLabelSize"
        Me.ucrNudXAxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkXAxisAngle
        '
        Me.ucrChkXAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisAngle, "ucrChkXAxisAngle")
        Me.ucrChkXAxisAngle.Name = "ucrChkXAxisAngle"
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
        'ucrChkXAxisLabelSize
        '
        Me.ucrChkXAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkXAxisLabelSize, "ucrChkXAxisLabelSize")
        Me.ucrChkXAxisLabelSize.Name = "ucrChkXAxisLabelSize"
        '
        'ucrChkSpecifyXAxisTickMarks
        '
        Me.ucrChkSpecifyXAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyXAxisTickMarks, "ucrChkSpecifyXAxisTickMarks")
        Me.ucrChkSpecifyXAxisTickMarks.Name = "ucrChkSpecifyXAxisTickMarks"
        '
        'lblXFrom
        '
        resources.ApplyResources(Me.lblXFrom, "lblXFrom")
        Me.lblXFrom.Name = "lblXFrom"
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
        'ucrInputXTo
        '
        Me.ucrInputXTo.AddQuotesIfUnrecognised = True
        Me.ucrInputXTo.IsMultiline = False
        Me.ucrInputXTo.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputXTo, "ucrInputXTo")
        Me.ucrInputXTo.Name = "ucrInputXTo"
        '
        'lblXInStepsOf
        '
        resources.ApplyResources(Me.lblXInStepsOf, "lblXInStepsOf")
        Me.lblXInStepsOf.Name = "lblXInStepsOf"
        '
        'lblXTo
        '
        resources.ApplyResources(Me.lblXTo, "lblXTo")
        Me.lblXTo.Name = "lblXTo"
        '
        'tpYAxis
        '
        Me.tpYAxis.Controls.Add(Me.lblDateDisplayFormat)
        Me.tpYAxis.Controls.Add(Me.ucrNudDateBreakNumber)
        Me.tpYAxis.Controls.Add(Me.ucrInputDateBreakTime)
        Me.tpYAxis.Controls.Add(Me.ucrChkSpecifyDateBreaks)
        Me.tpYAxis.Controls.Add(Me.ucrInputDateDisplayFormat)
        Me.tpYAxis.Controls.Add(Me.ucrNudYAxisAngle)
        Me.tpYAxis.Controls.Add(Me.ucrNudYAxisLabelSize)
        Me.tpYAxis.Controls.Add(Me.ucrChkYAxisAngle)
        Me.tpYAxis.Controls.Add(Me.ucrChkYAxisLabelSize)
        resources.ApplyResources(Me.tpYAxis, "tpYAxis")
        Me.tpYAxis.Name = "tpYAxis"
        Me.tpYAxis.UseVisualStyleBackColor = True
        '
        'lblDateDisplayFormat
        '
        resources.ApplyResources(Me.lblDateDisplayFormat, "lblDateDisplayFormat")
        Me.lblDateDisplayFormat.Name = "lblDateDisplayFormat"
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
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisLabelSize, "ucrChkYAxisLabelSize")
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
        '
        'tpLegend
        '
        Me.tpLegend.Controls.Add(Me.ucrInputLegendPosition)
        Me.tpLegend.Controls.Add(Me.ucrChkLegendPosition)
        resources.ApplyResources(Me.tpLegend, "tpLegend")
        Me.tpLegend.Name = "tpLegend"
        Me.tpLegend.UseVisualStyleBackColor = True
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputLegendPosition, "ucrInputLegendPosition")
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.Checked = False
        resources.ApplyResources(Me.ucrChkLegendPosition, "ucrChkLegendPosition")
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        '
        'ttInventoryPlot
        '
        Me.ttInventoryPlot.AutoPopDelay = 10000
        Me.ttInventoryPlot.InitialDelay = 500
        Me.ttInventoryPlot.ReshowDelay = 100
        '
        'sdgInventoryPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbInventory)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryPlot"
        Me.tbInventory.ResumeLayout(False)
        Me.tpFacets.ResumeLayout(False)
        Me.tpFacets.PerformLayout()
        Me.tpTitles.ResumeLayout(False)
        Me.grpyAxisTitle.ResumeLayout(False)
        Me.grpyAxisTitle.PerformLayout()
        Me.grpAxes.ResumeLayout(False)
        Me.grpAxes.PerformLayout()
        Me.grpGraphTitles.ResumeLayout(False)
        Me.grpGraphTitles.PerformLayout()
        Me.tpXAxis.ResumeLayout(False)
        Me.grpXAxisLabels.ResumeLayout(False)
        Me.grpXAxisLabels.PerformLayout()
        Me.tpYAxis.ResumeLayout(False)
        Me.tpYAxis.PerformLayout()
        Me.tpLegend.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsInventoryplot As ucrButtonsSubdialogue
    Friend WithEvents tbInventory As TabControl
    Friend WithEvents tpFacets As TabPage
    Friend WithEvents ucrChkFacetYSize As ucrCheck
    Friend WithEvents ucrNudFacetYSize As ucrNud
    Friend WithEvents ucrChkFacetXSize As ucrCheck
    Friend WithEvents ucrNudFacetXSize As ucrNud
    Friend WithEvents ucrNudNumberofRowsOrcolumns As ucrNud
    Friend WithEvents ucrChkNoOfRowsorColumns As ucrCheck
    Friend WithEvents ucrChkScales As ucrCheck
    Friend WithEvents ucrInputScale As ucrInputComboBox
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents ucrPnlHorizonatalVertical As UcrPanel
    Friend WithEvents tpTitles As TabPage
    Friend WithEvents grpyAxisTitle As GroupBox
    Friend WithEvents rdoAutoYAxis As RadioButton
    Friend WithEvents ucrInputYAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoYAxisTitle As RadioButton
    Friend WithEvents ucrNudYAxisTitleSize As ucrNud
    Friend WithEvents rdoSpecifyYAxisTitle As RadioButton
    Friend WithEvents UcrPnlYAxisTitle As UcrPanel
    Friend WithEvents lblYAxisTitleSize As Label
    Friend WithEvents grpAxes As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoAutoXAxis As RadioButton
    Friend WithEvents ucrNudXaxisTitleSize As ucrNud
    Friend WithEvents ucrInputXAxisTitle As ucrInputTextBox
    Friend WithEvents rdoNoTitleXAxisTitle As RadioButton
    Friend WithEvents rdoSpecifyXAxisTitle As RadioButton
    Friend WithEvents ucrPnlXAxisTitle As UcrPanel
    Friend WithEvents grpGraphTitles As GroupBox
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents lblCaptionSize As Label
    Friend WithEvents lblSubTitleSize As Label
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents lblCaption As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrNudCaptionSize As ucrNud
    Friend WithEvents ucrNudSubTitleSize As ucrNud
    Friend WithEvents ucrInputGraphcCaption As ucrInputTextBox
    Friend WithEvents ucrInputGraphTitle As ucrInputTextBox
    Friend WithEvents ucrInputGraphSubTitle As ucrInputTextBox
    Friend WithEvents tpXAxis As TabPage
    Friend WithEvents grpXAxisLabels As GroupBox
    Friend WithEvents ucrNudXAxisLabelSize As ucrNud
    Friend WithEvents ucrChkXAxisAngle As ucrCheck
    Friend WithEvents ucrNudXAxisAngle As ucrNud
    Friend WithEvents ucrChkXAxisLabelSize As ucrCheck
    Friend WithEvents ucrChkSpecifyXAxisTickMarks As ucrCheck
    Friend WithEvents lblXFrom As Label
    Friend WithEvents ucrInputXFrom As ucrInputTextBox
    Friend WithEvents ucrInputXInStepsOf As ucrInputTextBox
    Friend WithEvents ucrInputXTo As ucrInputTextBox
    Friend WithEvents lblXInStepsOf As Label
    Friend WithEvents lblXTo As Label
    Friend WithEvents tpYAxis As TabPage
    Friend WithEvents lblDateDisplayFormat As Label
    Friend WithEvents ucrNudDateBreakNumber As ucrNud
    Friend WithEvents ucrInputDateBreakTime As ucrInputComboBox
    Friend WithEvents ucrChkSpecifyDateBreaks As ucrCheck
    Friend WithEvents ucrInputDateDisplayFormat As ucrInputComboBox
    Friend WithEvents ucrNudYAxisAngle As ucrNud
    Friend WithEvents ucrNudYAxisLabelSize As ucrNud
    Friend WithEvents ucrChkYAxisAngle As ucrCheck
    Friend WithEvents ucrChkYAxisLabelSize As ucrCheck
    Friend WithEvents tpLegend As TabPage
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegendPosition As ucrCheck
    Friend WithEvents ttInventoryPlot As ToolTip
End Class
