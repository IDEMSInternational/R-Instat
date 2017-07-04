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

Imports instat
Imports instat.Translations

Public Class sdgSimpleRegOptions
    Public clsRModelFunction As RFunction
    Public clsRDataFrame As ucrDataFrame
    Public clsRYVariable, clsRXVariable As String
    Public clsRLmOrGLM As RFunction
    Public clsRGraphics As New RSyntax
    Private clsRSyntax As RSyntax
    Public clsRaovFunction, clsRaovpvalFunction, clsRestpvalFunction, clsAutoplot, clsRgeom_point, clsRPredFunction, clsRDFFunction, clsRFittedValues, clsRWriteFitted, clsRResiduals, clsRWriteResiduals, clsRStdResiduals, clsRWriteStdResiduals, clsRLeverage, clsRWriteLeverage As New RFunction
    Public clsVisReg, clsRaesFunction, clsRStat_smooth, clsR_ribbon, clsRaes_ribbon As New RFunction
    Public clsWhichFunction As RFunction
    Public bRCodeSet As Boolean = True

    'Display tab functions
    Public clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As RFunction

    Public bControlsInitialised As Boolean = False

    Private Sub sdgSimpleRegOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        'Display tab controls
        '###########################################
        ucrChkModel.SetText("Model")
        ucrChkModel.AddRSyntaxContainsFunctionNamesCondition(True, {"formula"}, True)
        ucrChkModel.AddRSyntaxContainsFunctionNamesCondition(False, {"formula"}, False)

        ucrChkANOVA.SetText("ANOVA")
        ucrChkANOVA.AddRSyntaxContainsFunctionNamesCondition(True, {"anova"}, True)
        ucrChkANOVA.AddRSyntaxContainsFunctionNamesCondition(False, {"anova"}, False)
        ucrChkANOVA.AddToLinkedControls(ucrChkPvalues, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'To display p values with anova table
        'temp disabled until implemented
        ucrChkPvalues.SetText("Include P-Values")
        ucrChkPvalues.Enabled = False
        ucrChkPvalues.Checked = True

        ucrChkEstimates.SetText("Estimates")
        ucrChkEstimates.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"}, True)
        ucrChkEstimates.AddRSyntaxContainsFunctionNamesCondition(False, {"summary"}, False)

        ucrChkConfLimits.SetText("Confidence Limits")
        ucrChkConfLimits.AddRSyntaxContainsFunctionNamesCondition(True, {"confint"}, True)
        ucrChkConfLimits.AddRSyntaxContainsFunctionNamesCondition(False, {"confint"}, False)
        ucrChkConfLimits.AddToLinkedControls(ucrNudConfLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.95)

        ucrNudConfLevel.SetParameter(New RParameter("level"))
        ucrNudConfLevel.DecimalPlaces = 2
        ucrNudConfLevel.Increment = 0.01
        ucrNudConfLevel.SetMinMax(0, 1)
        ucrNudConfLevel.SetLinkedDisplayControl(lblConfLevel)
        ucrNudConfLevel.SetRDefault(0.95)

        'Graphics tab control
        '###########################################

        'Fitting Models Plots (Visreg)
        ucrChkFittedModel.SetText("Fitted Model")
        ucrChkFittedModel.AddRSyntaxContainsFunctionNamesCondition(True, {"visreg"}, True)
        ucrChkFittedModel.AddRSyntaxContainsFunctionNamesCondition(False, {"visreg"}, False)
        ucrChkFittedModel.AddToLinkedControls(ucrNudWhiteSpace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkPartial, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkRugs, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkJitter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkConfIntervalband, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrPnlPlotType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrPnlScale, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        'Multiple plots
        ucrChkResidualPlots.SetText("Residual Plots")
        ucrChkResidualPlots.AddRSyntaxContainsFunctionNamesCondition(True, {"autoplot"}, True)
        ucrChkResidualPlots.AddRSyntaxContainsFunctionNamesCondition(False, {"autoplot"}, False)
        ucrChkResidualPlots.AddToLinkedControls(ucrPnlMutiplePlots, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlMutiplePlots.AddRadioButton(rdoSixPlots)
        ucrPnlMutiplePlots.AddRadioButton(rdoFourPlots)
        ucrPnlMutiplePlots.AddRadioButton(rdoChooseIndividual)
        'Can't set conditions for specify button so need this
        ucrPnlMutiplePlots.bAllowNonConditionValues = True
        ucrPnlMutiplePlots.bSetToFirstIfNoValue = False

        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "1")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "2")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "3")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "4", False)
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "5")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "6", False)

        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoSixPlots, "1")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoSixPlots, "2")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoSixPlots, "3")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoSixPlots, "4")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoSixPlots, "5")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoSixPlots, "6")

        ucrPnlMutiplePlots.AddToLinkedControls(ucrChkResidualsFitted, {rdoChooseIndividual}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMutiplePlots.AddToLinkedControls(ucrChkQQ, {rdoChooseIndividual}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMutiplePlots.AddToLinkedControls(ucrChkScaleLocation, {rdoChooseIndividual}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMutiplePlots.AddToLinkedControls(ucrChkCooksDistance, {rdoChooseIndividual}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMutiplePlots.AddToLinkedControls(ucrChkResidualsLeverage, {rdoChooseIndividual}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMutiplePlots.AddToLinkedControls(ucrChkCooksDistanceLeverage, {rdoChooseIndividual}, bNewLinkedHideIfParameterMissing:=True)

        'Currently not working correctly
        'ucrPnlMutiplePlots.SetLinkedDisplayControl(grpMultiplePlots)

        'Unclear how to set conditions for this option
        'ucrPnlMutiplePlots.AddParameterValuesCondition(rdoSpecifyIndividual, )

        'Individual Plots (Autoplot function)
        ucrChkResidualsFitted.SetText("Residuals v Fitted Values")
        ucrChkQQ.SetText("Q-Q")
        ucrChkScaleLocation.SetText("Scale-Location")
        ucrChkCooksDistance.SetText("Cook's Distance")
        ucrChkResidualsLeverage.SetText("Residuals v Leverage")
        ucrChkCooksDistanceLeverage.SetText("Cook's Distance v Leverage")

        ucrChkResidualsFitted.AddParameterPresentCondition(True, "1")
        ucrChkResidualsFitted.AddParameterPresentCondition(False, "1", False)
        ucrChkQQ.AddParameterPresentCondition(True, "2")
        ucrChkQQ.AddParameterPresentCondition(False, "2", False)
        ucrChkScaleLocation.AddParameterPresentCondition(True, "3")
        ucrChkScaleLocation.AddParameterPresentCondition(False, "3", False)
        ucrChkCooksDistance.AddParameterPresentCondition(True, "4")
        ucrChkCooksDistance.AddParameterPresentCondition(False, "4", False)
        ucrChkResidualsLeverage.AddParameterPresentCondition(True, "5")
        ucrChkResidualsLeverage.AddParameterPresentCondition(False, "5", False)
        ucrChkCooksDistanceLeverage.AddParameterPresentCondition(True, "6")
        ucrChkCooksDistanceLeverage.AddParameterPresentCondition(False, "6", False)

        'Currently not working correctly
        'ucrChkResidualsFitted.SetLinkedDisplayControl(grpIndividualPlots)

        ''type
        ucrPnlPlotType.SetParameter(New RParameter("type"))
        ucrPnlPlotType.AddRadioButton(rdoConditional, Chr(34) & "conditional" & Chr(34))
        ucrPnlPlotType.AddRadioButton(rdoContrast, Chr(34) & "contrast" & Chr(34))
        ucrPnlPlotType.SetRDefault(Chr(34) & "conditional" & Chr(34))

        ''scale
        ucrPnlScale.SetParameter(New RParameter("scale"))
        ucrPnlScale.AddRadioButton(rdoLinear, Chr(34) & "linear" & Chr(34))
        ucrPnlScale.AddRadioButton(rdoResponse, Chr(34) & "response" & Chr(34))
        ucrPnlScale.SetRDefault(Chr(34) & "linear" & Chr(34))

        ucrChkRugs.SetText("Rugs")
        ucrPnlPartial12.SetParameter(New RParameter("rug"))
        ucrPnlPartial12.AddRadioButton(rdo1, "1")
        ucrPnlPartial12.AddRadioButton(rdo2, "2")
        ucrPnlPartial12.AddRadioButton(rdoPartial, "!partial") 'To obtain partial: to be produced rug=T & partial=T(Default of partial is TRUE)
        ucrPnlPartial12.SetRDefault("!partial")

        ucrNudWhiteSpace.SetParameter(New RParameter("whitespace"))
        ucrNudWhiteSpace.DecimalPlaces = 1
        ucrNudWhiteSpace.Increment = 0.1
        ucrNudWhiteSpace.SetMinMax(0, 1)
        ucrNudWhiteSpace.SetRDefault(0.2)

        ucrChkRugs.AddToLinkedControls(ucrPnlPartial12, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoPartial)

        ucrChkJitter.SetText("Jitter")
        ucrChkJitter.SetParameter(New RParameter("jitter"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkJitter.SetRDefault("FALSE")

        ucrNudGraphicsCLevel.SetParameter(New RParameter("alpha"))
        ucrNudGraphicsCLevel.DecimalPlaces = 2
        ucrNudGraphicsCLevel.Increment = 0.01
        ucrNudGraphicsCLevel.SetMinMax(0, 1)

        ucrChkPartial.SetText("Partial")
        ucrChkPartial.SetParameter(New RParameter("partial"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPartial.SetRDefault("TRUE")

        ucrChkConfIntervalband.SetText("C.I band")
        ucrChkConfIntervalband.SetParameter(New RParameter("band"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkConfIntervalband.SetRDefault("TRUE")

        'Save Plots (Save tab)
        'Save Fitted Column Names
        'ucrSaveFittedColumnName.SetPrefix("Fitted")
        'ucrSaveFittedColumnName.SetSaveTypeAsColumn()
        ucrSaveFittedColumnName.SetCheckBoxText("Fitted Values")
        'ucrSaveFittedColumnName.SetIsComboBox()
        'ucrSaveFittedColumnName.SetDataFrameSelector(clsRDataFrame)


        '' save residuals column names
        'ucrSaveResidualsColumnName.SetPrefix("Resids")
        'ucrSaveResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveResidualsColumnName.SetCheckBoxText("residuals")
        'ucrSaveResidualsColumnName.SetIsComboBox()
        'ucrSaveResidualsColumnName.SetDataFrameSelector(clsRDataFrame)

        '' save stdresiduals column names
        'ucrSaveStdResidualsColumnName.SetPrefix("Sresids")
        'ucrSaveStdResidualsColumnName.SetSaveTypeAsColumn()
        'ucrSaveStdResidualsColumnName.SetIsComboBox()
        ucrSaveStdResidualsColumnName.SetCheckBoxText("std residuals")
        'ucrSaveStdResidualsColumnName.SetDataFrameSelector(clsRDataFrame)

        ''save leverage column names
        'ucrSaveLeverageColumnName.SetPrefix("Lever")
        'ucrSaveLeverageColumnName.SetSaveTypeAsColumn()
        'ucrSaveLeverageColumnName.SetIsComboBox()
        ucrSaveLeverageColumnName.SetCheckBoxText("leverage")
        'ucrSaveLeverageColumnName.SetDataFrameSelector(clsRDataFrame)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, Optional clsNewFormulaFunction As RFunction = Nothing, Optional clsNewAnovaFunction As RFunction = Nothing, Optional clsNewRSummaryFunction As RFunction = Nothing, Optional clsNewConfint As RFunction = Nothing, Optional clsNewVisReg As RFunction = Nothing, Optional clsNewRaovpvalFunction As RFunction = Nothing, Optional clsNewRgeom_point As RFunction = Nothing, Optional clsNewRWriteResiduals As RFunction = Nothing, Optional clsNewAutoplot As RFunction = Nothing, Optional clsNewRestpvalFunction As RFunction = Nothing, Optional clsNewRWriteLeverage As RFunction = Nothing, Optional clsNewRWriteStdResiduals As RFunction = Nothing, Optional clsNewRLmOrGLM As RFunction = Nothing, Optional clsNewRModelFunction As RFunction = Nothing, Optional clsNewRXVariable As String = Nothing, Optional clsNewRYVariable As String = Nothing, Optional clsNewRWriteFitted As RFunction = Nothing, Optional clsNewRFittedValues As RFunction = Nothing, Optional bReset As Boolean = False)
        bRCodeSet = False
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSyntax = clsNewRSyntax

        'Display functions
        clsAnovaFunction = clsNewAnovaFunction
        clsFormulaFunction = clsNewFormulaFunction
        clsSummaryFunction = clsNewRSummaryFunction
        clsConfint = clsNewConfint

        'Graph functions
        clsVisReg = clsNewVisReg

        clsRLmOrGLM = clsNewRLmOrGLM
        clsRestpvalFunction = clsNewRestpvalFunction
        clsRModelFunction = clsNewRModelFunction
        clsRXVariable = clsNewRXVariable
        clsRYVariable = clsNewRYVariable
        clsRWriteFitted = clsNewRWriteFitted
        clsRFittedValues = clsNewRFittedValues
        clsRaovpvalFunction = clsNewRaovpvalFunction
        clsRgeom_point = clsNewRgeom_point
        clsAutoplot = clsNewAutoplot
        clsRWriteResiduals = clsNewRWriteResiduals
        clsRWriteStdResiduals = clsNewRWriteStdResiduals
        clsRWriteLeverage = clsNewRWriteLeverage

        If clsAutoplot.ContainsParameter("which") Then
            clsWhichFunction = clsAutoplot.GetParameter("which").clsArgumentCodeStructure
        Else
            clsWhichFunction.Clear()
            clsWhichFunction.SetRCommand("c")
            clsWhichFunction.AddParameter("1", "1", iPosition:=0, bIncludeArgumentName:=False)
            clsWhichFunction.AddParameter("2", "2", iPosition:=1, bIncludeArgumentName:=False)
            clsWhichFunction.AddParameter("3", "3", iPosition:=2, bIncludeArgumentName:=False)
            clsWhichFunction.AddParameter("5", "5", iPosition:=4, bIncludeArgumentName:=False)
            clsAutoplot.AddParameter("which", clsRFunctionParameter:=clsWhichFunction)
        End If

        'Display tab controls
        ucrChkModel.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        ucrChkANOVA.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        ucrChkEstimates.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        ucrChkConfLimits.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        ucrNudConfLevel.SetRCode(clsConfint, bReset)
        ucrChkFittedModel.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)

        ucrPnlScale.SetRCode(clsVisReg, bReset)
        ucrPnlPlotType.SetRCode(clsVisReg, bReset)
        ucrChkJitter.SetRCode(clsVisReg, bReset)
        ucrNudGraphicsCLevel.SetRCode(clsVisReg, bReset)
        ucrNudWhiteSpace.SetRCode(clsVisReg, bReset)
        ucrChkPartial.SetRCode(clsVisReg, bReset)
        ucrChkConfIntervalband.SetRCode(clsVisReg, bReset)
        ucrPnlPartial12.SetRCode(clsVisReg, bReset)

        '    ## Residual tab
        ucrChkResidualPlots.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        rdoFourPlots.Checked = False
        rdoSixPlots.Checked = False
        ucrPnlMutiplePlots.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        If Not rdoFourPlots.Checked AndAlso Not rdoSixPlots.Checked Then
            rdoChooseIndividual.Checked = True
        End If

        IndividualPlotsSetRCode(bReset)

        'Saving options
        ucrSaveFittedColumnName.SetRCode(clsRWriteFitted, bReset)
        ucrSaveResidualsColumnName.SetRCode(clsRWriteResiduals, bReset)
        ucrSaveStdResidualsColumnName.SetRCode(clsRWriteStdResiduals, bReset)
        ucrSaveLeverageColumnName.SetRSyntax(clsRSyntax, bReset, bCloneIfNeeded:=True)
        bRCodeSet = True
    End Sub

    Private Sub IndividualPlotsSetRCode(Optional bReset As Boolean = False)
        bRCodeSet = False
        ucrChkResidualsFitted.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        ucrChkQQ.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        ucrChkScaleLocation.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCooksDistance.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        ucrChkResidualsLeverage.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        ucrChkCooksDistanceLeverage.SetRCode(clsWhichFunction, bReset, bCloneIfNeeded:=True)
        bRCodeSet = True
    End Sub

    Private Sub ucrChkModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkModel.ControlValueChanged
        If ucrChkModel.Checked Then
            clsRSyntax.AddToAfterCodes(clsFormulaFunction, iPosition:=0)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsFormulaFunction)
        End If
    End Sub

    Private Sub ucrChkANOVA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkANOVA.ControlValueChanged
        If ucrChkANOVA.Checked Then
            clsRSyntax.AddToAfterCodes(clsAnovaFunction, iPosition:=1)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsAnovaFunction)
        End If
    End Sub

    Private Sub ucrChkEstimates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEstimates.ControlValueChanged
        If ucrChkEstimates.Checked Then
            clsRSyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkDisplayCLimits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConfLimits.ControlValueChanged
        If ucrChkConfLimits.Checked Then
            clsRSyntax.AddToAfterCodes(clsConfint, iPosition:=3)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsConfint)
        End If
    End Sub

    Private Sub ucrChkFittedModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFittedModel.ControlValueChanged
        If ucrChkFittedModel.Checked Then
            clsRSyntax.AddToAfterCodes(clsVisReg, iPosition:=4)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsVisReg)
        End If
    End Sub

    Private Sub ucrChkResidualPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkResidualPlots.ControlValueChanged
        If ucrChkResidualPlots.Checked Then
            clsRSyntax.AddToAfterCodes(clsAutoplot, iPosition:=5)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsAutoplot)
        End If
    End Sub

    Private Sub ucrPnlMutiplePlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMutiplePlots.ControlValueChanged
        If bRCodeSet Then
            If rdoChooseIndividual.Checked Then
                IndividualPlotsSetRCode(False)
            End If
            SetWhichParameter()
        End If
    End Sub

    Public Sub SetRDataFrame(clsRDataFr As ucrDataFrame)
        clsRDataFrame = clsRDataFr
    End Sub

    Private Sub ucrchkRugs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRugs.ControlValueChanged
        If ucrChkRugs.Checked Then
            rdoPartial.Checked = True
        End If
    End Sub

    Private Sub SetWhichParameter()
        If bRCodeSet Then
            If ucrChkResidualPlots.Checked Then
                clsWhichFunction.ClearParameters()
                If rdoFourPlots.Checked OrElse rdoSixPlots.Checked Then
                    clsWhichFunction.ClearParameters()
                    clsWhichFunction.AddParameter("1", "1", iPosition:=0, bIncludeArgumentName:=False)
                    clsWhichFunction.AddParameter("2", "2", iPosition:=1, bIncludeArgumentName:=False)
                    clsWhichFunction.AddParameter("3", "3", iPosition:=2, bIncludeArgumentName:=False)
                    clsWhichFunction.AddParameter("5", "5", iPosition:=4, bIncludeArgumentName:=False)
                    If rdoSixPlots.Checked Then
                        clsWhichFunction.AddParameter("4", "4", iPosition:=3, bIncludeArgumentName:=False)
                        clsWhichFunction.AddParameter("6", "6", iPosition:=5, bIncludeArgumentName:=False)
                    End If
                ElseIf rdoChooseIndividual.Checked Then
                    If ucrChkResidualsFitted.Checked Then
                        clsWhichFunction.AddParameter("1", "1", iPosition:=0, bIncludeArgumentName:=False)
                    End If
                    If ucrChkQQ.Checked Then
                        clsWhichFunction.AddParameter("2", "2", iPosition:=1, bIncludeArgumentName:=False)
                    End If
                    If ucrChkScaleLocation.Checked Then
                        clsWhichFunction.AddParameter("3", "3", iPosition:=2, bIncludeArgumentName:=False)
                    End If
                    If ucrChkCooksDistance.Checked Then
                        clsWhichFunction.AddParameter("4", "4", iPosition:=3, bIncludeArgumentName:=False)
                    End If
                    If ucrChkResidualsLeverage.Checked Then
                        clsWhichFunction.AddParameter("5", "5", iPosition:=4, bIncludeArgumentName:=False)
                    End If
                    If ucrChkCooksDistanceLeverage.Checked Then
                        clsWhichFunction.AddParameter("6", "6", iPosition:=5, bIncludeArgumentName:=False)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ucrChkResidualsFitted_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkResidualsFitted.ControlValueChanged, ucrChkQQ.ControlValueChanged, ucrChkScaleLocation.ControlValueChanged, ucrChkCooksDistance.ControlValueChanged, ucrChkResidualsLeverage.ControlValueChanged, ucrChkCooksDistanceLeverage.ControlValueChanged
        SetWhichParameter()
    End Sub
End Class