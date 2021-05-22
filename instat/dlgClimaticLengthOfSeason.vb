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

Imports instat.Translations
Public Class dlgClimaticLengthOfSeason
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataName As String = ""

    Private clsLengthOfSeasonFunction, clsApplyInstatCalcFunction, clsCombinationCalcFunction, clsStartEndStatusFunction, clsIfElseFunction, clsIsNAFunction, clsCombinationListFunction As New RFunction
    Private clsMinusOpertor, clsAndOperator, clsOROperator As New ROperator
    Private Sub dlgClimaticLengthOfSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 564
        ucrReceiverStartofRains.SetParameter(New RParameter("start_doy", 1, bNewIncludeArgumentName:=False))
        ucrReceiverStartofRains.SetParameterIsString()
        ucrReceiverStartofRains.bWithQuotes = False
        ucrReceiverStartofRains.Selector = ucrSelectorLengthofSeason
        ucrSelectorLengthofSeason.bUseCurrentFilter = False

        ucrReceiverStartofRainsLogical.SetParameter(New RParameter("start_status", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStartofRainsLogical.SetParameterIsString()
        ucrReceiverStartofRainsLogical.bWithQuotes = False
        ucrReceiverStartofRainsLogical.Selector = ucrSelectorLengthofSeason


        ucrReceiverEndofRains.SetParameter(New RParameter("end_rain", 0, bNewIncludeArgumentName:=False))
        ucrReceiverEndofRains.SetParameterIsString()
        ucrReceiverEndofRains.bWithQuotes = False
        ucrReceiverEndofRains.Selector = ucrSelectorLengthofSeason

        ucrReceiverEndofRainsLogical.SetParameter(New RParameter("end_status", 1, bNewIncludeArgumentName:=False))
        ucrReceiverEndofRainsLogical.SetParameterIsString()
        ucrReceiverEndofRainsLogical.bWithQuotes = False
        ucrReceiverEndofRainsLogical.Selector = ucrSelectorLengthofSeason

        ucrChkLengthofSeason.AddParameterPresentCondition(True, "sub1", True)
        ucrChkLengthofSeason.AddParameterPresentCondition(False, "sub1", False)
        ucrChkLengthofSeason.AddToLinkedControls(ucrInputLengthofSeason, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLengthofSeason.SetText("Length of Season")

        ucrInputLengthofSeason.SetParameter(New RParameter("result_name", 2))
        ucrInputLengthofSeason.SetDataFrameSelector(ucrSelectorLengthofSeason.ucrAvailableDataFrames)
        ucrInputLengthofSeason.SetName("Length")


        ucrChkType.AddParameterPresentCondition(True, "sub2", True)
        ucrChkType.AddParameterPresentCondition(False, "sub2", False)
        ucrChkType.AddToLinkedControls(ucrInputTextType, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkType.SetText("Occurence")

        ucrInputTextType.SetParameter(New RParameter("result_name", 2))
        ucrInputTextType.SetDataFrameSelector(ucrSelectorLengthofSeason.ucrAvailableDataFrames)
        ucrInputTextType.SetName("length_status")
    End Sub

    Private Sub SetDefaults()
        Dim strLengthName As String = "length"
        Dim strTypeName As String = "length_status"

        clsLengthOfSeasonFunction.Clear()
        clsCombinationCalcFunction.Clear()
        clsApplyInstatCalcFunction.Clear()
        clsStartEndStatusFunction.Clear()
        clsCombinationListFunction.Clear()
        clsIsNAFunction.Clear()


        clsMinusOpertor.Clear()
        clsAndOperator.Clear()
        clsOROperator.Clear()


        ucrSelectorLengthofSeason.Reset()
        ucrReceiverStartofRains.SetMeAsReceiver()

        'length of season calculation
        clsLengthOfSeasonFunction.SetRCommand("instat_calculation$new")
        clsLengthOfSeasonFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsLengthOfSeasonFunction.AddParameter("function_exp", clsROperatorParameter:=clsMinusOpertor, iPosition:=1)
        clsLengthOfSeasonFunction.AddParameter("result_name", Chr(34) & strLengthName & Chr(34), iPosition:=2)
        clsLengthOfSeasonFunction.AddParameter("save", 2, iPosition:=5)
        clsLengthOfSeasonFunction.SetAssignTo("length_of_season")

        clsMinusOpertor.SetOperation("-")
        clsMinusOpertor.bToScriptAsRString = True

        'start status calculation
        clsStartEndStatusFunction.SetRCommand("instat_calculation$new")
        clsStartEndStatusFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsStartEndStatusFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseFunction, iPosition:=1)
        clsStartEndStatusFunction.AddParameter("result_name", Chr(34) & strTypeName & Chr(34), iPosition:=2)
        clsStartEndStatusFunction.AddParameter("save", 2, iPosition:=6)
        clsStartEndStatusFunction.SetAssignTo("start_end_status")

        clsIfElseFunction.SetPackageName("dplyr")
        clsIfElseFunction.SetRCommand("if_else")
        clsIfElseFunction.AddParameter("is.na", clsRFunctionParameter:=clsIsNAFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsIfElseFunction.AddParameter("NA", "NA", bIncludeArgumentName:=False, iPosition:=1)
        clsIfElseFunction.AddParameter("and", clsROperatorParameter:=clsAndOperator, bIncludeArgumentName:=False, iPosition:=2)
        clsIfElseFunction.bToScriptAsRString = True

        clsAndOperator.SetOperation("&")

        clsIsNAFunction.SetRCommand("is.na")
        clsIsNAFunction.AddParameter("or", clsROperatorParameter:=clsOROperator, bIncludeArgumentName:=False)

        clsOROperator.SetOperation("|")

        'combination calculation
        clsCombinationCalcFunction.SetRCommand("instat_calculation$new")
        clsCombinationCalcFunction.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationCalcFunction.AddParameter("sub_calculation", clsRFunctionParameter:=clsCombinationListFunction, iPosition:=2)
        clsCombinationCalcFunction.SetAssignTo("length_rains_combined")

        clsCombinationListFunction.SetRCommand("list")
        clsCombinationListFunction.AddParameter("sub1", clsRFunctionParameter:=clsLengthOfSeasonFunction, bIncludeArgumentName:=False, iPosition:=0)

        'Run Calculations
        clsApplyInstatCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsCombinationCalcFunction, iPosition:=0)
        clsApplyInstatCalcFunction.AddParameter("display", "FALSE", iPosition:=1)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatCalcFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStartofRainsLogical.AddAdditionalCodeParameterPair(clsOROperator, New RParameter("start_status", 0), iAdditionalPairNo:=1)
        ucrReceiverEndofRainsLogical.AddAdditionalCodeParameterPair(clsOROperator, New RParameter("end_status", 1), iAdditionalPairNo:=1)

        ucrReceiverStartofRains.SetRCode(clsMinusOpertor, bReset)
        ucrReceiverEndofRains.SetRCode(clsMinusOpertor, bReset)
        ucrReceiverStartofRainsLogical.SetRCode(clsAndOperator, bReset)
        ucrReceiverEndofRainsLogical.SetRCode(clsAndOperator, bReset)
        ucrInputLengthofSeason.SetRCode(clsLengthOfSeasonFunction, bReset)
        ucrInputTextType.SetRCode(clsStartEndStatusFunction, bReset)
        ucrChkLengthofSeason.SetRCode(clsCombinationListFunction, bReset)
        ucrChkType.SetRCode(clsCombinationListFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean
        If ucrChkLengthofSeason.Checked Then
            If Not ucrInputLengthofSeason.IsEmpty AndAlso Not ucrReceiverStartofRains.IsEmpty AndAlso Not ucrReceiverEndofRains.IsEmpty Then
                bOkEnabled = True
            Else
                bOkEnabled = False
            End If
        End If
        If ucrChkType.Checked Then
            If ucrInputTextType.IsEmpty() OrElse ucrReceiverStartofRainsLogical.IsEmpty OrElse ucrReceiverEndofRainsLogical.IsEmpty Then
                bOkEnabled = False
            End If
        End If
            ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverStartofRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStartofRains.ControlValueChanged, ucrReceiverEndofRains.ControlValueChanged
        clsLengthOfSeasonFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStartofRains.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverEndofRains.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrSelectorLengthofSeason_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorLengthofSeason.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorLengthofSeason.strCurrentDataFrame & Chr(34)
    End Sub

    Private Sub ucrReceiverStartofRainsLogical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStartofRainsLogical.ControlValueChanged, ucrReceiverEndofRainsLogical.ControlValueChanged
        clsStartEndStatusFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStartofRainsLogical.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverEndofRainsLogical.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrChkLengthofSeason_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLengthofSeason.ControlValueChanged
        If ucrChkLengthofSeason.Checked Then
            clsCombinationListFunction.AddParameter("sub1", clsRFunctionParameter:=clsLengthOfSeasonFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCombinationListFunction.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrChkType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkType.ControlValueChanged
        If ucrChkType.Checked Then
            clsCombinationListFunction.AddParameter("sub2", clsRFunctionParameter:=clsStartEndStatusFunction, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCombinationListFunction.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkLengthofSeason_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkLengthofSeason.ControlContentsChanged, ucrChkType.ControlContentsChanged, ucrInputLengthofSeason.ControlContentsChanged, ucrInputTextType.ControlContentsChanged, ucrReceiverStartofRains.ControlContentsChanged, ucrReceiverEndofRains.ControlContentsChanged, ucrReceiverStartofRainsLogical.ControlContentsChanged, ucrReceiverEndofRainsLogical.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class