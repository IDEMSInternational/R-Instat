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
Partial Class ucrColumnMetadata
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrColumnMetadata))
        Me.grdVariables = New unvell.ReoGrid.ReoGridControl()
        Me.columnContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColumnRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplicateColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCovertToOrderedFactors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToLogical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLevelsLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFreezeToHere = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnfreeze = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdVariables
        '
        Me.grdVariables.BackColor = System.Drawing.Color.White
        Me.grdVariables.ColumnHeaderContextMenuStrip = Nothing
        resources.ApplyResources(Me.grdVariables, "grdVariables")
        Me.grdVariables.LeadHeaderContextMenuStrip = Nothing
        Me.grdVariables.Name = "grdVariables"
        Me.grdVariables.RowHeaderContextMenuStrip = Me.columnContextMenuStrip
        Me.grdVariables.Script = Nothing
        Me.grdVariables.SheetTabContextMenuStrip = Nothing
        Me.grdVariables.SheetTabNewButtonVisible = True
        Me.grdVariables.SheetTabVisible = True
        Me.grdVariables.SheetTabWidth = 154
        Me.grdVariables.ShowScrollEndSpacing = True
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.ToolStripSeparator2, Me.mnuLevelsLabels, Me.ToolStripSeparator1, Me.mnuFreezeToHere, Me.mnuUnfreeze, Me.ToolStripSeparator3, Me.mnuSort, Me.mnuColumnFilter, Me.mnuClearColumnFilter})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        resources.ApplyResources(Me.columnContextMenuStrip, "columnContextMenuStrip")
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        resources.ApplyResources(Me.mnuColumnRename, "mnuColumnRename")
        '
        'mnuDuplicateColumn
        '
        Me.mnuDuplicateColumn.Name = "mnuDuplicateColumn"
        resources.ApplyResources(Me.mnuDuplicateColumn, "mnuDuplicateColumn")
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        resources.ApplyResources(Me.mnuInsertColsBefore, "mnuInsertColsBefore")
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        resources.ApplyResources(Me.mnuInsertColsAfter, "mnuInsertColsAfter")
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        resources.ApplyResources(Me.mnuDeleteCol, "mnuDeleteCol")
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        resources.ApplyResources(Me.toolStripMenuItem2, "toolStripMenuItem2")
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        resources.ApplyResources(Me.mnuConvertToFactor, "mnuConvertToFactor")
        '
        'mnuCovertToOrderedFactors
        '
        Me.mnuCovertToOrderedFactors.Name = "mnuCovertToOrderedFactors"
        resources.ApplyResources(Me.mnuCovertToOrderedFactors, "mnuCovertToOrderedFactors")
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        resources.ApplyResources(Me.mnuConvertText, "mnuConvertText")
        '
        'mnuConvertToLogical
        '
        Me.mnuConvertToLogical.Name = "mnuConvertToLogical"
        resources.ApplyResources(Me.mnuConvertToLogical, "mnuConvertToLogical")
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        resources.ApplyResources(Me.mnuConvertVariate, "mnuConvertVariate")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        resources.ApplyResources(Me.mnuLevelsLabels, "mnuLevelsLabels")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'mnuFreezeToHere
        '
        Me.mnuFreezeToHere.Name = "mnuFreezeToHere"
        resources.ApplyResources(Me.mnuFreezeToHere, "mnuFreezeToHere")
        '
        'mnuUnfreeze
        '
        Me.mnuUnfreeze.Name = "mnuUnfreeze"
        resources.ApplyResources(Me.mnuUnfreeze, "mnuUnfreeze")
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        resources.ApplyResources(Me.ToolStripSeparator3, "ToolStripSeparator3")
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        resources.ApplyResources(Me.mnuSort, "mnuSort")
        '
        'mnuColumnFilter
        '
        Me.mnuColumnFilter.Name = "mnuColumnFilter"
        resources.ApplyResources(Me.mnuColumnFilter, "mnuColumnFilter")
        '
        'mnuClearColumnFilter
        '
        Me.mnuClearColumnFilter.Name = "mnuClearColumnFilter"
        resources.ApplyResources(Me.mnuClearColumnFilter, "mnuClearColumnFilter")
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        resources.ApplyResources(Me.lblHeader, "lblHeader")
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Name = "lblHeader"
        '
        'tlpTableContainer
        '
        resources.ApplyResources(Me.tlpTableContainer, "tlpTableContainer")
        Me.tlpTableContainer.Controls.Add(Me.grdVariables, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        '
        'ucrColumnMetadata
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrColumnMetadata"
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdVariables As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblHeader As Label
    Private WithEvents columnContextMenuStrip As ContextMenuStrip
    Friend WithEvents mnuColumnRename As ToolStripMenuItem
    Friend WithEvents mnuDuplicateColumn As ToolStripMenuItem
    Private WithEvents mnuInsertColsBefore As ToolStripMenuItem
    Friend WithEvents mnuInsertColsAfter As ToolStripMenuItem
    Private WithEvents mnuDeleteCol As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnuConvertToFactor As ToolStripMenuItem
    Friend WithEvents mnuCovertToOrderedFactors As ToolStripMenuItem
    Friend WithEvents mnuConvertText As ToolStripMenuItem
    Friend WithEvents mnuConvertVariate As ToolStripMenuItem
    Friend WithEvents mnuFreezeToHere As ToolStripMenuItem
    Friend WithEvents mnuUnfreeze As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuSort As ToolStripMenuItem
    Private WithEvents mnuColumnFilter As ToolStripMenuItem
    Private WithEvents mnuClearColumnFilter As ToolStripMenuItem
    Friend WithEvents mnuConvertToLogical As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents mnuLevelsLabels As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
