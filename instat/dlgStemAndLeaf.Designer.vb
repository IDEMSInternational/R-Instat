<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStemAndLeaf
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
        Me.UcrAddRemove = New instat.ucrSelectorAddRemove()
        Me.UcrReceiverSingle1 = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(2, 12)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(186, 129)
        Me.UcrAddRemove.TabIndex = 0
        '
        'UcrReceiverSingle1
        '
        Me.UcrReceiverSingle1.Location = New System.Drawing.Point(245, 40)
        Me.UcrReceiverSingle1.Name = "UcrReceiverSingle1"
        Me.UcrReceiverSingle1.Size = New System.Drawing.Size(106, 26)
        Me.UcrReceiverSingle1.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(12, 216)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 2
        '
        'dlgStemAndLeaf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 260)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.UcrReceiverSingle1)
        Me.Controls.Add(Me.UcrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgStemAndLeaf"
        Me.Tag = "StemandLeaf"
        Me.Text = "Stem and Leaf"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrAddRemove As ucrSelectorAddRemove
    Friend WithEvents UcrReceiverSingle1 As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
End Class
