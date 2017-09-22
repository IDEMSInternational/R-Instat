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
        Me.mnuInsertColsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCovertToOrderedFactors = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertToDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvert = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnhideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnhideAllColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.FreezeToHereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnfreezeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearColumnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddComment = New System.Windows.Forms.ToolStripMenuItem()
        Me.cutRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.insertSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteDataFrame = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdData.SheetTabNewButtonVisible = False
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 154
        Me.grdData.ShowScrollEndSpacing = True
        Me.grdData.Size = New System.Drawing.Size(438, 238)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertVariate, Me.mnuConvertToDate, Me.mnuConvert, Me.ToolStripSeparator1, Me.mnuHideColumns, Me.mnuUnhideColumns, Me.mnuUnhideAllColumns, Me.toolStripMenuItem21, Me.FreezeToHereToolStripMenuItem, Me.UnfreezeToolStripMenuItem, Me.ToolStripSeparator3, Me.SortToolStripMenuItem, Me.columnFilterToolStripMenuItem, Me.clearColumnFilterToolStripMenuItem})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(213, 446)
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
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'mnuConvertToDate
        '
        Me.mnuConvertToDate.Name = "mnuConvertToDate"
        Me.mnuConvertToDate.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvertToDate.Text = "Convert to Date..."
        '
        'mnuConvert
        '
        Me.mnuConvert.Name = "mnuConvert"
        Me.mnuConvert.Size = New System.Drawing.Size(212, 22)
        Me.mnuConvert.Text = "Convert..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'mnuHideColumns
        '
        Me.mnuHideColumns.Name = "mnuHideColumns"
        Me.mnuHideColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuHideColumns.Text = "Hide"
        '
        'mnuUnhideColumns
        '
        Me.mnuUnhideColumns.Name = "mnuUnhideColumns"
        Me.mnuUnhideColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuUnhideColumns.Text = "Unhide..."
        '
        'mnuUnhideAllColumns
        '
        Me.mnuUnhideAllColumns.Name = "mnuUnhideAllColumns"
        Me.mnuUnhideAllColumns.Size = New System.Drawing.Size(212, 22)
        Me.mnuUnhideAllColumns.Tag = "Unhide_All"
        Me.mnuUnhideAllColumns.Text = "Unhide All"
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(209, 6)
        '
        'FreezeToHereToolStripMenuItem
        '
        Me.FreezeToHereToolStripMenuItem.Name = "FreezeToHereToolStripMenuItem"
        Me.FreezeToHereToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.FreezeToHereToolStripMenuItem.Text = "Freeze to Here"
        '
        'UnfreezeToolStripMenuItem
        '
        Me.UnfreezeToolStripMenuItem.Name = "UnfreezeToolStripMenuItem"
        Me.UnfreezeToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.UnfreezeToolStripMenuItem.Text = "Unfreeze"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SortToolStripMenuItem.Text = "Sort..."
        '
        'columnFilterToolStripMenuItem
        '
        Me.columnFilterToolStripMenuItem.Name = "columnFilterToolStripMenuItem"
        Me.columnFilterToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.columnFilterToolStripMenuItem.Text = "Filter..."
        '
        'clearColumnFilterToolStripMenuItem
        '
        Me.clearColumnFilterToolStripMenuItem.Name = "clearColumnFilterToolStripMenuItem"
        Me.clearColumnFilterToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.clearColumnFilterToolStripMenuItem.Text = "Remove Current Filter"
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddComment, Me.cutRangeToolStripMenuItem, Me.copyRangeToolStripMenuItem, Me.pasteRangeToolStripMenuItem})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(163, 92)
        '
        'AddComment
        '
        Me.AddComment.Name = "AddComment"
        Me.AddComment.Size = New System.Drawing.Size(162, 22)
        Me.AddComment.Text = "Add Comment..."
        '
        'cutRangeToolStripMenuItem
        '
        Me.cutRangeToolStripMenuItem.Enabled = False
        Me.cutRangeToolStripMenuItem.Name = "cutRangeToolStripMenuItem"
        Me.cutRangeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.cutRangeToolStripMenuItem.Text = "Cut"
        '
        'copyRangeToolStripMenuItem
        '
        Me.copyRangeToolStripMenuItem.Name = "copyRangeToolStripMenuItem"
        Me.copyRangeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.copyRangeToolStripMenuItem.Text = "Copy"
        '
        'pasteRangeToolStripMenuItem
        '
        Me.pasteRangeToolStripMenuItem.Enabled = False
        Me.pasteRangeToolStripMenuItem.Name = "pasteRangeToolStripMenuItem"
        Me.pasteRangeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.pasteRangeToolStripMenuItem.Text = "Paste"
        '
        'rowContextMenuStrip
        '
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
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertSheet, Me.deleteDataFrame, Me.renameSheet, Me.reorderSheet, Me.CopySheet, Me.HideSheet, Me.unhideSheet, Me.ViewSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(163, 180)
        '
        'insertSheet
        '
        Me.insertSheet.Name = "insertSheet"
        Me.insertSheet.Size = New System.Drawing.Size(162, 22)
        Me.insertSheet.Text = "Insert..."
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
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(162, 22)
        Me.reorderSheet.Text = "Reorder..."
        '
        'CopySheet
        '
        Me.CopySheet.Name = "CopySheet"
        Me.CopySheet.Size = New System.Drawing.Size(162, 22)
        Me.CopySheet.Text = "Copy..."
        '
        'HideSheet
        '
        Me.HideSheet.Enabled = False
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(162, 22)
        Me.HideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Enabled = False
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(162, 22)
        Me.unhideSheet.Text = "Unhide"
        '
        'ViewSheet
        '
        Me.ViewSheet.Name = "ViewSheet"
        Me.ViewSheet.Size = New System.Drawing.Size(162, 22)
        Me.ViewSheet.Text = "View Data Frame"
        '
        'lblNoData
        '
        Me.lblNoData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoData.Location = New System.Drawing.Point(0, 0)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(438, 238)
        Me.lblNoData.TabIndex = 1
        Me.lblNoData.Tag = "no_data_loaded"
        Me.lblNoData.Text = "No Data Loaded"
        Me.lblNoData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowDisplay
        '
        Me.lblRowDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRowDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRowDisplay.Location = New System.Drawing.Point(3, 264)
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
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.tlpTableContainer.Size = New System.Drawing.Size(444, 284)
        Me.tlpTableContainer.TabIndex = 6
        '
        'pnlDataContainer
        '
        Me.pnlDataContainer.Controls.Add(Me.grdData)
        Me.pnlDataContainer.Controls.Add(Me.lblNoData)
        Me.pnlDataContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDataContainer.Location = New System.Drawing.Point(3, 23)
        Me.pnlDataContainer.Name = "pnlDataContainer"
        Me.pnlDataContainer.Size = New System.Drawing.Size(438, 238)
        Me.pnlDataContainer.TabIndex = 7
        '
        'ucrDataView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrDataView"
        Me.Size = New System.Drawing.Size(444, 284)
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
    Private WithEvents mnuHideColumns As ToolStripMenuItem
    Private WithEvents mnuUnhideColumns As ToolStripMenuItem
    Private WithEvents toolStripMenuItem21 As ToolStripSeparator
    Private WithEvents columnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents clearColumnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents cellContextMenuStrip As ContextMenuStrip
    Private WithEvents cutRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents copyRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pasteRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rowContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertRowsAfter As ToolStripMenuItem
    Private WithEvents mnuDeleteRows As ToolStripMenuItem
    Friend WithEvents statusColumnMenu As ContextMenuStrip
    Friend WithEvents insertSheet As ToolStripMenuItem
    Friend WithEvents deleteDataFrame As ToolStripMenuItem
    Friend WithEvents renameSheet As ToolStripMenuItem
    Friend WithEvents mnuColumnRename As ToolStripMenuItem
    Friend WithEvents mnuConvertText As ToolStripMenuItem
    Friend WithEvents mnuConvertVariate As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuConvertToFactor As ToolStripMenuItem
    Friend WithEvents CopySheet As ToolStripMenuItem
    Friend WithEvents HideSheet As ToolStripMenuItem
    Friend WithEvents reorderSheet As ToolStripMenuItem
    Friend WithEvents unhideSheet As ToolStripMenuItem
    Friend WithEvents mnuUnhideAllColumns As ToolStripMenuItem
    Friend WithEvents mnuInsertColsAfter As ToolStripMenuItem
    Friend WithEvents mnuInsertRowsBefore As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuFilter As ToolStripMenuItem
    Friend WithEvents mnuRemoveCurrentFilter As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FreezeToHereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnfreezeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents mnuConvert As ToolStripMenuItem
    Friend WithEvents ViewSheet As ToolStripMenuItem
    Friend WithEvents mnuConvertToDate As ToolStripMenuItem
    Friend WithEvents mnuCovertToOrderedFactors As ToolStripMenuItem
    Friend WithEvents mnuDuplicateColumn As ToolStripMenuItem
    Friend WithEvents lblRowDisplay As Label
    Friend WithEvents mnuAddComment As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AddComment As ToolStripMenuItem
    Friend WithEvents lblHeader As Label
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents pnlDataContainer As Panel
End Class
