'' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgExtremesClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsExtreme As New RFunction
    Private strCurrDataName As String = ""
    Private clsRunCalcFunction, clsMinMaxCalcFunction, clsMinMaxGroupByFunction, clsMinMaxManipulationsFunction, clsMinMaxSummariseFunction, clsMinMaxFuncExp, clsPeaksFilterFunction As New RFunction
    Private clsCurrCalc As RFunction

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

        ucrReceiverStations.Selector = ucrSelectorClimaticExtremes
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStations.strSelectorHeading = "Station Variables"

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

        ucrReceiverElement.SetParameter(New RParameter("x", 0))
        ucrReceiverElement.Selector = ucrSelectorClimaticExtremes
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.strSelectorHeading = "Numerics"

        'ucrRdoOptions
        ucrPnlExtremesType.AddRadioButton(rdoMinMax)
        ucrPnlExtremesType.AddRadioButton(rdoPeaks)

        ucrPnlMaxMin.AddRadioButton(rdoMax)
        ucrPnlMaxMin.AddRadioButton(rdoMin)
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMax, "max")
        ucrPnlMaxMin.AddFunctionNamesCondition(rdoMin, "min")

        ucrChkDayNumber.SetText("Include Day of Occurance")

        ucrInputThresholdValue.SetValidationTypeAsNumeric()
        ucrInputThresholdValue.SetLinkedDisplayControl(lblValues)

        ucrInputThresholdOperator.SetParameter(New RParameter("function_exp"))
        Dim dctThreshold As New Dictionary(Of String, String)
        dctThreshold.Add(">", Chr(34) & ">" & Chr(34))
        dctThreshold.Add("<", Chr(34) & "<" & Chr(34))
        dctThreshold.Add(">=", Chr(34) & ">=" & Chr(34))
        dctThreshold.Add("<=", Chr(34) & "<=" & Chr(34))
        ucrInputThresholdOperator.SetItems(dctThreshold)
        ucrInputThresholdOperator.SetDropDownStyleAsNonEditable()
        ucrInputThresholdValue.SetValidationTypeAsNumeric()

        ucrInputSave.SetParameter(New RParameter("result_name"))

        ucrPnlExtremesType.AddToLinkedControls({ucrInputThresholdValue, ucrInputThresholdOperator}, {rdoPeaks}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlExtremesType.AddToLinkedControls(ucrPnlMaxMin, {rdoMinMax}, bNewLinkedHideIfParameterMissing:=True)

        'disabling control for now.
        ucrChkDayNumber.Enabled = False

        ucrPnlExtremesType.AddParameterValuesCondition(rdoPeaks, "type", Chr(34) & "filter" & Chr(34))
        ucrPnlExtremesType.AddParameterValuesCondition(rdoMinMax, "type", Chr(34) & "summary" & Chr(34))
    End Sub

    Private Sub SetDefaults()
        clsRunCalcFunction = New RFunction
        clsMinMaxCalcFunction = New RFunction
        clsMinMaxGroupByFunction = New RFunction
        clsMinMaxSummariseFunction = New RFunction
        clsMinMaxManipulationsFunction = New RFunction
        clsMinMaxFuncExp = New RFunction
        clsPeaksFilterFunction = New RFunction

        ucrSelectorClimaticExtremes.Reset()
        ucrInputThresholdValue.Reset()
        SetCalculationValues()

        clsPeaksFilterFunction.SetRCommand("instat_calculation$new")
        clsPeaksFilterFunction.SetAssignTo("peak_filter")
        clsPeaksFilterFunction.AddParameter("type", Chr(34) & "filter" & Chr(34))
        clsPeaksFilterFunction.AddParameter("save", 2)
        clsPeaksFilterFunction.SetAssignTo("grouping")

        clsMinMaxGroupByFunction.SetRCommand("instat_calculation$new")
        clsMinMaxGroupByFunction.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsMinMaxGroupByFunction.SetAssignTo("grouping")
        ucrInputThresholdValue.SetName(40)
        ucrInputThresholdOperator.SetName(">=")

        clsMinMaxManipulationsFunction.SetRCommand("list")
        clsMinMaxManipulationsFunction.AddParameter("group_by", clsRFunctionParameter:=clsMinMaxGroupByFunction, bIncludeArgumentName:=False)

        clsMinMaxSummariseFunction.SetRCommand("instat_calculation$new")
        clsMinMaxSummariseFunction.SetAssignTo("min_max_summary")
        clsMinMaxSummariseFunction.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsMinMaxSummariseFunction.AddParameter("save", 2)
        clsMinMaxSummariseFunction.AddParameter("result_name", "max")
        clsMinMaxSummariseFunction.AddParameter("manipulations", clsRFunctionParameter:=clsMinMaxManipulationsFunction)

        clsMinMaxFuncExp.SetRCommand("max")
        'TODO Make option on dialog
        clsMinMaxFuncExp.AddParameter("na.rm", "TRUE")

        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunction)
        'This is a dummy function used to set the R code of the ucrPnlExtremesType
        clsCurrCalc = clsMinMaxSummariseFunction
        clsRunCalcFunction.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrInputSave.AddAdditionalCodeParameterPair(clsPeaksFilterFunction, New RParameter("result_data_frame"), iAdditionalPairNo:=1)
        ucrReceiverElement.SetRCode(clsMinMaxFuncExp, bReset)
        ucrInputSave.SetRCode(clsMinMaxSummariseFunction, bReset)
        ucrPnlMaxMin.SetRCode(clsMinMaxFuncExp, bReset)
        ucrPnlExtremesType.SetRCode(clsCurrCalc, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty() AndAlso Not ucrReceiverDOY.IsEmpty() AndAlso Not ucrReceiverElement.IsEmpty() AndAlso (Not ucrReceiverYear.IsEmpty() OrElse Not ucrReceiverStations.IsEmpty()) Then
            If rdoMinMax.Checked Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(True)
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

    Private Sub SetGroupByFuncCalcFrom()
        'Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""

        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverStations.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStations.GetVariableNames() & ", " & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        ElseIf Not ucrReceiverYear.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        ElseIf Not ucrReceiverStations.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStations.GetVariableNames() & ")"
        End If
        If strGroupByCalcFrom <> "" Then
            clsMinMaxGroupByFunction.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsMinMaxGroupByFunction.RemoveParameterByName("calculated_from")
        End If
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
                ucrInputSave.SetName("Peaks")
            End If
        End If
    End Sub

    Private Sub SetMinMaxSummaryParams()
        Dim strCurrDataName As String = ""

        strCurrDataName = Chr(34) & ucrSelectorClimaticExtremes.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        If Not ucrReceiverElement.IsEmpty() Then
            clsMinMaxSummariseFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")")
            clsMinMaxSummariseFunction.AddParameter("function_exp", Chr(34) & clsMinMaxFuncExp.ToScript() & Chr(34))
        Else
            clsMinMaxSummariseFunction.RemoveParameterByName("calculated_from")
            clsMinMaxSummariseFunction.RemoveParameterByName("function_exp")
        End If
    End Sub

    Private Sub SetCalculationValues()
        If rdoMinMax.Checked Then
            clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsMinMaxSummariseFunction)
            clsCurrCalc = clsMinMaxSummariseFunction
            If rdoMin.Checked Then
                clsMinMaxFuncExp.SetRCommand("min")
            Else
                clsMinMaxFuncExp.SetRCommand("max")
            End If
        ElseIf rdoPeaks.Checked Then
            clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsPeaksFilterFunction)
            clsCurrCalc = clsPeaksFilterFunction
        Else
            clsRunCalcFunction.RemoveParameterByName("calc")
        End If
    End Sub

    Private Sub ucrPnlMinMaxPeaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremesType.ControlValueChanged, ucrPnlMaxMin.ControlValueChanged
        SetCalculationValues()
        SetAssignName()
        SetMinMaxSummaryParams()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged, ucrReceiverStations.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrInputThresholdOperator.ControlContentsChanged, ucrInputThresholdValue.ControlValueChanged
        SetMinMaxSummaryParams()
        clsPeaksFilterFunction.RemoveParameterByName("function_exp")
        clsPeaksFilterFunction.AddParameter("function_exp", Chr(34) & ucrReceiverElement.GetVariableNames(False) & ucrInputThresholdOperator.cboInput.SelectedItem & ucrInputThresholdValue.GetText & Chr(34))
    End Sub

    Private Sub ucrSelectorClimaticExtremes_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimaticExtremes.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged
        SetMinMaxSummaryParams()
        clsPeaksFilterFunction.RemoveParameterByName("calculated_from")
        clsPeaksFilterFunction.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")")
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class