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
Public Class dlgClimaticSummary
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsKeyFunction, clsGroupByFunction, clsDayFromAndTo, clsSummariseFunction, clsManipulationsFunction, clsRunCalcFunction As RFunction
    Private clsSumFunction, clsMaximaFunction, clsMinimaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, clsCountFunction, clsLengthFunction, clsProportionFunction, clsPercentileFunction, clsConcFunction As RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsMonthOperator As ROperator
    Dim strCurrDataName As String = ""
    Dim strGroupByCalcFrom As String = ""
    Private strTempFuc As String = ""
    Private Sub dlgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 510
        'setting selector
        ucrSelectorVariable.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVariable.SetParameterIsString()

        'setting up receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 1, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorVariable
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverDate.SetParameter(New RParameter("col_name", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsString()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorVariable
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("x", 0))
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.bWithQuotes = False
        ucrReceiverElement.strSelectorHeading = "Variables"
        ucrReceiverElement.Selector = ucrSelectorVariable
        ucrReceiverElement.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverElement.bAutoFill = True

        ucrReceiverFrom.Selector = ucrSelectorVariable
        ucrReceiverTo.Selector = ucrSelectorVariable

        ucrReceiverMonth.SetParameter(New RParameter("month", 0))
        ucrReceiverMonth.SetParameterIsRFunction()
        ucrReceiverMonth.bWithQuotes = False
        ucrReceiverMonth.strSelectorHeading = "Variables"
        ucrReceiverMonth.Selector = ucrSelectorVariable
        ucrReceiverMonth.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        ucrReceiverMonth.bAutoFill = True

        'setting up Nuds
        ucrNudFrom.SetParameter(New RParameter("from", 1))
        ucrNudFrom.SetMinMax(1, 365)

        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudTo.SetMinMax(2, 366)

        'panel setting
        ucrPnlAnnual.AddRadioButton(rdoAnnual)
        ucrPnlAnnual.AddRadioButton(rdoAnnualVariable)
        ucrPnlAnnual.AddRadioButton(rdoWithinYear)

        ucrInputSave.SetParameter(New RParameter("result_data_frame", 0))

        'linking controls
        ucrPnlAnnual.AddToLinkedControls({ucrNudFrom, ucrNudTo}, {rdoAnnual}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverFrom, ucrReceiverTo}, {rdoAnnualVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverMonth}, {rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrReceiverFrom.SetLinkedDisplayControl(lblReceiverFrom)
        ucrReceiverTo.SetLinkedDisplayControl(lblReceiverTo)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)
        'TODO:Disabled for now
        rdoAnnualVariable.Visible = False

        ucrPnlAnnual.AddParameterValuesCondition(rdoAnnual, "type", "filter")
        ucrPnlAnnual.AddParameterValuesCondition(rdoWithinYear, "type", "filter")
    End Sub

    Private Sub SetDefaults()
        bResetSubdialog = True
        clsKeyFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsDayFromAndTo = New RFunction
        clsRunCalcFunction = New RFunction
        clsSummariseFunction = New RFunction
        clsManipulationsFunction = New RFunction
        clsMinimaFunction = New RFunction
        clsMaximaFunction = New RFunction
        clsSumFunction = New RFunction
        clsMeanFunction = New RFunction
        clsMedianFunction = New RFunction
        clsSdFunction = New RFunction
        clsCountFunction = New RFunction
        clsLengthFunction = New RFunction
        clsProportionFunction = New RFunction
        clsPercentileFunction = New RFunction
        clsConcFunction = New RFunction

        clsDayFromOperator = New ROperator
        clsDayToOperator = New ROperator
        clsDayFromAndToOperator = New ROperator
        clsMonthOperator = New ROperator

        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366)
        clsDayFromAndTo.SetAssignTo("Day_From_and_To")

        clsGroupByFunction.SetRCommand("instat_calculation$new")
        clsGroupByFunction.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsGroupByFunction.SetAssignTo("Grouping")

        clsManipulationsFunction.SetRCommand("list")
        clsManipulationsFunction.AddParameter("sub_1", clsRFunctionParameter:=clsGroupByFunction, bIncludeArgumentName:=False)

        clsSummariseFunction.SetRCommand("instat_calculation$new")
        clsSummariseFunction.SetAssignTo("summary")
        clsSummariseFunction.AddParameter("type", Chr(34) & "summary" & Chr(34))
        clsSummariseFunction.AddParameter("save", 2)
        clsSummariseFunction.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationsFunction)

        clsKeyFunction.SetRCommand("InstatDataObject$add_key")

        clsSumFunction.SetRCommand("sum")
        clsMaximaFunction.SetRCommand("max")
        clsMinimaFunction.SetRCommand("min")
        clsMeanFunction.SetRCommand("mean")
        clsMedianFunction.SetRCommand("median")
        clsSdFunction.SetRCommand("sd")
        clsCountFunction.SetRCommand("which")
        clsLengthFunction.SetRCommand("length")
        clsPercentileFunction.SetRCommand("quantile")
        'clsConcFunction.SetRCommand("c")

        clsSumFunction.AddParameter("na.rm", "TRUE")
        clsMaximaFunction.AddParameter("na.rm", "TRUE")
        clsMinimaFunction.AddParameter("na.rm", "TRUE")
        clsMeanFunction.AddParameter("na.rm", "TRUE")
        clsMedianFunction.AddParameter("na.rm", "TRUE")
        clsSdFunction.AddParameter("na.rm", "TRUE")
        clsPercentileFunction.AddParameter("na.rm", "TRUE")

        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunction.AddParameter("calc", clsRFunctionParameter:=clsSummariseFunction, iPosition:=0)
        clsRunCalcFunction.AddParameter("display", "FALSE", iPosition:=1)
        SetGroupByOptions()
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsKeyFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsGroupByFunction, iPosition:=1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummariseFunction, iPosition:=3)
    End Sub

    Private Sub DayBoundaries()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
    End Sub

    Private Sub SetGroupByOptions()
        'Dim strCurrDataName As String = ""
        'Dim strGroupByCalcFrom As String = ""

        If Not ucrReceiverYear.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        ElseIf Not ucrReceiverStation.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        End If
        If strGroupByCalcFrom <> "" Then
            clsGroupByFunction.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsGroupByFunction.RemoveParameterByName("calculated_from")
        End If

    End Sub

    Private Sub SetSummaryParams()
        strCurrDataName = Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        If Not ucrReceiverElement.IsEmpty() Then
            clsSummariseFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")")
        Else
            clsSummariseFunction.RemoveParameterByName("calculated_from")
            clsSummariseFunction.RemoveParameterByName("function_exp")
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMedianFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMinimaFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMaximaFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsSdFunction, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)
        ucrReceiverMonth.SetRCode(clsMonthOperator, bReset)
        ucrReceiverElement.SetRCode(clsSumFunction, bReset)
        ucrSelectorVariable.SetRCode(clsKeyFunction, bReset)
        ucrReceiverDate.SetRCode(clsKeyFunction, bReset)
        'ucrPnlAnnual.SetRCode(clsGroupByFunction, bReset)
    End Sub

    'Private Sub SetAssignName()
    '    If Not ucrInputSave.bUserTyped Then
    '        If rdoAnnual.Checked Then
    '            ucrInputSave.SetName("Annual_summary")
    '        ElseIf rdoAnnualVariable.Checked Then
    '            ucrInputSave.SetName("Annual_variable_summary")
    '        ElseIf rdoWithinYear.Checked Then
    '            ucrInputSave.SetName("Within_year_summary")
    '        End If
    '    End If
    'End Sub

    Private Sub TestOkEnabled()
        If rdoAnnual.Checked Then
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoWithinYear.Checked Then
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdSummary_Click(sender As Object, e As EventArgs) Handles cmdSummary.Click
        sdgClimaticSummary.SetRCode(ucrBase.clsRsyntax, clsSummariseFunction, clsSumFunction, clsMinimaFunction, clsMaximaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, clsCountFunction, strTempFuc, clsLengthFunction, clsProportionFunction, clsPercentileFunction, clsConcFunction, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgClimaticSummary.ShowDialog()
    End Sub

    Private Sub ucrReceiverYear_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonth.ControlContentsChanged
        SetGroupByOptions()
    End Sub

    Private Sub ucrPnlAnnual_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnual.ControlContentsChanged
        If rdoAnnual.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsDayFromAndTo, iPosition:=2)
        ElseIf rdoWithinYear.Checked Then
            'If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty Then
            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverMonth.GetVariableNames() & ", " & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDayFromAndTo)
        ElseIf rdoAnnualVariable.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDayFromAndTo)
        End If
        If strGroupByCalcFrom <> "" Then
            clsGroupByFunction.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsGroupByFunction.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub ucrSelectorVariable_ControlContentsChanged(ucrChangedControl As ucrCore)
        DayBoundaries()
        SetSummaryParams()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayBoundaries()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrReceiverMonth.ControlContentsChanged
        SetSummaryParams()
        strTempFuc = ucrReceiverElement.GetVariableNames()
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrPnlAnnual.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class