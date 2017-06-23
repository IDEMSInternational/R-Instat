﻿' Instat-R
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


        ucrChkMultiplePlots.SetText("Multiple Plots")
        ucrChkIndividualPlots.SetText("Individual Plots")
        ucrChkFittedModel.SetText("Fitted Model")

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
        ucrChkRugs.AddToLinkedControls(ucrPnlPartial12, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrChkJitter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkMultiplePlots.AddToLinkedControls(ucrChkConfIntervalband, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        ucrPnlMutiplePlots.AddRadioButton(rdoFourPlots)
        ucrPnlMutiplePlots.AddRadioButton(rdoSixPlots2Rows)
        ucrPnlMutiplePlots.AddRadioButton(rdoSixPlots3Rows)
        ucrPnlMutiplePlots.AddRSyntaxContainsFunctionNamesCondition(rdoFourPlots, {"autoplot"})
        ucrPnlMutiplePlots.AddRSyntaxContainsFunctionNamesCondition(rdoSixPlots2Rows, {"autoplot"})
        ucrPnlMutiplePlots.AddRSyntaxContainsFunctionNamesCondition(rdoSixPlots3Rows, {"autoplot"})

        ucrPnlPlotType.SetParameter(New RParameter("type"))
        ucrPnlPlotType.AddRadioButton(rdoConditional, Chr(34) & "conditional" & Chr(34))
        ucrPnlPlotType.AddRadioButton(rdoContrast, Chr(34) & "contrast" & Chr(34))

        ucrPnlScale.SetParameter(New RParameter("scale"))
        ucrPnlScale.AddRadioButton(rdoLinear, Chr(34) & "linear" & Chr(34))
        ucrPnlScale.AddRadioButton(rdoResponse, Chr(34) & "response" & Chr(34))

        ucrChkRugs.SetText("Rugs")
        ucrPnlPartial12.SetParameter(New RParameter("rug"))
        ucrPnlPartial12.AddRadioButton(rdo1, "1")
        ucrPnlPartial12.AddRadioButton(rdo2, "2")
        ucrPnlPartial12.AddRadioButton(rdoPartial, "TRUE") 'To obtain partial: to be produced rug=T & partial=T(Default of partial is TRUE)
        ucrPnlPartial12.SetRDefault("TRUE")

        ucrChkJitter.SetText("Jitter")
        ucrChkJitter.SetParameter(New RParameter("jitter"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkJitter.SetRDefault("FALSE")

        ucrNudGraphicsCLevel.SetParameter(New RParameter("alpha"))
        ucrNudWhiteSpace.SetParameter(New RParameter("whitespace"))

        ucrChkPartial.SetText("Partial")
        ucrChkPartial.SetParameter(New RParameter("partial"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPartial.SetRDefault("TRUE")

        ucrChkConfIntervalband.SetText("C.I band")
        ucrChkConfIntervalband.SetParameter(New RParameter("band"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPartial.SetRDefault("TRUE")

        'Save Plots (Save tab)
        'Save Fitted Column Names
        ucrSaveFittedColumnName.SetPrefix("Fitted")
        ucrSaveFittedColumnName.SetSaveTypeAsDataFrame()
        ucrSaveFittedColumnName.SetCheckBoxText("Fitted Values")
        ucrSaveFittedColumnName.SetIsComboBox()
        ucrSaveFittedColumnName.SetAssignToIfUncheckedValue("last_fitted")
        ucrSaveFittedColumnName.Enabled = False ' disabled until working

        'Save Residuals Column Names
        ucrSaveResidualsColumnName.SetPrefix("Resids")
        ucrSaveResidualsColumnName.SetSaveTypeAsDataFrame()
        ucrSaveResidualsColumnName.SetCheckBoxText("Residuals")
        ucrSaveResidualsColumnName.SetIsComboBox()
        ucrSaveResidualsColumnName.SetAssignToIfUncheckedValue("last_residual")
        ucrSaveResidualsColumnName.Enabled = False ' disabled until working

        'Save StdResiduals Column Names
        ucrSaveStdResidualsColumnName.SetPrefix("Sresids")
        ucrSaveStdResidualsColumnName.SetSaveTypeAsDataFrame()
        ucrSaveStdResidualsColumnName.SetCheckBoxText("Std Residuals")
        ucrSaveStdResidualsColumnName.SetIsComboBox()
        ucrSaveStdResidualsColumnName.SetAssignToIfUncheckedValue("last_stdresidual")
        ucrSaveStdResidualsColumnName.Enabled = False ' disabled until working

        'Save Leverage Column Names
        ucrSaveLeverageColumnName.SetPrefix("Lever")
        ucrSaveLeverageColumnName.SetSaveTypeAsDataFrame()
        ucrSaveLeverageColumnName.SetCheckBoxText("Leverage")
        ucrSaveLeverageColumnName.SetIsComboBox()
        ucrSaveLeverageColumnName.SetAssignToIfUncheckedValue("last_leverage")
        ucrSaveLeverageColumnName.Enabled = False ' disabled until working

        bControlsInitialised = True
    End Sub

    'Optional clsNewRWriteLeverage As RFunction = Nothing,
    'Optional clsRWriteResiduals As RFunction = Nothing,
    Public Sub SetRCode(clsNewRSyntax As RSyntax, Optional clsNewRanovaFunction As RFunction = Nothing, Optional clsNewRSummaryFunction As RFunction = Nothing, Optional clsNewRConfint As RFunction = Nothing, Optional clsNewRggplotFunction As RFunction = Nothing, Optional clsNewRModelsFunction As RFunction = Nothing, Optional clsNewRaovpvalFunction As RFunction = Nothing, Optional clsNewRgeom_point As RFunction = Nothing, Optional clsNewRWriteResiduals As RFunction = Nothing, Optional clsNewRResidualPlots As RFunction = Nothing, Optional clsNewRestpvalFunction As RFunction = Nothing, Optional clsNewRWriteLeverage As RFunction = Nothing, Optional clsNewRWriteStdResiduals As RFunction = Nothing, Optional clsNewRLmOrGLM As RFunction = Nothing, Optional clsNewRModelFunction As RFunction = Nothing, Optional clsNewRXVariable As String = Nothing, Optional clsNewRYVariable As String = Nothing, Optional clsNewRWriteFitted As RFunction = Nothing, Optional clsNewRFittedValues As RFunction = Nothing, Optional clsNewRGraphicsOperator As ROperator = Nothing, Optional bReset As Boolean = False)
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
        clsRggplotFunction = clsNewRggplotFunction
        clsRWriteResiduals = clsNewRWriteResiduals
        clsRWriteStdResiduals = clsNewRWriteStdResiduals
        clsRWriteLeverage = clsNewRWriteLeverage

        ucrChkModel.SetRSyntax(clsRSyntax, bReset)
        ucrChkEstimates.SetRSyntax(clsRSyntax, bReset)
        ucrChkANOVA.SetRSyntax(clsRSyntax, bReset)
        ucrChkDisplayCLimits.SetRSyntax(clsRSyntax, bReset)
        ucrChkPvalues.SetRSyntax(clsRSyntax, bReset)
        ucrPnlScale.SetRCode(clsRggplotFunction, bReset)
        ucrPnlPlotType.SetRCode(clsRggplotFunction, bReset)
        ucrChkJitter.SetRCode(clsRggplotFunction, bReset)
        ucrNudGraphicsCLevel.SetRCode(clsRggplotFunction, bReset)
        ucrNudWhiteSpace.SetRCode(clsRggplotFunction, bReset)
        ucrChkPartial.SetRCode(clsRggplotFunction, bReset)
        ucrPnlPartial12.SetRCode(clsRggplotFunction, bReset)
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

    Private Sub ucrChkFittedModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFittedModel.ControlValueChanged
        If ucrChkFittedModel.Checked Then
            clsRggplotFunction.AddParameter("gg", "TRUE")
            clsRSyntax.AddToAfterCodes(clsRggplotFunction, iPosition:=6)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRggplotFunction)
        End If
    End Sub

    Public Sub SetRDataFrame(clsRDataFr As ucrDataFrame)
        clsRDataFrame = clsRDataFr
    End Sub


    Public Sub ResidualPlots()
        'clsRGraphics.SetOperation("+")
        'clsRResidualPlotsFunction.SetPackageName("ggplot2")
        'clsRResidualPlotsFunction.SetRCommand("autoplot")
        'clsRResidualPlotsFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        'clsRgeom_point.SetRCommand("geom_point")
    End Sub

    Private Sub ConfidenceInterval()
        clsRCIFunction.SetRCommand("confint")
        clsRCIFunction.AddParameter("object", clsRFunctionParameter:=clsRModelFunction)
        DisplayConfidence()
        frmMain.clsRLink.RunScript(clsRCIFunction.ToScript(), 2)
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
    Private Sub ucrPnlMutiplePlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMutiplePlots.ControlValueChanged, ucrPnlIndividualPlots.ControlValueChanged
        'Multiple Plots
        If ucrChkMultiplePlots.Checked Then
            If rdoFourPlots.Checked Then
                clsRResidualPlotsFunction.AddParameter("ncol", 2)
                clsRResidualPlotsFunction.RemoveParameterByName("which")
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            ElseIf rdoSixPlots2Rows.Checked Then
                clsRResidualPlotsFunction.AddParameter("ncol", 3)
                clsRResidualPlotsFunction.AddParameter("which", "1:6")
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            ElseIf rdoSixPlots3Rows.Checked Then
                clsRResidualPlotsFunction.AddParameter("ncol", 2)
                clsRResidualPlotsFunction.AddParameter("which", "1:6")
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            End If
            If (rdoFourPlots.Checked OrElse rdoSixPlots2Rows.Checked OrElse rdoSixPlots3Rows.Checked) Then
                clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=6)
            End If
        End If
        'Individual Plots
        If ucrChkIndividualPlots.Checked Then
            If rdoQQ.Checked Then
                clsRResidualPlotsFunction.RemoveParameterByName("ncol")
                clsRResidualPlotsFunction.AddParameter("which", 2)
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            ElseIf rdoResidualsFitted.Checked Then
                clsRResidualPlotsFunction.RemoveParameterByName("ncol")
                clsRResidualPlotsFunction.AddParameter("which", 1)
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
                clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
            ElseIf rdoResidualsLeverage.Checked Then
                clsRResidualPlotsFunction.RemoveParameterByName("ncol")
                clsRResidualPlotsFunction.AddParameter("which", 5)
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            ElseIf rdoCooksDistanceLeverage.Checked Then
                clsRResidualPlotsFunction.RemoveParameterByName("ncol")
                clsRResidualPlotsFunction.AddParameter("which", 6)
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            ElseIf rdoCooksDistance.Checked Then
                clsRResidualPlotsFunction.RemoveParameterByName("ncol")
                clsRResidualPlotsFunction.AddParameter("which", 4)
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            ElseIf rdoScaleLocation.Checked Then
                clsRResidualPlotsFunction.RemoveParameterByName("ncol")
                clsRResidualPlotsFunction.AddParameter("which", 3)
                clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsRResidualPlotsFunction, iPosition:=0)
            End If
            If (rdoResidualsFitted.Checked OrElse rdoQQ.Checked OrElse rdoResidualsLeverage.Checked OrElse rdoScaleLocation.Checked OrElse rdoCooksDistance.Checked OrElse rdoCooksDistanceLeverage.Checked) Then
                clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=7)
            End If
        End If
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
        If (ucrChkDisplayCLimits.Checked) Then
            ConfidenceInterval()
        End If
        If (rdoFourPlots.Checked Or rdoSixPlots2Rows.Checked Or rdoSixPlots3Rows.Checked Or rdoResidualsFitted.Checked Or rdoQQ.Checked Or rdoResidualsLeverage.Checked Or rdoScaleLocation.Checked Or rdoCooksDistance.Checked Or rdoCooksDistanceLeverage.Checked) Then
            frmMain.clsRLink.RunScript(clsRGraphics.GetScript, 3)
        End If
    End Sub

    ' disabled until working

    Private Sub FittedValues()
        clsRWriteFitted.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteFitted.AddParameter("col_name", Chr(34) & ucrSaveFittedColumnName.GetText & Chr(34))
    End Sub

    Private Sub Residuals()
        clsRWriteResiduals.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteResiduals.AddParameter("col_name", Chr(34) & ucrSaveResidualsColumnName.GetText & Chr(34))
    End Sub

    Private Sub StdResiduals()
        clsRWriteStdResiduals.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteStdResiduals.AddParameter("col_name", Chr(34) & ucrSaveStdResidualsColumnName.GetText & Chr(34))
    End Sub

    Private Sub Leverage()
        clsRWriteLeverage.AddParameter("data_name", Chr(34) & clsRDataFrame.cboAvailableDataFrames.Text & Chr(34))
        clsRWriteLeverage.AddParameter("col_name", Chr(34) & ucrSaveLeverageColumnName.GetText & Chr(34))
    End Sub

End Class