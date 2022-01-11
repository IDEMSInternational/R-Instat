<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgConstructRegexExpression
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
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(94, 266)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 30)
        Me.ucrBaseSubdialog.TabIndex = 8
        '
        'sdgConstructRegexExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(361, 301)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "sdgConstructRegexExpression"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Construct regex expression"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
End Class
