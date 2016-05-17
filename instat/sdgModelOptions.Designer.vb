<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgModelOptions
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
        Me.grpLinkFunctions = New System.Windows.Forms.GroupBox()
        Me.rdocloglog = New System.Windows.Forms.RadioButton()
        Me.rdoSqrt = New System.Windows.Forms.RadioButton()
        Me.rdoMuSquaredInverse = New System.Windows.Forms.RadioButton()
        Me.rdoInverse = New System.Windows.Forms.RadioButton()
        Me.rdoCauchit = New System.Windows.Forms.RadioButton()
        Me.rdoProbit = New System.Windows.Forms.RadioButton()
        Me.rdoLogit = New System.Windows.Forms.RadioButton()
        Me.rdoLog = New System.Windows.Forms.RadioButton()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.grpDistributions = New System.Windows.Forms.GroupBox()
        Me.rdoNormal = New System.Windows.Forms.RadioButton()
        Me.rdoPoisson = New System.Windows.Forms.RadioButton()
        Me.rdoBinomial = New System.Windows.Forms.RadioButton()
        Me.rdoQuasiBinomial = New System.Windows.Forms.RadioButton()
        Me.rdoQuasiPoisson = New System.Windows.Forms.RadioButton()
        Me.rdoQuasi = New System.Windows.Forms.RadioButton()
        Me.rdoInverseGaussian = New System.Windows.Forms.RadioButton()
        Me.rdoGamma = New System.Windows.Forms.RadioButton()
        Me.ucrButtonsSDGModelOptions = New instat.ucrButtonsSubdialogue()
        Me.grpLinkFunctions.SuspendLayout()
        Me.grpDistributions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLinkFunctions
        '
        Me.grpLinkFunctions.Controls.Add(Me.rdocloglog)
        Me.grpLinkFunctions.Controls.Add(Me.rdoSqrt)
        Me.grpLinkFunctions.Controls.Add(Me.rdoMuSquaredInverse)
        Me.grpLinkFunctions.Controls.Add(Me.rdoInverse)
        Me.grpLinkFunctions.Controls.Add(Me.rdoCauchit)
        Me.grpLinkFunctions.Controls.Add(Me.rdoProbit)
        Me.grpLinkFunctions.Controls.Add(Me.rdoLogit)
        Me.grpLinkFunctions.Controls.Add(Me.rdoLog)
        Me.grpLinkFunctions.Controls.Add(Me.rdoIdentity)
        Me.grpLinkFunctions.Location = New System.Drawing.Point(12, 129)
        Me.grpLinkFunctions.Name = "grpLinkFunctions"
        Me.grpLinkFunctions.Size = New System.Drawing.Size(229, 87)
        Me.grpLinkFunctions.TabIndex = 2
        Me.grpLinkFunctions.TabStop = False
        Me.grpLinkFunctions.Tag = "Link_Functions"
        Me.grpLinkFunctions.Text = "Link Functions"
        '
        'rdocloglog
        '
        Me.rdocloglog.AutoSize = True
        Me.rdocloglog.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdocloglog.Location = New System.Drawing.Point(77, 22)
        Me.rdocloglog.Name = "rdocloglog"
        Me.rdocloglog.Size = New System.Drawing.Size(59, 17)
        Me.rdocloglog.TabIndex = 23
        Me.rdocloglog.TabStop = True
        Me.rdocloglog.Tag = "cloglog"
        Me.rdocloglog.Text = "cloglog"
        Me.rdocloglog.UseVisualStyleBackColor = True
        Me.rdocloglog.UseWaitCursor = True
        '
        'rdoSqrt
        '
        Me.rdoSqrt.AutoSize = True
        Me.rdoSqrt.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoSqrt.Location = New System.Drawing.Point(77, 45)
        Me.rdoSqrt.Name = "rdoSqrt"
        Me.rdoSqrt.Size = New System.Drawing.Size(44, 17)
        Me.rdoSqrt.TabIndex = 24
        Me.rdoSqrt.TabStop = True
        Me.rdoSqrt.Tag = "Sqrt"
        Me.rdoSqrt.Text = "Sqrt"
        Me.rdoSqrt.UseVisualStyleBackColor = True
        Me.rdoSqrt.UseWaitCursor = True
        '
        'rdoMuSquaredInverse
        '
        Me.rdoMuSquaredInverse.AutoSize = True
        Me.rdoMuSquaredInverse.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoMuSquaredInverse.Location = New System.Drawing.Point(77, 64)
        Me.rdoMuSquaredInverse.Name = "rdoMuSquaredInverse"
        Me.rdoMuSquaredInverse.Size = New System.Drawing.Size(62, 17)
        Me.rdoMuSquaredInverse.TabIndex = 25
        Me.rdoMuSquaredInverse.TabStop = True
        Me.rdoMuSquaredInverse.Tag = "1/mu^2"
        Me.rdoMuSquaredInverse.Text = "1/mu^2"
        Me.rdoMuSquaredInverse.UseVisualStyleBackColor = True
        Me.rdoMuSquaredInverse.UseWaitCursor = True
        '
        'rdoInverse
        '
        Me.rdoInverse.AutoSize = True
        Me.rdoInverse.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoInverse.Location = New System.Drawing.Point(150, 64)
        Me.rdoInverse.Name = "rdoInverse"
        Me.rdoInverse.Size = New System.Drawing.Size(60, 17)
        Me.rdoInverse.TabIndex = 26
        Me.rdoInverse.TabStop = True
        Me.rdoInverse.Tag = "Inverse"
        Me.rdoInverse.Text = "Inverse"
        Me.rdoInverse.UseVisualStyleBackColor = True
        Me.rdoInverse.UseWaitCursor = True
        '
        'rdoCauchit
        '
        Me.rdoCauchit.AutoSize = True
        Me.rdoCauchit.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoCauchit.Location = New System.Drawing.Point(149, 22)
        Me.rdoCauchit.Name = "rdoCauchit"
        Me.rdoCauchit.Size = New System.Drawing.Size(61, 17)
        Me.rdoCauchit.TabIndex = 22
        Me.rdoCauchit.TabStop = True
        Me.rdoCauchit.Tag = "Cauchit"
        Me.rdoCauchit.Text = "Cauchit"
        Me.rdoCauchit.UseVisualStyleBackColor = True
        Me.rdoCauchit.UseWaitCursor = True
        '
        'rdoProbit
        '
        Me.rdoProbit.AutoSize = True
        Me.rdoProbit.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoProbit.Location = New System.Drawing.Point(150, 45)
        Me.rdoProbit.Name = "rdoProbit"
        Me.rdoProbit.Size = New System.Drawing.Size(52, 17)
        Me.rdoProbit.TabIndex = 21
        Me.rdoProbit.TabStop = True
        Me.rdoProbit.Tag = "Probit"
        Me.rdoProbit.Text = "Probit"
        Me.rdoProbit.UseVisualStyleBackColor = True
        Me.rdoProbit.UseWaitCursor = True
        '
        'rdoLogit
        '
        Me.rdoLogit.AutoSize = True
        Me.rdoLogit.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoLogit.Location = New System.Drawing.Point(9, 66)
        Me.rdoLogit.Name = "rdoLogit"
        Me.rdoLogit.Size = New System.Drawing.Size(48, 17)
        Me.rdoLogit.TabIndex = 20
        Me.rdoLogit.TabStop = True
        Me.rdoLogit.Tag = "Logit"
        Me.rdoLogit.Text = "Logit"
        Me.rdoLogit.UseVisualStyleBackColor = True
        Me.rdoLogit.UseWaitCursor = True
        '
        'rdoLog
        '
        Me.rdoLog.AutoSize = True
        Me.rdoLog.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoLog.Location = New System.Drawing.Point(9, 45)
        Me.rdoLog.Name = "rdoLog"
        Me.rdoLog.Size = New System.Drawing.Size(43, 17)
        Me.rdoLog.TabIndex = 19
        Me.rdoLog.TabStop = True
        Me.rdoLog.Tag = "Log"
        Me.rdoLog.Text = "Log"
        Me.rdoLog.UseVisualStyleBackColor = True
        Me.rdoLog.UseWaitCursor = True
        '
        'rdoIdentity
        '
        Me.rdoIdentity.AutoSize = True
        Me.rdoIdentity.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.rdoIdentity.Location = New System.Drawing.Point(9, 21)
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.Size = New System.Drawing.Size(59, 17)
        Me.rdoIdentity.TabIndex = 18
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
        Me.rdoIdentity.Text = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        Me.rdoIdentity.UseWaitCursor = True
        '
        'grpDistributions
        '
        Me.grpDistributions.Controls.Add(Me.rdoGamma)
        Me.grpDistributions.Controls.Add(Me.rdoInverseGaussian)
        Me.grpDistributions.Controls.Add(Me.rdoQuasi)
        Me.grpDistributions.Controls.Add(Me.rdoQuasiPoisson)
        Me.grpDistributions.Controls.Add(Me.rdoQuasiBinomial)
        Me.grpDistributions.Controls.Add(Me.rdoBinomial)
        Me.grpDistributions.Controls.Add(Me.rdoPoisson)
        Me.grpDistributions.Controls.Add(Me.rdoNormal)
        Me.grpDistributions.Location = New System.Drawing.Point(12, 13)
        Me.grpDistributions.Name = "grpDistributions"
        Me.grpDistributions.Size = New System.Drawing.Size(229, 110)
        Me.grpDistributions.TabIndex = 3
        Me.grpDistributions.TabStop = False
        Me.grpDistributions.Tag = "Distributions"
        Me.grpDistributions.Text = "Distributions"
        '
        'rdoNormal
        '
        Me.rdoNormal.AutoSize = True
        Me.rdoNormal.Location = New System.Drawing.Point(9, 19)
        Me.rdoNormal.Name = "rdoNormal"
        Me.rdoNormal.Size = New System.Drawing.Size(58, 17)
        Me.rdoNormal.TabIndex = 0
        Me.rdoNormal.TabStop = True
        Me.rdoNormal.Tag = "Normal"
        Me.rdoNormal.Text = "Normal"
        Me.rdoNormal.UseVisualStyleBackColor = True
        '
        'rdoPoisson
        '
        Me.rdoPoisson.AutoSize = True
        Me.rdoPoisson.Location = New System.Drawing.Point(9, 64)
        Me.rdoPoisson.Name = "rdoPoisson"
        Me.rdoPoisson.Size = New System.Drawing.Size(62, 17)
        Me.rdoPoisson.TabIndex = 1
        Me.rdoPoisson.TabStop = True
        Me.rdoPoisson.Tag = "Poisson"
        Me.rdoPoisson.Text = "Poisson"
        Me.rdoPoisson.UseVisualStyleBackColor = True
        '
        'rdoBinomial
        '
        Me.rdoBinomial.AutoSize = True
        Me.rdoBinomial.Location = New System.Drawing.Point(9, 84)
        Me.rdoBinomial.Name = "rdoBinomial"
        Me.rdoBinomial.Size = New System.Drawing.Size(64, 17)
        Me.rdoBinomial.TabIndex = 2
        Me.rdoBinomial.TabStop = True
        Me.rdoBinomial.Tag = "Binomial"
        Me.rdoBinomial.Text = "Binomial"
        Me.rdoBinomial.UseVisualStyleBackColor = True
        '
        'rdoQuasiBinomial
        '
        Me.rdoQuasiBinomial.AutoSize = True
        Me.rdoQuasiBinomial.Location = New System.Drawing.Point(110, 87)
        Me.rdoQuasiBinomial.Name = "rdoQuasiBinomial"
        Me.rdoQuasiBinomial.Size = New System.Drawing.Size(94, 17)
        Me.rdoQuasiBinomial.TabIndex = 3
        Me.rdoQuasiBinomial.TabStop = True
        Me.rdoQuasiBinomial.Tag = "Quasi_Binomial"
        Me.rdoQuasiBinomial.Text = "Quasi Binomial"
        Me.rdoQuasiBinomial.UseVisualStyleBackColor = True
        '
        'rdoQuasiPoisson
        '
        Me.rdoQuasiPoisson.AutoSize = True
        Me.rdoQuasiPoisson.Location = New System.Drawing.Point(110, 65)
        Me.rdoQuasiPoisson.Name = "rdoQuasiPoisson"
        Me.rdoQuasiPoisson.Size = New System.Drawing.Size(92, 17)
        Me.rdoQuasiPoisson.TabIndex = 4
        Me.rdoQuasiPoisson.TabStop = True
        Me.rdoQuasiPoisson.Tag = "Quasi_Poisson"
        Me.rdoQuasiPoisson.Text = "Quasi Poisson"
        Me.rdoQuasiPoisson.UseVisualStyleBackColor = True
        '
        'rdoQuasi
        '
        Me.rdoQuasi.AutoSize = True
        Me.rdoQuasi.Location = New System.Drawing.Point(110, 43)
        Me.rdoQuasi.Name = "rdoQuasi"
        Me.rdoQuasi.Size = New System.Drawing.Size(52, 17)
        Me.rdoQuasi.TabIndex = 5
        Me.rdoQuasi.TabStop = True
        Me.rdoQuasi.Tag = "Quasi"
        Me.rdoQuasi.Text = "Quasi"
        Me.rdoQuasi.UseVisualStyleBackColor = True
        '
        'rdoInverseGaussian
        '
        Me.rdoInverseGaussian.AutoSize = True
        Me.rdoInverseGaussian.Location = New System.Drawing.Point(110, 20)
        Me.rdoInverseGaussian.Name = "rdoInverseGaussian"
        Me.rdoInverseGaussian.Size = New System.Drawing.Size(107, 17)
        Me.rdoInverseGaussian.TabIndex = 6
        Me.rdoInverseGaussian.TabStop = True
        Me.rdoInverseGaussian.Tag = "Inverse_Gaussian"
        Me.rdoInverseGaussian.Text = "Inverse Gaussian"
        Me.rdoInverseGaussian.UseVisualStyleBackColor = True
        '
        'rdoGamma
        '
        Me.rdoGamma.AutoSize = True
        Me.rdoGamma.Location = New System.Drawing.Point(9, 42)
        Me.rdoGamma.Name = "rdoGamma"
        Me.rdoGamma.Size = New System.Drawing.Size(61, 17)
        Me.rdoGamma.TabIndex = 7
        Me.rdoGamma.TabStop = True
        Me.rdoGamma.Tag = "Gamma"
        Me.rdoGamma.Text = "Gamma"
        Me.rdoGamma.UseVisualStyleBackColor = True
        '
        'ucrButtonsSDGModelOptions
        '
        Me.ucrButtonsSDGModelOptions.Location = New System.Drawing.Point(41, 217)
        Me.ucrButtonsSDGModelOptions.Name = "ucrButtonsSDGModelOptions"
        Me.ucrButtonsSDGModelOptions.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSDGModelOptions.TabIndex = 1
        '
        'sdgModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 250)
        Me.Controls.Add(Me.grpDistributions)
        Me.Controls.Add(Me.grpLinkFunctions)
        Me.Controls.Add(Me.ucrButtonsSDGModelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgModelOptions"
        Me.Tag = "Model_Options"
        Me.Text = "Model Options"
        Me.grpLinkFunctions.ResumeLayout(False)
        Me.grpLinkFunctions.PerformLayout()
        Me.grpDistributions.ResumeLayout(False)
        Me.grpDistributions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSDGModelOptions As ucrButtonsSubdialogue
    Friend WithEvents grpLinkFunctions As GroupBox
    Friend WithEvents rdocloglog As RadioButton
    Friend WithEvents rdoSqrt As RadioButton
    Friend WithEvents rdoMuSquaredInverse As RadioButton
    Friend WithEvents rdoInverse As RadioButton
    Friend WithEvents rdoCauchit As RadioButton
    Friend WithEvents rdoProbit As RadioButton
    Friend WithEvents rdoLogit As RadioButton
    Friend WithEvents rdoLog As RadioButton
    Friend WithEvents rdoIdentity As RadioButton
    Friend WithEvents grpDistributions As GroupBox
    Friend WithEvents rdoQuasi As RadioButton
    Friend WithEvents rdoQuasiPoisson As RadioButton
    Friend WithEvents rdoQuasiBinomial As RadioButton
    Friend WithEvents rdoBinomial As RadioButton
    Friend WithEvents rdoPoisson As RadioButton
    Friend WithEvents rdoNormal As RadioButton
    Friend WithEvents rdoGamma As RadioButton
    Friend WithEvents rdoInverseGaussian As RadioButton
End Class
