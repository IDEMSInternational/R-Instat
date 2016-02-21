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
Public Class dlgDotPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_dotplot As New RFunction
    Private clsRaesFunction As New RFunction
    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRgeom_dotplot.SetRCommand("geom_dotplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrYVariableReceiver.Selector = ucrDotPlotSelector
        ucrFactorReceiver.Selector = ucrDotPlotSelector
        ucrSecondfactorReceiver.Selector = ucrDotPlotSelector
        ucrYVariableReceiver.SetMeAsReceiver()
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)

    End Sub

    Private Sub ucrFactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorReceiver.Leave
        clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
    End Sub

    Private Sub ucrSecondfactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrSecondfactorReceiver.Leave
        clsRaesFunction.AddParameter("fill", ucrSecondfactorReceiver.GetVariableNames(False))
    End Sub

    Private Sub ucrYVariableReceiver_Leave(sender As Object, e As EventArgs) Handles ucrYVariableReceiver.Leave
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_dotplot)

        If ucrFactorReceiver.txtReceiverSingle.Text = "" And ucrSecondfactorReceiver.txtReceiverSingle.Text = "" Then
            clsRgeom_dotplot.AddParameter("binaxis", Chr(34) & "y" & Chr(34))
        Else
            clsRaesFunction.AddParameter("y", ucrYVariableReceiver.GetVariableNames(False))
        End If

    End Sub
End Class