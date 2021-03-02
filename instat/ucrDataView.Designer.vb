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
        Me.lblRowDisplay = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDataContainer = New System.Windows.Forms.Panel()
        Me.panelSectionsAll = New System.Windows.Forms.Panel()
        Me.linkHelpInstructionVideos = New System.Windows.Forms.LinkLabel()
        Me.linkHelpRInstatWebsite = New System.Windows.Forms.LinkLabel()
        Me.linkHelpRpackages = New System.Windows.Forms.LinkLabel()
        Me.linkHelpIntroduction = New System.Windows.Forms.LinkLabel()
        Me.panelRecentMenuItems = New System.Windows.Forms.Panel()
        Me.linkStartOpenLibrary = New System.Windows.Forms.LinkLabel()
        Me.linkStartOpenFile = New System.Windows.Forms.LinkLabel()
        Me.linkStartNewDataFrame = New System.Windows.Forms.LinkLabel()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.panelSectionStart = New System.Windows.Forms.Panel()
        Me.panelSectionHelp = New System.Windows.Forms.Panel()
        Me.panelSectionRecent = New System.Windows.Forms.Panel()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.rowContextMenuStrip.SuspendLayout()
        Me.statusColumnMenu.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.pnlDataContainer.SuspendLayout()
        Me.panelSectionsAll.SuspendLayout()
        Me.panelSectionStart.SuspendLayout()
        Me.panelSectionHelp.SuspendLayout()
        Me.panelSectionRecent.SuspendLayout()
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
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdData.SheetTabNewButtonVisible = False
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 154
        Me.grdData.ShowScrollEndSpacing = True
        Me.grdData.Size = New System.Drawing.Size(438, 454)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuReorderColumns, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.ToolStripSeparator1, Me.mnuLevelsLabels, Me.toolStripMenuItem21, Me.mnuSort, Me.mnuColumnFilter, Me.mnuClearColumnFilter})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(213, 352)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        Me.mnuLevelsLabels.Size = New System.Drawing.Size(212, 22)
        Me.mnuLevelsLabels.Text = "Levels/Labels..."
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(209, 6)
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(212, 22)
        Me.mnuSort.Text = "Sort..."
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
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCell, Me.ToolStripSeparator3, Me.mnuRenameColumn, Me.mnuDuplColumn, Me.mnuReorderColumn, Me.ToolStripSeparator5, Me.mnuConvertToFact, Me.mnuConvertToOrderedFactor, Me.mnuConvertToCharacter, Me.mnuConvertToLogic, Me.mnuConvertToNumeric, Me.ToolStripSeparator6, Me.mnuLebelsLevel, Me.ToolStripSeparator7, Me.mnuSorts, Me.mnuFilters, Me.mnuRemoveCurrentFilters})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(213, 314)
        '
        'mnuCell
        '
        Me.mnuCell.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCellCutRange, Me.mnuCellCopyRange, Me.mnuCellPasteRange, Me.mnuCellHelp})
        Me.mnuCell.Name = "mnuCell"
        Me.mnuCell.Size = New System.Drawing.Size(212, 22)
        Me.mnuCell.Text = "Cell"
        '
        'mnuCellCutRange
        '
        Me.mnuCellCutRange.Enabled = False
        Me.mnuCellCutRange.Name = "mnuCellCutRange"
        Me.mnuCellCutRange.Size = New System.Drawing.Size(102, 22)
        Me.mnuCellCutRange.Text = "Cut"
        Me.mnuCellCutRange.Visible = False
        '
        'mnuCellCopyRange
        '
        Me.mnuCellCopyRange.Name = "mnuCellCopyRange"
        Me.mnuCellCopyRange.Size = New System.Drawing.Size(102, 22)
        Me.mnuCellCopyRange.Text = "Copy"
        '
        'mnuCellPasteRange
        '
        Me.mnuCellPasteRange.Enabled = False
        Me.mnuCellPasteRange.Name = "mnuCellPasteRange"
        Me.mnuCellPasteRange.Size = New System.Drawing.Size(102, 22)
        Me.mnuCellPasteRange.Text = "Paste"
        Me.mnuCellPasteRange.Visible = False
        '
        'mnuCellHelp
        '
        Me.mnuCellHelp.Name = "mnuCellHelp"
        Me.mnuCellHelp.Size = New System.Drawing.Size(102, 22)
        Me.mnuCellHelp.Text = "Help"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'mnuRenameColumn
        '
        Me.mnuRenameColumn.Name = "mnuRenameColumn"
        Me.mnuRenameColumn.Size = New System.Drawing.Size(212, 22)
        Me.mnuRenameColumn.Text = "Rename Column..."
        '
        'mnuDuplColumn
        '
        Me.mnuDuplColumn.Name = "mnuDuplColumn"
        Me.mnuDuplColumn.Size = New System.Drawing.Size(212, 22)
        Me.mnuDuplColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumn
        '
        Me.mnuReorderColumn.Name = "mnuReorderColumn"
        Me.mnuReorderColumn.Size = New System.Drawing.Size(212, 22)
        Me.mnuReorderColumn.Text = "Reorder Column(s)..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(209, 6)
        '
        'mnuConvertToFact
        '
        Me.mnuConvertToFact.Name = "mnuConvertToFact"
        Me.mnuConvertToFact.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToFact.Text = "Convert to Factor"
        '
        'mnuConvertToOrderedFactor
        '
        Me.mnuConvertToOrderedFactor.Name = "mnuConvertToOrderedFactor"
        Me.mnuConvertToOrderedFactor.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToOrderedFactor.Text = "Convert to Ordered Factor"
        '
        'mnuConvertToCharacter
        '
        Me.mnuConvertToCharacter.Name = "mnuConvertToCharacter"
        Me.mnuConvertToCharacter.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToCharacter.Text = "Convert to Character"
        '
        'mnuConvertToLogic
        '
        Me.mnuConvertToLogic.Name = "mnuConvertToLogic"
        Me.mnuConvertToLogic.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToLogic.Text = "Convert to Logical"
        '
        'mnuConvertToNumeric
        '
        Me.mnuConvertToNumeric.Name = "mnuConvertToNumeric"
        Me.mnuConvertToNumeric.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToNumeric.Text = "Convert to Numeric"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(209, 6)
        '
        'mnuLebelsLevel
        '
        Me.mnuLebelsLevel.Name = "mnuLebelsLevel"
        Me.mnuLebelsLevel.Size = New System.Drawing.Size(212, 22)
        Me.mnuLebelsLevel.Text = "Levels/Labels..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(209, 6)
        '
        'mnuSorts
        '
        Me.mnuSorts.Name = "mnuSorts"
        Me.mnuSorts.Size = New System.Drawing.Size(212, 22)
        Me.mnuSorts.Text = "Sort..."
        '
        'mnuFilters
        '
        Me.mnuFilters.Name = "mnuFilters"
        Me.mnuFilters.Size = New System.Drawing.Size(212, 22)
        Me.mnuFilters.Text = "Filter..."
        '
        'mnuRemoveCurrentFilters
        '
        Me.mnuRemoveCurrentFilters.Name = "mnuRemoveCurrentFilters"
        Me.mnuRemoveCurrentFilters.Size = New System.Drawing.Size(212, 22)
        Me.mnuRemoveCurrentFilters.Text = "Remove Current Filter"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRowsBefore, Me.mnuInsertRowsAfter, Me.mnuDeleteRows, Me.ToolStripSeparator2, Me.mnuAddComment, Me.ToolStripSeparator4, Me.mnuFilter, Me.mnuRemoveCurrentFilter})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(190, 148)
        '
        'mnuInsertRowsBefore
        '
        Me.mnuInsertRowsBefore.Name = "mnuInsertRowsBefore"
        Me.mnuInsertRowsBefore.Size = New System.Drawing.Size(189, 22)
        Me.mnuInsertRowsBefore.Text = "Insert Row(s) Before"
        '
        'mnuInsertRowsAfter
        '
        Me.mnuInsertRowsAfter.Name = "mnuInsertRowsAfter"
        Me.mnuInsertRowsAfter.Size = New System.Drawing.Size(189, 22)
        Me.mnuInsertRowsAfter.Text = "Insert Row(s) After"
        '
        'mnuDeleteRows
        '
        Me.mnuDeleteRows.Name = "mnuDeleteRows"
        Me.mnuDeleteRows.Size = New System.Drawing.Size(189, 22)
        Me.mnuDeleteRows.Text = "Delete Row(s)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(186, 6)
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        Me.mnuAddComment.Size = New System.Drawing.Size(189, 22)
        Me.mnuAddComment.Text = "Add Comment..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(186, 6)
        '
        'mnuFilter
        '
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(189, 22)
        Me.mnuFilter.Tag = "Filter..."
        Me.mnuFilter.Text = "Filter..."
        '
        'mnuRemoveCurrentFilter
        '
        Me.mnuRemoveCurrentFilter.Name = "mnuRemoveCurrentFilter"
        Me.mnuRemoveCurrentFilter.Size = New System.Drawing.Size(189, 22)
        Me.mnuRemoveCurrentFilter.Tag = "Remove_Current_Filter"
        Me.mnuRemoveCurrentFilter.Text = "Remove Current Filter"
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteDataFrame, Me.renameSheet, Me.HideSheet, Me.unhideSheet, Me.CopySheet, Me.reorderSheet, Me.ViewSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(163, 158)
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        Me.deleteDataFrame.Size = New System.Drawing.Size(162, 22)
        Me.deleteDataFrame.Text = "Delete..."
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(162, 22)
        Me.renameSheet.Text = "Rename..."
        '
        'HideSheet
        '
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(162, 22)
        Me.HideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(162, 22)
        Me.unhideSheet.Text = "Unhide..."
        '
        'CopySheet
        '
        Me.CopySheet.Name = "CopySheet"
        Me.CopySheet.Size = New System.Drawing.Size(162, 22)
        Me.CopySheet.Text = "Copy..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(162, 22)
        Me.reorderSheet.Text = "Reorder..."
        '
        'ViewSheet
        '
        Me.ViewSheet.Name = "ViewSheet"
        Me.ViewSheet.Size = New System.Drawing.Size(162, 22)
        Me.ViewSheet.Text = "View Data Frame"
        '
        'lblRowDisplay
        '
        Me.lblRowDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowDisplay.Location = New System.Drawing.Point(3, 480)
        Me.lblRowDisplay.Name = "lblRowDisplay"
        Me.lblRowDisplay.Size = New System.Drawing.Size(438, 20)
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
        Me.lblHeader.Location = New System.Drawing.Point(3, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(438, 20)
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
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(444, 500)
        Me.tlpTableContainer.TabIndex = 6
        '
        'pnlDataContainer
        '
        Me.pnlDataContainer.Controls.Add(Me.panelSectionsAll)
        Me.pnlDataContainer.Controls.Add(Me.grdData)
        Me.pnlDataContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataContainer.Location = New System.Drawing.Point(3, 23)
        Me.pnlDataContainer.Name = "pnlDataContainer"
        Me.pnlDataContainer.Size = New System.Drawing.Size(438, 454)
        Me.pnlDataContainer.TabIndex = 7
        '
        'panelSectionsAll
        '
        Me.panelSectionsAll.Controls.Add(Me.panelSectionRecent)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionHelp)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionStart)
        Me.panelSectionsAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSectionsAll.Location = New System.Drawing.Point(0, 0)
        Me.panelSectionsAll.Name = "panelSectionsAll"
        Me.panelSectionsAll.Size = New System.Drawing.Size(438, 454)
        Me.panelSectionsAll.TabIndex = 7
        '
        'linkHelpInstructionVideos
        '
        Me.linkHelpInstructionVideos.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpInstructionVideos.AutoSize = True
        Me.linkHelpInstructionVideos.Enabled = False
        Me.linkHelpInstructionVideos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpInstructionVideos.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpInstructionVideos.Location = New System.Drawing.Point(8, 94)
        Me.linkHelpInstructionVideos.Name = "linkHelpInstructionVideos"
        Me.linkHelpInstructionVideos.Size = New System.Drawing.Size(98, 13)
        Me.linkHelpInstructionVideos.TabIndex = 10
        Me.linkHelpInstructionVideos.TabStop = True
        Me.linkHelpInstructionVideos.Text = "Instructional videos"
        Me.linkHelpInstructionVideos.Visible = False
        '
        'linkHelpRInstatWebsite
        '
        Me.linkHelpRInstatWebsite.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpRInstatWebsite.AutoSize = True
        Me.linkHelpRInstatWebsite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpRInstatWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpRInstatWebsite.Location = New System.Drawing.Point(8, 75)
        Me.linkHelpRInstatWebsite.Name = "linkHelpRInstatWebsite"
        Me.linkHelpRInstatWebsite.Size = New System.Drawing.Size(83, 13)
        Me.linkHelpRInstatWebsite.TabIndex = 9
        Me.linkHelpRInstatWebsite.TabStop = True
        Me.linkHelpRInstatWebsite.Text = "R-Instat website"
        '
        'linkHelpRpackages
        '
        Me.linkHelpRpackages.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpRpackages.AutoSize = True
        Me.linkHelpRpackages.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpRpackages.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpRpackages.Location = New System.Drawing.Point(8, 56)
        Me.linkHelpRpackages.Name = "linkHelpRpackages"
        Me.linkHelpRpackages.Size = New System.Drawing.Size(116, 13)
        Me.linkHelpRpackages.TabIndex = 8
        Me.linkHelpRpackages.TabStop = True
        Me.linkHelpRpackages.Text = "R packages in R-Instat"
        '
        'linkHelpIntroduction
        '
        Me.linkHelpIntroduction.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpIntroduction.AutoSize = True
        Me.linkHelpIntroduction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpIntroduction.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpIntroduction.Location = New System.Drawing.Point(8, 37)
        Me.linkHelpIntroduction.Name = "linkHelpIntroduction"
        Me.linkHelpIntroduction.Size = New System.Drawing.Size(63, 13)
        Me.linkHelpIntroduction.TabIndex = 7
        Me.linkHelpIntroduction.TabStop = True
        Me.linkHelpIntroduction.Text = "Introduction"
        '
        'panelRecentMenuItems
        '
        Me.panelRecentMenuItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRecentMenuItems.AutoScroll = True
        Me.panelRecentMenuItems.Location = New System.Drawing.Point(9, 37)
        Me.panelRecentMenuItems.Name = "panelRecentMenuItems"
        Me.panelRecentMenuItems.Size = New System.Drawing.Size(354, 138)
        Me.panelRecentMenuItems.TabIndex = 6
        '
        'linkStartOpenLibrary
        '
        Me.linkStartOpenLibrary.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkStartOpenLibrary.AutoSize = True
        Me.linkStartOpenLibrary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartOpenLibrary.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartOpenLibrary.Location = New System.Drawing.Point(7, 75)
        Me.linkStartOpenLibrary.Name = "linkStartOpenLibrary"
        Me.linkStartOpenLibrary.Size = New System.Drawing.Size(95, 13)
        Me.linkStartOpenLibrary.TabIndex = 5
        Me.linkStartOpenLibrary.TabStop = True
        Me.linkStartOpenLibrary.Text = "Open from library..."
        '
        'linkStartOpenFile
        '
        Me.linkStartOpenFile.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkStartOpenFile.AutoSize = True
        Me.linkStartOpenFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartOpenFile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartOpenFile.Location = New System.Drawing.Point(7, 56)
        Me.linkStartOpenFile.Name = "linkStartOpenFile"
        Me.linkStartOpenFile.Size = New System.Drawing.Size(81, 13)
        Me.linkStartOpenFile.TabIndex = 4
        Me.linkStartOpenFile.TabStop = True
        Me.linkStartOpenFile.Text = "Open from file..."
        '
        'linkStartNewDataFrame
        '
        Me.linkStartNewDataFrame.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkStartNewDataFrame.AutoSize = True
        Me.linkStartNewDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartNewDataFrame.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartNewDataFrame.Location = New System.Drawing.Point(7, 37)
        Me.linkStartNewDataFrame.Name = "linkStartNewDataFrame"
        Me.linkStartNewDataFrame.Size = New System.Drawing.Size(96, 13)
        Me.linkStartNewDataFrame.TabIndex = 3
        Me.linkStartNewDataFrame.TabStop = True
        Me.linkStartNewDataFrame.Text = "New Data Frame..."
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHelp.Location = New System.Drawing.Point(6, 8)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(56, 25)
        Me.lblHelp.TabIndex = 2
        Me.lblHelp.Text = "Help"
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecent.Location = New System.Drawing.Point(4, 8)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(80, 25)
        Me.lblRecent.TabIndex = 1
        Me.lblRecent.Text = "Recent"
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStart.Location = New System.Drawing.Point(5, 6)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(57, 25)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Start"
        '
        'panelSectionStart
        '
        Me.panelSectionStart.Controls.Add(Me.lblStart)
        Me.panelSectionStart.Controls.Add(Me.linkStartNewDataFrame)
        Me.panelSectionStart.Controls.Add(Me.linkStartOpenFile)
        Me.panelSectionStart.Controls.Add(Me.linkStartOpenLibrary)
        Me.panelSectionStart.Location = New System.Drawing.Point(28, 20)
        Me.panelSectionStart.Name = "panelSectionStart"
        Me.panelSectionStart.Size = New System.Drawing.Size(374, 96)
        Me.panelSectionStart.TabIndex = 11
        '
        'panelSectionHelp
        '
        Me.panelSectionHelp.Controls.Add(Me.lblHelp)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpIntroduction)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpInstructionVideos)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpRpackages)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpRInstatWebsite)
        Me.panelSectionHelp.Location = New System.Drawing.Point(28, 330)
        Me.panelSectionHelp.Name = "panelSectionHelp"
        Me.panelSectionHelp.Size = New System.Drawing.Size(374, 118)
        Me.panelSectionHelp.TabIndex = 12
        '
        'panelSectionRecent
        '
        Me.panelSectionRecent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSectionRecent.Controls.Add(Me.lblRecent)
        Me.panelSectionRecent.Controls.Add(Me.panelRecentMenuItems)
        Me.panelSectionRecent.Location = New System.Drawing.Point(28, 130)
        Me.panelSectionRecent.Name = "panelSectionRecent"
        Me.panelSectionRecent.Size = New System.Drawing.Size(374, 186)
        Me.panelSectionRecent.TabIndex = 13
        '
        'ucrDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrDataView"
        Me.Size = New System.Drawing.Size(444, 500)
        Me.Tag = "Data_View"
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.pnlDataContainer.ResumeLayout(False)
        Me.panelSectionsAll.ResumeLayout(False)
        Me.panelSectionStart.ResumeLayout(False)
        Me.panelSectionStart.PerformLayout()
        Me.panelSectionHelp.ResumeLayout(False)
        Me.panelSectionHelp.PerformLayout()
        Me.panelSectionRecent.ResumeLayout(False)
        Me.panelSectionRecent.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents grdData As unvell.ReoGrid.ReoGridControl
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
    Friend WithEvents panelSectionsAll As Panel
    Friend WithEvents linkStartOpenLibrary As LinkLabel
    Friend WithEvents linkStartOpenFile As LinkLabel
    Friend WithEvents linkStartNewDataFrame As LinkLabel
    Friend WithEvents lblHelp As Label
    Friend WithEvents lblRecent As Label
    Friend WithEvents lblStart As Label
    Friend WithEvents panelRecentMenuItems As Panel
    Friend WithEvents linkHelpInstructionVideos As LinkLabel
    Friend WithEvents linkHelpRInstatWebsite As LinkLabel
    Friend WithEvents linkHelpRpackages As LinkLabel
    Friend WithEvents linkHelpIntroduction As LinkLabel
    Friend WithEvents panelSectionRecent As Panel
    Friend WithEvents panelSectionHelp As Panel
    Friend WithEvents panelSectionStart As Panel
End Class
