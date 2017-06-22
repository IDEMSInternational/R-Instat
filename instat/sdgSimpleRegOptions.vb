' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat
Imports instat.Translations
Public Class sdgSimpleRegOptions
    Public clsRModelFunction As RFunction
    Public clsRDataFrame As ucrDataFrame
    Public clsRGraphicsOperator As ROperator
    Public clsRYVariable, clsRXVariable As String
    Public clsRSummaryFunction, clsRanovaFunction, clsRConfint, clsRLmOrGLM As RFunction
    Public clsRGraphics As New RSyntax
    Private clsRSyntax As RSyntax
    Public clsRaovFunction, clsRaovpvalFunction, clsRestpvalFunction, clsRResidualPlotsFunction, clsRgeom_point, clsRPredFunction, clsRDFFunction, clsRFittedValues, clsRWriteFitted, clsRResiduals, clsRWriteResiduals, clsRStdResiduals, clsRWriteStdResiduals, clsRLeverage, clsRWriteLeverage As New RFunction
    Public clsRggplotFunction, clsRaesFunction, clsRStat_smooth, clsRModelsFunction, clsRCIFunction, clsR_ribbon, clsRaes_ribbon As New RFunction
    Public bControlsInitialised As Boolean = False

    Private Sub sdgSimpleRegOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkModel.SetText("Model")
        ucrChkModel.AddRSyntaxContainsFunctionNamesCondition(True, {"formula"})

        ucrChkANOVA.SetText("ANOVA")
        ucrChkANOVA.AddRSyntaxContainsFunctionNamesCondition(True, {"anova"})

        ucrChkEstimates.SetText("Estimates")
        ucrChkEstimates.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"})

        ucrChkDisplayCLimits.SetText("Confidence Limits")
        ucrChkDisplayCLimits.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"})

        ucrChkPvalues.SetText("P-Values")
        ucrChkPvalues.AddRSyntaxContainsFunctionNamesCondition(True, {"anova"})

        ucrChkPvalues.AddToLinkedControls(ucrNudDisplayCLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        ucrNudDisplayCLevel.SetLinkedDisplayControl(lblDisplayCLevel)

        ' ucrChkFittedValues.SetText("Fitted Values")
        ' ucrChkResiduals.SetText("Residuals")
        ' ucrChkStdResiduals.SetText("Std Residuals")
        'ucrChkLeverage.SetText("Leverage")

        ' ucrChkFittedValues.AddToLinkedControls(ucrFittedColumnName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        ' ucrChkResiduals.AddToLinkedControls(ucrResidualsColumnName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        ' ucrChkStdResiduals.AddToLinkedControls(ucrStdResidualsColumnName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)
        '  ucrChkLeverage.AddToLinkedControls(ucrLeverageColumnName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)

        ucrChkMultiplePlots.SetText("Multiple Plots")
        ucrChkIndividualPlots.SetText("Individual Plots")
        ucrChkFittedModel.SetText("Fitted Model")
        ucrChkPartial.SetText("Partial")
        ucrChkRugs.SetText("Rugs")
        ucrChkJitter.SetText("Jitter")
        ucrChkConfIntervalband.SetText("C.I band")

        ucrSaveFittedColumnName.SetPrefix("Fitted")
        ucrSaveFittedColumnName.SetSaveTypeAsColumn()
        ucrSaveFittedColumnName.SetIsComboBox()
        ucrSaveFittedColumnName.SetCheckBoxText("Fitted Values")
        ucrSaveFittedColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrSaveFittedColumnName.SetAssignToIfUncheckedValue("last_Fitted")

        ucrSaveResidualsColumnName.SetPrefix("Resids")
        ucrSaveResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveResidualsColumnName.SetIsComboBox()
        ucrSaveResidualsColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrSaveResidualsColumnName.SetAssignToIfUncheckedValue("last_Resids")

        ucrSaveStdResidualsColumnName.SetPrefix("Sresids")
        ucrSaveStdResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveStdResidualsColumnName.SetIsComboBox()
        ucrSaveStdResidualsColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrSaveStdResidualsColumnName.SetAssignToIfUncheckedValue("last_Sresids")

        ucrSaveLeverageColumnName.SetPrefix("Lever")
        ucrSaveLeverageColumnName.SetSaveTypeAsColumn()
        ucrSaveLeverageColumnName.SetIsComboBox()
        ucrSaveLeverageColumnName.SetDataFrameSelector(clsRDataFrame)
        ucrSaveLeverageColumnName.SetAssignToIfUncheckedValue("last_Lever")

        'Graphics Model
        ucrChkMultiplePlots.AddToLinkedControls(ucrNudDisplayCLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrNudWhiteSpace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrChkPartial, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrChkRugs, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrChkJitter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrChkConfIntervalband, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)


        ucrPnlMutiplePlots.AddRSyntaxContainsFunctionNamesCondition(rdoFourPlots, {"autoplot"})
        ucrPnlMutiplePlots.AddRSyntaxContainsFunctionNamesCondition(rdoFourPlots, {"autoplot"})
        ucrPnlMutiplePlots.AddRSyntaxContainsFunctionNamesCondition(rdoFourPlots, {"autoplot"})
        bControlsInitialised = True
    End Sub

    ' Optional clsRGraphicsOperator As RFunction = Nothing,
    Public Sub SetRCode(clsNewRSyntax As RSyntax, Optional clsNewRanovaFunction As RFunction = Nothing, Optional clsNewRSummaryFunction As RFunction = Nothing, Optional clsNewRConfint As RFunction = Nothing, Optional clsNewRModelsFunction As RFunction = Nothing, Optional clsNewRaovpvalFunction As RFunction = Nothing, Optional clsNewRgeom_point As RFunction = Nothing, Optional clsNewRResidualPlots As RFunction = Nothing, Optional clsNewRestpvalFunction As RFunction = Nothing, Optional clsNewRLmOrGLM As RFunction = Nothing, Optional clsNewRModelFunction As RFunction = Nothing, Optional clsNewRXVariable As String = Nothing, Optional clsNewRYVariable As String = Nothing, Optional clsNewRWriteFitted As RFunction = Nothing, Optional clsNewRFittedValues As RFunction = Nothing, Optional clsNewRGraphicsOperator As ROperator = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSyntax = clsNewRSyntax
        clsRGraphicsOperator = clsNewRGraphicsOperator
        clsRLmOrGLM = clsNewRLmOrGLM
        clsRestpvalFunction = clsNewRestpvalFunction
        clsRModelFunction = clsNewRModelFunction
        clsRXVariable = clsNewRXVariable
        clsRYVariable = clsNewRYVariable
        clsRWriteFitted = clsNewRWriteFitted
        clsRFittedValues = clsNewRFittedValues
        clsRaovpvalFunction = clsNewRaovpvalFunction
        clsRModelsFunction = clsNewRModelsFunction
        clsRSummaryFunction = clsNewRSummaryFunction
        clsRConfint = clsNewRConfint
        clsRanovaFunction = clsNewRanovaFunction
        clsRgeom_point = clsNewRgeom_point
        clsRResidualPlotsFunction = clsNewRResidualPlots

        ucrChkModel.SetRSyntax(clsRSyntax, bReset)
        ucrChkEstimates.SetRSyntax(clsRSyntax, bReset)
        ucrChkANOVA.SetRSyntax(clsRSyntax, bReset)
        ucrChkDisplayCLimits.SetRSyntax(clsRSyntax, bReset)
        ucrChkPvalues.SetRSyntax(clsRSyntax, bReset)
        ' ucrPnlMutiplePlots.SetRSyntax(clsRSyntax)
    End Sub

    Private Sub ucrChkANOVA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkANOVA.ControlValueChanged
        If ucrChkANOVA.Checked Then
            clsRSyntax.AddToAfterCodes(clsRanovaFunction, iPosition:=0)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRanovaFunction)
        End If
    End Sub

    Private Sub ucrChkEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEstimates.ControlValueChanged
        If ucrChkEstimates.Checked Then
            clsRSyntax.AddToAfterCodes(clsRSummaryFunction, iPosition:=1)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRSummaryFunction)
        End If
    End Sub


    Private Sub ucrChkModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkModel.ControlValueChanged
        If ucrChkModel.Checked Then
            clsRSyntax.AddToAfterCodes(clsRModelsFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRModelsFunction)
        End If
    End Sub

    Private Sub ucrChkDisplayCLimits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayCLimits.ControlValueChanged
        If ucrChkDisplayCLimits.Checked Then
            clsRSyntax.AddToAfterCodes(clsRConfint, iPosition:=4)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRConfint)
        End If
    End Sub

    Private Sub ucrChkPvalues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPvalues.ControlValueChanged
        If ucrChkPvalues.Checked Then
            clsRSyntax.AddToAfterCodes(clsRestpvalFunction, iPosition:=5)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRestpvalFunction)
        End If
    End Sub
    'Public Sub SetRModelFunction(clsRModelFunc As RFunction)
    '    clsRModelFunction = clsRModelFunc
    'End Sub

    Public Sub SetRDataFrame(clsRDataFr As ucrDataFrame)
        clsRDataFrame = clsRDataFr
    End Sub

    'Public Sub SetRYVariable(clsRYVar As ucrReceiverSingle)
    '    clsRYVariable = clsRYVar
    'End Sub
    'Public Sub SetRXVariable(clsRXVar As ucrReceiverSingle)
    '    clsRXVariable = clsRXVar
    'End Sub


    Public Sub ResidualPlots()
        'clsRGraphics.SetOperation("+")
        'clsRResidualPlotsFunction.SetPackageName("ggplot2")
        'clsRResidualPlotsFunction.SetRCommand("autoplot")
        'clsRResidualPlotsFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        'clsRgeom_point.SetRCommand("geom_point")
    End Sub

    Private Sub FittedModel()
        clsRggplotFunction.SetPackageName("visreg")
        clsRggplotFunction.SetRCommand("visreg")
        clsRggplotFunction.AddParameter("fit", clsRFunctionParameter:=clsRModelFunction)
        If rdoConditional.Checked Then
            clsRggplotFunction.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        ElseIf rdoContrast.Checked Then
            clsRggplotFunction.AddParameter("type", Chr(34) & "contrast" & Chr(34))
        End If
        If rdoLinear.Checked Then
            clsRggplotFunction.AddParameter("scale", Chr(34) & "linear" & Chr(34))
        ElseIf rdoResponse.Checked Then
            clsRggplotFunction.AddParameter("scale", Chr(34) & "response" & Chr(34))
        End If
        If ucrChkJitter.Checked Then
            clsRggplotFunction.AddParameter("jitter", "TRUE")
        Else
            clsRggplotFunction.RemoveParameterByName("jitter")
        End If
        clsRggplotFunction.AddParameter("alpha", nudGraphicsCLevel.Value)
        clsRggplotFunction.AddParameter("whitespace", nudWhiteSpace.Value)
        If ucrChkPartial.Checked Then
            clsRggplotFunction.AddParameter("partial", "TRUE")
        Else
            clsRggplotFunction.AddParameter("partial", "FALSE")
        End If
        If ucrChkConfIntervalband.Checked = False Then
            clsRggplotFunction.AddParameter("band", "FALSE")
        Else
            clsRggplotFunction.RemoveParameterByName("band")
        End If
        If ucrChkRugs.Checked Then
            If rdo1.Checked Then
                clsRggplotFunction.AddParameter("rug", 1)
            ElseIf rdo2.Checked Then
                clsRggplotFunction.AddParameter("rug", 2)
            End If
        Else
            clsRggplotFunction.RemoveParameterByName("rug")
        End If
        clsRggplotFunction.AddParameter("gg", "TRUE")
    End Sub

    Private Sub ConfidenceInterval()
        clsRCIFunction.SetRCommand("confint")
        clsRCIFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        DisplayConfidence()
        frmMain.clsRLink.RunScript(clsRCIFunction.ToScript(), 2)
    End Sub

    Private Sub chkPartial_CheckedChanged(sender As Object, e As EventArgs)
        FittedModel()
    End Sub

    Private Sub chkRugs_CheckedChanged(sender As Object, e As EventArgs)
        If ucrChkRugs.Checked Then
            grpRugs.Enabled = True
            rdoPartial.Checked = True
        End If
        FittedModel()
    End Sub

    Private Sub rdoPartial_CheckedChanged(sender As Object, e As EventArgs)
        FittedModel()
    End Sub

    Private Sub rdo1_CheckedChanged(sender As Object, e As EventArgs)
        FittedModel()
    End Sub

    Private Sub rdo2_CheckedChanged(sender As Object, e As EventArgs)
        FittedModel()
    End Sub

    Private Sub rdoConditional_CheckedChanged(sender As Object, e As EventArgs)
        FittedModel()
    End Sub

    Private Sub rdoContrast_CheckedChanged(sender As Object, e As EventArgs)
        FittedModel()
    End Sub

    Private Sub chkMultiplePlots_CheckedChanged(sender As Object, e As EventArgs)
        GraphMultiplePlots()
    End Sub

    Private Sub GraphMultiplePlots()
        If ucrChkMultiplePlots.Checked Then
            ucrChkFittedModel.Checked = False
            ucrChkIndividualPlots.Checked = False
            grpMultiplePlots.Enabled = True
            rdoFourPlots.Checked = True
        Else
            grpMultiplePlots.Enabled = False
        End If
    End Sub

    Private Sub GraphIndividualPlots()
        If ucrChkIndividualPlots.Checked Then
            ucrChkFittedModel.Checked = False
            ucrChkMultiplePlots.Checked = False
            grpIndividualPlots.Enabled = True
            rdoResidualsFitted.Checked = True
        Else
            grpIndividualPlots.Enabled = False
        End If
    End Sub

    Private Sub chkIndividualPlots_CheckedChanged(sender As Object, e As EventArgs)
        GraphIndividualPlots()
    End Sub
    Private Sub ucrPnlMutiplePlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMutiplePlots.ControlValueChanged
        If rdoFourPlots.Checked Then
            clsRResidualPlotsFunction.AddParameter("ncol", 2)
            clsRResidualPlotsFunction.RemoveParameterByName("which")
            clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction)
            clsRGraphicsOperator.AddParameter("geom_point", clsRFunctionParameter:=clsRgeom_point)
            'clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=6)
        ElseIf rdoSixPlots2Rows.Checked Then
            clsRResidualPlotsFunction.AddParameter("ncol", 3)
            clsRResidualPlotsFunction.AddParameter("which", "1:6")
            clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction)
            clsRGraphicsOperator.AddParameter("geom_point", clsRFunctionParameter:=clsRgeom_point)
            'clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=7)
        ElseIf rdoSixPlots3Rows.Checked Then
            clsRResidualPlotsFunction.AddParameter("ncol", 2)
            clsRResidualPlotsFunction.AddParameter("which", "1:6")
            clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction)
            clsRGraphicsOperator.AddParameter("geom_point", clsRFunctionParameter:=clsRgeom_point)
            ' clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=8)
        Else
            ' clsRSyntax.RemoveFromAfterCodes(clsRGraphicsOperator)
        End If
        If (rdoFourPlots.Checked Or rdoSixPlots2Rows.Checked Or rdoSixPlots3Rows.Checked Or rdoResidualsFitted.Checked Or rdoQQ.Checked Or rdoResidualsLeverage.Checked Or rdoScaleLocation.Checked Or rdoCooksDistance.Checked Or rdoCooksDistanceLeverage.Checked) Then
            clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=6)
        End If
    End Sub


    Private Sub rdoQQ_CheckedChanged(sender As Object, e As EventArgs)
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 2)
        ' clsRGraphics.AddParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphicsOperator.AddParameter("geom_point", clsRFunctionParameter:=clsRgeom_point)
    End Sub
    Private Sub rdoResidualsFitted_CheckedChanged(sender As Object, e As EventArgs)
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 1)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoResidualsLeverage_CheckedChanged(sender As Object, e As EventArgs)
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 5)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoCooksDistanceLeverage_CheckedChanged(sender As Object, e As EventArgs)
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 6)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoCooksDistance_CheckedChanged(sender As Object, e As EventArgs)
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 4)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub rdoScaleLocation_CheckedChanged(sender As Object, e As EventArgs)
        clsRResidualPlotsFunction.RemoveParameterByName("ncol")
        clsRResidualPlotsFunction.AddParameter("which", 3)
        clsRGraphics.SetOperatorParameter(True, clsRFunc:=clsRResidualPlotsFunction)
        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
    End Sub

    Private Sub FittedModel_CheckedChanged(sender As Object, e As EventArgs) Handles rdoContrast.CheckedChanged, rdoConditional.CheckedChanged, rdoPartial.CheckedChanged, rdo1.CheckedChanged, rdo2.CheckedChanged
        FittedModel()
    End Sub

    Private Sub CheckRugs_CheckedChanged(sender As Object, e As EventArgs)
        GraphFittedModel()
    End Sub

    Private Sub DisplayTabDefaults()
        'chkANOVA.Checked = True
        'chkModel.Checked = True
        'chkEstimates.Checked = True
        'chkPvalues.Enabled = True
        'chkPvalues.Checked = True
        'chkDisplayCLimits.Checked = False
        'lblDisplayCLevel.Enabled = False
        'nudDisplayCLevel.Enabled = False
    End Sub

    Private Sub SaveTab()
        'ucrFittedColumnName.SetPrefix("Fitted")
        'ucrFittedColumnName.SetItemsTypeAsColumns()
        'ucrFittedColumnName.SetDefaultTypeAsColumn()
        'ucrFittedColumnName.SetDataFrameSelector(clsRDataFrame)
        'ucrFittedColumnName.SetValidationTypeAsRVariable()

        'ucrResidualsColumnName.SetPrefix("Resids")
        'ucrResidualsColumnName.SetItemsTypeAsColumns()
        'ucrResidualsColumnName.SetDefaultTypeAsColumn()
        'ucrResidualsColumnName.SetDataFrameSelector(clsRDataFrame)
        'ucrResidualsColumnName.SetValidationTypeAsRVariable()

        'ucrStdResidualsColumnName.SetPrefix("Sresids")
        'ucrStdResidualsColumnName.SetItemsTypeAsColumns()
        'ucrStdResidualsColumnName.SetDefaultTypeAsColumn()
        'ucrStdResidualsColumnName.SetDataFrameSelector(clsRDataFrame)
        'ucrStdResidualsColumnName.SetValidationTypeAsRVariable()
        'ucrLeverageColumnName.SetPrefix("Lever")
        'ucrLeverageColumnName.SetItemsTypeAsColumns()
        'ucrLeverageColumnName.SetDefaultTypeAsColumn()
        'ucrLeverageColumnName.SetDataFrameSelector(clsRDataFrame)
        'ucrLeverageColumnName.SetValidationTypeAsRVariable()
        'ucrSaveFittedColumnName.Enabled = False
        ' ucrResidualsColumnName.Enabled = False
        'ucrStdResidualsColumnName.Enabled = False
        ' ucrLeverageColumnName.Enabled = False
        'ucrChkFittedValues.Checked = False
        'ucrChkLeverage.Checked = False
        ' ucrChkStdResiduals.Checked = False
        'ucrChkResiduals.Checked = False
    End Sub

    Private Sub GraphsTabDefaults()
        GraphFittedModel()
        GraphMultiplePlots()
        GraphIndividualPlots()
    End Sub

    Public Sub SetDefaults()
        DisplayTabDefaults()
        SaveTab()
        GraphsTabDefaults()
        ucrChkFittedModel.Checked = False
        ucrChkMultiplePlots.Checked = False
        ucrChkIndividualPlots.Checked = False
    End Sub

    Private Sub pvalues()
        If (ucrChkANOVA.Checked Or ucrChkEstimates.Checked) Then
            chkPvalues.Enabled = True
        Else
            chkPvalues.Enabled = False
        End If
    End Sub

    Private Sub chkanovatable_checkedchanged(sender As Object, e As EventArgs)
        pvalues()
    End Sub

    Private Sub chkestimates_checkedchanged(sender As Object, e As EventArgs)
        pvalues()
    End Sub

    Private Sub GraphFittedModel()
        If (ucrChkFittedModel.Checked) Then
            grpPlotType.Enabled = True
            grpScale.Enabled = True
            ucrNudDisplayCLevel.Enabled = True
            nudWhiteSpace.Enabled = True
            ucrChkPartial.Enabled = True
            ucrChkRugs.Enabled = True
            ucrChkJitter.Enabled = True
            ucrChkConfIntervalband.Enabled = True
            ucrChkIndividualPlots.Checked = False
            ucrChkMultiplePlots.Checked = False
        Else
            grpPlotType.Enabled = False
            grpScale.Enabled = False
            ucrNudDisplayCLevel.Enabled = False
            nudWhiteSpace.Enabled = False
            ucrChkPartial.Enabled = False
            ucrChkRugs.Enabled = False
            ucrChkJitter.Enabled = False
            ucrChkConfIntervalband.Enabled = False
        End If
        rdoConditional.Checked = True
        rdoLinear.Checked = True
        ucrNudDisplayCLevel.Value = 0.05
        nudWhiteSpace.Value = 0.2
        rdoPartial.Checked = True
        If ucrChkRugs.Checked = True Then
            grpRugs.Enabled = True
        Else
            grpRugs.Enabled = False
        End If
        If (ucrChkDisplayCLimits.Checked) Then
            lblDisplayCLevel.Enabled = True
            ucrNudDisplayCLevel.Enabled = True
        Else
            lblDisplayCLevel.Enabled = False
            ucrNudDisplayCLevel.Enabled = False
        End If

    End Sub

    Private Sub chkFittedModel_CheckedChanged(sender As Object, e As EventArgs)
        GraphFittedModel()
    End Sub

    Private Sub chkDisplayCLimits_CheckedChanged(sender As Object, e As EventArgs)
        GraphFittedModel()
        DisplayConfidence()
    End Sub

    Private Sub DisplayConfidence()
        If (ucrChkDisplayCLimits.Checked = True) Then
            clsRCIFunction.AddParameter("level", ucrNudDisplayCLevel.Value)
        ElseIf (ucrChkDisplayCLimits.Checked = False) Then
            clsRCIFunction.AddParameter("level", "")
        Else
            clsRCIFunction.RemoveParameterByName("level")
        End If
    End Sub

    Public Sub RegOptions()
        'If (ucrChkANOVA.Checked) Then
        '    If (chkPvalues.Checked) Then
        '        AnovaTablePvalues()
        '    Else
        '        AnovaTable()
        '    End If
        'End If
        'If (ucrChkEstimates.Checked) Then
        '    If (chkPvalues.Checked) Then
        '        EstimatesPvalues()
        '    Else
        '        Estimates()
        '    End If
        'End If
        'If (ucrChkModel.Checked) Then
        '    Model()
        'End If
        If (ucrChkDisplayCLimits.Checked) Then
            ConfidenceInterval()
        End If
        If (rdoFourPlots.Checked Or rdoSixPlots2Rows.Checked Or rdoSixPlots3Rows.Checked Or rdoResidualsFitted.Checked Or rdoQQ.Checked Or rdoResidualsLeverage.Checked Or rdoScaleLocation.Checked Or rdoCooksDistance.Checked Or rdoCooksDistanceLeverage.Checked) Then
            frmMain.clsRLink.RunScript(clsRGraphics.GetScript, 3)
        End If
        If (ucrChkFittedModel.Checked) Then
            frmMain.clsRLink.RunScript(clsRggplotFunction.ToScript(), 3)
        End If
        'If ucrChkFittedValues.Checked Then
        '    FittedValues()
        '    frmMain.clsRLink.RunScript(clsRWriteFitted.ToScript(), 3)
        'End If
        'If ucrChkResiduals.Checked Then
        '    Residuals()
        '    frmMain.clsRLink.RunScript(clsRWriteResiduals.ToScript(), 3)
        'End If
        'If ucrChkStdResiduals.Checked Then
        '    StdResiduals()
        '    frmMain.clsRLink.RunScript(clsRWriteStdResiduals.ToScript(), 3)
        'End If
        'If ucrChkLeverage.Checked Then
        '    Leverage()
        '    frmMain.clsRLink.RunScript(clsRWriteLeverage.ToScript(), 3)
        'End If
    End Sub

    Private Sub ucrFittedColumnName_NameChanged()
        FittedValues()
    End Sub

    Private Sub FittedValues()
        ' clsRFittedValues.SetRCommand("fitted")
        'clsRFittedValues.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        ' clsRWriteFitted.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsRWriteFitted.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteFitted.AddParameter("col_name", Chr(34) & ucrSaveFittedColumnName.GetText & Chr(34))
        'clsRWriteFitted.AddParameter("col_data", clsRFunctionParameter:=clsRFittedValues)
    End Sub

    Private Sub ucrResidualsColumnName_NameChanged()
        Residuals()
    End Sub

    Private Sub Residuals()
        'clsRResiduals.SetRCommand("resid")
        'clsRResiduals.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        'clsRWriteResiduals.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        'clsRWriteResiduals.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        'clsRWriteResiduals.AddParameter("col_name", Chr(34) & ucrResidualsColumnName.GetText & Chr(34))
        'clsRWriteResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRResiduals)
    End Sub

    Private Sub ucrStdResidualsColumnName_NameChanged()
        StdResiduals()
    End Sub

    Private Sub StdResiduals()
        '    clsRStdResiduals.SetRCommand("rstandard")
        '    clsRStdResiduals.AddParameter("model", clsRFunctionParameter:=clsRModelFunction)
        '    clsRWriteStdResiduals.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        '    clsRWriteStdResiduals.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        '    clsRWriteStdResiduals.AddParameter("col_name", Chr(34) & ucrStdResidualsColumnName.GetText & Chr(34))
        '    clsRWriteStdResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRStdResiduals)
    End Sub

    Private Sub ucrLeverageColumnName_NameChanged()
        Leverage()
    End Sub

    Private Sub Leverage()
        'clsRLeverage.SetRCommand("hatvalues")
        'clsRLeverage.AddParameter("model", clsRFunctionParameter:=clsRModelFunction)
        'clsRWriteLeverage.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        'clsRWriteLeverage.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        'clsRWriteLeverage.AddParameter("col_name", Chr(34) & ucrLeverageColumnName.GetText & Chr(34))
        'clsRWriteLeverage.AddParameter("col_data", clsRFunctionParameter:=clsRLeverage)
    End Sub

    Private Sub chkLeverage_CheckedChanged(sender As Object, e As EventArgs)
        'If ucrChkLeverage.Checked Then
        '    ucrLeverageColumnName.Enabled = True
        'Else
        '    ucrLeverageColumnName.Enabled = False
        'End If
    End Sub

    Private Sub chkResiduals_CheckedChanged(sender As Object, e As EventArgs)
        'If ucrChkResiduals.Checked Then
        '    ucrResidualsColumnName.Enabled = True
        'Else
        '    ucrResidualsColumnName.Enabled = False
        'End If
    End Sub

    Private Sub chkStdResiduals_CheckedChanged(sender As Object, e As EventArgs)
        'If ucrChkStdResiduals.Checked Then
        '    ucrStdResidualsColumnName.Enabled = True
        'Else
        '    ucrStdResidualsColumnName.Enabled = False
        'End If
    End Sub

    Private Sub chkFittedValues_CheckedChanged(sender As Object, e As EventArgs)
        'If ucrChkFittedValues.Checked Then
        '    ucrSaveFittedColumnName.Enabled = True
        'Else
        '    ucrSaveFittedColumnName.Enabled = False
        'End If
    End Sub


End Class