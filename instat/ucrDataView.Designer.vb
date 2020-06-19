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
Partial Class ucrDataView
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
        Me.grdData = New unvell.ReoGrid.ReoGridControl()
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLevelsLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuCell = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellCutRange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellCopyRange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellPasteRange = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRenameColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReorderColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToOrderedFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToCharacter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToLogic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToNumeric = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLebelsLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSorts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilters = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveCurrentFilters = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuInsertRowsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertRowsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveCurrentFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusColumnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.deleteDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.lblRowDisplay = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDataContainer = New System.Windows.Forms.Panel()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.rowContextMenuStrip.SuspendLayout()
        Me.statusColumnMenu.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.pnlDataContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.BackColor = System.Drawing.Color.White
        Me.grdData.ColumnHeaderContextMenuStrip = Me.columnContextMenuStrip
        Me.grdData.ContextMenuStrip = Me.cellContextMenuStrip
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.LeadHeaderContextMenuStrip = Nothing
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.Margin = New System.Windows.Forms.Padding(4)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdData.SheetTabNewButtonVisible = False
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 205
        Me.grdData.ShowScrollEndSpacing = True
        Me.grdData.Size = New System.Drawing.Size(584, 292)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuReorderColumns, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.ToolStripSeparator1, Me.mnuLevelsLabels, Me.toolStripMenuItem21, Me.mnuSort, Me.mnuColumnFilter, Me.mnuClearColumnFilter})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(251, 382)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(250, 24)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuDuplicateColumn
        '
        Me.mnuDuplicateColumn.Name = "mnuDuplicateColumn"
        Me.mnuDuplicateColumn.Size = New System.Drawing.Size(250, 24)
        Me.mnuDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumns
        '
        Me.mnuReorderColumns.Name = "mnuReorderColumns"
        Me.mnuReorderColumns.Size = New System.Drawing.Size(250, 24)
        Me.mnuReorderColumns.Text = "Reorder Column(s)..."
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        Me.mnuInsertColsBefore.Size = New System.Drawing.Size(250, 24)
        Me.mnuInsertColsBefore.Text = "Insert Column(s) Before"
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        Me.mnuInsertColsAfter.Size = New System.Drawing.Size(250, 24)
        Me.mnuInsertColsAfter.Text = "Insert Column(s) After"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(250, 24)
        Me.mnuDeleteCol.Text = "Delete Column(s)"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(247, 6)
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuCovertToOrderedFactors
        '
        Me.mnuCovertToOrderedFactors.Name = "mnuCovertToOrderedFactors"
        Me.mnuCovertToOrderedFactors.Size = New System.Drawing.Size(250, 24)
        Me.mnuCovertToOrderedFactors.Text = "Convert to Ordered Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertToLogical
        '
        Me.mnuConvertToLogical.Name = "mnuConvertToLogical"
        Me.mnuConvertToLogical.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToLogical.Text = "Convert to Logical"
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(247, 6)
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        Me.mnuLevelsLabels.Size = New System.Drawing.Size(250, 24)
        Me.mnuLevelsLabels.Text = "Levels/Labels..."
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(247, 6)
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(250, 24)
        Me.mnuSort.Text = "Sort..."
        '
        'mnuColumnFilter
        '
        Me.mnuColumnFilter.Name = "mnuColumnFilter"
        Me.mnuColumnFilter.Size = New System.Drawing.Size(250, 24)
        Me.mnuColumnFilter.Text = "Filter..."
        '
        'mnuClearColumnFilter
        '
        Me.mnuClearColumnFilter.Name = "mnuClearColumnFilter"
        Me.mnuClearColumnFilter.Size = New System.Drawing.Size(250, 24)
        Me.mnuClearColumnFilter.Text = "Remove Current Filter"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCell, Me.ToolStripSeparator3, Me.mnuRenameColumn, Me.mnuDuplColumn, Me.mnuReorderColumn, Me.ToolStripSeparator5, Me.mnuConvertToFact, Me.mnuConvertToOrderedFactor, Me.mnuConvertToCharacter, Me.mnuConvertToLogic, Me.mnuConvertToNumeric, Me.ToolStripSeparator6, Me.mnuLebelsLevel, Me.ToolStripSeparator7, Me.mnuSorts, Me.mnuFilters, Me.mnuRemoveCurrentFilters})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(251, 368)
        '
        'mnuCell
        '
        Me.mnuCell.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCellCutRange, Me.mnuCellCopyRange, Me.mnuCellPasteRange, Me.mnuCellHelp})
        Me.mnuCell.Name = "mnuCell"
        Me.mnuCell.Size = New System.Drawing.Size(250, 24)
        Me.mnuCell.Text = "Cell"
        '
        'mnuCellCutRange
        '
        Me.mnuCellCutRange.Enabled = False
        Me.mnuCellCutRange.Name = "mnuCellCutRange"
        Me.mnuCellCutRange.Size = New System.Drawing.Size(216, 26)
        Me.mnuCellCutRange.Text = "Cut"
        Me.mnuCellCutRange.Visible = False
        '
        'mnuCellCopyRange
        '
        Me.mnuCellCopyRange.Name = "mnuCellCopyRange"
        Me.mnuCellCopyRange.Size = New System.Drawing.Size(216, 26)
        Me.mnuCellCopyRange.Text = "Copy"
        '
        'mnuCellPasteRange
        '
        Me.mnuCellPasteRange.Enabled = False
        Me.mnuCellPasteRange.Name = "mnuCellPasteRange"
        Me.mnuCellPasteRange.Size = New System.Drawing.Size(216, 26)
        Me.mnuCellPasteRange.Text = "Paste"
        Me.mnuCellPasteRange.Visible = False
        '
        'mnuCellHelp
        '
        Me.mnuCellHelp.Name = "mnuCellHelp"
        Me.mnuCellHelp.Size = New System.Drawing.Size(216, 26)
        Me.mnuCellHelp.Text = "Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(247, 6)
        '
        'mnuRenameColumn
        '
        Me.mnuRenameColumn.Name = "mnuRenameColumn"
        Me.mnuRenameColumn.Size = New System.Drawing.Size(250, 24)
        Me.mnuRenameColumn.Text = "Rename Column..."
        '
        'mnuDuplColumn
        '
        Me.mnuDuplColumn.Name = "mnuDuplColumn"
        Me.mnuDuplColumn.Size = New System.Drawing.Size(250, 24)
        Me.mnuDuplColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumn
        '
        Me.mnuReorderColumn.Name = "mnuReorderColumn"
        Me.mnuReorderColumn.Size = New System.Drawing.Size(250, 24)
        Me.mnuReorderColumn.Text = "Reorder Column(s)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(247, 6)
        '
        'mnuConvertToFact
        '
        Me.mnuConvertToFact.Name = "mnuConvertToFact"
        Me.mnuConvertToFact.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToFact.Text = "Convert to Factor"
        '
        'mnuConvertToOrderedFactor
        '
        Me.mnuConvertToOrderedFactor.Name = "mnuConvertToOrderedFactor"
        Me.mnuConvertToOrderedFactor.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToOrderedFactor.Text = "Convert to Ordered Factor"
        '
        'mnuConvertToCharacter
        '
        Me.mnuConvertToCharacter.Name = "mnuConvertToCharacter"
        Me.mnuConvertToCharacter.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToCharacter.Text = "Convert to Character"
        '
        'mnuConvertToLogic
        '
        Me.mnuConvertToLogic.Name = "mnuConvertToLogic"
        Me.mnuConvertToLogic.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToLogic.Text = "Convert to Logical"
        '
        'mnuConvertToNumeric
        '
        Me.mnuConvertToNumeric.Name = "mnuConvertToNumeric"
        Me.mnuConvertToNumeric.Size = New System.Drawing.Size(250, 24)
        Me.mnuConvertToNumeric.Text = "Convert to Numeric"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(247, 6)
        '
        'mnuLebelsLevel
        '
        Me.mnuLebelsLevel.Name = "mnuLebelsLevel"
        Me.mnuLebelsLevel.Size = New System.Drawing.Size(250, 24)
        Me.mnuLebelsLevel.Text = "Levels/Labels..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(247, 6)
        '
        'mnuSorts
        '
        Me.mnuSorts.Name = "mnuSorts"
        Me.mnuSorts.Size = New System.Drawing.Size(250, 24)
        Me.mnuSorts.Text = "Sort..."
        '
        'mnuFilters
        '
        Me.mnuFilters.Name = "mnuFilters"
        Me.mnuFilters.Size = New System.Drawing.Size(250, 24)
        Me.mnuFilters.Text = "Filter..."
        '
        'mnuRemoveCurrentFilters
        '
        Me.mnuRemoveCurrentFilters.Name = "mnuRemoveCurrentFilters"
        Me.mnuRemoveCurrentFilters.Size = New System.Drawing.Size(250, 24)
        Me.mnuRemoveCurrentFilters.Text = "Remove Current Filter"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRowsBefore, Me.mnuInsertRowsAfter, Me.mnuDeleteRows, Me.ToolStripSeparator2, Me.mnuAddComment, Me.ToolStripSeparator4, Me.mnuFilter, Me.mnuRemoveCurrentFilter})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(222, 160)
        '
        'mnuInsertRowsBefore
        '
        Me.mnuInsertRowsBefore.Name = "mnuInsertRowsBefore"
        Me.mnuInsertRowsBefore.Size = New System.Drawing.Size(221, 24)
        Me.mnuInsertRowsBefore.Text = "Insert Row(s) Before"
        '
        'mnuInsertRowsAfter
        '
        Me.mnuInsertRowsAfter.Name = "mnuInsertRowsAfter"
        Me.mnuInsertRowsAfter.Size = New System.Drawing.Size(221, 24)
        Me.mnuInsertRowsAfter.Text = "Insert Row(s) After"
        '
        'mnuDeleteRows
        '
        Me.mnuDeleteRows.Name = "mnuDeleteRows"
        Me.mnuDeleteRows.Size = New System.Drawing.Size(221, 24)
        Me.mnuDeleteRows.Text = "Delete Row(s)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(218, 6)
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        Me.mnuAddComment.Size = New System.Drawing.Size(221, 24)
        Me.mnuAddComment.Text = "Add Comment..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(218, 6)
        '
        'mnuFilter
        '
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(221, 24)
        Me.mnuFilter.Tag = "Filter..."
        Me.mnuFilter.Text = "Filter..."
        '
        'mnuRemoveCurrentFilter
        '
        Me.mnuRemoveCurrentFilter.Name = "mnuRemoveCurrentFilter"
        Me.mnuRemoveCurrentFilter.Size = New System.Drawing.Size(221, 24)
        Me.mnuRemoveCurrentFilter.Tag = "Remove_Current_Filter"
        Me.mnuRemoveCurrentFilter.Text = "Remove Current Filter"
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteDataFrame, Me.renameSheet, Me.HideSheet, Me.unhideSheet, Me.CopySheet, Me.reorderSheet, Me.ViewSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(192, 172)
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        Me.deleteDataFrame.Size = New System.Drawing.Size(191, 24)
        Me.deleteDataFrame.Text = "Delete..."
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(191, 24)
        Me.renameSheet.Text = "Rename..."
        '
        'HideSheet
        '
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(191, 24)
        Me.HideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(191, 24)
        Me.unhideSheet.Text = "Unhide..."
        '
        'CopySheet
        '
        Me.CopySheet.Name = "CopySheet"
        Me.CopySheet.Size = New System.Drawing.Size(191, 24)
        Me.CopySheet.Text = "Copy..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(191, 24)
        Me.reorderSheet.Text = "Reorder..."
        '
        'ViewSheet
        '
        Me.ViewSheet.Name = "ViewSheet"
        Me.ViewSheet.Size = New System.Drawing.Size(191, 24)
        Me.ViewSheet.Text = "View Data Frame"
        '
        'lblNoData
        '
        Me.lblNoData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.lblNoData.Location = New System.Drawing.Point(0, 0)
        Me.lblNoData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(584, 292)
        Me.lblNoData.TabIndex = 1
        Me.lblNoData.Tag = "no_data_loaded"
        Me.lblNoData.Text = "No Data Loaded"
        Me.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowDisplay
        '
        Me.lblRowDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowDisplay.Location = New System.Drawing.Point(4, 325)
        Me.lblRowDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowDisplay.Name = "lblRowDisplay"
        Me.lblRowDisplay.Size = New System.Drawing.Size(584, 25)
        Me.lblRowDisplay.TabIndex = 4
        Me.lblRowDisplay.Text = "Label1"
        Me.lblRowDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeader.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeader.Location = New System.Drawing.Point(4, 0)
        Me.lblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(584, 25)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "Data View"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.lblRowDisplay, 0, 2)
        Me.tlpTableContainer.Controls.Add(Me.pnlDataContainer, 0, 1)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(592, 350)
        Me.tlpTableContainer.TabIndex = 6
        '
        'pnlDataContainer
        '
        Me.pnlDataContainer.Controls.Add(Me.grdData)
        Me.pnlDataContainer.Controls.Add(Me.lblNoData)
        Me.pnlDataContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataContainer.Location = New System.Drawing.Point(4, 29)
        Me.pnlDataContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlDataContainer.Name = "pnlDataContainer"
        Me.pnlDataContainer.Size = New System.Drawing.Size(584, 292)
        Me.pnlDataContainer.TabIndex = 7
        '
        'ucrDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucrDataView"
        Me.Size = New System.Drawing.Size(592, 350)
        Me.Tag = "Data_View"
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.pnlDataContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents grdData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblNoData As Label
    Private WithEvents columnContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertColsBefore As ToolStripMenuItem
    Private WithEvents mnuDeleteCol As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Private WithEvents toolStripMenuItem21 As ToolStripSeparator
    Private WithEvents mnuColumnFilter As ToolStripMenuItem
    Private WithEvents mnuClearColumnFilter As ToolStripMenuItem
    Private WithEvents cellContextMenuStrip As ContextMenuStrip
    Private WithEvents rowContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertRowsAfter As ToolStripMenuItem
    Private WithEvents mnuDeleteRows As ToolStripMenuItem
    Friend WithEvents statusColumnMenu As ContextMenuStrip
    Friend WithEvents deleteDataFrame As ToolStripMenuItem
    Friend WithEvents renameSheet As ToolStripMenuItem
    Friend WithEvents mnuColumnRename As ToolStripMenuItem
    Friend WithEvents mnuConvertText As ToolStripMenuItem
    Friend WithEvents mnuConvertVariate As ToolStripMenuItem
    Friend WithEvents mnuConvertToFactor As ToolStripMenuItem
    Friend WithEvents CopySheet As ToolStripMenuItem
    Friend WithEvents HideSheet As ToolStripMenuItem
    Friend WithEvents reorderSheet As ToolStripMenuItem
    Friend WithEvents unhideSheet As ToolStripMenuItem
    Friend WithEvents mnuInsertColsAfter As ToolStripMenuItem
    Friend WithEvents mnuInsertRowsBefore As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuFilter As ToolStripMenuItem
    Friend WithEvents mnuRemoveCurrentFilter As ToolStripMenuItem
    Friend WithEvents mnuSort As ToolStripMenuItem
    Friend WithEvents ViewSheet As ToolStripMenuItem
    Friend WithEvents mnuCovertToOrderedFactors As ToolStripMenuItem
    Friend WithEvents mnuDuplicateColumn As ToolStripMenuItem
    Friend WithEvents lblRowDisplay As Label
    Friend WithEvents mnuAddComment As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lblHeader As Label
    Friend WithEvents mnuConvertToLogical As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents pnlDataContainer As Panel
    Friend WithEvents mnuLevelsLabels As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuReorderColumns As ToolStripMenuItem
    Friend WithEvents mnuCell As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuRenameColumn As ToolStripMenuItem
    Friend WithEvents mnuDuplColumn As ToolStripMenuItem
    Friend WithEvents mnuReorderColumn As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuConvertToFact As ToolStripMenuItem
    Friend WithEvents mnuConvertToOrderedFactor As ToolStripMenuItem
    Friend WithEvents mnuConvertToCharacter As ToolStripMenuItem
    Friend WithEvents mnuConvertToLogic As ToolStripMenuItem
    Friend WithEvents mnuConvertToNumeric As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuLebelsLevel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents mnuSorts As ToolStripMenuItem
    Private WithEvents mnuFilters As ToolStripMenuItem
    Private WithEvents mnuRemoveCurrentFilters As ToolStripMenuItem
    Private WithEvents mnuCellCutRange As ToolStripMenuItem
    Private WithEvents mnuCellCopyRange As ToolStripMenuItem
    Private WithEvents mnuCellPasteRange As ToolStripMenuItem
    Friend WithEvents mnuCellHelp As ToolStripMenuItem
End Class
