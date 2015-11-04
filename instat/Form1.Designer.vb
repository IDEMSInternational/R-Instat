<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.UcrBaseSubdialogue1 = New instat.ucrButtonsSubdialogue()
        Me.SuspendLayout()
        '
        'UcrBaseSubdialogue1
        '
        Me.UcrBaseSubdialogue1.Location = New System.Drawing.Point(12, 206)
        Me.UcrBaseSubdialogue1.Name = "UcrBaseSubdialogue1"
        Me.UcrBaseSubdialogue1.Size = New System.Drawing.Size(253, 44)
        Me.UcrBaseSubdialogue1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.UcrBaseSubdialogue1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrBaseSubdialogue1 As ucrButtonsSubdialogue
End Class
