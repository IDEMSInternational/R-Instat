
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

Public Class dlgTricotModellingGeneral

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubDialog As Boolean = True

    Private bIsUnique As Boolean = True
    Private clsGetVariablesMetadataFunction As New RFunction
    Private clsGetObjectFunction, clsGetRankingItemsFunction, clsGetDataFrameFunction, clsGetColumn,
            clsLevelsFunction, clsFactorsFunction, clsMappingFunction, clsPladmmFunction, clsNamesFunction,
            clsCheckUniqueFunction, clsGetVariablesFromMetaDataFunction, clsFactorFunction, clsSummaryFunction, clscoefFunction,
            clsEstimatesFunction, clsSecondEstimatesFunction, clsDevianceFunction, clsDevianceMainFunction, clsPairwiseProbFunction,
            clsPairwiseProbMainFunction, clsReliabilityFunction, clsItemsParFunction, clsRegretFunction, clsNodeLabelsFunction,
            clsNodeRulesFunction, clsTopItemsFunction, clsAICFunction, clsUnListAICFunction, clsAICMainFunction, clsAnnovaFunction,
            clsConfidenLimFunction, clsStatsFunction, clsQuasivarianceFunction, clsVarianCovaMatrixFunction, clsGetObjectPlotFunction,
            clsGetObjectBarFunction, clsAddObjectHeatFunction, clsAddObjectPlotFunction, clsAddObjectBarFunction, clsHeatFunction,
            clsPlotFunction, clsBarfunction, clsWrapPlotFunction, clsWrapBarFunction As New RFunction
    Private clsObjectOperator, clsTildeOperator, clsTilde2Operator, clsBracketOperator, clsDevianceOperator, clsPairwiseProbOperator,
            clsNamesOperator, clsModelOperator, clsSpaceOperator, clsTilde3Operator, clsEmptySpaceOperator, clsCoefOperator,
            clsAICOperator, clsStatsOperator As New ROperator

    Private Sub dlgTricotModellingGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 707
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2

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

        ucrReceiverExpressionModellingGeneral.SetParameter(New RParameter("y", 2))
        ucrReceiverExpressionModellingGeneral.SetParameterIsString()
        ucrReceiverExpressionModellingGeneral.bWithQuotes = False
        ucrReceiverExpressionModellingGeneral.AddtoCombobox("1")
        ucrReceiverExpressionModellingGeneral.strSelectorHeading = "Variety Level Data"

        ucrSaveModellingGeneral.SetDataFrameSelector(ucrSelectorVarietyLevel.ucrAvailableDataFrames)
        ucrSaveModellingGeneral.SetSaveTypeAsModel()
        ucrSaveModellingGeneral.SetCheckBoxText("Store Model")
        ucrSaveModellingGeneral.SetIsComboBox()
        ucrSaveModellingGeneral.SetPrefix("gen_model")
        ucrSaveModellingGeneral.SetAssignToIfUncheckedValue("last_model")

        btnModelOptions.Enabled = False
        btnDisplayOptions.Enabled = True
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
        clsGetVariablesFromMetaDataFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clscoefFunction = New RFunction
        clsTildeOperator = New ROperator
        clsTilde2Operator = New ROperator
        'clsFactorsFunction = New RFunction
        clsEmptySpaceOperator = New ROperator
        clsFactorFunction = New RFunction
        clsAICMainFunction = New RFunction
        clsBracketOperator = New ROperator
        clsNamesFunction = New RFunction
        clsNamesOperator = New ROperator
        clsModelOperator = New ROperator
        'clsCheckUniqueFunction = New RFunction
        clsTilde3Operator = New ROperator

        ' Sub Dialogs
        '-----------------------------------------------------------------------------------------------------
        clsSummaryFunction = New RFunction
        clsAICOperator = New ROperator
        clsCoefOperator = New ROperator
        clsStatsOperator = New ROperator
        clsEstimatesFunction = New RFunction
        clsSecondEstimatesFunction = New RFunction
        clsItemsParFunction = New RFunction
        clsPairwiseProbFunction = New RFunction
        clsPairwiseProbMainFunction = New RFunction
        clsPairwiseProbOperator = New ROperator
        clsDevianceFunction = New RFunction
        clsDevianceOperator = New ROperator
        clsDevianceMainFunction = New RFunction
        clsReliabilityFunction = New RFunction
        clsNodeLabelsFunction = New RFunction
        clsConfidenLimFunction = New RFunction
        clsRegretFunction = New RFunction
        clsAnnovaFunction = New RFunction
        clsAICFunction = New RFunction
        clsNodeRulesFunction = New RFunction
        clsTopItemsFunction = New RFunction
        clsUnListAICFunction = New RFunction
        clsStatsFunction = New RFunction
        clsQuasivarianceFunction = New RFunction
        clsVarianCovaMatrixFunction = New RFunction
        clsGetObjectPlotFunction = New RFunction
        clsGetObjectBarFunction = New RFunction
        clsAddObjectHeatFunction = New RFunction
        clsAddObjectPlotFunction = New RFunction
        clsAddObjectBarFunction = New RFunction
        clsHeatFunction = New RFunction
        clsPlotFunction = New RFunction
        clsBarfunction = New RFunction
        clsWrapPlotFunction = New RFunction
        clsWrapBarFunction = New RFunction

        bResetSubDialog = True

        ucrSaveModellingGeneral.Reset()
        ucrSelectorTraitsRanking.Reset()
        ucrSelectorVarietyLevel.Reset()

        ucrReceiverExpressionModellingGeneral.Selector = ucrSelectorVarietyLevel

        ucrInputCheckVariety.SetName("")
        ucrInputCheckVariety.txtInput.BackColor = Color.White
        ucrInputCheckVariety.IsReadOnly = True

        'clsCheckUniqueFunction.SetRCommand("check_variety_data_level")

        clsGetVariablesMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadataFunction.SetAssignTo("get_index_names")


        clsGetVariablesFromMetaDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVariablesFromMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorTraitsRanking.strCurrentDataFrame & Chr(34))
        clsGetVariablesFromMetaDataFunction.AddParameter("property", Chr(34) & "Tricot_Type" & Chr(34))
        clsGetVariablesFromMetaDataFunction.AddParameter("property_value", Chr(34) & "variety" & Chr(34))
        clsGetVariablesFromMetaDataFunction.SetAssignTo("var_name")

        clsGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsObjectOperator.SetOperation("$")
        clsObjectOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectFunction, iPosition:=0)
        clsObjectOperator.AddParameter("right", "object", iPosition:=1)
        clsObjectOperator.SetAssignTo("rankings_object")
        clsObjectOperator.bSpaceAroundOperation = False

        clsSpaceOperator.SetOperation("")
        clsSpaceOperator.AddParameter("x", ucrTraitsReceiver.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
        clsSpaceOperator.SetAssignTo("vars")

        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsSpaceOperator, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index ", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("data_object", clsROperatorParameter:=clsObjectOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsGetRankingItemsFunction.SetAssignTo("rankings_object")

        'clsGetColumn.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        'clsGetColumn.SetAssignTo("column")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("data", Chr(34) & ucrSelectorTraitsRanking.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorTraitsRanking.strCurrentDataFrame)

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", ucrSelectorTraitsRanking.strCurrentDataFrame & "[[var_name]]", bIncludeArgumentName:=False)

        clsEmptySpaceOperator.SetOperation("")
        clsEmptySpaceOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.AddParameter("right", "[1]", bIncludeArgumentName:=False)
        clsEmptySpaceOperator.SetAssignTo("variety_baseline")
        clsEmptySpaceOperator.bSpaceAroundOperation = False

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorFunction, iPosition:=0, bIncludeArgumentName:=False)

        'clsFactorsFunction.SetRCommand("factor")
        'clsFactorsFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumn, iPosition:=0, bIncludeArgumentName:=False)

        clsBracketOperator.SetOperation("[")
        clsBracketOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, iPosition:=0)
        clsBracketOperator.AddParameter("right", "1]", iPosition:=1)
        clsBracketOperator.SetAssignTo("variety_baseline")
        clsBracketOperator.bSpaceAroundOperation = False

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

        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod_list", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorVarietyLevel.strCurrentDataFrame,
                                                  strObjectName:="last_model")


        ' SUB DIALOG FUNCTIONS
        '----------------------------------------------------------------------------------------------------------------------
        clsSummaryFunction.SetPackageName("purrr")
        clsSummaryFunction.SetRCommand("map")
        clsSummaryFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsSummaryFunction.AddParameter(".f", "~summary(.x)", iPosition:=1)
        clsSummaryFunction.iCallType = 2

        clsCoefOperator.SetOperation("~")
        clsCoefOperator.AddParameter("left", "", bIncludeArgumentName:=False, iPosition:=0)
        clsCoefOperator.AddParameter("right", clsRFunctionParameter:=clscoefFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsCoefOperator.bSpaceAroundOperation = False

        clscoefFunction.SetRCommand("coef")
        clscoefFunction.AddParameter("x", ".x", bIncludeArgumentName:=False)

        clsEstimatesFunction.SetPackageName("purrr")
        clsEstimatesFunction.SetRCommand("map")
        clsEstimatesFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsEstimatesFunction.AddParameter(".f", clsROperatorParameter:=clsCoefOperator, iPosition:=1)
        clsEstimatesFunction.iCallType = 2

        clsSecondEstimatesFunction.SetPackageName("purrr")
        clsSecondEstimatesFunction.SetRCommand("map")
        clsSecondEstimatesFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsSecondEstimatesFunction.AddParameter(".f", "~fitted.values(.x)", iPosition:=1)
        clsSecondEstimatesFunction.iCallType = 2

        clsDevianceFunction.SetRCommand("deviance")
        clsDevianceFunction.AddParameter("x", ".x", bIncludeArgumentName:=False)

        clsDevianceOperator.SetOperation("~")
        clsDevianceOperator.AddParameter("left", "", bIncludeArgumentName:=False, iPosition:=0)
        clsDevianceOperator.AddParameter("right", clsRFunctionParameter:=clsDevianceFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsDevianceMainFunction.SetPackageName("purrr")
        clsDevianceMainFunction.SetRCommand("map")
        clsDevianceMainFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsDevianceMainFunction.AddParameter(".f", clsROperatorParameter:=clsDevianceOperator, iPosition:=1)
        clsDevianceMainFunction.iCallType = 2

        clsPairwiseProbFunction.SetPackageName("gosset")
        clsPairwiseProbFunction.SetRCommand("pairwise_probs")
        clsPairwiseProbFunction.AddParameter("x", clsRFunctionParameter:=clscoefFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsPairwiseProbOperator.SetOperation("~")
        clsPairwiseProbOperator.AddParameter("left", "", bIncludeArgumentName:=False, iPosition:=0)
        clsPairwiseProbOperator.AddParameter("right", clsRFunctionParameter:=clsPairwiseProbFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsPairwiseProbOperator.bSpaceAroundOperation = False

        clsPairwiseProbMainFunction.SetPackageName("purrr")
        clsPairwiseProbMainFunction.SetRCommand("map")
        clsPairwiseProbMainFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsPairwiseProbMainFunction.AddParameter(".f", clsROperatorParameter:=clsPairwiseProbOperator, iPosition:=1)

        'clsReliabilityFunction.SetPackageName("purrr")
        'clsReliabilityFunction.SetRCommand("map")
        'clsReliabilityFunction.AddParameter(".x", "purrr::imap(.x = mod_list,  .f = ~gosset::reliability(.x, ref = variety_baseline[1]))", iPosition:=0)
        'clsReliabilityFunction.AddParameter(".f", "~ .x %>% dplyr::mutate(reliability_rescaled = round(reliability / 0.5 - 1, 2))", iPosition:=1)
        'clsReliabilityFunction.iCallType = 2

        clsItemsParFunction.SetPackageName("purrr")
        clsItemsParFunction.SetRCommand("map")
        clsItemsParFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsItemsParFunction.AddParameter(".f", "~PlackettLuce::itempar(.x)", iPosition:=1)
        clsItemsParFunction.iCallType = 2

        'clsRegretFunction.SetPackageName("purrr")
        'clsRegretFunction.SetRCommand("map")
        'clsRegretFunction.AddParameter(".x", "mod_list", iPosition:=0)
        'clsRegretFunction.AddParameter(".f", "~gosset::regret(.x)", iPosition:=1)
        'clsRegretFunction.iCallType = 2

        'clsNodeLabelsFunction.SetPackageName("purrr")
        'clsNodeLabelsFunction.SetRCommand("map")
        'clsNodeLabelsFunction.AddParameter(".x", "mod_list")
        'clsNodeLabelsFunction.AddParameter(".f", "~gosset::node_labels(.x)")
        'clsNodeLabelsFunction.iCallType = 2

        'clsNodeRulesFunction.SetPackageName("purrr")
        'clsNodeRulesFunction.SetRCommand("map")
        'clsNodeRulesFunction.AddParameter(".x", "mod_list")
        'clsNodeRulesFunction.AddParameter(".f", "~gosset::node_rules(.x)")
        'clsNodeRulesFunction.iCallType = 2

        'clsTopItemsFunction.SetPackageName("purrr")
        'clsTopItemsFunction.SetRCommand("map")
        'clsTopItemsFunction.AddParameter(".x", "mod_list")
        'clsTopItemsFunction.AddParameter(".f", "~gosset::top_items(.x, top = 3))")
        'clsTopItemsFunction.iCallType = 2

        clsAICFunction.SetRCommand("AIC")
        clsAICFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)

        clsUnListAICFunction.SetRCommand("unlist")
        clsUnListAICFunction.AddParameter("x", clsRFunctionParameter:=clsAICMainFunction, bIncludeArgumentName:=False)
        clsUnListAICFunction.SetAssignTo("aic_list")

        clsAICOperator.SetOperation("~")
        clsAICOperator.AddParameter("left", "", bIncludeArgumentName:=False, iPosition:=0)
        clsAICOperator.AddParameter("right", clsRFunctionParameter:=clsAICFunction, bIncludeArgumentName:=False, iPosition:=1)
        clsAICOperator.bSpaceAroundOperation = False

        clsAICMainFunction.SetPackageName("purrr")
        clsAICMainFunction.SetRCommand("map")
        clsAICMainFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsAICMainFunction.AddParameter(".f", clsROperatorParameter:=clsAICOperator, iPosition:=1)
        clsAICMainFunction.icallType = 2

        'clsAnnovaFunction.SetPackageName("purrr")
        'clsAnnovaFunction.SetRCommand("map")
        'clsAnnovaFunction.AddParameter(".x", "mod_list", iPosition:=0)
        'clsAnnovaFunction.AddParameter(".f", "~gosset:::anova.PlackettLuce(.x)", iPosition:=1)
        'clsAnnovaFunction.iCallType = 2

        clsStatsFunction.SetPackageName("stats")
        clsStatsFunction.SetRCommand("confint")
        clsStatsFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsStatsFunction.AddParameter("level", "0.95", iPosition:=1)

        clsStatsOperator.SetOperation("~")
        clsStatsOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsStatsOperator.AddParameter("right", clsRFunctionParameter:=clsStatsFunction, iPosition:=1, bIncludeArgumentName:=False)


        clsConfidenLimFunction.SetPackageName("purrr")
        clsConfidenLimFunction.SetRCommand("map")
        clsConfidenLimFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsConfidenLimFunction.AddParameter(".f", clsROperatorParameter:=clsStatsOperator, iPosition:=1)
        clsConfidenLimFunction.iCallType = 2

        'clsQuasivarianceFunction.SetPackageName("purrr")
        'clsQuasivarianceFunction.SetRCommand("map")
        'clsQuasivarianceFunction.AddParameter(".x", "mod_list", iPosition:=0)
        'clsQuasivarianceFunction.AddParameter(".f", "~qvcalc::qvcalc(PlackettLuce::itempar(.x))", iPosition:=1)
        'clsQuasivarianceFunction.iCallType = 2

        clsVarianCovaMatrixFunction.SetPackageName("purrr")
        clsVarianCovaMatrixFunction.SetRCommand("map")
        clsVarianCovaMatrixFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsVarianCovaMatrixFunction.AddParameter(".f", "~vcov(.x)", iPosition:=1)
        clsVarianCovaMatrixFunction.iCallType = 2


        ' PLOT FUNCTIONS
        '-------------------------------------------------------------------------------------------------------------------
        clsGetObjectPlotFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectPlotFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsGetObjectPlotFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        clsGetObjectBarFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectBarFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsGetObjectBarFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        clsAddObjectHeatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddObjectHeatFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsAddObjectHeatFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddObjectHeatFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddObjectHeatFunction.AddParameter("object", "instatExtras::check_graph(graph_object=last_graph)", iPosition:=4)

        clsAddObjectPlotFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddObjectPlotFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsAddObjectPlotFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddObjectPlotFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddObjectPlotFunction.AddParameter("object", "instatExtras::check_graph(graph_object=last_graph)", iPosition:=4)

        clsAddObjectBarFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddObjectBarFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsAddObjectBarFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddObjectBarFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddObjectBarFunction.AddParameter("object", "instatExtras::check_graph(graph_object=last_graph)", iPosition:=4)

        clsHeatFunction.SetPackageName("gosset")
        clsHeatFunction.SetRCommand("worth_map")
        clsHeatFunction.AddParameter(".x", "mod_list", iPosition:=0, bIncludeArgumentName:=False)
        clsHeatFunction.AddParameter("labels", "names(mod)", iPosition:=1)
        clsHeatFunction.SetAssignTo("last_graph")

        clsPlotFunction.SetPackageName("purrr")
        clsPlotFunction.SetRCommand("map2")
        clsPlotFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsPlotFunction.AddParameter(".y", "names(mod)", iPosition:=1)
        clsPlotFunction.AddParameter(".f", "~gosset:::plot.PlackettLuce(x = .x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsPlotFunction.SetAssignTo("list_of_plots")

        clsBarfunction.SetPackageName("purrr")
        clsBarfunction.SetRCommand("map2")
        clsBarfunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsBarfunction.AddParameter(".y", "names(mod)", iPosition:=1)
        clsBarfunction.AddParameter(".f", "~gosset::worth_bar(.x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsBarfunction.SetAssignTo("list_of_plots")

        clsWrapPlotFunction.SetPackageName("patchwork")
        clsWrapPlotFunction.SetRCommand("wrap_plots")
        clsWrapPlotFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapPlotFunction.SetAssignTo("last_graph")

        clsWrapBarFunction.SetPackageName("patchwork")
        clsWrapBarFunction.SetRCommand("wrap_plots")
        clsWrapBarFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapBarFunction.SetAssignTo("last_graph")



        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetRankingItemsFunction, iPosition:=3)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction, iPosition:=4)
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumn)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetVariablesFromMetaDataFunction, iPosition:=5)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsBracketOperator, iPosition:=6)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=7)

        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)

    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsGetVariablesMetadataFunction, ucrSelectorTraitsRanking.GetParameter())

        ucrSelectorTraitsRanking.SetRCode(clsGetObjectFunction, bReset)
        ucrSelectorVarietyLevel.SetRCode(clsPladmmFunction, bReset)
        ucrTraitsReceiver.SetRCode(clsSpaceOperator, bReset)
        ucrSaveModellingGeneral.SetRCode(clsModelOperator, bReset)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrTraitsReceiver.IsEmpty AndAlso Not ucrReceiverExpressionModellingGeneral.IsEmpty AndAlso
            ucrSaveModellingGeneral.IsComplete AndAlso Not ucrInputCheckVariety.IsEmpty AndAlso bIsUnique = True Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If
    End Sub


    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("( )", 2)
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("I()", 1)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverExpressionModellingGeneral.Clear()
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("sqrt( )", 2)
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("cos( )", 2)
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("log( )", 2)
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("sin( )", 2)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs) Handles cmdExp.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("exp( )", 2)
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        ucrReceiverExpressionModellingGeneral.AddToReceiverAtCursorPosition("tan( )", 2)
    End Sub



    Private Sub btnDisplayOptions_Click(sender As Object, e As EventArgs) Handles btnDisplayOptions.Click
        sdgDisplayModelOptions.SetRCode(clsNewSummaryFunction:=clsSummaryFunction, clsNewCoefOperator:=clsCoefOperator,
            clsNewCoefFunction:=clscoefFunction, clsNewSecondEstimatesFunction:=clsSecondEstimatesFunction,
            clsNewEstimatesFunction:=clsEstimatesFunction, clsNewDevianceFunction:=clsDevianceMainFunction,
            clsNewPariPropFunction:=clsPairwiseProbMainFunction, clsNewReliabilityFunction:=clsReliabilityFunction,
            clsNewItemsFunction:=clsItemsParFunction, clsNewRegretFunction:=clsRegretFunction, clsNewNodeLabFuction:=clsNodeLabelsFunction,
            clsNewNodeRuleFunction:=clsNodeRulesFunction, clsNewTopItemFunction:=clsTopItemsFunction, clsNewRSyntax:=ucrBase.clsRsyntax, clsNewAICFunction:=clsUnListAICFunction,
            clsNewSpaceOperator:=clsEmptySpaceOperator, clsNewLevelFunction:=clsLevelsFunction, clsNewGetDataFrameFunction:=clsGetDataFrameFunction,
            clsNewFactorFunction:=clsFactorFunction, clsNewAssigneOperator:=clsNamesOperator, bReset:=bResetSubDialog, clsNewAnnovaFunction:=clsAnnovaFunction,
            clsNewConfidenLimFunction:=clsConfidenLimFunction, clsNewStatsFunction:=clsStatsFunction, clsNewStatsOperator:=clsStatsOperator,
            clsNewQuasivarianceFunction:=clsQuasivarianceFunction, clsNewSndgetVarmataFunction:=clsGetVariablesFromMetaDataFunction,
            clsNewVarianCovaMatrixFunction:=clsVarianCovaMatrixFunction, clsNewGetObjectPlotFunction:=clsGetObjectPlotFunction,
            clsNewGetObjectBarFunction:=clsGetObjectBarFunction, clsNewAddObjectHeatFunction:=clsAddObjectHeatFunction, clsNewAddObjectPlotFunction:=clsAddObjectPlotFunction,
            clsNewAddObjectBarFunction:=clsAddObjectBarFunction, clsNewHeatFunction:=clsHeatFunction, clsNewPlotFunction:=clsPlotFunction, clsNewBarfunction:=clsBarfunction,
            clsNewWrapPlotFunction:=clsWrapPlotFunction, clsNewWrapBarFunction:=clsWrapBarFunction, clsNewGetObjectHeatFunction:=clsHeatFunction
        )
        sdgDisplayModelOptions.ucrChkANOVA.Enabled = False
        sdgDisplayModelOptions.ucrChkReability.Enabled = False
        sdgDisplayModelOptions.ucrChkQuasiVa.Enabled = False
        sdgDisplayModelOptions.ucrChkRegret.Enabled = False
        sdgDisplayModelOptions.ucrChkNodeLabel.Enabled = False
        sdgDisplayModelOptions.ucrChkNodeRules.Enabled = False
        sdgDisplayModelOptions.ucrChkTopItem.Enabled = False

        sdgDisplayModelOptions.ShowDialog()
        bResetSubDialog = False
    End Sub



    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitsReceiver.ControlContentsChanged,
        ucrSaveModellingGeneral.ControlContentsChanged, ucrSelectorVarietyLevel.ControlContentsChanged
        TestOkEnabled()
    End Sub


    '----------------------------------------------------------------------------------------------'
    'REVIEW THIS FUNCTION
    Private Sub ucrVarietyLevelReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionModellingGeneral.ControlValueChanged
        clsTilde2Operator.AddParameter("right", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)
        'clsGetColumn.AddParameter("col_name", ucrReceiverExpressionModellingGeneral.GetText, iPosition:=1, bIncludeArgumentName:=False)

    End Sub


    Private Sub ucrSelectorTraitsRanking_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTraitsRanking.ControlValueChanged

        If clsGetVariablesFromMetaDataFunction.ContainsParameter("data_name") Then
            clsGetVariablesFromMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorTraitsRanking.strCurrentDataFrame & Chr(34))
        End If
        If clsGetDataFrameFunction.ContainsParameter("data") Then
            clsFactorFunction.AddParameter("x", ucrSelectorTraitsRanking.strCurrentDataFrame & "[[var_name]]", bIncludeArgumentName:=False)
            clsGetDataFrameFunction.AddParameter("data", Chr(34) & ucrSelectorTraitsRanking.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If

        clsGetDataFrameFunction.SetAssignTo(ucrSelectorTraitsRanking.strCurrentDataFrame)
    End Sub

    Private Sub cmdCheckVariety_Click(sender As Object, e As EventArgs) Handles cmdCheckVariety.Click
        Dim chrOutput As CharacterVector
        Dim clsPackageCheck As New RFunction
        Dim expOutput As SymbolicExpression


        ' Resetting the background color of the input control 
        ucrInputCheckVariety.txtInput.BackColor = Color.White

        clsPackageCheck.SetPackageName("databook")
        clsPackageCheck.SetRCommand("check_variety_data_level")
        clsPackageCheck.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34))

        expOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsPackageCheck.ToScript())


        If expOutput Is Nothing OrElse expOutput.Type = RDotNet.Internals.SymbolicExpressionType.Null Then
            ucrInputCheckVariety.SetName("Model fails. There is no variety variable that is Tricot-Defined in this data.")
            Exit Sub
        End If

        chrOutput = expOutput.AsCharacter()
        If chrOutput.Count < 1 Then
            ucrInputCheckVariety.SetText("Cannot get data information.")
            ucrInputCheckVariety.txtInput.BackColor = Color.White
            Exit Sub
        End If
        Select Case chrOutput(0)
            Case "0"
                bIsUnique = False
                ucrInputCheckVariety.SetName("Model fails. There is no variety variable that is Tricot-Defined in this data.")
                ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            Case "1"
                bIsUnique = False
                ucrInputCheckVariety.SetName("Model fails. No key columns are defined in the dataset.")
                ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            Case "2"
                bIsUnique = False
                ucrInputCheckVariety.SetName("Model fails. Only variety level data can be used for this data. This is data where there is a unique row for each variety given.")
                ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            Case "3"
                bIsUnique = True
                ucrInputCheckVariety.SetName("Model runs OK.")
                ucrInputCheckVariety.txtInput.BackColor = Color.LightGreen
        End Select
        TestOkEnabled()
    End Sub

End Class