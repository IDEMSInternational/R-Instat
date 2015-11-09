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
        Me.grid = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'grid
        '
        Me.grid.BackColor = System.Drawing.Color.White
        Me.grid.ColumnHeaderContextMenuStrip = Nothing
        Me.grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid.LeadHeaderContextMenuStrip = Nothing
        Me.grid.Location = New System.Drawing.Point(0, 0)
        Me.grid.Name = "grid"
        Me.grid.RowHeaderContextMenuStrip = Nothing
        Me.grid.Script = Nothing
        Me.grid.SheetTabContextMenuStrip = Nothing
        Me.grid.SheetTabControlNewButtonVisible = True
        Me.grid.SheetTabControlWidth = 60
        Me.grid.SheetTabNewButtonVisible = True
        Me.grid.Size = New System.Drawing.Size(410, 261)
        Me.grid.TabIndex = 0
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 261)
        Me.Controls.Add(Me.grid)
        Me.Name = "frmEditor"
        Me.ShowIcon = False
        Me.Tag = "Data_View"
        Me.Text = "Data View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grid As unvell.ReoGrid.ReoGridControl
End Class
