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
Imports instat
Imports instat.Translations

Public Class dlgOneVariableSummarise
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True
    Private clsSummaryFunction, clsSummariesList, clsGtFunction,
        clsConcFunction, clsSummaryTableFunction, clsDummyFunction,
        clsSkimrFunction, clsPivotWiderFunction As New RFunction

    Private clsTableTitleFunction, clsStubFunction, clsStubFootnoteFunction, clsStubCellsFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction, clsFootnoteTitleLocationFunction,
        clsFootnoteSubtitleLocationFunction, clsTabFootnoteSubtitleFunction, clsFootnoteCellFunction, clsFootnoteCellBodyFunction,
            clsSecondFootnoteCellFunction, clsSecondFootnoteCellBodyFunction, clsTabStyleFunction, clsTabStyleCellTextFunction,
            clsTabStylePxFunction, clsTabStyleCellTitleFunction, clsThemesTabOptionsFunction, clsgtExtraThemesFunction As New RFunction
    Private clsPipeOperator, clsJoiningPipeOperator As New ROperator
    Private clsSummaryOperator As New ROperator
    Private bResetSubdialog As Boolean = False
    Private bResetFormatSubdialog As Boolean = False
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing

    Private Sub dlgOneVariableSummarise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultColumn()
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 410
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        Dim dctDisplayMissing As New Dictionary(Of String, String)

        'The selector is only used for one of the functions. Therefore it's parameter name is always the same. So this can be done in Initialise.
        ucrSelectorOneVarSummarise.SetParameter(New RParameter("data_name", 0))
        ucrSelectorOneVarSummarise.SetParameterIsString()

        ucrReceiverOneVarSummarise.SetParameter(New RParameter("object", 1))
        ucrReceiverOneVarSummarise.SetParameterIsRFunction()
        ucrReceiverOneVarSummarise.Selector = ucrSelectorOneVarSummarise
        ucrReceiverOneVarSummarise.SetMeAsReceiver()

        ucrNudMaxSum.SetParameter(New RParameter("maxsum", 2))
        ucrNudMaxSum.SetMinMax(1, 12)
        ucrNudMaxSum.SetLinkedDisplayControl(lblMaxSum)

        ucrPnlSummaries.AddRadioButton(rdoDefault)
        ucrPnlSummaries.AddRadioButton(rdoCustomised)
        ucrPnlSummaries.AddRadioButton(rdoSkim)
        ucrPnlSummaries.AddParameterValuesCondition(rdoCustomised, "checked_radio", "customised")
        ucrPnlSummaries.AddParameterValuesCondition(rdoDefault, "checked_radio", "defaults")
        ucrPnlSummaries.AddParameterValuesCondition(rdoSkim, "checked_radio", "skim")
        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls({ucrChkOmitMissing, ucrPnlColumnFactor, ucrReorderSummary, ucrChkDisplayMissing},
                                            {rdoCustomised}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True
        ucrChkOmitMissing.SetLinkedDisplayControl(cmdMissingOptions)

        ucrPnlColumnFactor.AddRadioButton(rdoSummary)
        ucrPnlColumnFactor.AddRadioButton(rdoVariable)
        ucrPnlColumnFactor.AddRadioButton(rdoNoColumnFactor)
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoNoColumnFactor, "factor_cols", "NoColFactor")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoSummary, "factor_cols", "Sum")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoVariable, "factor_cols", "Var")
        ucrPnlColumnFactor.SetLinkedDisplayControl(grpColumns)

        ucrChkDisplayMissing.SetText("Display Missing")
        ucrChkDisplayMissing.AddParameterValuesCondition(True, "checked", "TRUE")
        ucrChkDisplayMissing.AddParameterValuesCondition(False, "checked", "FALSE")

        ucrInputDisplayMissing.SetParameter(New RParameter("na_display", 6))
        dctDisplayMissing.Add("NA", "NA")
        dctDisplayMissing.Add("(blank)", " ")
        dctDisplayMissing.Add(".", Chr(34) & "." & Chr(34))
        dctDisplayMissing.Add("...", Chr(34) & "..." & Chr(34))
        dctDisplayMissing.Add("---", Chr(34) & "---" & Chr(34))
        ucrInputDisplayMissing.SetItems(dctDisplayMissing)
        ucrInputDisplayMissing.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)
        ucrChkDisplayMissing.AddToLinkedControls({ucrInputDisplayMissing}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True,
                                                 bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="NA")

        ucrSaveSummary.SetPrefix("summary_table")
        ucrSaveSummary.SetDataFrameSelector(ucrSelectorOneVarSummarise.ucrAvailableDataFrames)
        ucrSaveSummary.SetIsComboBox()

        ucrReorderSummary.bDataIsSummaries = True
    End Sub

    Private Sub SetDefaults()
        clsSummariesList = New RFunction
        clsSummaryFunction = New RFunction
        clsConcFunction = New RFunction
        clsSummaryTableFunction = New RFunction
        clsGtFunction = New RFunction
        clsDummyFunction = New RFunction
        clsSkimrFunction = New RFunction
        clsSummaryOperator = New ROperator
        clsPivotWiderFunction = New RFunction

        clsTableTitleFunction = New RFunction
        clsTabFootnoteTitleFunction = New RFunction
        clsTableSourcenoteFunction = New RFunction
        clsFootnoteTitleLocationFunction = New RFunction
        clsFootnoteSubtitleLocationFunction = New RFunction
        clsPipeOperator = New ROperator
        clsTabFootnoteSubtitleFunction = New RFunction
        clsFootnoteCellBodyFunction = New RFunction
        clsSecondFootnoteCellBodyFunction = New RFunction
        clsFootnoteCellFunction = New RFunction
        clsSecondFootnoteCellFunction = New RFunction
        clsTabStyleFunction = New RFunction
        clsTabStyleCellTextFunction = New RFunction
        clsTabStylePxFunction = New RFunction
        clsTabStyleCellTitleFunction = New RFunction
        clsJoiningPipeOperator = New ROperator
        clsThemesTabOptionsFunction = New RFunction
        clsgtExtraThemesFunction = New RFunction

        ucrSelectorOneVarSummarise.Reset()

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.bBrackets = False

        clsThemesTabOptionsFunction.SetPackageName("gt")
        clsThemesTabOptionsFunction.SetRCommand("tab_options")

        clsgtExtraThemesFunction.SetPackageName("gtExtras")

        clsTabStyleFunction.SetRCommand("tab_style")
        clsTabStyleFunction.SetPackageName("gt")
        clsTabStyleFunction.AddParameter("style", clsRFunctionParameter:=clsTabStyleCellTextFunction, iPosition:=0)
        clsTabStyleFunction.AddParameter("location", clsRFunctionParameter:=clsTabStyleCellTitleFunction, iPosition:=1)

        clsTabStyleCellTitleFunction.SetPackageName("gt")
        clsTabStyleCellTitleFunction.SetRCommand("cells_title")
        clsTabStyleCellTitleFunction.AddParameter("groups", Chr(34) & "title" & Chr(34), iPosition:=0)

        clsTabStyleCellTextFunction.SetPackageName("gt")
        clsTabStyleCellTextFunction.SetRCommand("cell_text")
        clsTabStyleCellTextFunction.AddParameter("size", clsRFunctionParameter:=clsTabStylePxFunction, iPosition:=0)

        clsTabStylePxFunction.SetPackageName("gt")
        clsTabStylePxFunction.SetRCommand("px")
        clsTabStylePxFunction.AddParameter("size", "18", bIncludeArgumentName:=False, iPosition:=0)

        clsTableTitleFunction.SetPackageName("gt")
        clsTableTitleFunction.SetRCommand("tab_header")

        clsTabFootnoteTitleFunction.SetPackageName("gt")
        clsTabFootnoteTitleFunction.SetRCommand("tab_footnote")

        clsTabFootnoteSubtitleFunction.SetPackageName("gt")
        clsTabFootnoteSubtitleFunction.SetRCommand("tab_footnote")

        clsFootnoteCellFunction.SetPackageName("gt")
        clsFootnoteCellFunction.SetRCommand("tab_footnote")

        clsSecondFootnoteCellFunction.SetPackageName("gt")
        clsSecondFootnoteCellFunction.SetRCommand("tab_footnote")

        clsFootnoteTitleLocationFunction.SetPackageName("gt")
        clsFootnoteTitleLocationFunction.SetRCommand("cells_title")

        clsFootnoteSubtitleLocationFunction.SetPackageName("gt")
        clsFootnoteSubtitleLocationFunction.SetRCommand("cells_title")

        clsTableSourcenoteFunction.SetPackageName("gt")
        clsTableSourcenoteFunction.SetRCommand("tab_source_note")

        clsFootnoteCellBodyFunction.SetPackageName("gt")
        clsFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsSecondFootnoteCellBodyFunction.SetPackageName("gt")
        clsSecondFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")
        clsSkimrFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarSummarise.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsSkimrFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                            strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                            strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                            strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                            strObjectName:="last_summary")

        'Dummy function used to set conditions
        clsDummyFunction.AddParameter("checked_radio", "defaults", iPosition:=0)
        clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
        clsDummyFunction.AddParameter("checked", "FALSE", iPosition:=2)
        clsDummyFunction.AddParameter("theme", "select", iPosition:=11)

        clsConcFunction.SetRCommand("c")

        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=1)

        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=0)
        clsSummaryOperator.AddParameter("gttbl", clsRFunctionParameter:=clsGtFunction, iPosition:=2)

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
        clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                               strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                               strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                               strObjectName:="last_table")

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", "12", iPosition:=2)
        clsSummaryFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarSummarise.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsSummaryFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                                   strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                   strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                   strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                                   strObjectName:="last_summary")

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryTableFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarSummarise.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsSummaryTableFunction.AddParameter("treat_columns_as_factor", "TRUE", iPosition:=1)
        clsSummaryTableFunction.AddParameter("margins", Chr(34) & "summary" & Chr(34), iPosition:=2)
        clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=5)
        clsSummaryTableFunction.SetAssignTo("summary_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsSummaryTableFunction, New RParameter("na.rm", iNewPosition:=2), iAdditionalPairNo:=1)
        ucrSaveSummary.AddAdditionalRCode(clsSummaryFunction, iAdditionalPairNo:=1)
        ucrSaveSummary.AddAdditionalRCode(clsJoiningPipeOperator, iAdditionalPairNo:=2)
        ucrReceiverOneVarSummarise.SetRCode(clsSummaryFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)

        ucrPnlSummaries.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsSummaryTableFunction, bReset)
        ucrInputDisplayMissing.SetRCode(clsSummaryTableFunction, bReset)
        ucrSaveSummary.SetRCode(clsSkimrFunction, bReset)

        If bReset Then
            ucrChkDisplayMissing.SetRCode(clsDummyFunction, bReset)
            ucrPnlColumnFactor.SetRCode(clsDummyFunction, bReset)
            ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
        End If
        bRCodeSet = True
        FillListView()
    End Sub

    Public Sub TestOKEnabled()
        'We cannot test the values on the sub dialog because the sub dialog may not be in sync with the main dialog code. This only happens once the sub dialog has been opened.
        If ucrReceiverOneVarSummarise.IsEmpty() OrElse (rdoCustomised.Checked AndAlso clsSummariesList.clsParameters.Count = 0) OrElse ucrNudMaxSum.GetText = "" OrElse Not ucrSaveSummary.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, clsSummaryTableFunction, clsConcFunction, ucrSelectorOneVarSummarise, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.bEnable2VariableTab = False
        sdgSummaries.ShowDialog()
        sdgSummaries.bEnable2VariableTab = True
        FillListView()
        TestOKEnabled()
    End Sub

    Private Sub cmdMissingOptions_Click(sender As Object, e As EventArgs) Handles cmdMissingOptions.Click
        sdgMissingOptions.SetRFunction(clsNewSummaryFunction:=clsSummaryTableFunction, clsNewConcFunction:=clsConcFunction, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgMissingOptions.ShowDialog()
    End Sub

    Private Sub ucrReceiverDescribeOneVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlValueChanged
        If Not ucrReceiverOneVarSummarise.IsEmpty Then
            clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverOneVarSummarise.GetVariableNames(), iPosition:=4)
            clsSkimrFunction.AddParameter("col_names", ucrReceiverOneVarSummarise.GetVariableNames(),
                                          bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsSummaryTableFunction.RemoveParameterByName("columns_to_summarise")
            clsSkimrFunction.RemoveParameterByName("col_names")
        End If
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorOneVarSummarise.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumns IsNot Nothing AndAlso strDefaultColumns.Count > 0 Then
            For Each strVar As String In strDefaultColumns
                ucrReceiverOneVarSummarise.Add(strVar, strDefaultDataFrame)
            Next
        End If
        strDefaultDataFrame = ""
        strDefaultColumns = Nothing
    End Sub

    Private Sub ucrSelectorOneVarSummarise_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneVarSummarise.ControlValueChanged
        clsSkimrFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarSummarise.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsSummaryFunction._strDataFrameNameToAddAssignToObject = ucrSelectorOneVarSummarise.strCurrentDataFrame
        clsJoiningPipeOperator._strDataFrameNameToAddAssignToObject = ucrSelectorOneVarSummarise.strCurrentDataFrame
        clsSkimrFunction._strDataFrameNameToAddAssignToObject = ucrSelectorOneVarSummarise.strCurrentDataFrame
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If Not ucrChkOmitMissing.Checked Then
            clsSummaryTableFunction.RemoveParameterByName("na_type")
        Else
            clsSummaryTableFunction.AddParameter("na_type", clsRFunctionParameter:=clsConcFunction, iPosition:=9)
        End If
        cmdMissingOptions.Enabled = ucrChkOmitMissing.Checked
    End Sub

    Private Sub ucrPnlSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummaries.ControlValueChanged
        If rdoCustomised.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "customised", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
            ucrSaveSummary.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            ucrSaveSummary.SetAssignToIfUncheckedValue("last_table")
            ucrSaveSummary.SetCheckBoxText("Save Table")
        ElseIf rdoDefault.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "defaults", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
            ucrSaveSummary.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveSummary.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveSummary.SetCheckBoxText("Save Summary")
        ElseIf rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "skim", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSkimrFunction)
            ucrSaveSummary.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveSummary.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveSummary.SetCheckBoxText("Save Summary")
        End If
        cmdSummaries.Visible = rdoCustomised.Checked
        cmdFormatTable.Visible = rdoCustomised.Checked
    End Sub

    Private Sub FillListView()
        If clsSummariesList.clsParameters.Count > 0 Then
            ucrReorderSummary.lstAvailableData.Clear()
            ucrReorderSummary.lstAvailableData.Columns.Add("Summaries")
            ucrReorderSummary.lstAvailableData.Columns(0).Width = -2
            For i = 0 To clsSummariesList.clsParameters.Count - 1
                clsSummariesList.clsParameters(i).Position = i
                ucrReorderSummary.lstAvailableData.Items.Add(clsSummariesList.clsParameters(i).strArgumentName)
            Next
        Else
            ucrReorderSummary.lstAvailableData.Items.Clear()
        End If
    End Sub

    Private Sub ucrReorderSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReorderSummary.ControlValueChanged
        Dim lstOrderedSummaries As New List(Of RParameter)
        Dim iPosition As Integer = 0
        For i = 0 To ucrReorderSummary.lstAvailableData.Items.Count - 1
            lstOrderedSummaries.Add(clsSummariesList.GetParameter(ucrReorderSummary.lstAvailableData.Items(i).Text))
        Next

        clsSummariesList.ClearParameters()
        'Changing the parameter positions
        For Each clsParameter In lstOrderedSummaries
            clsParameter.Position = iPosition
            clsSummariesList.AddParameter(clsParameter)
            iPosition += 1
        Next
    End Sub

    Private Sub cmdFormatTable_Click(sender As Object, e As EventArgs) Handles cmdFormatTable.Click
        sdgFormatSummaryTables.SetRCode(clsNewStubFunction:=clsStubFunction, clsNewStubCellsFunction:=clsStubCellsFunction, clsNewStubFootnoteFunction:=clsStubFootnoteFunction, clsNewTableTitleFunction:=clsTableTitleFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                     clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                   clsNewPipeOperator:=clsPipeOperator, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                   clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                   clsNewMutableOPerator:=clsSummaryOperator, clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction,
                                   clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, clsNewThemesTabOptionFunction:=clsThemesTabOptionsFunction,
                                   clsNewgtExtraThemesFunction:=clsgtExtraThemesFunction, bReset:=bResetFormatSubdialog)

        sdgFormatSummaryTables.ShowDialog()
        bResetFormatSubdialog = False
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnFactor.ControlValueChanged
        'If bRCodeSet Then
        If rdoNoColumnFactor.Checked Then
            clsSummaryOperator.RemoveParameterByName("col_factor")
            clsDummyFunction.AddParameter("factor_cols", "NoColFactor", iPosition:=1)
        Else
            clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            If rdoSummary.Checked Then
                clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
                clsPivotWiderFunction.AddParameter("names_from", "summary", iPosition:=0)
            ElseIf rdoVariable.Checked Then
                clsDummyFunction.AddParameter("factor_cols", "Var", iPosition:=1)
                clsPivotWiderFunction.AddParameter("names_from", "variable", iPosition:=0)
            End If
        End If
        'End If
    End Sub
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlContentsChanged, ucrNudMaxSum.ControlContentsChanged, ucrSaveSummary.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class