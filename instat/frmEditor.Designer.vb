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
        Me.lblNoData = New System.Windows.Forms.Label()
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
        Me.toolStripMenuItem26 = New System.Windows.Forms.ToolStripSeparator()
        Me.insertColPageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.removeColPageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem32 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.columnContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.BackColor = System.Drawing.Color.White
        Me.grdData.ColumnHeaderContextMenuStrip = Me.columnContextMenuStrip
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.LeadHeaderContextMenuStrip = Nothing
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Nothing
        Me.grdData.Script = Nothing
        Me.grdData.SheetTabContextMenuStrip = Nothing
        Me.grdData.SheetTabControlNewButtonVisible = True
        Me.grdData.SheetTabControlWidth = 60
        Me.grdData.SheetTabNewButtonVisible = True
        Me.grdData.Size = New System.Drawing.Size(410, 261)
        Me.grdData.TabIndex = 0
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
        'columnContextMenuStrip
        '
        Me.columnContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertColToolStripMenuItem, Me.deleteColumnToolStripMenuItem, Me.toolStripMenuItem2, Me.resetToDefaultWidthToolStripMenuItem, Me.columnWidthToolStripMenuItem, Me.hideColumnsToolStripMenuItem, Me.unhideColumnsToolStripMenuItem, Me.toolStripMenuItem21, Me.columnFilterToolStripMenuItem, Me.clearColumnFilterToolStripMenuItem, Me.toolStripMenuItem35, Me.groupColumnsToolStripMenuItem1, Me.ungroupColumnsToolStripMenuItem1, Me.ungroupAllColumnsToolStripMenuItem, Me.toolStripMenuItem26, Me.insertColPageBreakToolStripMenuItem, Me.removeColPageBreakToolStripMenuItem, Me.toolStripMenuItem32, Me.ToolStripMenuItem1})
        Me.columnContextMenuStrip.Name = "columnContextMenuStrip"
        Me.columnContextMenuStrip.Size = New System.Drawing.Size(193, 342)
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
        'toolStripMenuItem26
        '
        Me.toolStripMenuItem26.Name = "toolStripMenuItem26"
        Me.toolStripMenuItem26.Size = New System.Drawing.Size(189, 6)
        '
        'insertColPageBreakToolStripMenuItem
        '
        Me.insertColPageBreakToolStripMenuItem.Name = "insertColPageBreakToolStripMenuItem"
        Me.insertColPageBreakToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.insertColPageBreakToolStripMenuItem.Text = "Insert Page Break"
        '
        'removeColPageBreakToolStripMenuItem
        '
        Me.removeColPageBreakToolStripMenuItem.Name = "removeColPageBreakToolStripMenuItem"
        Me.removeColPageBreakToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.removeColPageBreakToolStripMenuItem.Text = "Remove Page Break"
        '
        'toolStripMenuItem32
        '
        Me.toolStripMenuItem32.Name = "toolStripMenuItem32"
        Me.toolStripMenuItem32.Size = New System.Drawing.Size(189, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(192, 22)
        Me.ToolStripMenuItem1.Text = "Properties..."
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
    Private WithEvents toolStripMenuItem26 As ToolStripSeparator
    Private WithEvents insertColPageBreakToolStripMenuItem As ToolStripMenuItem
    Private WithEvents removeColPageBreakToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem32 As ToolStripSeparator
    Private WithEvents ToolStripMenuItem1 As ToolStripMenuItem
End Class
