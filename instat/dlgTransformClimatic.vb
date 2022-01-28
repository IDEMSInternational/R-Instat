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
Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsRTransform, clsOverallTransformFunction, clsTransformManipulationsFunc, clsGroupByYear, clsGroupByStation, clsReplaceNAasElement, clsRTransformCountSpellSub As New RFunction
    Private clsTransformCheck As New RFunction

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

    ' Water Balance
    Private clsPMinFunctionMax, clsPMaxFunctionMax, clsRWaterBalanceFunction As New RFunction
    Private clsPMaxOperatorMax, clsReduceOpEvapValue As New ROperator

    'Degree
    Private clsDiurnalRangeOperator, clsTMeanAddOperator, clsTMeanDivideOperator As New ROperator
    Private clsHeatingDegreeDiffOperator, clsHeatingDegreeLogicOperator, clsHeatingDegreeOperator As New ROperator
    Private clsGrowingDegreDiffOperator, clsGrowingDegreeLogicOperator, clsGrowingDegreeOperator As New ROperator
    Private clsModifiedMinfunction As New RFunction
    Private clsModifiedDiffOperator, clsModifiedLogicOperator, clsModifiedGDDOperator As New ROperator
    Private clsLogicalRFunction, clsLogicalGDDRFunction, clsLogicalMgddRFunction As New RFunction
    Private clsMeanAddOperator, clsMeanDivideByOperator As New ROperator

    Private strCurrDataName As String = ""
    Private strRainDay As String = "rain_day"

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

        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCumulative, "function_exp", {"cumsum", "cummin", "cummax"})
        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCount, "function_exp", "rollapply")
        ucrPnlTransform.AddParameterPresentCondition(rdoCount, "sub_calculations", True)
        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoMoving, "function_exp", {"rollapply", "movingFun"})
        ucrPnlTransform.AddParameterPresentCondition(rdoMoving, "sub_calculations", False)
        ucrPnlTransform.AddParameterIsStringCondition(rdoSpell, "function_exp")
        ucrPnlTransform.AddFunctionNamesCondition(rdoMultSpells, "rollapply")
        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoWaterBalance, "function_exp", "Reduce")
        ucrPnlTransform.AddParameterIsROperatorCondition(rdoDegree, "function_exp")

        ucrPnlEvap.AddRadioButton(rdoEvapValue)
        ucrPnlEvap.AddRadioButton(rdoEvapVariable)
        ucrPnlEvap.AddParameterPresentCondition(rdoEvapValue, "evaporation.value")
        ucrPnlEvap.AddParameterPresentCondition(rdoEvapVariable, "evaporation.value", False)

        ucrPnlDegree.AddRadioButton(rdoTMean)
        ucrPnlDegree.AddRadioButton(rdoHeatingDegreeDays)
        ucrPnlDegree.AddRadioButton(rdoGrowingDegreeDays)
        ucrPnlDegree.AddRadioButton(rdoDiurnalRange)
        ucrPnlDegree.AddRadioButton(rdoModifiedGDD)

        ucrPnlDegree.AddParameterValuesCondition(rdoModifiedGDD, "checked", "mgdd")
        ucrPnlDegree.AddParameterValuesCondition(rdoDiurnalRange, "checked", "diurnal")
        ucrPnlDegree.AddParameterValuesCondition(rdoTMean, "checked", "mean")
        ucrPnlDegree.AddParameterValuesCondition(rdoHeatingDegreeDays, "checked", "hdd")
        ucrPnlDegree.AddParameterValuesCondition(rdoGrowingDegreeDays, "checked", "gdd")

        ttRdoRange.SetToolTip(rdoDiurnalRange, "Diurnal Range is the difference between Tmax And Tmin, (Tmax - Tmin)")
        ttRdoTMean.SetToolTip(rdoTMean, "Tmean is the average daily temperature, (Tmax + Tmin)/2")
        ttRdoHdd.SetToolTip(rdoHeatingDegreeDays, "Heating Degree Days. If the baseline = 15 degrees then HDD is (15 - tmean). HDD = 0 if tmean is more than 15.")
        ttRdoGdd.SetToolTip(rdoGrowingDegreeDays, "Growing (or Cooling) Degree Days. If the baseline = 15 degrees, then GDD = (tmean - 15), or 0 if tmean is less than 15")
        ttRdoMgdd.SetToolTip(rdoModifiedGDD, "Modified GDD is just GDD if tmean is less than the upper limit. If baseline = 15 degrees and limit = 30 degrees, then Modified GDD = 30 - 15 if tmean is more than 30 degrees.")

        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoMoving, "sub1", "instat_calculation$new", False) ' clsRRainday
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCount, "sub1", "instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoSpell, "sub1", "instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoWaterBalance, "sub1", "instat_calculation$new", False)

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

        ucrReceiverEvap.Selector = ucrSelectorTransform
        ucrReceiverEvap.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrReceiverEvap.SetParameterIsString()
        ucrReceiverEvap.bWithQuotes = False
        ucrReceiverEvap.strSelectorHeading = "Numerics"
        ucrReceiverEvap.SetIncludedDataTypes({"numeric"})

        ucrReceiverTMin.Selector = ucrSelectorTransform
        ucrReceiverTMin.SetParameter(New RParameter("tmin", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTMin.strSelectorHeading = "Numerics"
        ucrReceiverTMin.SetDataType("numeric")
        ucrReceiverTMin.SetParameterIsRFunction()
        ucrReceiverTMin.SetLinkedDisplayControl(lblTMin)

        ucrReceiverTMax.Selector = ucrSelectorTransform
        ucrReceiverTMax.SetParameter(New RParameter("tmax", 0, bNewIncludeArgumentName:=False))
        ucrReceiverTMax.strSelectorHeading = "Numerics"
        ucrReceiverTMax.SetDataType("numeric")
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

        ucrInputSpellUpper.SetParameter(New RParameter("max", 1))
        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.AddQuotesIfUnrecognised = False

        ' mult Spells 
        ucrNudMultSpells.SetParameter(New RParameter("width", 1))
        ucrNudMultSpells.SetMinMax(1, 21)
        ucrNudMultSpells.Increment = 1
        ucrNudMultSpells.SetLinkedDisplayControl(lblRowsMultSpells)

        ' Water Balance
        ucrNudWBCapacity.SetParameter(New RParameter("capacity", 1), False)
        ucrNudWBCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudWBCapacity.Increment = 10
        ucrNudWBCapacity.SetLinkedDisplayControl(lblWBCapacity)

        ucrInputEvaporation.SetParameter(New RParameter("evaporation.value", 1, False))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False

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

        ucrPnlEvap.AddToLinkedControls(ucrInputEvaporation, {rdoEvapValue}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEvap.AddToLinkedControls(ucrReceiverEvap, {rdoEvapVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlEvap.SetLinkedDisplayControl(lblWBEvaporation)

        ucrPnlDegree.AddToLinkedControls(ucrNudGDD, {rdoGrowingDegreeDays}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=15.0)
        ucrPnlDegree.AddToLinkedControls(ucrNudMgdd, {rdoModifiedGDD}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=15.0)
        ucrPnlDegree.AddToLinkedControls(ucrNudHDD, {rdoHeatingDegreeDays}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=15.0)
        ucrPnlDegree.AddToLinkedControls(ucrNudLimit, {rdoModifiedGDD}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30.0)

        ucrPnlTransform.AddToLinkedControls({ucrInputCumulative}, {rdoCumulative}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Sum")
        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlTransform.AddToLinkedControls({ucrInputCondition}, {rdoCount, rdoSpell, rdoMultSpells}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=">=")
        ucrPnlTransform.AddToLinkedControls(ucrInputSum, {rdoMoving}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudSumOver, {rdoMoving}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrChkCircular, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudMultSpells, {rdoMultSpells}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=21)
        ucrPnlTransform.AddToLinkedControls(ucrPnlEvap, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudWBCapacity, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=60)
        ucrPnlTransform.AddToLinkedControls(ucrChkGroupByYear, {rdoCount, rdoMoving, rdoSpell, rdoMultSpells, rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrReceiverYear, ucrReceiverData, ucrChkOptions}, {rdoCumulative, rdoCount, rdoMoving, rdoMultSpells, rdoSpell, rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrChkUseMaxMin, ucrPnlDegree}, {rdoDegree}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkCircular.AddToLinkedControls(ucrInputCircularPosition, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCircular.AddToLinkedControls(ucrInputPosition, {False}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputCondition.AddToLinkedControls(ucrInputSpellUpper, {"<=", "Between", "Outer"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrInputCondition.AddToLinkedControls(ucrInputSpellLower, {"Between", "Outer", ">="}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        'Temporary fix: ucrChkOptions is only used in linking
        ucrChkOptions.SetLinkedDisplayControl(grpTransform)
        ucrPnlDegree.SetLinkedDisplayControl(grpDegree)
    End Sub

    Private Sub SetDefaults()
        clsRTransform = New RFunction
        clsOverallTransformFunction = New RFunction
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
        clsRWaterBalanceFunction = New RFunction

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

        clsPMinFunctionMax = New RFunction
        clsPMaxFunctionMax = New RFunction
        clsPMaxOperatorMax = New ROperator
        clsGroupByYear.Clear()
        clsReduceOpEvapValue.Clear()
        clsGreaterThanOperator.Clear()
        clsLessThanOperator.Clear()

        ucrSelectorTransform.Reset()
        ucrReceiverData.SetMeAsReceiver()

        ' Count and Spells: Rainday
        clsRRainday.SetRCommand("instat_calculation$new")
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
        clsRRaindayLowerOperator.AddParameter("min", 0.85, iPosition:=1)

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
        clsRollConsecutiveSumFunction.AddParameter("FUN", "max_consecutive_sum")
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

        ' Water Balance
        clsRWaterBalanceFunction.bToScriptAsRString = True
        clsRWaterBalanceFunction.SetRCommand("Reduce")
        clsRWaterBalanceFunction.AddParameter("x", clsRFunctionParameter:=clsPMinFunctionMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMinFunctionMax.SetRCommand("function(x, y) pmin")
        clsPMinFunctionMax.AddParameter("pmax", clsRFunctionParameter:=clsPMaxFunctionMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.SetRCommand("pmax")
        clsPMaxFunctionMax.AddParameter("calculation", clsROperatorParameter:=clsPMaxOperatorMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxOperatorMax.SetOperation("-")
        clsPMaxOperatorMax.AddParameter("first", "x + y", iPosition:=0)
        clsPMaxOperatorMax.AddParameter("evaporation.value", 5, iPosition:=1)
        clsPMaxFunctionMax.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMax.AddParameter("capacity", 60, iPosition:=1, bIncludeArgumentName:=False)
        clsRWaterBalanceFunction.AddParameter("replace_na", iPosition:=1, bIncludeArgumentName:=False)
        clsRWaterBalanceFunction.AddParameter("accumulate", "TRUE", iPosition:=2)
        '"Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Rain, accumulate=TRUE)" & Chr(34))

        ' Degree
        clsDiurnalRangeOperator.SetOperation("-")
        clsDiurnalRangeOperator.AddParameter("tmax", "tmax", iPosition:=0)
        clsDiurnalRangeOperator.AddParameter("tmin", "tmin", iPosition:=1)
        clsDiurnalRangeOperator.bToScriptAsRString = True

        clsTMeanAddOperator.SetOperation("+")
        clsTMeanAddOperator.AddParameter("tmax", "tmax", iPosition:=0)
        clsTMeanAddOperator.AddParameter("tmin", "tmin", iPosition:=1)
        clsTMeanDivideOperator.SetOperation("/")
        clsTMeanDivideOperator.AddParameter("x", clsROperatorParameter:=clsTMeanAddOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsTMeanDivideOperator.AddParameter("y", 2, iPosition:=1, bIncludeArgumentName:=False)
        clsTMeanDivideOperator.bToScriptAsRString = True

        clsMeanAddOperator.SetOperation("+")
        clsMeanAddOperator.AddParameter("tmax", "tmax", iPosition:=0)
        clsMeanAddOperator.AddParameter("tmin", "tmin", iPosition:=1)
        clsMeanDivideByOperator.SetOperation("/")
        clsMeanDivideByOperator.AddParameter("x", clsROperatorParameter:=clsMeanAddOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsMeanDivideByOperator.AddParameter("y", 2, iPosition:=1, bIncludeArgumentName:=False)
        clsMeanDivideByOperator.SetAssignTo("mean")
        clsMeanDivideByOperator.bBrackets = True

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

        clsDummyFunction.AddParameter("checked", "diurnal", iPosition:=0)

        ' Group options 
        clsGroupByYear.SetRCommand("instat_calculation$new")
        clsGroupByYear.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByYear.AddParameter("result_name", Chr(34) & "group_by_year" & Chr(34), iPosition:=2)
        clsGroupByYear.SetAssignTo("group_by_year")

        clsGroupByStation.SetRCommand("instat_calculation$new")
        clsGroupByStation.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByStation.SetAssignTo("group_by_station")

        ' Overall Function
        clsRTransformCountSpellSub.SetRCommand("list")
        clsRTransformCountSpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False, iPosition:=0)

        clsTransformManipulationsFunc.SetRCommand("list")
        clsTransformManipulationsFunc.AddParameter("group_by_year", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=0)

        clsRTransform.SetRCommand("instat_calculation$new")
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRCountFunction, iPosition:=1) ' changes depending on the rdo
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
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRWaterBalanceFunction, New RParameter("replace_na", 1, False), iAdditionalPairNo:=5)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsReduceOpEvapValue, New RParameter("left", 0, False), iAdditionalPairNo:=6)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=7)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=8)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsCumulativeSum, New RParameter("x", 0, False), iAdditionalPairNo:=9)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsCumulativeMaximum, New RParameter("x", 0, False), iAdditionalPairNo:=10)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsCumulativeMinimum, New RParameter("x", 0, False), iAdditionalPairNo:=11)
        ucrNudSumOver.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("n", 1), iAdditionalPairNo:=1)
        ucrInputSum.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("fun", 2), iAdditionalPairNo:=1)
        ucrInputSpellUpper.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("max", 1), iAdditionalPairNo:=1)
        ucrInputSpellLower.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("min", 1), iAdditionalPairNo:=1)
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

        ucrPnlTransform.SetRCode(clsTransformCheck, bReset)

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
        ucrInputSpellLower.SetRCode(clsRRaindayLowerOperator, bReset)
        ucrInputSpellUpper.SetRCode(clsRRaindayUpperOperator, bReset)

        ' Water Balance
        ucrPnlEvap.SetRCode(clsPMaxOperatorMax, bReset)
        ucrInputEvaporation.SetRCode(clsPMaxOperatorMax, bReset)
        ucrReceiverEvap.SetRCode(clsReduceOpEvapValue, bReset)
        ucrNudWBCapacity.SetRCode(clsPMinFunctionMax, bReset)

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

    Private Sub ucrPnlTransform_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlValueChanged, ucrPnlDegree.ControlValueChanged
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
            clsRTransform.AddParameter("function_exp", Chr(34) & ".spells(x = " & strRainDay & ")" & Chr(34), iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
            clsRTransform.RemoveParameterByName("calculated_from")
            clsTransformCheck = clsRTransform
        ElseIf rdoMultSpells.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRollConsecutiveSumFunction, iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
            clsRTransform.RemoveParameterByName("calculated_from")
            clsTransformCheck = clsRollConsecutiveSumFunction
        ElseIf rdoWaterBalance.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRWaterBalanceFunction, iPosition:=1)
            clsRTransform.RemoveParameterByName("sub_calculations")
            clsTransformCheck = clsRTransform
        ElseIf rdoDegree.Checked Then
            DegreeFunctions()
            clsRTransform.RemoveParameterByName("sub_calculations")
            clsTransformCheck = clsRTransform
        End If
        Evaporation()
        AddCalculate()
        SetAssignName()
        GroupByStation()
        GroupByYear()
        SetAsReceiver()
        ChangeFunctions()
        AddRemoveMeanOperator()
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
        clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub Evaporation()
        If rdoWaterBalance.Checked Then
            If rdoEvapValue.Checked Then
                ucrReceiverData.SetMeAsReceiver()
                clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")")
                clsPMaxOperatorMax.AddParameter("evaporation.value", 5, iPosition:=1, bIncludeArgumentName:=False)
            ElseIf rdoEvapVariable.Checked Then
                ucrReceiverEvap.SetMeAsReceiver()
                clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ", " & strCurrDataName & "=" & ucrReceiverEvap.GetVariableNames & ")")
                clsReduceOpEvapValue.SetOperation("-")
                clsRWaterBalanceFunction.AddParameter("replace_na", clsROperatorParameter:=clsReduceOpEvapValue, iPosition:=1, bIncludeArgumentName:=False)
                clsPMaxOperatorMax.RemoveParameterByName("evaporation.value")
            End If
        End If
    End Sub

    Private Sub ucrSelectorTransform_ControlValueChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        RainDays()
        GroupByYear()
        GroupByStation()
        Evaporation()
        ChangeFunctions()
    End Sub

    Private Sub ucrInputSpellLower_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpellUpper.ControlValueChanged, ucrInputCondition.ControlValueChanged
        InputConditionOptions()
    End Sub

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged, ucrReceiverEvap.ControlValueChanged
        RainDays()
        Evaporation()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByStation()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByYear()
        CheckGroupByYearEnabled()
    End Sub

    Private Sub ucrInputSum_ControlValueChanged(ucrchangedControl As ucrCore) Handles ucrInputSum.ControlValueChanged
        MovingColNames()
    End Sub

    Private Sub ucrChkGroupByYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkGroupByYear.ControlValueChanged
        GroupByYear()
        CheckGroupByYearEnabled()
    End Sub

    Private Sub ucrInputEvaporation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputEvaporation.ControlContentsChanged, ucrPnlEvap.ControlContentsChanged
        Evaporation()
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

    Private Sub ucrChkCircular_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCircular.ControlValueChanged
        RasterFunction()
    End Sub

    Private Sub CumulativeFunctions()
        Select Case ucrInputCumulative.GetText
            Case "Sum"
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsCumulativeSum, iPosition:=1)
            Case "Maximum"
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsCumulativeMaximum, iPosition:=1)
            Case "Minimum"
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsCumulativeMinimum, iPosition:=1)
        End Select
    End Sub

    Private Sub CumulativeColNames()
        Select Case ucrInputCumulative.GetText
            Case "Sum"
                ucrSaveColumn.SetName("cumsum")
            Case "Maximum"
                ucrSaveColumn.SetName("cummax")
            Case "Minimum"
                ucrSaveColumn.SetName("cummin")
        End Select
    End Sub

    Private Sub ucrInputCumulative_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCumulative.ControlValueChanged
        CumulativeColNames()
        CumulativeFunctions()
    End Sub

    Private Sub AddCalculate()
        If rdoCumulative.Checked OrElse rdoMoving.Checked Then
            clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")")
        ElseIf rdoDegree.Checked Then
            If rdoDiurnalRange.Checked OrElse rdoTMean.Checked Then
                clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMin.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverTMax.GetVariableNames & ")")
            ElseIf rdoHeatingDegreeDays.Checked OrElse rdoGrowingDegreeDays.Checked OrElse rdoModifiedGDD.Checked Then
                clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverTMean.GetVariableNames & ")")
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
    Private Sub ucrPnlEvap_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlEvap.ControlContentsChanged, ucrInputSum.ControlContentsChanged, ucrPnlTransform.ControlContentsChanged, ucrReceiverData.ControlContentsChanged, ucrNudSumOver.ControlContentsChanged, ucrNudCountOver.ControlContentsChanged, ucrInputSpellUpper.ControlContentsChanged, ucrInputCondition.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrNudWBCapacity.ControlContentsChanged, ucrReceiverEvap.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrNudMultSpells.ControlContentsChanged,
        ucrChkUseMaxMin.ControlContentsChanged, ucrReceiverTMin.ControlContentsChanged, ucrReceiverTMean.ControlContentsChanged, ucrReceiverTMax.ControlContentsChanged, ucrPnlDegree.ControlContentsChanged, ucrNudGDD.ControlContentsChanged, ucrNudHDD.ControlContentsChanged, ucrNudMgdd.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveColumn.ControlValueChanged
        'change the parameter values
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
            rdoDiurnalRange.Enabled = False
            rdoTMean.Enabled = False
            ucrReceiverTMean.SetMeAsReceiver()
        End If
    End Sub

    Private Sub AddRemoveMeanOperator()
        If rdoDegree.Checked AndAlso ucrChkUseMaxMin.Checked AndAlso (rdoHeatingDegreeDays.Checked OrElse rdoGrowingDegreeDays.Checked Or rdoModifiedGDD.Checked) Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsMeanDivideByOperator)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsMeanDivideByOperator)
        End If
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
End Class