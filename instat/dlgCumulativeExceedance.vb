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
Public Class dlgCumulativeExceedance


    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtInterestedVariable_Leave(sender As Object, e As EventArgs) Handles txtInterestedVariable.Leave
        ucrBase.clsRsyntax.AddParameter("interested_var", Chr(34) & txtInterestedVariable.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlabel", Chr(34) & txtXLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtDataperiodLabel_Leave(sender As Object, e As EventArgs) Handles txtDataperiodLabel.Leave
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylabel", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub nudLineWidth_Leave(sender As Object, e As EventArgs) Handles nudLineWidth.Leave
        ucrBase.clsRsyntax.AddParameter("lwd", nudLineWidth.Value.ToString())

    End Sub

    Private Sub nudPlotCharacter_Leave(sender As Object, e As EventArgs) Handles nudPlotCharacter.Leave
        ucrBase.clsRsyntax.AddParameter("lwd", nudLineWidth.Value.ToString())

    End Sub

    Private Sub nudColourRainbow_Leave(sender As Object, e As EventArgs) Handles nudColourRainbow.Leave
        ucrBase.clsRsyntax.AddParameter("lwd", "rainbow(" & nudLineWidth.Value.ToString() & ")")

    End Sub

    Private Sub txtLegendBtype_Leave(sender As Object, e As EventArgs) Handles txtLegendBtype.Leave
        ucrBase.clsRsyntax.AddParameter("legend_bty", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub dlgCumulativeExceedance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$cumulative_exceedance_graphs")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub txtLegendLabel_Leave(sender As Object, e As EventArgs) Handles txtLegendLabel.Leave
        ucrBase.clsRsyntax.AddParameter("legend_label", "c(" & Chr(34) & txtYLabel.Text.ToString() & Chr(34) & ")") ' is a vector

    End Sub

    Private Sub chkPlotWindow_Leave(sender As Object, e As EventArgs) Handles chkPlotWindow.Leave
        If chkPlotWindow.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot_window", chkPlotWindow.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkPercents_Leave(sender As Object, e As EventArgs) Handles chkPercents.Leave
        If chkPercents.Checked Then
            ucrBase.clsRsyntax.AddParameter("percents", chkPercents.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkGridSquare_Leave(sender As Object, e As EventArgs) Handles chkGridSquare.Leave
        If chkGridSquare.Checked Then
            ucrBase.clsRsyntax.AddParameter("grid_sq", chkGridSquare.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkStationName_Leave(sender As Object, e As EventArgs) Handles chkStationName.Leave
        If chkStationName.Checked Then
            ucrBase.clsRsyntax.AddParameter("station_name", chkStationName.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkCumulativeGraph_Leave(sender As Object, e As EventArgs) Handles chkCumulativeGraph.Leave
        If chkCumulativeGraph.Checked Then
            ucrBase.clsRsyntax.AddParameter("cumulative_graph", chkCumulativeGraph.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub txtLegendPosition_Leave(sender As Object, e As EventArgs) Handles txtLegendPosition.Leave
        ucrBase.clsRsyntax.AddParameter("legend_position", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub
End Class