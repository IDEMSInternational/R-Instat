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
Public Class dlgSeasonalSummaryRain

    Private Sub dlgSeasonalSummaryRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$seasonal_summary.rain()")
        ucrBase.clsRsyntax.iCallType = 1
    End Sub

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
    End Sub

    Private Sub txtTotal_Leave(sender As Object, e As EventArgs) Handles txtTotal.Leave
        ucrBase.clsRsyntax.AddParameter("summary_col_names", Chr(34) & txtTotal.Text & Chr(34))
    End Sub

    Private Sub txtCount_Leave(sender As Object, e As EventArgs) Handles txtCount.Leave
        ucrBase.clsRsyntax.AddParameter("summary_col_names", Chr(34) & txtCount.Text & Chr(34))

    End Sub

    Private Sub txtMean_Leave(sender As Object, e As EventArgs) Handles txtMean.Leave
        ucrBase.clsRsyntax.AddParameter("summary_col_names", Chr(34) & txtMean.Text & Chr(34))

    End Sub

    Private Sub nudStartMonth_leave(sender As Object, e As EventArgs) Handles nudStartMonth.Leave

        ucrBase.clsRsyntax.AddParameter("month_start", nudStartMonth.Value)

    End Sub

    Private Sub nudNosofMonth_Leave(sender As Object, e As EventArgs) Handles nudNosofMonth.Leave
        ucrBase.clsRsyntax.AddParameter("number_month", nudNosofMonth.Value)

    End Sub

    Private Sub nudThreshold_ValueChanged(sender As Object, e As EventArgs) Handles nudThreshold.Leave
        ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value)

    End Sub

    Private Sub txtLongDrySpellName_Leave(sender As Object, e As EventArgs) Handles txtLongDrySpellName.Leave
        ucrBase.clsRsyntax.AddParameter("longest_dry_spell_name", Chr(34) & txtLongDrySpellName.Text & Chr(34))

    End Sub

    Private Sub txtSpellLengthName_Leave(sender As Object, e As EventArgs) Handles txtSpellLengthName.Leave
        ucrBase.clsRsyntax.AddParameter("spell_length_name", Chr(34) & txtSpellLengthName.Text & Chr(34))
    End Sub

    Private Sub chkCountLabel_Leave(sender As Object, e As EventArgs) Handles chkCountLabel.Leave
        If chkCountLabel.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", chkCountLabel.Checked.ToString().ToUpper())
        End If


    End Sub

    Private Sub chkSumLabel_Leave(sender As Object, e As EventArgs) Handles chkSumLabel.Leave
        If chkSumLabel.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", chkSumLabel.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkMean_Leave(sender As Object, e As EventArgs) Handles chkMean.CheckedChanged
        If chkCountLabel.Checked Then
            ucrBase.clsRsyntax.AddParameter("summaries", chkMean.Checked.ToString().ToUpper())
        End If
    End Sub
End Class