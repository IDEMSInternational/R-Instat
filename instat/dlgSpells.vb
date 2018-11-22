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
Public Class dlgSpells
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSpellLength, clsMaxValueManipulation, clsSubSpellLength1 As New RFunction
    Private clsMaxValue, clsMaxValueList, clsMaxValueFunction, clsSpellOrGroupList As New RFunction
    Private clsDayFromAndTo, clsGroupBy, clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator As New ROperator
    Private clsApplyInstatFunction, clsRRainday, clsRRaindayMatch As New RFunction
    Private clsConsecutiveSum As New RFunction
    Private clsRRaindayOperator, clsRRaindayAndOperator, clsRRaindayLowerOperator, clsRRaindayUpperOperator, clsAdditionalConditionReplaceOperator, clsAdditionalConditionReplaceOperator2, clsGreaterThanOperator, clsLessThanOperator As New ROperator
    Private clsAdditionalCondition, clsAdditionalConditionList, clsSubSpellLength2, clsAdditionalConditionReplaceFunction As New RFunction

    Private strCurrDataName As String = ""
    Private strRainDay As String = "rain_day"

    Private Sub dlgSpells_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 200

        ucrSelectorForSpells.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForSpells.SetParameterIsString()

        ' Setting receivers
        ucrReceiverElement.SetParameter(New RParameter("rain", 0))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.Selector = ucrSelectorForSpells
        'ucrReceiverElement.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverElement.bAutoFill = True
        ucrReceiverElement.SetDataType("numeric")
        ucrReceiverElement.strSelectorHeading = "Variables"

        ucrReceiverStation.SetParameter(New RParameter("station", 1, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForSpells
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.Selector = ucrSelectorForSpells
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverDate.SetParameter(New RParameter("date", 0, False))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForSpells
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForSpells
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        clsSubSpellLength1.SetRCommand("list")
        clsMaxValueList.SetRCommand("list")

        ucrInputSpellLower.SetParameter(New RParameter("min", 1))
        ucrInputSpellLower.SetValidationTypeAsNumeric()
        ucrInputSpellLower.AddQuotesIfUnrecognised = False

        ucrInputSpellUpper.SetParameter(New RParameter("max", 1))
        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.AddQuotesIfUnrecognised = False

        ucrInputCondition.SetItems({"<=", "Between", "Outer", ">="})
        ucrInputCondition.SetDropDownStyleAsNonEditable()

        ucrChkConditional.SetText("Assuming Condition Satisfied at Start of Each Period")
        ucrChkConditional.SetParameter(New RParameter("initial_value"))
        ucrChkConditional.SetValuesCheckedAndUnchecked("0", "NA")
        ucrChkConditional.SetRDefault("NA")

        ucrInputNewColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorForSpells.ucrAvailableDataFrames)
        ucrInputNewColumnName.SetName("spells")

        ucrInputCondition.AddToLinkedControls(ucrInputSpellUpper, {"<=", "Between", "Outer", ">="}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)
        ucrInputCondition.AddToLinkedControls(ucrInputSpellLower, {"Between", "Outer"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrInputFilterPreview.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        Dim strRainDay As String = "rain_day"
        Dim strDrySpell As String = "Dry_Spell"

        clsApplyInstatFunction.Clear()
        clsMaxValueManipulation.Clear()
        clsDayFromAndTo.Clear()
        clsGroupBy.Clear()
        clsRRainday.Clear()
        clsSpellLength.Clear()
        clsMaxValue.Clear()
        clsDayFromAndToOperator.Clear()
        clsDayFromOperator.Clear()
        clsDayToOperator.Clear()
        clsRRaindayOperator.Clear()
        clsRRaindayAndOperator.Clear()
        clsRRaindayLowerOperator.Clear()
        clsRRaindayUpperOperator.Clear()
        clsMaxValueFunction.Clear()
        clsAdditionalCondition.Clear()
        clsAdditionalConditionList.Clear()
        clsSubSpellLength2.Clear()
        clsAdditionalConditionReplaceFunction.Clear()
        clsAdditionalConditionReplaceOperator2.Clear()
        clsAdditionalConditionReplaceOperator.Clear()
        clsGreaterThanOperator.Clear()
        clsLessThanOperator.Clear()

        ucrSelectorForSpells.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        ucrInputCondition.SetName("Between")
        ucrInputNewColumnName.SetName("spells")
        ucrInputSpellLower.SetName(0)
        ucrInputSpellUpper.SetName(0.85)

        ' key

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        'DayFromandTo
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.bBrackets = False
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")
        clsDayFromAndTo.AddParameter("calculated_from", clsRFunctionParameter:=clsDayFilterCalcFromConvert, iPosition:=2)

        ' group
        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsGroupBy.SetAssignTo("grouping")

        clsSpellOrGroupList.SetRCommand("list")
        clsSpellOrGroupList.AddParameter("sub1", clsRFunctionParameter:=clsSpellLength, bIncludeArgumentName:=False, iPosition:=0)
        clsSpellOrGroupList.AddParameter("sub2", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False)

        ' rain_day
        'TODO remove this function
        'clsRRaindayMatch.bToScriptAsRString = True
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRRainday.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("save", "0", iPosition:=6)
        clsRRainday.AddParameter("function_exp", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=1)

        'clsRRaindayMatch.SetRCommand("match")
        'clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator)
        clsRRaindayAndOperator.bToScriptAsRString = True
        clsRRaindayAndOperator.SetOperation("&")
        clsRRaindayLowerOperator.SetOperation(">=")
        clsRRaindayLowerOperator.AddParameter("min", 0, iPosition:=1)
        clsRRaindayUpperOperator.SetOperation("<=")
        clsRRaindayUpperOperator.AddParameter("max", 0.85, iPosition:=1)
        'clsRRaindayMatch.AddParameter("table", "1", iPosition:=1)
        'clsRRaindayMatch.AddParameter("nomatch", "0", iPosition:=2)
        clsGreaterThanOperator.SetOperation(">")
        clsLessThanOperator.SetOperation("<")

        ' Spell Length
        clsSpellLength.SetRCommand("instat_calculation$new")
        clsSpellLength.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsSpellLength.AddParameter("result_name", Chr(34) & strDrySpell & Chr(34), iPosition:=2)
        clsSpellLength.AddParameter("function_exp", clsRFunctionParameter:=clsConsecutiveSum)
        clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength1, iPosition:=5)
        clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False)
        clsSpellLength.AddParameter("save", 0, iPosition:=6)
        clsSpellLength.SetAssignTo("spell_length")
        clsMaxValueManipulation.SetRCommand("list")

        ' Additional Checkbox
        'clsAdditionalConditionReplaceFunction.bToScriptAsRString = True
        'clsAdditionalCondition.SetRCommand("instat_calculation$new")
        'clsAdditionalCondition.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        'clsAdditionalCondition.AddParameter("function_exp", clsRFunctionParameter:=clsAdditionalConditionReplaceFunction, iPosition:=1)
        'clsAdditionalCondition.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        'clsAdditionalCondition.AddParameter("save", 0, iPosition:=6)
        'clsAdditionalCondition.SetAssignTo("additional_condition")
        'clsAdditionalConditionReplaceFunction.SetRCommand("replace")
        'clsAdditionalConditionReplaceFunction.AddParameter("x", strRainDay, iPosition:=0)
        'clsAdditionalConditionReplaceFunction.AddParameter("values", "0", iPosition:=2)
        'clsAdditionalConditionList.SetRCommand("list")
        'clsAdditionalConditionList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday)
        'clsAdditionalCondition.AddParameter("sub_calculation", clsRFunctionParameter:=clsAdditionalConditionList)

        'Max Value
        clsMaxValueFunction.bToScriptAsRString = True
        clsMaxValue.SetRCommand("instat_calculation$new")
        clsMaxValue.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsMaxValue.AddParameter("function_exp", clsRFunctionParameter:=clsMaxValueFunction, iPosition:=1)
        clsMaxValueFunction.SetRCommand("max")
        clsMaxValueFunction.AddParameter("x", strDrySpell)
        clsMaxValue.AddParameter("save", 2, iPosition:=6)
        clsMaxValue.AddParameter("result_name", Chr(34) & ucrInputNewColumnName.GetText() & Chr(34), iPosition:=3)
        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=5)
        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

        clsMaxValue.AddParameter("sub_calculation", clsRFunctionParameter:=clsSpellOrGroupList, iPosition:=5)
        clsMaxValue.SetAssignTo("spells")

        clsConsecutiveSum.bToScriptAsRString = True
        clsConsecutiveSum.SetRCommand(".spells")
        clsConsecutiveSum.AddParameter("x", strRainDay)

        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsMaxValue, iPosition:=0)
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsRRaindayLowerOperator, New RParameter("rain", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=2)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=3)
        ucrInputSpellUpper.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("left", 1), iAdditionalPairNo:=1)
        ucrInputSpellLower.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("left", 1), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrReceiverElement.SetRCode(clsRRaindayUpperOperator, bReset)
        ucrInputSpellLower.SetRCode(clsRRaindayLowerOperator, bReset)
        ucrInputSpellUpper.SetRCode(clsRRaindayUpperOperator, bReset)
        ucrInputNewColumnName.SetRCode(clsMaxValue, bReset)
        ucrChkConditional.SetRCode(clsConsecutiveSum, bReset)
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFromAndTo, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
        sdgDoyRange.ShowDialog()
        UpdateDayFilterPreview()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverElement.IsEmpty AndAlso Not ucrInputNewColumnName.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ((ucrInputCondition.GetText = "Between" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = "Outer" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = "<=" AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = ">=" AndAlso Not ucrInputSpellUpper.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub InputConditionOptions()
        Select Case ucrInputCondition.GetText
            Case "<="
                ucrInputSpellLower.Visible = False
                clsRRaindayAndOperator.RemoveParameterByName("upper")
                clsRRaindayUpperOperator.RemoveParameterByName("max")
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
                ucrInputSpellLower.Visible = True
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
            Case "Outer"
                ucrInputSpellLower.Visible = True
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsGreaterThanOperator, iPosition:=0)
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsLessThanOperator, iPosition:=1)
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=2)
            Case ">="
                ucrInputSpellLower.Visible = False
                clsRRaindayAndOperator.RemoveParameterByName("lower")
                clsRRaindayLowerOperator.RemoveParameterByName("min")
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        End Select
    End Sub

    Private Sub ucrInputSpellLower_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpellLower.ControlValueChanged, ucrInputSpellUpper.ControlValueChanged, ucrInputCondition.ControlValueChanged
        InputConditionOptions()
    End Sub

    Private Sub RainDays()
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")", iPosition:=0)
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")")
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorForSpells.ControlValueChanged
        If Not ucrReceiverDOY.IsEmpty Then
            clsDayFilterCalcFromList.AddParameter(ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrChkConditional_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkConditional.ControlContentsChanged
        If ucrChkConditional.Checked Then
            clsMaxValue.AddParameter("sub_calculation", clsRFunctionParameter:=clsSpellOrGroupList, iPosition:=5)
            clsGroupBy.RemoveParameterByName("sub_calculation")
        Else
            clsGroupBy.AddParameter("sub_calculation", clsRFunctionParameter:=clsSpellOrGroupList, iPosition:=5)
            clsMaxValue.RemoveParameterByName("sub_calculation")
        End If
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorForSpells.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        RainDays()
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged
        RainDays()
    End Sub

    Private Sub ucrSelectorVariable_DataFrameChanged() Handles ucrSelectorForSpells.DataFrameChanged
        clsDayFilterCalcFromList.ClearParameters()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrInputNewColumnName.ControlContentsChanged, ucrInputCondition.ControlContentsChanged, ucrInputSpellLower.ControlContentsChanged, ucrInputSpellUpper.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub UpdateDayFilterPreview()
        If ucrReceiverDOY.IsEmpty Then
            ucrInputFilterPreview.SetName("")
        Else
            ucrInputFilterPreview.SetName(clsDayFromAndToOperator.ToScript())
        End If
    End Sub
End Class