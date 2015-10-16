<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScript
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
        Me.editor = New unvell.ReoScript.Editor.ReoScriptEditorControl()
        Me.SuspendLayout()
        '
        'editor
        '
        Me.editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.editor.Location = New System.Drawing.Point(0, 0)
        Me.editor.Name = "editor"
        Me.editor.Size = New System.Drawing.Size(544, 601)
        Me.editor.TabIndex = 0
        '
        'frmScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 601)
        Me.Controls.Add(Me.editor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimizeBox = False
        Me.Name = "frmScript"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Command Window"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents editor As unvell.ReoScript.Editor.ReoScriptEditorControl
End Class
