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
Imports System.Windows.Controls
Imports ScintillaNET

Public Class ucrScript
    Public strRInstatLogFilesFolderPath As String = Path.Combine(Path.GetFullPath(FileIO.SpecialDirectories.MyDocuments), "R-Instat_Log_files")

    Private strComment As String = "Code run from Script Window"
    Private strCurrentDirectory As String = ""
    Private iMaxLineNumberCharLength As Integer = 0

    Public Sub CopyText()
        clsScriptOld.Copy()
        EnableDisableButtons()
    End Sub

    Public Sub SelectAllText()
        clsScriptOld.SelectAll()
        EnableDisableButtons()
    End Sub

    Private Sub RunCurrentLine()
        Static strScriptCmd As String = "" 'static so that script can be added to with successive calls of this function

        If clsScriptOld.TextLength > 0 Then
            Dim strLineTextString = clsScriptOld.Lines(clsScriptOld.CurrentLine).Text
            strScriptCmd &= vbCrLf & strLineTextString 'insert carriage return to ensure that new text starts on new line
            strScriptCmd = RunText(strScriptCmd)

            Dim iNextLinePos As Integer = clsScriptOld.Lines(clsScriptOld.CurrentLine).EndPosition
            clsScriptOld.GotoPosition(iNextLinePos)
        End If
    End Sub

    Public Sub AppendText(strText As String)
        clsScriptOld.AppendText(Environment.NewLine & strText)
        clsScriptOld.GotoPosition(clsScriptOld.TextLength)
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
        mnuUndo.Enabled = clsScriptOld.CanUndo
        mnuRedo.Enabled = clsScriptOld.CanRedo

        Dim bScriptselected = clsScriptOld.SelectedText.Length > 0
        Dim bScriptExists = clsScriptOld.TextLength > 0

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

        btnRemoveTab.Enabled = TabControl.TabCount > 1
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
        clsScriptOld.Margins(0).Width = clsScriptOld.TextWidth(Style.LineNumber, strLineNumber)
    End Sub

    Private Function IsCharBlank(charNew As Char) As Boolean
        Return charNew = Chr(0) OrElse String.IsNullOrWhiteSpace(charNew.ToString()) OrElse charNew = vbLf OrElse charNew = vbCr
    End Function

    Private Function IsCharQuote(charNew As Char) As Boolean
        Return charNew = """" OrElse charNew = "'"
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     If <paramref name="charNew"/> is a bracket/quote, then inserts a closing bracket/quote. <para>
    '''     This sub is based on a C# function from:
    '''     https://github.com/jacobslusser/ScintillaNET/wiki/Character-Autocompletion. </para><para>
    '''     It avoids inserting matching quotes in situations such as "don't". 
    '''     It also ensures that the caret does not remain in the center upon multiple quote insertions.</para><para>
    '''     For example ("|" is cursor position; '=&gt;' is output):</para><list type="bullet"><item>
    '''         insert ' =&gt; '|' </item><item>
    '''         insert ' again =&gt; ''| </item></list>
    '''     Visual Studio and RStudio have the same behaviour.
    ''' </summary>
    ''' <param name="charNew">  The character typed by the user. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub InsertMatchedChars(charNew As Char)
        Dim iCaretPos As Integer = clsScriptOld.CurrentPosition
        Dim bIsDocStart As Boolean = iCaretPos = 1
        Dim bIsDocEnd As Boolean = iCaretPos = clsScriptOld.Text.Length

        Dim charPrev As Char = If(bIsDocStart, Chr(0), ChrW(clsScriptOld.GetCharAt(iCaretPos - 2)))
        Dim charNext As Char = If(bIsDocEnd, Chr(0), ChrW(clsScriptOld.GetCharAt(iCaretPos)))

        Dim dctBrackets As New Dictionary(Of Char, Char) From {{"(", ")"}, {"{", "}"}, {"[", "]"}}

        'If user entered an open bracket character
        If dctBrackets.ContainsKey(charNew) Then
            If IsCharQuote(charNext) Then
                Exit Sub
            End If
            'insert close bracket character
            clsScriptOld.InsertText(iCaretPos, dctBrackets(charNew))
        ElseIf IsCharQuote(charNew) Then ' else if user entered quote
            'if user enters multiple quotes, then ensure that the caret does not remain in the center
            If charPrev = charNew AndAlso charNext = charNew Then
                clsScriptOld.DeleteRange(iCaretPos, 1)
                clsScriptOld.GotoPosition(iCaretPos)
                Exit Sub
            End If

            'in certain situations add a closing quote after the caret
            Dim charClosingBracket As Char
            Dim bIsEnclosedByBrackets As Boolean = dctBrackets.TryGetValue(charPrev, charClosingBracket) AndAlso charNext = charClosingBracket
            Dim bIsEnclosedBySpaces As Boolean = IsCharBlank(charPrev) AndAlso IsCharBlank(charNext)
            Dim bIsEnclosedByBracketAndSpace As Boolean = (dctBrackets.ContainsKey(charPrev) AndAlso IsCharBlank(charNext)) _
                                                   OrElse (dctBrackets.ContainsValue(charNext) AndAlso IsCharBlank(charPrev))
            If bIsEnclosedByBrackets OrElse bIsEnclosedBySpaces OrElse bIsEnclosedByBracketAndSpace Then
                clsScriptOld.InsertText(iCaretPos, charNew)
            End If
        End If
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>   Automatically sets the indent of a new line.<para>
    '''             Normally the indent is set to the same indent as the last previous non-empty 
    '''             line. However, if the caret was between '{}' when enter was pressed, then 
    '''             increases the indent by 2 spaces and moves the '}' to the next line.</para><para>
    '''             This results in code with nested indents. For example:</para>
    '''             <code>
    '''             a = function(b){
    '''             ..statement1
    '''             ..if (b){
    '''             ....statement2
    '''             ..}
    '''             }</code>. </summary>
    '''
    ''' <param name="iKeyPressed">    The last key pressed by the user. </param>
    '''--------------------------------------------------------------------------------------------
    Private Sub InsertIndent(iKeyPressed As Integer)
        ' we only need to enter an indent when the user presses the enter key
        If iKeyPressed <> Keys.Enter Or clsScriptOld.AutoCActive <> False Then
            Exit Sub
        End If

        ' find indent on previous non-blank line
        Dim iIndent As Integer = 0
        Dim strLinePrevText As String = ""
        For iLineNum As Integer = clsScriptOld.CurrentLine - 1 To 0 Step -1
            strLinePrevText = clsScriptOld.Lines(iLineNum).Text
            If Not String.IsNullOrWhiteSpace(strLinePrevText) Then
                iIndent = strLinePrevText.Length - strLinePrevText.TrimStart().Length
                Exit For
            End If
        Next

        ' if caret before '}', then move '}' to new line
        Dim strCharNext As String = If(clsScriptOld.Text.Length > clsScriptOld.CurrentPosition, clsScriptOld.Text(clsScriptOld.CurrentPosition), "")
        If strCharNext = "}"c Then
            clsScriptOld.InsertText(clsScriptOld.CurrentPosition, vbCrLf & "".PadRight(iIndent))
            clsScriptOld.ScrollRange(clsScriptOld.CurrentPosition, clsScriptOld.CurrentPosition + 2) 'ensure '}' is still visible to user
        End If

        ' if caret after '{', then increase indent 
        strLinePrevText = strLinePrevText.Replace(vbCrLf, "").TrimEnd() ' remove carriage returns and trailing spaces
        Dim strCharPrev As String = If(strLinePrevText.Length >= 1, strLinePrevText(strLinePrevText.Length - 1), "")
        If strCharPrev = "{"c Then
            iIndent += 2
        End If

        ' apply indent to current line
        clsScriptOld.InsertText(clsScriptOld.CurrentPosition, "".PadRight(iIndent))

        ' move caret to end indent
        clsScriptOld.GotoPosition(clsScriptOld.CurrentPosition + iIndent)
    End Sub

    Private Function IsBracket(iNewChar As Integer) As Boolean
        Dim arrRBrackets() As String = {"(", ")", "{", "}", "[", "]"}
        Return arrRBrackets.Contains(Chr(iNewChar))
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     If the caret is next to a bracket, then it highlights the paired open/close bracket. 
    '''     If it cannot find a paired bracket, then it displays the bracket next to the caret in 
    '''     the specified error colour. For nested indented brackets, also shows a vertical 
    '''     indentation line. <para>
    '''     This sub is based on a C# function from:
    '''     https://github.com/jacobslusser/ScintillaNET/wiki/Brace-Matching. </para>
    ''' </summary>
    '''--------------------------------------------------------------------------------------------
    Private Sub HighlightPairedBracket()
        'if caret has not moved, then do nothing
        Static iLastCaretPos As Integer = 0
        Dim iCaretPos As Integer = clsScriptOld.CurrentPosition
        If iLastCaretPos = iCaretPos Then
            Exit Sub
        End If
        iLastCaretPos = iCaretPos

        Dim iBracketPos1 As Integer = -1
        'is there a brace to the left Or right?
        If iCaretPos > 0 AndAlso IsBracket(clsScriptOld.GetCharAt(iCaretPos - 1)) Then
            iBracketPos1 = iCaretPos - 1
        ElseIf IsBracket(clsScriptOld.GetCharAt(iCaretPos)) Then
            iBracketPos1 = iCaretPos
        End If

        If iBracketPos1 >= 0 Then
            'find the matching brace
            Dim iBracketPos2 As Integer = clsScriptOld.BraceMatch(iBracketPos1)
            If iBracketPos2 = Scintilla.InvalidPosition Then
                clsScriptOld.BraceBadLight(iBracketPos1)
                clsScriptOld.HighlightGuide = 0
            Else
                clsScriptOld.BraceHighlight(iBracketPos1, iBracketPos2)
                clsScriptOld.HighlightGuide = clsScriptOld.GetColumn(iBracketPos1)
            End If
        Else
            'turn off brace matching
            clsScriptOld.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition)
            clsScriptOld.HighlightGuide = 0
        End If
    End Sub

    Private Sub RunLineSelection_Click(sender As Object, e As EventArgs) Handles mnuRunCurrentLineSelection.Click, cmdRunLineSelection.Click
        'temporarily disable the buttons in case its a long operation
        EnableRunButtons(False)
        If clsScriptOld.SelectedText.Length > 0 Then
            RunText(clsScriptOld.SelectedText)
        Else
            RunCurrentLine()
        End If
        EnableRunButtons(True)
    End Sub

    Private Sub RunAll_Click(sender As Object, e As EventArgs) Handles mnuRunAllText.Click, cmdRunAll.Click
        If clsScriptOld.TextLength < 1 _
                OrElse MsgBox("Are you sure you want to run the entire contents of the script window?",
                              vbYesNo, "Run All") = vbNo Then
            Exit Sub
        End If

        EnableRunButtons(False) 'temporarily disable the run buttons in case its a long operation
        RunText(clsScriptOld.Text)
        EnableRunButtons(True)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles mnuClearContents.Click, cmdClear.Click
        If clsScriptOld.TextLength < 1 _
                OrElse MsgBox("Are you sure you want to clear the contents of the script window?",
                               vbYesNo, "Clear") = vbNo Then
            Exit Sub
        End If
        clsScriptOld.ClearAll()
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
                              frmMain.clsRLink.GetRSetupScript() & clsScriptOld.Text)
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
                    File.WriteAllText(dlgSave.FileName, clsScriptOld.Text)
                Catch
                    MsgBox("Could not save the script file." & Environment.NewLine &
                           "The file may be in use by another program or you may not have access to write to the specified location.",
                           vbExclamation, "Save Script")
                End Try
            End If
        End Using
    End Sub

    Private Sub mnuLoadScriptFromFile_Click(sender As Object, e As EventArgs) Handles mnuLoadScriptFromFile.Click
        If clsScriptOld.TextLength > 0 _
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
                frmMain.ucrScriptWindow.clsScriptOld.Text = File.ReadAllText(dlgLoad.FileName)
            Catch
                MsgBox("Could not load the script from file." & Environment.NewLine &
                       "The file may be in use by another program or you may not have access to write to the specified location.",
                       vbExclamation, "Load Script")
            End Try
        End Using
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        If clsScriptOld.SelectedText.Length > 0 Then
            CopyText()
            EnableDisableButtons()
        End If
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        If clsScriptOld.SelectedText.Length > 0 Then
            clsScriptOld.Cut()
            EnableDisableButtons()
        End If
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        If Clipboard.ContainsData(DataFormats.Text) Then
            clsScriptOld.Paste()
            EnableDisableButtons()
        Else
            MsgBox("You can only paste text data on the script window.", MsgBoxStyle.Exclamation, "Paste to Script Window")
        End If
    End Sub

    Private Sub ucrScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnableDisableButtons()
        'normally we would do this in the designer, but designer doesn't allow enter key as shortcut
        mnuRunCurrentLineSelection.ShortcutKeys = Keys.Enter Or Keys.Control

        clsScriptOld = newScriptEditor()
        setLineNumberMarginWidth(1)
    End Sub

    Private Function newScriptEditor() As Scintilla
        Dim clsNewScript As Scintilla = New Scintilla With {
            .ContextMenuStrip = mnuContextScript,
            .Dock = DockStyle.Fill,
            .Location = New Point(3, 3),
            .Name = "txtScriptAdded",
            .Size = New Size(391, 409),
            .TabIndex = 14, 'TODO
            .TabWidth = 2
        }


        clsNewScript.StyleResetDefault()
        clsNewScript.Styles(Style.Default).Font = "Consolas"
        clsNewScript.Styles(Style.Default).Size = 10

        'TODO  Configure from R-Instat options?
        'clsScript.Styles(Style.Default).Font = frmMain.clsInstatOptions.fntEditor.Name
        'clsScript.Styles(Style.Default).Size = frmMain.clsInstatOptions.fntEditor.Size


        ' Set the lexer
        clsNewScript.Lexer = Lexer.R

        ' Instruct the lexer to calculate folding
        clsNewScript.SetProperty("fold", "1")
        clsNewScript.SetProperty("fold.compact", "1")

        ' Configure a margin to display folding symbols
        clsNewScript.Margins(2).Type = MarginType.Symbol
        clsNewScript.Margins(2).Mask = Marker.MaskFolders
        clsNewScript.Margins(2).Sensitive = True
        clsNewScript.Margins(2).Width = 20

        ' Set colors for all folding markers
        For i As Integer = 25 To 31
            clsNewScript.Markers(i).SetForeColor(SystemColors.ControlLightLight)
            clsNewScript.Markers(i).SetBackColor(SystemColors.ControlDark)
        Next

        ' Configure folding markers with respective symbols
        clsNewScript.Markers(Marker.Folder).Symbol = MarkerSymbol.BoxPlus
        clsNewScript.Markers(Marker.FolderOpen).Symbol = MarkerSymbol.BoxMinus
        clsNewScript.Markers(Marker.FolderEnd).Symbol = MarkerSymbol.BoxPlusConnected
        clsNewScript.Markers(Marker.FolderMidTail).Symbol = MarkerSymbol.TCorner
        clsNewScript.Markers(Marker.FolderOpenMid).Symbol = MarkerSymbol.BoxMinusConnected
        clsNewScript.Markers(Marker.FolderSub).Symbol = MarkerSymbol.VLine
        clsNewScript.Markers(Marker.FolderTail).Symbol = MarkerSymbol.LCorner

        ' Enable automatic folding
        clsNewScript.AutomaticFold = AutomaticFold.Show Or AutomaticFold.Click Or AutomaticFold.Change

        clsNewScript.IndentationGuides = IndentView.LookBoth
        clsNewScript.StyleClearAll()
        clsNewScript.Styles(Style.R.Default).ForeColor = Color.Silver
        clsNewScript.Styles(Style.R.Comment).ForeColor = Color.Green
        clsNewScript.Styles(Style.R.KWord).ForeColor = Color.Blue
        clsNewScript.Styles(Style.R.BaseKWord).ForeColor = Color.Blue
        clsNewScript.Styles(Style.R.OtherKWord).ForeColor = Color.Blue
        clsNewScript.Styles(Style.R.Number).ForeColor = Color.Purple
        clsNewScript.Styles(Style.R.String).ForeColor = Color.FromArgb(163, 21, 21)
        clsNewScript.Styles(Style.R.String2).ForeColor = Color.FromArgb(163, 21, 21)
        clsNewScript.Styles(Style.R.Operator).ForeColor = Color.Gray
        clsNewScript.Styles(Style.R.Identifier).ForeColor = Color.Black
        clsNewScript.Styles(Style.R.Infix).ForeColor = Color.Gray
        clsNewScript.Styles(Style.R.InfixEol).ForeColor = Color.Gray
        clsNewScript.Styles(Style.BraceLight).BackColor = Color.LightGray
        clsNewScript.Styles(Style.BraceLight).ForeColor = Color.BlueViolet
        clsNewScript.Styles(Style.BraceBad).ForeColor = Color.Red

        Dim tmp = clsNewScript.DescribeKeywordSets()
        clsNewScript.SetKeywords(0, "if else repeat while function for in next break TRUE FALSE NULL NA Inf NaN NA_integer_ NA_real_ NA_complex_ NA_character")

        'TODO if we want to set the key words for 'default package functions' (key word set 1) 
        ' and/or 'other package functions', then a good list is available at:
        '  https://raw.githubusercontent.com/moltenform/scite-files/master/files/files/api_files/r.properties  

        Return clsNewScript
    End Function

    Private Sub mnuContextScript_Opening(sender As Object, e As EventArgs) Handles mnuContextScript.Opening
        EnableDisableButtons()
    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        'Determine if last operation can be undone in text box.   
        If clsScriptOld.CanUndo Then
            clsScriptOld.Undo() 'Undo the last operation.
            EnableDisableButtons()
        End If
    End Sub

    Private Sub mnuRedo_Click(sender As Object, e As EventArgs) Handles mnuRedo.Click
        'Determine if last operation can be redone in text box.   
        If clsScriptOld.CanRedo Then
            clsScriptOld.Redo()
            EnableDisableButtons()
        End If
    End Sub

    Private Sub clsScript_TextChanged(sender As Object, e As EventArgs) Handles clsScriptOld.TextChanged
        EnableDisableButtons()
        setLineNumberMarginWidth(clsScriptOld.Lines.Count.ToString().Length)
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click, cmdHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "542")
    End Sub

    Private Sub mnuSelectAll_Click(sender As Object, e As EventArgs) Handles mnuSelectAll.Click
        clsScriptOld.SelectAll()
        EnableDisableButtons()
    End Sub

    Private Sub clsScript_CharAdded(sender As Object, e As CharAddedEventArgs) Handles clsScriptOld.CharAdded
        InsertMatchedChars(ChrW(e.Char))
        InsertIndent(e.Char)
    End Sub

    Private Sub clsScript_UpdateUI(sender As Object, e As UpdateUIEventArgs) Handles clsScriptOld.UpdateUI
        HighlightPairedBracket()
    End Sub

    Private Sub cmdAddTab_Click(sender As Object, e As EventArgs) Handles cmdAddTab.Click

        Static iTabCounter As Integer = 1

        clsScriptOld = newScriptEditor()
        setLineNumberMarginWidth(1)

        Dim tabPageAdded = New TabPage
        tabPageAdded.Controls.Add(clsScriptOld)
        tabPageAdded.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tabPageAdded.ForeColor = System.Drawing.SystemColors.ControlText
        tabPageAdded.Location = New System.Drawing.Point(4, 22)
        tabPageAdded.Name = "TabPageAdded"
        tabPageAdded.Padding = New System.Windows.Forms.Padding(3)
        tabPageAdded.Size = New System.Drawing.Size(397, 415)
        tabPageAdded.TabIndex = 0
        'tabPageAdded.Text = "Log"
        tabPageAdded.UseVisualStyleBackColor = True

        TabControl.TabPages.Add(tabPageAdded)
        'tabPageAdded.Text = "Untitled" & (TabControl.TabPages.IndexOf(tabPageAdded) + 1)
        tabPageAdded.Text = "Untitled" & iTabCounter
        iTabCounter += 1

        TabControl.SelectedTab = tabPageAdded

        'Dim txtScriptSelected As ScintillaNET.Scintilla
        'Dim tabPageControls = TabControl.SelectedTab.Controls
        'For Each control In tabPageControls
        '    If TypeOf control Is ScintillaNET.Scintilla Then
        '        txtScriptSelected = DirectCast(control, ScintillaNET.Scintilla)
        '    End If
        'Next

        clsScriptOld.AppendText("test" & iTabCounter - 1)
        EnableDisableButtons()

    End Sub

    Private Sub CmdRemoveTab_Click(sender As Object, e As EventArgs) Handles btnRemoveTab.Click

        If TabControl.TabCount < 2 Then
            Exit Sub
        End If

        Dim iTabRemovedIndex As Integer = TabControl.TabPages.IndexOf(TabControl.SelectedTab)
        Dim iTabNewSelected As Integer = iTabRemovedIndex
        If iTabRemovedIndex >= TabControl.TabCount - 1 Then
            iTabNewSelected -= 1
        End If
        TabControl.TabPages.Remove(TabControl.SelectedTab)
        TabControl.SelectedTab = TabControl.TabPages(iTabNewSelected)
        EnableDisableButtons()

    End Sub

    Private Sub tabControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl.Selected

        'TODO continue from here
        '- set txtScript to the Scintilla control of the newly selected tab
        '- replace clsScriptOld with clsScriptActive (find and replace, not rename)
        '- make private
        '- replace frmMain and dlgImportDataset calls to clsScriptOld with calls to public properties
        '- remove Scintilla from designer
        '- remove first tab from designer
        '- create first tab on load

        Dim txtScriptSelected As ScintillaNET.Scintilla = Nothing
        Dim tabPageControls = TabControl.SelectedTab.Controls
        For Each control In tabPageControls
            If TypeOf control Is ScintillaNET.Scintilla Then
                txtScriptSelected = DirectCast(control, ScintillaNET.Scintilla)
            End If
        Next

        If Not IsNothing(txtScriptSelected) Then
            txtScriptSelected.AppendText("changed1" & vbCrLf)
        End If
        EnableDisableButtons()
    End Sub

End Class
