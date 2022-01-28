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
    Private clsSummaryFunction, clsSummariesList, clsDataFrameFunction,
        clsColNamesFunction, clsConcFunction, clsCalculateSummaryFunction,
        clsPivotLongerStackFunction, clsMmtableFunction As New RFunction
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
        ucrPnlSummaries.AddFunctionNamesCondition(rdoCustomised, frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        ucrPnlSummaries.AddFunctionNamesCondition(rdoDefault, "summary")
        ucrPnlSummaries.AddToLinkedControls(ucrNudMaxSum, {rdoDefault}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaries.AddToLinkedControls(ucrChkOmitMissing, {rdoCustomised}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        ucrChkDisplaySummariesAsRows.SetText("Display Summaries As Rows")
        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
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

        ucrSelectorOneVarSummarise.Reset()

        clsConcFunction.SetRCommand("c")

        clsMmtableOperator.SetOperation("+")

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("x", "summary", iPosition:=0, bIncludeArgumentName:=False)

        clsColNamesFunction.SetRCommand("colnames")
        clsColNamesFunction.AddParameter("columns", clsRFunctionParameter:=clsDataFrameFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsPivotLongerStackFunction.SetPackageName("tidyr")
        clsPivotLongerStackFunction.SetRCommand("pivot_longer")
        clsPivotLongerStackFunction.AddParameter("data", clsRFunctionParameter:=clsDataFrameFunction, iPosition:=0)
        clsPivotLongerStackFunction.AddParameter("col", clsRFunctionParameter:=clsColNamesFunction, iPosition:=1)
        clsPivotLongerStackFunction.SetAssignTo("stacked_cols")

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("maxsum", 7)
        clsSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=3)

        clsCalculateSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsCalculateSummaryFunction.AddParameter("silent", "TRUE", iPosition:=0)
        clsCalculateSummaryFunction.AddParameter("store_result", "FALSE", iPosition:=1)
        clsCalculateSummaryFunction.AddParameter("return_output", "TRUE", iPosition:=2)
        clsCalculateSummaryFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=3)
        clsCalculateSummaryFunction.SetAssignTo("summary")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudMaxSum.SetRCode(clsSummaryFunction, bReset)
        ucrReceiverOneVarSummarise.SetRCode(clsSummaryFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryFunction, bReset)
        ucrPnlSummaries.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSelectorOneVarSummarise.SetRCode(clsCalculateSummaryFunction, bReset)
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
            ucrBase.clsRsyntax.SetBaseRFunction(clsCalculateSummaryFunction)
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
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPivotLongerStackFunction)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPivotLongerStackFunction)
        End If
        ChangeBaseFunction()
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If clsSummariesList.ContainsParameter("summary_cor") OrElse clsSummariesList.ContainsParameter("summary_cov") Then
            clsCalculateSummaryFunction.AddParameter("use", Chr(34) & "'na.or.complete'" & Chr(34))
        Else
            clsCalculateSummaryFunction.RemoveParameterByName("use")
        End If
        If Not ucrChkOmitMissing.Checked Then
            clsCalculateSummaryFunction.RemoveParameterByName("na_type")
        Else
            clsCalculateSummaryFunction.AddParameter("na_type", clsRFunctionParameter:=clsConcFunction, iPosition:=9)
        End If
    End Sub
End Class
