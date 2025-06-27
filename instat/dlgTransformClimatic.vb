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

Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsRTransform, clsAsNumericFunction, clsWaterBalanceFunction, clsOverallTransformFunction, clsTransformManipulationsFunc, clsGroupByYear, clsGroupByStation, clsReplaceNAasElement, clsRTransformCountSpellSub As New RFunction
    Private clsTransformCheck As New RFunction

    Private bDialogJustShown As Boolean = False
    'dummy
    Private clsDummyFunction As New RFunction
    'Cumulative
    Private clsCumulativeSum, clsCumulativeMaximum, clsCumulativeMinimum As New RFunction

    'Moving
    Private clsRMovingFunction, clsRasterFuction As New RFunction

    'Count and Spells
    Private clsRRainday, clsRRaindayMatch, clsRCountFunction, clsRollConsecutiveSumFunction As New RFunction
    Private clsRRaindayAndOperator, clsRRaindayOrOperator, clsRRaindayUpperOperator, clsRRaindayLowerOperator As New ROperator
    Private clsGreaterThanOperator, clsLessThanOperator As New ROperator

    ' Water Balance Min
    Private clsEndSeasonWBMinCalc As New RFunction
    Private clsEndSeasonWBMinCalcSubCalcsList As New RFunction
    Private clsReduceWBMinFunction As New RFunction
    Private clsReduceWBMinFunction1 As New RFunction
    Private clsWBMinEvapOperator As New ROperator
    Private clsWBEvaporationMinFunction As New RFunction
    Private clsReduceWBMinFunction2 As New RFunction
    Private clsEndSeasonRainMinCalc As New RFunction
    Private clsPMinWBMinFunction As New RFunction
    Private clsWBMinTailFunction1 As New RFunction
    Private clsWBMinTailFunction As New RFunction
    Private clsWBMinTailFunction2 As New RFunction
    Private clsEndSeasonIsNaRain As New RFunction
    Private clsEndSeasonConditionsOperator As New ROperator
    Private clsEndSeasonCombinationCalc As New RFunction
    Private clsEndSeasonCombinationSubCalcList As New RFunction
    Private clsEndSeasonFirstDoySummaryCalc As New RFunction
    Private clsGroupByStationYearCalc As New RFunction
    Private clsDoyFilterOperator As New ROperator
    Private clsDayFromOperator As New ROperator
    Private clsDayToOperator As New ROperator
    Private clsDoyFilterCalcFromConvert As New RFunction
    Private clsDoyFilterCalcFromList As New RFunction
    Private clsEndSeasonConditionsFilterSubCalcsList As New RFunction
    Private clsEndSeasonWBCalc As New RFunction
    Private clsEndSeasonWBCalcSubCalcsList As New RFunction
    Private clsRoundFunction As New RFunction
    Private clsEndSeasonWBConditionOperator As New ROperator
    Private clsIfElseWBFunction As New RFunction
    Private clsWBOperator As New ROperator
    Private clsWBMinMaxOperator As New ROperator
    Private clsIfElseRainMaxFunction As New RFunction
    Private clsMinusMinOperator As New ROperator
    Private clsMinusMaxOperator As New ROperator
    Private clsEndSeasonRainMaxCalc As New RFunction
    Private clsWBMaxTailFunction2 As New RFunction
    Private clsWBMaxTailFunction As New RFunction
    Private clsGroupByStationCalc As New RFunction

    ' Water Balance max
    Private clsEndSeasonWBMaxCalc As New RFunction
    Private clsEndSeasonWBMaxCalcSubCalcsList As New RFunction
    Private clsReduceWBMaxFunction As New RFunction
    Private clsPMinWBMaxFunction As New RFunction
    Private clsReduceWBMaxFunction1 As New RFunction
    Private clsWBMaxEvapOperator As New ROperator
    Private clsPMaxFunction As New RFunction
    Private clsWBOperator1 As New ROperator
    Private clsWBMaxTailFunction1 As New RFunction
    Private clsReduceWBMaxFunction2 As New RFunction
    Private clsIfElseRainMinFunction As New RFunction
    Private clsDoyFilterCalc As New RFunction

    'Degree
    Private clsDiurnalRangeOperator, clsTMeanAddOperator, clsTMeanDivideOperator As New ROperator
    Private clsHeatingDegreeDiffOperator, clsHeatingDegreeLogicOperator, clsHeatingDegreeOperator As New ROperator
    Private clsGrowingDegreDiffOperator, clsGrowingDegreeLogicOperator, clsGrowingDegreeOperator As New ROperator
    Private clsModifiedMinfunction, clsDegreeMeanFunction, clsRDegreeListParameter As New RFunction
    Private clsModifiedDiffOperator, clsModifiedLogicOperator, clsModifiedGDDOperator As New ROperator
    Private clsLogicalRFunction, clsLogicalGDDRFunction, clsLogicalMgddRFunction As New RFunction
    Private clsMeanAddOperator, clsMeanDivideByOperator As New ROperator

    Private strCurrDataName As String = ""
    Private strRainDay As String = "rain_day"
    Private strRainMin As String = "rain_min"
    Private strRainMax As String = "rain_max"
    Private strWBMin As String = "wb_min"
    Private strWBMax As String = "wb_max"
    Private strWB As String = "wb"
    Private strEvapReplaceNA As String = "evap_NA_as_value"

    'TODO:This will be useful when we want to resize dialog at different instances!
    'Private iReceiverMaxY As Integer
    'Private iReceiverLabelMaxY As Integer

    Private Sub dlgTransformClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            'iReceiverMaxY = ucrReceiverData.Location.Y
            'iReceiverLabelMaxY = lblData.Location.Y
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
        SetAssignName()
        CheckGroupByYearEnabled()
        bDialogJustShown = True
    End Sub

    Private Sub InitialiseDialog()
        Dim dctInputSumPairs As New Dictionary(Of String, String)
        Dim dctInputPosition As New Dictionary(Of String, String)
        Dim dctInputCircularPosition As New Dictionary(Of String, String)
        Dim dctInputLowerSpell As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 358

        'Overall Panel
        ucrPnlTransform.AddRadioButton(rdoCumulative)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoMoving)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoMultSpells)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)
        ucrPnlTransform.AddRadioButton(rdoDegree)

        ucrPnlTransform.AddParameterValuesCondition(rdoCumulative, "checked", "cumsum")
        ucrPnlTransform.AddParameterValuesCondition(rdoCount, "checked", "rollapply")
        ucrPnlTransform.AddParameterValuesCondition(rdoMoving, "checked", "moving")
        ucrPnlTransform.AddParameterValuesCondition(rdoSpell, "checked", "spell")
        ucrPnlTransform.AddParameterValuesCondition(rdoMultSpells, "checked", "spells")
        ucrPnlTransform.AddParameterValuesCondition(rdoWaterBalance, "checked", "Reduce")
        ucrPnlTransform.AddParameterValuesCondition(rdoDegree, "checked", "degree")

        ucrPnlEvap.AddRadioButton(rdoEvapValue)
        ucrPnlEvap.AddRadioButton(rdoEvapVariable)
        ucrPnlEvap.AddParameterValuesCondition(rdoEvapValue, "evaporation.value", "value")
        ucrPnlEvap.AddParameterValuesCondition(rdoEvapVariable, "evaporation.value", "variable")

        ucrPnlDegree.AddRadioButton(rdoTMean)
        ucrPnlDegree.AddRadioButton(rdoHeatingDegreeDays)
        ucrPnlDegree.AddRadioButton(rdoGrowingDegreeDays)
        ucrPnlDegree.AddRadioButton(rdoDiurnalRange)
        ucrPnlDegree.AddRadioButton(rdoModifiedGDD)

        ucrPnlDegree.AddParameterValuesCondition(rdoModifiedGDD, "check", "mgdd")
        ucrPnlDegree.AddParameterValuesCondition(rdoDiurnalRange, "check", "diurnal")
        ucrPnlDegree.AddParameterValuesCondition(rdoTMean, "check", "mean")
        ucrPnlDegree.AddParameterValuesCondition(rdoHeatingDegreeDays, "check", "hdd")
        ucrPnlDegree.AddParameterValuesCondition(rdoGrowingDegreeDays, "check", "gdd")

        ttRdoRange.SetToolTip(rdoDiurnalRange, "Diurnal Range is the difference between Tmax And Tmin, (Tmax - Tmin)")
        ttRdoTMean.SetToolTip(rdoTMean, "Tmean is the average daily temperature, (Tmax + Tmin)/2")
        ttRdoHdd.SetToolTip(rdoHeatingDegreeDays, "Heating Degree Days. If the baseline = 15 degrees then HDD is (15 - tmean). HDD = 0 if tmean is more than 15.")
        ttRdoGdd.SetToolTip(rdoGrowingDegreeDays, "Growing (or Cooling) Degree Days. If the baseline = 15 degrees, then GDD = (tmean - 15), or 0 if tmean is less than 15")
        ttRdoMgdd.SetToolTip(rdoModifiedGDD, "Modified GDD is just GDD if tmean is less than the upper limit. If baseline = 15 degrees and limit = 30 degrees, then Modified GDD = 30 - 15 if tmean is more than 30 degrees.")

        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoMoving, "sub1", "instatCalculations::instat_calculation$new", False) ' clsRRainday
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCount, "sub1", "instatCalculations::instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoSpell, "sub1", "instatCalculations::instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoWaterBalance, "sub1", "instatCalculations::instat_calculation$new", False)

        ' Setting receivers
        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ' What is this used for? I don't think this requires a key.
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverData.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False
        ucrReceiverData.bAutoFill = True
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverData.strSelectorHeading = "Numerics"
        ucrReceiverData.SetIncludedDataTypes({"numeric"})
        ucrReceiverData.SetLinkedDisplayControl(lblData)

        ucrReceiverEvap.SetParameter(New RParameter("x", 0))
        ucrReceiverEvap.Selector = ucrSelectorTransform
        ucrReceiverEvap.SetParameterIsString()
        ucrReceiverEvap.bWithQuotes = False

        ucrReceiverTMin.Selector = ucrSelectorTransform
        ucrReceiverTMin.SetParameter(New RParameter("tmin", 1))
        ucrReceiverTMin.strSelectorHeading = "Numerics"
        ucrReceiverTMin.SetDataType("numeric")
        ucrReceiverTMin.SetClimaticType("temp_min")
        ucrReceiverTMin.bAutoFill = True
        ucrReceiverTMin.SetParameterIsRFunction()
        ucrReceiverTMin.SetLinkedDisplayControl(lblTMin)

        ucrReceiverTMax.Selector = ucrSelectorTransform
        ucrReceiverTMax.SetParameter(New RParameter("tmax", 0))
        ucrReceiverTMax.strSelectorHeading = "Numerics"
        ucrReceiverTMax.SetDataType("numeric")
        ucrReceiverTMax.SetClimaticType("temp_max")
        ucrReceiverTMax.bAutoFill = True
        ucrReceiverTMax.SetParameterIsRFunction()
        ucrReceiverTMax.SetLinkedDisplayControl(lblTMax)

        ucrReceiverTMean.Selector = ucrSelectorTransform
        ucrReceiverTMean.SetParameter(New RParameter("tmean", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTMean.strSelectorHeading = "Numerics"
        ucrReceiverTMean.SetDataType("numeric")
        ucrReceiverTMean.SetParameterIsRFunction()
        ucrReceiverTMean.SetLinkedDisplayControl(lblTMean)

        ucrChkGroupByYear.SetText("Calculate by Year")

        'Cumulative
        ucrInputCumulative.AddItems({"Sum", "Maximum", "Minimum"})
        ucrInputCumulative.SetDropDownStyleAsNonEditable()

        ' Moving
        ucrInputSum.SetParameter(New RParameter("FUN", 2))
        dctInputSumPairs.Add("Sum", "sum")
        dctInputSumPairs.Add("Maximum", "max")
        dctInputSumPairs.Add("Minimum", "min")
        dctInputSumPairs.Add("Mean", "(mean)")
        dctInputSumPairs.Add("Median", "median")
        ucrInputSum.SetItems(dctInputSumPairs)
        ucrInputSum.SetDropDownStyleAsNonEditable()
        ucrInputSum.SetLinkedDisplayControl(lblSumOver)

        ucrInputPosition.SetParameter(New RParameter("align", 4))
        dctInputPosition.Add("Right", Chr(39) & "right" & Chr(39))
        dctInputPosition.Add("Centred", Chr(39) & "center" & Chr(39))
        dctInputPosition.Add("Left", Chr(39) & "left" & Chr(39))
        ucrInputPosition.SetItems(dctInputPosition)
        ucrInputPosition.SetDropDownStyleAsNonEditable()

        ucrInputCircularPosition.SetParameter(New RParameter("type", 3))
        dctInputCircularPosition.Add("Right", Chr(39) & "to" & Chr(39))
        dctInputCircularPosition.Add("Centred", Chr(39) & "around" & Chr(39))
        dctInputCircularPosition.Add("Left", Chr(39) & "from" & Chr(39))
        ucrInputCircularPosition.SetItems(dctInputCircularPosition)
        ucrInputCircularPosition.SetDropDownStyleAsNonEditable()

        ucrNudSumOver.SetParameter(New RParameter("width", 1))
        ucrNudSumOver.SetMinMax(1, 366)
        ucrNudSumOver.Increment = 1
        ucrNudSumOver.SetLinkedDisplayControl(lblSumRows)

        ucrChkCircular.SetParameter(New RParameter("circular", 4))
        ucrChkCircular.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCircular.SetText("Circular")
        ucrChkCircular.SetLinkedDisplayControl(lblPosition)

        ucrChkWB.AddParameterPresentCondition(True, "WB_evap", True)
        ucrChkWB.AddParameterPresentCondition(False, "WB_evap", False)
        ucrChkWB.SetText("Reducing")

        ucrNudWB.SetParameter(New RParameter("WB_evap_value", 2, False))
        ucrNudWB.SetMinMax(0, 1)
        ucrNudWB.Increment = 0.01
        ucrNudWB.DecimalPlaces = 2

        ' Count
        ucrNudCountOver.SetParameter(New RParameter("width", 1))
        ucrNudCountOver.SetMinMax(1, 366)
        ucrNudCountOver.Increment = 1
        ucrNudCountOver.SetLinkedDisplayControl(lblCountOver)

        ' Count and Spell
        ucrInputCondition.SetItems({"<=", "Between", ">=", "Outer"})
        ucrInputCondition.SetDropDownStyleAsNonEditable()

        ucrInputSpellLower.SetParameter(New RParameter("min", 1))
        dctInputLowerSpell.Add("0.85", "0.85")
        dctInputLowerSpell.Add("0", "0")
        dctInputLowerSpell.Add("2.45", "2.45")
        dctInputLowerSpell.Add("4.85", "4.85")
        dctInputLowerSpell.Add("9.85", "9.85")
        dctInputLowerSpell.Add("24.85", "24.85")
        ucrInputSpellLower.SetItems(dctInputLowerSpell)
        ucrInputSpellLower.AddQuotesIfUnrecognised = False
        ucrInputSpellLower.SetLinkedDisplayControl(lblCondition)
        ucrInputSpellLower.SetRDefault("0.85")

        ucrInputSpellUpper.SetParameter(New RParameter("max", 1))
        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.AddQuotesIfUnrecognised = False

        ' mult Spells 
        ucrNudMultSpells.SetParameter(New RParameter("width", 1))
        ucrNudMultSpells.SetMinMax(1, 21)
        ucrNudMultSpells.Increment = 1
        ucrNudMultSpells.SetLinkedDisplayControl(lblRowsMultSpells)

        ' Water Balance
        ucrNudWBCapacity.SetParameter(New RParameter("yes", 1))
        ucrNudWBCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudWBCapacity.Increment = 10
        ucrNudWBCapacity.SetLinkedDisplayControl(lblWBCapacity)

        ucrInputEvaporation.SetParameter(New RParameter("value", 1, bNewIncludeArgumentName:=False))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False
        ucrInputEvaporation.SetRDefault("5")

        'Degree
        ucrChkUseMaxMin.SetText("Use Max and Min")
        ucrChkUseMaxMin.AddToLinkedControls({ucrReceiverTMin, ucrReceiverTMax}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkUseMaxMin.AddToLinkedControls(ucrReceiverTMean, {False}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudHDD.SetParameter(New RParameter("baseline", 0, bNewIncludeArgumentName:=False))
        ucrNudHDD.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudHDD.Increment = 0.1
        ucrNudHDD.DecimalPlaces = 1
        ucrNudHDD.SetLinkedDisplayControl(lblBaselineHDD)

        ucrNudGDD.SetParameter(New RParameter("baseline", 1, bNewIncludeArgumentName:=False))
        ucrNudGDD.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudGDD.Increment = 0.1
        ucrNudGDD.DecimalPlaces = 1
        ucrNudGDD.SetLinkedDisplayControl(lblBaselineGDD)

        ucrNudMgdd.SetParameter(New RParameter("baseline", 1, bNewIncludeArgumentName:=False))
        ucrNudMgdd.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudMgdd.Increment = 0.1
        ucrNudMgdd.DecimalPlaces = 1
        ucrNudMgdd.SetLinkedDisplayControl(lblBaselineMgdd)

        ucrNudLimit.SetParameter(New RParameter("limit", 0, bNewIncludeArgumentName:=False))
        ucrNudLimit.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudLimit.Increment = 0.1
        ucrNudLimit.DecimalPlaces = 1
        ucrNudLimit.SetLinkedDisplayControl(lblLimit)

        'save control 
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorTransform.ucrAvailableDataFrames)
        ucrSaveColumn.SetPositionParametersDirectly(False, "result_name")
        ucrSaveColumn.SetLabelText("New Column Name:")
        'makes the ucrSave control to position new column after selected column
        ucrSaveColumn.setLinkedReceiver(ucrReceiverData)

        ucrPnlEvap.AddToLinkedControls(ucrInputEvaporation, {rdoEvapValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEvap.AddToLinkedControls(ucrReceiverEvap, {rdoEvapVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEvap.SetLinkedDisplayControl(lblWBEvaporation)

        ucrPnlDegree.AddToLinkedControls(ucrNudGDD, {rdoGrowingDegreeDays}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=15.0)
        ucrPnlDegree.AddToLinkedControls(ucrNudMgdd, {rdoModifiedGDD}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=15.0)
        ucrPnlDegree.AddToLinkedControls(ucrNudHDD, {rdoHeatingDegreeDays}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=15.0)
        ucrPnlDegree.AddToLinkedControls(ucrNudLimit, {rdoModifiedGDD}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30.0)

        ucrChkWB.AddToLinkedControls(ucrNudWB, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.5)

        ucrPnlTransform.AddToLinkedControls({ucrInputCumulative}, {rdoCumulative}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Sum")
        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlTransform.AddToLinkedControls({ucrInputCondition}, {rdoCount, rdoSpell, rdoMultSpells}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=">=")
        ucrPnlTransform.AddToLinkedControls(ucrInputSum, {rdoMoving}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudSumOver, {rdoMoving}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrChkCircular, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudMultSpells, {rdoMultSpells}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=21)
        ucrPnlTransform.AddToLinkedControls(ucrPnlEvap, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudWBCapacity, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=100)
        ucrPnlTransform.AddToLinkedControls(ucrChkGroupByYear, {rdoCount, rdoMoving, rdoSpell, rdoMultSpells, rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrReceiverYear, ucrReceiverData, ucrChkOptions}, {rdoCumulative, rdoCount, rdoMoving, rdoMultSpells, rdoSpell, rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrChkUseMaxMin, ucrPnlDegree}, {rdoDegree}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrChkWB}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCircular.AddToLinkedControls(ucrInputCircularPosition, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCircular.AddToLinkedControls(ucrInputPosition, {False}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputCondition.AddToLinkedControls(ucrInputSpellUpper, {"<=", "Between", "Outer"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrInputCondition.AddToLinkedControls(ucrInputSpellLower, {"Between", "Outer", ">="}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        'Temporary fix: ucrChkOptions is only used in linking
        ucrChkOptions.SetLinkedDisplayControl(grpTransform)
        ucrPnlDegree.SetLinkedDisplayControl(grpDegree)
    End Sub

    Private Sub SetDefaults()
        clsRTransform = New RFunction
        clsOverallTransformFunction = New RFunction
        clsWaterBalanceFunction = New RFunction
        clsTransformManipulationsFunc = New RFunction
        clsRTransformCountSpellSub = New RFunction

        clsDummyFunction = New RFunction

        clsCumulativeSum = New RFunction
        clsCumulativeMaximum = New RFunction
        clsCumulativeMinimum = New RFunction

        clsRMovingFunction = New RFunction
        clsRasterFuction = New RFunction
        clsReplaceNAasElement = New RFunction
        clsRCountFunction = New RFunction
        clsRRaindayMatch = New RFunction
        clsRRaindayAndOperator = New ROperator
        clsRRaindayOrOperator = New ROperator
        clsRRaindayUpperOperator = New ROperator
        clsRRaindayLowerOperator = New ROperator

        clsDiurnalRangeOperator = New ROperator
        clsTMeanAddOperator = New ROperator
        clsTMeanDivideOperator = New ROperator
        clsHeatingDegreeDiffOperator = New ROperator
        clsHeatingDegreeLogicOperator = New ROperator
        clsHeatingDegreeOperator = New ROperator
        clsGrowingDegreDiffOperator = New ROperator
        clsGrowingDegreeLogicOperator = New ROperator
        clsGrowingDegreeOperator = New ROperator
        clsModifiedMinfunction = New RFunction
        clsModifiedDiffOperator = New ROperator
        clsModifiedLogicOperator = New ROperator
        clsModifiedGDDOperator = New ROperator
        clsLogicalRFunction = New RFunction
        clsLogicalGDDRFunction = New RFunction
        clsLogicalMgddRFunction = New RFunction
        clsMeanAddOperator = New ROperator
        clsMeanDivideByOperator = New ROperator
        clsDegreeMeanFunction = New RFunction
        clsRDegreeListParameter = New RFunction

        clsGreaterThanOperator.Clear()
        clsLessThanOperator.Clear()

        ucrSelectorTransform.Reset()
        ucrReceiverData.SetMeAsReceiver()

        clsEndSeasonFirstDoySummaryCalc.Clear()

        clsGroupByStationYearCalc.Clear()
        clsGroupByStationCalc.Clear()
        clsEndSeasonWBCalc.Clear()

        '   Water Balance min
        clsEndSeasonRainMinCalc.Clear()
        clsEndSeasonWBMinCalc.Clear()
        clsEndSeasonWBMinCalcSubCalcsList.Clear()
        clsReduceWBMinFunction.Clear()
        clsReduceWBMinFunction1.Clear()
        clsWBMinEvapOperator.Clear()
        clsWBEvaporationMinFunction.Clear()
        clsPMaxFunction.Clear()
        clsPMinWBMinFunction.Clear()
        clsWBMinTailFunction.Clear()
        clsWBMinTailFunction1.Clear()
        clsWBMinTailFunction2.Clear()
        clsIfElseRainMinFunction.Clear()
        clsEndSeasonConditionsFilterSubCalcsList.Clear()
        clsEndSeasonWBConditionOperator.Clear()
        clsIfElseWBFunction.Clear()
        clsRoundFunction.Clear()
        clsWBMinMaxOperator.Clear()
        clsEndSeasonRainMaxCalc.Clear()
        clsWBMaxTailFunction2.Clear()
        clsWBMaxTailFunction.Clear()

        '   Water Balance max
        clsEndSeasonWBMaxCalc.Clear()
        clsEndSeasonWBMaxCalcSubCalcsList.Clear()
        clsReduceWBMaxFunction.Clear()
        clsReduceWBMaxFunction1.Clear()
        clsWBMaxEvapOperator.Clear()
        clsWBOperator1.Clear()
        clsWBMaxTailFunction1.Clear()
        clsPMinWBMaxFunction.Clear()
        clsEndSeasonWBCalcSubCalcsList.Clear()
        clsReduceWBMaxFunction2.Clear()
        clsReduceWBMinFunction2.Clear()
        clsEndSeasonConditionsOperator.Clear()
        clsEndSeasonCombinationCalc.Clear()
        clsDoyFilterCalc.Clear()
        clsDoyFilterOperator.Clear()
        clsDayFromOperator.Clear()
        clsDayToOperator.Clear()
        clsDoyFilterCalcFromConvert.Clear()
        clsDoyFilterCalcFromList.Clear()

        ' Count and Spells: Rainday
        clsRRainday.SetRCommand("instatCalculations::instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRRainday.AddParameter("function_exp", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=1)
        clsRRainday.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsRRainday.SetAssignTo("rain_day")

        clsRRaindayMatch.SetRCommand("match")
        clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator)
        clsRRaindayMatch.AddParameter("table", "1", iPosition:=1)
        clsRRaindayMatch.AddParameter("nomatch", "0", iPosition:=2)
        clsRRaindayMatch.bToScriptAsRString = True

        clsRRaindayAndOperator.bToScriptAsRString = True
        clsRRaindayAndOperator.SetOperation("&")
        clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        clsRRaindayUpperOperator.SetOperation("<=")
        clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=1)
        clsRRaindayLowerOperator.SetOperation(">=")

        clsRRaindayOrOperator.SetOperation("|")
        clsRRaindayOrOperator.AddParameter("upper", clsROperatorParameter:=clsGreaterThanOperator, iPosition:=0)
        clsGreaterThanOperator.SetOperation(">")
        clsRRaindayOrOperator.AddParameter("lower", clsROperatorParameter:=clsLessThanOperator, iPosition:=1)
        clsLessThanOperator.SetOperation("<")

        'Cumulative
        clsCumulativeSum.bToScriptAsRString = True
        clsCumulativeSum.SetRCommand("cumsum")

        clsCumulativeMaximum.bToScriptAsRString = True
        clsCumulativeMaximum.SetRCommand("cummax")

        clsCumulativeMinimum.bToScriptAsRString = True
        clsCumulativeMinimum.SetRCommand("cummin")

        ' Count
        clsRCountFunction.bToScriptAsRString = True
        clsRCountFunction.SetPackageName("zoo")
        clsRCountFunction.SetRCommand("rollapply")
        clsRCountFunction.AddParameter("data", strRainDay, iPosition:=0)
        clsRCountFunction.AddParameter("width", 1, iPosition:=1)
        clsRCountFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)
        clsRCountFunction.AddParameter("fill", "NA", iPosition:=5)
        clsRCountFunction.AddParameter("FUN", "sum", iPosition:=2)

        ' Spell
        ' this is run as a string Chr(34) & "cumsum(" & strRainDay & ")-cummax((" & strRainDay & "==0)*cumsum(" & strRainDay & "))" & Chr(34))

        'Multiple Spells 
        'zoo::rollapply(data = dodoma$Rain, width = 30, FUN = max_consecutive_sum, fill = NA, align="left")
        clsRollConsecutiveSumFunction.bToScriptAsRString = True
        clsRollConsecutiveSumFunction.SetPackageName("zoo")
        clsRollConsecutiveSumFunction.SetRCommand("rollapply")
        clsRollConsecutiveSumFunction.AddParameter("align", Chr(39) & "left" & Chr(39))
        clsRollConsecutiveSumFunction.AddParameter("width", 21, iPosition:=1)
        clsRollConsecutiveSumFunction.AddParameter("FUN", "instatExtras::max_consecutive_sum")
        clsRollConsecutiveSumFunction.AddParameter("fill", "NA")
        clsRollConsecutiveSumFunction.AddParameter("data", strRainDay)

        ' Moving
        clsRMovingFunction.SetPackageName("zoo")
        clsRMovingFunction.SetRCommand("rollapply")
        clsRMovingFunction.AddParameter("width", 3, iPosition:=1)
        clsRMovingFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsRMovingFunction.AddParameter("fill", "NA", iPosition:=3)
        clsRMovingFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)
        clsRMovingFunction.bToScriptAsRString = True

        clsRasterFuction.SetPackageName("raster")
        clsRasterFuction.SetRCommand("movingFun")
        clsRasterFuction.AddParameter("n", 3, iPosition:=1)
        clsRasterFuction.AddParameter("type", Chr(39) & "to" & Chr(39), iPosition:=3)
        clsRasterFuction.AddParameter("circular", "FALSE", iPosition:=4)
        clsRasterFuction.AddParameter("na.rm", "TRUE", iPosition:=5)
        clsRasterFuction.bToScriptAsRString = True

        clsGroupByStationCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsGroupByStationCalc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationCalc.SetAssignTo("grouping_by_station")

        clsGroupByStationYearCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsGroupByStationYearCalc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStationYearCalc.SetAssignTo("grouping_by_station_year")

        clsEndSeasonCombinationSubCalcList.SetRCommand("list")
        clsEndSeasonCombinationSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonFirstDoySummaryCalc, bIncludeArgumentName:=False, iPosition:=0)

        clsDoyFilterOperator.SetOperation("&")
        clsDoyFilterOperator.AddParameter("from_operator", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDoyFilterOperator.AddParameter("to_operator", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDoyFilterOperator.bBrackets = False
        clsDoyFilterOperator.bToScriptAsRString = True

        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)

        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)

        clsDoyFilterCalcFromConvert.SetPackageName("databook")
        clsDoyFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDoyFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDoyFilterCalcFromList, iPosition:=0)

        clsDoyFilterCalcFromList.SetRCommand("list")

        clsEndSeasonIsNaRain.SetRCommand("is.na")

        clsEndSeasonConditionsFilterSubCalcsList.SetRCommand("list")
        clsEndSeasonConditionsFilterSubCalcsList.AddParameter("sub1", clsRFunctionParameter:=clsEndSeasonWBCalc, iPosition:=0, bIncludeArgumentName:=False)

        clsEndSeasonConditionsOperator.bToScriptAsRString = True
        clsEndSeasonConditionsOperator.SetOperation("|")
        clsEndSeasonConditionsOperator.AddParameter("0", clsROperatorParameter:=clsEndSeasonWBConditionOperator, iPosition:=0)
        clsEndSeasonConditionsOperator.AddParameter("1", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=1)

        clsEndSeasonWBConditionOperator.SetOperation("<=")
        clsEndSeasonWBConditionOperator.AddParameter("0", strWB, iPosition:=0)
        clsEndSeasonWBConditionOperator.AddParameter("1", "0.5", iPosition:=1)

        clsEndSeasonWBCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsEndSeasonWBCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBCalc.AddParameter("function_exp", clsRFunctionParameter:=clsRoundFunction, iPosition:=1)
        clsEndSeasonWBCalc.AddParameter("save", "2", iPosition:=2)
        clsEndSeasonWBCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBCalcSubCalcsList, iPosition:=5)
        clsEndSeasonWBCalc.SetAssignTo(strWB)

        clsIfElseWBFunction.SetRCommand("ifelse")
        clsIfElseWBFunction.AddParameter("test", clsROperatorParameter:=clsWBOperator, iPosition:=0)
        clsIfElseWBFunction.AddParameter("yes", "NA", iPosition:=1)
        clsIfElseWBFunction.AddParameter("no", strWBMin, iPosition:=2)

        clsRoundFunction.bToScriptAsRString = True
        clsRoundFunction.SetRCommand("round")
        clsRoundFunction.AddParameter("x", clsRFunctionParameter:=clsIfElseWBFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsRoundFunction.AddParameter("y", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsWBOperator.SetOperation("|")
        clsWBOperator.AddParameter("0", clsROperatorParameter:=clsWBMinMaxOperator, iPosition:=0)
        clsWBOperator.AddParameter("1", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=1)

        clsWBMinMaxOperator.SetOperation("!=")
        clsWBMinMaxOperator.AddParameter("0", strWBMin, iPosition:=0)
        clsWBMinMaxOperator.AddParameter("1", strWBMax, iPosition:=1)

        clsWBOperator1.SetOperation("-")
        clsWBOperator1.AddParameter("left", "..1 + ..2", iPosition:=0)
        clsWBOperator1.AddParameter("right", clsRFunctionParameter:=clsWBEvaporationMinFunction, iPosition:=1)
        clsWBOperator1.bSpaceAroundOperation = True
        clsWBOperator1.bBrackets = False

        clsWBEvaporationMinFunction.SetPackageName("instatClimatic")
        clsWBEvaporationMinFunction.SetRCommand("WB_evaporation")
        clsWBEvaporationMinFunction.AddParameter("water_balance", "..1", iPosition:=0, bIncludeArgumentName:=False)
        clsWBEvaporationMinFunction.AddParameter("y", "..2", iPosition:=4, bIncludeArgumentName:=False)

        clsPMaxFunction.SetRCommand("pmax")
        clsPMaxFunction.AddParameter("0", "..1 + ..2", iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxFunction.AddParameter("1", "0", bIncludeArgumentName:=False)

        clsIfElseRainMaxFunction.bToScriptAsRString = True
        clsIfElseRainMaxFunction.SetRCommand("ifelse")
        clsIfElseRainMaxFunction.AddParameter("test", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=0)
        clsIfElseRainMaxFunction.AddParameter("yes", 100, iPosition:=0)

        ' Water Balance min
        clsEndSeasonWBMinCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsEndSeasonWBMinCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction, iPosition:=1)
        clsEndSeasonWBMinCalc.AddParameter("result_name", Chr(34) & strWBMin & Chr(34), iPosition:=2)
        clsEndSeasonWBMinCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBMinCalcSubCalcsList, iPosition:=3)
        clsEndSeasonWBMinCalc.SetAssignTo(strWBMin)

        clsEndSeasonRainMinCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsEndSeasonRainMinCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonRainMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseRainMinFunction, iPosition:=1)
        clsEndSeasonRainMinCalc.AddParameter("result_name", Chr(34) & strRainMin & Chr(34), iPosition:=2)
        clsEndSeasonRainMinCalc.SetAssignTo(strRainMin)

        clsIfElseRainMinFunction.bToScriptAsRString = True
        clsIfElseRainMinFunction.SetRCommand("ifelse")
        clsIfElseRainMinFunction.AddParameter("test", clsRFunctionParameter:=clsEndSeasonIsNaRain, iPosition:=0)
        clsIfElseRainMinFunction.AddParameter("yes", "0", iPosition:=1)

        clsEndSeasonWBMinCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBMinCalcSubCalcsList.AddParameter("0", strRainMin, iPosition:=0, bIncludeArgumentName:=False)

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

        clsAsNumericFunction = New RFunction
        clsAsNumericFunction.SetRCommand("as.numeric")
        clsAsNumericFunction.AddParameter("x", ucrReceiverEvap.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)

        clsMinusMinOperator = New ROperator
        clsMinusMinOperator.SetOperation("-")
        clsMinusMinOperator.AddParameter("left", strRainMin, iPosition:=0, bIncludeArgumentName:=False)
        clsMinusMinOperator.AddParameter("right", clsRFunctionParameter:=clsAsNumericFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsWBMinTailFunction2.SetRCommand("tail")
        clsWBMinTailFunction2.AddParameter("x", clsROperatorParameter:=clsMinusMinOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsWBMinTailFunction2.AddParameter("n", "-1", iPosition:=1)

        clsPMinWBMinFunction.SetRCommand(" ~ pmin")

        clsEndSeasonWBCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBCalcSubCalcsList.AddParameter("0", strWBMin, iPosition:=0, bIncludeArgumentName:=False)
        clsEndSeasonWBCalcSubCalcsList.AddParameter("1", strWBMax, iPosition:=1, bIncludeArgumentName:=False)

        clsWBMinTailFunction.SetRCommand("tail")
        clsWBMinTailFunction.AddParameter("x", clsROperatorParameter:=clsWBMinEvapOperator, iPosition:=0)
        clsWBMinTailFunction.AddParameter("n", "-1", iPosition:=1)

        clsWBMinTailFunction1.SetRCommand("tail")
        clsWBMinTailFunction1.AddParameter("x", ucrReceiverEvap.GetVariableNames(False), iPosition:=0)
        clsWBMinTailFunction1.AddParameter("n", "-1", iPosition:=1)

        clsWBMinEvapOperator.SetOperation("-")
        clsWBMinEvapOperator.AddParameter("0", strRainMin, iPosition:=0)
        clsWBMinEvapOperator.AddParameter("value", "5", iPosition:=1)

        ' Water Balance max
        clsEndSeasonWBMaxCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsEndSeasonWBMaxCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction, iPosition:=1)
        clsEndSeasonWBMaxCalc.AddParameter("result_name", Chr(34) & strWBMax & Chr(34), iPosition:=2)
        clsEndSeasonWBMaxCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsEndSeasonWBMaxCalcSubCalcsList, iPosition:=3)
        clsEndSeasonWBMaxCalc.SetAssignTo(strWBMax)

        clsEndSeasonRainMaxCalc.SetRCommand("instatCalculations::instat_calculation$new")
        clsEndSeasonRainMaxCalc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsEndSeasonRainMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsIfElseRainMaxFunction, iPosition:=1)
        clsEndSeasonRainMaxCalc.AddParameter("result_name", Chr(34) & strRainMax & Chr(34), iPosition:=2)
        clsEndSeasonRainMaxCalc.SetAssignTo(strRainMax)

        clsEndSeasonWBMaxCalcSubCalcsList.SetRCommand("list")
        clsEndSeasonWBMaxCalcSubCalcsList.AddParameter("0", strRainMax, iPosition:=0, bIncludeArgumentName:=False)

        clsMinusMaxOperator = New ROperator
        clsMinusMaxOperator.SetOperation("-")
        clsMinusMaxOperator.AddParameter("left", strRainMax, iPosition:=0, bIncludeArgumentName:=False)
        clsMinusMaxOperator.AddParameter("right", clsRFunctionParameter:=clsAsNumericFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsWBMaxTailFunction2.SetRCommand("tail")
        clsWBMaxTailFunction2.AddParameter("x", clsROperatorParameter:=clsMinusMaxOperator, iPosition:=0)
        clsWBMaxTailFunction2.AddParameter("n", "-1", iPosition:=1)

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
        clsWBMaxTailFunction1.AddParameter("x", ucrReceiverEvap.GetVariableNames(False), iPosition:=0)
        clsWBMaxTailFunction1.AddParameter("n", "-1", iPosition:=1)

        clsWBMaxEvapOperator.SetOperation("-")
        clsWBMaxEvapOperator.AddParameter("0", strRainMax, iPosition:=0)
        clsWBMaxEvapOperator.AddParameter("value", "5", iPosition:=1)

        ' Degree
        clsDiurnalRangeOperator.SetOperation("-")
        clsDiurnalRangeOperator.bToScriptAsRString = True

        clsTMeanAddOperator.SetOperation("+")
        clsTMeanDivideOperator.SetOperation("/")
        clsTMeanDivideOperator.AddParameter("x", clsROperatorParameter:=clsTMeanAddOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsTMeanDivideOperator.AddParameter("y", 2, iPosition:=1, bIncludeArgumentName:=False)
        clsTMeanDivideOperator.bToScriptAsRString = True

        clsMeanAddOperator.SetOperation("+")
        clsMeanDivideByOperator.SetOperation("/")
        clsMeanDivideByOperator.AddParameter("x", clsROperatorParameter:=clsMeanAddOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsMeanDivideByOperator.AddParameter("y", 2, iPosition:=1, bIncludeArgumentName:=False)
        clsMeanDivideByOperator.bToScriptAsRString = True
        clsMeanDivideByOperator.bBrackets = True

        clsDegreeMeanFunction.SetPackageName("instatCalculations")
        clsDegreeMeanFunction.SetRCommand("instat_calculation$new")
        clsDegreeMeanFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsDegreeMeanFunction.AddParameter("function_exp", clsROperatorParameter:=clsMeanDivideByOperator, iPosition:=2)
        clsDegreeMeanFunction.AddParameter("result_name", Chr(34) & "mean" & Chr(34), iPosition:=3)
        clsDegreeMeanFunction.SetAssignTo("mean_function")

        clsRDegreeListParameter.SetRCommand("list")
        clsRDegreeListParameter.AddParameter("x", clsRFunctionParameter:=clsDegreeMeanFunction, bIncludeArgumentName:=False)

        clsHeatingDegreeDiffOperator.SetOperation("-")
        clsHeatingDegreeDiffOperator.AddParameter("tmean", "tmean", iPosition:=1)

        clsHeatingDegreeLogicOperator.SetOperation("<")
        clsHeatingDegreeLogicOperator.AddParameter("tmean", "tmean", iPosition:=0)
        clsHeatingDegreeLogicOperator.AddParameter("baseline", "15", iPosition:=1)

        'This introduces brackets to the logic operator ie. (tmean < baseline)
        clsLogicalRFunction.SetRCommand("")
        clsLogicalRFunction.AddParameter("logical", clsROperatorParameter:=clsHeatingDegreeLogicOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsHeatingDegreeOperator.SetOperation("*")
        clsHeatingDegreeOperator.AddParameter("x", clsROperatorParameter:=clsHeatingDegreeDiffOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsHeatingDegreeOperator.AddParameter("y", clsRFunctionParameter:=clsLogicalRFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsHeatingDegreeOperator.bToScriptAsRString = True

        clsGrowingDegreDiffOperator.SetOperation("-")
        clsGrowingDegreDiffOperator.AddParameter("tmean", "tmean", iPosition:=0)
        clsGrowingDegreDiffOperator.AddParameter("baseline", "15", iPosition:=1)

        clsGrowingDegreeLogicOperator.SetOperation(">")
        clsGrowingDegreeLogicOperator.AddParameter("tmean", "tmean", iPosition:=0)
        clsGrowingDegreeLogicOperator.AddParameter("baseline", 15, iPosition:=1)

        'This introduces brackets to the logic operator ie. (tmean > baseline)
        clsLogicalGDDRFunction.SetRCommand("")
        clsLogicalGDDRFunction.AddParameter("logical", clsROperatorParameter:=clsGrowingDegreeLogicOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsGrowingDegreeOperator.SetOperation("*")
        clsGrowingDegreeOperator.AddParameter("x", clsROperatorParameter:=clsGrowingDegreDiffOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsGrowingDegreeOperator.AddParameter("y", clsRFunctionParameter:=clsLogicalGDDRFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsGrowingDegreeOperator.bToScriptAsRString = True

        clsModifiedMinfunction.SetRCommand("pmin")
        clsModifiedMinfunction.AddParameter("limit", 30, iPosition:=0, bIncludeArgumentName:=False)
        clsModifiedMinfunction.AddParameter("tmean", "tmean", iPosition:=1, bIncludeArgumentName:=False)

        clsModifiedDiffOperator.SetOperation("-")
        clsModifiedDiffOperator.AddParameter("x", clsRFunctionParameter:=clsModifiedMinfunction, iPosition:=0, bIncludeArgumentName:=False)
        clsModifiedDiffOperator.AddParameter("baseline", 15, iPosition:=1)

        clsModifiedLogicOperator.SetOperation(">")
        clsModifiedLogicOperator.AddParameter("tmean", "tmean", iPosition:=0)
        clsModifiedLogicOperator.AddParameter("baseline", 15, iPosition:=1)

        'This introduces brackets to the logic operator ie. (tmean > baseline)
        clsLogicalMgddRFunction.SetRCommand("")
        clsLogicalMgddRFunction.AddParameter("logical", clsROperatorParameter:=clsModifiedLogicOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsModifiedGDDOperator.SetOperation("*")
        clsModifiedGDDOperator.AddParameter("x", clsROperatorParameter:=clsModifiedDiffOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsModifiedGDDOperator.AddParameter("y", clsRFunctionParameter:=clsLogicalMgddRFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsModifiedGDDOperator.bToScriptAsRString = True

        clsDummyFunction.AddParameter("check", "diurnal", iPosition:=0)
        clsDummyFunction.AddParameter("evaporation.value", "value", iPosition:=1)
        clsDummyFunction.AddParameter("checked", "rollapply", iPosition:=2)

        ' Group options 
        clsGroupByYear.SetRCommand("instatCalculations::instat_calculation$new")
        clsGroupByYear.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByYear.AddParameter("result_name", Chr(34) & "group_by_year" & Chr(34), iPosition:=2)
        clsGroupByYear.SetAssignTo("group_by_year")

        clsGroupByStation.SetRCommand("instatCalculations::instat_calculation$new")
        clsGroupByStation.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStation.SetAssignTo("group_by_station")

        ' Overall Function
        clsRTransformCountSpellSub.SetRCommand("list")
        clsRTransformCountSpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False, iPosition:=0)

        clsTransformManipulationsFunc.SetRCommand("list")

        clsRTransform.SetRCommand("instatCalculations::instat_calculation$new")
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRTransform.AddParameter("result_name", Chr(34) & "count" & Chr(34), iPosition:=2)
        clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
        clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=5)
        clsRTransform.AddParameter("save", 2, iPosition:=6)
        clsRTransform.SetAssignTo("transform_calculation")

        clsTransformCheck = clsRTransform

        clsOverallTransformFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsOverallTransformFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform, iPosition:=0)
        clsOverallTransformFunction.AddParameter("display", "FALSE", iPosition:=1)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallTransformFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("x", 0, False), iAdditionalPairNo:=1)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsReplaceNAasElement, New RParameter("element", 0, False), iAdditionalPairNo:=2)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRRaindayUpperOperator, New RParameter("rain", 0), iAdditionalPairNo:=3)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRRaindayLowerOperator, New RParameter("rain", 0), iAdditionalPairNo:=4)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsIfElseRainMinFunction, New RParameter("no", 2), iAdditionalPairNo:=5)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=6)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=7)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsCumulativeSum, New RParameter("x", 0, False), iAdditionalPairNo:=8)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsCumulativeMaximum, New RParameter("x", 0, False), iAdditionalPairNo:=9)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsCumulativeMinimum, New RParameter("x", 0, False), iAdditionalPairNo:=10)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsEndSeasonIsNaRain, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsIfElseRainMaxFunction, New RParameter("no", 2), iAdditionalPairNo:=12)
        ucrNudSumOver.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("n", 1), iAdditionalPairNo:=1)
        ucrInputSum.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("fun", 2), iAdditionalPairNo:=1)
        ucrReceiverTMin.AddAdditionalCodeParameterPair(clsTMeanAddOperator, New RParameter("tmin", 1), iAdditionalPairNo:=1)
        ucrReceiverTMax.AddAdditionalCodeParameterPair(clsTMeanAddOperator, New RParameter("tmax", 0), iAdditionalPairNo:=1)
        ucrReceiverTMean.AddAdditionalCodeParameterPair(clsGrowingDegreDiffOperator, New RParameter("tmean", 0), iAdditionalPairNo:=1)
        ucrReceiverTMean.AddAdditionalCodeParameterPair(clsHeatingDegreeLogicOperator, New RParameter("tmean", 0), iAdditionalPairNo:=2)
        ucrReceiverTMean.AddAdditionalCodeParameterPair(clsGrowingDegreeLogicOperator, New RParameter("tmean", 0), iAdditionalPairNo:=3)
        ucrReceiverTMean.AddAdditionalCodeParameterPair(clsModifiedMinfunction, New RParameter("tmean", 1), iAdditionalPairNo:=4)
        ucrReceiverTMean.AddAdditionalCodeParameterPair(clsModifiedLogicOperator, New RParameter("tmean", 0), iAdditionalPairNo:=5)
        ucrNudHDD.AddAdditionalCodeParameterPair(clsHeatingDegreeLogicOperator, New RParameter("baseline", ucrNudHDD.GetText, 1), iAdditionalPairNo:=1)
        ucrNudGDD.AddAdditionalCodeParameterPair(clsGrowingDegreeLogicOperator, New RParameter("baseline", ucrNudGDD.GetText, 1), iAdditionalPairNo:=1)
        ucrNudMgdd.AddAdditionalCodeParameterPair(clsModifiedLogicOperator, New RParameter("baseline", ucrNudMgdd.GetText, 1), iAdditionalPairNo:=1)
        ucrReceiverTMax.AddAdditionalCodeParameterPair(clsMeanAddOperator, New RParameter("tmax", 0), iAdditionalPairNo:=2)
        ucrReceiverTMin.AddAdditionalCodeParameterPair(clsMeanAddOperator, New RParameter("tmin", 1), iAdditionalPairNo:=2)
        ucrInputEvaporation.AddAdditionalCodeParameterPair(clsWBMaxEvapOperator, New RParameter("value", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverEvap.AddAdditionalCodeParameterPair(clsWBMaxTailFunction1, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverEvap.AddAdditionalCodeParameterPair(clsAsNumericFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrSaveColumn.AddAdditionalCodeParameterPair(clsEndSeasonWBCalc, New RParameter("result_name", 2), iAdditionalPairNo:=1)

        ' Moving
        ucrNudSumOver.SetRCode(clsRMovingFunction, bReset)
        ucrInputSum.SetRCode(clsRMovingFunction, bReset)
        ucrInputPosition.SetRCode(clsRMovingFunction, bReset)
        ucrReceiverData.SetRCode(clsRMovingFunction, bReset)
        ucrInputCircularPosition.SetRCode(clsRasterFuction, bReset)
        ucrChkCircular.SetRCode(clsRasterFuction, bReset)

        'mult spells
        ucrNudMultSpells.SetRCode(clsRollConsecutiveSumFunction, bReset)

        ' Count
        ucrNudCountOver.SetRCode(clsRCountFunction, bReset)
        ucrInputSpellLower.SetRCode(clsLessThanOperator, bReset)
        ucrInputSpellUpper.SetRCode(clsRRaindayUpperOperator, bReset)

        ' Water Balance
        ucrReceiverEvap.SetRCode(clsWBMinTailFunction1, bReset)

        'Degree
        ucrReceiverTMin.SetRCode(clsDiurnalRangeOperator, bReset)
        ucrReceiverTMax.SetRCode(clsDiurnalRangeOperator, bReset)
        ucrReceiverTMean.SetRCode(clsHeatingDegreeDiffOperator, bReset)
        ucrNudHDD.SetRCode(clsHeatingDegreeDiffOperator, bReset)
        ucrNudGDD.SetRCode(clsGrowingDegreDiffOperator, bReset)
        ucrNudLimit.SetRCode(clsModifiedMinfunction, bReset)
        ucrNudMgdd.SetRCode(clsModifiedDiffOperator, bReset)
        ucrPnlDegree.SetRCode(clsDummyFunction, bReset)

        ucrSaveColumn.SetRCode(clsRTransform, bReset)
        If bReset Then
            ucrChkGroupByYear.SetRCode(clsTransformManipulationsFunc, bReset)
            ucrInputEvaporation.SetRCode(clsWBMinEvapOperator, bReset)
            ucrPnlEvap.SetRCode(clsDummyFunction, bReset)
            ucrPnlTransform.SetRCode(clsDummyFunction, bReset)
            ucrPnlDegree.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If rdoCount.Checked OrElse rdoCumulative.Checked OrElse rdoMoving.Checked _
                OrElse rdoMultSpells.Checked OrElse rdoSpell.Checked _
                OrElse rdoWaterBalance.Checked Then
            Dim betweenOuterOk As Boolean = Not ucrInputSpellUpper.IsEmpty _
                    AndAlso (
                        ((ucrInputCondition.GetText = "Between" OrElse ucrInputCondition.GetText = "Outer") _
                            AndAlso Not ucrInputSpellLower.IsEmpty) _
                        OrElse (ucrInputCondition.GetText = "<=") _
                        OrElse (ucrInputCondition.GetText = ">="))
            If Not ucrReceiverData.IsEmpty AndAlso ucrSaveColumn.IsComplete _
                    AndAlso ((rdoCount.Checked AndAlso ucrNudCountOver.GetText <> "" AndAlso betweenOuterOk) _
                        OrElse (rdoCumulative.Checked AndAlso Not ucrInputCumulative.IsEmpty) _
                        OrElse (rdoMoving.Checked AndAlso Not ucrInputSum.IsEmpty AndAlso ucrNudSumOver.GetText <> "") _
                        OrElse (rdoSpell.Checked AndAlso betweenOuterOk) _
                        OrElse (rdoMultSpells.Checked AndAlso ucrNudMultSpells.GetText <> "" AndAlso betweenOuterOk) _
                        OrElse (rdoWaterBalance.Checked AndAlso ucrNudWBCapacity.GetText <> "" _
                            AndAlso ((rdoEvapValue.Checked AndAlso Not ucrInputEvaporation.IsEmpty) _
                                OrElse (rdoEvapVariable.Checked AndAlso Not ucrReceiverEvap.IsEmpty)))) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoDegree.Checked Then
            If (ucrChkUseMaxMin.Checked AndAlso (ucrReceiverTMin.IsEmpty OrElse ucrReceiverTMax.IsEmpty)) OrElse
                (ucrChkUseMaxMin.Checked = False AndAlso ucrReceiverTMean.IsEmpty) OrElse Not ucrSaveColumn.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub InputConditionOptions()
        Select Case ucrInputCondition.GetText
            Case "<="
                clsRRaindayAndOperator.RemoveParameterByName("lower")
                clsRRaindayLowerOperator.RemoveParameterByName("min")
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=1)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
            Case "Outer"
                clsRRaindayOrOperator.AddParameter("upper", clsROperatorParameter:=clsGreaterThanOperator, iPosition:=0)
                clsRRaindayOrOperator.AddParameter("lower", clsROperatorParameter:=clsLessThanOperator, iPosition:=1)
                'These are a temporary fix so that "min" and "max" parameters can be updated from the controls properly
                clsLessThanOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsGreaterThanOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayOrOperator, iPosition:=0)
            Case ">="
                clsRRaindayAndOperator.RemoveParameterByName("upper")
                clsRRaindayUpperOperator.RemoveParameterByName("max")
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
        End Select
    End Sub

    Private Sub ucrPnlTransform_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlValueChanged, ucrPnlDegree.ControlValueChanged ', ucrPnlEvap.ControlValueChanged
        If rdoCumulative.Checked Then
            CumulativeFunctions()
            clsRTransform.RemoveParameterByName("sub_calculations")
            clsTransformCheck = clsRTransform
        ElseIf rdoCount.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRCountFunction, iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
            clsRTransform.RemoveParameterByName("calculated_from")
            clsTransformCheck = clsRTransform
        ElseIf rdoMoving.Checked Then
            RasterFunction()
            clsRTransform.RemoveParameterByName("sub_calculations")
            clsTransformCheck = clsRTransform
        ElseIf rdoSpell.Checked Then
            clsRTransform.AddParameter("function_exp", Chr(34) & "instatClimatic::spells(x = " & strRainDay & ")" & Chr(34), iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
            clsRTransform.RemoveParameterByName("calculated_from")
            clsTransformCheck = clsRTransform
        ElseIf rdoMultSpells.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRollConsecutiveSumFunction, iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
            clsRTransform.RemoveParameterByName("calculated_from")
            clsTransformCheck = clsRollConsecutiveSumFunction
        ElseIf rdoWaterBalance.Checked Then
            clsWaterBalanceFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
            clsWaterBalanceFunction.AddParameter("calc", strWB, iPosition:=0)
            clsWaterBalanceFunction.AddParameter("display", "FALSE", iPosition:=1)
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterBalanceFunction)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsEndSeasonRainMinCalc, iPosition:=0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsEndSeasonWBMinCalc, iPosition:=1)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsEndSeasonRainMaxCalc, iPosition:=2)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsEndSeasonWBMaxCalc, iPosition:=3)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsEndSeasonWBCalc, iPosition:=4)
            clsRTransform.RemoveParameterByName("sub_calculations")
            ReduceWaterBalance()
        ElseIf rdoDegree.Checked Then
            DegreeFunctions()
            clsTransformCheck = clsRTransform
        End If
        AddCalculate()
        AutoFill()
        SetAssignName()
        GroupByStation()
        GroupByYear()
        SetAsReceiver()
        ChangeFunctions()
        AddRemoveMeanOperator()
        ShowGroups()
        InputConditionOptions()
    End Sub

    Private Sub DegreeFunctions()
        If rdoDiurnalRange.Checked Then
            clsDummyFunction.AddParameter("checked", "diurnal", iPosition:=0)
            clsRTransform.AddParameter("function_exp", clsROperatorParameter:=clsDiurnalRangeOperator, iPosition:=1)
        ElseIf rdoTMean.Checked Then
            clsDummyFunction.AddParameter("checked", "mean", iPosition:=0)
            clsRTransform.AddParameter("function_exp", clsROperatorParameter:=clsTMeanDivideOperator, iPosition:=1)
        ElseIf rdoHeatingDegreeDays.Checked Then
            clsDummyFunction.AddParameter("checked", "hdd", iPosition:=0)
            clsRTransform.AddParameter("function_exp", clsROperatorParameter:=clsHeatingDegreeOperator, iPosition:=1)
        ElseIf rdoGrowingDegreeDays.Checked Then
            clsDummyFunction.AddParameter("checked", "gdd", iPosition:=0)
            clsRTransform.AddParameter("function_exp", clsROperatorParameter:=clsGrowingDegreeOperator, iPosition:=1)
        ElseIf rdoModifiedGDD.Checked Then
            clsDummyFunction.AddParameter("checked", "mgdd", iPosition:=0)
            clsRTransform.AddParameter("function_exp", clsROperatorParameter:=clsModifiedGDDOperator, iPosition:=1)
        End If
    End Sub
    Private Sub SetAssignName()
        If rdoCumulative.Checked Then
            CumulativeColNames()
        ElseIf rdoCount.Checked Then
            ucrSaveColumn.SetName("count")
        ElseIf rdoMoving.Checked Then
            MovingColNames()
        ElseIf rdoSpell.Checked Then
            ucrSaveColumn.SetName("spell")
        ElseIf rdoMultSpells.Checked Then
            ucrSaveColumn.SetName("spells")
        ElseIf rdoWaterBalance.Checked Then
            ucrSaveColumn.SetName("water")
        ElseIf rdoDegree.Checked Then
            If rdoDiurnalRange.Checked Then
                ucrSaveColumn.SetName("range")
            ElseIf rdoTMean.Checked Then
                ucrSaveColumn.SetName("tmean")
            ElseIf rdoHeatingDegreeDays.Checked Then
                ucrSaveColumn.SetName("hdd")
            ElseIf rdoGrowingDegreeDays.Checked Then
                ucrSaveColumn.SetName("gdd")
            ElseIf rdoModifiedGDD.Checked Then
                ucrSaveColumn.SetName("mgdd")
            End If
        End If
    End Sub

    Private Sub MovingColNames()
        Select Case ucrInputSum.GetText
            Case "Sum"
                ucrSaveColumn.SetName("moving_sum")
            Case "Maximum"
                ucrSaveColumn.SetName("moving_max")
            Case "Minimum"
                ucrSaveColumn.SetName("moving_min")
            Case "Mean"
                ucrSaveColumn.SetName("moving_mean")
            Case "Median"
                ucrSaveColumn.SetName("moving_median")
            Case Else
                ucrSaveColumn.SetName("moving")
        End Select
    End Sub

    Private Sub GroupByYear()
        If (rdoCount.Checked OrElse rdoMoving.Checked OrElse rdoSpell.Checked OrElse rdoMultSpells.Checked OrElse rdoWaterBalance.Checked) AndAlso Not ucrReceiverYear.IsEmpty Then
            If ucrChkGroupByYear.Enabled = True AndAlso ucrChkGroupByYear.Checked() Then
                clsGroupByYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
                clsTransformManipulationsFunc.AddParameter("group_by_year", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsGroupByYear.RemoveParameterByName("calculated_from")
                clsTransformManipulationsFunc.RemoveParameterByName("group_by_year")
            End If
        Else
            If rdoCumulative.Checked AndAlso Not ucrReceiverYear.IsEmpty Then
                clsGroupByYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
                clsTransformManipulationsFunc.AddParameter("group_by_year", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsGroupByYear.RemoveParameterByName("calculated_from")
                clsTransformManipulationsFunc.RemoveParameterByName("group_by_year")
            End If
        End If
    End Sub

    Private Sub CheckGroupByYearEnabled()
        If Not ucrReceiverYear.IsEmpty Then
            ucrChkGroupByYear.Enabled = True
        Else
            ucrChkGroupByYear.Enabled = False
            ucrChkGroupByYear.Checked = False
        End If

    End Sub

    Private Sub GroupByStation()
        If rdoDegree.Checked OrElse ucrReceiverStation.IsEmpty() Then
            clsGroupByStation.RemoveParameterByName("calculated_from")
            clsTransformManipulationsFunc.RemoveParameterByName("group_by_station")
        Else
            clsGroupByStation.AddParameter("calculated_from",
                                           "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")",
                                           iPosition:=3)
            clsTransformManipulationsFunc.AddParameter("group_by_station",
                                                       clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False,
                                                       iPosition:=0)
        End If
    End Sub

    Private Sub RainDays()
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")", iPosition:=3)
    End Sub

    Private Sub ucrSelectorTransform_ControlValueChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        RainDays()
        GroupByYear()
        GroupByStation()
        ReduceWaterBalance()
        ChangeFunctions()
        AddCalculate()
        AutoFill()
        RainfallChange()
    End Sub

    Private Sub ucrInputSpellLower_ControlValueChanged(ucrChangedControl As ucrCore)
        InputConditionOptions()
    End Sub

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged
        RainDays()
        ReduceWaterBalance()
        RainfallChange()
        AddCalculate()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByStation()
        ReduceWaterBalance()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByYear()
        CheckGroupByYearEnabled()
        ReduceWaterBalance()
    End Sub

    Private Sub ucrInputSum_ControlValueChanged(ucrchangedControl As ucrCore)
        MovingColNames()
    End Sub

    Private Sub ucrChkGroupByYear_ControlValueChanged(ucrChangedControl As ucrCore)
        GroupByYear()
        CheckGroupByYearEnabled()
        ReduceWaterBalance()
    End Sub

    Private Sub ucrInputEvaporation_ControlContentsChanged(ucrChangedControl As ucrCore)
        ReduceWaterBalance()
    End Sub

    Private Sub RasterFunction()
        If rdoMoving.Checked Then
            If ucrChkCircular.Checked Then
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRasterFuction, iPosition:=1)
            ElseIf Not ucrChkCircular.Checked Then
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRMovingFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrChkCircular_ControlValueChanged(ucrChangedControl As ucrCore)
        RasterFunction()
    End Sub

    Private Sub CumulativeFunctions()
        If rdoCumulative.Checked Then
            Select Case ucrInputCumulative.GetText
                Case "Sum"
                    clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsCumulativeSum, iPosition:=1)
                Case "Maximum"
                    clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsCumulativeMaximum, iPosition:=1)
                Case "Minimum"
                    clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsCumulativeMinimum, iPosition:=1)
            End Select
        ElseIf rdoCount.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRCountFunction, iPosition:=1) ' changes depending on the rdo
        End If
    End Sub

    Private Sub CumulativeColNames()
        If rdoCumulative.Checked Then
            Select Case ucrInputCumulative.GetText
                Case "Sum"
                    ucrSaveColumn.SetName("cumsum")
                Case "Maximum"
                    ucrSaveColumn.SetName("cummax")
                Case "Minimum"
                    ucrSaveColumn.SetName("cummin")
            End Select
        ElseIf rdoCount.Checked Then
            ucrSaveColumn.SetName("count")
        End If
    End Sub

    Private Sub ucrInputCumulative_ControlValueChanged(ucrChangedControl As ucrCore)
        CumulativeColNames()
        CumulativeFunctions()
    End Sub

    Private Sub AddCalculate()
        If rdoCumulative.Checked OrElse rdoMoving.Checked Then
            clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")")
        ElseIf rdoDegree.Checked Then
            If rdoDiurnalRange.Checked OrElse rdoTMean.Checked Then
                clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMin.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverTMax.GetVariableNames & ")")
                clsRTransform.RemoveParameterByName("sub_calculations")
            ElseIf rdoHeatingDegreeDays.Checked OrElse rdoGrowingDegreeDays.Checked OrElse rdoModifiedGDD.Checked Then
                clsDegreeMeanFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMin.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverTMax.GetVariableNames & ")")
                clsTMeanAddOperator.AddParameter("tmax", clsRFunctionParameter:=ucrReceiverTMax.GetVariables, iPosition:=0)
                clsTMeanAddOperator.AddParameter("tmin", clsRFunctionParameter:=ucrReceiverTMin.GetVariables, iPosition:=1)
                clsMeanAddOperator.AddParameter("tmax", clsRFunctionParameter:=ucrReceiverTMax.GetVariables, iPosition:=0)
                clsMeanAddOperator.AddParameter("tmin", clsRFunctionParameter:=ucrReceiverTMin.GetVariables, iPosition:=1)

                If (ucrChkUseMaxMin.Checked) Then
                    ' if "Use tmin and tmax" is checked, and one fo these three rdos are checked, then:
                    clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRDegreeListParameter)
                    clsRTransform.RemoveParameterByName("calculated_from")
                Else
                    ' calculated_from is the following only if "Use tmin and tmax" is unchecked:
                    clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMean.GetVariableNames & ")")
                    clsRTransform.RemoveParameterByName("sub_calculations")
                End If
            End If
        End If
    End Sub

    Private Sub ChangeFunctions()
        If Not rdoDegree.Checked Then
            Exit Sub
        End If
        If ucrChkUseMaxMin.Checked Then
            AlternativeFunctions()
        End If
    End Sub

    Private Sub AlternativeFunctions()
        If rdoGrowingDegreeDays.Checked Then
            clsGrowingDegreDiffOperator.AddParameter("tmean", "mean", iPosition:=0, bIncludeArgumentName:=False)
            clsGrowingDegreeLogicOperator.AddParameter("tmean", "mean", iPosition:=0, bIncludeArgumentName:=False)
            clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMax.GetVariableNames &
                                       "," & strCurrDataName & "=" & ucrReceiverTMin.GetVariableNames & ")")
        ElseIf rdoHeatingDegreeDays.Checked Then
            clsHeatingDegreeDiffOperator.AddParameter("tmean", "mean", iPosition:=1, bIncludeArgumentName:=False)
            clsHeatingDegreeLogicOperator.AddParameter("tmean", "mean", iPosition:=0, bIncludeArgumentName:=False)
            clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMax.GetVariableNames &
                                       "," & strCurrDataName & "=" & ucrReceiverTMin.GetVariableNames & ")")
        ElseIf rdoModifiedGDD.Checked Then
            clsModifiedMinfunction.AddParameter("tmean", "mean", iPosition:=1, bIncludeArgumentName:=False)
            clsModifiedLogicOperator.AddParameter("tmean", "mean", iPosition:=0, bIncludeArgumentName:=False)
            clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMax.GetVariableNames &
                                       "," & strCurrDataName & "=" & ucrReceiverTMin.GetVariableNames & ")")
        End If
    End Sub
    Private Sub ucrPnlEvap_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlEvap.ControlContentsChanged, ucrPnlTransform.ControlContentsChanged, ucrReceiverData.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged,
        ucrChkUseMaxMin.ControlContentsChanged, ucrReceiverTMin.ControlContentsChanged, ucrReceiverTMean.ControlContentsChanged, ucrReceiverTMax.ControlContentsChanged, ucrPnlDegree.ControlContentsChanged, ucrNudGDD.ControlContentsChanged, ucrNudHDD.ControlContentsChanged, ucrNudMgdd.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlValueChanged
        'change the parameter values
        clsEndSeasonWBCalc.AddParameter("result_name", Chr(34) & ucrSaveColumn.GetText() & Chr(34), iPosition:=2)
        clsRTransform.AddParameter(strParameterName:="result_name", strParameterValue:=Chr(34) & ucrSaveColumn.GetText & Chr(34), iPosition:=2)
    End Sub

    Private Sub SetAsReceiver()
        If Not rdoDegree.Checked Then
            Exit Sub
        End If
        If ucrChkUseMaxMin.Checked Then
            rdoDiurnalRange.Enabled = True
            rdoTMean.Enabled = True
            If ucrReceiverTMax.IsEmpty Then
                ucrReceiverTMax.SetMeAsReceiver()
            Else
                ucrReceiverTMin.SetMeAsReceiver()
            End If
        Else
            If (rdoDiurnalRange.Checked OrElse rdoTMean.Checked) Then
                rdoHeatingDegreeDays.Checked = True
            End If
            rdoDiurnalRange.Enabled = False
            rdoTMean.Enabled = False
            ucrReceiverTMean.SetMeAsReceiver()
        End If
    End Sub

    Private Sub AddRemoveMeanOperator()
        'If rdoDegree.Checked AndAlso ucrChkUseMaxMin.Checked AndAlso (rdoHeatingDegreeDays.Checked OrElse rdoGrowingDegreeDays.Checked Or rdoModifiedGDD.Checked) Then
        '    ucrBase.clsRsyntax.AddToBeforeCodes(clsMeanDivideByOperator)
        'Else
        '    ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMeanDivideByOperator)
        'End If
    End Sub

    Private Sub ucrChkUseMaxMin_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkUseMaxMin.ControlValueChanged, ucrNudGDD.ControlValueChanged, ucrNudHDD.ControlValueChanged, ucrNudMgdd.ControlValueChanged
        AddRemoveMeanOperator()
        SetAsReceiver()
        ChangeFunctions()
    End Sub

    Private Sub ucrReceiverTMax_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTMax.ControlValueChanged, ucrReceiverTMean.ControlValueChanged, ucrReceiverTMin.ControlValueChanged
        ChangeFunctions()
        AddRemoveMeanOperator()
        AddCalculate()
    End Sub

    Private Sub ShowGroups()
        If rdoDegree.Checked Then
            grpTransform.Hide()
            grpDegree.Show()
        Else
            grpDegree.Hide()
            grpTransform.Show()
        End If
    End Sub

    Private Sub AutoFill()
        If rdoWaterBalance.Checked Then
            Dim strDataFrame As String
            Dim strRainCol As String

            strDataFrame = ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.Text
            strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")

            If strRainCol <> "" Then
                ucrReceiverData.Add(strRainCol, strDataFrame)
            End If
        End If
    End Sub

    Private Sub RainfallChange()
        clsEndSeasonRainMinCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")", iPosition:=3)
        clsEndSeasonRainMaxCalc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub ucrChkWB_ControlValueChanged(ucrChangedControl As ucrCore)
        ReduceWaterBalance()
    End Sub

    Private Sub rdoEvapValue_CheckedChanged(sender As Object, e As EventArgs)
        ReduceWaterBalance()
    End Sub

    Private Sub ucrInputEvaporation_ControlValueChanged(ucrChangedControl As ucrCore)
        ReduceWaterBalance()
        If Me.Visible Then
            CheckForMissingValues()
        End If
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        ReduceWaterBalance()
    End Sub

    Private Sub ucrNudWB_ControlValueChanged(ucrChangedControl As ucrCore)
        ReduceWaterBalance()
    End Sub

    Private Sub ucrSelectorTransform_DataFrameChanged() Handles ucrSelectorTransform.DataFrameChanged
        clsDoyFilterCalcFromList.ClearParameters()
        AutoFill()
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlEvap_ControlValueChanged(ucrChangedControl As ucrCore)
        ReduceWaterBalance()
    End Sub

    Private Sub ucrNudWBCapacity_ControlValueChanged(ucrChangedControl As ucrCore)
        ReduceWaterBalance()
    End Sub

    Private Sub ReduceWaterBalance()
        If rdoWaterBalance.Checked Then
            clsPMaxFunction.RemoveParameterByName("0")
            clsPMaxFunction.RemoveParameterByName("0")
            clsWBMinEvapOperator.RemoveParameterByName("variable")
            clsWBMaxEvapOperator.RemoveParameterByName("variable")
            clsWBMaxEvapOperator.RemoveParameterByName("value")
            clsWBMinEvapOperator.RemoveParameterByName("value")
            clsPMaxFunction.RemoveParameterByName("wb")
            clsPMaxFunction.RemoveParameterByName("wb")
            clsEndSeasonWBCalc.AddParameter("adjacent_column", ucrReceiverData.GetVariableNames(), iPosition:=3)
            clsPMinWBMaxFunction.AddParameter("1", ucrNudWBCapacity.GetText(), iPosition:=1, bIncludeArgumentName:=False)
            clsPMinWBMinFunction.AddParameter("1", ucrNudWBCapacity.GetText(), iPosition:=1, bIncludeArgumentName:=False)
            If rdoEvapValue.Checked Then
                clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction, iPosition:=1)
                clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction, iPosition:=1)
                If ucrChkWB.Checked Then
                    clsWBEvaporationMinFunction.AddParameter("WB_evap_value", ucrNudWB.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                    clsWBEvaporationMinFunction.AddParameter("yes", ucrNudWBCapacity.GetText(), iPosition:=2, bIncludeArgumentName:=False)
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
                ucrReceiverEvap.SetMeAsReceiver()
                If ucrChkWB.Checked Then
                    clsEndSeasonWBMaxCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMaxFunction1, iPosition:=1)
                    clsEndSeasonWBMinCalc.AddParameter("function_exp", clsRFunctionParameter:=clsReduceWBMinFunction1, iPosition:=1)
                    clsWBEvaporationMinFunction.AddParameter("WB_evap_value", ucrNudWB.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                    clsWBEvaporationMinFunction.AddParameter("yes", ucrNudWBCapacity.GetText(), iPosition:=2, bIncludeArgumentName:=False)
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

    Private Sub CheckForMissingValues()
        If rdoWaterBalance.Checked AndAlso rdoEvapVariable.Checked Then
            If Not ucrReceiverEvap.IsEmpty Then
                Dim clsCalcFunction, clsIsNAFunction, clsAnyFunction As New RFunction
                Dim strDataFrame As String = ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.Text
                Dim strVariable As String = ucrReceiverEvap.GetVariableNames(False)

                ' Build: any(is.na(data_book$get_columns_from_data(...)))
                clsCalcFunction.SetRCommand("data_book$get_columns_from_data")
                clsCalcFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
                clsCalcFunction.AddParameter("col_names", Chr(34) & strVariable & Chr(34), iPosition:=0)

                clsIsNAFunction.SetRCommand("is.na")
                clsIsNAFunction.AddParameter("na", clsRFunctionParameter:=clsCalcFunction, iPosition:=0, bIncludeArgumentName:=False)

                clsAnyFunction.SetRCommand("any")
                clsAnyFunction.AddParameter("any", clsRFunctionParameter:=clsIsNAFunction, iPosition:=0, bIncludeArgumentName:=False)

                ' Run and check result
                Try
                    Dim symResult As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyFunction.ToScript)
                    If symResult.AsLogical()(0) Then
                        MsgBox("Sorry, missing values are not permitted in this variable here. They have to be estimated first.", MsgBoxStyle.Exclamation)
                    End If
                Catch ex As Exception
                    ' Do nothing on error — no message
                End Try
            End If
        End If
    End Sub

    Private Sub dlgWaterBalance_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If bDialogJustShown AndAlso Not ucrReceiverEvap.IsEmpty Then
            CheckForMissingValues()
            bDialogJustShown = False ' So it doesn't repeat if Shown is triggered again
        End If
    End Sub
End Class