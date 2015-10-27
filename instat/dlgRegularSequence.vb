' CLIMSOFT - Stats System
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
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpSequence2.Hide()
        grpRepeatSingle.Hide()
    End Sub

    Private Sub UcrButtons1_ClickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        Dim inputStrings() As String
        Dim lstOfStrings As New List(Of String)
        Dim strScript As String
        If rdSequence.Checked = True Then
            inputStrings = {txtFrom.Text, txtTo.Text, txtSteps.Text}
            lstOfStrings = New List(Of String)(inputStrings)
            frmMain.clsRSyntax.manage(lstOfStrings, "Data", "Regular Sequence", "regular")
        ElseIf rdSIngleValue.Checked = True
            strScript = "seq(from = " & Convert.ToInt32(txtValue.Text) & ", to = " & Convert.ToInt32(txtValue.Text) & ", length.out = " & Convert.ToInt32(txtRepeatTimes.Text) & ")"
            frmMain.clsRInterface.RunScript(strScript)
        ElseIf rdDates.Checked = True
            strScript = "capture.output(seq(from = as.Date('" & Format(datePicker1.Value, "yyyy/MM/dd") & "'), to = as.Date('" & Format(datePicker2.Value, "yyyy/MM/dd") & "'), by = '" & cboBy.SelectedItem.ToString() & "'))"
            frmMain.clsRInterface.RunScript(strScript)
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
End Class