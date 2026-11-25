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
    Public enumOnevariableMode As String = OnevariableMode.Prepare
    Public Enum OnevariableMode
        Prepare
        Describe
        Climatic
        Tricot
    End Enum

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRCodeSet As Boolean = True
    Private bUpdatingSkimMultipleRCode As Boolean = False
    Private clsSummaryFunction, clsSummariesList, clsGtFunction,
        clsConcFunction, clsSummaryTableFunction, clsDummyFunction,
        clsSkimrFunction, clsPivotWiderFunction, clsSelectedColumnsFunction,
        clsSelectFunction, clsWhereFunction, clsMapDfrFunction,
        clsSkimDataNamesFunction, clsSkimDataNamesNmFunction,
        clsSetNamesFunction, clsRelocateFunction As New RFunction

    Private clsPipeOperator, clsJoiningPipeOperator, clsSkimMultiplePipeOperator As New ROperator
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
        SetHelpOptions()
        SetDefaultColumn()
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 735
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        Dim dctDisplayMissing As New Dictionary(Of String, String)

        'The selector is only used for one of the functions. Therefore it's parameter name is always the same. So this can be done in Initialise.
        ucrSelectorOneVarSummarise.SetParameter(New RParameter("data_name", 0))
        ucrSelectorOneVarSummarise.SetParameterIsString()

        ucrReceiverOneVarSummarise.SetParameter(New RParameter("object", 1))
        ucrReceiverOneVarSummarise.SetParameterIsRFunction()
        ucrReceiverOneVarSummarise.bForceAsDataFrame = True
        ucrReceiverOneVarSummarise.Selector = ucrSelectorOneVarSummarise
        ucrReceiverOneVarSummarise.SetMeAsReceiver()

        ucrReceiverMultipleDataFrames.Selector = ucrSelectorMultipleDataFrames
        ucrReceiverMultipleDataFrames.SetItemType("dataframe")
        ucrReceiverMultipleDataFrames.strSelectorHeading = "Data Frames"
        ucrReceiverMultipleDataFrames.SetMeAsReceiver()

        ucrNudMaxSum.SetParameter(New RParameter("maxsum", 2))
        ucrNudMaxSum.SetMinMax(1, 100)
        ucrNudMaxSum.SetLinkedDisplayControl(lblMaxSum)

        ucrPnlSummaries.AddRadioButton(rdoDefault)
        ucrPnlSummaries.AddRadioButton(rdoSkim)
        ucrPnlSummaries.AddRadioButton(rdoSkimMultiple)
        ucrPnlSummaries.AddRadioButton(rdoCustomised)
        ucrPnlSummaries.AddParameterValuesCondition(rdoDefault, "checked_radio", "defaults")
        ucrPnlSummaries.AddParameterValuesCondition(rdoSkim, "checked_radio", "skim")
        ucrPnlSummaries.AddParameterValuesCondition(rdoSkimMultiple, "checked_radio", "skim_multiple")
        ucrPnlSummaries.AddParameterValuesCondition(rdoCustomised, "checked_radio", "customised")
        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls({ucrChkOmitMissing, ucrPnlColumnFactor, ucrReorderSummary, ucrChkDisplayMissing},
                                            {rdoCustomised}, bNewLinkedHideIfParameterMissing:=True)
        ' Swap selectors/receivers by mode (same pattern as dlgExportToCPT / dlgHideDataframes)
        ucrPnlSummaries.AddToLinkedControls({ucrSelectorOneVarSummarise, ucrReceiverOneVarSummarise},
                                            {rdoDefault, rdoSkim, rdoCustomised}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls({ucrSelectorMultipleDataFrames, ucrReceiverMultipleDataFrames, ucrPnlDataType},
                                            {rdoSkimMultiple}, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverOneVarSummarise.SetLinkedDisplayControl(lblSelectedVariable)
        ucrReceiverMultipleDataFrames.SetLinkedDisplayControl(lblSelectedDataFrames)
        ucrPnlDataType.SetLinkedDisplayControl(grpDataType)

        ucrPnlDataType.AddRadioButton(rdoCharacter)
        ucrPnlDataType.AddRadioButton(rdoFactor)
        ucrPnlDataType.AddRadioButton(rdoNumeric)
        ucrPnlDataType.AddParameterValuesCondition(rdoCharacter, "data_type", "character")
        ucrPnlDataType.AddParameterValuesCondition(rdoFactor, "data_type", "factor")
        ucrPnlDataType.AddParameterValuesCondition(rdoNumeric, "data_type", "numeric")

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
        clsPivotWiderFunction = New RFunction
        clsSelectedColumnsFunction = New RFunction
        clsSelectFunction = New RFunction
        clsWhereFunction = New RFunction
        clsMapDfrFunction = New RFunction
        clsSkimDataNamesFunction = New RFunction
        clsSkimDataNamesNmFunction = New RFunction
        clsSetNamesFunction = New RFunction
        clsRelocateFunction = New RFunction

        clsPipeOperator = New ROperator
        clsSkimMultiplePipeOperator = New ROperator
        clsSummaryOperator = New ROperator

        ucrSelectorOneVarSummarise.Reset()
        ucrSelectorMultipleDataFrames.Reset()

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.bBrackets = False

        ' Original Skim: skim selected columns from one data frame
        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")
        clsSkimrFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarSummarise.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsSkimrFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                            strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                            strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                            strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                            strObjectName:="last_summary")

        ' Skim - Multiple: filter by type across data frames
        clsWhereFunction.SetPackageName("tidyselect")
        clsWhereFunction.SetRCommand("where")
        clsWhereFunction.AddParameter("fn", "is.character", bIncludeArgumentName:=False, iPosition:=0)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("cols", clsRFunctionParameter:=clsWhereFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsSkimDataNamesFunction.SetRCommand("c")
        clsSkimDataNamesNmFunction.SetRCommand("c")
        clsSetNamesFunction.SetRCommand("setNames")
        clsSetNamesFunction.AddParameter("object", clsRFunctionParameter:=clsSkimDataNamesFunction, iPosition:=0)
        clsSetNamesFunction.AddParameter("nm", clsRFunctionParameter:=clsSkimDataNamesNmFunction, iPosition:=1)

        clsMapDfrFunction.SetPackageName("purrr")
        clsMapDfrFunction.SetRCommand("map_dfr")
        clsMapDfrFunction.AddParameter(".x", clsRFunctionParameter:=clsSetNamesFunction, iPosition:=0)
        clsMapDfrFunction.AddParameter(".f", GetSkimMapFormula(), iPosition:=1)
        clsMapDfrFunction.AddParameter(".id", Chr(34) & "data_frame" & Chr(34), iPosition:=2)

        ' Put data_frame first so it is visible without widening the output window
        clsRelocateFunction.SetPackageName("dplyr")
        clsRelocateFunction.SetRCommand("relocate")
        clsRelocateFunction.AddParameter("data_frame", "data_frame", bIncludeArgumentName:=False, iPosition:=0)

        clsSkimMultiplePipeOperator.SetOperation("%>%")
        clsSkimMultiplePipeOperator.bBrackets = False
        clsSkimMultiplePipeOperator.AddParameter("map", clsRFunctionParameter:=clsMapDfrFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSkimMultiplePipeOperator.AddParameter("relocate", clsRFunctionParameter:=clsRelocateFunction, iPosition:=1, bIncludeArgumentName:=False)

        'Dummy function used to set conditions
        clsDummyFunction.AddParameter("checked_radio", "defaults", iPosition:=0)
        clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
        clsDummyFunction.AddParameter("checked", "FALSE", iPosition:=2)
        clsDummyFunction.AddParameter("theme", "select", iPosition:=11)
        clsDummyFunction.AddParameter("data_type", "character", iPosition:=13)

        clsConcFunction.SetRCommand("c")

        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=1)

        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=0)
        clsSummaryOperator.AddParameter(strParameterName:="gt_tbl", clsRFunctionParameter:=clsGtFunction, iPosition:=2, bIncludeArgumentName:=False)


        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
        clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                               strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                               strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                               strObjectName:="last_table")

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count_all", Chr(34) & "summary_count_all" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSelectedColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsSelectedColumnsFunction.AddParameter("force_as_data_frame", "TRUE", iPosition:=2)
        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", "12", iPosition:=2)
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsSelectedColumnsFunction, iPosition:=0)
        clsSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=3)
        clsSummaryFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                                   strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                   strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                   strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                                   strObjectName:="last_summary")

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
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
        ucrSaveSummary.AddAdditionalRCode(clsSkimrFunction, iAdditionalPairNo:=3)
        ucrSaveSummary.AddAdditionalRCode(clsSkimMultiplePipeOperator, iAdditionalPairNo:=4)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)

        ucrPnlSummaries.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsSummaryTableFunction, bReset)
        ucrInputDisplayMissing.SetRCode(clsSummaryTableFunction, bReset)
        ucrSaveSummary.SetRCode(clsSkimrFunction, bReset)

        If bReset Then
            ucrChkDisplayMissing.SetRCode(clsDummyFunction, bReset)
            ucrPnlColumnFactor.SetRCode(clsDummyFunction, bReset)
            ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
            ucrPnlDataType.SetRCode(clsDummyFunction, bReset)
        End If
        bRCodeSet = True
        FillListView()
        SetActiveReceiverForMode()
    End Sub

    Public Sub TestOKEnabled()
        If rdoSkimMultiple.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverMultipleDataFrames.IsEmpty() AndAlso ucrSaveSummary.IsComplete)
        ElseIf ucrReceiverOneVarSummarise.IsEmpty() OrElse (rdoCustomised.Checked AndAlso clsSummariesList.clsParameters.Count = 0) OrElse ucrNudMaxSum.GetText = "" OrElse Not ucrSaveSummary.IsComplete Then
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
            clsSelectedColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorOneVarSummarise.strCurrentDataFrame & Chr(34), iPosition:=0)
            clsSelectedColumnsFunction.AddParameter("col_names", ucrReceiverOneVarSummarise.GetVariableNames(), iPosition:=1)
        Else
            clsSummaryTableFunction.RemoveParameterByName("columns_to_summarise")
            clsSkimrFunction.RemoveParameterByName("col_names")
            clsSelectedColumnsFunction.RemoveParameterByName("col_names")
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumOnevariableMode
            Case OnevariableMode.Prepare
                ucrBase.iHelpTopicID = 550
            Case OnevariableMode.Describe
                ucrBase.iHelpTopicID = 410
            Case OnevariableMode.Climatic
                ucrBase.iHelpTopicID = 615
            Case OnevariableMode.Tricot
                ucrBase.iHelpTopicID = 735
        End Select
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
        clsSelectedColumnsFunction.SetAssignTo(ucrSelectorOneVarSummarise.strCurrentDataFrame)
        If Not ucrReceiverOneVarSummarise.IsEmpty Then
            clsSelectedColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorOneVarSummarise.strCurrentDataFrame & Chr(34), iPosition:=0)
        End If
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
            ucrSaveSummary.SetCheckBoxText("Store Table")
            ucrSaveSummary.SetPrefix("summary_table")
            ucrSaveSummary.SetRCode(clsJoiningPipeOperator, False)
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoDefault.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "defaults", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
            ucrSaveSummary.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveSummary.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveSummary.SetCheckBoxText("Store Summary")
            ucrSaveSummary.SetPrefix("summary")
            ucrSaveSummary.SetRCode(clsSummaryFunction, False)
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "skim", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSkimrFunction)
            ucrSaveSummary.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveSummary.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveSummary.SetCheckBoxText("Store Summary")
            ucrSaveSummary.SetPrefix("summary")
            ucrSaveSummary.SetRCode(clsSkimrFunction, False)
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoSkimMultiple.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "skim_multiple", iPosition:=0)
            ucrSaveSummary.SetSaveTypeAsDataFrame()
            ucrSaveSummary.SetAssignToIfUncheckedValue("")
            ucrSaveSummary.SetCheckBoxText("Store Data Frame")
            ucrSaveSummary.SetPrefix("skim")
            ucrSaveSummary.SetRCode(clsSkimMultiplePipeOperator, False)
            UpdateSkimMultipleRCode()
        End If
        cmdSummaries.Visible = rdoCustomised.Checked
        cmdTableOptions.Visible = rdoCustomised.Checked
        ConfigureColumnFactorsAndNames()
        SetActiveReceiverForMode()
        TestOKEnabled()
    End Sub

    Private Sub SetActiveReceiverForMode()
        If rdoSkimMultiple.Checked Then
            ucrReceiverMultipleDataFrames.SetMeAsReceiver()
            UpdateSkimMultipleRCode()
        Else
            ucrReceiverOneVarSummarise.SetMeAsReceiver()
        End If
    End Sub

    Private Function GetSkimTypePredicate() As String
        If rdoFactor.Checked Then
            Return "is.factor"
        ElseIf rdoNumeric.Checked Then
            Return "is.numeric"
        Else
            Return "is.character"
        End If
    End Function

    Private Function GetSkimMapFormula() As String
        Return "~skimr::skim_without_charts(dplyr::select(" &
            frmMain.clsRLink.strInstatDataObject & "$get_data_frame(data_name=.x), tidyselect::where(" &
            GetSkimTypePredicate() & ")))"
    End Function

    Private Sub UpdateSkimMultipleRCode()
        If Not bRCodeSet OrElse Not rdoSkimMultiple.Checked OrElse bUpdatingSkimMultipleRCode Then
            Return
        End If

        bUpdatingSkimMultipleRCode = True
        Try
            Dim strType As String = GetSkimTypePredicate()
            clsWhereFunction.AddParameter("fn", strType, bIncludeArgumentName:=False, iPosition:=0)

            If rdoFactor.Checked Then
                clsDummyFunction.AddParameter("data_type", "factor", iPosition:=13)
            ElseIf rdoNumeric.Checked Then
                clsDummyFunction.AddParameter("data_type", "numeric", iPosition:=13)
            Else
                clsDummyFunction.AddParameter("data_type", "character", iPosition:=13)
            End If

            clsSkimDataNamesFunction.ClearParameters()
            clsSkimDataNamesNmFunction.ClearParameters()
            For Each strDf As String In ucrReceiverMultipleDataFrames.GetVariableNamesAsList()
                clsSkimDataNamesFunction.AddParameter(strDf, Chr(34) & strDf & Chr(34), bIncludeArgumentName:=False)
                clsSkimDataNamesNmFunction.AddParameter(strDf, Chr(34) & strDf & Chr(34), bIncludeArgumentName:=False)
            Next
            clsMapDfrFunction.AddParameter(".f", GetSkimMapFormula(), iPosition:=1)
            ucrBase.clsRsyntax.SetBaseROperator(clsSkimMultiplePipeOperator)

            If ucrSaveSummary.ucrChkSave.Checked Then
                ucrBase.clsRsyntax.iCallType = 0
            Else
                ucrBase.clsRsyntax.iCallType = 2
            End If
        Finally
            bUpdatingSkimMultipleRCode = False
        End Try
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

    Private Sub cmdTableOptions_Click(sender As Object, e As EventArgs) Handles cmdTableOptions.Click
        sdgTableOptions.Setup(ucrSelectorOneVarSummarise.strCurrentDataFrame, clsSummaryOperator, {EnumTableSubDialogTab.Header, EnumTableSubDialogTab.SourceNotes,
                                  EnumTableSubDialogTab.Themes, EnumTableSubDialogTab.OtherStyle,
                                  EnumTableSubDialogTab.Table})
        sdgTableOptions.ShowDialog(Me)
        bResetFormatSubdialog = False
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnFactor.ControlValueChanged
        ConfigureColumnFactorsAndNames()
    End Sub

    Private Sub ConfigureColumnFactorsAndNames()
        If rdoCustomised.Checked Then
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
        Else
            clsSummaryOperator.RemoveParameterByName("col_factor")
            clsPivotWiderFunction.RemoveParameterByName("names_from")
        End If
    End Sub

    Private Sub SkimMultipleOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDataType.ControlValueChanged
        If Not bRCodeSet OrElse Not rdoSkimMultiple.Checked Then
            Return
        End If
        UpdateSkimMultipleRCode()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverMultipleDataFrames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleDataFrames.ControlValueChanged
        If rdoSkimMultiple.Checked Then
            UpdateSkimMultipleRCode()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveSummary.ControlValueChanged
        If rdoSkimMultiple.Checked AndAlso Not bUpdatingSkimMultipleRCode Then
            If ucrSaveSummary.ucrChkSave.Checked Then
                ucrBase.clsRsyntax.iCallType = 0
            Else
                ucrBase.clsRsyntax.iCallType = 2
            End If
        End If
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlContentsChanged, ucrNudMaxSum.ControlContentsChanged, ucrReceiverMultipleDataFrames.ControlContentsChanged, ucrSaveSummary.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
