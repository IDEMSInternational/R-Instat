﻿' Instat-R
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
Public Class dlgWaterBalance
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsAddKey, clsAddKeyColName, clsGroupBy, clsDayFromAndTo As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator As New ROperator
    '60
    Private clsWBReplaceNAMax, clsWBReplaceNAMaxFunction, clsWBReplaceNAMaxFunctionList, clsWBWaterBalanceMax, clsWBWaterFilterMax, clsWBWaterFilterMaxList, clsWBFirstWaterBalanceMax, clsWBFirstWaterBalanceManipulationMax As RFunction
    Private clsWBWaterFilterMaxOperator, clsWBFirstWaterBalanceMaxOperator As New ROperator
    '0
    Private clsWBReplaceNAMinFunction, clsWBReplaceNAMinFunctionList As New RFunction
    Private clsWBWaterFilterMinOperator, clsWBFirstWaterBalanceMinOperator As New ROperator


    Private clsWaterBalManipulationsFunc, clsWaterEndRainsBase, clsWaterBalBase, clsFirstWaterBalanceYear, clsWaterBalanceList, clsWaterBalanceCalc, clsWaterBalance As New RFunction
    Public clsDifference, clsDifferenceList, clsFirstWaterBalance60List, clsWBFirstWaterBalanceMinList, clsWBWaterFilterMinList, clsWBReplaceNAMin, clsWaterBalance60List, clsWBWaterBalanceMinList, clsWBWaterBalanceMin, clsWBWaterFilterMin, clsWBFirstWaterBalanceMin As New RFunction
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

    Private Sub InitialiseDialog()
        rdoBoth.Enabled = False ' temp
        rdoRain.Enabled = False ' temp

        ucrSelectorForWaterBalance.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForWaterBalance.SetParameterIsString()

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForWaterBalance
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date", 0))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForWaterBalance
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True

        ucrReceiverRainfall.SetParameter(New RParameter("x", 0))
        ucrReceiverRainfall.SetParameterIsRFunction()
        ucrReceiverRainfall.bWithQuotes = False
        '        ucrReceiverRainfall.SetParameterIncludeArgumentName(False)
        ucrReceiverRainfall.Selector = ucrSelectorForWaterBalance
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True


        'WATER BALANCE
        ucrNudWBLessThan.SetParameter(New RParameter("rightMax", 1))
        ucrNudWBLessThan.SetMinMax(1, Integer.MaxValue)
        ucrNudWBLessThan.Increment = 10




        ucrReceiverRainfall.Selector = ucrSelectorForWaterBalance
        ucrReceiverYear.Selector = ucrSelectorForWaterBalance
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True


        clsWaterBalance.SetRCommand("instat_calculation$new")
        clsWaterBalance.SetAssignTo("Water_Balance")
        clsWaterBalanceCalc.SetRCommand("instat_calculation$new")
        clsWaterBalanceCalc.SetAssignTo("Water_Balance_Calc")
        clsFirstWaterBalanceYear.SetRCommand("instat_calculation$new")
        clsFirstWaterBalanceYear.SetAssignTo("First_Water_Balance")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")
        clsWaterBalanceList.SetRCommand("list")

        clsWBReplaceNAMin.SetRCommand("instat_calculation$new")
        clsWBWaterBalanceMin.SetRCommand("instat_calculation$new")
        clsWBWaterFilterMin.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMin.SetRCommand("instat_calculation$new")

        clsDifferenceList.SetRCommand("list")
        clsDifference.SetRCommand("instat_calculation$new")

        ' for clarity when it runs
        clsWBReplaceNAMax.SetAssignTo("Replace_NA_Max")
        clsWBReplaceNAMin.SetAssignTo("Replace_NA_Min")
        clsWBWaterBalanceMax.SetAssignTo("Water_Balance_Max")
        clsWBWaterBalanceMin.SetAssignTo("Water_Balance_Min")
        clsWBWaterFilterMax.SetAssignTo("Water_Filter_60")
        clsWBWaterFilterMin.SetAssignTo("Water_Filter_0")
        clsWBFirstWaterBalanceMax.SetAssignTo("First_Water_Balance_Max")
        clsWBFirstWaterBalanceMin.SetAssignTo("First_Water_Balance_Min")
        clsDifference.SetAssignTo("Difference")

        clsWaterBalance60List.SetRCommand("list")
        clsWBWaterBalanceMinList.SetRCommand("list")
        clsWBWaterFilterMinList.SetRCommand("list")
        clsFirstWaterBalance60List.SetRCommand("list")
        clsWBFirstWaterBalanceMinList.SetRCommand("list")

        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        clsWaterBalManipulationsFunc.SetRCommand("list")
        clsWaterBalManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False)

        'save
        'clsREndofRains.SetRCommand("instat_calculation$new")
        'clsREndofRains.SetAssignTo("end_of_rains_calculation")
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

        ucrNudCapacity.Maximum = Integer.MaxValue
        ucrNudCapacity.Increment = 10

        ucrNudTo.SetMinMax(2, 366)
        ucrNudFrom.SetMinMax(1, 366)


        ucrInputEvaporation.SetValidationTypeAsNumeric()

        ucrInputEndRainColName.SetParameter(New RParameter("result_name"))
        ucrInputEndRainColName.SetName("End_of_rains")
        ucrInputEndRainColName.SetLinkedDisplayControl(lblEndRainsColName)

        ucrInputWBColName.SetParameter(New RParameter("result_name"))
        ucrInputWBColName.SetName("Water_bal")
        ucrInputWBColName.SetLinkedDisplayControl(lblWBColName)

        'ucrPnlEndofRains.AddToLinkedControls({ucrInputEndRainColName}, {rdoRain}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlEndofRains.AddToLinkedControls({ucrInputWBColName}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlEndofRains.AddToLinkedControls({ucrInputEndRainColName, ucrInputWBColName}, {rdoBoth}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsAddKey = New RFunction
        clsAddKeyColName = New RFunction
        clsGroupBy = New RFunction
        clsDayFromAndTo = New RFunction
        clsDayFromAndToOperator = New ROperator
        clsWBReplaceNAMax = New RFunction
        clsWBReplaceNAMaxFunction = New RFunction
        clsWBReplaceNAMaxFunctionList = New RFunction
        clsWBWaterBalanceMax = New RFunction
        clsWBWaterFilterMax = New RFunction
        clsWBWaterFilterMaxList = New RFunction
        clsWBWaterFilterMaxOperator = New ROperator
        clsWBFirstWaterBalanceMax = New RFunction
        clsWBFirstWaterBalanceManipulationMax = New RFunction
        clsWBFirstWaterBalanceMaxOperator = New ROperator
        clsWBReplaceNAMin = New RFunction
        clsWBWaterBalanceMin = New RFunction
        clsWBWaterBalanceMinList = New RFunction
        clsWBReplaceNAMinFunctionList = New RFunction
        clsWBReplaceNAMinFunction = New RFunction
        clsWBWaterFilterMin = New RFunction
        clsWBWaterFilterMinList = New RFunction
        clsWBFirstWaterBalanceMin = New RFunction
        clsWBFirstWaterBalanceMinList = New RFunction
        clsWBWaterFilterMinOperator = New ROperator
        clsWBFirstWaterBalanceMinOperator = New ROperator

        ucrSelectorForWaterBalance.Reset()
        ucrReceiverDate.SetMeAsReceiver()

        'Add Key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        'group by
        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)

        'Day from and to
        'DayFromandTo
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        'clsDayFromAndTo.AddParameter("function_exp", Chr(34) & clsDayFromAndToOperator.ToScript & Chr(34), iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366)

        ' WATER BALANCE:
        clsWBFirstWaterBalanceManipulationMax.SetRCommand("list")

        ' If Maximum Capacity:
        clsWBReplaceNAMax.SetRCommand("instat_calculation$new")
        clsWBReplaceNAMax.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        'clsWBReplaceNAMax.AddParameter("function_exp", Chr(34) & clsWBReplaceNAMaxFunction.ToScript & Chr(34), iPosition:=1)
        clsWBReplaceNAMaxFunction.SetRCommand("replace")
        clsWBReplaceNAMaxFunction.AddParameter("list", clsRFunctionParameter:=clsWBReplaceNAMaxFunctionList, iPosition:=1)
        clsWBReplaceNAMaxFunctionList.SetRCommand("is.na")
        clsWBReplaceNAMaxFunction.AddParameter("values", 60, iPosition:=2) ' are we replacing wiht 60? Shouldnt we replace with max. capacity amount??
        'Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na( " & ucrReceiverRainfall.GetVariableNames(False) & "), 60)" & Chr(34))
        clsWBReplaceNAMax.AddParameter("result_name", Chr(34) & "Replace_NA_Max" & Chr(34), iPosition:=2)
        clsWBReplaceNAMax.AddParameter("save", "0", iPosition:=3)

        clsWBWaterBalanceMax.SetRCommand("instat_calculation$new")
        clsWBWaterBalanceMax.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWBWaterBalanceMax.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_Max, accumulate=TRUE)" & Chr(34))
        clsWBWaterBalanceMax.AddParameter("result_name", Chr(34) & "Water_Balance_Max" & Chr(34), iPosition:=2)
        clsWBWaterBalanceMax.AddParameter("save", "0", iPosition:=6)
        'TODO: function_exp

        clsWBWaterFilterMax.SetRCommand("instat_calculation$new")
        clsWBWaterFilterMaxList.SetRCommand("list")
        clsWBWaterFilterMax.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        'clsWBWaterFilterMax.AddParameter("function_exp", Chr(34) & clsWBWaterFilterMaxOperator.ToScript & Chr(34), iPosition:=1)
        clsWBWaterFilterMaxOperator.SetOperation("<=")
        clsWBWaterFilterMaxOperator.AddParameter("x", "Water_Balance_Max", iPosition:=0)
        clsWBWaterFilterMaxOperator.AddParameter("rightMax", 40, iPosition:=1)

        clsWBFirstWaterBalanceMax.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMax.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        'clsWBFirstWaterBalanceMax.AddParameter("function_exp", Chr(34) & clsWBFirstWaterBalanceMaxOperator.ToScript & Chr(34))
        clsWBFirstWaterBalanceMaxOperator.SetOperation("[")
        clsWBFirstWaterBalanceMaxOperator.AddParameter("right", "1]", iPosition:=1)
        ' Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34)) ' THIS IS without quotes. Is that as before?
        clsWBFirstWaterBalanceMax.AddParameter("result_name", Chr(34) & "First_Water_Balance_Max" & Chr(34), iPosition:=3)
        clsWBFirstWaterBalanceMax.AddParameter("save", "0", iPosition:=6)

        ' If Minimum Capacity:
        clsWBReplaceNAMin.SetRCommand("instat_calculation$new")
        clsWBReplaceNAMin.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        'clsWBReplaceNAMin.AddParameter("function_exp", Chr(34) & clsWBReplaceNAMaxFunction.ToScript & Chr(34), iPosition:=1)
        clsWBReplaceNAMinFunction.SetRCommand("replace")
        clsWBReplaceNAMinFunction.AddParameter("list", clsRFunctionParameter:=clsWBReplaceNAMinFunctionList, iPosition:=1)
        clsWBReplaceNAMinFunctionList.SetRCommand("is.na")
        clsWBReplaceNAMinFunction.AddParameter("values", 0, iPosition:=2)
        clsWBReplaceNAMin.AddParameter("result_name", Chr(34) & "Replace_NA_Min" & Chr(34), iPosition:=2)
        clsWBReplaceNAMin.AddParameter("save", "0", iPosition:=6)

        clsWBWaterBalanceMin.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWBWaterBalanceMin.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_Min, accumulate=TRUE)" & Chr(34))
        clsWBWaterBalanceMin.AddParameter("result_name", Chr(34) & "Water_Balance_Min" & Chr(34), iPosition:=2)
        clsWBWaterBalanceMin.AddParameter("save", "0", iPosition:=6)

        clsWBWaterFilterMin.SetRCommand("instat_calculation$new")
        clsWBWaterFilterMinList.SetRCommand("list")
        clsWBWaterFilterMin.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        'clsWBWaterFilterMin.AddParameter("function_exp", Chr(34) & clsWBWaterFilterMinOperator.ToScript & Chr(34), iPosition:=1)
        clsWBWaterFilterMinOperator.SetOperation("<=")
        clsWBWaterFilterMinOperator.AddParameter("x", "Water_Balance_Min", iPosition:=0)
        clsWBWaterFilterMinOperator.AddParameter("rightMin", 40, iPosition:=1)
        '"function_exp", Chr(34) & "Water_Balance_Min <= " & ucrNudWBLessThan.Value & Chr(34))

        clsWBFirstWaterBalanceMax.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        'clsWBFirstWaterBalanceMax.AddParameter("function_exp", Chr(34) & clsWBFirstWaterBalanceMaxOperator.ToScript & Chr(34))
        clsWBFirstWaterBalanceMaxOperator.SetOperation("[")
        clsWBFirstWaterBalanceMaxOperator.AddParameter("right", "1]", iPosition:=1)
        ' Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34)) ' THIS IS without quotes. Is that as before?
        clsWBFirstWaterBalanceMax.AddParameter("result_name", Chr(34) & "First_Water_Balance_Max" & Chr(34), iPosition:=3)
        clsWBFirstWaterBalanceMax.AddParameter("save", "0", iPosition:=6)

        clsWBFirstWaterBalanceMin.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMin.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        'clsWBFirstWaterBalanceMax.AddParameter("function_exp", Chr(34) & clsWBFirstWaterBalanceMinOperator.ToScript & Chr(34))
        clsWBFirstWaterBalanceMinOperator.SetOperation("[")
        clsWBFirstWaterBalanceMinOperator.AddParameter("right", "1]", iPosition:=1)
        ' clsWBFirstWaterBalanceMin.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        ' Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34)) ' DOY is without quotes. Is that as before?
        clsWBFirstWaterBalanceMin.AddParameter("result_name", Chr(34) & "First_Water_Balance_Min" & Chr(34), iPosition:=3)
        clsWBFirstWaterBalanceMin.AddParameter("save", "2", iPosition:=6) ' why is this save = 2?





        ucrNudFrom.Value = 1
        ucrNudTo.Value = 366
        ucrNudCapacity.Value = 60
        ucrInputEvaporation.SetName("5")
        ucrNudTotalOverDays.Value = 1
        ucrNudAmount.Value = 0

        WaterBalance()
        clsWaterBalance.AddParameter("result_name", Chr(34) & "Water_bal" & Chr(34))
        'clsWBFirstWaterBalanceMin.AddParameter("result_name", Chr(34) & "First_Water_Balance_Min" & Chr(34))
        clsWaterEndRainsBase.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsWaterEndRainsBase.AddParameter("display", "FALSE")
        clsWaterEndRainsBase.AddParameter("calc", clsRFunctionParameter:=clsWBFirstWaterBalanceMin)

        ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsWBFirstWaterBalanceMaxOperator, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsWBFirstWaterBalanceMinOperator, New RParameter("left", 0), iAdditionalPairNo:=3)
        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        ucrInputEndRainColName.SetRCode(clsWBFirstWaterBalanceMin, bReset)
        ucrInputWBColName.SetRCode(clsWaterBalance, bReset)

        'ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        'ucrInputSum.SetRCode(clsMatchFun, bReset)
        'ucrInputColName.SetRCode(clsRWater_bal, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)
        ucrSelectorForWaterBalance.SetRCode(clsAddKey, bReset)

        ' Water Balance:
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunctionList, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunctionList, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverRainfall.SetRCode(clsWBReplaceNAMaxFunction, bReset)

        ucrNudWBLessThan.AddAdditionalCodeParameterPair(clsWBWaterFilterMinOperator, New RParameter("rightMin", 0), iAdditionalPairNo:=1)
        ucrNudWBLessThan.SetRCode(clsWBWaterFilterMaxOperator, bReset)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then ' AndAlso nudCapacity.Text <> "" AndAlso nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso Not ucrInputEvaporation.IsEmpty AndAlso nudWBLessThan.Text <> "" AndAlso ucrSaveWaterBalance.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        ' does this update if I change the data name?
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDate.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")")
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDate.GetVariableNames & ")")
        End If
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForWaterBalance.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Water Balance: Defining column(s) as key")

        clsDayFromAndTo.SetAssignTo("Day_From_and_To")
        clsGroupBy.SetAssignTo("grouping")

        clsDayFromAndTo.AddParameter("function_exp", Chr(34) & clsDayFromAndToOperator.ToScript & Chr(34), iPosition:=1)

        ''FirstDayofTheYear()
        ''DayFromAndToMethod()

        ''WaterBalance()
        'FirstWaterBalancePerYear()
        'DayFromAndToMethod()
        'WaterBalance()
        'clsReplaceNA.SetAssignTo("replace_NA")
        clsWBReplaceNAMin.SetAssignTo("Replace_NA_Min")
        clsWBWaterBalanceMin.SetAssignTo("Water_Balance_Min")
        clsWBWaterFilterMin.SetAssignTo("Water_Filter_0")
        clsWBFirstWaterBalanceMin.SetAssignTo("First_Water_Balance_Min")
        clsDifference.SetAssignTo("Difference")
        clsWBReplaceNAMax.SetAssignTo("Replace_NA_Max")
        clsWBWaterBalanceMax.SetAssignTo("Water_Balance_Max")
        clsWBWaterFilterMax.SetAssignTo("Water_Filter_60")
        clsWBFirstWaterBalanceMax.SetAssignTo("First_Water_Balance_Max")
        PanelOptions()

        If rdoWaterBalance.Checked Then
            clsWBReplaceNAMax.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=5)
            clsWBReplaceNAMax.AddParameter("function_exp", Chr(34) & clsWBReplaceNAMaxFunction.ToScript & Chr(34), iPosition:=1)
            clsWBWaterBalanceMax.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance60List, iPosition:=5)
            clsWaterBalance60List.AddParameter("sub1", clsRFunctionParameter:=clsWBReplaceNAMax, iPosition:=0)
            clsWBWaterFilterMax.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterFilterMaxList, iPosition:=2)
            clsWBWaterFilterMaxList.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterBalanceMax)
            clsWBFirstWaterBalanceManipulationMax.AddParameter("sub2", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False)
            clsWBFirstWaterBalanceManipulationMax.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
            clsWBFirstWaterBalanceManipulationMax.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterFilterMax, bIncludeArgumentName:=False)
            clsWBWaterFilterMax.AddParameter("function_exp", Chr(34) & clsWBWaterFilterMaxOperator.ToScript & Chr(34), iPosition:=1)
            clsWBFirstWaterBalanceMax.AddParameter("function_exp", Chr(34) & clsWBFirstWaterBalanceMaxOperator.ToScript & Chr(34))
            clsWBFirstWaterBalanceMax.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=4)
            clsWBFirstWaterBalanceMax.AddParameter("manipulations", clsRFunctionParameter:=clsWBFirstWaterBalanceManipulationMax, iPosition:=5)
            clsWBReplaceNAMin.AddParameter("function_exp", Chr(34) & clsWBReplaceNAMinFunction.ToScript & Chr(34), iPosition:=1)
            clsWBReplaceNAMin.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
            clsWBWaterBalanceMin.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterBalanceMinList)
            clsWBWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBReplaceNAMin)
            clsWBWaterFilterMin.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterFilterMinList)
            clsWBWaterFilterMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterBalanceMin)
            clsWBFirstWaterBalanceMinList.AddParameter("sub2", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False)
            clsWBFirstWaterBalanceMinList.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
            clsWBFirstWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterFilterMin, bIncludeArgumentName:=False)
            clsWBFirstWaterBalanceMin.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=4)
            clsWBFirstWaterBalanceMin.AddParameter("manipulations", clsRFunctionParameter:=clsWBFirstWaterBalanceMinList, iPosition:=5)
            clsWBFirstWaterBalanceMax.AddParameter("function_exp", Chr(34) & clsWBFirstWaterBalanceMinOperator.ToScript & Chr(34))
        End If
    End Sub

    Private Sub DayBoundaries()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayBoundaries()
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        clsWBFirstWaterBalanceMinList.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
    End Sub





















    Private Sub nudValues()
        'ucrNudFrom.Maximum = ucrNudTo.Value - 1
        'ucrNudTo.Minimum = ucrNudFrom.Value + 1
    End Sub



    Private Sub WaterBalance()

        'clsReplaceNA0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        'clsReplaceNA0.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & "), 0)" & Chr(34))
        'clsReplaceNA0.AddParameter("result_name", Chr(34) & "Replace_NA_Min" & Chr(34))
        'clsReplaceNA0.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")")
        'clsReplaceNA0.AddParameter("save", "0")

        'clsWaterBalance0.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        'clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_Min, accumulate=TRUE)" & Chr(34))
        'clsWaterBalance0.AddParameter("result_name", Chr(34) & "Water_Balance_Min" & Chr(34))
        'clsWaterBalance0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance0List)
        'clsWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA0)
        'clsWaterBalance0.AddParameter("save", "0")

        'clsWaterFilter0.AddParameter("type", Chr(34) & "filter" & Chr(34))
        'clsWaterFilter0.AddParameter("function_exp", Chr(34) & "Water_Balance_Min <= " & ucrNudWBLessThan.Value & Chr(34))
        'clsWaterFilter0.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterFilter0List)
        'clsWaterFilter0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterBalance0)

        'clsFirstWaterBalance0.AddParameter("type", Chr(34) & "summary" & Chr(34))
        'clsFirstWaterBalance0.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[" & 1 & "]" & Chr(34))
        'clsFirstWaterBalance0.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        'clsFirstWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsFirstWaterBalance0List)
        'clsFirstWaterBalance0.AddParameter("save", "2")
        'clsFirstWaterBalance0List.AddParameter("sub2", clsRFunctionParameter:=clsYearGroup, bIncludeArgumentName:=False)
        'clsFirstWaterBalance0List.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False)
        'clsFirstWaterBalance0List.AddParameter("sub1", clsRFunctionParameter:=clsWaterFilter0, bIncludeArgumentName:=False)

    End Sub

    Private Sub FirstWaterBalancePerYear() ' error occurs when clsDifference runs
        clsDifference.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDifference.AddParameter("function_exp", Chr(34) & ucrInputEndRainColName.GetText() & " - First_Water_Balance_Max" & Chr(34))
        clsDifference.AddParameter("result_name", Chr(34) & "Difference" & Chr(34))
        clsDifference.AddParameter("sub_calculations", clsRFunctionParameter:=clsDifferenceList)
        clsDifferenceList.AddParameter("sub1", clsRFunctionParameter:=clsWBFirstWaterBalanceMin)
        clsDifferenceList.AddParameter("sub2", clsRFunctionParameter:=clsWBFirstWaterBalanceMax)
        clsDifference.AddParameter("save", "0")
        ' try it in the other sub? Or sub on it's own?

        clsWaterBalance.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsWaterBalance.AddParameter("function_exp", Chr(34) & "replace(" & ucrInputEndRainColName.GetText() & ", Difference != 0, NA)" & Chr(34))
        'clsWaterBalance.AddParameter("result_name", Chr(34) & ucrSaveWaterBalance.GetText() & Chr(34))
        clsWaterBalance.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalanceList)
        clsWaterBalanceList.AddParameter("sub1", clsRFunctionParameter:=clsWBFirstWaterBalanceMin)
        clsWaterBalanceList.AddParameter("sub2", clsRFunctionParameter:=clsDifference)
        clsWaterBalance.AddParameter("save", "2")
    End Sub

    'Private Sub YearGroupDaily()
    '    clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34))
    '    clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
    'End Sub

    Private Sub FirstDayofTheYear()
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance)
    End Sub

    'Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
    '    frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Water Balance: Defining Date column as key")

    '    FirstDayofTheYear()
    '    DayFromAndToMethod()
    '    WaterBalance()
    '    FirstWaterBalancePerYear()
    'End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDOY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDOY.SelectionChanged
        FirstWaterBalancePerYear()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub nudCapacity_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudCapacity.ControlContentsChanged
        'clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_Min, accumulate=TRUE)" & Chr(34))
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub nudWBLessThan_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudWBLessThan.ControlContentsChanged
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub DayFromAndTo_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged
        nudValues()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputEvaporation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputEvaporation.ControlContentsChanged
        'clsWaterBalance0.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_Min, accumulate=TRUE)" & Chr(34))
        WaterBalance()
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveWaterBalance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputWBColName.ControlValueChanged
        'clsWaterBalance.SetAssignTo(ucrInputWBColName.ucrInputTextSave.GetText)
        FirstWaterBalancePerYear()
    End Sub

    Private Sub ucrSaveWaterBalance_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputWBColName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlEndofRains_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlEndofRains.ControlContentsChanged
        PanelOptions()
    End Sub

    Private Sub PanelOptions()
        If rdoRain.Checked Then
            clsWBFirstWaterBalanceMin.AddParameter("save", "2")
            clsWBFirstWaterBalanceMin.SetAssignTo("First_Water_Balance_Min")
            clsWaterEndRainsBase.AddParameter("calc", clsRFunctionParameter:=clsWBFirstWaterBalanceMin)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
        ElseIf rdoWaterBalance.Checked Then
            'clsWaterBalance0.AddParameter("save", "2")
            'clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & ")," & ucrNudCapacity.Value & ")" & Chr(34))
            'clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA)
            'clsWaterBalBase.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance0)
            'ucrBase.clsRsyntax.SetBaseRFunction(clsWaterBalBase)
            clsWaterBalance.AddParameter("save", "2")
            clsWBFirstWaterBalanceMin.AddParameter("save", "0")
            clsWBFirstWaterBalanceMin.SetAssignTo("First_Water_Balance_Min")
            clsWaterBalance.SetAssignTo("Water_Balance")
            'clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na(" & ucrReceiverRainfall.GetVariableNames(False) & ")," & ucrNudCapacity.Value & ")" & Chr(34))
            'clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA)
            clsWaterBalBase.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
        ElseIf rdoBoth.Checked Then
            clsWaterBalance.AddParameter("save", "2")
            clsWBFirstWaterBalanceMin.AddParameter("save", "2")

            clsWBFirstWaterBalanceMin.SetAssignTo("First_Water_Balance_Min")
            clsWaterBalance.SetAssignTo("Water_Balance")
            clsWaterEndRainsBase.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterEndRainsBase)
        End If
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForWaterBalance.DataFrameChanged
        FirstDayofTheYear()
    End Sub

    'Private Sub SetGroupByFuncCalcFrom()
    '    Dim strCurrDataName As String = ""
    '    Dim strGroupByCalcFrom As String = ""

    '    strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

    '    If Not ucrReceiverStation.IsEmpty Then
    '        clsWaterBalance0.AddParameter("manipulations", clsRFunctionParameter:=clsWaterBalManipulationsFunc)
    '        strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
    '    Else
    '        clsWaterBalance0.RemoveParameterByName("manipulations")
    '    End If
    '    If strGroupByCalcFrom <> "" Then
    '    Else
    '        clsGroupBy.RemoveParameterByName("calculated_from")
    '    End If
    'End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
    End Sub

End Class