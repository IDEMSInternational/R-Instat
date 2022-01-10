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
        Me.tbInventory.Location = New System.Drawing.Point(9, 8)
        Me.tbInventory.Name = "tbInventory"
        Me.tbInventory.SelectedIndex = 0
        Me.tbInventory.Size = New System.Drawing.Size(515, 297)
        Me.tbInventory.TabIndex = 0
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
        Me.tpFacets.Location = New System.Drawing.Point(4, 22)
        Me.tpFacets.Name = "tpFacets"
        Me.tpFacets.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFacets.Size = New System.Drawing.Size(507, 271)
        Me.tpFacets.TabIndex = 4
        Me.tpFacets.Text = "Facets"
        Me.tpFacets.UseVisualStyleBackColor = True
        '
        'ucrNudNumberofRows
        '
        Me.ucrNudNumberofRows.AutoSize = True
        Me.ucrNudNumberofRows.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNumberofRows.Location = New System.Drawing.Point(156, 125)
        Me.ucrNudNumberofRows.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNumberofRows.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNumberofRows.Name = "ucrNudNumberofRows"
        Me.ucrNudNumberofRows.Size = New System.Drawing.Size(46, 20)
        Me.ucrNudNumberofRows.TabIndex = 9
        Me.ucrNudNumberofRows.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkNoOfRowsOrColumns
        '
        Me.ucrChkNoOfRowsOrColumns.AutoSize = True
        Me.ucrChkNoOfRowsOrColumns.Checked = False
        Me.ucrChkNoOfRowsOrColumns.Location = New System.Drawing.Point(12, 125)
        Me.ucrChkNoOfRowsOrColumns.Name = "ucrChkNoOfRowsOrColumns"
        Me.ucrChkNoOfRowsOrColumns.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkNoOfRowsOrColumns.TabIndex = 8
        '
        'rdoHorizontal
        '
        Me.rdoHorizontal.AutoSize = True
        Me.rdoHorizontal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHorizontal.Location = New System.Drawing.Point(12, 99)
        Me.rdoHorizontal.Name = "rdoHorizontal"
        Me.rdoHorizontal.Size = New System.Drawing.Size(72, 17)
        Me.rdoHorizontal.TabIndex = 6
        Me.rdoHorizontal.TabStop = True
        Me.rdoHorizontal.Tag = "Horizontal"
        Me.rdoHorizontal.Text = "Horizontal"
        Me.rdoHorizontal.UseVisualStyleBackColor = True
        '
        'rdoVertical
        '
        Me.rdoVertical.AutoSize = True
        Me.rdoVertical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoVertical.Location = New System.Drawing.Point(108, 99)
        Me.rdoVertical.Name = "rdoVertical"
        Me.rdoVertical.Size = New System.Drawing.Size(60, 17)
        Me.rdoVertical.TabIndex = 7
        Me.rdoVertical.TabStop = True
        Me.rdoVertical.Tag = "Vertical"
        Me.rdoVertical.Text = "Vertical"
        Me.rdoVertical.UseVisualStyleBackColor = True
        '
        'ucrPnlHorizonatalVertical
        '
        Me.ucrPnlHorizonatalVertical.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlHorizonatalVertical.Location = New System.Drawing.Point(12, 97)
        Me.ucrPnlHorizonatalVertical.Name = "ucrPnlHorizonatalVertical"
        Me.ucrPnlHorizonatalVertical.Size = New System.Drawing.Size(165, 20)
        Me.ucrPnlHorizonatalVertical.TabIndex = 60
        '
        'ucrChkFacetYSize
        '
        Me.ucrChkFacetYSize.AutoSize = True
        Me.ucrChkFacetYSize.Checked = False
        Me.ucrChkFacetYSize.Location = New System.Drawing.Point(12, 44)
        Me.ucrChkFacetYSize.Name = "ucrChkFacetYSize"
        Me.ucrChkFacetYSize.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkFacetYSize.TabIndex = 2
        '
        'ucrNudFacetYSize
        '
        Me.ucrNudFacetYSize.AutoSize = True
        Me.ucrNudFacetYSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetYSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFacetYSize.Location = New System.Drawing.Point(187, 44)
        Me.ucrNudFacetYSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFacetYSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetYSize.Name = "ucrNudFacetYSize"
        Me.ucrNudFacetYSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFacetYSize.TabIndex = 3
        Me.ucrNudFacetYSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkFacetXSize
        '
        Me.ucrChkFacetXSize.AutoSize = True
        Me.ucrChkFacetXSize.Checked = False
        Me.ucrChkFacetXSize.Location = New System.Drawing.Point(12, 18)
        Me.ucrChkFacetXSize.Name = "ucrChkFacetXSize"
        Me.ucrChkFacetXSize.Size = New System.Drawing.Size(156, 23)
        Me.ucrChkFacetXSize.TabIndex = 0
        '
        'ucrNudFacetXSize
        '
        Me.ucrNudFacetXSize.AutoSize = True
        Me.ucrNudFacetXSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetXSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudFacetXSize.Location = New System.Drawing.Point(187, 18)
        Me.ucrNudFacetXSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudFacetXSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudFacetXSize.Name = "ucrNudFacetXSize"
        Me.ucrNudFacetXSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudFacetXSize.TabIndex = 1
        Me.ucrNudFacetXSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkScales
        '
        Me.ucrChkScales.AutoSize = True
        Me.ucrChkScales.Checked = False
        Me.ucrChkScales.Location = New System.Drawing.Point(12, 70)
        Me.ucrChkScales.Name = "ucrChkScales"
        Me.ucrChkScales.Size = New System.Drawing.Size(172, 23)
        Me.ucrChkScales.TabIndex = 4
        '
        'ucrInputScale
        '
        Me.ucrInputScale.AddQuotesIfUnrecognised = True
        Me.ucrInputScale.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputScale.GetSetSelectedIndex = -1
        Me.ucrInputScale.IsReadOnly = False
        Me.ucrInputScale.Location = New System.Drawing.Point(187, 70)
        Me.ucrInputScale.Name = "ucrInputScale"
        Me.ucrInputScale.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputScale.TabIndex = 5
        '
        'tpTitles
        '
        Me.tpTitles.Controls.Add(Me.grpyAxisTitle)
        Me.tpTitles.Controls.Add(Me.grpAxes)
        Me.tpTitles.Controls.Add(Me.grpGraphTitles)
        Me.tpTitles.Location = New System.Drawing.Point(4, 22)
        Me.tpTitles.Name = "tpTitles"
        Me.tpTitles.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTitles.Size = New System.Drawing.Size(507, 271)
        Me.tpTitles.TabIndex = 0
        Me.tpTitles.Text = "Titles "
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
        Me.grpyAxisTitle.Location = New System.Drawing.Point(257, 152)
        Me.grpyAxisTitle.Name = "grpyAxisTitle"
        Me.grpyAxisTitle.Size = New System.Drawing.Size(240, 111)
        Me.grpyAxisTitle.TabIndex = 2
        Me.grpyAxisTitle.TabStop = False
        Me.grpyAxisTitle.Text = "Y-Axis Title"
        '
        'lblYAxisSize
        '
        Me.lblYAxisSize.AutoSize = True
        Me.lblYAxisSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYAxisSize.Location = New System.Drawing.Point(5, 79)
        Me.lblYAxisSize.Name = "lblYAxisSize"
        Me.lblYAxisSize.Size = New System.Drawing.Size(30, 13)
        Me.lblYAxisSize.TabIndex = 4
        Me.lblYAxisSize.Text = "Size:"
        '
        'rdoAutoYAxis
        '
        Me.rdoAutoYAxis.AutoSize = True
        Me.rdoAutoYAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAutoYAxis.Location = New System.Drawing.Point(6, 21)
        Me.rdoAutoYAxis.Name = "rdoAutoYAxis"
        Me.rdoAutoYAxis.Size = New System.Drawing.Size(50, 17)
        Me.rdoAutoYAxis.TabIndex = 0
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
        Me.ucrInputYAxisTitle.Location = New System.Drawing.Point(43, 47)
        Me.ucrInputYAxisTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputYAxisTitle.Name = "ucrInputYAxisTitle"
        Me.ucrInputYAxisTitle.Size = New System.Drawing.Size(146, 21)
        Me.ucrInputYAxisTitle.TabIndex = 3
        '
        'rdoNoYAxisTitle
        '
        Me.rdoNoYAxisTitle.AutoSize = True
        Me.rdoNoYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoYAxisTitle.Location = New System.Drawing.Point(138, 21)
        Me.rdoNoYAxisTitle.Name = "rdoNoYAxisTitle"
        Me.rdoNoYAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoYAxisTitle.TabIndex = 2
        Me.rdoNoYAxisTitle.TabStop = True
        Me.rdoNoYAxisTitle.Text = "No Title"
        Me.rdoNoYAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrNudYAxisTitleSize
        '
        Me.ucrNudYAxisTitleSize.AutoSize = True
        Me.ucrNudYAxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Location = New System.Drawing.Point(43, 76)
        Me.ucrNudYAxisTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisTitleSize.Name = "ucrNudYAxisTitleSize"
        Me.ucrNudYAxisTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisTitleSize.TabIndex = 5
        Me.ucrNudYAxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'rdoSpecifyYAxisTitle
        '
        Me.rdoSpecifyYAxisTitle.AutoSize = True
        Me.rdoSpecifyYAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyYAxisTitle.Location = New System.Drawing.Point(64, 21)
        Me.rdoSpecifyYAxisTitle.Name = "rdoSpecifyYAxisTitle"
        Me.rdoSpecifyYAxisTitle.Size = New System.Drawing.Size(60, 17)
        Me.rdoSpecifyYAxisTitle.TabIndex = 1
        Me.rdoSpecifyYAxisTitle.TabStop = True
        Me.rdoSpecifyYAxisTitle.Text = "Specify"
        Me.rdoSpecifyYAxisTitle.UseVisualStyleBackColor = True
        '
        'UcrPnlYAxisTitle
        '
        Me.UcrPnlYAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrPnlYAxisTitle.Location = New System.Drawing.Point(6, 16)
        Me.UcrPnlYAxisTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.UcrPnlYAxisTitle.Name = "UcrPnlYAxisTitle"
        Me.UcrPnlYAxisTitle.Size = New System.Drawing.Size(204, 81)
        Me.UcrPnlYAxisTitle.TabIndex = 37
        '
        'lblYAxisTitleSize
        '
        Me.lblYAxisTitleSize.AutoSize = True
        Me.lblYAxisTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblYAxisTitleSize.Location = New System.Drawing.Point(40, 76)
        Me.lblYAxisTitleSize.Name = "lblYAxisTitleSize"
        Me.lblYAxisTitleSize.Size = New System.Drawing.Size(30, 13)
        Me.lblYAxisTitleSize.TabIndex = 45
        Me.lblYAxisTitleSize.Text = "Size:"
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
        Me.grpAxes.Location = New System.Drawing.Point(9, 152)
        Me.grpAxes.Name = "grpAxes"
        Me.grpAxes.Size = New System.Drawing.Size(242, 111)
        Me.grpAxes.TabIndex = 1
        Me.grpAxes.TabStop = False
        Me.grpAxes.Text = "X-Axis Title"
        '
        'lblXAxisSize
        '
        Me.lblXAxisSize.AutoSize = True
        Me.lblXAxisSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXAxisSize.Location = New System.Drawing.Point(5, 79)
        Me.lblXAxisSize.Name = "lblXAxisSize"
        Me.lblXAxisSize.Size = New System.Drawing.Size(30, 13)
        Me.lblXAxisSize.TabIndex = 4
        Me.lblXAxisSize.Text = "Size:"
        '
        'rdoAutoXAxis
        '
        Me.rdoAutoXAxis.AutoSize = True
        Me.rdoAutoXAxis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoAutoXAxis.Location = New System.Drawing.Point(6, 21)
        Me.rdoAutoXAxis.Name = "rdoAutoXAxis"
        Me.rdoAutoXAxis.Size = New System.Drawing.Size(50, 17)
        Me.rdoAutoXAxis.TabIndex = 0
        Me.rdoAutoXAxis.TabStop = True
        Me.rdoAutoXAxis.Text = "Auto "
        Me.rdoAutoXAxis.UseVisualStyleBackColor = True
        '
        'ucrNudXaxisTitleSize
        '
        Me.ucrNudXaxisTitleSize.AutoSize = True
        Me.ucrNudXaxisTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Location = New System.Drawing.Point(46, 76)
        Me.ucrNudXaxisTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudXaxisTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXaxisTitleSize.Name = "ucrNudXaxisTitleSize"
        Me.ucrNudXaxisTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXaxisTitleSize.TabIndex = 5
        Me.ucrNudXaxisTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputXAxisTitle
        '
        Me.ucrInputXAxisTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputXAxisTitle.AutoSize = True
        Me.ucrInputXAxisTitle.IsMultiline = False
        Me.ucrInputXAxisTitle.IsReadOnly = False
        Me.ucrInputXAxisTitle.Location = New System.Drawing.Point(46, 47)
        Me.ucrInputXAxisTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXAxisTitle.Name = "ucrInputXAxisTitle"
        Me.ucrInputXAxisTitle.Size = New System.Drawing.Size(146, 21)
        Me.ucrInputXAxisTitle.TabIndex = 3
        '
        'rdoNoTitleXAxisTitle
        '
        Me.rdoNoTitleXAxisTitle.AutoSize = True
        Me.rdoNoTitleXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoNoTitleXAxisTitle.Location = New System.Drawing.Point(142, 21)
        Me.rdoNoTitleXAxisTitle.Name = "rdoNoTitleXAxisTitle"
        Me.rdoNoTitleXAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoNoTitleXAxisTitle.TabIndex = 2
        Me.rdoNoTitleXAxisTitle.TabStop = True
        Me.rdoNoTitleXAxisTitle.Text = "No Title"
        Me.rdoNoTitleXAxisTitle.UseVisualStyleBackColor = True
        '
        'rdoSpecifyXAxisTitle
        '
        Me.rdoSpecifyXAxisTitle.AutoSize = True
        Me.rdoSpecifyXAxisTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSpecifyXAxisTitle.Location = New System.Drawing.Point(67, 21)
        Me.rdoSpecifyXAxisTitle.Name = "rdoSpecifyXAxisTitle"
        Me.rdoSpecifyXAxisTitle.Size = New System.Drawing.Size(62, 17)
        Me.rdoSpecifyXAxisTitle.TabIndex = 1
        Me.rdoSpecifyXAxisTitle.TabStop = True
        Me.rdoSpecifyXAxisTitle.Text = "Specifiy"
        Me.rdoSpecifyXAxisTitle.UseVisualStyleBackColor = True
        '
        'ucrPnlXAxisTitle
        '
        Me.ucrPnlXAxisTitle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlXAxisTitle.Location = New System.Drawing.Point(6, 17)
        Me.ucrPnlXAxisTitle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlXAxisTitle.Name = "ucrPnlXAxisTitle"
        Me.ucrPnlXAxisTitle.Size = New System.Drawing.Size(228, 81)
        Me.ucrPnlXAxisTitle.TabIndex = 36
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
        Me.grpGraphTitles.Location = New System.Drawing.Point(9, 10)
        Me.grpGraphTitles.Name = "grpGraphTitles"
        Me.grpGraphTitles.Size = New System.Drawing.Size(488, 136)
        Me.grpGraphTitles.TabIndex = 0
        Me.grpGraphTitles.TabStop = False
        Me.grpGraphTitles.Text = "Graph"
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.AutoSize = True
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTitleSize.Location = New System.Drawing.Point(431, 18)
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTitleSize.TabIndex = 3
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCaptionSize
        '
        Me.lblCaptionSize.AutoSize = True
        Me.lblCaptionSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaptionSize.Location = New System.Drawing.Point(325, 75)
        Me.lblCaptionSize.Name = "lblCaptionSize"
        Me.lblCaptionSize.Size = New System.Drawing.Size(69, 13)
        Me.lblCaptionSize.TabIndex = 10
        Me.lblCaptionSize.Text = "Caption Size:"
        '
        'lblSubTitleSize
        '
        Me.lblSubTitleSize.AutoSize = True
        Me.lblSubTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitleSize.Location = New System.Drawing.Point(325, 48)
        Me.lblSubTitleSize.Name = "lblSubTitleSize"
        Me.lblSubTitleSize.Size = New System.Drawing.Size(68, 13)
        Me.lblSubTitleSize.TabIndex = 6
        Me.lblSubTitleSize.Text = "Subtitle Size:"
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(325, 20)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(53, 13)
        Me.lblTitleSize.TabIndex = 2
        Me.lblTitleSize.Text = "Title Size:"
        '
        'lblCaption
        '
        Me.lblCaption.AutoSize = True
        Me.lblCaption.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCaption.Location = New System.Drawing.Point(5, 75)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(78, 13)
        Me.lblCaption.TabIndex = 8
        Me.lblCaption.Text = "Graph Caption:"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubTitle.Location = New System.Drawing.Point(5, 48)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(77, 13)
        Me.lblSubTitle.TabIndex = 4
        Me.lblSubTitle.Text = "Graph Subtitle:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(6, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(62, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Graph Title:"
        '
        'ucrNudCaptionSize
        '
        Me.ucrNudCaptionSize.AutoSize = True
        Me.ucrNudCaptionSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCaptionSize.Location = New System.Drawing.Point(431, 72)
        Me.ucrNudCaptionSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudCaptionSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCaptionSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCaptionSize.Name = "ucrNudCaptionSize"
        Me.ucrNudCaptionSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudCaptionSize.TabIndex = 11
        Me.ucrNudCaptionSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudSubTitleSize
        '
        Me.ucrNudSubTitleSize.AutoSize = True
        Me.ucrNudSubTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSubTitleSize.Location = New System.Drawing.Point(431, 45)
        Me.ucrNudSubTitleSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudSubTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSubTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSubTitleSize.Name = "ucrNudSubTitleSize"
        Me.ucrNudSubTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSubTitleSize.TabIndex = 7
        Me.ucrNudSubTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputGraphcCaption
        '
        Me.ucrInputGraphcCaption.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphcCaption.AutoSize = True
        Me.ucrInputGraphcCaption.IsMultiline = True
        Me.ucrInputGraphcCaption.IsReadOnly = False
        Me.ucrInputGraphcCaption.Location = New System.Drawing.Point(137, 72)
        Me.ucrInputGraphcCaption.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphcCaption.Name = "ucrInputGraphcCaption"
        Me.ucrInputGraphcCaption.Size = New System.Drawing.Size(181, 53)
        Me.ucrInputGraphcCaption.TabIndex = 9
        '
        'ucrInputGraphTitle
        '
        Me.ucrInputGraphTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphTitle.AutoSize = True
        Me.ucrInputGraphTitle.IsMultiline = False
        Me.ucrInputGraphTitle.IsReadOnly = False
        Me.ucrInputGraphTitle.Location = New System.Drawing.Point(137, 18)
        Me.ucrInputGraphTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphTitle.Name = "ucrInputGraphTitle"
        Me.ucrInputGraphTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputGraphTitle.TabIndex = 1
        '
        'ucrInputGraphSubTitle
        '
        Me.ucrInputGraphSubTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputGraphSubTitle.AutoSize = True
        Me.ucrInputGraphSubTitle.IsMultiline = False
        Me.ucrInputGraphSubTitle.IsReadOnly = False
        Me.ucrInputGraphSubTitle.Location = New System.Drawing.Point(137, 45)
        Me.ucrInputGraphSubTitle.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputGraphSubTitle.Name = "ucrInputGraphSubTitle"
        Me.ucrInputGraphSubTitle.Size = New System.Drawing.Size(181, 21)
        Me.ucrInputGraphSubTitle.TabIndex = 5
        '
        'tpXAxis
        '
        Me.tpXAxis.Controls.Add(Me.grpXAxisLabels)
        Me.tpXAxis.Location = New System.Drawing.Point(4, 22)
        Me.tpXAxis.Name = "tpXAxis"
        Me.tpXAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tpXAxis.Size = New System.Drawing.Size(507, 271)
        Me.tpXAxis.TabIndex = 1
        Me.tpXAxis.Text = "X-Axis"
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
        Me.grpXAxisLabels.Location = New System.Drawing.Point(9, 10)
        Me.grpXAxisLabels.Name = "grpXAxisLabels"
        Me.grpXAxisLabels.Size = New System.Drawing.Size(492, 110)
        Me.grpXAxisLabels.TabIndex = 0
        Me.grpXAxisLabels.TabStop = False
        Me.grpXAxisLabels.Text = "X-Axis"
        '
        'ucrChkSpecifyXAxisTickMarks
        '
        Me.ucrChkSpecifyXAxisTickMarks.AutoSize = True
        Me.ucrChkSpecifyXAxisTickMarks.Checked = False
        Me.ucrChkSpecifyXAxisTickMarks.Location = New System.Drawing.Point(8, 24)
        Me.ucrChkSpecifyXAxisTickMarks.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSpecifyXAxisTickMarks.Name = "ucrChkSpecifyXAxisTickMarks"
        Me.ucrChkSpecifyXAxisTickMarks.Size = New System.Drawing.Size(141, 23)
        Me.ucrChkSpecifyXAxisTickMarks.TabIndex = 0
        '
        'ucrNudXAxisLabelSize
        '
        Me.ucrNudXAxisLabelSize.AutoSize = True
        Me.ucrNudXAxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Location = New System.Drawing.Point(112, 79)
        Me.ucrNudXAxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelSize.Name = "ucrNudXAxisLabelSize"
        Me.ucrNudXAxisLabelSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisLabelSize.TabIndex = 10
        Me.ucrNudXAxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkXAxisAngle
        '
        Me.ucrChkXAxisAngle.AutoSize = True
        Me.ucrChkXAxisAngle.Checked = False
        Me.ucrChkXAxisAngle.Location = New System.Drawing.Point(8, 53)
        Me.ucrChkXAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkXAxisAngle.Name = "ucrChkXAxisAngle"
        Me.ucrChkXAxisAngle.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkXAxisAngle.TabIndex = 7
        '
        'ucrNudXAxisAngle
        '
        Me.ucrNudXAxisAngle.AutoSize = True
        Me.ucrNudXAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisAngle.Location = New System.Drawing.Point(112, 52)
        Me.ucrNudXAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudXAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisAngle.Name = "ucrNudXAxisAngle"
        Me.ucrNudXAxisAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisAngle.TabIndex = 8
        Me.ucrNudXAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkXAxisLabelSize
        '
        Me.ucrChkXAxisLabelSize.AutoSize = True
        Me.ucrChkXAxisLabelSize.Checked = False
        Me.ucrChkXAxisLabelSize.Location = New System.Drawing.Point(8, 82)
        Me.ucrChkXAxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkXAxisLabelSize.Name = "ucrChkXAxisLabelSize"
        Me.ucrChkXAxisLabelSize.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkXAxisLabelSize.TabIndex = 9
        '
        'lblXFrom
        '
        Me.lblXFrom.AutoSize = True
        Me.lblXFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXFrom.Location = New System.Drawing.Point(157, 27)
        Me.lblXFrom.Name = "lblXFrom"
        Me.lblXFrom.Size = New System.Drawing.Size(33, 13)
        Me.lblXFrom.TabIndex = 1
        Me.lblXFrom.Text = "From:"
        '
        'ucrInputXFrom
        '
        Me.ucrInputXFrom.AddQuotesIfUnrecognised = True
        Me.ucrInputXFrom.AutoSize = True
        Me.ucrInputXFrom.IsMultiline = False
        Me.ucrInputXFrom.IsReadOnly = False
        Me.ucrInputXFrom.Location = New System.Drawing.Point(192, 24)
        Me.ucrInputXFrom.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXFrom.Name = "ucrInputXFrom"
        Me.ucrInputXFrom.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputXFrom.TabIndex = 2
        '
        'ucrInputXInStepsOf
        '
        Me.ucrInputXInStepsOf.AddQuotesIfUnrecognised = True
        Me.ucrInputXInStepsOf.AutoSize = True
        Me.ucrInputXInStepsOf.IsMultiline = False
        Me.ucrInputXInStepsOf.IsReadOnly = False
        Me.ucrInputXInStepsOf.Location = New System.Drawing.Point(435, 24)
        Me.ucrInputXInStepsOf.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXInStepsOf.Name = "ucrInputXInStepsOf"
        Me.ucrInputXInStepsOf.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputXInStepsOf.TabIndex = 6
        '
        'ucrInputXTo
        '
        Me.ucrInputXTo.AddQuotesIfUnrecognised = True
        Me.ucrInputXTo.AutoSize = True
        Me.ucrInputXTo.IsMultiline = False
        Me.ucrInputXTo.IsReadOnly = False
        Me.ucrInputXTo.Location = New System.Drawing.Point(272, 24)
        Me.ucrInputXTo.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputXTo.Name = "ucrInputXTo"
        Me.ucrInputXTo.Size = New System.Drawing.Size(51, 21)
        Me.ucrInputXTo.TabIndex = 4
        '
        'lblXInStepsOf
        '
        Me.lblXInStepsOf.AutoSize = True
        Me.lblXInStepsOf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXInStepsOf.Location = New System.Drawing.Point(328, 27)
        Me.lblXInStepsOf.Name = "lblXInStepsOf"
        Me.lblXInStepsOf.Size = New System.Drawing.Size(61, 13)
        Me.lblXInStepsOf.TabIndex = 5
        Me.lblXInStepsOf.Text = "In Steps of:"
        '
        'lblXTo
        '
        Me.lblXTo.AutoSize = True
        Me.lblXTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblXTo.Location = New System.Drawing.Point(248, 27)
        Me.lblXTo.Name = "lblXTo"
        Me.lblXTo.Size = New System.Drawing.Size(23, 13)
        Me.lblXTo.TabIndex = 3
        Me.lblXTo.Text = "To:"
        '
        'tpYAxis
        '
        Me.tpYAxis.Controls.Add(Me.grpYAxis)
        Me.tpYAxis.Location = New System.Drawing.Point(4, 22)
        Me.tpYAxis.Name = "tpYAxis"
        Me.tpYAxis.Padding = New System.Windows.Forms.Padding(3)
        Me.tpYAxis.Size = New System.Drawing.Size(507, 271)
        Me.tpYAxis.TabIndex = 2
        Me.tpYAxis.Text = "Y-Axis"
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
        Me.grpYAxis.Location = New System.Drawing.Point(9, 10)
        Me.grpYAxis.Name = "grpYAxis"
        Me.grpYAxis.Size = New System.Drawing.Size(492, 110)
        Me.grpYAxis.TabIndex = 0
        Me.grpYAxis.TabStop = False
        Me.grpYAxis.Text = "Y-Axis"
        '
        'ucrChkSpecifyDateBreaks
        '
        Me.ucrChkSpecifyDateBreaks.AutoSize = True
        Me.ucrChkSpecifyDateBreaks.Checked = False
        Me.ucrChkSpecifyDateBreaks.Location = New System.Drawing.Point(8, 24)
        Me.ucrChkSpecifyDateBreaks.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkSpecifyDateBreaks.Name = "ucrChkSpecifyDateBreaks"
        Me.ucrChkSpecifyDateBreaks.Size = New System.Drawing.Size(133, 23)
        Me.ucrChkSpecifyDateBreaks.TabIndex = 0
        '
        'ucrNudYAxisLabelSize
        '
        Me.ucrNudYAxisLabelSize.AutoSize = True
        Me.ucrNudYAxisLabelSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Location = New System.Drawing.Point(129, 79)
        Me.ucrNudYAxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisLabelSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisLabelSize.Name = "ucrNudYAxisLabelSize"
        Me.ucrNudYAxisLabelSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisLabelSize.TabIndex = 8
        Me.ucrNudYAxisLabelSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudYAxisAngle
        '
        Me.ucrNudYAxisAngle.AutoSize = True
        Me.ucrNudYAxisAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudYAxisAngle.Location = New System.Drawing.Point(129, 52)
        Me.ucrNudYAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudYAxisAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudYAxisAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudYAxisAngle.Name = "ucrNudYAxisAngle"
        Me.ucrNudYAxisAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudYAxisAngle.TabIndex = 6
        Me.ucrNudYAxisAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputDateDisplayFormat
        '
        Me.ucrInputDateDisplayFormat.AddQuotesIfUnrecognised = True
        Me.ucrInputDateDisplayFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateDisplayFormat.GetSetSelectedIndex = -1
        Me.ucrInputDateDisplayFormat.IsReadOnly = False
        Me.ucrInputDateDisplayFormat.Location = New System.Drawing.Point(375, 22)
        Me.ucrInputDateDisplayFormat.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputDateDisplayFormat.Name = "ucrInputDateDisplayFormat"
        Me.ucrInputDateDisplayFormat.Size = New System.Drawing.Size(110, 21)
        Me.ucrInputDateDisplayFormat.TabIndex = 4
        '
        'lblDateDisplayFormat
        '
        Me.lblDateDisplayFormat.AutoSize = True
        Me.lblDateDisplayFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblDateDisplayFormat.Location = New System.Drawing.Point(258, 27)
        Me.lblDateDisplayFormat.Name = "lblDateDisplayFormat"
        Me.lblDateDisplayFormat.Size = New System.Drawing.Size(79, 13)
        Me.lblDateDisplayFormat.TabIndex = 3
        Me.lblDateDisplayFormat.Text = "Display Format:"
        '
        'ucrChkYAxisLabelSize
        '
        Me.ucrChkYAxisLabelSize.AutoSize = True
        Me.ucrChkYAxisLabelSize.Checked = False
        Me.ucrChkYAxisLabelSize.Location = New System.Drawing.Point(8, 82)
        Me.ucrChkYAxisLabelSize.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYAxisLabelSize.Name = "ucrChkYAxisLabelSize"
        Me.ucrChkYAxisLabelSize.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkYAxisLabelSize.TabIndex = 7
        '
        'ucrChkYAxisAngle
        '
        Me.ucrChkYAxisAngle.AutoSize = True
        Me.ucrChkYAxisAngle.Checked = False
        Me.ucrChkYAxisAngle.Location = New System.Drawing.Point(8, 53)
        Me.ucrChkYAxisAngle.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrChkYAxisAngle.Name = "ucrChkYAxisAngle"
        Me.ucrChkYAxisAngle.Size = New System.Drawing.Size(75, 23)
        Me.ucrChkYAxisAngle.TabIndex = 5
        '
        'ucrNudDateBreakNumber
        '
        Me.ucrNudDateBreakNumber.AutoSize = True
        Me.ucrNudDateBreakNumber.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Location = New System.Drawing.Point(145, 23)
        Me.ucrNudDateBreakNumber.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrNudDateBreakNumber.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDateBreakNumber.Name = "ucrNudDateBreakNumber"
        Me.ucrNudDateBreakNumber.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudDateBreakNumber.TabIndex = 1
        Me.ucrNudDateBreakNumber.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputDateBreakTime
        '
        Me.ucrInputDateBreakTime.AddQuotesIfUnrecognised = True
        Me.ucrInputDateBreakTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDateBreakTime.GetSetSelectedIndex = -1
        Me.ucrInputDateBreakTime.IsReadOnly = False
        Me.ucrInputDateBreakTime.Location = New System.Drawing.Point(197, 23)
        Me.ucrInputDateBreakTime.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ucrInputDateBreakTime.Name = "ucrInputDateBreakTime"
        Me.ucrInputDateBreakTime.Size = New System.Drawing.Size(56, 21)
        Me.ucrInputDateBreakTime.TabIndex = 2
        '
        'tpLegend
        '
        Me.tpLegend.Controls.Add(Me.ucrInputLegendPosition)
        Me.tpLegend.Controls.Add(Me.ucrChkLegendPosition)
        Me.tpLegend.Location = New System.Drawing.Point(4, 22)
        Me.tpLegend.Name = "tpLegend"
        Me.tpLegend.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLegend.Size = New System.Drawing.Size(507, 271)
        Me.tpLegend.TabIndex = 3
        Me.tpLegend.Text = "Legend"
        Me.tpLegend.UseVisualStyleBackColor = True
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(156, 16)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputLegendPosition.TabIndex = 1
        '
        'ucrChkLegendPosition
        '
        Me.ucrChkLegendPosition.AutoSize = True
        Me.ucrChkLegendPosition.Checked = False
        Me.ucrChkLegendPosition.Location = New System.Drawing.Point(12, 18)
        Me.ucrChkLegendPosition.Name = "ucrChkLegendPosition"
        Me.ucrChkLegendPosition.Size = New System.Drawing.Size(204, 23)
        Me.ucrChkLegendPosition.TabIndex = 0
        '
        'ttInventoryPlot
        '
        Me.ttInventoryPlot.AutoPopDelay = 10000
        Me.ttInventoryPlot.InitialDelay = 500
        Me.ttInventoryPlot.ReshowDelay = 100
        '
        'ucrButtonsInventoryplot
        '
        Me.ucrButtonsInventoryplot.AutoSize = True
        Me.ucrButtonsInventoryplot.Location = New System.Drawing.Point(197, 307)
        Me.ucrButtonsInventoryplot.Name = "ucrButtonsInventoryplot"
        Me.ucrButtonsInventoryplot.Size = New System.Drawing.Size(224, 30)
        Me.ucrButtonsInventoryplot.TabIndex = 1
        '
        'sdgInventoryPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(537, 341)
        Me.Controls.Add(Me.tbInventory)
        Me.Controls.Add(Me.ucrButtonsInventoryplot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgInventoryPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inventory Plot"
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
        Me.tpLegend.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
