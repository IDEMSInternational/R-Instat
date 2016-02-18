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
Public Class dlgSummaryBarOrPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_summarybar As New RFunction
    Private clsRgeom_Piechart As New RFunction
    Private clsRgeom_Piechartcoord As New RFunction
    Private clsRaesFunction As New RFunction
    Private Sub cmdOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrYReceiver.Selector = ucrSummarybarSelector
        ucrFactorReceiver.Selector = ucrSummarybarSelector
        ucrSecondFactorReceiver.Selector = ucrSummarybarSelector
        ucrYReceiver.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub grpChartOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarChart.CheckedChanged, rdoPieChart.CheckedChanged
        If rdoBarChart.Checked = True Then
            clsRgeom_summarybar.SetRCommand("geom_bar")
            clsRgeom_summarybar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)
        ElseIf rdoPieChart.Checked = True Then
            clsRgeom_Piechart.SetRCommand("geom_bar")
            clsRgeom_summarybar.AddParameter("width", 1)
            clsRgeom_summarybar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_Piechart)
            ucrBase.clsRsyntax.SetOperation("+")
            clsRgeom_Piechartcoord.SetRCommand("coord_polar")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_Piechartcoord)
            clsRgeom_Piechartcoord.AddParameter("theta", Chr(34) & "Y" & Chr(34))
        Else
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=Nothing)
        End If
    End Sub

    Private Sub ucrYReceiver_Leave(sender As Object, e As EventArgs) Handles ucrYReceiver.Leave
        clsRaesFunction.AddParameter("y", ucrYReceiver.GetVariableNames(False))
    End Sub

    Private Sub ucrSecondFactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.Leave
        clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
    End Sub

    Private Sub ucrFactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorReceiver.Leave
        clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
    End Sub
End Class