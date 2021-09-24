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
    Private bRCodeSet As Boolean = True
    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction, clsConcFunction, clsSummariesList, clsDefaultFactors, clsDayFilterCalc, clsDayFilterCalcFromConvert, clsDayFilterCalcFromList, clsAddDateFunction As New RFunction
    Private clsFromAndToConditionOperator, clsFromConditionOperator, clsToConditionOperator As New ROperator

    Private Sub dlgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bRCodeSet = False
        If bFirstload Then
            iReceiverMaxY = ucrReceiverWithinYear.Location.Y
            iReceiverLabelMaxY = lblWithinYear.Location.Y
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bRCodeSet = True
        bReset = False
        WithinYearLabelReceiverLocation()
        SetFactors()
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    ' if within-year is checked, add within-year receiver
    ' if annual-variable is checked, add from.to receiver (or display!)
    ' if annual is checked, display from/to nuds

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 510
        ucrChkDropUnusedLevels.Enabled = False ' removed this functionality so this is disabled
        cmdMissingOptions.Enabled = False

        ucrSelectorVariable.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVariable.SetParameterIsString()

        'panel setting
        ucrPnlAnnualWithin.AddRadioButton(rdoAnnual)
        ucrPnlAnnualWithin.AddRadioButton(rdoAnnualWithinYear)
        ucrPnlAnnualWithin.AddRadioButton(rdoWithinYear)
        ucrPnlAnnualWithin.AddRadioButton(rdoStation)
        ucrPnlAnnualWithin.AddRadioButton(rdoDaily)

        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnual, "year", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnual, "within_variable", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnual, "date", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnualWithinYear, "within_variable", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnualWithinYear, "year", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnualWithinYear, "date", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoWithinYear, "within_variable", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoWithinYear, "year", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoWithinYear, "date", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoStation, "within_variable", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoStation, "year", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoStation, "date", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoDaily, "within_variable", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoDaily, "year", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoDaily, "date", True)

        'receivers:
        ' by receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 0, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorVariable
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameter(New RParameter("year", 1, False))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("within_variable", 2, False))
        ucrReceiverWithinYear.SetParameterIsString()
        'ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorVariable
        ucrReceiverWithinYear.SetIncludedDataTypes({"numeric", "factor"})

        ' others
        ucrReceiverDate.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsRFunction()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorVariable
        ucrReceiverDOY.SetClimaticType("doy")
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ' summary
        ucrReceiverElements.SetParameter(New RParameter("columns_to_summarise", 0))
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.strSelectorHeading = "Variables"
        ucrReceiverElements.Selector = ucrSelectorVariable
        ucrReceiverElements.SetIncludedDataTypes({"numeric"})

        ' Other checkbox options
        ucrChkStoreResults.SetParameter(New RParameter("store_results", 3))
        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 4))
        ucrChkPrintOutput.SetText("Print Results to Output Window")
        ucrChkPrintOutput.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkDropUnusedLevels.SetParameter(New RParameter("drop", 5))
        ucrChkDropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkDropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropUnusedLevels.SetRDefault("FALSE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkAddDateColumn.SetText("Add Date Column")
        ucrChkAddDateColumn.AddParameterPresentCondition(True, "data_name", True)
        ucrChkAddDateColumn.AddParameterPresentCondition(False, "data_name", False)

        'linking controls
        ucrPnlAnnualWithin.AddToLinkedControls({ucrReceiverYear}, {rdoAnnual, rdoAnnualWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrReceiverWithinYear}, {rdoAnnualWithinYear, rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrChkAddDateColumn}, {rdoAnnual, rdoAnnualWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)

        ucrInputFilterPreview.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsDefaultFactors = New RFunction
        clsConcFunction = New RFunction
        clsAddDateFunction = New RFunction

        clsFromAndToConditionOperator = New ROperator
        clsDayFilterCalc = New RFunction
        clsFromConditionOperator = New ROperator
        clsToConditionOperator = New ROperator

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        bResetSubdialog = True
        ucrSelectorVariable.Reset()
        ucrReceiverElements.SetMeAsReceiver()

        'TODO: this changes to from >= receiver and to <= receiver if annual-variable is checekd.
        clsFromAndToConditionOperator.bToScriptAsRString = True
        clsDayFilterCalc.SetRCommand("instat_calculation$new")
        clsDayFilterCalc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsDayFilterCalc.AddParameter("function_exp", clsROperatorParameter:=clsFromAndToConditionOperator, iPosition:=1)
        clsDayFilterCalc.AddParameter("calculated_from", clsRFunctionParameter:=clsDayFilterCalcFromConvert, iPosition:=2)

        clsFromAndToConditionOperator.SetOperation("&")
        clsFromAndToConditionOperator.bBrackets = False
        clsFromAndToConditionOperator.AddParameter("from", clsROperatorParameter:=clsFromConditionOperator, iPosition:=0)
        clsFromConditionOperator.SetOperation(">=") ' doy = DOYreceiver in position 0. This is always the case
        clsFromConditionOperator.AddParameter("from", 1, iPosition:=1)
        clsFromAndToConditionOperator.AddParameter("to", clsROperatorParameter:=clsToConditionOperator, iPosition:=1)
        clsToConditionOperator.SetOperation("<=") ' doy = DOYreceiver in position 0. This is always the case
        clsToConditionOperator.AddParameter("to", 366, iPosition:=1)
        clsDayFilterCalc.SetAssignTo("day_filter")

        'TODO: what defaults do we want?
        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False, iPosition:=3)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False, iPosition:=11)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("factors", clsRFunctionParameter:=clsDefaultFactors, iPosition:=1)
        clsDefaultFunction.AddParameter("additional_filter", clsRFunctionParameter:=clsDayFilterCalc, iPosition:=5)
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        clsDefaultFunction.AddParameter("silent", "TRUE")

        clsDefaultFactors.SetRCommand("c")
        clsConcFunction.SetRCommand("c")

        clsAddDateFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsAddDateFunction.AddParameter("factors", clsRFunctionParameter:=clsDefaultFactors, iPosition:=3)
        clsAddDateFunction.AddParameter("summaries", Chr(34) & "summary_min" & Chr(34), iPosition:=4)
        clsAddDateFunction.AddParameter("silent", "TRUE", iPosition:=5)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFromConditionOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)
        'This is currently not working. Selector should be able to pass additional parameter pairs!
        'ucrSelectorVariable.AddAdditionalCodeParameterPair(clsAddDateFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsToConditionOperator, bReset)
        ucrChkAddDateColumn.SetRCode(clsAddDateFunction, bReset)

        ucrSelectorVariable.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverElements.SetRCode(clsDefaultFunction, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrChkPrintOutput.SetRCode(clsDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverDate.SetRCode(clsAddDateFunction, bReset)

        ucrPnlAnnualWithin.SetRCode(clsDefaultFactors, bReset)
    End Sub

    'TODO: run these things at the correct times
    Public Sub TestOKEnabled()
        If Not clsSummariesList.clsParameters.Count = 0 AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso sdgSummaries.bOkEnabled Then
            If rdoAnnual.Checked Then
                If Not ucrReceiverDOY.IsEmpty AndAlso (Not ucrReceiverYear.IsEmpty OrElse Not ucrReceiverStation.IsEmpty) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoWithinYear.Checked Then
                If Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverWithinYear.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoAnnualWithinYear.Checked Then
                If Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverWithinYear.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoStation.Checked Then
                If Not ucrReceiverStation.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoDaily.Checked Then
                If Not ucrReceiverDOY.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        bRCodeSet = False
        SetDefaults()
        SetRCodeForControls(True)
        bRCodeSet = True
        SetFactors()
        TestOKEnabled()
    End Sub

    Private Sub cmdSummary_Click(sender As Object, e As EventArgs) Handles cmdSummary.Click
        sdgSummaries.SetRFunction(clsSummariesList, clsDefaultFunction, clsConcFunction, ucrSelectorVariable, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDoyRange_Click(sender As Object, e As EventArgs) Handles cmdDoyRange.Click
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFilterCalc, clsNewDayFromOperator:=clsFromConditionOperator, clsNewDayToOperator:=clsToConditionOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False))
        sdgDoyRange.ShowDialog()
        UpdateDayFilterPreview()
    End Sub

    Private Sub WithinYearLabelReceiverLocation()
        If rdoWithinYear.Checked Then
            lblWithinYear.Location = New Point(lblWithinYear.Location.X, iReceiverMaxY / 1.19)
            ucrReceiverWithinYear.Location = New Point(ucrReceiverWithinYear.Location.X, iReceiverLabelMaxY / 1.08)
        Else
            lblWithinYear.Location = New Point(lblWithinYear.Location.X, iReceiverLabelMaxY)
            ucrReceiverWithinYear.Location = New Point(ucrReceiverWithinYear.Location.X, iReceiverMaxY)
        End If
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If clsSummariesList.ContainsParameter("summary_cor") OrElse clsSummariesList.ContainsParameter("summary_cov") Then
            clsDefaultFunction.AddParameter("use", Chr(34) & "'na.or.complete'" & Chr(34))
        Else
            clsDefaultFunction.RemoveParameterByName("use")
        End If
        If Not ucrChkOmitMissing.Checked Then
            clsDefaultFunction.RemoveParameterByName("na_type")
        Else
            clsDefaultFunction.AddParameter("na_type", clsRFunctionParameter:=clsConcFunction, iPosition:=9)
        End If
        cmdMissingOptions.Enabled = ucrChkOmitMissing.Checked
    End Sub

    Private Sub cmdMissingOptions_Click(sender As Object, e As EventArgs) Handles cmdMissingOptions.Click
        sdgMissingOptions.SetRFunction(clsNewSummaryFunction:=clsDefaultFunction, clsNewConcFunction:=clsConcFunction, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgMissingOptions.ShowDialog()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorVariable.ControlValueChanged, ucrChkAddDateColumn.ControlValueChanged, ucrReceiverDate.ControlValueChanged
        If Not ucrReceiverDOY.IsEmpty Then
            clsDayFilterCalcFromList.AddParameter(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If

        If ucrChkAddDateColumn.Checked AndAlso Not ucrReceiverDate.IsEmpty Then
            clsAddDateFunction.AddParameter("data_name", Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        Else
            clsAddDateFunction.RemoveParameterByName("data_name")
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrPnlAnnualWithin_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnualWithin.ControlValueChanged
        WithinYearLabelReceiverLocation()
        SetFactors()
        If (rdoWithinYear.Checked AndAlso (ucrSelectorVariable.CurrentReceiver Is ucrReceiverYear)) OrElse (rdoAnnual.Checked AndAlso (ucrSelectorVariable.CurrentReceiver Is ucrReceiverWithinYear)) OrElse ((rdoStation.Checked OrElse rdoDaily.Checked) AndAlso ((ucrSelectorVariable.CurrentReceiver Is ucrReceiverWithinYear) OrElse (ucrSelectorVariable.CurrentReceiver Is ucrReceiverYear))) Then
            ucrReceiverElements.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrChkPrintOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintOutput.ControlValueChanged
        If ucrChkPrintOutput.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub ucrSelectorVariable_DataFrameChanged() Handles ucrSelectorVariable.DataFrameChanged
        clsDayFilterCalcFromList.ClearParameters()
    End Sub

    Private Sub UpdateDayFilterPreview()
        If ucrReceiverDOY.IsEmpty Then
            ucrInputFilterPreview.SetName("")
        Else
            ucrInputFilterPreview.SetName(clsFromAndToConditionOperator.ToScript())
        End If
    End Sub

    Private Sub SetFactors()
        If bRCodeSet Then
            If Not ucrReceiverStation.IsEmpty Then
                clsDefaultFactors.AddParameter(ucrReceiverStation.GetParameter())
            Else
                clsDefaultFactors.RemoveParameterByName("station")
            End If

            If rdoAnnual.Checked Then
                clsDefaultFactors.RemoveParameterByName("within_variable")
                clsDefaultFactors.RemoveParameterByName("date")
                clsDefaultFactors.AddParameter(ucrReceiverYear.GetParameter())
            ElseIf rdoAnnualWithinYear.Checked Then
                clsDefaultFactors.AddParameter(ucrReceiverWithinYear.GetParameter())
                clsDefaultFactors.AddParameter(ucrReceiverYear.GetParameter())
                clsDefaultFactors.RemoveParameterByName("date")
            ElseIf rdoWithinYear.Checked Then
                clsDefaultFactors.RemoveParameterByName("year")
                clsDefaultFactors.AddParameter(ucrReceiverWithinYear.GetParameter())
                clsDefaultFactors.RemoveParameterByName("date")
            ElseIf rdoStation.Checked Then
                clsDefaultFactors.RemoveParameterByName("within_variable")
                clsDefaultFactors.RemoveParameterByName("year")
                clsDefaultFactors.RemoveParameterByName("date")
            ElseIf rdoDaily.Checked Then
                clsDefaultFactors.RemoveParameterByName("within_variable")
                clsDefaultFactors.RemoveParameterByName("year")
                clsDefaultFactors.AddParameter("date", ucrReceiverDate.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
            End If
        End If
    End Sub

    Private Sub ucrChkAddDateColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddDateColumn.ControlValueChanged
        If ucrChkAddDateColumn.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsAddDateFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddDateFunction)
        End If
    End Sub

    Private Sub Receivers_controlValueChanged(ucrChangedControl As Control) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverWithinYear.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverElements.ControlValueChanged, ucrReceiverDOY.ControlValueChanged, ucrReceiverDate.ControlValueChanged
        SetFactors()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrReceiverWithinYear.ControlContentsChanged, ucrPnlAnnualWithin.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
