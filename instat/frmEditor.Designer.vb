<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grdData = New unvell.ReoGrid.ReoGridControl()
        Me.columnContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.insertColToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.resetToDefaultWidthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnWidthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hideColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.columnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.clearColumnFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem35 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupColumnsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ungroupColumnsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ungroupAllColumnsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.insertRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.resetToDefaultHeightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowHeightToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hideRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.unhideRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem20 = New System.Windows.Forms.ToolStripSeparator()
        Me.groupRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ungroupRowsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ungroupAllRowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem33 = New System.Windows.Forms.ToolStripSeparator()
        Me.statusColumnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.insertSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.deleteSheet = New System.Windows.Forms.ToolStripMenuItem()
        Me.renameSheet = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grdData.SheetTabControlNewButtonVisible = True
        Me.grdData.SheetTabControlWidth = 200
        Me.grdData.SheetTabNewButtonVisible = True
        Me.grdData.Size = New System.Drawing.Size(410, 261)
        Me.grdData.TabIndex = 0
        '
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertColToolStripMenuItem, Me.deleteColumnToolStripMenuItem, Me.toolStripMenuItem2, Me.resetToDefaultWidthToolStripMenuItem, Me.columnWidthToolStripMenuItem, Me.hideColumnsToolStripMenuItem, Me.unhideColumnsToolStripMenuItem, Me.toolStripMenuItem21, Me.columnFilterToolStripMenuItem, Me.clearColumnFilterToolStripMenuItem, Me.toolStripMenuItem35, Me.groupColumnsToolStripMenuItem1, Me.ungroupColumnsToolStripMenuItem1, Me.ungroupAllColumnsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(193, 286)
        '
        'insertColToolStripMenuItem
        '
        Me.insertColToolStripMenuItem.Name = "insertColToolStripMenuItem"
        Me.insertColToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.insertColToolStripMenuItem.Text = "Insert &Columns"
        '
        'deleteColumnToolStripMenuItem
        '
        Me.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem"
        Me.deleteColumnToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.deleteColumnToolStripMenuItem.Text = "Delete Columns"
        '
        'toolStripMenuItem2
        '
        Me.toolStripMenuItem2.Name = "toolStripMenuItem2"
        Me.toolStripMenuItem2.Size = New System.Drawing.Size(189, 6)
        '
        'resetToDefaultWidthToolStripMenuItem
        '
        Me.resetToDefaultWidthToolStripMenuItem.Name = "resetToDefaultWidthToolStripMenuItem"
        Me.resetToDefaultWidthToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.resetToDefaultWidthToolStripMenuItem.Text = "Reset to Default Width"
        '
        'columnWidthToolStripMenuItem
        '
        Me.columnWidthToolStripMenuItem.Enabled = False
        Me.columnWidthToolStripMenuItem.Name = "columnWidthToolStripMenuItem"
        Me.columnWidthToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.columnWidthToolStripMenuItem.Text = "Column &Width..."
        '
        'hideColumnsToolStripMenuItem
        '
        Me.hideColumnsToolStripMenuItem.Name = "hideColumnsToolStripMenuItem"
        Me.hideColumnsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.hideColumnsToolStripMenuItem.Text = "Hide"
        '
        'unhideColumnsToolStripMenuItem
        '
        Me.unhideColumnsToolStripMenuItem.Name = "unhideColumnsToolStripMenuItem"
        Me.unhideColumnsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.unhideColumnsToolStripMenuItem.Text = "Unhide"
        '
        'toolStripMenuItem21
        '
        Me.toolStripMenuItem21.Name = "toolStripMenuItem21"
        Me.toolStripMenuItem21.Size = New System.Drawing.Size(189, 6)
        '
        'columnFilterToolStripMenuItem
        '
        Me.columnFilterToolStripMenuItem.Name = "columnFilterToolStripMenuItem"
        Me.columnFilterToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.columnFilterToolStripMenuItem.Text = "Filter"
        '
        'clearColumnFilterToolStripMenuItem
        '
        Me.clearColumnFilterToolStripMenuItem.Name = "clearColumnFilterToolStripMenuItem"
        Me.clearColumnFilterToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.clearColumnFilterToolStripMenuItem.Text = "Clear Filter"
        '
        'toolStripMenuItem35
        '
        Me.toolStripMenuItem35.Name = "toolStripMenuItem35"
        Me.toolStripMenuItem35.Size = New System.Drawing.Size(189, 6)
        '
        'groupColumnsToolStripMenuItem1
        '
        Me.groupColumnsToolStripMenuItem1.Name = "groupColumnsToolStripMenuItem1"
        Me.groupColumnsToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.groupColumnsToolStripMenuItem1.Text = "Group"
        '
        'ungroupColumnsToolStripMenuItem1
        '
        Me.ungroupColumnsToolStripMenuItem1.Name = "ungroupColumnsToolStripMenuItem1"
        Me.ungroupColumnsToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ungroupColumnsToolStripMenuItem1.Text = "Ungroup"
        '
        'ungroupAllColumnsToolStripMenuItem
        '
        Me.ungroupAllColumnsToolStripMenuItem.Name = "ungroupAllColumnsToolStripMenuItem"
        Me.ungroupAllColumnsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ungroupAllColumnsToolStripMenuItem.Text = "Ungroup All"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Enabled = False
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripMenuItem1.Text = "Properties..."
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
        Me.cutRangeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.cutRangeToolStripMenuItem.Text = "Cut"
        '
        'copyRangeToolStripMenuItem
        '
        Me.copyRangeToolStripMenuItem.Name = "copyRangeToolStripMenuItem"
        Me.copyRangeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.copyRangeToolStripMenuItem.Text = "Copy"
        '
        'pasteRangeToolStripMenuItem
        '
        Me.pasteRangeToolStripMenuItem.Name = "pasteRangeToolStripMenuItem"
        Me.pasteRangeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.pasteRangeToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(198, 6)
        '
        'mergeRangeToolStripMenuItem
        '
        Me.mergeRangeToolStripMenuItem.Name = "mergeRangeToolStripMenuItem"
        Me.mergeRangeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.mergeRangeToolStripMenuItem.Text = "Merge"
        '
        'unmergeRangeToolStripMenuItem
        '
        Me.unmergeRangeToolStripMenuItem.Name = "unmergeRangeToolStripMenuItem"
        Me.unmergeRangeToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
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
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertRowToolStripMenuItem, Me.ToolStripMenuItem3, Me.toolStripMenuItem4, Me.resetToDefaultHeightToolStripMenuItem, Me.rowHeightToolStripMenuItem, Me.hideRowsToolStripMenuItem, Me.unhideRowsToolStripMenuItem, Me.toolStripMenuItem20, Me.groupRowsToolStripMenuItem1, Me.ungroupRowsToolStripMenuItem1, Me.ungroupAllRowsToolStripMenuItem, Me.toolStripMenuItem33})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(197, 220)
        '
        'insertRowToolStripMenuItem
        '
        Me.insertRowToolStripMenuItem.Name = "insertRowToolStripMenuItem"
        Me.insertRowToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.insertRowToolStripMenuItem.Text = "Insert &Rows"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(196, 22)
        Me.ToolStripMenuItem3.Text = "&Delete Rows"
        '
        'toolStripMenuItem4
        '
        Me.toolStripMenuItem4.Name = "toolStripMenuItem4"
        Me.toolStripMenuItem4.Size = New System.Drawing.Size(193, 6)
        '
        'resetToDefaultHeightToolStripMenuItem
        '
        Me.resetToDefaultHeightToolStripMenuItem.Name = "resetToDefaultHeightToolStripMenuItem"
        Me.resetToDefaultHeightToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.resetToDefaultHeightToolStripMenuItem.Text = "Reset to Default Height"
        '
        'rowHeightToolStripMenuItem
        '
        Me.rowHeightToolStripMenuItem.Enabled = False
        Me.rowHeightToolStripMenuItem.Name = "rowHeightToolStripMenuItem"
        Me.rowHeightToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.rowHeightToolStripMenuItem.Text = "Row &Height..."
        '
        'hideRowsToolStripMenuItem
        '
        Me.hideRowsToolStripMenuItem.Name = "hideRowsToolStripMenuItem"
        Me.hideRowsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.hideRowsToolStripMenuItem.Text = "&Hide"
        '
        'unhideRowsToolStripMenuItem
        '
        Me.unhideRowsToolStripMenuItem.Name = "unhideRowsToolStripMenuItem"
        Me.unhideRowsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.unhideRowsToolStripMenuItem.Text = "&Unhide"
        '
        'toolStripMenuItem20
        '
        Me.toolStripMenuItem20.Name = "toolStripMenuItem20"
        Me.toolStripMenuItem20.Size = New System.Drawing.Size(193, 6)
        '
        'groupRowsToolStripMenuItem1
        '
        Me.groupRowsToolStripMenuItem1.Name = "groupRowsToolStripMenuItem1"
        Me.groupRowsToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.groupRowsToolStripMenuItem1.Text = "&Group"
        '
        'ungroupRowsToolStripMenuItem1
        '
        Me.ungroupRowsToolStripMenuItem1.Name = "ungroupRowsToolStripMenuItem1"
        Me.ungroupRowsToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.ungroupRowsToolStripMenuItem1.Text = "Ungroup"
        '
        'ungroupAllRowsToolStripMenuItem
        '
        Me.ungroupAllRowsToolStripMenuItem.Name = "ungroupAllRowsToolStripMenuItem"
        Me.ungroupAllRowsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ungroupAllRowsToolStripMenuItem.Text = "Ungroup All"
        '
        'toolStripMenuItem33
        '
        Me.toolStripMenuItem33.Name = "toolStripMenuItem33"
        Me.toolStripMenuItem33.Size = New System.Drawing.Size(193, 6)
        '
        'statusColumnMenu
        '
        Me.statusColumnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertSheet, Me.deleteSheet, Me.renameSheet})
        Me.statusColumnMenu.Name = "statusColumnMenu"
        Me.statusColumnMenu.Size = New System.Drawing.Size(118, 70)
        '
        'insertSheet
        '
        Me.insertSheet.Name = "insertSheet"
        Me.insertSheet.Size = New System.Drawing.Size(117, 22)
        Me.insertSheet.Text = "Insert"
        '
        'deleteSheet
        '
        Me.deleteSheet.Name = "deleteSheet"
        Me.deleteSheet.Size = New System.Drawing.Size(117, 22)
        Me.deleteSheet.Text = "Delete"
        '
        'renameSheet
        '
        Me.renameSheet.Name = "renameSheet"
        Me.renameSheet.Size = New System.Drawing.Size(117, 22)
        Me.renameSheet.Text = "Rename"
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
    Private WithEvents insertColToolStripMenuItem As ToolStripMenuItem
    Private WithEvents deleteColumnToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem2 As ToolStripSeparator
    Private WithEvents resetToDefaultWidthToolStripMenuItem As ToolStripMenuItem
    Private WithEvents columnWidthToolStripMenuItem As ToolStripMenuItem
    Private WithEvents hideColumnsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents unhideColumnsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem21 As ToolStripSeparator
    Private WithEvents columnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents clearColumnFilterToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem35 As ToolStripSeparator
    Private WithEvents groupColumnsToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents ungroupColumnsToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents ungroupAllColumnsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem1 As ToolStripMenuItem
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
    Private WithEvents insertRowToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Private WithEvents toolStripMenuItem4 As ToolStripSeparator
    Private WithEvents resetToDefaultHeightToolStripMenuItem As ToolStripMenuItem
    Private WithEvents rowHeightToolStripMenuItem As ToolStripMenuItem
    Private WithEvents hideRowsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents unhideRowsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem20 As ToolStripSeparator
    Private WithEvents groupRowsToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents ungroupRowsToolStripMenuItem1 As ToolStripMenuItem
    Private WithEvents ungroupAllRowsToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem33 As ToolStripSeparator
    Friend WithEvents statusColumnMenu As ContextMenuStrip
    Friend WithEvents insertSheet As ToolStripMenuItem
    Friend WithEvents deleteSheet As ToolStripMenuItem
    Friend WithEvents renameSheet As ToolStripMenuItem
End Class
