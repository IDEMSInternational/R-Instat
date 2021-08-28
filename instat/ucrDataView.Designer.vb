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
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuColumnAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRenameColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReorderColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellPasteRange = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuComment = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.mnuBottomAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderDataView = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlDataContainer = New System.Windows.Forms.Panel()
        Me.panelSectionsAll = New System.Windows.Forms.Panel()
        Me.panelSectionRecent = New System.Windows.Forms.Panel()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.panelRecentMenuItems = New System.Windows.Forms.Panel()
        Me.panelSectionHelp = New System.Windows.Forms.Panel()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.linkHelpIntroduction = New System.Windows.Forms.LinkLabel()
        Me.linkHelpInstructionVideos = New System.Windows.Forms.LinkLabel()
        Me.linkHelpRpackages = New System.Windows.Forms.LinkLabel()
        Me.linkHelpRInstatWebsite = New System.Windows.Forms.LinkLabel()
        Me.panelSectionStart = New System.Windows.Forms.Panel()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.linkStartNewDataFrame = New System.Windows.Forms.LinkLabel()
        Me.linkStartOpenFile = New System.Windows.Forms.LinkLabel()
        Me.linkStartOpenLibrary = New System.Windows.Forms.LinkLabel()
        Me.TblPanPageDisplay = New System.Windows.Forms.TableLayoutPanel()
        Me.lblColFirst = New System.Windows.Forms.Label()
        Me.lblColDisplay = New System.Windows.Forms.Label()
        Me.lblColNext = New System.Windows.Forms.Label()
        Me.lblColBack = New System.Windows.Forms.Label()
        Me.lblRowLast = New System.Windows.Forms.Label()
        Me.lblRowFirst = New System.Windows.Forms.Label()
        Me.lblRowDisplay = New System.Windows.Forms.Label()
        Me.lblRowNext = New System.Windows.Forms.Label()
        Me.lblColLast = New System.Windows.Forms.Label()
        Me.lblRowBack = New System.Windows.Forms.Label()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.rowContextMenuStrip.SuspendLayout()
        Me.statusColumnMenu.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.pnlDataContainer.SuspendLayout()
        Me.panelSectionsAll.SuspendLayout()
        Me.panelSectionRecent.SuspendLayout()
        Me.panelSectionHelp.SuspendLayout()
        Me.panelSectionStart.SuspendLayout()
        Me.TblPanPageDisplay.SuspendLayout()
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
        Me.grdData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdData.SheetTabNewButtonVisible = False
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 231
        Me.grdData.ShowScrollEndSpacing = True
        Me.grdData.Size = New System.Drawing.Size(658, 697)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuReorderColumns, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.mnuPaste, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.ToolStripSeparator1, Me.mnuLevelsLabels, Me.toolStripMenuItem21, Me.mnuSort, Me.mnuColumnAddComment, Me.mnuColumnFilter, Me.mnuClearColumnFilter})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(293, 566)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(292, 32)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuDuplicateColumn
        '
        Me.mnuDuplicateColumn.Name = "mnuDuplicateColumn"
        Me.mnuDuplicateColumn.Size = New System.Drawing.Size(292, 32)
        Me.mnuDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumns
        '
        Me.mnuReorderColumns.Name = "mnuReorderColumns"
        Me.mnuReorderColumns.Size = New System.Drawing.Size(292, 32)
        Me.mnuReorderColumns.Text = "Reorder Column(s)..."
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        Me.mnuInsertColsBefore.Size = New System.Drawing.Size(292, 32)
        Me.mnuInsertColsBefore.Text = "Insert Column(s) Before"
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        Me.mnuInsertColsAfter.Size = New System.Drawing.Size(292, 32)
        Me.mnuInsertColsAfter.Text = "Insert Column(s) After"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(292, 32)
        Me.mnuDeleteCol.Text = "Delete Column(s)"
        '
        'mnuPaste
        '
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(292, 32)
        Me.mnuPaste.Text = "Paste"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(289, 6)
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuCovertToOrderedFactors
        '
        Me.mnuCovertToOrderedFactors.Name = "mnuCovertToOrderedFactors"
        Me.mnuCovertToOrderedFactors.Size = New System.Drawing.Size(292, 32)
        Me.mnuCovertToOrderedFactors.Text = "Convert to Ordered Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertToLogical
        '
        Me.mnuConvertToLogical.Name = "mnuConvertToLogical"
        Me.mnuConvertToLogical.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToLogical.Text = "Convert to Logical"
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(289, 6)
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        Me.mnuLevelsLabels.Size = New System.Drawing.Size(292, 32)
        Me.mnuLevelsLabels.Text = "Levels/Labels..."
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(289, 6)
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(292, 32)
        Me.mnuSort.Text = "Sort..."
        '
        'mnuColumnAddComment
        '
        Me.mnuColumnAddComment.Name = "mnuColumnAddComment"
        Me.mnuColumnAddComment.Size = New System.Drawing.Size(292, 32)
        Me.mnuColumnAddComment.Text = "Add Comment..."
        '
        'mnuColumnFilter
        '
        Me.mnuColumnFilter.Name = "mnuColumnFilter"
        Me.mnuColumnFilter.Size = New System.Drawing.Size(292, 32)
        Me.mnuColumnFilter.Text = "Filter..."
        '
        'mnuClearColumnFilter
        '
        Me.mnuClearColumnFilter.Name = "mnuClearColumnFilter"
        Me.mnuClearColumnFilter.Size = New System.Drawing.Size(292, 32)
        Me.mnuClearColumnFilter.Text = "Remove Current Filter"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.mnuRenameColumn, Me.mnuDuplColumn, Me.mnuReorderColumn, Me.mnuCellPasteRange, Me.ToolStripSeparator5, Me.mnuConvertToFact, Me.mnuConvertToOrderedFactor, Me.mnuConvertToCharacter, Me.mnuConvertToLogic, Me.mnuConvertToNumeric, Me.ToolStripSeparator6, Me.mnuLebelsLevel, Me.ToolStripSeparator7, Me.mnuSorts, Me.mnuComment, Me.mnuFilters, Me.mnuRemoveCurrentFilters})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(293, 476)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(289, 6)
        '
        'mnuRenameColumn
        '
        Me.mnuRenameColumn.Name = "mnuRenameColumn"
        Me.mnuRenameColumn.Size = New System.Drawing.Size(292, 32)
        Me.mnuRenameColumn.Text = "Rename Column..."
        '
        'mnuDuplColumn
        '
        Me.mnuDuplColumn.Name = "mnuDuplColumn"
        Me.mnuDuplColumn.Size = New System.Drawing.Size(292, 32)
        Me.mnuDuplColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumn
        '
        Me.mnuReorderColumn.Name = "mnuReorderColumn"
        Me.mnuReorderColumn.Size = New System.Drawing.Size(292, 32)
        Me.mnuReorderColumn.Text = "Reorder Column(s)..."
        '
        'mnuCellPasteRange
        '
        Me.mnuCellPasteRange.Name = "mnuCellPasteRange"
        Me.mnuCellPasteRange.Size = New System.Drawing.Size(292, 32)
        Me.mnuCellPasteRange.Text = "Paste"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(289, 6)
        '
        'mnuConvertToFact
        '
        Me.mnuConvertToFact.Name = "mnuConvertToFact"
        Me.mnuConvertToFact.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToFact.Text = "Convert to Factor"
        '
        'mnuConvertToOrderedFactor
        '
        Me.mnuConvertToOrderedFactor.Name = "mnuConvertToOrderedFactor"
        Me.mnuConvertToOrderedFactor.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToOrderedFactor.Text = "Convert to Ordered Factor"
        '
        'mnuConvertToCharacter
        '
        Me.mnuConvertToCharacter.Name = "mnuConvertToCharacter"
        Me.mnuConvertToCharacter.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToCharacter.Text = "Convert to Character"
        '
        'mnuConvertToLogic
        '
        Me.mnuConvertToLogic.Name = "mnuConvertToLogic"
        Me.mnuConvertToLogic.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToLogic.Text = "Convert to Logical"
        '
        'mnuConvertToNumeric
        '
        Me.mnuConvertToNumeric.Name = "mnuConvertToNumeric"
        Me.mnuConvertToNumeric.Size = New System.Drawing.Size(292, 32)
        Me.mnuConvertToNumeric.Text = "Convert to Numeric"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(289, 6)
        '
        'mnuLebelsLevel
        '
        Me.mnuLebelsLevel.Name = "mnuLebelsLevel"
        Me.mnuLebelsLevel.Size = New System.Drawing.Size(292, 32)
        Me.mnuLebelsLevel.Text = "Levels/Labels..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(289, 6)
        '
        'mnuSorts
        '
        Me.mnuSorts.Name = "mnuSorts"
        Me.mnuSorts.Size = New System.Drawing.Size(292, 32)
        Me.mnuSorts.Text = "Sort..."
        '
        'mnuComment
        '
        Me.mnuComment.Name = "mnuComment"
        Me.mnuComment.Size = New System.Drawing.Size(292, 32)
        Me.mnuComment.Text = "Add Comment..."
        '
        'mnuFilters
        '
        Me.mnuFilters.Name = "mnuFilters"
        Me.mnuFilters.Size = New System.Drawing.Size(292, 32)
        Me.mnuFilters.Text = "Filter..."
        '
        'mnuRemoveCurrentFilters
        '
        Me.mnuRemoveCurrentFilters.Name = "mnuRemoveCurrentFilters"
        Me.mnuRemoveCurrentFilters.Size = New System.Drawing.Size(292, 32)
        Me.mnuRemoveCurrentFilters.Text = "Remove Current Filter"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRowsBefore, Me.mnuInsertRowsAfter, Me.mnuDeleteRows, Me.ToolStripSeparator2, Me.mnuAddComment, Me.ToolStripSeparator4, Me.mnuFilter, Me.mnuRemoveCurrentFilter})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(255, 208)
        '
        'mnuInsertRowsBefore
        '
        Me.mnuInsertRowsBefore.Name = "mnuInsertRowsBefore"
        Me.mnuInsertRowsBefore.Size = New System.Drawing.Size(254, 32)
        Me.mnuInsertRowsBefore.Text = "Insert Row(s) Before"
        '
        'mnuInsertRowsAfter
        '
        Me.mnuInsertRowsAfter.Name = "mnuInsertRowsAfter"
        Me.mnuInsertRowsAfter.Size = New System.Drawing.Size(254, 32)
        Me.mnuInsertRowsAfter.Text = "Insert Row(s) After"
        '
        'mnuDeleteRows
        '
        Me.mnuDeleteRows.Name = "mnuDeleteRows"
        Me.mnuDeleteRows.Size = New System.Drawing.Size(254, 32)
        Me.mnuDeleteRows.Text = "Delete Row(s)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(251, 6)
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        Me.mnuAddComment.Size = New System.Drawing.Size(254, 32)
        Me.mnuAddComment.Text = "Add Comment..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(251, 6)
        '
        'mnuFilter
        '
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(254, 32)
        Me.mnuFilter.Tag = "Filter..."
        Me.mnuFilter.Text = "Filter..."
        '
        'mnuRemoveCurrentFilter
        '
        Me.mnuRemoveCurrentFilter.Name = "mnuRemoveCurrentFilter"
        Me.mnuRemoveCurrentFilter.Size = New System.Drawing.Size(254, 32)
        Me.mnuRemoveCurrentFilter.Tag = "Remove_Current_Filter"
        Me.mnuRemoveCurrentFilter.Text = "Remove Current Filter"
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteDataFrame, Me.renameSheet, Me.mnuBottomAddComment, Me.HideSheet, Me.unhideSheet, Me.CopySheet, Me.reorderSheet, Me.ViewSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(218, 260)
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        Me.deleteDataFrame.Size = New System.Drawing.Size(217, 32)
        Me.deleteDataFrame.Text = "Delete..."
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(217, 32)
        Me.renameSheet.Text = "Rename..."
        '
        'mnuBottomAddComment
        '
        Me.mnuBottomAddComment.Name = "mnuBottomAddComment"
        Me.mnuBottomAddComment.Size = New System.Drawing.Size(217, 32)
        Me.mnuBottomAddComment.Text = "Add Comment..."
        '
        'HideSheet
        '
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(217, 32)
        Me.HideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(217, 32)
        Me.unhideSheet.Text = "Unhide..."
        '
        'CopySheet
        '
        Me.CopySheet.Name = "CopySheet"
        Me.CopySheet.Size = New System.Drawing.Size(217, 32)
        Me.CopySheet.Text = "Copy..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(217, 32)
        Me.reorderSheet.Text = "Reorder..."
        '
        'ViewSheet
        '
        Me.ViewSheet.Name = "ViewSheet"
        Me.ViewSheet.Size = New System.Drawing.Size(217, 32)
        Me.ViewSheet.Text = "View Data Frame"
        '
        'lblHeaderDataView
        '
        Me.lblHeaderDataView.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderDataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderDataView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderDataView.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderDataView.Location = New System.Drawing.Point(4, 0)
        Me.lblHeaderDataView.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderDataView.Name = "lblHeaderDataView"
        Me.lblHeaderDataView.Size = New System.Drawing.Size(658, 31)
        Me.lblHeaderDataView.TabIndex = 5
        Me.lblHeaderDataView.Text = "Data View"
        Me.lblHeaderDataView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 1
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderDataView, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.pnlDataContainer, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.TblPanPageDisplay, 0, 2)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(666, 769)
        Me.tlpTableContainer.TabIndex = 6
        '
        'pnlDataContainer
        '
        Me.pnlDataContainer.Controls.Add(Me.panelSectionsAll)
        Me.pnlDataContainer.Controls.Add(Me.grdData)
        Me.pnlDataContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataContainer.Location = New System.Drawing.Point(4, 36)
        Me.pnlDataContainer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlDataContainer.Name = "pnlDataContainer"
        Me.pnlDataContainer.Size = New System.Drawing.Size(658, 697)
        Me.pnlDataContainer.TabIndex = 7
        '
        'panelSectionsAll
        '
        Me.panelSectionsAll.Controls.Add(Me.panelSectionRecent)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionHelp)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionStart)
        Me.panelSectionsAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSectionsAll.Location = New System.Drawing.Point(0, 0)
        Me.panelSectionsAll.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSectionsAll.Name = "panelSectionsAll"
        Me.panelSectionsAll.Size = New System.Drawing.Size(658, 697)
        Me.panelSectionsAll.TabIndex = 7
        '
        'panelSectionRecent
        '
        Me.panelSectionRecent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSectionRecent.Controls.Add(Me.lblRecent)
        Me.panelSectionRecent.Controls.Add(Me.panelRecentMenuItems)
        Me.panelSectionRecent.Location = New System.Drawing.Point(42, 200)
        Me.panelSectionRecent.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSectionRecent.Name = "panelSectionRecent"
        Me.panelSectionRecent.Size = New System.Drawing.Size(562, 286)
        Me.panelSectionRecent.TabIndex = 13
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecent.Location = New System.Drawing.Point(6, 12)
        Me.lblRecent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(116, 37)
        Me.lblRecent.TabIndex = 1
        Me.lblRecent.Text = "Recent"
        '
        'panelRecentMenuItems
        '
        Me.panelRecentMenuItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRecentMenuItems.AutoScroll = True
        Me.panelRecentMenuItems.Location = New System.Drawing.Point(14, 57)
        Me.panelRecentMenuItems.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelRecentMenuItems.Name = "panelRecentMenuItems"
        Me.panelRecentMenuItems.Size = New System.Drawing.Size(532, 212)
        Me.panelRecentMenuItems.TabIndex = 6
        '
        'panelSectionHelp
        '
        Me.panelSectionHelp.Controls.Add(Me.lblHelp)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpIntroduction)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpInstructionVideos)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpRpackages)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpRInstatWebsite)
        Me.panelSectionHelp.Location = New System.Drawing.Point(42, 508)
        Me.panelSectionHelp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSectionHelp.Name = "panelSectionHelp"
        Me.panelSectionHelp.Size = New System.Drawing.Size(561, 182)
        Me.panelSectionHelp.TabIndex = 12
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHelp.Location = New System.Drawing.Point(9, 12)
        Me.lblHelp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(82, 37)
        Me.lblHelp.TabIndex = 2
        Me.lblHelp.Text = "Help"
        '
        'linkHelpIntroduction
        '
        Me.linkHelpIntroduction.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpIntroduction.AutoSize = True
        Me.linkHelpIntroduction.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpIntroduction.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpIntroduction.Location = New System.Drawing.Point(12, 57)
        Me.linkHelpIntroduction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpIntroduction.Name = "linkHelpIntroduction"
        Me.linkHelpIntroduction.Size = New System.Drawing.Size(94, 20)
        Me.linkHelpIntroduction.TabIndex = 7
        Me.linkHelpIntroduction.TabStop = True
        Me.linkHelpIntroduction.Text = "Introduction"
        '
        'linkHelpInstructionVideos
        '
        Me.linkHelpInstructionVideos.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpInstructionVideos.AutoSize = True
        Me.linkHelpInstructionVideos.Enabled = False
        Me.linkHelpInstructionVideos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpInstructionVideos.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpInstructionVideos.Location = New System.Drawing.Point(12, 145)
        Me.linkHelpInstructionVideos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpInstructionVideos.Name = "linkHelpInstructionVideos"
        Me.linkHelpInstructionVideos.Size = New System.Drawing.Size(145, 20)
        Me.linkHelpInstructionVideos.TabIndex = 10
        Me.linkHelpInstructionVideos.TabStop = True
        Me.linkHelpInstructionVideos.Text = "Instructional videos"
        Me.linkHelpInstructionVideos.Visible = False
        '
        'linkHelpRpackages
        '
        Me.linkHelpRpackages.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpRpackages.AutoSize = True
        Me.linkHelpRpackages.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpRpackages.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpRpackages.Location = New System.Drawing.Point(12, 86)
        Me.linkHelpRpackages.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpRpackages.Name = "linkHelpRpackages"
        Me.linkHelpRpackages.Size = New System.Drawing.Size(172, 20)
        Me.linkHelpRpackages.TabIndex = 8
        Me.linkHelpRpackages.TabStop = True
        Me.linkHelpRpackages.Text = "R packages in R-Instat"
        '
        'linkHelpRInstatWebsite
        '
        Me.linkHelpRInstatWebsite.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkHelpRInstatWebsite.AutoSize = True
        Me.linkHelpRInstatWebsite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpRInstatWebsite.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpRInstatWebsite.Location = New System.Drawing.Point(12, 115)
        Me.linkHelpRInstatWebsite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpRInstatWebsite.Name = "linkHelpRInstatWebsite"
        Me.linkHelpRInstatWebsite.Size = New System.Drawing.Size(125, 20)
        Me.linkHelpRInstatWebsite.TabIndex = 9
        Me.linkHelpRInstatWebsite.TabStop = True
        Me.linkHelpRInstatWebsite.Text = "R-Instat website"
        '
        'panelSectionStart
        '
        Me.panelSectionStart.Controls.Add(Me.lblStart)
        Me.panelSectionStart.Controls.Add(Me.linkStartNewDataFrame)
        Me.panelSectionStart.Controls.Add(Me.linkStartOpenFile)
        Me.panelSectionStart.Controls.Add(Me.linkStartOpenLibrary)
        Me.panelSectionStart.Location = New System.Drawing.Point(42, 31)
        Me.panelSectionStart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelSectionStart.Name = "panelSectionStart"
        Me.panelSectionStart.Size = New System.Drawing.Size(561, 148)
        Me.panelSectionStart.TabIndex = 11
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStart.Location = New System.Drawing.Point(8, 9)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(85, 37)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Start"
        '
        'linkStartNewDataFrame
        '
        Me.linkStartNewDataFrame.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkStartNewDataFrame.AutoSize = True
        Me.linkStartNewDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartNewDataFrame.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartNewDataFrame.Location = New System.Drawing.Point(10, 57)
        Me.linkStartNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartNewDataFrame.Name = "linkStartNewDataFrame"
        Me.linkStartNewDataFrame.Size = New System.Drawing.Size(141, 20)
        Me.linkStartNewDataFrame.TabIndex = 3
        Me.linkStartNewDataFrame.TabStop = True
        Me.linkStartNewDataFrame.Text = "New Data Frame..."
        '
        'linkStartOpenFile
        '
        Me.linkStartOpenFile.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkStartOpenFile.AutoSize = True
        Me.linkStartOpenFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartOpenFile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartOpenFile.Location = New System.Drawing.Point(10, 86)
        Me.linkStartOpenFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartOpenFile.Name = "linkStartOpenFile"
        Me.linkStartOpenFile.Size = New System.Drawing.Size(120, 20)
        Me.linkStartOpenFile.TabIndex = 4
        Me.linkStartOpenFile.TabStop = True
        Me.linkStartOpenFile.Text = "Open from file..."
        '
        'linkStartOpenLibrary
        '
        Me.linkStartOpenLibrary.ActiveLinkColor = System.Drawing.Color.Blue
        Me.linkStartOpenLibrary.AutoSize = True
        Me.linkStartOpenLibrary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartOpenLibrary.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartOpenLibrary.Location = New System.Drawing.Point(10, 115)
        Me.linkStartOpenLibrary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartOpenLibrary.Name = "linkStartOpenLibrary"
        Me.linkStartOpenLibrary.Size = New System.Drawing.Size(141, 20)
        Me.linkStartOpenLibrary.TabIndex = 5
        Me.linkStartOpenLibrary.TabStop = True
        Me.linkStartOpenLibrary.Text = "Open from library..."
        '
        'TblPanPageDisplay
        '
        Me.TblPanPageDisplay.AutoSize = True
        Me.TblPanPageDisplay.ColumnCount = 12
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPanPageDisplay.Controls.Add(Me.lblColFirst, 7, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblColDisplay, 6, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblColNext, 9, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblColBack, 8, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblRowLast, 5, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblRowFirst, 2, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblRowDisplay, 1, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblRowNext, 4, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblColLast, 10, 0)
        Me.TblPanPageDisplay.Controls.Add(Me.lblRowBack, 3, 0)
        Me.TblPanPageDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblPanPageDisplay.Location = New System.Drawing.Point(0, 738)
        Me.TblPanPageDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.TblPanPageDisplay.Name = "TblPanPageDisplay"
        Me.TblPanPageDisplay.RowCount = 1
        Me.TblPanPageDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblPanPageDisplay.Size = New System.Drawing.Size(666, 31)
        Me.TblPanPageDisplay.TabIndex = 8
        '
        'lblColFirst
        '
        Me.lblColFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblColFirst.Location = New System.Drawing.Point(431, 0)
        Me.lblColFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColFirst.Name = "lblColFirst"
        Me.lblColFirst.Size = New System.Drawing.Size(16, 31)
        Me.lblColFirst.TabIndex = 15
        Me.lblColFirst.Text = "«"
        Me.lblColFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColDisplay
        '
        Me.lblColDisplay.AutoSize = True
        Me.lblColDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblColDisplay.Location = New System.Drawing.Point(337, 0)
        Me.lblColDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColDisplay.Name = "lblColDisplay"
        Me.lblColDisplay.Size = New System.Drawing.Size(86, 31)
        Me.lblColDisplay.TabIndex = 14
        Me.lblColDisplay.Text = "Label1"
        Me.lblColDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColNext
        '
        Me.lblColNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblColNext.Location = New System.Drawing.Point(479, 0)
        Me.lblColNext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColNext.Name = "lblColNext"
        Me.lblColNext.Size = New System.Drawing.Size(16, 31)
        Me.lblColNext.TabIndex = 13
        Me.lblColNext.Text = ">"
        Me.lblColNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColBack
        '
        Me.lblColBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblColBack.Location = New System.Drawing.Point(455, 0)
        Me.lblColBack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColBack.Name = "lblColBack"
        Me.lblColBack.Size = New System.Drawing.Size(16, 31)
        Me.lblColBack.TabIndex = 12
        Me.lblColBack.Text = "<"
        Me.lblColBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowLast
        '
        Me.lblRowLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowLast.Location = New System.Drawing.Point(313, 0)
        Me.lblRowLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowLast.Name = "lblRowLast"
        Me.lblRowLast.Size = New System.Drawing.Size(16, 31)
        Me.lblRowLast.TabIndex = 11
        Me.lblRowLast.Text = "»"
        Me.lblRowLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowFirst
        '
        Me.lblRowFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowFirst.Location = New System.Drawing.Point(241, 0)
        Me.lblRowFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowFirst.Name = "lblRowFirst"
        Me.lblRowFirst.Size = New System.Drawing.Size(16, 31)
        Me.lblRowFirst.TabIndex = 10
        Me.lblRowFirst.Text = "«"
        Me.lblRowFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowDisplay
        '
        Me.lblRowDisplay.AutoSize = True
        Me.lblRowDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowDisplay.Location = New System.Drawing.Point(147, 0)
        Me.lblRowDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowDisplay.Name = "lblRowDisplay"
        Me.lblRowDisplay.Size = New System.Drawing.Size(86, 31)
        Me.lblRowDisplay.TabIndex = 9
        Me.lblRowDisplay.Text = "Label1"
        Me.lblRowDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRowNext
        '
        Me.lblRowNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowNext.Location = New System.Drawing.Point(289, 0)
        Me.lblRowNext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowNext.Name = "lblRowNext"
        Me.lblRowNext.Size = New System.Drawing.Size(16, 31)
        Me.lblRowNext.TabIndex = 8
        Me.lblRowNext.Text = ">"
        Me.lblRowNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColLast
        '
        Me.lblColLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblColLast.Location = New System.Drawing.Point(503, 0)
        Me.lblColLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColLast.Name = "lblColLast"
        Me.lblColLast.Size = New System.Drawing.Size(16, 31)
        Me.lblColLast.TabIndex = 7
        Me.lblColLast.Text = "»"
        Me.lblColLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowBack
        '
        Me.lblRowBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblRowBack.Location = New System.Drawing.Point(265, 0)
        Me.lblRowBack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowBack.Name = "lblRowBack"
        Me.lblRowBack.Size = New System.Drawing.Size(16, 31)
        Me.lblRowBack.TabIndex = 5
        Me.lblRowBack.Text = "<"
        Me.lblRowBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrDataView"
        Me.Size = New System.Drawing.Size(666, 769)
        Me.Tag = "Data_View"
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.tlpTableContainer.PerformLayout()
        Me.pnlDataContainer.ResumeLayout(False)
        Me.panelSectionsAll.ResumeLayout(False)
        Me.panelSectionRecent.ResumeLayout(False)
        Me.panelSectionRecent.PerformLayout()
        Me.panelSectionHelp.ResumeLayout(False)
        Me.panelSectionHelp.PerformLayout()
        Me.panelSectionStart.ResumeLayout(False)
        Me.panelSectionStart.PerformLayout()
        Me.TblPanPageDisplay.ResumeLayout(False)
        Me.TblPanPageDisplay.PerformLayout()
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
    Friend WithEvents mnuAddComment As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lblHeaderDataView As Label
    Friend WithEvents mnuConvertToLogical As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents pnlDataContainer As Panel
    Friend WithEvents mnuLevelsLabels As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuReorderColumns As ToolStripMenuItem
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
    Friend WithEvents mnuComment As ToolStripMenuItem
    Friend WithEvents mnuColumnAddComment As ToolStripMenuItem
    Friend WithEvents mnuBottomAddComment As ToolStripMenuItem
    Private WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuCellPasteRange As ToolStripMenuItem
    Friend WithEvents TblPanPageDisplay As TableLayoutPanel
    Friend WithEvents lblColLast As Label
    Friend WithEvents lblRowBack As Label
    Friend WithEvents lblColFirst As Label
    Friend WithEvents lblColDisplay As Label
    Friend WithEvents lblColNext As Label
    Friend WithEvents lblColBack As Label
    Friend WithEvents lblRowLast As Label
    Friend WithEvents lblRowFirst As Label
    Friend WithEvents lblRowDisplay As Label
    Friend WithEvents lblRowNext As Label
End Class
