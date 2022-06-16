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
    Private bResetSubdialog As Boolean = False
    Public strFirstVariablesType, strSecondVariableType As String
    Public clsGetDataTypeFunction, clsGetSecondDataTypeFunction, clsRCorrelationFunction, clsRCustomSummaryFunction,
           clsCombineFunction, clsRAnovaFunction, clsFrequencyTablesFunction, clsSkimrFunction, clsSummariesListFunction,
           clsGroupByFunction, clsDummyFunction, clsMmtableFunction, clsHeaderTopLeftFunction, clSummaryTableFunction,
           clsHeaderLeftTopFunction, clsHeaderLeftTopFuncion, clsCombineFrequencyParametersFunction,
           clsSummaryMapFunction, clsCombineMultipleColumnsFunction, clsThreeVariableCombineFrequencyParametersFunction,
           clsMmtableMapFunction, clsHeaderTopLeftSummaryVariableFunction, clsSecondHeaderFunction,
           clsCombineFrequencyFactorParameterFunction, clsRenameFunction,
           clsSummaryTableFactorParameterCombineFunction As New RFunction

    Private clsGroupByPipeOperator, clsMmtablePlusOperator, clsMapFrequencyPipeOperator,
             clsMmtableTildeOperator, clsRenameTildeOperator, clsEmptyOperator, clsSecondEmptyOperator As New ROperator
    Private lstFrequencyParameters As New List(Of String)({"percentage_type", "margin_name",
                                                          "perc_total_factors", "perc_decimal",
                                                          "signif_fig", "include_margins"})
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

        ucrReceiverNumericVariable.SetParameterIsString()
        ucrReceiverNumericVariable.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverNumericVariable.SetLinkedDisplayControl(lblNumericVariable)

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
        ucrPnlDescribe.AddToLinkedControls({ucrReceiverNumericVariable}, {rdoThreeVariable}, bNewLinkedHideIfParameterMissing:=True)
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

        ucrChkThreeVariableDisplayAsPercentage.AddToLinkedControls(ucrReceiverThreeVariableMultiplePercentages, {True}, bNewLinkedHideIfParameterMissing:=True,
                                                      bNewLinkedAddRemoveParameter:=True)
        ucrChkThreeVariableDisplayAsPercentage.AddToLinkedControls(ucrChkThreeVariablePercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True,
                                                      bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverThreeVariableMultiplePercentages.SetParameter(New RParameter("perc_total_factors", 2))
        ucrReceiverThreeVariableMultiplePercentages.SetParameterIsString()
        ucrReceiverThreeVariableMultiplePercentages.Selector = ucrSelectorDescribeTwoVar
        ucrReceiverThreeVariableMultiplePercentages.SetDataType("factor")
        ucrReceiverThreeVariableMultiplePercentages.SetLinkedDisplayControl(lblThreeVariableFactorAsPercentages)

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

        clsGetDataTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetDataTypeFunction.AddParameter("property", "data_type_label")

        clsGetSecondDataTypeFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetSecondDataTypeFunction.AddParameter("property", "data_type_label")
    End Sub

    Private Sub SetDefaults()
        clsFrequencyTablesFunction = New RFunction
        clsRAnovaFunction = New RFunction
        clsRCorrelationFunction = New RFunction
        clsSummariesListFunction = New RFunction
        clsRCustomSummaryFunction = New RFunction
        clsCombineFunction = New RFunction
        clsSkimrFunction = New RFunction
        clsGroupByPipeOperator = New ROperator
        clsGroupByFunction = New RFunction
        clsMmtableFunction = New RFunction
        clsHeaderTopLeftFunction = New RFunction
        clsHeaderLeftTopFunction = New RFunction
        clsHeaderLeftTopFuncion = New RFunction
        clsDummyFunction = New RFunction
        clsCombineFrequencyParametersFunction = New RFunction
        clsSummaryMapFunction = New RFunction
        clsCombineMultipleColumnsFunction = New RFunction
        clsMmtableMapFunction = New RFunction
        clsHeaderTopLeftSummaryVariableFunction = New RFunction
        clsCombineFrequencyFactorParameterFunction = New RFunction
        clsRenameFunction = New RFunction
        clsSecondHeaderFunction = New RFunction
        clsThreeVariableCombineFrequencyParametersFunction = New RFunction
        clsSummaryTableFactorParameterCombineFunction = New RFunction
        clSummaryTableFunction = New RFunction
        clsRenameTildeOperator = New ROperator
        clsMmtableTildeOperator = New ROperator
        clsMapFrequencyPipeOperator = New ROperator
        clsMmtablePlusOperator = New ROperator
        clsEmptyOperator = New ROperator
        clsSecondEmptyOperator = New ROperator

        ucrSelectorDescribeTwoVar.Reset()
        ucrReceiverFirstVars.SetMeAsReceiver()
        ucrInputMarginName.SetText("All")
        ucrNudColumnFactors.SetText("2")
        ucrInputMarginName.Visible = False
        grpThreeVariablePercentages.Visible = False

        ucrBase.clsRsyntax.ClearCodes()

        clsCombineFrequencyParametersFunction.SetRCommand("c")

        clsThreeVariableCombineFrequencyParametersFunction.SetRCommand("c")

        clsSummaryTableFactorParameterCombineFunction.SetRCommand("c")

        clsRenameFunction.SetPackageName("dplyr")
        clsRenameFunction.SetRCommand("rename")
        clsRenameFunction.AddParameter(".data", clsRFunctionParameter:=clsFrequencyTablesFunction, iPosition:=0)
        clsRenameFunction.AddParameter("by_var", ".x", iPosition:=1)

        clsCombineFrequencyFactorParameterFunction.SetRCommand("c")
        clsCombineFrequencyFactorParameterFunction.AddParameter("factor_by", ".x",
                                                                iPosition:=3, bIncludeArgumentName:=False)

        clsEmptyOperator.SetOperation("")
        clsEmptyOperator.AddParameter("multiple_receiver_cols", "multiple_receiver_cols", iPosition:=0)
        clsEmptyOperator.SetAssignTo("names(list_of_tables)")

        clsSecondEmptyOperator.SetOperation("")
        clsSecondEmptyOperator.iCallType = 2
        clsSecondEmptyOperator.AddParameter("list_of_tables", "list_of_tables", iPosition:=0)

        clsRenameTildeOperator.SetOperation("~")
        clsRenameTildeOperator.AddParameter("empty_parameter", "", iPosition:=0)
        clsRenameTildeOperator.AddParameter("rename_function", clsRFunctionParameter:=clsRenameFunction, iPosition:=1)

        clsMmtableTildeOperator.SetOperation("~")
        clsMmtableTildeOperator.AddParameter("empty_parameter", "", iPosition:=0)
        clsMmtableTildeOperator.AddParameter("mmtable", clsRFunctionParameter:=clsMmtableFunction, iPosition:=1)

        clsCombineMultipleColumnsFunction.SetRCommand("c")
        clsCombineMultipleColumnsFunction.SetAssignTo("multiple_receiver_cols")

        clsSummaryMapFunction.SetPackageName("purrr")
        clsSummaryMapFunction.SetRCommand("map")
        clsSummaryMapFunction.AddParameter(".x", clsRFunctionParameter:=clsCombineMultipleColumnsFunction, iPosition:=0)
        clsSummaryMapFunction.AddParameter(".f", clsROperatorParameter:=clsRenameTildeOperator, iPosition:=1)

        clsMmtableMapFunction.SetPackageName("purrr")
        clsMmtableMapFunction.SetRCommand("map")
        clsMmtableMapFunction.AddParameter(".x", ".", iPosition:=0)
        clsMmtableMapFunction.AddParameter(".f", clsROperatorParameter:=clsMmtablePlusOperator, iPosition:=1)

        clsMapFrequencyPipeOperator.SetOperation("%>%")
        clsMapFrequencyPipeOperator.AddParameter("map_summary_table", clsRFunctionParameter:=clsSummaryMapFunction, iPosition:=1)
        clsMapFrequencyPipeOperator.AddParameter("map_mmtable", clsRFunctionParameter:=clsMmtableMapFunction, iPosition:=2)
        clsMapFrequencyPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsMapFrequencyPipeOperator.SetAssignTo("list_of_tables ")

        clsHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftFunction.SetRCommand("header_top_left")

        clsHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsHeaderLeftTopFunction.SetRCommand("header_left_top")

        clsSecondHeaderFunction.SetPackageName("mmtable2")
        clsSecondHeaderFunction.SetRCommand("header_left_top")

        clsHeaderTopLeftSummaryVariableFunction.SetPackageName("mmtable2")
        clsHeaderTopLeftSummaryVariableFunction.SetRCommand("header_top_left")
        clsHeaderTopLeftSummaryVariableFunction.AddParameter("variable", Chr(39) & "summary-variable" & Chr(39), iPosition:=0)

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", ".x", iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)

        clsMmtablePlusOperator.SetOperation("+")
        clsMmtablePlusOperator.bBrackets = False
        clsMmtablePlusOperator.AddParameter("mmtable2", clsROperatorParameter:=clsMmtableTildeOperator, iPosition:=0)
        clsMmtablePlusOperator.AddParameter("header_top_left", clsRFunctionParameter:=clsHeaderTopLeftFunction, iPosition:=1)
        clsMmtablePlusOperator.AddParameter("header_left_top", clsRFunctionParameter:=clsHeaderLeftTopFunction, iPosition:=2)

        clsGroupByPipeOperator.SetOperation("%>%")
        clsGroupByPipeOperator.AddParameter("skim", clsRFunctionParameter:=clsSkimrFunction, iPosition:=2, bIncludeArgumentName:=False)
        clsGroupByPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsSkimrFunction.SetPackageName("skimr")
        clsSkimrFunction.SetRCommand("skim_without_charts")

        clsCombineFunction.SetRCommand("c")

        clsFrequencyTablesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsFrequencyTablesFunction.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsFrequencyTablesFunction.AddParameter("summaries", "count_label", iPosition:=1)
        clsFrequencyTablesFunction.AddParameter("factors", clsRFunctionParameter:=clsCombineFrequencyFactorParameterFunction, iPosition:=2)

        clSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clSummaryTableFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=1)
        clSummaryTableFunction.AddParameter("factors", clsRFunctionParameter:=clsSummaryTableFactorParameterCombineFunction, iPosition:=2)
        clSummaryTableFunction.AddParameter("columns_to_summarise", ".x", iPosition:=3)

        clsRAnovaFunction.AddParameter("signif.stars", "FALSE", iPosition:=2)
        clsRAnovaFunction.AddParameter("sign_level", "FALSE", iPosition:=3)
        clsRAnovaFunction.AddParameter("means", "FALSE", iPosition:=4)

        clsSummariesListFunction.SetRCommand("c")
        clsSummariesListFunction.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)

        clsRCustomSummaryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")
        clsRCustomSummaryFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction)

        clsRCustomSummaryFunction.AddParameter("store_results", "FALSE", iPosition:=4)
        clsRCustomSummaryFunction.AddParameter("drop", "TRUE", iPosition:=5)
        clsRCustomSummaryFunction.AddParameter("na.rm", "FALSE", iPosition:=6)
        clsRCustomSummaryFunction.AddParameter("return_output", "TRUE", iPosition:=7)

        clsRCorrelationFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$cor")

        clsRAnovaFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$anova_tables")

        ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRAnovaFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=1)
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("y_col_name", 2), iAdditionalPairNo:=2)
        ucrReceiverSecondTwoVariableFactor.AddAdditionalCodeParameterPair(clsCombineFrequencyFactorParameterFunction, New RParameter("factor_one", 2, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRAnovaFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=1)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsRCorrelationFunction, New RParameter("x_col_names", 1), iAdditionalPairNo:=2)
        ucrReceiverFirstVars.AddAdditionalCodeParameterPair(clsSkimrFunction, New RParameter("col_names", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRAnovaFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clsRCustomSummaryFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=2)
        ucrSelectorDescribeTwoVar.AddAdditionalCodeParameterPair(clSummaryTableFunction, ucrSelectorDescribeTwoVar.GetParameter(), iAdditionalPairNo:=3)

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
        ucrReceiverThreeVariableMultiplePercentages.SetRCode(clsThreeVariableCombineFrequencyParametersFunction, bReset)
        ucrChkThreeVariablePercentageProportion.SetRCode(clsThreeVariableCombineFrequencyParametersFunction, bReset)
        ucrReceiverThreeVariableSecondFactor.SetRCode(clsCombineFrequencyFactorParameterFunction, bReset)
        ucrPnlDescribe.SetRCode(clsDummyFunction, bReset)
        ucrNudSigFigs.SetRCode(clsCombineFrequencyParametersFunction, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverFirstVars.IsEmpty Then
            If rdoTwoVariable.Checked Then
                If Not ucrReceiverSecondTwoVariableFactor.IsEmpty Then
                    If ucrChkDisplayAsPercentage.Checked Then
                        If ucrReceiverPercentages.IsEmpty Then
                            ucrBase.OKEnabled(False)
                        Else
                            ucrBase.OKEnabled(True)
                        End If
                    Else
                        ucrBase.OKEnabled(True)
                    End If
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoSkim.Checked Then
                ucrBase.OKEnabled(True)
            Else
                If Not ucrReceiverThreeVariableSecondFactor.IsEmpty AndAlso
                Not ucrReceiverNumericVariable.IsEmpty Then
                    If strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                        If ucrChkThreeVariableDisplayAsPercentage.Checked Then
                            If ucrReceiverThreeVariableMultiplePercentages.IsEmpty Then
                                ucrBase.OKEnabled(False)
                            Else
                                ucrBase.OKEnabled(True)
                            End If
                        Else
                            ucrBase.OKEnabled(True)
                        End If
                    Else
                        ucrBase.OKEnabled(True)
                    End If
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseDescribeTwoVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        If rdoTwoVariable.Checked Then
            If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
        ElseIf rdoThreeVariable.Checked Then
            If strFirstVariablesType = "categorical" AndAlso
                strSecondVariableType = "numeric" Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clsFrequencyTablesFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            ElseIf strFirstVariablesType = "numeric" AndAlso
                strSecondVariableType = "categorical" Then
                sdgSummaries.SetRFunction(clsSummariesListFunction, clSummaryTableFunction, clsCombineFunction, ucrSelectorDescribeTwoVar, bResetSubdialog)
            End If
        End If
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs)
        sdgDescribeDisplay.SetRFunction(clsFrequencyTablesFunction, clsRAnovaFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgDescribeDisplay.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub ManageControlsVisibility()
        grpSummaries.Visible = rdoThreeVariable.Checked OrElse rdoTwoVariable.Checked
        grpOptions.Visible = False

        If rdoTwoVariable.Checked Then
            Select Case strFirstVariablesType
                Case "numeric"
                    ucrChkOmitMissing.Visible = True
                    If strSecondVariableType = "categorical" Then
                        grpOptions.Visible = True
                    End If
            End Select
        ElseIf rdoThreeVariable.Checked Then
            If (strFirstVariablesType = "categorical" AndAlso
            strSecondVariableType = "numeric") OrElse
            (strFirstVariablesType = "numeric" And
            strSecondVariableType = "categorical") Then
                grpOptions.Visible = True
            Else
                grpOptions.Visible = False
            End If
        End If
    End Sub

    Private Sub ChangeBaseRCode()
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsEmptyOperator)
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSecondEmptyOperator)

        If rdoSkim.Checked Then
            clsDummyFunction.AddParameter("checked", "skim", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsGroupByPipeOperator)
        ElseIf rdoTwoVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "customize", iPosition:=0)
            If strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "numeric" Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRCorrelationFunction)
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "numeric" Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRAnovaFunction)
            ElseIf strFirstVariablesType = "numeric" AndAlso strSecondVariableType = "categorical" Then
                ucrReceiverFirstVars.SetParameterIsString()
                clsRenameTildeOperator.AddParameter("rename_function", clsRFunctionParameter:=clSummaryTableFunction, iPosition:=1)
                ucrBase.clsRsyntax.SetBaseROperator(clsMapFrequencyPipeOperator)
                ucrBase.clsRsyntax.AddToAfterCodes(clsEmptyOperator, 1)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSecondEmptyOperator, 2)
            ElseIf strFirstVariablesType = "categorical" AndAlso strSecondVariableType = "categorical" Then
                clsRenameTildeOperator.AddParameter("rename_function", clsRFunctionParameter:=clsRenameFunction, iPosition:=1)
                ucrBase.clsRsyntax.SetBaseROperator(clsMapFrequencyPipeOperator)
                ucrBase.clsRsyntax.AddToAfterCodes(clsEmptyOperator, 1)
                ucrBase.clsRsyntax.AddToAfterCodes(clsSecondEmptyOperator, 2)
            End If
        ElseIf rdoThreeVariable.Checked Then
            clsDummyFunction.AddParameter("checked", "three_variable", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsMapFrequencyPipeOperator)
            ucrBase.clsRsyntax.AddToAfterCodes(clsEmptyOperator, 1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsSecondEmptyOperator, 2)
        End If
    End Sub

    Private Sub UpdateCombineFactorFunctions()
        Dim iPosition As Integer = 0
        clsCombineMultipleColumnsFunction.ClearParameters()
        If rdoThreeVariable.Checked OrElse rdoTwoVariable.Checked Then
            If Not ucrReceiverFirstVars.IsEmpty Then
                For Each strColumn In ucrReceiverFirstVars.GetVariableNamesList()
                    clsCombineMultipleColumnsFunction.AddParameter(strColumn, strColumn, bIncludeArgumentName:=False, iPosition:=iPosition)
                    iPosition += 1
                Next
            End If
        End If
    End Sub

    Private Sub UpdateCombineFactorParameterFunction()
        clsSummaryTableFactorParameterCombineFunction.RemoveParameterByName("factor_one")
        clsSummaryTableFactorParameterCombineFunction.RemoveParameterByName("factor_two")
        clsSummaryTableFactorParameterCombineFunction.RemoveParameterByName("factor_three")
        If rdoTwoVariable.Checked Then
            clsSummaryTableFactorParameterCombineFunction.AddParameter("factor_one",
                                                ucrReceiverSecondTwoVariableFactor.GetVariableNames(), iPosition:=0,
                                                bIncludeArgumentName:=False)
        ElseIf rdoThreeVariable.Checked Then
            clsSummaryTableFactorParameterCombineFunction.AddParameter("factor_two",
                                             ucrReceiverThreeVariableSecondFactor.GetVariableNames(), iPosition:=1,
                                             bIncludeArgumentName:=False)

            If strSecondVariableType = "categorical" Then
                clsSummaryTableFactorParameterCombineFunction.AddParameter("factor_three",
                                                             ucrReceiverNumericVariable.GetVariableNames(), iPosition:=2,
                                                             bIncludeArgumentName:=False)
            End If
        End If
    End Sub

    Private Sub AddRemoveNAParameter()
        clsFrequencyTablesFunction.RemoveParameterByName("na.rm")
        clSummaryTableFunction.RemoveParameterByName("na.rm")
        If ucrChkOmitMissing.Checked Then
            If rdoTwoVariable.Checked Then
                If strFirstVariablesType = "numeric" AndAlso
                        strSecondVariableType = "categorical" Then
                    clSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
                End If
            ElseIf rdoThreeVariable.Checked Then
                If strFirstVariablesType = "numeric" AndAlso
                        strSecondVariableType = "categorical" Then
                    clSummaryTableFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
                ElseIf strFirstVariablesType = "categorical" AndAlso
                        strSecondVariableType = "numeric" Then
                    clsFrequencyTablesFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
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
        End If
        ChangeFirstTypeLabel()
        AssignSecondVariableType()
        ChangeBaseRCode()
        ManageControlsVisibility()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        ChangeSummaryFunctionForThreeVariable()
        UpdateClsCombineFrequencyFactorParameterFunction()
        AddRemoveNAParameter()
    End Sub

    Private Sub ChangeLocations()
        If rdoSkim.Checked Then
            ucrBase.Location = New Point(iUcrBaseXLocation, 328)
            Me.Size = New Point(iDialogueXsize, 425)
        Else
            Select Case strFirstVariablesType
                Case "numeric"
                    If strSecondVariableType = "categorical" Then
                        ucrBase.Location = New Point(iUcrBaseXLocation, 435)
                        Me.Size = New Point(iDialogueXsize, 530)
                    End If
                Case "categorical"
                    If strSecondVariableType = "categorical" Then
                        ucrBase.Location = New Point(iUcrBaseXLocation, 435)
                        Me.Size = New Point(iDialogueXsize, 530)
                    ElseIf strSecondVariableType = "numeric" Then
                        If rdoThreeVariable.Checked Then
                            ucrBase.Location = New Point(iUcrBaseXLocation, 435)
                            Me.Size = New Point(iDialogueXsize, 530)
                        Else
                            ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                            Me.Size = New Point(iDialogueXsize, 425)
                        End If
                    End If
                Case ""
                    ucrBase.Location = New Point(iUcrBaseXLocation, 328)
                    Me.Size = New Point(iDialogueXsize, 425)
            End Select
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
        grpThreeVariablePercentages.Visible = False
        grpTwoVariablePercentages.Visible = False
        grpFrequency.Visible = False
        ucrInputMarginName.Visible = ucrChkDisplayMargins.Checked
        If rdoTwoVariable.Checked Then
            If (strFirstVariablesType = "categorical" OrElse
                strFirstVariablesType = "numeric") AndAlso
                strSecondVariableType = "categorical" Then
                If strFirstVariablesType = "categorical" Then
                    grpTwoVariablePercentages.Visible = True
                Else
                    grpTwoVariablePercentages.Visible = False
                End If
                grpFrequency.Visible = True
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
        ElseIf rdoThreeVariable.Checked Then
            If (strFirstVariablesType = "numeric" AndAlso
                strSecondVariableType = "categorical") OrElse
               (strFirstVariablesType = "categorical" AndAlso
               strSecondVariableType = "numeric") Then
                grpFrequency.Visible = True
            ElseIf strFirstVariablesType = "categorical" AndAlso
                strSecondVariableType = "categorical" Then
                grpFrequency.Visible = True
                grpThreeVariablePercentages.Visible = True
                grpTwoVariablePercentages.Visible = False
            End If
        End If
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
            If strSecondVariableType = "categorical" Then
                Select Case strFirstVariablesType
                    Case "numeric"
                        If ucrNudColumnFactors.GetText = 1 Then
                            strLeftTop = Chr(39) & "summary-variable" & Chr(39)
                            strTopLeft = strFactor
                        Else
                            strTopLeft = Chr(39) & "summary-variable" & Chr(39)
                            strLeftTop = strFactor
                        End If
                    Case "categorical"
                        If ucrNudColumnFactors.GetText = 1 Then
                            strTopLeft = Chr(39) & "by_var" & Chr(39)
                            strLeftTop = strFactor
                        ElseIf ucrNudColumnFactors.GetText = 2 Then
                            strLeftTop = Chr(39) & "by_var" & Chr(39)
                            strTopLeft = strFactor
                        End If
                End Select
            End If
        Else
            If strSecondVariableType = "categorical" Then
                Select Case strFirstVariablesType
                    Case "categorical"
                        If ucrNudColumnFactors.GetText = 1 Then
                            clsSecondHeaderFunction.strRCommand = "header_left_top"
                            strLeftTop = Chr(39) & "by_var" & Chr(39)
                            strTopLeft = strFactor
                        ElseIf ucrNudColumnFactors.GetText = 2 Then
                            strLeftTop = strFactor
                            strTopLeft = Chr(39) & "by_var" & Chr(39)
                            clsSecondHeaderFunction.strRCommand = "header_top_left"
                        End If
                        strSecondHeader = ucrReceiverNumericVariable.GetVariableNames()
                    Case "numeric"
                        If ucrNudColumnFactors.GetText = 1 Then
                            clsSecondHeaderFunction.strRCommand = "header_top_left"
                            strLeftTop = ucrReceiverNumericVariable.GetVariableNames()
                            strTopLeft = strFactor
                        ElseIf ucrNudColumnFactors.GetText = 2 Then
                            clsSecondHeaderFunction.strRCommand = "header_left_top"
                            strTopLeft = ucrReceiverNumericVariable.GetVariableNames()
                            strLeftTop = strFactor
                        End If
                        strSecondHeader = Chr(34) & "summary-variable" & Chr(34)
                End Select
            ElseIf strSecondVariableType = "numeric" Then
                Select Case strFirstVariablesType
                    Case "categorical"
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
                End Select
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

    Private Sub ChangeSummaryFunctionForThreeVariable()
        clsFrequencyTablesFunction.AddParameter("summaries", "count_label", iPosition:=1)
        If rdoThreeVariable.Checked Then
            If strFirstVariablesType = "numeric" AndAlso
                  strSecondVariableType = "categorical" Then
                clsRenameTildeOperator.AddParameter("rename_function", clsRFunctionParameter:=clSummaryTableFunction, iPosition:=1)
            Else
                If strFirstVariablesType = "categorical" AndAlso
                  strSecondVariableType = "numeric" Then
                    clsFrequencyTablesFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesListFunction, iPosition:=1)
                End If
                clsRenameTildeOperator.AddParameter("rename_function", clsRFunctionParameter:=clsRenameFunction, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub AddRemoveFrequencyParameters()
        If rdoSkim.Checked Then
            Exit Sub
        End If
        Dim clsTempFrequency As RFunction = If(rdoThreeVariable.Checked,
        clsThreeVariableCombineFrequencyParametersFunction,
        clsCombineFrequencyParametersFunction).Clone

        For Each strParameter In lstFrequencyParameters
            clsFrequencyTablesFunction.RemoveParameterByName(strParameter)
            clSummaryTableFunction.RemoveParameterByName(strParameter)
        Next

        For Each clsParameter In clsTempFrequency.clsParameters
            If rdoThreeVariable.Checked Then
                If strFirstVariablesType = "categorical" AndAlso
                    strSecondVariableType = "categorical" Then
                    clsFrequencyTablesFunction.AddParameter(clsParameter)
                Else
                    If (strFirstVariablesType = "numeric" AndAlso
                    strSecondVariableType = "categorical") OrElse
                     (strFirstVariablesType = "categorical" AndAlso
                    strSecondVariableType = "numeric") Then
                        Select Case clsParameter.strArgumentName
                            Case "signif_fig", "include_margins", "margin_name"
                                If (strFirstVariablesType = "numeric" AndAlso
                                    strSecondVariableType = "categorical") Then
                                    clSummaryTableFunction.AddParameter(clsParameter)
                                Else
                                    clsFrequencyTablesFunction.AddParameter(clsParameter)
                                End If
                        End Select
                    End If
                End If
            Else
                If (strFirstVariablesType = "numeric" AndAlso
                    strSecondVariableType = "categorical") Then
                    Select Case clsParameter.strArgumentName
                        Case "signif_fig", "include_margins", "margin_name"
                            clSummaryTableFunction.AddParameter(clsParameter)
                    End Select
                End If
                clsFrequencyTablesFunction.AddParameter(clsParameter)
                End If
        Next
    End Sub

    Private Sub Frequencies_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPercentageProportion.ControlValueChanged,
        ucrChkDisplayAsPercentage.ControlValueChanged, ucrNudSigFigs.ControlValueChanged, ucrChkDisplayMargins.ControlValueChanged,
        ucrReceiverPercentages.ControlValueChanged, ucrInputMarginName.ControlValueChanged, ucrChkThreeVariablePercentageProportion.ControlValueChanged,
        ucrReceiverThreeVariableMultiplePercentages.ControlValueChanged, ucrChkThreeVariableDisplayAsPercentage.ControlValueChanged
        If rdoTwoVariable.Checked Then
            If ucrChkDisplayAsPercentage.Checked Then
                ucrReceiverPercentages.SetMeAsReceiver()
            Else
                ucrReceiverFirstVars.SetMeAsReceiver()
            End If
        ElseIf rdoThreeVariable.checked Then
            If ucrChkThreeVariableDisplayAsPercentage.Checked Then
                ucrReceiverThreeVariableMultiplePercentages.SetMeAsReceiver()
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
        clsMapFrequencyPipeOperator.AddParameter("data", clsRFunctionParameter:=ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsFrequencyTablesFunction.AddParameter("data_name", Chr(34) & ucrSelectorDescribeTwoVar.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub UpdateClsCombineFrequencyFactorParameterFunction()
        clsCombineFrequencyFactorParameterFunction.RemoveParameterByName("factor_two")
        clsFrequencyTablesFunction.RemoveParameterByName("columns_to_summarise")
        If rdoThreeVariable.Checked Then
            If strSecondVariableType = "categorical" Then
                clsCombineFrequencyFactorParameterFunction.AddParameter("factor_two", ucrReceiverNumericVariable.GetVariableNames(),
                                                                       iPosition:=1, bIncludeArgumentName:=False)
            ElseIf strSecondVariableType = "numeric" Then
                clsFrequencyTablesFunction.AddParameter("columns_to_summarise", ucrReceiverNumericVariable.GetVariableNames(), iPosition:=3)
            End If
        End If
    End Sub

    Private Sub ucrReceiverNumericVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumericVariable.ControlValueChanged
        AssignSecondVariableType()
        ManageControlsVisibility()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        ChangeSummaryFunctionForThreeVariable()
        AddRemoveFrequencyParameters()
        UpdateClsCombineFrequencyFactorParameterFunction()
        EnableDisableFrequencyControls()
        AddRemoveNAParameter()
    End Sub

    Private Sub ChangeSumaryLabelText()
        Dim strSummaryName As String = ""
        If rdoTwoVariable.Checked Then
            Select Case strFirstVariablesType
                Case "numeric"
                    If strSecondVariableType = "numeric" Then
                        strSummaryName = "Correlations"
                    ElseIf strSecondVariableType = "categorical" Then
                        strSummaryName = "Summary Tables"
                    End If
                Case "categorical"
                    If strSecondVariableType = "numeric" Then
                        strSummaryName = "ANOVA tables"
                    ElseIf strSecondVariableType = "categorical" Then
                        strSummaryName = "Frequency tables"
                    End If
                Case Else
                    strSummaryName = ""
            End Select
        ElseIf rdoThreeVariable.Checked Then
            Select Case strFirstVariablesType
                Case "numeric"
                    If strSecondVariableType = "categorical" Then
                        strSummaryName = "Summary tables"
                    End If
                Case "categorical"
                    If strSecondVariableType = "categorical" Then
                        strSummaryName = "Frequency tables"
                    ElseIf strSecondVariableType = "numeric" Then
                        strSummaryName = "Summary tables"
                    End If
                Case Else
                    strSummaryName = ""
            End Select
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
                ucrReceiverSecondTwoVariableFactor, ucrReceiverNumericVariable)
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

    Private Sub ucrReceiverSecondTwoVariableFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecondTwoVariableFactor.ControlValueChanged
        AssignSecondVariableType()
        ChangeBaseRCode()
        UpdateCombineFactorParameterFunction()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        AddRemoveNAParameter()
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

    Private Sub ucrReceiverFirstVars_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstVars.ControlValueChanged
        ChangeFirstTypeLabel()
        ChangeSummaryFunctionForThreeVariable()
        ChangeSumaryLabelText()
        ChangeBaseRCode()
        ManageControlsVisibility()
        UpdateCombineFactorFunctions()
        ChangeLocations()
        EnableDisableFrequencyControls()
        SwapMmtableHeaderFunctions()
        AddRemoveFrequencyParameters()
        AddRemoveNAParameter()
    End Sub

    Private Sub ucrReceiverThreeVariableSecondFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverThreeVariableSecondFactor.ControlValueChanged
        UpdateCombineFactorParameterFunction()
        SwapMmtableHeaderFunctions()
    End Sub

    Private Sub controls_contentChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayAsPercentage.ControlContentsChanged,
        ucrReceiverPercentages.ControlContentsChanged, ucrReceiverThreeVariableMultiplePercentages.ControlContentsChanged,
        ucrChkThreeVariableDisplayAsPercentage.ControlContentsChanged, ucrReceiverFirstVars.ControlContentsChanged,
        ucrReceiverSecondTwoVariableFactor.ControlContentsChanged, ucrReceiverThreeVariableSecondFactor.ControlContentsChanged,
        ucrReceiverNumericVariable.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class