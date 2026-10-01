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
        Me.columnContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColumnRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplicateColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReorderColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditCell2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCells2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCovertToOrderedFactors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLevelsLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnFilterRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnContextColumnSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnContextRemoveCurrentColumnSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRenameColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDuplColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReorderColumn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditCell = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCells = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToNumeric = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToOrderedFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToCharacter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToColumnDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLabelsLevel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSorts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFilterRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellContextColumnSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCellContextRemoveCurrentColumnSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveCurrentFilters = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuInsertRowsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertRowsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRowContextColumnSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRowContextRemoveCurrentColumnSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveCurrentFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusColumnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBottomAddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHelp3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblHeaderDataView = New System.Windows.Forms.Label()
        Me.tlpTableContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.panelSectionsAll = New System.Windows.Forms.Panel()
        Me.panelSectionAdvanced = New System.Windows.Forms.Panel()
        Me.linkStartAddRPackage = New System.Windows.Forms.LinkLabel()
        Me.lblAdvanced = New System.Windows.Forms.Label()
        Me.linkStartRestoreBackup = New System.Windows.Forms.LinkLabel()
        Me.linkStartPasteScriptfromClipboard = New System.Windows.Forms.LinkLabel()
        Me.panelSectionHelp = New System.Windows.Forms.Panel()
        Me.linkHelpData = New System.Windows.Forms.LinkLabel()
        Me.linkHelpGettingStarted = New System.Windows.Forms.LinkLabel()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.linkHelpRInstatResourcesSite = New System.Windows.Forms.LinkLabel()
        Me.panelSectionStart = New System.Windows.Forms.Panel()
        Me.linkStartPasteData = New System.Windows.Forms.LinkLabel()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.linkStartNewDataFrame = New System.Windows.Forms.LinkLabel()
        Me.linkStartOpenFile = New System.Windows.Forms.LinkLabel()
        Me.linkStartOpenLibrary = New System.Windows.Forms.LinkLabel()
        Me.panelSectionRecent = New System.Windows.Forms.Panel()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.panelRecentMenuItems = New System.Windows.Forms.Panel()
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
        Me.ucrReoGrid = New instat.ucrDataViewReoGrid()
        Me.ucrLinuxGrid = New instat.ucrDataViewLinuxGrid()
        Me.ttGoToRowOrColPage = New System.Windows.Forms.ToolTip(Me.components)
        Me.columnContextMenuStrip.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.rowContextMenuStrip.SuspendLayout()
        Me.statusColumnMenu.SuspendLayout()
        Me.tlpTableContainer.SuspendLayout()
        Me.panelSectionsAll.SuspendLayout()
        Me.panelSectionAdvanced.SuspendLayout()
        Me.panelSectionHelp.SuspendLayout()
        Me.panelSectionStart.SuspendLayout()
        Me.panelSectionRecent.SuspendLayout()
        Me.TblPanPageDisplay.SuspendLayout()
        Me.SuspendLayout()
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuReorderColumns, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.ToolStripSeparator13, Me.mnuEditCell2, Me.mnuDeleteCells2, Me.toolStripMenuItem2, Me.mnuConvertVariate, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToDate, Me.ToolStripSeparator1, Me.mnuLevelsLabels, Me.toolStripMenuItem21, Me.mnuSort, Me.mnuColumnAddComment, Me.mnuColumnFilterRows, Me.mnuColumnContextColumnSelection, Me.mnuColumnContextRemoveCurrentColumnSelection, Me.mnuClearColumnFilter, Me.ToolStripSeparator8, Me.mnuHelp})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(253, 538)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(252, 24)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuDuplicateColumn
        '
        Me.mnuDuplicateColumn.Name = "mnuDuplicateColumn"
        Me.mnuDuplicateColumn.Size = New System.Drawing.Size(252, 24)
        Me.mnuDuplicateColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumns
        '
        Me.mnuReorderColumns.Name = "mnuReorderColumns"
        Me.mnuReorderColumns.Size = New System.Drawing.Size(252, 24)
        Me.mnuReorderColumns.Text = "Reorder Column(s)..."
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        Me.mnuInsertColsBefore.Size = New System.Drawing.Size(252, 24)
        Me.mnuInsertColsBefore.Text = "Insert Column(s) Before"
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        Me.mnuInsertColsAfter.Size = New System.Drawing.Size(252, 24)
        Me.mnuInsertColsAfter.Text = "Insert Column(s) After"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(252, 24)
        Me.mnuDeleteCol.Text = "Delete Column(s)"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(249, 6)
        '
        'mnuEditCell2
        '
        Me.mnuEditCell2.Enabled = False
        Me.mnuEditCell2.Name = "mnuEditCell2"
        Me.mnuEditCell2.Size = New System.Drawing.Size(252, 24)
        Me.mnuEditCell2.Text = "Edit Cell..."
        '
        'mnuDeleteCells2
        '
        Me.mnuDeleteCells2.Enabled = False
        Me.mnuDeleteCells2.Name = "mnuDeleteCells2"
        Me.mnuDeleteCells2.Size = New System.Drawing.Size(252, 24)
        Me.mnuDeleteCells2.Text = "Delete Cell(s)"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(249, 6)
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuCovertToOrderedFactors
        '
        Me.mnuCovertToOrderedFactors.Name = "mnuCovertToOrderedFactors"
        Me.mnuCovertToOrderedFactors.Size = New System.Drawing.Size(252, 24)
        Me.mnuCovertToOrderedFactors.Text = "Convert to Ordered Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertToDate
        '
        Me.mnuConvertToDate.Name = "mnuConvertToDate"
        Me.mnuConvertToDate.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToDate.Text = "Convert to Date"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(249, 6)
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        Me.mnuLevelsLabels.Size = New System.Drawing.Size(252, 24)
        Me.mnuLevelsLabels.Text = "Levels/Labels..."
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(249, 6)
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(252, 24)
        Me.mnuSort.Text = "Sort..."
        '
        'mnuColumnAddComment
        '
        Me.mnuColumnAddComment.Name = "mnuColumnAddComment"
        Me.mnuColumnAddComment.Size = New System.Drawing.Size(252, 24)
        Me.mnuColumnAddComment.Text = "Add Comment..."
        '
        'mnuColumnFilterRows
        '
        Me.mnuColumnFilterRows.Name = "mnuColumnFilterRows"
        Me.mnuColumnFilterRows.Size = New System.Drawing.Size(252, 24)
        Me.mnuColumnFilterRows.Text = "Filter Rows..."
        '
        'mnuColumnContextColumnSelection
        '
        Me.mnuColumnContextColumnSelection.Name = "mnuColumnContextColumnSelection"
        Me.mnuColumnContextColumnSelection.Size = New System.Drawing.Size(252, 24)
        Me.mnuColumnContextColumnSelection.Text = "Select Columns..."
        '
        'mnuColumnContextRemoveCurrentColumnSelection
        '
        Me.mnuColumnContextRemoveCurrentColumnSelection.Name = "mnuColumnContextRemoveCurrentColumnSelection"
        Me.mnuColumnContextRemoveCurrentColumnSelection.Size = New System.Drawing.Size(252, 24)
        Me.mnuColumnContextRemoveCurrentColumnSelection.Text = "Remove Column Selection"
        '
        'mnuClearColumnFilter
        '
        Me.mnuClearColumnFilter.Name = "mnuClearColumnFilter"
        Me.mnuClearColumnFilter.Size = New System.Drawing.Size(252, 24)
        Me.mnuClearColumnFilter.Text = "Remove Current Filter"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(249, 6)
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(252, 24)
        Me.mnuHelp.Text = "Help"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRenameColumn, Me.mnuDuplColumn, Me.mnuReorderColumn, Me.mnuDeleteCol2, Me.ToolStripSeparator14, Me.mnuEditCell, Me.mnuDeleteCells, Me.ToolStripSeparator5, Me.mnuConvertToNumeric, Me.mnuConvertToFact, Me.mnuConvertToOrderedFactor, Me.mnuConvertToCharacter, Me.mnuConvertToColumnDate, Me.ToolStripSeparator6, Me.mnuLabelsLevel, Me.ToolStripSeparator7, Me.mnuSorts, Me.mnuComment, Me.mnuFilterRows, Me.mnuCellContextColumnSelection, Me.mnuCellContextRemoveCurrentColumnSelection, Me.mnuRemoveCurrentFilters, Me.ToolStripSeparator9, Me.mnuHelp1})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(253, 490)
        '
        'mnuRenameColumn
        '
        Me.mnuRenameColumn.Name = "mnuRenameColumn"
        Me.mnuRenameColumn.Size = New System.Drawing.Size(252, 24)
        Me.mnuRenameColumn.Text = "Rename Column..."
        '
        'mnuDuplColumn
        '
        Me.mnuDuplColumn.Name = "mnuDuplColumn"
        Me.mnuDuplColumn.Size = New System.Drawing.Size(252, 24)
        Me.mnuDuplColumn.Text = "Duplicate Column..."
        '
        'mnuReorderColumn
        '
        Me.mnuReorderColumn.Name = "mnuReorderColumn"
        Me.mnuReorderColumn.Size = New System.Drawing.Size(252, 24)
        Me.mnuReorderColumn.Text = "Reorder Column(s)..."
        '
        'mnuDeleteCol2
        '
        Me.mnuDeleteCol2.Enabled = False
        Me.mnuDeleteCol2.Name = "mnuDeleteCol2"
        Me.mnuDeleteCol2.Size = New System.Drawing.Size(252, 24)
        Me.mnuDeleteCol2.Text = "Delete Column(s)"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(249, 6)
        '
        'mnuEditCell
        '
        Me.mnuEditCell.Name = "mnuEditCell"
        Me.mnuEditCell.Size = New System.Drawing.Size(252, 24)
        Me.mnuEditCell.Text = "Edit Cell..."
        '
        'mnuDeleteCells
        '
        Me.mnuDeleteCells.Name = "mnuDeleteCells"
        Me.mnuDeleteCells.Size = New System.Drawing.Size(252, 24)
        Me.mnuDeleteCells.Text = "Delete Cell(s)"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(249, 6)
        '
        'mnuConvertToNumeric
        '
        Me.mnuConvertToNumeric.Name = "mnuConvertToNumeric"
        Me.mnuConvertToNumeric.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToNumeric.Text = "Convert to Numeric"
        '
        'mnuConvertToFact
        '
        Me.mnuConvertToFact.Name = "mnuConvertToFact"
        Me.mnuConvertToFact.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToFact.Text = "Convert to Factor"
        '
        'mnuConvertToOrderedFactor
        '
        Me.mnuConvertToOrderedFactor.Name = "mnuConvertToOrderedFactor"
        Me.mnuConvertToOrderedFactor.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToOrderedFactor.Text = "Convert to Ordered Factor"
        '
        'mnuConvertToCharacter
        '
        Me.mnuConvertToCharacter.Name = "mnuConvertToCharacter"
        Me.mnuConvertToCharacter.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToCharacter.Text = "Convert to Character"
        '
        'mnuConvertToColumnDate
        '
        Me.mnuConvertToColumnDate.Name = "mnuConvertToColumnDate"
        Me.mnuConvertToColumnDate.Size = New System.Drawing.Size(252, 24)
        Me.mnuConvertToColumnDate.Text = "Convert to Date"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(249, 6)
        '
        'mnuLabelsLevel
        '
        Me.mnuLabelsLevel.Name = "mnuLabelsLevel"
        Me.mnuLabelsLevel.Size = New System.Drawing.Size(252, 24)
        Me.mnuLabelsLevel.Text = "Levels/Labels..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(249, 6)
        '
        'mnuSorts
        '
        Me.mnuSorts.Name = "mnuSorts"
        Me.mnuSorts.Size = New System.Drawing.Size(252, 24)
        Me.mnuSorts.Text = "Sort..."
        '
        'mnuComment
        '
        Me.mnuComment.Name = "mnuComment"
        Me.mnuComment.Size = New System.Drawing.Size(252, 24)
        Me.mnuComment.Text = "Add Comment..."
        '
        'mnuFilterRows
        '
        Me.mnuFilterRows.Name = "mnuFilterRows"
        Me.mnuFilterRows.Size = New System.Drawing.Size(252, 24)
        Me.mnuFilterRows.Text = "Filter Rows..."
        '
        'mnuCellContextColumnSelection
        '
        Me.mnuCellContextColumnSelection.Name = "mnuCellContextColumnSelection"
        Me.mnuCellContextColumnSelection.Size = New System.Drawing.Size(252, 24)
        Me.mnuCellContextColumnSelection.Text = "Select Columns..."
        '
        'mnuCellContextRemoveCurrentColumnSelection
        '
        Me.mnuCellContextRemoveCurrentColumnSelection.Name = "mnuCellContextRemoveCurrentColumnSelection"
        Me.mnuCellContextRemoveCurrentColumnSelection.Size = New System.Drawing.Size(252, 24)
        Me.mnuCellContextRemoveCurrentColumnSelection.Text = "Remove Column Selection"
        '
        'mnuRemoveCurrentFilters
        '
        Me.mnuRemoveCurrentFilters.Name = "mnuRemoveCurrentFilters"
        Me.mnuRemoveCurrentFilters.Size = New System.Drawing.Size(252, 24)
        Me.mnuRemoveCurrentFilters.Text = "Remove Current Filter"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(249, 6)
        '
        'mnuHelp1
        '
        Me.mnuHelp1.Name = "mnuHelp1"
        Me.mnuHelp1.Size = New System.Drawing.Size(252, 24)
        Me.mnuHelp1.Text = "Help"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRowsBefore, Me.mnuInsertRowsAfter, Me.mnuDeleteRows, Me.ToolStripSeparator2, Me.mnuAddComment, Me.ToolStripSeparator4, Me.mnuFilter, Me.mnuRowContextColumnSelection, Me.mnuRowContextRemoveCurrentColumnSelection, Me.mnuRemoveCurrentFilter, Me.ToolStripSeparator10, Me.mnuHelp2})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(253, 238)
        '
        'mnuInsertRowsBefore
        '
        Me.mnuInsertRowsBefore.Name = "mnuInsertRowsBefore"
        Me.mnuInsertRowsBefore.Size = New System.Drawing.Size(252, 24)
        Me.mnuInsertRowsBefore.Text = "Insert Row(s) Before"
        '
        'mnuInsertRowsAfter
        '
        Me.mnuInsertRowsAfter.Name = "mnuInsertRowsAfter"
        Me.mnuInsertRowsAfter.Size = New System.Drawing.Size(252, 24)
        Me.mnuInsertRowsAfter.Text = "Insert Row(s) After"
        '
        'mnuDeleteRows
        '
        Me.mnuDeleteRows.Name = "mnuDeleteRows"
        Me.mnuDeleteRows.Size = New System.Drawing.Size(252, 24)
        Me.mnuDeleteRows.Text = "Delete Row(s)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(249, 6)
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        Me.mnuAddComment.Size = New System.Drawing.Size(252, 24)
        Me.mnuAddComment.Text = "Add Comment..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(249, 6)
        '
        'mnuFilter
        '
        Me.mnuFilter.Name = "mnuFilter"
        Me.mnuFilter.Size = New System.Drawing.Size(252, 24)
        Me.mnuFilter.Tag = "Filter..."
        Me.mnuFilter.Text = "Filter Rows..."
        '
        'mnuRowContextColumnSelection
        '
        Me.mnuRowContextColumnSelection.Name = "mnuRowContextColumnSelection"
        Me.mnuRowContextColumnSelection.Size = New System.Drawing.Size(252, 24)
        Me.mnuRowContextColumnSelection.Text = "Select Columns..."
        '
        'mnuRowContextRemoveCurrentColumnSelection
        '
        Me.mnuRowContextRemoveCurrentColumnSelection.Name = "mnuRowContextRemoveCurrentColumnSelection"
        Me.mnuRowContextRemoveCurrentColumnSelection.Size = New System.Drawing.Size(252, 24)
        Me.mnuRowContextRemoveCurrentColumnSelection.Text = "Remove Column Selection"
        '
        'mnuRemoveCurrentFilter
        '
        Me.mnuRemoveCurrentFilter.Name = "mnuRemoveCurrentFilter"
        Me.mnuRemoveCurrentFilter.Size = New System.Drawing.Size(252, 24)
        Me.mnuRemoveCurrentFilter.Tag = "Remove_Current_Filter"
        Me.mnuRemoveCurrentFilter.Text = "Remove Current Filter"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(249, 6)
        '
        'mnuHelp2
        '
        Me.mnuHelp2.Name = "mnuHelp2"
        Me.mnuHelp2.Size = New System.Drawing.Size(252, 24)
        Me.mnuHelp2.Text = "Help"
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.renameSheet, Me.reorderSheet, Me.CopySheet, Me.deleteDataFrame, Me.HideSheet, Me.unhideSheet, Me.ToolStripSeparator12, Me.mnuBottomAddComment, Me.ToolStripSeparator11, Me.mnuHelp3})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(185, 208)
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(184, 24)
        Me.renameSheet.Text = "Rename..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(184, 24)
        Me.reorderSheet.Text = "Reorder..."
        '
        'CopySheet
        '
        Me.CopySheet.Name = "CopySheet"
        Me.CopySheet.Size = New System.Drawing.Size(184, 24)
        Me.CopySheet.Text = "Copy..."
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        Me.deleteDataFrame.Size = New System.Drawing.Size(184, 24)
        Me.deleteDataFrame.Text = "Delete..."
        '
        'HideSheet
        '
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(184, 24)
        Me.HideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(184, 24)
        Me.unhideSheet.Text = "Unhide..."
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(181, 6)
        '
        'mnuBottomAddComment
        '
        Me.mnuBottomAddComment.Name = "mnuBottomAddComment"
        Me.mnuBottomAddComment.Size = New System.Drawing.Size(184, 24)
        Me.mnuBottomAddComment.Text = "Add Comment..."
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(181, 6)
        '
        'mnuHelp3
        '
        Me.mnuHelp3.Name = "mnuHelp3"
        Me.mnuHelp3.Size = New System.Drawing.Size(184, 24)
        Me.mnuHelp3.Text = "Help"
        '
        'lblHeaderDataView
        '
        Me.lblHeaderDataView.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.tlpTableContainer.SetColumnSpan(Me.lblHeaderDataView, 3)
        Me.lblHeaderDataView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHeaderDataView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHeaderDataView.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHeaderDataView.Location = New System.Drawing.Point(4, 0)
        Me.lblHeaderDataView.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeaderDataView.Name = "lblHeaderDataView"
        Me.lblHeaderDataView.Size = New System.Drawing.Size(927, 25)
        Me.lblHeaderDataView.TabIndex = 5
        Me.lblHeaderDataView.Text = "Data View"
        Me.lblHeaderDataView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tlpTableContainer
        '
        Me.tlpTableContainer.ColumnCount = 3
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpTableContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.tlpTableContainer.Controls.Add(Me.panelSectionsAll, 0, 1)
        Me.tlpTableContainer.Controls.Add(Me.lblHeaderDataView, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.TblPanPageDisplay, 1, 2)
        Me.tlpTableContainer.Controls.Add(Me.ucrReoGrid, 2, 1)
        Me.tlpTableContainer.Controls.Add(Me.ucrLinuxGrid, 1, 1)
        Me.tlpTableContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpTableContainer.Location = New System.Drawing.Point(0, 0)
        Me.tlpTableContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        Me.tlpTableContainer.RowCount = 3
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpTableContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpTableContainer.Size = New System.Drawing.Size(935, 601)
        Me.tlpTableContainer.TabIndex = 6
        '
        'panelSectionsAll
        '
        Me.panelSectionsAll.Controls.Add(Me.panelSectionAdvanced)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionHelp)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionStart)
        Me.panelSectionsAll.Controls.Add(Me.panelSectionRecent)
        Me.panelSectionsAll.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSectionsAll.Location = New System.Drawing.Point(4, 29)
        Me.panelSectionsAll.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSectionsAll.Name = "panelSectionsAll"
        Me.tlpTableContainer.SetRowSpan(Me.panelSectionsAll, 2)
        Me.panelSectionsAll.Size = New System.Drawing.Size(303, 568)
        Me.panelSectionsAll.TabIndex = 9
        '
        'panelSectionAdvanced
        '
        Me.panelSectionAdvanced.Controls.Add(Me.linkStartAddRPackage)
        Me.panelSectionAdvanced.Controls.Add(Me.lblAdvanced)
        Me.panelSectionAdvanced.Controls.Add(Me.linkStartRestoreBackup)
        Me.panelSectionAdvanced.Controls.Add(Me.linkStartPasteScriptfromClipboard)
        Me.panelSectionAdvanced.Location = New System.Drawing.Point(34, 515)
        Me.panelSectionAdvanced.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSectionAdvanced.Name = "panelSectionAdvanced"
        Me.panelSectionAdvanced.Size = New System.Drawing.Size(468, 104)
        Me.panelSectionAdvanced.TabIndex = 12
        '
        'linkStartAddRPackage
        '
        Me.linkStartAddRPackage.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartAddRPackage.AutoSize = True
        Me.linkStartAddRPackage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartAddRPackage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartAddRPackage.Location = New System.Drawing.Point(6, 80)
        Me.linkStartAddRPackage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartAddRPackage.Name = "linkStartAddRPackage"
        Me.linkStartAddRPackage.Size = New System.Drawing.Size(229, 16)
        Me.linkStartAddRPackage.TabIndex = 6
        Me.linkStartAddRPackage.TabStop = True
        Me.linkStartAddRPackage.Text = "Add R Package To R-Instat... (Online)"
        '
        'lblAdvanced
        '
        Me.lblAdvanced.AutoSize = True
        Me.lblAdvanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdvanced.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAdvanced.Location = New System.Drawing.Point(4, 5)
        Me.lblAdvanced.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdvanced.Name = "lblAdvanced"
        Me.lblAdvanced.Size = New System.Drawing.Size(135, 31)
        Me.lblAdvanced.TabIndex = 0
        Me.lblAdvanced.Text = "Advanced"
        '
        'linkStartRestoreBackup
        '
        Me.linkStartRestoreBackup.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartRestoreBackup.AutoSize = True
        Me.linkStartRestoreBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartRestoreBackup.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartRestoreBackup.Location = New System.Drawing.Point(6, 59)
        Me.linkStartRestoreBackup.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartRestoreBackup.Name = "linkStartRestoreBackup"
        Me.linkStartRestoreBackup.Size = New System.Drawing.Size(179, 16)
        Me.linkStartRestoreBackup.TabIndex = 4
        Me.linkStartRestoreBackup.TabStop = True
        Me.linkStartRestoreBackup.Text = "Restore Data From Backup..."
        '
        'linkStartPasteScriptfromClipboard
        '
        Me.linkStartPasteScriptfromClipboard.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartPasteScriptfromClipboard.AutoSize = True
        Me.linkStartPasteScriptfromClipboard.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartPasteScriptfromClipboard.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartPasteScriptfromClipboard.Location = New System.Drawing.Point(6, 38)
        Me.linkStartPasteScriptfromClipboard.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartPasteScriptfromClipboard.Name = "linkStartPasteScriptfromClipboard"
        Me.linkStartPasteScriptfromClipboard.Size = New System.Drawing.Size(175, 16)
        Me.linkStartPasteScriptfromClipboard.TabIndex = 5
        Me.linkStartPasteScriptfromClipboard.TabStop = True
        Me.linkStartPasteScriptfromClipboard.Text = "Paste Script From Clipboard"
        '
        'panelSectionHelp
        '
        Me.panelSectionHelp.Controls.Add(Me.linkHelpData)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpGettingStarted)
        Me.panelSectionHelp.Controls.Add(Me.lblHelp)
        Me.panelSectionHelp.Controls.Add(Me.linkHelpRInstatResourcesSite)
        Me.panelSectionHelp.Location = New System.Drawing.Point(35, 396)
        Me.panelSectionHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSectionHelp.Name = "panelSectionHelp"
        Me.panelSectionHelp.Size = New System.Drawing.Size(468, 101)
        Me.panelSectionHelp.TabIndex = 12
        '
        'linkHelpData
        '
        Me.linkHelpData.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkHelpData.AutoSize = True
        Me.linkHelpData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpData.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpData.Location = New System.Drawing.Point(6, 59)
        Me.linkHelpData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpData.Name = "linkHelpData"
        Me.linkHelpData.Size = New System.Drawing.Size(45, 16)
        Me.linkHelpData.TabIndex = 12
        Me.linkHelpData.TabStop = True
        Me.linkHelpData.Text = "Data..."
        '
        'linkHelpGettingStarted
        '
        Me.linkHelpGettingStarted.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkHelpGettingStarted.AutoSize = True
        Me.linkHelpGettingStarted.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpGettingStarted.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpGettingStarted.Location = New System.Drawing.Point(6, 38)
        Me.linkHelpGettingStarted.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpGettingStarted.Name = "linkHelpGettingStarted"
        Me.linkHelpGettingStarted.Size = New System.Drawing.Size(104, 16)
        Me.linkHelpGettingStarted.TabIndex = 11
        Me.linkHelpGettingStarted.TabStop = True
        Me.linkHelpGettingStarted.Text = "Getting Started..."
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblHelp.Location = New System.Drawing.Point(4, 5)
        Me.lblHelp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(70, 31)
        Me.lblHelp.TabIndex = 2
        Me.lblHelp.Text = "Help"
        '
        'linkHelpRInstatResourcesSite
        '
        Me.linkHelpRInstatResourcesSite.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkHelpRInstatResourcesSite.AutoSize = True
        Me.linkHelpRInstatResourcesSite.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkHelpRInstatResourcesSite.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkHelpRInstatResourcesSite.Location = New System.Drawing.Point(6, 80)
        Me.linkHelpRInstatResourcesSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkHelpRInstatResourcesSite.Name = "linkHelpRInstatResourcesSite"
        Me.linkHelpRInstatResourcesSite.Size = New System.Drawing.Size(196, 16)
        Me.linkHelpRInstatResourcesSite.TabIndex = 9
        Me.linkHelpRInstatResourcesSite.TabStop = True
        Me.linkHelpRInstatResourcesSite.Text = "R-Instat Resources Site (Online)"
        '
        'panelSectionStart
        '
        Me.panelSectionStart.Controls.Add(Me.linkStartPasteData)
        Me.panelSectionStart.Controls.Add(Me.lblStart)
        Me.panelSectionStart.Controls.Add(Me.linkStartNewDataFrame)
        Me.panelSectionStart.Controls.Add(Me.linkStartOpenFile)
        Me.panelSectionStart.Controls.Add(Me.linkStartOpenLibrary)
        Me.panelSectionStart.Location = New System.Drawing.Point(35, 19)
        Me.panelSectionStart.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSectionStart.Name = "panelSectionStart"
        Me.panelSectionStart.Size = New System.Drawing.Size(468, 125)
        Me.panelSectionStart.TabIndex = 11
        '
        'linkStartPasteData
        '
        Me.linkStartPasteData.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartPasteData.AutoSize = True
        Me.linkStartPasteData.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartPasteData.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartPasteData.Location = New System.Drawing.Point(6, 101)
        Me.linkStartPasteData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartPasteData.Name = "linkStartPasteData"
        Me.linkStartPasteData.Size = New System.Drawing.Size(179, 16)
        Me.linkStartPasteData.TabIndex = 7
        Me.linkStartPasteData.TabStop = True
        Me.linkStartPasteData.Text = "Paste Data From Clipboard..."
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStart.Location = New System.Drawing.Point(4, 5)
        Me.lblStart.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(72, 31)
        Me.lblStart.TabIndex = 0
        Me.lblStart.Text = "Start"
        '
        'linkStartNewDataFrame
        '
        Me.linkStartNewDataFrame.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartNewDataFrame.AutoSize = True
        Me.linkStartNewDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartNewDataFrame.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartNewDataFrame.Location = New System.Drawing.Point(6, 38)
        Me.linkStartNewDataFrame.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartNewDataFrame.Name = "linkStartNewDataFrame"
        Me.linkStartNewDataFrame.Size = New System.Drawing.Size(117, 16)
        Me.linkStartNewDataFrame.TabIndex = 3
        Me.linkStartNewDataFrame.TabStop = True
        Me.linkStartNewDataFrame.Text = "New Data Frame..."
        '
        'linkStartOpenFile
        '
        Me.linkStartOpenFile.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartOpenFile.AutoSize = True
        Me.linkStartOpenFile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartOpenFile.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartOpenFile.Location = New System.Drawing.Point(6, 59)
        Me.linkStartOpenFile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartOpenFile.Name = "linkStartOpenFile"
        Me.linkStartOpenFile.Size = New System.Drawing.Size(112, 16)
        Me.linkStartOpenFile.TabIndex = 4
        Me.linkStartOpenFile.TabStop = True
        Me.linkStartOpenFile.Text = "Import From File..."
        '
        'linkStartOpenLibrary
        '
        Me.linkStartOpenLibrary.ActiveLinkColor = System.Drawing.Color.Red
        Me.linkStartOpenLibrary.AutoSize = True
        Me.linkStartOpenLibrary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.linkStartOpenLibrary.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkStartOpenLibrary.Location = New System.Drawing.Point(6, 80)
        Me.linkStartOpenLibrary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.linkStartOpenLibrary.Name = "linkStartOpenLibrary"
        Me.linkStartOpenLibrary.Size = New System.Drawing.Size(131, 16)
        Me.linkStartOpenLibrary.TabIndex = 5
        Me.linkStartOpenLibrary.TabStop = True
        Me.linkStartOpenLibrary.Text = "Import From Library..."
        '
        'panelSectionRecent
        '
        Me.panelSectionRecent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelSectionRecent.Controls.Add(Me.lblRecent)
        Me.panelSectionRecent.Controls.Add(Me.panelRecentMenuItems)
        Me.panelSectionRecent.Location = New System.Drawing.Point(35, 155)
        Me.panelSectionRecent.Margin = New System.Windows.Forms.Padding(4)
        Me.panelSectionRecent.Name = "panelSectionRecent"
        Me.panelSectionRecent.Size = New System.Drawing.Size(223, 232)
        Me.panelSectionRecent.TabIndex = 13
        '
        'lblRecent
        '
        Me.lblRecent.AutoSize = True
        Me.lblRecent.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRecent.Location = New System.Drawing.Point(4, 5)
        Me.lblRecent.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.Size = New System.Drawing.Size(101, 31)
        Me.lblRecent.TabIndex = 1
        Me.lblRecent.Text = "Recent"
        '
        'panelRecentMenuItems
        '
        Me.panelRecentMenuItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelRecentMenuItems.AutoScroll = True
        Me.panelRecentMenuItems.Location = New System.Drawing.Point(6, 38)
        Me.panelRecentMenuItems.Margin = New System.Windows.Forms.Padding(4)
        Me.panelRecentMenuItems.Name = "panelRecentMenuItems"
        Me.panelRecentMenuItems.Size = New System.Drawing.Size(198, 172)
        Me.panelRecentMenuItems.TabIndex = 6
        '
        'TblPanPageDisplay
        '
        Me.TblPanPageDisplay.AutoSize = True
        Me.TblPanPageDisplay.ColumnCount = 12
        Me.tlpTableContainer.SetColumnSpan(Me.TblPanPageDisplay, 2)
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TblPanPageDisplay.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
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
        Me.TblPanPageDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblPanPageDisplay.Location = New System.Drawing.Point(311, 576)
        Me.TblPanPageDisplay.Margin = New System.Windows.Forms.Padding(0)
        Me.TblPanPageDisplay.Name = "TblPanPageDisplay"
        Me.TblPanPageDisplay.RowCount = 1
        Me.TblPanPageDisplay.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TblPanPageDisplay.Size = New System.Drawing.Size(624, 25)
        Me.TblPanPageDisplay.TabIndex = 8
        '
        'lblColFirst
        '
        Me.lblColFirst.AutoSize = True
        Me.lblColFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColFirst.Location = New System.Drawing.Point(395, 0)
        Me.lblColFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColFirst.Name = "lblColFirst"
        Me.lblColFirst.Size = New System.Drawing.Size(23, 25)
        Me.lblColFirst.TabIndex = 15
        Me.lblColFirst.Text = "«"
        Me.lblColFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColDisplay
        '
        Me.lblColDisplay.AutoSize = True
        Me.lblColDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColDisplay.Location = New System.Drawing.Point(316, 0)
        Me.lblColDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColDisplay.Name = "lblColDisplay"
        Me.lblColDisplay.Size = New System.Drawing.Size(71, 25)
        Me.lblColDisplay.TabIndex = 14
        Me.lblColDisplay.Text = "Label1"
        Me.lblColDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColNext
        '
        Me.lblColNext.AutoSize = True
        Me.lblColNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColNext.Location = New System.Drawing.Point(458, 0)
        Me.lblColNext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColNext.Name = "lblColNext"
        Me.lblColNext.Size = New System.Drawing.Size(24, 25)
        Me.lblColNext.TabIndex = 13
        Me.lblColNext.Text = ">"
        Me.lblColNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColBack
        '
        Me.lblColBack.AutoSize = True
        Me.lblColBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColBack.Location = New System.Drawing.Point(426, 0)
        Me.lblColBack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColBack.Name = "lblColBack"
        Me.lblColBack.Size = New System.Drawing.Size(24, 25)
        Me.lblColBack.TabIndex = 12
        Me.lblColBack.Text = "<"
        Me.lblColBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowLast
        '
        Me.lblRowLast.AutoSize = True
        Me.lblRowLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowLast.Location = New System.Drawing.Point(285, 0)
        Me.lblRowLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowLast.Name = "lblRowLast"
        Me.lblRowLast.Size = New System.Drawing.Size(23, 25)
        Me.lblRowLast.TabIndex = 11
        Me.lblRowLast.Text = "»"
        Me.lblRowLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowFirst
        '
        Me.lblRowFirst.AutoSize = True
        Me.lblRowFirst.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowFirst.Location = New System.Drawing.Point(190, 0)
        Me.lblRowFirst.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowFirst.Name = "lblRowFirst"
        Me.lblRowFirst.Size = New System.Drawing.Size(23, 25)
        Me.lblRowFirst.TabIndex = 10
        Me.lblRowFirst.Text = "«"
        Me.lblRowFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowDisplay
        '
        Me.lblRowDisplay.AutoSize = True
        Me.lblRowDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowDisplay.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblRowDisplay.Location = New System.Drawing.Point(111, 0)
        Me.lblRowDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowDisplay.Name = "lblRowDisplay"
        Me.lblRowDisplay.Size = New System.Drawing.Size(71, 25)
        Me.lblRowDisplay.TabIndex = 9
        Me.lblRowDisplay.Text = "Label1"
        Me.lblRowDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblRowNext
        '
        Me.lblRowNext.AutoSize = True
        Me.lblRowNext.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowNext.Location = New System.Drawing.Point(253, 0)
        Me.lblRowNext.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowNext.Name = "lblRowNext"
        Me.lblRowNext.Size = New System.Drawing.Size(24, 25)
        Me.lblRowNext.TabIndex = 8
        Me.lblRowNext.Text = ">"
        Me.lblRowNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColLast
        '
        Me.lblColLast.AutoSize = True
        Me.lblColLast.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColLast.Location = New System.Drawing.Point(490, 0)
        Me.lblColLast.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColLast.Name = "lblColLast"
        Me.lblColLast.Size = New System.Drawing.Size(23, 25)
        Me.lblColLast.TabIndex = 7
        Me.lblColLast.Text = "»"
        Me.lblColLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowBack
        '
        Me.lblRowBack.AutoSize = True
        Me.lblRowBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowBack.Location = New System.Drawing.Point(221, 0)
        Me.lblRowBack.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRowBack.Name = "lblRowBack"
        Me.lblRowBack.Size = New System.Drawing.Size(24, 25)
        Me.lblRowBack.TabIndex = 5
        Me.lblRowBack.Text = "<"
        Me.lblRowBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucrReoGrid
        '
        Me.ucrReoGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrReoGrid.Location = New System.Drawing.Point(623, 26)
        Me.ucrReoGrid.Margin = New System.Windows.Forms.Padding(1)
        Me.ucrReoGrid.Name = "ucrReoGrid"
        Me.ucrReoGrid.Size = New System.Drawing.Size(311, 549)
        Me.ucrReoGrid.TabIndex = 12
        '
        'ucrLinuxGrid
        '
        Me.ucrLinuxGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrLinuxGrid.Location = New System.Drawing.Point(312, 26)
        Me.ucrLinuxGrid.Margin = New System.Windows.Forms.Padding(1)
        Me.ucrLinuxGrid.Name = "ucrLinuxGrid"
        Me.ucrLinuxGrid.Size = New System.Drawing.Size(309, 549)
        Me.ucrLinuxGrid.TabIndex = 13
        '
        'ucrDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucrDataView"
        Me.Size = New System.Drawing.Size(935, 601)
        Me.Tag = "Data_View"
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.tlpTableContainer.ResumeLayout(False)
        Me.tlpTableContainer.PerformLayout()
        Me.panelSectionsAll.ResumeLayout(False)
        Me.panelSectionAdvanced.ResumeLayout(False)
        Me.panelSectionAdvanced.PerformLayout()
        Me.panelSectionHelp.ResumeLayout(False)
        Me.panelSectionHelp.PerformLayout()
        Me.panelSectionStart.ResumeLayout(False)
        Me.panelSectionStart.PerformLayout()
        Me.panelSectionRecent.ResumeLayout(False)
        Me.panelSectionRecent.PerformLayout()
        Me.TblPanPageDisplay.ResumeLayout(False)
        Me.TblPanPageDisplay.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents columnContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertColsBefore As ToolStripMenuItem
    Private WithEvents mnuDeleteCol As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Private WithEvents toolStripMenuItem21 As ToolStripSeparator
    Private WithEvents mnuColumnFilterRows As ToolStripMenuItem
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
    Friend WithEvents mnuCovertToOrderedFactors As ToolStripMenuItem
    Friend WithEvents mnuDuplicateColumn As ToolStripMenuItem
    Friend WithEvents mnuAddComment As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents lblHeaderDataView As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents mnuLevelsLabels As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuReorderColumns As ToolStripMenuItem
    Friend WithEvents mnuRenameColumn As ToolStripMenuItem
    Friend WithEvents mnuDuplColumn As ToolStripMenuItem
    Friend WithEvents mnuReorderColumn As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents mnuConvertToFact As ToolStripMenuItem
    Friend WithEvents mnuConvertToOrderedFactor As ToolStripMenuItem
    Friend WithEvents mnuConvertToCharacter As ToolStripMenuItem
    Friend WithEvents mnuConvertToNumeric As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents mnuLabelsLevel As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents mnuSorts As ToolStripMenuItem
    Private WithEvents mnuFilterRows As ToolStripMenuItem
    Private WithEvents mnuRemoveCurrentFilters As ToolStripMenuItem
    Friend WithEvents mnuComment As ToolStripMenuItem
    Friend WithEvents mnuColumnAddComment As ToolStripMenuItem
    Friend WithEvents mnuBottomAddComment As ToolStripMenuItem
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
    Friend WithEvents panelSectionsAll As Panel
    Friend WithEvents panelSectionRecent As Panel
    Friend WithEvents lblRecent As Label
    Friend WithEvents panelRecentMenuItems As Panel
    Friend WithEvents panelSectionHelp As Panel
    Friend WithEvents lblHelp As Label
    Friend WithEvents linkHelpRInstatResourcesSite As LinkLabel
    Friend WithEvents panelSectionStart As Panel
    Friend WithEvents lblStart As Label
    Friend WithEvents linkStartNewDataFrame As LinkLabel
    Friend WithEvents linkStartOpenFile As LinkLabel
    Friend WithEvents linkStartOpenLibrary As LinkLabel
    Friend WithEvents ucrReoGrid As ucrDataViewReoGrid
    Friend WithEvents ucrLinuxGrid As ucrDataViewLinuxGrid

    Private WithEvents mnuDeleteCell As ToolStripMenuItem
    Friend WithEvents mnuDeleteCells As ToolStripMenuItem

    Friend WithEvents mnuColumnContextColumnSelection As ToolStripMenuItem
    Friend WithEvents mnuColumnContextRemoveCurrentColumnSelection As ToolStripMenuItem
    Friend WithEvents mnuCellContextColumnSelection As ToolStripMenuItem
    Friend WithEvents mnuCellContextRemoveCurrentColumnSelection As ToolStripMenuItem
    Friend WithEvents mnuRowContextColumnSelection As ToolStripMenuItem
    Friend WithEvents mnuRowContextRemoveCurrentColumnSelection As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents mnuHelp1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents mnuHelp2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents mnuHelp3 As ToolStripMenuItem
    Friend WithEvents ttGoToRowOrColPage As ToolTip
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Private WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents mnuEditCell2 As ToolStripMenuItem
    Friend WithEvents mnuDeleteCells2 As ToolStripMenuItem
    Friend WithEvents mnuDeleteCol2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents mnuEditCell As ToolStripMenuItem
    Friend WithEvents linkHelpData As LinkLabel
    Friend WithEvents linkHelpGettingStarted As LinkLabel
    Friend WithEvents panelSectionAdvanced As Panel
    Friend WithEvents lblAdvanced As Label
    Friend WithEvents linkStartRestoreBackup As LinkLabel
    Friend WithEvents linkStartPasteScriptfromClipboard As LinkLabel
    Friend WithEvents linkStartAddRPackage As LinkLabel
    Friend WithEvents linkStartPasteData As LinkLabel
    Friend WithEvents mnuConvertToDate As ToolStripMenuItem
    Friend WithEvents mnuConvertToColumnDate As ToolStripMenuItem
End Class
