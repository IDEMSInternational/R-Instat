<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRowExpression
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrInputExpression = New instat.ucrInputTextBox()
        Me.SuspendLayout()
        '
        'ucrInputExpression
        '
        Me.ucrInputExpression.AddQuotesIfUnrecognised = True
        Me.ucrInputExpression.AutoSize = True
        Me.ucrInputExpression.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ucrInputExpression.IsMultiline = False
        Me.ucrInputExpression.IsReadOnly = False
        Me.ucrInputExpression.Location = New System.Drawing.Point(0, 0)
        Me.ucrInputExpression.Name = "ucrInputExpression"
        Me.ucrInputExpression.Size = New System.Drawing.Size(146, 21)
        Me.ucrInputExpression.TabIndex = 340
        '
        'ucrRowExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrInputExpression)
        Me.Name = "ucrRowExpression"
        Me.Size = New System.Drawing.Size(146, 21)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrInputExpression As ucrInputTextBox
End Class
