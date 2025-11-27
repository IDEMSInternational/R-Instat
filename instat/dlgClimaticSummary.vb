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

    Private clsDefaultFunction, clsIfElseFirstDoyFilledFunction, clsConcFunction, clsSummariesList,
        clsDefaultFactors, clsDayFilterCalc, clsDayFilterCalcFromConvert,
        clsDayFilterCalcFromList, clsAddDateFunction,
        clsDummyFunction, clsGetCalculationsFunction, clsGetDataFrameFunction,
        clsGetVaribalesMetadataFunction, clsGetSummaryVariablesFunction,
        clsGetDailyDataCalculationFunction, clsGetClimaticSummariesFunction, AddSaveDefinitionOptions() As New RFunction
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
        ucrPnlAnnualWithin.SetParameter(New RParameter("checked", 0))
        ucrPnlAnnualWithin.AddRadioButton(rdoAnnual, "annual")
        ucrPnlAnnualWithin.AddRadioButton(rdoAnnualWithinYear, "annual_within_year")
        ucrPnlAnnualWithin.AddRadioButton(rdoWithinYear, "within_year")
        ucrPnlAnnualWithin.AddRadioButton(rdoStation, "station")
        ucrPnlAnnualWithin.AddRadioButton(rdoDaily, "daily")

        ucrChkDayRange.SetText("Day Range")
        ucrChkDayRange.AddParameterValuesCondition(True, "day", "True")
        ucrChkDayRange.AddParameterValuesCondition(False, "day", "False")

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
        ucrReceiverWithinYear.SetClimaticType("month")
        ucrReceiverWithinYear.bAutoFill = True
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
        ucrReceiverDOY.SetParameterIsString()
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

        ucrChkDefinition.SetText("Definitions")
        ucrChkDefinition.AddParameterValuesCondition(True, "def", "True")
        ucrChkDefinition.AddParameterValuesCondition(False, "def", "False")

        'linking controls
        ucrPnlAnnualWithin.AddToLinkedControls({ucrReceiverYear}, {rdoAnnual, rdoAnnualWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrReceiverWithinYear}, {rdoAnnualWithinYear, rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrChkAddDateColumn}, {rdoAnnual, rdoAnnualWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlAnnualWithin.AddToLinkedControls({ucrChkDefinition}, {rdoAnnual, rdoWithinYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)
        ucrInputFilterPreview.IsReadOnly = True

        ucrChkDefinition.AddToLinkedControls(ucrSaveObject, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveObject.SetSaveType(strRObjectType:=RObjectTypeLabel.StructureLabel, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveObject.SetDataFrameSelector(ucrSelectorVariable.ucrAvailableDataFrames)
        ucrSaveObject.SetLabelText("Definition Object Name:")
        ucrSaveObject.SetIsComboBox()
        ucrSaveObject.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsDefaultFactors = New RFunction
        clsConcFunction = New RFunction
        clsAddDateFunction = New RFunction
        clsDummyFunction = New RFunction
        clsIfElseFirstDoyFilledFunction = New RFunction

        clsFromAndToConditionOperator = New ROperator
        clsDayFilterCalc = New RFunction
        clsFromConditionOperator = New ROperator
        clsToConditionOperator = New ROperator

        clsGetDataFrameFunction = New RFunction
        clsGetCalculationsFunction = New RFunction
        clsGetDailyDataCalculationFunction = New RFunction
        clsGetVaribalesMetadataFunction = New RFunction
        clsGetDailyDataCalculationFunction = New RFunction
        clsGetClimaticSummariesFunction = New RFunction

        Dim strLinkeddata As String = "linked_data_name"

        clsDayFilterCalcFromConvert = New RFunction
        clsDayFilterCalcFromConvert.SetPackageName("databook")
        clsDayFilterCalcFromConvert.SetRCommand("calc_from_convert")
        clsDayFilterCalcFromList = New RFunction
        clsDayFilterCalcFromList.SetRCommand("list")
        clsDayFilterCalcFromConvert.AddParameter("x", clsRFunctionParameter:=clsDayFilterCalcFromList, iPosition:=0)

        bResetSubdialog = True
        ucrSelectorVariable.Reset()
        ucrReceiverElements.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "annual", iPosition:=0)
        clsDummyFunction.AddParameter("day", "False", iPosition:=1)

        clsDummyFunction.AddParameter("def", "false", iPosition:=2)

        'TODO: this changes to from >= receiver and to <= receiver if annual-variable is checekd.
        clsFromAndToConditionOperator.bToScriptAsRString = True
        clsDayFilterCalc.SetRCommand("instatCalculations::instat_calculation$new")
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
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False, iPosition:=11)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("factors", clsRFunctionParameter:=clsDefaultFactors, iPosition:=1)
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        clsDefaultFunction.AddParameter("silent", "TRUE")

        clsDefaultFactors.SetRCommand("c")
        clsConcFunction.SetRCommand("c")

        ' 

        'Get DataFrame
        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "get_data_frame")
        clsGetDataFrameFunction.AddParameter(summary_data, strLinkeddata, iPosition:=0)
        clsGetDataFrameFunction.SetAssignTo("calculations_data")
        'Varibales MetaData
        clsGetVaribalesMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "get_variables_metadata")
        clsGetVaribalesMetadataFunction.AddParameter(summary_data, strLinkeddata, iPosition:=0)
        clsGetSummaryVariablesFunction.SetRCommand("variables_metadata")
        'Summary Variables
        clsGetSummaryVariablesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "get_summary_variables")
        clsGetSummaryVariablesFunction.AddParameter(summary_data, strLinkeddata, iPosition:=0)
        clsGetSummaryVariablesFunction.SetAssignTo("summary_variables")
        'daily_data_calculation
        clsGetDailyDataCalculationFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "get_daily_data_calculation")
        clsGetDailyDataCalculationFunction.AddParameter(summary_data, strLinkeddata, iPosition:=0)
        clsGetDailyDataCalculationFunction.SetAssignTo("daily_data_calculation")

        'get_climatic_summaries_definition
        clsGetClimaticSummariesFunction.SetRCommand("get_climatic_summaries_definition")
        clsGetClimaticSummariesFunction.AddParameter("calculations_data", clsRFunctionParameter:=clsGetCalculationsFunction, iPosition:=0)
        clsGetClimaticSummariesFunction.AddParameter("variables_metadata", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=1)
        clsGetClimaticSummariesFunction.AddParameter("summary_variables", clsRFunctionParameter:=clsCFunctionSummaryVars, iPosition:=2)
        clsGetClimaticSummariesFunction.AddParameter("daily_data_calculation", clsRFunctionParameter:=clsGetDailyCalculationsFunction, iPosition:=3)

        clsAddDateFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsAddDateFunction.AddParameter("factors", clsRFunctionParameter:=clsDefaultFactors, iPosition:=3)
        clsAddDateFunction.AddParameter("summaries", Chr(34) & "summary_min" & Chr(34), iPosition:=4)
        clsAddDateFunction.AddParameter("silent", "TRUE", iPosition:=5)
        AddDayRange()
        AddDateDoy()
        UpdateDateDoy()
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkAddDateColumn.SetRCode(clsAddDateFunction, bReset)
        ucrSelectorVariable.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverElements.SetRCode(clsDefaultFunction, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrSaveObject.AddAdditionalRCode(clsGetClimaticSummariesFunction, iAdditionalPairNo:=1)
        ucrChkPrintOutput.SetRCode(clsDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverDate.SetRCode(clsAddDateFunction, bReset)
        ucrPnlAnnualWithin.SetRCode(clsDummyFunction, bReset)
        ucrSaveObject.SetRCode(clsGetClimaticSummariesFunction, bReset)
        If bReset Then
            ucrChkDayRange.SetRCode(clsDummyFunction, bReset)
            ucrChkDefinition.SetRCode(clsDummyFunction, bReset)
        End If
        AddDateDoy()
        UpdateDateDoy()
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
        Dim bUseDate As Boolean = rdoStation.Checked
        sdgDoyRange.Setup(clsNewDoyFilterCalc:=clsDayFilterCalc, clsNewIfElseFirstDoyFilledFunction:=clsIfElseFirstDoyFilledFunction, clsNewDayFromOperator:=clsFromConditionOperator, clsNewDayToOperator:=clsToConditionOperator, clsNewCalcFromList:=clsDayFilterCalcFromList, strNewMainDataFrame:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strNewDoyColumn:=ucrReceiverDOY.GetVariableNames(False), bSetUseDateVisible:=True, bReset:=bResetSubdialog)
        sdgDoyRange.SetUseDateVisibility(bUseDate)
        If Not bUseDate Then
            sdgDoyRange.ucrChkUseDate.Checked = False
        End If
        sdgDoyRange.ShowDialog()
        UpdateDayFilterPreview()
        AddDayRange()
        AddDateDoy()
        UpdateDateDoy()
        bResetSubdialog = False

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
        AddSaveDefinitionOptions()
    End Sub

    Private Sub cmdMissingOptions_Click(sender As Object, e As EventArgs) Handles cmdMissingOptions.Click
        sdgMissingOptions.SetRFunction(clsNewSummaryFunction:=clsDefaultFunction, clsNewConcFunction:=clsConcFunction, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgMissingOptions.ShowDialog()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDOY.ControlValueChanged, ucrSelectorVariable.ControlValueChanged, ucrChkAddDateColumn.ControlValueChanged, ucrReceiverDate.ControlValueChanged
        UpdateDateDoy()
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
        ResetUseDateIfNotStation()
        If (rdoWithinYear.Checked AndAlso (ucrSelectorVariable.CurrentReceiver Is ucrReceiverYear)) OrElse (rdoAnnual.Checked AndAlso (ucrSelectorVariable.CurrentReceiver Is ucrReceiverWithinYear)) OrElse ((rdoStation.Checked OrElse rdoDaily.Checked) AndAlso ((ucrSelectorVariable.CurrentReceiver Is ucrReceiverWithinYear) OrElse (ucrSelectorVariable.CurrentReceiver Is ucrReceiverYear))) Then
            ucrReceiverElements.SetMeAsReceiver()
        End If
        AddDateDoy()
        UpdateDateDoy()
        AddSaveDefinitionOptions()
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
        If Not ucrReceiverDate.IsEmpty AndAlso sdgDoyRange.UseDateChecked Then
            ucrInputFilterPreview.SetName(clsFromAndToConditionOperator.ToScript())
        Else
            If ucrReceiverDOY.IsEmpty Then
                ucrInputFilterPreview.SetName("")
            Else
                ucrInputFilterPreview.SetName(clsFromAndToConditionOperator.ToScript())
            End If
        End If
        AddDateDoy()
        UpdateDateDoy()
        AddSaveDefinitionOptions()
    End Sub

    Private Sub SetFactors()
        If bRCodeSet Then
            clsLinkColsFunction.ClearParameters()
            If Not ucrReceiverStation.IsEmpty Then
                clsDefaultFactors.AddParameter(ucrReceiverStation.GetParameter())
                clsLinkColsFunction.AddParameter("station", ucrReceiverStation.GetVariableNames)
            Else
                clsDefaultFactors.RemoveParameterByName("station")
            End If

            If rdoAnnual.Checked Then
                clsDefaultFactors.RemoveParameterByName("within_variable")
                clsDefaultFactors.RemoveParameterByName("date")
                clsDefaultFactors.AddParameter(ucrReceiverYear.GetParameter())
                clsLinkColsFunction.AddParameter("year", ucrReceiverYear.GetVariableNames, bIncludeArgumentName:=False)
            ElseIf rdoAnnualWithinYear.Checked Then
                clsDefaultFactors.AddParameter(ucrReceiverWithinYear.GetParameter())
                clsDefaultFactors.AddParameter(ucrReceiverYear.GetParameter())
                clsDefaultFactors.RemoveParameterByName("date")
                clsLinkColsFunction.AddParameter("within_variable", ucrReceiverWithinYear.GetVariableNames, bIncludeArgumentName:=False)
                clsLinkColsFunction.AddParameter("year", ucrReceiverYear.GetVariableNames, bIncludeArgumentName:=False)
            ElseIf rdoWithinYear.Checked Then
                clsDefaultFactors.RemoveParameterByName("year")
                clsDefaultFactors.AddParameter(ucrReceiverWithinYear.GetParameter())
                clsDefaultFactors.RemoveParameterByName("date")
                clsLinkColsFunction.AddParameter("within_variable", ucrReceiverWithinYear.GetVariableNames, bIncludeArgumentName:=False)
            ElseIf rdoStation.Checked Then
                clsDefaultFactors.RemoveParameterByName("within_variable")
                clsDefaultFactors.RemoveParameterByName("year")
                clsDefaultFactors.RemoveParameterByName("date")
            ElseIf rdoDaily.Checked Then
                clsDefaultFactors.RemoveParameterByName("within_variable")
                clsDefaultFactors.RemoveParameterByName("year")
                clsDefaultFactors.AddParameter("date", ucrReceiverDOY.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
                clsLinkColsFunction.AddParameter("date", ucrReceiverDOY.GetVariableNames, bIncludeArgumentName:=False)
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
        AddDateDoy()
        UpdateDateDoy()
        AddSaveDefinitionOptions()
    End Sub

    Private Sub AddSaveDefinitionOptions()
        ' calculated_data <- data_book$get_calculations("<resulting data frame>")
        clsGetDataFrameFunction.AddParameter("summary_data", Chr(34) & ucrSaveObject.GetText() & Chr(34), iPosition:=0)
        clsGetCalculationsFunction.SetAssignTo("calculations_data")

        clsGetVaribalesMetadataFunction.AddParameter("summary_data", Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        clsGetDailyDataCalculationFunction.AddParameter("data_name", Chr(34) & ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        If ucrChkDefinition.Checked Then
            ' Add to R syntax (so it appears in the final R command)
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetClimaticSummariesFunction)

            If rdoAnnual.Checked Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsGetCalculationsFunction, iPosition:=13)
                'ucrSaveObject.SetPrefix("Annual_Definitions") <-- --> TODO Left out to understand why its not read in.
            End If

        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetClimaticSummariesFunction) ' <-- Need to understand why not to remove clsGetClimaticFunction
            If rdoAnnual.Checked Then
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetCalculationsFunction) ' <-- Also this
            End If
        End If

        If rdoWithinYear.Checked Then
            If ucrChkDefinition.Checked Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsGetCalculationsFunction, iPosition:=13)
                ucrSaveObject.SetPrefix("Within_Year_Definitions")

                If ucrChkDayRange.Checked Then
                    clsGetDailyCalculationsFunction.AddParameter("Day_Range", Chr(34) & ucrInputFilterPreview.GetText & Chr(34), iPosition:=2)
                End If
            Else
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetCalculationsFunction)
                If ucrChkDayRange.Checked Then
                    clsGetDailyCalculationsFunction.RemoveParameterByName("Day_Range")
                End If
            End If
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrReceiverWithinYear.ControlContentsChanged, ucrPnlAnnualWithin.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub AddDayRange()
        If ucrChkDayRange.Checked Then
            cmdDoyRange.Enabled = True
            ucrInputFilterPreview.Visible = True
            clsDefaultFunction.AddParameter("additional_filter", clsRFunctionParameter:=clsDayFilterCalc, iPosition:=5)
        Else
            cmdDoyRange.Enabled = False
            ucrInputFilterPreview.Visible = False
            clsDefaultFunction.RemoveParameterByName("additional_filter")
        End If
    End Sub

    Private Sub ucrChkDayRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDayRange.ControlValueChanged
        AddDayRange()
        AddSaveDefinitionOptions()
    End Sub

    Public Sub AddDateDoy()
        If rdoStation.Checked AndAlso sdgDoyRange.UseDateChecked Then
            clsFromConditionOperator.AddParameter("date", ucrReceiverDate.GetVariableNames(False), iPosition:=0)
            clsToConditionOperator.AddParameter("date", ucrReceiverDate.GetVariableNames(False), iPosition:=0)
            clsFromConditionOperator.RemoveParameterByName("doy")
            clsToConditionOperator.RemoveParameterByName("doy")
        Else
            clsFromConditionOperator.AddParameter("doy", ucrReceiverDOY.GetVariableNames(False), iPosition:=0)
            clsToConditionOperator.AddParameter("doy", ucrReceiverDOY.GetVariableNames(False), iPosition:=0)
            clsToConditionOperator.RemoveParameterByName("date")
            clsFromConditionOperator.RemoveParameterByName("date")
        End If
    End Sub

    Private Sub ucrChkDefinition()_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDefinition.ControlValueChanged, ucrPnlAnnualWithin.ControlValueChanged
        AddSaveDefinitionOptions()
    End Sub

    Private Sub ResetUseDateIfNotStation()
        If Not rdoStation.Checked Then
            sdgDoyRange.ResetUseDate()
            AddDateDoy()
            UpdateDateDoy()
            UpdateDayFilterPreview()
        End If
    End Sub

    Private Sub UpdateDateDoy()
        If rdoStation.Checked AndAlso sdgDoyRange.ucrChkUseDate.Checked Then
            If Not ucrReceiverDate.IsEmpty Then
                clsDayFilterCalcFromList.AddParameter(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDate.GetVariableNames(), iPosition:=0)
            Else
                clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            End If
        Else
            If Not ucrReceiverDOY.IsEmpty Then
                clsDayFilterCalcFromList.AddParameter(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strParameterValue:=ucrReceiverDOY.GetVariableNames(), iPosition:=0)
            Else
                clsDayFilterCalcFromList.RemoveParameterByName(ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            End If
        End If
    End Sub
End Class
