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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucrCalculator))
        Me.lblExpression = New System.Windows.Forms.Label()
        Me.chkSaveResultInto = New System.Windows.Forms.CheckBox()
        Me.cmdTry = New System.Windows.Forms.Button()
        Me.cmdHelp = New System.Windows.Forms.Button()
        Me.chkShowArguments = New System.Windows.Forms.CheckBox()
        Me.grpBasic = New System.Windows.Forms.GroupBox()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
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
        Me.grpTransform = New System.Windows.Forms.GroupBox()
        Me.cmdRowRank = New System.Windows.Forms.Button()
        Me.cmdDiff = New System.Windows.Forms.Button()
        Me.cmdEcdf = New System.Windows.Forms.Button()
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
        Me.grpSummary = New System.Windows.Forms.GroupBox()
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
        Me.cmdNear = New System.Windows.Forms.Button()
        Me.cmdBetween = New System.Windows.Forms.Button()
        Me.cmdIsFalse = New System.Windows.Forms.Button()
        Me.cmdAny = New System.Windows.Forms.Button()
        Me.cmdAll = New System.Windows.Forms.Button()
        Me.cmdIsTrue = New System.Windows.Forms.Button()
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
        Me.grpProbabilty = New System.Windows.Forms.GroupBox()
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
        Me.ucrInputCalOptions = New instat.ucrInputComboBox()
        Me.ucrSaveResultInto = New instat.ucrInputComboBox()
        Me.ucrInputTryMessage = New instat.ucrInputTextBox()
        Me.ucrSelectorForCalculations = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverForCalculation = New instat.ucrReceiverExpression()
        Me.cmdMode = New System.Windows.Forms.Button()
        Me.grpBasic.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpTransform.SuspendLayout()
        Me.grpSummary.SuspendLayout()
        Me.grpStrings.SuspendLayout()
        Me.grpLogical.SuspendLayout()
        Me.grpProbabilty.SuspendLayout()
        Me.grpMaths.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblExpression
        '
        resources.ApplyResources(Me.lblExpression, "lblExpression")
        Me.lblExpression.Name = "lblExpression"
        Me.lblExpression.Tag = "Expression"
        '
        'chkSaveResultInto
        '
        resources.ApplyResources(Me.chkSaveResultInto, "chkSaveResultInto")
        Me.chkSaveResultInto.Name = "chkSaveResultInto"
        Me.chkSaveResultInto.UseVisualStyleBackColor = True
        '
        'cmdTry
        '
        resources.ApplyResources(Me.cmdTry, "cmdTry")
        Me.cmdTry.Name = "cmdTry"
        Me.cmdTry.UseVisualStyleBackColor = True
        '
        'cmdHelp
        '
        resources.ApplyResources(Me.cmdHelp, "cmdHelp")
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.UseVisualStyleBackColor = True
        '
        'chkShowArguments
        '
        resources.ApplyResources(Me.chkShowArguments, "chkShowArguments")
        Me.chkShowArguments.Name = "chkShowArguments"
        Me.chkShowArguments.UseVisualStyleBackColor = True
        '
        'grpBasic
        '
        Me.grpBasic.Controls.Add(Me.cmdClear)
        Me.grpBasic.Controls.Add(Me.cmdDelete)
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
        resources.ApplyResources(Me.grpBasic, "grpBasic")
        Me.grpBasic.Name = "grpBasic"
        Me.grpBasic.TabStop = False
        '
        'cmdClear
        '
        resources.ApplyResources(Me.cmdClear, "cmdClear")
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        resources.ApplyResources(Me.cmdDelete, "cmdDelete")
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdBrackets
        '
        resources.ApplyResources(Me.cmdBrackets, "cmdBrackets")
        Me.cmdBrackets.Name = "cmdBrackets"
        Me.cmdBrackets.UseVisualStyleBackColor = True
        '
        'cmdPower
        '
        resources.ApplyResources(Me.cmdPower, "cmdPower")
        Me.cmdPower.Name = "cmdPower"
        Me.cmdPower.UseVisualStyleBackColor = True
        '
        'cmdDivide
        '
        resources.ApplyResources(Me.cmdDivide, "cmdDivide")
        Me.cmdDivide.Name = "cmdDivide"
        Me.cmdDivide.UseVisualStyleBackColor = True
        '
        'cmdPlus
        '
        resources.ApplyResources(Me.cmdPlus, "cmdPlus")
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.UseVisualStyleBackColor = True
        '
        'cmdMinus
        '
        resources.ApplyResources(Me.cmdMinus, "cmdMinus")
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.UseVisualStyleBackColor = True
        '
        'cmdMultiply
        '
        resources.ApplyResources(Me.cmdMultiply, "cmdMultiply")
        Me.cmdMultiply.Name = "cmdMultiply"
        Me.cmdMultiply.UseVisualStyleBackColor = True
        '
        'cmdDot
        '
        resources.ApplyResources(Me.cmdDot, "cmdDot")
        Me.cmdDot.Name = "cmdDot"
        Me.cmdDot.UseVisualStyleBackColor = True
        '
        'cmd9
        '
        resources.ApplyResources(Me.cmd9, "cmd9")
        Me.cmd9.Name = "cmd9"
        Me.cmd9.UseVisualStyleBackColor = True
        '
        'cmd8
        '
        resources.ApplyResources(Me.cmd8, "cmd8")
        Me.cmd8.Name = "cmd8"
        Me.cmd8.UseVisualStyleBackColor = True
        '
        'cmd7
        '
        resources.ApplyResources(Me.cmd7, "cmd7")
        Me.cmd7.Name = "cmd7"
        Me.cmd7.UseVisualStyleBackColor = True
        '
        'cmd6
        '
        resources.ApplyResources(Me.cmd6, "cmd6")
        Me.cmd6.Name = "cmd6"
        Me.cmd6.UseVisualStyleBackColor = True
        '
        'cmd5
        '
        resources.ApplyResources(Me.cmd5, "cmd5")
        Me.cmd5.Name = "cmd5"
        Me.cmd5.UseVisualStyleBackColor = True
        '
        'cmd4
        '
        resources.ApplyResources(Me.cmd4, "cmd4")
        Me.cmd4.Name = "cmd4"
        Me.cmd4.UseVisualStyleBackColor = True
        '
        'cmd3
        '
        resources.ApplyResources(Me.cmd3, "cmd3")
        Me.cmd3.Name = "cmd3"
        Me.cmd3.UseVisualStyleBackColor = True
        '
        'cmd2
        '
        resources.ApplyResources(Me.cmd2, "cmd2")
        Me.cmd2.Name = "cmd2"
        Me.cmd2.UseVisualStyleBackColor = True
        '
        'cmd0
        '
        resources.ApplyResources(Me.cmd0, "cmd0")
        Me.cmd0.Name = "cmd0"
        Me.cmd0.UseVisualStyleBackColor = True
        '
        'cmd1
        '
        resources.ApplyResources(Me.cmd1, "cmd1")
        Me.cmd1.Name = "cmd1"
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
        resources.ApplyResources(Me.grpDates, "grpDates")
        Me.grpDates.Name = "grpDates"
        Me.grpDates.TabStop = False
        '
        'cmdDmy
        '
        resources.ApplyResources(Me.cmdDmy, "cmdDmy")
        Me.cmdDmy.Name = "cmdDmy"
        Me.cmdDmy.Tag = "dmy"
        Me.cmdDmy.UseVisualStyleBackColor = True
        '
        'cmdDek
        '
        resources.ApplyResources(Me.cmdDek, "cmdDek")
        Me.cmdDek.Name = "cmdDek"
        Me.cmdDek.UseVisualStyleBackColor = True
        '
        'cmdDay
        '
        resources.ApplyResources(Me.cmdDay, "cmdDay")
        Me.cmdDay.Name = "cmdDay"
        Me.cmdDay.UseVisualStyleBackColor = True
        '
        'cmdMonth
        '
        resources.ApplyResources(Me.cmdMonth, "cmdMonth")
        Me.cmdMonth.Name = "cmdMonth"
        Me.cmdMonth.UseVisualStyleBackColor = True
        '
        'cmdYear
        '
        resources.ApplyResources(Me.cmdYear, "cmdYear")
        Me.cmdYear.Name = "cmdYear"
        Me.cmdYear.UseVisualStyleBackColor = True
        '
        'cmdDate
        '
        resources.ApplyResources(Me.cmdDate, "cmdDate")
        Me.cmdDate.Name = "cmdDate"
        Me.cmdDate.UseVisualStyleBackColor = True
        '
        'cmdYday
        '
        resources.ApplyResources(Me.cmdYday, "cmdYday")
        Me.cmdYday.Name = "cmdYday"
        Me.cmdYday.UseVisualStyleBackColor = True
        '
        'cmdWday
        '
        resources.ApplyResources(Me.cmdWday, "cmdWday")
        Me.cmdWday.Name = "cmdWday"
        Me.cmdWday.UseVisualStyleBackColor = True
        '
        'cmdMdy
        '
        resources.ApplyResources(Me.cmdMdy, "cmdMdy")
        Me.cmdMdy.Name = "cmdMdy"
        Me.cmdMdy.UseVisualStyleBackColor = True
        '
        'cmdYmd
        '
        resources.ApplyResources(Me.cmdYmd, "cmdYmd")
        Me.cmdYmd.Name = "cmdYmd"
        Me.cmdYmd.UseVisualStyleBackColor = True
        '
        'cmdDoy
        '
        resources.ApplyResources(Me.cmdDoy, "cmdDoy")
        Me.cmdDoy.Name = "cmdDoy"
        Me.cmdDoy.UseVisualStyleBackColor = True
        '
        'cmdLeap
        '
        resources.ApplyResources(Me.cmdLeap, "cmdLeap")
        Me.cmdLeap.Name = "cmdLeap"
        Me.cmdLeap.UseVisualStyleBackColor = True
        '
        'grpTransform
        '
        Me.grpTransform.Controls.Add(Me.cmdRowRank)
        Me.grpTransform.Controls.Add(Me.cmdDiff)
        Me.grpTransform.Controls.Add(Me.cmdEcdf)
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
        resources.ApplyResources(Me.grpTransform, "grpTransform")
        Me.grpTransform.Name = "grpTransform"
        Me.grpTransform.TabStop = False
        '
        'cmdRowRank
        '
        resources.ApplyResources(Me.cmdRowRank, "cmdRowRank")
        Me.cmdRowRank.Name = "cmdRowRank"
        Me.cmdRowRank.UseVisualStyleBackColor = True
        '
        'cmdDiff
        '
        resources.ApplyResources(Me.cmdDiff, "cmdDiff")
        Me.cmdDiff.Name = "cmdDiff"
        Me.cmdDiff.UseVisualStyleBackColor = True
        '
        'cmdEcdf
        '
        resources.ApplyResources(Me.cmdEcdf, "cmdEcdf")
        Me.cmdEcdf.Name = "cmdEcdf"
        Me.cmdEcdf.UseVisualStyleBackColor = True
        '
        'cmdmovemean
        '
        resources.ApplyResources(Me.cmdmovemean, "cmdmovemean")
        Me.cmdmovemean.Name = "cmdmovemean"
        Me.cmdmovemean.UseVisualStyleBackColor = True
        '
        'cmdCumMean
        '
        resources.ApplyResources(Me.cmdCumMean, "cmdCumMean")
        Me.cmdCumMean.Name = "cmdCumMean"
        Me.cmdCumMean.UseVisualStyleBackColor = True
        '
        'cmdNtile
        '
        resources.ApplyResources(Me.cmdNtile, "cmdNtile")
        Me.cmdNtile.Name = "cmdNtile"
        Me.cmdNtile.UseVisualStyleBackColor = True
        '
        'cmMovMed
        '
        resources.ApplyResources(Me.cmMovMed, "cmMovMed")
        Me.cmMovMed.Name = "cmMovMed"
        Me.cmMovMed.UseVisualStyleBackColor = True
        '
        'cmdMRank
        '
        resources.ApplyResources(Me.cmdMRank, "cmdMRank")
        Me.cmdMRank.Name = "cmdMRank"
        Me.cmdMRank.UseVisualStyleBackColor = True
        '
        'cmdDRank
        '
        resources.ApplyResources(Me.cmdDRank, "cmdDRank")
        Me.cmdDRank.Name = "cmdDRank"
        Me.cmdDRank.UseVisualStyleBackColor = True
        '
        'cmdMovMax
        '
        resources.ApplyResources(Me.cmdMovMax, "cmdMovMax")
        Me.cmdMovMax.Name = "cmdMovMax"
        Me.cmdMovMax.UseVisualStyleBackColor = True
        '
        'cmdMovSum
        '
        resources.ApplyResources(Me.cmdMovSum, "cmdMovSum")
        Me.cmdMovSum.Name = "cmdMovSum"
        Me.cmdMovSum.UseVisualStyleBackColor = True
        '
        'cmdpercentrank
        '
        resources.ApplyResources(Me.cmdpercentrank, "cmdpercentrank")
        Me.cmdpercentrank.Name = "cmdpercentrank"
        Me.cmdpercentrank.UseVisualStyleBackColor = True
        '
        'cmdcumsum
        '
        resources.ApplyResources(Me.cmdcumsum, "cmdcumsum")
        Me.cmdcumsum.Name = "cmdcumsum"
        Me.cmdcumsum.UseVisualStyleBackColor = True
        '
        'cmdcummin
        '
        resources.ApplyResources(Me.cmdcummin, "cmdcummin")
        Me.cmdcummin.Name = "cmdcummin"
        Me.cmdcummin.UseVisualStyleBackColor = True
        '
        'cmdcummax
        '
        resources.ApplyResources(Me.cmdcummax, "cmdcummax")
        Me.cmdcummax.Name = "cmdcummax"
        Me.cmdcummax.UseVisualStyleBackColor = True
        '
        'cmdPMin
        '
        resources.ApplyResources(Me.cmdPMin, "cmdPMin")
        Me.cmdPMin.Name = "cmdPMin"
        Me.cmdPMin.UseVisualStyleBackColor = True
        '
        'cmdpmax
        '
        resources.ApplyResources(Me.cmdpmax, "cmdpmax")
        Me.cmdpmax.Name = "cmdpmax"
        Me.cmdpmax.UseVisualStyleBackColor = True
        '
        'cmdLead
        '
        resources.ApplyResources(Me.cmdLead, "cmdLead")
        Me.cmdLead.Name = "cmdLead"
        Me.cmdLead.UseVisualStyleBackColor = True
        '
        'cmdLag
        '
        resources.ApplyResources(Me.cmdLag, "cmdLag")
        Me.cmdLag.Name = "cmdLag"
        Me.cmdLag.UseVisualStyleBackColor = True
        '
        'grpSummary
        '
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
        resources.ApplyResources(Me.grpSummary, "grpSummary")
        Me.grpSummary.Name = "grpSummary"
        Me.grpSummary.TabStop = False
        '
        'cmdFirst
        '
        resources.ApplyResources(Me.cmdFirst, "cmdFirst")
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.UseVisualStyleBackColor = True
        '
        'cmdLast
        '
        resources.ApplyResources(Me.cmdLast, "cmdLast")
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdnth
        '
        resources.ApplyResources(Me.cmdnth, "cmdnth")
        Me.cmdnth.Name = "cmdnth"
        Me.cmdnth.UseVisualStyleBackColor = True
        '
        'cmdCor
        '
        resources.ApplyResources(Me.cmdCor, "cmdCor")
        Me.cmdCor.Name = "cmdCor"
        Me.cmdCor.UseVisualStyleBackColor = True
        '
        'cmdCov
        '
        resources.ApplyResources(Me.cmdCov, "cmdCov")
        Me.cmdCov.Name = "cmdCov"
        Me.cmdCov.UseVisualStyleBackColor = True
        '
        'cmdMad
        '
        resources.ApplyResources(Me.cmdMad, "cmdMad")
        Me.cmdMad.Name = "cmdMad"
        Me.cmdMad.UseVisualStyleBackColor = True
        '
        'cmdMc
        '
        resources.ApplyResources(Me.cmdMc, "cmdMc")
        Me.cmdMc.Name = "cmdMc"
        Me.cmdMc.UseVisualStyleBackColor = True
        '
        'cmdPropn
        '
        resources.ApplyResources(Me.cmdPropn, "cmdPropn")
        Me.cmdPropn.Name = "cmdPropn"
        Me.cmdPropn.UseVisualStyleBackColor = True
        '
        'cmdCv
        '
        resources.ApplyResources(Me.cmdCv, "cmdCv")
        Me.cmdCv.Name = "cmdCv"
        Me.cmdCv.UseVisualStyleBackColor = True
        '
        'cmdSkew
        '
        resources.ApplyResources(Me.cmdSkew, "cmdSkew")
        Me.cmdSkew.Name = "cmdSkew"
        Me.cmdSkew.UseVisualStyleBackColor = True
        '
        'cmdAnyDup
        '
        resources.ApplyResources(Me.cmdAnyDup, "cmdAnyDup")
        Me.cmdAnyDup.Name = "cmdAnyDup"
        Me.cmdAnyDup.UseVisualStyleBackColor = True
        '
        'cmdDistinct
        '
        resources.ApplyResources(Me.cmdDistinct, "cmdDistinct")
        Me.cmdDistinct.Name = "cmdDistinct"
        Me.cmdDistinct.UseVisualStyleBackColor = True
        '
        'cmdNonMiss
        '
        resources.ApplyResources(Me.cmdNonMiss, "cmdNonMiss")
        Me.cmdNonMiss.Name = "cmdNonMiss"
        Me.cmdNonMiss.UseVisualStyleBackColor = True
        '
        'cmdIQR
        '
        resources.ApplyResources(Me.cmdIQR, "cmdIQR")
        Me.cmdIQR.Name = "cmdIQR"
        Me.cmdIQR.UseVisualStyleBackColor = True
        '
        'cmdQuantile
        '
        resources.ApplyResources(Me.cmdQuantile, "cmdQuantile")
        Me.cmdQuantile.Name = "cmdQuantile"
        Me.cmdQuantile.UseVisualStyleBackColor = True
        '
        'cmdRange
        '
        resources.ApplyResources(Me.cmdRange, "cmdRange")
        Me.cmdRange.Name = "cmdRange"
        Me.cmdRange.UseVisualStyleBackColor = True
        '
        'cmdSd
        '
        resources.ApplyResources(Me.cmdSd, "cmdSd")
        Me.cmdSd.Name = "cmdSd"
        Me.cmdSd.UseVisualStyleBackColor = True
        '
        'cmdMedian
        '
        resources.ApplyResources(Me.cmdMedian, "cmdMedian")
        Me.cmdMedian.Name = "cmdMedian"
        Me.cmdMedian.UseVisualStyleBackColor = True
        '
        'cmdMin
        '
        resources.ApplyResources(Me.cmdMin, "cmdMin")
        Me.cmdMin.Name = "cmdMin"
        Me.cmdMin.UseVisualStyleBackColor = True
        '
        'cmdMax
        '
        resources.ApplyResources(Me.cmdMax, "cmdMax")
        Me.cmdMax.Name = "cmdMax"
        Me.cmdMax.UseVisualStyleBackColor = True
        '
        'cmdMean
        '
        resources.ApplyResources(Me.cmdMean, "cmdMean")
        Me.cmdMean.Name = "cmdMean"
        Me.cmdMean.UseVisualStyleBackColor = True
        '
        'cmdMiss
        '
        resources.ApplyResources(Me.cmdMiss, "cmdMiss")
        Me.cmdMiss.Name = "cmdMiss"
        Me.cmdMiss.UseVisualStyleBackColor = True
        '
        'cmdLength
        '
        resources.ApplyResources(Me.cmdLength, "cmdLength")
        Me.cmdLength.Name = "cmdLength"
        Me.cmdLength.UseVisualStyleBackColor = True
        '
        'cmdSum
        '
        resources.ApplyResources(Me.cmdSum, "cmdSum")
        Me.cmdSum.Name = "cmdSum"
        Me.cmdSum.UseVisualStyleBackColor = True
        '
        'cmdVar
        '
        resources.ApplyResources(Me.cmdVar, "cmdVar")
        Me.cmdVar.Name = "cmdVar"
        Me.cmdVar.UseVisualStyleBackColor = True
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
        resources.ApplyResources(Me.grpStrings, "grpStrings")
        Me.grpStrings.Name = "grpStrings"
        Me.grpStrings.TabStop = False
        '
        'cmdSplit
        '
        resources.ApplyResources(Me.cmdSplit, "cmdSplit")
        Me.cmdSplit.Name = "cmdSplit"
        Me.cmdSplit.Tag = ""
        Me.cmdSplit.UseVisualStyleBackColor = True
        '
        'cmdCombine
        '
        resources.ApplyResources(Me.cmdCombine, "cmdCombine")
        Me.cmdCombine.Name = "cmdCombine"
        Me.cmdCombine.UseVisualStyleBackColor = True
        '
        'cmdDetect
        '
        resources.ApplyResources(Me.cmdDetect, "cmdDetect")
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Tag = ""
        Me.cmdDetect.UseVisualStyleBackColor = True
        '
        'cmdTrim
        '
        resources.ApplyResources(Me.cmdTrim, "cmdTrim")
        Me.cmdTrim.Name = "cmdTrim"
        Me.cmdTrim.UseVisualStyleBackColor = True
        '
        'cmdReplace
        '
        resources.ApplyResources(Me.cmdReplace, "cmdReplace")
        Me.cmdReplace.Name = "cmdReplace"
        Me.cmdReplace.UseVisualStyleBackColor = True
        '
        'cmdTitle
        '
        resources.ApplyResources(Me.cmdTitle, "cmdTitle")
        Me.cmdTitle.Name = "cmdTitle"
        Me.cmdTitle.UseVisualStyleBackColor = True
        '
        'cmdLower
        '
        resources.ApplyResources(Me.cmdLower, "cmdLower")
        Me.cmdLower.Name = "cmdLower"
        Me.cmdLower.UseVisualStyleBackColor = True
        '
        'cmdUpper
        '
        resources.ApplyResources(Me.cmdUpper, "cmdUpper")
        Me.cmdUpper.Name = "cmdUpper"
        Me.cmdUpper.UseVisualStyleBackColor = True
        '
        'cmdSort
        '
        resources.ApplyResources(Me.cmdSort, "cmdSort")
        Me.cmdSort.Name = "cmdSort"
        Me.cmdSort.UseVisualStyleBackColor = True
        '
        'cmdOrder
        '
        resources.ApplyResources(Me.cmdOrder, "cmdOrder")
        Me.cmdOrder.Name = "cmdOrder"
        Me.cmdOrder.UseVisualStyleBackColor = True
        '
        'cmdPad
        '
        resources.ApplyResources(Me.cmdPad, "cmdPad")
        Me.cmdPad.Name = "cmdPad"
        Me.cmdPad.UseVisualStyleBackColor = True
        '
        'cmdExtract
        '
        resources.ApplyResources(Me.cmdExtract, "cmdExtract")
        Me.cmdExtract.Name = "cmdExtract"
        Me.cmdExtract.UseVisualStyleBackColor = True
        '
        'cmdCountstrings
        '
        resources.ApplyResources(Me.cmdCountstrings, "cmdCountstrings")
        Me.cmdCountstrings.Name = "cmdCountstrings"
        Me.cmdCountstrings.UseVisualStyleBackColor = True
        '
        'cmdLocate
        '
        resources.ApplyResources(Me.cmdLocate, "cmdLocate")
        Me.cmdLocate.Name = "cmdLocate"
        Me.cmdLocate.UseVisualStyleBackColor = True
        '
        'grpLogical
        '
        Me.grpLogical.Controls.Add(Me.cmdNear)
        Me.grpLogical.Controls.Add(Me.cmdBetween)
        Me.grpLogical.Controls.Add(Me.cmdIsFalse)
        Me.grpLogical.Controls.Add(Me.cmdAny)
        Me.grpLogical.Controls.Add(Me.cmdAll)
        Me.grpLogical.Controls.Add(Me.cmdIsTrue)
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
        resources.ApplyResources(Me.grpLogical, "grpLogical")
        Me.grpLogical.Name = "grpLogical"
        Me.grpLogical.TabStop = False
        '
        'cmdNear
        '
        resources.ApplyResources(Me.cmdNear, "cmdNear")
        Me.cmdNear.Name = "cmdNear"
        Me.cmdNear.UseVisualStyleBackColor = True
        '
        'cmdBetween
        '
        resources.ApplyResources(Me.cmdBetween, "cmdBetween")
        Me.cmdBetween.Name = "cmdBetween"
        Me.cmdBetween.UseVisualStyleBackColor = True
        '
        'cmdIsFalse
        '
        resources.ApplyResources(Me.cmdIsFalse, "cmdIsFalse")
        Me.cmdIsFalse.Name = "cmdIsFalse"
        Me.cmdIsFalse.UseVisualStyleBackColor = True
        '
        'cmdAny
        '
        resources.ApplyResources(Me.cmdAny, "cmdAny")
        Me.cmdAny.Name = "cmdAny"
        Me.cmdAny.UseVisualStyleBackColor = True
        '
        'cmdAll
        '
        resources.ApplyResources(Me.cmdAll, "cmdAll")
        Me.cmdAll.Name = "cmdAll"
        Me.cmdAll.UseVisualStyleBackColor = True
        '
        'cmdIsTrue
        '
        resources.ApplyResources(Me.cmdIsTrue, "cmdIsTrue")
        Me.cmdIsTrue.Name = "cmdIsTrue"
        Me.cmdIsTrue.UseVisualStyleBackColor = True
        '
        'cmdIsNa
        '
        resources.ApplyResources(Me.cmdIsNa, "cmdIsNa")
        Me.cmdIsNa.Name = "cmdIsNa"
        Me.cmdIsNa.UseVisualStyleBackColor = True
        '
        'cmdNotIsNa
        '
        resources.ApplyResources(Me.cmdNotIsNa, "cmdNotIsNa")
        Me.cmdNotIsNa.Name = "cmdNotIsNa"
        Me.cmdNotIsNa.UseVisualStyleBackColor = True
        '
        'cmdDuplicate
        '
        resources.ApplyResources(Me.cmdDuplicate, "cmdDuplicate")
        Me.cmdDuplicate.Name = "cmdDuplicate"
        Me.cmdDuplicate.UseVisualStyleBackColor = True
        '
        'cmdIfelse
        '
        resources.ApplyResources(Me.cmdIfelse, "cmdIfelse")
        Me.cmdIfelse.Name = "cmdIfelse"
        Me.cmdIfelse.UseVisualStyleBackColor = True
        '
        'cmdmatch
        '
        resources.ApplyResources(Me.cmdmatch, "cmdmatch")
        Me.cmdmatch.Name = "cmdmatch"
        Me.cmdmatch.UseVisualStyleBackColor = True
        '
        'cmdwhen
        '
        resources.ApplyResources(Me.cmdwhen, "cmdwhen")
        Me.cmdwhen.Name = "cmdwhen"
        Me.cmdwhen.UseVisualStyleBackColor = True
        '
        'cmdOpeningBracket
        '
        resources.ApplyResources(Me.cmdOpeningBracket, "cmdOpeningBracket")
        Me.cmdOpeningBracket.Name = "cmdOpeningBracket"
        Me.cmdOpeningBracket.UseVisualStyleBackColor = True
        '
        'cmdColon
        '
        resources.ApplyResources(Me.cmdColon, "cmdColon")
        Me.cmdColon.Name = "cmdColon"
        Me.cmdColon.UseVisualStyleBackColor = True
        '
        'cmdGreaterOrEqualsTo
        '
        resources.ApplyResources(Me.cmdGreaterOrEqualsTo, "cmdGreaterOrEqualsTo")
        Me.cmdGreaterOrEqualsTo.Name = "cmdGreaterOrEqualsTo"
        Me.cmdGreaterOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdClossingBracket
        '
        resources.ApplyResources(Me.cmdClossingBracket, "cmdClossingBracket")
        Me.cmdClossingBracket.Name = "cmdClossingBracket"
        Me.cmdClossingBracket.Tag = ""
        Me.cmdClossingBracket.UseVisualStyleBackColor = True
        '
        'cmdAnd
        '
        resources.ApplyResources(Me.cmdAnd, "cmdAnd")
        Me.cmdAnd.Name = "cmdAnd"
        Me.cmdAnd.Tag = "And"
        Me.cmdAnd.UseVisualStyleBackColor = True
        '
        'cmdQuotes
        '
        resources.ApplyResources(Me.cmdQuotes, "cmdQuotes")
        Me.cmdQuotes.Name = "cmdQuotes"
        Me.cmdQuotes.UseVisualStyleBackColor = True
        '
        'cmdSquareBrackets
        '
        resources.ApplyResources(Me.cmdSquareBrackets, "cmdSquareBrackets")
        Me.cmdSquareBrackets.Name = "cmdSquareBrackets"
        Me.cmdSquareBrackets.UseVisualStyleBackColor = True
        '
        'cmdIntegerDivision
        '
        resources.ApplyResources(Me.cmdIntegerDivision, "cmdIntegerDivision")
        Me.cmdIntegerDivision.Name = "cmdIntegerDivision"
        Me.cmdIntegerDivision.UseVisualStyleBackColor = True
        '
        'cmdModulas
        '
        resources.ApplyResources(Me.cmdModulas, "cmdModulas")
        Me.cmdModulas.Name = "cmdModulas"
        Me.cmdModulas.UseVisualStyleBackColor = True
        '
        'cmdGreater
        '
        resources.ApplyResources(Me.cmdGreater, "cmdGreater")
        Me.cmdGreater.Name = "cmdGreater"
        Me.cmdGreater.UseVisualStyleBackColor = True
        '
        'cmdLesserOrEqualsTo
        '
        resources.ApplyResources(Me.cmdLesserOrEqualsTo, "cmdLesserOrEqualsTo")
        Me.cmdLesserOrEqualsTo.Name = "cmdLesserOrEqualsTo"
        Me.cmdLesserOrEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdLesser
        '
        resources.ApplyResources(Me.cmdLesser, "cmdLesser")
        Me.cmdLesser.Name = "cmdLesser"
        Me.cmdLesser.UseVisualStyleBackColor = True
        '
        'cmdOr
        '
        resources.ApplyResources(Me.cmdOr, "cmdOr")
        Me.cmdOr.Name = "cmdOr"
        Me.cmdOr.UseVisualStyleBackColor = True
        '
        'cmdNot
        '
        resources.ApplyResources(Me.cmdNot, "cmdNot")
        Me.cmdNot.Name = "cmdNot"
        Me.cmdNot.UseVisualStyleBackColor = True
        '
        'cmdNotEqualsTo
        '
        resources.ApplyResources(Me.cmdNotEqualsTo, "cmdNotEqualsTo")
        Me.cmdNotEqualsTo.Name = "cmdNotEqualsTo"
        Me.cmdNotEqualsTo.UseVisualStyleBackColor = True
        '
        'cmdEquivalent
        '
        resources.ApplyResources(Me.cmdEquivalent, "cmdEquivalent")
        Me.cmdEquivalent.Name = "cmdEquivalent"
        Me.cmdEquivalent.UseVisualStyleBackColor = True
        '
        'grpProbabilty
        '
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
        resources.ApplyResources(Me.grpProbabilty, "grpProbabilty")
        Me.grpProbabilty.Name = "grpProbabilty"
        Me.grpProbabilty.TabStop = False
        '
        'cmdGamma
        '
        resources.ApplyResources(Me.cmdGamma, "cmdGamma")
        Me.cmdGamma.Name = "cmdGamma"
        Me.cmdGamma.Tag = ""
        Me.cmdGamma.UseVisualStyleBackColor = True
        '
        'cmdLbeta
        '
        resources.ApplyResources(Me.cmdLbeta, "cmdLbeta")
        Me.cmdLbeta.Name = "cmdLbeta"
        Me.cmdLbeta.UseVisualStyleBackColor = True
        '
        'cmdqF
        '
        resources.ApplyResources(Me.cmdqF, "cmdqF")
        Me.cmdqF.Name = "cmdqF"
        Me.cmdqF.UseVisualStyleBackColor = True
        '
        'cmdFact
        '
        resources.ApplyResources(Me.cmdFact, "cmdFact")
        Me.cmdFact.Name = "cmdFact"
        Me.cmdFact.UseVisualStyleBackColor = True
        '
        'cmdChoose
        '
        resources.ApplyResources(Me.cmdChoose, "cmdChoose")
        Me.cmdChoose.Name = "cmdChoose"
        Me.cmdChoose.UseVisualStyleBackColor = True
        '
        'cmdPf
        '
        resources.ApplyResources(Me.cmdPf, "cmdPf")
        Me.cmdPf.Name = "cmdPf"
        Me.cmdPf.UseVisualStyleBackColor = True
        '
        'cmdPChisq
        '
        resources.ApplyResources(Me.cmdPChisq, "cmdPChisq")
        Me.cmdPChisq.Name = "cmdPChisq"
        Me.cmdPChisq.UseVisualStyleBackColor = True
        '
        'cmdLgamma
        '
        resources.ApplyResources(Me.cmdLgamma, "cmdLgamma")
        Me.cmdLgamma.Name = "cmdLgamma"
        Me.cmdLgamma.UseVisualStyleBackColor = True
        '
        'cmdPnorm
        '
        resources.ApplyResources(Me.cmdPnorm, "cmdPnorm")
        Me.cmdPnorm.Name = "cmdPnorm"
        Me.cmdPnorm.UseVisualStyleBackColor = True
        '
        'cmdQchisq
        '
        resources.ApplyResources(Me.cmdQchisq, "cmdQchisq")
        Me.cmdQchisq.Name = "cmdQchisq"
        Me.cmdQchisq.UseVisualStyleBackColor = True
        '
        'cmdQt
        '
        resources.ApplyResources(Me.cmdQt, "cmdQt")
        Me.cmdQt.Name = "cmdQt"
        Me.cmdQt.UseVisualStyleBackColor = True
        '
        'cmdQnorm
        '
        resources.ApplyResources(Me.cmdQnorm, "cmdQnorm")
        Me.cmdQnorm.Name = "cmdQnorm"
        Me.cmdQnorm.UseVisualStyleBackColor = True
        '
        'cmdPt
        '
        resources.ApplyResources(Me.cmdPt, "cmdPt")
        Me.cmdPt.Name = "cmdPt"
        Me.cmdPt.UseVisualStyleBackColor = True
        '
        'cmdLchoose
        '
        resources.ApplyResources(Me.cmdLchoose, "cmdLchoose")
        Me.cmdLchoose.Name = "cmdLchoose"
        Me.cmdLchoose.UseVisualStyleBackColor = True
        '
        'cmdLfact
        '
        resources.ApplyResources(Me.cmdLfact, "cmdLfact")
        Me.cmdLfact.Name = "cmdLfact"
        Me.cmdLfact.UseVisualStyleBackColor = True
        '
        'cmdTrigamma
        '
        resources.ApplyResources(Me.cmdTrigamma, "cmdTrigamma")
        Me.cmdTrigamma.Name = "cmdTrigamma"
        Me.cmdTrigamma.UseVisualStyleBackColor = True
        '
        'cmdBeta
        '
        resources.ApplyResources(Me.cmdBeta, "cmdBeta")
        Me.cmdBeta.Name = "cmdBeta"
        Me.cmdBeta.UseVisualStyleBackColor = True
        '
        'cmdDigamma
        '
        resources.ApplyResources(Me.cmdDigamma, "cmdDigamma")
        Me.cmdDigamma.Name = "cmdDigamma"
        Me.cmdDigamma.UseVisualStyleBackColor = True
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
        resources.ApplyResources(Me.grpMaths, "grpMaths")
        Me.grpMaths.Name = "grpMaths"
        Me.grpMaths.TabStop = False
        '
        'cmdSign
        '
        resources.ApplyResources(Me.cmdSign, "cmdSign")
        Me.cmdSign.Name = "cmdSign"
        Me.cmdSign.UseVisualStyleBackColor = True
        '
        'cmdRound
        '
        resources.ApplyResources(Me.cmdRound, "cmdRound")
        Me.cmdRound.Name = "cmdRound"
        Me.cmdRound.UseVisualStyleBackColor = True
        '
        'cmdSiginf
        '
        resources.ApplyResources(Me.cmdSiginf, "cmdSiginf")
        Me.cmdSiginf.Name = "cmdSiginf"
        Me.cmdSiginf.UseVisualStyleBackColor = True
        '
        'cmdAbs
        '
        resources.ApplyResources(Me.cmdAbs, "cmdAbs")
        Me.cmdAbs.Name = "cmdAbs"
        Me.cmdAbs.UseVisualStyleBackColor = True
        '
        'cmdExp
        '
        resources.ApplyResources(Me.cmdExp, "cmdExp")
        Me.cmdExp.Name = "cmdExp"
        Me.cmdExp.UseVisualStyleBackColor = True
        '
        'cmdDeg
        '
        resources.ApplyResources(Me.cmdDeg, "cmdDeg")
        Me.cmdDeg.Name = "cmdDeg"
        Me.cmdDeg.UseVisualStyleBackColor = True
        '
        'cmdTrunc
        '
        resources.ApplyResources(Me.cmdTrunc, "cmdTrunc")
        Me.cmdTrunc.Name = "cmdTrunc"
        Me.cmdTrunc.UseVisualStyleBackColor = True
        '
        'cmdAtan
        '
        resources.ApplyResources(Me.cmdAtan, "cmdAtan")
        Me.cmdAtan.Name = "cmdAtan"
        Me.cmdAtan.UseVisualStyleBackColor = True
        '
        'cmdTan
        '
        resources.ApplyResources(Me.cmdTan, "cmdTan")
        Me.cmdTan.Name = "cmdTan"
        Me.cmdTan.UseVisualStyleBackColor = True
        '
        'cmdLogTen
        '
        resources.ApplyResources(Me.cmdLogTen, "cmdLogTen")
        Me.cmdLogTen.Name = "cmdLogTen"
        Me.cmdLogTen.UseVisualStyleBackColor = True
        '
        'cmdRad
        '
        resources.ApplyResources(Me.cmdRad, "cmdRad")
        Me.cmdRad.Name = "cmdRad"
        Me.cmdRad.UseVisualStyleBackColor = True
        '
        'cmdFloor
        '
        resources.ApplyResources(Me.cmdFloor, "cmdFloor")
        Me.cmdFloor.Name = "cmdFloor"
        Me.cmdFloor.UseVisualStyleBackColor = True
        '
        'cmdAsin
        '
        resources.ApplyResources(Me.cmdAsin, "cmdAsin")
        Me.cmdAsin.Name = "cmdAsin"
        Me.cmdAsin.UseVisualStyleBackColor = True
        '
        'cmdSin
        '
        resources.ApplyResources(Me.cmdSin, "cmdSin")
        Me.cmdSin.Name = "cmdSin"
        Me.cmdSin.UseVisualStyleBackColor = True
        '
        'cmdLog
        '
        resources.ApplyResources(Me.cmdLog, "cmdLog")
        Me.cmdLog.Name = "cmdLog"
        Me.cmdLog.UseVisualStyleBackColor = True
        '
        'cmdPi
        '
        resources.ApplyResources(Me.cmdPi, "cmdPi")
        Me.cmdPi.Name = "cmdPi"
        Me.cmdPi.UseVisualStyleBackColor = True
        '
        'cmdCeiling
        '
        resources.ApplyResources(Me.cmdCeiling, "cmdCeiling")
        Me.cmdCeiling.Name = "cmdCeiling"
        Me.cmdCeiling.UseVisualStyleBackColor = True
        '
        'cmdAcos
        '
        resources.ApplyResources(Me.cmdAcos, "cmdAcos")
        Me.cmdAcos.Name = "cmdAcos"
        Me.cmdAcos.UseVisualStyleBackColor = True
        '
        'cmdCos
        '
        resources.ApplyResources(Me.cmdCos, "cmdCos")
        Me.cmdCos.Name = "cmdCos"
        Me.cmdCos.UseVisualStyleBackColor = True
        '
        'cmdSqrt
        '
        resources.ApplyResources(Me.cmdSqrt, "cmdSqrt")
        Me.cmdSqrt.Name = "cmdSqrt"
        Me.cmdSqrt.UseVisualStyleBackColor = True
        '
        'ucrInputCalOptions
        '
        Me.ucrInputCalOptions.AddQuotesIfUnrecognised = True
        Me.ucrInputCalOptions.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputCalOptions, "ucrInputCalOptions")
        Me.ucrInputCalOptions.Name = "ucrInputCalOptions"
        '
        'ucrSaveResultInto
        '
        Me.ucrSaveResultInto.AddQuotesIfUnrecognised = True
        Me.ucrSaveResultInto.IsReadOnly = False
        resources.ApplyResources(Me.ucrSaveResultInto, "ucrSaveResultInto")
        Me.ucrSaveResultInto.Name = "ucrSaveResultInto"
        '
        'ucrInputTryMessage
        '
        Me.ucrInputTryMessage.AddQuotesIfUnrecognised = True
        Me.ucrInputTryMessage.IsMultiline = False
        Me.ucrInputTryMessage.IsReadOnly = True
        resources.ApplyResources(Me.ucrInputTryMessage, "ucrInputTryMessage")
        Me.ucrInputTryMessage.Name = "ucrInputTryMessage"
        '
        'ucrSelectorForCalculations
        '
        Me.ucrSelectorForCalculations.bShowHiddenColumns = False
        Me.ucrSelectorForCalculations.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrSelectorForCalculations, "ucrSelectorForCalculations")
        Me.ucrSelectorForCalculations.Name = "ucrSelectorForCalculations"
        '
        'ucrReceiverForCalculation
        '
        Me.ucrReceiverForCalculation.frmParent = Nothing
        resources.ApplyResources(Me.ucrReceiverForCalculation, "ucrReceiverForCalculation")
        Me.ucrReceiverForCalculation.Name = "ucrReceiverForCalculation"
        Me.ucrReceiverForCalculation.Selector = Nothing
        Me.ucrReceiverForCalculation.strNcFilePath = ""
        Me.ucrReceiverForCalculation.ucrSelector = Nothing
        '
        'cmdMode
        '
        resources.ApplyResources(Me.cmdMode, "cmdMode")
        Me.cmdMode.Name = "cmdMode"
        Me.cmdMode.UseVisualStyleBackColor = True
        '
        'ucrCalculator
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpSummary)
        Me.Controls.Add(Me.grpProbabilty)
        Me.Controls.Add(Me.grpMaths)
        Me.Controls.Add(Me.grpTransform)
        Me.Controls.Add(Me.grpLogical)
        Me.Controls.Add(Me.grpStrings)
        Me.Controls.Add(Me.grpDates)
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
        Me.grpBasic.ResumeLayout(False)
        Me.grpDates.ResumeLayout(False)
        Me.grpTransform.ResumeLayout(False)
        Me.grpSummary.ResumeLayout(False)
        Me.grpStrings.ResumeLayout(False)
        Me.grpLogical.ResumeLayout(False)
        Me.grpProbabilty.ResumeLayout(False)
        Me.grpMaths.ResumeLayout(False)
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
    Friend WithEvents grpTransform As GroupBox
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
    Friend WithEvents cmdDelete As Button
    Friend WithEvents cmdClear As Button
    Friend WithEvents cmdMultiply As Button
    Friend WithEvents cmdpercentrank As Button
    Friend WithEvents cmdDiff As Button
    Friend WithEvents cmdEcdf As Button
    Friend WithEvents cmdmovemean As Button
    Friend WithEvents cmdCumMean As Button
    Friend WithEvents cmdNtile As Button
    Friend WithEvents cmMovMed As Button
    Friend WithEvents cmdMRank As Button
    Friend WithEvents cmdDRank As Button
    Friend WithEvents cmdMovMax As Button
    Friend WithEvents cmdMovSum As Button
    Friend WithEvents cmdAny As Button
    Friend WithEvents cmdAll As Button
    Friend WithEvents cmdIsTrue As Button
    Friend WithEvents cmdIsNa As Button
    Friend WithEvents cmdNotIsNa As Button
    Friend WithEvents cmdDuplicate As Button
    Friend WithEvents cmdIfelse As Button
    Friend WithEvents cmdmatch As Button
    Friend WithEvents cmdwhen As Button
    Friend WithEvents cmdNear As Button
    Friend WithEvents cmdBetween As Button
    Friend WithEvents cmdIsFalse As Button
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
End Class
