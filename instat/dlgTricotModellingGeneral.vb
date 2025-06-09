﻿Imports RDotNet

Public Class dlgTricotModellingGeneral

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubDialog As Boolean = True
    Private bCheck7Passed As Boolean = False
    Private bIsUnique As Boolean = True
    Private clsGetVariablesMetadataFunction As New RFunction
    Private clsGetObjectFunction, clsGetRankingItemsFunction, clsGetDataFrameFunction, clsLevelsFunction, clsMappingFunction, clsPladmmFunction,
            clsNamesFunction, clsGetVariablesFromMetaDataFunction, clsFactorFunction, clsSummaryFunction, clscoefFunction,
            clsEstimatesFunction, clsSecondEstimatesFunction, clsDevianceFunction, clsDevianceMainFunction, clsPairwiseProbFunction,
            clsPairwiseProbMainFunction, clsReliabilityFunction, clsItemsParFunction, clsRegretFunction, clsNodeLabelsFunction,
            clsNodeRulesFunction, clsTopItemsFunction, clsAICFunction, clsUnListAICFunction, clsAICMainFunction, clsAnnovaFunction,
            clsConfidenLimFunction, clsStatsFunction, clsQuasivarianceFunction, clsVarianCovaMatrixFunction, clsHeatFunction, clsPackageCheck,
            clsPlotFunction, clsBarfunction, clsWrapPlotFunction, clsWrapBarFunction, clsTreeFunction, clsImportDataFunction, clsDefineAsTricotFunction, clsWrapTrees,
            clsGetVarFromMetaData, clsGetColumnFromData, clsDataUnstackedFunction, clsPullFunction, clsFactor2Function, clsLevels2Function,
            clsPladmm2Function, clsMappings2Function, clsNames2Function, clsDataFunction, clsGetDataframe2function As New RFunction

    Private clsObjectOperator, clsTildeOperator, clsTilde2Operator, clsBracketOperator, clsDevianceOperator, clsPairwiseProbOperator,
            clsNamesOperator, clsModelOperator, clsSpaceOperator, clsEmptySpaceOperator, clsCoefOperator, clsPipe2Operator, clsBracket2Operator,
            clsAICOperator, clsStatsOperator, clsPipeOperator, clsTilde3Operator, clsTilde4Operator, clsNames2Operator As New ROperator

    Private Sub dlgTricotModellingGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            setDefaults()
        End If
        bCheck7Passed = False
        SetRcodeForControls(bReset)
        bReset = False
        ' autoTranslate(Me)
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
        ucrTraitsReceiver.SetTricotType("traits")
        ucrTraitsReceiver.bAutoFill = True

        ucrSelectorVarietyLevel.SetParameter(New RParameter("data", 0))
        ucrSelectorVarietyLevel.SetParameterIsrfunction()

        ucrReceiverExpressionModellingGeneral.SetParameter(New RParameter("y", 2))
        ucrReceiverExpressionModellingGeneral.Selector = ucrSelectorVarietyLevel
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

        bCheck7Passed = False

        btnModelOptions.Enabled = True
        btnDisplayOptions.Enabled = True
    End Sub

    Private Sub setDefaults()
        clsGetVariablesMetadataFunction = New RFunction
        clsGetObjectFunction = New RFunction
        clsObjectOperator = New ROperator
        clsSpaceOperator = New ROperator
        clsGetRankingItemsFunction = New RFunction
        clsLevelsFunction = New RFunction
        clsMappingFunction = New RFunction
        clsPladmmFunction = New RFunction
        clsGetVariablesFromMetaDataFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clscoefFunction = New RFunction
        clsPackageCheck = New RFunction
        clsTildeOperator = New ROperator
        clsTilde2Operator = New ROperator
        clsEmptySpaceOperator = New ROperator
        clsFactorFunction = New RFunction
        clsAICMainFunction = New RFunction
        clsBracketOperator = New ROperator
        clsNamesFunction = New RFunction
        clsNamesOperator = New ROperator
        clsModelOperator = New ROperator

        clsGetVarFromMetaData = New RFunction
        clsDataUnstackedFunction = New RFunction
        clsGetDataframe2function = New RFunction
        clsPullFunction = New RFunction
        clsDataFunction = New RFunction
        clsFactor2Function = New RFunction
        clsLevels2Function = New RFunction
        clsPladmm2Function = New RFunction
        clsMappings2Function = New RFunction
        clsNames2Function = New RFunction
        clsNames2Operator = New ROperator
        clsTilde4Operator = New ROperator
        clsBracket2Operator = New ROperator
        clsPipe2Operator = New ROperator
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
        clsHeatFunction = New RFunction
        clsPlotFunction = New RFunction
        clsBarfunction = New RFunction
        clsWrapPlotFunction = New RFunction
        clsWrapBarFunction = New RFunction
        bResetSubDialog = True
        bCheck7Passed = False

        ucrSaveModellingGeneral.Reset()
        ucrSelectorTraitsRanking.Reset()
        ucrSelectorVarietyLevel.Reset()

        ucrInputCheckVariety.SetName("")
        ucrInputCheckVariety.txtInput.BackColor = Color.White
        ucrInputCheckVariety.IsReadOnly = True

        ucrTraitsReceiver.SetMeAsReceiver()

        clsPackageCheck.SetPackageName("databook")
        clsPackageCheck.SetRCommand("check_variety_data_level")
        clsPackageCheck.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34))
        clsPackageCheck.AddParameter("col", Chr(34) & ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False) & Chr(34))

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


        clsGetVarFromMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVarFromMetaData.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.AddParameter("tricot_type", Chr(34) & "Tricot_Type" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.AddParameter("variety", Chr(34) & "variety" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.SetAssignTo("variety_level_var")

        clsGetColumnFromData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnFromData.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetColumnFromData.AddParameter("x", clsRFunctionParameter:=clsGetVarFromMetaData, iPosition:=1, bIncludeArgumentName:=False)
        clsGetColumnFromData.SetAssignTo("variety_level_var")

        clsGetDataframe2function.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataframe2function.AddParameter("data_name", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsGetDataframe2function.SetAssignTo(ucrSelectorVarietyLevel.strCurrentDataFrame)

        clsDataFunction.SetPackageName("data.table")
        clsDataFunction.SetRCommand("as.data.table")
        clsDataFunction.AddParameter("x", ucrSelectorVarietyLevel.strCurrentDataFrame, iPosition:=0, bIncludeArgumentName:=False)

        clsDataUnstackedFunction.SetPackageName("data.table")
        clsDataUnstackedFunction.SetRCommand("dcast")
        clsDataUnstackedFunction.AddParameter("data", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsDataUnstackedFunction.AddParameter("formula", "variety_level_var" & " + " & ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False) & " ~ " & Chr(34) & "X" & Chr(34), iPosition:=1)
        clsDataUnstackedFunction.SetAssignTo("cochran.bib_unstacked")

        clsPullFunction.SetPackageName("dplyr")
        clsPullFunction.SetRCommand("pull")
        clsPullFunction.AddParameter("x", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)

        clsPipe2Operator.SetOperation("%>%")
        clsPipe2Operator.AddParameter("left", "cochran.bib_unstacked", iPosition:=0, bIncludeArgumentName:=False)
        clsPipe2Operator.AddParameter("right", clsRFunctionParameter:=clsPullFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsPipe2Operator.SetAssignTo(ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False))

        clsFactor2Function.SetRCommand("factor")
        clsFactor2Function.AddParameter("x", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)

        clsLevels2Function.SetRCommand("levels")
        clsLevels2Function.AddParameter("x", clsRFunctionParameter:=clsFactor2Function, iPosition:=0, bIncludeArgumentName:=False)

        clsBracket2Operator.SetOperation("[")
        clsBracket2Operator.AddParameter("left", clsRFunctionParameter:=clsLevels2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsBracket2Operator.AddParameter("right", "1]", iPosition:=1, bIncludeArgumentName:=False)
        clsBracket2Operator.bSpaceAroundOperation = False
        clsBracket2Operator.SetAssignTo("variety_baseline")

        clsTilde3Operator.SetOperation("~")
        clsTilde3Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTilde3Operator.AddParameter("right", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)

        clsPladmm2Function.SetPackageName("PlackettLuce")
        clsPladmm2Function.SetRCommand("pladmm")
        clsPladmm2Function.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsPladmm2Function.AddParameter("y", clsROperatorParameter:=clsTilde3Operator, iPosition:=1, bIncludeArgumentName:=False)
        clsPladmm2Function.AddParameter("data", "cochran.bib_unstacked", iPosition:=2)

        clsTilde4Operator.SetOperation("~")
        clsTilde4Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTilde4Operator.AddParameter("right", clsRFunctionParameter:=clsPladmm2Function, iPosition:=1, bIncludeArgumentName:=False)

        clsMappings2Function.SetPackageName("purrr")
        clsMappings2Function.SetRCommand("map")
        clsMappings2Function.AddParameter(".x", "rankings_object", iPosition:=0)
        clsMappings2Function.AddParameter(".f", clsROperatorParameter:=clsTilde4Operator, iPosition:=1)
        clsMappings2Function.SetAssignTo("mod_list")

        clsNames2Function.SetRCommand("names")
        clsNames2Function.AddParameter("x", clsRFunctionParameter:=clsMappings2Function, iPosition:=0, bIncludeArgumentName:=False)

        clsNames2Operator.SetOperation("<-")
        clsNames2Operator.AddParameter("left", clsRFunctionParameter:=clsNames2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsNames2Operator.AddParameter("right", "vars", iPosition:=1, bIncludeArgumentName:=False)





        clsSpaceOperator.SetOperation("")
        clsSpaceOperator.AddParameter("x", ucrTraitsReceiver.GetVariableNames(), iPosition:=0, bIncludeArgumentName:=False)
        clsSpaceOperator.SetAssignTo("vars")

        clsGetRankingItemsFunction.SetRCommand("get_ranking_items")
        clsGetRankingItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariablesMetadataFunction, iPosition:=0)
        clsGetRankingItemsFunction.AddParameter("vars_to_get", clsROperatorParameter:=clsSpaceOperator, iPosition:=1)
        clsGetRankingItemsFunction.AddParameter("index ", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsGetRankingItemsFunction.AddParameter("data_object", clsROperatorParameter:=clsObjectOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsGetRankingItemsFunction.SetAssignTo("rankings_object")

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


        clsItemsParFunction.SetPackageName("purrr")
        clsItemsParFunction.SetRCommand("map")
        clsItemsParFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsItemsParFunction.AddParameter(".f", "~PlackettLuce::itempar(.x)", iPosition:=1)
        clsItemsParFunction.iCallType = 2

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

        clsVarianCovaMatrixFunction.SetPackageName("purrr")
        clsVarianCovaMatrixFunction.SetRCommand("map")
        clsVarianCovaMatrixFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsVarianCovaMatrixFunction.AddParameter(".f", "~vcov(.x)", iPosition:=1)
        clsVarianCovaMatrixFunction.iCallType = 2


        ' PLOT FUNCTIONS
        '-------------------------------------------------------------------------------------------------------------------
        clsHeatFunction.SetPackageName("gosset")
        clsHeatFunction.SetRCommand("worth_map")
        clsHeatFunction.AddParameter(".x", "mod_list", iPosition:=0, bIncludeArgumentName:=False)
        clsHeatFunction.AddParameter("labels", "names(mod_list)", iPosition:=1)
        clsHeatFunction.SetAssignTo("last_graph")
        clsHeatFunction.bExcludeAssignedFunctionOutput = False
        clsHeatFunction.iCallType = 3

        clsPlotFunction.SetPackageName("purrr")
        clsPlotFunction.SetRCommand("map2")
        clsPlotFunction.AddParameter(".x", "mod_list", iPosition:=0)
        clsPlotFunction.AddParameter(".y", "names(mod_list)", iPosition:=1)
        clsPlotFunction.AddParameter(".f", "~gosset:::plot.PlackettLuce(x = .x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsPlotFunction.SetAssignTo("list_of_plots")

        clsWrapPlotFunction.SetPackageName("patchwork")
        clsWrapPlotFunction.SetRCommand("wrap_plots")
        clsWrapPlotFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapPlotFunction.SetAssignTo("last_graph")
        clsWrapPlotFunction.iCallType = 3

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetRankingItemsFunction, iPosition:=3)

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
            Not ucrInputCheckVariety.IsEmpty AndAlso bIsUnique Then
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
        sdgDisplayModelOptions.enumPlacketLuceModelMode = sdgDisplayModelOptions.PlacketLuceModelMode.ModellingGeneral2
        sdgDisplayModelOptions.SetRCode(clsNewSummaryFunction:=clsSummaryFunction,
            clsNewCoefFunction:=clscoefFunction, clsNewSecondEstimatesFunction:=clsSecondEstimatesFunction,
            clsNewEstimatesFunction:=clsEstimatesFunction, clsNewImportDataFunction:=clsImportDataFunction, clsNewDefineAsTricotFunction:=clsDefineAsTricotFunction, clsNewPipeOperator:=clsPipeOperator, clsNewDevianceFunction:=clsDevianceMainFunction,
            clsNewPariPropFunction:=clsPairwiseProbMainFunction, clsNewReliabilityFunction:=clsReliabilityFunction,
            clsNewItemsFunction:=clsItemsParFunction, clsNewRegretFunction:=clsRegretFunction, clsNewNodeLabFuction:=clsNodeLabelsFunction,
            clsNewNodeRuleFunction:=clsNodeRulesFunction, clsNewTopItemFunction:=clsTopItemsFunction, clsNewRSyntax:=ucrBase.clsRsyntax, clsNewAICFunction:=clsUnListAICFunction,
            bReset:=bResetSubDialog, clsNewAnnovaFunction:=clsAnnovaFunction,
            clsNewConfidenLimFunction:=clsConfidenLimFunction, clsNewStatsFunction:=clsStatsFunction,
            clsNewQuasivarianceFunction:=clsQuasivarianceFunction,
            clsNewVarianCovaMatrixFunction:=clsVarianCovaMatrixFunction,
            clsNewHeatFunction:=clsHeatFunction, clsNewPlotFunction:=clsPlotFunction, clsNewBarfunction:=clsBarfunction,
            clsNewWrapPlotFunction:=clsWrapPlotFunction, clsNewWrapBarFunction:=clsWrapBarFunction, clsNewTreeFunction:=clsTreeFunction, clsNewWrapTree:=clsWrapTrees
        )
        sdgDisplayModelOptions.ucrChkANOVA.Enabled = False
        sdgDisplayModelOptions.ucrChkReability.Enabled = False
        sdgDisplayModelOptions.ucrChkQuasiVa.Enabled = False
        sdgDisplayModelOptions.grpTrees.Enabled = False
        sdgDisplayModelOptions.rdoPlot.Enabled = False
        sdgDisplayModelOptions.rdoBar.Enabled = False
        sdgDisplayModelOptions.rdoTree.Enabled = False
        sdgDisplayModelOptions.rdoMap.Enabled = True
        sdgDisplayModelOptions.ucrChkSave.Checked = False
        sdgDisplayModelOptions.ucrChkSave.Visible = False
        sdgDisplayModelOptions.ucrChkConfLimits.Enabled = True
        sdgDisplayModelOptions.ucrChkVaCoMa.Enabled = True
        sdgDisplayModelOptions.ucrChkEstimates.Enabled = True
        sdgDisplayModelOptions.ucrChkAIC.Enabled = True
        sdgDisplayModelOptions.ucrChkDeviance.Enabled = True
        sdgDisplayModelOptions.ucrChkSndEstimetes.Enabled = True
        sdgDisplayModelOptions.ucrChkParProp.Enabled = True

        sdgDisplayModelOptions.ucrChkItemPara.Enabled = True

        sdgDisplayModelOptions.ShowDialog()
        bResetSubDialog = False
    End Sub


    Private Sub btnModelOptions_Click(sender As Object, e As EventArgs) Handles btnModelOptions.Click
        sdgTricotModelOptions.enumTricotModelOptionsMode = sdgTricotModelOptions.TricotModelOptionsMode.ModellingGeneral
        sdgTricotModelOptions.SetRCode(
            clsNewRFunction:=clsPladmmFunction,
            clsNewRSyntax:=ucrBase.clsRsyntax,
            bReset:=bResetSubDialog
        )
        sdgTricotModelOptions.ShowDialog()
        bResetSubDialog = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitsReceiver.ControlContentsChanged,
        ucrSaveModellingGeneral.ControlContentsChanged, ucrReceiverExpressionModellingGeneral.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverExpressionModellingGeneral_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverExpressionModellingGeneral.ControlValueChanged
        clsDataUnstackedFunction.AddParameter("formula", "variety_level_var" & " + " & ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False) & " ~ " & Chr(34) & "X" & Chr(34), iPosition:=1)
        clsTilde2Operator.AddParameter("right", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)
        clsPackageCheck.AddParameter("col", Chr(34) & ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False) & Chr(34))
        clsPullFunction.AddParameter("x", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
        clsPipe2Operator.SetAssignTo(ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False))
        clsFactor2Function.AddParameter("x", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
        clsTilde3Operator.AddParameter("right", ucrReceiverExpressionModellingGeneral.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)
        Check()
        CheckAddCodesToBefore()
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

    Private Sub ucrSelectorVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVarietyLevel.ControlValueChanged
        clsGetVarFromMetaData.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetColumnFromData.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataframe2function.AddParameter("data_name", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsGetDataframe2function.SetAssignTo(ucrSelectorVarietyLevel.strCurrentDataFrame)
        clsDataFunction.AddParameter("x", ucrSelectorVarietyLevel.strCurrentDataFrame, iPosition:=0, bIncludeArgumentName:=False)
        clsPackageCheck.AddParameter("data", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34))
    End Sub

    Private Sub CheckAddCodesToBefore()
        If bCheck7Passed Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFrameFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetVariablesFromMetaDataFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsBracketOperator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsNamesOperator)

            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnFromData, iPosition:=4)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataframe2function, iPosition:=5)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsDataUnstackedFunction, iPosition:=6)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPipe2Operator, iPosition:=7)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsBracket2Operator, iPosition:=8)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNames2Operator, iPosition:=9)

        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetColumnFromData)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataframe2function)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsDataUnstackedFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPipe2Operator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsBracket2Operator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsNames2Operator)

            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrameFunction, iPosition:=4)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetVariablesFromMetaDataFunction, iPosition:=5)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsBracketOperator, iPosition:=6)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=7)
        End If
    End Sub

    Private Sub Check()
        Dim chrOutput As CharacterVector
        Dim expOutput As SymbolicExpression

        If Not ucrReceiverExpressionModellingGeneral.IsEmpty AndAlso Not ucrTraitsReceiver.IsEmpty Then

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
                Case "7"
                    bIsUnique = True
                    bCheck7Passed = True
                    ucrInputCheckVariety.SetName("Success. This data is at the plot level, but it can be used.")
                    ucrInputCheckVariety.txtInput.BackColor = Color.LightGreen
                Case "8"
                    bIsUnique = False
                    ucrInputCheckVariety.SetName("This data is at the plot level. Either use variety-level data, or use data where there is only one level of 'col' for each variety level.")
                    ucrInputCheckVariety.txtInput.BackColor = Color.Coral
            End Select

        Else
            ucrInputCheckVariety.SetName("")
            ucrInputCheckVariety.txtInput.BackColor = Color.White

        End If


    End Sub

End Class
