<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClimdexInput
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
        Me.ucrBaseClimdexInput = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrBaseClimdexInput
        '
        Me.ucrBaseClimdexInput.Location = New System.Drawing.Point(12, 208)
        Me.ucrBaseClimdexInput.Name = "ucrBaseClimdexInput"
        Me.ucrBaseClimdexInput.Size = New System.Drawing.Size(410, 52)
        Me.ucrBaseClimdexInput.TabIndex = 0
        '
        'dlgClimdexInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 261)
        Me.Controls.Add(Me.ucrBaseClimdexInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClimdexInput"
        Me.Text = "dlgClimdexInput"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrBaseClimdexInput As ucrButtons
End Class
