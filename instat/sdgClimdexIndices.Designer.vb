<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgClimdexIndices
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
        Me.ucrButtonsClimdexIndices = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrButtonsClimdexIndices
        '
        Me.ucrButtonsClimdexIndices.Location = New System.Drawing.Point(66, 219)
        Me.ucrButtonsClimdexIndices.Name = "ucrButtonsClimdexIndices"
        Me.ucrButtonsClimdexIndices.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsClimdexIndices.TabIndex = 0
        '
        'sdgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ucrButtonsClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgClimdexIndices"
        Me.Tag = "Climdex_Indices"
        Me.Text = "Climdex Indices"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsClimdexIndices As ucrButtonsSubdialogue
End Class
