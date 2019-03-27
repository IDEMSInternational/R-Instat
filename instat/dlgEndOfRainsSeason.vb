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

Imports instat
Imports instat.Translations
Public Class dlgEndOfRainsSeason
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strRainMin As String = "rain_min"
    Private strRainMax As String = "rain_max"
    Private strWBMin As String = "wb_min"
    Private strWBMax As String = "wb_max"
    Private strWB As String = "wb"
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

#Region "end_of_season_code_structures"

    Private clsEndSeasonIsNaRain As New RFunction

    ' Rain min
    Private clsEndSeasonRainMinCalc As New RFunction
    Private clsIfElseRainMinFunction As New RFunction

    ' Rain max
    Private clsEndSeasonRainMaxCalc As New RFunction
    Private clsIfElseRainMaxFunction As New RFunction

    'Pmax
    Private clsPMaxFunction As New RFunction
    Private clsPMaxOperator As New ROperator

    ' Water Balance min
    Private clsEndSeasonWBMinCalc As New RFunction
    Private clsEndSeasonWBMinCalcSubCalcsList As New RFunction
    Private clsReduceWBMinFunction As New RFunction
    Private clsPMinWBMinFunction As New RFunction

    ' Water Balance max
    Private clsEndSeasonWBMaxCalc As New RFunction
    Private clsEndSeasonWBMaxCalcSubCalcsList As New RFunction
    Private clsReduceWBMaxFunction As New RFunction
    Private clsPMinWBMaxFunction As New RFunction

    ' Water Balance
    Private clsEndSeasonWBCalc As New RFunction
    Private clsEndSeasonWBCalcSubCalcsList As New RFunction
    Private clsIfElseWBFunction As New RFunction
    Private clsWBOperator As New ROperator
    Private clsWBMinMaxOperator As New ROperator

    ' Conditions filter
    Private clsEndSeasonConditionsFilterCalc As New RFunction
    Private clsEndSeasonConditionsFilterSubCalcsList As New RFunction
    Private clsEndSeasonConditionsOperator As New ROperator
    Private clsEndSeasonWBConditionOperator As New ROperator

    ' Doy summary
    Private clsEndSeasonFirstDoySummaryCalc As New RFunction
    Private clsIfElseFirstDoyFunction As New RFunction
    Private clsIsNaFirstWB As New RFunction
    Private clsFirstDoyFunction As New RFunction
    Private clsFirstWBFunction As New RFunction

    ' Date summary
    Private clsEndSeasonFirstDateSummaryCalc As New RFunction
    Private clsIfElseFirstDateFunction As New RFunction
    Private clsFirstDateFunction As New RFunction

    ' Status summary
    Private clsEndSeasonStatusSummaryCalc As New RFunction

    ' Combination
    Private clsEndSeasonCombinationCalc As New RFunction
    Private clsEndSeasonCombinationManipulationList As New RFunction
    Private clsEndSeasonCombinationSubCalcList As New RFunction
#End Region

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
#Region "general_controls"
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
#End Region

#Region "end_of_rains_controls"
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
#End Region

#Region "end_of_season_controls"
        ucrReceiverEvaporation.SetParameter(New RParameter("variable", 0, bNewIncludeArgumentName:=False))
        ucrReceiverEvaporation.Selector = ucrSelectorForWaterBalance
        ucrReceiverEvaporation.SetParameterIsString()
        ucrReceiverEvaporation.bWithQuotes = False

        'TODO Set conditions for end of rains vs end of season
        ucrChkEndOfSeason.SetText("End of Season")

        ucrPnlEvaporation.AddRadioButton(rdoValueEvaporation)
        ucrPnlEvaporation.AddRadioButton(rdoVariableEvaporation)
        ucrPnlEvaporation.AddToLinkedControls(ucrInputEvaporation, {rdoValueEvaporation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlEvaporation.AddToLinkedControls(ucrReceiverEvaporation, {rdoVariableEvaporation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEvaporation.AddToLinkedControls(ucrInputReplaceNA, {rdoVariableEvaporation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)

        ucrChkEndOfSeason.AddToLinkedControls(ucrNudCapacity, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=60)
        ucrChkEndOfSeason.AddToLinkedControls(ucrNudWBLessThan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrChkEndOfSeason.AddToLinkedControls(ucrPnlEvaporation, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoValueEvaporation)
        ucrChkEndOfSeason.AddToLinkedControls(ucrChkEndofSeasonDoy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrChkEndofSeasonDoy.SetLinkedDisplayControl(grpEndofSeason)

        ucrChkEndOfSeason.AddToLinkedControls(ucrNudWBLessThan, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrPnlEvaporation.SetLinkedDisplayControl(lblEvaporation)
        ucrInputReplaceNA.SetLinkedDisplayControl(lblReplaceNA)

        ucrInputEvaporation.SetParameter(New RParameter("value", 1, bNewIncludeArgumentName:=False))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False

        ucrInputReplaceNA.SetParameter(New RParameter("values", 2))
        ucrInputReplaceNA.SetValidationTypeAsNumeric()
        ucrInputReplaceNA.AddQuotesIfUnrecognised = False

        ucrNudWBLessThan.SetParameter(New RParameter("1", 1, False))
        ucrNudWBLessThan.SetMinMax(0, Integer.MaxValue)
        ucrNudWBLessThan.Increment = 0.5
        ucrNudWBLessThan.DecimalPlaces = 2
        ucrNudWBLessThan.SetLinkedDisplayControl(lblWaterBalanceLessThan)

        ucrNudCapacity.SetParameter(New RParameter("yes", 1))
        ucrNudCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudCapacity.Increment = 10
        ucrNudCapacity.SetLinkedDisplayControl(lblCapacity)

        ucrInputSeasonDoy.SetParameter(New RParameter("result_name", 3))
        ucrInputSeasonDoy.SetName("end_season")
        ucrInputSeasonDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrInputSeasonDoy.SetValidationTypeAsRVariable()

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
#End Region
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
        Dim strEndSeasonDate As String = "end_rains_date"
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

        ' End of season code structures
        clsEndSeasonIsNaRain.Clear()

        '   Rain min
        clsEndSeasonRainMinCalc.Clear()
        clsIfElseRainMinFunction.Clear()

        '   Rain max
        clsEndSeasonRainMaxCalc.Clear()
        clsIfElseRainMaxFunction.Clear()

        '   Pmax
        clsPMaxFunction.Clear()
        clsPMaxOperator.Clear()

        '   Water Balance min
        clsEndSeasonWBMinCalc.Clear()
        clsEndSeasonWBMinCalcSubCalcsList.Clear()
        clsReduceWBMinFunction.Clear()
        clsPMinWBMinFunction.Clear()

        '   Water Balance max
        clsEndSeasonWBMaxCalc.Clear()
        clsEndSeasonWBMaxCalcSubCalcsList.Clear()
        clsReduceWBMaxFunction.Clear()
        clsPMinWBMaxFunction.Clear()

        '   Water Balance
        clsEndSeasonWBCalc.Clear()
        clsEndSeasonWBCalcSubCalcsList.Clear()
        clsIfElseWBFunction.Clear()
        clsWBOperator.Clear()
        clsWBMinMaxOperator.Clear()

        '   Conditions filter
        clsEndSeasonConditionsFilterCalc.Clear()
        clsEndSeasonConditionsFilterSubCalcsList.Clear()
        clsEndSeasonConditionsOperator.Clear()
        clsEndSeasonWBConditionOperator.Clear()

        '   Doy summary
        clsEndSeasonFirstDoySummaryCalc.Clear()
        clsIfElseFirstDoyFunction.Clear()
        clsIsNaFirstWB.Clear()
        clsFirstDoyFunction.Clear()
        clsFirstWBFunction.Clear()

        '   Date summary
        clsEndSeasonFirstDateSummaryCalc.Clear()
        clsIfElseFirstDateFunction.Clear()
        clsFirstDateFunction.Clear()

        '   Status summary
        clsEndSeasonStatusSummaryCalc.Clear()

        '   Combination
        clsEndSeasonCombinationCalc.Clear()
        clsEndSeasonCombinationManipulationList.Clear()
        clsEndSeasonCombinationSubCalcList.Clear()

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

#Region "end_of_season"
        clsEndSeasonIsNaRain.SetRCommand("is.na")

        'Rain min
        clsEndSeasonRainMinCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonRainMinCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonRainMinCalc.AddParameter("result_name", Chr(34) & strRainMin & Chr(34), iPosition:=2)
        clsEndSeasonRainMinCalc.SetAssignTo(strRainMin)

        clsIfElseRainMinFunction.bToScriptAsRString = True
        clsIfElseRainMinFunction.SetRCommand("ifelse")
        clsIfElseRainMinFunction.AddParameter("test", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=0)
        clsIfElseRainMinFunction.AddParameter("yes", "0", iPosition:=1)

        'Rain max
        clsEndSeasonRainMaxCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonRainMaxCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonRainMaxCalc.AddParameter("result_name", Chr(34) & strRainMax & Chr(34), iPosition:=2)
        clsEndSeasonRainMaxCalc.SetAssignTo(strRainMax)

        clsIfElseRainMaxFunction.bToScriptAsRString = True
        clsIfElseRainMaxFunction.SetRCommand("ifelse")
        clsIfElseRainMaxFunction.AddParameter("test", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=0)

        'Pmax
        clsPMaxFunction.SetRCommand("pmax")
        clsPMaxFunction.AddParameter("0", clsROperatorParameter:=clsPMaxOperator, iPosition:=0)
        clsPMaxFunction.AddParameter("1", "0", bIncludeArgumentName:=False)

        clsPMaxOperator.SetOperation("-")
        clsPMaxOperator.AddParameter("0", "x + y", iPosition:=0)

        ' Water Balance min
        clsEndSeasonWBMinCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonWBMinCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction, iPosition:=1)
        clsEndSeasonWBMinCalc.AddParameter("result_name", Chr(34) & strWBMin & Chr(34), iPosition:=2)
        clsEndSeasonWBMinCalc.AddParameter("sub_calculations", "list(" & strRainMin & ")", iPosition:=3)
        clsEndSeasonWBMinCalc.SetAssignTo(strWBMin)

        clsEndSeasonWBMinCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBMinCalcSubCalcsList.AddParameter("0", clsRFunctionParameter:=clsEndSeasonRainMinCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsReduceWBMinFunction.bToScriptAsRString = True
        clsReduceWBMinFunction.SetRCommand("Reduce")
        clsReduceWBMinFunction.AddParameter("f", clsRFunctionParameter:=clsPMinWBMinFunction, iPosition:=0)
        clsReduceWBMinFunction.AddParameter("x", strRainMin, iPosition:=1)
        clsReduceWBMinFunction.AddParameter("accumulate", "TRUE", iPosition:=2)

        clsPMinWBMinFunction.SetRCommand("function(x, y) pmin")
        clsPMinWBMinFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsPMinWBMinFunction.AddParameter("1", "60", iPosition:=1, bIncludeArgumentName:=False)

        ' Water Balance max
        clsEndSeasonWBMaxCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonWBMaxCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction, iPosition:=1)
        clsEndSeasonWBMaxCalc.AddParameter("result_name", Chr(34) & strWBMax & Chr(34), iPosition:=2)
        clsEndSeasonWBMaxCalc.AddParameter("sub_calculations", "list(" & strRainMax & ")", iPosition:=3)
        clsEndSeasonWBMaxCalc.SetAssignTo(strWBMax)

        clsEndSeasonWBMaxCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBMaxCalcSubCalcsList.AddParameter("0", clsRFunctionParameter:=clsEndSeasonRainMinCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsReduceWBMaxFunction.bToScriptAsRString = True
        clsReduceWBMaxFunction.SetRCommand("Reduce")
        clsReduceWBMaxFunction.AddParameter("f", clsRFunctionParameter:=clsPMinWBMaxFunction, iPosition:=0)
        clsReduceWBMaxFunction.AddParameter("x", strRainMax, iPosition:=1)
        clsReduceWBMaxFunction.AddParameter("accumulate", "TRUE", iPosition:=2)

        clsPMinWBMaxFunction.SetRCommand("function(x, y) pmin")
        clsPMinWBMaxFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsPMinWBMaxFunction.AddParameter("1", "60", iPosition:=1, bIncludeArgumentName:=False)

        ' Water Balance
        clsEndSeasonWBCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonWBCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseWBFunction, iPosition:=1)
        clsEndSeasonWBCalc.AddParameter("result_name", Chr(34) & strWB & Chr(34), iPosition:=2)
        clsEndSeasonWBCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBCalcSubCalcsList, iPosition:=3)
        clsEndSeasonWBCalc.SetAssignTo(strWB)

        clsEndSeasonWBCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBCalcSubCalcsList.AddParameter("0", clsRFunctionParameter:=clsEndSeasonWBMaxCalc, iPosition:=0, bIncludeArgumentName:=False)
        clsEndSeasonWBCalcSubCalcsList.AddParameter("1", clsRFunctionParameter:=clsEndSeasonWBMinCalc, iPosition:=1, bIncludeArgumentName:=False)

        clsIfElseWBFunction.bToScriptAsRString = True
        clsIfElseWBFunction.SetRCommand("ifelse")
        clsIfElseWBFunction.AddParameter("test", clsROperatorParameter:=clsWBOperator, iPosition:=0)
        clsIfElseWBFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfElseWBFunction.AddParameter("no", strWBMin, iPosition:=2)

        clsWBOperator.SetOperation("|")
        clsWBOperator.AddParameter("0", clsROperatorParameter:=clsWBMinMaxOperator, iPosition:=0)
        clsWBOperator.AddParameter("1", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=1)

        clsWBMinMaxOperator.SetOperation("!=")
        clsWBMinMaxOperator.AddParameter("0", strWBMin, iPosition:=0)
        clsWBMinMaxOperator.AddParameter("1", strWBMax, iPosition:=1)

        ' Conditions filter
        clsEndSeasonConditionsFilterCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonConditionsFilterCalc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsEndSeasonConditionsFilterCalc.AddParameter("function_exp", clsROperatorParameter:=clsEndSeasonConditionsOperator, iPosition:=1)
        clsEndSeasonConditionsFilterCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonConditionsFilterSubCalcsList, iPosition:=4)
        clsEndSeasonConditionsFilterCalc.SetAssignTo(strConditionsFilter)

        clsEndSeasonConditionsFilterSubCalcsList.SetRCommand("list")
        clsEndSeasonConditionsFilterSubCalcsList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonWBCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsEndSeasonConditionsOperator.bToScriptAsRString = True
        clsEndSeasonConditionsOperator.SetOperation("|")
        clsEndSeasonConditionsOperator.AddParameter("0", clsROperatorParameter:=clsEndSeasonWBConditionOperator, iPosition:=0)
        clsEndSeasonConditionsOperator.AddParameter("1", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=1)

        clsEndSeasonWBConditionOperator.SetOperation("<=")
        clsEndSeasonWBConditionOperator.AddParameter("0", strWB, iPosition:=0)

        ' Doy summary
        clsEndSeasonFirstDoySummaryCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonFirstDoySummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseFirstDoyFunction, iPosition:=1)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("result_name", Chr(34) & strEndSeason & Chr(34), iPosition:=2)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("save", "2", iPosition:=6)
        clsEndSeasonFirstDoySummaryCalc.SetAssignTo(strEndRains)

        clsIfElseFirstDoyFunction.bToScriptAsRString = True
        clsIfElseFirstDoyFunction.SetRCommand("ifelse")
        clsIfElseFirstDoyFunction.AddParameter("test", clsRFunctionParameter:=clsIsNaFirstWB, iPosition:=0)
        clsIfElseFirstDoyFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfElseFirstDoyFunction.AddParameter("no", clsRFunctionParameter:=clsFirstDoyFunction, iPosition:=2)

        clsIsNaFirstWB.SetRCommand("is.na")
        clsIsNaFirstWB.AddParameter("x", clsRFunctionParameter:=clsFirstWBFunction, iPosition:=0)

        clsFirstWBFunction.SetPackageName("dplyr")
        clsFirstWBFunction.SetRCommand("first")

        clsFirstDoyFunction.SetPackageName("dplyr")
        clsFirstDoyFunction.SetRCommand("first")

        ' Date summary
        clsEndSeasonFirstDateSummaryCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonFirstDateSummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndSeasonFirstDateSummaryCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseFirstDateFunction, iPosition:=1)
        clsEndSeasonFirstDateSummaryCalc.AddParameter("result_name", Chr(34) & strEndSeasonDate & Chr(34), iPosition:=2)
        clsEndSeasonFirstDateSummaryCalc.AddParameter("save", 2)
        clsEndSeasonFirstDateSummaryCalc.SetAssignTo(strEndSeasonDate)

        clsIfElseFirstDateFunction.SetPackageName("dplyr")
        clsIfElseFirstDateFunction.SetRCommand("if_else")
        clsIfElseFirstDateFunction.AddParameter("condition", clsRFunctionParameter:=clsIsNaFirstWB, iPosition:=0)
        clsIfElseFirstDateFunction.AddParameter("true", "as.Date(NA)", iPosition:=1)
        clsIfElseFirstDateFunction.AddParameter("false", clsRFunctionParameter:=clsFirstDateFunction, iPosition:=2)
        clsIfElseFirstDateFunction.bToScriptAsRString = True

        clsFirstDateFunction.SetPackageName("dplyr")
        clsFirstDateFunction.SetRCommand("first")

        ' Status summary
        clsEndSeasonStatusSummaryCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonStatusSummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndSeasonStatusSummaryCalc.AddParameter("function_exp", Chr(34) & "n() > 0" & Chr(34), iPosition:=1)
        clsEndSeasonStatusSummaryCalc.AddParameter("result_name", Chr(34) & strEndSeasonStatus & Chr(34), iPosition:=3)
        clsEndSeasonStatusSummaryCalc.AddParameter("save", 2, iPosition:=4)
        clsEndSeasonStatusSummaryCalc.SetAssignTo(strEndSeasonStatus)

        ' Combined
        clsEndSeasonCombinationCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonCombinationCalc.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsEndSeasonCombinationCalc.AddParameter("manipulations", clsRFunctionParameter:=clsEndSeasonCombinationManipulationList, iPosition:=1)
        clsEndSeasonCombinationCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonCombinationSubCalcList, iPosition:=2)
        clsEndSeasonCombinationCalc.SetAssignTo("end_of_season_combined")

        clsEndSeasonCombinationManipulationList.SetRCommand("list")
        clsEndSeasonCombinationManipulationList.AddParameter("manip1", clsRFunctionParameter:=clsEndSeasonConditionsFilterCalc, bIncludeArgumentName:=False, iPosition:=0)
        clsEndSeasonCombinationManipulationList.AddParameter("manip2", clsRFunctionParameter:=clsGroupByStationYearCalc, bIncludeArgumentName:=False, iPosition:=1)
        clsEndSeasonCombinationManipulationList.AddParameter("manip3", clsRFunctionParameter:=clsDoyFilterCalc, bIncludeArgumentName:=False, iPosition:=2)

        clsEndSeasonCombinationSubCalcList.SetRCommand("list")
        clsEndSeasonCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonFirstDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)
#End Region

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLastDoyFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstDoyFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsEndSeasonIsNaRain, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsIfElseRainMinFunction, New RParameter("no", 2), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsIfElseRainMaxFunction, New RParameter("no", 2), iAdditionalPairNo:=3)

        ucrNudCapacity.AddAdditionalCodeParameterPair(clsPMinWBMinFunction, New RParameter("1", 1), iAdditionalPairNo:=1)
        ucrNudCapacity.AddAdditionalCodeParameterPair(clsPMinWBMaxFunction, New RParameter("1", 1), iAdditionalPairNo:=2)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        ucrInputEndRainDoy.SetRCode(clsEndRainsLastDoySummaryCalc, bReset)
        ucrInputSeasonDoy.SetRCode(clsEndSeasonFirstDoySummaryCalc, bReset)
        ucrInputEndofRainsDate.SetRCode(clsEndRainsLastDateSummaryCalc, bReset)
        ucrInputEndofRainsOccurence.SetRCode(clsEndRainsStatusSummaryCalc, bReset)
        ucrInputEndofSeasonOccurence.SetRCode(clsEndSeasonStatusSummaryCalc, bReset)

        ucrReceiverDate.SetRCode(clsLastDateFunction, bReset)
        ucrReceiverEvaporation.SetRCode(clsPMaxOperator, bReset)
        'ucrInputReplaceNA.SetRCode(clsEvaporationReplaceNAFunc, bReset)

        ucrReceiverRainfall.SetRCode(clsRollSumRainFunction, bReset)

        ucrChkEndOfSeason.SetRCode(clsEndRainsCombinationSubCalcList, bReset)
        ucrChkEndofSeasonOccurence.SetRCode(clsEndRainsCombinationSubCalcList, bReset)

        ucrNudWBLessThan.SetRCode(clsEndSeasonWBConditionOperator, bReset)

        ucrInputEvaporation.SetRCode(clsPMaxOperator, bReset)
        ucrNudCapacity.SetRCode(clsIfElseRainMaxFunction, bReset)

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
        clsEndRainsLastDoySummaryCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsEndRainsLastDateSummaryCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDate.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub RainfallChange()
        clsEndRainsRollingSumCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
        clsEndSeasonRainMinCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
        clsEndSeasonRainMaxCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
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
            ucrReceiverRainfall.SetMeAsReceiver()
        ElseIf rdoVariableEvaporation.Checked Then
            ucrReceiverEvaporation.SetMeAsReceiver()

            'clsEvaporationReplaceNAFunc.bToScriptAsRString = True
            'clsEvaporationReplaceNA.SetRCommand("instat_calculation$new")
            'clsEvaporationReplaceNA.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
            'clsEvaporationReplaceNA.AddParameter("function_exp", clsRFunctionParameter:=clsEvaporationReplaceNAFunc, iPosition:=1)
            'clsEvaporationReplaceNAFunc.SetRCommand("replace")
            'clsEvaporationReplaceNAFunc.AddParameter("list", clsRFunctionParameter:=clsEvaporationReplaceNAFuncList, iPosition:=1)
            'clsEvaporationReplaceNAFuncList.SetRCommand("is.na")
            'clsEvaporationReplaceNA.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverEvaporation.GetVariableNames & ")")
            'clsEvaporationReplaceNA.AddParameter("result_name", Chr(34) & strEvapReplaceNA & Chr(34), iPosition:=2)
            'clsEvaporationReplaceNA.SetAssignTo(strEvapReplaceNA)

            'clsReduceOpEvapMin.SetOperation("-")
            'clsReduceOpEvapMin.AddParameter("first", strRainMin, iPosition:=0)
            'clsReduceOpEvapMin.AddParameter("second", strEvapReplaceNA, iPosition:=1)
            'clsReduceFunctionMin.AddParameter("replace_na", clsROperatorParameter:=clsReduceOpEvapMin, iPosition:=1, bIncludeArgumentName:=False)
            'clsWBWaterBalanceMinList.AddParameter("sub2", clsRFunctionParameter:=clsEvaporationReplaceNA, bIncludeArgumentName:=False)

            'clsReduceOpEvapMax.SetOperation("-")
            'clsReduceOpEvapMax.AddParameter("first", strRainMax, iPosition:=0)
            'clsReduceOpEvapMax.AddParameter("second", strEvapReplaceNA, iPosition:=1)
            'clsReduceFunctionMax.AddParameter("replace_na", clsROperatorParameter:=clsReduceOpEvapMax, iPosition:=1, bIncludeArgumentName:=False)
            'clsWaterBalanceMaxList.AddParameter("sub2", clsRFunctionParameter:=clsEvaporationReplaceNA, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub ucrChkEndofRainsDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsDoy.ControlValueChanged, ucrChkEndofRainsDate.ControlValueChanged, ucrChkEndofRainsOccurence.ControlValueChanged
        If ucrChkEndOfRains.Checked Then
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
        End If
    End Sub

    Private Sub ucrChkEndofSeasonOccurence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofSeasonOccurence.ControlValueChanged, ucrChkEndOfSeason.ControlValueChanged
        If ucrChkEndOfSeason.Checked Then
            If ucrChkEndofSeasonDoy.Checked Then
                clsEndSeasonCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonFirstDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub1")
            End If
            If ucrChkEndofSeasonDate.Checked Then
                clsEndSeasonCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsEndSeasonFirstDateSummaryCalc, bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub2")
            End If
            If ucrChkEndofRainsOccurence.Checked Then
                clsEndSeasonCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsEndSeasonStatusSummaryCalc, bIncludeArgumentName:=False, iPosition:=2)
            Else
                clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub3")
            End If
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkEndOfRains.ControlContentsChanged, ucrChkEndOfSeason.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrNudCapacity.ControlContentsChanged, ucrNudWBLessThan.ControlContentsChanged, ucrInputSeasonDoy.ControlContentsChanged, ucrNudTotalOverDays.ControlContentsChanged, ucrNudAmount.ControlContentsChanged, ucrChkEndofRainsDoy.ControlContentsChanged, ucrInputEndRainDoy.ControlContentsChanged, ucrChkEndofRainsDate.ControlContentsChanged, ucrInputEndofRainsDate.ControlContentsChanged, ucrChkEndofRainsOccurence.ControlContentsChanged, ucrInputEndofRainsOccurence.ControlContentsChanged, ucrChkEndofSeasonDoy.ControlContentsChanged, ucrPnlEvaporation.ControlContentsChanged, ucrReceiverEvaporation.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrInputReplaceNA.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkEndOfRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndOfRains.ControlValueChanged, ucrChkEndOfSeason.ControlValueChanged
        If ucrChkEndOfRains.Checked Then
            clsRunCalculation.AddParameter("calc", clsRFunctionParameter:=clsEndRainsCombinationCalc)
        ElseIf ucrChkEndOfSeason.Checked Then
            clsRunCalculation.AddParameter("calc", clsRFunctionParameter:=clsEndSeasonCombinationCalc)
        Else
            clsRunCalculation.RemoveParameterByName("calc")
        End If
    End Sub
End Class