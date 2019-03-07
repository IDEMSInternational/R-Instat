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
    Public Event SaveResultsCheckedChanged()
    Public Event TryCommadClick()
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private iBasicWidth As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        InitialiseControls()
        iBasicWidth = Me.Width
    End Sub

    Private Sub ucrCalculator_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        ucrInputCalOptions.SetItems({"Basic", "Maths", "Logical and Symbols", "Summary", "Strings (Character Columns)", "Probability", "Dates", "Transform", "Wakefield"}) ' "Rows" is a temp. name
        ucrInputCalOptions.SetDropDownStyleAsNonEditable()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        cmdTry.Enabled = False
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
    End Sub

    Public Sub Reset()
        ucrReceiverForCalculation.ResetText()
        ucrInputCalOptions.Reset()
        ucrInputTryMessage.Reset()
        ucrSaveResultInto.Reset()
        ucrSelectorForCalculations.Reset()
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
        If chkShowArguments.Checked Then
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
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpDates.Visible = False
                grpWakefield.Visible = False
                iHelpCalcID = 126
                Me.Size = New Size(iBasicWidth * 1.38, Me.Height)
            Case "Logical and Symbols"
                grpDates.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = True
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                iHelpCalcID = 127
                Me.Size = New Size(iBasicWidth * 1.44, Me.Height)
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
            Case "Summary"
                grpDates.Visible = False
                grpSummary.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                iHelpCalcID = 128
                Me.Size = New Size(iBasicWidth * 1.51, Me.Height)
                grpStrings.Visible = False
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
            Case "Strings (Character Columns)"
                grpDates.Visible = False
                grpStrings.Visible = True
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpProbabilty.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = False
                iHelpCalcID = 129
                Me.Size = New Size(iBasicWidth * 1.42, Me.Height)
            Case "Probability"
                grpDates.Visible = False
                grpProbabilty.Visible = True
                grpStrings.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpTransform.Visible = False
                grpWakefield.Visible = False
                iHelpCalcID = 120
                Me.Size = New Size(iBasicWidth * 1.57, Me.Height)
            Case "Dates"
                grpDates.Visible = True
                grpProbabilty.Visible = False
                grpStrings.Visible = False
                grpSummary.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpTransform.Visible = False
                grpWakefield.Visible = False
                iHelpCalcID = 130
                Me.Size = New Size(iBasicWidth * 1.32, Me.Height)
            Case "Transform"
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
                grpTransform.Visible = True
                grpWakefield.Visible = False
                Me.Size = New Size(iBasicWidth * 1.33, Me.Height)
            Case "Wakefield"
                grpDates.Visible = False
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
                grpTransform.Visible = False
                grpWakefield.Visible = True
                Me.Size = New Size(iBasicWidth * 1.7, Me.Height * 1.07)
            Case Else
                grpDates.Visible = False
                Me.Size = New Size(iBasicWidth, Me.Height)
                grpProbabilty.Visible = False
                grpSummary.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpTransform.Visible = False
                grpStrings.Visible = False
                grpWakefield.Visible = False
                iHelpCalcID = 14
        End Select
    End Sub

    Private Sub cmdRound_Click(sender As Object, e As EventArgs) Handles cmdRound.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round(x= , digits=0)", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round()", 1)
        End If
    End Sub

    Private Sub cmdFloor_Click(sender As Object, e As EventArgs) Handles cmdFloor.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("floor(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("floor()", 1)
        End If
    End Sub

    Private Sub cmdTrunc_Click(sender As Object, e As EventArgs) Handles cmdTrunc.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trunc(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trunc()", 1)
        End If
    End Sub

    Private Sub cmdSign_Click(sender As Object, e As EventArgs) Handles cmdSign.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sign(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sign()", 1)
        End If
    End Sub

    Private Sub cmdAcos_Click(sender As Object, e As EventArgs) Handles cmdAcos.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("acos()", 1)
        End If

    End Sub

    Private Sub cmdAsin_Click(sender As Object, e As EventArgs) Handles cmdAsin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("asin()", 1)
        End If
    End Sub

    Private Sub cmdAtan_Click(sender As Object, e As EventArgs) Handles cmdAtan.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan(x = )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("atan()", 1)
        End If
    End Sub

    Private Sub cmdSiginf_Click(sender As Object, e As EventArgs) Handles cmdSiginf.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif(x= , digits=6)", 11)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif()", 1)
        End If
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cos()", 1)
        End If
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sin()", 1)
        End If
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("tan()", 1)
        End If
    End Sub

    Private Sub cmdAbs_Click(sender As Object, e As EventArgs) Handles cmdAbs.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("abs(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("abs()", 1)
        End If
    End Sub

    Private Sub cmdExp_Click_1(sender As Object, e As EventArgs) Handles cmdExp.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("exp()", 1)
        End If
    End Sub

    Private Sub cmdLogTen_Click(sender As Object, e As EventArgs) Handles cmdLogTen.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log10(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log10()", 1)
        End If
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log(x= , base=exp(1))", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log()", 1)
        End If
    End Sub

    Private Sub cmdSqrt_Click_1(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        If chkShowArguments.Checked Then
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
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("length()", 1)
        End If
    End Sub

    Private Sub cmdMiss_Click(sender As Object, e As EventArgs) Handles cmdMiss.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na(x= ))", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(is.na())", 2)
        End If
    End Sub

    Private Sub cmdSum_Click(sender As Object, e As EventArgs) Handles cmdSum.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(x= , na.rm=TRUE)", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum()", 1)
        End If
    End Sub

    Private Sub cmdMean_Click(sender As Object, e As EventArgs) Handles cmdMean.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x= , trim=0 , na.rm=TRUE)", 23)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean()", 1)
        End If
    End Sub

    Private Sub cmdMax_Click(sender As Object, e As EventArgs) Handles cmdMax.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max(x= , na.rm=TRUE)", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max()", 1)
        End If
    End Sub

    Private Sub cmdMin_Click(sender As Object, e As EventArgs) Handles cmdMin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(x= , na.rm=TRUE)", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min()", 1)
        End If
    End Sub

    Private Sub cmdMedian_Click(sender As Object, e As EventArgs) Handles cmdMedian.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(x= , na.rm=TRUE)", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median()", 1)
        End If
    End Sub

    Private Sub cmdVar_Click(sender As Object, e As EventArgs) Handles cmdVar.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var(x= , y=NULL, na.rm=TRUE)", 22)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var()", 1)
        End If
    End Sub

    Private Sub cmdSd_Click(sender As Object, e As EventArgs) Handles cmdSd.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd(x= , na.rm=TRUE)", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd()", 1)
        End If
    End Sub

    Private Sub cmdRange_Click(sender As Object, e As EventArgs) Handles cmdRange.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range(x= , na.rm=TRUE, finite=FALSE)", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range()", 1)
        End If
    End Sub

    Private Sub cmdQuantile_Click(sender As Object, e As EventArgs) Handles cmdQuantile.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile(x= , probs=0.5, na.rm=TRUE, names=FALSE, type=7)", 45)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile()", 1)
        End If
    End Sub

    Private Sub cmdIQR_Click(sender As Object, e As EventArgs) Handles cmdIQR.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR(x= , na.rm = TRUE, type =7)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR()", 1)
        End If
    End Sub

    Private Sub cmdUpper_Click(sender As Object, e As EventArgs) Handles cmdUpper.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_upper(string = , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_upper()", 1)
        End If
    End Sub

    Private Sub cmdLower_Click(sender As Object, e As EventArgs) Handles cmdLower.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_lower(string= , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_lower()", 1)
        End If
    End Sub

    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_title(string= , locale=' ')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_to_title()", 1)
        End If
    End Sub

    Private Sub cmdTrim_Click(sender As Object, e As EventArgs) Handles cmdTrim.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trim(string= , side = c('both', 'left', 'right))", 35)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_trim()", 1)
        End If
    End Sub

    Private Sub cmdPad_Click(sender As Object, e As EventArgs) Handles cmdPad.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad(string= , width= , side = c('left', 'right', 'both'), pad= )", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_pad()", 1)
        End If
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order(x= , decreasing = FALSE, na_last = TRUE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_order()", 1)
        End If
    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort(x= , decreasing = FALSE, na_last = TRUE, locale = ' ')", 51)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_sort()", 1)
        End If
    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace(string= , pattern=' ' , replacement=' ' )", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_replace()", 1)
        End If
    End Sub

    Private Sub cmdLocate_Click(sender As Object, e As EventArgs) Handles cmdLocate.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate(string= , pattern=' ' )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_locate()", 1)
        End If
    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract(string= , pattern=' ' )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_extract()", 1)
        End If
    End Sub

    Private Sub cmdCountstrings_Click(sender As Object, e As EventArgs) Handles cmdCountstrings.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_count(string= , pattern =' ')", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_count()", 1)
        End If

    End Sub

    Private Sub cmdDetect_Click(sender As Object, e As EventArgs) Handles cmdDetect.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect(string= , pattern=' ' )", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_detect()", 1)
        End If
    End Sub

    Private Sub cmdQnorm_Click(sender As Object, e As EventArgs) Handles cmdQnorm.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm(p= , mean = 0, sd = 1, lower.tail = TRUE, log.p = FALSE)", 53)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm()", 1)
        End If
    End Sub

    Private Sub cmdQt_Click(sender As Object, e As EventArgs) Handles cmdQt.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt(p= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt()", 1)
        End If
    End Sub

    Private Sub cmdQchisq_Click(sender As Object, e As EventArgs) Handles cmdQchisq.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq(p= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq()", 1)
        End If
    End Sub

    Private Sub cmdqF_Click(sender As Object, e As EventArgs) Handles cmdqF.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf(p= , df1= , df2= ,lower.tail = TRUE)", 33)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf()", 1)
        End If
    End Sub

    Private Sub cmdPnorm_Click(sender As Object, e As EventArgs) Handles cmdPnorm.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnorm(q= , mean = 0, sd = 1, lower.tail = True, Log.p = False)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pnorm()", 1)
        End If
    End Sub

    Private Sub cmdPt_Click(sender As Object, e As EventArgs) Handles cmdPt.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt(q= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt()", 1)
        End If
    End Sub

    Private Sub cmdPChisq_Click(sender As Object, e As EventArgs) Handles cmdPChisq.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt()", 1)
        End If
    End Sub

    Private Sub cmdPf_Click(sender As Object, e As EventArgs) Handles cmdPf.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= , lower.tail = TRUE)", 26)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq()", 1)
        End If
    End Sub

    Private Sub cmdChoose_Click(sender As Object, e As EventArgs) Handles cmdChoose.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("choose(n= , k= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("choose()", 1)
        End If
    End Sub

    Private Sub cmdFact_Click(sender As Object, e As EventArgs) Handles cmdFact.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("factorial(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("factorial()", 1)
        End If
    End Sub

    Private Sub cmdBeta_Click(sender As Object, e As EventArgs) Handles cmdBeta.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("beta(a= , b= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("beta()", 1)
        End If
    End Sub

    Private Sub cmdLchoose_Click(sender As Object, e As EventArgs) Handles cmdLchoose.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lchoose(n= , k= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lchoose()", 1)
        End If
    End Sub

    Private Sub cmdLfact_Click(sender As Object, e As EventArgs) Handles cmdLfact.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lfactorial(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lfactorial()", 1)
        End If
    End Sub

    Private Sub cmdLbeta_Click(sender As Object, e As EventArgs) Handles cmdLbeta.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lbeta(a= , b= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lbeta()", 1)
        End If
    End Sub

    Private Sub cmdGamma_Click(sender As Object, e As EventArgs) Handles cmdGamma.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("gamma()", 1)
        End If
    End Sub

    Private Sub cmdLgamma_Click(sender As Object, e As EventArgs) Handles cmdLgamma.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lgamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lgamma()", 1)
        End If
    End Sub

    Private Sub cmdDigamma_Click(sender As Object, e As EventArgs) Handles cmdDigamma.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("digamma()", 1)
        End If
    End Sub

    Private Sub cmdTrigamma_Click(sender As Object, e As EventArgs) Handles cmdTrigamma.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trigamma(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("trigamma()", 1)
        End If
    End Sub

    Private Sub chkSaveResultInto_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResultInto.CheckedChanged
        RaiseEvent SaveResultsCheckedChanged()
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrSelectorForCalculations.DataFrameChanged
        ucrInputTryMessage.SetName("")
        RaiseEvent DataFrameChanged()
    End Sub

    Private Sub cmdCombine_Click(sender As Object, e As EventArgs) Handles cmdCombine.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_c(string= , pattern=' ')", 15)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_c()", 1)
        End If
    End Sub

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSplit.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_split_fixed(string= , pattern=' ', n= )", 19)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stringr::str_split_fixed()", 1)
        End If
    End Sub

    Private Sub cmdYear_Click(sender As Object, e As EventArgs) Handles cmdYear.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::year(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::year()", 1)
        End If
    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs) Handles cmdMonth.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::month(x= , label=FALSE, abbr=TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::month()", 1)
        End If
    End Sub

    Private Sub cmdDay_Click(sender As Object, e As EventArgs) Handles cmdDay.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::day(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::day()", 1)
        End If
    End Sub

    Private Sub cmdWday_Click(sender As Object, e As EventArgs) Handles cmdWday.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::wday(x= , label=FALSE, abbr=TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::wday()", 1)
        End If
    End Sub

    Private Sub cmdYday_Click(sender As Object, e As EventArgs) Handles cmdYday.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::yday(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::yday()", 1)
        End If
    End Sub

    Private Sub cmdDate_Click(sender As Object, e As EventArgs) Handles cmdDate.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::date(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::date()", 1)
        End If
    End Sub

    Private Sub cmdLeap_Click(sender As Object, e As EventArgs) Handles cmdLeap.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::leap_year(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::leap_year()", 1)
        End If
    End Sub

    Private Sub cmdYmd_Click(sender As Object, e As EventArgs) Handles cmdYmd.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::ymd()", 1)
        End If
    End Sub

    Private Sub cmdMdy_Click(sender As Object, e As EventArgs) Handles cmdMdy.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::mdy(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::mdy()", 1)
        End If
    End Sub

    Private Sub cmdDmy_Click(sender As Object, e As EventArgs) Handles cmdDmy.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::dmy(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("lubridate::dmy()", 1)
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
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lag(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lag()", 1)
        End If
    End Sub

    Private Sub cmdLead_Click(sender As Object, e As EventArgs) Handles cmdLead.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lead(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::lead()", 1)
        End If
    End Sub

    Private Sub cmdpmax_Click(sender As Object, e As EventArgs) Handles cmdpmax.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmax(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmax()", 1)
        End If
    End Sub

    Private Sub cmdPMin_Click(sender As Object, e As EventArgs) Handles cmdPMin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pmin()", 1)
        End If
    End Sub

    Private Sub cmdcummax_Click(sender As Object, e As EventArgs) Handles cmdcummax.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummax()", 1)
        End If
    End Sub

    Private Sub cmdcummin_Click(sender As Object, e As EventArgs) Handles cmdcummin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cummin()", 1)
        End If
    End Sub

    Private Sub cmdcumsum_Click(sender As Object, e As EventArgs) Handles cmdcumsum.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cumsum()", 1)
        End If
    End Sub

    Private Sub cmdpercentrank_Click(sender As Object, e As EventArgs) Handles cmdpercentrank.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::percent_rank()", 1)
        End If
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        If ucrReceiverForCalculation.IsEmpty Then
            cmdTry.Enabled = False
        Else
            cmdTry.Enabled = True
        End If
        RaiseEvent SelectionChanged()
    End Sub

    Private Sub ucrSaveResultInto_NameChanged() Handles ucrSaveResultInto.NameChanged
        RaiseEvent SaveNameChanged()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        HelpContent()
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        RaiseEvent TryCommadClick()
    End Sub

    Private Sub HelpContent()
        If iHelpCalcID > 0 Then
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpCalcID.ToString())
        Else
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        End If
    End Sub

    Public Sub SetAsCurrentReceiver()
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
    End Sub

    Private Sub cmdDiff_Click(sender As Object, e As EventArgs) Handles cmdDiff.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(NA, diff(x= , lag = 1, differences = 1))", 29)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("c(NA,diff())", 2)
        End If
    End Sub

    Private Sub cmdEcdf_Click(sender As Object, e As EventArgs) Handles cmdEcdf.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::cume_dist()", 1)
    End Sub

    Private Sub cmdNtile_Click(sender As Object, e As EventArgs) Handles cmdNtile.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::ntile(x= , n=2)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::ntile()", 1)
        End If
    End Sub

    Private Sub cmdMovMax_Click(sender As Object, e As EventArgs) Handles cmdMovMax.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmax(x= , k=3)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmax()", 1)
        End If
    End Sub

    Private Sub cmdMovSum_Click(sender As Object, e As EventArgs) Handles cmdMovSum.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollsum(x= , k=3)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollsum()", 1)
        End If
    End Sub

    Private Sub cmMovMed_Click(sender As Object, e As EventArgs) Handles cmMovMed.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmedian(x= , k=3)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmedian()", 1)
        End If
    End Sub

    Private Sub cmdMRank_Click(sender As Object, e As EventArgs) Handles cmdMRank.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::min_rank()", 1)
    End Sub

    Private Sub cmdmovemean_Click(sender As Object, e As EventArgs) Handles cmdmovemean.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmean(x= , k=3)", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("zoo::rollmean()", 1)
        End If
    End Sub

    Private Sub cmdCumMean_Click(sender As Object, e As EventArgs) Handles cmdCumMean.Click
        If chkShowArguments.Checked Then
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
        If chkShowArguments.Checked Then
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
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::near(x= , y= )", 6)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::near()", 1)
        End If
    End Sub
    Private Sub cmdLogit_Click(sender As Object, e As EventArgs) Handles cmdLogit.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("car::logit(p, percents = Range.p[2] > 1, adjust)", 24)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("car::logit()", 1)
        End If
    End Sub
    Private Sub cmdLogistic_Click(sender As Object, e As EventArgs) Handles cmdLogistic.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::plogis(q, Location = 0, Scale() = 1, lower.tail = True, Log.p = False))", 50)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("stats::plogis()", 1)
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
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("summary_coef_var()", 1)
    End Sub

    Private Sub cmdMad_Click(sender As Object, e As EventArgs) Handles cmdMad.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("summary_median_absolute_deviation()", 1)
    End Sub

    Private Sub cmdMc_Click(sender As Object, e As EventArgs) Handles cmdMc.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("summary_skewness_mc()", 1)
    End Sub

    Private Sub cmdNonMiss_Click(sender As Object, e As EventArgs) Handles cmdNonMiss.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(!is.na(x= ))", 2)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(!is.na())", 2)
        End If
    End Sub

    Private Sub cmdSkew_Click(sender As Object, e As EventArgs) Handles cmdSkew.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("summary_skewness()", 1)
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
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cor(x= , y= , use = ""everything"", method = c(""pearson"", ""kendall"", ""spearman""))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cor()", 1)
        End If
    End Sub

    Private Sub cmdCov_Click(sender As Object, e As EventArgs) Handles cmdCov.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cov(x= , y= , use = ""everything"", method = c(""pearson"", ""kendall"", ""spearman""))", 73)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("cov()", 1)
        End If
    End Sub

    Private Sub cmdRad_Click(sender As Object, e As EventArgs) Handles cmdRad.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::rad()", 1)
    End Sub

    Private Sub cmdDeg_Click(sender As Object, e As EventArgs) Handles cmdDeg.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("circular::deg()", 1)
    End Sub

    Private Sub cmdFirst_Click(sender As Object, e As EventArgs) Handles cmdFirst.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::first(x= , order_by=NULL)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::first()", 1)
        End If
    End Sub

    Private Sub cmdLast_Click(sender As Object, e As EventArgs) Handles cmdLast.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::last(x= , order_by=NULL)", 16)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::last()", 1)
        End If
    End Sub

    Private Sub cmdnth_Click(sender As Object, e As EventArgs) Handles cmdnth.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::nth(x= , n= , order_by=NULL)", 21)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("dplyr::nth()", 1)
        End If
    End Sub

    Private Sub cmdMode_Click(sender As Object, e As EventArgs) Handles cmdMode.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("summary_mode()", 1)
    End Sub

    Private Sub cmdNA_Click(sender As Object, e As EventArgs) Handles cmdNA.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("NA")
    End Sub

    Private Sub cmdWhich_Click(sender As Object, e As EventArgs) Handles cmdWhich.Click
        If chkShowArguments.Checked Then
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
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::age(n = , x = 20:35 , prob = NULL, name = ""Age"")", 40)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::age()", 1)
        End If
    End Sub

    Private Sub cmdAnimal_Click(sender As Object, e As EventArgs) Handles cmdAnimal.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::animal(n = , k =10 , x = wakefield::animal_list, prob = NULL, name = ""Animal"")", 68)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::animal()", 1)
        End If
    End Sub

    Private Sub cmdPet_Click(sender As Object, e As EventArgs) Handles cmdPet.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::pet(n = , x = c(""Dog"" , ""Cat"" , ""None"" , ""Bird"" , ""Horse"") , prob = c(0.365 , 0.304, 0.258 , 0.031 , 0.015) , name = ""Pet"")", 118)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::pet()", 1)
        End If
    End Sub

    Private Sub cmdAnswer_Click(sender As Object, e As EventArgs) Handles cmdAnswer.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::answer(n = , x = c(""No"" , ""Yes""), prob = NULL , name = ""Answer"")", 54)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::answer()", 1)
        End If
    End Sub

    Private Sub cmdCar_Click(sender As Object, e As EventArgs) Handles cmdCar.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::car(n = , x = rownames(datasets::mtcars), prob = NULL, name = ""Car"")", 61)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::car()", 1)
        End If
    End Sub

    Private Sub cmdChildren_Click(sender As Object, e As EventArgs) Handles cmdChildren.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::children(n = , x = 0:10, prob = c(0.25, 0.25, 0.15, 0.15, 0.1, 0.02, 0.02,0.02, 0.02, 0.01, 0.01), name = ""Children"")", 105)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::children()", 1)
        End If
    End Sub

    Private Sub cmdCoin_Click(sender As Object, e As EventArgs) Handles cmdCoin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::coin(""Tails"" , ""Heads"") , prob = NULL , name = ""Coin"")", 49)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::coin()", 1)
        End If
    End Sub

    Private Sub cmdColor_Click(sender As Object, e As EventArgs) Handles cmdColor.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::color(n = , x = c(""Red"" , ""Green"" , ""Blue"" , ""Yellow"" , ""Black"" , ""White"") , prob = NULL, name = ""Color"")", 96)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::color()", 1)
        End If
    End Sub

    Private Sub cmdPrimary_Click(sender As Object, e As EventArgs) Handles cmdPrimary.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::primary(n = ,  x = c(""Red"" , ""Green"" , ""Blue"" , ""Yellow"" , ""Black"" , ""White"") , prob = NULL, name = ""Color"")", 96)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield:: primary()", 1)
        End If
    End Sub

    Private Sub cmdDate_Stamp_Click(sender As Object, e As EventArgs) Handles cmdDate_Stamp.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::date_stamp(n = , random = FALSE , x = NULL , start = Sys.Date() , k = 12 , by = "" - 1 months"" , prob = NULL , name =  ""Date"")", 111)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::date_stamp()", 1)
        End If
    End Sub

    Private Sub cmdDeath_Click(sender As Object, e As EventArgs) Handles cmdDeath.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::death(n = , prob = NULL, name = ""Death"")", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::death()", 1)
        End If
    End Sub

    Private Sub cmdDied_Click(sender As Object, e As EventArgs) Handles cmdDied.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::died(n = , prob = NULL , name = ""Died"")", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::died()", 1)
        End If
    End Sub

    Private Sub cmdDice_Click(sender As Object, e As EventArgs) Handles cmdDice.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dice(n = , x = 1:6 , prob = NULL , name = ""Dice"")", 41)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dice()", 1)
        End If
    End Sub

    Private Sub cmdDna_Click(sender As Object, e As EventArgs) Handles cmdDna.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dna(n = , x = c(""Guanine"", ""Adenine"", ""Thymine"", ""Cytosine""), prob = NULL , name = ""DNA"")", 82)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dna()", 1)
        End If
    End Sub

    Private Sub cmdDob_Click(sender As Object, e As EventArgs) Handles cmdDob.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dob(n = , random = TRUE , x = NULL , start = Sys.Date() - 365 * 15 , k = 365 *2 , by = ""1 days"" , prob = NULL , name = ""DOB"")", 118)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dob()", 1)
        End If
    End Sub

    Private Sub cmdDummy_Click(sender As Object, e As EventArgs) Handles cmdDummy.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dummy(n = , prob = NULL, name = ""Dummy"")", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::dummy()", 1)
        End If
    End Sub

    Private Sub cmdEducation_Click(sender As Object, e As EventArgs) Handles cmdEducation.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield:: education(n = , x = c(""No Schooling Completed"" , ""Nursery School To 8th Grade"" , ""9th Grade To 12th Grade, No Diploma"" , ""Regular High School Diploma"" , ""GED Or Alternative Credential"" , ""Some College , Less than 1 Year"" , ""Some College , 1 Or More Years ,  No Degree"" , ""Associate's Degree"" , ""Bachelor's Degree"" , ""Master's Degree"" , ""Professional School Degree"" , ""Doctorate Degree"") ,  prob = c(0.013 , 0.05 , 0.0850 , 0.246 , 0.039 , 0.064 , 0.15 , 0.075, 0.176 , 0.072 , 0.019 , 0.012) , name = ""Education"")", 500)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::education()", 1)
        End If
    End Sub

    Private Sub cmdEmployment_Click(sender As Object, e As EventArgs) Handles cmdEmployment.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield:: employment(n = , x = c(""Full Time"" , ""Part Time"" , ""Unemployed"" , ""Retired"" , ""Student""), prob = c(0.6, 0.1, 0.1, 0.1, 0.1), Name = ""Employment"")", 131)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::employment()", 1)
        End If
    End Sub

    Private Sub cmdEye_Click(sender As Object, e As EventArgs) Handles cmdEye.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::eye(n =, x = c(""Brown"" , ""Blue"" , ""Green"" , ""Hazel"" , ""Gray"") , prob = c(0.44 , 0.3 , 0.13 , 0.09 , 0.04) , name = ""Eye"")", 114)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::eye()", 1)
        End If
    End Sub

    Private Sub cmdGrade_Level_Click(sender As Object, e As EventArgs) Handles cmdGrade_Level.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade_level(n = , x = c(""K"" , ""1"" , ""2"" , ""3"" , ""4"" , ""5"" , ""6"" , ""7"" , ""8"" , ""9"" , ""10"" ,""11"" , ""12""), prob = NULL, name = ""Grade_Level"")", 123)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade_level()", 1)
        End If
    End Sub

    Private Sub cmdGrade_Click(sender As Object, e As EventArgs) Handles cmdGrade.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade(n = , mean = 88 , sd = 4 , name = ""Grade"" , digits = 1)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::grade()", 1)
        End If
    End Sub

    Private Sub cmdGroup_Click(sender As Object, e As EventArgs) Handles cmdGroup.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::group(n = , x = c(""Control"" , ""Treatment"") , prob = NULL , name = ""Group"")", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::group()", 1)
        End If
    End Sub

    Private Sub cmdHair_Click(sender As Object, e As EventArgs) Handles cmdHair.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::hair(n = , x = c(""Brown"" , ""Black"" , ""Blonde"" , ""Red""), prob = c(0.35 , 0.28, 0.26 , 0.11), name = ""hair"")", 98)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::hair()", 1)
        End If
    End Sub

    Private Sub cmdHeight_Click(sender As Object, e As EventArgs) Handles cmdHeight.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::height(n = , mean = 69 , sd = 3.75 , min = 1 , max = NULL , digits = 0 , name = ""Height"")", 79)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::height()", 1)
        End If
    End Sub

    Private Sub cmdIncome_Click(sender As Object, e As EventArgs) Handles cmdIncome.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::income(n = , digits = 2, name = ""Income"")", 30)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::income()", 1)
        End If
    End Sub

    Private Sub cmdInternet_Browser_Click(sender As Object, e As EventArgs) Handles cmdInternet_Browser.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::internet_browser(n = , x = c(""Chrome"" , ""IE"", ""Firefox"" , ""Safari"" , ""Opera"" , ""Android"") , prob = c(0.5027 , 0.175 , 0.1689 , 0.0994, 0.017, 0.0132) , name = ""Browser"")", 149)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::internet_browser()", 1)
        End If
    End Sub

    Private Sub cmdIq_Click(sender As Object, e As EventArgs) Handles cmdIq.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::iq(n = , mean = 100 , sd = 10 , min = 0 , max = NULL , digits = 0 , name = ""IQ"")", 74)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::iq()", 1)
        End If
    End Sub

    Private Sub cmdLanguage_Click(sender As Object, e As EventArgs) Handles cmdLanguage.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::language(n = , x = wakefield::languages[[""Language""]] , prob = wakefield::languages[[""Proportion""]], name = ""Language"")", 107)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::language()", 1)
        End If
    End Sub

    Private Sub cmdLevel_Click(sender As Object, e As EventArgs) Handles cmdLevel.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::level(n = , x = 1:4 , prob = NULL , name = ""Level"")", 42)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::level()", 1)
        End If
    End Sub
    Private Sub cmdMath_Click(sender As Object, e As EventArgs) Handles cmdMath.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::math(n = , x = 1:4 , prob = c(0.29829 , 0.33332 , 0.22797 , 0.14042) , name = ""Math"")", 77)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::math()", 1)
        End If
    End Sub

    Private Sub cmdEla_Click(sender As Object, e As EventArgs) Handles cmdEla.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::ela(n = , x = 1:4 , prob = c(0.3161 , 0.37257 , 0.2233 , 0.08803) , name = ""ELA"")", 74)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::ela()", 1)
        End If
    End Sub

    Private Sub cmdGpa_Click(sender As Object, e As EventArgs) Handles cmdGpa.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gpa(n = , mean = 88 , sd = 4 , name = ""GPA"")", 37)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gpa()", 1)
        End If
    End Sub

    Private Sub cmdPetLikert_Click(sender As Object, e As EventArgs) Handles cmdLikert.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::likert((n = , x = c(""Strongly Agree"" , ""Agree"" , ""Neutral"" , ""Disagree"" , ""Strongly Disagree""), prob NULL , name = ""Likert"")", 113)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::likert()", 1)
        End If
    End Sub

    Private Sub cmdLorem_Ipsum_Click(sender As Object, e As EventArgs) Handles cmdLorem_ipsum.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::lorem_ipsum(n = , ..., name = ""Lorem_Ipsum"")", 29)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::lorem_ipsum()", 1)
        End If
    End Sub

    Private Sub cmdMarital_Click(sender As Object, e As EventArgs) Handles cmdMarital.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::marital(n = , x = c(""Married"" , ""Divorced"" , ""Widowed"" , ""Separated"" , ""Never Married"") , prob = NULL , name = ""Marital"")", 110)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::marital()", 1)
        End If
    End Sub

    Private Sub cmdMilitary_Click(sender As Object, e As EventArgs) Handles cmdMilitary.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::military(n = , x = c(""Army"", ""Air Force"", ""Navy"", ""Marine Corps"" , ""Coast Guard"") , prob = c(0.3785 , 0.2334 , 0.2218 , 0.1366 , 0.0296) , name = ""Military"")", 144)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::military()", 1)
        End If
    End Sub

    Private Sub cmdWakefield_Month_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Month.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_month(n = , x = month.name , prob = NULL , name = ""Month"")", 49)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_month()", 1)
        End If
    End Sub

    Private Sub cmdName_Click(sender As Object, e As EventArgs) Handles cmdName.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::name(n = , x = wakefield::name_neutral , prob = NULL , replace = FALSE , name = ""Name"")", 79)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::name()", 1)
        End If
    End Sub

    Private Sub cmdNormal_Click(sender As Object, e As EventArgs) Handles cmdNormal.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::normal(n = , mean = 0 , sd = 1 , min = NULL , max = NULL , name = ""Normal"")", 65)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::normal()", 1)
        End If
    End Sub

    Private Sub cmdPolitical_Click(sender As Object, e As EventArgs) Handles cmdPolitical.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::political((n = , x = c(""Democrat"" , ""Republican"" , ""Constitution"" , ""Libertarian"" , ""Green"") , prob = c(0.577269133302094 , 0.410800432748879 , 0.00491084954793489 , 0.00372590303330866 , 0.0032936813677832) , name = ""Political"")", 215)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::political()", 1)
        End If
    End Sub

    Private Sub cmdRace_Click(sender As Object, e As EventArgs) Handles cmdRace.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::race(n = , x = c(""White"" , ""Hispanic"" , ""Black"" , ""Asian"" , ""Bi-Racial"" , ""Native"" , ""Other"" , ""Hawaiian"") , prob = c(0.637 , 0.163 , 0.122 , 0.047 , 0.019 , 0.007 , 0.002 , 0.0015) , name = ""Race"")", 190)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::race()", 1)
        End If
    End Sub

    Private Sub cmdReligion_Click(sender As Object, e As EventArgs) Handles cmdReligion.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::religion(n = , x = c(""Christian"" , ""Muslim"" , ""None"" , ""Hindu"" , ""Buddhist"" , ""Folk"" , ""Other"" , ""Jewish"") , prob = c(0.31477 , 0.23163 , 0.16323 , 0.14985 , 0.07083 , 0.05882 , 0.00859 , 0.00227) , name = ""Religion"")", 205)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::religion()", 1)
        End If
    End Sub

    Private Sub cmdSat_Click(sender As Object, e As EventArgs) Handles cmdSat.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sat(n = , mean = 1500 , sd = 100 , min = 0 , max = 2400 , digits = 0 , name = ""SAT"")", 77)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sat()", 1)
        End If
    End Sub

    Private Sub cmdSentence_Click(sender As Object, e As EventArgs) Handles cmdSentence.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sentence(n = , x = wakefield::presidential_debates_2012 , prob = NULL , name = ""Sentence"")", 78)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sentence()", 1)
        End If
    End Sub

    Private Sub cmdGender_Click(sender As Object, e As EventArgs) Handles cmdGender.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gender(n = , x = c(""Male"" , ""Female"") , prob = c(0.51219512195122 , 0.48780487804878) , name = ""Gender"")", 95)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::gender()", 1)
        End If
    End Sub

    Private Sub cmdSex_Inclusive_Click(sender As Object, e As EventArgs) Handles cmdSex_Inclusive.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex_inclusive(n = , x = c(""Male"" , ""Female"" , ""Intersex"") , prob = NULL , name = ""Sex"")", 70)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex_inclusive()", 1)
        End If
    End Sub

    Private Sub cmdSex_Click(sender As Object, e As EventArgs) Handles cmdSex.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex(n = , x = c(""Male"" , ""Female"") , prob = c(0.51219512195122 , 0.48780487804878) , name = ""Sex"")", 91)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::sex()", 1)
        End If
    End Sub

    Private Sub cmdSmokes_Click(sender As Object, e As EventArgs) Handles cmdSmokes.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::smokes(n = , prob = c(0.822 , 0.178) , name = ""Smokes"")", 45)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::smokes()", 1)
        End If
    End Sub

    Private Sub cmdSpeed_Click(sender As Object, e As EventArgs) Handles cmdSpeed.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::speed(n = , mean = 55 , sd = 10 , min = 0 , max = NULL , digits = 0 , name = ""Speed"")", 76)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::speed()", 1)
        End If
    End Sub

    Private Sub cmdState_Click(sender As Object, e As EventArgs) Handles cmdState.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::state(n = , x = datasets::state.name , prob = wakefield::state_populations[[""Proportion""]], name = ""State"")", 98)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::state()", 1)
        End If
    End Sub

    Private Sub cmdString_Click(sender As Object, e As EventArgs) Handles cmdString.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::string(n = , x = ""[A-Za-z0-9]"" , length = 10 , name = ""String"")", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::string()", 1)
        End If
    End Sub

    Private Sub cmdWakefield_Upper_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Upper.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_upper(n = , k = 5, x = LETTERS , prob = NULL, name = ""Upper"")", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_upper()", 1)
        End If
    End Sub

    Private Sub cmdValid_Click(sender As Object, e As EventArgs) Handles cmdValid.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::Valid(n = , prob = NULL, name = ""Valid"")", 31)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::Valid()", 1)
        End If
    End Sub

    Private Sub cmdWakefield_Year_Click(sender As Object, e As EventArgs) Handles cmdWakefield_Year.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_year(n = , x = 1996:as.numeric(format(Sys.Date() , ""%Y"")) , prob = NULL , name = ""Year"")", 80)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("wakefield::wakefield_year()", 1)
        End If
    End Sub
End Class
