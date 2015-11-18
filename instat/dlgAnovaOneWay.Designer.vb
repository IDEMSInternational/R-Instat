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
        Me.ucrAddRemove = New instat.ucrSelectorAddRemove()
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.ucrSingleReceiver1 = New instat.ucrReceiverSingle()
        Me.ucrSingleReceiver2 = New instat.ucrReceiverSingleB()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.rdoMeans = New System.Windows.Forms.RadioButton()
        Me.rdoResiduals = New System.Windows.Forms.RadioButton()
        Me.rdoANOVA = New System.Windows.Forms.RadioButton()
        Me.grpPlots.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(3, 233)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 32)
        Me.ucrBase.TabIndex = 3
        '
        'ucrAddRemove
        '
        Me.ucrAddRemove.Location = New System.Drawing.Point(3, 12)
        Me.ucrAddRemove.Name = "ucrAddRemove"
        Me.ucrAddRemove.Size = New System.Drawing.Size(186, 129)
        Me.ucrAddRemove.TabIndex = 0
        '
        'lblYVariate
        '
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(254, 19)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(50, 13)
        Me.lblYVariate.TabIndex = 4
        Me.lblYVariate.Tag = "Y_Variate"
        Me.lblYVariate.Text = "Y Variate"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(257, 68)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 5
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'ucrSingleReceiver1
        '
        Me.ucrSingleReceiver1.Location = New System.Drawing.Point(257, 36)
        Me.ucrSingleReceiver1.Name = "ucrSingleReceiver1"
        Me.ucrSingleReceiver1.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver1.TabIndex = 6
        '
        'ucrSingleReceiver2
        '
        Me.ucrSingleReceiver2.Location = New System.Drawing.Point(260, 85)
        Me.ucrSingleReceiver2.Name = "ucrSingleReceiver2"
        Me.ucrSingleReceiver2.Size = New System.Drawing.Size(106, 26)
        Me.ucrSingleReceiver2.TabIndex = 7
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoANOVA)
        Me.grpPlots.Controls.Add(Me.rdoResiduals)
        Me.grpPlots.Controls.Add(Me.rdoMeans)
        Me.grpPlots.Controls.Add(Me.rdoNone)
        Me.grpPlots.Location = New System.Drawing.Point(12, 142)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(207, 85)
        Me.grpPlots.TabIndex = 8
        Me.grpPlots.TabStop = False
        Me.grpPlots.Tag = "Plots"
        Me.grpPlots.Text = "Plots"
        '
        'rdoNone
        '
        Me.rdoNone.AutoSize = True
        Me.rdoNone.Location = New System.Drawing.Point(7, 20)
        Me.rdoNone.Name = "rdoNone"
        Me.rdoNone.Size = New System.Drawing.Size(51, 17)
        Me.rdoNone.TabIndex = 0
        Me.rdoNone.TabStop = True
        Me.rdoNone.Tag = "None"
        Me.rdoNone.Text = "None"
        Me.rdoNone.UseVisualStyleBackColor = True
        '
        'rdoMeans
        '
        Me.rdoMeans.AutoSize = True
        Me.rdoMeans.Location = New System.Drawing.Point(7, 44)
        Me.rdoMeans.Name = "rdoMeans"
        Me.rdoMeans.Size = New System.Drawing.Size(57, 17)
        Me.rdoMeans.TabIndex = 1
        Me.rdoMeans.TabStop = True
        Me.rdoMeans.Tag = "Means"
        Me.rdoMeans.Text = "Means"
        Me.rdoMeans.UseVisualStyleBackColor = True
        '
        'rdoResiduals
        '
        Me.rdoResiduals.AutoSize = True
        Me.rdoResiduals.Location = New System.Drawing.Point(111, 19)
        Me.rdoResiduals.Name = "rdoResiduals"
        Me.rdoResiduals.Size = New System.Drawing.Size(71, 17)
        Me.rdoResiduals.TabIndex = 2
        Me.rdoResiduals.TabStop = True
        Me.rdoResiduals.Tag = "Residuals"
        Me.rdoResiduals.Text = "Residuals"
        Me.rdoResiduals.UseVisualStyleBackColor = True
        '
        'rdoANOVA
        '
        Me.rdoANOVA.AutoSize = True
        Me.rdoANOVA.Location = New System.Drawing.Point(111, 44)
        Me.rdoANOVA.Name = "rdoANOVA"
        Me.rdoANOVA.Size = New System.Drawing.Size(62, 17)
        Me.rdoANOVA.TabIndex = 3
        Me.rdoANOVA.TabStop = True
        Me.rdoANOVA.Tag = "ANOVA"
        Me.rdoANOVA.Text = "ANOVA"
        Me.rdoANOVA.UseVisualStyleBackColor = True
        '
        'dlgAnovaOneWay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.ucrSingleReceiver2)
        Me.Controls.Add(Me.ucrSingleReceiver1)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrAddRemove)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAnovaOneWay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Anova_One_Way"
        Me.Text = "Anova One Way"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrAddRemove As ucrSelectorAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents ucrSingleReceiver1 As ucrReceiverSingle
    Friend WithEvents ucrSingleReceiver2 As ucrReceiverSingleB
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoANOVA As RadioButton
    Friend WithEvents rdoResiduals As RadioButton
    Friend WithEvents rdoMeans As RadioButton
    Friend WithEvents rdoNone As RadioButton
End Class
