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

Public Class ucrCalculator
    Public iHelpCalcID As Integer
    Public Event NameChanged()
    Public Event SelectionChanged()
    Public Event SaveNameChanged()
    Public Event DataFrameChanged()
    Public Event TryCommadClick()
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsHelp As New RFunction
    Private iBasicWidth As Integer
    Private iBaseHeight As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitialiseControls()
        iBasicWidth = Me.Width
        iBaseHeight = Me.Height
    End Sub

    Private Sub ucrCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            If Not bControlsInitialised Then
                InitialiseControls()
            End If
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub

    Private Sub ReopenDialog()
        CalculationsOptions()
    End Sub

    Public Sub InitialiseControls()
        ucrInputCalOptions.SetItems({"Basic", "Maths", "Logical and Symbols", "Summary", "Strings (Character Columns)", "Factor", "Probability", "Dates", "Transform", "Wakefield", "Circular", "hydroGOF"}) ' "Rows" is a temp. name
        ucrInputCalOptions.SetDropDownStyleAsNonEditable()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations

        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        cmdDoy.Enabled = False ' temp
        cmdDek.Enabled = False ' temp
        'Temp disabled::Needs discussions to see if they are needed
        cmdAny.Enabled = False
        cmdAll.Enabled = False
        cmdIsTrue.Enabled = False
        cmdIsFalse.Enabled = False
        bControlsInitialised = True
        ttCalculator.SetToolTip(cmdRound, "round(x) to round to whole numbers, round(x,2) to round to 2 decimal places, round(x,-2) to round to the nearest 100")
        ttCalculator.SetToolTip(cmdSiginf, "signif(x,3) to round to 3 significant figures")

        ttCalculator.SetToolTip(cmdLag, "Shift a variable down. For example lag(1:5) = (NA,1,2,3,4); lag(1:5,3) = (NA,NA,NA, 1,2)")
        ttCalculator.SetToolTip(cmdLead, "Shift a variable up. For example lead(1:5) = (2,3,4,5,NA); lead(1:5;3) = (4,5, NA,NA,NA)")
        ttCalculator.SetToolTip(cmdDiff, "difference between successive elements. For example diff(c(1,4,3,7)) = (NA 3,-1,4)")
        ttCalculator.SetToolTip(cmdpmax, " maximum of a set of variables. For examples pmax(c(1,3,5),c(6,4,2)) = (6,4,5)")
        ttCalculator.SetToolTip(cmdPMin, "minimum of a set of variables. For examples pmin(c(1,3,5),c(6,4,2)) = (1,3,2)")
        ttCalculator.SetToolTip(cmdcummax, "cumulative maxima. For example cummax(c(3,2,1,4,0)) = (3,3,3,4,4)")
        ttCalculator.SetToolTip(cmdMovMax, "moving (or rolling) maxima. For example rollmax(x=c(3,2,1,4,0) ,3,fill=NA, align=""right"") = (NA,NA, 3,4,4)")
        ttCalculator.SetToolTip(cmdcumsum, "cumulative sums. For example cumsum(c(3,2,1,4,0)) = (3,5,6,10,10)")
        ttCalculator.SetToolTip(cmdCumMean, "cumulative means. For example cummean(c(3,2,1,4,0)) = (3,2.5,2,2.5,2)")
        ttCalculator.SetToolTip(cmdcummin, "cumulative minima. For example cummin(c(3,2,1,4,0)) = (3,2.,1,1,0)")
        ttCalculator.SetToolTip(cmdMovSum, "moving (or rolling) totals. For example rollsum(c(3,2,1,4,0) ,3,fill=NA, align=""left"") = (6,7,5,NA,NA)")
        ttCalculator.SetToolTip(cmdmovemean, "moving (or rolling) mean. For example rollmean(c(3,2,1,6,2) ,3,fill=NA) = (NA,2,3,3,NA)")
        ttCalculator.SetToolTip(cmMovMed, "moving (or rolling) medians. For example rollmedian(c(3,2,1,6,2) ,3,fill=NA) = (NA,2,2,2,NA)")
        ttCalculator.SetToolTip(cmdMovmin, "moving (or rolling) minima. For example rollapply(c(3,2,1,6,2),width=3,fill=NA, FUN=min) = (NA,1,1,1,NA)")
        ttCalculator.SetToolTip(cmdNtile, " Use ranks to divide into (almost) equal sized groups. For example ntile(c(15,11,13,12,NA,12),2) = (2,1,2,1,NA,1)")
        ttCalculator.SetToolTip(cmdCumdist, "Proportion of values less than or equal to the current rank. For example cume_dist(c(2,4,6,8,3)) = (0.2, 0.6, 0.8, 1.0, 0.4)")
        ttCalculator.SetToolTip(cmdRowRank, "row numbers as ranks. For example :row_number(c(15,11,13,12,NA,12)) = (5,1,3,2,NA,3)")
        ttCalculator.SetToolTip(cmdpercentrank, "rescale of minimum ranks to [0,1]. For example percent_rank(c(15,11,13,12,NA,12)) = (1,0,0.75,0.25,NA,0.25)")
        ttCalculator.SetToolTip(cmdDRank, "dense ranks. For example d_rank(c(15,11,13,12,NA,12)) = (4,1,3,2,NA,2)")
        ttCalculator.SetToolTip(cmdMRank, " minimum ranks. For example m_rank(c(15,11,13,12,NA,12)) = (5,1,4,2,NA,2)")
        ttCalculator.SetToolTip(cmdNafill, "fills missing values at the start, middle and end. For example na.fill(c(NA,2,NA,4,5,NA),fill=""extend"") = (2,2,3,4,5,5); while fill=c(15,""extend"",NA) = (15,2,3,4,5,NA)")
        ttCalculator.SetToolTip(cmdNaapprox, "linear interpolation of missing values. For example na.approx(c(5,NA,NA,2,2,NA,4,7,NA),maxgap=1,na.rm=FALSE) = (5,NA,NA,2,2,3,4,7,NA)")
        ttCalculator.SetToolTip(cmdNasplin, "Spline interpolation of missing values. For example na.spline(c(NA,NA,NA,2,2,NA,4,7,NA),maxgap=2,na.rm=FALSE) = (NA,NA,NA,2,2,2.5,4,7,12)")
        ttCalculator.SetToolTip(cmdNaest, "Missing values as the mean (usually) overall or with a factor. For example na.aggregate(c(NA,NA,NA,2,2,NA,4,7,NA),maxgap=2,na.rm=FALSE) = (NA,NA,NA,2,2,3.75,4,7,3.75)")


        ttCalculator.SetToolTip(cmdPower, "power(^)or exponent and can also be given as **. For example 2^3 = 8")
        ttCalculator.SetToolTip(cmdLesser, "less than(<). For example (2 < 3) is TRUE. (2 < 2) is FALSE, (2 < 1) is FALSE")
        ttCalculator.SetToolTip(cmdLesserOrEqualsTo, "less than or equals(<=). For example (2 <= 3) is TRUE, (2 <=2) is TRUE, (2 <= 1) is FALSE")
        ttCalculator.SetToolTip(cmdGreater, "greater than(>). For example (2 > 3) is FALSE, (2 > 2) is FALSE, (2 > 1) is TRUE")
        ttCalculator.SetToolTip(cmdGreaterOrEqualsTo, "greater or equals to(>=). For example (2 >= 3) is FALSE, (2 >=2) is TRUE, (2 >= 1) is TRUE")
        ttCalculator.SetToolTip(cmdEquivalent, "logical equals(==). For example (2 == 3) is FALSE, (2 == 2) is TRUE, (2 == 1) is FALSE")
        ttCalculator.SetToolTip(cmdNotEqualsTo, "not equals(!= )(opposite of ==). For example (2 != 3) is TRUE, (2 != 2) is FALSE and (2 != 1) is TRUE)")
        ttCalculator.SetToolTip(cmdOr, "logical OR(|). For example (2 < 3) | (2 < 1) is the same as (TRUE | FALSE) which is TRUE")
        ttCalculator.SetToolTip(cmdAnd, " logical AND(&). For example (2 < 3) & (2 < 1) is the same as (TRUE & FALSE) which is FALSE")
        ttCalculator.SetToolTip(cmdNot, "logical NOT(!). For example !(2 < 3) is FALSE, !(2 < 1) is TRUE")
        ttCalculator.SetToolTip(cmdColon, "colon is from:to(:). For example 3:6 is 3, 4, 5, 6. 6:3 is 6, 5, 4, 3 (It is the seq function with a step-length of 1 or -1.)")
        ttCalculator.SetToolTip(cmdModulas, "modulus operator(%%)gives the remainder after integer division. For example 7 %% 3 is 1, 12 %% 3 is 0")
        ttCalculator.SetToolTip(cmdIn, "(%in%)is like the match function and returns a logical vector. For example (11:15 %in% c(11,13)) gives TRUE, FALSE, TRUE, FALSE, FALSE")
        ttCalculator.SetToolTip(cmdmatch, "(see also %in%)gives the positions of the matching elements. For example match(11:15, c(11,13)) gives (1,NA, 2, NA, NA). match(11:15,c(11,13),nomatch=0) gives 1, 0, 2, 0, 0)")
        ttCalculator.SetToolTip(cmdIntegerDivision, "div operator(%/%)is for integer division. For example (7 %/% 3) is 2, (13 %/% 3) is 4")
        ttCalculator.SetToolTip(cmdwhen, "when is multiple ifelse, for example case_when(1:5>320,1:5>110) gives NA, 10, 10, 20, 20")
        ttCalculator.SetToolTip(cmdIfelse, "is what it says, for example ifelse((1:5 > 3,20,10) gives 10, 10, 10, 20, 20")
        ttCalculator.SetToolTip(cmdBetween, "between two values, for example between(1:5, 3,4) is FALSE, FALSE, TRUE, TRUE, FALSE")
        ttCalculator.SetToolTip(cmdIsNa, "is.na detects missing values, for example is.na(c(1,3,NA, 5)) gives FALSE, FALSE, TRUE, FALSE")
        ttCalculator.SetToolTip(cmdNotIsNa, "!is.na detects non-missing values, for example !is.na(c(1,3,NA, 5)) gives TRUE, TRUE, FALSE, TRUE")
        ttCalculator.SetToolTip(cmdDuplicate, "duplicate detects non-unique values, for example duplicated(c(1:3,2,7)) gives FALSE, FALSE, FALSE, TRUE, FALSE")
        ttCalculator.SetToolTip(cmdNear, "near(x,y)compares 2 variables. For example sqrt(5)^2 is almost, but isn't exactly 5, however near(sqrt(5)^2,5) is TRUE")
        ttCalculator.SetToolTip(cmdWhich, "which gives the indices of a logical variable. For example which(11:15>13) gives 4, 5. Note the result is usually not the same length as the original variable.")
        ttCalculator.SetToolTip(cmdAnyDup, "any Are any values TRUE in a logical variable. For example any(1:5 >3) gives TRUE")
        ttCalculator.SetToolTip(cmdAll, "all Are all values TRUE in a logical variable. For example all(1:5 >3) gives FALSE")
        ttCalculator.SetToolTip(cmdPnorm, "(normal probabilities. For example; pnorm(-1.6449) = 0.05; pnorm(130,100,15) = 0.9772.")
        ttCalculator.SetToolTip(cmdPt, " t probabilities. For example pt(-2,5) = 0.051; pt(-2,1000) = 0.0229 ~ pnorm(-2)")
        ttCalculator.SetToolTip(cmdPChisq, "chi square probabilities. For example pchisq(5,1) = 0.9747; pchisq(5,10) = 0.1088")

        ttCalculator.SetToolTip(cmdPf, "F probabilities. For example pf(2,1,10) = 0.8123; pf(2,50,50) = 0.9921")
        ttCalculator.SetToolTip(cmdQnorm, "qnormal quantiles. For example qnorm(0.05) = -1.6449; qnorm(0.9772, 100,15) = 130")
        ttCalculator.SetToolTip(cmdPbirth, "simultaneous birthday probabilities. For example pbirthday(10) = 0.1169 ; pbirthday(50) = 0.97")
        ttCalculator.SetToolTip(cmdQbirth, "simultaneous birthday quantiles. For example qbirthday(0.5) = 23, qbirthday(0.99) = 57")
        ttCalculator.SetToolTip(cmdPbinom, "binomial probabilities. For example pbinom(3,5,0.4) = 0.0.913")
        ttCalculator.SetToolTip(cmdQbinom, " binomial quantiles. For example qbinom(0.9,5,0.4) = 3")
        ttCalculator.SetToolTip(cmdPpois, "Poisson probabilities. For example ppois(8, 5) = 0.93")
        ttCalculator.SetToolTip(cmdQpois, "Poisson quantiles. For example qpois(0.9, 5) = 8")
        ttCalculator.SetToolTip(cmdPnbin, "negative binomial probabilities. For example pnbinom(4,1,0.4) = 0.922 (geometric); pnbinom(13,5,0.4) = 0.9058")
        ttCalculator.SetToolTip(cmdQnbin, "negative binomial quantiles. For example qnbinom(0.9,1,0.4) = 4 (geometric); qnbinom(0.9, 5,0.4) = 13")
        ttCalculator.SetToolTip(cmdFact, "factorial. For example factorial(4) = 4*3*2*1 = 24; factorial(3.5) = gamma(4.5) = 11.63")
        ttCalculator.SetToolTip(cmdLfact, "log factorial. For example lfactorial(400) = 2001")
        ttCalculator.SetToolTip(cmdChoose, "binomial coefficient. For example choose(7,4) = 7!/(4!*3!) = 35")
        ttCalculator.SetToolTip(cmdLchoose, "log binomial coefficient. For example lchoose(700,400) = 474.5")
        ttCalculator.SetToolTip(cmdBeta, "beta function. For example beta(6,2) = gamma(6)gamma(2)/gamma(8) = 0.02381")
        ttCalculator.SetToolTip(cmdLbeta, "log beta function. For example lbeta(100,40) = -84.51")
        ttCalculator.SetToolTip(cmdGamma, "gamma function. For example gamma(8) = fact(7) = 5040")
        ttCalculator.SetToolTip(cmdLgamma, " log gamma function. For example lgamma(800) = 4545")
        ttCalculator.SetToolTip(cmdDigamma, "digamma function. For example digamma(1) = -0.5772 (Euler's constant)")
        ttCalculator.SetToolTip(cmdTrigamma, "trigamma function. For example trigamma(1) = 1.645 (pi*pi/6)")
        ttCalculator.SetToolTip(cmdPbeta, "beta probabilities. For example pbeta(0.8,1,1) = 0.8 (Uniform); pbeta(0.8,10,10) = 0.9984")
        ttCalculator.SetToolTip(cmdQbeta, " beta quantiles. For example qbeta(0.2,1,1) = 0.2 (Uniform); qbeta(0.95,10,10) = 0.6799")
        ttCalculator.SetToolTip(cmdPgamma, "gamma probabilities. For example pgamma(2,1,1) = 0.8647; (Exponential) pgamma(2,10,10) = 0.995")
        ttCalculator.SetToolTip(cmdQgamma, "gamma quantiles. For example qgamma(0.95,1,1) = 2.995; qgamma( 0.95,10,10) = 1.571")
        ttCalculator.SetToolTip(cmdQchisq, "chi square quantiles. For example qchisq(0.95, 1) = 3.841; qchisq(0.95, 10) = 18.31")
        ttCalculator.SetToolTip(cmdQt, "t quantiles. For example qt(0.05, 5) = -2.015; qt(0.05, 100) = -1.66")
        ttCalculator.SetToolTip(cmdqF, "F quantiles. For example qf(0.95,1,10) = 4.965; qf(0.95, 50,50)= 1.599")

        ttCalculator.SetToolTip(cmdSqrt, "square root. For example sqrt(3) = 3 ^ 0.5 = 1.732")
        ttCalculator.SetToolTip(cmdCos, "cosine of angle in radians. For example cos(pi) = -1, cos(rad(90)) = (almost) 0.")
        ttCalculator.SetToolTip(cmdAcos, "angle corresponding to a given cosine (in the range 0 to pi). For example acos(0) = 1.57 = pi/2; deg(acos(-1))=180.")
        ttCalculator.SetToolTip(cmdCeiling, " Integer above the given value. For example ceiling(3.5) = 4; ceiling(-3.5) = -3")
        ttCalculator.SetToolTip(cmdPi, "pi = 3.14159")
        ttCalculator.SetToolTip(cmdLog, "(natural) logarithm. For example log(512) = 6.238; log(512,2) = 9 (log to base 2, i.e. 2 ^ 9 =512)")
        ttCalculator.SetToolTip(cmdSin, "sine of angle in radians. For example sin(pi/2) = sin(rad(90)) = 1.")
        ttCalculator.SetToolTip(cmdAsin, "angle corresponding to a given sine (in the range (0 to pi). For example asin(1) = 1.57 = pi/2.")
        ttCalculator.SetToolTip(cmdFloor, "integer below the given value. For example floor(3.5)=3; floor(-3.5) = -4.")
        ttCalculator.SetToolTip(cmdRad, "change from degrees to radians. For example rad(90) = 2*pi * 90/360 = 1.57 ( = pi/2)")
        ttCalculator.SetToolTip(cmdLogTen, "logarithm to base 10. For example log10(1000) =3 (=10^3)")
        ttCalculator.SetToolTip(cmdTan, " tangent of angle in radians. For example tan(pi/4) = sin(pi/4)/cos(pi/4) = tan(rad(45)) = 1")
        ttCalculator.SetToolTip(cmdAtan, "angle corresponding to a given tangent (in the range 0 to pi). For example atan(1) = 0..7854 (= pi/4); deg(atan(1)) = 45.")

    End Sub

    Public Sub Reset()
        ucrReceiverForCalculation.ResetText()
        ucrInputCalOptions.Reset()
        ucrSaveResultInto.Reset()
        ucrSelectorForCalculations.Reset()
        clsHelp.ClearParameters()
    End Sub
    Public Sub SetCalculationHistory()
        ucrReceiverForCalculation.AddtoCombobox(ucrReceiverForCalculation.GetText)
    End Sub

    Private Sub cmd0_Click(sender As Object, e As EventArgs) Handles cmd0.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("0")
    End Sub

    Private Sub cmd1_Click(sender As Object, e As EventArgs) Handles cmd1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("1")
    End Sub

    Private Sub cmd2_Click(sender As Object, e As EventArgs) Handles cmd2.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("2")
    End Sub

    Private Sub cmd3_Click(sender As Object, e As EventArgs) Handles cmd3.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("3")
    End Sub

    Private Sub cmd4_Click(sender As Object, e As EventArgs) Handles cmd4.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("4")
    End Sub

    Private Sub cmd5_Click(sender As Object, e As EventArgs) Handles cmd5.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("5")
    End Sub

    Private Sub cmd6_Click(sender As Object, e As EventArgs) Handles cmd6.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("6")
    End Sub

    Private Sub cmd7_Click(sender As Object, e As EventArgs) Handles cmd7.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("7")
    End Sub

    Private Sub cmd8_Click(sender As Object, e As EventArgs) Handles cmd8.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("8")
    End Sub

    Private Sub cmd9_Click(sender As Object, e As EventArgs) Handles cmd9.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("9")
    End Sub

    Private Sub cmdDot_Click(sender As Object, e As EventArgs) Handles cmdDot.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(".")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdGreater_Click(sender As Object, e As EventArgs) Handles cmdGreater.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" > ")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForCalculation.Clear()
    End Sub

    Private Sub cmdLesser_Click(sender As Object, e As EventArgs) Handles cmdLesser.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" < ")
    End Sub
    Private Sub cmdComma_Click(sender As Object, e As EventArgs) Handles cmdComma.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(",")
    End Sub

    Private Sub cmdPi_Click(sender As Object, e As EventArgs) Handles cmdPi.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pi")
    End Sub

    Private Sub cmdCeiling_Click(sender As Object, e As EventArgs) Handles cmdCeiling.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ceiling(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ceiling( )", 1)
        End If
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrInputCalOptions.NameChanged
        CalculationsOptions()
        RaiseEvent NameChanged()
    End Sub

    Private Sub CalculationsOptions()
        Select Case ucrInputCalOptions.GetText
            Case "Maths"
                grpSummary.Visible = False
                grpMaths.Visible = True
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                iHelpCalcID = 126
                Me.Size = New Size(iBasicWidth * 1.38, iBaseHeight)
            Case "Logical and Symbols"
                grpDates.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = True
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpHydroGOF.Visible = False
                iHelpCalcID = 127
                Me.Size = New Size(iBasicWidth * 1.44, iBaseHeight)
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
            Case "Summary"
                grpDates.Visible = False
                grpSummary.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                iHelpCalcID = 128
                Me.Size = New Size(iBasicWidth * 1.51, iBaseHeight)
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
            Case "Strings (Character Columns)"
                grpDates.Visible = False
                grpStrings.Visible = True
                grpFactor.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = True
                grpSymbols.Visible = True
                grpHydroGOF.Visible = False
                iHelpCalcID = 129
                Me.Size = New Size(iBasicWidth * 1.42, iBaseHeight)
            Case "Factor"
                grpFactor.Visible = True
                grpDates.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                iHelpCalcID = 127
                Me.Size = New Size(iBasicWidth * 1.44, iBaseHeight)
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
            Case "Probability"
                grpDates.Visible = False
                grpProbabilty.Visible = True
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                iHelpCalcID = 120
                Me.Size = New Size(iBasicWidth * 1.57, iBaseHeight)
            Case "Dates"
                grpDates.Visible = True
                grpProbabilty.Visible = False
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                iHelpCalcID = 130
                Me.Size = New Size(iBasicWidth * 1.32, iBaseHeight)
            Case "Transform"
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = True
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                Me.Size = New Size(iBasicWidth * 1.33, iBaseHeight)
            Case "Wakefield"
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = True
                grpSymbols.Visible = False
                grpModifier.Visible = False
                grpHydroGOF.Visible = False
                Me.Size = New Size(iBasicWidth * 1.7, iBaseHeight)
            Case "Circular"
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
                grpCircular.Visible = True
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                Me.Size = New Size(iBasicWidth * 1.39, iBaseHeight)
            Case "hydroGOF"
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpHydroGOF.Visible = True
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
                grpCircular.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                Me.Size = New Size(iBasicWidth * 1.27, iBaseHeight)
            Case Else
                grpDates.Visible = False
                Me.Size = New Size(iBasicWidth, iBaseHeight)
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpTransform.Visible = False
                grpStrings.Visible = False
                grpFactor.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpSymbols.Visible = False
                grpModifier.Visible = False
                grpHydroGOF.Visible = False
                iHelpCalcID = 14
        End Select
    End Sub

    Private Sub cmdRound_Click(sender As Object, e As EventArgs) Handles cmdRound.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round(x= , digits=0)", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round()", 1)
        End If
    End Sub

    Private Sub cmdFloor_Click(sender As Object, e As EventArgs) Handles cmdFloor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("floor(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("floor()", 1)
        End If
    End Sub

    Private Sub cmdTrunc_Click(sender As Object, e As EventArgs) Handles cmdTrunc.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trunc(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trunc()", 1)
        End If
    End Sub

    Private Sub cmdSign_Click(sender As Object, e As EventArgs) Handles cmdSign.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sign(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sign()", 1)
        End If
    End Sub

    Private Sub cmdAcos_Click(sender As Object, e As EventArgs) Handles cmdAcos.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos()", 1)
        End If

    End Sub

    Private Sub cmdAsin_Click(sender As Object, e As EventArgs) Handles cmdAsin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin()", 1)
        End If
    End Sub

    Private Sub cmdAtan_Click(sender As Object, e As EventArgs) Handles cmdAtan.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan()", 1)
        End If
    End Sub

    Private Sub cmdSiginf_Click(sender As Object, e As EventArgs) Handles cmdSiginf.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif(x= , digits=6)", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif()", 1)
        End If
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos()", 1)
        End If
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin()", 1)
        End If
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan()", 1)
        End If
    End Sub

    Private Sub cmdAbs_Click(sender As Object, e As EventArgs) Handles cmdAbs.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("abs(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("abs()", 1)
        End If
    End Sub

    Private Sub cmdExp_Click_1(sender As Object, e As EventArgs) Handles cmdExp.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp()", 1)
        End If
    End Sub

    Private Sub cmdLogTen_Click(sender As Object, e As EventArgs) Handles cmdLogTen.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log10(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log10()", 1)
        End If
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log(x= , base=exp(1))", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log()", 1)
        End If
    End Sub

    Private Sub cmdSqrt_Click_1(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sqrt(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sqrt()", 1)
        End If
    End Sub

    Private Sub cmdEquivalent_Click(sender As Object, e As EventArgs) Handles cmdEquivalent.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" == ")
    End Sub

    Private Sub cmdNotEqualsTo_Click(sender As Object, e As EventArgs) Handles cmdNotEqualsTo.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" != ")
    End Sub

    Private Sub cmdNot_Click(sender As Object, e As EventArgs) Handles cmdNot.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("!")
    End Sub

    Private Sub cmdOr_Click(sender As Object, e As EventArgs) Handles cmdOr.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" | ")
    End Sub

    Private Sub cmdLesserOrEqualsTo_Click(sender As Object, e As EventArgs) Handles cmdLesserOrEqualsTo.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" <= ")
    End Sub

    Private Sub cmdGreaterOrEqualsTo_Click(sender As Object, e As EventArgs) Handles cmdGreaterOrEqualsTo.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" >= ")
    End Sub

    Private Sub cmdModulas_Click(sender As Object, e As EventArgs) Handles cmdModulas.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" %% ")
    End Sub

    Private Sub cmdIntegerDivision_Click(sender As Object, e As EventArgs) Handles cmdIntegerDivision.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" %/% ")
    End Sub

    Private Sub cmdAnd_Click(sender As Object, e As EventArgs) Handles cmdAnd.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" & ")
    End Sub

    Private Sub cmdLength_Click(sender As Object, e As EventArgs) Handles cmdLength.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length()", 1)
        End If
    End Sub

    Private Sub cmdMiss_Click(sender As Object, e As EventArgs) Handles cmdMiss.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na(x= ))", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na())", 2)
        End If
    End Sub

    Private Sub cmdSum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum()", 1)
        End If
    End Sub

    Private Sub cmdMean_Click(sender As Object, e As EventArgs) Handles cmdMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x = , trim = 0 , na.rm = FALSE)", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean()", 1)
        End If
    End Sub

    Private Sub cmdMax_Click(sender As Object, e As EventArgs) Handles cmdMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max()", 1)
        End If
    End Sub

    Private Sub cmdMin_Click(sender As Object, e As EventArgs) Handles cmdMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min()", 1)
        End If
    End Sub

    Private Sub cmdMedian_Click(sender As Object, e As EventArgs) Handles cmdMedian.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median()", 1)
        End If
    End Sub

    Private Sub cmdVar_Click(sender As Object, e As EventArgs) Handles cmdVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var(x = , y = NULL, na.rm = FALSE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var()", 1)
        End If
    End Sub

    Private Sub cmdSd_Click(sender As Object, e As EventArgs) Handles cmdSd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd()", 1)
        End If
    End Sub

    Private Sub cmdRange_Click(sender As Object, e As EventArgs) Handles cmdRange.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range(x = , na.rm = FALSE, finite = FALSE)", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range()", 1)
        End If
    End Sub

    Private Sub cmdQuantile_Click(sender As Object, e As EventArgs) Handles cmdQuantile.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile(x = , probs = 0.5, na.rm = FALSE, names = FALSE, type=7)", 53)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile()", 1)
        End If
    End Sub

    Private Sub cmdIQR_Click(sender As Object, e As EventArgs) Handles cmdIQR.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR(x = , na.rm = FALSE, type = 7)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR()", 1)
        End If
    End Sub

    Private Sub cmdUpper_Click(sender As Object, e As EventArgs) Handles cmdUpper.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_upper(string = , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_upper()", 1)
        End If
    End Sub

    Private Sub cmdLower_Click(sender As Object, e As EventArgs) Handles cmdLower.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_lower(string= , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_lower()", 1)
        End If
    End Sub

    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_title(string= , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_title()", 1)
        End If
    End Sub

    Private Sub cmdTrim_Click(sender As Object, e As EventArgs) Handles cmdTrim.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trim(string= , side = c('both', 'left', 'right))", 35)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trim()", 1)
        End If
    End Sub

    Private Sub cmdPad_Click(sender As Object, e As EventArgs) Handles cmdPad.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad(string= , width= , side = c('left', 'right', 'both'), pad= )", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad()", 1)
        End If
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order(x= , decreasing = FALSE, na_last = TRUE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order()", 1)
        End If
    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort(x= , decreasing = FALSE, na_last = TRUE, locale = ' ')", 51)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort()", 1)
        End If
    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace(string = , pattern = argument , replacement = ' ' )", 43)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace()", 1)
        End If
    End Sub

    Private Sub cmdLocate_Click(sender As Object, e As EventArgs) Handles cmdLocate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate(string = , pattern = argument)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate()", 1)
        End If
    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract(string = , pattern = argument )", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract()", 1)
        End If
    End Sub

    Private Sub cmdCountstrings_Click(sender As Object, e As EventArgs) Handles cmdCountstrings.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_count(string = , pattern = argument )", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_count()", 1)
        End If

    End Sub

    Private Sub cmdDetect_Click(sender As Object, e As EventArgs) Handles cmdDetect.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect(string = , pattern = argument)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect()", 1)
        End If
    End Sub

    Private Sub cmdQnorm_Click(sender As Object, e As EventArgs) Handles cmdQnorm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm(p= , mean = 0, sd = 1, lower.tail = TRUE, log.p = FALSE)", 53)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm()", 1)
        End If
    End Sub

    Private Sub cmdQt_Click(sender As Object, e As EventArgs) Handles cmdQt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt(p= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt()", 1)
        End If
    End Sub

    Private Sub cmdQchisq_Click(sender As Object, e As EventArgs) Handles cmdQchisq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq(p= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq()", 1)
        End If
    End Sub

    Private Sub cmdqF_Click(sender As Object, e As EventArgs) Handles cmdqF.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf(p= , df1= , df2= ,lower.tail = TRUE)", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf()", 1)
        End If
    End Sub

    Private Sub cmdPnorm_Click(sender As Object, e As EventArgs) Handles cmdPnorm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnorm(q= , mean = 0, sd = 1, lower.tail = True, Log.p = False)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnorm()", 1)
        End If
    End Sub

    Private Sub cmdPt_Click(sender As Object, e As EventArgs) Handles cmdPt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt(q= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt()", 1)
        End If
    End Sub

    Private Sub cmdPChisq_Click(sender As Object, e As EventArgs) Handles cmdPChisq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt()", 1)
        End If
    End Sub

    Private Sub cmdPf_Click(sender As Object, e As EventArgs) Handles cmdPf.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq()", 1)
        End If
    End Sub

    Private Sub cmdChoose_Click(sender As Object, e As EventArgs) Handles cmdChoose.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("choose(n= , k= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("choose()", 1)
        End If
    End Sub

    Private Sub cmdFact_Click(sender As Object, e As EventArgs) Handles cmdFact.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("factorial(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("factorial()", 1)
        End If
    End Sub

    Private Sub cmdBeta_Click(sender As Object, e As EventArgs) Handles cmdBeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("beta(a= , b= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("beta()", 1)
        End If
    End Sub

    Private Sub cmdLchoose_Click(sender As Object, e As EventArgs) Handles cmdLchoose.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lchoose(n= , k= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lchoose()", 1)
        End If
    End Sub

    Private Sub cmdLfact_Click(sender As Object, e As EventArgs) Handles cmdLfact.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lfactorial(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lfactorial()", 1)
        End If
    End Sub

    Private Sub cmdLbeta_Click(sender As Object, e As EventArgs) Handles cmdLbeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lbeta(a= , b= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lbeta()", 1)
        End If
    End Sub

    Private Sub cmdGamma_Click(sender As Object, e As EventArgs) Handles cmdGamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gamma()", 1)
        End If
    End Sub

    Private Sub cmdLgamma_Click(sender As Object, e As EventArgs) Handles cmdLgamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lgamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lgamma()", 1)
        End If
    End Sub

    Private Sub cmdDigamma_Click(sender As Object, e As EventArgs) Handles cmdDigamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digamma()", 1)
        End If
    End Sub

    Private Sub cmdTrigamma_Click(sender As Object, e As EventArgs) Handles cmdTrigamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trigamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trigamma()", 1)
        End If
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrSelectorForCalculations.DataFrameChanged
        ucrTryCalculator.ucrInputTryMessage.SetName("")
        RaiseEvent DataFrameChanged()
    End Sub

    Private Sub cmdCombine_Click(sender As Object, e As EventArgs) Handles cmdCombine.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_c(string= , pattern=' ')", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_c()", 1)
        End If
    End Sub

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSplit.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_split(string = , pattern = argument, n = )", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_split()", 1)
        End If
    End Sub

    Private Sub cmdYear_Click(sender As Object, e As EventArgs) Handles cmdYear.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::year(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::year()", 1)
        End If
    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs) Handles cmdMonth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::month(x= , label=FALSE, abbr=TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::month()", 1)
        End If
    End Sub

    Private Sub cmdDay_Click(sender As Object, e As EventArgs) Handles cmdDay.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::day(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::day()", 1)
        End If
    End Sub

    Private Sub cmdWday_Click(sender As Object, e As EventArgs) Handles cmdWday.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::wday(x= , label=FALSE, abbr=TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::wday()", 1)
        End If
    End Sub

    Private Sub cmdYday_Click(sender As Object, e As EventArgs) Handles cmdYday.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::yday(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::yday()", 1)
        End If
    End Sub

    Private Sub cmdDate_Click(sender As Object, e As EventArgs) Handles cmdDate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::date(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::date()", 1)
        End If
    End Sub

    Private Sub cmdLeap_Click(sender As Object, e As EventArgs) Handles cmdLeap.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::leap_year(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::leap_year()", 1)
        End If
    End Sub

    Private Sub cmdYmd_Click(sender As Object, e As EventArgs) Handles cmdYmd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd()", 1)
        End If
    End Sub

    Private Sub cmdMdy_Click(sender As Object, e As EventArgs) Handles cmdMdy.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::mdy(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::mdy()", 1)
        End If
    End Sub
    Private Sub cmdDmy_Click(sender As Object, e As EventArgs) Handles cmdDmy.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::dmy(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::dmy()", 1)
        End If
    End Sub


    Private Sub cmdHour_Click(sender As Object, e As EventArgs) Handles cmdHour.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::hour(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::hour()", 1)
        End If
    End Sub
    Private Sub cmdMinutes_Click(sender As Object, e As EventArgs) Handles cmdminutes.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::min(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::min()", 1)
        End If
    End Sub
    Private Sub cmdSec_Click(sender As Object, e As EventArgs) Handles cmdSec.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::sec(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::sec()", 1)
        End If
    End Sub
    Private Sub cmdAm_Click(sender As Object, e As EventArgs) Handles cmdAm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::am(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::am()", 1)
        End If
    End Sub
    Private Sub cmdD_In_M_Click(sender As Object, e As EventArgs) Handles cmdD_In_M.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::d_in_m(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::d_in_m()", 1)
        End If
    End Sub
    Private Sub cmdQuarter_Click(sender As Object, e As EventArgs) Handles cmdQuarter.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::quarter(x =, with_year = FALSE, fiscal_start = 1 )", 39)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::quarter()", 1)
        End If
    End Sub

    Private Sub cmdDoy_Click(sender As Object, e As EventArgs) Handles cmdDoy.Click

    End Sub

    Private Sub cmdDek_Click(sender As Object, e As EventArgs) Handles cmdDek.Click

    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("( )", 1)
    End Sub
    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdClossingBracket_Click(sender As Object, e As EventArgs) Handles cmdClossingBracket.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdSquareBrackets_Click(sender As Object, e As EventArgs) Handles cmdSquareBrackets.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("[ ]", 2)
    End Sub

    Private Sub cmdQuotes_Click(sender As Object, e As EventArgs) Handles cmdQuotes.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(Chr(34) & "" & Chr(34), 1)
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" : ")
    End Sub

    Private Sub cmdLag_Click(sender As Object, e As EventArgs) Handles cmdLag.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lag(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lag()", 1)
        End If
    End Sub

    Private Sub cmdLead_Click(sender As Object, e As EventArgs) Handles cmdLead.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lead(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lead()", 1)
        End If
    End Sub

    Private Sub cmdpmax_Click(sender As Object, e As EventArgs) Handles cmdpmax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmax(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmax()", 1)
        End If
    End Sub

    Private Sub cmdPMin_Click(sender As Object, e As EventArgs) Handles cmdPMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmin()", 1)
        End If
    End Sub

    Private Sub cmdcummax_Click(sender As Object, e As EventArgs) Handles cmdcummax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax()", 1)
        End If
    End Sub

    Private Sub cmdcummin_Click(sender As Object, e As EventArgs) Handles cmdcummin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin()", 1)
        End If
    End Sub

    Private Sub cmdcumsum_Click(sender As Object, e As EventArgs) Handles cmdcumsum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum()", 1)
        End If
    End Sub

    Private Sub cmdpercentrank_Click(sender As Object, e As EventArgs) Handles cmdpercentrank.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank()", 1)
        End If
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        RaiseEvent SelectionChanged()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        HelpContent()
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs)
        RaiseEvent TryCommadClick()
    End Sub

    Private Sub HelpContent()

        If ucrInputCalOptions.GetText = "hydroGOF" Then
            clsHelp.AddParameter("package", Chr(34) & "hydroGOF" & Chr(34), iPosition:=1)
            frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Code generated to view help for hydroGOF package")
        Else
            If iHelpCalcID > 0 Then
                Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpCalcID.ToString())
            Else
                Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
            End If

        End If
    End Sub

    Public Sub SetAsCurrentReceiver()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
    End Sub

    Private Sub cmdDiff_Click(sender As Object, e As EventArgs) Handles cmdDiff.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(NA, diff(x= , lag = 1, differences = 1))", 29)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(NA,diff())", 2)
        End If
    End Sub

    Private Sub cmdEcdf_Click(sender As Object, e As EventArgs) Handles cmdCumdist.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cume_dist()", 1)
    End Sub

    Private Sub cmdNtile_Click(sender As Object, e As EventArgs) Handles cmdNtile.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::ntile(x= , n=2)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::ntile()", 1)
        End If
    End Sub

    Private Sub cmdMovMax_Click(sender As Object, e As EventArgs) Handles cmdMovMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmax(x = , k =3, fill = NA, na.pad = FALSE, align = c(""center"", ""left"", ""right""))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmax( ,k = 3, fill = NA)", 19)
        End If
    End Sub

    Private Sub cmdMovSum_Click(sender As Object, e As EventArgs) Handles cmdMovSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollsum(x = , k=3, fill = NA, na.pad = FALSE, align = c(""center"", ""left"", ""right""))", 72)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollsum( ,k = 3, fill = NA)", 19)
        End If
    End Sub

    Private Sub cmMovMed_Click(sender As Object, e As EventArgs) Handles cmMovMed.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmedian(x = , k = 3, fill = NA, na.pad = FALSE, align = c(""center"", ""left"", ""right""))", 74)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmedian( ,k = 3, fill = NA)", 19)
        End If
    End Sub

    Private Sub cmdMRank_Click(sender As Object, e As EventArgs) Handles cmdMRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::min_rank()", 1)
    End Sub

    Private Sub cmdmovemean_Click(sender As Object, e As EventArgs) Handles cmdmovemean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmean(x = , k=3, fill = NA, na.pad = FALSE, align = c(""center"", ""left"", ""right""))", 72)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmean( ,k = 3, fill = NA)", 19)
        End If
    End Sub

    Private Sub cmdCumMean_Click(sender As Object, e As EventArgs) Handles cmdCumMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cummean(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cummean()", 1)
        End If
    End Sub

    Private Sub cmdDRank_Click(sender As Object, e As EventArgs) Handles cmdDRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::dense_rank()", 1)
    End Sub

    Private Sub cmdRowRank_Click(sender As Object, e As EventArgs) Handles cmdRowRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::row_number()", 1)
    End Sub

    Private Sub cmdIfelse_Click(sender As Object, e As EventArgs) Handles cmdIfelse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ifelse(test= , ""yes"" , ""no"")", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ifelse()", 1)
        End If
    End Sub

    Private Sub cmdmatch_Click(sender As Object, e As EventArgs) Handles cmdmatch.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("match()", 1)
    End Sub

    Private Sub cmdwhen_Click(sender As Object, e As EventArgs) Handles cmdwhen.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::case_when()", 1)
    End Sub

    Private Sub cmdBetween_Click(sender As Object, e As EventArgs) Handles cmdBetween.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::between()", 1)
    End Sub

    Private Sub cmdNear_Click(sender As Object, e As EventArgs) Handles cmdNear.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::near(x= , y= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::near()", 1)
        End If
    End Sub
    Private Sub cmdLogit_Click(sender As Object, e As EventArgs) Handles cmdLogit.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("car::logit(p, percents = Range.p[2] > 1, adjust)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("car::logit()", 1)
        End If
    End Sub
    Private Sub cmdLogistic_Click(sender As Object, e As EventArgs) Handles cmdLogistic.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::plogis(q, Location = 0, Scale() = 1, lower.tail = True, Log.p = False))", 50)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::plogis()", 1)
        End If
    End Sub
    Private Sub cmdAtan2_Click(sender As Object, e As EventArgs) Handles cmdAtan2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan2(y = , x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan2()", 1)
        End If
    End Sub

    Private Sub cmdDuplicate_Click(sender As Object, e As EventArgs) Handles cmdDuplicate.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("duplicated()", 1)
    End Sub

    Private Sub cmdIsNa_Click(sender As Object, e As EventArgs) Handles cmdIsNa.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("is.na()", 1)
    End Sub

    Private Sub cmdNotIsNa_Click(sender As Object, e As EventArgs) Handles cmdNotIsNa.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("!is.na()", 1)
    End Sub

    Private Sub cmdCv_Click(sender As Object, e As EventArgs) Handles cmdCv.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("raster::cv(x = , aszero = FALSE, na.rm = FALSE)", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("raster::cv()", 1)
        End If
    End Sub

    Private Sub cmdMad_Click(sender As Object, e As EventArgs) Handles cmdMad.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::mad(x = , center = median(x), constant = 1.4826, na.rm = FALSE,low = FALSE, high = FALSE)", 82)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::mad()", 1)
        End If
    End Sub

    Private Sub cmdMc_Click(sender As Object, e As EventArgs) Handles cmdMc.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("robustbase::mc(x =, na.rm = FALSE, doReflect = (length(x) <= 100),doScale = TRUE, maxit = 100, trace.lev = 0, full.result = FALSE)", 112)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("robustbase::mc()", 1)
        End If
    End Sub

    Private Sub cmdNonMiss_Click(sender As Object, e As EventArgs) Handles cmdNonMiss.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(!is.na(x= ))", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(!is.na())", 2)
        End If
    End Sub

    Private Sub cmdSkew_Click(sender As Object, e As EventArgs) Handles cmdSkew.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::skewness(x = , na.rm = FALSE, type = 3)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::skewness()", 1)
        End If
    End Sub

    Private Sub cmdPropn_Click(sender As Object, e As EventArgs) Handles cmdPropn.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x= <=1, na.rm = TRUE)", 18)
    End Sub

    Private Sub cmdDistinct_Click(sender As Object, e As EventArgs) Handles cmdDistinct.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::n_distinct()", 1)
    End Sub

    Private Sub cmdAnyDup_Click(sender As Object, e As EventArgs) Handles cmdAnyDup.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("anyDuplicated()", 1)
    End Sub

    Private Sub cmdCor_Click(sender As Object, e As EventArgs) Handles cmdCor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cor(x= , y= , use = ""everything"", method = c(""pearson"", ""kendall"", ""spearman""))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cor(x = , y = )", 8)
        End If
    End Sub

    Private Sub cmdCov_Click(sender As Object, e As EventArgs) Handles cmdCov.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cov(x= , y= , use = ""everything"", method = c(""pearson"", ""kendall"", ""spearman""))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cov(x = , y = )", 8)
        End If
    End Sub

    Private Sub cmdRad_Click(sender As Object, e As EventArgs) Handles cmdRad.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rad()", 1)
    End Sub

    Private Sub cmdDeg_Click(sender As Object, e As EventArgs) Handles cmdDeg.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::deg()", 1)
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::first(x= , order_by=NULL)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::first()", 1)
        End If
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::last(x= , order_by=NULL)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::last()", 1)
        End If
    End Sub

    Private Sub cmdnth_Click(sender As Object, e As EventArgs) Handles cmdnth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::nth(x= , n= , order_by=NULL)", 21)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::nth()", 1)
        End If
    End Sub

    Private Sub cmdMode_Click(sender As Object, e As EventArgs) Handles cmdMode.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv(x = , na_rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv()", 1)
        End If
    End Sub

    Private Sub cmdNA_Click(sender As Object, e As EventArgs) Handles cmdNA.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("NA")
    End Sub

    Private Sub cmdWhich_Click(sender As Object, e As EventArgs) Handles cmdWhich.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which(x= , arr.ind = FALSE, useNames = TRUE)", 35)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which()", 1)
        End If
    End Sub

    Private Sub cmdIn_Click(sender As Object, e As EventArgs) Handles cmdIn.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" %in% ")
    End Sub

    Private Sub cmdDoubleSqrBrackets_Click(sender As Object, e As EventArgs) Handles cmdDoubleSqrBrackets.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("[[]]", 2)
    End Sub

    Private Sub cmdTrue_Click(sender As Object, e As EventArgs) Handles cmdTrue.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("TRUE")
    End Sub

    Private Sub cmdFalse_Click(sender As Object, e As EventArgs) Handles cmdFalse.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("FALSE")
    End Sub

    Private Sub cmdAge_Click(sender As Object, e As EventArgs) Handles cmdAge.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::age(n = , x = 20:35 , prob = NULL, name = ""Age"")", 40)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::age()", 1)
        End If
    End Sub

    Private Sub cmdAnimal_Click(sender As Object, e As EventArgs) Handles cmdAnimal.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::animal(n = , k =10 , x = wakefield::animal_list, prob = NULL, name = ""Animal"")", 68)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::animal()", 1)
        End If
    End Sub

    Private Sub cmdPet_Click(sender As Object, e As EventArgs) Handles cmdPet.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::pet(n = , x = c(""Dog"" , ""Cat"" , ""None"" , ""Bird"" , ""Horse"") , prob = c(0.365 , 0.304, 0.258 , 0.031 , 0.015) , name = ""Pet"")", 118)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::pet()", 1)
        End If
    End Sub

    Private Sub cmdAnswer_Click(sender As Object, e As EventArgs) Handles cmdAnswer.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::answer(n = , x = c(""No"" , ""Yes""), prob = NULL , name = ""Answer"")", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::answer()", 1)
        End If
    End Sub

    Private Sub cmdCar_Click(sender As Object, e As EventArgs) Handles cmdCar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::car(n = , x = rownames(datasets::mtcars), prob = NULL, name = ""Car"")", 61)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::car()", 1)
        End If
    End Sub

    Private Sub cmdChildren_Click(sender As Object, e As EventArgs) Handles cmdChildren.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::children(n = , x = 0:10, prob = c(0.25, 0.25, 0.15, 0.15, 0.1, 0.02, 0.02,0.02, 0.02, 0.01, 0.01), name = ""Children"")", 105)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::children()", 1)
        End If
    End Sub

    Private Sub cmdCoin_Click(sender As Object, e As EventArgs) Handles cmdCoin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::coin(""Tails"" , ""Heads"") , prob = NULL , name = ""Coin"")", 49)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::coin()", 1)
        End If
    End Sub

    Private Sub cmdColor_Click(sender As Object, e As EventArgs) Handles cmdColor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::color(n = , x = c(""Red"" , ""Green"" , ""Blue"" , ""Yellow"" , ""Black"" , ""White"") , prob = NULL, name = ""Color"")", 96)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::color()", 1)
        End If
    End Sub

    Private Sub cmdPrimary_Click(sender As Object, e As EventArgs) Handles cmdPrimary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::primary(n = ,  x = c(""Red"" , ""Green"" , ""Blue"" , ""Yellow"" , ""Black"" , ""White"") , prob = NULL, name = ""Color"")", 96)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield:: primary()", 1)
        End If
    End Sub

    Private Sub cmdDate_Stamp_Click(sender As Object, e As EventArgs) Handles cmdDate_Stamp.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::date_stamp(n = , random = FALSE , x = NULL , start = Sys.Date() , k = 12 , by = "" - 1 months"" , prob = NULL , name =  ""Date"")", 111)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::date_stamp()", 1)
        End If
    End Sub

    Private Sub cmdDeath_Click(sender As Object, e As EventArgs) Handles cmdDeath.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::death(n = , prob = NULL, name = ""Death"")", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::death()", 1)
        End If
    End Sub

    Private Sub cmdDied_Click(sender As Object, e As EventArgs) Handles cmdDied.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::died(n = , prob = NULL , name = ""Died"")", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::died()", 1)
        End If
    End Sub

    Private Sub cmdDice_Click(sender As Object, e As EventArgs) Handles cmdDice.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dice(n = , x = 1:6 , prob = NULL , name = ""Dice"")", 41)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dice()", 1)
        End If
    End Sub

    Private Sub cmdDna_Click(sender As Object, e As EventArgs) Handles cmdDna.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dna(n = , x = c(""Guanine"", ""Adenine"", ""Thymine"", ""Cytosine""), prob = NULL , name = ""DNA"")", 82)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dna()", 1)
        End If
    End Sub

    Private Sub cmdDob_Click(sender As Object, e As EventArgs) Handles cmdDob.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dob(n = , random = TRUE , x = NULL , start = Sys.Date() - 365 * 15 , k = 365 *2 , by = ""1 days"" , prob = NULL , name = ""DOB"")", 118)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dob()", 1)
        End If
    End Sub

    Private Sub cmdDummy_Click(sender As Object, e As EventArgs) Handles cmdDummy.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dummy(n = , prob = NULL, name = ""Dummy"")", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dummy()", 1)
        End If
    End Sub

    Private Sub cmdEducation_Click(sender As Object, e As EventArgs) Handles cmdEducation.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield:: education(n = , x = c(""No Schooling Completed"" , ""Nursery School To 8th Grade"" , ""9th Grade To 12th Grade, No Diploma"" , ""Regular High School Diploma"" , ""GED Or Alternative Credential"" , ""Some College , Less than 1 Year"" , ""Some College , 1 Or More Years ,  No Degree"" , ""Associate's Degree"" , ""Bachelor's Degree"" , ""Master's Degree"" , ""Professional School Degree"" , ""Doctorate Degree"") ,  prob = c(0.013 , 0.05 , 0.0850 , 0.246 , 0.039 , 0.064 , 0.15 , 0.075, 0.176 , 0.072 , 0.019 , 0.012) , name = ""Education"")", 500)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::education()", 1)
        End If
    End Sub

    Private Sub cmdEmployment_Click(sender As Object, e As EventArgs) Handles cmdEmployment.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield:: employment(n = , x = c(""Full Time"" , ""Part Time"" , ""Unemployed"" , ""Retired"" , ""Student""), prob = c(0.6, 0.1, 0.1, 0.1, 0.1), Name = ""Employment"")", 131)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::employment()", 1)
        End If
    End Sub

    Private Sub cmdEye_Click(sender As Object, e As EventArgs) Handles cmdEye.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::eye(n =, x = c(""Brown"" , ""Blue"" , ""Green"" , ""Hazel"" , ""Gray"") , prob = c(0.44 , 0.3 , 0.13 , 0.09 , 0.04) , name = ""Eye"")", 114)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::eye()", 1)
        End If
    End Sub

    Private Sub cmdGrade_Level_Click(sender As Object, e As EventArgs) Handles cmdGrade_Level.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade_level(n = , x = c(""K"" , ""1"" , ""2"" , ""3"" , ""4"" , ""5"" , ""6"" , ""7"" , ""8"" , ""9"" , ""10"" ,""11"" , ""12""), prob = NULL, name = ""Grade_Level"")", 123)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade_level()", 1)
        End If
    End Sub

    Private Sub cmdGrade_Click(sender As Object, e As EventArgs) Handles cmdGrade.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade(n = , mean = 88 , sd = 4 , name = ""Grade"" , digits = 1)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade()", 1)
        End If
    End Sub

    Private Sub cmdGroup_Click(sender As Object, e As EventArgs) Handles cmdGroup.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::group(n = , x = c(""Control"" , ""Treatment"") , prob = NULL , name = ""Group"")", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::group()", 1)
        End If
    End Sub

    Private Sub cmdHair_Click(sender As Object, e As EventArgs) Handles cmdHair.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::hair(n = , x = c(""Brown"" , ""Black"" , ""Blonde"" , ""Red""), prob = c(0.35 , 0.28, 0.26 , 0.11), name = ""hair"")", 98)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::hair()", 1)
        End If
    End Sub

    Private Sub cmdHeight_Click(sender As Object, e As EventArgs) Handles cmdHeight.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::height(n = , mean = 69 , sd = 3.75 , min = 1 , max = NULL , digits = 0 , name = ""Height"")", 79)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::height()", 1)
        End If
    End Sub

    Private Sub cmdIncome_Click(sender As Object, e As EventArgs) Handles cmdIncome.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::income(n = , digits = 2, name = ""Income"")", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::income()", 1)
        End If
    End Sub

    Private Sub cmdInternet_Browser_Click(sender As Object, e As EventArgs) Handles cmdInternet_Browser.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::internet_browser(n = , x = c(""Chrome"" , ""IE"", ""Firefox"" , ""Safari"" , ""Opera"" , ""Android"") , prob = c(0.5027 , 0.175 , 0.1689 , 0.0994, 0.017, 0.0132) , name = ""Browser"")", 149)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::internet_browser()", 1)
        End If
    End Sub

    Private Sub cmdIq_Click(sender As Object, e As EventArgs) Handles cmdIq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::iq(n = , mean = 100 , sd = 10 , min = 0 , max = NULL , digits = 0 , name = ""IQ"")", 74)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::iq()", 1)
        End If
    End Sub

    Private Sub cmdLanguage_Click(sender As Object, e As EventArgs) Handles cmdLanguage.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::language(n = , x = wakefield::languages[[""Language""]] , prob = wakefield::languages[[""Proportion""]], name = ""Language"")", 107)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::language()", 1)
        End If
    End Sub

    Private Sub cmdLevel_Click(sender As Object, e As EventArgs) Handles cmdLevel.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::level(n = , x = 1:4 , prob = NULL , name = ""Level"")", 42)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::level()", 1)
        End If
    End Sub
    Private Sub cmdMath_Click(sender As Object, e As EventArgs) Handles cmdMath.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::math(n = , x = 1:4 , prob = c(0.29829 , 0.33332 , 0.22797 , 0.14042) , name = ""Math"")", 77)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::math()", 1)
        End If
    End Sub

    Private Sub cmdEla_Click(sender As Object, e As EventArgs) Handles cmdEla.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::ela(n = , x = 1:4 , prob = c(0.3161 , 0.37257 , 0.2233 , 0.08803) , name = ""ELA"")", 74)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::ela()", 1)
        End If
    End Sub

    Private Sub cmdGpa_Click(sender As Object, e As EventArgs) Handles cmdGpa.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gpa(n = , mean = 88 , sd = 4 , name = ""GPA"")", 37)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gpa()", 1)
        End If
    End Sub

    Private Sub cmdPetLikert_Click(sender As Object, e As EventArgs) Handles cmdLikert.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::likert((n = , x = c(""Strongly Agree"" , ""Agree"" , ""Neutral"" , ""Disagree"" , ""Strongly Disagree""), prob NULL , name = ""Likert"")", 113)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::likert()", 1)
        End If
    End Sub

    Private Sub cmdLorem_Ipsum_Click(sender As Object, e As EventArgs) Handles cmdLorem_ipsum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::lorem_ipsum(n = , ..., name = ""Lorem_Ipsum"")", 29)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::lorem_ipsum()", 1)
        End If
    End Sub

    Private Sub cmdMarital_Click(sender As Object, e As EventArgs) Handles cmdMarital.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::marital(n = , x = c(""Married"" , ""Divorced"" , ""Widowed"" , ""Separated"" , ""Never Married"") , prob = NULL , name = ""Marital"")", 110)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::marital()", 1)
        End If
    End Sub

    Private Sub cmdMilitary_Click(sender As Object, e As EventArgs) Handles cmdMilitary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::military(n = , x = c(""Army"", ""Air Force"", ""Navy"", ""Marine Corps"" , ""Coast Guard"") , prob = c(0.3785 , 0.2334 , 0.2218 , 0.1366 , 0.0296) , name = ""Military"")", 144)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::military()", 1)
        End If
    End Sub

    Private Sub cmdWakefield_Month_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Month.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_month(n = , x = month.name , prob = NULL , name = ""Month"")", 49)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_month()", 1)
        End If
    End Sub

    Private Sub cmdName_Click(sender As Object, e As EventArgs) Handles cmdName.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::name(n = , x = wakefield::name_neutral , prob = NULL , replace = FALSE , name = ""Name"")", 79)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::name()", 1)
        End If
    End Sub

    Private Sub cmdNormal_Click(sender As Object, e As EventArgs) Handles cmdNormal.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::normal(n = , mean = 0 , sd = 1 , min = NULL , max = NULL , name = ""Normal"")", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::normal()", 1)
        End If
    End Sub

    Private Sub cmdPolitical_Click(sender As Object, e As EventArgs) Handles cmdPolitical.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::political((n = , x = c(""Democrat"" , ""Republican"" , ""Constitution"" , ""Libertarian"" , ""Green"") , prob = c(0.577269133302094 , 0.410800432748879 , 0.00491084954793489 , 0.00372590303330866 , 0.0032936813677832) , name = ""Political"")", 215)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::political()", 1)
        End If
    End Sub

    Private Sub cmdRace_Click(sender As Object, e As EventArgs) Handles cmdRace.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::race(n = , x = c(""White"" , ""Hispanic"" , ""Black"" , ""Asian"" , ""Bi-Racial"" , ""Native"" , ""Other"" , ""Hawaiian"") , prob = c(0.637 , 0.163 , 0.122 , 0.047 , 0.019 , 0.007 , 0.002 , 0.0015) , name = ""Race"")", 190)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::race()", 1)
        End If
    End Sub

    Private Sub cmdReligion_Click(sender As Object, e As EventArgs) Handles cmdReligion.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::religion(n = , x = c(""Christian"" , ""Muslim"" , ""None"" , ""Hindu"" , ""Buddhist"" , ""Folk"" , ""Other"" , ""Jewish"") , prob = c(0.31477 , 0.23163 , 0.16323 , 0.14985 , 0.07083 , 0.05882 , 0.00859 , 0.00227) , name = ""Religion"")", 205)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::religion()", 1)
        End If
    End Sub

    Private Sub cmdSat_Click(sender As Object, e As EventArgs) Handles cmdSat.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sat(n = , mean = 1500 , sd = 100 , min = 0 , max = 2400 , digits = 0 , name = ""SAT"")", 77)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sat()", 1)
        End If
    End Sub

    Private Sub cmdSentence_Click(sender As Object, e As EventArgs) Handles cmdSentence.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sentence(n = , x = wakefield::presidential_debates_2012 , prob = NULL , name = ""Sentence"")", 78)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sentence()", 1)
        End If
    End Sub

    Private Sub cmdGender_Click(sender As Object, e As EventArgs) Handles cmdGender.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gender(n = , x = c(""Male"" , ""Female"") , prob = c(0.51219512195122 , 0.48780487804878) , name = ""Gender"")", 95)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gender()", 1)
        End If
    End Sub

    Private Sub cmdSex_Inclusive_Click(sender As Object, e As EventArgs) Handles cmdSex_Inclusive.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex_inclusive(n = , x = c(""Male"" , ""Female"" , ""Intersex"") , prob = NULL , name = ""Sex"")", 70)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex_inclusive()", 1)
        End If
    End Sub

    Private Sub cmdSex_Click(sender As Object, e As EventArgs) Handles cmdSex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex(n = , x = c(""Male"" , ""Female"") , prob = c(0.51219512195122 , 0.48780487804878) , name = ""Sex"")", 91)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex()", 1)
        End If
    End Sub

    Private Sub cmdSmokes_Click(sender As Object, e As EventArgs) Handles cmdSmokes.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::smokes(n = , prob = c(0.822 , 0.178) , name = ""Smokes"")", 45)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::smokes()", 1)
        End If
    End Sub

    Private Sub cmdSpeed_Click(sender As Object, e As EventArgs) Handles cmdSpeed.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::speed(n = , mean = 55 , sd = 10 , min = 0 , max = NULL , digits = 0 , name = ""Speed"")", 76)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::speed()", 1)
        End If
    End Sub

    Private Sub cmdState_Click(sender As Object, e As EventArgs) Handles cmdState.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::state(n = , x = datasets::state.name , prob = wakefield::state_populations[[""Proportion""]], name = ""State"")", 98)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::state()", 1)
        End If
    End Sub

    Private Sub cmdString_Click(sender As Object, e As EventArgs) Handles cmdString.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::string(n = , x = ""[A-Za-z0-9]"" , length = 10 , name = ""String"")", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::string()", 1)
        End If
    End Sub

    Private Sub cmdWakefield_Upper_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Upper.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_upper(n = , k = 5, x = LETTERS , prob = NULL, name = ""Upper"")", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_upper()", 1)
        End If
    End Sub

    Private Sub cmdValid_Click(sender As Object, e As EventArgs) Handles cmdValid.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::Valid(n = , prob = NULL, name = ""Valid"")", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::Valid()", 1)
        End If
    End Sub

    Private Sub cmdWakefield_Year_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Year.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_year(n = , x = 1996:as.numeric(format(Sys.Date() , ""%Y"")) , prob = NULL , name = ""Year"")", 80)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_year()", 1)
        End If
    End Sub

    Private Sub cmdCircMean_Click(sender As Object, e As EventArgs) Handles cmdCircMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::mean.circular(x = , na.rm = FALSE, control.circular = list())", 44)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::mean.circular()", 1)
        End If
    End Sub

    Private Sub cmdCircMedian_Click(sender As Object, e As EventArgs) Handles cmdCircMedian.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::median.circular(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::median.circular()", 1)
        End If
    End Sub

    Private Sub cmdMedianHL_Click(sender As Object, e As EventArgs) Handles cmdMedianHL.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::medianHL.circular(x = , na.rm = FALSE, method = c(HL1,HL2,HL3), prop = NULL)", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::medianHL.circular()", 1)
        End If
    End Sub

    Private Sub cmdCircRange_Click(sender As Object, e As EventArgs) Handles cmdCircRange.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::range.circular(x = , test = FALSE, na.rm = FALSE, finite = FALSE, control.circular = list(), )", 76)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::range.circular()", 1)
        End If
    End Sub

    Private Sub cmdCircSd_Click(sender As Object, e As EventArgs) Handles cmdCircSd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::sd.circular(x = ,  na.rm = FALSE)", 18)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::sd.circular()", 1)
        End If
    End Sub

    Private Sub cmdCircVar_Click(sender As Object, e As EventArgs) Handles cmdCircVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::var.circular(x = ,  na.rm = FALSE)", 18)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::var.circular()", 1)
        End If
    End Sub

    Private Sub cmdA1_Click(sender As Object, e As EventArgs) Handles cmdA1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::A1(kappa = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::besselI()", 1)
        End If
    End Sub

    Private Sub cmdAngVar_Click(sender As Object, e As EventArgs) Handles cmdAngVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.variance(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.variance()", 1)
        End If
    End Sub

    Private Sub cmdAngDev_Click(sender As Object, e As EventArgs) Handles cmdAngDev.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.deviation(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.deviation()", 1)
        End If
    End Sub

    Private Sub cmdCircQ1_Click(sender As Object, e As EventArgs) Handles cmdCircQ1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.25, na.rm = FALSE, names = TRUE, type = 7)", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.25)", 16)
        End If
    End Sub

    Private Sub cmdCircMin_Click(sender As Object, e As EventArgs) Handles cmdCircMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0, na.rm = FALSE, names = TRUE, type = 7)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0)", 13)
        End If
    End Sub

    Private Sub cmdCircMax_Click(sender As Object, e As EventArgs) Handles cmdCircMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 1, na.rm = FALSE, names = TRUE, type = 7)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 1)", 13)
        End If
    End Sub

    Private Sub cmdCircQ3_Click(sender As Object, e As EventArgs) Handles cmdCircQ3.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.75, na.rm = FALSE, names = TRUE, type = 7)", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.75)", 16)
        End If
    End Sub

    Private Sub cmdCircQuantile_Click_1(sender As Object, e As EventArgs) Handles cmdCircQuantile.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = seq(0, 1, 0.25), na.rm = FALSE, names = TRUE, type = 7)", 66)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = seq(0, 1, 0.25))", 28)
        End If
    End Sub

    Private Sub cmdCircRho_Click_1(sender As Object, e As EventArgs) Handles cmdCircRho.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rho.circular(x = , na.rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rho.circular()", 1)
        End If
    End Sub

    Private Sub cmdCircular_Click(sender As Object, e As EventArgs) Handles cmdCircular.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::circular(x = , type = c(""angles"", ""directions""), units = c(""radians"", ""degrees"", ""hours""), ""template"" = c(""none"", ""geographics"", ""clock12"", ""clock24""),  modulo = c(""asis"", ""2pi"", ""pi""), zero = 0, rotation = c(""counter"", ""clock""), names))", 225)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::circular(x =, modulo = ""2pi"", units = ""radians"")", 36)
        End If
    End Sub


    Private Sub cmdMovmin_Click(sender As Object, e As EventArgs) Handles cmdMovmin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply(data = , width = , FUN = min , by = 1, by.column = TRUE, fill = NA, na.pad = FALSE, partial = FALSE, align = c(""center"", ""left"", ""right""), coredata = TRUE)))", 151)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply( , width = , FUN = min, k = 3, fill = NA)", 40)
        End If
    End Sub

    Private Sub cmdNafill_Click(sender As Object, e As EventArgs) Handles cmdNafill.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.fill(object = , fill = NA , ix = !is.na(object)))", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.fill()", 1)
        End If
    End Sub

    Private Sub cmdNaest_Click(sender As Object, e As EventArgs) Handles cmdNaest.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.aggregate(object = , by = 1, FUN = mean, na.rm = FALSE, maxgap = Inf))", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.aggregate()", 1)
        End If
    End Sub

    Private Sub cmdNaapprox_Click(sender As Object, e As EventArgs) Handles cmdNaapprox.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.approx(object = , x = index(object), xout = , na.rm = FALSE, maxgap = Inf, along))", 66)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.approx()", 1)
        End If
    End Sub

    Private Sub cmdNasplin_Click(sender As Object, e As EventArgs) Handles cmdNasplin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.spline(object = , x = index(object), xout = , na.rm = FALSE, maxgap = Inf, along))", 66)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.spline()", 1)
        End If

    End Sub


    Private Sub cmdFactor_Click(sender As Object, e As EventArgs) Handles cmdFactor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::as_factor(x = , ... )", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::as_factor()", 1)
        End If
    End Sub

    Private Sub cmdAnon_Click(sender As Object, e As EventArgs) Handles cmdAnon.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_anon(x = , prefix = "" )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_anon()", 1)
        End If
    End Sub

    Private Sub cmdLabelled_Click(sender As Object, e As EventArgs) Handles cmdLabelled.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("labelled::labelled(x = , labels = , label = NULL)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("labelled::labelled()", 1)
        End If
    End Sub

    Private Sub cmdCollapse_Click(sender As Object, e As EventArgs) Handles cmdCollapse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_collapse(.f = , ..., group_other = FALSE)", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_collapse()", 1)
        End If
    End Sub

    Private Sub cmdCross_Click(sender As Object, e As EventArgs) Handles cmdCross.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_cross(.f = , ..., sep = "":"", keep_empty = FALSE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_cross()", 1)
        End If
    End Sub

    Private Sub cmdDrop_Click(sender As Object, e As EventArgs) Handles cmdDrop.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_drop(f = , only)", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_drop()", 1)
        End If
    End Sub

    Private Sub cmdExpand_Click(sender As Object, e As EventArgs) Handles cmdExpand.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_expand(f = , ...)", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_expand()", 1)
        End If
    End Sub

    Private Sub cmdAdd_na_Click(sender As Object, e As EventArgs) Handles cmdAdd_na.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_explicit_na(f = , na_level = ""(Missing)"")", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_explicit_na()", 1)
        End If
    End Sub

    Private Sub cmdInorder_Click(sender As Object, e As EventArgs) Handles cmdInorder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inorder(f = , ordered = NA)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inorder()", 1)
        End If
    End Sub

    Private Sub cmdInfreq_Click(sender As Object, e As EventArgs) Handles cmdInfreq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_infreq(f = , ordered = NA)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_infreq()", 1)
        End If
    End Sub

    Private Sub cmdInseq_Click(sender As Object, e As EventArgs) Handles cmdInseq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inseq(f = , ordered = NA)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inseq()", 1)
        End If
    End Sub

    Private Sub cmdLump_Click(sender As Object, e As EventArgs) Handles cmdLump.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_lump(f = , n, prop, w = NULL, other_level = ""Other"", ties.method = c(""min"", ""average"", ""first"", ""last"", ""random"", ""max""))", 113)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_lump()", 1)
        End If
    End Sub

    Private Sub cmdFmatch_Click(sender As Object, e As EventArgs) Handles cmdFmatch.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_match(f = , lvls)", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_match()", 1)
        End If
    End Sub

    Private Sub cmdOther_Click(sender As Object, e As EventArgs) Handles cmdOther.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_other(f = , keep = , drop = , other_level = ""Other"")", 43)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_other()", 1)
        End If
    End Sub

    Private Sub cmdRecode_Click(sender As Object, e As EventArgs) Handles cmdRecode.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_recode(.f = , ...)", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_recode()", 1)
        End If
    End Sub

    Private Sub cmdRelevel_Click(sender As Object, e As EventArgs) Handles cmdRelevel.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_relevel(.f = , ..., after = 0L)", 19)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_relevel()", 1)
        End If
    End Sub

    Private Sub cmdReorder_Click(sender As Object, e As EventArgs) Handles cmdReorder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_reorder(.f = , .x = , .fun = median, ..., .desc = FALSE)", 44)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_reorder()", 1)
        End If
    End Sub

    Private Sub cmdReverse_Click(sender As Object, e As EventArgs) Handles cmdReverse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_rev(f = , )", 4)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_rev()", 1)
        End If
    End Sub

    Private Sub cmdShift_Click(sender As Object, e As EventArgs) Handles cmdShift.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shift(f = , n = 1L)", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shift()", 1)
        End If
    End Sub

    Private Sub cmdShuffle_Click(sender As Object, e As EventArgs) Handles cmdShuffle.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shuffle(f = , )", 4)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shuffle()", 1)

        End If
    End Sub

    Private Sub cmdPgamma_Click(sender As Object, e As EventArgs) Handles cmdPgamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pgamma(q = , shape = , rate = 1, scale = 1/rate, lower.tail = TRUE,log.p = FALSE))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pgamma()", 1)
        End If
    End Sub

    Private Sub cmdQgamma_Click(sender As Object, e As EventArgs) Handles cmdQgamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qgamma(p = , shape = , rate = 1, scale = 1/rate, lower.tail = TRUE, log.p = FALSE))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qgamma()", 1)
        End If
    End Sub

    Private Sub cmdPbeta_Click(sender As Object, e As EventArgs) Handles cmdPbeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbeta(q = , shape1 = , shape2 = , ncp = 0, lower.tail = TRUE, log.p = FALSE))", 68)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbeta()", 1)
        End If
    End Sub

    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmdPbirth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbirthday(n = , classes = 365, coincident = 2))", 34)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbirthday()", 1)
        End If
    End Sub

    Private Sub cmdPbinom_Click(sender As Object, e As EventArgs) Handles cmdPbinom.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbinom(q = , size = , prob = , lower.tail = TRUE, log.p = FALSE))", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbinom()", 1)
        End If
    End Sub

    Private Sub cmdPpois_Click(sender As Object, e As EventArgs) Handles cmdPpois.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ppois(q = , lambda = , lower.tail = TRUE, log.p = FALSE))", 48)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ppois()", 1)
        End If
    End Sub

    Private Sub cmdPnbin_Click(sender As Object, e As EventArgs) Handles cmdPnbin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnbinom(q = , size = , prob = , mu = , lower.tail = TRUE, log.p = FALSE))", 62)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnbinom()", 1)
        End If
    End Sub

    Private Sub cmdQbeta_Click(sender As Object, e As EventArgs) Handles cmdQbeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbeta(p = , shape1 = , shape2 = , ncp = 0, lower.tail = TRUE, log.p = FALSE))", 68)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbeta()", 1)
        End If
    End Sub

    Private Sub cmdQbirth_Click(sender As Object, e As EventArgs) Handles cmdQbirth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbirthday(prob = 0.5, classes = 365, coincident = 2))", 37)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbirthday()", 1)
        End If
    End Sub

    Private Sub cmdQbinom_Click(sender As Object, e As EventArgs) Handles cmdQbinom.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbinom(p = , size = , prob = , lower.tail = TRUE, log.p = FALSE))", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbinom()", 1)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdQpois.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qpois(p = , lambda = , lower.tail = TRUE, log.p = FALSE))", 48)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qpois()", 1)
        End If
    End Sub

    Private Sub cmdQnbin_Click(sender As Object, e As EventArgs) Handles cmdQnbin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnbinom(p = , size = , prob = , mu = , lower.tail = TRUE, log.p = FALSE))", 62)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnbinom()", 1)
        End If
    End Sub

    Private Sub cmdLinkert7_Click(sender As Object, e As EventArgs) Handles cmdLinkert7.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::likert_7(n = , x = c(""Strongly Agree"", ""Agree"", ""Somewhat Agree"", ""Neutral"",""Somewhat Disagree"", ""Disagree"", ""Strongly Disagree""), prob = NULL,name = ""Likert""))", 148)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::likert_7()", 1)
        End If
    End Sub

    Private Sub cmdStarts_Click(sender As Object, e As EventArgs) Handles cmdStarts.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_starts(string = , pattern = argument, negate = FALSE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_starts()", 1)
        End If
    End Sub

    Private Sub cmdEnd_Click(sender As Object, e As EventArgs) Handles cmdEnd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_ends(string = , pattern = argument, negate = FALSE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_ends()", 1)
        End If
    End Sub

    Private Sub cmdRemove1_Click(sender As Object, e As EventArgs) Handles cmdRemove1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_remove(string = , pattern = argument)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_remove()", 1)
        End If
    End Sub

    Private Sub cmdRemove2_Click(sender As Object, e As EventArgs) Handles cmdRemove2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_remove_all(string = , pattern = argument)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_remove_all()", 1)
        End If
    End Sub

    Private Sub cmdSquishb_Click(sender As Object, e As EventArgs) Handles cmdSquishb.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_squish(string = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_squish()", 1)
        End If
    End Sub

    Private Sub cmdEncodeb_Click(sender As Object, e As EventArgs) Handles cmdEncodeb.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_conv(string = , encoding = )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_conv()", 1)
        End If
    End Sub

    Private Sub cmdExtract2_Click(sender As Object, e As EventArgs) Handles cmdExtract2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_extract_all(string = , pattern = , simplify = FALSE)", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_extract_all()", 1)
        End If
    End Sub

    Private Sub cmdLocate2_Click(sender As Object, e As EventArgs) Handles cmdLocate2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_locate_all(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_locate_all()", 1)
        End If
    End Sub

    Private Sub cmdReplace2_Click(sender As Object, e As EventArgs) Handles cmdReplace2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_replace_all(string = , pattern = , replacement = )", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_replace_all()", 1)
        End If
    End Sub

    Private Sub cmdBoundary_Click(sender As Object, e As EventArgs) Handles cmdBoundary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(type = c(""character"", ""line_break"", ""sentence"", ""word""), stringr::boundary(), skip_word_none = NA)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::boundary()", 1)
        End If
    End Sub

    Private Sub cmdCollate_Click(sender As Object, e As EventArgs) Handles cmdCollate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::coll(), ignore_case = FALSE, locale = ""en"")", 51)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::coll()", 1)
        End If
    End Sub

    Private Sub cmdFixed_Click(sender As Object, e As EventArgs) Handles cmdFixed.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::fixed(), ignore_case = FALSE)", 41)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::fixed()", 1)
        End If
    End Sub

    Private Sub cmdRegex_Click(sender As Object, e As EventArgs) Handles cmdRegex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::regex() , ignore_case = FALSE , multiline = FALSE , comments = FALSE, dotall = FALSE)", 97)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::regex()", 1)
        End If
    End Sub

    Private Sub cmdAny1_Click(sender As Object, e As EventArgs) Handles cmdAny1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(".")
    End Sub

    Private Sub cmdbegin_Click(sender As Object, e As EventArgs) Handles cmdbegin.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("^", 1)
    End Sub

    Private Sub cmdEnd1_Click(sender As Object, e As EventArgs) Handles cmdEnd1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("$")
    End Sub

    Private Sub cmdDigit_Click(sender As Object, e As EventArgs) Handles cmdDigit.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("\d")
    End Sub

    Private Sub cmdSpace_Click(sender As Object, e As EventArgs) Handles cmdSpace.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("\s")
    End Sub

    Private Sub cmdOr1_Click(sender As Object, e As EventArgs) Handles cmdOr1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("[]", 1)
    End Sub

    Private Sub cmdNot1_Click(sender As Object, e As EventArgs) Handles cmdNot1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("[^ ]", 2)
    End Sub

    Private Sub cmdOr3_Click(sender As Object, e As EventArgs) Handles cmdOr3.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("|")
    End Sub

    Private Sub cmdOr2_Click(sender As Object, e As EventArgs) Handles cmdOr2.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("{}", 1)
    End Sub

    Private Sub cmdNumbers_Click(sender As Object, e As EventArgs) Handles cmdNumbers.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("{,}", 2)
    End Sub

    Private Sub cmdZeroOrOne_Click(sender As Object, e As EventArgs) Handles cmdZeroOrOne.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("?")
    End Sub

    Private Sub cmdPlusOne_Click(sender As Object, e As EventArgs) Handles cmdPlusOne.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdEscape_Click(sender As Object, e As EventArgs) Handles cmdEscape.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("\\")
    End Sub

    Private Sub cmdPlusZero_Click(sender As Object, e As EventArgs) Handles cmdPlusZero.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdMode1_Click(sender As Object, e As EventArgs) Handles cmdMode1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv1(x = , na_rm = FALSE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv1()", 1)
        End If
    End Sub

    Private Sub cmdKurtosis_Click(sender As Object, e As EventArgs) Handles cmdKurtosis.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::kurtosis(x = , na.rm = FALSE, type = 3)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::kurtosis()", 1)
        End If
    End Sub

    Private Sub cmdBr2_Click(sender As Object, e As EventArgs) Handles cmdBr2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::br2(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::br2(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdCp_Click(sender As Object, e As EventArgs) Handles cmdCp.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::cp(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::cp(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdV_Click(sender As Object, e As EventArgs) Handles cmdD.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::d(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::d(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdKGE_Click(sender As Object, e As EventArgs) Handles cmdKGE.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::KGE(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::KGE(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdMae_Click(sender As Object, e As EventArgs) Handles cmdMae.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::mae(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::mae(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdMd_Click(sender As Object, e As EventArgs) Handles cmdMd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::md(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::md((sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdMe_Click(sender As Object, e As EventArgs) Handles cmdMe.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::me(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::me(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdmNSE_Click(sender As Object, e As EventArgs) Handles cmdmNSE.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::mNSE(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::mNSE(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdMse_Click(sender As Object, e As EventArgs) Handles cmdMse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::mse(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::mse(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdNrmse_Click(sender As Object, e As EventArgs) Handles cmdNrmse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::nrmse(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::nrmse(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdNSE_Click(sender As Object, e As EventArgs) Handles cmdNSE.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::NSE(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::NSE(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdPbias_Click(sender As Object, e As EventArgs) Handles cmdPbias.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::pbias(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::pbias(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdPbiasfde_Click(sender As Object, e As EventArgs) Handles cmdPbiasfde.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::pbiasfdc(sim = , obs = , plot = FALSE)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::pbiasfdc(sim = , obs = , plot = FALSE)", 24)
        End If
    End Sub

    Private Sub cmdRd_Click(sender As Object, e As EventArgs) Handles cmdRd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rd(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rd(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdRmse_Click(sender As Object, e As EventArgs) Handles cmdRmse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rmse(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rmse(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdRNSE_Click(sender As Object, e As EventArgs) Handles cmdRNSE.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rNSE(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rNSE(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdRPearson_Click(sender As Object, e As EventArgs) Handles cmdRPearson.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rPearson(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rPearson(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdRSD_Click(sender As Object, e As EventArgs) Handles cmdRSD.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rSD(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rSD(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdRsr_Click(sender As Object, e As EventArgs) Handles cmdRsr.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rsr(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::rsr(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdSsq_Click(sender As Object, e As EventArgs) Handles cmdSsq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::ssq(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::ssq(sim = , obs = )", 10)
        End If
    End Sub

    Private Sub cmdVE_Click(sender As Object, e As EventArgs) Handles cmdVE.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::VE(sim = , obs = )", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hydroGOF::VE(sim = , obs = )", 10)
        End If
    End Sub

    ''' <summary>
    ''' this will be raised when the input name is changed and even when the ucrSave checkbox checked status is changed
    ''' </summary>
    ''' <param name="ucrChangedControl"></param>
    Private Sub ucrSaveResultInto_SaveNameChanged(ucrChangedControl As ucrCore) Handles ucrSaveResultInto.ControlContentsChanged
        RaiseEvent SaveNameChanged()
    End Sub

End Class
