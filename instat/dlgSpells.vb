'' Instat-R
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
Public Class dlgSpells
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsAddKey, clsSpellLength, clsMaxValueManipulation, clsSubSpellLength1 As New RFunction
    Private clsMaxValue, clsMaxValueList, clsMaxValueFunction As New RFunction
    Private clsDayFromAndTo, clsGroupBy, clsAddKeyColName As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator As New ROperator
    Private clsApplyInstatFunction, clsRRainday, clsRRaindayMatch As New RFunction
    Private clsRRaindayOperator, clsRRaindayAndOperator, clsRRaindayLowerOperator, clsRRaindayUpperOperator, clsAdditionalConditionReplaceOperator, clsAdditionalConditionReplaceOperator2 As New ROperator
    Private clsAdditionalCondition, clsAdditionalConditionList, clsSubSpellLength2, clsAdditionalConditionReplaceFunction As New RFunction
    Private strCurrDataName As String = ""

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
        Dim dctInputSumPairs As New Dictionary(Of String, String)

        ucrSelectorForSpells.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForSpells.SetParameterIsString()

        ' Setting receivers
        ucrReceiverRainfall.SetParameter(New RParameter("rain", 0))
        ucrReceiverRainfall.SetParameterIsRFunction()
        ucrReceiverRainfall.bWithQuotes = False
        '        ucrReceiverRainfall.SetParameterIncludeArgumentName(False)
        ucrReceiverRainfall.Selector = ucrSelectorForSpells
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForSpells
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorForSpells
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date", 0))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForSpells
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForSpells
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True

        clsSubSpellLength1.SetRCommand("list")
        clsMaxValueList.SetRCommand("list")

        ucrNudFrom.SetParameter(New RParameter("from", 1))
        ucrNudFrom.SetMinMax(1, 365)

        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudTo.SetMinMax(2, 366)

        ucrInputSpellLower.SetParameter(New RParameter("min", 1))
        ucrInputSpellLower.SetValidationTypeAsNumeric()
        ucrInputSpellLower.AddQuotesIfUnrecognised = False

        ucrInputSpellUpper.SetParameter(New RParameter("max", 1))
        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.AddQuotesIfUnrecognised = False

        'ucrInputCondition.SetParameter(New RParameter(""))
        'Dim dctCondition As New Dictionary(Of String, String)
        'dctCondition.Add("Between", "between")
        'dctCondition.Add("Less than", Chr(34) & "<" & Chr(34))
        'dctCondition.Add("Greater than", Chr(34) & ">" & Chr(34))
        'ucrInputCondition.SetItems(dctCondition)

        ucrInputCondition.SetItems({"<= Amount of Rain", "Between", ">= Amount of Rain"})
        ucrInputCondition.SetDropDownStyleAsNonEditable()

        ucrChkConditional.SetText("Conditional on Rain at Start of Spell") ' todo: set default

        ucrSaveSpells.SetDataFrameSelector(ucrSelectorForSpells.ucrAvailableDataFrames)
        ucrSaveSpells.SetLabelText("New Column Name:")
        ucrSaveSpells.SetIsTextBox()
        ucrSaveSpells.SetPrefix("Spells")
        ucrSaveSpells.SetSaveTypeAsColumn()
    End Sub

    Private Sub SetDefaults()
        Dim strRainDay As String = "rain_day"
        Dim strDrySpell As String = "Dry_Spell"
        Dim strRainDay2 As String = "rain_day2"

        clsApplyInstatFunction = New RFunction
        clsMaxValueManipulation = New RFunction
        clsDayFromAndTo = New RFunction
        clsGroupBy = New RFunction
        clsAddKey = New RFunction
        clsAddKeyColName = New RFunction
        clsRRainday = New RFunction
        clsSpellLength = New RFunction
        clsMaxValue = New RFunction
        clsDayFromAndToOperator = New ROperator
        clsDayFromOperator = New ROperator
        clsDayToOperator = New ROperator
        clsRRaindayOperator = New ROperator
        clsRRaindayAndOperator = New ROperator
        clsRRaindayLowerOperator = New ROperator
        clsRRaindayUpperOperator = New ROperator
        clsMaxValueFunction = New RFunction
        clsAdditionalCondition = New RFunction
        clsAdditionalConditionList = New RFunction
        clsSubSpellLength2 = New RFunction
        clsAdditionalConditionReplaceFunction = New RFunction
        clsAdditionalConditionReplaceOperator2 = New ROperator
        clsAdditionalConditionReplaceOperator = New ROperator

        ucrSelectorForSpells.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrInputCondition.SetName("<= Amount of Rain") 'TODO1: set item/name as this

        ' key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        'DayFromandTo
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366)

        ' group
        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsGroupBy.SetAssignTo("Grouping")

        ' rain_day
        clsRRaindayMatch.bToScriptAsRString = True
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRRainday.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsRRainday.AddParameter("save", "0", iPosition:=6)
        clsRRainday.AddParameter("function_exp", clsRFunctionParameter:=clsRRaindayMatch, iPosition:=1)
        clsRRaindayMatch.SetRCommand("match")
        clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator)
        clsRRaindayAndOperator.SetOperation("&")
        clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
        clsRRaindayLowerOperator.SetOperation(">=")
        clsRRaindayLowerOperator.AddParameter("min", 0, iPosition:=1)
        clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        clsRRaindayUpperOperator.SetOperation("<=")
        clsRRaindayUpperOperator.AddParameter("max", 0.85, iPosition:=1) ' why 0.85?
        clsRRaindayMatch.AddParameter("table", "1", iPosition:=1)
        clsRRaindayMatch.AddParameter("nomatch", "0", iPosition:=2)

        ' We have: match(Rain >= LOWER & Rain <= UPPER, 1, nomatch = 0)
        ' Spell Length
        clsSpellLength.SetRCommand("instat_calculation$new")
        clsSpellLength.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsSpellLength.AddParameter("result_name", Chr(34) & strDrySpell & Chr(34), iPosition:=2)
        clsSpellLength.AddParameter("save", 0, iPosition:=6)
        clsSpellLength.SetAssignTo(strDrySpell)

        clsMaxValueManipulation.SetRCommand("list")

        ' Additional Checkbox
        clsAdditionalConditionReplaceFunction.bToScriptAsRString = True
        clsAdditionalCondition.SetRCommand("instat_calculation$new")
        clsAdditionalCondition.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsAdditionalCondition.AddParameter("function_exp", clsRFunctionParameter:=clsAdditionalConditionReplaceFunction, iPosition:=1)
        clsAdditionalCondition.AddParameter("result_name", Chr(34) & strRainDay2 & Chr(34), iPosition:=2)
        clsAdditionalCondition.AddParameter("save", 0, iPosition:=6)
        clsAdditionalConditionReplaceFunction.SetRCommand("replace")
        clsAdditionalConditionReplaceFunction.AddParameter("x", strRainDay, iPosition:=0)
        clsAdditionalConditionReplaceFunction.AddParameter("list", ucrNudFrom.Value - 1, iPosition:=1)
        clsAdditionalConditionReplaceFunction.AddParameter("values", "0", iPosition:=2)
        clsAdditionalConditionList.SetRCommand("list")

        'Max Value
        clsMaxValueFunction.bToScriptAsRString = True
        clsMaxValue.SetRCommand("instat_calculation$new")
        clsMaxValue.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsMaxValue.AddParameter("function_exp", clsRFunctionParameter:=clsMaxValueFunction, iPosition:=1)
        clsMaxValueFunction.SetRCommand("max")
        clsMaxValueFunction.AddParameter("x", strDrySpell)
        clsMaxValue.AddParameter("result_name", Chr(34) & ucrSaveSpells.GetText() & Chr(34), iPosition:=3)
        clsMaxValue.AddParameter("save", 2, iPosition:=6)
        clsMaxValue.SetAssignTo(ucrSaveSpells.GetText)
        clsMaxValue.SetAssignTo("Spells_Rain")

        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsMaxValue, iPosition:=0)
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudFrom.AddAdditionalCodeParameterPair(clsAdditionalConditionReplaceOperator2, New RParameter("list", 0), iAdditionalPairNo:=1)
        'For day:
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)

        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRRaindayLowerOperator, New RParameter("rain", 0), iAdditionalPairNo:=1)
        ucrReceiverRainfall.SetRCode(clsRRaindayUpperOperator, bReset)
        ucrInputSpellLower.SetRCode(clsRRaindayLowerOperator, bReset)
        ucrInputSpellUpper.SetRCode(clsRRaindayUpperOperator, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)
        ucrSelectorForSpells.SetRCode(clsAddKey, bReset)
    End Sub

    Private Sub TestOKEnabled() 'TODO2: check this sub works and everything is calling
        If Not ucrReceiverRainfall.IsEmpty AndAlso ucrSaveSpells.IsComplete AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrInputSpellLower.Text <> "" AndAlso ucrNudFrom.GetText <> "" AndAlso ucrNudTo.GetText <> "" AndAlso ucrInputSpellUpper.Text <> "" Then
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

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Spells: Defining column(s) as key")
        '        clsDayFromAndTo.SetAssignTo("Day_From_and_To")


        ' conditional is checked:
        ' clsSpellLength has a different function expression. Can't it have the same? And strRainDay2 = strRainDay1 and overwrites itself

        If ucrChkConditional.Checked Then
            clsAdditionalConditionList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday)
            clsAdditionalCondition.AddParameter("sub_calculation", clsRFunctionParameter:=clsAdditionalConditionList)

            clsAdditionalCondition.AddParameter("function_exp", Chr(34) & clsAdditionalConditionReplaceFunction.ToScript & Chr(34))
            clsAdditionalCondition.SetAssignTo("Additional_Condition")
            clsSpellLength.AddParameter("function_exp", Chr(34) & "cumsum(" & strRainDay2 & ")-cummax((" & strRainDay2 & "==0)*cumsum(" & strRainDay2 & "))" & Chr(34))
            clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength1)
            clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsAdditionalCondition, bIncludeArgumentName:=False)
        Else
            clsSpellLength.AddParameter("function_exp", Chr(34) & "cumsum(" & strRainDay & ")-cummax((" & strRainDay & "==0)*cumsum(" & strRainDay & "))" & Chr(34))
            clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength1)
            clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub DayBoundaries() ' TODO: What to do about the calculated_from, sub1, etc
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=5)
        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
    End Sub

    Private Sub RainyDaysMethod()
        clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False)
        clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength1)
    End Sub

    Private Sub ucrInputSpellLower_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpellLower.ControlValueChanged, ucrInputSpellUpper.ControlValueChanged, ucrInputCondition.ControlValueChanged
        Select Case ucrInputCondition.GetText
            Case "<= Amount of Rain"
                ucrInputSpellUpper.Visible = False
                clsRRaindayOperator.RemoveParameterByName("upper_operators")
                clsRRaindayOperator.RemoveParameterByName("lower_upper_operators")
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
                ucrInputSpellUpper.Visible = True
                clsRRaindayOperator.RemoveParameterByName("upper_operators")
                clsRRaindayOperator.RemoveParameterByName("lower_operators")
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
            Case Else
                ucrInputSpellUpper.Visible = False
                clsRRaindayOperator.RemoveParameterByName("lower_operators")
                clsRRaindayOperator.RemoveParameterByName("lower_upper_operators")
                clsRRaindayOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        End Select
    End Sub

    Private Sub ucrReceiverRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=0)
        clsMaxValue.AddParameter("sub_calculations", clsRFunctionParameter:=clsMaxValueList, iPosition:=4)
        clsMaxValueList.AddParameter("sub1", clsRFunctionParameter:=clsSpellLength, bIncludeArgumentName:=False, iPosition:=0)
        RainyDaysMethod()
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForSpells.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
    End Sub

    Private Sub nudValues()
        '  nudFrom.Maximum = ucrNudTo.Value - 1
        ' ucrNudTo.Minimum = nudFrom.Value + 1
        'nudMaximumDays.Maximum = nudLengthofTime.Value - 1
        'nudLengthofTime.Minimum = nudMaximumDays.Value + 1
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayBoundaries()
        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=5)
        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        ' does this update if I change the data name?
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")")
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
        End If
        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=5)
        clsMaxValueManipulation.AddParameter("sub2", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrNudFrom_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudFrom.ControlValueChanged
        clsAdditionalConditionReplaceFunction.AddParameter("list", ucrNudFrom.Value - 1, iPosition:=1)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveSpells.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrInputSpellLower.ControlContentsChanged, ucrInputSpellUpper.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class