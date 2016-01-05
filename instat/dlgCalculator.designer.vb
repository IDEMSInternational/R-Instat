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
        Me.txtCalcLine = New System.Windows.Forms.TextBox()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.cmdDot = New System.Windows.Forms.Button()
        Me.cmdPi = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdRowNumbers = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdOpenBracket = New System.Windows.Forms.Button()
        Me.cmdCloseBracket = New System.Windows.Forms.Button()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.txtNewColumnName = New System.Windows.Forms.TextBox()
        Me.cmdBackSpace = New System.Windows.Forms.Button()
        Me.cmdLog10 = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdExp = New System.Windows.Forms.Button()
        Me.ucrBase = New instat.ucrButtons()
        Me.SuspendLayout()
        '
        'txtCalcLine
        '
        Me.txtCalcLine.Location = New System.Drawing.Point(16, 23)
        Me.txtCalcLine.Name = "txtCalcLine"
        Me.txtCalcLine.Size = New System.Drawing.Size(404, 20)
        Me.txtCalcLine.TabIndex = 79
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(29, 150)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(40, 40)
        Me.cmd1.TabIndex = 80
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(29, 196)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(40, 40)
        Me.cmd0.TabIndex = 81
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(75, 150)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(40, 40)
        Me.cmd2.TabIndex = 82
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(121, 150)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(40, 40)
        Me.cmd3.TabIndex = 83
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(29, 104)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(40, 40)
        Me.cmd4.TabIndex = 84
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(75, 104)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(40, 40)
        Me.cmd5.TabIndex = 85
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(121, 104)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(40, 40)
        Me.cmd6.TabIndex = 86
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(29, 58)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(40, 40)
        Me.cmd7.TabIndex = 87
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(75, 58)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(40, 40)
        Me.cmd8.TabIndex = 88
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Location = New System.Drawing.Point(121, 58)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(40, 40)
        Me.btn9.TabIndex = 89
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Location = New System.Drawing.Point(75, 196)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(40, 40)
        Me.cmdDot.TabIndex = 90
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.Location = New System.Drawing.Point(121, 196)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(40, 40)
        Me.cmdPi.TabIndex = 91
        Me.cmdPi.Text = "Pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(167, 196)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(40, 40)
        Me.cmdDivide.TabIndex = 95
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(167, 58)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(40, 40)
        Me.cmdPlus.TabIndex = 94
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(167, 104)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(40, 40)
        Me.cmdMinus.TabIndex = 93
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(167, 150)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(40, 40)
        Me.cmdMultiply.TabIndex = 92
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdRowNumbers
        '
        Me.cmdRowNumbers.Location = New System.Drawing.Point(213, 196)
        Me.cmdRowNumbers.Name = "cmdRowNumbers"
        Me.cmdRowNumbers.Size = New System.Drawing.Size(40, 40)
        Me.cmdRowNumbers.TabIndex = 99
        Me.cmdRowNumbers.Text = "Row Num"
        Me.cmdRowNumbers.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(213, 58)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(40, 40)
        Me.cmdPower.TabIndex = 98
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdOpenBracket
        '
        Me.cmdOpenBracket.Location = New System.Drawing.Point(213, 104)
        Me.cmdOpenBracket.Name = "cmdOpenBracket"
        Me.cmdOpenBracket.Size = New System.Drawing.Size(40, 40)
        Me.cmdOpenBracket.TabIndex = 97
        Me.cmdOpenBracket.Text = "("
        Me.cmdOpenBracket.UseVisualStyleBackColor = True
        '
        'cmdCloseBracket
        '
        Me.cmdCloseBracket.Location = New System.Drawing.Point(213, 150)
        Me.cmdCloseBracket.Name = "cmdCloseBracket"
        Me.cmdCloseBracket.Size = New System.Drawing.Size(40, 40)
        Me.cmdCloseBracket.TabIndex = 96
        Me.cmdCloseBracket.Text = ")"
        Me.cmdCloseBracket.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(26, 256)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 100
        Me.lblNewColumnName.Tag = "New_Column_Name"
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'txtNewColumnName
        '
        Me.txtNewColumnName.Location = New System.Drawing.Point(133, 253)
        Me.txtNewColumnName.Name = "txtNewColumnName"
        Me.txtNewColumnName.Size = New System.Drawing.Size(120, 20)
        Me.txtNewColumnName.TabIndex = 101
        '
        'cmdBackSpace
        '
        Me.cmdBackSpace.Location = New System.Drawing.Point(259, 58)
        Me.cmdBackSpace.Name = "cmdBackSpace"
        Me.cmdBackSpace.Size = New System.Drawing.Size(61, 40)
        Me.cmdBackSpace.TabIndex = 102
        Me.cmdBackSpace.Text = "<"
        Me.cmdBackSpace.UseVisualStyleBackColor = True
        '
        'cmdLog10
        '
        Me.cmdLog10.Location = New System.Drawing.Point(259, 196)
        Me.cmdLog10.Name = "cmdLog10"
        Me.cmdLog10.Size = New System.Drawing.Size(61, 40)
        Me.cmdLog10.TabIndex = 105
        Me.cmdLog10.Text = "log10"
        Me.cmdLog10.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Location = New System.Drawing.Point(259, 104)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(61, 40)
        Me.cmdSqrt.TabIndex = 104
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.Location = New System.Drawing.Point(259, 150)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(61, 40)
        Me.cmdExp.TabIndex = 103
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(16, 281)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 32)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(449, 320)
        Me.Controls.Add(Me.cmdLog10)
        Me.Controls.Add(Me.cmdSqrt)
        Me.Controls.Add(Me.cmdExp)
        Me.Controls.Add(Me.cmdBackSpace)
        Me.Controls.Add(Me.txtNewColumnName)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.cmdRowNumbers)
        Me.Controls.Add(Me.cmdPower)
        Me.Controls.Add(Me.cmdOpenBracket)
        Me.Controls.Add(Me.cmdCloseBracket)
        Me.Controls.Add(Me.cmdDivide)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.cmdMinus)
        Me.Controls.Add(Me.cmdMultiply)
        Me.Controls.Add(Me.cmdPi)
        Me.Controls.Add(Me.cmdDot)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.cmd8)
        Me.Controls.Add(Me.cmd7)
        Me.Controls.Add(Me.cmd6)
        Me.Controls.Add(Me.cmd5)
        Me.Controls.Add(Me.cmd4)
        Me.Controls.Add(Me.cmd3)
        Me.Controls.Add(Me.cmd2)
        Me.Controls.Add(Me.cmd0)
        Me.Controls.Add(Me.cmd1)
        Me.Controls.Add(Me.txtCalcLine)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtCalcLine As TextBox
    Friend WithEvents cmd1 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents cmdDot As Button
    Friend WithEvents cmdPi As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdRowNumbers As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdOpenBracket As Button
    Friend WithEvents cmdCloseBracket As Button
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents txtNewColumnName As TextBox
    Friend WithEvents cmdBackSpace As Button
    Friend WithEvents cmdLog10 As Button
    Friend WithEvents cmdSqrt As Button
    Friend WithEvents cmdExp As Button
End Class
