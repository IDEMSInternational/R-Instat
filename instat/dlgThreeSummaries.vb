
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
Public Class dlgThreeSummaries

    Private Sub dlgThreeSummaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$plot_three_summaries")
        ucrBase.clsRsyntax.iCallType = 0

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("title", txtTitle.Text.ToString())

    End Sub

    Private Sub txtVariable_TextChanged(sender As Object, e As EventArgs) Handles txtVariable.TextChanged
        ucrBase.clsRsyntax.AddParameter("var", txtVariable.Text.ToString())

    End Sub

    Private Sub txtYlabel_TextChanged(sender As Object, e As EventArgs) Handles txtYlabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", txtYlabel.Text.ToString())

    End Sub

    Private Sub txtColourMaximum_TextChanged(sender As Object, e As EventArgs) Handles txtColourMaximum.TextChanged
        ucrBase.clsRsyntax.AddParameter("max_color", txtColourMaximum.Text.ToString())

    End Sub
    Private Sub txtColourMean_TextChanged(sender As Object, e As EventArgs) Handles txtColourMean.TextChanged
        ucrBase.clsRsyntax.AddParameter("mean_color", txtColourMean.Text.ToString())

    End Sub
    Private Sub txtColourMinimum_TextChanged(sender As Object, e As EventArgs) Handles txtColourMinimum.TextChanged
        ucrBase.clsRsyntax.AddParameter("min_color", txtColourMinimum.Text.ToString())

    End Sub

    Private Sub nudPlotCharacter_ValueChanged(sender As Object, e As EventArgs) Handles nudPlotCharacter.ValueChanged
        ucrBase.clsRsyntax.AddParameter("pch", nudPlotCharacter.Value.ToString())

    End Sub

    Private Sub nudLineType_ValueChanged(sender As Object, e As EventArgs) Handles nudLineType.ValueChanged
        ucrBase.clsRsyntax.AddParameter("lty", nudLineType.Value.ToString())

    End Sub

    Private Sub nudlineWidth_ValueChanged(sender As Object, e As EventArgs) Handles nudlineWidth.ValueChanged
        ucrBase.clsRsyntax.AddParameter("lwd", nudlineWidth.Value.ToString())

    End Sub

    Private Sub txtPlotType_TextChanged(sender As Object, e As EventArgs) Handles txtPlotType.TextChanged
        ucrBase.clsRsyntax.AddParameter("type", txtPlotType.Text.ToString())

    End Sub
End Class