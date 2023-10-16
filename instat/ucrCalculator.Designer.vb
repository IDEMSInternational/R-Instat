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
        Me.cmdRHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripDate = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DateLubridateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateHmsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ContextMenuStripComplex = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ComplexBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpInteger = New System.Windows.Forms.GroupBox()
        Me.cmdPrimorial = New System.Windows.Forms.Button()
        Me.cmdFactorize2 = New System.Windows.Forms.Button()
        Me.cmdLucas = New System.Windows.Forms.Button()
        Me.cmdFactorize = New System.Windows.Forms.Button()
        Me.cmdSquare = New System.Windows.Forms.Button()
        Me.cmdTriangle = New System.Windows.Forms.Button()
        Me.cmdPadovan = New System.Windows.Forms.Button()
        Me.cmdAchilles = New System.Windows.Forms.Button()
        Me.cmdHappy = New System.Windows.Forms.Button()
        Me.cmdUgly = New System.Windows.Forms.Button()
        Me.cmdPowerful = New System.Windows.Forms.Button()
        Me.cmdFrugal = New System.Windows.Forms.Button()
        Me.cmdPerfect = New System.Windows.Forms.Button()
        Me.cmdAbundant = New System.Windows.Forms.Button()
        Me.cmdFibonacci2 = New System.Windows.Forms.Button()
        Me.cmdPalindrome = New System.Windows.Forms.Button()
        Me.cmdRoman = New System.Windows.Forms.Button()
        Me.cmdHexmode = New System.Windows.Forms.Button()
        Me.cmdOctmode = New System.Windows.Forms.Button()
        Me.cmdKTuple = New System.Windows.Forms.Button()
        Me.cmdTriplets = New System.Windows.Forms.Button()
        Me.cmdThird = New System.Windows.Forms.Button()
        Me.cmdSexy = New System.Windows.Forms.Button()
        Me.cmdCousin = New System.Windows.Forms.Button()
        Me.cmdTwin = New System.Windows.Forms.Button()
        Me.cmdPhi = New System.Windows.Forms.Button()
        Me.cmdCoprime = New System.Windows.Forms.Button()
        Me.cmdSCM = New System.Windows.Forms.Button()
        Me.cmdGCD = New System.Windows.Forms.Button()
        Me.cmdGeneratePrimes = New System.Windows.Forms.Button()
        Me.cmdNthPrime = New System.Windows.Forms.Button()
        Me.cmdIntegerRHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripInteger = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GmpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RutilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrimesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZseqToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfdesignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdHex = New System.Windows.Forms.Button()
        Me.cmdOctal = New System.Windows.Forms.Button()
        Me.cmdBinary = New System.Windows.Forms.Button()
        Me.cmdBigQ = New System.Windows.Forms.Button()
        Me.cmdDigitSum = New System.Windows.Forms.Button()
        Me.cmdRankPercent = New System.Windows.Forms.Button()
        Me.cmdDivisors = New System.Windows.Forms.Button()
        Me.cmdFibonacci = New System.Windows.Forms.Button()
        Me.cmdNextPrime = New System.Windows.Forms.Button()
        Me.cmdChoosez = New System.Windows.Forms.Button()
        Me.cmdFactorial = New System.Windows.Forms.Button()
        Me.cmdIsPrime = New System.Windows.Forms.Button()
        Me.cmdBigZ = New System.Windows.Forms.Button()
        Me.grpFactor = New System.Windows.Forms.GroupBox()
        Me.cmdTransformHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripFactor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FactorForcatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cmdHydroHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripHydroGOF = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HydroGOFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grpMaths = New System.Windows.Forms.GroupBox()
        Me.cmdMathsHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripMaths = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MathsStatsStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cmdSummaryRHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripSummary = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BaseToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.E1071ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RobustbaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpFrequencies = New System.Windows.Forms.GroupBox()
        Me.cmdFreqQuantile = New System.Windows.Forms.Button()
        Me.cmdFreqPropn = New System.Windows.Forms.Button()
        Me.cmdFreqDistinct = New System.Windows.Forms.Button()
        Me.cmdFreqIQR = New System.Windows.Forms.Button()
        Me.cmdFreqMedian = New System.Windows.Forms.Button()
        Me.cmdFreqSd = New System.Windows.Forms.Button()
        Me.cmdFreqVar = New System.Windows.Forms.Button()
        Me.cmdFreqMean = New System.Windows.Forms.Button()
        Me.cmdFreqMad = New System.Windows.Forms.Button()
        Me.cmdFreqMiss = New System.Windows.Forms.Button()
        Me.cmdFreqMode1 = New System.Windows.Forms.Button()
        Me.cmdFreqMax = New System.Windows.Forms.Button()
        Me.cmdFreqMin = New System.Windows.Forms.Button()
        Me.cmdFreqSum = New System.Windows.Forms.Button()
        Me.cmdFreqLength = New System.Windows.Forms.Button()
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
        Me.grpProbabilty = New System.Windows.Forms.GroupBox()
        Me.cmdPascal = New System.Windows.Forms.Button()
        Me.cmdProbRHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripProbability = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProbStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProbBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpRandom = New System.Windows.Forms.GroupBox()
        Me.cmdnbinomial = New System.Windows.Forms.Button()
        Me.cmdRan_sample = New System.Windows.Forms.Button()
        Me.cmdRan_beta = New System.Windows.Forms.Button()
        Me.cmdRan_gamma = New System.Windows.Forms.Button()
        Me.cmdpoisson = New System.Windows.Forms.Button()
        Me.cmdbinomial = New System.Windows.Forms.Button()
        Me.cmdbernoulli = New System.Windows.Forms.Button()
        Me.cmduni_integer = New System.Windows.Forms.Button()
        Me.cmdRan_normal = New System.Windows.Forms.Button()
        Me.cmduniform = New System.Windows.Forms.Button()
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
        Me.grpTransform = New System.Windows.Forms.GroupBox()
        Me.cmdDecimals = New System.Windows.Forms.Button()
        Me.cmdMASSFractions = New System.Windows.Forms.Button()
        Me.cmdScale = New System.Windows.Forms.Button()
        Me.cmdTransformRHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripTransform = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DplyrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZooToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRev = New System.Windows.Forms.Button()
        Me.cmdMovProd = New System.Windows.Forms.Button()
        Me.cmdCumProd = New System.Windows.Forms.Button()
        Me.cmdSortF = New System.Windows.Forms.Button()
        Me.cmdNasplin = New System.Windows.Forms.Button()
        Me.cmdNaapprox = New System.Windows.Forms.Button()
        Me.cmdNaest = New System.Windows.Forms.Button()
        Me.cmdNafill = New System.Windows.Forms.Button()
        Me.cmdMovmin = New System.Windows.Forms.Button()
        Me.cmdRowRank = New System.Windows.Forms.Button()
        Me.cmdDiff = New System.Windows.Forms.Button()
        Me.cmdCumdist = New System.Windows.Forms.Button()
        Me.cmdMovMean = New System.Windows.Forms.Button()
        Me.cmdCumMean = New System.Windows.Forms.Button()
        Me.cmdNtile = New System.Windows.Forms.Button()
        Me.cmMovMed = New System.Windows.Forms.Button()
        Me.cmdMRank = New System.Windows.Forms.Button()
        Me.cmdDRank = New System.Windows.Forms.Button()
        Me.cmdMovMax = New System.Windows.Forms.Button()
        Me.cmdMovSum = New System.Windows.Forms.Button()
        Me.cmdPercentRank = New System.Windows.Forms.Button()
        Me.cmdCumSum = New System.Windows.Forms.Button()
        Me.cmdCumMin = New System.Windows.Forms.Button()
        Me.cmdCumMax = New System.Windows.Forms.Button()
        Me.cmdPMin = New System.Windows.Forms.Button()
        Me.cmdPMax = New System.Windows.Forms.Button()
        Me.cmdLead = New System.Windows.Forms.Button()
        Me.cmdLag = New System.Windows.Forms.Button()
        Me.grpLogical = New System.Windows.Forms.GroupBox()
        Me.cmdLogicalHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripLogical = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogDplyrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.cmdReverseStr = New System.Windows.Forms.Button()
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
        Me.cmdCircularHelp = New instat.ucrSplitButton()
        Me.ContextMenuStripCircular = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CircularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.grpComplex = New System.Windows.Forms.GroupBox()
        Me.cmdComplexRHelp = New instat.ucrSplitButton()
        Me.cmdComplexTanH = New System.Windows.Forms.Button()
        Me.cmdComplexTan = New System.Windows.Forms.Button()
        Me.cmdComplexPi = New System.Windows.Forms.Button()
        Me.cmdComplexDeg = New System.Windows.Forms.Button()
        Me.cmdComplexRad = New System.Windows.Forms.Button()
        Me.cmdComplexSignif = New System.Windows.Forms.Button()
        Me.cmdComplexCosH = New System.Windows.Forms.Button()
        Me.cmdComplexSinH = New System.Windows.Forms.Button()
        Me.cmdComplexCos = New System.Windows.Forms.Button()
        Me.cmdComplexSin = New System.Windows.Forms.Button()
        Me.cmdComplexExp = New System.Windows.Forms.Button()
        Me.cmdComplexRound = New System.Windows.Forms.Button()
        Me.cmdComplexLog = New System.Windows.Forms.Button()
        Me.cmdComplexSqrt = New System.Windows.Forms.Button()
        Me.cmdConjugate = New System.Windows.Forms.Button()
        Me.cmdArg = New System.Windows.Forms.Button()
        Me.cmdMod = New System.Windows.Forms.Button()
        Me.cmdImaginary = New System.Windows.Forms.Button()
        Me.cmdReal = New System.Windows.Forms.Button()
        Me.cmdAsComplex = New System.Windows.Forms.Button()
        Me.ContextMenuStripTxtString = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TxTStringrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxTBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripWakefield = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.WakefieldToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripList = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListBaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListStatipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpList = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdListDuplicated = New System.Windows.Forms.Button()
        Me.cmdListOperator = New System.Windows.Forms.Button()
        Me.cmdListDiv = New System.Windows.Forms.Button()
        Me.cmdListMod = New System.Windows.Forms.Button()
        Me.cmdListIfelse = New System.Windows.Forms.Button()
        Me.cmdListOmit = New System.Windows.Forms.Button()
        Me.cmdListRev = New System.Windows.Forms.Button()
        Me.cmdListMovsum = New System.Windows.Forms.Button()
        Me.cmdListCumsum = New System.Windows.Forms.Button()
        Me.cmdListScale = New System.Windows.Forms.Button()
        Me.cmdListDiff = New System.Windows.Forms.Button()
        Me.cmdListLead = New System.Windows.Forms.Button()
        Me.cmdListLag = New System.Windows.Forms.Button()
        Me.cmdListRank = New System.Windows.Forms.Button()
        Me.cmdListSort = New System.Windows.Forms.Button()
        Me.grpMathBloc = New System.Windows.Forms.GroupBox()
        Me.cmdListSQRT = New System.Windows.Forms.Button()
        Me.cmdListPercent2 = New System.Windows.Forms.Button()
        Me.cmdListPercent = New System.Windows.Forms.Button()
        Me.cmdListProportion = New System.Windows.Forms.Button()
        Me.cmdListRound = New System.Windows.Forms.Button()
        Me.cmdListSquare = New System.Windows.Forms.Button()
        Me.cmdListDivide = New System.Windows.Forms.Button()
        Me.cmdListMultiply = New System.Windows.Forms.Button()
        Me.cmdListSubtract = New System.Windows.Forms.Button()
        Me.cmdListAdd = New System.Windows.Forms.Button()
        Me.cmdListNth = New System.Windows.Forms.Button()
        Me.cmdListLast = New System.Windows.Forms.Button()
        Me.cmdListFirst = New System.Windows.Forms.Button()
        Me.cmdListAnyDup = New System.Windows.Forms.Button()
        Me.cmdListDistinct = New System.Windows.Forms.Button()
        Me.cmdListIQR = New System.Windows.Forms.Button()
        Me.cmdListMad = New System.Windows.Forms.Button()
        Me.cmdListSd = New System.Windows.Forms.Button()
        Me.cmdListVar = New System.Windows.Forms.Button()
        Me.cmdListSsq = New System.Windows.Forms.Button()
        Me.cmdListMode1 = New System.Windows.Forms.Button()
        Me.cmdListMax = New System.Windows.Forms.Button()
        Me.cmdListFivenum = New System.Windows.Forms.Button()
        Me.cmdListMode = New System.Windows.Forms.Button()
        Me.cmdListQuantile = New System.Windows.Forms.Button()
        Me.cmdListDigitsum = New System.Windows.Forms.Button()
        Me.cmdListMin = New System.Windows.Forms.Button()
        Me.cmdListProd = New System.Windows.Forms.Button()
        Me.cmdListLength = New System.Windows.Forms.Button()
        Me.cmdListMedian = New System.Windows.Forms.Button()
        Me.cmdListMean = New System.Windows.Forms.Button()
        Me.cmdListRange = New System.Windows.Forms.Button()
        Me.cmdListSum = New System.Windows.Forms.Button()
        Me.cmdListSumd = New System.Windows.Forms.Button()
        Me.cmdListMissing = New System.Windows.Forms.Button()
        Me.cmdRhelpList = New instat.ucrSplitButton()
        Me.cmdWakefieldHelp = New instat.ucrSplitButton()
        Me.cmdStringRHelp = New instat.ucrSplitButton()
        Me.ucrSaveResultInto = New instat.ucrSave()
        Me.ucrTryCalculator = New instat.ucrTry()
        Me.ucrInputCalOptions = New instat.ucrInputComboBox()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForCalculation = New instat.ucrReceiverExpression()
        Me.grpBasic.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.ContextMenuStripDate.SuspendLayout()
        Me.ContextMenuStripComplex.SuspendLayout()
        Me.grpInteger.SuspendLayout()
        Me.ContextMenuStripInteger.SuspendLayout()
        Me.grpFactor.SuspendLayout()
        Me.ContextMenuStripFactor.SuspendLayout()
        Me.grpHydroGOF.SuspendLayout()
        Me.ContextMenuStripHydroGOF.SuspendLayout()
        Me.grpWakefield.SuspendLayout()
        Me.grpMaths.SuspendLayout()
        Me.ContextMenuStripMaths.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.ContextMenuStripSummary.SuspendLayout()
        Me.grpFrequencies.SuspendLayout()
        Me.grpProbabilty.SuspendLayout()
        Me.ContextMenuStripProbability.SuspendLayout()
        Me.grpRandom.SuspendLayout()
        Me.grpTransform.SuspendLayout()
        Me.ContextMenuStripTransform.SuspendLayout()
        Me.grpLogical.SuspendLayout()
        Me.ContextMenuStripLogical.SuspendLayout()
        Me.grpTestString.SuspendLayout()
        Me.grpCircular.SuspendLayout()
        Me.ContextMenuStripCircular.SuspendLayout()
        Me.grpModifier.SuspendLayout()
        Me.grpSymbols.SuspendLayout()
        Me.grpComplex.SuspendLayout()
        Me.ContextMenuStripTxtString.SuspendLayout()
        Me.ContextMenuStripWakefield.SuspendLayout()
        Me.ContextMenuStripList.SuspendLayout()
        Me.grpList.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpMathBloc.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExpression
        '
        Me.lblExpression.AutoSize = True
        Me.lblExpression.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblExpression.Location = New System.Drawing.Point(9, 15)
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Size = New System.Drawing.Size(91, 20)
        Me.lblExpression.TabIndex = 119
        Me.lblExpression.Tag = "Expression"
        Me.lblExpression.Text = "Expression:"
        '
        'chkShowParameters
        '
        Me.chkShowParameters.AutoSize = True
        Me.chkShowParameters.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.chkShowParameters.Location = New System.Drawing.Point(105, 62)
        Me.chkShowParameters.Margin = New System.Windows.Forms.Padding(4)
        Me.chkShowParameters.Name = "chkShowParameters"
        Me.chkShowParameters.Size = New System.Drawing.Size(161, 24)
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
        Me.grpBasic.Location = New System.Drawing.Point(334, 104)
        Me.grpBasic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpBasic.Size = New System.Drawing.Size(308, 201)
        Me.grpBasic.TabIndex = 179
        Me.grpBasic.TabStop = False
        Me.grpBasic.Text = "Basic"
        '
        'cmdClear
        '
        Me.cmdClear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClear.Location = New System.Drawing.Point(226, 106)
        Me.cmdClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(74, 90)
        Me.cmdClear.TabIndex = 190
        Me.cmdClear.Text = "Clear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdComma
        '
        Me.cmdComma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdComma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComma.Location = New System.Drawing.Point(4, 150)
        Me.cmdComma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComma.Name = "cmdComma"
        Me.cmdComma.Size = New System.Drawing.Size(57, 45)
        Me.cmdComma.TabIndex = 138
        Me.cmdComma.Text = ","
        Me.cmdComma.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        Me.cmdBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBrackets.Location = New System.Drawing.Point(116, 150)
        Me.cmdBrackets.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.Size = New System.Drawing.Size(57, 45)
        Me.cmdBrackets.TabIndex = 136
        Me.cmdBrackets.Text = "( )"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        Me.cmdPower.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPower.Location = New System.Drawing.Point(226, 63)
        Me.cmdPower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.Size = New System.Drawing.Size(74, 45)
        Me.cmdPower.TabIndex = 133
        Me.cmdPower.Text = "^"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        Me.cmdDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDivide.Location = New System.Drawing.Point(171, 20)
        Me.cmdDivide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.Size = New System.Drawing.Size(57, 45)
        Me.cmdDivide.TabIndex = 131
        Me.cmdDivide.Text = "/"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        Me.cmdPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdPlus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlus.Location = New System.Drawing.Point(171, 150)
        Me.cmdPlus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.Size = New System.Drawing.Size(57, 45)
        Me.cmdPlus.TabIndex = 130
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        Me.cmdMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMinus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMinus.Location = New System.Drawing.Point(171, 106)
        Me.cmdMinus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.Size = New System.Drawing.Size(57, 45)
        Me.cmdMinus.TabIndex = 129
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        Me.cmdMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMultiply.Location = New System.Drawing.Point(171, 63)
        Me.cmdMultiply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.Size = New System.Drawing.Size(57, 45)
        Me.cmdMultiply.TabIndex = 128
        Me.cmdMultiply.Text = "*"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        Me.cmdDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmdDot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDot.Location = New System.Drawing.Point(226, 20)
        Me.cmdDot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.Size = New System.Drawing.Size(74, 45)
        Me.cmdDot.TabIndex = 127
        Me.cmdDot.Text = "."
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        Me.cmd9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd9.Location = New System.Drawing.Point(116, 20)
        Me.cmd9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd9.Name = "cmd9"
        Me.cmd9.Size = New System.Drawing.Size(57, 45)
        Me.cmd9.TabIndex = 126
        Me.cmd9.Text = "9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        Me.cmd8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd8.Location = New System.Drawing.Point(60, 20)
        Me.cmd8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd8.Name = "cmd8"
        Me.cmd8.Size = New System.Drawing.Size(57, 45)
        Me.cmd8.TabIndex = 125
        Me.cmd8.Text = "8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        Me.cmd7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd7.Location = New System.Drawing.Point(4, 20)
        Me.cmd7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd7.Name = "cmd7"
        Me.cmd7.Size = New System.Drawing.Size(57, 45)
        Me.cmd7.TabIndex = 124
        Me.cmd7.Text = "7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        Me.cmd6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd6.Location = New System.Drawing.Point(116, 63)
        Me.cmd6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd6.Name = "cmd6"
        Me.cmd6.Size = New System.Drawing.Size(57, 45)
        Me.cmd6.TabIndex = 123
        Me.cmd6.Text = "6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        Me.cmd5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd5.Location = New System.Drawing.Point(60, 63)
        Me.cmd5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd5.Name = "cmd5"
        Me.cmd5.Size = New System.Drawing.Size(57, 45)
        Me.cmd5.TabIndex = 122
        Me.cmd5.Text = "5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        Me.cmd4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd4.Location = New System.Drawing.Point(4, 63)
        Me.cmd4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd4.Name = "cmd4"
        Me.cmd4.Size = New System.Drawing.Size(57, 45)
        Me.cmd4.TabIndex = 121
        Me.cmd4.Text = "4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        Me.cmd3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd3.Location = New System.Drawing.Point(116, 106)
        Me.cmd3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd3.Name = "cmd3"
        Me.cmd3.Size = New System.Drawing.Size(57, 45)
        Me.cmd3.TabIndex = 120
        Me.cmd3.Text = "3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        Me.cmd2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd2.Location = New System.Drawing.Point(60, 106)
        Me.cmd2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd2.Name = "cmd2"
        Me.cmd2.Size = New System.Drawing.Size(57, 45)
        Me.cmd2.TabIndex = 119
        Me.cmd2.Text = "2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        Me.cmd0.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd0.Location = New System.Drawing.Point(60, 150)
        Me.cmd0.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd0.Name = "cmd0"
        Me.cmd0.Size = New System.Drawing.Size(57, 45)
        Me.cmd0.TabIndex = 118
        Me.cmd0.Text = "0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        Me.cmd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmd1.Location = New System.Drawing.Point(4, 106)
        Me.cmd1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmd1.Name = "cmd1"
        Me.cmd1.Size = New System.Drawing.Size(57, 45)
        Me.cmd1.TabIndex = 117
        Me.cmd1.Text = "1"
        Me.cmd1.UseVisualStyleBackColor = True
        '
        'grpDates
        '
        Me.grpDates.Controls.Add(Me.cmdRHelp)
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
        Me.grpDates.Controls.Add(Me.cmdWday)
        Me.grpDates.Controls.Add(Me.cmdMdy)
        Me.grpDates.Controls.Add(Me.cmdYmd)
        Me.grpDates.Controls.Add(Me.cmdLeap)
        Me.grpDates.Location = New System.Drawing.Point(651, 93)
        Me.grpDates.Margin = New System.Windows.Forms.Padding(4)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Padding = New System.Windows.Forms.Padding(4)
        Me.grpDates.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grpDates.Size = New System.Drawing.Size(366, 243)
        Me.grpDates.TabIndex = 188
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Dates/Times"
        '
        'cmdRHelp
        '
        Me.cmdRHelp.AutoSize = True
        Me.cmdRHelp.ContextMenuStrip = Me.ContextMenuStripDate
        Me.cmdRHelp.Location = New System.Drawing.Point(222, 202)
        Me.cmdRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRHelp.Name = "cmdRHelp"
        Me.cmdRHelp.Size = New System.Drawing.Size(136, 45)
        Me.cmdRHelp.SplitMenuStrip = Me.ContextMenuStripDate
        Me.cmdRHelp.TabIndex = 212
        Me.cmdRHelp.Text = "R Help"
        Me.cmdRHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripDate
        '
        Me.ContextMenuStripDate.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripDate.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateLubridateToolStripMenuItem, Me.DateHmsToolStripMenuItem})
        Me.ContextMenuStripDate.Name = "ContextMenuStrip1"
        Me.ContextMenuStripDate.Size = New System.Drawing.Size(155, 68)
        '
        'DateLubridateToolStripMenuItem
        '
        Me.DateLubridateToolStripMenuItem.Name = "DateLubridateToolStripMenuItem"
        Me.DateLubridateToolStripMenuItem.Size = New System.Drawing.Size(154, 32)
        Me.DateLubridateToolStripMenuItem.Text = "lubridate"
        '
        'DateHmsToolStripMenuItem
        '
        Me.DateHmsToolStripMenuItem.Name = "DateHmsToolStripMenuItem"
        Me.DateHmsToolStripMenuItem.Size = New System.Drawing.Size(154, 32)
        Me.DateHmsToolStripMenuItem.Text = "hms"
        '
        'cmdPm
        '
        Me.cmdPm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPm.Location = New System.Drawing.Point(6, 195)
        Me.cmdPm.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPm.Name = "cmdPm"
        Me.cmdPm.Size = New System.Drawing.Size(90, 45)
        Me.cmdPm.TabIndex = 161
        Me.cmdPm.Text = "pm"
        Me.cmdPm.UseVisualStyleBackColor = True
        '
        'cmdTime
        '
        Me.cmdTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTime.Location = New System.Drawing.Point(183, 21)
        Me.cmdTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTime.Name = "cmdTime"
        Me.cmdTime.Size = New System.Drawing.Size(90, 45)
        Me.cmdTime.TabIndex = 160
        Me.cmdTime.Text = "time"
        Me.cmdTime.UseVisualStyleBackColor = True
        '
        'cmdDateTime
        '
        Me.cmdDateTime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDateTime.Location = New System.Drawing.Point(94, 21)
        Me.cmdDateTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDateTime.Name = "cmdDateTime"
        Me.cmdDateTime.Size = New System.Drawing.Size(90, 45)
        Me.cmdDateTime.TabIndex = 159
        Me.cmdDateTime.Text = "datetime"
        Me.cmdDateTime.UseVisualStyleBackColor = True
        '
        'cmdQuarter
        '
        Me.cmdQuarter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuarter.Location = New System.Drawing.Point(94, 195)
        Me.cmdQuarter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdQuarter.Name = "cmdQuarter"
        Me.cmdQuarter.Size = New System.Drawing.Size(90, 45)
        Me.cmdQuarter.TabIndex = 157
        Me.cmdQuarter.Text = "quarter"
        Me.cmdQuarter.UseVisualStyleBackColor = True
        '
        'cmdD_In_M
        '
        Me.cmdD_In_M.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdD_In_M.Location = New System.Drawing.Point(94, 64)
        Me.cmdD_In_M.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdD_In_M.Name = "cmdD_In_M"
        Me.cmdD_In_M.Size = New System.Drawing.Size(90, 45)
        Me.cmdD_In_M.TabIndex = 156
        Me.cmdD_In_M.Text = "d_in_m"
        Me.cmdD_In_M.UseVisualStyleBackColor = True
        '
        'cmdAm
        '
        Me.cmdAm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAm.Location = New System.Drawing.Point(272, 152)
        Me.cmdAm.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAm.Name = "cmdAm"
        Me.cmdAm.Size = New System.Drawing.Size(90, 45)
        Me.cmdAm.TabIndex = 155
        Me.cmdAm.Text = "am"
        Me.cmdAm.UseVisualStyleBackColor = True
        '
        'cmdSec
        '
        Me.cmdSec.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSec.Location = New System.Drawing.Point(183, 152)
        Me.cmdSec.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSec.Name = "cmdSec"
        Me.cmdSec.Size = New System.Drawing.Size(90, 45)
        Me.cmdSec.TabIndex = 154
        Me.cmdSec.Text = "sec"
        Me.cmdSec.UseVisualStyleBackColor = True
        '
        'cmdHour
        '
        Me.cmdHour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHour.Location = New System.Drawing.Point(6, 152)
        Me.cmdHour.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHour.Name = "cmdHour"
        Me.cmdHour.Size = New System.Drawing.Size(90, 45)
        Me.cmdHour.TabIndex = 153
        Me.cmdHour.Text = "hour"
        Me.cmdHour.UseVisualStyleBackColor = True
        '
        'cmdminutes
        '
        Me.cmdminutes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdminutes.Location = New System.Drawing.Point(94, 152)
        Me.cmdminutes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdminutes.Name = "cmdminutes"
        Me.cmdminutes.Size = New System.Drawing.Size(90, 45)
        Me.cmdminutes.TabIndex = 152
        Me.cmdminutes.Text = "min"
        Me.cmdminutes.UseVisualStyleBackColor = True
        '
        'cmdDmy
        '
        Me.cmdDmy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDmy.Location = New System.Drawing.Point(94, 108)
        Me.cmdDmy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDmy.Name = "cmdDmy"
        Me.cmdDmy.Size = New System.Drawing.Size(90, 45)
        Me.cmdDmy.TabIndex = 151
        Me.cmdDmy.Tag = "dmy"
        Me.cmdDmy.Text = "dmy"
        Me.cmdDmy.UseVisualStyleBackColor = True
        '
        'cmdDay
        '
        Me.cmdDay.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDay.Location = New System.Drawing.Point(6, 64)
        Me.cmdDay.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDay.Name = "cmdDay"
        Me.cmdDay.Size = New System.Drawing.Size(90, 45)
        Me.cmdDay.TabIndex = 145
        Me.cmdDay.Text = "day"
        Me.cmdDay.UseVisualStyleBackColor = True
        '
        'cmdMonth
        '
        Me.cmdMonth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMonth.Location = New System.Drawing.Point(6, 64)
        Me.cmdMonth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMonth.Name = "cmdMonth"
        Me.cmdMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMonth.Size = New System.Drawing.Size(90, 45)
        Me.cmdMonth.TabIndex = 144
        Me.cmdMonth.Text = "month"
        Me.cmdMonth.UseVisualStyleBackColor = True
        '
        'cmdYear
        '
        Me.cmdYear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYear.Location = New System.Drawing.Point(272, 21)
        Me.cmdYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdYear.Name = "cmdYear"
        Me.cmdYear.Size = New System.Drawing.Size(90, 45)
        Me.cmdYear.TabIndex = 143
        Me.cmdYear.Text = "year"
        Me.cmdYear.UseVisualStyleBackColor = True
        '
        'cmdDate
        '
        Me.cmdDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDate.Location = New System.Drawing.Point(6, 21)
        Me.cmdDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDate.Name = "cmdDate"
        Me.cmdDate.Size = New System.Drawing.Size(90, 45)
        Me.cmdDate.TabIndex = 142
        Me.cmdDate.Text = "date"
        Me.cmdDate.UseVisualStyleBackColor = True
        '
        'cmdYday
        '
        Me.cmdYday.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYday.Location = New System.Drawing.Point(272, 64)
        Me.cmdYday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdYday.Name = "cmdYday"
        Me.cmdYday.Size = New System.Drawing.Size(90, 45)
        Me.cmdYday.TabIndex = 141
        Me.cmdYday.Text = "yday"
        Me.cmdYday.UseVisualStyleBackColor = True
        '
        'cmdWday
        '
        Me.cmdWday.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWday.Location = New System.Drawing.Point(183, 64)
        Me.cmdWday.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdWday.Name = "cmdWday"
        Me.cmdWday.Size = New System.Drawing.Size(90, 45)
        Me.cmdWday.TabIndex = 140
        Me.cmdWday.Text = "wday"
        Me.cmdWday.UseVisualStyleBackColor = True
        '
        'cmdMdy
        '
        Me.cmdMdy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMdy.Location = New System.Drawing.Point(183, 108)
        Me.cmdMdy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMdy.Name = "cmdMdy"
        Me.cmdMdy.Size = New System.Drawing.Size(90, 45)
        Me.cmdMdy.TabIndex = 139
        Me.cmdMdy.Text = "mdy"
        Me.cmdMdy.UseVisualStyleBackColor = True
        '
        'cmdYmd
        '
        Me.cmdYmd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdYmd.Location = New System.Drawing.Point(6, 108)
        Me.cmdYmd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdYmd.Name = "cmdYmd"
        Me.cmdYmd.Size = New System.Drawing.Size(90, 45)
        Me.cmdYmd.TabIndex = 138
        Me.cmdYmd.Text = "ymd"
        Me.cmdYmd.UseVisualStyleBackColor = True
        '
        'cmdLeap
        '
        Me.cmdLeap.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLeap.Location = New System.Drawing.Point(272, 108)
        Me.cmdLeap.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLeap.Name = "cmdLeap"
        Me.cmdLeap.Size = New System.Drawing.Size(90, 45)
        Me.cmdLeap.TabIndex = 136
        Me.cmdLeap.Text = "leap"
        Me.cmdLeap.UseVisualStyleBackColor = True
        '
        'ContextMenuStripComplex
        '
        Me.ContextMenuStripComplex.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripComplex.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplexBaseToolStripMenuItem})
        Me.ContextMenuStripComplex.Name = "ContextMenuStrip1"
        Me.ContextMenuStripComplex.Size = New System.Drawing.Size(122, 36)
        '
        'ComplexBaseToolStripMenuItem
        '
        Me.ComplexBaseToolStripMenuItem.Name = "ComplexBaseToolStripMenuItem"
        Me.ComplexBaseToolStripMenuItem.Size = New System.Drawing.Size(121, 32)
        Me.ComplexBaseToolStripMenuItem.Text = "base"
        '
        'grpInteger
        '
        Me.grpInteger.Controls.Add(Me.cmdPrimorial)
        Me.grpInteger.Controls.Add(Me.cmdFactorize2)
        Me.grpInteger.Controls.Add(Me.cmdLucas)
        Me.grpInteger.Controls.Add(Me.cmdFactorize)
        Me.grpInteger.Controls.Add(Me.cmdSquare)
        Me.grpInteger.Controls.Add(Me.cmdTriangle)
        Me.grpInteger.Controls.Add(Me.cmdPadovan)
        Me.grpInteger.Controls.Add(Me.cmdAchilles)
        Me.grpInteger.Controls.Add(Me.cmdHappy)
        Me.grpInteger.Controls.Add(Me.cmdUgly)
        Me.grpInteger.Controls.Add(Me.cmdPowerful)
        Me.grpInteger.Controls.Add(Me.cmdFrugal)
        Me.grpInteger.Controls.Add(Me.cmdPerfect)
        Me.grpInteger.Controls.Add(Me.cmdAbundant)
        Me.grpInteger.Controls.Add(Me.cmdFibonacci2)
        Me.grpInteger.Controls.Add(Me.cmdPalindrome)
        Me.grpInteger.Controls.Add(Me.cmdRoman)
        Me.grpInteger.Controls.Add(Me.cmdHexmode)
        Me.grpInteger.Controls.Add(Me.cmdOctmode)
        Me.grpInteger.Controls.Add(Me.cmdKTuple)
        Me.grpInteger.Controls.Add(Me.cmdTriplets)
        Me.grpInteger.Controls.Add(Me.cmdThird)
        Me.grpInteger.Controls.Add(Me.cmdSexy)
        Me.grpInteger.Controls.Add(Me.cmdCousin)
        Me.grpInteger.Controls.Add(Me.cmdTwin)
        Me.grpInteger.Controls.Add(Me.cmdPhi)
        Me.grpInteger.Controls.Add(Me.cmdCoprime)
        Me.grpInteger.Controls.Add(Me.cmdSCM)
        Me.grpInteger.Controls.Add(Me.cmdGCD)
        Me.grpInteger.Controls.Add(Me.cmdGeneratePrimes)
        Me.grpInteger.Controls.Add(Me.cmdNthPrime)
        Me.grpInteger.Controls.Add(Me.cmdIntegerRHelp)
        Me.grpInteger.Controls.Add(Me.cmdHex)
        Me.grpInteger.Controls.Add(Me.cmdOctal)
        Me.grpInteger.Controls.Add(Me.cmdBinary)
        Me.grpInteger.Controls.Add(Me.cmdBigQ)
        Me.grpInteger.Controls.Add(Me.cmdDigitSum)
        Me.grpInteger.Controls.Add(Me.cmdRankPercent)
        Me.grpInteger.Controls.Add(Me.cmdDivisors)
        Me.grpInteger.Controls.Add(Me.cmdFibonacci)
        Me.grpInteger.Controls.Add(Me.cmdNextPrime)
        Me.grpInteger.Controls.Add(Me.cmdChoosez)
        Me.grpInteger.Controls.Add(Me.cmdFactorial)
        Me.grpInteger.Controls.Add(Me.cmdIsPrime)
        Me.grpInteger.Controls.Add(Me.cmdBigZ)
        Me.grpInteger.Location = New System.Drawing.Point(651, 92)
        Me.grpInteger.Margin = New System.Windows.Forms.Padding(4)
        Me.grpInteger.Name = "grpInteger"
        Me.grpInteger.Padding = New System.Windows.Forms.Padding(4)
        Me.grpInteger.Size = New System.Drawing.Size(462, 476)
        Me.grpInteger.TabIndex = 183
        Me.grpInteger.TabStop = False
        Me.grpInteger.Text = "Integer"
        '
        'cmdPrimorial
        '
        Me.cmdPrimorial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPrimorial.Location = New System.Drawing.Point(334, 272)
        Me.cmdPrimorial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrimorial.Name = "cmdPrimorial"
        Me.cmdPrimorial.Size = New System.Drawing.Size(112, 34)
        Me.cmdPrimorial.TabIndex = 47
        Me.cmdPrimorial.Text = "primorial"
        Me.cmdPrimorial.UseVisualStyleBackColor = True
        '
        'cmdFactorize2
        '
        Me.cmdFactorize2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFactorize2.Location = New System.Drawing.Point(224, 58)
        Me.cmdFactorize2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFactorize2.Name = "cmdFactorize2"
        Me.cmdFactorize2.Size = New System.Drawing.Size(112, 34)
        Me.cmdFactorize2.TabIndex = 46
        Me.cmdFactorize2.Text = "factorize2"
        Me.cmdFactorize2.UseVisualStyleBackColor = True
        '
        'cmdLucas
        '
        Me.cmdLucas.Location = New System.Drawing.Point(112, 92)
        Me.cmdLucas.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLucas.Name = "cmdLucas"
        Me.cmdLucas.Size = New System.Drawing.Size(112, 34)
        Me.cmdLucas.TabIndex = 45
        Me.cmdLucas.Text = "lucas"
        Me.cmdLucas.UseVisualStyleBackColor = True
        '
        'cmdFactorize
        '
        Me.cmdFactorize.Location = New System.Drawing.Point(112, 58)
        Me.cmdFactorize.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFactorize.Name = "cmdFactorize"
        Me.cmdFactorize.Size = New System.Drawing.Size(112, 34)
        Me.cmdFactorize.TabIndex = 44
        Me.cmdFactorize.Text = "factorize"
        Me.cmdFactorize.UseVisualStyleBackColor = True
        '
        'cmdSquare
        '
        Me.cmdSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSquare.Location = New System.Drawing.Point(334, 386)
        Me.cmdSquare.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSquare.Name = "cmdSquare"
        Me.cmdSquare.Size = New System.Drawing.Size(112, 34)
        Me.cmdSquare.TabIndex = 43
        Me.cmdSquare.Text = "square"
        Me.cmdSquare.UseVisualStyleBackColor = True
        '
        'cmdTriangle
        '
        Me.cmdTriangle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTriangle.Location = New System.Drawing.Point(224, 386)
        Me.cmdTriangle.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTriangle.Name = "cmdTriangle"
        Me.cmdTriangle.Size = New System.Drawing.Size(112, 34)
        Me.cmdTriangle.TabIndex = 42
        Me.cmdTriangle.Text = "triangle"
        Me.cmdTriangle.UseVisualStyleBackColor = True
        '
        'cmdPadovan
        '
        Me.cmdPadovan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPadovan.Location = New System.Drawing.Point(112, 386)
        Me.cmdPadovan.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPadovan.Name = "cmdPadovan"
        Me.cmdPadovan.Size = New System.Drawing.Size(112, 34)
        Me.cmdPadovan.TabIndex = 41
        Me.cmdPadovan.Text = "padovan"
        Me.cmdPadovan.UseVisualStyleBackColor = True
        '
        'cmdAchilles
        '
        Me.cmdAchilles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAchilles.Location = New System.Drawing.Point(2, 386)
        Me.cmdAchilles.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAchilles.Name = "cmdAchilles"
        Me.cmdAchilles.Size = New System.Drawing.Size(112, 34)
        Me.cmdAchilles.TabIndex = 40
        Me.cmdAchilles.Text = "achilles"
        Me.cmdAchilles.UseVisualStyleBackColor = True
        '
        'cmdHappy
        '
        Me.cmdHappy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdHappy.Location = New System.Drawing.Point(334, 352)
        Me.cmdHappy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHappy.Name = "cmdHappy"
        Me.cmdHappy.Size = New System.Drawing.Size(112, 34)
        Me.cmdHappy.TabIndex = 39
        Me.cmdHappy.Text = "happy"
        Me.cmdHappy.UseVisualStyleBackColor = True
        '
        'cmdUgly
        '
        Me.cmdUgly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdUgly.Location = New System.Drawing.Point(224, 352)
        Me.cmdUgly.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUgly.Name = "cmdUgly"
        Me.cmdUgly.Size = New System.Drawing.Size(112, 34)
        Me.cmdUgly.TabIndex = 38
        Me.cmdUgly.Text = "ugly"
        Me.cmdUgly.UseVisualStyleBackColor = True
        '
        'cmdPowerful
        '
        Me.cmdPowerful.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPowerful.Location = New System.Drawing.Point(112, 352)
        Me.cmdPowerful.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPowerful.Name = "cmdPowerful"
        Me.cmdPowerful.Size = New System.Drawing.Size(112, 34)
        Me.cmdPowerful.TabIndex = 37
        Me.cmdPowerful.Text = "powerful"
        Me.cmdPowerful.UseVisualStyleBackColor = True
        '
        'cmdFrugal
        '
        Me.cmdFrugal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFrugal.Location = New System.Drawing.Point(2, 352)
        Me.cmdFrugal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFrugal.Name = "cmdFrugal"
        Me.cmdFrugal.Size = New System.Drawing.Size(112, 34)
        Me.cmdFrugal.TabIndex = 36
        Me.cmdFrugal.Text = "frugal"
        Me.cmdFrugal.UseVisualStyleBackColor = True
        '
        'cmdPerfect
        '
        Me.cmdPerfect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPerfect.Location = New System.Drawing.Point(334, 320)
        Me.cmdPerfect.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPerfect.Name = "cmdPerfect"
        Me.cmdPerfect.Size = New System.Drawing.Size(112, 34)
        Me.cmdPerfect.TabIndex = 35
        Me.cmdPerfect.Text = "perfect"
        Me.cmdPerfect.UseVisualStyleBackColor = True
        '
        'cmdAbundant
        '
        Me.cmdAbundant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAbundant.Location = New System.Drawing.Point(224, 320)
        Me.cmdAbundant.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAbundant.Name = "cmdAbundant"
        Me.cmdAbundant.Size = New System.Drawing.Size(112, 34)
        Me.cmdAbundant.TabIndex = 34
        Me.cmdAbundant.Text = "abundant"
        Me.cmdAbundant.UseVisualStyleBackColor = True
        '
        'cmdFibonacci2
        '
        Me.cmdFibonacci2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFibonacci2.Location = New System.Drawing.Point(112, 320)
        Me.cmdFibonacci2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFibonacci2.Name = "cmdFibonacci2"
        Me.cmdFibonacci2.Size = New System.Drawing.Size(112, 34)
        Me.cmdFibonacci2.TabIndex = 33
        Me.cmdFibonacci2.Text = "fibonacci2"
        Me.cmdFibonacci2.UseVisualStyleBackColor = True
        '
        'cmdPalindrome
        '
        Me.cmdPalindrome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPalindrome.Location = New System.Drawing.Point(2, 320)
        Me.cmdPalindrome.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPalindrome.Name = "cmdPalindrome"
        Me.cmdPalindrome.Size = New System.Drawing.Size(112, 34)
        Me.cmdPalindrome.TabIndex = 32
        Me.cmdPalindrome.Text = "palindrome"
        Me.cmdPalindrome.UseVisualStyleBackColor = True
        '
        'cmdRoman
        '
        Me.cmdRoman.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRoman.Location = New System.Drawing.Point(224, 158)
        Me.cmdRoman.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRoman.Name = "cmdRoman"
        Me.cmdRoman.Size = New System.Drawing.Size(112, 34)
        Me.cmdRoman.TabIndex = 31
        Me.cmdRoman.Text = "roman"
        Me.cmdRoman.UseVisualStyleBackColor = True
        '
        'cmdHexmode
        '
        Me.cmdHexmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdHexmode.Location = New System.Drawing.Point(334, 124)
        Me.cmdHexmode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHexmode.Name = "cmdHexmode"
        Me.cmdHexmode.Size = New System.Drawing.Size(112, 34)
        Me.cmdHexmode.TabIndex = 30
        Me.cmdHexmode.Text = "hexmode"
        Me.cmdHexmode.UseVisualStyleBackColor = True
        '
        'cmdOctmode
        '
        Me.cmdOctmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdOctmode.Location = New System.Drawing.Point(224, 124)
        Me.cmdOctmode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOctmode.Name = "cmdOctmode"
        Me.cmdOctmode.Size = New System.Drawing.Size(112, 34)
        Me.cmdOctmode.TabIndex = 29
        Me.cmdOctmode.Text = "octmode"
        Me.cmdOctmode.UseVisualStyleBackColor = True
        '
        'cmdKTuple
        '
        Me.cmdKTuple.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdKTuple.Location = New System.Drawing.Point(224, 272)
        Me.cmdKTuple.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdKTuple.Name = "cmdKTuple"
        Me.cmdKTuple.Size = New System.Drawing.Size(112, 34)
        Me.cmdKTuple.TabIndex = 28
        Me.cmdKTuple.Text = "k-tuple"
        Me.cmdKTuple.UseVisualStyleBackColor = True
        '
        'cmdTriplets
        '
        Me.cmdTriplets.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTriplets.Location = New System.Drawing.Point(112, 272)
        Me.cmdTriplets.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTriplets.Name = "cmdTriplets"
        Me.cmdTriplets.Size = New System.Drawing.Size(112, 34)
        Me.cmdTriplets.TabIndex = 27
        Me.cmdTriplets.Text = "triplets"
        Me.cmdTriplets.UseVisualStyleBackColor = True
        '
        'cmdThird
        '
        Me.cmdThird.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdThird.Location = New System.Drawing.Point(2, 272)
        Me.cmdThird.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdThird.Name = "cmdThird"
        Me.cmdThird.Size = New System.Drawing.Size(112, 34)
        Me.cmdThird.TabIndex = 26
        Me.cmdThird.Text = "third"
        Me.cmdThird.UseVisualStyleBackColor = True
        '
        'cmdSexy
        '
        Me.cmdSexy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSexy.Location = New System.Drawing.Point(334, 238)
        Me.cmdSexy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSexy.Name = "cmdSexy"
        Me.cmdSexy.Size = New System.Drawing.Size(112, 34)
        Me.cmdSexy.TabIndex = 25
        Me.cmdSexy.Text = "sexy"
        Me.cmdSexy.UseVisualStyleBackColor = True
        '
        'cmdCousin
        '
        Me.cmdCousin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCousin.Location = New System.Drawing.Point(224, 238)
        Me.cmdCousin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCousin.Name = "cmdCousin"
        Me.cmdCousin.Size = New System.Drawing.Size(112, 34)
        Me.cmdCousin.TabIndex = 24
        Me.cmdCousin.Text = "cousin"
        Me.cmdCousin.UseVisualStyleBackColor = True
        '
        'cmdTwin
        '
        Me.cmdTwin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTwin.Location = New System.Drawing.Point(112, 238)
        Me.cmdTwin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTwin.Name = "cmdTwin"
        Me.cmdTwin.Size = New System.Drawing.Size(112, 34)
        Me.cmdTwin.TabIndex = 23
        Me.cmdTwin.Text = "twin"
        Me.cmdTwin.UseVisualStyleBackColor = True
        '
        'cmdPhi
        '
        Me.cmdPhi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPhi.Location = New System.Drawing.Point(112, 158)
        Me.cmdPhi.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPhi.Name = "cmdPhi"
        Me.cmdPhi.Size = New System.Drawing.Size(112, 34)
        Me.cmdPhi.TabIndex = 22
        Me.cmdPhi.Text = "phi"
        Me.cmdPhi.UseVisualStyleBackColor = True
        '
        'cmdCoprime
        '
        Me.cmdCoprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCoprime.Location = New System.Drawing.Point(2, 238)
        Me.cmdCoprime.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCoprime.Name = "cmdCoprime"
        Me.cmdCoprime.Size = New System.Drawing.Size(112, 34)
        Me.cmdCoprime.TabIndex = 21
        Me.cmdCoprime.Text = "coprime"
        Me.cmdCoprime.UseVisualStyleBackColor = True
        '
        'cmdSCM
        '
        Me.cmdSCM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSCM.Location = New System.Drawing.Point(2, 158)
        Me.cmdSCM.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSCM.Name = "cmdSCM"
        Me.cmdSCM.Size = New System.Drawing.Size(112, 34)
        Me.cmdSCM.TabIndex = 20
        Me.cmdSCM.Text = "scm"
        Me.cmdSCM.UseVisualStyleBackColor = True
        '
        'cmdGCD
        '
        Me.cmdGCD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdGCD.Location = New System.Drawing.Point(334, 158)
        Me.cmdGCD.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGCD.Name = "cmdGCD"
        Me.cmdGCD.Size = New System.Drawing.Size(112, 34)
        Me.cmdGCD.TabIndex = 19
        Me.cmdGCD.Text = "gcd"
        Me.cmdGCD.UseVisualStyleBackColor = True
        '
        'cmdGeneratePrimes
        '
        Me.cmdGeneratePrimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdGeneratePrimes.Location = New System.Drawing.Point(2, 206)
        Me.cmdGeneratePrimes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGeneratePrimes.Name = "cmdGeneratePrimes"
        Me.cmdGeneratePrimes.Size = New System.Drawing.Size(112, 34)
        Me.cmdGeneratePrimes.TabIndex = 18
        Me.cmdGeneratePrimes.Text = "primes"
        Me.cmdGeneratePrimes.UseVisualStyleBackColor = True
        '
        'cmdNthPrime
        '
        Me.cmdNthPrime.Location = New System.Drawing.Point(112, 206)
        Me.cmdNthPrime.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNthPrime.Name = "cmdNthPrime"
        Me.cmdNthPrime.Size = New System.Drawing.Size(112, 34)
        Me.cmdNthPrime.TabIndex = 17
        Me.cmdNthPrime.Text = "nth_prime"
        Me.cmdNthPrime.UseVisualStyleBackColor = True
        '
        'cmdIntegerRHelp
        '
        Me.cmdIntegerRHelp.AutoSize = True
        Me.cmdIntegerRHelp.ContextMenuStrip = Me.ContextMenuStripInteger
        Me.cmdIntegerRHelp.Location = New System.Drawing.Point(315, 434)
        Me.cmdIntegerRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIntegerRHelp.Name = "cmdIntegerRHelp"
        Me.cmdIntegerRHelp.Size = New System.Drawing.Size(136, 45)
        Me.cmdIntegerRHelp.SplitMenuStrip = Me.ContextMenuStripInteger
        Me.cmdIntegerRHelp.TabIndex = 16
        Me.cmdIntegerRHelp.Text = "R Help"
        Me.cmdIntegerRHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripInteger
        '
        Me.ContextMenuStripInteger.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripInteger.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GmpToolStripMenuItem, Me.DescToolsToolStripMenuItem, Me.RutilsToolStripMenuItem, Me.PrimesToolStripMenuItem, Me.ZseqToolStripMenuItem, Me.UtilsToolStripMenuItem, Me.ConfdesignToolStripMenuItem})
        Me.ContextMenuStripInteger.Name = "ContextMenuStripInteger"
        Me.ContextMenuStripInteger.Size = New System.Drawing.Size(180, 228)
        '
        'GmpToolStripMenuItem
        '
        Me.GmpToolStripMenuItem.Name = "GmpToolStripMenuItem"
        Me.GmpToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.GmpToolStripMenuItem.Text = "Gmp"
        '
        'DescToolsToolStripMenuItem
        '
        Me.DescToolsToolStripMenuItem.Name = "DescToolsToolStripMenuItem"
        Me.DescToolsToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.DescToolsToolStripMenuItem.Text = "DescTools"
        '
        'RutilsToolStripMenuItem
        '
        Me.RutilsToolStripMenuItem.Name = "RutilsToolStripMenuItem"
        Me.RutilsToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.RutilsToolStripMenuItem.Text = "R.utils"
        '
        'PrimesToolStripMenuItem
        '
        Me.PrimesToolStripMenuItem.Name = "PrimesToolStripMenuItem"
        Me.PrimesToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.PrimesToolStripMenuItem.Text = "Primes"
        '
        'ZseqToolStripMenuItem
        '
        Me.ZseqToolStripMenuItem.Name = "ZseqToolStripMenuItem"
        Me.ZseqToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.ZseqToolStripMenuItem.Text = "Zseq"
        '
        'UtilsToolStripMenuItem
        '
        Me.UtilsToolStripMenuItem.Name = "UtilsToolStripMenuItem"
        Me.UtilsToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.UtilsToolStripMenuItem.Text = "R Utils"
        '
        'ConfdesignToolStripMenuItem
        '
        Me.ConfdesignToolStripMenuItem.Name = "ConfdesignToolStripMenuItem"
        Me.ConfdesignToolStripMenuItem.Size = New System.Drawing.Size(179, 32)
        Me.ConfdesignToolStripMenuItem.Text = "Conf.design"
        '
        'cmdHex
        '
        Me.cmdHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdHex.Location = New System.Drawing.Point(112, 124)
        Me.cmdHex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHex.Name = "cmdHex"
        Me.cmdHex.Size = New System.Drawing.Size(112, 34)
        Me.cmdHex.TabIndex = 15
        Me.cmdHex.Text = "hex"
        Me.cmdHex.UseVisualStyleBackColor = True
        '
        'cmdOctal
        '
        Me.cmdOctal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdOctal.Location = New System.Drawing.Point(2, 124)
        Me.cmdOctal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOctal.Name = "cmdOctal"
        Me.cmdOctal.Size = New System.Drawing.Size(112, 34)
        Me.cmdOctal.TabIndex = 14
        Me.cmdOctal.Text = "octal"
        Me.cmdOctal.UseVisualStyleBackColor = True
        '
        'cmdBinary
        '
        Me.cmdBinary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBinary.Location = New System.Drawing.Point(334, 92)
        Me.cmdBinary.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBinary.Name = "cmdBinary"
        Me.cmdBinary.Size = New System.Drawing.Size(112, 34)
        Me.cmdBinary.TabIndex = 13
        Me.cmdBinary.Text = "binary"
        Me.cmdBinary.UseVisualStyleBackColor = True
        '
        'cmdBigQ
        '
        Me.cmdBigQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBigQ.Location = New System.Drawing.Point(112, 26)
        Me.cmdBigQ.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBigQ.Name = "cmdBigQ"
        Me.cmdBigQ.Size = New System.Drawing.Size(112, 34)
        Me.cmdBigQ.TabIndex = 12
        Me.cmdBigQ.Text = "bigq"
        Me.cmdBigQ.UseVisualStyleBackColor = True
        '
        'cmdDigitSum
        '
        Me.cmdDigitSum.Location = New System.Drawing.Point(334, 58)
        Me.cmdDigitSum.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDigitSum.Name = "cmdDigitSum"
        Me.cmdDigitSum.Size = New System.Drawing.Size(112, 34)
        Me.cmdDigitSum.TabIndex = 10
        Me.cmdDigitSum.Text = "digitsum"
        Me.cmdDigitSum.UseVisualStyleBackColor = True
        '
        'cmdRankPercent
        '
        Me.cmdRankPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRankPercent.Location = New System.Drawing.Point(224, 92)
        Me.cmdRankPercent.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRankPercent.Name = "cmdRankPercent"
        Me.cmdRankPercent.Size = New System.Drawing.Size(112, 34)
        Me.cmdRankPercent.TabIndex = 9
        Me.cmdRankPercent.Text = "percentrank"
        Me.cmdRankPercent.UseVisualStyleBackColor = True
        '
        'cmdDivisors
        '
        Me.cmdDivisors.Location = New System.Drawing.Point(2, 58)
        Me.cmdDivisors.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDivisors.Name = "cmdDivisors"
        Me.cmdDivisors.Size = New System.Drawing.Size(112, 34)
        Me.cmdDivisors.TabIndex = 8
        Me.cmdDivisors.Text = "divisors"
        Me.cmdDivisors.UseVisualStyleBackColor = True
        '
        'cmdFibonacci
        '
        Me.cmdFibonacci.Location = New System.Drawing.Point(2, 92)
        Me.cmdFibonacci.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFibonacci.Name = "cmdFibonacci"
        Me.cmdFibonacci.Size = New System.Drawing.Size(112, 34)
        Me.cmdFibonacci.TabIndex = 7
        Me.cmdFibonacci.Text = "fibonacci"
        Me.cmdFibonacci.UseVisualStyleBackColor = True
        '
        'cmdNextPrime
        '
        Me.cmdNextPrime.Location = New System.Drawing.Point(224, 206)
        Me.cmdNextPrime.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNextPrime.Name = "cmdNextPrime"
        Me.cmdNextPrime.Size = New System.Drawing.Size(112, 34)
        Me.cmdNextPrime.TabIndex = 5
        Me.cmdNextPrime.Text = "next prime"
        Me.cmdNextPrime.UseVisualStyleBackColor = True
        '
        'cmdChoosez
        '
        Me.cmdChoosez.Location = New System.Drawing.Point(334, 26)
        Me.cmdChoosez.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdChoosez.Name = "cmdChoosez"
        Me.cmdChoosez.Size = New System.Drawing.Size(112, 34)
        Me.cmdChoosez.TabIndex = 4
        Me.cmdChoosez.Text = "choose"
        Me.cmdChoosez.UseVisualStyleBackColor = True
        '
        'cmdFactorial
        '
        Me.cmdFactorial.Location = New System.Drawing.Point(224, 26)
        Me.cmdFactorial.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFactorial.Name = "cmdFactorial"
        Me.cmdFactorial.Size = New System.Drawing.Size(112, 34)
        Me.cmdFactorial.TabIndex = 2
        Me.cmdFactorial.Text = "factorial"
        Me.cmdFactorial.UseVisualStyleBackColor = True
        '
        'cmdIsPrime
        '
        Me.cmdIsPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdIsPrime.Location = New System.Drawing.Point(334, 206)
        Me.cmdIsPrime.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIsPrime.Name = "cmdIsPrime"
        Me.cmdIsPrime.Size = New System.Drawing.Size(112, 34)
        Me.cmdIsPrime.TabIndex = 1
        Me.cmdIsPrime.Text = "is_prime"
        Me.cmdIsPrime.UseVisualStyleBackColor = True
        '
        'cmdBigZ
        '
        Me.cmdBigZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBigZ.Location = New System.Drawing.Point(2, 26)
        Me.cmdBigZ.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBigZ.Name = "cmdBigZ"
        Me.cmdBigZ.Size = New System.Drawing.Size(112, 34)
        Me.cmdBigZ.TabIndex = 0
        Me.cmdBigZ.Text = "bigz"
        Me.cmdBigZ.UseVisualStyleBackColor = True
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
        Me.grpFactor.Location = New System.Drawing.Point(651, 92)
        Me.grpFactor.Name = "grpFactor"
        Me.grpFactor.Size = New System.Drawing.Size(372, 312)
        Me.grpFactor.TabIndex = 191
        Me.grpFactor.TabStop = False
        Me.grpFactor.Text = "Factor"
        '
        'cmdTransformHelp
        '
        Me.cmdTransformHelp.AutoSize = True
        Me.cmdTransformHelp.ContextMenuStrip = Me.ContextMenuStripFactor
        Me.cmdTransformHelp.Location = New System.Drawing.Point(226, 262)
        Me.cmdTransformHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTransformHelp.Name = "cmdTransformHelp"
        Me.cmdTransformHelp.Size = New System.Drawing.Size(136, 45)
        Me.cmdTransformHelp.SplitMenuStrip = Me.ContextMenuStripFactor
        Me.cmdTransformHelp.TabIndex = 212
        Me.cmdTransformHelp.Text = "R Help"
        Me.cmdTransformHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripFactor
        '
        Me.ContextMenuStripFactor.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripFactor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FactorForcatsToolStripMenuItem})
        Me.ContextMenuStripFactor.Name = "ContextMenuStrip1"
        Me.ContextMenuStripFactor.Size = New System.Drawing.Size(139, 36)
        '
        'FactorForcatsToolStripMenuItem
        '
        Me.FactorForcatsToolStripMenuItem.Name = "FactorForcatsToolStripMenuItem"
        Me.FactorForcatsToolStripMenuItem.Size = New System.Drawing.Size(138, 32)
        Me.FactorForcatsToolStripMenuItem.Text = "forcats"
        '
        'cmdShuffle
        '
        Me.cmdShuffle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdShuffle.Location = New System.Drawing.Point(273, 214)
        Me.cmdShuffle.Name = "cmdShuffle"
        Me.cmdShuffle.Size = New System.Drawing.Size(90, 48)
        Me.cmdShuffle.TabIndex = 210
        Me.cmdShuffle.Text = "shuffle"
        Me.cmdShuffle.UseVisualStyleBackColor = True
        '
        'cmdShift
        '
        Me.cmdShift.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdShift.Location = New System.Drawing.Point(184, 214)
        Me.cmdShift.Name = "cmdShift"
        Me.cmdShift.Size = New System.Drawing.Size(90, 48)
        Me.cmdShift.TabIndex = 209
        Me.cmdShift.Text = "shift"
        Me.cmdShift.UseVisualStyleBackColor = True
        '
        'cmdReverse
        '
        Me.cmdReverse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReverse.Location = New System.Drawing.Point(96, 214)
        Me.cmdReverse.Name = "cmdReverse"
        Me.cmdReverse.Size = New System.Drawing.Size(90, 48)
        Me.cmdReverse.TabIndex = 208
        Me.cmdReverse.Text = "reverse"
        Me.cmdReverse.UseVisualStyleBackColor = True
        '
        'cmdReorder
        '
        Me.cmdReorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReorder.Location = New System.Drawing.Point(6, 214)
        Me.cmdReorder.Name = "cmdReorder"
        Me.cmdReorder.Size = New System.Drawing.Size(90, 48)
        Me.cmdReorder.TabIndex = 207
        Me.cmdReorder.Text = "reorder"
        Me.cmdReorder.UseVisualStyleBackColor = True
        '
        'cmdRelevel
        '
        Me.cmdRelevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRelevel.Location = New System.Drawing.Point(273, 166)
        Me.cmdRelevel.Name = "cmdRelevel"
        Me.cmdRelevel.Size = New System.Drawing.Size(90, 48)
        Me.cmdRelevel.TabIndex = 206
        Me.cmdRelevel.Text = "relevel"
        Me.cmdRelevel.UseVisualStyleBackColor = True
        '
        'cmdRecode
        '
        Me.cmdRecode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRecode.Location = New System.Drawing.Point(184, 166)
        Me.cmdRecode.Name = "cmdRecode"
        Me.cmdRecode.Size = New System.Drawing.Size(90, 48)
        Me.cmdRecode.TabIndex = 205
        Me.cmdRecode.Text = "recode"
        Me.cmdRecode.UseVisualStyleBackColor = True
        '
        'cmdOther
        '
        Me.cmdOther.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOther.Location = New System.Drawing.Point(96, 166)
        Me.cmdOther.Name = "cmdOther"
        Me.cmdOther.Size = New System.Drawing.Size(90, 48)
        Me.cmdOther.TabIndex = 204
        Me.cmdOther.Text = "other"
        Me.cmdOther.UseVisualStyleBackColor = True
        '
        'cmdFmatch
        '
        Me.cmdFmatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFmatch.Location = New System.Drawing.Point(6, 166)
        Me.cmdFmatch.Name = "cmdFmatch"
        Me.cmdFmatch.Size = New System.Drawing.Size(90, 48)
        Me.cmdFmatch.TabIndex = 203
        Me.cmdFmatch.Text = "match"
        Me.cmdFmatch.UseVisualStyleBackColor = True
        '
        'cmdLump
        '
        Me.cmdLump.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLump.Location = New System.Drawing.Point(273, 120)
        Me.cmdLump.Name = "cmdLump"
        Me.cmdLump.Size = New System.Drawing.Size(90, 48)
        Me.cmdLump.TabIndex = 202
        Me.cmdLump.Text = "lump"
        Me.cmdLump.UseVisualStyleBackColor = True
        '
        'cmdInseq
        '
        Me.cmdInseq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInseq.Location = New System.Drawing.Point(184, 120)
        Me.cmdInseq.Name = "cmdInseq"
        Me.cmdInseq.Size = New System.Drawing.Size(90, 48)
        Me.cmdInseq.TabIndex = 201
        Me.cmdInseq.Text = "inseq"
        Me.cmdInseq.UseVisualStyleBackColor = True
        '
        'cmdInfreq
        '
        Me.cmdInfreq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInfreq.Location = New System.Drawing.Point(96, 120)
        Me.cmdInfreq.Name = "cmdInfreq"
        Me.cmdInfreq.Size = New System.Drawing.Size(90, 48)
        Me.cmdInfreq.TabIndex = 200
        Me.cmdInfreq.Text = "infreq"
        Me.cmdInfreq.UseVisualStyleBackColor = True
        '
        'cmdInorder
        '
        Me.cmdInorder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInorder.Location = New System.Drawing.Point(6, 120)
        Me.cmdInorder.Name = "cmdInorder"
        Me.cmdInorder.Size = New System.Drawing.Size(90, 48)
        Me.cmdInorder.TabIndex = 199
        Me.cmdInorder.Text = "inorder"
        Me.cmdInorder.UseVisualStyleBackColor = True
        '
        'cmdAdd_na
        '
        Me.cmdAdd_na.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAdd_na.Location = New System.Drawing.Point(273, 72)
        Me.cmdAdd_na.Name = "cmdAdd_na"
        Me.cmdAdd_na.Size = New System.Drawing.Size(90, 48)
        Me.cmdAdd_na.TabIndex = 198
        Me.cmdAdd_na.Text = "add_na"
        Me.cmdAdd_na.UseVisualStyleBackColor = True
        '
        'cmdExpand
        '
        Me.cmdExpand.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExpand.Location = New System.Drawing.Point(184, 72)
        Me.cmdExpand.Name = "cmdExpand"
        Me.cmdExpand.Size = New System.Drawing.Size(90, 48)
        Me.cmdExpand.TabIndex = 197
        Me.cmdExpand.Text = "expand"
        Me.cmdExpand.UseVisualStyleBackColor = True
        '
        'cmdDrop
        '
        Me.cmdDrop.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDrop.Location = New System.Drawing.Point(96, 72)
        Me.cmdDrop.Name = "cmdDrop"
        Me.cmdDrop.Size = New System.Drawing.Size(90, 48)
        Me.cmdDrop.TabIndex = 196
        Me.cmdDrop.Text = "drop"
        Me.cmdDrop.UseVisualStyleBackColor = True
        '
        'cmdCross
        '
        Me.cmdCross.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCross.Location = New System.Drawing.Point(6, 72)
        Me.cmdCross.Name = "cmdCross"
        Me.cmdCross.Size = New System.Drawing.Size(90, 48)
        Me.cmdCross.TabIndex = 195
        Me.cmdCross.Text = "cross"
        Me.cmdCross.UseVisualStyleBackColor = True
        '
        'cmdCollapse
        '
        Me.cmdCollapse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCollapse.Location = New System.Drawing.Point(273, 24)
        Me.cmdCollapse.Name = "cmdCollapse"
        Me.cmdCollapse.Size = New System.Drawing.Size(90, 48)
        Me.cmdCollapse.TabIndex = 194
        Me.cmdCollapse.Text = "collapse"
        Me.cmdCollapse.UseVisualStyleBackColor = True
        '
        'cmdLabelled
        '
        Me.cmdLabelled.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLabelled.Location = New System.Drawing.Point(184, 24)
        Me.cmdLabelled.Name = "cmdLabelled"
        Me.cmdLabelled.Size = New System.Drawing.Size(90, 48)
        Me.cmdLabelled.TabIndex = 193
        Me.cmdLabelled.Text = "labelled "
        Me.cmdLabelled.UseVisualStyleBackColor = True
        '
        'cmdFactor
        '
        Me.cmdFactor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFactor.Location = New System.Drawing.Point(6, 24)
        Me.cmdFactor.Name = "cmdFactor"
        Me.cmdFactor.Size = New System.Drawing.Size(90, 48)
        Me.cmdFactor.TabIndex = 191
        Me.cmdFactor.Text = "factor"
        Me.cmdFactor.UseVisualStyleBackColor = True
        '
        'cmdAnon
        '
        Me.cmdAnon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnon.Location = New System.Drawing.Point(96, 24)
        Me.cmdAnon.Name = "cmdAnon"
        Me.cmdAnon.Size = New System.Drawing.Size(90, 48)
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
        Me.grpHydroGOF.Location = New System.Drawing.Point(651, 92)
        Me.grpHydroGOF.Name = "grpHydroGOF"
        Me.grpHydroGOF.Size = New System.Drawing.Size(274, 404)
        Me.grpHydroGOF.TabIndex = 195
        Me.grpHydroGOF.TabStop = False
        Me.grpHydroGOF.Text = "hydroGOF "
        '
        'cmdHydroHelp
        '
        Me.cmdHydroHelp.AutoSize = True
        Me.cmdHydroHelp.ContextMenuStrip = Me.ContextMenuStripHydroGOF
        Me.cmdHydroHelp.Location = New System.Drawing.Point(166, 358)
        Me.cmdHydroHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHydroHelp.Name = "cmdHydroHelp"
        Me.cmdHydroHelp.Size = New System.Drawing.Size(129, 45)
        Me.cmdHydroHelp.SplitMenuStrip = Me.ContextMenuStripHydroGOF
        Me.cmdHydroHelp.TabIndex = 212
        Me.cmdHydroHelp.Text = "R Help"
        Me.cmdHydroHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripHydroGOF
        '
        Me.ContextMenuStripHydroGOF.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripHydroGOF.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HydroGOFToolStripMenuItem})
        Me.ContextMenuStripHydroGOF.Name = "ContextMenuStrip1"
        Me.ContextMenuStripHydroGOF.Size = New System.Drawing.Size(167, 36)
        '
        'HydroGOFToolStripMenuItem
        '
        Me.HydroGOFToolStripMenuItem.Name = "HydroGOFToolStripMenuItem"
        Me.HydroGOFToolStripMenuItem.Size = New System.Drawing.Size(166, 32)
        Me.HydroGOFToolStripMenuItem.Text = "hydroGOF"
        '
        'cmdVE
        '
        Me.cmdVE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVE.Location = New System.Drawing.Point(180, 309)
        Me.cmdVE.Name = "cmdVE"
        Me.cmdVE.Size = New System.Drawing.Size(90, 48)
        Me.cmdVE.TabIndex = 20
        Me.cmdVE.Text = "VE"
        Me.cmdVE.UseVisualStyleBackColor = True
        '
        'cmdSsq
        '
        Me.cmdSsq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSsq.Location = New System.Drawing.Point(92, 309)
        Me.cmdSsq.Name = "cmdSsq"
        Me.cmdSsq.Size = New System.Drawing.Size(90, 48)
        Me.cmdSsq.TabIndex = 19
        Me.cmdSsq.Text = "ssq"
        Me.cmdSsq.UseVisualStyleBackColor = True
        '
        'cmdRsr
        '
        Me.cmdRsr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRsr.Location = New System.Drawing.Point(3, 309)
        Me.cmdRsr.Name = "cmdRsr"
        Me.cmdRsr.Size = New System.Drawing.Size(90, 48)
        Me.cmdRsr.TabIndex = 18
        Me.cmdRsr.Text = "rsr"
        Me.cmdRsr.UseVisualStyleBackColor = True
        '
        'cmdRSD
        '
        Me.cmdRSD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRSD.Location = New System.Drawing.Point(180, 262)
        Me.cmdRSD.Name = "cmdRSD"
        Me.cmdRSD.Size = New System.Drawing.Size(90, 48)
        Me.cmdRSD.TabIndex = 17
        Me.cmdRSD.Text = "rSD"
        Me.cmdRSD.UseVisualStyleBackColor = True
        '
        'cmdRPearson
        '
        Me.cmdRPearson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRPearson.Location = New System.Drawing.Point(92, 262)
        Me.cmdRPearson.Name = "cmdRPearson"
        Me.cmdRPearson.Size = New System.Drawing.Size(90, 48)
        Me.cmdRPearson.TabIndex = 16
        Me.cmdRPearson.Text = "rPearson"
        Me.cmdRPearson.UseVisualStyleBackColor = True
        '
        'cmdRNSE
        '
        Me.cmdRNSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRNSE.Location = New System.Drawing.Point(3, 262)
        Me.cmdRNSE.Name = "cmdRNSE"
        Me.cmdRNSE.Size = New System.Drawing.Size(90, 48)
        Me.cmdRNSE.TabIndex = 15
        Me.cmdRNSE.Text = "rNSE"
        Me.cmdRNSE.UseVisualStyleBackColor = True
        '
        'cmdRmse
        '
        Me.cmdRmse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRmse.Location = New System.Drawing.Point(180, 214)
        Me.cmdRmse.Name = "cmdRmse"
        Me.cmdRmse.Size = New System.Drawing.Size(90, 48)
        Me.cmdRmse.TabIndex = 14
        Me.cmdRmse.Text = "rmse"
        Me.cmdRmse.UseVisualStyleBackColor = True
        '
        'cmdRd
        '
        Me.cmdRd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRd.Location = New System.Drawing.Point(92, 214)
        Me.cmdRd.Name = "cmdRd"
        Me.cmdRd.Size = New System.Drawing.Size(90, 48)
        Me.cmdRd.TabIndex = 13
        Me.cmdRd.Text = "rd"
        Me.cmdRd.UseVisualStyleBackColor = True
        '
        'cmdPbiasfde
        '
        Me.cmdPbiasfde.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbiasfde.Location = New System.Drawing.Point(3, 214)
        Me.cmdPbiasfde.Name = "cmdPbiasfde"
        Me.cmdPbiasfde.Size = New System.Drawing.Size(90, 48)
        Me.cmdPbiasfde.TabIndex = 12
        Me.cmdPbiasfde.Text = "pbiasfdc"
        Me.cmdPbiasfde.UseVisualStyleBackColor = True
        '
        'cmdPbias
        '
        Me.cmdPbias.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbias.Location = New System.Drawing.Point(180, 166)
        Me.cmdPbias.Name = "cmdPbias"
        Me.cmdPbias.Size = New System.Drawing.Size(90, 48)
        Me.cmdPbias.TabIndex = 11
        Me.cmdPbias.Text = "pbias"
        Me.cmdPbias.UseVisualStyleBackColor = True
        '
        'cmdNSE
        '
        Me.cmdNSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNSE.Location = New System.Drawing.Point(92, 166)
        Me.cmdNSE.Name = "cmdNSE"
        Me.cmdNSE.Size = New System.Drawing.Size(90, 48)
        Me.cmdNSE.TabIndex = 10
        Me.cmdNSE.Text = "NSE"
        Me.cmdNSE.UseVisualStyleBackColor = True
        '
        'cmdNrmse
        '
        Me.cmdNrmse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNrmse.Location = New System.Drawing.Point(3, 166)
        Me.cmdNrmse.Name = "cmdNrmse"
        Me.cmdNrmse.Size = New System.Drawing.Size(90, 48)
        Me.cmdNrmse.TabIndex = 9
        Me.cmdNrmse.Text = "nrmse"
        Me.cmdNrmse.UseVisualStyleBackColor = True
        '
        'cmdMse
        '
        Me.cmdMse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMse.Location = New System.Drawing.Point(180, 120)
        Me.cmdMse.Name = "cmdMse"
        Me.cmdMse.Size = New System.Drawing.Size(90, 48)
        Me.cmdMse.TabIndex = 8
        Me.cmdMse.Text = "mse"
        Me.cmdMse.UseVisualStyleBackColor = True
        '
        'cmdmNSE
        '
        Me.cmdmNSE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdmNSE.Location = New System.Drawing.Point(92, 120)
        Me.cmdmNSE.Name = "cmdmNSE"
        Me.cmdmNSE.Size = New System.Drawing.Size(90, 48)
        Me.cmdmNSE.TabIndex = 7
        Me.cmdmNSE.Text = "mNSE"
        Me.cmdmNSE.UseVisualStyleBackColor = True
        '
        'cmdMe
        '
        Me.cmdMe.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMe.Location = New System.Drawing.Point(3, 120)
        Me.cmdMe.Name = "cmdMe"
        Me.cmdMe.Size = New System.Drawing.Size(90, 48)
        Me.cmdMe.TabIndex = 6
        Me.cmdMe.Text = "me"
        Me.cmdMe.UseVisualStyleBackColor = True
        '
        'cmdMd
        '
        Me.cmdMd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMd.Location = New System.Drawing.Point(180, 72)
        Me.cmdMd.Name = "cmdMd"
        Me.cmdMd.Size = New System.Drawing.Size(90, 48)
        Me.cmdMd.TabIndex = 5
        Me.cmdMd.Text = "md"
        Me.cmdMd.UseVisualStyleBackColor = True
        '
        'cmdMae
        '
        Me.cmdMae.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMae.Location = New System.Drawing.Point(92, 72)
        Me.cmdMae.Name = "cmdMae"
        Me.cmdMae.Size = New System.Drawing.Size(90, 48)
        Me.cmdMae.TabIndex = 4
        Me.cmdMae.Text = "mae"
        Me.cmdMae.UseVisualStyleBackColor = True
        '
        'cmdKGE
        '
        Me.cmdKGE.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKGE.Location = New System.Drawing.Point(3, 72)
        Me.cmdKGE.Name = "cmdKGE"
        Me.cmdKGE.Size = New System.Drawing.Size(90, 48)
        Me.cmdKGE.TabIndex = 3
        Me.cmdKGE.Text = "KGE"
        Me.cmdKGE.UseVisualStyleBackColor = True
        '
        'cmdD
        '
        Me.cmdD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdD.Location = New System.Drawing.Point(180, 24)
        Me.cmdD.Name = "cmdD"
        Me.cmdD.Size = New System.Drawing.Size(90, 48)
        Me.cmdD.TabIndex = 2
        Me.cmdD.Text = "d"
        Me.cmdD.UseVisualStyleBackColor = True
        '
        'cmdCp
        '
        Me.cmdCp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCp.Location = New System.Drawing.Point(92, 24)
        Me.cmdCp.Name = "cmdCp"
        Me.cmdCp.Size = New System.Drawing.Size(90, 48)
        Me.cmdCp.TabIndex = 1
        Me.cmdCp.Text = "cp"
        Me.cmdCp.UseVisualStyleBackColor = True
        '
        'cmdBr2
        '
        Me.cmdBr2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBr2.Location = New System.Drawing.Point(3, 24)
        Me.cmdBr2.Name = "cmdBr2"
        Me.cmdBr2.Size = New System.Drawing.Size(90, 48)
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
        Me.grpWakefield.Location = New System.Drawing.Point(650, 93)
        Me.grpWakefield.Margin = New System.Windows.Forms.Padding(4)
        Me.grpWakefield.Name = "grpWakefield"
        Me.grpWakefield.Padding = New System.Windows.Forms.Padding(4)
        Me.grpWakefield.Size = New System.Drawing.Size(652, 519)
        Me.grpWakefield.TabIndex = 191
        Me.grpWakefield.TabStop = False
        Me.grpWakefield.Text = "Wakefield"
        '
        'cmdLinkert7
        '
        Me.cmdLinkert7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLinkert7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLinkert7.Location = New System.Drawing.Point(512, 459)
        Me.cmdLinkert7.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLinkert7.Name = "cmdLinkert7"
        Me.cmdLinkert7.Size = New System.Drawing.Size(128, 45)
        Me.cmdLinkert7.TabIndex = 54
        Me.cmdLinkert7.Text = "linkert7 (o.f)"
        Me.cmdLinkert7.UseVisualStyleBackColor = True
        '
        'cmdWakefield_Year
        '
        Me.cmdWakefield_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdWakefield_Year.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefield_Year.Location = New System.Drawing.Point(386, 459)
        Me.cmdWakefield_Year.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWakefield_Year.Name = "cmdWakefield_Year"
        Me.cmdWakefield_Year.Size = New System.Drawing.Size(128, 45)
        Me.cmdWakefield_Year.TabIndex = 53
        Me.cmdWakefield_Year.Text = "year"
        Me.cmdWakefield_Year.UseVisualStyleBackColor = True
        '
        'cmdValid
        '
        Me.cmdValid.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdValid.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdValid.Location = New System.Drawing.Point(260, 459)
        Me.cmdValid.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdValid.Name = "cmdValid"
        Me.cmdValid.Size = New System.Drawing.Size(128, 45)
        Me.cmdValid.TabIndex = 52
        Me.cmdValid.Text = "valid (L)"
        Me.cmdValid.UseVisualStyleBackColor = True
        '
        'cmdWakefield_Upper
        '
        Me.cmdWakefield_Upper.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdWakefield_Upper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefield_Upper.Location = New System.Drawing.Point(134, 459)
        Me.cmdWakefield_Upper.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWakefield_Upper.Name = "cmdWakefield_Upper"
        Me.cmdWakefield_Upper.Size = New System.Drawing.Size(128, 45)
        Me.cmdWakefield_Upper.TabIndex = 51
        Me.cmdWakefield_Upper.Text = "upper (c)"
        Me.cmdWakefield_Upper.UseVisualStyleBackColor = True
        '
        'cmdString
        '
        Me.cmdString.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdString.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdString.Location = New System.Drawing.Point(8, 459)
        Me.cmdString.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdString.Name = "cmdString"
        Me.cmdString.Size = New System.Drawing.Size(128, 45)
        Me.cmdString.TabIndex = 50
        Me.cmdString.Text = "string (c)"
        Me.cmdString.UseVisualStyleBackColor = True
        '
        'cmdState
        '
        Me.cmdState.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdState.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdState.Location = New System.Drawing.Point(512, 416)
        Me.cmdState.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdState.Name = "cmdState"
        Me.cmdState.Size = New System.Drawing.Size(128, 45)
        Me.cmdState.TabIndex = 49
        Me.cmdState.Text = "state (f)"
        Me.cmdState.UseVisualStyleBackColor = True
        '
        'cmdSpeed
        '
        Me.cmdSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSpeed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSpeed.Location = New System.Drawing.Point(386, 416)
        Me.cmdSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSpeed.Name = "cmdSpeed"
        Me.cmdSpeed.Size = New System.Drawing.Size(128, 45)
        Me.cmdSpeed.TabIndex = 48
        Me.cmdSpeed.Text = "speed"
        Me.cmdSpeed.UseVisualStyleBackColor = True
        '
        'cmdSmokes
        '
        Me.cmdSmokes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSmokes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSmokes.Location = New System.Drawing.Point(260, 416)
        Me.cmdSmokes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSmokes.Name = "cmdSmokes"
        Me.cmdSmokes.Size = New System.Drawing.Size(128, 45)
        Me.cmdSmokes.TabIndex = 47
        Me.cmdSmokes.Text = "smokes (L)"
        Me.cmdSmokes.UseVisualStyleBackColor = True
        '
        'cmdSex
        '
        Me.cmdSex.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSex.Location = New System.Drawing.Point(134, 416)
        Me.cmdSex.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSex.Name = "cmdSex"
        Me.cmdSex.Size = New System.Drawing.Size(128, 45)
        Me.cmdSex.TabIndex = 46
        Me.cmdSex.Text = "sex (f)"
        Me.cmdSex.UseVisualStyleBackColor = True
        '
        'cmdSex_Inclusive
        '
        Me.cmdSex_Inclusive.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSex_Inclusive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSex_Inclusive.Location = New System.Drawing.Point(8, 416)
        Me.cmdSex_Inclusive.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSex_Inclusive.Name = "cmdSex_Inclusive"
        Me.cmdSex_Inclusive.Size = New System.Drawing.Size(128, 45)
        Me.cmdSex_Inclusive.TabIndex = 45
        Me.cmdSex_Inclusive.Text = "sex_inclusive (f)"
        Me.cmdSex_Inclusive.UseVisualStyleBackColor = True
        '
        'cmdGender
        '
        Me.cmdGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGender.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGender.Location = New System.Drawing.Point(512, 372)
        Me.cmdGender.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGender.Name = "cmdGender"
        Me.cmdGender.Size = New System.Drawing.Size(128, 45)
        Me.cmdGender.TabIndex = 44
        Me.cmdGender.Text = "gender (f)"
        Me.cmdGender.UseVisualStyleBackColor = True
        '
        'cmdSentence
        '
        Me.cmdSentence.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSentence.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSentence.Location = New System.Drawing.Point(386, 372)
        Me.cmdSentence.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSentence.Name = "cmdSentence"
        Me.cmdSentence.Size = New System.Drawing.Size(128, 45)
        Me.cmdSentence.TabIndex = 43
        Me.cmdSentence.Text = "sentence (c)"
        Me.cmdSentence.UseVisualStyleBackColor = True
        '
        'cmdSat
        '
        Me.cmdSat.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdSat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSat.Location = New System.Drawing.Point(260, 372)
        Me.cmdSat.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSat.Name = "cmdSat"
        Me.cmdSat.Size = New System.Drawing.Size(128, 45)
        Me.cmdSat.TabIndex = 42
        Me.cmdSat.Text = "sat"
        Me.cmdSat.UseVisualStyleBackColor = True
        '
        'cmdReligion
        '
        Me.cmdReligion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdReligion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReligion.Location = New System.Drawing.Point(134, 372)
        Me.cmdReligion.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdReligion.Name = "cmdReligion"
        Me.cmdReligion.Size = New System.Drawing.Size(128, 45)
        Me.cmdReligion.TabIndex = 41
        Me.cmdReligion.Text = "religion (f)"
        Me.cmdReligion.UseVisualStyleBackColor = True
        '
        'cmdRace
        '
        Me.cmdRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdRace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRace.Location = New System.Drawing.Point(8, 372)
        Me.cmdRace.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRace.Name = "cmdRace"
        Me.cmdRace.Size = New System.Drawing.Size(128, 45)
        Me.cmdRace.TabIndex = 40
        Me.cmdRace.Text = "race (f)"
        Me.cmdRace.UseVisualStyleBackColor = True
        '
        'cmdPolitical
        '
        Me.cmdPolitical.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdPolitical.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPolitical.Location = New System.Drawing.Point(512, 328)
        Me.cmdPolitical.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPolitical.Name = "cmdPolitical"
        Me.cmdPolitical.Size = New System.Drawing.Size(128, 45)
        Me.cmdPolitical.TabIndex = 39
        Me.cmdPolitical.Text = "political (f)"
        Me.cmdPolitical.UseVisualStyleBackColor = True
        '
        'cmdNormal
        '
        Me.cmdNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdNormal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNormal.Location = New System.Drawing.Point(386, 328)
        Me.cmdNormal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNormal.Name = "cmdNormal"
        Me.cmdNormal.Size = New System.Drawing.Size(128, 45)
        Me.cmdNormal.TabIndex = 38
        Me.cmdNormal.Text = "normal"
        Me.cmdNormal.UseVisualStyleBackColor = True
        '
        'cmdName
        '
        Me.cmdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdName.Location = New System.Drawing.Point(260, 328)
        Me.cmdName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdName.Name = "cmdName"
        Me.cmdName.Size = New System.Drawing.Size(128, 45)
        Me.cmdName.TabIndex = 37
        Me.cmdName.Text = "name (c)"
        Me.cmdName.UseVisualStyleBackColor = True
        '
        'cmdWakefield_Month
        '
        Me.cmdWakefield_Month.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdWakefield_Month.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWakefield_Month.Location = New System.Drawing.Point(134, 328)
        Me.cmdWakefield_Month.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWakefield_Month.Name = "cmdWakefield_Month"
        Me.cmdWakefield_Month.Size = New System.Drawing.Size(128, 45)
        Me.cmdWakefield_Month.TabIndex = 36
        Me.cmdWakefield_Month.Text = "month (f)"
        Me.cmdWakefield_Month.UseVisualStyleBackColor = True
        '
        'cmdMilitary
        '
        Me.cmdMilitary.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdMilitary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMilitary.Location = New System.Drawing.Point(8, 328)
        Me.cmdMilitary.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMilitary.Name = "cmdMilitary"
        Me.cmdMilitary.Size = New System.Drawing.Size(128, 45)
        Me.cmdMilitary.TabIndex = 35
        Me.cmdMilitary.Text = "military (f)"
        Me.cmdMilitary.UseVisualStyleBackColor = True
        '
        'cmdMarital
        '
        Me.cmdMarital.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdMarital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMarital.Location = New System.Drawing.Point(512, 284)
        Me.cmdMarital.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMarital.Name = "cmdMarital"
        Me.cmdMarital.Size = New System.Drawing.Size(128, 45)
        Me.cmdMarital.TabIndex = 34
        Me.cmdMarital.Text = "marital (f)"
        Me.cmdMarital.UseVisualStyleBackColor = True
        '
        'cmdLorem_ipsum
        '
        Me.cmdLorem_ipsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLorem_ipsum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLorem_ipsum.Location = New System.Drawing.Point(386, 284)
        Me.cmdLorem_ipsum.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLorem_ipsum.Name = "cmdLorem_ipsum"
        Me.cmdLorem_ipsum.Size = New System.Drawing.Size(128, 45)
        Me.cmdLorem_ipsum.TabIndex = 33
        Me.cmdLorem_ipsum.Text = "lorem_ipsum (c)"
        Me.cmdLorem_ipsum.UseVisualStyleBackColor = True
        '
        'cmdLikert
        '
        Me.cmdLikert.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLikert.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLikert.Location = New System.Drawing.Point(260, 284)
        Me.cmdLikert.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLikert.Name = "cmdLikert"
        Me.cmdLikert.Size = New System.Drawing.Size(128, 45)
        Me.cmdLikert.TabIndex = 32
        Me.cmdLikert.Text = "likert (o.f)"
        Me.cmdLikert.UseVisualStyleBackColor = True
        '
        'cmdGpa
        '
        Me.cmdGpa.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGpa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGpa.Location = New System.Drawing.Point(134, 284)
        Me.cmdGpa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGpa.Name = "cmdGpa"
        Me.cmdGpa.Size = New System.Drawing.Size(128, 45)
        Me.cmdGpa.TabIndex = 31
        Me.cmdGpa.Text = "gpa"
        Me.cmdGpa.UseVisualStyleBackColor = True
        '
        'cmdEla
        '
        Me.cmdEla.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEla.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEla.Location = New System.Drawing.Point(8, 284)
        Me.cmdEla.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEla.Name = "cmdEla"
        Me.cmdEla.Size = New System.Drawing.Size(128, 45)
        Me.cmdEla.TabIndex = 30
        Me.cmdEla.Text = "ela"
        Me.cmdEla.UseVisualStyleBackColor = True
        '
        'cmdMath
        '
        Me.cmdMath.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdMath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMath.Location = New System.Drawing.Point(512, 240)
        Me.cmdMath.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMath.Name = "cmdMath"
        Me.cmdMath.Size = New System.Drawing.Size(128, 45)
        Me.cmdMath.TabIndex = 29
        Me.cmdMath.Text = "math"
        Me.cmdMath.UseVisualStyleBackColor = True
        '
        'cmdLevel
        '
        Me.cmdLevel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLevel.Location = New System.Drawing.Point(386, 240)
        Me.cmdLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLevel.Name = "cmdLevel"
        Me.cmdLevel.Size = New System.Drawing.Size(128, 45)
        Me.cmdLevel.TabIndex = 28
        Me.cmdLevel.Text = "level"
        Me.cmdLevel.UseVisualStyleBackColor = True
        '
        'cmdLanguage
        '
        Me.cmdLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdLanguage.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLanguage.Location = New System.Drawing.Point(260, 240)
        Me.cmdLanguage.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLanguage.Name = "cmdLanguage"
        Me.cmdLanguage.Size = New System.Drawing.Size(128, 45)
        Me.cmdLanguage.TabIndex = 27
        Me.cmdLanguage.Text = "language (f)"
        Me.cmdLanguage.UseVisualStyleBackColor = True
        '
        'cmdIq
        '
        Me.cmdIq.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdIq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIq.Location = New System.Drawing.Point(134, 240)
        Me.cmdIq.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIq.Name = "cmdIq"
        Me.cmdIq.Size = New System.Drawing.Size(128, 45)
        Me.cmdIq.TabIndex = 26
        Me.cmdIq.Text = "iq"
        Me.cmdIq.UseVisualStyleBackColor = True
        '
        'cmdInternet_Browser
        '
        Me.cmdInternet_Browser.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdInternet_Browser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdInternet_Browser.Location = New System.Drawing.Point(8, 240)
        Me.cmdInternet_Browser.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdInternet_Browser.Name = "cmdInternet_Browser"
        Me.cmdInternet_Browser.Size = New System.Drawing.Size(128, 45)
        Me.cmdInternet_Browser.TabIndex = 25
        Me.cmdInternet_Browser.Text = "browser (f)"
        Me.cmdInternet_Browser.UseVisualStyleBackColor = True
        '
        'cmdGrade_Level
        '
        Me.cmdGrade_Level.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGrade_Level.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGrade_Level.Location = New System.Drawing.Point(512, 153)
        Me.cmdGrade_Level.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrade_Level.Name = "cmdGrade_Level"
        Me.cmdGrade_Level.Size = New System.Drawing.Size(128, 45)
        Me.cmdGrade_Level.TabIndex = 19
        Me.cmdGrade_Level.Text = "grade_level (f)"
        Me.cmdGrade_Level.UseVisualStyleBackColor = True
        '
        'cmdEye
        '
        Me.cmdEye.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEye.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEye.Location = New System.Drawing.Point(386, 153)
        Me.cmdEye.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEye.Name = "cmdEye"
        Me.cmdEye.Size = New System.Drawing.Size(128, 45)
        Me.cmdEye.TabIndex = 18
        Me.cmdEye.Text = "eye (f)"
        Me.cmdEye.UseVisualStyleBackColor = True
        '
        'cmdEmployment
        '
        Me.cmdEmployment.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEmployment.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEmployment.Location = New System.Drawing.Point(260, 153)
        Me.cmdEmployment.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEmployment.Name = "cmdEmployment"
        Me.cmdEmployment.Size = New System.Drawing.Size(128, 45)
        Me.cmdEmployment.TabIndex = 17
        Me.cmdEmployment.Text = "employment (f)"
        Me.cmdEmployment.UseVisualStyleBackColor = True
        '
        'cmdEducation
        '
        Me.cmdEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdEducation.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEducation.Location = New System.Drawing.Point(134, 153)
        Me.cmdEducation.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEducation.Name = "cmdEducation"
        Me.cmdEducation.Size = New System.Drawing.Size(128, 45)
        Me.cmdEducation.TabIndex = 16
        Me.cmdEducation.Text = "education (f)"
        Me.cmdEducation.UseVisualStyleBackColor = True
        '
        'cmdDummy
        '
        Me.cmdDummy.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDummy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDummy.Location = New System.Drawing.Point(8, 153)
        Me.cmdDummy.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDummy.Name = "cmdDummy"
        Me.cmdDummy.Size = New System.Drawing.Size(128, 45)
        Me.cmdDummy.TabIndex = 15
        Me.cmdDummy.Text = "dummy"
        Me.cmdDummy.UseVisualStyleBackColor = True
        '
        'cmdDob
        '
        Me.cmdDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDob.Location = New System.Drawing.Point(512, 108)
        Me.cmdDob.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDob.Name = "cmdDob"
        Me.cmdDob.Size = New System.Drawing.Size(128, 45)
        Me.cmdDob.TabIndex = 14
        Me.cmdDob.Text = "dob (D)"
        Me.cmdDob.UseVisualStyleBackColor = True
        '
        'cmdDna
        '
        Me.cmdDna.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDna.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDna.Location = New System.Drawing.Point(386, 108)
        Me.cmdDna.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDna.Name = "cmdDna"
        Me.cmdDna.Size = New System.Drawing.Size(128, 45)
        Me.cmdDna.TabIndex = 13
        Me.cmdDna.Text = "dna (f)"
        Me.cmdDna.UseVisualStyleBackColor = True
        '
        'cmdDice
        '
        Me.cmdDice.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDice.Location = New System.Drawing.Point(260, 108)
        Me.cmdDice.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDice.Name = "cmdDice"
        Me.cmdDice.Size = New System.Drawing.Size(128, 45)
        Me.cmdDice.TabIndex = 12
        Me.cmdDice.Text = "dice"
        Me.cmdDice.UseVisualStyleBackColor = True
        '
        'cmdDied
        '
        Me.cmdDied.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDied.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDied.Location = New System.Drawing.Point(134, 108)
        Me.cmdDied.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDied.Name = "cmdDied"
        Me.cmdDied.Size = New System.Drawing.Size(128, 45)
        Me.cmdDied.TabIndex = 11
        Me.cmdDied.Text = "died (L)"
        Me.cmdDied.UseVisualStyleBackColor = True
        '
        'cmdDeath
        '
        Me.cmdDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDeath.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDeath.Location = New System.Drawing.Point(8, 108)
        Me.cmdDeath.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDeath.Name = "cmdDeath"
        Me.cmdDeath.Size = New System.Drawing.Size(128, 45)
        Me.cmdDeath.TabIndex = 10
        Me.cmdDeath.Text = "death (L)"
        Me.cmdDeath.UseVisualStyleBackColor = True
        '
        'cmdDate_Stamp
        '
        Me.cmdDate_Stamp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdDate_Stamp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDate_Stamp.Location = New System.Drawing.Point(512, 64)
        Me.cmdDate_Stamp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDate_Stamp.Name = "cmdDate_Stamp"
        Me.cmdDate_Stamp.Size = New System.Drawing.Size(128, 45)
        Me.cmdDate_Stamp.TabIndex = 9
        Me.cmdDate_Stamp.Text = "date_stamp"
        Me.cmdDate_Stamp.UseVisualStyleBackColor = True
        '
        'cmdPrimary
        '
        Me.cmdPrimary.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdPrimary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPrimary.Location = New System.Drawing.Point(386, 64)
        Me.cmdPrimary.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrimary.Name = "cmdPrimary"
        Me.cmdPrimary.Size = New System.Drawing.Size(128, 45)
        Me.cmdPrimary.TabIndex = 8
        Me.cmdPrimary.Text = "primary (f)"
        Me.cmdPrimary.UseVisualStyleBackColor = True
        '
        'cmdColor
        '
        Me.cmdColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdColor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColor.Location = New System.Drawing.Point(260, 64)
        Me.cmdColor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.Size = New System.Drawing.Size(128, 45)
        Me.cmdColor.TabIndex = 7
        Me.cmdColor.Text = "color (f)"
        Me.cmdColor.UseVisualStyleBackColor = True
        '
        'cmdCoin
        '
        Me.cmdCoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdCoin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCoin.Location = New System.Drawing.Point(134, 64)
        Me.cmdCoin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCoin.Name = "cmdCoin"
        Me.cmdCoin.Size = New System.Drawing.Size(128, 45)
        Me.cmdCoin.TabIndex = 6
        Me.cmdCoin.Text = "coin (f)"
        Me.cmdCoin.UseVisualStyleBackColor = True
        '
        'cmdChildren
        '
        Me.cmdChildren.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdChildren.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChildren.Location = New System.Drawing.Point(8, 64)
        Me.cmdChildren.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdChildren.Name = "cmdChildren"
        Me.cmdChildren.Size = New System.Drawing.Size(128, 45)
        Me.cmdChildren.TabIndex = 5
        Me.cmdChildren.Text = "children"
        Me.cmdChildren.UseVisualStyleBackColor = True
        '
        'cmdCar
        '
        Me.cmdCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdCar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCar.Location = New System.Drawing.Point(512, 21)
        Me.cmdCar.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCar.Name = "cmdCar"
        Me.cmdCar.Size = New System.Drawing.Size(128, 45)
        Me.cmdCar.TabIndex = 4
        Me.cmdCar.Text = "car (f)"
        Me.cmdCar.UseVisualStyleBackColor = True
        '
        'cmdAnswer
        '
        Me.cmdAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdAnswer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnswer.Location = New System.Drawing.Point(386, 21)
        Me.cmdAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAnswer.Name = "cmdAnswer"
        Me.cmdAnswer.Size = New System.Drawing.Size(128, 45)
        Me.cmdAnswer.TabIndex = 3
        Me.cmdAnswer.Text = "answer (f)"
        Me.cmdAnswer.UseVisualStyleBackColor = True
        '
        'cmdPet
        '
        Me.cmdPet.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdPet.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPet.Location = New System.Drawing.Point(260, 21)
        Me.cmdPet.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPet.Name = "cmdPet"
        Me.cmdPet.Size = New System.Drawing.Size(128, 45)
        Me.cmdPet.TabIndex = 2
        Me.cmdPet.Text = "pet (f)"
        Me.cmdPet.UseVisualStyleBackColor = True
        '
        'cmdAnimal
        '
        Me.cmdAnimal.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdAnimal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnimal.Location = New System.Drawing.Point(134, 21)
        Me.cmdAnimal.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAnimal.Name = "cmdAnimal"
        Me.cmdAnimal.Size = New System.Drawing.Size(128, 45)
        Me.cmdAnimal.TabIndex = 1
        Me.cmdAnimal.Text = "animal (f)"
        Me.cmdAnimal.UseVisualStyleBackColor = True
        '
        'cmdAge
        '
        Me.cmdAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAge.Location = New System.Drawing.Point(8, 21)
        Me.cmdAge.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAge.Name = "cmdAge"
        Me.cmdAge.Size = New System.Drawing.Size(128, 45)
        Me.cmdAge.TabIndex = 0
        Me.cmdAge.Text = "age"
        Me.cmdAge.UseVisualStyleBackColor = True
        '
        'cmdIncome
        '
        Me.cmdIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIncome.Location = New System.Drawing.Point(512, 196)
        Me.cmdIncome.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIncome.Name = "cmdIncome"
        Me.cmdIncome.Size = New System.Drawing.Size(128, 45)
        Me.cmdIncome.TabIndex = 24
        Me.cmdIncome.Text = "income"
        Me.cmdIncome.UseVisualStyleBackColor = True
        '
        'cmdHeight
        '
        Me.cmdHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdHeight.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHeight.Location = New System.Drawing.Point(386, 196)
        Me.cmdHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHeight.Name = "cmdHeight"
        Me.cmdHeight.Size = New System.Drawing.Size(128, 45)
        Me.cmdHeight.TabIndex = 23
        Me.cmdHeight.Text = "height"
        Me.cmdHeight.UseVisualStyleBackColor = True
        '
        'cmdHair
        '
        Me.cmdHair.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdHair.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdHair.Location = New System.Drawing.Point(260, 196)
        Me.cmdHair.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdHair.Name = "cmdHair"
        Me.cmdHair.Size = New System.Drawing.Size(128, 45)
        Me.cmdHair.TabIndex = 22
        Me.cmdHair.Text = "hair (f)"
        Me.cmdHair.UseVisualStyleBackColor = True
        '
        'cmdGroup
        '
        Me.cmdGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGroup.Location = New System.Drawing.Point(134, 196)
        Me.cmdGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGroup.Name = "cmdGroup"
        Me.cmdGroup.Size = New System.Drawing.Size(128, 45)
        Me.cmdGroup.TabIndex = 21
        Me.cmdGroup.Text = "group (f)"
        Me.cmdGroup.UseVisualStyleBackColor = True
        '
        'cmdGrade
        '
        Me.cmdGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!)
        Me.cmdGrade.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGrade.Location = New System.Drawing.Point(8, 196)
        Me.cmdGrade.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdGrade.Name = "cmdGrade"
        Me.cmdGrade.Size = New System.Drawing.Size(128, 45)
        Me.cmdGrade.TabIndex = 20
        Me.cmdGrade.Text = "grade"
        Me.cmdGrade.UseVisualStyleBackColor = True
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
        Me.grpMaths.Location = New System.Drawing.Point(650, 93)
        Me.grpMaths.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMaths.Name = "grpMaths"
        Me.grpMaths.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpMaths.Size = New System.Drawing.Size(384, 246)
        Me.grpMaths.TabIndex = 184
        Me.grpMaths.TabStop = False
        Me.grpMaths.Text = "Maths"
        '
        'cmdMathsHelp
        '
        Me.cmdMathsHelp.AutoSize = True
        Me.cmdMathsHelp.ContextMenuStrip = Me.ContextMenuStripMaths
        Me.cmdMathsHelp.Location = New System.Drawing.Point(264, 198)
        Me.cmdMathsHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMathsHelp.Name = "cmdMathsHelp"
        Me.cmdMathsHelp.Size = New System.Drawing.Size(129, 45)
        Me.cmdMathsHelp.SplitMenuStrip = Me.ContextMenuStripMaths
        Me.cmdMathsHelp.TabIndex = 211
        Me.cmdMathsHelp.Text = "R Help"
        Me.cmdMathsHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripMaths
        '
        Me.ContextMenuStripMaths.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripMaths.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MathsStatsStripMenuItem})
        Me.ContextMenuStripMaths.Name = "ContextMenuStrip1"
        Me.ContextMenuStripMaths.Size = New System.Drawing.Size(122, 36)
        '
        'MathsStatsStripMenuItem
        '
        Me.MathsStatsStripMenuItem.Name = "MathsStatsStripMenuItem"
        Me.MathsStatsStripMenuItem.Size = New System.Drawing.Size(121, 32)
        Me.MathsStatsStripMenuItem.Text = "stats"
        '
        'cmdAtan2
        '
        Me.cmdAtan2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAtan2.Location = New System.Drawing.Point(153, 195)
        Me.cmdAtan2.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAtan2.Name = "cmdAtan2"
        Me.cmdAtan2.Size = New System.Drawing.Size(76, 45)
        Me.cmdAtan2.TabIndex = 151
        Me.cmdAtan2.Text = "atan2"
        Me.cmdAtan2.UseVisualStyleBackColor = True
        '
        'cmdLogistic
        '
        Me.cmdLogistic.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogistic.Location = New System.Drawing.Point(78, 195)
        Me.cmdLogistic.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLogistic.Name = "cmdLogistic"
        Me.cmdLogistic.Size = New System.Drawing.Size(76, 45)
        Me.cmdLogistic.TabIndex = 149
        Me.cmdLogistic.Text = "logistic"
        Me.cmdLogistic.UseVisualStyleBackColor = True
        '
        'cmdLogit
        '
        Me.cmdLogit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogit.Location = New System.Drawing.Point(3, 195)
        Me.cmdLogit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLogit.Name = "cmdLogit"
        Me.cmdLogit.Size = New System.Drawing.Size(76, 45)
        Me.cmdLogit.TabIndex = 148
        Me.cmdLogit.Text = "logit"
        Me.cmdLogit.UseVisualStyleBackColor = True
        '
        'cmdSign
        '
        Me.cmdSign.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSign.Location = New System.Drawing.Point(304, 152)
        Me.cmdSign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.Size = New System.Drawing.Size(76, 45)
        Me.cmdSign.TabIndex = 147
        Me.cmdSign.Text = "sign"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmdRound
        '
        Me.cmdRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRound.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRound.Location = New System.Drawing.Point(230, 152)
        Me.cmdRound.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRound.Name = "cmdRound"
        Me.cmdRound.Size = New System.Drawing.Size(76, 45)
        Me.cmdRound.TabIndex = 146
        Me.cmdRound.Text = "round"
        Me.cmdRound.UseVisualStyleBackColor = True
        '
        'cmdSiginf
        '
        Me.cmdSiginf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSiginf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSiginf.Location = New System.Drawing.Point(154, 152)
        Me.cmdSiginf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSiginf.Name = "cmdSiginf"
        Me.cmdSiginf.Size = New System.Drawing.Size(76, 45)
        Me.cmdSiginf.TabIndex = 145
        Me.cmdSiginf.Text = "siginf"
        Me.cmdSiginf.UseVisualStyleBackColor = True
        '
        'cmdAbs
        '
        Me.cmdAbs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAbs.Location = New System.Drawing.Point(78, 152)
        Me.cmdAbs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.Size = New System.Drawing.Size(76, 45)
        Me.cmdAbs.TabIndex = 144
        Me.cmdAbs.Text = "abs"
        Me.cmdAbs.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        Me.cmdExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExp.Location = New System.Drawing.Point(3, 152)
        Me.cmdExp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.Size = New System.Drawing.Size(76, 45)
        Me.cmdExp.TabIndex = 143
        Me.cmdExp.Text = "exp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdDeg
        '
        Me.cmdDeg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDeg.Location = New System.Drawing.Point(304, 108)
        Me.cmdDeg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDeg.Name = "cmdDeg"
        Me.cmdDeg.Size = New System.Drawing.Size(76, 45)
        Me.cmdDeg.TabIndex = 142
        Me.cmdDeg.Text = "deg"
        Me.cmdDeg.UseVisualStyleBackColor = True
        '
        'cmdTrunc
        '
        Me.cmdTrunc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrunc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrunc.Location = New System.Drawing.Point(230, 108)
        Me.cmdTrunc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTrunc.Name = "cmdTrunc"
        Me.cmdTrunc.Size = New System.Drawing.Size(76, 45)
        Me.cmdTrunc.TabIndex = 141
        Me.cmdTrunc.Text = "trunc"
        Me.cmdTrunc.UseVisualStyleBackColor = True
        '
        'cmdAtan
        '
        Me.cmdAtan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAtan.Location = New System.Drawing.Point(154, 108)
        Me.cmdAtan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAtan.Name = "cmdAtan"
        Me.cmdAtan.Size = New System.Drawing.Size(76, 45)
        Me.cmdAtan.TabIndex = 140
        Me.cmdAtan.Text = "atan"
        Me.cmdAtan.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        Me.cmdTan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTan.Location = New System.Drawing.Point(78, 108)
        Me.cmdTan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.Size = New System.Drawing.Size(76, 45)
        Me.cmdTan.TabIndex = 139
        Me.cmdTan.Text = "tan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdLogTen
        '
        Me.cmdLogTen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLogTen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLogTen.Location = New System.Drawing.Point(3, 108)
        Me.cmdLogTen.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLogTen.Name = "cmdLogTen"
        Me.cmdLogTen.Size = New System.Drawing.Size(76, 45)
        Me.cmdLogTen.TabIndex = 138
        Me.cmdLogTen.Text = "log10"
        Me.cmdLogTen.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        Me.cmdRad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRad.Location = New System.Drawing.Point(304, 64)
        Me.cmdRad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRad.Name = "cmdRad"
        Me.cmdRad.Size = New System.Drawing.Size(76, 45)
        Me.cmdRad.TabIndex = 137
        Me.cmdRad.Text = "rad"
        Me.cmdRad.UseVisualStyleBackColor = True
        '
        'cmdFloor
        '
        Me.cmdFloor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFloor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFloor.Location = New System.Drawing.Point(230, 64)
        Me.cmdFloor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFloor.Name = "cmdFloor"
        Me.cmdFloor.Size = New System.Drawing.Size(76, 45)
        Me.cmdFloor.TabIndex = 136
        Me.cmdFloor.Text = "floor"
        Me.cmdFloor.UseVisualStyleBackColor = True
        '
        'cmdAsin
        '
        Me.cmdAsin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAsin.Location = New System.Drawing.Point(154, 64)
        Me.cmdAsin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAsin.Name = "cmdAsin"
        Me.cmdAsin.Size = New System.Drawing.Size(76, 45)
        Me.cmdAsin.TabIndex = 135
        Me.cmdAsin.Text = "asin"
        Me.cmdAsin.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        Me.cmdSin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSin.Location = New System.Drawing.Point(78, 64)
        Me.cmdSin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.Size = New System.Drawing.Size(76, 45)
        Me.cmdSin.TabIndex = 134
        Me.cmdSin.Text = "sin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        Me.cmdLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLog.Location = New System.Drawing.Point(3, 64)
        Me.cmdLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.Size = New System.Drawing.Size(76, 45)
        Me.cmdLog.TabIndex = 133
        Me.cmdLog.Text = "log"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        Me.cmdPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPi.Location = New System.Drawing.Point(304, 21)
        Me.cmdPi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.Size = New System.Drawing.Size(76, 45)
        Me.cmdPi.TabIndex = 132
        Me.cmdPi.Text = "pi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdCeiling
        '
        Me.cmdCeiling.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCeiling.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCeiling.Location = New System.Drawing.Point(230, 21)
        Me.cmdCeiling.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCeiling.Name = "cmdCeiling"
        Me.cmdCeiling.Size = New System.Drawing.Size(76, 45)
        Me.cmdCeiling.TabIndex = 131
        Me.cmdCeiling.Text = "ceiling"
        Me.cmdCeiling.UseVisualStyleBackColor = True
        '
        'cmdAcos
        '
        Me.cmdAcos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAcos.Location = New System.Drawing.Point(154, 21)
        Me.cmdAcos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAcos.Name = "cmdAcos"
        Me.cmdAcos.Size = New System.Drawing.Size(76, 45)
        Me.cmdAcos.TabIndex = 130
        Me.cmdAcos.Text = "acos"
        Me.cmdAcos.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        Me.cmdCos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCos.Location = New System.Drawing.Point(78, 21)
        Me.cmdCos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.Size = New System.Drawing.Size(76, 45)
        Me.cmdCos.TabIndex = 129
        Me.cmdCos.Text = "cos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        Me.cmdSqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSqrt.Location = New System.Drawing.Point(3, 21)
        Me.cmdSqrt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.Size = New System.Drawing.Size(76, 45)
        Me.cmdSqrt.TabIndex = 128
        Me.cmdSqrt.Text = "sqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
        Me.grpSummary.Controls.Add(Me.cmdSummaryRHelp)
        Me.grpSummary.Controls.Add(Me.grpFrequencies)
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
        Me.grpSummary.Location = New System.Drawing.Point(651, 94)
        Me.grpSummary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpSummary.Size = New System.Drawing.Size(432, 489)
        Me.grpSummary.TabIndex = 185
        Me.grpSummary.TabStop = False
        Me.grpSummary.Text = "Summary"
        '
        'cmdSummaryRHelp
        '
        Me.cmdSummaryRHelp.AutoSize = True
        Me.cmdSummaryRHelp.ContextMenuStrip = Me.ContextMenuStripSummary
        Me.cmdSummaryRHelp.Location = New System.Drawing.Point(291, 246)
        Me.cmdSummaryRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSummaryRHelp.Name = "cmdSummaryRHelp"
        Me.cmdSummaryRHelp.Size = New System.Drawing.Size(136, 45)
        Me.cmdSummaryRHelp.SplitMenuStrip = Me.ContextMenuStripSummary
        Me.cmdSummaryRHelp.TabIndex = 185
        Me.cmdSummaryRHelp.Text = "R Help"
        Me.cmdSummaryRHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripSummary
        '
        Me.ContextMenuStripSummary.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripSummary.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseToolStripMenuItem1, Me.StatsToolStripMenuItem, Me.StatipToolStripMenuItem, Me.E1071ToolStripMenuItem, Me.RobustbaseToolStripMenuItem, Me.RasterToolStripMenuItem})
        Me.ContextMenuStripSummary.Name = "ContextMenuStripSummary"
        Me.ContextMenuStripSummary.Size = New System.Drawing.Size(178, 196)
        '
        'BaseToolStripMenuItem1
        '
        Me.BaseToolStripMenuItem1.Name = "BaseToolStripMenuItem1"
        Me.BaseToolStripMenuItem1.Size = New System.Drawing.Size(177, 32)
        Me.BaseToolStripMenuItem1.Text = "Base"
        '
        'StatsToolStripMenuItem
        '
        Me.StatsToolStripMenuItem.Name = "StatsToolStripMenuItem"
        Me.StatsToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.StatsToolStripMenuItem.Text = "Stats"
        '
        'StatipToolStripMenuItem
        '
        Me.StatipToolStripMenuItem.Name = "StatipToolStripMenuItem"
        Me.StatipToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.StatipToolStripMenuItem.Text = "Statip"
        '
        'E1071ToolStripMenuItem
        '
        Me.E1071ToolStripMenuItem.Name = "E1071ToolStripMenuItem"
        Me.E1071ToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.E1071ToolStripMenuItem.Text = "e1071"
        '
        'RobustbaseToolStripMenuItem
        '
        Me.RobustbaseToolStripMenuItem.Name = "RobustbaseToolStripMenuItem"
        Me.RobustbaseToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.RobustbaseToolStripMenuItem.Text = "Robustbase"
        '
        'RasterToolStripMenuItem
        '
        Me.RasterToolStripMenuItem.Name = "RasterToolStripMenuItem"
        Me.RasterToolStripMenuItem.Size = New System.Drawing.Size(177, 32)
        Me.RasterToolStripMenuItem.Text = "Raster"
        '
        'grpFrequencies
        '
        Me.grpFrequencies.Controls.Add(Me.cmdFreqQuantile)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqPropn)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqDistinct)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqIQR)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMedian)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqSd)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqVar)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMean)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMad)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMiss)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMode1)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMax)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqMin)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqSum)
        Me.grpFrequencies.Controls.Add(Me.cmdFreqLength)
        Me.grpFrequencies.Location = New System.Drawing.Point(3, 312)
        Me.grpFrequencies.Margin = New System.Windows.Forms.Padding(4)
        Me.grpFrequencies.Name = "grpFrequencies"
        Me.grpFrequencies.Padding = New System.Windows.Forms.Padding(4)
        Me.grpFrequencies.Size = New System.Drawing.Size(424, 160)
        Me.grpFrequencies.TabIndex = 184
        Me.grpFrequencies.TabStop = False
        Me.grpFrequencies.Text = "Frequencies"
        '
        'cmdFreqQuantile
        '
        Me.cmdFreqQuantile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqQuantile.Location = New System.Drawing.Point(338, 108)
        Me.cmdFreqQuantile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqQuantile.Name = "cmdFreqQuantile"
        Me.cmdFreqQuantile.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqQuantile.TabIndex = 186
        Me.cmdFreqQuantile.Text = "quantile"
        Me.cmdFreqQuantile.UseVisualStyleBackColor = True
        '
        'cmdFreqPropn
        '
        Me.cmdFreqPropn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqPropn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqPropn.Location = New System.Drawing.Point(254, 108)
        Me.cmdFreqPropn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqPropn.Name = "cmdFreqPropn"
        Me.cmdFreqPropn.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqPropn.TabIndex = 185
        Me.cmdFreqPropn.Text = "propn"
        Me.cmdFreqPropn.UseVisualStyleBackColor = True
        '
        'cmdFreqDistinct
        '
        Me.cmdFreqDistinct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqDistinct.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqDistinct.Location = New System.Drawing.Point(170, 108)
        Me.cmdFreqDistinct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqDistinct.Name = "cmdFreqDistinct"
        Me.cmdFreqDistinct.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqDistinct.TabIndex = 184
        Me.cmdFreqDistinct.Text = "distinct"
        Me.cmdFreqDistinct.UseVisualStyleBackColor = True
        '
        'cmdFreqIQR
        '
        Me.cmdFreqIQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqIQR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqIQR.Location = New System.Drawing.Point(84, 108)
        Me.cmdFreqIQR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqIQR.Name = "cmdFreqIQR"
        Me.cmdFreqIQR.Size = New System.Drawing.Size(87, 45)
        Me.cmdFreqIQR.TabIndex = 183
        Me.cmdFreqIQR.Text = "IQR"
        Me.cmdFreqIQR.UseVisualStyleBackColor = True
        '
        'cmdFreqMedian
        '
        Me.cmdFreqMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMedian.Location = New System.Drawing.Point(170, 64)
        Me.cmdFreqMedian.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMedian.Name = "cmdFreqMedian"
        Me.cmdFreqMedian.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqMedian.TabIndex = 182
        Me.cmdFreqMedian.Text = "median"
        Me.cmdFreqMedian.UseVisualStyleBackColor = True
        '
        'cmdFreqSd
        '
        Me.cmdFreqSd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqSd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqSd.Location = New System.Drawing.Point(338, 64)
        Me.cmdFreqSd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqSd.Name = "cmdFreqSd"
        Me.cmdFreqSd.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqSd.TabIndex = 181
        Me.cmdFreqSd.Text = "sd"
        Me.cmdFreqSd.UseVisualStyleBackColor = True
        '
        'cmdFreqVar
        '
        Me.cmdFreqVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqVar.Location = New System.Drawing.Point(254, 64)
        Me.cmdFreqVar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqVar.Name = "cmdFreqVar"
        Me.cmdFreqVar.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqVar.TabIndex = 180
        Me.cmdFreqVar.Text = "var"
        Me.cmdFreqVar.UseVisualStyleBackColor = True
        '
        'cmdFreqMean
        '
        Me.cmdFreqMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMean.Location = New System.Drawing.Point(84, 64)
        Me.cmdFreqMean.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMean.Name = "cmdFreqMean"
        Me.cmdFreqMean.Size = New System.Drawing.Size(87, 45)
        Me.cmdFreqMean.TabIndex = 179
        Me.cmdFreqMean.Text = "mean"
        Me.cmdFreqMean.UseVisualStyleBackColor = True
        '
        'cmdFreqMad
        '
        Me.cmdFreqMad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMad.Location = New System.Drawing.Point(0, 108)
        Me.cmdFreqMad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMad.Name = "cmdFreqMad"
        Me.cmdFreqMad.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqMad.TabIndex = 178
        Me.cmdFreqMad.Text = "mad"
        Me.cmdFreqMad.UseVisualStyleBackColor = True
        '
        'cmdFreqMiss
        '
        Me.cmdFreqMiss.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMiss.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMiss.Location = New System.Drawing.Point(0, 64)
        Me.cmdFreqMiss.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMiss.Name = "cmdFreqMiss"
        Me.cmdFreqMiss.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqMiss.TabIndex = 177
        Me.cmdFreqMiss.Text = "miss"
        Me.cmdFreqMiss.UseVisualStyleBackColor = True
        '
        'cmdFreqMode1
        '
        Me.cmdFreqMode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMode1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMode1.Location = New System.Drawing.Point(338, 21)
        Me.cmdFreqMode1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMode1.Name = "cmdFreqMode1"
        Me.cmdFreqMode1.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqMode1.TabIndex = 176
        Me.cmdFreqMode1.Text = "mode1"
        Me.cmdFreqMode1.UseVisualStyleBackColor = True
        '
        'cmdFreqMax
        '
        Me.cmdFreqMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMax.Location = New System.Drawing.Point(254, 21)
        Me.cmdFreqMax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMax.Name = "cmdFreqMax"
        Me.cmdFreqMax.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqMax.TabIndex = 175
        Me.cmdFreqMax.Text = "max"
        Me.cmdFreqMax.UseVisualStyleBackColor = True
        '
        'cmdFreqMin
        '
        Me.cmdFreqMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqMin.Location = New System.Drawing.Point(170, 21)
        Me.cmdFreqMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqMin.Name = "cmdFreqMin"
        Me.cmdFreqMin.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqMin.TabIndex = 174
        Me.cmdFreqMin.Text = "min"
        Me.cmdFreqMin.UseVisualStyleBackColor = True
        '
        'cmdFreqSum
        '
        Me.cmdFreqSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqSum.Location = New System.Drawing.Point(84, 21)
        Me.cmdFreqSum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqSum.Name = "cmdFreqSum"
        Me.cmdFreqSum.Size = New System.Drawing.Size(87, 45)
        Me.cmdFreqSum.TabIndex = 173
        Me.cmdFreqSum.Text = "sum"
        Me.cmdFreqSum.UseVisualStyleBackColor = True
        '
        'cmdFreqLength
        '
        Me.cmdFreqLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFreqLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFreqLength.Location = New System.Drawing.Point(0, 21)
        Me.cmdFreqLength.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFreqLength.Name = "cmdFreqLength"
        Me.cmdFreqLength.Size = New System.Drawing.Size(86, 45)
        Me.cmdFreqLength.TabIndex = 172
        Me.cmdFreqLength.Text = "length"
        Me.cmdFreqLength.UseVisualStyleBackColor = True
        '
        'cmdKurtosis
        '
        Me.cmdKurtosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdKurtosis.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdKurtosis.Location = New System.Drawing.Point(344, 150)
        Me.cmdKurtosis.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdKurtosis.Name = "cmdKurtosis"
        Me.cmdKurtosis.Size = New System.Drawing.Size(84, 45)
        Me.cmdKurtosis.TabIndex = 182
        Me.cmdKurtosis.Text = "kurtosis"
        Me.cmdKurtosis.UseVisualStyleBackColor = True
        '
        'cmdMode1
        '
        Me.cmdMode1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMode1.Location = New System.Drawing.Point(344, 63)
        Me.cmdMode1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMode1.Name = "cmdMode1"
        Me.cmdMode1.Size = New System.Drawing.Size(84, 45)
        Me.cmdMode1.TabIndex = 180
        Me.cmdMode1.Text = "mode1"
        Me.cmdMode1.UseVisualStyleBackColor = True
        '
        'cmdMode
        '
        Me.cmdMode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMode.Location = New System.Drawing.Point(261, 63)
        Me.cmdMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMode.Name = "cmdMode"
        Me.cmdMode.Size = New System.Drawing.Size(84, 45)
        Me.cmdMode.TabIndex = 179
        Me.cmdMode.Text = "mode"
        Me.cmdMode.UseVisualStyleBackColor = True
        '
        'cmdFirst
        '
        Me.cmdFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFirst.Location = New System.Drawing.Point(178, 194)
        Me.cmdFirst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.Size = New System.Drawing.Size(84, 45)
        Me.cmdFirst.TabIndex = 178
        Me.cmdFirst.Text = "first"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        Me.cmdLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLast.Location = New System.Drawing.Point(261, 194)
        Me.cmdLast.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(84, 45)
        Me.cmdLast.TabIndex = 177
        Me.cmdLast.Text = "last"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdnth
        '
        Me.cmdnth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdnth.Location = New System.Drawing.Point(344, 194)
        Me.cmdnth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdnth.Name = "cmdnth"
        Me.cmdnth.Size = New System.Drawing.Size(84, 45)
        Me.cmdnth.TabIndex = 176
        Me.cmdnth.Text = "nth"
        Me.cmdnth.UseVisualStyleBackColor = True
        '
        'cmdCor
        '
        Me.cmdCor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCor.Location = New System.Drawing.Point(3, 237)
        Me.cmdCor.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCor.Name = "cmdCor"
        Me.cmdCor.Size = New System.Drawing.Size(94, 45)
        Me.cmdCor.TabIndex = 175
        Me.cmdCor.Text = "cor"
        Me.cmdCor.UseVisualStyleBackColor = True
        '
        'cmdCov
        '
        Me.cmdCov.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCov.Location = New System.Drawing.Point(96, 237)
        Me.cmdCov.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCov.Name = "cmdCov"
        Me.cmdCov.Size = New System.Drawing.Size(84, 45)
        Me.cmdCov.TabIndex = 174
        Me.cmdCov.Text = "cov"
        Me.cmdCov.UseVisualStyleBackColor = True
        '
        'cmdMad
        '
        Me.cmdMad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMad.Location = New System.Drawing.Point(261, 106)
        Me.cmdMad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMad.Name = "cmdMad"
        Me.cmdMad.Size = New System.Drawing.Size(84, 45)
        Me.cmdMad.TabIndex = 173
        Me.cmdMad.Text = "mad"
        Me.cmdMad.UseVisualStyleBackColor = True
        '
        'cmdMc
        '
        Me.cmdMc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMc.Location = New System.Drawing.Point(178, 150)
        Me.cmdMc.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMc.Name = "cmdMc"
        Me.cmdMc.Size = New System.Drawing.Size(84, 45)
        Me.cmdMc.TabIndex = 172
        Me.cmdMc.Text = "mc"
        Me.cmdMc.UseVisualStyleBackColor = True
        '
        'cmdPropn
        '
        Me.cmdPropn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPropn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPropn.Location = New System.Drawing.Point(96, 194)
        Me.cmdPropn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPropn.Name = "cmdPropn"
        Me.cmdPropn.Size = New System.Drawing.Size(84, 45)
        Me.cmdPropn.TabIndex = 171
        Me.cmdPropn.Text = "propn"
        Me.cmdPropn.UseVisualStyleBackColor = True
        '
        'cmdCv
        '
        Me.cmdCv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCv.Location = New System.Drawing.Point(96, 150)
        Me.cmdCv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCv.Name = "cmdCv"
        Me.cmdCv.Size = New System.Drawing.Size(84, 45)
        Me.cmdCv.TabIndex = 170
        Me.cmdCv.Text = "cv"
        Me.cmdCv.UseVisualStyleBackColor = True
        '
        'cmdSkew
        '
        Me.cmdSkew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSkew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSkew.Location = New System.Drawing.Point(261, 150)
        Me.cmdSkew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSkew.Name = "cmdSkew"
        Me.cmdSkew.Size = New System.Drawing.Size(84, 45)
        Me.cmdSkew.TabIndex = 169
        Me.cmdSkew.Text = "skew"
        Me.cmdSkew.UseVisualStyleBackColor = True
        '
        'cmdAnyDup
        '
        Me.cmdAnyDup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAnyDup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnyDup.Location = New System.Drawing.Point(3, 194)
        Me.cmdAnyDup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAnyDup.Name = "cmdAnyDup"
        Me.cmdAnyDup.Size = New System.Drawing.Size(94, 45)
        Me.cmdAnyDup.TabIndex = 168
        Me.cmdAnyDup.Text = "anyDup"
        Me.cmdAnyDup.UseVisualStyleBackColor = True
        '
        'cmdDistinct
        '
        Me.cmdDistinct.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDistinct.Location = New System.Drawing.Point(3, 150)
        Me.cmdDistinct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDistinct.Name = "cmdDistinct"
        Me.cmdDistinct.Size = New System.Drawing.Size(94, 45)
        Me.cmdDistinct.TabIndex = 167
        Me.cmdDistinct.Text = "distinct"
        Me.cmdDistinct.UseVisualStyleBackColor = True
        '
        'cmdNonMiss
        '
        Me.cmdNonMiss.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNonMiss.Location = New System.Drawing.Point(3, 106)
        Me.cmdNonMiss.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdNonMiss.Name = "cmdNonMiss"
        Me.cmdNonMiss.Size = New System.Drawing.Size(94, 45)
        Me.cmdNonMiss.TabIndex = 166
        Me.cmdNonMiss.Text = "non miss"
        Me.cmdNonMiss.UseVisualStyleBackColor = True
        '
        'cmdIQR
        '
        Me.cmdIQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdIQR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIQR.Location = New System.Drawing.Point(344, 106)
        Me.cmdIQR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdIQR.Name = "cmdIQR"
        Me.cmdIQR.Size = New System.Drawing.Size(84, 45)
        Me.cmdIQR.TabIndex = 165
        Me.cmdIQR.Text = "IQR"
        Me.cmdIQR.UseVisualStyleBackColor = True
        '
        'cmdQuantile
        '
        Me.cmdQuantile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuantile.Location = New System.Drawing.Point(178, 237)
        Me.cmdQuantile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQuantile.Name = "cmdQuantile"
        Me.cmdQuantile.Size = New System.Drawing.Size(84, 45)
        Me.cmdQuantile.TabIndex = 164
        Me.cmdQuantile.Text = "quantile"
        Me.cmdQuantile.UseVisualStyleBackColor = True
        '
        'cmdRange
        '
        Me.cmdRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRange.Location = New System.Drawing.Point(344, 20)
        Me.cmdRange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRange.Name = "cmdRange"
        Me.cmdRange.Size = New System.Drawing.Size(84, 45)
        Me.cmdRange.TabIndex = 163
        Me.cmdRange.Text = "range"
        Me.cmdRange.UseVisualStyleBackColor = True
        '
        'cmdSd
        '
        Me.cmdSd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSd.Location = New System.Drawing.Point(178, 106)
        Me.cmdSd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSd.Name = "cmdSd"
        Me.cmdSd.Size = New System.Drawing.Size(84, 45)
        Me.cmdSd.TabIndex = 160
        Me.cmdSd.Text = "sd"
        Me.cmdSd.UseVisualStyleBackColor = True
        '
        'cmdMedian
        '
        Me.cmdMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMedian.Location = New System.Drawing.Point(178, 63)
        Me.cmdMedian.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMedian.Name = "cmdMedian"
        Me.cmdMedian.Size = New System.Drawing.Size(84, 45)
        Me.cmdMedian.TabIndex = 158
        Me.cmdMedian.Text = "median"
        Me.cmdMedian.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        Me.cmdMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMin.Location = New System.Drawing.Point(178, 20)
        Me.cmdMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.Size = New System.Drawing.Size(84, 45)
        Me.cmdMin.TabIndex = 155
        Me.cmdMin.Text = "min"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdMax
        '
        Me.cmdMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMax.Location = New System.Drawing.Point(261, 20)
        Me.cmdMax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.Size = New System.Drawing.Size(84, 45)
        Me.cmdMax.TabIndex = 154
        Me.cmdMax.Text = "max"
        Me.cmdMax.UseVisualStyleBackColor = True
        '
        'cmdMean
        '
        Me.cmdMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMean.Location = New System.Drawing.Point(96, 63)
        Me.cmdMean.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMean.Name = "cmdMean"
        Me.cmdMean.Size = New System.Drawing.Size(84, 45)
        Me.cmdMean.TabIndex = 153
        Me.cmdMean.Text = "mean"
        Me.cmdMean.UseVisualStyleBackColor = True
        '
        'cmdMiss
        '
        Me.cmdMiss.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMiss.Location = New System.Drawing.Point(3, 63)
        Me.cmdMiss.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMiss.Name = "cmdMiss"
        Me.cmdMiss.Size = New System.Drawing.Size(94, 45)
        Me.cmdMiss.TabIndex = 149
        Me.cmdMiss.Text = "miss"
        Me.cmdMiss.UseVisualStyleBackColor = True
        '
        'cmdLength
        '
        Me.cmdLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLength.Location = New System.Drawing.Point(3, 20)
        Me.cmdLength.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLength.Name = "cmdLength"
        Me.cmdLength.Size = New System.Drawing.Size(94, 45)
        Me.cmdLength.TabIndex = 148
        Me.cmdLength.Text = "length"
        Me.cmdLength.UseVisualStyleBackColor = True
        '
        'cmdSum
        '
        Me.cmdSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSum.Location = New System.Drawing.Point(96, 20)
        Me.cmdSum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSum.Name = "cmdSum"
        Me.cmdSum.Size = New System.Drawing.Size(84, 45)
        Me.cmdSum.TabIndex = 150
        Me.cmdSum.Text = "sum"
        Me.cmdSum.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        Me.cmdVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdVar.Location = New System.Drawing.Point(96, 106)
        Me.cmdVar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdVar.Name = "cmdVar"
        Me.cmdVar.Size = New System.Drawing.Size(84, 45)
        Me.cmdVar.TabIndex = 159
        Me.cmdVar.Text = "var"
        Me.cmdVar.UseVisualStyleBackColor = True
        '
        'grpProbabilty
        '
        Me.grpProbabilty.Controls.Add(Me.cmdPascal)
        Me.grpProbabilty.Controls.Add(Me.cmdProbRHelp)
        Me.grpProbabilty.Controls.Add(Me.grpRandom)
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
        Me.grpProbabilty.Location = New System.Drawing.Point(651, 93)
        Me.grpProbabilty.Margin = New System.Windows.Forms.Padding(4)
        Me.grpProbabilty.Name = "grpProbabilty"
        Me.grpProbabilty.Padding = New System.Windows.Forms.Padding(4)
        Me.grpProbabilty.Size = New System.Drawing.Size(474, 482)
        Me.grpProbabilty.TabIndex = 187
        Me.grpProbabilty.TabStop = False
        Me.grpProbabilty.Text = "Probability"
        '
        'cmdPascal
        '
        Me.cmdPascal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPascal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPascal.Location = New System.Drawing.Point(3, 284)
        Me.cmdPascal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPascal.Name = "cmdPascal"
        Me.cmdPascal.Size = New System.Drawing.Size(93, 45)
        Me.cmdPascal.TabIndex = 213
        Me.cmdPascal.Text = "pascal"
        Me.cmdPascal.UseVisualStyleBackColor = True
        '
        'cmdProbRHelp
        '
        Me.cmdProbRHelp.AutoSize = True
        Me.cmdProbRHelp.ContextMenuStrip = Me.ContextMenuStripProbability
        Me.cmdProbRHelp.Location = New System.Drawing.Point(360, 285)
        Me.cmdProbRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdProbRHelp.Name = "cmdProbRHelp"
        Me.cmdProbRHelp.Size = New System.Drawing.Size(129, 45)
        Me.cmdProbRHelp.SplitMenuStrip = Me.ContextMenuStripProbability
        Me.cmdProbRHelp.TabIndex = 212
        Me.cmdProbRHelp.Text = "R Help"
        Me.cmdProbRHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripProbability
        '
        Me.ContextMenuStripProbability.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripProbability.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProbStatsToolStripMenuItem, Me.ProbBaseToolStripMenuItem})
        Me.ContextMenuStripProbability.Name = "ContextMenuStrip1"
        Me.ContextMenuStripProbability.Size = New System.Drawing.Size(122, 68)
        '
        'ProbStatsToolStripMenuItem
        '
        Me.ProbStatsToolStripMenuItem.Name = "ProbStatsToolStripMenuItem"
        Me.ProbStatsToolStripMenuItem.Size = New System.Drawing.Size(121, 32)
        Me.ProbStatsToolStripMenuItem.Text = "stats"
        '
        'ProbBaseToolStripMenuItem
        '
        Me.ProbBaseToolStripMenuItem.Name = "ProbBaseToolStripMenuItem"
        Me.ProbBaseToolStripMenuItem.Size = New System.Drawing.Size(121, 32)
        Me.ProbBaseToolStripMenuItem.Text = "base"
        '
        'grpRandom
        '
        Me.grpRandom.Controls.Add(Me.cmdnbinomial)
        Me.grpRandom.Controls.Add(Me.cmdRan_sample)
        Me.grpRandom.Controls.Add(Me.cmdRan_beta)
        Me.grpRandom.Controls.Add(Me.cmdRan_gamma)
        Me.grpRandom.Controls.Add(Me.cmdpoisson)
        Me.grpRandom.Controls.Add(Me.cmdbinomial)
        Me.grpRandom.Controls.Add(Me.cmdbernoulli)
        Me.grpRandom.Controls.Add(Me.cmduni_integer)
        Me.grpRandom.Controls.Add(Me.cmdRan_normal)
        Me.grpRandom.Controls.Add(Me.cmduniform)
        Me.grpRandom.Location = New System.Drawing.Point(9, 342)
        Me.grpRandom.Margin = New System.Windows.Forms.Padding(4)
        Me.grpRandom.Name = "grpRandom"
        Me.grpRandom.Padding = New System.Windows.Forms.Padding(4)
        Me.grpRandom.Size = New System.Drawing.Size(459, 126)
        Me.grpRandom.TabIndex = 199
        Me.grpRandom.TabStop = False
        Me.grpRandom.Text = "Random"
        '
        'cmdnbinomial
        '
        Me.cmdnbinomial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdnbinomial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdnbinomial.Location = New System.Drawing.Point(174, 64)
        Me.cmdnbinomial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdnbinomial.Name = "cmdnbinomial"
        Me.cmdnbinomial.Size = New System.Drawing.Size(108, 45)
        Me.cmdnbinomial.TabIndex = 182
        Me.cmdnbinomial.Text = "nbinomial"
        Me.cmdnbinomial.UseVisualStyleBackColor = True
        '
        'cmdRan_sample
        '
        Me.cmdRan_sample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRan_sample.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRan_sample.Location = New System.Drawing.Point(364, 64)
        Me.cmdRan_sample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRan_sample.Name = "cmdRan_sample"
        Me.cmdRan_sample.Size = New System.Drawing.Size(86, 45)
        Me.cmdRan_sample.TabIndex = 181
        Me.cmdRan_sample.Text = "sample"
        Me.cmdRan_sample.UseVisualStyleBackColor = True
        '
        'cmdRan_beta
        '
        Me.cmdRan_beta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRan_beta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRan_beta.Location = New System.Drawing.Point(280, 64)
        Me.cmdRan_beta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRan_beta.Name = "cmdRan_beta"
        Me.cmdRan_beta.Size = New System.Drawing.Size(86, 45)
        Me.cmdRan_beta.TabIndex = 180
        Me.cmdRan_beta.Text = "beta"
        Me.cmdRan_beta.UseVisualStyleBackColor = True
        '
        'cmdRan_gamma
        '
        Me.cmdRan_gamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRan_gamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRan_gamma.Location = New System.Drawing.Point(88, 64)
        Me.cmdRan_gamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRan_gamma.Name = "cmdRan_gamma"
        Me.cmdRan_gamma.Size = New System.Drawing.Size(87, 45)
        Me.cmdRan_gamma.TabIndex = 179
        Me.cmdRan_gamma.Text = "gamma"
        Me.cmdRan_gamma.UseVisualStyleBackColor = True
        '
        'cmdpoisson
        '
        Me.cmdpoisson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdpoisson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdpoisson.Location = New System.Drawing.Point(4, 64)
        Me.cmdpoisson.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdpoisson.Name = "cmdpoisson"
        Me.cmdpoisson.Size = New System.Drawing.Size(86, 45)
        Me.cmdpoisson.TabIndex = 177
        Me.cmdpoisson.Text = "poisson"
        Me.cmdpoisson.UseVisualStyleBackColor = True
        '
        'cmdbinomial
        '
        Me.cmdbinomial.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdbinomial.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdbinomial.Location = New System.Drawing.Point(364, 21)
        Me.cmdbinomial.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdbinomial.Name = "cmdbinomial"
        Me.cmdbinomial.Size = New System.Drawing.Size(86, 45)
        Me.cmdbinomial.TabIndex = 176
        Me.cmdbinomial.Text = "binomial"
        Me.cmdbinomial.UseVisualStyleBackColor = True
        '
        'cmdbernoulli
        '
        Me.cmdbernoulli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdbernoulli.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdbernoulli.Location = New System.Drawing.Point(280, 21)
        Me.cmdbernoulli.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdbernoulli.Name = "cmdbernoulli"
        Me.cmdbernoulli.Size = New System.Drawing.Size(86, 45)
        Me.cmdbernoulli.TabIndex = 175
        Me.cmdbernoulli.Text = "bernoulli"
        Me.cmdbernoulli.UseVisualStyleBackColor = True
        '
        'cmduni_integer
        '
        Me.cmduni_integer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmduni_integer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmduni_integer.Location = New System.Drawing.Point(174, 21)
        Me.cmduni_integer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmduni_integer.Name = "cmduni_integer"
        Me.cmduni_integer.Size = New System.Drawing.Size(108, 45)
        Me.cmduni_integer.TabIndex = 174
        Me.cmduni_integer.Text = "uni_integer"
        Me.cmduni_integer.UseVisualStyleBackColor = True
        '
        'cmdRan_normal
        '
        Me.cmdRan_normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRan_normal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRan_normal.Location = New System.Drawing.Point(88, 21)
        Me.cmdRan_normal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRan_normal.Name = "cmdRan_normal"
        Me.cmdRan_normal.Size = New System.Drawing.Size(87, 45)
        Me.cmdRan_normal.TabIndex = 173
        Me.cmdRan_normal.Text = "normal"
        Me.cmdRan_normal.UseVisualStyleBackColor = True
        '
        'cmduniform
        '
        Me.cmduniform.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmduniform.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmduniform.Location = New System.Drawing.Point(4, 21)
        Me.cmduniform.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmduniform.Name = "cmduniform"
        Me.cmduniform.Size = New System.Drawing.Size(86, 45)
        Me.cmduniform.TabIndex = 172
        Me.cmduniform.Text = "uniform"
        Me.cmduniform.UseVisualStyleBackColor = True
        '
        'cmdQnbin
        '
        Me.cmdQnbin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQnbin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQnbin.Location = New System.Drawing.Point(369, 153)
        Me.cmdQnbin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQnbin.Name = "cmdQnbin"
        Me.cmdQnbin.Size = New System.Drawing.Size(93, 45)
        Me.cmdQnbin.TabIndex = 176
        Me.cmdQnbin.Text = "qnbin"
        Me.cmdQnbin.UseVisualStyleBackColor = True
        '
        'cmdQpois
        '
        Me.cmdQpois.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQpois.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQpois.Location = New System.Drawing.Point(278, 153)
        Me.cmdQpois.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQpois.Name = "cmdQpois"
        Me.cmdQpois.Size = New System.Drawing.Size(93, 45)
        Me.cmdQpois.TabIndex = 175
        Me.cmdQpois.Text = "qpois"
        Me.cmdQpois.UseVisualStyleBackColor = True
        '
        'cmdQbinom
        '
        Me.cmdQbinom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQbinom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQbinom.Location = New System.Drawing.Point(186, 153)
        Me.cmdQbinom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQbinom.Name = "cmdQbinom"
        Me.cmdQbinom.Size = New System.Drawing.Size(93, 45)
        Me.cmdQbinom.TabIndex = 174
        Me.cmdQbinom.Text = "qbinom"
        Me.cmdQbinom.UseVisualStyleBackColor = True
        '
        'cmdQbirth
        '
        Me.cmdQbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQbirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQbirth.Location = New System.Drawing.Point(94, 153)
        Me.cmdQbirth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQbirth.Name = "cmdQbirth"
        Me.cmdQbirth.Size = New System.Drawing.Size(93, 45)
        Me.cmdQbirth.TabIndex = 173
        Me.cmdQbirth.Text = "qbirth"
        Me.cmdQbirth.UseVisualStyleBackColor = True
        '
        'cmdQbeta
        '
        Me.cmdQbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQbeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQbeta.Location = New System.Drawing.Point(3, 153)
        Me.cmdQbeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQbeta.Name = "cmdQbeta"
        Me.cmdQbeta.Size = New System.Drawing.Size(93, 45)
        Me.cmdQbeta.TabIndex = 172
        Me.cmdQbeta.Text = "qbeta"
        Me.cmdQbeta.UseVisualStyleBackColor = True
        '
        'cmdPnbin
        '
        Me.cmdPnbin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPnbin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPnbin.Location = New System.Drawing.Point(369, 110)
        Me.cmdPnbin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPnbin.Name = "cmdPnbin"
        Me.cmdPnbin.Size = New System.Drawing.Size(93, 45)
        Me.cmdPnbin.TabIndex = 171
        Me.cmdPnbin.Text = "pnbin"
        Me.cmdPnbin.UseVisualStyleBackColor = True
        '
        'cmdPpois
        '
        Me.cmdPpois.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPpois.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPpois.Location = New System.Drawing.Point(278, 110)
        Me.cmdPpois.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPpois.Name = "cmdPpois"
        Me.cmdPpois.Size = New System.Drawing.Size(93, 45)
        Me.cmdPpois.TabIndex = 170
        Me.cmdPpois.Text = "ppois"
        Me.cmdPpois.UseVisualStyleBackColor = True
        '
        'cmdPbinom
        '
        Me.cmdPbinom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPbinom.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbinom.Location = New System.Drawing.Point(186, 110)
        Me.cmdPbinom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPbinom.Name = "cmdPbinom"
        Me.cmdPbinom.Size = New System.Drawing.Size(93, 45)
        Me.cmdPbinom.TabIndex = 169
        Me.cmdPbinom.Text = "pbinom"
        Me.cmdPbinom.UseVisualStyleBackColor = True
        '
        'cmdPbirth
        '
        Me.cmdPbirth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPbirth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbirth.Location = New System.Drawing.Point(94, 110)
        Me.cmdPbirth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPbirth.Name = "cmdPbirth"
        Me.cmdPbirth.Size = New System.Drawing.Size(93, 45)
        Me.cmdPbirth.TabIndex = 168
        Me.cmdPbirth.Text = "pbirth"
        Me.cmdPbirth.UseVisualStyleBackColor = True
        '
        'cmdPbeta
        '
        Me.cmdPbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPbeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPbeta.Location = New System.Drawing.Point(3, 110)
        Me.cmdPbeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPbeta.Name = "cmdPbeta"
        Me.cmdPbeta.Size = New System.Drawing.Size(93, 45)
        Me.cmdPbeta.TabIndex = 167
        Me.cmdPbeta.Text = "pbeta"
        Me.cmdPbeta.UseVisualStyleBackColor = True
        '
        'cmdQgamma
        '
        Me.cmdQgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQgamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQgamma.Location = New System.Drawing.Point(369, 66)
        Me.cmdQgamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQgamma.Name = "cmdQgamma"
        Me.cmdQgamma.Size = New System.Drawing.Size(93, 45)
        Me.cmdQgamma.TabIndex = 166
        Me.cmdQgamma.Text = "qgamma"
        Me.cmdQgamma.UseVisualStyleBackColor = True
        '
        'cmdPgamma
        '
        Me.cmdPgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPgamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPgamma.Location = New System.Drawing.Point(369, 22)
        Me.cmdPgamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPgamma.Name = "cmdPgamma"
        Me.cmdPgamma.Size = New System.Drawing.Size(93, 45)
        Me.cmdPgamma.TabIndex = 165
        Me.cmdPgamma.Text = "pgamma"
        Me.cmdPgamma.UseVisualStyleBackColor = True
        '
        'cmdGamma
        '
        Me.cmdGamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdGamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGamma.Location = New System.Drawing.Point(278, 196)
        Me.cmdGamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdGamma.Name = "cmdGamma"
        Me.cmdGamma.Size = New System.Drawing.Size(93, 45)
        Me.cmdGamma.TabIndex = 163
        Me.cmdGamma.Tag = ""
        Me.cmdGamma.Text = "gamma"
        Me.cmdGamma.UseVisualStyleBackColor = True
        '
        'cmdLbeta
        '
        Me.cmdLbeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLbeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLbeta.Location = New System.Drawing.Point(186, 240)
        Me.cmdLbeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLbeta.Name = "cmdLbeta"
        Me.cmdLbeta.Size = New System.Drawing.Size(93, 45)
        Me.cmdLbeta.TabIndex = 159
        Me.cmdLbeta.Text = "lbeta"
        Me.cmdLbeta.UseVisualStyleBackColor = True
        '
        'cmdqF
        '
        Me.cmdqF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdqF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdqF.Location = New System.Drawing.Point(278, 66)
        Me.cmdqF.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdqF.Name = "cmdqF"
        Me.cmdqF.Size = New System.Drawing.Size(93, 45)
        Me.cmdqF.TabIndex = 162
        Me.cmdqF.Text = "qf"
        Me.cmdqF.UseVisualStyleBackColor = True
        '
        'cmdFact
        '
        Me.cmdFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdFact.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFact.Location = New System.Drawing.Point(3, 196)
        Me.cmdFact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdFact.Name = "cmdFact"
        Me.cmdFact.Size = New System.Drawing.Size(93, 45)
        Me.cmdFact.TabIndex = 154
        Me.cmdFact.Text = "fact"
        Me.cmdFact.UseVisualStyleBackColor = True
        '
        'cmdChoose
        '
        Me.cmdChoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdChoose.Location = New System.Drawing.Point(94, 196)
        Me.cmdChoose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdChoose.Name = "cmdChoose"
        Me.cmdChoose.Size = New System.Drawing.Size(93, 45)
        Me.cmdChoose.TabIndex = 161
        Me.cmdChoose.Text = "choose"
        Me.cmdChoose.UseVisualStyleBackColor = True
        '
        'cmdPf
        '
        Me.cmdPf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPf.Location = New System.Drawing.Point(278, 22)
        Me.cmdPf.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPf.Name = "cmdPf"
        Me.cmdPf.Size = New System.Drawing.Size(93, 45)
        Me.cmdPf.TabIndex = 156
        Me.cmdPf.Text = "pf"
        Me.cmdPf.UseVisualStyleBackColor = True
        '
        'cmdPChisq
        '
        Me.cmdPChisq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPChisq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPChisq.Location = New System.Drawing.Point(186, 22)
        Me.cmdPChisq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPChisq.Name = "cmdPChisq"
        Me.cmdPChisq.Size = New System.Drawing.Size(93, 45)
        Me.cmdPChisq.TabIndex = 155
        Me.cmdPChisq.Text = "pchisq"
        Me.cmdPChisq.UseVisualStyleBackColor = True
        '
        'cmdLgamma
        '
        Me.cmdLgamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLgamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLgamma.Location = New System.Drawing.Point(278, 240)
        Me.cmdLgamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLgamma.Name = "cmdLgamma"
        Me.cmdLgamma.Size = New System.Drawing.Size(93, 45)
        Me.cmdLgamma.TabIndex = 152
        Me.cmdLgamma.Text = "lgamma"
        Me.cmdLgamma.UseVisualStyleBackColor = True
        '
        'cmdPnorm
        '
        Me.cmdPnorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPnorm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPnorm.Location = New System.Drawing.Point(3, 22)
        Me.cmdPnorm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPnorm.Name = "cmdPnorm"
        Me.cmdPnorm.Size = New System.Drawing.Size(93, 45)
        Me.cmdPnorm.TabIndex = 148
        Me.cmdPnorm.Text = "pnorm"
        Me.cmdPnorm.UseVisualStyleBackColor = True
        '
        'cmdQchisq
        '
        Me.cmdQchisq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQchisq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQchisq.Location = New System.Drawing.Point(186, 66)
        Me.cmdQchisq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQchisq.Name = "cmdQchisq"
        Me.cmdQchisq.Size = New System.Drawing.Size(93, 45)
        Me.cmdQchisq.TabIndex = 160
        Me.cmdQchisq.Text = "qchisq"
        Me.cmdQchisq.UseVisualStyleBackColor = True
        '
        'cmdQt
        '
        Me.cmdQt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQt.Location = New System.Drawing.Point(94, 66)
        Me.cmdQt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQt.Name = "cmdQt"
        Me.cmdQt.Size = New System.Drawing.Size(93, 45)
        Me.cmdQt.TabIndex = 158
        Me.cmdQt.Text = "qt"
        Me.cmdQt.UseVisualStyleBackColor = True
        '
        'cmdQnorm
        '
        Me.cmdQnorm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdQnorm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQnorm.Location = New System.Drawing.Point(3, 66)
        Me.cmdQnorm.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQnorm.Name = "cmdQnorm"
        Me.cmdQnorm.Size = New System.Drawing.Size(93, 45)
        Me.cmdQnorm.TabIndex = 157
        Me.cmdQnorm.Text = "qnorm"
        Me.cmdQnorm.UseVisualStyleBackColor = True
        '
        'cmdPt
        '
        Me.cmdPt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPt.Location = New System.Drawing.Point(94, 22)
        Me.cmdPt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPt.Name = "cmdPt"
        Me.cmdPt.Size = New System.Drawing.Size(93, 45)
        Me.cmdPt.TabIndex = 153
        Me.cmdPt.Text = "pt"
        Me.cmdPt.UseVisualStyleBackColor = True
        '
        'cmdLchoose
        '
        Me.cmdLchoose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLchoose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLchoose.Location = New System.Drawing.Point(94, 240)
        Me.cmdLchoose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLchoose.Name = "cmdLchoose"
        Me.cmdLchoose.Size = New System.Drawing.Size(93, 45)
        Me.cmdLchoose.TabIndex = 151
        Me.cmdLchoose.Text = "lchoose"
        Me.cmdLchoose.UseVisualStyleBackColor = True
        '
        'cmdLfact
        '
        Me.cmdLfact.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLfact.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLfact.Location = New System.Drawing.Point(3, 240)
        Me.cmdLfact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLfact.Name = "cmdLfact"
        Me.cmdLfact.Size = New System.Drawing.Size(93, 45)
        Me.cmdLfact.TabIndex = 150
        Me.cmdLfact.Text = "lfact"
        Me.cmdLfact.UseVisualStyleBackColor = True
        '
        'cmdTrigamma
        '
        Me.cmdTrigamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrigamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrigamma.Location = New System.Drawing.Point(369, 240)
        Me.cmdTrigamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTrigamma.Name = "cmdTrigamma"
        Me.cmdTrigamma.Size = New System.Drawing.Size(93, 45)
        Me.cmdTrigamma.TabIndex = 149
        Me.cmdTrigamma.Text = "trigamma"
        Me.cmdTrigamma.UseVisualStyleBackColor = True
        '
        'cmdBeta
        '
        Me.cmdBeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdBeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBeta.Location = New System.Drawing.Point(186, 196)
        Me.cmdBeta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBeta.Name = "cmdBeta"
        Me.cmdBeta.Size = New System.Drawing.Size(93, 45)
        Me.cmdBeta.TabIndex = 149
        Me.cmdBeta.Text = "beta"
        Me.cmdBeta.UseVisualStyleBackColor = True
        '
        'cmdDigamma
        '
        Me.cmdDigamma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdDigamma.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigamma.Location = New System.Drawing.Point(369, 196)
        Me.cmdDigamma.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDigamma.Name = "cmdDigamma"
        Me.cmdDigamma.Size = New System.Drawing.Size(93, 45)
        Me.cmdDigamma.TabIndex = 164
        Me.cmdDigamma.Text = "digamma"
        Me.cmdDigamma.UseVisualStyleBackColor = True
        '
        'grpTransform
        '
        Me.grpTransform.Controls.Add(Me.cmdDecimals)
        Me.grpTransform.Controls.Add(Me.cmdMASSFractions)
        Me.grpTransform.Controls.Add(Me.cmdScale)
        Me.grpTransform.Controls.Add(Me.cmdTransformRHelp)
        Me.grpTransform.Controls.Add(Me.cmdRev)
        Me.grpTransform.Controls.Add(Me.cmdMovProd)
        Me.grpTransform.Controls.Add(Me.cmdCumProd)
        Me.grpTransform.Controls.Add(Me.cmdSortF)
        Me.grpTransform.Controls.Add(Me.cmdNasplin)
        Me.grpTransform.Controls.Add(Me.cmdNaapprox)
        Me.grpTransform.Controls.Add(Me.cmdNaest)
        Me.grpTransform.Controls.Add(Me.cmdNafill)
        Me.grpTransform.Controls.Add(Me.cmdMovmin)
        Me.grpTransform.Controls.Add(Me.cmdRowRank)
        Me.grpTransform.Controls.Add(Me.cmdDiff)
        Me.grpTransform.Controls.Add(Me.cmdCumdist)
        Me.grpTransform.Controls.Add(Me.cmdMovMean)
        Me.grpTransform.Controls.Add(Me.cmdCumMean)
        Me.grpTransform.Controls.Add(Me.cmdNtile)
        Me.grpTransform.Controls.Add(Me.cmMovMed)
        Me.grpTransform.Controls.Add(Me.cmdMRank)
        Me.grpTransform.Controls.Add(Me.cmdDRank)
        Me.grpTransform.Controls.Add(Me.cmdMovMax)
        Me.grpTransform.Controls.Add(Me.cmdMovSum)
        Me.grpTransform.Controls.Add(Me.cmdPercentRank)
        Me.grpTransform.Controls.Add(Me.cmdCumSum)
        Me.grpTransform.Controls.Add(Me.cmdCumMin)
        Me.grpTransform.Controls.Add(Me.cmdCumMax)
        Me.grpTransform.Controls.Add(Me.cmdPMin)
        Me.grpTransform.Controls.Add(Me.cmdPMax)
        Me.grpTransform.Controls.Add(Me.cmdLead)
        Me.grpTransform.Controls.Add(Me.cmdLag)
        Me.grpTransform.Location = New System.Drawing.Point(651, 93)
        Me.grpTransform.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTransform.Size = New System.Drawing.Size(465, 376)
        Me.grpTransform.TabIndex = 189
        Me.grpTransform.TabStop = False
        Me.grpTransform.Text = "Transform"
        '
        'cmdDecimals
        '
        Me.cmdDecimals.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDecimals.Location = New System.Drawing.Point(3, 284)
        Me.cmdDecimals.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDecimals.Name = "cmdDecimals"
        Me.cmdDecimals.Size = New System.Drawing.Size(93, 45)
        Me.cmdDecimals.TabIndex = 207
        Me.cmdDecimals.Text = "decimals"
        Me.cmdDecimals.UseVisualStyleBackColor = True
        '
        'cmdMASSFractions
        '
        Me.cmdMASSFractions.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMASSFractions.Location = New System.Drawing.Point(3, 240)
        Me.cmdMASSFractions.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMASSFractions.Name = "cmdMASSFractions"
        Me.cmdMASSFractions.Size = New System.Drawing.Size(93, 45)
        Me.cmdMASSFractions.TabIndex = 206
        Me.cmdMASSFractions.Text = "fractions"
        Me.cmdMASSFractions.UseVisualStyleBackColor = True
        '
        'cmdScale
        '
        Me.cmdScale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdScale.Location = New System.Drawing.Point(3, 196)
        Me.cmdScale.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdScale.Name = "cmdScale"
        Me.cmdScale.Size = New System.Drawing.Size(93, 45)
        Me.cmdScale.TabIndex = 205
        Me.cmdScale.Text = "scale"
        Me.cmdScale.UseVisualStyleBackColor = True
        '
        'cmdTransformRHelp
        '
        Me.cmdTransformRHelp.AutoSize = True
        Me.cmdTransformRHelp.ContextMenuStrip = Me.ContextMenuStripTransform
        Me.cmdTransformRHelp.Location = New System.Drawing.Point(324, 330)
        Me.cmdTransformRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTransformRHelp.Name = "cmdTransformRHelp"
        Me.cmdTransformRHelp.Size = New System.Drawing.Size(136, 45)
        Me.cmdTransformRHelp.SplitMenuStrip = Me.ContextMenuStripTransform
        Me.cmdTransformRHelp.TabIndex = 204
        Me.cmdTransformRHelp.Text = "R Help"
        Me.cmdTransformRHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripTransform
        '
        Me.ContextMenuStripTransform.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripTransform.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BaseToolStripMenuItem, Me.DplyrToolStripMenuItem, Me.MASSToolStripMenuItem, Me.ZooToolStripMenuItem})
        Me.ContextMenuStripTransform.Name = "ContextMenuStrip1"
        Me.ContextMenuStripTransform.Size = New System.Drawing.Size(133, 132)
        '
        'BaseToolStripMenuItem
        '
        Me.BaseToolStripMenuItem.Name = "BaseToolStripMenuItem"
        Me.BaseToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.BaseToolStripMenuItem.Text = "base"
        '
        'DplyrToolStripMenuItem
        '
        Me.DplyrToolStripMenuItem.Name = "DplyrToolStripMenuItem"
        Me.DplyrToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.DplyrToolStripMenuItem.Text = "dplyr"
        '
        'MASSToolStripMenuItem
        '
        Me.MASSToolStripMenuItem.Name = "MASSToolStripMenuItem"
        Me.MASSToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.MASSToolStripMenuItem.Text = "MASS"
        '
        'ZooToolStripMenuItem
        '
        Me.ZooToolStripMenuItem.Name = "ZooToolStripMenuItem"
        Me.ZooToolStripMenuItem.Size = New System.Drawing.Size(132, 32)
        Me.ZooToolStripMenuItem.Text = "zoo"
        '
        'cmdRev
        '
        Me.cmdRev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRev.Location = New System.Drawing.Point(186, 153)
        Me.cmdRev.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRev.Name = "cmdRev"
        Me.cmdRev.Size = New System.Drawing.Size(93, 45)
        Me.cmdRev.TabIndex = 203
        Me.cmdRev.Text = "rev"
        Me.cmdRev.UseVisualStyleBackColor = True
        '
        'cmdMovProd
        '
        Me.cmdMovProd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovProd.Location = New System.Drawing.Point(186, 110)
        Me.cmdMovProd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMovProd.Name = "cmdMovProd"
        Me.cmdMovProd.Size = New System.Drawing.Size(93, 45)
        Me.cmdMovProd.TabIndex = 202
        Me.cmdMovProd.Text = "movprod"
        Me.cmdMovProd.UseVisualStyleBackColor = True
        '
        'cmdCumProd
        '
        Me.cmdCumProd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumProd.Location = New System.Drawing.Point(186, 66)
        Me.cmdCumProd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCumProd.Name = "cmdCumProd"
        Me.cmdCumProd.Size = New System.Drawing.Size(93, 45)
        Me.cmdCumProd.TabIndex = 201
        Me.cmdCumProd.Text = "cumprod"
        Me.cmdCumProd.UseVisualStyleBackColor = True
        '
        'cmdSortF
        '
        Me.cmdSortF.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSortF.Location = New System.Drawing.Point(3, 22)
        Me.cmdSortF.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSortF.Name = "cmdSortF"
        Me.cmdSortF.Size = New System.Drawing.Size(93, 45)
        Me.cmdSortF.TabIndex = 198
        Me.cmdSortF.Text = "sort"
        Me.cmdSortF.UseVisualStyleBackColor = True
        '
        'cmdNasplin
        '
        Me.cmdNasplin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNasplin.Location = New System.Drawing.Point(369, 240)
        Me.cmdNasplin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNasplin.Name = "cmdNasplin"
        Me.cmdNasplin.Size = New System.Drawing.Size(93, 45)
        Me.cmdNasplin.TabIndex = 197
        Me.cmdNasplin.Text = "nasplin"
        Me.cmdNasplin.UseVisualStyleBackColor = True
        '
        'cmdNaapprox
        '
        Me.cmdNaapprox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNaapprox.Location = New System.Drawing.Point(278, 240)
        Me.cmdNaapprox.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNaapprox.Name = "cmdNaapprox"
        Me.cmdNaapprox.Size = New System.Drawing.Size(93, 45)
        Me.cmdNaapprox.TabIndex = 196
        Me.cmdNaapprox.Text = "naapprox"
        Me.cmdNaapprox.UseVisualStyleBackColor = True
        '
        'cmdNaest
        '
        Me.cmdNaest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNaest.Location = New System.Drawing.Point(186, 240)
        Me.cmdNaest.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNaest.Name = "cmdNaest"
        Me.cmdNaest.Size = New System.Drawing.Size(93, 45)
        Me.cmdNaest.TabIndex = 195
        Me.cmdNaest.Text = "naest"
        Me.cmdNaest.UseVisualStyleBackColor = True
        '
        'cmdNafill
        '
        Me.cmdNafill.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNafill.Location = New System.Drawing.Point(94, 240)
        Me.cmdNafill.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNafill.Name = "cmdNafill"
        Me.cmdNafill.Size = New System.Drawing.Size(93, 45)
        Me.cmdNafill.TabIndex = 194
        Me.cmdNafill.Text = "nafill"
        Me.cmdNafill.UseVisualStyleBackColor = True
        '
        'cmdMovmin
        '
        Me.cmdMovmin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovmin.Location = New System.Drawing.Point(369, 110)
        Me.cmdMovmin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMovmin.Name = "cmdMovmin"
        Me.cmdMovmin.Size = New System.Drawing.Size(93, 45)
        Me.cmdMovmin.TabIndex = 193
        Me.cmdMovmin.Text = "movmin"
        Me.cmdMovmin.UseVisualStyleBackColor = True
        '
        'cmdRowRank
        '
        Me.cmdRowRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRowRank.Location = New System.Drawing.Point(94, 196)
        Me.cmdRowRank.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRowRank.Name = "cmdRowRank"
        Me.cmdRowRank.Size = New System.Drawing.Size(93, 45)
        Me.cmdRowRank.TabIndex = 192
        Me.cmdRowRank.Text = "r_rank"
        Me.cmdRowRank.UseVisualStyleBackColor = True
        '
        'cmdDiff
        '
        Me.cmdDiff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDiff.Location = New System.Drawing.Point(94, 153)
        Me.cmdDiff.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDiff.Name = "cmdDiff"
        Me.cmdDiff.Size = New System.Drawing.Size(93, 45)
        Me.cmdDiff.TabIndex = 191
        Me.cmdDiff.Text = "diff"
        Me.cmdDiff.UseVisualStyleBackColor = True
        '
        'cmdCumdist
        '
        Me.cmdCumdist.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumdist.Location = New System.Drawing.Point(369, 153)
        Me.cmdCumdist.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCumdist.Name = "cmdCumdist"
        Me.cmdCumdist.Size = New System.Drawing.Size(93, 45)
        Me.cmdCumdist.TabIndex = 190
        Me.cmdCumdist.Text = "cumdist"
        Me.cmdCumdist.UseVisualStyleBackColor = True
        '
        'cmdMovMean
        '
        Me.cmdMovMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovMean.Location = New System.Drawing.Point(278, 110)
        Me.cmdMovMean.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMovMean.Name = "cmdMovMean"
        Me.cmdMovMean.Size = New System.Drawing.Size(93, 45)
        Me.cmdMovMean.TabIndex = 189
        Me.cmdMovMean.Text = "movmean"
        Me.cmdMovMean.UseVisualStyleBackColor = True
        '
        'cmdCumMean
        '
        Me.cmdCumMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumMean.Location = New System.Drawing.Point(278, 66)
        Me.cmdCumMean.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCumMean.Name = "cmdCumMean"
        Me.cmdCumMean.Size = New System.Drawing.Size(93, 45)
        Me.cmdCumMean.TabIndex = 188
        Me.cmdCumMean.Text = "cummean"
        Me.cmdCumMean.UseVisualStyleBackColor = True
        '
        'cmdNtile
        '
        Me.cmdNtile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNtile.Location = New System.Drawing.Point(278, 153)
        Me.cmdNtile.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNtile.Name = "cmdNtile"
        Me.cmdNtile.Size = New System.Drawing.Size(93, 45)
        Me.cmdNtile.TabIndex = 187
        Me.cmdNtile.Text = "ntile"
        Me.cmdNtile.UseVisualStyleBackColor = True
        '
        'cmMovMed
        '
        Me.cmMovMed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmMovMed.Location = New System.Drawing.Point(3, 153)
        Me.cmMovMed.Margin = New System.Windows.Forms.Padding(4)
        Me.cmMovMed.Name = "cmMovMed"
        Me.cmMovMed.Size = New System.Drawing.Size(93, 45)
        Me.cmMovMed.TabIndex = 186
        Me.cmMovMed.Text = "movmed"
        Me.cmMovMed.UseVisualStyleBackColor = True
        '
        'cmdMRank
        '
        Me.cmdMRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMRank.Location = New System.Drawing.Point(369, 196)
        Me.cmdMRank.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMRank.Name = "cmdMRank"
        Me.cmdMRank.Size = New System.Drawing.Size(93, 45)
        Me.cmdMRank.TabIndex = 185
        Me.cmdMRank.Text = "m_rank"
        Me.cmdMRank.UseVisualStyleBackColor = True
        '
        'cmdDRank
        '
        Me.cmdDRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDRank.Location = New System.Drawing.Point(278, 196)
        Me.cmdDRank.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDRank.Name = "cmdDRank"
        Me.cmdDRank.Size = New System.Drawing.Size(93, 45)
        Me.cmdDRank.TabIndex = 184
        Me.cmdDRank.Text = "d_rank"
        Me.cmdDRank.UseVisualStyleBackColor = True
        '
        'cmdMovMax
        '
        Me.cmdMovMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovMax.Location = New System.Drawing.Point(3, 110)
        Me.cmdMovMax.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMovMax.Name = "cmdMovMax"
        Me.cmdMovMax.Size = New System.Drawing.Size(93, 45)
        Me.cmdMovMax.TabIndex = 183
        Me.cmdMovMax.Text = "movmax"
        Me.cmdMovMax.UseVisualStyleBackColor = True
        '
        'cmdMovSum
        '
        Me.cmdMovSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMovSum.Location = New System.Drawing.Point(94, 110)
        Me.cmdMovSum.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdMovSum.Name = "cmdMovSum"
        Me.cmdMovSum.Size = New System.Drawing.Size(93, 45)
        Me.cmdMovSum.TabIndex = 182
        Me.cmdMovSum.Text = "movsum"
        Me.cmdMovSum.UseVisualStyleBackColor = True
        '
        'cmdPercentRank
        '
        Me.cmdPercentRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPercentRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPercentRank.Location = New System.Drawing.Point(186, 196)
        Me.cmdPercentRank.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPercentRank.Name = "cmdPercentRank"
        Me.cmdPercentRank.Size = New System.Drawing.Size(93, 45)
        Me.cmdPercentRank.TabIndex = 181
        Me.cmdPercentRank.Text = "% rank"
        Me.cmdPercentRank.UseVisualStyleBackColor = True
        '
        'cmdCumSum
        '
        Me.cmdCumSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumSum.Location = New System.Drawing.Point(94, 66)
        Me.cmdCumSum.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCumSum.Name = "cmdCumSum"
        Me.cmdCumSum.Size = New System.Drawing.Size(93, 45)
        Me.cmdCumSum.TabIndex = 180
        Me.cmdCumSum.Text = "cumsum"
        Me.cmdCumSum.UseVisualStyleBackColor = True
        '
        'cmdCumMin
        '
        Me.cmdCumMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumMin.Location = New System.Drawing.Point(369, 66)
        Me.cmdCumMin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCumMin.Name = "cmdCumMin"
        Me.cmdCumMin.Size = New System.Drawing.Size(93, 45)
        Me.cmdCumMin.TabIndex = 179
        Me.cmdCumMin.Text = "cummin"
        Me.cmdCumMin.UseVisualStyleBackColor = True
        '
        'cmdCumMax
        '
        Me.cmdCumMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCumMax.Location = New System.Drawing.Point(3, 66)
        Me.cmdCumMax.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCumMax.Name = "cmdCumMax"
        Me.cmdCumMax.Size = New System.Drawing.Size(93, 45)
        Me.cmdCumMax.TabIndex = 178
        Me.cmdCumMax.Text = "cummax"
        Me.cmdCumMax.UseVisualStyleBackColor = True
        '
        'cmdPMin
        '
        Me.cmdPMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPMin.Location = New System.Drawing.Point(369, 22)
        Me.cmdPMin.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPMin.Name = "cmdPMin"
        Me.cmdPMin.Size = New System.Drawing.Size(93, 45)
        Me.cmdPMin.TabIndex = 177
        Me.cmdPMin.Text = "pmin"
        Me.cmdPMin.UseVisualStyleBackColor = True
        '
        'cmdPMax
        '
        Me.cmdPMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPMax.Location = New System.Drawing.Point(278, 22)
        Me.cmdPMax.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPMax.Name = "cmdPMax"
        Me.cmdPMax.Size = New System.Drawing.Size(93, 45)
        Me.cmdPMax.TabIndex = 176
        Me.cmdPMax.Text = "pmax"
        Me.cmdPMax.UseVisualStyleBackColor = True
        '
        'cmdLead
        '
        Me.cmdLead.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLead.Location = New System.Drawing.Point(186, 22)
        Me.cmdLead.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLead.Name = "cmdLead"
        Me.cmdLead.Size = New System.Drawing.Size(93, 45)
        Me.cmdLead.TabIndex = 175
        Me.cmdLead.Text = "lead"
        Me.cmdLead.UseVisualStyleBackColor = True
        '
        'cmdLag
        '
        Me.cmdLag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLag.Location = New System.Drawing.Point(94, 22)
        Me.cmdLag.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLag.Name = "cmdLag"
        Me.cmdLag.Size = New System.Drawing.Size(93, 45)
        Me.cmdLag.TabIndex = 174
        Me.cmdLag.Text = "lag"
        Me.cmdLag.UseVisualStyleBackColor = True
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
        Me.grpLogical.Location = New System.Drawing.Point(650, 93)
        Me.grpLogical.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLogical.Name = "grpLogical"
        Me.grpLogical.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.grpLogical.Size = New System.Drawing.Size(387, 320)
        Me.grpLogical.TabIndex = 183
        Me.grpLogical.TabStop = False
        Me.grpLogical.Text = "Logical and Symbols"
        '
        'cmdLogicalHelp
        '
        Me.cmdLogicalHelp.AutoSize = True
        Me.cmdLogicalHelp.ContextMenuStrip = Me.ContextMenuStripLogical
        Me.cmdLogicalHelp.Location = New System.Drawing.Point(279, 280)
        Me.cmdLogicalHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdLogicalHelp.Name = "cmdLogicalHelp"
        Me.cmdLogicalHelp.Size = New System.Drawing.Size(129, 45)
        Me.cmdLogicalHelp.SplitMenuStrip = Me.ContextMenuStripLogical
        Me.cmdLogicalHelp.TabIndex = 212
        Me.cmdLogicalHelp.Text = "R Help"
        Me.cmdLogicalHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripLogical
        '
        Me.ContextMenuStripLogical.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripLogical.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogBaseToolStripMenuItem, Me.LogDplyrToolStripMenuItem})
        Me.ContextMenuStripLogical.Name = "ContextMenuStrip1"
        Me.ContextMenuStripLogical.Size = New System.Drawing.Size(126, 68)
        '
        'LogBaseToolStripMenuItem
        '
        Me.LogBaseToolStripMenuItem.Name = "LogBaseToolStripMenuItem"
        Me.LogBaseToolStripMenuItem.Size = New System.Drawing.Size(125, 32)
        Me.LogBaseToolStripMenuItem.Text = "base"
        '
        'LogDplyrToolStripMenuItem
        '
        Me.LogDplyrToolStripMenuItem.Name = "LogDplyrToolStripMenuItem"
        Me.LogDplyrToolStripMenuItem.Size = New System.Drawing.Size(125, 32)
        Me.LogDplyrToolStripMenuItem.Text = "dplyr"
        '
        'cmdFalse
        '
        Me.cmdFalse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFalse.Location = New System.Drawing.Point(303, 63)
        Me.cmdFalse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdFalse.Name = "cmdFalse"
        Me.cmdFalse.Size = New System.Drawing.Size(78, 45)
        Me.cmdFalse.TabIndex = 207
        Me.cmdFalse.Text = "FALSE"
        Me.cmdFalse.UseVisualStyleBackColor = True
        '
        'cmdTrue
        '
        Me.cmdTrue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrue.Location = New System.Drawing.Point(303, 20)
        Me.cmdTrue.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdTrue.Name = "cmdTrue"
        Me.cmdTrue.Size = New System.Drawing.Size(78, 45)
        Me.cmdTrue.TabIndex = 206
        Me.cmdTrue.Text = "TRUE"
        Me.cmdTrue.UseVisualStyleBackColor = True
        '
        'cmdDoubleSqrBrackets
        '
        Me.cmdDoubleSqrBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDoubleSqrBrackets.Location = New System.Drawing.Point(192, 106)
        Me.cmdDoubleSqrBrackets.Name = "cmdDoubleSqrBrackets"
        Me.cmdDoubleSqrBrackets.Size = New System.Drawing.Size(54, 45)
        Me.cmdDoubleSqrBrackets.TabIndex = 205
        Me.cmdDoubleSqrBrackets.Text = "[[ ]]"
        Me.cmdDoubleSqrBrackets.UseVisualStyleBackColor = True
        '
        'cmdIn
        '
        Me.cmdIn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIn.Location = New System.Drawing.Point(192, 150)
        Me.cmdIn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdIn.Name = "cmdIn"
        Me.cmdIn.Size = New System.Drawing.Size(98, 45)
        Me.cmdIn.TabIndex = 204
        Me.cmdIn.Text = "%in%"
        Me.cmdIn.UseVisualStyleBackColor = True
        '
        'cmdWhich
        '
        Me.cmdWhich.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdWhich.Location = New System.Drawing.Point(288, 150)
        Me.cmdWhich.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWhich.Name = "cmdWhich"
        Me.cmdWhich.Size = New System.Drawing.Size(93, 45)
        Me.cmdWhich.TabIndex = 203
        Me.cmdWhich.Text = "which"
        Me.cmdWhich.UseVisualStyleBackColor = True
        '
        'cmdNA
        '
        Me.cmdNA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNA.Location = New System.Drawing.Point(244, 63)
        Me.cmdNA.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdNA.Name = "cmdNA"
        Me.cmdNA.Size = New System.Drawing.Size(60, 45)
        Me.cmdNA.TabIndex = 202
        Me.cmdNA.Text = "NA"
        Me.cmdNA.UseVisualStyleBackColor = True
        '
        'cmdNear
        '
        Me.cmdNear.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNear.Location = New System.Drawing.Point(288, 237)
        Me.cmdNear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNear.Name = "cmdNear"
        Me.cmdNear.Size = New System.Drawing.Size(93, 45)
        Me.cmdNear.TabIndex = 201
        Me.cmdNear.Text = "near"
        Me.cmdNear.UseVisualStyleBackColor = True
        '
        'cmdBetween
        '
        Me.cmdBetween.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBetween.Location = New System.Drawing.Point(288, 194)
        Me.cmdBetween.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdBetween.Name = "cmdBetween"
        Me.cmdBetween.Size = New System.Drawing.Size(93, 45)
        Me.cmdBetween.TabIndex = 200
        Me.cmdBetween.Text = "between"
        Me.cmdBetween.UseVisualStyleBackColor = True
        '
        'cmdIsNa
        '
        Me.cmdIsNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIsNa.Location = New System.Drawing.Point(6, 237)
        Me.cmdIsNa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIsNa.Name = "cmdIsNa"
        Me.cmdIsNa.Size = New System.Drawing.Size(93, 45)
        Me.cmdIsNa.TabIndex = 195
        Me.cmdIsNa.Text = "is.na"
        Me.cmdIsNa.UseVisualStyleBackColor = True
        '
        'cmdNotIsNa
        '
        Me.cmdNotIsNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNotIsNa.Location = New System.Drawing.Point(98, 237)
        Me.cmdNotIsNa.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdNotIsNa.Name = "cmdNotIsNa"
        Me.cmdNotIsNa.Size = New System.Drawing.Size(94, 45)
        Me.cmdNotIsNa.TabIndex = 194
        Me.cmdNotIsNa.Text = "!is.na"
        Me.cmdNotIsNa.UseVisualStyleBackColor = True
        '
        'cmdDuplicate
        '
        Me.cmdDuplicate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDuplicate.Location = New System.Drawing.Point(192, 237)
        Me.cmdDuplicate.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDuplicate.Name = "cmdDuplicate"
        Me.cmdDuplicate.Size = New System.Drawing.Size(98, 45)
        Me.cmdDuplicate.TabIndex = 193
        Me.cmdDuplicate.Text = "duplicated"
        Me.cmdDuplicate.UseVisualStyleBackColor = True
        '
        'cmdIfelse
        '
        Me.cmdIfelse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIfelse.Location = New System.Drawing.Point(6, 194)
        Me.cmdIfelse.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdIfelse.Name = "cmdIfelse"
        Me.cmdIfelse.Size = New System.Drawing.Size(93, 45)
        Me.cmdIfelse.TabIndex = 192
        Me.cmdIfelse.Text = "ifelse"
        Me.cmdIfelse.UseVisualStyleBackColor = True
        '
        'cmdmatch
        '
        Me.cmdmatch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdmatch.Location = New System.Drawing.Point(98, 194)
        Me.cmdmatch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdmatch.Name = "cmdmatch"
        Me.cmdmatch.Size = New System.Drawing.Size(94, 45)
        Me.cmdmatch.TabIndex = 191
        Me.cmdmatch.Text = "match"
        Me.cmdmatch.UseVisualStyleBackColor = True
        '
        'cmdwhen
        '
        Me.cmdwhen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdwhen.Location = New System.Drawing.Point(192, 194)
        Me.cmdwhen.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdwhen.Name = "cmdwhen"
        Me.cmdwhen.Size = New System.Drawing.Size(98, 45)
        Me.cmdwhen.TabIndex = 190
        Me.cmdwhen.Text = "when"
        Me.cmdwhen.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        Me.cmdOpeningBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOpeningBracket.Location = New System.Drawing.Point(244, 106)
        Me.cmdOpeningBracket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.Size = New System.Drawing.Size(60, 45)
        Me.cmdOpeningBracket.TabIndex = 139
        Me.cmdOpeningBracket.Text = "("
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        Me.cmdColon.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cmdColon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdColon.Location = New System.Drawing.Point(64, 106)
        Me.cmdColon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.Size = New System.Drawing.Size(60, 45)
        Me.cmdColon.TabIndex = 139
        Me.cmdColon.Text = ":"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdGreaterOrEqualsTo
        '
        Me.cmdGreaterOrEqualsTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGreaterOrEqualsTo.Location = New System.Drawing.Point(192, 20)
        Me.cmdGreaterOrEqualsTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdGreaterOrEqualsTo.Name = "cmdGreaterOrEqualsTo"
        Me.cmdGreaterOrEqualsTo.Size = New System.Drawing.Size(54, 45)
        Me.cmdGreaterOrEqualsTo.TabIndex = 138
        Me.cmdGreaterOrEqualsTo.Text = ">="
        Me.cmdGreaterOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdClossingBracket
        '
        Me.cmdClossingBracket.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdClossingBracket.Location = New System.Drawing.Point(303, 106)
        Me.cmdClossingBracket.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdClossingBracket.Name = "cmdClossingBracket"
        Me.cmdClossingBracket.Size = New System.Drawing.Size(78, 45)
        Me.cmdClossingBracket.TabIndex = 137
        Me.cmdClossingBracket.Tag = ""
        Me.cmdClossingBracket.Text = ")"
        Me.cmdClossingBracket.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        Me.cmdAnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdAnd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAnd.Location = New System.Drawing.Point(192, 63)
        Me.cmdAnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Size = New System.Drawing.Size(54, 45)
        Me.cmdAnd.TabIndex = 137
        Me.cmdAnd.Tag = "And"
        Me.cmdAnd.Text = "&&"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdQuotes
        '
        Me.cmdQuotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdQuotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdQuotes.Location = New System.Drawing.Point(244, 20)
        Me.cmdQuotes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.Size = New System.Drawing.Size(60, 45)
        Me.cmdQuotes.TabIndex = 135
        Me.cmdQuotes.Text = """ """
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        Me.cmdSquareBrackets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquareBrackets.Location = New System.Drawing.Point(123, 106)
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.Size = New System.Drawing.Size(69, 45)
        Me.cmdSquareBrackets.TabIndex = 134
        Me.cmdSquareBrackets.Text = "[ ]"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdIntegerDivision
        '
        Me.cmdIntegerDivision.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdIntegerDivision.Location = New System.Drawing.Point(98, 150)
        Me.cmdIntegerDivision.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdIntegerDivision.Name = "cmdIntegerDivision"
        Me.cmdIntegerDivision.Size = New System.Drawing.Size(94, 45)
        Me.cmdIntegerDivision.TabIndex = 135
        Me.cmdIntegerDivision.Text = "div (%/%)"
        Me.cmdIntegerDivision.UseVisualStyleBackColor = True
        '
        'cmdModulas
        '
        Me.cmdModulas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdModulas.Location = New System.Drawing.Point(6, 150)
        Me.cmdModulas.Name = "cmdModulas"
        Me.cmdModulas.Size = New System.Drawing.Size(93, 45)
        Me.cmdModulas.TabIndex = 134
        Me.cmdModulas.Text = "mod (%%)"
        Me.cmdModulas.UseVisualStyleBackColor = True
        '
        'cmdGreater
        '
        Me.cmdGreater.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGreater.Location = New System.Drawing.Point(123, 20)
        Me.cmdGreater.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.Size = New System.Drawing.Size(69, 45)
        Me.cmdGreater.TabIndex = 133
        Me.cmdGreater.Text = ">"
        Me.cmdGreater.UseVisualStyleBackColor = True
        '
        'cmdLesserOrEqualsTo
        '
        Me.cmdLesserOrEqualsTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLesserOrEqualsTo.Location = New System.Drawing.Point(64, 20)
        Me.cmdLesserOrEqualsTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLesserOrEqualsTo.Name = "cmdLesserOrEqualsTo"
        Me.cmdLesserOrEqualsTo.Size = New System.Drawing.Size(60, 45)
        Me.cmdLesserOrEqualsTo.TabIndex = 132
        Me.cmdLesserOrEqualsTo.Text = "<="
        Me.cmdLesserOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdLesser
        '
        Me.cmdLesser.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLesser.Location = New System.Drawing.Point(6, 20)
        Me.cmdLesser.Name = "cmdLesser"
        Me.cmdLesser.Size = New System.Drawing.Size(58, 45)
        Me.cmdLesser.TabIndex = 131
        Me.cmdLesser.Text = "<"
        Me.cmdLesser.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        Me.cmdOr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr.Location = New System.Drawing.Point(123, 63)
        Me.cmdOr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.Size = New System.Drawing.Size(69, 45)
        Me.cmdOr.TabIndex = 130
        Me.cmdOr.Text = "|"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'cmdNot
        '
        Me.cmdNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cmdNot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNot.Location = New System.Drawing.Point(6, 106)
        Me.cmdNot.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdNot.Name = "cmdNot"
        Me.cmdNot.Size = New System.Drawing.Size(58, 45)
        Me.cmdNot.TabIndex = 129
        Me.cmdNot.Text = "!"
        Me.cmdNot.UseVisualStyleBackColor = True
        '
        'cmdNotEqualsTo
        '
        Me.cmdNotEqualsTo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNotEqualsTo.Location = New System.Drawing.Point(64, 63)
        Me.cmdNotEqualsTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdNotEqualsTo.Name = "cmdNotEqualsTo"
        Me.cmdNotEqualsTo.Size = New System.Drawing.Size(60, 45)
        Me.cmdNotEqualsTo.TabIndex = 128
        Me.cmdNotEqualsTo.Text = "!="
        Me.cmdNotEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdEquivalent
        '
        Me.cmdEquivalent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEquivalent.Location = New System.Drawing.Point(6, 63)
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.Size = New System.Drawing.Size(58, 45)
        Me.cmdEquivalent.TabIndex = 127
        Me.cmdEquivalent.Text = "=="
        Me.cmdEquivalent.UseVisualStyleBackColor = True
        '
        'grpTestString
        '
        Me.grpTestString.Controls.Add(Me.cmdReverseStr)
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
        Me.grpTestString.Location = New System.Drawing.Point(651, 92)
        Me.grpTestString.Margin = New System.Windows.Forms.Padding(4)
        Me.grpTestString.Name = "grpTestString"
        Me.grpTestString.Padding = New System.Windows.Forms.Padding(4)
        Me.grpTestString.Size = New System.Drawing.Size(454, 246)
        Me.grpTestString.TabIndex = 186
        Me.grpTestString.TabStop = False
        Me.grpTestString.Text = "Text/Strings (Character Columns)"
        '
        'cmdReverseStr
        '
        Me.cmdReverseStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdReverseStr.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReverseStr.Location = New System.Drawing.Point(369, 153)
        Me.cmdReverseStr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdReverseStr.Name = "cmdReverseStr"
        Me.cmdReverseStr.Size = New System.Drawing.Size(78, 45)
        Me.cmdReverseStr.TabIndex = 165
        Me.cmdReverseStr.Tag = ""
        Me.cmdReverseStr.Text = "reverse"
        Me.cmdReverseStr.UseVisualStyleBackColor = True
        '
        'cmdEnds
        '
        Me.cmdEnds.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnds.Location = New System.Drawing.Point(180, 110)
        Me.cmdEnds.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEnds.Name = "cmdEnds"
        Me.cmdEnds.Size = New System.Drawing.Size(90, 45)
        Me.cmdEnds.TabIndex = 164
        Me.cmdEnds.Text = "ends"
        Me.cmdEnds.UseVisualStyleBackColor = True
        '
        'cmdTrunck
        '
        Me.cmdTrunck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrunck.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrunck.Location = New System.Drawing.Point(369, 196)
        Me.cmdTrunck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTrunck.Name = "cmdTrunck"
        Me.cmdTrunck.Size = New System.Drawing.Size(78, 45)
        Me.cmdTrunck.TabIndex = 163
        Me.cmdTrunck.Text = "trunc "
        Me.cmdTrunck.UseVisualStyleBackColor = True
        '
        'cmdLenth
        '
        Me.cmdLenth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLenth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLenth.Location = New System.Drawing.Point(242, 153)
        Me.cmdLenth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLenth.Name = "cmdLenth"
        Me.cmdLenth.Size = New System.Drawing.Size(66, 45)
        Me.cmdLenth.TabIndex = 162
        Me.cmdLenth.Text = "length"
        Me.cmdLenth.UseVisualStyleBackColor = True
        '
        'cmdGlue
        '
        Me.cmdGlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdGlue.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdGlue.Location = New System.Drawing.Point(306, 153)
        Me.cmdGlue.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdGlue.Name = "cmdGlue"
        Me.cmdGlue.Size = New System.Drawing.Size(64, 45)
        Me.cmdGlue.TabIndex = 161
        Me.cmdGlue.Text = "glue"
        Me.cmdGlue.UseVisualStyleBackColor = True
        '
        'cmdStarts
        '
        Me.cmdStarts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdStarts.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStarts.Location = New System.Drawing.Point(302, 196)
        Me.cmdStarts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdStarts.Name = "cmdStarts"
        Me.cmdStarts.Size = New System.Drawing.Size(69, 45)
        Me.cmdStarts.TabIndex = 160
        Me.cmdStarts.Tag = ""
        Me.cmdStarts.Text = "starts"
        Me.cmdStarts.UseVisualStyleBackColor = True
        '
        'cmdReplace2
        '
        Me.cmdReplace2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdReplace2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReplace2.Location = New System.Drawing.Point(165, 196)
        Me.cmdReplace2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdReplace2.Name = "cmdReplace2"
        Me.cmdReplace2.Size = New System.Drawing.Size(90, 45)
        Me.cmdReplace2.TabIndex = 159
        Me.cmdReplace2.Tag = ""
        Me.cmdReplace2.Text = "replace2"
        Me.cmdReplace2.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        Me.cmdReplace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdReplace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReplace.Location = New System.Drawing.Point(92, 196)
        Me.cmdReplace.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.Size = New System.Drawing.Size(75, 45)
        Me.cmdReplace.TabIndex = 158
        Me.cmdReplace.Tag = ""
        Me.cmdReplace.Text = "replace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdRemove2
        '
        Me.cmdRemove2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRemove2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemove2.Location = New System.Drawing.Point(3, 196)
        Me.cmdRemove2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRemove2.Name = "cmdRemove2"
        Me.cmdRemove2.Size = New System.Drawing.Size(90, 45)
        Me.cmdRemove2.TabIndex = 157
        Me.cmdRemove2.Tag = ""
        Me.cmdRemove2.Text = "remove2"
        Me.cmdRemove2.UseVisualStyleBackColor = True
        '
        'cmdRemove1
        '
        Me.cmdRemove1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdRemove1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRemove1.Location = New System.Drawing.Point(165, 153)
        Me.cmdRemove1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdRemove1.Name = "cmdRemove1"
        Me.cmdRemove1.Size = New System.Drawing.Size(78, 45)
        Me.cmdRemove1.TabIndex = 156
        Me.cmdRemove1.Tag = ""
        Me.cmdRemove1.Text = "remove"
        Me.cmdRemove1.UseVisualStyleBackColor = True
        '
        'cmdLocate2
        '
        Me.cmdLocate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLocate2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLocate2.Location = New System.Drawing.Point(92, 153)
        Me.cmdLocate2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLocate2.Name = "cmdLocate2"
        Me.cmdLocate2.Size = New System.Drawing.Size(75, 45)
        Me.cmdLocate2.TabIndex = 155
        Me.cmdLocate2.Tag = ""
        Me.cmdLocate2.Text = "locate2"
        Me.cmdLocate2.UseVisualStyleBackColor = True
        '
        'cmdExtract2
        '
        Me.cmdExtract2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExtract2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExtract2.Location = New System.Drawing.Point(357, 110)
        Me.cmdExtract2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExtract2.Name = "cmdExtract2"
        Me.cmdExtract2.Size = New System.Drawing.Size(90, 45)
        Me.cmdExtract2.TabIndex = 154
        Me.cmdExtract2.Tag = ""
        Me.cmdExtract2.Text = "extract2"
        Me.cmdExtract2.UseVisualStyleBackColor = True
        '
        'cmdEncodeb
        '
        Me.cmdEncodeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdEncodeb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEncodeb.Location = New System.Drawing.Point(357, 66)
        Me.cmdEncodeb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdEncodeb.Name = "cmdEncodeb"
        Me.cmdEncodeb.Size = New System.Drawing.Size(90, 45)
        Me.cmdEncodeb.TabIndex = 151
        Me.cmdEncodeb.Text = "encode "
        Me.cmdEncodeb.UseVisualStyleBackColor = True
        '
        'cmdSquishb
        '
        Me.cmdSquishb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSquishb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSquishb.Location = New System.Drawing.Point(357, 22)
        Me.cmdSquishb.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSquishb.Name = "cmdSquishb"
        Me.cmdSquishb.Size = New System.Drawing.Size(90, 45)
        Me.cmdSquishb.TabIndex = 150
        Me.cmdSquishb.Text = "squish "
        Me.cmdSquishb.UseVisualStyleBackColor = True
        '
        'cmdSub
        '
        Me.cmdSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSub.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSub.Location = New System.Drawing.Point(254, 196)
        Me.cmdSub.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSub.Name = "cmdSub"
        Me.cmdSub.Size = New System.Drawing.Size(50, 45)
        Me.cmdSub.TabIndex = 149
        Me.cmdSub.Tag = ""
        Me.cmdSub.Text = "sub"
        Me.cmdSub.UseVisualStyleBackColor = True
        '
        'cmdCombine
        '
        Me.cmdCombine.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCombine.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCombine.Location = New System.Drawing.Point(268, 66)
        Me.cmdCombine.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCombine.Name = "cmdCombine"
        Me.cmdCombine.Size = New System.Drawing.Size(90, 45)
        Me.cmdCombine.TabIndex = 148
        Me.cmdCombine.Text = "combine"
        Me.cmdCombine.UseVisualStyleBackColor = True
        '
        'cmdDetect
        '
        Me.cmdDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdDetect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDetect.Location = New System.Drawing.Point(92, 110)
        Me.cmdDetect.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Size = New System.Drawing.Size(90, 45)
        Me.cmdDetect.TabIndex = 147
        Me.cmdDetect.Tag = ""
        Me.cmdDetect.Text = "detect"
        Me.cmdDetect.UseVisualStyleBackColor = True
        '
        'cmdTrim
        '
        Me.cmdTrim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTrim.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTrim.Location = New System.Drawing.Point(268, 22)
        Me.cmdTrim.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTrim.Name = "cmdTrim"
        Me.cmdTrim.Size = New System.Drawing.Size(90, 45)
        Me.cmdTrim.TabIndex = 146
        Me.cmdTrim.Text = "trim"
        Me.cmdTrim.UseVisualStyleBackColor = True
        '
        'cmdTitle
        '
        Me.cmdTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitle.Location = New System.Drawing.Point(180, 22)
        Me.cmdTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.Size = New System.Drawing.Size(90, 45)
        Me.cmdTitle.TabIndex = 142
        Me.cmdTitle.Text = "title"
        Me.cmdTitle.UseVisualStyleBackColor = True
        '
        'cmdLower
        '
        Me.cmdLower.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLower.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLower.Location = New System.Drawing.Point(92, 22)
        Me.cmdLower.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLower.Name = "cmdLower"
        Me.cmdLower.Size = New System.Drawing.Size(90, 45)
        Me.cmdLower.TabIndex = 141
        Me.cmdLower.Text = "lower"
        Me.cmdLower.UseVisualStyleBackColor = True
        '
        'cmdUpper
        '
        Me.cmdUpper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdUpper.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdUpper.Location = New System.Drawing.Point(3, 22)
        Me.cmdUpper.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdUpper.Name = "cmdUpper"
        Me.cmdUpper.Size = New System.Drawing.Size(90, 45)
        Me.cmdUpper.TabIndex = 140
        Me.cmdUpper.Text = "upper"
        Me.cmdUpper.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        Me.cmdSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdSort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSort.Location = New System.Drawing.Point(180, 66)
        Me.cmdSort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.Size = New System.Drawing.Size(90, 45)
        Me.cmdSort.TabIndex = 139
        Me.cmdSort.Text = "sort"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdOrder
        '
        Me.cmdOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdOrder.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOrder.Location = New System.Drawing.Point(92, 66)
        Me.cmdOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.Size = New System.Drawing.Size(90, 45)
        Me.cmdOrder.TabIndex = 138
        Me.cmdOrder.Text = "order"
        Me.cmdOrder.UseVisualStyleBackColor = True
        '
        'cmdPad
        '
        Me.cmdPad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdPad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPad.Location = New System.Drawing.Point(3, 66)
        Me.cmdPad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdPad.Name = "cmdPad"
        Me.cmdPad.Size = New System.Drawing.Size(90, 45)
        Me.cmdPad.TabIndex = 137
        Me.cmdPad.Text = "pad"
        Me.cmdPad.UseVisualStyleBackColor = True
        '
        'cmdExtract
        '
        Me.cmdExtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdExtract.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdExtract.Location = New System.Drawing.Point(268, 110)
        Me.cmdExtract.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.Size = New System.Drawing.Size(90, 45)
        Me.cmdExtract.TabIndex = 136
        Me.cmdExtract.Text = "extract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCountstrings
        '
        Me.cmdCountstrings.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdCountstrings.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCountstrings.Location = New System.Drawing.Point(3, 110)
        Me.cmdCountstrings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdCountstrings.Name = "cmdCountstrings"
        Me.cmdCountstrings.Size = New System.Drawing.Size(90, 45)
        Me.cmdCountstrings.TabIndex = 134
        Me.cmdCountstrings.Text = "count"
        Me.cmdCountstrings.UseVisualStyleBackColor = True
        '
        'cmdLocate
        '
        Me.cmdLocate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdLocate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdLocate.Location = New System.Drawing.Point(3, 153)
        Me.cmdLocate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdLocate.Name = "cmdLocate"
        Me.cmdLocate.Size = New System.Drawing.Size(90, 45)
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
        Me.grpCircular.Location = New System.Drawing.Point(651, 92)
        Me.grpCircular.Name = "grpCircular"
        Me.grpCircular.Size = New System.Drawing.Size(372, 252)
        Me.grpCircular.TabIndex = 192
        Me.grpCircular.TabStop = False
        Me.grpCircular.Text = "Circular"
        '
        'cmdCircularHelp
        '
        Me.cmdCircularHelp.AutoSize = True
        Me.cmdCircularHelp.ContextMenuStrip = Me.ContextMenuStripCircular
        Me.cmdCircularHelp.Location = New System.Drawing.Point(261, 213)
        Me.cmdCircularHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCircularHelp.Name = "cmdCircularHelp"
        Me.cmdCircularHelp.Size = New System.Drawing.Size(129, 45)
        Me.cmdCircularHelp.SplitMenuStrip = Me.ContextMenuStripCircular
        Me.cmdCircularHelp.TabIndex = 212
        Me.cmdCircularHelp.Text = "R Help"
        Me.cmdCircularHelp.UseVisualStyleBackColor = True
        '
        'ContextMenuStripCircular
        '
        Me.ContextMenuStripCircular.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripCircular.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CircularToolStripMenuItem})
        Me.ContextMenuStripCircular.Name = "ContextMenuStrip1"
        Me.ContextMenuStripCircular.Size = New System.Drawing.Size(140, 36)
        '
        'CircularToolStripMenuItem
        '
        Me.CircularToolStripMenuItem.Name = "CircularToolStripMenuItem"
        Me.CircularToolStripMenuItem.Size = New System.Drawing.Size(139, 32)
        Me.CircularToolStripMenuItem.Text = "circular"
        '
        'cmdCircular
        '
        Me.cmdCircular.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircular.Location = New System.Drawing.Point(3, 27)
        Me.cmdCircular.Name = "cmdCircular"
        Me.cmdCircular.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircular.TabIndex = 15
        Me.cmdCircular.Text = "circular"
        Me.cmdCircular.UseVisualStyleBackColor = True
        '
        'cmdCircQuantile
        '
        Me.cmdCircQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircQuantile.Location = New System.Drawing.Point(180, 120)
        Me.cmdCircQuantile.Name = "cmdCircQuantile"
        Me.cmdCircQuantile.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircQuantile.TabIndex = 13
        Me.cmdCircQuantile.Text = "quantile"
        Me.cmdCircQuantile.UseVisualStyleBackColor = True
        '
        'cmdCircMax
        '
        Me.cmdCircMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMax.Location = New System.Drawing.Point(268, 166)
        Me.cmdCircMax.Name = "cmdCircMax"
        Me.cmdCircMax.Size = New System.Drawing.Size(98, 48)
        Me.cmdCircMax.TabIndex = 10
        Me.cmdCircMax.Text = "max"
        Me.cmdCircMax.UseVisualStyleBackColor = True
        '
        'cmdA1
        '
        Me.cmdA1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdA1.Location = New System.Drawing.Point(3, 120)
        Me.cmdA1.Name = "cmdA1"
        Me.cmdA1.Size = New System.Drawing.Size(90, 48)
        Me.cmdA1.TabIndex = 8
        Me.cmdA1.Text = "A1"
        Me.cmdA1.UseVisualStyleBackColor = True
        '
        'cmdAngVar
        '
        Me.cmdAngVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAngVar.Location = New System.Drawing.Point(92, 120)
        Me.cmdAngVar.Name = "cmdAngVar"
        Me.cmdAngVar.Size = New System.Drawing.Size(90, 48)
        Me.cmdAngVar.TabIndex = 6
        Me.cmdAngVar.Text = "ang.var"
        Me.cmdAngVar.UseVisualStyleBackColor = True
        '
        'cmdCircRho
        '
        Me.cmdCircRho.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircRho.Location = New System.Drawing.Point(268, 120)
        Me.cmdCircRho.Name = "cmdCircRho"
        Me.cmdCircRho.Size = New System.Drawing.Size(98, 48)
        Me.cmdCircRho.TabIndex = 14
        Me.cmdCircRho.Text = "rho"
        Me.cmdCircRho.UseVisualStyleBackColor = True
        '
        'cmdCircQ3
        '
        Me.cmdCircQ3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircQ3.Location = New System.Drawing.Point(180, 166)
        Me.cmdCircQ3.Name = "cmdCircQ3"
        Me.cmdCircQ3.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircQ3.TabIndex = 12
        Me.cmdCircQ3.Text = "q3"
        Me.cmdCircQ3.UseVisualStyleBackColor = True
        '
        'cmdCircQ1
        '
        Me.cmdCircQ1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircQ1.Location = New System.Drawing.Point(92, 166)
        Me.cmdCircQ1.Name = "cmdCircQ1"
        Me.cmdCircQ1.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircQ1.TabIndex = 11
        Me.cmdCircQ1.Text = "q1"
        Me.cmdCircQ1.UseVisualStyleBackColor = True
        '
        'cmdCircMin
        '
        Me.cmdCircMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMin.Location = New System.Drawing.Point(3, 166)
        Me.cmdCircMin.Name = "cmdCircMin"
        Me.cmdCircMin.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircMin.TabIndex = 9
        Me.cmdCircMin.Text = "min"
        Me.cmdCircMin.UseVisualStyleBackColor = True
        '
        'cmdAngDev
        '
        Me.cmdAngDev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAngDev.Location = New System.Drawing.Point(180, 74)
        Me.cmdAngDev.Name = "cmdAngDev"
        Me.cmdAngDev.Size = New System.Drawing.Size(90, 48)
        Me.cmdAngDev.TabIndex = 7
        Me.cmdAngDev.Text = "ang.dev"
        Me.cmdAngDev.UseVisualStyleBackColor = True
        '
        'cmdCircVar
        '
        Me.cmdCircVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircVar.Location = New System.Drawing.Point(268, 74)
        Me.cmdCircVar.Name = "cmdCircVar"
        Me.cmdCircVar.Size = New System.Drawing.Size(98, 48)
        Me.cmdCircVar.TabIndex = 5
        Me.cmdCircVar.Text = "var"
        Me.cmdCircVar.UseVisualStyleBackColor = True
        '
        'cmdCircSd
        '
        Me.cmdCircSd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircSd.Location = New System.Drawing.Point(92, 74)
        Me.cmdCircSd.Name = "cmdCircSd"
        Me.cmdCircSd.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircSd.TabIndex = 4
        Me.cmdCircSd.Text = "sd"
        Me.cmdCircSd.UseVisualStyleBackColor = True
        '
        'cmdCircRange
        '
        Me.cmdCircRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircRange.Location = New System.Drawing.Point(3, 74)
        Me.cmdCircRange.Name = "cmdCircRange"
        Me.cmdCircRange.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircRange.TabIndex = 3
        Me.cmdCircRange.Text = "range"
        Me.cmdCircRange.UseVisualStyleBackColor = True
        '
        'cmdMedianHL
        '
        Me.cmdMedianHL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMedianHL.Location = New System.Drawing.Point(268, 27)
        Me.cmdMedianHL.Name = "cmdMedianHL"
        Me.cmdMedianHL.Size = New System.Drawing.Size(98, 48)
        Me.cmdMedianHL.TabIndex = 2
        Me.cmdMedianHL.Text = "medianHL"
        Me.cmdMedianHL.UseVisualStyleBackColor = True
        '
        'cmdCircMedian
        '
        Me.cmdCircMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMedian.Location = New System.Drawing.Point(180, 27)
        Me.cmdCircMedian.Name = "cmdCircMedian"
        Me.cmdCircMedian.Size = New System.Drawing.Size(90, 48)
        Me.cmdCircMedian.TabIndex = 1
        Me.cmdCircMedian.Text = "median"
        Me.cmdCircMedian.UseVisualStyleBackColor = True
        '
        'cmdCircMean
        '
        Me.cmdCircMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCircMean.Location = New System.Drawing.Point(92, 27)
        Me.cmdCircMean.Name = "cmdCircMean"
        Me.cmdCircMean.Size = New System.Drawing.Size(90, 48)
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
        Me.grpModifier.Location = New System.Drawing.Point(651, 344)
        Me.grpModifier.Name = "grpModifier"
        Me.grpModifier.Size = New System.Drawing.Size(384, 80)
        Me.grpModifier.TabIndex = 192
        Me.grpModifier.TabStop = False
        Me.grpModifier.Text = "Modifier"
        '
        'cmdRegex
        '
        Me.cmdRegex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdRegex.Location = New System.Drawing.Point(282, 20)
        Me.cmdRegex.Name = "cmdRegex"
        Me.cmdRegex.Size = New System.Drawing.Size(94, 45)
        Me.cmdRegex.TabIndex = 3
        Me.cmdRegex.Text = "regex"
        Me.cmdRegex.UseVisualStyleBackColor = True
        '
        'cmdFixed
        '
        Me.cmdFixed.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdFixed.Location = New System.Drawing.Point(189, 20)
        Me.cmdFixed.Name = "cmdFixed"
        Me.cmdFixed.Size = New System.Drawing.Size(94, 45)
        Me.cmdFixed.TabIndex = 2
        Me.cmdFixed.Text = "fixed"
        Me.cmdFixed.UseVisualStyleBackColor = True
        '
        'cmdCollate
        '
        Me.cmdCollate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdCollate.Location = New System.Drawing.Point(96, 20)
        Me.cmdCollate.Name = "cmdCollate"
        Me.cmdCollate.Size = New System.Drawing.Size(94, 45)
        Me.cmdCollate.TabIndex = 1
        Me.cmdCollate.Text = "collate"
        Me.cmdCollate.UseVisualStyleBackColor = True
        '
        'cmdBoundary
        '
        Me.cmdBoundary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdBoundary.Location = New System.Drawing.Point(3, 20)
        Me.cmdBoundary.Name = "cmdBoundary"
        Me.cmdBoundary.Size = New System.Drawing.Size(94, 45)
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
        Me.grpSymbols.Location = New System.Drawing.Point(650, 426)
        Me.grpSymbols.Name = "grpSymbols"
        Me.grpSymbols.Size = New System.Drawing.Size(474, 168)
        Me.grpSymbols.TabIndex = 193
        Me.grpSymbols.TabStop = False
        Me.grpSymbols.Text = "Symbols"
        '
        'cmdOr3
        '
        Me.cmdOr3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr3.Location = New System.Drawing.Point(190, 69)
        Me.cmdOr3.Name = "cmdOr3"
        Me.cmdOr3.Size = New System.Drawing.Size(94, 45)
        Me.cmdOr3.TabIndex = 16
        Me.cmdOr3.Text = "| or"
        Me.cmdOr3.UseVisualStyleBackColor = True
        '
        'cmdEscape
        '
        Me.cmdEscape.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEscape.Location = New System.Drawing.Point(284, 112)
        Me.cmdEscape.Name = "cmdEscape"
        Me.cmdEscape.Size = New System.Drawing.Size(94, 45)
        Me.cmdEscape.TabIndex = 14
        Me.cmdEscape.Text = "\\ escape"
        Me.cmdEscape.UseVisualStyleBackColor = True
        '
        'cmdPlusZero
        '
        Me.cmdPlusZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlusZero.Location = New System.Drawing.Point(376, 112)
        Me.cmdPlusZero.Name = "cmdPlusZero"
        Me.cmdPlusZero.Size = New System.Drawing.Size(94, 45)
        Me.cmdPlusZero.TabIndex = 15
        Me.cmdPlusZero.Text = "- to"
        Me.cmdPlusZero.UseVisualStyleBackColor = True
        '
        'cmdZero
        '
        Me.cmdZero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZero.Location = New System.Drawing.Point(190, 112)
        Me.cmdZero.Name = "cmdZero"
        Me.cmdZero.Size = New System.Drawing.Size(94, 45)
        Me.cmdZero.TabIndex = 13
        Me.cmdZero.Text = "* 0+"
        Me.cmdZero.UseVisualStyleBackColor = True
        '
        'cmdPlusOne
        '
        Me.cmdPlusOne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdPlusOne.Location = New System.Drawing.Point(96, 112)
        Me.cmdPlusOne.Name = "cmdPlusOne"
        Me.cmdPlusOne.Size = New System.Drawing.Size(94, 45)
        Me.cmdPlusOne.TabIndex = 12
        Me.cmdPlusOne.Text = "+ 1+"
        Me.cmdPlusOne.UseVisualStyleBackColor = True
        '
        'cmdZeroOrOne
        '
        Me.cmdZeroOrOne.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdZeroOrOne.Location = New System.Drawing.Point(3, 112)
        Me.cmdZeroOrOne.Name = "cmdZeroOrOne"
        Me.cmdZeroOrOne.Size = New System.Drawing.Size(94, 45)
        Me.cmdZeroOrOne.TabIndex = 11
        Me.cmdZeroOrOne.Text = "? 0 or 1"
        Me.cmdZeroOrOne.UseVisualStyleBackColor = True
        '
        'cmdNumbers
        '
        Me.cmdNumbers.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNumbers.Location = New System.Drawing.Point(376, 69)
        Me.cmdNumbers.Name = "cmdNumbers"
        Me.cmdNumbers.Size = New System.Drawing.Size(94, 45)
        Me.cmdNumbers.TabIndex = 10
        Me.cmdNumbers.Text = "{ m,n } "
        Me.cmdNumbers.UseVisualStyleBackColor = True
        '
        'cmdNot1
        '
        Me.cmdNot1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdNot1.Location = New System.Drawing.Point(96, 69)
        Me.cmdNot1.Name = "cmdNot1"
        Me.cmdNot1.Size = New System.Drawing.Size(94, 45)
        Me.cmdNot1.TabIndex = 8
        Me.cmdNot1.Text = "[^ ] not"
        Me.cmdNot1.UseVisualStyleBackColor = True
        '
        'cmdOr2
        '
        Me.cmdOr2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr2.Location = New System.Drawing.Point(284, 69)
        Me.cmdOr2.Name = "cmdOr2"
        Me.cmdOr2.Size = New System.Drawing.Size(94, 45)
        Me.cmdOr2.TabIndex = 9
        Me.cmdOr2.Text = "{ n} "
        Me.cmdOr2.UseVisualStyleBackColor = True
        '
        'cmdOr1
        '
        Me.cmdOr1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdOr1.Location = New System.Drawing.Point(3, 69)
        Me.cmdOr1.Name = "cmdOr1"
        Me.cmdOr1.Size = New System.Drawing.Size(94, 45)
        Me.cmdOr1.TabIndex = 7
        Me.cmdOr1.Text = "[ ] or"
        Me.cmdOr1.UseVisualStyleBackColor = True
        '
        'cmdSpace
        '
        Me.cmdSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSpace.Location = New System.Drawing.Point(376, 24)
        Me.cmdSpace.Name = "cmdSpace"
        Me.cmdSpace.Size = New System.Drawing.Size(94, 45)
        Me.cmdSpace.TabIndex = 6
        Me.cmdSpace.Text = "\\s space"
        Me.cmdSpace.UseVisualStyleBackColor = True
        '
        'cmdDigit
        '
        Me.cmdDigit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdDigit.Location = New System.Drawing.Point(284, 24)
        Me.cmdDigit.Name = "cmdDigit"
        Me.cmdDigit.Size = New System.Drawing.Size(94, 45)
        Me.cmdDigit.TabIndex = 5
        Me.cmdDigit.Text = "\\d digit"
        Me.cmdDigit.UseVisualStyleBackColor = True
        '
        'cmdEnd1
        '
        Me.cmdEnd1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdEnd1.Location = New System.Drawing.Point(190, 24)
        Me.cmdEnd1.Name = "cmdEnd1"
        Me.cmdEnd1.Size = New System.Drawing.Size(94, 45)
        Me.cmdEnd1.TabIndex = 4
        Me.cmdEnd1.Text = "$ end"
        Me.cmdEnd1.UseVisualStyleBackColor = True
        '
        'cmdbegin
        '
        Me.cmdbegin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdbegin.Location = New System.Drawing.Point(96, 24)
        Me.cmdbegin.Name = "cmdbegin"
        Me.cmdbegin.Size = New System.Drawing.Size(94, 45)
        Me.cmdbegin.TabIndex = 3
        Me.cmdbegin.Text = "^ begin"
        Me.cmdbegin.UseVisualStyleBackColor = True
        '
        'cmdAny1
        '
        Me.cmdAny1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAny1.Location = New System.Drawing.Point(3, 24)
        Me.cmdAny1.Name = "cmdAny1"
        Me.cmdAny1.Size = New System.Drawing.Size(94, 45)
        Me.cmdAny1.TabIndex = 2
        Me.cmdAny1.Text = ". any"
        Me.cmdAny1.UseVisualStyleBackColor = True
        '
        'grpComplex
        '
        Me.grpComplex.Controls.Add(Me.cmdComplexRHelp)
        Me.grpComplex.Controls.Add(Me.cmdComplexTanH)
        Me.grpComplex.Controls.Add(Me.cmdComplexTan)
        Me.grpComplex.Controls.Add(Me.cmdComplexPi)
        Me.grpComplex.Controls.Add(Me.cmdComplexDeg)
        Me.grpComplex.Controls.Add(Me.cmdComplexRad)
        Me.grpComplex.Controls.Add(Me.cmdComplexSignif)
        Me.grpComplex.Controls.Add(Me.cmdComplexCosH)
        Me.grpComplex.Controls.Add(Me.cmdComplexSinH)
        Me.grpComplex.Controls.Add(Me.cmdComplexCos)
        Me.grpComplex.Controls.Add(Me.cmdComplexSin)
        Me.grpComplex.Controls.Add(Me.cmdComplexExp)
        Me.grpComplex.Controls.Add(Me.cmdComplexRound)
        Me.grpComplex.Controls.Add(Me.cmdComplexLog)
        Me.grpComplex.Controls.Add(Me.cmdComplexSqrt)
        Me.grpComplex.Controls.Add(Me.cmdConjugate)
        Me.grpComplex.Controls.Add(Me.cmdArg)
        Me.grpComplex.Controls.Add(Me.cmdMod)
        Me.grpComplex.Controls.Add(Me.cmdImaginary)
        Me.grpComplex.Controls.Add(Me.cmdReal)
        Me.grpComplex.Controls.Add(Me.cmdAsComplex)
        Me.grpComplex.Location = New System.Drawing.Point(651, 104)
        Me.grpComplex.Margin = New System.Windows.Forms.Padding(4)
        Me.grpComplex.Name = "grpComplex"
        Me.grpComplex.Padding = New System.Windows.Forms.Padding(4)
        Me.grpComplex.Size = New System.Drawing.Size(432, 339)
        Me.grpComplex.TabIndex = 198
        Me.grpComplex.TabStop = False
        Me.grpComplex.Text = "Complex"
        '
        'cmdComplexRHelp
        '
        Me.cmdComplexRHelp.AutoSize = True
        Me.cmdComplexRHelp.ContextMenuStrip = Me.ContextMenuStripComplex
        Me.cmdComplexRHelp.Location = New System.Drawing.Point(274, 254)
        Me.cmdComplexRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdComplexRHelp.Name = "cmdComplexRHelp"
        Me.cmdComplexRHelp.Size = New System.Drawing.Size(136, 45)
        Me.cmdComplexRHelp.SplitMenuStrip = Me.ContextMenuStripComplex
        Me.cmdComplexRHelp.TabIndex = 209
        Me.cmdComplexRHelp.Text = "R Help"
        Me.cmdComplexRHelp.UseVisualStyleBackColor = True
        '
        'cmdComplexTanH
        '
        Me.cmdComplexTanH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexTanH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexTanH.Location = New System.Drawing.Point(318, 156)
        Me.cmdComplexTanH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexTanH.Name = "cmdComplexTanH"
        Me.cmdComplexTanH.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexTanH.TabIndex = 208
        Me.cmdComplexTanH.Text = "tanh"
        Me.cmdComplexTanH.UseVisualStyleBackColor = True
        '
        'cmdComplexTan
        '
        Me.cmdComplexTan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexTan.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexTan.Location = New System.Drawing.Point(318, 112)
        Me.cmdComplexTan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexTan.Name = "cmdComplexTan"
        Me.cmdComplexTan.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexTan.TabIndex = 207
        Me.cmdComplexTan.Text = "tan"
        Me.cmdComplexTan.UseVisualStyleBackColor = True
        '
        'cmdComplexPi
        '
        Me.cmdComplexPi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexPi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexPi.Location = New System.Drawing.Point(318, 200)
        Me.cmdComplexPi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexPi.Name = "cmdComplexPi"
        Me.cmdComplexPi.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexPi.TabIndex = 206
        Me.cmdComplexPi.Text = "pi"
        Me.cmdComplexPi.UseVisualStyleBackColor = True
        '
        'cmdComplexDeg
        '
        Me.cmdComplexDeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexDeg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexDeg.Location = New System.Drawing.Point(318, 69)
        Me.cmdComplexDeg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexDeg.Name = "cmdComplexDeg"
        Me.cmdComplexDeg.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexDeg.TabIndex = 205
        Me.cmdComplexDeg.Text = "deg"
        Me.cmdComplexDeg.UseVisualStyleBackColor = True
        '
        'cmdComplexRad
        '
        Me.cmdComplexRad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexRad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexRad.Location = New System.Drawing.Point(318, 26)
        Me.cmdComplexRad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexRad.Name = "cmdComplexRad"
        Me.cmdComplexRad.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexRad.TabIndex = 204
        Me.cmdComplexRad.Text = "rad"
        Me.cmdComplexRad.UseVisualStyleBackColor = True
        '
        'cmdComplexSignif
        '
        Me.cmdComplexSignif.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexSignif.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexSignif.Location = New System.Drawing.Point(220, 200)
        Me.cmdComplexSignif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexSignif.Name = "cmdComplexSignif"
        Me.cmdComplexSignif.Size = New System.Drawing.Size(98, 45)
        Me.cmdComplexSignif.TabIndex = 203
        Me.cmdComplexSignif.Text = "signif"
        Me.cmdComplexSignif.UseVisualStyleBackColor = True
        '
        'cmdComplexCosH
        '
        Me.cmdComplexCosH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexCosH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexCosH.Location = New System.Drawing.Point(220, 156)
        Me.cmdComplexCosH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexCosH.Name = "cmdComplexCosH"
        Me.cmdComplexCosH.Size = New System.Drawing.Size(98, 45)
        Me.cmdComplexCosH.TabIndex = 202
        Me.cmdComplexCosH.Text = "cosh"
        Me.cmdComplexCosH.UseVisualStyleBackColor = True
        '
        'cmdComplexSinH
        '
        Me.cmdComplexSinH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexSinH.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexSinH.Location = New System.Drawing.Point(134, 156)
        Me.cmdComplexSinH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexSinH.Name = "cmdComplexSinH"
        Me.cmdComplexSinH.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexSinH.TabIndex = 201
        Me.cmdComplexSinH.Text = "sinh"
        Me.cmdComplexSinH.UseVisualStyleBackColor = True
        '
        'cmdComplexCos
        '
        Me.cmdComplexCos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexCos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexCos.Location = New System.Drawing.Point(220, 112)
        Me.cmdComplexCos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexCos.Name = "cmdComplexCos"
        Me.cmdComplexCos.Size = New System.Drawing.Size(98, 45)
        Me.cmdComplexCos.TabIndex = 200
        Me.cmdComplexCos.Text = "cos"
        Me.cmdComplexCos.UseVisualStyleBackColor = True
        '
        'cmdComplexSin
        '
        Me.cmdComplexSin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexSin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexSin.Location = New System.Drawing.Point(134, 112)
        Me.cmdComplexSin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexSin.Name = "cmdComplexSin"
        Me.cmdComplexSin.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexSin.TabIndex = 199
        Me.cmdComplexSin.Text = "sin"
        Me.cmdComplexSin.UseVisualStyleBackColor = True
        '
        'cmdComplexExp
        '
        Me.cmdComplexExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexExp.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexExp.Location = New System.Drawing.Point(36, 112)
        Me.cmdComplexExp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexExp.Name = "cmdComplexExp"
        Me.cmdComplexExp.Size = New System.Drawing.Size(98, 45)
        Me.cmdComplexExp.TabIndex = 192
        Me.cmdComplexExp.Text = "exp"
        Me.cmdComplexExp.UseVisualStyleBackColor = True
        '
        'cmdComplexRound
        '
        Me.cmdComplexRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexRound.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexRound.Location = New System.Drawing.Point(134, 200)
        Me.cmdComplexRound.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexRound.Name = "cmdComplexRound"
        Me.cmdComplexRound.Size = New System.Drawing.Size(87, 45)
        Me.cmdComplexRound.TabIndex = 191
        Me.cmdComplexRound.Text = "round"
        Me.cmdComplexRound.UseVisualStyleBackColor = True
        '
        'cmdComplexLog
        '
        Me.cmdComplexLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexLog.Location = New System.Drawing.Point(36, 156)
        Me.cmdComplexLog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexLog.Name = "cmdComplexLog"
        Me.cmdComplexLog.Size = New System.Drawing.Size(98, 45)
        Me.cmdComplexLog.TabIndex = 190
        Me.cmdComplexLog.Text = "log"
        Me.cmdComplexLog.UseVisualStyleBackColor = True
        '
        'cmdComplexSqrt
        '
        Me.cmdComplexSqrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdComplexSqrt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdComplexSqrt.Location = New System.Drawing.Point(36, 200)
        Me.cmdComplexSqrt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdComplexSqrt.Name = "cmdComplexSqrt"
        Me.cmdComplexSqrt.Size = New System.Drawing.Size(98, 45)
        Me.cmdComplexSqrt.TabIndex = 189
        Me.cmdComplexSqrt.Text = "sqrt"
        Me.cmdComplexSqrt.UseVisualStyleBackColor = True
        '
        'cmdConjugate
        '
        Me.cmdConjugate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdConjugate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdConjugate.Location = New System.Drawing.Point(220, 69)
        Me.cmdConjugate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdConjugate.Name = "cmdConjugate"
        Me.cmdConjugate.Size = New System.Drawing.Size(98, 45)
        Me.cmdConjugate.TabIndex = 188
        Me.cmdConjugate.Text = "conjugate"
        Me.cmdConjugate.UseVisualStyleBackColor = True
        '
        'cmdArg
        '
        Me.cmdArg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdArg.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdArg.Location = New System.Drawing.Point(134, 69)
        Me.cmdArg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdArg.Name = "cmdArg"
        Me.cmdArg.Size = New System.Drawing.Size(87, 45)
        Me.cmdArg.TabIndex = 187
        Me.cmdArg.Text = "arg"
        Me.cmdArg.UseVisualStyleBackColor = True
        '
        'cmdMod
        '
        Me.cmdMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdMod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdMod.Location = New System.Drawing.Point(36, 69)
        Me.cmdMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdMod.Name = "cmdMod"
        Me.cmdMod.Size = New System.Drawing.Size(98, 45)
        Me.cmdMod.TabIndex = 186
        Me.cmdMod.Text = "mod"
        Me.cmdMod.UseVisualStyleBackColor = True
        '
        'cmdImaginary
        '
        Me.cmdImaginary.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdImaginary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdImaginary.Location = New System.Drawing.Point(220, 26)
        Me.cmdImaginary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdImaginary.Name = "cmdImaginary"
        Me.cmdImaginary.Size = New System.Drawing.Size(98, 45)
        Me.cmdImaginary.TabIndex = 185
        Me.cmdImaginary.Text = "imaginary"
        Me.cmdImaginary.UseVisualStyleBackColor = True
        '
        'cmdReal
        '
        Me.cmdReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdReal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdReal.Location = New System.Drawing.Point(134, 26)
        Me.cmdReal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdReal.Name = "cmdReal"
        Me.cmdReal.Size = New System.Drawing.Size(87, 45)
        Me.cmdReal.TabIndex = 177
        Me.cmdReal.Text = "real"
        Me.cmdReal.UseVisualStyleBackColor = True
        '
        'cmdAsComplex
        '
        Me.cmdAsComplex.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdAsComplex.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdAsComplex.Location = New System.Drawing.Point(36, 26)
        Me.cmdAsComplex.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdAsComplex.Name = "cmdAsComplex"
        Me.cmdAsComplex.Size = New System.Drawing.Size(98, 45)
        Me.cmdAsComplex.TabIndex = 176
        Me.cmdAsComplex.Text = "complex"
        Me.cmdAsComplex.UseVisualStyleBackColor = True
        '
        'ContextMenuStripTxtString
        '
        Me.ContextMenuStripTxtString.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripTxtString.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TxTStringrToolStripMenuItem, Me.TxTBaseToolStripMenuItem})
        Me.ContextMenuStripTxtString.Name = "ContextMenuStrip1"
        Me.ContextMenuStripTxtString.Size = New System.Drawing.Size(137, 68)
        '
        'TxTStringrToolStripMenuItem
        '
        Me.TxTStringrToolStripMenuItem.Name = "TxTStringrToolStripMenuItem"
        Me.TxTStringrToolStripMenuItem.Size = New System.Drawing.Size(136, 32)
        Me.TxTStringrToolStripMenuItem.Text = "Stringr"
        '
        'TxTBaseToolStripMenuItem
        '
        Me.TxTBaseToolStripMenuItem.Name = "TxTBaseToolStripMenuItem"
        Me.TxTBaseToolStripMenuItem.Size = New System.Drawing.Size(136, 32)
        Me.TxTBaseToolStripMenuItem.Text = "base"
        '
        'ContextMenuStripWakefield
        '
        Me.ContextMenuStripWakefield.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripWakefield.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WakefieldToolStripMenuItem})
        Me.ContextMenuStripWakefield.Name = "ContextMenuStrip1"
        Me.ContextMenuStripWakefield.Size = New System.Drawing.Size(159, 36)
        '
        'WakefieldToolStripMenuItem
        '
        Me.WakefieldToolStripMenuItem.Name = "WakefieldToolStripMenuItem"
        Me.WakefieldToolStripMenuItem.Size = New System.Drawing.Size(158, 32)
        Me.WakefieldToolStripMenuItem.Text = "wakefield"
        '
        'ContextMenuStripList
        '
        Me.ContextMenuStripList.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStripList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListBaseToolStripMenuItem, Me.ListStatsToolStripMenuItem, Me.ListStatipToolStripMenuItem})
        Me.ContextMenuStripList.Name = "ContextMenuStrip1"
        Me.ContextMenuStripList.Size = New System.Drawing.Size(129, 100)
        '
        'ListBaseToolStripMenuItem
        '
        Me.ListBaseToolStripMenuItem.Name = "ListBaseToolStripMenuItem"
        Me.ListBaseToolStripMenuItem.Size = New System.Drawing.Size(128, 32)
        Me.ListBaseToolStripMenuItem.Text = "base"
        '
        'ListStatsToolStripMenuItem
        '
        Me.ListStatsToolStripMenuItem.Name = "ListStatsToolStripMenuItem"
        Me.ListStatsToolStripMenuItem.Size = New System.Drawing.Size(128, 32)
        Me.ListStatsToolStripMenuItem.Text = "stats"
        '
        'ListStatipToolStripMenuItem
        '
        Me.ListStatipToolStripMenuItem.Name = "ListStatipToolStripMenuItem"
        Me.ListStatipToolStripMenuItem.Size = New System.Drawing.Size(128, 32)
        Me.ListStatipToolStripMenuItem.Text = "statip"
        '
        'grpList
        '
        Me.grpList.Controls.Add(Me.GroupBox1)
        Me.grpList.Controls.Add(Me.grpMathBloc)
        Me.grpList.Controls.Add(Me.cmdListNth)
        Me.grpList.Controls.Add(Me.cmdListLast)
        Me.grpList.Controls.Add(Me.cmdListFirst)
        Me.grpList.Controls.Add(Me.cmdListAnyDup)
        Me.grpList.Controls.Add(Me.cmdListDistinct)
        Me.grpList.Controls.Add(Me.cmdListIQR)
        Me.grpList.Controls.Add(Me.cmdListMad)
        Me.grpList.Controls.Add(Me.cmdListSd)
        Me.grpList.Controls.Add(Me.cmdListVar)
        Me.grpList.Controls.Add(Me.cmdListSsq)
        Me.grpList.Controls.Add(Me.cmdListMode1)
        Me.grpList.Controls.Add(Me.cmdListMax)
        Me.grpList.Controls.Add(Me.cmdListFivenum)
        Me.grpList.Controls.Add(Me.cmdListMode)
        Me.grpList.Controls.Add(Me.cmdListQuantile)
        Me.grpList.Controls.Add(Me.cmdListDigitsum)
        Me.grpList.Controls.Add(Me.cmdListMin)
        Me.grpList.Controls.Add(Me.cmdListProd)
        Me.grpList.Controls.Add(Me.cmdListLength)
        Me.grpList.Controls.Add(Me.cmdListMedian)
        Me.grpList.Controls.Add(Me.cmdListMean)
        Me.grpList.Controls.Add(Me.cmdListRange)
        Me.grpList.Controls.Add(Me.cmdListSum)
        Me.grpList.Controls.Add(Me.cmdListSumd)
        Me.grpList.Controls.Add(Me.cmdListMissing)
        Me.grpList.Location = New System.Drawing.Point(657, 62)
        Me.grpList.Margin = New System.Windows.Forms.Padding(4)
        Me.grpList.Name = "grpList"
        Me.grpList.Padding = New System.Windows.Forms.Padding(4)
        Me.grpList.Size = New System.Drawing.Size(474, 550)
        Me.grpList.TabIndex = 214
        Me.grpList.TabStop = False
        Me.grpList.Text = "Summary"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdListDuplicated)
        Me.GroupBox1.Controls.Add(Me.cmdListOperator)
        Me.GroupBox1.Controls.Add(Me.cmdListDiv)
        Me.GroupBox1.Controls.Add(Me.cmdListMod)
        Me.GroupBox1.Controls.Add(Me.cmdListIfelse)
        Me.GroupBox1.Controls.Add(Me.cmdListOmit)
        Me.GroupBox1.Controls.Add(Me.cmdListRev)
        Me.GroupBox1.Controls.Add(Me.cmdListMovsum)
        Me.GroupBox1.Controls.Add(Me.cmdListCumsum)
        Me.GroupBox1.Controls.Add(Me.cmdListScale)
        Me.GroupBox1.Controls.Add(Me.cmdListDiff)
        Me.GroupBox1.Controls.Add(Me.cmdListLead)
        Me.GroupBox1.Controls.Add(Me.cmdListLag)
        Me.GroupBox1.Controls.Add(Me.cmdListRank)
        Me.GroupBox1.Controls.Add(Me.cmdListSort)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 372)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(466, 164)
        Me.GroupBox1.TabIndex = 200
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transform"
        '
        'cmdListDuplicated
        '
        Me.cmdListDuplicated.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListDuplicated.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListDuplicated.Location = New System.Drawing.Point(362, 108)
        Me.cmdListDuplicated.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListDuplicated.Name = "cmdListDuplicated"
        Me.cmdListDuplicated.Size = New System.Drawing.Size(98, 45)
        Me.cmdListDuplicated.TabIndex = 186
        Me.cmdListDuplicated.Text = "duplicated"
        Me.cmdListDuplicated.UseVisualStyleBackColor = True
        '
        'cmdListOperator
        '
        Me.cmdListOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListOperator.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListOperator.Location = New System.Drawing.Point(279, 108)
        Me.cmdListOperator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListOperator.Name = "cmdListOperator"
        Me.cmdListOperator.Size = New System.Drawing.Size(84, 45)
        Me.cmdListOperator.TabIndex = 185
        Me.cmdListOperator.Text = ">"
        Me.cmdListOperator.UseVisualStyleBackColor = True
        '
        'cmdListDiv
        '
        Me.cmdListDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListDiv.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListDiv.Location = New System.Drawing.Point(190, 108)
        Me.cmdListDiv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListDiv.Name = "cmdListDiv"
        Me.cmdListDiv.Size = New System.Drawing.Size(90, 45)
        Me.cmdListDiv.TabIndex = 184
        Me.cmdListDiv.Text = "div (%/%)"
        Me.cmdListDiv.UseVisualStyleBackColor = True
        '
        'cmdListMod
        '
        Me.cmdListMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMod.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMod.Location = New System.Drawing.Point(86, 108)
        Me.cmdListMod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMod.Name = "cmdListMod"
        Me.cmdListMod.Size = New System.Drawing.Size(106, 45)
        Me.cmdListMod.TabIndex = 183
        Me.cmdListMod.Text = "mod (%%)"
        Me.cmdListMod.UseVisualStyleBackColor = True
        '
        'cmdListIfelse
        '
        Me.cmdListIfelse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListIfelse.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListIfelse.Location = New System.Drawing.Point(2, 108)
        Me.cmdListIfelse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListIfelse.Name = "cmdListIfelse"
        Me.cmdListIfelse.Size = New System.Drawing.Size(86, 45)
        Me.cmdListIfelse.TabIndex = 182
        Me.cmdListIfelse.Text = "ifelse"
        Me.cmdListIfelse.UseVisualStyleBackColor = True
        '
        'cmdListOmit
        '
        Me.cmdListOmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListOmit.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListOmit.Location = New System.Drawing.Point(362, 64)
        Me.cmdListOmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListOmit.Name = "cmdListOmit"
        Me.cmdListOmit.Size = New System.Drawing.Size(98, 45)
        Me.cmdListOmit.TabIndex = 181
        Me.cmdListOmit.Text = "omit.na"
        Me.cmdListOmit.UseVisualStyleBackColor = True
        '
        'cmdListRev
        '
        Me.cmdListRev.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListRev.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListRev.Location = New System.Drawing.Point(279, 64)
        Me.cmdListRev.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListRev.Name = "cmdListRev"
        Me.cmdListRev.Size = New System.Drawing.Size(84, 45)
        Me.cmdListRev.TabIndex = 180
        Me.cmdListRev.Text = "rev"
        Me.cmdListRev.UseVisualStyleBackColor = True
        '
        'cmdListMovsum
        '
        Me.cmdListMovsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMovsum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMovsum.Location = New System.Drawing.Point(190, 64)
        Me.cmdListMovsum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMovsum.Name = "cmdListMovsum"
        Me.cmdListMovsum.Size = New System.Drawing.Size(90, 45)
        Me.cmdListMovsum.TabIndex = 179
        Me.cmdListMovsum.Text = "movsum"
        Me.cmdListMovsum.UseVisualStyleBackColor = True
        '
        'cmdListCumsum
        '
        Me.cmdListCumsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListCumsum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListCumsum.Location = New System.Drawing.Point(86, 64)
        Me.cmdListCumsum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListCumsum.Name = "cmdListCumsum"
        Me.cmdListCumsum.Size = New System.Drawing.Size(106, 45)
        Me.cmdListCumsum.TabIndex = 178
        Me.cmdListCumsum.Text = "cumsum"
        Me.cmdListCumsum.UseVisualStyleBackColor = True
        '
        'cmdListScale
        '
        Me.cmdListScale.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListScale.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListScale.Location = New System.Drawing.Point(2, 64)
        Me.cmdListScale.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListScale.Name = "cmdListScale"
        Me.cmdListScale.Size = New System.Drawing.Size(86, 45)
        Me.cmdListScale.TabIndex = 177
        Me.cmdListScale.Text = " scale"
        Me.cmdListScale.UseVisualStyleBackColor = True
        '
        'cmdListDiff
        '
        Me.cmdListDiff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListDiff.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListDiff.Location = New System.Drawing.Point(362, 21)
        Me.cmdListDiff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListDiff.Name = "cmdListDiff"
        Me.cmdListDiff.Size = New System.Drawing.Size(98, 45)
        Me.cmdListDiff.TabIndex = 176
        Me.cmdListDiff.Text = "diff"
        Me.cmdListDiff.UseVisualStyleBackColor = True
        '
        'cmdListLead
        '
        Me.cmdListLead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListLead.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListLead.Location = New System.Drawing.Point(279, 21)
        Me.cmdListLead.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListLead.Name = "cmdListLead"
        Me.cmdListLead.Size = New System.Drawing.Size(84, 45)
        Me.cmdListLead.TabIndex = 175
        Me.cmdListLead.Text = "lead"
        Me.cmdListLead.UseVisualStyleBackColor = True
        '
        'cmdListLag
        '
        Me.cmdListLag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListLag.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListLag.Location = New System.Drawing.Point(190, 21)
        Me.cmdListLag.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListLag.Name = "cmdListLag"
        Me.cmdListLag.Size = New System.Drawing.Size(90, 45)
        Me.cmdListLag.TabIndex = 174
        Me.cmdListLag.Text = "lag"
        Me.cmdListLag.UseVisualStyleBackColor = True
        '
        'cmdListRank
        '
        Me.cmdListRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListRank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListRank.Location = New System.Drawing.Point(86, 21)
        Me.cmdListRank.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListRank.Name = "cmdListRank"
        Me.cmdListRank.Size = New System.Drawing.Size(106, 45)
        Me.cmdListRank.TabIndex = 173
        Me.cmdListRank.Text = "rank"
        Me.cmdListRank.UseVisualStyleBackColor = True
        '
        'cmdListSort
        '
        Me.cmdListSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSort.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSort.Location = New System.Drawing.Point(2, 21)
        Me.cmdListSort.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSort.Name = "cmdListSort"
        Me.cmdListSort.Size = New System.Drawing.Size(86, 45)
        Me.cmdListSort.TabIndex = 172
        Me.cmdListSort.Text = "sort"
        Me.cmdListSort.UseVisualStyleBackColor = True
        '
        'grpMathBloc
        '
        Me.grpMathBloc.Controls.Add(Me.cmdListSQRT)
        Me.grpMathBloc.Controls.Add(Me.cmdListPercent2)
        Me.grpMathBloc.Controls.Add(Me.cmdListPercent)
        Me.grpMathBloc.Controls.Add(Me.cmdListProportion)
        Me.grpMathBloc.Controls.Add(Me.cmdListRound)
        Me.grpMathBloc.Controls.Add(Me.cmdListSquare)
        Me.grpMathBloc.Controls.Add(Me.cmdListDivide)
        Me.grpMathBloc.Controls.Add(Me.cmdListMultiply)
        Me.grpMathBloc.Controls.Add(Me.cmdListSubtract)
        Me.grpMathBloc.Controls.Add(Me.cmdListAdd)
        Me.grpMathBloc.Location = New System.Drawing.Point(4, 244)
        Me.grpMathBloc.Margin = New System.Windows.Forms.Padding(4)
        Me.grpMathBloc.Name = "grpMathBloc"
        Me.grpMathBloc.Padding = New System.Windows.Forms.Padding(4)
        Me.grpMathBloc.Size = New System.Drawing.Size(466, 126)
        Me.grpMathBloc.TabIndex = 199
        Me.grpMathBloc.TabStop = False
        Me.grpMathBloc.Text = "Maths"
        '
        'cmdListSQRT
        '
        Me.cmdListSQRT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSQRT.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSQRT.Location = New System.Drawing.Point(368, 64)
        Me.cmdListSQRT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSQRT.Name = "cmdListSQRT"
        Me.cmdListSQRT.Size = New System.Drawing.Size(88, 45)
        Me.cmdListSQRT.TabIndex = 181
        Me.cmdListSQRT.Text = "sqrt"
        Me.cmdListSQRT.UseVisualStyleBackColor = True
        '
        'cmdListPercent2
        '
        Me.cmdListPercent2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListPercent2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListPercent2.Location = New System.Drawing.Point(279, 64)
        Me.cmdListPercent2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListPercent2.Name = "cmdListPercent2"
        Me.cmdListPercent2.Size = New System.Drawing.Size(90, 45)
        Me.cmdListPercent2.TabIndex = 180
        Me.cmdListPercent2.Text = "percent2"
        Me.cmdListPercent2.UseVisualStyleBackColor = True
        '
        'cmdListPercent
        '
        Me.cmdListPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListPercent.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListPercent.Location = New System.Drawing.Point(190, 64)
        Me.cmdListPercent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListPercent.Name = "cmdListPercent"
        Me.cmdListPercent.Size = New System.Drawing.Size(90, 45)
        Me.cmdListPercent.TabIndex = 179
        Me.cmdListPercent.Text = "percent"
        Me.cmdListPercent.UseVisualStyleBackColor = True
        '
        'cmdListProportion
        '
        Me.cmdListProportion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListProportion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListProportion.Location = New System.Drawing.Point(86, 64)
        Me.cmdListProportion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListProportion.Name = "cmdListProportion"
        Me.cmdListProportion.Size = New System.Drawing.Size(106, 45)
        Me.cmdListProportion.TabIndex = 178
        Me.cmdListProportion.Text = "proportion"
        Me.cmdListProportion.UseVisualStyleBackColor = True
        '
        'cmdListRound
        '
        Me.cmdListRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListRound.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListRound.Location = New System.Drawing.Point(2, 64)
        Me.cmdListRound.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListRound.Name = "cmdListRound"
        Me.cmdListRound.Size = New System.Drawing.Size(86, 45)
        Me.cmdListRound.TabIndex = 177
        Me.cmdListRound.Text = "round"
        Me.cmdListRound.UseVisualStyleBackColor = True
        '
        'cmdListSquare
        '
        Me.cmdListSquare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSquare.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSquare.Location = New System.Drawing.Point(368, 21)
        Me.cmdListSquare.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSquare.Name = "cmdListSquare"
        Me.cmdListSquare.Size = New System.Drawing.Size(88, 45)
        Me.cmdListSquare.TabIndex = 176
        Me.cmdListSquare.Text = "power (^)"
        Me.cmdListSquare.UseVisualStyleBackColor = True
        '
        'cmdListDivide
        '
        Me.cmdListDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListDivide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListDivide.Location = New System.Drawing.Point(279, 21)
        Me.cmdListDivide.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListDivide.Name = "cmdListDivide"
        Me.cmdListDivide.Size = New System.Drawing.Size(90, 45)
        Me.cmdListDivide.TabIndex = 175
        Me.cmdListDivide.Text = "divide (/)"
        Me.cmdListDivide.UseVisualStyleBackColor = True
        '
        'cmdListMultiply
        '
        Me.cmdListMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMultiply.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMultiply.Location = New System.Drawing.Point(190, 21)
        Me.cmdListMultiply.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMultiply.Name = "cmdListMultiply"
        Me.cmdListMultiply.Size = New System.Drawing.Size(90, 45)
        Me.cmdListMultiply.TabIndex = 174
        Me.cmdListMultiply.Text = "times (*)"
        Me.cmdListMultiply.UseVisualStyleBackColor = True
        '
        'cmdListSubtract
        '
        Me.cmdListSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSubtract.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSubtract.Location = New System.Drawing.Point(86, 21)
        Me.cmdListSubtract.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSubtract.Name = "cmdListSubtract"
        Me.cmdListSubtract.Size = New System.Drawing.Size(106, 45)
        Me.cmdListSubtract.TabIndex = 173
        Me.cmdListSubtract.Text = " subtract (-)"
        Me.cmdListSubtract.UseVisualStyleBackColor = True
        '
        'cmdListAdd
        '
        Me.cmdListAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListAdd.Location = New System.Drawing.Point(2, 21)
        Me.cmdListAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListAdd.Name = "cmdListAdd"
        Me.cmdListAdd.Size = New System.Drawing.Size(86, 45)
        Me.cmdListAdd.TabIndex = 172
        Me.cmdListAdd.Text = "sum (+)"
        Me.cmdListAdd.UseVisualStyleBackColor = True
        '
        'cmdListNth
        '
        Me.cmdListNth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListNth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListNth.Location = New System.Drawing.Point(370, 152)
        Me.cmdListNth.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListNth.Name = "cmdListNth"
        Me.cmdListNth.Size = New System.Drawing.Size(93, 45)
        Me.cmdListNth.TabIndex = 176
        Me.cmdListNth.Text = "nth"
        Me.cmdListNth.UseVisualStyleBackColor = True
        '
        'cmdListLast
        '
        Me.cmdListLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListLast.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListLast.Location = New System.Drawing.Point(279, 152)
        Me.cmdListLast.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListLast.Name = "cmdListLast"
        Me.cmdListLast.Size = New System.Drawing.Size(93, 45)
        Me.cmdListLast.TabIndex = 175
        Me.cmdListLast.Text = "last"
        Me.cmdListLast.UseVisualStyleBackColor = True
        '
        'cmdListFirst
        '
        Me.cmdListFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListFirst.Location = New System.Drawing.Point(188, 152)
        Me.cmdListFirst.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListFirst.Name = "cmdListFirst"
        Me.cmdListFirst.Size = New System.Drawing.Size(93, 45)
        Me.cmdListFirst.TabIndex = 174
        Me.cmdListFirst.Text = "first"
        Me.cmdListFirst.UseVisualStyleBackColor = True
        '
        'cmdListAnyDup
        '
        Me.cmdListAnyDup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListAnyDup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListAnyDup.Location = New System.Drawing.Point(96, 152)
        Me.cmdListAnyDup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListAnyDup.Name = "cmdListAnyDup"
        Me.cmdListAnyDup.Size = New System.Drawing.Size(93, 45)
        Me.cmdListAnyDup.TabIndex = 173
        Me.cmdListAnyDup.Text = "anydup"
        Me.cmdListAnyDup.UseVisualStyleBackColor = True
        '
        'cmdListDistinct
        '
        Me.cmdListDistinct.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListDistinct.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListDistinct.Location = New System.Drawing.Point(4, 152)
        Me.cmdListDistinct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListDistinct.Name = "cmdListDistinct"
        Me.cmdListDistinct.Size = New System.Drawing.Size(93, 45)
        Me.cmdListDistinct.TabIndex = 172
        Me.cmdListDistinct.Text = "distinct"
        Me.cmdListDistinct.UseVisualStyleBackColor = True
        '
        'cmdListIQR
        '
        Me.cmdListIQR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListIQR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListIQR.Location = New System.Drawing.Point(370, 108)
        Me.cmdListIQR.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListIQR.Name = "cmdListIQR"
        Me.cmdListIQR.Size = New System.Drawing.Size(93, 45)
        Me.cmdListIQR.TabIndex = 171
        Me.cmdListIQR.Text = "IQR"
        Me.cmdListIQR.UseVisualStyleBackColor = True
        '
        'cmdListMad
        '
        Me.cmdListMad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMad.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMad.Location = New System.Drawing.Point(279, 108)
        Me.cmdListMad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMad.Name = "cmdListMad"
        Me.cmdListMad.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMad.TabIndex = 170
        Me.cmdListMad.Text = "mad"
        Me.cmdListMad.UseVisualStyleBackColor = True
        '
        'cmdListSd
        '
        Me.cmdListSd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSd.Location = New System.Drawing.Point(188, 108)
        Me.cmdListSd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSd.Name = "cmdListSd"
        Me.cmdListSd.Size = New System.Drawing.Size(93, 45)
        Me.cmdListSd.TabIndex = 169
        Me.cmdListSd.Text = "sd"
        Me.cmdListSd.UseVisualStyleBackColor = True
        '
        'cmdListVar
        '
        Me.cmdListVar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListVar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListVar.Location = New System.Drawing.Point(96, 108)
        Me.cmdListVar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListVar.Name = "cmdListVar"
        Me.cmdListVar.Size = New System.Drawing.Size(93, 45)
        Me.cmdListVar.TabIndex = 168
        Me.cmdListVar.Text = "var"
        Me.cmdListVar.UseVisualStyleBackColor = True
        '
        'cmdListSsq
        '
        Me.cmdListSsq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSsq.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSsq.Location = New System.Drawing.Point(4, 108)
        Me.cmdListSsq.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSsq.Name = "cmdListSsq"
        Me.cmdListSsq.Size = New System.Drawing.Size(93, 45)
        Me.cmdListSsq.TabIndex = 167
        Me.cmdListSsq.Text = "ssq"
        Me.cmdListSsq.UseVisualStyleBackColor = True
        '
        'cmdListMode1
        '
        Me.cmdListMode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMode1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMode1.Location = New System.Drawing.Point(370, 64)
        Me.cmdListMode1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMode1.Name = "cmdListMode1"
        Me.cmdListMode1.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMode1.TabIndex = 166
        Me.cmdListMode1.Text = "mode1"
        Me.cmdListMode1.UseVisualStyleBackColor = True
        '
        'cmdListMax
        '
        Me.cmdListMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMax.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMax.Location = New System.Drawing.Point(370, 21)
        Me.cmdListMax.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMax.Name = "cmdListMax"
        Me.cmdListMax.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMax.TabIndex = 165
        Me.cmdListMax.Text = "max"
        Me.cmdListMax.UseVisualStyleBackColor = True
        '
        'cmdListFivenum
        '
        Me.cmdListFivenum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListFivenum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListFivenum.Location = New System.Drawing.Point(279, 195)
        Me.cmdListFivenum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListFivenum.Name = "cmdListFivenum"
        Me.cmdListFivenum.Size = New System.Drawing.Size(93, 45)
        Me.cmdListFivenum.TabIndex = 163
        Me.cmdListFivenum.Tag = ""
        Me.cmdListFivenum.Text = "fivenum"
        Me.cmdListFivenum.UseVisualStyleBackColor = True
        '
        'cmdListMode
        '
        Me.cmdListMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMode.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMode.Location = New System.Drawing.Point(279, 64)
        Me.cmdListMode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMode.Name = "cmdListMode"
        Me.cmdListMode.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMode.TabIndex = 162
        Me.cmdListMode.Text = "mode"
        Me.cmdListMode.UseVisualStyleBackColor = True
        '
        'cmdListQuantile
        '
        Me.cmdListQuantile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListQuantile.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListQuantile.Location = New System.Drawing.Point(4, 195)
        Me.cmdListQuantile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListQuantile.Name = "cmdListQuantile"
        Me.cmdListQuantile.Size = New System.Drawing.Size(93, 45)
        Me.cmdListQuantile.TabIndex = 154
        Me.cmdListQuantile.Text = "quantile"
        Me.cmdListQuantile.UseVisualStyleBackColor = True
        '
        'cmdListDigitsum
        '
        Me.cmdListDigitsum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListDigitsum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListDigitsum.Location = New System.Drawing.Point(96, 195)
        Me.cmdListDigitsum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListDigitsum.Name = "cmdListDigitsum"
        Me.cmdListDigitsum.Size = New System.Drawing.Size(93, 45)
        Me.cmdListDigitsum.TabIndex = 161
        Me.cmdListDigitsum.Text = "digitsum"
        Me.cmdListDigitsum.UseVisualStyleBackColor = True
        '
        'cmdListMin
        '
        Me.cmdListMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMin.Location = New System.Drawing.Point(279, 21)
        Me.cmdListMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMin.Name = "cmdListMin"
        Me.cmdListMin.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMin.TabIndex = 156
        Me.cmdListMin.Text = "min"
        Me.cmdListMin.UseVisualStyleBackColor = True
        '
        'cmdListProd
        '
        Me.cmdListProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListProd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListProd.Location = New System.Drawing.Point(188, 21)
        Me.cmdListProd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListProd.Name = "cmdListProd"
        Me.cmdListProd.Size = New System.Drawing.Size(93, 45)
        Me.cmdListProd.TabIndex = 155
        Me.cmdListProd.Text = "prod"
        Me.cmdListProd.UseVisualStyleBackColor = True
        '
        'cmdListLength
        '
        Me.cmdListLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListLength.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListLength.Location = New System.Drawing.Point(4, 21)
        Me.cmdListLength.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListLength.Name = "cmdListLength"
        Me.cmdListLength.Size = New System.Drawing.Size(93, 45)
        Me.cmdListLength.TabIndex = 148
        Me.cmdListLength.Text = "length"
        Me.cmdListLength.UseVisualStyleBackColor = True
        '
        'cmdListMedian
        '
        Me.cmdListMedian.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMedian.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMedian.Location = New System.Drawing.Point(188, 64)
        Me.cmdListMedian.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMedian.Name = "cmdListMedian"
        Me.cmdListMedian.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMedian.TabIndex = 160
        Me.cmdListMedian.Text = "median"
        Me.cmdListMedian.UseVisualStyleBackColor = True
        '
        'cmdListMean
        '
        Me.cmdListMean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMean.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMean.Location = New System.Drawing.Point(96, 64)
        Me.cmdListMean.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMean.Name = "cmdListMean"
        Me.cmdListMean.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMean.TabIndex = 158
        Me.cmdListMean.Text = "mean"
        Me.cmdListMean.UseVisualStyleBackColor = True
        '
        'cmdListRange
        '
        Me.cmdListRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListRange.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListRange.Location = New System.Drawing.Point(4, 64)
        Me.cmdListRange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListRange.Name = "cmdListRange"
        Me.cmdListRange.Size = New System.Drawing.Size(93, 45)
        Me.cmdListRange.TabIndex = 157
        Me.cmdListRange.Text = "range"
        Me.cmdListRange.UseVisualStyleBackColor = True
        '
        'cmdListSum
        '
        Me.cmdListSum.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSum.Location = New System.Drawing.Point(96, 21)
        Me.cmdListSum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSum.Name = "cmdListSum"
        Me.cmdListSum.Size = New System.Drawing.Size(93, 45)
        Me.cmdListSum.TabIndex = 153
        Me.cmdListSum.Text = "sum"
        Me.cmdListSum.UseVisualStyleBackColor = True
        '
        'cmdListSumd
        '
        Me.cmdListSumd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListSumd.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListSumd.Location = New System.Drawing.Point(188, 195)
        Me.cmdListSumd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListSumd.Name = "cmdListSumd"
        Me.cmdListSumd.Size = New System.Drawing.Size(93, 45)
        Me.cmdListSumd.TabIndex = 149
        Me.cmdListSumd.Text = "sumd"
        Me.cmdListSumd.UseVisualStyleBackColor = True
        '
        'cmdListMissing
        '
        Me.cmdListMissing.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cmdListMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdListMissing.Location = New System.Drawing.Point(370, 195)
        Me.cmdListMissing.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdListMissing.Name = "cmdListMissing"
        Me.cmdListMissing.Size = New System.Drawing.Size(93, 45)
        Me.cmdListMissing.TabIndex = 164
        Me.cmdListMissing.Text = "missing"
        Me.cmdListMissing.UseVisualStyleBackColor = True
        '
        'cmdRhelpList
        '
        Me.cmdRhelpList.AutoSize = True
        Me.cmdRhelpList.ContextMenuStrip = Me.ContextMenuStripList
        Me.cmdRhelpList.Location = New System.Drawing.Point(1011, 39)
        Me.cmdRhelpList.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRhelpList.Name = "cmdRhelpList"
        Me.cmdRhelpList.Size = New System.Drawing.Size(102, 34)
        Me.cmdRhelpList.SplitMenuStrip = Me.ContextMenuStripList
        Me.cmdRhelpList.TabIndex = 212
        Me.cmdRhelpList.Text = "R Help"
        Me.cmdRhelpList.UseVisualStyleBackColor = True
        '
        'cmdWakefieldHelp
        '
        Me.cmdWakefieldHelp.AutoSize = True
        Me.cmdWakefieldHelp.ContextMenuStrip = Me.ContextMenuStripWakefield
        Me.cmdWakefieldHelp.Location = New System.Drawing.Point(1161, 62)
        Me.cmdWakefieldHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdWakefieldHelp.Name = "cmdWakefieldHelp"
        Me.cmdWakefieldHelp.Size = New System.Drawing.Size(136, 34)
        Me.cmdWakefieldHelp.SplitMenuStrip = Me.ContextMenuStripWakefield
        Me.cmdWakefieldHelp.TabIndex = 211
        Me.cmdWakefieldHelp.Text = "R Help"
        Me.cmdWakefieldHelp.UseVisualStyleBackColor = True
        '
        'cmdStringRHelp
        '
        Me.cmdStringRHelp.AutoSize = True
        Me.cmdStringRHelp.ContextMenuStrip = Me.ContextMenuStripTxtString
        Me.cmdStringRHelp.Location = New System.Drawing.Point(970, 62)
        Me.cmdStringRHelp.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdStringRHelp.Name = "cmdStringRHelp"
        Me.cmdStringRHelp.Size = New System.Drawing.Size(136, 34)
        Me.cmdStringRHelp.SplitMenuStrip = Me.ContextMenuStripTxtString
        Me.cmdStringRHelp.TabIndex = 210
        Me.cmdStringRHelp.Text = "R Help"
        Me.cmdStringRHelp.UseVisualStyleBackColor = True
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveResultInto.Location = New System.Drawing.Point(16, 455)
        Me.ucrSaveResultInto.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        Me.ucrSaveResultInto.Size = New System.Drawing.Size(490, 33)
        Me.ucrSaveResultInto.TabIndex = 196
        '
        'ucrTryCalculator
        '
        Me.ucrTryCalculator.AutoSize = True
        Me.ucrTryCalculator.Location = New System.Drawing.Point(2, 384)
        Me.ucrTryCalculator.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrTryCalculator.Name = "ucrTryCalculator"
        Me.ucrTryCalculator.RunCommandAsMultipleLines = False
        Me.ucrTryCalculator.Size = New System.Drawing.Size(594, 55)
        Me.ucrTryCalculator.TabIndex = 194
        '
        'ucrInputCalOptions
        '
        Me.ucrInputCalOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputCalOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputCalOptions.GetSetSelectedIndex = -1
        Me.ucrInputCalOptions.IsReadOnly = False
        Me.ucrInputCalOptions.Location = New System.Drawing.Point(339, 62)
        Me.ucrInputCalOptions.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ucrInputCalOptions.Name = "ucrInputCalOptions"
        Me.ucrInputCalOptions.Size = New System.Drawing.Size(206, 33)
        Me.ucrInputCalOptions.TabIndex = 180
        '
        'ucrSelectorForCalculations
        '
        Me.ucrSelectorForCalculations.AutoSize = True
        Me.ucrSelectorForCalculations.bDropUnusedFilterLevels = False
        Me.ucrSelectorForCalculations.bShowHiddenColumns = False
        Me.ucrSelectorForCalculations.bUseCurrentFilter = True
        Me.ucrSelectorForCalculations.Location = New System.Drawing.Point(0, 96)
        Me.ucrSelectorForCalculations.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorForCalculations.Name = "ucrSelectorForCalculations"
        Me.ucrSelectorForCalculations.Size = New System.Drawing.Size(320, 274)
        Me.ucrSelectorForCalculations.TabIndex = 173
        '
        'ucrReceiverForCalculation
        '
        Me.ucrReceiverForCalculation.AutoSize = True
        Me.ucrReceiverForCalculation.frmParent = Nothing
        Me.ucrReceiverForCalculation.Location = New System.Drawing.Point(105, 9)
        Me.ucrReceiverForCalculation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ucrReceiverForCalculation.Name = "ucrReceiverForCalculation"
        Me.ucrReceiverForCalculation.Selector = Nothing
        Me.ucrReceiverForCalculation.Size = New System.Drawing.Size(586, 44)
        Me.ucrReceiverForCalculation.strNcFilePath = ""
        Me.ucrReceiverForCalculation.TabIndex = 120
        Me.ucrReceiverForCalculation.ucrSelector = Nothing
        '
        'ucrCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.Controls.Add(Me.cmdRhelpList)
        Me.Controls.Add(Me.grpList)
        Me.Controls.Add(Me.grpProbabilty)
        Me.Controls.Add(Me.grpInteger)
        Me.Controls.Add(Me.cmdWakefieldHelp)
        Me.Controls.Add(Me.cmdStringRHelp)
        Me.Controls.Add(Me.ucrSaveResultInto)
        Me.Controls.Add(Me.ucrTryCalculator)
        Me.Controls.Add(Me.grpSymbols)
        Me.Controls.Add(Me.chkShowParameters)
        Me.Controls.Add(Me.ucrInputCalOptions)
        Me.Controls.Add(Me.grpBasic)
        Me.Controls.Add(Me.ucrSelectorForCalculations)
        Me.Controls.Add(Me.ucrReceiverForCalculation)
        Me.Controls.Add(Me.lblExpression)
        Me.Controls.Add(Me.grpTestString)
        Me.Controls.Add(Me.grpModifier)
        Me.Controls.Add(Me.grpComplex)
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpWakefield)
        Me.Controls.Add(Me.grpTransform)
        Me.Controls.Add(Me.grpLogical)
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.grpHydroGOF)
        Me.Controls.Add(Me.grpFactor)
        Me.Controls.Add(Me.grpCircular)
        Me.Controls.Add(Me.grpMaths)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucrCalculator"
        Me.Size = New System.Drawing.Size(1348, 686)
        Me.grpBasic.ResumeLayout(False)
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.ContextMenuStripDate.ResumeLayout(False)
        Me.ContextMenuStripComplex.ResumeLayout(False)
        Me.grpInteger.ResumeLayout(False)
        Me.grpInteger.PerformLayout()
        Me.ContextMenuStripInteger.ResumeLayout(False)
        Me.grpFactor.ResumeLayout(False)
        Me.grpFactor.PerformLayout()
        Me.ContextMenuStripFactor.ResumeLayout(False)
        Me.grpHydroGOF.ResumeLayout(False)
        Me.grpHydroGOF.PerformLayout()
        Me.ContextMenuStripHydroGOF.ResumeLayout(False)
        Me.grpWakefield.ResumeLayout(False)
        Me.grpMaths.ResumeLayout(False)
        Me.grpMaths.PerformLayout()
        Me.ContextMenuStripMaths.ResumeLayout(False)
        Me.grpSummary.ResumeLayout(False)
        Me.grpSummary.PerformLayout()
        Me.ContextMenuStripSummary.ResumeLayout(False)
        Me.grpFrequencies.ResumeLayout(False)
        Me.grpProbabilty.ResumeLayout(False)
        Me.grpProbabilty.PerformLayout()
        Me.ContextMenuStripProbability.ResumeLayout(False)
        Me.grpRandom.ResumeLayout(False)
        Me.grpTransform.ResumeLayout(False)
        Me.grpTransform.PerformLayout()
        Me.ContextMenuStripTransform.ResumeLayout(False)
        Me.grpLogical.ResumeLayout(False)
        Me.grpLogical.PerformLayout()
        Me.ContextMenuStripLogical.ResumeLayout(False)
        Me.grpTestString.ResumeLayout(False)
        Me.grpCircular.ResumeLayout(False)
        Me.grpCircular.PerformLayout()
        Me.ContextMenuStripCircular.ResumeLayout(False)
        Me.grpModifier.ResumeLayout(False)
        Me.grpSymbols.ResumeLayout(False)
        Me.grpComplex.ResumeLayout(False)
        Me.grpComplex.PerformLayout()
        Me.ContextMenuStripTxtString.ResumeLayout(False)
        Me.ContextMenuStripWakefield.ResumeLayout(False)
        Me.ContextMenuStripList.ResumeLayout(False)
        Me.grpList.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpMathBloc.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrReceiverForCalculation As ucrReceiverExpression
    Friend WithEvents lblExpression As Label
    Friend WithEvents ucrSelectorForCalculations As ucrSelectorByDataFrameAddRemove
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
    Friend WithEvents cmdCumSum As Button
    Friend WithEvents cmdCumMin As Button
    Friend WithEvents cmdCumMax As Button
    Friend WithEvents cmdPMin As Button
    Friend WithEvents cmdPMax As Button
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
    Friend WithEvents cmdPercentRank As Button
    Friend WithEvents cmdDiff As Button
    Friend WithEvents cmdCumdist As Button
    Friend WithEvents cmdMovMean As Button
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
    Friend WithEvents grpInteger As GroupBox
    Friend WithEvents cmdFactorial As Button
    Friend WithEvents cmdIsPrime As Button
    Friend WithEvents cmdBigZ As Button
    Friend WithEvents cmdNextPrime As Button
    Friend WithEvents cmdChoosez As Button
    Friend WithEvents cmdFibonacci As Button
    Friend WithEvents cmdDigitSum As Button
    Friend WithEvents cmdRankPercent As Button
    Friend WithEvents cmdDivisors As Button
    Friend WithEvents cmdBigQ As Button
    Friend WithEvents cmdHex As Button
    Friend WithEvents cmdOctal As Button
    Friend WithEvents cmdBinary As Button
    Friend WithEvents cmdIntegerRHelp As ucrSplitButton
    Friend WithEvents ContextMenuStripInteger As ContextMenuStrip
    Friend WithEvents DescToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RutilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdNthPrime As Button
    Friend WithEvents PrimesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdGeneratePrimes As Button
    Friend WithEvents cmdReverseStr As Button
    Friend WithEvents cmdKTuple As Button
    Friend WithEvents cmdTriplets As Button
    Friend WithEvents cmdThird As Button
    Friend WithEvents cmdSexy As Button
    Friend WithEvents cmdCousin As Button
    Friend WithEvents cmdTwin As Button
    Friend WithEvents cmdPhi As Button
    Friend WithEvents cmdCoprime As Button
    Friend WithEvents cmdSCM As Button
    Friend WithEvents cmdGCD As Button
    Friend WithEvents cmdRoman As Button
    Friend WithEvents cmdHexmode As Button
    Friend WithEvents cmdOctmode As Button
    Friend WithEvents cmdSquare As Button
    Friend WithEvents cmdTriangle As Button
    Friend WithEvents cmdPadovan As Button
    Friend WithEvents cmdAchilles As Button
    Friend WithEvents cmdHappy As Button
    Friend WithEvents cmdUgly As Button
    Friend WithEvents cmdPowerful As Button
    Friend WithEvents cmdFrugal As Button
    Friend WithEvents cmdPerfect As Button
    Friend WithEvents cmdAbundant As Button
    Friend WithEvents cmdFibonacci2 As Button
    Friend WithEvents cmdPalindrome As Button
    Friend WithEvents cmdFactorize As Button
    Friend WithEvents GmpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZseqToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtilsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdRev As Button
    Friend WithEvents cmdMovProd As Button
    Friend WithEvents cmdCumProd As Button
    Friend WithEvents cmdTransformRHelp As ucrSplitButton
    Friend WithEvents ContextMenuStripTransform As ContextMenuStrip
    Friend WithEvents BaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DplyrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZooToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdLucas As Button
    Friend WithEvents grpFrequencies As GroupBox
    Friend WithEvents cmdFreqQuantile As Button
    Friend WithEvents cmdFreqPropn As Button
    Friend WithEvents cmdFreqDistinct As Button
    Friend WithEvents cmdFreqIQR As Button
    Friend WithEvents cmdFreqMedian As Button
    Friend WithEvents cmdFreqSd As Button
    Friend WithEvents cmdFreqVar As Button
    Friend WithEvents cmdFreqMean As Button
    Friend WithEvents cmdFreqMad As Button
    Friend WithEvents cmdFreqMiss As Button
    Friend WithEvents cmdFreqMode1 As Button
    Friend WithEvents cmdFreqMax As Button
    Friend WithEvents cmdFreqMin As Button
    Friend WithEvents cmdFreqSum As Button
    Friend WithEvents cmdFreqLength As Button
    Friend WithEvents cmdSummaryRHelp As ucrSplitButton
    Friend WithEvents ContextMenuStripSummary As ContextMenuStrip
    Friend WithEvents BaseToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents E1071ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RobustbaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpRandom As GroupBox
    Friend WithEvents cmdnbinomial As Button
    Friend WithEvents cmdRan_sample As Button
    Friend WithEvents cmdRan_beta As Button
    Friend WithEvents cmdRan_gamma As Button
    Friend WithEvents cmdpoisson As Button
    Friend WithEvents cmdbinomial As Button
    Friend WithEvents cmdbernoulli As Button
    Friend WithEvents cmduni_integer As Button
    Friend WithEvents cmdRan_normal As Button
    Friend WithEvents cmduniform As Button
    Friend WithEvents grpComplex As GroupBox
    Friend WithEvents cmdReal As Button
    Friend WithEvents cmdAsComplex As Button
    Friend WithEvents cmdComplexExp As Button
    Friend WithEvents cmdComplexRound As Button
    Friend WithEvents cmdComplexLog As Button
    Friend WithEvents cmdComplexSqrt As Button
    Friend WithEvents cmdConjugate As Button
    Friend WithEvents cmdArg As Button
    Friend WithEvents cmdMod As Button
    Friend WithEvents cmdImaginary As Button
    Friend WithEvents cmdComplexTanH As Button
    Friend WithEvents cmdComplexTan As Button
    Friend WithEvents cmdComplexPi As Button
    Friend WithEvents cmdComplexDeg As Button
    Friend WithEvents cmdComplexRad As Button
    Friend WithEvents cmdComplexSignif As Button
    Friend WithEvents cmdComplexCosH As Button
    Friend WithEvents cmdComplexSinH As Button
    Friend WithEvents cmdComplexCos As Button
    Friend WithEvents cmdComplexSin As Button
    Friend WithEvents cmdComplexRHelp As ucrSplitButton
    Friend WithEvents ContextMenuStripComplex As ContextMenuStrip
    Friend WithEvents ComplexBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdRHelp As ucrSplitButton
    Friend WithEvents cmdTransformHelp As ucrSplitButton
    Friend WithEvents cmdHydroHelp As ucrSplitButton
    Friend WithEvents cmdMathsHelp As ucrSplitButton
    Friend WithEvents cmdProbRHelp As ucrSplitButton
    Friend WithEvents cmdLogicalHelp As ucrSplitButton
    Friend WithEvents cmdCircularHelp As ucrSplitButton
    Friend WithEvents cmdStringRHelp As ucrSplitButton
    Friend WithEvents cmdWakefieldHelp As ucrSplitButton
    Friend WithEvents ContextMenuStripMaths As ContextMenuStrip
    Friend WithEvents MathsStatsStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripLogical As ContextMenuStrip
    Friend WithEvents LogBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogDplyrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripTxtString As ContextMenuStrip
    Friend WithEvents TxTStringrToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxTBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripFactor As ContextMenuStrip
    Friend WithEvents FactorForcatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripProbability As ContextMenuStrip
    Friend WithEvents ProbStatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProbBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripDate As ContextMenuStrip
    Friend WithEvents DateLubridateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateHmsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripHydroGOF As ContextMenuStrip
    Friend WithEvents HydroGOFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripCircular As ContextMenuStrip
    Friend WithEvents CircularToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripWakefield As ContextMenuStrip
    Friend WithEvents WakefieldToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripList As ContextMenuStrip
    Friend WithEvents ListBaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListStatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListStatipToolStripMenuItem As ToolStripMenuItem

    Friend WithEvents cmdDecimals As Button
    Friend WithEvents cmdMASSFractions As Button
    Friend WithEvents cmdScale As Button
    Friend WithEvents MASSToolStripMenuItem As ToolStripMenuItem


    Friend WithEvents cmdPrimorial As Button
    Friend WithEvents cmdFactorize2 As Button

    Friend WithEvents cmdPascal As Button
    Friend WithEvents ConfdesignToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents grpList As GroupBox
    Friend WithEvents cmdRhelpList As ucrSplitButton
    Friend WithEvents grpMathBloc As GroupBox
    Friend WithEvents cmdListSquare As Button
    Friend WithEvents cmdListDivide As Button
    Friend WithEvents cmdListMultiply As Button
    Friend WithEvents cmdListSubtract As Button
    Friend WithEvents cmdListAdd As Button
    Friend WithEvents cmdListNth As Button
    Friend WithEvents cmdListLast As Button
    Friend WithEvents cmdListFirst As Button
    Friend WithEvents cmdListAnyDup As Button
    Friend WithEvents cmdListDistinct As Button
    Friend WithEvents cmdListIQR As Button
    Friend WithEvents cmdListMad As Button
    Friend WithEvents cmdListSd As Button
    Friend WithEvents cmdListVar As Button
    Friend WithEvents cmdListSsq As Button
    Friend WithEvents cmdListMode1 As Button
    Friend WithEvents cmdListMax As Button
    Friend WithEvents cmdListFivenum As Button
    Friend WithEvents cmdListMode As Button
    Friend WithEvents cmdListQuantile As Button
    Friend WithEvents cmdListDigitsum As Button
    Friend WithEvents cmdListMin As Button
    Friend WithEvents cmdListProd As Button
    Friend WithEvents cmdListLength As Button
    Friend WithEvents cmdListMedian As Button
    Friend WithEvents cmdListMean As Button
    Friend WithEvents cmdListRange As Button
    Friend WithEvents cmdListSum As Button
    Friend WithEvents cmdListSumd As Button
    Friend WithEvents cmdListMissing As Button
    Friend WithEvents cmdListSQRT As Button
    Friend WithEvents cmdListPercent2 As Button
    Friend WithEvents cmdListPercent As Button
    Friend WithEvents cmdListProportion As Button
    Friend WithEvents cmdListRound As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdListOmit As Button
    Friend WithEvents cmdListRev As Button
    Friend WithEvents cmdListMovsum As Button
    Friend WithEvents cmdListCumsum As Button
    Friend WithEvents cmdListScale As Button
    Friend WithEvents cmdListDiff As Button
    Friend WithEvents cmdListLead As Button
    Friend WithEvents cmdListLag As Button
    Friend WithEvents cmdListRank As Button
    Friend WithEvents cmdListSort As Button
    Friend WithEvents cmdListDuplicated As Button
    Friend WithEvents cmdListOperator As Button
    Friend WithEvents cmdListDiv As Button
    Friend WithEvents cmdListMod As Button
    Friend WithEvents cmdListIfelse As Button
End Class
