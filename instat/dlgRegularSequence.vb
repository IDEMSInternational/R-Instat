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
Public Class dlgRegularSequence
    Public clsRSyntax As New RSyntax
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpSequence2.Hide()
        grpRepeatSingle.Hide()
    End Sub

    Private Sub UcrButtons1_ClickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim lstOfStrings
        If rdSequence.Checked = True Then
            lstOfStrings = New List(Of String)({txtFrom.Text, txtTo.Text, txtSteps.Text})
            clsRSyntax.manage(lstOfStrings, "regular")
        ElseIf rdSIngleValue.Checked = True
            lstOfStrings = New List(Of String)({txtValue.Text, txtRepeatTimes.Text})
            clsRSyntax.manage(lstOfStrings, "repeated")
        ElseIf rdDates.Checked = True
            lstOfStrings = New List(Of Object)({datePicker1.Value, datePicker2.Value, cboBy.SelectedItem.ToString()})
            clsRSyntax.manage(lstOfStrings, "date")
        End If
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

    'Private Sub txtColName_Validating(sender As Object, e As EventArgs) Handles txtColName.Validating
    '    If txtColName.Text = String.Empty Then
    '        'UcrButtons1.Enabled = False
    '        errorProvider.SetError(txtColName, "Please Enter the name for the column")
    '    End If
    'End Sub
    'Private Sub txtColName_Validated(sender As Object, e As EventArgs) Handles txtColName.Validated
    '    UcrButtons1.Enabled = True
    'End Sub

    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles UcrButtons1.Load

    End Sub
End Class