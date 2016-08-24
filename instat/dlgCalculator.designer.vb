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
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdPower = New System.Windows.Forms.Button()
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
        Me.grpStrings = New System.Windows.Forms.GroupBox()
        Me.cmdDetect = New System.Windows.Forms.Button()
        Me.cmdTrim = New System.Windows.Forms.Button()
        Me.cmdReplace = New System.Windows.Forms.Button()
        Me.cmdTitle = New System.Windows.Forms.Button()
        Me.cmdLower = New System.Windows.Forms.Button()
        Me.cmdUpper = New System.Windows.Forms.Button()
        Me.cmdSort = New System.Windows.Forms.Button()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.cmdPad = New System.Windows.Forms.Button()
        Me.cmdExtract = New System.Windows.Forms.Button()
        Me.cmdLength = New System.Windows.Forms.Button()
        Me.cmdCountstrings = New System.Windows.Forms.Button()
        Me.cmdLocate = New System.Windows.Forms.Button()
        Me.cmdCount = New System.Windows.Forms.Button()
        Me.cmdMiss = New System.Windows.Forms.Button()
        Me.cmdSum = New System.Windows.Forms.Button()
        Me.cmdMean = New System.Windows.Forms.Button()
        Me.cmdMax = New System.Windows.Forms.Button()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmdMedian = New System.Windows.Forms.Button()
        Me.cmdVar = New System.Windows.Forms.Button()
        Me.cmdSd = New System.Windows.Forms.Button()
        Me.cmdRange = New System.Windows.Forms.Button()
        Me.cmdQuantile = New System.Windows.Forms.Button()
        Me.cmdIQR = New System.Windows.Forms.Button()
        Me.grpStatistics = New System.Windows.Forms.GroupBox()
        Me.cmdEquivalent = New System.Windows.Forms.Button()
        Me.cmdNotEqualsTo = New System.Windows.Forms.Button()
        Me.cmdNot = New System.Windows.Forms.Button()
        Me.cmdOr = New System.Windows.Forms.Button()
        Me.cmdLesser = New System.Windows.Forms.Button()
        Me.cmdLesserOrEqualsTo = New System.Windows.Forms.Button()
        Me.cmdGreater = New System.Windows.Forms.Button()
        Me.cmdModulas = New System.Windows.Forms.Button()
        Me.cmdIntegerDivision = New System.Windows.Forms.Button()
        Me.cmdAnd = New System.Windows.Forms.Button()
        Me.cmdGreaterOrEqualsTo = New System.Windows.Forms.Button()
        Me.grpLogical = New System.Windows.Forms.GroupBox()
        Me.ucrInputCalOptions = New instat.ucrInputComboBox()
        Me.ucrReceiverForCalculation = New instat.ucrReceiverExpression()
        Me.ucrSaveResultInto = New instat.ucrInputComboBox()
        Me.ucrSpaceToMangeResult = New instat.ucrInputTextBox()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.grpBasic.SuspendLayout()
        Me.grpMaths.SuspendLayout()
        Me.grpStrings.SuspendLayout()
        Me.grpStatistics.SuspendLayout()
        Me.grpLogical.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.Location = New System.Drawing.Point(12, 17)
        Me.lblExpression.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(58, 13)
        Me.lblExpression.TabIndex = 107
        Me.lblExpression.Tag = "Expression"
        Me.lblExpression.Text = "Expression"
        '
        'cmdTry
        '
        Me.cmdTry.Location = New System.Drawing.Point(8, 228)
        Me.cmdTry.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(74, 23)
        Me.cmdTry.TabIndex = 110
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'chkSaveResultInto
        '
        Me.chkSaveResultInto.AutoSize = True
        Me.chkSaveResultInto.Location = New System.Drawing.Point(8, 260)
        Me.chkSaveResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkSaveResultInto.Name = "chkSaveResultInto"
        Me.chkSaveResultInto.Size = New System.Drawing.Size(104, 17)
        Me.chkSaveResultInto.TabIndex = 113
        Me.chkSaveResultInto.Text = "Save Result into"
        Me.chkSaveResultInto.UseVisualStyleBackColor = True
        '
        'chkDefaultCalculationName
        '
        Me.chkDefaultCalculationName.AutoSize = True
        Me.chkDefaultCalculationName.Location = New System.Drawing.Point(8, 283)
        Me.chkDefaultCalculationName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkDefaultCalculationName.Name = "chkDefaultCalculationName"
        Me.chkDefaultCalculationName.Size = New System.Drawing.Size(144, 17)
        Me.chkDefaultCalculationName.TabIndex = 115
        Me.chkDefaultCalculationName.Text = "Default Calculation name"
        Me.chkDefaultCalculationName.UseVisualStyleBackColor = True
        '
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.cmdClear)
        Me.grpBasic.Controls.Add(Me.cmdDelete)
        Me.grpBasic.Controls.Add(Me.cmdPower)
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
        Me.grpBasic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Size = New System.Drawing.Size(164, 147)
        Me.grpBasic.TabIndex = 119
        Me.grpBasic.TabStop = False
        Me.grpBasic.Text = "Basic"
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(126, 79)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(34, 61)
        Me.cmdClear.TabIndex = 135
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(2, 110)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(60, 30)
        Me.cmdDelete.TabIndex = 132
        Me.cmdDelete.Tag = "Del"
        Me.cmdDelete.Text = "Del"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(127, 45)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(33, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(97, 13)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(26, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(97, 110)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(26, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(97, 78)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(26, 30)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(97, 45)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(26, 32)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Location = New System.Drawing.Point(126, 13)
        Me.cmdDot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(34, 30)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(65, 13)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(30, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(35, 13)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(28, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(2, 13)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(29, 30)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(65, 45)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(30, 32)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(35, 45)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(28, 32)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(2, 45)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(29, 32)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(65, 78)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(30, 30)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(35, 78)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(28, 30)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(65, 110)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(30, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(2, 78)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(29, 30)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'grpMaths
        '
        Me.grpMaths.Controls.Add(Me.cmdSign)
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
        Me.grpMaths.Location = New System.Drawing.Point(390, 69)
        Me.grpMaths.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMaths.Name = "grpMaths"
        Me.grpMaths.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMaths.Size = New System.Drawing.Size(208, 153)
        Me.grpMaths.TabIndex = 148
        Me.grpMaths.TabStop = False
        Me.grpMaths.Text = "Maths"
        '
        'cmdSign
        '
        Me.cmdSign.Location = New System.Drawing.Point(166, 113)
        Me.cmdSign.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(38, 30)
        Me.cmdSign.TabIndex = 147
        Me.cmdSign.Text = "sign"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmdRound
        '
        Me.cmdRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRound.Location = New System.Drawing.Point(125, 113)
        Me.cmdRound.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRound.Name = "cmdRound"
        Me.cmdRound.Size = New System.Drawing.Size(38, 30)
        Me.cmdRound.TabIndex = 146
        Me.cmdRound.Text = "round"
        Me.cmdRound.UseVisualStyleBackColor = True
        '
        'cmdSiginf
        '
        Me.cmdSiginf.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSiginf.Location = New System.Drawing.Point(84, 113)
        Me.cmdSiginf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSiginf.Name = "cmdSiginf"
        Me.cmdSiginf.Size = New System.Drawing.Size(38, 30)
        Me.cmdSiginf.TabIndex = 145
        Me.cmdSiginf.Text = "siginf"
        Me.cmdSiginf.UseVisualStyleBackColor = True
        '
        'cmdAbs
        '
        Me.cmdAbs.Location = New System.Drawing.Point(43, 113)
        Me.cmdAbs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.Size = New System.Drawing.Size(38, 30)
        Me.cmdAbs.TabIndex = 144
        Me.cmdAbs.Text = "abs"
        Me.cmdAbs.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.Location = New System.Drawing.Point(2, 113)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(38, 30)
        Me.cmdExp.TabIndex = 143
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdDeg
        '
        Me.cmdDeg.Location = New System.Drawing.Point(166, 79)
        Me.cmdDeg.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDeg.Name = "cmdDeg"
        Me.cmdDeg.Size = New System.Drawing.Size(38, 30)
        Me.cmdDeg.TabIndex = 142
        Me.cmdDeg.Text = "deg"
        Me.cmdDeg.UseVisualStyleBackColor = True
        '
        'cmdTrunc
        '
        Me.cmdTrunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrunc.Location = New System.Drawing.Point(125, 79)
        Me.cmdTrunc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrunc.Name = "cmdTrunc"
        Me.cmdTrunc.Size = New System.Drawing.Size(38, 30)
        Me.cmdTrunc.TabIndex = 141
        Me.cmdTrunc.Text = "trunc"
        Me.cmdTrunc.UseVisualStyleBackColor = True
        '
        'cmdAtan
        '
        Me.cmdAtan.Location = New System.Drawing.Point(84, 79)
        Me.cmdAtan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAtan.Name = "cmdAtan"
        Me.cmdAtan.Size = New System.Drawing.Size(38, 30)
        Me.cmdAtan.TabIndex = 140
        Me.cmdAtan.Text = "atan"
        Me.cmdAtan.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.Location = New System.Drawing.Point(43, 79)
        Me.cmdTan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(38, 30)
        Me.cmdTan.TabIndex = 139
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdLogTen
        '
        Me.cmdLogTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLogTen.Location = New System.Drawing.Point(2, 79)
        Me.cmdLogTen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLogTen.Name = "cmdLogTen"
        Me.cmdLogTen.Size = New System.Drawing.Size(38, 30)
        Me.cmdLogTen.TabIndex = 138
        Me.cmdLogTen.Text = "log10"
        Me.cmdLogTen.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        Me.cmdRad.Location = New System.Drawing.Point(166, 48)
        Me.cmdRad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRad.Name = "cmdRad"
        Me.cmdRad.Size = New System.Drawing.Size(38, 30)
        Me.cmdRad.TabIndex = 137
        Me.cmdRad.Text = "rad"
        Me.cmdRad.UseVisualStyleBackColor = True
        '
        'cmdFloor
        '
        Me.cmdFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFloor.Location = New System.Drawing.Point(125, 48)
        Me.cmdFloor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFloor.Name = "cmdFloor"
        Me.cmdFloor.Size = New System.Drawing.Size(38, 30)
        Me.cmdFloor.TabIndex = 136
        Me.cmdFloor.Text = "floor"
        Me.cmdFloor.UseVisualStyleBackColor = True
        '
        'cmdAsin
        '
        Me.cmdAsin.Location = New System.Drawing.Point(84, 48)
        Me.cmdAsin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAsin.Name = "cmdAsin"
        Me.cmdAsin.Size = New System.Drawing.Size(38, 30)
        Me.cmdAsin.TabIndex = 135
        Me.cmdAsin.Text = "asin"
        Me.cmdAsin.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.Location = New System.Drawing.Point(43, 48)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(38, 30)
        Me.cmdSin.TabIndex = 134
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.Location = New System.Drawing.Point(2, 48)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(38, 30)
        Me.cmdLog.TabIndex = 133
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.Location = New System.Drawing.Point(166, 14)
        Me.cmdPi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(38, 30)
        Me.cmdPi.TabIndex = 132
        Me.cmdPi.Text = "pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdCeiling
        '
        Me.cmdCeiling.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCeiling.Location = New System.Drawing.Point(125, 14)
        Me.cmdCeiling.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCeiling.Name = "cmdCeiling"
        Me.cmdCeiling.Size = New System.Drawing.Size(38, 30)
        Me.cmdCeiling.TabIndex = 131
        Me.cmdCeiling.Text = "ceiling"
        Me.cmdCeiling.UseVisualStyleBackColor = True
        '
        'cmdAcos
        '
        Me.cmdAcos.Location = New System.Drawing.Point(84, 14)
        Me.cmdAcos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAcos.Name = "cmdAcos"
        Me.cmdAcos.Size = New System.Drawing.Size(38, 30)
        Me.cmdAcos.TabIndex = 130
        Me.cmdAcos.Text = "acos"
        Me.cmdAcos.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        Me.cmdCos.Location = New System.Drawing.Point(43, 14)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(38, 30)
        Me.cmdCos.TabIndex = 129
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.Location = New System.Drawing.Point(2, 14)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(38, 30)
        Me.cmdSqrt.TabIndex = 128
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'grpStrings
        '
        Me.grpStrings.Controls.Add(Me.cmdDetect)
        Me.grpStrings.Controls.Add(Me.cmdTrim)
        Me.grpStrings.Controls.Add(Me.cmdReplace)
        Me.grpStrings.Controls.Add(Me.cmdTitle)
        Me.grpStrings.Controls.Add(Me.cmdLower)
        Me.grpStrings.Controls.Add(Me.cmdUpper)
        Me.grpStrings.Controls.Add(Me.cmdSort)
        Me.grpStrings.Controls.Add(Me.cmdOrder)
        Me.grpStrings.Controls.Add(Me.cmdPad)
        Me.grpStrings.Controls.Add(Me.cmdExtract)
        Me.grpStrings.Controls.Add(Me.cmdLength)
        Me.grpStrings.Controls.Add(Me.cmdCountstrings)
        Me.grpStrings.Controls.Add(Me.cmdLocate)
        Me.grpStrings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStrings.Location = New System.Drawing.Point(387, 68)
        Me.grpStrings.Name = "grpStrings"
        Me.grpStrings.Size = New System.Drawing.Size(141, 145)
        Me.grpStrings.TabIndex = 150
        Me.grpStrings.TabStop = False
        Me.grpStrings.Text = "Strings"
        '
        'cmdDetect
        '
        Me.cmdDetect.Location = New System.Drawing.Point(6, 111)
        Me.cmdDetect.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Size = New System.Drawing.Size(60, 30)
        Me.cmdDetect.TabIndex = 147
        Me.cmdDetect.Tag = ""
        Me.cmdDetect.Text = "detect"
        Me.cmdDetect.UseVisualStyleBackColor = True
        '
        'cmdTrim
        '
        Me.cmdTrim.Location = New System.Drawing.Point(101, 14)
        Me.cmdTrim.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrim.Name = "cmdTrim"
        Me.cmdTrim.Size = New System.Drawing.Size(35, 30)
        Me.cmdTrim.TabIndex = 146
        Me.cmdTrim.Text = "trim"
        Me.cmdTrim.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        Me.cmdReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReplace.Location = New System.Drawing.Point(101, 44)
        Me.cmdReplace.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(35, 32)
        Me.cmdReplace.TabIndex = 143
        Me.cmdReplace.Text = "replace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdTitle
        '
        Me.cmdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTitle.Location = New System.Drawing.Point(69, 14)
        Me.cmdTitle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.Size = New System.Drawing.Size(30, 30)
        Me.cmdTitle.TabIndex = 142
        Me.cmdTitle.Text = "title"
        Me.cmdTitle.UseVisualStyleBackColor = True
        '
        'cmdLower
        '
        Me.cmdLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLower.Location = New System.Drawing.Point(39, 14)
        Me.cmdLower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLower.Name = "cmdLower"
        Me.cmdLower.Size = New System.Drawing.Size(28, 30)
        Me.cmdLower.TabIndex = 141
        Me.cmdLower.Text = "lower"
        Me.cmdLower.UseVisualStyleBackColor = True
        '
        'cmdUpper
        '
        Me.cmdUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpper.Location = New System.Drawing.Point(6, 14)
        Me.cmdUpper.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdUpper.Name = "cmdUpper"
        Me.cmdUpper.Size = New System.Drawing.Size(29, 30)
        Me.cmdUpper.TabIndex = 140
        Me.cmdUpper.Text = "upper"
        Me.cmdUpper.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSort.Location = New System.Drawing.Point(69, 46)
        Me.cmdSort.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(28, 32)
        Me.cmdSort.TabIndex = 139
        Me.cmdSort.Text = "sort"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdOrder
        '
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(39, 46)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(28, 32)
        Me.cmdOrder.TabIndex = 138
        Me.cmdOrder.Text = "order"
        Me.cmdOrder.UseVisualStyleBackColor = True
        '
        'cmdPad
        '
        Me.cmdPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPad.Location = New System.Drawing.Point(6, 46)
        Me.cmdPad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPad.Name = "cmdPad"
        Me.cmdPad.Size = New System.Drawing.Size(29, 32)
        Me.cmdPad.TabIndex = 137
        Me.cmdPad.Text = "pad"
        Me.cmdPad.UseVisualStyleBackColor = True
        '
        'cmdExtract
        '
        Me.cmdExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExtract.Location = New System.Drawing.Point(91, 79)
        Me.cmdExtract.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(45, 30)
        Me.cmdExtract.TabIndex = 136
        Me.cmdExtract.Text = "extract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdLength
        '
        Me.cmdLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLength.Location = New System.Drawing.Point(48, 79)
        Me.cmdLength.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLength.Name = "cmdLength"
        Me.cmdLength.Size = New System.Drawing.Size(39, 30)
        Me.cmdLength.TabIndex = 135
        Me.cmdLength.Text = "length"
        Me.cmdLength.UseVisualStyleBackColor = True
        '
        'cmdCountstrings
        '
        Me.cmdCountstrings.Location = New System.Drawing.Point(69, 111)
        Me.cmdCountstrings.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCountstrings.Name = "cmdCountstrings"
        Me.cmdCountstrings.Size = New System.Drawing.Size(67, 30)
        Me.cmdCountstrings.TabIndex = 134
        Me.cmdCountstrings.Text = "count"
        Me.cmdCountstrings.UseVisualStyleBackColor = True
        '
        'cmdLocate
        '
        Me.cmdLocate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLocate.Location = New System.Drawing.Point(6, 79)
        Me.cmdLocate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLocate.Name = "cmdLocate"
        Me.cmdLocate.Size = New System.Drawing.Size(38, 30)
        Me.cmdLocate.TabIndex = 133
        Me.cmdLocate.Text = "locate"
        Me.cmdLocate.UseVisualStyleBackColor = True
        '
        'cmdCount
        '
        Me.cmdCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCount.Location = New System.Drawing.Point(4, 13)
        Me.cmdCount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCount.Name = "cmdCount"
        Me.cmdCount.Size = New System.Drawing.Size(38, 30)
        Me.cmdCount.TabIndex = 148
        Me.cmdCount.Text = "count"
        Me.cmdCount.UseVisualStyleBackColor = True
        '
        'cmdMiss
        '
        Me.cmdMiss.Location = New System.Drawing.Point(43, 13)
        Me.cmdMiss.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMiss.Name = "cmdMiss"
        Me.cmdMiss.Size = New System.Drawing.Size(38, 30)
        Me.cmdMiss.TabIndex = 149
        Me.cmdMiss.Text = "miss"
        Me.cmdMiss.UseVisualStyleBackColor = True
        '
        'cmdSum
        '
        Me.cmdSum.Location = New System.Drawing.Point(82, 13)
        Me.cmdSum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSum.Name = "cmdSum"
        Me.cmdSum.Size = New System.Drawing.Size(38, 30)
        Me.cmdSum.TabIndex = 150
        Me.cmdSum.Text = "sum"
        Me.cmdSum.UseVisualStyleBackColor = True
        '
        'cmdMean
        '
        Me.cmdMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMean.Location = New System.Drawing.Point(4, 45)
        Me.cmdMean.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMean.Name = "cmdMean"
        Me.cmdMean.Size = New System.Drawing.Size(38, 30)
        Me.cmdMean.TabIndex = 153
        Me.cmdMean.Text = "mean"
        Me.cmdMean.UseVisualStyleBackColor = True
        '
        'cmdMax
        '
        Me.cmdMax.Location = New System.Drawing.Point(43, 45)
        Me.cmdMax.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.Size = New System.Drawing.Size(38, 30)
        Me.cmdMax.TabIndex = 154
        Me.cmdMax.Text = "max"
        Me.cmdMax.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        Me.cmdMin.Location = New System.Drawing.Point(82, 45)
        Me.cmdMin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(38, 30)
        Me.cmdMin.TabIndex = 155
        Me.cmdMin.Text = "min"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdMedian
        '
        Me.cmdMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMedian.Location = New System.Drawing.Point(4, 76)
        Me.cmdMedian.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMedian.Name = "cmdMedian"
        Me.cmdMedian.Size = New System.Drawing.Size(38, 30)
        Me.cmdMedian.TabIndex = 158
        Me.cmdMedian.Text = "median"
        Me.cmdMedian.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        Me.cmdVar.Location = New System.Drawing.Point(43, 76)
        Me.cmdVar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdVar.Name = "cmdVar"
        Me.cmdVar.Size = New System.Drawing.Size(38, 30)
        Me.cmdVar.TabIndex = 159
        Me.cmdVar.Text = "var"
        Me.cmdVar.UseVisualStyleBackColor = True
        '
        'cmdSd
        '
        Me.cmdSd.Location = New System.Drawing.Point(82, 76)
        Me.cmdSd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSd.Name = "cmdSd"
        Me.cmdSd.Size = New System.Drawing.Size(38, 30)
        Me.cmdSd.TabIndex = 160
        Me.cmdSd.Text = "sd"
        Me.cmdSd.UseVisualStyleBackColor = True
        '
        'cmdRange
        '
        Me.cmdRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRange.Location = New System.Drawing.Point(4, 107)
        Me.cmdRange.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRange.Name = "cmdRange"
        Me.cmdRange.Size = New System.Drawing.Size(38, 30)
        Me.cmdRange.TabIndex = 163
        Me.cmdRange.Text = "range"
        Me.cmdRange.UseVisualStyleBackColor = True
        '
        'cmdQuantile
        '
        Me.cmdQuantile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuantile.Location = New System.Drawing.Point(43, 107)
        Me.cmdQuantile.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuantile.Name = "cmdQuantile"
        Me.cmdQuantile.Size = New System.Drawing.Size(38, 30)
        Me.cmdQuantile.TabIndex = 164
        Me.cmdQuantile.Text = "quantile"
        Me.cmdQuantile.UseVisualStyleBackColor = True
        '
        'cmdIQR
        '
        Me.cmdIQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIQR.Location = New System.Drawing.Point(82, 107)
        Me.cmdIQR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIQR.Name = "cmdIQR"
        Me.cmdIQR.Size = New System.Drawing.Size(38, 30)
        Me.cmdIQR.TabIndex = 165
        Me.cmdIQR.Text = "IQR"
        Me.cmdIQR.UseVisualStyleBackColor = True
        '
        'grpStatistics
        '
        Me.grpStatistics.Controls.Add(Me.cmdIQR)
        Me.grpStatistics.Controls.Add(Me.cmdQuantile)
        Me.grpStatistics.Controls.Add(Me.cmdRange)
        Me.grpStatistics.Controls.Add(Me.cmdSd)
        Me.grpStatistics.Controls.Add(Me.cmdVar)
        Me.grpStatistics.Controls.Add(Me.cmdMedian)
        Me.grpStatistics.Controls.Add(Me.cmdMin)
        Me.grpStatistics.Controls.Add(Me.cmdMax)
        Me.grpStatistics.Controls.Add(Me.cmdMean)
        Me.grpStatistics.Controls.Add(Me.cmdSum)
        Me.grpStatistics.Controls.Add(Me.cmdMiss)
        Me.grpStatistics.Controls.Add(Me.cmdCount)
        Me.grpStatistics.Location = New System.Drawing.Point(390, 69)
        Me.grpStatistics.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStatistics.Name = "grpStatistics"
        Me.grpStatistics.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStatistics.Size = New System.Drawing.Size(120, 140)
        Me.grpStatistics.TabIndex = 149
        Me.grpStatistics.TabStop = False
        Me.grpStatistics.Text = "Statistics"
        '
        'cmdEquivalent
        '
        Me.cmdEquivalent.Location = New System.Drawing.Point(2, 13)
        Me.cmdEquivalent.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.Size = New System.Drawing.Size(30, 30)
        Me.cmdEquivalent.TabIndex = 127
        Me.cmdEquivalent.Text = "=="
        Me.cmdEquivalent.UseVisualStyleBackColor = True
        '
        'cmdNotEqualsTo
        '
        Me.cmdNotEqualsTo.Location = New System.Drawing.Point(2, 45)
        Me.cmdNotEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNotEqualsTo.Name = "cmdNotEqualsTo"
        Me.cmdNotEqualsTo.Size = New System.Drawing.Size(30, 32)
        Me.cmdNotEqualsTo.TabIndex = 128
        Me.cmdNotEqualsTo.Text = "!="
        Me.cmdNotEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdNot
        '
        Me.cmdNot.Location = New System.Drawing.Point(2, 78)
        Me.cmdNot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNot.Name = "cmdNot"
        Me.cmdNot.Size = New System.Drawing.Size(30, 30)
        Me.cmdNot.TabIndex = 129
        Me.cmdNot.Text = "!"
        Me.cmdNot.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        Me.cmdOr.Location = New System.Drawing.Point(2, 110)
        Me.cmdOr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.Size = New System.Drawing.Size(30, 30)
        Me.cmdOr.TabIndex = 130
        Me.cmdOr.Text = "|"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'cmdLesser
        '
        Me.cmdLesser.Location = New System.Drawing.Point(34, 13)
        Me.cmdLesser.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLesser.Name = "cmdLesser"
        Me.cmdLesser.Size = New System.Drawing.Size(30, 30)
        Me.cmdLesser.TabIndex = 131
        Me.cmdLesser.Text = "<"
        Me.cmdLesser.UseVisualStyleBackColor = True
        '
        'cmdLesserOrEqualsTo
        '
        Me.cmdLesserOrEqualsTo.Location = New System.Drawing.Point(34, 45)
        Me.cmdLesserOrEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLesserOrEqualsTo.Name = "cmdLesserOrEqualsTo"
        Me.cmdLesserOrEqualsTo.Size = New System.Drawing.Size(30, 32)
        Me.cmdLesserOrEqualsTo.TabIndex = 132
        Me.cmdLesserOrEqualsTo.Text = "<="
        Me.cmdLesserOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdGreater
        '
        Me.cmdGreater.Location = New System.Drawing.Point(34, 78)
        Me.cmdGreater.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.Size = New System.Drawing.Size(70, 30)
        Me.cmdGreater.TabIndex = 133
        Me.cmdGreater.Text = ">"
        Me.cmdGreater.UseVisualStyleBackColor = True
        '
        'cmdModulas
        '
        Me.cmdModulas.Location = New System.Drawing.Point(66, 13)
        Me.cmdModulas.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdModulas.Name = "cmdModulas"
        Me.cmdModulas.Size = New System.Drawing.Size(38, 30)
        Me.cmdModulas.TabIndex = 134
        Me.cmdModulas.Text = "%%"
        Me.cmdModulas.UseVisualStyleBackColor = True
        '
        'cmdIntegerDivision
        '
        Me.cmdIntegerDivision.Location = New System.Drawing.Point(66, 45)
        Me.cmdIntegerDivision.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIntegerDivision.Name = "cmdIntegerDivision"
        Me.cmdIntegerDivision.Size = New System.Drawing.Size(38, 32)
        Me.cmdIntegerDivision.TabIndex = 135
        Me.cmdIntegerDivision.Text = "%/%"
        Me.cmdIntegerDivision.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        Me.cmdAnd.Location = New System.Drawing.Point(66, 110)
        Me.cmdAnd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Size = New System.Drawing.Size(38, 30)
        Me.cmdAnd.TabIndex = 137
        Me.cmdAnd.Tag = "And"
        Me.cmdAnd.Text = "And"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdGreaterOrEqualsTo
        '
        Me.cmdGreaterOrEqualsTo.Location = New System.Drawing.Point(34, 110)
        Me.cmdGreaterOrEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGreaterOrEqualsTo.Name = "cmdGreaterOrEqualsTo"
        Me.cmdGreaterOrEqualsTo.Size = New System.Drawing.Size(30, 30)
        Me.cmdGreaterOrEqualsTo.TabIndex = 138
        Me.cmdGreaterOrEqualsTo.Text = ">="
        Me.cmdGreaterOrEqualsTo.UseVisualStyleBackColor = True
        '
        'grpLogical
        '
        Me.grpLogical.Controls.Add(Me.cmdGreaterOrEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdAnd)
        Me.grpLogical.Controls.Add(Me.cmdIntegerDivision)
        Me.grpLogical.Controls.Add(Me.cmdModulas)
        Me.grpLogical.Controls.Add(Me.cmdGreater)
        Me.grpLogical.Controls.Add(Me.cmdLesserOrEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdLesser)
        Me.grpLogical.Controls.Add(Me.cmdOr)
        Me.grpLogical.Controls.Add(Me.cmdNot)
        Me.grpLogical.Controls.Add(Me.cmdNotEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdEquivalent)
        Me.grpLogical.Location = New System.Drawing.Point(390, 69)
        Me.grpLogical.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpLogical.Name = "grpLogical"
        Me.grpLogical.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpLogical.Size = New System.Drawing.Size(104, 144)
        Me.grpLogical.TabIndex = 121
        Me.grpLogical.TabStop = False
        Me.grpLogical.Text = "Logical"
        '
        'ucrInputCalOptions
        '
        Me.ucrInputCalOptions.IsReadOnly = False
        Me.ucrInputCalOptions.Location = New System.Drawing.Point(222, 42)
        Me.ucrInputCalOptions.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputCalOptions.Name = "ucrInputCalOptions"
        Me.ucrInputCalOptions.Size = New System.Drawing.Size(137, 22)
        Me.ucrInputCalOptions.TabIndex = 120
        '
        'ucrReceiverForCalculation
        '
        Me.ucrReceiverForCalculation.Location = New System.Drawing.Point(90, 16)
        Me.ucrReceiverForCalculation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForCalculation.Name = "ucrReceiverForCalculation"
        Me.ucrReceiverForCalculation.Selector = Nothing
        Me.ucrReceiverForCalculation.Size = New System.Drawing.Size(284, 20)
        Me.ucrReceiverForCalculation.TabIndex = 118
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.IsReadOnly = False
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(119, 257)
        Me.ucrSaveResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(256, 22)
        Me.ucrSaveResultInto.TabIndex = 117
        '
        'ucrSpaceToMangeResult
        '
        Me.ucrSpaceToMangeResult.IsReadOnly = False
        Me.ucrSpaceToMangeResult.Location = New System.Drawing.Point(91, 230)
        Me.ucrSpaceToMangeResult.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrSpaceToMangeResult.Name = "ucrSpaceToMangeResult"
        Me.ucrSpaceToMangeResult.Size = New System.Drawing.Size(284, 22)
        Me.ucrSpaceToMangeResult.TabIndex = 111
        '
        'ucrSelectorForCalculations
        '
        Me.ucrSelectorForCalculations.bShowHiddenColumns = False
        Me.ucrSelectorForCalculations.Location = New System.Drawing.Point(8, 36)
        Me.ucrSelectorForCalculations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCalculations.Name = "ucrSelectorForCalculations"
        Me.ucrSelectorForCalculations.Size = New System.Drawing.Size(210, 181)
        Me.ucrSelectorForCalculations.TabIndex = 106
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(8, 308)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(404, 51)
        Me.ucrBase.TabIndex = 0
        '
        'dlgCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 514)
        Me.Controls.Add(Me.grpStrings)
        Me.Controls.Add(Me.grpMaths)
        Me.Controls.Add(Me.grpLogical)
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
        Me.Controls.Add(Me.grpStatistics)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "dlgCalculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Calculations"
        Me.Text = "Calculations"
        Me.grpBasic.ResumeLayout(False)
        Me.grpMaths.ResumeLayout(False)
        Me.grpStrings.ResumeLayout(False)
        Me.grpStatistics.ResumeLayout(False)
        Me.grpLogical.ResumeLayout(False)
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
    Friend WithEvents cmdClear As Button
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
    Friend WithEvents grpStrings As GroupBox
    Friend WithEvents cmdDetect As Button
    Friend WithEvents cmdTrim As Button
    Friend WithEvents cmdReplace As Button
    Friend WithEvents cmdTitle As Button
    Friend WithEvents cmdLower As Button
    Friend WithEvents cmdUpper As Button
    Friend WithEvents cmdSort As Button
    Friend WithEvents cmdOrder As Button
    Friend WithEvents cmdPad As Button
    Friend WithEvents cmdExtract As Button
    Friend WithEvents cmdLength As Button
    Friend WithEvents cmdCountstrings As Button
    Friend WithEvents cmdLocate As Button
    Friend WithEvents cmdCount As Button
    Friend WithEvents cmdMiss As Button
    Friend WithEvents cmdSum As Button
    Friend WithEvents cmdMean As Button
    Friend WithEvents cmdMax As Button
    Friend WithEvents cmdMin As Button
    Friend WithEvents cmdMedian As Button
    Friend WithEvents cmdVar As Button
    Friend WithEvents cmdSd As Button
    Friend WithEvents cmdRange As Button
    Friend WithEvents cmdQuantile As Button
    Friend WithEvents cmdIQR As Button
    Friend WithEvents grpStatistics As GroupBox
    Friend WithEvents cmdEquivalent As Button
    Friend WithEvents cmdNotEqualsTo As Button
    Friend WithEvents cmdNot As Button
    Friend WithEvents cmdOr As Button
    Friend WithEvents cmdLesser As Button
    Friend WithEvents cmdLesserOrEqualsTo As Button
    Friend WithEvents cmdGreater As Button
    Friend WithEvents cmdModulas As Button
    Friend WithEvents cmdIntegerDivision As Button
    Friend WithEvents cmdAnd As Button
    Friend WithEvents cmdGreaterOrEqualsTo As Button
    Friend WithEvents grpLogical As GroupBox
End Class
