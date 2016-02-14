<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOneWayANOVA
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrYVariate = New instat.ucrReceiverSingle()
        Me.ucrFactor = New instat.ucrReceiverSingle()
        Me.lblYVariate = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.grpPlots = New System.Windows.Forms.GroupBox()
        Me.rdoANOVA = New System.Windows.Forms.RadioButton()
        Me.rdoResiduals = New System.Windows.Forms.RadioButton()
        Me.rdoMeans = New System.Windows.Forms.RadioButton()
        Me.rdoNone = New System.Windows.Forms.RadioButton()
        Me.ucrAddRemoveDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpPlots.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(4, 314)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 57)
        Me.ucrBase.TabIndex = 0
        '
        'ucrYVariate
        '
        Me.ucrYVariate.Location = New System.Drawing.Point(265, 112)
        Me.ucrYVariate.Name = "ucrYVariate"
        Me.ucrYVariate.Size = New System.Drawing.Size(106, 26)
        Me.ucrYVariate.TabIndex = 3
        '
        'ucrFactor
        '
        Me.ucrFactor.Location = New System.Drawing.Point(265, 160)
        Me.ucrFactor.Name = "ucrFactor"
        Me.ucrFactor.Size = New System.Drawing.Size(106, 26)
        Me.ucrFactor.TabIndex = 4
        '
        'lblYVariate
        '
        Me.lblYVariate.AutoSize = True
        Me.lblYVariate.Location = New System.Drawing.Point(271, 98)
        Me.lblYVariate.Name = "lblYVariate"
        Me.lblYVariate.Size = New System.Drawing.Size(49, 13)
        Me.lblYVariate.TabIndex = 5
        Me.lblYVariate.Tag = "Y variate"
        Me.lblYVariate.Text = "Y variate"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(272, 148)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 6
        Me.lblFactor.Tag = "Factor"
        Me.lblFactor.Text = "Factor"
        '
        'grpPlots
        '
        Me.grpPlots.Controls.Add(Me.rdoANOVA)
        Me.grpPlots.Controls.Add(Me.rdoResiduals)
        Me.grpPlots.Controls.Add(Me.rdoMeans)
        Me.grpPlots.Controls.Add(Me.rdoNone)
        Me.grpPlots.Location = New System.Drawing.Point(11, 216)
        Me.grpPlots.Name = "grpPlots"
        Me.grpPlots.Size = New System.Drawing.Size(231, 76)
        Me.grpPlots.TabIndex = 7
        Me.grpPlots.TabStop = False
        Me.grpPlots.Tag = "Plots"
        Me.grpPlots.Text = "Plots"
        '
        'rdoANOVA
        '
        Me.rdoANOVA.AutoSize = True
        Me.rdoANOVA.Location = New System.Drawing.Point(127, 44)
        Me.rdoANOVA.Name = "rdoANOVA"
        Me.rdoANOVA.Size = New System.Drawing.Size(62, 17)
        Me.rdoANOVA.TabIndex = 3
        Me.rdoANOVA.TabStop = True
        Me.rdoANOVA.Tag = "ANOVA"
        Me.rdoANOVA.Text = "ANOVA"
        Me.rdoANOVA.UseVisualStyleBackColor = True
        '
        'rdoResiduals
        '
        Me.rdoResiduals.AutoSize = True
        Me.rdoResiduals.Location = New System.Drawing.Point(127, 20)
        Me.rdoResiduals.Name = "rdoResiduals"
        Me.rdoResiduals.Size = New System.Drawing.Size(71, 17)
        Me.rdoResiduals.TabIndex = 2
        Me.rdoResiduals.TabStop = True
        Me.rdoResiduals.Tag = "Residuals"
        Me.rdoResiduals.Text = "Residuals"
        Me.rdoResiduals.UseVisualStyleBackColor = True
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
        'ucrAddRemoveDataFrame
        '
        Me.ucrAddRemoveDataFrame.Location = New System.Drawing.Point(4, 20)
        Me.ucrAddRemoveDataFrame.Name = "ucrAddRemoveDataFrame"
        Me.ucrAddRemoveDataFrame.Size = New System.Drawing.Size(242, 179)
        Me.ucrAddRemoveDataFrame.TabIndex = 8
        '
        'dlgOneWayANOVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 371)
        Me.Controls.Add(Me.ucrAddRemoveDataFrame)
        Me.Controls.Add(Me.grpPlots)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblYVariate)
        Me.Controls.Add(Me.ucrFactor)
        Me.Controls.Add(Me.ucrYVariate)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgOneWayANOVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "One Way Anova"
        Me.grpPlots.ResumeLayout(False)
        Me.grpPlots.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrYVariate As ucrReceiverSingle
    Friend WithEvents ucrFactor As ucrReceiverSingle
    Friend WithEvents lblYVariate As Label
    Friend WithEvents lblFactor As Label
    Friend WithEvents grpPlots As GroupBox
    Friend WithEvents rdoResiduals As RadioButton
    Friend WithEvents rdoMeans As RadioButton
    Friend WithEvents rdoNone As RadioButton
    Friend WithEvents rdoANOVA As RadioButton
    Friend WithEvents ucrAddRemoveDataFrame As ucrSelectorByDataFrameAddRemove
End Class
