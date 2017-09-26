﻿' R- Instat
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
Public Class dlgEndOfRainsSeason
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsAddKey, clsAddKeyColName, clsGroupBy, clsDayFromAndTo As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsWaterBalanceOperator, clsDifferenceOperation As New ROperator
    '60
    Private clsWBReplaceNAMax, clsWBReplaceNAMaxFunction, clsWBReplaceNAMaxFunctionList, clsWBWaterBalanceMax, clsWBWaterFilterMax, clsWBWaterFilterMaxList, clsWBFirstWaterBalanceMax, clsWBFirstWaterBalanceManipulationMax, clsWaterBalanceMaxList, clsReduceFunctionMax, clsPMinFunctionMax, clsPMaxFunctionMax As New RFunction
    Private clsWBWaterFilterMaxOperator, clsWBFirstWaterBalanceMaxOperator, clsPMaxOperatorMax As New ROperator
    '0
    Private clsWBReplaceNAMin, clsWBReplaceNAMinFunction, clsWBReplaceNAMinFunctionList, clsWBWaterBalanceMin, clsWBWaterFilterMin, clsWBWaterFilterMinList, clsWBFirstWaterBalanceMin, clsWBFirstWaterBalanceMinList, clsWBWaterBalanceMinList, clsReduceFunctionMin, clsPMinFunctionMin, clsPMaxFunctionMin As New RFunction
    Private clsWBWaterFilterMinOperator, clsWBFirstWaterBalanceMinOperator, clsPMaxOperatorMin As New ROperator

    Private clsCombinationBase, clsEndRainBase, clsCombinationBaseList, clsWaterBalanceList, clsWaterBalanceFunction, clsWaterBalance As New RFunction
    Private clsDifference, clsDifferenceList As New RFunction

    'EoR
    Private clsEndRainFilter, clsEndRainLastInstance, clsEndRainLastInstanceFunction, clsEndRainLastInstanceList, clsEndRainFilterList, clsEndRainRollingSum, clsRollingSumFunction, clsEndRainLastInstanceManipulationList As New RFunction
    Private clsEndRainFilterOperator, clsEndRainLastInstanceOperator, clsEndRainLastInstanceOperator2 As New ROperator

    Private strCurrDataName As String = ""

    Private Sub dlgWaterBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrSelectorForWaterBalance.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForWaterBalance.SetParameterIsString()

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForWaterBalance
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("date", 0))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForWaterBalance
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverRainfall.SetParameter(New RParameter("x", 0))
        ucrReceiverRainfall.SetParameterIsRFunction()
        ucrReceiverRainfall.bWithQuotes = False
        ucrReceiverRainfall.Selector = ucrSelectorForWaterBalance
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverRainfall.strSelectorHeading = "Rain Variables"

        ucrReceiverYear.Selector = ucrSelectorForWaterBalance
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Days
        ucrNudFrom.SetParameter(New RParameter("from", 1))
        ucrNudFrom.SetMinMax(1, 366)

        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudTo.SetMinMax(2, 366)

        'WATER BALANCE
        ucrChkEndOfSeason.SetText("End of Season")
        ucrChkEndOfSeason.SetParameter(New RParameter("sub_water_balance", clsWaterBalance, 0), False)

        ucrChkEndOfSeason.AddToLinkedControls(ucrNudCapacity, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=60)
        ucrChkEndOfSeason.AddToLinkedControls(ucrNudWBLessThan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrChkEndOfSeason.AddToLinkedControls(ucrChkEvaporationAsReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)
        ucrChkEndOfSeason.AddToLinkedControls(ucrInputWBColName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_season")

        ucrChkEvaporationAsReceiver.SetText("Evaporation As Receiver")
        ucrChkEvaporationAsReceiver.Enabled = False ' Temporary while receiver isn't set up for End of Season
        ucrChkEvaporationAsReceiver.AddToLinkedControls(ucrReceiverEvaporation, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)
        ucrChkEvaporationAsReceiver.AddToLinkedControls(ucrInputEvaporation, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrChkEvaporationAsReceiver.SetLinkedDisplayControl(lblEvaporation)

        ucrInputEvaporation.SetParameter(New RParameter("evaporation", 1, False))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False

        ucrNudWBLessThan.SetParameter(New RParameter("rightMaxMin", 1, False))
        ucrNudWBLessThan.SetMinMax(0, Integer.MaxValue)
        ucrNudWBLessThan.Increment = 0.5
        ucrNudWBLessThan.DecimalPlaces = 2
        ucrNudWBLessThan.SetLinkedDisplayControl(lblWaterBalanceLessThan)

        ucrNudCapacity.SetParameter(New RParameter("values", 1, False))
        ucrNudCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudCapacity.Increment = 10
        ucrNudCapacity.SetLinkedDisplayControl(lblCapacity)

        ucrInputWBColName.SetParameter(New RParameter("result_name", 3))
        ucrInputWBColName.SetName("end_season")
        ucrInputWBColName.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrInputWBColName.SetLinkedDisplayControl(lblWBColName)
        ucrInputWBColName.SetValidationTypeAsRVariable()

        ' End of Rains
        ucrChkEndOfRains.SetParameter(New RParameter("sub_end_rain", clsEndRainLastInstance, 1), False)
        ucrChkEndOfRains.SetText("End of Rains")

        ucrChkEndOfRains.AddToLinkedControls(ucrNudThreshold, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)
        ucrChkEndOfRains.AddToLinkedControls(ucrNudTotalOverDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrChkEndOfRains.AddToLinkedControls(ucrInputEndRainColName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_rain")

        ucrNudThreshold.SetParameter(New RParameter("threshold", 1, False))
        ucrNudThreshold.SetMinMax() ' min and max
        ucrNudThreshold.DecimalPlaces = 2
        ucrNudThreshold.Increment = 0.1
        ucrNudThreshold.SetLinkedDisplayControl(lblThreshold)

        ucrNudTotalOverDays.SetParameter(New RParameter("n", 1))
        ucrNudTotalOverDays.SetMinMax(1, 366)
        ucrNudTotalOverDays.SetLinkedDisplayControl(lblTotalOverDays)

        ucrInputEndRainColName.SetParameter(New RParameter("result_name", 3))
        ucrInputEndRainColName.SetName("end_rain")
        ucrInputEndRainColName.SetValidationTypeAsRVariable()
        ucrInputEndRainColName.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrInputEndRainColName.SetLinkedDisplayControl(lblEndRainsColName)
    End Sub

    Private Sub SetDefaults()
        Dim strWaterBalanceMax As String = "water_balance_max"
        Dim strFirstWaterBalanceMax As String = "first_water_balance_max"
        Dim strReplaceNAMax As String = "replace_NA_max"
        Dim strFirstWaterBalanceMin As String = "first_water_balance_min"
        Dim strReplaceNAMin As String = "replace_NA_min"
        Dim strWaterBalanceMin As String = "water_balance_min"
        Dim strDifference As String = "difference"
        Dim strFilterRain As String = "filter_rain"
        Dim strRollingSum As String = "rolling_sum"

        clsAddKey.Clear()
        clsAddKeyColName.Clear()
        clsGroupBy.Clear()
        clsDayFromAndTo.Clear()
        clsDayFromAndToOperator.Clear()
        clsWBReplaceNAMax.Clear()
        clsWBReplaceNAMaxFunction.Clear()
        clsWBReplaceNAMaxFunctionList.Clear()
        clsWBWaterBalanceMax.Clear()
        clsWBWaterFilterMax.Clear()
        clsWBWaterFilterMaxList.Clear()
        clsWBWaterFilterMaxOperator.Clear()
        clsWBFirstWaterBalanceMax.Clear()
        clsWBFirstWaterBalanceManipulationMax.Clear()
        clsWBFirstWaterBalanceMaxOperator.Clear()
        clsWBReplaceNAMin.Clear()
        clsWBWaterBalanceMin.Clear()
        clsWBWaterBalanceMinList.Clear()
        clsWBReplaceNAMinFunctionList.Clear()
        clsWBReplaceNAMinFunction.Clear()
        clsWBWaterFilterMin.Clear()
        clsWBWaterFilterMinList.Clear()
        clsWBFirstWaterBalanceMin.Clear()
        clsWBFirstWaterBalanceMinList.Clear()
        clsWBWaterFilterMinOperator.Clear()
        clsWBFirstWaterBalanceMinOperator.Clear()
        clsPMaxOperatorMax.Clear()
        clsReduceFunctionMax.Clear()
        clsPMinFunctionMax.Clear()
        clsPMaxFunctionMax.Clear()
        clsPMaxOperatorMin.Clear()
        clsReduceFunctionMin.Clear()
        clsPMinFunctionMin.Clear()
        clsPMaxFunctionMin.Clear()
        clsWaterBalanceMaxList.Clear()
        clsDifference.Clear()
        clsDifferenceOperation.Clear()
        clsWaterBalance.Clear()
        clsWaterBalanceFunction.Clear()
        clsWaterBalanceOperator.Clear()

        clsEndRainFilter.Clear()
        clsEndRainFilterOperator.Clear()
        clsEndRainLastInstance.Clear()
        clsEndRainLastInstanceOperator.Clear()
        clsEndRainLastInstanceOperator2.Clear()
        clsEndRainLastInstanceFunction.Clear()
        clsEndRainLastInstanceList.Clear()
        clsEndRainFilterList.Clear()
        clsEndRainRollingSum.Clear()
        clsRollingSumFunction.Clear()
        clsEndRainLastInstanceManipulationList.Clear()

        clsCombinationBase.Clear()
        clsEndRainBase.Clear()
        clsCombinationBaseList.Clear()

        ucrSelectorForWaterBalance.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrInputEndRainColName.Reset()
        ucrInputWBColName.Reset()

        'Add Key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        'group by
        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupBy.SetAssignTo("grouping")

        'Day from and to
        'DayFromandTo
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from_operator", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)
        clsDayFromAndToOperator.AddParameter("to_operator", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")

        ' Water Balance / End of Season:

        ' For Maximum Capacity:
        clsWBReplaceNAMaxFunction.bToScriptAsRString = True
        clsWBReplaceNAMax.SetRCommand("instat_calculation$new")
        clsWBReplaceNAMax.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWBReplaceNAMax.AddParameter("function_exp", clsRFunctionParameter:=clsWBReplaceNAMaxFunction, iPosition:=1)
        clsWBReplaceNAMaxFunction.SetRCommand("replace")
        clsWBReplaceNAMaxFunction.AddParameter("list", clsRFunctionParameter:=clsWBReplaceNAMaxFunctionList, iPosition:=1)
        clsWBReplaceNAMaxFunctionList.SetRCommand("is.na")
        clsWBReplaceNAMaxFunction.AddParameter("values", 60, iPosition:=2)
        'Chr(34) & "replace(" & ucrReceiverRainfall.GetVariableNames(False) & ", is.na( " & ucrReceiverRainfall.GetVariableNames(False) & "), 60)" & Chr(34))
        clsWBReplaceNAMax.AddParameter("result_name", Chr(34) & strReplaceNAMax & Chr(34), iPosition:=2)
        clsWBReplaceNAMax.SetAssignTo(strReplaceNAMax)

        clsReduceFunctionMax.bToScriptAsRString = True
        clsWaterBalanceMaxList.SetRCommand("list")
        clsWaterBalanceMaxList.AddParameter("sub1", clsRFunctionParameter:=clsWBReplaceNAMax, iPosition:=0)

        clsWBWaterBalanceMax.SetRCommand("instat_calculation$new")
        clsWBWaterBalanceMax.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWBWaterBalanceMax.AddParameter("function_exp", clsRFunctionParameter:=clsReduceFunctionMax, iPosition:=1)
        clsReduceFunctionMax.SetRCommand("Reduce")
        clsReduceFunctionMax.AddParameter("x", clsRFunctionParameter:=clsPMinFunctionMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMinFunctionMax.SetRCommand("function(x, y) pmin")
        clsPMinFunctionMax.AddParameter("pmax", clsRFunctionParameter:=clsPMaxFunctionMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.SetRCommand("pmax")
        clsPMaxFunctionMax.AddParameter("calculation", clsROperatorParameter:=clsPMaxOperatorMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxOperatorMax.SetOperation("-")
        clsPMaxOperatorMax.AddParameter("first", "x + y", iPosition:=0)
        clsPMaxOperatorMax.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMax.AddParameter("values", 60, iPosition:=1, bIncludeArgumentName:=False)
        clsReduceFunctionMax.AddParameter("replace_na", strReplaceNAMax, iPosition:=1, bIncludeArgumentName:=False)
        clsReduceFunctionMax.AddParameter("accumulate", "TRUE", iPosition:=2)
        ''"Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Replace_NA_Max, accumulate=TRUE)" & Chr(34))
        clsWBWaterBalanceMax.AddParameter("result_name", Chr(34) & strWaterBalanceMax & Chr(34), iPosition:=2)
        clsWBWaterBalanceMax.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalanceMaxList, iPosition:=4)
        clsWBWaterBalanceMax.SetAssignTo(strWaterBalanceMax)

        clsWBWaterFilterMaxOperator.bToScriptAsRString = True
        clsWBWaterFilterMax.SetRCommand("instat_calculation$new")
        clsWBWaterFilterMaxList.SetRCommand("list")
        clsWBWaterFilterMax.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsWBWaterFilterMax.AddParameter("function_exp", clsROperatorParameter:=clsWBWaterFilterMaxOperator, iPosition:=1)
        clsWBWaterFilterMax.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterFilterMaxList, iPosition:=4)
        clsWBWaterFilterMaxList.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterBalanceMax)
        clsWBWaterFilterMaxOperator.SetOperation("<=")
        clsWBWaterFilterMaxOperator.AddParameter("x", strWaterBalanceMax, iPosition:=0)
        clsWBWaterFilterMaxOperator.AddParameter("rightMaxMin", 0.5, iPosition:=1)
        clsWBWaterFilterMax.SetAssignTo("water_filter_max")

        clsWBFirstWaterBalanceMaxOperator.bToScriptAsRString = True
        clsWBFirstWaterBalanceMax.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMax.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsWBFirstWaterBalanceMax.AddParameter("function_exp", clsROperatorParameter:=clsWBFirstWaterBalanceMaxOperator, iPosition:=1)
        clsWBFirstWaterBalanceMaxOperator.SetOperation("[")
        clsWBFirstWaterBalanceMaxOperator.AddParameter("right", "1 ]", iPosition:=1)
        clsWBFirstWaterBalanceMax.AddParameter("result_name", Chr(34) & strFirstWaterBalanceMax & Chr(34), iPosition:=2)
        clsWBFirstWaterBalanceManipulationMax.SetRCommand("list")
        clsWBFirstWaterBalanceMax.AddParameter("manipulations", clsRFunctionParameter:=clsWBFirstWaterBalanceManipulationMax, iPosition:=5)
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub1", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False, iPosition:=0)
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub2", clsRFunctionParameter:=clsWBWaterFilterMax, bIncludeArgumentName:=False, iPosition:=1)
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=2)
        clsWBFirstWaterBalanceMax.SetAssignTo(strFirstWaterBalanceMax)

        ' For Minimum Capacity:
        clsWBReplaceNAMinFunction.bToScriptAsRString = True
        clsWBReplaceNAMin.SetRCommand("instat_calculation$new")
        clsWBReplaceNAMin.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWBReplaceNAMin.AddParameter("function_exp", clsRFunctionParameter:=clsWBReplaceNAMinFunction, iPosition:=1)
        clsWBReplaceNAMinFunction.SetRCommand("replace")
        clsWBReplaceNAMinFunction.AddParameter("list", clsRFunctionParameter:=clsWBReplaceNAMinFunctionList, iPosition:=1)
        clsWBReplaceNAMinFunctionList.SetRCommand("is.na")
        clsWBReplaceNAMinFunction.AddParameter("values", 0, iPosition:=2)
        clsWBReplaceNAMin.AddParameter("result_name", Chr(34) & strReplaceNAMin & Chr(34), iPosition:=2)
        clsWBReplaceNAMin.SetAssignTo(strReplaceNAMin)

        clsReduceFunctionMin.bToScriptAsRString = True
        clsWBWaterBalanceMinList.SetRCommand("list")
        clsWBWaterBalanceMin.SetRCommand("instat_calculation$new")
        clsWBWaterBalanceMin.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWBWaterBalanceMin.AddParameter("function_exp", clsRFunctionParameter:=clsReduceFunctionMin, iPosition:=1)
        clsReduceFunctionMin.SetRCommand("Reduce")
        clsReduceFunctionMin.AddParameter("x", clsRFunctionParameter:=clsPMinFunctionMin, iPosition:=0, bIncludeArgumentName:=False)
        clsPMinFunctionMin.SetRCommand("function(x, y) pmin")
        clsPMinFunctionMin.AddParameter("pmax", clsRFunctionParameter:=clsPMaxFunctionMin, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxFunctionMin.SetRCommand("pmax")
        clsPMaxFunctionMin.AddParameter("calculation", clsROperatorParameter:=clsPMaxOperatorMin, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxOperatorMin.SetOperation("-")
        clsPMaxOperatorMin.AddParameter("first", "x + y", iPosition:=0)
        clsPMaxOperatorMin.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
        clsPMaxFunctionMin.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMin.AddParameter("values", 60, iPosition:=1, bIncludeArgumentName:=False)
        clsReduceFunctionMin.AddParameter("replace_na", strReplaceNAMin, iPosition:=1, bIncludeArgumentName:=False)
        clsReduceFunctionMin.AddParameter("accumulate", "TRUE", iPosition:=2)
        clsWBWaterBalanceMin.AddParameter("result_name", Chr(34) & strWaterBalanceMin & Chr(34), iPosition:=2)
        clsWBWaterBalanceMin.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterBalanceMinList, iPosition:=4)
        clsWBWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBReplaceNAMin)
        clsWBWaterBalanceMin.SetAssignTo(strWaterBalanceMin)

        clsWBWaterFilterMinOperator.bToScriptAsRString = True
        clsWBWaterFilterMin.SetRCommand("instat_calculation$new")
        clsWBWaterFilterMinList.SetRCommand("list")
        clsWBWaterFilterMin.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsWBWaterFilterMin.AddParameter("function_exp", clsROperatorParameter:=clsWBWaterFilterMinOperator, iPosition:=1)
        clsWBWaterFilterMinOperator.SetOperation("<=")
        clsWBWaterFilterMinOperator.AddParameter("x", strWaterBalanceMin, iPosition:=0)
        clsWBWaterFilterMinOperator.AddParameter("rightMaxMin", 0.5, iPosition:=1)
        clsWBWaterFilterMin.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterFilterMinList, iPosition:=4)
        clsWBWaterFilterMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterBalanceMin)
        clsWBWaterFilterMin.SetAssignTo("water_filter_min")

        clsWBFirstWaterBalanceMinOperator.bToScriptAsRString = True
        clsWBFirstWaterBalanceMinList.SetRCommand("list")
        clsWBFirstWaterBalanceMin.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMin.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsWBFirstWaterBalanceMin.AddParameter("function_exp", clsROperatorParameter:=clsWBFirstWaterBalanceMinOperator, iPosition:=1)
        clsWBFirstWaterBalanceMinOperator.SetOperation("[")
        clsWBFirstWaterBalanceMinOperator.AddParameter("right", "1 ]", iPosition:=1)
        clsWBFirstWaterBalanceMin.AddParameter("result_name", Chr(34) & strFirstWaterBalanceMin & Chr(34), iPosition:=3)
        clsWBFirstWaterBalanceMin.AddParameter("manipulations", clsRFunctionParameter:=clsWBFirstWaterBalanceMinList, iPosition:=5)
        clsWBFirstWaterBalanceMin.SetAssignTo(strFirstWaterBalanceMin)
        clsWBFirstWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False, iPosition:=0)
        clsWBFirstWaterBalanceMinList.AddParameter("sub2", clsRFunctionParameter:=clsWBWaterFilterMin, bIncludeArgumentName:=False, iPosition:=1)
        clsWBFirstWaterBalanceMinList.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=2)

        clsDifferenceOperation.bToScriptAsRString = True
        clsDifferenceList.SetRCommand("list")
        clsDifference.SetRCommand("instat_calculation$new")
        clsDifference.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDifference.AddParameter("function_exp", clsROperatorParameter:=clsDifferenceOperation, iPosition:=1)
        clsDifferenceOperation.SetOperation("-")
        clsDifferenceOperation.AddParameter("left", strFirstWaterBalanceMin, iPosition:=0)
        clsDifferenceOperation.AddParameter("right", strFirstWaterBalanceMax, iPosition:=1)
        clsDifference.AddParameter("result_name", Chr(34) & strDifference & Chr(34), iPosition:=2)
        clsDifference.AddParameter("sub_calculations", clsRFunctionParameter:=clsDifferenceList, iPosition:=4)
        clsDifferenceList.AddParameter("sub1", clsRFunctionParameter:=clsWBFirstWaterBalanceMin, iPosition:=0)
        clsDifferenceList.AddParameter("sub2", clsRFunctionParameter:=clsWBFirstWaterBalanceMax, iPosition:=1)
        clsDifference.SetAssignTo(strDifference)

        'Difference
        clsWaterBalanceFunction.bToScriptAsRString = True
        clsWaterBalanceList.SetRCommand("list")
        clsWaterBalance.SetRCommand("instat_calculation$new")
        clsWaterBalance.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWaterBalance.AddParameter("function_exp", clsRFunctionParameter:=clsWaterBalanceFunction, iPosition:=1)
        clsWaterBalanceFunction.SetRCommand("replace")
        clsWaterBalanceFunction.AddParameter("x", strFirstWaterBalanceMin, iPosition:=0)
        clsWaterBalanceFunction.AddParameter("list", strDifference & "!= 0", iPosition:=1) 'clsROperatorParameter:=clsWaterBalanceOperator, iPosition:=1)
        clsWaterBalanceFunction.AddParameter("values", "NA", iPosition:=2)
        'Chr(34) & "replace(" & strFirstWaterBalanceMin & ", Difference != 0, NA)" & Chr(34), iPosition:=1)
        clsWaterBalance.AddParameter("result_name", Chr(34) & ucrInputWBColName.GetText() & Chr(34), iPosition:=2)
        clsWaterBalance.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalanceList, iPosition:=4)
        clsWaterBalanceList.AddParameter("sub1", clsRFunctionParameter:=clsWBFirstWaterBalanceMin, iPosition:=0, bIncludeArgumentName:=False)
        clsWaterBalanceList.AddParameter("sub2", clsRFunctionParameter:=clsDifference, iPosition:=1, bIncludeArgumentName:=False)
        clsWaterBalance.AddParameter("save", "2", iPosition:=6)
        clsWaterBalance.SetAssignTo("water_balance")

        ' End of Rains
        clsRollingSumFunction.bToScriptAsRString = True
        clsEndRainRollingSum.SetRCommand("instat_calculation$new")
        clsEndRainRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndRainRollingSum.AddParameter("function_exp", clsRFunctionParameter:=clsRollingSumFunction, iPosition:=1)
        clsRollingSumFunction.SetPackageName("RcppRoll")
        clsRollingSumFunction.SetRCommand("roll_sumr")
        clsRollingSumFunction.AddParameter("n", 2, iPosition:=1)
        clsRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsEndRainRollingSum.AddParameter("result_name", Chr(34) & strRollingSum & Chr(34), iPosition:=2)
        clsEndRainRollingSum.SetAssignTo("start_rain_rolling_sum")

        clsEndRainFilterOperator.bToScriptAsRString = True
        clsEndRainFilterList.SetRCommand("list")
        clsEndRainFilter.SetRCommand("instat_calculation$new")
        clsEndRainFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsEndRainFilter.AddParameter("function_exp", clsROperatorParameter:=clsEndRainFilterOperator, iPosition:=1)
        clsEndRainFilterOperator.SetOperation(">")
        clsEndRainFilterOperator.AddParameter("left", strRollingSum, iPosition:=0)
        clsEndRainFilterOperator.AddParameter("threshold", 0.85, iPosition:=1)
        clsEndRainFilter.AddParameter("result_name", Chr(34) & strFilterRain & Chr(34), iPosition:=2)
        clsEndRainFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainFilterList, iPosition:=4)
        clsEndRainFilterList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainRollingSum, iPosition:=0, bIncludeArgumentName:=False)
        clsEndRainFilter.SetAssignTo("rain_above_threshold")

        'clsEndRainLastInstanceOperator.bToScriptAsRString = True
        clsEndRainLastInstanceList.SetRCommand("list")
        clsEndRainLastInstance.SetRCommand("instat_calculation$new")
        clsEndRainLastInstance.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        'todo: fix this
        clsEndRainLastInstance.AddParameter("function_exp", ucrReceiverDOY.GetVariableNames(False) & "[ length" & ucrReceiverDOY.GetVariableNames(False) & "]", iPosition:=1)
        'clsEndRainLastInstance.AddParameter("function_exp", clsROperatorParameter:=clsEndRainLastInstanceOperator, iPosition:=1)
        'clsEndRainLastInstanceOperator.SetOperation("[")
        ''left = doy column
        'clsEndRainLastInstanceOperator.AddParameter("right", clsROperatorParameter:=clsEndRainLastInstanceOperator2, iPosition:=1)
        'clsEndRainLastInstanceOperator2.SetOperation("]")
        'clsEndRainLastInstanceOperator2.AddParameter("left", clsRFunctionParameter:=clsEndRainLastInstanceFunction, iPosition:=0)
        'clsEndRainLastInstanceFunction.SetRCommand("length")
        ' x = doy column
        'clsEndRainLastInstance.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainLastInstanceList, iPosition:=4)
        clsEndRainLastInstance.AddParameter("result_name", Chr(34) & "end_rain" & Chr(34), iPosition:=2) ' the result name of this is what is in the save, see how it's done in Start of Rains and Spells. This needs to be implemented properly in End of Season too as well as here, iPosition:=2)
        'clsEndRainLastInstanceList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainFilter, iPosition:=0, bIncludeArgumentName:=False)
        clsEndRainLastInstance.AddParameter("manipulations", clsRFunctionParameter:=clsEndRainLastInstanceManipulationList, iPosition:=5)
        clsEndRainLastInstanceManipulationList.SetRCommand("list")
        clsEndRainLastInstanceManipulationList.AddParameter("sub1", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False, iPosition:=0)
        clsEndRainLastInstanceManipulationList.AddParameter("sub2", clsRFunctionParameter:=clsEndRainFilter, bIncludeArgumentName:=False, iPosition:=1)
        clsEndRainLastInstanceManipulationList.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=2)
        clsEndRainLastInstance.AddParameter("save", "2", iPosition:=6)
        clsEndRainLastInstance.SetAssignTo("end_of_rains")

        clsCombinationBase.SetRCommand("instat_calculation$new")
        clsCombinationBase.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationBase.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinationBaseList, iPosition:=4)
        clsCombinationBaseList.SetRCommand("list")
        'clsCombinationBaseList.AddParameter("sub_water_balance", clsRFunctionParameter:=clsWaterBalance, iPosition:=0) ' if we want these default unchecked.
        'clsCombinationBaseList.AddParameter("sub_end_rain", clsRFunctionParameter:=clsEndRainLastInstance, iPosition:=1)

        clsEndRainBase.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsEndRainBase.AddParameter("display", "FALSE")
        clsEndRainBase.AddParameter("calc", clsRFunctionParameter:=clsCombinationBase)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAddKey, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsEndRainBase)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsWBFirstWaterBalanceMaxOperator, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsWBFirstWaterBalanceMinOperator, New RParameter("left", 0), iAdditionalPairNo:=3)
        'ucrReceiverDOY.AddAdditionalCodeParameterPair(clsEndRainLastInstanceOperator, New RParameter("left", 0, False), iAdditionalPairNo:=4)
        'ucrReceiverDOY.AddAdditionalCodeParameterPair(clsEndRainLastInstanceFunction, New RParameter("left", 0, False), iAdditionalPairNo:=5)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunctionList, New RParameter("x", 0, False), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunctionList, New RParameter("x", 0, False), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRollingSumFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrNudWBLessThan.AddAdditionalCodeParameterPair(clsWBWaterFilterMinOperator, ucrNudWBLessThan.GetParameter(), iAdditionalPairNo:=1)
        ucrInputEvaporation.AddAdditionalCodeParameterPair(clsPMaxOperatorMin, ucrInputEvaporation.GetParameter(), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunction, ucrNudCapacity.GetParameter(), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsPMinFunctionMin, ucrNudCapacity.GetParameter(), iAdditionalPairNo:=2)

        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        ucrInputEndRainColName.SetRCode(clsEndRainLastInstance, bReset)
        ucrInputWBColName.SetRCode(clsWaterBalance, bReset)

        'ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        'ucrInputSum.SetRCode(clsMatchFun, bReset)
        'ucrInputColName.SetRCode(clsRWater_bal, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)
        ucrSelectorForWaterBalance.SetRCode(clsAddKey, bReset)

        ' Water Balance:
        ucrChkEndOfSeason.SetRCode(clsCombinationBaseList, bReset)
        ucrReceiverRainfall.SetRCode(clsWBReplaceNAMaxFunction, bReset)

        ucrNudWBLessThan.SetRCode(clsWBWaterFilterMaxOperator, bReset)

        ucrInputEvaporation.SetRCode(clsPMaxOperatorMax, bReset)
        ucrNudCapacity.SetRCode(clsPMinFunctionMax, bReset)

        'EoR
        ucrChkEndOfRains.SetRCode(clsCombinationBaseList, bReset)
        ucrNudThreshold.SetRCode(clsEndRainFilterOperator, bReset)
        ucrNudTotalOverDays.SetRCode(clsRollingSumFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (ucrChkEndOfRains.Checked OrElse ucrChkEndOfSeason.Checked) AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrNudFrom.GetText <> "" AndAlso ucrNudTo.GetText <> "" AndAlso ((ucrChkEndOfSeason.Checked AndAlso ucrNudCapacity.GetText <> "" AndAlso ucrNudWBLessThan.GetText <> "" AndAlso Not ucrInputWBColName.IsEmpty AndAlso Not ucrInputEvaporation.IsEmpty) OrElse Not ucrChkEndOfSeason.Checked) AndAlso ((ucrChkEndOfRains.Checked AndAlso ucrNudThreshold.GetText <> "" AndAlso ucrNudTotalOverDays.GetText <> "") OrElse Not ucrChkEndOfRains.Checked) AndAlso ucrInputEndRainColName.GetText <> ucrInputWBColName.GetText Then
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

    Private Sub GroupBy()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        End If
    End Sub

    Private Sub DayChange()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsWBFirstWaterBalanceMin.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsWBFirstWaterBalanceMax.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndRainLastInstance.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub RainfallChange()
        clsWBReplaceNAMin.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsWBReplaceNAMax.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub YearChange()
        clsEndRainRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrReceiverStationYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupBy()
        YearChange()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayChange()
        clsEndRainLastInstance.AddParameter("function_exp", Chr(34) & ucrReceiverDOY.GetVariableNames(False) & "[length(" & ucrReceiverDOY.GetVariableNames(False) & ")]" & Chr(34), iPosition:=1)
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForWaterBalance.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupBy()
        DayChange()
        YearChange()
        RainfallChange()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkEndOfRains.ControlContentsChanged, ucrChkEndOfSeason.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudCapacity.ControlContentsChanged, ucrNudWBLessThan.ControlContentsChanged, ucrInputWBColName.ControlContentsChanged, ucrChkEvaporationAsReceiver.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrReceiverEvaporation.ControlContentsChanged, ucrNudTotalOverDays.ControlContentsChanged, ucrNudThreshold.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class