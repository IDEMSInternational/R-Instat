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
    Public lstOfStrings As New List(Of String)
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpSequence2.Hide()
        grpRepeatSingle.Hide()
    End Sub

    Private Sub UcrButtons1_ClickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        UcrButtons1.clsRsyntax.GetScript()
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

    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs)
        UcrButtons1.clsRsyntax.SetFunction("seq")
    End Sub

    Private Sub txtFrom_Validating(sender As Object, e As EventArgs) Handles txtFrom.Validating
        If IsNumeric(txtFrom.Text) Then
            UcrButtons1.clsRsyntax.AddParameter("from", txtFrom.Text)
        Else
            MsgBox("Please Enter a number!", vbCritical, "Message for Instat+")
            txtFrom.Focus()
        End If
    End Sub

    Private Sub txtTo_Validating(sender As Object, e As EventArgs) Handles txtTo.Validating
        If IsNumeric(txtTo.Text) Then
            UcrButtons1.clsRsyntax.AddParameter("to", txtFrom.Text)
        Else
            MsgBox("Please Enter a number!", vbCritical, "Message for Instat+")
            txtTo.Focus()
        End If
    End Sub

    Private Sub txtSteps_Validating(sender As Object, e As EventArgs) Handles txtSteps.Validating
        If IsNumeric(txtSteps.Text) Then
            UcrButtons1.clsRsyntax.AddParameter("by", txtFrom.Text)
        Else
            MsgBox("Please Enter a number!", vbCritical, "Message for Instat+")
            txtSteps.Focus()
        End If
    End Sub
End Class