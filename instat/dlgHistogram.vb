﻿' Instat-R
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
    Private clsRgeom_boxplotFunction As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRgeom_boxplotFunction.SetRCommand("geom_histogram")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.iCallType = 0
        ucrXReceiver.Selector = ucrHistogramSelector
        ucrXReceiver.SetMeAsReceiver()
        ucrBase.OKEnabled(False)
        autoTranslate(Me)
    End Sub

    Private Sub ucrHistogramSelector_DataFrameChanged(sender As Object, e As EventArgs) Handles ucrHistogramSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrHistogramSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrXReceiver_ValueChanged(sender As Object, e As EventArgs) Handles ucrXReceiver.ValueChanged
        If Not (ucrXReceiver.txtReceiverSingle.Text = "") Then
            clsRaesFunction.AddParameter("x", ucrXReceiver.GetVariableNames(False))
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

End Class