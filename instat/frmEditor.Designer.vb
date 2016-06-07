﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEditor
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
        Me.components = New System.ComponentModel.Container()
        Me.grdData = New unvell.ReoGrid.ReoGridControl()
        Me.columnContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuColumnRename = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertColsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuHideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnhideColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnhideAllColumns = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.columnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearColumnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem35 = New System.Windows.Forms.ToolStripSeparator()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cutRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuInsertRowsBefore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInsertRowsAfter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveCurrentFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusColumnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.insertSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.reorderSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.rowContextMenuStrip.SuspendLayout()
        Me.statusColumnMenu.SuspendLayout()
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
        Me.grdData.SheetTabWidth = 200
        Me.grdData.Size = New System.Drawing.Size(410, 261)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuInsertColsBefore, Me.mnuInsertColsAfter, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuConvertText, Me.mnuConvertVariate, Me.ToolStripSeparator1, Me.mnuHideColumns, Me.mnuUnhideColumns, Me.mnuUnhideAllColumns, Me.toolStripMenuItem21, Me.columnFilterToolStripMenuItem, Me.clearColumnFilterToolStripMenuItem, Me.toolStripMenuItem35})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(200, 292)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(199, 22)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuInsertColsBefore
        '
        Me.mnuInsertColsBefore.Name = "mnuInsertColsBefore"
        Me.mnuInsertColsBefore.Size = New System.Drawing.Size(199, 22)
        Me.mnuInsertColsBefore.Text = "Insert Column(s) Before"
        '
        'mnuInsertColsAfter
        '
        Me.mnuInsertColsAfter.Name = "mnuInsertColsAfter"
        Me.mnuInsertColsAfter.Size = New System.Drawing.Size(199, 22)
        Me.mnuInsertColsAfter.Text = "Insert Column(s) After"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(199, 22)
        Me.mnuDeleteCol.Text = "Delete Column(s)"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(196, 6)
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(199, 22)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(199, 22)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(199, 22)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        '
        'mnuHideColumns
        '
        Me.mnuHideColumns.Name = "mnuHideColumns"
        Me.mnuHideColumns.Size = New System.Drawing.Size(199, 22)
        Me.mnuHideColumns.Text = "Hide"
        '
        'mnuUnhideColumns
        '
        Me.mnuUnhideColumns.Name = "mnuUnhideColumns"
        Me.mnuUnhideColumns.Size = New System.Drawing.Size(199, 22)
        Me.mnuUnhideColumns.Text = "Unhide..."
        '
        'mnuUnhideAllColumns
        '
        Me.mnuUnhideAllColumns.Name = "mnuUnhideAllColumns"
        Me.mnuUnhideAllColumns.Size = New System.Drawing.Size(199, 22)
        Me.mnuUnhideAllColumns.Tag = "Unhide_All"
        Me.mnuUnhideAllColumns.Text = "Unhide All"
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(196, 6)
        '
        'columnFilterToolStripMenuItem
        '
        Me.columnFilterToolStripMenuItem.Enabled = False
        Me.columnFilterToolStripMenuItem.Name = "columnFilterToolStripMenuItem"
        Me.columnFilterToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.columnFilterToolStripMenuItem.Text = "Filter..."
        '
        'clearColumnFilterToolStripMenuItem
        '
        Me.clearColumnFilterToolStripMenuItem.Enabled = False
        Me.clearColumnFilterToolStripMenuItem.Name = "clearColumnFilterToolStripMenuItem"
        Me.clearColumnFilterToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.clearColumnFilterToolStripMenuItem.Text = "Clear Filters"
        '
        'toolStripMenuItem35
        '
        Me.toolStripMenuItem35.Name = "toolStripMenuItem35"
        Me.toolStripMenuItem35.Size = New System.Drawing.Size(196, 6)
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutRangeToolStripMenuItem, Me.copyRangeToolStripMenuItem, Me.pasteRangeToolStripMenuItem})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(103, 70)
        '
        'cutRangeToolStripMenuItem
        '
        Me.cutRangeToolStripMenuItem.Enabled = False
        Me.cutRangeToolStripMenuItem.Name = "cutRangeToolStripMenuItem"
        Me.cutRangeToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.cutRangeToolStripMenuItem.Text = "Cut"
        '
        'copyRangeToolStripMenuItem
        '
        Me.copyRangeToolStripMenuItem.Name = "copyRangeToolStripMenuItem"
        Me.copyRangeToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.copyRangeToolStripMenuItem.Text = "Copy"
        '
        'pasteRangeToolStripMenuItem
        '
        Me.pasteRangeToolStripMenuItem.Enabled = False
        Me.pasteRangeToolStripMenuItem.Name = "pasteRangeToolStripMenuItem"
        Me.pasteRangeToolStripMenuItem.Size = New System.Drawing.Size(102, 22)
        Me.pasteRangeToolStripMenuItem.Text = "Paste"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRowsBefore, Me.mnuInsertRowsAfter, Me.mnuDeleteRows, Me.ToolStripSeparator2, Me.mnuFilter, Me.mnuRemoveCurrentFilter})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(190, 120)
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
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertSheet, Me.deleteSheet, Me.renameSheet, Me.reorderSheet, Me.CopySheet, Me.HideSheet, Me.unhideSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(153, 180)
        '
        'insertSheet
        '
        Me.insertSheet.Name = "insertSheet"
        Me.insertSheet.Size = New System.Drawing.Size(152, 22)
        Me.insertSheet.Text = "Insert..."
        '
        'deleteSheet
        '
        Me.deleteSheet.Enabled = False
        Me.deleteSheet.Name = "deleteSheet"
        Me.deleteSheet.Size = New System.Drawing.Size(152, 22)
        Me.deleteSheet.Text = "Delete"
        '
        'renameSheet
        '
        Me.renameSheet.Enabled = False
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(152, 22)
        Me.renameSheet.Text = "Rename..."
        '
        'reorderSheet
        '
        Me.reorderSheet.Enabled = False
        Me.reorderSheet.Name = "reorderSheet"
        Me.reorderSheet.Size = New System.Drawing.Size(152, 22)
        Me.reorderSheet.Text = "Reorder..."
        '
        'CopySheet
        '
        Me.CopySheet.Enabled = False
        Me.CopySheet.Name = "CopySheet"
        Me.CopySheet.Size = New System.Drawing.Size(152, 22)
        Me.CopySheet.Text = "Copy..."
        '
        'HideSheet
        '
        Me.HideSheet.Enabled = False
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(152, 22)
        Me.HideSheet.Text = "Hide"
        '
        'unhideSheet
        '
        Me.unhideSheet.Enabled = False
        Me.unhideSheet.Name = "unhideSheet"
        Me.unhideSheet.Size = New System.Drawing.Size(152, 22)
        Me.unhideSheet.Text = "Unhide"
        '
        'lblNoData
        '
        Me.lblNoData.AutoSize = True
        Me.lblNoData.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoData.Location = New System.Drawing.Point(122, 105)
        Me.lblNoData.Name = "lblNoData"
        Me.lblNoData.Size = New System.Drawing.Size(211, 31)
        Me.lblNoData.TabIndex = 1
        Me.lblNoData.Tag = "no_data_loaded"
        Me.lblNoData.Text = "No Data Loaded"
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 261)
        Me.Controls.Add(Me.grdData)
        Me.Controls.Add(Me.lblNoData)
        Me.Name = "frmEditor"
        Me.ShowIcon = False
        Me.Tag = "Data_View"
        Me.Text = "Data View"
        Me.columnContextMenuStrip.ResumeLayout(False)
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Private WithEvents toolStripMenuItem35 As ToolStripSeparator
    Private WithEvents cellContextMenuStrip As ContextMenuStrip
    Private WithEvents cutRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents copyRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pasteRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rowContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertRowsAfter As ToolStripMenuItem
    Private WithEvents mnuDeleteRows As ToolStripMenuItem
    Friend WithEvents statusColumnMenu As ContextMenuStrip
    Friend WithEvents insertSheet As ToolStripMenuItem
    Friend WithEvents deleteSheet As ToolStripMenuItem
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
End Class
