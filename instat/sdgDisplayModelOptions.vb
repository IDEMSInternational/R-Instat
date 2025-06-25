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

Public Class sdgDisplayModelOptions
    Private clsSummaryFunction, clsNodeLabFuction, clsNodeRuleFunction, clsTopItemFunction, clsRegretFunction, clsAnnovaFunction, clsEstimatesFunction, clsConfidenLimFunction,
        clsAICFunction, clsDevianceFunction, clsSecondEstimatesFunction, clsPariPropFunction, clsReliabilityFunction, clsItemsFunction, clsVarianCovaMatrixFunction, clsQuasivarianceFunction As RFunction
    Private clsCoefFunction, clsStatsFunction, clsImportDataFunction, clsDefineAsTricotFunction As RFunction
    Private clsDummyFunction, clsPlotFunction, clsHeatFunction, clsWrapBarFunction, clsWrapPlotFunction, clsBarfunction, clsTreeFunction, clsWrapTrees As RFunction
    Private clsPipeOperator As New ROperator
    Private bControlsInitialised As Boolean = False
    Private bInitialised As Boolean = False
    Public enumPlacketLuceModelMode As String = PlacketLuceModelMode.nocovariates

    Private clsRSyntax As New RSyntax

    Private Sub sdgDisplayModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        SetHelpOptions()
    End Sub

    Public Enum PlacketLuceModelMode
        nocovariates
        tree
        ModelOneVarCov2
        ModellingGeneral2
    End Enum

    Private Sub InitialiseDialog()
        ucrChkModel.SetText("Summary")
        ucrChkModel.AddParameterValuesCondition(True, "summary", "True")
        ucrChkModel.AddParameterValuesCondition(False, "summary", "False")

        ucrChkANOVA.SetText("ANOVA")
        ucrChkANOVA.AddRSyntaxContainsFunctionNamesCondition(True, {"gosset:::anova.PlackettLuce(.x)"}, True)
        ucrChkANOVA.AddRSyntaxContainsFunctionNamesCondition(False, {"gosset:::anova.PlackettLuce(.x)"}, False)

        ucrChkEstimates.SetText("Coefficients")
        ucrChkEstimates.AddRSyntaxContainsFunctionNamesCondition(True, {"coef"}, True)
        ucrChkEstimates.AddRSyntaxContainsFunctionNamesCondition(False, {"coef"}, False)
        ucrChkEstimates.AddToLinkedControls({ucrChkLog, ucrChkSave}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkLog.SetText("Log")
        ucrChkLog.AddRSyntaxContainsFunctionNamesCondition(True, {"log"}, True)
        ucrChkLog.AddRSyntaxContainsFunctionNamesCondition(False, {"log"}, False)

        ucrChkSave.SetText("Store as Data Frame")
        ucrChkSave.AddRSyntaxContainsFunctionNamesCondition(True, {"save"}, True)
        ucrChkSave.AddRSyntaxContainsFunctionNamesCondition(False, {"save"}, False)

        ucrChkConfLimits.SetText("Confidence Limits")
        ucrChkConfLimits.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"}, True)
        ucrChkConfLimits.AddRSyntaxContainsFunctionNamesCondition(False, {"confint"}, False)
        ucrChkConfLimits.AddToLinkedControls(ucrNudConfLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True) ', bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.95")

        ucrNudConfLevel.SetParameter(New RParameter("level"))
        ucrNudConfLevel.DecimalPlaces = 2
        ucrNudConfLevel.Increment = 0.01
        ucrNudConfLevel.SetMinMax(0, 1)
        ucrNudConfLevel.SetLinkedDisplayControl(lblConfLevel)

        ucrChkAIC.SetText("AIC")
        ucrChkAIC.AddRSyntaxContainsFunctionNamesCondition(True, {"aic"}, True)
        ucrChkAIC.AddRSyntaxContainsFunctionNamesCondition(False, {"aic"}, False)

        ucrChkDeviance.SetText("Deviance")
        ucrChkDeviance.AddRSyntaxContainsFunctionNamesCondition(True, {"deviance"}, True)
        ucrChkDeviance.AddRSyntaxContainsFunctionNamesCondition(False, {"deviance"}, False)

        ucrChkSndEstimetes.SetText("Fitted Values")
        ucrChkSndEstimetes.AddRSyntaxContainsFunctionNamesCondition(True, {"snd_estimates"}, True)
        ucrChkSndEstimetes.AddRSyntaxContainsFunctionNamesCondition(False, {"snd_estimates"}, False)

        ucrChkParProp.SetText("Pairewise Probabilities")
        ucrChkParProp.AddRSyntaxContainsFunctionNamesCondition(True, {"pair"}, True)
        ucrChkParProp.AddRSyntaxContainsFunctionNamesCondition(False, {"pair"}, False)

        ucrChkReability.SetText("Reliability")
        ucrChkReability.AddRSyntaxContainsFunctionNamesCondition(True, {"reliability"}, True)
        ucrChkReability.AddRSyntaxContainsFunctionNamesCondition(False, {"reliability"}, False)

        ucrChkItemPara.SetText("Item Parameters")
        ucrChkItemPara.AddRSyntaxContainsFunctionNamesCondition(True, {"item"}, True)
        ucrChkItemPara.AddRSyntaxContainsFunctionNamesCondition(False, {"item"}, False)

        ucrChkVaCoMa.SetText("Variance-Covariance Matrix")
        ucrChkVaCoMa.AddRSyntaxContainsFunctionNamesCondition(True, {"vacoma"}, True)
        ucrChkVaCoMa.AddRSyntaxContainsFunctionNamesCondition(False, {"vacoma"}, False)

        ucrChkQuasiVa.SetText("Quasi Variance")
        ucrChkQuasiVa.AddRSyntaxContainsFunctionNamesCondition(True, {"quasi"}, True)
        ucrChkQuasiVa.AddRSyntaxContainsFunctionNamesCondition(False, {"quasi"}, False)

        ucrChkRegret.SetText("Regret")
        ucrChkRegret.AddRSyntaxContainsFunctionNamesCondition(True, {"regret"}, True)
        ucrChkRegret.AddRSyntaxContainsFunctionNamesCondition(False, {"regret"}, False)

        ucrChkNodeLabel.SetText("Node Labels")
        ucrChkNodeLabel.AddRSyntaxContainsFunctionNamesCondition(True, {"node_label"}, True)
        ucrChkNodeLabel.AddRSyntaxContainsFunctionNamesCondition(False, {"node_label"}, False)

        ucrChkNodeRules.SetText("Node Rules")
        ucrChkNodeRules.AddRSyntaxContainsFunctionNamesCondition(True, {"node_rules"}, True)
        ucrChkNodeRules.AddRSyntaxContainsFunctionNamesCondition(False, {"node_rules"}, False)

        ucrChkTopItem.SetText("Top Items")
        ucrChkTopItem.AddRSyntaxContainsFunctionNamesCondition(True, {"top_items"}, True)
        ucrChkTopItem.AddRSyntaxContainsFunctionNamesCondition(False, {"top_items"}, False)
        ucrChkTopItem.AddToLinkedControls(ucrNudNumber, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrNudNumber.SetParameter(New RParameter("level"))
        ucrNudNumber.Increment = 1
        ucrNudNumber.SetMinMax(0, 100)
        ucrNudNumber.SetLinkedDisplayControl(lblNumber)
        ucrNudNumber.SetRDefault(1)

        If Not bInitialised Then
            ucrPnlPlots.AddRadioButton(rdoNoPlot)
            ucrPnlPlots.AddRadioButton(rdoPlot)
            ucrPnlPlots.AddRadioButton(rdoMap)
            ucrPnlPlots.AddRadioButton(rdoBar)
            ucrPnlPlots.AddRadioButton(rdoTree)
            ucrPnlPlots.AddParameterValuesCondition(rdoNoPlot, "plot", "True")
            ucrPnlPlots.AddParameterValuesCondition(rdoPlot, "plot", "False")
            ucrPnlPlots.AddParameterValuesCondition(rdoMap, "plot", "False")
            ucrPnlPlots.AddParameterValuesCondition(rdoBar, "plot", "False")
            ucrPnlPlots.AddParameterValuesCondition(rdoTree, "plot", "False")
            ucrPnlPlots.AddToLinkedControls({ucrChkLogGraphic}, {rdoMap}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
            ucrPnlPlots.AddToLinkedControls({ucrSavePlots}, {rdoMap, rdoBar, rdoPlot}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
            bInitialised = True
        End If

        ucrChkLogGraphic.SetText("Log")

        ucrSavePlots.SetPrefix("plot")
        ucrSavePlots.SetSaveTypeAsGraph()
        ucrSavePlots.SetDataFrameSelector(dlgPlacketLuceModel.ucrSelectorTraitsPL.ucrAvailableDataFrames)
        ucrSavePlots.SetCheckBoxText("Store Graph")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_graph")

        ucrChkLogGraphic.Enabled = False
        bControlsInitialised = False
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewWrapPlotFunction As RFunction, clsNewWrapBarFunction As RFunction, clsNewSummaryFunction As RFunction, clsNewAnnovaFunction As RFunction, clsNewEstimatesFunction As RFunction,
                        clsNewImportDataFunction As RFunction, clsNewDefineAsTricotFunction As RFunction, clsNewPipeOperator As ROperator, clsNewConfidenLimFunction As RFunction, clsNewAICFunction As RFunction, clsNewDevianceFunction As RFunction,
                        clsNewSecondEstimatesFunction As RFunction, clsNewPariPropFunction As RFunction, clsNewReliabilityFunction As RFunction, clsNewItemsFunction As RFunction, clsNewVarianCovaMatrixFunction As RFunction,
                        clsNewQuasivarianceFunction As RFunction, clsNewCoefFunction As RFunction, clsNewStatsFunction As RFunction, clsNewNodeLabFuction As RFunction, clsNewNodeRuleFunction As RFunction, clsNewTopItemFunction As RFunction,
                        clsNewRegretFunction As RFunction, clsNewPlotFunction As RFunction, clsNewHeatFunction As RFunction, clsNewBarfunction As RFunction, clsNewTreeFunction As RFunction, clsNewWrapTree As RFunction, Optional bReset As Boolean = False)

        ucrNudConfLevel.SetText("0.95")
        If Not bControlsInitialised Then
            InitialiseDialog()
        End If

        clsRSyntax = clsNewRSyntax
        clsDummyFunction = New RFunction
        clsDummyFunction.AddParameter("plot", "True", iPosition:=0)
        clsDummyFunction.AddParameter("summary", "True", iPosition:=1)
        clsAnnovaFunction = clsNewAnnovaFunction
        clsSummaryFunction = clsNewSummaryFunction
        clsEstimatesFunction = clsNewEstimatesFunction
        clsDefineAsTricotFunction = clsNewDefineAsTricotFunction
        clsImportDataFunction = clsNewImportDataFunction
        clsPipeOperator = clsNewPipeOperator
        clsConfidenLimFunction = clsNewConfidenLimFunction
        clsAICFunction = clsNewAICFunction
        clsDevianceFunction = clsNewDevianceFunction
        clsSecondEstimatesFunction = clsNewSecondEstimatesFunction
        clsPariPropFunction = clsNewPariPropFunction
        clsReliabilityFunction = clsNewReliabilityFunction
        clsItemsFunction = clsNewItemsFunction
        clsVarianCovaMatrixFunction = clsNewVarianCovaMatrixFunction
        clsQuasivarianceFunction = clsNewQuasivarianceFunction
        clsCoefFunction = clsNewCoefFunction
        clsStatsFunction = clsNewStatsFunction
        clsNodeLabFuction = clsNewNodeLabFuction
        clsNodeRuleFunction = clsNewNodeRuleFunction
        clsTopItemFunction = clsNewTopItemFunction
        clsRegretFunction = clsNewRegretFunction
        clsPlotFunction = clsNewPlotFunction
        clsHeatFunction = clsNewHeatFunction
        clsBarfunction = clsNewBarfunction
        clsTreeFunction = clsNewTreeFunction
        clsWrapBarFunction = clsNewWrapBarFunction
        clsWrapPlotFunction = clsNewWrapPlotFunction
        clsWrapTrees = clsNewWrapTree

        If bReset Then
            ucrChkANOVA.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkModel.SetRCode(clsDummyFunction, bReset)
            ucrChkEstimates.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkSave.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkLog.SetRCode(clsCoefFunction, bReset, bCloneIfNeeded:=True)
            ucrChkAIC.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkConfLimits.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrNudConfLevel.SetRCode(clsStatsFunction, bReset, bCloneIfNeeded:=True)
            ucrChkDeviance.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkItemPara.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkNodeLabel.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkNodeRules.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkParProp.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkQuasiVa.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkReability.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkRegret.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkSndEstimetes.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkTopItem.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrChkVaCoMa.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrNudConfLevel.SetRCode(clsStatsFunction, bReset)
            ucrSavePlots.AddAdditionalRCode(clsWrapPlotFunction, 1)
            ucrSavePlots.AddAdditionalRCode(clsWrapBarFunction, 2)
            ucrSavePlots.SetRCode(clsHeatFunction, bReset, bCloneIfNeeded:=True)
            ucrChkLogGraphic.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
            ucrPnlPlots.SetRCode(clsDummyFunction, bReset)
        End If
        AddRemoveSummary()
    End Sub

    Private Sub ucrChkAIC_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAIC.ControlValueChanged
        If ucrChkAIC.Checked Then
            clsRSyntax.AddToBeforeCodes(clsAICFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsAICFunction)
        End If
    End Sub

    Private Sub ucrChkANOVA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkANOVA.ControlValueChanged
        If ucrChkANOVA.Checked Then
            clsRSyntax.AddToBeforeCodes(clsAnnovaFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsAnnovaFunction)
        End If
    End Sub

    Private Sub ucrChkConfLimits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConfLimits.ControlValueChanged
        If ucrChkConfLimits.Checked Then
            clsRSyntax.AddToBeforeCodes(clsConfidenLimFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsConfidenLimFunction)
        End If
    End Sub

    Private Sub ucrChkDeviance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDeviance.ControlValueChanged
        If ucrChkDeviance.Checked Then
            clsRSyntax.AddToBeforeCodes(clsDevianceFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsDevianceFunction)
        End If
    End Sub

    Private Sub ucrChkEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEstimates.ControlValueChanged
        If ucrChkEstimates.Checked Then
            clsRSyntax.AddToBeforeCodes(clsEstimatesFunction, iPosition:=11)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsEstimatesFunction)
            ucrChkSave.Checked = False
        End If
    End Sub

    Private Sub ucrChkItemPara_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkItemPara.ControlValueChanged
        If ucrChkItemPara.Checked Then
            clsRSyntax.AddToBeforeCodes(clsItemsFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsItemsFunction)
        End If
    End Sub

    Private Sub ucrChkLog_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLog.ControlValueChanged
        If ucrChkLog.Checked Then
            clsCoefFunction.AddParameter("log", "T/F", iPosition:=1)
        Else
            clsCoefFunction.RemoveParameterByName("log")
        End If
    End Sub

    Private Sub ucrChkSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSave.ControlValueChanged
        If ucrChkSave.Checked Then
            clsEstimatesFunction.SetAssignTo("coefficients_data")
            clsRSyntax.AddToBeforeCodes(clsPipeOperator, iPosition:=12)
            clsRSyntax.AddToBeforeCodes(clsImportDataFunction, iPosition:=13)
            clsRSyntax.AddToBeforeCodes(clsDefineAsTricotFunction, iPosition:=14)
        Else
            clsEstimatesFunction.RemoveAssignTo()
            clsRSyntax.RemoveFromBeforeCodes(clsPipeOperator)
            clsRSyntax.RemoveFromBeforeCodes(clsImportDataFunction)
            clsRSyntax.RemoveFromBeforeCodes(clsDefineAsTricotFunction)
        End If
    End Sub


    Private Sub ucrChkModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkModel.ControlValueChanged
        AddRemoveSummary()
    End Sub

    Private Sub AddRemoveSummary()
        If ucrChkModel.Checked Then
            clsRSyntax.AddToBeforeCodes(clsSummaryFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkNodeLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNodeLabel.ControlValueChanged
        If ucrChkNodeLabel.Checked Then
            clsRSyntax.AddToBeforeCodes(clsNodeLabFuction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsNodeLabFuction)
        End If
    End Sub

    Private Sub ucrChkNodeRules_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNodeRules.ControlValueChanged
        If ucrChkNodeRules.Checked Then
            clsRSyntax.AddToBeforeCodes(clsNodeRuleFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsNodeRuleFunction)
        End If
    End Sub

    Private Sub ucrChkParProp_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkParProp.ControlValueChanged
        If ucrChkParProp.Checked Then
            clsRSyntax.AddToBeforeCodes(clsPariPropFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsPariPropFunction)
        End If
    End Sub

    Private Sub ucrChkQuasiVa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkQuasiVa.ControlValueChanged
        If ucrChkQuasiVa.Checked Then
            clsRSyntax.AddToBeforeCodes(clsQuasivarianceFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsQuasivarianceFunction)
        End If
    End Sub

    Private Sub ucrChkReability_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkReability.ControlValueChanged
        If ucrChkReability.Checked Then
            clsRSyntax.AddToBeforeCodes(clsReliabilityFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsReliabilityFunction)
        End If
    End Sub

    Private Sub ucrChkRegret_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRegret.ControlValueChanged
        If ucrChkRegret.Checked Then
            clsRSyntax.AddToBeforeCodes(clsRegretFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsRegretFunction)
        End If
    End Sub

    Private Sub ucrChkSndEstimetes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSndEstimetes.ControlValueChanged
        If ucrChkSndEstimetes.Checked Then
            clsRSyntax.AddToBeforeCodes(clsSecondEstimatesFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsSecondEstimatesFunction)
        End If
    End Sub

    Private Sub ucrChkTopItem_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTopItem.ControlValueChanged
        If ucrChkTopItem.Checked Then
            clsRSyntax.AddToBeforeCodes(clsTopItemFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsTopItemFunction)
        End If
    End Sub

    Private Sub ucrChkVaCoMa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkVaCoMa.ControlValueChanged
        If ucrChkVaCoMa.Checked Then
            clsRSyntax.AddToBeforeCodes(clsVarianCovaMatrixFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsVarianCovaMatrixFunction)
        End If
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPlots.ControlValueChanged
        If rdoBar.Checked Then
            clsRSyntax.AddToBeforeCodes(clsBarfunction)
            clsRSyntax.AddToBeforeCodes(clsWrapBarFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsBarfunction)
            clsRSyntax.RemoveFromBeforeCodes(clsWrapBarFunction)
        End If
        If rdoTree.Checked Then
            clsRSyntax.AddToBeforeCodes(clsTreeFunction)
            clsRSyntax.AddToBeforeCodes(clsWrapTrees)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsTreeFunction)
            clsRSyntax.RemoveFromBeforeCodes(clsWrapTrees)
        End If
        If rdoPlot.Checked Then
            clsRSyntax.AddToBeforeCodes(clsPlotFunction)
            clsRSyntax.AddToBeforeCodes(clsWrapPlotFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsPlotFunction)
            clsRSyntax.RemoveFromBeforeCodes(clsWrapPlotFunction)
        End If
        If rdoMap.Checked Then
            clsRSyntax.AddToBeforeCodes(clsHeatFunction)
        Else
            clsRSyntax.RemoveFromBeforeCodes(clsHeatFunction)
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumPlacketLuceModelMode
            Case PlacketLuceModelMode.nocovariates
                ucrSdgButtons.iHelpTopicID = 722
            Case PlacketLuceModelMode.tree
                ucrSdgButtons.iHelpTopicID = 724
            Case PlacketLuceModelMode.ModelOneVarCov2
                ucrSdgButtons.iHelpTopicID = 726
            Case PlacketLuceModelMode.ModellingGeneral2
                ucrSdgButtons.iHelpTopicID = 728
        End Select
    End Sub

End Class
