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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrDataView))
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
        Me.mnuConvertToLogical = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuLevelsLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFreezeToHere = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnfreeze = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClearColumnFilter = New System.Windows.Forms.ToolStripMenuItem()
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
        resources.ApplyResources(Me.grdData, "grdData")
        Me.grdData.LeadHeaderContextMenuStrip = Nothing
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdData.SheetTabNewButtonVisible = False
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 154
        Me.grdData.ShowScrollEndSpacing = True
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuDuplicateColumn, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuCovertToOrderedFactors, Me.mnuConvertText, Me.mnuConvertToLogical, Me.mnuConvertVariate, Me.ToolStripSeparator1, Me.mnuLevelsLabels, Me.toolStripMenuItem21, Me.mnuFreezeToHere, Me.mnuUnfreeze, Me.ToolStripSeparator3, Me.mnuSort, Me.mnuColumnFilter, Me.mnuClearColumnFilter})
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'mnuLevelsLabels
        '
        Me.mnuLevelsLabels.Name = "mnuLevelsLabels"
        resources.ApplyResources(Me.mnuLevelsLabels, "mnuLevelsLabels")
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        resources.ApplyResources(Me.toolStripMenuItem21, "toolStripMenuItem21")
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
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddComment, Me.cutRangeToolStripMenuItem, Me.copyRangeToolStripMenuItem, Me.pasteRangeToolStripMenuItem})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        resources.ApplyResources(Me.cellContextMenuStrip, "cellContextMenuStrip")
        '
        'AddComment
        '
        Me.AddComment.Name = "AddComment"
        resources.ApplyResources(Me.AddComment, "AddComment")
        '
        'cutRangeToolStripMenuItem
        '
        resources.ApplyResources(Me.cutRangeToolStripMenuItem, "cutRangeToolStripMenuItem")
        Me.cutRangeToolStripMenuItem.Name = "cutRangeToolStripMenuItem"
        '
        'copyRangeToolStripMenuItem
        '
        Me.copyRangeToolStripMenuItem.Name = "copyRangeToolStripMenuItem"
        resources.ApplyResources(Me.copyRangeToolStripMenuItem, "copyRangeToolStripMenuItem")
        '
        'pasteRangeToolStripMenuItem
        '
        resources.ApplyResources(Me.pasteRangeToolStripMenuItem, "pasteRangeToolStripMenuItem")
        Me.pasteRangeToolStripMenuItem.Name = "pasteRangeToolStripMenuItem"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRowsBefore, Me.mnuInsertRowsAfter, Me.mnuDeleteRows, Me.ToolStripSeparator2, Me.mnuAddComment, Me.ToolStripSeparator4, Me.mnuFilter, Me.mnuRemoveCurrentFilter})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        resources.ApplyResources(Me.rowContextMenuStrip, "rowContextMenuStrip")
        '
        'mnuInsertRowsBefore
        '
        Me.mnuInsertRowsBefore.Name = "mnuInsertRowsBefore"
        resources.ApplyResources(Me.mnuInsertRowsBefore, "mnuInsertRowsBefore")
        '
        'mnuInsertRowsAfter
        '
        Me.mnuInsertRowsAfter.Name = "mnuInsertRowsAfter"
        resources.ApplyResources(Me.mnuInsertRowsAfter, "mnuInsertRowsAfter")
        '
        'mnuDeleteRows
        '
        Me.mnuDeleteRows.Name = "mnuDeleteRows"
        resources.ApplyResources(Me.mnuDeleteRows, "mnuDeleteRows")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'mnuAddComment
        '
        Me.mnuAddComment.Name = "mnuAddComment"
        resources.ApplyResources(Me.mnuAddComment, "mnuAddComment")
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        resources.ApplyResources(Me.ToolStripSeparator4, "ToolStripSeparator4")
        '
        'mnuFilter
        '
        Me.mnuFilter.Name = "mnuFilter"
        resources.ApplyResources(Me.mnuFilter, "mnuFilter")
        Me.mnuFilter.Tag = "Filter..."
        '
        'mnuRemoveCurrentFilter
        '
        Me.mnuRemoveCurrentFilter.Name = "mnuRemoveCurrentFilter"
        resources.ApplyResources(Me.mnuRemoveCurrentFilter, "mnuRemoveCurrentFilter")
        Me.mnuRemoveCurrentFilter.Tag = "Remove_Current_Filter"
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteDataFrame, Me.renameSheet, Me.HideSheet, Me.unhideSheet, Me.CopySheet, Me.reorderSheet, Me.ViewSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        resources.ApplyResources(Me.statusColumnMenu, "statusColumnMenu")
        '
        'deleteDataFrame
        '
        Me.deleteDataFrame.Name = "deleteDataFrame"
        resources.ApplyResources(Me.deleteDataFrame, "deleteDataFrame")
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        resources.ApplyResources(Me.renameSheet, "renameSheet")
        '
        'HideSheet
        '
        Me.HideSheet.Name = "HideSheet"
        resources.ApplyResources(Me.HideSheet, "HideSheet")
        '
        'unhideSheet
        '
        Me.unhideSheet.Name = "unhideSheet"
        resources.ApplyResources(Me.unhideSheet, "unhideSheet")
        '
        'CopySheet
        '
        Me.CopySheet.Name = "CopySheet"
        resources.ApplyResources(Me.CopySheet, "CopySheet")
        '
        'reorderSheet
        '
        resources.ApplyResources(Me.reorderSheet, "reorderSheet")
        Me.reorderSheet.Name = "reorderSheet"
        '
        'ViewSheet
        '
        Me.ViewSheet.Name = "ViewSheet"
        resources.ApplyResources(Me.ViewSheet, "ViewSheet")
        '
        'lblNoData
        '
        resources.ApplyResources(Me.lblNoData, "lblNoData")
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Tag = "no_data_loaded"
        '
        'lblRowDisplay
        '
        resources.ApplyResources(Me.lblRowDisplay, "lblRowDisplay")
        Me.lblRowDisplay.Name = "lblRowDisplay"
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
        Me.tlpTableContainer.Controls.Add(Me.lblHeader, 0, 0)
        Me.tlpTableContainer.Controls.Add(Me.lblRowDisplay, 0, 2)
        Me.tlpTableContainer.Controls.Add(Me.pnlDataContainer, 0, 1)
        Me.tlpTableContainer.Name = "tlpTableContainer"
        '
        'pnlDataContainer
        '
        Me.pnlDataContainer.Controls.Add(Me.grdData)
        Me.pnlDataContainer.Controls.Add(Me.lblNoData)
        resources.ApplyResources(Me.pnlDataContainer, "pnlDataContainer")
        Me.pnlDataContainer.Name = "pnlDataContainer"
        '
        'ucrDataView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpTableContainer)
        Me.Name = "ucrDataView"
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
    Private WithEvents cutRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents copyRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pasteRangeToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents mnuFreezeToHere As ToolStripMenuItem
    Friend WithEvents mnuUnfreeze As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ViewSheet As ToolStripMenuItem
    Friend WithEvents mnuCovertToOrderedFactors As ToolStripMenuItem
    Friend WithEvents mnuDuplicateColumn As ToolStripMenuItem
    Friend WithEvents lblRowDisplay As Label
    Friend WithEvents mnuAddComment As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AddComment As ToolStripMenuItem
    Friend WithEvents lblHeader As Label
    Friend WithEvents mnuConvertToLogical As ToolStripMenuItem
    Friend WithEvents tlpTableContainer As TableLayoutPanel
    Friend WithEvents pnlDataContainer As Panel
    Friend WithEvents mnuLevelsLabels As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
