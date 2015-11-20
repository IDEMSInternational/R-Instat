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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSingleReceiver2 = New instat.ucrReceiverSingle()
        Me.ucrSingleReceiver1 = New instat.ucrReceiverSingle()
        Me.UcrAddRemove = New instat.ucrSelectorAddRemove()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(252, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Y variate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(252, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Factor"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 233)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 3
        '
        'ucrSingleReceiver2
        '
        Me.ucrSingleReceiver2.Location = New System.Drawing.Point(244, 91)
        Me.ucrSingleReceiver2.Name = "ucrSingleReceiver2"
        Me.ucrSingleReceiver2.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver2.TabIndex = 2
        '
        'ucrSingleReceiver1
        '
        Me.ucrSingleReceiver1.Location = New System.Drawing.Point(244, 39)
        Me.ucrSingleReceiver1.Name = "ucrSingleReceiver1"
        Me.ucrSingleReceiver1.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver1.TabIndex = 1
        '
        'UcrAddRemove
        '
        Me.UcrAddRemove.Location = New System.Drawing.Point(12, 12)
        Me.UcrAddRemove.Name = "UcrAddRemove"
        Me.UcrAddRemove.Size = New System.Drawing.Size(209, 129)
        Me.UcrAddRemove.TabIndex = 0
        '
        'dlgAnovaOneWay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSingleReceiver2)
        Me.Controls.Add(Me.ucrSingleReceiver1)
        Me.Controls.Add(Me.UcrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAnovaOneWay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Anova_One_Way"
        Me.Text = "Non-Parametric One Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrSingleReceiver1 As ucrReceiverSingle
    Friend WithEvents ucrSingleReceiver2 As ucrReceiverSingle
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
