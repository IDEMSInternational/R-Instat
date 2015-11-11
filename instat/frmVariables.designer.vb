<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVariables
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
        Me.gridVariables = New unvell.ReoGrid.ReoGridControl()
        Me.SuspendLayout()
        '
        'gridVariables
        '
        Me.gridVariables.BackColor = System.Drawing.Color.White
        Me.gridVariables.ColumnHeaderContextMenuStrip = Nothing
        Me.gridVariables.Dock = System.Windows.Forms.DockStyle.Left
        Me.gridVariables.LeadHeaderContextMenuStrip = Nothing
        Me.gridVariables.Location = New System.Drawing.Point(0, 0)
        Me.gridVariables.Name = "gridVariables"
        Me.gridVariables.RowHeaderContextMenuStrip = Nothing
        Me.gridVariables.Script = Nothing
        Me.gridVariables.SheetTabContextMenuStrip = Nothing
        Me.gridVariables.SheetTabControlNewButtonVisible = False
        Me.gridVariables.SheetTabControlWidth = 100
        Me.gridVariables.SheetTabNewButtonVisible = False
        Me.gridVariables.Size = New System.Drawing.Size(268, 261)
        Me.gridVariables.TabIndex = 2
        Me.gridVariables.Text = "Variables"
        '
        'frmVariables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.gridVariables)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmVariables"
        Me.Text = "frmVariables"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridVariables As unvell.ReoGrid.ReoGridControl
End Class
