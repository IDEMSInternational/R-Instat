' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgHistogram
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
        Me.rdoHistogram = New System.Windows.Forms.RadioButton()
        Me.rdoDensity_ridges = New System.Windows.Forms.RadioButton()
        Me.rdoFrequencyPolygon = New System.Windows.Forms.RadioButton()
        Me.lblfactor = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemHistogramOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemDotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemDensityOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemDensityRidgesOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemFrequencyPolygonOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblReorder = New System.Windows.Forms.Label()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrNudMinHeight = New instat.ucrNud()
        Me.ucrChkMinHeight = New instat.ucrCheck()
        Me.ucrChkOmitYAxis = New instat.ucrCheck()
        Me.ucrChkBinWidth = New instat.ucrCheck()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrInputAddReorder = New instat.ucrInputComboBox()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrChkDisplayAsDotPlot = New instat.ucrCheck()
        Me.ucrChkRidges = New instat.ucrCheck()
        Me.ucrInputStats = New instat.ucrInputComboBox()
        Me.ucrChkPercentages = New instat.ucrCheck()
        Me.ucrSaveHist = New instat.ucrSave()
        Me.ucrVariablesAsFactorforHist = New instat.ucrVariablesAsFactor()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrHistogramSelector = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.ucrInputWidth = New instat.ucrInputTextBox()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoHistogram
        '
        Me.rdoHistogram.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHistogram.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHistogram.FlatAppearance.BorderSize = 2
        Me.rdoHistogram.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHistogram.Location = New System.Drawing.Point(14, 18)
        Me.rdoHistogram.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(218, 42)
        Me.rdoHistogram.TabIndex = 1
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.Tag = "Histogram"
        Me.rdoHistogram.Text = "Histogram"
        Me.rdoHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'rdoDensity_ridges
        '
        Me.rdoDensity_ridges.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDensity_ridges.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity_ridges.FlatAppearance.BorderSize = 2
        Me.rdoDensity_ridges.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity_ridges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDensity_ridges.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity_ridges.Location = New System.Drawing.Point(226, 18)
        Me.rdoDensity_ridges.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDensity_ridges.Name = "rdoDensity_ridges"
        Me.rdoDensity_ridges.Size = New System.Drawing.Size(218, 42)
        Me.rdoDensity_ridges.TabIndex = 2
        Me.rdoDensity_ridges.TabStop = True
        Me.rdoDensity_ridges.Tag = "Density"
        Me.rdoDensity_ridges.Text = "Density/Ridges"
        Me.rdoDensity_ridges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDensity_ridges.UseVisualStyleBackColor = True
        '
        'rdoFrequencyPolygon
        '
        Me.rdoFrequencyPolygon.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrequencyPolygon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyPolygon.FlatAppearance.BorderSize = 2
        Me.rdoFrequencyPolygon.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrequencyPolygon.Location = New System.Drawing.Point(441, 18)
        Me.rdoFrequencyPolygon.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFrequencyPolygon.Name = "rdoFrequencyPolygon"
        Me.rdoFrequencyPolygon.Size = New System.Drawing.Size(218, 42)
        Me.rdoFrequencyPolygon.TabIndex = 3
        Me.rdoFrequencyPolygon.TabStop = True
        Me.rdoFrequencyPolygon.Tag = "Frequency_Polygon"
        Me.rdoFrequencyPolygon.Text = "Frequency Polygon"
        Me.rdoFrequencyPolygon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrequencyPolygon.UseVisualStyleBackColor = True
        '
        'lblfactor
        '
        Me.lblfactor.AutoSize = True
        Me.lblfactor.Location = New System.Drawing.Point(424, 318)
        Me.lblfactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(126, 20)
        Me.lblfactor.TabIndex = 6
        Me.lblfactor.Tag = "Factor_Selected:"
        Me.lblfactor.Text = "Factor Selected:"
        '
        'lblStats
        '
        Me.lblStats.Location = New System.Drawing.Point(14, 414)
        Me.lblStats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(84, 28)
        Me.lblStats.TabIndex = 11
        Me.lblStats.Text = "merge"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemHistogramOptions, Me.toolStripMenuItemDotOptions, Me.toolStripMenuItemDensityOptions, Me.toolStripMenuItemDensityRidgesOptions, Me.toolStripMenuItemFrequencyPolygonOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(305, 196)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(304, 32)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemHistogramOptions
        '
        Me.toolStripMenuItemHistogramOptions.Name = "toolStripMenuItemHistogramOptions"
        Me.toolStripMenuItemHistogramOptions.Size = New System.Drawing.Size(304, 32)
        Me.toolStripMenuItemHistogramOptions.Text = "Histogram Options"
        '
        'toolStripMenuItemDotOptions
        '
        Me.toolStripMenuItemDotOptions.Name = "toolStripMenuItemDotOptions"
        Me.toolStripMenuItemDotOptions.Size = New System.Drawing.Size(304, 32)
        Me.toolStripMenuItemDotOptions.Text = "Dotplot Options"
        '
        'toolStripMenuItemDensityOptions
        '
        Me.toolStripMenuItemDensityOptions.Name = "toolStripMenuItemDensityOptions"
        Me.toolStripMenuItemDensityOptions.Size = New System.Drawing.Size(304, 32)
        Me.toolStripMenuItemDensityOptions.Text = "Density Options"
        '
        'toolStripMenuItemDensityRidgesOptions
        '
        Me.toolStripMenuItemDensityRidgesOptions.Name = "toolStripMenuItemDensityRidgesOptions"
        Me.toolStripMenuItemDensityRidgesOptions.Size = New System.Drawing.Size(304, 32)
        Me.toolStripMenuItemDensityRidgesOptions.Text = "Density Ridges Options"
        '
        'toolStripMenuItemFrequencyPolygonOptions
        '
        Me.toolStripMenuItemFrequencyPolygonOptions.Name = "toolStripMenuItemFrequencyPolygonOptions"
        Me.toolStripMenuItemFrequencyPolygonOptions.Size = New System.Drawing.Size(304, 32)
        Me.toolStripMenuItemFrequencyPolygonOptions.Text = "Frequency Polygon Options"
        '
        'lblReorder
        '
        Me.lblReorder.AutoSize = True
        Me.lblReorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblReorder.Location = New System.Drawing.Point(429, 447)
        Me.lblReorder.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReorder.Name = "lblReorder"
        Me.lblReorder.Size = New System.Drawing.Size(71, 20)
        Me.lblReorder.TabIndex = 38
        Me.lblReorder.Text = "Reorder:"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(312, 501)
        Me.lblFacetBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(76, 20)
        Me.lblFacetBy.TabIndex = 84
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrNudMinHeight
        '
        Me.ucrNudMinHeight.AutoSize = True
        Me.ucrNudMinHeight.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinHeight.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinHeight.Location = New System.Drawing.Point(207, 470)
        Me.ucrNudMinHeight.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudMinHeight.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinHeight.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinHeight.Name = "ucrNudMinHeight"
        Me.ucrNudMinHeight.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudMinHeight.TabIndex = 44
        Me.ucrNudMinHeight.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkMinHeight
        '
        Me.ucrChkMinHeight.AutoSize = True
        Me.ucrChkMinHeight.Checked = False
        Me.ucrChkMinHeight.Location = New System.Drawing.Point(15, 466)
        Me.ucrChkMinHeight.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkMinHeight.Name = "ucrChkMinHeight"
        Me.ucrChkMinHeight.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkMinHeight.TabIndex = 43
        '
        'ucrChkOmitYAxis
        '
        Me.ucrChkOmitYAxis.AutoSize = True
        Me.ucrChkOmitYAxis.Checked = False
        Me.ucrChkOmitYAxis.Location = New System.Drawing.Point(15, 430)
        Me.ucrChkOmitYAxis.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkOmitYAxis.Name = "ucrChkOmitYAxis"
        Me.ucrChkOmitYAxis.Size = New System.Drawing.Size(214, 34)
        Me.ucrChkOmitYAxis.TabIndex = 42
        '
        'ucrChkBinWidth
        '
        Me.ucrChkBinWidth.AutoSize = True
        Me.ucrChkBinWidth.Checked = False
        Me.ucrChkBinWidth.Location = New System.Drawing.Point(15, 393)
        Me.ucrChkBinWidth.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkBinWidth.Name = "ucrChkBinWidth"
        Me.ucrChkBinWidth.Size = New System.Drawing.Size(216, 34)
        Me.ucrChkBinWidth.TabIndex = 40
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(477, 522)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(152, 32)
        Me.ucrInputStation.TabIndex = 86
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(308, 524)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(165, 39)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 85
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(130, 522)
        Me.ucrInputLegendPosition.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(168, 32)
        Me.ucrInputLegendPosition.TabIndex = 88
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(16, 524)
        Me.ucrChkLegend.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(147, 36)
        Me.ucrChkLegend.TabIndex = 87
        '
        'ucrInputAddReorder
        '
        Me.ucrInputAddReorder.AddQuotesIfUnrecognised = True
        Me.ucrInputAddReorder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputAddReorder.GetSetSelectedIndex = -1
        Me.ucrInputAddReorder.IsReadOnly = False
        Me.ucrInputAddReorder.Location = New System.Drawing.Point(430, 471)
        Me.ucrInputAddReorder.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputAddReorder.Name = "ucrInputAddReorder"
        Me.ucrInputAddReorder.Size = New System.Drawing.Size(180, 32)
        Me.ucrInputAddReorder.TabIndex = 39
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(14, 350)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(224, 34)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 10
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkDisplayAsDotPlot
        '
        Me.ucrChkDisplayAsDotPlot.AutoSize = True
        Me.ucrChkDisplayAsDotPlot.Checked = False
        Me.ucrChkDisplayAsDotPlot.Location = New System.Drawing.Point(424, 384)
        Me.ucrChkDisplayAsDotPlot.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkDisplayAsDotPlot.Name = "ucrChkDisplayAsDotPlot"
        Me.ucrChkDisplayAsDotPlot.Size = New System.Drawing.Size(230, 34)
        Me.ucrChkDisplayAsDotPlot.TabIndex = 8
        '
        'ucrChkRidges
        '
        Me.ucrChkRidges.AutoSize = True
        Me.ucrChkRidges.Checked = False
        Me.ucrChkRidges.Location = New System.Drawing.Point(424, 384)
        Me.ucrChkRidges.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkRidges.Name = "ucrChkRidges"
        Me.ucrChkRidges.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkRidges.TabIndex = 15
        '
        'ucrInputStats
        '
        Me.ucrInputStats.AddQuotesIfUnrecognised = True
        Me.ucrInputStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStats.GetSetSelectedIndex = -1
        Me.ucrInputStats.IsReadOnly = False
        Me.ucrInputStats.Location = New System.Drawing.Point(110, 408)
        Me.ucrInputStats.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrInputStats.Name = "ucrInputStats"
        Me.ucrInputStats.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputStats.TabIndex = 12
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.AutoSize = True
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(424, 420)
        Me.ucrChkPercentages.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(150, 34)
        Me.ucrChkPercentages.TabIndex = 9
        '
        'ucrSaveHist
        '
        Me.ucrSaveHist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveHist.Location = New System.Drawing.Point(15, 578)
        Me.ucrSaveHist.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrSaveHist.Name = "ucrSaveHist"
        Me.ucrSaveHist.Size = New System.Drawing.Size(483, 36)
        Me.ucrSaveHist.TabIndex = 13
        '
        'ucrVariablesAsFactorforHist
        '
        Me.ucrVariablesAsFactorforHist.AutoSize = True
        Me.ucrVariablesAsFactorforHist.frmParent = Me
        Me.ucrVariablesAsFactorforHist.Location = New System.Drawing.Point(422, 102)
        Me.ucrVariablesAsFactorforHist.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrVariablesAsFactorforHist.Name = "ucrVariablesAsFactorforHist"
        Me.ucrVariablesAsFactorforHist.Selector = Nothing
        Me.ucrVariablesAsFactorforHist.Size = New System.Drawing.Size(188, 204)
        Me.ucrVariablesAsFactorforHist.strNcFilePath = ""
        Me.ucrVariablesAsFactorforHist.TabIndex = 5
        Me.ucrVariablesAsFactorforHist.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforHist.ucrVariableSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.AutoSize = True
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(424, 342)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(184, 30)
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.TabIndex = 7
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'ucrHistogramSelector
        '
        Me.ucrHistogramSelector.AutoSize = True
        Me.ucrHistogramSelector.bDropUnusedFilterLevels = False
        Me.ucrHistogramSelector.bShowHiddenColumns = False
        Me.ucrHistogramSelector.bUseCurrentFilter = True
        Me.ucrHistogramSelector.Location = New System.Drawing.Point(15, 72)
        Me.ucrHistogramSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrHistogramSelector.Name = "ucrHistogramSelector"
        Me.ucrHistogramSelector.Size = New System.Drawing.Size(321, 274)
        Me.ucrHistogramSelector.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 612)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 14
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(12, 16)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(650, 45)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'ucrInputWidth
        '
        Me.ucrInputWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputWidth.AutoSize = True
        Me.ucrInputWidth.IsMultiline = False
        Me.ucrInputWidth.IsReadOnly = False
        Me.ucrInputWidth.Location = New System.Drawing.Point(209, 393)
        Me.ucrInputWidth.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputWidth.Name = "ucrInputWidth"
        Me.ucrInputWidth.Size = New System.Drawing.Size(104, 32)
        Me.ucrInputWidth.TabIndex = 89
        '
        'dlgHistogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(672, 692)
        Me.Controls.Add(Me.ucrInputWidth)
        Me.Controls.Add(Me.ucrNudMinHeight)
        Me.Controls.Add(Me.ucrChkOmitYAxis)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.lblReorder)
        Me.Controls.Add(Me.ucrInputAddReorder)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrChkDisplayAsDotPlot)
        Me.Controls.Add(Me.ucrChkRidges)
        Me.Controls.Add(Me.lblStats)
        Me.Controls.Add(Me.ucrInputStats)
        Me.Controls.Add(Me.ucrChkPercentages)
        Me.Controls.Add(Me.ucrSaveHist)
        Me.Controls.Add(Me.ucrVariablesAsFactorforHist)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.rdoFrequencyPolygon)
        Me.Controls.Add(Me.rdoDensity_ridges)
        Me.Controls.Add(Me.rdoHistogram)
        Me.Controls.Add(Me.ucrHistogramSelector)
        Me.Controls.Add(Me.lblfactor)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrChkMinHeight)
        Me.Controls.Add(Me.ucrChkBinWidth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgHistogram"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Histogram"
        Me.Text = "Histogram Plot"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrHistogramSelector As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoHistogram As RadioButton
    Friend WithEvents rdoDensity_ridges As RadioButton
    Friend WithEvents rdoFrequencyPolygon As RadioButton
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblfactor As Label
    Friend WithEvents ucrVariablesAsFactorforHist As ucrVariablesAsFactor
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSaveHist As ucrSave
    Friend WithEvents ucrInputStats As ucrInputComboBox
    Friend WithEvents ucrChkPercentages As ucrCheck
    Friend WithEvents lblStats As Label
    Friend WithEvents ucrChkRidges As ucrCheck
    Friend WithEvents ucrChkDisplayAsDotPlot As ucrCheck
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemHistogramOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemDensityOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemDensityRidgesOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemFrequencyPolygonOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemDotOptions As ToolStripMenuItem
    Friend WithEvents lblReorder As Label
    Friend WithEvents ucrInputAddReorder As ucrInputComboBox

    Friend WithEvents ucrChkBinWidth As ucrCheck
    Friend WithEvents ucrChkOmitYAxis As ucrCheck
    Friend WithEvents ucrNudMinHeight As ucrNud
    Friend WithEvents ucrChkMinHeight As ucrCheck

    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrInputWidth As ucrInputTextBox
End Class