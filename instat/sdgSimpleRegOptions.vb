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
    Public clsRLmOrGLM As RFunction
    Public clsRGraphics As New RSyntax
    Private clsRSyntax As RSyntax
    Public clsRaovFunction, clsRaovpvalFunction, clsRestpvalFunction, clsAutoplot, clsRgeom_point, clsRPredFunction, clsRDFFunction, clsRFittedValues, clsRWriteFitted, clsRResiduals, clsRWriteResiduals, clsRStdResiduals, clsRWriteStdResiduals, clsRLeverage, clsRWriteLeverage As New RFunction
    Public clsVisReg, clsRaesFunction, clsRStat_smooth, clsR_ribbon, clsRaes_ribbon As New RFunction

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
        ucrChkMultiplePlots.SetText("Multiple Plots")
        ucrChkMultiplePlots.AddRSyntaxContainsFunctionNamesCondition(True, {"autoplot"}, True)
        ucrChkMultiplePlots.AddRSyntaxContainsFunctionNamesCondition(False, {"autoplot"}, False)
        ucrChkMultiplePlots.AddToLinkedControls(ucrPnlMutiplePlots, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoFourPlots)

        ucrPnlMutiplePlots.AddRadioButton(rdoFourPlots)
        ucrPnlMutiplePlots.AddRadioButton(rdoSixPlots2Rows)
        ucrPnlMutiplePlots.AddRadioButton(rdoSixPlots3Rows)

        ucrPnlMutiplePlots.AddParameterValuesCondition(rdoFourPlots, "ncol", "2")
        ucrPnlMutiplePlots.AddParameterPresentCondition(rdoFourPlots, "which", False)

        ucrPnlMutiplePlots.AddParameterValuesCondition(rdoSixPlots2Rows, "ncol", "3")
        ucrPnlMutiplePlots.AddParameterValuesCondition(rdoSixPlots2Rows, "which", "1:6")

        ucrPnlMutiplePlots.AddParameterValuesCondition(rdoSixPlots3Rows, "ncol", "2")
        ucrPnlMutiplePlots.AddParameterValuesCondition(rdoSixPlots3Rows, "which", "1:6")

        'Individual Plots (Autoplot function)
        ucrPnlIndividualPlots.AddRadioButton(rdoResidualsFitted)
        ucrPnlIndividualPlots.AddRadioButton(rdoQQ)
        ucrPnlIndividualPlots.AddRadioButton(rdoResidualsLeverage)
        ucrPnlIndividualPlots.AddRadioButton(rdoScaleLocation)
        ucrPnlIndividualPlots.AddRadioButton(rdoCooksDistanceLeverage)
        ucrPnlIndividualPlots.AddRadioButton(rdoCooksDistance)

        ucrChkIndividualPlots.Enabled = False
        ucrChkIndividualPlots.AddFunctionNamesCondition(False, "autoplot", False)
        'ucrChkIndividualPlots.AddFunctionNamesCondition(True, "autoplot")
        ucrChkIndividualPlots.SetText("Individual Plots")
        ucrChkIndividualPlots.AddToLinkedControls(ucrPnlIndividualPlots, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoResidualsFitted)
        'ucrPnlIndividualPlots.SetLinkedDisplayControl(grpIndividualPlots)

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

        ''Save Plots (Save tab)
        ''Save Fitted Column Names
        ucrSaveFittedColumnName.SetPrefix("Fitted")
        ucrSaveFittedColumnName.SetSaveTypeAsColumn()
        ucrSaveFittedColumnName.SetCheckBoxText("Fitted Values")
        ucrSaveFittedColumnName.SetIsComboBox()
        ucrSaveFittedColumnName.SetDataFrameSelector(clsRDataFrame)


        ' save residuals column names
        ucrSaveResidualsColumnName.SetPrefix("Resids")
        ucrSaveResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveResidualsColumnName.SetCheckBoxText("residuals")
        ucrSaveResidualsColumnName.SetIsComboBox()
        ucrSaveResidualsColumnName.SetDataFrameSelector(clsRDataFrame)

        ' save stdresiduals column names
        ucrSaveStdResidualsColumnName.SetPrefix("Sresids")
        ucrSaveStdResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveStdResidualsColumnName.SetIsComboBox()
        ucrSaveStdResidualsColumnName.SetCheckBoxText("std residuals")
        ucrSaveStdResidualsColumnName.SetDataFrameSelector(clsRDataFrame)

        'save leverage column names
        ucrSaveLeverageColumnName.SetPrefix("Lever")
        ucrSaveLeverageColumnName.SetSaveTypeAsColumn()
        ucrSaveLeverageColumnName.SetIsComboBox()
        ucrSaveLeverageColumnName.SetCheckBoxText("leverage")
        ucrSaveLeverageColumnName.SetDataFrameSelector(clsRDataFrame)

        bControlsInitialised = True
    End Sub

    'Optional clsNewRWriteLeverage As RFunction = Nothing,
    'Optional strNewTempDataframe As String = Nothing,
    Public Sub SetRCode(clsNewRSyntax As RSyntax, Optional clsNewFormulaFunction As RFunction = Nothing, Optional clsNewAnovaFunction As RFunction = Nothing, Optional clsNewRSummaryFunction As RFunction = Nothing, Optional clsNewConfint As RFunction = Nothing, Optional clsNewVisReg As RFunction = Nothing, Optional clsNewRaovpvalFunction As RFunction = Nothing, Optional clsNewRgeom_point As RFunction = Nothing, Optional clsNewRWriteResiduals As RFunction = Nothing, Optional clsNewAutoplot As RFunction = Nothing, Optional clsNewRestpvalFunction As RFunction = Nothing, Optional clsNewRWriteLeverage As RFunction = Nothing, Optional clsNewRWriteStdResiduals As RFunction = Nothing, Optional clsNewRLmOrGLM As RFunction = Nothing, Optional clsNewRModelFunction As RFunction = Nothing, Optional clsNewRXVariable As String = Nothing, Optional clsNewRYVariable As String = Nothing, Optional clsNewRWriteFitted As RFunction = Nothing, Optional clsNewRFittedValues As RFunction = Nothing, Optional clsNewRGraphicsOperator As ROperator = Nothing, Optional bReset As Boolean = False)
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

        clsRGraphicsOperator = clsNewRGraphicsOperator
        clsRLmOrGLM = clsNewRLmOrGLM
        clsRestpvalFunction = clsNewRestpvalFunction
        clsRModelFunction = clsNewRModelFunction
        clsRXVariable = clsNewRXVariable
        clsRYVariable = clsNewRYVariable
        'clsRWriteFitted = clsNewRWriteFitted
        clsRFittedValues = clsNewRFittedValues
        clsRaovpvalFunction = clsNewRaovpvalFunction
        clsRgeom_point = clsNewRgeom_point
        clsAutoplot = clsNewAutoplot
        'clsRWriteResiduals = clsNewRWriteResiduals
        ' clsRWriteStdResiduals = clsNewRWriteStdResiduals
        'clsRWriteLeverage = clsNewRWriteLeverage

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

        ucrChkIndividualPlots.SetRCode(clsAutoplot, bReset)
        ucrPnlIndividualPlots.SetRCode(clsAutoplot, bReset)
        ucrChkMultiplePlots.SetRCode(clsAutoplot, bReset)
        ucrPnlMutiplePlots.SetRCode(clsAutoplot, bReset)

        ucrSaveFittedColumnName.SetRCode(clsRWriteFitted, bReset)
        ucrSaveResidualsColumnName.SetRCode(clsRWriteResiduals, bReset)
        ucrSaveStdResidualsColumnName.SetRCode(clsRWriteStdResiduals, bReset)
        ucrSaveLeverageColumnName.SetRCode(clsRWriteLeverage, bReset)

        clsRResiduals.SetPackageName("stats")
        clsRResiduals.SetRCommand("resid")
        clsRResiduals.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)
        clsRWriteResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRResiduals)

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

    Private Sub ucrChkMultiplePlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMultiplePlots.ControlValueChanged
        If ucrChkMultiplePlots.Checked Then
            clsRSyntax.AddToAfterCodes(clsAutoplot, iPosition:=4)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsAutoplot)
        End If
    End Sub

    Public Sub SetRDataFrame(clsRDataFr As ucrDataFrame)
        clsRDataFrame = clsRDataFr
    End Sub

    Private Sub ucrPnlMutiplePlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMutiplePlots.ControlValueChanged, ucrPnlIndividualPlots.ControlValueChanged
        ''Multiple Plots
        'If ucrChkMultiplePlots.Checked Then
        '    If rdoFourPlots.Checked Then
        '        clsAutoplot.AddParameter("ncol", 2)
        '        clsAutoplot.RemoveParameterByName("which")
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    ElseIf rdoSixPlots2Rows.Checked Then
        '        clsAutoplot.AddParameter("ncol", 3)
        '        clsAutoplot.AddParameter("which", "1:6")
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    ElseIf rdoSixPlots3Rows.Checked Then
        '        clsAutoplot.AddParameter("ncol", 2)
        '        clsAutoplot.AddParameter("which", "1:6")
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    End If
        '    If (rdoFourPlots.Checked OrElse rdoSixPlots2Rows.Checked OrElse rdoSixPlots3Rows.Checked) Then
        '        clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=6)
        '    End If
        'End If
        ''Individual Plots
        'If ucrChkIndividualPlots.Checked Then
        '    If rdoQQ.Checked Then
        '        clsAutoplot.RemoveParameterByName("ncol")
        '        clsAutoplot.AddParameter("which", 2)
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    ElseIf rdoResidualsFitted.Checked Then
        '        clsAutoplot.RemoveParameterByName("ncol")
        '        clsAutoplot.AddParameter("which", 1)
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '        clsRGraphics.SetOperatorParameter(False, clsRFunc:=clsRgeom_point)
        '    ElseIf rdoResidualsLeverage.Checked Then
        '        clsAutoplot.RemoveParameterByName("ncol")
        '        clsAutoplot.AddParameter("which", 5)
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    ElseIf rdoCooksDistanceLeverage.Checked Then
        '        clsAutoplot.RemoveParameterByName("ncol")
        '        clsAutoplot.AddParameter("which", 6)
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    ElseIf rdoCooksDistance.Checked Then
        '        clsAutoplot.RemoveParameterByName("ncol")
        '        clsAutoplot.AddParameter("which", 4)
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    ElseIf rdoScaleLocation.Checked Then
        '        clsAutoplot.RemoveParameterByName("ncol")
        '        clsAutoplot.AddParameter("which", 3)
        '        clsRGraphicsOperator.AddParameter("reidual", clsRFunctionParameter:=clsAutoplot, iPosition:=0)
        '    End If
        '    If (rdoResidualsFitted.Checked OrElse rdoQQ.Checked OrElse rdoResidualsLeverage.Checked OrElse rdoScaleLocation.Checked OrElse rdoCooksDistance.Checked OrElse rdoCooksDistanceLeverage.Checked) Then
        '        clsRSyntax.AddToAfterCodes(clsRGraphicsOperator, iPosition:=7)
        '    End If
        'End If
    End Sub

    Private Sub ucrSaveFittedColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveFittedColumnName.ControlValueChanged
        'clsRFittedValues.SetPackageName("stats")
        'clsRFittedValues.SetRCommand("fitted")
        'clsRFittedValues.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)
        'clsRWriteFitted.AddParameter("col_data", clsRFunctionParameter:=clsRFittedValues)
        'clsRSyntax.AddToAfterCodes(clsRWriteFitted, iPosition:=8)
    End Sub

    Private Sub ucrSaveResidualsColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResidualsColumnName.ControlValueChanged
        'clsRResiduals.SetPackageName("stats")
        'clsRResiduals.SetRCommand("resid")
        'clsRResiduals.AddParameter("object", clsRFunctionParameter:=clsRLmOrGLM)
        'clsRWriteResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRResiduals)
        'clsRSyntax.AddToAfterCodes(clsRWriteResiduals, iPosition:=9)
        ' clsRSyntax.RemoveFromAfterCodes(clsRWriteFitted)
        '    clsRSyntax.RemoveFromAfterCodes(clsRWriteStdResiduals)
        '    clsRSyntax.RemoveFromAfterCodes(clsRWriteLeverage)
    End Sub

    Private Sub ucrSaveStdResidualsColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveStdResidualsColumnName.ControlValueChanged
        'clsRStdResiduals.SetPackageName("stats")
        'clsRStdResiduals.SetRCommand("rstandard")
        'clsRStdResiduals.AddParameter("model", clsRFunctionParameter:=clsRLmOrGLM)
        'clsRWriteStdResiduals.AddParameter("col_data", clsRFunctionParameter:=clsRStdResiduals)
        'clsRSyntax.AddToAfterCodes(clsRWriteStdResiduals, iPosition:=10)
        '   clsRSyntax.RemoveFromAfterCodes(clsRWriteFitted)
        '  clsRSyntax.RemoveFromAfterCodes(clsRWriteResiduals)
        ' clsRSyntax.RemoveFromAfterCodes(clsRWriteLeverage)
    End Sub

    Private Sub ucrSaveLeverageColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveLeverageColumnName.ControlValueChanged
        'clsRLeverage.SetPackageName("stats")
        'clsRLeverage.SetRCommand("hatvalues")
        'clsRLeverage.AddParameter("model", clsRFunctionParameter:=clsRLmOrGLM)
        'clsRWriteLeverage.AddParameter("col_data", clsRFunctionParameter:=clsRLeverage)
        'clsRSyntax.AddToAfterCodes(clsRWriteLeverage, iPosition:=11)
        'clsRSyntax.RemoveFromAfterCodes(clsRWriteStdResiduals)
        'clsRSyntax.RemoveFromAfterCodes(clsRWriteResiduals)
        'clsRSyntax.RemoveFromAfterCodes(clsRWriteFitted)
    End Sub

    Private Sub ucrchkRugs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRugs.ControlValueChanged
        If ucrChkRugs.Checked Then
            rdoPartial.Checked = True
        End If
    End Sub
End Class