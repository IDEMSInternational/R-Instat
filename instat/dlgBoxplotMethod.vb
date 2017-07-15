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
Public Class dlgBoxplotMethod
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$boxplot_method")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub chkConvert_CheckedChanged(sender As Object, e As EventArgs) Handles chkConvert.CheckedChanged
        If chkConvert.Checked Then
            ucrBase.clsRsyntax.AddParameter("convert", chkConvert.Checked.ToString().ToUpper())
        End If
    End Sub
    Private Sub chkHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontal.CheckedChanged
        If chkHorizontal.Checked Then
            ucrBase.clsRsyntax.AddParameter("horizontal", chkHorizontal.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub txtDataPeriodLabel_Leave(sender As Object, e As EventArgs) Handles txtDataPeriodLabel.Leave
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & txtDataPeriodLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtInterestedVariable_Leave(sender As Object, e As EventArgs) Handles txtInterestedVariable.Leave
        ucrBase.clsRsyntax.AddParameter("interested_var", Chr(34) & txtInterestedVariable.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtFactor_Leave(sender As Object, e As EventArgs) Handles txtFactor.Leave
        ucrBase.clsRsyntax.AddParameter("factor", Chr(34) & txtFactor.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlabel", Chr(34) & txtXLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylabel", Chr(34) & txtYLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtFillColour_Leave(sender As Object, e As EventArgs) Handles txtFillColour.Leave
        ucrBase.clsRsyntax.AddParameter("fill_col", Chr(34) & txtFillColour.Text.ToString() & Chr(34))
    End Sub

    Private Sub nudWhisklty_Leave(sender As Object, e As EventArgs) Handles nudWhisklty.Leave
        ucrBase.clsRsyntax.AddParameter("whisklty", nudWhisklty.Value.ToString())
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & txtTitle.Text.ToString() & Chr(34))
    End Sub
End Class