<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimdexIndices
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
        Me.ucrBaseClimdexIndices = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrBaseClimdexIndices
        '
        Me.ucrBaseClimdexIndices.Location = New System.Drawing.Point(24, 207)
        Me.ucrBaseClimdexIndices.Name = "ucrBaseClimdexIndices"
        Me.ucrBaseClimdexIndices.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseClimdexIndices.TabIndex = 0
        '
        'dlgClimdexIndices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 261)
        Me.Controls.Add(Me.ucrBaseClimdexIndices)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdexIndices"
        Me.Text = "dlgClimdexIndices"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseClimdexIndices As ucrButtons
End Class
