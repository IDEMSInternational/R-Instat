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
    Private clsMaxValue, clsMaxValueList As New RFunction
    Private clsDayFromAndTo, clsYearGroupDaily As New RFunction
    Private clsApplyInstatFunction, clsRRainday As New RFunction
    Private strCurrDataName As String = ""
    Private strValuesUnder As String = ">="

    Private Sub dlgSpells_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            SetDefaults()
            bFirstload = False
            '        Else
            '            ReopenDialog()
        End If
        SetRCodeForControls(bReset)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 200
        Dim dctInputSumPairs As New Dictionary(Of String, String)

        ucrSelectorForSpells.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForSpells.SetParameterIsString()

        ' Setting receivers
        ucrReceiverRainfall.SetParameter(New RParameter("data", 0))
        ucrReceiverRainfall.SetParameterIsString()
        ucrReceiverRainfall.bWithQuotes = False
        ucrReceiverRainfall.SetParameterIncludeArgumentName(False)
        ucrReceiverRainfall.Selector = ucrSelectorForSpells
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True

        ucrReceiverStation.Selector = ucrSelectorForSpells
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorForSpells
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("col_name", 0))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForSpells
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.Selector = ucrSelectorForSpells
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True

        'clsRTransform.SetRCommand("instat_calculation$new")
        'clsRTransform.SetAssignTo("transform_calculation")

        clsSubSpellLength1.SetRCommand("list")
        clsMaxValueList.SetRCommand("list")

        'ucrInputCondition.SetParameter(New RParameter(""))
        'Dim dctCondition As New Dictionary(Of String, String)
        'dctCondition.Add("Between", "between")
        'dctCondition.Add("Less than", Chr(34) & "<" & Chr(34))
        'dctCondition.Add("Greater than", Chr(34) & ">" & Chr(34))
        'ucrInputCondition.SetItems(dctCondition)

        ucrInputCondition.SetItems({"<= Amount of Rain", "Between", ">= Amount of Rain"})

        ucrSaveSpells.SetDataFrameSelector(ucrSelectorForSpells.ucrAvailableDataFrames)
        ucrSaveSpells.SetLabelText("New Column Name:")
        ucrSaveSpells.SetIsTextBox()
        ucrSaveSpells.SetPrefix("Spells")
        ucrSaveSpells.SetSaveTypeAsColumn()
    End Sub

    '        clsSubSpellLength2.SetRCommand("list")
    '        clsAdditionalCondition.SetRCommand("instat_calculation$new")
    '        clsAdditionalCondition.SetAssignTo("Additional_Condition")

    Private Sub SetDefaults()
        clsApplyInstatFunction = New RFunction
        clsMaxValueManipulation = New RFunction
        clsDayFromAndTo = New RFunction
        clsYearGroupDaily = New RFunction
        clsRRainday = New RFunction
        clsSpellLength = New RFunction
        clsMaxValue = New RFunction

        ucrSelectorForSpells.Reset()
        ucrReceiverDate.SetMeAsReceiver()

        ' key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")

        'DayFromandTo
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & ucrNudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & ucrNudTo.Value & Chr(34))
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))

        ' Year group
        clsYearGroupDaily.SetRCommand("instat_calculation$new")
        clsYearGroupDaily.AddParameter("type", Chr(34) & "by" & Chr(34))

        ' rain_day option
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverRainfall.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverRainfall.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0,1)" & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34), iPosition:=3)
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=0)
        clsRRainday.AddParameter("save", "0", iPosition:=4)

        ' Spell Length
        clsSpellLength.SetRCommand("instat_calculation$new")
        clsSpellLength.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsSpellLength.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
        clsSpellLength.AddParameter("save", 0)
        clsSpellLength.AddParameter("function_exp", Chr(34) & "cumsum(rain_day)-cummax((rain_day==0)*cumsum(rain_day))" & Chr(34))

        ' Base
        clsMaxValueManipulation.SetRCommand("list")
        clsMaxValueManipulation.AddParameter("sub2", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

        'Max Value
        clsMaxValue.SetRCommand("instat_calculation$new")
        clsMaxValue.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=1)
        clsMaxValue.AddParameter("function_exp", Chr(34) & "max(Dry_Spell)" & Chr(34), iPosition:=2)
        clsMaxValue.AddParameter("result_name", Chr(34) & ucrSaveSpells.GetText() & Chr(34), iPosition:=3)
        clsMaxValue.AddParameter("save", 2, iPosition:=4)
        clsMaxValue.SetAssignTo(ucrSaveSpells.ucrInputTextSave.GetText)
        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=4)

        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsMaxValue, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDate.SetRCode(clsAddKey, bReset)
        ucrSelectorForSpells.SetRCode(clsAddKey, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'If Not ucrReceiverRainfall.IsEmpty AndAlso ucrSaveSpells.IsComplete AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrInputSpellLower.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso ucrInputSpellUpper.Text <> "" Then ' and ucrInput is empty
        ucrBase.OKEnabled(True)
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining Date column as key")
        clsMaxValue.SetAssignTo("Spells_Rain")
        clsSpellLength.SetAssignTo("Dry_Spell")
        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
        clsYearGroupDaily.SetAssignTo("grouping")
        SubCalcForDrySpell()
        SetGroupByFuncCalcFrom()
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsMaxValue, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
    End Sub

    'Private Sub ucrPnlTransform_ControlContentsChanged(ucrChangedControl As ucrCore) Handles 
    '    Dim bRain As Boolean = False
    '    clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverRainfall.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrreceiverrain.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0, 1)" & Chr(34))
    '    clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday)
    '        clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=6)
    '    SetAssignName()
    'End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForSpells.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverRainfall.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverRainfall.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0, 1)" & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=0)
    End Sub

    Private Sub SetGroupByFuncCalcFrom()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""
        strCurrDataName = Chr(34) & ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        If Not ucrReceiverStation.IsEmpty Then
            clsYearGroupDaily.SetAssignTo("grouping")
            clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation, iPosition:=4)

            '            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        Else
            clsMaxValue.RemoveParameterByName("manipulations")

        End If
        '        If strGroupByCalcFrom <> "" Then
        '        clsYearGroupDaily.AddParameter("calculated_from", strGroupByCalcFrom, iPosition:=0)
        '        Else
        '        clsYearGroupDaily.RemoveParameterByName("calculated_from")
        '        End If
        MaxValue()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSpellBetween_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputSpellUpper.ControlContentsChanged, ucrInputSpellLower.ControlContentsChanged
        clsMaxValueList.AddParameter("sub1", clsRFunctionParameter:=clsSpellLength, bIncludeArgumentName:=False, iPosition:=0)
        clsMaxValue.AddParameter("sub_calculations", clsRFunctionParameter:=clsMaxValueList, iPosition:=7)
        TestOKEnabled()
        RainyDaysMethod()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged()

    End Sub

    Private Sub MaxValue()
        clsMaxValueManipulation.AddParameter("sub2", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsMaxValueList.AddParameter("sub1", clsRFunctionParameter:=clsSpellLength, bIncludeArgumentName:=False)

        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation)
        clsMaxValue.AddParameter("sub_calculations", clsRFunctionParameter:=clsMaxValueList)
    End Sub

    Private Sub SubCalcForDrySpell()
        clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False)
        clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength1)
    End Sub

    Private Sub RainyDaysMethod()
        Select Case ucrInputCondition.GetText
            Case "<= Amount of Rain"
                clsRRainday.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & ucrInputSpellLower.GetText & "," & "1, nomatch = 0" & ")" & Chr(34))
            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
                clsRRainday.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & ucrInputSpellLower.GetText & "&" & ucrReceiverRainfall.GetVariableNames(False) & "<=" & ucrInputSpellUpper.GetText & "," & "1, nomatch = 0" & ")" & Chr(34))
            Case Else
                clsRRainday.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & "<=" & ucrInputSpellLower.GetText & "," & "1, nomatch = 0" & ")" & Chr(34))
        End Select
    End Sub

    Private Sub Ifthenudschange() ' and if the receiver changes
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & ucrNudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & ucrNudTo.Value & Chr(34))
    End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        clsYearGroupDaily.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub nudTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudTo.ControlValueChanged, ucrNudFrom.ControlValueChanged
        Ifthenudschange()
    End Sub
End Class

'TODO: Make by Year and Station
'TODO: Add functionality for chkbox

'    Private Sub SetDefaults()
'        ucrSelectorForSpells.Reset()
'        ucrSaveSpells.Reset()

'        TestOKEnabled()

'        chkConditionRain.Checked = False
'        nudFrom.Value = 1
'        nudTo.Value = 366
'        nudConditionLeft.Value = 0
'        NudConditionRight.Value = 0.85
'        ucrInputCondition.SetName("Between")
'    End Sub

'    Private Sub ReopenDialog()

'    End Sub

'    Private Sub DisplayForConditions()
'        Select Case ucrInputCondition.GetText
'            Case "Between"
'                nudConditionLeft.Visible = True
'                NudConditionRight.Visible = True
'            Case Else
'                nudConditionLeft.Visible = True
'                NudConditionRight.Visible = False
'        End Select
'    End Sub

'    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
'        SetDefaults()
'    End Sub

'    ' nud max and mins.
'    Private Sub nudValues()
'        '  nudFrom.Maximum = ucrNudTo.Value - 1
'        ' ucrNudTo.Minimum = nudFrom.Value + 1
'        'nudMaximumDays.Maximum = nudLengthofTime.Value - 1
'        'nudLengthofTime.Minimum = nudMaximumDays.Value + 1
'    End Sub

'    Private Sub DayFromAndToMethod()

'    End Sub



' Private Sub RainyDaysMethod()
'        If chkConditionRain.Checked Then
'            clsSpellLength.RemoveParameterByName("function_exp")
'            clsSpellLength.RemoveParameterByName("sub_calculations")
'            clsSubSpellLength1.RemoveParameterByName("sub1")

'            clsAdditionalCondition.AddParameter("type", Chr(34) & "calculation" & Chr(34))
'            clsAdditionalCondition.AddParameter("function_exp", Chr(34) & "replace(rain_day, " & (nudFrom.Value - 1) & ", 0)" & Chr(34))
'            clsAdditionalCondition.AddParameter("result_name", Chr(34) & "rain_day2" & Chr(34))
'            clsAdditionalCondition.AddParameter("sub_calculation", clsRFunctionParameter:=clsAdditionalConditionList)
'            clsAdditionalConditionList.SetRCommand("list")
'            clsAdditionalConditionList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday)
'            clsAdditionalCondition.AddParameter("save", 0)

'            clsSpellLength.AddParameter("function_exp", Chr(34) & "cumsum(rain_day2)-cummax((rain_day2==0)*cumsum(rain_day2))" & Chr(34))
'            clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength2)
'            clsSubSpellLength2.AddParameter("sub1", clsRFunctionParameter:=clsAdditionalCondition, bIncludeArgumentName:=False)
'        Else
'            clsAdditionalCondition.RemoveParameterByName("type")
'            clsAdditionalCondition.RemoveParameterByName("function_exp")
'            clsAdditionalCondition.RemoveParameterByName("result_name")
'            clsAdditionalCondition.RemoveParameterByName("sub_calculation")
'            clsAdditionalCondition.RemoveParameterByName("save")
'            clsAdditionalConditionList.RemoveParameterByName("sub1")
'            clsSpellLength.RemoveParameterByName("function_exp")
'            clsSpellLength.RemoveParameterByName("sub_calculations")
'            clsSubSpellLength2.RemoveParameterByName("sub1")

'            clsSpellLength.AddParameter("function_exp", Chr(34) & "cumsum(rain_day)-cummax((rain_day==0)*cumsum(rain_day))" & Chr(34))
'            clsSpellLength.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubSpellLength1)
'            clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False)
'        End If
'    End Sub

'    Private Sub ucrInputCondition_NameChanged() Handles ucrInputCondition.NameChanged
'        DisplayForConditions()
'        RainyDaysMethod()
'    End Sub

'''''''''''''Private Sub MaxValue()
'''''''''''''    clsMaxValueManipulation.SetRCommand("list")
'''''''''''''    clsMaxValueManipulation.AddParameter("sub2", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
'''''''''''''    clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

'''''''''''''    clsMaxValue.AddParameter("type", Chr(34) & "summary" & Chr(34))
'''''''''''''    clsMaxValue.AddParameter("function_exp", Chr(34) & "max(Dry_Spell)" & Chr(34))
'''''''''''''    clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation)
'''''''''''''    clsMaxValue.AddParameter("sub_calculations", clsRFunctionParameter:=clsMaxValueList)
'''''''''''''    clsMaxValueList.AddParameter("sub1", clsRFunctionParameter:=clsSpellLength, bIncludeArgumentName:=False)
'''''''''''''    clsMaxValue.AddParameter("result_name", Chr(34) & ucrSaveSpells.GetText() & Chr(34))
'''''''''''''    clsMaxValue.AddParameter("save", 2)
'''''''''''''End Sub

'''''''''''''    Private Sub firstDayofTheYear()
'''''''''''''        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsMaxValue)
'''''''''''''    End Sub

'    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
'        DayFromAndToMethod()
'        RainyDaysMethod()
'        MaxValue()
'    End Sub

'    Private Sub nudToAndFrom_ControlValueChanged(sender As Object, e As EventArgs) Handles nudTo.TextChanged, nudFrom.TextChanged
'        nudValues()
'        DayFromAndToMethod()
'        RainyDaysMethod()
'        TestOKEnabled()
'    End Sub

'    Private Sub ucrReceiverDOY(sender As Object, e As EventArgs) Handles ucrReceiverDayOfYear.SelectionChanged
'        DayFromAndToMethod()
'        MaxValue()
'        firstDayofTheYear()
'        TestOKEnabled()
'    End Sub

'    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
'        RainyDaysMethod()
'        TestOKEnabled()
'    End Sub


'    Private Sub ConditionalRainNuds_valuechanged(sender As Object, e As EventArgs) Handles NudConditionRight.TextChanged, nudConditionLeft.TextChanged
'        RainyDaysMethod()
'        TestOKEnabled()
'    End Sub

'    Private Sub chkConditionRain_CheckedChanged(sender As Object, e As EventArgs) Handles chkConditionRain.CheckedChanged
'        RainyDaysMethod()
'    End Sub

'    Private Sub ucrSaveSpells_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveSpells.ControlContentsChanged
'        TestOKEnabled()
'    End Sub

'    Private Sub ucrSaveSpells_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveSpells.ControlValueChanged
'''''''''''''        clsMaxValue.SetAssignTo(ucrSaveSpells.ucrInputTextSave.GetText)
'        MaxValue()
'    End Sub
'End Class