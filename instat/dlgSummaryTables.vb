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
Public Class dlgSummaryTables
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction, clsConcFunction, clsMutableFunction As New RFunction
    Private clsSummariesHeaderLeftTopFunction, clsSummariesHeaderTopLeftFunction,
            clsVariableHeaderLeftTopFunction, clsVariableHeaderTopLeftFunction,
            clsummaryVariableHeaderLeftTopFunction, clsSummaryVariableHeaderTopLeftFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsMutableOperator, clsColumnOperator As New ROperator
    Private Sub dlgNewSummaryTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrInputNA.Enabled = False
        lblDisplayNA.Enabled = False
        ucrChkStoreResults.Enabled = False

        ucrBase.clsRsyntax.iCallType = 4
        ucrBase.iHelpTopicID = 426
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        'summary_name = NA - 8
        ucrSelectorSummaryTables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSummaryTables.SetParameterIsString()

        ucrReceiverSummaryCols.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSummaryCols.Selector = ucrSelectorSummaryTables
        ucrReceiverSummaryCols.SetDataType("numeric")
        ucrReceiverSummaryCols.SetParameterIsString()

        ucrReceiverFactors.SetParameter(New RParameter("factors", 3))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorSummaryTables
        ucrReceiverFactors.SetDataType("factor")

        'ucrChkStoreResults.SetParameter(New RParameter("store_results", 5))
        'ucrChkStoreResults.SetText("Store Results in Data Frame")
        'ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        'ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 7))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 9))
        ucrChkDisplayMargins.SetText("Display Outer Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrChkDisplaySummariesAsRow.SetText("Display Summaries As Rows")
        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
        ucrChkDisplaySummaryVariablesAsRow.SetText("Display Summary_Variables As Rows")

        ucrChkDisplaySummariesAsRow.AddParameterPresentCondition(True, "summaries")
        ucrChkDisplaySummariesAsRow.AddParameterPresentCondition(False, "summaries", False)

        ucrChkDisplaySummaryVariablesAsRow.AddParameterPresentCondition(True, "summ_variables")
        ucrChkDisplaySummaryVariablesAsRow.AddParameterPresentCondition(False, "summ_variables", False)

        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(True, "variables")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(False, "variables", False)

        ucrNudColumnFactors.SetLinkedDisplayControl(lblColumnFactors)
        ucrNudColumnFactors.SetMinMax(iNewMin:=0)
        ucrNudColumnFactors.Increment = 1

        ucrPnlMargin.AddRadioButton(rdoOuter)
        ucrPnlMargin.AddRadioButton(rdoSummary)
        ucrPnlMargin.AddRadioButton(rdoBoth)
        ucrPnlMargin.SetLinkedDisplayControl(grpMargin)

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=10))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrChkSummaries.SetText("Treat Summary Columns as a Further Factor")

        ucrChkSummaries.AddParameterPresentCondition(True, "singleDisplay")
        ucrChkSummaries.AddParameterPresentCondition(False, "singleDisplay", False)

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 14))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrReceiverWeights.SetParameter(New RParameter("weights", 17))
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.Selector = ucrSelectorSummaryTables
        ucrReceiverWeights.SetDataType("numeric")

        ucrChkWeight.SetText("Weights")
        ucrChkWeight.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeight.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'Not yet implemented
        ucrChkWeight.Enabled = False

        ucrInputNA.SetParameter(New RParameter("na_display", 15))
        ucrInputNA.SetRDefault(Chr(34) & Chr(34))

        ucrSaveTable.SetPrefix("summ_table")
        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrSelectorSummaryTables.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")


        ucrChkSummaries.AddToLinkedControls({ucrChkDisplaySummariesAsRow, ucrChkDisplayVariablesAsRows}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSummaries.AddToLinkedControls(ucrChkDisplaySummaryVariablesAsRow, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDisplayMargins.AddToLinkedControls({ucrInputMarginName}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All")
        ucrChkDisplayMargins.AddToLinkedControls({ucrPnlMargin}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoOuter)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsConcFunction = New RFunction
        clsMutableFunction = New RFunction
        clsSummariesHeaderLeftTopFunction = New RFunction
        clsSummariesHeaderTopLeftFunction = New RFunction
        clsVariableHeaderLeftTopFunction = New RFunction
        clsVariableHeaderTopLeftFunction = New RFunction
        clsummaryVariableHeaderLeftTopFunction = New RFunction
        clsSummaryVariableHeaderTopLeftFunction = New RFunction
        clsDummyFunction = New RFunction
        clsMutableOperator = New ROperator
        clsColumnOperator = New ROperator

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()
        ucrSaveTable.Reset()
        ucrNudColumnFactors.SetText(2)

        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        clsMutableOperator.SetOperation("+")

        clsColumnOperator.SetOperation("+")

        clsConcFunction.SetRCommand("c")

        clsSummariesHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsSummariesHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsSummariesHeaderLeftTopFunction.AddParameter("summary", "Summary", iPosition:=0, bIncludeArgumentName:=False)

        clsSummariesHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummariesHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummariesHeaderTopLeftFunction.AddParameter("summary", "Summary", iPosition:=0, bIncludeArgumentName:=False)

        clsVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsVariableHeaderLeftTopFunction.AddParameter("variable", "Variable", iPosition:=0, bIncludeArgumentName:=False)

        clsVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsVariableHeaderTopLeftFunction.AddParameter("variable", "Variable", iPosition:=0, bIncludeArgumentName:=False)

        clsummaryVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsummaryVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsummaryVariableHeaderLeftTopFunction.AddParameter("summary_variable", Chr(34) & "Summary_Variable" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)

        clsSummaryVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummaryVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummaryVariableHeaderTopLeftFunction.AddParameter("summary_variable", Chr(34) & "Summary_Variable" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)

        clsMutableOperator.RemoveParameterByName("summariesVariableLeftTop")
        clsMutableOperator.AddParameter("summariesVariableTopLeft", clsRFunctionParameter:=clsSummaryVariableHeaderTopLeftFunction, iPosition:=1)

        clsMutableFunction.SetPackageName("mmtable2")
        clsMutableFunction.SetRCommand("mmtable")
        clsMutableFunction.AddParameter("data", "summary_table", iPosition:=0)
        clsMutableFunction.AddParameter("table_data", "Value", iPosition:=1)

        clsMutableOperator.AddParameter("mutableFunc", clsRFunctionParameter:=clsMutableFunction, iPosition:=0)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=2)
        clsDefaultFunction.SetAssignTo("summary_table")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseROperator(clsMutableOperator)
        clsMutableOperator.SetAssignTo("last_table", strTempDataframe:=ucrSelectorSummaryTables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_table")
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorSummaryTables.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverSummaryCols.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverFactors.SetRCode(clsDefaultFunction, bReset)
        'ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsDefaultFunction, bReset)
        ucrPnlMargin.SetRCode(clsDefaultFunction, bReset)
        ucrInputMarginName.SetRCode(clsDefaultFunction, bReset)
        ucrChkSummaries.SetRCode(clsDummyFunction, bReset)
        ucrNudSigFigs.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverWeights.SetRCode(clsDefaultFunction, bReset)
        ucrChkWeight.SetRCode(clsDefaultFunction, bReset)
        ucrInputNA.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplaySummariesAsRow.SetRCode(clsDummyFunction, bReset)
        ucrChkDisplaySummaryVariablesAsRow.SetRCode(clsDummyFunction, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsDummyFunction, bReset)
        ucrSaveTable.SetRCode(clsMutableOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactors.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse (ucrChkWeight.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso Not ucrReceiverSummaryCols.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, clsDefaultFunction, clsConcFunction, ucrSelectorSummaryTables, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.bEnable2VariableTab = False
        sdgSummaries.ShowDialog()
        sdgSummaries.bEnable2VariableTab = True
        TestOKEnabled()
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeight.ControlValueChanged
        If ucrChkWeight.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            If ucrReceiverFactors.IsEmpty Then
                ucrReceiverFactors.SetMeAsReceiver()
            ElseIf ucrReceiverSummaryCols.IsEmpty Then
                ucrReceiverSummaryCols.SetMeAsReceiver()
            Else
                ucrReceiverFactors.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged, ucrChkWeight.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrNudSigFigs.ControlContentsChanged, ucrReceiverSummaryCols.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub Margin_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMargin.ControlValueChanged, ucrChkDisplayMargins.ControlValueChanged
        If ucrChkDisplayMargins.Checked Then
            If rdoOuter.Checked Then
                clsDefaultFunction.AddParameter("margins", Chr(34) & "outer" & Chr(34), iPosition:=8)
            ElseIf rdoBoth.Checked Then
                clsDefaultFunction.AddParameter("margins", "c(""outer"",""sumary"")", iPosition:=8)
            ElseIf rdoSummary.Checked Then
                clsDefaultFunction.AddParameter("margins", Chr(34) & "summary" & Chr(34), iPosition:=8)
            End If
        Else
            clsDefaultFunction.RemoveParameterByName("margins")
        End If
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplaySummariesAsRow.ControlValueChanged, ucrChkDisplayVariablesAsRows.ControlValueChanged, ucrChkDisplaySummaryVariablesAsRow.ControlValueChanged, ucrChkSummaries.ControlValueChanged
        If ucrChkSummaries.Checked Then
            clsMutableOperator.RemoveParameterByName("summariesVariableTopLeft")
            clsMutableOperator.RemoveParameterByName("summariesVariableLeftTop")
            If ucrChkDisplaySummariesAsRow.Checked Then
                clsMutableOperator.RemoveParameterByName("summariesTopLeft")
                clsMutableOperator.AddParameter("summariesLeftTop", clsRFunctionParameter:=clsSummariesHeaderLeftTopFunction, iPosition:=1)
                clsDummyFunction.AddParameter("summaries", "summaries", iPosition:=0)
            Else
                clsMutableOperator.RemoveParameterByName("summariesLeftTop")
                clsMutableOperator.AddParameter("summariesTopLeft", clsRFunctionParameter:=clsSummariesHeaderTopLeftFunction, iPosition:=1)
                clsDummyFunction.RemoveParameterByName("summaries")
            End If

            If ucrChkDisplayVariablesAsRows.Checked Then
                clsMutableOperator.RemoveParameterByName("variablesTopLeft")
                clsMutableOperator.AddParameter("variablesLeftTop", clsRFunctionParameter:=clsVariableHeaderLeftTopFunction, iPosition:=1)
                clsDummyFunction.AddParameter("variables", "variables", iPosition:=1)
            Else
                clsMutableOperator.RemoveParameterByName("variablesLeftTop")
                clsMutableOperator.AddParameter("variablesTopLeft", clsRFunctionParameter:=clsVariableHeaderTopLeftFunction, iPosition:=1)
                clsDummyFunction.RemoveParameterByName("variables")
            End If
            clsDummyFunction.AddParameter("singleDisplay", "singleDisplay", iPosition:=1)
        Else
            clsMutableOperator.RemoveParameterByName("summariesTopLeft")
            clsMutableOperator.RemoveParameterByName("summariesLeftTop")
            clsMutableOperator.RemoveParameterByName("variablesTopLeft")
            clsMutableOperator.RemoveParameterByName("variablesLeftTop")
            If ucrChkDisplaySummaryVariablesAsRow.Checked Then
                clsMutableOperator.RemoveParameterByName("summariesVariableTopLeft")
                clsMutableOperator.AddParameter("summariesVariableLeftTop", clsRFunctionParameter:=clsummaryVariableHeaderLeftTopFunction, iPosition:=1)
                clsDummyFunction.AddParameter("summ_variables", "summ_variables", iPosition:=2)
            Else
                clsMutableOperator.RemoveParameterByName("summariesVariableLeftTop")
                clsMutableOperator.AddParameter("summariesVariableTopLeft", clsRFunctionParameter:=clsSummaryVariableHeaderTopLeftFunction, iPosition:=1)
                clsDummyFunction.RemoveParameterByName("summ_variables")
            End If
            clsDummyFunction.RemoveParameterByName("singleDisplay")
        End If
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged, ucrNudColumnFactors.ControlValueChanged
        Dim iColumn As Integer = 0
        Dim iNumberOfColumns As Integer = ucrNudColumnFactors.GetText()
        clsColumnOperator.ClearParameters()
        If Not ucrReceiverFactors.IsEmpty Then
            For Each strcolumn As String In ucrReceiverFactors.GetVariableNamesAsList
                If (iColumn + 1) <= iNumberOfColumns Then
                    Dim clsHeaderLeftFunction As New RFunction
                    clsHeaderLeftFunction.SetPackageName("mmtable2")
                    clsHeaderLeftFunction.SetRCommand("header_top_left")
                    clsHeaderLeftFunction.AddParameter("column", strcolumn, iPosition:=0, bIncludeArgumentName:=False)
                    clsColumnOperator.AddParameter(strcolumn, clsRFunctionParameter:=clsHeaderLeftFunction, iPosition:=iColumn)
                Else
                    Dim clsHeaderTopFunction As New RFunction
                    clsHeaderTopFunction.SetPackageName("mmtable2")
                    clsHeaderTopFunction.SetRCommand("header_left_top")
                    clsHeaderTopFunction.AddParameter("column", strcolumn, iPosition:=0, bIncludeArgumentName:=False)
                    clsColumnOperator.AddParameter(strcolumn, clsRFunctionParameter:=clsHeaderTopFunction, iPosition:=iColumn)
                End If
                iColumn = iColumn + 1
            Next
            clsMutableOperator.AddParameter("columnOp", clsROperatorParameter:=clsColumnOperator)
        End If
    End Sub
End Class