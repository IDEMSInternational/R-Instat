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
Partial Class sdgCorrPlot
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
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoPairwisePlot = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelationPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScatterPlotMatrix = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.ucrChkReverseLegendOrder = New instat.ucrCheck()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrSelectorFactor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.lblGeom = New System.Windows.Forms.Label()
        Me.ucrInputComboGeom = New instat.ucrInputComboBox()
        Me.ucrNudMaximumSize = New instat.ucrNud()
        Me.lblMaximumSize = New System.Windows.Forms.Label()
        Me.ucrNudMinimunSize = New instat.ucrNud()
        Me.lblMinimumSize = New System.Windows.Forms.Label()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrBaseSdgCorrPlot = New instat.ucrButtonsSubdialogue()
        Me.GroupBox1.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(12, 19)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 1
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoPairwisePlot
        '
        Me.rdoPairwisePlot.AutoSize = True
        Me.rdoPairwisePlot.Location = New System.Drawing.Point(12, 42)
        Me.rdoPairwisePlot.Name = "rdoPairwisePlot"
        Me.rdoPairwisePlot.Size = New System.Drawing.Size(85, 17)
        Me.rdoPairwisePlot.TabIndex = 2
        Me.rdoPairwisePlot.Text = "Pairwise Plot"
        Me.rdoPairwisePlot.UseVisualStyleBackColor = True
        '
        'rdoCorrelationPlot
        '
        Me.rdoCorrelationPlot.AutoSize = True
        Me.rdoCorrelationPlot.Location = New System.Drawing.Point(177, 19)
        Me.rdoCorrelationPlot.Name = "rdoCorrelationPlot"
        Me.rdoCorrelationPlot.Size = New System.Drawing.Size(96, 17)
        Me.rdoCorrelationPlot.TabIndex = 3
        Me.rdoCorrelationPlot.Text = "Correlation Plot"
        Me.rdoCorrelationPlot.UseVisualStyleBackColor = True
        '
        'rdoScatterPlotMatrix
        '
        Me.rdoScatterPlotMatrix.AutoSize = True
        Me.rdoScatterPlotMatrix.Location = New System.Drawing.Point(177, 42)
        Me.rdoScatterPlotMatrix.Name = "rdoScatterPlotMatrix"
        Me.rdoScatterPlotMatrix.Size = New System.Drawing.Size(90, 17)
        Me.rdoScatterPlotMatrix.TabIndex = 4
        Me.rdoScatterPlotMatrix.Text = "Scatter Matrix"
        Me.rdoScatterPlotMatrix.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoNone)
        Me.GroupBox1.Controls.Add(Me.rdoPairwisePlot)
        Me.GroupBox1.Controls.Add(Me.rdoCorrelationPlot)
        Me.GroupBox1.Controls.Add(Me.rdoScatterPlotMatrix)
        Me.GroupBox1.Controls.Add(Me.ucrPnlGraphType)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 67)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Graphs"
        '
        'ucrPnlGraphType
        '
        Me.ucrPnlGraphType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGraphType.Location = New System.Drawing.Point(6, 15)
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        Me.ucrPnlGraphType.Size = New System.Drawing.Size(318, 46)
        Me.ucrPnlGraphType.TabIndex = 0
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.ucrChkReverseLegendOrder)
        Me.grpOptions.Controls.Add(Me.lblFactor)
        Me.grpOptions.Controls.Add(Me.ucrSelectorFactor)
        Me.grpOptions.Controls.Add(Me.ucrReceiverFactor)
        Me.grpOptions.Controls.Add(Me.ucrChkLabel)
        Me.grpOptions.Controls.Add(Me.lblGeom)
        Me.grpOptions.Controls.Add(Me.ucrInputComboGeom)
        Me.grpOptions.Controls.Add(Me.ucrNudMaximumSize)
        Me.grpOptions.Controls.Add(Me.lblMaximumSize)
        Me.grpOptions.Controls.Add(Me.ucrNudMinimunSize)
        Me.grpOptions.Controls.Add(Me.lblMinimumSize)
        Me.grpOptions.Location = New System.Drawing.Point(10, 80)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(346, 252)
        Me.grpOptions.TabIndex = 1
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'ucrChkReverseLegendOrder
        '
        Me.ucrChkReverseLegendOrder.AutoSize = True
        Me.ucrChkReverseLegendOrder.Checked = False
        Me.ucrChkReverseLegendOrder.Location = New System.Drawing.Point(6, 217)
        Me.ucrChkReverseLegendOrder.Name = "ucrChkReverseLegendOrder"
        Me.ucrChkReverseLegendOrder.Size = New System.Drawing.Size(190, 23)
        Me.ucrChkReverseLegendOrder.TabIndex = 13
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(227, 35)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(40, 13)
        Me.lblFactor.TabIndex = 12
        Me.lblFactor.Text = "Factor:"
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.AutoSize = True
        Me.ucrSelectorFactor.bDropUnusedFilterLevels = False
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        Me.ucrSelectorFactor.Location = New System.Drawing.Point(7, 24)
        Me.ucrSelectorFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        Me.ucrSelectorFactor.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorFactor.TabIndex = 11
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.AutoSize = True
        Me.ucrReceiverFactor.frmParent = Me
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(223, 51)
        Me.ucrReceiverFactor.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.TabIndex = 10
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.AutoSize = True
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(12, 51)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(145, 23)
        Me.ucrChkLabel.TabIndex = 3
        '
        'lblGeom
        '
        Me.lblGeom.AutoSize = True
        Me.lblGeom.Location = New System.Drawing.Point(11, 28)
        Me.lblGeom.Name = "lblGeom"
        Me.lblGeom.Size = New System.Drawing.Size(38, 13)
        Me.lblGeom.TabIndex = 1
        Me.lblGeom.Tag = "Geom:"
        Me.lblGeom.Text = "Geom:"
        '
        'ucrInputComboGeom
        '
        Me.ucrInputComboGeom.AddQuotesIfUnrecognised = True
        Me.ucrInputComboGeom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputComboGeom.GetSetSelectedIndex = -1
        Me.ucrInputComboGeom.IsReadOnly = False
        Me.ucrInputComboGeom.Location = New System.Drawing.Point(51, 24)
        Me.ucrInputComboGeom.Name = "ucrInputComboGeom"
        Me.ucrInputComboGeom.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputComboGeom.TabIndex = 2
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.AutoSize = True
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMaximumSize.Location = New System.Drawing.Point(98, 103)
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMaximumSize.TabIndex = 9
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaximumSize
        '
        Me.lblMaximumSize.AutoSize = True
        Me.lblMaximumSize.Location = New System.Drawing.Point(11, 106)
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Size = New System.Drawing.Size(77, 13)
        Me.lblMaximumSize.TabIndex = 8
        Me.lblMaximumSize.Tag = "Maximum_Size:"
        Me.lblMaximumSize.Text = "Maximum Size:"
        '
        'ucrNudMinimunSize
        '
        Me.ucrNudMinimunSize.AutoSize = True
        Me.ucrNudMinimunSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudMinimunSize.Location = New System.Drawing.Point(98, 77)
        Me.ucrNudMinimunSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimunSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Name = "ucrNudMinimunSize"
        Me.ucrNudMinimunSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudMinimunSize.TabIndex = 7
        Me.ucrNudMinimunSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinimumSize
        '
        Me.lblMinimumSize.AutoSize = True
        Me.lblMinimumSize.Location = New System.Drawing.Point(11, 80)
        Me.lblMinimumSize.Name = "lblMinimumSize"
        Me.lblMinimumSize.Size = New System.Drawing.Size(74, 13)
        Me.lblMinimumSize.TabIndex = 6
        Me.lblMinimumSize.Tag = "Minimum_Size:"
        Me.lblMinimumSize.Text = "Minimum Size:"
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 339)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(346, 24)
        Me.ucrSaveGraph.TabIndex = 13
        '
        'ucrBaseSdgCorrPlot
        '
        Me.ucrBaseSdgCorrPlot.AutoSize = True
        Me.ucrBaseSdgCorrPlot.Location = New System.Drawing.Point(111, 363)
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        Me.ucrBaseSdgCorrPlot.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSdgCorrPlot.TabIndex = 14
        '
        'sdgCorrPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(366, 401)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorrPlot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Correlation_Display_and_Graphics"
        Me.Text = "Correlation Display and Graphics"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdgCorrPlot As ucrButtonsSubdialogue
    Friend WithEvents grpGraphs As GroupBox
    Friend WithEvents ucrPnlGraphType As UcrPanel
    Friend WithEvents rdoScatterPlotMatrix As RadioButton
    Friend WithEvents rdoCorrelationPlot As RadioButton
    Friend WithEvents rdoPairwisePlot As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents ucrChkLabel As ucrCheck
    Friend WithEvents lblGeom As Label
    Friend WithEvents ucrInputComboGeom As ucrInputComboBox
    Friend WithEvents ucrNudMaximumSize As ucrNud
    Friend WithEvents lblMaximumSize As Label
    Friend WithEvents ucrNudMinimunSize As ucrNud
    Friend WithEvents lblMinimumSize As Label
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents ucrSelectorFactor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrChkReverseLegendOrder As ucrCheck
End Class