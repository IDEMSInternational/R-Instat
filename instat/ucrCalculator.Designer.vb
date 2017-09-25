' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrCalculator
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ucrReceiverForCalculation = New instat.ucrReceiverExpression()
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.ucrSaveResultInto = New instat.ucrInputComboBox()
        Me.chkSaveResultInto = New System.Windows.Forms.CheckBox()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.chkShowArguments = New System.Windows.Forms.CheckBox()
        Me.ucrInputCalOptions = New instat.ucrInputComboBox()
        Me.grpBasic = New System.Windows.Forms.GroupBox()
        Me.cmdBrackets = New System.Windows.Forms.Button()
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
        Me.grpDates = New System.Windows.Forms.GroupBox()
        Me.cmdDmy = New System.Windows.Forms.Button()
        Me.cmdDek = New System.Windows.Forms.Button()
        Me.cmdDay = New System.Windows.Forms.Button()
        Me.cmdMonth = New System.Windows.Forms.Button()
        Me.cmdYear = New System.Windows.Forms.Button()
        Me.cmdDate = New System.Windows.Forms.Button()
        Me.cmdYday = New System.Windows.Forms.Button()
        Me.cmdWday = New System.Windows.Forms.Button()
        Me.cmdMdy = New System.Windows.Forms.Button()
        Me.cmdYmd = New System.Windows.Forms.Button()
        Me.cmdDoy = New System.Windows.Forms.Button()
        Me.cmdLeap = New System.Windows.Forms.Button()
        Me.grpRows = New System.Windows.Forms.GroupBox()
        Me.cmdpercentrank = New System.Windows.Forms.Button()
        Me.cmdcumsum = New System.Windows.Forms.Button()
        Me.cmdcummin = New System.Windows.Forms.Button()
        Me.cmdcummax = New System.Windows.Forms.Button()
        Me.cmdPMin = New System.Windows.Forms.Button()
        Me.cmdpmax = New System.Windows.Forms.Button()
        Me.cmdLead = New System.Windows.Forms.Button()
        Me.cmdLag = New System.Windows.Forms.Button()
        Me.grpStrings = New System.Windows.Forms.GroupBox()
        Me.cmdSplit = New System.Windows.Forms.Button()
        Me.cmdCombine = New System.Windows.Forms.Button()
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
        Me.cmdCountstrings = New System.Windows.Forms.Button()
        Me.cmdLocate = New System.Windows.Forms.Button()
        Me.grpLogical = New System.Windows.Forms.GroupBox()
        Me.cmdOpeningBracket = New System.Windows.Forms.Button()
        Me.cmdColon = New System.Windows.Forms.Button()
        Me.cmdGreaterOrEqualsTo = New System.Windows.Forms.Button()
        Me.cmdClossingBracket = New System.Windows.Forms.Button()
        Me.cmdAnd = New System.Windows.Forms.Button()
        Me.cmdQuotes = New System.Windows.Forms.Button()
        Me.cmdSquareBrackets = New System.Windows.Forms.Button()
        Me.cmdIntegerDivision = New System.Windows.Forms.Button()
        Me.cmdModulas = New System.Windows.Forms.Button()
        Me.cmdGreater = New System.Windows.Forms.Button()
        Me.cmdLesserOrEqualsTo = New System.Windows.Forms.Button()
        Me.cmdLesser = New System.Windows.Forms.Button()
        Me.cmdOr = New System.Windows.Forms.Button()
        Me.cmdNot = New System.Windows.Forms.Button()
        Me.cmdNotEqualsTo = New System.Windows.Forms.Button()
        Me.cmdEquivalent = New System.Windows.Forms.Button()
        Me.grpProbabilty = New System.Windows.Forms.GroupBox()
        Me.cmdDigamma = New System.Windows.Forms.Button()
        Me.cmdGamma = New System.Windows.Forms.Button()
        Me.cmdLbeta = New System.Windows.Forms.Button()
        Me.cmdqF = New System.Windows.Forms.Button()
        Me.cmdFact = New System.Windows.Forms.Button()
        Me.cmdChoose = New System.Windows.Forms.Button()
        Me.cmdPf = New System.Windows.Forms.Button()
        Me.cmdPChisq = New System.Windows.Forms.Button()
        Me.cmdLgamma = New System.Windows.Forms.Button()
        Me.cmdPnorm = New System.Windows.Forms.Button()
        Me.cmdQchisq = New System.Windows.Forms.Button()
        Me.cmdQt = New System.Windows.Forms.Button()
        Me.cmdQnorm = New System.Windows.Forms.Button()
        Me.cmdPt = New System.Windows.Forms.Button()
        Me.cmdLchoose = New System.Windows.Forms.Button()
        Me.cmdLfact = New System.Windows.Forms.Button()
        Me.cmdTrigamma = New System.Windows.Forms.Button()
        Me.cmdBeta = New System.Windows.Forms.Button()
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
        Me.grpStatistics = New System.Windows.Forms.GroupBox()
        Me.cmdIQR = New System.Windows.Forms.Button()
        Me.cmdQuantile = New System.Windows.Forms.Button()
        Me.cmdRange = New System.Windows.Forms.Button()
        Me.cmdSd = New System.Windows.Forms.Button()
        Me.cmdVar = New System.Windows.Forms.Button()
        Me.cmdMedian = New System.Windows.Forms.Button()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmdMax = New System.Windows.Forms.Button()
        Me.cmdMean = New System.Windows.Forms.Button()
        Me.cmdSum = New System.Windows.Forms.Button()
        Me.cmdMiss = New System.Windows.Forms.Button()
        Me.cmdCount = New System.Windows.Forms.Button()
        Me.grpBasic.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpRows.SuspendLayout()
        Me.grpStrings.SuspendLayout()
        Me.grpLogical.SuspendLayout()
        Me.grpProbabilty.SuspendLayout()
        Me.grpMaths.SuspendLayout()
        Me.grpStatistics.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrReceiverForCalculation
        '
        Me.ucrReceiverForCalculation.frmParent = Nothing
        Me.ucrReceiverForCalculation.Location = New System.Drawing.Point(87, 13)
        Me.ucrReceiverForCalculation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForCalculation.Name = "ucrReceiverForCalculation"
        Me.ucrReceiverForCalculation.Selector = Nothing
        Me.ucrReceiverForCalculation.Size = New System.Drawing.Size(284, 28)
        Me.ucrReceiverForCalculation.strNcFilePath = ""
        Me.ucrReceiverForCalculation.TabIndex = 120
        Me.ucrReceiverForCalculation.ucrSelector = Nothing
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.Location = New System.Drawing.Point(8, 17)
        Me.lblExpression.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(58, 13)
        Me.lblExpression.TabIndex = 119
        Me.lblExpression.Tag = "Expression"
        Me.lblExpression.Text = "Expression"
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.AddQuotesIfUnrecognised = True
        Me.ucrSaveResultInto.IsReadOnly = False
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(121, 286)
        Me.ucrSaveResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(256, 22)
        Me.ucrSaveResultInto.TabIndex = 177
        '
        'chkSaveResultInto
        '
        Me.chkSaveResultInto.AutoSize = True
        Me.chkSaveResultInto.Location = New System.Drawing.Point(10, 289)
        Me.chkSaveResultInto.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.chkSaveResultInto.Name = "chkSaveResultInto"
        Me.chkSaveResultInto.Size = New System.Drawing.Size(104, 17)
        Me.chkSaveResultInto.TabIndex = 176
        Me.chkSaveResultInto.Text = "Save Result into"
        Me.chkSaveResultInto.UseVisualStyleBackColor = True
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        Me.ucrInputTryMessage.Location = New System.Drawing.Point(93, 257)
        Me.ucrInputTryMessage.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        Me.ucrInputTryMessage.Size = New System.Drawing.Size(284, 22)
        Me.ucrInputTryMessage.TabIndex = 175
        '
        'cmdTry
        '
        Me.cmdTry.Location = New System.Drawing.Point(10, 257)
        Me.cmdTry.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.Size = New System.Drawing.Size(74, 23)
        Me.cmdTry.TabIndex = 174
        Me.cmdTry.Text = "Try"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'ucrSelectorForCalculations
        '
        Me.ucrSelectorForCalculations.bShowHiddenColumns = False
        Me.ucrSelectorForCalculations.bUseCurrentFilter = True
        Me.ucrSelectorForCalculations.Location = New System.Drawing.Point(0, 64)
        Me.ucrSelectorForCalculations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCalculations.Name = "ucrSelectorForCalculations"
        Me.ucrSelectorForCalculations.Size = New System.Drawing.Size(210, 181)
        Me.ucrSelectorForCalculations.TabIndex = 173
        '
        'cmdHelp
        '
        Me.cmdHelp.Location = New System.Drawing.Point(396, 221)
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelp.TabIndex = 182
        Me.cmdHelp.Text = "Help"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'chkShowArguments
        '
        Me.chkShowArguments.AutoSize = True
        Me.chkShowArguments.Location = New System.Drawing.Point(373, 40)
        Me.chkShowArguments.Name = "chkShowArguments"
        Me.chkShowArguments.Size = New System.Drawing.Size(106, 17)
        Me.chkShowArguments.TabIndex = 181
        Me.chkShowArguments.Text = "Show Arguments"
        Me.chkShowArguments.UseVisualStyleBackColor = True
        '
        'ucrInputCalOptions
        '
        Me.ucrInputCalOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputCalOptions.IsReadOnly = False
        Me.ucrInputCalOptions.Location = New System.Drawing.Point(226, 38)
        Me.ucrInputCalOptions.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputCalOptions.Name = "ucrInputCalOptions"
        Me.ucrInputCalOptions.Size = New System.Drawing.Size(137, 22)
        Me.ucrInputCalOptions.TabIndex = 180
        '
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.cmdBrackets)
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
        Me.grpBasic.Location = New System.Drawing.Point(223, 64)
        Me.grpBasic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Size = New System.Drawing.Size(205, 148)
        Me.grpBasic.TabIndex = 179
        Me.grpBasic.TabStop = False
        Me.grpBasic.Text = "Basic"
        '
        'cmdBrackets
        '
        Me.cmdBrackets.Location = New System.Drawing.Point(81, 106)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(38, 30)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(160, 75)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(38, 61)
        Me.cmdClear.TabIndex = 135
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(3, 106)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(38, 30)
        Me.cmdDelete.TabIndex = 132
        Me.cmdDelete.Tag = "Del"
        Me.cmdDelete.Text = "Del"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Location = New System.Drawing.Point(160, 44)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(38, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Location = New System.Drawing.Point(120, 13)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(38, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Location = New System.Drawing.Point(120, 106)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(38, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Location = New System.Drawing.Point(120, 75)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(38, 30)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Location = New System.Drawing.Point(120, 44)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(38, 30)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Location = New System.Drawing.Point(160, 13)
        Me.cmdDot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(38, 30)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.Location = New System.Drawing.Point(81, 13)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(38, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.Location = New System.Drawing.Point(42, 13)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(38, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.Location = New System.Drawing.Point(3, 13)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(38, 30)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.Location = New System.Drawing.Point(81, 44)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(38, 30)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.Location = New System.Drawing.Point(42, 44)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(38, 30)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.Location = New System.Drawing.Point(3, 44)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(38, 30)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.Location = New System.Drawing.Point(81, 75)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(38, 30)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.Location = New System.Drawing.Point(42, 75)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(38, 30)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.Location = New System.Drawing.Point(42, 106)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(38, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.Location = New System.Drawing.Point(3, 75)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(38, 30)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.Controls.Add(Me.cmdDmy)
        Me.grpDates.Controls.Add(Me.cmdDek)
        Me.grpDates.Controls.Add(Me.cmdDay)
        Me.grpDates.Controls.Add(Me.cmdMonth)
        Me.grpDates.Controls.Add(Me.cmdYear)
        Me.grpDates.Controls.Add(Me.cmdDate)
        Me.grpDates.Controls.Add(Me.cmdYday)
        Me.grpDates.Controls.Add(Me.cmdWday)
        Me.grpDates.Controls.Add(Me.cmdMdy)
        Me.grpDates.Controls.Add(Me.cmdYmd)
        Me.grpDates.Controls.Add(Me.cmdDoy)
        Me.grpDates.Controls.Add(Me.cmdLeap)
        Me.grpDates.Location = New System.Drawing.Point(433, 64)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(189, 147)
        Me.grpDates.TabIndex = 188
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Dates"
        '
        'cmdDmy
        '
        Me.cmdDmy.Location = New System.Drawing.Point(4, 77)
        Me.cmdDmy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDmy.Name = "cmdDmy"
        Me.cmdDmy.Size = New System.Drawing.Size(60, 30)
        Me.cmdDmy.TabIndex = 151
        Me.cmdDmy.Tag = "dmy"
        Me.cmdDmy.Text = "dmy"
        Me.cmdDmy.UseVisualStyleBackColor = True
        '
        'cmdDek
        '
        Me.cmdDek.Location = New System.Drawing.Point(124, 108)
        Me.cmdDek.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDek.Name = "cmdDek"
        Me.cmdDek.Size = New System.Drawing.Size(60, 30)
        Me.cmdDek.TabIndex = 150
        Me.cmdDek.Text = "dek"
        Me.cmdDek.UseVisualStyleBackColor = True
        '
        'cmdDay
        '
        Me.cmdDay.Location = New System.Drawing.Point(124, 15)
        Me.cmdDay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDay.Name = "cmdDay"
        Me.cmdDay.Size = New System.Drawing.Size(60, 30)
        Me.cmdDay.TabIndex = 145
        Me.cmdDay.Text = "day"
        Me.cmdDay.UseVisualStyleBackColor = True
        '
        'cmdMonth
        '
        Me.cmdMonth.Location = New System.Drawing.Point(64, 15)
        Me.cmdMonth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMonth.Name = "cmdMonth"
        Me.cmdMonth.Size = New System.Drawing.Size(60, 30)
        Me.cmdMonth.TabIndex = 144
        Me.cmdMonth.Text = "month"
        Me.cmdMonth.UseVisualStyleBackColor = True
        '
        'cmdYear
        '
        Me.cmdYear.Location = New System.Drawing.Point(4, 15)
        Me.cmdYear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdYear.Name = "cmdYear"
        Me.cmdYear.Size = New System.Drawing.Size(60, 30)
        Me.cmdYear.TabIndex = 143
        Me.cmdYear.Text = "year"
        Me.cmdYear.UseVisualStyleBackColor = True
        '
        'cmdDate
        '
        Me.cmdDate.Location = New System.Drawing.Point(124, 46)
        Me.cmdDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDate.Name = "cmdDate"
        Me.cmdDate.Size = New System.Drawing.Size(60, 30)
        Me.cmdDate.TabIndex = 142
        Me.cmdDate.Text = "date"
        Me.cmdDate.UseVisualStyleBackColor = True
        '
        'cmdYday
        '
        Me.cmdYday.Location = New System.Drawing.Point(64, 46)
        Me.cmdYday.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdYday.Name = "cmdYday"
        Me.cmdYday.Size = New System.Drawing.Size(60, 30)
        Me.cmdYday.TabIndex = 141
        Me.cmdYday.Text = "yday"
        Me.cmdYday.UseVisualStyleBackColor = True
        '
        'cmdWday
        '
        Me.cmdWday.Location = New System.Drawing.Point(4, 46)
        Me.cmdWday.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdWday.Name = "cmdWday"
        Me.cmdWday.Size = New System.Drawing.Size(60, 30)
        Me.cmdWday.TabIndex = 140
        Me.cmdWday.Text = "wday"
        Me.cmdWday.UseVisualStyleBackColor = True
        '
        'cmdMdy
        '
        Me.cmdMdy.Location = New System.Drawing.Point(124, 77)
        Me.cmdMdy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMdy.Name = "cmdMdy"
        Me.cmdMdy.Size = New System.Drawing.Size(60, 30)
        Me.cmdMdy.TabIndex = 139
        Me.cmdMdy.Text = "mdy"
        Me.cmdMdy.UseVisualStyleBackColor = True
        '
        'cmdYmd
        '
        Me.cmdYmd.Location = New System.Drawing.Point(64, 77)
        Me.cmdYmd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdYmd.Name = "cmdYmd"
        Me.cmdYmd.Size = New System.Drawing.Size(60, 30)
        Me.cmdYmd.TabIndex = 138
        Me.cmdYmd.Text = "ymd"
        Me.cmdYmd.UseVisualStyleBackColor = True
        '
        'cmdDoy
        '
        Me.cmdDoy.Location = New System.Drawing.Point(64, 108)
        Me.cmdDoy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDoy.Name = "cmdDoy"
        Me.cmdDoy.Size = New System.Drawing.Size(60, 30)
        Me.cmdDoy.TabIndex = 137
        Me.cmdDoy.Text = "doy"
        Me.cmdDoy.UseVisualStyleBackColor = True
        '
        'cmdLeap
        '
        Me.cmdLeap.Location = New System.Drawing.Point(4, 108)
        Me.cmdLeap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLeap.Name = "cmdLeap"
        Me.cmdLeap.Size = New System.Drawing.Size(60, 30)
        Me.cmdLeap.TabIndex = 136
        Me.cmdLeap.Text = "leap"
        Me.cmdLeap.UseVisualStyleBackColor = True
        '
        'grpRows
        '
        Me.grpRows.Controls.Add(Me.cmdpercentrank)
        Me.grpRows.Controls.Add(Me.cmdcumsum)
        Me.grpRows.Controls.Add(Me.cmdcummin)
        Me.grpRows.Controls.Add(Me.cmdcummax)
        Me.grpRows.Controls.Add(Me.cmdPMin)
        Me.grpRows.Controls.Add(Me.cmdpmax)
        Me.grpRows.Controls.Add(Me.cmdLead)
        Me.grpRows.Controls.Add(Me.cmdLag)
        Me.grpRows.Location = New System.Drawing.Point(433, 64)
        Me.grpRows.Name = "grpRows"
        Me.grpRows.Size = New System.Drawing.Size(137, 148)
        Me.grpRows.TabIndex = 189
        Me.grpRows.TabStop = False
        Me.grpRows.Text = "Rows"
        '
        'cmdpercentrank
        '
        Me.cmdpercentrank.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.cmdpercentrank.Location = New System.Drawing.Point(67, 108)
        Me.cmdpercentrank.Name = "cmdpercentrank"
        Me.cmdpercentrank.Size = New System.Drawing.Size(62, 30)
        Me.cmdpercentrank.TabIndex = 181
        Me.cmdpercentrank.Text = "percent_rank"
        Me.cmdpercentrank.UseVisualStyleBackColor = True
        '
        'cmdcumsum
        '
        Me.cmdcumsum.Location = New System.Drawing.Point(5, 108)
        Me.cmdcumsum.Name = "cmdcumsum"
        Me.cmdcumsum.Size = New System.Drawing.Size(62, 30)
        Me.cmdcumsum.TabIndex = 180
        Me.cmdcumsum.Text = "cumsum"
        Me.cmdcumsum.UseVisualStyleBackColor = True
        '
        'cmdcummin
        '
        Me.cmdcummin.Location = New System.Drawing.Point(67, 77)
        Me.cmdcummin.Name = "cmdcummin"
        Me.cmdcummin.Size = New System.Drawing.Size(62, 30)
        Me.cmdcummin.TabIndex = 179
        Me.cmdcummin.Text = "cummin"
        Me.cmdcummin.UseVisualStyleBackColor = True
        '
        'cmdcummax
        '
        Me.cmdcummax.Location = New System.Drawing.Point(5, 77)
        Me.cmdcummax.Name = "cmdcummax"
        Me.cmdcummax.Size = New System.Drawing.Size(62, 30)
        Me.cmdcummax.TabIndex = 178
        Me.cmdcummax.Text = "cummax"
        Me.cmdcummax.UseVisualStyleBackColor = True
        '
        'cmdPMin
        '
        Me.cmdPMin.Location = New System.Drawing.Point(67, 46)
        Me.cmdPMin.Name = "cmdPMin"
        Me.cmdPMin.Size = New System.Drawing.Size(62, 30)
        Me.cmdPMin.TabIndex = 177
        Me.cmdPMin.Text = "pmin"
        Me.cmdPMin.UseVisualStyleBackColor = True
        '
        'cmdpmax
        '
        Me.cmdpmax.Location = New System.Drawing.Point(5, 46)
        Me.cmdpmax.Name = "cmdpmax"
        Me.cmdpmax.Size = New System.Drawing.Size(62, 30)
        Me.cmdpmax.TabIndex = 176
        Me.cmdpmax.Text = "pmax"
        Me.cmdpmax.UseVisualStyleBackColor = True
        '
        'cmdLead
        '
        Me.cmdLead.Location = New System.Drawing.Point(67, 15)
        Me.cmdLead.Name = "cmdLead"
        Me.cmdLead.Size = New System.Drawing.Size(62, 30)
        Me.cmdLead.TabIndex = 175
        Me.cmdLead.Text = "lead"
        Me.cmdLead.UseVisualStyleBackColor = True
        '
        'cmdLag
        '
        Me.cmdLag.Location = New System.Drawing.Point(5, 15)
        Me.cmdLag.Name = "cmdLag"
        Me.cmdLag.Size = New System.Drawing.Size(62, 30)
        Me.cmdLag.TabIndex = 174
        Me.cmdLag.Text = "lag"
        Me.cmdLag.UseVisualStyleBackColor = True
        '
        'grpStrings
        '
        Me.grpStrings.Controls.Add(Me.cmdSplit)
        Me.grpStrings.Controls.Add(Me.cmdCombine)
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
        Me.grpStrings.Controls.Add(Me.cmdCountstrings)
        Me.grpStrings.Controls.Add(Me.cmdLocate)
        Me.grpStrings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpStrings.Location = New System.Drawing.Point(433, 64)
        Me.grpStrings.Name = "grpStrings"
        Me.grpStrings.Size = New System.Drawing.Size(163, 148)
        Me.grpStrings.TabIndex = 186
        Me.grpStrings.TabStop = False
        Me.grpStrings.Text = "Strings (Character Columns)"
        '
        'cmdSplit
        '
        Me.cmdSplit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSplit.Location = New System.Drawing.Point(44, 108)
        Me.cmdSplit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSplit.Name = "cmdSplit"
        Me.cmdSplit.Size = New System.Drawing.Size(38, 30)
        Me.cmdSplit.TabIndex = 149
        Me.cmdSplit.Tag = ""
        Me.cmdSplit.Text = "split"
        Me.cmdSplit.UseVisualStyleBackColor = True
        '
        'cmdCombine
        '
        Me.cmdCombine.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.0!)
        Me.cmdCombine.Location = New System.Drawing.Point(125, 77)
        Me.cmdCombine.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCombine.Name = "cmdCombine"
        Me.cmdCombine.Size = New System.Drawing.Size(38, 30)
        Me.cmdCombine.TabIndex = 148
        Me.cmdCombine.Text = "combine"
        Me.cmdCombine.UseVisualStyleBackColor = True
        '
        'cmdDetect
        '
        Me.cmdDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetect.Location = New System.Drawing.Point(5, 108)
        Me.cmdDetect.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Size = New System.Drawing.Size(38, 30)
        Me.cmdDetect.TabIndex = 147
        Me.cmdDetect.Tag = ""
        Me.cmdDetect.Text = "detect"
        Me.cmdDetect.UseVisualStyleBackColor = True
        '
        'cmdTrim
        '
        Me.cmdTrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrim.Location = New System.Drawing.Point(125, 15)
        Me.cmdTrim.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrim.Name = "cmdTrim"
        Me.cmdTrim.Size = New System.Drawing.Size(38, 30)
        Me.cmdTrim.TabIndex = 146
        Me.cmdTrim.Text = "trim"
        Me.cmdTrim.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        Me.cmdReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReplace.Location = New System.Drawing.Point(125, 46)
        Me.cmdReplace.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(38, 30)
        Me.cmdReplace.TabIndex = 143
        Me.cmdReplace.Text = "replace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdTitle
        '
        Me.cmdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTitle.Location = New System.Drawing.Point(85, 15)
        Me.cmdTitle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.Size = New System.Drawing.Size(38, 30)
        Me.cmdTitle.TabIndex = 142
        Me.cmdTitle.Text = "title"
        Me.cmdTitle.UseVisualStyleBackColor = True
        '
        'cmdLower
        '
        Me.cmdLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLower.Location = New System.Drawing.Point(45, 15)
        Me.cmdLower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLower.Name = "cmdLower"
        Me.cmdLower.Size = New System.Drawing.Size(38, 30)
        Me.cmdLower.TabIndex = 141
        Me.cmdLower.Text = "lower"
        Me.cmdLower.UseVisualStyleBackColor = True
        '
        'cmdUpper
        '
        Me.cmdUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpper.Location = New System.Drawing.Point(5, 15)
        Me.cmdUpper.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdUpper.Name = "cmdUpper"
        Me.cmdUpper.Size = New System.Drawing.Size(38, 30)
        Me.cmdUpper.TabIndex = 140
        Me.cmdUpper.Text = "upper"
        Me.cmdUpper.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSort.Location = New System.Drawing.Point(85, 46)
        Me.cmdSort.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(38, 30)
        Me.cmdSort.TabIndex = 139
        Me.cmdSort.Text = "sort"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdOrder
        '
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOrder.Location = New System.Drawing.Point(45, 46)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(38, 30)
        Me.cmdOrder.TabIndex = 138
        Me.cmdOrder.Text = "order"
        Me.cmdOrder.UseVisualStyleBackColor = True
        '
        'cmdPad
        '
        Me.cmdPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPad.Location = New System.Drawing.Point(5, 46)
        Me.cmdPad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPad.Name = "cmdPad"
        Me.cmdPad.Size = New System.Drawing.Size(38, 30)
        Me.cmdPad.TabIndex = 137
        Me.cmdPad.Text = "pad"
        Me.cmdPad.UseVisualStyleBackColor = True
        '
        'cmdExtract
        '
        Me.cmdExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExtract.Location = New System.Drawing.Point(84, 108)
        Me.cmdExtract.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(80, 30)
        Me.cmdExtract.TabIndex = 136
        Me.cmdExtract.Text = "extract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCountstrings
        '
        Me.cmdCountstrings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCountstrings.Location = New System.Drawing.Point(45, 77)
        Me.cmdCountstrings.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCountstrings.Name = "cmdCountstrings"
        Me.cmdCountstrings.Size = New System.Drawing.Size(78, 30)
        Me.cmdCountstrings.TabIndex = 134
        Me.cmdCountstrings.Text = "count"
        Me.cmdCountstrings.UseVisualStyleBackColor = True
        '
        'cmdLocate
        '
        Me.cmdLocate.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLocate.Location = New System.Drawing.Point(5, 77)
        Me.cmdLocate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLocate.Name = "cmdLocate"
        Me.cmdLocate.Size = New System.Drawing.Size(38, 30)
        Me.cmdLocate.TabIndex = 133
        Me.cmdLocate.Text = "locate"
        Me.cmdLocate.UseVisualStyleBackColor = True
        '
        'grpLogical
        '
        Me.grpLogical.Controls.Add(Me.cmdOpeningBracket)
        Me.grpLogical.Controls.Add(Me.cmdColon)
        Me.grpLogical.Controls.Add(Me.cmdGreaterOrEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdClossingBracket)
        Me.grpLogical.Controls.Add(Me.cmdAnd)
        Me.grpLogical.Controls.Add(Me.cmdQuotes)
        Me.grpLogical.Controls.Add(Me.cmdSquareBrackets)
        Me.grpLogical.Controls.Add(Me.cmdIntegerDivision)
        Me.grpLogical.Controls.Add(Me.cmdModulas)
        Me.grpLogical.Controls.Add(Me.cmdGreater)
        Me.grpLogical.Controls.Add(Me.cmdLesserOrEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdLesser)
        Me.grpLogical.Controls.Add(Me.cmdOr)
        Me.grpLogical.Controls.Add(Me.cmdNot)
        Me.grpLogical.Controls.Add(Me.cmdNotEqualsTo)
        Me.grpLogical.Controls.Add(Me.cmdEquivalent)
        Me.grpLogical.Location = New System.Drawing.Point(433, 64)
        Me.grpLogical.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpLogical.Name = "grpLogical"
        Me.grpLogical.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpLogical.Size = New System.Drawing.Size(163, 148)
        Me.grpLogical.TabIndex = 183
        Me.grpLogical.TabStop = False
        Me.grpLogical.Text = "Logical and Symbols"
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(121, 77)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(38, 30)
        Me.cmdOpeningBracket.TabIndex = 139
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Location = New System.Drawing.Point(82, 77)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(38, 30)
        Me.cmdColon.TabIndex = 139
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdGreaterOrEqualsTo
        '
        Me.cmdGreaterOrEqualsTo.Location = New System.Drawing.Point(42, 109)
        Me.cmdGreaterOrEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGreaterOrEqualsTo.Name = "cmdGreaterOrEqualsTo"
        Me.cmdGreaterOrEqualsTo.Size = New System.Drawing.Size(38, 30)
        Me.cmdGreaterOrEqualsTo.TabIndex = 138
        Me.cmdGreaterOrEqualsTo.Text = ">="
        Me.cmdGreaterOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdClossingBracket
        '
        Me.cmdClossingBracket.Location = New System.Drawing.Point(122, 109)
        Me.cmdClossingBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClossingBracket.Name = "cmdClossingBracket"
        Me.cmdClossingBracket.Size = New System.Drawing.Size(38, 30)
        Me.cmdClossingBracket.TabIndex = 137
        Me.cmdClossingBracket.Tag = ""
        Me.cmdClossingBracket.Text = ")"
        Me.cmdClossingBracket.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        Me.cmdAnd.Location = New System.Drawing.Point(83, 109)
        Me.cmdAnd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Size = New System.Drawing.Size(38, 30)
        Me.cmdAnd.TabIndex = 137
        Me.cmdAnd.Tag = "And"
        Me.cmdAnd.Text = "And"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdQuotes
        '
        Me.cmdQuotes.Location = New System.Drawing.Point(121, 45)
        Me.cmdQuotes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.Size = New System.Drawing.Size(38, 30)
        Me.cmdQuotes.TabIndex = 135
        Me.cmdQuotes.Text = """ """
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        Me.cmdSquareBrackets.Location = New System.Drawing.Point(121, 13)
        Me.cmdSquareBrackets.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.Size = New System.Drawing.Size(38, 30)
        Me.cmdSquareBrackets.TabIndex = 134
        Me.cmdSquareBrackets.Text = "[ ]"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdIntegerDivision
        '
        Me.cmdIntegerDivision.Location = New System.Drawing.Point(82, 45)
        Me.cmdIntegerDivision.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIntegerDivision.Name = "cmdIntegerDivision"
        Me.cmdIntegerDivision.Size = New System.Drawing.Size(38, 30)
        Me.cmdIntegerDivision.TabIndex = 135
        Me.cmdIntegerDivision.Text = "%/%"
        Me.cmdIntegerDivision.UseVisualStyleBackColor = True
        '
        'cmdModulas
        '
        Me.cmdModulas.Location = New System.Drawing.Point(82, 13)
        Me.cmdModulas.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdModulas.Name = "cmdModulas"
        Me.cmdModulas.Size = New System.Drawing.Size(38, 30)
        Me.cmdModulas.TabIndex = 134
        Me.cmdModulas.Text = "%%"
        Me.cmdModulas.UseVisualStyleBackColor = True
        '
        'cmdGreater
        '
        Me.cmdGreater.Location = New System.Drawing.Point(42, 77)
        Me.cmdGreater.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.Size = New System.Drawing.Size(38, 30)
        Me.cmdGreater.TabIndex = 133
        Me.cmdGreater.Text = ">"
        Me.cmdGreater.UseVisualStyleBackColor = True
        '
        'cmdLesserOrEqualsTo
        '
        Me.cmdLesserOrEqualsTo.Location = New System.Drawing.Point(42, 45)
        Me.cmdLesserOrEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLesserOrEqualsTo.Name = "cmdLesserOrEqualsTo"
        Me.cmdLesserOrEqualsTo.Size = New System.Drawing.Size(38, 30)
        Me.cmdLesserOrEqualsTo.TabIndex = 132
        Me.cmdLesserOrEqualsTo.Text = "<="
        Me.cmdLesserOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdLesser
        '
        Me.cmdLesser.Location = New System.Drawing.Point(42, 13)
        Me.cmdLesser.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLesser.Name = "cmdLesser"
        Me.cmdLesser.Size = New System.Drawing.Size(38, 30)
        Me.cmdLesser.TabIndex = 131
        Me.cmdLesser.Text = "<"
        Me.cmdLesser.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        Me.cmdOr.Location = New System.Drawing.Point(2, 109)
        Me.cmdOr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.Size = New System.Drawing.Size(38, 30)
        Me.cmdOr.TabIndex = 130
        Me.cmdOr.Text = "|"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'cmdNot
        '
        Me.cmdNot.Location = New System.Drawing.Point(2, 77)
        Me.cmdNot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNot.Name = "cmdNot"
        Me.cmdNot.Size = New System.Drawing.Size(38, 30)
        Me.cmdNot.TabIndex = 129
        Me.cmdNot.Text = "!"
        Me.cmdNot.UseVisualStyleBackColor = True
        '
        'cmdNotEqualsTo
        '
        Me.cmdNotEqualsTo.Location = New System.Drawing.Point(2, 45)
        Me.cmdNotEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNotEqualsTo.Name = "cmdNotEqualsTo"
        Me.cmdNotEqualsTo.Size = New System.Drawing.Size(38, 30)
        Me.cmdNotEqualsTo.TabIndex = 128
        Me.cmdNotEqualsTo.Text = "!="
        Me.cmdNotEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdEquivalent
        '
        Me.cmdEquivalent.Location = New System.Drawing.Point(2, 13)
        Me.cmdEquivalent.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.Size = New System.Drawing.Size(38, 30)
        Me.cmdEquivalent.TabIndex = 127
        Me.cmdEquivalent.Text = "=="
        Me.cmdEquivalent.UseVisualStyleBackColor = True
        '
        'grpProbabilty
        '
        Me.grpProbabilty.Controls.Add(Me.cmdDigamma)
        Me.grpProbabilty.Controls.Add(Me.cmdGamma)
        Me.grpProbabilty.Controls.Add(Me.cmdLbeta)
        Me.grpProbabilty.Controls.Add(Me.cmdqF)
        Me.grpProbabilty.Controls.Add(Me.cmdFact)
        Me.grpProbabilty.Controls.Add(Me.cmdChoose)
        Me.grpProbabilty.Controls.Add(Me.cmdPf)
        Me.grpProbabilty.Controls.Add(Me.cmdPChisq)
        Me.grpProbabilty.Controls.Add(Me.cmdLgamma)
        Me.grpProbabilty.Controls.Add(Me.cmdPnorm)
        Me.grpProbabilty.Controls.Add(Me.cmdQchisq)
        Me.grpProbabilty.Controls.Add(Me.cmdQt)
        Me.grpProbabilty.Controls.Add(Me.cmdQnorm)
        Me.grpProbabilty.Controls.Add(Me.cmdPt)
        Me.grpProbabilty.Controls.Add(Me.cmdLchoose)
        Me.grpProbabilty.Controls.Add(Me.cmdLfact)
        Me.grpProbabilty.Controls.Add(Me.cmdTrigamma)
        Me.grpProbabilty.Controls.Add(Me.cmdBeta)
        Me.grpProbabilty.Location = New System.Drawing.Point(433, 64)
        Me.grpProbabilty.Name = "grpProbabilty"
        Me.grpProbabilty.Size = New System.Drawing.Size(334, 148)
        Me.grpProbabilty.TabIndex = 187
        Me.grpProbabilty.TabStop = False
        Me.grpProbabilty.Text = "Probability"
        '
        'cmdDigamma
        '
        Me.cmdDigamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDigamma.Location = New System.Drawing.Point(161, 108)
        Me.cmdDigamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDigamma.Name = "cmdDigamma"
        Me.cmdDigamma.Size = New System.Drawing.Size(92, 30)
        Me.cmdDigamma.TabIndex = 164
        Me.cmdDigamma.Text = "digamma"
        Me.cmdDigamma.UseVisualStyleBackColor = True
        '
        'cmdGamma
        '
        Me.cmdGamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGamma.Location = New System.Drawing.Point(2, 108)
        Me.cmdGamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGamma.Name = "cmdGamma"
        Me.cmdGamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdGamma.TabIndex = 163
        Me.cmdGamma.Tag = ""
        Me.cmdGamma.Text = "gamma"
        Me.cmdGamma.UseVisualStyleBackColor = True
        '
        'cmdLbeta
        '
        Me.cmdLbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLbeta.Location = New System.Drawing.Point(254, 77)
        Me.cmdLbeta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLbeta.Name = "cmdLbeta"
        Me.cmdLbeta.Size = New System.Drawing.Size(62, 30)
        Me.cmdLbeta.TabIndex = 159
        Me.cmdLbeta.Text = "lbeta"
        Me.cmdLbeta.UseVisualStyleBackColor = True
        '
        'cmdqF
        '
        Me.cmdqF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdqF.Location = New System.Drawing.Point(191, 15)
        Me.cmdqF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdqF.Name = "cmdqF"
        Me.cmdqF.Size = New System.Drawing.Size(62, 30)
        Me.cmdqF.TabIndex = 162
        Me.cmdqF.Text = "qF"
        Me.cmdqF.UseVisualStyleBackColor = True
        '
        'cmdFact
        '
        Me.cmdFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFact.Location = New System.Drawing.Point(254, 46)
        Me.cmdFact.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFact.Name = "cmdFact"
        Me.cmdFact.Size = New System.Drawing.Size(62, 30)
        Me.cmdFact.TabIndex = 154
        Me.cmdFact.Text = "fact"
        Me.cmdFact.UseVisualStyleBackColor = True
        '
        'cmdChoose
        '
        Me.cmdChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChoose.Location = New System.Drawing.Point(191, 46)
        Me.cmdChoose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdChoose.Name = "cmdChoose"
        Me.cmdChoose.Size = New System.Drawing.Size(62, 30)
        Me.cmdChoose.TabIndex = 161
        Me.cmdChoose.Text = "choose"
        Me.cmdChoose.UseVisualStyleBackColor = True
        '
        'cmdPf
        '
        Me.cmdPf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPf.Location = New System.Drawing.Point(128, 46)
        Me.cmdPf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPf.Name = "cmdPf"
        Me.cmdPf.Size = New System.Drawing.Size(62, 30)
        Me.cmdPf.TabIndex = 156
        Me.cmdPf.Text = "pF"
        Me.cmdPf.UseVisualStyleBackColor = True
        '
        'cmdPChisq
        '
        Me.cmdPChisq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPChisq.Location = New System.Drawing.Point(65, 46)
        Me.cmdPChisq.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPChisq.Name = "cmdPChisq"
        Me.cmdPChisq.Size = New System.Drawing.Size(62, 30)
        Me.cmdPChisq.TabIndex = 155
        Me.cmdPChisq.Text = "pchisq"
        Me.cmdPChisq.UseVisualStyleBackColor = True
        '
        'cmdLgamma
        '
        Me.cmdLgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLgamma.Location = New System.Drawing.Point(65, 108)
        Me.cmdLgamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLgamma.Name = "cmdLgamma"
        Me.cmdLgamma.Size = New System.Drawing.Size(95, 30)
        Me.cmdLgamma.TabIndex = 152
        Me.cmdLgamma.Text = "lgamma"
        Me.cmdLgamma.UseVisualStyleBackColor = True
        '
        'cmdPnorm
        '
        Me.cmdPnorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPnorm.Location = New System.Drawing.Point(254, 15)
        Me.cmdPnorm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPnorm.Name = "cmdPnorm"
        Me.cmdPnorm.Size = New System.Drawing.Size(62, 30)
        Me.cmdPnorm.TabIndex = 148
        Me.cmdPnorm.Text = "pnorm"
        Me.cmdPnorm.UseVisualStyleBackColor = True
        '
        'cmdQchisq
        '
        Me.cmdQchisq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQchisq.Location = New System.Drawing.Point(128, 15)
        Me.cmdQchisq.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQchisq.Name = "cmdQchisq"
        Me.cmdQchisq.Size = New System.Drawing.Size(62, 30)
        Me.cmdQchisq.TabIndex = 160
        Me.cmdQchisq.Text = "qchisq"
        Me.cmdQchisq.UseVisualStyleBackColor = True
        '
        'cmdQt
        '
        Me.cmdQt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQt.Location = New System.Drawing.Point(65, 15)
        Me.cmdQt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQt.Name = "cmdQt"
        Me.cmdQt.Size = New System.Drawing.Size(62, 30)
        Me.cmdQt.TabIndex = 158
        Me.cmdQt.Text = "qt"
        Me.cmdQt.UseVisualStyleBackColor = True
        '
        'cmdQnorm
        '
        Me.cmdQnorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQnorm.Location = New System.Drawing.Point(2, 15)
        Me.cmdQnorm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQnorm.Name = "cmdQnorm"
        Me.cmdQnorm.Size = New System.Drawing.Size(62, 30)
        Me.cmdQnorm.TabIndex = 157
        Me.cmdQnorm.Text = "qnorm"
        Me.cmdQnorm.UseVisualStyleBackColor = True
        '
        'cmdPt
        '
        Me.cmdPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPt.Location = New System.Drawing.Point(2, 46)
        Me.cmdPt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPt.Name = "cmdPt"
        Me.cmdPt.Size = New System.Drawing.Size(62, 30)
        Me.cmdPt.TabIndex = 153
        Me.cmdPt.Text = "pt"
        Me.cmdPt.UseVisualStyleBackColor = True
        '
        'cmdLchoose
        '
        Me.cmdLchoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLchoose.Location = New System.Drawing.Point(65, 77)
        Me.cmdLchoose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLchoose.Name = "cmdLchoose"
        Me.cmdLchoose.Size = New System.Drawing.Size(95, 30)
        Me.cmdLchoose.TabIndex = 151
        Me.cmdLchoose.Text = "lchoose"
        Me.cmdLchoose.UseVisualStyleBackColor = True
        '
        'cmdLfact
        '
        Me.cmdLfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLfact.Location = New System.Drawing.Point(161, 77)
        Me.cmdLfact.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLfact.Name = "cmdLfact"
        Me.cmdLfact.Size = New System.Drawing.Size(92, 30)
        Me.cmdLfact.TabIndex = 150
        Me.cmdLfact.Text = "lfact"
        Me.cmdLfact.UseVisualStyleBackColor = True
        '
        'cmdTrigamma
        '
        Me.cmdTrigamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTrigamma.Location = New System.Drawing.Point(254, 108)
        Me.cmdTrigamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrigamma.Name = "cmdTrigamma"
        Me.cmdTrigamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdTrigamma.TabIndex = 149
        Me.cmdTrigamma.Text = "trigamma"
        Me.cmdTrigamma.UseVisualStyleBackColor = True
        '
        'cmdBeta
        '
        Me.cmdBeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBeta.Location = New System.Drawing.Point(2, 77)
        Me.cmdBeta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBeta.Name = "cmdBeta"
        Me.cmdBeta.Size = New System.Drawing.Size(62, 30)
        Me.cmdBeta.TabIndex = 149
        Me.cmdBeta.Text = "beta"
        Me.cmdBeta.UseVisualStyleBackColor = True
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
        Me.grpMaths.Location = New System.Drawing.Point(433, 64)
        Me.grpMaths.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMaths.Name = "grpMaths"
        Me.grpMaths.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMaths.Size = New System.Drawing.Size(208, 148)
        Me.grpMaths.TabIndex = 184
        Me.grpMaths.TabStop = False
        Me.grpMaths.Text = "Maths"
        '
        'cmdSign
        '
        Me.cmdSign.Location = New System.Drawing.Point(166, 110)
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
        Me.cmdRound.Location = New System.Drawing.Point(125, 110)
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
        Me.cmdSiginf.Location = New System.Drawing.Point(84, 110)
        Me.cmdSiginf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSiginf.Name = "cmdSiginf"
        Me.cmdSiginf.Size = New System.Drawing.Size(38, 30)
        Me.cmdSiginf.TabIndex = 145
        Me.cmdSiginf.Text = "siginf"
        Me.cmdSiginf.UseVisualStyleBackColor = True
        '
        'cmdAbs
        '
        Me.cmdAbs.Location = New System.Drawing.Point(43, 110)
        Me.cmdAbs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.Size = New System.Drawing.Size(38, 30)
        Me.cmdAbs.TabIndex = 144
        Me.cmdAbs.Text = "abs"
        Me.cmdAbs.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.Location = New System.Drawing.Point(2, 110)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(38, 30)
        Me.cmdExp.TabIndex = 143
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdDeg
        '
        Me.cmdDeg.Location = New System.Drawing.Point(166, 78)
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
        Me.cmdTrunc.Location = New System.Drawing.Point(125, 78)
        Me.cmdTrunc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrunc.Name = "cmdTrunc"
        Me.cmdTrunc.Size = New System.Drawing.Size(38, 30)
        Me.cmdTrunc.TabIndex = 141
        Me.cmdTrunc.Text = "trunc"
        Me.cmdTrunc.UseVisualStyleBackColor = True
        '
        'cmdAtan
        '
        Me.cmdAtan.Location = New System.Drawing.Point(84, 78)
        Me.cmdAtan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAtan.Name = "cmdAtan"
        Me.cmdAtan.Size = New System.Drawing.Size(38, 30)
        Me.cmdAtan.TabIndex = 140
        Me.cmdAtan.Text = "atan"
        Me.cmdAtan.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.Location = New System.Drawing.Point(43, 78)
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
        Me.cmdLogTen.Location = New System.Drawing.Point(2, 78)
        Me.cmdLogTen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLogTen.Name = "cmdLogTen"
        Me.cmdLogTen.Size = New System.Drawing.Size(38, 30)
        Me.cmdLogTen.TabIndex = 138
        Me.cmdLogTen.Text = "log10"
        Me.cmdLogTen.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        Me.cmdRad.Location = New System.Drawing.Point(166, 46)
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
        Me.cmdFloor.Location = New System.Drawing.Point(125, 46)
        Me.cmdFloor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFloor.Name = "cmdFloor"
        Me.cmdFloor.Size = New System.Drawing.Size(38, 30)
        Me.cmdFloor.TabIndex = 136
        Me.cmdFloor.Text = "floor"
        Me.cmdFloor.UseVisualStyleBackColor = True
        '
        'cmdAsin
        '
        Me.cmdAsin.Location = New System.Drawing.Point(84, 46)
        Me.cmdAsin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAsin.Name = "cmdAsin"
        Me.cmdAsin.Size = New System.Drawing.Size(38, 30)
        Me.cmdAsin.TabIndex = 135
        Me.cmdAsin.Text = "asin"
        Me.cmdAsin.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.Location = New System.Drawing.Point(43, 46)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(38, 30)
        Me.cmdSin.TabIndex = 134
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.Location = New System.Drawing.Point(2, 46)
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
        Me.grpStatistics.Location = New System.Drawing.Point(433, 64)
        Me.grpStatistics.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStatistics.Name = "grpStatistics"
        Me.grpStatistics.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpStatistics.Size = New System.Drawing.Size(120, 148)
        Me.grpStatistics.TabIndex = 185
        Me.grpStatistics.TabStop = False
        Me.grpStatistics.Text = "Statistics"
        '
        'cmdIQR
        '
        Me.cmdIQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdIQR.Location = New System.Drawing.Point(82, 109)
        Me.cmdIQR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIQR.Name = "cmdIQR"
        Me.cmdIQR.Size = New System.Drawing.Size(38, 30)
        Me.cmdIQR.TabIndex = 165
        Me.cmdIQR.Text = "IQR"
        Me.cmdIQR.UseVisualStyleBackColor = True
        '
        'cmdQuantile
        '
        Me.cmdQuantile.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuantile.Location = New System.Drawing.Point(43, 109)
        Me.cmdQuantile.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuantile.Name = "cmdQuantile"
        Me.cmdQuantile.Size = New System.Drawing.Size(38, 30)
        Me.cmdQuantile.TabIndex = 164
        Me.cmdQuantile.Text = "quantile"
        Me.cmdQuantile.UseVisualStyleBackColor = True
        '
        'cmdRange
        '
        Me.cmdRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRange.Location = New System.Drawing.Point(4, 109)
        Me.cmdRange.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRange.Name = "cmdRange"
        Me.cmdRange.Size = New System.Drawing.Size(38, 30)
        Me.cmdRange.TabIndex = 163
        Me.cmdRange.Text = "range"
        Me.cmdRange.UseVisualStyleBackColor = True
        '
        'cmdSd
        '
        Me.cmdSd.Location = New System.Drawing.Point(82, 78)
        Me.cmdSd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSd.Name = "cmdSd"
        Me.cmdSd.Size = New System.Drawing.Size(38, 30)
        Me.cmdSd.TabIndex = 160
        Me.cmdSd.Text = "sd"
        Me.cmdSd.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        Me.cmdVar.Location = New System.Drawing.Point(43, 78)
        Me.cmdVar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdVar.Name = "cmdVar"
        Me.cmdVar.Size = New System.Drawing.Size(38, 30)
        Me.cmdVar.TabIndex = 159
        Me.cmdVar.Text = "var"
        Me.cmdVar.UseVisualStyleBackColor = True
        '
        'cmdMedian
        '
        Me.cmdMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMedian.Location = New System.Drawing.Point(4, 78)
        Me.cmdMedian.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMedian.Name = "cmdMedian"
        Me.cmdMedian.Size = New System.Drawing.Size(38, 30)
        Me.cmdMedian.TabIndex = 158
        Me.cmdMedian.Text = "median"
        Me.cmdMedian.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        Me.cmdMin.Location = New System.Drawing.Point(82, 46)
        Me.cmdMin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(38, 30)
        Me.cmdMin.TabIndex = 155
        Me.cmdMin.Text = "min"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdMax
        '
        Me.cmdMax.Location = New System.Drawing.Point(43, 46)
        Me.cmdMax.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.Size = New System.Drawing.Size(38, 30)
        Me.cmdMax.TabIndex = 154
        Me.cmdMax.Text = "max"
        Me.cmdMax.UseVisualStyleBackColor = True
        '
        'cmdMean
        '
        Me.cmdMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMean.Location = New System.Drawing.Point(4, 46)
        Me.cmdMean.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMean.Name = "cmdMean"
        Me.cmdMean.Size = New System.Drawing.Size(38, 30)
        Me.cmdMean.TabIndex = 153
        Me.cmdMean.Text = "mean"
        Me.cmdMean.UseVisualStyleBackColor = True
        '
        'cmdSum
        '
        Me.cmdSum.Location = New System.Drawing.Point(82, 14)
        Me.cmdSum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSum.Name = "cmdSum"
        Me.cmdSum.Size = New System.Drawing.Size(38, 30)
        Me.cmdSum.TabIndex = 150
        Me.cmdSum.Text = "sum"
        Me.cmdSum.UseVisualStyleBackColor = True
        '
        'cmdMiss
        '
        Me.cmdMiss.Location = New System.Drawing.Point(43, 14)
        Me.cmdMiss.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMiss.Name = "cmdMiss"
        Me.cmdMiss.Size = New System.Drawing.Size(38, 30)
        Me.cmdMiss.TabIndex = 149
        Me.cmdMiss.Text = "miss"
        Me.cmdMiss.UseVisualStyleBackColor = True
        '
        'cmdCount
        '
        Me.cmdCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCount.Location = New System.Drawing.Point(4, 14)
        Me.cmdCount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCount.Name = "cmdCount"
        Me.cmdCount.Size = New System.Drawing.Size(38, 30)
        Me.cmdCount.TabIndex = 148
        Me.cmdCount.Text = "count"
        Me.cmdCount.UseVisualStyleBackColor = True
        '
        'ucrCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.grpRows)
        Me.Controls.Add(Me.grpStrings)
        Me.Controls.Add(Me.grpLogical)
        Me.Controls.Add(Me.grpProbabilty)
        Me.Controls.Add(Me.grpMaths)
        Me.Controls.Add(Me.grpStatistics)
        Me.Controls.Add(Me.cmdHelp)
        Me.Controls.Add(Me.chkShowArguments)
        Me.Controls.Add(Me.ucrInputCalOptions)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.ucrSaveResultInto)
        Me.Controls.Add(Me.chkSaveResultInto)
        Me.Controls.Add(Me.ucrInputTryMessage)
        Me.Controls.Add(Me.cmdTry)
        Me.Controls.Add(Me.ucrSelectorForCalculations)
        Me.Controls.Add(Me.ucrReceiverForCalculation)
        Me.Controls.Add(Me.lblExpression)
        Me.Name = "ucrCalculator"
        Me.Size = New System.Drawing.Size(491, 322)
        Me.grpBasic.ResumeLayout(False)
        Me.grpDates.ResumeLayout(False)
        Me.grpRows.ResumeLayout(False)
        Me.grpStrings.ResumeLayout(False)
        Me.grpLogical.ResumeLayout(False)
        Me.grpProbabilty.ResumeLayout(False)
        Me.grpMaths.ResumeLayout(False)
        Me.grpStatistics.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverForCalculation As ucrReceiverExpression
    Friend WithEvents lblExpression As Label
    Friend WithEvents ucrSaveResultInto As ucrInputComboBox
    Friend WithEvents chkSaveResultInto As CheckBox
    Friend WithEvents ucrInputTryMessage As ucrInputTextBox
    Friend WithEvents cmdTry As Button
    Friend WithEvents ucrSelectorForCalculations As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdHelp As Button
    Friend WithEvents chkShowArguments As CheckBox
    Friend WithEvents ucrInputCalOptions As ucrInputComboBox
    Friend WithEvents grpBasic As GroupBox
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdPower As Button
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
    Friend WithEvents grpDates As GroupBox
    Friend WithEvents cmdDmy As Button
    Friend WithEvents cmdDek As Button
    Friend WithEvents cmdDay As Button
    Friend WithEvents cmdMonth As Button
    Friend WithEvents cmdYear As Button
    Friend WithEvents cmdDate As Button
    Friend WithEvents cmdYday As Button
    Friend WithEvents cmdWday As Button
    Friend WithEvents cmdMdy As Button
    Friend WithEvents cmdYmd As Button
    Friend WithEvents cmdDoy As Button
    Friend WithEvents cmdLeap As Button
    Friend WithEvents grpRows As GroupBox
    Friend WithEvents cmdpercentrank As Button
    Friend WithEvents cmdcumsum As Button
    Friend WithEvents cmdcummin As Button
    Friend WithEvents cmdcummax As Button
    Friend WithEvents cmdPMin As Button
    Friend WithEvents cmdpmax As Button
    Friend WithEvents cmdLead As Button
    Friend WithEvents cmdLag As Button
    Friend WithEvents grpStrings As GroupBox
    Friend WithEvents cmdSplit As Button
    Friend WithEvents cmdCombine As Button
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
    Friend WithEvents cmdCountstrings As Button
    Friend WithEvents cmdLocate As Button
    Friend WithEvents grpLogical As GroupBox
    Friend WithEvents cmdOpeningBracket As Button
    Friend WithEvents cmdColon As Button
    Friend WithEvents cmdGreaterOrEqualsTo As Button
    Friend WithEvents cmdClossingBracket As Button
    Friend WithEvents cmdAnd As Button
    Friend WithEvents cmdQuotes As Button
    Friend WithEvents cmdSquareBrackets As Button
    Friend WithEvents cmdIntegerDivision As Button
    Friend WithEvents cmdModulas As Button
    Friend WithEvents cmdGreater As Button
    Friend WithEvents cmdLesserOrEqualsTo As Button
    Friend WithEvents cmdLesser As Button
    Friend WithEvents cmdOr As Button
    Friend WithEvents cmdNot As Button
    Friend WithEvents cmdNotEqualsTo As Button
    Friend WithEvents cmdEquivalent As Button
    Friend WithEvents grpProbabilty As GroupBox
    Friend WithEvents cmdDigamma As Button
    Friend WithEvents cmdGamma As Button
    Friend WithEvents cmdLbeta As Button
    Friend WithEvents cmdqF As Button
    Friend WithEvents cmdFact As Button
    Friend WithEvents cmdChoose As Button
    Friend WithEvents cmdPf As Button
    Friend WithEvents cmdPChisq As Button
    Friend WithEvents cmdLgamma As Button
    Friend WithEvents cmdPnorm As Button
    Friend WithEvents cmdQchisq As Button
    Friend WithEvents cmdQt As Button
    Friend WithEvents cmdQnorm As Button
    Friend WithEvents cmdPt As Button
    Friend WithEvents cmdLchoose As Button
    Friend WithEvents cmdLfact As Button
    Friend WithEvents cmdTrigamma As Button
    Friend WithEvents cmdBeta As Button
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
    Friend WithEvents grpStatistics As GroupBox
    Friend WithEvents cmdIQR As Button
    Friend WithEvents cmdQuantile As Button
    Friend WithEvents cmdRange As Button
    Friend WithEvents cmdSd As Button
    Friend WithEvents cmdVar As Button
    Friend WithEvents cmdMedian As Button
    Friend WithEvents cmdMin As Button
    Friend WithEvents cmdMax As Button
    Friend WithEvents cmdMean As Button
    Friend WithEvents cmdSum As Button
    Friend WithEvents cmdMiss As Button
    Friend WithEvents cmdCount As Button
End Class
