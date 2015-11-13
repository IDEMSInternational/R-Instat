<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAnovaOneWay
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ucrBase = New instat.ucrButtons()
        Me.UcrSingleReceiver2 = New instat.ucrReceiverSingle()
        Me.UcrSingleReceiver1 = New instat.ucrReceiverSingle()
        Me.UcrAddRemove = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 233)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 3
        '
        'UcrSingleReceiver2
        '
        Me.UcrSingleReceiver2.Location = New System.Drawing.Point(244, 35)
        Me.UcrSingleReceiver2.Name = "UcrSingleReceiver2"
        Me.UcrSingleReceiver2.Size = New System.Drawing.Size(106, 26)
        Me.UcrSingleReceiver2.TabIndex = 2
        '
        'UcrSingleReceiver1
        '
        Me.UcrSingleReceiver1.Location = New System.Drawing.Point(244, 86)
        Me.UcrSingleReceiver1.Name = "UcrSingleReceiver1"
        Me.UcrSingleReceiver1.Size = New System.Drawing.Size(106, 26)
        Me.UcrSingleReceiver1.TabIndex = 1
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(3, 12)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(186, 129)
        Me.UcrAddRemove.TabIndex = 0
        '
        'dlgAnovaOneWay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.UcrSingleReceiver2)
        Me.Controls.Add(Me.UcrSingleReceiver1)
        Me.Controls.Add(Me.UcrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAnovaOneWay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Anova_One_Way"
        Me.Text = "Anova One Way"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrAddRemove As ucrSelectorAddRemove
    Friend WithEvents UcrSingleReceiver1 As ucrReceiverSingle
    Friend WithEvents UcrSingleReceiver2 As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
End Class
