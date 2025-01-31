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
    Private bResetSubdialog As Boolean = True
    Private clsCalcRainDay, clsCalcStartDOY, clsConvertssndLinkedVariableFunction, clsDeleteunusedrowFunction, clsRunStartStatus2Function, clsStartRainCombine2Function, clsListFunction, clsNastatus2Function, clsIfElseStatus2Function, clsStatRainStatus2Function, clsSetnameRainStatusFunction, clsSetnameRainFunction, clsCalculatedListformFunction, clsConvertLinkedvariablesvectorFunction, clsConvertLinkedVariablesFunction, clsStationTypeFunction, clsConvertStationtypeFunction, clsVectorFunction, clsGetlinkeddataFunction, clsGetDataFrameFunction, clsListevapFunction, clsRollEvaporationFunction, clsFractionEvapFunction, clsSumEvapFunction, clsConvertColumnType1Function, clsConvertColumnType2Function, clsConvertColumnTypeFunction, clsGetColumnDataTypeFunction, clsDummyFunction, clsIfelseStatusFunction, clsIfelseStatus1Function, clsFirstStatusFunction, clsIsNAStatusFunction, clsCalcStartDate, clsCombinationCalc, clsListCalFunction, clsCombinationManipList, clsCombinationSubCalcList, clsListSubCalc, clsManipulationFirstDOYPerYear, clsConditionsFilter, clsCombinedList As New RFunction
    Private clsDayFromAndTo, clsGroupByStation, clsGroupByYear, clsListToTalRain, clsApplyInstatFunction, clsFirstDOY, clsFirstDate As New RFunction
    Private clsDayFromAndToOperator, clsEvapOperator, clsDayFromOperator, clsDayToOperator, clsRainDayOperator, clsRainDayConditionOperator, clsConditionsAndOperator, clsTRCombineOperator, clsRollingSumRainDayOperator, clsDSCombineOperator, clsDPCombineOperator As New ROperator
    Private clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction

    Private clsSpellsFunction, clsIfElseFirstDoyFilledFunction As New RFunction
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
    Private strFactionEvap As String = "fraction_evap"
    Private strSumFractionEvap As String = "roll_sum_evap"

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
        Dim dctInputThreshold As New Dictionary(Of String, String)

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

        ucrReceiverEvap.SetParameter(New RParameter("evap", 0, False))
        ucrReceiverEvap.SetParameterIsString()
        ucrReceiverEvap.bWithQuotes = False
        ucrReceiverEvap.Selector = ucrSelectorForStartofRains

        ucrInputThreshold.SetParameter(New RParameter("threshold", 1))
        dctInputThreshold.Add("0.85", "0.85")
        dctInputThreshold.Add("0.5", "0.5")
        dctInputThreshold.Add("0.05", "0.05")
        dctInputThreshold.Add("0.99", "0.99")
        ucrInputThreshold.SetItems(dctInputThreshold)
        ucrInputThreshold.AddQuotesIfUnrecognised = False
        ucrInputThreshold.SetLinkedDisplayControl(lblThreshold)
        ucrInputThreshold.SetRDefault(0.85)

        'Total Rainfall
        ucrPnlTRCalculateBy.AddRadioButton(rdoTRAmount)
        ucrPnlTRCalculateBy.AddRadioButton(rdoTRPercentile)
        ucrPnlTRCalculateBy.AddRadioButton(rdoEvapo)
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRAmount, "tr_perc_sub", False)
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRPercentile, "tr_perc_sub")
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoEvapo, "tr_perc_sub")
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudTRPercentile, {rdoTRPercentile}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.8)
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudTRAmount, {rdoTRAmount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=20)
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrNudEvapo, {rdoEvapo}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)
        ucrPnlTRCalculateBy.AddToLinkedControls(ucrReceiverEvap, {rdoEvapo}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTRCalculateBy.SetLinkedDisplayControl(lblTRVal)
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRPercentile, "tr_perc")
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoTRAmount, "tr_amount")
        ucrPnlTRCalculateBy.AddParameterPresentCondition(rdoEvapo, "evap")

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

        ucrNudEvapo.SetParameter(New RParameter("frac", 1, False))
        ucrNudEvapo.SetMinMax(0.01, 10)
        ucrNudEvapo.DecimalPlaces = 2
        ucrNudEvapo.Increment = 0.01
        ucrNudEvapo.SetLinkedDisplayControl(lblFraction)

        ucrChkAdditional.SetText("Additional Conditions")
        ucrChkAdditional.AddParameterValuesCondition(True, "additional", "True")
        ucrChkAdditional.AddParameterValuesCondition(False, "additional", "False")

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
        ucrChkAsDoy.SetText("Day")

        ucrChkAsDate.AddParameterValuesCondition(True, "sub2", "True")
        ucrChkAsDate.AddParameterValuesCondition(False, "sub2", "False")
        ucrChkAsDate.SetText("Date")

        ucrChkStatus.AddParameterValuesCondition(True, "sub3", "True")
        ucrChkStatus.AddParameterValuesCondition(False, "sub3", "False")
        ucrChkStatus.SetText("Occurrence")
        SetReceiver()
        AdditionalCondition()
        ChangeDSValue()
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
        Dim strYearType As String = "year_type"
        Dim strStationType As String = "station_type"
        Dim strcalculatedfromlist As String = "calculated_from_list"
        Dim strStartStatus2 As String = "start_rain_status2"
        Dim strstartraincombinedstatus2 As String = "start_rain_combined_status_2"

        clsRainRollingSumFunction = New RFunction
        clsGetlinkeddataFunction = New RFunction
        clsVectorFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromList = New RFunction
        clsDummyFunction = New RFunction
        clsIfElseFirstDoyFilledFunction = New RFunction
        clsConvertLinkedvariablesvectorFunction = New RFunction
        clsSetnameRainStatusFunction = New RFunction
        clsSetnameRainFunction = New RFunction
        clsIfElseStatus2Function = New RFunction
        clsNastatus2Function = New RFunction
        clsListFunction = New RFunction

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
        clsListCalFunction.Clear()
        clsCombinationSubCalcList.Clear()
        clsIfelseStatus1Function.Clear()
        clsIfelseStatusFunction.Clear()
        clsFirstStatusFunction.Clear()
        clsIsNAStatusFunction.Clear()
        clsGetColumnDataTypeFunction.Clear()
        clsConvertColumnTypeFunction.Clear()
        clsConvertColumnType2Function.Clear()
        clsConvertColumnType1Function.Clear()
        clsFractionEvapFunction.Clear()
        clsSumEvapFunction.Clear()
        clsEvapOperator.Clear()
        clsRollEvaporationFunction.Clear()
        clsListevapFunction.Clear()
        clsStationTypeFunction.Clear()
        clsConvertStationtypeFunction.Clear()
        clsConvertLinkedVariablesFunction.Clear()
        clsCalculatedListformFunction.Clear()
        clsStatRainStatus2Function.Clear()
        clsStartRainCombine2Function.Clear()
        clsRunStartStatus2Function.Clear()
        clsConvertssndLinkedVariableFunction.Clear()
        clsDeleteunusedrowFunction.Clear()

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

        bResetSubdialog = True
        ucrSelectorForStartofRains.Reset()

        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")

        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        clsDummyFunction.AddParameter("sub2", "True", iPosition:=0)
        clsDummyFunction.AddParameter("sub3", "True", iPosition:=1)
        clsDummyFunction.AddParameter("additional", "False", iPosition:=2)

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

        clsGetColumnDataTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_data_types")
        clsGetColumnDataTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetColumnDataTypeFunction.SetAssignTo(strYearType)

        clsConvertColumnTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnTypeFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)

        clsConvertColumnType1Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnType1Function.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnType1Function.AddParameter("to_type", strYearType, iPosition:=2)

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

        clsFractionEvapFunction.SetRCommand("instat_calculation$new")
        clsFractionEvapFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsFractionEvapFunction.AddParameter("function_exp", clsROperatorParameter:=clsEvapOperator, iPosition:=1)
        clsFractionEvapFunction.AddParameter("result_name", Chr(34) & strFactionEvap & Chr(34), iPosition:=2)
        clsFractionEvapFunction.SetAssignTo(strFactionEvap)

        clsEvapOperator.SetOperation("*")
        clsEvapOperator.bToScriptAsRString = True

        clsSumEvapFunction.SetRCommand("instat_calculation$new")
        clsSumEvapFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsSumEvapFunction.AddParameter("function_exp", clsRFunctionParameter:=clsRollEvaporationFunction, iPosition:=1)
        clsSumEvapFunction.AddParameter("result_name", Chr(34) & strSumFractionEvap & Chr(34), iPosition:=2)
        clsSumEvapFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsListevapFunction, iPosition:=3)
        clsSumEvapFunction.SetAssignTo(strSumFractionEvap)

        clsListevapFunction.SetRCommand("list")
        clsListevapFunction.AddParameter("x", strFactionEvap, iPosition:=0, bIncludeArgumentName:=False)

        clsRollEvaporationFunction.SetPackageName("RcppRoll")
        clsRollEvaporationFunction.SetRCommand("roll_sumr")
        clsRollEvaporationFunction.AddParameter("x", strFactionEvap, iPosition:=0)
        clsRollEvaporationFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollEvaporationFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRollEvaporationFunction.bToScriptAsRString = True

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
        clsCombinedList.AddParameter("tr_sub", clsRFunctionParameter:=clsCalcRainRollingSum, bIncludeArgumentName:=False, iPosition:=0)

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
        clsCalcStatus.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStatusFunction, iPosition:=1)
        clsCalcStatus.AddParameter("result_name", Chr(34) & strStartStatus & Chr(34), iPosition:=3)
        clsCalcStatus.AddParameter("save", 2, iPosition:=4)
        clsCalcStatus.SetAssignTo("start_of_rains_status")

        clsIfelseStatusFunction.SetRCommand("ifelse")
        clsIfelseStatusFunction.bToScriptAsRString = True
        clsIfelseStatusFunction.AddParameter("x", "n() > 0", iPosition:=0, bIncludeArgumentName:=False)
        clsIfelseStatusFunction.AddParameter("y", clsRFunctionParameter:=clsIfelseStatus1Function, iPosition:=1, bIncludeArgumentName:=False)
        clsIfelseStatusFunction.AddParameter("z", "FALSE", iPosition:=2, bIncludeArgumentName:=False)

        clsIfelseStatus1Function.SetRCommand("ifelse")
        clsIfelseStatus1Function.AddParameter("yes", clsRFunctionParameter:=clsFirstStatusFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsIfelseStatus1Function.AddParameter("test", "NA", iPosition:=1, bIncludeArgumentName:=False)
        clsIfelseStatus1Function.AddParameter("no", "TRUE", iPosition:=2, bIncludeArgumentName:=False)

        clsFirstStatusFunction.SetPackageName("dplyr")
        clsFirstStatusFunction.SetRCommand("first")
        clsFirstStatusFunction.AddParameter("x", clsRFunctionParameter:=clsIsNAStatusFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsIsNAStatusFunction.SetRCommand("is.na")
        clsIsNAStatusFunction.AddParameter("x", strRollSumRain, iPosition:=0, bIncludeArgumentName:=False)

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
        clsCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartDate, bIncludeArgumentName:=False, iPosition:=1)
        clsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsCalcStatus, bIncludeArgumentName:=False, iPosition:=2)

        'Sub_Calculations List
        clsListSubCalc.SetRCommand("list")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")

        clsGetlinkeddataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_linked_to_data_name")
        clsGetlinkeddataFunction.SetAssignTo("linked_data_name")

        clsVectorFunction.SetRCommand("c")

        clsConvertColumnType2Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertColumnType2Function.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnType2Function.AddParameter("to_type", strStationType, iPosition:=2)

        'Run Calculations
        clsListCalFunction.SetRCommand("list")
        clsListCalFunction.AddParameter("drop", "FALSE", iPosition:=0)

        clsApplyInstatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatFunction.AddParameter("calc", clsRFunctionParameter:=clsCombinationCalc, iPosition:=0)
        clsApplyInstatFunction.AddParameter("param_list", clsRFunctionParameter:=clsListCalFunction, iPosition:=2)

        clsStationTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_data_types")
        clsStationTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsStationTypeFunction.SetAssignTo(strStationType)

        clsConvertStationtypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertStationtypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertStationtypeFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)

        clsConvertLinkedVariablesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_linked_variable")
        clsConvertLinkedVariablesFunction.AddParameter("from_data_frame", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertLinkedVariablesFunction.AddParameter("link_cols", clsRFunctionParameter:=clsConvertLinkedvariablesvectorFunction, iPosition:=2)

        clsConvertLinkedvariablesvectorFunction.SetRCommand("c")

        clsCalculatedListformFunction.SetRCommand("c")
        clsCalculatedListformFunction.AddParameter("x", clsRFunctionParameter:=clsSetnameRainStatusFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsCalculatedListformFunction.AddParameter("y", clsRFunctionParameter:=clsSetNameRainFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsCalculatedListformFunction.SetAssignTo(strcalculatedfromlist)

        clsSetnameRainStatusFunction.SetRCommand("setNames")
        clsSetnameRainStatusFunction.AddParameter("x", Chr(34) & strStartStatus & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsSetnameRainStatusFunction.AddParameter("y", "linked_data_name", iPosition:=1, bIncludeArgumentName:=False)

        clsSetnameRainFunction.SetRCommand("setNames")
        clsSetnameRainFunction.AddParameter("x", Chr(34) & strStartDoy & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsSetnameRainFunction.AddParameter("y", "linked_data_name", iPosition:=1, bIncludeArgumentName:=False)

        clsStatRainStatus2Function.SetRCommand("instat_calculation$new")
        clsStatRainStatus2Function.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsStatRainStatus2Function.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseStatus2Function, iPosition:=1)
        clsStatRainStatus2Function.AddParameter("calculated_from", strcalculatedfromlist, iPosition:=2)
        clsStatRainStatus2Function.AddParameter("result_name", Chr(34) & "start_rain_status" & Chr(34), iPosition:=3)
        clsStatRainStatus2Function.AddParameter("save", "2", iPosition:=4)
        clsStatRainStatus2Function.SetAssignTo(strStartStatus2)
        clsIfElseStatus2Function.SetRCommand("ifelse")
        clsIfElseStatus2Function.bToScriptAsRString = True
        clsIfElseStatus2Function.AddParameter("test", clsRFunctionParameter:=clsNastatus2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsIfElseStatus2Function.AddParameter("yes", "TRUE", iPosition:=1, bIncludeArgumentName:=False)
        clsIfElseStatus2Function.AddParameter("no", strStartStatus, iPosition:=2, bIncludeArgumentName:=False)

        clsNastatus2Function.SetRCommand("!is.na")
        clsNastatus2Function.AddParameter("x", strStartDoy, iPosition:=0, bIncludeArgumentName:=False)

        clsStartRainCombine2Function.SetRCommand("instat_calculation$new")
        clsStartRainCombine2Function.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsStartRainCombine2Function.AddParameter("sub_calculations", clsRFunctionParameter:=clsListFunction, iPosition:=1)
        clsStartRainCombine2Function.SetAssignTo(strstartraincombinedstatus2)

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("x", strStartStatus2, iPosition:=0, bIncludeArgumentName:=False)

        clsRunStartStatus2Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunStartStatus2Function.AddParameter("calc", strstartraincombinedstatus2, iPosition:=0)
        clsRunStartStatus2Function.AddParameter("display", "FALSE", iPosition:=1)
        clsRunStartStatus2Function.AddParameter("param_list", clsRFunctionParameter:=clsListCalFunction, iPosition:=2)

        clsConvertssndLinkedVariableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_linked_variable")
        clsConvertssndLinkedVariableFunction.AddParameter("from_data_frame", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertssndLinkedVariableFunction.AddParameter("link_cols", clsRFunctionParameter:=clsConvertLinkedvariablesvectorFunction, iPosition:=1)

        clsDeleteunusedrowFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_unused_station_year_combinations")
        clsDeleteunusedrowFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        ucrBase.clsRsyntax.ClearCodes()

        ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnDataTypeFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertColumnTypeFunction, iPosition:=1)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertLinkedVariablesFunction, iPosition:=4)
        ucrBase.clsRsyntax.AddToAfterCodes(clsConvertColumnType1Function, iPosition:=5)
        ucrBase.clsRsyntax.AddToAfterCodes(clsConvertssndLinkedVariableFunction, iPosition:=8)
        SetReceiver()
        ChangeDSValue()
        AdditionalCondition()
        GroupByStationOptions()
        AddRemoveStartStatus()
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
        ucrInputThreshold.AddAdditionalCodeParameterPair(clsRainDayConditionOperator, New RParameter("threshold", 1), iAdditionalPairNo:=1)
        ucrInputNewDoyColumnName.AddAdditionalCodeParameterPair(clsCalcStartDOY, New RParameter("result_name", 3), iAdditionalPairNo:=1)
        ucrNudTROverDays.AddAdditionalCodeParameterPair(clsRollEvaporationFunction, New RParameter("n", 1), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        If bReset Then
            ucrChkAsDoy.SetRCode(clsCombinationSubCalcList, bReset)
            ucrChkStatus.SetRCode(clsDummyFunction, bReset)
            ucrChkAsDate.SetRCode(clsDummyFunction, bReset)
            ucrChkAdditional.SetRCode(clsDummyFunction, bReset)
        End If
        ucrInputThreshold.SetRCode(clsRainDayOperator, bReset)

        ucrReceiverDate.SetRCode(clsFirstDate, bReset)
        ucrInputNewDoyColumnName.SetRCode(clsCalcStartDOY, bReset)
        ucrInputNewDateColumnName.SetRCode(clsCalcStartDate, bReset)
        ucrInputNewStatusColumnName.SetRCode(clsCalcStatus, bReset)

        'Total Rainfall
        ucrChkTotalRainfall.SetRCode(clsCombinedList, bReset)
        ucrNudTROverDays.SetRCode(clsRainRollingSumFunction, bReset)
        ucrNudTRPercentile.SetRCode(clsTRWetSpellFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsRainRollingSumFunction, bReset)
        ucrNudTRAmount.SetRCode(clsTRCombineOperator, bReset)

        'Evaporation
        ucrReceiverEvap.SetRCode(clsEvapOperator, bReset)
        ucrNudEvapo.SetRCode(clsEvapOperator, bReset)
        AdditionalCondition()
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean
        If Not ucrReceiverRainfall.IsEmpty AndAlso
                Not ucrReceiverDate.IsEmpty AndAlso
                Not ucrReceiverDOY.IsEmpty AndAlso
                Not ucrReceiverYear.IsEmpty AndAlso
                ucrInputThreshold.GetText <> "" AndAlso
                (
                    (
                        (ucrChkTotalRainfall.Checked AndAlso ucrNudTROverDays.GetText <> "") AndAlso
                        ((rdoTRAmount.Checked AndAlso ucrNudTRAmount.GetText <> "") OrElse (rdoTRPercentile.Checked AndAlso ucrNudTRPercentile.GetText <> "") OrElse (rdoEvapo.Checked AndAlso Not ucrReceiverEvap.IsEmpty AndAlso ucrNudTRPercentile.GetText <> ""))) OrElse
                    Not ucrChkTotalRainfall.Checked) Then
            bOkEnabled = True
        Else
            bOkEnabled = False
        End If
        If Not ucrChkTotalRainfall.Checked Then
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
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFromAndTo, clsNewIfElseFirstDoyFilledFunction:=clsIfElseFirstDoyFilledFunction, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
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
                clsTRCombineOperator.RemoveParameterByName("evap")
                clsCombinedList.RemoveParameterByName("tr_perc_sub")
                clsTRCombineOperator.RemoveParameterByName("tr_perc")
                clsCombinedList.RemoveParameterByName("evap_frac")
                clsTRCombineOperator.AddParameter("tr_amount", ucrNudTRAmount.Value, bIncludeArgumentName:=False, iPosition:=1)
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFractionEvapFunction)
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSumEvapFunction)
            ElseIf rdoTRPercentile.Checked Then
                clsTRCombineOperator.RemoveParameterByName("evap")
                clsTRCombineOperator.RemoveParameterByName("tr_amount")
                clsCombinedList.RemoveParameterByName("evap_frac")
                clsCombinedList.AddParameter("tr_perc_sub", clsRFunctionParameter:=clsTRWetSpell, bIncludeArgumentName:=False)
                clsTRCombineOperator.AddParameter("tr_perc", strParameterValue:=strWetSpell, iPosition:=1)
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFractionEvapFunction)
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSumEvapFunction)
            Else
                clsCombinedList.RemoveParameterByName("tr_perc_sub")
                clsTRCombineOperator.RemoveParameterByName("tr_perc_sub")
                clsTRCombineOperator.RemoveParameterByName("tr_amount")
                clsCombinedList.AddParameter("evap_frac", strSumFractionEvap, bIncludeArgumentName:=False, iPosition:=1)
                clsTRCombineOperator.AddParameter("evap", strParameterValue:=strSumFractionEvap, iPosition:=1, bIncludeArgumentName:=False)
                If Not ucrReceiverEvap.IsEmpty Then
                    clsFractionEvapFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverEvap.GetVariableNames & ")", iPosition:=3)
                Else
                    clsFractionEvapFunction.RemoveParameterByName("calculated_from")
                End If
                ucrBase.clsRsyntax.AddToBeforeCodes(clsFractionEvapFunction, iPosition:=2)
                ucrBase.clsRsyntax.AddToBeforeCodes(clsSumEvapFunction, iPosition:=3)
            End If
        Else
            clsTRCombineOperator.RemoveParameterByName("tr_amount")
            clsCombinedList.RemoveParameterByName("tr_perc_sub")
            clsCombinedList.RemoveParameterByName("evap_frac")
            clsTRCombineOperator.RemoveParameterByName("tr_perc")
            clsTRCombineOperator.RemoveParameterByName("evap")
        End If
    End Sub

    Private Sub GroupByStationOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsDeleteunusedrowFunction.AddParameter("station", ucrReceiverStation.GetVariableNames(), iPosition:=2)
            clsCombinationManipList.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False, iPosition:=0)
            clsListToTalRain.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
            clsCalcRainRollingSum.AddParameter("manipulations", clsRFunctionParameter:=clsListToTalRain, iPosition:=4)
            clsGroupByStation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
            clsConvertStationtypeFunction.AddParameter("col_names", ucrReceiverStation.GetVariableNames(), iPosition:=1)
            clsConvertLinkedvariablesvectorFunction.AddParameter("y", ucrReceiverStation.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
            clsStationTypeFunction.AddParameter("columns", ucrReceiverStation.GetVariableNames(), iPosition:=1)
            clsConvertColumnType2Function.AddParameter("col_names", ucrReceiverStation.GetVariableNames(), iPosition:=1)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsStationTypeFunction, iPosition:=2)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertStationtypeFunction, iPosition:=3)
            ucrBase.clsRsyntax.AddToAfterCodes(clsDeleteunusedrowFunction, iPosition:=7)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDeleteunusedrowFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsStationTypeFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsConvertStationtypeFunction)
            clsDeleteunusedrowFunction.RemoveParameterByName("station")
            clsConvertStationtypeFunction.RemoveParameterByName("col_names")
            clsCombinationManipList.RemoveParameterByName("manip1")
            clsListToTalRain.RemoveParameterByName("manip1")
            clsCalcRainRollingSum.RemoveParameterByName("manipulations")
            clsGroupByStation.RemoveParameterByName("calculated_from")
            clsConvertLinkedvariablesvectorFunction.RemoveParameterByName("y")
            clsStationTypeFunction.RemoveParameterByName("columns")
            clsConvertColumnType2Function.RemoveParameterByName("col_names")
        End If
    End Sub

    Private Sub GroupByYearOptions()
        If Not ucrReceiverYear.IsEmpty Then
            clsGetColumnDataTypeFunction.AddParameter("columns", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsConvertColumnTypeFunction.AddParameter("col_names", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsConvertColumnType1Function.AddParameter("col_names", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsDeleteunusedrowFunction.AddParameter("year", ucrReceiverYear.GetVariableNames(), iPosition:=1)
            clsGroupByYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
            clsConvertLinkedvariablesvectorFunction.AddParameter("x", ucrReceiverYear.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsDeleteunusedrowFunction.RemoveParameterByName("year")
            clsGroupByYear.RemoveParameterByName("calculated_from")
            clsGetColumnDataTypeFunction.RemoveParameterByName("columns")
            clsConvertColumnTypeFunction.RemoveParameterByName("col_names")
            clsConvertColumnType1Function.RemoveParameterByName("col_names")
            clsConvertLinkedvariablesvectorFunction.RemoveParameterByName("x")
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

    Private Sub ucrChkTotalRainfall_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTotalRainfall.ControlValueChanged, ucrPnlTRCalculateBy.ControlValueChanged, ucrNudTRAmount.ControlValueChanged, ucrNudEvapo.ControlValueChanged, ucrReceiverEvap.ControlValueChanged
        CombinedFilter()
        SetReceiver()
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
        CombinedFilter()
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
        YearStationVariable()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByYearOptions()
        YearStationVariable()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        clsGetColumnDataTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnType1Function.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetlinkeddataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsStationTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertStationtypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertLinkedVariablesFunction.AddParameter("from_data_frame", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertssndLinkedVariableFunction.AddParameter("from_data_frame", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsDeleteunusedrowFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnType2Function.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

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
            clsListSubCalc.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub1")
            clsListSubCalc.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrInputNewDoyColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNewDoyColumnName.ControlValueChanged
        clsSORStartSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=ucrInputNewDoyColumnName.GetText, bIncludeArgumentName:=False, iPosition:=0)
        clsSORStatusSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=ucrInputNewDoyColumnName.GetText, bIncludeArgumentName:=False, iPosition:=0)
    End Sub

    Private Sub AddRemoveStartStatus()
        If ucrChkStatus.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetlinkeddataFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsCalculatedListformFunction, iPosition:=1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsStatRainStatus2Function, iPosition:=2)
            ucrBase.clsRsyntax.AddToAfterCodes(clsStartRainCombine2Function, iPosition:=3)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRunStartStatus2Function, iPosition:=4)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStatRainStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartRainCombine2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2Function)
        End If
    End Sub

    Private Sub ucrChkStatus_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStatus.ControlValueChanged
        AddRemoveStartStatus()
        If ucrChkStatus.Checked Then
            clsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsCalcStatus, bIncludeArgumentName:=False, iPosition:=2)
            clsListSubCalc.AddParameter("sub3", clsRFunctionParameter:=clsCalcStatus, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub3")
            clsListSubCalc.RemoveParameterByName("sub3")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrInputNewDoyColumnName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrInputThreshold.ControlContentsChanged, ucrChkTotalRainfall.ControlContentsChanged, ucrNudTROverDays.ControlContentsChanged, ucrPnlTRCalculateBy.ControlContentsChanged, ucrNudTRAmount.ControlContentsChanged, ucrNudTRPercentile.ControlContentsChanged, ucrChkAsDoy.ControlContentsChanged, ucrChkAsDate.ControlContentsChanged, ucrInputNewDateColumnName.ControlContentsChanged, ucrChkStatus.ControlContentsChanged, ucrInputNewStatusColumnName.ControlContentsChanged, ucrNudEvapo.ControlContentsChanged, ucrReceiverEvap.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub SetReceiver()
        If rdoEvapo.Checked Then
            ucrReceiverEvap.SetMeAsReceiver()
        Else
            ucrReceiverRainfall.SetMeAsReceiver()
        End If
    End Sub

    Private Sub AdditionalCondition()
        cmdAdditionnal.Visible = ucrChkAdditional.Checked
    End Sub

    Private Sub ucrChkAdditional_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAdditional.ControlValueChanged
        AdditionalCondition()
        ChangeDSValue()
    End Sub

    Private Sub cmdAdditionnal_Click(sender As Object, e As EventArgs) Handles cmdAdditionnal.Click
        sdgAdditionalCondition.SetRCode(clsNewCombinedList:=clsCombinedList, clsNewCalcRollSumNumberDryPeriod:=clsCalcRollSumNumberDryPeriod, clsNewCalcRainDayRollingSum:=clsCalcRainDayRollingSum, clsNewCalcDrySpellRollMax:=clsCalcDrySpellRollMax, clsNewConditionsAndOperator:=clsConditionsAndOperator, clsNewRollingSumRainDayOperator:=clsRollingSumRainDayOperator, clsNewDSCombineOperator:=clsDSCombineOperator, clsNewDPCombineOperator:=clsDPCombineOperator, clsNewSumRainDryPeriodIntervalPlusOperator:=clsSumRainDryPeriodIntervalPlusOperator, bReset:=bResetSubdialog)
        sdgAdditionalCondition.ShowDialog()
        bResetSubdialog = False
        AdditionalCondition()
        ChangeDSValue()
    End Sub

    Private Sub ChangeDSValue()
        If ucrChkAdditional.Checked Then
            If sdgAdditionalCondition.ucrChkNumberOfRainyDays.Checked Then
                clsConditionsAndOperator.AddParameter("rain_days", clsROperatorParameter:=clsRollingSumRainDayOperator, iPosition:=2, bIncludeArgumentName:=False)
                clsIsNaOperatorStartDOY.AddParameter("2", clsRFunctionParameter:=clsIsNaFirstRollSumRainDay, iPosition:=2)
                clsConditionsOrOverallOperator.AddParameter("is.na_roll_sum_rain_day", clsRFunctionParameter:=clsIsNaRollSumRainDay, iPosition:=3)
                clsCombinedList.AddParameter("rd_sub", clsRFunctionParameter:=clsCalcRainDayRollingSum, bIncludeArgumentName:=False, iPosition:=1)
            Else
                clsCombinedList.RemoveParameterByName("rd_sub")
                clsConditionsAndOperator.RemoveParameterByName("rain_days")
                clsIsNaOperatorStartDOY.RemoveParameterByName("2")
                clsConditionsOrOverallOperator.RemoveParameterByName("is.na_roll_sum_rain_day")
            End If
            If sdgAdditionalCondition.ucrChkDrySpell.Checked Then
                clsConditionsAndOperator.AddParameter("dry_spell", clsROperatorParameter:=clsDSCombineOperator, iPosition:=3, bIncludeArgumentName:=False)
                clsIsNaOperatorStartDOY.AddParameter("3", clsRFunctionParameter:=clsIsNaFirstDrySpell, iPosition:=3)
                clsConditionsOrOverallOperator.AddParameter("is.na_dry_spell", clsRFunctionParameter:=clsIsNaDrySpell, iPosition:=4)
                clsCombinedList.AddParameter("ds_sub", clsRFunctionParameter:=clsCalcDrySpellRollMax, iPosition:=2, bIncludeArgumentName:=False)
            Else
                clsConditionsAndOperator.RemoveParameterByName("dry_spell")
                clsCombinedList.RemoveParameterByName("ds_sub")
                clsIsNaOperatorStartDOY.RemoveParameterByName("3")
                clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_spell")
            End If
            If sdgAdditionalCondition.ucrChkDryPeriod.Checked Then
                clsConditionsAndOperator.AddParameter("dry_period", clsROperatorParameter:=clsDPCombineOperator, iPosition:=4, bIncludeArgumentName:=False)
                clsIsNaOperatorStartDOY.AddParameter("4", clsRFunctionParameter:=clsIsNaFirstDryPeriod, iPosition:=4)
                clsConditionsOrOverallOperator.AddParameter("is.na_dry_period", clsRFunctionParameter:=clsIsNaDryPeriod, iPosition:=5)
                clsCombinedList.AddParameter("dp_sub", clsRFunctionParameter:=clsCalcRollSumNumberDryPeriod, iPosition:=3, bIncludeArgumentName:=False)
            Else
                clsConditionsAndOperator.RemoveParameterByName("dry_period")
                clsCombinedList.RemoveParameterByName("dp_sub")
                clsIsNaOperatorStartDOY.RemoveParameterByName("4")
                clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_period")
            End If
            If Not sdgAdditionalCondition.ucrNudDSMaximumDays.IsEmpty Then
                clsDSCombineOperator.AddParameter("ds_max", sdgAdditionalCondition.ucrNudDSMaximumDays.GetText(), iPosition:=1)
            Else
                clsDSCombineOperator.RemoveParameterByName("ds_max")
            End If
            If Not sdgAdditionalCondition.ucrNudRDMinimumDays.IsEmpty Then
                clsRollingSumRainDayOperator.AddParameter("1", sdgAdditionalCondition.ucrNudRDMinimumDays.GetText(), iPosition:=1)
            Else
                clsRollingSumRainDayOperator.RemoveParameterByName("1")
            End If
            If Not sdgAdditionalCondition.ucrNudDPMaxRain.IsEmpty Then
                clsSumRainDryPeriodOperator.AddParameter("right", sdgAdditionalCondition.ucrNudDPMaxRain.GetText(), iPosition:=1)
            Else
                clsSumRainDryPeriodOperator.RemoveParameterByName("right")
            End If
            If Not sdgAdditionalCondition.ucrNudDPRainPeriod.IsEmpty Then
                clsRollingSumRainDryPeriodFunction.AddParameter("n", sdgAdditionalCondition.ucrNudDPRainPeriod.GetText(), iPosition:=1)
                clsSumRainDryPeriodIntervalPlusOperator.AddParameter("n", sdgAdditionalCondition.ucrNudDPRainPeriod.GetText(), iPosition:=0)
            Else
                clsSumRainDryPeriodIntervalPlusOperator.RemoveParameterByName("n")
                clsRollingSumRainDryPeriodFunction.RemoveParameterByName("n")
            End If
            If Not sdgAdditionalCondition.ucrNudDPOverallInterval.IsEmpty Then
                clsSumRainDryPeriodIntervalMinusOperator.AddParameter("0", sdgAdditionalCondition.ucrNudDPOverallInterval.GetText(), iPosition:=0)
            Else
                clsSumRainDryPeriodIntervalMinusOperator.RemoveParameterByName("0")
            End If
            If Not sdgAdditionalCondition.ucrNudDSLengthOfTime.IsEmpty Then
                clsDrySpellPeriodRollMaxFunction.AddParameter("n", sdgAdditionalCondition.ucrNudDSLengthOfTime.GetText(), iPosition:=0)
            Else
                clsDrySpellPeriodRollMaxFunction.RemoveParameterByName("n")
            End If
            If Not sdgAdditionalCondition.ucrNudRDOutOfDays.IsEmpty Then
                clsRainDayRollingSumFunction.AddParameter("n", sdgAdditionalCondition.ucrNudRDOutOfDays.GetText(), iPosition:=1)
            Else
                clsRainDayRollingSumFunction.RemoveParameterByName("n")
            End If
        Else
            clsCombinedList.RemoveParameterByName("rd_sub")
            clsCombinedList.RemoveParameterByName("ds_sub")
            clsCombinedList.RemoveParameterByName("dp_sub")

            clsIsNaOperatorStartDOY.RemoveParameterByName("4")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_period")
            clsIsNaOperatorStartDOY.RemoveParameterByName("3")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_dry_spell")
            clsIsNaOperatorStartDOY.RemoveParameterByName("2")
            clsConditionsOrOverallOperator.RemoveParameterByName("is.na_roll_sum_rain_day")

            clsConditionsAndOperator.RemoveParameterByName("dry_period")
            clsConditionsAndOperator.RemoveParameterByName("dry_spell")
            clsConditionsAndOperator.RemoveParameterByName("rain_days")

            clsRainDayRollingSumFunction.RemoveParameterByName("n")
            clsDrySpellPeriodRollMaxFunction.RemoveParameterByName("n")
            clsSumRainDryPeriodOperator.RemoveParameterByName("right")
            clsDSCombineOperator.RemoveParameterByName("ds_max")
            clsRollingSumRainDayOperator.RemoveParameterByName("1")
            clsSumRainDryPeriodIntervalPlusOperator.RemoveParameterByName("n")
            clsRollingSumRainDryPeriodFunction.RemoveParameterByName("n")
            clsSumRainDryPeriodIntervalMinusOperator.RemoveParameterByName("0")
        End If
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
End Class
