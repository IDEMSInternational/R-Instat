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
        ucrInputCalOptions.SetItems({"Basic", "Maths", "Logical and Symbols", "Summary", "Text/Strings (Character Columns)", "Factor", "Probability", "Dates/Times", "Transform", "Wakefield", "Circular", "hydroGOF", "Integer"}) ' "Rows" is a temp. name
        ucrInputCalOptions.SetDropDownStyleAsNonEditable()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations

        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")

        'Temp disabled::Needs discussions to see if they are needed
        bControlsInitialised = True
        ttCalculator.SetToolTip(cmdRound, "round(x) to round to whole numbers, round(x,2) to round to 2 decimal places, round(x,-2) to round to the nearest 100")
        ttCalculator.SetToolTip(cmdSiginf, "signif(x,3) to round to 3 significant figures")

        ttCalculator.SetToolTip(cmdSortF, "sorts a vector into ascending or descending order. For example sort(c(5,7,4,4,3)) = (3,4,4,5,7)")
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
        ttCalculator.SetToolTip(cmdPercentRank, "rescale of minimum ranks to [0,1]. For example percent_rank(c(15,11,13,12,NA,12)) = (1,0,0.75,0.25,NA,0.25)")
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

        ttCalculator.SetToolTip(cmdBigZ, "encodes arbitrarily large integers")
        ttCalculator.SetToolTip(cmdBigQ, "encodes rationals encoded as ratios or arbitrarily large integers")
        ttCalculator.SetToolTip(cmdFactorial, "factorial n!, as big integer. For example, factorialZ(6)= 720")
        ttCalculator.SetToolTip(cmdChoosez, "computes binomial coefficient choose(n,k) as a big integer. For example, chooseZ(20,2)=190")
        ttCalculator.SetToolTip(cmdNextPrime, "gives the next prime number. For example, nextprime(14)= 17")
        ttCalculator.SetToolTip(cmdFactorize, "compute the prime factorizations. For example, Factorize(20)= (2,5,2,1)")
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
        ttCalculator.SetToolTip(cmdFibonacci2, "generates fibonacci numbers to the length of the data frame. For example the 10th fibonacci number is just 34, but the 50th is much larger, 7778742049")
        ttCalculator.SetToolTip(cmdAbundant, "when divisors sum to more than the number. So 12 is less than 1+2+3+4+6 = 16. Opposite is Deficient")
        ttCalculator.SetToolTip(cmdPerfect, "divisors add to the number. So 6 = 1+2+3. Only 51 perfect numbers are currently known.")
        ttCalculator.SetToolTip(cmdFrugal, "125 is frugal because 125 = 5(cubed) and 5 and 3 are fewer digits (2) than 125 (3).")
        ttCalculator.SetToolTip(cmdPowerful, "36 = 2(squared)*3(squared) is powerful because for each divisor, here 2 and 3, its square is also a divisor.")
        ttCalculator.SetToolTip(cmdUgly, "also called Regular or Hamming or 5-smooth numbers. Numbers for which the factors are only 2, or 3 or 5.")
        ttCalculator.SetToolTip(cmdHappy, "13 is happy because 1(squared) + 3(squared) = 10, then 1(squared)+ 0(squared) = 1.")
        ttCalculator.SetToolTip(cmdAchilles, "powerful numbers that are not perfect squares. 72 is the smallest Achilles number.")
        ttCalculator.SetToolTip(cmdPadovan, "sum of last but 1 and last but 2 values. So from ...7, 9, 12, next is 7+9 = 16.")
        ttCalculator.SetToolTip(cmdTriangle, "number of objects in a triangle, so 0, 1, 3, 6, 10...")
        ttCalculator.SetToolTip(cmdSquare, "squares of each integer, so 1, 4, 9, 16.")
        ttCalculator.SetToolTip(cmdLucas, "generartes lucas numbers to the length of the dataframe. For example the 10th lucas number is 76")

        ttCalculator.SetToolTip(cmdLength, "number of observations: For example length(c(1,2,3,4,NA)) = 5 ")
        ttCalculator.SetToolTip(cmdSum, "the sum or total: So sum(c(1,2,3,4,10)) = 20 ")
        ttCalculator.SetToolTip(cmdMin, "the smallest value: So min(c(4,3,10,1,2)) = 1 ")
        ttCalculator.SetToolTip(cmdMax, "the largest value: So max(c(4,3,10,1,2)) = 10 ")
        ttCalculator.SetToolTip(cmdRange, "gives both the min and the max. Use max - min to give the value of the range")
        ttCalculator.SetToolTip(cmdMiss, "the number of missing values. So miss(c( NA,2,3,4,NA)) = 2")
        ttCalculator.SetToolTip(cmdMean, "the average, usually sum/length. So mean(c(1,2,3,4,10)) = 4")
        ttCalculator.SetToolTip(cmdMedian, "the value halfway up the values in order. So median(c(1,2,3,4,10) = 3")
        ttCalculator.SetToolTip(cmdMode, "the most popular value. So mode(c(10,2,2,3,3) = 2 and 3")
        ttCalculator.SetToolTip(cmdMode1, "the first mode. So mode1(c(10,2,2,3,3)) = 2")
        ttCalculator.SetToolTip(cmdNonMiss, "the number of non-missing values. So nonmiss(c(1,2,3,4,NA)) = 4")
        ttCalculator.SetToolTip(cmdVar, "the variance. The average of the squared deviations from the mean - dividing by (n-1)")
        ttCalculator.SetToolTip(cmdSd, "the standard deviation. A typical distance from the mean. Often roughly a quarter of the range of the data.")
        ttCalculator.SetToolTip(cmdMad, "the median of the absolute deviations from the median. So mad(c(1,2,3,4,10)) = median of (2,1,0,1,7). Median = 1 and multiplied by 1.483 to be like the sd for normally distributed data.")
        ttCalculator.SetToolTip(cmdIQR, "the interquartile range. So, for (1,2,3,4,10) the upper quartile=4, lower=2, so IQR = 2.")
        ttCalculator.SetToolTip(cmdDistinct, "the number of different values in the variable. So distinct(c(1,2,3,3,NA,NA)) = 4")
        ttCalculator.SetToolTip(cmdCv, "coefficient of variation, namely 100 * sd/mean. So cv(c(1,2,3,4,10)) = 100*3.536/4 = 88.4.")
        ttCalculator.SetToolTip(cmdMc, "median couple. A robust measure of skewness, between -1 and +1. mc(c(1,1,4,4,5)) = -0.5, while mc(c(2,3,3,4,10)) = 0.375.")
        ttCalculator.SetToolTip(cmdSkew, "skewness defined as third central moment/sd^3. For skew(c(1,1,4,4,5)) = -0.18, while skew(2,3,3,4,10) = 0.95.")
        ttCalculator.SetToolTip(cmdKurtosis, "kurtosis defined as 4th central moment/sd^4 -3. A measure of peakedness which is zero for normally distributed data.")
        ttCalculator.SetToolTip(cmdAnyDup, "the row number of the first duplicated value, or 0 if no duplicates. So anydup(c(1,2,3,3,10) = 4.")
        ttCalculator.SetToolTip(cmdPropn, "proportion of variable less than (or more than) a specified value. So prop(c(0,1,1,4,10) <=1) = 0.6.")
        ttCalculator.SetToolTip(cmdFirst, "value in the first row. So first(c(NA,7,8,9,10)) is NA. Also first(c(NA,7,8,9,10),order=(2,3,0,1,2)) = 8.")
        ttCalculator.SetToolTip(cmdLast, "value in the last row. So last(c(NA,7,8,9,10)) = 10. Also last(c(NA,7,8,9,10),order=c(2,3,0,1,2)) = 7")
        ttCalculator.SetToolTip(cmdnth, "value in nth row, So nth(c(NA,7,8,9,10)) = 8. Also nth(c(NA,7,7,9,10),3,order=c(2,3,0,1,2))= NA.")
        ttCalculator.SetToolTip(cmdCor, "correlation between 2 variables. It is a value between -1 and +1.")
        ttCalculator.SetToolTip(cmdCov, "covariance between 2 variables.")
        ttCalculator.SetToolTip(cmdQuantile, "a quantile, given a value between 0 and 1. So quantile(c(1,2,3,4,10), 0.25) = 2 and is the lower quartile.")

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
                strPackageName = "stats"
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
                Me.Size = New Size(iBasicWidth * 1.38, iBaseHeight)
            Case "Logical and Symbols"
                strPackageName = "base"
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
            Case "Summary"
                strPackageName = "base"
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
            Case "Text/Strings (Character Columns)"
                strPackageName = "stringr"
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
                Me.Size = New Size(iBasicWidth * 1.42, iBaseHeight)
            Case "Factor"
                strPackageName = "base"
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
            Case "Probability"
                strPackageName = "stats"
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
                Me.Size = New Size(iBasicWidth * 1.57, iBaseHeight)
            Case "Dates/Times"
                strPackageName = "lubridate"
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
                Me.Size = New Size(iBasicWidth * 1.32, iBaseHeight)
            Case "Transform"
                strPackageName = "dplyr"
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
                Me.Size = New Size(iBasicWidth * 1.47, iBaseHeight)
            Case "Wakefield"
                strPackageName = "wakefield"
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
                Me.Size = New Size(iBasicWidth * 1.8, iBaseHeight)
            Case "Circular"
                strPackageName = "circular"
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
                Me.Size = New Size(iBasicWidth * 1.39, iBaseHeight)
            Case "hydroGOF"
                strPackageName = "hydroGOF"
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
                Me.Size = New Size(iBasicWidth * 1.27, iBaseHeight)
            Case "Integer"
                strPackageName = "gmp"
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
                Me.Size = New Size(iBasicWidth * 1.5, iBaseHeight)
            Case "Basic"
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
            Case Else
                grpDates.Visible = False
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad(string = , width = , side = c('left', 'right', 'both') , pad = )", 56)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad()", 1)
        End If
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order(x = , decreasing = FALSE , na_last = TRUE)", 40)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order()", 1)
        End If
    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort(x= , decreasing = FALSE , na_last = TRUE , locale = ' ')", 53)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect(string = , pattern = , negate = FALSE)", 31)
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

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSub.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sub(string="""", start = 1L, end = -1L)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sub()", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::minute(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::minute()", 1)
        End If
    End Sub
    Private Sub cmdSec_Click(sender As Object, e As EventArgs) Handles cmdSec.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::second(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::second()", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::days_in_month(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::days_in_month()", 1)
        End If
    End Sub
    Private Sub cmdQuarter_Click(sender As Object, e As EventArgs) Handles cmdQuarter.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::quarter(x =, with_year = FALSE, fiscal_start = 1 )", 39)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::quarter()", 1)
        End If
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

    Private Sub cmdpmax_Click(sender As Object, e As EventArgs) Handles cmdPMax.Click
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

    Private Sub cmdcummax_Click(sender As Object, e As EventArgs) Handles cmdCumMax.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax()", 1)
        End If
    End Sub

    Private Sub cmdcummin_Click(sender As Object, e As EventArgs) Handles cmdCumMin.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin()", 1)
        End If
    End Sub

    Private Sub cmdcumsum_Click(sender As Object, e As EventArgs) Handles cmdCumSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum()", 1)
        End If
    End Sub

    Private Sub cmdpercentrank_Click(sender As Object, e As EventArgs) Handles cmdPercentRank.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank()", 1)
        End If
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        RaiseEvent SelectionChanged()
    End Sub


    Private Sub OpenHelpPage()
        Dim clsHelp As New RFunction

        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript,
                                   strComment:="Opening help page for " &
                                   strPackageName & " Package. Generated from dialog Calculator",
                                   iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdRHelp.Click, cmdHydroHelp.Click, cmdCircularHelp.Click, cmdWakefieldHelp.Click, cmdMathsHelp.Click, cmdLogicalHelp.Click, cmdProbRHelp.Click, cmdStringRHelp.Click
        OpenHelpPage()
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

    Private Sub cmdmovemean_Click(sender As Object, e As EventArgs) Handles cmdMovMean.Click
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("robustbase::mc(x = , na.rm = TRUE, doReflect = (length(x = ) <= 100),doScale = TRUE, maxit = 100, trace.lev = 0, full.result = FALSE)", 113)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("robustbase::mc( , na.rm = TRUE)", 16)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::skewness(x = , na.rm = TRUE, type = 3)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::skewness( , na.rm = TRUE)", 16)
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

    Private Sub cmdDate_Stamp_Click(sender As Object, e As EventArgs) Handles cmdDate_Stamp.Click
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

    Private Sub cmdDied_Click(sender As Object, e As EventArgs) Handles cmdDied.Click
        Dim clsWakefieldDiedFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldDiedFunction.SetPackageName("wakefield")
        clsWakefieldDiedFunction.SetRCommand("died")
        clsWakefieldDiedFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldDiedFunction.AddParameter("prob", "NULL", iPosition:=1)
        clsWakefieldDiedFunction.AddParameter("name", Chr(34) & "Died" & Chr(34), iPosition:=2)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldDiedFunction.ToScript, 0)
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

    Private Sub cmdInternet_Browser_Click(sender As Object, e As EventArgs) Handles cmdInternet_Browser.Click
        Dim clsWakefieldInternetBrowserFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsBrowserListFunction As New RFunction
        Dim clsBrowserProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsBrowserListFunction.SetRCommand("c")
        clsBrowserListFunction.AddParameter("chrome", Chr(34) & "Chrome" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsBrowserListFunction.AddParameter("IE", Chr(34) & "IE" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsBrowserListFunction.AddParameter("firefox", Chr(34) & "Firefox" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsBrowserListFunction.AddParameter("safari", Chr(34) & "Safari" & Chr(34), iPosition:=3, bIncludeArgumentName:=False)
        clsBrowserListFunction.AddParameter("opera", Chr(34) & "Opera" & Chr(34), iPosition:=4, bIncludeArgumentName:=False)
        clsBrowserListFunction.AddParameter("android", Chr(34) & "Android" & Chr(34), iPosition:=5, bIncludeArgumentName:=False)

        clsBrowserProbFunction.SetRCommand("c")
        clsBrowserProbFunction.AddParameter("0.5027", "0.5027", iPosition:=0, bIncludeArgumentName:=False)
        clsBrowserProbFunction.AddParameter("0.175", "0.175", iPosition:=1, bIncludeArgumentName:=False)
        clsBrowserProbFunction.AddParameter("0.1689", "0.1689", iPosition:=2, bIncludeArgumentName:=False)
        clsBrowserProbFunction.AddParameter("0.0994", "0.0994", iPosition:=3, bIncludeArgumentName:=False)
        clsBrowserProbFunction.AddParameter("0.017", "0.017", iPosition:=4, bIncludeArgumentName:=False)
        clsBrowserProbFunction.AddParameter("0.0132", "0.0132", iPosition:=5, bIncludeArgumentName:=False)

        clsWakefieldInternetBrowserFunction.SetPackageName("wakefield")
        clsWakefieldInternetBrowserFunction.SetRCommand("internet_browser")
        clsWakefieldInternetBrowserFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldInternetBrowserFunction.AddParameter("x", clsRFunctionParameter:=clsBrowserListFunction, iPosition:=1)
        clsWakefieldInternetBrowserFunction.AddParameter("prob", clsRFunctionParameter:=clsBrowserProbFunction, iPosition:=2)
        clsWakefieldInternetBrowserFunction.AddParameter("name", Chr(34) & "Browser" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldInternetBrowserFunction.ToScript, 0)
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
        clsWakefieldIQFunction.AddParameter("sd", "10", iPosition:=2)
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

    Private Sub cmdLevel_Click(sender As Object, e As EventArgs) Handles cmdLevel.Click
        Dim clsWakefieldLevelFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldLevelFunction.SetPackageName("wakefield")
        clsWakefieldLevelFunction.SetRCommand("level")
        clsWakefieldLevelFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldLevelFunction.AddParameter("x", "1:4", iPosition:=1)
        clsWakefieldLevelFunction.AddParameter("prob", "NULL", iPosition:=2)
        clsWakefieldLevelFunction.AddParameter("name", Chr(34) & "Level" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLevelFunction.ToScript, 0)
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

    Private Sub cmdEla_Click(sender As Object, e As EventArgs) Handles cmdEla.Click
        Dim clsWakefieldElaFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsELAProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsELAProbFunction.SetRCommand("c")
        clsELAProbFunction.AddParameter("0.3161", "0.29829", iPosition:=0, bIncludeArgumentName:=False)
        clsELAProbFunction.AddParameter("0.37257", "0.37257", iPosition:=1, bIncludeArgumentName:=False)
        clsELAProbFunction.AddParameter("0.2233", "0.2233", iPosition:=2, bIncludeArgumentName:=False)
        clsELAProbFunction.AddParameter("0.08803", "0.08803", iPosition:=3, bIncludeArgumentName:=False)

        clsWakefieldElaFunction.SetPackageName("wakefield")
        clsWakefieldElaFunction.SetRCommand("ela")
        clsWakefieldElaFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldElaFunction.AddParameter("x", "1:4", iPosition:=1)
        clsWakefieldElaFunction.AddParameter("prob", clsRFunctionParameter:=clsELAProbFunction, iPosition:=2)
        clsWakefieldElaFunction.AddParameter("name", Chr(34) & "ELA" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldElaFunction.ToScript, 0)
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
        clsWakefieldSatFunction.AddParameter("mean", "1500", iPosition:=1)
        clsWakefieldSatFunction.AddParameter("sd", "100", iPosition:=2)
        clsWakefieldSatFunction.AddParameter("min", "0", iPosition:=3)
        clsWakefieldSatFunction.AddParameter("max", "2400", iPosition:=4)
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

    Private Sub cmdSex_Click(sender As Object, e As EventArgs) Handles cmdSex.Click
        Dim clsWakefieldSexFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction
        Dim clsSexListFunction As New RFunction
        Dim clsSexProbFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsSexListFunction.SetRCommand("c")
        clsSexListFunction.AddParameter("male", Chr(34) & "Male" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsSexListFunction.AddParameter("female", Chr(34) & "Female" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsSexProbFunction.SetRCommand("c")
        clsSexProbFunction.AddParameter("0.51219512195122", "0.51219512195122", iPosition:=0, bIncludeArgumentName:=False)
        clsSexProbFunction.AddParameter("0.48780487804878", "0.48780487804878", iPosition:=1, bIncludeArgumentName:=False)

        clsWakefieldSexFunction.SetPackageName("wakefield")
        clsWakefieldSexFunction.SetRCommand("sex")
        clsWakefieldSexFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldSexFunction.AddParameter("x", clsRFunctionParameter:=clsSexListFunction, iPosition:=1)
        clsWakefieldSexFunction.AddParameter("prob", clsRFunctionParameter:=clsSexProbFunction, iPosition:=2)
        clsWakefieldSexFunction.AddParameter("name", Chr(34) & "Sex" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldSexFunction.ToScript, 0)
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

    Private Sub cmdWakefield_Upper_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Upper.Click
        Dim clsWakefieldUpperFunction As New RFunction
        Dim clsWakefieldNrowFunction As New RFunction

        clsWakefieldNrowFunction.SetRCommand("nrow")
        clsWakefieldNrowFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem, iPosition:=0)

        clsWakefieldUpperFunction.SetPackageName("wakefield")
        clsWakefieldUpperFunction.SetRCommand("upper")
        clsWakefieldUpperFunction.AddParameter("n", clsRFunctionParameter:=clsWakefieldNrowFunction, iPosition:=0)
        clsWakefieldUpperFunction.AddParameter("k", "5", iPosition:=1)
        clsWakefieldUpperFunction.AddParameter("x", "LETTERS", iPosition:=2)
        clsWakefieldUpperFunction.AddParameter("prob", "NULL", iPosition:=3)
        clsWakefieldUpperFunction.AddParameter("name", Chr(34) & "Upper" & Chr(34), iPosition:=4)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldUpperFunction.ToScript, 0)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular:: mean.circular(x = , na.rm = FALSE, control.circular = list())", 44)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply(data = , width = 3, FUN = min , by = 1, by.column = TRUE, fill = NA, na.pad = FALSE, partial = FALSE, align = c(""center"", ""left"", ""right""), coredata = TRUE)", 150)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollapply( , width = 3, FUN = min, fill = NA, align= ""center"")", 52)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(X = , FUN= pbirthday, classes= 365, coincident= 2)", 47)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( , pbirthday)", 13)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply(X= , FUN= qbirthday, classes= 365, coincident= 2)", 47)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sapply( , qbirthday)", 13)
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
        clsWakefieldLikert7Function.AddParameter("name", Chr(34) & "Likert" & Chr(34), iPosition:=3)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsWakefieldLikert7Function.ToScript, 0)
    End Sub

    Private Sub cmdStarts_Click(sender As Object, e As EventArgs) Handles cmdStarts.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_starts(string = , pattern = , negate = FALSE)", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_starts()", 1)
        End If
    End Sub

    Private Sub cmdRemove1_Click(sender As Object, e As EventArgs) Handles cmdRemove1.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove()", 1)
        End If
    End Sub

    Private Sub cmdRemove2_Click(sender As Object, e As EventArgs) Handles cmdRemove2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove_all(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_remove_all()", 1)
        End If
    End Sub

    Private Sub cmdSquishb_Click(sender As Object, e As EventArgs) Handles cmdSquishb.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_squish(string = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_squish()", 1)
        End If
    End Sub

    Private Sub cmdEncodeb_Click(sender As Object, e As EventArgs) Handles cmdEncodeb.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_conv(string = , encoding = )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_conv()", 1)
        End If
    End Sub

    Private Sub cmdExtract2_Click(sender As Object, e As EventArgs) Handles cmdExtract2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract_all(string = , pattern = , simplify = FALSE)", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract_all()", 1)
        End If
    End Sub

    Private Sub cmdLocate2_Click(sender As Object, e As EventArgs) Handles cmdLocate2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate_all(string = , pattern = )", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate_all()", 1)
        End If
    End Sub

    Private Sub cmdReplace2_Click(sender As Object, e As EventArgs) Handles cmdReplace2.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace_all(string = , pattern = , replacement = )", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace_all()", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::count(pattern = , stringr::coll(), ignore_case = FALSE, locale = ""en"")", 55)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("e1071::kurtosis(x = , na.rm = TRUE, type = 3)", 26)
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

    Private Sub cmdDateTime_Click(sender As Object, e As EventArgs) Handles cmdDateTime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::as_datetime(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::as_datetime()", 1)
        End If
    End Sub

    Private Sub cmdTime_Click(sender As Object, e As EventArgs) Handles cmdTime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hms::hms(seconds = , minutes = , hours = , days = )", 32)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("hms::hms()", 1)
        End If
    End Sub

    Private Sub cmdPm_Click(sender As Object, e As EventArgs) Handles cmdPm.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::pm(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::pm()", 1)
        End If
    End Sub

    ''' <summary>
    ''' this will be raised when the input name is changed and even when the ucrSave checkbox checked status is changed
    ''' </summary>
    ''' <param name="ucrChangedControl"></param>
    Private Sub ucrSaveResultInto_SaveNameChanged(ucrChangedControl As ucrCore) Handles ucrSaveResultInto.ControlContentsChanged
        RaiseEvent SaveNameChanged()
    End Sub

    Private Sub cmdGlue_Click(sender As Object, e As EventArgs) Handles cmdGlue.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_glue(.sep = """" , .envir = parent.frame())", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_glue()", 1)
        End If
    End Sub

    Private Sub cmdLenth_Click(sender As Object, e As EventArgs) Handles cmdLenth.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_length(string="""")", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_length()", 1)
        End If
    End Sub

    Private Sub cmdTrunck_Click(sender As Object, e As EventArgs) Handles cmdTrunck.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trunc(string =  , width = , side = c(""right"" , ""left"", ""center"") , ellipsis =  )", 63)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trunc()", 1)
        End If
    End Sub

    Private Sub cmdEnds_Click(sender As Object, e As EventArgs) Handles cmdEnds.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_ends(string = , pattern = , negate = FALSE)", 39)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_ends()", 1)
        End If
    End Sub

    Private Sub cmdSortF_Click(sender As Object, e As EventArgs) Handles cmdSortF.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sort(x = , decreasing = FALSE )", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sort()", 1)
        End If
    End Sub

    Private Sub cmdBigZ_Click(sender As Object, e As EventArgs) Handles cmdBigZ.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigz(a = , mod = NA )", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigz()", 1)
        End If
    End Sub

    Private Sub cmdIsPrime_Click(sender As Object, e As EventArgs) Handles cmdIsPrime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::isprime(n = , reps = )", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::isprime()", 1)
        End If
    End Sub

    Private Sub cmdFactorial_Click(sender As Object, e As EventArgs) Handles cmdFactorial.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::factorialZ(n = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::factorialZ()", 1)
        End If
    End Sub

    Private Sub cmdChoosez_Click(sender As Object, e As EventArgs) Handles cmdChoosez.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::chooseZ(n = , k = )", 8)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::chooseZ()", 1)
        End If
    End Sub

    Private Sub cmdNextPrime_Click(sender As Object, e As EventArgs) Handles cmdNextPrime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::nextprime(n = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::nextprime()", 1)
        End If
    End Sub

    Private Sub cmdFibonacci_Click(sender As Object, e As EventArgs) Handles cmdFibonacci.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Fibonacci(n = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Fibonacci()", 1)
        End If
    End Sub

    Private Sub cmdDivisors_Click(sender As Object, e As EventArgs) Handles cmdDivisors.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Divisors(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Divisors()", 1)
        End If
    End Sub

    Private Sub cmdRankPercent_Click(sender As Object, e As EventArgs) Handles cmdRankPercent.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::PercentRank(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::PercentRank()", 1)
        End If
    End Sub

    Private Sub cmdDigitSum_Click(sender As Object, e As EventArgs) Handles cmdDigitSum.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::DigitSum(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::DigitSum()", 1)
        End If
    End Sub

    Private Sub cmdBigQ_Click(sender As Object, e As EventArgs) Handles cmdBigQ.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigq(a = , mod = NA )", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gmp::as.bigq()", 1)
        End If
    End Sub

    Private Sub cmdBinary_Click(sender As Object, e As EventArgs) Handles cmdBinary.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToBin(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToBin()", 1)
        End If
    End Sub

    Private Sub cmdAsOctmode_Click(sender As Object, e As EventArgs) Handles cmdOctal.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToOct(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToOct()", 1)
        End If
    End Sub

    Private Sub cmdAsHexmode_Click(sender As Object, e As EventArgs) Handles cmdHex.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToHex(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("R.utils::intToHex()", 1)
        End If
    End Sub

    Private Sub cmdIntegerRHelp_Click(sender As Object, e As EventArgs) Handles cmdIntegerRHelp.Click
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

    Private Sub RutilsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RutilsToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "R.utils"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdNthPrime_Click(sender As Object, e As EventArgs) Handles cmdNthPrime.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::nth_prime(x = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::nth_prime()", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringi::stri_reverse(str = )", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringi::stri_reverse()", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("primes::phi()", 1)
        End If
    End Sub

    Private Sub PrimeFunctions(strRCommand As String)
        Dim clsPrimesFunction As New RFunction

        clsPrimesFunction.SetPackageName("primes")
        clsPrimesFunction.SetRCommand(strRCommand)
        clsPrimesFunction.AddParameter("min", "0", iPosition:=0)
        clsPrimesFunction.AddParameter("max", "100", iPosition:=1)

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

        clsKTuplePrimeFunction.SetPackageName("primes")
        clsKTuplePrimeFunction.SetRCommand("k_tuple")
        clsKTuplePrimeFunction.AddParameter("min", "0", iPosition:=0)
        clsKTuplePrimeFunction.AddParameter("max", "100", iPosition:=1)
        clsKTuplePrimeFunction.AddParameter("tuple", clsRFunctionParameter:=clsTuplePatternFunction, iPosition:=2)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsKTuplePrimeFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsRepFunction.AddParameter("len", clsRFunctionParameter:=clsDataFunction, iPosition:=1)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsRepFunction.ToScript, 0)
    End Sub

    Private Sub cmdRoman_Click(sender As Object, e As EventArgs) Handles cmdRoman.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("utils::as.roman(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("utils::as.roman()", 1)
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

    Private Sub cmdFibonnaci_Click(sender As Object, e As EventArgs) Handles cmdFibonacci2.Click
        Dim clsFibonacciFunction As New RFunction

        clsDataFunction.SetRCommand("nrow")
        clsDataFunction.AddParameter("x", ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsFibonacciFunction.SetPackageName("Zseq")
        clsFibonacciFunction.SetRCommand("Fibonacci")
        clsFibonacciFunction.AddParameter("n", clsRFunctionParameter:=clsDataFunction, iPosition:=0)

        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(clsFibonacciFunction.ToScript, 0)
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

        clsDataFunction.SetRCommand("nrow")
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.octmode(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.octmode()", 1)
        End If
    End Sub

    Private Sub cmdHexmode_Click(sender As Object, e As EventArgs) Handles cmdHexmode.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.hexmode(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("as.hexmode()", 1)
        End If
    End Sub

    Private Sub cmdFactorize2_Click(sender As Object, e As EventArgs) Handles cmdFactorize.Click
        If chkShowParameters.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Factorize(n= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("DescTools::Factorize()", 1)
        End If
    End Sub

    Private Sub GmpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GmpToolStripMenuItem.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Integer" Then
            strPackageName = "gmp"
        End If
        OpenHelpPage()
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumprod(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumprod()", 1)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rev(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("rev()", 1)
        End If
    End Sub

    Private Sub cmdTransformRHelp_Click(sender As Object, e As EventArgs) Handles cmdTransformRHelp.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Transform" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
    End Sub

    Private Sub BaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseToolStripMenuItem.Click
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(rep(,),na.rm=TRUE)", 14)
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

    Private Sub BaseToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BaseToolStripMenuItem1.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "base"
        End If
        OpenHelpPage()
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

    Private Sub cmdSummaryRHelp_Click(sender As Object, e As EventArgs) Handles cmdSummaryRHelp.Click
        CalculationsOptions()
        If ucrInputCalOptions.GetText = "Summary" Then
            strPackageName = "base"
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
End Class
