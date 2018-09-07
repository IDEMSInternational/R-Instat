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
    Private strClearedText As String = "" 'stores cleared text for undoing

    Public Sub CopyText()
        txtScript.Copy()
    End Sub

    Public Sub CutText()
        txtScript.Cut()
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
        strClearedText = ""
    End Sub

    Private Sub mnuClearContents_Click(sender As Object, e As EventArgs) Handles mnuClearContents.Click
        Dim dlgResponse As DialogResult
        If txtScript.Text <> "" Then
            dlgResponse = MessageBox.Show("Are you sure you want to clear the contents of the script window?" & Me.Text, "Clear " & Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dlgResponse = DialogResult.Yes Then
                strClearedText = txtScript.Text
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

    Private Sub mnuRunCurrentLine_Click(sender As Object, e As EventArgs) Handles mnuRunCurrentLine.Click
        If txtScript.TextLength > 0 Then
            Dim lineNum As Integer = txtScript.GetLineFromCharIndex(txtScript.GetFirstCharIndexOfCurrentLine())
            If lineNum < txtScript.Lines.Length Then
                RunText(txtScript.Lines(lineNum))
                If lineNum < txtScript.Lines.Length - 1 Then
                    txtScript.SelectionStart = txtScript.GetFirstCharIndexFromLine(lineNum + 1)
                End If
            End If
        End If
    End Sub

    Private Sub RunText(strText As String)
        If strText <> "" Then
            frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strText, strNewComment:=strComment)
        End If
    End Sub

    Private Sub mnuOpenScript_Click(sender As Object, e As EventArgs) Handles mnuOpenScriptasFile.Click
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
            MessageBox.Show("Could not save the script file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", "Open Script", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub mnuSaveScript_Click(sender As Object, e As EventArgs) Handles mnuSaveScript.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Script To File"
            dlgSave.Filter = "R Script File (*.R)|*.R|Text File (*.txt)|*.txt"

            dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory

            If dlgSave.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSave.FileName, txtScript.Text)
                Catch
                    MessageBox.Show("Could not save the script file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", "Save Script", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        End Using
    End Sub

    Private Sub mnuLoadScriptFromFile_Click(sender As Object, e As EventArgs) Handles mnuLoadScriptFromFile.Click

        Dim msgWarning As DialogResult

        Using dlgLoad As New OpenFileDialog
            dlgLoad.Title = "Load Script From Text File"
            dlgLoad.Filter = "Text & R Script Files(*.txt,*.R)|*.txt;*.R|R Script File (*.R)|*.R|Text File (*.txt)|*.txt"
            dlgLoad.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory

            If dlgLoad.ShowDialog() = DialogResult.OK Then
                msgWarning = MessageBox.Show("Loading a script from file will clear your current script" & Environment.NewLine & "Do you still want to load?", "Load Script From File", MessageBoxButtons.YesNo)
                If msgWarning = DialogResult.Yes Then
                    Try
                        txtScript.Text = File.ReadAllText(dlgLoad.FileName)
                    Catch
                        MessageBox.Show("Could not load the script from file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", "Load Script", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End Using
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        CopyText()
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        CutText()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        If Clipboard.ContainsData(DataFormats.Text) Then
            txtScript.Paste()
        Else
            MessageBox.Show("You can only paste text data on the script window", "Paste to Script Window", MessageBoxButtons.OK)
        End If
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
        mnuHelp.Enabled = False 'TODO. Remove this after help is developed
        mnuRunCurrentLine.ShortcutKeys = Keys.Enter Or Keys.Control
        txtScript.WordWrap = False
        EnableCopyCut()
        EnableMenusWhenScriptNotEmpty()
    End Sub

    Private Sub txtScript_MouseUp(sender As Object, e As EventArgs) Handles txtScript.MouseUp, txtScript.KeyUp
        EnableCopyCut()
    End Sub

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged
        EnableMenusWhenScriptNotEmpty()
    End Sub

    Private Sub EnableMenusWhenScriptNotEmpty()
        If txtScript.Text <> "" Then
            cmdRun.Enabled = True
            mnuOpenScriptasFile.Enabled = True
            mnuClearContents.Enabled = True
            mnuSaveScript.Enabled = True
            mnuRunCurrentLine.Enabled = True
            mnuRunAllText.Enabled = True
        Else
            cmdRun.Enabled = False
            mnuOpenScriptasFile.Enabled = False
            mnuClearContents.Enabled = False
            mnuSaveScript.Enabled = False
            mnuRunCurrentLine.Enabled = False
            mnuRunAllText.Enabled = False
        End If
    End Sub

    Private Sub Menu_Undo(sender As Object, e As EventArgs) Handles mnuUndo.Click
        'Determine if last operation can be undone in text box.   
        If txtScript.CanUndo Then
            'Undo the last operation.
            txtScript.Undo()
            'Clear the undo buffer to prevent last action from being redone.
            txtScript.ClearUndo()
        ElseIf strClearedText <> "" Then
            txtScript.Text = strClearedText
            strClearedText = ""
        End If
    End Sub

    Private Sub mnuRunAllText_Click(sender As Object, e As EventArgs) Handles mnuRunAllText.Click
        RunText(txtScript.Text)
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        'TODO
    End Sub
End Class
