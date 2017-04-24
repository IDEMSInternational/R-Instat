<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStringDistance
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
        Me.UcrBaseStringDistance = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'UcrBaseStringDistance
        '
        Me.UcrBaseStringDistance.Location = New System.Drawing.Point(10, 266)
        Me.UcrBaseStringDistance.Name = "UcrBaseStringDistance"
        Me.UcrBaseStringDistance.Size = New System.Drawing.Size(410, 52)
        Me.UcrBaseStringDistance.TabIndex = 0
        '
        'dlgStringDistance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 330)
        Me.Controls.Add(Me.UcrBaseStringDistance)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStringDistance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "String Distance"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrBaseStringDistance As ucrButtons
End Class
