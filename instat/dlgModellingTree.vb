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

Public Class dlgModellingTree

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = False
    Private bUniqueChecked As Boolean = False
    Public clsFormulaOperator As New ROperator

    Public clsRConvert As New RFunction

    Private clsFactorFunction, clsLevelsFunction, clsMappingFunction, clsPlackettLuceFunction As New RFunction
    Private clsGetVariablesMetaDataFunction, clsRGetObjectFunction, clsGetRankingItemsFunction, clsNamesFunction As New RFunction
    Private clsGetDataFrameFunction, clsGetVariablesFromMetaDataFunction, clsGetSecondDataFrameFunction, clsLibraryFunction As New RFunction
    Private clsTildaOperator, clsRankingsOperator, clsEmptySpaceOperator, clsFormularTildaOperator, clsVarOperator, clsAssignOperator, clsSaveOperator As New ROperator

    'Sub dialog Functions and Operators
    Private clsSummaryFunction, clsEstimatesFunction, clscoefFunction, clsUnListAICFunction, clsAICFunction, clsAICMainFunction As New RFunction
    Private clsDevianceFunction, clsDevianceMainFunction, clsSecondEstimatesFunction As New RFunction
    Private clsRegretFunction, clsNodeLabelsFunction, clsNodeRulesFunction, clsTopItemsFunction As New RFunction
    Private clsPairwiseProbFunction, clsPairwiseProbMainFunction, clsReliabilityFunction, clsItemsParFunction As New RFunction
    Private clsCoefOperator, clsAICOperator, clsDevianceOperator, clsPairwiseProbOperator, clsStatsOperator, clsModelOperator, clsPipeOperator As New ROperator
    Private clsAnnovaFunction, clsConfidenLimFunction, clsStatsFunction, clsQuasivarianceFunction, clsVarianCovaMatrixFunction As New RFunction
    Private clsWrapBarFunction, clsWrapPlotFunction, clsPlacketFunction, clsWrapTrees As New RFunction

    Private clsAddObjectHeatFunction, clsHeatFunction, clsTreeFunction, clsImportDataFunction, clsDefineAsTricotFunction As New RFunction
    Private clsPlotFunction, clsBarfunction As New RFunction

    Public bResetSubDialog As Boolean = False

    Private dctPlotFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgFitModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
            bUniqueChecked = False
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
        ucrBase.iHelpTopicID = 705
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorByDataFrameAddRemoveForModellingTree.SetParameter(New RParameter("data", 0))
        ucrSelectorByDataFrameAddRemoveForModellingTree.SetParameterIsrfunction()

        UcrSelectorByDataFrameForModellingTreeSecond.SetParameter(New RParameter("data", 0))
        UcrSelectorByDataFrameForModellingTreeSecond.SetParameterIsString()

        ucrReceiverModellingTree.SetParameter(New RParameter("vars_to_get", 1))
        ucrReceiverModellingTree.SetParameterIsRFunction()
        ucrReceiverModellingTree.Selector = ucrSelectorByDataFrameAddRemoveForModellingTree
        ucrReceiverModellingTree.strSelectorHeading = "Traits"
        ucrReceiverModellingTree.SetTricotType("traits")
        ucrReceiverModellingTree.bAutoFill = True

        ucrReceiverExpressionModellingTree.SetParameter(New RParameter("y", 2))
        ucrReceiverExpressionModellingTree.SetParameterIsString()
        ucrReceiverExpressionModellingTree.bWithQuotes = False
        ucrReceiverExpressionModellingTree.AddtoCombobox("1")
        ucrReceiverExpressionModellingTree.strSelectorHeading = "Variables"
        ucrReceiverExpressionModellingTree.SetIncludedDataTypes({"numeric", "factor"})

        ucrInputCheck.SetLinkedDisplayControl(lblCheckVareity)


        ucrModelName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemoveForModellingTree.ucrAvailableDataFrames)
        ucrModelName.SetPrefix("gen_model")
        ucrModelName.SetSaveTypeAsModel()
        ucrModelName.SetCheckBoxText("Store Model")
        ucrModelName.SetIsComboBox()
        ucrModelName.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsFormulaOperator = New ROperator

        clsRConvert = New RFunction
        clsGetVariablesMetaDataFunction = New RFunction
        clsRGetObjectFunction = New RFunction
        clsGetRankingItemsFunction = New RFunction
        clsRankingsOperator = New ROperator
        clsFactorFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsMappingFunction = New RFunction
        clsNamesFunction = New RFunction
        clsModelOperator = New ROperator
        clsEmptySpaceOperator = New ROperator
        clsTildaOperator = New ROperator
        clsFormularTildaOperator = New ROperator
        clsVarOperator = New ROperator
        clsAssignOperator = New ROperator
        clsSaveOperator = New ROperator

        'Sub dialog Functions
        clsSummaryFunction = New RFunction
        clsUnListAICFunction = New RFunction
        clsAICFunction = New RFunction
        clsAICMainFunction = New RFunction
        clsDevianceFunction = New RFunction
        clsDevianceMainFunction = New RFunction
        clsSecondEstimatesFunction = New RFunction
        clsPairwiseProbFunction = New RFunction
        clsPairwiseProbFunction = New RFunction
        clsPairwiseProbMainFunction = New RFunction
        clsReliabilityFunction = New RFunction
        clsItemsParFunction = New RFunction
        clsRegretFunction = New RFunction
        clsNodeLabelsFunction = New RFunction
        clsNodeRulesFunction = New RFunction
        clsTopItemsFunction = New RFunction
        clsAnnovaFunction = New RFunction
        clsConfidenLimFunction = New RFunction
        clsStatsFunction = New RFunction
        clsQuasivarianceFunction = New RFunction
        clsVarianCovaMatrixFunction = New RFunction
        clsWrapBarFunction = New RFunction
        clsWrapPlotFunction = New RFunction
        clsWrapTrees = New RFunction
        clsAddObjectHeatFunction = New RFunction
        clsBarfunction = New RFunction
        clsHeatFunction = New RFunction
        clsTreeFunction = New RFunction
        clsPlotFunction = New RFunction
        clsCoefOperator = New ROperator
        clsAICOperator = New ROperator
        clsDevianceOperator = New ROperator
        clsPairwiseProbOperator = New ROperator
        clsStatsOperator = New ROperator

        bUniqueChecked = False
        bResetSubDialog = True
        ucrSelectorByDataFrameAddRemoveForModellingTree.Reset()
        ucrReceiverExpressionModellingTree.Clear()
        ucrModelName.Reset()
        ucrReceiverModellingTree.SetMeAsReceiver()
        ucrSelectorByDataFrameAddRemoveForModellingTree.Focus()

        clsRConvert.SetRCommand("as.numeric")

        clsFormulaOperator = clsRegressionDefaults.clsDefaultFormulaOperator.Clone

        ucrReceiverModellingTree.SetMeAsReceiver()
        ucrReceiverExpressionModellingTree.Selector = UcrSelectorByDataFrameForModellingTreeSecond
        ucrReceiverModellingTree.Selector = ucrSelectorByDataFrameAddRemoveForModellingTree


        ucrInputModelPreview.SetName("")
        ucrInputModelPreview.IsReadOnly = True

        ucrInputCheck.SetName("")
        ucrInputCheck.txtInput.BackColor = Color.White
        ucrInputCheck.IsReadOnly = True

        clsGetVariablesMetaDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetVariablesMetaDataFunction.SetAssignTo("get_index_names")


        clsRGetObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsRGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsRGetObjectFunction.AddParameter("object_name", Chr(34) & "grouped_rankings_list" & Chr(34))

        clsRankingsOperator.SetOperation("$")
        clsRankingsOperator.AddParameter("left", clsRFunctionParameter:=clsRGetObjectFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsRankingsOperator.AddParameter("right", "object", bIncludeArgumentName:=False, iPosition:=1)
        clsRankingsOperator.SetAssignTo("rankings_object")
        clsRankingsOperator.bSpaceAroundOperation = False

        clsVarOperator.SetOperation("")
        clsVarOperator.AddParameter("combine", strParameterValue:=ucrReceiverModellingTree.GetVariableNames(), bIncludeArgumentName:=False)
        clsVarOperator.SetAssignTo("vars")


        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetaDataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsVarOperator, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("ranking_objects", clsROperatorParameter:=clsRankingsOperator, bIncludeArgumentName:=False, iPosition:=3)
        clsGetRankingItemsFunction.SetAssignTo("ranking_objects")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.AddParameter("data", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame)

        clsGetSecondDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetSecondDataFrameFunction.AddParameter("data", Chr(34) & UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        clsGetSecondDataFrameFunction.SetAssignTo(UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)


        clsGetVariablesFromMetaDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVariablesFromMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34))
        clsGetVariablesFromMetaDataFunction.AddParameter("property", Chr(34) & "Tricot_Type" & Chr(34))
        clsGetVariablesFromMetaDataFunction.AddParameter("property_value", Chr(34) & "variety" & Chr(34))
        clsGetVariablesFromMetaDataFunction.SetAssignTo("var_name")

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorFunction, bIncludeArgumentName:=False)

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & "[[var_name]]", bIncludeArgumentName:=False)

        clsEmptySpaceOperator.SetOperation("")
        clsEmptySpaceOperator.AddParameter("left", clsRFunctionParameter:=clsLevelsFunction, bIncludeArgumentName:=False)
        clsEmptySpaceOperator.AddParameter("right", "[1]", bIncludeArgumentName:=False)
        clsEmptySpaceOperator.SetAssignTo("variety_baseline")
        clsEmptySpaceOperator.bSpaceAroundOperation = False

        clsMappingFunction.SetPackageName("purrr")
        clsMappingFunction.SetRCommand("map")
        clsMappingFunction.AddParameter(".x", clsRFunctionParameter:=clsGetRankingItemsFunction)
        clsMappingFunction.AddParameter(".f", clsROperatorParameter:=clsTildaOperator)
        clsMappingFunction.SetAssignTo("mod_list")

        clsPlackettLuceFunction.SetPackageName("PlackettLuce")
        clsPlackettLuceFunction.SetRCommand("pltree")
        clsPlackettLuceFunction.AddParameter(".x", clsROperatorParameter:=clsFormularTildaOperator, bIncludeArgumentName:=False)
        clsPlackettLuceFunction.AddParameter("data", UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)
        clsPlackettLuceFunction.AddParameter("ref", clsROperatorParameter:=clsEmptySpaceOperator, iPosition:=2)

        clsTildaOperator.SetOperation("~")
        clsTildaOperator.AddParameter("left", "", bIncludeArgumentName:=False, iPosition:=0)
        clsTildaOperator.AddParameter("right", clsRFunctionParameter:=clsPlackettLuceFunction, bIncludeArgumentName:=False, iPosition:=2)
        clsTildaOperator.bSpaceAroundOperation = False

        clsFormularTildaOperator.SetOperation("~")
        clsFormularTildaOperator.AddParameter("left", ".x", bIncludeArgumentName:=False, iPosition:=0)
        clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)


        clsLibraryFunction.SetRCommand("library")
        clsLibraryFunction.AddParameter("package_name", "PlackettLuce", bIncludeArgumentName:=False)

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", "mod_list", bIncludeArgumentName:=False)

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, bIncludeArgumentName:=False)
        clsAssignOperator.AddParameter("right", "vars", bIncludeArgumentName:=False)
        clsAssignOperator.bAllBrackets = False

        clsSaveOperator.SetOperation("")
        clsSaveOperator.AddParameter("right", clsRFunctionParameter:=clsMappingFunction, bIncludeArgumentName:=False)
        clsSaveOperator.bAllBrackets = False

        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod_list", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                 strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                 strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                 strRDataFrameNameToAddObjectTo:=ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame,
                                                 strObjectName:="last_model"
        )




        '----------------------------------------------------------------------------------------------------------------------------------
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
        clsAICMainFunction.iCallType = 2

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

        clsSecondEstimatesFunction.SetPackageName("purrr")
        clsSecondEstimatesFunction.SetRCommand("map")
        clsSecondEstimatesFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsSecondEstimatesFunction.AddParameter(".f", "~fitted.values(.x)", iPosition:=1)
        clsSecondEstimatesFunction.iCallType = 2

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

        clsReliabilityFunction.SetPackageName("purrr")
        clsReliabilityFunction.SetRCommand("map")
        clsReliabilityFunction.AddParameter(".x", "purrr::imap(.x = mod_list,  .f = ~gosset::reliability(.x, ref = variety_baseline[1]))", iPosition:=0)
        clsReliabilityFunction.AddParameter(".f", "~ .x %>% dplyr::mutate(reliability_rescaled = round(reliability / 0.5 - 1, 2))", iPosition:=1)
        clsReliabilityFunction.iCallType = 2

        clsItemsParFunction.SetPackageName("purrr")
        clsItemsParFunction.SetRCommand("map")
        clsItemsParFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsItemsParFunction.AddParameter(".f", "~PlackettLuce::itempar(.x)", iPosition:=1)
        clsItemsParFunction.iCallType = 2

        clsRegretFunction.SetPackageName("purrr")
        clsRegretFunction.SetRCommand("map")
        clsRegretFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsRegretFunction.AddParameter(".f", "~gosset::regret(.x)", iPosition:=1)
        clsRegretFunction.iCallType = 2

        clsNodeLabelsFunction.SetPackageName("purrr")
        clsNodeLabelsFunction.SetRCommand("map")
        clsNodeLabelsFunction.AddParameter(".x", "mod_list")
        clsNodeLabelsFunction.AddParameter(".f", "~gosset::node_labels(.x)")
        clsNodeLabelsFunction.iCallType = 2

        clsNodeRulesFunction.SetPackageName("purrr")
        clsNodeRulesFunction.SetRCommand("map")
        clsNodeRulesFunction.AddParameter(".x", "mod_list")
        clsNodeRulesFunction.AddParameter(".f", "~gosset::node_rules(.x)")
        clsNodeRulesFunction.iCallType = 2

        clsTopItemsFunction.SetPackageName("purrr")
        clsTopItemsFunction.SetRCommand("map")
        clsTopItemsFunction.AddParameter(".x", "mod_list")
        clsTopItemsFunction.AddParameter(".f", "~gosset::top_items(.x, top = 3)")
        clsTopItemsFunction.iCallType = 2

        clsAnnovaFunction.SetPackageName("purrr")
        clsAnnovaFunction.SetRCommand("map")
        clsAnnovaFunction.AddParameter(".x", "mod", iPosition:=0)
        clsAnnovaFunction.AddParameter(".f", "~gosset:::anova.PlackettLuce(.x)", iPosition:=1)
        clsAnnovaFunction.iCallType = 2

        clsStatsFunction.SetPackageName("stats")
        clsStatsFunction.SetRCommand("confint")
        clsStatsFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsStatsFunction.AddParameter("level", "0.95", iPosition:=1)

        clsStatsOperator.SetOperation("~")
        clsStatsOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsStatsOperator.AddParameter("right", clsRFunctionParameter:=clsStatsFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsConfidenLimFunction.SetPackageName("purrr")
        clsConfidenLimFunction.SetRCommand("map")
        clsConfidenLimFunction.AddParameter(".x", "mod", iPosition:=0)
        clsConfidenLimFunction.AddParameter(".f", clsROperatorParameter:=clsStatsOperator, iPosition:=1)
        clsConfidenLimFunction.iCallType = 2

        clsQuasivarianceFunction.SetPackageName("purrr")
        clsQuasivarianceFunction.SetRCommand("map")
        clsQuasivarianceFunction.AddParameter(".x", "mod", iPosition:=0)
        clsQuasivarianceFunction.AddParameter(".f", "~qvcalc::qvcalc(PlackettLuce::itempar(.x))", iPosition:=1)
        clsQuasivarianceFunction.iCallType = 2

        clsVarianCovaMatrixFunction.SetPackageName("purrr")
        clsVarianCovaMatrixFunction.SetRCommand("map")
        clsVarianCovaMatrixFunction.AddParameter(".x", "mod", iPosition:=0)
        clsVarianCovaMatrixFunction.AddParameter(".f", "~vcov(.x)", iPosition:=1)
        clsVarianCovaMatrixFunction.iCallType = 2


        ' Functions/Operators in the Graphs Tab under the display option (need review)
        '------------------------------------------------------------------------------------------------------------------------------------------
        clsHeatFunction.SetPackageName("gosset")
        clsHeatFunction.SetRCommand("worth_map")
        clsHeatFunction.AddParameter(".x", "mod_list", iPosition:=0, bIncludeArgumentName:=False)
        clsHeatFunction.AddParameter("labels", "names(mod_list)", iPosition:=1)
        clsHeatFunction.SetAssignTo("last_graph")
        clsHeatFunction.bExcludeAssignedFunctionOutput = False
        clsHeatFunction.iCallType = 3

        clsTreeFunction.SetPackageName("purrr")
        clsTreeFunction.SetRCommand("map2")
        clsTreeFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsTreeFunction.AddParameter(".y", "names(mod_list)", iPosition:=1)
        clsTreeFunction.AddParameter(".f", "~plot_pltree(.x) + ggplot2::labs(caption = .y)")
        clsTreeFunction.SetAssignTo("list_of_plots")
        clsTreeFunction.bExcludeAssignedFunctionOutput = False
        clsTreeFunction.iCallType = 3

        clsPlotFunction.SetPackageName("purrr")
        clsPlotFunction.SetRCommand("map2")
        clsPlotFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsPlotFunction.AddParameter(".y", "names(mod_list)", iPosition:=1)
        clsPlotFunction.AddParameter(".f", "~gosset:::plot.PlackettLuce(x = .x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsPlotFunction.SetAssignTo("list_of_plots")

        clsBarfunction.SetPackageName("purrr")
        clsBarfunction.SetRCommand("map2")
        clsBarfunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsBarfunction.AddParameter(".y", "names(mod_list)", iPosition:=1)
        clsBarfunction.AddParameter(".f", "~gosset::worth_bar(.x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsBarfunction.SetAssignTo("list_of_plots")
        clsBarfunction.bExcludeAssignedFunctionOutput = False
        clsBarfunction.iCallType = 3

        clsAddObjectHeatFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsAddObjectHeatFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        clsAddObjectHeatFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddObjectHeatFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddObjectHeatFunction.AddParameter("object", "instatExtras::check_graph(graph_object=last_graph)", iPosition:=4)

        clsWrapBarFunction.SetPackageName("patchwork")
        clsWrapBarFunction.SetRCommand("wrap_plots")
        clsWrapBarFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapBarFunction.bExcludeAssignedFunctionOutput = False
        clsWrapBarFunction.iCallType = 3

        clsWrapPlotFunction.SetPackageName("patchwork")
        clsWrapPlotFunction.SetRCommand("wrap_plots")
        clsWrapPlotFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapPlotFunction.bExcludeAssignedFunctionOutput = False
        clsWrapPlotFunction.iCallType = 3

        clsWrapTrees.SetPackageName("patchwork")
        clsWrapTrees.SetRCommand("wrap_plots")
        clsWrapTrees.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapTrees.bExcludeAssignedFunctionOutput = False
        clsWrapTrees.iCallType = 3
        clsWrapTrees.SetAssignToOutputObject(
            strObjectName:="last_graph",
            strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
            strRObjectFormatToAssignTo:=RObjectFormat.Image,
            strRObjectToAssignTo:="last_graph"
        )

        ' PLACKET FUNCTION FOR THE MODEL OPTIONS SUB-DIALOG
        '---------------------------------------------------------------------------------------------------------------------------------------------
        'clsPlacketFunction.SetPackageName("PlackettLuce")
        'clsPlacketFunction.SetRCommand("PlackettLuce")
        'clsPlacketFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)

        ucrBase.clsRsyntax.ClearCodes()

        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction, iPosition:=1)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetSecondDataFrameFunction, iPosition:=2)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetVariablesFromMetaDataFunction, iPosition:=3)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsLibraryFunction, iPosition:=4)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsMappingFunction, iPosition:=5)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAssignOperator, iPosition:=6)

        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)

    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrModelName.ControlValueChanged

    End Sub


    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrModelName.AddAdditionalRCode(clsModelOperator, bReset)
        ucrModelName.SetRCode(clsModelOperator)

        bRCodeSet = True
        ResponseConvert()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverModellingTree.IsEmpty()) AndAlso (Not ucrReceiverExpressionModellingTree.IsEmpty()) AndAlso bUniqueChecked AndAlso
            (Not ucrInputCheck.IsEmpty()) AndAlso ucrModelName.IsComplete Then
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

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("( )", 2)
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("I()", 1)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverExpressionModellingTree.Clear()
    End Sub

    Private Sub cmdSqrt_Click(sender As Object, e As EventArgs) Handles cmdSqrt.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("sqrt( )", 2)
    End Sub

    Private Sub cmdCos_Click(sender As Object, e As EventArgs) Handles cmdCos.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("cos( )", 2)
    End Sub

    Private Sub cmdLog_Click(sender As Object, e As EventArgs) Handles cmdLog.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("log( )", 2)
    End Sub

    Private Sub cmdSin_Click(sender As Object, e As EventArgs) Handles cmdSin.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("sin( )", 2)
    End Sub

    Private Sub cmdExp_Click(sender As Object, e As EventArgs) Handles cmdExp.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("exp( )", 2)
    End Sub

    Private Sub cmdTan_Click(sender As Object, e As EventArgs) Handles cmdTan.Click
        ucrReceiverExpressionModellingTree.AddToReceiverAtCursorPosition("tan( )", 2)
    End Sub

    Private Sub cmdModelOptions_Click(sender As Object, e As EventArgs) Handles cmdModelOptions.Click
        sdgPLModelOptions.enumPLModelOptionsMode = sdgPLModelOptions.PLModelOptionsMode.Tree
        sdgPLModelOptions.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, bReset:=bResetSubDialog, clsNewPlacketFunction:=clsPlackettLuceFunction)
        sdgPLModelOptions.ucrChkMultivariateNormal.Enabled = False
        sdgPLModelOptions.ucrChkGamma.Enabled = False
        sdgPLModelOptions.ShowDialog()
        bResetSubDialog = False
    End Sub
    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDisplayModelOptions.enumPlacketLuceModelMode = sdgDisplayModelOptions.PlacketLuceModelMode.tree
        sdgDisplayModelOptions.SetRCode(clsNewSummaryFunction:=clsSummaryFunction, clsNewCoefFunction:=clscoefFunction, clsNewSecondEstimatesFunction:=clsSecondEstimatesFunction,
            clsNewEstimatesFunction:=clsEstimatesFunction, clsNewImportDataFunction:=clsImportDataFunction, clsNewDefineAsTricotFunction:=clsDefineAsTricotFunction, clsNewPipeOperator:=clsPipeOperator, clsNewDevianceFunction:=clsDevianceMainFunction,
            clsNewPariPropFunction:=clsPairwiseProbMainFunction, clsNewReliabilityFunction:=clsReliabilityFunction,
            clsNewItemsFunction:=clsItemsParFunction, clsNewRegretFunction:=clsRegretFunction, clsNewNodeLabFuction:=clsNodeLabelsFunction,
            clsNewNodeRuleFunction:=clsNodeRulesFunction, clsNewTopItemFunction:=clsTopItemsFunction, clsNewRSyntax:=ucrBase.clsRsyntax, clsNewAICFunction:=clsUnListAICFunction,
            bReset:=bResetSubDialog, clsNewAnnovaFunction:=clsAnnovaFunction,
            clsNewConfidenLimFunction:=clsConfidenLimFunction, clsNewStatsFunction:=clsStatsFunction,
            clsNewQuasivarianceFunction:=clsQuasivarianceFunction, clsNewVarianCovaMatrixFunction:=clsVarianCovaMatrixFunction,
            clsNewHeatFunction:=clsHeatFunction, clsNewPlotFunction:=clsPlotFunction, clsNewBarfunction:=clsBarfunction,
            clsNewWrapPlotFunction:=clsWrapPlotFunction, clsNewWrapBarFunction:=clsWrapBarFunction, clsNewTreeFunction:=clsTreeFunction, clsNewWrapTree:=clsWrapTrees
        )
        sdgDisplayModelOptions.ucrChkANOVA.Enabled = False
        sdgDisplayModelOptions.ucrChkConfLimits.Enabled = False
        sdgDisplayModelOptions.ucrChkVaCoMa.Enabled = False
        sdgDisplayModelOptions.ucrChkQuasiVa.Enabled = False
        sdgDisplayModelOptions.ucrChkEstimates.Enabled = True
        sdgDisplayModelOptions.ucrChkAIC.Enabled = True
        sdgDisplayModelOptions.ucrChkDeviance.Enabled = True
        sdgDisplayModelOptions.ucrChkSndEstimetes.Enabled = True
        sdgDisplayModelOptions.ucrChkParProp.Enabled = True
        sdgDisplayModelOptions.ucrChkReability.Enabled = True
        sdgDisplayModelOptions.ucrChkItemPara.Enabled = True
        sdgDisplayModelOptions.ucrChkSave.Checked = False
        sdgDisplayModelOptions.ucrChkSave.Visible = False
        sdgDisplayModelOptions.rdoPlot.Enabled = False
        sdgDisplayModelOptions.rdoTree.Enabled = True
        sdgDisplayModelOptions.rdoNoPlot.Enabled = True
        sdgDisplayModelOptions.rdoMap.Enabled = True
        sdgDisplayModelOptions.rdoBar.Enabled = True
        sdgDisplayModelOptions.grpTrees.Enabled = True

        sdgDisplayModelOptions.ShowDialog()
        bResetSubDialog = False
    End Sub

    Private Sub Check()
        Dim clsPackageCheck As New RFunction
        Dim expOutput As SymbolicExpression
        Dim chrOutput As CharacterVector

        If Not ucrReceiverExpressionModellingTree.IsEmpty AndAlso Not ucrReceiverModellingTree.IsEmpty Then
            clsPackageCheck.SetPackageName("databook")
            clsPackageCheck.SetRCommand("check_ID_data_level")
            clsPackageCheck.AddParameter("data", Chr(34) & UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame & Chr(34))

            expOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsPackageCheck.ToScript(), bSilent:=True)

            If expOutput Is Nothing OrElse expOutput.Type = Internals.SymbolicExpressionType.Null Then
                ucrInputCheck.SetText("Cannot get data information.")
                Exit Sub
            End If

            chrOutput = expOutput.AsCharacter
            If chrOutput.Count < 1 Then
                ucrInputCheck.SetText("Cannot get data information.")
                ucrInputCheck.txtInput.BackColor = Color.White
                Exit Sub
            End If
            Select Case chrOutput(0)
                Case "0"
                    bUniqueChecked = False
                    ucrInputCheck.SetText("There is no ID variable that is Tricot-Defined in this data.")
                    ucrInputCheck.txtInput.BackColor = Color.LightCoral
                Case "1"
                    bUniqueChecked = False
                    ucrInputCheck.SetText("No key columns are defined in the dataset.")
                    ucrInputCheck.txtInput.BackColor = Color.LightCoral
                Case "2"
                    bUniqueChecked = False
                    ucrInputCheck.SetText("Only ID level data can be used for this data. This is data where there is a unique row for each ID variable given.")
                    ucrInputCheck.txtInput.BackColor = Color.LightCoral
                Case "3"
                    bUniqueChecked = True
                    ucrInputCheck.SetText("Success. The dataset is Tricot-defined and at the ID level.")
                    ucrInputCheck.txtInput.BackColor = Color.LightGreen
            End Select

        Else
            ucrInputCheck.SetName("")
            ucrInputCheck.txtInput.BackColor = Color.White
        End If

        'TestOKEnabled()
    End Sub

    Private Sub UpdatePreview()
        If Not ucrReceiverExpressionModellingTree.IsEmpty Then
            ucrInputModelPreview.SetName(clsFormularTildaOperator.ToScript())
        Else
            ucrInputModelPreview.SetName("")
        End If
    End Sub

    Public Sub ResponseConvert()
        If bRCodeSet Then
            If Not ucrReceiverExpressionModellingTree.IsEmpty() Then
                clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)
            End If


            If Not ucrReceiverModellingTree.IsEmpty Then
                clsVarOperator.AddParameter("combine", strParameterValue:=ucrReceiverModellingTree.GetVariableNames(), bIncludeArgumentName:=False)
                clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsVarOperator, iPosition:=1)
            End If
            UpdatePreview()
            TestOKEnabled()
        End If
    End Sub


    Private Sub ucrReceiverExpressionModellingTree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionModellingTree.ControlValueChanged
        clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)
        UpdatePreview()
        Check()
        UpdatePreview()
        TestOKEnabled()
    End Sub


    Private Sub ucrReceiverExpressionModellingTree_ControlContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionModellingTree.ControlContentsChanged, UcrSelectorByDataFrameForModellingTreeSecond.ControlContentsChanged
        clsFormularTildaOperator.AddParameter("right", ucrReceiverExpressionModellingTree.GetVariableNames(bWithQuotes:=False), bIncludeArgumentName:=False, iPosition:=2)
        UpdatePreview()
    End Sub

    Private Sub ucrReceiverModellingTree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverModellingTree.ControlValueChanged
        ResponseConvert()
    End Sub

    Private Sub ucrSelectorByDataFrameAddRemoveForModellingTree_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorByDataFrameAddRemoveForModellingTree.ControlValueChanged

        If clsGetVariablesMetaDataFunction.ContainsParameter("data_name") Then
            clsGetVariablesMetaDataFunction.RemoveParameterByName("data_name")
            clsGetVariablesMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If
        If clsGetVariablesFromMetaDataFunction.ContainsParameter("data_name") Then
            clsGetVariablesFromMetaDataFunction.RemoveParameterByName("data_name")
            clsGetVariablesFromMetaDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), iPosition:=0)
        End If
        If clsRGetObjectFunction.ContainsParameter("data_name") Then
            clsRGetObjectFunction.RemoveParameterByName("data_name")
            clsRGetObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34))
        End If
        If clsGetDataFrameFunction.ContainsParameter("data") Then
            clsGetDataFrameFunction.RemoveParameterByName("data")
            clsGetDataFrameFunction.AddParameter("data", Chr(34) & ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If
        If clsFactorFunction.ContainsParameter("x") Then
            clsFactorFunction.RemoveParameterByName("x")
            clsFactorFunction.AddParameter("x", ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame & "[[var_name]]", bIncludeArgumentName:=False)
        End If

        clsGetDataFrameFunction.SetAssignTo(ucrSelectorByDataFrameAddRemoveForModellingTree.strCurrentDataFrame)

    End Sub

    Private Sub UcrSelectorByDataFrameForModellingTreeSecond_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrSelectorByDataFrameForModellingTreeSecond.ControlValueChanged

        If clsGetSecondDataFrameFunction.ContainsParameter("data") Then
            clsGetSecondDataFrameFunction.RemoveParameterByName("data")
            clsGetSecondDataFrameFunction.AddParameter("data", Chr(34) & UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame & Chr(34), bIncludeArgumentName:=False)
        End If
        If clsPlackettLuceFunction.ContainsParameter("data") Then
            clsPlackettLuceFunction.RemoveParameterByName("data")
            clsPlackettLuceFunction.AddParameter("data", UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)
        End If
        clsGetSecondDataFrameFunction.SetAssignTo(UcrSelectorByDataFrameForModellingTreeSecond.strCurrentDataFrame)

    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverExpressionModellingTree.AddtoCombobox(ucrReceiverExpressionModellingTree.GetText)
    End Sub

End Class
