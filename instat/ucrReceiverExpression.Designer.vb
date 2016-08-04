<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrReceiverExpression
    Inherits instat.ucrReceiver

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
        Me.cboExpression = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cboExpression
        '
        Me.cboExpression.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboExpression.FormattingEnabled = True
        Me.cboExpression.Location = New System.Drawing.Point(0, 0)
        Me.cboExpression.Name = "cboExpression"
        Me.cboExpression.Size = New System.Drawing.Size(250, 21)
        Me.cboExpression.TabIndex = 0
        '
        'ucrReceiverExpression
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cboExpression)
        Me.Name = "ucrReceiverExpression"
        Me.Size = New System.Drawing.Size(250, 20)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboExpression As ComboBox
End Class
