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
Imports System.IO
Public Class ucrLog
    Public clsInstatOptions As InstatOptions
    Public Sub CopyText()
        txtLog.Copy()
    End Sub

    Public Sub SelectAllText()
        txtLog.SelectAll()
    End Sub

    Private Sub mnuOpenLogFile_Click(sender As Object, e As EventArgs) Handles mnuOpenLogFile.Click
        clsInstatOptions = New InstatOptions
        Dim clsProcessStart As New RFunction
        Dim strLogFilename As String = "RInstatLog.R"
        Dim strWD As String = clsInstatOptions.strWorkingDirectory

        Try
            File.WriteAllText(Path.Combine(strWD, strLogFilename), txtLog.Text)
            Process.Start(Path.Combine(strWD, strLogFilename))
        Catch
            MsgBox("Could not save the log file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        txtLog.SelectAll()
        txtLog.Copy()
    End Sub
End Class
