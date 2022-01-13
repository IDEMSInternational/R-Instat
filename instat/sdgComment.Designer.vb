<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgComment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtComment
        '
        Me.txtComment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtComment.Location = New System.Drawing.Point(0, 0)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(315, 78)
        Me.txtComment.TabIndex = 1
        '
        'sdgComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(315, 78)
        Me.Controls.Add(Me.txtComment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "sdgComment"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComment As TextBox
End Class
