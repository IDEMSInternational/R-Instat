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
    Private bCheck7Passed As Boolean = False
    Private clsGetVariablesMetadataFunction As New RFunction
    Private clsWrapBarFunction, clsWrapPlotFunction,
        clsHeatFunction, clsPlotFunction, clsBarfunction, clsAnnovaFunction, clsSummaryFunction, clsAICFunction,
        clsCoefFunction, clsConfidenLimFunction, clsDevianceFunction, clsEstimatesFunction, clsItemsFunction,
        clsPariPropFunction, clsQuasivarianceFunction, clsReliabilityFunction, clsSecondEstimatesFunction,
        clsStatsFunction, clsRegretFunction, clsTopItemFunction, clsNodeRuleFunction, clsNodeLabFuction,
        clsTreeFunction, clsVarianCovaMatrixFunction, clsImportDataFunction, clsDefineAsTricotFunction, clsWrapTrees,
        clsGetVarFromMetaData, clsGetColumnFromData, clsDataUnstackedFunction, clsPullFunction, clsLevels2Function,
        clsFactor2Function, clsPladmm2Function, clsMap2Function, clsNames2Function, clsDataFunction, clsGetDataFrame As New RFunction

    Private clsMapFunction As New RFunction
    Private clsCoefOperator, clsStatsOperator, clsSpaceOpreator, clsAssignOperator, clsPipeOperator, clsPipe2Operator, clsNames2Operator As New ROperator

    Private clsGetObjectFunction, clsGetRankingItemsFunction, clsGetColumn,
        clsLevelsFunction, clsFactorsFunction, clsMappingFunction, clsPladmmFunction, clsNamesFunction,
        clsCheckUniqueFunction As New RFunction
    Private clsObjectOperator, clsTildeOperator, clsTilde2Operator, clsBracketOperator, clsTilde5Operator, clsTilde6Operator,
        clsNamesOperator, clsModelOperator, clsSpaceOperator, clsTilde3Operator, clsBracket2Operator As New ROperator


    Private Sub dlgTricotModelOneVarCov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrTraitsReceiver.SetTricotType("traits")
        ucrTraitsReceiver.bAutoFill = True

        ucrSelectorVarietyLevel.SetParameter(New RParameter("data_name", 0))
        ucrSelectorVarietyLevel.SetParameterIsrfunction()

        ucrVarietyLevelReceiver.SetParameter(New RParameter("c", 0))
        ucrVarietyLevelReceiver.Selector = ucrSelectorVarietyLevel
        ucrVarietyLevelReceiver.SetParameterIsRFunction()
        ucrVarietyLevelReceiver.SetMeAsReceiver()

        bCheck7Passed = False

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
        clsTreeFunction = New RFunction
        clsVarianCovaMatrixFunction = New RFunction

        clsGetVarFromMetaData = New RFunction
        clsGetColumnFromData = New RFunction
        clsDataFunction = New RFunction
        clsDataUnstackedFunction = New RFunction
        clsPullFunction = New RFunction
        clsLevels2Function = New RFunction
        clsFactor2Function = New RFunction
        clsPladmm2Function = New RFunction
        clsMap2Function = New RFunction
        clsNames2Function = New RFunction
        clsNames2Operator = New ROperator
        clsTilde5Operator = New ROperator
        clsBracket2Operator = New ROperator
        clsPipe2Operator = New ROperator
        clsTilde6Operator = New ROperator

        clsMapFunction = New RFunction
        clsCoefOperator = New ROperator
        clsStatsOperator = New ROperator
        clsSpaceOpreator = New ROperator
        clsAssignOperator = New ROperator

        ucrTricOneVarSave.Reset()
        ucrSelectorTraitsRanking.Reset()
        ucrSelectorVarietyLevel.Reset()

        bResetSubDialog = True
        bCheck7Passed = False

        ucrInputCheckVariety.SetName("")
        ucrInputCheckVariety.txtInput.BackColor = Color.White
        ucrInputCheckVariety.IsReadOnly = True

        clsCheckUniqueFunction.SetRCommand("check_variety_data_level")
        clsCheckUniqueFunction.AddParameter("col", Chr(34) & ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False) & Chr(34), iPosition:=1)

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

        clsGetVarFromMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsGetVarFromMetaData.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.AddParameter("second", Chr(34) & "Tricot_Type" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.AddParameter("third", Chr(34) & "variety" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.SetAssignTo("variety_level_var")

        clsGetColumnFromData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnFromData.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetColumnFromData.AddParameter("y", clsRFunctionParameter:=clsGetVarFromMetaData, iPosition:=1, bIncludeArgumentName:=False)
        clsGetColumnFromData.SetAssignTo("variety_level_var")

        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrame.AddParameter("data_name", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsGetDataFrame.SetAssignTo(ucrSelectorVarietyLevel.strCurrentDataFrame)

        clsDataFunction.SetPackageName("data.table")
        clsDataFunction.SetRCommand("as.data.table")
        clsDataFunction.AddParameter("x", ucrSelectorVarietyLevel.strCurrentDataFrame, iPosition:=0, bIncludeArgumentName:=False)

        clsDataUnstackedFunction.SetPackageName("data.table")
        clsDataUnstackedFunction.SetRCommand("dcast")
        clsDataUnstackedFunction.AddParameter("data", clsRFunctionParameter:=clsDataFunction, iPosition:=0)
        clsDataUnstackedFunction.AddParameter("formula", "variety_level_var" & " + " & ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False) & " ~ " & Chr(34) & "X" & Chr(34), iPosition:=1)
        clsDataUnstackedFunction.SetAssignTo("data_unstacked")

        clsPullFunction.SetPackageName("dplyr")
        clsPullFunction.SetRCommand("pull")
        clsPullFunction.AddParameter("x", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)

        clsPipe2Operator.SetOperation("%>%")
        clsPipe2Operator.AddParameter("left", "data_unstacked", iPosition:=0, bIncludeArgumentName:=False)
        clsPipe2Operator.AddParameter("right", clsRFunctionParameter:=clsPullFunction, iPosition:=1, bIncludeArgumentName:=False)
        clsPipe2Operator.SetAssignTo(ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False))

        clsFactor2Function.SetRCommand("factor")
        clsFactor2Function.AddParameter("x", clsROperatorParameter:=clsPipe2Operator, iPosition:=0, bIncludeArgumentName:=False)

        clsLevels2Function.SetRCommand("levels")
        clsLevels2Function.AddParameter("x", clsRFunctionParameter:=clsFactor2Function, iPosition:=0, bIncludeArgumentName:=False)

        clsBracket2Operator.SetOperation("[")
        clsBracket2Operator.AddParameter("left", clsRFunctionParameter:=clsLevels2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsBracket2Operator.AddParameter("right", "1]", iPosition:=1, bIncludeArgumentName:=False)
        clsBracket2Operator.SetAssignTo("variety_baseline")
        clsBracket2Operator.bSpaceAroundOperation = False

        clsTilde5Operator.SetOperation("~")
        clsTilde5Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTilde5Operator.AddParameter("right", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)

        clsPladmm2Function.SetPackageName("PlackettLuce")
        clsPladmm2Function.SetRCommand("pladmm")
        clsPladmm2Function.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)
        clsPladmm2Function.AddParameter("y", clsROperatorParameter:=clsTilde5Operator, iPosition:=1, bIncludeArgumentName:=False)
        clsPladmm2Function.AddParameter("data", "data_unstacked", iPosition:=2)

        clsTilde6Operator.SetOperation("~")
        clsTilde6Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsTilde6Operator.AddParameter("right", clsRFunctionParameter:=clsPladmm2Function, iPosition:=1, bIncludeArgumentName:=False)

        clsMap2Function.SetPackageName("purrr")
        clsMap2Function.SetRCommand("map")
        clsMap2Function.AddParameter(".x", "rankings_object", iPosition:=0)
        clsMap2Function.AddParameter(".f", clsROperatorParameter:=clsTilde6Operator, iPosition:=1)
        clsMap2Function.SetAssignTo("mod_list")

        clsNames2Function.SetRCommand("names")
        clsNames2Function.AddParameter("x", clsRFunctionParameter:=clsMap2Function, iPosition:=0, bIncludeArgumentName:=False)

        clsNames2Operator.SetOperation("<-")
        clsNames2Operator.AddParameter("left", clsRFunctionParameter:=clsNames2Function, iPosition:=0, bIncludeArgumentName:=False)
        clsNames2Operator.AddParameter("right", "vars", iPosition:=1, bIncludeArgumentName:=False)

        clsLevelsFunction.SetRCommand("levels")
        clsLevelsFunction.AddParameter("x", clsRFunctionParameter:=clsFactorsFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsFactorsFunction.SetRCommand("factor")
        clsFactorsFunction.AddParameter("x", clsRFunctionParameter:=clsGetColumn, iPosition:=0, bIncludeArgumentName:=False)

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
        clsPladmmFunction.AddParameter("data", "data_unstacked", iPosition:=2)

        clsTilde2Operator.SetOperation("~")
        clsTilde2Operator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", clsRFunctionParameter:=clsMappingFunction, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction, iPosition:=0)
        clsNamesOperator.AddParameter("right", "vars", iPosition:=1)

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
        clsHeatFunction.bExcludeAssignedFunctionOutput = False
        clsHeatFunction.iCallType = 3

        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod_list", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorVarietyLevel.strCurrentDataFrame,
                                                  strObjectName:="last_model")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetRankingItemsFunction, iPosition:=3)
        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)

    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsRanking.AddAdditionalCodeParameterPair(clsGetVariablesMetadataFunction, ucrSelectorTraitsRanking.GetParameter(), iAdditionalPairNo:=1)

        ucrSelectorVarietyLevel.AddAdditionalCodeParameterPair(clsGetColumn, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrSelectorVarietyLevel.AddAdditionalCodeParameterPair(clsGetVarFromMetaData, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrSelectorVarietyLevel.AddAdditionalCodeParameterPair(clsGetColumnFromData, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrSelectorVarietyLevel.AddAdditionalCodeParameterPair(clsDataFunction, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrSelectorVarietyLevel.AddAdditionalCodeParameterPair(clsCheckUniqueFunction, New RParameter("x", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)

        ucrSelectorTraitsRanking.SetRCode(clsGetObjectFunction, bReset)
        ucrSelectorVarietyLevel.SetRCode(clsGetDataFrame, bReset)
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
        clsPullFunction.AddParameter("x", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
        clsDataUnstackedFunction.AddParameter("formula", "variety_level_var" & " + " & ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False) & " ~ " & Chr(34) & "X" & Chr(34), iPosition:=1)
        clsTilde5Operator.AddParameter("right", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=1, bIncludeArgumentName:=False)
        clsPipe2Operator.SetAssignTo(ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False))
        clsFactor2Function.AddParameter("x", ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False), iPosition:=0, bIncludeArgumentName:=False)
        clsCheckUniqueFunction.AddParameter("col", Chr(34) & ucrVarietyLevelReceiver.GetVariableNames(bWithQuotes:=False) & Chr(34), iPosition:=1)
        CheckVarietyUnique()
        CheckAddCodesToBefore()
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
            ElseIf iAnyDuplicated = 7 Then
                ucrInputCheckVariety.SetName("Success. This data is at the plot level, but it can be used.")
                ucrInputCheckVariety.txtInput.BackColor = Color.LightGreen
                bIsUnique = True
                bCheck7Passed = True
            ElseIf iAnyDuplicated = 8 Then
                ucrInputCheckVariety.SetName("This data is at the plot level. Either use variety-level data, or use data where there is only one level of 'col' for each variety level.")
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

    Private Sub CheckAddCodesToBefore()
        If bCheck7Passed Then
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsBracketOperator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsNamesOperator)

            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetColumnFromData, iPosition:=4)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDataFrame, iPosition:=5)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsDataUnstackedFunction, iPosition:=6)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsPipe2Operator, iPosition:=7)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsBracket2Operator, iPosition:=8)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNames2Operator, iPosition:=9)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetColumnFromData)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDataFrame)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsDataUnstackedFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsPipe2Operator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsBracket2Operator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsNames2Operator)

            ucrBase.clsRsyntax.AddToBeforeCodes(clsBracketOperator, iPosition:=4)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=5)
        End If
    End Sub

    Private Sub ucrSelectorVarietyLevel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorVarietyLevel.ControlValueChanged
        clsGetColumn.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetVarFromMetaData.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetColumnFromData.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsDataFunction.AddParameter("x", ucrSelectorVarietyLevel.strCurrentDataFrame, iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrame.AddParameter("data_name", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0)
        clsGetDataFrame.SetAssignTo(ucrSelectorVarietyLevel.strCurrentDataFrame)
        clsCheckUniqueFunction.AddParameter("x", Chr(34) & ucrSelectorVarietyLevel.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
    End Sub

    Private Sub btnModelOptions_Click(sender As Object, e As EventArgs) Handles btnModelOptions.Click
        sdgTricotModelOptions.enumTricotModelOptionsMode = sdgTricotModelOptions.TricotModelOptionsMode.ModelOneVarCov
        sdgTricotModelOptions.SetRCode(clsNewRFunction:=clsPladmmFunction, clsNewRSyntax:=ucrBase.clsRsyntax, bReset:=bResetSubDialog)
        sdgTricotModelOptions.ShowDialog(Me)
        bResetSubDialog = False
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles btnDisplayOptions.Click
        sdgDisplayModelOptions.enumPlacketLuceModelMode = sdgDisplayModelOptions.PlacketLuceModelMode.ModelOneVarCov2
        sdgDisplayModelOptions.SetRCode(clsNewWrapBarFunction:=clsWrapBarFunction, clsNewWrapPlotFunction:=clsWrapPlotFunction,
                                        clsNewHeatFunction:=clsHeatFunction, clsNewPlotFunction:=clsPlotFunction, clsNewBarfunction:=clsBarfunction,
                                        clsNewAnnovaFunction:=clsAnnovaFunction, clsNewSummaryFunction:=clsSummaryFunction, clsNewAICFunction:=clsAICFunction,
                                        clsNewCoefFunction:=clsCoefFunction, clsNewConfidenLimFunction:=clsConfidenLimFunction, clsNewWrapTree:=clsWrapTrees,
                                        clsNewDevianceFunction:=clsDevianceFunction, clsNewEstimatesFunction:=clsEstimatesFunction, clsNewImportDataFunction:=clsImportDataFunction, clsNewDefineAsTricotFunction:=clsDefineAsTricotFunction, clsNewPipeOperator:=clsPipeOperator, clsNewItemsFunction:=clsItemsFunction,
                                        clsNewPariPropFunction:=clsPariPropFunction, clsNewQuasivarianceFunction:=clsQuasivarianceFunction, clsNewReliabilityFunction:=clsReliabilityFunction,
                                        clsNewRSyntax:=ucrBase.clsRsyntax, clsNewSecondEstimatesFunction:=clsSecondEstimatesFunction, clsNewStatsFunction:=clsStatsFunction, clsNewRegretFunction:=clsRegretFunction,
                                        clsNewTopItemFunction:=clsTopItemFunction, clsNewNodeRuleFunction:=clsNodeRuleFunction, clsNewNodeLabFuction:=clsNodeLabFuction,
                                        clsNewTreeFunction:=clsTreeFunction, clsNewVarianCovaMatrixFunction:=clsVarianCovaMatrixFunction, bReset:=bResetSubDialog)
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
