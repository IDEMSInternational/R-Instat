' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Imports RDotNet

Public Class dlgCalculator
    Dim strCalcHistory As List(Of String)
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Public iHelpCalcID As Integer


    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetCalculationHistory()
        ucrReceiverForCalculation.AddtoCombobox(ucrReceiverForCalculation.GetText)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForCalculation.IsEmpty Then
            If chkSaveResultInto.Checked AndAlso ucrSaveResultInto.IsEmpty Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSaveResultInto.SetPrefix("Calc")
        ucrSaveResultInto.Reset()
        ucrInputCalOptions.Reset()
        ucrReceiverForCalculation.Clear()
        ucrInputCalOptions.SetName("Basic")
        chkShowArguments.Checked = False
        chkSaveResultInto.Checked = True
        SaveResults()
        grpDates.Enabled = False
    End Sub

    Private Sub ReopenDialog()
        SaveResults()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 14
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResultInto.SetItemsTypeAsColumns()
        ucrSaveResultInto.SetDefaultTypeAsColumn()
        ucrSaveResultInto.SetDataFrameSelector(ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrSelectorForCalculations.Reset()
        ucrInputCalOptions.SetItems({"Basic", "Maths", "Logical and Symbols", "Summary", "Text", "Runoff", "Dates"})
        ucrSaveResultInto.SetValidationTypeAsRVariable()

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

    Private Sub ucrSaveResultInto_NameChanged() Handles ucrSaveResultInto.NameChanged
        SaveResults()
        TestOKEnabled()
    End Sub

    Private Sub SaveResults()
        If chkSaveResultInto.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveResultInto.GetText(), strTempColumn:=ucrSaveResultInto.GetText(), strTempDataframe:=ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
            ucrBase.clsRsyntax.iCallType = 0
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        strFunc = clsAttach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        strFunc = clsDetach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
        SetCalculationHistory()
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForCalculation.GetVariableNames(False))
        ucrInputTryMessage.SetName("")
        cmdTry.Enabled = Not ucrReceiverForCalculation.IsEmpty()
        TestOKEnabled()
    End Sub

    Private Sub cmdGreater_Click(sender As Object, e As EventArgs) Handles cmdGreater.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(">")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForCalculation.Clear()
    End Sub

    Private Sub cmdLesser_Click(sender As Object, e As EventArgs) Handles cmdLesser.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("<")
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        ucrReceiverForCalculation.Backspace()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrInputCalOptions.NameChanged
        CalculationsOptions()
    End Sub

    Private Sub CalculationsOptions()
        Select Case ucrInputCalOptions.GetText
            Case "Maths"
                grpStatistics.Visible = False
                grpMaths.Visible = True
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                grpProbabilty.Visible = False
                iHelpCalcID = 126
                Me.Size = New System.Drawing.Size(659, 377)
            Case "Logical and Symbols"
                grpDates.Visible = False
                grpStatistics.Visible = False
                grpLogical.Visible = True
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                Me.Size = New System.Drawing.Size(617, 377)
                grpProbabilty.Visible = False
                iHelpCalcID = 127


            Case "Summary"
                grpDates.Visible = False
                grpStatistics.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(600, 377)
                grpStrings.Visible = False
                grpProbabilty.Visible = False
                iHelpCalcID = 128
            Case "Text"
                grpDates.Visible = False
                grpStrings.Visible = True
                grpStatistics.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpProbabilty.Visible = False
                Me.Size = New System.Drawing.Size(491, 377)
                iHelpCalcID = 338
            Case "Runoff"
                grpDates.Visible = False
                grpProbabilty.Visible = True
                grpStrings.Visible = False
                grpStatistics.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(779, 377)
                iHelpCalcID = 120
            Case "Dates"
                grpDates.Visible = True
                grpProbabilty.Visible = False
                grpStrings.Visible = False
                grpStatistics.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(639, 377)
                iHelpCalcID = 130
            Case Else
                grpDates.Visible = False
                Me.Size = New System.Drawing.Size(491, 377)
                grpProbabilty.Visible = False
                grpStatistics.Visible = False
                grpBasic.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpStrings.Visible = False
        End Select
    End Sub

    Private Sub cmdPi_Click(sender As Object, e As EventArgs) Handles cmdPi.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pi")
    End Sub

    Private Sub cmdCeiling_Click(sender As Object, e As EventArgs) Handles cmdCeiling.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ceiling(x= )", 1)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("ceiling()", 1)
        End If
    End Sub

    Private Sub cmdRound_Click(sender As Object, e As EventArgs) Handles cmdRound.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("round(x= ,digits=0)", 10)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("signif(x= ,digits=6)", 10)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("log(x= ,base=exp(1))", 13)
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
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("==")
    End Sub

    Private Sub cmdNotEqualsTo_Click(sender As Object, e As EventArgs) Handles cmdNotEqualsTo.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("!=")
    End Sub

    Private Sub cmdNot_Click(sender As Object, e As EventArgs) Handles cmdNot.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("!")
    End Sub

    Private Sub cmdOr_Click(sender As Object, e As EventArgs) Handles cmdOr.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("|")
    End Sub

    Private Sub cmdLesserOrEqualsTo_Click(sender As Object, e As EventArgs) Handles cmdLesserOrEqualsTo.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("<=")
    End Sub

    Private Sub cmdGreaterOrEqualsTo_Click(sender As Object, e As EventArgs) Handles cmdGreaterOrEqualsTo.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(">=")
    End Sub

    Private Sub cmdModulas_Click(sender As Object, e As EventArgs) Handles cmdModulas.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("%%")
    End Sub

    Private Sub cmdIntegerDivision_Click(sender As Object, e As EventArgs) Handles cmdIntegerDivision.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("%/%")
    End Sub

    Private Sub cmdAnd_Click(sender As Object, e As EventArgs) Handles cmdAnd.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("&")
    End Sub

    Private Sub cmdCount_Click(sender As Object, e As EventArgs) Handles cmdCount.Click
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum(x= ,na.rm=FALSE)", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sum()", 1)
        End If
    End Sub

    Private Sub cmdMean_Click(sender As Object, e As EventArgs) Handles cmdMean.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean(x= ,trim=0 ,na.rm=FALSE)", 21)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("mean()", 1)
        End If
    End Sub

    Private Sub cmdMax_Click(sender As Object, e As EventArgs) Handles cmdMax.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max(x= ,na.rm=FALSE)", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("max()", 1)
        End If
    End Sub

    Private Sub cmdMin_Click(sender As Object, e As EventArgs) Handles cmdMin.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(x= ,na.rm=FALSE)", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min()", 1)
        End If
    End Sub

    Private Sub cmdMedian_Click(sender As Object, e As EventArgs) Handles cmdMedian.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(x= ,na.rm=FALSE)", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median()", 1)
        End If
    End Sub

    Private Sub cmdVar_Click(sender As Object, e As EventArgs) Handles cmdVar.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var(x= , y=NULL,na.rm=FALSE)", 21)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("var()", 1)
        End If
    End Sub

    Private Sub cmdSd_Click(sender As Object, e As EventArgs) Handles cmdSd.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd(x= , na.rm=FALSE)", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("sd()", 1)
        End If
    End Sub

    Private Sub cmdRange_Click(sender As Object, e As EventArgs) Handles cmdRange.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range(x= , na.rm=FALSE, finite=FALSE)", 28)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("range()", 1)
        End If
    End Sub

    Private Sub cmdQuantile_Click(sender As Object, e As EventArgs) Handles cmdQuantile.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile(x= ,probs=0.5, na.rm=FALSE, names=TRUE, type=7)", 44)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile()", 1)
        End If
        ucrBase.clsRsyntax.iCallType = 2
    End Sub

    Private Sub cmdIQR_Click(sender As Object, e As EventArgs) Handles cmdIQR.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR(x=, na.rm = FALSE, type =7)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("IQR()", 1)
        End If
    End Sub

    Private Sub cmdUpper_Click(sender As Object, e As EventArgs) Handles cmdUpper.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_to_upper(string= , locale='')", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_to_upper()", 1)
        End If
    End Sub

    Private Sub cmdLower_Click(sender As Object, e As EventArgs) Handles cmdLower.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_to_lower(string= , locale='')", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_to_lower()", 1)
        End If
    End Sub

    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_to_title(string= , locale='')", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_to_title()", 1)
        End If
    End Sub

    Private Sub cmdTrim_Click(sender As Object, e As EventArgs) Handles cmdTrim.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_trim(string= , side = c('both', 'left', 'right))", 35)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_trim()", 1)
        End If
    End Sub

    Private Sub cmdPad_Click(sender As Object, e As EventArgs) Handles cmdPad.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_pad(string= , width= , side = c('left', 'right', 'both'), pad= )", 46)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_pad()", 1)
        End If
    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_order(x= , decreasing = FALSE, na_last = TRUE)", 38)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_order()", 1)
        End If
    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_sort(x= ,decreasing = FALSE, na_last = TRUE, locale = '',)", 50)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_sort()", 1)
        End If
    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_replace(string= ,pattern= ,replacement= )", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_replace()", 1)
        End If
    End Sub

    Private Sub cmdLocate_Click(sender As Object, e As EventArgs) Handles cmdLocate.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_locate(string= , pattern= )", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_locate()", 1)
        End If
    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_extract(string= , pattern= )", 12)

        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_extract()", 1)
        End If
    End Sub

    Private Sub cmdCountstrings_Click(sender As Object, e As EventArgs) Handles cmdCountstrings.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_count(string= , pattern ='')", 14)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_count()", 1)
        End If

    End Sub

    Private Sub cmdDetect_Click(sender As Object, e As EventArgs) Handles cmdDetect.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_detect(string= , pattern= )", 12)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_detect()", 1)
        End If
    End Sub

    Private Sub cmdQnorm_Click(sender As Object, e As EventArgs) Handles cmdQnorm.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm(p= ,mean = 0, sd = 1, lower.tail = TRUE, log.p = FALSE)", 52)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qnorm()", 1)
        End If
    End Sub

    Private Sub cmdQt_Click(sender As Object, e As EventArgs) Handles cmdQt.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt(p= , df= ,lower.tail = TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qt()", 1)
        End If
    End Sub

    Private Sub cmdQchisq_Click(sender As Object, e As EventArgs) Handles cmdQchisq.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq(p= , df= ,lower.tail = TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qchisq()", 1)
        End If
    End Sub

    Private Sub cmdqF_Click(sender As Object, e As EventArgs) Handles cmdqF.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("qf(p= , df1= ,df2= ,lower.tail = TRUE)", 32)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt(q= , df= ,lower.tail = TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt()", 1)
        End If
    End Sub

    Private Sub cmdPChisq_Click(sender As Object, e As EventArgs) Handles cmdPChisq.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= ,lower.tail = TRUE)", 25)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pt()", 1)
        End If
    End Sub

    Private Sub cmdPf_Click(sender As Object, e As EventArgs) Handles cmdPf.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("pchisq(q= , df= ,lower.tail = TRUE)", 25)
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
        SaveResults()
        ShowControl()
    End Sub

    Private Sub ucrSelectorForCalculations_DataframeChanged() Handles ucrSelectorForCalculations.DataFrameChanged
        ucrInputTryMessage.SetName("")
        SaveResults()
    End Sub

    Private Sub ShowControl()
        If chkSaveResultInto.Checked Then
            ucrSaveResultInto.Visible = True
        Else
            ucrSaveResultInto.Visible = False
        End If
    End Sub

    Private Sub cmdCombine_Click(sender As Object, e As EventArgs) Handles cmdCombine.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_c(string= , pattern='')", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_c()", 1)
        End If
    End Sub

    Private Sub cmdSplit_Click(sender As Object, e As EventArgs) Handles cmdSplit.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_split_fixed(string= , pattern='', n= )", 18)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("str_split_fixed()", 1)
        End If
    End Sub

    Private Sub cmdYear_Click(sender As Object, e As EventArgs) Handles cmdYear.Click

    End Sub

    Private Sub cmdMonth_Click(sender As Object, e As EventArgs) Handles cmdMonth.Click

    End Sub

    Private Sub cmdDay_Click(sender As Object, e As EventArgs) Handles cmdDay.Click

    End Sub

    Private Sub cmdWday_Click(sender As Object, e As EventArgs) Handles cmdWday.Click

    End Sub

    Private Sub cmdYday_Click(sender As Object, e As EventArgs) Handles cmdYday.Click

    End Sub

    Private Sub cmdDate_Click(sender As Object, e As EventArgs) Handles cmdDate.Click

    End Sub

    Private Sub cmdLeap_Click(sender As Object, e As EventArgs) Handles cmdLeap.Click

    End Sub

    Private Sub cmdYmd_Click(sender As Object, e As EventArgs) Handles cmdYmd.Click

    End Sub

    Private Sub cmdMdy_Click(sender As Object, e As EventArgs) Handles cmdMdy.Click

    End Sub

    Private Sub cmdDmy_Click(sender As Object, e As EventArgs) Handles cmdDmy.Click

    End Sub

    Private Sub cmdDoy_Click(sender As Object, e As EventArgs) Handles cmdDoy.Click

    End Sub

    Private Sub cmdDek_Click(sender As Object, e As EventArgs) Handles cmdDek.Click

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
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub TryScript()
        Dim strOutPut As String
        Dim strAttach As String
        Dim strDetach As String
        Dim strTempScript As String = ""
        Dim strVecOutput As CharacterVector
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String
        Dim strAssignToColumn As String
        Dim strAssignToDataFrame As String

        bIsAssigned = ucrBase.clsRsyntax.GetbIsAssigned()
        bToBeAssigned = ucrBase.clsRsyntax.GetbToBeAssigned()
        strAssignTo = ucrBase.clsRsyntax.GetstrAssignTo()
        'These should really be done through RSyntax methods as above
        strAssignToColumn = ucrBase.clsRsyntax.strAssignToColumn
        strAssignToDataFrame = ucrBase.clsRsyntax.strAssignToDataframe

        Try
            If ucrReceiverForCalculation.IsEmpty Then
                ucrInputTryMessage.SetName("")
            Else
                'get strScript here
                strAttach = clsAttach.ToScript(strTempScript)
                frmMain.clsRLink.RunInternalScript(strTempScript & strAttach, bSilent:=True)
                ucrBase.clsRsyntax.RemoveAssignTo()
                strOutPut = ucrBase.clsRsyntax.GetScript
                strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strOutPut, bSilent:=True)
                If strVecOutput IsNot Nothing Then
                    If strVecOutput.Length > 1 Then
                        ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5) & "...")
                    Else
                        ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5))
                    End If
                Else
                    ucrInputTryMessage.SetName("Command produced an error or no output to display.")
                End If
            End If
        Catch ex As Exception
            ucrInputTryMessage.SetName("Command produced an error. Modify input before running.")
        Finally
            strTempScript = ""
            strDetach = clsDetach.ToScript(strTempScript)
            frmMain.clsRLink.RunInternalScript(strTempScript & strDetach, bSilent:=True)
            ucrBase.clsRsyntax.SetbIsAssigned(bIsAssigned)
            ucrBase.clsRsyntax.SetbToBeAssigned(bToBeAssigned)
            ucrBase.clsRsyntax.SetstrAssignTo(strAssignTo)
            'These should really be done through RSyntax methods as above
            ucrBase.clsRsyntax.strAssignToColumn = strAssignToColumn
            ucrBase.clsRsyntax.strAssignToDataframe = strAssignToDataFrame
        End Try
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        TryScript()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        HelpContent()
    End Sub

    Private Sub HelpContent()
        If iHelpCalcID > 0 Then
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpCalcID.ToString())
        Else
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        End If
    End Sub
End Class