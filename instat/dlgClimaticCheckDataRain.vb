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
Public Class dlgClimaticCheckDataRain
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataName As String = ""
    'Large/Same/wetdays
    Private clsGroupByFunc, clsRainFilterFunc, clsRunCalcFunc, clsListFunc, clsGroupByMonth As New RFunction
    'Large 
    Private clsLargeTestCalcFunc As New RFunction
    Private clsLargeOperator, clsOrLargeOperator, clsLargeLessOperator, clsRainyDaysOperator As New ROperator
    Private clsManipList As New RFunction
    Private strLargeTest As String = "Large"
    'Same
    Private clsRleFunc, clsRepFunc, clsAsNumericFunc As New RFunction
    Private clsSameCalcFunc, clsSameTestFunc As New RFunction
    Private clsAndOperator, clsDollarOperator, clsGreaterSameOperator As New ROperator
    Private clsSameList As New RFunction
    Private strSameCalc As String = "same"
    Private strSameTestCalc As String = "Same"
    'Wetdays
    Private clsCumSumFuc, clsCumMaxFunc As New RFunction
    Private clsGreaterOperator, clsMinusOperator, clsMultiplOperator, clsGreatOperator, clsEqualOperator As New ROperator
    Private clsCumulativeCalcFunc, clsCumulativeTestFunc As New RFunction
    Private clsCumulativeList As New RFunction
    Private strCumulativeCalc As String = "Wet_days"
    Private strCumulativeTestCalc As String = "wet_days"
    Private strDryMonthCalc As String = "dry_month"
    Private strDryMonthTestCalc As String = "dry_month_calc"
    'Dry Month
    Private clsGroupByMonthYearFunction, clsDryMonthCalculationFunc, clsListCalcFunction, clsSumFuction, clsDryMonthTestCalculationFunc, clsListTestFunction, clsNotIsNaFunction, clsDrySumFuction, clsFilterMonthFunction, clsGroupByListFunc As New RFunction
    Private clsDryMonthEqualOperator, clsDryMonthAndOperator, clsLessOperator, clsDryTestAndOperator, clsInOperator, clsNotOperator As New ROperator

    'Combined Filters
    Private clsOrOperator As New ROperator
    Private clsListSubCalc As New RFunction
    'Outlier 
    Private clsListForOutlierManipulations, clsRainyDaysFunc, clsUpperOutlierLimitFunc, clsUpperOutlierLimitValueCalcFunc, clsUpperOutlierlimitTestFunc, clsUpperListOutlier As New RFunction
    Private clsUpperOutlierOperator As New ROperator
    Private strUpperOutlierTest As String = "upper_outlier"
    Private clsLowerOutlierLimitValueCalcFunc, clsLowerOutlierlimitTestFunc, clsLowerListOutlier, clsLowerOutlierLimitFunc As New RFunction
    Private clsLowerOutlierOperator As New ROperator
    Private strLowerOutlierTest As String = "lower_outlier"
    Private clsOutliersOperator As New ROperator
    Private bResetSubdialog As Boolean = False

    Private Sub dlgRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        setRcodeForControls(bReset)
        If bFirstload Then
            AutoFillRainColumn()
            bFirstload = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 511
        Dim lstControls As New List(Of Control)
        lstControls.AddRange({lblMissingThreshold, cmdOmitMonths, lblThresholdmm})

        ucrReceiverStation.Selector = ucrSelectorRain
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorRain
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDay.Selector = ucrSelectorRain
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        ucrReceiverMonth.Selector = ucrSelectorRain
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("left", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement.Selector = ucrSelectorRain
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False

        ucrNudLarge.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrNudLarge.SetMinMax(iNewMin:=Integer.MinValue, iNewMax:=Integer.MaxValue)

        ucrReceiverDate.Selector = ucrSelectorRain
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True

        ucrChkLarge.SetParameter(New RParameter("large", strLargeTest, 1), bNewChangeParameterValue:=False)
        ucrChkLarge.SetText("Large")

        ucrChkSame.SetParameter(New RParameter("same", strSameTestCalc, 1), bNewChangeParameterValue:=False)
        ucrChkSame.SetText("Same")

        ucrChkWetDays.SetParameter(New RParameter("wet_days", strCumulativeTestCalc, 1, False), bNewChangeParameterValue:=False)
        ucrChkWetDays.SetText("Consecutive")

        ucrChkDryMonth.SetParameter(New RParameter("dry_month", strDryMonthCalc, 1, False), bNewChangeParameterValue:=False)
        ucrChkDryMonth.SetText("Dry Month")

        ucrNudSame.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrNudWetDays.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))

        ucrChkOutlier.SetParameter(New RParameter("outlier.limit", strUpperOutlierTest, 1), bNewChangeParameterValue:=False)
        ucrChkOutlier.SetText("Outlier")

        ucrNudCoeff.SetParameter(New RParameter("coef", 1))
        ucrNudCoeff.DecimalPlaces = 1
        ucrNudCoeff.Increment = 0.1
        ucrNudCoeff.SetRDefault("1.5")

        ucrInputThreshold.SetParameter(New RParameter("limit", 1))
        ucrInputThreshold.AddQuotesIfUnrecognised = False
        ucrInputThreshold.SetValidationTypeAsNumeric(dcmMin:=0)

        ucrNudSkewnessWeight.SetParameter(New RParameter("skewnessweight", 4))
        ucrNudSkewnessWeight.DecimalPlaces = 1
        ucrNudSkewnessWeight.Increment = 0.1
        ucrNudSkewnessWeight.SetRDefault("4")

        ucrChkOmitZero.SetParameter(New RParameter("omit", 7))
        ucrChkOmitZero.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitZero.SetText("Omit Zero")

        ucrInputThresholdValue.SetParameter(New RParameter("value", 8))
        ucrInputThresholdValue.AddQuotesIfUnrecognised = False
        ucrInputThresholdValue.SetValidationTypeAsNumeric()

        'Linking of controls
        ucrChkLarge.AddToLinkedControls(ucrNudLarge, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=200)
        ucrChkSame.AddToLinkedControls(ucrNudSame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrChkWetDays.AddToLinkedControls(ucrNudWetDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkDryMonth.AddToLinkedControls(ucrInputThreshold, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.05)
        ucrChkOutlier.AddToLinkedControls(ucrChkOmitZero, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkOutlier.AddToLinkedControls(ucrNudCoeff, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1.5)
        ucrChkOutlier.AddToLinkedControls(ucrNudSkewnessWeight, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4)
        ucrChkOmitZero.AddToLinkedControls(ucrInputThresholdValue, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrInputThreshold.SetLinkedDisplayControl(lstControls)
        ucrInputThresholdValue.SetLinkedDisplayControl(lblThreshold)
        ucrNudLarge.SetLinkedDisplayControl(lblmm)
        ucrNudSame.SetLinkedDisplayControl(lblDays)
        ucrNudWetDays.SetLinkedDisplayControl(lblRainDays)
        ucrNudSkewnessWeight.SetLinkedDisplayControl(lblSkewnessWeight)
        ucrNudCoeff.SetLinkedDisplayControl(lblCoeff)

        ucrChkCalculatedColumns.SetText("Calculated columns")
        ucrChkCalculatedColumns.SetParameter(New RParameter("save", 4))
        ucrChkCalculatedColumns.SetValuesCheckedAndUnchecked("2", "0")

        ucrChkLogicalColumns.SetText("Logical columns")
        ucrChkLogicalColumns.SetParameter(New RParameter("save", 4))
        ucrChkLogicalColumns.SetValuesCheckedAndUnchecked("2", "0")
    End Sub

    Private Sub SetDefaults()
        Dim strLengths As String = "lengths"
        Dim strUpperOutlierLimit As String = "outlier_upper_limit"
        Dim strLowerOutlierLimit As String = "outlier_lower_limit"
        clsRleFunc = New RFunction
        clsRepFunc = New RFunction
        clsAsNumericFunc = New RFunction
        clsAndOperator = New ROperator
        clsDollarOperator = New ROperator
        clsOrOperator = New ROperator
        clsEqualOperator = New ROperator
        clsLargeOperator = New ROperator
        clsLargeLessOperator = New ROperator
        clsInOperator = New ROperator
        clsNotOperator = New ROperator

        clsRainyDaysOperator.Clear()
        clsUpperOutlierOperator.Clear()
        clsOrLargeOperator.Clear()
        clsGreaterSameOperator.Clear()
        clsGreatOperator.Clear()

        clsRainFilterFunc.Clear()
        clsLargeTestCalcFunc.Clear()
        clsSameCalcFunc.Clear()
        clsCumulativeTestFunc.Clear()
        clsSameTestFunc.Clear()
        clsCumulativeCalcFunc.Clear()
        clsUpperOutlierlimitTestFunc.Clear()
        clsListForOutlierManipulations.Clear()
        clsDryMonthCalculationFunc.Clear()
        clsGroupByMonthYearFunction.Clear()
        clsListCalcFunction.Clear()
        clsSumFuction.Clear()
        clsDryMonthTestCalculationFunc.Clear()
        clsListTestFunction.Clear()
        clsNotIsNaFunction.Clear()
        clsDrySumFuction.Clear()
        clsFilterMonthFunction.Clear()
        clsGroupByListFunc.Clear()
        clsDryMonthEqualOperator.Clear()
        clsDryMonthAndOperator.Clear()
        clsLessOperator.Clear()
        clsDryTestAndOperator.Clear()
        clsInOperator.Clear()
        clsNotOperator.Clear()

        ucrSelectorRain.Reset()
        ucrReceiverElement.SetMeAsReceiver()

        bResetSubdialog = True

        'Group Function
        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunc.SetAssignTo("grouping")

        clsListFunc.SetRCommand("list")
        clsListFunc.AddParameter("sub1", clsRFunctionParameter:=clsGroupByFunc, bIncludeArgumentName:=False, iPosition:=1)

        'Main Filter
        clsRainFilterFunc.SetRCommand("instat_calculation$new")
        clsRainFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsRainFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator, iPosition:=1)
        clsRainFilterFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsListSubCalc, iPosition:=2)
        clsRainFilterFunc.AddParameter("result_data_frame", Chr(34) & "qcRain" & Chr(34), iPosition:=4)
        clsRainFilterFunc.AddParameter("save", 2, iPosition:=5)
        clsRainFilterFunc.SetAssignTo("rainfall_filter")

        clsListSubCalc.SetRCommand("list")

        clsManipList.SetRCommand("list")
        clsManipList.AddParameter("manip1", clsRFunctionParameter:=clsGroupByFunc, bIncludeArgumentName:=False)

        'Large
        clsLargeOperator.SetOperation(">")
        clsLargeOperator.AddParameter("left", iPosition:=0)
        clsOrLargeOperator.SetOperation("|")
        clsOrLargeOperator.bBrackets = False
        clsOrLargeOperator.bToScriptAsRString = True
        clsOrLargeOperator.bSpaceAroundOperation = False
        clsOrLargeOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsLargeOperator, iPosition:=0)
        clsOrLargeOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsLargeLessOperator, iPosition:=1)
        clsLargeLessOperator.SetOperation("<")
        clsLargeLessOperator.AddParameter("right", bIncludeArgumentName:=False, strParameterValue:="-1E-8", iPosition:=1)

        clsLargeTestCalcFunc.SetRCommand("instat_calculation$new")
        clsLargeTestCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsLargeTestCalcFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrLargeOperator, iPosition:=1)
        clsLargeTestCalcFunc.AddParameter("result_name", Chr(34) & strLargeTest & Chr(34))
        clsLargeTestCalcFunc.SetAssignTo("large_test_calculation")

        'Same
        clsGreaterOperator.SetOperation(">")
        clsGreaterOperator.AddParameter("y", "0", iPosition:=1, bIncludeArgumentName:=False)

        clsAndOperator.SetOperation("&")
        clsAndOperator.bBrackets = False
        clsAndOperator.bToScriptAsRString = True
        clsAndOperator.AddParameter("left", clsROperatorParameter:=clsGreaterSameOperator, iPosition:=0)
        clsAndOperator.AddParameter("right", clsROperatorParameter:=clsGreaterOperator, iPosition:=1)

        clsGreaterSameOperator.SetOperation(">=")
        clsGreaterSameOperator.AddParameter("left", bIncludeArgumentName:=False, strParameterValue:=strSameCalc, iPosition:=0)

        clsAsNumericFunc.SetRCommand("as.numeric")

        clsRleFunc.SetRCommand("rle")
        clsRleFunc.AddParameter("numeric", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumericFunc, iPosition:=0)

        clsDollarOperator.SetOperation("$")
        clsDollarOperator.bSpaceAroundOperation = False
        clsDollarOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRleFunc, iPosition:=0)
        clsDollarOperator.AddParameter("right", bIncludeArgumentName:=False, strParameterValue:=strLengths, iPosition:=1)

        clsRepFunc.SetRCommand("rep")
        clsRepFunc.AddParameter("first", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=0)
        clsRepFunc.AddParameter("second", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=1)
        clsRepFunc.bToScriptAsRString = True

        clsSameCalcFunc.SetRCommand("instat_calculation$new")
        clsSameCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsSameCalcFunc.AddParameter("function_exp", clsRFunctionParameter:=clsRepFunc, iPosition:=1)
        clsSameCalcFunc.AddParameter("result_name", Chr(34) & strSameCalc & Chr(34))
        clsSameCalcFunc.SetAssignTo("same_calculation")

        clsSameTestFunc.SetRCommand("instat_calculation$new")
        clsSameTestFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsSameTestFunc.AddParameter("function_exp", clsROperatorParameter:=clsAndOperator, iPosition:=1)
        clsSameTestFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsSameList, iPosition:=2)
        clsSameTestFunc.AddParameter("result_name", Chr(34) & strSameTestCalc & Chr(34))
        clsSameTestFunc.SetAssignTo("same_test_calculation")

        clsSameList.SetRCommand("list")
        clsSameList.AddParameter("sub1", clsRFunctionParameter:=clsSameCalcFunc, bIncludeArgumentName:=False)

        'Wet
        clsEqualOperator.SetOperation("==")
        clsEqualOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)
        clsEqualOperator.AddParameter("right", "0", bIncludeArgumentName:=False, iPosition:=1)
        clsCumSumFuc.SetRCommand("cumsum")
        clsGreatOperator.SetOperation(">")
        clsGreatOperator.bToScriptAsRString = True
        clsGreatOperator.AddParameter("left", bIncludeArgumentName:=False, strParameterValue:=strCumulativeCalc, iPosition:=0)
        clsMinusOperator.SetOperation("-")
        clsMinusOperator.bToScriptAsRString = True
        clsMinusOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumSumFuc, iPosition:=0)
        clsMinusOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumMaxFunc, iPosition:=1)
        clsCumMaxFunc.SetRCommand("cummax")
        clsCumMaxFunc.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsMultiplOperator, iPosition:=0)
        clsMultiplOperator.SetOperation("*")
        clsMultiplOperator.bSpaceAroundOperation = False
        clsMultiplOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsEqualOperator, iPosition:=0)
        clsMultiplOperator.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsCumSumFuc, iPosition:=1)
        clsCumSumFuc.AddParameter("x", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterOperator, iPosition:=0)

        clsCumulativeCalcFunc.SetRCommand("instat_calculation$new")
        clsCumulativeCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCumulativeCalcFunc.AddParameter("function_exp", clsROperatorParameter:=clsMinusOperator, iPosition:=1)
        clsCumulativeCalcFunc.AddParameter("result_name", Chr(34) & strCumulativeCalc & Chr(34))
        clsCumulativeCalcFunc.SetAssignTo("cumulative_calculation")

        clsCumulativeTestFunc.SetRCommand("instat_calculation$new")
        clsCumulativeTestFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCumulativeTestFunc.AddParameter("function_exp", clsROperatorParameter:=clsGreatOperator, iPosition:=1)
        clsCumulativeTestFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsCumulativeList, iPosition:=2)
        clsCumulativeTestFunc.AddParameter("result_name", Chr(34) & strCumulativeTestCalc & Chr(34))
        clsCumulativeTestFunc.SetAssignTo("cumulative_test_calculation")

        clsCumulativeList.SetRCommand("list")
        clsCumulativeList.AddParameter("sub1", clsRFunctionParameter:=clsCumulativeCalcFunc, bIncludeArgumentName:=False)

        'Group By Month 
        clsGroupByMonth.SetRCommand("instat_calculation$new")
        clsGroupByMonth.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByMonth.SetAssignTo("grouping_month")

        clsGroupByMonthYearFunction.SetRCommand("instat_calculation$new")
        clsGroupByMonthYearFunction.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByMonthYearFunction.SetAssignTo("grouping_month_year")

        clsGroupByListFunc.SetRCommand("list")
        clsGroupByListFunc.AddParameter("group", clsRFunctionParameter:=clsGroupByMonthYearFunction, bIncludeArgumentName:=False)

        clsListForOutlierManipulations.SetRCommand("list")
        clsListForOutlierManipulations.AddParameter("sub1", clsRFunctionParameter:=clsGroupByMonth, bIncludeArgumentName:=False, iPosition:=0)
        'clsListForOutlierManipulations.AddParameter("sub2", clsRFunctionParameter:=clsRainyDaysFunc, bIncludeArgumentName:=False, iPosition:=1)

        'Rainy Days Operator
        clsRainyDaysOperator.SetOperation(">")
        clsRainyDaysOperator.AddParameter("left", iPosition:=0)
        clsRainyDaysOperator.AddParameter("right", "0.85", iPosition:=1, bIncludeArgumentName:=False)
        clsRainyDaysOperator.bBrackets = True
        clsRainyDaysOperator.bToScriptAsRString = True

        clsRainyDaysFunc.SetRCommand("instat_calculation$new")
        clsRainyDaysFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsRainyDaysFunc.AddParameter("function_exp", clsROperatorParameter:=clsRainyDaysOperator, iPosition:=0)
        clsRainyDaysFunc.SetAssignTo("rainydays_filter")

        'upper Outlier Limit function
        clsUpperOutlierLimitValueCalcFunc.SetRCommand("instat_calculation$new")
        clsUpperOutlierLimitValueCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsUpperOutlierLimitValueCalcFunc.AddParameter("function_exp", clsRFunctionParameter:=clsUpperOutlierLimitFunc, iPosition:=1)
        clsUpperOutlierLimitValueCalcFunc.AddParameter("result_name", Chr(34) & strUpperOutlierLimit & Chr(34), iPosition:=4)
        clsUpperOutlierLimitValueCalcFunc.SetAssignTo("outlier_upper_limit")
        clsUpperOutlierLimitFunc.SetRCommand("summary_outlier_limit")
        clsUpperOutlierLimitFunc.bToScriptAsRString = True
        clsUpperOutlierLimitFunc.AddParameter("bskewedcalc", "TRUE", iPosition:=4)
        clsUpperOutlierLimitFunc.AddParameter("omit", "TRUE", iPosition:=7)

        'Outlier Operator 
        clsUpperOutlierOperator.SetOperation(">")
        clsUpperOutlierOperator.AddParameter("right", strUpperOutlierLimit, iPosition:=1)
        clsUpperOutlierOperator.bBrackets = False
        clsUpperOutlierOperator.bToScriptAsRString = True

        clsUpperOutlierlimitTestFunc.SetRCommand("instat_calculation$new")
        clsUpperOutlierlimitTestFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsUpperOutlierlimitTestFunc.AddParameter("function_exp", clsROperatorParameter:=clsUpperOutlierOperator, iPosition:=1)
        clsUpperOutlierlimitTestFunc.AddParameter("result_name", Chr(34) & strUpperOutlierTest & Chr(34))
        clsUpperOutlierlimitTestFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsUpperListOutlier)
        clsUpperOutlierlimitTestFunc.SetAssignTo("outlier_upper_test_calculation")

        clsUpperListOutlier.SetRCommand("list")
        clsUpperListOutlier.AddParameter("sub1", clsRFunctionParameter:=clsUpperOutlierLimitValueCalcFunc, bIncludeArgumentName:=False)

        'lower Outlier Limit function
        clsLowerOutlierLimitValueCalcFunc.SetRCommand("instat_calculation$new")
        clsLowerOutlierLimitValueCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsLowerOutlierLimitValueCalcFunc.AddParameter("function_exp", clsRFunctionParameter:=clsLowerOutlierLimitFunc, iPosition:=1)
        clsLowerOutlierLimitValueCalcFunc.AddParameter("result_name", Chr(34) & strLowerOutlierLimit & Chr(34), iPosition:=4)
        clsLowerOutlierLimitValueCalcFunc.SetAssignTo("outlier_lower_limit")

        clsLowerOutlierLimitFunc.SetRCommand("summary_outlier_limit")
        clsLowerOutlierLimitFunc.bToScriptAsRString = True
        clsLowerOutlierLimitFunc.AddParameter("bskewedcalc", "FALSE")

        'Outlier Operator 
        clsLowerOutlierOperator.SetOperation("<")
        clsLowerOutlierOperator.AddParameter("right", strLowerOutlierLimit, iPosition:=1)
        clsLowerOutlierOperator.bBrackets = False
        clsLowerOutlierOperator.bToScriptAsRString = True

        clsLowerOutlierlimitTestFunc.SetRCommand("instat_calculation$new")
        clsLowerOutlierlimitTestFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsLowerOutlierlimitTestFunc.AddParameter("function_exp", clsROperatorParameter:=clsLowerOutlierOperator, iPosition:=1)
        clsLowerOutlierlimitTestFunc.AddParameter("result_name", Chr(34) & strLowerOutlierTest & Chr(34))
        clsLowerOutlierlimitTestFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsLowerListOutlier)
        clsLowerOutlierlimitTestFunc.SetAssignTo("outlier_lower_test_calculation")

        clsLowerListOutlier.SetRCommand("list")
        clsLowerListOutlier.AddParameter("sub1", clsRFunctionParameter:=clsLowerOutlierLimitValueCalcFunc, bIncludeArgumentName:=False)

        clsOutliersOperator.SetOperation(",")
        clsOutliersOperator.AddParameter("sub1", clsRFunctionParameter:=clsUpperOutlierlimitTestFunc, bIncludeArgumentName:=False)

        'Removed this sub_claculation because lower limit is not of interest for rainfall data.
        'clsOutliersOperator.AddParameter("sub2", clsRFunctionParameter:=clsLowerOutlierlimitTestFunc, bIncludeArgumentName:=False)

        'Combined filters
        clsOrOperator.SetOperation("|")
        clsOrOperator.bBrackets = True
        clsOrOperator.bToScriptAsRString = True

        'Dry Month Calculations
        clsFilterMonthFunction.SetRCommand("instat_calculation$new")
        clsFilterMonthFunction.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsFilterMonthFunction.AddParameter("function_exp", clsROperatorParameter:=clsInOperator, iPosition:=1)
        clsFilterMonthFunction.AddParameter("manipulations", clsRFunctionParameter:=clsGroupByListFunc, iPosition:=3)
        clsFilterMonthFunction.SetAssignTo("filter_months")

        clsInOperator.SetOperation("%in%")
        clsInOperator.AddParameter("not_month", clsROperatorParameter:=clsNotOperator, iPosition:=0)
        clsInOperator.bBrackets = False
        clsInOperator.bToScriptAsRString = True

        clsNotOperator.SetOperation("!")
        clsNotOperator.bSpaceAroundOperation = False
        clsNotOperator.AddParameter("space", "", iPosition:=0)

        clsDryMonthCalculationFunc.SetRCommand("instat_calculation$new")
        clsDryMonthCalculationFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDryMonthCalculationFunc.AddParameter("function_exp", clsROperatorParameter:=clsDryMonthAndOperator, iPosition:=1)
        clsDryMonthCalculationFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListCalcFunction, iPosition:=3)
        clsDryMonthCalculationFunc.AddParameter("result_name", Chr(34) & strDryMonthCalc & Chr(34), iPosition:=4)
        clsDryMonthCalculationFunc.SetAssignTo("dry_month_calculation")

        clsListCalcFunction.SetRCommand("list")
        clsListCalcFunction.AddParameter("group", clsRFunctionParameter:=clsFilterMonthFunction, bIncludeArgumentName:=False)

        clsDryMonthEqualOperator.SetOperation("==")
        clsDryMonthEqualOperator.AddParameter("sum", clsRFunctionParameter:=clsSumFuction, iPosition:=0)
        clsDryMonthEqualOperator.AddParameter("zero", 0, iPosition:=1)

        clsSumFuction.SetRCommand("sum")

        clsLessOperator.SetOperation("<")
        clsLessOperator.AddParameter("and", clsRFunctionParameter:=clsDrySumFuction, iPosition:=0)
        clsLessOperator.AddParameter("limit", 0.05, iPosition:=1)

        clsDryMonthAndOperator.SetOperation("&")
        clsDryMonthAndOperator.AddParameter("equal", clsROperatorParameter:=clsDryMonthEqualOperator, iPosition:=0)
        clsDryMonthAndOperator.AddParameter("sum", clsROperatorParameter:=clsLessOperator, iPosition:=1)
        clsDryMonthAndOperator.bToScriptAsRString = True
        clsDryMonthAndOperator.bBrackets = False

        clsDrySumFuction.SetRCommand("sum")

        clsDryTestAndOperator.SetOperation("&")
        clsDryTestAndOperator.AddParameter("!is.na", clsRFunctionParameter:=clsNotIsNaFunction, iPosition:=0)
        clsDryTestAndOperator.AddParameter("dry", strDryMonthTestCalc, iPosition:=1)
        clsDryTestAndOperator.bToScriptAsRString = True

        clsNotIsNaFunction.SetRCommand("!is.na")

        clsDryMonthTestCalculationFunc.SetRCommand("instat_calculation$new")
        clsDryMonthTestCalculationFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDryMonthTestCalculationFunc.AddParameter("function_exp", clsROperatorParameter:=clsDryTestAndOperator, iPosition:=1)
        clsDryMonthTestCalculationFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsListTestFunction, iPosition:=3)
        clsDryMonthTestCalculationFunc.AddParameter("result_name", Chr(34) & "dry_month" & Chr(34), iPosition:=4)
        clsDryMonthTestCalculationFunc.SetAssignTo("dry_month_test_calculation")

        clsListTestFunction.SetRCommand("list")
        clsListTestFunction.AddParameter("sub1", clsRFunctionParameter:=clsDryMonthCalculationFunc, bIncludeArgumentName:=False)

        ' Run Calc function
        clsRunCalcFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsRainFilterFunc)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub setRcodeForControls(bReset)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsGreaterOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsAsNumericFunc, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsLargeLessOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsUpperOutlierOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsUpperOutlierLimitFunc, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsRainyDaysOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=6)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsLowerOutlierLimitFunc, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=7)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsLowerOutlierOperator, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=8)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsSumFuction, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=9)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsNotIsNaFunction, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=10)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsDrySumFuction, New RParameter("rain", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=11)

        ucrChkLarge.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("large", strParamValue:=clsLargeTestCalcFunc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkSame.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("same", strParamValue:=clsSameTestFunc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkWetDays.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("wet_days", strParamValue:=clsCumulativeTestFunc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkOutlier.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("outlier", clsOutliersOperator, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkDryMonth.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("dry_month", clsDryMonthCalculationFunc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        'ucrChkCalculatedColumns.AddAdditionalCodeParameterPair(, New RParameter("save"), iAdditionalPairNo:=1)
        ucrChkCalculatedColumns.AddAdditionalCodeParameterPair(clsUpperOutlierLimitValueCalcFunc, New RParameter("save"), iAdditionalPairNo:=1)
        ucrChkCalculatedColumns.AddAdditionalCodeParameterPair(clsLowerOutlierLimitValueCalcFunc, New RParameter("save"), iAdditionalPairNo:=2)

        ucrChkLogicalColumns.AddAdditionalCodeParameterPair(clsSameTestFunc, New RParameter("save"), iAdditionalPairNo:=1)
        ucrChkLogicalColumns.AddAdditionalCodeParameterPair(clsCumulativeTestFunc, New RParameter("save"), iAdditionalPairNo:=2)
        ucrChkLogicalColumns.AddAdditionalCodeParameterPair(clsUpperOutlierlimitTestFunc, New RParameter("save"), iAdditionalPairNo:=3)
        ucrChkLogicalColumns.AddAdditionalCodeParameterPair(clsLowerOutlierlimitTestFunc, New RParameter("save"), iAdditionalPairNo:=4)
        'ucrChkLogicalColumns.AddAdditionalCodeParameterPair(clsDryMonthCalculationFunc, New RParameter("save"), iAdditionalPairNo:=5)

        ucrReceiverElement.SetRCode(clsLargeOperator, bReset)
        ucrNudLarge.SetRCode(clsLargeOperator, bReset)
        ucrNudSame.SetRCode(clsGreaterSameOperator, bReset)
        ucrNudWetDays.SetRCode(clsGreatOperator, bReset)
        'ucrReceiverMonth.SetRCode(clsNotEqualToOperator, bReset)

        ucrChkLarge.SetRCode(clsOrOperator, bReset)
        ucrChkSame.SetRCode(clsOrOperator, bReset)
        ucrChkWetDays.SetRCode(clsOrOperator, bReset)
        ucrChkDryMonth.SetRCode(clsOrOperator, bReset)
        ucrChkOmitZero.SetRCode(clsUpperOutlierLimitFunc, bReset)
        ucrInputThresholdValue.SetRCode(clsUpperOutlierLimitFunc, bReset)
        ucrNudCoeff.SetRCode(clsUpperOutlierLimitFunc, bReset)
        ucrInputThreshold.SetRCode(clsLessOperator, bReset)

        ucrChkOutlier.SetRCode(clsOrOperator, bReset)
        ucrNudSkewnessWeight.SetRCode(clsUpperOutlierLimitFunc, bReset)

        ucrChkLogicalColumns.SetRCode(clsLargeTestCalcFunc, bReset)
        ucrChkCalculatedColumns.SetRCode(clsCumulativeCalcFunc, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverElement.IsEmpty AndAlso ((ucrChkLarge.Checked AndAlso ucrNudLarge.GetText <> "") OrElse (ucrChkSame.Checked AndAlso ucrNudSame.GetText <> "") OrElse (ucrChkWetDays.Checked AndAlso ucrNudWetDays.GetText <> "") OrElse (ucrChkOutlier.Checked AndAlso ucrNudSkewnessWeight.GetText <> "" AndAlso ucrNudCoeff.GetText <> "") OrElse (ucrChkDryMonth.Checked AndAlso Not ucrInputThreshold.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        If ucrChkOutlier.Checked AndAlso ucrChkOmitZero.Checked AndAlso ucrInputThresholdValue.IsEmpty Then
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub CalculatedFromCalc()
        clsLargeTestCalcFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
        clsSameCalcFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "= " & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
        clsCumulativeCalcFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "= " & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
        clsUpperOutlierlimitTestFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "= " & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
        clsLowerOutlierlimitTestFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "= " & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
        clsLowerOutlierLimitValueCalcFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "= " & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
            clsRainFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsManipList, iPosition:=3)
        Else
            clsRainFilterFunc.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub GroupByMonth()
        If Not ucrReceiverMonth.IsEmpty Then
            clsGroupByMonth.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverMonth.GetVariableNames & ")", iPosition:=1)
            clsFilterMonthFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverMonth.GetVariableNames & ")", iPosition:=2)
            clsUpperOutlierLimitValueCalcFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
            clsLowerOutlierLimitValueCalcFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
        Else
            clsUpperOutlierLimitValueCalcFunc.RemoveParameterByName("manipulations")
            clsLowerOutlierLimitValueCalcFunc.RemoveParameterByName("manipulations")
        End If
        If Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupByMonthYearFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverMonth.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=1)
        End If
    End Sub

    Private Sub cmdOmitMonths_Click(sender As Object, e As EventArgs) Handles cmdOmitMonths.Click
        sdgSelectMonth.SetRCode(clsNewInOperator:=clsInOperator, ucrNewReceiverMonth:=ucrReceiverMonth, bReset:=bResetSubdialog)
        sdgSelectMonth.ShowDialog()
        bResetSubdialog = True
    End Sub

    Private Sub RainyDays()
        clsRainyDaysFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
        clsDryMonthCalculationFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub DryMonths()
        clsDryMonthTestCalculationFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverMonth.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub OutlierLimitCalc()
        clsUpperOutlierLimitValueCalcFunc.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        setRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverMonth.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverElement.ControlValueChanged
        clsNotOperator.AddParameter("Month", ucrReceiverMonth.GetVariableNames(False), iPosition:=1)
        GroupByOptions()
        GroupByMonth()
        DryMonths()
    End Sub

    Private Sub ucrSelectorRain_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRain.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorRain.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34)
        GroupByOptions()
        GroupByMonth()
        RainyDays()
        OutlierLimitCalc()
        AutoFillRainColumn()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrNudLarge.ControlValueChanged
        RainyDays()
        OutlierLimitCalc()
        CalculatedFromCalc()
        TestOkEnabled()
    End Sub

    Private Sub AutoFillRainColumn()
        Dim strRainCol As String
        Dim strDataFrame As String

        strDataFrame = ucrSelectorRain.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        strRainCol = frmMain.clsRLink.GetClimaticColumnOfType(strDataFrame, "rain_label")

        If strRainCol <> "" Then
            ucrReceiverElement.Add(strRainCol, strDataFrame)
        End If
    End Sub

    Private Sub ucrReceiverElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrChkLarge.ControlContentsChanged, ucrChkSame.ControlContentsChanged, ucrChkWetDays.ControlContentsChanged, ucrNudLarge.ControlContentsChanged, ucrNudSame.ControlContentsChanged, ucrNudWetDays.ControlContentsChanged, ucrChkOutlier.ControlContentsChanged, ucrChkOmitZero.ControlContentsChanged, ucrInputThresholdValue.ControlContentsChanged, ucrChkDryMonth.ControlContentsChanged, ucrInputThreshold.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class