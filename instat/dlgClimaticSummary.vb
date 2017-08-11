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
    Private clsKeyFunction, clsAddKeyColName, clsGroupByFunction, clsDayFromAndTo, clsSummariseFunction, clsManipulationsFunction, clsRunCalcFunction As New RFunction
    Private clsSumFunction, clsMaximaFunction, clsMinimaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, clsCountFunction, clsProportionFunction, clsPercentileFunction As New RFunction
    Private clsAboveFuction, clsTotalFunction, clsSubCalcFunction, clsLengthTotalFunction, clsLengthAboveFunction, clsWhichAboveFunction As New RFunction
    Private clsDayFromAndToOperator, clsDayFromOperator, clsDayToOperator, clsDivideOperator, clsMultipyOperator, clsWhichAboveFunctionOperator As New ROperator
    Private strCurrDataName As String = ""
    'Dim strGroupByCalcFrom As String = ""
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

        ucrReceiverDate.SetParameter(New RParameter("date", 1))
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
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverElement.SetParameter(New RParameter("x", 0))
        ucrReceiverElement.SetParameterIsRFunction()
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

        'linking controls
        ucrPnlAnnual.AddToLinkedControls(ucrNudFrom, {rdoAnnual}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls(ucrNudTo, {rdoAnnual}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverFrom, ucrReceiverTo}, {rdoAnnualVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnual.AddToLinkedControls({ucrReceiverMonth}, {rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrReceiverFrom.SetLinkedDisplayControl(lblReceiverFrom)
        ucrReceiverTo.SetLinkedDisplayControl(lblReceiverTo)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        'TODO:Disabled for now
        rdoAnnualVariable.Enabled = False

        ucrPnlAnnual.AddParameterValuesCondition(rdoAnnual, "type", "filter")
        ucrPnlAnnual.AddParameterValuesCondition(rdoWithinYear, "type", "filter")

        ' If this is to rename, i think this needs to be on the sub because htat's where you pick your variables.
        ucrInputSave.SetParameter(New RParameter("result_data_frame", 0))
    End Sub

    Private Sub SetDefaults()
        bResetSubdialog = True
        Dim strElementAboveHold As String = "element_above_hold"
        Dim strElementTotal As String = "total_for_element"
        Dim strProportions As String = "proportion"

        clsKeyFunction = New RFunction
        clsAddKeyColName = New RFunction
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
        clsProportionFunction = New RFunction
        clsPercentileFunction = New RFunction

        clsAboveFuction = New RFunction
        clsTotalFunction = New RFunction
        clsSubCalcFunction = New RFunction
        clsLengthTotalFunction = New RFunction
        clsLengthAboveFunction = New RFunction
        clsWhichAboveFunction = New RFunction
        clsWhichAboveFunctionOperator = New ROperator

        clsDayFromOperator = New ROperator
        clsDayToOperator = New ROperator
        clsDayFromAndToOperator = New ROperator
        clsDivideOperator = New ROperator
        clsMultipyOperator = New ROperator

        ucrSelectorVariable.Reset()

        clsKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsKeyFunction.AddParameter("col_name", clsRFunctionParameter:=clsAddKeyColName)
        clsAddKeyColName.SetRCommand("c")

        clsDayFromAndToOperator.bToScriptAsRString = True
        clsDayFromAndTo.SetRCommand("instat_calculation$new")
        clsDayFromAndTo.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFromAndTo.AddParameter("function_exp", clsROperatorParameter:=clsDayFromAndToOperator, iPosition:=1)
        clsDayFromAndToOperator.SetOperation("&")
        clsDayFromAndToOperator.AddParameter("from", clsROperatorParameter:=clsDayFromOperator, iPosition:=0)
        clsDayFromOperator.SetOperation(">=")
        clsDayFromOperator.AddParameter("from", 1, iPosition:=1)
        clsDayFromAndToOperator.AddParameter("to", clsROperatorParameter:=clsDayToOperator, iPosition:=1)
        clsDayToOperator.SetOperation("<=")
        clsDayToOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFromAndTo.SetAssignTo("day_from_and_to")

        clsGroupByFunction.SetRCommand("instat_calculation$new")
        clsGroupByFunction.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunction.SetAssignTo("grouping")

        ' For Proportion Option
        clsLengthAboveFunction.bToScriptAsRString = True
        clsAboveFuction.SetRCommand("instat_calculation$new")
        clsAboveFuction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsAboveFuction.AddParameter("function_exp", clsRFunctionParameter:=clsLengthAboveFunction, iPosition:=1)
        clsLengthAboveFunction.SetRCommand("length")
        clsLengthAboveFunction.AddParameter("which", clsRFunctionParameter:=clsWhichAboveFunction, bIncludeArgumentName:=False)
        clsWhichAboveFunction.SetRCommand("which")
        clsWhichAboveFunction.AddParameter("operator", clsROperatorParameter:=clsWhichAboveFunctionOperator, bIncludeArgumentName:=False) ' >, if > is our default on the sub
        clsWhichAboveFunctionOperator.SetOperation(">") ' if > is our default on the sub!
        ' element on the left hand side clsWhichAboveFunctionOperator.AddParameter("element", iPosition:=0)
        clsWhichAboveFunctionOperator.AddParameter("amount", 0.85, iPosition:=1)
        clsAboveFuction.AddParameter("result_name", Chr(34) & strElementAboveHold & Chr(34))
        clsAboveFuction.AddParameter("save", 0, iPosition:=4)
        clsAboveFuction.SetAssignTo(strElementAboveHold)

        clsLengthTotalFunction.bToScriptAsRString = True
        clsTotalFunction.SetRCommand("instat_calculation$new")
        clsTotalFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsTotalFunction.AddParameter("function_exp", clsRFunctionParameter:=clsLengthTotalFunction, iPosition:=1)
        clsLengthTotalFunction.SetRCommand("length")
        clsLengthTotalFunction.AddParameter("length", strTempFuc, bIncludeArgumentName:=False)
        clsTotalFunction.AddParameter("save", 0, iPosition:=2)
        clsTotalFunction.AddParameter("result_name", Chr(34) & strElementTotal & Chr(34), iPosition:=3)
        clsTotalFunction.SetAssignTo(strElementTotal)

        clsDivideOperator.bToScriptAsRString = True
        clsProportionFunction.SetRCommand("instat_calculation$new")
        clsProportionFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsProportionFunction.AddParameter("function_exp", clsROperatorParameter:=clsDivideOperator, iPosition:=1)
        clsDivideOperator.SetOperation("/")
        clsDivideOperator.AddParameter("sub_1", clsRFunctionParameter:=clsAboveFuction, iPosition:=0)
        clsDivideOperator.AddParameter("sub_2", clsRFunctionParameter:=clsTotalFunction, iPosition:=1)
        clsProportionFunction.AddParameter("save", 2, iPosition:=2)
        clsProportionFunction.AddParameter("result_name", Chr(34) & strProportions & Chr(34), iPosition:=3) ' TODO: this should be automatic on the sub.
        clsProportionFunction.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcFunction, iPosition:=4)
        clsProportionFunction.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationsFunction, iPosition:=5)
        clsProportionFunction.SetAssignTo("summary")
        clsSubCalcFunction.SetRCommand("list")
        clsSubCalcFunction.AddParameter("sub_1", clsRFunctionParameter:=clsAboveFuction, bIncludeArgumentName:=False)
        clsSubCalcFunction.AddParameter("sub_2", clsRFunctionParameter:=clsTotalFunction, bIncludeArgumentName:=False)

        ' Count
        ' set up here that 
        clsCountFunction.SetRCommand("length")
        clsCountFunction.AddParameter("which", clsRFunctionParameter:=clsWhichAboveFunction, bIncludeArgumentName:=False)

        ' if As Percentage is checked:
        clsMultipyOperator.SetOperation("*")
        clsMultipyOperator.AddParameter("sub_1", clsROperatorParameter:=clsDivideOperator, bIncludeArgumentName:=False, iPosition:=0)
        clsMultipyOperator.AddParameter("sub_2", "100", bIncludeArgumentName:=False, iPosition:=1)

        ' For other summaries:
        clsSummariseFunction.SetRCommand("instat_calculation$new")
        clsSummariseFunction.AddParameter("type", Chr(34) & "summary" & Chr(34), iPosition:=0)
        clsSummariseFunction.AddParameter("function_exp", Chr(34) & "sum" & Chr(34), iPosition:=1)
        'set default value
        clsSummariseFunction.AddParameter("save", 2, iPosition:=3)
        clsSummariseFunction.AddParameter("manipulations", clsRFunctionParameter:=clsManipulationsFunction, iPosition:=5)
        clsSummariseFunction.SetAssignTo("summary")

        ' For all summaries:
        clsManipulationsFunction.SetRCommand("list")
        clsManipulationsFunction.AddParameter("sub_1", clsRFunctionParameter:=clsGroupByFunction, bIncludeArgumentName:=False)

        clsSumFunction.SetRCommand("sum")
        clsSumFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsMaximaFunction.SetRCommand("max")
        clsMaximaFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsMinimaFunction.SetRCommand("min")
        clsMinimaFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsMedianFunction.SetRCommand("median")
        clsMedianFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsSdFunction.SetRCommand("sd")
        clsSdFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsPercentileFunction.SetRCommand("quantile")
        clsPercentileFunction.AddParameter("probs", 0.8, iPosition:=1)
        clsPercentileFunction.AddParameter("na.rm", "TRUE", iPosition:=2)

        clsRunCalcFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunction.AddParameter("display", "FALSE", iPosition:=1)
        ReceiverFocus()
        SetGroupByOptions()
        DayBoundaries()
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsKeyFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunction)
    End Sub

    Private Sub ReceiverFocus()
        If rdoAnnual.Checked Then
            ucrReceiverStation.SetMeAsReceiver()
        ElseIf rdoWithinYear.Checked Then
            ucrReceiverMonth.SetMeAsReceiver()
        End If
    End Sub

    Private Sub DayBoundaries()
        clsDayFromAndTo.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverDOY.GetVariableNames() & ")")
        clsAboveFuction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")")
    End Sub

    Private Sub SetGroupByOptions()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""
        strCurrDataName = Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        If rdoWithinYear.Checked Then
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty Then
                strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverMonth.GetVariableNames() & ", " & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
            End If
        ElseIf rdoAnnual.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsGroupByFunction, iPosition:=1)
            If Not ucrReceiverYear.IsEmpty Then
                strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
            ElseIf Not ucrReceiverStation.IsEmpty Then
                strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
            End If
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
            clsSummariseFunction.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverElement.GetVariableNames() & ")", iPosition:=4)
        Else
            clsSummariseFunction.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMedianFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMinimaFunction, New RParameter("x", 0), iAdditionalPairNo:=3)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsMaximaFunction, New RParameter("x", 0), iAdditionalPairNo:=4)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsSdFunction, New RParameter("x", 0), iAdditionalPairNo:=5)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsWhichAboveFunctionOperator, New RParameter("element", 0), iAdditionalPairNo:=6)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsPercentileFunction, New RParameter("x", 0), iAdditionalPairNo:=7)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsDayFromOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsDayToOperator, bReset)
        ucrNudFrom.SetRCode(clsDayFromOperator, bReset)
        ucrNudTo.SetRCode(clsDayToOperator, bReset)
        ucrReceiverElement.SetRCode(clsSumFunction, bReset)
        ucrSelectorVariable.SetRCode(clsKeyFunction, bReset)
        ucrReceiverDate.SetRCode(clsAddKeyColName, bReset)
        ucrReceiverStation.SetRCode(clsAddKeyColName, bReset)

        'ucrPnlAnnual.SetRCode(clsDayFromAndTo, bReset)
    End Sub

    'Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
    '    frmMain.clsRLink.RunScript(clsKeyFunction.ToScript, strComment:="Spells: Defining column(s) as key")
    'End Sub

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
        sdgClimaticSummary.SetRCode(ucrBase.clsRsyntax, clsSummariseFunction, clsSumFunction, clsMinimaFunction, clsMaximaFunction, clsMeanFunction, clsMedianFunction, clsSdFunction, strTempFuc, clsCountFunction, clsProportionFunction, clsPercentileFunction, clsAboveFuction, clsWhichAboveFunctionOperator, clsTotalFunction, clsWhichAboveFunction, clsRunCalcFunction, clsMultipyOperator, clsDivideOperator, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgClimaticSummary.ShowDialog()
    End Sub

    Private Sub ucrReceiverYear_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonth.ControlContentsChanged
        SetGroupByOptions()
    End Sub

    Private Sub ucrPnlAnnual_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnual.ControlContentsChanged
        SetGroupByOptions()
        ReceiverFocus()
        If rdoAnnual.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsDayFromAndTo)
        ElseIf rdoWithinYear.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDayFromAndTo)
        ElseIf rdoAnnualVariable.Checked Then
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsDayFromAndTo)
        End If
    End Sub

    Private Sub ucrSelectorVariable_ControlContentsChanged(ucrChangedControl As ucrCore)
        DayBoundaries()
        SetSummaryParams()
        SetGroupByOptions()
    End Sub

    Private Sub ucrReceiverDOY_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged
        DayBoundaries()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlValueChanged, ucrReceiverMonth.ControlContentsChanged
        SetSummaryParams()
        DayBoundaries()
        strTempFuc = ucrReceiverElement.GetVariableNames(bWithQuotes:=False)
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrPnlAnnual.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class