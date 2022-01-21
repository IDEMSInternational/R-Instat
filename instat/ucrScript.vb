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
    Private bUserTextChanged As Boolean = False

    Public Sub CopyText()
        txtScript.Copy()
    End Sub

    Public Sub CutText()
        txtScript.Cut()
    End Sub

    Public Sub SelectAllText()
        txtScript.SelectAll()
    End Sub

    Private Sub RunAllText()
        If txtScript.TextLength > 0 Then
            If MsgBox("Are you sure you want to run the entire contents of the script window?", MessageBoxButtons.YesNo, "Run All") = MsgBoxResult.Yes Then
                RunText(txtScript.Text)
            End If
        End If
    End Sub

    Private Sub RunSelectedText()
        If txtScript.SelectionLength > 0 Then
            RunText(txtScript.SelectedText)
        End If
    End Sub

    Private Sub RunCurrentLine()
        Static strScriptCmd As String = "" 'static so that script can be added to with successive calls of this function

        If txtScript.TextLength > 0 Then
            Dim lineNum As Integer = txtScript.GetLineFromCharIndex(txtScript.GetFirstCharIndexOfCurrentLine())
            If lineNum < txtScript.Lines.Length Then
                'add the new text to any unexecuted script remaining from previous calls to this function
                strScriptCmd &= vbCrLf & txtScript.Lines(lineNum) 'insert carriage return to ensure that new text starts on new line
                strScriptCmd = RunText(strScriptCmd)
                If lineNum < txtScript.Lines.Length - 1 Then
                    txtScript.SelectionStart = txtScript.GetFirstCharIndexFromLine(lineNum + 1)
                    txtScript.ScrollToCaret()
                End If
            End If
        End If
    End Sub

    Private Sub ClearContents()
        If txtScript.TextLength > 0 Then
            If MessageBox.Show("Are you sure you want to clear the contents of the script window?" & Me.Text,
                               "Clear " & Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                bUserTextChanged = True
                'This was preferred over txtScript.Clear() , to support undo
                txtScript.Focus()
                txtScript.SelectAll()
                SendKeys.Send("{BACKSPACE}")
            End If
        End If
    End Sub

    Public Sub AppendText(strText As String)
        txtScript.Text = txtScript.Text & Environment.NewLine & strText
        txtScript.SelectionStart = txtScript.Text.Length
        txtScript.ScrollToCaret()
        txtScript.Refresh()
    End Sub

    Private Function RunText(strText As String) As String
        Return If(strText <> "", frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strText, strNewComment:=strComment), "")
    End Function

    Private Sub EnableRunButtons(bEnable As Boolean)
        cmdRunLineSelection.Enabled = bEnable
        cmdRunAll.Enabled = bEnable
    End Sub

    Private Sub RunLineSelection_Click(sender As Object, e As EventArgs) Handles cmdRunLineSelection.Click, mnuRunCurrentLineSelection.Click
        'temporarily disable the buttons incase its a long operation
        EnableRunButtons(False)
        txtScript.Focus()
        If txtScript.SelectionLength > 0 Then
            RunSelectedText()
        Else
            RunCurrentLine()
        End If
        EnableRunButtons(True)
    End Sub

    Private Sub RunAll_Click(sender As Object, e As EventArgs) Handles cmdRunAll.Click, mnuRunAllText.Click
        'temporarily disable the buttons incase its a long operation
        EnableRunButtons(False)
        RunAllText()
        EnableRunButtons(True)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click, mnuClearContents.Click
        ClearContents()
    End Sub

    Private Sub mnuOpenScript_Click(sender As Object, e As EventArgs) Handles mnuOpenScriptasFile.Click
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
        Using dlgLoad As New OpenFileDialog
            dlgLoad.Title = "Load Script From Text File"
            dlgLoad.Filter = "Text & R Script Files (*.txt,*.R)|*.txt;*.R|R Script File (*.R)|*.R|Text File (*.txt)|*.txt"
            dlgLoad.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory

            If dlgLoad.ShowDialog() = DialogResult.OK Then
                If txtScript.TextLength = 0 OrElse MessageBox.Show("Loading a script from file will clear your current script" & Environment.NewLine & "Do you still want to load?",
              "Load Script From File", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Try
                        frmMain.ucrScriptWindow.txtScript.Text = File.ReadAllText(dlgLoad.FileName)
                    Catch
                        MessageBox.Show("Could not load the script from file." & Environment.NewLine & "The file may be in use by another program or you may not have access to write to the specified location.", "Load Script", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End Using
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        If txtScript.SelectionLength > 0 Then
            CopyText()
        End If
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        If txtScript.SelectionLength > 0 Then
            bUserTextChanged = False
            mnuUndo.Enabled = True
            CutText()
        End If
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        If Clipboard.ContainsData(DataFormats.Text) Then
            bUserTextChanged = False
            mnuUndo.Enabled = True
            txtScript.Paste()
        Else
            MessageBox.Show("You can only paste text data on the script window", "Paste to Script Window", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub ucrScript_Load(sender As Object, e As EventArgs) Handles Me.Load
        'todo. how can this be done through the visual studio properties panel?
        mnuRunCurrentLineSelection.ShortcutKeys = Keys.Enter Or Keys.Control

        txtScript.WordWrap = False
        EnableRunButtons(txtScript.TextLength > 0)
        mnuRedo.Enabled = False 'this is only enabled when undo operation is done.
    End Sub

    Private Sub mnuContextScript_Opening(sender As Object, e As EventArgs) Handles mnuContextScript.Opening
        If txtScript.TextLength > 0 Then
            mnuOpenScriptasFile.Enabled = True
            mnuClearContents.Enabled = True
            mnuSaveScript.Enabled = True
            mnuRunCurrentLineSelection.Enabled = True
            mnuRunAllText.Enabled = True
        Else
            mnuOpenScriptasFile.Enabled = False
            mnuClearContents.Enabled = False
            mnuSaveScript.Enabled = False
            mnuRunCurrentLineSelection.Enabled = False
            mnuRunAllText.Enabled = False
        End If

        If txtScript.SelectionLength > 0 Then
            mnuCopy.Enabled = True
            mnuCut.Enabled = True
        Else
            mnuCopy.Enabled = False
            mnuCut.Enabled = False
        End If

    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        'Determine if last operation can be undone in text box.   
        If txtScript.CanUndo Then
            bUserTextChanged = False
            txtScript.Undo() 'Undo the last operation.
            mnuUndo.Enabled = False
            mnuRedo.Enabled = True
        End If
    End Sub

    Private Sub mnuRedo_Click(sender As Object, e As EventArgs) Handles mnuRedo.Click

        'Determine if last operation can be undone in text box.   
        If txtScript.CanUndo Then
            bUserTextChanged = False
            'This is an equivalent of redo in this case. 
            'because calling undo twice gets the last undone text to be redone
            txtScript.Undo()
            mnuUndo.Enabled = True
            mnuRedo.Enabled = False
        End If
    End Sub

    Private Sub txtScript_KeyDown(sender As Object, e As KeyEventArgs) Handles txtScript.KeyDown
        'Ignore the Ctrl, Shift commands. It could be a redo action which we want to ignore.
        If Not (e.Control OrElse e.Shift OrElse e.Modifiers = (Keys.Control OrElse Keys.Shift)) Then
            bUserTextChanged = True
        End If
    End Sub

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged
        EnableRunButtons(txtScript.TextLength > 0)
        'Only enabled undo if the text was changed directly by the user.  

        If bUserTextChanged AndAlso Not mnuUndo.Enabled Then
            txtScript.ClearUndo() 'Clear undo, because this is now a new text input by the user.

            mnuUndo.Enabled = True
            mnuRedo.Enabled = False
        End If
        bUserTextChanged = False 'reset flag
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "542")
    End Sub

End Class
