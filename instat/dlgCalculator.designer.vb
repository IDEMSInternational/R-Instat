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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnPi = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnRowNumbers = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnOpenBracket = New System.Windows.Forms.Button()
        Me.btnCloseBracket = New System.Windows.Forms.Button()
        Me.lblNewColumnName = New System.Windows.Forms.Label()
        Me.txtNewColumnName = New System.Windows.Forms.TextBox()
        Me.btnBackSpace = New System.Windows.Forms.Button()
        Me.btnLog10 = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
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
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(29, 150)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(40, 40)
        Me.btn1.TabIndex = 80
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Location = New System.Drawing.Point(29, 196)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(40, 40)
        Me.btn0.TabIndex = 81
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(75, 150)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(40, 40)
        Me.btn2.TabIndex = 82
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(121, 150)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(40, 40)
        Me.btn3.TabIndex = 83
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(29, 104)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(40, 40)
        Me.btn4.TabIndex = 84
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Location = New System.Drawing.Point(75, 104)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(40, 40)
        Me.btn5.TabIndex = 85
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Location = New System.Drawing.Point(121, 104)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(40, 40)
        Me.btn6.TabIndex = 86
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Location = New System.Drawing.Point(29, 58)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(40, 40)
        Me.btn7.TabIndex = 87
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Location = New System.Drawing.Point(75, 58)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(40, 40)
        Me.btn8.TabIndex = 88
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
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
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(75, 196)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(40, 40)
        Me.btnDot.TabIndex = 90
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'btnPi
        '
        Me.btnPi.Location = New System.Drawing.Point(121, 196)
        Me.btnPi.Name = "btnPi"
        Me.btnPi.Size = New System.Drawing.Size(40, 40)
        Me.btnPi.TabIndex = 91
        Me.btnPi.Text = "Pi"
        Me.btnPi.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(167, 196)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(40, 40)
        Me.btnDivide.TabIndex = 95
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(167, 58)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 40)
        Me.btnPlus.TabIndex = 94
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnMinus
        '
        Me.btnMinus.Location = New System.Drawing.Point(167, 104)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(40, 40)
        Me.btnMinus.TabIndex = 93
        Me.btnMinus.Text = "-"
        Me.btnMinus.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(167, 150)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(40, 40)
        Me.btnMultiply.TabIndex = 92
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnRowNumbers
        '
        Me.btnRowNumbers.Location = New System.Drawing.Point(213, 196)
        Me.btnRowNumbers.Name = "btnRowNumbers"
        Me.btnRowNumbers.Size = New System.Drawing.Size(40, 40)
        Me.btnRowNumbers.TabIndex = 99
        Me.btnRowNumbers.Text = "Row Num"
        Me.btnRowNumbers.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(213, 58)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(40, 40)
        Me.btnPower.TabIndex = 98
        Me.btnPower.Text = "^"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnOpenBracket
        '
        Me.btnOpenBracket.Location = New System.Drawing.Point(213, 104)
        Me.btnOpenBracket.Name = "btnOpenBracket"
        Me.btnOpenBracket.Size = New System.Drawing.Size(40, 40)
        Me.btnOpenBracket.TabIndex = 97
        Me.btnOpenBracket.Text = "("
        Me.btnOpenBracket.UseVisualStyleBackColor = True
        '
        'btnCloseBracket
        '
        Me.btnCloseBracket.Location = New System.Drawing.Point(213, 150)
        Me.btnCloseBracket.Name = "btnCloseBracket"
        Me.btnCloseBracket.Size = New System.Drawing.Size(40, 40)
        Me.btnCloseBracket.TabIndex = 96
        Me.btnCloseBracket.Text = ")"
        Me.btnCloseBracket.UseVisualStyleBackColor = True
        '
        'lblNewColumnName
        '
        Me.lblNewColumnName.AutoSize = True
        Me.lblNewColumnName.Location = New System.Drawing.Point(26, 256)
        Me.lblNewColumnName.Name = "lblNewColumnName"
        Me.lblNewColumnName.Size = New System.Drawing.Size(101, 13)
        Me.lblNewColumnName.TabIndex = 100
        Me.lblNewColumnName.Tag = "Available _Variables "
        Me.lblNewColumnName.Text = "New Column Name:"
        '
        'txtNewColumnName
        '
        Me.txtNewColumnName.Location = New System.Drawing.Point(133, 253)
        Me.txtNewColumnName.Name = "txtNewColumnName"
        Me.txtNewColumnName.Size = New System.Drawing.Size(120, 20)
        Me.txtNewColumnName.TabIndex = 101
        '
        'btnBackSpace
        '
        Me.btnBackSpace.Location = New System.Drawing.Point(259, 58)
        Me.btnBackSpace.Name = "btnBackSpace"
        Me.btnBackSpace.Size = New System.Drawing.Size(61, 40)
        Me.btnBackSpace.TabIndex = 102
        Me.btnBackSpace.Text = "<"
        Me.btnBackSpace.UseVisualStyleBackColor = True
        '
        'btnLog10
        '
        Me.btnLog10.Location = New System.Drawing.Point(259, 196)
        Me.btnLog10.Name = "btnLog10"
        Me.btnLog10.Size = New System.Drawing.Size(61, 40)
        Me.btnLog10.TabIndex = 105
        Me.btnLog10.Text = "log10"
        Me.btnLog10.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(259, 104)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(61, 40)
        Me.btnSqrt.TabIndex = 104
        Me.btnSqrt.Text = "sqrt"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnExp
        '
        Me.btnExp.Location = New System.Drawing.Point(259, 150)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(61, 40)
        Me.btnExp.TabIndex = 103
        Me.btnExp.Text = "exp"
        Me.btnExp.UseVisualStyleBackColor = True
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
        Me.Controls.Add(Me.btnLog10)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnExp)
        Me.Controls.Add(Me.btnBackSpace)
        Me.Controls.Add(Me.txtNewColumnName)
        Me.Controls.Add(Me.lblNewColumnName)
        Me.Controls.Add(Me.btnRowNumbers)
        Me.Controls.Add(Me.btnPower)
        Me.Controls.Add(Me.btnOpenBracket)
        Me.Controls.Add(Me.btnCloseBracket)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnPi)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.txtCalcLine)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents txtCalcLine As TextBox
    Friend WithEvents btn1 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnPi As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnRowNumbers As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnOpenBracket As Button
    Friend WithEvents btnCloseBracket As Button
    Friend WithEvents lblNewColumnName As Label
    Friend WithEvents txtNewColumnName As TextBox
    Friend WithEvents btnBackSpace As Button
    Friend WithEvents btnLog10 As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnExp As Button
End Class
