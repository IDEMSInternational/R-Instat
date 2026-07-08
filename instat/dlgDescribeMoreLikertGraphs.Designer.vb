<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgDescribeTwoVariableMoreLikertGraphs
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLevelsWarning = New System.Windows.Forms.Label()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cmdPlotOptions = New System.Windows.Forms.Button()
        Me.cmdLikertOptions = New System.Windows.Forms.Button()
        Me.grpLabels = New System.Windows.Forms.GroupBox()
        Me.ucrChkWrap = New instat.ucrCheck()
        Me.ucrNudWrap = New instat.ucrNud()
        Me.ucrChkValues = New instat.ucrCheck()
        Me.ucrChkTotals = New instat.ucrCheck()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.rdoLikert = New System.Windows.Forms.RadioButton()
        Me.rdoStacked = New System.Windows.Forms.RadioButton()
        Me.rdoSide = New System.Windows.Forms.RadioButton()
        Me.ucrPnlChartType = New instat.UcrPanel()
        Me.lblCutoffLevel = New System.Windows.Forms.Label()
        Me.ucrNudCutoffLevel = New instat.ucrNud()
        Me.lblExclude = New System.Windows.Forms.Label()
        Me.ucrNudExclude = New instat.ucrNud()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorGGLikert = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverMultipleGGLikert = New instat.ucrReceiverMultiple()
        Me.ucrChkReverse = New instat.ucrCheck()
        Me.ucrChkSymmetric = New instat.ucrCheck()
        Me.ucrChkCutoff = New instat.ucrCheck()
        Me.ucrNudCutoff = New instat.ucrNud()
        Me.ucrChkSort = New instat.ucrCheck()
        Me.ucrChkDescending = New instat.ucrCheck()
        Me.ucrSaveGGLikert = New instat.ucrSave()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpLabels.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblLevelsWarning
        '
        Me.lblLevelsWarning.ForeColor = System.Drawing.Color.Red
        Me.lblLevelsWarning.Location = New System.Drawing.Point(290, 238)
        Me.lblLevelsWarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLevelsWarning.Name = "lblLevelsWarning"
        Me.lblLevelsWarning.Size = New System.Drawing.Size(254, 40)
        Me.lblLevelsWarning.TabIndex = 7
        Me.lblLevelsWarning.Text = "All factors must have the same number of levels."
        Me.lblLevelsWarning.Visible = False
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(290, 52)
        Me.lblFactors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(55, 16)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Text = "Factors:"
        '
        'cmdPlotOptions
        '
        Me.cmdPlotOptions.Location = New System.Drawing.Point(11, 245)
        Me.cmdPlotOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPlotOptions.Name = "cmdPlotOptions"
        Me.cmdPlotOptions.Size = New System.Drawing.Size(185, 29)
        Me.cmdPlotOptions.TabIndex = 4
        Me.cmdPlotOptions.Text = "Plot Options"
        Me.cmdPlotOptions.UseVisualStyleBackColor = True
        '
        'cmdLikertOptions
        '
        Me.cmdLikertOptions.Enabled = False
        Me.cmdLikertOptions.Location = New System.Drawing.Point(11, 280)
        Me.cmdLikertOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLikertOptions.Name = "cmdLikertOptions"
        Me.cmdLikertOptions.Size = New System.Drawing.Size(185, 29)
        Me.cmdLikertOptions.TabIndex = 5
        Me.cmdLikertOptions.Text = "Likert Options"
        Me.cmdLikertOptions.UseVisualStyleBackColor = True
        '
        'grpLabels
        '
        Me.grpLabels.Controls.Add(Me.ucrChkWrap)
        Me.grpLabels.Controls.Add(Me.ucrNudWrap)
        Me.grpLabels.Controls.Add(Me.ucrChkValues)
        Me.grpLabels.Controls.Add(Me.ucrChkTotals)
        Me.grpLabels.Location = New System.Drawing.Point(290, 278)
        Me.grpLabels.Margin = New System.Windows.Forms.Padding(4)
        Me.grpLabels.Name = "grpLabels"
        Me.grpLabels.Padding = New System.Windows.Forms.Padding(5)
        Me.grpLabels.Size = New System.Drawing.Size(254, 130)
        Me.grpLabels.TabIndex = 3
        Me.grpLabels.TabStop = False
        Me.grpLabels.Text = "Labels"
        '
        'ucrChkWrap
        '
        Me.ucrChkWrap.AutoSize = True
        Me.ucrChkWrap.Checked = False
        Me.ucrChkWrap.Location = New System.Drawing.Point(8, 22)
        Me.ucrChkWrap.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkWrap.Name = "ucrChkWrap"
        Me.ucrChkWrap.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkWrap.TabIndex = 0
        '
        'ucrNudWrap
        '
        Me.ucrNudWrap.AutoSize = True
        Me.ucrNudWrap.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudWrap.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudWrap.Location = New System.Drawing.Point(140, 22)
        Me.ucrNudWrap.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudWrap.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.ucrNudWrap.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.ucrNudWrap.Name = "ucrNudWrap"
        Me.ucrNudWrap.Size = New System.Drawing.Size(69, 25)
        Me.ucrNudWrap.TabIndex = 1
        Me.ucrNudWrap.Value = New Decimal(New Integer() {25, 0, 0, 0})
        Me.ucrNudWrap.Visible = False
        '
        'ucrChkValues
        '
        Me.ucrChkValues.AutoSize = True
        Me.ucrChkValues.Checked = True
        Me.ucrChkValues.Location = New System.Drawing.Point(8, 58)
        Me.ucrChkValues.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkValues.Name = "ucrChkValues"
        Me.ucrChkValues.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkValues.TabIndex = 2
        '
        'ucrChkTotals
        '
        Me.ucrChkTotals.AutoSize = True
        Me.ucrChkTotals.Checked = True
        Me.ucrChkTotals.Location = New System.Drawing.Point(8, 92)
        Me.ucrChkTotals.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkTotals.Name = "ucrChkTotals"
        Me.ucrChkTotals.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkTotals.TabIndex = 3
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.rdoLikert)
        Me.grpType.Controls.Add(Me.rdoStacked)
        Me.grpType.Controls.Add(Me.rdoSide)
        Me.grpType.Controls.Add(Me.ucrPnlChartType)
        Me.grpType.Controls.Add(Me.lblCutoffLevel)
        Me.grpType.Controls.Add(Me.ucrNudCutoffLevel)
        Me.grpType.Controls.Add(Me.lblExclude)
        Me.grpType.Controls.Add(Me.ucrNudExclude)
        Me.grpType.Location = New System.Drawing.Point(11, 442)
        Me.grpType.Margin = New System.Windows.Forms.Padding(4)
        Me.grpType.Name = "grpType"
        Me.grpType.Padding = New System.Windows.Forms.Padding(5)
        Me.grpType.Size = New System.Drawing.Size(533, 58)
        Me.grpType.TabIndex = 20
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type"
        '
        'rdoLikert
        '
        Me.rdoLikert.AutoSize = True
        Me.rdoLikert.Checked = True
        Me.rdoLikert.Location = New System.Drawing.Point(8, 24)
        Me.rdoLikert.Name = "rdoLikert"
        Me.rdoLikert.Size = New System.Drawing.Size(60, 20)
        Me.rdoLikert.TabIndex = 0
        Me.rdoLikert.TabStop = True
        Me.rdoLikert.Text = "Likert"
        Me.rdoLikert.UseVisualStyleBackColor = True
        '
        'rdoStacked
        '
        Me.rdoStacked.AutoSize = True
        Me.rdoStacked.Location = New System.Drawing.Point(73, 24)
        Me.rdoStacked.Name = "rdoStacked"
        Me.rdoStacked.Size = New System.Drawing.Size(78, 20)
        Me.rdoStacked.TabIndex = 1
        Me.rdoStacked.Text = "Stacked"
        Me.rdoStacked.UseVisualStyleBackColor = True
        '
        'rdoSide
        '
        Me.rdoSide.AutoSize = True
        Me.rdoSide.Location = New System.Drawing.Point(155, 24)
        Me.rdoSide.Name = "rdoSide"
        Me.rdoSide.Size = New System.Drawing.Size(56, 20)
        Me.rdoSide.TabIndex = 2
        Me.rdoSide.Text = "Side"
        Me.rdoSide.UseVisualStyleBackColor = True
        '
        'ucrPnlChartType
        '
        Me.ucrPnlChartType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlChartType.Location = New System.Drawing.Point(5, 18)
        Me.ucrPnlChartType.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlChartType.Name = "ucrPnlChartType"
        Me.ucrPnlChartType.Size = New System.Drawing.Size(242, 30)
        Me.ucrPnlChartType.TabIndex = 0
        '
        'lblCutoffLevel
        '
        Me.lblCutoffLevel.AutoSize = True
        Me.lblCutoffLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblCutoffLevel.Location = New System.Drawing.Point(379, 24)
        Me.lblCutoffLevel.Name = "lblCutoffLevel"
        Me.lblCutoffLevel.Size = New System.Drawing.Size(60, 16)
        Me.lblCutoffLevel.TabIndex = 3
        Me.lblCutoffLevel.Text = "Cutoff at: "
        Me.lblCutoffLevel.Visible = False
        '
        'ucrNudCutoffLevel
        '
        Me.ucrNudCutoffLevel.AutoSize = True
        Me.ucrNudCutoffLevel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoffLevel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoffLevel.Location = New System.Drawing.Point(446, 21)
        Me.ucrNudCutoffLevel.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudCutoffLevel.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ucrNudCutoffLevel.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoffLevel.Name = "ucrNudCutoffLevel"
        Me.ucrNudCutoffLevel.Size = New System.Drawing.Size(55, 25)
        Me.ucrNudCutoffLevel.TabIndex = 4
        Me.ucrNudCutoffLevel.Value = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ucrNudCutoffLevel.Visible = False
        '
        'lblExclude
        '
        Me.lblExclude.AutoSize = True
        Me.lblExclude.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExclude.Location = New System.Drawing.Point(257, 24)
        Me.lblExclude.Name = "lblExclude"
        Me.lblExclude.Size = New System.Drawing.Size(58, 16)
        Me.lblExclude.TabIndex = 5
        Me.lblExclude.Text = "Exclude:"
        '
        'ucrNudExclude
        '
        Me.ucrNudExclude.AutoSize = True
        Me.ucrNudExclude.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudExclude.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudExclude.Location = New System.Drawing.Point(317, 21)
        Me.ucrNudExclude.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrNudExclude.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.ucrNudExclude.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudExclude.Name = "ucrNudExclude"
        Me.ucrNudExclude.Size = New System.Drawing.Size(55, 25)
        Me.ucrNudExclude.TabIndex = 6
        Me.ucrNudExclude.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(270, 508)
        Me.lblFacetBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(63, 16)
        Me.lblFacetBy.TabIndex = 27
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(118, 504)
        Me.ucrInputLegendPosition.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(140, 26)
        Me.ucrInputLegendPosition.TabIndex = 75
        Me.ucrInputLegendPosition.Visible = False
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(11, 503)
        Me.ucrChkLegend.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(122, 30)
        Me.ucrChkLegend.TabIndex = 74
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(448, 503)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(11)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(100, 26)
        Me.ucrInputStation.TabIndex = 29
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(340, 501)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(100, 32)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 28
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrSelectorGGLikert
        '
        Me.ucrSelectorGGLikert.AutoSize = True
        Me.ucrSelectorGGLikert.bDropUnusedFilterLevels = False
        Me.ucrSelectorGGLikert.bShowHiddenColumns = False
        Me.ucrSelectorGGLikert.bUseCurrentFilter = True
        Me.ucrSelectorGGLikert.Location = New System.Drawing.Point(11, 12)
        Me.ucrSelectorGGLikert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGGLikert.Name = "ucrSelectorGGLikert"
        Me.ucrSelectorGGLikert.Size = New System.Drawing.Size(266, 229)
        Me.ucrSelectorGGLikert.TabIndex = 0
        '
        'ucrReceiverMultipleGGLikert
        '
        Me.ucrReceiverMultipleGGLikert.AutoSize = True
        Me.ucrReceiverMultipleGGLikert.frmParent = Me
        Me.ucrReceiverMultipleGGLikert.Location = New System.Drawing.Point(290, 75)
        Me.ucrReceiverMultipleGGLikert.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultipleGGLikert.Name = "ucrReceiverMultipleGGLikert"
        Me.ucrReceiverMultipleGGLikert.Selector = Nothing
        Me.ucrReceiverMultipleGGLikert.Size = New System.Drawing.Size(182, 162)
        Me.ucrReceiverMultipleGGLikert.strNcFilePath = ""
        Me.ucrReceiverMultipleGGLikert.TabIndex = 2
        Me.ucrReceiverMultipleGGLikert.ucrSelector = Nothing
        '
        'ucrChkReverse
        '
        Me.ucrChkReverse.AutoSize = True
        Me.ucrChkReverse.Checked = False
        Me.ucrChkReverse.Location = New System.Drawing.Point(11, 318)
        Me.ucrChkReverse.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkReverse.Name = "ucrChkReverse"
        Me.ucrChkReverse.Size = New System.Drawing.Size(185, 29)
        Me.ucrChkReverse.TabIndex = 10
        '
        'ucrChkSymmetric
        '
        Me.ucrChkSymmetric.AutoSize = True
        Me.ucrChkSymmetric.Checked = False
        Me.ucrChkSymmetric.Location = New System.Drawing.Point(11, 350)
        Me.ucrChkSymmetric.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkSymmetric.Name = "ucrChkSymmetric"
        Me.ucrChkSymmetric.Size = New System.Drawing.Size(185, 29)
        Me.ucrChkSymmetric.TabIndex = 11
        '
        'ucrChkCutoff
        '
        Me.ucrChkCutoff.AutoSize = True
        Me.ucrChkCutoff.Checked = False
        Me.ucrChkCutoff.Location = New System.Drawing.Point(11, 382)
        Me.ucrChkCutoff.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkCutoff.Name = "ucrChkCutoff"
        Me.ucrChkCutoff.Size = New System.Drawing.Size(122, 29)
        Me.ucrChkCutoff.TabIndex = 12
        '
        'ucrNudCutoff
        '
        Me.ucrNudCutoff.AutoSize = True
        Me.ucrNudCutoff.DecimalPlaces = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCutoff.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ucrNudCutoff.Location = New System.Drawing.Point(144, 382)
        Me.ucrNudCutoff.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudCutoff.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.ucrNudCutoff.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Name = "ucrNudCutoff"
        Me.ucrNudCutoff.Size = New System.Drawing.Size(69, 25)
        Me.ucrNudCutoff.TabIndex = 13
        Me.ucrNudCutoff.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCutoff.Visible = False
        '
        'ucrChkSort
        '
        Me.ucrChkSort.AutoSize = True
        Me.ucrChkSort.Checked = False
        Me.ucrChkSort.Location = New System.Drawing.Point(11, 414)
        Me.ucrChkSort.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkSort.Name = "ucrChkSort"
        Me.ucrChkSort.Size = New System.Drawing.Size(120, 29)
        Me.ucrChkSort.TabIndex = 14
        '
        'ucrChkDescending
        '
        Me.ucrChkDescending.AutoSize = True
        Me.ucrChkDescending.Checked = False
        Me.ucrChkDescending.Enabled = False
        Me.ucrChkDescending.Location = New System.Drawing.Point(139, 414)
        Me.ucrChkDescending.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDescending.Name = "ucrChkDescending"
        Me.ucrChkDescending.Size = New System.Drawing.Size(121, 29)
        Me.ucrChkDescending.TabIndex = 15
        '
        'ucrSaveGGLikert
        '
        Me.ucrSaveGGLikert.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGGLikert.Location = New System.Drawing.Point(11, 539)
        Me.ucrSaveGGLikert.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ucrSaveGGLikert.Name = "ucrSaveGGLikert"
        Me.ucrSaveGGLikert.Size = New System.Drawing.Size(451, 30)
        Me.ucrSaveGGLikert.TabIndex = 17
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(11, 577)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 18
        '
        'dlgDescribeTwoVariableMoreLikertGraphs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(560, 647)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrSelectorGGLikert)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverMultipleGGLikert)
        Me.Controls.Add(Me.lblLevelsWarning)
        Me.Controls.Add(Me.grpLabels)
        Me.Controls.Add(Me.cmdPlotOptions)
        Me.Controls.Add(Me.cmdLikertOptions)
        Me.Controls.Add(Me.ucrChkReverse)
        Me.Controls.Add(Me.ucrChkSymmetric)
        Me.Controls.Add(Me.ucrChkCutoff)
        Me.Controls.Add(Me.ucrNudCutoff)
        Me.Controls.Add(Me.ucrChkSort)
        Me.Controls.Add(Me.ucrChkDescending)
        Me.Controls.Add(Me.grpType)
        Me.Controls.Add(Me.ucrSaveGGLikert)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescribeTwoVariableMoreLikertGraphs"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More Likert Graph (gglikert)"
        Me.grpLabels.ResumeLayout(False)
        Me.grpLabels.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorGGLikert As instat.ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactors As System.Windows.Forms.Label
    Friend WithEvents ucrReceiverMultipleGGLikert As instat.ucrReceiverMultiple
    Friend WithEvents cmdPlotOptions As System.Windows.Forms.Button
    Friend WithEvents cmdLikertOptions As System.Windows.Forms.Button
    Friend WithEvents ucrChkSort As instat.ucrCheck
    Friend WithEvents ucrChkDescending As instat.ucrCheck
    Friend WithEvents ucrChkReverse As instat.ucrCheck
    Friend WithEvents ucrChkSymmetric As instat.ucrCheck
    Friend WithEvents ucrChkCutoff As instat.ucrCheck
    Friend WithEvents ucrNudCutoff As instat.ucrNud
    Friend WithEvents grpLabels As System.Windows.Forms.GroupBox
    Friend WithEvents ucrChkWrap As instat.ucrCheck
    Friend WithEvents ucrNudWrap As instat.ucrNud
    Friend WithEvents ucrChkValues As instat.ucrCheck
    Friend WithEvents ucrChkTotals As instat.ucrCheck
    Friend WithEvents grpType As System.Windows.Forms.GroupBox
    Friend WithEvents ucrPnlChartType As instat.UcrPanel
    Friend WithEvents rdoLikert As System.Windows.Forms.RadioButton
    Friend WithEvents rdoStacked As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSide As System.Windows.Forms.RadioButton
    Friend WithEvents lblCutoffLevel As System.Windows.Forms.Label
    Friend WithEvents ucrNudCutoffLevel As instat.ucrNud
    Friend WithEvents lblExclude As System.Windows.Forms.Label
    Friend WithEvents ucrNudExclude As instat.ucrNud
    Friend WithEvents lblLevelsWarning As System.Windows.Forms.Label
    Friend WithEvents ucrSaveGGLikert As instat.ucrSave
    Friend WithEvents ucrBase As instat.ucrButtons
    Friend WithEvents ucrInputStation As instat.ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As instat.ucrReceiverSingle
    Friend WithEvents lblFacetBy As System.Windows.Forms.Label
    Friend WithEvents ucrInputLegendPosition As instat.ucrInputComboBox
    Friend WithEvents ucrChkLegend As instat.ucrCheck
End Class