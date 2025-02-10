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

    Private clsLengthOfSeasonFunction, clsLengthmoreFunction, clsListFunction, clsAscharactermoreFunction, clsConvertColumnTypeFunction, clsElseIfMoreFunction, clsApplyInstatCalcFunction, clsAsCharacterFunction, clsCombinationCalcFunction, clsStartEndStatusFunction, clsCaseWhenFunction, clsIsNAFunction, clsIsNA1Function, clsCombinationListFunction As New RFunction
    Private clsMinusOpertor, clsAssignMoreOperator, clsMinusmoreOPerator, clsAndOperator, clsOROperator, clsCaseWhenOperator, clsCaseWhen1Operator, clsCaseWhen2Operator, clsCaseWhen3Operator, clsAssignOperator, clsAssign1Operator, clsAssign2Operator, clsAssign3Operator, clsAssign4Operator, clsAnd1Operator, clsAnd2Operator As New ROperator

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

        ucrChkLengthmore.SetText("Length_More")
        ucrChkLengthmore.AddParameterPresentCondition(True, "sub3", True)
        ucrChkLengthmore.AddParameterPresentCondition(False, "sub3", False)
        ucrChkLengthmore.AddToLinkedControls(ucrNudLenghtmore, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=366)

        ucrNudLenghtmore.SetParameter(New RParameter("left", 0, False))
        ucrNudLenghtmore.DecimalPlaces = 0
        ucrNudLenghtmore.Increment = 1
        ucrNudLenghtmore.Minimum = 1
        ucrNudLenghtmore.Maximum = 366
        EnableLengthmore()
    End Sub

    Private Sub SetDefaults()
        Dim strLengthName As String = "length"
        Dim strTypeName As String = "length_status"

        clsAscharactermoreFunction = New RFunction
        clsListFunction = New RFunction
        clsMinusmoreOPerator =New ROperator

        clsLengthOfSeasonFunction.Clear()
        clsCombinationCalcFunction.Clear()
        clsApplyInstatCalcFunction.Clear()
        clsStartEndStatusFunction.Clear()
        clsCombinationListFunction.Clear()
        clsIsNAFunction.Clear()
        clsIsNA1Function.Clear()
        clsAsCharacterFunction.Clear()
        clsLengthmoreFunction.Clear()
        clsElseIfMoreFunction.Clear()

        clsAssignMoreOperator.Clear()
        clsMinusOpertor.Clear()
        clsAndOperator.Clear()
        clsOROperator.Clear()
        clsCaseWhenOperator.Clear()
        clsCaseWhen1Operator.Clear()
        clsCaseWhen2Operator.Clear()
        clsCaseWhen3Operator.Clear()
        clsAssignOperator.Clear()
        clsAssign1Operator.Clear()
        clsAssign2Operator.Clear()
        clsAssign3Operator.Clear()
        clsAssign4Operator.Clear()
        clsAnd1Operator.Clear()
        clsAnd2Operator.Clear()
        clsConvertColumnTypeFunction.Clear()

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
        clsStartEndStatusFunction.AddParameter("function_exp", clsRFunctionParameter:=clsCaseWhenFunction, iPosition:=1)
        clsStartEndStatusFunction.AddParameter("result_name", Chr(34) & strTypeName & Chr(34), iPosition:=2)
        clsStartEndStatusFunction.AddParameter("save", 2, iPosition:=6)
        clsStartEndStatusFunction.SetAssignTo("start_end_status")

        clsCaseWhenFunction.SetPackageName("dplyr")
        clsCaseWhenFunction.SetRCommand("case_when")
        clsCaseWhenFunction.AddParameter("is.na", clsROperatorParameter:=clsCaseWhenOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsCaseWhenFunction.AddParameter("NA", clsROperatorParameter:=clsCaseWhen1Operator, bIncludeArgumentName:=False, iPosition:=1)
        clsCaseWhenFunction.AddParameter("and", clsROperatorParameter:=clsCaseWhen2Operator, bIncludeArgumentName:=False, iPosition:=2)
        clsCaseWhenFunction.AddParameter("test", clsROperatorParameter:=clsCaseWhen3Operator, bIncludeArgumentName:=False, iPosition:=3)
        clsCaseWhenFunction.bToScriptAsRString = True

        clsAndOperator.SetOperation("&")

        clsIsNAFunction.SetRCommand("is.na")

        clsIsNA1Function.SetRCommand("is.na")

        clsCaseWhenOperator.SetOperation("~")
        clsCaseWhenOperator.AddParameter("left", clsROperatorParameter:=clsOROperator, iPosition:=0, bIncludeArgumentName:=False)
        clsCaseWhenOperator.AddParameter("right", "NA_character_", iPosition:=1, bIncludeArgumentName:=False)
        clsCaseWhenOperator.bBrackets = False

        clsCaseWhen1Operator.SetOperation("~")
        clsCaseWhen1Operator.AddParameter("left", clsROperatorParameter:=clsAssignOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsCaseWhen1Operator.AddParameter("right", clsRFunctionParameter:=clsAsCharacterFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsCaseWhen1Operator.bBrackets = False

        clsCaseWhen2Operator.SetOperation("~")
        clsCaseWhen2Operator.AddParameter("left", clsROperatorParameter:=clsAssign2Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsCaseWhen2Operator.AddParameter("right", "'NONE'", iPosition:=1, bIncludeArgumentName:=False)
        clsCaseWhen2Operator.bBrackets = False

        clsCaseWhen3Operator.SetOperation("~")
        clsCaseWhen3Operator.AddParameter("left", clsROperatorParameter:=clsAssign4Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsCaseWhen3Operator.AddParameter("right", "'MORE'", iPosition:=1, bIncludeArgumentName:=False)
        clsCaseWhen3Operator.bBrackets = False

        clsAsCharacterFunction.SetRCommand("as.character")

        clsAssignOperator.SetOperation("==")
        clsAssignOperator.bBrackets = False

        clsAssign2Operator.SetOperation("==")
        clsAssign2Operator.AddParameter("left", clsROperatorParameter:=clsAnd1Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsAssign2Operator.AddParameter("right", "TRUE", iPosition:=1, bIncludeArgumentName:=False)
        clsAssign2Operator.bBrackets = False

        clsAnd1Operator.SetOperation("&")
        clsAnd1Operator.AddParameter("left", clsROperatorParameter:=clsAssign1Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsAnd1Operator.bBrackets = False

        clsAssign1Operator.SetOperation("==")
        clsAssign1Operator.AddParameter("right", "FALSE", iPosition:=1, bIncludeArgumentName:=False)
        clsAssign1Operator.bBrackets = False

        clsAssign4Operator.SetOperation("==")
        clsAssign4Operator.AddParameter("left", clsROperatorParameter:=clsAnd2Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsAssign4Operator.AddParameter("right", "FALSE", iPosition:=1, bIncludeArgumentName:=False)
        clsAssign4Operator.bBrackets = False

        clsAnd2Operator.SetOperation("&")
        clsAnd2Operator.AddParameter("left", clsROperatorParameter:=clsAssign3Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsAnd2Operator.bBrackets = False

        clsAssign3Operator.SetOperation("==")
        clsAssign3Operator.AddParameter("right", "TRUE", iPosition:=1, bIncludeArgumentName:=False)
        clsAssign3Operator.bBrackets = False

        clsOROperator.SetOperation("|")
        clsOROperator.AddParameter("left", clsRFunctionParameter:=clsIsNAFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsOROperator.AddParameter("right", clsRFunctionParameter:=clsIsNA1Function, iPosition:=1, bIncludeArgumentName:=False)
        clsOROperator.bBrackets = False

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

        clsConvertColumnTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnTypeFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)

        clsLengthmoreFunction.SetRCommand("instat_calculation$new")
        clsLengthmoreFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsLengthmoreFunction.AddParameter("function_exp", clsRFunctionParameter:=clsElseIfMoreFunction, iPosition:=1)
        clsLengthmoreFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsListFunction, iPosition:=4)
        clsLengthmoreFunction.AddParameter("save", 2, iPosition:=5)
        clsLengthmoreFunction.SetAssignTo("length_more")

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("x", "start_end_status", iPosition:=0, bIncludeArgumentName:=False)
        clsListFunction.AddParameter("y", "length_of_season", iPosition:=1, bIncludeArgumentName:=False)

        clsElseIfMoreFunction.SetRCommand("ifelse")
        clsElseIfMoreFunction.bToScriptAsRString = True
        clsElseIfMoreFunction.AddParameter("test", clsROperatorParameter:=clsAssignMoreOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsElseIfMoreFunction.AddParameter("yes", clsROperatorParameter:=clsMinusmoreOPerator, iPosition:=1, bIncludeArgumentName:=False)

        clsAssignMoreOperator.SetOperation("==")
        clsAssignMoreOperator.AddParameter("left", clsRFunctionParameter:=clsAscharactermoreFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsAssignMoreOperator.AddParameter("rigth", Chr(34) & "MORE" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)

        clsAscharactermoreFunction.SetRCommand("as.character")

        clsMinusmoreOPerator.SetOperation("-")

        'Base Function
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatCalcFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStartofRainsLogical.AddAdditionalCodeParameterPair(clsIsNAFunction, New RParameter("start_status", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverEndofRainsLogical.AddAdditionalCodeParameterPair(clsIsNA1Function, New RParameter("end_status", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverStartofRainsLogical.AddAdditionalCodeParameterPair(clsAsCharacterFunction, New RParameter("start_status", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverStartofRainsLogical.AddAdditionalCodeParameterPair(clsAssignOperator, New RParameter("start_status", 0), iAdditionalPairNo:=3)
        ucrReceiverEndofRainsLogical.AddAdditionalCodeParameterPair(clsAssignOperator, New RParameter("end_status", 1), iAdditionalPairNo:=2)
        ucrReceiverEndofRainsLogical.AddAdditionalCodeParameterPair(clsAnd1Operator, New RParameter("end_status", 1), iAdditionalPairNo:=3)
        ucrReceiverStartofRainsLogical.AddAdditionalCodeParameterPair(clsAssign1Operator, New RParameter("start_status", 0), iAdditionalPairNo:=4)
        ucrReceiverEndofRainsLogical.AddAdditionalCodeParameterPair(clsAnd2Operator, New RParameter("end_status", 1), iAdditionalPairNo:=4)
        ucrReceiverStartofRainsLogical.AddAdditionalCodeParameterPair(clsAssign3Operator, New RParameter("start_status", 0), iAdditionalPairNo:=5)
        ucrInputTextType.AddAdditionalCodeParameterPair(clsConvertColumnTypeFunction, New RParameter("col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverStartofRains.AddAdditionalCodeParameterPair(clsMinusmoreOPerator, New RParameter("rigth", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrReceiverStartofRains.SetRCode(clsMinusOpertor, bReset)
        ucrReceiverEndofRains.SetRCode(clsMinusOpertor, bReset)
        ucrReceiverStartofRainsLogical.SetRCode(clsAndOperator, bReset)
        ucrReceiverEndofRainsLogical.SetRCode(clsAndOperator, bReset)
        ucrInputLengthofSeason.SetRCode(clsLengthOfSeasonFunction, bReset)
        ucrInputTextType.SetRCode(clsStartEndStatusFunction, bReset)
        ucrChkLengthofSeason.SetRCode(clsCombinationListFunction, bReset)
        ucrChkType.SetRCode(clsCombinationListFunction, bReset)
        ucrChkLengthmore.SetRCode(clsCombinationListFunction, bReset)
        ucrNudLenghtmore.SetRCode(clsMinusmoreOPerator, bReset)
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
        EnableLengthmore()
        If ucrChkType.Checked Then
            clsCombinationListFunction.AddParameter("sub2", clsRFunctionParameter:=clsStartEndStatusFunction, bIncludeArgumentName:=False, iPosition:=1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsConvertColumnTypeFunction, iPosition:=0)
        Else
            clsCombinationListFunction.RemoveParameterByName("sub2")
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsConvertColumnTypeFunction)

        End If
    End Sub

    Private Sub ucrChkLengthofSeason_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkLengthofSeason.ControlContentsChanged, ucrChkType.ControlContentsChanged, ucrInputLengthofSeason.ControlContentsChanged, ucrInputTextType.ControlContentsChanged, ucrReceiverStartofRains.ControlContentsChanged, ucrReceiverEndofRains.ControlContentsChanged, ucrReceiverStartofRainsLogical.ControlContentsChanged, ucrReceiverEndofRainsLogical.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorLengthofSeason_DataFrameChanged() Handles ucrSelectorLengthofSeason.DataFrameChanged
        clsConvertColumnTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorLengthofSeason.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrChkLengthmore_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLengthmore.ControlValueChanged
        EnableLengthmore()
        If ucrChkLengthmore.Checked Then
            clsCombinationListFunction.AddParameter("sub3", clsRFunctionParameter:=clsLengthmoreFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsCombinationListFunction.RemoveParameterByName("sub3")
        End If
    End Sub

    Private Sub EnableLengthmore()
        ucrChkLengthmore.Enabled = ucrChkType.Checked
    End Sub

    Private Sub ucrInputLengthofSeason_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLengthofSeason.ControlValueChanged
        If Not ucrInputLengthofSeason.IsEmpty Then
            clsElseIfMoreFunction.AddParameter("no", ucrInputLengthofSeason.GetText(), iPosition:=2, bIncludeArgumentName:=False)
            clsLengthmoreFunction.AddParameter("result_name", Chr(34) & ucrInputLengthofSeason.GetText & "_more" & Chr(34), iPosition:=2)
        Else
            clsElseIfMoreFunction.RemoveParameterByName("no")
            clsLengthmoreFunction.RemoveParameterByName("result_name")
        End If
    End Sub

    Private Sub ucrInputTextType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTextType.ControlValueChanged
        If Not ucrInputTextType.IsEmpty Then
            clsAscharactermoreFunction.AddParameter("x", ucrInputTextType.GetText(), iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsAscharactermoreFunction.RemoveParameterByName("x")
        End If
    End Sub
End Class