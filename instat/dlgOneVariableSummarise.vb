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
    Private bResetSubdialog As Boolean = False
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing
    Private clsSummaryFunction, clsSummariesList, clsSummaryTableFunction, clsConcFunction,
            clsMmtable2Function, clsHeaderTopLeftSummaryVariableFunction, clsHeaderTopLeftVariableFunction,
            clsHeaderTopLeftSummaryFunction, clsHeaderLeftTopSummaryFunction, clsHeaderLeftTopVariableFunction,
            clsDummyFunction As New RFunction
    Private clsMmtableOperator As New ROperator
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

        cmdSummaries.Visible = False

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

        ucrPnlSummaries.AddParameterValuesCondition(rdoCustomised, "isROperator", "TRUE")
        ucrPnlSummaries.AddParameterValuesCondition(rdoDefault, "isROperator", "FALSE")

        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls(ucrChkOmitMissing, {rdoCustomised}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls(ucrChkTreatColumnsAsFactors, {rdoCustomised}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
        ucrChkDisplayVariablesAsRows.AddParameterValuesCondition(True, "variable", "TRUE")
        ucrChkDisplayVariablesAsRows.AddParameterValuesCondition(False, "variable", "FALSE")

        ucrChkDisplaySummaryAsRow.SetText("Display Summary As Rows")
        ucrChkDisplaySummaryAsRow.AddParameterValuesCondition(True, "summary", "TRUE")
        ucrChkDisplaySummaryAsRow.AddParameterValuesCondition(False, "summary", "FALSE")

        ucrChkTreatColumnsAsFactors.SetParameter(New RParameter("treat_columns_as_factor", iNewPosition:=3))
        ucrChkTreatColumnsAsFactors.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTreatColumnsAsFactors.SetText("Treat Columns As Factor")
        ucrChkTreatColumnsAsFactors.AddToLinkedControls({ucrChkDisplaySummaryAsRow, ucrChkDisplayVariablesAsRows}, {True}, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsSummariesList = New RFunction
        clsSummaryFunction = New RFunction
        clsSummaryTableFunction = New RFunction
        clsConcFunction = New RFunction
        clsMmtable2Function = New RFunction
        clsHeaderTopLeftSummaryVariableFunction = New RFunction
        clsHeaderTopLeftVariableFunction = New RFunction
        clsHeaderTopLeftSummaryVariableFunction = New RFunction
        clsHeaderLeftTopSummaryFunction = New RFunction
        clsHeaderLeftTopVariableFunction = New RFunction
        clsMmtableOperator = New ROperator
        clsDummyFunction = New RFunction

        ucrSelectorOneVarSummarise.Reset()

        clsDummyFunction.AddParameter("summary", "FALSE", iPosition:=0)
        clsDummyFunction.AddParameter("variable", "FALSE", iPosition:=1)
        clsDummyFunction.AddParameter("isROperator", "FALSE", iPosition:=2)

        clsConcFunction.SetRCommand("c")

        clsMmtableOperator.SetOperation("+")
        clsMmtableOperator.AddParameter("mmtable_function", clsRFunctionParameter:=clsMmtable2Function, iPosition:=0)

        clsMmtable2Function.SetPackageName("mmtable2")
        clsMmtable2Function.SetRCommand("mmtable")
        clsMmtable2Function.AddParameter("data", "summary_table", iPosition:=0)
        clsMmtable2Function.AddParameter("cells", "value", iPosition:=1)

        clsHeaderTopLeftVariableFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftVariableFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftVariableFunction.AddParameter("variable", "variable", iPosition:=0)

        clsHeaderTopLeftSummaryVariableFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftSummaryVariableFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftSummaryVariableFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

        clsHeaderTopLeftSummaryFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftSummaryFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftSummaryFunction.AddParameter("variable", "summary", iPosition:=0)

        clsHeaderLeftTopVariableFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopVariableFunction.SetRCommand("header_left_top")
        clsHeaderLeftTopVariableFunction.AddParameter("variable", "variable", iPosition:=0)

        clsHeaderLeftTopSummaryFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopSummaryFunction.SetRCommand("header_left_top")
        clsHeaderLeftTopSummaryFunction.AddParameter("variable", "summary", iPosition:=0)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", 7)
        clsSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=3)

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=1)
        clsSummaryTableFunction.AddParameter("j", "1", iPosition:=2)
        clsSummaryTableFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=3)
        clsSummaryTableFunction.SetAssignTo("summary_table")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsSummaryTableFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=1)
        ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
        ucrReceiverOneVarSummarise.SetRCode(clsSummaryFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)
        ucrPnlSummaries.SetRCode(clsDummyFunction, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsSummaryTableFunction, bReset)
        ucrChkTreatColumnsAsFactors.SetRCode(clsSummaryTableFunction, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsDummyFunction, bReset)
        ucrChkDisplaySummaryAsRow.SetRCode(clsDummyFunction, bReset)
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

    Private Sub ucrReceiverDescribeOneVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverOneVarSummarise.ControlValueChanged
        If Not ucrReceiverOneVarSummarise.IsEmpty Then
            clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverOneVarSummarise.GetVariableNames())
        Else
            clsSummaryTableFunction.RemoveParameterByName("columns_to_summarise")
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
            ucrBase.clsRsyntax.AddToBeforeCodes(clsSummaryTableFunction)
            ucrBase.clsRsyntax.SetBaseROperator(clsMmtableOperator)
            clsDummyFunction.AddParameter("isROperator", "TRUE", iPosition:=2)
            cmdSummaries.Visible = True
        ElseIf rdoDefault.Checked Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSummaryTableFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
            clsDummyFunction.AddParameter("isROperator", "FALSE", iPosition:=2)
            cmdSummaries.Visible = False
        End If
        AddRemoveHeaders()
    End Sub

    Private Sub TreatColumnsAsFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTreatColumnsAsFactors.ControlValueChanged
        AddRemoveHeaders()
    End Sub

    Private Sub AddRemoveHeaders()
        clsMmtableOperator.RemoveParameterByName("left_top_variable")
        clsMmtableOperator.RemoveParameterByName("left_top_summary")
        clsMmtableOperator.RemoveParameterByName("top_left_summary")
        clsMmtableOperator.RemoveParameterByName("top_left_variable")
        clsMmtableOperator.RemoveParameterByName("summary-variable")
        If rdoCustomised.Checked Then
            If ucrChkTreatColumnsAsFactors.Checked Then
                If ucrChkDisplayVariablesAsRows.Checked AndAlso ucrChkDisplaySummaryAsRow.Checked Then
                    clsMmtableOperator.AddParameter("left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=1)
                    clsMmtableOperator.AddParameter("left_top_summary", clsRFunctionParameter:=clsHeaderLeftTopSummaryFunction, iPosition:=2)
                ElseIf ucrChkDisplayVariablesAsRows.Checked Then
                    clsMmtableOperator.AddParameter("left_top_variable", clsRFunctionParameter:=clsHeaderLeftTopVariableFunction, iPosition:=1)
                    clsMmtableOperator.AddParameter("top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=2)
                ElseIf ucrChkDisplaySummaryAsRow.Checked Then
                    clsMmtableOperator.AddParameter("top_left_variable", clsRFunctionParameter:=clsHeaderTopLeftVariableFunction, iPosition:=1)
                    clsMmtableOperator.AddParameter("left_top_summary", clsRFunctionParameter:=clsHeaderLeftTopSummaryFunction, iPosition:=2)
                Else
                    clsMmtableOperator.AddParameter("top_left_summary", clsRFunctionParameter:=clsHeaderTopLeftSummaryFunction, iPosition:=1)
                    clsMmtableOperator.AddParameter("top_left_variable", clsRFunctionParameter:=clsHeaderTopLeftVariableFunction, iPosition:=2)
                End If
            Else
                clsMmtableOperator.AddParameter("summary-variable", clsRFunctionParameter:=clsHeaderTopLeftSummaryVariableFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrChkDisplaySummaryAsRow_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplaySummaryAsRow.ControlValueChanged
        If ucrChkDisplaySummaryAsRow.Checked Then
            clsDummyFunction.AddParameter("summary", "TRUE", iPosition:=0)
        Else
            clsDummyFunction.AddParameter("summary", "FALSE", iPosition:=0)
        End If
        AddRemoveHeaders()
    End Sub

    Private Sub ucrChkDisplayVariablesAsRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayVariablesAsRows.ControlValueChanged
        If ucrChkDisplayVariablesAsRows.Checked Then
            clsDummyFunction.AddParameter("variable", "TRUE", iPosition:=1)
        Else
            clsDummyFunction.AddParameter("variable", "FALSE", iPosition:=1)
        End If
        AddRemoveHeaders()
    End Sub
End Class
