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

Imports instat
Imports instat.Translations

Public Class dlgExtremes
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction
    Private clsFevdFunction, clsNaExclude, clsConvertVector As New RFunction
    Private clsFevdPlotsFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetFittingOptions As Boolean = False
    Public bResetDisplayOptions As Boolean = False

    Private Sub dlgExtremes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctFevdTypes As New Dictionary(Of String, String)

        ucrReceiverVariable.Selector = ucrSelectorExtremes
        ucrReceiverVariable.strSelectorHeading = "Variables"
        ucrReceiverVariable.SetMeAsReceiver()
        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrInputExtremes.SetParameter(New RParameter("type", 1))
        dctFevdTypes.Add("GEV", Chr(34) & "GEV" & Chr(34))
        dctFevdTypes.Add("GP", Chr(34) & "GP" & Chr(34))
        dctFevdTypes.Add("PP", Chr(34) & "PP" & Chr(34))
        dctFevdTypes.Add("Gumbel", Chr(34) & "Gumbel" & Chr(34))
        dctFevdTypes.Add("Exponential", Chr(34) & "Exponential" & Chr(34))
        ucrInputExtremes.SetItems(dctFevdTypes)
        ucrInputExtremes.SetDropDownStyleAsNonEditable()

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverVariable.Selector = ucrSelectorExtremes
        ucrReceiverVariable.strSelectorHeading = "Variables"
        ucrReceiverVariable.SetMeAsReceiver()
        ucrReceiverVariable.SetParameter(New RParameter("object", 0))
        ucrReceiverVariable.SetParameterIsRFunction()

        ucrChkExplanatoryModelForLocationParameter.SetText("Explanatory Model for Location")
        ucrChkExplanatoryModelForLocationParameter.SetParameter(New RParameter(" location.fun", 3), bNewChangeParameterValue:=False)
        ucrChkExplanatoryModelForLocationParameter.AddToLinkedControls(ucrReceiverExpressionExplanatoryModelForLocParam, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverExpressionExplanatoryModelForLocParam.SetParameter(New RParameter(" location.fun", 3))
        ucrReceiverExpressionExplanatoryModelForLocParam.SetParameterIsString()
        ucrReceiverExpressionExplanatoryModelForLocParam.bWithQuotes = False
        ucrReceiverExpressionExplanatoryModelForLocParam.SetText("~1")

        ucrTryModelling.SetReceiver(ucrReceiverExpressionExplanatoryModelForLocParam)
        ucrTryModelling.SetIsModel()

        ucrSaveExtremes.SetPrefix("extreme")
        ucrSaveExtremes.SetIsComboBox()
        ucrSaveExtremes.SetCheckBoxText("Save Graph")
        ucrSaveExtremes.SetSaveTypeAsModel()
        ucrSaveExtremes.SetDataFrameSelector(ucrSelectorExtremes.ucrAvailableDataFrames)
        ucrSaveExtremes.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsFevdFunction = New RFunction
        clsFevdPlotsFunction = New RFunction
        clsNaExclude = New RFunction
        clsConvertVector = New RFunction

        ucrBase.clsRsyntax.ClearCodes()

        ucrSaveExtremes.Reset()
        ucrSelectorExtremes.Reset()
        ucrReceiverExpressionExplanatoryModelForLocParam.Selector = ucrSelectorExtremes

        clsNaExclude.SetPackageName("stats")
        clsNaExclude.SetRCommand("na.exclude")

        clsFevdPlotsFunction.SetPackageName("extRemes")
        clsFevdPlotsFunction.SetRCommand("plot.fevd")
        clsFevdPlotsFunction.iCallType = 3
        clsFevdPlotsFunction.bExcludeAssignedFunctionOutput = False

        clsFevdFunction.SetPackageName("extRemes")
        clsFevdFunction.SetRCommand("fevd")


        clsConvertVector.SetRCommand("as.vector")
        clsConvertVector.AddParameter("x", clsRFunctionParameter:=clsNaExclude)

        clsFevdFunction.AddParameter("x", clsRFunctionParameter:=clsConvertVector, iPosition:=0)
        clsFevdFunction.AddParameter("type", Chr(34) & "GEV" & Chr(34), iPosition:=1)
        clsFevdFunction.AddParameter("method", Chr(34) & "MLE" & Chr(34), iPosition:=2)


        clsFevdFunction.SetAssignTo(ucrSaveExtremes.GetText(), strTempDataframe:=ucrSelectorExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)
        clsFevdPlotsFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        clsFevdPlotsFunction.AddParameter("x", clsRFunctionParameter:=clsFevdFunction, iPosition:=0)

        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorExtremes.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorExtremes.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsFevdFunction)
        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)

        bResetDisplayOptions = True
        bResetFittingOptions = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputExtremes.SetRCode(clsFevdFunction, bReset)
        ucrReceiverVariable.SetRCode(clsNaExclude, bReset)
        ucrSaveExtremes.SetRCode(clsFevdFunction, bReset)
        ucrChkExplanatoryModelForLocationParameter.SetRCode(clsFevdFunction, bReset)
        ucrReceiverExpressionExplanatoryModelForLocParam.SetRCode(clsFevdFunction, bReset)
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgExtremeDisplayOptions.SetRCode(clsNewFevdPlotFunction:=clsFevdPlotsFunction, clsNewRSyntax:=ucrBase.clsRsyntax)
        bResetDisplayOptions = False
        sdgExtremeDisplayOptions.ShowDialog()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverVariable.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdFittingOptions_Click(sender As Object, e As EventArgs) Handles cmdFittingOptions.Click
        sdgExtremesMethod.SetRCode(clsNewFevdFunction:=clsFevdFunction, bReset:=bResetFittingOptions)
        bResetFittingOptions = False
        sdgExtremesMethod.ShowDialog()
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("( )", 2)
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("I()", 1)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.Clear()
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("sqrt( )", 2)
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("cos( )", 2)
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("log( )", 2)
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("sin( )", 2)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs) Handles cmdExp.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("exp( )", 2)
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        ucrReceiverExpressionExplanatoryModelForLocParam.AddToReceiverAtCursorPosition("tan( )", 2)
    End Sub



    Private Sub ucrReceiverVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariable.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkExplanatoryModelForLocationParameter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExplanatoryModelForLocationParameter.ControlValueChanged
        If ucrChkExplanatoryModelForLocationParameter.Checked Then
            grpFirstCalc.Visible = True
            grpSecondCalc.Visible = True
        Else
            grpFirstCalc.Visible = False
            grpSecondCalc.Visible = False
        End If
    End Sub
End Class