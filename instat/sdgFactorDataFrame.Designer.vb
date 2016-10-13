<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgFactorDataFrame
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
        Me.ucrBaseFactorSubdlg = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrBaseFactorSubdlg
        '
        Me.ucrBaseFactorSubdlg.Location = New System.Drawing.Point(12, 219)
        Me.ucrBaseFactorSubdlg.Name = "ucrBaseFactorSubdlg"
        Me.ucrBaseFactorSubdlg.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseFactorSubdlg.TabIndex = 0
        '
        'sdgFactorDataFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ucrBaseFactorSubdlg)
        Me.Name = "sdgFactorDataFrame"
        Me.Text = "sdgFactorDataFrame"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseFactorSubdlg As ucrButtonsSubdialogue
End Class
