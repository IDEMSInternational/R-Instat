<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgLayers
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
        Me.ucrSdgLayerBase = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrSdgLayerBase
        '
        Me.ucrSdgLayerBase.Location = New System.Drawing.Point(64, 251)
        Me.ucrSdgLayerBase.Name = "ucrSdgLayerBase"
        Me.ucrSdgLayerBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgLayerBase.TabIndex = 0
        '
        'sdgLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 293)
        Me.Controls.Add(Me.ucrSdgLayerBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgLayers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Layers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgLayerBase As ucrButtonsSubdialogue
End Class
