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

Imports instat.Translations
Public Class dlgHistogram
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_histogramFunction As New RFunction
    Private clsRgeom_densityFunction As New RFunction
    Private clsRgeom_FPolygon As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.iCallType = 0
        ucrXReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrXReceiver.SetMeAsReceiver()
        ucrBase.OKEnabled(False)
        autoTranslate(Me)
    End Sub

    Private Sub ucrHistogramSelector_DataFrameChanged(sender As Object, e As EventArgs) Handles ucrHistogramSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrHistogramSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrXReceiver_Leave(sender As Object, e As EventArgs) Handles ucrXReceiver.Leave

        If Not (ucrXReceiver.txtReceiverSingle.Text = "") Then
            clsRaesFunction.AddParameter("x", ucrXReceiver.GetVariableNames(False))
            ucrBase.OKEnabled(True)
        Else

            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrFactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorReceiver.Leave
        clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False))
    End Sub

    Private Sub rdoHistogram_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHistogram.CheckedChanged
        If rdoHistogram.Checked = True Then
            clsRgeom_histogramFunction.SetRCommand("geom_histogram")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_histogramFunction)
        End If
    End Sub

    Private Sub rdoDensity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDensity.CheckedChanged
        If rdoDensity.Checked = True Then
            clsRgeom_densityFunction.SetRCommand("geom_density")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_densityFunction)
        End If
    End Sub

    Private Sub rdoFreequencyPolygon_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFreequencyPolygon.CheckedChanged
        If rdoFreequencyPolygon.Checked = True Then
            clsRgeom_FPolygon.SetRCommand("geom_freqpoly")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_FPolygon)
        End If
    End Sub

    Private Sub rdoHistogram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoHistogram.KeyPress
        If e.KeyChar = vbCr Then
            rdoHistogram.Checked = True
        End If
    End Sub

    Private Sub rdoDensity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoDensity.KeyPress
        If e.KeyChar = vbCr Then
            rdoDensity.Checked = True
        End If
    End Sub

    Private Sub rdoFreequencyPolygon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoFreequencyPolygon.KeyPress
        If e.KeyChar = vbCr Then
            rdoFreequencyPolygon.Checked = True
        End If
    End Sub
End Class