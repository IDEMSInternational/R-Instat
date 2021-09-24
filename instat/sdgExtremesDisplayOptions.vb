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
Public Class sdgExtremesDisplayOptions
    Public clsPlotFunction As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False
    Private Sub sdgExtremeDisplayOtions(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
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

    Public Sub SetRCode(clsNewPlotFunction As RFunction, clsNewRSyntax As RSyntax, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsRsyntax = clsNewRSyntax
        clsPlotFunction = clsNewPlotFunction

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
End Class
