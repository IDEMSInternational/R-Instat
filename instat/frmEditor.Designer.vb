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
        Me.cellContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cutRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pasteRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mergeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.unmergeRangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.changeCellsTypeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.formatCellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cellContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdData
        '
        Me.grdData.BackColor = System.Drawing.Color.White
        Me.grdData.ColumnHeaderContextMenuStrip = Nothing
        Me.grdData.ContextMenuStrip = Me.cellContextMenuStrip
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
        'cellContextMenuStrip
        '
        Me.cellContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cutRangeToolStripMenuItem, Me.copyRangeToolStripMenuItem, Me.pasteRangeToolStripMenuItem, Me.ToolStripSeparator4, Me.mergeRangeToolStripMenuItem, Me.unmergeRangeToolStripMenuItem, Me.toolStripMenuItem11, Me.changeCellsTypeToolStripMenuItem2, Me.toolStripMenuItem6, Me.formatCellToolStripMenuItem})
        Me.cellContextMenuStrip.Name = "cellContextMenuStrip"
        Me.cellContextMenuStrip.Size = New System.Drawing.Size(202, 198)
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
        'toolStripMenuItem11
        '
        Me.toolStripMenuItem11.Name = "toolStripMenuItem11"
        Me.toolStripMenuItem11.Size = New System.Drawing.Size(198, 6)
        '
        'changeCellsTypeToolStripMenuItem2
        '
        Me.changeCellsTypeToolStripMenuItem2.Name = "changeCellsTypeToolStripMenuItem2"
        Me.changeCellsTypeToolStripMenuItem2.Size = New System.Drawing.Size(201, 22)
        Me.changeCellsTypeToolStripMenuItem2.Text = "Change Cell Type"
        '
        'toolStripMenuItem6
        '
        Me.toolStripMenuItem6.Name = "toolStripMenuItem6"
        Me.toolStripMenuItem6.Size = New System.Drawing.Size(198, 6)
        '
        'formatCellToolStripMenuItem
        '
        Me.formatCellToolStripMenuItem.Name = "formatCellToolStripMenuItem"
        Me.formatCellToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys)
        Me.formatCellToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.formatCellToolStripMenuItem.Text = "&Format Cell..."
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
        Me.cellContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents grdData As unvell.ReoGrid.ReoGridControl
    Friend WithEvents lblNoData As Label
    Private WithEvents cellContextMenuStrip As ContextMenuStrip
    Private WithEvents cutRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents copyRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents pasteRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents ToolStripSeparator4 As ToolStripSeparator
    Private WithEvents mergeRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents unmergeRangeToolStripMenuItem As ToolStripMenuItem
    Private WithEvents toolStripMenuItem11 As ToolStripSeparator
    Private WithEvents changeCellsTypeToolStripMenuItem2 As ToolStripMenuItem
    Private WithEvents toolStripMenuItem6 As ToolStripSeparator
    Private WithEvents formatCellToolStripMenuItem As ToolStripMenuItem
End Class
