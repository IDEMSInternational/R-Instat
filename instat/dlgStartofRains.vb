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
    Public clsRainyDays, clsRainyDaysFunction, clsFirstDOYPerYear, clsManipulationFirstDOYPerYear, clsCombinedFilter, clsCombinedList As New RFunction
    Private clsDayFromAndTo, clsGroupBy, clsAddKey, clsAddKeyColName, clsApplyInstatFunction As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsRainyDaysOperator, clsFirstDOYPerYearOperator, clsCombineOperator, clsRainCombineOperator, clsTRCombineOperator, clsRDCombineOperator, clsDSCombineOperator, clsDPCombineOperator As New ROperator
    'Total Rainfall classes
    Private clsTRRollingSum, clsTRRollingSumFunction, clsTRWetSpell, clsTRWetSpellList, clsTRWetSpellFunction As New RFunction
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
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("date", 0, False))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorForStartofRains
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorForStartofRains
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverRainfall.SetParameter(New RParameter("x", 0))
        ucrReceiverRainfall.SetParameterIsRFunction()
        ucrReceiverRainfall.bWithQuotes = False
        ucrReceiverRainfall.strSelectorHeading = "Rain Variables"
        ucrReceiverRainfall.Selector = ucrSelectorForStartofRains
        ucrReceiverRainfall.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverRainfall.bAutoFill = True

        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Days
        ucrNudFrom.SetParameter(New RParameter("from", 0))
        ucrNudFrom.SetMinMax(1, 365)

        ucrNudTo.SetParameter(New RParameter("to", 0))
        ucrNudTo.SetMinMax(2, 366)

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
        ucrChkTotalRainfall.AddToLinkedControls(ucrNudTROverDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
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
        ucrChkDrySpell.AddToLinkedControls(ucrNudDSLengthOfTime, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)
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

        ucrReceiverYear.Selector = ucrSelectorForStartofRains
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        'save
        ucrInputNewColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewColumnName.SetPrefix("start")
    End Sub

    Private Sub SetDefaults()
        Dim strRainDay As String = "rain_day"
        Dim strRollingRainDays As String = "rolling_rain_days"
        Dim strDrySpell As String = "dry_spell"
        Dim strRainInDays As String = "rain_in_days"
        Dim strAboveThreshold As String = "above_threshold"
        Dim strDPOverallIntervalRain As String = "dp_overall_interval_rain"
        Dim strRollSumRain As String = "roll_sum_Rain"

        clsAddKey.Clear()
        clsAddKeyColName.Clear()
        clsDayFromAndTo.Clear()
        clsDayFromAndToOperator.Clear()
        clsGroupBy.Clear()
        clsRainyDays.Clear()
        clsRainyDaysFunction.Clear()
        clsRainyDaysOperator.Clear()
        clsFirstDOYPerYear.Clear()
        clsFirstDOYPerYearOperator.Clear()
        clsCombinedFilter.Clear()
        clsCombinedList.Clear()

        clsTRRollingSum.Clear()
        clsTRRollingSumFunction.Clear()
        clsTRWetSpellList.Clear()
        clsTRWetSpell.Clear()
        clsTRWetSpellFunction.Clear()
        clsRDRollingRainDays.Clear()
        clsRDRollingRainDaysFunction.Clear()
        clsRDRollingRainDaysSub.Clear()

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

        clsCombineOperator.Clear()
        clsTRCombineOperator.Clear()
        clsRDCombineOperator.Clear()
        clsDSCombineOperator.Clear()
        clsDPCombineOperator.Clear()

        ucrReceiverDate.SetMeAsReceiver()
        ucrSelectorForStartofRains.Reset()

        ' Adding a key
        clsAddKey.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKey.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        'DayFromandTo
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")

        ' group
        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupBy.SetAssignTo("grouping")

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
        clsTRRollingSumFunction.bToScriptAsRString = True
        clsTRRollingSum.SetRCommand("instat_calculation$new")
        clsTRRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsTRRollingSum.AddParameter("result_name", Chr(34) & strRollSumRain & Chr(34), iPosition:=2)
        clsTRRollingSum.AddParameter("function_exp", clsRFunctionParameter:=clsTRRollingSumFunction, iPosition:=1)
        clsTRRollingSumFunction.SetPackageName("RcppRoll")
        clsTRRollingSumFunction.SetRCommand("roll_sumr")
        clsTRRollingSumFunction.AddParameter("n", 2, iPosition:=1)
        clsTRRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsTRRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsTRRollingSum.SetAssignTo("total_rainfall_rolling_day")

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
        clsDSDrySpellFunction.AddParameter("n", 30, iPosition:=1)
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
        clsCombinedList.SetRCommand("list")
        clsCombinedFilter.SetRCommand("instat_calculation$new")
        clsCombinedFilter.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsCombinedFilter.AddParameter("function_exp", clsROperatorParameter:=clsCombineOperator, iPosition:=1)
        clsCombinedFilter.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedList, iPosition:=4)
        clsCombinedFilter.SetAssignTo("overall_combined_filter")
        clsCombineOperator.bToScriptAsRString = True
        clsCombineOperator.SetOperation("&")

        ' run always
        clsCombineOperator.AddParameter("rainfall", clsROperatorParameter:=clsRainCombineOperator, iPosition:=0)
        clsRainCombineOperator.SetOperation(">=")
        clsRainCombineOperator.AddParameter("rain_threshold", 0.85, iPosition:=1)

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
        clsFirstDOYPerYearOperator.bToScriptAsRString = True
        clsFirstDOYPerYear.SetRCommand("instat_calculation$new")
        clsManipulationFirstDOYPerYear.SetRCommand("list")
        clsManipulationFirstDOYPerYear.AddParameter("group_sub", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False, iPosition:=0)
        clsManipulationFirstDOYPerYear.AddParameter("dry_spell_sub", clsRFunctionParameter:=clsCombinedFilter, bIncludeArgumentName:=False, iPosition:=1)
        clsManipulationFirstDOYPerYear.AddParameter("day_sub", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=2)
        clsFirstDOYPerYear.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationFirstDOYPerYear, iPosition:=5)
        clsFirstDOYPerYear.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsFirstDOYPerYear.AddParameter("function_exp", clsROperatorParameter:=clsFirstDOYPerYearOperator, iPosition:=1)
        clsFirstDOYPerYearOperator.SetOperation("[")
        clsFirstDOYPerYearOperator.AddParameter("rightside", "1 ]", iPosition:=1)
        clsFirstDOYPerYear.AddParameter("result_name", Chr(34) & "start" & Chr(34), iPosition:=2)
        clsFirstDOYPerYear.AddParameter("save", 2, iPosition:=6)
        clsFirstDOYPerYear.SetAssignTo("start_of_rains")

        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsFirstDOYPerYear, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)

        'DefaultNudValue()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFirstDOYPerYearOperator, New RParameter("doy", 0), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainyDaysOperator, New RParameter("Rain", 1), iAdditionalPairNo:=1)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsDPRainInDaysFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverRainfall.AddAdditionalCodeParameterPair(clsRainCombineOperator, New RParameter("rain", 0), iAdditionalPairNo:=3)
        ucrNudThreshold.AddAdditionalCodeParameterPair(clsRainCombineOperator, New RParameter("rain_threshold", 1), iAdditionalPairNo:=1)
        ucrNudDPRainPeriod.AddAdditionalCodeParameterPair(clsDPOverallIntervalFunctionOperatorRight, ucrNudDPRainPeriod.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)

        ucrNudThreshold.SetRCode(clsRainyDaysOperator, bReset)

        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)
        ucrSelectorForStartofRains.SetRCode(clsAddKey, bReset)
        ucrInputNewColumnName.SetRCode(clsFirstDOYPerYear, bReset)

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
        If Not ucrInputNewColumnName.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso ucrNudThreshold.GetText <> "" AndAlso ucrNudFrom.GetText <> "" AndAlso ucrNudTo.GetText <> "" AndAlso ((ucrChkNumberOfRainyDays.Checked AndAlso ucrNudRDMinimumDays.GetText <> "" AndAlso ucrNudRDOutOfDays.GetText <> "") OrElse Not ucrChkNumberOfRainyDays.Checked) AndAlso (((ucrChkTotalRainfall.Checked AndAlso ucrNudTROverDays.GetText <> "") AndAlso ((rdoTRAmount.Checked AndAlso ucrNudTRAmount.GetText <> "") OrElse (rdoTRPercentile.Checked AndAlso ucrNudTRPercentile.GetText <> ""))) OrElse Not ucrChkTotalRainfall.Checked) AndAlso ((ucrChkDrySpell.Checked AndAlso ucrNudDSMaximumDays.GetText <> "" AndAlso ucrNudDSLengthOfTime.GetText <> "") OrElse Not ucrChkDrySpell.Checked) AndAlso ((ucrChkDryPeriod.Checked AndAlso ucrNudDPMaxRain.GetText <> "" AndAlso ucrNudDPRainPeriod.GetText <> "" AndAlso ucrNudDPOverallInterval.GetText <> "") OrElse Not ucrChkDryPeriod.Checked) Then
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
        frmMain.clsRLink.RunScript(clsAddKey.ToScript, strComment:="Start of Rains: Defining column(s) as key")
    End Sub

    Private Sub CombinedFilter()
        clsCombineOperator.AddParameter("total_rainfall", clsROperatorParameter:=clsTRCombineOperator, iPosition:=1)
        If ucrChkTotalRainfall.Checked Then
            If rdoTRAmount.Checked Then
                clsCombinedList.RemoveParameterByName("tr_perc_sub")
                clsTRCombineOperator.RemoveParameterByName("tr_perc")
                clsTRCombineOperator.AddParameter("tr_amount", strParameterValue:=ucrNudTRAmount.Value, iPosition:=1)
            Else
                clsCombinedList.AddParameter("tr_perc_sub", clsRFunctionParameter:=clsTRWetSpell, bIncludeArgumentName:=False)
                clsTRCombineOperator.RemoveParameterByName("tr_amount")
                clsTRCombineOperator.AddParameter("tr_perc", strParameterValue:=strWetSpell, iPosition:=1)
            End If
        Else
            clsCombinedList.RemoveParameterByName("tr_perc_sub")
            clsCombineOperator.RemoveParameterByName("total_rainfall")
            clsTRCombineOperator.RemoveParameterByName("tr_perc")
            clsTRCombineOperator.RemoveParameterByName("tr_amount")
        End If
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        End If
    End Sub

    Private Sub DayBoundaries()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
        clsFirstDOYPerYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub RainDays()
        clsRainyDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub TotalRainfall()
        clsTRRollingSum.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub DryPeriod()
        clsDPRainInDays.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverRainfall.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrChkTotalRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTotalRainfall.ControlValueChanged, ucrPnlTRCalculateBy.ControlValueChanged
        CombinedFilter()
    End Sub

    Private Sub ucrSelectorForStartofRains_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForStartofRains.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        DayBoundaries()
        RainDays()
        TotalRainfall()
        DryPeriod()
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayBoundaries()
    End Sub

    Private Sub ucrReceiverRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlValueChanged
        RainDays()
        TotalRainfall()
        DryPeriod()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub MaximumValuesControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkDryPeriod.ControlContentsChanged, ucrNudDPRainPeriod.ControlContentsChanged, ucrNudDPOverallInterval.ControlContentsChanged
        If ucrChkDryPeriod.Checked Then
            ucrNudDPRainPeriod.Maximum = ucrNudDPOverallInterval.Value
            ucrNudDPOverallInterval.Minimum = ucrNudDPRainPeriod.Value
        End If
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudTo.ControlContentsChanged, ucrReceiverRainfall.ControlContentsChanged, ucrInputNewColumnName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrNudThreshold.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrChkNumberOfRainyDays.ControlContentsChanged, ucrNudRDMinimumDays.ControlContentsChanged, ucrNudRDOutOfDays.ControlContentsChanged, ucrChkTotalRainfall.ControlContentsChanged, ucrNudTROverDays.ControlContentsChanged, ucrPnlTRCalculateBy.ControlContentsChanged, ucrNudTRAmount.ControlContentsChanged, ucrNudTRPercentile.ControlContentsChanged, ucrChkDrySpell.ControlContentsChanged, ucrNudDSMaximumDays.ControlContentsChanged, ucrNudDSLengthOfTime.ControlContentsChanged, ucrNudDPMaxRain.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class