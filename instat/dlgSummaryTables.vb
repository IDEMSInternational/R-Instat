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
    Private bResetFormatSubdialog As Boolean = False
    Private clsSummaryDefaultFunction, clsFrequencyDefaultFunction, clsConcFunction As New RFunction
    Private bRCodeSet As Boolean = True
    Private clsStubHeadFunction, clsPivotWiderFunction As New RFunction
    Private iUcrBaseXLocation, iDialogueXsize As Integer

    Private clsTableTitleFunction, clsStubFunction, clsStubCellsFunction, clsTabFootnoteTitleFunction, clsStubFootnoteFunction, clsTableSourcenoteFunction, clsFootnoteTitleLocationFunction, clsFootnoteSubtitleLocationFunction,
            clsTabFootnoteSubtitleFunction, clsFootnoteCellFunction, clsFootnoteCellBodyFunction,
            clsSecondFootnoteCellFunction, clsSecondFootnoteCellBodyFunction, clsTabStyleFunction, clsDummyFunction,
            clsTabStyleCellTextFunction, clsTabStylePxFunction, clsTabStyleCellTitleFunction, clsThemesTabOptionsFunction,
            clsgtExtraThemesFunction, clsGtFunction As New RFunction

    Private clsSummaryOperator, clsFrequencyOperator, clsPipeOperator, clsJoiningPipeOperator As New ROperator

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
        DialogueSize()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 426
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        iUcrBaseXLocation = ucrBase.Location.X
        iDialogueXsize = Me.Height

        'summary_name = NA - 8
        ucrSelectorSummaryTables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSummaryTables.SetParameterIsString()

        ucrReceiverSummaryCols.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSummaryCols.Selector = ucrSelectorSummaryTables
        ucrReceiverSummaryCols.SetDataType("numeric")
        ucrReceiverSummaryCols.SetParameterIsString()
        ucrReceiverSummaryCols.SetLinkedDisplayControl(lblVariables)

        ucrReceiverFactors.SetParameter(New RParameter("factors", 2))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorSummaryTables
        ucrReceiverFactors.SetDataType("factor")

        ucrReceiverWeights.SetParameter(New RParameter("weights", 3))
        ucrReceiverWeights.SetParameterIsString()
        ucrReceiverWeights.Selector = ucrSelectorSummaryTables
        ucrReceiverWeights.SetDataType("numeric")

        ucrReceiverPercentages.SetParameter(New RParameter("perc_total_factors", 1))
        ucrReceiverPercentages.SetParameterIsString()
        ucrReceiverPercentages.Selector = ucrSelectorSummaryTables
        ucrReceiverPercentages.SetDataType("factor") ' TODO data this accepts must be in the other receiver too
        ucrReceiverPercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkStoreResults.SetText("Store Output")
        ucrChkStoreResults.SetParameter(New RParameter("store_table", 4))
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("FALSE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 5))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")
        ucrChkOmitMissing.SetLinkedDisplayControl(cmdMissingOptions)

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 6))
        ucrChkDisplayMargins.SetText("Display Outer Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")
        ucrChkDisplayMargins.AddToLinkedControls({ucrInputMarginName}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                 bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All")
        ucrChkDisplayMargins.AddToLinkedControls({ucrPnlMargin}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True,
                                                 bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoOuter)

        ucrChkFrequencyDisplayMargins.SetParameter(New RParameter("include_margins", 3))
        ucrChkFrequencyDisplayMargins.SetText("Display Margins")
        ucrChkFrequencyDisplayMargins.SetRDefault("FALSE")
        ucrChkFrequencyDisplayMargins.AddToLinkedControls(ucrInputFrequencyMarginName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True,
                                                  bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All", bNewLinkedUpdateFunction:=True)

        ucrInputFrequencyMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputFrequencyMarginName.SetLinkedDisplayControl(lblFrequencyMarginName)

        ucrPnlMargin.SetParameter(New RParameter("margins", iNewPosition:=7))
        ucrPnlMargin.AddRadioButton(rdoOuter, Chr(34) & "outer" & Chr(34))
        ucrPnlMargin.AddRadioButton(rdoSummary, Chr(34) & "summary" & Chr(34))
        ucrPnlMargin.AddRadioButton(rdoBoth, "c(""outer"",""summary"")")
        ucrPnlMargin.SetLinkedDisplayControl(grpMargin)

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrChkSummaries.SetParameter(New RParameter("treat_columns_as_factor", 8))
        ucrChkSummaries.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSummaries.SetText("Treat Summaries as a Further Factor")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 9))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrChkWeight.SetText("Weights")
        ucrChkWeight.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeight.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'Not yet implemented
        ucrChkWeight.Visible = False

        ucrPnlSummaryFrequencyTables.AddRadioButton(rdoSummaryTable)
        ucrPnlSummaryFrequencyTables.AddRadioButton(rdoFrequencyTable)
        ucrPnlSummaryFrequencyTables.AddRadioButton(rdoMultipleResponse)
        ucrPnlSummaryFrequencyTables.AddParameterValuesCondition(rdoSummaryTable, "rdo_checked", "rdoSummary")
        ucrPnlSummaryFrequencyTables.AddParameterValuesCondition(rdoFrequencyTable, "rdo_checked", "rdoFrequency")
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrReceiverSummaryCols}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrReorderSummary}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkDisplayAsPercentage}, {rdoFrequencyTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkSummaries}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkDisplayMargins}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkFrequencyDisplayMargins}, {rdoFrequencyTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrChkOmitMissing}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSummaryFrequencyTables.AddToLinkedControls({ucrPnlColumnFactor}, {rdoSummaryTable}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 2))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverPercentages, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                      bNewLinkedAddRemoveParameter:=True, bNewLinkedUpdateFunction:=True)
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True,
                                                      bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)
        ucrChkDisplayAsPercentage.SetLinkedDisplayControl(grpPercentages)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 3))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrPnlColumnFactor.AddRadioButton(rdoNoColumnFactor)
        ucrPnlColumnFactor.AddRadioButton(rdoFactorVariable)
        ucrPnlColumnFactor.AddRadioButton(rdoSummaryVariable)
        ucrPnlColumnFactor.AddRadioButton(rdoVariable)
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoNoColumnFactor, "factor_cols", "NoColFactor")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoFactorVariable, "factor_cols", "FactorVar")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoSummaryVariable, "factor_cols", "SumVar")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoVariable, "factor_cols", "Var")
        ucrPnlColumnFactor.AddToLinkedControls(ucrReceiverColumnFactor, {rdoFactorVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverColumnFactor.SetParameter(New RParameter("names_from", 0))
        ucrReceiverColumnFactor.Selector = ucrSelectorSummaryTables
        ucrReceiverColumnFactor.SetDataType("factor")

        ucrSaveTable.SetPrefix("summary_table")
        ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrSelectorSummaryTables.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")

        ucrReorderSummary.bDataIsSummaries = True
    End Sub

    Private Sub SetDefaults()
        clsSummaryDefaultFunction = New RFunction
        clsFrequencyDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsConcFunction = New RFunction
        clsTableTitleFunction = New RFunction
        clsStubFunction = New RFunction
        clsStubCellsFunction = New RFunction
        clsTabFootnoteTitleFunction = New RFunction
        clsStubFootnoteFunction = New RFunction
        clsTableSourcenoteFunction = New RFunction
        clsFootnoteTitleLocationFunction = New RFunction
        clsFootnoteSubtitleLocationFunction = New RFunction
        clsSummaryOperator = New ROperator
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
        clsFrequencyOperator = New ROperator
        clsDummyFunction = New RFunction
        clsThemesTabOptionsFunction = New RFunction
        clsgtExtraThemesFunction = New RFunction
        clsGtFunction = New RFunction
        clsPivotWiderFunction = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()
        ucrSaveTable.Reset()

        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        clsDummyFunction.AddParameter("theme", "select", iPosition:=11)
        clsDummyFunction.AddParameter("rdo_checked", "rdoFrequency", iPosition:=1)
        clsDummyFunction.AddParameter("factor_cols", "FactorVar", iPosition:=2)

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.bBrackets = False

        clsConcFunction.SetRCommand("c")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.bBrackets = False

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)

        clsThemesTabOptionsFunction.SetPackageName("gt")
        clsThemesTabOptionsFunction.SetRCommand("tab_options")

        clsgtExtraThemesFunction.SetPackageName("gtExtras")
        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")

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

        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=1)

        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsSummaryDefaultFunction, iPosition:=0)
        clsSummaryOperator.AddParameter("gttbl", clsRFunctionParameter:=clsGtFunction, iPosition:=2)

        clsFrequencyOperator.SetOperation("%>%")
        clsFrequencyOperator.bBrackets = False
        clsFrequencyOperator.AddParameter("tableFun", clsRFunctionParameter:=clsFrequencyDefaultFunction, iPosition:=0)
        clsFrequencyOperator.AddParameter("gttbl", clsRFunctionParameter:=clsGtFunction, iPosition:=2)

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsSummaryDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryDefaultFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=8)
        clsSummaryDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=12)
        clsSummaryDefaultFunction.SetAssignToObject("summary_table")

        clsFrequencyDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsFrequencyDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=8)
        clsFrequencyDefaultFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=10)
        clsFrequencyDefaultFunction.AddParameter("summaries", "count_label", iPosition:=11)
        clsFrequencyDefaultFunction.SetAssignToObject("frequency_table")

        clsTableTitleFunction.SetPackageName("gt")
        clsTableTitleFunction.SetRCommand("tab_header")

        clsStubFunction.SetPackageName("gt")
        clsStubFunction.SetRCommand("tab_stubhead")

        clsStubCellsFunction.SetPackageName("gt")
        clsStubCellsFunction.SetRCommand("cells_stubhead")

        clsTabFootnoteTitleFunction.SetPackageName("gt")
        clsTabFootnoteTitleFunction.SetRCommand("tab_footnote")

        clsStubFootnoteFunction.SetPackageName("gt")
        clsStubFootnoteFunction.SetRCommand("tab_footnote")

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

        ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
        clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorSummaryTables.strCurrentDataFrame,
                                                  strObjectName:="last_table")

        bResetSubdialog = True
        bResetFormatSubdialog = True
        TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False
        ucrSelectorSummaryTables.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrSelectorSummaryTables.GetParameter, iAdditionalPairNo:=1)
        ucrChkStoreResults.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrChkStoreResults.GetParameter, iAdditionalPairNo:=1)
        ucrNudSigFigs.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrNudSigFigs.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverFactors.AddAdditionalCodeParameterPair(clsFrequencyDefaultFunction, ucrReceiverFactors.GetParameter, iAdditionalPairNo:=1)

        ucrSelectorSummaryTables.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkOmitMissing.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkFrequencyDisplayMargins.SetRCode(clsFrequencyDefaultFunction, bReset)
        ucrNudSigFigs.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrReceiverWeights.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkSummaries.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkWeight.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrPnlSummaryFrequencyTables.SetRCode(clsDummyFunction, bReset)
        ucrChkStoreResults.SetRCode(clsSummaryDefaultFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsFrequencyDefaultFunction, bReset)
        ucrPnlColumnFactor.SetRCode(clsDummyFunction, bReset)
        ucrSaveTable.SetRCode(clsJoiningPipeOperator, bReset)
        If bReset Then
            ucrReceiverSummaryCols.SetRCode(clsSummaryDefaultFunction, bReset)
            ucrReceiverFactors.SetRCode(clsSummaryDefaultFunction, bReset)
        End If
        bRCodeSet = True
        FillListView()
    End Sub

    Private Sub TestOKEnabled()
        If rdoSummaryTable.Checked Then
            If ucrSaveTable.IsComplete AndAlso ucrNudSigFigs.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse
                (ucrChkWeight.Checked AndAlso Not ucrReceiverWeights.IsEmpty)) AndAlso
                Not ucrReceiverSummaryCols.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrReceiverFactors.IsEmpty AndAlso ucrSaveTable.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, clsSummaryDefaultFunction, clsConcFunction, ucrSelectorSummaryTables, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.bEnable2VariableTab = False
        sdgSummaries.ShowDialog()
        sdgSummaries.bEnable2VariableTab = True
        FillListView()
        TestOKEnabled()
    End Sub

    Private Sub cmdFormatTable_Click(sender As Object, e As EventArgs) Handles cmdFormatTable.Click
        If rdoSummaryTable.Checked Then
            sdgFormatSummaryTables.SetRCode(clsNewStubCellsFunction:=clsStubCellsFunction, clsNewTableTitleFunction:=clsTableTitleFunction, clsNewStubFunction:=clsStubFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewStubFootnoteFunction:=clsStubFootnoteFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                         clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                       clsNewPipeOperator:=clsPipeOperator, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                       clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                       clsNewMutableOPerator:=clsSummaryOperator, clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction,
                                       clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, clsNewThemesTabOptionFunction:=clsThemesTabOptionsFunction,
                                       clsNewgtExtraThemesFunction:=clsgtExtraThemesFunction, bReset:=bResetFormatSubdialog)
        Else
            sdgFormatSummaryTables.SetRCode(clsNewStubCellsFunction:=clsStubCellsFunction, clsNewTableTitleFunction:=clsTableTitleFunction, clsNewStubFunction:=clsStubFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewStubFootnoteFunction:=clsStubFootnoteFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                       clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                     clsNewPipeOperator:=clsPipeOperator, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                     clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                     clsNewMutableOPerator:=clsFrequencyOperator, clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction,
                                     clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, clsNewThemesTabOptionFunction:=clsThemesTabOptionsFunction,
                                     clsNewgtExtraThemesFunction:=clsgtExtraThemesFunction, bReset:=bResetFormatSubdialog)
        End If

        sdgFormatSummaryTables.ShowDialog()
        bResetFormatSubdialog = False
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

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged, ucrSaveTable.ControlContentsChanged,
        ucrChkWeight.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrReceiverSummaryCols.ControlContentsChanged,
        ucrPnlSummaryFrequencyTables.ControlContentsChanged, ucrPnlColumnFactor.ControlContentsChanged, ucrReceiverColumnFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnFactor.ControlValueChanged,
        ucrChkSummaries.ControlValueChanged, ucrPnlSummaryFrequencyTables.ControlValueChanged, ucrReceiverColumnFactor.ControlValueChanged,
        ucrReceiverFactors.ControlValueChanged
        cmdSummaries.Visible = rdoSummaryTable.Checked
        cmdFormatTable.Location = New Point(286, If(rdoSummaryTable.Checked, 464, 273))
        If rdoFrequencyTable.Checked Then
            grpDisplay.Visible = False
            rdoVariable.Visible = False
            clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsFrequencyOperator, iPosition:=0)
            clsDummyFunction.AddParameter("rdo_checked", "rdoFrequency", iPosition:=1)
            ucrSaveTable.SetPrefix("frequency_table")
            rdoSummaryVariable.Text = "Summary-Variable"
        Else
            grpDisplay.Visible = True
            clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
            clsDummyFunction.AddParameter("rdo_checked", "rdoSummary", iPosition:=1)
            ucrSaveTable.SetPrefix("summary_table")
            If ucrChkSummaries.Checked Then
                rdoSummaryVariable.Text = "Summary"
                rdoVariable.Visible = True
            Else
                rdoSummaryVariable.Text = "Summary-Variable"
                rdoVariable.Visible = False
            End If
        End If
        If bRCodeSet Then
            If rdoNoColumnFactor.Checked Then
                clsSummaryOperator.RemoveParameterByName("col_factor")
                clsFrequencyOperator.RemoveParameterByName("col_factor")
                clsDummyFunction.AddParameter("factor_cols", "NoColFactor", iPosition:=2)
            Else
                clsFrequencyOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
                clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
                If rdoFactorVariable.Checked Then
                    ucrReceiverColumnFactor.SetMeAsReceiver()
                    clsDummyFunction.AddParameter("factor_cols", "FactorVar", iPosition:=2)
                    clsPivotWiderFunction.AddParameter("names_from", ucrReceiverColumnFactor.GetVariableNames(False), iPosition:=0)
                ElseIf rdoSummaryVariable.Checked Then
                    clsDummyFunction.AddParameter("factor_cols", "SumVar", iPosition:=2)
                    If rdoFrequencyTable.Checked Then
                        clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)
                    Else
                        If ucrChkSummaries.Checked Then
                            clsPivotWiderFunction.AddParameter("names_from", "summary", iPosition:=0)
                        Else
                            clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)
                        End If
                    End If
                ElseIf rdoVariable.Checked Then
                    clsDummyFunction.AddParameter("factor_cols", "Var", iPosition:=2)
                    clsPivotWiderFunction.AddParameter("names_from", "variable", iPosition:=0)
                End If
            End If
        End If

        If rdoVariable.Checked Then
            If Not ucrChkSummaries.Checked Then
                rdoSummaryVariable.Checked = True
            Else
                rdoVariable.Checked = True
            End If
        End If
        AddingColumnFactor()
        DialogueSize()
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

    Private Sub ucrChkDisplayAsPercentage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayAsPercentage.ControlValueChanged
        If ucrChkDisplayAsPercentage.Checked Then
            ucrReceiverPercentages.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
        DialogueSize()
    End Sub

    Private Sub DialogueSize()
        If rdoFrequencyTable.Checked Then
            Me.Size = New Size(505, iDialogueXsize * 0.75)
            Me.ucrNudSigFigs.Location = New Point(119, 304)
            Me.lblSigFigs.Location = New Point(7, 307)
            Me.ucrSaveTable.Location = New Point(10, 340)
            Me.ucrBase.Location = New Point(iUcrBaseXLocation, 370)
        Else
            Me.Size = New Size(505, iDialogueXsize)
            Me.ucrNudSigFigs.Location = New Point(119, 356)
            Me.lblSigFigs.Location = New Point(7, 359)
            Me.ucrSaveTable.Location = New Point(10, 495)
            Me.ucrBase.Location = New Point(iUcrBaseXLocation, 524)
        End If
    End Sub

    Private Sub AddingColumnFactor()
        Dim lstVariables As New List(Of String)
        Dim iXVarCount As Integer

        iXVarCount = lstVariables.Count
        If bRCodeSet Then
            If lstVariables.Contains(ucrReceiverColumnFactor.GetVariableNames(False)) OrElse
                Not ucrReceiverFactors.GetVariableNamesAsList().Contains(ucrReceiverColumnFactor.GetVariableNames(False)) Then
                ucrReceiverColumnFactor.Clear()
                ucrReceiverFactors.SetMeAsReceiver()
            End If
            If iXVarCount = 0 AndAlso ucrReceiverFactors.lstSelectedVariables.Items.Count >= 1 AndAlso
                ucrReceiverColumnFactor.IsEmpty() Then
                ucrReceiverColumnFactor.Add(ucrReceiverFactors.lstSelectedVariables.Items(0).Text)
                ucrReceiverFactors.SetMeAsReceiver()
            ElseIf ucrReceiverFactors.IsEmpty Then
                ucrReceiverColumnFactor.Clear()
            End If
            lstVariables = ucrReceiverFactors.GetVariableNamesAsList()
            If ucrReceiverFactors.lstSelectedVariables.Items.Count >= 1 Then
                Dim iIndex = ucrReceiverFactors.lstSelectedVariables.Items.Count - 1
                ucrReceiverPercentages.Add(ucrReceiverFactors.lstSelectedVariables.Items(iIndex).Text)
                ucrReceiverFactors.SetMeAsReceiver()
            End If
        End If
    End Sub

End Class
