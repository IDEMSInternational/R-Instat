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
    Private clsGetDataframe As New RFunction
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

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 426
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        'summary_name = NA - 8
        ucrSelectorSummaryTables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSummaryTables.SetParameterIsString()

        ucrReceiverSummaryCols.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSummaryCols.Selector = ucrSelectorSummaryTables
        ucrReceiverSummaryCols.SetDataType("numeric")
        ucrReceiverSummaryCols.SetParameterIsString()

        ucrChkStoreResults.SetText("Store Output")
        ucrChkStoreResults.SetParameter(New RParameter("store_table", 13))
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("False")

        ucrReceiverFactors.SetParameter(New RParameter("factors", 2))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorSummaryTables
        ucrReceiverFactors.SetDataType("factor")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 4))
        ucrChkDisplayMargins.SetText("Display Outer Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrChkDisplaySummariesAsRow.SetText("Display Summaries As Rows")
        ucrChkDisplaySummariesAsRow.AddParameterPresentCondition(True, "summariesLeftTop")
        ucrChkDisplaySummariesAsRow.AddParameterPresentCondition(False, "summariesLeftTop", False)

        ucrChkDisplaySummaryVariablesAsRow.SetText("Display Summary_Variables As Rows")
        ucrChkDisplaySummaryVariablesAsRow.AddParameterPresentCondition(True, "summariesVariableLeftTop")
        ucrChkDisplaySummaryVariablesAsRow.AddParameterPresentCondition(False, "summariesVariableLeftTop", False)

        ucrChkDisplayVariablesAsRows.SetText("Display Variables As Rows")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(True, "variablesLeftTop")
        ucrChkDisplayVariablesAsRows.AddParameterPresentCondition(False, "variablesLeftTop", False)

        ucrNudColumnFactors.SetLinkedDisplayControl(lblColumnFactors)
        ucrNudColumnFactors.SetMinMax(iNewMin:=0)
        ucrNudColumnFactors.Increment = 1

        ucrPnlMargin.AddRadioButton(rdoOuter)
        ucrPnlMargin.AddRadioButton(rdoSummary)
        ucrPnlMargin.AddRadioButton(rdoBoth)
        ucrPnlMargin.SetLinkedDisplayControl(grpMargin)

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrChkSummaries.SetParameter(New RParameter("treat_columns_as_factor", 9))
        ucrChkSummaries.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSummaries.SetText("Treat Summaries as a Further Factor")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 6))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrReceiverWeights.SetParameter(New RParameter("weights", 7))
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.Selector = ucrSelectorSummaryTables
        ucrReceiverWeights.SetDataType("numeric")

        ucrChkWeight.SetText("Weights")
        ucrChkWeight.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeight.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'Not yet implemented
        ucrChkWeight.Enabled = False

        ucrInputNA.SetParameter(New RParameter("na_display", 8))
        ucrInputNA.SetRDefault(Chr(34) & Chr(34))

        ucrSaveTable.SetPrefix("summary_table")
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
        clsMutableOperator = New ROperator
        clsColumnOperator = New ROperator
        clsGetDataframe = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()
        ucrSaveTable.Reset()
        ucrNudColumnFactors.SetText(1)

        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        clsMutableOperator.SetOperation("+")

        clsColumnOperator.SetOperation("+")

        clsConcFunction.SetRCommand("c")

        clsSummariesHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsSummariesHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsSummariesHeaderLeftTopFunction.AddParameter("summary", "summary", iPosition:=0, bIncludeArgumentName:=False)

        clsSummariesHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummariesHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummariesHeaderTopLeftFunction.AddParameter("summary", "summary", iPosition:=0, bIncludeArgumentName:=False)

        clsVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsVariableHeaderLeftTopFunction.AddParameter("variable", "variable", iPosition:=0, bIncludeArgumentName:=False)

        clsVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsVariableHeaderTopLeftFunction.AddParameter("variable", "variable", iPosition:=0, bIncludeArgumentName:=False)

        clsummaryVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsummaryVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsummaryVariableHeaderLeftTopFunction.AddParameter("summary_variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0, bIncludeArgumentName:=False)

        clsSummaryVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummaryVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummaryVariableHeaderTopLeftFunction.AddParameter("summary_variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0, bIncludeArgumentName:=False)

        clsMutableFunction.SetPackageName("mmtable2")
        clsMutableFunction.SetRCommand("mmtable")
        clsMutableFunction.AddParameter("data", "summary_table", iPosition:=0)
        clsMutableFunction.AddParameter("cells", "value", iPosition:=1)

        clsMutableOperator.AddParameter("mutableFunc", clsRFunctionParameter:=clsMutableFunction, iPosition:=0)
        clsMutableOperator.AddParameter("summariesVariableTopLeft", clsRFunctionParameter:=clsSummaryVariableHeaderTopLeftFunction, iPosition:=1)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=9)
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=2)
        clsDefaultFunction.SetAssignTo("summary_table")

        clsGetDataframe = ucrSelectorSummaryTables.ucrAvailableDataFrames.clsCurrDataFrame
        clsGetDataframe.SetAssignTo(ucrSelectorSummaryTables.ucrAvailableDataFrames.cboAvailableDataFrames.Text)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataframe, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultFunction, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseROperator(clsMutableOperator)
        clsMutableOperator.SetAssignTo("last_table", strTempDataframe:=ucrSelectorSummaryTables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_table")
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorSummaryTables.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverSummaryCols.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverFactors.SetRCode(clsDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsDefaultFunction, bReset)
        ucrPnlMargin.SetRCode(clsDefaultFunction, bReset)
        ucrInputMarginName.SetRCode(clsDefaultFunction, bReset)
        ucrChkSummaries.SetRCode(clsDefaultFunction, bReset)
        ucrNudSigFigs.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverWeights.SetRCode(clsDefaultFunction, bReset)
        ucrChkWeight.SetRCode(clsDefaultFunction, bReset)
        ucrInputNA.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplaySummariesAsRow.SetRCode(clsMutableOperator, bReset)
        ucrChkDisplaySummaryVariablesAsRow.SetRCode(clsMutableOperator, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsMutableOperator, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrSaveTable.SetRCode(clsMutableOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse (ucrChkWeight.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso Not ucrReceiverSummaryCols.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
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
                clsDefaultFunction.AddParameter("margins", "c(""outer"",""summary"")", iPosition:=8)
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
            Else
                clsMutableOperator.RemoveParameterByName("summariesLeftTop")
                clsMutableOperator.AddParameter("summariesTopLeft", clsRFunctionParameter:=clsSummariesHeaderTopLeftFunction, iPosition:=1)
            End If

            If ucrChkDisplayVariablesAsRows.Checked Then
                clsMutableOperator.RemoveParameterByName("variablesTopLeft")
                clsMutableOperator.AddParameter("variablesLeftTop", clsRFunctionParameter:=clsVariableHeaderLeftTopFunction, iPosition:=1)
            Else
                clsMutableOperator.RemoveParameterByName("variablesLeftTop")
                clsMutableOperator.AddParameter("variablesTopLeft", clsRFunctionParameter:=clsVariableHeaderTopLeftFunction, iPosition:=1)
            End If
        Else
            clsMutableOperator.RemoveParameterByName("summariesTopLeft")
            clsMutableOperator.RemoveParameterByName("summariesLeftTop")
            clsMutableOperator.RemoveParameterByName("variablesTopLeft")
            clsMutableOperator.RemoveParameterByName("variablesLeftTop")
            If ucrChkDisplaySummaryVariablesAsRow.Checked Then
                clsMutableOperator.RemoveParameterByName("summariesVariableTopLeft")
                clsMutableOperator.AddParameter("summariesVariableLeftTop", clsRFunctionParameter:=clsummaryVariableHeaderLeftTopFunction, iPosition:=1)
            Else
                clsMutableOperator.RemoveParameterByName("summariesVariableLeftTop")
                clsMutableOperator.AddParameter("summariesVariableTopLeft", clsRFunctionParameter:=clsSummaryVariableHeaderTopLeftFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged, ucrNudColumnFactors.ControlValueChanged
        AddMutableFunctions()
    End Sub

    Private Sub AddMutableFunctions()
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