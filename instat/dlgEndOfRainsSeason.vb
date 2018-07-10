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
Public Class dlgEndOfRainsSeason
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strReplaceNAMin As String = "rain_NA_as_0"
    Private strReplaceNAMax As String = "rain_NA_as_60"
    Private strEvapReplaceNA As String = "evap_NA_as_value"
    Private clsAddKey, clsAddKeyColName, clsGroupByStationYear, clsGroupByStation, clsDayFromAndTo As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsWaterBalanceOperator, clsDifferenceOperation As New ROperator
    Private clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction
    '60
    Private clsWBReplaceNAMax, clsWBReplaceNAMaxFunction, clsWBReplaceNAMaxFunctionList, clsWBWaterBalanceMax, clsWBWaterFilterMax, clsWBWaterFilterMaxList, clsWBFirstWaterBalanceMax, clsWBFirstWaterBalanceManipulationMax, clsWaterBalanceMaxList, clsReduceFunctionMax, clsPMinFunctionMax, clsPMaxFunctionMax As New RFunction
    Private clsWBWaterFilterMaxOperator, clsWBFirstWaterBalanceMaxOperator, clsPMaxOperatorMax As New ROperator
    '0
    Private clsWBReplaceNAMin, clsWBReplaceNAMinFunction, clsWBReplaceNAMinFunctionList, clsWBWaterBalanceMin, clsWBWaterFilterMin, clsWBWaterFilterMinList, clsWBFirstWaterBalanceMin, clsWBFirstWaterBalanceMinList, clsWBWaterBalanceMinList, clsReduceFunctionMin, clsPMinFunctionMin, clsPMaxFunctionMin As New RFunction
    Private clsEvaporationReplaceNAFunc, clsEvaporationReplaceNA, clsEvaporationReplaceNAFuncList As New RFunction
    Private clsReduceOpEvapMin, clsReduceOpEvapMax As New ROperator

    Private clsWBWaterFilterMinOperator, clsWBFirstWaterBalanceMinOperator, clsPMaxOperatorMin As New ROperator

    Private clsCombinationBase, clsEndRainBase, clsWaterBalanceList, clsWaterBalanceFunction, clsWaterBalance As New RFunction
    Private clsDifference, clsDifferenceList As New RFunction

    'EoR
    Private clsEndRainFilter, clsEndRainLastInstance, clsEndRainLastInstanceFunction, clsEndRainLastInstanceList, clsEndRainFilterList, clsEndRainRollingSum, clsRollingSumFunction, clsEndRainLastInstanceManipulationList As New RFunction
    Private clsEndRainFilterOperator, clsEndRainLastInstanceOperator, clsEndRainLastInstanceOperator2 As New ROperator
    Private clsLastDoyFunction, clsLastDateFunction, clsEndOfRainsDateFunction As New RFunction
    Private clsEndOfRainsFilter, clsEORFilterList, clsListManipulations, clsRollManipList, clsEOREndFunction As New RFunction
    Private clsLessEqualOperator, clsSquareBracketOpertor As New ROperator
    Private clsIfElseFunc, clsIsNAFunc, clsIsNA, clsSubCalcList As New RFunction
    Private clsEORStatusFunction, clsIfElseFunction As New RFunction
    Private clsEOREndSummary As New clsRains
    Private clsEORStatusSummary As New clsRains

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
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("date", 0, bNewIncludeArgumentName:=False))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForWaterBalance
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bWithQuotes = False
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForWaterBalance
        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverRainfall.SetParameter(New RParameter("x", 0))
        ucrReceiverRainfall.SetParameterIsString()
        ucrReceiverRainfall.bWithQuotes = False
        ucrReceiverRainfall.Selector = ucrSelectorForWaterBalance
        ucrReceiverRainfall.SetClimaticType("rain")
        ucrReceiverRainfall.bAutoFill = True
        ucrReceiverRainfall.strSelectorHeading = "Rain Variables"

        ucrReceiverYear.Selector = ucrSelectorForWaterBalance
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverEvaporation.Selector = ucrSelectorForWaterBalance
        ucrReceiverEvaporation.SetParameterIsString()
        ucrReceiverEvaporation.bWithQuotes = False
        ucrReceiverEvaporation.SetParameter(New RParameter("x", 0))

        'WATER BALANCE
        ucrChkEndOfSeason.SetText("End of Season")
        ucrChkEndOfSeason.SetParameter(New RParameter("sub_water_balance", clsWaterBalance, 0, bNewIncludeArgumentName:=False), False)

        ucrPnlEvaporation.AddRadioButton(rdoValueEvaporation)
        ucrPnlEvaporation.AddRadioButton(rdoVariableEvaporation)
        ucrPnlEvaporation.AddToLinkedControls(ucrInputEvaporation, {rdoValueEvaporation}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlEvaporation.AddToLinkedControls(ucrReceiverEvaporation, {rdoVariableEvaporation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlEvaporation.AddToLinkedControls(ucrInputReplaceNA, {rdoVariableEvaporation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)

        ucrChkEndOfSeason.AddToLinkedControls(ucrNudCapacity, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=60)
        ucrChkEndOfSeason.AddToLinkedControls(ucrNudWBLessThan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrChkEndOfSeason.AddToLinkedControls(ucrPnlEvaporation, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoValueEvaporation)
        ucrChkEndOfSeason.AddToLinkedControls(ucrChkEndofSeasonDoy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrChkEndofSeasonDoy.SetLinkedDisplayControl(grpEndofSeason)

        ucrChkEndOfSeason.AddToLinkedControls(ucrNudWBLessThan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrPnlEvaporation.SetLinkedDisplayControl(lblEvaporation)
        ucrInputReplaceNA.SetLinkedDisplayControl(lblReplaceNA)

        ucrInputEvaporation.SetParameter(New RParameter("evaporation", 1, False))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False

        ucrInputReplaceNA.SetParameter(New RParameter("values", 2))
        ucrInputReplaceNA.SetValidationTypeAsNumeric()
        ucrInputReplaceNA.AddQuotesIfUnrecognised = False

        ucrNudWBLessThan.SetParameter(New RParameter("rightMaxMin", 1, False))
        ucrNudWBLessThan.SetMinMax(0, Integer.MaxValue)
        ucrNudWBLessThan.Increment = 0.5
        ucrNudWBLessThan.DecimalPlaces = 2
        ucrNudWBLessThan.SetLinkedDisplayControl(lblWaterBalanceLessThan)

        ucrNudCapacity.SetParameter(New RParameter("values", 1))
        ucrNudCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudCapacity.Increment = 10
        ucrNudCapacity.SetLinkedDisplayControl(lblCapacity)

        ucrInputSeasonDoy.SetParameter(New RParameter("result_name", 3))
        ucrInputSeasonDoy.SetName("end_season_day")
        ucrInputSeasonDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrInputSeasonDoy.SetValidationTypeAsRVariable()


        ' End of Rains
        ucrChkEndOfRains.SetParameter(New RParameter("sub_end_rain", clsEndRainLastInstance, 1, bNewIncludeArgumentName:=False), False)
        ucrChkEndOfRains.SetText("End of Rains")

        ucrChkEndOfRains.AddToLinkedControls(ucrNudAmount, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkEndOfRains.AddToLinkedControls(ucrNudTotalOverDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkEndOfRains.AddToLinkedControls(ucrChkEndofRainsDoy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrChkEndofRainsDoy.SetLinkedDisplayControl(grpEndofRains)

        ucrNudAmount.SetParameter(New RParameter("threshold", 1, False))
        ucrNudAmount.SetMinMax() ' min and max
        ucrNudAmount.DecimalPlaces = 2
        ucrNudAmount.Increment = 0.1
        ucrNudAmount.SetLinkedDisplayControl(lblAmount)

        ucrNudTotalOverDays.SetParameter(New RParameter("n", 1))
        ucrNudTotalOverDays.SetMinMax(1, 366)
        ucrNudTotalOverDays.SetLinkedDisplayControl(lblTotalOverDays)

        ucrChkEndofSeasonDoy.AddToLinkedControls(ucrInputSeasonDoy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_season")
        ucrChkEndofSeasonDoy.SetText("Day")

        ucrChkEndofSeasonDate.AddToLinkedControls(ucrInputEndofSeasonDate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonDate.SetText("Date")

        ucrChkEndofSeasonOccurence.AddToLinkedControls(ucrInputEndofSeasonOccurence, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonOccurence.SetText("Occurrence")

        ucrChkEndofRainsDoy.AddToLinkedControls(ucrInputEndRainDoy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_rain")
        ucrChkEndofRainsDoy.SetText("Day")
        ucrChkEndofRainsDoy.AddParameterPresentCondition(True, "sub1", True)
        ucrChkEndofRainsDoy.AddParameterPresentCondition(False, "sub1", False)

        ucrInputEndRainDoy.SetParameter(New RParameter("result_name", 3))
        ucrInputEndRainDoy.SetName("end_rain")
        ucrInputEndRainDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofRainsDate.AddToLinkedControls(ucrInputEndofRainsDate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_raind")
        ucrChkEndofRainsDate.SetText("Date")
        ucrChkEndofRainsDate.AddParameterPresentCondition(True, "sub2", True)
        ucrChkEndofRainsDate.AddParameterPresentCondition(False, "sub2", False)

        ucrInputEndofRainsDate.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofRainsDate.SetName("end_raind")
        ucrInputEndofRainsDate.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofRainsOccurence.AddToLinkedControls(ucrInputEndofRainsOccurence, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_rainl")
        ucrChkEndofRainsOccurence.SetText("Occurrence")
        ucrChkEndofRainsOccurence.AddParameterPresentCondition(True, "sub2", True)
        ucrChkEndofRainsOccurence.AddParameterPresentCondition(False, "sub2", False)

        ucrInputEndofRainsOccurence.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofRainsOccurence.SetName("end_rainl")
        ucrInputEndofRainsOccurence.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

    End Sub

    Private Sub SetDefaults()
        Dim strWaterBalanceMax As String = "water_balance_max"
        Dim strFirstWaterBalanceMax As String = "first_water_balance_max"
        Dim strFirstWaterBalanceMin As String = "first_water_balance_min"
        Dim strWaterBalanceMin As String = "water_balance_min"
        Dim strDifference As String = "difference"
        Dim strFilterRain As String = "filter_rain"
        Dim strRollingSum As String = "rolling_sum"
        Dim strEndRain As String = "end_rain"
        Dim strEndStatus As String = "end_status"

        clsAddKey.Clear()
        clsAddKeyColName.Clear()
        clsGroupByStationYear.Clear()
        clsGroupByStation.Clear()
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
        clsEvaporationReplaceNAFunc.Clear()
        clsEvaporationReplaceNA.Clear()
        clsEvaporationReplaceNAFuncList.Clear()
        clsReduceOpEvapMin.Clear()
        clsReduceOpEvapMax.Clear()

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
        'clsCombinationBaseList.Clear()
        clsEORFilterList.Clear()
        clsSubCalcList.Clear()
        clsEndOfRainsFilter.Clear()
        clsEORStatusFunction.Clear()
        clsEOREndFunction.Clear()

        ucrSelectorForWaterBalance.Reset()
        ucrReceiverRainfall.SetMeAsReceiver()

        'Add Key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")
        clsAddKey.AddParameter("data_name", strCurrDataName)

        'group by
        clsGroupByStationYear.SetRCommand("instat_calculation$new")
        clsGroupByStationYear.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationYear.SetAssignTo("grouping_by_station_year")

        clsGroupByStation.SetRCommand("instat_calculation$new")
        clsGroupByStation.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStation.SetAssignTo("grouping_by_station")

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

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
        clsDayFromAndToOperator.bBrackets = False
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")
        clsDayFromAndTo.AddParameter("calculated_from", clsRFunctionParameter:=clsDayFilterCalcFromConvert, iPosition:=2)

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
        'clsPMaxOperatorMax.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMax.AddParameter("values", 60, iPosition:=1)
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
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub1", clsRFunctionParameter:=clsGroupByStationYear, bIncludeArgumentName:=False, iPosition:=0)
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
        'clsPMaxOperatorMin.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
        clsPMaxFunctionMin.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMin.AddParameter("values", 60, iPosition:=1)
        clsReduceFunctionMin.AddParameter("replace_na", strReplaceNAMin, iPosition:=1, bIncludeArgumentName:=False)
        clsReduceFunctionMin.AddParameter("accumulate", "TRUE", iPosition:=2)
        clsWBWaterBalanceMin.AddParameter("result_name", Chr(34) & strWaterBalanceMin & Chr(34), iPosition:=2)
        clsWBWaterBalanceMin.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterBalanceMinList, iPosition:=4)
        clsWBWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBReplaceNAMin, bIncludeArgumentName:=False)
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
        clsWBFirstWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsGroupByStationYear, bIncludeArgumentName:=False, iPosition:=0)
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
        clsWaterBalance.AddParameter("result_name", Chr(34) & ucrInputSeasonDoy.GetText() & Chr(34), iPosition:=2)
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
        clsRollingSumFunction.AddParameter("n", 1, iPosition:=1)
        clsRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsEndRainRollingSum.AddParameter("result_name", Chr(34) & strRollingSum & Chr(34), iPosition:=2)
        clsEndRainRollingSum.AddParameter("manipulations", clsRFunctionParameter:=clsRollManipList, iPosition:=4)
        clsEndRainRollingSum.SetAssignTo("start_rain_rolling_sum")

        clsEndRainFilterOperator.bToScriptAsRString = True
        clsEndRainFilterList.SetRCommand("list")
        clsEndRainFilter.SetRCommand("instat_calculation$new")
        clsEndRainFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsEndRainFilter.AddParameter("function_exp", clsROperatorParameter:=clsEndRainFilterOperator, iPosition:=1)
        clsEndRainFilterOperator.SetOperation(">")
        clsEndRainFilterOperator.AddParameter("left", strRollingSum, iPosition:=0)
        clsEndRainFilterOperator.AddParameter("threshold", 10, iPosition:=1)
        clsEndRainFilter.AddParameter("result_name", Chr(34) & strFilterRain & Chr(34), iPosition:=2)
        clsEndRainFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainFilterList, iPosition:=4)
        clsEndRainFilterList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainRollingSum, iPosition:=0, bIncludeArgumentName:=False)
        clsEndRainFilter.SetAssignTo("rain_above_threshold")

        'clsEndRainLastInstanceOperator.bToScriptAsRString = True
        clsEndRainLastInstanceList.SetRCommand("list")
        clsEndRainLastInstance.SetRCommand("instat_calculation$new")
        clsEndRainLastInstance.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        'todo: fix this
        clsEndRainLastInstance.AddParameter("function_exp", clsRFunctionParameter:=clsLastDoyFunction, iPosition:=1)
        'clsEndRainLastInstance.AddParameter("function_exp", clsROperatorParameter:=clsEndRainLastInstanceOperator, iPosition:=1)
        'clsEndRainLastInstanceOperator.SetOperation("[")
        ''left = doy column
        'clsEndRainLastInstanceOperator.AddParameter("right", clsROperatorParameter:=clsEndRainLastInstanceOperator2, iPosition:=1)
        'clsEndRainLastInstanceOperator2.SetOperation("]")
        'clsEndRainLastInstanceOperator2.AddParameter("left", clsRFunctionParameter:=clsEndRainLastInstanceFunction, iPosition:=0)
        'clsEndRainLastInstanceFunction.SetRCommand("length")
        ' x = doy column
        'clsEndRainLastInstance.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainLastInstanceList, iPosition:=4)
        clsEndRainLastInstance.AddParameter("result_name", Chr(34) & strEndRain & Chr(34), iPosition:=2) ' the result name of this is what is in the save, see how it's done in Start of Rains and Spells. This needs to be implemented properly in End of Season too as well as here, iPosition:=2)
        'clsEndRainLastInstanceList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainFilter, iPosition:=0, bIncludeArgumentName:=False)
        clsEndRainLastInstance.AddParameter("manipulations", clsRFunctionParameter:=clsEndRainLastInstanceManipulationList, iPosition:=5)
        clsEndRainLastInstance.AddParameter("save", "2", iPosition:=6)
        clsEndRainLastInstance.SetAssignTo("end_of_rains_doy")

        clsEndRainLastInstanceManipulationList.SetRCommand("list")
        clsEndRainLastInstanceManipulationList.AddParameter("sub1", clsRFunctionParameter:=clsGroupByStationYear, bIncludeArgumentName:=False, iPosition:=0)
        clsEndRainLastInstanceManipulationList.AddParameter("sub2", clsRFunctionParameter:=clsEndRainFilter, bIncludeArgumentName:=False, iPosition:=1)
        clsEndRainLastInstanceManipulationList.AddParameter("sub3", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=2)

        clsLastDoyFunction.SetPackageName("dplyr")
        clsLastDoyFunction.SetRCommand("last")
        clsLastDoyFunction.AddParameter("default", "NA", iPosition:=1)
        clsLastDoyFunction.bToScriptAsRString = True

        clsEndOfRainsDateFunction.SetRCommand("instat_calculation$new")
        clsEndOfRainsDateFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndOfRainsDateFunction.AddParameter("function_exp", clsRFunctionParameter:=clsLastDateFunction, iPosition:=1)
        clsEndOfRainsDateFunction.AddParameter("result_name", Chr(34) & "end_raind" & Chr(34), iPosition:=2)
        clsEndOfRainsDateFunction.AddParameter("manipulations", clsRFunctionParameter:=clsEndRainLastInstanceManipulationList, iPosition:=4)
        clsEndOfRainsDateFunction.AddParameter("save", 2)
        clsEndOfRainsDateFunction.SetAssignTo("end_of_rains_date")

        clsLastDateFunction.SetPackageName("dplyr")
        clsLastDateFunction.SetRCommand("last")
        clsLastDateFunction.AddParameter("default", "NA", iPosition:=1)
        clsLastDateFunction.bToScriptAsRString = True

        clsCombinationBase.SetRCommand("instat_calculation$new")
        clsCombinationBase.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationBase.AddParameter("manipulations", clsRFunctionParameter:=clsListManipulations, iPosition:=1)
        clsCombinationBase.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=2)
        'clsCombinationBaseList.SetRCommand("list")
        clsCombinationBase.SetAssignTo("end_of_rains_combined")
        'clsCombinationBaseList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainLastInstance, bIncludeArgumentName:=False, iPosition:=0)

        clsSubCalcList.SetRCommand("list")

        clsListManipulations.SetRCommand("list")
        clsListManipulations.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStationYear, bIncludeArgumentName:=False, iPosition:=0)

        clsEORStatusSummary.SetDefaults()
        clsEORStatusSummary.clsIsNaIfelse.bToScriptAsRString = True
        clsEORStatusSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=strEndRain, bIncludeArgumentName:=False, iPosition:=0)

        clsEOREndSummary.SetDefaults()
        clsEOREndSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=strEndRain, bIncludeArgumentName:=False, iPosition:=0)

        clsEOREndFunction.SetRCommand("instat_calculation$new")
        clsEOREndFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEOREndFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseFunction, iPosition:=1)
        clsEOREndFunction.AddParameter("result_name", Chr(34) & strEndRain & Chr(34), iPosition:=3)
        clsEOREndFunction.AddParameter("save", 2, iPosition:=4)
        clsEOREndFunction.SetAssignTo("end_of_rains_end")

        clsRollManipList.SetRCommand("list")

        clsLessEqualOperator.SetOperation("<=")
        clsLessEqualOperator.bToScriptAsRString = True
        clsLessEqualOperator.AddParameter("ifelse", clsRFunctionParameter:=clsIfElseFunc, bIncludeArgumentName:=False)

        clsIfElseFunc.SetRCommand("ifelse")
        clsIfElseFunc.AddParameter("is.na", clsRFunctionParameter:=clsIsNAFunc, bIncludeArgumentName:=False, iPosition:=0)
        clsIfElseFunc.AddParameter("366", 366, bIncludeArgumentName:=False, iPosition:=1)
        clsIfElseFunc.AddParameter("end_rain1", clsROperatorParameter:=clsSquareBracketOpertor, bIncludeArgumentName:=False, iPosition:=2)

        clsIsNAFunc.SetRCommand("is.na")
        clsIsNAFunc.AddParameter("operation", clsROperatorParameter:=clsSquareBracketOpertor, iPosition:=0, bIncludeArgumentName:=False)

        clsSquareBracketOpertor.SetOperation("[1")
        clsSquareBracketOpertor.AddParameter("end_rain1", strEndRain, bIncludeArgumentName:=False, iPosition:=0)
        clsSquareBracketOpertor.AddParameter("bracket", "]", bIncludeArgumentName:=False, iPosition:=1)

        clsEORStatusFunction.SetRCommand("instat_calculation$new")
        clsEORStatusFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEORStatusFunction.AddParameter("function_exp", clsRFunctionParameter:=clsEORStatusSummary.clsIsNaIfelse, iPosition:=1)
        clsEORStatusFunction.AddParameter("result_name", Chr(34) & strEndStatus & Chr(34), iPosition:=3)
        clsEORStatusFunction.AddParameter("save", 2, iPosition:=4)
        clsEORStatusFunction.SetAssignTo("end_of_rains_status")

        clsIfElseFunction.SetRCommand("ifelse")
        clsIfElseFunction.bToScriptAsRString = True
        clsIfElseFunction.AddParameter("is.na", clsRFunctionParameter:=clsIsNA, bIncludeArgumentName:=False, iPosition:=0)
        clsIfElseFunction.AddParameter("NA", "NA", bIncludeArgumentName:=False, iPosition:=1)
        clsIfElseFunction.AddParameter("end_day", clsROperatorParameter:=clsSquareBracketOpertor, bIncludeArgumentName:=False, iPosition:=2)

        clsIsNA.SetRCommand("is.na")
        clsIsNA.AddParameter("is.na", clsRFunctionParameter:=clsEOREndSummary.clsIsNaIfelse, bIncludeArgumentName:=False)

        clsEndOfRainsFilter.SetRCommand("instat_calculation$new")
        clsEndOfRainsFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsEndOfRainsFilter.AddParameter("function_exp", clsROperatorParameter:=clsLessEqualOperator, iPosition:=1)
        clsEndOfRainsFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsEORFilterList, iPosition:=4)
        clsEndOfRainsFilter.SetAssignTo("end_of_rains_filter")

        clsEORFilterList.SetRCommand("list")
        clsEORFilterList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainLastInstance, bIncludeArgumentName:=False, iPosition:=0)

        clsCombinationBase.SetAssignTo("end_of_rainsseason_combined")
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
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLastDoyFunction, New RParameter("day", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLessEqualOperator, New RParameter("day", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunctionList, New RParameter("x", 0, False), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunctionList, New RParameter("x", 0, False), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRollingSumFunction, New RParameter("x", 0), iAdditionalPairNo:=4)

        clsEOREndSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=5)
        clsEORStatusSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=6)

        ucrNudWBLessThan.AddAdditionalCodeParameterPair(clsWBWaterFilterMinOperator, ucrNudWBLessThan.GetParameter(), iAdditionalPairNo:=1)
        ucrInputEvaporation.AddAdditionalCodeParameterPair(clsPMaxOperatorMax, New RParameter("evaporation", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunction, ucrNudCapacity.GetParameter(), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsPMinFunctionMin, ucrNudCapacity.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverEvaporation.AddAdditionalCodeParameterPair(clsEvaporationReplaceNAFuncList, New RParameter("x", 0, False), iAdditionalPairNo:=1)
        'ucrReceiverDate.AddAdditionalCodeParameterPair(clsLastDateFunction, New RParameter("date", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        ucrInputEndRainDoy.SetRCode(clsEndRainLastInstance, bReset)
        ucrInputSeasonDoy.SetRCode(clsWaterBalance, bReset)
        ucrInputEndofRainsDate.SetRCode(clsEndOfRainsDateFunction, bReset)
        ucrInputEndofRainsOccurence.SetRCode(clsEORStatusFunction, bReset)

        'ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        'ucrInputSum.SetRCode(clsMatchFun, bReset)
        'ucrInputColName.SetRCode(clsRWater_bal, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverDate.SetRCode(clsLastDateFunction, bReset)
        ucrSelectorForWaterBalance.SetRCode(clsAddKey, bReset)
        ucrReceiverEvaporation.SetRCode(clsEvaporationReplaceNAFunc, bReset)
        ucrInputReplaceNA.SetRCode(clsEvaporationReplaceNAFunc, bReset)

        ' Water Balance:
        ucrChkEndOfSeason.SetRCode(clsSubCalcList, bReset)
        ucrReceiverRainfall.SetRCode(clsWBReplaceNAMaxFunction, bReset)

        ucrNudWBLessThan.SetRCode(clsWBWaterFilterMaxOperator, bReset)

        ucrInputEvaporation.SetRCode(clsPMaxOperatorMin, bReset)
        ucrNudCapacity.SetRCode(clsPMinFunctionMax, bReset)

        'EoR
        ucrChkEndOfRains.SetRCode(clsSubCalcList, bReset)
        ucrNudAmount.SetRCode(clsEndRainFilterOperator, bReset)
        ucrNudTotalOverDays.SetRCode(clsRollingSumFunction, bReset)
        ucrChkEndofRainsDoy.SetRCode(clsEORFilterList, bReset)
        ucrChkEndofRainsDate.SetRCode(clsEORFilterList, bReset)
        ucrChkEndofRainsOccurence.SetRCode(clsSubCalcList, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (ucrChkEndOfRains.Checked OrElse ucrChkEndOfSeason.Checked) AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ((ucrChkEndOfSeason.Checked AndAlso ucrNudCapacity.GetText <> "" AndAlso ucrNudWBLessThan.GetText <> "" AndAlso Not ucrInputSeasonDoy.IsEmpty AndAlso ((rdoValueEvaporation.Checked AndAlso Not ucrInputEvaporation.IsEmpty) OrElse (rdoVariableEvaporation.Checked AndAlso Not ucrReceiverEvaporation.IsEmpty AndAlso Not ucrInputReplaceNA.IsEmpty))) OrElse Not ucrChkEndOfSeason.Checked) AndAlso ((ucrChkEndOfRains.Checked AndAlso ucrNudAmount.GetText <> "" AndAlso ucrNudTotalOverDays.GetText <> "" AndAlso Not ucrInputEndRainDoy.IsEmpty) OrElse Not ucrChkEndOfRains.Checked) AndAlso ucrInputEndRainDoy.GetText <> "" AndAlso ucrInputSeasonDoy.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFromAndTo, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
        sdgDoyRange.ShowDialog()
        UpdateDayFilterPreview()
    End Sub

    Private Sub UpdateDayFilterPreview()
        If ucrReceiverDOY.IsEmpty Then
            ucrInputFilterPreview.SetName("")
        Else
            ucrInputFilterPreview.SetName(clsDayFromAndToOperator.ToScript())
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub GroupingBy()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupByStationYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupByStationYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        End If
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByStation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=2)
            clsRollManipList.AddParameter("manip", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
        Else
            clsRollManipList.RemoveParameterByName("manip")
        End If
    End Sub

    Private Sub DayChange()
        clsWBFirstWaterBalanceMin.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsWBFirstWaterBalanceMax.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndRainLastInstance.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndOfRainsDateFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDate.GetVariableNames() & ")", iPosition:=3)
        clsAddKeyColName.AddParameter("Date", ucrReceiverDate.GetVariableNames(), iPosition:=0)
        clsEndOfRainsFilter.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=2)

    End Sub

    Private Sub RainfallChange()
        clsWBReplaceNAMin.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsWBReplaceNAMax.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsEORStatusFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsEOREndFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub YearChange()
        clsEndRainRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrReceiverStationYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupingBy()
        YearChange()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorForWaterBalance.ControlValueChanged
        If Not ucrReceiverDOY.IsEmpty Then
            clsDayFilterCalcFromList.AddParameter(ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForWaterBalance.ControlContentsChanged, ucrReceiverDOY.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupingBy()
        DayChange()
        YearChange()
        RainfallChange()
    End Sub

    Private Sub ucrSelectorForWaterBalance_DataFrameChanged() Handles ucrSelectorForWaterBalance.DataFrameChanged
        clsDayFilterCalcFromList.ClearParameters()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkEndOfRains.ControlContentsChanged, ucrChkEndOfSeason.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrNudCapacity.ControlContentsChanged, ucrNudWBLessThan.ControlContentsChanged, ucrInputSeasonDoy.ControlContentsChanged, ucrNudTotalOverDays.ControlContentsChanged, ucrNudAmount.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlEvaporation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlEvaporation.ControlValueChanged, ucrReceiverEvaporation.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrInputReplaceNA.ControlContentsChanged
        Evaporation()
        TestOKEnabled()
    End Sub

    Private Sub Evaporation()
        If rdoValueEvaporation.Checked Then
            clsPMaxOperatorMin.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
            clsPMaxOperatorMax.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
            clsReduceFunctionMin.AddParameter("replace_na", strReplaceNAMin, iPosition:=1, bIncludeArgumentName:=False)
            clsReduceFunctionMax.AddParameter("replace_na", strReplaceNAMax, iPosition:=1, bIncludeArgumentName:=False)
            clsWBWaterBalanceMinList.RemoveParameterByName("sub2")
            clsWaterBalanceMaxList.RemoveParameterByName("sub2")
        ElseIf rdoVariableEvaporation.Checked Then
            ucrReceiverEvaporation.SetMeAsReceiver()
            clsEvaporationReplaceNAFunc.bToScriptAsRString = True
            clsEvaporationReplaceNA.SetRCommand("instat_calculation$new")
            clsEvaporationReplaceNA.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
            clsEvaporationReplaceNA.AddParameter("function_exp", clsRFunctionParameter:=clsEvaporationReplaceNAFunc, iPosition:=1)
            clsEvaporationReplaceNAFunc.SetRCommand("replace")
            clsEvaporationReplaceNAFunc.AddParameter("list", clsRFunctionParameter:=clsEvaporationReplaceNAFuncList, iPosition:=1)
            clsEvaporationReplaceNAFuncList.SetRCommand("is.na")
            clsEvaporationReplaceNA.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverEvaporation.GetVariableNames & ")")
            clsEvaporationReplaceNA.AddParameter("result_name", Chr(34) & strEvapReplaceNA & Chr(34), iPosition:=2)
            clsEvaporationReplaceNA.SetAssignTo(strEvapReplaceNA)

            clsReduceOpEvapMin.SetOperation("-")
            clsReduceOpEvapMin.AddParameter("first", strReplaceNAMin, iPosition:=0)
            clsReduceOpEvapMin.AddParameter("second", strEvapReplaceNA, iPosition:=1)
            clsReduceFunctionMin.AddParameter("replace_na", clsROperatorParameter:=clsReduceOpEvapMin, iPosition:=1, bIncludeArgumentName:=False)
            clsWBWaterBalanceMinList.AddParameter("sub2", clsRFunctionParameter:=clsEvaporationReplaceNA, bIncludeArgumentName:=False)

            clsReduceOpEvapMax.SetOperation("-")
            clsReduceOpEvapMax.AddParameter("first", strReplaceNAMax, iPosition:=0)
            clsReduceOpEvapMax.AddParameter("second", strEvapReplaceNA, iPosition:=1)
            clsReduceFunctionMax.AddParameter("replace_na", clsROperatorParameter:=clsReduceOpEvapMax, iPosition:=1, bIncludeArgumentName:=False)
            clsWaterBalanceMaxList.AddParameter("sub2", clsRFunctionParameter:=clsEvaporationReplaceNA, bIncludeArgumentName:=False)

            clsPMaxOperatorMax.RemoveParameterByName("evaporation")
            clsPMaxOperatorMin.RemoveParameterByName("evaporation")
        End If
    End Sub

    Private Sub ucrChkEndofRainsDoy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsDoy.ControlValueChanged, ucrChkEndOfRains.ControlValueChanged
        If ucrChkEndOfRains.Checked Then
            If ucrChkEndofRainsDoy.Checked Then
                clsEORFilterList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainLastInstance, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsEORFilterList.RemoveParameterByName("sub1")
            End If
        Else
            clsEORFilterList.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrChkEndofRainsDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsDate.ControlValueChanged, ucrChkEndOfRains.ControlValueChanged
        If ucrChkEndOfRains.Checked Then
            clsListManipulations.AddParameter("manip2", clsRFunctionParameter:=clsEndOfRainsFilter, bIncludeArgumentName:=False, iPosition:=1)
            If ucrChkEndofRainsDate.Checked Then
                clsEORFilterList.AddParameter("sub2", clsRFunctionParameter:=clsEndOfRainsDateFunction, bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsEORFilterList.RemoveParameterByName("sub2")
            End If
        Else
            clsListManipulations.RemoveParameterByName("manip2")
            clsEORFilterList.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkEndofRainsOccurence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsOccurence.ControlValueChanged, ucrChkEndOfRains.ControlValueChanged
        If ucrChkEndOfRains.Checked Then
            clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEOREndFunction, bIncludeArgumentName:=False, iPosition:=0)
            If ucrChkEndofRainsOccurence.Checked Then
                clsSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsEORStatusFunction, bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsSubCalcList.RemoveParameterByName("sub2")
            End If
        Else
            clsSubCalcList.RemoveParameterByName("sub1")
            clsSubCalcList.RemoveParameterByName("sub2")
        End If
    End Sub
End Class