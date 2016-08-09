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
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.chkSaveResultInto = New System.Windows.Forms.CheckBox()
        Me.chkDefaultCalculationName = New System.Windows.Forms.CheckBox()
        Me.grpBasic = New System.Windows.Forms.GroupBox()
        Me.cmdGreaterThan = New System.Windows.Forms.Button()
        Me.cmdLessThan = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdDivide = New System.Windows.Forms.Button()
        Me.cmdPlus = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.Button()
        Me.cmdMultiply = New System.Windows.Forms.Button()
        Me.cmdDot = New System.Windows.Forms.Button()
        Me.cmd9 = New System.Windows.Forms.Button()
        Me.cmd8 = New System.Windows.Forms.Button()
        Me.cmd7 = New System.Windows.Forms.Button()
        Me.cmd6 = New System.Windows.Forms.Button()
        Me.cmd5 = New System.Windows.Forms.Button()
        Me.cmd4 = New System.Windows.Forms.Button()
        Me.cmd3 = New System.Windows.Forms.Button()
        Me.cmd2 = New System.Windows.Forms.Button()
        Me.cmd0 = New System.Windows.Forms.Button()
        Me.cmd1 = New System.Windows.Forms.Button()
        Me.grpLogical = New System.Windows.Forms.GroupBox()
        Me.grpMaths = New System.Windows.Forms.GroupBox()
        Me.cmdSign = New System.Windows.Forms.Button()
        Me.cmdRound = New System.Windows.Forms.Button()
        Me.cmdSiginf = New System.Windows.Forms.Button()
        Me.cmdAbs = New System.Windows.Forms.Button()
        Me.cmdExp = New System.Windows.Forms.Button()
        Me.cmdDeg = New System.Windows.Forms.Button()
        Me.cmdTrunc = New System.Windows.Forms.Button()
        Me.cmdAtan = New System.Windows.Forms.Button()
        Me.cmdTan = New System.Windows.Forms.Button()
        Me.cmdLogTen = New System.Windows.Forms.Button()
        Me.cmdRad = New System.Windows.Forms.Button()
        Me.cmdFloor = New System.Windows.Forms.Button()
        Me.cmdAsin = New System.Windows.Forms.Button()
        Me.cmdSin = New System.Windows.Forms.Button()
        Me.cmdLog = New System.Windows.Forms.Button()
        Me.cmdPi = New System.Windows.Forms.Button()
        Me.cmdCeiling = New System.Windows.Forms.Button()
        Me.cmdAcos = New System.Windows.Forms.Button()
        Me.cmdCos = New System.Windows.Forms.Button()
        Me.cmdSqrt = New System.Windows.Forms.Button()
        Me.cmdGreaterOrEqualsTo = New System.Windows.Forms.Button()
        Me.cmdAnd = New System.Windows.Forms.Button()
        Me.cmdTrue = New System.Windows.Forms.Button()
        Me.cmdIntegerDivision = New System.Windows.Forms.Button()
        Me.cmdModulas = New System.Windows.Forms.Button()
        Me.cmdGreater = New System.Windows.Forms.Button()
        Me.cmdLesserOrEqualsTo = New System.Windows.Forms.Button()
        Me.cmdLesser = New System.Windows.Forms.Button()
        Me.cmdOr = New System.Windows.Forms.Button()
        Me.cmdNot = New System.Windows.Forms.Button()
        Me.cmdNotEqualsTo = New System.Windows.Forms.Button()
        Me.cmdEquivalent = New System.Windows.Forms.Button()
        Me.ucrInputCalOptions = New instat.ucrInputComboBox()
        Me.ucrReceiverForCalculation = New instat.ucrReceiverExpression()
        Me.ucrSaveResultInto = New instat.ucrInputComboBox()
        Me.ucrSpaceToMangeResult = New instat.ucrInputTextBox()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpBasic.SuspendLayout()
        Me.grpLogical.SuspendLayout()
        Me.grpMaths.SuspendLayout()
        Me.SuspendLayout()
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
        'cmdTry
        '
        Me.cmdTry.Location = New System.Drawing.Point(9, 228)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(75, 23)
        Me.cmdTry.TabIndex = 110
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
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
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.cmdGreaterThan)
        Me.grpBasic.Controls.Add(Me.cmdLessThan)
        Me.grpBasic.Controls.Add(Me.cmdPower)
        Me.grpBasic.Controls.Add(Me.cmdDelete)
        Me.grpBasic.Controls.Add(Me.cmdDivide)
        Me.grpBasic.Controls.Add(Me.cmdPlus)
        Me.grpBasic.Controls.Add(Me.cmdMinus)
        Me.grpBasic.Controls.Add(Me.cmdMultiply)
        Me.grpBasic.Controls.Add(Me.cmdDot)
        Me.grpBasic.Controls.Add(Me.cmd9)
        Me.grpBasic.Controls.Add(Me.cmd8)
        Me.grpBasic.Controls.Add(Me.cmd7)
        Me.grpBasic.Controls.Add(Me.cmd6)
        Me.grpBasic.Controls.Add(Me.cmd5)
        Me.grpBasic.Controls.Add(Me.cmd4)
        Me.grpBasic.Controls.Add(Me.cmd3)
        Me.grpBasic.Controls.Add(Me.cmd2)
        Me.grpBasic.Controls.Add(Me.cmd0)
        Me.grpBasic.Controls.Add(Me.cmd1)
        Me.grpBasic.Location = New System.Drawing.Point(222, 69)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Size = New System.Drawing.Size(153, 147)
        Me.grpBasic.TabIndex = 119
        Me.grpBasic.TabStop = False
        Me.grpBasic.Text = "Basic"
        '
        'cmdGreaterThan
        '
        Me.cmdGreaterThan.Location = New System.Drawing.Point(126, 78)
        Me.cmdGreaterThan.Name = "cmdGreaterThan"
        Me.cmdGreaterThan.Size = New System.Drawing.Size(26, 31)
        Me.cmdGreaterThan.TabIndex = 135
        Me.cmdGreaterThan.Text = ">"
        Me.cmdGreaterThan.UseVisualStyleBackColor = True
        '
        'cmdLessThan
        '
        Me.cmdLessThan.Location = New System.Drawing.Point(126, 45)
        Me.cmdLessThan.Name = "cmdLessThan"
        Me.cmdLessThan.Size = New System.Drawing.Size(26, 32)
        Me.cmdLessThan.TabIndex = 134
        Me.cmdLessThan.Text = "<"
        Me.cmdLessThan.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(126, 110)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(26, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(3, 110)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(60, 30)
        Me.cmdDelete.TabIndex = 132
        Me.cmdDelete.Tag = "Del"
        Me.cmdDelete.Text = "Del"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(97, 13)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(27, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(97, 110)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(27, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(97, 78)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(27, 31)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(97, 45)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(27, 32)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Location = New System.Drawing.Point(126, 13)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(26, 30)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(65, 13)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(30, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(35, 13)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(28, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(3, 13)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(29, 30)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(65, 45)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(30, 32)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(35, 45)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(28, 32)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(3, 45)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(29, 32)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(65, 78)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(30, 31)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(35, 78)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(28, 31)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(65, 110)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(30, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(3, 78)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(29, 31)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'grpLogical
        '
        Me.grpLogical.Controls.Add(Me.cmdGreaterOrEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdAnd)
        Me.grpLogical.Controls.Add(Me.cmdTrue)
        Me.grpLogical.Controls.Add(Me.cmdIntegerDivision)
        Me.grpLogical.Controls.Add(Me.cmdModulas)
        Me.grpLogical.Controls.Add(Me.cmdGreater)
        Me.grpLogical.Controls.Add(Me.cmdLesserOrEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdLesser)
        Me.grpLogical.Controls.Add(Me.cmdOr)
        Me.grpLogical.Controls.Add(Me.cmdNot)
        Me.grpLogical.Controls.Add(Me.cmdNotEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdEquivalent)
        Me.grpLogical.Location = New System.Drawing.Point(3, 0)
        Me.grpLogical.Name = "grpLogical"
        Me.grpLogical.Size = New System.Drawing.Size(116, 158)
        Me.grpLogical.TabIndex = 121
        Me.grpLogical.TabStop = False
        Me.grpLogical.Text = "Logical"
        '
        'grpMaths
        '
        Me.grpMaths.Controls.Add(Me.cmdSign)
        Me.grpMaths.Controls.Add(Me.grpLogical)
        Me.grpMaths.Controls.Add(Me.cmdRound)
        Me.grpMaths.Controls.Add(Me.cmdSiginf)
        Me.grpMaths.Controls.Add(Me.cmdAbs)
        Me.grpMaths.Controls.Add(Me.cmdExp)
        Me.grpMaths.Controls.Add(Me.cmdDeg)
        Me.grpMaths.Controls.Add(Me.cmdTrunc)
        Me.grpMaths.Controls.Add(Me.cmdAtan)
        Me.grpMaths.Controls.Add(Me.cmdTan)
        Me.grpMaths.Controls.Add(Me.cmdLogTen)
        Me.grpMaths.Controls.Add(Me.cmdRad)
        Me.grpMaths.Controls.Add(Me.cmdFloor)
        Me.grpMaths.Controls.Add(Me.cmdAsin)
        Me.grpMaths.Controls.Add(Me.cmdSin)
        Me.grpMaths.Controls.Add(Me.cmdLog)
        Me.grpMaths.Controls.Add(Me.cmdPi)
        Me.grpMaths.Controls.Add(Me.cmdCeiling)
        Me.grpMaths.Controls.Add(Me.cmdAcos)
        Me.grpMaths.Controls.Add(Me.cmdCos)
        Me.grpMaths.Controls.Add(Me.cmdSqrt)
        Me.grpMaths.Location = New System.Drawing.Point(375, 69)
        Me.grpMaths.Name = "grpMaths"
        Me.grpMaths.Size = New System.Drawing.Size(208, 148)
        Me.grpMaths.TabIndex = 148
        Me.grpMaths.TabStop = False
        Me.grpMaths.Text = "Maths"
        '
        'cmdSign
        '
        Me.cmdSign.Location = New System.Drawing.Point(166, 112)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(38, 30)
        Me.cmdSign.TabIndex = 147
        Me.cmdSign.Text = "sign"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmdRound
        '
        Me.cmdRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRound.Location = New System.Drawing.Point(125, 112)
        Me.cmdRound.Name = "cmdRound"
        Me.cmdRound.Size = New System.Drawing.Size(38, 30)
        Me.cmdRound.TabIndex = 146
        Me.cmdRound.Text = "round"
        Me.cmdRound.UseVisualStyleBackColor = True
        '
        'cmdSiginf
        '
        Me.cmdSiginf.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiginf.Location = New System.Drawing.Point(84, 112)
        Me.cmdSiginf.Name = "cmdSiginf"
        Me.cmdSiginf.Size = New System.Drawing.Size(38, 30)
        Me.cmdSiginf.TabIndex = 145
        Me.cmdSiginf.Text = "siginf"
        Me.cmdSiginf.UseVisualStyleBackColor = True
        '
        'cmdAbs
        '
        Me.cmdAbs.Location = New System.Drawing.Point(43, 112)
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.Size = New System.Drawing.Size(38, 30)
        Me.cmdAbs.TabIndex = 144
        Me.cmdAbs.Text = "abs"
        Me.cmdAbs.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.Location = New System.Drawing.Point(3, 112)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(38, 30)
        Me.cmdExp.TabIndex = 143
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdDeg
        '
        Me.cmdDeg.Location = New System.Drawing.Point(166, 80)
        Me.cmdDeg.Name = "cmdDeg"
        Me.cmdDeg.Size = New System.Drawing.Size(38, 30)
        Me.cmdDeg.TabIndex = 142
        Me.cmdDeg.Text = "deg"
        Me.cmdDeg.UseVisualStyleBackColor = True
        '
        'cmdTrunc
        '
        Me.cmdTrunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrunc.Location = New System.Drawing.Point(125, 80)
        Me.cmdTrunc.Name = "cmdTrunc"
        Me.cmdTrunc.Size = New System.Drawing.Size(38, 30)
        Me.cmdTrunc.TabIndex = 141
        Me.cmdTrunc.Text = "trunc"
        Me.cmdTrunc.UseVisualStyleBackColor = True
        '
        'cmdAtan
        '
        Me.cmdAtan.Location = New System.Drawing.Point(84, 80)
        Me.cmdAtan.Name = "cmdAtan"
        Me.cmdAtan.Size = New System.Drawing.Size(38, 30)
        Me.cmdAtan.TabIndex = 140
        Me.cmdAtan.Text = "atan"
        Me.cmdAtan.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.Location = New System.Drawing.Point(43, 80)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(38, 30)
        Me.cmdTan.TabIndex = 139
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdLogTen
        '
        Me.cmdLogTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogTen.Location = New System.Drawing.Point(3, 80)
        Me.cmdLogTen.Name = "cmdLogTen"
        Me.cmdLogTen.Size = New System.Drawing.Size(38, 30)
        Me.cmdLogTen.TabIndex = 138
        Me.cmdLogTen.Text = "log10"
        Me.cmdLogTen.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        Me.cmdRad.Location = New System.Drawing.Point(166, 47)
        Me.cmdRad.Name = "cmdRad"
        Me.cmdRad.Size = New System.Drawing.Size(38, 30)
        Me.cmdRad.TabIndex = 137
        Me.cmdRad.Text = "rad"
        Me.cmdRad.UseVisualStyleBackColor = True
        '
        'cmdFloor
        '
        Me.cmdFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFloor.Location = New System.Drawing.Point(125, 47)
        Me.cmdFloor.Name = "cmdFloor"
        Me.cmdFloor.Size = New System.Drawing.Size(38, 30)
        Me.cmdFloor.TabIndex = 136
        Me.cmdFloor.Text = "floor"
        Me.cmdFloor.UseVisualStyleBackColor = True
        '
        'cmdAsin
        '
        Me.cmdAsin.Location = New System.Drawing.Point(84, 47)
        Me.cmdAsin.Name = "cmdAsin"
        Me.cmdAsin.Size = New System.Drawing.Size(38, 30)
        Me.cmdAsin.TabIndex = 135
        Me.cmdAsin.Text = "asin"
        Me.cmdAsin.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.Location = New System.Drawing.Point(43, 47)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(38, 30)
        Me.cmdSin.TabIndex = 134
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.Location = New System.Drawing.Point(3, 47)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(38, 30)
        Me.cmdLog.TabIndex = 133
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.Location = New System.Drawing.Point(166, 15)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(38, 30)
        Me.cmdPi.TabIndex = 132
        Me.cmdPi.Text = "pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdCeiling
        '
        Me.cmdCeiling.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCeiling.Location = New System.Drawing.Point(125, 15)
        Me.cmdCeiling.Name = "cmdCeiling"
        Me.cmdCeiling.Size = New System.Drawing.Size(38, 30)
        Me.cmdCeiling.TabIndex = 131
        Me.cmdCeiling.Text = "ceiling"
        Me.cmdCeiling.UseVisualStyleBackColor = True
        '
        'cmdAcos
        '
        Me.cmdAcos.Location = New System.Drawing.Point(84, 15)
        Me.cmdAcos.Name = "cmdAcos"
        Me.cmdAcos.Size = New System.Drawing.Size(38, 30)
        Me.cmdAcos.TabIndex = 130
        Me.cmdAcos.Text = "acos"
        Me.cmdAcos.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        Me.cmdCos.Location = New System.Drawing.Point(43, 15)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(38, 30)
        Me.cmdCos.TabIndex = 129
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Location = New System.Drawing.Point(3, 15)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(38, 30)
        Me.cmdSqrt.TabIndex = 128
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'cmdGreaterOrEqualsTo
        '
        Me.cmdGreaterOrEqualsTo.Location = New System.Drawing.Point(34, 110)
        Me.cmdGreaterOrEqualsTo.Name = "cmdGreaterOrEqualsTo"
        Me.cmdGreaterOrEqualsTo.Size = New System.Drawing.Size(30, 30)
        Me.cmdGreaterOrEqualsTo.TabIndex = 138
        Me.cmdGreaterOrEqualsTo.Text = ">="
        Me.cmdGreaterOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        Me.cmdAnd.Location = New System.Drawing.Point(66, 110)
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Size = New System.Drawing.Size(38, 30)
        Me.cmdAnd.TabIndex = 137
        Me.cmdAnd.Tag = "And"
        Me.cmdAnd.Text = "And"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdTrue
        '
        Me.cmdTrue.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrue.Location = New System.Drawing.Point(66, 78)
        Me.cmdTrue.Name = "cmdTrue"
        Me.cmdTrue.Size = New System.Drawing.Size(38, 31)
        Me.cmdTrue.TabIndex = 136
        Me.cmdTrue.Text = "isTRUE()"
        Me.cmdTrue.UseVisualStyleBackColor = True
        '
        'cmdIntegerDivision
        '
        Me.cmdIntegerDivision.Location = New System.Drawing.Point(66, 45)
        Me.cmdIntegerDivision.Name = "cmdIntegerDivision"
        Me.cmdIntegerDivision.Size = New System.Drawing.Size(38, 32)
        Me.cmdIntegerDivision.TabIndex = 135
        Me.cmdIntegerDivision.Text = "%/%"
        Me.cmdIntegerDivision.UseVisualStyleBackColor = True
        '
        'cmdModulas
        '
        Me.cmdModulas.Location = New System.Drawing.Point(66, 13)
        Me.cmdModulas.Name = "cmdModulas"
        Me.cmdModulas.Size = New System.Drawing.Size(38, 30)
        Me.cmdModulas.TabIndex = 134
        Me.cmdModulas.Text = "%%"
        Me.cmdModulas.UseVisualStyleBackColor = True
        '
        'cmdGreater
        '
        Me.cmdGreater.Location = New System.Drawing.Point(34, 78)
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.Size = New System.Drawing.Size(30, 31)
        Me.cmdGreater.TabIndex = 133
        Me.cmdGreater.Text = ">"
        Me.cmdGreater.UseVisualStyleBackColor = True
        '
        'cmdLesserOrEqualsTo
        '
        Me.cmdLesserOrEqualsTo.Location = New System.Drawing.Point(34, 45)
        Me.cmdLesserOrEqualsTo.Name = "cmdLesserOrEqualsTo"
        Me.cmdLesserOrEqualsTo.Size = New System.Drawing.Size(30, 32)
        Me.cmdLesserOrEqualsTo.TabIndex = 132
        Me.cmdLesserOrEqualsTo.Text = "<="
        Me.cmdLesserOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdLesser
        '
        Me.cmdLesser.Location = New System.Drawing.Point(34, 13)
        Me.cmdLesser.Name = "cmdLesser"
        Me.cmdLesser.Size = New System.Drawing.Size(30, 30)
        Me.cmdLesser.TabIndex = 131
        Me.cmdLesser.Text = "<"
        Me.cmdLesser.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        Me.cmdOr.Location = New System.Drawing.Point(2, 110)
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.Size = New System.Drawing.Size(30, 30)
        Me.cmdOr.TabIndex = 130
        Me.cmdOr.Text = "|"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'cmdNot
        '
        Me.cmdNot.Location = New System.Drawing.Point(2, 78)
        Me.cmdNot.Name = "cmdNot"
        Me.cmdNot.Size = New System.Drawing.Size(30, 31)
        Me.cmdNot.TabIndex = 129
        Me.cmdNot.Text = "!"
        Me.cmdNot.UseVisualStyleBackColor = True
        '
        'cmdNotEqualsTo
        '
        Me.cmdNotEqualsTo.Location = New System.Drawing.Point(2, 45)
        Me.cmdNotEqualsTo.Name = "cmdNotEqualsTo"
        Me.cmdNotEqualsTo.Size = New System.Drawing.Size(30, 32)
        Me.cmdNotEqualsTo.TabIndex = 128
        Me.cmdNotEqualsTo.Text = "!="
        Me.cmdNotEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdEquivalent
        '
        Me.cmdEquivalent.Location = New System.Drawing.Point(2, 13)
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.Size = New System.Drawing.Size(30, 30)
        Me.cmdEquivalent.TabIndex = 127
        Me.cmdEquivalent.Text = "=="
        Me.cmdEquivalent.UseVisualStyleBackColor = True
        '
        'ucrInputCalOptions
        '
        Me.ucrInputCalOptions.IsReadOnly = False
        Me.ucrInputCalOptions.Location = New System.Drawing.Point(222, 42)
        Me.ucrInputCalOptions.Name = "ucrInputCalOptions"
        Me.ucrInputCalOptions.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputCalOptions.TabIndex = 120
        '
        'ucrReceiverForCalculation
        '
        Me.ucrReceiverForCalculation.Location = New System.Drawing.Point(90, 16)
        Me.ucrReceiverForCalculation.Name = "ucrReceiverForCalculation"
        Me.ucrReceiverForCalculation.Selector = Nothing
        Me.ucrReceiverForCalculation.Size = New System.Drawing.Size(284, 20)
        Me.ucrReceiverForCalculation.TabIndex = 118
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.IsReadOnly = False
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(119, 257)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(256, 21)
        Me.ucrSaveResultInto.TabIndex = 117
        '
        'ucrSpaceToMangeResult
        '
        Me.ucrSpaceToMangeResult.IsReadOnly = False
        Me.ucrSpaceToMangeResult.Location = New System.Drawing.Point(91, 229)
        Me.ucrSpaceToMangeResult.Name = "ucrSpaceToMangeResult"
        Me.ucrSpaceToMangeResult.Size = New System.Drawing.Size(284, 21)
        Me.ucrSpaceToMangeResult.TabIndex = 111
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
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(9, 306)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 50)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 363)
        Me.Controls.Add(Me.grpMaths)
        Me.Controls.Add(Me.ucrInputCalOptions)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.ucrReceiverForCalculation)
        Me.Controls.Add(Me.ucrSaveResultInto)
        Me.Controls.Add(Me.chkDefaultCalculationName)
        Me.Controls.Add(Me.chkSaveResultInto)
        Me.Controls.Add(Me.ucrSpaceToMangeResult)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.lblExpression)
        Me.Controls.Add(Me.ucrSelectorForCalculations)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "dlgCalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Calculations"
        Me.Text = "Calculations"
        Me.grpBasic.ResumeLayout(False)
        Me.grpLogical.ResumeLayout(False)
        Me.grpMaths.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorForCalculations As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblExpression As Label
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrSpaceToMangeResult As ucrInputTextBox
    Friend WithEvents chkSaveResultInto As CheckBox
    Friend WithEvents chkDefaultCalculationName As CheckBox
    Friend WithEvents ucrSaveResultInto As ucrInputComboBox
    Friend WithEvents ucrReceiverForCalculation As ucrReceiverExpression
    Friend WithEvents grpBasic As GroupBox
    Friend WithEvents cmdGreaterThan As Button
    Friend WithEvents cmdLessThan As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdDot As Button
    Friend WithEvents cmd9 As Button
    Friend WithEvents cmd8 As Button
    Friend WithEvents cmd7 As Button
    Friend WithEvents cmd6 As Button
    Friend WithEvents cmd5 As Button
    Friend WithEvents cmd4 As Button
    Friend WithEvents cmd3 As Button
    Friend WithEvents cmd2 As Button
    Friend WithEvents cmd0 As Button
    Friend WithEvents cmd1 As Button
    Friend WithEvents ucrInputCalOptions As ucrInputComboBox
    Friend WithEvents grpLogical As GroupBox
    Friend WithEvents cmdGreaterOrEqualsTo As Button
    Friend WithEvents cmdAnd As Button
    Friend WithEvents cmdTrue As Button
    Friend WithEvents cmdIntegerDivision As Button
    Friend WithEvents cmdModulas As Button
    Friend WithEvents cmdGreater As Button
    Friend WithEvents cmdLesserOrEqualsTo As Button
    Friend WithEvents cmdLesser As Button
    Friend WithEvents cmdOr As Button
    Friend WithEvents cmdNot As Button
    Friend WithEvents cmdNotEqualsTo As Button
    Friend WithEvents cmdEquivalent As Button
    Friend WithEvents grpMaths As GroupBox
    Friend WithEvents cmdSign As Button
    Friend WithEvents cmdRound As Button
    Friend WithEvents cmdSiginf As Button
    Friend WithEvents cmdAbs As Button
    Friend WithEvents cmdExp As Button
    Friend WithEvents cmdDeg As Button
    Friend WithEvents cmdTrunc As Button
    Friend WithEvents cmdAtan As Button
    Friend WithEvents cmdTan As Button
    Friend WithEvents cmdLogTen As Button
    Friend WithEvents cmdRad As Button
    Friend WithEvents cmdFloor As Button
    Friend WithEvents cmdAsin As Button
    Friend WithEvents cmdSin As Button
    Friend WithEvents cmdLog As Button
    Friend WithEvents cmdPi As Button
    Friend WithEvents cmdCeiling As Button
    Friend WithEvents cmdAcos As Button
    Friend WithEvents cmdCos As Button
    Friend WithEvents cmdSqrt As Button
End Class
