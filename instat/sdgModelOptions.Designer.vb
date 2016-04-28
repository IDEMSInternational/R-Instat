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
        Me.tbDistribution = New System.Windows.Forms.TabPage()
        Me.tbFunctions = New System.Windows.Forms.TabPage()
        Me.grpGeneralFunctions = New System.Windows.Forms.GroupBox()
        Me.rdoNaturallog = New System.Windows.Forms.RadioButton()
        Me.nudPower = New System.Windows.Forms.NumericUpDown()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoSquareroot = New System.Windows.Forms.RadioButton()
        Me.rdoLogBase10 = New System.Windows.Forms.RadioButton()
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.grpLinkFunctions = New System.Windows.Forms.GroupBox()
        Me.rdoIdentity = New System.Windows.Forms.RadioButton()
        Me.rdoLog = New System.Windows.Forms.RadioButton()
        Me.rdoLogit = New System.Windows.Forms.RadioButton()
        Me.rdoProbit = New System.Windows.Forms.RadioButton()
        Me.rdoCauchit = New System.Windows.Forms.RadioButton()
        Me.rdoInverse = New System.Windows.Forms.RadioButton()
        Me.rdoMuSquaredInverse = New System.Windows.Forms.RadioButton()
        Me.rdoSqrt = New System.Windows.Forms.RadioButton()
        Me.rdocloglog = New System.Windows.Forms.RadioButton()
        Me.ucrButtonsSDGModelOptions = New instat.ucrButtonsSubdialogue()
        Me.tbDistribution.SuspendLayout()
        Me.tbFunctions.SuspendLayout()
        Me.grpGeneralFunctions.SuspendLayout()
        CType(Me.nudPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegOptions.SuspendLayout()
        Me.grpLinkFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbDistribution
        '
        Me.tbDistribution.Controls.Add(Me.grpLinkFunctions)
        Me.tbDistribution.Location = New System.Drawing.Point(4, 22)
        Me.tbDistribution.Name = "tbDistribution"
        Me.tbDistribution.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDistribution.Size = New System.Drawing.Size(205, 173)
        Me.tbDistribution.TabIndex = 2
        Me.tbDistribution.Tag = "Distribution"
        Me.tbDistribution.Text = "Distribution"
        Me.tbDistribution.UseVisualStyleBackColor = True
        Me.tbDistribution.UseWaitCursor = True
        '
        'tbFunctions
        '
        Me.tbFunctions.Controls.Add(Me.grpGeneralFunctions)
        Me.tbFunctions.Location = New System.Drawing.Point(4, 22)
        Me.tbFunctions.Name = "tbFunctions"
        Me.tbFunctions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFunctions.Size = New System.Drawing.Size(205, 173)
        Me.tbFunctions.TabIndex = 1
        Me.tbFunctions.Tag = "Functions"
        Me.tbFunctions.Text = "Functions"
        Me.tbFunctions.UseVisualStyleBackColor = True
        '
        'grpGeneralFunctions
        '
        Me.grpGeneralFunctions.Controls.Add(Me.rdoNaturallog)
        Me.grpGeneralFunctions.Controls.Add(Me.nudPower)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoPower)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoSquareroot)
        Me.grpGeneralFunctions.Controls.Add(Me.rdoLogBase10)
        Me.grpGeneralFunctions.Location = New System.Drawing.Point(10, 17)
        Me.grpGeneralFunctions.Name = "grpGeneralFunctions"
        Me.grpGeneralFunctions.Size = New System.Drawing.Size(181, 134)
        Me.grpGeneralFunctions.TabIndex = 10
        Me.grpGeneralFunctions.TabStop = False
        Me.grpGeneralFunctions.Tag = "General_Functions"
        Me.grpGeneralFunctions.Text = "General Functions"
        '
        'rdoNaturallog
        '
        Me.rdoNaturallog.AutoSize = True
        Me.rdoNaturallog.Location = New System.Drawing.Point(9, 24)
        Me.rdoNaturallog.Name = "rdoNaturallog"
        Me.rdoNaturallog.Size = New System.Drawing.Size(76, 17)
        Me.rdoNaturallog.TabIndex = 6
        Me.rdoNaturallog.TabStop = True
        Me.rdoNaturallog.Tag = "Natural_log"
        Me.rdoNaturallog.Text = "Natural log"
        Me.rdoNaturallog.UseVisualStyleBackColor = True
        '
        'nudPower
        '
        Me.nudPower.Location = New System.Drawing.Point(86, 92)
        Me.nudPower.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudPower.Name = "nudPower"
        Me.nudPower.Size = New System.Drawing.Size(41, 20)
        Me.nudPower.TabIndex = 5
        Me.nudPower.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rdoPower
        '
        Me.rdoPower.AutoSize = True
        Me.rdoPower.Location = New System.Drawing.Point(10, 93)
        Me.rdoPower.Name = "rdoPower"
        Me.rdoPower.Size = New System.Drawing.Size(55, 17)
        Me.rdoPower.TabIndex = 8
        Me.rdoPower.TabStop = True
        Me.rdoPower.Tag = "Power"
        Me.rdoPower.Text = "Power"
        Me.rdoPower.UseVisualStyleBackColor = True
        '
        'rdoSquareroot
        '
        Me.rdoSquareroot.AutoSize = True
        Me.rdoSquareroot.Location = New System.Drawing.Point(9, 70)
        Me.rdoSquareroot.Name = "rdoSquareroot"
        Me.rdoSquareroot.Size = New System.Drawing.Size(80, 17)
        Me.rdoSquareroot.TabIndex = 9
        Me.rdoSquareroot.TabStop = True
        Me.rdoSquareroot.Tag = "Square_root"
        Me.rdoSquareroot.Text = "Square root"
        Me.rdoSquareroot.UseVisualStyleBackColor = True
        '
        'rdoLogBase10
        '
        Me.rdoLogBase10.AutoSize = True
        Me.rdoLogBase10.Location = New System.Drawing.Point(9, 47)
        Me.rdoLogBase10.Name = "rdoLogBase10"
        Me.rdoLogBase10.Size = New System.Drawing.Size(85, 17)
        Me.rdoLogBase10.TabIndex = 7
        Me.rdoLogBase10.TabStop = True
        Me.rdoLogBase10.Tag = "Log_Base_10"
        Me.rdoLogBase10.Text = "Log Base 10"
        Me.rdoLogBase10.UseVisualStyleBackColor = True
        '
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbFunctions)
        Me.tbRegOptions.Controls.Add(Me.tbDistribution)
        Me.tbRegOptions.Location = New System.Drawing.Point(12, 12)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(213, 199)
        Me.tbRegOptions.TabIndex = 1
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
        Me.grpLinkFunctions.Cursor = System.Windows.Forms.Cursors.Default
        Me.grpLinkFunctions.Location = New System.Drawing.Point(9, 15)
        Me.grpLinkFunctions.Name = "grpLinkFunctions"
        Me.grpLinkFunctions.Size = New System.Drawing.Size(181, 134)
        Me.grpLinkFunctions.TabIndex = 12
        Me.grpLinkFunctions.TabStop = False
        Me.grpLinkFunctions.Tag = "Link_Functions"
        Me.grpLinkFunctions.Text = "Link Functions"
        '
        'rdoIdentity
        '
        Me.rdoIdentity.AutoSize = True
        Me.rdoIdentity.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoIdentity.Location = New System.Drawing.Point(9, 24)
        Me.rdoIdentity.Name = "rdoIdentity"
        Me.rdoIdentity.Size = New System.Drawing.Size(59, 17)
        Me.rdoIdentity.TabIndex = 6
        Me.rdoIdentity.TabStop = True
        Me.rdoIdentity.Tag = "Identity"
        Me.rdoIdentity.Text = "Identity"
        Me.rdoIdentity.UseVisualStyleBackColor = True
        '
        'rdoLog
        '
        Me.rdoLog.AutoSize = True
        Me.rdoLog.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoLog.Location = New System.Drawing.Point(9, 48)
        Me.rdoLog.Name = "rdoLog"
        Me.rdoLog.Size = New System.Drawing.Size(43, 17)
        Me.rdoLog.TabIndex = 7
        Me.rdoLog.TabStop = True
        Me.rdoLog.Tag = "Log"
        Me.rdoLog.Text = "Log"
        Me.rdoLog.UseVisualStyleBackColor = True
        '
        'rdoLogit
        '
        Me.rdoLogit.AutoSize = True
        Me.rdoLogit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoLogit.Location = New System.Drawing.Point(9, 71)
        Me.rdoLogit.Name = "rdoLogit"
        Me.rdoLogit.Size = New System.Drawing.Size(48, 17)
        Me.rdoLogit.TabIndex = 8
        Me.rdoLogit.TabStop = True
        Me.rdoLogit.Tag = "Logit"
        Me.rdoLogit.Text = "Logit"
        Me.rdoLogit.UseVisualStyleBackColor = True
        '
        'rdoProbit
        '
        Me.rdoProbit.AutoSize = True
        Me.rdoProbit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoProbit.Location = New System.Drawing.Point(9, 94)
        Me.rdoProbit.Name = "rdoProbit"
        Me.rdoProbit.Size = New System.Drawing.Size(52, 17)
        Me.rdoProbit.TabIndex = 9
        Me.rdoProbit.TabStop = True
        Me.rdoProbit.Tag = "Probit"
        Me.rdoProbit.Text = "Probit"
        Me.rdoProbit.UseVisualStyleBackColor = True
        '
        'rdoCauchit
        '
        Me.rdoCauchit.AutoSize = True
        Me.rdoCauchit.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoCauchit.Location = New System.Drawing.Point(9, 117)
        Me.rdoCauchit.Name = "rdoCauchit"
        Me.rdoCauchit.Size = New System.Drawing.Size(61, 17)
        Me.rdoCauchit.TabIndex = 10
        Me.rdoCauchit.TabStop = True
        Me.rdoCauchit.Tag = "Cauchit"
        Me.rdoCauchit.Text = "Cauchit"
        Me.rdoCauchit.UseVisualStyleBackColor = True
        '
        'rdoInverse
        '
        Me.rdoInverse.AutoSize = True
        Me.rdoInverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoInverse.Location = New System.Drawing.Point(116, 82)
        Me.rdoInverse.Name = "rdoInverse"
        Me.rdoInverse.Size = New System.Drawing.Size(60, 17)
        Me.rdoInverse.TabIndex = 11
        Me.rdoInverse.TabStop = True
        Me.rdoInverse.Tag = "Inverse"
        Me.rdoInverse.Text = "Inverse"
        Me.rdoInverse.UseVisualStyleBackColor = True
        '
        'rdoMuSquaredInverse
        '
        Me.rdoMuSquaredInverse.AutoSize = True
        Me.rdoMuSquaredInverse.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoMuSquaredInverse.Location = New System.Drawing.Point(116, 60)
        Me.rdoMuSquaredInverse.Name = "rdoMuSquaredInverse"
        Me.rdoMuSquaredInverse.Size = New System.Drawing.Size(62, 17)
        Me.rdoMuSquaredInverse.TabIndex = 12
        Me.rdoMuSquaredInverse.TabStop = True
        Me.rdoMuSquaredInverse.Tag = "1/mu^2"
        Me.rdoMuSquaredInverse.Text = "1/mu^2"
        Me.rdoMuSquaredInverse.UseVisualStyleBackColor = True
        '
        'rdoSqrt
        '
        Me.rdoSqrt.AutoSize = True
        Me.rdoSqrt.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdoSqrt.Location = New System.Drawing.Point(116, 42)
        Me.rdoSqrt.Name = "rdoSqrt"
        Me.rdoSqrt.Size = New System.Drawing.Size(44, 17)
        Me.rdoSqrt.TabIndex = 13
        Me.rdoSqrt.TabStop = True
        Me.rdoSqrt.Tag = "Sqrt"
        Me.rdoSqrt.Text = "Sqrt"
        Me.rdoSqrt.UseVisualStyleBackColor = True
        '
        'rdocloglog
        '
        Me.rdocloglog.AutoSize = True
        Me.rdocloglog.Cursor = System.Windows.Forms.Cursors.Default
        Me.rdocloglog.Location = New System.Drawing.Point(116, 19)
        Me.rdocloglog.Name = "rdocloglog"
        Me.rdocloglog.Size = New System.Drawing.Size(59, 17)
        Me.rdocloglog.TabIndex = 14
        Me.rdocloglog.TabStop = True
        Me.rdocloglog.Tag = "cloglog"
        Me.rdocloglog.Text = "cloglog"
        Me.rdocloglog.UseVisualStyleBackColor = True
        '
        'ucrButtonsSDGModelOptions
        '
        Me.ucrButtonsSDGModelOptions.Location = New System.Drawing.Point(41, 206)
        Me.ucrButtonsSDGModelOptions.Name = "ucrButtonsSDGModelOptions"
        Me.ucrButtonsSDGModelOptions.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSDGModelOptions.TabIndex = 0
        '
        'sdgModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(236, 242)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrButtonsSDGModelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgModelOptions"
        Me.Tag = "Model_Options"
        Me.Text = "Model Options"
        Me.tbDistribution.ResumeLayout(False)
        Me.tbFunctions.ResumeLayout(False)
        Me.grpGeneralFunctions.ResumeLayout(False)
        Me.grpGeneralFunctions.PerformLayout()
        CType(Me.nudPower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegOptions.ResumeLayout(False)
        Me.grpLinkFunctions.ResumeLayout(False)
        Me.grpLinkFunctions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSDGModelOptions As ucrButtonsSubdialogue
    Friend WithEvents tbDistribution As TabPage
    Friend WithEvents tbFunctions As TabPage
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents nudPower As NumericUpDown
    Friend WithEvents grpGeneralFunctions As GroupBox
    Friend WithEvents rdoNaturallog As RadioButton
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoSquareroot As RadioButton
    Friend WithEvents rdoLogBase10 As RadioButton
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
End Class
