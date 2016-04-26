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
        Me.grpLinkFunctions = New System.Windows.Forms.GroupBox()
        Me.chkSqrt = New System.Windows.Forms.CheckBox()
        Me.chkMuSquaredInverse = New System.Windows.Forms.CheckBox()
        Me.chkInverse = New System.Windows.Forms.CheckBox()
        Me.chkProbit = New System.Windows.Forms.CheckBox()
        Me.chkCauchit = New System.Windows.Forms.CheckBox()
        Me.chkcloglog = New System.Windows.Forms.CheckBox()
        Me.chkLogLink = New System.Windows.Forms.CheckBox()
        Me.chkLogit = New System.Windows.Forms.CheckBox()
        Me.chkIdentity = New System.Windows.Forms.CheckBox()
        Me.tbFunctions = New System.Windows.Forms.TabPage()
        Me.nudPower = New System.Windows.Forms.NumericUpDown()
        Me.tbRegOptions = New System.Windows.Forms.TabControl()
        Me.ucrButtonsSDGModelOptions = New instat.ucrButtonsSubdialogue()
        Me.rdoNaturallog = New System.Windows.Forms.RadioButton()
        Me.rdoLogBase10 = New System.Windows.Forms.RadioButton()
        Me.rdoPower = New System.Windows.Forms.RadioButton()
        Me.rdoSquareroot = New System.Windows.Forms.RadioButton()
        Me.grpGeneralFunctions = New System.Windows.Forms.GroupBox()
        Me.tbDistribution.SuspendLayout()
        Me.grpLinkFunctions.SuspendLayout()
        Me.tbFunctions.SuspendLayout()
        CType(Me.nudPower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbRegOptions.SuspendLayout()
        Me.grpGeneralFunctions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbDistribution
        '
        Me.tbDistribution.Controls.Add(Me.grpLinkFunctions)
        Me.tbDistribution.Location = New System.Drawing.Point(4, 22)
        Me.tbDistribution.Name = "tbDistribution"
        Me.tbDistribution.Padding = New System.Windows.Forms.Padding(3)
        Me.tbDistribution.Size = New System.Drawing.Size(219, 157)
        Me.tbDistribution.TabIndex = 2
        Me.tbDistribution.Tag = "Distribution"
        Me.tbDistribution.Text = "Distribution"
        Me.tbDistribution.UseVisualStyleBackColor = True
        Me.tbDistribution.UseWaitCursor = True
        '
        'grpLinkFunctions
        '
        Me.grpLinkFunctions.Controls.Add(Me.chkSqrt)
        Me.grpLinkFunctions.Controls.Add(Me.chkMuSquaredInverse)
        Me.grpLinkFunctions.Controls.Add(Me.chkInverse)
        Me.grpLinkFunctions.Controls.Add(Me.chkProbit)
        Me.grpLinkFunctions.Controls.Add(Me.chkCauchit)
        Me.grpLinkFunctions.Controls.Add(Me.chkcloglog)
        Me.grpLinkFunctions.Controls.Add(Me.chkLogLink)
        Me.grpLinkFunctions.Controls.Add(Me.chkLogit)
        Me.grpLinkFunctions.Controls.Add(Me.chkIdentity)
        Me.grpLinkFunctions.Location = New System.Drawing.Point(6, 6)
        Me.grpLinkFunctions.Name = "grpLinkFunctions"
        Me.grpLinkFunctions.Size = New System.Drawing.Size(203, 145)
        Me.grpLinkFunctions.TabIndex = 2
        Me.grpLinkFunctions.TabStop = False
        Me.grpLinkFunctions.Tag = "Link_Function"
        Me.grpLinkFunctions.Text = "Link Function"
        Me.grpLinkFunctions.UseWaitCursor = True
        '
        'chkSqrt
        '
        Me.chkSqrt.AutoSize = True
        Me.chkSqrt.Location = New System.Drawing.Point(127, 46)
        Me.chkSqrt.Name = "chkSqrt"
        Me.chkSqrt.Size = New System.Drawing.Size(45, 17)
        Me.chkSqrt.TabIndex = 10
        Me.chkSqrt.Tag = "Sqrt"
        Me.chkSqrt.Text = "Sqrt"
        Me.chkSqrt.UseVisualStyleBackColor = True
        Me.chkSqrt.UseWaitCursor = True
        '
        'chkMuSquaredInverse
        '
        Me.chkMuSquaredInverse.AutoSize = True
        Me.chkMuSquaredInverse.Location = New System.Drawing.Point(127, 73)
        Me.chkMuSquaredInverse.Name = "chkMuSquaredInverse"
        Me.chkMuSquaredInverse.Size = New System.Drawing.Size(63, 17)
        Me.chkMuSquaredInverse.TabIndex = 7
        Me.chkMuSquaredInverse.Tag = "1/mu^2"
        Me.chkMuSquaredInverse.Text = "1/mu^2"
        Me.chkMuSquaredInverse.UseVisualStyleBackColor = True
        Me.chkMuSquaredInverse.UseWaitCursor = True
        '
        'chkInverse
        '
        Me.chkInverse.AutoSize = True
        Me.chkInverse.Location = New System.Drawing.Point(127, 99)
        Me.chkInverse.Name = "chkInverse"
        Me.chkInverse.Size = New System.Drawing.Size(61, 17)
        Me.chkInverse.TabIndex = 6
        Me.chkInverse.Tag = "Inverse"
        Me.chkInverse.Text = "Inverse"
        Me.chkInverse.UseVisualStyleBackColor = True
        Me.chkInverse.UseWaitCursor = True
        '
        'chkProbit
        '
        Me.chkProbit.AutoSize = True
        Me.chkProbit.Location = New System.Drawing.Point(19, 99)
        Me.chkProbit.Name = "chkProbit"
        Me.chkProbit.Size = New System.Drawing.Size(53, 17)
        Me.chkProbit.TabIndex = 5
        Me.chkProbit.Tag = "Probit"
        Me.chkProbit.Text = "Probit"
        Me.chkProbit.UseVisualStyleBackColor = True
        Me.chkProbit.UseWaitCursor = True
        '
        'chkCauchit
        '
        Me.chkCauchit.AutoSize = True
        Me.chkCauchit.Location = New System.Drawing.Point(19, 122)
        Me.chkCauchit.Name = "chkCauchit"
        Me.chkCauchit.Size = New System.Drawing.Size(62, 17)
        Me.chkCauchit.TabIndex = 4
        Me.chkCauchit.Tag = "Cauchit"
        Me.chkCauchit.Text = "Cauchit"
        Me.chkCauchit.UseVisualStyleBackColor = True
        Me.chkCauchit.UseWaitCursor = True
        '
        'chkcloglog
        '
        Me.chkcloglog.AutoSize = True
        Me.chkcloglog.Location = New System.Drawing.Point(127, 19)
        Me.chkcloglog.Name = "chkcloglog"
        Me.chkcloglog.Size = New System.Drawing.Size(60, 17)
        Me.chkcloglog.TabIndex = 3
        Me.chkcloglog.Tag = "cloglog"
        Me.chkcloglog.Text = "cloglog"
        Me.chkcloglog.UseVisualStyleBackColor = True
        Me.chkcloglog.UseWaitCursor = True
        '
        'chkLogLink
        '
        Me.chkLogLink.AutoSize = True
        Me.chkLogLink.Location = New System.Drawing.Point(19, 46)
        Me.chkLogLink.Name = "chkLogLink"
        Me.chkLogLink.Size = New System.Drawing.Size(44, 17)
        Me.chkLogLink.TabIndex = 2
        Me.chkLogLink.Tag = "Log"
        Me.chkLogLink.Text = "Log"
        Me.chkLogLink.UseVisualStyleBackColor = True
        Me.chkLogLink.UseWaitCursor = True
        '
        'chkLogit
        '
        Me.chkLogit.AccessibleName = "1"
        Me.chkLogit.AutoSize = True
        Me.chkLogit.Location = New System.Drawing.Point(19, 73)
        Me.chkLogit.Name = "chkLogit"
        Me.chkLogit.Size = New System.Drawing.Size(49, 17)
        Me.chkLogit.TabIndex = 1
        Me.chkLogit.Tag = "Logit"
        Me.chkLogit.Text = "Logit"
        Me.chkLogit.UseVisualStyleBackColor = True
        Me.chkLogit.UseWaitCursor = True
        '
        'chkIdentity
        '
        Me.chkIdentity.AutoSize = True
        Me.chkIdentity.Location = New System.Drawing.Point(19, 19)
        Me.chkIdentity.Name = "chkIdentity"
        Me.chkIdentity.Size = New System.Drawing.Size(60, 17)
        Me.chkIdentity.TabIndex = 0
        Me.chkIdentity.Tag = "Identity"
        Me.chkIdentity.Text = "Identity"
        Me.chkIdentity.UseVisualStyleBackColor = True
        Me.chkIdentity.UseWaitCursor = True
        '
        'tbFunctions
        '
        Me.tbFunctions.Controls.Add(Me.grpGeneralFunctions)
        Me.tbFunctions.Location = New System.Drawing.Point(4, 22)
        Me.tbFunctions.Name = "tbFunctions"
        Me.tbFunctions.Padding = New System.Windows.Forms.Padding(3)
        Me.tbFunctions.Size = New System.Drawing.Size(219, 157)
        Me.tbFunctions.TabIndex = 1
        Me.tbFunctions.Tag = "Functions"
        Me.tbFunctions.Text = "Functions"
        Me.tbFunctions.UseVisualStyleBackColor = True
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
        'tbRegOptions
        '
        Me.tbRegOptions.Controls.Add(Me.tbFunctions)
        Me.tbRegOptions.Controls.Add(Me.tbDistribution)
        Me.tbRegOptions.Location = New System.Drawing.Point(12, 12)
        Me.tbRegOptions.Name = "tbRegOptions"
        Me.tbRegOptions.SelectedIndex = 0
        Me.tbRegOptions.Size = New System.Drawing.Size(227, 183)
        Me.tbRegOptions.TabIndex = 1
        '
        'ucrButtonsSDGModelOptions
        '
        Me.ucrButtonsSDGModelOptions.Location = New System.Drawing.Point(41, 201)
        Me.ucrButtonsSDGModelOptions.Name = "ucrButtonsSDGModelOptions"
        Me.ucrButtonsSDGModelOptions.Size = New System.Drawing.Size(142, 30)
        Me.ucrButtonsSDGModelOptions.TabIndex = 0
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
        'sdgModelOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 231)
        Me.Controls.Add(Me.tbRegOptions)
        Me.Controls.Add(Me.ucrButtonsSDGModelOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgModelOptions"
        Me.Tag = "Model_Options"
        Me.Text = "Model Options"
        Me.tbDistribution.ResumeLayout(False)
        Me.grpLinkFunctions.ResumeLayout(False)
        Me.grpLinkFunctions.PerformLayout()
        Me.tbFunctions.ResumeLayout(False)
        CType(Me.nudPower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbRegOptions.ResumeLayout(False)
        Me.grpGeneralFunctions.ResumeLayout(False)
        Me.grpGeneralFunctions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrButtonsSDGModelOptions As ucrButtonsSubdialogue
    Friend WithEvents tbDistribution As TabPage
    Friend WithEvents grpLinkFunctions As GroupBox
    Friend WithEvents chkInverse As CheckBox
    Friend WithEvents chkProbit As CheckBox
    Friend WithEvents chkCauchit As CheckBox
    Friend WithEvents chkcloglog As CheckBox
    Friend WithEvents chkLogLink As CheckBox
    Friend WithEvents chkLogit As CheckBox
    Friend WithEvents chkIdentity As CheckBox
    Friend WithEvents tbFunctions As TabPage
    Friend WithEvents tbRegOptions As TabControl
    Friend WithEvents chkSqrt As CheckBox
    Friend WithEvents chkMuSquaredInverse As CheckBox
    Friend WithEvents nudPower As NumericUpDown
    Friend WithEvents grpGeneralFunctions As GroupBox
    Friend WithEvents rdoNaturallog As RadioButton
    Friend WithEvents rdoPower As RadioButton
    Friend WithEvents rdoSquareroot As RadioButton
    Friend WithEvents rdoLogBase10 As RadioButton
End Class
