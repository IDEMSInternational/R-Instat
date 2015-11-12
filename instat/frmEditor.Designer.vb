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
        Me.gridColumns = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'gridColumns
        '
        Me.gridColumns.BackColor = System.Drawing.Color.White
        Me.gridColumns.ColumnHeaderContextMenuStrip = Nothing
        Me.gridColumns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridColumns.LeadHeaderContextMenuStrip = Nothing
        Me.gridColumns.Location = New System.Drawing.Point(0, 0)
        Me.gridColumns.Name = "gridColumns"
        Me.gridColumns.RowHeaderContextMenuStrip = Nothing
        Me.gridColumns.Script = Nothing
        Me.gridColumns.SheetTabContextMenuStrip = Nothing
        Me.gridColumns.SheetTabControlNewButtonVisible = True
        Me.gridColumns.SheetTabControlWidth = 60
        Me.gridColumns.SheetTabNewButtonVisible = True
        Me.gridColumns.Size = New System.Drawing.Size(410, 261)
        Me.gridColumns.TabIndex = 0
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 261)
        Me.Controls.Add(Me.gridColumns)
        Me.Name = "frmEditor"
        Me.ShowIcon = False
        Me.Tag = "Data_View"
        Me.Text = "Data View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridColumns As unvell.ReoGrid.ReoGridControl
End Class
