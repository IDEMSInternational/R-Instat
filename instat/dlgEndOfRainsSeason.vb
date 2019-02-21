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
    Private strCurrDataName As String = ""

#Region "general_code_structures"
    ' General
    Private clsRunCalculation As New RFunction

    ' Group by
    Private clsGroupByStationYearCalc As New RFunction
    Private clsGroupByStationCalc As New RFunction

    ' Doy filter
    Private clsDoyFilterCalcFromConvert As New RFunction
    Private clsDoyFilterCalcFromList As New RFunction
    Private clsDoyFilterCalc As New RFunction
    Private clsDoyFilterOperator As New ROperator
    Private clsDayFromOperator As New ROperator
    Private clsDayToOperator As New ROperator
#End Region

#Region "end_of_rains_code_structures"
    ' Rolling sum rain
    Private clsEndRainsRollingSumCalc As New RFunction
    Private clsRollSumRainFunction As New RFunction

    ' Conditions filter
    Private clsEndRainsConditionsFilterCalc As New RFunction
    Private clsEndRainsConditionsFilterSubCalcsList As New RFunction
    Private clsEndRainsConditionsOperator As New ROperator
    Private clsEndRainsRollSumRainConditionOperator As New ROperator
    Private clsIsNaRollSumRain As New RFunction

    ' Doy summary
    Private clsEndRainsLastDoySummaryCalc As New RFunction
    Private clsIfElseLastDoyFunction As New RFunction
    Private clsIsNaLastRollSumRain As New RFunction
    Private clsLastDoyFunction As New RFunction
    Private clsLastRollSumRainFunction As New RFunction

    ' Date summary
    Private clsEndRainsLastDateSummaryCalc As New RFunction
    Private clsIfElseLastDateFunction As New RFunction
    Private clsLastDateFunction As New RFunction

    ' Status summary
    Private clsEndRainsStatusSummaryCalc As New RFunction

    ' Combination
    Private clsEndRainsCombinationCalc As New RFunction
    Private clsEndRainsCombinationManipulationList As New RFunction
    Private clsEndRainsCombinationSubCalcList As New RFunction
#End Region

    Private clsWaterBalanceOperator, clsDifferenceOperation As New ROperator
    '60
    Private clsWBReplaceNAMax, clsWBReplaceNAMaxFunction, clsWBReplaceNAMaxFunctionList, clsWBWaterBalanceMax, clsWBWaterFilterMax, clsWBWaterFilterMaxList, clsWBFirstWaterBalanceMax, clsWBFirstWaterBalanceManipulationMax, clsWaterBalanceMaxList, clsReduceFunctionMax, clsPMinFunctionMax, clsPMaxFunctionMax As New RFunction
    Private clsWBWaterFilterMaxOperator, clsPMaxOperatorMax As New ROperator
    Private clsFirstWBMAx As New RFunction
    '0
    Private clsWBReplaceNAMin, clsWBReplaceNAMinFunction, clsWBReplaceNAMinFunctionList, clsWBWaterBalanceMin, clsWBWaterFilterMin, clsWBWaterFilterMinList, clsWBFirstWaterBalanceMin, clsWBFirstWaterBalanceMinList, clsWBWaterBalanceMinList, clsReduceFunctionMin, clsPMinFunctionMin, clsPMaxFunctionMin As New RFunction
    Private clsEvaporationReplaceNAFunc, clsEvaporationReplaceNA, clsEvaporationReplaceNAFuncList As New RFunction
    Private clsReduceOpEvapMin, clsReduceOpEvapMax As New ROperator

    Private clsWBWaterFilterMinOperator, clsPMaxOperatorMin As New ROperator
    Private clsFirstWBMin As New RFunction

    Private clsCombinationBase, clsWaterBalanceList, clsWaterBalanceFunction, clsWaterBalance As New RFunction
    Private clsDifference, clsDifferenceList As New RFunction
    Private clsEndOfSeasonFilter, clsEOSFilterList, clsEOSIfElseFunc, clsEOSIsNA, clsEOSEndFunction, clsEOSStatusFunction As New RFunction
    Private clsLessEOSEqualOperator, clsSquareEOSBracketOpertor As New ROperator
    Private clsIfEOSIfelsefunc, clsEORIsNAFunc As New RFunction
    Private clsEOSEndSummary As New clsRains
    Private clsEOSStatusSummary As New clsRains

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

        'TODO temp disabled until reworked to deal with missing values
        ucrChkEndOfSeason.Enabled = False

        ucrSelectorForWaterBalance.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForWaterBalance.SetParameterIsString()

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForWaterBalance
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("x", 0))
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
        ucrReceiverRainfall.SetMeAsReceiver()

        ucrReceiverYear.Selector = ucrSelectorForWaterBalance
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverEvaporation.SetParameter(New RParameter("x", 0))
        ucrReceiverEvaporation.Selector = ucrSelectorForWaterBalance
        ucrReceiverEvaporation.SetParameterIsString()
        ucrReceiverEvaporation.bWithQuotes = False

        'WATER BALANCE
        ucrChkEndOfSeason.SetParameter(New RParameter("sub_water_balance", clsWaterBalance, 0, bNewIncludeArgumentName:=False), False)
        ucrChkEndOfSeason.SetText("End of Season")

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
        ucrInputSeasonDoy.SetName("end_season")
        ucrInputSeasonDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrInputSeasonDoy.SetValidationTypeAsRVariable()

        ' End of Rains
        'TODO Set conditions for end of rains vs end of season
        ucrChkEndOfRains.SetText("End of Rains")
        ucrChkEndOfRains.AddToLinkedControls(ucrNudAmount, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndOfRains.AddToLinkedControls(ucrNudTotalOverDays, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndOfRains.AddToLinkedControls(ucrChkEndofRainsDoy, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudAmount.SetParameter(New RParameter("threshold", 1, False))
        ucrNudAmount.SetMinMax() ' min and max
        ucrNudAmount.DecimalPlaces = 2
        ucrNudAmount.Increment = 0.1
        ucrNudAmount.SetLinkedDisplayControl(lblAmount)

        ucrNudTotalOverDays.SetParameter(New RParameter("n", 1))
        ucrNudTotalOverDays.SetMinMax(1, 366)
        ucrNudTotalOverDays.SetLinkedDisplayControl(lblTotalOverDays)

        ucrChkEndofRainsDoy.AddToLinkedControls(ucrInputEndRainDoy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofRainsDoy.SetText("Day")
        ucrChkEndofRainsDoy.AddParameterPresentCondition(True, "sub1", True)
        ucrChkEndofRainsDoy.AddParameterPresentCondition(False, "sub1", False)
        ucrChkEndofRainsDoy.SetLinkedDisplayControl(grpEndofRains)

        ucrInputEndRainDoy.SetParameter(New RParameter("result_name", 3))
        ucrInputEndRainDoy.SetValidationTypeAsRVariable()
        ucrInputEndRainDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofRainsDate.AddToLinkedControls(ucrInputEndofRainsDate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofRainsDate.SetText("Date")
        ucrChkEndofRainsDate.AddParameterPresentCondition(True, "sub2", True)
        ucrChkEndofRainsDate.AddParameterPresentCondition(False, "sub2", False)

        ucrInputEndofRainsDate.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofRainsDate.SetValidationTypeAsRVariable()
        ucrInputEndofRainsDate.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofRainsOccurence.AddToLinkedControls(ucrInputEndofRainsOccurence, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofRainsOccurence.SetText("Occurrence")
        ucrChkEndofRainsOccurence.AddParameterPresentCondition(True, "sub3", True)
        ucrChkEndofRainsOccurence.AddParameterPresentCondition(False, "sub3", False)

        ucrInputEndofRainsOccurence.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofRainsOccurence.SetValidationTypeAsRVariable()
        ucrInputEndofRainsOccurence.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        'end season
        ucrChkEndofSeasonDoy.AddToLinkedControls(ucrInputSeasonDoy, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonDoy.SetText("Day")

        ucrChkEndofSeasonDate.AddToLinkedControls(ucrInputEndofSeasonDate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonDate.SetText("Date")

        ucrChkEndofSeasonOccurence.AddToLinkedControls(ucrInputEndofSeasonOccurence, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="end_seasonl")
        ucrChkEndofSeasonOccurence.SetText("Occurrence")
        ucrChkEndofSeasonOccurence.AddParameterPresentCondition(True, "sub3", True)
        ucrChkEndofSeasonOccurence.AddParameterPresentCondition(False, "sub3", False)

        ucrInputEndofSeasonOccurence.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofSeasonOccurence.SetName("end_rainl")
        ucrInputEndofSeasonOccurence.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        Dim strWaterBalanceMax As String = "water_balance_max"
        Dim strFirstWaterBalanceMax As String = "first_water_balance_max"
        Dim strFirstWaterBalanceMin As String = "first_water_balance_min"
        Dim strWaterBalanceMin As String = "water_balance_min"
        Dim strDifference As String = "difference"
        Dim strConditionsFilter As String = "conditions_filter"
        Dim strRollSumRain As String = "roll_sum_rain"
        Dim strEndRains As String = "end_rains"
        Dim strEndRainsStatus As String = "end_rains_status"
        Dim strEndRainsDate As String = "end_rains_date"
        Dim strEndSeason As String = "end_season"
        Dim strEndSeasonStatus As String = "end_season_status"
        Dim strDoyFilter As String = "doy_filter"

#Region "clear_code_structures"
        ' General
        clsRunCalculation.Clear()

        '   Group by
        clsGroupByStationYearCalc.Clear()
        clsGroupByStationCalc.Clear()

        '   Doy filter
        clsDoyFilterCalcFromConvert.Clear()
        clsDoyFilterCalcFromList.Clear()
        clsDoyFilterCalc.Clear()
        clsDoyFilterOperator.Clear()
        clsDayFromOperator.Clear()
        clsDayToOperator.Clear()

        ' End of rains code structures
        '   Rolling sum rain
        clsEndRainsRollingSumCalc.Clear()
        clsRollSumRainFunction.Clear()

        '   Conditions filter
        clsEndRainsConditionsFilterCalc.Clear()
        clsEndRainsConditionsFilterSubCalcsList.Clear()
        clsEndRainsConditionsOperator.Clear()
        clsEndRainsRollSumRainConditionOperator.Clear()
        clsIsNaRollSumRain.Clear()

        '   Doy summary
        clsEndRainsLastDoySummaryCalc.Clear()
        clsIfElseLastDoyFunction.Clear()
        clsIsNaLastRollSumRain.Clear()
        clsLastDoyFunction.Clear()
        clsLastRollSumRainFunction.Clear()

        '   Date summary
        clsEndRainsLastDateSummaryCalc.Clear()
        clsIfElseLastDateFunction.Clear()
        clsLastDateFunction.Clear()

        '   Status summary
        clsEndRainsStatusSummaryCalc.Clear()

        '   Combination
        clsEndRainsCombinationCalc.Clear()
        clsEndRainsCombinationManipulationList.Clear()
        clsEndRainsCombinationSubCalcList.Clear()
#End Region

        ucrSelectorForWaterBalance.Reset()
        ucrReceiverRainfall.SetMeAsReceiver()

        ' Group by
        clsGroupByStationYearCalc.SetRCommand("instat_calculation$new")
        clsGroupByStationYearCalc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationYearCalc.SetAssignTo("grouping_by_station_year")

        clsGroupByStationCalc.SetRCommand("instat_calculation$new")
        clsGroupByStationCalc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationCalc.SetAssignTo("grouping_by_station")

        ' Doy Filter
        clsDoyFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDoyFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDoyFilterCalcFromList, iPosition:=0)

        clsDoyFilterCalcFromList.SetRCommand("list")

        clsDoyFilterCalc.SetRCommand("instat_calculation$new")
        clsDoyFilterCalc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDoyFilterCalc.AddParameter("function_exp", clsROperatorParameter:=clsDoyFilterOperator, iPosition:=1)
        clsDoyFilterCalc.AddParameter("calculated_from", clsRFunctionParameter:=clsDoyFilterCalcFromConvert, iPosition:=2)
        clsDoyFilterCalc.SetAssignTo(strDoyFilter)

        clsDoyFilterOperator.SetOperation("&")
        clsDoyFilterOperator.AddParameter("from_operator", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDoyFilterOperator.AddParameter("to_operator", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDoyFilterOperator.bBrackets = False
        clsDoyFilterOperator.bToScriptAsRString = True

        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)

        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)

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

        clsWBFirstWaterBalanceMax.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMax.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsWBFirstWaterBalanceMax.AddParameter("function_exp", clsRFunctionParameter:=clsFirstWBMAx, iPosition:=1)

        clsFirstWBMAx.SetPackageName("dplyr")
        clsFirstWBMAx.SetRCommand("first")
        clsFirstWBMAx.bToScriptAsRString = True

        clsWBFirstWaterBalanceMax.AddParameter("result_name", Chr(34) & strFirstWaterBalanceMax & Chr(34), iPosition:=2)
        clsWBFirstWaterBalanceManipulationMax.SetRCommand("list")
        clsWBFirstWaterBalanceMax.AddParameter("manipulations", clsRFunctionParameter:=clsWBFirstWaterBalanceManipulationMax, iPosition:=5)
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub1", clsRFunctionParameter:=clsGroupByStationYearCalc, bIncludeArgumentName:=False, iPosition:=0)
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub2", clsRFunctionParameter:=clsWBWaterFilterMax, bIncludeArgumentName:=False, iPosition:=1)
        clsWBFirstWaterBalanceManipulationMax.AddParameter("sub3", clsRFunctionParameter:=clsDoyFilterCalc, bIncludeArgumentName:=False, iPosition:=2)
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

        clsWBWaterFilterMin.SetRCommand("instat_calculation$new")
        clsWBWaterFilterMin.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsWBWaterFilterMin.AddParameter("function_exp", clsROperatorParameter:=clsWBWaterFilterMinOperator, iPosition:=1)
        clsWBWaterFilterMin.AddParameter("sub_calculations", clsRFunctionParameter:=clsWBWaterFilterMinList, iPosition:=4)
        clsWBWaterFilterMin.SetAssignTo("water_filter_min")

        clsWBWaterFilterMinOperator.SetOperation("<=")
        clsWBWaterFilterMinOperator.AddParameter("x", strWaterBalanceMin, iPosition:=0)
        clsWBWaterFilterMinOperator.AddParameter("rightMaxMin", 0.5, iPosition:=1)
        clsWBWaterFilterMinOperator.bToScriptAsRString = True

        clsWBWaterFilterMinList.SetRCommand("list")
        clsWBWaterFilterMinList.AddParameter("sub1", clsRFunctionParameter:=clsWBWaterBalanceMin)

        clsWBFirstWaterBalanceMin.SetRCommand("instat_calculation$new")
        clsWBFirstWaterBalanceMin.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsWBFirstWaterBalanceMin.AddParameter("function_exp", clsRFunctionParameter:=clsFirstWBMin, iPosition:=1)
        clsWBFirstWaterBalanceMin.AddParameter("result_name", Chr(34) & strFirstWaterBalanceMin & Chr(34), iPosition:=3)
        clsWBFirstWaterBalanceMin.AddParameter("manipulations", clsRFunctionParameter:=clsWBFirstWaterBalanceMinList, iPosition:=5)
        clsWBFirstWaterBalanceMin.SetAssignTo(strFirstWaterBalanceMin)

        clsFirstWBMin.SetPackageName("dplyr")
        clsFirstWBMin.SetRCommand("first")
        clsFirstWBMin.bToScriptAsRString = True

        clsWBFirstWaterBalanceMinList.SetRCommand("list")
        clsWBFirstWaterBalanceMinList.AddParameter("sub1", clsRFunctionParameter:=clsGroupByStationYearCalc, bIncludeArgumentName:=False, iPosition:=0)
        clsWBFirstWaterBalanceMinList.AddParameter("sub2", clsRFunctionParameter:=clsWBWaterFilterMin, bIncludeArgumentName:=False, iPosition:=1)
        clsWBFirstWaterBalanceMinList.AddParameter("sub3", clsRFunctionParameter:=clsDoyFilterCalc, bIncludeArgumentName:=False, iPosition:=2)

        clsDifference.SetRCommand("instat_calculation$new")
        clsDifference.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDifference.AddParameter("function_exp", clsROperatorParameter:=clsDifferenceOperation, iPosition:=1)
        clsDifference.AddParameter("result_name", Chr(34) & strDifference & Chr(34), iPosition:=2)
        clsDifference.AddParameter("sub_calculations", clsRFunctionParameter:=clsDifferenceList, iPosition:=4)
        clsDifference.SetAssignTo("difference_calculation")

        clsDifferenceOperation.SetOperation("-")
        clsDifferenceOperation.AddParameter("left", strFirstWaterBalanceMin, iPosition:=0)
        clsDifferenceOperation.AddParameter("right", strFirstWaterBalanceMax, iPosition:=1)
        clsDifferenceOperation.bToScriptAsRString = True

        clsDifferenceList.SetRCommand("list")
        clsDifferenceList.AddParameter("sub1", clsRFunctionParameter:=clsWBFirstWaterBalanceMin, bIncludeArgumentName:=False, iPosition:=0)
        clsDifferenceList.AddParameter("sub2", clsRFunctionParameter:=clsWBFirstWaterBalanceMax, bIncludeArgumentName:=False, iPosition:=1)

        'Difference
        clsWaterBalanceList.SetRCommand("list")
        clsWaterBalanceList.AddParameter("sub1", clsRFunctionParameter:=clsWBFirstWaterBalanceMin, iPosition:=0, bIncludeArgumentName:=False)
        clsWaterBalanceList.AddParameter("sub2", clsRFunctionParameter:=clsDifference, iPosition:=1, bIncludeArgumentName:=False)

        clsWaterBalance.SetRCommand("instat_calculation$new")
        clsWaterBalance.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsWaterBalance.AddParameter("function_exp", clsRFunctionParameter:=clsWaterBalanceFunction, iPosition:=1)
        'Chr(34) & "replace(" & strFirstWaterBalanceMin & ", Difference != 0, NA)" & Chr(34), iPosition:=1)
        clsWaterBalance.AddParameter("result_name", Chr(34) & ucrInputSeasonDoy.GetText() & Chr(34), iPosition:=2)
        clsWaterBalance.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalanceList, iPosition:=4)
        clsWaterBalance.AddParameter("save", "2", iPosition:=6)
        clsWaterBalance.SetAssignTo("water_balance_calculation")

        clsWaterBalanceFunction.SetRCommand("replace")
        clsWaterBalanceFunction.AddParameter("x", strFirstWaterBalanceMin, iPosition:=0)
        clsWaterBalanceFunction.AddParameter("list", strDifference & "!= 0", iPosition:=1) 'clsROperatorParameter:=clsWaterBalanceOperator, iPosition:=1)
        clsWaterBalanceFunction.AddParameter("values", "NA", iPosition:=2)
        clsWaterBalanceFunction.bToScriptAsRString = True

#Region "end_of_rains"

        ' Rolling sum calculation
        clsEndRainsRollingSumCalc.SetRCommand("instat_calculation$new")
        clsEndRainsRollingSumCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndRainsRollingSumCalc.AddParameter("function_exp", clsRFunctionParameter:=clsRollSumRainFunction, iPosition:=1)
        clsEndRainsRollingSumCalc.AddParameter("result_name", Chr(34) & strRollSumRain & Chr(34), iPosition:=2)
        clsEndRainsRollingSumCalc.SetAssignTo(strRollSumRain)

        clsRollSumRainFunction.SetPackageName("RcppRoll")
        clsRollSumRainFunction.SetRCommand("roll_sumr")
        clsRollSumRainFunction.AddParameter("n", 1, iPosition:=1)
        clsRollSumRainFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollSumRainFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRollSumRainFunction.bToScriptAsRString = True

        ' Conditions filter
        clsEndRainsConditionsFilterCalc.SetRCommand("instat_calculation$new")
        clsEndRainsConditionsFilterCalc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsEndRainsConditionsFilterCalc.AddParameter("function_exp", clsROperatorParameter:=clsEndRainsConditionsOperator, iPosition:=1)
        clsEndRainsConditionsFilterCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainsConditionsFilterSubCalcsList, iPosition:=4)
        clsEndRainsConditionsFilterCalc.SetAssignTo(strConditionsFilter)

        clsEndRainsConditionsFilterSubCalcsList.SetRCommand("list")
        clsEndRainsConditionsFilterSubCalcsList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainsRollingSumCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsEndRainsConditionsOperator.SetOperation("|")
        clsEndRainsConditionsOperator.AddParameter("0", clsROperatorParameter:=clsEndRainsRollSumRainConditionOperator, iPosition:=0)
        clsEndRainsConditionsOperator.AddParameter("1", clsRFunctionParameter:=clsIsNaRollSumRain, iPosition:=1)
        clsEndRainsConditionsOperator.bToScriptAsRString = True

        clsEndRainsRollSumRainConditionOperator.SetOperation(">")
        clsEndRainsRollSumRainConditionOperator.AddParameter("left", strRollSumRain, iPosition:=0)
        clsEndRainsRollSumRainConditionOperator.AddParameter("threshold", 10, iPosition:=1)

        clsIsNaRollSumRain.SetRCommand("is.na")
        clsIsNaRollSumRain.AddParameter("x", strRollSumRain, iPosition:=0)

        ' Doy summary
        clsEndRainsLastDoySummaryCalc.SetRCommand("instat_calculation$new")
        clsEndRainsLastDoySummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndRainsLastDoySummaryCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseLastDoyFunction, iPosition:=1)
        clsEndRainsLastDoySummaryCalc.AddParameter("result_name", Chr(34) & strEndRains & Chr(34), iPosition:=2)
        clsEndRainsLastDoySummaryCalc.AddParameter("save", "2", iPosition:=6)
        clsEndRainsLastDoySummaryCalc.SetAssignTo(strEndRains)

        clsIfElseLastDoyFunction.SetRCommand("ifelse")
        clsIfElseLastDoyFunction.AddParameter("test", clsRFunctionParameter:=clsIsNaLastRollSumRain, iPosition:=0)
        clsIfElseLastDoyFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfElseLastDoyFunction.AddParameter("no", clsRFunctionParameter:=clsLastDoyFunction, iPosition:=2)
        clsIfElseLastDoyFunction.bToScriptAsRString = True

        clsIsNaLastRollSumRain.SetRCommand("is.na")
        clsIsNaLastRollSumRain.AddParameter("x", clsRFunctionParameter:=clsLastRollSumRainFunction, iPosition:=0)

        clsLastRollSumRainFunction.SetPackageName("dplyr")
        clsLastRollSumRainFunction.SetRCommand("last")
        clsLastRollSumRainFunction.AddParameter("x", strRollSumRain, iPosition:=0)

        clsLastDoyFunction.SetPackageName("dplyr")
        clsLastDoyFunction.SetRCommand("last")

        ' Date summary
        clsEndRainsLastDateSummaryCalc.SetRCommand("instat_calculation$new")
        clsEndRainsLastDateSummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndRainsLastDateSummaryCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseLastDateFunction, iPosition:=1)
        clsEndRainsLastDateSummaryCalc.AddParameter("result_name", Chr(34) & strEndRainsDate & Chr(34), iPosition:=2)
        clsEndRainsLastDateSummaryCalc.AddParameter("save", 2)
        clsEndRainsLastDateSummaryCalc.SetAssignTo(strEndRainsDate)

        clsIfElseLastDateFunction.SetPackageName("dplyr")
        clsIfElseLastDateFunction.SetRCommand("if_else")
        clsIfElseLastDateFunction.AddParameter("condition", clsRFunctionParameter:=clsIsNaLastRollSumRain, iPosition:=0)
        clsIfElseLastDateFunction.AddParameter("true", "as.Date(NA)", iPosition:=1)
        clsIfElseLastDateFunction.AddParameter("false", clsRFunctionParameter:=clsLastDateFunction, iPosition:=2)
        clsIfElseLastDateFunction.bToScriptAsRString = True

        clsLastDateFunction.SetPackageName("dplyr")
        clsLastDateFunction.SetRCommand("last")

        ' Status summary
        clsEndRainsStatusSummaryCalc.SetRCommand("instat_calculation$new")
        clsEndRainsStatusSummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndRainsStatusSummaryCalc.AddParameter("function_exp", Chr(34) & "n() > 0" & Chr(34), iPosition:=1)
        clsEndRainsStatusSummaryCalc.AddParameter("result_name", Chr(34) & strEndRainsStatus & Chr(34), iPosition:=3)
        clsEndRainsStatusSummaryCalc.AddParameter("save", 2, iPosition:=4)
        clsEndRainsStatusSummaryCalc.SetAssignTo(strEndRainsStatus)

        ' Combined
        clsEndRainsCombinationCalc.SetRCommand("instat_calculation$new")
        clsEndRainsCombinationCalc.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsEndRainsCombinationCalc.AddParameter("manipulations", clsRFunctionParameter:=clsEndRainsCombinationManipulationList, iPosition:=1)
        clsEndRainsCombinationCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainsCombinationSubCalcList, iPosition:=2)
        clsEndRainsCombinationCalc.SetAssignTo("end_of_rains_combined")

        clsEndRainsCombinationManipulationList.SetRCommand("list")
        clsEndRainsCombinationManipulationList.AddParameter("manip1", clsRFunctionParameter:=clsEndRainsConditionsFilterCalc, bIncludeArgumentName:=False, iPosition:=0)
        clsEndRainsCombinationManipulationList.AddParameter("manip2", clsRFunctionParameter:=clsGroupByStationYearCalc, bIncludeArgumentName:=False, iPosition:=1)
        clsEndRainsCombinationManipulationList.AddParameter("manip3", clsRFunctionParameter:=clsDoyFilterCalc, bIncludeArgumentName:=False, iPosition:=2)

        clsEndRainsCombinationSubCalcList.SetRCommand("list")
        clsEndRainsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainsLastDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)

        clsRunCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalculation.AddParameter("display", "FALSE")
        clsRunCalculation.AddParameter("calc", clsRFunctionParameter:=clsEndRainsCombinationCalc)

        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalculation)
#End Region

        clsLessEOSEqualOperator.SetOperation("<=")
        clsLessEOSEqualOperator.bToScriptAsRString = True
        clsLessEOSEqualOperator.AddParameter("ifelse", clsRFunctionParameter:=clsEOSIfElseFunc, bIncludeArgumentName:=False, iPosition:=1)

        clsEOSIfElseFunc.SetRCommand("ifelse")
        clsEOSIfElseFunc.AddParameter("is.na", clsRFunctionParameter:=clsEOSIsNA, bIncludeArgumentName:=False, iPosition:=0)
        clsEOSIfElseFunc.AddParameter("366", 366, bIncludeArgumentName:=False, iPosition:=1)
        clsEOSIfElseFunc.AddParameter("end_season", clsROperatorParameter:=clsSquareEOSBracketOpertor, bIncludeArgumentName:=False, iPosition:=2)

        clsEOSIsNA.SetRCommand("is.na")
        clsEOSIsNA.AddParameter("end_season", clsROperatorParameter:=clsSquareEOSBracketOpertor, bIncludeArgumentName:=False)

        clsSquareEOSBracketOpertor.SetOperation("[1")
        clsSquareEOSBracketOpertor.bSpaceAroundOperation = False
        clsSquareEOSBracketOpertor.AddParameter("end_season", strEndSeason, bIncludeArgumentName:=False, iPosition:=0)
        clsSquareEOSBracketOpertor.AddParameter("bracket", "]", bIncludeArgumentName:=False, iPosition:=1)

        clsEndOfSeasonFilter.SetRCommand("instat_calculation$new")
        clsEndOfSeasonFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsEndOfSeasonFilter.AddParameter("function_exp", clsROperatorParameter:=clsLessEOSEqualOperator, iPosition:=1)
        clsEndOfSeasonFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsEOSFilterList, iPosition:=4)
        clsEndOfSeasonFilter.SetAssignTo("end_of_season_filter")

        clsEOSFilterList.SetRCommand("list")
        clsEOSFilterList.AddParameter("sub1", clsRFunctionParameter:=clsWaterBalance, bIncludeArgumentName:=False, iPosition:=0)

        clsEOSEndSummary.SetDefaults()
        clsEOSEndSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=strEndSeason, bIncludeArgumentName:=False, iPosition:=0)

        clsEOSStatusSummary.SetDefaults()
        clsEOSStatusSummary.clsIsNaIfelse.bToScriptAsRString = True
        clsEOSStatusSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=strEndSeason, bIncludeArgumentName:=False, iPosition:=0)

        clsIfEOSIfelsefunc.SetRCommand("ifelse")
        clsIfEOSIfelsefunc.bToScriptAsRString = True
        clsIfEOSIfelsefunc.AddParameter("ifelse", clsRFunctionParameter:=clsEORIsNAFunc, bIncludeArgumentName:=False, iPosition:=0)
        clsIfEOSIfelsefunc.AddParameter("NA", "NA", bIncludeArgumentName:=False, iPosition:=1)
        clsIfEOSIfelsefunc.AddParameter("end_season", clsROperatorParameter:=clsSquareEOSBracketOpertor, bIncludeArgumentName:=False, iPosition:=2)

        clsEORIsNAFunc.SetRCommand("is.na")
        clsEORIsNAFunc.AddParameter("ifelse", clsRFunctionParameter:=clsEOSEndSummary.clsIsNaIfelse, bIncludeArgumentName:=False)

        clsEOSEndFunction.SetRCommand("instat_calculation$new")
        clsEOSEndFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEOSEndFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfEOSIfelsefunc, iPosition:=1)
        clsEOSEndFunction.AddParameter("result_name", Chr(34) & strEndSeason & Chr(34), iPosition:=3)
        clsEOSEndFunction.AddParameter("save", 2, iPosition:=4)
        clsEOSEndFunction.SetAssignTo("end_of_season_end")

        clsEOSStatusFunction.SetRCommand("instat_calculation$new")
        clsEOSStatusFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEOSStatusFunction.AddParameter("function_exp", clsRFunctionParameter:=clsEOSStatusSummary.clsIsNaIfelse, iPosition:=1)
        clsEOSStatusFunction.AddParameter("result_name", Chr(34) & strEndSeasonStatus & Chr(34), iPosition:=3)
        clsEOSStatusFunction.AddParameter("save", 2, iPosition:=4)
        clsEOSStatusFunction.SetAssignTo("end_of_season_status")

        clsCombinationBase.SetRCommand("instat_calculation$new")
        clsCombinationBase.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        'clsCombinationBase.AddParameter("manipulations", clsRFunctionParameter:=clsListManipulations, iPosition:=1)
        'clsCombinationBase.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndRainsCombinationSubCalcList, iPosition:=2)
        clsCombinationBase.SetAssignTo("end_of_rains_season_combined")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstWBMAx, New RParameter("doy", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstWBMin, New RParameter("doy", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLastDoyFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLessEOSEqualOperator, New RParameter("day", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunctionList, New RParameter("x", 0, False), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunctionList, New RParameter("x", 0, False), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsWBReplaceNAMinFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRollSumRainFunction, New RParameter("x", 0), iAdditionalPairNo:=4)

        'clsEOSEndSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=5)
        'clsEOSStatusSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=6)

        ucrNudWBLessThan.AddAdditionalCodeParameterPair(clsWBWaterFilterMinOperator, ucrNudWBLessThan.GetParameter(), iAdditionalPairNo:=1)
        ucrInputEvaporation.AddAdditionalCodeParameterPair(clsPMaxOperatorMax, New RParameter("evaporation", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsWBReplaceNAMaxFunction, ucrNudCapacity.GetParameter(), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsPMinFunctionMin, ucrNudCapacity.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverEvaporation.AddAdditionalCodeParameterPair(clsEvaporationReplaceNAFuncList, New RParameter("x", 0, False), iAdditionalPairNo:=1)
        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        ucrInputEndRainDoy.SetRCode(clsEndRainsLastDoySummaryCalc, bReset)
        ucrInputSeasonDoy.SetRCode(clsWaterBalance, bReset)
        ucrInputEndofRainsDate.SetRCode(clsEndRainsLastDateSummaryCalc, bReset)
        ucrInputEndofRainsOccurence.SetRCode(clsEndRainsStatusSummaryCalc, bReset)
        ucrInputEndofSeasonOccurence.SetRCode(clsEOSStatusFunction, bReset)

        'ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        'ucrInputSum.SetRCode(clsMatchFun, bReset)
        'ucrInputColName.SetRCode(clsRWater_bal, bReset)

        ucrReceiverDate.SetRCode(clsLastDateFunction, bReset)
        ucrReceiverEvaporation.SetRCode(clsEvaporationReplaceNAFunc, bReset)
        ucrInputReplaceNA.SetRCode(clsEvaporationReplaceNAFunc, bReset)

        ' Water Balance:
        ucrChkEndOfSeason.SetRCode(clsEndRainsCombinationSubCalcList, bReset)
        ucrReceiverRainfall.SetRCode(clsWBReplaceNAMaxFunction, bReset)
        ucrChkEndofSeasonOccurence.SetRCode(clsEndRainsCombinationSubCalcList, bReset)

        ucrNudWBLessThan.SetRCode(clsWBWaterFilterMaxOperator, bReset)

        ucrInputEvaporation.SetRCode(clsPMaxOperatorMin, bReset)
        ucrNudCapacity.SetRCode(clsPMinFunctionMax, bReset)

        'EoR
        ucrNudAmount.SetRCode(clsEndRainsRollSumRainConditionOperator, bReset)
        ucrNudTotalOverDays.SetRCode(clsRollSumRainFunction, bReset)
        ucrChkEndofRainsDoy.SetRCode(clsEndRainsCombinationSubCalcList, bReset)
        ucrChkEndofRainsDate.SetRCode(clsEndRainsCombinationSubCalcList, bReset)
        ucrChkEndofRainsOccurence.SetRCode(clsEndRainsCombinationSubCalcList, bReset)

        'TODO temporary until these are converted to radio buttons
        If bReset Then
            ucrChkEndOfRains.Checked = True
            ucrChkEndOfRains.Checked = False
            ucrChkEndOfSeason.Checked = True
            ucrChkEndOfSeason.Checked = False
        End If
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean = True

        'TODO change to radio buttons so only one can be checked at a time
        If ucrChkEndOfRains.Checked AndAlso ucrChkEndOfSeason.Checked Then
            bOkEnabled = False
        ElseIf ucrChkEndOfRains.Checked Then
            If ucrReceiverRainfall.IsEmpty OrElse ucrReceiverDate.IsEmpty OrElse ucrReceiverDOY.IsEmpty OrElse ucrReceiverYear.IsEmpty OrElse ucrNudAmount.GetText = "" OrElse ucrNudTotalOverDays.GetText = "" Then
                bOkEnabled = False
            ElseIf Not (ucrChkEndofRainsDoy.Checked OrElse ucrChkEndofRainsDate.Checked OrElse ucrChkEndofRainsOccurence.Checked) Then
                bOkEnabled = False
            ElseIf ucrChkEndofRainsDoy.Checked AndAlso ucrInputEndRainDoy.IsEmpty Then
                bOkEnabled = False
            ElseIf ucrChkEndofRainsDate.Checked AndAlso ucrInputEndofRainsDate.IsEmpty Then
                bOkEnabled = False
            ElseIf ucrChkEndofRainsOccurence.Checked AndAlso ucrInputEndofRainsOccurence.IsEmpty Then
                bOkEnabled = False
            End If
        ElseIf ucrChkEndOfSeason.Checked Then
            If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrNudCapacity.GetText <> "" AndAlso ucrNudWBLessThan.GetText <> "" AndAlso ucrChkEndofSeasonDoy.Checked Then
                bOkEnabled = True
            Else
                bOkEnabled = False
            End If
            If ucrChkEndofSeasonDoy.Checked AndAlso ucrInputSeasonDoy.IsEmpty Then
                bOkEnabled = False
            ElseIf rdoValueEvaporation.Checked AndAlso ucrInputEvaporation.IsEmpty Then
                bOkEnabled = False
            ElseIf rdoVariableEvaporation.Checked AndAlso ucrReceiverEvaporation.IsEmpty OrElse ucrInputReplaceNA.IsEmpty Then
                bOkEnabled = False
            End If
        End If
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDoyFilterCalc, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDoyFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
        sdgDoyRange.ShowDialog()
        UpdateDayFilterPreview()
    End Sub

    Private Sub UpdateDayFilterPreview()
        If ucrReceiverDOY.IsEmpty Then
            ucrInputFilterPreview.SetName("")
        Else
            ucrInputFilterPreview.SetName(clsDoyFilterOperator.ToScript())
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub GroupingBy()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupByStationYearCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupByStationYearCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        End If
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByStationCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=2)
        Else
        End If
    End Sub

    Private Sub DayChange()
        clsWBFirstWaterBalanceMin.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsWBFirstWaterBalanceMax.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndRainsLastDoySummaryCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndRainsLastDateSummaryCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDate.GetVariableNames() & ")", iPosition:=3)
        clsEndOfSeasonFilter.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=2)
    End Sub

    Private Sub RainfallChange()
        clsWBReplaceNAMin.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsWBReplaceNAMax.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsEOSEndFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsEOSStatusFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
        clsEndRainsRollingSumCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrReceiverStationYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupingBy()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorForWaterBalance.ControlValueChanged
        If Not ucrReceiverDOY.IsEmpty Then
            clsDoyFilterCalcFromList.AddParameter(ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDoyFilterCalcFromList.RemoveParameterByName(ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrSelectorForSpells_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrSelectorForWaterBalance.ControlContentsChanged, ucrReceiverDOY.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupingBy()
        DayChange()
        RainfallChange()
    End Sub

    Private Sub ucrSelectorForWaterBalance_DataFrameChanged() Handles ucrSelectorForWaterBalance.DataFrameChanged
        clsDoyFilterCalcFromList.ClearParameters()
    End Sub

    Private Sub ucrPnlEvaporation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlEvaporation.ControlValueChanged, ucrReceiverEvaporation.ControlValueChanged, ucrInputEvaporation.ControlValueChanged, ucrInputReplaceNA.ControlValueChanged
        Evaporation()
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

    Private Sub ucrChkEndofRainsDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsDoy.ControlValueChanged, ucrChkEndofRainsDate.ControlValueChanged, ucrChkEndofRainsOccurence.ControlValueChanged
        If ucrChkEndofRainsDoy.Checked Then
            clsEndRainsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainsLastDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub1")
        End If
        If ucrChkEndofRainsDate.Checked Then
            clsEndRainsCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsEndRainsLastDateSummaryCalc, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub2")
        End If
        If ucrChkEndofRainsOccurence.Checked Then
            clsEndRainsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsEndRainsStatusSummaryCalc, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub3")
        End If

    End Sub

    Private Sub ucrChkEndofSeasonOccurence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofSeasonOccurence.ControlValueChanged, ucrChkEndOfSeason.ControlValueChanged
        If ucrChkEndOfSeason.Checked Then
            'clsListManipulations.AddParameter("manip3", clsRFunctionParameter:=clsEndOfSeasonFilter, bIncludeArgumentName:=False, iPosition:=2)
            'clsEndRainsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsEOSEndFunction, bIncludeArgumentName:=False, iPosition:=2)
            If ucrChkEndofSeasonOccurence.Checked Then
                'clsEndRainsCombinationSubCalcList.AddParameter("sub4", clsRFunctionParameter:=clsEOSStatusFunction, bIncludeArgumentName:=False, iPosition:=3)
            Else
                'clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub3")
            End If
        Else
            'clsListManipulations.RemoveParameterByName("manip3")
            'clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub3")
            'clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub4")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkEndOfRains.ControlContentsChanged, ucrChkEndOfSeason.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrNudCapacity.ControlContentsChanged, ucrNudWBLessThan.ControlContentsChanged, ucrInputSeasonDoy.ControlContentsChanged, ucrNudTotalOverDays.ControlContentsChanged, ucrNudAmount.ControlContentsChanged, ucrChkEndofRainsDoy.ControlContentsChanged, ucrInputEndRainDoy.ControlContentsChanged, ucrChkEndofRainsDate.ControlContentsChanged, ucrInputEndofRainsDate.ControlContentsChanged, ucrChkEndofRainsOccurence.ControlContentsChanged, ucrInputEndofRainsOccurence.ControlContentsChanged, ucrChkEndofSeasonDoy.ControlContentsChanged, ucrPnlEvaporation.ControlContentsChanged, ucrReceiverEvaporation.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrInputReplaceNA.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class