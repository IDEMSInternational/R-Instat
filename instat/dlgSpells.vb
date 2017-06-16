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
    Private clsRTransform, clsRRollFuncExpr, clsMatchFun, clsTransformManipulationsFunc, clsTransformGroupByFunc, clsWaterBalance60, clsSubCalcList As New RFunction
    Private clsRollFunction, clsRRainday As New RFunction
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 200
        Dim dctInputSumPairs As New Dictionary(Of String, String)

        ' Setting receivers
        ucrReceiverRainfall.SetParameter(New RParameter("data", 0))
        ucrReceiverRainfall.SetParameterIsString()
        ucrReceiverRainfall.bWithQuotes = False
        ucrReceiverRainfall.SetParameterIncludeArgumentName(False)
        ucrReceiverRainfall.Selector = ucrSelectorForSpells

        ucrReceiverStation.Selector = ucrSelectorForSpells
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorForSpells
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorForSpells
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.Selector = ucrSelectorForSpells
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True

        'clsRTransform.SetRCommand("instat_calculation$new")
        'clsRTransform.SetAssignTo("transform_calculation")

        clsSubCalcList.SetRCommand("list")
    End Sub


    '    Private Sub InitialiseDialog()
    '        ucrBase.iHelpTopicID = 200
    '        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
    '        clsDayFromAndTo.SetRCommand("instat_calculation$new")
    '        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
    '        clsYearGroupDaily.SetRCommand("instat_calculation$new")
    '        clsYearGroupDaily.SetAssignTo("Year_Group_Daily")
    '        clsRainyDays.SetRCommand("instat_calculation$new")
    '        clsMaxValue.SetRCommand("instat_calculation$new")
    '        clsMaxValue.SetAssignTo("Max_Rain_Per_Year")
    '        clsSpellLength.SetRCommand("instat_calculation$new")
    '        clsSpellLength.SetAssignTo("Dry_Spell")
    '        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
    '        clsSubSpellLength1.SetRCommand("list")
    '        clsSubSpellLength2.SetRCommand("list")
    '        clsMaxValueManipulation.SetRCommand("list")
    '        clsAdditionalCondition.SetRCommand("instat_calculation$new")
    '        clsAdditionalCondition.SetAssignTo("Additional_Condition")

    '        clsMaxValueList.SetRCommand("list")
    '        ucrReceiverRainfall.Selector = ucrSelectorForSpells
    '        ucrReceiverYear.Selector = ucrSelectorForSpells
    '        ucrReceiverDate.Selector = ucrSelectorForSpells
    '        ucrReceiverDayOfYear.Selector = ucrSelectorForSpells
    '        ucrReceiverDate.SetMeAsReceiver()

    '        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
    '        ucrReceiverDayOfYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
    '        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
    '        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
    '        ucrReceiverDate.bAutoFill = True
    '        ucrReceiverDayOfYear.bAutoFill = True
    '        ucrReceiverRainfall.bAutoFill = True
    '        ucrReceiverYear.bAutoFill = True

    '        nudConditionLeft.DecimalPlaces = 2
    '        NudConditionRight.DecimalPlaces = 2

    '        'Dim dctCondition As New Dictionary(Of String, String)
    '        'dctCondition.Add("Between", "between")
    '        'dctCondition.Add("Less than", Chr(34) & "<" & Chr(34))
    '        'dctCondition.Add("Greater than", Chr(34) & ">" & Chr(34))
    '        'ucrInputCondition.SetItems(dctCondition)

    '        ucrInputCondition.SetItems({"<= Amount of Rain", "Between", ">= Amount of Rain"})
    '        nudFrom.Minimum = 1
    '        nudFrom.Maximum = 366
    '        nudTo.Minimum = 1
    '        nudTo.Maximum = 366

    '        'save
    '        ucrSaveSpells.SetDataFrameSelector(ucrSelectorForSpells.ucrAvailableDataFrames)
    '        ucrSaveSpells.SetLabelText("New Column Name:")
    '        ucrSaveSpells.SetIsTextBox()
    '        ucrSaveSpells.SetPrefix("Spells")
    '        ucrSaveSpells.SetSaveTypeAsColumn()
    '    End Sub

    Private Sub SetDefaults()
        clsRRollFuncExpr = New RFunction
        clsRTransform = New RFunction
        clsMatchFun = New RFunction
        clsRollFunction = New RFunction
        clsTransformManipulationsFunc = New RFunction
        clsTransformGroupByFunc = New RFunction

        ucrSelectorForSpells.Reset()
        ucrReceiverDate.SetMeAsReceiver()

        ' RDO1
        clsTransformGroupByFunc.SetRCommand("instat_calculation$new")
        clsTransformGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=2)
        clsTransformGroupByFunc.SetAssignTo("grouping")

        ' RDO2
        clsMatchFun.SetRCommand("match.fun")
        clsMatchFun.AddParameter("FUN", Chr(39) & "sum" & Chr(39), iPosition:=0)

        clsRRollFuncExpr.SetPackageName("zoo")
        clsRRollFuncExpr.SetRCommand("rollapply")
        clsRRollFuncExpr.AddParameter("data", ucrReceiverRainfall.GetVariableNames(bWithQuotes:=False), iPosition:=0)
        clsRRollFuncExpr.AddParameter("fill", "NA", iPosition:=3)
        clsRRollFuncExpr.AddParameter("width", 1, iPosition:=2)
        clsRRollFuncExpr.AddParameter("FUN", clsRFunctionParameter:=clsMatchFun, iPosition:=1)
        clsRRollFuncExpr.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)

        clsWaterBalance60.SetRCommand("instat_calculation$new")
        clsWaterBalance60.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsWaterBalance60.AddParameter("result_name", Chr(34) & "Water_Balance_60" & Chr(34), iPosition:=3)
        clsWaterBalance60.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=5)
        clsWaterBalance60.AddParameter("save", "2", iPosition:=4)
        clsWaterBalance60.SetAssignTo("Water_Balance_60")

        ' RDO4
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)

        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverRainfall.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverRainfall.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0,1)" & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34), iPosition:=3)
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=0)
        clsRRainday.AddParameter("save", "0", iPosition:=4)
        clsRRainday.SetAssignTo("rain_day")

        ' Base
        clsTransformManipulationsFunc.SetRCommand("list")
        clsTransformManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsTransformGroupByFunc, bIncludeArgumentName:=False, iPosition:=0)

        clsRTransform.SetRCommand("instat_calculation$new")
        clsRTransform.SetAssignTo("transform_calculation")
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsRTransform.AddParameter("result_name", Chr(34) & "moving_sum" & Chr(34), iPosition:=3)
        clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=4)
        clsRTransform.AddParameter("save", 2, iPosition:=4)

        clsRollFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRollFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsRollFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso ucrSaveSpells.IsComplete AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrInputSpellLower.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso ucrInputSpellUpper.Text <> "" Then ' and ucrInput is empty
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
        clsRTransform.SetAssignTo("transform_calculation")
        clsWaterBalance60.SetAssignTo("water_balance_60")
        clsRRainday.SetAssignTo("rain_day")
        SetGroupByFuncCalcFrom()
        clsRTransform.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34), iPosition:=2)
        clsRollFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
    End Sub

    Private Sub SumOver()
        If Not ucrReceiverRainfall.IsEmpty Then
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        End If
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
        clsRTransform.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=0)
    End Sub

    Private Sub SetGroupByFuncCalcFrom()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""
        strCurrDataName = Chr(34) & ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        If Not ucrReceiverStation.IsEmpty Then
            clsTransformGroupByFunc.SetAssignTo("grouping")
            clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=4)

            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        Else
            clsRTransform.RemoveParameterByName("manipulations")

        End If
        If strGroupByCalcFrom <> "" Then
            clsTransformGroupByFunc.AddParameter("calculated_from", strGroupByCalcFrom, iPosition:=0)
        Else
            clsTransformGroupByFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        SumOver()
        TestOKEnabled()
    End Sub

    Private Sub ucrSpellBetween_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputSpellUpper.ControlContentsChanged, ucrInputSpellLower.ControlContentsChanged
        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverRainfall.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverRainfall.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0, 1)" & Chr(34), iPosition:=2)
        clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, iPosition:=0)
        clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=7)
        clsRTransform.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34), iPosition:=2)
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class


'Public Class dlgSpells
'    Private clsAddKey, clsDayFromAndTo, clsAdditionalCondition, clsRainyDays, clsMaxValue, clsYearGroupDaily, clsMaxValueManipulation As New RFunction
'    Private clsMaxValueList, clsSpellLength, clsSubSpellLength1, clsSubSpellLength2, clsAdditionalConditionList As New RFunction
'    Private strCurrDataName As String = ""
'    Private bFirstLoad As Boolean = True


'    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForSpells.DataFrameChanged
'        strCurrDataName = Chr(34) & ucrSelectorForSpells.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
'        clsAddKey.AddParameter("data_name", strCurrDataName)
'        firstDayofTheYear()
'    End Sub



'    Private Sub SetDefaults()
'        ucrSelectorForSpells.Reset()
'        ucrSaveSpells.Reset()

'        TestOKEnabled()

'        chkConditionRain.Checked = False
'        nudFrom.Value = 1
'        nudTo.Value = 366
'        nudConditionLeft.Value = 0
'        nudConditionLeft.Maximum = Integer.MaxValue
'        NudConditionRight.Maximum = Integer.MaxValue
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
'        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDayOfYear.GetVariableNames(False) & ">=" & nudFrom.Value & " & " & ucrReceiverDayOfYear.GetVariableNames(False) & "<=" & nudTo.Value & Chr(34))
'        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDayOfYear.GetVariableNames() & ")")
'        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
'    End Sub

'    Private Sub RainyDaysMethod()

'        clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34))
'        Select Case ucrInputCondition.GetText
'            Case "<= Amount of Rain"
'                clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudConditionLeft.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
'            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
'                clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudConditionLeft.Value & "&" & ucrReceiverRainfall.GetVariableNames(False) & "<=" & NudConditionRight.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
'            Case Else
'                clsRainyDays.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverRainfall.GetVariableNames(False) & "<=" & nudConditionLeft.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
'        End Select
'        clsRainyDays.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34))
'        clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames(True) & ")")
'        clsRainyDays.AddParameter("save", 0)

'        If chkConditionRain.Checked Then
'            clsSpellLength.RemoveParameterByName("function_exp")
'            clsSpellLength.RemoveParameterByName("sub_calculations")
'            clsSubSpellLength1.RemoveParameterByName("sub1")

'            clsAdditionalCondition.AddParameter("type", Chr(34) & "calculation" & Chr(34))
'            clsAdditionalCondition.AddParameter("function_exp", Chr(34) & "replace(rain_day, " & (nudFrom.Value - 1) & ", 0)" & Chr(34))
'            clsAdditionalCondition.AddParameter("result_name", Chr(34) & "rain_day2" & Chr(34))
'            clsAdditionalCondition.AddParameter("sub_calculation", clsRFunctionParameter:=clsAdditionalConditionList)
'            clsAdditionalConditionList.SetRCommand("list")
'            clsAdditionalConditionList.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays)
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
'            clsSubSpellLength1.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
'        End If
'        clsSpellLength.AddParameter("type", Chr(34) & "calculation" & Chr(34))
'        clsSpellLength.AddParameter("result_name", Chr(34) & "Dry_Spell" & Chr(34))
'        clsSpellLength.AddParameter("save", 0)
'    End Sub

'    Private Sub ucrInputCondition_NameChanged() Handles ucrInputCondition.NameChanged
'        DisplayForConditions()
'        RainyDaysMethod()
'    End Sub

'    Private Sub MaxValue()
'        clsMaxValueManipulation.SetRCommand("list")
'        clsMaxValueManipulation.AddParameter("sub2", clsRFunctionParameter:=clsYearGroupDaily, bIncludeArgumentName:=False)
'        clsMaxValueManipulation.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)

'        clsMaxValue.AddParameter("type", Chr(34) & "summary" & Chr(34))
'        clsMaxValue.AddParameter("function_exp", Chr(34) & "max(Dry_Spell)" & Chr(34))
'        clsMaxValue.AddParameter("manipulations", clsRFunctionParameter:=clsMaxValueManipulation)
'        clsMaxValue.AddParameter("sub_calculations", clsRFunctionParameter:=clsMaxValueList)
'        clsMaxValueList.AddParameter("sub1", clsRFunctionParameter:=clsSpellLength, bIncludeArgumentName:=False)
'        clsMaxValue.AddParameter("result_name", Chr(34) & ucrSaveSpells.GetText() & Chr(34))
'        clsMaxValue.AddParameter("save", 2)
'    End Sub

'    Private Sub firstDayofTheYear()
'        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsMaxValue)
'    End Sub

'    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
'        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining Date column as key")

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

'    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
'        clsYearGroupDaily.AddParameter("type", Chr(34) & "by" & Chr(34))
'        clsYearGroupDaily.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
'        TestOKEnabled()
'    End Sub

'    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
'        If Not ucrReceiverDate.IsEmpty Then
'            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
'        Else
'            clsAddKey.RemoveParameterByName("col_name")
'        End If
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
'        clsMaxValue.SetAssignTo(ucrSaveSpells.ucrInputTextSave.GetText)
'        MaxValue()
'    End Sub
'End Class