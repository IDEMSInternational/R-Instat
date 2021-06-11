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
        Me.grdVariables = New unvell.ReoGrid.ReoGridControl()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColumnRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplicateColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReorderColumns = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusColumnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.deleteDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.hideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.copySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.viewSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.propertiesContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuDeleteLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderColumnMetadata = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.mnuBottomAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.statusColumnMenu.SuspendLayout()
        Me.propertiesContextMenuStrip.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdVariables
        '
        Me.grdVariables.BackColor = System.Drawing.Color.White
        Me.grdVariables.ColumnHeaderContextMenuStrip = Nothing
        Me.grdVariables.ContextMenuStrip = Me.cellContextMenuStrip
        Me.grdVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdVariables.LeadHeaderContextMenuStrip = Nothing
        Me.grdVariables.Location = New System.Drawing.Point(3, 23)
        Me.grdVariables.Name = "grdVariables"
        Me.grdVariables.RowHeaderContextMenuStrip = Me.columnContextMenuStrip
        Me.grdVariables.Script = Nothing
        Me.grdVariables.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdVariables.SheetTabNewButtonVisible = True
        Me.grdVariables.SheetTabVisible = True
        Me.grdVariables.SheetTabWidth = 154
        Me.grdVariables.ShowScrollEndSpacing = True
        Me.grdVariables.Size = New System.Drawing.Size(338, 92)
        Me.grdVariables.TabIndex = 2
        Me.grdVariables.Text = "Variables"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelp})
        Me.cellContextMenuStrip.Name = "ContextMenuStrip1"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(100, 26)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(99, 22)
        Me.mnuHelp.Text = "Help"
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuReorderColumns, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.ToolStripSeparator2, Me.mnuLevelsLabels, Me.ToolStripSeparator1, Me.mnuSort, Me.mnuAddComment, Me.mnuColumnFilter, Me.mnuClearColumnFilter})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(213, 374)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(212, 22)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuDuplicateColumn
        '
        Me.mnuDuplicateColumn.Name = "mnuDuplicateColumn"
        Me.mnuDuplicateColumn.Size = New System.Drawing.Size(212, 22)
        Me.mnuDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumns
        '
        Me.mnuReorderColumns.Name = "mnuReorderColumns"
        Me.mnuReorderColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuReorderColumns.Text = "Reorder Column(s)..."
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        Me.mnuInsertColsBefore.Size = New System.Drawing.Size(212, 22)
        Me.mnuInsertColsBefore.Text = "Insert Column(s) Before"
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        Me.mnuInsertColsAfter.Size = New System.Drawing.Size(212, 22)
        Me.mnuInsertColsAfter.Text = "Insert Column(s) After"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(212, 22)
        Me.mnuDeleteCol.Text = "Delete Column(s)"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuCovertToOrderedFactors
        '
        Me.mnuCovertToOrderedFactors.Name = "mnuCovertToOrderedFactors"
        Me.mnuCovertToOrderedFactors.Size = New System.Drawing.Size(212, 22)
        Me.mnuCovertToOrderedFactors.Text = "Convert to Ordered Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertToLogical
        '
        Me.mnuConvertToLogical.Name = "mnuConvertToLogical"
        Me.mnuConvertToLogical.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToLogical.Text = "Convert to Logical"
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(209, 6)
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        Me.mnuLevelsLabels.Size = New System.Drawing.Size(212, 22)
        Me.mnuLevelsLabels.Text = "Levels/Labels..."
        Me.mnuLevelsLabels.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(212, 22)
        Me.mnuSort.Text = "Sort..."
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        Me.mnuAddComment.Size = New System.Drawing.Size(212, 22)
        Me.mnuAddComment.Text = "Add Comment..."
        '
        'mnuColumnFilter
        '
        Me.mnuColumnFilter.Name = "mnuColumnFilter"
        Me.mnuColumnFilter.Size = New System.Drawing.Size(212, 22)
        Me.mnuColumnFilter.Text = "Filter..."
        '
        'mnuClearColumnFilter
        '
        Me.mnuClearColumnFilter.Name = "mnuClearColumnFilter"
        Me.mnuClearColumnFilter.Size = New System.Drawing.Size(212, 22)
        Me.mnuClearColumnFilter.Text = "Remove Current Filter"
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteDataFrame, Me.renameSheet, Me.mnuBottomAddComment, Me.hideSheet, Me.unhideSheet, Me.copySheet, Me.reorderSheet, Me.viewSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(181, 202)
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        Me.deleteDataFrame.Size = New System.Drawing.Size(180, 22)
        Me.deleteDataFrame.Text = "Delete..."
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(180, 22)
        Me.renameSheet.Text = "Rename..."
        '
        'hideSheet
        '
        Me.hideSheet.Name = "hideSheet"
        Me.hideSheet.Size = New System.Drawing.Size(180, 22)
        Me.hideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(180, 22)
        Me.unhideSheet.Text = "Unhide..."
        '
        'copySheet
        '
        Me.copySheet.Name = "copySheet"
        Me.copySheet.Size = New System.Drawing.Size(180, 22)
        Me.copySheet.Text = "Copy..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(180, 22)
        Me.reorderSheet.Text = "Reorder..."
        '
        'viewSheet
        '
        Me.viewSheet.Name = "viewSheet"
        Me.viewSheet.Size = New System.Drawing.Size(180, 22)
        Me.viewSheet.Text = "View Data Frame"
        '
        'propertiesContextMenuStrip
        '
        Me.propertiesContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDeleteLabels})
        Me.propertiesContextMenuStrip.Name = "columnContextMenuStrip"
        Me.propertiesContextMenuStrip.Size = New System.Drawing.Size(144, 26)
        '
        'mnuDeleteLabels
        '
        Me.mnuDeleteLabels.Name = "mnuDeleteLabels"
        Me.mnuDeleteLabels.Size = New System.Drawing.Size(143, 22)
        Me.mnuDeleteLabels.Text = "Delete Labels"
        '
        'lblHeaderColumnMetadata
        '
        Me.lblHeaderColumnMetadata.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderColumnMetadata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderColumnMetadata.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderColumnMetadata.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderColumnMetadata.Location = New System.Drawing.Point(3, 0)
        Me.lblHeaderColumnMetadata.Name = "lblHeaderColumnMetadata"
        Me.lblHeaderColumnMetadata.Size = New System.Drawing.Size(338, 20)
        Me.lblHeaderColumnMetadata.TabIndex = 6
        Me.lblHeaderColumnMetadata.Text = "Column Metadata"
        Me.lblHeaderColumnMetadata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.grdVariables, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderColumnMetadata, 0, 0)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(344, 138)
        Me.tlpTableContainer.TabIndex = 7
        '
        'mnuBottomAddComment
        '
        Me.mnuBottomAddComment.Name = "mnuBottomAddComment"
        Me.mnuBottomAddComment.Size = New System.Drawing.Size(180, 22)
        Me.mnuBottomAddComment.Text = "Add Comment..."
        '
        'ucrColumnMetadata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrColumnMetadata"
        Me.Size = New System.Drawing.Size(344, 138)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.propertiesContextMenuStrip.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdVariables As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblHeaderColumnMetadata As Label
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
    Friend WithEvents mnuSort As ToolStripMenuItem
    Private WithEvents mnuColumnFilter As ToolStripMenuItem
    Private WithEvents mnuClearColumnFilter As ToolStripMenuItem
    Friend WithEvents mnuConvertToLogical As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents mnuLevelsLabels As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuReorderColumns As ToolStripMenuItem
    Private WithEvents propertiesContextMenuStrip As ContextMenuStrip
    Friend WithEvents mnuDeleteLabels As ToolStripMenuItem
    Friend WithEvents cellContextMenuStrip As ContextMenuStrip
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents statusColumnMenu As ContextMenuStrip
    Friend WithEvents deleteDataFrame As ToolStripMenuItem
    Friend WithEvents renameSheet As ToolStripMenuItem
    Friend WithEvents hideSheet As ToolStripMenuItem
    Friend WithEvents unhideSheet As ToolStripMenuItem
    Friend WithEvents copySheet As ToolStripMenuItem
    Friend WithEvents reorderSheet As ToolStripMenuItem
    Friend WithEvents viewSheet As ToolStripMenuItem
    Friend WithEvents mnuAddComment As ToolStripMenuItem
    Friend WithEvents mnuBottomAddComment As ToolStripMenuItem
End Class
