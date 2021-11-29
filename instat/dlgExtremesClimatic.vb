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
Public Class dlgExtremesClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bUpdateMinMax As Boolean = True
    Private clsExtreme As New RFunction
    Private strCurrDataName As String = ""
    Private clsGroupByFunction, clsRunCalcFunction, clsDayFromAndTo, clsDayManipulation As New RFunction
    Private clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator As New ROperator
    Private clsCurrCalc As RFunction
    ' Min/Max Options
    Private clsMinMaxSummariseFunction, clsMinMaxManipulationsFunction, clsMinMaxFuncExp As New RFunction
    ' Peak Options
    Private clsPeaksFilterOperator As New ROperator
    Private clsPeaksFilterFunction As New RFunction

    'Carry column code
    Private clsCombinationCalc As New RFunction
    Private clsCombinationSubCalcs As New RFunction
    Private clsCombinationManipulations As New RFunction
    Private clsFirstDateSummary As New RFunction
    Private clsFirstFunction As New RFunction
    Private clsLastDateSummary As New RFunction
    Private clsLastFunction As New RFunction
    Private clsNSummary As New RFunction
    Private clsNFunction As New RFunction
    Private clsDateCarryCalcFromList As New RFunction
    Private clsFilterExtremeCalc As New RFunction
    Private clsFilterExtremeSubCalcs As New RFunction
    Private clsFilterExtremeExp As New ROperator

    Private clsPlotMrlFunction As New RFunction
    Private clsThresholdPlotFunction As New RFunction
    Private clsDeclusteringFunction As New RFunction
    Private clsDummyRfunction As New RFunction

    Private Sub dlgExtremesClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
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
        ucrBase.iHelpTopicID = 203
        Dim dctColours As New Dictionary(Of String, String)
        Dim dctDistributions As New Dictionary(Of String, String)

        ucrReceiverYear.Selector = ucrSelectorClimaticExtremes
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverStation.SetParameter(New RParameter("station_name", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorClimaticExtremes
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        '' What is Date used for in this?
        ucrReceiverDate.SetParameter(New RParameter("x", 0))
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.bWithQuotes = False
        ucrReceiverDate.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverElement.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement.Selector = ucrSelectorClimaticExtremes
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.bAutoFill = True
        ucrReceiverElement.strSelectorHeading = "Numerics"
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})

        ucrSelectorClimaticExtremes.SetParameter(New RParameter("data", 0))
        ucrSelectorClimaticExtremes.SetParameterIsrfunction()

        ' Panel Options
        ucrPnlExtremesType.AddRadioButton(rdoMinMax)
        ucrPnlExtremesType.AddRadioButton(rdoPeaks)
        ucrPnlExtremesType.AddRadioButton(rdoThreshold)
        ucrPnlExtremesType.AddParameterValuesCondition(rdoPeaks, "type", Chr(34) & "filter" & Chr(34))
        ucrPnlExtremesType.AddParameterValuesCondition(rdoMinMax, "type", {Chr(34) & "summary" & Chr(34), Chr(34) & "combination" & Chr(34)})
        ucrPnlExtremesType.AddFunctionNamesCondition(rdoThreshold, {"plot_mrl", "plot_multiple_threshold", "plot_declustered"})

        ucrPnlPlots.AddRadioButton(rdoMrlPlot)
        ucrPnlPlots.AddRadioButton(rdoThreshRangePlot)
        ucrPnlPlots.AddFunctionNamesCondition(rdoMrlPlot, "plot_mrl")
        ucrPnlPlots.AddFunctionNamesCondition(rdoThreshRangePlot, "plot_multiple_threshold")

        ' Min/Max Option
        ucrPnlMaxMin.AddRadioButton(rdoMax)
        ucrPnlMaxMin.AddRadioButton(rdoMin)
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMax, "max")
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMin, "min")

        ucrChkDeclustering.SetText("Declustering")
        ucrChkDeclustering.AddRSyntaxContainsFunctionNamesCondition(True, {"plot_declustered"})
        ucrChkDeclustering.AddRSyntaxContainsFunctionNamesCondition(False, {"plot_declustered"}, False)

        ucrChkFirstDate.SetText("Include First Date of Occurrence")
        ucrChkFirstDate.AddParameterPresentCondition(True, "sub1", True)
        ucrChkFirstDate.AddParameterPresentCondition(False, "sub1", False)

        ucrChkNDates.SetText("Include N Occurances")
        ucrChkNDates.AddParameterPresentCondition(True, "sub2", True)
        ucrChkNDates.AddParameterPresentCondition(False, "sub2", False)

        ucrChkLastDate.SetText("Include Last Date of Occurrence")
        ucrChkLastDate.AddParameterPresentCondition(True, "sub3", True)
        ucrChkLastDate.AddParameterPresentCondition(False, "sub3", False)

        ucrChkMissingValues.SetParameter(New RParameter("na.rm", 1))
        ucrChkMissingValues.SetText("Include Missing Values")
        ucrChkMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMissingValues.SetRDefault("FALSE")

        ' Peaks Option
        ucrInputThresholdValue.SetParameter(New RParameter("right", 1))
        ucrInputThresholdValue.SetValidationTypeAsNumeric()
        ucrInputThresholdValue.SetLinkedDisplayControl(lblValues)
        ucrInputThresholdValue.AddQuotesIfUnrecognised = False

        ucrInputThresholdOperator.SetParameter(New RParameter("function_exp", 1)) ' is it function_exp = OPERATOR?
        ' This is adding a new operator, this has been done before with functions, e.g. dlgScatterplot has a checkbox which adds or removes a function (geom_smooth)
        ' But here, the function added changes depending on which is selected from the combo box.
        ucrInputThresholdOperator.SetItems({"<", "<=", ">=", ">"})

        ucrInputThresholdOperator.AddParameterIsROperatorCondition("<", "<", True)
        ucrInputThresholdOperator.AddParameterIsROperatorCondition("<=", "<=", True)
        ucrInputThresholdOperator.AddParameterIsROperatorCondition(">", ">=", True)
        ucrInputThresholdOperator.AddParameterIsROperatorCondition(">", ">=", True)
        ucrInputThresholdOperator.SetDropDownStyleAsNonEditable()
        ucrInputThresholdOperator.AddQuotesIfUnrecognised = False

        ucrInputSave.SetParameter(New RParameter("result_name", 4))
        ucrInputSave.SetValidationTypeAsRVariable()

        ucrPnlExtremesType.AddToLinkedControls(ucrInputThresholdOperator, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=">=")
        ucrPnlExtremesType.AddToLinkedControls(ucrInputThresholdValue, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="60")
        ucrPnlExtremesType.AddToLinkedControls(ucrChkDeclustering, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrPnlMaxMin, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkMissingValues, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls({ucrChkFirstDate, ucrChkLastDate}, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrInputSave, {rdoMinMax, rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkNDates, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls({ucrNudColumns, ucrInputMin, ucrInputMax, ucrInputFill, ucrInputColours, ucrChkRugPlot}, {rdoMrlPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls({ucrNudThresholds, ucrNudThresholdColumns, ucrNudAlpha, ucrInputDistribution}, {rdoThreshRangePlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls({ucrPnlPlots}, {rdoThreshold}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls({ucrSaveMrlPlot}, {rdoMrlPlot}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPlots.AddToLinkedControls({ucrSaveThresholdPlot}, {rdoThreshRangePlot}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkRunLength.AddToLinkedControls({ucrNudRunLength}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkPrintSummary.AddToLinkedControls({ucrSaveDeclusteredPlot, ucrNudDeclusterColumns}, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDeclustering.AddToLinkedControls({ucrChkPrintSummary}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMaxMin.SetLinkedDisplayControl(lblNewColName)
        ucrPnlMaxMin.SetLinkedDisplayControl(lblNewColName)
        ucrChkMissingValues.SetLinkedDisplayControl(grpMinMaxOptions)
        ucrInputThresholdValue.SetLinkedDisplayControl(grpPeakOptions)
        ucrNudColumns.SetLinkedDisplayControl(lblColumns)
        ucrInputMin.SetLinkedDisplayControl(lblMinimum)
        ucrInputMax.SetLinkedDisplayControl(lblTo)
        ucrInputFill.SetLinkedDisplayControl(lblFill)
        ucrInputColours.SetLinkedDisplayControl(lblColour)
        ucrNudThresholds.SetLinkedDisplayControl(lblThresholds)
        ucrNudThresholdColumns.SetLinkedDisplayControl(lblThresholdColumns)
        ucrNudAlpha.SetLinkedDisplayControl(lblAlpha)
        ucrInputDistribution.SetLinkedDisplayControl(lblDistribution)
        ucrPnlPlots.SetLinkedDisplayControl(grpPlots)
        ucrInputMin.SetLinkedDisplayControl(grpMrlOptions)
        ucrInputDistribution.SetLinkedDisplayControl(grpThresholdOptions)
        ucrInputThresholdOperator.SetLinkedDisplayControl(lblNewDFName)
        ucrChkPrintSummary.SetLinkedDisplayControl(grpDeclusteringOptions)
        ucrNudDeclusterColumns.SetLinkedDisplayControl(lblDeclusterColumns)

        ucrInputFilterPreview.IsReadOnly = True

        ucrNudColumns.SetParameter(New RParameter("ncol", 3))
        ucrNudColumns.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)
        ucrNudColumns.SetRDefault("1")

        ucrInputMin.SetValidationTypeAsNumeric()
        ucrInputMin.AddQuotesIfUnrecognised = False

        ucrInputMax.SetValidationTypeAsNumeric()
        ucrInputMax.AddQuotesIfUnrecognised = False

        dctColours.Add("Black", Chr(34) & "black" & Chr(34))
        dctColours.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctColours.Add("Red", Chr(34) & "red" & Chr(34))
        dctColours.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctColours.Add("Green", Chr(34) & "green" & Chr(34))
        dctColours.Add("Violet", Chr(34) & "violet" & Chr(34))

        ucrInputFill.SetParameter(New RParameter("fill", 6))
        ucrInputFill.SetItems(dctColours)
        ucrInputFill.bAllowNonConditionValues = True
        ucrInputFill.SetRDefault(Chr(34) & "red" & Chr(34))

        ucrInputColours.SetParameter(New RParameter("col", 7))
        ucrInputColours.SetItems(dctColours)
        ucrInputColours.bAllowNonConditionValues = True
        ucrInputColours.SetRDefault(Chr(34) & "black" & Chr(34))

        ucrChkRugPlot.SetParameter(New RParameter("rug", 8))
        ucrChkRugPlot.SetText("Add Rug Plot")
        ucrChkRugPlot.SetRDefault("TRUE")

        ucrChkPrintSummary.SetParameter(New RParameter("print_summary", 11))
        ucrChkPrintSummary.SetText("Print declustered summary")
        ucrChkPrintSummary.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintSummary.SetRDefault("FALSE")

        ucrChkRunLength.SetText("Run Length")
        ucrChkRunLength.AddParameterPresentCondition(True, "r")
        ucrChkRunLength.AddParameterPresentCondition(False, "r", False)

        ucrNudRunLength.SetParameter(New RParameter("r", 4))
        ucrNudRunLength.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)

        ucrSaveMrlPlot.SetDataFrameSelector(ucrSelectorClimaticExtremes.ucrAvailableDataFrames)
        ucrSaveMrlPlot.SetPrefix("mrl_plot")
        ucrSaveMrlPlot.SetSaveTypeAsGraph()
        ucrSaveMrlPlot.SetIsComboBox()
        ucrSaveMrlPlot.SetCheckBoxText("Save Graph")
        ucrSaveMrlPlot.SetAssignToIfUncheckedValue("last_graph")

        ucrSaveThresholdPlot.SetDataFrameSelector(ucrSelectorClimaticExtremes.ucrAvailableDataFrames)
        ucrSaveThresholdPlot.SetPrefix("threshold_plot")
        ucrSaveThresholdPlot.SetSaveTypeAsGraph()
        ucrSaveThresholdPlot.SetIsComboBox()
        ucrSaveThresholdPlot.SetCheckBoxText("Save Graph")
        ucrSaveThresholdPlot.SetAssignToIfUncheckedValue("last_graph")

        ucrNudDeclusterColumns.SetParameter(New RParameter("ncol", 7))
        ucrNudDeclusterColumns.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)
        ucrNudDeclusterColumns.SetRDefault("1")

        ucrSaveDeclusteredPlot.SetDataFrameSelector(ucrSelectorClimaticExtremes.ucrAvailableDataFrames)
        ucrSaveDeclusteredPlot.SetPrefix("declustered_plot")
        ucrSaveDeclusteredPlot.SetSaveTypeAsGraph()
        ucrSaveDeclusteredPlot.SetIsComboBox()
        ucrSaveDeclusteredPlot.SetCheckBoxText("Save Graph")
        ucrSaveDeclusteredPlot.SetAssignToIfUncheckedValue("last_graph")

        ucrInputDistribution.SetParameter(New RParameter("type", 4))
        dctDistributions.Add("GP", Chr(34) & "GP" & Chr(34))
        dctDistributions.Add("PP", Chr(34) & "PP" & Chr(34))
        dctDistributions.Add("Exponential", Chr(34) & "Exponential" & Chr(34))
        ucrInputDistribution.SetItems(dctDistributions)
        ucrInputDistribution.SetDropDownStyleAsNonEditable()
        ucrInputDistribution.SetRDefault(Chr(34) & "GP" & Chr(34))

        ucrNudThresholds.SetParameter(New RParameter("nint", 5))
        ucrNudThresholds.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)
        ucrNudThresholds.SetRDefault("10")

        ucrNudAlpha.SetParameter(New RParameter("alpha", 6))
        ucrNudAlpha.DecimalPlaces = 2
        ucrNudAlpha.Increment = 0.01
        ucrNudAlpha.SetMinMax(0, 1)
        ucrNudAlpha.SetRDefault("0.05")

        ucrNudThresholdColumns.SetParameter(New RParameter("ncol", 7))
        ucrNudThresholdColumns.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)
        ucrNudThresholdColumns.SetRDefault("1")

        ttpThreshold.SetToolTip(rdoThreshold, "Plots that aid in identification of a threshold over which to fit a generalized Pareto distribution and threshold selection through fitting models to a range of thresholds.")
    End Sub

    Private Sub SetDefaults()
        clsGroupByFunction.Clear()
        clsRunCalcFunction.Clear()
        clsDayFromAndTo.Clear()
        clsDayFromAndToOperator.Clear()
        clsDayFromOperator.Clear()
        clsDayToOperator.Clear()
        clsDayManipulation.Clear()
        clsMinMaxSummariseFunction.Clear()
        clsMinMaxFuncExp.Clear()
        clsMinMaxManipulationsFunction.Clear()
        clsPeaksFilterFunction.Clear()
        clsPeaksFilterOperator.Clear()

        clsCombinationCalc.Clear()
        clsCombinationSubCalcs.Clear()
        clsCombinationManipulations.Clear()
        clsFirstDateSummary.Clear()
        clsFirstFunction.Clear()
        clsLastDateSummary.Clear()
        clsLastFunction.Clear()
        clsNSummary.Clear()
        clsNFunction.Clear()
        clsDateCarryCalcFromList.Clear()
        clsFilterExtremeCalc.Clear()
        clsFilterExtremeSubCalcs.Clear()
        clsFilterExtremeExp.Clear()

        clsPlotMrlFunction = New RFunction
        clsThresholdPlotFunction = New RFunction
        clsDeclusteringFunction = New RFunction
        clsDummyRfunction = clsPlotMrlFunction

        ucrSelectorClimaticExtremes.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        ucrSaveMrlPlot.Reset()
        ucrSaveThresholdPlot.Reset()
        ucrInputMin.SetText("")
        ucrInputMax.SetText("")
        SetCalculationValues()

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        ' Days
        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.bBrackets = False
        clsDayFromAndToOperator.AddParameter("from_operator", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)
        clsDayFromAndToOperator.AddParameter("to_operator", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.AddParameter("calculated_from", clsRFunctionParameter:=clsDayFilterCalcFromConvert, iPosition:=2)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")
        UpdateDayFilterPreview()

        ' For the Min/Max option:
        clsGroupByFunction.SetRCommand("instat_calculation$new")
        clsGroupByFunction.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunction.SetAssignTo("grouping")

        clsMinMaxManipulationsFunction.SetRCommand("list")
        clsMinMaxFuncExp.bToScriptAsRString = True
        clsMinMaxSummariseFunction.SetRCommand("instat_calculation$new")
        clsMinMaxSummariseFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsMinMaxSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMinMaxFuncExp, iPosition:=1)
        clsMinMaxFuncExp.SetRCommand("max")
        clsMinMaxFuncExp.AddParameter("x", iPosition:=0)
        clsMinMaxSummariseFunction.AddParameter("result_name", "max", iPosition:=2)
        clsMinMaxSummariseFunction.AddParameter("manipulations", clsRFunctionParameter:=clsMinMaxManipulationsFunction, iPosition:=3)
        clsMinMaxManipulationsFunction.AddParameter("sub1", clsRFunctionParameter:=clsGroupByFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsMinMaxManipulationsFunction.AddParameter("sub2", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=1)
        clsMinMaxSummariseFunction.AddParameter("save", 2, iPosition:=4)
        clsMinMaxSummariseFunction.SetAssignTo("min_max_summary")

        ' For the Peaks option:
        clsDayManipulation.SetRCommand("list")
        clsPeaksFilterOperator.bToScriptAsRString = True
        clsPeaksFilterFunction.SetRCommand("instat_calculation$new")
        clsPeaksFilterFunction.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsPeaksFilterFunction.AddParameter("function_exp", clsROperatorParameter:=clsPeaksFilterOperator, iPosition:=1)
        clsPeaksFilterOperator.SetOperation(">=") ' this value changes depending what is selected in the combo box. Temp. fix in a sub, but needs a proper fix.
        clsPeaksFilterOperator.AddParameter("left", iPosition:=0)
        clsPeaksFilterOperator.AddParameter("right", "60", iPosition:=1)
        clsPeaksFilterFunction.AddParameter("manipulations", clsRFunctionParameter:=clsDayManipulation, iPosition:=2)
        clsDayManipulation.AddParameter("sub1", clsRFunctionParameter:=clsDayFromAndTo, bIncludeArgumentName:=False, iPosition:=0)
        clsPeaksFilterFunction.AddParameter("save", 2, iPosition:=3)
        clsPeaksFilterFunction.SetAssignTo("peak_filter")

        'Code for carry columns
        clsCombinationCalc.SetRCommand("instat_calculation$new")
        clsCombinationCalc.AddParameter("type", Chr(34) & "combination" & Chr(34), iPosition:=0)
        clsCombinationCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsCombinationSubCalcs, iPosition:=1)
        clsCombinationCalc.AddParameter("manipulations", clsRFunctionParameter:=clsCombinationManipulations, iPosition:=2)
        clsCombinationCalc.SetAssignTo("overall_calc")

        clsCombinationSubCalcs.SetRCommand("list")
        clsCombinationSubCalcs.AddParameter("sub1", clsRFunctionParameter:=clsFirstDateSummary, iPosition:=0, bIncludeArgumentName:=False)
        clsCombinationSubCalcs.AddParameter("sub2", clsRFunctionParameter:=clsNSummary, iPosition:=1, bIncludeArgumentName:=False)

        clsCombinationManipulations.SetRCommand("list")
        clsCombinationManipulations.AddParameter("manip1", clsRFunctionParameter:=clsGroupByFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsCombinationManipulations.AddParameter("manip2", clsRFunctionParameter:=clsDayFromAndTo, iPosition:=1, bIncludeArgumentName:=False)
        clsCombinationManipulations.AddParameter("manip3", clsRFunctionParameter:=clsFilterExtremeCalc, iPosition:=1, bIncludeArgumentName:=False)

        clsDateCarryCalcFromList.SetRCommand("list")

        clsFirstDateSummary.SetRCommand("instat_calculation$new")
        clsFirstDateSummary.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsFirstDateSummary.AddParameter("function_exp", clsRFunctionParameter:=clsFirstFunction, iPosition:=1)
        clsFirstDateSummary.AddParameter("calculated_from", clsRFunctionParameter:=clsDateCarryCalcFromList, iPosition:=2)
        clsFirstDateSummary.AddParameter("save", "2", iPosition:=4)
        clsFirstDateSummary.SetAssignTo("first_date_summary")

        clsFirstFunction.SetPackageName("dplyr")
        clsFirstFunction.SetRCommand("first")
        clsFirstFunction.bToScriptAsRString = True

        clsLastDateSummary.SetRCommand("instat_calculation$new")
        clsLastDateSummary.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsLastDateSummary.AddParameter("function_exp", clsRFunctionParameter:=clsLastFunction, iPosition:=1)
        clsLastDateSummary.AddParameter("calculated_from", clsRFunctionParameter:=clsDateCarryCalcFromList, iPosition:=2)
        clsLastDateSummary.AddParameter("save", "2", iPosition:=4)
        clsLastDateSummary.SetAssignTo("last_date_summary")

        clsLastFunction.SetPackageName("dplyr")
        clsLastFunction.SetRCommand("last")
        clsLastFunction.bToScriptAsRString = True

        clsNSummary.SetRCommand("instat_calculation$new")
        clsNSummary.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsNSummary.AddParameter("function_exp", clsRFunctionParameter:=clsNFunction, iPosition:=1)
        clsNSummary.AddParameter("calculated_from", clsRFunctionParameter:=clsDateCarryCalcFromList, iPosition:=2)
        clsNSummary.AddParameter("save", "2", iPosition:=4)
        clsNSummary.SetAssignTo("n_dates_summary")

        clsNFunction.SetRCommand("summary_count")
        clsNFunction.bToScriptAsRString = True

        clsFilterExtremeCalc.SetRCommand("instat_calculation$new")
        clsFilterExtremeCalc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsFilterExtremeCalc.AddParameter("function_exp", clsROperatorParameter:=clsFilterExtremeExp, iPosition:=1)
        clsFilterExtremeCalc.AddParameter("sub_calculations", clsRFunctionParameter:=clsFilterExtremeSubCalcs, iPosition:=2)
        clsFilterExtremeCalc.SetAssignTo("filter_extreme_dates")

        clsFilterExtremeSubCalcs.SetRCommand("list")
        clsFilterExtremeSubCalcs.AddParameter("sub1", clsRFunctionParameter:=clsMinMaxSummariseFunction, bIncludeArgumentName:=False)

        clsFilterExtremeExp.SetOperation("==")
        clsFilterExtremeExp.bToScriptAsRString = True

        clsPlotMrlFunction.SetRCommand("plot_mrl")
        clsPlotMrlFunction.AddParameter("ncol", "1", iPosition:=3)
        clsPlotMrlFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsThresholdPlotFunction.SetRCommand("plot_multiple_threshold")
        clsThresholdPlotFunction.AddParameter("nint", "10", iPosition:=5)
        clsThresholdPlotFunction.AddParameter("alpha", "0.05", iPosition:=6)
        clsThresholdPlotFunction.AddParameter("ncol", "1", iPosition:=7)
        clsThresholdPlotFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsDeclusteringFunction.SetRCommand("plot_declustered")
        clsDeclusteringFunction.AddParameter("threshold", "40", iPosition:=3)
        clsDeclusteringFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        'Overall Calculation
        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        'This is a dummy function used to set the R code of the ucrPnlExtremesType
        clsCurrCalc = clsMinMaxSummariseFunction
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunction)
        clsRunCalcFunction.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        bUpdateMinMax = False
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrInputSave.AddAdditionalCodeParameterPair(clsPeaksFilterFunction, New RParameter("result_data_frame"), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsPeaksFilterOperator, New RParameter("left"), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsFilterExtremeExp, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsLastFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsNFunction, New RParameter("x", 0), iAdditionalPairNo:=2)

        ucrSelectorClimaticExtremes.AddAdditionalCodeParameterPair(clsThresholdPlotFunction, ucrSelectorClimaticExtremes.GetParameter, iAdditionalPairNo:=1)
        ucrSelectorClimaticExtremes.AddAdditionalCodeParameterPair(clsDeclusteringFunction, ucrSelectorClimaticExtremes.GetParameter, iAdditionalPairNo:=2)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsThresholdPlotFunction, New RParameter("station_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsDeclusteringFunction, New RParameter("station_col_name", 2), iAdditionalPairNo:=2)

        ucrInputThresholdValue.AddAdditionalCodeParameterPair(clsDeclusteringFunction, New RParameter("threshold", 3), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrInputThresholdValue.SetRCode(clsPeaksFilterOperator, bReset)
        ucrPnlMaxMin.SetRCode(clsMinMaxFuncExp, bReset)
        ucrReceiverElement.SetRCode(clsMinMaxFuncExp, bReset)
        ucrChkMissingValues.SetRCode(clsMinMaxFuncExp, bReset)
        ucrInputSave.SetRCode(clsMinMaxSummariseFunction, bReset)
         ucrPnlExtremesType.SetRCode(clsCurrCalc, bReset)
        ucrReceiverDate.SetRCode(clsFirstFunction, bReset)
        ucrChkFirstDate.SetRCode(clsCombinationSubCalcs, bReset)
        ucrChkNDates.SetRCode(clsCombinationSubCalcs, bReset)
        ucrChkLastDate.SetRCode(clsCombinationSubCalcs, bReset)
        ucrSelectorClimaticExtremes.SetRCode(clsPlotMrlFunction, bReset)
        ucrReceiverStation.SetRCode(clsPlotMrlFunction, bReset)
        ucrNudColumns.SetRCode(clsPlotMrlFunction, bReset)
        ucrPnlPlots.SetRCode(clsDummyRfunction, bReset)
        ucrInputFill.SetRCode(clsPlotMrlFunction, bReset)
        ucrInputColours.SetRCode(clsPlotMrlFunction, bReset)
        ucrChkRugPlot.SetRCode(clsPlotMrlFunction, bReset)

        ucrInputDistribution.SetRCode(clsThresholdPlotFunction, bReset)
        ucrNudThresholdColumns.SetRCode(clsThresholdPlotFunction, bReset)
        ucrNudAlpha.SetRCode(clsThresholdPlotFunction, bReset)
        ucrNudThresholds.SetRCode(clsThresholdPlotFunction, bReset)
        ucrNudRunLength.SetRCode(clsDeclusteringFunction, bReset)
        ucrChkPrintSummary.SetRCode(clsDeclusteringFunction, bReset)
        ucrNudDeclusterColumns.SetRCode(clsDeclusteringFunction, bReset)
        ucrChkRunLength.SetRCode(clsDeclusteringFunction, bReset)
        ucrChkDeclustering.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrSaveThresholdPlot.SetRCode(clsThresholdPlotFunction)
        ucrSaveMrlPlot.SetRCode(clsPlotMrlFunction, bReset)
        'This is done on bReset because we don't want to SetAssignTo when this save control is hidden
        If bReset Then
            ucrSaveDeclusteredPlot.SetRCode(clsDeclusteringFunction, bReset)
        End If
        bUpdateMinMax = True
    End Sub

    Private Sub TestOkEnabled()
        If rdoMinMax.Checked OrElse rdoPeaks.Checked Then
            If Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverDOY.IsEmpty() AndAlso Not ucrReceiverElement.IsEmpty() AndAlso Not ucrReceiverYear.IsEmpty() AndAlso Not ucrInputSave.IsEmpty AndAlso ((rdoPeaks.Checked AndAlso Not ucrInputThresholdValue.IsEmpty) OrElse rdoMinMax.Checked) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If ucrReceiverElement.IsEmpty OrElse (rdoMrlPlot.Checked AndAlso Not ucrSaveMrlPlot.IsComplete OrElse ucrNudColumns.GetText = "") OrElse (rdoThreshRangePlot.Checked AndAlso Not ucrSaveThresholdPlot.IsComplete OrElse ucrNudThresholds.GetText = "" OrElse ucrNudThresholdColumns.GetText = "" OrElse ucrNudAlpha.GetText = "") OrElse (ucrChkDeclustering.Checked AndAlso (Not ucrSaveDeclusteredPlot.IsComplete) OrElse ucrNudDeclusterColumns.GetText = "" OrElse ucrNudRunLength.GetText = "") Then
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

    Private Sub SetAssignName()
        If rdoMinMax.Checked Then
            If rdoMax.Checked Then
                ucrInputSave.SetName("max")
            Else
                ucrInputSave.SetName("min")
            End If
        ElseIf rdoPeaks.Checked Then
            ucrInputSave.SetName("peaks")
        End If
    End Sub

    Private Sub SetCalculationValues()
        If rdoMinMax.Checked Then
            If rdoMin.Checked Then
                clsMinMaxFuncExp.SetRCommand("min")
            ElseIf rdoMax.Checked Then
                clsMinMaxFuncExp.SetRCommand("max")
            Else
            End If
            If ucrChkFirstDate.Checked OrElse ucrChkNDates.Checked OrElse ucrChkLastDate.Checked Then
                clsCurrCalc = clsCombinationCalc
            Else
                clsCurrCalc = clsMinMaxSummariseFunction
            End If
        ElseIf rdoPeaks.Checked Then
            clsCurrCalc = clsPeaksFilterFunction

            ' TODO1: Fix so that this is automatically done. This is an operation which is also associated to a ucrInput
            If ucrInputThresholdOperator.GetText = ">=" Then
                clsPeaksFilterOperator.SetOperation(">=")
            ElseIf ucrInputThresholdOperator.GetText = ">" Then
                clsPeaksFilterOperator.SetOperation(">")
            ElseIf ucrInputThresholdOperator.GetText = "<" Then
                clsPeaksFilterOperator.SetOperation("<")
            ElseIf ucrInputThresholdOperator.GetText = "<=" Then
                clsPeaksFilterOperator.SetOperation("<=")
            Else
            End If
        Else
        End If
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsCurrCalc) ' TODO2: fix this so that the new class runs with the change of the radio button. The class that runs should change depending which rdo is checked. Also a problem in dlgStringDistance
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupByFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
        Else
            clsGroupByFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=1)
        End If
    End Sub

    Private Sub MinMaxFunction()
        clsMinMaxSummariseFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")", iPosition:=2)
        clsFilterExtremeCalc.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")", iPosition:=2)
    End Sub

    Private Sub PeaksFunction()
        clsPeaksFilterFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")", iPosition:=2)
    End Sub

    Private Sub ucrPnlMinMaxPeaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremesType.ControlValueChanged, ucrPnlMaxMin.ControlValueChanged
        SetCalculationValues()
        SetAssignName()
        SetThresholdBaseFunction()

        If rdoThreshold.Checked Then
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFromAndTo, clsNewDayFromOperator:=clsDayFromOperator, clsNewDayToOperator:=clsDayToOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
        sdgDoyRange.ShowDialog()
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrSelectorClimaticExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimaticExtremes.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupByOptions()
        MinMaxFunction()
        PeaksFunction()
        SetDateCalcFrom()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged
        Dim exprMin As SymbolicExpression
        Dim exprMax As SymbolicExpression
        Dim minCharVector As CharacterVector
        Dim maxCharVector As CharacterVector
        Dim clsMinimumFunction As New RFunction
        Dim clsMaximumFunction As New RFunction
        Dim clsGetVariablesFunc As New RFunction

        clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetVariablesFunc.AddParameter("data_name", Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsGetVariablesFunc.AddParameter("col_names", Chr(34) & ucrReceiverElement.GetVariableNames(False) & Chr(34), iPosition:=1)

        clsMinimumFunction.SetRCommand("min")
        clsMaximumFunction.SetRCommand("max")
        clsMinimumFunction.AddParameter("x", clsRFunctionParameter:=clsGetVariablesFunc, iPosition:=0)
        clsMaximumFunction.AddParameter("x", clsRFunctionParameter:=clsGetVariablesFunc, iPosition:=0)
        clsMinimumFunction.AddParameter("na.rm", "TRUE", iPosition:=1)
        clsMaximumFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        exprMin = frmMain.clsRLink.RunInternalScriptGetValue(clsMinimumFunction.ToScript(), bSilent:=True)
        exprMax = frmMain.clsRLink.RunInternalScriptGetValue(clsMaximumFunction.ToScript(), bSilent:=True)

        If bUpdateMinMax Then
            If exprMin IsNot Nothing AndAlso Not exprMin.Type = Internals.SymbolicExpressionType.Null Then
                minCharVector = exprMin.AsCharacter
                ucrInputMin.SetText(minCharVector(0))
            End If
            If exprMax IsNot Nothing AndAlso Not exprMax.Type = Internals.SymbolicExpressionType.Null Then
                maxCharVector = exprMax.AsCharacter
                ucrInputMax.SetText(maxCharVector(0))
            End If
        End If

        If Not ucrReceiverElement.IsEmpty Then
            clsPlotMrlFunction.AddParameter("element_name", ucrReceiverElement.GetVariableNames, iPosition:=2)
            clsThresholdPlotFunction.AddParameter("element_col_name", ucrReceiverElement.GetVariableNames, iPosition:=2)
            clsDeclusteringFunction.AddParameter("element_col_name", ucrReceiverElement.GetVariableNames, iPosition:=2)
        Else
            clsPlotMrlFunction.RemoveParameterByName("element_name")
            clsThresholdPlotFunction.RemoveParameterByName("element_col_name")
            clsDeclusteringFunction.RemoveParameterByName("element_col_name")
        End If
        MinMaxFunction()
        PeaksFunction()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrSelectorClimaticExtremes.ControlValueChanged, ucrReceiverDOY.ControlContentsChanged
        GroupByOptions()

        If Not ucrReceiverDOY.IsEmpty Then
            clsDayFilterCalcFromList.AddParameter(ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrInputThresholdOperator_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputThresholdOperator.ControlValueChanged
        SetCalculationValues()
    End Sub

    Private Sub ucrSelectorClimaticExtremes_DataFrameChanged() Handles ucrSelectorClimaticExtremes.DataFrameChanged
        clsDayFilterCalcFromList.ClearParameters()
    End Sub

    Private Sub UpdateDayFilterPreview()
        If ucrReceiverDOY.IsEmpty Then
            ucrInputFilterPreview.SetName("")
        Else
            ucrInputFilterPreview.SetName(clsDayFromAndToOperator.ToScript())
        End If
    End Sub

    Private Sub ucrChkFirstDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFirstDate.ControlValueChanged
        If ucrChkFirstDate.Checked Then
            clsCombinationSubCalcs.AddParameter("sub1", clsRFunctionParameter:=clsFirstDateSummary, iPosition:=0, bIncludeArgumentName:=False)
        Else
            clsCombinationSubCalcs.RemoveParameterByName("sub1")
        End If
        SetCalculationValues()
    End Sub

    Private Sub ucrChkNDates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNDates.ControlValueChanged
        If ucrChkNDates.Checked Then
            clsCombinationSubCalcs.AddParameter("sub2", clsRFunctionParameter:=clsNSummary, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsCombinationSubCalcs.RemoveParameterByName("sub2")
        End If
        SetCalculationValues()
    End Sub

    Private Sub ucrChkLastDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLastDate.ControlValueChanged
        If ucrChkLastDate.Checked Then
            clsCombinationSubCalcs.AddParameter("sub3", clsRFunctionParameter:=clsLastDateSummary, iPosition:=2, bIncludeArgumentName:=False)
        Else
            clsCombinationSubCalcs.RemoveParameterByName("sub3")
        End If
        SetCalculationValues()
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        SetDateCalcFrom()
    End Sub

    Private Sub SetDateCalcFrom()
        clsDateCarryCalcFromList.ClearParameters()
        clsDateCarryCalcFromList.AddParameter(strCurrDataName, ucrReceiverDate.GetVariableNames(), iPosition:=0)
    End Sub

    Private Sub SetResultNameCarryColumns()
        clsFirstDateSummary.AddParameter("result_name", Chr(34) & "Date_first_" & ucrInputSave.GetText() & Chr(34), iPosition:=3)
        clsLastDateSummary.AddParameter("result_name", Chr(34) & "Date_last_" & ucrInputSave.GetText() & Chr(34), iPosition:=3)
        clsNSummary.AddParameter("result_name", Chr(34) & "n_" & ucrInputSave.GetText() & Chr(34), iPosition:=3)
    End Sub

    Private Sub ucrInputSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSave.ControlValueChanged
        SetResultNameCarryColumns()
        clsFilterExtremeExp.AddParameter("right", ucrInputSave.GetText(), iPosition:=1)
    End Sub

    Private Sub ucrInputMax_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputMax.ControlContentsChanged
        If ucrInputMax.GetValue <> "" Then
            clsPlotMrlFunction.AddParameter("umax", ucrInputMax.GetValue, iPosition:=5)
        Else
            clsPlotMrlFunction.RemoveParameterByName("umax")
        End If
    End Sub

    Private Sub ucrInputMin_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputMin.ControlContentsChanged
        If ucrInputMin.GetValue <> "" Then
            clsPlotMrlFunction.AddParameter("umin", ucrInputMin.GetValue, iPosition:=4)
        Else
            clsPlotMrlFunction.RemoveParameterByName("umin")
        End If
    End Sub

    Private Sub SetThresholdBaseFunction()
        If rdoThreshold.Checked Then
            If rdoMrlPlot.Checked Then
                clsDummyRfunction = clsPlotMrlFunction
            ElseIf rdoThreshRangePlot.Checked Then
                clsDummyRfunction = clsThresholdPlotFunction
            End If
            ucrBase.clsRsyntax.SetBaseRFunction(clsDummyRfunction)
            clsCurrCalc = clsDummyRfunction
        End If
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlValueChanged
        SetThresholdBaseFunction()
    End Sub

    Private Sub ucrChkPrintSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintSummary.ControlValueChanged
        If ucrChkPrintSummary.Checked Then
            clsDeclusteringFunction.iCallType = 2
        Else
            clsDeclusteringFunction.iCallType = 3
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrInputSave.ControlContentsChanged, ucrInputThresholdValue.ControlContentsChanged, ucrPnlPlots.ControlContentsChanged, ucrSaveMrlPlot.ControlContentsChanged, ucrSaveThresholdPlot.ControlContentsChanged, ucrNudColumns.ControlContentsChanged, ucrNudThresholds.ControlContentsChanged, ucrNudThresholdColumns.ControlContentsChanged, ucrNudAlpha.ControlContentsChanged, ucrNudDeclusterColumns.ControlContentsChanged, ucrNudRunLength.ControlContentsChanged, ucrSaveDeclusteredPlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkDeclustering_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDeclustering.ControlValueChanged
        If ucrChkDeclustering.Checked Then
            clsDeclusteringFunction.iCallType = 3
            clsDeclusteringFunction.bExcludeAssignedFunctionOutput = False
            ucrBase.clsRsyntax.AddToAfterCodes(clsDeclusteringFunction, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDeclusteringFunction)
        End If
    End Sub
End Class