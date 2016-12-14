<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgCalculationsSummmary
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
        Me.UcrButtonsSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'UcrButtonsSubdialogue1
        '
        Me.UcrButtonsSubdialogue1.Location = New System.Drawing.Point(13, 219)
        Me.UcrButtonsSubdialogue1.Name = "UcrButtonsSubdialogue1"
        Me.UcrButtonsSubdialogue1.Size = New System.Drawing.Size(142, 30)
        Me.UcrButtonsSubdialogue1.TabIndex = 0
        '
        'sdgCalculationsSummmary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 261)
        Me.Controls.Add(Me.UcrButtonsSubdialogue1)
        Me.Name = "sdgCalculationsSummmary"
        Me.Text = "Summary Calculations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrButtonsSubdialogue1 As ucrButtonsSubdialogue
End Class
