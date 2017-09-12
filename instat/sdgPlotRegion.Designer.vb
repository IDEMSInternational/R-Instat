<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgPlotRegion
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
        Me.ucrButtonsSdgPlotRegion = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrButtonsSdgPlotRegion
        '
        Me.ucrButtonsSdgPlotRegion.Location = New System.Drawing.Point(61, 219)
        Me.ucrButtonsSdgPlotRegion.Name = "ucrButtonsSdgPlotRegion"
        Me.ucrButtonsSdgPlotRegion.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSdgPlotRegion.TabIndex = 0
        '
        'sdgPlotRegion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ucrButtonsSdgPlotRegion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgPlotRegion"
        Me.Text = "Plot Region"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSdgPlotRegion As ucrButtonsSubdialogue
End Class
