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
    Private clsRainyDays, clsRainyDaysFunction, clsFirstDOYPerYear, clsFirstDatePerYear, clsCombinationCalc, clsCombinationManipList, clsCombinationSubCalcList, clsListSubCalc, clsManipStartFirstList, clsManipulationFirstDOYPerYear, clsCombinedFilter, clsCombinedList As New RFunction
    Private clsDayFromAndTo, clsGroupByStation, clsGroupByStationYear, clsListToTalRain, clsAddKey, clsAddKeyColName, clsApplyInstatFunction, clsFirstDOYPerStationYear, clsFirstDate As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsRainyDaysOperator, clsCombineOperator, clsRainCombineOperator, clsTRCombineOperator, clsRDCombineOperator, clsDSCombineOperator, clsDPCombineOperator As New ROperator
    Private clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction
    'Total Rainfall classes
    Private clsTRRollingSum, clsTRRollingSumFunction, clsTRWetSpell, clsTRWetSpellList, clsTRWetSpellFunction As New RFunction
    Private clsSORFilter, clsSORFilterIfelse, clsSORFilterIsNA As New RFunction
    Private clsLessFilterOperator As New ROperator
    Private clsSORStart, clsSORStatus, clsSORStartIfelse, clsSORIsNA As New RFunction
    Private clsSORStartSummary As New clsRains
    Private clsSORStatusSummary As New clsRains

    'Rainy Day classes
    Private clsRDRollingRainDays, clsRDRollingRainDaysFunction, clsRDRollingRainDaysSub As New RFunction
    'Dry Spell classes
    Private clsDSDrySpellPeriod, clsDSDrySpell, clsDSDrySpellPeriodFunctionLead, clsDSDrySpellFunction, clsDSDrySpellList, clsDSDrySpellSub As New RFunction

    'Dry Period classes
    Private clsDPOverallInterval, clsDPOverallIntervalList, clsDPRain, clsDPRainList, clsDPRainInDays, clsDPRainInDaysFunctionLead, clsDPRainInDaysFunction, clsDPRainFunction, clsDPOverallIntervalFunction As New RFunction
    Private clsDPRainFunctionOperator, clsDPOverallIntervalFunctionOperator, clsDPOverallIntervalFunctionOperatorRight As New ROperator
    Private strCurrDataName As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strWetSpell As String = "wet_spell"

    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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

        ucrChkTotalRainfall.SetParameter(New RParameter("tr_sub", clsTRRollingSum, 1, False), False)
        ucrChkTotalRainfall.AddAdditionalCodeParameterPair(clsCombineOperator, New RParameter("total_rainfall", clsTRCombineOperator, 1, False), iAdditionalPairNo:=1)
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
        ucrChkNumberOfRainyDays.SetParameter(New RParameter("rd_sub", clsRDRollingRainDays, 2, False), False)
        ucrChkNumberOfRainyDays.AddAdditionalCodeParameterPair(clsCombineOperator, New RParameter("rain_days", clsRDCombineOperator, 2, False), iAdditionalPairNo:=1)
        ucrChkNumberOfRainyDays.SetText("Number of Rainy Days")

        ucrNudRDMinimumDays.SetParameter(New RParameter("rd_min", 1))
        ucrNudRDMinimumDays.SetLinkedDisplayControl(lblRDMinimum)
        ucrNudRDMinimumDays.SetMinMax(1, 366)

        ucrNudRDOutOfDays.SetParameter(New RParameter("n", 1))
        ucrNudRDOutOfDays.SetLinkedDisplayControl(lblRDWidth)
        ucrNudRDOutOfDays.SetMinMax(1, 366)

        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDMinimumDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkNumberOfRainyDays.AddToLinkedControls(ucrNudRDOutOfDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)

        'Dry Spell
        ucrChkDrySpell.SetParameter(New RParameter("ds_sub", clsDSDrySpellPeriod, 3, False), False)
        ucrChkDrySpell.AddAdditionalCodeParameterPair(clsCombineOperator, New RParameter("dry_spell", clsDSCombineOperator, 3, False), iAdditionalPairNo:=1)
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
        ucrChkDryPeriod.SetParameter(New RParameter("dp_sub", clsDPOverallInterval, 3, False), False)
        ucrChkDryPeriod.AddAdditionalCodeParameterPair(clsCombineOperator, New RParameter("dry_period", clsDPCombineOperator, 4, False), iAdditionalPairNo:=1)
        ucrChkDryPeriod.SetText("Dry Period")

        ucrNudDPRainPeriod.SetParameter(New RParameter("n", 0))
        ucrNudDPRainPeriod.SetLinkedDisplayControl(lblDPLength)
        ucrNudDPRainPeriod.SetMinMax(1, 366)

        ucrNudDPMaxRain.SetParameter(New RParameter("right", 1))
        ucrNudDPMaxRain.SetLinkedDisplayControl(lblDPMaxRain)
        ucrNudDPMaxRain.SetMinMax(1, Integer.MaxValue)

        ucrNudDPOverallInterval.SetParameter(New RParameter("overall", 0))
        ucrNudDPOverallInterval.SetLinkedDisplayControl(lblDPOverallInterval)
        ucrNudDPOverallInterval.SetMinMax(1, 366)

        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPMaxRain, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=40)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPOverallInterval, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=45)
        ucrChkDryPeriod.AddToLinkedControls(ucrNudDPRainPeriod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)

        'save
        ucrInputNewDoyColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewDoyColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewDoyColumnName.SetName("start_doy")

        ucrInputNewDateColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewDateColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewDateColumnName.SetName("start_date")

        ucrInputNewStatusColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewStatusColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewStatusColumnName.SetName("start_status")

        ucrChkAsDoy.AddToLinkedControls(ucrInputNewDoyColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAsDate.AddToLinkedControls(ucrInputNewDateColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStatus.AddToLinkedControls(ucrInputNewStatusColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAsDoy.AddParameterPresentCondition(True, "sub1", True)
        ucrChkAsDoy.AddParameterPresentCondition(False, "sub1", False)
        ucrChkAsDoy.SetText("Day of Year")

        ucrChkAsDate.AddParameterPresentCondition(True, "sub2", True)
        ucrChkAsDate.AddParameterPresentCondition(False, "sub2", False)
        ucrChkAsDate.SetText("Date")

        ucrChkStatus.AddParameterPresentCondition(True, "sub2", True)
        ucrChkStatus.AddParameterPresentCondition(False, "sub2", False)
        ucrChkStatus.SetText("Occurrence")
    End Sub

    Private Sub SetDefaults()
        Dim strRainDay As String = "rain_day"
        Dim strRollingRainDays As String = "rolling_rain_days"
        Dim strDrySpell As String = "dry_spell"
        Dim strRainInDays As String = "rain_in_days"
        Dim strAboveThreshold As String = "above_threshold"
        Dim strDPOverallIntervalRain As String = "dp_overall_interval_rain"
        Dim strRollSumRain As String = "roll_sum_Rain"
        Dim strStartDate As String = "start_date"
        Dim strStartStatus As String = "start_status"
        Dim strStartDoy As String = "start_doy"

        clsAddKey.Clear()
        clsAddKeyColName.Clear()
        clsDayFromAndTo.Clear()
        clsDayFromAndToOperator.Clear()
        clsGroupByStation.Clear()
        clsGroupByStationYear.Clear()
        clsRainyDays.Clear()
        clsRainyDaysFunction.Clear()
        clsRainyDaysOperator.Clear()
        clsFirstDOYPerYear.Clear()
        clsFirstDOYPerStationYear.Clear()
        clsCombinedFilter.Clear()
        clsCombinedList.Clear()
        clsCombinationCalc.Clear()
        clsListSubCalc.Clear()
        clsCombinationSubCalcList.Clear()

        clsTRRollingSum.Clear()
        clsTRRollingSumFunction = New RFunction
        clsTRWetSpellList.Clear()
        clsTRWetSpell.Clear()
        clsTRWetSpellFunction.Clear()
        clsRDRollingRainDays.Clear()
        clsRDRollingRainDaysFunction.Clear()
        clsRDRollingRainDaysSub.Clear()
        clsSORFilter.Clear()

        clsDSDrySpell.Clear()
        clsDSDrySpellList.Clear()
        clsDSDrySpellPeriod.Clear()
        clsDSDrySpellFunction.Clear()
        clsDSDrySpellSub.Clear()
        clsDSDrySpellPeriodFunctionLead.Clear()

        clsDPRainInDays.Clear()
        clsDPRain.Clear()
        clsDPOverallIntervalList.Clear()
        clsDPOverallInterval.Clear()
        clsDPOverallIntervalFunction.Clear()
        clsDPRainInDaysFunctionLead.Clear()
        clsDPRainInDaysFunction.Clear()
        clsDPRainFunction.Clear()
        clsDPRainFunctionOperator.Clear()
        clsDPOverallIntervalFunction.Clear()
        clsDPOverallIntervalFunctionOperator.Clear()
        clsDPOverallIntervalFunctionOperatorRight.Clear()
        clsApplyInstatFunction.Clear()

        clsTRCombineOperator.Clear()
        clsRDCombineOperator.Clear()
        clsDSCombineOperator.Clear()
        clsDPCombineOperator.Clear()

        ucrReceiverRainfall.SetMeAsReceiver()
        ucrSelectorForStartofRains.Reset()

        ' Adding a key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKey.AddParameter("data_name", strCurrDataName, iPosition:=0)
        clsAddKeyColName.SetRCommand("c")

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        'DayFromandTo
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.bBrackets = False
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")
        clsDayFromAndTo.AddParameter("calculated_from", clsRFunctionParameter:=clsDayFilterCalcFromConvert, iPosition:=2)

        ' group_by_station
        clsGroupByStation.SetRCommand("instat_calculation$new")
        clsGroupByStation.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStation.SetAssignTo("grouping_by_station")

        ' group_by_station_year
        clsGroupByStationYear.SetRCommand("instat_calculation$new")
        clsGroupByStationYear.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationYear.SetAssignTo("grouping_by_station_year")

        'rainydays
        clsRainyDaysFunction.bToScriptAsRString = True
        clsRainyDays.SetRCommand("instat_calculation$new")
        clsRainyDays.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRainyDays.AddParameter("function_exp", clsRFunctionParameter:=clsRainyDaysFunction, iPosition:=1)
        clsRainyDaysFunction.SetRCommand("match")
        clsRainyDaysFunction.AddParameter("x", clsROperatorParameter:=clsRainyDaysOperator, iPosition:=0)
        clsRainyDaysOperator.SetOperation(">=")
        clsRainyDaysOperator.AddParameter("threshold", 0.85, iPosition:=1)
        clsRainyDaysFunction.AddParameter("table", "1", iPosition:=1)
        clsRainyDaysFunction.AddParameter("nomatch", "0", iPosition:=2)
        '"match(" & ucrReceiverRainfall.GetVariableNames(False) & ">=" & nudThreshold.Value & "," & "1, nomatch = 0" & ")" & Chr(34))
        clsRainyDays.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)

        'TOTAL RAINFALL: associated with ucrChkTRTotalRainfall
        clsTRRollingSum.SetRCommand("instat_calculation$new")
        clsTRRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsTRRollingSum.AddParameter("function_exp", clsRFunctionParameter:=clsTRRollingSumFunction, iPosition:=1)
        clsTRRollingSum.AddParameter("result_name", Chr(34) & strRollSumRain & Chr(34), iPosition:=2)
        clsTRRollingSum.AddParameter("save", 2, iPosition:=5)
        clsTRRollingSum.SetAssignTo("total_rainfall_rolling_day")

        clsTRRollingSumFunction.SetPackageName("RcppRoll")
        clsTRRollingSumFunction.SetRCommand("roll_sumr")
        clsTRRollingSumFunction.AddParameter("n", 2, iPosition:=1)
        clsTRRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsTRRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsTRRollingSumFunction.bToScriptAsRString = True

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

        clsSORStart.SetRCommand("instat_calculation$new")
        clsSORStart.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsSORStart.AddParameter("function_exp", clsRFunctionParameter:=clsSORStartIfelse, iPosition:=1)
        clsSORStart.AddParameter("result_name", Chr(34) & strStartDoy & Chr(34), iPosition:=3)
        clsSORStart.AddParameter("save", 2, iPosition:=4)
        clsSORStart.SetAssignTo("start_of_rains_start")

        clsSORStartSummary.SetDefaults()
        clsSORStartSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=strStartDoy, bIncludeArgumentName:=False, iPosition:=0)

        clsSORStatusSummary.SetDefaults()
        clsSORStatusSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=strStartDoy, bIncludeArgumentName:=False, iPosition:=0)
        clsSORStatusSummary.clsIsNaIfelse.bToScriptAsRString = True

        clsSORStatus.SetRCommand("instat_calculation$new")
        clsSORStatus.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsSORStatus.AddParameter("function_exp", clsRFunctionParameter:=clsSORStatusSummary.clsIsNaIfelse, iPosition:=1)
        clsSORStatus.AddParameter("result_name", Chr(34) & strStartStatus & Chr(34), iPosition:=3)
        clsSORStatus.AddParameter("save", 2, iPosition:=4)
        clsSORStatus.SetAssignTo("start_of_rains_status")

        clsSORStartIfelse.SetRCommand("ifelse")
        clsSORStartIfelse.bToScriptAsRString = True
        clsSORStartIfelse.AddParameter("is.na", clsRFunctionParameter:=clsSORIsNA, bIncludeArgumentName:=False, iPosition:=0)
        clsSORStartIfelse.AddParameter("NA", "NA", bIncludeArgumentName:=False, iPosition:=1)
        clsSORStartIfelse.AddParameter("start_doy", strParameterValue:=strStartDoy, bIncludeArgumentName:=False, iPosition:=2)

        clsSORIsNA.SetRCommand("is.na")
        clsSORIsNA.AddParameter("ifelse", clsRFunctionParameter:=clsSORStartSummary.clsIsNaIfelse, bIncludeArgumentName:=False)

        ' Quantile checked:
        ' this function is associated with that rdo.
        clsTRWetSpellFunction.bToScriptAsRString = True
        clsTRWetSpellList.SetRCommand("list")
        clsTRWetSpellList.AddParameter("sub1", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)
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

        ' RAINY DAY
        clsRDRollingRainDaysFunction.bToScriptAsRString = True
        clsRDRollingRainDays.SetRCommand("instat_calculation$new")
        clsRDRollingRainDaysSub.SetRCommand("list")
        clsRDRollingRainDays.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRDRollingRainDays.AddParameter("function_exp", clsRFunctionParameter:=clsRDRollingRainDaysFunction, iPosition:=1)
        clsRDRollingRainDaysFunction.SetPackageName("RcppRoll")
        clsRDRollingRainDaysFunction.SetRCommand("roll_sumr")
        clsRDRollingRainDaysFunction.AddParameter("x", strRainDay, iPosition:=0)
        clsRDRollingRainDaysFunction.AddParameter("n", 2, iPosition:=1)
        clsRDRollingRainDaysFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRDRollingRainDaysFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRDRollingRainDays.AddParameter("result_name", Chr(34) & strRollingRainDays & Chr(34), iPosition:=2)
        clsRDRollingRainDays.SetAssignTo("rain_day_rolling_day")
        clsRDRollingRainDaysSub.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False, iPosition:=0)
        clsRDRollingRainDays.AddParameter("sub_calculations", clsRFunctionParameter:=clsRDRollingRainDaysSub, iPosition:=4)

        'DRY SPELL
        clsDSDrySpell.SetRCommand("instat_calculation$new")
        clsDSDrySpellPeriod.SetRCommand("instat_calculation$new")
        clsDSDrySpellList.SetRCommand("list")
        clsDSDrySpellSub.SetRCommand("list")

        clsDSDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDSDrySpell.AddParameter("function_exp", Chr(34) & "cumsum(" & strRainDay & "==0)-cummax((" & strRainDay & ")*cumsum(" & strRainDay & "== 0))" & Chr(34), iPosition:=1)
        clsDSDrySpell.AddParameter("result_name", Chr(34) & strDrySpell & Chr(34), iPosition:=2)
        clsDSDrySpell.SetAssignTo("dry_spell")

        clsDSDrySpellPeriodFunctionLead.bToScriptAsRString = True
        clsDSDrySpellPeriod.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDSDrySpellPeriod.AddParameter("function_exp", clsRFunctionParameter:=clsDSDrySpellPeriodFunctionLead, iPosition:=1)
        clsDSDrySpellPeriodFunctionLead.SetRCommand("lead")
        clsDSDrySpellPeriodFunctionLead.AddParameter("x", clsRFunctionParameter:=clsDSDrySpellFunction)
        clsDSDrySpellFunction.SetPackageName("RcppRoll")
        clsDSDrySpellFunction.SetRCommand("roll_maxl")
        clsDSDrySpellFunction.AddParameter("x", strDrySpell, iPosition:=0)
        clsDSDrySpellFunction.AddParameter("n", 21, iPosition:=1)
        clsDSDrySpellFunction.AddParameter("fill", "NA", iPosition:=2)
        clsDSDrySpellFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsDSDrySpellPeriod.AddParameter("result_name", Chr(34) & strDrySpell & Chr(34), iPosition:=2)
        clsDSDrySpellPeriod.SetAssignTo("dry_spell_period")

        clsDSDrySpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRainyDays, bIncludeArgumentName:=False)
        clsDSDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDrySpellSub, iPosition:=4)
        clsDSDrySpellList.AddParameter("sub1", clsRFunctionParameter:=clsDSDrySpell, bIncludeArgumentName:=False)
        clsDSDrySpellPeriod.AddParameter("sub_calculations", clsRFunctionParameter:=clsDSDrySpellList, iPosition:=4)

        'DRY PERIOD
        clsDPRainInDaysFunctionLead.bToScriptAsRString = True
        clsDPOverallInterval.SetRCommand("instat_calculation$new")
        clsDPOverallIntervalList.SetRCommand("list")
        clsDPRainList.SetRCommand("list")
        clsDPRain.SetRCommand("instat_calculation$new")
        clsDPRainInDays.SetRCommand("instat_calculation$new")

        clsDPRainInDays.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        'width = " & nudDPRainPeriod.Value & ", FUN = sum, na.rm = FALSE, align='left', fill=NA)" & Chr(34))
        clsDPRainInDays.AddParameter("function_exp", clsRFunctionParameter:=clsDPRainInDaysFunctionLead, iPosition:=1)
        clsDPRainInDaysFunctionLead.SetRCommand("lead") ' i assume lead is wanted if it's the NEXT x days.
        clsDPRainInDaysFunctionLead.AddParameter("x", clsRFunctionParameter:=clsDPRainInDaysFunction)
        clsDPRainInDaysFunction.SetPackageName("RcppRoll")
        clsDPRainInDaysFunction.SetRCommand("roll_suml")
        clsDPRainInDaysFunction.AddParameter("n", 30, iPosition:=1)
        clsDPRainInDaysFunction.AddParameter("fill", "NA", iPosition:=2)
        clsDPRainInDaysFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsDPRainInDays.AddParameter("result_name", Chr(34) & strRainInDays & Chr(34), iPosition:=2) ' sub calc running?
        clsDPRainInDays.SetAssignTo("dry_period_rolling_sum")

        clsDPRainFunction.bToScriptAsRString = True
        clsDPRain.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        '        clsDPRain.AddParameter("function_exp", Chr(34) & "match( Rain_in_Days <= " & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
        clsDPRain.AddParameter("function_exp", clsRFunctionParameter:=clsDPRainFunction, iPosition:=1)
        clsDPRainFunction.SetRCommand("match")
        clsDPRainFunction.AddParameter("x", clsROperatorParameter:=clsDPRainFunctionOperator)
        clsDPRainFunctionOperator.SetOperation("<=")
        clsDPRainFunctionOperator.AddParameter("left", strRainInDays, iPosition:=0)
        clsDPRainFunctionOperator.AddParameter("right", 40, iPosition:=1)
        clsDPRainFunction.AddParameter("table", 1, iPosition:=1)
        clsDPRainFunction.AddParameter("nomatch", 0, iPosition:=2)
        'Chr(34) & "match( Rain_in_Days <= " & nudDPMaxRain.Value & ", 1, nomatch = 0)" & Chr(34))
        clsDPRain.AddParameter("result_name", Chr(34) & strAboveThreshold & Chr(34), iPosition:=2)
        clsDPRain.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPRainList, iPosition:=4)
        clsDPRain.SetAssignTo("dry_period_above_threshold")

        clsDPRainList.AddParameter("sub1", clsRFunctionParameter:=clsDPRainInDays, bIncludeArgumentName:=False)
        clsDPOverallInterval.AddParameter("sub_calculations", clsRFunctionParameter:=clsDPOverallIntervalList, iPosition:=4)
        clsDPOverallIntervalList.AddParameter("sub1", clsRFunctionParameter:=clsDPRain, bIncludeArgumentName:=False)

        clsDPOverallIntervalFunction.bToScriptAsRString = True
        clsDPOverallInterval.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDPOverallInterval.AddParameter("function_exp", clsRFunctionParameter:=clsDPOverallIntervalFunction, iPosition:=1)
        clsDPOverallIntervalFunction.SetPackageName("RcppRoll")
        clsDPOverallIntervalFunction.SetRCommand("roll_suml")
        clsDPOverallIntervalFunction.AddParameter("x", strAboveThreshold, iPosition:=0) ' data = Above_Threshold or = strAboveThreshold
        clsDPOverallIntervalFunction.AddParameter("n", clsROperatorParameter:=clsDPOverallIntervalFunctionOperator, iPosition:=1)
        clsDPOverallIntervalFunction.AddParameter("fill", "NA", iPosition:=2)
        clsDPOverallIntervalFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsDPOverallIntervalFunctionOperator.SetOperation("-")
        clsDPOverallIntervalFunctionOperator.AddParameter("overall", 45, iPosition:=0)
        clsDPOverallIntervalFunctionOperator.AddParameter("right", clsROperatorParameter:=clsDPOverallIntervalFunctionOperatorRight, iPosition:=1)
        clsDPOverallIntervalFunctionOperatorRight.SetOperation("+")
        clsDPOverallIntervalFunctionOperatorRight.AddParameter("n", 30, iPosition:=0)
        clsDPOverallIntervalFunctionOperatorRight.AddParameter("1", 1, iPosition:=1)
        clsDPOverallInterval.AddParameter("result_name", Chr(34) & strDPOverallIntervalRain & Chr(34), iPosition:=2)
        clsDPOverallInterval.SetAssignTo("dry_period_overall_interval")

        ' Combined filter
        clsCombinedFilter.SetRCommand("instat_calculation$new")
        clsCombinedFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsCombinedFilter.AddParameter("function_exp", clsROperatorParameter:=clsCombineOperator, iPosition:=1)
        clsCombinedFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedList, iPosition:=4)
        clsCombinedFilter.SetAssignTo("overall_combined_filter")

        clsCombinedList.SetRCommand("list")
        clsCombinedList.AddParameter("tr_sub", clsRFunctionParameter:=clsTRRollingSum, bIncludeArgumentName:=False)

        ' run always
        clsCombineOperator.AddParameter("rainfall", clsROperatorParameter:=clsRainCombineOperator, iPosition:=0)
        clsCombineOperator.bToScriptAsRString = True
        clsCombineOperator.SetOperation("&")

        clsRainCombineOperator.SetOperation(">=")
        clsRainCombineOperator.AddParameter("rain_threshold", 0.85, bIncludeArgumentName:=False, iPosition:=1)

        ' run if chkTR is checked
        clsTRCombineOperator.SetOperation(">")
        clsTRCombineOperator.AddParameter("tr_left", strRollSumRain, iPosition:=0)

        ' run if chkRD is checked
        clsRDCombineOperator.SetOperation(">=")
        clsRDCombineOperator.AddParameter("rd_left", strRollingRainDays, iPosition:=0)
        clsRDCombineOperator.AddParameter("rd_min", 1, iPosition:=1)

        ' run if chkDS is checked
        clsDSCombineOperator.SetOperation("<")
        clsDSCombineOperator.AddParameter("ds_left", strDrySpell, iPosition:=0)
        clsDSCombineOperator.AddParameter("ds_max", 9, iPosition:=1)

        ' run if chkDP is checked
        clsDPCombineOperator.SetOperation("==")
        clsDPCombineOperator.AddParameter("dp_left", strDPOverallIntervalRain, iPosition:=0)
        clsDPCombineOperator.AddParameter("dp_max", 0, iPosition:=1)

        ' First DOY
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsFirstDOYPerYear.AddParameter("function_exp", clsRFunctionParameter:=clsFirstDOYPerStationYear, iPosition:=1)
        clsFirstDOYPerStationYear.SetPackageName("dplyr")
        clsFirstDOYPerStationYear.SetRCommand("first")
        clsFirstDOYPerStationYear.AddParameter("default", "NA", iPosition:=1)
        clsFirstDOYPerStationYear.bToScriptAsRString = True
        clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & strStartDoy & Chr(34), iPosition:=2)
        clsFirstDOYPerYear.AddParameter("save", 2, iPosition:=6)
        clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipStartFirstList, iPosition:=7)
        clsFirstDOYPerYear.SetAssignTo("start_of_rains_doy")

        'First Date
        clsFirstDatePerYear.SetRCommand("instat_calculation$new")
        clsFirstDatePerYear.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsFirstDatePerYear.AddParameter("function_exp", clsRFunctionParameter:=clsFirstDate, iPosition:=1)
        clsFirstDate.SetPackageName("dplyr")
        clsFirstDate.SetRCommand("first")
        clsFirstDate.bToScriptAsRString = True
        clsFirstDate.AddParameter("default", "NA", iPosition:=1)
        clsFirstDatePerYear.AddParameter("save", 2, iPosition:=6)
        clsFirstDatePerYear.AddParameter("result_name", Chr(34) & strStartDate & Chr(34), iPosition:=2)
        clsFirstDatePerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipStartFirstList, iPosition:=7)
        clsFirstDatePerYear.SetAssignTo("start_of_rains_date")

        'Combination
        clsCombinationCalc.SetRCommand("instat_calculation$new")
        clsCombinationCalc.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationCalc.AddParameter("manipulations", clsRFunctionParameter:=clsCombinationManipList, iPosition:=1)
        clsCombinationCalc.AddParameter("sub_calculation", clsRFunctionParameter:=clsCombinationSubCalcList, iPosition:=2)
        clsCombinationCalc.SetAssignTo("start_of_rains_combined")

        clsCombinationManipList.SetRCommand("list")
        clsCombinationManipList.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStationYear, bIncludeArgumentName:=False, iPosition:=0)
        clsCombinationManipList.AddParameter("manip2", clsRFunctionParameter:=clsSORFilter, bIncludeArgumentName:=False, iPosition:=1)

        clsCombinationSubCalcList.SetRCommand("list")
        clsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsSORStart, bIncludeArgumentName:=False, iPosition:=0)

        'Sub_Calculations List
        clsListSubCalc.SetRCommand("list")
        clsListSubCalc.AddParameter("sub1", iPosition:=0, clsRFunctionParameter:=clsFirstDOYPerYear, bIncludeArgumentName:=False)

        'Manipulation List
        clsManipStartFirstList.SetRCommand("list")
        clsManipStartFirstList.AddParameter("manp1", clsRFunctionParameter:=clsCombinedFilter, bIncludeArgumentName:=False, iPosition:=0)
        clsManipStartFirstList.AddParameter("manp2", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=1)

        'Run Calculations
        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsCombinationCalc, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstDOYPerStationYear, New RParameter("doy", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsLessFilterOperator, New RParameter("doy", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainyDaysOperator, New RParameter("Rain", 1), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsDPRainInDaysFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainCombineOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        clsSORStartSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=4)
        clsSORStatusSummary.SetControlParameters(ucrReceiverRainfall, iAdditionalPairNo:=5)

        ucrNudThreshold.AddAdditionalCodeParameterPair(clsRainCombineOperator, New RParameter("rain_threshold", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrNudDPRainPeriod.AddAdditionalCodeParameterPair(clsDPOverallIntervalFunctionOperatorRight, ucrNudDPRainPeriod.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrChkAsDoy.SetRCode(clsListSubCalc, bReset)
        ucrChkStatus.SetRCode(clsCombinationSubCalcList, bReset)
        ucrChkAsDate.SetRCode(clsListSubCalc, bReset)
        ucrNudThreshold.SetRCode(clsRainyDaysOperator, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrSelectorForStartofRains.SetRCode(clsAddKey, bReset)
        ucrReceiverDate.SetRCode(clsFirstDate, bReset)
        ucrInputNewDoyColumnName.SetRCode(clsFirstDOYPerYear, bReset)
        ucrInputNewDateColumnName.SetRCode(clsFirstDatePerYear, bReset)
        ucrInputNewStatusColumnName.SetRCode(clsSORStatus, bReset)

        'Total Rainfall
        ucrChkTotalRainfall.SetRCode(clsCombinedList, bReset)
        ucrNudTROverDays.SetRCode(clsTRRollingSumFunction, bReset)
        ucrNudTRPercentile.SetRCode(clsTRWetSpellFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsTRRollingSumFunction, bReset)

        'Rain Days
        ucrChkNumberOfRainyDays.SetRCode(clsCombinedList, bReset)
        ucrNudRDOutOfDays.SetRCode(clsRDRollingRainDaysFunction, bReset)

        'DrySpell
        ucrChkDrySpell.SetRCode(clsCombinedList, bReset)
        ucrNudDSLengthOfTime.SetRCode(clsDSDrySpellFunction, bReset)

        'DryPeriod
        ucrChkDryPeriod.SetRCode(clsCombinedList, bReset)
        ucrNudDPRainPeriod.SetRCode(clsDPRainInDaysFunction, bReset)
        ucrNudDPMaxRain.SetRCode(clsDPRainFunctionOperator, bReset)
        ucrNudDPOverallInterval.SetRCode(clsDPOverallIntervalFunctionOperator, bReset)

        ' Combine
        ucrNudRDMinimumDays.SetRCode(clsRDCombineOperator, bReset)
        ucrNudDSMaximumDays.SetRCode(clsDSCombineOperator, bReset)
        ucrNudTRAmount.SetRCode(clsTRCombineOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean
        If (ucrChkAsDoy.Checked AndAlso Not ucrInputNewDoyColumnName.IsEmpty) AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrNudThreshold.GetText <> "" AndAlso ((ucrChkNumberOfRainyDays.Checked AndAlso ucrNudRDMinimumDays.GetText <> "" AndAlso ucrNudRDOutOfDays.GetText <> "") OrElse Not ucrChkNumberOfRainyDays.Checked) AndAlso (((ucrChkTotalRainfall.Checked AndAlso ucrNudTROverDays.GetText <> "") AndAlso ((rdoTRAmount.Checked AndAlso ucrNudTRAmount.GetText <> "") OrElse (rdoTRPercentile.Checked AndAlso ucrNudTRPercentile.GetText <> ""))) OrElse Not ucrChkTotalRainfall.Checked) AndAlso ((ucrChkDrySpell.Checked AndAlso ucrNudDSMaximumDays.GetText <> "" AndAlso ucrNudDSLengthOfTime.GetText <> "") OrElse Not ucrChkDrySpell.Checked) AndAlso ((ucrChkDryPeriod.Checked AndAlso ucrNudDPMaxRain.GetText <> "" AndAlso ucrNudDPRainPeriod.GetText <> "" AndAlso ucrNudDPOverallInterval.GetText <> "") OrElse Not ucrChkDryPeriod.Checked) Then
            bOkEnabled = True
        Else
            bOkEnabled = False
        End If
        If Not (ucrChkTotalRainfall.Checked OrElse ucrChkNumberOfRainyDays.Checked OrElse ucrChkDrySpell.Checked OrElse ucrChkDryPeriod.Checked) Then
            bOkEnabled = False
        End If
        If ucrChkAsDoy.Checked AndAlso ucrChkAsDate.Checked Then
            If Not ucrInputNewDoyColumnName.IsEmpty AndAlso Not ucrInputNewDateColumnName.IsEmpty Then
                bOkEnabled = True
            Else
                bOkEnabled = False
            End If
        End If
        If ucrChkStatus.Checked Then
            If ucrInputNewStatusColumnName.IsEmpty Then
                bOkEnabled = False
            End If
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

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining column(s) as key")
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
            clsListToTalRain.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
            clsTRRollingSum.AddParameter("manipulations", clsRFunctionParameter:=clsListToTalRain, iPosition:=4)
            clsGroupByStation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
        Else
            clsListToTalRain.RemoveParameterByName("manip1")
            clsTRRollingSum.RemoveParameterByName("manipulations")
            clsGroupByStation.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub GroupByStationYearOptions()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupByStationYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
            clsManipStartFirstList.AddParameter("manp3", clsRFunctionParameter:=clsGroupByStationYear, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsGroupByStationYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
            clsManipStartFirstList.RemoveParameterByName("manp3")
        End If
    End Sub

    Private Sub DayBoundaries()
        clsSORFilter.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsAddKeyColName.AddParameter("date", ucrReceiverDate.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=0)
    End Sub

    Private Sub RainDays()
        clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub TotalRainfallCalcFrom()
        clsTRRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
        clsSORStart.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=2)
        clsSORStatus.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub DryPeriod()
        clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrChkTotalRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTotalRainfall.ControlValueChanged, ucrPnlTRCalculateBy.ControlValueChanged, ucrNudTRAmount.ControlValueChanged
        CombinedFilter()
    End Sub

    Private Sub ucrSelectorForStartofRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForStartofRains.ControlValueChanged, ucrReceiverDOY.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.strCurrentDataFrame & Chr(34)
        DayBoundaries()
        RainDays()
        TotalRainfallCalcFrom()
        DryPeriod()
        GroupByStationOptions()
        GroupByStationYearOptions()
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

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupByStationOptions()
        GroupByStationYearOptions()
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
            clsListSubCalc.AddParameter("sub2", iPosition:=1, clsRFunctionParameter:=clsFirstDatePerYear, bIncludeArgumentName:=False)
        Else
            clsListSubCalc.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkAsDoy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAsDoy.ControlValueChanged
        If ucrChkAsDoy.Checked Then
            clsListSubCalc.AddParameter("sub1", iPosition:=1, clsRFunctionParameter:=clsFirstDOYPerYear, bIncludeArgumentName:=False)
        Else
            clsListSubCalc.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrChkStatus_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStatus.ControlValueChanged
        If ucrChkStatus.Checked Then
            clsCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsSORStatus, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrInputNewDoyColumnName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrNudThreshold.ControlContentsChanged, ucrChkNumberOfRainyDays.ControlContentsChanged, ucrNudRDMinimumDays.ControlContentsChanged, ucrNudRDOutOfDays.ControlContentsChanged, ucrChkTotalRainfall.ControlContentsChanged, ucrNudTROverDays.ControlContentsChanged, ucrPnlTRCalculateBy.ControlContentsChanged, ucrNudTRAmount.ControlContentsChanged, ucrNudTRPercentile.ControlContentsChanged, ucrChkDrySpell.ControlContentsChanged, ucrNudDSMaximumDays.ControlContentsChanged, ucrNudDSLengthOfTime.ControlContentsChanged, ucrNudDPMaxRain.ControlContentsChanged, ucrChkAsDoy.ControlContentsChanged, ucrChkAsDate.ControlContentsChanged, ucrInputNewDateColumnName.ControlContentsChanged, ucrChkStatus.ControlContentsChanged, ucrInputNewStatusColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class