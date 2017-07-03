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
Public Class ucrLog
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
End Class
