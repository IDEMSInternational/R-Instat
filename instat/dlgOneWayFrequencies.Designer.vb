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
Partial Class dlgOneWayFrequencies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgOneWayFrequencies))
        Me.grpSort = New System.Windows.Forms.GroupBox()
        Me.rdoDescendingFrequencies = New System.Windows.Forms.RadioButton()
        Me.rdoAscendingFrequencies = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrPnlSort = New instat.UcrPanel()
        Me.cmdOptions = New System.Windows.Forms.Button()
        Me.lblSelectedVariable = New System.Windows.Forms.Label()
        Me.rdoGraph = New System.Windows.Forms.RadioButton()
        Me.rdoTable = New System.Windows.Forms.RadioButton()
        Me.rdoBoth = New System.Windows.Forms.RadioButton()
        Me.ucrNudGroups = New instat.ucrNud()
        Me.ucrPnlFrequencies = New instat.UcrPanel()
        Me.ucrChkGroupData = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrChkWeights = New instat.ucrCheck()
        Me.ucrChkFlip = New instat.ucrCheck()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorOneWayFreq = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverOneWayFreq = New instat.ucrReceiverMultiple()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.grpSort.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSort
        '
        Me.grpSort.Controls.Add(Me.rdoDescendingFrequencies)
        Me.grpSort.Controls.Add(Me.rdoAscendingFrequencies)
        Me.grpSort.Controls.Add(Me.rdoNone)
        Me.grpSort.Controls.Add(Me.ucrPnlSort)
        resources.ApplyResources(Me.grpSort, "grpSort")
        Me.grpSort.Name = "grpSort"
        Me.grpSort.TabStop = False
        '
        'rdoDescendingFrequencies
        '
        resources.ApplyResources(Me.rdoDescendingFrequencies, "rdoDescendingFrequencies")
        Me.rdoDescendingFrequencies.Name = "rdoDescendingFrequencies"
        Me.rdoDescendingFrequencies.TabStop = True
        Me.rdoDescendingFrequencies.UseVisualStyleBackColor = True
        '
        'rdoAscendingFrequencies
        '
        resources.ApplyResources(Me.rdoAscendingFrequencies, "rdoAscendingFrequencies")
        Me.rdoAscendingFrequencies.Name = "rdoAscendingFrequencies"
        Me.rdoAscendingFrequencies.TabStop = True
        Me.rdoAscendingFrequencies.UseVisualStyleBackColor = True
        '
        'rdoNone
        '
        resources.ApplyResources(Me.rdoNone, "rdoNone")
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.TabStop = True
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'ucrPnlSort
        '
        resources.ApplyResources(Me.ucrPnlSort, "ucrPnlSort")
        Me.ucrPnlSort.Name = "ucrPnlSort"
        '
        'cmdOptions
        '
        resources.ApplyResources(Me.cmdOptions, "cmdOptions")
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'lblSelectedVariable
        '
        resources.ApplyResources(Me.lblSelectedVariable, "lblSelectedVariable")
        Me.lblSelectedVariable.Name = "lblSelectedVariable"
        '
        'rdoGraph
        '
        resources.ApplyResources(Me.rdoGraph, "rdoGraph")
        Me.rdoGraph.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.FlatAppearance.BorderSize = 2
        Me.rdoGraph.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGraph.Name = "rdoGraph"
        Me.rdoGraph.UseVisualStyleBackColor = True
        '
        'rdoTable
        '
        resources.ApplyResources(Me.rdoTable, "rdoTable")
        Me.rdoTable.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.FlatAppearance.BorderSize = 2
        Me.rdoTable.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoTable.Name = "rdoTable"
        Me.rdoTable.UseVisualStyleBackColor = True
        '
        'rdoBoth
        '
        resources.ApplyResources(Me.rdoBoth, "rdoBoth")
        Me.rdoBoth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.FlatAppearance.BorderSize = 2
        Me.rdoBoth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoBoth.Name = "rdoBoth"
        Me.rdoBoth.UseVisualStyleBackColor = True
        '
        'ucrNudGroups
        '
        Me.ucrNudGroups.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGroups.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        resources.ApplyResources(Me.ucrNudGroups, "ucrNudGroups")
        Me.ucrNudGroups.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudGroups.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudGroups.Name = "ucrNudGroups"
        Me.ucrNudGroups.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrPnlFrequencies
        '
        resources.ApplyResources(Me.ucrPnlFrequencies, "ucrPnlFrequencies")
        Me.ucrPnlFrequencies.Name = "ucrPnlFrequencies"
        '
        'ucrChkGroupData
        '
        Me.ucrChkGroupData.Checked = False
        resources.ApplyResources(Me.ucrChkGroupData, "ucrChkGroupData")
        Me.ucrChkGroupData.Name = "ucrChkGroupData"
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
        'ucrChkWeights
        '
        Me.ucrChkWeights.Checked = False
        resources.ApplyResources(Me.ucrChkWeights, "ucrChkWeights")
        Me.ucrChkWeights.Name = "ucrChkWeights"
        '
        'ucrChkFlip
        '
        Me.ucrChkFlip.Checked = False
        resources.ApplyResources(Me.ucrChkFlip, "ucrChkFlip")
        Me.ucrChkFlip.Name = "ucrChkFlip"
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrSelectorOneWayFreq
        '
        Me.ucrSelectorOneWayFreq.bShowHiddenColumns = False
        Me.ucrSelectorOneWayFreq.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorOneWayFreq, "ucrSelectorOneWayFreq")
        Me.ucrSelectorOneWayFreq.Name = "ucrSelectorOneWayFreq"
        '
        'ucrReceiverOneWayFreq
        '
        Me.ucrReceiverOneWayFreq.frmParent = Me
        resources.ApplyResources(Me.ucrReceiverOneWayFreq, "ucrReceiverOneWayFreq")
        Me.ucrReceiverOneWayFreq.Name = "ucrReceiverOneWayFreq"
        Me.ucrReceiverOneWayFreq.Selector = Nothing
        Me.ucrReceiverOneWayFreq.strNcFilePath = ""
        Me.ucrReceiverOneWayFreq.ucrSelector = Nothing
        '
        'ucrSaveGraph
        '
        resources.ApplyResources(Me.ucrSaveGraph, "ucrSaveGraph")
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        '
        'dlgOneWayFrequencies
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.ucrReceiverOneWayFreq)
        Me.Controls.Add(Me.rdoBoth)
        Me.Controls.Add(Me.rdoGraph)
        Me.Controls.Add(Me.ucrNudGroups)
        Me.Controls.Add(Me.rdoTable)
        Me.Controls.Add(Me.ucrPnlFrequencies)
        Me.Controls.Add(Me.ucrChkGroupData)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.ucrChkWeights)
        Me.Controls.Add(Me.ucrChkFlip)
        Me.Controls.Add(Me.lblSelectedVariable)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.grpSort)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorOneWayFreq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOneWayFrequencies"
        Me.grpSort.ResumeLayout(False)
        Me.grpSort.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorOneWayFreq As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents grpSort As GroupBox
    Friend WithEvents rdoDescendingFrequencies As RadioButton
    Friend WithEvents rdoAscendingFrequencies As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents ucrPnlSort As UcrPanel
    Friend WithEvents cmdOptions As Button
    Friend WithEvents lblSelectedVariable As Label
    Friend WithEvents ucrChkFlip As ucrCheck
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkWeights As ucrCheck
    Friend WithEvents ucrNudGroups As ucrNud
    Friend WithEvents ucrChkGroupData As ucrCheck
    Friend WithEvents rdoGraph As RadioButton
    Friend WithEvents rdoTable As RadioButton
    Friend WithEvents ucrPnlFrequencies As UcrPanel
    Friend WithEvents rdoBoth As RadioButton
    Friend WithEvents ucrReceiverOneWayFreq As ucrReceiverMultiple
    Friend WithEvents ucrSaveGraph As ucrSave
End Class
