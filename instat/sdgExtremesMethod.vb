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
Public Class sdgExtremesMethod
    Private clsFevdFunction As New RFunction
    Public clsConfidenceIntervalFunction As New RFunction
    Public clsPlotFunction As New RFunction
    Public clsPriorParamListFunction As New RFunction
    Public clsInitialListFunction As New RFunction
    Public clsConcatenateFunction As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False
    Public Sub InitialiseControls()
        Dim dctType As New Dictionary(Of String, String)

        ucrPnlFitMethodExtremes.SetParameter(New RParameter("method", 2))
        ucrPnlFitMethodExtremes.AddRadioButton(rdoMle, Chr(34) & "MLE" & Chr(34))
        ucrPnlFitMethodExtremes.AddRadioButton(rdoBayesian, Chr(34) & "Bayesian" & Chr(34))
        ucrPnlFitMethodExtremes.AddRadioButton(rdoGMLE, Chr(34) & "GMLE" & Chr(34))
        ucrPnlFitMethodExtremes.AddRadioButton(rdoLmoments, Chr(34) & "Lmoments" & Chr(34))

        ucrPnlFitMethodExtremes.AddToLinkedControls(ucrInputPrior, {rdoBayesian}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFitMethodExtremes.AddToLinkedControls({ucrNudScale,
                                                    ucrNudShape, ucrNudLocation}, {rdoBayesian},
                                          bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFitMethodExtremes.AddToLinkedControls(ucrNudNumberOfIterations, {rdoBayesian}, bNewLinkedHideIfParameterMissing:=True,
                                                    bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=9999,
                                                    bNewLinkedUpdateFunction:=True)


        ucrChkType.SetText("Type")
        ucrChkType.AddParameterPresentCondition(True, "type")
        ucrChkType.AddParameterPresentCondition(False, "type", False)

        ucrInputType.SetParameter(New RParameter("type", 1))
        dctType.Add("parameter", Chr(34) & "parameter" & Chr(34))
        dctType.Add("return.level", Chr(34) & "return.level" & Chr(34))
        ucrInputType.SetItems(dctType)
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrNudReturnLevel.SetParameter(New RParameter("return.period", 2))
        ucrNudReturnLevel.SetMinMax(20, 100)
        ucrNudReturnLevel.SetRDefault(100)
        ucrNudReturnLevel.SetLinkedDisplayControl(lblReturnLevel)
        ucrInputType.AddToLinkedControls(ucrNudReturnLevel, {"return.level"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkType.AddToLinkedControls(ucrInputType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True,
                                       bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="parameter")

        ucrInputPrior.SetParameter(New RParameter("first", 5, bNewIncludeArgumentName:=False))
        ucrInputPrior.AddQuotesIfUnrecognised = False
        ucrInputPrior.SetValidationTypeAsNumericList()
        ucrInputPrior.SetLinkedDisplayControl(lblPrior)

        ucrNudLocation.SetParameter(New RParameter("location", 1))
        ucrNudLocation.SetMinMax(-5, 10)
        ucrNudLocation.DecimalPlaces = 1
        ucrNudLocation.Increment = 0.1
        ucrNudLocation.SetLinkedDisplayControl(grpInitial)

        ucrNudScale.SetParameter(New RParameter("scale", 2))
        ucrNudScale.SetMinMax(-5, 10)
        ucrNudScale.DecimalPlaces = 1
        ucrNudScale.Increment = 0.1

        ucrNudShape.SetParameter(New RParameter("shape", 3))
        ucrNudShape.SetMinMax(-5, 10)
        ucrNudShape.DecimalPlaces = 1
        ucrNudShape.Increment = 1

        ucrNudNumberOfIterations.SetParameter(New RParameter("iter", 7))
        ucrNudNumberOfIterations.SetMinMax(0, 30000)
        ucrNudNumberOfIterations.SetLinkedDisplayControl(lblNumberOfIterations)

        ucrPnlDisplayOptionsExtreme.SetParameter(New RParameter("type", 1))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoPrimary, Chr(34) & "primary" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoDensity, Chr(34) & "density" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoHist, Chr(34) & "hist" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoProbprob, Chr(34) & "probprob" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoQQ2, Chr(34) & "qq2" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoQQPlot, Chr(34) & "qq" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoRlplot, Chr(34) & "rl" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoZPlot, Chr(34) & "Zplot" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoTrace, Chr(34) & "trace" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddRadioButton(rdoNoPlot)

        ucrPnlDisplayOptionsExtreme.AddParameterPresentCondition(rdoNoPlot, "type", False)
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoPrimary, "type", Chr(34) & "primary" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoDensity, "type", Chr(34) & "density" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoHist, "type", Chr(34) & "hist" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoProbprob, "type", Chr(34) & "probprob" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoQQ2, "type", Chr(34) & "qq2" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoQQPlot, "type", Chr(34) & "qq" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoRlplot, "type", Chr(34) & "rl" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoZPlot, "type", Chr(34) & "Zplot" & Chr(34))
        ucrPnlDisplayOptionsExtreme.AddParameterValuesCondition(rdoTrace, "type", Chr(34) & "trace" & Chr(34))

        ucrSavePlots.SetPrefix("plot")
        ucrSavePlots.SetSaveTypeAsGraph()
        ucrSavePlots.SetDataFrameSelector(dlgExtremes.ucrSelectorExtremes.ucrAvailableDataFrames)
        ucrSavePlots.SetCheckBoxText("Save Graph:")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_graph")

        bControlsInitialised = True
    End Sub
    Public Sub SetRCode(clsNewFevdFunction As RFunction, clsNewPriorParamListFunction As RFunction,
                        clsNewPlotFunction As RFunction, clsNewRSyntax As RSyntax,
                        clsNewInitialListFunction As RFunction, clsNewConfidenceIntervalFunction As RFunction,
                      Optional clsNewConcatenateFunction As RFunction = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFevdFunction = clsNewFevdFunction
        clsRsyntax = clsNewRSyntax
        clsPlotFunction = clsNewPlotFunction
        clsPriorParamListFunction = clsNewPriorParamListFunction
        clsInitialListFunction = clsNewInitialListFunction
        clsConcatenateFunction = clsNewConcatenateFunction
        clsConfidenceIntervalFunction = clsNewConfidenceIntervalFunction
        ucrChkType.SetRCode(clsConfidenceIntervalFunction, bReset)
        ucrNudReturnLevel.SetRCode(clsConfidenceIntervalFunction, bReset)
        ucrInputPrior.SetRCode(clsConcatenateFunction, bReset)
        ucrNudLocation.SetRCode(clsInitialListFunction, bReset)
        ucrNudScale.SetRCode(clsInitialListFunction, bReset)
        ucrNudShape.SetRCode(clsInitialListFunction, bReset)
        ucrPnlFitMethodExtremes.SetRCode(clsFevdFunction, bReset)
        ucrPnlDisplayOptionsExtreme.SetRCode(clsPlotFunction, bReset, bCloneIfNeeded:=True)
        ucrSavePlots.SetRCode(clsPlotFunction, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub ucrPnlExtreme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayOptionsExtreme.ControlValueChanged
        If rdoNoPlot.Checked Then
            clsPlotFunction.RemoveParameterByName("type")
            clsRsyntax.RemoveFromAfterCodes(clsPlotFunction)
        Else
            clsRsyntax.AddToAfterCodes(clsPlotFunction, iPosition:=0)
        End If
    End Sub

    Private Sub ucrChkType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkType.ControlValueChanged, ucrInputType.ControlValueChanged, ucrNudReturnLevel.ControlValueChanged
        If ucrChkType.Checked Then
            clsConfidenceIntervalFunction.AddParameter("x", clsRFunctionParameter:=clsFevdFunction, iPosition:=0)
            clsRsyntax.SetBaseRFunction(clsConfidenceIntervalFunction)
        Else
            clsConfidenceIntervalFunction.RemoveParameterByName("x")
            clsRsyntax.SetBaseRFunction(clsFevdFunction)
        End If
    End Sub

    Private Sub ucrPnlFitMethodExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFitMethodExtremes.ControlValueChanged
        If rdoBayesian.Checked Then
            clsFevdFunction.AddParameter("priorParams", clsRFunctionParameter:=clsPriorParamListFunction, iPosition:=4)
            clsFevdFunction.AddParameter("initial", clsRFunctionParameter:=clsInitialListFunction, iPosition:=5)
        Else
            clsFevdFunction.RemoveParameterByName("priorParams")
            clsFevdFunction.RemoveParameterByName("initial")
        End If
    End Sub
End Class