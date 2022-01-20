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
Public Class dlgSummaryTables
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction, clsConcFunction, clsMutableFunction As New RFunction
    Private clsSummariesHeaderLeftTopFunction, clsSummariesHeaderTopLeftFunction,
            clsVariableHeaderLeftTopFunction, clsVariableHeaderTopLeftFunction, clsStubHeadFunction,
            clsummaryVariableHeaderLeftTopFunction, clsSummaryVariableHeaderTopLeftFunction As New RFunction

    Private clsTableTitleFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction,
            clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsHeaderFormatFunction,
            clsTabOptionsFunction, clsBorderWeightPxFunction, clsFootnoteTitleLocationFunction, clsFootnoteSubtitleLocationFunction,
            clsTabFootnoteSubtitleFunction, clsStyleListFunction, clsFootnoteCellFunction, clsFootnoteCellBodyFunction,
            clsSecondFootnoteCellFunction, clsSecondFootnoteCellBodyFunction, clsTabStyleFunction, clsDummyFunction,
            clsTabStyleCellTextFunction, clsTabStylePxFunction, clsTabStyleCellTitleFunction As New RFunction
    Private clsMutableOperator, clsColumnOperator, clsPipeOperator, clsJoiningPipeOperator,
            clsTabFootnoteOperator As New ROperator

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
        ucrChkStoreResults.SetRDefault("FALSE")

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

        ucrPnlMargin.SetParameter(New RParameter("margins", iNewPosition:=8))
        ucrPnlMargin.AddRadioButton(rdoOuter, Chr(34) & "outer" & Chr(34))
        ucrPnlMargin.AddRadioButton(rdoSummary, Chr(34) & "summary" & Chr(34))
        ucrPnlMargin.AddRadioButton(rdoBoth, "c(""outer"",""summary"")")
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

        ucrReorderSummary.bDataIsSummaries = True
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
        clsTableTitleFunction = New RFunction
        clsTabFootnoteTitleFunction = New RFunction
        clsTableSourcenoteFunction = New RFunction
        clsCellTextFunction = New RFunction
        clsCellBorderFunction = New RFunction
        clsCellFillFunction = New RFunction
        clsHeaderFormatFunction = New RFunction
        clsTabOptionsFunction = New RFunction
        clsBorderWeightPxFunction = New RFunction
        clsFootnoteTitleLocationFunction = New RFunction
        clsFootnoteSubtitleLocationFunction = New RFunction
        clsStyleListFunction = New RFunction
        clsMutableOperator = New ROperator
        clsColumnOperator = New ROperator
        clsPipeOperator = New ROperator
        clsTabFootnoteSubtitleFunction = New RFunction
        clsFootnoteCellBodyFunction = New RFunction
        clsSecondFootnoteCellBodyFunction = New RFunction
        clsFootnoteCellFunction = New RFunction
        clsSecondFootnoteCellFunction = New RFunction
        clsStubHeadFunction = New RFunction
        clsTabStyleFunction = New RFunction
        clsTabStyleCellTextFunction = New RFunction
        clsTabStylePxFunction = New RFunction
        clsTabStyleCellTitleFunction = New RFunction
        clsJoiningPipeOperator = New ROperator
        clsTabFootnoteOperator = New ROperator
        clsDummyFunction = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()
        ucrSaveTable.Reset()
        ucrNudColumnFactors.SetText(1)

        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        clsMutableOperator.SetOperation("+")

        clsColumnOperator.SetOperation("+")

        clsConcFunction.SetRCommand("c")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.bBrackets = False

        clsTabFootnoteOperator.SetOperation("%>%")
        clsTabFootnoteOperator.bBrackets = False

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsMutableOperator, iPosition:=0)

        clsStubHeadFunction.SetPackageName("gt")
        clsStubHeadFunction.SetRCommand("tab_stubhead")

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

        clsSummariesHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsSummariesHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsSummariesHeaderLeftTopFunction.AddParameter("variable", "summary", iPosition:=0)

        clsSummariesHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummariesHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummariesHeaderTopLeftFunction.AddParameter("variable", "summary", iPosition:=0)

        clsVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsVariableHeaderLeftTopFunction.AddParameter("variable", "variable", iPosition:=0)

        clsVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsVariableHeaderTopLeftFunction.AddParameter("variable", "variable", iPosition:=0)

        clsummaryVariableHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsummaryVariableHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsummaryVariableHeaderLeftTopFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

        clsSummaryVariableHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummaryVariableHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummaryVariableHeaderTopLeftFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

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

        clsCellTextFunction.SetPackageName("gt")
        clsCellTextFunction.SetRCommand("cell_text")

        clsCellBorderFunction.SetPackageName("gt")
        clsCellBorderFunction.SetRCommand("cell_borders")
        clsCellBorderFunction.AddParameter("weight", clsRFunctionParameter:=clsBorderWeightPxFunction, iPosition:=3)

        clsCellFillFunction.SetPackageName("gt")
        clsCellFillFunction.SetRCommand("cell_fill")

        clsHeaderFormatFunction.SetPackageName("mmtable2")
        clsHeaderFormatFunction.SetRCommand("header_format")
        clsHeaderFormatFunction.AddParameter("header", Chr(34) & "all_cols" & Chr(34), iPosition:=0)
        clsHeaderFormatFunction.AddParameter("style", clsRFunctionParameter:=clsStyleListFunction, iPosition:=1)

        clsTabOptionsFunction.SetPackageName("gt")
        clsTabOptionsFunction.SetRCommand("tab_options")

        clsBorderWeightPxFunction.SetPackageName("gt")
        clsBorderWeightPxFunction.SetRCommand("px")
        clsBorderWeightPxFunction.AddParameter("weight", "1", iPosition:=0, bIncludeArgumentName:=False)

        clsStyleListFunction.SetRCommand("list")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
        clsJoiningPipeOperator.SetAssignTo("last_table", strTempDataframe:=ucrSelectorSummaryTables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_table")
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
        ucrChkDisplaySummariesAsRow.SetRCode(clsMutableOperator, bReset)
        ucrChkDisplaySummaryVariablesAsRow.SetRCode(clsMutableOperator, bReset)
        ucrChkDisplayVariablesAsRows.SetRCode(clsMutableOperator, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrSaveTable.SetRCode(clsJoiningPipeOperator, bReset)
        FillListView()
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveTable.IsComplete AndAlso ucrNudColumnFactors.GetText() <> "" AndAlso ucrNudSigFigs.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse (ucrChkWeight.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso Not ucrReceiverSummaryCols.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
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
        FillListView()
        TestOKEnabled()
    End Sub

    Private Sub cmdFormatTable_Click(sender As Object, e As EventArgs) Handles cmdFormatTable.Click
        sdgFormatSummaryTables.SetRCode(clsNewTableTitleFunction:=clsTableTitleFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                         clsNewCellTextFunction:=clsCellTextFunction, clsNewCellBorderFunction:=clsCellBorderFunction, clsNewCellFillFunction:=clsCellFillFunction, clsNewHeaderFormatFunction:=clsHeaderFormatFunction,
                                         clsNewTabOptionsFunction:=clsTabOptionsFunction, clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewStubHeadFunction:=clsStubHeadFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                        clsNewPipeOperator:=clsPipeOperator, clsNewBorderWeightPxFunction:=clsBorderWeightPxFunction, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                        clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                        clsNewStyleListFunction:=clsStyleListFunction, clsNewMutableOPerator:=clsMutableOperator, clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction, clsNewTabFootnoteOperator:=clsTabFootnoteOperator,
                                        clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, bReset:=bReset)
        sdgFormatSummaryTables.ShowDialog()
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

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged, ucrChkWeight.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrNudSigFigs.ControlContentsChanged, ucrReceiverSummaryCols.ControlContentsChanged, ucrNudColumnFactors.ControlValueChanged
        TestOKEnabled()
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplaySummariesAsRow.ControlValueChanged, ucrChkDisplayVariablesAsRows.ControlValueChanged, ucrChkDisplaySummaryVariablesAsRow.ControlValueChanged, ucrChkSummaries.ControlValueChanged
        clsMutableOperator.RemoveParameterByName("summariesTopLeft")
        clsMutableOperator.RemoveParameterByName("summariesLeftTop")
        clsMutableOperator.RemoveParameterByName("variablesTopLeft")
        clsMutableOperator.RemoveParameterByName("variablesLeftTop")
        clsMutableOperator.RemoveParameterByName("summariesVariableTopLeft")
        clsMutableOperator.RemoveParameterByName("summariesVariableLeftTop")

        If ucrChkSummaries.Checked Then
            If ucrChkDisplaySummariesAsRow.Checked Then
                clsMutableOperator.AddParameter("summariesLeftTop", clsRFunctionParameter:=clsSummariesHeaderLeftTopFunction, iPosition:=1)
            Else
                clsMutableOperator.AddParameter("summariesTopLeft", clsRFunctionParameter:=clsSummariesHeaderTopLeftFunction, iPosition:=1)
            End If

            If ucrChkDisplayVariablesAsRows.Checked Then
                clsMutableOperator.AddParameter("variablesLeftTop", clsRFunctionParameter:=clsVariableHeaderLeftTopFunction, iPosition:=1)
            Else
                clsMutableOperator.AddParameter("variablesTopLeft", clsRFunctionParameter:=clsVariableHeaderTopLeftFunction, iPosition:=1)
            End If
        Else
            If ucrChkDisplaySummaryVariablesAsRow.Checked Then
                clsMutableOperator.AddParameter("summariesVariableLeftTop", clsRFunctionParameter:=clsummaryVariableHeaderLeftTopFunction, iPosition:=1)
            Else
                clsMutableOperator.AddParameter("summariesVariableTopLeft", clsRFunctionParameter:=clsSummaryVariableHeaderTopLeftFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged, ucrNudColumnFactors.ControlValueChanged
        Dim iColumn As Integer = 0
        Dim iNumberOfColumns As Integer

        clsColumnOperator.ClearParameters()
        clsMutableOperator.RemoveParameterByName("columnOp")

        If Not ucrReceiverFactors.IsEmpty AndAlso ucrNudColumnFactors.GetText() <> "" Then
            iNumberOfColumns = ucrNudColumnFactors.GetText()
            For Each strColumn As String In ucrReceiverFactors.GetVariableNamesAsList
                Dim clsHeaderFunction As New RFunction
                clsHeaderFunction.SetPackageName("mmtable2")
                clsHeaderFunction.SetRCommand(If(iColumn < iNumberOfColumns, "header_top_left", "header_left_top"))
                clsHeaderFunction.AddParameter("variable", strColumn, iPosition:=0)
                clsColumnOperator.AddParameter(strColumn, clsRFunctionParameter:=clsHeaderFunction, iPosition:=iColumn)
                iColumn += 1
            Next
            clsMutableOperator.AddParameter("columnOp", clsROperatorParameter:=clsColumnOperator, iPosition:=3)
        End If
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
End Class