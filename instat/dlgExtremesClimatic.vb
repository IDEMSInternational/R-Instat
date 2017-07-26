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
    Private clsGroupByFunction, clsRunCalcFunction As New RFunction
    Private clsCurrCalc As RFunction
    ' Min/Max Options
    Private clsMinMaxSummariseFunction, clsMinMaxManipulationsFunction, clsMinMaxFuncExp As New RFunction
    ' Peak Options
    Private clsPeaksFilterOperator As New ROperator
    Private clsPeaksFilterFunction As New RFunction

    Private Sub dlgExtremesClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverStation.Selector = ucrSelectorClimaticExtremes
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        '' What is Date used for in this?
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverDate.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverDOY.Selector = ucrSelectorClimaticExtremes
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.strSelectorHeading = "Day variables"

        ucrReceiverElement.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement.Selector = ucrSelectorClimaticExtremes
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.strSelectorHeading = "Numerics"

        ' Panel Options:
        ucrPnlExtremesType.AddRadioButton(rdoMinMax)
        ucrPnlExtremesType.AddRadioButton(rdoPeaks)
        ucrPnlExtremesType.AddParameterValuesCondition(rdoPeaks, "type", Chr(34) & "filter" & Chr(34))
        ucrPnlExtremesType.AddParameterValuesCondition(rdoMinMax, "type", Chr(34) & "summary" & Chr(34))

        ucrPnlExtremesType.AddToLinkedControls(ucrInputThresholdOperator, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=">=")
        ucrPnlExtremesType.AddToLinkedControls(ucrInputThresholdValue, {rdoPeaks}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.85")
        ucrPnlExtremesType.AddToLinkedControls(ucrPnlMaxMin, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrChkMissingValues, {rdoMinMax}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlMaxMin.SetLinkedDisplayControl(lblNewColName)

        'to/from

        ' Min/Max Option
        ucrPnlMaxMin.AddRadioButton(rdoMax)
        ucrPnlMaxMin.AddRadioButton(rdoMin)
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMax, "max")
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMin, "min")

        ucrChkDayNumber.SetText("Include Day of Occurrence")

        ucrChkMissingValues.SetText("Include Missing Values")
        ucrChkMissingValues.SetParameter(New RParameter("na.rm", 1))

        ' Peaks Option
        ucrInputThresholdValue.SetParameter(New RParameter("right", 1))
        ucrInputThresholdValue.SetValidationTypeAsNumeric()
        ucrInputThresholdValue.SetLinkedDisplayControl(lblValues)
        ucrInputThresholdValue.AddQuotesIfUnrecognised = False

        ucrInputThresholdOperator.SetParameter(New RParameter("function_exp", 1))
        Dim dctThreshold As New Dictionary(Of String, String)
        dctThreshold.Add(">", Chr(34) & ">" & Chr(34))
        dctThreshold.Add("<", Chr(34) & "<" & Chr(34))
        dctThreshold.Add(">=", Chr(34) & ">=" & Chr(34))
        dctThreshold.Add("<=", Chr(34) & "<=" & Chr(34))
        ucrInputThresholdOperator.SetItems(dctThreshold)
        ucrInputThresholdOperator.SetDropDownStyleAsNonEditable()
        ucrInputThresholdOperator.AddQuotesIfUnrecognised = False

        ucrInputSave.SetParameter(New RParameter("result_name", 4))
        'disabling control for now.
        ucrChkDayNumber.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsGroupByFunction.Clear()
        clsRunCalcFunction.Clear()
        clsMinMaxSummariseFunction.Clear()
        clsMinMaxFuncExp.Clear()
        clsMinMaxManipulationsFunction.Clear()
        clsPeaksFilterFunction.Clear()
        clsPeaksFilterOperator.Clear()

        ucrSelectorClimaticExtremes.Reset()
        ucrInputThresholdValue.Reset()
        SetCalculationValues()

        ' For the Min/Max option:
        clsGroupByFunction.SetRCommand("instat_calculation$new")
        clsGroupByFunction.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunction.SetAssignTo("grouping")

        clsMinMaxManipulationsFunction.SetRCommand("list")
        clsMinMaxManipulationsFunction.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, bIncludeArgumentName:=False)
        clsMinMaxFuncExp.bToScriptAsRString = True
        clsMinMaxSummariseFunction.SetRCommand("instat_calculation$new")
        clsMinMaxSummariseFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsMinMaxSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMinMaxFuncExp, iPosition:=1)
        clsMinMaxFuncExp.SetRCommand("max")
        clsMinMaxFuncExp.AddParameter("x", iPosition:=0)
        clsMinMaxFuncExp.AddParameter("na.rm", "TRUE", iPosition:=1)
        clsMinMaxSummariseFunction.AddParameter("result_name", "max", iPosition:=2)
        clsMinMaxSummariseFunction.AddParameter("manipulations", clsRFunctionParameter:=clsMinMaxManipulationsFunction, iPosition:=3)
        clsMinMaxSummariseFunction.AddParameter("save", 2, iPosition:=4)
        clsMinMaxSummariseFunction.SetAssignTo("min_max_summary")

        ' For the Peaks option:
        clsPeaksFilterOperator.bToScriptAsRString = True
        clsPeaksFilterFunction.SetRCommand("instat_calculation$new")
        clsPeaksFilterFunction.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsPeaksFilterFunction.AddParameter("function_exp", clsROperatorParameter:=clsPeaksFilterOperator, iPosition:=1)
        clsPeaksFilterOperator.SetOperation(">=") ' this value changes depending what is selected in the combo box. Temp. fix in a sub, but needs a proper fix.
        clsPeaksFilterOperator.AddParameter("left", iPosition:=0)
        clsPeaksFilterOperator.AddParameter("right", "0.85", iPosition:=1)
        clsPeaksFilterFunction.AddParameter("save", 2, iPosition:=2)
        clsPeaksFilterFunction.SetAssignTo("peak_filter")

        'Overall Calculation
        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        'This is a dummy function used to set the R code of the ucrPnlExtremesType
        clsCurrCalc = clsMinMaxSummariseFunction
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunction)
        clsRunCalcFunction.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrInputSave.AddAdditionalCodeParameterPair(clsPeaksFilterFunction, New RParameter("result_data_frame"), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsPeaksFilterOperator, New RParameter("left"), iAdditionalPairNo:=1)
        '        ucrInputThresholdOperator.SetRCode(clsPeaksFilterFunction, bReset)
        ucrInputThresholdValue.SetRCode(clsPeaksFilterOperator, bReset)

        ucrPnlMaxMin.SetRCode(clsMinMaxFuncExp, bReset)
        ucrReceiverElement.SetRCode(clsMinMaxFuncExp, bReset)
        ucrChkMissingValues.SetRCode(clsMinMaxFuncExp, bReset)

        ucrInputSave.SetRCode(clsMinMaxSummariseFunction, bReset)
        ucrPnlExtremesType.SetRCode(clsCurrCalc, bReset)
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
        If Not ucrInputSave.bUserTyped Then
            If rdoMinMax.Checked Then
                If rdoMax.Checked Then
                    ucrInputSave.SetName("max")
                Else
                    ucrInputSave.SetName("min")
                End If
            ElseIf rdoPeaks.Checked Then
                ucrInputSave.SetName("peaks")
            End If
        End If
    End Sub

    Private Sub SetCalculationValues()
        If rdoMinMax.Checked Then
            clsCurrCalc = clsMinMaxSummariseFunction

            If rdoMin.Checked Then
                clsMinMaxFuncExp.SetRCommand("min")
            Else
                clsMinMaxFuncExp.SetRCommand("max")
            End If
            clsMinMaxSummariseFunction.AddParameter("function_exp", clsRFunctionParameter:=clsMinMaxFuncExp, iPosition:=1) ' TODO1: fix this so that we don't lose the function_exp when we change the r function. Should we do two bases here clsMaxFuncExp and clsMinFuncExp and then the problem is similar to TODO1. We want to change the class being called for function_exp when the radio buttons are changed
        Else
            clsCurrCalc = clsPeaksFilterFunction

            ' TODO2: Fix that this is automatically done. This is an operation which is also associated to a ucrInput
            If ucrInputThresholdOperator.GetText = ">=" Then
                clsPeaksFilterOperator.SetOperation(">=")
            ElseIf ucrInputThresholdOperator.GetText = ">" Then
                clsPeaksFilterOperator.SetOperation(">")
            ElseIf ucrInputThresholdOperator.GetText = "<" Then
                clsPeaksFilterOperator.SetOperation("<")
            Else
                clsPeaksFilterOperator.SetOperation("<=")
            End If
            clsPeaksFilterFunction.AddParameter("function_exp", clsROperatorParameter:=clsPeaksFilterOperator, iPosition:=1) ' TODO1 to apply here too
        End If
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsCurrCalc) ' TODO3: fix this so that the new class runs with the change of the radio button. The class that runs should change depending which rdo is checked. Also a problem in dlgStringDistance
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupByFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
        Else
            clsGroupByFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")", iPosition:=1)
        End If
    End Sub

    Private Sub MinMaxFunction()
        clsMinMaxSummariseFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")", iPosition:=1)
    End Sub

    Private Sub PeaksFunction()
        clsPeaksFilterFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")", iPosition:=1)
    End Sub

    Private Sub ucrPnlMinMaxPeaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremesType.ControlValueChanged, ucrPnlMaxMin.ControlValueChanged
        SetCalculationValues()
        SetAssignName()
    End Sub

    Private Sub ucrSelectorClimaticExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimaticExtremes.ControlValueChanged
        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupByOptions()
        PeaksFunction()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged ', ucrInputThresholdOperator.ControlContentsChanged, ucrInputThresholdValue.ControlValueChanged
        MinMaxFunction()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByOptions()
        PeaksFunction()
    End Sub

    Private Sub ucrInputThresholdOperator_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputThresholdOperator.ControlValueChanged
        SetCalculationValues()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrInputSave.ControlContentsChanged, ucrInputThresholdValue.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class