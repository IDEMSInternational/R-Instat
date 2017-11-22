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

Imports System.IO
Public Class ucrScript
    Private strComment As String = "Code run from Script Window"
    Public strRInstatLogFilesFolderPath As String = Path.Combine(Path.GetFullPath(FileIO.SpecialDirectories.MyDocuments), "R-Instat_Log_files")

    Public Sub CopyText()
        txtScript.Copy()
    End Sub

    Public Sub SelectAllText()
        txtScript.SelectAll()
    End Sub

    Private Sub cmdRun_Click(sender As Object, e As EventArgs) Handles cmdRun.Click
        RunText(txtScript.Text)
    End Sub

    Public Sub AppendText(strText As String)
        txtScript.Text = txtScript.Text & Environment.NewLine & strText
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Sub mnuRunWholeScript_Click(sender As Object, e As EventArgs) Handles mnuClearContents.Click
        Dim dlgResponse As DialogResult
        If txtScript.Text <> "" Then
            dlgResponse = MessageBox.Show("Are you sure you want to clear the " & Me.Text, "Clear " & Me.Text, MessageBoxButtons.YesNo)
            If dlgResponse = DialogResult.Yes Then
                txtScript.Clear()
            End If
        End If
    End Sub

    Private Sub mnuRunSelectedText_Click(sender As Object, e As EventArgs) Handles mnuRunSelectedText.Click
        If txtScript.SelectionLength > 0 AndAlso txtScript.SelectedText <> "" Then
            RunText(txtScript.SelectedText)
        End If
    End Sub

    Private Sub RunText(strText As String)
        If strText <> "" Then
            If MsgBox("Running code from the script window is not yet a stable operation." & vbNewLine & vbNewLine & "Do you want to proceed?", MessageBoxButtons.YesNo, "Warning") = MsgBoxResult.Yes Then
                frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strText, strNewComment:=strComment)
            End If
        End If
    End Sub

    Private Sub cmdOpenScript_Click(sender As Object, e As EventArgs) Handles cmdOpenScript.Click
        Dim clsProcessStart As New RFunction
        Dim strScriptFilename As String = ""
        Dim i As Integer

        Try
            If Not Directory.Exists(strRInstatLogFilesFolderPath) Then
                Directory.CreateDirectory(strRInstatLogFilesFolderPath)
            End If
            strScriptFilename = "RInstatScript.R"

            While File.Exists(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename))
                i = i + 1
                strScriptFilename = "RInstatScript" & i & ".R"
            End While
            File.WriteAllText(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename), frmMain.clsRLink.GetRSetupScript() & txtScript.Text)
            Process.Start(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename))
        Catch
            MsgBox("Could not save the script file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
            End
        End Try
    End Sub
End Class
