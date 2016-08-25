
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
    Dim dataset As DataFrame
    Dim clsAttach As New RFunction
    Dim clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 14
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForCalculation.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSaveResultInto.SetPrefix("Cal")
        ucrSaveResultInto.Reset()
        ucrInputCalOptions.Reset()
        ucrReceiverForCalculation.cboExpression.ResetText()
        Me.Size = New System.Drawing.Size(436, 402)
        ucrInputCalOptions.cboInput.Text = "Basic"
        chkShowArguments.Checked = True
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 1
        ucrReceiverForCalculation.Selector = ucrSelectorForCalculations
        ucrReceiverForCalculation.SetMeAsReceiver()
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResultInto.SetItemsTypeAsColumns()
        ucrSaveResultInto.SetDefaultTypeAsColumn()
        ucrSaveResultInto.SetDataFrameSelector(ucrSelectorForCalculations.ucrAvailableDataFrames)
        ucrSelectorForCalculations.Reset()
        ucrInputCalOptions.cboInput.Items.Add("Basic")
        ucrInputCalOptions.cboInput.Items.Add("Maths")
        ucrInputCalOptions.cboInput.Items.Add("Logical")
        ucrInputCalOptions.cboInput.Items.Add("Statistics")
        ucrInputCalOptions.cboInput.Items.Add("Strings")
    End Sub

    'Private Sub ucrSaveResultIntoInto_NameChanged() Handles ucrSaveResultInto.NameChanged
    '    ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveResultInto.GetText, strTempDataframe:=ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveResultInto.GetText, bAssignToIsPrefix:=True)
    'End Sub

    Private Sub AddText(strVar As String, Optional intStepsBack As Integer = 0, Optional bolInsertSelected As Boolean = False)
        'Dim intCurrCursorPosition As Integer
        'Dim strSelectedText As String = txtCalcLine.SelectedText

        'txtCalcLine.SelectedText = ""
        'intCurrCursorPosition = txtCalcLine.SelectionStart
        'txtCalcLine.Text = txtCalcLine.Text.Insert(txtCalcLine.SelectionStart, strVar)
        'intCurrCursorPosition = intCurrCursorPosition + strVar.Length - intStepsBack
        'If bolInsertSelected Then
        '    txtCalcLine.Text = txtCalcLine.Text.Insert(intCurrCursorPosition, strSelectedText)
        '    intCurrCursorPosition = intCurrCursorPosition + strSelectedText.Length + 1
        'End If
        'txtCalcLine.SelectionStart = intCurrCursorPosition
        'txtCalcLine.Select()
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

    Private Sub lstAvailableVariable_DoubleClick(sender As Object, e As EventArgs)
        'If lstAvailableVariable.SelectedItem <> "" Then
        '    AddText("data[[""" & lstAvailableVariable.SelectedItem & """]]")
        'End If
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForCalculation.AddToReceiverAtCursorPosition("^")
    End Sub



    Private Sub ucrSaveResultInto_NameChanged() Handles ucrSaveResultInto.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(ucrSaveResultInto.GetText(), strTempColumn:=ucrSaveResultInto.GetText(), strTempDataframe:=ucrSelectorForCalculations.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
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
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorForCalculations.ucrAvailableDataFrames.clsCurrDataFrame)
        strFunc = clsDetach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrReceiverForCalculation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCalculation.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForCalculation.GetVariableNames(False))
        ucrBase.OKEnabled(True)
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
        ucrReceiverForCalculation.Clear()
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputCalOptions_NameChanged() Handles ucrInputCalOptions.NameChanged
        Select Case ucrInputCalOptions.GetText
            Case "Maths"
                grpStatistics.Visible = False
                grpMaths.Visible = True
                grpLogical.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                Me.Size = New System.Drawing.Size(614, 402)
            Case "Logical"
                grpStatistics.Visible = False
                grpLogical.Visible = True
                grpMaths.Visible = False
                grpBasic.Visible = True
                grpStrings.Visible = False
                Me.Size = New System.Drawing.Size(552, 402)
            Case "Statistics"
                grpStatistics.Visible = True
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(552, 402)
                grpStrings.Visible = False
            Case "Strings"
                grpStrings.Visible = True
                grpStatistics.Visible = False
                grpLogical.Visible = False
                grpMaths.Visible = False
                grpBasic.Visible = True
                Me.Size = New System.Drawing.Size(580, 402)

            Case Else
                Me.Size = New System.Drawing.Size(424, 402)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min(x= ,na.rm=FASLE)", 13)
        Else
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("min()", 1)
        End If
    End Sub

    Private Sub cmdMedian_Click(sender As Object, e As EventArgs) Handles cmdMedian.Click
        If chkShowArguments.Checked Then
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("median(x=na.rm=FALSE)", 13)
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
            ucrReceiverForCalculation.AddToReceiverAtCursorPosition("quantile(x= ,probs=seq(0,1,0.25), na.rm=FALSE, names=TRUE, type=7)", 54)
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

    End Sub

    Private Sub cmdLower_Click(sender As Object, e As EventArgs) Handles cmdLower.Click

    End Sub

    Private Sub cmdTitle_Click(sender As Object, e As EventArgs) Handles cmdTitle.Click

    End Sub

    Private Sub cmdTrim_Click(sender As Object, e As EventArgs) Handles cmdTrim.Click

    End Sub

    Private Sub cmdPad_Click(sender As Object, e As EventArgs) Handles cmdPad.Click

    End Sub

    Private Sub cmdOrder_Click(sender As Object, e As EventArgs) Handles cmdOrder.Click

    End Sub

    Private Sub cmdSort_Click(sender As Object, e As EventArgs) Handles cmdSort.Click

    End Sub

    Private Sub cmdReplace_Click(sender As Object, e As EventArgs) Handles cmdReplace.Click

    End Sub

    Private Sub cmdLocate_Click(sender As Object, e As EventArgs) Handles cmdLocate.Click

    End Sub

    Private Sub cmdLength_Click(sender As Object, e As EventArgs) Handles cmdLength.Click

    End Sub

    Private Sub cmdExtract_Click(sender As Object, e As EventArgs) Handles cmdExtract.Click

    End Sub

    Private Sub cmdCountstrings_Click(sender As Object, e As EventArgs) Handles cmdCountstrings.Click

    End Sub

    Private Sub cmdDetect_Click(sender As Object, e As EventArgs) Handles cmdDetect.Click

    End Sub

End Class