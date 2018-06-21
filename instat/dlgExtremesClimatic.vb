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
Public Class dlgExtremesClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
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

        ucrReceiverYear.Selector = ucrSelectorClimaticExtremes
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

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
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverElement.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement.Selector = ucrSelectorClimaticExtremes
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.bAutoFill = True
        ucrReceiverElement.strSelectorHeading = "Numerics"
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})

        ' Panel Options
        ucrPnlExtremesType.AddRadioButton(rdoMinMax)
        ucrPnlExtremesType.AddRadioButton(rdoPeaks)
        ucrPnlExtremesType.AddParameterValuesCondition(rdoPeaks, "type", Chr(34) & "filter" & Chr(34))
        ucrPnlExtremesType.AddParameterValuesCondition(rdoMinMax, "type", {Chr(34) & "summary" & Chr(34), Chr(34) & "combination" & Chr(34)})

        ' Min/Max Option
        ucrPnlMaxMin.AddRadioButton(rdoMax)
        ucrPnlMaxMin.AddRadioButton(rdoMin)
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMax, "max")
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMin, "min")

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
        ucrPnlExtremesType.AddToLinkedControls(ucrPnlMaxMin, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkMissingValues, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkFirstDate, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkLastDate, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkNDates, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlMaxMin.SetLinkedDisplayControl(lblNewColName)

        ucrInputFilterPreview.IsReadOnly = True
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

        ucrSelectorClimaticExtremes.Reset()
        ucrReceiverElement.SetMeAsReceiver()
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
        clsMinMaxFuncExp.AddParameter("na.rm", "TRUE", iPosition:=1)
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

        'Overall Calculation
        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        'This is a dummy function used to set the R code of the ucrPnlExtremesType
        clsCurrCalc = clsMinMaxSummariseFunction
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunction)
        clsRunCalcFunction.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        ucrInputSave.AddAdditionalCodeParameterPair(clsPeaksFilterFunction, New RParameter("result_data_frame"), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsPeaksFilterOperator, New RParameter("left"), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsFilterExtremeExp, New RParameter("left", 0), iAdditionalPairNo:=2)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsLastFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsNFunction, New RParameter("x", 0), iAdditionalPairNo:=2)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)

        '        ucrInputThresholdOperator.SetRCode(clsPeaksFilterFunction, bReset)
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
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverDOY.IsEmpty() AndAlso Not ucrReceiverElement.IsEmpty() AndAlso Not ucrReceiverYear.IsEmpty() AndAlso Not ucrInputSave.IsEmpty AndAlso ((rdoPeaks.Checked AndAlso Not ucrInputThresholdValue.IsEmpty) OrElse rdoMinMax.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
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

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrInputSave.ControlContentsChanged, ucrInputThresholdValue.ControlContentsChanged
        TestOkEnabled()
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
End Class