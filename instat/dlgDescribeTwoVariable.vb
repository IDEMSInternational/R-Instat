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
Public Class dlgDescribeTwoVariable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRcodeSet As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public strFirstVariablesType, strSecondVariableType As String

    'MAPPING AND SUMMARY FUNCTIoNS
    Private clsCombineFrequencyParametersFunction, clsCombineFunction,
        clsCombineMultipleColumnsFunction, clsDummyFunction, clsFormatTableMapFunction,
        clsGroupByFunction, clsHeaderLeftTopFunction, clsHeaderTopLeftFunction,
        clsMmtableFunction, clsMmtableMapFunction, clsRAnovaFunction,
        clsRCorrelationFunction, clsRCustomSummaryFunction, clsRenameFunction,
        clsSecondHeaderFunction, clsSkimrFunction, clsSummariesListFunction,
        clsSummaryMapFunction, clsSummaryTableCombineFactorsFunction,
        clsSummaryTableFunction, clsThreeVariableCombineFrequencyParametersFunction As New RFunction

    'FORMAT TABLE FUNCTIONS
    Private clsBorderWeightPxFunction, clsCellBorderFunction, clsCellFillFunction,
        clsCellTextFunction, clsFootnoteCellBodyFunction, clsFootnoteCellFunction,
        clsFootnoteSubtitleLocationFunction, clsFootnoteTitleLocationFunction,
        clsHeaderFormatFunction, clsSecondFootnoteCellBodyFunction,
        clsSecondFootnoteCellFunction, clsStubHeadFunction, clsStyleListFunction,
        clsTabFootnoteSubtitleFunction, clsTabFootnoteTitleFunction,
        clsTableSourcenoteFunction, clsTableTitleFunction, clsTabOptionsFunction,
        clsTabStyleCellTextFunction, clsTabStyleCellTitleFunction, clsTabStyleFunction,
        clsTabStylePxFunction As New RFunction

    Private clsGroupByPipeOperator, clsMmtablePlusOperator, clsMapPipeOperator,
             clsMmtableTildeOperator, clsSummaryTildeOperator, clsEmptyOperator,
             clsSecondEmptyOperator As New ROperator
    'Frequency Parameters
    Private lstFrequencyParameters As New List(Of String)({"percentage_type", "margin_name",
                                                          "perc_total_factors", "perc_decimal",
                                                          "signif_fig", "include_margins"})

    'Format Operators
    Private clsPipeOperator, clsTabFootnoteOperator,
            clsJoiningPipeOperator, clsFormatTableTildeOperator,
            clsFormatTableMappingPipeOperator As ROperator
    Private iUcrBaseXLocation, iDialogueXsize As Integer

    Private Sub dlgDescribeTwoVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 414
        ucrBase.clsRsyntax.iCallType = 2

        iUcrBaseXLocation = ucrBase.Location.X
        iDialogueXsize = Me.Size.Width

        ucrSelectorDescribeTwoVar.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDescribeTwoVar.SetParameterIsString()

        ucrReceiverFirstVars.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverFirstVars.SetParameterIsString()
        ucrReceiverFirstVars.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)

        ucrReceiverSecondTwoVariableFactor.SetParameter(New RParameter("factors", 2))
        ucrReceiverSecondTwoVariableFactor.SetParameterIsString()
        ucrReceiverSecondTwoVariableFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondTwoVariableFactor.SetLinkedDisplayControl(lbSecondVariable)

        ucrReceiverSkimrGroupByFactor.SetParameter(New RParameter("factors", 2, bNewIncludeArgumentName:=False))
        ucrReceiverSkimrGroupByFactor.bWithQuotes = False
        ucrReceiverSkimrGroupByFactor.SetParameterIsString()
        ucrReceiverSkimrGroupByFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSkimrGroupByFactor.SetLinkedDisplayControl(lblFirstGroupByFactor)
        ucrReceiverSkimrGroupByFactor.SetDataType("factor")

        ucrReceiverSecondSkimrGroupByFactor.SetParameter(New RParameter("second_factor", 3, bNewIncludeArgumentName:=False))
        ucrReceiverSecondSkimrGroupByFactor.bWithQuotes = False
        ucrReceiverSecondSkimrGroupByFactor.SetParameterIsString()
        ucrReceiverSecondSkimrGroupByFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverSecondSkimrGroupByFactor.SetLinkedDisplayControl(lblSecondGroupByFactor)
        ucrReceiverSecondSkimrGroupByFactor.SetDataType("factor")

        ucrReceiverThreeVariableThirdVariable.SetParameter(New RParameter("second_factors", 3, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariableThirdVariable.SetParameterIsString()
        ucrReceiverThreeVariableThirdVariable.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverThreeVariableThirdVariable.SetLinkedDisplayControl(lblThirdVariable)

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.bUpdateRCodeFromControl = True

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 5))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrPnlDescribe.AddRadioButton(rdoTwoVariable)
        ucrPnlDescribe.AddRadioButton(rdoSkim)
        ucrPnlDescribe.AddRadioButton(rdoThreeVariable)
        ucrPnlDescribe.AddParameterValuesCondition(rdoTwoVariable, "checked", "customize")
        ucrPnlDescribe.AddParameterValuesCondition(rdoSkim, "checked", "skim")
        ucrPnlDescribe.AddParameterValuesCondition(rdoThreeVariable, "checked", "three_variable")

        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSkimrGroupByFactor, ucrReceiverSecondSkimrGroupByFactor}, {rdoSkim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableThirdVariable}, {rdoThreeVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSecondTwoVariableFactor}, {rdoTwoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableSecondFactor}, {rdoThreeVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 1))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverPercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverThreeVariableSecondFactor.SetParameter(New RParameter("second_three_varible_factor", 0, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariableSecondFactor.SetParameterIsString()
        ucrReceiverThreeVariableSecondFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverThreeVariableSecondFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverThreeVariableSecondFactor.SetLinkedDisplayControl(lblThreeVariableSecondFactor)

        ucrReceiverPercentages.SetParameter(New RParameter("perc_total_factors", 2))
        ucrReceiverPercentages.SetParameterIsString()
        ucrReceiverPercentages.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverPercentages.SetDataType("factor")
        ucrReceiverPercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkThreeVariableDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 1))
        ucrChkThreeVariableDisplayAsPercentage.SetText("As Percentages")
        ucrChkThreeVariableDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkThreeVariableDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkThreeVariableDisplayAsPercentage.AddToLinkedControls(ucrReceiverThreeVariablePercentage, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                      bNewLinkedAddRemoveParameter:=True)
        ucrChkThreeVariableDisplayAsPercentage.AddToLinkedControls(ucrChkThreeVariablePercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True,
                                                      bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverThreeVariablePercentage.SetParameter(New RParameter("perc_total_factors", 2))
        ucrReceiverThreeVariablePercentage.SetParameterIsString()
        ucrReceiverThreeVariablePercentage.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverThreeVariablePercentage.SetDataType("factor")
        ucrReceiverThreeVariablePercentage.SetLinkedDisplayControl(lblThreeVariableFactorAsPercentages)

        ucrChkThreeVariablePercentageProportion.SetParameter(New RParameter("perc_decimal", 3))
        ucrChkThreeVariablePercentageProportion.SetText("Display as Decimal")
        ucrChkThreeVariablePercentageProportion.SetRDefault("FALSE")

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 3))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 6))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrNudColumnFactors.SetMinMax(1, 2)
    End Sub

    Private Sub SetDefaults()
        clsBorderWeightPxFunction = New RFunction
        clsCellBorderFunction = New RFunction
        clsCellFillFunction = New RFunction
        clsCellTextFunction = New RFunction
        clsCombineFrequencyParametersFunction = New RFunction
        clsCombineFunction = New RFunction
        clsCombineMultipleColumnsFunction = New RFunction
        clsDummyFunction = New RFunction
        clsFootnoteCellBodyFunction = New RFunction
        clsFootnoteCellFunction = New RFunction
        clsFootnoteSubtitleLocationFunction = New RFunction
        clsFootnoteTitleLocationFunction = New RFunction
        clsFormatTableMapFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsHeaderFormatFunction = New RFunction
        clsHeaderLeftTopFunction = New RFunction
        clsHeaderTopLeftFunction = New RFunction
        clsMmtableFunction = New RFunction
        clsMmtableMapFunction = New RFunction
        clsRAnovaFunction = New RFunction
        clsRCorrelationFunction = New RFunction
        clsRCustomSummaryFunction = New RFunction
        clsRenameFunction = New RFunction
        clsSecondFootnoteCellBodyFunction = New RFunction
        clsSecondFootnoteCellFunction = New RFunction
        clsSecondHeaderFunction = New RFunction
        clsSkimrFunction = New RFunction
        clsStyleListFunction = New RFunction
        clsStubHeadFunction = New RFunction
        clsSummariesListFunction = New RFunction
        clsSummaryMapFunction = New RFunction
        clsSummaryTableCombineFactorsFunction = New RFunction
        clsSummaryTableFunction = New RFunction
        clsTabFootnoteSubtitleFunction = New RFunction
        clsTabFootnoteTitleFunction = New RFunction
        clsTableSourcenoteFunction = New RFunction
        clsTableTitleFunction = New RFunction
        clsTabOptionsFunction = New RFunction
        clsTabStyleCellTextFunction = New RFunction
        clsTabStyleCellTitleFunction = New RFunction
        clsTabStyleFunction = New RFunction
        clsTabStylePxFunction = New RFunction
        clsThreeVariableCombineFrequencyParametersFunction = New RFunction
        clsEmptyOperator = New ROperator
        clsFormatTableMappingPipeOperator = New ROperator
        clsFormatTableTildeOperator = New ROperator
        clsGroupByPipeOperator = New ROperator
        clsJoiningPipeOperator = New ROperator
        clsMapPipeOperator = New ROperator
        clsMmtablePlusOperator = New ROperator
        clsMmtableTildeOperator = New ROperator
        clsPipeOperator = New ROperator
        clsSecondEmptyOperator = New ROperator
        clsTabFootnoteOperator = New ROperator


        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrInputMarginName.SetText("All")
        ucrNudColumnFactors.SetText("2")
        ucrInputMarginName.Visible = False

        ucrBase.clsRsyntax.ClearCodes()

        clsBorderWeightPxFunction.SetPackageName("gt")
        clsBorderWeightPxFunction.SetRCommand("px")
        clsBorderWeightPxFunction.AddParameter("weight", "1", iPosition:=0, bIncludeArgumentName:=False)

        clsCellBorderFunction.SetPackageName("gt")
        clsCellBorderFunction.SetRCommand("cell_borders")
        clsCellBorderFunction.AddParameter("weight", clsRFunctionParameter:=clsBorderWeightPxFunction, iPosition:=3)

        clsCellFillFunction.SetPackageName("gt")
        clsCellFillFunction.SetRCommand("cell_fill")

        clsCellTextFunction.SetPackageName("gt")
        clsCellTextFunction.SetRCommand("cell_text")

        clsCombineFrequencyParametersFunction.SetRCommand("c")

        clsCombineFunction.SetRCommand("c")

        clsCombineMultipleColumnsFunction.SetRCommand("c")
        clsCombineMultipleColumnsFunction.SetAssignTo("multiple_receiver_cols")

        clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)

        clsEmptyOperator.SetOperation("")
        clsEmptyOperator.AddParameter("multiple_receiver_cols", "multiple_receiver_cols", iPosition:=0)
        clsEmptyOperator.SetAssignTo("names(list_of_tables)")

        clsFootnoteCellBodyFunction.SetPackageName("gt")
        clsFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsFootnoteCellFunction.SetPackageName("gt")
        clsFootnoteCellFunction.SetRCommand("tab_footnote")

        clsFootnoteSubtitleLocationFunction.SetPackageName("gt")
        clsFootnoteSubtitleLocationFunction.SetRCommand("cells_title")

        clsFootnoteTitleLocationFunction.SetPackageName("gt")
        clsFootnoteTitleLocationFunction.SetRCommand("cells_title")

        clsFormatTableMapFunction.SetPackageName("purrr")
        clsFormatTableMapFunction.SetRCommand("map")
        clsFormatTableMapFunction.AddParameter(".x", "list_of_tables", iPosition:=0)
        clsFormatTableMapFunction.AddParameter(".f", clsROperatorParameter:=clsJoiningPipeOperator, iPosition:=1)

        clsFormatTableMappingPipeOperator.SetOperation("%>%")
        clsFormatTableMappingPipeOperator.AddParameter("map", clsRFunctionParameter:=clsFormatTableMapFunction, iPosition:=1)
        clsFormatTableMappingPipeOperator.SetAssignTo("list_of_tables")

        clsFormatTableTildeOperator.SetOperation("~")
        clsFormatTableTildeOperator.AddParameter("empty_parameter", "", iPosition:=0)
        clsFormatTableTildeOperator.AddParameter(".x", ".x", iPosition:=1)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsGroupByPipeOperator.SetOperation("%>%")
        clsGroupByPipeOperator.AddParameter("skim", clsRFunctionParameter:=clsSkimrFunction,
                                            iPosition:=2, bIncludeArgumentName:=False)
        clsGroupByPipeOperator.AddParameter("data",
                                            clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsHeaderFormatFunction.SetPackageName("mmtable2")
        clsHeaderFormatFunction.SetRCommand("header_format")
        clsHeaderFormatFunction.AddParameter("header", Chr(34) & "all_cols" & Chr(34), iPosition:=0)
        clsHeaderFormatFunction.AddParameter("style", clsRFunctionParameter:=clsStyleListFunction, iPosition:=1)

        clsHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopFunction.SetRCommand("header_left_top")

        clsHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftFunction.SetRCommand("header_top_left")

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("mutable", clsROperatorParameter:=clsFormatTableTildeOperator, iPosition:=0)
        clsJoiningPipeOperator.bBrackets = False

        clsMapPipeOperator.SetOperation("%>%")
        clsMapPipeOperator.AddParameter("map_summary_table", clsRFunctionParameter:=clsSummaryMapFunction, iPosition:=1)
        clsMapPipeOperator.AddParameter("map_mmtable", clsRFunctionParameter:=clsMmtableMapFunction, iPosition:=2)
        clsMapPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsMapPipeOperator.SetAssignTo("list_of_tables ")

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", ".x", iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsMmtableMapFunction.SetPackageName("purrr")
        clsMmtableMapFunction.SetRCommand("map")
        clsMmtableMapFunction.AddParameter(".x", ".", iPosition:=0)
        clsMmtableMapFunction.AddParameter(".f", clsROperatorParameter:=clsMmtablePlusOperator, iPosition:=1)

        clsMmtablePlusOperator.SetOperation("+")
        clsMmtablePlusOperator.bBrackets = False
        clsMmtablePlusOperator.AddParameter("mmtable2", clsROperatorParameter:=clsMmtableTildeOperator, iPosition:=0)
        clsMmtablePlusOperator.AddParameter("header_top_left", clsRFunctionParameter:=clsHeaderTopLeftFunction, iPosition:=1)
        clsMmtablePlusOperator.AddParameter("header_left_top", clsRFunctionParameter:=clsHeaderLeftTopFunction, iPosition:=2)

        clsMmtableTildeOperator.SetOperation("~")
        clsMmtableTildeOperator.AddParameter("empty_parameter", "", iPosition:=0)
        clsMmtableTildeOperator.AddParameter("mmtable", clsRFunctionParameter:=clsMmtableFunction, iPosition:=1)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.bBrackets = False

        clsRAnovaFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        clsRAnovaFunction.AddParameter("signif.stars", "FALSE", iPosition:=2)
        clsRAnovaFunction.AddParameter("sign_level", "FALSE", iPosition:=3)
        clsRAnovaFunction.AddParameter("means", "FALSE", iPosition:=4)

        clsRCorrelationFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$cor")

        clsRCustomSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        clsRCustomSummaryFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction)
        clsRCustomSummaryFunction.AddParameter("store_results", "FALSE", iPosition:=4)
        clsRCustomSummaryFunction.AddParameter("drop", "TRUE", iPosition:=5)
        clsRCustomSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=6)
        clsRCustomSummaryFunction.AddParameter("return_output", "TRUE", iPosition:=7)

        clsRenameFunction.SetPackageName("dplyr")
        clsRenameFunction.SetRCommand("rename")
        clsRenameFunction.AddParameter(".data", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=0)
        clsRenameFunction.AddParameter("by_var", ".x", iPosition:=1)

        clsSecondEmptyOperator.SetOperation("")
        clsSecondEmptyOperator.iCallType = 2
        clsSecondEmptyOperator.AddParameter("list_of_tables", "list_of_tables", iPosition:=0)

        clsSecondFootnoteCellBodyFunction.SetPackageName("gt")
        clsSecondFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsSecondFootnoteCellFunction.SetPackageName("gt")
        clsSecondFootnoteCellFunction.SetRCommand("tab_footnote")

        clsSecondHeaderFunction.SetPackageName("mmtable2")
        clsSecondHeaderFunction.SetRCommand("header_left_top")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")

        clsStubHeadFunction.SetPackageName("gt")
        clsStubHeadFunction.SetRCommand("tab_stubhead")

        clsStyleListFunction.SetRCommand("list")

        clsSummariesListFunction.SetRCommand("c")
        clsSummariesListFunction.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34),
                                              bIncludeArgumentName:=False, iPosition:=0)

        clsSummaryMapFunction.SetPackageName("purrr")
        clsSummaryMapFunction.SetRCommand("map")
        clsSummaryMapFunction.AddParameter(".x", clsRFunctionParameter:=clsCombineMultipleColumnsFunction, iPosition:=0)
        clsSummaryMapFunction.AddParameter(".f", clsROperatorParameter:=clsSummaryTildeOperator, iPosition:=1)

        clsSummaryTableCombineFactorsFunction.SetRCommand("c")

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryTableFunction.AddParameter("factors", clsRFunctionParameter:=clsSummaryTableCombineFactorsFunction, iPosition:=2)

        clsSummaryTildeOperator.SetOperation("~")
        clsSummaryTildeOperator.AddParameter("empty_parameter", "", iPosition:=0)

        clsTableSourcenoteFunction.SetPackageName("gt")
        clsTableSourcenoteFunction.SetRCommand("tab_source_note")

        clsTableTitleFunction.SetPackageName("gt")
        clsTableTitleFunction.SetRCommand("tab_header")

        clsTabFootnoteOperator.SetOperation("%>%")
        clsTabFootnoteOperator.bBrackets = False

        clsTabFootnoteTitleFunction.SetPackageName("gt")
        clsTabFootnoteTitleFunction.SetRCommand("tab_footnote")

        clsTabFootnoteSubtitleFunction.SetPackageName("gt")
        clsTabFootnoteSubtitleFunction.SetRCommand("tab_footnote")

        clsTabOptionsFunction.SetPackageName("gt")
        clsTabOptionsFunction.SetRCommand("tab_options")

        clsTabStyleCellTextFunction.SetPackageName("gt")
        clsTabStyleCellTextFunction.SetRCommand("cell_text")
        clsTabStyleCellTextFunction.AddParameter("size", clsRFunctionParameter:=clsTabStylePxFunction, iPosition:=0)

        clsTabStyleCellTitleFunction.SetPackageName("gt")
        clsTabStyleCellTitleFunction.SetRCommand("cells_title")
        clsTabStyleCellTitleFunction.AddParameter("groups", Chr(34) & "title" & Chr(34), iPosition:=0)

        clsTabStyleFunction.SetRCommand("tab_style")
        clsTabStyleFunction.SetPackageName("gt")
        clsTabStyleFunction.AddParameter("style", clsRFunctionParameter:=clsTabStyleCellTextFunction, iPosition:=0)
        clsTabStyleFunction.AddParameter("location", clsRFunctionParameter:=clsTabStyleCellTitleFunction, iPosition:=1)

        clsTabStylePxFunction.SetPackageName("gt")
        clsTabStylePxFunction.SetRCommand("px")
        clsTabStylePxFunction.AddParameter("size", "18", bIncludeArgumentName:=False, iPosition:=0)

        clsThreeVariableCombineFrequencyParametersFunction.SetRCommand("c")

        ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRAnovaFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=2)

        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRAnovaFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=2)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsSkimrFunction, New RParameter("col_names", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnovaFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRCustomSummaryFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=2)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsSummaryTableFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=3)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsFormatTableMappingPipeOperator, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=4)


        ucrChkDisplayMargins.AddAdditionalCodeParameterPair(clsThreeVariableCombineFrequencyParametersFunction, ucrChkDisplayMargins.GetParameter, iAdditionalPairNo:=1)

        ucrNudSigFigs.AddAdditionalCodeParameterPair(clsThreeVariableCombineFrequencyParametersFunction, ucrNudSigFigs.GetParameter, iAdditionalPairNo:=1)

        ucrChkOmitMissing.SetRCode(clsRCustomSummaryFunction, bReset)
        ucrReceiverFirstVars.SetRCode(clsRCustomSummaryFunction, bReset)
        ucrReceiverSecondTwoVariableFactor.SetRCode(clsRCustomSummaryFunction, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCorrelationFunction, bReset)
        ucrReceiverSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverSecondSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrReceiverPercentages.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrChkPercentageProportion.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrChkThreeVariableDisplayAsPercentage.SetRCode(clsThreeVariableCombineFrequencyParametersFunction, bReset)
        ucrReceiverThreeVariablePercentage.SetRCode(clsThreeVariableCombineFrequencyParametersFunction, bReset)
        ucrChkThreeVariablePercentageProportion.SetRCode(clsThreeVariableCombineFrequencyParametersFunction, bReset)
        ucrPnlDescribe.SetRCode(clsDummyFunction, bReset)
        ucrNudSigFigs.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        bRcodeSet = True
    End Sub

    Public Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverFirstVars.IsEmpty AndAlso (
                (rdoTwoVariable.Checked _
                AndAlso Not ucrReceiverSecondTwoVariableFactor.IsEmpty) _
                OrElse rdoSkim.Checked _
                OrElse (Not ucrReceiverThreeVariableSecondFactor.IsEmpty _
                AndAlso Not ucrReceiverThreeVariableThirdVariable.IsEmpty) _
                AndAlso (IsCategoricalByCategorical() OrElse IsNumericByCategorical() _
                OrElse IsCategoricalByNumeric())))
    End Sub

    Private Function IsCategoricalByCategorical() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical"
    End Function

    Private Function IsCategoricalByNumeric() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric"
    End Function

    Private Function IsNumericByCategorical() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical"
    End Function

    Private Function IsNumericByNumeric() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric"
    End Function

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        If rdoTwoVariable.Checked Then
            If IsNumericByCategorical() Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clsSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If IsCategoricalByNumeric() OrElse IsNumericByCategorical() Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clsSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
        End If
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs)
        sdgDescribeDisplay.SetRFunction(clsSummaryTableFunction, clsRAnovaFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgDescribeDisplay.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub ManageControlsVisibility()
        grpSummaries.Visible = rdoThreeVariable.Checked OrElse rdoTwoVariable.Checked

        If rdoTwoVariable.Checked Then
            ucrChkOmitMissing.Visible = strFirstVariablesType = "numeric"
            grpOptions.Visible = IsNumericByCategorical()
        ElseIf rdoThreeVariable.Checked Then
            grpOptions.Visible = IsCategoricalByNumeric() OrElse IsNumericByCategorical()
        Else
            grpOptions.Visible = False
        End If
    End Sub

    Private Sub ChangeBaseRCode()
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsEmptyOperator)
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSecondEmptyOperator)
        AddFormatTableMapToAfterCode()

        If rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        ElseIf rdoTwoVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "customize", iPosition:=0)
            If IsNumericByNumeric() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelationFunction)
            ElseIf IsCategoricalByNumeric() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRAnovaFunction)
            ElseIf IsNumericByCategorical() OrElse IsCategoricalByCategorical() Then
                If IsNumericByCategorical() Then
                    ucrReceiverFirstVars.SetParameterIsString()
                    clsSummaryTildeOperator.AddParameter("_function", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=1)
                Else
                    clsSummaryTildeOperator.AddParameter("_function", clsRFunctionParameter:=clsRenameFunction, iPosition:=1)
                End If
                ucrBase.clsRsyntax.SetBaseROperator(clsMapPipeOperator)
                ucrBase.clsRsyntax.AddToAfterCodes(clsEmptyOperator, 1)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSecondEmptyOperator, 3)
            End If
        ElseIf rdoThreeVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "three_variable", iPosition:=0)
            If IsCategoricalByNumeric() OrElse IsCategoricalByCategorical() Then
                clsSummaryTildeOperator.AddParameter("_function", clsRFunctionParameter:=clsRenameFunction, iPosition:=1)
            ElseIf IsNumericByCategorical() Then
                clsSummaryTildeOperator.AddParameter("_function", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=1)
            End If
            ucrBase.clsRsyntax.SetBaseROperator(clsMapPipeOperator)
            ucrBase.clsRsyntax.AddToAfterCodes(clsEmptyOperator, 1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsSecondEmptyOperator, 3)
        End If
    End Sub

    Private Sub AddFormatTableMapToAfterCode()
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsFormatTableMappingPipeOperator)
        If rdoSkim.Checked OrElse IsNothing(clsJoiningPipeOperator.GetParameter("pipe")) Then
            Exit Sub
        End If

        If IsNumericByCategorical() OrElse IsCategoricalByCategorical() _
                OrElse (IsCategoricalByNumeric() AndAlso rdoThreeVariable.Checked) Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsFormatTableMappingPipeOperator, 2)
        End If
    End Sub

    Private Sub UpdateCombineFactorFunctions()
        If rdoSkim.Checked OrElse ucrReceiverFirstVars.IsEmpty Then
            Exit Sub
        End If

        Dim iPosition As Integer = 0
        clsCombineMultipleColumnsFunction.ClearParameters()
        For Each strColumn In ucrReceiverFirstVars.GetVariableNamesList()
            clsCombineMultipleColumnsFunction.AddParameter(strColumn, strColumn, bIncludeArgumentName:=False, iPosition:=iPosition)
            iPosition += 1
        Next
    End Sub

    Private Sub UpdateCombineFactorParameterFunction()
        clsSummaryTableCombineFactorsFunction.RemoveParameterByName("factor_one")
        clsSummaryTableCombineFactorsFunction.RemoveParameterByName("factor_two")
        clsSummaryTableCombineFactorsFunction.RemoveParameterByName("factor_three")
        If rdoTwoVariable.Checked Then
            clsSummaryTableCombineFactorsFunction.AddParameter("factor_one",
                                                ucrReceiverSecondTwoVariableFactor.GetVariableNames(), iPosition:=0,
                                                bIncludeArgumentName:=False)
            If strFirstVariablesType = "categorical" Then
                clsSummaryTableCombineFactorsFunction.AddParameter("factor_two",
                                                            ".x", iPosition:=1,
                                                            bIncludeArgumentName:=False)
            End If
        ElseIf rdoThreeVariable.Checked Then
            clsSummaryTableCombineFactorsFunction.AddParameter("factor_one",
                                             ucrReceiverThreeVariableSecondFactor.GetVariableNames(), iPosition:=0,
                                             bIncludeArgumentName:=False)
            If strSecondVariableType = "categorical" Then
                clsSummaryTableCombineFactorsFunction.AddParameter("factor_two",
                                                            ucrReceiverThreeVariableThirdVariable.GetVariableNames(), iPosition:=1,
                                                            bIncludeArgumentName:=False)
            End If
            If IsCategoricalByCategorical() Then
                clsSummaryTableCombineFactorsFunction.AddParameter("factor_three",
                                                            ".x", iPosition:=2,
                                                            bIncludeArgumentName:=False)
            End If
            If IsCategoricalByNumeric() Then
                clsSummaryTableCombineFactorsFunction.AddParameter("factor_two",
                                                           ".x", iPosition:=1,
                                                           bIncludeArgumentName:=False)
            End If
        End If
    End Sub

    Private Sub AddRemoveNAParameter()
        clsSummaryTableFunction.RemoveParameterByName("na.rm")
        If ucrChkOmitMissing.Checked Then
            If rdoTwoVariable.Checked Then
                If IsNumericByCategorical() Then
                    clsSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
                End If
            ElseIf rdoThreeVariable.Checked Then
                If IsNumericByCategorical() OrElse IsCategoricalByNumeric() Then
                    clsSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
                End If
            End If
        End If
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If ucrChkOmitMissing.Checked Then
            clsRCorrelationFunction.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34), iPosition:=2)
        Else
            clsRCorrelationFunction.RemoveParameterByName("use")
        End If
        AddRemoveNAParameter()
    End Sub

    Private Sub ucrPnlDescribe_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDescribe.ControlValueChanged
        ucrReceiverFirstVars.Clear()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
        If rdoSkim.Checked Then
            ucrReceiverFirstVars.SetSingleTypeStatus(False)
        ElseIf rdoThreeVariable.Checked Then
            lblThreeVariableCategorical.Visible = True
            lblThreeVariableCategorical.Location = New Point(106, 16)
            lblSecondType.Location = New Point(12, 33)
            lblSecondBy.Visible = True
        Else
            lblThreeVariableCategorical.Visible = False
            lblThreeVariableCategorical.Location = New Point(12, 33)
            lblSecondType.Location = New Point(106, 18)
            lblSecondBy.Visible = False
        End If
        ChangeFirstTypeLabel()
        AssignSecondVariableType()
        ChangeBaseRCode()
        ManageControlsVisibility()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        AddRemoveNAParameter()
        HideFormatTableButton()
    End Sub

    Private Sub HideFormatTableButton()
        cmdFormatTable.Visible = IsNumericByCategorical() _
            OrElse IsCategoricalByCategorical() OrElse (IsCategoricalByNumeric() _
            AndAlso rdoThreeVariable.Checked)
    End Sub

    Private Sub ChangeLocations()
        If rdoSkim.Checked Then
            ucrBase.Location = New Point(iUcrBaseXLocation, 328)
            Me.Size = New Point(iDialogueXsize, 425)
        Else

            If IsNumericByCategorical() OrElse IsCategoricalByCategorical() _
                OrElse (IsCategoricalByNumeric() AndAlso rdoThreeVariable.Checked) Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 435)
                Me.Size = New Point(iDialogueXsize, 530)
            ElseIf IsCategoricalByNumeric() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                Me.Size = New Point(iDialogueXsize, 425)
            End If
        End If
    End Sub

    Private Sub ucrReceiverSecondOpt_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSkimrGroupByFactor.ControlValueChanged
        If ucrReceiverSkimrGroupByFactor.IsEmpty Then
            clsGroupByPipeOperator.RemoveParameterByName("group")
        Else
            clsGroupByPipeOperator.AddParameter("group", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub EnableDisableFrequencyControls()
        grpThreeVariablePercentages.Visible = rdoThreeVariable.Checked _
            AndAlso IsCategoricalByCategorical()
        grpTwoVariablePercentages.Visible = rdoTwoVariable.Checked AndAlso (IsCategoricalByCategorical() _
            OrElse IsNumericByCategorical())
        grpFrequency.Visible = (rdoTwoVariable.Checked AndAlso (IsCategoricalByCategorical() _
            OrElse IsNumericByCategorical())) OrElse (rdoThreeVariable.Checked _
            AndAlso (IsNumericByCategorical() OrElse IsCategoricalByNumeric() _
            OrElse IsCategoricalByCategorical()))
        ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked
    End Sub

    Private Sub SwapMmtableHeaderFunctions()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        Dim ucrReceiverSecondFactor As ucrReceiverSingle = If(rdoTwoVariable.Checked,
            ucrReceiverSecondTwoVariableFactor, ucrReceiverThreeVariableSecondFactor)
        Dim strFactor As String = ucrReceiverSecondFactor.GetVariableNames
        Dim strLeftTop As String = ""
        Dim strTopLeft As String = ""
        Dim strSecondHeader As String = ""

        clsMmtablePlusOperator.RemoveParameterByName("second_header_function")

        If rdoTwoVariable.Checked Then
            If IsNumericByCategorical() Then
                If ucrNudColumnFactors.GetText = 1 Then
                    strLeftTop = Chr(39) & "summary-variable" & Chr(39)
                    strTopLeft = strFactor
                Else
                    strTopLeft = Chr(39) & "summary-variable" & Chr(39)
                    strLeftTop = strFactor
                End If
            ElseIf IsCategoricalByCategorical() Then
                If ucrNudColumnFactors.GetText = 1 Then
                    strTopLeft = Chr(39) & "by_var" & Chr(39)
                    strLeftTop = strFactor
                ElseIf ucrNudColumnFactors.GetText = 2 Then
                    strLeftTop = Chr(39) & "by_var" & Chr(39)
                    strTopLeft = strFactor
                End If
            End If
        Else
            If IsCategoricalByCategorical() Then
                If ucrNudColumnFactors.GetText = 1 Then
                    clsSecondHeaderFunction.strRCommand = "header_left_top"
                    strLeftTop = Chr(39) & "by_var" & Chr(39)
                    strTopLeft = strFactor
                ElseIf ucrNudColumnFactors.GetText = 2 Then
                    strLeftTop = strFactor
                    strTopLeft = Chr(39) & "by_var" & Chr(39)
                    clsSecondHeaderFunction.strRCommand = "header_top_left"
                End If
                strSecondHeader = ucrReceiverThreeVariableThirdVariable.GetVariableNames()
            ElseIf IsNumericByCategorical() Then
                If ucrNudColumnFactors.GetText = 1 Then
                    clsSecondHeaderFunction.strRCommand = "header_top_left"
                    strLeftTop = ucrReceiverThreeVariableThirdVariable.GetVariableNames()
                    strTopLeft = strFactor
                ElseIf ucrNudColumnFactors.GetText = 2 Then
                    clsSecondHeaderFunction.strRCommand = "header_left_top"
                    strTopLeft = ucrReceiverThreeVariableThirdVariable.GetVariableNames()
                    strLeftTop = strFactor
                End If
                strSecondHeader = Chr(34) & "summary-variable" & Chr(34)
            ElseIf IsCategoricalByNumeric() Then
                If ucrNudColumnFactors.GetText = 1 Then
                    clsSecondHeaderFunction.strRCommand = "header_top_left"
                    strTopLeft = Chr(39) & "by_var" & Chr(39)
                    strLeftTop = strFactor

                ElseIf ucrNudColumnFactors.GetText = 2 Then
                    clsSecondHeaderFunction.strRCommand = "header_left_top"
                    strLeftTop = Chr(39) & "by_var" & Chr(39)
                    strTopLeft = strFactor
                End If
                strSecondHeader = Chr(34) & "summary-variable" & Chr(34)
            End If
        End If
        clsHeaderTopLeftFunction.AddParameter("variable", strLeftTop, iPosition:=0)
        clsHeaderLeftTopFunction.AddParameter("variable", strTopLeft, iPosition:=0)

        If strSecondHeader <> "" Then
            clsSecondHeaderFunction.AddParameter("variable", strSecondHeader, iPosition:=0)
            clsMmtablePlusOperator.AddParameter("second_header_function",
                                                clsRFunctionParameter:=clsSecondHeaderFunction, iPosition:=3)
        End If
    End Sub

    Private Sub AddRemoveFrequencyParameters()
        If rdoSkim.Checked Then
            Exit Sub
        End If

        For Each strParameter In lstFrequencyParameters
            clsSummaryTableFunction.RemoveParameterByName(strParameter)
        Next

        Dim clsTempFrequency As RFunction = If(rdoThreeVariable.Checked,
        clsThreeVariableCombineFrequencyParametersFunction,
        clsCombineFrequencyParametersFunction).Clone

        For Each clsParameter In clsTempFrequency.clsParameters
            If IsCategoricalByCategorical() Then
                clsSummaryTableFunction.AddParameter(clsParameter)
            Else
                If IsNumericByCategorical() OrElse IsCategoricalByNumeric() Then
                    Select Case clsParameter.strArgumentName
                        Case "signif_fig", "include_margins", "margin_name"
                            clsSummaryTableFunction.AddParameter(clsParameter)
                    End Select
                End If
            End If
        Next
    End Sub

    Private Sub Frequencies_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPercentageProportion.ControlValueChanged,
        ucrChkDisplayAsPercentage.ControlValueChanged, ucrNudSigFigs.ControlValueChanged, ucrChkDisplayMargins.ControlValueChanged,
        ucrReceiverPercentages.ControlValueChanged, ucrInputMarginName.ControlValueChanged, ucrChkThreeVariablePercentageProportion.ControlValueChanged, ucrChkThreeVariableDisplayAsPercentage.ControlValueChanged
        If rdoTwoVariable.Checked Then
            If ucrChkDisplayAsPercentage.Checked Then
                ucrReceiverPercentages.SetMeAsReceiver()
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
        ElseIf rdoThreeVariable.Checked Then
            If ucrChkThreeVariableDisplayAsPercentage.Checked Then
                ucrReceiverThreeVariablePercentage.SetMeAsReceiver()
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
        End If
        If ucrChkDisplayMargins.Checked Then
            ucrInputMarginName.Visible = True
            clsCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
            clsThreeVariableCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
        Else
            ucrInputMarginName.Visible = False
            clsCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
            clsThreeVariableCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
        End If
        AddRemoveFrequencyParameters()
    End Sub

    Private Sub ucrNudColumnFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudColumnFactors.ControlValueChanged
        SwapMmtableHeaderFunctions()
    End Sub

    Private Sub ucrSelectorDescribeTwoVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDescribeTwoVar.ControlValueChanged
        clsGroupByPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsMapPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub UpdateSummaryTableFunction()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        clsSummaryTableFunction.RemoveParameterByName("columns_to_summarise")
        If rdoTwoVariable.Checked Then
            If IsCategoricalByCategorical() Then
                clsSummaryTableFunction.AddParameter("summaries", "count_label", iPosition:=1)
            ElseIf IsNumericByCategorical() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=1)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ".x", iPosition:=3)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If IsCategoricalByNumeric() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=1)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverThreeVariableThirdVariable.GetVariableNames(), iPosition:=3)
            ElseIf IsCategoricalByCategorical() Then
                clsSummaryTableFunction.AddParameter("summaries", "count_label", iPosition:=1)
            ElseIf IsNumericByCategorical() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=1)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ".x", iPosition:=3)
            End If
        End If
    End Sub

    Private Sub ucrReceiverNumericVariable_ControlValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableThirdVariable.ControlValueChanged,
               ucrReceiverThreeVariableThirdVariable.ControlContentsChanged
        AssignSecondVariableType()
        ManageControlsVisibility()
        UpdateCombineFactorParameterFunction()
        ChangeBaseRCode()
        ChangeLocations()
        EnableDisableFrequencyControls()
        UpdateSummaryTableFunction()
        SwapMmtableHeaderFunctions()
        AddRemoveFrequencyParameters()
        EnableDisableFrequencyControls()
        AddRemoveNAParameter()
        HideFormatTableButton()
        TestOKEnabled()
    End Sub

    Private Sub ChangeSumaryLabelText()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        Dim strSummaryName As String = ""

        If IsCategoricalByCategorical() Then
            strSummaryName = "Frequency tables"
        ElseIf IsNumericByCategorical() Then
            strSummaryName = "Summary tables"
        Else
            If rdoTwoVariable.Checked Then
                If IsNumericByNumeric() Then
                    strSummaryName = "Correlations"
                ElseIf IsCategoricalByNumeric() Then
                    strSummaryName = "ANOVA tables"
                Else
                    strSummaryName = ""
                End If
            ElseIf rdoThreeVariable.Checked Then
                If IsCategoricalByNumeric() Then
                    strSummaryName = "Summary tables"
                Else
                    strSummaryName = ""
                End If
            End If
        End If

        If strSummaryName <> "" Then
            lblSummaryName.Text = strSummaryName
            lblSummaryName.ForeColor = SystemColors.Highlight
        Else
            lblSummaryName.Text = "__________"
            lblSummaryName.ForeColor = SystemColors.ControlText
        End If
        autoTranslate(Me)
    End Sub

    Private Sub AssignSecondVariableType()
        If rdoTwoVariable.Checked OrElse rdoThreeVariable.Checked Then
            Dim ucrCurrentReceiver As ucrReceiverSingle = If(rdoTwoVariable.Checked,
                ucrReceiverSecondTwoVariableFactor, ucrReceiverThreeVariableThirdVariable)
            If Not ucrCurrentReceiver.IsEmpty Then
                strSecondVariableType = If({"factor", "character", "logical"}.Contains(ucrCurrentReceiver.strCurrDataType),
                                  "categorical", "numeric")
                lblSecondType.Text = strSecondVariableType
                lblSecondType.ForeColor = SystemColors.Highlight

            Else
                strSecondVariableType = ""
                lblSecondType.Text = "________"
                lblSecondType.ForeColor = SystemColors.ControlText
            End If
            ChangeSumaryLabelText()
        End If
        ManageControlsVisibility()
    End Sub

    Private Sub ucrReceiverSecondTwoVariableFactor_ValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondTwoVariableFactor.ControlValueChanged,
            ucrReceiverSecondTwoVariableFactor.ControlContentsChanged
        AssignSecondVariableType()
        ChangeBaseRCode()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        AddRemoveNAParameter()
        HideFormatTableButton()
        TestOKEnabled()
    End Sub

    Private Sub ChangeFirstTypeLabel()
        Dim lstFirstItemTypes As List(Of String)
        If Not ucrReceiverFirstVars.IsEmpty() Then
            lstFirstItemTypes = ucrReceiverFirstVars.GetCurrentItemTypes(True, bIsCategoricalNumeric:=True)
            If lstFirstItemTypes.Count = 1 AndAlso lstFirstItemTypes.Contains("logical") Then
                lstFirstItemTypes(0) = "categorical"
            Else
                lstFirstItemTypes.RemoveAll(Function(x) x.Contains("logical"))
            End If
            If (lstFirstItemTypes.Count > 0) Then
                strFirstVariablesType = lstFirstItemTypes(0)
            Else
                strFirstVariablesType = ""
            End If
        Else
            strFirstVariablesType = ""
        End If

        If strFirstVariablesType <> "" Then
            lblFirstType.Text = strFirstVariablesType
            lblFirstType.ForeColor = SystemColors.Highlight
        Else
            lblFirstType.Text = "________"
            lblFirstType.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub ucrReceiverFirstVars_ControlValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlValueChanged,
            ucrReceiverFirstVars.ControlContentsChanged
        ChangeFirstTypeLabel()
        ChangeSumaryLabelText()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeBaseRCode()
        ManageControlsVisibility()
        UpdateCombineFactorFunctions()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        AddRemoveFrequencyParameters()
        AddRemoveNAParameter()
        HideFormatTableButton()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverThreeVariableSecondFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableSecondFactor.ControlValueChanged
        UpdateCombineFactorParameterFunction()
        SwapMmtableHeaderFunctions()
    End Sub

    Private Sub controls_contentChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayAsPercentage.ControlContentsChanged,
        ucrReceiverPercentages.ControlContentsChanged,
        ucrChkThreeVariableDisplayAsPercentage.ControlContentsChanged, ucrReceiverThreeVariableSecondFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverSecondTwoVariableFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSecondTwoVariableFactor.SelectionChanged
        MatchingCategoricalByCategoricalVariables(ucrReceiverSecondTwoVariableFactor)
    End Sub

    Private Sub ucrReceiverFirstVars_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFirstVars.SelectionChanged
        MatchingCategoricalByCategoricalVariables(ucrReceiverFirstVars)
    End Sub

    Private Sub ucrReceiverThreeVariableSecondFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverThreeVariableSecondFactor.SelectionChanged
        MatchingCategoricalByCategoricalVariables(ucrReceiverThreeVariableSecondFactor)
    End Sub

    Private Sub ucrReceiverThreeVariableThirdVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverThreeVariableThirdVariable.SelectionChanged
        MatchingCategoricalByCategoricalVariables(ucrReceiverThreeVariableThirdVariable)
    End Sub

    Private Sub MatchingCategoricalByCategoricalVariables(sender As ucrReceiver)
        If Not bRcodeSet OrElse rdoSkim.Checked OrElse sender.IsEmpty Then
            Exit Sub
        End If
        Dim bContainedInMultipleReceiver As Boolean = False

        If TypeOf (sender) Is ucrReceiverSingle Then
            bContainedInMultipleReceiver = ucrReceiverFirstVars.GetVariableNamesList.Contains(
                                                TryCast(sender, ucrReceiverSingle).GetVariableNames)
        ElseIf TypeOf (sender) Is ucrReceiverMultiple Then
            Dim lstMultipleVariables As String() = TryCast(sender, ucrReceiverMultiple).GetVariableNamesList()
            If rdoTwoVariable.Checked Then
                bContainedInMultipleReceiver = lstMultipleVariables.Contains(ucrReceiverSecondTwoVariableFactor.GetVariableNames)
            Else
                bContainedInMultipleReceiver = lstMultipleVariables.Contains(ucrReceiverThreeVariableSecondFactor.GetVariableNames) OrElse (
                    lstMultipleVariables.Contains(ucrReceiverThreeVariableThirdVariable.GetVariableNames) AndAlso strSecondVariableType = "categorical")
            End If
        End If


        If sender Is ucrReceiverSecondTwoVariableFactor Then
            If bContainedInMultipleReceiver And strFirstVariablesType = "categorical" Then
                DisplayWarning(" First Variable ")
            End If
        ElseIf sender Is ucrReceiverThreeVariableThirdVariable Then
            If (bContainedInMultipleReceiver And strFirstVariablesType = "categorical") OrElse
               (ucrReceiverThreeVariableThirdVariable.GetVariableNames = ucrReceiverThreeVariableSecondFactor.GetVariableNames) Then
                DisplayWarning(" First Variable and Second Variable ")
            End If
        ElseIf sender Is ucrReceiverThreeVariableSecondFactor Then
            If (strFirstVariablesType = "categorical" AndAlso bContainedInMultipleReceiver) OrElse
                              (ucrReceiverThreeVariableThirdVariable.GetVariableNames = ucrReceiverThreeVariableSecondFactor.GetVariableNames) Then
                DisplayWarning(" First Variable and Third Variable ")
            End If
        ElseIf sender Is ucrReceiverFirstVars Then
            If rdoTwoVariable.Checked Then
                If strSecondVariableType = "categorical" AndAlso bContainedInMultipleReceiver Then
                    DisplayWarning(" Second Variable ")
                End If
            ElseIf rdoThreeVariable.Checked Then
                If bContainedInMultipleReceiver Then
                    DisplayWarning(" Second Variable and Third Variable ")
                End If
            End If
        End If
    End Sub

    Private Sub DisplayWarning(strMessage As String)
        MsgBox("Pick a categorical variable different from those selected in the" & strMessage & "to avoid Errors", vbOKOnly, "Matching Factor Variables")
    End Sub

    Private Sub cmdFormatTable_Click(sender As Object, e As EventArgs) Handles cmdFormatTable.Click
        sdgFormatSummaryTables.SetRCode(clsNewTableTitleFunction:=clsTableTitleFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                        clsNewCellTextFunction:=clsCellTextFunction, clsNewCellBorderFunction:=clsCellBorderFunction, clsNewCellFillFunction:=clsCellFillFunction, clsNewHeaderFormatFunction:=clsHeaderFormatFunction,
                                        clsNewTabOptionsFunction:=clsTabOptionsFunction, clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewStubHeadFunction:=clsStubHeadFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                       clsNewPipeOperator:=clsPipeOperator, clsNewBorderWeightPxFunction:=clsBorderWeightPxFunction, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                       clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                       clsNewStyleListFunction:=clsStyleListFunction, clsNewMutableOPerator:=clsMmtablePlusOperator, clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction, clsNewTabFootnoteOperator:=clsTabFootnoteOperator,
                                       clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, bReset:=bReset)
        sdgFormatSummaryTables.ShowDialog()
        AddFormatTableMapToAfterCode()
    End Sub
End Class
