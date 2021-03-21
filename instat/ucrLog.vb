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
Imports System.ComponentModel

Public Class ucrLog
    Private strComment As String = "Code run from Log Window"
    Public strRInstatLogFilesFolderPath As String = Path.Combine(Path.GetFullPath(FileIO.SpecialDirectories.MyDocuments), "R-Instat_Log_files")
    Private bRunCurrentLine As Boolean = False

    Public Sub CopyText()
        txtLog.Copy()
    End Sub

    Public Sub SelectAllText()
        txtLog.SelectAll()
    End Sub

    Private Sub mnuOpenLogFile_Click(sender As Object, e As EventArgs) Handles mnuOpenLogFile.Click
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
            MessageBox.Show("Could not save the log file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", "Save Log File", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        If txtLog.SelectionLength = 0 Then
            SelectAllText()
        End If
        CopyText()
    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged
        If Not bRunCurrentLine Then
            txtLog.SelectionStart = txtLog.Text.Length
            txtLog.ScrollToCaret()
            txtLog.Refresh()
        End If
    End Sub

    Private Sub mnuRunCurrentLine_Click(sender As Object, e As EventArgs) Handles mnuRunCurrentLine.Click
        If txtLog.TextLength > 0 Then
            Dim lineNum As Integer = txtLog.GetLineFromCharIndex(txtLog.GetFirstCharIndexOfCurrentLine())
            If lineNum < txtLog.Lines.Length Then
                bRunCurrentLine = True
                RunText(txtLog.Lines(lineNum))
                If lineNum < txtLog.Lines.Length - 1 Then
                    txtLog.SelectionStart = txtLog.GetFirstCharIndexFromLine(lineNum + 1)
                    txtLog.ScrollToCaret()
                End If
                bRunCurrentLine = False
            End If
        End If
    End Sub

    Private Sub mnuContextLogFile_Opening(sender As Object, e As CancelEventArgs) Handles mnuContextLogFile.Opening
        mnuRunCurrentLine.Enabled = (txtLog.TextLength > 0)
        mnuRunAll.Enabled = (txtLog.TextLength > 0)
        mnuRunSelectedText.Enabled = (txtLog.SelectionLength > 0)
    End Sub

    Private Sub mnuRunSelectedText_Click(sender As Object, e As EventArgs) Handles mnuRunSelectedText.Click
        If txtLog.SelectionLength > 0 Then
            RunText(txtLog.SelectedText)
        End If
    End Sub

    Private Sub mnuRunAll_Click(sender As Object, e As EventArgs) Handles mnuRunAll.Click
        If txtLog.TextLength > 0 Then
            RunText(txtLog.Text)
        End If
    End Sub

    Private Sub ucrLog_Load(sender As Object, e As EventArgs) Handles Me.Load
        mnuRunCurrentLine.ShortcutKeys = Keys.Enter Or Keys.Control
        txtLog.WordWrap = False 'For the run current line to work well
    End Sub

    Private Sub RunText(strText As String)
        If strText <> "" Then
            frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strText, strNewComment:=strComment)
        End If
    End Sub

    Private Sub mnuSaveLogFile_Click(sender As Object, e As EventArgs) Handles mnuSaveLogFile.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Log File"
            dlgSave.Filter = "R Script File (*.R)|*.R|Text File (*.txt)|*.txt"
            dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            If dlgSave.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSave.FileName, txtLog.Text)
                Catch
                    MessageBox.Show("Could not save the log file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", "Save Log File", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "541")
    End Sub

End Class
