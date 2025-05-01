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

Public Class dlgPlacketLuceModel
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private clsGetDataFrameFunction, clsSndgetVarmataFunction, clsLevelFunction, clsFactorFunction, clsNamesFunction, clsGetVarMetadataFunction, clsGetObjectRFunction, clsRankingsItemsFunction, clsVarFunction, clsMapFunction, clsPlacketFunction As RFunction
    Private clsPlotFunction, clsWrapPlotFunction, clsWrapBarFunction, clsHeatFunction, clsBarfunction, clsNodeLabFuction, clsNodeRuleFunction, clsTopItemFunction, clsRegretFunction, clsSummaryFunction, clsAnnovaFunction, clsEstimatesFunction, clsConfidenLimFunction, clsAICFunction, clsDevianceFunction, clsSecondEstimatesFunction, clsPariPropFunction, clsReliabilityFunction, clsItemsFunction, clsVarianCovaMatrixFunction, clsQuasivarianceFunction As RFunction
    Private clsCoefFunction, clsStatsFunction As RFunction
    Private clsStatsOperator, clsCoefOperator As ROperator
    Private clsAssignOperator, clsSpaceOpreator As ROperator
    Private clsGetRankingOperator, clsModelOperator, clsPlacketOperator, clsNamesOperator As ROperator

    Private Sub dlgPlacketLuceModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorTraitsPL.SetParameter(New RParameter("data_name", 0))
        ucrSelectorTraitsPL.SetParameterIsString()

        ucrReceiverMultipleTraits.SetParameter(New RParameter("vars_to_get", 1, False))
        ucrReceiverMultipleTraits.SetParameterIsString()
        ucrReceiverMultipleTraits.Selector = ucrSelectorTraitsPL
        ucrReceiverMultipleTraits.strSelectorHeading = "Traits"
        ucrReceiverMultipleTraits.SetMeAsReceiver()
        ucrReceiverMultipleTraits.SetTricotType({"traits"})
        ucrReceiverMultipleTraits.SetLinkedDisplayControl(lblTraits)

        ucrSaveResult.SetPrefix("model")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Store Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("last_model")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorTraitsPL.ucrAvailableDataFrames)

        cmdModelOptions.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsGetVarMetadataFunction = New RFunction
        clsRankingsItemsFunction = New RFunction
        clsGetObjectRFunction = New RFunction
        clsVarFunction = New RFunction
        clsMapFunction = New RFunction
        clsPlacketFunction = New RFunction
        clsNamesFunction = New RFunction
        clsAnnovaFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsEstimatesFunction = New RFunction
        clsConfidenLimFunction = New RFunction
        clsAICFunction = New RFunction
        clsDevianceFunction = New RFunction
        clsSecondEstimatesFunction = New RFunction
        clsPariPropFunction = New RFunction
        clsReliabilityFunction = New RFunction
        clsItemsFunction = New RFunction
        clsVarianCovaMatrixFunction = New RFunction
        clsQuasivarianceFunction = New RFunction
        clsStatsFunction = New RFunction
        clsCoefFunction = New RFunction
        clsPlotFunction = New RFunction
        clsHeatFunction = New RFunction
        clsBarfunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsSndgetVarmataFunction = New RFunction
        clsLevelFunction = New RFunction
        clsFactorFunction = New RFunction
        clsWrapBarFunction = New RFunction
        clsWrapPlotFunction = New RFunction

        clsSpaceOpreator = New ROperator
        clsAssignOperator = New ROperator
        clsGetRankingOperator = New ROperator
        clsPlacketOperator = New ROperator
        clsNamesOperator = New ROperator
        clsModelOperator = New ROperator
        clsStatsOperator = New ROperator
        clsCoefOperator = New ROperator

        ucrSelectorTraitsPL.Reset()
        ucrSaveResult.Reset()

        bResetSubdialog = True

        clsVarFunction.SetRCommand("")
        clsVarFunction.SetAssignTo("vars")

        clsGetVarMetadataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVarMetadataFunction.SetAssignTo("get_index_names")

        clsGetObjectRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object")
        clsGetObjectRFunction.AddParameter("object_name", Chr(34) & "rankings_list" & Chr(34), iPosition:=1)

        clsGetRankingOperator.SetOperation("$")
        clsGetRankingOperator.AddParameter("left", clsRFunctionParameter:=clsGetObjectRFunction, iPosition:=0)
        clsGetRankingOperator.AddParameter("right", "object", iPosition:=1)
        clsGetRankingOperator.bSpaceAroundOperation = False
        clsGetRankingOperator.SetAssignTo("rankings_object")

        clsRankingsItemsFunction.SetRCommand("get_ranking_items")
        clsRankingsItemsFunction.AddParameter("data", clsRFunctionParameter:=clsGetVarMetadataFunction, iPosition:=0)
        clsRankingsItemsFunction.AddParameter("vars_to_get", clsRFunctionParameter:=clsVarFunction, iPosition:=1)
        clsRankingsItemsFunction.AddParameter("index", Chr(34) & "rankings_index" & Chr(34), iPosition:=2)
        clsRankingsItemsFunction.AddParameter("rankings_object", clsROperatorParameter:=clsGetRankingOperator, bIncludeArgumentName:=False, iPosition:=3)
        clsRankingsItemsFunction.SetAssignTo("rankings_object")

        clsMapFunction.SetPackageName("purrr")
        clsMapFunction.SetRCommand("map")
        clsMapFunction.AddParameter(".x", "rankings_object", iPosition:=0)
        clsMapFunction.AddParameter(".f", clsROperatorParameter:=clsPlacketOperator, iPosition:=1)
        clsMapFunction.SetAssignTo("mod")

        clsPlacketOperator.SetOperation("~")
        clsPlacketOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsPlacketOperator.AddParameter("right", clsRFunctionParameter:=clsPlacketFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsPlacketFunction.SetPackageName("PlackettLuce")
        clsPlacketFunction.SetRCommand("PlackettLuce")
        clsPlacketFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)

        clsNamesOperator.SetOperation("<-")
        clsNamesOperator.AddParameter("left", clsRFunctionParameter:=clsNamesFunction)
        clsNamesOperator.AddParameter("right", "vars")
        clsNamesOperator.bAllBrackets = False

        clsNamesFunction.SetRCommand("names")
        clsNamesFunction.AddParameter("x", "mod", iPosition:=0, bIncludeArgumentName:=False)

        clsAnnovaFunction.SetPackageName("purrr")
        clsAnnovaFunction.SetRCommand("map")
        clsAnnovaFunction.AddParameter(".x", "mod", iPosition:=0)
        clsAnnovaFunction.AddParameter(".f", "~gosset:::anova.PlackettLuce(.x)", iPosition:=1)
        clsAnnovaFunction.iCallType = 2

        clsSummaryFunction.SetPackageName("purrr")
        clsSummaryFunction.SetRCommand("map")
        clsSummaryFunction.AddParameter(".x", "mod", iPosition:=0)
        clsSummaryFunction.AddParameter(".f", "~summary(.x)", iPosition:=1)
        clsSummaryFunction.iCallType = 2

        clsEstimatesFunction.SetPackageName("purrr")
        clsEstimatesFunction.SetRCommand("map")
        clsEstimatesFunction.AddParameter(".x", "mod", iPosition:=0)
        clsEstimatesFunction.AddParameter(".f", clsROperatorParameter:=clsCoefOperator, iPosition:=1)
        clsEstimatesFunction.iCallType = 2

        clsCoefOperator.SetOperation("~")
        clsCoefOperator.AddParameter("left", "", iPosition:=0, bIncludeArgumentName:=False)
        clsCoefOperator.AddParameter("right", clsRFunctionParameter:=clsCoefFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsCoefFunction.SetRCommand("coef")
        clsCoefFunction.AddParameter("x", ".x", iPosition:=0, bIncludeArgumentName:=False)

        clsConfidenLimFunction.SetPackageName("purrr")
        clsConfidenLimFunction.SetRCommand("map")
        clsConfidenLimFunction.AddParameter(".x", "mod", iPosition:=0)
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
        clsAICFunction.AddParameter(".x", "mod", iPosition:=0)
        clsAICFunction.AddParameter(".f", "~AIC(.x)", iPosition:=1)
        clsAICFunction.iCallType = 2

        clsDevianceFunction.SetPackageName("purrr")
        clsDevianceFunction.SetRCommand("map")
        clsDevianceFunction.AddParameter(".x", "mod", iPosition:=0)
        clsDevianceFunction.AddParameter(".f", "~deviance(.x)", iPosition:=1)
        clsDevianceFunction.iCallType = 2

        clsSecondEstimatesFunction.SetPackageName("purrr")
        clsSecondEstimatesFunction.SetRCommand("map")
        clsSecondEstimatesFunction.AddParameter(".x", "mod", iPosition:=0)
        clsSecondEstimatesFunction.AddParameter(".f", "~fitted.values(.x)", iPosition:=1)
        clsSecondEstimatesFunction.iCallType = 2

        clsPariPropFunction.SetPackageName("purrr")
        clsPariPropFunction.SetRCommand("map")
        clsPariPropFunction.AddParameter(".x", "mod", iPosition:=0)
        clsPariPropFunction.AddParameter(".f", "~gosset::pairwise_probs(coef(.x))", iPosition:=1)
        clsPariPropFunction.iCallType = 2

        clsReliabilityFunction.SetPackageName("purrr")
        clsReliabilityFunction.SetRCommand("map")
        clsReliabilityFunction.AddParameter(".x", "purrr::imap(.x = mod,  .f = ~gosset::reliability(.x, ref = variety_baseline))", iPosition:=0)
        clsReliabilityFunction.AddParameter(".f", "~ .x %>% dplyr::mutate(reliability_rescaled = round(reliability / 0.5 - 1, 2))", iPosition:=1)
        clsReliabilityFunction.iCallType = 2

        clsItemsFunction.SetPackageName("purrr")
        clsItemsFunction.SetRCommand("map")
        clsItemsFunction.AddParameter(".x", "mod", iPosition:=0)
        clsItemsFunction.AddParameter(".f", "~PlackettLuce::itempar(.x)", iPosition:=1)
        clsItemsFunction.iCallType = 2

        clsVarianCovaMatrixFunction.SetPackageName("purrr")
        clsVarianCovaMatrixFunction.SetRCommand("map")
        clsVarianCovaMatrixFunction.AddParameter(".x", "mod", iPosition:=0)
        clsVarianCovaMatrixFunction.AddParameter(".f", "~vcov(.x)", iPosition:=1)
        clsVarianCovaMatrixFunction.iCallType = 2

        clsQuasivarianceFunction.SetPackageName("purrr")
        clsQuasivarianceFunction.SetRCommand("map")
        clsQuasivarianceFunction.AddParameter(".x", "mod", iPosition:=0)
        clsQuasivarianceFunction.AddParameter(".f", "~qvcalc::qvcalc(PlackettLuce::itempar(.x))", iPosition:=1)
        clsQuasivarianceFunction.iCallType = 2

        clsAssignOperator.SetOperation("<-")
        Dim strDataname As String = ucrSelectorTraitsPL.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        Dim strData As String = strDataname.Replace("""", "")
        clsAssignOperator.AddParameter("left", strData, iPosition:=0, bIncludeArgumentName:=False)
        clsAssignOperator.AddParameter("right", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsSndgetVarmataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_from_metadata")
        clsSndgetVarmataFunction.AddParameter("property", Chr(34) & "Tricot_Type" & Chr(34), iPosition:=1)
        clsSndgetVarmataFunction.AddParameter("property_value", Chr(34) & "variety" & Chr(34), iPosition:=2)
        clsSndgetVarmataFunction.SetAssignTo("var_name")

        clsSpaceOpreator.SetOperation("")
        clsSpaceOpreator.AddParameter("left", clsRFunctionParameter:=clsLevelFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSpaceOpreator.AddParameter("right", "[1]", iPosition:=1, bIncludeArgumentName:=False)
        clsSpaceOpreator.SetAssignTo("variety_baseline")
        clsSpaceOpreator.bSpaceAroundOperation = False

        clsLevelFunction.SetRCommand("levels")
        clsLevelFunction.AddParameter("x", clsRFunctionParameter:=clsFactorFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", ucrSelectorTraitsPL.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "[[var_name]]")

        clsPlotFunction.SetPackageName("purrr")
        clsPlotFunction.SetRCommand("map2")
        clsPlotFunction.AddParameter(".x", "mod", iPosition:=0)
        clsPlotFunction.AddParameter(".y", "names(mod)", iPosition:=1)
        clsPlotFunction.AddParameter(".f", "~gosset:::plot.PlackettLuce(x = .x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsPlotFunction.SetAssignTo("list_of_plots")

        clsHeatFunction.SetPackageName("gosset")
        clsHeatFunction.SetRCommand("worth_map")
        clsHeatFunction.AddParameter(".x", "mod", iPosition:=0, bIncludeArgumentName:=False)
        clsHeatFunction.AddParameter("labels", "names(mod)", iPosition:=1)
        clsHeatFunction.bExcludeAssignedFunctionOutput = False
        clsHeatFunction.iCallType = 3

        clsBarfunction.SetPackageName("purrr")
        clsBarfunction.SetRCommand("map2")
        clsBarfunction.AddParameter(".x", "mod", iPosition:=0)
        clsBarfunction.AddParameter(".y", "names(mod)", iPosition:=1)
        clsBarfunction.AddParameter(".f", "~gosset::worth_bar(.x) + ggplot2::ggtitle(.y)", iPosition:=2)
        clsBarfunction.SetAssignTo("list_of_plots")

        clsWrapPlotFunction.SetPackageName("patchwork")
        clsWrapPlotFunction.SetRCommand("wrap_plots")
        clsWrapPlotFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapPlotFunction.bExcludeAssignedFunctionOutput = False
        clsWrapPlotFunction.iCallType = 3

        clsWrapBarFunction.SetPackageName("patchwork")
        clsWrapBarFunction.SetRCommand("wrap_plots")
        clsWrapBarFunction.AddParameter("x", "list_of_plots", iPosition:=0, bIncludeArgumentName:=False)
        clsWrapBarFunction.bExcludeAssignedFunctionOutput = False
        clsWrapBarFunction.iCallType = 3

        clsModelOperator.SetOperation("")
        clsModelOperator.AddParameter("left", "mod", iPosition:=0)
        clsModelOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorTraitsPL.strCurrentDataFrame,
                                                  strObjectName:="last_model")

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsRankingsItemsFunction, iPosition:=3)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsMapFunction, iPosition:=4)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=5)
        ucrBase.clsRsyntax.SetBaseROperator(clsModelOperator)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSelectorTraitsPL.AddAdditionalCodeParameterPair(clsGetObjectRFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrSelectorTraitsPL.AddAdditionalCodeParameterPair(clsGetDataFrameFunction, New RParameter("x", 0, False), iAdditionalPairNo:=2)
        ucrSelectorTraitsPL.AddAdditionalCodeParameterPair(clsSndgetVarmataFunction, New RParameter("data_name", 0), iAdditionalPairNo:=3)
        ucrReceiverMultipleTraits.SetRCode(clsVarFunction, bReset)
        ucrSelectorTraitsPL.SetRCode(clsGetVarMetadataFunction, bReset)
        ucrSaveResult.SetRCode(clsModelOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverMultipleTraits.IsEmpty AndAlso ucrSaveResult.IsComplete)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTraitsPL.ControlContentsChanged, ucrReceiverMultipleTraits.ControlContentsChanged, ucrSaveResult.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgDisplayModelOptions.SetRCode(clsNewWrapBarFunction:=clsWrapBarFunction, clsNewWrapPlotFunction:=clsWrapPlotFunction, clsNewHeatFunction:=clsHeatFunction, clsNewPlotFunction:=clsPlotFunction, clsNewBarfunction:=clsBarfunction, clsNewAnnovaFunction:=clsAnnovaFunction, clsNewSummaryFunction:=clsSummaryFunction, clsNewAICFunction:=clsAICFunction, clsNewCoefFunction:=clsCoefFunction, clsNewConfidenLimFunction:=clsConfidenLimFunction, clsNewDevianceFunction:=clsDevianceFunction, clsNewEstimatesFunction:=clsEstimatesFunction, clsNewItemsFunction:=clsItemsFunction, clsNewPariPropFunction:=clsPariPropFunction, clsNewQuasivarianceFunction:=clsQuasivarianceFunction, clsNewReliabilityFunction:=clsReliabilityFunction, clsNewRSyntax:=ucrBase.clsRsyntax, clsNewSecondEstimatesFunction:=clsSecondEstimatesFunction, clsNewStatsFunction:=clsStatsFunction, clsNewRegretFunction:=clsRegretFunction, clsNewTopItemFunction:=clsTopItemFunction, clsNewNodeRuleFunction:=clsNodeRuleFunction, clsNewNodeLabFuction:=clsNodeLabFuction, clsNewVarianCovaMatrixFunction:=clsVarianCovaMatrixFunction, bReset:=bResetSubdialog)
        sdgDisplayModelOptions.ucrChkRegret.Enabled = False
        sdgDisplayModelOptions.ucrChkNodeLabel.Enabled = False
        sdgDisplayModelOptions.ucrChkNodeRules.Enabled = False
        sdgDisplayModelOptions.ucrChkTopItem.Enabled = False
        sdgDisplayModelOptions.ShowDialog()
        bResetSubdialog = False
        AddRemoveFunctions()
    End Sub

    Private Sub AddRemoveFunctions()
        If sdgDisplayModelOptions.ucrChkReability.Checked OrElse sdgDisplayModelOptions.ucrChkHeat.Checked OrElse sdgDisplayModelOptions.ucrChkBar.Checked Then
            clsMapFunction.AddParameter("ref", "variety_baseline", iPosition:=2)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsAssignOperator, iPosition:=4)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsSndgetVarmataFunction, iPosition:=5)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsSpaceOpreator, iPosition:=6)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsMapFunction, iPosition:=7)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=8)
        Else
            clsMapFunction.RemoveParameterByName("ref")
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAssignOperator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSpaceOpreator)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSndgetVarmataFunction)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsMapFunction, iPosition:=4)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsNamesOperator, iPosition:=5)
        End If
    End Sub
End Class
