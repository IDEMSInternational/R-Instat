<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrReceiverSingle
    Inherits instat.ucrReceiver

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtReceiverSingle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtReceiverSingle
        '
        Me.txtReceiverSingle.Location = New System.Drawing.Point(3, 3)
        Me.txtReceiverSingle.Name = "txtReceiverSingle"
        Me.txtReceiverSingle.Size = New System.Drawing.Size(100, 20)
        Me.txtReceiverSingle.TabIndex = 0
        '
        'ucrReceiverSingle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.txtReceiverSingle)
        Me.Name = "ucrReceiverSingle"
        Me.Size = New System.Drawing.Size(106, 26)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceiverSingle As TextBox
End Class
