<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.mnuInsertCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteCol = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConvertToFactor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertText = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConvertVariate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.hideColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.columnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearColumnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem35 = New System.Windows.Forms.ToolStripSeparator()
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cutRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mergeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.unmergeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.leadHeaderContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.resetAllPageBreaksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuInsertRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDeleteRows = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.hideRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripMenuItem33 = New System.Windows.Forms.ToolStripSeparator()
        Me.statusColumnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.insertSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoveOrCopySheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNoData = New System.Windows.Forms.Label()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.leadHeaderContextMenuStrip.SuspendLayout()
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
        Me.grdData.LeadHeaderContextMenuStrip = Me.leadHeaderContextMenuStrip
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Me.statusColumnMenu
        Me.grdData.SheetTabNewButtonVisible = True
        Me.grdData.SheetTabVisible = True
        Me.grdData.SheetTabWidth = 200
        Me.grdData.Size = New System.Drawing.Size(410, 261)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColumnRename, Me.mnuInsertCol, Me.mnuDeleteCol, Me.toolStripMenuItem2, Me.mnuConvertToFactor, Me.mnuConvertText, Me.mnuConvertVariate, Me.ToolStripSeparator1, Me.hideColumnsToolStripMenuItem, Me.unhideColumnsToolStripMenuItem, Me.toolStripMenuItem21, Me.columnFilterToolStripMenuItem, Me.clearColumnFilterToolStripMenuItem, Me.toolStripMenuItem35})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(185, 248)
        '
        'mnuColumnRename
        '
        Me.mnuColumnRename.Name = "mnuColumnRename"
        Me.mnuColumnRename.Size = New System.Drawing.Size(184, 22)
        Me.mnuColumnRename.Text = "Rename Column..."
        '
        'mnuInsertCol
        '
        Me.mnuInsertCol.Name = "mnuInsertCol"
        Me.mnuInsertCol.Size = New System.Drawing.Size(184, 22)
        Me.mnuInsertCol.Text = "Insert &Columns"
        '
        'mnuDeleteCol
        '
        Me.mnuDeleteCol.Name = "mnuDeleteCol"
        Me.mnuDeleteCol.Size = New System.Drawing.Size(184, 22)
        Me.mnuDeleteCol.Text = "Delete Columns"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(181, 6)
        '
        'mnuConvertToFactor
        '
        Me.mnuConvertToFactor.Name = "mnuConvertToFactor"
        Me.mnuConvertToFactor.Size = New System.Drawing.Size(184, 22)
        Me.mnuConvertToFactor.Text = "Convert to Factor"
        '
        'mnuConvertText
        '
        Me.mnuConvertText.Name = "mnuConvertText"
        Me.mnuConvertText.Size = New System.Drawing.Size(184, 22)
        Me.mnuConvertText.Text = "Convert to Character"
        '
        'mnuConvertVariate
        '
        Me.mnuConvertVariate.Name = "mnuConvertVariate"
        Me.mnuConvertVariate.Size = New System.Drawing.Size(184, 22)
        Me.mnuConvertVariate.Text = "Convert to Numeric"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(181, 6)
        '
        'hideColumnsToolStripMenuItem
        '
        Me.hideColumnsToolStripMenuItem.Name = "hideColumnsToolStripMenuItem"
        Me.hideColumnsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.hideColumnsToolStripMenuItem.Text = "Hide"
        '
        'unhideColumnsToolStripMenuItem
        '
        Me.unhideColumnsToolStripMenuItem.Name = "unhideColumnsToolStripMenuItem"
        Me.unhideColumnsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.unhideColumnsToolStripMenuItem.Text = "Unhide"
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(181, 6)
        '
        'columnFilterToolStripMenuItem
        '
        Me.columnFilterToolStripMenuItem.Name = "columnFilterToolStripMenuItem"
        Me.columnFilterToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.columnFilterToolStripMenuItem.Text = "Filter..."
        '
        'clearColumnFilterToolStripMenuItem
        '
        Me.clearColumnFilterToolStripMenuItem.Name = "clearColumnFilterToolStripMenuItem"
        Me.clearColumnFilterToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.clearColumnFilterToolStripMenuItem.Text = "Clear Filters"
        '
        'toolStripMenuItem35
        '
        Me.toolStripMenuItem35.Name = "toolStripMenuItem35"
        Me.toolStripMenuItem35.Size = New System.Drawing.Size(181, 6)
        '
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutRangeToolStripMenuItem, Me.copyRangeToolStripMenuItem, Me.pasteRangeToolStripMenuItem, Me.ToolStripSeparator4, Me.mergeRangeToolStripMenuItem, Me.unmergeRangeToolStripMenuItem})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(124, 120)
        '
        'cutRangeToolStripMenuItem
        '
        Me.cutRangeToolStripMenuItem.Name = "cutRangeToolStripMenuItem"
        Me.cutRangeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.cutRangeToolStripMenuItem.Text = "Cut"
        '
        'copyRangeToolStripMenuItem
        '
        Me.copyRangeToolStripMenuItem.Name = "copyRangeToolStripMenuItem"
        Me.copyRangeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.copyRangeToolStripMenuItem.Text = "Copy"
        '
        'pasteRangeToolStripMenuItem
        '
        Me.pasteRangeToolStripMenuItem.Name = "pasteRangeToolStripMenuItem"
        Me.pasteRangeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.pasteRangeToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(120, 6)
        '
        'mergeRangeToolStripMenuItem
        '
        Me.mergeRangeToolStripMenuItem.Name = "mergeRangeToolStripMenuItem"
        Me.mergeRangeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.mergeRangeToolStripMenuItem.Text = "Merge"
        '
        'unmergeRangeToolStripMenuItem
        '
        Me.unmergeRangeToolStripMenuItem.Name = "unmergeRangeToolStripMenuItem"
        Me.unmergeRangeToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.unmergeRangeToolStripMenuItem.Text = "Unmerge"
        '
        'leadHeaderContextMenuStrip
        '
        Me.leadHeaderContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.resetAllPageBreaksToolStripMenuItem1})
        Me.leadHeaderContextMenuStrip.Name = "leadHeaderContextMenuStrip"
        Me.leadHeaderContextMenuStrip.Size = New System.Drawing.Size(186, 26)
        '
        'resetAllPageBreaksToolStripMenuItem1
        '
        Me.resetAllPageBreaksToolStripMenuItem1.Name = "resetAllPageBreaksToolStripMenuItem1"
        Me.resetAllPageBreaksToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.resetAllPageBreaksToolStripMenuItem1.Text = "Reset All Page Breaks"
        '
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInsertRow, Me.mnuDeleteRows, Me.toolStripMenuItem4, Me.hideRowsToolStripMenuItem, Me.unhideRowsToolStripMenuItem, Me.toolStripMenuItem20, Me.toolStripMenuItem33})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(139, 110)
        '
        'mnuInsertRow
        '
        Me.mnuInsertRow.Name = "mnuInsertRow"
        Me.mnuInsertRow.Size = New System.Drawing.Size(138, 22)
        Me.mnuInsertRow.Text = "Insert &Rows"
        '
        'mnuDeleteRows
        '
        Me.mnuDeleteRows.Name = "mnuDeleteRows"
        Me.mnuDeleteRows.Size = New System.Drawing.Size(138, 22)
        Me.mnuDeleteRows.Text = "&Delete Rows"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(135, 6)
        '
        'hideRowsToolStripMenuItem
        '
        Me.hideRowsToolStripMenuItem.Name = "hideRowsToolStripMenuItem"
        Me.hideRowsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.hideRowsToolStripMenuItem.Text = "&Hide"
        '
        'unhideRowsToolStripMenuItem
        '
        Me.unhideRowsToolStripMenuItem.Name = "unhideRowsToolStripMenuItem"
        Me.unhideRowsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.unhideRowsToolStripMenuItem.Text = "&Unhide"
        '
        'toolStripMenuItem20
        '
        Me.toolStripMenuItem20.Name = "toolStripMenuItem20"
        Me.toolStripMenuItem20.Size = New System.Drawing.Size(135, 6)
        '
        'toolStripMenuItem33
        '
        Me.toolStripMenuItem33.Name = "toolStripMenuItem33"
        Me.toolStripMenuItem33.Size = New System.Drawing.Size(135, 6)
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertSheet, Me.deleteSheet, Me.renameSheet, Me.MoveOrCopySheet, Me.HideSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(150, 114)
        '
        'insertSheet
        '
        Me.insertSheet.Name = "insertSheet"
        Me.insertSheet.Size = New System.Drawing.Size(149, 22)
        Me.insertSheet.Text = "Insert"
        '
        'deleteSheet
        '
        Me.deleteSheet.Name = "deleteSheet"
        Me.deleteSheet.Size = New System.Drawing.Size(149, 22)
        Me.deleteSheet.Text = "Delete"
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(149, 22)
        Me.renameSheet.Text = "Rename"
        '
        'MoveOrCopySheet
        '
        Me.MoveOrCopySheet.Name = "MoveOrCopySheet"
        Me.MoveOrCopySheet.Size = New System.Drawing.Size(149, 22)
        Me.MoveOrCopySheet.Text = "Move or Copy"
        '
        'HideSheet
        '
        Me.HideSheet.Name = "HideSheet"
        Me.HideSheet.Size = New System.Drawing.Size(149, 22)
        Me.HideSheet.Text = "Hide"
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
        Me.leadHeaderContextMenuStrip.ResumeLayout(False)
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.statusColumnMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents grdData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblNoData As Label
    Private WithEvents columnContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertCol As ToolStripMenuItem
    Private WithEvents mnuDeleteCol As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Private WithEvents hideColumnsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents unhideColumnsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem21 As ToolStripSeparator
    Private WithEvents columnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents clearColumnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem35 As ToolStripSeparator
    Private WithEvents cellContextMenuStrip As ContextMenuStrip
    Private WithEvents cutRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents copyRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pasteRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripSeparator4 As ToolStripSeparator
    Private WithEvents mergeRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents unmergeRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents leadHeaderContextMenuStrip As ContextMenuStrip
    Private WithEvents resetAllPageBreaksToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents rowContextMenuStrip As ContextMenuStrip
    Private WithEvents mnuInsertRow As ToolStripMenuItem
    Private WithEvents mnuDeleteRows As ToolStripMenuItem
    Private WithEvents toolStripMenuItem4 As ToolStripSeparator
    Private WithEvents hideRowsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents unhideRowsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem20 As ToolStripSeparator
    Private WithEvents toolStripMenuItem33 As ToolStripSeparator
    Friend WithEvents statusColumnMenu As ContextMenuStrip
    Friend WithEvents insertSheet As ToolStripMenuItem
    Friend WithEvents deleteSheet As ToolStripMenuItem
    Friend WithEvents renameSheet As ToolStripMenuItem
    Friend WithEvents mnuColumnRename As ToolStripMenuItem
    Friend WithEvents mnuConvertText As ToolStripMenuItem
    Friend WithEvents mnuConvertVariate As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuConvertToFactor As ToolStripMenuItem
    Friend WithEvents MoveOrCopySheet As ToolStripMenuItem
    Friend WithEvents HideSheet As ToolStripMenuItem
End Class
