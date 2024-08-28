'R- Instat
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

Imports RDotNet
Public Class ucrCalculator
    Public iHelpCalcID As Integer
    Public Event NameChanged()
    Public Event SelectionChanged()
    Public Event SaveNameChanged()
    Public Event DataFrameChanged()
    Public Event TryCommadClick()
    Public Event ControlValueChanged()
    Public Event ClearClick()
    Public Event CheckBoxClick()
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsHelp As New RFunction
    Private iBasicWidth As Integer
    Private iBaseHeight As Integer
    Private strPackageName As String
    Private clsDataFunction As New RFunction
    Private clsRepFunction As New RFunction
    Private clsZseqFunction As New RFunction
    Private FrequencyFunction As New RFunction

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
        ucrInputCalOptions.SetItems({"Basic", "Maths", "Logical and Symbols", "Transform", "Summary", "Probability", "Factor", "Text/Strings (Character Columns)", "Dates/Times", "Circular", "Wakefield", "Goodness of Fit", "List", "Complex", "Integer", "Functions"}) ' "Rows" is a temp. name
        ucrInputCalOptions.SetDropDownStyleAsNonEditable()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations

        ucrChkStoreScalar.Text = "Store Scalar"

        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")

        'Temp disabled::Needs discussions to see if they are needed
        bControlsInitialised = True
        ttCalculator.SetToolTip(cmdRound, "round(x) to round to whole numbers, round(x,2) to round to 2 decimal places, round(x,-2) to round to the nearest 100")
        ttCalculator.SetToolTip(cmdSiginf, "signif(x,3) to round to 3 significant figures")

        'Transform keyboard tooltips
        ttCalculator.SetToolTip(cmdSortF, """Use only With extreme care"" sorts a vector into ascending Or descending order. For example sort(c(5, 7, 4, 4, 3)) = (3, 4, 4, 5, 7)")
        ttCalculator.SetToolTip(cmdScale, "centre And scale the data - usually by producing (x - xbar)/s")
        ttCalculator.SetToolTip(cmdLag, "shift a variable down. For example lag(1:5) = (NA,1,2,3,4); lag(1:5,3) = (NA,NA,NA, 1,2)")
        ttCalculator.SetToolTip(cmdLead, "shift a variable up. For example lead(1:5) = (2,3,4,5,NA); lead(1:5;3) = (4,5, NA,NA,NA)")
        ttCalculator.SetToolTip(cmdDiff, "difference between successive elements. For example diff(c(1,4,3,7)) = (NA 3,-1,4)")
        ttCalculator.SetToolTip(cmdRev, "reverse a variable. For example rev(c(1,2,3,4,5)) =(5,4,3,2,1)")
        ttCalculator.SetToolTip(cmdPMax, " maximum of a set of variables. For examples pmax(c(1,3,5),c(6,4,2)) = (6,4,5)")
        ttCalculator.SetToolTip(cmdPMin, "minimum of a set of variables. For examples pmin(c(1,3,5),c(6,4,2)) = (1,3,2)")
        ttCalculator.SetToolTip(cmdCumMax, "cumulative maxima. For example cummax(c(3,2,1,4,0)) = (3,3,3,4,4)")
        ttCalculator.SetToolTip(cmdMovMax, "moving (or rolling) maxima. For example rollmax(x=c(3,2,1,4,0) ,3,fill=NA, align=""right"") = (NA,NA, 3,4,4)")
        ttCalculator.SetToolTip(cmdCumSum, "cumulative sums. For example cumsum(c(3,2,1,4,0)) = (3,5,6,10,10)")
        ttCalculator.SetToolTip(cmdCumProd, "cumulative products. For example cumprod(c(2,3,5,7)) = (2,6,30,210)")
        ttCalculator.SetToolTip(cmdMovProd, "moving products Fror example rollapply(c(2,3,5,7,11),width=3,fill=NA, FUN=prod) = (NA,30,105,385,NA)")
        ttCalculator.SetToolTip(cmdCumMean, "cumulative means. For example cummean(c(3,2,1,4,0)) = (3,2.5,2,2.5,2)")
        ttCalculator.SetToolTip(cmdCumMin, "cumulative minima. For example cummin(c(3,2,1,4,0)) = (3,2.,1,1,0)")
        ttCalculator.SetToolTip(cmdMovSum, "moving (or rolling) totals. For example rollsum(c(3,2,1,4,0) ,3,fill=NA, align=""left"") = (6,7,5,NA,NA)")
        ttCalculator.SetToolTip(cmdMovMean, "moving (or rolling) mean. For example rollmean(c(3,2,1,6,2) ,3,fill=NA) = (NA,2,3,3,NA)")
        ttCalculator.SetToolTip(cmMovMed, "moving (or rolling) medians. For example rollmedian(c(3,2,1,6,2) ,3,fill=NA) = (NA,2,2,2,NA)")
        ttCalculator.SetToolTip(cmdMovmin, "moving (or rolling) minima. For example rollapply(c(3,2,1,6,2),width=3,fill=NA, FUN=min) = (NA,1,1,1,NA)")
        ttCalculator.SetToolTip(cmdNtile, " use ranks to divide into (almost) equal sized groups. For example ntile(c(15,11,13,12,NA,12),2) = (2,1,2,1,NA,1)")
        ttCalculator.SetToolTip(cmdCumdist, "proportion of values less than or equal to the current rank. For example cume_dist(c(2,4,6,8,3)) = (0.2, 0.6, 0.8, 1.0, 0.4)")
        ttCalculator.SetToolTip(cmdRowRank, "row numbers as ranks. For example :row_number(c(15,11,13,12,NA,12)) = (5,1,3,2,NA,3)")
        ttCalculator.SetToolTip(cmdRank, "ranks. For example rank(15,11,13,12, NA, 12) = (5, 1, 4, 2.5, 6, 2.5)")
        ttCalculator.SetToolTip(cmdPercentRank, "rescale of minimum ranks to [0,1]. For example percent_rank(c(15,11,13,12,NA,12)) = (1,0,0.75,0.25,NA,0.25)")
        ttCalculator.SetToolTip(cmdDRank, "dense ranks. For example d_rank(c(15,11,13,12,NA,12)) = (4,1,3,2,NA,2)")
        ttCalculator.SetToolTip(cmdMRank, " minimum ranks. For example m_rank(c(15,11,13,12,NA,12)) = (5,1,4,2,NA,2)")
        ttCalculator.SetToolTip(cmdNafill, "fills missing values at the start, middle and end. For example na.fill(c(NA,2,NA,4,5,NA),fill=""extend"") = (2,2,3,4,5,5); while fill=c(15,""extend"",NA) = (15,2,3,4,5,NA)")
        ttCalculator.SetToolTip(cmdNaapprox, "linear interpolation of missing values. For example na.approx(c(5,NA,NA,2,2,NA,4,7,NA),maxgap=1,na.rm=FALSE) = (5,NA,NA,2,2,3,4,7,NA)")
        ttCalculator.SetToolTip(cmdNasplin, "Spline interpolation of missing values. For example na.spline(c(NA,NA,NA,2,2,NA,4,7,NA),maxgap=2,na.rm=FALSE) = (NA,NA,NA,2,2,2.5,4,7,12)")
        ttCalculator.SetToolTip(cmdNaest, "Missing values as the mean (usually) overall or with a factor. For example na.aggregate(c(NA,NA,NA,2,2,NA,4,7,NA),maxgap=2,na.rm=FALSE) = (NA,NA,NA,2,2,3.75,4,7,3.75)")
        ttCalculator.SetToolTip(cmdRescale, "Transforms to (0, 1) scale, using (x - min)/(max - min)")

        'Logical and Symbols toooltips
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
        ttCalculator.SetToolTip(cmdwhen, "when is multiple ifelse, for example case_when(1:5 > 3 ~ 20, 1:5>1~10) gives (NA,10,10,20,20)")
        ttCalculator.SetToolTip(cmdIfelse, "is what it says, for example ifelse((1:5 > 3,20,10) gives 10, 10, 10, 20, 20")
        ttCalculator.SetToolTip(cmdBetween, "between two values, for example between(1:5, 3,4) is FALSE, FALSE, TRUE, TRUE, FALSE")
        ttCalculator.SetToolTip(cmdIsNa, "is.na detects missing values, for example is.na(c(1,3,NA, 5)) gives FALSE, FALSE, TRUE, FALSE")
        ttCalculator.SetToolTip(cmdNotIsNa, "!is.na detects non-missing values, for example !is.na(c(1,3,NA, 5)) gives TRUE, TRUE, FALSE, TRUE")
        ttCalculator.SetToolTip(cmdDuplicate, "duplicate detects non-unique values, for example duplicated(c(1:3,2,7)) gives FALSE, FALSE, FALSE, TRUE, FALSE")
        ttCalculator.SetToolTip(cmdNear, "near(x,y)compares 2 variables. For example sqrt(5)^2 is almost, but isn't exactly 5, however near(sqrt(5)^2,5) is TRUE")
        ttCalculator.SetToolTip(cmdnumeric, "Define a variable as numeric.  For example as numeric(c(TRUE,TRUE,FALSE,TRUE)) gives (1, 1,0, 1) ")
        ttCalculator.SetToolTip(cmdSquareBrackets, "Extract one or more elements from a column (or data frame")
        ttCalculator.SetToolTip(cmdTilde, "This is called tilde and links the left side and right side of a formula")
        ttCalculator.SetToolTip(cmdCalcConcantenateFunction, "Combines arguments to form a single vector, e.g. c(1:3 8) is 1, 2, 3, 8")
        ttCalculator.SetToolTip(cmdCalcRepelicationFunction, "Repeat of a sequence, e.g. rep(c(2, 3, 4), each=2) gives 2, 2, 3, 3, 4, 4")
        ttCalculator.SetToolTip(cmdCalcSequenceFunction, "Sequences, given either as seq(1, 5, 2) to give 1, 3, 5 or as seq(1, 5, length = 3) to give the same")
        ttCalculator.SetToolTip(cmdWhich, "which gives the indices of a logical variable. For example which(11:15>13) gives 4, 5. Note the result is usually not the same length as the original variable.")
        ttCalculator.SetToolTip(cmdAnyDup, "any Are any values TRUE in a logical variable. For example any(1:5 >3) gives TRUE")
        ttCalculator.SetToolTip(cmdPnorm, "(normal probabilities. For example; pnorm(-1.6449) = 0.05; pnorm(130,100,15) = 0.9772.")
        ttCalculator.SetToolTip(cmdPt, " t probabilities. For example pt(-2,5) = 0.051; pt(-2,1000) = 0.0229 ~ pnorm(-2)")
        ttCalculator.SetToolTip(cmdPChisq, "chi square probabilities. For example pchisq(5,1) = 0.9747; pchisq(5,10) = 0.1088")

        'Probabilityv keyboard tooltips
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

        'maths keyboard tooltips
        ttCalculator.SetToolTip(cmdDeg, "Change from radians to degrees. For example deg(pi/2) = 90.")
        ttCalculator.SetToolTip(cmdExp, "The exponential function. exp(1) = e = 2.71828. exp(0) = 1, exp(-2) = 0.1353 = 1/exp(2). It is the inverse of the log function, so exp(6.238) = 512, while log(512) = 6.238.")
        ttCalculator.SetToolTip(cmdAbs, "The absolute (or positive) value. For example abs (-4.4) = abs(4.4) = 4.4.")
        ttCalculator.SetToolTip(cmdSign, "The sign of the corresponding values. So sign(4.2)=1, sign(-20)=-1, sign(c(-2,-1,0,1,2,3))= (-1,-1,0,1,1,1)")
        ttCalculator.SetToolTip(cmdLogit, "log(p/(1-p)) for p between 0 and 1, or between 0 and 100 if you have percentages. For example logit(c(0.2, 0.5, 0.95)) is (-1.386, 0, 2.944).")
        ttCalculator.SetToolTip(cmdLogistic, "Distribution function for the logistic distribution. For example dlogis(c(-2,-1,0,1,2), 0, 5513) = (0.026, 0.14, 0.5, 0.86, 0.974). The scale of 0.5513 gives a standard deviation of 1.")
        ttCalculator.SetToolTip(cmdAtan2, "atan2(x,y) gives the angle between the x axis and the vector between to origin and the point (x,y). For example atan2(1,1) = 0.7854 = pi/4 (=45 degrees).")
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
        ttCalculator.SetToolTip(cmdAtan, "angle corresponding to a given tangent (in the range 0 to pi). For example atan(1) = 0.7854 (= pi/4); deg(atan(1)) = 45.")
        ttCalculator.SetToolTip(cmdTrunc, "truncates the values towards 0. So trunc(3.5) = 3, trunc(-3.5)= -3")
        '----------------------------------------------------------------------------------------------------

        ttCalculator.SetToolTip(cmdUpper, "Change to upper case. For example str_to_upper(""Dr. Foster"") gives ""DR. FOSTER""")
        ttCalculator.SetToolTip(cmdLower, "Change to lower case. For example str_to_lower(""Dr. Foster"") gives ""dr. foster""")
        ttCalculator.SetToolTip(cmdTitle, "Change first letter of each word. For example str_to_title(""dr. foster"") gives ""Dr. Foster""")
        ttCalculator.SetToolTip(cmdTrim, "Deletes white space round a text. For example, str_trim(""  shower   of rain  "") gives ""shower   of rain""")
        ttCalculator.SetToolTip(cmdSquishb, "Deletes excess white space For example, str_squish(""shower    of rain  "") gives ""shower of rain""")
        ttCalculator.SetToolTip(cmdPad, "Make string a fixed width. For example, str_pad(""science"",12,""right"") gives ""science     """)
        ttCalculator.SetToolTip(cmdOrder, "Give numeric order. For exampled, str_order(c(""11"",""a"",""tree"",""5""),num=TRUE) gives 4,1,2,3""")
        ttCalculator.SetToolTip(cmdSort, "Sort the strings. For example, str_sort(c(""11"",""a"",""tree"",""5""),numeric=TRUE) gives ""5""    ""11""   ""a""    ""tree""")
        ttCalculator.SetToolTip(cmdCombine, "Join multiple strings. For example, :str_c(""letter: "",c(""d"",""o"",""g"")) gives ""letter: d"" ""letter: o"" ""letter: g""")
        ttCalculator.SetToolTip(cmdCountstrings, " The number of matches. For example, str_count(c(""nose"",""lip"",""eye""),""e"") gives 1 0 2""")
        ttCalculator.SetToolTip(cmdDetect, " Detect a match. For example, str_detect(c(""nose"",""lip"",""eye""),""e"") gives TRUE FALSE TRUE""")
        ttCalculator.SetToolTip(cmdEnds, " Detect an ending match. For example, str_ends(c(""nose"",""lip"",""eye""),""e"") gives TRUE FALSE TRUE")
        ttCalculator.SetToolTip(cmdExtract, "Extract a matching string. For example, str_extract(c(""nose"",""lip"",""eye""),""e"") gives e NA e")
        ttCalculator.SetToolTip(cmdExtract2, "Extract all matching strings. For example, str_extract_all(c(""nose"",""lip"",""eye""),""e"") gives e NA e, e""")
        ttCalculator.SetToolTip(cmdGlue, "Format and combine strings with glue. For example, (with survey data) str_glue(""Village {village}, with fertilizer {fert*10}kg."") gives Village SABEY, with fertilizer 0kg. etc""")
        ttCalculator.SetToolTip(cmdLenth, "Length of a string. For example, str_length(""Usain Bolt"") gives 10""")
        ttCalculator.SetToolTip(cmdLocate, "Start and end position of pattern in a string. For example, str_locate(c(""nose"",""lip"",""eye""),""e"") gives 4, 4 NA 1, 1""")
        ttCalculator.SetToolTip(cmdLocate2, "All start and end positions . For example, str_locate_all(c(""nose"",""lip"",""eye""),""e"") gives 4, 4 NA 1, 1  3, 3""")
        ttCalculator.SetToolTip(cmdRemove1, "Remove pattern . For example, str_remove(c(""nose"",""lip"",""eye""),""e"") gives ""nos"" ""lip"" ""ye""")
        ttCalculator.SetToolTip(cmdRemove2, "Remove all occurrences of pattern. For example, str_remove_all(c(""nose"",""lip"",""eye""),""e"") gives ""nos"" ""lip"" ""y""")
        ttCalculator.SetToolTip(cmdReplace, "Extract substring. For example, str_replace(c(""nose"",""ear"",""eye""),""e"",""y"") gives ""nosy"" ""yar"" ""yye""")
        ttCalculator.SetToolTip(cmdReplace2, "Replace all patterns. For example, str_replace_all(c(""nose"",""ear"",""eye""),""e"",""y"") gives ""nosy"" ""yar"" ""yyy""")
        ttCalculator.SetToolTip(cmdStarts, " Detect a starting match. For example, str_starts(c(""nose"",""ear"",""eye""),""e"") gives FALSE TRUE TRUE")
        ttCalculator.SetToolTip(cmdTrunck, "Truncate strings. For example, str_trunc(""Katumani"",7) gives ""Katu…""; 8 gives ""Katumani""")
        ttCalculator.SetToolTip(cmdSub, "Extract substring. For example,str_sub(""Kakamega County"",1,8) ""gives"" ""Kakamega.""  ""-6 gives"" ""County""")
        ttCalculator.SetToolTip(cmdEncodeb, "Specify the encoding of a string")

        ttCalculator.SetToolTip(cmdBoundary, "Count words or sentences, rather than characters. For example, str_count(""In a shower of rain"", boundary(""word"") gives 5")
        ttCalculator.SetToolTip(cmdCollate, " Compare patterns literally – no regex. For example, str_detect(""rss"",coll(""r.s"")) is FALSE")
        ttCalculator.SetToolTip(cmdFixed, "like collate, but only if all strings are ASCII characters.")
        ttCalculator.SetToolTip(cmdRegex, "The default in comparing patterns. For example, str_detect(""rss"",""r.s"") or str_detect(""rss"",regex(""r.s"")) gives TRUE, because ‘.’ Matches any character.")
        ttCalculator.SetToolTip(cmdAny1, " Matches any character. For example,str_count(c(""rss"",""r.s.t""),""."") gives 3 5.  Using \\. Gives 0 2 ")
        ttCalculator.SetToolTip(cmdbegin, " Start of the string. For example, str_count(c(""rss"",""r.s.t""),""^r\\."") gives 0 1")
        ttCalculator.SetToolTip(cmdEnd1, "End of the string. For example, str_count(c(""rss"",""r.s.t""),""s$"") gives 1 0")
        ttCalculator.SetToolTip(cmdDigit, "Digit (0 to 9), For example, str_replace_all(c(""rs5"",""r19s20t""),""[^\\d]"","") gives 5 1920")
        ttCalculator.SetToolTip(cmdSpace, "space. For example. str_remove_all(c(""r ss"",""r s t""),""\\s"") gives ""rss"" ""rst""")
        ttCalculator.SetToolTip(cmdOr1, "or. For example, str_count(c(""rss"", ""rsstt""),""[st]"") gives 2 4")
        ttCalculator.SetToolTip(cmdNot1, "not any. For example, str_remove_all(c(""rs5"",""r19s20t""),""[^\\d]"") gives 5 1920")
        ttCalculator.SetToolTip(cmdOr3, "or. For example, str_count(c(""-abc"",""67""),""-|\\d"") gives 1 2")
        ttCalculator.SetToolTip(cmdOr2, "n times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]{1}t"") gives 0 1 0 0")
        ttCalculator.SetToolTip(cmdNumbers, "between. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]{0,2}t"") gives 1 1 1 1")
        ttCalculator.SetToolTip(cmdZeroOrOne, "0 or 1 times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]?t"") gives 1 1 0 0 ")
        ttCalculator.SetToolTip(cmdPlusOne, "1 or more times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]+t"") gives 0 1 1 1")
        ttCalculator.SetToolTip(cmdZero, "0 or more times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]*t"") gives 1 1 1 1 ")
        ttCalculator.SetToolTip(cmdEscape, "Escape (with +*.? etc). For example, str_detect(c(""b$t"",""bat?"",""3*4""),""[\\?\\$\\*]"") gives TRUE TRUE TRUE")
        ttCalculator.SetToolTip(cmdPlusZero, "range of values. For example, str_count(c(""b$t"",""Bat?""),""[a-zA-Z]"") gives 2 3")

        'Interger keyboard tooltips
        ttCalculator.SetToolTip(cmdBigZ, "encodes arbitrarily large integers")
        ttCalculator.SetToolTip(cmdBigQ, "encodes rationals encoded as ratios or arbitrarily large integers")
        ttCalculator.SetToolTip(cmdFactorial, "factorial n!, as big integer. For example, factorialZ(6)= 720")
        ttCalculator.SetToolTip(cmdChoosez, "computes binomial coefficient choose(n,k) as a big integer. For example, chooseZ(20,2)=190")
        ttCalculator.SetToolTip(cmdNextPrime, "gives the next prime number. For example, nextprime(14)= 17")
        ttCalculator.SetToolTip(cmdFactorize, "compute the prime factorizations. For example, Factorize(20)= (2,5,2,1)")
        ttCalculator.SetToolTip(cmdFactorize2, "like factorize, but with simpler layout of results and much slower for large data sets.")
        ttCalculator.SetToolTip(cmdIsPrime, "checks if the number is prime and returns 0 or 2, 0= False, 2= True. For example, is.prime(10) returns 0")
        ttCalculator.SetToolTip(cmdFibonacci, "generates Fibonacci numbers. For example, Fibonacci(8)=21")
        ttCalculator.SetToolTip(cmdDivisors, "returns the divisors of x. For example, Divisors(21)= c(1,3,7)")
        ttCalculator.SetToolTip(cmdRankPercent, "returns the percentile that the number correspods to. For example, PercentRank(c(1,2,5,11,15)) = 0.2,0.4,0.6,0.8,1.0")
        ttCalculator.SetToolTip(cmdDigitSum, "calculates digit sum of x. For example, DigitSum(12344)= 14")
        ttCalculator.SetToolTip(cmdBinary, "converts an integer into a binary number. For example,intToBin(c(2,5,7,8))= 10,101,111,1000")
        ttCalculator.SetToolTip(cmdOctal, "converts an integer into an octal number. For example, intToOct(c(2,5,12,17))= 02,05,14,21")
        ttCalculator.SetToolTip(cmdHex, "converts an integer into a hexadecimal number. For example, intToHex(c(2,7,10,15)))= 2,7,a,f")
        ttCalculator.SetToolTip(cmdOctmode, "converts an integer into an octal number. For example, as.octmode(intToOct(c(2,5,12,17)))= 02,05,14,21")
        ttCalculator.SetToolTip(cmdHexmode, "converts an integer into a hexadecimal number. For example, as.hexmode(intToHex(c(2,7,10,15)))= 2,7,a,f")
        ttCalculator.SetToolTip(cmdNthPrime, "gives the n-th prime. For example nth_prime(1000)= 7919")
        ttCalculator.SetToolTip(cmdGeneratePrimes, "generates the first n prime numbers equal to the number of rows in the data")
        ttCalculator.SetToolTip(cmdGCD, "greatest common divisor, for example gcd(18,42) = 6")
        ttCalculator.SetToolTip(cmdSCM, "smallest common multiple, for example scm(18,42) = 126 (= 718 & 342)")
        ttCalculator.SetToolTip(cmdCoprime, "also called mutually prime, for example coprime(30,77) = TRUE. (30 = 235, 77 = 7*11)")
        ttCalculator.SetToolTip(cmdPhi, "Euler’s Totient Function. For example phi(12) = 4 (1, 2, 5, 7 are less than 12 and coprime)")
        ttCalculator.SetToolTip(cmdTwin, "twin primes, for example, twin(0,10) gives (3,5), & (5,7)")
        ttCalculator.SetToolTip(cmdCousin, "cousin primes, for example cousin(0,20) gives (3,7) & (13,17)")
        ttCalculator.SetToolTip(cmdSexy, "sexy primes (6 in Latin is sex!), for example sexy(0,40) gives (23,29) & (31,37)")
        ttCalculator.SetToolTip(cmdThird, "third cousin primes, for example third(0,100) gives (89,97)")
        ttCalculator.SetToolTip(cmdTriplets, "sexy prime triplets, for example triplets(0,100) gives (47, 53, 59)")
        ttCalculator.SetToolTip(cmdKTuple, "k_tuple general formula for all these keys. For example k_tuple(0, 10, c(0,2)) gives twin primes")
        ttCalculator.SetToolTip(cmdRoman, "converts a small(up to 3899) positive integer to Roman numbers. For example as.roman(14)=XIV")
        ttCalculator.SetToolTip(cmdPalindrome, "generates palindromes to the length of the dataframe. For example the 100th palindromic number is 909")
        ttCalculator.SetToolTip(cmdCatalan, "generates Catalan numbers to the length of the data frame. The 5th is 10!/(5!*6!) =7 * 6 = 42")
        ttCalculator.SetToolTip(cmdPerfect, "divisors add to the number. So 6 = 1+2+3. Only 51 perfect numbers are currently known.")
        ttCalculator.SetToolTip(cmdFrugal, "125 is frugal because 125 = 5(cubed) and 5 and 3 are fewer digits (2) than 125 (3).")
        ttCalculator.SetToolTip(cmdPowerful, "36 = 2(squared)*3(squared) is powerful because for each divisor, here 2 and 3, its square is also a divisor.")
        ttCalculator.SetToolTip(cmdUgly, "also called Regular or Hamming or 5-smooth numbers. Numbers for which the factors are only 2, or 3 or 5.")
        ttCalculator.SetToolTip(cmdHappy, "13 is happy because 1(squared) + 3(squared) = 10, then 1(squared)+ 0(squared) = 1.")
        ttCalculator.SetToolTip(cmdAchilles, "powerful numbers that are not perfect squares. 72 is the smallest Achilles number.")
        ttCalculator.SetToolTip(cmdPadovan, "sum of last but 1 and last but 2 values. So from ...7, 9, 12, next is 7+9 = 16.")
        ttCalculator.SetToolTip(cmdTriangle, "number of objects in a triangle, so 0, 1, 3, 6, 10...")
        ttCalculator.SetToolTip(cmdSquare, "squares of each integer, so 1, 4, 9, 16.")
        ttCalculator.SetToolTip(cmdLucas, "generates Lucas numbers to the length of the dataframe. For example the 10th Lucas number is 76")
        ttCalculator.SetToolTip(cmdPrimorial, "gives the primorial (like the factorial, but just the primes up to the number) for a variable. For example primorial(c(7,8,9)) = 235*7 = (210, 210, 210)")

        ' Complex keyboard tooltips
        ttCalculator.SetToolTip(cmdComplexPi, "pi = 3.14159")
        ttCalculator.SetToolTip(cmdComplexi, "i is defined as the square root of -1. So sqrt(as.complex(-1)) = 0 + 1i")
        ttCalculator.SetToolTip(cmdComplex, "Generate a complex variable. For example complex(3, 2:4,1.5) gives 2+1.5i, 3+1.5i, 4+1.5i")
        ttCalculator.SetToolTip(cmdAsComplex, "Define a variable as complex. For example as.complex(-1) gives 1 + 0i")
        ttCalculator.SetToolTip(cmdReal, "The real part of a complex number. For example Re(3 + 2i) gives 3.")
        ttCalculator.SetToolTip(cmdImaginary, "The imaginary part of a complex number or variable. For example Im(3 + 2i) gives 2.")
        ttCalculator.SetToolTip(cmdMod, "The modulus (polar coordinate) of a complex number or variable. For example Mod(3 + 2i) gives 3.606, which is sqrt(3*3 + 2*2). Also abs(3 + 2i) is the same as Mod(3 + 2i).")
        ttCalculator.SetToolTip(cmdArg, " The argument (polar coordinate) of a complex number or variable. For example Arg(3 + 2i) gives 0.588 where 3 = 3.606cos(0.588) and 2 = 3.606sin(0.588).")
        ttCalculator.SetToolTip(cmdConjugate, "Conjugate of a complex number or variable: For example Conj(3 + 2i) gives 3 - 2i.")
        ttCalculator.SetToolTip(cmdComplexRad, "Change from degrees to radians. For example rad(90 + 180i) gives (1.571 + 3.142i)")
        ttCalculator.SetToolTip(cmdComplexDeg, " Change from radians to degrees. For example deg(pi/2 + 3.142i) gives (90 + 180i)")
        ttCalculator.SetToolTip(cmdComplexSqrt, "Square root. For example sqrt(-9 + 0i) gives (0 + 3i) or just 3i. sqrt(-9 + 2i) gives 0.331 + 3.018i)")
        ttCalculator.SetToolTip(cmdComplexExp, "exponential function. For example exp(1 + 2i) gives -1.131+2.472i")
        ttCalculator.SetToolTip(cmdComplexRound, "round(pi/2 + 3.14259i) gives 2 + 3i) so rounds to whole numbers. round(pi/2 + 3.14259i, 2) gives 1.57 + 3.14i, so rounds to 2 decimals.")
        ttCalculator.SetToolTip(cmdComplexSignif, "Rounds to give the specified number off digits in the larger of the components. For example signif(0.424 + 511.38i, 3) gives (0 + 511i)")
        ttCalculator.SetToolTip(cmdComplexSin, "sine of the angle in radians For example sin(1-1i) gives (1.2985-0.635i)")
        ttCalculator.SetToolTip(cmdComplexCos, "cosine of the angle in radians. For example cos(1-1i) gives (0.8337+0.9889i)")
        ttCalculator.SetToolTip(cmdComplexTan, "tangent of the angle in radians. For example tan(1-i) gives (0.272-1.084i)")
        ttCalculator.SetToolTip(cmdComplexAsin, "arcsine, or inverse of the sine. It is the angle in radians corresponding to a given sine. For example asin(1.2985-0.635i) gives (1-1i)")
        ttCalculator.SetToolTip(cmdComplexAcos, "arccos, or inverse of the cosine. It is the angle corresponding to a given cos. For example acos(0.8337+0.9889i) gives (1-1i)")
        ttCalculator.SetToolTip(cmdComplexAtan, "arctan or inverse of the tangent. It is the angle corresponding to a given tan. For example atan(0.272-1.084i) gives (1-1i)")
        ttCalculator.SetToolTip(cmdComplexSinH, " hyperbolic sin of a number in radians (asinh also exists)")
        ttCalculator.SetToolTip(cmdComplexCosH, "hyperbolic cosine of a number in radians (acosh also exists)")
        ttCalculator.SetToolTip(cmdComplexTanH, "hyperbolic tangent of a number in radians (atanh also exists)")
        ttCalculator.SetToolTip(cmdComplexLog, "natural logarithm. For example log(1 + 2i) gives 0.805+1.107i")

        'Goodness of Fit keyboard tooltips
        ttCalculator.SetToolTip(cmdBr2, "r-squared times the slope of the regression line between sim and obs")
        ttCalculator.SetToolTip(cmdCp, "coefficent of persistence between sim and obs")
        ttCalculator.SetToolTip(cmdD, "Index of agreement between sim and obs")
        ttCalculator.SetToolTip(cmdKGE, "Kling-Gupta efficiency between sim and obs")
        ttCalculator.SetToolTip(cmdMae, "mean absolute error between sim and obs")
        ttCalculator.SetToolTip(cmdMd, "modified index of agreement between sim and obsmNSE")
        ttCalculator.SetToolTip(cmdMe, "mean error between sim and obs")
        ttCalculator.SetToolTip(cmdmNSE, "modified Nash-Sutcliffe efficiency between sim and obs")
        ttCalculator.SetToolTip(cmdMse, "mean squared error between sim and obs")
        ttCalculator.SetToolTip(cmdNrmse, "normalized root mean square error between sim and obs")
        ttCalculator.SetToolTip(cmdNSE, "Nash-Sutcliffe efficiency between sim and obs")
        ttCalculator.SetToolTip(cmdPbias, "percent bias between sim and obs")
        ttCalculator.SetToolTip(cmdPbiasfdc, "percent bias in the slope of the midsegment of the flow duration curve")
        ttCalculator.SetToolTip(cmdRd, "relative index of agreement (d) between sim and obs. (Value is between 0 and 1)")
        ttCalculator.SetToolTip(cmdRmse, "root mean square error between sim and obs, so the standard deviation of the model prediction error")
        ttCalculator.SetToolTip(cmdRNSE, "relative Nash-Sutcliffe efficiency between sim and obs")
        ttCalculator.SetToolTip(cmdRPearson, "correlation between sim and obs")
        ttCalculator.SetToolTip(cmdRSD, "ratio of standard deviations between sim and obs")
        ttCalculator.SetToolTip(cmdRsr, "ratio of the root mean square error between sim and obs to the standard deviation of obs")
        ttCalculator.SetToolTip(cmdSsq, "sum of squared residuals between sim and obs")
        ttCalculator.SetToolTip(cmdVE, " volumetric efficiency between sim and obs (Value is between 0 and 1)")

        'Wakefield Tooltips
        ttCalculator.SetToolTip(cmdAge, "Sample of ages, with default from 20 to 35")
        ttCalculator.SetToolTip(cmdAnimal, "Sample of animals, with default of 10 from a list of 591 animals!")
        ttCalculator.SetToolTip(cmdPet, "Sample of pets. Default is dog, cat, none, bird, horse, with given probabilities")
        ttCalculator.SetToolTip(cmdAnswer, " Sample of No or Yes, with defaults of equal probability")
        ttCalculator.SetToolTip(cmdCar, "Sample of cars, with datasets mtcars makes as default")
        ttCalculator.SetToolTip(cmdChildren, "Sample of number of children, with default 0 to 10 and defined probabilities")
        ttCalculator.SetToolTip(cmdCoin, "Sample giving heads or tails with default of equal probability")
        ttCalculator.SetToolTip(cmdColor, "Sample by default from the 657 colours in the grDevices package")
        ttCalculator.SetToolTip(cmdPrimary, "Sample by default from the colours, red, green, blue, yellow, black, and white. Are those your primary colours?")
        ttCalculator.SetToolTip(cmdWakefieldDates, " Sample of dates with default being dates in order, by month, for the past year")
        ttCalculator.SetToolTip(cmdDeath, "Sample giving FALSE/TRUE with default being equally likely")
        ttCalculator.SetToolTip(cmdDice, "Sample with default being equally likely from a 6 sided dice")
        ttCalculator.SetToolTip(cmdDna, "Sample with default being equally likely from Guanine, Adenine, Thymine, Cytosine")
        ttCalculator.SetToolTip(cmdDob, "Sample of dates, with default being for 2 years, starting 15 years ago")
        ttCalculator.SetToolTip(cmdDummy, "Sample of 0 and 1, with default equally likely")
        ttCalculator.SetToolTip(cmdEducation, "Sample of 12 education levels from No education to doctorate with defined probabilities")
        ttCalculator.SetToolTip(cmdEmployment, "Sample of 5 employment levels, namely: full-time, part-time, unemployed, retired, student")
        ttCalculator.SetToolTip(cmdEye, "Sample of 5 eye colours, namely: brown, blue green, hazel, grey")
        ttCalculator.SetToolTip(cmdGrade_Level, "Sample of grade levels from 1 to 12")
        ttCalculator.SetToolTip(cmdGrade, "Sample from normal disribution with default mean 88 and sd 4. See also grade_letter and gpa")
        ttCalculator.SetToolTip(cmdGrade_Letter, "Sample from normal distribution with default mean 88 snd sd 4, with fixed translation into A+ to F")
        ttCalculator.SetToolTip(cmdGpa, "Sample from normal distribution with default mean 88 and sd 4, with fixed translation into gpa of 4 to 0")
        ttCalculator.SetToolTip(cmdGroup, "Sample generating 2 groups, with default of random assignment to Control and Treatment, with equal probabilities")
        ttCalculator.SetToolTip(cmdHair, "Sample with default of 4 hair colours, brown, black, blonde, red, and defined probabilities")
        ttCalculator.SetToolTip(cmdHeight, "Sample from normal distribution with default mean 69, and sd 3.75, min 1, and no specified max, rounded to no decimals")
        ttCalculator.SetToolTip(cmdIncome, "Sample from a gamma distribution with mean 40,000 and shape 2. (Multiply the result to change the mean)")
        ttCalculator.SetToolTip(cmdid, "Generate a variable with zero-padded IDs")
        ttCalculator.SetToolTip(cmdIq, "Sample from normal distribution with default of mean 100 and sd 15 - not 10 as provided by the package")
        ttCalculator.SetToolTip(cmdLanguage, "Sample of world's languages with default being list of 99 languages, provided, together with their proportions")
        ttCalculator.SetToolTip(cmdWakefieldLower, "Sample of single letters, with default being one of a,b,c,d,e")
        ttCalculator.SetToolTip(cmdMath, "Sample of integers with default of 1 to 4, and probabilities based on New York grading in maths for Grades 3 to 8 children. (Called level instead if equally likely)")
        ttCalculator.SetToolTip(cmdWakefieldMinute, "Sample of minutes as H:M:S time elements. (Tweak command to hours or seconds if needed)")
        ttCalculator.SetToolTip(cmdLikert, "Sample from 5-point scale, ranging from strongly agree to strongly disagree, with default of equal probabilities")
        ttCalculator.SetToolTip(cmdLorem_ipsum, "Provides random gibberish text, based on Latin")
        ttCalculator.SetToolTip(cmdMarital, "Sample with default of 5 categories, Married, Divorced, Widowed, Separated, Never Married, equally likely")
        ttCalculator.SetToolTip(cmdMilitary, "Sample with default of 5 categories, Army, etc, and proportions to match US military")
        ttCalculator.SetToolTip(cmdWakefield_Month, "Sample of months with default using full names for all months and equal proportions")
        ttCalculator.SetToolTip(cmdName, "Sample of names, with default from provided list of 95,025 different gender-neutral names, (so sampled without replacement)")
        ttCalculator.SetToolTip(cmdNormal, "Sample from normal distribution, with default being standard normal, (mean 0, sd 1) and no min or max values specified")
        ttCalculator.SetToolTip(cmdPolitical, "Sample of political parties with default being 5 categories based on US registered voters")
        ttCalculator.SetToolTip(cmdRace, "Sample with default of 8 races (white, to Hawaiaan) and US proportions")
        ttCalculator.SetToolTip(cmdReligion, "Sample with default of 8 religions and world ratios of numbers in each")
        ttCalculator.SetToolTip(cmdSat, "Sample of SAT scores. Normal distribution and default changed from package values to give mean of 1000 and maximum of 1600")
        ttCalculator.SetToolTip(cmdSentence, "Sample of sentences with default supplied list from 2012 presidential debate")
        ttCalculator.SetToolTip(cmdGender, "Sample of male, female with default proportions matching gender makeup")
        ttCalculator.SetToolTip(cmdSex_Inclusive, "Sample of male, female, intersex, with default proportion of transgender from 2011 report")
        ttCalculator.SetToolTip(cmdWakefieldTimes, "Sample of times of day as H:M:S time elements")
        ttCalculator.SetToolTip(cmdSmokes, "Logical (TRUE/FALSE) sample with default of 18% smokers")
        ttCalculator.SetToolTip(cmdSpeed, "Sample from normal distribution, with default mean 55 and sd 10")
        ttCalculator.SetToolTip(cmdState, "Sample with default from the 50 US states in proportion to their 2010 populations")
        ttCalculator.SetToolTip(cmdString, "Sample with default of 10 random alphanumeric characters")
        ttCalculator.SetToolTip(cmdWakefieldUpper, "Sample of single capital letter, with default being one of A, B, C, D, E")
        ttCalculator.SetToolTip(cmdValid, "Logical (TRUE/FALSE) sample with default being equal probability")
        ttCalculator.SetToolTip(cmdWakefield_Year, "Sample of years with default from 1996 to current year, with equal probability")
        ttCalculator.SetToolTip(cmdLikert7, " Sample from 7-point scale, ranging from strongly agree to strongly disagree, with default of equal probabilities")

        ' circular keyboard tooltips
        ttCalculator.SetToolTip(cmdCircular, "Define a variable as circular. Specify whether the data are in radians (default), degrees, or hours")
        ttCalculator.SetToolTip(cmdCircMean, "The circular mean. For example with 1, 2, 3, 6, mean(circular(c(1,2,3,6)) gives 1.51")
        ttCalculator.SetToolTip(cmdCircSd, "The circular standard deviation. This is not the sqrt(circular.var). It is reasonably close to the ordinary sd for data in radians")
        ttCalculator.SetToolTip(cmdCircRho, "The mean resultant length is between 0 and 1. Small values imply large (circular) variation. For 1,2,3,6 rho is 0.4036. With 1,2,3,4,5,6 it is 0.049")
        ttCalculator.SetToolTip(cmdCircRange, "Circular range is the shortest arc containing the data. For example with 1,2,3,6 gives 3.28 (6 is also -0.28 on circle from 0 to 2*pi)")
        ttCalculator.SetToolTip(cmdCircVar, "The circular variance is (1 - rho), so between 0 and 1, with small values implying low (circular) variation. For 1,2,3,6 var is 0.5964. With 1,2,3,4,5,6 var is 0.951")
        ttCalculator.SetToolTip(cmdCircQuantiles, "Defined quantiles round the circle. With 0.5 it is the (circular) median, so is 1.5 for 1,2,3,6")
        ttCalculator.SetToolTip(cmdCircMax, "Largest value round the circle. For example, for 1,2,3,6 max is 3")
        ttCalculator.SetToolTip(cmdCircMin, " Smallest value round the circle. For 1,2,3,6 min is 6. (values are from 6 (almost 2 * pi  to 3)")
        ttCalculator.SetToolTip(cmdCircQ1, "Lower quartile round the circle. For 1,2,3,6, q1 is 0.68")
        ttCalculator.SetToolTip(cmdCircQ3, "Upper quartile round the circle. For 1,2,3,6 q3 is 2.25")
        ttCalculator.SetToolTip(cmdMedianHL, " Median using Hodges-Lehmann estimate. For example with 1,2,3,6, medianHL (and median) give 1.5")
        ttCalculator.SetToolTip(cmdCircMedian, "Circular median. For example with 23 and 2 representing hours, median(circular(c(23,2), units=""hours"")) gives 0,5")
        ttCalculator.SetToolTip(cmdAngVar, "The angular variance is twice the circular variance, so between 0 and 2")
        ttCalculator.SetToolTip(cmdA1, "Ratio of Bessel functions for values of kappa parameter. Used in the von Mises (circular normal) distribution kappa = 0.9 gives A1 same as rho value for 1,2,3,6 data")
        ttCalculator.SetToolTip(cmdAngDev, "The angular deviation is square root of the angular variance, so between 0 and sqrt(2)")

        'Dates/Times keyboard tooltips
        ttCalculator.SetToolTip(cmdDate, "Get the date part of a date-time variable")
        ttCalculator.SetToolTip(cmdAsDate, "Converts a character or numeric variable into a date. For example as_date(30) or as_date(""19700131"") or as.date(""1970.jan-31"") each give 1970-01-31")
        ttCalculator.SetToolTip(cmdDateTime, "Converts a character or numeric variable into a date-time variable. For example as_datetime(30) gives 1970-01-01 00:00:30 UTC")
        ttCalculator.SetToolTip(cmdTime, "Converts seconds, minutes, hours into a time variable. For example hms(185) gives 00:03:05, hms(25, 64) gives 01:04:25")
        ttCalculator.SetToolTip(cmdYmd, "Makes a date variable from various character or numeric formats in year-month-day order. For example ymd(19840512) gives 1984-05-12")
        ttCalculator.SetToolTip(cmdDmy, "Makes a date variable from various formats in day-month-year order. For example dmy(12051984) gives 1984-05-12")
        ttCalculator.SetToolTip(cmdMdy, " Makes a date variable for mdy order. For example mdy(5121984) gives 1984-05-12. (Note alternatives of myd, ydm and dym)")
        ttCalculator.SetToolTip(cmdAsTime, "Makes a time variable from numeric or character variable. For example: as_hms(185) gives 00:03:05, as_hms(""14:55:10"") gives 14:55:10")
        ttCalculator.SetToolTip(cmdYmdHms, "Make a date-time variable from various character or numeric formats")
        ttCalculator.SetToolTip(cmdYmdHm, " Make a date-time variable from various formats. For example ymd_hm(202406161201) gives 2024-06-16 12:01:00 UTC")
        ttCalculator.SetToolTip(cmdYmdH, "Make a date-time variable from various formats. For example ymd_h(""2024.6:16,12"") gives ""2024-06-16 12:00:00 UTC""")
        ttCalculator.SetToolTip(cmdLeap, "True if date is from a leap year and FALSE otherwise. For example leap(1984-05-12) is TRUE")
        ttCalculator.SetToolTip(cmdYear, "Extract year from date or date-time. For example year(""1984-5-12"") gives 1984")
        ttCalculator.SetToolTip(cmdMonth, "Extract month from a date or date-time variable")
        ttCalculator.SetToolTip(cmdDay, "Extract day in month from date or date-time. For example day(""1984-5-12"" gives 12")
        ttCalculator.SetToolTip(cmdYday, "Gives the day in the year, and depends on leap year. For example yday(""1984-3-1"") gives 61, while yday(""1986-3-1"") gives 60")
        ttCalculator.SetToolTip(cmdWday, "Gives the day of the week from a date, or date-time variable. For example wday(""1984--5-12"", label=TRUE) gives Sat")
        ttCalculator.SetToolTip(cmdD_In_M, "Gives the number of days in the month from date, or date-time. For example d_in_m(""1984_2-12"") gives 29 as 1984 is a leap year")
        ttCalculator.SetToolTip(cmdAm, "TRUE or FALSE from date-time variable. For example am(""1984-05-12 14:23:45"") is FALSE")
        ttCalculator.SetToolTip(cmdPm, "TRUE or FALSE from date-time variable. For example pm(""1984-05-12 14:23:45"") is TRUE")
        ttCalculator.SetToolTip(cmdHour, "Extract hour from date-time variable. For example hour(""1984-05-12 14:23:45"") is 14. Also hour(""1984-05-12"") is 0")
        ttCalculator.SetToolTip(cmdMinutes, "Extract minute from date-time variable. For example minute(""1984-05-12 14:23:45"") Is 23")
        ttCalculator.SetToolTip(cmdSec, "Extract second from date-time variable. For example second(""1984-05-12 14:23:45"") is 45")
        ttCalculator.SetToolTip(cmdQuarter, " 3-month period of the year from a date or date-time variable. For example quarter(""1984-05-12"") gives 2")

        ' Factor keyboard tooltips
        ttCalculator.SetToolTip(cmdFactor, "Make a factor from a numeric or character variable")
        ttCalculator.SetToolTip(cmdAnon, "Anonymise factor levels, replacing them by a number. Optionally add a prefix, for example fct_anon(name, ""n"")")
        ttCalculator.SetToolTip(cmdLabelled, "Create a labelled variable")
        ttCalculator.SetToolTip(cmdCollapse, "Combine factor levels. For example fct_collapse(variety, trad=""TRAD"",improved=c(""NEW"",""OLD""))")
        ttCalculator.SetToolTip(cmdCross, "Make interaction variable. For example fct_cross(variety,fertgrp, keep_empty=TRUE)")
        ttCalculator.SetToolTip(cmdDrop, "Drop unused levels")
        ttCalculator.SetToolTip(cmdExpand, "Add additional levels. For example fct_expand(Village, ""New"", ""Newer"")")
        ttCalculator.SetToolTip(cmdAdd_na, "Make missing values into an additional factor level. For example fct_na_value_to_level(fertgrp)")
        ttCalculator.SetToolTip(cmdInorder, "Order the factor levels by their appearance in the data")
        ttCalculator.SetToolTip(cmdInfreq, "Order the factor levels by their frequency ")
        ttCalculator.SetToolTip(cmdInseq, "Order a factor with numeric levels")
        ttCalculator.SetToolTip(cmdLump, "Change all levels appearing less than min times into Other. For example fct_lump_min(Variety,10)")
        ttCalculator.SetToolTip(cmdFmatch, "Make a logical variable with TRUE when levels are in the factor. For example fct_match(variety,c(""NEW"",""OLD""))")
        ttCalculator.SetToolTip(cmdOther, " Replace levels with Other. For example fct_other(variety, keep=""NEW"")")
        ttCalculator.SetToolTip(cmdRecode, "Change factor levels. For example fct_recode(variety,improved=""NEW"",improved=""OLD"")")
        ttCalculator.SetToolTip(cmdRelevel, " Reorder factor levels. For example fct_relevel(fertgrp,""0cwt"", "".5-2cwt"")")
        ttCalculator.SetToolTip(cmdReorder, "Reorder levels using (default ofmedian of another variable. For example fct_reorder(variety,yield)")
        ttCalculator.SetToolTip(cmdReverse, "Reverse the order of the factor levels")
        ttCalculator.SetToolTip(cmdShift, "Shift the order of the factor levels")
        ttCalculator.SetToolTip(cmdShuffle, "Shuffle the order of the factor levels")

        'Functions keyboard tooltips
        ttCalculator.SetToolTip(cmdAve, "Gives the mean, as a column. For example ave(c(1,2,3,4,10)) = 4, 4, 4, 4, 4")
        ttCalculator.SetToolTip(cmdAveFun, "As ave key, but change mean (in the function) to any summary, e.g. sd, for std dev or raster::cv for coefficient of variation")
        ttCalculator.SetToolTip(cmdAveFac, "Gives the means for one or more factors")
        ttCalculator.SetToolTip(cmdAveBoth, "Gives any summary measure for one or more factors")
        ttCalculator.SetToolTip(cmdFunctionsSsq, "Gives uncorrected sum of squares through the ave function")
        ttCalculator.SetToolTip(cmdFunctionsSsqSession, "Gives uncorrected sum of squares, but only if the library calculator code has been run in the current sesion")
        ttCalculator.SetToolTip(cmdCssq, "Gives corrected sum of squares through the ave function")
        ttCalculator.SetToolTip(cmdCssqSession, "Gives corrected sum of squares, but only if the library calculator code has been run in the current sesion")
        ttCalculator.SetToolTip(cmdPolynomial, "Makes a variable into a polynomial object")
        ttCalculator.SetToolTip(cmdOrigin, " Gives the polynomial coefficients, relative to a new origin")
        ttCalculator.SetToolTip(cmdRoots, "Gives the zeros of a polynomial")
        ttCalculator.SetToolTip(cmdCoeffs, "Gives the polynomial from the zeros")
        ttCalculator.SetToolTip(cmdProd, "The product of the values. So prod(c(1,2,3,4,10)) = 240")
        ttCalculator.SetToolTip(cmdCombn, "combn(c(-2,1,3,4), 2,FUN=prod) gives the products of the values 2 at a time, -2  -6  -8 , 3   4  12. (result usually put into output window)")
        ttCalculator.SetToolTip(cmdCoef, "single coefficient of a polynomial if given roots. So sum(combn(c(-2,1,3,4),3. FUN=prod) =(-6 -12-24 +12) = -26")
        ttCalculator.SetToolTip(cmdCoeffs2, " Gives the polynomial coefficients from the zeros")
        ttCalculator.SetToolTip(cmdFunctionsDigitsum, "Gives the sum of the digits in a numeric variable")
        ttCalculator.SetToolTip(cmdDigitsumSession, "Gives the sum of the digits, if library calculator code has been run in the current session")
        ttCalculator.SetToolTip(cmdPascalSession, "Gives binomial coefficients, if the library calculator code has been run in the current session")
        ttCalculator.SetToolTip(cmdDigitsqu, "Squares of digits in an integer variable")
        ttCalculator.SetToolTip(cmdDigitsquSession, "Squares of digits if the library calculator code has been run in the current session")
        ttCalculator.SetToolTip(cmdMASSFractionsSession, "Changes decimal dta into fractions, if the library calculator code has been run in the current session")
        ttCalculator.SetToolTip(cmdDecimalsSession, "Changes fractions back to decimals if the library calculator code has been run in the current session")
        ttCalculator.SetToolTip(cmdDigitssq, " Gives the ssq of the digits in a numeric variable. For example with c(12, 24, 86) gives (5, 20, 100)")
        ttCalculator.SetToolTip(cmddigitssqSession, "Gives digit sum of squares, but only if the library calculator code has been run in the current sesion")
        ttCalculator.SetToolTip(cmdPascal, "Gives Pascal triangles, e.g. for c(1,2,3,4) gives 1, (1,1), (1, 2, 1), (1, 3, 3, 1)")
        ttCalculator.SetToolTip(cmdMASSFractions, "changes decimal data into a character variable with fractions. So 1.5 becomes 3/2, 0.25 becomes 1/4 etc.")
        ttCalculator.SetToolTip(cmdDecimals, "the inverse of the fractions key. So 3/2 becomes 1.5, 1/4 becomes 0.25 etc.")
        '---------------------------------------------------------------------------------------------------------------------

        Const strTooltipCmdLength = "number Of observations: For example length(c(1,2,3,4,NA)) = 5 "
        ttCalculator.SetToolTip(cmdLength, strTooltipCmdLength)
        ttCalculator.SetToolTip(cmdListLength, strTooltipCmdLength)

        Const strTooltipCmdSum = "the sum or total: So sum(c(1,2,3,4,10)) = 20 "
        ttCalculator.SetToolTip(cmdSum, strTooltipCmdSum)
        ttCalculator.SetToolTip(cmdListSum, strTooltipCmdSum)

        Const strTooltipCmdMin = "the smallest value: So min(c(4,3,10,1,2)) = 1 "
        ttCalculator.SetToolTip(cmdMin, strTooltipCmdMin)
        ttCalculator.SetToolTip(cmdListMin, strTooltipCmdMin)

        Const strTooltipCmdMax = "the largest value: So max(c(4,3,10,1,2)) = 10"
        ttCalculator.SetToolTip(cmdMax, strTooltipCmdMax)
        ttCalculator.SetToolTip(cmdListMax, strTooltipCmdMax)

        Const strTooltipCmdRange = "gives both the min and the max. Use max - min to give the value of the range"
        ttCalculator.SetToolTip(cmdRange, strTooltipCmdRange)
        ttCalculator.SetToolTip(cmdListRange, strTooltipCmdRange)

        Const strTooltipCmdMean = "the average, usually sum/length. So mean(c(1,2,3,4,10)) = 4"
        ttCalculator.SetToolTip(cmdMean, strTooltipCmdMean)
        ttCalculator.SetToolTip(cmdListMean, strTooltipCmdMean)

        Const strTooltipCmdMedian = "the value halfway up the values in order. So median(c(1,2,3,4,10) = 3"
        ttCalculator.SetToolTip(cmdMedian, strTooltipCmdMedian)
        ttCalculator.SetToolTip(cmdListMedian, strTooltipCmdMedian)

        Const strTooltipCmdMode = "the most popular value. So mode(c(10,2,2,3,3) = 2 and 3"
        ttCalculator.SetToolTip(cmdMode, strTooltipCmdMode)
        ttCalculator.SetToolTip(cmdListMode, strTooltipCmdMode)

        Const strTooltipCmdMode1 = "the first mode. So mode1(c(10,2,2,3,3)) = 2"
        ttCalculator.SetToolTip(cmdMode1, strTooltipCmdMode1)
        ttCalculator.SetToolTip(cmdListMode1, strTooltipCmdMode1)

        Const strTooltipCmdVAR = "the variance. The average of the squared deviations from the mean - dividing by (n-1)."
        ttCalculator.SetToolTip(cmdVar, strTooltipCmdVAR)
        ttCalculator.SetToolTip(cmdListVar, strTooltipCmdVAR)

        Const strTooltipCmdSD = "the standard deviation. A typical distance from the mean. Often roughly a quarter of the range of the data."
        ttCalculator.SetToolTip(cmdSd, strTooltipCmdSD)
        ttCalculator.SetToolTip(cmdListSd, strTooltipCmdSD)

        Const strTooltipCmdMad = "the median of the absolute deviations from the median. So mad(c(1,2,3,4,10)) = median of (2,1,0,1,7). Median = 1 and multiplied by 1.483 to be like the sd for normally distributed data."
        ttCalculator.SetToolTip(cmdMad, strTooltipCmdMad)
        ttCalculator.SetToolTip(cmdListMad, strTooltipCmdMad)

        Const strTooltipCmdIQR = "the interquartile range. So, for (1,2,3,4,10) the upper quartile=4, lower=2, so IQR = 2."
        ttCalculator.SetToolTip(cmdIQR, strTooltipCmdIQR)
        ttCalculator.SetToolTip(cmdListIQR, strTooltipCmdIQR)

        Const strTooltipCmdDistinct = "the number of different values in the variable. So distinct(c(1,2,3,3,NA,NA)) = 4."
        ttCalculator.SetToolTip(cmdDistinct, strTooltipCmdDistinct)
        ttCalculator.SetToolTip(cmdListDistinct, strTooltipCmdDistinct)

        Const strTooltipCmdAnyDup = "the row number of the first duplicated value, or 0 if no duplicates. So anydup(c(1,2,3,3,10) = 4."
        ttCalculator.SetToolTip(cmdAnyDup, strTooltipCmdAnyDup)
        ttCalculator.SetToolTip(cmdListAnyDup, strTooltipCmdAnyDup)

        ttCalculator.SetToolTip(cmdMiss, "the number of missing values. So miss(c( NA,2,3,4,NA)) = 2")
        ttCalculator.SetToolTip(cmdNonMiss, "the number of non-missing values. So nonmiss(c(1,2,3,4,NA)) = 4")
        ttCalculator.SetToolTip(cmdDistinct, "the number of different values in the variable. So distinct(c(1,2,3,3,NA,NA)) = 4")
        ttCalculator.SetToolTip(cmdCv, "coefficient of variation, namely 100 * sd/mean. So cv(c(1,2,3,4,10)) = 100*3.536/4 = 88.4.")
        ttCalculator.SetToolTip(cmdMc, "median couple. A robust measure of skewness, between -1 and +1. mc(c(1,1,4,4,5)) = -0.5, while mc(c(2,3,3,4,10)) = 0.375.")
        ttCalculator.SetToolTip(cmdSkew, "skewness defined as third central moment/sd^3. For skew(c(1,1,4,4,5)) = -0.18, while skew(2,3,3,4,10) = 0.95.")
        ttCalculator.SetToolTip(cmdKurtosis, "kurtosis defined as 4th central moment/sd^4 -3. A measure of peakedness which is zero for normally distributed data.")
        ttCalculator.SetToolTip(cmdPropn, "proportion of variable less than (or more than) a specified value. So prop(c(0,1,1,4,10) <=1) = 0.6.")
        ttCalculator.SetToolTip(cmdFirst, "value in the first row. So first(c(NA,7,8,9,10)) is NA. Also first(c(NA,7,8,9,10),order=(2,3,0,1,2)) = 8.")
        ttCalculator.SetToolTip(cmdLast, "value in the last row. So last(c(NA,7,8,9,10)) = 10. Also last(c(NA,7,8,9,10),order=c(2,3,0,1,2)) = 7")
        ttCalculator.SetToolTip(cmdnth, "value in nth row, So nth(c(NA,7,8,9,10)) = 8. Also nth(c(NA,7,7,9,10),3,order=c(2,3,0,1,2))= NA.")
        ttCalculator.SetToolTip(cmdCor, "correlation between 2 variables. It is a value between -1 and +1.")
        ttCalculator.SetToolTip(cmdCov, "covariance between 2 variables.")
        ttCalculator.SetToolTip(cmdQuantile, "a quantile, given a value between 0 and 1. So quantile(c(1,2,3,4,10), 0.25) = 2 and is the lower quartile.")
        ttCalculator.SetToolTip(cmdwhichmax, "Row number of the maximum value. So which.max(c(4,3,10,1,2)) is 3")
        ttCalculator.SetToolTip(cmdwhichmin, "Row number of the minimum value. So which.min(c(4,3,10,1,2)) is 4")
        ttCalculator.SetToolTip(cmdwheremax, "Value of a variable at the which.max position. So for c(""a"",""b"",""c"",""d"",""e""), is ""c"", for the data in which.max tooltip.")
        ttCalculator.SetToolTip(cmdwheremin, "Value of a variable at the which.min position. So for c(""a"",""b"",""c"",""d"",""e""), is ""d"", for the data in which.min tooltip.")
        ttCalculator.SetToolTip(cmdFreqDistinct, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqIQR, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqLength, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMad, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMax, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMean, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMedian, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMin, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMiss, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqMode1, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqPropn, "complete as rep(d > 50, f)) to give the proportion of values in variable d more than 50")
        ttCalculator.SetToolTip(cmdFreqQuantile, "complete as rep(d ,f), prop=0.2), for example, for the 20% point.")
        ttCalculator.SetToolTip(cmdFreqSd, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqSum, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")
        ttCalculator.SetToolTip(cmdFreqVar, "complete the command by rep(d ,f) for data in variable called d and frequencies in f")

        ttCalculator.SetToolTip(cmduniform, "Random sample from the uniform distribution between 0 & 1. Use say runif(n,5,10) to change the range")
        ttCalculator.SetToolTip(cmdRan_normal, "Random sample from the standard normal distribution. Use, say rnorm(n,100,15) to change the mean and sd.")
        ttCalculator.SetToolTip(cmduni_integer, "Random integers between 1 and 5. Use say sample.int(3,n,TRUE,prob=c(6,3,1)) to sample 1 to 3 with defined probabilities.")
        ttCalculator.SetToolTip(cmdbernoulli, "Random Bernoulli (0 or 1) sample. Use say rbinom(n,1,1/6) for a random sample of a given dice value.")
        ttCalculator.SetToolTip(cmdbinomial, "Random binomial sample with values between 0 and 3. Use say rbinom(n,5,prob=0.1) for other distributions.")
        ttCalculator.SetToolTip(cmdpoisson, "Random Poisson sample with mean 1. Change the mean as required.")
        ttCalculator.SetToolTip(cmdnbinomial, "Random geometric sample as given, i.e. number of failures before size=1 success. Change value of size (must remain positive) for other negative binomials.")
        ttCalculator.SetToolTip(cmdRan_gamma, "Random sample with shape=1 is from the exponential distribution with mean 2. Keep scale (>0) = 2 and change shape (>0) to 0.5 for chi-square distribution with 1d.f. or to 5, for 10 d.f. Keep scale = 2 for chi-square.")
        ttCalculator.SetToolTip(cmdRan_beta, "This special case is the uniform distribution between 0 and 1. Change shape1 > 0 and shape2 > 0 for different beta distributions.")
        ttCalculator.SetToolTip(cmdRan_sample, "Random sample with replacement, from a given variable. Change replace to FALSE for a random permutation.")

        ttCalculator.SetToolTip(cmdListMissing, "add the option to omit missing values in the summaries")
        ttCalculator.SetToolTip(cmdListDigitsum, "calculates digit sum of x. For example, DigitSum(12344)= 14")
        ttCalculator.SetToolTip(cmdListAdd, "add a value (default 10) to each number in the list")
        ttCalculator.SetToolTip(cmdListSubtract, "subtract a value (default 10) from each number in the list.")
        ttCalculator.SetToolTip(cmdListMultiply, "multiply each number in the list by a given value (default 10).")
        ttCalculator.SetToolTip(cmdDivide, "divide each value in the list by a given value (default 10).")
        ttCalculator.SetToolTip(cmdListAnyDup, "the observation number of the first duplicated value, or 0 if no duplicates. So anydup(c(1,2,3,3,10) = 4.")
        ttCalculator.SetToolTip(cmdListSquare, "raise each number in the list to a given power (default 2, to square the numbers).")
        ttCalculator.SetToolTip(cmdListFirst, "the first value in each list.")
        ttCalculator.SetToolTip(cmdListLast, "the last value in each list.")
        ttCalculator.SetToolTip(cmdListNth, "the nth value in each list, (default = 2, the second value).")
        ttCalculator.SetToolTip(cmdListQuantile, "default is 20%, 50% (median) and 80% of each list.")
        ttCalculator.SetToolTip(cmdListRound, "applies the round function to each value in each list, with a default of 3 decimal places (change round to signif for significant figures).")
        ttCalculator.SetToolTip(cmdListPercent2, "percent of each value in the list, rounded to a default of 2 decimal places.")
        ttCalculator.SetToolTip(cmdListSQRT, "square root each number in the list. (Change sqrt to abs, log, exp, sin, etc for other functions).")
        ttCalculator.SetToolTip(cmdListSort, "sort values into ascending order.  (Change FALSE to TRUE for descending).")
        ttCalculator.SetToolTip(cmdListRank, "ranks of values with average for tied values.")
        ttCalculator.SetToolTip(cmdListLag, "lag values by one observation, so NA starts each list.")
        ttCalculator.SetToolTip(cmdListLead, "opposite to lag, so NA is last value.")
        ttCalculator.SetToolTip(cmdListDiff, "differences between successive elements.")
        ttCalculator.SetToolTip(cmdListScale, "scale each list, by subtracting the mean and dividing by the sd.")
        ttCalculator.SetToolTip(cmdListCumsum, "cumulative sum of elements in each list. (replace by cummin, cummax, cumprod, or dplyr::cummean for other cumulative functions).")
        ttCalculator.SetToolTip(cmdListMovsum, "moving sum of elements in each list (replace by rollmax, rollmean or rollmedian for others).")
        ttCalculator.SetToolTip(cmdListRev, "reverse the data in each list.")
        ttCalculator.SetToolTip(cmdListOmit, "drop NA values.")
        ttCalculator.SetToolTip(cmdListIfelse, "replace the condition and the TRUE, FALSE values with those of your choice.")
        ttCalculator.SetToolTip(cmdListMod, "gives the remainder from division by 10, or a number you choose.  For example 28 %%8 = 4.")
        ttCalculator.SetToolTip(cmdListDiv, "gives the value after integer division by 10, or a number of your choice.  For example 28 %/% 8 = 3.")
        ttCalculator.SetToolTip(cmdListOperator, "gives TRUE or FALSE depending on the condition.  (Use >=, <, <=, ==, != as well).")
        ttCalculator.SetToolTip(cmdListDuplicated, "gives TRUE for any duplicates and FALSE otherwise.")
        ttCalculator.SetToolTip(cmdListFivenum, "gives the same summaries as the boxplot, so minimum, lower and upper hinges (roughly the quartiles), median, and maximum.")
        ttCalculator.SetToolTip(cmdListSumd, "if the list contains the 2 numbers 34 and 27, then the sum of the digits (individually) is 3 + 4 = 7 and 2 + 7 = 9, so sumd will give 7 + 9 = 16.")
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
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" + ")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" - ")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" * ")
    End Sub

    Private Sub cmdDivide_Click(sender As Object, e As EventArgs) Handles cmdDivide.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" / ")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdGreater_Click(sender As Object, e As EventArgs) Handles cmdGreater.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" > ")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForCalculation.Clear()
        RaiseEvent ClearClick()
    End Sub

    Private Sub ucrChkStoreScalar_Click(sender As Object, e As EventArgs) Handles ucrChkStoreScalar.Click
        RaiseEvent CheckBoxClick()
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
            Case "Functions"
                strPackageName = "ave"
                grpSummary.Visible = False
                grpMaths.Visible = False
                grpLogical.Visible = False
                grpFunctions.Visible = True
                grpBasic.Visible = True
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = True
                Me.Size = New Size(iBasicWidth * 1.4, iBaseHeight)
            Case "Maths"
                strPackageName = "stats"
                grpFunctions.Visible = False
                grpSummary.Visible = False
                grpMaths.Visible = True
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.38, iBaseHeight)
            Case "Logical and Symbols"
                strPackageName = "base"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = True
                grpMaths.Visible = False
                grpBasic.Visible = True
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpHydroGOF.Visible = False
                Me.Size = New Size(iBasicWidth * 1.44, iBaseHeight)
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
            Case "Summary"
                strPackageName = "base"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpSummary.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New Size(iBasicWidth * 1.51, iBaseHeight)
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
            Case "Text/Strings (Character Columns)"
                strPackageName = "stringr"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpTestString.Visible = True
                grpFactor.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                cmdStringRHelp.Visible = True
                cmdWakefieldHelp.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = True
                grpSymbols.Visible = True
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.42, iBaseHeight)
            Case "Factor"
                strPackageName = "base"
                grpFunctions.Visible = False
                grpFactor.Visible = True
                grpDates.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpBasic.Visible = True
                grpTestString.Visible = False
                Me.Size = New Size(iBasicWidth * 1.44, iBaseHeight)
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
            Case "Probability"
                strPackageName = "stats"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpProbabilty.Visible = True
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpTransform.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.57, iBaseHeight)
            Case "Dates/Times"
                strPackageName = "lubridate"
                grpFunctions.Visible = False
                grpDates.Visible = True
                grpProbabilty.Visible = False
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpTransform.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.32, iBaseHeight)
            Case "Transform"
                strPackageName = "dplyr"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = True
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.47, iBaseHeight)
            Case "Wakefield"
                strPackageName = "wakefield"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = True
                grpMaths.Visible = False
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = True
                grpSymbols.Visible = False
                grpModifier.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.8, iBaseHeight)
            Case "Circular"
                strPackageName = "circular"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpCircular.Visible = True
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.39, iBaseHeight)
            Case "Goodness of Fit"
                strPackageName = "hydroGOF"
                grpFunctions.Visible = False
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpHydroGOF.Visible = True
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpTestString.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpFactor.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
                grpCircular.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.25, iBaseHeight)
            Case "Integer"
                strPackageName = "gmp"
                grpFunctions.Visible = False
                grpSummary.Visible = False
                grpMaths.Visible = False
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpTestString.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = True
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.5, iBaseHeight)
            Case "List"
                strPackageName = "base"
                grpFunctions.Visible = False
                grpSummary.Visible = False
                grpMaths.Visible = False
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpTestString.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = True
                cmdRhelpList.Visible = True
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.3, iBaseHeight)
            Case "Complex"
                strPackageName = "base"
                grpFunctions.Visible = False
                grpSummary.Visible = False
                grpMaths.Visible = False
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpTestString.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = True
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth * 1.3, iBaseHeight)
            Case "Basic"
                grpFunctions.Visible = False
                grpSummary.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpTestString.Visible = False
                cmdStringRHelp.Visible = False
                cmdWakefieldHelp.Visible = False
                grpFactor.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpModifier.Visible = False
                grpSymbols.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpComplex.Visible = False
                grpList.Visible = False
                cmdRhelpList.Visible = False
                cmdRhelpFunctions.Visible = False
            Case Else
                grpDates.Visible = False
                grpFunctions.Visible = False
                Me.Size = New Size(iBasicWidth, iBaseHeight)
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpTransform.Visible = False
                grpTestString.Visible = False
                grpFactor.Visible = False
                grpCircular.Visible = False
                grpWakefield.Visible = False
                grpSymbols.Visible = False
                grpModifier.Visible = False
                grpHydroGOF.Visible = False
                grpInteger.Visible = False
                grpList.Visible = False
                iHelpCalcID = 14
        End Select
    End Sub

    Private Sub cmdRound_Click(sender As Object, e As EventArgs) Handles cmdRound.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round(x= , digits=0)", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round( )", 2)
        End If
    End Sub

    Private Sub cmdFloor_Click(sender As Object, e As EventArgs) Handles cmdFloor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("floor(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("floor( )", 2)
        End If
    End Sub

    Private Sub cmdTrunc_Click(sender As Object, e As EventArgs) Handles cmdTrunc.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trunc(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trunc( )", 2)
        End If
    End Sub

    Private Sub cmdSign_Click(sender As Object, e As EventArgs) Handles cmdSign.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sign(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sign( )", 2)
        End If
    End Sub

    Private Sub cmdAcos_Click(sender As Object, e As EventArgs) Handles cmdAcos.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos( )", 2)
        End If
    End Sub

    Private Sub cmdAsin_Click(sender As Object, e As EventArgs) Handles cmdAsin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin( )", 2)
        End If
    End Sub

    Private Sub cmdAtan_Click(sender As Object, e As EventArgs) Handles cmdAtan.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan( )", 2)
        End If
    End Sub

    Private Sub cmdSiginf_Click(sender As Object, e As EventArgs) Handles cmdSiginf.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif(x= , digits=6)", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif()", 2)
        End If
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos( )", 2)
        End If
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin( )", 2)
        End If
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan( )", 2)
        End If
    End Sub

    Private Sub cmdAbs_Click(sender As Object, e As EventArgs) Handles cmdAbs.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("abs(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("abs( )", 2)
        End If
    End Sub

    Private Sub cmdExp_Click_1(sender As Object, e As EventArgs) Handles cmdExp.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp( )", 2)
        End If
    End Sub

    Private Sub cmdLogTen_Click(sender As Object, e As EventArgs) Handles cmdLogTen.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log10(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log10( )", 2)
        End If
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log(x= , base=exp(1))", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log( )", 2)
        End If
    End Sub

    Private Sub cmdSqrt_Click_1(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sqrt(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sqrt( )", 2)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length( )", 2)
        End If
    End Sub

    Private Sub cmdMiss_Click(sender As Object, e As EventArgs) Handles cmdMiss.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na(x= ))", 3)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na( ))", 3)
        End If
    End Sub

    Private Sub cmdSum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdMean_Click(sender As Object, e As EventArgs) Handles cmdMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x = , trim = 0 , na.rm = TRUE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdMax_Click(sender As Object, e As EventArgs) Handles cmdMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max( , na.rm = TRUE)", 15)
        End If
    End Sub

    Private Sub cmdMin_Click(sender As Object, e As EventArgs) Handles cmdMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdMedian_Click(sender As Object, e As EventArgs) Handles cmdMedian.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdVar_Click(sender As Object, e As EventArgs) Handles cmdVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var(x = , y = NULL, na.rm = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdSd_Click(sender As Object, e As EventArgs) Handles cmdSd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdRange_Click(sender As Object, e As EventArgs) Handles cmdRange.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range(x = , na.rm = TRUE, finite = FALSE)", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdQuantile_Click(sender As Object, e As EventArgs) Handles cmdQuantile.Click
        Dim clsQuantileFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsQuantileFunction.SetRCommand("quantile")
        clsQuantileFunction.AddParameter("x", "", iPosition:=0)
        clsQuantileFunction.AddParameter("probs", "0.5", iPosition:=1)
        clsQuantileFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
        clsQuantileFunction.AddParameter("names", "FALSE", iPosition:=3)
        clsQuantileFunction.AddParameter("type", "7", iPosition:=4)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsQuantileFunction, iPosition:=0)
        clsRepFunction.AddParameter("len", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 66)
    End Sub

    Private Sub cmdIQR_Click(sender As Object, e As EventArgs) Handles cmdIQR.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR(x = , na.rm = TRUE, type = 7)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdUpper_Click(sender As Object, e As EventArgs) Handles cmdUpper.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_upper(string = , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_upper()", 2)
        End If
    End Sub

    Private Sub cmdLower_Click(sender As Object, e As EventArgs) Handles cmdLower.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_lower(string= , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_lower( )", 2)
        End If
    End Sub

    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_title(string= , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_title( )", 2)
        End If
    End Sub

    Private Sub cmdTrim_Click(sender As Object, e As EventArgs) Handles cmdTrim.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trim(string= , side = c('both', 'left', 'right))", 35)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trim( )", 2)
        End If
    End Sub

    Private Sub cmdPad_Click(sender As Object, e As EventArgs) Handles cmdPad.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad(string = , width = , side = c('left', 'right', 'both') , pad = )", 56)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad( )", 2)
        End If
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order(x = , decreasing = FALSE , na_last = TRUE)", 40)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order( )", 2)
        End If
    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort(x= , decreasing = FALSE , na_last = TRUE , locale = ' ')", 53)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort( )", 2)
        End If
    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace(string = , pattern = argument , replacement = ' ' )", 43)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace( )", 2)
        End If
    End Sub

    Private Sub cmdLocate_Click(sender As Object, e As EventArgs) Handles cmdLocate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate(string = , pattern = argument)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate( )", 2)
        End If
    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract(string = , pattern = argument )", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract( )", 2)
        End If
    End Sub

    Private Sub cmdCountstrings_Click(sender As Object, e As EventArgs) Handles cmdCountstrings.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_count(string = , pattern = argument )", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_count( )", 2)
        End If

    End Sub

    Private Sub cmdDetect_Click(sender As Object, e As EventArgs) Handles cmdDetect.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect(string = , pattern = , negate = FALSE)", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect( )", 2)
        End If
    End Sub

    Private Sub cmdQnorm_Click(sender As Object, e As EventArgs) Handles cmdQnorm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm(p= , mean = 0, sd = 1, lower.tail = TRUE, log.p = FALSE)", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm( )", 2)
        End If
    End Sub

    Private Sub cmdQt_Click(sender As Object, e As EventArgs) Handles cmdQt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt(p= , df= , lower.tail = TRUE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt(, )", 3)
        End If
    End Sub

    Private Sub cmdQchisq_Click(sender As Object, e As EventArgs) Handles cmdQchisq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq(p= , df= , lower.tail = TRUE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq(, )", 3)
        End If
    End Sub

    Private Sub cmdqF_Click(sender As Object, e As EventArgs) Handles cmdqF.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf(p= , df1= , df2= ,lower.tail = TRUE)", 34)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf(, , )", 5)
        End If
    End Sub

    Private Sub cmdPnorm_Click(sender As Object, e As EventArgs) Handles cmdPnorm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnorm(q= , mean = 0, sd = 1, lower.tail = True, Log.p = False)", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnorm( )", 2)
        End If
    End Sub

    Private Sub cmdPt_Click(sender As Object, e As EventArgs) Handles cmdPt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt(q= , df= , lower.tail = TRUE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt(, )", 3)
        End If
    End Sub

    Private Sub cmdPChisq_Click(sender As Object, e As EventArgs) Handles cmdPChisq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= , lower.tail = TRUE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(, )", 3)
        End If
    End Sub

    Private Sub cmdPf_Click(sender As Object, e As EventArgs) Handles cmdPf.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pf(q= , df1= ,df2=, lower.tail = TRUE)", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pf(, , )", 5)
        End If
    End Sub

    Private Sub cmdChoose_Click(sender As Object, e As EventArgs) Handles cmdChoose.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("choose(n= , k= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("choose(, )", 3)
        End If
    End Sub

    Private Sub cmdFact_Click(sender As Object, e As EventArgs) Handles cmdFact.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("factorial(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("factorial( )", 2)
        End If
    End Sub

    Private Sub cmdBeta_Click(sender As Object, e As EventArgs) Handles cmdBeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("beta(a= , b= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("beta(, )", 3)
        End If
    End Sub

    Private Sub cmdLchoose_Click(sender As Object, e As EventArgs) Handles cmdLchoose.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lchoose(n= , k= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lchoose(, )", 3)
        End If
    End Sub

    Private Sub cmdLfact_Click(sender As Object, e As EventArgs) Handles cmdLfact.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lfactorial(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lfactorial( )", 2)
        End If
    End Sub

    Private Sub cmdLbeta_Click(sender As Object, e As EventArgs) Handles cmdLbeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lbeta(a= , b= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lbeta(, )", 3)
        End If
    End Sub

    Private Sub cmdGamma_Click(sender As Object, e As EventArgs) Handles cmdGamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gamma(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gamma( )", 2)
        End If
    End Sub

    Private Sub cmdLgamma_Click(sender As Object, e As EventArgs) Handles cmdLgamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lgamma(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lgamma( )", 2)
        End If
    End Sub

    Private Sub cmdDigamma_Click(sender As Object, e As EventArgs) Handles cmdDigamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digamma(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digamma( )", 2)
        End If
    End Sub

    Private Sub cmdTrigamma_Click(sender As Object, e As EventArgs) Handles cmdTrigamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trigamma(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trigamma( )", 2)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_c( )", 2)
        End If
    End Sub

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSub.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sub(string="""", start = 1L, end = -1L)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sub( )", 2)
        End If
    End Sub

    Private Sub cmdYear_Click(sender As Object, e As EventArgs) Handles cmdYear.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::year(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::year( )", 2)
        End If
    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs) Handles cmdMonth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::month(x= , label=FALSE, abbr=TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::month( )", 2)
        End If
    End Sub

    Private Sub cmdDay_Click(sender As Object, e As EventArgs) Handles cmdDay.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::day(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::day( )", 2)
        End If
    End Sub

    Private Sub cmdWday_Click(sender As Object, e As EventArgs) Handles cmdWday.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::wday(x= , label=FALSE, abbr=TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::wday( )", 2)
        End If
    End Sub

    Private Sub cmdYday_Click(sender As Object, e As EventArgs) Handles cmdYday.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::yday(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::yday( )", 2)
        End If
    End Sub

    Private Sub cmdDate_Click(sender As Object, e As EventArgs) Handles cmdDate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::date(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::date( )", 2)
        End If
    End Sub

    Private Sub cmdAsDate_Click(sender As Object, e As EventArgs) Handles cmdAsDate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::as_date(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::as_date( )", 2)
        End If
    End Sub

    Private Sub cmdYmdHms_Click(sender As Object, e As EventArgs) Handles cmdYmdHms.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd_hms(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd_hms( )", 2)
        End If
    End Sub

    Private Sub cmdYmdHm_Click(sender As Object, e As EventArgs) Handles cmdYmdHm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd_hm(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd_hm( )", 2)
        End If
    End Sub

    Private Sub cmdYmdH_Click(sender As Object, e As EventArgs) Handles cmdYmdH.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd_h(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd_h( )", 2)
        End If
    End Sub

    Private Sub cmdLeap_Click(sender As Object, e As EventArgs) Handles cmdLeap.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::leap_year(date= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::leap_year( )", 2)
        End If
    End Sub

    Private Sub cmdYmd_Click(sender As Object, e As EventArgs) Handles cmdYmd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd( )", 2)
        End If
    End Sub

    Private Sub cmdMdy_Click(sender As Object, e As EventArgs) Handles cmdMdy.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::mdy(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::mdy( )", 2)
        End If
    End Sub

    Private Sub cmdDmy_Click(sender As Object, e As EventArgs) Handles cmdDmy.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::dmy(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::dmy( )", 2)
        End If
    End Sub

    Private Sub cmdHour_Click(sender As Object, e As EventArgs) Handles cmdHour.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::hour(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::hour( )", 2)
        End If
    End Sub

    Private Sub cmdMinutes_Click(sender As Object, e As EventArgs) Handles cmdMinutes.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::minute(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::minute( )", 2)
        End If
    End Sub

    Private Sub cmdSec_Click(sender As Object, e As EventArgs) Handles cmdSec.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::second(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::second( )", 2)
        End If
    End Sub

    Private Sub cmdAm_Click(sender As Object, e As EventArgs) Handles cmdAm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::am(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::am( )", 2)
        End If
    End Sub

    Private Sub cmdPm_Click(sender As Object, e As EventArgs) Handles cmdPm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::pm(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::pm( )", 2)
        End If
    End Sub

    Private Sub cmdD_In_M_Click(sender As Object, e As EventArgs) Handles cmdD_In_M.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::days_in_month(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::days_in_month( )", 2)
        End If
    End Sub

    Private Sub cmdQuarter_Click(sender As Object, e As EventArgs) Handles cmdQuarter.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::quarter(x= , with_year = FALSE, fiscal_start = 1 )", 40)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::quarter( )", 2)
        End If
    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("( )", 2)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lag(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lag( )", 2)
        End If
    End Sub

    Private Sub cmdLead_Click(sender As Object, e As EventArgs) Handles cmdLead.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lead(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lead( )", 2)
        End If
    End Sub

    Private Sub cmdpmax_Click(sender As Object, e As EventArgs) Handles cmdPMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmax(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmax( )", 2)
        End If
    End Sub

    Private Sub cmdPMin_Click(sender As Object, e As EventArgs) Handles cmdPMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmin(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmin( )", 2)
        End If
    End Sub

    Private Sub cmdcummax_Click(sender As Object, e As EventArgs) Handles cmdCumMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax( )", 2)
        End If
    End Sub

    Private Sub cmdcummin_Click(sender As Object, e As EventArgs) Handles cmdCumMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin( )", 2)
        End If
    End Sub

    Private Sub cmdcumsum_Click(sender As Object, e As EventArgs) Handles cmdCumSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum( )", 2)
        End If
    End Sub

    Private Sub cmdpercentrank_Click(sender As Object, e As EventArgs) Handles cmdPercentRank.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank(x= )*100", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank( )*100", 6)
        End If
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        RaiseEvent SelectionChanged()
    End Sub

    Private Sub OpenHelpPage()
        If strPackageName <> "" Then
            frmMaximiseOutput.Show(strFileName:=clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName), bReplace:=False)
        End If
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs)
        RaiseEvent TryCommadClick()
    End Sub

    Public Sub SetAsCurrentReceiver()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
    End Sub

    Private Sub cmdDiff_Click(sender As Object, e As EventArgs) Handles cmdDiff.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(NA, diff(x= , lag = 1, differences = 1))", 29)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(NA,diff(x= , lag = 1, differences = 1))", 29)
        End If
    End Sub

    Private Sub cmdEcdf_Click(sender As Object, e As EventArgs) Handles cmdCumdist.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cume_dist( )*100", 6)
    End Sub

    Private Sub cmdNtile_Click(sender As Object, e As EventArgs) Handles cmdNtile.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::ntile(x= ,n=2)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::ntile( )", 2)
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
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::min_rank( )", 2)
    End Sub

    Private Sub cmdmovemean_Click(sender As Object, e As EventArgs) Handles cmdMovMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmean(x = , k=3, fill = NA, na.pad = FALSE, align = c(""center"", ""left"", ""right""))", 72)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmean( ,k = 3, fill = NA)", 19)
        End If
    End Sub

    Private Sub cmdCumMean_Click(sender As Object, e As EventArgs) Handles cmdCumMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cummean(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cummean( )", 2)
        End If
    End Sub

    Private Sub cmdDRank_Click(sender As Object, e As EventArgs) Handles cmdDRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::dense_rank( )", 2)
    End Sub

    Private Sub cmdRank_Click(sender As Object, e As EventArgs) Handles cmdRank.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rank(x= ,na.last=TRUE,ties.method=c(""average"", ""first"", ""last"", ""random"", ""max"", ""min""))", 81)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rank( )", 2)
        End If
    End Sub

    Private Sub cmdRescale_Click(sender As Object, e As EventArgs) Handles cmdRescale.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("scales::rescale( ,to=c(0,1),narm=TRUE)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("scales::rescale( ,narm=TRUE)", 12)
        End If
    End Sub

    Private Sub cmdRowRank_Click(sender As Object, e As EventArgs) Handles cmdRowRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::row_number( )", 2)
    End Sub

    Private Sub cmdIfelse_Click(sender As Object, e As EventArgs) Handles cmdIfelse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ifelse(test= , ""yes"" , ""no"")", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ifelse( )", 2)
        End If
    End Sub

    Private Sub cmdmatch_Click(sender As Object, e As EventArgs) Handles cmdmatch.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("match( )", 2)
    End Sub

    Private Sub cmdwhen_Click(sender As Object, e As EventArgs) Handles cmdwhen.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::case_when( )", 2)
    End Sub

    Private Sub cmdBetween_Click(sender As Object, e As EventArgs) Handles cmdBetween.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::between( )", 2)
    End Sub

    Private Sub cmdNear_Click(sender As Object, e As EventArgs) Handles cmdNear.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::near(x= , y= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::near( )", 2)
        End If
    End Sub

    Private Sub cmdCalcRepelicationFunction_Click(sender As Object, e As EventArgs) Handles cmdCalcRepelicationFunction.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rep(x = , times = , length = , each = )", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rep( )", 2)
        End If
    End Sub

    Private Sub cmdCalcSequenceFunction_Click(sender As Object, e As EventArgs) Handles cmdCalcSequenceFunction.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("seq(from = , to = , by = , length =  )", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("seq( )", 2)
        End If
    End Sub

    Private Sub cmdCalcConcantenateFunction_Click(sender As Object, e As EventArgs) Handles cmdCalcConcantenateFunction.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c( , recursive = FALSE)", 21)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c( )", 2)
        End If
    End Sub

    Private Sub cmdnumeric_Click(sender As Object, e As EventArgs) Handles cmdnumeric.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.numeric(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.numeric( )", 2)
        End If
    End Sub

    Private Sub cmdLogit_Click(sender As Object, e As EventArgs) Handles cmdLogit.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("car::logit(p, percents = Range.p[2] > 1, adjust)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("car::logit( )", 2)
        End If
    End Sub

    Private Sub cmdLogistic_Click(sender As Object, e As EventArgs) Handles cmdLogistic.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::plogis(q, Location = 0, Scale() = 1, lower.tail = True, Log.p = False))", 50)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::plogis( )", 2)
        End If
    End Sub
    Private Sub cmdAtan2_Click(sender As Object, e As EventArgs) Handles cmdAtan2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan2(y= ,x= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan2( )", 2)
        End If
    End Sub

    Private Sub cmdDuplicate_Click(sender As Object, e As EventArgs) Handles cmdDuplicate.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("duplicated( )", 2)
    End Sub

    Private Sub cmdIsNa_Click(sender As Object, e As EventArgs) Handles cmdIsNa.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("is.na( )", 2)
    End Sub

    Private Sub cmdNotIsNa_Click(sender As Object, e As EventArgs) Handles cmdNotIsNa.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("!is.na( )", 2)
    End Sub

    Private Sub cmdCv_Click(sender As Object, e As EventArgs) Handles cmdCv.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("raster::cv(x = , aszero = FALSE, na.rm = TRUE)", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("raster::cv( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdMad_Click(sender As Object, e As EventArgs) Handles cmdMad.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::mad(x = , center = median(x = ), constant = 1.4826, na.rm = TRUE,low = FALSE, high = FALSE)", 84)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::mad( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdMc_Click(sender As Object, e As EventArgs) Handles cmdMc.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("robustbase::mc(x = , na.rm = TRUE, doReflect = (length(x = ) <= 100),doScale = TRUE, maxit= 100, trace.lev= 0, full.result= FALSE)", 113)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("robustbase::mc( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdNonMiss_Click(sender As Object, e As EventArgs) Handles cmdNonMiss.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(!is.na(x= ))", 3)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(!is.na( ))", 3)
        End If
    End Sub

    Private Sub cmdSkew_Click(sender As Object, e As EventArgs) Handles cmdSkew.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::skewness(x = , na.rm = TRUE, type = 3)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::skewness( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdPropn_Click(sender As Object, e As EventArgs) Handles cmdPropn.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x= <=1, na.rm = TRUE)", 18)
    End Sub

    Private Sub cmdDistinct_Click(sender As Object, e As EventArgs) Handles cmdDistinct.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::n_distinct( )", 2)
    End Sub

    Private Sub cmdAnyDup_Click(sender As Object, e As EventArgs) Handles cmdAnyDup.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("anyDuplicated( )", 2)
    End Sub

    Private Sub cmdCor_Click(sender As Object, e As EventArgs) Handles cmdCor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cor(x= , y= , use = ""na"", method = c(""pearson"", ""kendall"", ""spearman""))", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cor(x = , y = , use = ""na"")", 19)
        End If
    End Sub

    Private Sub cmdCov_Click(sender As Object, e As EventArgs) Handles cmdCov.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cov(x= , y= , use = ""na"", method = c(""pearson"", ""kendall"", ""spearman""))", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cov(x = , y = , use = ""na"")", 19)
        End If
    End Sub

    Private Sub cmdRad_Click(sender As Object, e As EventArgs) Handles cmdRad.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rad( )", 2)
    End Sub

    Private Sub cmdDeg_Click(sender As Object, e As EventArgs) Handles cmdDeg.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::deg( )", 2)
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::first(x= , order_by=NULL)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::first( )", 2)
        End If
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::last(x= , order_by=NULL)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::last( )", 2)
        End If
    End Sub

    Private Sub cmdnth_Click(sender As Object, e As EventArgs) Handles cmdnth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::nth(x= , n= , order_by=NULL)", 21)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::nth( )", 2)
        End If
    End Sub

    Private Sub cmdMode_Click(sender As Object, e As EventArgs) Handles cmdMode.Click
        Dim clsSummaryModeFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsSummaryModeFunction.SetPackageName("statip")
        clsSummaryModeFunction.SetRCommand("mfv")
        clsSummaryModeFunction.AddParameter("x", "", iPosition:=0)
        clsSummaryModeFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSummaryModeFunction, iPosition:=0)
        clsRepFunction.AddParameter("len", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 34)
    End Sub

    Private Sub cmdNA_Click(sender As Object, e As EventArgs) Handles cmdNA.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("NA")
    End Sub

    Private Sub cmdWhich_Click(sender As Object, e As EventArgs) Handles cmdWhich.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which(x= , arr.ind = FALSE, useNames = TRUE)", 35)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which( )", 2)
        End If
    End Sub

    Private Sub cmdIn_Click(sender As Object, e As EventArgs) Handles cmdIn.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" %in% ")
    End Sub

    Private Sub cmdTilde_Click(sender As Object, e As EventArgs) Handles cmdTilde.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("~")
    End Sub

    Private Sub cmdTrue_Click(sender As Object, e As EventArgs) Handles cmdTrue.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("TRUE")
    End Sub

    Private Sub cmdFalse_Click(sender As Object, e As EventArgs) Handles cmdFalse.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("FALSE")
    End Sub

    Private Sub cmdAge_Click(sender As Object, e As EventArgs) Handles cmdAge.Click
        Dim clsWakefieldAgeFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldAgeFunction.SetPackageName("wakefield")
        clsWakefieldAgeFunction.SetRCommand("age")
        clsWakefieldAgeFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldAgeFunction.AddParameter("x", "20:35", iPosition:=1)
        clsWakefieldAgeFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldAgeFunction.AddParameter("name", Chr(34) & "Age" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldAgeFunction.ToScript, 0)
    End Sub

    Private Sub cmdAnimal_Click(sender As Object, e As EventArgs) Handles cmdAnimal.Click
        Dim clsWakefieldAnimalFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldAnimalFunction.SetPackageName("wakefield")
        clsWakefieldAnimalFunction.SetRCommand("animal")
        clsWakefieldAnimalFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldAnimalFunction.AddParameter("k", "10", iPosition:=1)
        clsWakefieldAnimalFunction.AddParameter("x", "wakefield::animal_list", iPosition:=2)
        clsWakefieldAnimalFunction.AddParameter("prob", "NULL", iPosition:=3)
        clsWakefieldAnimalFunction.AddParameter("name", Chr(34) & "Animal" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldAnimalFunction.ToScript, 0)
    End Sub

    Private Sub cmdPet_Click(sender As Object, e As EventArgs) Handles cmdPet.Click
        Dim clsWakefieldPetFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsPetListFunction As New RFunction
        Dim clsPetProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsPetListFunction.SetRCommand("c")
        clsPetListFunction.AddParameter("d", Chr(34) & "Dog" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPetListFunction.AddParameter("c", Chr(34) & "Cat" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsPetListFunction.AddParameter("n", Chr(34) & "None" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsPetListFunction.AddParameter("b", Chr(34) & "Bird" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsPetListFunction.AddParameter("h", Chr(34) & "Horse" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsPetProbFunction.SetRCommand("c")
        clsPetProbFunction.AddParameter("0.365", "0.365", iPosition:=0, bIncludeArgumentName:=False)
        clsPetProbFunction.AddParameter("0.304", "0.304", iPosition:=1, bIncludeArgumentName:=False)
        clsPetProbFunction.AddParameter("0.258", "0.258", iPosition:=2, bIncludeArgumentName:=False)
        clsPetProbFunction.AddParameter("0.031", "0.031", iPosition:=3, bIncludeArgumentName:=False)
        clsPetProbFunction.AddParameter("0.015", "0.015", iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldPetFunction.SetPackageName("wakefield")
        clsWakefieldPetFunction.SetRCommand("pet")
        clsWakefieldPetFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldPetFunction.AddParameter("x", clsRFunctionParameter:=clsPetListFunction, iPosition:=1)
        clsWakefieldPetFunction.AddParameter("prob", clsRFunctionParameter:=clsPetProbFunction, iPosition:=2)
        clsWakefieldPetFunction.AddParameter("name", Chr(34) & "Pet" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldPetFunction.ToScript, 0)
    End Sub

    Private Sub cmdAnswer_Click(sender As Object, e As EventArgs) Handles cmdAnswer.Click
        Dim clsWakefieldAnswerFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsAnswerListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsAnswerListFunction.SetRCommand("c")
        clsAnswerListFunction.AddParameter("no", Chr(34) & "No" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsAnswerListFunction.AddParameter("yes", Chr(34) & "Yes" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsWakefieldAnswerFunction.SetPackageName("wakefield")
        clsWakefieldAnswerFunction.SetRCommand("answer")
        clsWakefieldAnswerFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldAnswerFunction.AddParameter("x", clsRFunctionParameter:=clsAnswerListFunction, iPosition:=1)
        clsWakefieldAnswerFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldAnswerFunction.AddParameter("name", Chr(34) & "Answer" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldAnswerFunction.ToScript, 0)
    End Sub

    Private Sub cmdCar_Click(sender As Object, e As EventArgs) Handles cmdCar.Click
        Dim clsWakefieldCarFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsRowNameFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsRowNameFunction.SetRCommand("rownames")
        clsRowNameFunction.AddParameter("x", "datasets::mtcars", iPosition:=0, bIncludeArgumentName:=False)

        clsWakefieldCarFunction.SetPackageName("wakefield")
        clsWakefieldCarFunction.SetRCommand("car")
        clsWakefieldCarFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldCarFunction.AddParameter("x", clsRFunctionParameter:=clsRowNameFunction, iPosition:=1)
        clsWakefieldCarFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldCarFunction.AddParameter("name", Chr(34) & "Car" & Chr(34))

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldCarFunction.ToScript, 0)
    End Sub

    Private Sub cmdChildren_Click(sender As Object, e As EventArgs) Handles cmdChildren.Click
        Dim clsWakefieldChildrenFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsChildrenProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsChildrenProbFunction.SetRCommand("c")
        clsChildrenProbFunction.AddParameter("0.25", "0.25", iPosition:=0, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.26", "0.25", iPosition:=1, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.15", "0.15", iPosition:=2, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.16", "0.15", iPosition:=3, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.1", "0.1", iPosition:=4, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.02", "0.02", iPosition:=5, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.03", "0.02", iPosition:=6, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.04", "0.02", iPosition:=7, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.05", "0.02", iPosition:=8, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.01", "0.01", iPosition:=9, bIncludeArgumentName:=False)
        clsChildrenProbFunction.AddParameter("0.06", "0.01", iPosition:=10, bIncludeArgumentName:=False)

        clsWakefieldChildrenFunction.SetPackageName("wakefield")
        clsWakefieldChildrenFunction.SetRCommand("children")
        clsWakefieldChildrenFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldChildrenFunction.AddParameter("x", "0:10", iPosition:=1)
        clsWakefieldChildrenFunction.AddParameter("prob", clsRFunctionParameter:=clsChildrenProbFunction, iPosition:=2)
        clsWakefieldChildrenFunction.AddParameter("name", Chr(34) & "Children" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldChildrenFunction.ToScript, 0)
    End Sub

    Private Sub cmdCoin_Click(sender As Object, e As EventArgs) Handles cmdCoin.Click
        Dim clsWakefieldCoinFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsCoinListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsCoinListFunction.SetRCommand("c")
        clsCoinListFunction.AddParameter("head", Chr(34) & "Heads" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsCoinListFunction.AddParameter("tail", Chr(34) & "Tails" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsWakefieldCoinFunction.SetPackageName("wakefield")
        clsWakefieldCoinFunction.SetRCommand("coin")
        clsWakefieldCoinFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldCoinFunction.AddParameter("x", clsRFunctionParameter:=clsCoinListFunction, iPosition:=1)
        clsWakefieldCoinFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldCoinFunction.AddParameter("name", Chr(34) & "Coin" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldCoinFunction.ToScript, 0)
    End Sub

    Private Sub cmdColor_Click(sender As Object, e As EventArgs) Handles cmdColor.Click
        Dim clsWakefieldColorFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsColorListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsColorListFunction.SetPackageName("grDevices")
        clsColorListFunction.SetRCommand("colors")

        clsWakefieldColorFunction.SetPackageName("wakefield")
        clsWakefieldColorFunction.SetRCommand("color")
        clsWakefieldColorFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldColorFunction.AddParameter("x", clsRFunctionParameter:=clsColorListFunction, iPosition:=1)
        clsWakefieldColorFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldColorFunction.AddParameter("name", Chr(34) & "Color" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldColorFunction.ToScript, 0)
    End Sub

    Private Sub cmdPrimary_Click(sender As Object, e As EventArgs) Handles cmdPrimary.Click
        Dim clsWakefieldPrimaryFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsColorListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsColorListFunction.SetRCommand("c")
        clsColorListFunction.AddParameter("r", Chr(34) & "Red" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsColorListFunction.AddParameter("g", Chr(34) & "Green" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsColorListFunction.AddParameter("b", Chr(34) & "Blue" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsColorListFunction.AddParameter("y", Chr(34) & "Yellow" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsColorListFunction.AddParameter("bl", Chr(34) & "Black" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsColorListFunction.AddParameter("w", Chr(34) & "White" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)

        clsWakefieldPrimaryFunction.SetPackageName("wakefield")
        clsWakefieldPrimaryFunction.SetRCommand("primary")
        clsWakefieldPrimaryFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldPrimaryFunction.AddParameter("x", clsRFunctionParameter:=clsColorListFunction, iPosition:=1)
        clsWakefieldPrimaryFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldPrimaryFunction.AddParameter("name", Chr(34) & "Color" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldPrimaryFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefieldDates_Click(sender As Object, e As EventArgs) Handles cmdWakefieldDates.Click
        Dim clsWakefieldDateStampFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsStartDateFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsStartDateFunction.SetRCommand("Sys.Date")

        clsWakefieldDateStampFunction.SetPackageName("wakefield")
        clsWakefieldDateStampFunction.SetRCommand("date_stamp")
        clsWakefieldDateStampFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldDateStampFunction.AddParameter("random", "FALSE", iPosition:=1)
        clsWakefieldDateStampFunction.AddParameter("x", "NULL", iPosition:=2)
        clsWakefieldDateStampFunction.AddParameter("start", clsRFunctionParameter:=clsStartDateFunction, iPosition:=3)
        clsWakefieldDateStampFunction.AddParameter("k", 12, iPosition:=4)
        clsWakefieldDateStampFunction.AddParameter("by", Chr(34) & "-1 months" & Chr(34), iPosition:=5)
        clsWakefieldDateStampFunction.AddParameter("prob", "NULL", iPosition:=6)
        clsWakefieldDateStampFunction.AddParameter("name", Chr(34) & "Date" & Chr(34), iPosition:=7)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDateStampFunction.ToScript, 0)
    End Sub

    Private Sub cmdDeath_Click(sender As Object, e As EventArgs) Handles cmdDeath.Click
        Dim clsWakefieldDeathFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldDeathFunction.SetPackageName("wakefield")
        clsWakefieldDeathFunction.SetRCommand("death")
        clsWakefieldDeathFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldDeathFunction.AddParameter("prob", "NULL", iPosition:=1)
        clsWakefieldDeathFunction.AddParameter("name", Chr(34) & "Death" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDeathFunction.ToScript, 0)
    End Sub

    Private Sub cmdGrade_Letter_Click(sender As Object, e As EventArgs) Handles cmdGrade_Letter.Click
        Dim clsWakefieldgrade_letterFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldgrade_letterFunction.SetPackageName("wakefield")
        clsWakefieldgrade_letterFunction.SetRCommand("grade_letter")
        clsWakefieldgrade_letterFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldgrade_letterFunction.AddParameter("mean", "88", iPosition:=1)
        clsWakefieldgrade_letterFunction.AddParameter("sd", "4", iPosition:=2)
        clsWakefieldgrade_letterFunction.AddParameter("name", Chr(34) & "Grade_Letter" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldgrade_letterFunction.ToScript, 0)
    End Sub

    Private Sub cmdDice_Click(sender As Object, e As EventArgs) Handles cmdDice.Click
        Dim clsWakefieldDiceFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldDiceFunction.SetPackageName("wakefield")
        clsWakefieldDiceFunction.SetRCommand("dice")
        clsWakefieldDiceFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldDiceFunction.AddParameter("x", "1:6", iPosition:=1)
        clsWakefieldDiceFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldDiceFunction.AddParameter("name", Chr(34) & "Dice" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDiceFunction.ToScript, 0)
    End Sub

    Private Sub cmdDna_Click(sender As Object, e As EventArgs) Handles cmdDna.Click
        Dim clsWakefieldDnaFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsDNAListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsDNAListFunction.SetRCommand("c")
        clsDNAListFunction.AddParameter("G", Chr(34) & "Guanine" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsDNAListFunction.AddParameter("A", Chr(34) & "Adenine" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsDNAListFunction.AddParameter("T", Chr(34) & "Thymine" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsDNAListFunction.AddParameter("C", Chr(34) & "Cytosine" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)

        clsWakefieldDnaFunction.SetPackageName("wakefield")
        clsWakefieldDnaFunction.SetRCommand("dna")
        clsWakefieldDnaFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldDnaFunction.AddParameter("x", clsRFunctionParameter:=clsDNAListFunction, iPosition:=1)
        clsWakefieldDnaFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldDnaFunction.AddParameter("name", Chr(34) & "DNA" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDnaFunction.ToScript, 0)
    End Sub

    Private Sub cmdDob_Click(sender As Object, e As EventArgs) Handles cmdDob.Click
        Dim clsWakefieldDobFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsDOBDateFunction As New RFunction
        Dim clsDobSubtractOperator As New ROperator
        Dim clsDobMultiplyOperator As New ROperator

        clsDOBDateFunction.SetRCommand("Sys.Date")
        clsDobMultiplyOperator.SetOperation("*")
        clsDobMultiplyOperator.AddParameter("x", "365", iPosition:=0, bIncludeArgumentName:=False)
        clsDobMultiplyOperator.AddParameter("y", "15", iPosition:=1, bIncludeArgumentName:=False)
        clsDobSubtractOperator.SetOperation("-")
        clsDobSubtractOperator.AddParameter("x", clsRFunctionParameter:=clsDOBDateFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsDobSubtractOperator.AddParameter("y", clsROperatorParameter:=clsDobMultiplyOperator, bIncludeArgumentName:=False)

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)
        clsWakefieldDobFunction.AddParameter("random", "TRUE", iPosition:=1)
        clsWakefieldDobFunction.AddParameter("x", "NULL", iPosition:=2)
        clsWakefieldDobFunction.AddParameter("start", clsROperatorParameter:=clsDobSubtractOperator, iPosition:=3)
        clsWakefieldDobFunction.AddParameter("k", "365*2", iPosition:=4)
        clsWakefieldDobFunction.AddParameter("by", Chr(34) & "1 days" & Chr(34), iPosition:=5)
        clsWakefieldDobFunction.AddParameter("prob", "NULL", iPosition:=6)
        clsWakefieldDobFunction.AddParameter("name", Chr(34) & "DOB" & Chr(34), iPosition:=7)

        clsWakefieldDobFunction.SetPackageName("wakefield")
        clsWakefieldDobFunction.SetRCommand("dob")
        clsWakefieldDobFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDobFunction.ToScript, 0)
    End Sub

    Private Sub cmdDummy_Click(sender As Object, e As EventArgs) Handles cmdDummy.Click
        Dim clsWakefieldDummyFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldDummyFunction.SetPackageName("wakefield")
        clsWakefieldDummyFunction.SetRCommand("dummy")
        clsWakefieldDummyFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldDummyFunction.AddParameter("prob", "NULL", iPosition:=1)
        clsWakefieldDummyFunction.AddParameter("name", Chr(34) & "Dummy" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDummyFunction.ToScript, 0)
    End Sub

    Private Sub cmdEducation_Click(sender As Object, e As EventArgs) Handles cmdEducation.Click
        Dim clsWakefieldEducationFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsEducationListFunction As New RFunction
        Dim clsEducationProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsEducationListFunction.SetRCommand("c")
        clsEducationListFunction.AddParameter("nsc", Chr(34) & "No Schooling Completed" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("ns8", Chr(34) & "Nursery School To 8th Grade" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("9-12", Chr(34) & "9th Grade To 12th Grade,No Diploma" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("rhc", Chr(34) & "Regular High School Diploma" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("ged", Chr(34) & "GED or Alternative Credential" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("sc1", Chr(34) & "Some College,Less Than 1 Year" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("scn", Chr(34) & "Some College,1 orMore Years, No Degree" & Chr(34), iPosition:=6, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("ad", Chr(34) & "Associate's Degree" & Chr(34), iPosition:=7, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("bd", Chr(34) & "Bachelor's Degree" & Chr(34), iPosition:=8, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("md", Chr(34) & "Master's Degree" & Chr(34), iPosition:=9, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("psc", Chr(34) & "Professional School Degree" & Chr(34), iPosition:=10, bIncludeArgumentName:=False)
        clsEducationListFunction.AddParameter("dd", Chr(34) & "Doctorate's Degree" & Chr(34), iPosition:=11, bIncludeArgumentName:=False)

        clsEducationProbFunction.SetRCommand("c")
        clsEducationProbFunction.AddParameter("0.013", "0.013", iPosition:=0, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.05", "0.05", iPosition:=1, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.0850", "0.0850", iPosition:=2, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.246", "0.246", iPosition:=3, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.039", "0.039", iPosition:=4, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.064", "0.064", iPosition:=5, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.15", "0.15", iPosition:=6, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.075", "0.075", iPosition:=7, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.176", "0.176", iPosition:=8, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.072", "0.072", iPosition:=9, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.019", "0.019", iPosition:=10, bIncludeArgumentName:=False)
        clsEducationProbFunction.AddParameter("0.012", "0.012", iPosition:=11, bIncludeArgumentName:=False)

        clsWakefieldEducationFunction.SetPackageName("wakefield")
        clsWakefieldEducationFunction.SetRCommand("education")
        clsWakefieldEducationFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldEducationFunction.AddParameter("x", clsRFunctionParameter:=clsEducationListFunction, iPosition:=1)
        clsWakefieldEducationFunction.AddParameter("prob", clsRFunctionParameter:=clsEducationProbFunction, iPosition:=2)
        clsWakefieldEducationFunction.AddParameter("name", Chr(34) & "Education" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldEducationFunction.ToScript, 0)
    End Sub

    Private Sub cmdEmployment_Click(sender As Object, e As EventArgs) Handles cmdEmployment.Click
        Dim clsWakefieldEmploymentFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsEmploymentListFunction As New RFunction
        Dim clsEmploymentProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsEmploymentListFunction.SetRCommand("c")
        clsEmploymentListFunction.AddParameter("FT", Chr(34) & "Full Time" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsEmploymentListFunction.AddParameter("PT", Chr(34) & "Part Time" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsEmploymentListFunction.AddParameter("U", Chr(34) & "Unemployed" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsEmploymentListFunction.AddParameter("R", Chr(34) & "Retired" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsEmploymentListFunction.AddParameter("S", Chr(34) & "Student" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsEmploymentProbFunction.SetRCommand("c")
        clsEmploymentProbFunction.AddParameter("0.6", "0.6", iPosition:=0, bIncludeArgumentName:=False)
        clsEmploymentProbFunction.AddParameter("0.1", "0.1", iPosition:=1, bIncludeArgumentName:=False)
        clsEmploymentProbFunction.AddParameter("0.2", "0.1", iPosition:=2, bIncludeArgumentName:=False)
        clsEmploymentProbFunction.AddParameter("0.3", "0.1", iPosition:=3, bIncludeArgumentName:=False)
        clsEmploymentProbFunction.AddParameter("0.4", "0.1", iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldEmploymentFunction.SetPackageName("wakefield")
        clsWakefieldEmploymentFunction.SetRCommand("employment")
        clsWakefieldEmploymentFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldEmploymentFunction.AddParameter("x", clsRFunctionParameter:=clsEmploymentListFunction, iPosition:=1)
        clsWakefieldEmploymentFunction.AddParameter("prob", clsRFunctionParameter:=clsEmploymentProbFunction, iPosition:=2)
        clsWakefieldEmploymentFunction.AddParameter("name", Chr(34) & "Employment" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldEmploymentFunction.ToScript, 0)
    End Sub

    Private Sub cmdEye_Click(sender As Object, e As EventArgs) Handles cmdEye.Click
        Dim clsWakefieldEyeFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsEyeColorFunction As New RFunction
        Dim clsEyeColorProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsEyeColorFunction.SetRCommand("c")
        clsEyeColorFunction.AddParameter("brown", Chr(34) & "Brown" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsEyeColorFunction.AddParameter("blue", Chr(34) & "Blue" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsEyeColorFunction.AddParameter("green", Chr(34) & "Green" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsEyeColorFunction.AddParameter("hazel", Chr(34) & "Hazel" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsEyeColorFunction.AddParameter("gray", Chr(34) & "Gray" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsEyeColorProbFunction.SetRCommand("c")
        clsEyeColorProbFunction.AddParameter("0.44", "0.44", iPosition:=0, bIncludeArgumentName:=False)
        clsEyeColorProbFunction.AddParameter("0.3", "0.3", iPosition:=1, bIncludeArgumentName:=False)
        clsEyeColorProbFunction.AddParameter("0.13", "0.13", iPosition:=2, bIncludeArgumentName:=False)
        clsEyeColorProbFunction.AddParameter("0.09", "0.09", iPosition:=3, bIncludeArgumentName:=False)
        clsEyeColorProbFunction.AddParameter("0.04", "0.04", iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldEyeFunction.SetPackageName("wakefield")
        clsWakefieldEyeFunction.SetRCommand("eye")
        clsWakefieldEyeFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldEyeFunction.AddParameter("x", clsRFunctionParameter:=clsEyeColorFunction, iPosition:=1)
        clsWakefieldEyeFunction.AddParameter("prob", clsRFunctionParameter:=clsEyeColorProbFunction, iPosition:=2)
        clsWakefieldEyeFunction.AddParameter("name", Chr(34) & "Eye" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldEyeFunction.ToScript, 0)
    End Sub

    Private Sub cmdGrade_Level_Click(sender As Object, e As EventArgs) Handles cmdGrade_Level.Click
        Dim clsWakefieldGradeLevelFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsGradeLevelListunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsGradeLevelListunction.SetRCommand("c")
        clsGradeLevelListunction.AddParameter("k", Chr(34) & "k" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("1", Chr(34) & "1" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("2", Chr(34) & "2" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("3", Chr(34) & "3" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("4", Chr(34) & "4" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("5", Chr(34) & "5" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("6", Chr(34) & "6" & Chr(34), iPosition:=6, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("7", Chr(34) & "7" & Chr(34), iPosition:=7, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("8", Chr(34) & "8" & Chr(34), iPosition:=8, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("9", Chr(34) & "9" & Chr(34), iPosition:=9, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("10", Chr(34) & "10" & Chr(34), iPosition:=10, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("11", Chr(34) & "11" & Chr(34), iPosition:=11, bIncludeArgumentName:=False)
        clsGradeLevelListunction.AddParameter("12", Chr(34) & "12" & Chr(34), iPosition:=12, bIncludeArgumentName:=False)

        clsWakefieldGradeLevelFunction.SetPackageName("wakefield")
        clsWakefieldGradeLevelFunction.SetRCommand("grade_level")
        clsWakefieldGradeLevelFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldGradeLevelFunction.AddParameter("x", clsRFunctionParameter:=clsGradeLevelListunction, iPosition:=1)
        clsWakefieldGradeLevelFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldGradeLevelFunction.AddParameter("name", Chr(34) & "Grade_Level" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldGradeLevelFunction.ToScript, 0)
    End Sub

    Private Sub cmdGrade_Click(sender As Object, e As EventArgs) Handles cmdGrade.Click
        Dim clsWakefieldGradeFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldGradeFunction.SetPackageName("wakefield")
        clsWakefieldGradeFunction.SetRCommand("grade")
        clsWakefieldGradeFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldGradeFunction.AddParameter("mean", "88", iPosition:=1)
        clsWakefieldGradeFunction.AddParameter("sd", "4", iPosition:=2)
        clsWakefieldGradeFunction.AddParameter("name", Chr(34) & "Grade" & Chr(34), iPosition:=3)
        clsWakefieldGradeFunction.AddParameter("digits", "1", iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldGradeFunction.ToScript, 0)
    End Sub

    Private Sub cmdGroup_Click(sender As Object, e As EventArgs) Handles cmdGroup.Click
        Dim clsWakefieldGroupFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsGroupListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsGroupListFunction.SetRCommand("c")
        clsGroupListFunction.AddParameter("C", Chr(34) & "Control" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGroupListFunction.AddParameter("T", Chr(34) & "Treatment" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsWakefieldGroupFunction.SetPackageName("wakefield")
        clsWakefieldGroupFunction.SetRCommand("group")
        clsWakefieldGroupFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldGroupFunction.AddParameter("x", clsRFunctionParameter:=clsGroupListFunction, iPosition:=1)
        clsWakefieldGroupFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldGroupFunction.AddParameter("name", Chr(34) & "Group" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldGroupFunction.ToScript, 0)
    End Sub

    Private Sub cmdHair_Click(sender As Object, e As EventArgs) Handles cmdHair.Click
        Dim clsWakefieldHairFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsHairColorFunction As New RFunction
        Dim clsHairProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsHairColorFunction.SetRCommand("c")
        clsHairColorFunction.AddParameter("brown", Chr(34) & "Brown" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsHairColorFunction.AddParameter("black", Chr(34) & "Black" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsHairColorFunction.AddParameter("blonde", Chr(34) & "Blonde" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsHairColorFunction.AddParameter("red", Chr(34) & "Red" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)

        clsHairProbFunction.SetRCommand("c")
        clsHairProbFunction.AddParameter("0.35", "0.35", iPosition:=0, bIncludeArgumentName:=False)
        clsHairProbFunction.AddParameter("0.28", "0.28", iPosition:=1, bIncludeArgumentName:=False)
        clsHairProbFunction.AddParameter("0.26", "0.26", iPosition:=2, bIncludeArgumentName:=False)
        clsHairProbFunction.AddParameter("0.11", "0.11", iPosition:=3, bIncludeArgumentName:=False)

        clsWakefieldHairFunction.SetPackageName("wakefield")
        clsWakefieldHairFunction.SetRCommand("hair")
        clsWakefieldHairFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldHairFunction.AddParameter("x", clsRFunctionParameter:=clsHairColorFunction, iPosition:=1)
        clsWakefieldHairFunction.AddParameter("prob", clsRFunctionParameter:=clsHairProbFunction, iPosition:=2)
        clsWakefieldHairFunction.AddParameter("name", Chr(34) & "Hair" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldHairFunction.ToScript, 0)
    End Sub

    Private Sub cmdHeight_Click(sender As Object, e As EventArgs) Handles cmdHeight.Click
        Dim clsWakefieldHeightFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldHeightFunction.SetPackageName("wakefield")
        clsWakefieldHeightFunction.SetRCommand("height")
        clsWakefieldHeightFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldHeightFunction.AddParameter("mean", "69", iPosition:=1)
        clsWakefieldHeightFunction.AddParameter("sd", "3.75", iPosition:=2)
        clsWakefieldHeightFunction.AddParameter("min", "1", iPosition:=3)
        clsWakefieldHeightFunction.AddParameter("max", "NULL", iPosition:=4)
        clsWakefieldHeightFunction.AddParameter("digits", "0", iPosition:=5)
        clsWakefieldHeightFunction.AddParameter("name", Chr(34) & "Height" & Chr(34), iPosition:=6)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldHeightFunction.ToScript, 0)
    End Sub

    Private Sub cmdIncome_Click(sender As Object, e As EventArgs) Handles cmdIncome.Click
        Dim clsWakefieldIncomeFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldIncomeFunction.SetPackageName("wakefield")
        clsWakefieldIncomeFunction.SetRCommand("income")
        clsWakefieldIncomeFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldIncomeFunction.AddParameter("digits", "2", iPosition:=1)
        clsWakefieldIncomeFunction.AddParameter("name", Chr(34) & "Income" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldIncomeFunction.ToScript, 0)
    End Sub

    Private Sub cmdid_Click(sender As Object, e As EventArgs) Handles cmdid.Click
        Dim clsWakefieldIDFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldIDFunction.SetPackageName("wakefield")
        clsWakefieldIDFunction.SetRCommand("id")
        clsWakefieldIDFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldIDFunction.AddParameter("random", "FALSE", iPosition:=1)
        clsWakefieldIDFunction.AddParameter("name", Chr(34) & "ID" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldIDFunction.ToScript, 0)
    End Sub

    Private Sub cmdIq_Click(sender As Object, e As EventArgs) Handles cmdIq.Click
        Dim clsWakefieldIQFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldIQFunction.SetPackageName("wakefield")
        clsWakefieldIQFunction.SetRCommand("iq")
        clsWakefieldIQFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldIQFunction.AddParameter("mean", "100", iPosition:=1)
        clsWakefieldIQFunction.AddParameter("sd", "15", iPosition:=2)
        clsWakefieldIQFunction.AddParameter("min", "0", iPosition:=3)
        clsWakefieldIQFunction.AddParameter("max", "NULL", iPosition:=4)
        clsWakefieldIQFunction.AddParameter("digits", "0", iPosition:=5)
        clsWakefieldIQFunction.AddParameter("name", Chr(34) & "IQ" & Chr(34), iPosition:=6)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldIQFunction.ToScript, 0)
    End Sub

    Private Sub cmdLanguage_Click(sender As Object, e As EventArgs) Handles cmdLanguage.Click
        Dim clsWakefieldLanguageFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsProportionOperator As New ROperator

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldLanguageFunction.SetPackageName("wakefield")
        clsWakefieldLanguageFunction.SetRCommand("language")
        clsWakefieldLanguageFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldLanguageFunction.AddParameter("x", "wakefield::languages[[" & Chr(34) & "Language" & Chr(34) & "]]", iPosition:=1)
        clsWakefieldLanguageFunction.AddParameter("prob", "wakefield:: languages[[" & Chr(34) & "Proportion" & Chr(34) & "]]", iPosition:=2)
        clsWakefieldLanguageFunction.AddParameter("name", Chr(34) & "Language" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLanguageFunction.ToScript, 0)
    End Sub

    Private Sub cmdMath_Click(sender As Object, e As EventArgs) Handles cmdMath.Click
        Dim clsWakefieldMathFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsMathProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsMathProbFunction.SetRCommand("c")
        clsMathProbFunction.AddParameter("0.29829", "0.29829", iPosition:=0, bIncludeArgumentName:=False)
        clsMathProbFunction.AddParameter("0.33332", "0.33332", iPosition:=1, bIncludeArgumentName:=False)
        clsMathProbFunction.AddParameter("0.22797", "0.22797", iPosition:=2, bIncludeArgumentName:=False)
        clsMathProbFunction.AddParameter("0.14042", "0.14042", iPosition:=3, bIncludeArgumentName:=False)

        clsWakefieldMathFunction.SetPackageName("wakefield")
        clsWakefieldMathFunction.SetRCommand("math")
        clsWakefieldMathFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldMathFunction.AddParameter("x", "1:4", iPosition:=1)
        clsWakefieldMathFunction.AddParameter("prob", clsRFunctionParameter:=clsMathProbFunction, iPosition:=2)
        clsWakefieldMathFunction.AddParameter("name", Chr(34) & "Math" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldMathFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefieldMinute_Click(sender As Object, e As EventArgs) Handles cmdWakefieldMinute.Click
        Dim clsWakefieldMinuteFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldMinuteFunction.SetPackageName("wakefield")
        clsWakefieldMinuteFunction.SetRCommand("minute")
        clsWakefieldMinuteFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldMinuteFunction.AddParameter("x", "seq(0, 59, by = 1)/60 ", iPosition:=1)
        clsWakefieldMinuteFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldMinuteFunction.AddParameter("random", "FALSE", iPosition:=3)
        clsWakefieldMinuteFunction.AddParameter("name", Chr(34) & "Minute" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldMinuteFunction.ToScript, 0)
    End Sub

    Private Sub cmdGpa_Click(sender As Object, e As EventArgs) Handles cmdGpa.Click
        Dim clsWakefieldGpaFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldGpaFunction.SetPackageName("wakefield")
        clsWakefieldGpaFunction.SetRCommand("gpa")
        clsWakefieldGpaFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldGpaFunction.AddParameter("mean", "88", iPosition:=1)
        clsWakefieldGpaFunction.AddParameter("sd", "4", iPosition:=2)
        clsWakefieldGpaFunction.AddParameter("name", Chr(34) & "GPA" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldGpaFunction.ToScript, 0)
    End Sub

    Private Sub cmdPetLikert_Click(sender As Object, e As EventArgs) Handles cmdLikert.Click
        Dim clsWakefieldLikertFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsLikertListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsLikertListFunction.SetRCommand("c")
        clsLikertListFunction.AddParameter("s agree", Chr(34) & "Strongly Agree" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsLikertListFunction.AddParameter("agree", Chr(34) & "Agree" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsLikertListFunction.AddParameter("neutral", Chr(34) & "Neutral" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsLikertListFunction.AddParameter("disagree", Chr(34) & "Disagree" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsLikertListFunction.AddParameter("s disagree", Chr(34) & "Strongly Disagree" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldLikertFunction.SetPackageName("wakefield")
        clsWakefieldLikertFunction.SetRCommand("likert")
        clsWakefieldLikertFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldLikertFunction.AddParameter("x", clsRFunctionParameter:=clsLikertListFunction, iPosition:=1)
        clsWakefieldLikertFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldLikertFunction.AddParameter("name", Chr(34) & "Likert" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLikertFunction.ToScript, 0)
    End Sub

    Private Sub cmdLorem_Ipsum_Click(sender As Object, e As EventArgs) Handles cmdLorem_ipsum.Click
        Dim clsWakefieldLoremIpsumFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldLoremIpsumFunction.SetPackageName("wakefield")
        clsWakefieldLoremIpsumFunction.SetRCommand("lorem_ipsum")
        clsWakefieldLoremIpsumFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldLoremIpsumFunction.AddParameter("name", Chr(34) & "Lorem_Ipsum" & Chr(34), iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLoremIpsumFunction.ToScript, 0)
    End Sub

    Private Sub cmdMarital_Click(sender As Object, e As EventArgs) Handles cmdMarital.Click
        Dim clsWakefieldMaritalFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsMaritalListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsMaritalListFunction.SetRCommand("c")
        clsMaritalListFunction.AddParameter("married", Chr(34) & "Married" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsMaritalListFunction.AddParameter("divorced", Chr(34) & "Divorced" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsMaritalListFunction.AddParameter("widowed", Chr(34) & "Widowed" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsMaritalListFunction.AddParameter("separated", Chr(34) & "Separated" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsMaritalListFunction.AddParameter("never married", Chr(34) & "Never Married" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldMaritalFunction.SetPackageName("wakefield")
        clsWakefieldMaritalFunction.SetRCommand("marital")
        clsWakefieldMaritalFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldMaritalFunction.AddParameter("x", clsRFunctionParameter:=clsMaritalListFunction, iPosition:=1)
        clsWakefieldMaritalFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldMaritalFunction.AddParameter("name", Chr(34) & "Marital" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldMaritalFunction.ToScript, 0)
    End Sub

    Private Sub cmdMilitary_Click(sender As Object, e As EventArgs) Handles cmdMilitary.Click
        Dim clsWakefieldMilitaryFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsMilitaryListFunction As New RFunction
        Dim clsMilitaryProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsMilitaryListFunction.SetRCommand("c")
        clsMilitaryListFunction.AddParameter("army", Chr(34) & "Army" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsMilitaryListFunction.AddParameter("air force", Chr(34) & "Air Force" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsMilitaryListFunction.AddParameter("navy", Chr(34) & "Navy" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsMilitaryListFunction.AddParameter("marine corps", Chr(34) & "Marine Corps" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsMilitaryListFunction.AddParameter("coast guard", Chr(34) & "Coast Guard" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsMilitaryProbFunction.SetRCommand("c")
        clsMilitaryProbFunction.AddParameter("0.3785", "0.3785", iPosition:=0, bIncludeArgumentName:=False)
        clsMilitaryProbFunction.AddParameter("0.2334", "0.2334", iPosition:=1, bIncludeArgumentName:=False)
        clsMilitaryProbFunction.AddParameter("0.2218", "0.2218", iPosition:=2, bIncludeArgumentName:=False)
        clsMilitaryProbFunction.AddParameter("0.1366", "0.1366", iPosition:=3, bIncludeArgumentName:=False)
        clsMilitaryProbFunction.AddParameter("0.0296", "0.0296", iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldMilitaryFunction.SetPackageName("wakefield")
        clsWakefieldMilitaryFunction.SetRCommand("military")
        clsWakefieldMilitaryFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldMilitaryFunction.AddParameter("x", clsRFunctionParameter:=clsMilitaryListFunction, iPosition:=1)
        clsWakefieldMilitaryFunction.AddParameter("prob", clsRFunctionParameter:=clsMilitaryProbFunction, iPosition:=2)
        clsWakefieldMilitaryFunction.AddParameter("name", Chr(34) & "Military" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldMilitaryFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefield_Month_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Month.Click
        Dim clsWakefieldWMonthFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldWMonthFunction.SetPackageName("wakefield")
        clsWakefieldWMonthFunction.SetRCommand("month")
        clsWakefieldWMonthFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldWMonthFunction.AddParameter("x", "month.name", iPosition:=1)
        clsWakefieldWMonthFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldWMonthFunction.AddParameter("name", Chr(34) & "Month" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldWMonthFunction.ToScript, 0)
    End Sub

    Private Sub cmdName_Click(sender As Object, e As EventArgs) Handles cmdName.Click
        Dim clsWakefieldNameFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldNameFunction.SetPackageName("wakefield")
        clsWakefieldNameFunction.SetRCommand("name")
        clsWakefieldNameFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldNameFunction.AddParameter("x", "wakefield::name_neutral", iPosition:=1)
        clsWakefieldNameFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldNameFunction.AddParameter("replace", "FALSE", iPosition:=3)
        clsWakefieldNameFunction.AddParameter("name", Chr(34) & "Name" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldNameFunction.ToScript, 0)
    End Sub

    Private Sub cmdNormal_Click(sender As Object, e As EventArgs) Handles cmdNormal.Click
        Dim clsWakefieldNormalFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldNormalFunction.SetPackageName("wakefield")
        clsWakefieldNormalFunction.SetRCommand("normal")
        clsWakefieldNormalFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldNormalFunction.AddParameter("mean", "0", iPosition:=1)
        clsWakefieldNormalFunction.AddParameter("sd", "1", iPosition:=2)
        clsWakefieldNormalFunction.AddParameter("min", "NULL", iPosition:=3)
        clsWakefieldNormalFunction.AddParameter("max", "NULL", iPosition:=4)
        clsWakefieldNormalFunction.AddParameter("name", Chr(34) & "Normal" & Chr(34), iPosition:=5)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldNormalFunction.ToScript, 0)
    End Sub

    Private Sub cmdPolitical_Click(sender As Object, e As EventArgs) Handles cmdPolitical.Click
        Dim clsWakefieldPoliticalFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsPoliticalListFunction As New RFunction
        Dim clsPoliticalProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsPoliticalListFunction.SetRCommand("c")
        clsPoliticalListFunction.AddParameter("democrat", Chr(34) & "Democrat" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsPoliticalListFunction.AddParameter("republican", Chr(34) & "Republican" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsPoliticalListFunction.AddParameter("constitution", Chr(34) & "Constitution" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsPoliticalListFunction.AddParameter("libertarian", Chr(34) & "Libertarian" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsPoliticalListFunction.AddParameter("green", Chr(34) & "Green" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)

        clsPoliticalProbFunction.SetRCommand("c")
        clsPoliticalProbFunction.AddParameter("0.577269133302094", "0.577269133302094", iPosition:=0, bIncludeArgumentName:=False)
        clsPoliticalProbFunction.AddParameter("0.410800432748879", "0.410800432748879", iPosition:=1, bIncludeArgumentName:=False)
        clsPoliticalProbFunction.AddParameter("0.00491084954793489", "0.00491084954793489", iPosition:=2, bIncludeArgumentName:=False)
        clsPoliticalProbFunction.AddParameter("0.00372590303330866", "0.00372590303330866", iPosition:=3, bIncludeArgumentName:=False)
        clsPoliticalProbFunction.AddParameter("0.0032936813677832", "0.0032936813677832", iPosition:=4, bIncludeArgumentName:=False)

        clsWakefieldPoliticalFunction.SetPackageName("wakefield")
        clsWakefieldPoliticalFunction.SetRCommand("political")
        clsWakefieldPoliticalFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldPoliticalFunction.AddParameter("x", clsRFunctionParameter:=clsPoliticalListFunction, iPosition:=1)
        clsWakefieldPoliticalFunction.AddParameter("prob", clsRFunctionParameter:=clsPoliticalProbFunction, iPosition:=2)
        clsWakefieldPoliticalFunction.AddParameter("name", Chr(34) & "Political" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldPoliticalFunction.ToScript, 0)
    End Sub

    Private Sub cmdRace_Click(sender As Object, e As EventArgs) Handles cmdRace.Click
        Dim clsWakefieldRaceFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsRaceListFunction As New RFunction
        Dim clsRaceProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsRaceListFunction.SetRCommand("c")
        clsRaceListFunction.AddParameter("white", Chr(34) & "White" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("hispanic", Chr(34) & "Hispanic" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("black", Chr(34) & "Black" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("asian", Chr(34) & "Asian" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("bi racial", Chr(34) & "Bi-Racial" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("native", Chr(34) & "Native" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("other", Chr(34) & "Other" & Chr(34), iPosition:=6, bIncludeArgumentName:=False)
        clsRaceListFunction.AddParameter("hawaiian", Chr(34) & "Hawaiian" & Chr(34), iPosition:=7, bIncludeArgumentName:=False)

        clsRaceProbFunction.SetRCommand("c")
        clsRaceProbFunction.AddParameter("0.637", "0.637", iPosition:=0, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.163", "0.163", iPosition:=1, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.122", "0.122", iPosition:=2, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.047", "0.047", iPosition:=3, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.019", "0.019", iPosition:=4, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.007", "0.007", iPosition:=5, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.002", "0.002", iPosition:=6, bIncludeArgumentName:=False)
        clsRaceProbFunction.AddParameter("0.0015", "0.0015", iPosition:=7, bIncludeArgumentName:=False)

        clsWakefieldRaceFunction.SetPackageName("wakefield")
        clsWakefieldRaceFunction.SetRCommand("race")
        clsWakefieldRaceFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldRaceFunction.AddParameter("x", clsRFunctionParameter:=clsRaceListFunction, iPosition:=1)
        clsWakefieldRaceFunction.AddParameter("prob", clsRFunctionParameter:=clsRaceProbFunction, iPosition:=2)
        clsWakefieldRaceFunction.AddParameter("name", Chr(34) & "Race" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldRaceFunction.ToScript, 0)
    End Sub

    Private Sub cmdReligion_Click(sender As Object, e As EventArgs) Handles cmdReligion.Click
        Dim clsWakefieldReligionFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsReligionListFunction As New RFunction
        Dim clsReligionProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsReligionListFunction.SetRCommand("c")
        clsReligionListFunction.AddParameter("christian", Chr(34) & "Christian" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("muslim", Chr(34) & "Muslim" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("none", Chr(34) & "None" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("hindu", Chr(34) & "Hindu" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("buddhist", Chr(34) & "Buddhist" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("folk", Chr(34) & "Folk" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("other", Chr(34) & "Other" & Chr(34), iPosition:=6, bIncludeArgumentName:=False)
        clsReligionListFunction.AddParameter("hawaiian", Chr(34) & "Hawaiian" & Chr(34), iPosition:=7, bIncludeArgumentName:=False)

        clsReligionProbFunction.SetRCommand("c")
        clsReligionProbFunction.AddParameter("0.31477", "0.31477", iPosition:=0, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.23163", "0.23163", iPosition:=1, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.16323", "0.16323", iPosition:=2, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.14985", "0.14985", iPosition:=3, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.07083", "0.07083", iPosition:=4, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.05882", "0.05882", iPosition:=5, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.00859", "0.00859", iPosition:=6, bIncludeArgumentName:=False)
        clsReligionProbFunction.AddParameter("0.00227", "0.00227", iPosition:=7, bIncludeArgumentName:=False)

        clsWakefieldReligionFunction.SetPackageName("wakefield")
        clsWakefieldReligionFunction.SetRCommand("religion")
        clsWakefieldReligionFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldReligionFunction.AddParameter("x", clsRFunctionParameter:=clsReligionListFunction, iPosition:=1)
        clsWakefieldReligionFunction.AddParameter("prob", clsRFunctionParameter:=clsReligionProbFunction, iPosition:=2)
        clsWakefieldReligionFunction.AddParameter("name", Chr(34) & "Religion" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldReligionFunction.ToScript, 0)
    End Sub

    Private Sub cmdSat_Click(sender As Object, e As EventArgs) Handles cmdSat.Click
        Dim clsWakefieldSatFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldSatFunction.SetPackageName("wakefield")
        clsWakefieldSatFunction.SetRCommand("sat")
        clsWakefieldSatFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldSatFunction.AddParameter("mean", "1000", iPosition:=1)
        clsWakefieldSatFunction.AddParameter("sd", "150", iPosition:=2)
        clsWakefieldSatFunction.AddParameter("min", "400", iPosition:=3)
        clsWakefieldSatFunction.AddParameter("max", "1600", iPosition:=4)
        clsWakefieldSatFunction.AddParameter("digits", "0", iPosition:=5)
        clsWakefieldSatFunction.AddParameter("name", Chr(34) & "SAT" & Chr(34), iPosition:=6)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldSatFunction.ToScript, 0)
    End Sub

    Private Sub cmdSentence_Click(sender As Object, e As EventArgs) Handles cmdSentence.Click
        Dim clsWakefieldSentenceFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldSentenceFunction.SetPackageName("wakefield")
        clsWakefieldSentenceFunction.SetRCommand("sentence")
        clsWakefieldSentenceFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldSentenceFunction.AddParameter("x", "wakefield::presidential_debates_2012", iPosition:=1)
        clsWakefieldSentenceFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldSentenceFunction.AddParameter("name", Chr(34) & "Sentence" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldSentenceFunction.ToScript, 0)
    End Sub

    Private Sub cmdGender_Click(sender As Object, e As EventArgs) Handles cmdGender.Click
        Dim clsWakefieldGenderFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsGenderListFunction As New RFunction
        Dim clsGenderProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsGenderListFunction.SetRCommand("c")
        clsGenderListFunction.AddParameter("male", Chr(34) & "Male" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGenderListFunction.AddParameter("female", Chr(34) & "Female" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsGenderProbFunction.SetRCommand("c")
        clsGenderProbFunction.AddParameter("0.51219512195122", "0.51219512195122", iPosition:=0, bIncludeArgumentName:=False)
        clsGenderProbFunction.AddParameter("0.48780487804878", "0.48780487804878", iPosition:=1, bIncludeArgumentName:=False)

        clsWakefieldGenderFunction.SetPackageName("wakefield")
        clsWakefieldGenderFunction.SetRCommand("gender")
        clsWakefieldGenderFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldGenderFunction.AddParameter("x", clsRFunctionParameter:=clsGenderListFunction, iPosition:=1)
        clsWakefieldGenderFunction.AddParameter("prob", clsRFunctionParameter:=clsGenderProbFunction, iPosition:=2)
        clsWakefieldGenderFunction.AddParameter("name", Chr(34) & "Gender" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldGenderFunction.ToScript, 0)
    End Sub

    Private Sub cmdSex_Inclusive_Click(sender As Object, e As EventArgs) Handles cmdSex_Inclusive.Click
        Dim clsWakefieldSexInclusiveFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsInclusiveListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsInclusiveListFunction.SetRCommand("c")
        clsInclusiveListFunction.AddParameter("male", Chr(34) & "Male" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsInclusiveListFunction.AddParameter("female", Chr(34) & "Female" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsInclusiveListFunction.AddParameter("intersex", Chr(34) & "Intersex" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)

        clsWakefieldSexInclusiveFunction.SetPackageName("wakefield")
        clsWakefieldSexInclusiveFunction.SetRCommand("sex_inclusive")
        clsWakefieldSexInclusiveFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldSexInclusiveFunction.AddParameter("x", clsRFunctionParameter:=clsInclusiveListFunction, iPosition:=1)
        clsWakefieldSexInclusiveFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldSexInclusiveFunction.AddParameter("name", Chr(34) & "Sex" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldSexInclusiveFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefieldTimes_Click(sender As Object, e As EventArgs) Handles cmdWakefieldTimes.Click
        Dim clsWakefieldTimestampFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldTimestampFunction.SetPackageName("wakefield")
        clsWakefieldTimestampFunction.SetRCommand("time_stamp")
        clsWakefieldTimestampFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldTimestampFunction.AddParameter("x", "seq(0, 23, by = 1)", iPosition:=1)
        clsWakefieldTimestampFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldTimestampFunction.AddParameter("random", "FALSE", iPosition:=3)
        clsWakefieldTimestampFunction.AddParameter("name", Chr(34) & "Time" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldTimestampFunction.ToScript, 0)
    End Sub

    Private Sub cmdSmokes_Click(sender As Object, e As EventArgs) Handles cmdSmokes.Click
        Dim clsWakefieldSmokesFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsSmokesProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsSmokesProbFunction.SetRCommand("c")
        clsSmokesProbFunction.AddParameter("0.822", "0.822", iPosition:=0, bIncludeArgumentName:=False)
        clsSmokesProbFunction.AddParameter("0.178", "0.178", iPosition:=1, bIncludeArgumentName:=False)

        clsWakefieldSmokesFunction.SetPackageName("wakefield")
        clsWakefieldSmokesFunction.SetRCommand("smokes")
        clsWakefieldSmokesFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldSmokesFunction.AddParameter("prob", clsRFunctionParameter:=clsSmokesProbFunction, iPosition:=1)
        clsWakefieldSmokesFunction.AddParameter("name", Chr(34) & "Smokes" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldSmokesFunction.ToScript, 0)
    End Sub

    Private Sub cmdSpeed_Click(sender As Object, e As EventArgs) Handles cmdSpeed.Click
        Dim clsWakefieldSpeedFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldSpeedFunction.SetPackageName("wakefield")
        clsWakefieldSpeedFunction.SetRCommand("speed")
        clsWakefieldSpeedFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldSpeedFunction.AddParameter("mean", "55", iPosition:=1)
        clsWakefieldSpeedFunction.AddParameter("sd", "10", iPosition:=2)
        clsWakefieldSpeedFunction.AddParameter("min", "0", iPosition:=3)
        clsWakefieldSpeedFunction.AddParameter("max", "NULL", iPosition:=4)
        clsWakefieldSpeedFunction.AddParameter("digits", "0", iPosition:=5)
        clsWakefieldSpeedFunction.AddParameter("name", Chr(34) & "Speed" & Chr(34), iPosition:=6)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldSpeedFunction.ToScript, 0)
    End Sub

    Private Sub cmdState_Click(sender As Object, e As EventArgs) Handles cmdState.Click
        Dim clsWakefieldStateFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldStateFunction.SetPackageName("wakefield")
        clsWakefieldStateFunction.SetRCommand("state")
        clsWakefieldStateFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldStateFunction.AddParameter("x", "datasets::state.name", iPosition:=1)
        clsWakefieldStateFunction.AddParameter("prob", "wakefield::state_populations[[" & Chr(34) & "Proportion" & Chr(34) & "]]", iPosition:=2)
        clsWakefieldStateFunction.AddParameter("name", Chr(34) & "State" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldStateFunction.ToScript, 0)
    End Sub

    Private Sub cmdString_Click(sender As Object, e As EventArgs) Handles cmdString.Click
        Dim clsWakefieldStringFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldStringFunction.SetPackageName("wakefield")
        clsWakefieldStringFunction.SetRCommand("string")
        clsWakefieldStringFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldStringFunction.AddParameter("x", Chr(34) & "[A-Za-z0-9]" & Chr(34), iPosition:=1)
        clsWakefieldStringFunction.AddParameter("length", "10", iPosition:=2)
        clsWakefieldStringFunction.AddParameter("name", Chr(34) & "String" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldStringFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefield_Upper_Click(sender As Object, e As EventArgs) Handles cmdWakefieldUpper.Click
        Dim clsWakefieldUpper_factorFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldUpper_factorFunction.SetPackageName("wakefield")
        clsWakefieldUpper_factorFunction.SetRCommand("upper_factor")
        clsWakefieldUpper_factorFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldUpper_factorFunction.AddParameter("k", "5", iPosition:=1)
        clsWakefieldUpper_factorFunction.AddParameter("x", "LETTERS", iPosition:=2)
        clsWakefieldUpper_factorFunction.AddParameter("prob", "NULL", iPosition:=3)
        clsWakefieldUpper_factorFunction.AddParameter("name", Chr(34) & "Upper" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldUpper_factorFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefieldLower_click(sender As Object, e As EventArgs) Handles cmdWakefieldLower.Click
        Dim clsWakefieldLower_FactorFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldLower_FactorFunction.SetPackageName("wakefield")
        clsWakefieldLower_FactorFunction.SetRCommand("lower_factor")
        clsWakefieldLower_FactorFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldLower_FactorFunction.AddParameter("k", "5", iPosition:=1)
        clsWakefieldLower_FactorFunction.AddParameter("x", "letters", iPosition:=2)
        clsWakefieldLower_FactorFunction.AddParameter("prob", "NULL", iPosition:=3)
        clsWakefieldLower_FactorFunction.AddParameter("name", Chr(34) & "Lower" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLower_FactorFunction.ToScript, 0)
    End Sub

    Private Sub cmdValid_Click(sender As Object, e As EventArgs) Handles cmdValid.Click
        Dim clsWakefieldValidFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldValidFunction.SetPackageName("wakefield")
        clsWakefieldValidFunction.SetRCommand("valid")
        clsWakefieldValidFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldValidFunction.AddParameter("prob", "NULL", iPosition:=1)
        clsWakefieldValidFunction.AddParameter("name", Chr(34) & "Valid" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldValidFunction.ToScript, 0)
    End Sub

    Private Sub cmdWakefield_Year_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Year.Click
        Dim clsWakefieldYearFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldYearFunction.SetPackageName("wakefield")
        clsWakefieldYearFunction.SetRCommand("year")
        clsWakefieldYearFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldYearFunction.AddParameter("x", "1996:as.numeric(format(Sys.Date()," & Chr(34) & "%Y" & Chr(34) & "))", iPosition:=1)
        clsWakefieldYearFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldYearFunction.AddParameter("name", Chr(34) & "Year" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldYearFunction.ToScript, 0)
    End Sub

    Private Sub cmdCircMean_Click(sender As Object, e As EventArgs) Handles cmdCircMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular:: mean.circular(x= , na.rm = TRUE, control.circular = list())", 43)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::mean.circular( )", 2)
        End If
    End Sub

    Private Sub cmdCircMedian_Click(sender As Object, e As EventArgs) Handles cmdCircMedian.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::median.circular(x= , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::median.circular( )", 2)
        End If
    End Sub

    Private Sub cmdMedianHL_Click(sender As Object, e As EventArgs) Handles cmdMedianHL.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::medianHL.circular(x= , na.rm = TRUE, method = c(""HL1"",""HL2"",""HL3""), prop = NULL)", 60)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::medianHL.circular( )", 2)
        End If
    End Sub

    Private Sub cmdCircRange_Click(sender As Object, e As EventArgs) Handles cmdCircRange.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::range.circular(x = , test = FALSE, na.rm = TRUE, finite = FALSE, control.circular = list(), )", 75)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::range.circular( )", 2)
        End If
    End Sub

    Private Sub cmdCircSd_Click(sender As Object, e As EventArgs) Handles cmdCircSd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::sd.circular(x = ,  na.rm = TRUE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::sd.circular( )", 2)
        End If
    End Sub

    Private Sub cmdCircVar_Click(sender As Object, e As EventArgs) Handles cmdCircVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::var.circular(x = ,  na.rm = TRUE)", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::var.circular( )", 2)
        End If
    End Sub

    Private Sub cmdA1_Click(sender As Object, e As EventArgs) Handles cmdA1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::A1(kappa = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::A1( )", 2)
        End If
    End Sub

    Private Sub cmdAngVar_Click(sender As Object, e As EventArgs) Handles cmdAngVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.variance(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.variance( )", 2)
        End If
    End Sub

    Private Sub cmdAngDev_Click(sender As Object, e As EventArgs) Handles cmdAngDev.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.deviation(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::angular.deviation( )", 2)
        End If
    End Sub

    Private Sub cmdCircQ1_Click(sender As Object, e As EventArgs) Handles cmdCircQ1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.25, na.rm = TRUE, names = TRUE, type = 7)", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.25)", 16)
        End If
    End Sub

    Private Sub cmdCircMin_Click(sender As Object, e As EventArgs) Handles cmdCircMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0, na.rm = TRUE, names = TRUE, type = 7)", 51)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0)", 13)
        End If
    End Sub

    Private Sub cmdCircMax_Click(sender As Object, e As EventArgs) Handles cmdCircMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 1, na.rm = TRUE, names = TRUE, type = 7)", 51)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 1)", 13)
        End If
    End Sub

    Private Sub cmdCircQ3_Click(sender As Object, e As EventArgs) Handles cmdCircQ3.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.75, na.rm = TRUE, names = TRUE, type = 7)", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = 0.75)", 16)
        End If
    End Sub

    Private Sub cmdCircQuantiles_Click_1(sender As Object, e As EventArgs) Handles cmdCircQuantiles.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = seq(0, 1, 0.25), na.rm = TRUE, names = TRUE, type = 7)", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::quantile.circular(x = , probs = seq(0, 1, 0.25))", 26)
        End If
    End Sub

    Private Sub cmdCircRho_Click_1(sender As Object, e As EventArgs) Handles cmdCircRho.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rho.circular(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rho.circular( )", 2)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply(data = , width = 3, FUN = min , by = 1, by.column = TRUE, fill = NA, na.pad = FALSE, partial = FALSE, align = c(""center"", ""left"", ""right""), coredata = TRUE)", 150)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply( , width = 3, FUN = min, fill = NA, align= ""center"")", 52)
        End If
    End Sub

    Private Sub cmdNafill_Click(sender As Object, e As EventArgs) Handles cmdNafill.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.fill(object = , fill = NA , ix = !is.na(object)))", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.fill( )", 2)
        End If
    End Sub

    Private Sub cmdNaest_Click(sender As Object, e As EventArgs) Handles cmdNaest.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.aggregate(object = , by = 1, FUN = mean, na.rm = FALSE, maxgap = Inf))", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.aggregate( )", 2)
        End If
    End Sub

    Private Sub cmdNaapprox_Click(sender As Object, e As EventArgs) Handles cmdNaapprox.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.approx(object = , x = index(object), xout = , na.rm = FALSE, maxgap = Inf, along))", 66)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.approx( )", 2)
        End If
    End Sub

    Private Sub cmdNasplin_Click(sender As Object, e As EventArgs) Handles cmdNasplin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.spline(object = , x = index(object), xout = , na.rm = FALSE, maxgap = Inf, along))", 66)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::na.spline( )", 2)
        End If
    End Sub


    Private Sub cmdFactor_Click(sender As Object, e As EventArgs) Handles cmdFactor.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::as_factor(x = , ... )", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::as_factor( )", 2)
        End If
    End Sub

    Private Sub cmdAnon_Click(sender As Object, e As EventArgs) Handles cmdAnon.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_anon(x = , prefix = "" )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_anon( )", 2)
        End If
    End Sub

    Private Sub cmdLabelled_Click(sender As Object, e As EventArgs) Handles cmdLabelled.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("labelled::labelled(x = , labels = , label = NULL)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("labelled::labelled( )", 2)
        End If
    End Sub

    Private Sub cmdCollapse_Click(sender As Object, e As EventArgs) Handles cmdCollapse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_collapse(.f = , ..., group_other = FALSE)", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_collapse( )", 2)
        End If
    End Sub

    Private Sub cmdCross_Click(sender As Object, e As EventArgs) Handles cmdCross.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_cross(.f = , ..., sep = "":"", keep_empty = FALSE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_cross( )", 2)
        End If
    End Sub

    Private Sub cmdDrop_Click(sender As Object, e As EventArgs) Handles cmdDrop.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_drop(f = , only)", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_drop( )", 2)
        End If
    End Sub

    Private Sub cmdExpand_Click(sender As Object, e As EventArgs) Handles cmdExpand.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_expand(f = , ...)", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_expand( )", 2)
        End If
    End Sub

    Private Sub cmdAdd_na_Click(sender As Object, e As EventArgs) Handles cmdAdd_na.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_na_value_to_level(f = ,level = Null)", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_na_value_to_level( )", 2)
        End If
    End Sub

    Private Sub cmdInorder_Click(sender As Object, e As EventArgs) Handles cmdInorder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inorder(f = , ordered = NA)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inorder( )", 2)
        End If
    End Sub

    Private Sub cmdInfreq_Click(sender As Object, e As EventArgs) Handles cmdInfreq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_infreq(f = , ordered = NA)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_infreq( )", 2)
        End If
    End Sub

    Private Sub cmdInseq_Click(sender As Object, e As EventArgs) Handles cmdInseq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inseq(f = , ordered = NA)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_inseq( )", 2)
        End If
    End Sub

    Private Sub cmdLump_Click(sender As Object, e As EventArgs) Handles cmdLump.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_lump_min(f = , n, prop, w = NULL, other_level = ""Other"", ties.method = c(""min"", ""average"", ""first"", ""last"", ""random"", ""max""))", 113)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_lump_min( )", 2)
        End If
    End Sub

    Private Sub cmdFmatch_Click(sender As Object, e As EventArgs) Handles cmdFmatch.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_match(f = , lvls)", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_match( )", 2)
        End If
    End Sub

    Private Sub cmdOther_Click(sender As Object, e As EventArgs) Handles cmdOther.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_other(f = , keep = , drop = , other_level = ""Other"")", 43)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_other( )", 2)
        End If
    End Sub

    Private Sub cmdRecode_Click(sender As Object, e As EventArgs) Handles cmdRecode.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_recode(.f = , ...)", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_recode( )", 2)
        End If
    End Sub

    Private Sub cmdRelevel_Click(sender As Object, e As EventArgs) Handles cmdRelevel.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_relevel(.f = , ..., after = 0L)", 19)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_relevel( )", 2)
        End If
    End Sub

    Private Sub cmdReorder_Click(sender As Object, e As EventArgs) Handles cmdReorder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_reorder(.f = , .x = , .fun = median, ..., .desc = FALSE)", 44)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_reorder( )", 2)
        End If
    End Sub

    Private Sub cmdReverse_Click(sender As Object, e As EventArgs) Handles cmdReverse.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_rev(f = , )", 4)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_rev( )", 2)
        End If
    End Sub

    Private Sub cmdShift_Click(sender As Object, e As EventArgs) Handles cmdShift.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shift(f = , n = 1L)", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shift( )", 2)
        End If
    End Sub

    Private Sub cmdShuffle_Click(sender As Object, e As EventArgs) Handles cmdShuffle.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shuffle(f = , )", 4)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("forcats::fct_shuffle( )", 2)

        End If
    End Sub

    Private Sub cmdPgamma_Click(sender As Object, e As EventArgs) Handles cmdPgamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pgamma(q = , shape = , rate = 1, lower.tail = TRUE,log.p = FALSE)", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pgamma(, , )", 5)
        End If
    End Sub

    Private Sub cmdQgamma_Click(sender As Object, e As EventArgs) Handles cmdQgamma.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qgamma(p = , shape = , rate = 1, lower.tail = TRUE, log.p = FALSE)", 56)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qgamma(, )", 3)
        End If
    End Sub

    Private Sub cmdPbeta_Click(sender As Object, e As EventArgs) Handles cmdPbeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbeta(q = , shape1 = , shape2 = , ncp = 0, lower.tail = TRUE, log.p = FALSE)", 67)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbeta(, , )", 5)
        End If
    End Sub

    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmdPbirth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(X = , FUN= pbirthday, classes= 365, coincident= 2)", 47)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( , pbirthday)", 13)
        End If
    End Sub

    Private Sub cmdPbinom_Click(sender As Object, e As EventArgs) Handles cmdPbinom.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbinom(q = , size = , prob = , lower.tail = TRUE, log.p = FALSE)", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pbinom(, , )", 5)
        End If
    End Sub

    Private Sub cmdPpois_Click(sender As Object, e As EventArgs) Handles cmdPpois.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ppois(q = , lambda = , lower.tail = TRUE, log.p = FALSE)", 47)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ppois(, )", 3)
        End If
    End Sub

    Private Sub cmdPnbin_Click(sender As Object, e As EventArgs) Handles cmdPnbin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnbinom(q = , size = , prob = , mu = , lower.tail = TRUE, log.p = FALSE)", 61)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnbinom(, , )", 5)
        End If
    End Sub

    Private Sub cmdQbeta_Click(sender As Object, e As EventArgs) Handles cmdQbeta.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbeta(p = , shape1 = , shape2 = , ncp = 0, lower.tail = TRUE, log.p = FALSE)", 67)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbeta(, , )", 5)
        End If
    End Sub

    Private Sub cmdQbirth_Click(sender As Object, e As EventArgs) Handles cmdQbirth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(X= , FUN= qbirthday, classes= 365, coincident= 2)", 47)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( , qbirthday)", 13)
        End If
    End Sub

    Private Sub cmdQbinom_Click(sender As Object, e As EventArgs) Handles cmdQbinom.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbinom(p = , size = , prob = , lower.tail = TRUE, log.p = FALSE)", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qbinom(, , )", 5)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles cmdQpois.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qpois(p = , lambda = , lower.tail = TRUE, log.p = FALSE)", 47)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qpois(, )", 3)
        End If
    End Sub

    Private Sub cmdQnbin_Click(sender As Object, e As EventArgs) Handles cmdQnbin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnbinom(p = , size = , prob = , mu = , lower.tail = TRUE, log.p = FALSE)", 61)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnbinom(, , )", 5)
        End If
    End Sub

    Private Sub cmdLikert7_Click(sender As Object, e As EventArgs) Handles cmdLikert7.Click
        Dim clsWakefieldLikert7Function As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsLikert7ListFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsLikert7ListFunction.SetRCommand("c")
        clsLikert7ListFunction.AddParameter("s agree", Chr(34) & "Strongly Agree" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsLikert7ListFunction.AddParameter("agree", Chr(34) & "Agree" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsLikert7ListFunction.AddParameter("some_agree", Chr(34) & "Somewhat Agree" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsLikert7ListFunction.AddParameter("neutral", Chr(34) & "Neutral" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsLikert7ListFunction.AddParameter("some_disagree", Chr(34) & "Somewhat Disagree" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsLikert7ListFunction.AddParameter("disagree", Chr(34) & "Disagree" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)
        clsLikert7ListFunction.AddParameter("s disagree", Chr(34) & "Strongly Disagree" & Chr(34), iPosition:=6, bIncludeArgumentName:=False)

        clsWakefieldLikert7Function.SetPackageName("wakefield")
        clsWakefieldLikert7Function.SetRCommand("likert_7")
        clsWakefieldLikert7Function.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldLikert7Function.AddParameter("x", clsRFunctionParameter:=clsLikert7ListFunction, iPosition:=1)
        clsWakefieldLikert7Function.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldLikert7Function.AddParameter("name", Chr(34) & "Likert7" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLikert7Function.ToScript, 0)
    End Sub

    Private Sub cmdStarts_Click(sender As Object, e As EventArgs) Handles cmdStarts.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_starts(string = , pattern = , negate = FALSE)", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_starts( )", 2)
        End If
    End Sub

    Private Sub cmdRemove1_Click(sender As Object, e As EventArgs) Handles cmdRemove1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove( )", 2)
        End If
    End Sub

    Private Sub cmdRemove2_Click(sender As Object, e As EventArgs) Handles cmdRemove2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove_all(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove_all( )", 2)
        End If
    End Sub

    Private Sub cmdSquishb_Click(sender As Object, e As EventArgs) Handles cmdSquishb.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_squish(string = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_squish( )", 2)
        End If
    End Sub

    Private Sub cmdEncodeb_Click(sender As Object, e As EventArgs) Handles cmdEncodeb.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_conv(string = , encoding = )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_conv( )", 2)
        End If
    End Sub

    Private Sub cmdExtract2_Click(sender As Object, e As EventArgs) Handles cmdExtract2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract_all(string = , pattern = , simplify = FALSE)", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract_all( )", 2)
        End If
    End Sub

    Private Sub cmdLocate2_Click(sender As Object, e As EventArgs) Handles cmdLocate2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate_all(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate_all( )", 2)
        End If
    End Sub

    Private Sub cmdReplace2_Click(sender As Object, e As EventArgs) Handles cmdReplace2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace_all(string = , pattern = , replacement = )", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace_all( )", 2)
        End If
    End Sub

    Private Sub cmdBoundary_Click(sender As Object, e As EventArgs) Handles cmdBoundary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(type = c(""character"", ""line_break"", ""sentence"", ""word""), stringr::boundary(), skip_word_none = NA)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::boundary( )", 2)
        End If
    End Sub

    Private Sub cmdCollate_Click(sender As Object, e As EventArgs) Handles cmdCollate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::coll(), ignore_case = FALSE, locale = ""en"")", 55)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::coll( )", 2)
        End If
    End Sub

    Private Sub cmdFixed_Click(sender As Object, e As EventArgs) Handles cmdFixed.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::fixed(), ignore_case = FALSE)", 41)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::fixed( )", 2)
        End If
    End Sub

    Private Sub cmdRegex_Click(sender As Object, e As EventArgs) Handles cmdRegex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::regex() , ignore_case = FALSE , multiline = FALSE , comments = FALSE, dotall = FALSE)", 97)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::regex( )", 2)
        End If
    End Sub

    Private Sub cmdAny1_Click(sender As Object, e As EventArgs) Handles cmdAny1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(".", 1)
    End Sub

    Private Sub cmdbegin_Click(sender As Object, e As EventArgs) Handles cmdbegin.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("^", 1)
    End Sub

    Private Sub cmdEnd1_Click(sender As Object, e As EventArgs) Handles cmdEnd1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("$")
    End Sub

    Private Sub cmdDigit_Click(sender As Object, e As EventArgs) Handles cmdDigit.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("\\d")
    End Sub

    Private Sub cmdSpace_Click(sender As Object, e As EventArgs) Handles cmdSpace.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("\\s")
    End Sub

    Private Sub cmdOr1_Click(sender As Object, e As EventArgs) Handles cmdOr1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("[]", 1)
    End Sub

    Private Sub cmdNot1_Click(sender As Object, e As EventArgs) Handles cmdNot1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("[^ ]", 3)
    End Sub

    Private Sub cmdOr3_Click(sender As Object, e As EventArgs) Handles cmdOr3.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("|", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv1(x = , na.rm = TRUE)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv1( , na.rm = TRUE)", 16)
        End If
    End Sub

    Private Sub cmdKurtosis_Click(sender As Object, e As EventArgs) Handles cmdKurtosis.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::kurtosis(x= , na.rm = TRUE, type = 3)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::kurtosis( , na.rm = TRUE)", 16)
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

    Private Sub cmdPbiasfdc_Click(sender As Object, e As EventArgs) Handles cmdPbiasfdc.Click
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

    Private Sub cmdDateTime_Click(sender As Object, e As EventArgs) Handles cmdDateTime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::as_datetime(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::as_datetime( )", 2)
        End If
    End Sub

    Private Sub cmdTime_Click(sender As Object, e As EventArgs) Handles cmdTime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hms::hms(seconds = , minutes = , hours = , days = )", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hms::hms( )", 2)
        End If
    End Sub

    Private Sub cmdAsTime_Click(sender As Object, e As EventArgs) Handles cmdAsTime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hms::as_hms(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hms::as_hms( )", 2)
        End If
    End Sub

    ''' <summary>
    ''' this will be raised when the input name is changed and even when the ucrSave checkbox checked status is changed
    ''' </summary>
    ''' <param name="ucrChangedControl"></param>
    Private Sub ucrSaveResultInto_SaveNameChanged(ucrChangedControl As ucrCore) Handles ucrSaveResultInto.ControlContentsChanged
        RaiseEvent SaveNameChanged()
    End Sub

    Private Sub ucrSaveResultInto_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResultInto.ControlValueChanged
        RaiseEvent ControlValueChanged()
    End Sub

    Private Sub cmdGlue_Click(sender As Object, e As EventArgs) Handles cmdGlue.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_glue(.sep = """" , .envir = parent.frame())", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_glue( )", 2)
        End If
    End Sub

    Private Sub cmdLenth_Click(sender As Object, e As EventArgs) Handles cmdLenth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_length(string="""")", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_length( )", 2)
        End If
    End Sub

    Private Sub cmdTrunck_Click(sender As Object, e As EventArgs) Handles cmdTrunck.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trunc(string =  , width = , side = c(""right"" , ""left"", ""center"") , ellipsis =  )", 63)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trunc( )", 2)
        End If
    End Sub

    Private Sub cmdEnds_Click(sender As Object, e As EventArgs) Handles cmdEnds.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_ends(string = , pattern = , negate = FALSE)", 39)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_ends( )", 2)
        End If
    End Sub

    Private Sub cmdSortF_Click(sender As Object, e As EventArgs) Handles cmdSortF.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sort(x = , decreasing = FALSE )", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sort( )", 2)
        End If
    End Sub

    Private Sub cmdBigZ_Click(sender As Object, e As EventArgs) Handles cmdBigZ.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigz(a = , mod = NA )", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigz( )", 2)
        End If
    End Sub

    Private Sub cmdIsPrime_Click(sender As Object, e As EventArgs) Handles cmdIsPrime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::isprime(n = , reps = )", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::isprime( )", 2)
        End If
    End Sub

    Private Sub cmdFactorial_Click(sender As Object, e As EventArgs) Handles cmdFactorial.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::factorialZ(n = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::factorialZ( )", 2)
        End If
    End Sub

    Private Sub cmdChoosez_Click(sender As Object, e As EventArgs) Handles cmdChoosez.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::chooseZ(n = , k = )", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::chooseZ( )", 2)
        End If
    End Sub

    Private Sub cmdNextPrime_Click(sender As Object, e As EventArgs) Handles cmdNextPrime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::nextprime(n= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::nextprime( )", 2)
        End If
    End Sub

    Private Sub cmdFibonacci_Click(sender As Object, e As EventArgs) Handles cmdFibonacci.Click
        Dim clsFibonacciFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsFibonacciFunction.SetPackageName("Zseq")
        clsFibonacciFunction.SetRCommand("Fibonacci")
        clsFibonacciFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsFibonacciFunction.ToScript, 0)
    End Sub


    Private Sub cmdDivisors_Click(sender As Object, e As EventArgs) Handles cmdDivisors.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Divisors(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Divisors( )", 2)
        End If
    End Sub

    Private Sub cmdRankPercent_Click(sender As Object, e As EventArgs) Handles cmdRankPercent.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::PercentRank(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::PercentRank( )", 2)
        End If
    End Sub

    Private Sub cmdDigitSum_Click(sender As Object, e As EventArgs) Handles cmdDigitSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::DigitSum(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::DigitSum( )", 2)
        End If
    End Sub

    Private Sub cmdBigQ_Click(sender As Object, e As EventArgs) Handles cmdBigQ.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigq(a = , mod = NA )", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigq( )", 2)
        End If
    End Sub

    Private Sub cmdBinary_Click(sender As Object, e As EventArgs) Handles cmdBinary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToBin(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToBin( )", 2)
        End If
    End Sub

    Private Sub cmdAsOctmode_Click(sender As Object, e As EventArgs) Handles cmdOctal.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToOct(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToOct( )", 2)
        End If
    End Sub

    Private Sub cmdAsHexmode_Click(sender As Object, e As EventArgs) Handles cmdHex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToHex(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToHex( )", 2)
        End If
    End Sub

    Private Sub cmdIntegerRHelp_Click(sender As Object, e As EventArgs) Handles cmdIntegerRHelp.Click, GmpToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "gmp"
        End If
        OpenHelpPage()
    End Sub

    Private Sub DescToolsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescToolsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "DescTools"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ConfdesignToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfdesignToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "conf.design"
        End If
        OpenHelpPage()
    End Sub

    Private Sub RutilsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutilsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "R.utils"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdNthPrime_Click(sender As Object, e As EventArgs) Handles cmdNthPrime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::nth_prime(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::nth_prime( )", 2)
        End If
    End Sub

    Private Sub PrimesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrimesToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "primes"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdGeneratePrimes_Click(sender As Object, e As EventArgs) Handles cmdGeneratePrimes.Click
        Dim clsNRowsFunction As New RFunction
        Dim clsGeneratePrimesFunction As New RFunction

        clsNRowsFunction.SetRCommand("nrow")
        clsNRowsFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsGeneratePrimesFunction.SetPackageName("primes")
        clsGeneratePrimesFunction.SetRCommand("generate_n_primes")
        clsGeneratePrimesFunction.AddParameter("n", clsRFunctionParameter:=clsNRowsFunction, iPosition:=0)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsGeneratePrimesFunction.ToScript, 0)
    End Sub

    Private Sub cmdReverseStr_Click(sender As Object, e As EventArgs) Handles cmdReverseStr.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringi::stri_reverse(str= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringi::stri_reverse( )", 2)
        End If
    End Sub

    Private Sub cmdGCD_Click(sender As Object, e As EventArgs) Handles cmdGCD.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::gcd(m= , n= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::gcd( , )", 4)
        End If
    End Sub

    Private Sub cmdSCM_Click(sender As Object, e As EventArgs) Handles cmdSCM.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::scm(m= , n= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::scm( , )", 4)
        End If
    End Sub

    Private Sub cmdCoprime_Click(sender As Object, e As EventArgs) Handles cmdCoprime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::coprime(m= , n= )", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::coprime( , )", 4)
        End If
    End Sub

    Private Sub cmdPhi_Click(sender As Object, e As EventArgs) Handles cmdPhi.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::phi(n= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::phi( )", 2)
        End If
    End Sub

    Private Sub PrimeFunctions(strRCommand As String)
        Dim clsPrimesFunction As New RFunction

        clsPrimesFunction.SetPackageName("primes")
        clsPrimesFunction.SetRCommand(strRCommand)
        clsPrimesFunction.AddParameter("min", "0", iPosition:=0)
        clsPrimesFunction.AddParameter("max", "1000000", iPosition:=1)

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsPrimesFunction, iPosition:=0)
        clsRepFunction.AddParameter("len", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 0)
    End Sub


    Private Sub cmdTwin_Click(sender As Object, e As EventArgs) Handles cmdTwin.Click
        PrimeFunctions("twin_primes")
    End Sub

    Private Sub cmdCousin_Click(sender As Object, e As EventArgs) Handles cmdCousin.Click
        PrimeFunctions("cousin_primes")
    End Sub

    Private Sub cmdSexy_Click(sender As Object, e As EventArgs) Handles cmdSexy.Click
        PrimeFunctions("sexy_primes")
    End Sub

    Private Sub cmdThird_Click(sender As Object, e As EventArgs) Handles cmdThird.Click
        PrimeFunctions("third_cousin_primes")
    End Sub

    Private Sub cmdTriplets_Click(sender As Object, e As EventArgs) Handles cmdTriplets.Click
        PrimeFunctions("sexy_prime_triplets")
    End Sub

    Private Sub cmdKTuple_Click(sender As Object, e As EventArgs) Handles cmdKTuple.Click
        Dim clsKTuplePrimeFunction As New RFunction
        Dim clsTuplePatternFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsTuplePatternFunction.SetRCommand("c")
        clsTuplePatternFunction.AddParameter("x", "0", iPosition:=0, bIncludeArgumentName:=False)
        clsTuplePatternFunction.AddParameter("y", "2", iPosition:=1, bIncludeArgumentName:=False)
        clsTuplePatternFunction.AddParameter("z", "8", iPosition:=2, bIncludeArgumentName:=False)

        clsKTuplePrimeFunction.SetPackageName("primes")
        clsKTuplePrimeFunction.SetRCommand("k_tuple")
        clsKTuplePrimeFunction.AddParameter("min", "0", iPosition:=0)
        clsKTuplePrimeFunction.AddParameter("max", "1000000", iPosition:=1)
        clsKTuplePrimeFunction.AddParameter("tuple", clsRFunctionParameter:=clsTuplePatternFunction, iPosition:=2)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsKTuplePrimeFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRepFunction.AddParameter("len", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 0)
    End Sub

    Private Sub cmdRoman_Click(sender As Object, e As EventArgs) Handles cmdRoman.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("utils::as.roman(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("utils::as.roman( )", 2)
        End If
    End Sub

    Private Sub ZseqFunctions(strRCommand As String)
        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsZseqFunction.SetPackageName("Zseq")
        clsZseqFunction.SetRCommand(strRCommand)
        clsZseqFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsZseqFunction.AddParameter("gmp", "FALSE", iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsZseqFunction.ToScript, 0)
    End Sub

    Private Sub cmdPalindrome_Click(sender As Object, e As EventArgs) Handles cmdPalindrome.Click
        ZseqFunctions("Palindromic")
    End Sub

    Private Sub cmdCatalan_Click(sender As Object, e As EventArgs) Handles cmdCatalan.Click
        Dim clsCatalanFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsCatalanFunction.SetPackageName("Zseq")
        clsCatalanFunction.SetRCommand("Catalan")
        clsCatalanFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsCatalanFunction.ToScript, 0)
    End Sub


    Private Sub cmdAbundant_Click(sender As Object, e As EventArgs) Handles cmdAbundant.Click
        ZseqFunctions("Abundant")
    End Sub

    Private Sub cmdFrugal_Click(sender As Object, e As EventArgs) Handles cmdFrugal.Click
        ZseqFunctions("Frugal")
    End Sub

    Private Sub cmdPowerful_Click(sender As Object, e As EventArgs) Handles cmdPowerful.Click
        ZseqFunctions("Powerful")
    End Sub

    Private Sub cmdHappy_Click(sender As Object, e As EventArgs) Handles cmdHappy.Click
        ZseqFunctions("Happy")
    End Sub

    Private Sub cmdAchilles_Click(sender As Object, e As EventArgs) Handles cmdAchilles.Click
        ZseqFunctions("Achilles")
    End Sub

    Private Sub cmdPadovan_Click(sender As Object, e As EventArgs) Handles cmdPadovan.Click
        Dim clsPadovanFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsPadovanFunction.SetPackageName("Zseq")
        clsPadovanFunction.SetRCommand("Padovan")
        clsPadovanFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsPadovanFunction.ToScript, 0)
    End Sub

    Private Sub cmdTriangle_Click(sender As Object, e As EventArgs) Handles cmdTriangle.Click
        ZseqFunctions("Triangular")
    End Sub

    Private Sub cmdSquare_Click(sender As Object, e As EventArgs) Handles cmdSquare.Click
        ZseqFunctions("Square")
    End Sub

    Private Sub cmdPerfect_Click(sender As Object, e As EventArgs) Handles cmdPerfect.Click
        Dim clsPerfectFunction As New RFunction

        clsPerfectFunction.SetPackageName("Zseq")
        clsPerfectFunction.SetRCommand("Perfect")
        clsPerfectFunction.AddParameter("n", "10", iPosition:=0)

        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsPerfectFunction, iPosition:=0)
        clsRepFunction.AddParameter("length", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 0)
    End Sub


    Private Sub cmdUgly_Click(sender As Object, e As EventArgs) Handles cmdUgly.Click
        Dim clsUglyFunction As New RFunction

        clsUglyFunction.SetPackageName("Zseq")
        clsUglyFunction.SetRCommand("Regular")
        clsUglyFunction.AddParameter("n", "100", iPosition:=0)
        clsUglyFunction.AddParameter("gmp", "FALSE", iPosition:=1)

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsUglyFunction, iPosition:=0)
        clsRepFunction.AddParameter("length", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 0)
    End Sub

    Private Sub cmdOctmode_Click(sender As Object, e As EventArgs) Handles cmdOctmode.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.octmode(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.octmode( )", 2)
        End If
    End Sub

    Private Sub cmdHexmode_Click(sender As Object, e As EventArgs) Handles cmdHexmode.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.hexmode(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.hexmode( )", 2)
        End If
    End Sub

    Private Sub cmdFactorize_Click(sender As Object, e As EventArgs) Handles cmdFactorize.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Factorize(n= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Factorize( )", 2)
        End If
    End Sub

    Private Sub ZseqToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZseqToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "Zseq"
        End If
        OpenHelpPage()
    End Sub

    Private Sub UtilsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "utils"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdCumProd_Click(sender As Object, e As EventArgs) Handles cmdCumProd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumprod(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumprod( )", 2)
        End If
    End Sub

    Private Sub cmdMovProd_Click(sender As Object, e As EventArgs) Handles cmdMovProd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply(data = , width = 3, FUN = prod , by = 1, by.column = TRUE, fill = NA, na.pad = FALSE, partial = FALSE, align = c(""center"", ""left"", ""right""), coredata = TRUE)", 150)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply( , width = 3, FUN = prod, fill = NA, align= ""center"")", 53)
        End If
    End Sub

    Private Sub cmdRev_Click(sender As Object, e As EventArgs) Handles cmdRev.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rev(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rev( )", 2)
        End If
    End Sub

    Private Sub cmdTransformRHelp_Click(sender As Object, e As EventArgs) Handles cmdTransformRHelp.Click, BaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Transform" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub DplyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DplyrToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Transform" Then
            strPackageName = "dplyr"
        End If
        OpenHelpPage()
    End Sub

    Private Sub MASSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MASSToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Transform" Then
            strPackageName = "MASS"
        End If
        OpenHelpPage()
    End Sub


    Private Sub ScalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScalesToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Transform" Then
            strPackageName = "scales"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ZooToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZooToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Transform" Then
            strPackageName = "zoo"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdLucas_Click(sender As Object, e As EventArgs) Handles cmdLucas.Click
        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsZseqFunction.SetPackageName("Zseq")
        clsZseqFunction.SetRCommand("Lucas")
        clsZseqFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsZseqFunction.AddParameter("gmp", "TRUE", iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsZseqFunction.ToScript, 0)
    End Sub

    Private Sub cmdPrimorial_Click(sender As Object, e As EventArgs) Handles cmdPrimorial.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,primes::primorial_n)", 22)
    End Sub

    Private Sub cmdFactorize2_Click(sender As Object, e As EventArgs) Handles cmdFactorize2.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("conf.design::factorize( )", 2)
    End Sub

    Private Sub cmdFreqLength_Click(sender As Object, e As EventArgs) Handles cmdFreqLength.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length(x=rep(x= ,times= ))", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length(rep( , ))", 5)
        End If
    End Sub

    Private Sub cmdFreqSum_Click(sender As Object, e As EventArgs) Handles cmdFreqSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(x=rep(x= ,times= ),na.rm= TRUE)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(rep(, ),na.rm=TRUE)", 15)
        End If
    End Sub

    Private Sub cmdFreqMin_Click(sender As Object, e As EventArgs) Handles cmdFreqMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(x=rep(x= ,times= ), na.rm= TRUE)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(rep( , ), na.rm= TRUE)", 18)
        End If
    End Sub

    Private Sub cmdFreqMax_Click(sender As Object, e As EventArgs) Handles cmdFreqMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max(x=rep(x= ,times= ), na.rm= TRUE)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max(rep( , ), na.rm= TRUE)", 18)
        End If
    End Sub

    Private Sub cmdFreqMode1_Click(sender As Object, e As EventArgs) Handles cmdFreqMode1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv1(rep(x = , times= ), na.rm = TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("statip::mfv1(rep( , ), na.rm = TRUE)", 19)
        End If
    End Sub

    Private Sub cmdFreqMiss_Click(sender As Object, e As EventArgs) Handles cmdFreqMiss.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(x=is.na(rep(x= ,times= )))", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na(rep( , )))", 5)
        End If
    End Sub

    Private Sub cmdFreqMean_Click(sender As Object, e As EventArgs) Handles cmdFreqMean.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x=rep(x= ,times= ), na.rm= TRUE)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(rep( , ), na.rm=TRUE)", 16)
        End If
    End Sub

    Private Sub cmdFreqMedian_Click(sender As Object, e As EventArgs) Handles cmdFreqMedian.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(x=rep(x= ,times= ), na.rm= TRUE)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(rep( , ), na.rm=TRUE)", 17)
        End If
    End Sub

    Private Sub cmdFreqVar_Click(sender As Object, e As EventArgs) Handles cmdFreqVar.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::var(x = rep(x= ,times= ), na.rm = TRUE)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::var(rep( , ), na.rm=TRUE)", 17)
        End If
    End Sub

    Private Sub cmdFreqSd_Click(sender As Object, e As EventArgs) Handles cmdFreqSd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::sd(x = rep(x= ,times= ), na.rm = TRUE)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::sd(rep( , ), na.rm=TRUE)", 17)
        End If
    End Sub

    Private Sub cmdFreqMad_Click(sender As Object, e As EventArgs) Handles cmdFreqMad.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::mad(x = rep(x= ,times= ), na.rm = TRUE)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::mad(rep( , ), na.rm=TRUE)", 17)
        End If
    End Sub

    Private Sub cmdFreqIQR_Click(sender As Object, e As EventArgs) Handles cmdFreqIQR.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::IQR(x = rep(x= ,times= ), na.rm = TRUE)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::IQR(rep( , ), na.rm=TRUE)", 17)
        End If
    End Sub

    Private Sub cmdFreqDistinct_Click(sender As Object, e As EventArgs) Handles cmdFreqDistinct.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::n_distinct(x = rep(x= ,times= ))", 10)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::n_distinct(rep( , ))", 5)
        End If
    End Sub

    Private Sub cmdFreqPropn_Click(sender As Object, e As EventArgs) Handles cmdFreqPropn.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x= rep(x= <=1, ), na.rm = TRUE))", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(rep( <=1, ), na.rm = TRUE)", 21)
        End If
    End Sub

    Private Sub cmdFreqQuantile_Click(sender As Object, e As EventArgs) Handles cmdFreqQuantile.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile(x= rep(x= , times= ), probs= 0.2, na.rm = TRUE))", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile(rep( , ), 0.2, na.rm = TRUE)", 24)
        End If
    End Sub

    Private Sub StatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub StatipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatipToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "statip"
        End If
        OpenHelpPage()
    End Sub

    Private Sub E1071ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles E1071ToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "e1071"
        End If
        OpenHelpPage()
    End Sub

    Private Sub RobustbaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RobustbaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "robustbase"
        End If
        OpenHelpPage()
    End Sub

    Private Sub RasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RasterToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "raster"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdSummaryRHelp_Click(sender As Object, e As EventArgs) Handles cmdSummaryRHelp.Click, BaseToolStripMenuItem1.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRhelpList_Click(sender As Object, e As EventArgs) Handles cmdRhelpList.Click, ListBaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "List" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ListStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListStatsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "List" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ListStatipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListStatipToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "List" Then
            strPackageName = "statip"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdComplexRHelp_Click(sender As Object, e As EventArgs) Handles cmdComplexRHelp.Click, ComplexBaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Complex" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdWakefieldHelp_Click(sender As Object, e As EventArgs) Handles cmdWakefieldHelp.Click, WakefieldToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Wakefield" Then
            strPackageName = "wakefield"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdCircularHelp_Click(sender As Object, e As EventArgs) Handles cmdCircularHelp.Click, CircularToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Circular" Then
            strPackageName = "circular"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdHydroHelp_Click(sender As Object, e As EventArgs) Handles cmdHydroHelp.Click, HydroGOFToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Goodness of Fit " Then
            strPackageName = "hydroGOF"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdMathsHelp_Click(sender As Object, e As EventArgs) Handles cmdMathsHelp.Click, MathsBaseStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Maths" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub MathsStatsStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathsStatsStripMenuItem.Click
        If ucrInputCalOptions.GetText = "Maths" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub MathsCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathsCarToolStripMenuItem.Click
        If ucrInputCalOptions.GetText = "Maths" Then
            strPackageName = "car"
        End If
        OpenHelpPage()
    End Sub

    Private Sub MathsCircularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MathsCircularToolStripMenuItem.Click
        If ucrInputCalOptions.GetText = "Maths" Then
            strPackageName = "circular"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdTransformHelp_Click(sender As Object, e As EventArgs) Handles cmdTransformHelp.Click, FactorForcatsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Factor" Then
            strPackageName = "forcats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdLogicalHelp_Click(sender As Object, e As EventArgs) Handles cmdLogicalHelp.Click, LogBaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Logical and Symbols" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub LogDplyrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogDplyrToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Logical and Symbols" Then
            strPackageName = "dplyr"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdStringRHelp_Click(sender As Object, e As EventArgs) Handles cmdStringRHelp.Click, TxTStringrToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Text/Strings (Character Columns)" Then
            strPackageName = "stringr"
        End If
        OpenHelpPage()
    End Sub

    Private Sub TxTBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TxTBaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Text/Strings (Character Columns)" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdProbRHelp_Click(sender As Object, e As EventArgs) Handles cmdProbRHelp.Click, ProbStatsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Probability" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ProbBaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbBaseToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Probability" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelp_Click(sender As Object, e As EventArgs) Handles cmdRHelp.Click, DateLubridateToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Dates/Times" Then
            strPackageName = "lubridate"
        End If
        OpenHelpPage()
    End Sub

    Private Sub DateHmsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateHmsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Dates/Times" Then
            strPackageName = "hms"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmduniform_Click(sender As Object, e As EventArgs) Handles cmduniform.Click
        Dim clsUniformFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsUniformFunction.SetRCommand("runif")
        clsUniformFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsUniformFunction.AddParameter("min", "0", iPosition:=1)
        clsUniformFunction.AddParameter("max", "1", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsUniformFunction.ToScript, 0)
    End Sub

    Private Sub cmdpoisson_Click(sender As Object, e As EventArgs) Handles cmdpoisson.Click
        Dim clsPoissonFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsPoissonFunction.SetRCommand("rpois")
        clsPoissonFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsPoissonFunction.AddParameter("lambda", "1", iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsPoissonFunction.ToScript, 0)
    End Sub

    Private Sub cmdRan_normal_Click(sender As Object, e As EventArgs) Handles cmdRan_normal.Click
        Dim clsNormalFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsNormalFunction.SetRCommand("rnorm")
        clsNormalFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsNormalFunction.AddParameter("mean", "0", iPosition:=1)
        clsNormalFunction.AddParameter("sd", "1", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsNormalFunction.ToScript, 0)
    End Sub

    Private Sub cmduni_integer_Click(sender As Object, e As EventArgs) Handles cmduni_integer.Click
        Dim clsUnitegerFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsUnitegerFunction.SetRCommand("sample.int")
        clsUnitegerFunction.AddParameter("n", "5", iPosition:=0)
        clsUnitegerFunction.AddParameter("size", clsRFunctionParameter:=clsDataFunction, iPosition:=1)
        clsUnitegerFunction.AddParameter("replace", "TRUE", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsUnitegerFunction.ToScript, 0)
    End Sub

    Private Sub cmdbernoulli_Click(sender As Object, e As EventArgs) Handles cmdbernoulli.Click
        Dim clsBernoulliFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsBernoulliFunction.SetRCommand("rbinom")
        clsBernoulliFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsBernoulliFunction.AddParameter("size", "1", iPosition:=1)
        clsBernoulliFunction.AddParameter("prob", "0.5", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsBernoulliFunction.ToScript, 0)
    End Sub

    Private Sub cmdbinomial_Click(sender As Object, e As EventArgs) Handles cmdbinomial.Click
        Dim clsBinomialFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsBinomialFunction.SetRCommand("rbinom")
        clsBinomialFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsBinomialFunction.AddParameter("size", "3", iPosition:=1)
        clsBinomialFunction.AddParameter("prob", "0.5", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsBinomialFunction.ToScript, 0)
    End Sub

    Private Sub cmdnbinomial_Click(sender As Object, e As EventArgs) Handles cmdnbinomial.Click
        Dim clsNbinomialFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsNbinomialFunction.SetRCommand("rnbinom")
        clsNbinomialFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsNbinomialFunction.AddParameter("size", "1", iPosition:=1)
        clsNbinomialFunction.AddParameter("prob", "0.5", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsNbinomialFunction.ToScript, 0)
    End Sub

    Private Sub cmdRan_gamma_Click(sender As Object, e As EventArgs) Handles cmdRan_gamma.Click
        Dim clsGammaFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsGammaFunction.SetRCommand("rgamma")
        clsGammaFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsGammaFunction.AddParameter("shape", "1", iPosition:=1)
        clsGammaFunction.AddParameter("scale", "2", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsGammaFunction.ToScript, 0)
    End Sub

    Private Sub cmdRan_beta_Click(sender As Object, e As EventArgs) Handles cmdRan_beta.Click
        Dim clsBetaFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsBetaFunction.SetRCommand("rbeta")
        clsBetaFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsBetaFunction.AddParameter("shape1", "1", iPosition:=1)
        clsBetaFunction.AddParameter("shape2", "1", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsBetaFunction.ToScript, 0)
    End Sub

    Private Sub cmdRan_sample_Click(sender As Object, e As EventArgs) Handles cmdRan_sample.Click
        Dim clsSampleFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsSampleFunction.SetRCommand("sample")
        clsSampleFunction.AddParameter("x", " ", iPosition:=0)
        clsSampleFunction.AddParameter("size", clsRFunctionParameter:=clsDataFunction, iPosition:=1)
        clsSampleFunction.AddParameter("replace", "TRUE", iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsSampleFunction.ToScript, 36)
    End Sub

    Private Sub cmdComplex_Click(sender As Object, e As EventArgs) Handles cmdComplex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("complex(length.out= 0,real= numeric(),imaginary= numeric(),modulus= 1,argument= 0)", 0)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("complex(real= ,imaginary= )", 14)
        End If
    End Sub

    Private Sub cmdComplexAsin_Click(sender As Object, e As EventArgs) Handles cmdComplexAsin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin( )", 2)
        End If
    End Sub

    Private Sub cmdComplexAcos_Click(sender As Object, e As EventArgs) Handles cmdComplexAcos.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos( )", 2)
        End If
    End Sub

    Private Sub cmdComplexAtan_Click(sender As Object, e As EventArgs) Handles cmdComplexAtan.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan( )", 2)
        End If
    End Sub

    Private Sub cmdReal_Click(sender As Object, e As EventArgs) Handles cmdReal.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Re(z= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Re( )", 2)
        End If
    End Sub

    Private Sub cmdImaginary_Click(sender As Object, e As EventArgs) Handles cmdImaginary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Im(z= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Im( )", 2)
        End If
    End Sub

    Private Sub cmdMod_Click(sender As Object, e As EventArgs) Handles cmdMod.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Mod(z= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Mod( )", 2)
        End If
    End Sub

    Private Sub cmdArg_Click(sender As Object, e As EventArgs) Handles cmdArg.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Arg(z= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Arg( )", 2)
        End If
    End Sub

    Private Sub cmdConjugate_Click(sender As Object, e As EventArgs) Handles cmdConjugate.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Conj(z= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("Conj( )", 2)
        End If
    End Sub

    Private Sub cmdComplexi_Click(sender As Object, e As EventArgs) Handles cmdComplexi.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("i", -1)
    End Sub

    Private Sub cmdAsComplex_Click(sender As Object, e As EventArgs) Handles cmdAsComplex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.complex(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.complex( )", 2)
        End If
    End Sub

    Private Sub cmdComplexLog_Click(sender As Object, e As EventArgs) Handles cmdComplexLog.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log(x= , base=exp(1))", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log( )", 2)
        End If
    End Sub

    Private Sub cmdComplexSqrt_Click_1(sender As Object, e As EventArgs) Handles cmdComplexSqrt.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sqrt(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sqrt( )", 2)
        End If
    End Sub

    Private Sub cmdComplexRound_Click(sender As Object, e As EventArgs) Handles cmdComplexRound.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round(x= , digits=0)", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round( )", 2)
        End If
    End Sub

    Private Sub cmdComplexExp_Click_1(sender As Object, e As EventArgs) Handles cmdComplexExp.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp( )", 2)
        End If
    End Sub

    Private Sub cmdComplexSignif_Click(sender As Object, e As EventArgs) Handles cmdComplexSignif.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif(x= , digits=6)", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif( )", 2)
        End If
    End Sub

    Private Sub cmdComplexCos_Click(sender As Object, e As EventArgs) Handles cmdComplexCos.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos( )", 2)
        End If
    End Sub

    Private Sub cmdComplexSin_Click(sender As Object, e As EventArgs) Handles cmdComplexSin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin( )", 2)
        End If
    End Sub

    Private Sub cmdComplexTan_Click(sender As Object, e As EventArgs) Handles cmdComplexTan.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan( )", 2)
        End If
    End Sub

    Private Sub cmdComplexCosH_Click(sender As Object, e As EventArgs) Handles cmdComplexCosH.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cosh(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cosh( )", 2)
        End If
    End Sub

    Private Sub cmdComplexSinH_Click(sender As Object, e As EventArgs) Handles cmdComplexSinH.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sinh(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sinh( )", 2)
        End If
    End Sub

    Private Sub cmdComplexTanH_Click(sender As Object, e As EventArgs) Handles cmdComplexTanH.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tanh(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tanh( )", 2)
        End If
    End Sub

    Private Sub cmdComplexRad_Click(sender As Object, e As EventArgs) Handles cmdComplexRad.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rad( )", 2)
    End Sub

    Private Sub cmdComplexDeg_Click(sender As Object, e As EventArgs) Handles cmdComplexDeg.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::deg( )", 2)
    End Sub

    Private Sub cmdComplexPi_Click(sender As Object, e As EventArgs) Handles cmdComplexPi.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pi", -1)
    End Sub

    Private Sub cmdScale_Click(sender As Object, e As EventArgs) Handles cmdScale.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("scale( , center = TRUE, scale = TRUE)", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("scale( )", 2)
        End If
    End Sub

    Private Sub cmdListLength_Click(sender As Object, e As EventArgs) Handles cmdListLength.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,length)", 9)
    End Sub

    Private Sub cmdListSum_Click(sender As Object, e As EventArgs) Handles cmdListSum.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,sum)", 6)
    End Sub

    Private Sub cmdListProd_Click(sender As Object, e As EventArgs) Handles cmdListProd.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,prod)", 8)
    End Sub

    Private Sub cmdListMin_Click(sender As Object, e As EventArgs) Handles cmdListMin.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,min)", 6)
    End Sub

    Private Sub cmdListMax_Click(sender As Object, e As EventArgs) Handles cmdListMax.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,max)", 6)
    End Sub

    Private Sub cmdListRange_Click(sender As Object, e As EventArgs) Handles cmdListRange.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lapply(  , range)", 9)
    End Sub

    Private Sub cmdListMean_Click(sender As Object, e As EventArgs) Handles cmdListMean.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  , mean)", 8)
    End Sub

    Private Sub cmdListMedian_Click(sender As Object, e As EventArgs) Handles cmdListMedian.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  , median)", 10)
    End Sub

    Private Sub cmdListMode_Click(sender As Object, e As EventArgs) Handles cmdListMode.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lapply(  ,statip::mfv)", 14)
    End Sub

    Private Sub cmdListMode1_Click(sender As Object, e As EventArgs) Handles cmdListMode1.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,statip::mfv1)", 15)
    End Sub

    Private Sub cmdListSsq_Click(sender As Object, e As EventArgs) Handles cmdListSsq.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , function(x) {sum(x*x)})", 28)
    End Sub

    Private Sub cmdListVar_Click(sender As Object, e As EventArgs) Handles cmdListVar.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , var)", 7)
    End Sub

    Private Sub cmdListSd_Click(sender As Object, e As EventArgs) Handles cmdListSd.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , sd)", 6)
    End Sub

    Private Sub cmdListMad_Click(sender As Object, e As EventArgs) Handles cmdListMad.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , stats::mad)", 14)
    End Sub

    Private Sub cmdListIQR_Click(sender As Object, e As EventArgs) Handles cmdListIQR.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , IQR)", 7)
    End Sub

    Private Sub cmdListDistinct_Click(sender As Object, e As EventArgs) Handles cmdListDistinct.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , dplyr::n_distinct)", 21)
    End Sub

    Private Sub cmdListAnyDup_Click(sender As Object, e As EventArgs) Handles cmdListAnyDup.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , anyDuplicated)", 17)
    End Sub

    Private Sub cmdListFirst_Click(sender As Object, e As EventArgs) Handles cmdListFirst.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , dplyr::first)", 15)
    End Sub

    Private Sub cmdListLast_Click(sender As Object, e As EventArgs) Handles cmdListLast.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , dplyr::last)", 16)
    End Sub

    Private Sub cmdListNth_Click(sender As Object, e As EventArgs) Handles cmdListNth.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( ,dplyr::nth, 2)", 16)
    End Sub

    Private Sub cmdListQuantile_Click(sender As Object, e As EventArgs) Handles cmdListQuantile.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lapply(  ,quantile,prob=c(0.2,0.5,0.8))", 31)
    End Sub

    Private Sub cmdListDigitsum_Click(sender As Object, e As EventArgs) Handles cmdListDigitsum.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,DescTools::DigitSum)", 22)
    End Sub

    Private Sub cmdListSumd_Click(sender As Object, e As EventArgs) Handles cmdListSumd.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(sapply(  ,DescTools::DigitSum),sum)", 27)
    End Sub

    Private Sub cmdListFivenum_Click(sender As Object, e As EventArgs) Handles cmdListFivenum.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lapply( ,fivenum)", 10)
    End Sub

    Private Sub cmdListMissing_Click(sender As Object, e As EventArgs) Handles cmdListMissing.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("  ,na.rm=TRUE")
    End Sub

    Private Sub cmdListAdd_Click(sender As Object, e As EventArgs) Handles cmdListAdd.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) x + 10)", 21)
    End Sub

    Private Sub cmdListSubtract_Click(sender As Object, e As EventArgs) Handles cmdListSubtract.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) x - 10)", 21)
    End Sub

    Private Sub cmdListMultiply_Click(sender As Object, e As EventArgs) Handles cmdListMultiply.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) x * 10)", 21)
    End Sub

    Private Sub cmdListDivide_Click(sender As Object, e As EventArgs) Handles cmdListDivide.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) x / 10)", 21)
    End Sub

    Private Sub cmdListSquare_Click(sender As Object, e As EventArgs) Handles cmdListSquare.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) x^2)", 19)
    End Sub

    Private Sub cmdListRound_Click(sender As Object, e As EventArgs) Handles cmdListRound.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( ,round,3)", 10)
    End Sub

    Private Sub cmdListProportion_Click(sender As Object, e As EventArgs) Handles cmdListProportion.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) x/sum(x))", 24)
    End Sub

    Private Sub cmdListPercent_Click(sender As Object, e As EventArgs) Handles cmdListPercent.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) 100*x/sum(x))", 27)
    End Sub

    Private Sub cmdListPercent2_Click(sender As Object, e As EventArgs) Handles cmdListPercent2.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,function(x) round(x/sum(x)*100,2))", 37)
    End Sub

    Private Sub cmdListSQRT_Click(sender As Object, e As EventArgs) Handles cmdListSQRT.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( ,sqrt)", 7)
    End Sub

    Private Sub cmdListSort_Click(sender As Object, e As EventArgs) Handles cmdListSort.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,sort, FALSE)", 14)
    End Sub

    Private Sub cmdListRank_Click(sender As Object, e As EventArgs) Handles cmdListRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,rank)", 7)
    End Sub

    Private Sub cmdListLag_Click(sender As Object, e As EventArgs) Handles cmdListLag.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,dplyr::lag)", 13)
    End Sub

    Private Sub cmdListLead_Click(sender As Object, e As EventArgs) Handles cmdListLead.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,dplyr::lead)", 14)
    End Sub

    Private Sub cmdListDiff_Click(sender As Object, e As EventArgs) Handles cmdListDiff.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,diff)", 7)
    End Sub

    Private Sub cmdListScale_Click(sender As Object, e As EventArgs) Handles cmdListScale.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) {round(scale(x),3)})", 34)
    End Sub

    Private Sub cmdListCumsum_Click(sender As Object, e As EventArgs) Handles cmdListCumsum.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,cumsum)", 9)
    End Sub

    Private Sub cmdListMovsum_Click(sender As Object, e As EventArgs) Handles cmdListMovsum.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,zoo::rollsum,3,NA)", 19)
    End Sub

    Private Sub cmdListRev_Click(sender As Object, e As EventArgs) Handles cmdListRev.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,rev)", 6)
    End Sub

    Private Sub cmdListOmit_Click(sender As Object, e As EventArgs) Handles cmdListOmit.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" sapply( ,na.omit)", 10)
    End Sub

    Private Sub cmdListIfelse_Click(sender As Object, e As EventArgs) Handles cmdListIfelse.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  , function(x) {ifelse(x < 10, -1,1)})", 38)
    End Sub

    Private Sub cmdListMod_Click(sender As Object, e As EventArgs) Handles cmdListMod.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,function(x) {x %% 10})", 24)
    End Sub

    Private Sub cmdListDiv_Click(sender As Object, e As EventArgs) Handles cmdListDiv.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   ,function(x) { x %/% 10})", 26)
    End Sub

    Private Sub cmdListOperator_Click(sender As Object, e As EventArgs) Handles cmdListOperator.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(   , function(x) { x > 10 })", 26)
    End Sub

    Private Sub cmdListDuplicated_Click(sender As Object, e As EventArgs) Handles cmdListDuplicated.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(  ,duplicated)", 13)
    End Sub

    Private Sub cmdwhichmax_Click(sender As Object, e As EventArgs) Handles cmdwhichmax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which.max(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which.max( )", 2)
        End If
    End Sub

    Private Sub cmdwheremin_Click(sender As Object, e As EventArgs) Handles cmdwheremin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" [which.min(x= )]", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" [which.min( )]", 15)
        End If
    End Sub

    Private Sub cmdwhichmin_Click(sender As Object, e As EventArgs) Handles cmdwhichmin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which.min(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("which.min( )", 2)
        End If
    End Sub

    Private Sub cmdwheremax_Click(sender As Object, e As EventArgs) Handles cmdwheremax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" [which.max(x= )]", 17)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" [which.max( )]", 15)
        End If
    End Sub

    'Functions keyboard
    Private Sub cmdAve_Click(sender As Object, e As EventArgs) Handles cmdAve.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave( )", 2)
        End If
    End Sub

    Private Sub cmdAveFun_Click(sender As Object, e As EventArgs) Handles cmdAveFun.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(x= ,FUN=function(x) mean(x, na.rm=TRUE))", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave( ,FUN=mean)", 11)
        End If
    End Sub

    Private Sub cmdAveFac_Click(sender As Object, e As EventArgs) Handles cmdAveFac.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(x= , )", 4)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(, )", 3)
        End If
    End Sub

    Private Sub cmdAveBoth_Click(sender As Object, e As EventArgs) Handles cmdAveBoth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(x= , , FUN=function(x) mean(x, trim=0.1))", 39)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave( , ,FUN=mean)", 13)
        End If
    End Sub

    Private Sub cmdFunctionsSsq_Click(sender As Object, e As EventArgs) Handles cmdFunctionsSsq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(x= ,FUN= function(x) sum(x*x,na.rm=TRUE))", 39)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave( ,FUN= function(x) sum(x*x,na.rm=TRUE))", 39)
        End If
    End Sub

    Private Sub cmdFunctionsSsqSession_Click(sender As Object, e As EventArgs) Handles cmdFunctionsSsqSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ssq(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ssq( )", 2)
        End If
    End Sub

    Private Sub cmdCssq_Click(sender As Object, e As EventArgs) Handles cmdCssq.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave(x= ,FUN=function(x) sum((x - mean(x,na.rm=TRUE))^2,na.rm=TRUE))", 61)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ave( ,FUN=function(x) sum((x - mean(x,na.rm=TRUE))^2,na.rm=TRUE))", 61)
        End If
    End Sub

    Private Sub cmdCssqSession_Click(sender As Object, e As EventArgs) Handles cmdCssqSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cssq(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cssq( )", 2)
        End If
    End Sub

    Private Sub cmdPolynomial_Click(sender As Object, e As EventArgs) Handles cmdPolynomial.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("polynom::polynomial(coef= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("polynom::polynomial( )", 2)
        End If
    End Sub

    Private Sub cmdOrigin_Click(sender As Object, e As EventArgs) Handles cmdOrigin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("polynom::change.origin(  p= ,o= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("polynom::change.origin(, )", 3)
        End If
    End Sub

    Private Sub cmdRoots_Click(sender As Object, e As EventArgs) Handles cmdRoots.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" c(polyroot(z= ),NA) ", 7)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(polyroot( ),NA) ", 7)
        End If
    End Sub

    Private Sub cmdCoeffs_Click(sender As Object, e As EventArgs) Handles cmdCoeffs.Click
        Dim clsCoeffsFunction As New RFunction

        Dim dataFrameName As String = ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem
        Dim DataFunctionCoeffs As String = " [1:nrow(" & dataFrameName & ")-1]"

        clsCoeffsFunction.SetPackageName("polynom")
        clsCoeffsFunction.SetRCommand("poly.calc")
        clsCoeffsFunction.AddParameter("s", DataFunctionCoeffs, iPosition:=0, bIncludeArgumentName:=False)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsCoeffsFunction.ToScript, 22)
    End Sub

    Private Sub cmdProd_Click(sender As Object, e As EventArgs) Handles cmdProd.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" prod(x= , na.rm=TRUE) ", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("prod( , na.rm=TRUE)", 14)
        End If
    End Sub

    Private Sub cmdCombn_Click(sender As Object, e As EventArgs) Handles cmdCombn.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("combn(x- ,m- ,FUN=prod, na.rm=TRUE)", 27)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("combn( , ,FUN=prod, na.rm=TRUE)", 25)
        End If
    End Sub

    Private Sub cmdCoef_Click(sender As Object, e As EventArgs) Handles cmdCoef.Click
        Dim clsSumCoefFunction As New RFunction
        Dim clsCmbnCoefFunction As New RFunction
        Dim clsReFunction As New RFunction
        Dim dataFrameName As String = ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem
        Dim DataFunctionCoef As String = " [1:nrow(" & dataFrameName & ")-1]"

        clsReFunction.SetRCommand("Re")
        clsReFunction.AddParameter("c", clsRFunctionParameter:=clsSumCoefFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSumCoefFunction.SetRCommand("sum")
        clsSumCoefFunction.AddParameter("s", clsRFunctionParameter:=clsCmbnCoefFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsCmbnCoefFunction.SetRCommand("combn")
        clsCmbnCoefFunction.AddParameter("d", DataFunctionCoef, iPosition:=0, bIncludeArgumentName:=False)
        clsCmbnCoefFunction.AddParameter("var", "0", iPosition:=1, bIncludeArgumentName:=False)
        clsCmbnCoefFunction.AddParameter("FUN", "prod", iPosition:=2)
        clsCmbnCoefFunction.AddParameter("na.rm", "TRUE", iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsReFunction.ToScript, 49)
    End Sub

    Private Sub cmdCoeffs2_Click(sender As Object, e As EventArgs) Handles cmdCoeffs2.Click
        Dim clsCoeffs2Function As New RFunction
        Dim clsMapFunction As New RFunction
        Dim clsSumFunction As New RFunction
        Dim clsCmbnFunction As New RFunction

        Dim dataFrameName As String = ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem
        Dim DataFunction1 As String = "(nrow(" & dataFrameName & ")-1):0"
        Dim DataFunction2 As String = " [1:nrow(" & dataFrameName & ")-1]"

        clsCoeffs2Function.AddParameter("map", clsRFunctionParameter:=clsMapFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsCoeffs2Function.SetRCommand("as.numeric")
        clsMapFunction.SetPackageName("purrr")
        clsMapFunction.SetRCommand("map")
        clsMapFunction.AddParameter(".x", DataFunction1, iPosition:=0)
        clsCmbnFunction.SetRCommand("combn")
        clsCmbnFunction.AddParameter("k", DataFunction2, bIncludeArgumentName:=False, iPosition:=0)
        clsCmbnFunction.AddParameter("var", ".x", iPosition:=1, bIncludeArgumentName:=False)
        clsCmbnFunction.AddParameter("FUN", "prod", iPosition:=2)
        clsSumFunction.SetRCommand("~sum")
        clsSumFunction.AddParameter("y", clsRFunctionParameter:=clsCmbnFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsMapFunction.AddParameter(".f", clsRFunctionParameter:=clsSumFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsCoeffs2Function.ToScript, 39)
    End Sub

    Private Sub cmdDigitssqSession_Click(sender As Object, e As EventArgs) Handles cmddigitssqSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digitssq(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digitssq( )", 2)
        End If
    End Sub

    Private Sub cmdDigitssq_Click(sender As Object, e As EventArgs) Handles cmdDigitssq.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( ,function(n){a<-as.integer(c(strsplit(as.character(n),split="""")[[1]])); sum(a^2)})", 83)
    End Sub

    Private Sub cmdRHelpFunctions_Click(sender As Object, e As EventArgs) Handles cmdRhelpFunctions.Click, MASSFunctionsToolStripMenuItem1.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Functions" Then
            strPackageName = "MASS"
        End If
        OpenHelpPage()
    End Sub

    Private Sub UtilsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UtilsToolStripMenuItem1.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Functions" Then
            strPackageName = "utils"
        End If
        OpenHelpPage()
    End Sub

    Private Sub MASSFunctionsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MASSFunctionsToolStripMenuItem1.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Functions" Then
            strPackageName = "MASS"
        End If
        OpenHelpPage()
    End Sub

    Private Sub PolynomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PolynomToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Functions" Then
            strPackageName = "polynom"
        End If
        OpenHelpPage()
    End Sub

    Private Sub StatsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StatsToolStripMenuItem1.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Functions" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdPascal_Click(sender As Object, e As EventArgs) Handles cmdPascal.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( , function(x) {lapply(x, function(i) {choose(i, 0:i)})})", 57)
    End Sub

    Private Sub cmdPascalSession_Click(sender As Object, e As EventArgs) Handles cmdPascalSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pascal(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pascal( )", 2)
        End If
    End Sub

    Private Sub cmdDigitsqu_Click(sender As Object, e As EventArgs) Handles cmdDigitsqu.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(" sapply( , function(n) {a<-as.integer(c(strsplit(as.character(n), split= """")[[1]])); a^2})", 82)
    End Sub

    Private Sub cmdDigitsquSession_Click(sender As Object, e As EventArgs) Handles cmdDigitsquSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digitsqu(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digitsqu( )", 2)
        End If
    End Sub

    Private Sub cmdFunctionsDigitsum_Click(sender As Object, e As EventArgs) Handles cmdFunctionsDigitsum.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( , function(n){a<-as.integer(c(strsplit(as.character(n),split="""")[[1]]));sum(a)})", 81)
    End Sub

    Private Sub cmdDigitsumSession_Click(sender As Object, e As EventArgs) Handles cmdDigitsumSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digitsum(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digitsum( )", 2)
        End If
    End Sub

    Private Sub cmdMASSFractions_Click(sender As Object, e As EventArgs) Handles cmdMASSFractions.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.character(MASS::fractions( , cycles = 10, max.denominator = 2000))", 40)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.character(MASS::fractions( ))", 3)
        End If
    End Sub

    Private Sub cmdMASSFractionsSession_Click(sender As Object, e As EventArgs) Handles cmdMASSFractionsSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("fractions(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("fractions( )", 2)
        End If
    End Sub

    Private Sub cmdDecimals_Click(sender As Object, e As EventArgs) Handles cmdDecimals.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(X = , FUN = function(v) {sapply(X = v,FUN = function(w) eval(parse(text=w)))})", 75)
    End Sub

    Private Sub cmdDecimalsSession_Click(sender As Object, e As EventArgs) Handles cmdDecimalsSession.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("decimals(x= )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("decimals( )", 2)
        End If
    End Sub
End Class