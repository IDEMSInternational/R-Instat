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
Imports ScintillaNET

Public Class ucrScript
    Public strRInstatLogFilesFolderPath As String = Path.Combine(Path.GetFullPath(FileIO.SpecialDirectories.MyDocuments), "R-Instat_Log_files")

    Private strComment As String = "Code run from Script Window"
    Private strCurrentDirectory As String = ""
    Private iMaxLineNumberCharLength As Integer = 0

    Public Sub CopyText()
        txtScript.Copy()
        EnableDisableButtons()
    End Sub

    Public Sub SelectAllText()
        txtScript.SelectAll()
        EnableDisableButtons()
    End Sub

    Private Sub RunCurrentLine()
        Static strScriptCmd As String = "" 'static so that script can be added to with successive calls of this function

        If txtScript.TextLength > 0 Then
            Dim strLineTextString = txtScript.Lines(txtScript.CurrentLine).Text
            strScriptCmd &= vbCrLf & strLineTextString 'insert carriage return to ensure that new text starts on new line
            strScriptCmd = RunText(strScriptCmd)

            Dim iNextLinePos As Integer = txtScript.Lines(txtScript.CurrentLine).EndPosition
            txtScript.GotoPosition(iNextLinePos)
        End If
    End Sub

    Public Sub AppendText(strText As String)
        txtScript.AppendText(Environment.NewLine & strText)
        txtScript.GotoPosition(txtScript.TextLength)
        EnableDisableButtons()
    End Sub

    Private Function RunText(strText As String) As String
        Return If(Not String.IsNullOrEmpty(strText),
                  frmMain.clsRLink.RunScriptFromWindow(strNewScript:=strText, strNewComment:=strComment),
                  "")
    End Function

    Private Sub EnableRunButtons(bEnable As Boolean)
        cmdRunLineSelection.Enabled = bEnable
        cmdRunAll.Enabled = bEnable
    End Sub

    Private Sub EnableDisableButtons()
        mnuUndo.Enabled = txtScript.CanUndo
        mnuRedo.Enabled = txtScript.CanRedo

        Dim bScriptselected = txtScript.SelectedText.Length > 0
        Dim bScriptExists = txtScript.TextLength > 0

        mnuCut.Enabled = bScriptselected
        mnuCopy.Enabled = bScriptselected
        mnuPaste.Enabled = Clipboard.ContainsData(DataFormats.Text)
        mnuSelectAll.Enabled = bScriptExists
        mnuClearContents.Enabled = bScriptExists

        mnuRunCurrentLineSelection.Enabled = bScriptExists
        mnuRunAllText.Enabled = bScriptExists

        mnuOpenScriptasFile.Enabled = bScriptExists
        mnuSaveScript.Enabled = bScriptExists

        cmdRunLineSelection.Enabled = bScriptExists
        cmdRunAll.Enabled = bScriptExists
        cmdClear.Enabled = bScriptExists
    End Sub

    Private Sub setLineNumberMarginWidth(iMaxLineNumberCharLengthNew As Integer)
        If iMaxLineNumberCharLength = iMaxLineNumberCharLengthNew Then
            Exit Sub
        End If
        iMaxLineNumberCharLength = iMaxLineNumberCharLengthNew

        Dim strLineNumber As String = "9"
        For i As Integer = 1 To iMaxLineNumberCharLength
            strLineNumber &= "9"
        Next
        txtScript.Margins(0).Width = txtScript.TextWidth(Style.LineNumber, strLineNumber)
    End Sub

    Private Sub RunLineSelection_Click(sender As Object, e As EventArgs) Handles mnuRunCurrentLineSelection.Click, cmdRunLineSelection.Click
        'temporarily disable the buttons in case its a long operation
        EnableRunButtons(False)
        If txtScript.SelectedText.Length > 0 Then
            RunText(txtScript.SelectedText)
        Else
            RunCurrentLine()
        End If
        EnableRunButtons(True)
    End Sub

    Private Sub RunAll_Click(sender As Object, e As EventArgs) Handles mnuRunAllText.Click, cmdRunAll.Click
        If txtScript.TextLength < 1 _
                OrElse MsgBox("Are you sure you want to run the entire contents of the script window?",
                              vbYesNo, "Run All") = vbNo Then
            Exit Sub
        End If

        EnableRunButtons(False) 'temporarily disable the run buttons in case its a long operation
        RunText(txtScript.Text)
        EnableRunButtons(True)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles mnuClearContents.Click, cmdClear.Click
        If txtScript.TextLength < 1 _
                OrElse MsgBox("Are you sure you want to clear the contents of the script window?",
                               vbYesNo, "Clear") = vbNo Then
            Exit Sub
        End If
        txtScript.ClearAll()
        EnableDisableButtons()
    End Sub

    Private Sub mnuOpenScript_Click(sender As Object, e As EventArgs) Handles mnuOpenScriptasFile.Click
        Try
            If Not Directory.Exists(strRInstatLogFilesFolderPath) Then
                Directory.CreateDirectory(strRInstatLogFilesFolderPath)
            End If
            Dim strScriptFilename As String = "RInstatScript.R"
            Dim i As Integer = 0
            While File.Exists(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename))
                i += 1
                strScriptFilename = "RInstatScript" & i & ".R"
            End While
            File.WriteAllText(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename),
                              frmMain.clsRLink.GetRSetupScript() & txtScript.Text)
            Process.Start(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename))
        Catch
            MsgBox("Could not save the script file." & Environment.NewLine &
                   "The file may be in use by another program or you may not have access to write to the specified location.",
                   vbExclamation, "Open Script")
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
                    MsgBox("Could not save the script file." & Environment.NewLine &
                           "The file may be in use by another program or you may not have access to write to the specified location.",
                           vbExclamation, "Save Script")
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuLoadScriptFromFile_Click(sender As Object, e As EventArgs) Handles mnuLoadScriptFromFile.Click
        If txtScript.TextLength > 0 _
                AndAlso MsgBox("Loading a script from file will clear your current script" _
                               & Environment.NewLine & "Do you still want to load?",
                               vbYesNo, "Load Script From File") = vbNo Then
            Exit Sub
        End If

        Using dlgLoad As New OpenFileDialog
            dlgLoad.Title = "Load Script From Text File"
            dlgLoad.Filter = "Text & R Script Files (*.txt,*.R)|*.txt;*.R|R Script File (*.R)|*.R|Text File (*.txt)|*.txt"
            dlgLoad.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory

            If Not dlgLoad.ShowDialog() = DialogResult.OK Then
                Exit Sub
            End If

            Try
                frmMain.ucrScriptWindow.txtScript.Text = File.ReadAllText(dlgLoad.FileName)
            Catch
                MsgBox("Could not load the script from file." & Environment.NewLine &
                       "The file may be in use by another program or you may not have access to write to the specified location.",
                       vbExclamation, "Load Script")
            End Try
        End Using
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        If txtScript.SelectedText.Length > 0 Then
            CopyText()
            EnableDisableButtons()
        End If
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        If txtScript.SelectedText.Length > 0 Then
            txtScript.Cut()
            EnableDisableButtons()
        End If
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        If Clipboard.ContainsData(DataFormats.Text) Then
            txtScript.Paste()
            EnableDisableButtons()
        Else
            MsgBox("You can only paste text data on the script window.", "Paste to Script Window")
        End If
    End Sub

    Private Sub ucrScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDisableButtons()
        'normally we would do this in the designer, but designer doesn't allow enter key as shortcut
        mnuRunCurrentLineSelection.ShortcutKeys = Keys.Enter Or Keys.Control

        txtScript.StyleResetDefault()
        txtScript.Styles(Style.Default).Font = "Consolas"
        txtScript.Styles(Style.Default).Size = 10

        'TODO  Configure from R-Instat options?
        'TextArea.Styles(Style.Default).Font = frmMain.clsInstatOptions.fntEditor.Name
        'TextArea.Styles(Style.Default).Size = frmMain.clsInstatOptions.fntEditor.Size

        txtScript.StyleClearAll()
        txtScript.Styles(Style.R.Default).ForeColor = Color.Silver
        txtScript.Styles(Style.R.Comment).ForeColor = Color.Green
        txtScript.Styles(Style.R.KWord).ForeColor = Color.Blue
        txtScript.Styles(Style.R.BaseKWord).ForeColor = Color.Blue
        txtScript.Styles(Style.R.OtherKWord).ForeColor = Color.Blue
        txtScript.Styles(Style.R.Number).ForeColor = Color.Olive
        txtScript.Styles(Style.R.String).ForeColor = Color.FromArgb(163, 21, 21)
        txtScript.Styles(Style.R.String2).ForeColor = Color.FromArgb(163, 21, 21)
        txtScript.Styles(Style.R.Operator).ForeColor = Color.Purple
        txtScript.Styles(Style.R.Identifier).ForeColor = Color.Black
        txtScript.Styles(Style.R.Infix).ForeColor = Color.Purple
        txtScript.Styles(Style.R.InfixEol).ForeColor = Color.Purple

        setLineNumberMarginWidth(1)
    End Sub

    Private Sub mnuContextScript_Opening(sender As Object, e As EventArgs) Handles mnuContextScript.Opening
        EnableDisableButtons()
    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        'Determine if last operation can be undone in text box.   
        If txtScript.CanUndo Then
            txtScript.Undo() 'Undo the last operation.
            EnableDisableButtons()
        End If
    End Sub

    Private Sub mnuRedo_Click(sender As Object, e As EventArgs) Handles mnuRedo.Click
        'Determine if last operation can be redone in text box.   
        If txtScript.CanRedo Then
            txtScript.Redo()
            EnableDisableButtons()
        End If
    End Sub

    Private Sub txtScript_TextChanged(sender As Object, e As EventArgs) Handles txtScript.TextChanged
        EnableDisableButtons()
        setLineNumberMarginWidth(txtScript.Lines.Count.ToString().Length)
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click, cmdHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "542")
    End Sub

    Private Sub mnuSelectAll_Click(sender As Object, e As EventArgs) Handles mnuSelectAll.Click
        txtScript.SelectAll()
        EnableDisableButtons()
    End Sub
End Class
