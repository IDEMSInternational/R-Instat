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
Imports RDotNet
Imports instat
Imports System.ComponentModel

Public Class ucrLog
    Private strComment As String = "Code run from Log Window"
    Public strRInstatLogFilesFolderPath As String = Path.Combine(Path.GetFullPath(FileIO.SpecialDirectories.MyDocuments), "R-Instat_Log_files")
    Public Sub CopyText()
        txtLog.Copy()
    End Sub
    Public Sub SelectAllText()
        txtLog.SelectAll()
    End Sub

    Private Sub mnuOpenLogFile_Click(sender As Object, e As EventArgs) Handles mnuOpenLogFile.Click
        Dim clsProcessStart As New RFunction
        Dim strLogFilename As String = ""
        Dim i As Integer

        Try
            If Not Directory.Exists(strRInstatLogFilesFolderPath) Then
                Directory.CreateDirectory(strRInstatLogFilesFolderPath)
            End If
            strLogFilename = "RInstatLog.R"

            While File.Exists(Path.Combine(strRInstatLogFilesFolderPath, strLogFilename))
                i = i + 1
                strLogFilename = "RInstatLog" & i & ".R"
            End While
            File.WriteAllText(Path.Combine(strRInstatLogFilesFolderPath, strLogFilename), txtLog.Text)
            Process.Start(Path.Combine(strRInstatLogFilesFolderPath, strLogFilename))
        Catch
            MsgBox("Could not save the log file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
            End
        End Try
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        If txtLog.SelectionLength = 0 Then
            txtLog.SelectAll()
        End If
        txtLog.Copy()
    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged
        txtLog.SelectionStart = txtLog.Text.Length
        txtLog.ScrollToCaret()
        txtLog.Refresh()
    End Sub

    Private Sub mnuRunSelectedText_Click(sender As Object, e As EventArgs) Handles mnuRunSelectedText.Click
        If txtLog.SelectedText <> "" AndAlso txtLog.SelectionLength > 0 Then
            Dim strSelectedScript As String = txtLog.SelectedText
            If MsgBox("Running selected code from the log window is not yet a stable operation e.g. if a selection is incomplete or if the data has changed." & vbNewLine & vbNewLine & "Do you want to proceed?", MessageBoxButtons.YesNo, "Warning") = MsgBoxResult.Yes Then
                frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strSelectedScript, strNewComment:=strComment)
            End If
        End If
    End Sub

    Private Sub mnuContextLogFile_Opening(sender As Object, e As CancelEventArgs) Handles mnuContextLogFile.Opening
        mnuRunSelectedText.Enabled = (txtLog.SelectedText <> "" AndAlso txtLog.SelectionLength > 0)
    End Sub
End Class
