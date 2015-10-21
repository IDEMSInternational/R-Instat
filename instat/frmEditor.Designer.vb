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
        Me.ReoGridControl1 = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'ReoGridControl1
        '
        Me.ReoGridControl1.BackColor = System.Drawing.Color.White
        Me.ReoGridControl1.ColumnHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReoGridControl1.LeadHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Location = New System.Drawing.Point(0, 0)
        Me.ReoGridControl1.Name = "ReoGridControl1"
        Me.ReoGridControl1.RowHeaderContextMenuStrip = Nothing
        Me.ReoGridControl1.Script = Nothing
        Me.ReoGridControl1.SheetTabContextMenuStrip = Nothing
        Me.ReoGridControl1.SheetTabControlNewButtonVisible = True
        Me.ReoGridControl1.SheetTabControlWidth = 60
        Me.ReoGridControl1.SheetTabNewButtonVisible = True
        Me.ReoGridControl1.Size = New System.Drawing.Size(284, 261)
        Me.ReoGridControl1.TabIndex = 0
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReoGridControl1)
        Me.Name = "frmEditor"
        Me.Text = "Editor Window"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReoGridControl1 As unvell.ReoGrid.ReoGridControl
End Class
