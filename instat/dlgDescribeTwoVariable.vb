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

    'SUMMARY FUNCTIoNS
    Private clsCombineFrequencyParametersFunction, clsCombineFunction,
       clsDummyFunction, clsGroupByFunction, clsRAnovaFunction,
        clsRCorrelationFunction, clsSkimrFunction, clsSummariesListFunction,
        clsSummaryTableCombineFactorsFunction, clsSummaryTableFunction,
        clsThreeVariableCombineFrequencyParametersFunction, clsPivotWiderFunction As New RFunction

    'FORMAT TABLE FUNCTIONS
    Private clsFootnoteCellBodyFunction, clsFootnoteCellFunction,
        clsFootnoteSubtitleLocationFunction, clsFootnoteTitleLocationFunction, clsSecondFootnoteCellBodyFunction,
        clsSecondFootnoteCellFunction, clsStyleListFunction,
        clsTabFootnoteSubtitleFunction, clsTabFootnoteTitleFunction,
        clsTableSourcenoteFunction, clsTableTitleFunction, clsThemesTabOptionFunction,
        clsTabStyleCellTextFunction, clsTabStyleCellTitleFunction, clsTabStyleFunction,
        clsTabStylePxFunction, clsgtExtrasThemesFuction As New RFunction

    Private clsGroupByPipeOperator, clsSummaryOperator As New ROperator

    Private clsFrequencyTablesFunction, clsgtFunction, clsCombineFrequencyFactorParameterFunction,
        clsSelectFunction, clsRenameCombineFunction As New RFunction
    'Frequency Parameters
    Private lstFrequencyParameters As New List(Of String)({"percentage_type", "margin_name",
                                                          "perc_total_factors", "perc_decimal",
                                                          "signif_fig", "include_margins"})

    'Format Operators
    Private clsPipeOperator, clsTabFootnoteOperator,
            clsJoiningPipeOperator, clsMutableOperator As ROperator
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
        'ucrChkOmitMissing.SetLinkedDisplayControl(cmdMissingOptions)

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

        ucrPnlDescribe.AddRadioButton(rdoTwoVariable)
        ucrPnlDescribe.AddRadioButton(rdoSkim)
        ucrPnlDescribe.AddRadioButton(rdoThreeVariable)
        ucrPnlDescribe.AddParameterValuesCondition(rdoTwoVariable, "checked", "customize")
        ucrPnlDescribe.AddParameterValuesCondition(rdoSkim, "checked", "skim")
        ucrPnlDescribe.AddParameterValuesCondition(rdoThreeVariable, "checked", "three_variable")
        rdoThreeVariable.Enabled = False

        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSkimrGroupByFactor, ucrReceiverSecondSkimrGroupByFactor}, {rdoSkim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableThirdVariable}, {rdoThreeVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverSecondTwoVariableFactor}, {rdoTwoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverThreeVariableSecondFactor}, {rdoThreeVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverThreeVariableSecondFactor.SetParameter(New RParameter("second_three_varible_factor", 0, bNewIncludeArgumentName:=False))
        ucrReceiverThreeVariableSecondFactor.SetParameterIsString()
        ucrReceiverThreeVariableSecondFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverThreeVariableSecondFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverThreeVariableSecondFactor.SetLinkedDisplayControl(lblThreeVariableSecondFactor)

        ucrPnlColumnFactor.AddRadioButton(rdoSummaryVariable)
        ucrPnlColumnFactor.AddRadioButton(rdoVariableFactor)
        ucrPnlColumnFactor.AddRadioButton(rdoNoColumnFactor)
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoNoColumnFactor, "factor_cols", "NoColFactor")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoSummaryVariable, "factor_cols", "Sum")
        ucrPnlColumnFactor.AddParameterValuesCondition(rdoVariableFactor, "factor_cols", "FactorVar")
        ucrPnlColumnFactor.AddToLinkedControls(ucrReceiverColumnFactor, {rdoVariableFactor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverColumnFactor.SetParameter(New RParameter("names_from", 0))
        ucrReceiverColumnFactor.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverColumnFactor.SetDataType("factor")

        'ucrSaveTable.SetPrefix("summary_table")
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
        clsPivotWiderFunction = New RFunction
        clsgtExtrasThemesFuction = New RFunction
        clsMutableOperator = New ROperator

        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrInputMarginName.SetText("All")
        ucrInputMarginName.Visible = False
        ucrSaveTable.Reset()

        'ucrBase.clsRsyntax.ClearCodes()

        clsCombineFrequencyParametersFunction.SetRCommand("c")

        clsCombineFunction.SetRCommand("c")

        clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
        clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
        clsDummyFunction.AddParameter("theme", "select", iPosition:=2)

        clsPivotWiderFunction.SetRCommand("pivot_wider")
        clsPivotWiderFunction.AddParameter("values_from", "value", iPosition:=1)

        clsFootnoteCellBodyFunction.SetPackageName("gt")
        clsFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsFootnoteCellFunction.SetPackageName("gt")
        clsFootnoteCellFunction.SetRCommand("tab_footnote")

        clsFootnoteSubtitleLocationFunction.SetPackageName("gt")
        clsFootnoteSubtitleLocationFunction.SetRCommand("cells_title")

        clsFootnoteTitleLocationFunction.SetPackageName("gt")
        clsFootnoteTitleLocationFunction.SetRCommand("cells_title")

        clsgtExtrasThemesFuction.SetPackageName("gtExtras")

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsGroupByPipeOperator.SetOperation("%>%")
        clsGroupByPipeOperator.AddParameter("skim", clsRFunctionParameter:=clsSkimrFunction,
                                            iPosition:=2, bIncludeArgumentName:=False)
        clsGroupByPipeOperator.AddParameter("data",
                                            clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        'clsGroupByPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
        '                                       strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
        '                                       strRObjectFormatToAssignTo:=RObjectFormat.Text,
        '                                       strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
        '                                       strObjectName:="last_summary")

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")

        clsCombineFunction.SetRCommand("c")

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
        clsSummaryTableFunction.SetAssignTo("summary_table")

        clsgtFunction.SetPackageName("gt")
        clsgtFunction.SetRCommand("gt")

        clsSummaryOperator.SetOperation("%>%")
        clsSummaryOperator.AddParameter("tableFun", clsRFunctionParameter:=clsSummaryTableFunction, iPosition:=0)
        clsSummaryOperator.AddParameter("gttbl", clsRFunctionParameter:=clsgtFunction, iPosition:=1)

        clsJoiningPipeOperator.SetOperation("%>%")
        clsJoiningPipeOperator.AddParameter("gtable", clsROperatorParameter:=clsSummaryOperator, iPosition:=0)
        'clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
        'strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
        '                                       strRObjectFormatToAssignTo:=RObjectFormat.Html,
        '                                       strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
        '                                       strObjectName:="last_table")
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

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnovaFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsSummaryTableFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=2)
        ucrSaveTable.AddAdditionalRCode(clsJoiningPipeOperator, iAdditionalPairNo:=1)

        ucrChkOmitMissing.SetRCode(clsSummaryTableFunction, bReset)
        ucrReceiverFirstVars.SetRCode(clsSummaryTableFunction, bReset)
        ucrReceiverSecondTwoVariableFactor.SetRCode(clsSummaryTableFunction, bReset)
        ucrSelectorDescribeTwoVar.SetRCode(clsRCorrelationFunction, bReset)
        ucrReceiverSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrReceiverSecondSkimrGroupByFactor.SetRCode(clsGroupByFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrReceiverPercentages.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrChkPercentageProportion.SetRCode(clsCombineFrequencyParametersFunction, bReset)
        ucrPnlDescribe.SetRCode(clsDummyFunction, bReset)
        ucrReceiverThreeVariableSecondFactor.SetRCode(clsSummaryTableCombineFactorsFunction, bReset)
        ucrReceiverThreeVariableThirdVariable.SetRCode(clsSummaryTableCombineFactorsFunction, bReset)
        ucrPnlColumnFactor.SetRCode(clsDummyFunction, bReset)
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
                OrElse IsFactorByNumeric() OrElse IsNumericByNumeric())) AndAlso ucrSaveTable.IsComplete)
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
        ElseIf rdoThreeVariable.Checked Then
            If IsFactorByNumeric() OrElse IsNumericByFactor() Then
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
        ucrReorderSummary.Visible = IsNumericByFactor()
        cmdSummaries.Visible = IsNumericByFactor()
        grpColumnFactor.Visible = IsFactorByFactor() OrElse IsNumericByFactor()
        ucrChkDisplayMargins.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor()
        ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked AndAlso IsFactorByFactor()
        grpDisplay.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor()

        If rdoTwoVariable.Checked Then
            ucrChkOmitMissing.Visible = strFirstVariablesType = "numeric"
        ElseIf rdoThreeVariable.Checked Then
            ucrChkOmitMissing.Visible = IsFactorByNumeric() OrElse IsNumericByFactor()
        Else
            ucrChkOmitMissing.Visible = False
        End If
        cmdMissingOptions.Visible = ucrChkOmitMissing.Checked
    End Sub

    Private Sub ChangeBaseRCode()
        If rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)

            ucrSaveTable.Visible = True
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
                clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                ucrSaveTable.SetPrefix("summary_table")
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Save Table")
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                     strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                     strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                     strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                     strObjectName:="last_table")
            ElseIf IsFactorByFactor() Then
                ucrSaveTable.Visible = True
                clsDummyFunction.AddParameter("factor_cols", "FactorVar", iPosition:=1)
                ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
                ucrSaveTable.SetPrefix("frequency_table")
                ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
                ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
                ucrSaveTable.SetCheckBoxText("Save Table")
                clsJoiningPipeOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                  strRDataFrameNameToAddObjectTo:=ucrSelectorDescribeTwoVar.strCurrentDataFrame,
                                  strObjectName:="last_table")
            End If
        ElseIf rdoThreeVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "three_variable", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
            ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            'ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
            ucrSaveTable.SetCheckBoxText("Save Table")
        End If
        FactorColumns()
        'ChangePrefix()
    End Sub

    'Private Sub ChangePrefix()
    '    If rdoSkim.Checked Then
    '        ucrSaveTable.SetPrefix("summary_table")
    '    Else
    '        If IsNumericByFactor() Then
    '            ucrSaveTable.SetPrefix("summary_table")
    '        ElseIf IsFactorByFactor Then
    '            ucrSaveTable.SetPrefix("frequency_table")
    '        End If
    '    End If
    'End Sub

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
        'EnableDisableFrequencyControls()
        ' AddRemoveFrequencyParameters()
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
            ucrSaveTable.Location = New Point(23, 286)
        ElseIf rdoThreeVariable.Checked Then
            ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
            lblThreeVariableCategorical.Visible = True
            lblThreeVariableCategorical.Location = New Point(106, 18)
            lblSecondType.Location = New Point(12, 33)
            lblSecondBy.Visible = True
        Else
            ucrSaveTable.Location = New Point(23, 450)
            ucrReceiverFirstVars.SetSingleTypeStatus(True, bIsCategoricalNumeric:=True)
            lblThreeVariableCategorical.Visible = False
            lblThreeVariableCategorical.Location = New Point(12, 33)
            lblSecondType.Location = New Point(106, 18)
            lblSecondBy.Visible = False
        End If
        ' cmdSummaries.Visible = rdoTwoVariable.Checked OrElse rdoThreeVariable.Checked

        ChangeFirstTypeLabel()
        AssignSecondVariableType()
        ChangeBaseRCode()
        ManageControlsVisibility()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        EnableDisableFrequencyControls()
        AddRemoveNAParameter()
        HideFormatTableButton()
    End Sub

    Private Sub HideFormatTableButton()
        cmdFormatTable.Visible = IsNumericByFactor() _
            OrElse IsFactorByFactor() OrElse (IsFactorByNumeric() _
            AndAlso rdoThreeVariable.Checked)
    End Sub

    Private Sub ChangeLocations()
        If IsNumericByFactor() OrElse IsFactorByFactor() _
                OrElse (IsFactorByNumeric() AndAlso rdoThreeVariable.Checked) Then
            ucrBase.Location = New Point(iUcrBaseXLocation, 487)
            Me.Size = New Point(iDialogueXsize, 580)
        ElseIf IsFactorByNumeric() Then
            ucrBase.Location = New Point(iUcrBaseXLocation, 319)
            Me.Size = New Point(iDialogueXsize, 415)
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

    Private Sub EnableDisableFrequencyControls()
        ' grpThreeVariablePercentages.Visible = rdoThreeVariable.Checked _
        '     AndAlso IsFactorByFactor()
        'grpDisplay.Visible = rdoTwoVariable.Checked AndAlso IsFactorByFactor()
        'OrElse IsNumericByCategorical())
        ' grpFrequency.Visible = (rdoTwoVariable.Checked AndAlso (IsCategoricalByCategorical() _
        'OrElse IsNumericByCategorical())) OrElse (rdoThreeVariable.Checked _
        'AndAlso (IsNumericByCategorical() OrElse IsCategoricalByNumeric() _
        ' OrElse IsCategoricalByCategorical()))
        'ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked
    End Sub

    Private Sub Display_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnFactor.ControlValueChanged, ucrReceiverColumnFactor.ControlValueChanged
        FactorColumns()
    End Sub

    Private Sub FactorColumns()
        If rdoNoColumnFactor.Checked Then
            clsSummaryOperator.RemoveParameterByName("col_factor")
            clsDummyFunction.AddParameter("factor_cols", "NoColFactor", iPosition:=1)
        Else
            clsSummaryOperator.AddParameter("col_factor", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            If rdoSummaryVariable.Checked Then
                clsDummyFunction.AddParameter("factor_cols", "Sum", iPosition:=1)
                clsPivotWiderFunction.AddParameter("names_from", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)
            ElseIf rdoVariableFactor.Checked Then
                ucrReceiverColumnFactor.SetMeAsReceiver()
                clsDummyFunction.AddParameter("factor_cols", "FactorVar", iPosition:=1)
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverColumnFactor.GetVariableNames(False), iPosition:=0)
            End If
        End If
        AddingColumnFactor()
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
        '    ucrChkDisplayAsPercentage.ControlValueChanged, ucrChkThreeVariablePercentageProportion.ControlValueChanged, ucrChkThreeVariableDisplayAsPercentage.ControlValueChanged
        If rdoTwoVariable.Checked Then
            If ucrChkDisplayAsPercentage.Checked Then
                ucrReceiverPercentages.SetMeAsReceiver()
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
            '    ElseIf rdoThreeVariable.Checked Then
            '        If ucrChkThreeVariableDisplayAsPercentage.Checked Then
            '            ucrReceiverThreeVariablePercentage.SetMeAsReceiver()
        Else
            ucrReceiverFirstVars.SetMeAsReceiver()
        End If
        '    End If
        If ucrChkDisplayMargins.Checked Then
            ucrInputMarginName.Visible = True
            clsCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
            'clsThreeVariableCombineFrequencyParametersFunction.AddParameter("margin_name", Chr(34) & ucrInputMarginName.GetText & Chr(34), iPosition:=6)
        Else
            ucrInputMarginName.Visible = False
            clsCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
            'clsThreeVariableCombineFrequencyParametersFunction.RemoveParameterByName("margin_name")
        End If

        AddRemoveFrequencyParameters()
    End Sub

    Private Sub ucrSelectorDescribeTwoVar_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDescribeTwoVar.ControlValueChanged
        clsGroupByPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        ' clsJoiningPipeOperator._strDataFrameNameToAddAssignToObject = ucrSelectorDescribeTwoVar.strCurrentDataFrame
        ' clsGroupByPipeOperator._strDataFrameNameToAddAssignToObject = ucrSelectorDescribeTwoVar.strCurrentDataFrame
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
            ElseIf IsNumericByFactor() Then
                clsSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=4)
            End If
        End If
    End Sub

    Private Sub ucrReceiverNumericVariable_ControlValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableThirdVariable.ControlValueChanged
        AssignSecondVariableType()
        ManageControlsVisibility()
        UpdateCombineFactorParameterFunction()
        ChangeBaseRCode()
        ChangeLocations()
        EnableDisableFrequencyControls()
        UpdateSummaryTableFunction()
        AddRemoveFrequencyParameters()
        AddRemoveNAParameter()
        HideFormatTableButton()
        ' TestOKEnabled()
    End Sub

    Private Sub ChangeSumaryLabelText()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        Dim strSummaryName As String = ""

        If IsFactorByFactor() Then
            strSummaryName = "Frequency tables"
        ElseIf IsNumericByFactor() Then
            strSummaryName = "Summary tables"
        Else
            If rdoTwoVariable.Checked Then
                If IsNumericByNumeric() Then
                    strSummaryName = "Correlations"
                ElseIf IsFactorByNumeric() Then
                    strSummaryName = "ANOVA tables"
                Else
                    strSummaryName = ""
                End If
            ElseIf rdoThreeVariable.Checked Then
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
        ChangeLocations()
        'EnableDisableFrequencyControls()
        AddRemoveNAParameter()
        HideFormatTableButton()
        ManageControlsVisibility()
        'TestOKEnabled()
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

    Private Sub ucrReceiverFirstVars_ControlValueAndContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlValueChanged
        'ucrReceiverFirstVars.ControlContentsChanged()
        ChangeFirstTypeLabel()
        ChangeSumaryLabelText()
        UpdateSummaryTableFunction()
        UpdateCombineFactorParameterFunction()
        ChangeBaseRCode()
        ManageControlsVisibility()
        ChangeLocations()
        EnableDisableFrequencyControls()
        AddRemoveFrequencyParameters()
        AddRemoveNAParameter()
        HideFormatTableButton()
        'TestOKEnabled()
    End Sub

    Private Sub ucrReceiverThreeVariableSecondFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableSecondFactor.ControlValueChanged
        UpdateCombineFactorParameterFunction()
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

    Private Sub AddingColumnFactor()
        Dim lstVariables As New List(Of String)
        Dim iXVarCount As Integer

        iXVarCount = lstVariables.Count
        If bRcodeSet Then
            If lstVariables.Contains(ucrReceiverColumnFactor.GetVariableNames(False)) OrElse
                Not ucrReceiverSecondTwoVariableFactor.GetVariableNames().Contains(ucrReceiverColumnFactor.GetVariableNames(False)) Then
                ucrReceiverColumnFactor.Clear()
                ucrReceiverSecondTwoVariableFactor.SetMeAsReceiver()
            End If
            If iXVarCount = 0 AndAlso Not ucrReceiverSecondTwoVariableFactor.IsEmpty AndAlso
                ucrReceiverColumnFactor.IsEmpty() Then
                ucrReceiverColumnFactor.SetText(ucrReceiverSecondTwoVariableFactor.GetVariableNames(False))
                ucrReceiverSecondTwoVariableFactor.SetMeAsReceiver()
            ElseIf ucrReceiverSecondTwoVariableFactor.IsEmpty Then
                ucrReceiverColumnFactor.Clear()
            End If
            'lstVariables = ucrReceiverSecondTwoVariableFactor.GetVariableNamesAsList()
        End If
    End Sub
End Class
