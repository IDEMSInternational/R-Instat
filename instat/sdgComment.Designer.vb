<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgComment
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
        Me.ucrBaseSdg = New instat.ucrButtonsSubdialogue()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ucrBaseSdg
        '
        Me.ucrBaseSdg.Location = New System.Drawing.Point(132, 118)
        Me.ucrBaseSdg.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBaseSdg.Name = "ucrBaseSdg"
        Me.ucrBaseSdg.Size = New System.Drawing.Size(213, 46)
        Me.ucrBaseSdg.TabIndex = 0
        '
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(2, 3)
        Me.txtComment.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(472, 107)
        Me.txtComment.TabIndex = 2
        '
        'sdgComment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 169)
        Me.Controls.Add(Me.txtComment)
        Me.Controls.Add(Me.ucrBaseSdg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgComment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSdg As ucrButtonsSubdialogue
    Friend WithEvents txtComment As TextBox
End Class
