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
    Private clsSummaryOperator As New ROperator
    Private bResetSubdialog As Boolean = False
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing
    Private Const iMaxSum = 12

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
        ucrNudMaxSum.SetMinMax(iMaxSum, Integer.MaxValue)
        ucrNudMaxSum.SetLinkedDisplayControl(lblMaxSum)

        ucrPnlSummaries.AddRadioButton(rdoDefault)
        ucrPnlSummaries.AddRadioButton(rdoCustomised)
        ucrPnlSummaries.AddRadioButton(rdoSkim)
        ucrPnlSummaries.AddParameterValuesCondition(rdoCustomised, "checked_radio", "customised")
        ucrPnlSummaries.AddParameterValuesCondition(rdoDefault, "checked_radio", "defaults")
        ucrPnlSummaries.AddParameterValuesCondition(rdoSkim, "checked_radio", "skim")
        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True,
                                            bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=iMaxSum)
        ucrPnlSummaries.AddToLinkedControls({ucrChkOmitMissing, ucrPnlColumnFactor, ucrChkDisplayMargins, ucrChkDisplayMissing},
                                            {rdoCustomised}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True
        ucrChkOmitMissing.SetLinkedDisplayControl(cmdMissingOptions)

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 3))
        ucrChkDisplayMargins.SetText("Display Outer Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")
        ucrChkDisplayMargins.AddToLinkedControls({ucrInputMarginName}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                 bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All")

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=4))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrPnlColumnFactor.AddRadioButton(rdoSummary)
        ucrPnlColumnFactor.AddRadioButton(rdoVariable)
        ucrPnlColumnFactor.AddRadioButton(rdoNoColumnFactor)
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoNoColumnFactor, "factor_cols", "NoColFactor")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoSummary, "factor_cols", "Sum")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoVariable, "factor_cols", "Var")
        ucrPnlColumnFactor.SetLinkedDisplayControl(grpColumns)

        ucrChkDisplayMissing.SetText("Display Missing As")
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

        ucrSelectorOneVarSummarise.Reset()

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

        clsConcFunction.SetRCommand("c")

        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=1)

        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=0)
        clsSummaryOperator.AddParameter("gttbl", clsRFunctionParameter:=clsGtFunction, iPosition:=2)
        clsSummaryOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                               strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                               strRDataFrameNameToAddObjectTo:=ucrSelectorOneVarSummarise.strCurrentDataFrame,
                                               strObjectName:="last_table")

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", iMaxSum)
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
        ucrSaveSummary.AddAdditionalRCode(clsSummaryOperator, iAdditionalPairNo:=2)
        ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
        ucrReceiverOneVarSummarise.SetRCode(clsSummaryFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)

        ucrChkDisplayMargins.SetRCode(clsSummaryTableFunction, bReset)
        ucrPnlSummaries.SetRCode(clsDummyFunction, bReset)
        ucrPnlColumnFactor.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsSummaryTableFunction, bReset)
        ucrInputDisplayMissing.SetRCode(clsSummaryTableFunction, bReset)
        ucrSaveSummary.SetRCode(clsSkimrFunction, bReset)

        If bReset Then
            ucrChkDisplayMissing.SetRCode(clsDummyFunction, bReset)
        End If

        bRCodeSet = True
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
        clsSummaryOperator._strDataFrameNameToAddAssignToObject = ucrSelectorOneVarSummarise.strCurrentDataFrame
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
            ucrBase.clsRsyntax.SetBaseROperator(clsSummaryOperator)
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
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnFactor.ControlValueChanged
        If rdoSummary.Checked Then
            clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
            clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            clsPivotWiderFunction.AddParameter("names_from", "summary", iPosition:=0)
        ElseIf rdoVariable.Checked Then
            clsDummyFunction.AddParameter("factor_cols", "Var", iPosition:=1)
            clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            clsPivotWiderFunction.AddParameter("names_from", "variable", iPosition:=0)
        Else
            clsSummaryOperator.RemoveParameterByName("col_factor")
            clsDummyFunction.AddParameter("factor_cols", "NoColFactor", iPosition:=1)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlContentsChanged, ucrNudMaxSum.ControlContentsChanged, ucrSaveSummary.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class