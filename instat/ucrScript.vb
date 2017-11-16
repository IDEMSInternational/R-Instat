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


Public Class ucrScript

    Public clsRLInk As New RLink

    Public Sub CopyText()
        txtScript.Copy()
    End Sub

    Public Sub SelectAllText()
        txtScript.SelectAll()
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        Dim dlgResponse As DialogResult
        If txtScript.Text <> "" Then
            dlgResponse = MessageBox.Show("Are you sure you want to clear the " & Me.Text, "Clear " & Me.Text, MessageBoxButtons.YesNo)
            If dlgResponse = DialogResult.Yes Then
                txtScript.Clear()
            End If
        End If
    End Sub

    Public Sub AppendText(strText As String)
        txtScript.Text = txtScript.Text & Environment.NewLine & strText
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Sub mnuRunWholeScript_Click(sender As Object, e As EventArgs) Handles mnuRunWholeScript.Click

        Dim strScript As String
        strScript = txtScript.Text
        clsRLInk.bOutput = True

        For Each strLine As String In strScript.Split(Environment.NewLine)
            strLine = strLine.Replace(vbLf, String.Empty)
            strLine = strLine.Replace(vbCrLf, String.Empty)
            clsRLInk.RunScript(strScript:=strLine, iCallType:=0, strComment:="Code run from Script window", bSeparateThread:=False, bSilent:=True)
        Next
    End Sub

End Class
