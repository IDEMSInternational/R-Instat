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
        Me.components = New System.ComponentModel.Container()
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.cmdRHelp = New System.Windows.Forms.Button()
        Me.chkShowParameters = New System.Windows.Forms.CheckBox()
        Me.grpBasic = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdComma = New System.Windows.Forms.Button()
        Me.cmdBrackets = New System.Windows.Forms.Button()
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
        Me.cmdPm = New System.Windows.Forms.Button()
        Me.cmdTime = New System.Windows.Forms.Button()
        Me.cmdDateTime = New System.Windows.Forms.Button()
        Me.cmdQuarter = New System.Windows.Forms.Button()
        Me.cmdD_In_M = New System.Windows.Forms.Button()
        Me.cmdAm = New System.Windows.Forms.Button()
        Me.cmdSec = New System.Windows.Forms.Button()
        Me.cmdHour = New System.Windows.Forms.Button()
        Me.cmdminutes = New System.Windows.Forms.Button()
        Me.cmdDmy = New System.Windows.Forms.Button()
        Me.cmdDay = New System.Windows.Forms.Button()
        Me.cmdMonth = New System.Windows.Forms.Button()
        Me.cmdYear = New System.Windows.Forms.Button()
        Me.cmdDate = New System.Windows.Forms.Button()
        Me.cmdYday = New System.Windows.Forms.Button()
        Me.cmdWday = New System.Windows.Forms.Button()
        Me.cmdMdy = New System.Windows.Forms.Button()
        Me.cmdYmd = New System.Windows.Forms.Button()
        Me.cmdLeap = New System.Windows.Forms.Button()
        Me.grpFactor = New System.Windows.Forms.GroupBox()
        Me.cmdTransformHelp = New System.Windows.Forms.Button()
        Me.cmdShuffle = New System.Windows.Forms.Button()
        Me.cmdShift = New System.Windows.Forms.Button()
        Me.cmdReverse = New System.Windows.Forms.Button()
        Me.cmdReorder = New System.Windows.Forms.Button()
        Me.cmdRelevel = New System.Windows.Forms.Button()
        Me.cmdRecode = New System.Windows.Forms.Button()
        Me.cmdOther = New System.Windows.Forms.Button()
        Me.cmdFmatch = New System.Windows.Forms.Button()
        Me.cmdLump = New System.Windows.Forms.Button()
        Me.cmdInseq = New System.Windows.Forms.Button()
        Me.cmdInfreq = New System.Windows.Forms.Button()
        Me.cmdInorder = New System.Windows.Forms.Button()
        Me.cmdAdd_na = New System.Windows.Forms.Button()
        Me.cmdExpand = New System.Windows.Forms.Button()
        Me.cmdDrop = New System.Windows.Forms.Button()
        Me.cmdCross = New System.Windows.Forms.Button()
        Me.cmdCollapse = New System.Windows.Forms.Button()
        Me.cmdLabelled = New System.Windows.Forms.Button()
        Me.cmdFactor = New System.Windows.Forms.Button()
        Me.cmdAnon = New System.Windows.Forms.Button()
        Me.grpHydroGOF = New System.Windows.Forms.GroupBox()
        Me.cmdHydroHelp = New System.Windows.Forms.Button()
        Me.cmdVE = New System.Windows.Forms.Button()
        Me.cmdSsq = New System.Windows.Forms.Button()
        Me.cmdRsr = New System.Windows.Forms.Button()
        Me.cmdRSD = New System.Windows.Forms.Button()
        Me.cmdRPearson = New System.Windows.Forms.Button()
        Me.cmdRNSE = New System.Windows.Forms.Button()
        Me.cmdRmse = New System.Windows.Forms.Button()
        Me.cmdRd = New System.Windows.Forms.Button()
        Me.cmdPbiasfde = New System.Windows.Forms.Button()
        Me.cmdPbias = New System.Windows.Forms.Button()
        Me.cmdNSE = New System.Windows.Forms.Button()
        Me.cmdNrmse = New System.Windows.Forms.Button()
        Me.cmdMse = New System.Windows.Forms.Button()
        Me.cmdmNSE = New System.Windows.Forms.Button()
        Me.cmdMe = New System.Windows.Forms.Button()
        Me.cmdMd = New System.Windows.Forms.Button()
        Me.cmdMae = New System.Windows.Forms.Button()
        Me.cmdKGE = New System.Windows.Forms.Button()
        Me.cmdD = New System.Windows.Forms.Button()
        Me.cmdCp = New System.Windows.Forms.Button()
        Me.cmdBr2 = New System.Windows.Forms.Button()
        Me.grpWakefield = New System.Windows.Forms.GroupBox()
        Me.cmdLinkert7 = New System.Windows.Forms.Button()
        Me.cmdWakefield_Year = New System.Windows.Forms.Button()
        Me.cmdValid = New System.Windows.Forms.Button()
        Me.cmdWakefield_Upper = New System.Windows.Forms.Button()
        Me.cmdString = New System.Windows.Forms.Button()
        Me.cmdState = New System.Windows.Forms.Button()
        Me.cmdSpeed = New System.Windows.Forms.Button()
        Me.cmdSmokes = New System.Windows.Forms.Button()
        Me.cmdSex = New System.Windows.Forms.Button()
        Me.cmdSex_Inclusive = New System.Windows.Forms.Button()
        Me.cmdGender = New System.Windows.Forms.Button()
        Me.cmdSentence = New System.Windows.Forms.Button()
        Me.cmdSat = New System.Windows.Forms.Button()
        Me.cmdReligion = New System.Windows.Forms.Button()
        Me.cmdRace = New System.Windows.Forms.Button()
        Me.cmdPolitical = New System.Windows.Forms.Button()
        Me.cmdNormal = New System.Windows.Forms.Button()
        Me.cmdName = New System.Windows.Forms.Button()
        Me.cmdWakefield_Month = New System.Windows.Forms.Button()
        Me.cmdMilitary = New System.Windows.Forms.Button()
        Me.cmdMarital = New System.Windows.Forms.Button()
        Me.cmdLorem_ipsum = New System.Windows.Forms.Button()
        Me.cmdLikert = New System.Windows.Forms.Button()
        Me.cmdGpa = New System.Windows.Forms.Button()
        Me.cmdEla = New System.Windows.Forms.Button()
        Me.cmdMath = New System.Windows.Forms.Button()
        Me.cmdLevel = New System.Windows.Forms.Button()
        Me.cmdLanguage = New System.Windows.Forms.Button()
        Me.cmdIq = New System.Windows.Forms.Button()
        Me.cmdInternet_Browser = New System.Windows.Forms.Button()
        Me.cmdGrade_Level = New System.Windows.Forms.Button()
        Me.cmdEye = New System.Windows.Forms.Button()
        Me.cmdEmployment = New System.Windows.Forms.Button()
        Me.cmdEducation = New System.Windows.Forms.Button()
        Me.cmdDummy = New System.Windows.Forms.Button()
        Me.cmdDob = New System.Windows.Forms.Button()
        Me.cmdDna = New System.Windows.Forms.Button()
        Me.cmdDice = New System.Windows.Forms.Button()
        Me.cmdDied = New System.Windows.Forms.Button()
        Me.cmdDeath = New System.Windows.Forms.Button()
        Me.cmdDate_Stamp = New System.Windows.Forms.Button()
        Me.cmdPrimary = New System.Windows.Forms.Button()
        Me.cmdColor = New System.Windows.Forms.Button()
        Me.cmdCoin = New System.Windows.Forms.Button()
        Me.cmdChildren = New System.Windows.Forms.Button()
        Me.cmdCar = New System.Windows.Forms.Button()
        Me.cmdAnswer = New System.Windows.Forms.Button()
        Me.cmdPet = New System.Windows.Forms.Button()
        Me.cmdAnimal = New System.Windows.Forms.Button()
        Me.cmdAge = New System.Windows.Forms.Button()
        Me.cmdIncome = New System.Windows.Forms.Button()
        Me.cmdHeight = New System.Windows.Forms.Button()
        Me.cmdHair = New System.Windows.Forms.Button()
        Me.cmdGroup = New System.Windows.Forms.Button()
        Me.cmdGrade = New System.Windows.Forms.Button()
        Me.cmdWakefieldHelp = New System.Windows.Forms.Button()
        Me.grpMaths = New System.Windows.Forms.GroupBox()
        Me.cmdMathsHelp = New System.Windows.Forms.Button()
        Me.cmdAtan2 = New System.Windows.Forms.Button()
        Me.cmdLogistic = New System.Windows.Forms.Button()
        Me.cmdLogit = New System.Windows.Forms.Button()
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
        Me.grpSummary = New System.Windows.Forms.GroupBox()
        Me.cmdSummaryHelp = New System.Windows.Forms.Button()
        Me.cmdKurtosis = New System.Windows.Forms.Button()
        Me.cmdMode1 = New System.Windows.Forms.Button()
        Me.cmdMode = New System.Windows.Forms.Button()
        Me.cmdFirst = New System.Windows.Forms.Button()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdnth = New System.Windows.Forms.Button()
        Me.cmdCor = New System.Windows.Forms.Button()
        Me.cmdCov = New System.Windows.Forms.Button()
        Me.cmdMad = New System.Windows.Forms.Button()
        Me.cmdMc = New System.Windows.Forms.Button()
        Me.cmdPropn = New System.Windows.Forms.Button()
        Me.cmdCv = New System.Windows.Forms.Button()
        Me.cmdSkew = New System.Windows.Forms.Button()
        Me.cmdAnyDup = New System.Windows.Forms.Button()
        Me.cmdDistinct = New System.Windows.Forms.Button()
        Me.cmdNonMiss = New System.Windows.Forms.Button()
        Me.cmdIQR = New System.Windows.Forms.Button()
        Me.cmdQuantile = New System.Windows.Forms.Button()
        Me.cmdRange = New System.Windows.Forms.Button()
        Me.cmdSd = New System.Windows.Forms.Button()
        Me.cmdMedian = New System.Windows.Forms.Button()
        Me.cmdMin = New System.Windows.Forms.Button()
        Me.cmdMax = New System.Windows.Forms.Button()
        Me.cmdMean = New System.Windows.Forms.Button()
        Me.cmdMiss = New System.Windows.Forms.Button()
        Me.cmdLength = New System.Windows.Forms.Button()
        Me.cmdSum = New System.Windows.Forms.Button()
        Me.cmdVar = New System.Windows.Forms.Button()
        Me.grpTransform = New System.Windows.Forms.GroupBox()
        Me.cmdHelpZoo = New System.Windows.Forms.Button()
        Me.cmdHelpDplyr = New System.Windows.Forms.Button()
        Me.cmdSortF = New System.Windows.Forms.Button()
        Me.cmdNasplin = New System.Windows.Forms.Button()
        Me.cmdNaapprox = New System.Windows.Forms.Button()
        Me.cmdNaest = New System.Windows.Forms.Button()
        Me.cmdNafill = New System.Windows.Forms.Button()
        Me.cmdMovmin = New System.Windows.Forms.Button()
        Me.cmdRowRank = New System.Windows.Forms.Button()
        Me.cmdDiff = New System.Windows.Forms.Button()
        Me.cmdCumdist = New System.Windows.Forms.Button()
        Me.cmdmovemean = New System.Windows.Forms.Button()
        Me.cmdCumMean = New System.Windows.Forms.Button()
        Me.cmdNtile = New System.Windows.Forms.Button()
        Me.cmMovMed = New System.Windows.Forms.Button()
        Me.cmdMRank = New System.Windows.Forms.Button()
        Me.cmdDRank = New System.Windows.Forms.Button()
        Me.cmdMovMax = New System.Windows.Forms.Button()
        Me.cmdMovSum = New System.Windows.Forms.Button()
        Me.cmdpercentrank = New System.Windows.Forms.Button()
        Me.cmdcumsum = New System.Windows.Forms.Button()
        Me.cmdcummin = New System.Windows.Forms.Button()
        Me.cmdcummax = New System.Windows.Forms.Button()
        Me.cmdPMin = New System.Windows.Forms.Button()
        Me.cmdpmax = New System.Windows.Forms.Button()
        Me.cmdLead = New System.Windows.Forms.Button()
        Me.cmdLag = New System.Windows.Forms.Button()
        Me.grpProbabilty = New System.Windows.Forms.GroupBox()
        Me.cmdProbRHelp = New System.Windows.Forms.Button()
        Me.cmdQnbin = New System.Windows.Forms.Button()
        Me.cmdQpois = New System.Windows.Forms.Button()
        Me.cmdQbinom = New System.Windows.Forms.Button()
        Me.cmdQbirth = New System.Windows.Forms.Button()
        Me.cmdQbeta = New System.Windows.Forms.Button()
        Me.cmdPnbin = New System.Windows.Forms.Button()
        Me.cmdPpois = New System.Windows.Forms.Button()
        Me.cmdPbinom = New System.Windows.Forms.Button()
        Me.cmdPbirth = New System.Windows.Forms.Button()
        Me.cmdPbeta = New System.Windows.Forms.Button()
        Me.cmdQgamma = New System.Windows.Forms.Button()
        Me.cmdPgamma = New System.Windows.Forms.Button()
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
        Me.cmdDigamma = New System.Windows.Forms.Button()
        Me.grpLogical = New System.Windows.Forms.GroupBox()
        Me.cmdLogicalHelp = New System.Windows.Forms.Button()
        Me.cmdFalse = New System.Windows.Forms.Button()
        Me.cmdTrue = New System.Windows.Forms.Button()
        Me.cmdDoubleSqrBrackets = New System.Windows.Forms.Button()
        Me.cmdIn = New System.Windows.Forms.Button()
        Me.cmdWhich = New System.Windows.Forms.Button()
        Me.cmdNA = New System.Windows.Forms.Button()
        Me.cmdNear = New System.Windows.Forms.Button()
        Me.cmdBetween = New System.Windows.Forms.Button()
        Me.cmdIsNa = New System.Windows.Forms.Button()
        Me.cmdNotIsNa = New System.Windows.Forms.Button()
        Me.cmdDuplicate = New System.Windows.Forms.Button()
        Me.cmdIfelse = New System.Windows.Forms.Button()
        Me.cmdmatch = New System.Windows.Forms.Button()
        Me.cmdwhen = New System.Windows.Forms.Button()
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
        Me.grpTestString = New System.Windows.Forms.GroupBox()
        Me.cmdEnds = New System.Windows.Forms.Button()
        Me.cmdTrunck = New System.Windows.Forms.Button()
        Me.cmdLenth = New System.Windows.Forms.Button()
        Me.cmdGlue = New System.Windows.Forms.Button()
        Me.cmdStarts = New System.Windows.Forms.Button()
        Me.cmdReplace2 = New System.Windows.Forms.Button()
        Me.cmdReplace = New System.Windows.Forms.Button()
        Me.cmdRemove2 = New System.Windows.Forms.Button()
        Me.cmdRemove1 = New System.Windows.Forms.Button()
        Me.cmdLocate2 = New System.Windows.Forms.Button()
        Me.cmdExtract2 = New System.Windows.Forms.Button()
        Me.cmdEncodeb = New System.Windows.Forms.Button()
        Me.cmdSquishb = New System.Windows.Forms.Button()
        Me.cmdSub = New System.Windows.Forms.Button()
        Me.cmdCombine = New System.Windows.Forms.Button()
        Me.cmdDetect = New System.Windows.Forms.Button()
        Me.cmdTrim = New System.Windows.Forms.Button()
        Me.cmdTitle = New System.Windows.Forms.Button()
        Me.cmdLower = New System.Windows.Forms.Button()
        Me.cmdUpper = New System.Windows.Forms.Button()
        Me.cmdSort = New System.Windows.Forms.Button()
        Me.cmdOrder = New System.Windows.Forms.Button()
        Me.cmdPad = New System.Windows.Forms.Button()
        Me.cmdExtract = New System.Windows.Forms.Button()
        Me.cmdCountstrings = New System.Windows.Forms.Button()
        Me.cmdLocate = New System.Windows.Forms.Button()
        Me.ttCalculator = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCircular = New System.Windows.Forms.GroupBox()
        Me.cmdCircularHelp = New System.Windows.Forms.Button()
        Me.cmdCircular = New System.Windows.Forms.Button()
        Me.cmdCircQuantile = New System.Windows.Forms.Button()
        Me.cmdCircMax = New System.Windows.Forms.Button()
        Me.cmdA1 = New System.Windows.Forms.Button()
        Me.cmdAngVar = New System.Windows.Forms.Button()
        Me.cmdCircRho = New System.Windows.Forms.Button()
        Me.cmdCircQ3 = New System.Windows.Forms.Button()
        Me.cmdCircQ1 = New System.Windows.Forms.Button()
        Me.cmdCircMin = New System.Windows.Forms.Button()
        Me.cmdAngDev = New System.Windows.Forms.Button()
        Me.cmdCircVar = New System.Windows.Forms.Button()
        Me.cmdCircSd = New System.Windows.Forms.Button()
        Me.cmdCircRange = New System.Windows.Forms.Button()
        Me.cmdMedianHL = New System.Windows.Forms.Button()
        Me.cmdCircMedian = New System.Windows.Forms.Button()
        Me.cmdCircMean = New System.Windows.Forms.Button()
        Me.grpModifier = New System.Windows.Forms.GroupBox()
        Me.cmdRegex = New System.Windows.Forms.Button()
        Me.cmdFixed = New System.Windows.Forms.Button()
        Me.cmdCollate = New System.Windows.Forms.Button()
        Me.cmdBoundary = New System.Windows.Forms.Button()
        Me.grpSymbols = New System.Windows.Forms.GroupBox()
        Me.cmdOr3 = New System.Windows.Forms.Button()
        Me.cmdEscape = New System.Windows.Forms.Button()
        Me.cmdPlusZero = New System.Windows.Forms.Button()
        Me.cmdZero = New System.Windows.Forms.Button()
        Me.cmdPlusOne = New System.Windows.Forms.Button()
        Me.cmdZeroOrOne = New System.Windows.Forms.Button()
        Me.cmdNumbers = New System.Windows.Forms.Button()
        Me.cmdNot1 = New System.Windows.Forms.Button()
        Me.cmdOr2 = New System.Windows.Forms.Button()
        Me.cmdOr1 = New System.Windows.Forms.Button()
        Me.cmdSpace = New System.Windows.Forms.Button()
        Me.cmdDigit = New System.Windows.Forms.Button()
        Me.cmdEnd1 = New System.Windows.Forms.Button()
        Me.cmdbegin = New System.Windows.Forms.Button()
        Me.cmdAny1 = New System.Windows.Forms.Button()
        Me.cmdStringRHelp = New System.Windows.Forms.Button()
        Me.ucrSaveResultInto = New instat.ucrSave()
        Me.ucrTryCalculator = New instat.ucrTry()
        Me.ucrInputCalOptions = New instat.ucrInputComboBox()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForCalculation = New instat.ucrReceiverExpression()
        Me.grpBasic.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpFactor.SuspendLayout()
        Me.grpHydroGOF.SuspendLayout()
        Me.grpWakefield.SuspendLayout()
        Me.grpMaths.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.grpTransform.SuspendLayout()
        Me.grpProbabilty.SuspendLayout()
        Me.grpLogical.SuspendLayout()
        Me.grpTestString.SuspendLayout()
        Me.grpCircular.SuspendLayout()
        Me.grpModifier.SuspendLayout()
        Me.grpSymbols.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpression.Location = New System.Drawing.Point(6, 10)
        Me.lblExpression.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(61, 13)
        Me.lblExpression.TabIndex = 119
        Me.lblExpression.Tag = "Expression"
        Me.lblExpression.Text = "Expression:"
        '
        'cmdRHelp
        '
        Me.cmdRHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRHelp.Location = New System.Drawing.Point(166, 137)
        Me.cmdRHelp.Name = "cmdRHelp"
        Me.cmdRHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdRHelp.TabIndex = 182
        Me.cmdRHelp.Text = "R Help"
        Me.cmdRHelp.UseVisualStyleBackColor = True
        '
        'chkShowParameters
        '
        Me.chkShowParameters.AutoSize = True
        Me.chkShowParameters.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShowParameters.Location = New System.Drawing.Point(70, 41)
        Me.chkShowParameters.Name = "chkShowParameters"
        Me.chkShowParameters.Size = New System.Drawing.Size(109, 17)
        Me.chkShowParameters.TabIndex = 181
        Me.chkShowParameters.Text = "Show Parameters"
        Me.chkShowParameters.UseVisualStyleBackColor = True
        '
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.cmdClear)
        Me.grpBasic.Controls.Add(Me.cmdComma)
        Me.grpBasic.Controls.Add(Me.cmdBrackets)
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
        Me.grpBasic.Location = New System.Drawing.Point(223, 69)
        Me.grpBasic.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpBasic.Size = New System.Drawing.Size(205, 134)
        Me.grpBasic.TabIndex = 179
        Me.grpBasic.TabStop = False
        Me.grpBasic.Text = "Basic"
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(151, 71)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 60)
        Me.cmdClear.TabIndex = 190
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdComma
        '
        Me.cmdComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdComma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComma.Location = New System.Drawing.Point(3, 100)
        Me.cmdComma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdComma.Name = "cmdComma"
        Me.cmdComma.Size = New System.Drawing.Size(38, 30)
        Me.cmdComma.TabIndex = 138
        Me.cmdComma.Text = ","
        Me.cmdComma.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        Me.cmdBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrackets.Location = New System.Drawing.Point(77, 100)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(38, 30)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(151, 42)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(49, 30)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDivide.Location = New System.Drawing.Point(114, 13)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(38, 30)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(114, 100)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(38, 30)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(114, 71)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(38, 30)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(114, 42)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(38, 30)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDot.Location = New System.Drawing.Point(151, 13)
        Me.cmdDot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(49, 30)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd9.Location = New System.Drawing.Point(77, 13)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(38, 30)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd8.Location = New System.Drawing.Point(40, 13)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(38, 30)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        Me.cmd6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd6.Location = New System.Drawing.Point(77, 42)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(38, 30)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd5.Location = New System.Drawing.Point(40, 42)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(38, 30)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd4.Location = New System.Drawing.Point(3, 42)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(38, 30)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd3.Location = New System.Drawing.Point(77, 71)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(38, 30)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd2.Location = New System.Drawing.Point(40, 71)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(38, 30)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd0.Location = New System.Drawing.Point(40, 100)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(38, 30)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd1.Location = New System.Drawing.Point(3, 71)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(38, 30)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.Controls.Add(Me.cmdPm)
        Me.grpDates.Controls.Add(Me.cmdTime)
        Me.grpDates.Controls.Add(Me.cmdDateTime)
        Me.grpDates.Controls.Add(Me.cmdQuarter)
        Me.grpDates.Controls.Add(Me.cmdD_In_M)
        Me.grpDates.Controls.Add(Me.cmdAm)
        Me.grpDates.Controls.Add(Me.cmdSec)
        Me.grpDates.Controls.Add(Me.cmdHour)
        Me.grpDates.Controls.Add(Me.cmdminutes)
        Me.grpDates.Controls.Add(Me.cmdDmy)
        Me.grpDates.Controls.Add(Me.cmdDay)
        Me.grpDates.Controls.Add(Me.cmdMonth)
        Me.grpDates.Controls.Add(Me.cmdYear)
        Me.grpDates.Controls.Add(Me.cmdDate)
        Me.grpDates.Controls.Add(Me.cmdYday)
        Me.grpDates.Controls.Add(Me.cmdRHelp)
        Me.grpDates.Controls.Add(Me.cmdWday)
        Me.grpDates.Controls.Add(Me.cmdMdy)
        Me.grpDates.Controls.Add(Me.cmdYmd)
        Me.grpDates.Controls.Add(Me.cmdLeap)
        Me.grpDates.Location = New System.Drawing.Point(431, 61)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDates.Size = New System.Drawing.Size(244, 162)
        Me.grpDates.TabIndex = 188
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Dates/Times"
        '
        'cmdPm
        '
        Me.cmdPm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPm.Location = New System.Drawing.Point(4, 130)
        Me.cmdPm.Name = "cmdPm"
        Me.cmdPm.Size = New System.Drawing.Size(60, 30)
        Me.cmdPm.TabIndex = 161
        Me.cmdPm.Text = "pm"
        Me.cmdPm.UseVisualStyleBackColor = True
        '
        'cmdTime
        '
        Me.cmdTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTime.Location = New System.Drawing.Point(122, 14)
        Me.cmdTime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTime.Name = "cmdTime"
        Me.cmdTime.Size = New System.Drawing.Size(60, 30)
        Me.cmdTime.TabIndex = 160
        Me.cmdTime.Text = "time"
        Me.cmdTime.UseVisualStyleBackColor = True
        '
        'cmdDateTime
        '
        Me.cmdDateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDateTime.Location = New System.Drawing.Point(63, 14)
        Me.cmdDateTime.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDateTime.Name = "cmdDateTime"
        Me.cmdDateTime.Size = New System.Drawing.Size(60, 30)
        Me.cmdDateTime.TabIndex = 159
        Me.cmdDateTime.Text = "datetime"
        Me.cmdDateTime.UseVisualStyleBackColor = True
        '
        'cmdQuarter
        '
        Me.cmdQuarter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuarter.Location = New System.Drawing.Point(63, 130)
        Me.cmdQuarter.Name = "cmdQuarter"
        Me.cmdQuarter.Size = New System.Drawing.Size(60, 30)
        Me.cmdQuarter.TabIndex = 157
        Me.cmdQuarter.Text = "quarter"
        Me.cmdQuarter.UseVisualStyleBackColor = True
        '
        'cmdD_In_M
        '
        Me.cmdD_In_M.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdD_In_M.Location = New System.Drawing.Point(63, 43)
        Me.cmdD_In_M.Name = "cmdD_In_M"
        Me.cmdD_In_M.Size = New System.Drawing.Size(60, 30)
        Me.cmdD_In_M.TabIndex = 156
        Me.cmdD_In_M.Text = "d_in_m"
        Me.cmdD_In_M.UseVisualStyleBackColor = True
        '
        'cmdAm
        '
        Me.cmdAm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAm.Location = New System.Drawing.Point(181, 101)
        Me.cmdAm.Name = "cmdAm"
        Me.cmdAm.Size = New System.Drawing.Size(60, 30)
        Me.cmdAm.TabIndex = 155
        Me.cmdAm.Text = "am"
        Me.cmdAm.UseVisualStyleBackColor = True
        '
        'cmdSec
        '
        Me.cmdSec.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSec.Location = New System.Drawing.Point(122, 101)
        Me.cmdSec.Name = "cmdSec"
        Me.cmdSec.Size = New System.Drawing.Size(60, 30)
        Me.cmdSec.TabIndex = 154
        Me.cmdSec.Text = "sec"
        Me.cmdSec.UseVisualStyleBackColor = True
        '
        'cmdHour
        '
        Me.cmdHour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHour.Location = New System.Drawing.Point(4, 101)
        Me.cmdHour.Name = "cmdHour"
        Me.cmdHour.Size = New System.Drawing.Size(60, 30)
        Me.cmdHour.TabIndex = 153
        Me.cmdHour.Text = "hour"
        Me.cmdHour.UseVisualStyleBackColor = True
        '
        'cmdminutes
        '
        Me.cmdminutes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdminutes.Location = New System.Drawing.Point(63, 101)
        Me.cmdminutes.Name = "cmdminutes"
        Me.cmdminutes.Size = New System.Drawing.Size(60, 30)
        Me.cmdminutes.TabIndex = 152
        Me.cmdminutes.Text = "min"
        Me.cmdminutes.UseVisualStyleBackColor = True
        '
        'cmdDmy
        '
        Me.cmdDmy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDmy.Location = New System.Drawing.Point(63, 72)
        Me.cmdDmy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDmy.Name = "cmdDmy"
        Me.cmdDmy.Size = New System.Drawing.Size(60, 30)
        Me.cmdDmy.TabIndex = 151
        Me.cmdDmy.Tag = "dmy"
        Me.cmdDmy.Text = "dmy"
        Me.cmdDmy.UseVisualStyleBackColor = True
        '
        'cmdDay
        '
        Me.cmdDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDay.Location = New System.Drawing.Point(4, 43)
        Me.cmdDay.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDay.Name = "cmdDay"
        Me.cmdDay.Size = New System.Drawing.Size(60, 30)
        Me.cmdDay.TabIndex = 145
        Me.cmdDay.Text = "day"
        Me.cmdDay.UseVisualStyleBackColor = True
        '
        'cmdMonth
        '
        Me.cmdMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMonth.Location = New System.Drawing.Point(4, 43)
        Me.cmdMonth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMonth.Name = "cmdMonth"
        Me.cmdMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMonth.Size = New System.Drawing.Size(60, 30)
        Me.cmdMonth.TabIndex = 144
        Me.cmdMonth.Text = "month"
        Me.cmdMonth.UseVisualStyleBackColor = True
        '
        'cmdYear
        '
        Me.cmdYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYear.Location = New System.Drawing.Point(181, 14)
        Me.cmdYear.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdYear.Name = "cmdYear"
        Me.cmdYear.Size = New System.Drawing.Size(60, 30)
        Me.cmdYear.TabIndex = 143
        Me.cmdYear.Text = "year"
        Me.cmdYear.UseVisualStyleBackColor = True
        '
        'cmdDate
        '
        Me.cmdDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDate.Location = New System.Drawing.Point(4, 14)
        Me.cmdDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDate.Name = "cmdDate"
        Me.cmdDate.Size = New System.Drawing.Size(60, 30)
        Me.cmdDate.TabIndex = 142
        Me.cmdDate.Text = "date"
        Me.cmdDate.UseVisualStyleBackColor = True
        '
        'cmdYday
        '
        Me.cmdYday.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYday.Location = New System.Drawing.Point(181, 43)
        Me.cmdYday.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdYday.Name = "cmdYday"
        Me.cmdYday.Size = New System.Drawing.Size(60, 30)
        Me.cmdYday.TabIndex = 141
        Me.cmdYday.Text = "yday"
        Me.cmdYday.UseVisualStyleBackColor = True
        '
        'cmdWday
        '
        Me.cmdWday.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWday.Location = New System.Drawing.Point(122, 43)
        Me.cmdWday.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdWday.Name = "cmdWday"
        Me.cmdWday.Size = New System.Drawing.Size(60, 30)
        Me.cmdWday.TabIndex = 140
        Me.cmdWday.Text = "wday"
        Me.cmdWday.UseVisualStyleBackColor = True
        '
        'cmdMdy
        '
        Me.cmdMdy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMdy.Location = New System.Drawing.Point(122, 72)
        Me.cmdMdy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMdy.Name = "cmdMdy"
        Me.cmdMdy.Size = New System.Drawing.Size(60, 30)
        Me.cmdMdy.TabIndex = 139
        Me.cmdMdy.Text = "mdy"
        Me.cmdMdy.UseVisualStyleBackColor = True
        '
        'cmdYmd
        '
        Me.cmdYmd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYmd.Location = New System.Drawing.Point(4, 72)
        Me.cmdYmd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdYmd.Name = "cmdYmd"
        Me.cmdYmd.Size = New System.Drawing.Size(60, 30)
        Me.cmdYmd.TabIndex = 138
        Me.cmdYmd.Text = "ymd"
        Me.cmdYmd.UseVisualStyleBackColor = True
        '
        'cmdLeap
        '
        Me.cmdLeap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLeap.Location = New System.Drawing.Point(181, 72)
        Me.cmdLeap.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLeap.Name = "cmdLeap"
        Me.cmdLeap.Size = New System.Drawing.Size(60, 30)
        Me.cmdLeap.TabIndex = 136
        Me.cmdLeap.Text = "leap"
        Me.cmdLeap.UseVisualStyleBackColor = True
        '
        'grpFactor
        '
        Me.grpFactor.Controls.Add(Me.cmdTransformHelp)
        Me.grpFactor.Controls.Add(Me.cmdShuffle)
        Me.grpFactor.Controls.Add(Me.cmdShift)
        Me.grpFactor.Controls.Add(Me.cmdReverse)
        Me.grpFactor.Controls.Add(Me.cmdReorder)
        Me.grpFactor.Controls.Add(Me.cmdRelevel)
        Me.grpFactor.Controls.Add(Me.cmdRecode)
        Me.grpFactor.Controls.Add(Me.cmdOther)
        Me.grpFactor.Controls.Add(Me.cmdFmatch)
        Me.grpFactor.Controls.Add(Me.cmdLump)
        Me.grpFactor.Controls.Add(Me.cmdInseq)
        Me.grpFactor.Controls.Add(Me.cmdInfreq)
        Me.grpFactor.Controls.Add(Me.cmdInorder)
        Me.grpFactor.Controls.Add(Me.cmdAdd_na)
        Me.grpFactor.Controls.Add(Me.cmdExpand)
        Me.grpFactor.Controls.Add(Me.cmdDrop)
        Me.grpFactor.Controls.Add(Me.cmdCross)
        Me.grpFactor.Controls.Add(Me.cmdCollapse)
        Me.grpFactor.Controls.Add(Me.cmdLabelled)
        Me.grpFactor.Controls.Add(Me.cmdFactor)
        Me.grpFactor.Controls.Add(Me.cmdAnon)
        Me.grpFactor.Location = New System.Drawing.Point(431, 61)
        Me.grpFactor.Margin = New System.Windows.Forms.Padding(2)
        Me.grpFactor.Name = "grpFactor"
        Me.grpFactor.Padding = New System.Windows.Forms.Padding(2)
        Me.grpFactor.Size = New System.Drawing.Size(248, 199)
        Me.grpFactor.TabIndex = 191
        Me.grpFactor.TabStop = False
        Me.grpFactor.Text = "Factor"
        '
        'cmdTransformHelp
        '
        Me.cmdTransformHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTransformHelp.Location = New System.Drawing.Point(167, 174)
        Me.cmdTransformHelp.Name = "cmdTransformHelp"
        Me.cmdTransformHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdTransformHelp.TabIndex = 211
        Me.cmdTransformHelp.Text = "R Help"
        Me.cmdTransformHelp.UseVisualStyleBackColor = True
        '
        'cmdShuffle
        '
        Me.cmdShuffle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdShuffle.Location = New System.Drawing.Point(182, 143)
        Me.cmdShuffle.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdShuffle.Name = "cmdShuffle"
        Me.cmdShuffle.Size = New System.Drawing.Size(60, 32)
        Me.cmdShuffle.TabIndex = 210
        Me.cmdShuffle.Text = "shuffle"
        Me.cmdShuffle.UseVisualStyleBackColor = True
        '
        'cmdShift
        '
        Me.cmdShift.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdShift.Location = New System.Drawing.Point(123, 143)
        Me.cmdShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdShift.Name = "cmdShift"
        Me.cmdShift.Size = New System.Drawing.Size(60, 32)
        Me.cmdShift.TabIndex = 209
        Me.cmdShift.Text = "shift"
        Me.cmdShift.UseVisualStyleBackColor = True
        '
        'cmdReverse
        '
        Me.cmdReverse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReverse.Location = New System.Drawing.Point(64, 143)
        Me.cmdReverse.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReverse.Name = "cmdReverse"
        Me.cmdReverse.Size = New System.Drawing.Size(60, 32)
        Me.cmdReverse.TabIndex = 208
        Me.cmdReverse.Text = "reverse"
        Me.cmdReverse.UseVisualStyleBackColor = True
        '
        'cmdReorder
        '
        Me.cmdReorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReorder.Location = New System.Drawing.Point(4, 143)
        Me.cmdReorder.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdReorder.Name = "cmdReorder"
        Me.cmdReorder.Size = New System.Drawing.Size(60, 32)
        Me.cmdReorder.TabIndex = 207
        Me.cmdReorder.Text = "reorder"
        Me.cmdReorder.UseVisualStyleBackColor = True
        '
        'cmdRelevel
        '
        Me.cmdRelevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRelevel.Location = New System.Drawing.Point(182, 111)
        Me.cmdRelevel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRelevel.Name = "cmdRelevel"
        Me.cmdRelevel.Size = New System.Drawing.Size(60, 32)
        Me.cmdRelevel.TabIndex = 206
        Me.cmdRelevel.Text = "relevel"
        Me.cmdRelevel.UseVisualStyleBackColor = True
        '
        'cmdRecode
        '
        Me.cmdRecode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRecode.Location = New System.Drawing.Point(123, 111)
        Me.cmdRecode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRecode.Name = "cmdRecode"
        Me.cmdRecode.Size = New System.Drawing.Size(60, 32)
        Me.cmdRecode.TabIndex = 205
        Me.cmdRecode.Text = "recode"
        Me.cmdRecode.UseVisualStyleBackColor = True
        '
        'cmdOther
        '
        Me.cmdOther.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOther.Location = New System.Drawing.Point(64, 111)
        Me.cmdOther.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOther.Name = "cmdOther"
        Me.cmdOther.Size = New System.Drawing.Size(60, 32)
        Me.cmdOther.TabIndex = 204
        Me.cmdOther.Text = "other"
        Me.cmdOther.UseVisualStyleBackColor = True
        '
        'cmdFmatch
        '
        Me.cmdFmatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFmatch.Location = New System.Drawing.Point(4, 111)
        Me.cmdFmatch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFmatch.Name = "cmdFmatch"
        Me.cmdFmatch.Size = New System.Drawing.Size(60, 32)
        Me.cmdFmatch.TabIndex = 203
        Me.cmdFmatch.Text = "match"
        Me.cmdFmatch.UseVisualStyleBackColor = True
        '
        'cmdLump
        '
        Me.cmdLump.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLump.Location = New System.Drawing.Point(182, 80)
        Me.cmdLump.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLump.Name = "cmdLump"
        Me.cmdLump.Size = New System.Drawing.Size(60, 32)
        Me.cmdLump.TabIndex = 202
        Me.cmdLump.Text = "lump"
        Me.cmdLump.UseVisualStyleBackColor = True
        '
        'cmdInseq
        '
        Me.cmdInseq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInseq.Location = New System.Drawing.Point(123, 80)
        Me.cmdInseq.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdInseq.Name = "cmdInseq"
        Me.cmdInseq.Size = New System.Drawing.Size(60, 32)
        Me.cmdInseq.TabIndex = 201
        Me.cmdInseq.Text = "inseq"
        Me.cmdInseq.UseVisualStyleBackColor = True
        '
        'cmdInfreq
        '
        Me.cmdInfreq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInfreq.Location = New System.Drawing.Point(64, 80)
        Me.cmdInfreq.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdInfreq.Name = "cmdInfreq"
        Me.cmdInfreq.Size = New System.Drawing.Size(60, 32)
        Me.cmdInfreq.TabIndex = 200
        Me.cmdInfreq.Text = "infreq"
        Me.cmdInfreq.UseVisualStyleBackColor = True
        '
        'cmdInorder
        '
        Me.cmdInorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInorder.Location = New System.Drawing.Point(4, 80)
        Me.cmdInorder.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdInorder.Name = "cmdInorder"
        Me.cmdInorder.Size = New System.Drawing.Size(60, 32)
        Me.cmdInorder.TabIndex = 199
        Me.cmdInorder.Text = "inorder"
        Me.cmdInorder.UseVisualStyleBackColor = True
        '
        'cmdAdd_na
        '
        Me.cmdAdd_na.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAdd_na.Location = New System.Drawing.Point(182, 48)
        Me.cmdAdd_na.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAdd_na.Name = "cmdAdd_na"
        Me.cmdAdd_na.Size = New System.Drawing.Size(60, 32)
        Me.cmdAdd_na.TabIndex = 198
        Me.cmdAdd_na.Text = "add_na"
        Me.cmdAdd_na.UseVisualStyleBackColor = True
        '
        'cmdExpand
        '
        Me.cmdExpand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExpand.Location = New System.Drawing.Point(123, 48)
        Me.cmdExpand.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExpand.Name = "cmdExpand"
        Me.cmdExpand.Size = New System.Drawing.Size(60, 32)
        Me.cmdExpand.TabIndex = 197
        Me.cmdExpand.Text = "expand"
        Me.cmdExpand.UseVisualStyleBackColor = True
        '
        'cmdDrop
        '
        Me.cmdDrop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDrop.Location = New System.Drawing.Point(64, 48)
        Me.cmdDrop.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDrop.Name = "cmdDrop"
        Me.cmdDrop.Size = New System.Drawing.Size(60, 32)
        Me.cmdDrop.TabIndex = 196
        Me.cmdDrop.Text = "drop"
        Me.cmdDrop.UseVisualStyleBackColor = True
        '
        'cmdCross
        '
        Me.cmdCross.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCross.Location = New System.Drawing.Point(4, 48)
        Me.cmdCross.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCross.Name = "cmdCross"
        Me.cmdCross.Size = New System.Drawing.Size(60, 32)
        Me.cmdCross.TabIndex = 195
        Me.cmdCross.Text = "cross"
        Me.cmdCross.UseVisualStyleBackColor = True
        '
        'cmdCollapse
        '
        Me.cmdCollapse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCollapse.Location = New System.Drawing.Point(182, 16)
        Me.cmdCollapse.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCollapse.Name = "cmdCollapse"
        Me.cmdCollapse.Size = New System.Drawing.Size(60, 32)
        Me.cmdCollapse.TabIndex = 194
        Me.cmdCollapse.Text = "collapse"
        Me.cmdCollapse.UseVisualStyleBackColor = True
        '
        'cmdLabelled
        '
        Me.cmdLabelled.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLabelled.Location = New System.Drawing.Point(123, 16)
        Me.cmdLabelled.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLabelled.Name = "cmdLabelled"
        Me.cmdLabelled.Size = New System.Drawing.Size(60, 32)
        Me.cmdLabelled.TabIndex = 193
        Me.cmdLabelled.Text = "labelled "
        Me.cmdLabelled.UseVisualStyleBackColor = True
        '
        'cmdFactor
        '
        Me.cmdFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFactor.Location = New System.Drawing.Point(4, 16)
        Me.cmdFactor.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFactor.Name = "cmdFactor"
        Me.cmdFactor.Size = New System.Drawing.Size(60, 32)
        Me.cmdFactor.TabIndex = 191
        Me.cmdFactor.Text = "factor"
        Me.cmdFactor.UseVisualStyleBackColor = True
        '
        'cmdAnon
        '
        Me.cmdAnon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnon.Location = New System.Drawing.Point(64, 16)
        Me.cmdAnon.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAnon.Name = "cmdAnon"
        Me.cmdAnon.Size = New System.Drawing.Size(60, 32)
        Me.cmdAnon.TabIndex = 192
        Me.cmdAnon.Text = "anon"
        Me.cmdAnon.UseVisualStyleBackColor = True
        '
        'grpHydroGOF
        '
        Me.grpHydroGOF.Controls.Add(Me.cmdHydroHelp)
        Me.grpHydroGOF.Controls.Add(Me.cmdVE)
        Me.grpHydroGOF.Controls.Add(Me.cmdSsq)
        Me.grpHydroGOF.Controls.Add(Me.cmdRsr)
        Me.grpHydroGOF.Controls.Add(Me.cmdRSD)
        Me.grpHydroGOF.Controls.Add(Me.cmdRPearson)
        Me.grpHydroGOF.Controls.Add(Me.cmdRNSE)
        Me.grpHydroGOF.Controls.Add(Me.cmdRmse)
        Me.grpHydroGOF.Controls.Add(Me.cmdRd)
        Me.grpHydroGOF.Controls.Add(Me.cmdPbiasfde)
        Me.grpHydroGOF.Controls.Add(Me.cmdPbias)
        Me.grpHydroGOF.Controls.Add(Me.cmdNSE)
        Me.grpHydroGOF.Controls.Add(Me.cmdNrmse)
        Me.grpHydroGOF.Controls.Add(Me.cmdMse)
        Me.grpHydroGOF.Controls.Add(Me.cmdmNSE)
        Me.grpHydroGOF.Controls.Add(Me.cmdMe)
        Me.grpHydroGOF.Controls.Add(Me.cmdMd)
        Me.grpHydroGOF.Controls.Add(Me.cmdMae)
        Me.grpHydroGOF.Controls.Add(Me.cmdKGE)
        Me.grpHydroGOF.Controls.Add(Me.cmdD)
        Me.grpHydroGOF.Controls.Add(Me.cmdCp)
        Me.grpHydroGOF.Controls.Add(Me.cmdBr2)
        Me.grpHydroGOF.Location = New System.Drawing.Point(431, 61)
        Me.grpHydroGOF.Margin = New System.Windows.Forms.Padding(2)
        Me.grpHydroGOF.Name = "grpHydroGOF"
        Me.grpHydroGOF.Padding = New System.Windows.Forms.Padding(2)
        Me.grpHydroGOF.Size = New System.Drawing.Size(183, 260)
        Me.grpHydroGOF.TabIndex = 195
        Me.grpHydroGOF.TabStop = False
        Me.grpHydroGOF.Text = "hydroGOF "
        '
        'cmdHydroHelp
        '
        Me.cmdHydroHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHydroHelp.Location = New System.Drawing.Point(105, 237)
        Me.cmdHydroHelp.Name = "cmdHydroHelp"
        Me.cmdHydroHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdHydroHelp.TabIndex = 183
        Me.cmdHydroHelp.Text = "R Help"
        Me.cmdHydroHelp.UseVisualStyleBackColor = True
        '
        'cmdVE
        '
        Me.cmdVE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVE.Location = New System.Drawing.Point(120, 206)
        Me.cmdVE.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdVE.Name = "cmdVE"
        Me.cmdVE.Size = New System.Drawing.Size(60, 32)
        Me.cmdVE.TabIndex = 20
        Me.cmdVE.Text = "VE"
        Me.cmdVE.UseVisualStyleBackColor = True
        '
        'cmdSsq
        '
        Me.cmdSsq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSsq.Location = New System.Drawing.Point(61, 206)
        Me.cmdSsq.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSsq.Name = "cmdSsq"
        Me.cmdSsq.Size = New System.Drawing.Size(60, 32)
        Me.cmdSsq.TabIndex = 19
        Me.cmdSsq.Text = "ssq"
        Me.cmdSsq.UseVisualStyleBackColor = True
        '
        'cmdRsr
        '
        Me.cmdRsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRsr.Location = New System.Drawing.Point(2, 206)
        Me.cmdRsr.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRsr.Name = "cmdRsr"
        Me.cmdRsr.Size = New System.Drawing.Size(60, 32)
        Me.cmdRsr.TabIndex = 18
        Me.cmdRsr.Text = "rsr"
        Me.cmdRsr.UseVisualStyleBackColor = True
        '
        'cmdRSD
        '
        Me.cmdRSD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRSD.Location = New System.Drawing.Point(120, 175)
        Me.cmdRSD.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRSD.Name = "cmdRSD"
        Me.cmdRSD.Size = New System.Drawing.Size(60, 32)
        Me.cmdRSD.TabIndex = 17
        Me.cmdRSD.Text = "rSD"
        Me.cmdRSD.UseVisualStyleBackColor = True
        '
        'cmdRPearson
        '
        Me.cmdRPearson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRPearson.Location = New System.Drawing.Point(61, 175)
        Me.cmdRPearson.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRPearson.Name = "cmdRPearson"
        Me.cmdRPearson.Size = New System.Drawing.Size(60, 32)
        Me.cmdRPearson.TabIndex = 16
        Me.cmdRPearson.Text = "rPearson"
        Me.cmdRPearson.UseVisualStyleBackColor = True
        '
        'cmdRNSE
        '
        Me.cmdRNSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRNSE.Location = New System.Drawing.Point(2, 175)
        Me.cmdRNSE.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRNSE.Name = "cmdRNSE"
        Me.cmdRNSE.Size = New System.Drawing.Size(60, 32)
        Me.cmdRNSE.TabIndex = 15
        Me.cmdRNSE.Text = "rNSE"
        Me.cmdRNSE.UseVisualStyleBackColor = True
        '
        'cmdRmse
        '
        Me.cmdRmse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRmse.Location = New System.Drawing.Point(120, 143)
        Me.cmdRmse.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRmse.Name = "cmdRmse"
        Me.cmdRmse.Size = New System.Drawing.Size(60, 32)
        Me.cmdRmse.TabIndex = 14
        Me.cmdRmse.Text = "rmse"
        Me.cmdRmse.UseVisualStyleBackColor = True
        '
        'cmdRd
        '
        Me.cmdRd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRd.Location = New System.Drawing.Point(61, 143)
        Me.cmdRd.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRd.Name = "cmdRd"
        Me.cmdRd.Size = New System.Drawing.Size(60, 32)
        Me.cmdRd.TabIndex = 13
        Me.cmdRd.Text = "rd"
        Me.cmdRd.UseVisualStyleBackColor = True
        '
        'cmdPbiasfde
        '
        Me.cmdPbiasfde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbiasfde.Location = New System.Drawing.Point(2, 143)
        Me.cmdPbiasfde.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPbiasfde.Name = "cmdPbiasfde"
        Me.cmdPbiasfde.Size = New System.Drawing.Size(60, 32)
        Me.cmdPbiasfde.TabIndex = 12
        Me.cmdPbiasfde.Text = "pbiasfdc"
        Me.cmdPbiasfde.UseVisualStyleBackColor = True
        '
        'cmdPbias
        '
        Me.cmdPbias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbias.Location = New System.Drawing.Point(120, 111)
        Me.cmdPbias.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPbias.Name = "cmdPbias"
        Me.cmdPbias.Size = New System.Drawing.Size(60, 32)
        Me.cmdPbias.TabIndex = 11
        Me.cmdPbias.Text = "pbias"
        Me.cmdPbias.UseVisualStyleBackColor = True
        '
        'cmdNSE
        '
        Me.cmdNSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNSE.Location = New System.Drawing.Point(61, 111)
        Me.cmdNSE.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNSE.Name = "cmdNSE"
        Me.cmdNSE.Size = New System.Drawing.Size(60, 32)
        Me.cmdNSE.TabIndex = 10
        Me.cmdNSE.Text = "NSE"
        Me.cmdNSE.UseVisualStyleBackColor = True
        '
        'cmdNrmse
        '
        Me.cmdNrmse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNrmse.Location = New System.Drawing.Point(2, 111)
        Me.cmdNrmse.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNrmse.Name = "cmdNrmse"
        Me.cmdNrmse.Size = New System.Drawing.Size(60, 32)
        Me.cmdNrmse.TabIndex = 9
        Me.cmdNrmse.Text = "nrmse"
        Me.cmdNrmse.UseVisualStyleBackColor = True
        '
        'cmdMse
        '
        Me.cmdMse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMse.Location = New System.Drawing.Point(120, 80)
        Me.cmdMse.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMse.Name = "cmdMse"
        Me.cmdMse.Size = New System.Drawing.Size(60, 32)
        Me.cmdMse.TabIndex = 8
        Me.cmdMse.Text = "mse"
        Me.cmdMse.UseVisualStyleBackColor = True
        '
        'cmdmNSE
        '
        Me.cmdmNSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdmNSE.Location = New System.Drawing.Point(61, 80)
        Me.cmdmNSE.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdmNSE.Name = "cmdmNSE"
        Me.cmdmNSE.Size = New System.Drawing.Size(60, 32)
        Me.cmdmNSE.TabIndex = 7
        Me.cmdmNSE.Text = "mNSE"
        Me.cmdmNSE.UseVisualStyleBackColor = True
        '
        'cmdMe
        '
        Me.cmdMe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMe.Location = New System.Drawing.Point(2, 80)
        Me.cmdMe.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMe.Name = "cmdMe"
        Me.cmdMe.Size = New System.Drawing.Size(60, 32)
        Me.cmdMe.TabIndex = 6
        Me.cmdMe.Text = "me"
        Me.cmdMe.UseVisualStyleBackColor = True
        '
        'cmdMd
        '
        Me.cmdMd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMd.Location = New System.Drawing.Point(120, 48)
        Me.cmdMd.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMd.Name = "cmdMd"
        Me.cmdMd.Size = New System.Drawing.Size(60, 32)
        Me.cmdMd.TabIndex = 5
        Me.cmdMd.Text = "md"
        Me.cmdMd.UseVisualStyleBackColor = True
        '
        'cmdMae
        '
        Me.cmdMae.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMae.Location = New System.Drawing.Point(61, 48)
        Me.cmdMae.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMae.Name = "cmdMae"
        Me.cmdMae.Size = New System.Drawing.Size(60, 32)
        Me.cmdMae.TabIndex = 4
        Me.cmdMae.Text = "mae"
        Me.cmdMae.UseVisualStyleBackColor = True
        '
        'cmdKGE
        '
        Me.cmdKGE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKGE.Location = New System.Drawing.Point(2, 48)
        Me.cmdKGE.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdKGE.Name = "cmdKGE"
        Me.cmdKGE.Size = New System.Drawing.Size(60, 32)
        Me.cmdKGE.TabIndex = 3
        Me.cmdKGE.Text = "KGE"
        Me.cmdKGE.UseVisualStyleBackColor = True
        '
        'cmdD
        '
        Me.cmdD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdD.Location = New System.Drawing.Point(120, 16)
        Me.cmdD.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(60, 32)
        Me.cmdD.TabIndex = 2
        Me.cmdD.Text = "d"
        Me.cmdD.UseVisualStyleBackColor = True
        '
        'cmdCp
        '
        Me.cmdCp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCp.Location = New System.Drawing.Point(61, 16)
        Me.cmdCp.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCp.Name = "cmdCp"
        Me.cmdCp.Size = New System.Drawing.Size(60, 32)
        Me.cmdCp.TabIndex = 1
        Me.cmdCp.Text = "cp"
        Me.cmdCp.UseVisualStyleBackColor = True
        '
        'cmdBr2
        '
        Me.cmdBr2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBr2.Location = New System.Drawing.Point(2, 16)
        Me.cmdBr2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdBr2.Name = "cmdBr2"
        Me.cmdBr2.Size = New System.Drawing.Size(60, 32)
        Me.cmdBr2.TabIndex = 0
        Me.cmdBr2.Text = "br2"
        Me.cmdBr2.UseVisualStyleBackColor = True
        '
        'grpWakefield
        '
        Me.grpWakefield.Controls.Add(Me.cmdLinkert7)
        Me.grpWakefield.Controls.Add(Me.cmdWakefield_Year)
        Me.grpWakefield.Controls.Add(Me.cmdValid)
        Me.grpWakefield.Controls.Add(Me.cmdWakefield_Upper)
        Me.grpWakefield.Controls.Add(Me.cmdString)
        Me.grpWakefield.Controls.Add(Me.cmdState)
        Me.grpWakefield.Controls.Add(Me.cmdSpeed)
        Me.grpWakefield.Controls.Add(Me.cmdSmokes)
        Me.grpWakefield.Controls.Add(Me.cmdSex)
        Me.grpWakefield.Controls.Add(Me.cmdSex_Inclusive)
        Me.grpWakefield.Controls.Add(Me.cmdGender)
        Me.grpWakefield.Controls.Add(Me.cmdSentence)
        Me.grpWakefield.Controls.Add(Me.cmdSat)
        Me.grpWakefield.Controls.Add(Me.cmdReligion)
        Me.grpWakefield.Controls.Add(Me.cmdRace)
        Me.grpWakefield.Controls.Add(Me.cmdPolitical)
        Me.grpWakefield.Controls.Add(Me.cmdNormal)
        Me.grpWakefield.Controls.Add(Me.cmdName)
        Me.grpWakefield.Controls.Add(Me.cmdWakefield_Month)
        Me.grpWakefield.Controls.Add(Me.cmdMilitary)
        Me.grpWakefield.Controls.Add(Me.cmdMarital)
        Me.grpWakefield.Controls.Add(Me.cmdLorem_ipsum)
        Me.grpWakefield.Controls.Add(Me.cmdLikert)
        Me.grpWakefield.Controls.Add(Me.cmdGpa)
        Me.grpWakefield.Controls.Add(Me.cmdEla)
        Me.grpWakefield.Controls.Add(Me.cmdMath)
        Me.grpWakefield.Controls.Add(Me.cmdLevel)
        Me.grpWakefield.Controls.Add(Me.cmdLanguage)
        Me.grpWakefield.Controls.Add(Me.cmdIq)
        Me.grpWakefield.Controls.Add(Me.cmdInternet_Browser)
        Me.grpWakefield.Controls.Add(Me.cmdGrade_Level)
        Me.grpWakefield.Controls.Add(Me.cmdEye)
        Me.grpWakefield.Controls.Add(Me.cmdEmployment)
        Me.grpWakefield.Controls.Add(Me.cmdEducation)
        Me.grpWakefield.Controls.Add(Me.cmdDummy)
        Me.grpWakefield.Controls.Add(Me.cmdDob)
        Me.grpWakefield.Controls.Add(Me.cmdDna)
        Me.grpWakefield.Controls.Add(Me.cmdDice)
        Me.grpWakefield.Controls.Add(Me.cmdDied)
        Me.grpWakefield.Controls.Add(Me.cmdDeath)
        Me.grpWakefield.Controls.Add(Me.cmdDate_Stamp)
        Me.grpWakefield.Controls.Add(Me.cmdPrimary)
        Me.grpWakefield.Controls.Add(Me.cmdColor)
        Me.grpWakefield.Controls.Add(Me.cmdCoin)
        Me.grpWakefield.Controls.Add(Me.cmdChildren)
        Me.grpWakefield.Controls.Add(Me.cmdCar)
        Me.grpWakefield.Controls.Add(Me.cmdAnswer)
        Me.grpWakefield.Controls.Add(Me.cmdPet)
        Me.grpWakefield.Controls.Add(Me.cmdAnimal)
        Me.grpWakefield.Controls.Add(Me.cmdAge)
        Me.grpWakefield.Controls.Add(Me.cmdIncome)
        Me.grpWakefield.Controls.Add(Me.cmdHeight)
        Me.grpWakefield.Controls.Add(Me.cmdHair)
        Me.grpWakefield.Controls.Add(Me.cmdGroup)
        Me.grpWakefield.Controls.Add(Me.cmdGrade)
        Me.grpWakefield.Location = New System.Drawing.Point(431, 61)
        Me.grpWakefield.Name = "grpWakefield"
        Me.grpWakefield.Size = New System.Drawing.Size(435, 346)
        Me.grpWakefield.TabIndex = 191
        Me.grpWakefield.TabStop = False
        Me.grpWakefield.Text = "Wakefield"
        '
        'cmdLinkert7
        '
        Me.cmdLinkert7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLinkert7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLinkert7.Location = New System.Drawing.Point(341, 306)
        Me.cmdLinkert7.Name = "cmdLinkert7"
        Me.cmdLinkert7.Size = New System.Drawing.Size(85, 30)
        Me.cmdLinkert7.TabIndex = 54
        Me.cmdLinkert7.Text = "linkert7 (o.f)"
        Me.cmdLinkert7.UseVisualStyleBackColor = True
        '
        'cmdWakefield_Year
        '
        Me.cmdWakefield_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdWakefield_Year.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefield_Year.Location = New System.Drawing.Point(257, 306)
        Me.cmdWakefield_Year.Name = "cmdWakefield_Year"
        Me.cmdWakefield_Year.Size = New System.Drawing.Size(85, 30)
        Me.cmdWakefield_Year.TabIndex = 53
        Me.cmdWakefield_Year.Text = "year"
        Me.cmdWakefield_Year.UseVisualStyleBackColor = True
        '
        'cmdValid
        '
        Me.cmdValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdValid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdValid.Location = New System.Drawing.Point(173, 306)
        Me.cmdValid.Name = "cmdValid"
        Me.cmdValid.Size = New System.Drawing.Size(85, 30)
        Me.cmdValid.TabIndex = 52
        Me.cmdValid.Text = "valid (L)"
        Me.cmdValid.UseVisualStyleBackColor = True
        '
        'cmdWakefield_Upper
        '
        Me.cmdWakefield_Upper.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdWakefield_Upper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefield_Upper.Location = New System.Drawing.Point(89, 306)
        Me.cmdWakefield_Upper.Name = "cmdWakefield_Upper"
        Me.cmdWakefield_Upper.Size = New System.Drawing.Size(85, 30)
        Me.cmdWakefield_Upper.TabIndex = 51
        Me.cmdWakefield_Upper.Text = "upper (c)"
        Me.cmdWakefield_Upper.UseVisualStyleBackColor = True
        '
        'cmdString
        '
        Me.cmdString.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdString.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdString.Location = New System.Drawing.Point(5, 306)
        Me.cmdString.Name = "cmdString"
        Me.cmdString.Size = New System.Drawing.Size(85, 30)
        Me.cmdString.TabIndex = 50
        Me.cmdString.Text = "string (c)"
        Me.cmdString.UseVisualStyleBackColor = True
        '
        'cmdState
        '
        Me.cmdState.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdState.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdState.Location = New System.Drawing.Point(341, 277)
        Me.cmdState.Name = "cmdState"
        Me.cmdState.Size = New System.Drawing.Size(85, 30)
        Me.cmdState.TabIndex = 49
        Me.cmdState.Text = "state (f)"
        Me.cmdState.UseVisualStyleBackColor = True
        '
        'cmdSpeed
        '
        Me.cmdSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSpeed.Location = New System.Drawing.Point(257, 277)
        Me.cmdSpeed.Name = "cmdSpeed"
        Me.cmdSpeed.Size = New System.Drawing.Size(85, 30)
        Me.cmdSpeed.TabIndex = 48
        Me.cmdSpeed.Text = "speed"
        Me.cmdSpeed.UseVisualStyleBackColor = True
        '
        'cmdSmokes
        '
        Me.cmdSmokes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSmokes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSmokes.Location = New System.Drawing.Point(173, 277)
        Me.cmdSmokes.Name = "cmdSmokes"
        Me.cmdSmokes.Size = New System.Drawing.Size(85, 30)
        Me.cmdSmokes.TabIndex = 47
        Me.cmdSmokes.Text = "smokes (L)"
        Me.cmdSmokes.UseVisualStyleBackColor = True
        '
        'cmdSex
        '
        Me.cmdSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSex.Location = New System.Drawing.Point(89, 277)
        Me.cmdSex.Name = "cmdSex"
        Me.cmdSex.Size = New System.Drawing.Size(85, 30)
        Me.cmdSex.TabIndex = 46
        Me.cmdSex.Text = "sex (f)"
        Me.cmdSex.UseVisualStyleBackColor = True
        '
        'cmdSex_Inclusive
        '
        Me.cmdSex_Inclusive.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSex_Inclusive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSex_Inclusive.Location = New System.Drawing.Point(5, 277)
        Me.cmdSex_Inclusive.Name = "cmdSex_Inclusive"
        Me.cmdSex_Inclusive.Size = New System.Drawing.Size(85, 30)
        Me.cmdSex_Inclusive.TabIndex = 45
        Me.cmdSex_Inclusive.Text = "sex_inclusive (f)"
        Me.cmdSex_Inclusive.UseVisualStyleBackColor = True
        '
        'cmdGender
        '
        Me.cmdGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGender.Location = New System.Drawing.Point(341, 248)
        Me.cmdGender.Name = "cmdGender"
        Me.cmdGender.Size = New System.Drawing.Size(85, 30)
        Me.cmdGender.TabIndex = 44
        Me.cmdGender.Text = "gender (f)"
        Me.cmdGender.UseVisualStyleBackColor = True
        '
        'cmdSentence
        '
        Me.cmdSentence.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSentence.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSentence.Location = New System.Drawing.Point(257, 248)
        Me.cmdSentence.Name = "cmdSentence"
        Me.cmdSentence.Size = New System.Drawing.Size(85, 30)
        Me.cmdSentence.TabIndex = 43
        Me.cmdSentence.Text = "sentence (c)"
        Me.cmdSentence.UseVisualStyleBackColor = True
        '
        'cmdSat
        '
        Me.cmdSat.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSat.Location = New System.Drawing.Point(173, 248)
        Me.cmdSat.Name = "cmdSat"
        Me.cmdSat.Size = New System.Drawing.Size(85, 30)
        Me.cmdSat.TabIndex = 42
        Me.cmdSat.Text = "sat"
        Me.cmdSat.UseVisualStyleBackColor = True
        '
        'cmdReligion
        '
        Me.cmdReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdReligion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReligion.Location = New System.Drawing.Point(89, 248)
        Me.cmdReligion.Name = "cmdReligion"
        Me.cmdReligion.Size = New System.Drawing.Size(85, 30)
        Me.cmdReligion.TabIndex = 41
        Me.cmdReligion.Text = "religion (f)"
        Me.cmdReligion.UseVisualStyleBackColor = True
        '
        'cmdRace
        '
        Me.cmdRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdRace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRace.Location = New System.Drawing.Point(5, 248)
        Me.cmdRace.Name = "cmdRace"
        Me.cmdRace.Size = New System.Drawing.Size(85, 30)
        Me.cmdRace.TabIndex = 40
        Me.cmdRace.Text = "race (f)"
        Me.cmdRace.UseVisualStyleBackColor = True
        '
        'cmdPolitical
        '
        Me.cmdPolitical.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdPolitical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPolitical.Location = New System.Drawing.Point(341, 219)
        Me.cmdPolitical.Name = "cmdPolitical"
        Me.cmdPolitical.Size = New System.Drawing.Size(85, 30)
        Me.cmdPolitical.TabIndex = 39
        Me.cmdPolitical.Text = "political (f)"
        Me.cmdPolitical.UseVisualStyleBackColor = True
        '
        'cmdNormal
        '
        Me.cmdNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdNormal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNormal.Location = New System.Drawing.Point(257, 219)
        Me.cmdNormal.Name = "cmdNormal"
        Me.cmdNormal.Size = New System.Drawing.Size(85, 30)
        Me.cmdNormal.TabIndex = 38
        Me.cmdNormal.Text = "normal"
        Me.cmdNormal.UseVisualStyleBackColor = True
        '
        'cmdName
        '
        Me.cmdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdName.Location = New System.Drawing.Point(173, 219)
        Me.cmdName.Name = "cmdName"
        Me.cmdName.Size = New System.Drawing.Size(85, 30)
        Me.cmdName.TabIndex = 37
        Me.cmdName.Text = "name (c)"
        Me.cmdName.UseVisualStyleBackColor = True
        '
        'cmdWakefield_Month
        '
        Me.cmdWakefield_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdWakefield_Month.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefield_Month.Location = New System.Drawing.Point(89, 219)
        Me.cmdWakefield_Month.Name = "cmdWakefield_Month"
        Me.cmdWakefield_Month.Size = New System.Drawing.Size(85, 30)
        Me.cmdWakefield_Month.TabIndex = 36
        Me.cmdWakefield_Month.Text = "month (f)"
        Me.cmdWakefield_Month.UseVisualStyleBackColor = True
        '
        'cmdMilitary
        '
        Me.cmdMilitary.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdMilitary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMilitary.Location = New System.Drawing.Point(5, 219)
        Me.cmdMilitary.Name = "cmdMilitary"
        Me.cmdMilitary.Size = New System.Drawing.Size(85, 30)
        Me.cmdMilitary.TabIndex = 35
        Me.cmdMilitary.Text = "military (f)"
        Me.cmdMilitary.UseVisualStyleBackColor = True
        '
        'cmdMarital
        '
        Me.cmdMarital.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdMarital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMarital.Location = New System.Drawing.Point(341, 189)
        Me.cmdMarital.Name = "cmdMarital"
        Me.cmdMarital.Size = New System.Drawing.Size(85, 30)
        Me.cmdMarital.TabIndex = 34
        Me.cmdMarital.Text = "marital (f)"
        Me.cmdMarital.UseVisualStyleBackColor = True
        '
        'cmdLorem_ipsum
        '
        Me.cmdLorem_ipsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLorem_ipsum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLorem_ipsum.Location = New System.Drawing.Point(257, 189)
        Me.cmdLorem_ipsum.Name = "cmdLorem_ipsum"
        Me.cmdLorem_ipsum.Size = New System.Drawing.Size(85, 30)
        Me.cmdLorem_ipsum.TabIndex = 33
        Me.cmdLorem_ipsum.Text = "lorem_ipsum (c)"
        Me.cmdLorem_ipsum.UseVisualStyleBackColor = True
        '
        'cmdLikert
        '
        Me.cmdLikert.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLikert.Location = New System.Drawing.Point(173, 189)
        Me.cmdLikert.Name = "cmdLikert"
        Me.cmdLikert.Size = New System.Drawing.Size(85, 30)
        Me.cmdLikert.TabIndex = 32
        Me.cmdLikert.Text = "likert (o.f)"
        Me.cmdLikert.UseVisualStyleBackColor = True
        '
        'cmdGpa
        '
        Me.cmdGpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGpa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGpa.Location = New System.Drawing.Point(89, 189)
        Me.cmdGpa.Name = "cmdGpa"
        Me.cmdGpa.Size = New System.Drawing.Size(85, 30)
        Me.cmdGpa.TabIndex = 31
        Me.cmdGpa.Text = "gpa"
        Me.cmdGpa.UseVisualStyleBackColor = True
        '
        'cmdEla
        '
        Me.cmdEla.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEla.Location = New System.Drawing.Point(5, 189)
        Me.cmdEla.Name = "cmdEla"
        Me.cmdEla.Size = New System.Drawing.Size(85, 30)
        Me.cmdEla.TabIndex = 30
        Me.cmdEla.Text = "ela"
        Me.cmdEla.UseVisualStyleBackColor = True
        '
        'cmdMath
        '
        Me.cmdMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdMath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMath.Location = New System.Drawing.Point(341, 160)
        Me.cmdMath.Name = "cmdMath"
        Me.cmdMath.Size = New System.Drawing.Size(85, 30)
        Me.cmdMath.TabIndex = 29
        Me.cmdMath.Text = "math"
        Me.cmdMath.UseVisualStyleBackColor = True
        '
        'cmdLevel
        '
        Me.cmdLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLevel.Location = New System.Drawing.Point(257, 160)
        Me.cmdLevel.Name = "cmdLevel"
        Me.cmdLevel.Size = New System.Drawing.Size(85, 30)
        Me.cmdLevel.TabIndex = 28
        Me.cmdLevel.Text = "level"
        Me.cmdLevel.UseVisualStyleBackColor = True
        '
        'cmdLanguage
        '
        Me.cmdLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLanguage.Location = New System.Drawing.Point(173, 160)
        Me.cmdLanguage.Name = "cmdLanguage"
        Me.cmdLanguage.Size = New System.Drawing.Size(85, 30)
        Me.cmdLanguage.TabIndex = 27
        Me.cmdLanguage.Text = "language (f)"
        Me.cmdLanguage.UseVisualStyleBackColor = True
        '
        'cmdIq
        '
        Me.cmdIq.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdIq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIq.Location = New System.Drawing.Point(89, 160)
        Me.cmdIq.Name = "cmdIq"
        Me.cmdIq.Size = New System.Drawing.Size(85, 30)
        Me.cmdIq.TabIndex = 26
        Me.cmdIq.Text = "iq"
        Me.cmdIq.UseVisualStyleBackColor = True
        '
        'cmdInternet_Browser
        '
        Me.cmdInternet_Browser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdInternet_Browser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInternet_Browser.Location = New System.Drawing.Point(5, 160)
        Me.cmdInternet_Browser.Name = "cmdInternet_Browser"
        Me.cmdInternet_Browser.Size = New System.Drawing.Size(85, 30)
        Me.cmdInternet_Browser.TabIndex = 25
        Me.cmdInternet_Browser.Text = "browser (f)"
        Me.cmdInternet_Browser.UseVisualStyleBackColor = True
        '
        'cmdGrade_Level
        '
        Me.cmdGrade_Level.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGrade_Level.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGrade_Level.Location = New System.Drawing.Point(341, 102)
        Me.cmdGrade_Level.Name = "cmdGrade_Level"
        Me.cmdGrade_Level.Size = New System.Drawing.Size(85, 30)
        Me.cmdGrade_Level.TabIndex = 19
        Me.cmdGrade_Level.Text = "grade_level (f)"
        Me.cmdGrade_Level.UseVisualStyleBackColor = True
        '
        'cmdEye
        '
        Me.cmdEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEye.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEye.Location = New System.Drawing.Point(257, 102)
        Me.cmdEye.Name = "cmdEye"
        Me.cmdEye.Size = New System.Drawing.Size(85, 30)
        Me.cmdEye.TabIndex = 18
        Me.cmdEye.Text = "eye (f)"
        Me.cmdEye.UseVisualStyleBackColor = True
        '
        'cmdEmployment
        '
        Me.cmdEmployment.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEmployment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEmployment.Location = New System.Drawing.Point(173, 102)
        Me.cmdEmployment.Name = "cmdEmployment"
        Me.cmdEmployment.Size = New System.Drawing.Size(85, 30)
        Me.cmdEmployment.TabIndex = 17
        Me.cmdEmployment.Text = "employment (f)"
        Me.cmdEmployment.UseVisualStyleBackColor = True
        '
        'cmdEducation
        '
        Me.cmdEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEducation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEducation.Location = New System.Drawing.Point(89, 102)
        Me.cmdEducation.Name = "cmdEducation"
        Me.cmdEducation.Size = New System.Drawing.Size(85, 30)
        Me.cmdEducation.TabIndex = 16
        Me.cmdEducation.Text = "education (f)"
        Me.cmdEducation.UseVisualStyleBackColor = True
        '
        'cmdDummy
        '
        Me.cmdDummy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDummy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDummy.Location = New System.Drawing.Point(5, 102)
        Me.cmdDummy.Name = "cmdDummy"
        Me.cmdDummy.Size = New System.Drawing.Size(85, 30)
        Me.cmdDummy.TabIndex = 15
        Me.cmdDummy.Text = "dummy"
        Me.cmdDummy.UseVisualStyleBackColor = True
        '
        'cmdDob
        '
        Me.cmdDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDob.Location = New System.Drawing.Point(341, 72)
        Me.cmdDob.Name = "cmdDob"
        Me.cmdDob.Size = New System.Drawing.Size(85, 30)
        Me.cmdDob.TabIndex = 14
        Me.cmdDob.Text = "dob (D)"
        Me.cmdDob.UseVisualStyleBackColor = True
        '
        'cmdDna
        '
        Me.cmdDna.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDna.Location = New System.Drawing.Point(257, 72)
        Me.cmdDna.Name = "cmdDna"
        Me.cmdDna.Size = New System.Drawing.Size(85, 30)
        Me.cmdDna.TabIndex = 13
        Me.cmdDna.Text = "dna (f)"
        Me.cmdDna.UseVisualStyleBackColor = True
        '
        'cmdDice
        '
        Me.cmdDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDice.Location = New System.Drawing.Point(173, 72)
        Me.cmdDice.Name = "cmdDice"
        Me.cmdDice.Size = New System.Drawing.Size(85, 30)
        Me.cmdDice.TabIndex = 12
        Me.cmdDice.Text = "dice"
        Me.cmdDice.UseVisualStyleBackColor = True
        '
        'cmdDied
        '
        Me.cmdDied.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDied.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDied.Location = New System.Drawing.Point(89, 72)
        Me.cmdDied.Name = "cmdDied"
        Me.cmdDied.Size = New System.Drawing.Size(85, 30)
        Me.cmdDied.TabIndex = 11
        Me.cmdDied.Text = "died (L)"
        Me.cmdDied.UseVisualStyleBackColor = True
        '
        'cmdDeath
        '
        Me.cmdDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDeath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDeath.Location = New System.Drawing.Point(5, 72)
        Me.cmdDeath.Name = "cmdDeath"
        Me.cmdDeath.Size = New System.Drawing.Size(85, 30)
        Me.cmdDeath.TabIndex = 10
        Me.cmdDeath.Text = "death (L)"
        Me.cmdDeath.UseVisualStyleBackColor = True
        '
        'cmdDate_Stamp
        '
        Me.cmdDate_Stamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDate_Stamp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDate_Stamp.Location = New System.Drawing.Point(341, 43)
        Me.cmdDate_Stamp.Name = "cmdDate_Stamp"
        Me.cmdDate_Stamp.Size = New System.Drawing.Size(85, 30)
        Me.cmdDate_Stamp.TabIndex = 9
        Me.cmdDate_Stamp.Text = "date_stamp"
        Me.cmdDate_Stamp.UseVisualStyleBackColor = True
        '
        'cmdPrimary
        '
        Me.cmdPrimary.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrimary.Location = New System.Drawing.Point(257, 43)
        Me.cmdPrimary.Name = "cmdPrimary"
        Me.cmdPrimary.Size = New System.Drawing.Size(85, 30)
        Me.cmdPrimary.TabIndex = 8
        Me.cmdPrimary.Text = "primary (f)"
        Me.cmdPrimary.UseVisualStyleBackColor = True
        '
        'cmdColor
        '
        Me.cmdColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColor.Location = New System.Drawing.Point(173, 43)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(85, 30)
        Me.cmdColor.TabIndex = 7
        Me.cmdColor.Text = "color (f)"
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'cmdCoin
        '
        Me.cmdCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdCoin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCoin.Location = New System.Drawing.Point(89, 43)
        Me.cmdCoin.Name = "cmdCoin"
        Me.cmdCoin.Size = New System.Drawing.Size(85, 30)
        Me.cmdCoin.TabIndex = 6
        Me.cmdCoin.Text = "coin (f)"
        Me.cmdCoin.UseVisualStyleBackColor = True
        '
        'cmdChildren
        '
        Me.cmdChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdChildren.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChildren.Location = New System.Drawing.Point(5, 43)
        Me.cmdChildren.Name = "cmdChildren"
        Me.cmdChildren.Size = New System.Drawing.Size(85, 30)
        Me.cmdChildren.TabIndex = 5
        Me.cmdChildren.Text = "children"
        Me.cmdChildren.UseVisualStyleBackColor = True
        '
        'cmdCar
        '
        Me.cmdCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdCar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCar.Location = New System.Drawing.Point(341, 14)
        Me.cmdCar.Name = "cmdCar"
        Me.cmdCar.Size = New System.Drawing.Size(85, 30)
        Me.cmdCar.TabIndex = 4
        Me.cmdCar.Text = "car (f)"
        Me.cmdCar.UseVisualStyleBackColor = True
        '
        'cmdAnswer
        '
        Me.cmdAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdAnswer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnswer.Location = New System.Drawing.Point(257, 14)
        Me.cmdAnswer.Name = "cmdAnswer"
        Me.cmdAnswer.Size = New System.Drawing.Size(85, 30)
        Me.cmdAnswer.TabIndex = 3
        Me.cmdAnswer.Text = "answer (f)"
        Me.cmdAnswer.UseVisualStyleBackColor = True
        '
        'cmdPet
        '
        Me.cmdPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdPet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPet.Location = New System.Drawing.Point(173, 14)
        Me.cmdPet.Name = "cmdPet"
        Me.cmdPet.Size = New System.Drawing.Size(85, 30)
        Me.cmdPet.TabIndex = 2
        Me.cmdPet.Text = "pet (f)"
        Me.cmdPet.UseVisualStyleBackColor = True
        '
        'cmdAnimal
        '
        Me.cmdAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnimal.Location = New System.Drawing.Point(89, 14)
        Me.cmdAnimal.Name = "cmdAnimal"
        Me.cmdAnimal.Size = New System.Drawing.Size(85, 30)
        Me.cmdAnimal.TabIndex = 1
        Me.cmdAnimal.Text = "animal (f)"
        Me.cmdAnimal.UseVisualStyleBackColor = True
        '
        'cmdAge
        '
        Me.cmdAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAge.Location = New System.Drawing.Point(5, 14)
        Me.cmdAge.Name = "cmdAge"
        Me.cmdAge.Size = New System.Drawing.Size(85, 30)
        Me.cmdAge.TabIndex = 0
        Me.cmdAge.Text = "age"
        Me.cmdAge.UseVisualStyleBackColor = True
        '
        'cmdIncome
        '
        Me.cmdIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIncome.Location = New System.Drawing.Point(341, 131)
        Me.cmdIncome.Name = "cmdIncome"
        Me.cmdIncome.Size = New System.Drawing.Size(85, 30)
        Me.cmdIncome.TabIndex = 24
        Me.cmdIncome.Text = "income"
        Me.cmdIncome.UseVisualStyleBackColor = True
        '
        'cmdHeight
        '
        Me.cmdHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHeight.Location = New System.Drawing.Point(257, 131)
        Me.cmdHeight.Name = "cmdHeight"
        Me.cmdHeight.Size = New System.Drawing.Size(85, 30)
        Me.cmdHeight.TabIndex = 23
        Me.cmdHeight.Text = "height"
        Me.cmdHeight.UseVisualStyleBackColor = True
        '
        'cmdHair
        '
        Me.cmdHair.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdHair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHair.Location = New System.Drawing.Point(173, 131)
        Me.cmdHair.Name = "cmdHair"
        Me.cmdHair.Size = New System.Drawing.Size(85, 30)
        Me.cmdHair.TabIndex = 22
        Me.cmdHair.Text = "hair (f)"
        Me.cmdHair.UseVisualStyleBackColor = True
        '
        'cmdGroup
        '
        Me.cmdGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGroup.Location = New System.Drawing.Point(89, 131)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Size = New System.Drawing.Size(85, 30)
        Me.cmdGroup.TabIndex = 21
        Me.cmdGroup.Text = "group (f)"
        Me.cmdGroup.UseVisualStyleBackColor = True
        '
        'cmdGrade
        '
        Me.cmdGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGrade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGrade.Location = New System.Drawing.Point(5, 131)
        Me.cmdGrade.Name = "cmdGrade"
        Me.cmdGrade.Size = New System.Drawing.Size(85, 30)
        Me.cmdGrade.TabIndex = 20
        Me.cmdGrade.Text = "grade"
        Me.cmdGrade.UseVisualStyleBackColor = True
        '
        'cmdWakefieldHelp
        '
        Me.cmdWakefieldHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefieldHelp.Location = New System.Drawing.Point(782, 39)
        Me.cmdWakefieldHelp.Name = "cmdWakefieldHelp"
        Me.cmdWakefieldHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdWakefieldHelp.TabIndex = 183
        Me.cmdWakefieldHelp.Text = "R Help"
        Me.cmdWakefieldHelp.UseVisualStyleBackColor = True
        '
        'grpMaths
        '
        Me.grpMaths.Controls.Add(Me.cmdMathsHelp)
        Me.grpMaths.Controls.Add(Me.cmdAtan2)
        Me.grpMaths.Controls.Add(Me.cmdLogistic)
        Me.grpMaths.Controls.Add(Me.cmdLogit)
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
        Me.grpMaths.Location = New System.Drawing.Point(431, 61)
        Me.grpMaths.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMaths.Name = "grpMaths"
        Me.grpMaths.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpMaths.Size = New System.Drawing.Size(256, 164)
        Me.grpMaths.TabIndex = 184
        Me.grpMaths.TabStop = False
        Me.grpMaths.Text = "Maths"
        '
        'cmdMathsHelp
        '
        Me.cmdMathsHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMathsHelp.Location = New System.Drawing.Point(179, 136)
        Me.cmdMathsHelp.Name = "cmdMathsHelp"
        Me.cmdMathsHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdMathsHelp.TabIndex = 183
        Me.cmdMathsHelp.Text = "R Help"
        Me.cmdMathsHelp.UseVisualStyleBackColor = True
        '
        'cmdAtan2
        '
        Me.cmdAtan2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAtan2.Location = New System.Drawing.Point(102, 130)
        Me.cmdAtan2.Name = "cmdAtan2"
        Me.cmdAtan2.Size = New System.Drawing.Size(51, 30)
        Me.cmdAtan2.TabIndex = 151
        Me.cmdAtan2.Text = "atan2"
        Me.cmdAtan2.UseVisualStyleBackColor = True
        '
        'cmdLogistic
        '
        Me.cmdLogistic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogistic.Location = New System.Drawing.Point(52, 130)
        Me.cmdLogistic.Name = "cmdLogistic"
        Me.cmdLogistic.Size = New System.Drawing.Size(51, 30)
        Me.cmdLogistic.TabIndex = 149
        Me.cmdLogistic.Text = "logistic"
        Me.cmdLogistic.UseVisualStyleBackColor = True
        '
        'cmdLogit
        '
        Me.cmdLogit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogit.Location = New System.Drawing.Point(2, 130)
        Me.cmdLogit.Name = "cmdLogit"
        Me.cmdLogit.Size = New System.Drawing.Size(51, 30)
        Me.cmdLogit.TabIndex = 148
        Me.cmdLogit.Text = "logit"
        Me.cmdLogit.UseVisualStyleBackColor = True
        '
        'cmdSign
        '
        Me.cmdSign.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSign.Location = New System.Drawing.Point(203, 101)
        Me.cmdSign.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(51, 30)
        Me.cmdSign.TabIndex = 147
        Me.cmdSign.Text = "sign"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmdRound
        '
        Me.cmdRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRound.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRound.Location = New System.Drawing.Point(153, 101)
        Me.cmdRound.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRound.Name = "cmdRound"
        Me.cmdRound.Size = New System.Drawing.Size(51, 30)
        Me.cmdRound.TabIndex = 146
        Me.cmdRound.Text = "round"
        Me.cmdRound.UseVisualStyleBackColor = True
        '
        'cmdSiginf
        '
        Me.cmdSiginf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSiginf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSiginf.Location = New System.Drawing.Point(103, 101)
        Me.cmdSiginf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSiginf.Name = "cmdSiginf"
        Me.cmdSiginf.Size = New System.Drawing.Size(51, 30)
        Me.cmdSiginf.TabIndex = 145
        Me.cmdSiginf.Text = "siginf"
        Me.cmdSiginf.UseVisualStyleBackColor = True
        '
        'cmdAbs
        '
        Me.cmdAbs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAbs.Location = New System.Drawing.Point(52, 101)
        Me.cmdAbs.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.Size = New System.Drawing.Size(51, 30)
        Me.cmdAbs.TabIndex = 144
        Me.cmdAbs.Text = "abs"
        Me.cmdAbs.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExp.Location = New System.Drawing.Point(2, 101)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(51, 30)
        Me.cmdExp.TabIndex = 143
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdDeg
        '
        Me.cmdDeg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDeg.Location = New System.Drawing.Point(203, 72)
        Me.cmdDeg.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDeg.Name = "cmdDeg"
        Me.cmdDeg.Size = New System.Drawing.Size(51, 30)
        Me.cmdDeg.TabIndex = 142
        Me.cmdDeg.Text = "deg"
        Me.cmdDeg.UseVisualStyleBackColor = True
        '
        'cmdTrunc
        '
        Me.cmdTrunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrunc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrunc.Location = New System.Drawing.Point(153, 72)
        Me.cmdTrunc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrunc.Name = "cmdTrunc"
        Me.cmdTrunc.Size = New System.Drawing.Size(51, 30)
        Me.cmdTrunc.TabIndex = 141
        Me.cmdTrunc.Text = "trunc"
        Me.cmdTrunc.UseVisualStyleBackColor = True
        '
        'cmdAtan
        '
        Me.cmdAtan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAtan.Location = New System.Drawing.Point(103, 72)
        Me.cmdAtan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAtan.Name = "cmdAtan"
        Me.cmdAtan.Size = New System.Drawing.Size(51, 30)
        Me.cmdAtan.TabIndex = 140
        Me.cmdAtan.Text = "atan"
        Me.cmdAtan.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTan.Location = New System.Drawing.Point(52, 72)
        Me.cmdTan.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(51, 30)
        Me.cmdTan.TabIndex = 139
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdLogTen
        '
        Me.cmdLogTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLogTen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogTen.Location = New System.Drawing.Point(2, 72)
        Me.cmdLogTen.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLogTen.Name = "cmdLogTen"
        Me.cmdLogTen.Size = New System.Drawing.Size(51, 30)
        Me.cmdLogTen.TabIndex = 138
        Me.cmdLogTen.Text = "log10"
        Me.cmdLogTen.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        Me.cmdRad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRad.Location = New System.Drawing.Point(203, 43)
        Me.cmdRad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRad.Name = "cmdRad"
        Me.cmdRad.Size = New System.Drawing.Size(51, 30)
        Me.cmdRad.TabIndex = 137
        Me.cmdRad.Text = "rad"
        Me.cmdRad.UseVisualStyleBackColor = True
        '
        'cmdFloor
        '
        Me.cmdFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFloor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFloor.Location = New System.Drawing.Point(153, 43)
        Me.cmdFloor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFloor.Name = "cmdFloor"
        Me.cmdFloor.Size = New System.Drawing.Size(51, 30)
        Me.cmdFloor.TabIndex = 136
        Me.cmdFloor.Text = "floor"
        Me.cmdFloor.UseVisualStyleBackColor = True
        '
        'cmdAsin
        '
        Me.cmdAsin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAsin.Location = New System.Drawing.Point(103, 43)
        Me.cmdAsin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAsin.Name = "cmdAsin"
        Me.cmdAsin.Size = New System.Drawing.Size(51, 30)
        Me.cmdAsin.TabIndex = 135
        Me.cmdAsin.Text = "asin"
        Me.cmdAsin.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSin.Location = New System.Drawing.Point(52, 43)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(51, 30)
        Me.cmdSin.TabIndex = 134
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLog.Location = New System.Drawing.Point(2, 43)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(51, 30)
        Me.cmdLog.TabIndex = 133
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPi.Location = New System.Drawing.Point(203, 14)
        Me.cmdPi.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(51, 30)
        Me.cmdPi.TabIndex = 132
        Me.cmdPi.Text = "pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdCeiling
        '
        Me.cmdCeiling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCeiling.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCeiling.Location = New System.Drawing.Point(153, 14)
        Me.cmdCeiling.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCeiling.Name = "cmdCeiling"
        Me.cmdCeiling.Size = New System.Drawing.Size(51, 30)
        Me.cmdCeiling.TabIndex = 131
        Me.cmdCeiling.Text = "ceiling"
        Me.cmdCeiling.UseVisualStyleBackColor = True
        '
        'cmdAcos
        '
        Me.cmdAcos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAcos.Location = New System.Drawing.Point(103, 14)
        Me.cmdAcos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAcos.Name = "cmdAcos"
        Me.cmdAcos.Size = New System.Drawing.Size(51, 30)
        Me.cmdAcos.TabIndex = 130
        Me.cmdAcos.Text = "acos"
        Me.cmdAcos.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        Me.cmdCos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCos.Location = New System.Drawing.Point(52, 14)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(51, 30)
        Me.cmdCos.TabIndex = 129
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSqrt.Location = New System.Drawing.Point(2, 14)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(51, 30)
        Me.cmdSqrt.TabIndex = 128
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.cmdSummaryHelp)
        Me.grpSummary.Controls.Add(Me.cmdKurtosis)
        Me.grpSummary.Controls.Add(Me.cmdMode1)
        Me.grpSummary.Controls.Add(Me.cmdMode)
        Me.grpSummary.Controls.Add(Me.cmdFirst)
        Me.grpSummary.Controls.Add(Me.cmdLast)
        Me.grpSummary.Controls.Add(Me.cmdnth)
        Me.grpSummary.Controls.Add(Me.cmdCor)
        Me.grpSummary.Controls.Add(Me.cmdCov)
        Me.grpSummary.Controls.Add(Me.cmdMad)
        Me.grpSummary.Controls.Add(Me.cmdMc)
        Me.grpSummary.Controls.Add(Me.cmdPropn)
        Me.grpSummary.Controls.Add(Me.cmdCv)
        Me.grpSummary.Controls.Add(Me.cmdSkew)
        Me.grpSummary.Controls.Add(Me.cmdAnyDup)
        Me.grpSummary.Controls.Add(Me.cmdDistinct)
        Me.grpSummary.Controls.Add(Me.cmdNonMiss)
        Me.grpSummary.Controls.Add(Me.cmdIQR)
        Me.grpSummary.Controls.Add(Me.cmdQuantile)
        Me.grpSummary.Controls.Add(Me.cmdRange)
        Me.grpSummary.Controls.Add(Me.cmdSd)
        Me.grpSummary.Controls.Add(Me.cmdMedian)
        Me.grpSummary.Controls.Add(Me.cmdMin)
        Me.grpSummary.Controls.Add(Me.cmdMax)
        Me.grpSummary.Controls.Add(Me.cmdMean)
        Me.grpSummary.Controls.Add(Me.cmdMiss)
        Me.grpSummary.Controls.Add(Me.cmdLength)
        Me.grpSummary.Controls.Add(Me.cmdSum)
        Me.grpSummary.Controls.Add(Me.cmdVar)
        Me.grpSummary.Location = New System.Drawing.Point(431, 61)
        Me.grpSummary.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSummary.Size = New System.Drawing.Size(288, 191)
        Me.grpSummary.TabIndex = 185
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'cmdSummaryHelp
        '
        Me.cmdSummaryHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSummaryHelp.Location = New System.Drawing.Point(210, 165)
        Me.cmdSummaryHelp.Name = "cmdSummaryHelp"
        Me.cmdSummaryHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdSummaryHelp.TabIndex = 183
        Me.cmdSummaryHelp.Text = "R Help"
        Me.cmdSummaryHelp.UseVisualStyleBackColor = True
        '
        'cmdKurtosis
        '
        Me.cmdKurtosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdKurtosis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKurtosis.Location = New System.Drawing.Point(229, 100)
        Me.cmdKurtosis.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdKurtosis.Name = "cmdKurtosis"
        Me.cmdKurtosis.Size = New System.Drawing.Size(56, 30)
        Me.cmdKurtosis.TabIndex = 182
        Me.cmdKurtosis.Text = "kurtosis"
        Me.cmdKurtosis.UseVisualStyleBackColor = True
        '
        'cmdMode1
        '
        Me.cmdMode1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMode1.Location = New System.Drawing.Point(229, 42)
        Me.cmdMode1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMode1.Name = "cmdMode1"
        Me.cmdMode1.Size = New System.Drawing.Size(56, 30)
        Me.cmdMode1.TabIndex = 180
        Me.cmdMode1.Text = "mode1"
        Me.cmdMode1.UseVisualStyleBackColor = True
        '
        'cmdMode
        '
        Me.cmdMode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMode.Location = New System.Drawing.Point(174, 42)
        Me.cmdMode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMode.Name = "cmdMode"
        Me.cmdMode.Size = New System.Drawing.Size(56, 30)
        Me.cmdMode.TabIndex = 179
        Me.cmdMode.Text = "mode"
        Me.cmdMode.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFirst.Location = New System.Drawing.Point(119, 129)
        Me.cmdFirst.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(56, 30)
        Me.cmdFirst.TabIndex = 178
        Me.cmdFirst.Text = "first"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLast.Location = New System.Drawing.Point(174, 129)
        Me.cmdLast.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(56, 30)
        Me.cmdLast.TabIndex = 177
        Me.cmdLast.Text = "last"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdnth
        '
        Me.cmdnth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdnth.Location = New System.Drawing.Point(229, 129)
        Me.cmdnth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdnth.Name = "cmdnth"
        Me.cmdnth.Size = New System.Drawing.Size(56, 30)
        Me.cmdnth.TabIndex = 176
        Me.cmdnth.Text = "nth"
        Me.cmdnth.UseVisualStyleBackColor = True
        '
        'cmdCor
        '
        Me.cmdCor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCor.Location = New System.Drawing.Point(2, 158)
        Me.cmdCor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCor.Name = "cmdCor"
        Me.cmdCor.Size = New System.Drawing.Size(62, 30)
        Me.cmdCor.TabIndex = 175
        Me.cmdCor.Text = "cor"
        Me.cmdCor.UseVisualStyleBackColor = True
        '
        'cmdCov
        '
        Me.cmdCov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCov.Location = New System.Drawing.Point(63, 158)
        Me.cmdCov.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCov.Name = "cmdCov"
        Me.cmdCov.Size = New System.Drawing.Size(56, 30)
        Me.cmdCov.TabIndex = 174
        Me.cmdCov.Text = "cov"
        Me.cmdCov.UseVisualStyleBackColor = True
        '
        'cmdMad
        '
        Me.cmdMad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMad.Location = New System.Drawing.Point(174, 71)
        Me.cmdMad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMad.Name = "cmdMad"
        Me.cmdMad.Size = New System.Drawing.Size(56, 30)
        Me.cmdMad.TabIndex = 173
        Me.cmdMad.Text = "mad"
        Me.cmdMad.UseVisualStyleBackColor = True
        '
        'cmdMc
        '
        Me.cmdMc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMc.Location = New System.Drawing.Point(119, 100)
        Me.cmdMc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMc.Name = "cmdMc"
        Me.cmdMc.Size = New System.Drawing.Size(56, 30)
        Me.cmdMc.TabIndex = 172
        Me.cmdMc.Text = "mc"
        Me.cmdMc.UseVisualStyleBackColor = True
        '
        'cmdPropn
        '
        Me.cmdPropn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPropn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPropn.Location = New System.Drawing.Point(64, 129)
        Me.cmdPropn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPropn.Name = "cmdPropn"
        Me.cmdPropn.Size = New System.Drawing.Size(56, 30)
        Me.cmdPropn.TabIndex = 171
        Me.cmdPropn.Text = "propn"
        Me.cmdPropn.UseVisualStyleBackColor = True
        '
        'cmdCv
        '
        Me.cmdCv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCv.Location = New System.Drawing.Point(64, 100)
        Me.cmdCv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCv.Name = "cmdCv"
        Me.cmdCv.Size = New System.Drawing.Size(56, 30)
        Me.cmdCv.TabIndex = 170
        Me.cmdCv.Text = "cv"
        Me.cmdCv.UseVisualStyleBackColor = True
        '
        'cmdSkew
        '
        Me.cmdSkew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSkew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSkew.Location = New System.Drawing.Point(174, 100)
        Me.cmdSkew.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSkew.Name = "cmdSkew"
        Me.cmdSkew.Size = New System.Drawing.Size(56, 30)
        Me.cmdSkew.TabIndex = 169
        Me.cmdSkew.Text = "skew"
        Me.cmdSkew.UseVisualStyleBackColor = True
        '
        'cmdAnyDup
        '
        Me.cmdAnyDup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAnyDup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnyDup.Location = New System.Drawing.Point(2, 129)
        Me.cmdAnyDup.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAnyDup.Name = "cmdAnyDup"
        Me.cmdAnyDup.Size = New System.Drawing.Size(63, 30)
        Me.cmdAnyDup.TabIndex = 168
        Me.cmdAnyDup.Text = "anyDup"
        Me.cmdAnyDup.UseVisualStyleBackColor = True
        '
        'cmdDistinct
        '
        Me.cmdDistinct.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDistinct.Location = New System.Drawing.Point(2, 100)
        Me.cmdDistinct.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDistinct.Name = "cmdDistinct"
        Me.cmdDistinct.Size = New System.Drawing.Size(63, 30)
        Me.cmdDistinct.TabIndex = 167
        Me.cmdDistinct.Text = "distinct"
        Me.cmdDistinct.UseVisualStyleBackColor = True
        '
        'cmdNonMiss
        '
        Me.cmdNonMiss.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNonMiss.Location = New System.Drawing.Point(2, 71)
        Me.cmdNonMiss.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNonMiss.Name = "cmdNonMiss"
        Me.cmdNonMiss.Size = New System.Drawing.Size(63, 30)
        Me.cmdNonMiss.TabIndex = 166
        Me.cmdNonMiss.Text = "non miss"
        Me.cmdNonMiss.UseVisualStyleBackColor = True
        '
        'cmdIQR
        '
        Me.cmdIQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdIQR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIQR.Location = New System.Drawing.Point(229, 71)
        Me.cmdIQR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIQR.Name = "cmdIQR"
        Me.cmdIQR.Size = New System.Drawing.Size(56, 30)
        Me.cmdIQR.TabIndex = 165
        Me.cmdIQR.Text = "IQR"
        Me.cmdIQR.UseVisualStyleBackColor = True
        '
        'cmdQuantile
        '
        Me.cmdQuantile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuantile.Location = New System.Drawing.Point(118, 158)
        Me.cmdQuantile.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuantile.Name = "cmdQuantile"
        Me.cmdQuantile.Size = New System.Drawing.Size(56, 30)
        Me.cmdQuantile.TabIndex = 164
        Me.cmdQuantile.Text = "quantile"
        Me.cmdQuantile.UseVisualStyleBackColor = True
        '
        'cmdRange
        '
        Me.cmdRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRange.Location = New System.Drawing.Point(229, 13)
        Me.cmdRange.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRange.Name = "cmdRange"
        Me.cmdRange.Size = New System.Drawing.Size(56, 30)
        Me.cmdRange.TabIndex = 163
        Me.cmdRange.Text = "range"
        Me.cmdRange.UseVisualStyleBackColor = True
        '
        'cmdSd
        '
        Me.cmdSd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSd.Location = New System.Drawing.Point(119, 71)
        Me.cmdSd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSd.Name = "cmdSd"
        Me.cmdSd.Size = New System.Drawing.Size(56, 30)
        Me.cmdSd.TabIndex = 160
        Me.cmdSd.Text = "sd"
        Me.cmdSd.UseVisualStyleBackColor = True
        '
        'cmdMedian
        '
        Me.cmdMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMedian.Location = New System.Drawing.Point(119, 42)
        Me.cmdMedian.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMedian.Name = "cmdMedian"
        Me.cmdMedian.Size = New System.Drawing.Size(56, 30)
        Me.cmdMedian.TabIndex = 158
        Me.cmdMedian.Text = "median"
        Me.cmdMedian.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        Me.cmdMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMin.Location = New System.Drawing.Point(119, 13)
        Me.cmdMin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(56, 30)
        Me.cmdMin.TabIndex = 155
        Me.cmdMin.Text = "min"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdMax
        '
        Me.cmdMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMax.Location = New System.Drawing.Point(174, 13)
        Me.cmdMax.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.Size = New System.Drawing.Size(56, 30)
        Me.cmdMax.TabIndex = 154
        Me.cmdMax.Text = "max"
        Me.cmdMax.UseVisualStyleBackColor = True
        '
        'cmdMean
        '
        Me.cmdMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMean.Location = New System.Drawing.Point(64, 42)
        Me.cmdMean.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMean.Name = "cmdMean"
        Me.cmdMean.Size = New System.Drawing.Size(56, 30)
        Me.cmdMean.TabIndex = 153
        Me.cmdMean.Text = "mean"
        Me.cmdMean.UseVisualStyleBackColor = True
        '
        'cmdMiss
        '
        Me.cmdMiss.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMiss.Location = New System.Drawing.Point(2, 42)
        Me.cmdMiss.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdMiss.Name = "cmdMiss"
        Me.cmdMiss.Size = New System.Drawing.Size(63, 30)
        Me.cmdMiss.TabIndex = 149
        Me.cmdMiss.Text = "miss"
        Me.cmdMiss.UseVisualStyleBackColor = True
        '
        'cmdLength
        '
        Me.cmdLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLength.Location = New System.Drawing.Point(2, 13)
        Me.cmdLength.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLength.Name = "cmdLength"
        Me.cmdLength.Size = New System.Drawing.Size(63, 30)
        Me.cmdLength.TabIndex = 148
        Me.cmdLength.Text = "length"
        Me.cmdLength.UseVisualStyleBackColor = True
        '
        'cmdSum
        '
        Me.cmdSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSum.Location = New System.Drawing.Point(64, 13)
        Me.cmdSum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSum.Name = "cmdSum"
        Me.cmdSum.Size = New System.Drawing.Size(56, 30)
        Me.cmdSum.TabIndex = 150
        Me.cmdSum.Text = "sum"
        Me.cmdSum.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        Me.cmdVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVar.Location = New System.Drawing.Point(64, 71)
        Me.cmdVar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdVar.Name = "cmdVar"
        Me.cmdVar.Size = New System.Drawing.Size(56, 30)
        Me.cmdVar.TabIndex = 159
        Me.cmdVar.Text = "var"
        Me.cmdVar.UseVisualStyleBackColor = True
        '
        'grpTransform
        '
        Me.grpTransform.Controls.Add(Me.cmdHelpZoo)
        Me.grpTransform.Controls.Add(Me.cmdHelpDplyr)
        Me.grpTransform.Controls.Add(Me.cmdSortF)
        Me.grpTransform.Controls.Add(Me.cmdNasplin)
        Me.grpTransform.Controls.Add(Me.cmdNaapprox)
        Me.grpTransform.Controls.Add(Me.cmdNaest)
        Me.grpTransform.Controls.Add(Me.cmdNafill)
        Me.grpTransform.Controls.Add(Me.cmdMovmin)
        Me.grpTransform.Controls.Add(Me.cmdRowRank)
        Me.grpTransform.Controls.Add(Me.cmdDiff)
        Me.grpTransform.Controls.Add(Me.cmdCumdist)
        Me.grpTransform.Controls.Add(Me.cmdmovemean)
        Me.grpTransform.Controls.Add(Me.cmdCumMean)
        Me.grpTransform.Controls.Add(Me.cmdNtile)
        Me.grpTransform.Controls.Add(Me.cmMovMed)
        Me.grpTransform.Controls.Add(Me.cmdMRank)
        Me.grpTransform.Controls.Add(Me.cmdDRank)
        Me.grpTransform.Controls.Add(Me.cmdMovMax)
        Me.grpTransform.Controls.Add(Me.cmdMovSum)
        Me.grpTransform.Controls.Add(Me.cmdpercentrank)
        Me.grpTransform.Controls.Add(Me.cmdcumsum)
        Me.grpTransform.Controls.Add(Me.cmdcummin)
        Me.grpTransform.Controls.Add(Me.cmdcummax)
        Me.grpTransform.Controls.Add(Me.cmdPMin)
        Me.grpTransform.Controls.Add(Me.cmdpmax)
        Me.grpTransform.Controls.Add(Me.cmdLead)
        Me.grpTransform.Controls.Add(Me.cmdLag)
        Me.grpTransform.Location = New System.Drawing.Point(431, 61)
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.Size = New System.Drawing.Size(251, 218)
        Me.grpTransform.TabIndex = 189
        Me.grpTransform.TabStop = False
        Me.grpTransform.Text = "Transform"
        '
        'cmdHelpZoo
        '
        Me.cmdHelpZoo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelpZoo.Location = New System.Drawing.Point(172, 189)
        Me.cmdHelpZoo.Name = "cmdHelpZoo"
        Me.cmdHelpZoo.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelpZoo.TabIndex = 200
        Me.cmdHelpZoo.Text = "R Help(zoo)"
        Me.cmdHelpZoo.UseVisualStyleBackColor = True
        '
        'cmdHelpDplyr
        '
        Me.cmdHelpDplyr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHelpDplyr.Location = New System.Drawing.Point(98, 189)
        Me.cmdHelpDplyr.Name = "cmdHelpDplyr"
        Me.cmdHelpDplyr.Size = New System.Drawing.Size(75, 23)
        Me.cmdHelpDplyr.TabIndex = 199
        Me.cmdHelpDplyr.Text = "R Help"
        Me.cmdHelpDplyr.UseVisualStyleBackColor = True
        '
        'cmdSortF
        '
        Me.cmdSortF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSortF.Location = New System.Drawing.Point(2, 15)
        Me.cmdSortF.Name = "cmdSortF"
        Me.cmdSortF.Size = New System.Drawing.Size(62, 30)
        Me.cmdSortF.TabIndex = 198
        Me.cmdSortF.Text = "sort"
        Me.cmdSortF.UseVisualStyleBackColor = True
        '
        'cmdNasplin
        '
        Me.cmdNasplin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNasplin.Location = New System.Drawing.Point(185, 160)
        Me.cmdNasplin.Name = "cmdNasplin"
        Me.cmdNasplin.Size = New System.Drawing.Size(62, 30)
        Me.cmdNasplin.TabIndex = 197
        Me.cmdNasplin.Text = "nasplin"
        Me.cmdNasplin.UseVisualStyleBackColor = True
        '
        'cmdNaapprox
        '
        Me.cmdNaapprox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNaapprox.Location = New System.Drawing.Point(124, 160)
        Me.cmdNaapprox.Name = "cmdNaapprox"
        Me.cmdNaapprox.Size = New System.Drawing.Size(62, 30)
        Me.cmdNaapprox.TabIndex = 196
        Me.cmdNaapprox.Text = "naapprox"
        Me.cmdNaapprox.UseVisualStyleBackColor = True
        '
        'cmdNaest
        '
        Me.cmdNaest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNaest.Location = New System.Drawing.Point(63, 160)
        Me.cmdNaest.Name = "cmdNaest"
        Me.cmdNaest.Size = New System.Drawing.Size(62, 30)
        Me.cmdNaest.TabIndex = 195
        Me.cmdNaest.Text = "naest"
        Me.cmdNaest.UseVisualStyleBackColor = True
        '
        'cmdNafill
        '
        Me.cmdNafill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNafill.Location = New System.Drawing.Point(2, 160)
        Me.cmdNafill.Name = "cmdNafill"
        Me.cmdNafill.Size = New System.Drawing.Size(62, 30)
        Me.cmdNafill.TabIndex = 194
        Me.cmdNafill.Text = "nafill"
        Me.cmdNafill.UseVisualStyleBackColor = True
        '
        'cmdMovmin
        '
        Me.cmdMovmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovmin.Location = New System.Drawing.Point(2, 102)
        Me.cmdMovmin.Name = "cmdMovmin"
        Me.cmdMovmin.Size = New System.Drawing.Size(62, 30)
        Me.cmdMovmin.TabIndex = 193
        Me.cmdMovmin.Text = "movmin"
        Me.cmdMovmin.UseVisualStyleBackColor = True
        '
        'cmdRowRank
        '
        Me.cmdRowRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRowRank.Location = New System.Drawing.Point(2, 131)
        Me.cmdRowRank.Name = "cmdRowRank"
        Me.cmdRowRank.Size = New System.Drawing.Size(62, 30)
        Me.cmdRowRank.TabIndex = 192
        Me.cmdRowRank.Text = "r_rank"
        Me.cmdRowRank.UseVisualStyleBackColor = True
        '
        'cmdDiff
        '
        Me.cmdDiff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiff.Location = New System.Drawing.Point(63, 102)
        Me.cmdDiff.Name = "cmdDiff"
        Me.cmdDiff.Size = New System.Drawing.Size(62, 30)
        Me.cmdDiff.TabIndex = 191
        Me.cmdDiff.Text = "diff"
        Me.cmdDiff.UseVisualStyleBackColor = True
        '
        'cmdCumdist
        '
        Me.cmdCumdist.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumdist.Location = New System.Drawing.Point(185, 102)
        Me.cmdCumdist.Name = "cmdCumdist"
        Me.cmdCumdist.Size = New System.Drawing.Size(62, 30)
        Me.cmdCumdist.TabIndex = 190
        Me.cmdCumdist.Text = "cumdist"
        Me.cmdCumdist.UseVisualStyleBackColor = True
        '
        'cmdmovemean
        '
        Me.cmdmovemean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdmovemean.Location = New System.Drawing.Point(124, 73)
        Me.cmdmovemean.Name = "cmdmovemean"
        Me.cmdmovemean.Size = New System.Drawing.Size(62, 30)
        Me.cmdmovemean.TabIndex = 189
        Me.cmdmovemean.Text = "movmean"
        Me.cmdmovemean.UseVisualStyleBackColor = True
        '
        'cmdCumMean
        '
        Me.cmdCumMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumMean.Location = New System.Drawing.Point(124, 44)
        Me.cmdCumMean.Name = "cmdCumMean"
        Me.cmdCumMean.Size = New System.Drawing.Size(62, 30)
        Me.cmdCumMean.TabIndex = 188
        Me.cmdCumMean.Text = "cummean"
        Me.cmdCumMean.UseVisualStyleBackColor = True
        '
        'cmdNtile
        '
        Me.cmdNtile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNtile.Location = New System.Drawing.Point(124, 102)
        Me.cmdNtile.Name = "cmdNtile"
        Me.cmdNtile.Size = New System.Drawing.Size(62, 30)
        Me.cmdNtile.TabIndex = 187
        Me.cmdNtile.Text = "ntile"
        Me.cmdNtile.UseVisualStyleBackColor = True
        '
        'cmMovMed
        '
        Me.cmMovMed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmMovMed.Location = New System.Drawing.Point(185, 73)
        Me.cmMovMed.Name = "cmMovMed"
        Me.cmMovMed.Size = New System.Drawing.Size(62, 30)
        Me.cmMovMed.TabIndex = 186
        Me.cmMovMed.Text = "movmed"
        Me.cmMovMed.UseVisualStyleBackColor = True
        '
        'cmdMRank
        '
        Me.cmdMRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMRank.Location = New System.Drawing.Point(185, 131)
        Me.cmdMRank.Name = "cmdMRank"
        Me.cmdMRank.Size = New System.Drawing.Size(62, 30)
        Me.cmdMRank.TabIndex = 185
        Me.cmdMRank.Text = "m_rank"
        Me.cmdMRank.UseVisualStyleBackColor = True
        '
        'cmdDRank
        '
        Me.cmdDRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDRank.Location = New System.Drawing.Point(124, 131)
        Me.cmdDRank.Name = "cmdDRank"
        Me.cmdDRank.Size = New System.Drawing.Size(62, 30)
        Me.cmdDRank.TabIndex = 184
        Me.cmdDRank.Text = "d_rank"
        Me.cmdDRank.UseVisualStyleBackColor = True
        '
        'cmdMovMax
        '
        Me.cmdMovMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovMax.Location = New System.Drawing.Point(2, 73)
        Me.cmdMovMax.Name = "cmdMovMax"
        Me.cmdMovMax.Size = New System.Drawing.Size(62, 30)
        Me.cmdMovMax.TabIndex = 183
        Me.cmdMovMax.Text = "movmax"
        Me.cmdMovMax.UseVisualStyleBackColor = True
        '
        'cmdMovSum
        '
        Me.cmdMovSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovSum.Location = New System.Drawing.Point(63, 73)
        Me.cmdMovSum.Name = "cmdMovSum"
        Me.cmdMovSum.Size = New System.Drawing.Size(62, 30)
        Me.cmdMovSum.TabIndex = 182
        Me.cmdMovSum.Text = "movsum"
        Me.cmdMovSum.UseVisualStyleBackColor = True
        '
        'cmdpercentrank
        '
        Me.cmdpercentrank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdpercentrank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdpercentrank.Location = New System.Drawing.Point(63, 131)
        Me.cmdpercentrank.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdpercentrank.Name = "cmdpercentrank"
        Me.cmdpercentrank.Size = New System.Drawing.Size(62, 30)
        Me.cmdpercentrank.TabIndex = 181
        Me.cmdpercentrank.Text = "% rank"
        Me.cmdpercentrank.UseVisualStyleBackColor = True
        '
        'cmdcumsum
        '
        Me.cmdcumsum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdcumsum.Location = New System.Drawing.Point(63, 44)
        Me.cmdcumsum.Name = "cmdcumsum"
        Me.cmdcumsum.Size = New System.Drawing.Size(62, 30)
        Me.cmdcumsum.TabIndex = 180
        Me.cmdcumsum.Text = "cumsum"
        Me.cmdcumsum.UseVisualStyleBackColor = True
        '
        'cmdcummin
        '
        Me.cmdcummin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdcummin.Location = New System.Drawing.Point(185, 44)
        Me.cmdcummin.Name = "cmdcummin"
        Me.cmdcummin.Size = New System.Drawing.Size(62, 30)
        Me.cmdcummin.TabIndex = 179
        Me.cmdcummin.Text = "cummin"
        Me.cmdcummin.UseVisualStyleBackColor = True
        '
        'cmdcummax
        '
        Me.cmdcummax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdcummax.Location = New System.Drawing.Point(2, 44)
        Me.cmdcummax.Name = "cmdcummax"
        Me.cmdcummax.Size = New System.Drawing.Size(62, 30)
        Me.cmdcummax.TabIndex = 178
        Me.cmdcummax.Text = "cummax"
        Me.cmdcummax.UseVisualStyleBackColor = True
        '
        'cmdPMin
        '
        Me.cmdPMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPMin.Location = New System.Drawing.Point(192, 15)
        Me.cmdPMin.Name = "cmdPMin"
        Me.cmdPMin.Size = New System.Drawing.Size(55, 30)
        Me.cmdPMin.TabIndex = 177
        Me.cmdPMin.Text = "pmin"
        Me.cmdPMin.UseVisualStyleBackColor = True
        '
        'cmdpmax
        '
        Me.cmdpmax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdpmax.Location = New System.Drawing.Point(149, 15)
        Me.cmdpmax.Name = "cmdpmax"
        Me.cmdpmax.Size = New System.Drawing.Size(44, 30)
        Me.cmdpmax.TabIndex = 176
        Me.cmdpmax.Text = "pmax"
        Me.cmdpmax.UseVisualStyleBackColor = True
        '
        'cmdLead
        '
        Me.cmdLead.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLead.Location = New System.Drawing.Point(106, 15)
        Me.cmdLead.Name = "cmdLead"
        Me.cmdLead.Size = New System.Drawing.Size(44, 30)
        Me.cmdLead.TabIndex = 175
        Me.cmdLead.Text = "lead"
        Me.cmdLead.UseVisualStyleBackColor = True
        '
        'cmdLag
        '
        Me.cmdLag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLag.Location = New System.Drawing.Point(63, 15)
        Me.cmdLag.Name = "cmdLag"
        Me.cmdLag.Size = New System.Drawing.Size(44, 30)
        Me.cmdLag.TabIndex = 174
        Me.cmdLag.Text = "lag"
        Me.cmdLag.UseVisualStyleBackColor = True
        '
        'grpProbabilty
        '
        Me.grpProbabilty.Controls.Add(Me.cmdProbRHelp)
        Me.grpProbabilty.Controls.Add(Me.cmdQnbin)
        Me.grpProbabilty.Controls.Add(Me.cmdQpois)
        Me.grpProbabilty.Controls.Add(Me.cmdQbinom)
        Me.grpProbabilty.Controls.Add(Me.cmdQbirth)
        Me.grpProbabilty.Controls.Add(Me.cmdQbeta)
        Me.grpProbabilty.Controls.Add(Me.cmdPnbin)
        Me.grpProbabilty.Controls.Add(Me.cmdPpois)
        Me.grpProbabilty.Controls.Add(Me.cmdPbinom)
        Me.grpProbabilty.Controls.Add(Me.cmdPbirth)
        Me.grpProbabilty.Controls.Add(Me.cmdPbeta)
        Me.grpProbabilty.Controls.Add(Me.cmdQgamma)
        Me.grpProbabilty.Controls.Add(Me.cmdPgamma)
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
        Me.grpProbabilty.Controls.Add(Me.cmdDigamma)
        Me.grpProbabilty.Location = New System.Drawing.Point(431, 61)
        Me.grpProbabilty.Name = "grpProbabilty"
        Me.grpProbabilty.Size = New System.Drawing.Size(316, 215)
        Me.grpProbabilty.TabIndex = 187
        Me.grpProbabilty.TabStop = False
        Me.grpProbabilty.Text = "Probability"
        '
        'cmdProbRHelp
        '
        Me.cmdProbRHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdProbRHelp.Location = New System.Drawing.Point(233, 189)
        Me.cmdProbRHelp.Name = "cmdProbRHelp"
        Me.cmdProbRHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdProbRHelp.TabIndex = 198
        Me.cmdProbRHelp.Text = "R Help"
        Me.cmdProbRHelp.UseVisualStyleBackColor = True
        '
        'cmdQnbin
        '
        Me.cmdQnbin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQnbin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQnbin.Location = New System.Drawing.Point(246, 102)
        Me.cmdQnbin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQnbin.Name = "cmdQnbin"
        Me.cmdQnbin.Size = New System.Drawing.Size(62, 30)
        Me.cmdQnbin.TabIndex = 176
        Me.cmdQnbin.Text = "qnbin"
        Me.cmdQnbin.UseVisualStyleBackColor = True
        '
        'cmdQpois
        '
        Me.cmdQpois.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQpois.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQpois.Location = New System.Drawing.Point(185, 102)
        Me.cmdQpois.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQpois.Name = "cmdQpois"
        Me.cmdQpois.Size = New System.Drawing.Size(62, 30)
        Me.cmdQpois.TabIndex = 175
        Me.cmdQpois.Text = "qpois"
        Me.cmdQpois.UseVisualStyleBackColor = True
        '
        'cmdQbinom
        '
        Me.cmdQbinom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQbinom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQbinom.Location = New System.Drawing.Point(124, 102)
        Me.cmdQbinom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQbinom.Name = "cmdQbinom"
        Me.cmdQbinom.Size = New System.Drawing.Size(62, 30)
        Me.cmdQbinom.TabIndex = 174
        Me.cmdQbinom.Text = "qbinom"
        Me.cmdQbinom.UseVisualStyleBackColor = True
        '
        'cmdQbirth
        '
        Me.cmdQbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQbirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQbirth.Location = New System.Drawing.Point(63, 102)
        Me.cmdQbirth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQbirth.Name = "cmdQbirth"
        Me.cmdQbirth.Size = New System.Drawing.Size(62, 30)
        Me.cmdQbirth.TabIndex = 173
        Me.cmdQbirth.Text = "qbirth"
        Me.cmdQbirth.UseVisualStyleBackColor = True
        '
        'cmdQbeta
        '
        Me.cmdQbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQbeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQbeta.Location = New System.Drawing.Point(2, 102)
        Me.cmdQbeta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQbeta.Name = "cmdQbeta"
        Me.cmdQbeta.Size = New System.Drawing.Size(62, 30)
        Me.cmdQbeta.TabIndex = 172
        Me.cmdQbeta.Text = "qbeta"
        Me.cmdQbeta.UseVisualStyleBackColor = True
        '
        'cmdPnbin
        '
        Me.cmdPnbin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPnbin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPnbin.Location = New System.Drawing.Point(246, 73)
        Me.cmdPnbin.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPnbin.Name = "cmdPnbin"
        Me.cmdPnbin.Size = New System.Drawing.Size(62, 30)
        Me.cmdPnbin.TabIndex = 171
        Me.cmdPnbin.Text = "pnbin"
        Me.cmdPnbin.UseVisualStyleBackColor = True
        '
        'cmdPpois
        '
        Me.cmdPpois.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPpois.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPpois.Location = New System.Drawing.Point(185, 73)
        Me.cmdPpois.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPpois.Name = "cmdPpois"
        Me.cmdPpois.Size = New System.Drawing.Size(62, 30)
        Me.cmdPpois.TabIndex = 170
        Me.cmdPpois.Text = "ppois"
        Me.cmdPpois.UseVisualStyleBackColor = True
        '
        'cmdPbinom
        '
        Me.cmdPbinom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPbinom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbinom.Location = New System.Drawing.Point(124, 73)
        Me.cmdPbinom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPbinom.Name = "cmdPbinom"
        Me.cmdPbinom.Size = New System.Drawing.Size(62, 30)
        Me.cmdPbinom.TabIndex = 169
        Me.cmdPbinom.Text = "pbinom"
        Me.cmdPbinom.UseVisualStyleBackColor = True
        '
        'cmdPbirth
        '
        Me.cmdPbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPbirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbirth.Location = New System.Drawing.Point(63, 73)
        Me.cmdPbirth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPbirth.Name = "cmdPbirth"
        Me.cmdPbirth.Size = New System.Drawing.Size(62, 30)
        Me.cmdPbirth.TabIndex = 168
        Me.cmdPbirth.Text = "pbirth"
        Me.cmdPbirth.UseVisualStyleBackColor = True
        '
        'cmdPbeta
        '
        Me.cmdPbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPbeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbeta.Location = New System.Drawing.Point(2, 73)
        Me.cmdPbeta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPbeta.Name = "cmdPbeta"
        Me.cmdPbeta.Size = New System.Drawing.Size(62, 30)
        Me.cmdPbeta.TabIndex = 167
        Me.cmdPbeta.Text = "pbeta"
        Me.cmdPbeta.UseVisualStyleBackColor = True
        '
        'cmdQgamma
        '
        Me.cmdQgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQgamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQgamma.Location = New System.Drawing.Point(246, 44)
        Me.cmdQgamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQgamma.Name = "cmdQgamma"
        Me.cmdQgamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdQgamma.TabIndex = 166
        Me.cmdQgamma.Text = "qgamma"
        Me.cmdQgamma.UseVisualStyleBackColor = True
        '
        'cmdPgamma
        '
        Me.cmdPgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPgamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPgamma.Location = New System.Drawing.Point(246, 15)
        Me.cmdPgamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPgamma.Name = "cmdPgamma"
        Me.cmdPgamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdPgamma.TabIndex = 165
        Me.cmdPgamma.Text = "pgamma"
        Me.cmdPgamma.UseVisualStyleBackColor = True
        '
        'cmdGamma
        '
        Me.cmdGamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdGamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGamma.Location = New System.Drawing.Point(185, 131)
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
        Me.cmdLbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLbeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLbeta.Location = New System.Drawing.Point(124, 160)
        Me.cmdLbeta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLbeta.Name = "cmdLbeta"
        Me.cmdLbeta.Size = New System.Drawing.Size(62, 30)
        Me.cmdLbeta.TabIndex = 159
        Me.cmdLbeta.Text = "lbeta"
        Me.cmdLbeta.UseVisualStyleBackColor = True
        '
        'cmdqF
        '
        Me.cmdqF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdqF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdqF.Location = New System.Drawing.Point(185, 44)
        Me.cmdqF.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdqF.Name = "cmdqF"
        Me.cmdqF.Size = New System.Drawing.Size(62, 30)
        Me.cmdqF.TabIndex = 162
        Me.cmdqF.Text = "qf"
        Me.cmdqF.UseVisualStyleBackColor = True
        '
        'cmdFact
        '
        Me.cmdFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFact.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFact.Location = New System.Drawing.Point(2, 131)
        Me.cmdFact.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdFact.Name = "cmdFact"
        Me.cmdFact.Size = New System.Drawing.Size(62, 30)
        Me.cmdFact.TabIndex = 154
        Me.cmdFact.Text = "fact"
        Me.cmdFact.UseVisualStyleBackColor = True
        '
        'cmdChoose
        '
        Me.cmdChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChoose.Location = New System.Drawing.Point(63, 131)
        Me.cmdChoose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdChoose.Name = "cmdChoose"
        Me.cmdChoose.Size = New System.Drawing.Size(62, 30)
        Me.cmdChoose.TabIndex = 161
        Me.cmdChoose.Text = "choose"
        Me.cmdChoose.UseVisualStyleBackColor = True
        '
        'cmdPf
        '
        Me.cmdPf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPf.Location = New System.Drawing.Point(185, 15)
        Me.cmdPf.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPf.Name = "cmdPf"
        Me.cmdPf.Size = New System.Drawing.Size(62, 30)
        Me.cmdPf.TabIndex = 156
        Me.cmdPf.Text = "pf"
        Me.cmdPf.UseVisualStyleBackColor = True
        '
        'cmdPChisq
        '
        Me.cmdPChisq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPChisq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPChisq.Location = New System.Drawing.Point(124, 15)
        Me.cmdPChisq.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPChisq.Name = "cmdPChisq"
        Me.cmdPChisq.Size = New System.Drawing.Size(62, 30)
        Me.cmdPChisq.TabIndex = 155
        Me.cmdPChisq.Text = "pchisq"
        Me.cmdPChisq.UseVisualStyleBackColor = True
        '
        'cmdLgamma
        '
        Me.cmdLgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLgamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLgamma.Location = New System.Drawing.Point(185, 160)
        Me.cmdLgamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLgamma.Name = "cmdLgamma"
        Me.cmdLgamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdLgamma.TabIndex = 152
        Me.cmdLgamma.Text = "lgamma"
        Me.cmdLgamma.UseVisualStyleBackColor = True
        '
        'cmdPnorm
        '
        Me.cmdPnorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPnorm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPnorm.Location = New System.Drawing.Point(2, 15)
        Me.cmdPnorm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPnorm.Name = "cmdPnorm"
        Me.cmdPnorm.Size = New System.Drawing.Size(62, 30)
        Me.cmdPnorm.TabIndex = 148
        Me.cmdPnorm.Text = "pnorm"
        Me.cmdPnorm.UseVisualStyleBackColor = True
        '
        'cmdQchisq
        '
        Me.cmdQchisq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQchisq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQchisq.Location = New System.Drawing.Point(124, 44)
        Me.cmdQchisq.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQchisq.Name = "cmdQchisq"
        Me.cmdQchisq.Size = New System.Drawing.Size(62, 30)
        Me.cmdQchisq.TabIndex = 160
        Me.cmdQchisq.Text = "qchisq"
        Me.cmdQchisq.UseVisualStyleBackColor = True
        '
        'cmdQt
        '
        Me.cmdQt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQt.Location = New System.Drawing.Point(63, 44)
        Me.cmdQt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQt.Name = "cmdQt"
        Me.cmdQt.Size = New System.Drawing.Size(62, 30)
        Me.cmdQt.TabIndex = 158
        Me.cmdQt.Text = "qt"
        Me.cmdQt.UseVisualStyleBackColor = True
        '
        'cmdQnorm
        '
        Me.cmdQnorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQnorm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQnorm.Location = New System.Drawing.Point(2, 44)
        Me.cmdQnorm.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQnorm.Name = "cmdQnorm"
        Me.cmdQnorm.Size = New System.Drawing.Size(62, 30)
        Me.cmdQnorm.TabIndex = 157
        Me.cmdQnorm.Text = "qnorm"
        Me.cmdQnorm.UseVisualStyleBackColor = True
        '
        'cmdPt
        '
        Me.cmdPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPt.Location = New System.Drawing.Point(63, 15)
        Me.cmdPt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPt.Name = "cmdPt"
        Me.cmdPt.Size = New System.Drawing.Size(62, 30)
        Me.cmdPt.TabIndex = 153
        Me.cmdPt.Text = "pt"
        Me.cmdPt.UseVisualStyleBackColor = True
        '
        'cmdLchoose
        '
        Me.cmdLchoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLchoose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLchoose.Location = New System.Drawing.Point(63, 160)
        Me.cmdLchoose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLchoose.Name = "cmdLchoose"
        Me.cmdLchoose.Size = New System.Drawing.Size(62, 30)
        Me.cmdLchoose.TabIndex = 151
        Me.cmdLchoose.Text = "lchoose"
        Me.cmdLchoose.UseVisualStyleBackColor = True
        '
        'cmdLfact
        '
        Me.cmdLfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLfact.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLfact.Location = New System.Drawing.Point(2, 160)
        Me.cmdLfact.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLfact.Name = "cmdLfact"
        Me.cmdLfact.Size = New System.Drawing.Size(62, 30)
        Me.cmdLfact.TabIndex = 150
        Me.cmdLfact.Text = "lfact"
        Me.cmdLfact.UseVisualStyleBackColor = True
        '
        'cmdTrigamma
        '
        Me.cmdTrigamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrigamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrigamma.Location = New System.Drawing.Point(246, 160)
        Me.cmdTrigamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrigamma.Name = "cmdTrigamma"
        Me.cmdTrigamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdTrigamma.TabIndex = 149
        Me.cmdTrigamma.Text = "trigamma"
        Me.cmdTrigamma.UseVisualStyleBackColor = True
        '
        'cmdBeta
        '
        Me.cmdBeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBeta.Location = New System.Drawing.Point(124, 131)
        Me.cmdBeta.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdBeta.Name = "cmdBeta"
        Me.cmdBeta.Size = New System.Drawing.Size(62, 30)
        Me.cmdBeta.TabIndex = 149
        Me.cmdBeta.Text = "beta"
        Me.cmdBeta.UseVisualStyleBackColor = True
        '
        'cmdDigamma
        '
        Me.cmdDigamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdDigamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigamma.Location = New System.Drawing.Point(246, 131)
        Me.cmdDigamma.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdDigamma.Name = "cmdDigamma"
        Me.cmdDigamma.Size = New System.Drawing.Size(62, 30)
        Me.cmdDigamma.TabIndex = 164
        Me.cmdDigamma.Text = "digamma"
        Me.cmdDigamma.UseVisualStyleBackColor = True
        '
        'grpLogical
        '
        Me.grpLogical.Controls.Add(Me.cmdLogicalHelp)
        Me.grpLogical.Controls.Add(Me.cmdFalse)
        Me.grpLogical.Controls.Add(Me.cmdTrue)
        Me.grpLogical.Controls.Add(Me.cmdDoubleSqrBrackets)
        Me.grpLogical.Controls.Add(Me.cmdIn)
        Me.grpLogical.Controls.Add(Me.cmdWhich)
        Me.grpLogical.Controls.Add(Me.cmdNA)
        Me.grpLogical.Controls.Add(Me.cmdNear)
        Me.grpLogical.Controls.Add(Me.cmdBetween)
        Me.grpLogical.Controls.Add(Me.cmdIsNa)
        Me.grpLogical.Controls.Add(Me.cmdNotIsNa)
        Me.grpLogical.Controls.Add(Me.cmdDuplicate)
        Me.grpLogical.Controls.Add(Me.cmdIfelse)
        Me.grpLogical.Controls.Add(Me.cmdmatch)
        Me.grpLogical.Controls.Add(Me.cmdwhen)
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
        Me.grpLogical.Location = New System.Drawing.Point(431, 61)
        Me.grpLogical.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpLogical.Name = "grpLogical"
        Me.grpLogical.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpLogical.Size = New System.Drawing.Size(253, 213)
        Me.grpLogical.TabIndex = 183
        Me.grpLogical.TabStop = False
        Me.grpLogical.Text = "Logical and Symbols"
        '
        'cmdLogicalHelp
        '
        Me.cmdLogicalHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogicalHelp.Location = New System.Drawing.Point(173, 187)
        Me.cmdLogicalHelp.Name = "cmdLogicalHelp"
        Me.cmdLogicalHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdLogicalHelp.TabIndex = 208
        Me.cmdLogicalHelp.Text = "R Help"
        Me.cmdLogicalHelp.UseVisualStyleBackColor = True
        '
        'cmdFalse
        '
        Me.cmdFalse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFalse.Location = New System.Drawing.Point(152, 42)
        Me.cmdFalse.Name = "cmdFalse"
        Me.cmdFalse.Size = New System.Drawing.Size(52, 30)
        Me.cmdFalse.TabIndex = 207
        Me.cmdFalse.Text = "FALSE"
        Me.cmdFalse.UseVisualStyleBackColor = True
        '
        'cmdTrue
        '
        Me.cmdTrue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrue.Location = New System.Drawing.Point(152, 13)
        Me.cmdTrue.Name = "cmdTrue"
        Me.cmdTrue.Size = New System.Drawing.Size(52, 30)
        Me.cmdTrue.TabIndex = 206
        Me.cmdTrue.Text = "TRUE"
        Me.cmdTrue.UseVisualStyleBackColor = True
        '
        'cmdDoubleSqrBrackets
        '
        Me.cmdDoubleSqrBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoubleSqrBrackets.Location = New System.Drawing.Point(118, 71)
        Me.cmdDoubleSqrBrackets.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDoubleSqrBrackets.Name = "cmdDoubleSqrBrackets"
        Me.cmdDoubleSqrBrackets.Size = New System.Drawing.Size(50, 30)
        Me.cmdDoubleSqrBrackets.TabIndex = 205
        Me.cmdDoubleSqrBrackets.Text = "[[ ]]"
        Me.cmdDoubleSqrBrackets.UseVisualStyleBackColor = True
        '
        'cmdIn
        '
        Me.cmdIn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIn.Location = New System.Drawing.Point(78, 100)
        Me.cmdIn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIn.Name = "cmdIn"
        Me.cmdIn.Size = New System.Drawing.Size(45, 30)
        Me.cmdIn.TabIndex = 204
        Me.cmdIn.Text = "%in%"
        Me.cmdIn.UseVisualStyleBackColor = True
        '
        'cmdWhich
        '
        Me.cmdWhich.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWhich.Location = New System.Drawing.Point(196, 100)
        Me.cmdWhich.Name = "cmdWhich"
        Me.cmdWhich.Size = New System.Drawing.Size(52, 30)
        Me.cmdWhich.TabIndex = 203
        Me.cmdWhich.Text = "which"
        Me.cmdWhich.UseVisualStyleBackColor = True
        '
        'cmdNA
        '
        Me.cmdNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNA.Location = New System.Drawing.Point(159, 100)
        Me.cmdNA.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNA.Name = "cmdNA"
        Me.cmdNA.Size = New System.Drawing.Size(38, 30)
        Me.cmdNA.TabIndex = 202
        Me.cmdNA.Text = "NA"
        Me.cmdNA.UseVisualStyleBackColor = True
        '
        'cmdNear
        '
        Me.cmdNear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNear.Location = New System.Drawing.Point(186, 158)
        Me.cmdNear.Name = "cmdNear"
        Me.cmdNear.Size = New System.Drawing.Size(62, 30)
        Me.cmdNear.TabIndex = 201
        Me.cmdNear.Text = "near"
        Me.cmdNear.UseVisualStyleBackColor = True
        '
        'cmdBetween
        '
        Me.cmdBetween.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBetween.Location = New System.Drawing.Point(186, 129)
        Me.cmdBetween.Name = "cmdBetween"
        Me.cmdBetween.Size = New System.Drawing.Size(62, 30)
        Me.cmdBetween.TabIndex = 200
        Me.cmdBetween.Text = "between"
        Me.cmdBetween.UseVisualStyleBackColor = True
        '
        'cmdIsNa
        '
        Me.cmdIsNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIsNa.Location = New System.Drawing.Point(4, 158)
        Me.cmdIsNa.Name = "cmdIsNa"
        Me.cmdIsNa.Size = New System.Drawing.Size(62, 30)
        Me.cmdIsNa.TabIndex = 195
        Me.cmdIsNa.Text = "is.na"
        Me.cmdIsNa.UseVisualStyleBackColor = True
        '
        'cmdNotIsNa
        '
        Me.cmdNotIsNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNotIsNa.Location = New System.Drawing.Point(65, 158)
        Me.cmdNotIsNa.Name = "cmdNotIsNa"
        Me.cmdNotIsNa.Size = New System.Drawing.Size(58, 30)
        Me.cmdNotIsNa.TabIndex = 194
        Me.cmdNotIsNa.Text = "!is.na"
        Me.cmdNotIsNa.UseVisualStyleBackColor = True
        '
        'cmdDuplicate
        '
        Me.cmdDuplicate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDuplicate.Location = New System.Drawing.Point(122, 158)
        Me.cmdDuplicate.Name = "cmdDuplicate"
        Me.cmdDuplicate.Size = New System.Drawing.Size(65, 30)
        Me.cmdDuplicate.TabIndex = 193
        Me.cmdDuplicate.Text = "duplicated"
        Me.cmdDuplicate.UseVisualStyleBackColor = True
        '
        'cmdIfelse
        '
        Me.cmdIfelse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIfelse.Location = New System.Drawing.Point(4, 129)
        Me.cmdIfelse.Name = "cmdIfelse"
        Me.cmdIfelse.Size = New System.Drawing.Size(62, 30)
        Me.cmdIfelse.TabIndex = 192
        Me.cmdIfelse.Text = "ifelse"
        Me.cmdIfelse.UseVisualStyleBackColor = True
        '
        'cmdmatch
        '
        Me.cmdmatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdmatch.Location = New System.Drawing.Point(65, 129)
        Me.cmdmatch.Name = "cmdmatch"
        Me.cmdmatch.Size = New System.Drawing.Size(58, 30)
        Me.cmdmatch.TabIndex = 191
        Me.cmdmatch.Text = "match"
        Me.cmdmatch.UseVisualStyleBackColor = True
        '
        'cmdwhen
        '
        Me.cmdwhen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdwhen.Location = New System.Drawing.Point(122, 129)
        Me.cmdwhen.Name = "cmdwhen"
        Me.cmdwhen.Size = New System.Drawing.Size(65, 30)
        Me.cmdwhen.TabIndex = 190
        Me.cmdwhen.Text = "when"
        Me.cmdwhen.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(167, 71)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(40, 30)
        Me.cmdOpeningBracket.TabIndex = 139
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(41, 71)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(38, 30)
        Me.cmdColon.TabIndex = 139
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdGreaterOrEqualsTo
        '
        Me.cmdGreaterOrEqualsTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGreaterOrEqualsTo.Location = New System.Drawing.Point(115, 13)
        Me.cmdGreaterOrEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGreaterOrEqualsTo.Name = "cmdGreaterOrEqualsTo"
        Me.cmdGreaterOrEqualsTo.Size = New System.Drawing.Size(38, 30)
        Me.cmdGreaterOrEqualsTo.TabIndex = 138
        Me.cmdGreaterOrEqualsTo.Text = ">="
        Me.cmdGreaterOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdClossingBracket
        '
        Me.cmdClossingBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClossingBracket.Location = New System.Drawing.Point(206, 71)
        Me.cmdClossingBracket.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdClossingBracket.Name = "cmdClossingBracket"
        Me.cmdClossingBracket.Size = New System.Drawing.Size(42, 30)
        Me.cmdClossingBracket.TabIndex = 137
        Me.cmdClossingBracket.Tag = ""
        Me.cmdClossingBracket.Text = ")"
        Me.cmdClossingBracket.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        Me.cmdAnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdAnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnd.Location = New System.Drawing.Point(115, 42)
        Me.cmdAnd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Size = New System.Drawing.Size(38, 30)
        Me.cmdAnd.TabIndex = 137
        Me.cmdAnd.Tag = "And"
        Me.cmdAnd.Text = "&&"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdQuotes
        '
        Me.cmdQuotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdQuotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuotes.Location = New System.Drawing.Point(122, 100)
        Me.cmdQuotes.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.Size = New System.Drawing.Size(38, 30)
        Me.cmdQuotes.TabIndex = 135
        Me.cmdQuotes.Text = """ """
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        Me.cmdSquareBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquareBrackets.Location = New System.Drawing.Point(78, 71)
        Me.cmdSquareBrackets.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.Size = New System.Drawing.Size(42, 30)
        Me.cmdSquareBrackets.TabIndex = 134
        Me.cmdSquareBrackets.Text = "[ ]"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdIntegerDivision
        '
        Me.cmdIntegerDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIntegerDivision.Location = New System.Drawing.Point(41, 100)
        Me.cmdIntegerDivision.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdIntegerDivision.Name = "cmdIntegerDivision"
        Me.cmdIntegerDivision.Size = New System.Drawing.Size(38, 30)
        Me.cmdIntegerDivision.TabIndex = 135
        Me.cmdIntegerDivision.Text = "%/%"
        Me.cmdIntegerDivision.UseVisualStyleBackColor = True
        '
        'cmdModulas
        '
        Me.cmdModulas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModulas.Location = New System.Drawing.Point(4, 100)
        Me.cmdModulas.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdModulas.Name = "cmdModulas"
        Me.cmdModulas.Size = New System.Drawing.Size(38, 30)
        Me.cmdModulas.TabIndex = 134
        Me.cmdModulas.Text = "%%"
        Me.cmdModulas.UseVisualStyleBackColor = True
        '
        'cmdGreater
        '
        Me.cmdGreater.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGreater.Location = New System.Drawing.Point(78, 13)
        Me.cmdGreater.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.Size = New System.Drawing.Size(38, 30)
        Me.cmdGreater.TabIndex = 133
        Me.cmdGreater.Text = ">"
        Me.cmdGreater.UseVisualStyleBackColor = True
        '
        'cmdLesserOrEqualsTo
        '
        Me.cmdLesserOrEqualsTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLesserOrEqualsTo.Location = New System.Drawing.Point(41, 13)
        Me.cmdLesserOrEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLesserOrEqualsTo.Name = "cmdLesserOrEqualsTo"
        Me.cmdLesserOrEqualsTo.Size = New System.Drawing.Size(38, 30)
        Me.cmdLesserOrEqualsTo.TabIndex = 132
        Me.cmdLesserOrEqualsTo.Text = "<="
        Me.cmdLesserOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdLesser
        '
        Me.cmdLesser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLesser.Location = New System.Drawing.Point(4, 13)
        Me.cmdLesser.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLesser.Name = "cmdLesser"
        Me.cmdLesser.Size = New System.Drawing.Size(38, 30)
        Me.cmdLesser.TabIndex = 131
        Me.cmdLesser.Text = "<"
        Me.cmdLesser.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        Me.cmdOr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr.Location = New System.Drawing.Point(78, 42)
        Me.cmdOr.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.Size = New System.Drawing.Size(38, 30)
        Me.cmdOr.TabIndex = 130
        Me.cmdOr.Text = "|"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'cmdNot
        '
        Me.cmdNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdNot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNot.Location = New System.Drawing.Point(4, 71)
        Me.cmdNot.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNot.Name = "cmdNot"
        Me.cmdNot.Size = New System.Drawing.Size(38, 30)
        Me.cmdNot.TabIndex = 129
        Me.cmdNot.Text = "!"
        Me.cmdNot.UseVisualStyleBackColor = True
        '
        'cmdNotEqualsTo
        '
        Me.cmdNotEqualsTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNotEqualsTo.Location = New System.Drawing.Point(41, 42)
        Me.cmdNotEqualsTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdNotEqualsTo.Name = "cmdNotEqualsTo"
        Me.cmdNotEqualsTo.Size = New System.Drawing.Size(38, 30)
        Me.cmdNotEqualsTo.TabIndex = 128
        Me.cmdNotEqualsTo.Text = "!="
        Me.cmdNotEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdEquivalent
        '
        Me.cmdEquivalent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEquivalent.Location = New System.Drawing.Point(4, 42)
        Me.cmdEquivalent.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.Size = New System.Drawing.Size(38, 30)
        Me.cmdEquivalent.TabIndex = 127
        Me.cmdEquivalent.Text = "=="
        Me.cmdEquivalent.UseVisualStyleBackColor = True
        '
        'grpTestString
        '
        Me.grpTestString.Controls.Add(Me.cmdEnds)
        Me.grpTestString.Controls.Add(Me.cmdTrunck)
        Me.grpTestString.Controls.Add(Me.cmdLenth)
        Me.grpTestString.Controls.Add(Me.cmdGlue)
        Me.grpTestString.Controls.Add(Me.cmdStarts)
        Me.grpTestString.Controls.Add(Me.cmdReplace2)
        Me.grpTestString.Controls.Add(Me.cmdReplace)
        Me.grpTestString.Controls.Add(Me.cmdRemove2)
        Me.grpTestString.Controls.Add(Me.cmdRemove1)
        Me.grpTestString.Controls.Add(Me.cmdLocate2)
        Me.grpTestString.Controls.Add(Me.cmdExtract2)
        Me.grpTestString.Controls.Add(Me.cmdEncodeb)
        Me.grpTestString.Controls.Add(Me.cmdSquishb)
        Me.grpTestString.Controls.Add(Me.cmdSub)
        Me.grpTestString.Controls.Add(Me.cmdCombine)
        Me.grpTestString.Controls.Add(Me.cmdDetect)
        Me.grpTestString.Controls.Add(Me.cmdTrim)
        Me.grpTestString.Controls.Add(Me.cmdTitle)
        Me.grpTestString.Controls.Add(Me.cmdLower)
        Me.grpTestString.Controls.Add(Me.cmdUpper)
        Me.grpTestString.Controls.Add(Me.cmdSort)
        Me.grpTestString.Controls.Add(Me.cmdOrder)
        Me.grpTestString.Controls.Add(Me.cmdPad)
        Me.grpTestString.Controls.Add(Me.cmdExtract)
        Me.grpTestString.Controls.Add(Me.cmdCountstrings)
        Me.grpTestString.Controls.Add(Me.cmdLocate)
        Me.grpTestString.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grpTestString.Location = New System.Drawing.Point(434, 63)
        Me.grpTestString.Name = "grpTestString"
        Me.grpTestString.Size = New System.Drawing.Size(303, 164)
        Me.grpTestString.TabIndex = 186
        Me.grpTestString.TabStop = False
        Me.grpTestString.Text = "Text/Strings (Character Columns)"
        '
        'cmdEnds
        '
        Me.cmdEnds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnds.Location = New System.Drawing.Point(120, 73)
        Me.cmdEnds.Name = "cmdEnds"
        Me.cmdEnds.Size = New System.Drawing.Size(60, 30)
        Me.cmdEnds.TabIndex = 164
        Me.cmdEnds.Text = "ends"
        Me.cmdEnds.UseVisualStyleBackColor = True
        '
        'cmdTrunck
        '
        Me.cmdTrunck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrunck.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrunck.Location = New System.Drawing.Point(246, 131)
        Me.cmdTrunck.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrunck.Name = "cmdTrunck"
        Me.cmdTrunck.Size = New System.Drawing.Size(52, 30)
        Me.cmdTrunck.TabIndex = 163
        Me.cmdTrunck.Text = "trunc "
        Me.cmdTrunck.UseVisualStyleBackColor = True
        '
        'cmdLenth
        '
        Me.cmdLenth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLenth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLenth.Location = New System.Drawing.Point(61, 102)
        Me.cmdLenth.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLenth.Name = "cmdLenth"
        Me.cmdLenth.Size = New System.Drawing.Size(60, 30)
        Me.cmdLenth.TabIndex = 162
        Me.cmdLenth.Text = "length"
        Me.cmdLenth.UseVisualStyleBackColor = True
        '
        'cmdGlue
        '
        Me.cmdGlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdGlue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGlue.Location = New System.Drawing.Point(2, 102)
        Me.cmdGlue.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdGlue.Name = "cmdGlue"
        Me.cmdGlue.Size = New System.Drawing.Size(60, 30)
        Me.cmdGlue.TabIndex = 161
        Me.cmdGlue.Text = "glue"
        Me.cmdGlue.UseVisualStyleBackColor = True
        '
        'cmdStarts
        '
        Me.cmdStarts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdStarts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStarts.Location = New System.Drawing.Point(204, 131)
        Me.cmdStarts.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdStarts.Name = "cmdStarts"
        Me.cmdStarts.Size = New System.Drawing.Size(43, 30)
        Me.cmdStarts.TabIndex = 160
        Me.cmdStarts.Tag = ""
        Me.cmdStarts.Text = "starts"
        Me.cmdStarts.UseVisualStyleBackColor = True
        '
        'cmdReplace2
        '
        Me.cmdReplace2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdReplace2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReplace2.Location = New System.Drawing.Point(111, 131)
        Me.cmdReplace2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdReplace2.Name = "cmdReplace2"
        Me.cmdReplace2.Size = New System.Drawing.Size(60, 30)
        Me.cmdReplace2.TabIndex = 159
        Me.cmdReplace2.Tag = ""
        Me.cmdReplace2.Text = "replace2"
        Me.cmdReplace2.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        Me.cmdReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReplace.Location = New System.Drawing.Point(61, 131)
        Me.cmdReplace.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(51, 30)
        Me.cmdReplace.TabIndex = 158
        Me.cmdReplace.Tag = ""
        Me.cmdReplace.Text = "replace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdRemove2
        '
        Me.cmdRemove2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRemove2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemove2.Location = New System.Drawing.Point(2, 131)
        Me.cmdRemove2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRemove2.Name = "cmdRemove2"
        Me.cmdRemove2.Size = New System.Drawing.Size(60, 30)
        Me.cmdRemove2.TabIndex = 157
        Me.cmdRemove2.Tag = ""
        Me.cmdRemove2.Text = "remove2"
        Me.cmdRemove2.UseVisualStyleBackColor = True
        '
        'cmdRemove1
        '
        Me.cmdRemove1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRemove1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemove1.Location = New System.Drawing.Point(238, 102)
        Me.cmdRemove1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdRemove1.Name = "cmdRemove1"
        Me.cmdRemove1.Size = New System.Drawing.Size(60, 30)
        Me.cmdRemove1.TabIndex = 156
        Me.cmdRemove1.Tag = ""
        Me.cmdRemove1.Text = "remove"
        Me.cmdRemove1.UseVisualStyleBackColor = True
        '
        'cmdLocate2
        '
        Me.cmdLocate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLocate2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLocate2.Location = New System.Drawing.Point(179, 102)
        Me.cmdLocate2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLocate2.Name = "cmdLocate2"
        Me.cmdLocate2.Size = New System.Drawing.Size(60, 30)
        Me.cmdLocate2.TabIndex = 155
        Me.cmdLocate2.Tag = ""
        Me.cmdLocate2.Text = "locate2"
        Me.cmdLocate2.UseVisualStyleBackColor = True
        '
        'cmdExtract2
        '
        Me.cmdExtract2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExtract2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExtract2.Location = New System.Drawing.Point(238, 73)
        Me.cmdExtract2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExtract2.Name = "cmdExtract2"
        Me.cmdExtract2.Size = New System.Drawing.Size(60, 30)
        Me.cmdExtract2.TabIndex = 154
        Me.cmdExtract2.Tag = ""
        Me.cmdExtract2.Text = "extract2"
        Me.cmdExtract2.UseVisualStyleBackColor = True
        '
        'cmdEncodeb
        '
        Me.cmdEncodeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdEncodeb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEncodeb.Location = New System.Drawing.Point(238, 44)
        Me.cmdEncodeb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdEncodeb.Name = "cmdEncodeb"
        Me.cmdEncodeb.Size = New System.Drawing.Size(60, 30)
        Me.cmdEncodeb.TabIndex = 151
        Me.cmdEncodeb.Text = "encode "
        Me.cmdEncodeb.UseVisualStyleBackColor = True
        '
        'cmdSquishb
        '
        Me.cmdSquishb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSquishb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquishb.Location = New System.Drawing.Point(238, 15)
        Me.cmdSquishb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSquishb.Name = "cmdSquishb"
        Me.cmdSquishb.Size = New System.Drawing.Size(60, 30)
        Me.cmdSquishb.TabIndex = 150
        Me.cmdSquishb.Text = "squish "
        Me.cmdSquishb.UseVisualStyleBackColor = True
        '
        'cmdSub
        '
        Me.cmdSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSub.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSub.Location = New System.Drawing.Point(170, 131)
        Me.cmdSub.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSub.Name = "cmdSub"
        Me.cmdSub.Size = New System.Drawing.Size(35, 30)
        Me.cmdSub.TabIndex = 149
        Me.cmdSub.Tag = ""
        Me.cmdSub.Text = "sub"
        Me.cmdSub.UseVisualStyleBackColor = True
        '
        'cmdCombine
        '
        Me.cmdCombine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCombine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCombine.Location = New System.Drawing.Point(179, 44)
        Me.cmdCombine.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCombine.Name = "cmdCombine"
        Me.cmdCombine.Size = New System.Drawing.Size(60, 30)
        Me.cmdCombine.TabIndex = 148
        Me.cmdCombine.Text = "combine"
        Me.cmdCombine.UseVisualStyleBackColor = True
        '
        'cmdDetect
        '
        Me.cmdDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdDetect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDetect.Location = New System.Drawing.Point(61, 73)
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
        Me.cmdTrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrim.Location = New System.Drawing.Point(179, 15)
        Me.cmdTrim.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTrim.Name = "cmdTrim"
        Me.cmdTrim.Size = New System.Drawing.Size(60, 30)
        Me.cmdTrim.TabIndex = 146
        Me.cmdTrim.Text = "trim"
        Me.cmdTrim.UseVisualStyleBackColor = True
        '
        'cmdTitle
        '
        Me.cmdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitle.Location = New System.Drawing.Point(120, 15)
        Me.cmdTitle.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.Size = New System.Drawing.Size(60, 30)
        Me.cmdTitle.TabIndex = 142
        Me.cmdTitle.Text = "title"
        Me.cmdTitle.UseVisualStyleBackColor = True
        '
        'cmdLower
        '
        Me.cmdLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLower.Location = New System.Drawing.Point(61, 15)
        Me.cmdLower.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLower.Name = "cmdLower"
        Me.cmdLower.Size = New System.Drawing.Size(60, 30)
        Me.cmdLower.TabIndex = 141
        Me.cmdLower.Text = "lower"
        Me.cmdLower.UseVisualStyleBackColor = True
        '
        'cmdUpper
        '
        Me.cmdUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdUpper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUpper.Location = New System.Drawing.Point(2, 15)
        Me.cmdUpper.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdUpper.Name = "cmdUpper"
        Me.cmdUpper.Size = New System.Drawing.Size(60, 30)
        Me.cmdUpper.TabIndex = 140
        Me.cmdUpper.Text = "upper"
        Me.cmdUpper.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSort.Location = New System.Drawing.Point(120, 44)
        Me.cmdSort.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(60, 30)
        Me.cmdSort.TabIndex = 139
        Me.cmdSort.Text = "sort"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdOrder
        '
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOrder.Location = New System.Drawing.Point(61, 44)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(60, 30)
        Me.cmdOrder.TabIndex = 138
        Me.cmdOrder.Text = "order"
        Me.cmdOrder.UseVisualStyleBackColor = True
        '
        'cmdPad
        '
        Me.cmdPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPad.Location = New System.Drawing.Point(2, 44)
        Me.cmdPad.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdPad.Name = "cmdPad"
        Me.cmdPad.Size = New System.Drawing.Size(60, 30)
        Me.cmdPad.TabIndex = 137
        Me.cmdPad.Text = "pad"
        Me.cmdPad.UseVisualStyleBackColor = True
        '
        'cmdExtract
        '
        Me.cmdExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExtract.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExtract.Location = New System.Drawing.Point(179, 73)
        Me.cmdExtract.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(60, 30)
        Me.cmdExtract.TabIndex = 136
        Me.cmdExtract.Text = "extract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCountstrings
        '
        Me.cmdCountstrings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCountstrings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCountstrings.Location = New System.Drawing.Point(2, 73)
        Me.cmdCountstrings.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdCountstrings.Name = "cmdCountstrings"
        Me.cmdCountstrings.Size = New System.Drawing.Size(60, 30)
        Me.cmdCountstrings.TabIndex = 134
        Me.cmdCountstrings.Text = "count"
        Me.cmdCountstrings.UseVisualStyleBackColor = True
        '
        'cmdLocate
        '
        Me.cmdLocate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLocate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLocate.Location = New System.Drawing.Point(120, 102)
        Me.cmdLocate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmdLocate.Name = "cmdLocate"
        Me.cmdLocate.Size = New System.Drawing.Size(60, 30)
        Me.cmdLocate.TabIndex = 133
        Me.cmdLocate.Text = "locate"
        Me.cmdLocate.UseVisualStyleBackColor = True
        '
        'ttCalculator
        '
        Me.ttCalculator.AutoPopDelay = 10000
        Me.ttCalculator.InitialDelay = 500
        Me.ttCalculator.ReshowDelay = 100
        '
        'grpCircular
        '
        Me.grpCircular.Controls.Add(Me.cmdCircularHelp)
        Me.grpCircular.Controls.Add(Me.cmdCircular)
        Me.grpCircular.Controls.Add(Me.cmdCircQuantile)
        Me.grpCircular.Controls.Add(Me.cmdCircMax)
        Me.grpCircular.Controls.Add(Me.cmdA1)
        Me.grpCircular.Controls.Add(Me.cmdAngVar)
        Me.grpCircular.Controls.Add(Me.cmdCircRho)
        Me.grpCircular.Controls.Add(Me.cmdCircQ3)
        Me.grpCircular.Controls.Add(Me.cmdCircQ1)
        Me.grpCircular.Controls.Add(Me.cmdCircMin)
        Me.grpCircular.Controls.Add(Me.cmdAngDev)
        Me.grpCircular.Controls.Add(Me.cmdCircVar)
        Me.grpCircular.Controls.Add(Me.cmdCircSd)
        Me.grpCircular.Controls.Add(Me.cmdCircRange)
        Me.grpCircular.Controls.Add(Me.cmdMedianHL)
        Me.grpCircular.Controls.Add(Me.cmdCircMedian)
        Me.grpCircular.Controls.Add(Me.cmdCircMean)
        Me.grpCircular.Location = New System.Drawing.Point(431, 61)
        Me.grpCircular.Margin = New System.Windows.Forms.Padding(2)
        Me.grpCircular.Name = "grpCircular"
        Me.grpCircular.Padding = New System.Windows.Forms.Padding(2)
        Me.grpCircular.Size = New System.Drawing.Size(242, 168)
        Me.grpCircular.TabIndex = 192
        Me.grpCircular.TabStop = False
        Me.grpCircular.Text = "Circular"
        '
        'cmdCircularHelp
        '
        Me.cmdCircularHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircularHelp.Location = New System.Drawing.Point(165, 142)
        Me.cmdCircularHelp.Name = "cmdCircularHelp"
        Me.cmdCircularHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdCircularHelp.TabIndex = 183
        Me.cmdCircularHelp.Text = "R Help"
        Me.cmdCircularHelp.UseVisualStyleBackColor = True
        '
        'cmdCircular
        '
        Me.cmdCircular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircular.Location = New System.Drawing.Point(2, 18)
        Me.cmdCircular.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircular.Name = "cmdCircular"
        Me.cmdCircular.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircular.TabIndex = 15
        Me.cmdCircular.Text = "circular"
        Me.cmdCircular.UseVisualStyleBackColor = True
        '
        'cmdCircQuantile
        '
        Me.cmdCircQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircQuantile.Location = New System.Drawing.Point(120, 80)
        Me.cmdCircQuantile.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircQuantile.Name = "cmdCircQuantile"
        Me.cmdCircQuantile.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircQuantile.TabIndex = 13
        Me.cmdCircQuantile.Text = "quantile"
        Me.cmdCircQuantile.UseVisualStyleBackColor = True
        '
        'cmdCircMax
        '
        Me.cmdCircMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMax.Location = New System.Drawing.Point(179, 111)
        Me.cmdCircMax.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircMax.Name = "cmdCircMax"
        Me.cmdCircMax.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircMax.TabIndex = 10
        Me.cmdCircMax.Text = "max"
        Me.cmdCircMax.UseVisualStyleBackColor = True
        '
        'cmdA1
        '
        Me.cmdA1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdA1.Location = New System.Drawing.Point(2, 80)
        Me.cmdA1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdA1.Name = "cmdA1"
        Me.cmdA1.Size = New System.Drawing.Size(60, 32)
        Me.cmdA1.TabIndex = 8
        Me.cmdA1.Text = "A1"
        Me.cmdA1.UseVisualStyleBackColor = True
        '
        'cmdAngVar
        '
        Me.cmdAngVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAngVar.Location = New System.Drawing.Point(61, 80)
        Me.cmdAngVar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAngVar.Name = "cmdAngVar"
        Me.cmdAngVar.Size = New System.Drawing.Size(60, 32)
        Me.cmdAngVar.TabIndex = 6
        Me.cmdAngVar.Text = "ang.var"
        Me.cmdAngVar.UseVisualStyleBackColor = True
        '
        'cmdCircRho
        '
        Me.cmdCircRho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircRho.Location = New System.Drawing.Point(179, 80)
        Me.cmdCircRho.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircRho.Name = "cmdCircRho"
        Me.cmdCircRho.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircRho.TabIndex = 14
        Me.cmdCircRho.Text = "rho"
        Me.cmdCircRho.UseVisualStyleBackColor = True
        '
        'cmdCircQ3
        '
        Me.cmdCircQ3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircQ3.Location = New System.Drawing.Point(120, 111)
        Me.cmdCircQ3.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircQ3.Name = "cmdCircQ3"
        Me.cmdCircQ3.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircQ3.TabIndex = 12
        Me.cmdCircQ3.Text = "q3"
        Me.cmdCircQ3.UseVisualStyleBackColor = True
        '
        'cmdCircQ1
        '
        Me.cmdCircQ1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircQ1.Location = New System.Drawing.Point(61, 111)
        Me.cmdCircQ1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircQ1.Name = "cmdCircQ1"
        Me.cmdCircQ1.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircQ1.TabIndex = 11
        Me.cmdCircQ1.Text = "q1"
        Me.cmdCircQ1.UseVisualStyleBackColor = True
        '
        'cmdCircMin
        '
        Me.cmdCircMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMin.Location = New System.Drawing.Point(2, 111)
        Me.cmdCircMin.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircMin.Name = "cmdCircMin"
        Me.cmdCircMin.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircMin.TabIndex = 9
        Me.cmdCircMin.Text = "min"
        Me.cmdCircMin.UseVisualStyleBackColor = True
        '
        'cmdAngDev
        '
        Me.cmdAngDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAngDev.Location = New System.Drawing.Point(120, 49)
        Me.cmdAngDev.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAngDev.Name = "cmdAngDev"
        Me.cmdAngDev.Size = New System.Drawing.Size(60, 32)
        Me.cmdAngDev.TabIndex = 7
        Me.cmdAngDev.Text = "ang.dev"
        Me.cmdAngDev.UseVisualStyleBackColor = True
        '
        'cmdCircVar
        '
        Me.cmdCircVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircVar.Location = New System.Drawing.Point(179, 49)
        Me.cmdCircVar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircVar.Name = "cmdCircVar"
        Me.cmdCircVar.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircVar.TabIndex = 5
        Me.cmdCircVar.Text = "var"
        Me.cmdCircVar.UseVisualStyleBackColor = True
        '
        'cmdCircSd
        '
        Me.cmdCircSd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircSd.Location = New System.Drawing.Point(61, 49)
        Me.cmdCircSd.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircSd.Name = "cmdCircSd"
        Me.cmdCircSd.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircSd.TabIndex = 4
        Me.cmdCircSd.Text = "sd"
        Me.cmdCircSd.UseVisualStyleBackColor = True
        '
        'cmdCircRange
        '
        Me.cmdCircRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircRange.Location = New System.Drawing.Point(2, 49)
        Me.cmdCircRange.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircRange.Name = "cmdCircRange"
        Me.cmdCircRange.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircRange.TabIndex = 3
        Me.cmdCircRange.Text = "range"
        Me.cmdCircRange.UseVisualStyleBackColor = True
        '
        'cmdMedianHL
        '
        Me.cmdMedianHL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMedianHL.Location = New System.Drawing.Point(179, 18)
        Me.cmdMedianHL.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdMedianHL.Name = "cmdMedianHL"
        Me.cmdMedianHL.Size = New System.Drawing.Size(60, 32)
        Me.cmdMedianHL.TabIndex = 2
        Me.cmdMedianHL.Text = "medianHL"
        Me.cmdMedianHL.UseVisualStyleBackColor = True
        '
        'cmdCircMedian
        '
        Me.cmdCircMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMedian.Location = New System.Drawing.Point(120, 18)
        Me.cmdCircMedian.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircMedian.Name = "cmdCircMedian"
        Me.cmdCircMedian.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircMedian.TabIndex = 1
        Me.cmdCircMedian.Text = "median"
        Me.cmdCircMedian.UseVisualStyleBackColor = True
        '
        'cmdCircMean
        '
        Me.cmdCircMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMean.Location = New System.Drawing.Point(61, 18)
        Me.cmdCircMean.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCircMean.Name = "cmdCircMean"
        Me.cmdCircMean.Size = New System.Drawing.Size(60, 32)
        Me.cmdCircMean.TabIndex = 0
        Me.cmdCircMean.Text = "mean"
        Me.cmdCircMean.UseVisualStyleBackColor = True
        '
        'grpModifier
        '
        Me.grpModifier.Controls.Add(Me.cmdRegex)
        Me.grpModifier.Controls.Add(Me.cmdFixed)
        Me.grpModifier.Controls.Add(Me.cmdCollate)
        Me.grpModifier.Controls.Add(Me.cmdBoundary)
        Me.grpModifier.Location = New System.Drawing.Point(434, 229)
        Me.grpModifier.Margin = New System.Windows.Forms.Padding(2)
        Me.grpModifier.Name = "grpModifier"
        Me.grpModifier.Padding = New System.Windows.Forms.Padding(2)
        Me.grpModifier.Size = New System.Drawing.Size(256, 53)
        Me.grpModifier.TabIndex = 192
        Me.grpModifier.TabStop = False
        Me.grpModifier.Text = "Modifier"
        '
        'cmdRegex
        '
        Me.cmdRegex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRegex.Location = New System.Drawing.Point(188, 13)
        Me.cmdRegex.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdRegex.Name = "cmdRegex"
        Me.cmdRegex.Size = New System.Drawing.Size(63, 30)
        Me.cmdRegex.TabIndex = 3
        Me.cmdRegex.Text = "regex"
        Me.cmdRegex.UseVisualStyleBackColor = True
        '
        'cmdFixed
        '
        Me.cmdFixed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFixed.Location = New System.Drawing.Point(126, 13)
        Me.cmdFixed.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdFixed.Name = "cmdFixed"
        Me.cmdFixed.Size = New System.Drawing.Size(63, 30)
        Me.cmdFixed.TabIndex = 2
        Me.cmdFixed.Text = "fixed"
        Me.cmdFixed.UseVisualStyleBackColor = True
        '
        'cmdCollate
        '
        Me.cmdCollate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCollate.Location = New System.Drawing.Point(64, 13)
        Me.cmdCollate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCollate.Name = "cmdCollate"
        Me.cmdCollate.Size = New System.Drawing.Size(63, 30)
        Me.cmdCollate.TabIndex = 1
        Me.cmdCollate.Text = "collate"
        Me.cmdCollate.UseVisualStyleBackColor = True
        '
        'cmdBoundary
        '
        Me.cmdBoundary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBoundary.Location = New System.Drawing.Point(2, 13)
        Me.cmdBoundary.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdBoundary.Name = "cmdBoundary"
        Me.cmdBoundary.Size = New System.Drawing.Size(63, 30)
        Me.cmdBoundary.TabIndex = 0
        Me.cmdBoundary.Text = "boundary"
        Me.cmdBoundary.UseVisualStyleBackColor = True
        '
        'grpSymbols
        '
        Me.grpSymbols.Controls.Add(Me.cmdOr3)
        Me.grpSymbols.Controls.Add(Me.cmdEscape)
        Me.grpSymbols.Controls.Add(Me.cmdPlusZero)
        Me.grpSymbols.Controls.Add(Me.cmdZero)
        Me.grpSymbols.Controls.Add(Me.cmdPlusOne)
        Me.grpSymbols.Controls.Add(Me.cmdZeroOrOne)
        Me.grpSymbols.Controls.Add(Me.cmdNumbers)
        Me.grpSymbols.Controls.Add(Me.cmdNot1)
        Me.grpSymbols.Controls.Add(Me.cmdOr2)
        Me.grpSymbols.Controls.Add(Me.cmdOr1)
        Me.grpSymbols.Controls.Add(Me.cmdSpace)
        Me.grpSymbols.Controls.Add(Me.cmdDigit)
        Me.grpSymbols.Controls.Add(Me.cmdEnd1)
        Me.grpSymbols.Controls.Add(Me.cmdbegin)
        Me.grpSymbols.Controls.Add(Me.cmdAny1)
        Me.grpSymbols.Location = New System.Drawing.Point(433, 284)
        Me.grpSymbols.Margin = New System.Windows.Forms.Padding(2)
        Me.grpSymbols.Name = "grpSymbols"
        Me.grpSymbols.Padding = New System.Windows.Forms.Padding(2)
        Me.grpSymbols.Size = New System.Drawing.Size(316, 112)
        Me.grpSymbols.TabIndex = 193
        Me.grpSymbols.TabStop = False
        Me.grpSymbols.Text = "Symbols"
        '
        'cmdOr3
        '
        Me.cmdOr3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr3.Location = New System.Drawing.Point(127, 46)
        Me.cmdOr3.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOr3.Name = "cmdOr3"
        Me.cmdOr3.Size = New System.Drawing.Size(63, 30)
        Me.cmdOr3.TabIndex = 16
        Me.cmdOr3.Text = "| or"
        Me.cmdOr3.UseVisualStyleBackColor = True
        '
        'cmdEscape
        '
        Me.cmdEscape.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEscape.Location = New System.Drawing.Point(189, 75)
        Me.cmdEscape.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEscape.Name = "cmdEscape"
        Me.cmdEscape.Size = New System.Drawing.Size(63, 30)
        Me.cmdEscape.TabIndex = 14
        Me.cmdEscape.Text = "\\ escape"
        Me.cmdEscape.UseVisualStyleBackColor = True
        '
        'cmdPlusZero
        '
        Me.cmdPlusZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlusZero.Location = New System.Drawing.Point(251, 75)
        Me.cmdPlusZero.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPlusZero.Name = "cmdPlusZero"
        Me.cmdPlusZero.Size = New System.Drawing.Size(63, 30)
        Me.cmdPlusZero.TabIndex = 15
        Me.cmdPlusZero.Text = "- to"
        Me.cmdPlusZero.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZero.Location = New System.Drawing.Point(127, 75)
        Me.cmdZero.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(63, 30)
        Me.cmdZero.TabIndex = 13
        Me.cmdZero.Text = "* 0+"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdPlusOne
        '
        Me.cmdPlusOne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlusOne.Location = New System.Drawing.Point(64, 75)
        Me.cmdPlusOne.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdPlusOne.Name = "cmdPlusOne"
        Me.cmdPlusOne.Size = New System.Drawing.Size(63, 30)
        Me.cmdPlusOne.TabIndex = 12
        Me.cmdPlusOne.Text = "+ 1+"
        Me.cmdPlusOne.UseVisualStyleBackColor = True
        '
        'cmdZeroOrOne
        '
        Me.cmdZeroOrOne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZeroOrOne.Location = New System.Drawing.Point(2, 75)
        Me.cmdZeroOrOne.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdZeroOrOne.Name = "cmdZeroOrOne"
        Me.cmdZeroOrOne.Size = New System.Drawing.Size(63, 30)
        Me.cmdZeroOrOne.TabIndex = 11
        Me.cmdZeroOrOne.Text = "? 0 or 1"
        Me.cmdZeroOrOne.UseVisualStyleBackColor = True
        '
        'cmdNumbers
        '
        Me.cmdNumbers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNumbers.Location = New System.Drawing.Point(251, 46)
        Me.cmdNumbers.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNumbers.Name = "cmdNumbers"
        Me.cmdNumbers.Size = New System.Drawing.Size(63, 30)
        Me.cmdNumbers.TabIndex = 10
        Me.cmdNumbers.Text = "{ m,n } "
        Me.cmdNumbers.UseVisualStyleBackColor = True
        '
        'cmdNot1
        '
        Me.cmdNot1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNot1.Location = New System.Drawing.Point(64, 46)
        Me.cmdNot1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdNot1.Name = "cmdNot1"
        Me.cmdNot1.Size = New System.Drawing.Size(63, 30)
        Me.cmdNot1.TabIndex = 8
        Me.cmdNot1.Text = "[^ ] not"
        Me.cmdNot1.UseVisualStyleBackColor = True
        '
        'cmdOr2
        '
        Me.cmdOr2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr2.Location = New System.Drawing.Point(189, 46)
        Me.cmdOr2.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOr2.Name = "cmdOr2"
        Me.cmdOr2.Size = New System.Drawing.Size(63, 30)
        Me.cmdOr2.TabIndex = 9
        Me.cmdOr2.Text = "{ n} "
        Me.cmdOr2.UseVisualStyleBackColor = True
        '
        'cmdOr1
        '
        Me.cmdOr1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr1.Location = New System.Drawing.Point(2, 46)
        Me.cmdOr1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdOr1.Name = "cmdOr1"
        Me.cmdOr1.Size = New System.Drawing.Size(63, 30)
        Me.cmdOr1.TabIndex = 7
        Me.cmdOr1.Text = "[ ] or"
        Me.cmdOr1.UseVisualStyleBackColor = True
        '
        'cmdSpace
        '
        Me.cmdSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSpace.Location = New System.Drawing.Point(251, 16)
        Me.cmdSpace.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSpace.Name = "cmdSpace"
        Me.cmdSpace.Size = New System.Drawing.Size(63, 30)
        Me.cmdSpace.TabIndex = 6
        Me.cmdSpace.Text = "\\s space"
        Me.cmdSpace.UseVisualStyleBackColor = True
        '
        'cmdDigit
        '
        Me.cmdDigit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit.Location = New System.Drawing.Point(189, 16)
        Me.cmdDigit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDigit.Name = "cmdDigit"
        Me.cmdDigit.Size = New System.Drawing.Size(63, 30)
        Me.cmdDigit.TabIndex = 5
        Me.cmdDigit.Text = "\\d digit"
        Me.cmdDigit.UseVisualStyleBackColor = True
        '
        'cmdEnd1
        '
        Me.cmdEnd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnd1.Location = New System.Drawing.Point(127, 16)
        Me.cmdEnd1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEnd1.Name = "cmdEnd1"
        Me.cmdEnd1.Size = New System.Drawing.Size(63, 30)
        Me.cmdEnd1.TabIndex = 4
        Me.cmdEnd1.Text = "$ end"
        Me.cmdEnd1.UseVisualStyleBackColor = True
        '
        'cmdbegin
        '
        Me.cmdbegin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdbegin.Location = New System.Drawing.Point(64, 16)
        Me.cmdbegin.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdbegin.Name = "cmdbegin"
        Me.cmdbegin.Size = New System.Drawing.Size(63, 30)
        Me.cmdbegin.TabIndex = 3
        Me.cmdbegin.Text = "^ begin"
        Me.cmdbegin.UseVisualStyleBackColor = True
        '
        'cmdAny1
        '
        Me.cmdAny1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAny1.Location = New System.Drawing.Point(2, 16)
        Me.cmdAny1.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAny1.Name = "cmdAny1"
        Me.cmdAny1.Size = New System.Drawing.Size(63, 30)
        Me.cmdAny1.TabIndex = 2
        Me.cmdAny1.Text = ". any"
        Me.cmdAny1.UseVisualStyleBackColor = True
        '
        'cmdStringRHelp
        '
        Me.cmdStringRHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStringRHelp.Location = New System.Drawing.Point(656, 41)
        Me.cmdStringRHelp.Name = "cmdStringRHelp"
        Me.cmdStringRHelp.Size = New System.Drawing.Size(75, 23)
        Me.cmdStringRHelp.TabIndex = 197
        Me.cmdStringRHelp.Text = "R Help"
        Me.cmdStringRHelp.UseVisualStyleBackColor = True
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(11, 311)
        Me.ucrSaveResultInto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(327, 22)
        Me.ucrSaveResultInto.TabIndex = 196
        '
        'ucrTryCalculator
        '
        Me.ucrTryCalculator.AutoSize = True
        Me.ucrTryCalculator.Location = New System.Drawing.Point(1, 256)
        Me.ucrTryCalculator.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTryCalculator.Name = "ucrTryCalculator"
        Me.ucrTryCalculator.RunCommandAsMultipleLines = False
        Me.ucrTryCalculator.Size = New System.Drawing.Size(396, 33)
        Me.ucrTryCalculator.TabIndex = 194
        '
        'ucrInputCalOptions
        '
        Me.ucrInputCalOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputCalOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCalOptions.GetSetSelectedIndex = -1
        Me.ucrInputCalOptions.IsReadOnly = False
        Me.ucrInputCalOptions.Location = New System.Drawing.Point(226, 41)
        Me.ucrInputCalOptions.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrInputCalOptions.Name = "ucrInputCalOptions"
        Me.ucrInputCalOptions.Size = New System.Drawing.Size(137, 22)
        Me.ucrInputCalOptions.TabIndex = 180
        '
        'ucrSelectorForCalculations
        '
        Me.ucrSelectorForCalculations.AutoSize = True
        Me.ucrSelectorForCalculations.bDropUnusedFilterLevels = False
        Me.ucrSelectorForCalculations.bShowHiddenColumns = False
        Me.ucrSelectorForCalculations.bUseCurrentFilter = True
        Me.ucrSelectorForCalculations.Location = New System.Drawing.Point(0, 64)
        Me.ucrSelectorForCalculations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCalculations.Name = "ucrSelectorForCalculations"
        Me.ucrSelectorForCalculations.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorForCalculations.TabIndex = 173
        '
        'ucrReceiverForCalculation
        '
        Me.ucrReceiverForCalculation.AutoSize = True
        Me.ucrReceiverForCalculation.frmParent = Nothing
        Me.ucrReceiverForCalculation.Location = New System.Drawing.Point(70, 6)
        Me.ucrReceiverForCalculation.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ucrReceiverForCalculation.Name = "ucrReceiverForCalculation"
        Me.ucrReceiverForCalculation.Selector = Nothing
        Me.ucrReceiverForCalculation.Size = New System.Drawing.Size(391, 29)
        Me.ucrReceiverForCalculation.strNcFilePath = ""
        Me.ucrReceiverForCalculation.TabIndex = 120
        Me.ucrReceiverForCalculation.ucrSelector = Nothing
        '
        'ucrCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.grpHydroGOF)
        Me.Controls.Add(Me.grpFactor)
        Me.Controls.Add(Me.grpCircular)
        Me.Controls.Add(Me.grpWakefield)
        Me.Controls.Add(Me.grpMaths)
        Me.Controls.Add(Me.grpLogical)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpTransform)
        Me.Controls.Add(Me.grpProbabilty)
        Me.Controls.Add(Me.cmdWakefieldHelp)
        Me.Controls.Add(Me.cmdStringRHelp)
        Me.Controls.Add(Me.ucrSaveResultInto)
        Me.Controls.Add(Me.ucrTryCalculator)
        Me.Controls.Add(Me.grpTestString)
        Me.Controls.Add(Me.grpSymbols)
        Me.Controls.Add(Me.grpModifier)
        Me.Controls.Add(Me.chkShowParameters)
        Me.Controls.Add(Me.ucrInputCalOptions)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.ucrSelectorForCalculations)
        Me.Controls.Add(Me.ucrReceiverForCalculation)
        Me.Controls.Add(Me.lblExpression)
        Me.Name = "ucrCalculator"
        Me.Size = New System.Drawing.Size(878, 457)
        Me.grpBasic.ResumeLayout(False)
        Me.grpDates.ResumeLayout(False)
        Me.grpFactor.ResumeLayout(False)
        Me.grpHydroGOF.ResumeLayout(False)
        Me.grpWakefield.ResumeLayout(False)
        Me.grpMaths.ResumeLayout(False)
        Me.grpSummary.ResumeLayout(False)
        Me.grpTransform.ResumeLayout(False)
        Me.grpProbabilty.ResumeLayout(False)
        Me.grpLogical.ResumeLayout(False)
        Me.grpTestString.ResumeLayout(False)
        Me.grpCircular.ResumeLayout(False)
        Me.grpModifier.ResumeLayout(False)
        Me.grpSymbols.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverForCalculation As ucrReceiverExpression
    Friend WithEvents lblExpression As Label
    Friend WithEvents ucrSelectorForCalculations As ucrSelectorByDataFrameAddRemove
    Friend WithEvents cmdRHelp As Button
    Friend WithEvents chkShowParameters As CheckBox
    Friend WithEvents ucrInputCalOptions As ucrInputComboBox
    Friend WithEvents grpBasic As GroupBox
    Friend WithEvents cmdBrackets As Button
    Friend WithEvents cmdPower As Button
    Friend WithEvents cmdDivide As Button
    Friend WithEvents cmdPlus As Button
    Friend WithEvents cmdMinus As Button
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
    Friend WithEvents cmdDay As Button
    Friend WithEvents cmdMonth As Button
    Friend WithEvents cmdYear As Button
    Friend WithEvents cmdDate As Button
    Friend WithEvents cmdYday As Button
    Friend WithEvents cmdWday As Button
    Friend WithEvents cmdMdy As Button
    Friend WithEvents cmdYmd As Button
    Friend WithEvents cmdLeap As Button
    Friend WithEvents grpTransform As GroupBox
    Friend WithEvents cmdcumsum As Button
    Friend WithEvents cmdcummin As Button
    Friend WithEvents cmdcummax As Button
    Friend WithEvents cmdPMin As Button
    Friend WithEvents cmdpmax As Button
    Friend WithEvents cmdLead As Button
    Friend WithEvents cmdLag As Button
    Friend WithEvents grpTestString As GroupBox
    Friend WithEvents cmdSub As Button
    Friend WithEvents cmdCombine As Button
    Friend WithEvents cmdDetect As Button
    Friend WithEvents cmdTrim As Button
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
    Friend WithEvents grpSummary As GroupBox
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
    Friend WithEvents cmdLength As Button
    Friend WithEvents cmdComma As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdpercentrank As Button
    Friend WithEvents cmdDiff As Button
    Friend WithEvents cmdCumdist As Button
    Friend WithEvents cmdmovemean As Button
    Friend WithEvents cmdCumMean As Button
    Friend WithEvents cmdNtile As Button
    Friend WithEvents cmMovMed As Button
    Friend WithEvents cmdMRank As Button
    Friend WithEvents cmdDRank As Button
    Friend WithEvents cmdMovMax As Button
    Friend WithEvents cmdMovSum As Button
    Friend WithEvents cmdIsNa As Button
    Friend WithEvents cmdNotIsNa As Button
    Friend WithEvents cmdDuplicate As Button
    Friend WithEvents cmdIfelse As Button
    Friend WithEvents cmdmatch As Button
    Friend WithEvents cmdwhen As Button
    Friend WithEvents cmdNear As Button
    Friend WithEvents cmdBetween As Button
    Friend WithEvents cmdRowRank As Button
    Friend WithEvents cmdNonMiss As Button
    Friend WithEvents cmdDistinct As Button
    Friend WithEvents cmdMad As Button
    Friend WithEvents cmdMc As Button
    Friend WithEvents cmdPropn As Button
    Friend WithEvents cmdCv As Button
    Friend WithEvents cmdSkew As Button
    Friend WithEvents cmdAnyDup As Button
    Friend WithEvents cmdCor As Button
    Friend WithEvents cmdCov As Button
    Friend WithEvents cmdFirst As Button
    Friend WithEvents cmdLast As Button
    Friend WithEvents cmdnth As Button
    Friend WithEvents cmdMode As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents cmdNA As Button
    Friend WithEvents cmdIn As Button
    Friend WithEvents cmdWhich As Button
    Friend WithEvents cmdDoubleSqrBrackets As Button
    Friend WithEvents cmdFalse As Button
    Friend WithEvents cmdTrue As Button
    Friend WithEvents ttCalculator As ToolTip
    Friend WithEvents cmdWakefield_Year As Button
    Friend WithEvents cmdValid As Button
    Friend WithEvents cmdWakefield_Upper As Button
    Friend WithEvents cmdString As Button
    Friend WithEvents cmdState As Button
    Friend WithEvents cmdSpeed As Button
    Friend WithEvents cmdSmokes As Button
    Friend WithEvents cmdSex As Button
    Friend WithEvents cmdSex_Inclusive As Button
    Friend WithEvents cmdGender As Button
    Friend WithEvents cmdSentence As Button
    Friend WithEvents cmdSat As Button
    Friend WithEvents cmdReligion As Button
    Friend WithEvents cmdRace As Button
    Friend WithEvents cmdPolitical As Button
    Friend WithEvents cmdNormal As Button
    Friend WithEvents cmdName As Button
    Friend WithEvents cmdWakefield_Month As Button
    Friend WithEvents cmdMilitary As Button
    Friend WithEvents cmdMarital As Button
    Friend WithEvents cmdLorem_ipsum As Button
    Friend WithEvents cmdGpa As Button
    Friend WithEvents cmdEla As Button
    Friend WithEvents cmdMath As Button
    Friend WithEvents cmdLevel As Button
    Friend WithEvents cmdLanguage As Button
    Friend WithEvents cmdIq As Button
    Friend WithEvents cmdInternet_Browser As Button
    Friend WithEvents cmdGrade_Level As Button
    Friend WithEvents cmdEye As Button
    Friend WithEvents cmdEmployment As Button
    Friend WithEvents cmdEducation As Button
    Friend WithEvents cmdDummy As Button
    Friend WithEvents cmdDob As Button
    Friend WithEvents cmdDna As Button
    Friend WithEvents cmdDice As Button
    Friend WithEvents cmdDied As Button
    Friend WithEvents cmdDeath As Button
    Friend WithEvents cmdDate_Stamp As Button
    Friend WithEvents cmdPrimary As Button
    Friend WithEvents cmdColor As Button
    Friend WithEvents cmdCoin As Button
    Friend WithEvents cmdChildren As Button
    Friend WithEvents cmdHeight As Button
    Friend WithEvents grpWakefield As GroupBox
    Friend WithEvents cmdLikert As Button
    Friend WithEvents cmdCar As Button
    Friend WithEvents cmdAnswer As Button
    Friend WithEvents cmdPet As Button
    Friend WithEvents cmdAnimal As Button
    Friend WithEvents cmdAge As Button
    Friend WithEvents cmdIncome As Button
    Friend WithEvents cmdHair As Button
    Friend WithEvents cmdGroup As Button
    Friend WithEvents cmdGrade As Button
    Friend WithEvents cmdLogistic As Button
    Friend WithEvents cmdLogit As Button
    Friend WithEvents cmdAtan2 As Button
    Friend WithEvents cmdQuarter As Button
    Friend WithEvents cmdD_In_M As Button
    Friend WithEvents cmdAm As Button
    Friend WithEvents cmdSec As Button
    Friend WithEvents cmdHour As Button
    Friend WithEvents cmdminutes As Button
    Friend WithEvents grpCircular As GroupBox
    Friend WithEvents cmdCircMedian As Button
    Friend WithEvents cmdCircMean As Button
    Friend WithEvents cmdCircQ3 As Button
    Friend WithEvents cmdCircQ1 As Button
    Friend WithEvents cmdCircMax As Button
    Friend WithEvents cmdCircMin As Button
    Friend WithEvents cmdA1 As Button
    Friend WithEvents cmdAngDev As Button
    Friend WithEvents cmdAngVar As Button
    Friend WithEvents cmdCircVar As Button
    Friend WithEvents cmdCircSd As Button
    Friend WithEvents cmdCircRange As Button
    Friend WithEvents cmdMedianHL As Button
    Friend WithEvents cmdCircRho As Button
    Friend WithEvents cmdCircQuantile As Button
    Friend WithEvents cmdCircular As Button

    Friend WithEvents cmdMovmin As Button
    Friend WithEvents cmdNasplin As Button
    Friend WithEvents cmdNaapprox As Button
    Friend WithEvents cmdNaest As Button
    Friend WithEvents cmdNafill As Button

    Friend WithEvents grpFactor As GroupBox
    Friend WithEvents cmdShuffle As Button
    Friend WithEvents cmdShift As Button
    Friend WithEvents cmdReverse As Button
    Friend WithEvents cmdReorder As Button
    Friend WithEvents cmdRelevel As Button
    Friend WithEvents cmdRecode As Button
    Friend WithEvents cmdOther As Button
    Friend WithEvents cmdFmatch As Button
    Friend WithEvents cmdLump As Button
    Friend WithEvents cmdInseq As Button
    Friend WithEvents cmdInfreq As Button
    Friend WithEvents cmdInorder As Button
    Friend WithEvents cmdAdd_na As Button
    Friend WithEvents cmdExpand As Button
    Friend WithEvents cmdDrop As Button
    Friend WithEvents cmdCross As Button
    Friend WithEvents cmdCollapse As Button
    Friend WithEvents cmdLabelled As Button
    Friend WithEvents cmdFactor As Button
    Friend WithEvents cmdAnon As Button
    Friend WithEvents cmdPgamma As Button
    Friend WithEvents cmdQgamma As Button
    Friend WithEvents cmdPnbin As Button
    Friend WithEvents cmdPpois As Button
    Friend WithEvents cmdPbinom As Button
    Friend WithEvents cmdPbirth As Button
    Friend WithEvents cmdPbeta As Button
    Friend WithEvents cmdQnbin As Button
    Friend WithEvents cmdQpois As Button
    Friend WithEvents cmdQbinom As Button
    Friend WithEvents cmdQbirth As Button
    Friend WithEvents cmdQbeta As Button
    Friend WithEvents cmdLinkert7 As Button
    Friend WithEvents cmdEncodeb As Button
    Friend WithEvents cmdSquishb As Button
    Friend WithEvents cmdExtract2 As Button
    Friend WithEvents cmdLocate2 As Button
    Friend WithEvents cmdRemove2 As Button
    Friend WithEvents cmdRemove1 As Button
    Friend WithEvents cmdStarts As Button
    Friend WithEvents cmdReplace2 As Button
    Friend WithEvents cmdReplace As Button
    Friend WithEvents grpModifier As GroupBox
    Friend WithEvents grpSymbols As GroupBox
    Friend WithEvents cmdRegex As Button
    Friend WithEvents cmdFixed As Button
    Friend WithEvents cmdCollate As Button
    Friend WithEvents cmdBoundary As Button
    Friend WithEvents cmdOr2 As Button
    Friend WithEvents cmdNot1 As Button
    Friend WithEvents cmdOr1 As Button
    Friend WithEvents cmdSpace As Button
    Friend WithEvents cmdDigit As Button
    Friend WithEvents cmdEnd1 As Button
    Friend WithEvents cmdbegin As Button
    Friend WithEvents cmdAny1 As Button
    Friend WithEvents cmdPlusZero As Button
    Friend WithEvents cmdEscape As Button
    Friend WithEvents cmdZero As Button
    Friend WithEvents cmdPlusOne As Button
    Friend WithEvents cmdZeroOrOne As Button
    Friend WithEvents cmdNumbers As Button
    Friend WithEvents cmdOr3 As Button
    Friend WithEvents cmdMode1 As Button
    Friend WithEvents cmdKurtosis As Button
    Friend WithEvents ucrTryCalculator As ucrTry
    Friend WithEvents grpHydroGOF As GroupBox
    Friend WithEvents cmdD As Button
    Friend WithEvents cmdCp As Button
    Friend WithEvents cmdBr2 As Button
    Friend WithEvents cmdMd As Button
    Friend WithEvents cmdMae As Button
    Friend WithEvents cmdKGE As Button
    Friend WithEvents cmdMse As Button
    Friend WithEvents cmdmNSE As Button
    Friend WithEvents cmdMe As Button
    Friend WithEvents cmdPbias As Button
    Friend WithEvents cmdNSE As Button
    Friend WithEvents cmdNrmse As Button
    Friend WithEvents cmdRmse As Button
    Friend WithEvents cmdRd As Button
    Friend WithEvents cmdPbiasfde As Button
    Friend WithEvents cmdRSD As Button
    Friend WithEvents cmdRPearson As Button
    Friend WithEvents cmdRNSE As Button
    Friend WithEvents cmdVE As Button
    Friend WithEvents cmdSsq As Button
    Friend WithEvents cmdRsr As Button
    Friend WithEvents ucrSaveResultInto As ucrSave
    Friend WithEvents cmdTime As Button
    Friend WithEvents cmdDateTime As Button
    Friend WithEvents cmdPm As Button
    Friend WithEvents cmdLenth As Button
    Friend WithEvents cmdGlue As Button
    Friend WithEvents cmdTrunck As Button
    Friend WithEvents cmdEnds As Button
    Friend WithEvents cmdSortF As Button
    Friend WithEvents cmdHydroHelp As Button
    Friend WithEvents cmdTransformHelp As Button
    Friend WithEvents cmdCircularHelp As Button
    Friend WithEvents cmdWakefieldHelp As Button
    Friend WithEvents cmdMathsHelp As Button
    Friend WithEvents cmdLogicalHelp As Button
    Friend WithEvents cmdSummaryHelp As Button
    Friend WithEvents cmdHelpZoo As Button
    Friend WithEvents cmdHelpDplyr As Button
    Friend WithEvents cmdStringRHelp As Button
    Friend WithEvents cmdProbRHelp As Button
End Class
