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
    Private clsSummaryFunction, clsSummariesList, clsMmtableFunction,
        clsConcFunction, clsSummaryTableFunction, clsHeaderLeftTopVariableFunction,
                clsHeaderLeftTopSummaryFunction, clsHeaderTopLeftVariableFunction,
                clsHeaderTopLeftSummaryFunction, clsDummyFunction,
                clsSkimrFunction As New RFunction
    Private clsMmtableOperator As ROperator
    Private bResetSubdialog As Boolean = False
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

        'The selector is only used for one of the functions. Therefore it's parameter name is always the same. So this can be done in Initialise.
        ucrSelectorOneVarSummarise.SetParameter(New RParameter("data_name", 0))
        ucrSelectorOneVarSummarise.SetParameterIsString()

        ucrReceiverOneVarSummarise.SetParameter(New RParameter("object", 0))
        ucrReceiverOneVarSummarise.SetParameterIsRFunction()
        ucrReceiverOneVarSummarise.Selector = ucrSelectorOneVarSummarise
        ucrReceiverOneVarSummarise.SetMeAsReceiver()

        ucrNudMaxSum.SetParameter(New RParameter("maxsum", 2))
        ucrNudMaxSum.SetRDefault("7")
        ucrNudMaxSum.SetLinkedDisplayControl(lblMaxSum)

        ucrPnlSummaries.AddRadioButton(rdoDefault)
        ucrPnlSummaries.AddRadioButton(rdoCustomised)
        ucrPnlSummaries.AddRadioButton(rdoSkim)
        ucrPnlSummaries.AddParameterValuesCondition(rdoCustomised, "checked_radio", "customised")
        ucrPnlSummaries.AddParameterValuesCondition(rdoDefault, "checked_radio", "defaults")
        ucrPnlSummaries.AddParameterValuesCondition(rdoSkim, "checked_radio", "skim")
        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls({ucrChkOmitMissing, ucrChkDisplaySummariesAsRows, ucrChkDisplayVariablesAsRows, ucrChkDisplayMargins},
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

        ucrChkDisplaySummariesAsRows.SetText("Display Summaries As Rows")
        ucrChkDisplaySummariesAsRows.AddParameterValuesCondition(True, "summary_by_row", "TRUE")
        ucrChkDisplaySummariesAsRows.AddParameterValuesCondition(False, "summary_by_row", "FALSE")
        ucrChkDisplaySummariesAsRows.SetLinkedDisplayControl(cmdSummaries)

        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
        ucrChkDisplayVariablesAsRows.AddParameterValuesCondition(True, "variable_by_row", "TRUE")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(False, "variable_by_row", "FALSE")
    End Sub

    Private Sub SetDefaults()
        clsSummariesList = New RFunction
        clsSummaryFunction = New RFunction
        clsConcFunction = New RFunction
        clsSummaryTableFunction = New RFunction
        clsMmtableOperator = New ROperator
        clsMmtableFunction = New RFunction
        clsHeaderLeftTopVariableFunction = New RFunction
        clsHeaderLeftTopSummaryFunction = New RFunction
        clsHeaderTopLeftVariableFunction = New RFunction
        clsHeaderTopLeftSummaryFunction = New RFunction
        clsDummyFunction = New RFunction
        clsSkimrFunction = New RFunction

        ucrSelectorOneVarSummarise.Reset()

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")
        clsSkimrFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorOneVarSummarise.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        'Dummy function used to set conditions for the summary and variable checkbox
        clsDummyFunction.AddParameter("variable_by_row", "TRUE", iPosition:=0)
        clsDummyFunction.AddParameter("summary_by_row", "FALSE", iPosition:=1)
        clsDummyFunction.AddParameter("checked_radio", "defaults", iPosition:=2)

        clsConcFunction.SetRCommand("c")

        clsMmtableOperator.SetOperation("+")
        clsMmtableOperator.AddParameter("mmtable_function", clsRFunctionParameter:=clsMmtableFunction, iPosition:=0)
        clsMmtableOperator.AddParameter("header_left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=1)
        clsMmtableOperator.AddParameter("header_top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=2)

        clsHeaderLeftTopVariableFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopVariableFunction.SetRCommand("header_left_top")
        clsHeaderLeftTopVariableFunction.AddParameter("variable", Chr(39) & "variable" & Chr(39), iPosition:=0)

        clsHeaderLeftTopSummaryFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopSummaryFunction.SetRCommand("header_left_top")
        clsHeaderLeftTopSummaryFunction.AddParameter("variable", Chr(39) & "summary" & Chr(39), iPosition:=0)

        clsHeaderTopLeftVariableFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftVariableFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftVariableFunction.AddParameter("variable", Chr(39) & "variable" & Chr(39), iPosition:=0)

        clsHeaderTopLeftSummaryFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftSummaryFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftSummaryFunction.AddParameter("variable", Chr(39) & "summary" & Chr(39), iPosition:=0)

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", 7)
        clsSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=3)

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryTableFunction.AddParameter("treat_columns_as_factor", "TRUE", iPosition:=0)
        clsSummaryTableFunction.AddParameter("margins", Chr(34) & "summary" & Chr(34), iPosition:=1)
        clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=2)
        clsSummaryTableFunction.SetAssignTo("summary_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsSummaryTableFunction, New RParameter("na.rm", iNewPosition:=2), iAdditionalPairNo:=1)

        ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
        ucrReceiverOneVarSummarise.SetRCode(clsSummaryFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsSummaryTableFunction, bReset)
        ucrPnlSummaries.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsSummaryTableFunction, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsDummyFunction, bReset)
        ucrChkDisplaySummariesAsRows.SetRCode(clsDummyFunction, bReset)
        bRCodeSet = True
    End Sub

    Public Sub TestOKEnabled()
        'We cannot test the values on the sub dialog because the sub dialog may not be in sync with the main dialog code. This only happens once the sub dialog has been opened.
        If ucrReceiverOneVarSummarise.IsEmpty() OrElse (rdoCustomised.Checked AndAlso clsSummariesList.clsParameters.Count = 0) OrElse ucrNudMaxSum.GetText = "" Then
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
            clsDummyFunction.AddParameter("checked_radio", "customised", iPosition:=2)
            ucrBase.clsRsyntax.SetBaseROperator(clsMmtableOperator)
        ElseIf rdoDefault.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "defaults", iPosition:=2)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        ElseIf rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked_radio", "skim", iPosition:=2)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSkimrFunction)
        End If
    End Sub

    Private Sub ucrChkDisplayVariablesAsRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayVariablesAsRows.ControlValueChanged, ucrChkDisplaySummariesAsRows.ControlValueChanged
        If bRCodeSet Then
            clsMmtableOperator.RemoveParameterByName("header_left_top_variable")
            clsMmtableOperator.RemoveParameterByName("header_top_left_summary")
            clsMmtableOperator.RemoveParameterByName("header_left_top_summaries")
            clsMmtableOperator.RemoveParameterByName("header_top_left_variable")
            clsMmtableOperator.RemoveParameterByName("header_left_top_summary")
            clsMmtableOperator.RemoveParameterByName("header_top__left_summary")
            If ucrChkDisplaySummariesAsRows.Checked AndAlso ucrChkDisplayVariablesAsRows.Checked Then
                clsMmtableOperator.AddParameter("header_left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=1)
                clsMmtableOperator.AddParameter("header_left_top_summary", clsRFunctionParameter:=clsHeaderLeftTopSummaryFunction, iPosition:=2)
            ElseIf ucrChkDisplayVariablesAsRows.Checked Then
                clsMmtableOperator.AddParameter("header_left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=1)
                clsMmtableOperator.AddParameter("header_top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=2)
            ElseIf ucrChkDisplaySummariesAsRows.Checked Then
                clsMmtableOperator.AddParameter("header_left_top_summaries", clsRFunctionParameter:=clsHeaderLeftTopSummaryFunction, iPosition:=1)
                clsMmtableOperator.AddParameter("header_top_left_variable", clsRFunctionParameter:=clsHeaderTopLeftVariableFunction, iPosition:=2)
            Else
                clsMmtableOperator.AddParameter("header_top_left_variable", clsRFunctionParameter:=clsHeaderTopLeftVariableFunction, iPosition:=1)
                clsMmtableOperator.AddParameter("header_top__left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=2)
            End If

            If ucrChkDisplayVariablesAsRows.Checked Then
                clsDummyFunction.AddParameter("variable_by_row", "TRUE", iPosition:=0)
            Else
                clsDummyFunction.AddParameter("variable_by_row", "FALSE", iPosition:=0)
            End If

            If ucrChkDisplaySummariesAsRows.Checked Then
                clsDummyFunction.AddParameter("summary_by_row", "TRUE", iPosition:=1)
            Else
                clsDummyFunction.AddParameter("summary_by_row", "FALSE", iPosition:=1)
            End If
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlContentsChanged, ucrNudMaxSum.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class