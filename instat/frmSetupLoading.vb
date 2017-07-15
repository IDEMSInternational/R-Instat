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

Public Class frmSetupLoading
    Private strHyperlink As String = ""

    Private Sub frmSetupLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Eventually have multiple messages and rotate what is shown each time
        lblMessage.Text = "Did you know that R-Instat was developed in Africa by African Maths Initiative (AMI)?" & Environment.NewLine & "Click here to find out more about AMI and the partners who helped make R-Instat a success."

        'Optional hyperlink when clicking on the message
        strHyperlink = "http://africandata.org"
        lblMessage.Cursor = Cursors.Hand
    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click
        If strHyperlink <> "" Then
            Try
                Process.Start(strHyperlink)
            Catch ex As Exception
                MsgBox("Sorry, we couldn't open this link (" & strHyperlink & ")" & Environment.NewLine & ex.Message, "Cannot open link")
            End Try
        End If
    End Sub
End Class