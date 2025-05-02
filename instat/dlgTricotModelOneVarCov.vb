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
Imports RDotNet
Public Class dlgTricotModelOneVarCov
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bResetSubDialog As Boolean = False
    Private bIsUnique As Boolean = True
    Private clsGetVariablesMetadataFunction As New RFunction
    Private clsWrapBarFunction, clsWrapPlotFunction, clsGetObjectHeatFunction, clsGetObjectPlotFunction,
    clsGetObjectBarFunction, clsAddObjectHeatFunction, clsAddObjectPlotFunction, clsAddObjectBarFunction,
    clsHeatFunction, clsPlotFunction, clsBarfunction, clsAnnovaFunction, clsSummaryFunction, clsAICFunction,
    clsCoefFunction, clsConfidenLimFunction, clsDevianceFunction, clsEstimatesFunction, clsItemsFunction,
    clsPariPropFunction, clsQuasivarianceFunction, clsReliabilityFunction, clsSecondEstimatesFunction,
    clsStatsFunction, clsRegretFunction, clsTopItemFunction, clsNodeRuleFunction, clsNodeLabFuction,
    clsSndgetVarmataFunction, clsLevelFunction, clsTreeFunction,
    clsFactorFunction, clsGetDataFrameFunction, clsVarianCovaMatrixFunction As New RFunction

    Private clsMapFunction As New RFunction
    Private clsCoefOperator, clsStatsOperator, clsSpaceOpreator, clsAssignOperator As New ROperator

    Private clsGetObjectFunction, clsGetRankingItemsFunction, clsGetColumn,
        clsLevelsFunction, clsFactorsFunction, clsMappingFunction, clsPladmmFunction, clsNamesFunction,
    clsCheckUniqueFunction As New RFunction
    Private clsObjectOperator, clsTildeOperator, clsTilde2Operator, clsBracketOperator,
        clsNamesOperator, clsModelOperator, clsSpaceOperator, clsTilde3Operator As New ROperator


    Private Sub dlgTricotModelOneVarCov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            setDefaults()
        End If

        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 706

        ucrSelectorTraitsRanking.SetParameter(New RParameter("data_name", 0))
        ucrSelectorTraitsRanking.SetParameterIsString()

        ucrTraitsReceiver.SetParameter(New RParameter("x", 0))
        ucrTraitsReceiver.Selector = ucrSelectorTraitsRanking
        ucrTraitsReceiver.SetParameterIsString()
        ucrTraitsReceiver.SetMeAsReceiver()
        ucrTraitsReceiver.strSelectorHeading = "Traits"
        ucrTraitsReceiver.SetTricotType({"traits"})

        ucrSelectorVarietyLevel.SetParameter(New RParameter("data", 3))
        ucrSelectorVarietyLevel.SetParameterIsrfunction()

        ucrVarietyLevelReceiver.SetParameter(New RParameter("c", 0))
        ucrVarietyLevelReceiver.Selector = ucrSelectorVarietyLevel
        ucrVarietyLevelReceiver.SetParameterIsRFunction()
        ucrVarietyLevelReceiver.SetMeAsReceiver()

        ucrTricOneVarSave.SetDataFrameSelector(ucrSelectorVarietyLevel.ucrAvailableDataFrames)
        ucrTricOneVarSave.SetSaveTypeAsModel()
        ucrTricOneVarSave.SetCheckBoxText("Store Model")
        ucrTricOneVarSave.SetIsComboBox()
        ucrTricOneVarSave.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub setDefaults()
        clsGetVariablesMetadataFunction = New RFunction
        clsGetObjectFunction = New RFunction
        clsObjectOperator = New ROperator
        clsSpaceOperator = New ROperator
        clsGetRankingItemsFunction = New RFunction
        clsGetColumn = New RFunction
        clsLevelsFunction = New RFunction
        clsMappingFunction = New RFunction
        clsPladmmFunction = New RFunction
        clsTildeOperator = New ROperator
        clsTilde2Operator = New ROperator
        clsFactorsFunction = New RFunction
        clsBracketOperator = New ROperator
        clsNamesFunction = New RFunction
        clsNamesOperator = New ROperator
        clsModelOperator = New ROperator
        clsCheckUniqueFunction = New RFunction
        clsTilde3Operator = New ROperator

        clsWrapBarFunction = New RFunction
        clsWrapPlotFunction = New RFunction
        clsGetObjectHeatFunction = New RFunction
        clsGetObjectPlotFunction = New RFunction
        clsGetObjectBarFunction = New RFunction
        clsAddObjectHeatFunction = New RFunction
        clsAddObjectPlotFunction = New RFunction
        clsAddObjectBarFunction = New RFunction
        clsHeatFunction = New RFunction
        clsPlotFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsAICFunction = New RFunction
        clsCoefFunction = New RFunction
        clsConfidenLimFunction = New RFunction
        clsDevianceFunction = New RFunction
        clsEstimatesFunction = New RFunction
        clsItemsFunction = New RFunction
        clsPariPropFunction = New RFunction
        clsQuasivarianceFunction = New RFunction
        clsSecondEstimatesFunction = New RFunction
        clsStatsFunction = New RFunction
        clsLevelFunction = New RFunction
        clsFactorFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsVarianCovaMatrixFunction = New RFunction

        clsMapFunction = New RFunction
        clsCoefOperator = New ROperator
        clsStatsOperator = New ROperator
        clsSpaceOpreator = New ROperator
        clsAssignOperator = New ROperator

        ucrTricOneVarSave.Reset()
        ucrSelectorTraitsRanking.Reset()
        ucrSelectorVarietyLevel.Reset()

        bResetSubDialog = True

        ucrInputCheckVariety.SetName("")
        ucrInputCheckVariety.txtInput.BackColor = Color.White
        ucrInputCheckVariety.IsReadOnly = True


        clsCheckUniqueFunction.SetRCommand("check_variety_data_level")

        clsGetVariablesMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadataFunction.SetAssignTo("get_index_names")

        clsGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsObjectOperator.SetOperation("$")
        clsObjectOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectFunction, iPosition:=0)
        clsObjectOperator.AddParameter("right", "object", iPosition:=1)
        clsObjectOperator.SetAssignTo("rankings_object")

        clsSpaceOperator.SetOperation(" ")
        clsSpaceOperator.AddParameter("x", ucrTraitsReceiver.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
        clsSpaceOperator.SetAssignTo("vars")

        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsSpaceOperator, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index ", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("data_object", clsROperatorParameter:=clsObjectOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsGetRankingItemsFunction.SetAssignTo("rankings_object")

        clsGetColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumn.SetAssignTo("column")

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorsFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsFactorsFunction.SetRCommand("factor")
        clsFactorsFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumn, iPosition:=0, bIncludeArgumentName:=False)

        clsBracketOperator.SetOperation("[")
        clsBracketOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsBracketOperator.AddParameter("right", "1]", iPosition:=1)
        clsBracketOperator.SetAssignTo("variety_baseline")

        clsTildeOperator.SetOperation("~")
        clsTildeOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTildeOperator.AddParameter("right", clsRFunctionParameter:=clsPladmmFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", "rankings_object", iPosition:=0)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsTildeOperator, iPosition:=1)
        clsMappingFunction.SetAssignTo("mod_list")

        clsPladmmFunction.SetPackageName("PlackettLuce")
        clsPladmmFunction.SetRCommand("pladmm")
        clsPladmmFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsPladmmFunction.AddParameter("y", clsROperatorParameter:=clsTilde2Operator, iPosition:=1, bIncludeArgumentName:=False)


        clsTilde2Operator.SetOperation("~")
        clsTilde2Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", clsRFunctionParameter:=clsMappingFunction, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, iPosition:=0)
        clsNamesOperator.AddParameter("right", clsROperatorParameter:=clsSpaceOperator, iPosition:=1)

        clsSummaryFunction.SetPackageName("purrr")
        clsSummaryFunction.SetRCommand("map")
        clsSummaryFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsSummaryFunction.AddParameter(".f", "~summary(.x)", iPosition:=1)
        clsSummaryFunction.iCallType = 2

        clsEstimatesFunction.SetPackageName("purrr")
        clsEstimatesFunction.SetRCommand("map")
        clsEstimatesFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsEstimatesFunction.AddParameter(".f", clsROperatorParameter:=clsCoefOperator, iPosition:=1)
        clsEstimatesFunction.iCallType = 2

        clsCoefOperator.SetOperation("~")
        clsCoefOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsCoefOperator.AddParameter("right", clsRFunctionParameter:=clsCoefFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsCoefFunction.SetRCommand("coef")
        clsCoefFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsCoefFunction.AddParameter("log", "T/F", iPosition:=1)

        clsConfidenLimFunction.SetPackageName("purrr")
        clsConfidenLimFunction.SetRCommand("map")
        clsConfidenLimFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsConfidenLimFunction.AddParameter(".f", clsROperatorParameter:=clsStatsOperator, iPosition:=1)
        clsConfidenLimFunction.iCallType = 2

        clsStatsOperator.SetOperation("~")
        clsStatsOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsStatsOperator.AddParameter("right", clsRFunctionParameter:=clsStatsFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsStatsFunction.SetPackageName("stats")
        clsStatsFunction.SetRCommand("confint")
        clsStatsFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsStatsFunction.AddParameter("level", "0.95", iPosition:=1)

        clsAICFunction.SetPackageName("purrr")
        clsAICFunction.SetRCommand("map")
        clsAICFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsAICFunction.AddParameter(".f", "~AIC(.x)", iPosition:=1)
        clsAICFunction.iCallType = 2

        clsDevianceFunction.SetPackageName("purrr")
        clsDevianceFunction.SetRCommand("map")
        clsDevianceFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsDevianceFunction.AddParameter(".f", "~deviance(.x)", iPosition:=1)
        clsDevianceFunction.iCallType = 2

        clsSecondEstimatesFunction.SetPackageName("purrr")
        clsSecondEstimatesFunction.SetRCommand("map")
        clsSecondEstimatesFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsSecondEstimatesFunction.AddParameter(".f", "~fitted.values(.x)", iPosition:=1)
        clsSecondEstimatesFunction.iCallType = 2

        clsPariPropFunction.SetPackageName("purrr")
        clsPariPropFunction.SetRCommand("map")
        clsPariPropFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsPariPropFunction.AddParameter(".f", "~gosset::pairwise_probs(coef(.x))", iPosition:=1)
        clsPariPropFunction.iCallType = 2

        clsItemsFunction.SetPackageName("purrr")
        clsItemsFunction.SetRCommand("map")
        clsItemsFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsItemsFunction.AddParameter(".f", "~PlackettLuce::itempar(.x)", iPosition:=1)
        clsItemsFunction.iCallType = 2

        clsVarianCovaMatrixFunction.SetPackageName("purrr")
        clsVarianCovaMatrixFunction.SetRCommand("map")
        clsVarianCovaMatrixFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsVarianCovaMatrixFunction.AddParameter(".f", "~vcov(.x)", iPosition:=1)
        clsVarianCovaMatrixFunction.iCallType = 2

        'Heatmap
        clsHeatFunction.SetPackageName("gosset")
        clsHeatFunction.SetRCommand("worth_map")
        clsHeatFunction.AddParameter(".x", "mod_list", iPosition:=0, bIncludeArgumentName:=False)
        clsHeatFunction.AddParameter("labels", "names(mod_list)", iPosition:=1)
        clsHeatFunction.AddParameter("ref", "variety_baseline", iPosition:=2)
        clsHeatFunction.SetAssignTo("last_graph")

        clsAddObjectHeatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddObjectHeatFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsAddObjectHeatFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddObjectHeatFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddObjectHeatFunction.AddParameter("object", "instatExtras::check_graph(graph_object=last_graph)", iPosition:=4)

        clsGetObjectHeatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectHeatFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsGetObjectHeatFunction.AddParameter("as_file", "TRUE", iPosition:=2)


        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod_list", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorVarietyLevel.strCurrentDataFrame,
                                                  strObjectName:="last_model")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetRankingItemsFunction, iPosition:=3)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsBracketOperator, iPosition:=4)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=5)
        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)

    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsGetVariablesMetadataFunction, ucrSelectorTraitsRanking.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsAddObjectHeatFunction, New RParameter("data_name", 0), iAdditionalPairNo:=2)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsGetObjectHeatFunction, New RParameter("data_name", 0), iAdditionalPairNo:=3)


        ucrSelectorTraitsRanking.SetRCode(clsGetObjectFunction, bReset)
        ucrSelectorVarietyLevel.SetRCode(clsPladmmFunction, bReset)
        ucrTraitsReceiver.SetRCode(clsSpaceOperator, bReset)
        ucrTricOneVarSave.SetRCode(clsModelOperator, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrTraitsReceiver.IsEmpty AndAlso Not ucrVarietyLevelReceiver.IsEmpty AndAlso
            ucrTricOneVarSave.IsComplete AndAlso Not ucrInputCheckVariety.IsEmpty AndAlso bIsUnique = True Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitsReceiver.ControlContentsChanged, ucrVarietyLevelReceiver.ControlContentsChanged,
        ucrTricOneVarSave.ControlContentsChanged, ucrSelectorVarietyLevel.ControlContentsChanged
        TestOkEnabled()
    End Sub
    Private Sub ucrVarietyLevelReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrVarietyLevelReceiver.ControlValueChanged
        clsTilde2Operator.AddParameter("right", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)
        clsGetColumn.AddParameter("col_name", ucrVarietyLevelReceiver.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
        CheckVarietyUnique()
    End Sub

    Private Sub CheckVarietyUnique()
        Dim iAnyDuplicated As Integer
        If Not ucrVarietyLevelReceiver.IsEmpty Then
            Try
                iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsCheckUniqueFunction.ToScript()).AsInteger(0)
            Catch ex As Exception
                iAnyDuplicated = 0
            End Try

            If iAnyDuplicated = 0 Then
                ucrInputCheckVariety.SetName("Model fails. There is no variety variable that is Tricot-Defined in this data.")
                ucrInputCheckVariety.txtInput.BackColor = Color.Coral
                bIsUnique = False
            ElseIf iAnyDuplicated = 1 Then
                ucrInputCheckVariety.SetName("Model fails. No key columns are defined in the dataset.")
                ucrInputCheckVariety.txtInput.BackColor = Color.Coral
                bIsUnique = False

            ElseIf iAnyDuplicated = 2 Then
                ucrInputCheckVariety.SetName("Model fails. Only variety level data can be used for this data. This is data where there is a unique row for each variety given.")
                ucrInputCheckVariety.txtInput.BackColor = Color.Coral
                bIsUnique = False
            Else
                ucrInputCheckVariety.SetName("Model runs OK.")
                ucrInputCheckVariety.txtInput.BackColor = Color.LightGreen
                bIsUnique = True
            End If

        Else
            ucrInputCheckVariety.SetName("")
            ucrInputCheckVariety.txtInput.BackColor = Color.White
        End If
    End Sub

    Private Sub ucrSelectorVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVarietyLevel.ControlValueChanged
        clsGetColumn.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsCheckUniqueFunction.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
    End Sub

    Private Sub btnModelOptions_Click(sender As Object, e As EventArgs) Handles btnModelOptions.Click
        sdgTricotModelOptions.SetRCode(clsNewRFunction:=clsPladmmFunction, clsNewRSyntax:=ucrBase.clsRsyntax, bReset:=bResetSubDialog)

        sdgTricotModelOptions.ShowDialog(Me)

        bResetSubDialog = False
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles btnDisplayOptions.Click
        sdgDisplayModelOptions.SetRCode(clsNewWrapBarFunction:=clsWrapBarFunction, clsNewWrapPlotFunction:=clsWrapPlotFunction,
                                        clsNewHeatFunction:=clsHeatFunction, clsNewPlotFunction:=clsPlotFunction, clsNewBarfunction:=clsBarfunction,
                                        clsNewAnnovaFunction:=clsAnnovaFunction, clsNewSummaryFunction:=clsSummaryFunction, clsNewAICFunction:=clsAICFunction,
                                        clsNewCoefFunction:=clsCoefFunction, clsNewConfidenLimFunction:=clsConfidenLimFunction,
                                        clsNewDevianceFunction:=clsDevianceFunction, clsNewEstimatesFunction:=clsEstimatesFunction, clsNewItemsFunction:=clsItemsFunction,
                                        clsNewPariPropFunction:=clsPariPropFunction, clsNewQuasivarianceFunction:=clsQuasivarianceFunction, clsNewReliabilityFunction:=clsReliabilityFunction,
                                        clsNewRSyntax:=ucrBase.clsRsyntax, clsNewSecondEstimatesFunction:=clsSecondEstimatesFunction, clsNewStatsFunction:=clsStatsFunction, clsNewRegretFunction:=clsRegretFunction,
                                        clsNewTopItemFunction:=clsTopItemFunction, clsNewNodeRuleFunction:=clsNodeRuleFunction, clsNewNodeLabFuction:=clsNodeLabFuction,
                                        clsNewVarianCovaMatrixFunction:=clsVarianCovaMatrixFunction, clsNewTreeFunction:=clsTreeFunction, bReset:=bResetSubDialog)
        sdgDisplayModelOptions.ucrChkANOVA.Enabled = False
        sdgDisplayModelOptions.ucrChkReability.Enabled = False
        sdgDisplayModelOptions.ucrChkQuasiVa.Enabled = False
        sdgDisplayModelOptions.ucrChkRegret.Enabled = False
        sdgDisplayModelOptions.ucrChkNodeLabel.Enabled = False
        sdgDisplayModelOptions.ucrChkNodeRules.Enabled = False
        sdgDisplayModelOptions.ucrChkTopItem.Enabled = False

        sdgDisplayModelOptions.rdoPlot.Enabled = False
        sdgDisplayModelOptions.rdoBar.Enabled = False
        sdgDisplayModelOptions.rdoTree.Enabled = False
        sdgDisplayModelOptions.ShowDialog()
        bResetSubDialog = False
        AddRemoveFunctions()
    End Sub
    Private Sub AddRemoveFunctions()
        If sdgDisplayModelOptions.rdoMap.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=6)
        Else
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=6)
        End If
    End Sub
End Class
