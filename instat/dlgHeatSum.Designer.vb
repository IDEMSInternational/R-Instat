<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgHeatSum
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
        Me.ucrButtons = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrButtons
        '
        Me.ucrButtons.Location = New System.Drawing.Point(3, 265)
        Me.ucrButtons.Name = "ucrButtons"
        Me.ucrButtons.Size = New System.Drawing.Size(410, 32)
        Me.ucrButtons.TabIndex = 0
        '
        'dlgHeatSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 300)
        Me.Controls.Add(Me.ucrButtons)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgHeatSum"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Heat_Sum"
        Me.Text = "Heat Sum"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtons As ucrButtons
End Class
