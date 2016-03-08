<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgDensityOptions
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
        Me.ucrBaseDensityOptions = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrBaseDensityOptions
        '
        Me.ucrBaseDensityOptions.Location = New System.Drawing.Point(60, 224)
        Me.ucrBaseDensityOptions.Name = "ucrBaseDensityOptions"
        Me.ucrBaseDensityOptions.Size = New System.Drawing.Size(142, 30)
        Me.ucrBaseDensityOptions.TabIndex = 0
        '
        'sdgDensityOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ucrBaseDensityOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgDensityOptions"
        Me.Tag = "Density_Options"
        Me.Text = "Density Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseDensityOptions As ucrButtonsSubdialogue
End Class
