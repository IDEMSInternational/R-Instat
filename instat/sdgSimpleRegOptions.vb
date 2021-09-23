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

Public Class sdgSimpleRegOptions
    Public clsRGraphics As New RSyntax
    Private clsRSyntax As New RSyntax
    Private ucrAvailableDataframe As ucrDataFrame
    Public clsRAovFunction, clsRPredFunction, clsRDFFunction, clsRResiduals, clsRLeverage As New RFunction
    Public clsVisReg, clsRaesFunction, clsRStat_smooth, clsR_ribbon, clsRaes_ribbon As New RFunction
    'Public clsWhichFunction As RFunction
    Public bRCodeSet As Boolean = True
    Private clsResidplotFunction, clsQQplotFunction, clsScaleLocationFunction, clsCooksDistanceFunction, clsResidualsLeverageFunction, clsCooksDistanceLeverage As New RFunction
    'Private dctPlot As New Dictionary(Of String, RFunction)

    'Display tab functions
    Public clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As RFunction
    Private clsFittedValuesFunction, clsResidualFunction, clsRstandardFunction, clsHatvaluesFunction As New RFunction

    Public bControlsInitialised As Boolean = False

    Private Sub sdgSimpleRegOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        InitialiseTabs()

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
        ucrChkFittedModel.AddToLinkedControls(ucrNudWhiteSpace, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrNudGraphicsCLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.05)
        ucrChkFittedModel.AddToLinkedControls(ucrChkPartial, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkRugs, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkJitter, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrChkConfIntervalband, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrPnlPlotType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFittedModel.AddToLinkedControls(ucrPnlScale, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudGraphicsCLevel.SetLinkedDisplayControl(lblGraphicsSignLevel)
        ucrNudWhiteSpace.SetLinkedDisplayControl(lblWhiteSpace)
        ucrPnlPlotType.SetLinkedDisplayControl(grpPlotType)
        ucrPnlScale.SetLinkedDisplayControl(grpScale)
        ucrPnlPartial12.SetLinkedDisplayControl(grpRugs)

        'Individual Plots (Autoplot function)
        ucrChkResidualsFitted.SetText("Residuals v Fitted Values")
        ucrChkQQ.SetText("Q-Q")
        ucrChkScaleLocation.SetText("Scale-Location")
        ucrChkCooksDistance.SetText("Cook's Distance")
        ucrChkResidualsLeverage.SetText("Residuals v Leverage")
        ucrChkCooksDistanceLeverage.SetText("Cook's Distance v Leverage")

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

        ucrChkRugs.AddToLinkedControls(ucrPnlPartial12, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoPartial)

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
        ucrSaveFittedColumnName.SetPrefix("fitted")
        ucrSaveFittedColumnName.SetSaveTypeAsColumn()
        ucrSaveFittedColumnName.SetCheckBoxText("Fitted Values")
        ucrSaveFittedColumnName.SetIsComboBox()

        '' save residuals column names
        ucrSaveResidualsColumnName.SetPrefix("resids")
        ucrSaveResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveResidualsColumnName.SetCheckBoxText("Residuals")
        ucrSaveResidualsColumnName.SetIsComboBox()

        '' save stdresiduals column names
        ucrSaveStdResidualsColumnName.SetPrefix("sresids")
        ucrSaveStdResidualsColumnName.SetSaveTypeAsColumn()
        ucrSaveStdResidualsColumnName.SetIsComboBox()
        ucrSaveStdResidualsColumnName.SetCheckBoxText("Std Residuals")

        ''save leverage column names
        ucrSaveLeverageColumnName.SetPrefix("lever")
        ucrSaveLeverageColumnName.SetSaveTypeAsColumn()
        ucrSaveLeverageColumnName.SetIsComboBox()
        ucrSaveLeverageColumnName.SetCheckBoxText("Leverage")

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewFormulaFunction As RFunction, clsNewAnovaFunction As RFunction, clsNewRSummaryFunction As RFunction, clsNewConfint As RFunction, clsNewVisReg As RFunction, clsNewResidualFunction As RFunction, clsNewFittedValuesFunction As RFunction, clsNewRstandardFunction As RFunction, clsNewHatvaluesFunction As RFunction, ucrNewAvailableDatafrane As ucrDataFrame, dctNewPlot As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)
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
        clsResidualFunction = clsNewResidualFunction
        clsFittedValuesFunction = clsNewFittedValuesFunction
        clsRstandardFunction = clsNewRstandardFunction
        clsHatvaluesFunction = clsNewHatvaluesFunction

        'Graph functions
        clsVisReg = clsNewVisReg

        clsResidplotFunction = dctNewPlot.Values(0)
        clsQQplotFunction = dctNewPlot.Values(1)
        clsScaleLocationFunction = dctNewPlot.Values(2)
        clsCooksDistanceFunction = dctNewPlot.Values(3)
        clsResidualsLeverageFunction = dctNewPlot.Values(4)
        clsCooksDistanceLeverage = dctNewPlot.Values(5)

        ucrAvailableDataframe = ucrNewAvailableDatafrane

        ucrSaveResidualsColumnName.SetDataFrameSelector(ucrAvailableDataframe)
        ucrSaveFittedColumnName.SetDataFrameSelector(ucrAvailableDataframe)
        ucrSaveStdResidualsColumnName.SetDataFrameSelector(ucrAvailableDataframe)
        ucrSaveLeverageColumnName.SetDataFrameSelector(ucrAvailableDataframe)

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

        Dim clsTempFunc As RFunction
        Dim clsTempParam As RParameter
        Dim lstPlots As New List(Of Integer)

        For Each clsRCode As RCodeStructure In clsRSyntax.lstAfterCodes
            clsTempFunc = TryCast(clsRCode, RFunction)
            If clsTempFunc IsNot Nothing AndAlso clsTempFunc.strRCommand = "plot" AndAlso clsTempFunc.ContainsParameter("which") Then
                clsTempParam = clsTempFunc.GetParameter("which")
                Select Case clsTempParam.strArgumentValue
                    Case 1
                        clsResidplotFunction = clsTempFunc
                        lstPlots.Add(1)
                    Case 2
                        clsQQplotFunction = clsTempFunc
                        lstPlots.Add(2)
                    Case 3
                        clsScaleLocationFunction = clsTempFunc
                        lstPlots.Add(3)
                    Case 4
                        clsCooksDistanceFunction = clsTempFunc
                        lstPlots.Add(4)
                    Case 5
                        clsResidualsLeverageFunction = clsTempFunc
                        lstPlots.Add(5)
                    Case 6
                        clsCooksDistanceLeverage = clsTempFunc
                        lstPlots.Add(6)
                End Select
            End If
        Next
        ucrChkResidualsFitted.Checked = (lstPlots.Contains(1))
        ucrChkQQ.Checked = (lstPlots.Contains(2))
        ucrChkScaleLocation.Checked = (lstPlots.Contains(3))
        ucrChkCooksDistance.Checked = (lstPlots.Contains(4))
        ucrChkResidualsLeverage.Checked = (lstPlots.Contains(5))
        ucrChkCooksDistanceLeverage.Checked = (lstPlots.Contains(6))

        'Saving options
        ucrSaveFittedColumnName.SetRCode(clsFittedValuesFunction, bReset, bCloneIfNeeded:=True)
        ucrSaveResidualsColumnName.SetRCode(clsResidualFunction, bReset, bCloneIfNeeded:=True)
        ucrSaveStdResidualsColumnName.SetRCode(clsRstandardFunction, bReset, bCloneIfNeeded:=True)
        ucrSaveLeverageColumnName.SetRCode(clsHatvaluesFunction, bReset, bCloneIfNeeded:=True)

        If bReset Then
            tbpRegOptions.SelectedIndex = 0
            tcGraphics.SelectedIndex = 0
            'TODO:This are temporary fixes to enable this save controls to reset properly!
            ucrSaveResidualsColumnName.ucrChkSave.Checked = False
            ucrSaveFittedColumnName.ucrChkSave.Checked = False
            ucrSaveStdResidualsColumnName.ucrChkSave.Checked = False
            ucrSaveLeverageColumnName.ucrChkSave.Checked = False
            ucrSaveResidualsColumnName.Reset()
            ucrSaveFittedColumnName.Reset()
            ucrSaveStdResidualsColumnName.Reset()
            ucrSaveLeverageColumnName.Reset()
        End If
        GroupBoxDisplay()
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
            grpPlotType.Show()
            grpScale.Show()
            clsRSyntax.AddToAfterCodes(clsVisReg, iPosition:=4)
        Else
            grpPlotType.Hide()
            grpScale.Hide()
            clsRSyntax.RemoveFromAfterCodes(clsVisReg)
        End If
    End Sub

    Private Sub GroupBoxDisplay()
        If ucrChkFittedModel.Checked Then
            grpPlotType.Show()
            grpScale.Show()
        Else
            grpPlotType.Hide()
            grpScale.Hide()
        End If
        If ucrChkRugs.Checked Then
            grpRugs.Show()
        Else
            grpRugs.Hide()
        End If
    End Sub

    Private Sub ucrchkRugs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRugs.ControlValueChanged
        If ucrChkRugs.Checked Then
            rdoPartial.Checked = True
        End If
    End Sub

    Private Sub ucrSaveResidualsColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResidualsColumnName.ControlValueChanged
        If ucrSaveResidualsColumnName.ucrChkSave.Checked Then
            clsRSyntax.AddToAfterCodes(clsResidualFunction, iPosition:=5)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsResidualFunction)
        End If
    End Sub

    Private Sub ucrSaveFittedColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveFittedColumnName.ControlValueChanged
        If ucrSaveFittedColumnName.ucrChkSave.Checked Then
            clsRSyntax.AddToAfterCodes(clsFittedValuesFunction, iPosition:=6)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsFittedValuesFunction)
        End If
    End Sub

    Private Sub ucrSaveStdResidualsColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveStdResidualsColumnName.ControlValueChanged
        If ucrSaveStdResidualsColumnName.ucrChkSave.Checked Then
            clsRSyntax.AddToAfterCodes(clsRstandardFunction, iPosition:=7)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRstandardFunction)
        End If
    End Sub

    Private Sub ucrSaveLeverageColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveLeverageColumnName.ControlValueChanged
        If ucrSaveLeverageColumnName.ucrChkSave.Checked Then
            clsRSyntax.AddToAfterCodes(clsHatvaluesFunction, iPosition:=8)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsHatvaluesFunction)
        End If
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpRegOptions.TabCount - 1
            tbpRegOptions.SelectedIndex = i
        Next
        tbpRegOptions.TabPages(2).Enabled = True
        tbpRegOptions.SelectedIndex = 0
        For j = 0 To tcGraphics.TabCount - 1
            tcGraphics.SelectedIndex = j
        Next
        tcGraphics.SelectedIndex = 0
    End Sub

    Private Sub ucrChkResidualsFitted_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkResidualsFitted.ControlValueChanged
        If ucrChkResidualsFitted.Checked Then
            clsRSyntax.AddToAfterCodes(clsResidplotFunction, iPosition:=9)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsResidplotFunction)
        End If
    End Sub

    Private Sub ucrChkQQ_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkQQ.ControlValueChanged
        If ucrChkQQ.Checked Then
            clsRSyntax.AddToAfterCodes(clsQQplotFunction, iPosition:=10)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsQQplotFunction)
        End If
    End Sub

    Private Sub ucrChkScaleLocation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkScaleLocation.ControlValueChanged
        If ucrChkScaleLocation.Checked Then
            clsRSyntax.AddToAfterCodes(clsScaleLocationFunction, iPosition:=11)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsScaleLocationFunction)
        End If
    End Sub

    Private Sub ucrChkCooksDistance_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCooksDistance.ControlValueChanged
        If ucrChkCooksDistance.Checked Then
            clsRSyntax.AddToAfterCodes(clsCooksDistanceFunction, iPosition:=12)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsCooksDistanceFunction)
        End If
    End Sub

    Private Sub ucrChkResidualsLeverage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkResidualsLeverage.ControlValueChanged
        If ucrChkResidualsLeverage.Checked Then
            clsRSyntax.AddToAfterCodes(clsResidualsLeverageFunction, iPosition:=13)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsResidualsLeverageFunction)
        End If
    End Sub

    Private Sub ucrChkCooksDistanceLeverage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCooksDistanceLeverage.ControlValueChanged
        If ucrChkCooksDistanceLeverage.Checked Then
            clsRSyntax.AddToAfterCodes(clsCooksDistanceLeverage, iPosition:=14)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsCooksDistanceLeverage)
        End If
    End Sub
End Class