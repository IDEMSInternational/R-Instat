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
Public Class dlgThreeSummaries

    Private Sub dlgThreeSummaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$plot_three_summaries")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub txtPlotType_Leave(sender As Object, e As EventArgs) Handles txtPlotType.Leave
        ucrBase.clsRsyntax.AddParameter("type", txtPlotType.Text.ToString())
    End Sub

    Private Sub nudlineWidth_Leave(sender As Object, e As EventArgs) Handles nudlineWidth.Leave
        ucrBase.clsRsyntax.AddParameter("lwd", nudlineWidth.Value.ToString())
    End Sub

    Private Sub nudLineType_Leave(sender As Object, e As EventArgs) Handles nudLineType.Leave
        ucrBase.clsRsyntax.AddParameter("lty", nudLineType.Value.ToString())
    End Sub

    Private Sub nudPlotCharacter_Leave(sender As Object, e As EventArgs) Handles nudPlotCharacter.Leave
        ucrBase.clsRsyntax.AddParameter("pch", nudPlotCharacter.Value.ToString())
    End Sub

    Private Sub txtColourMinimum_Leave(sender As Object, e As EventArgs) Handles txtColourMinimum.Leave
        ucrBase.clsRsyntax.AddParameter("min_color", txtColourMinimum.Text.ToString())
    End Sub

    Private Sub txtColourMean_Leave(sender As Object, e As EventArgs) Handles txtColourMean.Leave
        ucrBase.clsRsyntax.AddParameter("mean_color", txtColourMean.Text.ToString())
    End Sub

    Private Sub txtColourMaximum_Leave(sender As Object, e As EventArgs) Handles txtColourMaximum.Leave
        ucrBase.clsRsyntax.AddParameter("max_color", txtColourMaximum.Text.ToString())
    End Sub

    Private Sub txtYlabel_Leave(sender As Object, e As EventArgs) Handles txtYlabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylab", txtYlabel.Text.ToString())
    End Sub

    Private Sub txtVariable_Leave(sender As Object, e As EventArgs) Handles txtVariable.Leave
        ucrBase.clsRsyntax.AddParameter("var", txtVariable.Text.ToString())
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("title", txtTitle.Text.ToString())
    End Sub
End Class