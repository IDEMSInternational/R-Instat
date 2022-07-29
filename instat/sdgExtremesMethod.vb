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
    Public clsListFunction As New RFunction
    Public clsListInitialFunction As New RFunction
    Public clsConcatenateFunction As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False
    Public Sub InitialiseControls()
        Dim dctType As New Dictionary(Of String, String)

        ucrPnlExtremes.SetParameter(New RParameter("method", 2))
        ucrPnlExtremes.AddRadioButton(rdoMle, Chr(34) & "MLE" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoBayesian, Chr(34) & "Bayesian" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoGMLE, Chr(34) & "GMLE" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoLmoments, Chr(34) & "Lmoments" & Chr(34))


        ucrChkType.SetText("Type")
        ucrChkType.AddParameterPresentCondition(True, "type")
        ucrChkType.AddParameterPresentCondition(False, "type", False)

        ucrInputType.SetParameter(New RParameter("type", 1))
        dctType.Add("parameter", Chr(34) & "parameter" & Chr(34))
        dctType.Add("return.level", Chr(34) & "return.level" & Chr(34))
        ucrInputType.SetItems(dctType)
        'ucrInputType.SetRDefault(Chr(34) & "parameter" & Chr(34))
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrNudReturnLevel.SetParameter(New RParameter("return.period", 2))
        ucrNudReturnLevel.SetMinMax(20, 100)
        ucrNudReturnLevel.SetRDefault(20)
        ucrNudReturnLevel.SetLinkedDisplayControl(lblReturnLevel)
        ucrInputType.AddToLinkedControls(ucrNudReturnLevel, {"return.level"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkType.AddToLinkedControls(ucrInputType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True,
                                       bNewLinkedUpdateFunction:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Chr(34) & "parameter" & Chr(34))

        ucrInputPrior.SetParameter(New RParameter("first", 5, bNewIncludeArgumentName:=False))
        ucrInputPrior.AddQuotesIfUnrecognised = False
        ucrInputPrior.SetValidationTypeAsNumericList()
        ucrInputPrior.SetLinkedDisplayControl(lblPrior)

        ucrNudLocation.SetParameter(New RParameter("location", 1))
        ucrNudLocation.SetMinMax(-5, 10)
        ucrNudLocation.DecimalPlaces = 1
        ucrNudLocation.Increment = 0.1

        ucrNudScale.SetParameter(New RParameter("scale", 2))
        ucrNudScale.SetMinMax(-5, 10)
        ucrNudScale.DecimalPlaces = 1
        ucrNudScale.Increment = 0.1
        'ucrNudScale.SetRDefault(0.1)

        ucrNudShape.SetParameter(New RParameter("shape", 3))
        ucrNudShape.SetMinMax(-5, 10)
        ucrNudShape.DecimalPlaces = 1
        ucrNudShape.Increment = 1
        'ucrNudShape.SetRDefault(-0.5)

        ucrNudLocation.SetLinkedDisplayControl(lblLocation)
        ucrNudScale.SetLinkedDisplayControl(lblScale)
        ucrNudShape.SetLinkedDisplayControl(lblShape)

        ucrNudNumberOfIterations.SetParameter(New RParameter("iter", 7))
        ucrNudNumberOfIterations.SetMinMax(0, 30000)
        ucrNudNumberOfIterations.SetLinkedDisplayControl(lblNumberOfIterations)


        'ucrPnlExtremes.AddToLinkedControls({ucrNudLocationInitial, ucrNudLocationPrior, ucrNudScaleInitial, ucrNudScalePrior, ucrNudshapeInitial, ucrNudShapePrior, ucrNudNumberOfIterations}, {rdoBayesian})


        ucrPnlExtreme.SetParameter(New RParameter("type", 1))

        ucrPnlExtreme.AddRadioButton(rdoPrimary, Chr(34) & "primary" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoDensity, Chr(34) & "density" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoHist, Chr(34) & "hist" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoProbprob, Chr(34) & "probprob" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoQQ2, Chr(34) & "qq2" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoQQPlot, Chr(34) & "qq" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoRlplot, Chr(34) & "rl" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoZPlot, Chr(34) & "Zplot" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoTrace, Chr(34) & "trace" & Chr(34))
        ucrPnlExtreme.AddRadioButton(rdoNoPlot)

        ucrPnlExtreme.AddParameterPresentCondition(rdoNoPlot, "type", False)
        ucrPnlExtreme.AddParameterValuesCondition(rdoPrimary, "type", Chr(34) & "primary" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoDensity, "type", Chr(34) & "density" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoHist, "type", Chr(34) & "hist" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoProbprob, "type", Chr(34) & "probprob" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoQQ2, "type", Chr(34) & "qq2" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoQQPlot, "type", Chr(34) & "qq" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoRlplot, "type", Chr(34) & "rl" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoZPlot, "type", Chr(34) & "Zplot" & Chr(34))
        ucrPnlExtreme.AddParameterValuesCondition(rdoTrace, "type", Chr(34) & "trace" & Chr(34))

        ucrSavePlots.SetPrefix("plot")
        ucrSavePlots.SetSaveTypeAsGraph()
        ucrSavePlots.SetDataFrameSelector(dlgExtremes.ucrSelectorExtremes.ucrAvailableDataFrames)
        ucrSavePlots.SetCheckBoxText("Save Graph:")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_graph")

        bControlsInitialised = True
    End Sub
    Public Sub SetRCode(clsNewFevdFunction As RFunction, clsNewListFunction As RFunction, clsNewPlotFunction As RFunction,
                        clsNewRSyntax As RSyntax, clsNewListInitialFunction As RFunction, clsNewConfidenceIntervalFunction As RFunction,
                      Optional clsNewConcatenateFunction As RFunction = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFevdFunction = clsNewFevdFunction
        clsRsyntax = clsNewRSyntax
        clsPlotFunction = clsNewPlotFunction
        clsListFunction = clsNewListFunction
        clsListInitialFunction = clsNewListInitialFunction
        clsConcatenateFunction = clsNewConcatenateFunction
        clsConfidenceIntervalFunction = clsNewConfidenceIntervalFunction
        ucrChkType.SetRCode(clsConfidenceIntervalFunction)
        ucrNudReturnLevel.SetRCode(clsConfidenceIntervalFunction, bReset)
        ucrInputPrior.SetRCode(clsConcatenateFunction, bReset)
        ucrNudNumberOfIterations.SetRCode(clsFevdFunction, bReset)

        ucrNudLocation.SetRCode(clsListInitialFunction, bReset)
        ucrNudScale.SetRCode(clsListInitialFunction, bReset)
        ucrNudShape.SetRCode(clsListInitialFunction, bReset)

        ucrPnlExtremes.SetRCode(clsFevdFunction, bReset)
        ucrPnlExtreme.SetRCode(clsPlotFunction, bReset, bCloneIfNeeded:=True)
        ucrSavePlots.SetRCode(clsPlotFunction, bReset, bCloneIfNeeded:=True)
    End Sub
    Private Sub ucrPnlExtreme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtreme.ControlValueChanged
        If rdoNoPlot.Checked Then
            clsPlotFunction.RemoveParameterByName("type")
            clsRsyntax.RemoveFromAfterCodes(clsPlotFunction)
        Else
            clsRsyntax.AddToAfterCodes(clsPlotFunction, iPosition:=0)
        End If
    End Sub
    Private Sub InitialPriorParametres()

        If rdoBayesian.Checked Then
            ucrNudScale.Visible = True
            ucrNudLocation.Visible = True
            ucrNudShape.Visible = True
            ucrInputPrior.Visible = True
            ucrNudNumberOfIterations.Visible = True
            grpInitial.Visible = True
        Else
            ucrNudScale.Visible = False
            ucrNudLocation.Visible = False
            ucrNudShape.Visible = False
            ucrInputPrior.Visible = False
            ucrNudNumberOfIterations.Visible = False
            grpInitial.Visible = False

        End If
    End Sub

    Private Sub ucrPnlExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremes.ControlValueChanged
        InitialPriorParametres()
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
End Class