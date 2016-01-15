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
        Me.toolStripMenuItem27 = New System.Windows.Forms.ToolStripSeparator()
        Me.insertRowPageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.removeRowPageBreakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem33 = New System.Windows.Forms.ToolStripSeparator()
        Me.rowPropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.rowContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.BackColor = System.Drawing.Color.White
        Me.grdData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdData.LeadHeaderContextMenuStrip = Nothing
        Me.grdData.Location = New System.Drawing.Point(0, 0)
        Me.grdData.Name = "grdData"
        Me.grdData.RowHeaderContextMenuStrip = Me.rowContextMenuStrip
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
        'rowContextMenuStrip
        '
        Me.rowContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.insertRowToolStripMenuItem, Me.ToolStripMenuItem3, Me.toolStripMenuItem4, Me.resetToDefaultHeightToolStripMenuItem, Me.rowHeightToolStripMenuItem, Me.hideRowsToolStripMenuItem, Me.unhideRowsToolStripMenuItem, Me.toolStripMenuItem20, Me.groupRowsToolStripMenuItem1, Me.ungroupRowsToolStripMenuItem1, Me.ungroupAllRowsToolStripMenuItem, Me.toolStripMenuItem27, Me.insertRowPageBreakToolStripMenuItem, Me.removeRowPageBreakToolStripMenuItem, Me.toolStripMenuItem33, Me.rowPropertiesToolStripMenuItem})
        Me.rowContextMenuStrip.Name = "columnContextMenuStrip"
        Me.rowContextMenuStrip.Size = New System.Drawing.Size(197, 292)
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
        'toolStripMenuItem27
        '
        Me.toolStripMenuItem27.Name = "toolStripMenuItem27"
        Me.toolStripMenuItem27.Size = New System.Drawing.Size(193, 6)
        '
        'insertRowPageBreakToolStripMenuItem
        '
        Me.insertRowPageBreakToolStripMenuItem.Name = "insertRowPageBreakToolStripMenuItem"
        Me.insertRowPageBreakToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.insertRowPageBreakToolStripMenuItem.Text = "Insert Page Break"
        '
        'removeRowPageBreakToolStripMenuItem
        '
        Me.removeRowPageBreakToolStripMenuItem.Name = "removeRowPageBreakToolStripMenuItem"
        Me.removeRowPageBreakToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.removeRowPageBreakToolStripMenuItem.Text = "Remove Page Break"
        '
        'toolStripMenuItem33
        '
        Me.toolStripMenuItem33.Name = "toolStripMenuItem33"
        Me.toolStripMenuItem33.Size = New System.Drawing.Size(193, 6)
        '
        'rowPropertiesToolStripMenuItem
        '
        Me.rowPropertiesToolStripMenuItem.Name = "rowPropertiesToolStripMenuItem"
        Me.rowPropertiesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.rowPropertiesToolStripMenuItem.Text = "Properties..."
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
        Me.rowContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents grdData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblNoData As Label
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
    Private WithEvents toolStripMenuItem27 As ToolStripSeparator
    Private WithEvents insertRowPageBreakToolStripMenuItem As ToolStripMenuItem
    Private WithEvents removeRowPageBreakToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem33 As ToolStripSeparator
    Private WithEvents rowPropertiesToolStripMenuItem As ToolStripMenuItem
End Class
