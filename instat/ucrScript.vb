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

    ''' <summary>
    ''' Enumeration to specify the type of script in the active tab.
    ''' </summary>
    Private Enum ScriptType
        json
        other
        quarto
        rScript
    End Enum

    ''' <summary>
    ''' Gets or sets the type of script for the current tab.
    ''' The value is stored in the active Scintilla control's Tag property.
    ''' We need to use the Tag property because we can have multiple tabs, each with
    ''' its own Scintilla control, and each tab can contain a different type of script.
    ''' We use this property to determine the type of script in the current tab,
    ''' so that we can set the correct lexer when loading a script from file, and also
    ''' so that we can enable/disable the buttons and context menu options correctly.
    ''' </summary>
    Private Property enumScriptType As ScriptType
        Get
            If clsScriptActive IsNot Nothing AndAlso clsScriptActive.Tag IsNot Nothing Then
                Return DirectCast(clsScriptActive.Tag, ScriptType)
            Else
                Return ScriptType.rScript ' Default value
            End If
        End Get
        Set(value As ScriptType)
            If clsScriptActive IsNot Nothing Then
                clsScriptActive.Tag = value
            End If
        End Set
    End Property

    Private ReadOnly Property isFindValid As Boolean
        Get
            Dim bScriptExists As Boolean = clsScriptActive.TextLength > 0
            Dim bTextSelected As Boolean = clsScriptActive.SelectedText.Length > 0

            Return bScriptExists AndAlso bTextSelected
        End Get
    End Property

    Private ReadOnly Property isReplaceValid As Boolean
        Get
            Dim bClipoardContainsText As Boolean = Clipboard.ContainsData(DataFormats.Text)
            Dim bIsScriptTab As Boolean = TabControl.SelectedIndex <> iTabIndexLog

            Return isFindValid AndAlso bIsScriptTab AndAlso bClipoardContainsText
        End Get
    End Property

    Friend WithEvents clsScriptActive As Scintilla
    Friend WithEvents clsScriptLog As Scintilla

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        SetupInitialLayout()

    End Sub

    Private Sub ucrScript_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim strRunStatementSelectionToolTip As String = "Run the current statement or selection. (Ctrl+Enter)"
        Dim strRunAllToolTip As String = "Run all the text in the tab. (Ctrl+Alt+R)"
        Dim strLoadToolTip As String = "Load from file into the current tab."
        Dim strSaveToolTip As String = "Save the contents of the current tab to a file."

        toolTipScriptWindow.SetToolTip(cmdRunStatementSelection, strRunStatementSelectionToolTip)
        toolTipScriptWindow.SetToolTip(cmdRunAll, strRunAllToolTip)
        toolTipScriptWindow.SetToolTip(cmdLoadScript, strLoadToolTip)
        toolTipScriptWindow.SetToolTip(cmdSave, strSaveToolTip)
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
        mnuRunCurrentStatementSelection.ToolTipText = strRunStatementSelectionToolTip
        mnuRunAllText.ToolTipText = strRunAllToolTip
        mnuOpenScriptasFile.ToolTipText = "Save file to log folder and open file in external editor."
        mnuLoadScriptFromFile.ToolTipText = strLoadToolTip
        mnuSaveScript.ToolTipText = strSaveToolTip
        mnuHelp.ToolTipText = "Display the Script Window help information."

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
    ''' the contents of the active tab to the specified file.
    ''' </summary>
    ''' <param name="bIsLog"> True if the tab to be saved is the log tab.</param>
    Public Sub SaveScript(bIsLog As Boolean)
        If Not bIsLog AndAlso TabControl.SelectedIndex = iTabIndexLog Then
            If TabControl.TabCount = 2 Then
                TabControl.SelectTab(1)
            Else
                MsgBox("No script tab selected. Please first select the tab of the script you wish to save.", vbExclamation, "Save Script")
                Exit Sub
            End If
        End If

        Using dlgSave As New SaveFileDialog

            Select Case enumScriptType
                Case ScriptType.json
                    dlgSave.Title = "Save To Json File"
                    dlgSave.Filter = "JSON File (*.json)|*.json"
                Case ScriptType.quarto
                    dlgSave.Title = "Save To Quarto File"
                    dlgSave.Filter = "Quarto File (*.qmd)|*.qmd"
                Case ScriptType.rScript
                    dlgSave.Title = If(bIsLog, "Save Log To R Script File", "Save To R Script File")
                    dlgSave.Filter = "R Script File (*.R)|*.R"
                Case Else
                    dlgSave.Title = "Save To Text File"
                    dlgSave.Filter = "Text File (*.txt)|*.txt"
            End Select

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
                    TabControl.SelectedTab.Text = If(enumScriptType = ScriptType.rScript,
                                                     Path.GetFileNameWithoutExtension(dlgSave.FileName),
                                                     Path.GetFileName(dlgSave.FileName))
                    frmMain.clsRecentItems.addToMenu(Replace(Path.Combine(Path.GetFullPath(strInitialDirectory), System.IO.Path.GetFileName(dlgSave.FileName)), "\", "/"))
                    frmMain.bDataSaved = True

                    If bIsLog Then
                        strInitialDirectoryLog = Path.GetDirectoryName(dlgSave.FileName)
                    Else
                        strInitialDirectory = Path.GetDirectoryName(dlgSave.FileName)
                    End If
                Catch
                    MsgBox("Could not save the " & If(bIsLog, "Log ", "") & "file." & Environment.NewLine &
                   "The file may be in use by another program or you may not have access to write to the specified location.",
                   vbExclamation, "Save " & If(bIsLog, "Log ", "") & "File.")
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
        clsScriptActive = New Scintilla With {
            .ContextMenuStrip = mnuContextScript,
            .Dock = DockStyle.Fill,
            .Location = New Point(3, 3),
            .Name = "txtScriptAdded",
            .Size = New Size(391, 409),
            .TabIndex = 14, 'TODO
            .TabWidth = 2
        }
        SetupScriptEditorR()
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
        Dim bIsRScript As Boolean = enumScriptType = ScriptType.rScript
        Dim bScriptExists As Boolean = clsScriptActive.TextLength > 0

        cmdRunStatementSelection.Enabled = bScriptExists AndAlso bIsRScript
        cmdRunAll.Enabled = bScriptExists AndAlso (bIsRScript OrElse enumScriptType = ScriptType.quarto)
        cmdLoadScript.Enabled = Not bIsLogTab
        cmdSave.Enabled = bScriptExists
        cmdInsert.Enabled = bIsRScript
        cmdRemoveTab.Enabled = TabControl.TabCount > 2 AndAlso Not bIsLogTab
        cmdClear.Enabled = bScriptExists AndAlso Not bIsLogTab
    End Sub

    ''' <summary>
    ''' Enables or disables the run buttons and all right click menu options
    ''' </summary>
    ''' <param name="bEnable">If true, enables buttons/options, else disables them</param>
    Private Sub EnableRunOptions(bEnable As Boolean)
        cmdRunStatementSelection.Enabled = bEnable
        cmdRunAll.Enabled = bEnable
        mnuRunCurrentStatementSelection.Enabled = bEnable
        mnuRunAllText.Enabled = bEnable
    End Sub

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''    Searches for the next occurrence of <paramref name="strTextToFind"/> in the active 
    '''    script and highlights it.
    ''' </summary>
    ''' <param name="strTextToFind"></param>
    ''' <returns>True if the active script contains at least one instance of 
    '''     <paramref name="strTextToFind"/>, else returns False</returns>
    '''--------------------------------------------------------------------------------------------
    Private Function FindAndHighlightNextOccurrence(strTextToFind As String) As Boolean

        Dim iCurrentCursorPosition As Integer = clsScriptActive.CurrentPosition
        Dim iNextOccurrencePosition As Integer = -1

        ' If cursor not at end of text, search from cursor position
        If iCurrentCursorPosition < clsScriptActive.Text.Length Then
            iNextOccurrencePosition = clsScriptActive.Text.IndexOf(strTextToFind, iCurrentCursorPosition + 1)
        End If

        ' If the text is not found, search from the beginning of the text
        If iNextOccurrencePosition = -1 Then
            iNextOccurrencePosition = clsScriptActive.Text.IndexOf(strTextToFind, 0)
        End If

        If iNextOccurrencePosition = -1 Then
            Return False
        End If

        clsScriptActive.GotoPosition(iNextOccurrencePosition)
        clsScriptActive.SetSelection(iNextOccurrencePosition, iNextOccurrencePosition + strTextToFind.Length)

        Return True
    End Function

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''    Searches for the previous occurrence of <paramref name="strTextToFind"/> in the active 
    '''    script and highlights it.
    ''' </summary>
    ''' <param name="strTextToFind"></param>
    ''' <returns>True if the active script contains at least one instance of 
    '''     <paramref name="strTextToFind"/>, else returns False</returns>
    '''--------------------------------------------------------------------------------------------
    Private Function FindAndHighlightPreviousOccurrence(strTextToFind As String) As Boolean

        Dim iCurrentCursorPosition As Integer = clsScriptActive.CurrentPosition
        Dim iPrevOccurrencePosition As Integer = -1

        ' If cursor not at start of text, search from cursor position
        If iCurrentCursorPosition > 0 Then
            iPrevOccurrencePosition = clsScriptActive.Text.LastIndexOf(strTextToFind, iCurrentCursorPosition - 1)
        End If

        ' If the text is not found, search from the end of the text
        If iPrevOccurrencePosition = -1 Then
            iPrevOccurrencePosition = clsScriptActive.Text.LastIndexOf(strTextToFind, clsScriptActive.Text.Length - 1)
        End If

        If iPrevOccurrencePosition = -1 Then
            Return False
        End If

        clsScriptActive.GotoPosition(iPrevOccurrencePosition)
        clsScriptActive.SetSelection(iPrevOccurrencePosition, iPrevOccurrencePosition + strTextToFind.Length)

        Return True
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
                               vbYesNo, "Load From File") = vbNo Then
            Exit Sub
        End If

        Using dlgLoad As New OpenFileDialog
            dlgLoad.Title = "Load From File"
            dlgLoad.Filter = "R Script, Quarto and Text Files (*.R;*.qmd;*.txt)|*.R;*.qmd;*.txt|" &
                             "R Script Files (*.R)|*.R|" &
                             "Quarto Files (*.qmd)|*.qmd|" &
                             "Text Files (*.txt)|*.txt|" &
                             "JSON Files (*.json)|*.json|" &
                             "All Files (*.*)|*.*"

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
                strInitialDirectory = Path.GetDirectoryName(dlgLoad.FileName)
                bIsTextChanged = False
                clsRScript = Nothing
                frmMain.clsRecentItems.addToMenu(Replace(Path.Combine(Path.GetFullPath(strInitialDirectory), System.IO.Path.GetFileName(dlgLoad.FileName)), "\", "/"))
                frmMain.bDataSaved = True

                ' Set enumScriptType based on file extension
                Dim strFileExtension As String = Path.GetExtension(dlgLoad.FileName).ToLower()
                Select Case strFileExtension
                    Case ".json"
                        enumScriptType = ScriptType.json
                        clsScriptActive.Lexer = Lexer.Json
                    Case ".qmd"
                        enumScriptType = ScriptType.quarto
                        SetupScriptEditorQuarto()
                    Case ".r"
                        enumScriptType = ScriptType.rScript
                        SetupScriptEditorR()
                    Case Else
                        enumScriptType = ScriptType.other
                        clsScriptActive.Lexer = Lexer.Null
                End Select
                TabControl.SelectedTab.Text = If(enumScriptType = ScriptType.rScript,
                                                 Path.GetFileNameWithoutExtension(dlgLoad.FileName),
                                                 Path.GetFileName(dlgLoad.FileName))
                EnableDisableButtons()
            Catch
                MsgBox("Could not load the script from file." & Environment.NewLine &
                       "The file may be in use by another program or you may not have access to read from the specified location.",
                       vbExclamation, "Load Script")
            End Try
        End Using

    End Sub

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

    Private Sub SetupScriptEditorQuarto()

        clsScriptActive.Lexer = Lexer.Markdown

        clsScriptActive.StyleResetDefault()
        clsScriptActive.Styles(Style.Default).Font = "Consolas"
        clsScriptActive.Styles(Style.Default).Size = 10

        clsScriptActive.StyleClearAll()
        clsScriptActive.Styles(Style.Markdown.Default).ForeColor = Color.Black

        clsScriptActive.Styles(Style.Markdown.BlockQuote).ForeColor = Color.Black
        clsScriptActive.Styles(Style.Markdown.Code).BackColor = Color.WhiteSmoke
        clsScriptActive.Styles(Style.Markdown.Code).ForeColor = Color.DimGray
        clsScriptActive.Styles(Style.Markdown.Code2).BackColor = Color.WhiteSmoke
        clsScriptActive.Styles(Style.Markdown.Code2).ForeColor = Color.DimGray
        clsScriptActive.Styles(Style.Markdown.OListItem).ForeColor = Color.Black
        clsScriptActive.Styles(Style.Markdown.Em1).ForeColor = Color.DodgerBlue
        clsScriptActive.Styles(Style.Markdown.Em2).ForeColor = Color.DarkBlue
        clsScriptActive.Styles(Style.Markdown.Header1).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.Header2).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.Header3).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.Header4).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.Header5).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.Header6).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.HRule).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.Markdown.Link).ForeColor = Color.DodgerBlue
        clsScriptActive.Styles(Style.Markdown.Strong1).ForeColor = Color.DodgerBlue
        clsScriptActive.Styles(Style.Markdown.Strong2).ForeColor = Color.DarkBlue
        clsScriptActive.Styles(Style.Markdown.UListItem).ForeColor = Color.Green

        clsScriptActive.Styles(Style.BraceLight).BackColor = Color.LightGray
        clsScriptActive.Styles(Style.BraceLight).ForeColor = Color.BlueViolet
        clsScriptActive.Styles(Style.BraceBad).ForeColor = Color.Red

        ' Note @lloyddewit 04/09/25: I am not sure that the remaining markdown styles are used in
        '     Quarto files . I decided to include them anyway and give then clear colours. So if a
        '     Quarto file does ever use them, then it should be easy to find the applicable style
        '     in the code and change to a more desirable colour.
        clsScriptActive.Styles(Style.Markdown.CodeBk).ForeColor = Color.Red
        clsScriptActive.Styles(Style.Markdown.LineBegin).ForeColor = Color.Orange
        clsScriptActive.Styles(Style.Markdown.PreChar).ForeColor = Color.Yellow
        clsScriptActive.Styles(Style.Markdown.Strikeout).ForeColor = Color.Violet
    End Sub

    Private Sub SetupScriptEditorR()

        clsScriptActive.Lexer = Lexer.R

        clsScriptActive.StyleResetDefault()
        clsScriptActive.Styles(Style.Default).Font = "Consolas"
        clsScriptActive.Styles(Style.Default).Size = 10

        'TODO  Configure from R-Instat options?
        'clsScript.Styles(Style.Default).Font = frmMain.clsInstatOptions.fntEditor.Name
        'clsScript.Styles(Style.Default).Size = frmMain.clsInstatOptions.fntEditor.Size

        ' Instruct the lexer to calculate folding
        clsScriptActive.SetProperty("fold", "1")
        clsScriptActive.SetProperty("fold.compact", "1")

        ' Configure a margin to display folding symbols
        clsScriptActive.Margins(2).Type = MarginType.Symbol
        clsScriptActive.Margins(2).Mask = Marker.MaskFolders
        clsScriptActive.Margins(2).Sensitive = True
        clsScriptActive.Margins(2).Width = 20

        ' Set colors for all folding markers
        For i As Integer = 25 To 31
            clsScriptActive.Markers(i).SetForeColor(SystemColors.ControlLightLight)
            clsScriptActive.Markers(i).SetBackColor(SystemColors.ControlDark)
        Next

        ' Configure folding markers with respective symbols
        clsScriptActive.Markers(Marker.Folder).Symbol = MarkerSymbol.BoxPlus
        clsScriptActive.Markers(Marker.FolderOpen).Symbol = MarkerSymbol.BoxMinus
        clsScriptActive.Markers(Marker.FolderEnd).Symbol = MarkerSymbol.BoxPlusConnected
        clsScriptActive.Markers(Marker.FolderMidTail).Symbol = MarkerSymbol.TCorner
        clsScriptActive.Markers(Marker.FolderOpenMid).Symbol = MarkerSymbol.BoxMinusConnected
        clsScriptActive.Markers(Marker.FolderSub).Symbol = MarkerSymbol.VLine
        clsScriptActive.Markers(Marker.FolderTail).Symbol = MarkerSymbol.LCorner

        ' Enable automatic folding
        clsScriptActive.AutomaticFold = AutomaticFold.Show Or AutomaticFold.Click Or AutomaticFold.Change

        clsScriptActive.IndentationGuides = IndentView.LookBoth
        clsScriptActive.StyleClearAll()
        clsScriptActive.Styles(Style.R.Default).ForeColor = Color.Silver
        clsScriptActive.Styles(Style.R.Comment).ForeColor = Color.Green
        clsScriptActive.Styles(Style.R.KWord).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.R.BaseKWord).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.R.OtherKWord).ForeColor = Color.Blue
        clsScriptActive.Styles(Style.R.Number).ForeColor = Color.Purple
        clsScriptActive.Styles(Style.R.String).ForeColor = Color.FromArgb(163, 21, 21)
        clsScriptActive.Styles(Style.R.String2).ForeColor = Color.FromArgb(163, 21, 21)
        clsScriptActive.Styles(Style.R.Operator).ForeColor = Color.Gray
        clsScriptActive.Styles(Style.R.Identifier).ForeColor = Color.Black
        clsScriptActive.Styles(Style.R.Infix).ForeColor = Color.Gray
        clsScriptActive.Styles(Style.R.InfixEol).ForeColor = Color.Gray
        clsScriptActive.Styles(Style.BraceLight).BackColor = Color.LightGray
        clsScriptActive.Styles(Style.BraceLight).ForeColor = Color.BlueViolet
        clsScriptActive.Styles(Style.BraceBad).ForeColor = Color.Red

        clsScriptActive.SetKeywords(0, "if else repeat while function for in next break TRUE FALSE NULL NA Inf NaN NA_integer_ NA_real_ NA_complex_ NA_character")

        'TODO if we want to set the key words for 'default package functions' (key word set 1) 
        ' and/or 'other package functions', then a good list is available at:
        '  https://raw.githubusercontent.com/moltenform/scite-files/master/files/files/api_files/r.properties  
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
        Dim bIsLogTab As Boolean = TabControl.SelectedIndex = iTabIndexLog
        Dim bIsRScript As Boolean = enumScriptType = ScriptType.rScript
        Dim bScriptExists As Boolean = clsScriptActive.TextLength > 0
        Dim bScriptSelected As Boolean = clsScriptActive.SelectedText.Length > 0

        mnuUndo.Enabled = clsScriptActive.CanUndo AndAlso Not bIsLogTab
        mnuRedo.Enabled = clsScriptActive.CanRedo AndAlso Not bIsLogTab
        mnuCut.Enabled = bScriptSelected AndAlso Not bIsLogTab
        mnuCopy.Enabled = bScriptSelected
        mnuPaste.Enabled = Clipboard.ContainsData(DataFormats.Text) AndAlso Not bIsLogTab
        mnuSelectAll.Enabled = bScriptExists
        mnuClear.Enabled = cmdClear.Enabled
        mnuFindNext.Enabled = isFindValid
        mnuFindPrev.Enabled = isFindValid
        mnuReplace.Enabled = isReplaceValid
        mnuReplaceAll.Enabled = isReplaceValid
        mnuRunCurrentStatementSelection.Enabled = cmdRunStatementSelection.Enabled
        mnuRunAllText.Enabled = cmdRunAll.Enabled
        mnuReformatCode.Enabled = bScriptExists AndAlso bIsRScript AndAlso Not bIsLogTab
        mnuOpenScriptasFile.Enabled = bScriptExists AndAlso bIsRScript
        mnuLoadScriptFromFile.Enabled = cmdLoadScript.Enabled
        mnuSaveScript.Enabled = cmdSave.Enabled
    End Sub

    Private Sub mnuContextScript_Closing(sender As Object, e As EventArgs) Handles mnuContextScript.Closing
        'On closing menu context, just enable all the menu options to restore their short cut keys
        'validations of the options actions is done by the functions that the events call.
        mnuUndo.Enabled = True
        mnuRedo.Enabled = True
        mnuCut.Enabled = True
        mnuCopy.Enabled = True
        mnuPaste.Enabled = True
        mnuSelectAll.Enabled = True
        mnuClear.Enabled = True
        mnuFindNext.Enabled = True
        mnuFindPrev.Enabled = True
        mnuReplace.Enabled = True
        mnuReplaceAll.Enabled = True
        mnuRunCurrentStatementSelection.Enabled = True
        mnuRunAllText.Enabled = True
        mnuReformatCode.Enabled = True
        mnuOpenScriptasFile.Enabled = True
        mnuLoadScriptFromFile.Enabled = True
        mnuSaveScript.Enabled = True
        mnuHelp.Enabled = True
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

    Private Sub mnuFindNext_Click(sender As Object, e As EventArgs) Handles mnuFindNext.Click
        If Not isFindValid Then
            Exit Sub
        End If

        ' Function will never return false when searching for the selected text,
        ' so ignore the return value
        FindAndHighlightNextOccurrence(clsScriptActive.SelectedText)
    End Sub

    Private Sub mnuFindPrev_Click(sender As Object, e As EventArgs) Handles mnuFindPrev.Click
        If Not isFindValid Then
            Exit Sub
        End If

        ' Function will never return false when searching for the selected text,
        ' so ignore the return value
        FindAndHighlightPreviousOccurrence(clsScriptActive.SelectedText)
    End Sub

    Private Sub mnuReplace_Click(sender As Object, e As EventArgs) Handles mnuReplace.Click
        If Not isReplaceValid Then
            Exit Sub
        End If

        Dim strSelectedTextOrigional As String = clsScriptActive.SelectedText
        clsScriptActive.ReplaceSelection(Clipboard.GetText())
        If Not FindAndHighlightNextOccurrence(strSelectedTextOrigional) Then
            MsgBox("No more occurrences found.", MsgBoxStyle.Information, "Replace")
        End If
    End Sub

    Private Sub mnuReplaceAll_Click(sender As Object, e As EventArgs) Handles mnuReplaceAll.Click
        If Not isReplaceValid Then
            Exit Sub
        End If
        ReplaceAll(clsScriptActive.SelectedText, Clipboard.GetText())
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
            TabControl.SelectedTab.Text = Path.GetFileNameWithoutExtension(strScriptFilename)
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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    '''    Returns the number of occurrences of <paramref name="strTextToFind"/> in the script.
    ''' </summary>
    ''' <param name="strTextToFind"></param>
    ''' <returns>the number of occurrences of <paramref name="strTextToFind"/> in the script</returns>
    '''--------------------------------------------------------------------------------------------
    Private Function NumOfOccurences(strTextToFind As String) As Integer
        If String.IsNullOrEmpty(strTextToFind) Then
            Return 0
        End If

        Dim strScriptText As String = clsScriptActive.Text
        Dim iCount As Integer = 0
        Dim iPosition As Integer = 0

        While iPosition <> -1
            iPosition = strScriptText.IndexOf(strTextToFind, iPosition)
            If iPosition <> -1 Then
                iCount += 1
                iPosition += strTextToFind.Length
            End If
        End While

        Return iCount
    End Function

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

    '''--------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Finds all occurrences of <paramref name="strFindText"/> in the script and replaces them all 
    ''' with <paramref name="strReplacementText"/>. Moves the caret to the start of the script and, 
    ''' if needed, scrolls the caret into view.
    ''' </summary>
    ''' <param name="strFindText"> The text to search for</param>
    ''' <param name="strReplacementText"> The new text to replace <paramref name="strFindText"/></param>
    '''--------------------------------------------------------------------------------------------
    Private Sub ReplaceAll(strFindText As String, strReplacementText As String)

        If String.IsNullOrEmpty(strFindText) Then
            MsgBox("The text to find cannot be empty.", MsgBoxStyle.Exclamation, "Replace All")
            Exit Sub
        End If

        Dim iCount As Integer = NumOfOccurences(strFindText)
        If iCount = 0 Then
            MsgBox("The text to find was not found in the document.", MsgBoxStyle.Information, "Replace All")
            Exit Sub
        End If

        Dim result As MsgBoxResult = MsgBox(
                $"Do you want to replace {iCount} occurrence(s) of the selected text?",
                vbYesNo + vbQuestion, "Replace All")
        If result = MsgBoxResult.No Then
            Exit Sub
        End If

        ' Replace all occurrences of the text to find with the replacement text
        Dim iPosition As Integer = 0
        clsScriptActive.BeginUndoAction()
        Try
            While iPosition <> -1
                iPosition = clsScriptActive.Text.IndexOf(strFindText, iPosition)
                If iPosition <> -1 Then
                    clsScriptActive.TargetStart = iPosition
                    clsScriptActive.TargetEnd = iPosition + strFindText.Length
                    clsScriptActive.ReplaceTarget(strReplacementText)
                    iPosition += strReplacementText.Length
                End If
            End While
        Finally
            clsScriptActive.EndUndoAction()
        End Try

        clsScriptActive.GotoPosition(0)
        clsScriptActive.ScrollCaret()
    End Sub

    Private Sub mnuReformatCode_Click(sender As Object, e As EventArgs) Handles mnuReformatCode.Click
        ' Exit early if no text is selected
        If clsScriptActive.SelectionStart = clsScriptActive.SelectionEnd Then
            Exit Sub
        End If

        ' Your R script text from Scintilla
        Dim scriptText As String = clsScriptActive.SelectedText.Replace("""", "\""")
        Dim clsStylerFunction As New RFunction

        clsStylerFunction.SetPackageName("styler")
        clsStylerFunction.SetRCommand("style_text")
        clsStylerFunction.AddParameter("text", Chr(34) & scriptText & Chr(34), bIncludeArgumentName:=False)

        Dim expTemp As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsStylerFunction.ToScript(), bSilent:=True)

        ' Check if the result from R is valid
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            ' If valid, format and replace the selected text
            Dim formattedCode As String() = expTemp.AsCharacter().ToArray
            Dim formattedText As String = String.Join(Environment.NewLine, formattedCode)
            clsScriptActive.ReplaceSelection(formattedText)
        End If
    End Sub

    Private Sub cmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click, toolStripMenuItemInsertStatement.Click
        dlgScript.ShowDialog()
    End Sub

    Private Sub toolStripMenuItemInsertCommentUncomment_Click(sender As Object, e As EventArgs) Handles toolStripMenuItemInsertCommentUncomment.Click
        Dim originalCaretPosition As Integer = clsScriptActive.CurrentPosition

        ' Get the start and end positions of the selected text
        Dim selectionStart As Integer = clsScriptActive.SelectionStart
        Dim selectionEnd As Integer = clsScriptActive.SelectionEnd

        ' Get the start and end lines of the selection
        Dim startLine As Integer = clsScriptActive.LineFromPosition(selectionStart)
        Dim endLine As Integer = clsScriptActive.LineFromPosition(selectionEnd)

        ' Begin updating text
        clsScriptActive.BeginUndoAction()

        Try
            ' Check if all lines are commented or not
            Dim allCommented As Boolean = True
            For lineIndex As Integer = startLine To endLine
                Dim lineText As String = clsScriptActive.Lines(lineIndex).Text.TrimStart()
                If Not lineText.StartsWith("#") Then
                    allCommented = False
                    Exit For
                End If
            Next

            ' Toggle comment status for each line
            For lineIndex As Integer = startLine To endLine
                Dim line As Line = clsScriptActive.Lines(lineIndex)
                Dim lineStartPos As Integer = line.Position
                Dim lineEndPos As Integer = lineStartPos + line.Length
                Dim lineText As String = line.Text
                Dim iCountSpace As Integer = System.Text.RegularExpressions.Regex.Matches(lineText, "#\s#").Count
                If iCountSpace > 0 Then iCountSpace += 1

                If allCommented Then
                    ' Set the target range to the matched text
                    clsScriptActive.TargetStart = lineStartPos
                    clsScriptActive.TargetEnd = lineStartPos + lineText.Count(Function(c) c = "#"c) + iCountSpace
                    ' Replace the target range with an empty string to remove the `#`
                    clsScriptActive.ReplaceTarget("")
                Else
                    ' Comment: Add `#` at the start
                    clsScriptActive.InsertText(lineStartPos, "# ")
                End If
            Next
        Finally
            clsScriptActive.EndUndoAction()
        End Try

        clsScriptActive.Focus()
        clsScriptActive.GotoPosition(originalCaretPosition)
    End Sub

End Class
