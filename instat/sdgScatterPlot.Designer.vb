<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgScatterPlot
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
        Me.ucrSdgScatterPlotBase = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrSdgScatterPlotBase
        '
        Me.ucrSdgScatterPlotBase.Location = New System.Drawing.Point(68, 219)
        Me.ucrSdgScatterPlotBase.Name = "ucrSdgScatterPlotBase"
        Me.ucrSdgScatterPlotBase.Size = New System.Drawing.Size(142, 30)
        Me.ucrSdgScatterPlotBase.TabIndex = 0
        '
        'sdgScatterPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ucrSdgScatterPlotBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgScatterPlot"
        Me.Text = "ScatterPlot Options"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrSdgScatterPlotBase As ucrButtonsSubdialogue
End Class
