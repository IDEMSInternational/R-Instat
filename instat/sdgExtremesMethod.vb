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
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False
    Public Sub InitialiseControls()
        ucrPnlExtremes.SetParameter(New RParameter("method", 2))
        ucrPnlExtremes.AddRadioButton(rdoMle, Chr(34) & "MLE" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoBayesian, Chr(34) & "Bayesian" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoGMLE, Chr(34) & "GMLE" & Chr(34))
        ucrPnlExtremes.AddRadioButton(rdoLmoments, Chr(34) & "Lmoments" & Chr(34))

        ucrNudLocationPrior.SetLinkedDisplayControl(lblLocationPrior)
        ucrNudScalePrior.SetLinkedDisplayControl(lblScalePrior)
        ucrNudShapePrior.SetLinkedDisplayControl(lblShapePrior)
        ucrNudLocationInitial.SetLinkedDisplayControl(lblLocationInitial)
        ucrNudScaleInitial.SetLinkedDisplayControl(lblScaleInitial)
        ucrNudshapeInitial.SetLinkedDisplayControl(lblShapeInitial)
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
    Public Sub SetRCode(clsNewFevdFunction As RFunction, clsNewPlotFunction As RFunction, clsNewRSyntax As RSyntax, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFevdFunction = clsNewFevdFunction
        clsRsyntax = clsNewRSyntax
        clsPlotFunction = clsNewPlotFunction

        ucrPnlExtremes.SetRCode(clsFevdFunction)
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
            ucrNudLocationPrior.Visible = True
            ucrNudScalePrior.Visible = True
            ucrNudShapePrior.Visible = True
            ucrNudLocationInitial.Visible = True
            ucrNudScaleInitial.Visible = True
            ucrNudshapeInitial.Visible = True
            ucrNudNumberOfIterations.Visible = True
        Else
            ucrNudLocationPrior.Visible = False
            ucrNudScalePrior.Visible = False
            ucrNudShapePrior.Visible = False
            ucrNudLocationInitial.Visible = False
            ucrNudScaleInitial.Visible = False
            ucrNudshapeInitial.Visible = False
            ucrNudNumberOfIterations.Visible = False
        End If
    End Sub

    Private Sub ucrPnlExtremes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExtremes.ControlValueChanged
        InitialPriorParametres()
    End Sub
End Class