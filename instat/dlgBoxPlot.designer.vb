﻿' R- Instat
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
        Me.toolStripMenuItemGeomTextOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ucrChkLabelOutlier = New instat.ucrCheck()
        Me.ucrInputSummaries = New instat.ucrInputComboBox()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrChkTufte = New instat.ucrCheck()
        Me.ucrChkGrouptoConnect = New instat.ucrCheck()
        Me.ucrNudTransparency = New instat.ucrNud()
        Me.ucrNudJitter = New instat.ucrNud()
        Me.ucrChkAddPoints = New instat.ucrCheck()
        Me.ucrChkSwapParameters = New instat.ucrCheck()
        Me.ucrSaveBoxplot = New instat.ucrSave()
        Me.ucrChkHorizontalBoxplot = New instat.ucrCheck()
        Me.ucrChkVarWidth = New instat.ucrCheck()
        Me.ucrVariablesAsFactorForBoxplot = New instat.ucrVariablesAsFactor()
        Me.ucrSecondFactorReceiver = New instat.ucrReceiverSingle()
        Me.ucrSelectorBoxPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrByFactorsReceiver = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrPnlPlots = New instat.UcrPanel()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblByFactors
        '
        Me.lblByFactors.AutoSize = True
        Me.lblByFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblByFactors.Location = New System.Drawing.Point(272, 205)
        Me.lblByFactors.Name = "lblByFactors"
        Me.lblByFactors.Size = New System.Drawing.Size(88, 13)
        Me.lblByFactors.TabIndex = 6
        Me.lblByFactors.Tag = "By_Factor:"
        Me.lblByFactors.Text = "Factor (Optional):"
        '
        'lblBySecondFactor
        '
        Me.lblBySecondFactor.AutoSize = True
        Me.lblBySecondFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblBySecondFactor.Location = New System.Drawing.Point(272, 249)
        Me.lblBySecondFactor.Name = "lblBySecondFactor"
        Me.lblBySecondFactor.Size = New System.Drawing.Size(128, 13)
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
        Me.rdoBoxplotTufte.Location = New System.Drawing.Point(17, 13)
        Me.rdoBoxplotTufte.Name = "rdoBoxplotTufte"
        Me.rdoBoxplotTufte.Size = New System.Drawing.Size(133, 27)
        Me.rdoBoxplotTufte.TabIndex = 1
        Me.rdoBoxplotTufte.TabStop = True
        Me.rdoBoxplotTufte.Text = "Boxplot/Tufte Boxplot"
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
        Me.rdoJitter.Location = New System.Drawing.Point(148, 13)
        Me.rdoJitter.Name = "rdoJitter"
        Me.rdoJitter.Size = New System.Drawing.Size(129, 27)
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
        Me.rdoViolin.Location = New System.Drawing.Point(275, 13)
        Me.rdoViolin.Name = "rdoViolin"
        Me.rdoViolin.Size = New System.Drawing.Size(135, 27)
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
        Me.lblJitter.Location = New System.Drawing.Point(128, 326)
        Me.lblJitter.Name = "lblJitter"
        Me.lblJitter.Size = New System.Drawing.Size(32, 13)
        Me.lblJitter.TabIndex = 18
        Me.lblJitter.Tag = "By_Factor:"
        Me.lblJitter.Text = "Jitter:"
        '
        'lblTransparency
        '
        Me.lblTransparency.AutoSize = True
        Me.lblTransparency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTransparency.Location = New System.Drawing.Point(223, 325)
        Me.lblTransparency.Name = "lblTransparency"
        Me.lblTransparency.Size = New System.Drawing.Size(75, 13)
        Me.lblTransparency.TabIndex = 20
        Me.lblTransparency.Tag = "By_Factor:"
        Me.lblTransparency.Text = "Transparency:"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemBoxOptions, Me.toolStripMenuItemJitterOptions, Me.toolStripMenuItemSummaryOptions, Me.toolStripMenuItemTufteOptions, Me.toolStripMenuItemViolinOptions, Me.toolStripMenuItemGeomTextOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(181, 180)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemBoxOptions
        '
        Me.toolStripMenuItemBoxOptions.Name = "toolStripMenuItemBoxOptions"
        Me.toolStripMenuItemBoxOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemBoxOptions.Text = "Boxplot Options"
        '
        'toolStripMenuItemJitterOptions
        '
        Me.toolStripMenuItemJitterOptions.Name = "toolStripMenuItemJitterOptions"
        Me.toolStripMenuItemJitterOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemJitterOptions.Text = "Jitter Options"
        '
        'toolStripMenuItemSummaryOptions
        '
        Me.toolStripMenuItemSummaryOptions.Name = "toolStripMenuItemSummaryOptions"
        Me.toolStripMenuItemSummaryOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemSummaryOptions.Text = "Summary Options"
        '
        'toolStripMenuItemTufteOptions
        '
        Me.toolStripMenuItemTufteOptions.Name = "toolStripMenuItemTufteOptions"
        Me.toolStripMenuItemTufteOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemTufteOptions.Text = "Tufte Options"
        '
        'toolStripMenuItemViolinOptions
        '
        Me.toolStripMenuItemViolinOptions.Name = "toolStripMenuItemViolinOptions"
        Me.toolStripMenuItemViolinOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemViolinOptions.Text = "Violin Options"
        '
        'toolStripMenuItemGeomTextOptions
        '
        Me.toolStripMenuItemGeomTextOptions.Enabled = False
        Me.toolStripMenuItemGeomTextOptions.Name = "toolStripMenuItemGeomTextOptions"
        Me.toolStripMenuItemGeomTextOptions.Size = New System.Drawing.Size(180, 22)
        Me.toolStripMenuItemGeomTextOptions.Text = "Geom_Text Options"
        '
        'ucrChkLabelOutlier
        '
        Me.ucrChkLabelOutlier.AutoSize = True
        Me.ucrChkLabelOutlier.Checked = False
        Me.ucrChkLabelOutlier.Location = New System.Drawing.Point(10, 352)
        Me.ucrChkLabelOutlier.Name = "ucrChkLabelOutlier"
        Me.ucrChkLabelOutlier.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkLabelOutlier.TabIndex = 24
        '
        'ucrInputSummaries
        '
        Me.ucrInputSummaries.AddQuotesIfUnrecognised = True
        Me.ucrInputSummaries.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSummaries.GetSetSelectedIndex = -1
        Me.ucrInputSummaries.IsReadOnly = False
        Me.ucrInputSummaries.Location = New System.Drawing.Point(130, 293)
        Me.ucrInputSummaries.Name = "ucrInputSummaries"
        Me.ucrInputSummaries.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputSummaries.TabIndex = 16
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(272, 288)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(138, 25)
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
        Me.ucrChkTufte.Location = New System.Drawing.Point(275, 352)
        Me.ucrChkTufte.Name = "ucrChkTufte"
        Me.ucrChkTufte.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkTufte.TabIndex = 11
        '
        'ucrChkGrouptoConnect
        '
        Me.ucrChkGrouptoConnect.AutoSize = True
        Me.ucrChkGrouptoConnect.Checked = False
        Me.ucrChkGrouptoConnect.Location = New System.Drawing.Point(10, 294)
        Me.ucrChkGrouptoConnect.Name = "ucrChkGrouptoConnect"
        Me.ucrChkGrouptoConnect.Size = New System.Drawing.Size(144, 23)
        Me.ucrChkGrouptoConnect.TabIndex = 15
        '
        'ucrNudTransparency
        '
        Me.ucrNudTransparency.AutoSize = True
        Me.ucrNudTransparency.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTransparency.Location = New System.Drawing.Point(301, 322)
        Me.ucrNudTransparency.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTransparency.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTransparency.Name = "ucrNudTransparency"
        Me.ucrNudTransparency.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTransparency.TabIndex = 21
        Me.ucrNudTransparency.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.AutoSize = True
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJitter.Location = New System.Drawing.Point(164, 322)
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudJitter.TabIndex = 19
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkAddPoints
        '
        Me.ucrChkAddPoints.AutoSize = True
        Me.ucrChkAddPoints.Checked = False
        Me.ucrChkAddPoints.Location = New System.Drawing.Point(10, 322)
        Me.ucrChkAddPoints.Name = "ucrChkAddPoints"
        Me.ucrChkAddPoints.Size = New System.Drawing.Size(115, 23)
        Me.ucrChkAddPoints.TabIndex = 17
        '
        'ucrChkSwapParameters
        '
        Me.ucrChkSwapParameters.AutoSize = True
        Me.ucrChkSwapParameters.Checked = False
        Me.ucrChkSwapParameters.Enabled = False
        Me.ucrChkSwapParameters.Location = New System.Drawing.Point(275, 290)
        Me.ucrChkSwapParameters.Name = "ucrChkSwapParameters"
        Me.ucrChkSwapParameters.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkSwapParameters.TabIndex = 10
        '
        'ucrSaveBoxplot
        '
        Me.ucrSaveBoxplot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveBoxplot.Location = New System.Drawing.Point(10, 384)
        Me.ucrSaveBoxplot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveBoxplot.Name = "ucrSaveBoxplot"
        Me.ucrSaveBoxplot.Size = New System.Drawing.Size(328, 24)
        Me.ucrSaveBoxplot.TabIndex = 22
        '
        'ucrChkHorizontalBoxplot
        '
        Me.ucrChkHorizontalBoxplot.AutoSize = True
        Me.ucrChkHorizontalBoxplot.Checked = False
        Me.ucrChkHorizontalBoxplot.Location = New System.Drawing.Point(10, 266)
        Me.ucrChkHorizontalBoxplot.Name = "ucrChkHorizontalBoxplot"
        Me.ucrChkHorizontalBoxplot.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkHorizontalBoxplot.TabIndex = 14
        '
        'ucrChkVarWidth
        '
        Me.ucrChkVarWidth.AutoSize = True
        Me.ucrChkVarWidth.Checked = False
        Me.ucrChkVarWidth.Location = New System.Drawing.Point(10, 238)
        Me.ucrChkVarWidth.Name = "ucrChkVarWidth"
        Me.ucrChkVarWidth.Size = New System.Drawing.Size(238, 23)
        Me.ucrChkVarWidth.TabIndex = 13
        '
        'ucrVariablesAsFactorForBoxplot
        '
        Me.ucrVariablesAsFactorForBoxplot.AutoSize = True
        Me.ucrVariablesAsFactorForBoxplot.frmParent = Me
        Me.ucrVariablesAsFactorForBoxplot.Location = New System.Drawing.Point(275, 63)
        Me.ucrVariablesAsFactorForBoxplot.Name = "ucrVariablesAsFactorForBoxplot"
        Me.ucrVariablesAsFactorForBoxplot.Selector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.Size = New System.Drawing.Size(120, 130)
        Me.ucrVariablesAsFactorForBoxplot.strNcFilePath = ""
        Me.ucrVariablesAsFactorForBoxplot.TabIndex = 5
        Me.ucrVariablesAsFactorForBoxplot.ucrSelector = Nothing
        Me.ucrVariablesAsFactorForBoxplot.ucrVariableSelector = Nothing
        '
        'ucrSecondFactorReceiver
        '
        Me.ucrSecondFactorReceiver.AutoSize = True
        Me.ucrSecondFactorReceiver.frmParent = Me
        Me.ucrSecondFactorReceiver.Location = New System.Drawing.Point(275, 262)
        Me.ucrSecondFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSecondFactorReceiver.Name = "ucrSecondFactorReceiver"
        Me.ucrSecondFactorReceiver.Selector = Nothing
        Me.ucrSecondFactorReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrSecondFactorReceiver.strNcFilePath = ""
        Me.ucrSecondFactorReceiver.TabIndex = 9
        Me.ucrSecondFactorReceiver.ucrSelector = Nothing
        '
        'ucrSelectorBoxPlot
        '
        Me.ucrSelectorBoxPlot.AutoSize = True
        Me.ucrSelectorBoxPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorBoxPlot.bShowHiddenColumns = False
        Me.ucrSelectorBoxPlot.bUseCurrentFilter = True
        Me.ucrSelectorBoxPlot.Location = New System.Drawing.Point(10, 50)
        Me.ucrSelectorBoxPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorBoxPlot.Name = "ucrSelectorBoxPlot"
        Me.ucrSelectorBoxPlot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorBoxPlot.TabIndex = 4
        '
        'ucrByFactorsReceiver
        '
        Me.ucrByFactorsReceiver.AutoSize = True
        Me.ucrByFactorsReceiver.frmParent = Me
        Me.ucrByFactorsReceiver.Location = New System.Drawing.Point(275, 220)
        Me.ucrByFactorsReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrByFactorsReceiver.Name = "ucrByFactorsReceiver"
        Me.ucrByFactorsReceiver.Selector = Nothing
        Me.ucrByFactorsReceiver.Size = New System.Drawing.Size(120, 20)
        Me.ucrByFactorsReceiver.strNcFilePath = ""
        Me.ucrByFactorsReceiver.TabIndex = 7
        Me.ucrByFactorsReceiver.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(10, 412)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 23
        '
        'ucrPnlPlots
        '
        Me.ucrPnlPlots.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlPlots.Location = New System.Drawing.Point(7, 12)
        Me.ucrPnlPlots.Name = "ucrPnlPlots"
        Me.ucrPnlPlots.Size = New System.Drawing.Size(410, 35)
        Me.ucrPnlPlots.TabIndex = 0
        '
        'dlgBoxplot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(425, 466)
        Me.Controls.Add(Me.ucrChkLabelOutlier)
        Me.Controls.Add(Me.ucrInputSummaries)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrChkTufte)
        Me.Controls.Add(Me.ucrChkGrouptoConnect)
        Me.Controls.Add(Me.ucrNudTransparency)
        Me.Controls.Add(Me.lblTransparency)
        Me.Controls.Add(Me.ucrNudJitter)
        Me.Controls.Add(Me.lblJitter)
        Me.Controls.Add(Me.ucrChkAddPoints)
        Me.Controls.Add(Me.ucrChkSwapParameters)
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
    Friend WithEvents ucrChkSwapParameters As ucrCheck
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
    Friend WithEvents ucrChkLabelOutlier As ucrCheck
    Friend WithEvents toolStripMenuItemGeomTextOptions As ToolStripMenuItem
End Class
