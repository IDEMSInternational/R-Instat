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
Imports RDotNet
Imports RDotNet.Internals

Public Class dlgStartofRains
    Private bResetSubdialog As Boolean = True
    Private clsCalcRainDay, clsCalcStartDOY, clsConvertssndLinkedVariableFunction, clsDeleteunusedrowFunction, clsRunStartStatus2Function, clsStartRainCombine2Function, clsInnerIfElseFunction, clsListFunction, clsNastatus2Function As New RFunction
    Private clsIfElseStatus2Function, clsConvertColumnType1Function, clsConvertColumnType2Function, clsGetColumnDataTypeFunction, clsStatRainStatus2Function, clsSetnameRainStatusFunction, clsCalculatedListformFunction, clsConvertLinkedvariablesvectorFunction As New RFunction
    Private clsListSubCalc, clsManipulationFirstDOYPerYear, clsConditionsFilter, clsCombinedList, clsSetnameRainFunction, clsConvertColumnTypeFunction As New RFunction
    Private clsConvertLinkedVariablesFunction, clsStationTypeFunction, clsConvertStationtypeFunction, clsVectorFunction, clsGetlinkeddataFunction, clsGetDataFrameFunction, clsListevapFunction, clsRollEvaporationFunction, clsFractionEvapFunction As New RFunction
    Private clsSumEvapFunction, clsDummyFunction, clsIfelseStatusFunction, clsIfelseStatus1Function, clsFirstStatusFunction, clsIsNAStatusFunction, clsCalcStartDate, clsCombinationCalc, clsListCalFunction, clsCombinationManipList, clsCombinationSubCalcList As New RFunction
    Private clsDayFromAndTo, clsGroupByStation, clsGroupByYear, clsListToTalRain, clsFirstDate As New RFunction
    Private clsDayFromAndToOperator, clsEvapOperator, clsDayFromOperator, clsRainDayConditionOperator, clsTRCombineOperator, clsStartStatusEqualsTrueOperator As New ROperator
    Private clsRollingSumRainDayOperator, clsDSCombineOperator, clsDPCombineOperator, clsDayToOperator, clsRainDayOperator, clsConditionsAndOperator As New ROperator
    Private clsDayFilterCalcFromConvert, clsDayFilterCalcFromList, clsApplyInstatFunction, clsFirstDOY, clsDefineAsClimatic, clsVectorConcat2Function As New RFunction
    Private clsGetCalulationsFunction, clsGetOffsetTermFunction, clsGetStartRainsDefinitionsFunction As New RFunction

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
    Private clsSumRainDryPeriodOperator, clsSumRainDryPeriodIntervalMinusOperator, clsIsNaStartDOYOperator, clsSumRainDryPeriodIntervalPlusOperator As New ROperator
    Private strCurrDataName As String = ""
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strWetSpell As String = "wet_spell"
    Private strFactionEvap As String = "fraction_evap"
    Private strSumFractionEvap As String = "roll_sum_evap"
    'Functions for rdotem Tmax
    Private clsGetsummerCalulationsFunction, clsGetsummerDataFrameFunction, clsGetOffsetsummerTermFunction, clsGetStartsummerDefinitionsFunction, clsListSubCalcSummerFunction, clsGetOffsetTermSummerFunction, clsGetCalulationsSummerFunction, clsGetDataFrameSummerFunction, clsGetlinkeddataSummerFunction, clsVectorConcat2SummerFunction, clsVectorSummerFunction, clsDefineAsClimaticSummerFunction, clsStartCombine2SummerFunction, clsSetnameSummerFunction, clsRunStartStatus2SummerFunction, clsListSummerFunction, clsSetnameSummerStatusFunction, clsCalculatedListformSummerFunction, clsIfElseStatus2SummerFunction, clsInnerIfElseSummerFunction, clsNastatus2SummerFunction, clsStartSummerStatus2Function, clsFirstRollMeanSummerFunction, clsIsNaFirstRollMeanSummerFunction, clsListToTalSummerFunction, clsApplyInstatSummerFunction, clsListCalSummerFunction, clsCombinationSubCalcListSummerFunction, clsCombinationManipListSummerFunction, clsCombinationCalcSummerFunction, clsIsNASummerStatusFunction, clsFirstSummerStatusFunction, clsIfelseSummerStatus1Function, clsIfelseSummerStatusFunction, clsCalcSummerStatusFunction, clsIfelseStartSummerDateFunction, clsCalcStartSummerDateFunction, clsIsNaFirstSummerFunction, clsFirstSummerFunction, clsIfelseStartDOYSummerFunction, clsCalcStartDOYSummerFunction, clsIsNaSummerFunction, clsIsnaRollMeanSummerFunction, clsConditionsFilterSummerFunction, clsCombinedListSummerFunction, clsRollingMeanSummerFunction, clsCalcRollingmeanSummerFunction As New RFunction
    'Operator for rdoTem Tmax
    Private clsStartStatusEqualsTrueSummerOperator, clsBarSummerOperator, clsGreaterOrEqualSummerOperator, clsGreaterSummerOperator, clsConditionsAndSummerOperator, clsConditionsOrOverallSummerOperator As New ROperator
    'Functions for rdoTem Tmin
    Private clsGetWinterCalulationsFunction, clsGetWinterDataFrameFunction, clsGetOffsetWinterTermFunction, clsGetStartWinterDefinitionsFunction, clsListSubCalcWinterFunction, clsGetOffsetTermWinterFunction, clsGetCalulationsWinterFunction, clsGetDataFrameWinterFunction, clsGetlinkeddataWinterFunction, clsVectorConcat2WinterFunction, clsVectorWinterFunction, clsDefineAsClimaticWinterFunction, clsStartCombine2WinterFunction, clsSetnameWinterFunction, clsRunStartStatus2WinterFunction, clsListWinterFunction, clsSetnameWinterStatusFunction, clsCalculatedListformWinterFunction, clsIfElseStatus2WinterFunction, clsInnerIfElseWinterFunction, clsNastatus2WinterFunction, clsStartWinterStatus2Function, clsFirstRollMeanWinterFunction, clsIsNaFirstRollMeanWinterFunction, clsListToTalWinterFunction, clsApplyInstatWinterFunction, clsListCalWinterFunction, clsCombinationSubCalcListWinterFunction, clsCombinationManipListWinterFunction, clsCombinationCalcWinterFunction, clsIsNAWinterStatusFunction, clsFirstWinterStatusFunction, clsIfelseWinterStatus1Function, clsIfelseWinterStatusFunction, clsCalcWinterStatusFunction, clsIfelseStartWinterDateFunction, clsCalcStartWinterDateFunction, clsIsNaFirstWinterFunction, clsFirstWinterFunction, clsIfelseStartDOYWinterFunction, clsCalcStartDOYWinterFunction, clsIsNaWinterFunction, clsIsnaRollMeanWinterFunction, clsConditionsFilterWinterFunction, clsCombinedListWinterFunction, clsRollingMeanWinterFunction, clsCalcRollingmeanWinterFunction As New RFunction
    'Operator for rdoTem Tmin
    Private clsStartStatusEqualsTrueWinterOperator, clsIsNaStartDOYWinterOperator, clsBarWinterOperator, clsGreaterOrEqualWinterOperator, clsGreaterWinterOperator, clsConditionsAndWinterOperator, clsConditionsOrOverallWinterOperator As New ROperator

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
        DialogueSize()
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

        ucrPnlStart.AddRadioButton(rdoRain)
        ucrPnlStart.AddRadioButton(rdoTemperature)
        ucrPnlStart.AddParameterPresentCondition(rdoRain, "Checked", False)
        ucrPnlStart.AddParameterPresentCondition(rdoTemperature, "Checked")
        ucrPnlStart.AddToLinkedControls({ucrSaveDefinition, ucrReceiverRainfall, ucrInputThreshold}, {rdoRain}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStart.AddToLinkedControls({ucrPnlTem, ucrNudTotalOverDays, ucrReceiverTem}, {rdoTemperature}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStart.AddToLinkedControls(ucrNudAmount, {rdoTemperature}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)

        ucrPnlTem.AddRadioButton(rdoSummer)
        ucrPnlTem.AddRadioButton(rdoWinter)
        ucrPnlTem.AddParameterPresentCondition(rdoSummer, "Checked", False)
        ucrPnlTem.AddParameterPresentCondition(rdoWinter, "Checked")
        ucrPnlTem.AddToLinkedControls({ucrReceiverTmax, ucrSaveDefinitionTem}, {rdoSummer}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTem.AddToLinkedControls({ucrReceiverTmin, ucrSaveDefinitionwinter}, {rdoWinter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

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

        ucrNudTRAmount.SetParameter(New RParameter("tr_amount", 20, False), False)
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
        ucrInputNewDoyColumnName.SetName("start")

        ucrInputNewDateColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewDateColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewDateColumnName.SetName("start_d")

        ucrInputNewStatusColumnName.SetParameter(New RParameter("result_name", 2))
        ucrInputNewStatusColumnName.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputNewStatusColumnName.SetName("start_s")

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

        ucrReceiverTmax.SetParameter(New RParameter("x", 0))
        ucrReceiverTmax.SetParameterIsString()
        ucrReceiverTmax.bWithQuotes = False
        ucrReceiverTmax.strSelectorHeading = "Temperature Variables"
        ucrReceiverTmax.Selector = ucrSelectorForStartofRains
        ucrReceiverTmax.SetClimaticType("temp_max")
        ucrReceiverTmax.bAutoFill = True
        ucrReceiverTmax.SetLinkedDisplayControl(lblTmax)

        ucrReceiverTmin.SetParameter(New RParameter("x", 0))
        ucrReceiverTmin.SetParameterIsString()
        ucrReceiverTmin.bWithQuotes = False
        ucrReceiverTmin.strSelectorHeading = "Temperature Variables"
        ucrReceiverTmin.Selector = ucrSelectorForStartofRains
        ucrReceiverTmin.SetClimaticType("temp_min")
        ucrReceiverTmin.bAutoFill = True
        ucrReceiverTmin.SetLinkedDisplayControl(lblTmin)
        ucrReceiverTmin.Visible = False

        ucrNudAmount.SetParameter(New RParameter("threshold", 1, False))
        ucrNudAmount.DecimalPlaces = 2
        ucrNudAmount.Increment = 0.1
        ucrNudAmount.SetText("30")
        ucrNudAmount.SetLinkedDisplayControl(lblAmount)

        ucrNudTotalOverDays.SetParameter(New RParameter("n", 1))
        ucrNudTotalOverDays.SetMinMax(1, 366)
        ucrNudTotalOverDays.SetLinkedDisplayControl(lblTotalOverDays)

        ucrInputTextTempday.SetParameter(New RParameter("result_name", 2))
        ucrInputTextTempday.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputTextTempday.SetName("start")

        ucrInputTextTemdate.SetParameter(New RParameter("result_name", 2))
        ucrInputTextTemdate.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputTextTemdate.SetName("start_d")

        ucrInputTextTemOccu.SetParameter(New RParameter("result_name", 2))
        ucrInputTextTemOccu.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputTextTemOccu.SetName("start_s")

        ucrChkTemDay.AddToLinkedControls(ucrInputTextTempday, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTemDate.AddToLinkedControls(ucrInputTextTemdate, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTemOccu.AddToLinkedControls(ucrInputTextTemOccu, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkTemDay.AddParameterPresentCondition(True, "sub1", True)
        ucrChkTemDay.AddParameterPresentCondition(False, "sub1", False)
        ucrChkTemDay.SetText("Day")

        ucrChkTemDate.AddParameterValuesCondition(True, "sub2", "True")
        ucrChkTemDate.AddParameterValuesCondition(False, "sub2", "False")
        ucrChkTemDate.SetText("Date")

        ucrChkTemOccu.AddParameterValuesCondition(True, "sub3", "True")
        ucrChkTemOccu.AddParameterValuesCondition(False, "sub3", "False")
        ucrChkTemOccu.SetText("Occurrence")

        ucrInputDayWinter.SetParameter(New RParameter("result_name", 2))
        ucrInputDayWinter.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputDayWinter.SetName("start")

        ucrInputDateWinter.SetParameter(New RParameter("result_name", 2))
        ucrInputDateWinter.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputDateWinter.SetName("start_d")

        ucrInputOccuWinter.SetParameter(New RParameter("result_name", 2))
        ucrInputOccuWinter.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)
        ucrInputOccuWinter.SetName("start_s")
        ucrChkDayWinter.AddToLinkedControls(ucrInputDayWinter, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDateWinter.AddToLinkedControls(ucrInputDateWinter, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkOccuWinter.AddToLinkedControls(ucrInputOccuWinter, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDayWinter.AddParameterPresentCondition(True, "sub1", True)
        ucrChkDayWinter.AddParameterPresentCondition(False, "sub1", False)
        ucrChkDayWinter.SetText("Day")

        ucrChkDateWinter.AddParameterValuesCondition(True, "sub2", "True")
        ucrChkDateWinter.AddParameterValuesCondition(False, "sub2", "False")
        ucrChkDateWinter.SetText("Date")

        ucrChkOccuWinter.AddParameterValuesCondition(True, "sub3", "True")
        ucrChkOccuWinter.AddParameterValuesCondition(False, "sub3", "False")
        ucrChkOccuWinter.SetText("Occurrence")

        ucrSaveDefinition.SetPrefix("start_rains_definition")
        ucrSaveDefinition.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveDefinition.SetIsComboBox()
        ucrSaveDefinition.SetCheckBoxText("Store Definitions")
        ucrSaveDefinition.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveDefinition.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)

        ucrSaveDefinitionTem.SetPrefix("start_summer_definition")
        ucrSaveDefinitionTem.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveDefinitionTem.SetIsComboBox()
        ucrSaveDefinitionTem.SetCheckBoxText("Store Definitions")
        ucrSaveDefinitionTem.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveDefinitionTem.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)

        ucrSaveDefinitionwinter.SetPrefix("start_winter_definition")
        ucrSaveDefinitionwinter.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveDefinitionwinter.SetIsComboBox()
        ucrSaveDefinitionwinter.SetCheckBoxText("Store Definitions")
        ucrSaveDefinitionwinter.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        ucrSaveDefinitionwinter.SetDataFrameSelector(ucrSelectorForStartofRains.ucrAvailableDataFrames)

        SetReceiver()
        AdditionalCondition()
        ChangeDSValue()
        ShowHideControls()
        DialogueSize()
    End Sub

    Private Sub SetDefaults()
        Dim strRainDay As String = "rain_day"
        Dim strRollSumRainDay As String = "roll_n_rain_days"
        Dim strDrySpell As String = "dry_spell"
        Dim strRollMaxDrySpell As String = "roll_max_dry_spell"
        Dim strAboveThreshold As String = "above_threshold"
        Dim strRollSumNumberDryPeriod As String = "n_dry_period"
        Dim strRollSumRain As String = "roll_sum_rain"
        Dim strRollMeanTem As String = "roll_mean_tem"
        Dim strStartDate As String = "start_d"
        Dim strStartStatus As String = "start_s"
        Dim strStartDoy As String = "start"
        Dim strRollSumRainDryPeriod As String = "roll_sum_rain_dry_period"
        Dim strYearType As String = "year_type"
        Dim strStationType As String = "station_type"
        Dim strcalculatedfromlist As String = "calculated_from_list"
        Dim strcalculatedfromlistSummer As String = "calculated_from_list"
        Dim strStartStatus2 As String = "start_rain_status2"
        Dim strStartStatus2Tem As String = "start_summer_status2"
        Dim strstartraincombinedstatus2 As String = "start_rain_combined_status_2"
        Dim strcalculatedfromlistWinter As String = "calculated_from_list"
        Dim strstartsummercombinedstatus2 As String = "start_summer_combined_status_2"
        Dim strLinkedDataName As String = "linked_data_name"
        Dim strstartWintercombinedstatus2 As String = "start_winter_combined_status_2"
        Dim strStartStatus2Winter As String = "start_winter_status2"
        Dim strRollMeanWinter As String = "roll_mean_tem"

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
        clsDefineAsClimatic = New RFunction
        clsVectorConcat2Function = New RFunction
        clsGetCalulationsFunction = New RFunction
        clsGetOffsetTermFunction = New RFunction
        clsGetStartRainsDefinitionsFunction = New RFunction
        clsGetsummerDataFrameFunction = New RFunction
        clsGetsummerCalulationsFunction = New RFunction
        clsGetOffsetsummerTermFunction = New RFunction
        clsGetStartsummerDefinitionsFunction = New RFunction

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
        clsGetOffsetTermSummerFunction.Clear()
        clsGetCalulationsSummerFunction.Clear()
        clsGetDataFrameSummerFunction.Clear()
        clsGetlinkeddataSummerFunction.Clear()
        clsVectorConcat2SummerFunction.Clear()
        clsVectorSummerFunction.Clear()
        clsDefineAsClimaticSummerFunction.Clear()
        clsStartCombine2SummerFunction.Clear()
        clsSetnameSummerFunction.Clear()
        clsRunStartStatus2SummerFunction.Clear()
        clsListSummerFunction.Clear()
        clsSetnameSummerStatusFunction.Clear()
        clsCalculatedListformSummerFunction.Clear()
        clsIfElseStatus2SummerFunction.Clear()
        clsInnerIfElseSummerFunction.Clear()
        clsNastatus2SummerFunction.Clear()
        clsStartSummerStatus2Function.Clear()
        clsFirstRollMeanSummerFunction.Clear()
        clsIsNaFirstRollMeanSummerFunction.Clear()
        clsListToTalSummerFunction.Clear()
        clsApplyInstatSummerFunction.Clear()
        clsListCalSummerFunction.Clear()
        clsCombinationSubCalcListSummerFunction.Clear()
        clsCombinationManipListSummerFunction.Clear()
        clsCombinationCalcSummerFunction.Clear()
        clsIsNASummerStatusFunction.Clear()
        clsFirstSummerStatusFunction.Clear()
        clsIfelseSummerStatus1Function.Clear()
        clsIfelseSummerStatusFunction.Clear()
        clsCalcSummerStatusFunction.Clear()
        clsIfelseStartSummerDateFunction.Clear()
        clsCalcStartSummerDateFunction.Clear()
        clsIsNaFirstSummerFunction.Clear()
        clsFirstSummerFunction.Clear()
        clsIfelseStartDOYSummerFunction.Clear()
        clsCalcStartDOYSummerFunction.Clear()
        clsIsNaSummerFunction.Clear()
        clsIsnaRollMeanSummerFunction.Clear()
        clsConditionsFilterSummerFunction.Clear()
        clsCombinedListSummerFunction.Clear()
        clsRollingMeanSummerFunction.Clear()
        clsCalcRollingmeanSummerFunction.Clear()
        clsSpellsFunction.Clear()
        clsRainDaySpellsOperator.Clear()
        clsStartStatusEqualsTrueSummerOperator.Clear()
        clsBarSummerOperator.Clear()
        clsGreaterOrEqualSummerOperator.Clear()
        clsGreaterSummerOperator.Clear()
        clsConditionsAndSummerOperator.Clear()
        clsConditionsOrOverallSummerOperator.Clear()
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
        clsListSubCalcSummerFunction.Clear()
        clsIfelseStartDOY.Clear()
        clsIfelseStartDate.Clear()
        clsGetWinterCalulationsFunction.Clear()
        clsGetWinterDataFrameFunction.Clear()
        clsGetOffsetWinterTermFunction.Clear()
        clsGetStartWinterDefinitionsFunction.Clear()
        clsListSubCalcWinterFunction.Clear()
        clsGetOffsetTermWinterFunction.Clear()
        clsGetCalulationsWinterFunction.Clear()
        clsGetDataFrameWinterFunction.Clear()
        clsGetlinkeddataWinterFunction.Clear()
        clsVectorConcat2WinterFunction.Clear()
        clsVectorWinterFunction.Clear()
        clsDefineAsClimaticWinterFunction.Clear()
        clsStartCombine2WinterFunction.Clear()
        clsSetnameWinterFunction.Clear()
        clsRunStartStatus2WinterFunction.Clear()
        clsListWinterFunction.Clear()
        clsSetnameWinterStatusFunction.Clear()
        clsCalculatedListformWinterFunction.Clear()
        clsIfElseStatus2WinterFunction.Clear()
        clsInnerIfElseWinterFunction.Clear()
        clsNastatus2WinterFunction.Clear()
        clsStartWinterStatus2Function.Clear()
        clsFirstRollMeanWinterFunction.Clear()
        clsIsNaFirstRollMeanWinterFunction.Clear()
        clsListToTalWinterFunction.Clear()
        clsApplyInstatWinterFunction.Clear()
        clsListCalWinterFunction.Clear()
        clsCombinationSubCalcListWinterFunction.Clear()
        clsCombinationManipListWinterFunction.Clear()
        clsCombinationCalcWinterFunction.Clear()
        clsIsNAWinterStatusFunction.Clear()
        clsFirstWinterStatusFunction.Clear()
        clsIfelseWinterStatus1Function.Clear()
        clsIfelseWinterStatusFunction.Clear()
        clsCalcWinterStatusFunction.Clear()
        clsIfelseStartWinterDateFunction.Clear()
        clsCalcStartWinterDateFunction.Clear()
        clsIsNaFirstWinterFunction.Clear()
        clsFirstWinterFunction.Clear()
        clsIfelseStartDOYWinterFunction.Clear()
        clsCalcStartDOYWinterFunction.Clear()
        clsIsNaWinterFunction.Clear()
        clsIsnaRollMeanWinterFunction.Clear()
        clsConditionsFilterWinterFunction.Clear()
        clsCombinedListWinterFunction.Clear()
        clsRollingMeanWinterFunction.Clear()
        clsCalcRollingmeanWinterFunction.Clear()
        'Operator for rdoTem Tmin
        clsStartStatusEqualsTrueWinterOperator.Clear()
        clsBarWinterOperator.Clear()
        clsGreaterOrEqualWinterOperator.Clear()
        clsGreaterWinterOperator.Clear()
        clsConditionsAndWinterOperator.Clear()
        clsConditionsOrOverallWinterOperator.Clear()

        clsTRCombineOperator.Clear()
        clsRollingSumRainDayOperator.Clear()
        clsDSCombineOperator.Clear()
        clsDPCombineOperator.Clear()

        bResetSubdialog = True
        ucrSelectorForStartofRains.Reset()
        ucrSaveDefinition.Reset()
        ucrSaveDefinitionTem.Reset()
        SetRCodeForControls(True)
        ucrNudTROverDays.SetText("3")
        ucrNudTRAmount.SetText("20")
        ucrNudTotalOverDays.SetText("1")
        ucrNudAmount.SetText("30")

        clsDayFilterCalcFromConvert.SetPackageName("databook")
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")

        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        clsDummyFunction.AddParameter("sub2", "True", iPosition:=0)
        clsDummyFunction.AddParameter("sub3", "True", iPosition:=1)
        clsDummyFunction.AddParameter("additional", "False", iPosition:=2)
        clsDummyFunction.AddParameter("definitions", "False", iPosition:=3)
        clsDummyFunction.AddParameter("checked", "Rain", iPosition:=4)

        'Day From and To
        clsDayFromAndTo.SetPackageName("instatCalculations")
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
        clsGroupByStation.SetPackageName("instatCalculations")
        clsGroupByStation.SetRCommand("instat_calculation$new")
        clsGroupByStation.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStation.SetAssignTo("grouping_by_station")

        ' group_by_year
        clsGroupByYear.SetPackageName("instatCalculations")
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
        clsCalcRainRollingSum.SetPackageName("instatCalculations")
        clsCalcRainRollingSum.SetRCommand("instat_calculation$new")
        clsCalcRainRollingSum.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRainRollingSum.AddParameter("function_exp", clsRFunctionParameter:=clsRainRollingSumFunction, iPosition:=1)
        clsCalcRainRollingSum.AddParameter("result_name", Chr(34) & strRollSumRain & Chr(34), iPosition:=2)
        clsCalcRainRollingSum.SetAssignTo(strRollSumRain)

        clsRainRollingSumFunction.SetPackageName("RcppRoll")
        clsRainRollingSumFunction.SetRCommand("roll_sumr")
        clsRainRollingSumFunction.AddParameter("n", ucrNudTROverDays.GetText, iPosition:=1)
        clsRainRollingSumFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRainRollingSumFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRainRollingSumFunction.bToScriptAsRString = True

        clsFirstRollSumRain.SetPackageName("dplyr")
        clsFirstRollSumRain.SetRCommand("first")
        clsFirstRollSumRain.AddParameter("x", strRollSumRain, iPosition:=0)

        clsIsNaFirstRollSumRain.SetRCommand("is.na")
        clsIsNaFirstRollSumRain.AddParameter("x", clsRFunctionParameter:=clsFirstRollSumRain, iPosition:=0)

        ' RAINY DAY associated with ucrChkNumberOfRainyDays
        clsCalcRainDay.SetPackageName("instatCalculations")
        clsCalcRainDay.SetRCommand("instat_calculation$new")
        clsCalcRainDay.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRainDay.AddParameter("function_exp", clsROperatorParameter:=clsRainDayOperator, iPosition:=1)
        clsCalcRainDay.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsCalcRainDay.SetAssignTo(strRainDay)

        clsRainDayOperator.SetOperation(">=")
        clsRainDayOperator.bToScriptAsRString = True
        clsRainDayOperator.AddParameter("threshold", 0.85, iPosition:=1)

        clsCalcRainDayRollingSum.SetPackageName("instatCalculations")
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
        clsSORFilter.SetPackageName("instatCalculations")
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
        clsTRWetSpell.SetPackageName("instatCalculations")
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
        clsCalcDrySpell.SetPackageName("instatCalculations")
        clsCalcDrySpell.SetRCommand("instat_calculation$new")
        clsCalcDrySpell.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcDrySpell.AddParameter("function_exp", clsRFunctionParameter:=clsSpellsFunction, iPosition:=1)
        clsCalcDrySpell.AddParameter("result_name", Chr(34) & strDrySpell & Chr(34), iPosition:=2)
        clsCalcDrySpell.AddParameter("sub_calculations", clsRFunctionParameter:=clsDrySpellSubCalcList, iPosition:=4)
        clsCalcDrySpell.SetAssignTo(strDrySpell)

        clsDrySpellSubCalcList.SetRCommand("list")
        clsDrySpellSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcRainDay, bIncludeArgumentName:=False)


        clsSpellsFunction.SetPackageName("instatClimatic")
        clsSpellsFunction.SetRCommand("spells")
        clsSpellsFunction.AddParameter("x", clsROperatorParameter:=clsRainDaySpellsOperator, iPosition:=0)
        clsSpellsFunction.bToScriptAsRString = True

        clsRainDaySpellsOperator.SetOperation("==")
        clsRainDaySpellsOperator.AddParameter("0", strRainDay, iPosition:=0)
        clsRainDaySpellsOperator.AddParameter("1", "0", iPosition:=1)

        clsCalcDrySpellRollMax.SetPackageName("instatCalculations")
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

        clsFractionEvapFunction.SetPackageName("instatCalculations")
        clsFractionEvapFunction.SetRCommand("instat_calculation$new")
        clsFractionEvapFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsFractionEvapFunction.AddParameter("function_exp", clsROperatorParameter:=clsEvapOperator, iPosition:=1)
        clsFractionEvapFunction.AddParameter("result_name", Chr(34) & strFactionEvap & Chr(34), iPosition:=2)
        clsFractionEvapFunction.SetAssignTo(strFactionEvap)

        clsEvapOperator.SetOperation("*")
        clsEvapOperator.bToScriptAsRString = True

        clsSumEvapFunction.SetPackageName("instatCalculations")
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
        clsRollEvaporationFunction.AddParameter("n", ucrNudTROverDays.GetText, iPosition:=4)
        clsRollEvaporationFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollEvaporationFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRollEvaporationFunction.bToScriptAsRString = True

        'DRY PERIOD
        clsCalcRainRollingSumDryPeriod.SetPackageName("instatCalculations")
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

        clsCalcRollSumNumberDryPeriod.SetPackageName("instatCalculations")
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
        clsConditionsFilter.SetPackageName("instatCalculations")
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
        clsTRCombineOperator.AddParameter("tr_amount", "20", iPosition:=1, bIncludeArgumentName:=False)

        ' run if chkDS is checked
        clsDSCombineOperator.SetOperation("<=")
        clsDSCombineOperator.AddParameter("ds_left", strRollMaxDrySpell, iPosition:=0)
        clsDSCombineOperator.AddParameter("ds_max", 9, iPosition:=1)

        ' run if chkDP is checked
        clsDPCombineOperator.SetOperation("==")
        clsDPCombineOperator.AddParameter("dp_left", strRollSumNumberDryPeriod, iPosition:=0)
        clsDPCombineOperator.AddParameter("dp_max", 0, iPosition:=1)

        ' First DOY
        clsCalcStartDOY.SetPackageName("instatCalculations")
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
        clsCalcStartDate.SetPackageName("instatCalculations")
        clsCalcStartDate.SetRCommand("instat_calculation$new")
        clsCalcStartDate.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartDate.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartDate, iPosition:=1)
        clsCalcStartDate.AddParameter("result_name", Chr(34) & strStartDate & Chr(34), iPosition:=2)
        clsCalcStartDate.AddParameter("save", 2, iPosition:=6)
        clsCalcStartDate.SetAssignTo("start_rain_date")

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
        clsCalcStatus.SetPackageName("instatCalculations")
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
        clsCombinationCalc.SetPackageName("instatCalculations")
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

        ' IF ANY POTENTIAL PROBLEMS, REVERT THIS PART BACK TO ORIGINAL FORM
        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo("summary_data")

        clsGetlinkeddataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_linked_to_data_name")
        clsGetlinkeddataFunction.SetAssignTo(strLinkedDataName)

        clsDefineAsClimatic.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_climatic")
        clsDefineAsClimatic.AddParameter("data_name", clsRFunctionParameter:=clsGetlinkeddataFunction, iPosition:=0)
        clsDefineAsClimatic.AddParameter("overwrite", "FALSE", iPosition:=3)
        clsDefineAsClimatic.iCallType = 2

        clsVectorConcat2Function.SetRCommand("c")

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
        clsCalculatedListformFunction.SetAssignTo(strcalculatedfromlist)

        clsSetnameRainStatusFunction.SetRCommand("setNames")
        clsSetnameRainStatusFunction.AddParameter("y", strLinkedDataName, iPosition:=1, bIncludeArgumentName:=False)

        clsSetnameRainFunction.SetRCommand("setNames")
        clsSetnameRainFunction.AddParameter("y", strLinkedDataName, iPosition:=1, bIncludeArgumentName:=False)

        clsStatRainStatus2Function.SetPackageName("instatCalculations")
        clsStatRainStatus2Function.SetRCommand("instat_calculation$new")
        clsStatRainStatus2Function.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsStatRainStatus2Function.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseStatus2Function, iPosition:=1)
        clsStatRainStatus2Function.AddParameter("calculated_from", strcalculatedfromlist, iPosition:=2)
        clsStatRainStatus2Function.AddParameter("result_name", Chr(34) & "start_s" & Chr(34), iPosition:=3)
        clsStatRainStatus2Function.AddParameter("save", "2", iPosition:=4)
        clsStatRainStatus2Function.SetAssignTo(strStartStatus2)
        clsIfElseStatus2Function.SetRCommand("ifelse")
        clsIfElseStatus2Function.bToScriptAsRString = True

        clsNastatus2Function.SetRCommand("!is.na")
        clsIfElseStatus2Function.AddParameter("test", clsRFunctionParameter:=clsNastatus2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsIfElseStatus2Function.AddParameter("yes", "TRUE", iPosition:=1, bIncludeArgumentName:=False)
        clsIfElseStatus2Function.AddParameter("no", clsRFunctionParameter:=clsInnerIfElseFunction, iPosition:=2, bIncludeArgumentName:=False)

        clsInnerIfElseFunction.SetRCommand("ifelse")
        clsInnerIfElseFunction.AddParameter("test", clsROperatorParameter:=clsStartStatusEqualsTrueOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsInnerIfElseFunction.AddParameter("yes", "NA", iPosition:=1, bIncludeArgumentName:=False)

        clsStartStatusEqualsTrueOperator.SetOperation("==")
        clsStartStatusEqualsTrueOperator.AddParameter("1", "TRUE", iPosition:=1)

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

        clsGetCalulationsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_calculations")
        clsGetCalulationsFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetCalulationsFunction.SetAssignTo("calculations_data")

        clsGetOffsetTermFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_offset_term")
        clsGetOffsetTermFunction.SetAssignTo("definitions_offset")

        clsGetStartRainsDefinitionsFunction.SetRCommand("get_start_rains_definition")
        clsGetStartRainsDefinitionsFunction.AddParameter("summary_data", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsGetStartRainsDefinitionsFunction.AddParameter("calculations_data", clsRFunctionParameter:=clsGetCalulationsFunction, iPosition:=1)
        clsGetStartRainsDefinitionsFunction.AddParameter("definitions_offset", clsRFunctionParameter:=clsGetOffsetTermFunction, iPosition:=5)

        'Functions and Operators for Tem rdo
        clsCalcRollingmeanSummerFunction.SetPackageName("instatCalculations")
        clsCalcRollingmeanSummerFunction.SetRCommand("instat_calculation$new")
        clsCalcRollingmeanSummerFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRollingmeanSummerFunction.AddParameter("function_exp", clsRFunctionParameter:=clsRollingMeanSummerFunction, iPosition:=1)
        clsCalcRollingmeanSummerFunction.AddParameter("result_name", Chr(34) & strRollMeanTem & Chr(34), iPosition:=2)
        clsCalcRollingmeanSummerFunction.SetAssignTo(strRollMeanTem)

        clsRollingMeanSummerFunction.SetPackageName("RcppRoll")
        clsRollingMeanSummerFunction.SetRCommand("roll_meanr")
        clsRollingMeanSummerFunction.AddParameter("n", ucrNudTotalOverDays.GetText, iPosition:=1)
        clsRollingMeanSummerFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollingMeanSummerFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRollingMeanSummerFunction.bToScriptAsRString = True

        clsFirstRollMeanSummerFunction.SetPackageName("dplyr")
        clsFirstRollMeanSummerFunction.SetRCommand("first")
        clsFirstRollMeanSummerFunction.AddParameter("x", strRollMeanTem, iPosition:=0)

        clsIsNaFirstRollMeanSummerFunction.SetRCommand("is.na")
        clsIsNaFirstRollMeanSummerFunction.AddParameter("x", clsRFunctionParameter:=clsFirstRollMeanSummerFunction, iPosition:=0)

        clsConditionsFilterSummerFunction.SetPackageName("instatCalculations")
        clsConditionsFilterSummerFunction.SetRCommand("instat_calculation$new")
        clsConditionsFilterSummerFunction.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsConditionsFilterSummerFunction.AddParameter("function_exp", clsROperatorParameter:=clsConditionsOrOverallSummerOperator, iPosition:=1)
        clsConditionsFilterSummerFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedListSummerFunction, iPosition:=4)
        clsConditionsFilterSummerFunction.SetAssignTo("conditions_filter")

        clsConditionsOrOverallSummerOperator.SetOperation("|")
        clsConditionsOrOverallSummerOperator.bToScriptAsRString = True
        clsConditionsOrOverallSummerOperator.AddParameter("conditions", clsROperatorParameter:=clsConditionsAndSummerOperator, iPosition:=0)
        clsConditionsOrOverallSummerOperator.AddParameter("is.na_tem", clsROperatorParameter:=clsBarSummerOperator, iPosition:=1)

        clsConditionsAndSummerOperator.SetOperation("&")
        clsConditionsAndSummerOperator.AddParameter("left", clsROperatorParameter:=clsGreaterOrEqualSummerOperator, iPosition:=0)
        clsConditionsAndSummerOperator.AddParameter("right", clsROperatorParameter:=clsGreaterSummerOperator, iPosition:=1)

        clsGreaterOrEqualSummerOperator.SetOperation(">=")
        clsGreaterOrEqualSummerOperator.AddParameter("threshold", "30", iPosition:=1, bIncludeArgumentName:=False)

        clsGreaterSummerOperator.SetOperation(">")
        clsGreaterSummerOperator.AddParameter("tr_left", strRollMeanTem, iPosition:=0)
        clsGreaterSummerOperator.AddParameter("tr_amount", "1", iPosition:=1)

        clsBarSummerOperator.SetOperation("|")
        clsBarSummerOperator.AddParameter("left", clsRFunctionParameter:=clsIsNaSummerFunction, iPosition:=0)
        clsBarSummerOperator.AddParameter("right", clsRFunctionParameter:=clsIsnaRollMeanSummerFunction, iPosition:=1)

        clsIsnaRollMeanSummerFunction.SetRCommand("is.na")
        clsIsnaRollMeanSummerFunction.AddParameter("x", strRollMeanTem, iPosition:=0)

        clsIsNaSummerFunction.SetRCommand("is.na")

        clsCombinedListSummerFunction.SetRCommand("list")
        clsCombinedListSummerFunction.AddParameter("tr_sub", clsRFunctionParameter:=clsCalcRollingmeanSummerFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsCalcStartDOYSummerFunction.SetPackageName("instatCalculations")
        clsCalcStartDOYSummerFunction.SetRCommand("instat_calculation$new")
        clsCalcStartDOYSummerFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartDOYSummerFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartDOYSummerFunction, iPosition:=1)
        clsCalcStartDOYSummerFunction.AddParameter("result_name", Chr(34) & strStartDoy & Chr(34), iPosition:=2)
        clsCalcStartDOYSummerFunction.AddParameter("save", 2, iPosition:=6)
        clsCalcStartDOYSummerFunction.SetAssignTo("start_of_summer_doy")

        clsIfelseStartDOYSummerFunction.SetRCommand("ifelse")
        clsIfelseStartDOYSummerFunction.bToScriptAsRString = True
        clsIfelseStartDOYSummerFunction.AddParameter("test", clsROperatorParameter:=clsIsNaStartDOYOperator, iPosition:=0)
        clsIfelseStartDOYSummerFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfelseStartDOYSummerFunction.AddParameter("no", clsRFunctionParameter:=clsFirstDOY, iPosition:=2)

        clsIsNaStartDOYOperator.SetOperation("|")
        clsIsNaStartDOYOperator.AddParameter("0", clsRFunctionParameter:=clsIsNaFirstSummerFunction, iPosition:=0)
        clsIsNaStartDOYOperator.AddParameter("1", clsRFunctionParameter:=clsIsNaFirstRollMeanSummerFunction, iPosition:=1)

        clsIsNaFirstSummerFunction.SetRCommand("is.na")
        clsIsNaFirstSummerFunction.AddParameter("x", clsRFunctionParameter:=clsFirstSummerFunction, iPosition:=0)

        clsListToTalSummerFunction.SetRCommand("list")

        clsListSubCalcSummerFunction.SetRCommand("list")

        clsFirstSummerFunction.SetPackageName("dplyr")
        clsFirstSummerFunction.SetRCommand("first")

        clsCalcStartSummerDateFunction.SetPackageName("instatCalculations")
        clsCalcStartSummerDateFunction.SetRCommand("instat_calculation$new")
        clsCalcStartSummerDateFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartSummerDateFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartSummerDateFunction, iPosition:=1)
        clsCalcStartSummerDateFunction.AddParameter("result_name", Chr(34) & strStartDate & Chr(34), iPosition:=2)
        clsCalcStartSummerDateFunction.AddParameter("save", 2, iPosition:=6)
        clsCalcStartSummerDateFunction.SetAssignTo("start_Summer_date")

        clsIfelseStartSummerDateFunction.SetPackageName("dplyr")
        clsIfelseStartSummerDateFunction.SetRCommand("if_else")
        clsIfelseStartSummerDateFunction.bToScriptAsRString = True
        clsIfelseStartSummerDateFunction.AddParameter("condition", clsROperatorParameter:=clsIsNaStartDOYOperator, iPosition:=0)
        clsIfelseStartSummerDateFunction.AddParameter("true", "as.Date(NA)", iPosition:=1)
        clsIfelseStartSummerDateFunction.AddParameter("false", clsRFunctionParameter:=clsFirstDate, iPosition:=2)

        clsCalcSummerStatusFunction.SetPackageName("instatCalculations")
        clsCalcSummerStatusFunction.SetRCommand("instat_calculation$new")
        clsCalcSummerStatusFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcSummerStatusFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseSummerStatusFunction, iPosition:=1)
        clsCalcSummerStatusFunction.AddParameter("result_name", Chr(34) & strStartStatus & Chr(34), iPosition:=3)
        clsCalcSummerStatusFunction.AddParameter("save", 2, iPosition:=4)
        clsCalcSummerStatusFunction.SetAssignTo("start_of_summer_status")

        clsIfelseSummerStatusFunction.SetRCommand("ifelse")
        clsIfelseSummerStatusFunction.bToScriptAsRString = True
        clsIfelseSummerStatusFunction.AddParameter("x", "n() > 0", iPosition:=0, bIncludeArgumentName:=False)
        clsIfelseSummerStatusFunction.AddParameter("y", clsRFunctionParameter:=clsIfelseSummerStatus1Function, iPosition:=1, bIncludeArgumentName:=False)
        clsIfelseSummerStatusFunction.AddParameter("z", "FALSE", iPosition:=2, bIncludeArgumentName:=False)

        clsIfelseSummerStatus1Function.SetRCommand("ifelse")
        clsIfelseSummerStatus1Function.AddParameter("yes", clsRFunctionParameter:=clsFirstSummerStatusFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsIfelseSummerStatus1Function.AddParameter("test", "NA", iPosition:=1, bIncludeArgumentName:=False)
        clsIfelseSummerStatus1Function.AddParameter("no", "TRUE", iPosition:=2, bIncludeArgumentName:=False)

        clsFirstSummerStatusFunction.SetPackageName("dplyr")
        clsFirstSummerStatusFunction.SetRCommand("first")
        clsFirstSummerStatusFunction.AddParameter("x", clsRFunctionParameter:=clsIsNASummerStatusFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsIsNASummerStatusFunction.SetRCommand("is.na")
        clsIsNASummerStatusFunction.AddParameter("x", strRollMeanTem, iPosition:=0, bIncludeArgumentName:=False)

        clsCombinationCalcSummerFunction.SetPackageName("instatCalculations")
        clsCombinationCalcSummerFunction.SetRCommand("instat_calculation$new")
        clsCombinationCalcSummerFunction.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationCalcSummerFunction.AddParameter("manipulations", clsRFunctionParameter:=clsCombinationManipListSummerFunction, iPosition:=1)
        clsCombinationCalcSummerFunction.AddParameter("sub_calculation", clsRFunctionParameter:=clsCombinationSubCalcListSummerFunction, iPosition:=2)
        clsCombinationCalcSummerFunction.SetAssignTo("start_of_summer_combined")

        clsCombinationManipListSummerFunction.SetRCommand("list")
        clsCombinationManipListSummerFunction.AddParameter("manip2", clsRFunctionParameter:=clsConditionsFilterSummerFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsCombinationManipListSummerFunction.AddParameter("manip3", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=2)
        clsCombinationManipListSummerFunction.AddParameter("manip4", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=3)

        clsCombinationSubCalcListSummerFunction.SetRCommand("list")
        clsCombinationSubCalcListSummerFunction.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOYSummerFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsCombinationSubCalcListSummerFunction.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartSummerDateFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsCombinationSubCalcListSummerFunction.AddParameter("sub3", clsRFunctionParameter:=clsCalcSummerStatusFunction, bIncludeArgumentName:=False, iPosition:=2)

        clsListCalSummerFunction.SetRCommand("list")
        clsListCalSummerFunction.AddParameter("drop", "FALSE", iPosition:=0)

        clsApplyInstatSummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatSummerFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatSummerFunction.AddParameter("calc", clsRFunctionParameter:=clsCombinationCalcSummerFunction, iPosition:=0)
        clsApplyInstatSummerFunction.AddParameter("param_list", clsRFunctionParameter:=clsListCalSummerFunction, iPosition:=2)

        clsGetStartsummerDefinitionsFunction.SetRCommand("get_start_summer_definition")
        clsGetStartsummerDefinitionsFunction.AddParameter("summary_data", clsRFunctionParameter:=clsGetsummerDataFrameFunction, iPosition:=0)
        clsGetStartsummerDefinitionsFunction.AddParameter("calculations_data", clsRFunctionParameter:=clsGetsummerCalulationsFunction, iPosition:=1)
        clsGetStartsummerDefinitionsFunction.AddParameter("definitions_offset", clsRFunctionParameter:=clsGetOffsetsummerTermFunction, iPosition:=5)

        clsGetsummerDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetsummerDataFrameFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetsummerDataFrameFunction.SetAssignTo("summary_data")

        clsGetsummerCalulationsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_calculations")
        clsGetsummerCalulationsFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetsummerCalulationsFunction.SetAssignTo("calculations_data")

        clsGetOffsetsummerTermFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_offset_term")
        clsGetOffsetsummerTermFunction.SetAssignTo("definitions_offset")

        clsStartSummerStatus2Function.SetPackageName("instatCalculations")
        clsStartSummerStatus2Function.SetRCommand("instat_calculation$new")
        clsStartSummerStatus2Function.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsStartSummerStatus2Function.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseStatus2SummerFunction, iPosition:=1)
        clsStartSummerStatus2Function.AddParameter("calculated_from", strcalculatedfromlistSummer, iPosition:=2)
        clsStartSummerStatus2Function.AddParameter("result_name", Chr(34) & "start_s" & Chr(34), iPosition:=3)
        clsStartSummerStatus2Function.AddParameter("save", "2", iPosition:=4)
        clsStartSummerStatus2Function.SetAssignTo(strStartStatus2Tem)

        clsStartCombine2SummerFunction.SetRCommand("instat_calculation$new")
        clsStartCombine2SummerFunction.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsStartCombine2SummerFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsListSummerFunction, iPosition:=1)
        clsStartCombine2SummerFunction.SetAssignTo(strstartsummercombinedstatus2)

        clsListSummerFunction.SetRCommand("list")
        clsListSummerFunction.AddParameter("x", strStartStatus2Tem, iPosition:=0, bIncludeArgumentName:=False)

        clsRunStartStatus2SummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunStartStatus2SummerFunction.AddParameter("calc", strstartsummercombinedstatus2, iPosition:=0)
        clsRunStartStatus2SummerFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsRunStartStatus2SummerFunction.AddParameter("param_list", clsRFunctionParameter:=clsListCalSummerFunction, iPosition:=2)

        clsCalculatedListformSummerFunction.SetRCommand("c")
        clsCalculatedListformSummerFunction.SetAssignTo(strcalculatedfromlistSummer)

        clsSetnameSummerStatusFunction.SetRCommand("setNames")
        clsSetnameSummerStatusFunction.AddParameter("y", strLinkedDataName, iPosition:=1, bIncludeArgumentName:=False)

        clsSetnameSummerFunction.SetRCommand("setNames")
        clsSetnameSummerFunction.AddParameter("y", strLinkedDataName, iPosition:=1, bIncludeArgumentName:=False)

        clsIfElseStatus2SummerFunction.SetRCommand("ifelse")
        clsIfElseStatus2SummerFunction.bToScriptAsRString = True

        clsNastatus2SummerFunction.SetRCommand("!is.na")
        clsIfElseStatus2SummerFunction.AddParameter("test", clsRFunctionParameter:=clsNastatus2SummerFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsIfElseStatus2SummerFunction.AddParameter("yes", "TRUE", iPosition:=1, bIncludeArgumentName:=False)
        clsIfElseStatus2SummerFunction.AddParameter("no", clsRFunctionParameter:=clsInnerIfElseSummerFunction, iPosition:=2, bIncludeArgumentName:=False)

        clsInnerIfElseSummerFunction.SetRCommand("ifelse")
        clsInnerIfElseSummerFunction.AddParameter("test", clsROperatorParameter:=clsStartStatusEqualsTrueSummerOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsInnerIfElseSummerFunction.AddParameter("yes", "NA", iPosition:=1, bIncludeArgumentName:=False)

        clsStartStatusEqualsTrueSummerOperator.SetOperation("==")
        clsStartStatusEqualsTrueSummerOperator.AddParameter("1", "TRUE", iPosition:=1)

        clsGetlinkeddataSummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_linked_to_data_name")
        clsGetlinkeddataSummerFunction.SetAssignTo(strLinkedDataName)

        clsDefineAsClimaticSummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_climatic")
        clsDefineAsClimaticSummerFunction.AddParameter("data_name", clsRFunctionParameter:=clsGetlinkeddataSummerFunction, iPosition:=0)
        clsDefineAsClimaticSummerFunction.AddParameter("overwrite", "FALSE", iPosition:=3)
        clsDefineAsClimaticSummerFunction.iCallType = 2

        clsVectorConcat2SummerFunction.SetRCommand("c")

        clsVectorSummerFunction.SetRCommand("c")

        clsGetDataFrameSummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameSummerFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameSummerFunction.SetAssignTo("summary_data")

        clsGetCalulationsSummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_calculations")
        clsGetCalulationsSummerFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetCalulationsSummerFunction.SetAssignTo("calculations_data")

        clsGetOffsetTermSummerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_offset_term")
        clsGetOffsetTermSummerFunction.SetAssignTo("definitions_offset")

        'Functions and Operators for Tmin rdo
        clsCalcRollingmeanWinterFunction.SetPackageName("instatCalculations")
        clsCalcRollingmeanWinterFunction.SetRCommand("instat_calculation$new")
        clsCalcRollingmeanWinterFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcRollingmeanWinterFunction.AddParameter("function_exp", clsRFunctionParameter:=clsRollingMeanWinterFunction, iPosition:=1)
        clsCalcRollingmeanWinterFunction.AddParameter("result_name", Chr(34) & strRollMeanWinter & Chr(34), iPosition:=2)
        clsCalcRollingmeanWinterFunction.SetAssignTo(strRollMeanTem)

        clsRollingMeanWinterFunction.SetPackageName("RcppRoll")
        clsRollingMeanWinterFunction.SetRCommand("roll_meanr")
        clsRollingMeanWinterFunction.AddParameter("n", ucrNudTotalOverDays.GetText, iPosition:=1)
        clsRollingMeanWinterFunction.AddParameter("fill", "NA", iPosition:=2)
        clsRollingMeanWinterFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsRollingMeanWinterFunction.bToScriptAsRString = True

        clsFirstRollMeanWinterFunction.SetPackageName("dplyr")
        clsFirstRollMeanWinterFunction.SetRCommand("first")
        clsFirstRollMeanWinterFunction.AddParameter("x", strRollMeanWinter, iPosition:=0)

        clsIsNaFirstRollMeanWinterFunction.SetRCommand("is.na")
        clsIsNaFirstRollMeanWinterFunction.AddParameter("x", clsRFunctionParameter:=clsFirstRollMeanWinterFunction, iPosition:=0)

        clsConditionsFilterWinterFunction.SetPackageName("instatCalculations")
        clsConditionsFilterWinterFunction.SetRCommand("instat_calculation$new")
        clsConditionsFilterWinterFunction.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsConditionsFilterWinterFunction.AddParameter("function_exp", clsROperatorParameter:=clsConditionsOrOverallWinterOperator, iPosition:=1)
        clsConditionsFilterWinterFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinedListWinterFunction, iPosition:=4)
        clsConditionsFilterWinterFunction.SetAssignTo("conditions_filter")

        clsConditionsOrOverallWinterOperator.SetOperation("|")
        clsConditionsOrOverallWinterOperator.bToScriptAsRString = True
        clsConditionsOrOverallWinterOperator.AddParameter("conditions", clsROperatorParameter:=clsConditionsAndWinterOperator, iPosition:=0)
        clsConditionsOrOverallWinterOperator.AddParameter("is.na_tem", clsROperatorParameter:=clsBarWinterOperator, iPosition:=1)

        clsConditionsAndWinterOperator.SetOperation("&")
        clsConditionsAndWinterOperator.AddParameter("left", clsROperatorParameter:=clsGreaterOrEqualWinterOperator, iPosition:=0)
        clsConditionsAndWinterOperator.AddParameter("right", clsROperatorParameter:=clsGreaterWinterOperator, iPosition:=1)

        clsGreaterOrEqualWinterOperator.SetOperation("=<")
        clsGreaterOrEqualWinterOperator.AddParameter("threshold", "30", iPosition:=1, bIncludeArgumentName:=False)

        clsGreaterWinterOperator.SetOperation(">")
        clsGreaterWinterOperator.AddParameter("tr_left", strRollMeanTem, iPosition:=0)
        clsGreaterWinterOperator.AddParameter("tr_amount", "1", iPosition:=1)

        clsBarWinterOperator.SetOperation("|")
        clsBarWinterOperator.AddParameter("left", clsRFunctionParameter:=clsIsNaWinterFunction, iPosition:=0)
        clsBarWinterOperator.AddParameter("right", clsRFunctionParameter:=clsIsnaRollMeanWinterFunction, iPosition:=1)

        clsIsnaRollMeanWinterFunction.SetRCommand("is.na")
        clsIsnaRollMeanWinterFunction.AddParameter("x", strRollMeanWinter, iPosition:=0)

        clsIsNaWinterFunction.SetRCommand("is.na")

        clsCombinedListWinterFunction.SetRCommand("list")
        clsCombinedListWinterFunction.AddParameter("tr_sub", clsRFunctionParameter:=clsCalcRollingmeanWinterFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsCalcStartDOYWinterFunction.SetPackageName("instatCalculations")
        clsCalcStartDOYWinterFunction.SetRCommand("instat_calculation$new")
        clsCalcStartDOYWinterFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartDOYWinterFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartDOYWinterFunction, iPosition:=1)
        clsCalcStartDOYWinterFunction.AddParameter("result_name", Chr(34) & strStartDoy & Chr(34), iPosition:=2)
        clsCalcStartDOYWinterFunction.AddParameter("save", 2, iPosition:=6)
        clsCalcStartDOYWinterFunction.SetAssignTo("start_of_winter_doy")

        clsIfelseStartDOYWinterFunction.SetRCommand("ifelse")
        clsIfelseStartDOYWinterFunction.bToScriptAsRString = True
        clsIfelseStartDOYWinterFunction.AddParameter("test", clsROperatorParameter:=clsIsNaStartDOYWinterOperator, iPosition:=0)
        clsIfelseStartDOYWinterFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfelseStartDOYWinterFunction.AddParameter("no", clsRFunctionParameter:=clsFirstDOY, iPosition:=2)

        clsIsNaStartDOYWinterOperator.SetOperation("|")
        clsIsNaStartDOYWinterOperator.AddParameter("0", clsRFunctionParameter:=clsIsNaFirstWinterFunction, iPosition:=0)
        clsIsNaStartDOYWinterOperator.AddParameter("1", clsRFunctionParameter:=clsIsNaFirstRollMeanWinterFunction, iPosition:=1)

        clsIsNaFirstWinterFunction.SetRCommand("is.na")
        clsIsNaFirstWinterFunction.AddParameter("x", clsRFunctionParameter:=clsFirstWinterFunction, iPosition:=0)

        clsListToTalWinterFunction.SetRCommand("list")

        clsListSubCalcWinterFunction.SetRCommand("list")

        clsFirstWinterFunction.SetPackageName("dplyr")
        clsFirstWinterFunction.SetRCommand("first")

        clsCalcStartWinterDateFunction.SetPackageName("instatCalculations")
        clsCalcStartWinterDateFunction.SetRCommand("instat_calculation$new")
        clsCalcStartWinterDateFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcStartWinterDateFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseStartWinterDateFunction, iPosition:=1)
        clsCalcStartWinterDateFunction.AddParameter("result_name", Chr(34) & strStartDate & Chr(34), iPosition:=2)
        clsCalcStartWinterDateFunction.AddParameter("save", 2, iPosition:=6)
        clsCalcStartWinterDateFunction.SetAssignTo("start_winter_date")

        clsIfelseStartWinterDateFunction.SetPackageName("dplyr")
        clsIfelseStartWinterDateFunction.SetRCommand("if_else")
        clsIfelseStartWinterDateFunction.bToScriptAsRString = True
        clsIfelseStartWinterDateFunction.AddParameter("condition", clsROperatorParameter:=clsIsNaStartDOYWinterOperator, iPosition:=0)
        clsIfelseStartWinterDateFunction.AddParameter("true", "as.Date(NA)", iPosition:=1)
        clsIfelseStartWinterDateFunction.AddParameter("false", clsRFunctionParameter:=clsFirstDate, iPosition:=2)

        clsCalcWinterStatusFunction.SetPackageName("instatCalculations")
        clsCalcWinterStatusFunction.SetRCommand("instat_calculation$new")
        clsCalcWinterStatusFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsCalcWinterStatusFunction.AddParameter("function_exp", clsRFunctionParameter:=clsIfelseWinterStatusFunction, iPosition:=1)
        clsCalcWinterStatusFunction.AddParameter("result_name", Chr(34) & strStartStatus & Chr(34), iPosition:=3)
        clsCalcWinterStatusFunction.AddParameter("save", 2, iPosition:=4)
        clsCalcWinterStatusFunction.SetAssignTo("start_of_winter_status")

        clsIfelseWinterStatusFunction.SetRCommand("ifelse")
        clsIfelseWinterStatusFunction.bToScriptAsRString = True
        clsIfelseWinterStatusFunction.AddParameter("x", "n() > 0", iPosition:=0, bIncludeArgumentName:=False)
        clsIfelseWinterStatusFunction.AddParameter("y", clsRFunctionParameter:=clsIfelseWinterStatus1Function, iPosition:=1, bIncludeArgumentName:=False)
        clsIfelseWinterStatusFunction.AddParameter("z", "FALSE", iPosition:=2, bIncludeArgumentName:=False)

        clsIfelseWinterStatus1Function.SetRCommand("ifelse")
        clsIfelseWinterStatus1Function.AddParameter("yes", clsRFunctionParameter:=clsFirstWinterStatusFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsIfelseWinterStatus1Function.AddParameter("test", "NA", iPosition:=1, bIncludeArgumentName:=False)
        clsIfelseWinterStatus1Function.AddParameter("no", "TRUE", iPosition:=2, bIncludeArgumentName:=False)

        clsFirstWinterStatusFunction.SetPackageName("dplyr")
        clsFirstWinterStatusFunction.SetRCommand("first")
        clsFirstWinterStatusFunction.AddParameter("x", clsRFunctionParameter:=clsIsNAWinterStatusFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsIsNAWinterStatusFunction.SetRCommand("is.na")
        clsIsNAWinterStatusFunction.AddParameter("x", strRollMeanWinter, iPosition:=0, bIncludeArgumentName:=False)

        clsCombinationCalcWinterFunction.SetPackageName("instatCalculations")
        clsCombinationCalcWinterFunction.SetRCommand("instat_calculation$new")
        clsCombinationCalcWinterFunction.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationCalcWinterFunction.AddParameter("manipulations", clsRFunctionParameter:=clsCombinationManipListWinterFunction, iPosition:=1)
        clsCombinationCalcWinterFunction.AddParameter("sub_calculation", clsRFunctionParameter:=clsCombinationSubCalcListWinterFunction, iPosition:=2)
        clsCombinationCalcWinterFunction.SetAssignTo("start_of_winter_combined")

        clsCombinationManipListWinterFunction.SetRCommand("list")
        clsCombinationManipListWinterFunction.AddParameter("manip2", clsRFunctionParameter:=clsConditionsFilterWinterFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsCombinationManipListWinterFunction.AddParameter("manip3", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=2)
        clsCombinationManipListWinterFunction.AddParameter("manip4", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=3)

        clsCombinationSubCalcListWinterFunction.SetRCommand("list")
        clsCombinationSubCalcListWinterFunction.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOYWinterFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsCombinationSubCalcListWinterFunction.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartWinterDateFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsCombinationSubCalcListWinterFunction.AddParameter("sub3", clsRFunctionParameter:=clsCalcWinterStatusFunction, bIncludeArgumentName:=False, iPosition:=2)

        clsListCalWinterFunction.SetRCommand("list")
        clsListCalWinterFunction.AddParameter("drop", "FALSE", iPosition:=0)

        clsApplyInstatWinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsApplyInstatWinterFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsApplyInstatWinterFunction.AddParameter("calc", clsRFunctionParameter:=clsCombinationCalcWinterFunction, iPosition:=0)
        clsApplyInstatWinterFunction.AddParameter("param_list", clsRFunctionParameter:=clsListCalWinterFunction, iPosition:=2)

        clsGetStartWinterDefinitionsFunction.SetRCommand("get_start_summer_definition")
        clsGetStartWinterDefinitionsFunction.AddParameter("summary_data", clsRFunctionParameter:=clsGetWinterDataFrameFunction, iPosition:=0)
        clsGetStartWinterDefinitionsFunction.AddParameter("calculations_data", clsRFunctionParameter:=clsGetWinterCalulationsFunction, iPosition:=1)
        clsGetStartWinterDefinitionsFunction.AddParameter("definitions_offset", clsRFunctionParameter:=clsGetOffsetWinterTermFunction, iPosition:=5)

        clsGetWinterDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetWinterDataFrameFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetWinterDataFrameFunction.SetAssignTo("summary_data")

        clsGetWinterCalulationsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_calculations")
        clsGetWinterCalulationsFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetWinterCalulationsFunction.SetAssignTo("calculations_data")

        clsGetOffsetWinterTermFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_offset_term")
        clsGetOffsetWinterTermFunction.SetAssignTo("definitions_offset")

        clsStartWinterStatus2Function.SetPackageName("instatCalculations")
        clsStartWinterStatus2Function.SetRCommand("instat_calculation$new")
        clsStartWinterStatus2Function.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsStartWinterStatus2Function.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseStatus2WinterFunction, iPosition:=1)
        clsStartWinterStatus2Function.AddParameter("calculated_from", strcalculatedfromlistWinter, iPosition:=2)
        clsStartWinterStatus2Function.AddParameter("result_name", Chr(34) & "start_s" & Chr(34), iPosition:=3)
        clsStartWinterStatus2Function.AddParameter("save", "2", iPosition:=4)
        clsStartWinterStatus2Function.SetAssignTo(strStartStatus2Winter)

        clsStartCombine2WinterFunction.SetRCommand("instat_calculation$new")
        clsStartCombine2WinterFunction.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsStartCombine2WinterFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsListWinterFunction, iPosition:=1)
        clsStartCombine2WinterFunction.SetAssignTo(strstartWintercombinedstatus2)

        clsListWinterFunction.SetRCommand("list")
        clsListWinterFunction.AddParameter("x", strStartStatus2Winter, iPosition:=0, bIncludeArgumentName:=False)

        clsRunStartStatus2WinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunStartStatus2WinterFunction.AddParameter("calc", strstartWintercombinedstatus2, iPosition:=0)
        clsRunStartStatus2WinterFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsRunStartStatus2WinterFunction.AddParameter("param_list", clsRFunctionParameter:=clsListCalWinterFunction, iPosition:=2)

        clsCalculatedListformWinterFunction.SetRCommand("c")
        clsCalculatedListformWinterFunction.SetAssignTo(strcalculatedfromlistWinter)

        clsSetnameWinterStatusFunction.SetRCommand("setNames")
        clsSetnameWinterStatusFunction.AddParameter("y", strLinkedDataName, iPosition:=1, bIncludeArgumentName:=False)

        clsSetnameWinterFunction.SetRCommand("setNames")
        clsSetnameWinterFunction.AddParameter("y", strLinkedDataName, iPosition:=1, bIncludeArgumentName:=False)

        clsIfElseStatus2WinterFunction.SetRCommand("ifelse")
        clsIfElseStatus2WinterFunction.bToScriptAsRString = True

        clsNastatus2WinterFunction.SetRCommand("!is.na")
        clsIfElseStatus2WinterFunction.AddParameter("test", clsRFunctionParameter:=clsNastatus2WinterFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsIfElseStatus2WinterFunction.AddParameter("yes", "TRUE", iPosition:=1, bIncludeArgumentName:=False)
        clsIfElseStatus2WinterFunction.AddParameter("no", clsRFunctionParameter:=clsInnerIfElseWinterFunction, iPosition:=2, bIncludeArgumentName:=False)

        clsInnerIfElseWinterFunction.SetRCommand("ifelse")
        clsInnerIfElseWinterFunction.AddParameter("test", clsROperatorParameter:=clsStartStatusEqualsTrueWinterOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsInnerIfElseWinterFunction.AddParameter("yes", "NA", iPosition:=1, bIncludeArgumentName:=False)

        clsStartStatusEqualsTrueWinterOperator.SetOperation("==")
        clsStartStatusEqualsTrueWinterOperator.AddParameter("1", "TRUE", iPosition:=1)

        clsGetlinkeddataWinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_linked_to_data_name")
        clsGetlinkeddataWinterFunction.SetAssignTo(strLinkedDataName)

        clsDefineAsClimaticWinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_climatic")
        clsDefineAsClimaticWinterFunction.AddParameter("data_name", clsRFunctionParameter:=clsGetlinkeddataWinterFunction, iPosition:=0)
        clsDefineAsClimaticWinterFunction.AddParameter("overwrite", "FALSE", iPosition:=3)
        clsDefineAsClimaticWinterFunction.iCallType = 2

        clsVectorConcat2WinterFunction.SetRCommand("c")

        clsVectorWinterFunction.SetRCommand("c")

        clsGetDataFrameWinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameWinterFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameWinterFunction.SetAssignTo("summary_data")

        clsGetCalulationsWinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_calculations")
        clsGetCalulationsWinterFunction.AddParameter("x", strLinkedDataName, iPosition:=0, bIncludeArgumentName:=False)
        clsGetCalulationsWinterFunction.SetAssignTo("calculations_data")

        clsGetOffsetTermWinterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_offset_term")
        clsGetOffsetTermWinterFunction.SetAssignTo("definitions_offset")

        ucrBase.clsRsyntax.ClearCodes()
        AddRemoveTotalOverDays()
        'ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnDataTypeFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertColumnTypeFunction, iPosition:=1)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertLinkedVariablesFunction, iPosition:=4)
        ucrBase.clsRsyntax.AddToAfterCodes(clsConvertColumnType1Function, iPosition:=6)
        ucrBase.clsRsyntax.AddToAfterCodes(clsConvertssndLinkedVariableFunction, iPosition:=8)
        SetReceiver()
        ChangeDSValue()
        AdditionalCondition()
        GroupByStationOptions()
        AddRemoveStartStatus()
        AddRemoveStatustmax()
        AddSaveDefinitionCodes()
        AddRemoveTotalOverDays()
        AddRemoveStatustmin()
        ChangeFunctions()
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
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsGreaterOrEqualSummerOperator, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsIsNaSummerFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverTmax.AddAdditionalCodeParameterPair(clsFirstSummerFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsGreaterOrEqualWinterOperator, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsIsNaWinterFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverTmin.AddAdditionalCodeParameterPair(clsFirstWinterFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrNudTotalOverDays.AddAdditionalCodeParameterPair(clsRollingMeanWinterFunction, New RParameter("n", 1), iAdditionalPairNo:=1)
        ucrInputTextTempday.AddAdditionalCodeParameterPair(clsCalcStartDOYWinterFunction, New RParameter("result_name", 3), iAdditionalPairNo:=1)
        ucrSelectorForStartofRains.AddAdditionalCodeParameterPair(clsGetOffsetWinterTermFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrInputTextTempday.AddAdditionalCodeParameterPair(clsCalcStartDOYSummerFunction, New RParameter("result_name", 3), iAdditionalPairNo:=2)
        ucrInputTextTempday.AddAdditionalCodeParameterPair(clsNastatus2SummerFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrInputTextTempday.AddAdditionalCodeParameterPair(clsSetnameSummerFunction, New RParameter("x", 0), iAdditionalPairNo:=4)

        ucrSelectorForStartofRains.AddAdditionalCodeParameterPair(clsGetOffsetsummerTermFunction, New RParameter("data_name", 0), iAdditionalPairNo:=2)
        ucrNudAmount.AddAdditionalCodeParameterPair(clsGreaterOrEqualWinterOperator, New RParameter("threshold", 1, False), iAdditionalPairNo:=1)
        ucrInputTextTemdate.AddAdditionalCodeParameterPair(clsCalcStartWinterDateFunction, New RParameter("result_name", 2), iAdditionalPairNo:=1)
        ucrInputOccuWinter.AddAdditionalCodeParameterPair(clsCalcWinterStatusFunction, New RParameter("result_name", 1), iAdditionalPairNo:=1)
        ucrInputTextTemOccu.AddAdditionalCodeParameterPair(clsStartSummerStatus2Function, New RParameter("result_name", 1), iAdditionalPairNo:=1)
        ucrInputOccuWinter.AddAdditionalCodeParameterPair(clsStartWinterStatus2Function, New RParameter("result_name", 1), iAdditionalPairNo:=2)
        ucrInputNewStatusColumnName.AddAdditionalCodeParameterPair(clsStatRainStatus2Function, New RParameter("result_name", 3), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrSelectorForStartofRains.SetRCode(clsGetOffsetTermFunction, bReset)
        ucrSaveDefinition.SetRCode(clsGetStartRainsDefinitionsFunction, bReset)
        ucrSaveDefinitionTem.SetRCode(clsGetStartsummerDefinitionsFunction, bReset)
        ucrSaveDefinitionwinter.SetRCode(clsGetStartWinterDefinitionsFunction, bReset)
        If bReset Then
            ucrChkAsDoy.SetRCode(clsCombinationSubCalcList, bReset)
            ucrChkStatus.SetRCode(clsDummyFunction, bReset)
            ucrChkAsDate.SetRCode(clsDummyFunction, bReset)
            ucrChkAdditional.SetRCode(clsDummyFunction, bReset)
            ucrNudTROverDays.SetRCode(clsRainRollingSumFunction, bReset)
            ucrNudTRAmount.SetRCode(clsTRCombineOperator, bReset)
            ucrChkTemDay.SetRCode(clsCombinationSubCalcListSummerFunction, bReset)
            ucrChkTemDate.SetRCode(clsDummyFunction, bReset)
            ucrChkTemOccu.SetRCode(clsDummyFunction, bReset)
            ucrChkDayWinter.SetRCode(clsCombinationSubCalcListWinterFunction, bReset)
            ucrChkDateWinter.SetRCode(clsDummyFunction, bReset)
            ucrChkOccuWinter.SetRCode(clsDummyFunction, bReset)
            ucrPnlStart.SetRCode(clsApplyInstatFunction, bReset)
            ucrPnlTem.SetRCode(clsApplyInstatFunction, bReset)
        End If
        ucrInputThreshold.SetRCode(clsRainDayOperator, bReset)
        ucrReceiverDate.SetRCode(clsFirstDate, bReset)
        ucrInputNewDoyColumnName.SetRCode(clsCalcStartDOY, bReset)
        ucrInputNewDateColumnName.SetRCode(clsCalcStartDate, bReset)
        ucrInputNewStatusColumnName.SetRCode(clsCalcStatus, bReset)

        'Total Rainfall
        ucrChkTotalRainfall.SetRCode(clsCombinedList, bReset)
        ucrNudTRPercentile.SetRCode(clsTRWetSpellFunction, bReset)
        ucrReceiverRainfall.SetRCode(clsRainRollingSumFunction, bReset)

        'Evaporation
        ucrReceiverEvap.SetRCode(clsEvapOperator, bReset)
        ucrNudEvapo.SetRCode(clsEvapOperator, bReset)
        ucrReceiverTmax.SetRCode(clsRollingMeanSummerFunction, bReset)
        ucrReceiverTmin.SetRCode(clsRollingMeanWinterFunction, bReset)
        ucrNudTotalOverDays.SetRCode(clsRollingMeanSummerFunction, bReset)
        ucrNudAmount.SetRCode(clsGreaterOrEqualSummerOperator, bReset)
        ucrInputTextTempday.SetRCode(clsCalcStartDOYSummerFunction, bReset)
        ucrInputTextTemdate.SetRCode(clsCalcStartSummerDateFunction, bReset)
        ucrInputTextTemOccu.SetRCode(clsCalcSummerStatusFunction, bReset)
        ucrInputDayWinter.SetRCode(clsCalcStartDOYWinterFunction, bReset)
        ucrInputDateWinter.SetRCode(clsCalcStartWinterDateFunction, bReset)
        ucrInputOccuWinter.SetRCode(clsCalcWinterStatusFunction, bReset)
        AdditionalCondition()
    End Sub

    Private Sub TestOKEnabled()
        Dim bOkEnabled As Boolean
        If rdoRain.Checked Then
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
            If ucrSaveDefinition.ucrChkSave.Checked AndAlso Not ucrSaveDefinition.IsComplete Then
                bOkEnabled = False
            End If
        Else
            If rdoSummer.Checked Then
                If Not ucrReceiverTmax.IsEmpty AndAlso
                    Not ucrReceiverDate.IsEmpty AndAlso
                    Not ucrReceiverDOY.IsEmpty AndAlso
                    Not ucrReceiverYear.IsEmpty AndAlso
                    ucrNudAmount.GetText <> "" AndAlso
                    ucrNudTotalOverDays.GetText <> "" Then
                    bOkEnabled = True
                Else
                    bOkEnabled = False
                End If
                If Not (ucrChkTemDay.Checked OrElse ucrChkTemDate.Checked OrElse ucrChkTemOccu.Checked) Then
                    bOkEnabled = False
                End If
                If (ucrChkTemDay.Checked AndAlso ucrInputTextTempday.IsEmpty) OrElse
                (ucrChkTemDate.Checked AndAlso ucrInputTextTemdate.IsEmpty) OrElse
                (ucrChkTemOccu.Checked AndAlso ucrInputTextTemOccu.IsEmpty) Then
                    bOkEnabled = False
                End If

                If ucrSaveDefinitionTem.ucrChkSave.Checked AndAlso Not ucrSaveDefinitionTem.IsComplete Then
                    bOkEnabled = False
                End If
            ElseIf rdoWinter.Checked Then
                If Not ucrReceiverTmin.IsEmpty AndAlso
                    Not ucrReceiverDate.IsEmpty AndAlso
                    Not ucrReceiverDOY.IsEmpty AndAlso
                    Not ucrReceiverYear.IsEmpty AndAlso
                    ucrNudAmount.GetText <> "" AndAlso
                    ucrNudTotalOverDays.GetText <> "" Then
                    bOkEnabled = True
                Else
                    bOkEnabled = False
                End If
                If Not (ucrChkDayWinter.Checked OrElse ucrChkDateWinter.Checked OrElse ucrChkOccuWinter.Checked) Then
                    bOkEnabled = False
                End If

                If (ucrChkDayWinter.Checked AndAlso ucrInputDayWinter.IsEmpty) OrElse
                (ucrChkDateWinter.Checked AndAlso ucrInputDateWinter.IsEmpty) OrElse
                (ucrChkOccuWinter.Checked AndAlso ucrInputOccuWinter.IsEmpty) Then
                    bOkEnabled = False
                End If
                If ucrSaveDefinitionwinter.ucrChkSave.Checked AndAlso Not ucrSaveDefinitionwinter.IsComplete Then
                    bOkEnabled = False
                End If
            End If

        End If
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub ChangeFunctions()
        If rdoRain.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatFunction)
        Else
            If rdoSummer.Checked Then
                ucrReceiverTmax.SetMeAsReceiver()
                ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatSummerFunction)
            Else
                ucrReceiverTmin.SetMeAsReceiver()
                ucrBase.clsRsyntax.SetBaseRFunction(clsApplyInstatWinterFunction)
            End If
        End If
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFromAndTo, clsNewIfElseFirstDoyFilledFunction:=clsIfElseFirstDoyFilledFunction, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False), bSetUseDateVisible:=False)
        sdgDoyRange.ShowDialog()
        sdgDoyRange.SetUseDateVisibility(False)
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
        ucrSaveDefinition.ucrChkSave.Checked = False
        ucrSaveDefinitionTem.ucrChkSave.Checked = False
    End Sub

    Private Sub ShowHideControls()
        ucrInputThreshold.Visible = rdoRain.Checked
        grpDisplay.Visible = rdoRain.Checked
        grpTemDisplay.Visible = rdoTemperature.Checked AndAlso rdoSummer.Checked
        grpWinter.Visible = rdoTemperature.Checked AndAlso rdoWinter.Checked
        grpConditionsForSatrtofRains.Visible = rdoRain.Checked
        grpTem.Visible = rdoTemperature.Checked
        ucrReceiverTmax.Visible = rdoSummer.Checked
        ucrReceiverTmin.Visible = rdoWinter.Checked
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
                clsTRCombineOperator.RemoveParameterByName("tr_perc")
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
            ' If rdoRain.Checked Then
            clsCombinationManipList.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False, iPosition:=0)
            clsListToTalRain.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
            clsCalcRainRollingSum.AddParameter("manipulations", clsRFunctionParameter:=clsListToTalRain, iPosition:=4)
            'Else
            clsCombinationManipListSummerFunction.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False, iPosition:=0)
            clsListToTalSummerFunction.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
            clsCalcRollingmeanSummerFunction.AddParameter("manipulations", clsRFunctionParameter:=clsListToTalSummerFunction, iPosition:=4)
            clsCombinationManipListWinterFunction.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False, iPosition:=0)
            clsListToTalWinterFunction.AddParameter("manip1", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False)
            clsCalcRollingmeanWinterFunction.AddParameter("manipulations", clsRFunctionParameter:=clsListToTalWinterFunction, iPosition:=4)

            clsDeleteunusedrowFunction.AddParameter("station", ucrReceiverStation.GetVariableNames(), iPosition:=2)
            clsGroupByStation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
            clsConvertStationtypeFunction.AddParameter("col_names", ucrReceiverStation.GetVariableNames(), iPosition:=1)
            clsConvertLinkedvariablesvectorFunction.AddParameter("y", ucrReceiverStation.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
            clsStationTypeFunction.AddParameter("columns", ucrReceiverStation.GetVariableNames(), iPosition:=1)
            clsConvertColumnType2Function.AddParameter("col_names", ucrReceiverStation.GetVariableNames(), iPosition:=1)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsStationTypeFunction, iPosition:=2)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsConvertStationtypeFunction, iPosition:=3)
            ucrBase.clsRsyntax.AddToAfterCodes(clsDeleteunusedrowFunction, iPosition:=9)
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

    Private Sub TotalTemCalcFrom()
        clsCalcRollingmeanSummerFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTmax.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub TotalTminCalcFrom()
        clsCalcRollingmeanWinterFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTmin.GetVariableNames & ")", iPosition:=3)
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
        TotalTemCalcFrom()
        TotalTminCalcFrom()
        DryPeriod()
        GroupByStationOptions()
        GroupByYearOptions()
        CombinedFilter()
        AddRemoveSetNamesParameter()
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
        AddTypes()
        AddSummerTypes()
        AddWinterTypes()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByYearOptions()
        YearStationVariable()
        AddTypes()
        AddSummerTypes()
        AddWinterTypes()
    End Sub

    Private Sub ucrSelectorForStartofRains_DataFrameChanged() Handles ucrSelectorForStartofRains.DataFrameChanged
        clsGetColumnDataTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnTypeFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsConvertColumnType1Function.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetlinkeddataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetlinkeddataSummerFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetlinkeddataWinterFunction.AddParameter("data_name", Chr(34) & ucrSelectorForStartofRains.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
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
        AddRemoverdoFunctions()
        If ucrChkAsDate.Checked Then
            clsCombinationSubCalcList.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartDate, bIncludeArgumentName:=False, iPosition:=1)
            clsListSubCalc.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartDate, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub2")
            clsListSubCalc.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkAsDoy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAsDoy.ControlValueChanged
        AddRemoveSetNamesParameter()
        AddRemoverdoFunctions()
        If ucrChkAsDoy.Checked Then
            clsCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False, iPosition:=0)
            clsListSubCalc.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOY, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCombinationSubCalcList.RemoveParameterByName("sub1")
            clsListSubCalc.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub AddRemoveSetNamesParameter()
        If ucrChkAsDoy.Checked Then
            clsNastatus2Function.AddParameter("x", ucrInputNewDoyColumnName.GetText, iPosition:=0, bIncludeArgumentName:=False)
            clsSetnameRainFunction.AddParameter("x", Chr(34) & ucrInputNewDoyColumnName.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsCalculatedListformFunction.AddParameter("y", clsRFunctionParameter:=clsSetnameRainFunction, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsSetnameRainFunction.RemoveParameterByName("x")
            clsNastatus2Function.RemoveParameterByName("x")
            clsCalculatedListformFunction.RemoveParameterByName("y")
        End If
        If ucrChkStatus.Checked Then
            clsStartStatusEqualsTrueOperator.AddParameter("0", ucrInputNewStatusColumnName.GetText, iPosition:=0)
            clsInnerIfElseFunction.AddParameter("no", ucrInputNewStatusColumnName.GetText, iPosition:=2, bIncludeArgumentName:=False)
            clsSetnameRainStatusFunction.AddParameter("x", Chr(34) & ucrInputNewStatusColumnName.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsCalculatedListformFunction.AddParameter("x", clsRFunctionParameter:=clsSetnameRainStatusFunction, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsSetnameRainStatusFunction.RemoveParameterByName("x")
            clsInnerIfElseFunction.RemoveParameterByName("no")
            clsStartStatusEqualsTrueOperator.RemoveParameterByName("0")
            clsCalculatedListformFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub ucrInputNewDoyColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNewDoyColumnName.ControlValueChanged
        clsSORStartSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=ucrInputNewDoyColumnName.GetText, bIncludeArgumentName:=False, iPosition:=0)
        clsSORStatusSummary.clsSORFilterOperator.AddParameter("left", strParameterValue:=ucrInputNewDoyColumnName.GetText, bIncludeArgumentName:=False, iPosition:=0)
        AddRemoveSetNamesParameter()
    End Sub

    Private Sub ucrInputNewStatusColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNewStatusColumnName.ControlValueChanged
        AddRemoveSetNamesParameter()
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
        AddRemoveDefineAsClimaticFunction()
    End Sub

    Private Sub AddRemoveStatustmax()
        If ucrChkTemOccu.Checked Then
            clsStartStatusEqualsTrueSummerOperator.AddParameter("0", ucrInputTextTemOccu.GetText, iPosition:=0)
            clsInnerIfElseSummerFunction.AddParameter("no", ucrInputTextTemOccu.GetText, iPosition:=2, bIncludeArgumentName:=False)
            clsSetnameSummerStatusFunction.AddParameter("x", Chr(34) & ucrInputTextTemOccu.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsCalculatedListformSummerFunction.AddParameter("x", clsRFunctionParameter:=clsSetnameSummerStatusFunction, iPosition:=1, bIncludeArgumentName:=False)

            If ucrChkTemDay.Checked Then
                clsNastatus2SummerFunction.AddParameter("x", ucrInputTextTempday.GetText, iPosition:=0, bIncludeArgumentName:=False)
                clsSetnameSummerFunction.AddParameter("x", Chr(34) & ucrInputTextTempday.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
                clsCalculatedListformSummerFunction.AddParameter("y", clsRFunctionParameter:=clsSetnameSummerFunction, iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsSetnameSummerFunction.RemoveParameterByName("x")
                clsNastatus2SummerFunction.RemoveParameterByName("x")
                clsCalculatedListformSummerFunction.RemoveParameterByName("y")
            End If
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetlinkeddataSummerFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsCalculatedListformSummerFunction, iPosition:=1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsStartSummerStatus2Function, iPosition:=2)
            ucrBase.clsRsyntax.AddToAfterCodes(clsStartCombine2SummerFunction, iPosition:=3)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRunStartStatus2SummerFunction, iPosition:=4)
        Else
            clsSetnameSummerStatusFunction.RemoveParameterByName("x")
            clsInnerIfElseSummerFunction.RemoveParameterByName("no")
            clsStartStatusEqualsTrueSummerOperator.RemoveParameterByName("0")
            clsCalculatedListformSummerFunction.RemoveParameterByName("x")
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataSummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformSummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartSummerStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartCombine2SummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2SummerFunction)
        End If

        If ucrChkTemDate.Checked OrElse ucrChkTemOccu.Checked OrElse ucrChkTemDay.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsDefineAsClimaticSummerFunction, iPosition:=5)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimaticSummerFunction)
        End If
    End Sub

    Private Sub AddRemoveStatustmin()
        If ucrChkOccuWinter.Checked Then
            clsStartStatusEqualsTrueWinterOperator.AddParameter("0", ucrInputOccuWinter.GetText, iPosition:=0)
            clsInnerIfElseWinterFunction.AddParameter("no", ucrInputOccuWinter.GetText, iPosition:=2, bIncludeArgumentName:=False)
            clsSetnameWinterStatusFunction.AddParameter("x", Chr(34) & ucrInputOccuWinter.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsCalculatedListformWinterFunction.AddParameter("x", clsRFunctionParameter:=clsSetnameWinterStatusFunction, iPosition:=1, bIncludeArgumentName:=False)

            ucrBase.clsRsyntax.AddToAfterCodes(clsGetlinkeddataWinterFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsCalculatedListformWinterFunction, iPosition:=1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsStartWinterStatus2Function, iPosition:=2)
            ucrBase.clsRsyntax.AddToAfterCodes(clsStartCombine2WinterFunction, iPosition:=3)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRunStartStatus2WinterFunction, iPosition:=4)
        Else
            clsSetnameWinterStatusFunction.RemoveParameterByName("x")
            clsInnerIfElseWinterFunction.RemoveParameterByName("no")
            clsStartStatusEqualsTrueWinterOperator.RemoveParameterByName("0")
            clsCalculatedListformWinterFunction.RemoveParameterByName("x")
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataWinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformWinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartWinterStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartCombine2WinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2WinterFunction)
        End If
        If ucrChkDayWinter.Checked Then
            clsNastatus2WinterFunction.AddParameter("x", ucrInputDayWinter.GetText, iPosition:=0, bIncludeArgumentName:=False)
            clsSetnameWinterFunction.AddParameter("x", Chr(34) & ucrInputDayWinter.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            clsCalculatedListformWinterFunction.AddParameter("y", clsRFunctionParameter:=clsSetnameWinterFunction, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsSetnameWinterFunction.RemoveParameterByName("x")
            clsNastatus2WinterFunction.RemoveParameterByName("x")
            clsCalculatedListformWinterFunction.RemoveParameterByName("y")
        End If
        If ucrChkDateWinter.Checked OrElse ucrChkOccuWinter.Checked OrElse ucrChkDayWinter.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsDefineAsClimaticWinterFunction, iPosition:=5)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimaticWinterFunction)
        End If
    End Sub

    Private Sub AddRemoveDefineAsClimaticFunction()
        If ucrChkAsDate.Checked OrElse ucrChkStatus.Checked OrElse ucrChkAsDoy.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsDefineAsClimatic, iPosition:=5)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimatic)
        End If
    End Sub

    Private Sub ucrChkStatus_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStatus.ControlValueChanged
        AddRemoverdoFunctions()
        If rdoRain.Checked Then
            AddRemoveStartStatus()
            AddRemoveSetNamesParameter()
            If ucrChkStatus.Checked Then
                clsCombinationSubCalcList.AddParameter("sub3", clsRFunctionParameter:=clsCalcStatus, bIncludeArgumentName:=False, iPosition:=2)
                clsListSubCalc.AddParameter("sub3", clsRFunctionParameter:=clsCalcStatus, bIncludeArgumentName:=False, iPosition:=2)
            Else
                clsCombinationSubCalcList.RemoveParameterByName("sub3")
                clsListSubCalc.RemoveParameterByName("sub3")
            End If
        End If
    End Sub

    Private Sub ucrSaveDefinition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveDefinition.ControlValueChanged
        If ucrSaveDefinition.ucrChkSave.Checked Then
            If ucrSaveDefinition.ucrInputComboSave.GetText() = "" Then
                ucrSaveDefinition.ucrInputComboSave.SetName("start_rains_definition")
            End If
        End If
    End Sub

    Private Sub ucrSaveDefinitionTem_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveDefinitionTem.ControlValueChanged
        If ucrSaveDefinitionTem.ucrChkSave.Checked Then
            If ucrSaveDefinitionTem.ucrInputComboSave.GetText() = "" Then
                ucrSaveDefinitionTem.ucrInputComboSave.SetName("start_summer_definition")
            End If
        End If
    End Sub

    Private Sub ucrChkTemOccu_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTemOccu.ControlValueChanged
        AddRemoveStatustmax()
        AddRemoverdoFunctions()
        If rdoTemperature.Checked Then
            If ucrChkTemOccu.Checked Then
                clsCombinationSubCalcListSummerFunction.AddParameter("sub3", clsRFunctionParameter:=clsCalcSummerStatusFunction, bIncludeArgumentName:=False, iPosition:=2)
                clsListSubCalcSummerFunction.AddParameter("sub3", clsRFunctionParameter:=clsCalcSummerStatusFunction, bIncludeArgumentName:=False, iPosition:=2)
            Else
                clsCombinationSubCalcListSummerFunction.RemoveParameterByName("sub3")
                clsListSubCalcSummerFunction.RemoveParameterByName("sub3")
            End If
        End If
    End Sub

    Private Sub ucrChkTemDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTemDate.ControlValueChanged
        AddRemoverdoFunctions()
        AddRemoveStatustmax()
        If ucrChkTemDate.Checked Then
            clsCombinationSubCalcListSummerFunction.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartSummerDateFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsListSubCalc.AddParameter("sub2", clsRFunctionParameter:=clsCalcStartSummerDateFunction, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCombinationSubCalcListSummerFunction.RemoveParameterByName("sub2")
            clsListSubCalc.RemoveParameterByName("sub2")
        End If
    End Sub

    Private Sub ucrChkTemDay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTemDay.ControlValueChanged
        AddRemoveStatustmax()
        AddRemoverdoFunctions()
        If ucrChkTemDay.Checked Then
            clsCombinationSubCalcListSummerFunction.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOYSummerFunction, bIncludeArgumentName:=False, iPosition:=0)
            clsListSubCalc.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOYSummerFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCombinationSubCalcListSummerFunction.RemoveParameterByName("sub1")
            clsListSubCalc.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainfall.ControlContentsChanged, ucrInputNewDoyColumnName.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrInputThreshold.ControlContentsChanged, ucrChkTotalRainfall.ControlContentsChanged, ucrNudTROverDays.ControlContentsChanged, ucrPnlTRCalculateBy.ControlContentsChanged, ucrNudTRAmount.ControlContentsChanged, ucrNudTRPercentile.ControlContentsChanged, ucrChkAsDoy.ControlContentsChanged, ucrChkAsDate.ControlContentsChanged, ucrInputNewDateColumnName.ControlContentsChanged,
        ucrChkStatus.ControlContentsChanged, ucrInputNewStatusColumnName.ControlContentsChanged, ucrNudEvapo.ControlContentsChanged, ucrReceiverEvap.ControlContentsChanged, ucrSaveDefinitionTem.ControlContentsChanged, ucrSaveDefinition.ControlContentsChanged, ucrChkTemDay.ControlContentsChanged, ucrChkTemDate.ControlContentsChanged, ucrInputTextTemdate.ControlContentsChanged, ucrChkTemOccu.ControlContentsChanged, ucrInputTextTemOccu.ControlContentsChanged, ucrInputTextTempday.ControlContentsChanged, ucrNudTotalOverDays.ControlContentsChanged, ucrNudAmount.ControlContentsChanged, ucrReceiverTmin.ControlContentsChanged, ucrReceiverTmax.ControlContentsChanged
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
            clsVectorSummerFunction.AddParameter("x", ucrReceiverYear.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
            clsVectorWinterFunction.AddParameter("x", ucrReceiverYear.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
            If Not ucrReceiverStation.IsEmpty Then
                clsVectorFunction.AddParameter("y", ucrReceiverStation.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
                clsVectorSummerFunction.AddParameter("y", ucrReceiverStation.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
                clsVectorWinterFunction.AddParameter("y", ucrReceiverStation.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsVectorFunction.RemoveParameterByName("y")
                clsVectorSummerFunction.RemoveParameterByName("y")
                clsVectorWinterFunction.RemoveParameterByName("y")
            End If
            clsGetlinkeddataFunction.AddParameter("link_cols", clsRFunctionParameter:=clsVectorFunction, iPosition:=1)
            clsGetlinkeddataSummerFunction.AddParameter("link_cols", clsRFunctionParameter:=clsVectorSummerFunction, iPosition:=1)
            clsDefineAsClimatic.AddParameter("key_col_names", clsRFunctionParameter:=clsVectorFunction, iPosition:=1)
            clsDefineAsClimaticSummerFunction.AddParameter("key_col_names", clsRFunctionParameter:=clsVectorSummerFunction, iPosition:=1)
            clsGetlinkeddataWinterFunction.AddParameter("link_cols", clsRFunctionParameter:=clsVectorSummerFunction, iPosition:=1)
            clsDefineAsClimaticWinterFunction.AddParameter("key_col_names", clsRFunctionParameter:=clsVectorSummerFunction, iPosition:=1)
        Else
            clsGetlinkeddataFunction.RemoveParameterByName("link_cols")
            clsGetlinkeddataSummerFunction.RemoveParameterByName("link_cols")
            clsVectorFunction.RemoveParameterByName("x")
            clsVectorSummerFunction.RemoveParameterByName("x")
            clsGetlinkeddataWinterFunction.RemoveParameterByName("link_cols")
            clsVectorWinterFunction.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub AddSaveDefinitionCodes()
        If rdoRain.Checked Then
            If ucrSaveDefinition.ucrChkSave.Checked Then
                ucrBase.clsRsyntax.AddToAfterCodes(clsGetStartRainsDefinitionsFunction, iPosition:=10)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetStartRainsDefinitionsFunction)
            End If
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetStartWinterDefinitionsFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetStartsummerDefinitionsFunction)
        Else
            If rdoSummer.Checked Then
                If ucrSaveDefinitionTem.ucrChkSave.Checked Then
                    ucrBase.clsRsyntax.AddToAfterCodes(clsGetStartsummerDefinitionsFunction, iPosition:=10)
                Else
                    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetStartsummerDefinitionsFunction)
                End If
            Else
                If ucrSaveDefinitionwinter.ucrChkSave.Checked Then
                    ucrBase.clsRsyntax.AddToAfterCodes(clsGetStartWinterDefinitionsFunction, iPosition:=10)
                Else
                    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetStartWinterDefinitionsFunction)
                End If
            End If
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetStartRainsDefinitionsFunction)
        End If
        TestOKEnabled()
    End Sub

    Private Sub DialogueSize()
        grpRainParameters.Visible = True
        If rdoRain.Checked Then
            Me.Size = New Size(571, 672)
            Me.ucrBase.Location = New Point(14, 571)
            Me.grpRainParameters.Location = New Point(13, 255)
        Else
            Me.Size = New Size(441, 572)
            Me.grpTemDisplay.Location = New Size(13, 395)
            Me.grpWinter.Location = New Size(13, 395)
            Me.ucrSaveDefinitionTem.Location = New Point(13, 455)
            Me.ucrSaveDefinitionwinter.Location = New Point(13, 455)
            Me.ucrBase.Location = New Point(14, 492)
            Me.grpRainParameters.Location = New Point(13, 345)
            Me.lblAmount.Location = New Point(10, 315)
            Me.lblTotalOverDays.Location = New Point(156, 315)
            Me.ucrNudAmount.Location = New Point(63, 313)
            Me.ucrNudTotalOverDays.Location = New Point(228, 313)
        End If
    End Sub

    Private Sub ucrSaveDefinition_ControlContentChanged(ucrChangedControl As ucrCore) Handles ucrSaveDefinition.ControlValueChanged
        AddSaveDefinitionCodes()
    End Sub

    Private Sub ucrSaveDefinitionTem_ControlContentChanged(ucrChangedControl As ucrCore) Handles ucrSaveDefinitionTem.ControlValueChanged
        AddSaveDefinitionCodes()
        AddRemoveTotalOverDays()
    End Sub

    Private Sub ucrDefinitionAndTypeControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAsDoy.ControlValueChanged,
            ucrChkAsDate.ControlValueChanged, ucrChkStatus.ControlValueChanged, ucrInputNewDoyColumnName.ControlValueChanged,
            ucrInputNewDateColumnName.ControlValueChanged, ucrInputNewStatusColumnName.ControlValueChanged
        AddTypes()
        AddStartRainsDefinitionParams()
        AddRemoverdoFunctions()
    End Sub

    Private Sub ucrDefinitionSummerControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTemDay.ControlValueChanged,
            ucrChkTemDate.ControlValueChanged, ucrChkTemOccu.ControlValueChanged, ucrInputTextTempday.ControlValueChanged,
            ucrInputTextTemdate.ControlValueChanged, ucrInputTextTemOccu.ControlValueChanged
        AddSummerTypes()
        AddStartsummerDefinitionParams()
        AddRemoverdoFunctions()
    End Sub

    Private Sub ucrDefinitionWinterControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDayWinter.ControlValueChanged,
            ucrChkDateWinter.ControlValueChanged, ucrChkOccuWinter.ControlValueChanged, ucrInputDayWinter.ControlValueChanged,
            ucrInputDateWinter.ControlValueChanged, ucrInputOccuWinter.ControlValueChanged
        AddWinterTypes()
        AddStartWinterDefinitionParams()
        AddRemoveStatustmin()
        AddRemoverdoFunctions()
    End Sub

    Private Sub AddStartRainsDefinitionParams()
        AddParamOrNull(ucrChkAsDoy, ucrInputNewDoyColumnName, clsGetStartRainsDefinitionsFunction, "start_rain", 2)
        AddParamOrNull(ucrChkAsDate, ucrInputNewDateColumnName, clsGetStartRainsDefinitionsFunction, "start_rain_date", 3)
        AddParamOrNull(ucrChkStatus, ucrInputNewStatusColumnName, clsGetStartRainsDefinitionsFunction, "start_rain_status", 4)
    End Sub

    Private Sub AddStartsummerDefinitionParams()
        AddParamOrNullTem(ucrChkTemDay, ucrInputTextTempday, clsGetStartsummerDefinitionsFunction, "start_summer", 2)
        AddParamOrNullTem(ucrChkTemDate, ucrInputTextTemdate, clsGetStartsummerDefinitionsFunction, "start_summer_date", 3)
        AddParamOrNullTem(ucrChkTemOccu, ucrInputTextTemOccu, clsGetStartsummerDefinitionsFunction, "start_summer_status", 4)
    End Sub

    Private Sub AddStartWinterDefinitionParams()
        AddParamOrNullTmin(ucrChkDayWinter, ucrInputDayWinter, clsGetStartWinterDefinitionsFunction, "start_winter", 2)
        AddParamOrNullTmin(ucrChkDateWinter, ucrInputDateWinter, clsGetStartWinterDefinitionsFunction, "start_winter_date", 3)
        AddParamOrNullTmin(ucrChkOccuWinter, ucrInputOccuWinter, clsGetStartWinterDefinitionsFunction, "start_winter_status", 4)
    End Sub

    Private Sub AddParamOrNull(ucrChk As ucrCheck, ucrInput As ucrInputTextBox, clsFuncName As RFunction, paramName As String, paramPos As Integer)
        If ucrChk.Checked Then
            If Not ucrInput.IsEmpty Then
                clsFuncName.AddParameter(paramName, Chr(34) & ucrInput.GetText() & Chr(34), iPosition:=paramPos)
            Else
                clsFuncName.AddParameter(paramName, "NULL", iPosition:=paramPos)
            End If
        Else
            clsFuncName.AddParameter(paramName, "NULL", iPosition:=paramPos)
        End If
    End Sub

    Private Sub AddRemoveVectorConcatParam(ucrChk As ucrCheck, ucrInput As ucrInputTextBox, paramName As String, paramPos As Integer)
        If ucrChk.Checked Then
            If Not ucrInput.IsEmpty Then
                clsVectorConcat2Function.AddParameter(paramName, Chr(34) & ucrInput.GetText() & Chr(34), iPosition:=paramPos)
            Else
                clsVectorConcat2Function.RemoveParameterByName(paramName)
            End If
        Else
            clsVectorConcat2Function.RemoveParameterByName(paramName)
        End If
    End Sub

    Private Sub AddParamOrNullTem(ucrChk As ucrCheck, ucrInput As ucrInputTextBox, clsFuncName As RFunction, paramName As String, paramPos As Integer)
        If ucrChk.Checked Then
            If Not ucrInput.IsEmpty Then
                clsFuncName.AddParameter(paramName, Chr(34) & ucrInput.GetText() & Chr(34), iPosition:=paramPos)
            Else
                clsFuncName.AddParameter(paramName, "NULL", iPosition:=paramPos)
            End If
        Else
            clsFuncName.AddParameter(paramName, "NULL", iPosition:=paramPos)
        End If
    End Sub

    Private Sub AddParamOrNullTmin(ucrChk As ucrCheck, ucrInput As ucrInputTextBox, clsFuncName As RFunction, paramName As String, paramPos As Integer)
        If ucrChk.Checked Then
            If Not ucrInput.IsEmpty Then
                clsFuncName.AddParameter(paramName, Chr(34) & ucrInput.GetText() & Chr(34), iPosition:=paramPos)
            Else
                clsFuncName.AddParameter(paramName, "NULL", iPosition:=paramPos)
            End If
        Else
            clsFuncName.AddParameter(paramName, "NULL", iPosition:=paramPos)
        End If
    End Sub

    Private Sub AddRemoveVectorConcatTemParam(ucrChk As ucrCheck, ucrInput As ucrInputTextBox, paramName As String, paramPos As Integer)
        If ucrChk.Checked Then
            If Not ucrInput.IsEmpty Then
                clsVectorConcat2SummerFunction.AddParameter(paramName, Chr(34) & ucrInput.GetText() & Chr(34), iPosition:=paramPos)
            Else
                clsVectorConcat2SummerFunction.RemoveParameterByName(paramName)
            End If
        Else
            clsVectorConcat2SummerFunction.RemoveParameterByName(paramName)
        End If
    End Sub

    Private Sub AddRemoveVectorConcatTminParam(ucrChk As ucrCheck, ucrInput As ucrInputTextBox, paramName As String, paramPos As Integer)
        If ucrChk.Checked Then
            If Not ucrInput.IsEmpty Then
                clsVectorConcat2WinterFunction.AddParameter(paramName, Chr(34) & ucrInput.GetText() & Chr(34), iPosition:=paramPos)
            Else
                clsVectorConcat2WinterFunction.RemoveParameterByName(paramName)
            End If
        Else
            clsVectorConcat2WinterFunction.RemoveParameterByName(paramName)
        End If
    End Sub

    Private Sub AddSummerTypes()
        If Not ucrReceiverStation.IsEmpty Then
            clsVectorConcat2SummerFunction.AddParameter("station", ucrReceiverStation.GetVariableNames(), iPosition:=0)
        Else
            clsVectorConcat2SummerFunction.RemoveParameterByName("station")
        End If
        clsVectorConcat2SummerFunction.AddParameter("year", ucrReceiverYear.GetVariableNames(), iPosition:=1)

        AddRemoveVectorConcatTemParam(ucrChkTemDay, ucrInputTextTemdate, "start_summer", 2)
        AddRemoveVectorConcatTemParam(ucrChkTemDate, ucrInputTextTemdate, "start_summer_date", 3)
        AddRemoveVectorConcatTemParam(ucrChkTemOccu, ucrInputTextTemOccu, "start_summer_status", 4)

        clsDefineAsClimaticSummerFunction.AddParameter("types", clsRFunctionParameter:=clsVectorConcat2SummerFunction, iPosition:=2)
    End Sub

    Private Sub AddWinterTypes()
        If Not ucrReceiverStation.IsEmpty Then
            clsVectorConcat2WinterFunction.AddParameter("station", ucrReceiverStation.GetVariableNames(), iPosition:=0)
        Else
            clsVectorConcat2WinterFunction.RemoveParameterByName("station")
        End If
        clsVectorConcat2WinterFunction.AddParameter("year", ucrReceiverYear.GetVariableNames(), iPosition:=1)

        AddRemoveVectorConcatTminParam(ucrChkDayWinter, ucrInputDateWinter, "start_winter", 2)
        AddRemoveVectorConcatTminParam(ucrChkDateWinter, ucrInputDateWinter, "start_winter_date", 3)
        AddRemoveVectorConcatTminParam(ucrChkOccuWinter, ucrInputOccuWinter, "start_winter_status", 4)

        clsDefineAsClimaticWinterFunction.AddParameter("types", clsRFunctionParameter:=clsVectorConcat2WinterFunction, iPosition:=2)
    End Sub

    Private Sub AddTypes()
        If Not ucrReceiverStation.IsEmpty Then
            clsVectorConcat2Function.AddParameter("station", ucrReceiverStation.GetVariableNames(), iPosition:=0)
        Else
            clsVectorConcat2Function.RemoveParameterByName("station")
        End If
        clsVectorConcat2Function.AddParameter("year", ucrReceiverYear.GetVariableNames(), iPosition:=1)

        AddRemoveVectorConcatParam(ucrChkAsDoy, ucrInputNewDoyColumnName, "start_rain", 2)
        AddRemoveVectorConcatParam(ucrChkAsDate, ucrInputNewDateColumnName, "start_rain_date", 3)
        AddRemoveVectorConcatParam(ucrChkStatus, ucrInputNewStatusColumnName, "start_rain_status", 4)

        clsDefineAsClimatic.AddParameter("types", clsRFunctionParameter:=clsVectorConcat2Function, iPosition:=2)
    End Sub

    Private Sub ucrPnlStart_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStart.ControlValueChanged
        AddRemovetreshold()
        ChangeFunctions()
        AddRemoveTotalOverDays()
        AddSaveDefinitionCodes()
        ChangeFunctions()
        DialogueSize()
        ChangeFunctions()
        AddRemoveStartStatus()
        AddRemoveStatustmax()
        AddRemoveStatustmin()
        ShowHideControls()
        AddRemoverdoFunctions()
        TestOKEnabled()
    End Sub

    Private Sub AddRemoveTotalOverDays()
        If Not ucrNudTotalOverDays.IsEmpty Then
            If rdoSummer.Checked Then
                clsRollingMeanSummerFunction.AddParameter("n", ucrNudTotalOverDays.GetText(), iPosition:=1)
                clsRollingMeanWinterFunction.RemoveParameterByName("n")
            Else
                clsRollingMeanWinterFunction.AddParameter("n", ucrNudTotalOverDays.GetText(), iPosition:=1)
                clsRollingMeanSummerFunction.RemoveParameterByName("n")
            End If
        Else
            clsRollingMeanSummerFunction.RemoveParameterByName("n")
            clsRollingMeanWinterFunction.RemoveParameterByName("n")
        End If
    End Sub

    Private Sub ucrNudTotalOverDays_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudTotalOverDays.ControlValueChanged
        AddRemoveTotalOverdays()
    End Sub

    Private Sub ucrInputTextTemday_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTextTempday.ControlValueChanged
        AddRemoveStatustmax()
    End Sub

    Private Sub ucrInputTextTemOccu_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTextTemOccu.ControlValueChanged
        AddRemoveStatustmax()
    End Sub

    Private Sub ucrNudAmount_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudAmount.ControlValueChanged
        AddRemovetreshold()
    End Sub

    Private Sub AddRemovetreshold()
        If Not ucrNudAmount.IsEmpty Then
            If rdoSummer.Checked Then
                clsGreaterOrEqualSummerOperator.AddParameter("threshold", ucrNudAmount.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                clsGreaterOrEqualWinterOperator.RemoveParameterByName("threshold")
            Else
                clsGreaterOrEqualWinterOperator.AddParameter("threshold", ucrNudAmount.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                clsGreaterOrEqualSummerOperator.RemoveParameterByName("threshold")
            End If
        Else
            clsGreaterOrEqualSummerOperator.RemoveParameterByName("threshold")
            clsGreaterOrEqualWinterOperator.RemoveParameterByName("threshold")
        End If
    End Sub

    Private Sub ucrReceiverTmax_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTmax.ControlValueChanged
        TotalTemCalcFrom()
        ShowHideControls()
        ChangeFunctions()
        AddRemoveTotalOverDays()
    End Sub

    Private Sub ucrReceiverTmin_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTmin.ControlValueChanged
        TotalTminCalcFrom()
        ShowHideControls()
        ChangeFunctions()
        AddRemoveTotalOverDays()
    End Sub

    Private Sub ucrPnlTem_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTem.ControlValueChanged
        TotalTminCalcFrom()
        AddRemoveStatustmax()
        AddRemoveStatustmin()
        ShowHideControls()
        ChangeFunctions()
        TotalTemCalcFrom()
        ChangeFunctions()
        AddRemoveTotalOverDays()
        AddSaveDefinitionCodes()
        AddRemoverdoFunctions()
    End Sub

    Private Sub AddRemoverdoFunctions()
        If rdoRain.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataSummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformSummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartSummerStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartCombine2SummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2SummerFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimaticSummerFunction)

            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataWinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformWinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartWinterStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartCombine2WinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2WinterFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimaticWinterFunction)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStatRainStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartRainCombine2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2Function)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimatic)
            If rdoSummer.Checked Then
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataWinterFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformWinterFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartWinterStatus2Function)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartCombine2WinterFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2WinterFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimaticWinterFunction)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetlinkeddataSummerFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsCalculatedListformSummerFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartSummerStatus2Function)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsStartCombine2SummerFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRunStartStatus2SummerFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDefineAsClimaticSummerFunction)
            End If
        End If
    End Sub

    Private Sub ucrChkOccuWinter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOccuWinter.ControlValueChanged, ucrChkDayWinter.ControlValueChanged, ucrChkDateWinter.ControlValueChanged
        AddRemoveStatustmin()
        AddRemoverdoFunctions()
        If ucrChkOccuWinter.Checked Then
            clsCombinationSubCalcListWinterFunction.AddParameter("sub3", clsRFunctionParameter:=clsCalcWinterStatusFunction, bIncludeArgumentName:=False, iPosition:=2)
            clsListSubCalcWinterFunction.AddParameter("sub3", clsRFunctionParameter:=clsCalcWinterStatusFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsCombinationSubCalcListWinterFunction.RemoveParameterByName("sub3")
            clsListSubCalcWinterFunction.RemoveParameterByName("sub3")
        End If
        If ucrChkTemDay.Checked Then
            clsCombinationSubCalcListWinterFunction.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOYWinterFunction, bIncludeArgumentName:=False, iPosition:=0)
            clsListSubCalcWinterFunction.AddParameter("sub1", clsRFunctionParameter:=clsCalcStartDOYWinterFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCombinationSubCalcListWinterFunction.RemoveParameterByName("sub1")
            clsListSubCalcWinterFunction.RemoveParameterByName("sub1")
        End If
    End Sub

    Private Sub ucrSaveDefinitionwinter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveDefinitionwinter.ControlValueChanged
        AddSaveDefinitionCodes()
    End Sub
End Class


