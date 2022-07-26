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
    Public clsPlotFunction As New RFunction
    Public clsListFunction As New RFunction
    Public clsListInitialFunction As New RFunction
    Public clsConcatenateFunction As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False
    Public Sub InitialiseControls()
        ucrPnlExtremes.SetParameter(New RParameter("method", 2))
        ucrPnlExtremes.AddRadioButton(rdoMle, Chr(34) & "MLE" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoBayesian, Chr(34) & "Bayesian" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoGMLE, Chr(34) & "GMLE" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoLmoments, Chr(34) & "Lmoments" & Chr(34))


        ucrChkType.SetText("Type")
        ucrChkType.AddToLinkedControls(ucrInputType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputPrior.SetParameter(New RParameter("priorParams", 5))
        ucrInputPrior.AddQuotesIfUnrecognised = False
        ucrInputPrior.SetValidationTypeAsNumericList()
        ucrInputPrior.SetLinkedDisplayControl(lblPrior)

        ucrInputInitial.SetParameter(New RParameter("initial", 6))
        ucrInputInitial.AddQuotesIfUnrecognised = False
        ucrInputInitial.SetValidationTypeAsNumericList()
        ucrInputInitial.SetLinkedDisplayControl(lblInitial)


        ucrNudNumberOfIterations.SetParameter(New RParameter("iter", 7))
        ucrNudNumberOfIterations.SetMinMax(0, 30000)
        ucrNudNumberOfIterations.SetRDefault(9999)
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
                        clsNewRSyntax As RSyntax, clsNewListInitialFunction As RFunction, clsNewConcatenateFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFevdFunction = clsNewFevdFunction
        clsRsyntax = clsNewRSyntax
        clsPlotFunction = clsNewPlotFunction
        clsListFunction = clsNewListFunction
        clsListInitialFunction = clsNewListInitialFunction
        clsConcatenateFunction = clsNewConcatenateFunction
        ucrInputPrior.SetRCode(clsListFunction, bReset)
        ucrInputInitial.SetRCode(clsListInitialFunction, bReset)
        ucrNudNumberOfIterations.SetRCode(clsFevdFunction, bReset)
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
            ucrInputInitial.Visible = True
            ucrInputPrior.Visible = True
            ucrNudNumberOfIterations.Visible = True
        Else
            ucrInputInitial.Visible = False
            ucrInputPrior.Visible = False
            ucrNudNumberOfIterations.Visible = False

        End If
    End Sub

    Private Sub ucrPnlExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremes.ControlValueChanged
        InitialPriorParametres()
    End Sub

    Private Sub ucrInputInitial_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputInitial.ControlValueChanged
        clsFevdFunction.AddParameter("x", "c(" & ucrInputInitial.GetText & ")", iPosition:=6)
        'ucrInputInitial.SetName("0.25,0.5,0.75")
        'ucrInputInitial.SetItems({"0.25,0.5,0.75", "0, 0.2, 0.4, 0.6, 0.8, 1", "0.5, 0.8, 1"})
    End Sub

    Private Sub ucrInputPrior_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPrior.ControlValueChanged
        clsFevdFunction.AddParameter("v", "c(" & ucrInputPrior.GetText & ")", iPosition:=5)
        'ucrInputPrior.SetName("0.25,0.5,0.75")
        'ucrInputPrior.SetItems({"0.25,0.5,0.75", "0, 0.2, 0.4, 0.6, 0.8, 1", "0.5, 0.8, 1"})
    End Sub
End Class