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
        Me.ucrBaseSummmaryCalcSubdialog = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrBaseSummmaryCalcSubdialog
        '
        Me.ucrBaseSummmaryCalcSubdialog.Location = New System.Drawing.Point(13, 219)
        Me.ucrBaseSummmaryCalcSubdialog.Name = "ucrBaseSummmaryCalcSubdialog"
        Me.ucrBaseSummmaryCalcSubdialog.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseSummmaryCalcSubdialog.TabIndex = 0
        '
        'sdgCalculationsSummmary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 261)
        Me.Controls.Add(Me.ucrBaseSummmaryCalcSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgCalculationsSummmary"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Summary Calculations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseSummmaryCalcSubdialog As ucrButtonsSubdialogue
End Class
