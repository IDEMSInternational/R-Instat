<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDescribeDisplay
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
        Me.UcrButtonsSubdialogue2 = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue2
        '
        Me.UcrButtonsSubdialogue2.Location = New System.Drawing.Point(66, 219)
        Me.UcrButtonsSubdialogue2.Name = "UcrButtonsSubdialogue2"
        Me.UcrButtonsSubdialogue2.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue2.TabIndex = 2
        '
        'sdgDescribeDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.UcrButtonsSubdialogue2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgDescribeDisplay"
        Me.Text = "sdgDescribeDisplay"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue2 As ucrButtonsSubdialogue
End Class
