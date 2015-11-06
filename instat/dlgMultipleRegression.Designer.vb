<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMultipleRegression
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
        Me.UcrReceiverMultiple1 = New instat.ucrReceiverMultiple()
        Me.UcrSelector1 = New instat.ucrSelector()
        Me.SuspendLayout()
        '
        'UcrReceiverMultiple1
        '
        Me.UcrReceiverMultiple1.Location = New System.Drawing.Point(199, 12)
        Me.UcrReceiverMultiple1.Name = "UcrReceiverMultiple1"
        Me.UcrReceiverMultiple1.Size = New System.Drawing.Size(98, 118)
        Me.UcrReceiverMultiple1.TabIndex = 0
        '
        'UcrSelector1
        '
        Me.UcrSelector1.Location = New System.Drawing.Point(12, 12)
        Me.UcrSelector1.Name = "UcrSelector1"
        Me.UcrSelector1.Size = New System.Drawing.Size(181, 123)
        Me.UcrSelector1.TabIndex = 1
        '
        'dlgMultipleRegression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 142)
        Me.Controls.Add(Me.UcrSelector1)
        Me.Controls.Add(Me.UcrReceiverMultiple1)
        Me.Name = "dlgMultipleRegression"
        Me.Text = "dlgMultipleRegression"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrReceiverMultiple1 As ucrReceiverMultiple
    Friend WithEvents UcrSelector1 As ucrSelector
End Class
