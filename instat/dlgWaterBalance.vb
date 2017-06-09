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

Imports instat
Imports instat.Translations
Public Class dlgWaterBalance
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Public clsEndRainsGroupByFunc, clsWaterBalGroupByFunc, clsWaterEndRainsBase, clsEndOfRainsManipulationsFunc, clsREndofRains, clsWaterBalBase, clsWaterBalManipulationsFunc, clssGroupByFunc, clsAddKey, clsYearGroup, clsDayFromAndTo, clsFirstWaterBalanceYear As New RFunction
    Public clsWaterBalanceList, clsWaterBalanceCalc, clsSubCalcList, clsReplaceNA, clsFirstWaterBalance0List, clsWaterFilter0List, clsReplaceNA0, clsWaterBalance0List, clsWaterBalance0, clsWaterFilter0, clsFirstWaterBalance0 As New RFunction
    Private strCurrDataName As String = ""

    Private Sub dlgWaterBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    'Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForWaterBalance.DataFrameChanged
    '    strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
    '    clsAddKey.AddParameter("data_name", strCurrDataName)
    '    FirstDayofTheYear()
    'End Sub

    Private Sub InitialiseDialog()
        ucrReceiverStation.Selector = ucrSelectorForWaterBalance
        ucrReceiverRainfall.Selector = ucrSelectorForWaterBalance
        ucrReceiverYear.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.Selector = ucrSelectorForWaterBalance
        ucrReceiverDOY.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True
        ucrReceiverStation.bAutoFill = True

        clsREndofRains.SetRCommand("instat_calculation$new")
        clsREndofRains.SetAssignTo("end_of_rains_calculation")
        ucrPnlEndofRains.AddRadioButton(rdoRain)
        ucrPnlEndofRains.AddRadioButton(rdoWaterBalance)
        ucrPnlEndofRains.AddRadioButton(rdoBoth)

        ucrNudCapacity.SetParameter(New RParameter("capacity"))
        ucrNudCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudCapacity.Increment = 1
        ucrNudCapacity.SetLinkedDisplayControl(lblCapacity)

        ucrInputEvaporation.SetParameter(New RParameter("evaporation"))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.SetLinkedDisplayControl(lblEvaporation)

        ucrInputColName.SetParameter(New RParameter("result_name"))
        ucrInputColName.SetName("water_bal")

        ucrNudCapacity.Maximum = Integer.MaxValue
        ucrNudCapacity.Increment = 10

        ucrNudTo.SetMinMax(2, 366)
        ucrNudFrom.SetMinMax(1, 366)

        ucrNudWBLessThan.SetMinMax(1, Integer.MaxValue)
        ucrNudWBLessThan.Increment = 10

        ucrInputEvaporation.SetValidationTypeAsNumeric()

        'ucrPnlEndofRains.AddToLinkedControls({ucrNudTotalOverDays, ucrNudAmount}, {rdoRain}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlEndofRains.AddToLinkedControls({ucrInputEvaporation, ucrNudWBLessThan, ucrNudCapacity}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsWaterBalGroupByFunc = New RFunction
        clsWaterBalManipulationsFunc = New RFunction
        clsEndOfRainsManipulationsFunc = New RFunction
        clsWaterBalBase = New RFunction
        ucrSelectorForWaterBalance.Reset()

        rdoRain.Checked = True ' this needs to be fixed well

        ucrNudFrom.Value = 1
        ucrNudTo.Value = 366
        ucrNudCapacity.Value = 60
        ucrNudWBLessThan.Value = 40
        ucrInputEvaporation.SetName("5")
        ucrNudTotalOverDays.Value = 1
        ucrNudAmount.Value = 0

        clsDayFromAndTo = New RFunction
        clsYearGroup = New RFunction
        clsWaterBalanceCalc = New RFunction
        clsFirstWaterBalanceYear = New RFunction
        clsWaterBalanceList = New RFunction
        clsReplaceNA0 = New RFunction

        clsWaterBalanceCalc = New RFunction
        clsWaterFilter0 = New RFunction
        clsWaterBalance0 = New RFunction
        clsFirstWaterBalance0 = New RFunction

        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & ucrNudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & ucrNudTo.Value & Chr(34))
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsDayFromAndTo.SetAssignTo("Day_From_and_To")

        clsYearGroup.SetRCommand("instat_calculation$new")
        clsYearGroup.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroup.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
        clsYearGroup.SetAssignTo("Year_Group_Daily")

        clsWaterBalanceCalc.SetRCommand("instat_calculation$new")
        clsWaterBalanceCalc.SetAssignTo("Water_Balance_Calc")
        clsFirstWaterBalanceYear.SetRCommand("instat_calculation$new")
        clsFirstWaterBalanceYear.SetAssignTo("First_Water_Balance")

        clsReplaceNA0.SetRCommand("instat_calculation$new")
        clsReplaceNA0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA0.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & "), 0)" & Chr(34))
        clsReplaceNA0.AddParameter("result_name", Chr(34) & "Replace_NA_0" & Chr(34))
        clsReplaceNA0.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        clsReplaceNA0.AddParameter("save", "0")
        clsReplaceNA0.SetAssignTo("Replace_NA_0")

        clsWaterBalance0.SetRCommand("instat_calculation$new")
        clsWaterBalance0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_0, accumulate=TRUE)" & Chr(34))
        clsWaterBalance0.AddParameter("result_name", Chr(34) & "Water_Balance_0" & Chr(34))
        clsWaterBalance0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance0List)
        clsWaterBalance0.AddParameter("save", "0")
        clsWaterBalance0.SetAssignTo("Water_Balance_0")

        clsWaterFilter0.SetRCommand("instat_calculation$new")
        clsWaterFilter0.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsWaterFilter0.AddParameter("function_exp", Chr(34) & "Water_Balance_0 == 0" & Chr(34))
        clsWaterFilter0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterFilter0List)
        clsWaterFilter0.SetAssignTo("Water_Filter_0")

        clsFirstWaterBalance0.SetRCommand("instat_calculation$new")
        clsFirstWaterBalance0.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsFirstWaterBalance0.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        clsFirstWaterBalance0.AddParameter("result_name", Chr(34) & "First_Water_Balance_0" & Chr(34))
        clsFirstWaterBalance0.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsFirstWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsFirstWaterBalance0List)
        clsFirstWaterBalance0.AddParameter("save", "2")
        clsFirstWaterBalance0.SetAssignTo("First_Water_Balance_0")

        clsWaterBalance0List.SetRCommand("list")
        clsWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA0)

        clsWaterFilter0List.SetRCommand("list")
        clsWaterFilter0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterBalance0)

        clsFirstWaterBalance0List.SetRCommand("list")
        clsFirstWaterBalance0List.AddParameter("sub2", clsRFunctionParameter:=clsYearGroup, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterFilter0, bIncludeArgumentName:=False)

        clsWaterBalManipulationsFunc.SetRCommand("list")
        clsWaterBalManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsWaterBalGroupByFunc, bIncludeArgumentName:=False)

        clsEndOfRainsManipulationsFunc.SetRCommand("list")
        clsEndOfRainsManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsEndRainsGroupByFunc, bIncludeArgumentName:=False)


        clsWaterBalGroupByFunc.SetRCommand("instat_calculation$new")
        clsWaterBalGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsWaterBalGroupByFunc.SetAssignTo("grouping")

        clsSubCalcList.SetRCommand("list")
        clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA)

        clsREndofRains.AddParameter("function_exp", Chr(34) & "min(water_bal)")
        clsREndofRains.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsREndofRains.AddParameter("result_name", Chr(34) & "end_rains" & Chr(34))
        clsREndofRains.AddParameter("manipulations", clsRFunctionParameter:=clsWaterBalManipulationsFunc)
        clsREndofRains.AddParameter("save", 2)

        clsWaterBalBase.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsWaterBalBase.AddParameter("display", "FALSE")
        clsWaterBalBase.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance0)

        clsWaterEndRainsBase.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsWaterEndRainsBase.AddParameter("display", "FALSE")
        clsWaterEndRainsBase.AddParameter("calc", clsRFunctionParameter:=clsFirstWaterBalance0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'ucrPnlTransform.SetRCode(clsMatchFun, bReset)
        'ucrNudSumOver.SetRCode(clsRRollFuncExpr, bReset)
        'ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        'ucrInputSum.SetRCode(clsMatchFun, bReset)
        'ucrInputColName.SetRCode(clsRWater_bal, bReset)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then ' AndAlso ucrNudCapacity.Text <> "" AndAlso ucrNudFrom.Text <> "" AndAlso ucrNudTo.Text <> "" AndAlso Not ucrInputEvaporation.IsEmpty AndAlso ucrNudWBLessThan.Text <> "" AndAlso ucrInputColName.GetText <> "" Then
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

    Private Sub nudValues()
        ucrNudFrom.Maximum = ucrNudTo.Value - 1
        ucrNudTo.Minimum = ucrNudFrom.Value + 1
    End Sub

    Private Sub AddKeyMethod()
        If Not ucrReceiverDate.IsEmpty Then
            clsAddKey.AddParameter("col_name", ucrReceiverDate.GetVariableNames)
        Else
            clsAddKey.RemoveParameterByName("col_name")
        End If
    End Sub

    Private Sub DayFromAndToMethod()
        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & ">=" & ucrNudFrom.Value & " & " & ucrReceiverDOY.GetVariableNames(False) & "<=" & ucrNudTo.Value & Chr(34))
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34))
    End Sub

    Private Sub WaterBalance()
        clsReplaceNA0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA0.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & "), 0)" & Chr(34))
        clsReplaceNA0.AddParameter("result_name", Chr(34) & "Replace_NA_0" & Chr(34))
        clsReplaceNA0.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        clsReplaceNA0.AddParameter("save", "0")

        clsWaterBalance0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_0, accumulate=TRUE)" & Chr(34))
        clsWaterBalance0.AddParameter("result_name", Chr(34) & "Water_Balance_0" & Chr(34))
        clsWaterBalance0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance0List)
        clsWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA0)
        clsWaterBalance0.AddParameter("save", "0")

        clsWaterFilter0.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsWaterFilter0.AddParameter("function_exp", Chr(34) & "Water_Balance_0 == 0" & Chr(34))
        clsWaterFilter0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterFilter0List)
        clsWaterFilter0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterBalance0)

        clsFirstWaterBalance0.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsFirstWaterBalance0.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        clsFirstWaterBalance0.AddParameter("result_name", Chr(34) & "First_Water_Balance_0" & Chr(34))
        clsFirstWaterBalance0.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsFirstWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsFirstWaterBalance0List)
        clsFirstWaterBalance0.AddParameter("save", "2")
        clsFirstWaterBalance0List.AddParameter("sub2", clsRFunctionParameter:=clsYearGroup, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsFirstWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterFilter0, bIncludeArgumentName:=False)
    End Sub

    Private Sub YearGroupDaily()
        clsYearGroup.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsYearGroup.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
    End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        YearGroupDaily()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDOY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDOY.SelectionChanged
        DayFromAndToMethod()
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveWaterBalance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputColName.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged ', ucrNudCapacity.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrNudWBLessThan.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlEndofRains_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlEndofRains.ControlContentsChanged
        PanelOptions()
    End Sub

    Private Sub PanelOptions()
        If rdoRain.Checked Then
            clsWaterBalance0.AddParameter("save", "0")
            clsWaterEndRainsBase.AddParameter("calc", clsRFunctionParameter:=clsFirstWaterBalance0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
        ElseIf rdoWaterBalance.Checked Then
            clsWaterBalance0.AddParameter("save", "2")
            clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & ")," & ucrNudCapacity.Value & ")" & Chr(34))
            clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA)
            clsWaterBalBase.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterBalBase)
        ElseIf rdoBoth.Checked Then
            clsWaterBalance0.AddParameter("save", "2")
            clsWaterBalance0.SetAssignTo("Water_Balance_0")
            clsWaterEndRainsBase.AddParameter("calc", clsRFunctionParameter:=clsFirstWaterBalance0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
        End If
    End Sub

    Private Sub SetGroupByFuncCalcFrom()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""

        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        If Not ucrReceiverStation.IsEmpty Then
            clsWaterBalGroupByFunc.SetAssignTo("grouping")
            clsWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsWaterBalManipulationsFunc)
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        Else
            clsWaterBalance0.RemoveParameterByName("manipulations")
        End If
        If strGroupByCalcFrom <> "" Then
            clsWaterBalGroupByFunc.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsWaterBalGroupByFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        DayFromAndToMethod()
        WaterBalance()
        clsReplaceNA.SetAssignTo("replace_NA")
        clsReplaceNA0.SetAssignTo("Replace_NA_0")
        clsWaterBalance0.SetAssignTo("Water_Balance_0")
        clsWaterFilter0.SetAssignTo("Water_Filter_0")
        clsFirstWaterBalance0.SetAssignTo("First_Water_Balance_0")
        SetGroupByFuncCalcFrom()
        PanelOptions()

    End Sub

    Private Sub ucrWBControls_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrNudCapacity.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged
        clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudCapacity.Value & "), replace_NA, accumulate=TRUE)" & Chr(34))
    End Sub

    Private Sub ucrSelectorForWaterBalance_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorForWaterBalance.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & ")," & ucrNudCapacity.Value & ")" & Chr(34))
        clsWaterBalance0.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        clsReplaceNA.AddParameter("calculated_from", " list(" & strCurrDataName & "= " & ucrReceiverRainfall.GetVariableNames() & ")")
    End Sub

    Private Sub ucrNudFromTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudFrom.ControlValueChanged, ucrNudTo.ControlValueChanged
        nudValues()
    End Sub
End Class