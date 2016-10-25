<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimdex
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
        Me.ucrBaseClimdex = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrBaseClimdex
        '
        Me.ucrBaseClimdex.Location = New System.Drawing.Point(12, 197)
        Me.ucrBaseClimdex.Name = "ucrBaseClimdex"
        Me.ucrBaseClimdex.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseClimdex.TabIndex = 0
        '
        'dlgClimdex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 261)
        Me.Controls.Add(Me.ucrBaseClimdex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdex"
        Me.Tag = "Climdex"
        Me.Text = "Climdex"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseClimdex As ucrButtons
End Class
