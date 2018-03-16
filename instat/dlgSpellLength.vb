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

Public Class dlgSpellLengths
    Private Sub dlgSpellLengths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$spell_lengths")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub nudThreshold_Leave(sender As Object, e As EventArgs) Handles nudThreshold.Leave
        ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value.ToString())
    End Sub

    Private Sub chkPrintTable_Leave(sender As Object, e As EventArgs) Handles chkPrintTable.Leave
        If chkPrintTable.Checked Then
            ucrBase.clsRsyntax.AddParameter("print_table", chkPrintTable.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkMonthAbbreviations_Leave(sender As Object, e As EventArgs) Handles chkMonthAbbreviations.Leave
        If chkMonthAbbreviations.Checked Then
            ucrBase.clsRsyntax.AddParameter("month_list", chkMonthAbbreviations.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkSeparate_Leave(sender As Object, e As EventArgs) Handles chkSeparate.Leave
        If chkSeparate.Checked Then
            ucrBase.clsRsyntax.AddParameter("separate", chkSeparate.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkRemoveNA_Leave(sender As Object, e As EventArgs) Handles chkRemoveNA.Leave
        If chkRemoveNA.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.rm", chkRemoveNA.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub txtDOYearList_Leave(sender As Object, e As EventArgs) Handles txtDOYearList.Leave
        ucrBase.clsRsyntax.AddParameter("doy_m", Chr(34) & txtDOYearList.Text & Chr(34))
        'this variable doy_m is a class list, however its a vector of the form c(m,n).
    End Sub

    Private Sub txtListYears_Leave(sender As Object, e As EventArgs) Handles txtListYears.Leave
        ucrBase.clsRsyntax.AddParameter("years", Chr(34) & txtListYears.Text & Chr(34))
        'this variable doy_m is a class list, however its a vector of the form c(m,n).

    End Sub

End Class