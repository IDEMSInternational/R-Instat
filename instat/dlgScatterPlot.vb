
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

Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_scatterplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub ucrPlotSelector_Load(sender As Object, e As EventArgs) Handles ucrScatterPlotSelector.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_scatterplotFunction.SetRCommand("geom_point")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_scatterplotFunction)

        ucrReceiverX.Selector = ucrScatterPlotSelector
        ucrReceiverX.SetDataType("numeric")
        ucrReceiverY.Selector = ucrScatterPlotSelector
        ucrReceiverY.SetDataType("numeric")
        ucrFactorOptionalReceiver.Selector = ucrScatterPlotSelector
        ucrFactorOptionalReceiver.SetDataType("factor")
        autoTranslate(Me)

        If bFirstLoad Then
            'setdefauts
            bFirstLoad = False
            SetDefaults()

        End If
    End Sub
    Private Sub ucrScatterPlotSelector_DataFrameChanged() Handles ucrScatterPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrScatterPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverY.SelectionChanged
        If ucrReceiverY.IsEmpty() = False Then
            clsRaesFunction.AddParameter("y", ucrReceiverY.GetVariableNames(False))
            ucrReceiverX.SetMeAsReceiver()
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged

        If ucrReceiverX.IsEmpty() = False Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
            ucrFactorOptionalReceiver.SetMeAsReceiver()
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        If ucrFactorOptionalReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("color", ucrFactorOptionalReceiver.GetVariableNames(False))
            ucrReceiverY.SetMeAsReceiver()
        Else
            clsRaesFunction.RemoveParameterByName("color")
        End If
    End Sub

    Private Sub TestOkEnabled()
        'tests when okay is enable
        If ucrReceiverX.IsEmpty() = True Or ucrReceiverY.IsEmpty() = True Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub SetDefaults()
        'setDefaults
        ucrScatterPlotSelector.Reset()
        ucrScatterPlotSelector.Focus()
        ucrReceiverY.SetMeAsReceiver()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub
End Class