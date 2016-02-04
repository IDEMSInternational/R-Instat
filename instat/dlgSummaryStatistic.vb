
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
Public Class dlgSummaryStatistic
    Private Sub dlgSummaryStatistic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$summary_statistic")
        ucrBase.clsRsyntax.iCallType = 1

    End Sub

    Private Sub txtInterestedVariable_Leave(sender As Object, e As EventArgs) Handles txtInterestedVariable.Leave
        ucrBase.clsRsyntax.AddParameter("interested_var", Chr(34) & txtInterestedVariable.Text & Chr(34))

    End Sub

    Private Sub txtPeriodLabel_Leave(sender As Object, e As EventArgs) Handles txtPeriodLabel.Leave
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & txtPeriodLabel.Text & Chr(34))

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave

    End Sub

    Private Sub nudDigits_Leave(sender As Object, e As EventArgs) Handles nudDigits.Leave
        ucrBase.clsRsyntax.AddParameter("digits", nudDigits.Value.ToString())

    End Sub

    Private Sub chkPercents_Leave(sender As Object, e As EventArgs) Handles chkPercents.Leave
        If chkPercents.Checked Then
            ucrBase.clsRsyntax.AddParameter(" percents", chkPercents.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkStatistics_Leave(sender As Object, e As EventArgs) Handles chkStatistics.Leave
        If chkStatistics.Checked Then
            ucrBase.clsRsyntax.AddParameter(" statistics", chkStatistics.Checked.ToString().ToUpper)
        End If

    End Sub

    Private Sub chkCounts_Leave(sender As Object, e As EventArgs) Handles chkCounts.Leave
        If chkCounts.Checked Then
            ucrBase.clsRsyntax.AddParameter(" counts", chkCounts.Checked.ToString().ToUpper)
        End If

    End Sub

    Private Sub chkAppend_Leave(sender As Object, e As EventArgs) Handles chkAppend.Leave
        If chkAppend.Checked Then
            ucrBase.clsRsyntax.AddParameter(" append", chkAppend.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkConvert_Leave(sender As Object, e As EventArgs) Handles chkConvert.Leave
        If chkConvert.Checked Then
            ucrBase.clsRsyntax.AddParameter("convert", chkAppend.Checked.ToString().ToUpper())
        End If
    End Sub

    Private Sub chkRemoveNA_Leave(sender As Object, e As EventArgs) Handles chkRemoveNA.Leave
        If chkRemoveNA.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.rm", chkRemoveNA.Checked.ToString().ToUpper())
        End If
    End Sub
End Class