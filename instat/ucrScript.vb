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

Imports System.Collections.Specialized
Imports System.IO
Imports System.Windows.Controls
Imports RInsightF461
Imports ScintillaNET
Imports RDotNet

Public Class ucrScript

    Private bIsTextChanged = False
    Private iMaxLineNumberCharLength As Integer = 0
    Private Const iTabIndexLog As Integer = 0
    Private clsRScript As RScript = Nothing
    Private strRInstatLogFilesFolderPath As String = Path.Combine(Path.GetFullPath(FileIO.SpecialDirectories.MyDocuments), "R-Instat_Log_files")

    Friend WithEvents clsScriptActive As Scintilla
    Friend WithEvents clsScriptLog As Scintilla

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        SetupInitialLayout()

    End Sub

    Private Sub ucrScript_Load(sender As Object, e As EventArgs) Handles Me.Load

        toolTipScriptWindow.SetToolTip(cmdRunStatementSelection, "Run the current statement or selection. (Ctrl+Enter)")
        toolTipScriptWindow.SetToolTip(cmdRunAll, "Run all the text in the tab. (Ctrl+Alt+R)")
        toolTipScriptWindow.SetToolTip(cmdLoadScript, "Load a script from file into the current tab.")
        toolTipScriptWindow.SetToolTip(cmdSave, "Save the script in the current tab to a file.")
        toolTipScriptWindow.SetToolTip(cmdAddTab, "Add a new tab.")
        toolTipScriptWindow.SetToolTip(cmdRemoveTab, "Delete the current tab.")
        toolTipScriptWindow.SetToolTip(cmdClear, "Clear the contents of the current tab. (Ctrl+L)")
        toolTipScriptWindow.SetToolTip(cmdHelp, "Display the Script Window help information.")

        mnuUndo.ToolTipText = "Undo the last change. (Ctrl+Z)"
        mnuRedo.ToolTipText = "Redo the last change. (Ctrl+Y)"
        mnuCut.ToolTipText = "Copy the selected text to the clipboard, then delete the text. (Ctrl+X)"
        mnuCopy.ToolTipText = "Copy the selected text to the clipboard. (Ctrl+C)"
        mnuPaste.ToolTipText = "Paste the contents of the clipboard into the current tab. (Ctrl+V)"
        mnuSelectAll.ToolTipText = "Select all the contents of the current tab. (Ctrl+A)"
        mnuClear.ToolTipText = "Clear the contents of the current tab. (Ctrl+L)"
        mnuRunCurrentStatementSelection.ToolTipText = "Run the current statement or selection. (Ctrl+Enter)"
        mnuRunAllText.ToolTipText = "Run all the text in the tab. (Ctrl+Alt+R)"
        mnuOpenScriptasFile.ToolTipText = "Save file to log folder and open file in external editor."
        mnuLoadScriptFromFile.ToolTipText = "Load script from file into the current tab."
        mnuSaveScript.ToolTipText = "Save the script in the current tab to a file."
        mnuHelp.ToolTipText = "Display the Script Window help information."
        mnuInsertScript.ToolTipText = "Insert script in the current tab."

        'normally we would do this in the designer, but designer doesn't allow enter key as shortcut
        mnuRunCurrentStatementSelection.ShortcutKeys = Keys.Enter Or Keys.Control

        'Make the script tab the selected tab
        TabControl.SelectTab(1)
    End Sub

    Private Sub SetupInitialLayout()
        'Create log tab
        AddTab(bIsLogTab:=True)

        'Create script tab
        AddTab()
    End Sub

    ''' <summary>
    '''     The current text in the active tab. 
    ''' </summary>
    Public Property strActiveTabText As String
        Get
            Return If(IsNothing(clsScriptActive), Nothing, clsScriptActive.Text)
        End Get
        Set(strNewText As String)
            If Not IsNothing(clsScriptActive) Then
                clsScriptActive.Text = strNewText
            End If
        End Set
    End Property

    ''' <summary>
    '''     Appends <paramref name="strText"/> to the end of the text in the active tab.
    ''' </summary>
    ''' <param name="strText"> The text to append to the contents of the active tab.</param>
    Public Sub AppendText(strText As String, Optional bAppendAtCurrentCursorPosition As Boolean = False)
        If String.IsNullOrEmpty(strText) Then
            Exit Sub
        End If

        If bAppendAtCurrentCursorPosition Then
            clsScriptActive.InsertText(clsScriptActive.CurrentPosition, strText & Environment.NewLine)
            ' Todo. find a way of going to the last position of the inserted "group of text".
            ' Currently this just goes to the last position of the first line of inserted text
            clsScriptActive.GotoPosition(clsScriptActive.Lines(clsScriptActive.CurrentLine).EndPosition)
        Else
            clsScriptActive.AppendText(Environment.NewLine & strText)
            clsScriptActive.GotoPosition(clsScriptActive.TextLength)
        End If


        EnableDisableButtons()
    End Sub

    Function EscapeDoubleQuotes(ByVal input As String) As String
        ' Replace each double quote with an escaped double quote
        Return input.Replace("""", "\""")
    End Function

    Public Sub FormatRCode()

        Try
            ' Your R script text from Scintilla
            Dim scriptText As String = EscapeDoubleQuotes(clsScriptActive.SelectedText)
            Dim clsStylerFunction As New RFunction

            clsStylerFunction.SetPackageName("styler")
            clsStylerFunction.SetRCommand("style_text")
            clsStylerFunction.AddParameter("text", Chr(34) & scriptText & Chr(34), bIncludeArgumentName:=False)

            Dim expTemp As SymbolicExpression
            Dim formattedCode As String() = Nothing
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsStylerFunction.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                formattedCode = expTemp.AsCharacter().ToArray
            End If

            ' Join the formattedCode array into a single string
            Dim formattedText As String = String.Join(Environment.NewLine, formattedCode)

            ' Check if there is any selected text
            If clsScriptActive.SelectionStart <> clsScriptActive.SelectionEnd Then
                ' Replace the selected text with the formatted text
                clsScriptActive.ReplaceSelection(formattedText)
            Else
                ' If no text is selected, you could decide what to do (e.g., insert the text at the current caret position)
                Dim currentPos As Integer = clsScriptActive.CurrentPosition
                clsScriptActive.InsertText(currentPos, formattedText)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    ''' <summary>
    ''' Removes the selected text from the active tab, and copies the removed text to the clipboard.
    ''' </summary>
    Public Sub CutText()
        If TabControl.SelectedIndex = iTabIndexLog Then
            MsgBox("You can only cut from a script tab, not the log tab.", MsgBoxStyle.Exclamation, "Cut from log tab")
            Exit Sub
        End If

        If clsScriptActive.SelectedText.Length > 0 Then
            clsScriptActive.Cut()
            EnableDisableButtons()
        End If
    End Sub

    ''' <summary>
    ''' Copies the selected text from the active tab to the clipboard.
    ''' </summary>
    Public Sub CopyText()
        If clsScriptActive.SelectedText.Length > 0 Then
            clsScriptActive.Copy()
            EnableDisableButtons()
        End If
    End Sub

    ''' <summary>
    ''' If script tab is already selected, then returns True.
    ''' If log tab is selected and there is only one script tab, then selects script tab and 
    ''' returns True.
    ''' If log tab is selected and there is more than one script tab, then displays a message 
    ''' box and returns False.
    ''' </summary>
    ''' <returns>True if a script tab is selected, or if there is only one script tab; else 
    '''          returns False.</returns>
    Public Function IsScriptTabSelected() As Boolean
        If TabControl.SelectedIndex = iTabIndexLog Then
            If TabControl.TabCount = 2 Then
                TabControl.SelectTab(1)
            Else
                MsgBox("No script tab selected. Please first select the tab of the script you wish to write to.", vbExclamation, "Script Tab Not Selected")
                Return False
            End If
        End If
        Return True
    End Function


    ''' <summary>
    '''     Appends <paramref name="strText"/> to the end of the text in the log tab.
    ''' </summary>
    ''' <param name="strText"> The text to append to the contents of the log tab.</param>
    Public Sub LogText(strText As String)
        clsScriptLog.ReadOnly = False
        clsScriptLog.AppendText(Environment.NewLine & strText)
        clsScriptLog.ReadOnly = True
        clsScriptLog.GotoPosition(clsScriptLog.TextLength)
        If TabControl.SelectedIndex = iTabIndexLog Then
            EnableDisableButtons()
        End If
    End Sub

    ''' <summary>
    ''' Pastes the contents of the clipboard into the active tab.
    ''' </summary>
    Public Sub PasteText()
        If TabControl.SelectedIndex = iTabIndexLog Then
            MsgBox("You can only paste to a script tab, not the log tab.", MsgBoxStyle.Exclamation, "Paste to log tab")
            Exit Sub
        End If

        If Clipboard.ContainsData(DataFormats.Text) Then
            clsScriptActive.Paste()
            EnableDisableButtons()
        Else
            MsgBox("You can only paste text data on the script window.", MsgBoxStyle.Exclamation, "Paste to Script Window")
        End If
    End Sub

    ''' <summary>
    ''' Displays a file save dialog; allows the user to specify a folder and file name; and saves 
    ''' the log/script to the specified file.
    ''' </summary>
    ''' <param name="bIsLog"> True if the script to be saved is the log file.</param>
    Public Sub SaveScript(bIsLog As Boolean, Optional bOpenAsFile As Boolean = False)
        If Not bIsLog AndAlso TabControl.SelectedIndex = iTabIndexLog Then
            If TabControl.TabCount = 2 Then
                TabControl.SelectTab(1)
            Else
                MsgBox("No script tab selected. Please first select the tab of the script you wish to save.", vbExclamation, "Save Script")
                Exit Sub
            End If
        End If

        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save " & If(bIsLog, "Log", "Script") & " To File"
            dlgSave.Filter = "R Script File (*.R)|*.R|Text File (*.txt)|*.txt|JSON File (*.json)|*.json"
            dlgSave.FileName = Path.GetFileName(TabControl.SelectedTab.Text)

            ' Ensure that dialog opens in the correct folder.
            Static strInitialDirectory As String = frmMain.clsInstatOptions.strWorkingDirectory
            Static strInitialDirectoryLog As String = frmMain.clsInstatOptions.strWorkingDirectory
            dlgSave.InitialDirectory = If(bIsLog, strInitialDirectoryLog, strInitialDirectory)

            If dlgSave.ShowDialog() = DialogResult.OK Then
                Try
                    File.WriteAllText(dlgSave.FileName, If(bIsLog, clsScriptLog.Text, clsScriptActive.Text))
                    strInitialDirectory = Path.GetDirectoryName(dlgSave.FileName)
                    bIsTextChanged = False
                    TabControl.SelectedTab.Text = System.IO.Path.GetFileNameWithoutExtension(dlgSave.FileName)
                    frmMain.clsRecentItems.addToMenu(Replace(Path.Combine(Path.GetFullPath(strInitialDirectory), System.IO.Path.GetFileName(dlgSave.FileName)), "\", "/"))
                    frmMain.bDataSaved = True

                    If bIsLog Then
                        strInitialDirectoryLog = Path.GetDirectoryName(dlgSave.FileName)
                    Else
                        strInitialDirectory = Path.GetDirectoryName(dlgSave.FileName)
                    End If
                Catch
                    MsgBox("Could not save the " & If(bIsLog, "Log", "Script") & " file." & Environment.NewLine &
                   "The file may be in use by another program or you may not have access to write to the specified location.",
                   vbExclamation, "Save " & If(bIsLog, "Log", "Script"))
                End Try
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Selects all the text in the active tab.
    ''' </summary>
    Public Sub SelectAllText()
        clsScriptActive.SelectAll()
        EnableDisableButtons()
    End Sub

    Private Sub AddTab(Optional bIsLogTab As Boolean = False)
        clsScriptActive = NewScriptEditor()
        SetLineNumberMarginWidth(1, True)

        Dim tabPageAdded = New TabPage
        tabPageAdded.Controls.Add(clsScriptActive)
        tabPageAdded.Font = New Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tabPageAdded.ForeColor = SystemColors.ControlText
        tabPageAdded.Location = New Point(4, 22)
        tabPageAdded.Name = "TabPageAdded"
        tabPageAdded.Padding = New Padding(3)
        tabPageAdded.Size = New Size(397, 415)
        tabPageAdded.TabIndex = 0
        tabPageAdded.UseVisualStyleBackColor = True

        If bIsLogTab Then
            tabPageAdded.Text = "Log"
            clsScriptLog = clsScriptActive
            clsScriptLog.Styles(Style.Default).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.Default).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.Comment).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.KWord).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.BaseKWord).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.OtherKWord).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.Number).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.String).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.String2).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.Operator).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.Identifier).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.Infix).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.R.InfixEol).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.BraceLight).BackColor = Color.DarkGray
            clsScriptLog.Styles(Style.BraceBad).BackColor = Color.Gainsboro
            clsScriptLog.Styles(Style.LineNumber).BackColor = Color.DarkGray
            clsScriptLog.SetFoldMarginColor(True, Color.DarkGray)
            clsScriptLog.ReadOnly = True
        Else
            Static iTabCounter As Integer = 1
            tabPageAdded.Text = "Untitled" & iTabCounter
            iTabCounter += 1
        End If

        TabControl.TabPages.Add(tabPageAdded)

        TabControl.SelectedTab = tabPageAdded
        bIsTextChanged = False
        clsRScript = Nothing
        EnableDisableButtons()
    End Sub

    Private Sub EnableDisableButtons()

        Dim bIsLogTab As Boolean = TabControl.SelectedIndex = iTabIndexLog
        Dim bScriptExists As Boolean = clsScriptActive.TextLength > 0

        cmdRunStatementSelection.Enabled = bScriptExists
        cmdRunAll.Enabled = bScriptExists
        cmdLoadScript.Enabled = Not bIsLogTab
        cmdSave.Enabled = bScriptExists
        cmdClear.Enabled = bScriptExists AndAlso Not bIsLogTab

        cmdRemoveTab.Enabled = TabControl.TabCount > 2 AndAlso Not bIsLogTab
    End Sub

    ''' <summary>
    ''' Enables or disables all right click menu options
    ''' </summary>
    ''' <param name="bEnable">If true, enables all right click options, false disables them</param>
    Private Sub EnableRightClickMenuOptions(bEnable As Boolean)
        mnuUndo.Enabled = bEnable
        mnuRedo.Enabled = bEnable
        mnuCut.Enabled = bEnable
        mnuCopy.Enabled = bEnable
        mnuPaste.Enabled = bEnable
        mnuSelectAll.Enabled = bEnable
        mnuClear.Enabled = bEnable
        mnuRunCurrentStatementSelection.Enabled = bEnable
        mnuRunAllText.Enabled = bEnable
        mnuLoadScriptFromFile.Enabled = bEnable
        mnuOpenScriptasFile.Enabled = bEnable
        mnuSaveScript.Enabled = bEnable
    End Sub

    ''' <summary>
    ''' Enables or disables the run buttons and all right click menu options
    ''' </summary>
    ''' <param name="bEnable">If true, enables buttons/options, else disables them</param>
    Private Sub EnableRunOptions(bEnable As Boolean)
        cmdRunStatementSelection.Enabled = bEnable
        cmdRunAll.Enabled = bEnable
        EnableRightClickMenuOptions(bEnable)
    End Sub

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
        Dim iCaretPos As Integer = clsScriptActive.CurrentPosition
        If iLastCaretPos = iCaretPos Then
            Exit Sub
        End If
        iLastCaretPos = iCaretPos

        Dim iBracketPos1 As Integer = -1
        'is there a brace to the left Or right?
        If iCaretPos > 0 AndAlso IsBracket(clsScriptActive.GetCharAt(iCaretPos - 1)) Then
            iBracketPos1 = iCaretPos - 1
        ElseIf IsBracket(clsScriptActive.GetCharAt(iCaretPos)) Then
            iBracketPos1 = iCaretPos
        End If

        If iBracketPos1 >= 0 Then
            'find the matching brace
            Dim iBracketPos2 As Integer = clsScriptActive.BraceMatch(iBracketPos1)
            If iBracketPos2 = Scintilla.InvalidPosition Then
                clsScriptActive.BraceBadLight(iBracketPos1)
                clsScriptActive.HighlightGuide = 0
            Else
                clsScriptActive.BraceHighlight(iBracketPos1, iBracketPos2)
                clsScriptActive.HighlightGuide = clsScriptActive.GetColumn(iBracketPos1)
            End If
        Else
            'turn off brace matching
            clsScriptActive.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition)
            clsScriptActive.HighlightGuide = 0
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
        If iKeyPressed <> Keys.Enter Or clsScriptActive.AutoCActive <> False Then
            Exit Sub
        End If

        ' find indent on previous non-blank line
        Dim iIndent As Integer = 0
        Dim strLinePrevText As String = ""
        For iLineNum As Integer = clsScriptActive.CurrentLine - 1 To 0 Step -1
            strLinePrevText = clsScriptActive.Lines(iLineNum).Text
            If Not String.IsNullOrWhiteSpace(strLinePrevText) Then
                iIndent = strLinePrevText.Length - strLinePrevText.TrimStart().Length
                Exit For
            End If
        Next

        ' if caret before '}', then move '}' to new line
        Dim strCharNext As String = If(clsScriptActive.Text.Length > clsScriptActive.CurrentPosition, clsScriptActive.Text(clsScriptActive.CurrentPosition), "")
        If strCharNext = "}"c Then
            clsScriptActive.InsertText(clsScriptActive.CurrentPosition, vbCrLf & "".PadRight(iIndent))
            clsScriptActive.ScrollRange(clsScriptActive.CurrentPosition, clsScriptActive.CurrentPosition + 2) 'ensure '}' is still visible to user
        End If

        ' if caret after '{', then increase indent 
        strLinePrevText = strLinePrevText.Replace(vbCrLf, "").TrimEnd() ' remove carriage returns and trailing spaces
        Dim strCharPrev As String = If(strLinePrevText.Length >= 1, strLinePrevText(strLinePrevText.Length - 1), "")
        If strCharPrev = "{"c Then
            iIndent += 2
        End If

        ' apply indent to current line
        clsScriptActive.InsertText(clsScriptActive.CurrentPosition, "".PadRight(iIndent))

        ' move caret to end indent
        clsScriptActive.GotoPosition(clsScriptActive.CurrentPosition + iIndent)
    End Sub

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
        Dim iCaretPos As Integer = clsScriptActive.CurrentPosition
        Dim bIsDocStart As Boolean = iCaretPos = 1
        Dim bIsDocEnd As Boolean = iCaretPos = clsScriptActive.Text.Length

        Dim charPrev As Char = If(bIsDocStart, Chr(0), ChrW(clsScriptActive.GetCharAt(iCaretPos - 2)))
        Dim charNext As Char = If(bIsDocEnd, Chr(0), ChrW(clsScriptActive.GetCharAt(iCaretPos)))

        Dim dctBrackets As New Dictionary(Of Char, Char) From {{"(", ")"}, {"{", "}"}, {"[", "]"}}

        'If user entered an open bracket character
        If dctBrackets.ContainsKey(charNew) Then
            If IsCharQuote(charNext) Then
                Exit Sub
            End If
            'insert close bracket character
            clsScriptActive.InsertText(iCaretPos, dctBrackets(charNew))
        ElseIf IsCharQuote(charNew) Then ' else if user entered quote
            'if user enters multiple quotes, then ensure that the caret does not remain in the center
            If charPrev = charNew AndAlso charNext = charNew Then
                clsScriptActive.DeleteRange(iCaretPos, 1)
                clsScriptActive.GotoPosition(iCaretPos)
                Exit Sub
            End If

            'in certain situations add a closing quote after the caret
            Dim charClosingBracket As Char
            Dim bIsEnclosedByBrackets As Boolean = dctBrackets.TryGetValue(charPrev, charClosingBracket) AndAlso charNext = charClosingBracket
            Dim bIsEnclosedBySpaces As Boolean = IsCharBlank(charPrev) AndAlso IsCharBlank(charNext)
            Dim bIsEnclosedByBracketAndSpace As Boolean = (dctBrackets.ContainsKey(charPrev) AndAlso IsCharBlank(charNext)) _
                                                   OrElse (dctBrackets.ContainsValue(charNext) AndAlso IsCharBlank(charPrev))
            If bIsEnclosedByBrackets OrElse bIsEnclosedBySpaces OrElse bIsEnclosedByBracketAndSpace Then
                clsScriptActive.InsertText(iCaretPos, charNew)
            End If
        End If
    End Sub

    Private Function IsBracket(iNewChar As Integer) As Boolean
        'the `Chr()` function may throw an exception for higher value integers,
        '    so check value is in a reasonable range. Note: 40 = `(` and 125 = `}`
        If iNewChar < 40 OrElse iNewChar > 125 Then
            Return False
        End If

        Dim arrRBrackets() As String = {"(", ")", "{", "}", "[", "]"}
        Return arrRBrackets.Contains(Chr(iNewChar))
    End Function

    Private Function IsCharBlank(charNew As Char) As Boolean
        Return charNew = Chr(0) OrElse String.IsNullOrWhiteSpace(charNew.ToString()) OrElse charNew = vbLf OrElse charNew = vbCr
    End Function

    Private Function IsCharQuote(charNew As Char) As Boolean
        Return charNew = """" OrElse charNew = "'"
    End Function

    Private Sub LoadScript()
        If TabControl.SelectedIndex = iTabIndexLog Then
            MsgBox("You can only load script to a script tab, not the log tab.", MsgBoxStyle.Exclamation, "Load to log tab")
            Exit Sub
        End If

        If clsScriptActive.TextLength > 0 _
                AndAlso MsgBox("Loading a script from file will clear your current script" _
                               & Environment.NewLine & "Do you still want to load?",
                               vbYesNo, "Load Script From File") = vbNo Then
            Exit Sub
        End If

        Using dlgLoad As New OpenFileDialog
            dlgLoad.Title = "Load Script From Text File"
            dlgLoad.Filter = "Text & R Script Files (*.txt, *.R, *.json)|*.txt;*.R;*.json|R Script File (*.R)|*.R|Text File (*.txt)|*.txt|JSON File (*.json)|*.json"

            ' Ensure that dialog opens in the correct folder.
            'In theory, we should be able to use `dlgLoad.RestoreDirectory = True` but this does
            'not work (I think a bug in WinForms).So we need to use a static variable instead.
            Static strInitialDirectory As String = frmMain.clsInstatOptions.strWorkingDirectory
            dlgLoad.InitialDirectory = strInitialDirectory

            If Not dlgLoad.ShowDialog() = DialogResult.OK Then
                Exit Sub
            End If

            Try
                frmMain.ucrScriptWindow.clsScriptActive.Text = File.ReadAllText(dlgLoad.FileName)
                TabControl.SelectedTab.Text = System.IO.Path.GetFileNameWithoutExtension(dlgLoad.FileName)
                strInitialDirectory = Path.GetDirectoryName(dlgLoad.FileName)
                bIsTextChanged = False
                clsRScript = Nothing
                frmMain.clsRecentItems.addToMenu(Replace(Path.Combine(Path.GetFullPath(strInitialDirectory), System.IO.Path.GetFileName(dlgLoad.FileName)), "\", "/"))
                frmMain.bDataSaved = True
            Catch
                MsgBox("Could not load the script from file." & Environment.NewLine &
                       "The file may be in use by another program or you may not have access to read from the specified location.",
                       vbExclamation, "Load Script")
            End Try
        End Using

    End Sub

    Private Function NewScriptEditor() As Scintilla
        Dim clsNewScript As Scintilla = New Scintilla With {
            .ContextMenuStrip = mnuContextScript,
            .Dock = DockStyle.Fill,
            .Lexer = Lexer.R,
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

    Private Sub RunCurrentStatement()

        If clsScriptActive.TextLength <= 0 Then
            Exit Sub
        End If

        'temporarily disable the buttons in case its a long operation
        EnableRunOptions(False)

        Try
            Dim dctRStatements As OrderedDictionary
            Try
                If clsRScript Is Nothing Then
                    clsRScript = New RScript(clsScriptActive.Text)
                End If
                dctRStatements = clsRScript.statements
            Catch ex As Exception
                MsgBox("R script parsing failed with message:" & Environment.NewLine _
                   & Environment.NewLine & ex.Message & Environment.NewLine & Environment.NewLine _
                   & "Try using 'Run All' or 'Run Selected'. This will execute the script using a less strict method.",
                   MsgBoxStyle.Information, "Could not parse R script")
                Exit Sub
            End Try

            If IsNothing(dctRStatements) OrElse dctRStatements.Count = 0 Then
                Exit Sub
            End If

            Dim iCaretPos As Integer = clsScriptActive.CurrentPosition
            Dim iNextStatementPos As Integer = 0
            Dim clsRStatement As RStatement = Nothing

            For Each kvpDictEntry As DictionaryEntry In dctRStatements
                If kvpDictEntry.Key > iCaretPos Then
                    iNextStatementPos = kvpDictEntry.Key
                    Exit For
                End If
                clsRStatement = kvpDictEntry.Value
            Next

            'if we will execute the only/last statement
            If iNextStatementPos = 0 Then
                ' if there is no blank line at end of text, then add blank line
                If Not (clsScriptActive.Text.EndsWith(vbCr) _
                    OrElse clsScriptActive.Text.EndsWith(vbLf)) Then
                    clsScriptActive.AppendText(vbCrLf)
                End If
                iNextStatementPos = clsScriptActive.TextLength

            Else 'else move caret to first non-blank line of next statement
                For iTextPos As Integer = iNextStatementPos To clsScriptActive.Text.Length - 1
                    Dim chrNext As Char = clsScriptActive.Text.Chars(iTextPos)
                    If chrNext <> vbLf AndAlso chrNext <> vbCr AndAlso Not Char.IsWhiteSpace(chrNext) Then
                        iNextStatementPos = iTextPos
                        Exit For
                    End If
                Next
            End If

            clsScriptActive.GotoPosition(iNextStatementPos)

            frmMain.clsRLink.RunRStatement(clsRStatement)
            frmMain.UpdateAllGrids()
        Finally
            EnableRunOptions(True)
        End Try
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Executes the <paramref name="strScript"/> R script.
    ''' </summary>
    ''' <param name="strScript"> The R script to execute.</param>
    ''' <param name="strComment">Converted into an R comment and prefixed to the script.</param>
    '''--------------------------------------------------------------------------------------------
    Private Sub RunScript(strScript As String, strComment As String)

        EnableRunOptions(False) 'temporarily disable the run buttons in case its a long operation

        Dim dctRStatements As OrderedDictionary
        Try
            dctRStatements = New RScript(frmMain.clsRLink.GetFormattedComment(strComment) _
                                            & Environment.NewLine & strScript).statements
        Catch ex As Exception
            MsgBox("R script parsing failed with message:" & Environment.NewLine _
                   & Environment.NewLine & ex.Message & Environment.NewLine & Environment.NewLine _
                   & "R-Instat will now attempt to execute the script using a less strict method.",
                   MsgBoxStyle.Information, "Could Not Parse R Script")
            frmMain.clsRLink.RunScriptFromWindow(strScript.Trim(vbLf), strComment)
            dctRStatements = Nothing
        End Try

        If Not IsNothing(dctRStatements) Then
            For Each kvpDictEntry As DictionaryEntry In dctRStatements
                frmMain.clsRLink.RunRStatement(kvpDictEntry.Value)
            Next
            frmMain.UpdateAllGrids()
        End If

        EnableRunOptions(True)
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''     Sets the margin used to display line numbers to the correct width so that line numbers 
    '''     up to and including <paramref name="iMaxLineNumberCharLengthNew"/> display correctly.
    ''' </summary>
    ''' <param name="iMaxLineNumberCharLengthNew"> The maximum line number that needs to be 
    '''     displayed (normally the number of lines in the script).</param>
    ''' <param name="bForce"> If true, then forces reset of margin width even if the margin width  
    '''     is the same as the last time that this sub was called (normally only needed when 
    '''     switching to a new tab).</param>
    '''--------------------------------------------------------------------------------------------
    Private Sub SetLineNumberMarginWidth(iMaxLineNumberCharLengthNew As Integer,
                                         Optional bForce As Boolean = False)
        If iMaxLineNumberCharLength = iMaxLineNumberCharLengthNew _
                AndAlso Not bForce Then
            Exit Sub
        End If
        iMaxLineNumberCharLength = iMaxLineNumberCharLengthNew

        Dim strLineNumber As String = "9"
        For i As Integer = 1 To iMaxLineNumberCharLength
            strLineNumber &= "9"
        Next
        clsScriptActive.Margins(0).Width = clsScriptActive.TextWidth(Style.LineNumber, strLineNumber)
    End Sub

    Private Sub clsScriptActive_CharAdded(sender As Object, e As CharAddedEventArgs) Handles clsScriptActive.CharAdded
        InsertMatchedChars(ChrW(e.Char))
        InsertIndent(e.Char)
    End Sub

    Private Sub clsScriptActive_TextChanged(sender As Object, e As EventArgs) Handles clsScriptActive.TextChanged
        bIsTextChanged = True
        clsRScript = Nothing
        EnableDisableButtons()
        SetLineNumberMarginWidth(clsScriptActive.Lines.Count.ToString().Length)
    End Sub

    Private Sub clsScriptActive_UpdateUI(sender As Object, e As UpdateUIEventArgs) Handles clsScriptActive.UpdateUI
        HighlightPairedBracket()
    End Sub

    Private Sub cmdAddTab_Click(sender As Object, e As EventArgs) Handles cmdAddTab.Click
        AddTab()
    End Sub

    Private Sub cmdLoadScript_Click(sender As Object, e As EventArgs) Handles cmdLoadScript.Click
        LoadScript()
    End Sub

    Private Sub mnuInsertScript_Click(sender As Object, e As EventArgs) Handles mnuInsertScript.Click, cmdInsertScript.Click
        dlgScript.ShowDialog()
    End Sub

    Private Sub cmdRemoveTab_Click(sender As Object, e As EventArgs) Handles cmdRemoveTab.Click
        'never remove last script tab
        If TabControl.TabCount < 2 Then
            Exit Sub
        End If

        If clsScriptActive.TextLength > 0 AndAlso bIsTextChanged _
            AndAlso MsgBox("Are you sure you want to delete the tab and lose the contents?",
                               vbYesNo, "Remove Tab") = vbNo Then
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

    Private Sub mnuContextScript_Opening(sender As Object, e As EventArgs) Handles mnuContextScript.Opening
        'enable and disable menu options based on the active script properties before the user views them

        Dim bScriptSelected As Boolean = clsScriptActive.SelectedText.Length > 0
        Dim bScriptExists As Boolean = clsScriptActive.TextLength > 0

        'initially disable all the right click menu options
        EnableRightClickMenuOptions(False)

        'if active tab is not log tab then enable the options based on active tab state
        'below are options that are not to be used in the log tab
        If TabControl.SelectedIndex <> iTabIndexLog Then
            mnuUndo.Enabled = clsScriptActive.CanUndo
            mnuRedo.Enabled = clsScriptActive.CanRedo
            mnuCut.Enabled = bScriptSelected
            mnuCopy.Enabled = bScriptSelected
            mnuPaste.Enabled = Clipboard.ContainsData(DataFormats.Text)
            mnuClear.Enabled = bScriptExists
            mnuLoadScriptFromFile.Enabled = True
        End If

        'enable remaining options based on tab state
        mnuSelectAll.Enabled = bScriptExists
        mnuRunCurrentStatementSelection.Enabled = bScriptExists
        mnuRunAllText.Enabled = bScriptExists
        mnuOpenScriptasFile.Enabled = bScriptExists
        mnuSaveScript.Enabled = bScriptExists
    End Sub

    Private Sub mnuContextScript_Closing(sender As Object, e As EventArgs) Handles mnuContextScript.Closing
        'On closing menu context, just enable all the menu options to restore their short cut keys
        'validations of the options actions is done by the functions that the events call.
        EnableRightClickMenuOptions(True)
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        CutText()
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        CopyText()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        PasteText()
    End Sub

    Private Sub mnuClearContents_Click(sender As Object, e As EventArgs) Handles mnuClear.Click, cmdClear.Click

        If TabControl.SelectedIndex = iTabIndexLog Then
            MsgBox("You can only clear a script tab, not the log tab.", MsgBoxStyle.Exclamation, "Clear log tab")
            Exit Sub
        End If

        If clsScriptActive.TextLength < 1 _
                OrElse MsgBox("Are you sure you want to clear the contents of the script window?",
                               vbYesNo, "Clear") = vbNo Then
            Exit Sub
        End If
        clsScriptActive.ClearAll()
        EnableDisableButtons()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click, cmdHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "542")
    End Sub

    Private Sub mnuLoadScript_Click(sender As Object, e As EventArgs) Handles mnuLoadScriptFromFile.Click
        LoadScript()
    End Sub

    Private Sub mnuOpenScriptasFile_Click(sender As Object, e As EventArgs) Handles mnuOpenScriptasFile.Click
        Try
            Dim bIsLog As Boolean = TabControl.SelectedIndex = iTabIndexLog

            If Not Directory.Exists(strRInstatLogFilesFolderPath) Then
                Directory.CreateDirectory(strRInstatLogFilesFolderPath)
            End If
            Dim strScriptFilename As String = If(bIsLog, "RInstatLog.R", "RInstatScript.R")
            Dim i As Integer = 0
            While File.Exists(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename))
                i += 1
                strScriptFilename = If(bIsLog, "RInstatLog", "RInstatScript") & i & ".R"
            End While
            File.WriteAllText(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename),
                              If(bIsLog, clsScriptLog.Text,
                                 frmMain.clsRLink.GetRSetupScript() & vbCrLf & clsScriptActive.Text))
            Process.Start(Path.Combine(strRInstatLogFilesFolderPath, strScriptFilename))
            TabControl.SelectedTab.Text = strScriptFilename
        Catch
            MsgBox("Could not save the script file." & Environment.NewLine &
                   "The file may be in use by another program or you may not have access to write to the specified location.",
                   vbExclamation, "Open Script as File")
        End Try
    End Sub

    Private Sub mnuRedo_Click(sender As Object, e As EventArgs) Handles mnuRedo.Click
        If TabControl.SelectedIndex = iTabIndexLog Then
            MsgBox("You can only redo in a script tab, not the log tab.", MsgBoxStyle.Exclamation, "Redo log tab")
            Exit Sub
        End If

        'Determine if last operation can be redone in text box.   
        If clsScriptActive.CanRedo Then
            clsScriptActive.Redo()
            EnableDisableButtons()
        End If
    End Sub

    ' Ensure the cursor is visible by scrolling it into view
    Private Sub SetFocusAndScrollCaret()
        ' Set focus back to the ScintillaNET editor control
        clsScriptActive.Focus()

        ' Ensure the cursor is visible by scrolling it into view
        clsScriptActive.ScrollCaret()
    End Sub

    Private Sub mnuRunAllText_Click(sender As Object, e As EventArgs) Handles mnuRunAllText.Click, cmdRunAll.Click
        If clsScriptActive.TextLength < 1 _
                OrElse MsgBox("Are you sure you want to run the entire contents of the script window?",
                              vbYesNo, "Run All") = vbNo Then
            Exit Sub
        End If

        RunScript(clsScriptActive.Text, "Code run from Script Window (all text)")

        SetFocusAndScrollCaret()
    End Sub

    Private Sub mnuRunCurrentStatementSelection_Click(sender As Object, e As EventArgs) Handles mnuRunCurrentStatementSelection.Click, cmdRunStatementSelection.Click
        If clsScriptActive.SelectedText.Length > 0 Then
            RunScript(clsScriptActive.SelectedText, "Code run from Script Window (selected text)")
        Else
            RunCurrentStatement()
        End If

        SetFocusAndScrollCaret()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        SaveScript(TabControl.SelectedIndex = iTabIndexLog)
    End Sub

    Private Sub mnuSaveScript_Click(sender As Object, e As EventArgs) Handles mnuSaveScript.Click
        SaveScript(TabControl.SelectedIndex = iTabIndexLog)
    End Sub

    Private Sub mnuSelectAll_Click(sender As Object, e As EventArgs) Handles mnuSelectAll.Click
        SelectAllText()
    End Sub

    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        If TabControl.SelectedIndex = iTabIndexLog Then
            MsgBox("You can only undo from a script tab, not the log tab.", MsgBoxStyle.Exclamation, "Undo log tab")
            Exit Sub
        End If

        'Determine if last operation can be undone in text box.   
        If clsScriptActive.CanUndo Then
            clsScriptActive.Undo() 'Undo the last operation.
            EnableDisableButtons()
        End If
    End Sub

    Private Sub tabControl_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl.Selected
        Dim tabPageControls = TabControl.SelectedTab.Controls
        For Each control In tabPageControls
            If TypeOf control Is Scintilla Then
                clsScriptActive = DirectCast(control, Scintilla)

                'If tab contains script, then assume that latest script is not yet saved.
                'This is just to be on the safe side. It is not worth the extra complexity of
                'checking if the script is the same as the associated file name
                bIsTextChanged = clsScriptActive.TextLength > 0
                clsRScript = Nothing
                EnableDisableButtons()
                Exit Sub
            End If
        Next

        If IsNothing(clsScriptActive) Then
            MsgBox("Developer error: could not find editor window in tab.")
        End If
    End Sub

    Private Sub TabControl_DoubleClick(sender As Object, e As EventArgs) Handles TabControl.DoubleClick
        Dim rectangle = TabControl.GetTabRect(TabControl.SelectedIndex())
        rectangle = TabControl.RectangleToScreen(rectangle)
        rectangle = TabControl.Parent.RectangleToClient(rectangle)
        Dim textbox As New System.Windows.Forms.TextBox

        AddHandler textbox.Leave, AddressOf RenameTextboxLeave
        AddHandler textbox.KeyDown, AddressOf RenameTextboxKeyDown
        textbox.SetBounds(rectangle.Left, rectangle.Top, rectangle.Width, rectangle.Height)
        Me.Controls.Add(textbox)
        textbox.BringToFront()
        textbox.Focus()
    End Sub

    Private Sub RenameTextboxKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TabControl.SelectedTab.Text = sender.text
            'Move focus from the textbox - this will make it dispose
            TabControl.SelectedTab.Focus()
        End If
    End Sub

    Private Sub RenameTextboxLeave(sender As Object, e As EventArgs)
        TabControl.SelectedTab.Text = sender.text
        sender.Dispose()
    End Sub

End Class
