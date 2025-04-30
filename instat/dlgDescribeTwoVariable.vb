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
    Public enumTwovariableMode As String = TwovariableMode.Describe
    Public Enum TwovariableMode
        Describe
        Climatic
    End Enum

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bRcodeSet As Boolean = True
    Private bResetSubdialog As Boolean = False
    Public strFirstVariablesType, strSecondVariableType, strThirdVariableType As String

    'SUMMARY FUNCTIoNS
    Private clsCombineFrequencyParametersFunction, clsCombineFrequencyColParametersFunction, clsCombineFunction, clsCombineSwapAnova2Table, clsCombineAnova2Function, clsSummariseFunction,
       clsDummyFunction, clsGroupByFunction, clsRAnovaFunction, clsCorrFunction, clsRAnovaTableFunction,
        clsRCorrelationFunction, clsSkimrFunction, clsSummariesListFunction, clsCombineAnovaFunction,
        clsSummaryTableCombineFactorsFunction, clsSummaryTableFunction, clsRAnovaSwapTable2Funtion,
        clsThreeVariableCombineFrequencyParametersFunction, clsPivotWiderFunction, clsMappingFunction, clsMapping2Function, clsRAnovaTable2Function As New RFunction

    'FORMAT TABLE FUNCTIONS
    Private clsFootnoteCellBodyFunction, clsFootnoteCellFunction,
        clsFootnoteSubtitleLocationFunction, clsFootnoteTitleLocationFunction, clsSecondFootnoteCellBodyFunction,
        clsSecondFootnoteCellFunction, clsStyleListFunction,
        clsTabFootnoteSubtitleFunction, clsTabFootnoteTitleFunction,
        clsTableSourcenoteFunction, clsTableTitleFunction, clsThemesTabOptionFunction,
        clsTabStyleCellTextFunction, clsTabStyleCellTitleFunction, clsTabStyleFunction,
        clsTabStylePxFunction, clsgtExtrasThemesFuction, clsCrossDfFunction, clsListFunction As New RFunction


    Private clsGroupByPipeOperator, clsSummaryOperator, clsGroupByPipeOperator2, clsGroupByPipeOperator3, clsGroupByPipeOperator4, clsGroupByPipeOperatorData As New ROperator

    Private clsTildOperator, clsMapOperator, clsGtTableROperator, clsPivotOperator As New ROperator


    Private clsgtFunction, clsMapSummaryFunction, clsMap2SummaryFunction, clsMapGtFunction As New RFunction
    'Frequency Parameters
    Private lstFrequencyParameters As New List(Of String)({"percentage_type", "margin_name",
                                                          "perc_total_factors", "perc_decimal",
                                                          "signif_fig", "include_margins"})

    'Format Operators
    Private clsPipeOperator, clsFactorOperator, clsSummariesOperator, clsTabFootnoteOperator,
            clsJoiningPipeOperator, clsMutableOperator, clsAnovaSwapTable2Opeator, clsAnovaTable2Operator, clsYlist2Operator, clsYlistOperator As New ROperator
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
        SetHelpOptions()
        bReset = False
        TestOKEnabled()
        ManageControlsVisibility()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 414
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

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

        ucrReceiverPercentages.SetParameter(New RParameter("perc_total_factors", 2))
        ucrReceiverPercentages.SetParameterIsString()
        ucrReceiverPercentages.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverPercentages.SetDataType("factor")

        ucrReceiverColumns.SetParameter(New RParameter("perc_total_factors", 3))
        ucrReceiverColumns.SetParameterIsString()
        ucrReceiverColumns.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverColumns.SetDataType("factor")

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 1))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverPercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrpnlPercent, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkCorrelations.SetText("Correlations")
        ucrChkCorrelations.AddParameterValuesCondition(True, "corr", "True")
        ucrChkCorrelations.AddParameterValuesCondition(False, "corr", "False")

        ucrChkMeans.SetText("Means/Model")
        ucrChkMeans.SetParameter(New RParameter("means", 5))
        ucrChkMeans.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMeans.SetRDefault("FALSE")

        ucrChkLevSig.SetText("Sig.Level")
        ucrChkLevSig.SetParameter(New RParameter("sign_level", 4))
        ucrChkLevSig.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkLevSig.SetRDefault("FALSE")

        ucrChkTotal.SetText("Total")
        ucrChkTotal.SetParameter(New RParameter("total", 6))
        ucrChkTotal.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTotal.SetRDefault("FALSE")

        ucrChkInteraction.SetText("Interaction")
        ucrChkInteraction.SetParameter(New RParameter("interaction", 5))
        ucrChkInteraction.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInteraction.SetRDefault("FALSE")

        ucrChkSwapXYVar.SetText("Swap First/Second Variables")
        ucrChkSwapXYVar.AddParameterValuesCondition(True, "var", "True")
        ucrChkSwapXYVar.AddParameterValuesCondition(False, "var", "False")
        ' This controls the visibility of the display margins check box
        ucrChkSwapXYVar.AddToLinkedControls({ucrChkDisplayMargins}, {False}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlDescribe.AddRadioButton(rdoTwoVariable)
        ucrPnlDescribe.AddRadioButton(rdoSkim)
        ucrPnlDescribe.AddRadioButton(rdoThreeVariable)
        ucrPnlDescribe.AddParameterValuesCondition(rdoTwoVariable, "checked", "customize")
        ucrPnlDescribe.AddParameterValuesCondition(rdoSkim, "checked", "skim")
        ucrPnlDescribe.AddParameterValuesCondition(rdoThreeVariable, "checked", "three_variable")

        ucrpnlPercent.AddRadioButton(rdoOCol)
        ucrpnlPercent.AddRadioButton(rdoORow)
        ucrpnlPercent.AddRadioButton(rdoOCell)
        ucrpnlPercent.AddParameterValuesCondition(rdoOCol, "percent", "col")
        ucrpnlPercent.AddParameterValuesCondition(rdoORow, "percent", "row")
        ucrpnlPercent.AddParameterValuesCondition(rdoOCell, "percent", "cell")

        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSkimrGroupByFactor, ucrReceiverSecondSkimrGroupByFactor}, {rdoSkim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableThirdVariable}, {rdoThreeVariable}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSecondTwoVariableFactor}, {rdoTwoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableSecondFactor}, {rdoThreeVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrpnlPercent.AddToLinkedControls({ucrReceiverPercentages}, {rdoORow}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrpnlPercent.AddToLinkedControls({ucrReceiverColumns}, {rdoOCol}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverThreeVariableSecondFactor.SetParameter(New RParameter("second_three_varible_factor", 0, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariableSecondFactor.SetParameterIsString()
        ucrReceiverThreeVariableSecondFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverThreeVariableSecondFactor.SetLinkedDisplayControl(lblThreeVariableSecondFactor)

        ucrSaveTable.SetDataFrameSelector(ucrSelectorDescribeTwoVar.ucrAvailableDataFrames)
        ucrSaveTable.SetIsTextBox()
        ucrReorderSummary.bDataIsSummaries = True
        AddRemoveTotalParm()
        AddInteraction()
        ManageControlsVisibility()
    End Sub

    Private Sub SetDefaults()
        clsCombineFrequencyParametersFunction = New RFunction
        clsCombineFrequencyColParametersFunction = New RFunction
        clsCombineFunction = New RFunction
        clsDummyFunction = New RFunction
        clsFootnoteCellBodyFunction = New RFunction
        clsFootnoteCellFunction = New RFunction
        clsFootnoteSubtitleLocationFunction = New RFunction
        clsFootnoteTitleLocationFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsRAnovaFunction = New RFunction
        clsRCorrelationFunction = New RFunction
        clsSecondFootnoteCellBodyFunction = New RFunction
        clsSecondFootnoteCellFunction = New RFunction
        clsSkimrFunction = New RFunction
        clsStyleListFunction = New RFunction
        clsSummariesListFunction = New RFunction
        clsSummaryTableCombineFactorsFunction = New RFunction
        clsSummaryTableFunction = New RFunction
        clsTabFootnoteSubtitleFunction = New RFunction
        clsTabFootnoteTitleFunction = New RFunction
        clsTableSourcenoteFunction = New RFunction
        clsTableTitleFunction = New RFunction
        clsThemesTabOptionFunction = New RFunction
        clsTabStyleCellTextFunction = New RFunction
        clsTabStyleCellTitleFunction = New RFunction
        clsTabStyleFunction = New RFunction
        clsTabStylePxFunction = New RFunction
        clsThreeVariableCombineFrequencyParametersFunction = New RFunction
        clsGroupByPipeOperator = New ROperator
        clsJoiningPipeOperator = New ROperator
        clsPipeOperator = New ROperator
        clsTabFootnoteOperator = New ROperator
        clsgtFunction = New RFunction
        clsSummaryOperator = New ROperator
        clsMapOperator = New ROperator
        clsPivotWiderFunction = New RFunction
        clsCombineAnovaFunction = New RFunction
        clsCombineAnova2Function = New RFunction
        clsCombineSwapAnova2Table = New RFunction
        clsSummariseFunction = New RFunction
        clsCorrFunction = New RFunction
        clsRAnovaTableFunction = New RFunction
        clsgtExtrasThemesFuction = New RFunction
        clsMutableOperator = New ROperator

        clsGroupByPipeOperator2 = New ROperator
        clsGroupByPipeOperator3 = New ROperator
        clsGroupByPipeOperator4 = New ROperator
        clsGroupByPipeOperatorData = New ROperator
        clsMappingFunction = New RFunction
        clsMapping2Function = New RFunction
        clsAnovaTable2Operator = New ROperator
        clsAnovaSwapTable2Opeator = New ROperator
        clsYlistOperator = New ROperator
        clsYlist2Operator = New ROperator
        clsRAnovaTable2Function = New RFunction
        clsRAnovaSwapTable2Funtion = New RFunction
        clsCrossDfFunction = New RFunction
        clsListFunction = New RFunction
        clsMap2SummaryFunction = New RFunction

        clsTildOperator = New ROperator
        clsMapSummaryFunction = New RFunction
        clsMapGtFunction = New RFunction
        clsPivotOperator = New ROperator
        clsFactorOperator = New ROperator
        clsSummariesOperator = New ROperator
        clsGtTableROperator = New ROperator

        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrInputMarginName.SetText("All")
        ucrInputMarginName.Visible = False
        ucrSaveTable.Reset()

        clsCombineFrequencyParametersFunction.SetRCommand("c")
        clsCombineFrequencyColParametersFunction.SetRCommand("c")

        clsCombineFunction.SetRCommand("c")

        clsSummariesOperator.SetOperation("", bBracketsTemp:=False)
        clsSummariesOperator.SetAssignTo("summaries")

        clsFactorOperator.SetOperation("", bBracketsTemp:=False)
        clsFactorOperator.SetAssignTo("factors")

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("factor", "factors", iPosition:=0)
        clsListFunction.AddParameter("summary", "summaries", iPosition:=1)

        clsCrossDfFunction.SetRCommand("cross_df")
        clsCrossDfFunction.AddParameter("list", clsRFunctionParameter:=clsListFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsCrossDfFunction.SetAssignTo("combinations")

        clsMap2SummaryFunction.SetPackageName("purrr")
        clsMap2SummaryFunction.SetRCommand("map2")
        clsMap2SummaryFunction.AddParameter(".x", "combinations$factor", iPosition:=0)
        clsMap2SummaryFunction.AddParameter(".y", "combinations$summary", iPosition:=1)

        clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
        clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
        clsDummyFunction.AddParameter("theme", "select", iPosition:=2)
        clsDummyFunction.AddParameter("row_sum", "False", iPosition:=3)
        clsDummyFunction.AddParameter("corr", "False", iPosition:=4)
        clsDummyFunction.AddParameter("var", "False", iPosition:=5)
        clsDummyFunction.AddParameter("percent", "col", iPosition:=6)

        clsPivotWiderFunction.SetPackageName("tidyr")
        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=2)

        clsFootnoteCellBodyFunction.SetPackageName("gt")
        clsFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsFootnoteCellFunction.SetPackageName("gt")
        clsFootnoteCellFunction.SetRCommand("tab_footnote")

        clsFootnoteSubtitleLocationFunction.SetPackageName("gt")
        clsFootnoteSubtitleLocationFunction.SetRCommand("cells_title")

        clsFootnoteTitleLocationFunction.SetPackageName("gt")
        clsFootnoteTitleLocationFunction.SetRCommand("cells_title")

        clsgtExtrasThemesFuction.SetPackageName("gtExtras")

        clsCombineAnova2Function.SetRCommand("c")

        clsCombineSwapAnova2Table.SetRCommand("c")

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("walk")
        clsMappingFunction.AddParameter(".x", clsROperatorParameter:=clsYlistOperator, iPosition:=0)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsAnovaTable2Operator, iPosition:=1)

        clsMapping2Function.SetPackageName("purrr")
        clsMapping2Function.SetRCommand("walk")
        clsMapping2Function.AddParameter(".x", clsROperatorParameter:=clsYlist2Operator, iPosition:=0)
        clsMapping2Function.AddParameter(".f", clsROperatorParameter:=clsAnovaSwapTable2Opeator, iPosition:=1)

        clsAnovaTable2Operator.SetOperation("~")
        clsAnovaTable2Operator.AddParameter("right", clsRFunctionParameter:=clsRAnovaTable2Function, iPosition:=1)
        clsAnovaTable2Operator.bForceIncludeOperation = True

        clsAnovaSwapTable2Opeator.SetOperation("~")
        clsAnovaSwapTable2Opeator.AddParameter("right", clsRFunctionParameter:=clsRAnovaSwapTable2Funtion, iPosition:=1)
        clsAnovaSwapTable2Opeator.bForceIncludeOperation = True

        clsYlistOperator.SetOperation("", bBracketsTemp:=False)
        clsYlistOperator.SetAssignTo("y_col_names_list")

        clsYlist2Operator.SetOperation("", bBracketsTemp:=False)
        clsYlist2Operator.SetAssignTo("y_col_names_list")

        clsRAnovaTable2Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables2")
        clsRAnovaTable2Function.AddParameter("data", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsRAnovaTable2Function.AddParameter(" x_col_names", clsRFunctionParameter:=clsCombineAnova2Function, iPosition:=1)
        clsRAnovaTable2Function.AddParameter("y_col_name", ".x", iPosition:=2)
        clsRAnovaTable2Function.AddParameter("signif.stars", "FALSE", iPosition:=3)
        clsRAnovaTable2Function.AddParameter("sign_level", "FALSE", iPosition:=4)

        clsRAnovaSwapTable2Funtion.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables2")
        clsRAnovaSwapTable2Funtion.AddParameter("data", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsRAnovaSwapTable2Funtion.AddParameter(" y_col_name", clsRFunctionParameter:=clsCombineSwapAnova2Table, iPosition:=1)
        clsRAnovaSwapTable2Funtion.AddParameter("x_col_names", ".x", iPosition:=2)
        clsRAnovaSwapTable2Funtion.AddParameter("signif.stars", "FALSE", iPosition:=3)
        clsRAnovaSwapTable2Funtion.AddParameter("sign_level", "FALSE", iPosition:=4)

        clsGroupByPipeOperator.SetOperation("%>%")
        clsGroupByPipeOperator.AddParameter("skim", clsRFunctionParameter:=clsSkimrFunction,
                                            iPosition:=2, bIncludeArgumentName:=False)
        clsGroupByPipeOperator.AddParameter("data",
                                            clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsGroupByPipeOperator2.SetOperation("%>%", bBracketsTemp:=False)
        clsGroupByPipeOperator2.AddParameter("left", clsROperatorParameter:=clsGroupByPipeOperatorData, iPosition:=0)
        clsGroupByPipeOperator2.AddParameter("right", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)

        clsGroupByPipeOperator3.SetOperation("%>%", bBracketsTemp:=False)
        clsGroupByPipeOperator3.AddParameter("left", clsROperatorParameter:=clsGroupByPipeOperator2, iPosition:=0)
        clsGroupByPipeOperator3.AddParameter("right", clsRFunctionParameter:=clsSummariseFunction, iPosition:=1)

        clsGroupByPipeOperator4.SetOperation("%>%", bBracketsTemp:=False)
        clsGroupByPipeOperator4.AddParameter("left", clsROperatorParameter:=clsGroupByPipeOperator3, iPosition:=0)
        clsGroupByPipeOperator4.AddParameter("right", clsRFunctionParameter:=clsgtFunction, iPosition:=1)

        clsGroupByPipeOperatorData.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsGroupByPipeOperatorData.bBrackets = False

        clsSummariseFunction.SetRCommand("summarise")
        clsSummariseFunction.AddParameter("cor", clsRFunctionParameter:=clsCorrFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsCorrFunction.SetRCommand("cor")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")

        clsRAnovaTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        clsRAnovaTableFunction.AddParameter("x_col_names", clsRFunctionParameter:=clsCombineAnovaFunction, iPosition:=1)
        clsRAnovaTableFunction.AddParameter("y_col_name", clsRFunctionParameter:=clsCombineFunction, iPosition:=2)
        clsRAnovaTableFunction.AddParameter("signif.stars", "FALSE", iPosition:=3)
        clsRAnovaTableFunction.AddParameter("sign_level", "FALSE", iPosition:=4)
        clsRAnovaTableFunction.AddParameter("means", "FALSE", iPosition:=5)

        clsCombineFunction.SetRCommand("c")

        clsCombineAnovaFunction.SetRCommand("c")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.bBrackets = False

        clsRAnovaFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        clsRAnovaFunction.AddParameter("signif.stars", "FALSE", iPosition:=2)
        clsRAnovaFunction.AddParameter("sign_level", "FALSE", iPosition:=3)
        clsRAnovaFunction.AddParameter("means", "FALSE", iPosition:=4)

        clsRCorrelationFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$cor")

        clsSecondFootnoteCellBodyFunction.SetPackageName("gt")
        clsSecondFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsSecondFootnoteCellFunction.SetPackageName("gt")
        clsSecondFootnoteCellFunction.SetRCommand("tab_footnote")

        clsStyleListFunction.SetRCommand("list")

        clsSummariesListFunction.SetRCommand("c")
        clsSummariesListFunction.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34),
                                              bIncludeArgumentName:=False, iPosition:=0)

        clsSummaryTableCombineFactorsFunction.SetRCommand("c")

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryTableFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=3)

        clsTildOperator.SetOperation("~")
        clsTildOperator.AddParameter("right", clsRFunctionParameter:=clsSummaryTableFunction)
        clsTildOperator.bBrackets = False
        clsTildOperator.bForceIncludeOperation = True
        clsTildOperator.bSpaceAroundOperation = False

        clsMapSummaryFunction.SetPackageName("purrr")
        clsMapSummaryFunction.SetRCommand("map")

        clsMapGtFunction.SetPackageName("purrr")
        clsMapGtFunction.SetRCommand("map")
        clsMapGtFunction.AddParameter("gttbl", clsRFunctionParameter:=clsgtFunction, bIncludeArgumentName:=False)

        clsgtFunction.SetPackageName("gt")
        clsgtFunction.SetRCommand("gt")

        clsGtTableROperator.SetOperation("%>%")
        clsGtTableROperator.bBrackets = False
        clsGtTableROperator.AddParameter(strParameterName:="gt_tbl", clsRFunctionParameter:=clsgtFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsPivotOperator.SetOperation("%>%")
        clsPivotOperator.AddParameter("left", clsRFunctionParameter:=clsPivotWiderFunction)
        clsPivotOperator.AddParameter("right", clsRFunctionParameter:=clsgtFunction)
        clsPivotOperator.AddParameter("right", clsROperatorParameter:=clsGtTableROperator)
        clsPivotOperator.bBrackets = False

        clsMapOperator.SetOperation("%>%")
        clsMapOperator.AddParameter("left", clsROperatorParameter:=clsTildOperator)
        clsMapOperator.AddParameter("right", clsROperatorParameter:=clsPivotOperator)
        clsMapOperator.bBrackets = False

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("gtable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
        clsJoiningPipeOperator.bBrackets = False

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

        clsThemesTabOptionFunction.SetPackageName("gt")
        clsThemesTabOptionFunction.SetRCommand("tab_options")

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

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        ThreeVarSummariesVar()
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsSkimrFunction, New RParameter("col_names", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsMapSummaryFunction, New RParameter(".x", 1), iAdditionalPairNo:=3)
        ucrChkMeans.AddAdditionalCodeParameterPair(clsRAnovaSwapTable2Funtion, New RParameter("means", iNewPosition:=5), iAdditionalPairNo:=1)
        ucrChkLevSig.AddAdditionalCodeParameterPair(clsRAnovaSwapTable2Funtion, New RParameter("sign_level", iNewPosition:=4), iAdditionalPairNo:=1)
        ucrChkDisplayMargins.AddAdditionalCodeParameterPair(clsCombineFrequencyColParametersFunction, New RParameter("include_margins", iNewPosition:=5), iAdditionalPairNo:=1)
        ucrChkDisplayAsPercentage.AddAdditionalCodeParameterPair(clsCombineFrequencyColParametersFunction, New RParameter("percentage_type", iNewPosition:=1), iAdditionalPairNo:=1)
        ucrChkDisplayMargins.AddAdditionalCodeParameterPair(clsThreeVariableCombineFrequencyParametersFunction, New RParameter("include_margins", iNewPosition:=5), iAdditionalPairNo:=2)
        ucrChkInteraction.AddAdditionalCodeParameterPair(clsRAnovaSwapTable2Funtion, New RParameter("interaction", iNewPosition:=7), iAdditionalPairNo:=1)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsSummaryTableFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSaveTable.AddAdditionalRCode(clsJoiningPipeOperator, iAdditionalPairNo:=1)
        ucrSaveTable.AddAdditionalRCode(clsGroupByPipeOperator4, iAdditionalPairNo:=2)

        ucrChkOmitMissing.SetRCode(clsSummaryTableFunction, bReset)
        ucrReceiverSecondTwoVariableFactor.SetRCode(clsDummyFunction, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCorrelationFunction, bReset)
        ucrReceiverSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverSecondSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrReceiverPercentages.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrReceiverColumns.SetRCode(clsCombineFrequencyColParametersFunction, bReset)
        ucrPnlDescribe.SetRCode(clsDummyFunction, bReset)
        ucrpnlPercent.SetRCode(clsDummyFunction, bReset)
        ucrChkCorrelations.SetRCode(clsDummyFunction, bReset)
        ucrChkSwapXYVar.SetRCode(clsDummyFunction, bReset)
        ucrChkMeans.SetRCode(clsRAnovaTable2Function, bReset)
        ucrChkLevSig.SetRCode(clsRAnovaTable2Function, bReset)
        ucrChkInteraction.SetRCode(clsRAnovaTable2Function, bReset)
        ucrReceiverThreeVariableSecondFactor.SetRCode(clsSummaryTableCombineFactorsFunction, bReset)
        ucrReceiverThreeVariableThirdVariable.SetRCode(clsSummaryTableCombineFactorsFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrSaveTable.SetRCode(clsGroupByPipeOperator, bReset)
        If bReset Then
            ucrReceiverFirstVars.SetRCode(clsDummyFunction, bReset)
        End If
        bRcodeSet = True

        FillListView()
        AddRemoveTotalParm()
        AddInteraction()
        ChangeBaseRCode()
        ThreeVarSummariesVar()
    End Sub

    Public Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverFirstVars.IsEmpty AndAlso (
                (rdoTwoVariable.Checked _
                AndAlso Not ucrReceiverSecondTwoVariableFactor.IsEmpty) _
                OrElse rdoSkim.Checked _
                OrElse (Not ucrReceiverThreeVariableSecondFactor.IsEmpty _
                AndAlso Not ucrReceiverThreeVariableThirdVariable.IsEmpty) _
                AndAlso (IsFactorByFactor() OrElse IsNumericByFactor() _
                OrElse IsFactorByNumeric() OrElse IsNumericByNumericByFactor() OrElse IsNumericByFactorByFactor() OrElse IsNumericByNumericByNumeric() _
                OrElse IsFactorByNumericByNumeric() OrElse IsNumericByFactorByNumeric() OrElse IsFactorByFactorByFactor() OrElse IsNumericByNumeric())) AndAlso ucrSaveTable.IsComplete)
    End Sub

    Private Function IsFactorByFactor() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical"
    End Function

    Private Function IsFactorByNumeric() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric"
    End Function

    Private Function IsNumericByFactor() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical"
    End Function

    Private Function IsNumericByNumeric() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric"
    End Function

    Private Function IsNumericByNumericByFactor() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "categorical"
    End Function

    Private Function IsNumericByFactorByFactor() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "categorical"
    End Function

    Private Function IsFactorByFactorByFactor() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "categorical"
    End Function

    Private Function IsNumericByFactorByNumeric() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "numeric"
    End Function

    Private Function IsNumericByNumericByNumeric() As Boolean
        Return strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "numeric"
    End Function

    Private Function IsFactorByNumericByNumeric() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "numeric"
    End Function

    Private Function IsFactorByNumericByFactor() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" AndAlso strThirdVariableType = "categorical"
    End Function

    Private Function IsFactorByFactorByNumeric() As Boolean
        Return strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" AndAlso strThirdVariableType = "numeric"
    End Function

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        If rdoTwoVariable.Checked Then
            If IsFactorByNumeric() Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clsSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clsSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
        End If
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        FillListView()
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
        ucrChkDisplayMargins.Visible = (rdoTwoVariable.Checked AndAlso (IsFactorByFactor() OrElse IsFactorByNumeric())) OrElse
    (rdoThreeVariable.Checked AndAlso (IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() OrElse IsFactorByFactorByFactor()))

        ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked AndAlso
    (IsFactorByFactor() OrElse IsFactorByFactorByNumeric() OrElse
    IsFactorByNumericByFactor() OrElse IsFactorByFactorByFactor())

        grpDisplay.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor()
        ucrReceiverPercentages.Visible = rdoTwoVariable.Checked AndAlso ucrChkDisplayAsPercentage.Checked AndAlso rdoORow.Checked AndAlso IsFactorByFactor()
        ucrpnlPercent.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor() AndAlso ucrChkDisplayAsPercentage.Checked
        ucrReceiverColumns.Visible = ucrChkDisplayAsPercentage.Checked AndAlso IsFactorByFactor() AndAlso rdoOCol.Checked
        ucrChkCorrelations.Visible = False
        ucrChkSwapXYVar.Visible = False
        ucrChkOmitMissing.Visible = False
        cmdMissingOptions.Visible = False

        If rdoTwoVariable.Checked Then
            ucrChkOmitMissing.Visible = False
            ucrChkOmitMissing.Visible = Not ucrChkSwapXYVar.Checked AndAlso IsFactorByNumeric()
            ucrChkSwapXYVar.Visible = IsNumericByNumeric() OrElse IsFactorByNumeric()
            ucrChkCorrelations.Visible = IsNumericByNumeric()
            cmdMissingOptions.Visible = ucrChkOmitMissing.Checked AndAlso ucrChkOmitMissing.Visible
        End If
        If rdoThreeVariable.Checked Then
            If IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
                ucrReorderSummary.Visible = True
                cmdSummaries.Visible = True
            Else
                ucrReorderSummary.Visible = False
                cmdSummaries.Visible = False
            End If
            ucrChkOmitMissing.Visible = IsFactorByNumericByFactor() OrElse IsFactorByFactorByNumeric()
            cmdMissingOptions.Visible = ucrChkOmitMissing.Checked
        End If
    End Sub

    Private Sub ChangeBaseRCode()
        ucrSaveTable.Visible = False
        ucrReorderSummary.Visible = False
        cmdSummaries.Visible = False
        cmdFormatTable.Visible = False
        ucrChkMeans.Visible = False
        ucrChkLevSig.Visible = False
        ucrChkTotal.Visible = False
        ucrChkInteraction.Visible = False
        cmdMissingOptions.Visible = False
        ucrChkOmitMissing.Visible = False
        If rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
            cmdFormatTable.Visible = False
            ucrSaveTable.Visible = True
            ucrSaveTable.Location = New Point(23, 286)
            ucrSaveTable.SetPrefix("summary_table")
            ucrSaveTable.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveTable.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveTable.SetCheckBoxText("Store Summary")
            ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
            clsGroupByPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                   strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                   strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                     strObjectName:="last_summary")

        ElseIf rdoTwoVariable.Checked Then
            ucrChkOmitMissing.Visible = False
            clsDummyFunction.AddParameter("checked", "customize", iPosition:=0)
            If IsNumericByNumeric() Then
                If ucrChkSwapXYVar.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMapping2Function)
                    clsDummyFunction.AddParameter("var", "True", iPosition:=5)
                Else
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
                    clsDummyFunction.AddParameter("var", "False", iPosition:=5)
                End If
                If ucrChkCorrelations.Checked Then
                    ucrBase.clsRsyntax.AddToAfterCodes(clsRCorrelationFunction, iPosition:=0)
                    clsDummyFunction.AddParameter("corr", "True", iPosition:=4)
                    clsRCorrelationFunction.iCallType = 2
                Else
                    clsDummyFunction.AddParameter("corr", "False", iPosition:=4)
                    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRCorrelationFunction)
                End If
                ucrSaveTable.Visible = False
                cmdFormatTable.Visible = False
                ucrChkInteraction.Visible = False
                ucrChkMeans.Visible = True
                ucrChkLevSig.Visible = True
                ucrChkTotal.Visible = True
                ucrChkTotal.Location = New Point(310, 189)
                ucrChkLevSig.Location = New Point(397, 186)
                ucrChkMeans.Location = New Point(310, 210)

            ElseIf IsNumericByFactor() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
                ucrChkInteraction.Visible = False
                ucrChkMeans.Visible = True
                ucrChkLevSig.Visible = True
                ucrChkTotal.Visible = True
                ucrSaveTable.Visible = True
                ucrSaveTable.Location = New Point(23, 450)
                ucrChkTotal.Location = New Point(310, 189)
                ucrChkMeans.Location = New Point(310, 210)
                ucrChkLevSig.Location = New Point(397, 186)
                clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
                ucrSaveTable.SetPrefix("summary_table")
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Save Table")

            ElseIf IsFactorByFactor() Then
                ucrSaveTable.Visible = True
                cmdFormatTable.Visible = True
                ucrChkMeans.Visible = False
                ucrChkLevSig.Visible = False
                ucrChkTotal.Visible = False
                ucrChkInteraction.Visible = False
                ucrSaveTable.Location = New Point(23, 370)
                clsDummyFunction.AddParameter("factor_cols", "FactorVar", iPosition:=1)
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                ucrSaveTable.SetPrefix("frequency_table")
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Save Table")
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                  strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                  strObjectName:="last_table")
            ElseIf IsFactorByNumeric() Then
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRCorrelationFunction)

                If ucrChkSwapXYVar.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMapping2Function)
                    clsDummyFunction.AddParameter("var", "True", iPosition:=5)
                    ucrReorderSummary.Visible = False
                    cmdSummaries.Visible = False
                    cmdFormatTable.Visible = False
                    ucrChkInteraction.Visible = False
                    ucrChkOmitMissing.Visible = False
                    cmdMissingOptions.Visible = False
                    ucrChkMeans.Visible = True
                    ucrChkLevSig.Visible = True
                    ucrChkTotal.Visible = True
                    ucrChkTotal.Location = New Point(310, 189)
                    ucrChkLevSig.Location = New Point(397, 186)
                    ucrChkMeans.Location = New Point(310, 210)
                Else
                    clsDummyFunction.AddParameter("var", "False", iPosition:=5)
                    ucrSaveTable.Visible = True
                    ucrReorderSummary.Visible = True
                    cmdSummaries.Visible = True
                    cmdFormatTable.Visible = True
                    ucrChkOmitMissing.Visible = True
                    ucrChkMeans.Visible = False
                    ucrChkLevSig.Visible = False
                    ucrChkTotal.Visible = False
                    ucrChkInteraction.Visible = False
                    ucrSaveTable.Location = New Point(23, 450)
                    ucrChkOmitMissing.Location = New Point(15, 365)
                    cmdMissingOptions.Location = New Point(17, 385)
                    clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
                    ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                    ucrSaveTable.SetPrefix("summary_table")
                    ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                    ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                    ucrSaveTable.SetCheckBoxText("Save Table")
                    clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                         strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                         strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                         strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                         strObjectName:="last_table")
                End If

            End If
        ElseIf rdoThreeVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "three_variable", iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSummariesOperator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsFactorOperator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsCrossDfFunction)
            If IsFactorByFactorByFactor() Then
                cmdFormatTable.Visible = True
                ucrSaveTable.Location = New Point(23, 341)
                ucrSaveTable.Visible = True
                ucrSaveTable.SetPrefix("frequency_table")
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Store Table")
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                    strObjectName:="last_table")
            ElseIf IsFactorByNumericByNumeric() Then
                cmdFormatTable.Visible = True
                ucrSaveTable.Visible = True
                ucrSaveTable.Location = New Point(23, 300)
                ucrSaveTable.SetPrefix("cor_table")
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Store Cor")
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                             strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                 strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                 strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                   strObjectName:="last_table")

            ElseIf IsNumericByNumericByFactor() Then
                cmdFormatTable.Visible = False
                ucrSaveTable.Visible = False
                ucrChkMeans.Visible = True
                ucrChkLevSig.Visible = True
                ucrChkTotal.Visible = True
                ucrChkInteraction.Visible = True
                ucrChkTotal.Location = New Point(310, 250)
                ucrChkLevSig.Location = New Point(397, 250)
                ucrChkInteraction.Location = New Point(310, 275)
                ucrChkMeans.Location = New Point(310, 300)
                If ucrChkSwapXYVar.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMapping2Function)
                    clsDummyFunction.AddParameter("var", "True", iPosition:=5)
                Else
                    clsDummyFunction.AddParameter("var", "False", iPosition:=5)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
                End If
            ElseIf IsNumericByNumericByNumeric() Then
                cmdFormatTable.Visible = False
                ucrSaveTable.Visible = False
                ucrChkMeans.Visible = True
                ucrChkLevSig.Visible = True
                ucrChkTotal.Visible = True
                ucrChkInteraction.Visible = True
                ucrChkTotal.Location = New Point(310, 250)
                ucrChkLevSig.Location = New Point(397, 250)
                ucrChkInteraction.Location = New Point(310, 275)
                ucrChkMeans.Location = New Point(310, 300)
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            ElseIf IsNumericByFactorByFactor() Then
                cmdFormatTable.Visible = False
                ucrSaveTable.Visible = False
                ucrChkMeans.Visible = True
                ucrChkLevSig.Visible = True
                ucrChkTotal.Visible = True
                ucrChkInteraction.Visible = True
                ucrChkTotal.Location = New Point(310, 250)
                ucrChkLevSig.Location = New Point(397, 250)
                ucrChkInteraction.Location = New Point(310, 275)
                ucrChkMeans.Location = New Point(310, 300)
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            ElseIf IsNumericByFactorByNumeric() Then
                cmdFormatTable.Visible = False
                ucrSaveTable.Visible = False
                ucrChkMeans.Visible = True
                ucrChkLevSig.Visible = True
                ucrChkTotal.Visible = True
                ucrChkInteraction.Visible = True
                ucrChkTotal.Location = New Point(310, 250)
                ucrChkLevSig.Location = New Point(397, 250)
                ucrChkInteraction.Location = New Point(310, 275)
                ucrChkMeans.Location = New Point(310, 300)
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            ElseIf IsFactorByNumericByFactor() OrElse IsFactorByFactorByNumeric() Then
                ucrSaveTable.SetPrefix("summary_table")
                cmdFormatTable.Visible = True
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Save Table")
                ucrBase.clsRsyntax.AddToBeforeCodes(clsSummariesOperator, 0)
                ucrBase.clsRsyntax.AddToBeforeCodes(clsFactorOperator, 1)
                ucrBase.clsRsyntax.AddToBeforeCodes(clsCrossDfFunction, 2)
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                    strObjectName:="last_table")
                ucrReorderSummary.Visible = True
                cmdSummaries.Visible = True
                ucrSaveTable.Visible = True
                ucrChkOmitMissing.Visible = True
                ucrSaveTable.Location = New Point(23, 440)
                ucrChkOmitMissing.Location = New Point(15, 360)
                cmdMissingOptions.Location = New Point(17, 380)
            End If
        End If
        FactorColumns()
        AddInteraction()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdCorrParam()
        ThreeVarSummariesVar()
    End Sub

    Private Sub UpdateCombineFactorParameterFunction()
        If rdoThreeVariable.Checked Then
            clsSummaryTableFunction.AddParameter("factors", clsRFunctionParameter:=clsSummaryTableCombineFactorsFunction, iPosition:=2)
        End If
    End Sub

    Private Sub AddRemoveNAParameter()
        clsSummaryTableFunction.RemoveParameterByName("na.rm")
        If ucrChkOmitMissing.Checked Then
            If rdoTwoVariable.Checked Then
                If Not ucrChkSwapXYVar.Checked AndAlso IsFactorByNumeric() Then
                    clsSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
                End If
            ElseIf rdoThreeVariable.Checked Then
                If IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
                    clsSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
                End If
            End If
        End If
        ChangeLocations()
        TestOKEnabled()
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged, ucrChkCorrelations.ControlValueChanged
        If ucrChkOmitMissing.Checked AndAlso ucrChkCorrelations.Checked Then
            clsRCorrelationFunction.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34), iPosition:=2)
        Else
            clsRCorrelationFunction.RemoveParameterByName("use")
        End If
        AddRemoveNAParameter()
        If Not ucrChkOmitMissing.Checked Then
            clsSummaryTableFunction.RemoveParameterByName("na_type")
            clsSummaryTableFunction.RemoveParameterByName("na_max_n")
            clsSummaryTableFunction.RemoveParameterByName("na_min_n")
            clsSummaryTableFunction.RemoveParameterByName("na_max_prop")
            clsSummaryTableFunction.RemoveParameterByName("na_consecutive_n")
        Else
            clsSummaryTableFunction.AddParameter("na_type", clsRFunctionParameter:=clsCombineFunction, iPosition:=9)
        End If
        cmdMissingOptions.Visible = ucrChkOmitMissing.Checked
        ManageControlsVisibility()
        ChangeBaseRCode()
    End Sub

    Private Sub ucrPnlDescribe_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDescribe.ControlValueChanged
        'ucrReceiverFirstVars.Clear()
        'ucrReceiverThreeVariableSecondFactor.Clear()
        'ucrReceiverThreeVariableThirdVariable.Clear()
        'ucrReceiverSecondTwoVariableFactor.Clear()
        ucrReceiverFirstVars.SetMeAsReceiver()

        If rdoSkim.Checked Then
            ucrReceiverFirstVars.SetSingleTypeStatus(False)
        ElseIf rdoThreeVariable.Checked Then
            ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
            lblThreeVariableCategorical.Visible = True
            lblThreeVariableCategorical.Location = New Point(38, 33)
            lblSecondType.Location = New Point(106, 18)
            lblSecondBy.Visible = True
        Else
            ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
            lblThreeVariableCategorical.Visible = False
            lblThreeVariableCategorical.Location = New Point(12, 33)
            lblSecondType.Location = New Point(106, 18)
            lblSecondBy.Visible = False
        End If

        ChangeFirstTypeLabel()
        AssignSecondVariableType()
        AssignThirdVariableType()
        ChangeBaseRCode()
        ManageControlsVisibility()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        AddRemoveNAParameter()
        FactorColumns()
        AddRemoveFirstCorrParam()
        AddRemoveSecondCorrParam()
        AddRemoveThirdCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdAnovaParam()
        AddRemoveFirstAnova2Param()
        ThreeVarSummariesVar()
    End Sub

    Private Sub ChangeLocations()
        If rdoTwoVariable.Checked Then
            If IsFactorByNumeric() Then
                If ucrChkSwapXYVar.Checked Then
                    ucrBase.Location = New Point(iUcrBaseXLocation, 400)
                    Me.Size = New Point(iDialogueXsize, 500)
                Else
                    ucrBase.Location = New Point(iUcrBaseXLocation, 487)
                    Me.Size = New Point(iDialogueXsize, 580)
                    cmdFormatTable.Location = New Point(330, 450)
                End If
            ElseIf IsNumericByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 319)
                Me.Size = New Point(iDialogueXsize, 415)
            ElseIf IsFactorByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 395)
                Me.Size = New Point(iDialogueXsize, 485)
                cmdFormatTable.Location = New Point(330, 370)
            Else
                ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                Me.Size = New Point(iDialogueXsize, 425)
            End If
        ElseIf rdoThreeVariable.Checked Then

            If IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 353)
                Me.Size = New Point(iDialogueXsize, 450)
            ElseIf IsFactorByFactorByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 370)
                Me.Size = New Point(iDialogueXsize, 465)
                cmdFormatTable.Visible = True
                cmdFormatTable.Location = New Point(330, 340)
            ElseIf IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 470)
                Me.Size = New Point(iDialogueXsize, 570)
                cmdFormatTable.Location = New Point(330, 440)
            Else
                ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                Me.Size = New Point(iDialogueXsize, 425)
                cmdFormatTable.Location = New Point(330, 300)
            End If
        Else
            ucrBase.Location = New Point(iUcrBaseXLocation, 333)
            Me.Size = New Point(iDialogueXsize, 430)
        End If
    End Sub

    Private Sub ucrReceiverSecondOpt_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSkimrGroupByFactor.ControlValueChanged
        If ucrReceiverSkimrGroupByFactor.IsEmpty Then
            clsGroupByPipeOperator.RemoveParameterByName("group")
        Else
            clsGroupByPipeOperator.AddParameter("group", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub AddRemoveFirstCorrParam()
        If rdoThreeVariable.Checked Then
            If IsFactorByNumericByNumeric() Then
                If ucrReceiverFirstVars.IsEmpty Then
                    clsGroupByFunction.RemoveParameterByName("var")
                Else
                    Dim lstControlVars As List(Of String) = ucrReceiverFirstVars.GetVariableNamesAsList()
                    Dim strControlVar As String = String.Join(",", lstControlVars)

                    clsGroupByFunction.AddParameter("var", strControlVar, iPosition:=1, bIncludeArgumentName:=False)

                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveSecondCorrParam()
        If rdoThreeVariable.Checked Then
            If IsFactorByNumericByNumeric() Then
                If ucrReceiverThreeVariableSecondFactor.IsEmpty Then
                    clsCorrFunction.RemoveParameterByName("x")
                Else
                    clsCorrFunction.AddParameter("x", ucrReceiverThreeVariableSecondFactor.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveThirdCorrParam()
        If rdoThreeVariable.Checked Then
            If IsFactorByNumericByNumeric() Then
                If ucrReceiverThreeVariableThirdVariable.IsEmpty Then
                    clsSummaryTableFunction.RemoveParameterByName("y")
                Else
                    clsSummaryTableFunction.AddParameter("y", ucrReceiverThreeVariableThirdVariable.GetVariableNames)
                End If
            Else
                clsSummaryTableFunction.RemoveParameterByName("y")
            End If
        End If
    End Sub

    Private Sub FactorColumns()
        If rdoTwoVariable.Checked Then
            If IsFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("factors", "c(" & ucrReceiverSecondTwoVariableFactor.GetVariableNames & "," & ".x" & ")")
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ".x")
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverSecondTwoVariableFactor.GetVariableNames(bWithQuotes:=False), iPosition:=1)
            ElseIf IsFactorByNumeric() Then
                clsSummaryTableFunction.AddParameter("factors", ".x")
                clsPivotWiderFunction.AddParameter("names_from", "{{ .x }}", iPosition:=1)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverSecondTwoVariableFactor.GetVariableNames)
                clsMapSummaryFunction.AddParameter(".x", ucrReceiverFirstVars.GetVariableNames, iPosition:=3)
            Else
                clsSummaryTableFunction.AddParameter("factors", ucrReceiverSecondTwoVariableFactor.GetVariableNames)
                clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=1)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverFirstVars.GetVariableNames)
            End If
        End If
        If rdoThreeVariable.Checked Then
            If IsFactorByFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("factors", "c(" & ucrReceiverThreeVariableSecondFactor.GetVariableNames & "," & ucrReceiverThreeVariableThirdVariable.GetVariableNames & "," & ".x" & ")")
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ".x")
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverThreeVariableThirdVariable.GetVariableNames(False), iPosition:=0)
                clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            ElseIf IsFactorByFactorByNumeric() Then
                clsSummaryTableFunction.AddParameter("factors", "c(" & ".x" & "," & ucrReceiverThreeVariableSecondFactor.GetVariableNames & ")")
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverThreeVariableThirdVariable.GetVariableNames)
                clsSummaryTableFunction.AddParameter("summaries", ".y", iPosition:=0)
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverThreeVariableSecondFactor.GetVariableNames(False), iPosition:=0)
                clsSummaryOperator.RemoveParameterByName("col_factor")
            ElseIf IsFactorByNumericByFactor() Then
                clsSummaryTableFunction.AddParameter("factors", "c(" & ".x" & "," & ucrReceiverThreeVariableThirdVariable.GetVariableNames & ")")
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverThreeVariableSecondFactor.GetVariableNames)
                clsSummaryTableFunction.AddParameter("summaries", ".y", iPosition:=0)
                clsSummaryOperator.RemoveParameterByName("col_factor")
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverThreeVariableThirdVariable.GetVariableNames(False), iPosition:=0)

            ElseIf IsFactorByNumericByNumeric() Then
                clsMapSummaryFunction.AddParameter(".x", ucrReceiverFirstVars.GetVariableNames)
                clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverThreeVariableSecondFactor.GetVariableNames)
                clsSummaryTableFunction.AddParameter("summaries", Chr(34) & "summary_cor" & Chr(34), iPosition:=0)
                clsSummaryTableFunction.AddParameter("factors", ".x")
                clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            Else
                clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverFirstVars.GetVariableNames)
                clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            End If
        End If
        ThreeVarSummariesVar()
    End Sub

    Private Sub ThreeVarSummariesVar()
        clsMap2SummaryFunction.RemoveParameterByName(".f")
        clsMapSummaryFunction.RemoveParameterByName(".f")
        clsSummaryOperator.RemoveParameterByName("right")
        clsSummaryOperator.RemoveParameterByName("tableFun")
        If rdoThreeVariable.Checked Then
            If IsFactorByNumericByFactor() OrElse IsFactorByFactorByNumeric() Then
                clsFactorOperator.AddParameter("factors", ucrReceiverFirstVars.GetVariableNames, iPosition:=0, bIncludeArgumentName:=False)
                clsSummariesOperator.AddParameter("summary", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsMap2SummaryFunction.AddParameter(".f", clsROperatorParameter:=clsMapOperator, iPosition:=2)
                clsSummaryOperator.AddParameter("right", clsRFunctionParameter:=clsMap2SummaryFunction, iPosition:=2)

            ElseIf IsFactorByNumericByNumeric() Then
                clsMapSummaryFunction.AddParameter(".f", clsROperatorParameter:=clsMapOperator, iPosition:=1)
                clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsMapSummaryFunction, iPosition:=2)

            ElseIf IsFactorByNumericByNumeric() Then
                clsMapSummaryFunction.AddParameter(".f", clsROperatorParameter:=clsMapOperator, iPosition:=1)
                clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsMapSummaryFunction, iPosition:=2)

            ElseIf IsFactorByFactorByFactor() Then
                clsMapSummaryFunction.AddParameter(".f", clsROperatorParameter:=clsMapOperator, iPosition:=1)
                clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsMapSummaryFunction, iPosition:=2)
            End If
        ElseIf rdoTwoVariable.Checked Then
            clsMapSummaryFunction.AddParameter(".f", clsROperatorParameter:=clsMapOperator, iPosition:=1)
            clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsMapSummaryFunction, iPosition:=2)
        End If
    End Sub

    Private Sub AddRemoveFirstAnova2Param()
        If rdoThreeVariable.Checked Then
            If Not ucrReceiverFirstVars.IsEmpty Then
                If IsNumericByNumericByFactor() Then
                    If ucrChkSwapXYVar.Checked Then
                        clsYlist2Operator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                        clsYlistOperator.RemoveParameterByName("cols")
                    Else
                        clsYlistOperator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                        clsYlist2Operator.RemoveParameterByName("cols")
                    End If
                ElseIf IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                    clsYlistOperator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                End If
            Else
                clsYlist2Operator.RemoveParameterByName("cols")
                clsYlistOperator.RemoveParameterByName("cols")
            End If
        ElseIf rdoTwoVariable.Checked Then
            If IsNumericByNumeric() Then
                If Not ucrReceiverFirstVars.IsEmpty Then
                    If ucrChkSwapXYVar.Checked Then
                        clsYlist2Operator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                        clsYlistOperator.RemoveParameterByName("cols")

                    Else
                        clsYlistOperator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                        clsYlist2Operator.RemoveParameterByName("cols")

                    End If
                Else
                    clsYlist2Operator.RemoveParameterByName("cols")
                    clsYlistOperator.RemoveParameterByName("cols")

                End If
            ElseIf IsNumericByFactor() Then
                If ucrReceiverFirstVars.IsEmpty Then
                    clsYlistOperator.RemoveParameterByName("cols")
                Else
                    clsYlistOperator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                End If
            ElseIf IsFactorByNumeric() Then
                If Not ucrReceiverFirstVars.IsEmpty Then
                    If ucrChkSwapXYVar.Checked Then
                        clsYlist2Operator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                        clsYlistOperator.RemoveParameterByName("cols")
                    Else
                        clsYlist2Operator.RemoveParameterByName("cols")
                        clsYlistOperator.RemoveParameterByName("cols")
                    End If
                Else
                    clsYlist2Operator.RemoveParameterByName("cols")
                    clsYlistOperator.RemoveParameterByName("cols")

                End If
            End If

        End If
    End Sub

    Private Sub AddRemoveSecondAnovaParam()
        clsCombineSwapAnova2Table.RemoveParameterByName("x")
        clsCombineAnova2Function.RemoveParameterByName("x")
        If rdoThreeVariable.Checked Then
            If Not ucrReceiverThreeVariableSecondFactor.IsEmpty Then
                If IsNumericByNumericByFactor() Then
                    If ucrChkSwapXYVar.Checked Then
                        clsCombineSwapAnova2Table.AddParameter("x", ".x", bIncludeArgumentName:=False)
                        clsRAnovaSwapTable2Funtion.AddParameter("x_col_names", "c(" & ucrReceiverThreeVariableSecondFactor.GetVariableNames & "," & ucrReceiverThreeVariableThirdVariable.GetVariableNames & ")", iPosition:=2)

                        clsCombineAnova2Function.RemoveParameterByName("x")
                    Else
                        clsCombineAnova2Function.AddParameter("x", ucrReceiverThreeVariableSecondFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
                        clsCombineSwapAnova2Table.RemoveParameterByName("x")
                        clsRAnovaSwapTable2Funtion.AddParameter("x_col_names", ".x", iPosition:=2)

                    End If
                ElseIf IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                    clsCombineAnova2Function.AddParameter("x", ucrReceiverThreeVariableSecondFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)

                Else
                    clsCombineAnova2Function.RemoveParameterByName("x")
                    clsCombineSwapAnova2Table.RemoveParameterByName("x")
                End If
            Else
                clsCombineAnova2Function.RemoveParameterByName("x")
                clsCombineSwapAnova2Table.RemoveParameterByName("x")
            End If
        ElseIf rdoTwoVariable.Checked Then
            If IsNumericByNumeric() Then
                If Not ucrReceiverSecondTwoVariableFactor.IsEmpty Then
                    If ucrChkSwapXYVar.Checked Then
                        clsCombineSwapAnova2Table.AddParameter("x", ucrReceiverSecondTwoVariableFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
                        clsCombineAnova2Function.RemoveParameterByName("x")
                    Else
                        clsCombineAnova2Function.AddParameter("x", ucrReceiverSecondTwoVariableFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
                        clsCombineSwapAnova2Table.RemoveParameterByName("x")

                    End If
                Else
                    clsCombineSwapAnova2Table.RemoveParameterByName("x")
                    clsCombineAnova2Function.RemoveParameterByName("x")

                End If
            ElseIf IsFactorByNumeric() Then
                If Not ucrReceiverSecondTwoVariableFactor.IsEmpty Then
                    If ucrChkSwapXYVar.Checked Then
                        clsCombineSwapAnova2Table.AddParameter("x", ucrReceiverSecondTwoVariableFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
                        clsCombineAnova2Function.RemoveParameterByName("x")
                    Else
                        clsCombineSwapAnova2Table.RemoveParameterByName("x")
                        clsCombineAnova2Function.RemoveParameterByName("x")
                    End If
                Else
                    clsCombineSwapAnova2Table.RemoveParameterByName("x")
                    clsCombineAnova2Function.RemoveParameterByName("x")

                End If
            ElseIf IsNumericByFactor() Then
                If ucrReceiverSecondTwoVariableFactor.IsEmpty Then
                    clsCombineAnova2Function.RemoveParameterByName("x")
                Else
                    clsCombineAnova2Function.AddParameter("x", ucrReceiverSecondTwoVariableFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
                End If
            Else
                clsCombineSwapAnova2Table.RemoveParameterByName("x")
                clsCombineAnova2Function.RemoveParameterByName("x")
            End If
        End If

    End Sub

    Private Sub AddRemoveThirdAnovaParam()
        If rdoThreeVariable.Checked Then
            If Not ucrReceiverThreeVariableThirdVariable.IsEmpty Then
                If IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                    clsCombineAnova2Function.AddParameter("y", ucrReceiverThreeVariableThirdVariable.GetVariableNames(True), iPosition:=2, bIncludeArgumentName:=False)
                Else
                    clsCombineAnova2Function.RemoveParameterByName("y")

                End If
            Else
                clsCombineAnova2Function.RemoveParameterByName("y")
            End If
        Else
            clsCombineAnova2Function.RemoveParameterByName("y")
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
        Dim clsTempColFrequency As RFunction = clsCombineFrequencyColParametersFunction.Clone
        If rdoTwoVariable.Checked Then
            If rdoORow.Checked OrElse rdoOCell.Checked Then
                For Each clsParameter In clsTempFrequency.clsParameters
                    If IsFactorByFactor() Then
                        clsSummaryTableFunction.AddParameter(clsParameter)
                    Else
                        If IsNumericByFactor() OrElse IsFactorByNumeric() Then
                            Select Case clsParameter.strArgumentName
                                Case "signif_fig", "include_margins", "margin_name"
                                    clsSummaryTableFunction.AddParameter(clsParameter)
                            End Select
                        End If
                    End If
                Next

            ElseIf rdoOCol.Checked Then

                For Each clsParameter In clsTempColFrequency.clsParameters
                    If IsFactorByFactor() Then
                        clsSummaryTableFunction.AddParameter(clsParameter)
                    Else
                        If IsNumericByFactor() OrElse IsFactorByNumeric() Then
                            Select Case clsParameter.strArgumentName
                                Case "signif_fig", "include_margins", "margin_name"
                                    clsSummaryTableFunction.AddParameter(clsParameter)
                            End Select
                        End If
                    End If
                Next
            End If
        ElseIf rdoThreeVariable.Checked Then

            For Each clsParameter In clsTempFrequency.clsParameters
                If IsFactorByFactorByFactor() Then
                    clsSummaryTableFunction.AddParameter(clsParameter)
                Else
                    If IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
                        Select Case clsParameter.strArgumentName
                            Case "signif_fig", "include_margins", "margin_name"
                                clsSummaryTableFunction.AddParameter(clsParameter)
                        End Select
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub Frequencies_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPercentages.ControlValueChanged,
        ucrChkDisplayAsPercentage.ControlValueChanged, ucrChkDisplayMargins.ControlValueChanged, ucrInputMarginName.ControlValueChanged, ucrpnlPercent.ControlValueChanged
        If rdoTwoVariable.Checked Then
            If ucrChkDisplayAsPercentage.Checked Then
                If rdoORow.Checked Then
                    ucrReceiverPercentages.SetMeAsReceiver()
                ElseIf rdoOCol.Checked Then
                    ucrReceiverColumns.SetMeAsReceiver()
                Else
                    ucrReceiverFirstVars.SetMeAsReceiver()
                End If
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
        ElseIf rdoSkim.Checked Then
            ucrReceiverFirstVars.SetMeAsReceiver()
        Else
            ucrReceiverFirstVars.SetMeAsReceiver()

        End If
        If rdoORow.Checked OrElse rdoOCell.Checked Then
            If ucrChkDisplayMargins.Checked Then
                ucrInputMarginName.Visible = True
                clsCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
            Else
                ucrInputMarginName.Visible = False
                clsCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
            End If
        ElseIf rdoOCol.Checked Then

            If ucrChkDisplayMargins.Checked Then
                ucrInputMarginName.Visible = True
                clsCombineFrequencyColParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
            Else
                ucrInputMarginName.Visible = False
                clsCombineFrequencyColParametersFunction.RemoveParameterByName("margin_name")
            End If
        Else
            clsCombineFrequencyColParametersFunction.RemoveParameterByName("margin_name")
            clsCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
        End If
        If rdoThreeVariable.Checked AndAlso IsFactorByFactorByFactor() OrElse IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
            If ucrChkDisplayMargins.Checked Then
                ucrInputMarginName.Visible = True
                clsThreeVariableCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
            Else
                ucrInputMarginName.Visible = False
                clsThreeVariableCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
            End If

        End If
        FactorColumns()
        AddRemoveFrequencyParameters()
        AddingColumnFactor()
        ChangeBaseRCode()
    End Sub

    Private Sub ucrSelectorDescribeTwoVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDescribeTwoVar.ControlValueChanged
        clsGroupByPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsRAnovaTableFunction.AddParameter("data", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub UpdateSummaryTableFunction()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        If rdoTwoVariable.Checked Then
            If IsFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("summaries", "count_label", iPosition:=4)
            ElseIf IsFactorByNumeric() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=4)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If IsFactorByFactorByNumeric() OrElse IsFactorByNumericByFactor() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=4)
            ElseIf IsFactorByFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("summaries", "count_label", iPosition:=4)
            End If
        End If
    End Sub

    Private Sub ucrReceiverNumericVariable_ControlValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableThirdVariable.ControlValueChanged
        AssignThirdVariableType()
        ManageControlsVisibility()
        UpdateCombineFactorParameterFunction()
        ChangeBaseRCode()
        ChangeLocations()
        UpdateSummaryTableFunction()
        AddRemoveFrequencyParameters()
        AddRemoveNAParameter()
        AddRemoveFirstCorrParam()
        AddRemoveThirdCorrParam()
        AddRemoveSecondCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdAnovaParam()
        AddRemoveFirstAnova2Param()
        FactorColumns()
    End Sub

    Private Sub ChangeSumaryLabelText()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        Dim strSummaryName As String = ""

        If IsFactorByFactor() Then
            strSummaryName = "Frequency tables"
        Else
            If rdoTwoVariable.Checked Then
                If IsNumericByNumeric() Then
                    strSummaryName = "ANOVA tables"
                ElseIf IsFactorByNumeric() Then
                    If ucrChkSwapXYVar.Checked Then
                        strSummaryName = "ANOVA tables"
                    Else
                        strSummaryName = "Summary tables"
                    End If
                ElseIf IsNumericByFactor() Then
                    strSummaryName = "ANOVA tables"
                Else
                    strSummaryName = ""
                End If
            End If
        End If
        If rdoThreeVariable.Checked Then
            If IsFactorByNumericByNumeric() Then
                strSummaryName = "Correlations"
            ElseIf IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() Then
                strSummaryName = "ANOVA tables"
            ElseIf IsNumericByFactorByFactor() Then
                strSummaryName = "ANOVA tables"
            ElseIf IsNumericByFactorByNumeric() Then
                strSummaryName = "ANOVA tables"
            ElseIf IsFactorByFactorByFactor() Then
                strSummaryName = "Frequency tables"
            ElseIf IsFactorByNumericByFactor() Then
                strSummaryName = "Summary tables"
            ElseIf IsFactorByFactorByNumeric() Then
                strSummaryName = "Summary tables"
            Else
                strSummaryName = ""
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
                ucrReceiverSecondTwoVariableFactor, ucrReceiverThreeVariableSecondFactor)
            If Not ucrCurrentReceiver.IsEmpty Then
                strSecondVariableType = If({"factor", "ordered,factor", "character", "logical"}.Contains(ucrCurrentReceiver.strCurrDataType),
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
        ChangeLocations()
        AddRemoveNAParameter()
        ManageControlsVisibility()
        FactorColumns()
        AddRemoveFirstAnova2Param()
        AddRemoveSecondAnovaParam()
        AddingColumnFactor()
        AddRemoveThirdAnovaParam()
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

    Private Sub AssignThirdVariableType()
        If rdoThreeVariable.Checked Then
            Dim ucrCurrentReceiver As ucrReceiverSingle = ucrReceiverThreeVariableThirdVariable
            If Not ucrCurrentReceiver.IsEmpty Then
                strThirdVariableType = If({"factor", "ordered,factor", "character", "logical"}.Contains(ucrCurrentReceiver.strCurrDataType),
                                  "categorical", "numeric")
                lblThreeVariableCategorical.Text = strThirdVariableType
                lblThreeVariableCategorical.ForeColor = SystemColors.Highlight

            Else
                strThirdVariableType = ""
                lblThreeVariableCategorical.Text = "________"
                lblThreeVariableCategorical.ForeColor = SystemColors.ControlText
            End If
            ChangeSumaryLabelText()
        End If
        ManageControlsVisibility()
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumTwovariableMode
            Case TwovariableMode.Describe
                ucrBase.iHelpTopicID = 414
            Case TwovariableMode.Climatic
                ucrBase.iHelpTopicID = 408
        End Select

    End Sub

    Private Sub ucrReceiverFirstVars_ControlValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlValueChanged,
        ucrReceiverFirstVars.ControlContentsChanged
        ChangeFirstTypeLabel()
        ChangeSumaryLabelText()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeBaseRCode()
        ManageControlsVisibility()
        ChangeLocations()
        AddRemoveFrequencyParameters()
        AddRemoveNAParameter()
        FactorColumns()
        AddRemoveFirstCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdAnovaParam()
        AddRemoveFirstAnova2Param()
        AddingColumnFactor()
        ThreeVarSummariesVar()
    End Sub

    Private Sub ucrReceiverThreeVariableSecondFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableSecondFactor.ControlValueChanged
        UpdateCombineFactorParameterFunction()
        AssignSecondVariableType()
        AddRemoveFirstCorrParam()
        AddRemoveSecondCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveFirstAnova2Param()
        UpdateSummaryTableFunction()
        FactorColumns()
        ChangeLocations()
        ChangeSumaryLabelText()
        ChangeBaseRCode()
        ManageControlsVisibility()
        AddRemoveThirdAnovaParam()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlContentsChanged,
        ucrReceiverSecondTwoVariableFactor.ControlContentsChanged, ucrPnlDescribe.ControlContentsChanged,
        ucrReceiverThreeVariableThirdVariable.ControlContentsChanged
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
                    lstMultipleVariables.Contains(ucrReceiverThreeVariableThirdVariable.GetVariableNames))
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
        sdgTableOptions.Setup(ucrSelectorDescribeTwoVar.strCurrentDataFrame, clsGtTableROperator)
        sdgTableOptions.ShowDialog(Me)
    End Sub

    Private Sub cmdMissingOptions_Click(sender As Object, e As EventArgs) Handles cmdMissingOptions.Click
        sdgMissingOptions.SetRFunction(clsNewSummaryFunction:=clsSummaryTableFunction, clsNewConcFunction:=clsCombineFunction, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgMissingOptions.ShowDialog()
    End Sub

    Private Sub FillListView()
        If clsSummariesListFunction.clsParameters.Count > 0 Then
            ucrReorderSummary.lstAvailableData.Clear()
            ucrReorderSummary.lstAvailableData.Columns.Add("Summaries")
            ucrReorderSummary.lstAvailableData.Columns(0).Width = -2
            For i = 0 To clsSummariesListFunction.clsParameters.Count - 1
                clsSummariesListFunction.clsParameters(i).Position = i
                ucrReorderSummary.lstAvailableData.Items.Add(clsSummariesListFunction.clsParameters(i).strArgumentName)
            Next
        Else
            ucrReorderSummary.lstAvailableData.Items.Clear()
        End If
    End Sub

    Private Sub ucrReorderSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReorderSummary.ControlValueChanged
        Dim lstOrderedSummaries As New List(Of RParameter)
        Dim iPosition As Integer = 0
        For i = 0 To ucrReorderSummary.lstAvailableData.Items.Count - 1
            lstOrderedSummaries.Add(clsSummariesListFunction.GetParameter(ucrReorderSummary.lstAvailableData.Items(i).Text))
        Next

        clsSummariesListFunction.ClearParameters()
        'Changing the parameter positions
        For Each clsParameter In lstOrderedSummaries
            clsParameter.Position = iPosition
            clsSummariesListFunction.AddParameter(clsParameter)
            iPosition += 1
        Next
    End Sub

    Private Sub ucrChkCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCorrelations.ControlValueChanged
        ChangeBaseRCode()
        If ucrChkCorrelations.Checked AndAlso Not ucrReceiverFirstVars.IsEmpty Then
            clsRCorrelationFunction.AddParameter("x_col_names", ucrReceiverFirstVars.GetVariableNames)
        Else
            clsRCorrelationFunction.RemoveParameterByName("x_col_names")
        End If
    End Sub

    Private Sub ucrChkSwapXYVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSwapXYVar.ControlValueChanged
        AddRemoveFirstAnova2Param()
        AddRemoveSecondAnovaParam()
        ChangeBaseRCode()
        ChangeSumaryLabelText()
        ManageControlsVisibility()
        ChangeLocations()
        AddRemoveThirdAnovaParam()
    End Sub

    Private Sub AddingColumnFactor()
        If IsFactorByFactor() Then
            If rdoOCol.Checked Then
                If Not ucrReceiverFirstVars.IsEmpty Then
                    ' Get the list of variable names from ucrReceiverFirstVars
                    Dim variableNames As List(Of String) = ucrReceiverFirstVars.GetVariableNamesAsList

                    ' Get the current list of variable names in ucrReceiverColumns
                    Dim currentColumnVars As List(Of String) = ucrReceiverColumns.GetVariableNamesAsList()

                    ' Remove variables from ucrReceiverColumns that are no longer in ucrReceiverFirstVars
                    For Each varName As String In currentColumnVars
                        If Not variableNames.Contains(varName) Then
                            ucrReceiverColumns.Remove(New String() {varName}) ' Remove expects an array of strings
                        End If
                    Next

                    ' Add the remaining variables to ucrReceiverColumns
                    For Each varName As String In variableNames
                        If Not currentColumnVars.Contains(varName) Then
                            ucrReceiverColumns.Add(varName)
                        End If
                    Next

                End If
            ElseIf rdoORow.Checked Then
                If Not ucrReceiverSecondTwoVariableFactor.IsEmpty Then
                    ucrReceiverPercentages.Add(ucrReceiverSecondTwoVariableFactor.GetVariableNames(False))
                End If
            End If
        Else
            ucrReceiverPercentages.Clear()
            ucrReceiverColumns.Clear()
        End If

    End Sub

    Private Sub ucrpnlPercent_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrpnlPercent.ControlValueChanged
        AddingColumnFactor()
        If rdoOCol.Checked Then
            clsDummyFunction.AddParameter("percent", "col", iPosition:=6)
        ElseIf rdoORow.Checked Then
            clsDummyFunction.AddParameter("percent", "row", iPosition:=6)
        Else
            clsDummyFunction.AddParameter("percent", "cell", iPosition:=6)
        End If
    End Sub

    Private Sub ucrChkTotal_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTotal.ControlValueChanged
        AddRemoveTotalParm()
    End Sub

    Private Sub AddRemoveTotalParm()
        clsRAnovaTable2Function.AddParameter("total", If(ucrChkTotal.Checked, "TRUE", "FALSE"), iPosition:=6)
        clsRAnovaSwapTable2Funtion.AddParameter("total", If(ucrChkTotal.Checked AndAlso ucrChkSwapXYVar.Checked, "TRUE", "FALSE"), iPosition:=6)
    End Sub

    Private Sub ucrChkInteraction_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkInteraction.ControlValueChanged
        AddInteraction()
    End Sub

    Private Sub AddInteraction()
        If rdoThreeVariable.Checked AndAlso ucrChkInteraction.Checked Then
            clsRAnovaTable2Function.AddParameter("interaction", "TRUE", iPosition:=7)
            clsRAnovaSwapTable2Funtion.AddParameter("interaction", "TRUE", iPosition:=7)
        Else
            clsRAnovaTable2Function.RemoveParameterByName("interaction")
            clsRAnovaSwapTable2Funtion.RemoveParameterByName("interaction")
        End If
    End Sub
End Class
