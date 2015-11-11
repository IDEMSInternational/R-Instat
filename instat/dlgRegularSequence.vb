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
Public Class dlgRegularSequence
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpSequence2.Hide()
        grpRepeatSingle.Hide()
        UcrBase.clsRsyntax.SetFunction("seq")
        UcrBase.clsRsyntax.iCallType = 2
        autoTranslate(Me)
    End Sub

    Private Sub rdSIngleValue_Click(sender As Object, e As EventArgs) Handles rdSIngleValue.Click
        grpSequence.Hide()
        grpSequence2.Hide()
        grpRepeatSingle.Visible = True
    End Sub

    Private Sub rdDates_Click(sender As Object, e As EventArgs) Handles rdDates.Click
        grpSequence.Hide()
        grpRepeatSingle.Hide()
        grpSequence2.Visible = True
    End Sub

    Private Sub rdSequence_Click(sender As Object, e As EventArgs) Handles rdSequence.Click
        grpRepeatSingle.Hide()
        grpSequence2.Hide()
        grpSequence.Visible = True
    End Sub

    Private Sub txtFrom_Leave(sender As Object, e As EventArgs) Handles txtFrom.Leave
        UcrBase.clsRsyntax.AddParameter("from", txtFrom.Text)
    End Sub

    Private Sub txtTo_TextChanged(sender As Object, e As EventArgs) Handles txtTo.TextChanged
        UcrBase.clsRsyntax.AddParameter("to", txtTo.Text)
    End Sub

    Private Sub txtSteps_TextChanged(sender As Object, e As EventArgs) Handles txtSteps.TextChanged
        UcrBase.clsRsyntax.AddParameter("by", txtSteps.Text)
    End Sub

    Private Sub datePicker1_ValueChanged(sender As Object, e As EventArgs) Handles datePicker1.ValueChanged
        UcrBase.clsRsyntax.AddParameter("from", Format(datePicker1.Value, "yyyy/MM/dd"))
    End Sub

    Private Sub datePicker2_ValueChanged(sender As Object, e As EventArgs) Handles datePicker2.ValueChanged
        UcrBase.clsRsyntax.AddParameter("to", Format(datePicker2.Value, "yyyy/MM/dd"))
    End Sub

    Private Sub cboBy_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboBy.SelectedIndexChanged
        UcrBase.clsRsyntax.AddParameter("by", cboBy.SelectedItem.ToString())
    End Sub

    Private Sub txtValue_TextChanged(sender As Object, e As EventArgs) Handles txtValue.TextChanged
        UcrBase.clsRsyntax.AddParameter("from", Format(datePicker2.Value, "yyyy/MM/dd"))
    End Sub

    Private Sub txtRepeatTimes_TextChanged(sender As Object, e As EventArgs) Handles txtRepeatTimes.TextChanged
        UcrBase.clsRsyntax.AddParameter("length.out", txtRepeatTimes.Text)
    End Sub
End Class