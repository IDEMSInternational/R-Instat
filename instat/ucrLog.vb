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

Public Class ucrLog
    Public Sub CopyText()
        txtLog.Copy()
    End Sub

    Public Sub SelectAllText()
        txtLog.SelectAll()
    End Sub

    Private Sub mnuOpenLogFile_Click(sender As Object, e As EventArgs) Handles mnuOpenLogFile.Click
        Dim clsProcessStart As New RFunction
        Dim strLogFilename As String = ""
        Dim dlgOpenLogFile As New OpenFileDialog
        clsProcessStart.SetRCommand("Process.Start")
        dlgOpenLogFile.Filter = "All R files|*.R;|All files|*.*;"
        dlgOpenLogFile.Title = "load Log File"
        dlgOpenLogFile.Title = "load Log from file"
        If dlgOpenLogFile.ShowDialog() = DialogResult.OK Then
            If dlgOpenLogFile.FileName <> "" Then
                strLogFilename = dlgOpenLogFile.FileName
            End If
        End If
        clsProcessStart.AddParameter("filename", strLogFilename, bIncludeArgumentName:=False)
        frmMain.clsRLink.RunScript(clsProcessStart.ToScript, strComment:="Loading Script")
    End Sub
End Class
