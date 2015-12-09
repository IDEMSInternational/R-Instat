<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgNon_ParametricANOVA
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
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrReceiverFactor = New instat.ucrReceiverSingle()
        Me.ucrReceiverYVariate = New instat.ucrReceiverSingle()
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'lblYVariate
        '
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(256, 25)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(50, 13)
        Me.lblYVariate.TabIndex = 4
        Me.lblYVariate.Tag = "Y_Variate"
        Me.lblYVariate.Text = "Y Variate"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(256, 77)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrReceiverFactor
        '
        Me.ucrReceiverFactor.Location = New System.Drawing.Point(250, 91)
        Me.ucrReceiverFactor.Name = "ucrReceiverFactor"
        Me.ucrReceiverFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverFactor.TabIndex = 3
        '
        'ucrReceiverYVariate
        '
        Me.ucrReceiverYVariate.Location = New System.Drawing.Point(250, 38)
        Me.ucrReceiverYVariate.Name = "ucrReceiverYVariate"
        Me.ucrReceiverYVariate.Size = New System.Drawing.Size(106, 26)
        Me.ucrReceiverYVariate.TabIndex = 2
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(16, 6)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(203, 127)
        Me.ucrAddRemove.TabIndex = 1
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(0, 184)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 0
        '
        'dlgNon_ParametricANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 218)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrReceiverFactor)
        Me.Controls.Add(Me.ucrReceiverYVariate)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgNon_ParametricANOVA"
        Me.Text = "Non-Parametric One Way ANOVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrReceiverYVariate As ucrReceiverSingle
    Friend WithEvents ucrReceiverFactor As ucrReceiverSingle
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
End Class
