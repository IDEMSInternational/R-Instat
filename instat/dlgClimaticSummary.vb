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
    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction, clsSummariesList, clsDefaultFactors, clsDayFilterCalc, clsDayFilterCalcFromConvert, clsDayFilterCalcFromList As New RFunction
    Private clsFromAndToConditionOperator, clsFromConditionOperator, clsToConditionOperator As New ROperator

    Private Sub dlgClimaticSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        bReset = False
        autoTranslate(Me)
        WithinYearLabelReceiverLocation()
        TestOKEnabled()
    End Sub

    ' if within-year is checked, add within-year receiver
    ' if annual-variable is checked, add from.to receiver (or display!)
    ' if annual is checked, display from/to nuds

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 510
        ucrChkDropUnusedLevels.Enabled = False ' removed this functionality so this is disabled

        ucrSelectorVariable.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVariable.SetParameterIsString()

        'panel setting
        ucrPnlAnnualWithin.AddRadioButton(rdoAnnual)
        ucrPnlAnnualWithin.AddRadioButton(rdoAnnualWithinYear)
        ucrPnlAnnualWithin.AddRadioButton(rdoWithinYear)

        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnual, "within_variable", False)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnualWithinYear, "within_variable", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoAnnualWithinYear, "year", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoWithinYear, "within_variable", True)
        ucrPnlAnnualWithin.AddParameterPresentCondition(rdoWithinYear, "year", False)

        'receivers:
        ' by receivers
        ucrReceiverStation.SetParameter(New RParameter("station", 0, False))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorVariable
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.SetParameter(New RParameter("year", 1, False))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("within_variable", 2, False))
        ucrReceiverWithinYear.SetParameterIsString()
        'ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorVariable
        ucrReceiverWithinYear.SetIncludedDataTypes({"numeric", "factor"})

        ' others
        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDOY.SetParameter(New RParameter("day", 0))
        ucrReceiverDOY.SetParameterIsRFunction()
        ucrReceiverDOY.bWithQuotes = False
        ucrReceiverDOY.Selector = ucrSelectorVariable
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ' summary
        ucrReceiverElement.SetParameter(New RParameter("columns_to_summarise", 0))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.strSelectorHeading = "Variables"
        ucrReceiverElement.Selector = ucrSelectorVariable
        ucrReceiverElement.SetIncludedDataTypes({"numeric"})
        ucrReceiverElement.bAutoFill = True

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

        'linking controls
        ucrPnlAnnualWithin.AddToLinkedControls({ucrReceiverYear}, {rdoAnnual, rdoAnnualWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrReceiverWithinYear}, {rdoAnnualWithinYear, rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrChkAddDateColumn}, {rdoAnnualWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)

        ucrInputFilterPreview.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsDefaultFactors = New RFunction

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
        ucrReceiverElement.SetMeAsReceiver()
        ucrChkAddDateColumn.Enabled = False
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
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("factors", clsRFunctionParameter:=clsDefaultFactors, iPosition:=1)
        clsDefaultFunction.AddParameter("additional_filter", clsRFunctionParameter:=clsDayFilterCalc, iPosition:=5)
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        clsDefaultFunction.AddParameter("silent", "TRUE")

        clsDefaultFactors.SetRCommand("c")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDOY.AddAdditionalCodeParameterPair(clsFromConditionOperator, New RParameter("doy", 0), iAdditionalPairNo:=1)

        ucrReceiverDOY.SetRCode(clsToConditionOperator, bReset)

        ucrSelectorVariable.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverElement.SetRCode(clsDefaultFunction, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrChkPrintOutput.SetRCode(clsDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, bReset)

        ucrPnlAnnualWithin.SetRCode(clsDefaultFactors, bReset)
        ucrReceiverStation.SetRCode(clsDefaultFactors, bReset)
        ucrReceiverYear.SetRCode(clsDefaultFactors, bReset)
        ucrReceiverWithinYear.SetRCode(clsDefaultFactors, bReset)
    End Sub

    'TODO: run these things at the correct times
    Public Sub TestOKEnabled()
        If Not clsSummariesList.clsParameters.Count = 0 AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso sdgSummaries.bOkEnabled Then
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
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummary_Click(sender As Object, e As EventArgs) Handles cmdSummary.Click
        sdgSummaries.SetRFunction(clsSummariesList, clsDefaultFunction, ucrSelectorVariable, bResetSubdialog)
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
            lblWithinYear.Location = New Point(lblWithinYear.Location.X, iReceiverMaxY / 1.25)
            ucrReceiverWithinYear.Location = New Point(ucrReceiverWithinYear.Location.X, iReceiverLabelMaxY / 1.11)
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
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorVariable.ControlValueChanged
        If Not ucrReceiverDOY.IsEmpty Then
            clsDayFilterCalcFromList.AddParameter(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
        Else
            clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
        UpdateDayFilterPreview()
    End Sub

    Private Sub ucrPnlAnnualWithin_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAnnualWithin.ControlValueChanged
        WithinYearLabelReceiverLocation()
    End Sub

    Private Sub ucrChkPrintOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintOutput.ControlValueChanged
        If ucrChkPrintOutput.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverWithinYear.ControlContentsChanged, ucrPnlAnnualWithin.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged
        TestOKEnabled()
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
End Class