<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.tbInventory = New System.Windows.Forms.TabControl()
        Me.tpFacets = New System.Windows.Forms.TabPage()
        Me.ucrNudNumberofRows = New instat.ucrNud()
        Me.ucrChkNoOfRowsOrColumns = New instat.ucrCheck()
        Me.rdoHorizontal = New System.Windows.Forms.RadioButton()
        Me.rdoVertical = New System.Windows.Forms.RadioButton()
        Me.ucrPnlHorizonatalVertical = New instat.UcrPanel()
        Me.ucrChkFacetYSize = New instat.ucrCheck()
        Me.ucrNudFacetYSize = New instat.ucrNud()
        Me.ucrChkFacetXSize = New instat.ucrCheck()
        Me.ucrNudFacetXSize = New instat.ucrNud()
        Me.ucrChkScales = New instat.ucrCheck()
        Me.ucrInputScale = New instat.ucrInputComboBox()
        Me.tpTitles = New System.Windows.Forms.TabPage()
        Me.grpyAxisTitle = New System.Windows.Forms.GroupBox()
        Me.lblYAxisSize = New System.Windows.Forms.Label()
        Me.rdoAutoYAxis = New System.Windows.Forms.RadioButton()
        Me.ucrInputYAxisTitle = New instat.ucrInputTextBox()
        Me.rdoNoYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.ucrNudYAxisTitleSize = New instat.ucrNud()
        Me.rdoSpecifyYAxisTitle = New System.Windows.Forms.RadioButton()
        Me.UcrPnlYAxisTitle = New instat.UcrPanel()
        Me.lblYAxisTitleSize = New System.Windows.Forms.Label()
        Me.grpAxes = New System.Windows.Forms.GroupBox()
        Me.lblXAxisSize = New System.Windows.Forms.Label()
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
        Me.ucrChkSpecifyXAxisTickMarks = New instat.ucrCheck()
        Me.ucrNudXAxisLabelSize = New instat.ucrNud()
        Me.ucrChkXAxisAngle = New instat.ucrCheck()
        Me.ucrNudXAxisAngle = New instat.ucrNud()
        Me.ucrChkXAxisLabelSize = New instat.ucrCheck()
        Me.lblXFrom = New System.Windows.Forms.Label()
        Me.ucrInputXFrom = New instat.ucrInputTextBox()
        Me.ucrInputXInStepsOf = New instat.ucrInputTextBox()
        Me.ucrInputXTo = New instat.ucrInputTextBox()
        Me.lblXInStepsOf = New System.Windows.Forms.Label()
        Me.lblXTo = New System.Windows.Forms.Label()
        Me.tpYAxis = New System.Windows.Forms.TabPage()
        Me.grpYAxis = New System.Windows.Forms.GroupBox()
        Me.ucrChkSpecifyDateBreaks = New instat.ucrCheck()
        Me.ucrNudYAxisLabelSize = New instat.ucrNud()
        Me.ucrNudYAxisAngle = New instat.ucrNud()
        Me.ucrInputDateDisplayFormat = New instat.ucrInputComboBox()
        Me.lblDateDisplayFormat = New System.Windows.Forms.Label()
        Me.ucrChkYAxisLabelSize = New instat.ucrCheck()
        Me.ucrChkYAxisAngle = New instat.ucrCheck()
        Me.ucrNudDateBreakNumber = New instat.ucrNud()
        Me.ucrInputDateBreakTime = New instat.ucrInputComboBox()
        Me.tpLegend = New System.Windows.Forms.TabPage()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegendPosition = New instat.ucrCheck()
        Me.ttInventoryPlot = New System.Windows.Forms.ToolTip(Me.components)
        Me.ucrButtonsInventoryplot = New instat.ucrButtonsSubdialogue()
        Me.tbInventory.SuspendLayout()
        Me.tpFacets.SuspendLayout()
        Me.tpTitles.SuspendLayout()
        Me.grpyAxisTitle.SuspendLayout()
        Me.grpAxes.SuspendLayout()
        Me.grpGraphTitles.SuspendLayout()
        Me.tpXAxis.SuspendLayout()
        Me.grpXAxisLabels.SuspendLayout()
        Me.tpYAxis.SuspendLayout()
        Me.grpYAxis.SuspendLayout()
        Me.tpLegend.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tpFacets.Controls.Add(Me.ucrNudNumberofRows)
        Me.tpFacets.Controls.Add(Me.ucrChkNoOfRowsOrColumns)
        Me.tpFacets.Controls.Add(Me.rdoHorizontal)
        Me.tpFacets.Controls.Add(Me.rdoVertical)
        Me.tpFacets.Controls.Add(Me.ucrPnlHorizonatalVertical)
        Me.tpFacets.Controls.Add(Me.ucrChkFacetYSize)
        Me.tpFacets.Controls.Add(Me.ucrNudFacetYSize)
        Me.tpFacets.Controls.Add(Me.ucrChkFacetXSize)
        Me.tpFacets.Controls.Add(Me.ucrNudFacetXSize)
        Me.tpFacets.Controls.Add(Me.ucrChkScales)
        Me.tpFacets.Controls.Add(Me.ucrInputScale)
        resources.ApplyResources(Me.tpFacets, "tpFacets")
        Me.tpFacets.Name = "tpFacets"
        Me.tpFacets.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudNumberofRows, "ucrNudNumberofRows")
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        resources.ApplyResources(Me.ucrChkNoOfRowsOrColumns, "ucrChkNoOfRowsOrColumns")
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        '
        'rdoHorizontal
        '
        resources.ApplyResources(Me.rdoHorizontal, "rdoHorizontal")
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        resources.ApplyResources(Me.rdoVertical, "rdoVertical")
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
        Me.grpyAxisTitle.Controls.Add(Me.lblYAxisSize)
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
        'lblYAxisSize
        '
        resources.ApplyResources(Me.lblYAxisSize, "lblYAxisSize")
        Me.lblYAxisSize.Name = "lblYAxisSize"
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
        Me.grpAxes.Controls.Add(Me.lblXAxisSize)
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
        'lblXAxisSize
        '
        resources.ApplyResources(Me.lblXAxisSize, "lblXAxisSize")
        Me.lblXAxisSize.Name = "lblXAxisSize"
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
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkSpecifyXAxisTickMarks)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXAxisLabelSize)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.ucrNudXAxisAngle)
        Me.grpXAxisLabels.Controls.Add(Me.ucrChkXAxisLabelSize)
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
        'ucrChkSpecifyXAxisTickMarks
        '
        Me.ucrChkSpecifyXAxisTickMarks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyXAxisTickMarks, "ucrChkSpecifyXAxisTickMarks")
        Me.ucrChkSpecifyXAxisTickMarks.Name = "ucrChkSpecifyXAxisTickMarks"
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
        Me.tpYAxis.Controls.Add(Me.grpYAxis)
        resources.ApplyResources(Me.tpYAxis, "tpYAxis")
        Me.tpYAxis.Name = "tpYAxis"
        Me.tpYAxis.UseVisualStyleBackColor = True
        '
        'grpYAxis
        '
        Me.grpYAxis.Controls.Add(Me.ucrChkSpecifyDateBreaks)
        Me.grpYAxis.Controls.Add(Me.ucrNudYAxisLabelSize)
        Me.grpYAxis.Controls.Add(Me.ucrNudYAxisAngle)
        Me.grpYAxis.Controls.Add(Me.ucrInputDateDisplayFormat)
        Me.grpYAxis.Controls.Add(Me.lblDateDisplayFormat)
        Me.grpYAxis.Controls.Add(Me.ucrChkYAxisLabelSize)
        Me.grpYAxis.Controls.Add(Me.ucrChkYAxisAngle)
        Me.grpYAxis.Controls.Add(Me.ucrNudDateBreakNumber)
        Me.grpYAxis.Controls.Add(Me.ucrInputDateBreakTime)
        resources.ApplyResources(Me.grpYAxis, "grpYAxis")
        Me.grpYAxis.Name = "grpYAxis"
        Me.grpYAxis.TabStop = False
        '
        'ucrChkSpecifyDateBreaks
        '
        Me.ucrChkSpecifyDateBreaks.Checked = False
        resources.ApplyResources(Me.ucrChkSpecifyDateBreaks, "ucrChkSpecifyDateBreaks")
        Me.ucrChkSpecifyDateBreaks.Name = "ucrChkSpecifyDateBreaks"
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
        'ucrInputDateDisplayFormat
        '
        Me.ucrInputDateDisplayFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateDisplayFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateDisplayFormat.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputDateDisplayFormat, "ucrInputDateDisplayFormat")
        Me.ucrInputDateDisplayFormat.Name = "ucrInputDateDisplayFormat"
        '
        'lblDateDisplayFormat
        '
        resources.ApplyResources(Me.lblDateDisplayFormat, "lblDateDisplayFormat")
        Me.lblDateDisplayFormat.Name = "lblDateDisplayFormat"
        '
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisLabelSize, "ucrChkYAxisLabelSize")
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.Checked = False
        resources.ApplyResources(Me.ucrChkYAxisAngle, "ucrChkYAxisAngle")
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
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
        'ucrButtonsInventoryplot
        '
        resources.ApplyResources(Me.ucrButtonsInventoryplot, "ucrButtonsInventoryplot")
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
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
        Me.grpYAxis.ResumeLayout(False)
        Me.grpYAxis.PerformLayout()
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
    Friend WithEvents ucrChkScales As ucrCheck
    Friend WithEvents ucrInputScale As ucrInputComboBox
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
    Friend WithEvents lblXAxisSize As Label
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
    Friend WithEvents ucrNudNumberofRows As ucrNud
    Friend WithEvents ucrChkNoOfRowsOrColumns As ucrCheck
    Friend WithEvents rdoHorizontal As RadioButton
    Friend WithEvents rdoVertical As RadioButton
    Friend WithEvents ucrPnlHorizonatalVertical As UcrPanel
    Friend WithEvents lblYAxisSize As Label
    Friend WithEvents ucrChkSpecifyXAxisTickMarks As ucrCheck
    Friend WithEvents grpYAxis As GroupBox
End Class
