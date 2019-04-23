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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgCorrPlot))
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoPairwisePlot = New System.Windows.Forms.RadioButton()
        Me.rdoCorrelationPlot = New System.Windows.Forms.RadioButton()
        Me.rdoScatterPlotMatrix = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucrPnlGraphType = New instat.UcrPanel()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
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
        resources.ApplyResources(Me.rdoNone, "rdoNone")
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoPairwisePlot
        '
        resources.ApplyResources(Me.rdoPairwisePlot, "rdoPairwisePlot")
        Me.rdoPairwisePlot.Name = "rdoPairwisePlot"
        Me.rdoPairwisePlot.UseVisualStyleBackColor = True
        '
        'rdoCorrelationPlot
        '
        resources.ApplyResources(Me.rdoCorrelationPlot, "rdoCorrelationPlot")
        Me.rdoCorrelationPlot.Name = "rdoCorrelationPlot"
        Me.rdoCorrelationPlot.UseVisualStyleBackColor = True
        '
        'rdoScatterPlotMatrix
        '
        resources.ApplyResources(Me.rdoScatterPlotMatrix, "rdoScatterPlotMatrix")
        Me.rdoScatterPlotMatrix.Name = "rdoScatterPlotMatrix"
        Me.rdoScatterPlotMatrix.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoNone)
        Me.GroupBox1.Controls.Add(Me.rdoPairwisePlot)
        Me.GroupBox1.Controls.Add(Me.rdoCorrelationPlot)
        Me.GroupBox1.Controls.Add(Me.rdoScatterPlotMatrix)
        Me.GroupBox1.Controls.Add(Me.ucrPnlGraphType)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ucrPnlGraphType
        '
        resources.ApplyResources(Me.ucrPnlGraphType, "ucrPnlGraphType")
        Me.ucrPnlGraphType.Name = "ucrPnlGraphType"
        '
        'grpOptions
        '
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
        resources.ApplyResources(Me.grpOptions, "grpOptions")
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.TabStop = False
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'ucrSelectorFactor
        '
        Me.ucrSelectorFactor.bShowHiddenColumns = False
        Me.ucrSelectorFactor.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorFactor, "ucrSelectorFactor")
        Me.ucrSelectorFactor.Name = "ucrSelectorFactor"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverFactor, "ucrReceiverFactor")
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Selector = Nothing
        Me.ucrReceiverFactor.strNcFilePath = ""
        Me.ucrReceiverFactor.ucrSelector = Nothing
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.Checked = False
        resources.ApplyResources(Me.ucrChkLabel, "ucrChkLabel")
        Me.ucrChkLabel.Name = "ucrChkLabel"
        '
        'lblGeom
        '
        resources.ApplyResources(Me.lblGeom, "lblGeom")
        Me.lblGeom.Name = "lblGeom"
        Me.lblGeom.Tag = "Geom:"
        '
        'ucrInputComboGeom
        '
        Me.ucrInputComboGeom.AddQuotesIfUnrecognised = True
        Me.ucrInputComboGeom.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputComboGeom, "ucrInputComboGeom")
        Me.ucrInputComboGeom.Name = "ucrInputComboGeom"
        '
        'ucrNudMaximumSize
        '
        Me.ucrNudMaximumSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMaximumSize, "ucrNudMaximumSize")
        Me.ucrNudMaximumSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMaximumSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMaximumSize.Name = "ucrNudMaximumSize"
        Me.ucrNudMaximumSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMaximumSize
        '
        resources.ApplyResources(Me.lblMaximumSize, "lblMaximumSize")
        Me.lblMaximumSize.Name = "lblMaximumSize"
        Me.lblMaximumSize.Tag = "Maximum_Size:"
        '
        'ucrNudMinimunSize
        '
        Me.ucrNudMinimunSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudMinimunSize, "ucrNudMinimunSize")
        Me.ucrNudMinimunSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudMinimunSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudMinimunSize.Name = "ucrNudMinimunSize"
        Me.ucrNudMinimunSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMinimumSize
        '
        resources.ApplyResources(Me.lblMinimumSize, "lblMinimumSize")
        Me.lblMinimumSize.Name = "lblMinimumSize"
        Me.lblMinimumSize.Tag = "Minimum_Size:"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrBaseSdgCorrPlot
        '
        resources.ApplyResources(Me.ucrBaseSdgCorrPlot, "ucrBaseSdgCorrPlot")
        Me.ucrBaseSdgCorrPlot.Name = "ucrBaseSdgCorrPlot"
        '
        'sdgCorrPlot
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrBaseSdgCorrPlot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCorrPlot"
        Me.Tag = "Correlation_Display_and_Graphics"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.ResumeLayout(False)

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
End Class