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

    'Conversion
    Private clsPrecipitationFunction, clsTemperatureFunction, clsWindSpeedFunction As New RFunction

    'Moving
    Private clsRMovingFunction As New RFunction
    Private clsRasterFuction As New RFunction

    'Count and Spells
    Private clsRRainday, clsRRaindayMatch, clsRCountFunction, clsRollConsecutiveSumFunction As New RFunction
    Private clsRRaindayAndOperator, clsRRaindayLowerOperator, clsRRaindayUpperOperator, clsRCountOperator As New ROperator
    Private clsGreaterThanOperator, clsLessThanOperator As New ROperator

    ' Water Balance
    Private clsPMinFunctionMax, clsPMaxFunctionMax, clsRWaterBalanceFunction As New RFunction
    Private clsPMaxOperatorMax, clsReduceOpEvapValue As New ROperator

    Private strCurrDataName As String = ""
    Private strRainDay As String = "rain_day"

    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer

    Private Sub dlgTransformClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            iReceiverMaxY = ucrReceiverData.Location.Y
            iReceiverLabelMaxY = lblData.Location.Y
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
    End Sub

    Private Sub InitialiseDialog()
        Dim dctInputSumPairs As New Dictionary(Of String, String)
        Dim dctInputPosition As New Dictionary(Of String, String)
        Dim dctInputCircularPosition As New Dictionary(Of String, String)

        Dim dctPrecipitationUnits As New Dictionary(Of String, String)
        Dim dctTemperatureUnits As New Dictionary(Of String, String)
        Dim dctWindSpeedUnits As New Dictionary(Of String, String)

        Dim lstLabels As New List(Of Control)
        lstLabels.AddRange({lblFrom, lblTo, lblDecimal})

        ucrBase.iHelpTopicID = 358

        'Overall Panel
        ucrPnlTransform.AddRadioButton(rdoConversion)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoMoving)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoMultSpells)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)

        ucrPnlElements.AddRadioButton(rdoRain)
        ucrPnlElements.AddRadioButton(rdoTemperature)
        ucrPnlElements.AddRadioButton(rdoWindSpeed)

        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoConversion, "function_exp", {"convert_precip", "convert_temperature", "convert_wind_speed"})
        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCount, "function_exp", "rollapply")
        ucrPnlTransform.AddParameterPresentCondition(rdoCount, "sub_calculations", True)
        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoMoving, "function_exp", {"rollapply", "raster"})
        ucrPnlTransform.AddParameterPresentCondition(rdoMoving, "sub_calculations", False)
        ucrPnlTransform.AddParameterIsStringCondition(rdoSpell, "function_exp")
        ucrPnlTransform.AddFunctionNamesCondition(rdoMultSpells, "rollapply")
        ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoWaterBalance, "function_exp", "Reduce")

        ucrPnlElements.AddFunctionNamesCondition(rdoRain, "convert_precip")
        ucrPnlElements.AddFunctionNamesCondition(rdoTemperature, "convert_temperature")
        ucrPnlElements.AddFunctionNamesCondition(rdoWindSpeed, "convert_wind_speed")

        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoMoving, "sub1", "instat_calculation$new", False) ' clsRRainday
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCount, "sub1", "instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoSpell, "sub1", "instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoWaterBalance, "sub1", "instat_calculation$new", False)

        ' Setting receivers
        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ' What is this used for? I don't think this requires a key.
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverData.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False
        ucrReceiverData.bAutoFill = True
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverData.strSelectorHeading = "Numerics"
        ucrReceiverData.SetIncludedDataTypes({"numeric"})

        ucrReceiverEvap.Selector = ucrSelectorTransform
        ucrReceiverEvap.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrReceiverEvap.SetParameterIsString()
        ucrReceiverEvap.bWithQuotes = False
        ucrReceiverEvap.strSelectorHeading = "Numerics"
        ucrReceiverEvap.SetIncludedDataTypes({"numeric"})

        ucrChkGroupByYear.SetParameter(New RParameter("group_by_year", strParamValue:=clsGroupByYear, bNewIncludeArgumentName:=False), False)
        ucrChkGroupByYear.SetText("Group by Year")

        ' Moving
        ucrInputSum.SetParameter(New RParameter("FUN", 0))
        dctInputSumPairs.Add("Sum", "sum")
        dctInputSumPairs.Add("Maximum", "max")
        dctInputSumPairs.Add("Minimum", "min")
        dctInputSumPairs.Add("Mean", "(mean)")
        dctInputSumPairs.Add("Median", "median")
        ucrInputSum.SetItems(dctInputSumPairs)
        ucrInputSum.SetDropDownStyleAsNonEditable()
        ucrInputSum.SetLinkedDisplayControl(lblSumOver)
        ucrInputSum.bAllowNonConditionValues = True


        ucrInputPosition.SetParameter(New RParameter("align", 4))
        dctInputPosition.Add("Right", Chr(39) & "right" & Chr(39))
        dctInputPosition.Add("Centred", Chr(39) & "center" & Chr(39))
        dctInputPosition.Add("Left", Chr(39) & "left" & Chr(39))
        ucrInputPosition.SetItems(dctInputPosition)
        ucrInputPosition.SetDropDownStyleAsNonEditable()
        ucrInputPosition.bAllowNonConditionValues = True

        ucrInputCircularPosition.SetParameter(New RParameter("type", 3))
        dctInputCircularPosition.Add("Right", Chr(39) & "to" & Chr(39))
        dctInputCircularPosition.Add("Centred", Chr(39) & "around" & Chr(39))
        dctInputCircularPosition.Add("Left", Chr(39) & "from" & Chr(39))
        ucrInputCircularPosition.SetItems(dctInputCircularPosition)
        ucrInputCircularPosition.SetDropDownStyleAsNonEditable()
        ucrInputCircularPosition.bAllowNonConditionValues = True

        ucrInputFromPrecipitation.SetParameter(New RParameter("old_metric", 1))
        dctPrecipitationUnits.Add("cm", Chr(34) & "cm" & Chr(34))
        dctPrecipitationUnits.Add("inches", Chr(34) & "inches" & Chr(34))
        dctPrecipitationUnits.Add("mm", Chr(34) & "mm" & Chr(34))
        ucrInputFromPrecipitation.SetItems(dctPrecipitationUnits)
        ucrInputFromPrecipitation.SetDropDownStyleAsNonEditable()
        ucrInputFromPrecipitation.bAllowNonConditionValues = True

        ucrInputToPrecipitation.SetParameter(New RParameter("new_metric", 2))
        ucrInputToPrecipitation.SetItems(dctPrecipitationUnits)
        ucrInputToPrecipitation.SetDropDownStyleAsNonEditable()
        ucrInputToPrecipitation.bAllowNonConditionValues = True

        ucrInputFromTemperature.SetParameter(New RParameter("old_metric", 1))
        dctTemperatureUnits.Add("Celsius", Chr(34) & "celsius" & Chr(34))
        dctTemperatureUnits.Add("Fahrenheit", Chr(34) & "fahrenheit" & Chr(34))
        dctTemperatureUnits.Add("Kelvin", Chr(34) & "kelvin" & Chr(34))
        ucrInputFromTemperature.SetItems(dctTemperatureUnits)
        ucrInputFromTemperature.SetDropDownStyleAsNonEditable()

        ucrInputToTemperature.SetParameter(New RParameter("new_metric", 2))
        ucrInputToTemperature.SetItems(dctTemperatureUnits)
        ucrInputToTemperature.SetDropDownStyleAsNonEditable()

        ucrInputFromWindSpeed.SetParameter(New RParameter("old_metric", 1))
        dctWindSpeedUnits.Add("Feet per second (ftps)", Chr(34) & "ftps" & Chr(34))
        dctWindSpeedUnits.Add("Kilometres per hour (kmph)", Chr(34) & "kmph" & Chr(34))
        dctWindSpeedUnits.Add("Knots", Chr(34) & "knots" & Chr(34))
        dctWindSpeedUnits.Add("Metres per second (mps)", Chr(34) & "mps" & Chr(34))
        dctWindSpeedUnits.Add("Miles per hour (mph)", Chr(34) & "mph" & Chr(34))
        ucrInputFromWindSpeed.SetItems(dctWindSpeedUnits)
        ucrInputFromWindSpeed.SetDropDownStyleAsNonEditable()

        ucrInputToWindSpeed.SetParameter(New RParameter("new_metric", 2))
        ucrInputToWindSpeed.SetItems(dctWindSpeedUnits)
        ucrInputToWindSpeed.SetDropDownStyleAsNonEditable()

        ucrNudDecimal.SetParameter(New RParameter("round", 3))
        ucrNudDecimal.SetMinMax(0, 3)

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
        ucrInputSpellLower.SetValidationTypeAsNumeric()
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

        ' Save Options
        ucrInputColName.SetParameter(New RParameter("result_name", 2))
        ucrInputColName.SetName("moving_sum")

        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlTransform.AddToLinkedControls({ucrInputCondition}, {rdoCount, rdoSpell, rdoMultSpells}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Between")

        ucrPnlTransform.AddToLinkedControls(ucrInputSum, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Sum")
        ucrPnlTransform.AddToLinkedControls(ucrNudSumOver, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=3)
        ucrPnlTransform.AddToLinkedControls(ucrInputPosition, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Right")
        ucrPnlTransform.AddToLinkedControls(ucrInputCircularPosition, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Right")
        ucrPnlTransform.AddToLinkedControls(ucrChkCircular, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlTransform.AddToLinkedControls(ucrPnlElements, {rdoConversion}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoRain)

        ucrPnlElements.AddToLinkedControls(ucrInputFromPrecipitation, {rdoRain}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="inches")
        ucrPnlElements.AddToLinkedControls(ucrInputToPrecipitation, {rdoRain}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="mm")
        ucrPnlElements.AddToLinkedControls(ucrInputFromTemperature, {rdoTemperature}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Kelvin")
        ucrPnlElements.AddToLinkedControls(ucrInputToTemperature, {rdoTemperature}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Celsius")
        ucrPnlElements.AddToLinkedControls(ucrInputFromWindSpeed, {rdoWindSpeed}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Knots")
        ucrPnlElements.AddToLinkedControls(ucrInputToWindSpeed, {rdoWindSpeed}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Metres per second (mps)")

        ucrInputCondition.AddToLinkedControls(ucrInputSpellUpper, {"<=", "Between", ">=", "Outer"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)
        ucrInputCondition.AddToLinkedControls(ucrInputSpellLower, {"Between", "Outer"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrPnlTransform.AddToLinkedControls({ucrNudMultSpells}, {rdoMultSpells}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=21)

        ucrPnlTransform.AddToLinkedControls(ucrPnlEvap, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlTransform.AddToLinkedControls(ucrNudWBCapacity, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=60)

        ucrPnlEvap.AddRadioButton(rdoEvapValue)
        ucrPnlEvap.AddRadioButton(rdoEvapVariable)
        ucrPnlEvap.AddToLinkedControls(ucrInputEvaporation, {rdoEvapValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlEvap.AddToLinkedControls(ucrReceiverEvap, {rdoEvapVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlEvap.SetLinkedDisplayControl(lblWBEvaporation)
        ucrPnlElements.SetLinkedDisplayControl(grpElements)
        ucrNudDecimal.SetLinkedDisplayControl(lstLabels)
        ucrReceiverYear.SetLinkedDisplayControl(grpTransform)


    End Sub

    Private Sub SetDefaults()
        clsRTransform = New RFunction
        clsOverallTransformFunction = New RFunction
        clsTransformManipulationsFunc = New RFunction
        clsRTransformCountSpellSub = New RFunction

        clsPrecipitationFunction = New RFunction
        clsTemperatureFunction = New RFunction
        clsWindSpeedFunction = New RFunction

        clsRMovingFunction = New RFunction
        clsRasterFuction = New RFunction
        clsGroupByYear.Clear()
        clsReplaceNAasElement = New RFunction
        clsRCountFunction = New RFunction
        clsRWaterBalanceFunction = New RFunction

        clsRRaindayMatch = New RFunction
        clsRCountFunction = New RFunction
        clsRRaindayAndOperator = New ROperator
        clsRRaindayLowerOperator = New ROperator
        clsRRaindayUpperOperator = New ROperator
        clsRCountOperator = New ROperator

        clsPMinFunctionMax = New RFunction
        clsPMaxFunctionMax = New RFunction
        clsPMaxOperatorMax = New ROperator
        clsReduceOpEvapValue.Clear()
        clsGreaterThanOperator.Clear()
        clsLessThanOperator.Clear()

        ucrSelectorTransform.Reset()
        ucrReceiverData.SetMeAsReceiver()
        ucrInputFromPrecipitation.SetName("inches")
        ucrInputToPrecipitation.SetName("mm")

        'Conversion
        clsPrecipitationFunction.bToScriptAsRString = True
        clsPrecipitationFunction.SetPackageName("weathermetrics")
        clsPrecipitationFunction.SetRCommand("convert_precip")
        clsPrecipitationFunction.AddParameter("round", 1, iPosition:=3)
        clsPrecipitationFunction.AddParameter("old_metric", Chr(34) & "inches" & Chr(34), iPosition:=1)
        clsPrecipitationFunction.AddParameter("new_metric", Chr(34) & "mm" & Chr(34), iPosition:=2)

        clsTemperatureFunction.SetPackageName("weathermetrics")
        clsTemperatureFunction.SetRCommand("convert_temperature")

        clsWindSpeedFunction.SetPackageName("weathermetrics")
        clsWindSpeedFunction.SetRCommand("convert_wind_speed")

        ' Count and Spells: Rainday
        clsRRaindayMatch.bToScriptAsRString = True
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRRainday.AddParameter("function_exp", clsRFunctionParameter:=clsRRaindayMatch, iPosition:=1)
        clsRRainday.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsRRainday.SetAssignTo("rain_day")

        clsRRaindayMatch.SetRCommand("match")
        clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator)
        clsRRaindayAndOperator.SetOperation("&")
        clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
        clsRRaindayLowerOperator.SetOperation("<=")
        clsRRaindayLowerOperator.AddParameter("min", 0, iPosition:=1)
        clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        clsRRaindayUpperOperator.SetOperation(">=")
        clsRRaindayUpperOperator.AddParameter("max", 0.85, iPosition:=1)
        clsRRaindayMatch.AddParameter("table", "1", iPosition:=1)
        clsRRaindayMatch.AddParameter("nomatch", "0", iPosition:=2)

        clsGreaterThanOperator.SetOperation(">")
        clsLessThanOperator.SetOperation("<")

        ' Count
        clsRCountFunction.bToScriptAsRString = True
        clsRCountFunction.SetPackageName("zoo")
        clsRCountFunction.SetRCommand("rollapply")
        clsRCountFunction.AddParameter("data", strRainDay, iPosition:=0)
        clsRCountFunction.AddParameter("width", 2, iPosition:=1)
        clsRCountFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsRCountFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)
        clsRCountFunction.AddParameter("fill", "NA", iPosition:=5)

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
        clsRMovingFunction.bToScriptAsRString = True
        clsRMovingFunction.SetPackageName("zoo")
        clsRMovingFunction.SetRCommand("rollapply")
        clsRMovingFunction.AddParameter("width", 3, iPosition:=1)
        clsRMovingFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsRMovingFunction.AddParameter("fill", "NA", iPosition:=3)
        clsRMovingFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)

        clsRasterFuction.bToScriptAsRString = True
        clsRasterFuction.SetPackageName("raster")
        clsRasterFuction.SetRCommand("movingFun")
        clsRasterFuction.AddParameter("n", 3, iPosition:=1)
        clsRasterFuction.AddParameter("circular", "FALSE", iPosition:=2)
        clsRasterFuction.AddParameter("fun", "sum", iPosition:=3)
        clsRasterFuction.AddParameter("type", Chr(39) & "to" & Chr(39), iPosition:=4)
        clsRasterFuction.AddParameter("na.rm", "TRUE", iPosition:=5)

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
        'clsPMaxOperatorMax.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMax.AddParameter("capacity", 60, iPosition:=1, bIncludeArgumentName:=False)
        clsRWaterBalanceFunction.AddParameter("replace_na", iPosition:=1, bIncludeArgumentName:=False)
        clsRWaterBalanceFunction.AddParameter("accumulate", "TRUE", iPosition:=2)
        '"Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Rain, accumulate=TRUE)" & Chr(34))

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
        'clsTransformManipulationsFunc.AddParameter("group_by_year", clsRFunctionParameter:=clsGroupByYear, bIncludeArgumentName:=False, iPosition:=0)

        clsRTransform.SetRCommand("instat_calculation$new")
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsPrecipitationFunction, iPosition:=1) ' changes depending on the rdo
        clsRTransform.AddParameter("result_name", Chr(34) & "conversion" & Chr(34), iPosition:=2)
        clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=5)
        clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub, iPosition:=4)
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
        ucrReceiverData.AddAdditionalCodeParameterPair(clsPrecipitationFunction, New RParameter("precip", 0), iAdditionalPairNo:=1)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsTemperatureFunction, New RParameter("temperature", 0), iAdditionalPairNo:=2)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsWindSpeedFunction, New RParameter("wind_speed", 0), iAdditionalPairNo:=3)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("x", 0, False), iAdditionalPairNo:=4)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsReplaceNAasElement, New RParameter("element", 0, False), iAdditionalPairNo:=5)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRRaindayLowerOperator, New RParameter("rain", 0), iAdditionalPairNo:=6)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRRaindayUpperOperator, New RParameter("rain", 0), iAdditionalPairNo:=7)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRWaterBalanceFunction, New RParameter("replace_na", 1, False), iAdditionalPairNo:=8)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsReduceOpEvapValue, New RParameter("left", 0, False), iAdditionalPairNo:=9)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=10)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("rain", 0), iAdditionalPairNo:=11)
        ucrInputSpellUpper.AddAdditionalCodeParameterPair(clsGreaterThanOperator, New RParameter("left", 1), iAdditionalPairNo:=1)
        ucrInputSpellLower.AddAdditionalCodeParameterPair(clsLessThanOperator, New RParameter("left", 1), iAdditionalPairNo:=1)
        ucrNudSumOver.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("n", 1, False), iAdditionalPairNo:=1)
        ucrInputSum.AddAdditionalCodeParameterPair(clsRasterFuction, New RParameter("fun", 2), iAdditionalPairNo:=1)
        ucrNudDecimal.AddAdditionalCodeParameterPair(clsTemperatureFunction, (New RParameter("round", 3)), iAdditionalPairNo:=1)
        ucrNudDecimal.AddAdditionalCodeParameterPair(clsWindSpeedFunction, (New RParameter("round", 3)), iAdditionalPairNo:=2)

        ucrPnlTransform.SetRCode(clsTransformCheck, bReset)
        ucrChkGroupByYear.SetRCode(clsTransformManipulationsFunc, bReset)

        'Conversion
        ucrInputFromPrecipitation.SetRCode(clsPrecipitationFunction, bReset)
        ucrInputToPrecipitation.SetRCode(clsPrecipitationFunction, bReset)
        ucrInputFromTemperature.SetRCode(clsTemperatureFunction, bReset)
        ucrInputToTemperature.SetRCode(clsTemperatureFunction, bReset)
        ucrInputFromWindSpeed.SetRCode(clsWindSpeedFunction, bReset)
        ucrInputToWindSpeed.SetRCode(clsWindSpeedFunction, bReset)
        ucrNudDecimal.SetRCode(clsPrecipitationFunction, bReset)

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
        ucrInputEvaporation.SetRCode(clsPMaxOperatorMax, bReset)
        ucrReceiverEvap.SetRCode(clsReduceOpEvapValue, bReset)
        ucrNudWBCapacity.SetRCode(clsPMinFunctionMax, bReset)

        ucrInputColName.SetRCode(clsRTransform, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverData.IsEmpty AndAlso Not ucrInputColName.IsEmpty AndAlso ((rdoCount.Checked AndAlso ucrNudCountOver.GetText <> "" AndAlso ((ucrInputCondition.GetText = "Between" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = "<=" AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = ">=" AndAlso Not ucrInputSpellUpper.IsEmpty))) OrElse (rdoMoving.Checked AndAlso Not ucrInputSum.IsEmpty AndAlso ucrNudSumOver.GetText <> "") OrElse (rdoSpell.Checked AndAlso ((ucrInputCondition.GetText = "Between" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = "Outer" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = "<=" AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = ">=" AndAlso Not ucrInputSpellUpper.IsEmpty))) OrElse (rdoMultSpells.Checked AndAlso ucrNudMultSpells.GetText <> "" AndAlso ((ucrInputCondition.GetText = "Between" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = "<=" AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (ucrInputCondition.GetText = ">=" AndAlso Not ucrInputSpellUpper.IsEmpty))) OrElse (rdoWaterBalance.Checked AndAlso ucrNudWBCapacity.GetText <> "" AndAlso ((rdoEvapValue.Checked AndAlso Not ucrInputEvaporation.IsEmpty) OrElse (rdoEvapVariable.Checked AndAlso Not ucrReceiverEvap.IsEmpty)))) Then
            ucrBase.OKEnabled(True)
        ElseIf rdoConversion.Checked AndAlso Not ucrReceiverData.IsEmpty Then
            If rdoRain.Checked AndAlso ucrInputFromPrecipitation.GetText <> ucrInputToPrecipitation.GetText Then
                ucrBase.OKEnabled(True)
            ElseIf rdoTemperature.Checked AndAlso ucrInputFromTemperature.GetText <> ucrInputToTemperature.GetText Then
                ucrBase.OKEnabled(True)
            ElseIf rdoWindSpeed.Checked AndAlso ucrInputFromWindSpeed.GetText <> ucrInputToWindSpeed.GetText Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
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
                clsRRaindayAndOperator.RemoveParameterByName("upper")
                clsRRaindayUpperOperator.RemoveParameterByName("max")
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
            Case "Outer"
                ucrInputSpellLower.Visible = True
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsGreaterThanOperator, iPosition:=0)
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsLessThanOperator, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=2)
            Case ">="
                clsRRaindayAndOperator.RemoveParameterByName("lower")
                clsRRaindayLowerOperator.RemoveParameterByName("min")
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        End Select
    End Sub

    Private Sub ucrPnlTransform_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlValueChanged
        If rdoConversion.Checked Then
            Conversion()
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
            clsRTransform.AddParameter("function_exp", Chr(34) & "consecutive_sum(x = " & strRainDay & ", initial_value = NA)" & Chr(34), iPosition:=1)
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
        End If
        RasterPosition()
        ReceiverLocation()
    End Sub

    Private Sub SetAssignName()
        If rdoConversion.Checked Then
            ucrInputColName.SetName("conversion")
        ElseIf rdoCount.Checked Then
            ucrInputColName.SetName("count")
        ElseIf rdoMoving.Checked Then
            MovingColNames()
        ElseIf rdoSpell.Checked Then
            ucrInputColName.SetName("spell")
        ElseIf rdoMultSpells.Checked Then
            ucrInputColName.SetName("spells")
        ElseIf rdoWaterBalance.Checked Then
            ucrInputColName.SetName("water")
        End If
    End Sub

    Private Sub MovingColNames()
        Select Case ucrInputSum.GetText
            Case "Sum"
                ucrInputColName.SetName("moving_sum")
            Case "Maximum"
                ucrInputColName.SetName("moving_max")
            Case "Minimum"
                ucrInputColName.SetName("moving_min")
            Case "Mean"
                ucrInputColName.SetName("moving_mean")
            Case "Median"
                ucrInputColName.SetName("moving_median")
            Case Else
                ucrInputColName.SetName("moving")
        End Select
    End Sub

    Private Sub GroupByYear()
        If ucrChkGroupByYear.Checked() Then
            clsGroupByYear.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=3)
        Else
            clsGroupByYear.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub GroupByStation()
        If Not ucrReceiverStation.IsEmpty() Then
            clsGroupByStation.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=3)
            clsTransformManipulationsFunc.AddParameter("group_by_station", clsRFunctionParameter:=clsGroupByStation, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsGroupByStation.RemoveParameterByName("calculated_from")
            clsTransformManipulationsFunc.RemoveParameterByName("group_by_station")
        End If
    End Sub

    Private Sub RainDays()
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")", iPosition:=3)
        clsRTransform.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames & ")", iPosition:=3)
    End Sub

    Private Sub Evaporation()
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
    End Sub

    Private Sub ucrSelectorTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        RainDays()
        GroupByYear()
        GroupByStation()
        Evaporation()
    End Sub

    Private Sub ucrInputSpellLower_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpellLower.ControlValueChanged, ucrInputSpellUpper.ControlValueChanged, ucrInputCondition.ControlValueChanged
        InputConditionOptions()
    End Sub

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged, ucrReceiverEvap.ControlValueChanged
        RainDays()
        Evaporation()
        TestOkEnabled()
        ReceiverLocation()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByStation()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByYear()
        ReceiverLocation()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverData.ControlContentsChanged, ucrNudSumOver.ControlContentsChanged, ucrNudCountOver.ControlContentsChanged, ucrInputSpellLower.ControlContentsChanged, ucrInputSpellUpper.ControlContentsChanged, ucrInputCondition.ControlContentsChanged, ucrInputColName.ControlContentsChanged, ucrNudWBCapacity.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrPnlTransform.ControlContentsChanged
        SetAssignName()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputSum_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputSum.ControlContentsChanged
        MovingColNames()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkGroupByYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkGroupByYear.ControlValueChanged
        GroupByYear()
    End Sub

    Private Sub ucrInputEvaporation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputEvaporation.ControlContentsChanged
        Evaporation()
    End Sub

    Private Sub ucrPnlEvap_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlEvap.ControlContentsChanged
        Evaporation()
        TestOkEnabled()
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

    Private Sub RasterPosition()
        If rdoMoving.Checked Then
            If ucrChkCircular.Checked Then
                ucrInputCircularPosition.Show()
                ucrInputPosition.Hide()
            Else
                ucrInputCircularPosition.Hide()
                ucrInputPosition.Show()
            End If
        End If
    End Sub

    Private Sub Conversion()
        If rdoConversion.Checked Then
            If rdoRain.Checked Then
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsPrecipitationFunction, iPosition:=1)
            ElseIf rdoTemperature.Checked Then
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsTemperatureFunction, iPosition:=1)
            ElseIf rdoWindSpeed.Checked Then
                clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsWindSpeedFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrInputCircularPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCircularPosition.ControlValueChanged, ucrInputPosition.ControlValueChanged
        RasterPosition()
    End Sub

    Private Sub ucrChkCircular_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCircular.ControlValueChanged
        RasterPosition()
        RasterFunction()
    End Sub

    Private Sub ucrPnlElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlElements.ControlValueChanged
        Conversion()
    End Sub

    Private Sub ReceiverLocation()
        If rdoConversion.Checked Then
            lblData.Location = New Point(lblData.Location.X, iReceiverLabelMaxY / 1.3)
            ucrReceiverData.Location = New Point(ucrReceiverData.Location.X, iReceiverMaxY / 1.27)
            lblYear.Visible = False
            ucrReceiverYear.Visible = False
        Else
            lblData.Location = New Point(lblData.Location.X, iReceiverLabelMaxY)
            ucrReceiverData.Location = New Point(ucrReceiverData.Location.X, iReceiverMaxY)
            lblYear.Visible = True
            ucrReceiverYear.Visible = True
        End If
    End Sub
End Class