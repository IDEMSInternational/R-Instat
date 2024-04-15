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
    Private clsCombineFrequencyParametersFunction, clsCombineFunction, clsCombineAnova2Function, clsSummariseFunction,
       clsDummyFunction, clsGroupByFunction, clsRAnovaFunction, clsCorrFunction, clsRAnovaTableFunction,
        clsRCorrelationFunction, clsSkimrFunction, clsSummariesListFunction, clsCombineAnovaFunction,
        clsSummaryTableCombineFactorsFunction, clsSummaryTableFunction,
        clsThreeVariableCombineFrequencyParametersFunction, clsPivotWiderFunction, clsMappingFunction, clsRAnovaTable2Function As New RFunction

    'FORMAT TABLE FUNCTIONS
    Private clsFootnoteCellBodyFunction, clsFootnoteCellFunction,
        clsFootnoteSubtitleLocationFunction, clsFootnoteTitleLocationFunction, clsSecondFootnoteCellBodyFunction,
        clsSecondFootnoteCellFunction, clsStyleListFunction,
        clsTabFootnoteSubtitleFunction, clsTabFootnoteTitleFunction,
        clsTableSourcenoteFunction, clsTableTitleFunction, clsThemesTabOptionFunction,
        clsTabStyleCellTextFunction, clsTabStyleCellTitleFunction, clsTabStyleFunction,
        clsTabStylePxFunction, clsgtExtrasThemesFuction As New RFunction


    Private clsGroupByPipeOperator, clsSummaryOperator, clsGroupByPipeOperator2, clsGroupByPipeOperator3, clsGroupByPipeOperator4, clsGroupByPipeOperatorData As New ROperator

    Private clsTildOperator, clsMapOperator, clsPivotOperator As New ROperator


    Private clsgtFunction, clsMapSummaryFunction, clsMapGtFunction As New RFunction
    'Frequency Parameters
    Private lstFrequencyParameters As New List(Of String)({"percentage_type", "margin_name",
                                                          "perc_total_factors", "perc_decimal",
                                                          "signif_fig", "include_margins"})

    'Format Operators
    Private clsPipeOperator, clsTabFootnoteOperator,
            clsJoiningPipeOperator, clsMutableOperator, clsAnovaTable2Operator, clsYlistOperator As New ROperator
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

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 1))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverPercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverPercentages.SetParameter(New RParameter("perc_total_factors", 2))
        ucrReceiverPercentages.SetParameterIsString()
        ucrReceiverPercentages.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverPercentages.SetDataType("factor")
        ucrReceiverPercentages.SetLinkedDisplayControl(lblFactorAsPercentage)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 3))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrChkSummariesRowCol.SetText("Summaries in Rows")
        ucrChkSummariesRowCol.AddParameterValuesCondition(True, "row_sum", "True")
        ucrChkSummariesRowCol.AddParameterValuesCondition(False, "row_sum", "False")

        ucrPnlDescribe.AddRadioButton(rdoTwoVariable)
        ucrPnlDescribe.AddRadioButton(rdoSkim)
        ucrPnlDescribe.AddRadioButton(rdoThreeVariable)
        ucrPnlDescribe.AddParameterValuesCondition(rdoTwoVariable, "checked", "customize")
        ucrPnlDescribe.AddParameterValuesCondition(rdoSkim, "checked", "skim")
        ucrPnlDescribe.AddParameterValuesCondition(rdoThreeVariable, "checked", "three_variable")
        'rdoThreeVariable.Enabled = False

        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSkimrGroupByFactor, ucrReceiverSecondSkimrGroupByFactor}, {rdoSkim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableThirdVariable}, {rdoThreeVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSecondTwoVariableFactor, ucrChkSummariesRowCol}, {rdoTwoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableSecondFactor}, {rdoThreeVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverThreeVariableSecondFactor.SetParameter(New RParameter("second_three_varible_factor", 0, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariableSecondFactor.SetParameterIsString()
        ucrReceiverThreeVariableSecondFactor.Selector = ucrSelectorDescribeTwoVar
        'ucrReceiverThreeVariableSecondFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverThreeVariableSecondFactor.SetLinkedDisplayControl(lblThreeVariableSecondFactor)

        ucrSaveTable.SetDataFrameSelector(ucrSelectorDescribeTwoVar.ucrAvailableDataFrames)
        ucrSaveTable.SetIsTextBox()

        ucrReorderSummary.bDataIsSummaries = True
    End Sub

    Private Sub SetDefaults()
        clsCombineFrequencyParametersFunction = New RFunction
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
        clsAnovaTable2Operator = New ROperator
        clsYlistOperator = New ROperator
        clsRAnovaTable2Function = New RFunction

        clsTildOperator = New ROperator
        clsMapSummaryFunction = New RFunction
        clsMapGtFunction = New RFunction
        clsPivotOperator = New ROperator


        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrInputMarginName.SetText("All")
        ucrInputMarginName.Visible = False
        ucrSaveTable.Reset()

        clsCombineFrequencyParametersFunction.SetRCommand("c")

        clsCombineFunction.SetRCommand("c")

        clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
        clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
        clsDummyFunction.AddParameter("theme", "select", iPosition:=2)
        clsDummyFunction.AddParameter("row_sum", "False", iPosition:=3)

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

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", clsROperatorParameter:=clsYlistOperator, iPosition:=0)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsAnovaTable2Operator, iPosition:=1)

        clsAnovaTable2Operator.SetOperation("~")
        clsAnovaTable2Operator.AddParameter("right", clsRFunctionParameter:=clsRAnovaTable2Function, iPosition:=1)
        clsAnovaTable2Operator.bForceIncludeOperation = True

        clsYlistOperator.SetOperation("", bBracketsTemp:=False)
        clsYlistOperator.SetAssignTo("y_col_names_list")

        clsRAnovaTable2Function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables2")
        clsRAnovaTable2Function.AddParameter("data", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsRAnovaTable2Function.AddParameter(" x_col_names", clsRFunctionParameter:=clsCombineAnova2Function, iPosition:=1)
        clsRAnovaTable2Function.AddParameter("y_col_name", ".x", iPosition:=2)
        clsRAnovaTable2Function.AddParameter("signif.stars", "FALSE", iPosition:=3)
        clsRAnovaTable2Function.AddParameter("sign_level", "FALSE", iPosition:=4)
        clsRAnovaTable2Function.AddParameter("means", "FALSE", iPosition:=5)

        clsGroupByPipeOperator.SetOperation("%>%")
        clsGroupByPipeOperator.AddParameter("skim", clsRFunctionParameter:=clsSkimrFunction,
                                            iPosition:=2, bIncludeArgumentName:=False)
        clsGroupByPipeOperator.AddParameter("data",
                                            clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsGroupByPipeOperator2.SetOperation("%>%")
        clsGroupByPipeOperator2.AddParameter("left", clsROperatorParameter:=clsGroupByPipeOperatorData, iPosition:=0)
        clsGroupByPipeOperator2.AddParameter("right", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)

        clsGroupByPipeOperator3.SetOperation("%>%")
        clsGroupByPipeOperator3.AddParameter("left", clsROperatorParameter:=clsGroupByPipeOperator2, iPosition:=0)
        clsGroupByPipeOperator3.AddParameter("right", clsRFunctionParameter:=clsSummariseFunction, iPosition:=1)

        clsGroupByPipeOperator4.SetOperation("%>%")
        clsGroupByPipeOperator4.AddParameter("left", clsROperatorParameter:=clsGroupByPipeOperator3, iPosition:=0)
        clsGroupByPipeOperator4.AddParameter("right", clsRFunctionParameter:=clsgtFunction, iPosition:=1)

        clsGroupByPipeOperatorData.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsSummariseFunction.SetRCommand("summarise")
        clsSummariseFunction.AddParameter("cor", clsRFunctionParameter:=clsCorrFunction, bIncludeArgumentName:=False, iPosition:=0)


        clsCorrFunction.SetRCommand("cor")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")

        clsRAnovaTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")
        clsRAnovaTableFunction.AddParameter("data", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
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
        clsSummariesListFunction.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34),
                                              bIncludeArgumentName:=False, iPosition:=0)

        clsSummaryTableCombineFactorsFunction.SetRCommand("c")

        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsSummaryTableFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=3)
        'clsSummaryTableFunction.SetAssignTo("summary_table")

        clsTildOperator.SetOperation("~")
        clsTildOperator.AddParameter("right", clsRFunctionParameter:=clsSummaryTableFunction)
        clsTildOperator.bBrackets = False
        clsTildOperator.bForceIncludeOperation = True
        clsTildOperator.bSpaceAroundOperation = False

        clsMapSummaryFunction.SetPackageName("purrr")
        clsMapSummaryFunction.SetRCommand("map")
        clsMapSummaryFunction.AddParameter(".f", clsROperatorParameter:=clsMapOperator, iPosition:=1)

        clsMapGtFunction.SetPackageName("purrr")
        clsMapGtFunction.SetRCommand("map")
        clsMapGtFunction.AddParameter("gttbl", clsRFunctionParameter:=clsgtFunction, bIncludeArgumentName:=False)

        clsgtFunction.SetPackageName("gt")
        clsgtFunction.SetRCommand("gt")

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsMapSummaryFunction, iPosition:=1)
        'clsSummaryOperator.AddParameter("gttbl", clsRFunctionParameter:=clsgtFunction, iPosition:=1)

        clsPivotOperator.SetOperation("%>%")
        clsPivotOperator.AddParameter("left", clsRFunctionParameter:=clsPivotWiderFunction)
        clsPivotOperator.AddParameter("right", clsRFunctionParameter:=clsgtFunction)
        clsPivotOperator.bBrackets = False

        clsMapOperator.SetOperation("%>%")
        clsMapOperator.AddParameter("left", clsROperatorParameter:=clsTildOperator)
        'clsMapOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        'clsMapOperator.AddParameter("tableFun", clsRFunctionParameter:=clsMapSummaryFunction, iPosition:=1)
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
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRAnovaFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=2)

        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRAnovaFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=2)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsSkimrFunction, New RParameter("col_names", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsMapSummaryFunction, New RParameter(".x", 1), iAdditionalPairNo:=4)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnovaFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsSummaryTableFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=2)
        ucrSaveTable.AddAdditionalRCode(clsJoiningPipeOperator, iAdditionalPairNo:=1)

        ucrChkOmitMissing.SetRCode(clsSummaryTableFunction, bReset)
        ucrReceiverFirstVars.SetRCode(clsDummyFunction, bReset)
        ucrReceiverSecondTwoVariableFactor.SetRCode(clsDummyFunction, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCorrelationFunction, bReset)
        ucrReceiverSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverSecondSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrReceiverPercentages.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrChkPercentageProportion.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrPnlDescribe.SetRCode(clsDummyFunction, bReset)
        ucrChkSummariesRowCol.SetRCode(clsDummyFunction, bReset)
        ucrReceiverThreeVariableSecondFactor.SetRCode(clsSummaryTableCombineFactorsFunction, bReset)
        ucrReceiverThreeVariableThirdVariable.SetRCode(clsSummaryTableCombineFactorsFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrSaveTable.SetRCode(clsGroupByPipeOperator, bReset)
        bRcodeSet = True

        FillListView()
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

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        If rdoTwoVariable.Checked Then
            If IsNumericByFactor() Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clsSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
            'ElseIf rdoThreeVariable.Checked Then
            '    'If IsFactorByNumeric() Then
            '    '    sdgSummaries.SetRFunction(clsSummariesListFunction, clsSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            '    'End If
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
        ucrReorderSummary.Visible = IsNumericByFactor()
        cmdSummaries.Visible = IsNumericByFactor()
        ucrChkDisplayMargins.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor()
        ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked AndAlso IsFactorByFactor()
        grpDisplay.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor()
        ucrChkSummariesRowCol.Visible = False
        If rdoTwoVariable.Checked Then
            ucrChkOmitMissing.Visible = strFirstVariablesType = "numeric"
            ucrChkSummariesRowCol.Visible = IsNumericByFactor()
        ElseIf rdoThreeVariable.Checked Then
            ucrChkOmitMissing.Visible = IsFactorByNumeric() OrElse IsNumericByFactor()
        Else
            ucrChkOmitMissing.Visible = False
        End If
        If rdoThreeVariable.Checked Then
            If IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                ucrReorderSummary.Visible = False
                cmdSummaries.Visible = False
            End If
            ucrChkDisplayMargins.Visible = IsFactorByFactorByFactor()
            ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked AndAlso IsFactorByFactorByFactor()
        End If
        cmdMissingOptions.Visible = ucrChkOmitMissing.Checked
    End Sub

    Private Sub ChangeBaseRCode()
        ucrSaveTable.Visible = False
        If rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)

            ucrSaveTable.Visible = True
            ucrSaveTable.Location = New Point(23, 286)
            ucrSaveTable.SetPrefix("summary_table")
            ucrSaveTable.SetSaveType(RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)
            ucrSaveTable.SetAssignToIfUncheckedValue("last_summary")
            ucrSaveTable.SetCheckBoxText("Save Summary")
            ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
            clsGroupByPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                   strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                   strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                     strObjectName:="last_summary")

        ElseIf rdoTwoVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "customize", iPosition:=0)
            If IsNumericByNumeric() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelationFunction)
                ucrSaveTable.Visible = False
            ElseIf IsFactorByNumeric() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRAnovaFunction)
                ucrSaveTable.Visible = False
            ElseIf IsNumericByFactor() Then
                ucrSaveTable.Visible = True
                ucrSaveTable.Location = New Point(23, 450)
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
            ElseIf IsFactorByFactor() Then
                ucrSaveTable.Visible = True
                ucrSaveTable.Location = New Point(23, 350)
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
            End If
        ElseIf rdoThreeVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "three_variable", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
            ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            ucrSaveTable.SetCheckBoxText("Save Table")
            If IsFactorByFactorByFactor() Then
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                    strObjectName:="last_table")
            End If
            If IsFactorByNumericByNumeric() Then
                ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator4)
                clsGroupByPipeOperator4.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                              strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                                    strObjectName:="last_table")
            End If
            If IsNumericByNumericByFactor() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            End If
            If IsNumericByNumericByNumeric() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            End If
            If IsNumericByFactorByFactor() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            End If
            If IsNumericByFactorByNumeric() Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMappingFunction)
            End If
        End If
        FactorColumns()
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
                If IsNumericByFactor() Then
                    clsSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
                End If
            ElseIf rdoThreeVariable.Checked Then
                If IsNumericByFactor() OrElse IsFactorByNumeric() Then
                    clsSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
                End If
            End If
        End If
        ChangeLocations()
        TestOKEnabled()
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If ucrChkOmitMissing.Checked Then
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
    End Sub

    Private Sub ucrPnlDescribe_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDescribe.ControlValueChanged
        ucrReceiverFirstVars.Clear()
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
        ShowFormatTableButton()
        FactorColumns()
        AddRemoveFirstCorrParam()
        AddRemoveSecondCorrParam()
        AddRemoveThirdCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdAnovaParam()
        AddRemoveFirstAnova2Param()
    End Sub

    Private Sub ShowFormatTableButton()
        If rdoTwoVariable.Checked Then
            cmdFormatTable.Visible = IsNumericByFactor() _
            OrElse IsFactorByFactor() OrElse IsFactorByNumeric()
        ElseIf rdoThreeVariable.Checked Then
            cmdFormatTable.Visible = IsFactorByFactorByFactor()
        Else
            cmdFormatTable.Visible = False
        End If
    End Sub

    Private Sub ChangeLocations()
        If rdoTwoVariable.Checked Then
            If IsNumericByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 487)
                Me.Size = New Point(iDialogueXsize, 580)
                cmdFormatTable.Location = New Point(326, 423)
            ElseIf IsFactorByNumeric() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 319)
                Me.Size = New Point(iDialogueXsize, 415)
            ElseIf IsFactorByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 370)
                Me.Size = New Point(iDialogueXsize, 465)
                cmdFormatTable.Location = New Point(326, 325)
            Else
                ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                Me.Size = New Point(iDialogueXsize, 425)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                Me.Size = New Point(iDialogueXsize, 425)
            ElseIf IsFactorByFactorByFactor() Then
                ucrBase.Location = New Point(iUcrBaseXLocation, 370)
                Me.Size = New Point(iDialogueXsize, 465)
                cmdFormatTable.Visible = True
                cmdFormatTable.Location = New Point(326, 325)
            Else
                ucrBase.Location = New Point(iUcrBaseXLocation, 385)
                Me.Size = New Point(iDialogueXsize, 480)
            End If
        Else
            ucrBase.Location = New Point(iUcrBaseXLocation, 328)
            Me.Size = New Point(iDialogueXsize, 425)
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
                    clsGroupByFunction.AddParameter("var", ucrReceiverFirstVars.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
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
                    clsCorrFunction.RemoveParameterByName("y")
                Else
                    clsCorrFunction.AddParameter("y", ucrReceiverThreeVariableThirdVariable.GetVariableNames(False), iPosition:=2, bIncludeArgumentName:=False)
                End If
            End If
        End If
    End Sub

    Private Sub FactorColumns()
        If rdoTwoVariable.Checked Then
            If IsFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("factors", "c(" & ucrReceiverSecondTwoVariableFactor.GetVariableNames & "," & ".x" & ")")
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ".x")
                clsPivotWiderFunction.AddParameter("names_from", "{{ .x }}", iPosition:=1)
            Else
                clsSummaryTableFunction.AddParameter("factors", ucrReceiverSecondTwoVariableFactor.GetVariableNames)
                clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=1)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverFirstVars.GetVariableNames)
                SummariesInRowsOrCols()
            End If
        End If
        If rdoThreeVariable.Checked Then
            clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            If IsFactorByFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("factors", "c(" & Chr(34) & ucrReceiverFirstVars.lstSelectedVariables.Items(0).Text & Chr(34) & "," & ucrReceiverThreeVariableSecondFactor.GetVariableNames & "," & ucrReceiverThreeVariableThirdVariable.GetVariableNames & ")")
                clsSummaryTableFunction.AddParameter("columns_to_summarise", Chr(34) & ucrReceiverFirstVars.lstSelectedVariables.Items(0).Text & Chr(34))
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverFirstVars.lstSelectedVariables.Items(0).Text, iPosition:=0)
            Else
                clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)
                clsSummaryTableFunction.AddParameter("columns_to_summarise", ucrReceiverFirstVars.GetVariableNames)
                SummariesInRowsOrCols()
            End If
        End If
    End Sub

    Private Sub AddRemoveFirstAnova2Param()
        If rdoThreeVariable.Checked Then
            If IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                If ucrReceiverFirstVars.IsEmpty Then
                    clsYlistOperator.RemoveParameterByName("cols")
                Else
                    clsYlistOperator.AddParameter("cols", ucrReceiverFirstVars.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveSecondAnovaParam()
        If rdoThreeVariable.Checked Then
            If IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                If ucrReceiverThreeVariableSecondFactor.IsEmpty Then
                    clsCombineAnova2Function.RemoveParameterByName("x")
                Else
                    clsCombineAnova2Function.AddParameter("x", ucrReceiverThreeVariableSecondFactor.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        End If
    End Sub

    Private Sub AddRemoveThirdAnovaParam()
        If rdoThreeVariable.Checked Then
            If IsNumericByNumericByFactor() OrElse IsNumericByNumericByNumeric() OrElse IsNumericByFactorByFactor() OrElse IsNumericByFactorByNumeric() Then
                If ucrReceiverThreeVariableThirdVariable.IsEmpty Then
                    clsCombineAnova2Function.RemoveParameterByName("y")
                Else
                    clsCombineAnova2Function.AddParameter("y", ucrReceiverThreeVariableThirdVariable.GetVariableNames(True), iPosition:=2, bIncludeArgumentName:=False)
                End If
            End If
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
    End Sub

    Private Sub Frequencies_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPercentageProportion.ControlValueChanged,
        ucrChkDisplayAsPercentage.ControlValueChanged, ucrChkDisplayMargins.ControlValueChanged,
        ucrReceiverPercentages.ControlValueChanged, ucrInputMarginName.ControlValueChanged
        If rdoTwoVariable.Checked Then
            If ucrChkDisplayAsPercentage.Checked Then
                ucrReceiverPercentages.SetMeAsReceiver()
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
        Else
            ucrReceiverFirstVars.SetMeAsReceiver()
        End If
        If ucrChkDisplayMargins.Checked Then
            ucrInputMarginName.Visible = True
            clsCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
        Else
            ucrInputMarginName.Visible = False
            clsCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
        End If
        FactorColumns()
        AddRemoveFrequencyParameters()
    End Sub

    Private Sub ucrSelectorDescribeTwoVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDescribeTwoVar.ControlValueChanged
        clsGroupByPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub UpdateSummaryTableFunction()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        If rdoTwoVariable.Checked Then
            If IsFactorByFactor() Then
                clsSummaryTableFunction.AddParameter("summaries", "count_label", iPosition:=4)
            ElseIf IsNumericByFactor() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=4)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If IsFactorByNumeric() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=4)
            ElseIf IsFactorByFactor() Then
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
        ShowFormatTableButton()
        AddRemoveFirstCorrParam()
        AddRemoveThirdCorrParam()
        AddRemoveSecondCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdAnovaParam()
        AddRemoveFirstAnova2Param()
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
                    strSummaryName = "Correlations"
                ElseIf IsFactorByNumeric() Then
                    strSummaryName = "ANOVA tables"
                ElseIf IsNumericByFactor() Then
                    strSummaryName = "Summary tables"
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
            Else
                strSummaryName = "Summary tables"
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

    Private Sub SummariesInRowsOrCols()
        If ucrChkSummariesRowCol.Checked Then
            clsPivotWiderFunction.AddParameter("names_from", ucrReceiverSecondTwoVariableFactor.GetVariableNames(False), iPosition:=1)
            clsDummyFunction.AddParameter("row_sum", "True", iPosition:=3)
        Else
            clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=1)
            clsDummyFunction.AddParameter("row_sum", "False", iPosition:=3)
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
        ShowFormatTableButton()
        ManageControlsVisibility()
        FactorColumns()
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
                strThirdVariableType = If({"factor", "character", "logical"}.Contains(ucrCurrentReceiver.strCurrDataType),
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
        ShowFormatTableButton()
        FactorColumns()
        AddRemoveFirstCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveThirdAnovaParam()
        AddRemoveFirstAnova2Param()
    End Sub

    Private Sub ucrReceiverThreeVariableSecondFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableSecondFactor.ControlValueChanged
        UpdateCombineFactorParameterFunction()
        AssignSecondVariableType()
        AddRemoveFirstCorrParam()
        AddRemoveSecondCorrParam()
        AddRemoveSecondAnovaParam()
        AddRemoveFirstAnova2Param()
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
        sdgFormatSummaryTables.SetRCode(clsNewTableTitleFunction:=clsTableTitleFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                        clsNewThemesTabOptionFunction:=clsThemesTabOptionFunction, clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                       clsNewPipeOperator:=clsPipeOperator, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                       clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                       clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction, clsNewgtExtraThemesFunction:=clsgtExtrasThemesFuction, clsNewMutableOperator:=clsMutableOperator,
                                       clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, bReset:=bReset)
        sdgFormatSummaryTables.ShowDialog()
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

    Private Sub ucrChkSummariesRowCol_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummariesRowCol.ControlValueChanged
        ManageControlsVisibility()
        SummariesInRowsOrCols()
    End Sub

End Class
