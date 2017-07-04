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
Public Class dlgYearRaincount
    Private Sub dlgYearRaincount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$plot_yearly_rain_count")

    End Sub

    Private Sub chkGrid_CheckedChanged(sender As Object, e As EventArgs) Handles chkGrid.CheckedChanged
        If chkGrid.Checked Then
            ucrBase.clsRsyntax.AddParameter("grid", chkGrid.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkPlotWindow_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlotWindow.CheckedChanged
        If chkPlotWindow.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot_window", chkPlotWindow.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkRemoveNA_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveNA.CheckedChanged
        If chkRemoveNA.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.rm", chkRemoveNA.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub nudPlotCharacter_Leave(sender As Object, e As EventArgs) Handles nudPlotCharacter.Leave
        ucrBase.clsRsyntax.AddParameter("pch", nudPlotCharacter.Value.ToString())
    End Sub

    Private Sub nudYLimits_Leave(sender As Object, e As EventArgs) Handles nudYLimits.Leave
        ucrBase.clsRsyntax.AddParameter("ylim", nudYLimits.Value.ToString())
    End Sub

    Private Sub nudYGrid_Leave(sender As Object, e As EventArgs) Handles nudYGrid.Leave
        ucrBase.clsRsyntax.AddParameter("ygrid", nudYGrid.Value.ToString())
    End Sub

    Private Sub nudLineType_Leave(sender As Object, e As EventArgs) Handles nudLineType.Leave
        ucrBase.clsRsyntax.AddParameter("lty", nudLineType.Value.ToString())
    End Sub

    Private Sub nudLineWidth2_Leave(sender As Object, e As EventArgs) Handles nudLineWidth2.Leave
        ucrBase.clsRsyntax.AddParameter("lwd2", nudLineWidth2.Value.ToString())
    End Sub

    Private Sub nudLineWidth1_Leave(sender As Object, e As EventArgs) Handles nudLineWidth1.Leave
        ucrBase.clsRsyntax.AddParameter("lwd", nudLineWidth1.Value.ToString())
    End Sub

    Private Sub txtColour1_Leave(sender As Object, e As EventArgs) Handles txtColour1.Leave
        ucrBase.clsRsyntax.AddParameter("col1", Chr(34) & txtColour1.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtColour2_Leave(sender As Object, e As EventArgs) Handles txtColour2.Leave
        ucrBase.clsRsyntax.AddParameter("col2", Chr(34) & txtColour2.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtType_Leave(sender As Object, e As EventArgs) Handles txtType.Leave
        ucrBase.clsRsyntax.AddParameter("type", Chr(34) & txtVariable.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtVariableLabel_Leave(sender As Object, e As EventArgs) Handles txtVariableLabel.Leave
        ucrBase.clsRsyntax.AddParameter("var_label", Chr(34) & txtVariableLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & txtTitle.Text.ToString() & Chr(34))
    End Sub
End Class