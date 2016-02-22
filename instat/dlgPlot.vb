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
Public Class dlgPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_plotFunction As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)
        ucrReceiverY.Selector = ucrPlotSelector
        ucrReceiverX.Selector = ucrPlotSelector
        ucrFactorOptionalReceiver.Selector = ucrPlotSelector
        ucrReceiverY.SetMeAsReceiver()
    End Sub

    Private Sub ucrReceiverY_Leave(sender As Object, e As EventArgs) Handles ucrReceiverY.Leave
        clsRaesFunction.AddParameter("y", ucrReceiverY.GetVariableNames(False))
    End Sub

    Private Sub ucrReceiverX_Leave(sender As Object, e As EventArgs) Handles ucrReceiverX.Leave
        clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
    End Sub

    Private Sub ucrPlotSelector_DataFrameChanged() Handles ucrPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrFactorOptionalReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.Leave
        clsRaesFunction.AddParameter("fill", ucrFactorOptionalReceiver.GetVariableNames(False))
    End Sub

    Private Sub chkPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkPoints.CheckedChanged
        If chkPoints.Checked = True Then
            clsRgeom_plotFunction.SetRCommand("geom_point")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_plotFunction)
        End If
    End Sub

    Private Sub chkLines_CheckedChanged(sender As Object, e As EventArgs) Handles chkLines.CheckedChanged
        If chkLines.Checked = True Then
            clsRgeom_plotFunction.SetRCommand("geom_line")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_plotFunction)
        End If
    End Sub
End Class