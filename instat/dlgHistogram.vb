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
    Public bFirstLoad As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_histogramFunction As New RFunction
    Private clsRgeom_densityFunction As New RFunction
    Private clsRgeom_FPolygon As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            'setdefaults
            SetDefaults()
            bFirstLoad = False
        Else
            'todo what happens when it reopens
            ReopenDialog()
        End If

        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 118
        ucrXReceiver.SetMeAsReceiver()
        ucrFactorReceiver.SetDataType("factor")
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub ucrHistogramSelector_DataFrameChanged() Handles ucrHistogramSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrHistogramSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrXReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrXReceiver.SelectionChanged
        If Not ucrXReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrXReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        If Not ucrFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub rdoHistogram_CheckedChanged(sender As Object, e As EventArgs) Handles rdoHistogram.CheckedChanged
        If rdoHistogram.Checked = True Then
            clsRgeom_histogramFunction.SetRCommand("geom_histogram")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_histogramFunction)
            cmdHistogramOptions.Visible = True
        Else
            cmdHistogramOptions.Visible = False
        End If
    End Sub

    Private Sub rdoDensity_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDensity.CheckedChanged
        If rdoDensity.Checked = True Then
            clsRgeom_densityFunction.SetRCommand("geom_density")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_densityFunction)
            cmdDensityOptions.Visible = True
        Else
            cmdDensityOptions.Visible = False
        End If
    End Sub

    Private Sub rdoFreequencyPolygon_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFreequencyPolygon.CheckedChanged
        If rdoFreequencyPolygon.Checked = True Then
            clsRgeom_FPolygon.SetRCommand("geom_freqpoly")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_FPolygon)
            cmdFrequencyOptions.Visible = True
        Else
            cmdFrequencyOptions.Visible = False
        End If
    End Sub

    Private Sub TestOkEnabled()
        'tests when ok can be enabled
        If ucrXReceiver.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If

    End Sub

    Private Sub SetDefaults()
        'seting Defaults for the dialog
        ucrXReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrXReceiver.SetMeAsReceiver()
        ucrHistogramSelector.Reset()
        rdoHistogram.Checked = True
        cmdHistogramOptions.Visible = True
        cmdDensityOptions.Visible = False
        cmdFrequencyOptions.Visible = False
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()
        'TODO what happens on reopening

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

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdHistogramOptions_Click(sender As Object, e As EventArgs) Handles cmdHistogramOptions.Click
        sdgHistogramOptions.ShowDialog()
    End Sub

    Private Sub cmdFrequencyOptions_Click(sender As Object, e As EventArgs) Handles cmdFrequencyOptions.Click
        sdgFrequencyPolygonOptions.ShowDialog()
    End Sub

    Private Sub cmdDensityOptions_Click(sender As Object, e As EventArgs) Handles cmdDensityOptions.Click
        sdgDensityOptions.ShowDialog()
    End Sub
End Class