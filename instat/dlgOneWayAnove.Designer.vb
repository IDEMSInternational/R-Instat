<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNPOneWay
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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrSingleReceiver1 = New instat.ucrReceiverSingle()
        Me.ucrSingleReceiver2 = New instat.ucrReceiverSingleB()
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 0)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(182, 118)
        Me.ucrAddRemove.TabIndex = 0
        '
        'ucrSingleReceiver1
        '
        Me.ucrSingleReceiver1.Location = New System.Drawing.Point(214, 38)
        Me.ucrSingleReceiver1.Name = "ucrSingleReceiver1"
        Me.ucrSingleReceiver1.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver1.TabIndex = 1
        '
        'ucrSingleReceiver2
        '
        Me.ucrSingleReceiver2.Location = New System.Drawing.Point(214, 83)
        Me.ucrSingleReceiver2.Name = "ucrSingleReceiver2"
        Me.ucrSingleReceiver2.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver2.TabIndex = 2
        '
        'lblYVariate
        '
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(223, 25)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(50, 13)
        Me.lblYVariate.TabIndex = 3
        Me.lblYVariate.Tag = "Y_Variate"
        Me.lblYVariate.Text = "Y Variate"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(226, 71)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 4
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 250)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 5
        '
        'dlgNPOneWay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 279)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrSingleReceiver2)
        Me.Controls.Add(Me.ucrSingleReceiver1)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgNPOneWay"
        Me.Tag = "Non_Parametric_One_Way_Anova"
        Me.Text = "Non-Parametric One Way Anova"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrSingleReceiver1 As ucrReceiverSingle
    Friend WithEvents ucrSingleReceiver2 As ucrReceiverSingleB
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrBase As ucrButtons
End Class
