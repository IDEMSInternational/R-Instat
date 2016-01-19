<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCommand
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
        Me.txtcommand = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'txtcommand
        '
        Me.txtcommand.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcommand.Location = New System.Drawing.Point(0, 0)
        Me.txtcommand.Name = "txtcommand"
        Me.txtcommand.Size = New System.Drawing.Size(631, 261)
        Me.txtcommand.TabIndex = 0
        Me.txtcommand.Text = ""
        '
        'frmCommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 261)
        Me.Controls.Add(Me.txtcommand)
        Me.Name = "frmCommand"
        Me.ShowIcon = False
        Me.Tag = "Output_Window"
        Me.Text = "Output Window"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtcommand As RichTextBox
End Class
