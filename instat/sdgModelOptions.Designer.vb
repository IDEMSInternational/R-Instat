<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgModelOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.rdocloglog = New System.Windows.Forms.RadioButton()
        Me.rdoSqrt = New System.Windows.Forms.RadioButton()
        Me.rdoMuSquaredInverse = New System.Windows.Forms.RadioButton()
        Me.rdoInverse = New System.Windows.Forms.RadioButton()
        Me.rdoCauchit = New System.Windows.Forms.RadioButton()
        Me.rdoProbit = New System.Windows.Forms.RadioButton()
        Me.grpLinkFunctions = New System.Windows.Forms.GroupBox()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.rdoLog = New System.Windows.Forms.RadioButton()
        Me.rdoLogit = New System.Windows.Forms.RadioButton()
        Me.ucrPnlLinkFunctions = New instat.UcrPanel()
        Me.ucrDistributionChoice = New instat.ucrDistributions()
        Me.ucrButtonsSDGModelOptions = New instat.ucrButtonsSubdialogue()
        Me.grpLinkFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'rdocloglog
        '
        Me.rdocloglog.AutoSize = True
        Me.rdocloglog.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdocloglog.Location = New System.Drawing.Point(85, 23)
        Me.rdocloglog.Name = "rdocloglog"
        Me.rdocloglog.Size = New System.Drawing.Size(59, 17)
        Me.rdocloglog.TabIndex = 1
        Me.rdocloglog.Tag = "cloglog"
        Me.rdocloglog.Text = "cloglog"
        Me.rdocloglog.UseVisualStyleBackColor = True
        '
        'rdoSqrt
        '
        Me.rdoSqrt.AutoSize = True
        Me.rdoSqrt.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoSqrt.Location = New System.Drawing.Point(85, 47)
        Me.rdoSqrt.Name = "rdoSqrt"
        Me.rdoSqrt.Size = New System.Drawing.Size(44, 17)
        Me.rdoSqrt.TabIndex = 4
        Me.rdoSqrt.Tag = "Sqrt"
        Me.rdoSqrt.Text = "Sqrt"
        Me.rdoSqrt.UseVisualStyleBackColor = True
        '
        'rdoMuSquaredInverse
        '
        Me.rdoMuSquaredInverse.AutoSize = True
        Me.rdoMuSquaredInverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoMuSquaredInverse.Location = New System.Drawing.Point(85, 73)
        Me.rdoMuSquaredInverse.Name = "rdoMuSquaredInverse"
        Me.rdoMuSquaredInverse.Size = New System.Drawing.Size(62, 17)
        Me.rdoMuSquaredInverse.TabIndex = 7
        Me.rdoMuSquaredInverse.Tag = "1/mu^2"
        Me.rdoMuSquaredInverse.Text = "1/mu^2"
        Me.rdoMuSquaredInverse.UseVisualStyleBackColor = True
        '
        'rdoInverse
        '
        Me.rdoInverse.AutoSize = True
        Me.rdoInverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoInverse.Location = New System.Drawing.Point(155, 71)
        Me.rdoInverse.Name = "rdoInverse"
        Me.rdoInverse.Size = New System.Drawing.Size(60, 17)
        Me.rdoInverse.TabIndex = 8
        Me.rdoInverse.Tag = "Inverse"
        Me.rdoInverse.Text = "Inverse"
        Me.rdoInverse.UseVisualStyleBackColor = True
        '
        'rdoCauchit
        '
        Me.rdoCauchit.AutoSize = True
        Me.rdoCauchit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoCauchit.Location = New System.Drawing.Point(155, 22)
        Me.rdoCauchit.Name = "rdoCauchit"
        Me.rdoCauchit.Size = New System.Drawing.Size(61, 17)
        Me.rdoCauchit.TabIndex = 2
        Me.rdoCauchit.Tag = "Cauchit"
        Me.rdoCauchit.Text = "Cauchit"
        Me.rdoCauchit.UseVisualStyleBackColor = True
        '
        'rdoProbit
        '
        Me.rdoProbit.AutoSize = True
        Me.rdoProbit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoProbit.Location = New System.Drawing.Point(155, 47)
        Me.rdoProbit.Name = "rdoProbit"
        Me.rdoProbit.Size = New System.Drawing.Size(52, 17)
        Me.rdoProbit.TabIndex = 5
        Me.rdoProbit.Tag = "Probit"
        Me.rdoProbit.Text = "Probit"
        Me.rdoProbit.UseVisualStyleBackColor = True
        '
        'grpLinkFunctions
        '
        Me.grpLinkFunctions.Controls.Add(Me.rdoIdentity)
        Me.grpLinkFunctions.Controls.Add(Me.rdoLog)
        Me.grpLinkFunctions.Controls.Add(Me.rdoLogit)
        Me.grpLinkFunctions.Controls.Add(Me.rdocloglog)
        Me.grpLinkFunctions.Controls.Add(Me.rdoSqrt)
        Me.grpLinkFunctions.Controls.Add(Me.rdoMuSquaredInverse)
        Me.grpLinkFunctions.Controls.Add(Me.rdoInverse)
        Me.grpLinkFunctions.Controls.Add(Me.rdoCauchit)
        Me.grpLinkFunctions.Controls.Add(Me.rdoProbit)
        Me.grpLinkFunctions.Controls.Add(Me.ucrPnlLinkFunctions)
        Me.grpLinkFunctions.Location = New System.Drawing.Point(13, 57)
        Me.grpLinkFunctions.Name = "grpLinkFunctions"
        Me.grpLinkFunctions.Size = New System.Drawing.Size(239, 104)
        Me.grpLinkFunctions.TabIndex = 11
        Me.grpLinkFunctions.TabStop = False
        Me.grpLinkFunctions.Text = "LinkFunctions"
        '
        'rdoIdentity
        '
        Me.rdoIdentity.AutoSize = True
        Me.rdoIdentity.Location = New System.Drawing.Point(15, 22)
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.Size = New System.Drawing.Size(59, 17)
        Me.rdoIdentity.TabIndex = 12
        Me.rdoIdentity.Text = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'rdoLog
        '
        Me.rdoLog.AutoSize = True
        Me.rdoLog.Location = New System.Drawing.Point(15, 47)
        Me.rdoLog.Name = "rdoLog"
        Me.rdoLog.Size = New System.Drawing.Size(43, 17)
        Me.rdoLog.TabIndex = 11
        Me.rdoLog.Text = "Log"
        Me.rdoLog.UseVisualStyleBackColor = True
        '
        'rdoLogit
        '
        Me.rdoLogit.AutoSize = True
        Me.rdoLogit.Location = New System.Drawing.Point(15, 71)
        Me.rdoLogit.Name = "rdoLogit"
        Me.rdoLogit.Size = New System.Drawing.Size(48, 17)
        Me.rdoLogit.TabIndex = 10
        Me.rdoLogit.Text = "Logit"
        Me.rdoLogit.UseVisualStyleBackColor = True
        '
        'ucrPnlLinkFunctions
        '
        Me.ucrPnlLinkFunctions.Location = New System.Drawing.Point(6, 19)
        Me.ucrPnlLinkFunctions.Name = "ucrPnlLinkFunctions"
        Me.ucrPnlLinkFunctions.Size = New System.Drawing.Size(225, 79)
        Me.ucrPnlLinkFunctions.TabIndex = 9
        '
        'ucrDistributionChoice
        '
        Me.ucrDistributionChoice.Location = New System.Drawing.Point(13, 12)
        Me.ucrDistributionChoice.Name = "ucrDistributionChoice"
        Me.ucrDistributionChoice.Size = New System.Drawing.Size(208, 27)
        Me.ucrDistributionChoice.TabIndex = 10
        '
        'ucrButtonsSDGModelOptions
        '
        Me.ucrButtonsSDGModelOptions.Location = New System.Drawing.Point(34, 163)
        Me.ucrButtonsSDGModelOptions.Name = "ucrButtonsSDGModelOptions"
        Me.ucrButtonsSDGModelOptions.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSDGModelOptions.TabIndex = 2
        '
        'sdgModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 204)
        Me.Controls.Add(Me.ucrDistributionChoice)
        Me.Controls.Add(Me.grpLinkFunctions)
        Me.Controls.Add(Me.ucrButtonsSDGModelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgModelOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Tag = "Model_Options"
        Me.Text = "Model Options"
        Me.grpLinkFunctions.ResumeLayout(False)
        Me.grpLinkFunctions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSDGModelOptions As ucrButtonsSubdialogue
    Friend WithEvents rdocloglog As RadioButton
    Friend WithEvents rdoSqrt As RadioButton
    Friend WithEvents rdoMuSquaredInverse As RadioButton
    Friend WithEvents rdoInverse As RadioButton
    Friend WithEvents rdoCauchit As RadioButton
    Friend WithEvents rdoProbit As RadioButton
    Friend WithEvents ucrPnlLinkFunctions As UcrPanel
    Friend WithEvents grpLinkFunctions As GroupBox
    Friend WithEvents ucrDistributionChoice As ucrDistributions
    Friend WithEvents rdoIdentity As RadioButton
    Friend WithEvents rdoLog As RadioButton
    Friend WithEvents rdoLogit As RadioButton
End Class
