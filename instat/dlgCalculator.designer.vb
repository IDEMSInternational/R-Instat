<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgCalculator
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
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmdDot = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdBackSpace = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.ucrInputExpression = New instat.ucrInputComboBox()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.ucrSpaceToMangeResult = New instat.ucrInputTextBox()
        Me.chkSaveResultInto = New System.Windows.Forms.CheckBox()
        Me.chkDefaultCalculationName = New System.Windows.Forms.CheckBox()
        Me.cmdGreaterThan = New System.Windows.Forms.Button()
        Me.ucrSaveResultInto = New instat.ucrInputComboBox()
        Me.SuspendLayout()
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(226, 123)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(29, 31)
        Me.cmd1.TabIndex = 80
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(226, 155)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(60, 30)
        Me.cmd0.TabIndex = 81
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(258, 123)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(28, 31)
        Me.cmd2.TabIndex = 82
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(288, 123)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(30, 31)
        Me.cmd3.TabIndex = 83
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(226, 90)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(29, 32)
        Me.cmd4.TabIndex = 84
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(258, 90)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(28, 32)
        Me.cmd5.TabIndex = 85
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(288, 90)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(30, 32)
        Me.cmd6.TabIndex = 86
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(226, 58)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(29, 30)
        Me.cmd7.TabIndex = 87
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(258, 58)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(28, 30)
        Me.cmd8.TabIndex = 88
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(288, 58)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(30, 30)
        Me.cmd9.TabIndex = 89
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Location = New System.Drawing.Point(349, 58)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(26, 30)
        Me.cmdDot.TabIndex = 90
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(320, 58)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(27, 30)
        Me.cmdDivide.TabIndex = 95
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(320, 155)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(27, 30)
        Me.cmdPlus.TabIndex = 94
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(320, 123)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(27, 31)
        Me.cmdMinus.TabIndex = 93
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(320, 90)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(27, 32)
        Me.cmdMultiply.TabIndex = 92
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(349, 155)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(26, 30)
        Me.cmdPower.TabIndex = 98
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(288, 155)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(30, 30)
        Me.cmdDelete.TabIndex = 97
        Me.cmdDelete.Tag = "Del"
        Me.cmdDelete.Text = "Del"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBackSpace
        '
        Me.cmdBackSpace.Location = New System.Drawing.Point(349, 90)
        Me.cmdBackSpace.Name = "cmdBackSpace"
        Me.cmdBackSpace.Size = New System.Drawing.Size(26, 32)
        Me.cmdBackSpace.TabIndex = 102
        Me.cmdBackSpace.Text = "<"
        Me.cmdBackSpace.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 306)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 50)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorForCalculations
        '
        Me.ucrSelectorForCalculations.bShowHiddenColumns = False
        Me.ucrSelectorForCalculations.Location = New System.Drawing.Point(9, 36)
        Me.ucrSelectorForCalculations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCalculations.Name = "ucrSelectorForCalculations"
        Me.ucrSelectorForCalculations.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorForCalculations.TabIndex = 106
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.Location = New System.Drawing.Point(12, 17)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(58, 13)
        Me.lblExpression.TabIndex = 107
        Me.lblExpression.Tag = "Expression"
        Me.lblExpression.Text = "Expression"
        '
        'ucrInputExpression
        '
        Me.ucrInputExpression.IsReadOnly = False
        Me.ucrInputExpression.Location = New System.Drawing.Point(98, 12)
        Me.ucrInputExpression.Name = "ucrInputExpression"
        Me.ucrInputExpression.Size = New System.Drawing.Size(399, 21)
        Me.ucrInputExpression.TabIndex = 108
        '
        'cmdTry
        '
        Me.cmdTry.Location = New System.Drawing.Point(9, 228)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(75, 23)
        Me.cmdTry.TabIndex = 110
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'ucrSpaceToMangeResult
        '
        Me.ucrSpaceToMangeResult.IsReadOnly = False
        Me.ucrSpaceToMangeResult.Location = New System.Drawing.Point(91, 229)
        Me.ucrSpaceToMangeResult.Name = "ucrSpaceToMangeResult"
        Me.ucrSpaceToMangeResult.Size = New System.Drawing.Size(284, 21)
        Me.ucrSpaceToMangeResult.TabIndex = 111
        '
        'chkSaveResultInto
        '
        Me.chkSaveResultInto.AutoSize = True
        Me.chkSaveResultInto.Location = New System.Drawing.Point(9, 260)
        Me.chkSaveResultInto.Name = "chkSaveResultInto"
        Me.chkSaveResultInto.Size = New System.Drawing.Size(104, 17)
        Me.chkSaveResultInto.TabIndex = 113
        Me.chkSaveResultInto.Text = "Save Result into"
        Me.chkSaveResultInto.UseVisualStyleBackColor = True
        '
        'chkDefaultCalculationName
        '
        Me.chkDefaultCalculationName.AutoSize = True
        Me.chkDefaultCalculationName.Location = New System.Drawing.Point(9, 283)
        Me.chkDefaultCalculationName.Name = "chkDefaultCalculationName"
        Me.chkDefaultCalculationName.Size = New System.Drawing.Size(144, 17)
        Me.chkDefaultCalculationName.TabIndex = 115
        Me.chkDefaultCalculationName.Text = "Default Calculation name"
        Me.chkDefaultCalculationName.UseVisualStyleBackColor = True
        '
        'cmdGreaterThan
        '
        Me.cmdGreaterThan.Location = New System.Drawing.Point(349, 123)
        Me.cmdGreaterThan.Name = "cmdGreaterThan"
        Me.cmdGreaterThan.Size = New System.Drawing.Size(26, 31)
        Me.cmdGreaterThan.TabIndex = 116
        Me.cmdGreaterThan.Text = ">"
        Me.cmdGreaterThan.UseVisualStyleBackColor = True
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.IsReadOnly = False
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(119, 257)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(256, 21)
        Me.ucrSaveResultInto.TabIndex = 117
        '
        'dlgCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 363)
        Me.Controls.Add(Me.ucrSaveResultInto)
        Me.Controls.Add(Me.cmdGreaterThan)
        Me.Controls.Add(Me.chkDefaultCalculationName)
        Me.Controls.Add(Me.chkSaveResultInto)
        Me.Controls.Add(Me.ucrSpaceToMangeResult)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrInputExpression)
        Me.Controls.Add(Me.lblExpression)
        Me.Controls.Add(Me.ucrSelectorForCalculations)
        Me.Controls.Add(Me.cmdBackSpace)
        Me.Controls.Add(Me.cmdPower)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdDivide)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdMinus)
        Me.Controls.Add(Me.cmdMultiply)
        Me.Controls.Add(Me.cmdDot)
        Me.Controls.Add(Me.cmd9)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd0)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Calculations"
        Me.Text = "Calculations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmdDot As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdBackSpace As Button
    Friend WithEvents ucrSelectorForCalculations As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblExpression As Label
    Friend WithEvents ucrInputExpression As ucrInputComboBox
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrSpaceToMangeResult As ucrInputTextBox
    Friend WithEvents chkSaveResultInto As CheckBox
    Friend WithEvents chkDefaultCalculationName As CheckBox
    Friend WithEvents cmdGreaterThan As Button
    Friend WithEvents ucrSaveResultInto As ucrInputComboBox
End Class
