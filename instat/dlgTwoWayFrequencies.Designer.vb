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
Partial Class dlgTwoWayFrequencies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgTwoWayFrequencies))
        Me.lblRowFactor = New System.Windows.Forms.Label()
        Me.lblColumnFactor = New System.Windows.Forms.Label()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.grpFreqTypeTable = New System.Windows.Forms.GroupBox()
        Me.ucrChkCount = New instat.ucrCheck()
        Me.ucrChkCell = New instat.ucrCheck()
        Me.ucrChkColumn = New instat.ucrCheck()
        Me.ucrChkRow = New instat.ucrCheck()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.grpFreqTypeGraph = New System.Windows.Forms.GroupBox()
        Me.rdoCount = New System.Windows.Forms.RadioButton()
        Me.rdoCell = New System.Windows.Forms.RadioButton()
        Me.rdoRow = New System.Windows.Forms.RadioButton()
        Me.rdoColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlFreqType = New instat.UcrPanel()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrSelectorTwoWayFrequencies = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrPnlFreqDisplay = New instat.UcrPanel()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverColumnFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverRowFactor = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpFreqTypeTable.SuspendLayout()
        Me.grpFreqTypeGraph.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRowFactor
        '
        resources.ApplyResources(Me.lblRowFactor, "lblRowFactor")
        Me.lblRowFactor.Name = "lblRowFactor"
        '
        'lblColumnFactor
        '
        resources.ApplyResources(Me.lblColumnFactor, "lblColumnFactor")
        Me.lblColumnFactor.Name = "lblColumnFactor"
        '
        'rdoTable
        '
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'grpFreqTypeTable
        '
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCount)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkCell)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkColumn)
        Me.grpFreqTypeTable.Controls.Add(Me.ucrChkRow)
        resources.ApplyResources(Me.grpFreqTypeTable, "grpFreqTypeTable")
        Me.grpFreqTypeTable.Name = "grpFreqTypeTable"
        Me.grpFreqTypeTable.TabStop = False
        '
        'ucrChkCount
        '
        Me.ucrChkCount.Checked = False
        resources.ApplyResources(Me.ucrChkCount, "ucrChkCount")
        Me.ucrChkCount.Name = "ucrChkCount"
        '
        'ucrChkCell
        '
        Me.ucrChkCell.Checked = False
        resources.ApplyResources(Me.ucrChkCell, "ucrChkCell")
        Me.ucrChkCell.Name = "ucrChkCell"
        '
        'ucrChkColumn
        '
        Me.ucrChkColumn.Checked = False
        resources.ApplyResources(Me.ucrChkColumn, "ucrChkColumn")
        Me.ucrChkColumn.Name = "ucrChkColumn"
        '
        'ucrChkRow
        '
        Me.ucrChkRow.Checked = False
        resources.ApplyResources(Me.ucrChkRow, "ucrChkRow")
        Me.ucrChkRow.Name = "ucrChkRow"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'rdoBoth
        '
        resources.ApplyResources(Me.rdoBoth, "rdoBoth")
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'grpFreqTypeGraph
        '
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCount)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoCell)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoRow)
        Me.grpFreqTypeGraph.Controls.Add(Me.rdoColumn)
        Me.grpFreqTypeGraph.Controls.Add(Me.ucrPnlFreqType)
        resources.ApplyResources(Me.grpFreqTypeGraph, "grpFreqTypeGraph")
        Me.grpFreqTypeGraph.Name = "grpFreqTypeGraph"
        Me.grpFreqTypeGraph.TabStop = False
        '
        'rdoCount
        '
        resources.ApplyResources(Me.rdoCount, "rdoCount")
        Me.rdoCount.Name = "rdoCount"
        Me.rdoCount.TabStop = True
        Me.rdoCount.UseVisualStyleBackColor = True
        '
        'rdoCell
        '
        resources.ApplyResources(Me.rdoCell, "rdoCell")
        Me.rdoCell.Name = "rdoCell"
        Me.rdoCell.TabStop = True
        Me.rdoCell.UseVisualStyleBackColor = True
        '
        'rdoRow
        '
        resources.ApplyResources(Me.rdoRow, "rdoRow")
        Me.rdoRow.Name = "rdoRow"
        Me.rdoRow.TabStop = True
        Me.rdoRow.UseVisualStyleBackColor = True
        '
        'rdoColumn
        '
        resources.ApplyResources(Me.rdoColumn, "rdoColumn")
        Me.rdoColumn.Name = "rdoColumn"
        Me.rdoColumn.TabStop = True
        Me.rdoColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlFreqType
        '
        resources.ApplyResources(Me.ucrPnlFreqType, "ucrPnlFreqType")
        Me.ucrPnlFreqType.Name = "ucrPnlFreqType"
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'ucrSelectorTwoWayFrequencies
        '
        Me.ucrSelectorTwoWayFrequencies.bShowHiddenColumns = False
        Me.ucrSelectorTwoWayFrequencies.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorTwoWayFrequencies, "ucrSelectorTwoWayFrequencies")
        Me.ucrSelectorTwoWayFrequencies.Name = "ucrSelectorTwoWayFrequencies"
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        resources.ApplyResources(Me.ucrChkFlip, "ucrChkFlip")
        Me.ucrChkFlip.Name = "ucrChkFlip"
        '
        'ucrPnlFreqDisplay
        '
        resources.ApplyResources(Me.ucrPnlFreqDisplay, "ucrPnlFreqDisplay")
        Me.ucrPnlFreqDisplay.Name = "ucrPnlFreqDisplay"
        '
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        resources.ApplyResources(Me.ucrChkWeights, "ucrChkWeights")
        Me.ucrChkWeights.Name = "ucrChkWeights"
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverWeights, "ucrReceiverWeights")
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverColumnFactor
        '
        Me.ucrReceiverColumnFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverColumnFactor, "ucrReceiverColumnFactor")
        Me.ucrReceiverColumnFactor.Name = "ucrReceiverColumnFactor"
        Me.ucrReceiverColumnFactor.Selector = Nothing
        Me.ucrReceiverColumnFactor.strNcFilePath = ""
        Me.ucrReceiverColumnFactor.ucrSelector = Nothing
        '
        'ucrReceiverRowFactor
        '
        Me.ucrReceiverRowFactor.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverRowFactor, "ucrReceiverRowFactor")
        Me.ucrReceiverRowFactor.Name = "ucrReceiverRowFactor"
        Me.ucrReceiverRowFactor.Selector = Nothing
        Me.ucrReceiverRowFactor.strNcFilePath = ""
        Me.ucrReceiverRowFactor.ucrSelector = Nothing
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'dlgTwoWayFrequencies
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.grpFreqTypeGraph)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.ucrSelectorTwoWayFrequencies)
        Me.Controls.Add(Me.grpFreqTypeTable)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.lblColumnFactor)
        Me.Controls.Add(Me.ucrPnlFreqDisplay)
        Me.Controls.Add(Me.lblRowFactor)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrReceiverColumnFactor)
        Me.Controls.Add(Me.ucrReceiverRowFactor)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgTwoWayFrequencies"
        Me.grpFreqTypeTable.ResumeLayout(False)
        Me.grpFreqTypeGraph.ResumeLayout(False)
        Me.grpFreqTypeGraph.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorTwoWayFrequencies As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverRowFactor As ucrReceiverSingle
    Friend WithEvents lblColumnFactor As Label
    Friend WithEvents lblRowFactor As Label
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrReceiverColumnFactor As ucrReceiverSingle
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents ucrPnlFreqDisplay As UcrPanel
    Friend WithEvents grpFreqTypeTable As GroupBox
    Friend WithEvents cmdOptions As Button
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents grpFreqTypeGraph As GroupBox
    Friend WithEvents rdoCount As RadioButton
    Friend WithEvents rdoCell As RadioButton
    Friend WithEvents rdoRow As RadioButton
    Friend WithEvents rdoColumn As RadioButton
    Friend WithEvents ucrPnlFreqType As UcrPanel
    Friend WithEvents ucrChkCount As ucrCheck
    Friend WithEvents ucrChkCell As ucrCheck
    Friend WithEvents ucrChkColumn As ucrCheck
    Friend WithEvents ucrChkRow As ucrCheck
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
