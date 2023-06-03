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
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.ucrInputHistPositions = New instat.ucrInputComboBox()
        Me.UcrChkReverse = New instat.ucrCheck()
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
        Me.rdoHistogram.Location = New System.Drawing.Point(11, 15)
        Me.rdoHistogram.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(181, 35)
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
        Me.rdoDensity_ridges.Location = New System.Drawing.Point(189, 15)
        Me.rdoDensity_ridges.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoDensity_ridges.Name = "rdoDensity_ridges"
        Me.rdoDensity_ridges.Size = New System.Drawing.Size(181, 35)
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
        Me.rdoFrequencyPolygon.Location = New System.Drawing.Point(368, 15)
        Me.rdoFrequencyPolygon.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoFrequencyPolygon.Name = "rdoFrequencyPolygon"
        Me.rdoFrequencyPolygon.Size = New System.Drawing.Size(181, 35)
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
        Me.lblfactor.Location = New System.Drawing.Point(354, 265)
        Me.lblfactor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(111, 17)
        Me.lblfactor.TabIndex = 6
        Me.lblfactor.Tag = "Factor_Selected:"
        Me.lblfactor.Text = "Factor Selected:"
        '
        'lblStats
        '
        Me.lblStats.Location = New System.Drawing.Point(11, 345)
        Me.lblStats.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(70, 24)
        Me.lblStats.TabIndex = 11
        Me.lblStats.Text = "merge"
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemHistogramOptions, Me.toolStripMenuItemDotOptions, Me.toolStripMenuItemDensityOptions, Me.toolStripMenuItemDensityRidgesOptions, Me.toolStripMenuItemFrequencyPolygonOptions})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(259, 148)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(258, 24)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemHistogramOptions
        '
        Me.toolStripMenuItemHistogramOptions.Name = "toolStripMenuItemHistogramOptions"
        Me.toolStripMenuItemHistogramOptions.Size = New System.Drawing.Size(258, 24)
        Me.toolStripMenuItemHistogramOptions.Text = "Histogram Options"
        '
        'toolStripMenuItemDotOptions
        '
        Me.toolStripMenuItemDotOptions.Name = "toolStripMenuItemDotOptions"
        Me.toolStripMenuItemDotOptions.Size = New System.Drawing.Size(258, 24)
        Me.toolStripMenuItemDotOptions.Text = "Dotplot Options"
        '
        'toolStripMenuItemDensityOptions
        '
        Me.toolStripMenuItemDensityOptions.Name = "toolStripMenuItemDensityOptions"
        Me.toolStripMenuItemDensityOptions.Size = New System.Drawing.Size(258, 24)
        Me.toolStripMenuItemDensityOptions.Text = "Density Options"
        '
        'toolStripMenuItemDensityRidgesOptions
        '
        Me.toolStripMenuItemDensityRidgesOptions.Name = "toolStripMenuItemDensityRidgesOptions"
        Me.toolStripMenuItemDensityRidgesOptions.Size = New System.Drawing.Size(258, 24)
        Me.toolStripMenuItemDensityRidgesOptions.Text = "Density Ridges Options"
        '
        'toolStripMenuItemFrequencyPolygonOptions
        '
        Me.toolStripMenuItemFrequencyPolygonOptions.Name = "toolStripMenuItemFrequencyPolygonOptions"
        Me.toolStripMenuItemFrequencyPolygonOptions.Size = New System.Drawing.Size(258, 24)
        Me.toolStripMenuItemFrequencyPolygonOptions.Text = "Frequency Polygon Options"
        '
        'cmdOptions
        '
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(11, 291)
        Me.cmdOptions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(186, 29)
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
        Me.ucrChkDisplayAsDotPlot.Location = New System.Drawing.Point(354, 320)
        Me.ucrChkDisplayAsDotPlot.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkDisplayAsDotPlot.Name = "ucrChkDisplayAsDotPlot"
        Me.ucrChkDisplayAsDotPlot.Size = New System.Drawing.Size(191, 29)
        Me.ucrChkDisplayAsDotPlot.TabIndex = 8
        '
        'ucrChkRidges
        '
        Me.ucrChkRidges.AutoSize = True
        Me.ucrChkRidges.Checked = False
        Me.ucrChkRidges.Location = New System.Drawing.Point(354, 320)
        Me.ucrChkRidges.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkRidges.Name = "ucrChkRidges"
        Me.ucrChkRidges.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkRidges.TabIndex = 15
        '
        'ucrInputStats
        '
        Me.ucrInputStats.AddQuotesIfUnrecognised = True
        Me.ucrInputStats.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStats.GetSetSelectedIndex = -1
        Me.ucrInputStats.IsReadOnly = False
        Me.ucrInputStats.Location = New System.Drawing.Point(91, 340)
        Me.ucrInputStats.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrInputStats.Name = "ucrInputStats"
        Me.ucrInputStats.Size = New System.Drawing.Size(171, 26)
        Me.ucrInputStats.TabIndex = 12
        '
        'ucrChkPercentages
        '
        Me.ucrChkPercentages.AutoSize = True
        Me.ucrChkPercentages.Checked = False
        Me.ucrChkPercentages.Location = New System.Drawing.Point(354, 350)
        Me.ucrChkPercentages.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ucrChkPercentages.Name = "ucrChkPercentages"
        Me.ucrChkPercentages.Size = New System.Drawing.Size(125, 29)
        Me.ucrChkPercentages.TabIndex = 9
        '
        'ucrSaveHist
        '
        Me.ucrSaveHist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveHist.Location = New System.Drawing.Point(12, 389)
        Me.ucrSaveHist.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrSaveHist.Name = "ucrSaveHist"
        Me.ucrSaveHist.Size = New System.Drawing.Size(402, 30)
        Me.ucrSaveHist.TabIndex = 13
        '
        'ucrVariablesAsFactorforHist
        '
        Me.ucrVariablesAsFactorforHist.AutoSize = True
        Me.ucrVariablesAsFactorforHist.frmParent = Me
        Me.ucrVariablesAsFactorforHist.Location = New System.Drawing.Point(351, 85)
        Me.ucrVariablesAsFactorforHist.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrVariablesAsFactorforHist.Name = "ucrVariablesAsFactorforHist"
        Me.ucrVariablesAsFactorforHist.Selector = Nothing
        Me.ucrVariablesAsFactorforHist.Size = New System.Drawing.Size(156, 170)
        Me.ucrVariablesAsFactorforHist.strNcFilePath = ""
        Me.ucrVariablesAsFactorforHist.TabIndex = 5
        Me.ucrVariablesAsFactorforHist.ucrSelector = Nothing
        Me.ucrVariablesAsFactorforHist.ucrVariableSelector = Nothing
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.AutoSize = True
        Me.ucrFactorReceiver.frmParent = Me
        Me.ucrFactorReceiver.Location = New System.Drawing.Point(354, 285)
        Me.ucrFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.Size = New System.Drawing.Size(154, 25)
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
        Me.ucrHistogramSelector.Location = New System.Drawing.Point(12, 60)
        Me.ucrHistogramSelector.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrHistogramSelector.Name = "ucrHistogramSelector"
        Me.ucrHistogramSelector.Size = New System.Drawing.Size(268, 229)
        Me.ucrHistogramSelector.TabIndex = 4
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(11, 544)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(511, 65)
        Me.ucrBase.TabIndex = 14
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlOptions.Location = New System.Drawing.Point(10, 14)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(541, 38)
        Me.ucrPnlOptions.TabIndex = 0
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPosition.Location = New System.Drawing.Point(354, 458)
        Me.lblPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(62, 17)
        Me.lblPosition.TabIndex = 40
        Me.lblPosition.Text = "Position:"
        '
        'ucrInputHistPositions
        '
        Me.ucrInputHistPositions.AddQuotesIfUnrecognised = True
        Me.ucrInputHistPositions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputHistPositions.GetSetSelectedIndex = -1
        Me.ucrInputHistPositions.IsReadOnly = False
        Me.ucrInputHistPositions.Location = New System.Drawing.Point(354, 493)
        Me.ucrInputHistPositions.Margin = New System.Windows.Forms.Padding(8)
        Me.ucrInputHistPositions.Name = "ucrInputHistPositions"
        Me.ucrInputHistPositions.Size = New System.Drawing.Size(150, 26)
        Me.ucrInputHistPositions.TabIndex = 41
        '
        'UcrChkReverse
        '
        Me.UcrChkReverse.AutoSize = True
        Me.UcrChkReverse.Checked = False
        Me.UcrChkReverse.Location = New System.Drawing.Point(351, 431)
        Me.UcrChkReverse.Margin = New System.Windows.Forms.Padding(6)
        Me.UcrChkReverse.Name = "UcrChkReverse"
        Me.UcrChkReverse.Size = New System.Drawing.Size(191, 29)
        Me.UcrChkReverse.TabIndex = 42
        '
        'dlgHistogram
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(560, 623)
        Me.Controls.Add(Me.UcrChkReverse)
        Me.Controls.Add(Me.ucrInputHistPositions)
        Me.Controls.Add(Me.lblPosition)
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
    Friend WithEvents lblPosition As Label
    Friend WithEvents ucrInputHistPositions As ucrInputComboBox
    Friend WithEvents UcrChkReverse As ucrCheck
End Class