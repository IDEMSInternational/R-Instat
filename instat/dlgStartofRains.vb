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

Public Class dlgStartofRains
    Private clsCalcRainDay, clsCalcStartDOY, clsCalcStartDate, clsCombinationCalc, clsCombinationManipList, clsCombinationSubCalcList, clsListSubCalc, clsManipulationFirstDOYPerYear, clsConditionsFilter, clsCombinedList As New RFunction
    Private clsDayFromAndTo, clsGroupByStation, clsGroupByYear, clsListToTalRain, clsApplyInstatFunction, clsFirstDOY, clsFirstDate As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsRainDayOperator, clsRainDayConditionOperator, clsConditionsAndOperator, clsTRCombineOperator, clsRollingSumRainDayOperator, clsDSCombineOperator, clsDPCombineOperator As New ROperator
    Private clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction

    Private clsSpellsFunction As New RFunction
    Private clsRainDaySpellsOperator As New ROperator

    Private clsConditionsOrOverallOperator As New ROperator

    'Total Rainfall classes
    Private clsCalcRainRollingSum, clsRainRollingSumFunction, clsTRWetSpell, clsTRWetSpellList, clsTRWetSpellFunction As New RFunction
    Private clsSORFilter, clsSORFilterIfelse, clsSORFilterIsNA As New RFunction
    Private clsLessFilterOperator As New ROperator
    Private clsCalcStatus, clsIfelseStartDOY, clsIfelseStartDate, clsSORIsNA As New RFunction
    Private clsSORStartSummary As New clsRains
    Private clsSORStatusSummary As New clsRains

    Private clsIsNaOperatorStartDOY As New ROperator

    Private clsFirstRain As New RFunction
    Private clsIsNaFirstRain As New RFunction

    Private clsFirstRollSumRain As New RFunction
    Private clsIsNaFirstRollSumRain As New RFunction

    Private clsFirstRollSumRainDay As New RFunction
    Private clsIsNaFirstRollSumRainDay As New RFunction

    Private clsFirstDrySpell As New RFunction
    Private clsIsNaFirstDrySpell As New RFunction

    Private clsFirstDryPeriod As New RFunction
    Private clsIsNaFirstDryPeriod As New RFunction

    Private clsIsNaRain As New RFunction
    Private clsIsNaRollSumRain As New RFunction
    Private clsIsNaRollSumRainDay As New RFunction
    Private clsIsNaDrySpell As New RFunction
    Private clsIsNaDryPeriod As New RFunction

    'Rainy Day classes
    Private clsCalcRainDayRollingSum, clsRainDayRollingSumFunction, clsRDRollingRainDaysSub As New RFunction
    'Dry Spell classes
    Private clsCalcDrySpellRollMax, clsCalcDrySpell, clsDrySpellPeriodLeadFunction, clsDrySpellPeriodRollMaxFunction, clsDrySpellPeriodSubCalcList, clsDrySpellSubCalcList As New RFunction

    'Dry Period classes
    Private clsCalcRollSumNumberDryPeriod, clsRollSumNumberDryPeriodSubCalcList, clsCalcRainRollingSumDryPeriod, clsLeadRollingSumRainDryPeriodFunction, clsRollingSumRainDryPeriodFunction, clsRollSumNumberDryPeriodFunction As New RFunction
    Private clsSumRainDryPeriodOperator, clsSumRainDryPeriodIntervalMinusOperator, clsSumRainDryPeriodIntervalPlusOperator As New ROperator
    Private strCurrDataName As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strWetSpell As String = "wet_spell"

    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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
        ucrBase.iHelpTopicID = 199

        ' setting the selector
        ucrSelectorForStartofRains.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForStartofRains.SetParameterIsString()

        ' setting receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 1, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForStartofRains
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("date", 0, False))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.bWithQuotes = False
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverRainfall.SetParameter(New RParameter("x", 0))
        ucrReceiverRainfall.SetParameterIsString()
        ucrReceiverRainfall.bWithQuotes = False
        ucrReceiverRainfall.strSelectorHeading = "Rain Variables"
        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverRainfall.SetClimaticType("rain")
        ucrReceiverRainfall.bAutoFill = True

        ucrNudThreshold.SetParameter(New RParameter("threshold", 1))
        ucrNudThreshold.DecimalPlaces = 2

        'Total Rainfall
        ucrPnlTRCalculateBy.AddRadioButton(rdoTRAmount)
        ucrPnlTRCalculateBy.AddRadioButton(rdoTRPercentile)
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRAmount, "tr_perc_sub", False)
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRPercentile, "tr_perc_sub")
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudTRPercentile, {rdoTRPercentile}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.8)
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudTRAmount, {rdoTRAmount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=20)
        ucrPnlTRCalculateBy.SetLinkedDisplayControl(lblTRVal)
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRPercentile, "tr_perc")
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRAmount, "tr_amount")

        ucrNudTRAmount.SetParameter(New RParameter("tr_amount", 1, False), False)
        ucrNudTRAmount.SetMinMax(1, Integer.MaxValue)

        ucrChkTotalRainfall.SetParameter(New RParameter("tr_sub", clsCalcRainRollingSum, 1, False), False)
        ucrChkTotalRainfall.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("total_rainfall", clsTRCombineOperator, 1, False), iAdditionalPairNo:=1)
        ucrChkTotalRainfall.SetText("Total Rainfall")
        ucrChkTotalRainfall.AddToLinkedControls(ucrNudTROverDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudTROverDays.SetLinkedDisplayControl(lblTROverDays)
        ucrChkTotalRainfall.AddToLinkedControls(ucrPnlTRCalculateBy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoTRAmount)

        ucrNudTROverDays.SetParameter(New RParameter("n", 1))
        ucrNudTROverDays.SetMinMax(1, 366)

        ucrNudTRPercentile.SetParameter(New RParameter("probs", 1))
        ucrNudTRPercentile.SetMinMax(0, 1)
        ucrNudTRPercentile.DecimalPlaces = 2
        ucrNudTRPercentile.Increment = 0.1

        'Number of Rainy days
        ucrChkNumberOfRainyDays.SetParameter(New RParameter("rd_sub", clsCalcRainDayRollingSum, 2, False), False)
        ucrChkNumberOfRainyDays.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("rain_days", clsRollingSumRainDayOperator, 2, False), iAdditionalPairNo:=1)
        ucrChkNumberOfRainyDays.SetText("Number of Rainy Days")

        ucrNudRDMinimumDays.SetParameter(New RParameter("1", 1))
        ucrNudRDMinimumDays.SetLinkedDisplayControl(lblRDMinimum)
        ucrNudRDMinimumDays.SetMinMax(1, 366)

        ucrNudRDOutOfDays.SetParameter(New RParameter("n", 1))
        ucrNudRDOutOfDays.SetLinkedDisplayControl(lblRDWidth)
        ucrNudRDOutOfDays.SetMinMax(1, 366)

        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDMinimumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDOutOfDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)

        'Dry Spell
        ucrChkDrySpell.SetParameter(New RParameter("ds_sub", clsCalcDrySpellRollMax, 3, False), False)
        ucrChkDrySpell.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("dry_spell", clsDSCombineOperator, 3, False), iAdditionalPairNo:=1)
        ucrChkDrySpell.SetText("Dry Spell")
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSLengthOfTime, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=21)
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSMaximumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=9)
        ucrNudDSLengthOfTime.SetLinkedDisplayControl(lblDSLengthofTime)
        ucrNudDSMaximumDays.SetLinkedDisplayControl(lblDSMaximumDays)

        ucrNudDSLengthOfTime.SetParameter(New RParameter("n", 1))
        ucrNudDSLengthOfTime.SetMinMax(1, 366)

        ucrNudDSMaximumDays.SetParameter(New RParameter("ds_max", 1))
        ucrNudDSMaximumDays.SetMinMax(1, 366)

        ' Dry Period
        ucrChkDryPeriod.SetParameter(New RParameter("dp_sub", clsCalcRollSumNumberDryPeriod, 3, False), False)
        ucrChkDryPeriod.AddAdditionalCodeParameterPair(clsConditionsAndOperator, New RParameter("dry_period", clsDPCombineOperator, 4, False), iAdditionalPairNo:=1)
        ucrChkDryPeriod.SetText("Dry Period")

        ucrNudDPRainPeriod.SetParameter(New RParameter("n", 0))
        ucrNudDPRainPeriod.SetLinkedDisplayControl(lblDPLength)
        ucrNudDPRainPeriod.SetMinMax(1, 366)

        ucrNudDPMaxRain.SetParameter(New RParameter("right", 1))
        ucrNudDPMaxRain.SetLinkedDisplayControl(lblDPMaxRain)
        ucrNudDPMaxRain.SetMinMax(1, Integer.MaxValue)

        ucrNudDPOverallInterval.SetParameter(New RParameter("0", 0))
        ucrNudDPOverallInterval.SetLinkedDisplayControl(lblDPOverallInterval)
        ucrNudDPOverallInterval.SetMinMax(1, 366)

        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPMaxRain, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=40)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPOverallInterval, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=45)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPRainPeriod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)

        'save
        ucrInputNewDoyColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewDoyColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewDoyColumnName.SetName("start_rain")

        ucrInputNewDateColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewDateColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewDateColumnName.SetName("start_rain_date")

        ucrInputNewStatusColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewStatusColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewStatusColumnName.SetName("start_rain_status")

        ucrChkAsDoy.AddToLinkedControls(ucrInputNewDoyColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAsDate.AddToLinkedControls(ucrInputNewDateColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStatus.AddToLinkedControls(ucrInputNewStatusColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAsDoy.AddParameterPresentCondition(True, "sub1", True)
        ucrChkAsDoy.AddParameterPresentCondition(False, "sub1", False)
        ucrChkAsDoy.SetText("Day of Year")

        ucrChkAsDate.AddParameterPresentCondition(True, "sub2", True)
        ucrChkAsDate.AddParameterPresentCondition(False, "sub2", False)
        ucrChkAsDate.SetText("Date")

        ucrChkStatus.AddParameterPresentCondition(True, "sub3", True)
        ucrChkStatus.AddParameterPresentCondition(False, "sub3", False)
        ucrChkStatus.SetText("Occurrence")
    End Sub

    Private Sub SetDefaults()
        Dim strRainDay As String = "rain_day"
        Dim strRollSumRainDay As String = "roll_n_rain_days"
        Dim strDrySpell As String = "dry_spell"
        Dim strRollMaxDrySpell As String = "roll_max_dry_spell"
        Dim strAboveThreshold As String = "above_threshold"
        Dim strRollSumNumberDryPeriod As String = "n_dry_period"
        Dim strRollSumRain As String = "roll_sum_rain"
        Dim strStartDate As String = "start_rain_date"
        Dim strStartStatus As String = "start_rain_status"
        Dim strStartDoy As String = "start_rain"
        Dim strRollSumRainDryPeriod As String = "roll_sum_rain_dry_period"

        clsDayFromAndTo.Clear()
        clsDayFromAndToOperator.Clear()
        clsGroupByStation.Clear()
        clsGroupByYear.Clear()
        clsCalcRainDay.Clear()
        clsRainDayOperator.Clear()
        clsRainDayConditionOperator.Clear()
        clsCalcStartDOY.Clear()
        clsConditionsOrOverallOperator.Clear()
        clsConditionsFilter.Clear()
        clsCombinedList.Clear()
        clsCombinationCalc.Clear()
        clsListSubCalc.Clear()
        clsCombinationSubCalcList.Clear()

        clsSpellsFunction.Clear()
        clsRainDaySpellsOperator.Clear()

        clsFirstDOY.Clear()

        clsIsNaOperatorStartDOY.Clear()
        clsIsNaFirstRain.Clear()
        clsFirstRain.Clear()

        clsIsNaRain.Clear()
        clsIsNaRollSumRain.Clear()
        clsIsNaRollSumRainDay.Clear()
        clsIsNaDrySpell.Clear()
        clsIsNaDryPeriod.Clear()

        clsFirstRollSumRain.Clear()
        clsIsNaFirstRollSumRain.Clear()

        clsFirstRollSumRainDay.Clear()
        clsIsNaFirstRollSumRainDay.Clear()

        clsFirstDrySpell.Clear()
        clsIsNaFirstDrySpell.Clear()

        clsFirstDryPeriod.Clear()
        clsIsNaFirstDryPeriod.Clear()

        clsCalcRainRollingSum.Clear()
        clsRainRollingSumFunction = New RFunction
        clsTRWetSpellList.Clear()
        clsTRWetSpell.Clear()
        clsTRWetSpellFunction.Clear()
        clsCalcRainDayRollingSum.Clear()
        clsRainDayRollingSumFunction.Clear()
        clsRDRollingRainDaysSub.Clear()
        clsSORFilter.Clear()

        clsCalcDrySpell.Clear()
        clsDrySpellPeriodSubCalcList.Clear()
        clsCalcDrySpellRollMax.Clear()
        clsDrySpellPeriodRollMaxFunction.Clear()
        clsDrySpellSubCalcList.Clear()
        clsDrySpellPeriodLeadFunction.Clear()

        clsCalcRainRollingSumDryPeriod.Clear()
        clsRollSumNumberDryPeriodSubCalcList.Clear()
        clsCalcRollSumNumberDryPeriod.Clear()
        clsRollSumNumberDryPeriodFunction.Clear()
        clsLeadRollingSumRainDryPeriodFunction.Clear()
        clsRollingSumRainDryPeriodFunction.Clear()
        clsSumRainDryPeriodOperator.Clear()
        clsRollSumNumberDryPeriodFunction.Clear()
        clsSumRainDryPeriodIntervalMinusOperator.Clear()
        clsSumRainDryPeriodIntervalPlusOperator.Clear()
        clsApplyInstatFunction.Clear()

        clsIfelseStartDOY.Clear()
        clsIfelseStartDate.Clear()

        clsTRCombineOperator.Clear()
        clsRollingSumRainDayOperator.Clear()
        clsDSCombineOperator.Clear()
        clsDPCombineOperator.Clear()

        ucrReceiverRainfall.SetMeAsReceiver()
        ucrSelectorForStartofRains.Reset()

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        'Day From and To
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndTo.AddParameter("calculated_from", clsRFunctionParameter:=clsDayFilterCalcFromConvert, iPosition:=2)
        clsDayFromAndTo.SetAssignTo("doy_filter")

        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndToOperator.bBrackets = False
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)

        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)

        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)

        ' group_by_station
        clsGroupByStation.SetRCommand("instat_calculation$new")
        clsGroupByStation.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStation.SetAssignTo("grouping_by_station")

        ' group_by_year
        clsGroupByYear.SetRCommand("instat_calculation$new")
        clsGroupByYear.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByYear.SetAssignTo("grouping_by_year")

        'TOTAL RAIN: associated with ucrChkTotalRainfall
        clsCalcRainRollingSum.SetRCommand("instat_calculation$new")
        clsCalcRainRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRainRollingSum.AddParameter("function_exp", clsRFunctionParameter:=clsRainRollingSumFunction, iPosition:=1)
        clsCalcRainRollingSum.AddParameter("result_name", Chr(34) & strRollSumRain & Chr(34), iPosition:=2)
        clsCalcRainRollingSum.SetAssignTo(strRollSumRain)

        clsRainRollingSumFunction.SetPackageName("RcppRoll")
        clsRainRollingSumFunction.SetRCommand("roll_sumr")
        clsRainRollingSumFunction.AddParameter("n", 2, iPosition:=1)
        clsRainRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRainRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRainRollingSumFunction.bToScriptAsRString = True

        clsFirstRollSumRain.SetPackageName("dplyr")
        clsFirstRollSumRain.SetRCommand("first")
        clsFirstRollSumRain.AddParameter("x", strRollSumRain, iPosition:=0)

        clsIsNaFirstRollSumRain.SetRCommand("is.na")
        clsIsNaFirstRollSumRain.AddParameter("x", clsRFunctionParameter:=clsFirstRollSumRain, iPosition:=0)

        ' RAINY DAY associated with ucrChkNumberOfRainyDays
        clsCalcRainDay.SetRCommand("instat_calculation$new")
        clsCalcRainDay.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRainDay.AddParameter("function_exp", clsROperatorParameter:=clsRainDayOperator, iPosition:=1)
        clsCalcRainDay.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsCalcRainDay.SetAssignTo(strRainDay)

        clsRainDayOperator.SetOperation(">=")
        clsRainDayOperator.bToScriptAsRString = True
        clsRainDayOperator.AddParameter("threshold", 0.85, iPosition:=1)

        clsCalcRainDayRollingSum.SetRCommand("instat_calculation$new")
        clsCalcRainDayRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRainDayRollingSum.AddParameter("function_exp", clsRFunctionParameter:=clsRainDayRollingSumFunction, iPosition:=1)
        clsCalcRainDayRollingSum.AddParameter("result_name", Chr(34) & strRollSumRainDay & Chr(34), iPosition:=2)
        clsCalcRainDayRollingSum.AddParameter("sub_calculations", clsRFunctionParameter:=clsRDRollingRainDaysSub, iPosition:=4)
        clsCalcRainDayRollingSum.SetAssignTo(strRollSumRainDay)

        clsRainDayRollingSumFunction.SetPackageName("RcppRoll")
        clsRainDayRollingSumFunction.SetRCommand("roll_sumr")
        clsRainDayRollingSumFunction.AddParameter("x", strRainDay, iPosition:=0)
        clsRainDayRollingSumFunction.AddParameter("n", 2, iPosition:=1)
        clsRainDayRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRainDayRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRainDayRollingSumFunction.bToScriptAsRString = True

        clsRDRollingRainDaysSub.SetRCommand("list")
        clsRDRollingRainDaysSub.AddParameter("sub1", clsRFunctionParameter:=clsCalcRainDay, bIncludeArgumentName:=False, iPosition:=0)

        clsRollingSumRainDayOperator.SetOperation(">=")
        clsRollingSumRainDayOperator.AddParameter("0", strRollSumRainDay, iPosition:=0)
        clsRollingSumRainDayOperator.AddParameter("1", 1, iPosition:=1)

        clsFirstRollSumRainDay.SetPackageName("dplyr")
        clsFirstRollSumRainDay.SetRCommand("first")
        clsFirstRollSumRainDay.AddParameter("x", strRollSumRainDay, iPosition:=0)

        clsIsNaFirstRollSumRainDay.SetRCommand("is.na")
        clsIsNaFirstRollSumRainDay.AddParameter("x", clsRFunctionParameter:=clsFirstRollSumRainDay, iPosition:=0)

        clsListToTalRain.SetRCommand("list")

        'SOR_Filter
        clsSORFilter.SetRCommand("instat_calculation$new")
        clsSORFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsSORFilter.AddParameter("function_exp", clsROperatorParameter:=clsLessFilterOperator, iPosition:=1)
        clsSORFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsListSubCalc, iPosition:=4)
        clsSORFilter.SetAssignTo("start_of_rains_filter")

        clsSORFilterIsNA.SetRCommand("is.na")
        clsSORFilterIsNA.AddParameter("start", clsROperatorParameter:=clsSORStartSummary.clsSORFilterOperator, bIncludeArgumentName:=False)

        clsSORFilterIfelse.SetRCommand("ifelse")
        clsSORFilterIfelse.AddParameter("is.na", clsRFunctionParameter:=clsSORFilterIsNA, bIncludeArgumentName:=False, iPosition:=0)
        clsSORFilterIfelse.AddParameter("366", "366", bIncludeArgumentName:=False, iPosition:=1)
        clsSORFilterIfelse.AddParameter("start", clsROperatorParameter:=clsSORStartSummary.clsSORFilterOperator, bIncludeArgumentName:=False, iPosition:=2)

        clsLessFilterOperator.SetOperation("<=")
        clsLessFilterOperator.AddParameter("right", clsRFunctionParameter:=clsSORFilterIfelse, bIncludeArgumentName:=False, iPosition:=1)
        clsLessFilterOperator.bToScriptAsRString = True

        clsSORStatusSummary.SetDefaults()
        clsSORStatusSummary.clsIsNaIfelse.bToScriptAsRString = True

        ' Quantile checked:
        ' this function is associated with that rdo.
        clsTRWetSpellFunction.bToScriptAsRString = True
        clsTRWetSpellList.SetRCommand("list")
        clsTRWetSpellList.AddParameter("sub1", clsRFunctionParameter:=clsCalcRainRollingSum, bIncludeArgumentName:=False)
        clsTRWetSpell.SetRCommand("instat_calculation$new")
        clsTRWetSpell.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsTRWetSpell.AddParameter("function_exp", clsRFunctionParameter:=clsTRWetSpellFunction, iPosition:=1)
        clsTRWetSpellFunction.SetRCommand("quantile")
        clsTRWetSpellFunction.AddParameter("x", strRollSumRain, iPosition:=0)
        clsTRWetSpellFunction.AddParameter("probs", 0.8, iPosition:=1)
        clsTRWetSpellFunction.AddParameter("na.rm", "TRUE", iPosition:=2)
        clsTRWetSpell.AddParameter("result_name", Chr(34) & strWetSpell & Chr(34), iPosition:=2)
        clsTRWetSpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsTRWetSpellList, iPosition:=4)
        clsTRWetSpell.SetAssignTo("total_rainfall_wet_spell")

        'DRY SPELL associated with ucrChkDrySpell
        clsCalcDrySpell.SetRCommand("instat_calculation$new")
        clsCalcDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcDrySpell.AddParameter("function_exp", clsRFunctionParameter:=clsSpellsFunction, iPosition:=1)
        clsCalcDrySpell.AddParameter("result_name", Chr(34) & strDrySpell & Chr(34), iPosition:=2)
        clsCalcDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsDrySpellSubCalcList, iPosition:=4)
        clsCalcDrySpell.SetAssignTo(strDrySpell)

        clsDrySpellSubCalcList.SetRCommand("list")
        clsDrySpellSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcRainDay, bIncludeArgumentName:=False)

        clsSpellsFunction.SetRCommand(".spells")
        clsSpellsFunction.AddParameter("x", clsROperatorParameter:=clsRainDaySpellsOperator, iPosition:=0)
        clsSpellsFunction.bToScriptAsRString = True

        clsRainDaySpellsOperator.SetOperation("==")
        clsRainDaySpellsOperator.AddParameter("0", strRainDay, iPosition:=0)
        clsRainDaySpellsOperator.AddParameter("1", "0", iPosition:=1)

        clsCalcDrySpellRollMax.SetRCommand("instat_calculation$new")
        clsCalcDrySpellRollMax.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcDrySpellRollMax.AddParameter("function_exp", clsRFunctionParameter:=clsDrySpellPeriodLeadFunction, iPosition:=1)
        clsCalcDrySpellRollMax.AddParameter("result_name", Chr(34) & strRollMaxDrySpell & Chr(34), iPosition:=2)
        clsCalcDrySpellRollMax.AddParameter("sub_calculations", clsRFunctionParameter:=clsDrySpellPeriodSubCalcList, iPosition:=4)
        clsCalcDrySpellRollMax.SetAssignTo(strRollMaxDrySpell)

        clsDrySpellPeriodSubCalcList.SetRCommand("list")
        clsDrySpellPeriodSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcDrySpell, bIncludeArgumentName:=False)

        clsDrySpellPeriodLeadFunction.SetPackageName("dplyr")
        clsDrySpellPeriodLeadFunction.SetRCommand("lead")
        clsDrySpellPeriodLeadFunction.bToScriptAsRString = True
        clsDrySpellPeriodLeadFunction.AddParameter("x", clsRFunctionParameter:=clsDrySpellPeriodRollMaxFunction)

        clsDrySpellPeriodRollMaxFunction.SetPackageName("RcppRoll")
        clsDrySpellPeriodRollMaxFunction.SetRCommand("roll_maxl")
        clsDrySpellPeriodRollMaxFunction.AddParameter("x", strDrySpell, iPosition:=0)
        clsDrySpellPeriodRollMaxFunction.AddParameter("n", 21, iPosition:=1)
        clsDrySpellPeriodRollMaxFunction.AddParameter("fill", "NA", iPosition:=2)

        clsFirstDrySpell.SetPackageName("dplyr")
        clsFirstDrySpell.SetRCommand("first")
        clsFirstDrySpell.AddParameter("x", strRollMaxDrySpell, iPosition:=0)

        clsIsNaFirstDrySpell.SetRCommand("is.na")
        clsIsNaFirstDrySpell.AddParameter("x", clsRFunctionParameter:=clsFirstDrySpell, iPosition:=0)

        'DRY PERIOD

        clsCalcRainRollingSumDryPeriod.SetRCommand("instat_calculation$new")
        clsCalcRainRollingSumDryPeriod.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRainRollingSumDryPeriod.AddParameter("function_exp", clsRFunctionParameter:=clsLeadRollingSumRainDryPeriodFunction, iPosition:=1)
        clsCalcRainRollingSumDryPeriod.AddParameter("result_name", Chr(34) & strRollSumRainDryPeriod & Chr(34), iPosition:=2)
        clsCalcRainRollingSumDryPeriod.SetAssignTo(strRollSumRainDryPeriod)

        clsLeadRollingSumRainDryPeriodFunction.SetRCommand("lead")
        clsLeadRollingSumRainDryPeriodFunction.AddParameter("x", clsRFunctionParameter:=clsRollingSumRainDryPeriodFunction)
        clsLeadRollingSumRainDryPeriodFunction.bToScriptAsRString = True

        clsRollingSumRainDryPeriodFunction.SetPackageName("RcppRoll")
        clsRollingSumRainDryPeriodFunction.SetRCommand("roll_suml")
        clsRollingSumRainDryPeriodFunction.AddParameter("n", 30, iPosition:=1)
        clsRollingSumRainDryPeriodFunction.AddParameter("fill", "NA", iPosition:=2)

        clsCalcRollSumNumberDryPeriod.SetRCommand("instat_calculation$new")
        clsCalcRollSumNumberDryPeriod.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRollSumNumberDryPeriod.AddParameter("function_exp", clsRFunctionParameter:=clsRollSumNumberDryPeriodFunction, iPosition:=1)
        clsCalcRollSumNumberDryPeriod.AddParameter("sub_calculations", clsRFunctionParameter:=clsRollSumNumberDryPeriodSubCalcList, iPosition:=4)
        clsCalcRollSumNumberDryPeriod.AddParameter("result_name", Chr(34) & strRollSumNumberDryPeriod & Chr(34), iPosition:=2)
        clsCalcRollSumNumberDryPeriod.SetAssignTo(strRollSumNumberDryPeriod)

        clsRollSumNumberDryPeriodSubCalcList.SetRCommand("list")
        clsRollSumNumberDryPeriodSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcRainRollingSumDryPeriod, bIncludeArgumentName:=False)

        clsRollSumNumberDryPeriodFunction.bToScriptAsRString = True
        clsRollSumNumberDryPeriodFunction.SetPackageName("RcppRoll")
        clsRollSumNumberDryPeriodFunction.SetRCommand("roll_suml")
        clsRollSumNumberDryPeriodFunction.AddParameter("x", clsROperatorParameter:=clsSumRainDryPeriodOperator, iPosition:=0)
        clsRollSumNumberDryPeriodFunction.AddParameter("n", clsROperatorParameter:=clsSumRainDryPeriodIntervalMinusOperator, iPosition:=1)
        clsRollSumNumberDryPeriodFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollSumNumberDryPeriodFunction.AddParameter("na.rm", "FALSE", iPosition:=3)

        clsSumRainDryPeriodOperator.SetOperation("<=")
        clsSumRainDryPeriodOperator.AddParameter("left", strRollSumRainDryPeriod, iPosition:=0)
        clsSumRainDryPeriodOperator.AddParameter("right", 40, iPosition:=1)

        clsSumRainDryPeriodIntervalMinusOperator.SetOperation("-")
        clsSumRainDryPeriodIntervalMinusOperator.AddParameter("0", 45, iPosition:=0)
        clsSumRainDryPeriodIntervalMinusOperator.AddParameter("1", clsROperatorParameter:=clsSumRainDryPeriodIntervalPlusOperator, iPosition:=1)

        clsSumRainDryPeriodIntervalPlusOperator.SetOperation("+")
        clsSumRainDryPeriodIntervalPlusOperator.AddParameter("n", 30, iPosition:=0)
        clsSumRainDryPeriodIntervalPlusOperator.AddParameter("1", 1, iPosition:=1)

        clsFirstDryPeriod.SetPackageName("dplyr")
        clsFirstDryPeriod.SetRCommand("first")
        clsFirstDryPeriod.AddParameter("x", strRollSumNumberDryPeriod, iPosition:=0)

        clsIsNaFirstDryPeriod.SetRCommand("is.na")
        clsIsNaFirstDryPeriod.AddParameter("x", clsRFunctionParameter:=clsFirstDryPeriod, iPosition:=0)

        ' Combined filter
        clsConditionsFilter.SetRCommand("instat_calculation$new")
        clsConditionsFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsConditionsFilter.AddParameter("function_exp", clsROperatorParameter:=clsConditionsOrOverallOperator, iPosition:=1)
        clsConditionsFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedList, iPosition:=4)
        clsConditionsFilter.SetAssignTo("conditions_filter")

        clsCombinedList.SetRCommand("list")
        clsCombinedList.AddParameter("tr_sub", clsRFunctionParameter:=clsCalcRainRollingSum, bIncludeArgumentName:=False)

        clsConditionsOrOverallOperator.SetOperation("|")
        clsConditionsOrOverallOperator.bToScriptAsRString = True
        clsConditionsOrOverallOperator.AddParameter("conditions", clsROperatorParameter:=clsConditionsAndOperator, iPosition:=0)
        clsConditionsOrOverallOperator.AddParameter("is.na_rain", clsRFunctionParameter:=clsIsNaRain, iPosition:=1)

        clsConditionsAndOperator.AddParameter("rain", clsROperatorParameter:=clsRainDayConditionOperator, iPosition:=0)
        clsConditionsAndOperator.SetOperation("&")

        clsRainDayConditionOperator.SetOperation(">=")
        clsRainDayConditionOperator.AddParameter("threshold", 0.85, iPosition:=1)

        clsIsNaRain.SetRCommand("is.na")

        clsIsNaRollSumRain.SetRCommand("is.na")
        clsIsNaRollSumRain.AddParameter("x", strRollSumRain, iPosition:=0)

        clsIsNaRollSumRainDay.SetRCommand("is.na")
        clsIsNaRollSumRainDay.AddParameter("x", strRollSumRainDay, iPosition:=0)

        clsIsNaDrySpell.SetRCommand("is.na")
        clsIsNaDrySpell.AddParameter("x", strRollMaxDrySpell, iPosition:=0)

        clsIsNaDryPeriod.SetRCommand("is.na")
        clsIsNaDryPeriod.AddParameter("x", strRollSumNumberDryPeriod, iPosition:=0)

        ' run if chkTR is checked
        clsTRCombineOperator.SetOperation(">")
        clsTRCombineOperator.AddParameter("tr_left", strRollSumRain, iPosition:=0)

        ' run if chkDS is checked
        clsDSCombineOperator.SetOperation("<=")
        clsDSCombineOperator.AddParameter("ds_left", strRollMaxDrySpell, iPosition:=0)
        clsDSCombineOperator.AddParameter("ds_max", 9, iPosition:=1)

        ' run if chkDP is checked
        clsDPCombineOperator.SetOperation("==")
        clsDPCombineOperator.AddParameter("dp_left", strRollSumNumberDryPeriod, iPosition:=0)
        clsDPCombineOperator.AddParameter("dp_max", 0, iPosition:=1)

        ' First DOY
        clsCalcStartDOY.SetRCommand("instat_calculation$new")
        clsCalcStartDOY.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartDOY.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartDOY, iPosition:=1)
        clsCalcStartDOY.AddParameter("result_name", Chr(34) & strStartDoy & Chr(34), iPosition:=2)
        clsCalcStartDOY.AddParameter("save", 2, iPosition:=6)
        clsCalcStartDOY.SetAssignTo("start_of_rains_doy")

        clsIfelseStartDOY.SetRCommand("ifelse")
        clsIfelseStartDOY.bToScriptAsRString = True
        clsIfelseStartDOY.AddParameter("test", clsROperatorParameter:=clsIsNaOperatorStartDOY, iPosition:=0)
        clsIfelseStartDOY.AddParameter("yes", "NA", iPosition:=1)
        clsIfelseStartDOY.AddParameter("no", clsRFunctionParameter:=clsFirstDOY, iPosition:=2)

        clsFirstDOY.SetPackageName("dplyr")
        clsFirstDOY.SetRCommand("first")
        clsFirstDOY.AddParameter("default", "NA", iPosition:=1)

        clsIsNaOperatorStartDOY.SetOperation("|")
        clsIsNaOperatorStartDOY.AddParameter("0", clsRFunctionParameter:=clsIsNaFirstRain, iPosition:=0)

        clsIsNaFirstRain.SetRCommand("is.na")
        clsIsNaFirstRain.AddParameter("x", clsRFunctionParameter:=clsFirstRain, iPosition:=0)

        clsFirstRain.SetPackageName("dplyr")
        clsFirstRain.SetRCommand("first")

        'First Date
        clsCalcStartDate.SetRCommand("instat_calculation$new")
        clsCalcStartDate.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartDate.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartDate, iPosition:=1)
        clsCalcStartDate.AddParameter("result_name", Chr(34) & strStartDate & Chr(34), iPosition:=2)
        clsCalcStartDate.AddParameter("save", 2, iPosition:=6)
        clsCalcStartDate.SetAssignTo(strStartDate)

        clsIfelseStartDate.SetPackageName("dplyr")
        clsIfelseStartDate.SetRCommand("if_else")
        clsIfelseStartDate.bToScriptAsRString = True
        clsIfelseStartDate.AddParameter("condition", clsROperatorParameter:=clsIsNaOperatorStartDOY, iPosition:=0)
        clsIfelseStartDate.AddParameter("true", "as.Date(NA)", iPosition:=1)
        clsIfelseStartDate.AddParameter("false", clsRFunctionParameter:=clsFirstDate, iPosition:=2)

        clsFirstDate.SetPackageName("dplyr")
        clsFirstDate.SetRCommand("first")
        clsFirstDate.AddParameter("default", "NA", iPosition:=1)

        ' Status
        clsCalcStatus.SetRCommand("instat_calculation$new")
        clsCalcStatus.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStatus.AddParameter("function_exp", Chr(34) & "n() > 0" & Chr(34), iPosition:=1)
        clsCalcStatus.AddParameter("result_name", Chr(34) & strStartStatus & Chr(34), iPosition:=3)
        clsCalcStatus.AddParameter("save", 2, iPosition:=4)
        clsCalcStatus.SetAssignTo("start_of_rains_status")

        'Combination
        clsCombinationCalc.SetRCommand("instat_calculation$new")
        clsCombinationCalc.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationCalc.AddParameter("manipulations", clsRFunctionParameter:=clsCombinationManipList, iPosition:=1)
        clsCombinationCalc.AddParameter("sub_calculation", clsRFunctionParameter:=clsCombinationSubCalcList, iPosition:=2)
        clsCombinationCalc.SetAssignTo("start_of_rains_combined")

        clsCombinationManipList.SetRCommand("list")
        clsCombinationManipList.AddParameter("manip2", clsRFunctionParameter:=clsConditionsFilter, bIncludeArgumentName:=False, iPosition:=1)
        clsCombinationManipList.AddParameter("manip3", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=2)
        clsCombinationManipList.AddParameter("manip4", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=3)

        clsCombinationSubCalcList.SetRCommand("list")
        clsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False, iPosition:=0)

        'Sub_Calculations List
        clsListSubCalc.SetRCommand("list")
        clsListSubCalc.AddParameter("sub1", iPosition:=0, clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False)

        'Run Calculations
        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsCombinationCalc, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstDOY, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLessFilterOperator, New RParameter("doy", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRollingSumRainDryPeriodFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainDayOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainDayConditionOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsFirstRain, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsIsNaRain, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrNudThreshold.AddAdditionalCodeParameterPair(clsRainDayConditionOperator, New RParameter("threshold", 1), iAdditionalPairNo:=1)

        'clsSORStartSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=4)
        'clsSORStatusSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=5)

        ucrNudDPRainPeriod.AddAdditionalCodeParameterPair(clsSumRainDryPeriodIntervalPlusOperator, ucrNudDPRainPeriod.GetParameter(), iAdditionalPairNo:=1)
        ucrInputNewDoyColumnName.AddAdditionalCodeParameterPair(clsCalcStartDOY, New RParameter("result_name", 3), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrChkAsDoy.SetRCode(clsCombinationSubCalcList, bReset)
        ucrChkStatus.SetRCode(clsCombinationSubCalcList, bReset)
        ucrChkAsDate.SetRCode(clsCombinationSubCalcList, bReset)
        ucrNudThreshold.SetRCode(clsRainDayOperator, bReset)

        ucrReceiverDate.SetRCode(clsFirstDate, bReset)
        ucrInputNewDoyColumnName.SetRCode(clsCalcStartDOY, bReset)
        ucrInputNewDateColumnName.SetRCode(clsCalcStartDate, bReset)
        ucrInputNewStatusColumnName.SetRCode(clsCalcStatus, bReset)

        'Total Rainfall
        ucrChkTotalRainfall.SetRCode(clsCombinedList, bReset)
        ucrNudTROverDays.SetRCode(clsRainRollingSumFunction, bReset)
        ucrNudTRPercentile.SetRCode(clsTRWetSpellFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsRainRollingSumFunction, bReset)

        'Rain Days
        ucrChkNumberOfRainyDays.SetRCode(clsCombinedList, bReset)
        ucrNudRDOutOfDays.SetRCode(clsRainDayRollingSumFunction, bReset)

        'DrySpell
        ucrChkDrySpell.SetRCode(clsCombinedList, bReset)
        ucrNudDSLengthOfTime.SetRCode(clsDrySpellPeriodRollMaxFunction, bReset)

        'DryPeriod
        ucrChkDryPeriod.SetRCode(clsCombinedList, bReset)
        ucrNudDPRainPeriod.SetRCode(clsRollingSumRainDryPeriodFunction, bReset)
        ucrNudDPMaxRain.SetRCode(clsSumRainDryPeriodOperator, bReset)
        ucrNudDPOverallInterval.SetRCode(clsSumRainDryPeriodIntervalMinusOperator, bReset)

        ' Combine
        ucrNudRDMinimumDays.SetRCode(clsRollingSumRainDayOperator, bReset)
        ucrNudDSMaximumDays.SetRCode(clsDSCombineOperator, bReset)
        ucrNudTRAmount.SetRCode(clsTRCombineOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean
        If Not ucrReceiverRainfall.IsEmpty AndAlso
                Not ucrReceiverDate.IsEmpty AndAlso
                Not ucrReceiverDOY.IsEmpty AndAlso
                Not ucrReceiverYear.IsEmpty AndAlso
                ucrNudThreshold.GetText <> "" AndAlso
                (
                    (ucrChkNumberOfRainyDays.Checked AndAlso ucrNudRDMinimumDays.GetText <> "" AndAlso ucrNudRDOutOfDays.GetText <> "") OrElse
                    Not ucrChkNumberOfRainyDays.Checked) AndAlso
                (
                    (
                        (ucrChkTotalRainfall.Checked AndAlso ucrNudTROverDays.GetText <> "") AndAlso
                        ((rdoTRAmount.Checked AndAlso ucrNudTRAmount.GetText <> "") OrElse (rdoTRPercentile.Checked AndAlso ucrNudTRPercentile.GetText <> ""))) OrElse
                    Not ucrChkTotalRainfall.Checked) AndAlso
                (
                    (ucrChkDrySpell.Checked AndAlso ucrNudDSMaximumDays.GetText <> "" AndAlso ucrNudDSLengthOfTime.GetText <> "") OrElse
                    Not ucrChkDrySpell.Checked) AndAlso
                (
                    (ucrChkDryPeriod.Checked AndAlso ucrNudDPMaxRain.GetText <> "" AndAlso ucrNudDPRainPeriod.GetText <> "" AndAlso ucrNudDPOverallInterval.GetText <> "") OrElse
                    Not ucrChkDryPeriod.Checked) Then
            bOkEnabled = True
        Else
            bOkEnabled = False
        End If
        If Not (ucrChkTotalRainfall.Checked OrElse ucrChkNumberOfRainyDays.Checked OrElse ucrChkDrySpell.Checked OrElse ucrChkDryPeriod.Checked) Then
            bOkEnabled = False
        End If
        If Not (ucrChkAsDoy.Checked OrElse ucrChkAsDate.Checked OrElse ucrChkStatus.Checked) Then
            bOkEnabled = False
        End If
        If (ucrChkAsDoy.Checked AndAlso ucrInputNewDoyColumnName.IsEmpty) OrElse
                (ucrChkAsDate.Checked AndAlso ucrInputNewDateColumnName.IsEmpty) OrElse
                (ucrChkStatus.Checked AndAlso ucrInputNewStatusColumnName.IsEmpty) Then
            bOkEnabled = False
        End If

        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFromAndTo, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
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

    Private Sub CombinedFilter()

        If ucrChkTotalRainfall.Checked Then
            If rdoTRAmount.Checked Then
                clsCombinedList.RemoveParameterByName("tr_perc_sub")
                clsTRCombineOperator.RemoveParameterByName("tr_perc")
                clsTRCombineOperator.AddParameter("tr_amount", ucrNudTRAmount.Value, bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsTRCombineOperator.RemoveParameterByName("tr_amount")
                clsCombinedList.AddParameter("tr_perc_sub", clsRFunctionParameter:=clsTRWetSpell, bIncludeArgumentName:=False)
                clsTRCombineOperator.AddParameter("tr_perc", strParameterValue:=strWetSpell, iPosition:=1)
            End If
        Else
            clsTRCombineOperator.RemoveParameterByName("tr_amount")
            clsCombinedList.RemoveParameterByName("tr_perc_sub")
            clsTRCombineOperator.RemoveParameterByName("tr_perc")
        End If
    End Sub

    Private Sub GroupByStationOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsCombinationManipList.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False, iPosition:=0)
            clsListToTalRain.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
            clsCalcRainRollingSum.AddParameter("manipulations", clsRFunctionParameter:=clsListToTalRain, iPosition:=4)
            clsGroupByStation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
        Else
            clsCombinationManipList.RemoveParameterByName("manip1")
            clsListToTalRain.RemoveParameterByName("manip1")
            clsCalcRainRollingSum.RemoveParameterByName("manipulations")
            clsGroupByStation.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub GroupByYearOptions()
        If Not ucrReceiverYear.IsEmpty Then
            clsGroupByYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupByYear.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub DayBoundaries()
        clsSORFilter.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub RainDays()
        clsCalcRainDay.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub TotalRainfallCalcFrom()
        clsCalcRainRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub DryPeriod()
        clsCalcRainRollingSumDryPeriod.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrChkTotalRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTotalRainfall.ControlValueChanged, ucrPnlTRCalculateBy.ControlValueChanged, ucrNudTRAmount.ControlValueChanged
        CombinedFilter()
        If ucrChkTotalRainfall.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("1", clsRFunctionParameter:=clsIsNaFirstRollSumRain, iPosition:=1)
            clsConditionsOrOverallOperator.AddParameter("is.na_roll_sum_rain", clsRFunctionParameter:=clsIsNaRollSumRain, iPosition:=2)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("1")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_roll_sum_rain")
        End If
    End Sub

    Private Sub ucrSelectorForStartofRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForStartofRains.ControlValueChanged, ucrReceiverDOY.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.strCurrentDataFrame & Chr(34)
        DayBoundaries()
        RainDays()
        TotalRainfallCalcFrom()
        DryPeriod()
        GroupByStationOptions()
        GroupByYearOptions()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorForStartofRains.ControlValueChanged
        If Not ucrReceiverDOY.IsEmpty Then
            clsDayFilterCalcFromList.AddParameter(ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrReceiverRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        RainDays()
        TotalRainfallCalcFrom()
        DryPeriod()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByStationOptions()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByYearOptions()
    End Sub

    Private Sub MaximumValuesControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDryPeriod.ControlContentsChanged, ucrNudDPRainPeriod.ControlContentsChanged, ucrNudDPOverallInterval.ControlContentsChanged
        If ucrChkDryPeriod.Checked Then
            ucrNudDPRainPeriod.Maximum = ucrNudDPOverallInterval.Value
            ucrNudDPOverallInterval.Minimum = ucrNudDPRainPeriod.Value
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        clsDayFilterCalcFromList.ClearParameters()
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        DayBoundaries()
    End Sub

    Private Sub ucrChkAsDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAsDate.ControlValueChanged
        If ucrChkAsDate.Checked Then
            clsCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartDate, bIncludeArgumentName:=False, iPosition:=1)
            clsListSubCalc.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartDate, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub2")
            clsListSubCalc.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkAsDoy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAsDoy.ControlValueChanged
        If ucrChkAsDoy.Checked Then
            clsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False, iPosition:=0)
            clsListSubCalc.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub1")
            clsListSubCalc.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrInputNewDoyColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNewDoyColumnName.ControlValueChanged
        clsSORStartSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=ucrInputNewDoyColumnName.GetText, bIncludeArgumentName:=False, iPosition:=0)
        clsSORStatusSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=ucrInputNewDoyColumnName.GetText, bIncludeArgumentName:=False, iPosition:=0)
    End Sub

    Private Sub ucrChkStatus_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStatus.ControlValueChanged
        If ucrChkStatus.Checked Then
            clsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsCalcStatus, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub3")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrInputNewDoyColumnName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrNudThreshold.ControlContentsChanged, ucrChkNumberOfRainyDays.ControlContentsChanged, ucrNudRDMinimumDays.ControlContentsChanged, ucrNudRDOutOfDays.ControlContentsChanged, ucrChkTotalRainfall.ControlContentsChanged, ucrNudTROverDays.ControlContentsChanged, ucrPnlTRCalculateBy.ControlContentsChanged, ucrNudTRAmount.ControlContentsChanged, ucrNudTRPercentile.ControlContentsChanged, ucrChkDrySpell.ControlContentsChanged, ucrNudDSMaximumDays.ControlContentsChanged, ucrNudDSLengthOfTime.ControlContentsChanged, ucrNudDPMaxRain.ControlContentsChanged, ucrChkAsDoy.ControlContentsChanged, ucrChkAsDate.ControlContentsChanged, ucrInputNewDateColumnName.ControlContentsChanged, ucrChkStatus.ControlContentsChanged, ucrInputNewStatusColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkNumberOfRainyDays_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNumberOfRainyDays.ControlValueChanged
        If ucrChkNumberOfRainyDays.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("2", clsRFunctionParameter:=clsIsNaFirstRollSumRainDay, iPosition:=2)
            clsConditionsOrOverallOperator.AddParameter("is.na_roll_sum_rain_day", clsRFunctionParameter:=clsIsNaRollSumRainDay, iPosition:=3)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("2")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_roll_sum_rain_day")
        End If
    End Sub

    Private Sub ucrChkDrySpell_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDrySpell.ControlValueChanged
        If ucrChkDrySpell.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("3", clsRFunctionParameter:=clsIsNaFirstDrySpell, iPosition:=3)
            clsConditionsOrOverallOperator.AddParameter("is.na_dry_spell", clsRFunctionParameter:=clsIsNaDrySpell, iPosition:=4)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("3")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_spell")
        End If
    End Sub

    Private Sub ucrChkDryPeriod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDryPeriod.ControlValueChanged
        If ucrChkDryPeriod.Checked Then
            clsIsNaOperatorStartDOY.AddParameter("4", clsRFunctionParameter:=clsIsNaFirstDryPeriod, iPosition:=4)
            clsConditionsOrOverallOperator.AddParameter("is.na_dry_period", clsRFunctionParameter:=clsIsNaDryPeriod, iPosition:=5)
        Else
            clsIsNaOperatorStartDOY.RemoveParameterByName("4")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_period")
        End If
    End Sub
End Class
