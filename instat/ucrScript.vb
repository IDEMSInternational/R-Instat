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
    Private strCurrentDirectory As String = ""
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

    Private Sub mnuClearContents_Click(sender As Object, e As EventArgs) Handles mnuClearContents.Click
        Dim dlgResponse As DialogResult
        If txtScript.Text <> "" Then
            dlgResponse = MessageBox.Show("Are you sure you want to clear the contents of the script window?" & Me.Text, "Clear " & Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgResponse = DialogResult.Yes Then
                txtScript.Clear()
            End If
        End If
    End Sub

    Private Sub mnuRunSelectedText_Click(sender As Object, e As EventArgs) Handles mnuRunSelectedText.Click
        If txtScript.SelectionLength > 0 AndAlso txtScript.SelectedText <> "" Then
            RunText(txtScript.SelectedText)
        Else
            MessageBox.Show("You need to select some text before running" & Me.Text, "No text selected" & Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub RunText(strText As String)
        If strText <> "" Then
            If MsgBox("Running code from the script window is not yet a stable operation." & vbNewLine & vbNewLine & "Do you want to proceed?", MessageBoxButtons.YesNo, "Warning") = MsgBoxResult.Yes Then
                frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strText, strNewComment:=strComment)
            End If
        End If
    End Sub

    Private Sub mnuOpenScript_Click(sender As Object, e As EventArgs) Handles mnuOpenScript.Click
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

    Private Sub mnuSaveScript_Click(sender As Object, e As EventArgs) Handles mnuSaveScript.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Script To File"
            dlgSave.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"

            dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory

            If dlgSave.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSave.FileName, txtScript.Text)
                Catch
                    MsgBox("Could not save the script file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                End Try

            End If
        End Using
    End Sub

    Private Sub mnuOpenScriptFromFile_Click(sender As Object, e As EventArgs) Handles mnuOpenScriptFromFile.Click

        Dim msgWarning As DialogResult

        Using dlgOpen As New OpenFileDialog
            dlgOpen.Title = "Open Script From Text File"
            dlgOpen.Filter = "Text File (*.txt)|*.txt|R Script File (*.R)|*.R"
            dlgOpen.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory

            If dlgOpen.ShowDialog() = DialogResult.OK Then
                msgWarning = MessageBox.Show("Opening a script from file will clear your current script" & Environment.NewLine & "Do you want still want to open?", "Open Script From File", MessageBoxButtons.YesNo)
                If msgWarning = DialogResult.Yes Then
                    Try
                        txtScript.Text = File.ReadAllText(dlgOpen.FileName)
                    Catch
                        MsgBox("Could not open the script from file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", MsgBoxStyle.Critical)
                    End Try
                End If
            End If
        End Using
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        Clipboard.SetText(txtScript.Text)
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        Clipboard.Clear()
        Clipboard.SetText(txtScript.Text)
        txtScript.Text = ""
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        txtScript.Text = Clipboard.GetText()
    End Sub

    Private Sub EnableCopyCut()
        If txtScript.SelectionLength > 0 Then
            mnuCopy.Enabled = True
            mnuCut.Enabled = True
            mnuRunSelectedText.Enabled = True
        Else
            mnuCopy.Enabled = False
            mnuCut.Enabled = False
            mnuRunSelectedText.Enabled = False
        End If
    End Sub

    Private Sub ucrScript_Load(sender As Object, e As EventArgs) Handles Me.Load
        EnableCopyCut()
    End Sub

    Private Sub txtScript_MouseUp(sender As Object, e As EventArgs) Handles txtScript.MouseUp, txtScript.KeyUp
        EnableCopyCut()
    End Sub
End Class
