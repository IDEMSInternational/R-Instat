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
Partial Class dlgBoxplot
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
        Me.lblByFactors = New System.Windows.Forms.Label()
        Me.lblBySecondFactor = New System.Windows.Forms.Label()
        Me.rdoBoxplotTufte = New System.Windows.Forms.RadioButton()
        Me.rdoJitter = New System.Windows.Forms.RadioButton()
        Me.rdoViolin = New System.Windows.Forms.RadioButton()
        Me.lblJitter = New System.Windows.Forms.Label()
        Me.lblTransparency = New System.Windows.Forms.Label()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemBoxOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemJitterOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemSummaryOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemTufteOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemViolinOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTextOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.ucrNudBoxPlot = New instat.ucrNud()
        Me.ucrChkBoxPlot = New instat.ucrCheck()
        Me.ucrInputWidth = New instat.ucrInputTextBox()
        Me.ucrChkWidth = New instat.ucrCheck()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrInputSummaries = New instat.ucrInputComboBox()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrChkTufte = New instat.ucrCheck()
        Me.ucrChkGrouptoConnect = New instat.ucrCheck()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrNudJitter = New instat.ucrNud()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrSaveBoxplot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrVariablesAsFactorForBoxplot = New instat.ucrVariablesAsFactor()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.ucrNudOutlierCoefficient = New instat.ucrNud()
        Me.lblOutlierCoefficient = New System.Windows.Forms.Label()
        Me.ucrSelectorBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblByFactors.Location = New System.Drawing.Point(408, 308)
        Me.lblByFactors.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(124, 20)
        Me.lblByFactors.TabIndex = 6
        Me.lblByFactors.Tag = "By_Factor:"
        Me.lblByFactors.Text = "Factor (Usually):"
        '
        'lblBySecondFactor
        '
        Me.lblBySecondFactor.AutoSize = True
        Me.lblBySecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBySecondFactor.Location = New System.Drawing.Point(408, 374)
        Me.lblBySecondFactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBySecondFactor.Name = "lblBySecondFactor"
        Me.lblBySecondFactor.Size = New System.Drawing.Size(191, 20)
        Me.lblBySecondFactor.TabIndex = 8
        Me.lblBySecondFactor.Tag = "By_Second_Factor:"
        Me.lblBySecondFactor.Text = "Second Factor (Optional):"
        '
        'rdoBoxplotTufte
        '
        Me.rdoBoxplotTufte.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBoxplotTufte.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplotTufte.FlatAppearance.BorderSize = 2
        Me.rdoBoxplotTufte.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoxplotTufte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBoxplotTufte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoBoxplotTufte.Location = New System.Drawing.Point(26, 20)
        Me.rdoBoxplotTufte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoBoxplotTufte.Name = "rdoBoxplotTufte"
        Me.rdoBoxplotTufte.Size = New System.Drawing.Size(200, 40)
        Me.rdoBoxplotTufte.TabIndex = 1
        Me.rdoBoxplotTufte.TabStop = True
        Me.rdoBoxplotTufte.Text = "Boxplot"
        Me.rdoBoxplotTufte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoBoxplotTufte.UseVisualStyleBackColor = True
        '
        'rdoJitter
        '
        Me.rdoJitter.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoJitter.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatAppearance.BorderSize = 2
        Me.rdoJitter.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoJitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoJitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoJitter.Location = New System.Drawing.Point(222, 20)
        Me.rdoJitter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.Size = New System.Drawing.Size(194, 40)
        Me.rdoJitter.TabIndex = 2
        Me.rdoJitter.TabStop = True
        Me.rdoJitter.Text = "Jitter Plot"
        Me.rdoJitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoJitter.UseVisualStyleBackColor = True
        '
        'rdoViolin
        '
        Me.rdoViolin.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoViolin.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatAppearance.BorderSize = 2
        Me.rdoViolin.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoViolin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoViolin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoViolin.Location = New System.Drawing.Point(412, 20)
        Me.rdoViolin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(202, 40)
        Me.rdoViolin.TabIndex = 3
        Me.rdoViolin.TabStop = True
        Me.rdoViolin.Text = "Violin Plot"
        Me.rdoViolin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoViolin.UseVisualStyleBackColor = True
        '
        'lblJitter
        '
        Me.lblJitter.AutoSize = True
        Me.lblJitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblJitter.Location = New System.Drawing.Point(192, 540)
        Me.lblJitter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblJitter.Name = "lblJitter"
        Me.lblJitter.Size = New System.Drawing.Size(48, 20)
        Me.lblJitter.TabIndex = 18
        Me.lblJitter.Tag = "By_Factor:"
        Me.lblJitter.Text = "Jitter:"
        '
        'lblTransparency
        '
        Me.lblTransparency.AutoSize = True
        Me.lblTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTransparency.Location = New System.Drawing.Point(334, 538)
        Me.lblTransparency.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Size = New System.Drawing.Size(109, 20)
        Me.lblTransparency.TabIndex = 20
        Me.lblTransparency.Tag = "By_Factor:"
        Me.lblTransparency.Text = "Transparency:"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemBoxOptions, Me.toolStripMenuItemJitterOptions, Me.toolStripMenuItemSummaryOptions, Me.toolStripMenuItemTufteOptions, Me.toolStripMenuItemViolinOptions, Me.ToolStripMenuItemTextOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(230, 228)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(229, 32)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemBoxOptions
        '
        Me.toolStripMenuItemBoxOptions.Name = "toolStripMenuItemBoxOptions"
        Me.toolStripMenuItemBoxOptions.Size = New System.Drawing.Size(229, 32)
        Me.toolStripMenuItemBoxOptions.Text = "Boxplot Options"
        '
        'toolStripMenuItemJitterOptions
        '
        Me.toolStripMenuItemJitterOptions.Name = "toolStripMenuItemJitterOptions"
        Me.toolStripMenuItemJitterOptions.Size = New System.Drawing.Size(229, 32)
        Me.toolStripMenuItemJitterOptions.Text = "Jitter Options"
        '
        'toolStripMenuItemSummaryOptions
        '
        Me.toolStripMenuItemSummaryOptions.Name = "toolStripMenuItemSummaryOptions"
        Me.toolStripMenuItemSummaryOptions.Size = New System.Drawing.Size(229, 32)
        Me.toolStripMenuItemSummaryOptions.Text = "Summary Options"
        '
        'toolStripMenuItemTufteOptions
        '
        Me.toolStripMenuItemTufteOptions.Name = "toolStripMenuItemTufteOptions"
        Me.toolStripMenuItemTufteOptions.Size = New System.Drawing.Size(229, 32)
        Me.toolStripMenuItemTufteOptions.Text = "Tufte Options"
        '
        'toolStripMenuItemViolinOptions
        '
        Me.toolStripMenuItemViolinOptions.Name = "toolStripMenuItemViolinOptions"
        Me.toolStripMenuItemViolinOptions.Size = New System.Drawing.Size(229, 32)
        Me.toolStripMenuItemViolinOptions.Text = "Violin Options"
        '
        'ToolStripMenuItemTextOptions
        '
        Me.ToolStripMenuItemTextOptions.Name = "ToolStripMenuItemTextOptions"
        Me.ToolStripMenuItemTextOptions.Size = New System.Drawing.Size(229, 32)
        Me.ToolStripMenuItemTextOptions.Text = "Text Options"
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(333, 600)
        Me.lblFacetBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(76, 20)
        Me.lblFacetBy.TabIndex = 24
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWidth.Location = New System.Drawing.Point(188, 502)
        Me.lblWidth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(54, 20)
        Me.lblWidth.TabIndex = 33
        Me.lblWidth.Tag = "By_Factor:"
        Me.lblWidth.Text = "Width:"
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.AutoSize = True
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(15, 498)
        Me.ucrChkLabel.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(182, 34)
        Me.ucrChkLabel.TabIndex = 34
        '
        'ucrNudBoxPlot
        '
        Me.ucrNudBoxPlot.AutoSize = True
        Me.ucrNudBoxPlot.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBoxPlot.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBoxPlot.Location = New System.Drawing.Point(248, 498)
        Me.ucrNudBoxPlot.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudBoxPlot.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBoxPlot.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBoxPlot.Name = "ucrNudBoxPlot"
        Me.ucrNudBoxPlot.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudBoxPlot.TabIndex = 32
        Me.ucrNudBoxPlot.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkBoxPlot
        '
        Me.ucrChkBoxPlot.AutoSize = True
        Me.ucrChkBoxPlot.Checked = False
        Me.ucrChkBoxPlot.Location = New System.Drawing.Point(15, 501)
        Me.ucrChkBoxPlot.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkBoxPlot.Name = "ucrChkBoxPlot"
        Me.ucrChkBoxPlot.Size = New System.Drawing.Size(171, 34)
        Me.ucrChkBoxPlot.TabIndex = 31
        '
        'ucrInputWidth
        '
        Me.ucrInputWidth.AddQuotesIfUnrecognised = True
        Me.ucrInputWidth.AutoSize = True
        Me.ucrInputWidth.IsMultiline = False
        Me.ucrInputWidth.IsReadOnly = False
        Me.ucrInputWidth.Location = New System.Drawing.Point(195, 464)
        Me.ucrInputWidth.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputWidth.Name = "ucrInputWidth"
        Me.ucrInputWidth.Size = New System.Drawing.Size(104, 32)
        Me.ucrInputWidth.TabIndex = 30
        '
        'ucrChkWidth
        '
        Me.ucrChkWidth.AutoSize = True
        Me.ucrChkWidth.Checked = False
        Me.ucrChkWidth.Location = New System.Drawing.Point(15, 465)
        Me.ucrChkWidth.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkWidth.Name = "ucrChkWidth"
        Me.ucrChkWidth.Size = New System.Drawing.Size(182, 34)
        Me.ucrChkWidth.TabIndex = 29
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(484, 621)
        Me.ucrInputStation.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(147, 32)
        Me.ucrInputStation.TabIndex = 26
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(333, 622)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(147, 39)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 25
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(158, 621)
        Me.ucrInputLegendPosition.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(168, 32)
        Me.ucrInputLegendPosition.TabIndex = 28
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(15, 618)
        Me.ucrChkLegend.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(147, 36)
        Me.ucrChkLegend.TabIndex = 27
        '
        'ucrInputSummaries
        '
        Me.ucrInputSummaries.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummaries.GetSetSelectedIndex = -1
        Me.ucrInputSummaries.IsReadOnly = False
        Me.ucrInputSummaries.Location = New System.Drawing.Point(195, 424)
        Me.ucrInputSummaries.Margin = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.ucrInputSummaries.Name = "ucrInputSummaries"
        Me.ucrInputSummaries.Size = New System.Drawing.Size(122, 32)
        Me.ucrInputSummaries.TabIndex = 16
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(15, 354)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(222, 38)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 12
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrChkTufte
        '
        Me.ucrChkTufte.AutoSize = True
        Me.ucrChkTufte.Checked = False
        Me.ucrChkTufte.Location = New System.Drawing.Point(412, 470)
        Me.ucrChkTufte.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkTufte.Name = "ucrChkTufte"
        Me.ucrChkTufte.Size = New System.Drawing.Size(218, 34)
        Me.ucrChkTufte.TabIndex = 11
        '
        'ucrChkGrouptoConnect
        '
        Me.ucrChkGrouptoConnect.AutoSize = True
        Me.ucrChkGrouptoConnect.Checked = False
        Me.ucrChkGrouptoConnect.Location = New System.Drawing.Point(15, 428)
        Me.ucrChkGrouptoConnect.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkGrouptoConnect.Name = "ucrChkGrouptoConnect"
        Me.ucrChkGrouptoConnect.Size = New System.Drawing.Size(216, 34)
        Me.ucrChkGrouptoConnect.TabIndex = 15
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(452, 534)
        Me.ucrNudTransparency.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudTransparency.TabIndex = 21
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.AutoSize = True
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJitter.Location = New System.Drawing.Point(246, 534)
        Me.ucrNudJitter.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudJitter.TabIndex = 19
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.AutoSize = True
        Me.ucrChkAddPoints.Checked = False
        Me.ucrChkAddPoints.Location = New System.Drawing.Point(15, 537)
        Me.ucrChkAddPoints.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        Me.ucrChkAddPoints.Size = New System.Drawing.Size(172, 34)
        Me.ucrChkAddPoints.TabIndex = 17
        '
        'ucrSaveBoxplot
        '
        Me.ucrSaveBoxplot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveBoxplot.Location = New System.Drawing.Point(15, 658)
        Me.ucrSaveBoxplot.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveBoxplot.Name = "ucrSaveBoxplot"
        Me.ucrSaveBoxplot.Size = New System.Drawing.Size(492, 36)
        Me.ucrSaveBoxplot.TabIndex = 22
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.AutoSize = True
        Me.ucrChkHorizontalBoxplot.Checked = False
        Me.ucrChkHorizontalBoxplot.Location = New System.Drawing.Point(15, 394)
        Me.ucrChkHorizontalBoxplot.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        Me.ucrChkHorizontalBoxplot.Size = New System.Drawing.Size(357, 34)
        Me.ucrChkHorizontalBoxplot.TabIndex = 14
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.AutoSize = True
        Me.ucrChkVarWidth.Checked = False
        Me.ucrChkVarWidth.Location = New System.Drawing.Point(412, 435)
        Me.ucrChkVarWidth.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        Me.ucrChkVarWidth.Size = New System.Drawing.Size(219, 34)
        Me.ucrChkVarWidth.TabIndex = 13
        '
        'ucrVariablesAsFactorForBoxplot
        '
        Me.ucrVariablesAsFactorForBoxplot.AutoSize = True
        Me.ucrVariablesAsFactorForBoxplot.frmParent = Me
        Me.ucrVariablesAsFactorForBoxplot.Location = New System.Drawing.Point(412, 94)
        Me.ucrVariablesAsFactorForBoxplot.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrVariablesAsFactorForBoxplot.Name = "ucrVariablesAsFactorForBoxplot"
        Me.ucrVariablesAsFactorForBoxplot.Selector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.Size = New System.Drawing.Size(180, 195)
        Me.ucrVariablesAsFactorForBoxplot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForBoxplot.TabIndex = 5
        Me.ucrVariablesAsFactorForBoxplot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.ucrVariableSelector = Nothing
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.AutoSize = True
        Me.ucrSecondFactorReceiver.frmParent = Me
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(412, 393)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(180, 30)
        Me.ucrSecondFactorReceiver.strNcFilePath = ""
        Me.ucrSecondFactorReceiver.TabIndex = 9
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.AutoSize = True
        Me.ucrByFactorsReceiver.frmParent = Me
        Me.ucrByFactorsReceiver.Location = New System.Drawing.Point(412, 330)
        Me.ucrByFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Selector = Nothing
        Me.ucrByFactorsReceiver.Size = New System.Drawing.Size(180, 30)
        Me.ucrByFactorsReceiver.strNcFilePath = ""
        Me.ucrByFactorsReceiver.TabIndex = 7
        Me.ucrByFactorsReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(15, 699)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(611, 77)
        Me.ucrBase.TabIndex = 23
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(10, 18)
        Me.ucrPnlPlots.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(615, 52)
        Me.ucrPnlPlots.TabIndex = 0
        '
        'ucrNudOutlierCoefficient
        '
        Me.ucrNudOutlierCoefficient.AutoSize = True
        Me.ucrNudOutlierCoefficient.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Location = New System.Drawing.Point(453, 500)
        Me.ucrNudOutlierCoefficient.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrNudOutlierCoefficient.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudOutlierCoefficient.Name = "ucrNudOutlierCoefficient"
        Me.ucrNudOutlierCoefficient.Size = New System.Drawing.Size(72, 30)
        Me.ucrNudOutlierCoefficient.TabIndex = 36
        Me.ucrNudOutlierCoefficient.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblOutlierCoefficient
        '
        Me.lblOutlierCoefficient.AutoSize = True
        Me.lblOutlierCoefficient.Location = New System.Drawing.Point(192, 504)
        Me.lblOutlierCoefficient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOutlierCoefficient.Name = "lblOutlierCoefficient"
        Me.lblOutlierCoefficient.Size = New System.Drawing.Size(152, 20)
        Me.lblOutlierCoefficient.TabIndex = 35
        Me.lblOutlierCoefficient.Text = "Outlier Coefficiennt :"
        '
        'ucrSelectorBoxPlot
        '
        Me.ucrSelectorBoxPlot.AutoSize = True
        Me.ucrSelectorBoxPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorBoxPlot.bUseCurrentFilter = True
        Me.ucrSelectorBoxPlot.Location = New System.Drawing.Point(15, 75)
        Me.ucrSelectorBoxPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorBoxPlot.Name = "ucrSelectorBoxPlot"
        Me.ucrSelectorBoxPlot.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorBoxPlot.TabIndex = 4
        '
        'dlgBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(638, 777)
        Me.Controls.Add(Me.ucrNudOutlierCoefficient)
        Me.Controls.Add(Me.lblOutlierCoefficient)
        Me.Controls.Add(Me.ucrChkLabel)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.ucrNudBoxPlot)
        Me.Controls.Add(Me.ucrChkBoxPlot)
        Me.Controls.Add(Me.ucrInputWidth)
        Me.Controls.Add(Me.ucrChkWidth)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.ucrInputSummaries)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrChkTufte)
        Me.Controls.Add(Me.ucrChkGrouptoConnect)
        Me.Controls.Add(Me.ucrNudTransparency)
        Me.Controls.Add(Me.lblTransparency)
        Me.Controls.Add(Me.ucrNudJitter)
        Me.Controls.Add(Me.lblJitter)
        Me.Controls.Add(Me.ucrChkAddPoints)
        Me.Controls.Add(Me.ucrSaveBoxplot)
        Me.Controls.Add(Me.ucrChkHorizontalBoxplot)
        Me.Controls.Add(Me.ucrChkVarWidth)
        Me.Controls.Add(Me.rdoViolin)
        Me.Controls.Add(Me.rdoJitter)
        Me.Controls.Add(Me.rdoBoxplotTufte)
        Me.Controls.Add(Me.ucrVariablesAsFactorForBoxplot)
        Me.Controls.Add(Me.ucrSecondFactorReceiver)
        Me.Controls.Add(Me.ucrSelectorBoxPlot)
        Me.Controls.Add(Me.lblBySecondFactor)
        Me.Controls.Add(Me.lblByFactors)
        Me.Controls.Add(Me.ucrByFactorsReceiver)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrPnlPlots)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgBoxplot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Boxplot"
        Me.Text = "Boxplot Options"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrByFactorsReceiver As ucrReceiverSingle
    Friend WithEvents lblByFactors As Label
    Friend WithEvents ucrSelectorBoxPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrSecondFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblBySecondFactor As Label
    Friend WithEvents ucrVariablesAsFactorForBoxplot As ucrVariablesAsFactor
    Friend WithEvents rdoBoxplotTufte As RadioButton
    Friend WithEvents rdoJitter As RadioButton
    Friend WithEvents rdoViolin As RadioButton
    Friend WithEvents ucrSaveBoxplot As ucrSave
    Friend WithEvents ucrChkHorizontalBoxplot As ucrCheck
    Friend WithEvents ucrChkVarWidth As ucrCheck
    Friend WithEvents ucrPnlPlots As UcrPanel
    Friend WithEvents ucrNudTransparency As ucrNud
    Friend WithEvents lblTransparency As Label
    Friend WithEvents ucrNudJitter As ucrNud
    Friend WithEvents lblJitter As Label
    Friend WithEvents ucrChkAddPoints As ucrCheck
    Friend WithEvents ucrChkGrouptoConnect As ucrCheck
    Friend WithEvents ucrChkTufte As ucrCheck
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemBoxOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemJitterOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemViolinOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemTufteOptions As ToolStripMenuItem
    Friend WithEvents ucrInputSummaries As ucrInputComboBox
    Friend WithEvents toolStripMenuItemSummaryOptions As ToolStripMenuItem
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ucrInputWidth As ucrInputTextBox
    Friend WithEvents ucrChkWidth As ucrCheck
    Friend WithEvents ucrNudBoxPlot As ucrNud
    Friend WithEvents ucrChkBoxPlot As ucrCheck
    Friend WithEvents lblWidth As Label
    Friend WithEvents ucrChkLabel As ucrCheck
    Friend WithEvents ToolStripMenuItemTextOptions As ToolStripMenuItem
    Friend WithEvents ucrNudOutlierCoefficient As ucrNud
    Friend WithEvents lblOutlierCoefficient As Label
End Class
