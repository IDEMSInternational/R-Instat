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
    Private strRainMin As String = "rain_min"
    Private strRainMax As String = "rain_max"
    Private strWBMin As String = "wb_min"
    Private strWBMax As String = "wb_max"
    Private strWB As String = "wb"
    Private strEvapReplaceNA As String = "evap_NA_as_value"
    Private strCurrDataName As String = ""
    Private iCapacityDefault As Integer = 60
    Private strYearType As String = "year_type"

#Region "general_code_structures"
    ' General
    Private clsVectorFunction, clsGetlinkeddataFunction, clsConvertColumnType1Function, clsConvertColumnType2Function, clsGetColumnDataTypeFunction, clsConvertColumnTypeFunction, clsRunCalculation, clsListCalFunction, clsDummyFunction As New RFunction
    Private clsFirstOrLastFunction As New RFunction

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
    Private clsEndRainsRollingSumCalc, clsWBEvaporationMinFunction, clsWBEvaporationMaxFunction As New RFunction
    Private clsRollSumRainFunction As New RFunction
    Private clsWBOperator1, clsWBOperator2 As New ROperator
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

    ' Water Balance min
    Private clsEndSeasonWBMinCalc As New RFunction
    Private clsEndSeasonWBMinCalcSubCalcsList As New RFunction
    Private clsReduceWBMinFunction As New RFunction
    Private clsReduceWBMinFunction1 As New RFunction
    Private clsReduceWBMinFunction2 As New RFunction
    Private clsPMinWBMinFunction As New RFunction
    Private clsWBMinTailFunction As New RFunction
    Private clsWBMinTailFunction1 As New RFunction
    Private clsWBMinTailFunction2 As New RFunction
    Private clsWBMinEvapOperator As New ROperator
    Private clsMinusMinOperator As New ROperator
    Private clsMinusMaxOperator As New ROperator

    ' Water Balance max
    Private clsEndSeasonWBMaxCalc As New RFunction
    Private clsEndSeasonWBMaxCalcSubCalcsList As New RFunction
    Private clsReduceWBMaxFunction As New RFunction
    Private clsReduceWBMaxFunction1 As New RFunction
    Private clsReduceWBMaxFunction2 As New RFunction
    Private clsAsNumericFunction As New RFunction
    Private clsPMinWBMaxFunction As New RFunction
    Private clsWBMaxTailFunction As New RFunction
    Private clsWBMaxTailFunction1 As New RFunction
    Private clsWBMaxTailFunction2 As New RFunction
    Private clsWBMaxEvapOperator As New ROperator

    ' Water Balance
    Private clsEndSeasonWBCalc As New RFunction
    Private clsEndSeasonWBCalcSubCalcsList As New RFunction
    Private clsIfElseWBFunction As New RFunction
    Private clsWBOperator As New ROperator
    Private clsWBMinMaxOperator As New ROperator

    ' Evaporation
    Private clsIfElseVariableEvaporation As New RFunction
    Private clsIsNaEvaporation As New RFunction

    ' Conditions filter
    Private clsEndSeasonConditionsFilterCalc As New RFunction
    Private clsEndSeasonConditionsFilterSubCalcsList As New RFunction
    Private clsEndSeasonConditionsOperator As New ROperator
    Private clsEndSeasonWBConditionOperator As New ROperator

    ' Doy summary
    Private clsEndSeasonFirstDoySummaryCalc As New RFunction
    Private clsEndSeasonFirstDoySummaryCalcFilledFunction As New RFunction
    Private clsIfElseFirstDoyFunction As New RFunction
    Public clsIfElseFirstDoyFilledFunction As New RFunction
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

    Private Sub dlgEndOfRainsSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
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

        ucrChkEndofSeasonDoy.AddParameterPresentCondition(True, "sub1", True)
        ucrChkEndofSeasonDoy.AddParameterPresentCondition(False, "sub1", False)
        ucrChkEndofSeasonDoy.SetText("Day")

        'TODO Set conditions for end of rains vs end of season
        ucrPnlEndOfRainsAndSeasons.AddRadioButton(rdoEndOfRains)
        ucrPnlEndOfRainsAndSeasons.AddRadioButton(rdoEndOfSeasons)
        ucrPnlEndOfRainsAndSeasons.AddFunctionNamesCondition(rdoEndOfRains, "last")
        ucrPnlEndOfRainsAndSeasons.AddFunctionNamesCondition(rdoEndOfSeasons, "first")
#End Region

#Region "end_of_rains_controls"

        ucrNudAmount.SetParameter(New RParameter("threshold", 1, False))
        ucrNudAmount.DecimalPlaces = 2
        ucrNudAmount.Increment = 0.1

        ucrNudTotalOverDays.SetParameter(New RParameter("n", 1))
        ucrNudTotalOverDays.SetMinMax(1, 366)

        ucrChkEndofRainsDoy.AddParameterPresentCondition(True, "sub1")
        ucrChkEndofRainsDoy.AddParameterPresentCondition(False, "sub1", False)
        ucrChkEndofRainsDoy.SetText("Day")


        ucrInputEndRainDoy.SetParameter(New RParameter("result_name", 3))
        ucrInputEndRainDoy.SetValidationTypeAsRVariable()
        ucrInputEndRainDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofRainsDate.AddParameterValuesCondition(True, "sub2", "True")
        ucrChkEndofRainsDate.AddParameterValuesCondition(False, "sub2", "False")
        ucrChkEndofRainsDate.SetText("Date")

        ucrInputEndofRainsDate.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofRainsDate.SetValidationTypeAsRVariable()
        ucrInputEndofRainsDate.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofRainsOccurence.SetText("Occurrence")
        ucrChkEndofRainsOccurence.AddParameterValuesCondition(True, "sub3", "True")
        ucrChkEndofRainsOccurence.AddParameterValuesCondition(False, "sub3", "False")

        ucrInputEndofRainsOccurence.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofRainsOccurence.SetValidationTypeAsRVariable()
        ucrInputEndofRainsOccurence.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
#End Region

#Region "end_of_season_controls"
        ucrReceiverEvaporation.SetParameter(New RParameter("x", 0))
        ucrReceiverEvaporation.Selector = ucrSelectorForWaterBalance
        ucrReceiverEvaporation.SetParameterIsString()
        ucrReceiverEvaporation.bWithQuotes = False

        ucrPnlEvaporation.AddRadioButton(rdoValueEvaporation)
        ucrPnlEvaporation.AddRadioButton(rdoVariableEvaporation)
        ucrPnlEvaporation.AddParameterPresentCondition(rdoValueEvaporation, "variable", False)
        ucrPnlEvaporation.AddParameterPresentCondition(rdoVariableEvaporation, "variable")

        ucrInputEvaporation.SetParameter(New RParameter("value", 1, bNewIncludeArgumentName:=False))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False

        ucrNudWBLessThan.SetParameter(New RParameter("1", 1, False))
        ucrNudWBLessThan.SetMinMax(0, Integer.MaxValue)
        ucrNudWBLessThan.Increment = 0.5
        ucrNudWBLessThan.DecimalPlaces = 2

        ucrNudCapacity.SetParameter(New RParameter("yes", 1))
        ucrNudCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudCapacity.Increment = 10

        ucrInputSeasonDoy.SetParameter(New RParameter("result_name", 3))
        ucrInputSeasonDoy.SetValidationTypeAsRVariable()
        ucrInputSeasonDoy.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofSeasonDate.SetText("Date")
        ucrChkEndofSeasonDate.AddParameterValuesCondition(True, "sub2", "True")
        ucrChkEndofSeasonDate.AddParameterValuesCondition(False, "sub2", "False")

        ucrInputEndofSeasonDate.SetParameter(New RParameter("result_name", 3))
        ucrInputEndofSeasonDate.SetValidationTypeAsRVariable()
        ucrInputEndofSeasonDate.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)

        ucrChkEndofSeasonOccurence.AddParameterValuesCondition(True, "sub3", "True")
        ucrChkEndofSeasonOccurence.AddParameterValuesCondition(False, "sub3", "False")
        ucrChkEndofSeasonOccurence.SetText("Occurrence")

        ucrInputEndofSeasonOccurence.SetParameter(New RParameter("result_name", 2))
        ucrInputEndofSeasonOccurence.SetDataFrameSelector(ucrSelectorForWaterBalance.ucrAvailableDataFrames)
        ucrInputEndofSeasonOccurence.SetValidationTypeAsRVariable()

        ucrChkWB.AddParameterPresentCondition(True, "WB_evap", True)
        ucrChkWB.AddParameterPresentCondition(False, "WB_evap", False)
        ucrChkWB.SetText("Reducing")

        ucrNudWB.SetParameter(New RParameter("WB_evap_value", 2, False))
        ucrNudWB.SetMinMax(0, 1)
        ucrNudWB.Increment = 0.01
        ucrNudWB.DecimalPlaces = 2


        'linking controls
        ucrChkEndofRainsDoy.AddToLinkedControls(ucrInputEndRainDoy, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonOccurence.AddToLinkedControls(ucrInputEndofSeasonOccurence, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonDate.AddToLinkedControls(ucrInputEndofSeasonDate, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofSeasonDoy.AddToLinkedControls(ucrInputSeasonDoy, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkWB.AddToLinkedControls(ucrNudWB, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrPnlEvaporation.AddToLinkedControls(ucrInputEvaporation, {rdoValueEvaporation}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlEvaporation.AddToLinkedControls(ucrReceiverEvaporation, {rdoVariableEvaporation}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofRainsOccurence.AddToLinkedControls(ucrInputEndofRainsOccurence, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkEndofRainsDate.AddToLinkedControls(ucrInputEndofRainsDate, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEndOfRainsAndSeasons.AddToLinkedControls({ucrNudAmount, ucrNudTotalOverDays}, {rdoEndOfRains}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEndOfRainsAndSeasons.AddToLinkedControls({ucrNudCapacity, ucrNudWBLessThan, ucrChkEndofSeasonDoy}, {rdoEndOfSeasons}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEndOfRainsAndSeasons.AddToLinkedControls({ucrPnlEvaporation}, {rdoEndOfSeasons}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEndOfRainsAndSeasons.AddToLinkedControls({ucrChkWB}, {rdoEndOfSeasons}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEndOfRainsAndSeasons.AddToLinkedControls({ucrChkEndofSeasonDate, ucrChkEndofSeasonDoy, ucrChkEndofSeasonOccurence}, {rdoEndOfSeasons}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEndOfRainsAndSeasons.AddToLinkedControls({ucrChkEndofRainsDate, ucrChkEndofRainsDoy, ucrChkEndofRainsOccurence}, {rdoEndOfRains}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkEndofRainsDoy.SetLinkedDisplayControl(grpEndofRains)
        ucrPnlEvaporation.SetLinkedDisplayControl(lblEvaporation)
        ucrNudAmount.SetLinkedDisplayControl(lblAmount)
        ucrNudWBLessThan.SetLinkedDisplayControl(lblWaterBalanceLessThan)
        ucrNudCapacity.SetLinkedDisplayControl(lblCapacity)
        ucrChkEndofSeasonDoy.SetLinkedDisplayControl(grpEndofSeason)
        ucrNudTotalOverDays.SetLinkedDisplayControl(lblTotalOverDays)

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
        Dim strEndSeasonFilled As String = "end_season_filled"
        Dim strEndSeasonStatus As String = "end_season_status"
        Dim strEndSeasonDate As String = "end_season_date"
        Dim strDoyFilter As String = "doy_filter"
        Dim strEndofRains As String = "end_of_rains_combined"
        Dim strEndofSeason As String = "end_of_season_combined"

        clsGetlinkeddataFunction = New RFunction
        clsVectorFunction = New RFunction

#Region "clear_code_structures"
        ' General
        clsRunCalculation.Clear()
        clsListCalFunction.Clear()
        clsFirstOrLastFunction.Clear()
        clsConvertColumnTypeFunction.Clear()
        clsConvertColumnType2Function.Clear()
        clsGetColumnDataTypeFunction.Clear()
        clsConvertColumnType1Function.Clear()
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

        '   Water Balance min
        clsEndSeasonWBMinCalc.Clear()
        clsEndSeasonWBMinCalcSubCalcsList.Clear()
        clsReduceWBMinFunction.Clear()
        clsReduceWBMinFunction1.Clear()
        clsReduceWBMinFunction2.Clear()
        clsPMinWBMinFunction.Clear()
        clsWBMinTailFunction.Clear()
        clsWBMinTailFunction1.Clear()
        clsWBMinTailFunction2.Clear()
        clsWBMinEvapOperator.Clear()

        '   Water Balance max
        clsEndSeasonWBMaxCalc.Clear()
        clsEndSeasonWBMaxCalcSubCalcsList.Clear()
        clsReduceWBMaxFunction.Clear()
        clsReduceWBMaxFunction1.Clear()
        clsReduceWBMaxFunction2.Clear()
        clsPMinWBMaxFunction.Clear()
        clsWBMaxTailFunction.Clear()
        clsWBMaxTailFunction1.Clear()
        clsWBMaxTailFunction2.Clear()
        clsWBMaxEvapOperator.Clear()

        '   Water Balance
        clsEndSeasonWBCalc.Clear()
        clsEndSeasonWBCalcSubCalcsList.Clear()
        clsIfElseWBFunction.Clear()
        clsWBOperator.Clear()
        clsWBOperator1.Clear()
        clsWBOperator2.Clear()
        clsWBEvaporationMinFunction.Clear()
        clsPMinWBMaxFunction.Clear()
        clsWBMinMaxOperator.Clear()

        '   Evaporation
        clsIfElseVariableEvaporation.Clear()
        clsIsNaEvaporation.Clear()

        '   Conditions filter
        clsEndSeasonConditionsFilterCalc.Clear()
        clsEndSeasonConditionsFilterSubCalcsList.Clear()
        clsEndSeasonConditionsOperator.Clear()
        clsEndSeasonWBConditionOperator.Clear()

        '   Doy summary
        clsEndSeasonFirstDoySummaryCalc.Clear()
        clsEndSeasonFirstDoySummaryCalcFilledFunction.Clear()
        clsIfElseFirstDoyFunction.Clear()
        clsIfElseFirstDoyFilledFunction.Clear()
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
        'temporary fix
        rdoEndOfRains.Checked = True

        ucrNudCapacity.SetText("100")
        ucrNudWBLessThan.SetText("0.5")

        clsDummyFunction = New RFunction
        clsDummyFunction.AddParameter("sub2", "True", iPosition:=0)
        clsDummyFunction.AddParameter("sub3", "True", iPosition:=1)

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
        clsEndRainsCombinationCalc.SetAssignTo(strEndofRains)

        clsEndRainsCombinationManipulationList.SetRCommand("list")
        clsEndRainsCombinationManipulationList.AddParameter("manip1", clsRFunctionParameter:=clsEndRainsConditionsFilterCalc, bIncludeArgumentName:=False, iPosition:=0)
        clsEndRainsCombinationManipulationList.AddParameter("manip2", clsRFunctionParameter:=clsGroupByStationYearCalc, bIncludeArgumentName:=False, iPosition:=1)
        clsEndRainsCombinationManipulationList.AddParameter("manip3", clsRFunctionParameter:=clsDoyFilterCalc, bIncludeArgumentName:=False, iPosition:=2)

        clsWBOperator1.SetOperation("-")
        clsWBOperator1.AddParameter("left", "..1 + ..2", iPosition:=0)
        clsWBOperator1.AddParameter("right", clsRFunctionParameter:=clsWBEvaporationMinFunction, iPosition:=1)
        clsWBOperator1.bSpaceAroundOperation = True
        clsWBOperator1.bBrackets = False

        clsWBEvaporationMinFunction.SetRCommand("WB_evaporation")
        clsWBEvaporationMinFunction.AddParameter("water_balance", "..1", iPosition:=0, bIncludeArgumentName:=False)
        clsWBEvaporationMinFunction.AddParameter("y", "..2", iPosition:=4, bIncludeArgumentName:=False)

        clsEndRainsCombinationSubCalcList.SetRCommand("list")
        clsEndRainsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainsLastDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)

        clsListCalFunction.SetRCommand("list")
        clsListCalFunction.AddParameter("drop", "FALSE", iPosition:=0)

        clsRunCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalculation.AddParameter("display", "FALSE", iPosition:=0)
        clsRunCalculation.AddParameter("calc", clsRFunctionParameter:=clsEndRainsCombinationCalc, iPosition:=1)
        clsRunCalculation.AddParameter("param_list", clsRFunctionParameter:=clsListCalFunction, iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalculation)
#End Region

#Region "end_of_season"
        clsEndSeasonIsNaRain.SetRCommand("is.na")

        'Rain min
        clsEndSeasonRainMinCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonRainMinCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonRainMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseRainMinFunction, iPosition:=1)
        clsEndSeasonRainMinCalc.AddParameter("result_name", Chr(34) & strRainMin & Chr(34), iPosition:=2)
        clsEndSeasonRainMinCalc.SetAssignTo(strRainMin)

        clsIfElseRainMinFunction.bToScriptAsRString = True
        clsIfElseRainMinFunction.SetRCommand("ifelse")
        clsIfElseRainMinFunction.AddParameter("test", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=0)
        clsIfElseRainMinFunction.AddParameter("yes", "0", iPosition:=1)

        'Rain max
        clsEndSeasonRainMaxCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonRainMaxCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonRainMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseRainMaxFunction, iPosition:=1)
        clsEndSeasonRainMaxCalc.AddParameter("result_name", Chr(34) & strRainMax & Chr(34), iPosition:=2)
        clsEndSeasonRainMaxCalc.SetAssignTo(strRainMax)

        clsIfElseRainMaxFunction.bToScriptAsRString = True
        clsIfElseRainMaxFunction.SetRCommand("ifelse")
        clsIfElseRainMaxFunction.AddParameter("test", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=0)
        clsIfElseRainMaxFunction.AddParameter("yes", 100, iPosition:=0)

        'Pmax
        clsPMaxFunction.SetRCommand("pmax")
        clsPMaxFunction.AddParameter("0", "..1 + ..2", iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxFunction.AddParameter("1", "0", bIncludeArgumentName:=False)

        ' Water Balance min
        clsEndSeasonWBMinCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonWBMinCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction, iPosition:=1)
        clsEndSeasonWBMinCalc.AddParameter("result_name", Chr(34) & strWBMin & Chr(34), iPosition:=2)
        clsEndSeasonWBMinCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBMinCalcSubCalcsList, iPosition:=3)
        clsEndSeasonWBMinCalc.SetAssignTo(strWBMin)

        clsEndSeasonWBMinCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBMinCalcSubCalcsList.AddParameter("0", clsRFunctionParameter:=clsEndSeasonRainMinCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsReduceWBMinFunction.bToScriptAsRString = True
        clsReduceWBMinFunction.SetPackageName("purrr")
        clsReduceWBMinFunction.SetRCommand("accumulate")
        clsReduceWBMinFunction.AddParameter(".f", clsRFunctionParameter:=clsPMinWBMinFunction, iPosition:=0)
        clsReduceWBMinFunction.AddParameter(".x", clsRFunctionParameter:=clsWBMinTailFunction, iPosition:=1)
        clsReduceWBMinFunction.AddParameter(".init", "0", iPosition:=2)

        clsReduceWBMinFunction1.bToScriptAsRString = True
        clsReduceWBMinFunction1.SetPackageName("purrr")
        clsReduceWBMinFunction1.SetRCommand("accumulate2")
        clsReduceWBMinFunction1.AddParameter(".f", clsRFunctionParameter:=clsPMinWBMinFunction, iPosition:=0)
        clsReduceWBMinFunction1.AddParameter(".x", clsRFunctionParameter:=clsWBMinTailFunction, iPosition:=1)
        clsReduceWBMinFunction1.AddParameter(".init", "0", iPosition:=2)

        clsReduceWBMinFunction2.bToScriptAsRString = True
        clsReduceWBMinFunction2.SetPackageName("purrr")
        clsReduceWBMinFunction2.SetRCommand("accumulate")
        clsReduceWBMinFunction2.AddParameter(".f", clsRFunctionParameter:=clsPMinWBMinFunction, iPosition:=0)
        clsReduceWBMinFunction2.AddParameter(".x", clsRFunctionParameter:=clsWBMinTailFunction2, iPosition:=1)
        clsReduceWBMinFunction2.AddParameter(".init", "0", iPosition:=2)

        clsPMinWBMinFunction.SetRCommand(" ~ pmin")

        clsWBMinTailFunction.SetRCommand("tail")
        clsWBMinTailFunction.AddParameter("x", clsROperatorParameter:=clsWBMinEvapOperator, iPosition:=0)
        clsWBMinTailFunction.AddParameter("n", "-1", iPosition:=1)

        clsWBMinTailFunction1.SetRCommand("tail")
        clsWBMinTailFunction1.AddParameter("x", ucrReceiverEvaporation.GetVariableNames(False), iPosition:=0)
        clsWBMinTailFunction1.AddParameter("n", "-1", iPosition:=1)

        clsAsNumericFunction = New RFunction
        clsAsNumericFunction.SetRCommand("as.numeric")
        clsAsNumericFunction.AddParameter("x", ucrReceiverEvaporation.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)

        clsMinusMinOperator = New ROperator
        clsMinusMinOperator.SetOperation("-")
        clsMinusMinOperator.AddParameter("left", strRainMin, iPosition:=0, bIncludeArgumentName:=False)
        clsMinusMinOperator.AddParameter("right", clsRFunctionParameter:=clsAsNumericFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsWBMinTailFunction2.SetRCommand("tail")
        clsWBMinTailFunction2.AddParameter("x", clsROperatorParameter:=clsMinusMinOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsWBMinTailFunction2.AddParameter("n", "-1", iPosition:=1)

        clsWBMinEvapOperator.SetOperation("-")
        clsWBMinEvapOperator.AddParameter("0", strRainMin, iPosition:=0)

        ' Water Balance max
        clsEndSeasonWBMaxCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonWBMaxCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction, iPosition:=1)
        clsEndSeasonWBMaxCalc.AddParameter("result_name", Chr(34) & strWBMax & Chr(34), iPosition:=2)
        clsEndSeasonWBMaxCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBMaxCalcSubCalcsList, iPosition:=3)
        clsEndSeasonWBMaxCalc.SetAssignTo(strWBMax)

        clsEndSeasonWBMaxCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBMaxCalcSubCalcsList.AddParameter("0", clsRFunctionParameter:=clsEndSeasonRainMaxCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsReduceWBMaxFunction.bToScriptAsRString = True
        clsReduceWBMaxFunction.SetPackageName("purrr")
        clsReduceWBMaxFunction.SetRCommand("accumulate")
        clsReduceWBMaxFunction.AddParameter(".f", clsRFunctionParameter:=clsPMinWBMaxFunction, iPosition:=0)
        clsReduceWBMaxFunction.AddParameter(".x", clsRFunctionParameter:=clsWBMaxTailFunction, iPosition:=1)
        clsReduceWBMaxFunction.AddParameter(".init", "0", iPosition:=2)

        clsReduceWBMaxFunction1.bToScriptAsRString = True
        clsReduceWBMaxFunction1.SetPackageName("purrr")
        clsReduceWBMaxFunction1.SetRCommand("accumulate2")
        clsReduceWBMaxFunction1.AddParameter(".f", clsRFunctionParameter:=clsPMinWBMaxFunction, iPosition:=0)
        clsReduceWBMaxFunction1.AddParameter(".x", clsRFunctionParameter:=clsWBMaxTailFunction, iPosition:=1)
        clsReduceWBMaxFunction1.AddParameter(".init", "0", iPosition:=2)

        clsReduceWBMaxFunction2.bToScriptAsRString = True
        clsReduceWBMaxFunction2.SetPackageName("purrr")
        clsReduceWBMaxFunction2.SetRCommand("accumulate")
        clsReduceWBMaxFunction2.AddParameter(".f", clsRFunctionParameter:=clsPMinWBMaxFunction, iPosition:=0)
        clsReduceWBMaxFunction2.AddParameter(".x", clsRFunctionParameter:=clsWBMaxTailFunction2, iPosition:=1)
        clsReduceWBMaxFunction2.AddParameter(".init", "0", iPosition:=2)

        clsPMinWBMaxFunction.SetRCommand(" ~ pmin")

        clsWBMaxTailFunction.SetRCommand("tail")
        clsWBMaxTailFunction.AddParameter("x", clsROperatorParameter:=clsWBMaxEvapOperator, iPosition:=0)
        clsWBMaxTailFunction.AddParameter("n", "-1", iPosition:=1)

        clsWBMaxTailFunction1.SetRCommand("tail")
        clsWBMaxTailFunction1.AddParameter("x", ucrReceiverEvaporation.GetVariableNames(False), iPosition:=0)
        clsWBMaxTailFunction1.AddParameter("n", "-1", iPosition:=1)

        clsMinusMaxOperator = New ROperator
        clsMinusMaxOperator.SetOperation("-")
        clsMinusMaxOperator.AddParameter("left", strRainMax, iPosition:=0, bIncludeArgumentName:=False)
        clsMinusMaxOperator.AddParameter("right", clsRFunctionParameter:=clsAsNumericFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsWBMaxTailFunction2.SetRCommand("tail")
        clsWBMaxTailFunction2.AddParameter("x", clsROperatorParameter:=clsMinusMaxOperator, iPosition:=0)
        clsWBMaxTailFunction2.AddParameter("n", "-1", iPosition:=1)

        clsWBMaxEvapOperator.SetOperation("-")
        clsWBMaxEvapOperator.AddParameter("0", strRainMax, iPosition:=0)
        clsWBMaxEvapOperator.AddParameter("value", "5", iPosition:=1)

        ' Water Balance
        clsEndSeasonWBCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonWBCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseWBFunction, iPosition:=1)
        clsEndSeasonWBCalc.AddParameter("result_name", Chr(34) & strWB & Chr(34), iPosition:=2)
        clsEndSeasonWBCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBCalcSubCalcsList, iPosition:=3)
        clsEndSeasonWBCalc.SetAssignTo(strWB)

        clsEndSeasonWBCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBCalcSubCalcsList.AddParameter("0", clsRFunctionParameter:=clsEndSeasonWBMinCalc, iPosition:=0, bIncludeArgumentName:=False)
        clsEndSeasonWBCalcSubCalcsList.AddParameter("1", clsRFunctionParameter:=clsEndSeasonWBMaxCalc, iPosition:=1, bIncludeArgumentName:=False)

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

        ' Evaporation
        clsIfElseVariableEvaporation.SetRCommand("ifelse")
        clsIfElseVariableEvaporation.AddParameter("test", clsRFunctionParameter:=clsIsNaEvaporation, iPosition:=0)
        clsIfElseVariableEvaporation.AddParameter("yes", "5", iPosition:=1)

        clsIsNaEvaporation.SetRCommand("is.na")

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
        clsEndSeasonWBConditionOperator.AddParameter("1", "0.5", iPosition:=1)

        ' Doy summary
        clsEndSeasonFirstDoySummaryCalc.SetRCommand("instat_calculation$new")
        clsEndSeasonFirstDoySummaryCalc.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseFirstDoyFunction, iPosition:=1)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("result_name", Chr(34) & strEndSeason & Chr(34), iPosition:=2)
        clsEndSeasonFirstDoySummaryCalc.AddParameter("save", "2", iPosition:=6)
        clsEndSeasonFirstDoySummaryCalc.SetAssignTo(strEndSeason)

        clsEndSeasonFirstDoySummaryCalcFilledFunction.SetRCommand("instat_calculation$new")
        clsEndSeasonFirstDoySummaryCalcFilledFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsEndSeasonFirstDoySummaryCalcFilledFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseFirstDoyFilledFunction, iPosition:=1)
        clsEndSeasonFirstDoySummaryCalcFilledFunction.AddParameter("result_name", Chr(34) & strEndSeasonFilled & Chr(34), iPosition:=2)
        clsEndSeasonFirstDoySummaryCalcFilledFunction.AddParameter("save", "2", iPosition:=6)
        clsEndSeasonFirstDoySummaryCalcFilledFunction.SetAssignTo(strEndSeasonFilled)

        clsIfElseFirstDoyFunction.bToScriptAsRString = True
        clsIfElseFirstDoyFunction.SetRCommand("ifelse")
        clsIfElseFirstDoyFunction.AddParameter("test", clsRFunctionParameter:=clsIsNaFirstWB, iPosition:=0)
        clsIfElseFirstDoyFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfElseFirstDoyFunction.AddParameter("no", clsRFunctionParameter:=clsFirstDoyFunction, iPosition:=2)

        clsIfElseFirstDoyFilledFunction.bToScriptAsRString = True
        clsIfElseFirstDoyFilledFunction.SetRCommand("ifelse")
        clsIfElseFirstDoyFilledFunction.AddParameter("test", clsRFunctionParameter:=clsIsNaFirstWB, iPosition:=0)
        clsIfElseFirstDoyFilledFunction.AddParameter("yes", "366", iPosition:=1)
        clsIfElseFirstDoyFilledFunction.AddParameter("no", clsRFunctionParameter:=clsFirstDoyFunction, iPosition:=2)

        clsIsNaFirstWB.SetRCommand("is.na")
        clsIsNaFirstWB.AddParameter("x", clsRFunctionParameter:=clsFirstWBFunction, iPosition:=0)

        clsFirstWBFunction.SetPackageName("dplyr")
        clsFirstWBFunction.SetRCommand("first")
        clsFirstWBFunction.AddParameter("x", strWB, iPosition:=0)

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
        clsEndSeasonCombinationCalc.SetAssignTo(strEndofSeason)

        clsEndSeasonCombinationManipulationList.SetRCommand("list")
        clsEndSeasonCombinationManipulationList.AddParameter("manip1", clsRFunctionParameter:=clsEndSeasonConditionsFilterCalc, bIncludeArgumentName:=False, iPosition:=0)
        clsEndSeasonCombinationManipulationList.AddParameter("manip2", clsRFunctionParameter:=clsGroupByStationYearCalc, bIncludeArgumentName:=False, iPosition:=1)
        clsEndSeasonCombinationManipulationList.AddParameter("manip3", clsRFunctionParameter:=clsDoyFilterCalc, bIncludeArgumentName:=False, iPosition:=2)

        clsEndSeasonCombinationSubCalcList.SetRCommand("list")
        clsEndSeasonCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonFirstDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)

        clsGetColumnDataTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_data_types")
        clsGetColumnDataTypeFunction.SetAssignTo(strYearType)

        clsConvertColumnTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnTypeFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)

        clsGetlinkeddataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_linked_to_data_name")
        clsGetlinkeddataFunction.SetAssignTo("linked_data_name")

        clsVectorFunction.SetRCommand("c")

        clsConvertColumnType2Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnType2Function.AddParameter("data_name", "linked_data_name", iPosition:=0)
        clsConvertColumnType2Function.AddParameter("to_type", "year_type", iPosition:=2)

        clsConvertColumnType1Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnType1Function.AddParameter("to_type", "year_type", iPosition:=2)

#End Region
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnDataTypeFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertColumnTypeFunction, iPosition:=1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsGetlinkeddataFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsConvertColumnType1Function, iPosition:=1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsConvertColumnType2Function, iPosition:=2)

        clsFirstOrLastFunction = clsLastDoyFunction
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLastDoyFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstDoyFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsEndSeasonIsNaRain, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsIfElseRainMinFunction, New RParameter("no", 2), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsIfElseRainMaxFunction, New RParameter("no", 2), iAdditionalPairNo:=3)
        ucrReceiverEvaporation.AddAdditionalCodeParameterPair(clsWBMaxTailFunction1, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverEvaporation.AddAdditionalCodeParameterPair(clsAsNumericFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsFirstDateFunction, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        ucrInputEndRainDoy.SetRCode(clsEndRainsLastDoySummaryCalc, bReset)
        ucrInputEndofRainsDate.SetRCode(clsEndRainsLastDateSummaryCalc, bReset)
        ucrInputEndofRainsOccurence.SetRCode(clsEndRainsStatusSummaryCalc, bReset)

        ucrInputSeasonDoy.SetRCode(clsEndSeasonFirstDoySummaryCalc, bReset)
        ucrInputEndofSeasonDate.SetRCode(clsEndSeasonFirstDateSummaryCalc, bReset)
        ucrInputEndofSeasonOccurence.SetRCode(clsEndSeasonStatusSummaryCalc, bReset)

        ucrReceiverDate.SetRCode(clsLastDateFunction, bReset)

        ucrReceiverRainfall.SetRCode(clsRollSumRainFunction, bReset)

        ucrNudWBLessThan.SetRCode(clsEndSeasonWBConditionOperator, bReset)

        If bReset Then
            ucrChkWB.SetRCode(clsWBEvaporationMinFunction, bReset)
            ucrNudWB.SetRCode(clsWBEvaporationMinFunction, bReset)
            ucrPnlEvaporation.SetRCode(clsWBMinEvapOperator, bReset)
            ucrReceiverEvaporation.SetRCode(clsWBMinTailFunction1, bReset)
        End If

        ucrChkEndofSeasonDoy.SetRCode(clsEndSeasonCombinationSubCalcList, bReset)
        ucrChkEndofSeasonDate.SetRCode(clsDummyFunction, bReset)
        ucrChkEndofSeasonOccurence.SetRCode(clsDummyFunction, bReset)

        ucrNudAmount.SetRCode(clsEndRainsRollSumRainConditionOperator, bReset)
        ucrNudTotalOverDays.SetRCode(clsRollSumRainFunction, bReset)
        ucrChkEndofRainsDoy.SetRCode(clsEndRainsCombinationSubCalcList, bReset)
        ucrChkEndofRainsDate.SetRCode(clsDummyFunction, bReset)
        ucrChkEndofRainsOccurence.SetRCode(clsDummyFunction, bReset)
        ucrPnlEndOfRainsAndSeasons.SetRCode(clsFirstOrLastFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean = True

        'TODO change to radio buttons so only one can be checked at a time
        If rdoEndOfRains.Checked Then
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
        ElseIf rdoEndOfSeasons.Checked Then
            If ucrReceiverRainfall.IsEmpty OrElse ucrReceiverDate.IsEmpty OrElse ucrReceiverDOY.IsEmpty OrElse ucrReceiverYear.IsEmpty OrElse ucrNudCapacity.GetText = "" OrElse ucrNudWBLessThan.GetText = "" Then
                bOkEnabled = False
            ElseIf Not (ucrChkEndofSeasonDoy.Checked OrElse ucrChkEndofSeasonDate.Checked OrElse ucrChkEndofSeasonOccurence.Checked) Then
                bOkEnabled = False
            ElseIf ucrChkEndofSeasonDoy.Checked AndAlso ucrInputSeasonDoy.IsEmpty Then
                bOkEnabled = False
            ElseIf ucrChkEndofSeasonDate.Checked AndAlso ucrInputEndofSeasonDate.IsEmpty Then
                bOkEnabled = False
            ElseIf ucrChkEndofSeasonOccurence.Checked AndAlso ucrInputEndofSeasonOccurence.IsEmpty Then
                bOkEnabled = False
            ElseIf rdoValueEvaporation.Checked AndAlso ucrInputEvaporation.IsEmpty Then
                bOkEnabled = False
            ElseIf rdoVariableEvaporation.Checked AndAlso ucrReceiverEvaporation.IsEmpty Then
                bOkEnabled = False
            End If
        Else
            bOkEnabled = False
        End If
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDoyFilterCalc, clsNewDayFromOperator:=clsDayFromOperator, clsNewIfElseFirstDoyFilledFunction:=clsIfElseFirstDoyFilledFunction, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDoyFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
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
        clsEndSeasonFirstDoySummaryCalcFilledFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub RainfallChange()
        clsEndRainsRollingSumCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
        clsEndSeasonRainMinCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
        clsEndSeasonRainMaxCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub YearStationVariable()
        If Not ucrReceiverYear.IsEmpty Then
            clsVectorFunction.AddParameter("x", ucrReceiverYear.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
            If Not ucrReceiverStation.IsEmpty Then
                clsVectorFunction.AddParameter("y", ucrReceiverStation.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsVectorFunction.RemoveParameterByName("y")
            End If
            clsGetlinkeddataFunction.AddParameter("link_cols", clsRFunctionParameter:=clsVectorFunction, iPosition:=1)
        Else
            clsGetlinkeddataFunction.RemoveParameterByName("link_cols")
            clsVectorFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub ucrReceiverStationYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupingBy()
        YearStationVariable()
        If Not ucrReceiverYear.IsEmpty Then
            clsGetColumnDataTypeFunction.AddParameter("columns", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsConvertColumnTypeFunction.AddParameter("col_names", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsConvertColumnType1Function.AddParameter("col_names", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsConvertColumnType2Function.AddParameter("col_names", ucrReceiverYear.GetVariableNames(), iPosition:=1)
        Else
            clsConvertColumnType1Function.RemoveParameterByName("col_names")
            clsConvertColumnType2Function.RemoveParameterByName("col_names")
            clsGetColumnDataTypeFunction.RemoveParameterByName("columns")
            clsConvertColumnTypeFunction.RemoveParameterByName("col_names")
        End If
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
        clsGetColumnDataTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnType1Function.AddParameter("data_name", Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetlinkeddataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForWaterBalance.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrPnlEvaporation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlEvaporation.ControlValueChanged, ucrReceiverEvaporation.ControlValueChanged, ucrInputEvaporation.ControlValueChanged
        Evaporation()
    End Sub

    Private Sub Evaporation()
        If rdoEndOfSeasons.Checked Then
            clsPMaxFunction.RemoveParameterByName("0")
            clsPMaxFunction.RemoveParameterByName("0")
            clsWBMinEvapOperator.RemoveParameterByName("variable")
            clsWBMaxEvapOperator.RemoveParameterByName("variable")
            clsWBMaxEvapOperator.RemoveParameterByName("value")
            clsWBMinEvapOperator.RemoveParameterByName("value")
            clsPMaxFunction.RemoveParameterByName("wb")
            clsPMaxFunction.RemoveParameterByName("wb")
            clsPMinWBMaxFunction.AddParameter("1", ucrNudCapacity.GetText(), iPosition:=1, bIncludeArgumentName:=False)
            clsPMinWBMinFunction.AddParameter("1", ucrNudCapacity.GetText(), iPosition:=1, bIncludeArgumentName:=False)
            If rdoValueEvaporation.Checked Then
                clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction, iPosition:=1)
                clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction, iPosition:=1)
                If ucrChkWB.Checked Then
                    clsWBEvaporationMinFunction.AddParameter("WB_evap_value", ucrNudWB.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                    clsWBEvaporationMinFunction.AddParameter("yes", ucrNudCapacity.GetText(), iPosition:=2, bIncludeArgumentName:=False)
                    clsWBEvaporationMinFunction.AddParameter("value", ucrInputEvaporation.GetText(), iPosition:=3, bIncludeArgumentName:=False)
                    clsPMaxFunction.AddParameter("wb", clsROperatorParameter:=clsWBOperator1, iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMinFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMaxFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsWBMaxEvapOperator.AddParameter("value", ucrInputEvaporation.GetText(), iPosition:=1)
                    clsWBMinEvapOperator.AddParameter("value", ucrInputEvaporation.GetText(), iPosition:=1)
                    clsPMaxFunction.AddParameter("0", "..1 + ..2", iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMinFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMaxFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                End If
            Else
                ucrReceiverEvaporation.SetMeAsReceiver()
                If ucrChkWB.Checked Then
                    clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction1, iPosition:=1)
                    clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction1, iPosition:=1)
                    clsWBEvaporationMinFunction.AddParameter("WB_evap_value", ucrNudWB.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                    clsWBEvaporationMinFunction.AddParameter("yes", ucrNudCapacity.GetText(), iPosition:=2, bIncludeArgumentName:=False)
                    clsWBEvaporationMinFunction.AddParameter("value", "..3", bIncludeArgumentName:=False, iPosition:=3)
                    clsReduceWBMinFunction1.AddParameter(".y", clsRFunctionParameter:=clsWBMinTailFunction1, iPosition:=1)
                    clsReduceWBMaxFunction1.AddParameter(".y", clsRFunctionParameter:=clsWBMaxTailFunction1, iPosition:=1)
                    clsPMaxFunction.AddParameter("wb", clsROperatorParameter:=clsWBOperator1, iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMinFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMaxFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction2, iPosition:=1)
                    clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction2, iPosition:=1)
                    clsPMaxFunction.AddParameter("0", "..1 + ..2", iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMinFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                    clsPMinWBMaxFunction.AddParameter("0", clsRFunctionParameter:=clsPMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
                End If
            End If
        End If
    End Sub

    Private Sub ucrPnlEndOfRainsAndSeasons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlEndOfRainsAndSeasons.ControlValueChanged
        If rdoEndOfRains.Checked Then
            clsRunCalculation.AddParameter("calc", clsRFunctionParameter:=clsEndRainsCombinationCalc)
            clsFirstOrLastFunction = clsLastDoyFunction
        Else
            clsRunCalculation.AddParameter("calc", clsRFunctionParameter:=clsEndSeasonCombinationCalc)
            clsFirstOrLastFunction = clsFirstDoyFunction
            Evaporation()
        End If
    End Sub

    Private Sub ucrChkEndofRainsDoy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsDoy.ControlValueChanged
        If ucrChkEndofRainsDoy.Checked Then
            clsEndRainsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndRainsLastDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrChkEndofRainsDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsDate.ControlValueChanged
        If ucrChkEndofRainsDate.Checked Then
            clsEndRainsCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsEndRainsLastDateSummaryCalc, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkEndofSeasonOccurence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofSeasonOccurence.ControlValueChanged
        If ucrChkEndofSeasonOccurence.Checked Then
            clsEndSeasonCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsEndSeasonStatusSummaryCalc, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub3")
        End If
    End Sub

    Private Sub ucrChkEndofSeasonDoy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofSeasonDoy.ControlValueChanged
        If ucrChkEndofSeasonDoy.Checked Then
            clsEndSeasonCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonFirstDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)
            clsEndSeasonCombinationSubCalcList.AddParameter("sub4", clsRFunctionParameter:=clsEndSeasonFirstDoySummaryCalcFilledFunction, bIncludeArgumentName:=False, iPosition:=3)
        Else
            clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub1")
            clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub4")
        End If
    End Sub

    Private Sub ucrChkEndofSeasonDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofSeasonDate.ControlValueChanged
        If ucrChkEndofSeasonDate.Checked Then
            clsEndSeasonCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsEndSeasonFirstDateSummaryCalc, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsEndSeasonCombinationSubCalcList.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkEndofRainsOccurence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEndofRainsOccurence.ControlValueChanged
        If ucrChkEndofRainsOccurence.Checked Then
            clsEndRainsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsEndRainsStatusSummaryCalc, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsEndRainsCombinationSubCalcList.RemoveParameterByName("sub3")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlEndOfRainsAndSeasons.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrNudCapacity.ControlContentsChanged, ucrNudWBLessThan.ControlContentsChanged, ucrInputSeasonDoy.ControlContentsChanged, ucrNudTotalOverDays.ControlContentsChanged, ucrNudAmount.ControlContentsChanged, ucrChkEndofRainsDoy.ControlContentsChanged, ucrInputEndRainDoy.ControlContentsChanged, ucrChkEndofRainsDate.ControlContentsChanged, ucrInputEndofRainsDate.ControlContentsChanged, ucrChkEndofRainsOccurence.ControlContentsChanged, ucrInputEndofRainsOccurence.ControlContentsChanged, ucrChkEndofSeasonDoy.ControlContentsChanged, ucrPnlEvaporation.ControlContentsChanged, ucrReceiverEvaporation.ControlContentsChanged, ucrChkEndofSeasonOccurence.ControlContentsChanged, ucrInputEndofSeasonOccurence.ControlContentsChanged, ucrChkEndofSeasonDate.ControlContentsChanged, ucrInputEndofSeasonDate.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkWB_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWB.ControlValueChanged, ucrNudWB.ControlValueChanged, ucrNudCapacity.ControlValueChanged
        Evaporation()
    End Sub

    Private Sub rdoValueEvaporation_CheckedChanged(sender As Object, e As EventArgs) Handles rdoValueEvaporation.CheckedChanged, rdoVariableEvaporation.CheckedChanged
        Evaporation()
    End Sub

    Private Sub ucrNudWBLessThan_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudWBLessThan.ControlValueChanged, ucrChkEndofSeasonOccurence.ControlValueChanged, ucrInputEndofSeasonOccurence.ControlValueChanged, ucrChkEndofSeasonDate.ControlValueChanged, ucrInputEndofSeasonDate.ControlValueChanged, ucrChkEndofSeasonDoy.ControlValueChanged, ucrInputSeasonDoy.ControlValueChanged, ucrSelectorForWaterBalance.ControlValueChanged
        If Not ucrNudWBLessThan.IsEmpty Then
            clsEndSeasonWBConditionOperator.AddParameter("1", ucrNudWBLessThan.GetText(), iPosition:=1)
        Else
            clsEndSeasonWBConditionOperator.RemoveParameterByName("1")
        End If
        'Evaporation()
    End Sub
End Class