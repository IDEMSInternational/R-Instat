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

Public Class dlgMissingValuesplot
    Private Sub dlgMissingValuesplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.iCallType = 0
        txtTitle.Text = "Rain Present"
        txtXLabel.Text = "Year"
        txtYLabel.Text = "Day of Year"
        txtLegendPosition.Text = "topright"
        txtRainFillColour.Text = "blue"
        txtMissingFillColor.Text = "red"
        txtDryFillColor.Text = "yellow"
        chkStationName.Checked = True
        chkHorizontal.Checked = True
        nudThreshold.Value = "0.85"
        txtASP.Text = "NA"
        txtlog.Text = ""
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$plot_missing_values_rain")
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtLegend_Leave(sender As Object, e As EventArgs) Handles txtLegend.Leave
        'legend is a vector"c(len1,len2,len3)"
        ucrBase.clsRsyntax.AddParameter("legend", "c(" & Chr(34) & "Rain" & Chr(34) & "," & Chr(34) & "Dry" & Chr(34) & "," & Chr(34) & "NA" & Chr(34) & ")")
    End Sub

    Private Sub txtLegendPosition_Leave(sender As Object, e As EventArgs) Handles txtLegendPosition.Leave
        ucrBase.clsRsyntax.AddParameter("legend_position", Chr(34) & txtLegendPosition.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtFillColour_Leave(sender As Object, e As EventArgs) Handles txtRainFillColour.Leave, txtDryFillColor.Leave, txtMissingFillColor.Leave
        ucrBase.clsRsyntax.AddParameter("fill_col", "c(" & Chr(34) & txtDryFillColor.Text.ToString() & Chr(34) & "," & Chr(34) & txtMissingFillColor.Text.ToString() & Chr(34) & "," & Chr(34) & txtRainFillColour.Text.ToString() & Chr(34) & ")") ' fill colour is a 3-tuple "c(col1,col2,col3)"

    End Sub

    Private Sub txtASP_Leave(sender As Object, e As EventArgs) Handles txtASP.Leave
        ucrBase.clsRsyntax.AddParameter("asp", Chr(34) & txtASP.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtlog_Leave(sender As Object, e As EventArgs) Handles txtlog.Leave
        ucrBase.clsRsyntax.AddParameter("log", Chr(34) & txtlog.Text.ToString() & Chr(34))
    End Sub

    Private Sub nudYlim_Leave(sender As Object, e As EventArgs) Handles nudYlim.Leave
        ucrBase.clsRsyntax.AddParameter("ylim", nudYlim.Value.ToString()) ' ylim is a 2-tuple"c(t1,t2)
    End Sub

    Private Sub nudPlotCharacter_Leave(sender As Object, e As EventArgs) Handles nudPlotCharacter.Leave
        ucrBase.clsRsyntax.AddParameter("pch", nudPlotCharacter.Value.ToString())
    End Sub

    Private Sub nudThreshold_Leave(sender As Object, e As EventArgs) Handles nudThreshold.Leave
        ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value.ToString())

    End Sub

    Private Sub chkHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontal.CheckedChanged
        If chkHorizontal.Checked Then
            ucrBase.clsRsyntax.AddParameter("horiz", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("horiz", "FALSE")
        End If

    End Sub
    Private Sub chkStationName_CheckedChanged(sender As Object, e As EventArgs) Handles chkStationName.CheckedChanged
        If chkStationName.Checked Then
            ucrBase.clsRsyntax.AddParameter("station_name", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("station_name", "FALSE")
        End If
    End Sub
End Class