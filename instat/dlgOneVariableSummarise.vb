﻿' R- Instat
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
    Private clsSummaryFunction, clsSummariesList, clsDataFrameFunction, clsAsVectorFunction,
        clsColNamesFunction, clsConcFunction, clsCalculateSummaryFunction, clsRowNamesFunction,
        clsPivotLongerStackFunction, clsMmtableFunction, clsHeaderLeftTopVariableFunction,
        clsHeaderLeftTopSummaryFunction, clsHeaderTopLeftVariableFunction,
        clsHeaderTopLeftSummaryFunction, clsDummyFunction As New RFunction
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
        ucrPnlSummaries.AddRSyntaxContainsFunctionNamesCondition(rdoCustomised, {"pivot_longer"})
        ucrPnlSummaries.AddRSyntaxContainsFunctionNamesCondition(rdoDefault, {"pivot_longer"}, False)
        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls({ucrChkOmitMissing, ucrChkDisplaySummariesAsRows, ucrChkDisplayVariablesAsRows}, {rdoCustomised}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        ucrChkDisplaySummariesAsRows.SetText("Display Summaries As Rows")
        ucrChkDisplaySummariesAsRows.AddParameterValuesCondition(True, "summary_by_row", "TRUE")
        ucrChkDisplaySummariesAsRows.AddParameterValuesCondition(False, "summary_by_row", "FALSE")

        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
        ucrChkDisplayVariablesAsRows.AddParameterValuesCondition(True, "variable_by_row", "TRUE")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(False, "variable_by_row", "FALSE")
    End Sub

    Private Sub SetDefaults()
        clsSummariesList = New RFunction
        clsSummaryFunction = New RFunction
        clsConcFunction = New RFunction
        clsCalculateSummaryFunction = New RFunction
        clsDataFrameFunction = New RFunction
        clsPivotLongerStackFunction = New RFunction
        clsColNamesFunction = New RFunction
        clsMmtableOperator = New ROperator
        clsMmtableFunction = New RFunction
        clsAsVectorFunction = New RFunction
        clsRowNamesFunction = New RFunction
        clsHeaderLeftTopVariableFunction = New RFunction
        clsHeaderLeftTopSummaryFunction = New RFunction
        clsHeaderTopLeftVariableFunction = New RFunction
        clsHeaderTopLeftSummaryFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorOneVarSummarise.Reset()
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        'Dummy function used t set conditions for the summary and variable checkbox
        clsDummyFunction.AddParameter("variable_by_row", "TRUE", iPosition:=0)
        clsDummyFunction.AddParameter("summary_by_row", "FALSE", iPosition:=1)

        clsConcFunction.SetRCommand("c")

        clsMmtableOperator.SetOperation("+")
        clsMmtableOperator.AddParameter("mmtable_function", clsRFunctionParameter:=clsMmtableFunction, iPosition:=0)
        clsMmtableOperator.AddParameter("header_left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=3)
        clsMmtableOperator.AddParameter("header_top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=4)

        clsHeaderLeftTopVariableFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopVariableFunction.SetRCommand("header_left_top")
        clsHeaderLeftTopVariableFunction.AddParameter("variable", "variable", iPosition:=0)

        clsHeaderLeftTopSummaryFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopSummaryFunction.SetRCommand("header_left_top")
        clsHeaderLeftTopSummaryFunction.AddParameter("variable", "summary", iPosition:=0)

        clsHeaderTopLeftVariableFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftVariableFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftVariableFunction.AddParameter("variable", "variable", iPosition:=0)

        clsHeaderTopLeftSummaryFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftSummaryFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftSummaryFunction.AddParameter("variable", "summary", iPosition:=0)

        clsAsVectorFunction.SetRCommand("as.vector")
        clsAsVectorFunction.AddParameter("x", clsRFunctionParameter:=clsRowNamesFunction, iPosition:=0)

        clsRowNamesFunction.SetRCommand("rownames")
        clsRowNamesFunction.AddParameter("x", "summary_result", iPosition:=0)

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", "stacked_data", iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("x", "summary_result", iPosition:=0, bIncludeArgumentName:=False)
        clsDataFrameFunction.AddParameter("summary", clsRFunctionParameter:=clsAsVectorFunction, iPosition:=1)

        clsColNamesFunction.SetRCommand("colnames")
        clsColNamesFunction.AddParameter("x", "summary_result", iPosition:=0)

        clsPivotLongerStackFunction.SetPackageName("tidyr")
        clsPivotLongerStackFunction.SetRCommand("pivot_longer")
        clsPivotLongerStackFunction.AddParameter("data", clsRFunctionParameter:=clsDataFrameFunction, iPosition:=0)
        clsPivotLongerStackFunction.AddParameter("col", clsRFunctionParameter:=clsColNamesFunction, iPosition:=1)
        clsPivotLongerStackFunction.AddParameter("names_to", Chr(34) & "variable" & Chr(34), iPosition:=2)
        clsPivotLongerStackFunction.SetAssignTo("stacked_data")

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", 7)
        clsSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=3)

        clsCalculateSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        clsCalculateSummaryFunction.AddParameter("return_output", "TRUE", iPosition:=0)
        clsCalculateSummaryFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=1)
        clsCalculateSummaryFunction.SetAssignTo("summary_result")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
        ucrReceiverOneVarSummarise.SetRCode(clsSummaryFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)
        ucrPnlSummaries.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsCalculateSummaryFunction, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsDummyFunction, bReset)
        ucrChkDisplaySummariesAsRows.SetRCode(clsDummyFunction, bReset)
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
        sdgSummaries.SetRFunction(clsSummariesList, clsCalculateSummaryFunction, clsConcFunction, ucrSelectorOneVarSummarise, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.bEnable2VariableTab = False
        sdgSummaries.ShowDialog()
        sdgSummaries.bEnable2VariableTab = True
        TestOKEnabled()
    End Sub

    Private Sub ChangeBaseFunction()
        If rdoCustomised.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsMmtableOperator)
            cmdSummaries.Visible = True
        ElseIf rdoDefault.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
            cmdSummaries.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverDescribeOneVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlValueChanged
        If Not ucrReceiverOneVarSummarise.IsEmpty Then
            clsCalculateSummaryFunction.AddParameter("columns_to_summarise", ucrReceiverOneVarSummarise.GetVariableNames(), iPosition:=4)
        Else
            clsCalculateSummaryFunction.RemoveParameterByName("columns_to_summarise")
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlContentsChanged, ucrNudMaxSum.ControlContentsChanged, ucrPnlSummaries.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlSummaries_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSummaries.ControlValueChanged
        If rdoCustomised.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCalculateSummaryFunction, iPosition:=0)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPivotLongerStackFunction, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsCalculateSummaryFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPivotLongerStackFunction)
        End If
        ChangeBaseFunction()
    End Sub

    Private Sub ucrChkDisplayVariablesAsRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayVariablesAsRows.ControlValueChanged, ucrChkDisplaySummariesAsRows.ControlValueChanged
        clsMmtableOperator.RemoveParameterByName("header_left_top_variable")
        clsMmtableOperator.RemoveParameterByName("header_top_left_summary")
        clsMmtableOperator.RemoveParameterByName("header_left_top_summaries")
        clsMmtableOperator.RemoveParameterByName("header_top_left_variable")
        If ucrChkDisplaySummariesAsRows.Checked AndAlso ucrChkDisplayVariablesAsRows.Checked Then
            clsMmtableOperator.AddParameter("header_top_left_variable", clsRFunctionParameter:=clsHeaderTopLeftVariableFunction, iPosition:=5)
            clsMmtableOperator.AddParameter("header_top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=6)
        ElseIf ucrChkDisplayVariablesAsRows.Checked Then
            clsMmtableOperator.AddParameter("header_left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=3)
            clsMmtableOperator.AddParameter("header_top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=4)
        ElseIf ucrChkDisplaySummariesAsRows.Checked Then
            clsMmtableOperator.AddParameter("header_left_top_summaries", clsRFunctionParameter:=clsHeaderLeftTopSummaryFunction, iPosition:=1)
            clsMmtableOperator.AddParameter("header_top_left_variable", clsRFunctionParameter:=clsHeaderTopLeftVariableFunction, iPosition:=2)
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
    End Sub
End Class
