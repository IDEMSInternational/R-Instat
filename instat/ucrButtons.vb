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

Imports System.ComponentModel
Imports System.IO
Imports instat.Translations
Imports Newtonsoft.Json
Imports RInsightF461

Public Class ucrButtons
    ''' <summary>
    ''' Specifies the type of information required when calling <see cref="GetText([Enum])"/>.
    ''' </summary>
    Public Enum EnumTextType
        comment
        isComment
    End Enum

    Public Shadows clsRsyntax As RSyntax

    Public iHelpTopicID As Integer
    Public bFirstLoad As Boolean

    ''' <summary>
    ''' When set to true, scripts will be appended at the current cursor position of the script window
    ''' When set to false, scripts will appended at the below the last script in the script window
    ''' </summary>
    Public bAppendScriptsAtCurrentScriptWindowCursorPosition As Boolean = False
    Public bAddScriptToScriptWindowOnClickOk As Boolean = True
    Public bMakeVisibleScriptWindow As Boolean = True

    Public strDialogName = ""
    Public dctConfigurableValues As New Dictionary(Of String, String)
    Public lstTransformToScript As New List(Of clsTransformationRModel)
    Public lstTransformFromControl As New List(Of clsTransformationControl)

    Public Event BeforeClickOk(sender As Object, e As EventArgs)
    Public Event ClickOk(sender As Object, e As EventArgs)
    Public Event ClickReset(sender As Object, e As EventArgs)
    Public Event ClickClose(sender As Object, e As EventArgs)
    Private strCurrLang As String
    Private bCommentChangedInThisDialog, bLoadInProgress As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsRsyntax = New RSyntax
        iHelpTopicID = -1
        bFirstLoad = True
    End Sub

    ''' <summary>
    '''  Returns information about the dialog comment as specified by <paramref name="enumTextType"/>.
    '''  If <paramref name="enumTextType"/> is not specified, returns the comment text.
    ''' </summary>
    ''' <param name="enumTextType"></param>
    ''' <returns>The comment information specified by <paramref name="enumTextType"/>: either the 
    ''' comment text; or the state of the comment check box ("TRUE" or "FALSE").</returns>
    Public Overrides Function GetText(Optional enumTextType As [Enum] = Nothing) As String
        If enumTextType Is Nothing Then
            enumTextType = ucrButtons.EnumTextType.comment
        End If

        Dim textType As EnumTextType
        Try
            textType = DirectCast(enumTextType, EnumTextType)
        Catch ex As InvalidCastException
            Throw New InvalidCastException("Invalid text type requested from buttons.")
        End Try

        Select Case textType
            Case ucrButtons.EnumTextType.comment
                ' Split the comment into lines
                Dim lines As String() = txtComment.Text.Split(New String() {vbCrLf, vbCr, vbLf},
                                                              StringSplitOptions.RemoveEmptyEntries)

                ' Prepend "# " to each line that is not just whitespace, ignore blank lines
                Dim strComment As String = ""
                For i As Integer = 0 To lines.Length - 1
                    strComment &= "# " & lines(i) & vbCrLf
                Next

                Return strComment & vbCrLf

            Case ucrButtons.EnumTextType.isComment
                Return If(chkComment.Checked, "TRUE", "FALSE")
        End Select

        Throw New InvalidEnumArgumentException("Unhandled text type requested from buttons.")
    End Function

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.ParentForm.Close()
        RaiseEvent ClickClose(sender, e)
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        SetDefaults()
        RaiseEvent ClickReset(sender, e)
    End Sub

    '"Ok", "Ok and Close" and "Ok and Keep" Click event 
    Private Sub Ok_Click(sender As Object, e As EventArgs) Handles cmdOk.Click, toolStripMenuItemOkClose.Click, toolStripMenuItemOkKeep.Click
        OnScriptButtonsClick(sender, e, bAddScriptToScriptWindowOnClickOk, Not sender Is toolStripMenuItemOkKeep)
    End Sub

    '"To Script", "To Script and Close" and "To Script and Keep" Click event 
    Private Sub ToScript_Click(sender As Object, e As EventArgs) Handles cmdPaste.Click, toolStripMenuItemToScriptClose.Click, toolStripMenuItemToScriptKeep.Click
        OnScriptButtonsClick(sender, e, False, Not sender Is toolStripMenuItemToScriptKeep)
        frmMain.mnuViewLogScript.Checked = True
    End Sub

    Private Sub txtComment_TextChanged(sender As Object, e As EventArgs) Handles txtComment.TextChanged
        ' only set the flag if the user changes the text (not when the dialog is loading)
        If Not bLoadInProgress Then
            bCommentChangedInThisDialog = True
        End If
    End Sub

    Private Sub OnScriptButtonsClick(sender As Object, e As EventArgs, bExecuteScripts As Boolean, bCloseForm As Boolean)
        Dim lstCurrentEnabled As New List(Of Boolean)
        Dim ctrTempControl As Control
        Dim j As Integer

        'this is getting the current controls on the form and disables then to prevent user to interract with form when its running
        For Each ctrTempControl In ParentForm.Controls
            lstCurrentEnabled.Add(ctrTempControl.Enabled)
            ctrTempControl.Enabled = False
        Next
        ParentForm.Cursor = Cursors.WaitCursor

        RaiseEvent BeforeClickOk(sender, e)
        Scripts(bRun:=bExecuteScripts)
        RaiseEvent ClickOk(sender, e)

        'Need to be resetting other AssignTo values as well, maybe through single method

        'Warning: these reinitializing processes of the RSyntax parameters should probably be integrated at the end of GetScript. 
        'However, for the moment, RSyntax is not playing it's role of capturing the whole set of R-commands that the user wants to run when OK is Cklicked. 
        'Indeed, the events BeforeClickOk and ClickOk enables for the moment to insert R-commands before and after the Base R-command handle. 
        'In the process, we want the RSyntax parameters to be set as at the end of GetScript. Hence the reset needs to come after.
        'Eventually, all this should be more neatly incorporated in the RSyntax machinery...

        j = 0
        For Each ctrTempControl In ParentForm.Controls
            ctrTempControl.Enabled = lstCurrentEnabled(j)
            j = j + 1
        Next
        ParentForm.Cursor = Cursors.Default

        If bCloseForm Then
            ParentForm.Close()
        End If
    End Sub

    Private Sub Scripts(bRun As Boolean)
        If Not frmMain.ucrScriptWindow.IsScriptTabSelected() Then
            Exit Sub
        End If

        Dim strComment, strComments As String
        Dim lstBeforeScripts As List(Of String)
        Dim lstAfterScripts As List(Of String)
        Dim lstBeforeCodes As List(Of RCodeStructure)
        Dim lstAfterCodes As List(Of RCodeStructure)
        Dim bFirstCode As Boolean = True
        Dim clsRemoveFunc As New RFunction
        Dim clsRemoveListFun As New RFunction
        Dim lstAssignToCodes As New List(Of RCodeStructure) 'todo. remove after refactoring GetAllAssignTo
        Dim lstAssignToStrings As New List(Of String)
        Dim strExpected As String = ""

        'rm is the R function to remove the created objects from the memory at the end of the script and c is the function that puts them together in a list
        clsRemoveFunc.SetRCommand("rm")
        clsRemoveListFun.SetRCommand("c")

        'this sets the comment for the script
        If chkComment.Checked Then
            strComments = txtComment.Text
        Else
            strComments = ""
        End If
        If Not bRun AndAlso strComments <> "" Then
            strExpected &= frmMain.clsRLink.GetFormattedComment(strComments) & Environment.NewLine & vbLf
            frmMain.AddToScriptWindow(frmMain.clsRLink.GetFormattedComment(strComments) & Environment.NewLine, bMakeVisible:=bMakeVisibleScriptWindow, bAppendAtCurrentCursorPosition:=bAppendScriptsAtCurrentScriptWindowCursorPosition)
        End If

        'Get this list before doing ToScript then no need for global variable name
        clsRsyntax.GetAllAssignTo(lstAssignToCodes, lstAssignToStrings)

        'Run additional before codes
        lstBeforeCodes = clsRsyntax.GetBeforeCodes()
        lstBeforeScripts = clsRsyntax.GetScriptsFromCodeList(lstBeforeCodes)
        For i As Integer = 0 To lstBeforeCodes.Count - 1
            If bFirstCode Then
                strComment = strComments
                bFirstCode = False
            Else
                strComment = ""
            End If
            If bRun Then
                frmMain.clsRLink.RunScript(lstBeforeScripts(i), iCallType:=lstBeforeCodes(i).iCallType, strComment:=strComment, bSeparateThread:=clsRsyntax.bSeparateThread)
            Else
                strExpected &= lstBeforeScripts(i) & vbLf
                frmMain.AddToScriptWindow(lstBeforeScripts(i), bMakeVisible:=bMakeVisibleScriptWindow, bAppendAtCurrentCursorPosition:=bAppendScriptsAtCurrentScriptWindowCursorPosition)
            End If
        Next

        'Run base code from RSyntax
        If bRun Then
            If bFirstCode Then
                strComment = strComments
                bFirstCode = False
            Else
                strComment = ""
            End If
            frmMain.clsRLink.RunScript(clsRsyntax.GetScript(), clsRsyntax.iCallType, strComment:=strComment, bSeparateThread:=clsRsyntax.bSeparateThread)
        Else
            strExpected &= clsRsyntax.GetScript() & vbLf
            frmMain.AddToScriptWindow(clsRsyntax.GetScript(), bMakeVisible:=bMakeVisibleScriptWindow, bAppendAtCurrentCursorPosition:=bAppendScriptsAtCurrentScriptWindowCursorPosition)
        End If

        'Run additional after codes
        lstAfterCodes = clsRsyntax.GetAfterCodes()
        lstAfterScripts = clsRsyntax.GetScriptsFromCodeList(lstAfterCodes)
        For i As Integer = 0 To lstAfterCodes.Count - 1
            If bRun Then
                If bFirstCode Then
                    strComment = strComments
                    bFirstCode = False
                Else
                    strComment = ""
                End If
                frmMain.clsRLink.RunScript(lstAfterScripts(i), iCallType:=lstAfterCodes(i).iCallType, strComment:=strComment, bSeparateThread:=clsRsyntax.bSeparateThread, bShowWaitDialogOverride:=clsRsyntax.bShowWaitDialogOverride)
            Else
                strExpected &= lstAfterScripts(i) & vbLf
                frmMain.AddToScriptWindow(lstAfterScripts(i), bMakeVisible:=bMakeVisibleScriptWindow, bAppendAtCurrentCursorPosition:=bAppendScriptsAtCurrentScriptWindowCursorPosition)
            End If
        Next

        'Clear variables from global environment
        'TODO check that this line could be removed
        clsRemoveFunc.ClearParameters()
        'remove any duplicate set assign to. This gets unique set assign to object names to remove
        lstAssignToStrings = lstAssignToStrings.Distinct().ToList
        'TODO remove assign to instat object
        'lstAssignToStrings.RemoveAll(Function(x) x = frmMain.clsRLink.strInstatDataObject)
        If lstAssignToStrings.Count = 1 Then
            'Don't want to remove the Instat Object if it's been assigned
            clsRemoveFunc.AddParameter("x1", lstAssignToStrings(0), bIncludeArgumentName:=False)
        ElseIf lstAssignToStrings.Count > 1 Then
            For i As Integer = 0 To lstAssignToStrings.Count - 1
                clsRemoveListFun.AddParameter(i, Chr(34) & lstAssignToStrings(i) & Chr(34), bIncludeArgumentName:=False)
            Next
            clsRemoveFunc.AddParameter("list", clsRFunctionParameter:=clsRemoveListFun)
        End If

        If clsRemoveFunc.clsParameters.Count > 0 Then
            If bRun Then
                frmMain.clsRLink.RunScript(clsRemoveFunc.ToScript(), iCallType:=0)
            Else
                strExpected &= clsRemoveFunc.ToScript()
                frmMain.AddToScriptWindow(clsRemoveFunc.ToScript(), bMakeVisible:=bMakeVisibleScriptWindow, bAppendAtCurrentCursorPosition:=bAppendScriptsAtCurrentScriptWindowCursorPosition)
            End If
        End If

        CreateRScriptUsingXpBackEnd(strExpected)

    End Sub

    Public Sub OKEnabled(bEnabled As Boolean)
        cmdOk.Enabled = bEnabled
        cmdPaste.Enabled = bEnabled
    End Sub

    Private Sub ucrButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bLoadInProgress = True
        If frmMain.clsRecentItems IsNot Nothing Then
            frmMain.clsRecentItems.addToMenu(Me.Parent)
        End If
        If bFirstLoad Then
            'TODO. Temp this could be done on the designer
            txtComment.Multiline = True
            AddButtonInCommentTextbox()
            SetDefaults()
            bFirstLoad = False
        ElseIf Not bCommentChangedInThisDialog Then
            ' If the comment was not set specifically for this dialog, then reset to the Instat 
            ' option comment. We need to do this in case the instat option comment changed since 
            ' we last opened this dialog, e.g. by switching from English to French.
            ResetCommentToInstatOptionComment()
        End If
        If frmMain.clsInstatOptions IsNot Nothing Then
            If frmMain.clsInstatOptions.strLanguageCultureCode <> "en-GB" Then
                cmdHelp.Width = cmdOk.Width / 2
                cmdLanguage.Visible = True
            Else
                cmdHelp.Width = cmdOk.Width
                cmdLanguage.Visible = False
            End If
            strCurrLang = frmMain.clsInstatOptions.strLanguageCultureCode
        End If
        bLoadInProgress = False
    End Sub

    Private Sub SetDefaults()
        If frmMain.clsInstatOptions IsNot Nothing Then
            chkComment.Checked = frmMain.clsInstatOptions.bIncludeCommentDefault
        Else
            chkComment.Checked = True
        End If
        SetCommentEditable()
        ResetCommentToInstatOptionComment()
    End Sub

    ''' <summary>
    ''' Creates the R script using the cross-platform backend. 
    ''' Writes both <paramref name="strExpected"/> and the cross-platform backend R script to the 
    ''' Desktop (in tmp/expected.R and tmp/actual.R respectively). These files are for testing 
    ''' the cross-platform backend.
    ''' </summary>
    ''' <param name="strExpected"> The R script generated using the classic approach.</param>
    Private Sub CreateRScriptUsingXpBackEnd(strExpected As String)
        If String.IsNullOrEmpty(strDialogName) Then
            Exit Sub
        End If

        'update the configurable values from the current state of the controls
        For Each transform As clsTransformationControl In lstTransformFromControl
            transform.UpdateConfigurableValue(dctConfigurableValues)
        Next

        'build the R model from the R script
        Dim strDialogPathStem As String = Path.Combine(frmMain.strStaticPath & "\DialogDefinitions\Dlg" + strDialogName + "\dlg" + strDialogName)
        Dim strScriptReset = File.ReadAllText(strDialogPathStem + ".R")
        Dim rScript As RScript = New RScript(strScriptReset)

        'update the R model from the configurable values
        Dim strTransformationsRJson As String = File.ReadAllText(strDialogPathStem + ".json")
        lstTransformToScript = JsonConvert.DeserializeObject(Of List(Of clsTransformationRModel))(strTransformationsRJson)
        For Each transform As clsTransformationRModel In lstTransformToScript
            transform.updateRModel(rScript, dctConfigurableValues)
        Next

        'write the expected script (script built from RSyntax classes)
        Dim strDesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim strFilePath As String = Path.Combine(strDesktopPath, "tmp", "expected.R")
        strExpected = vbLf & vbLf & vbLf & strExpected
        If File.Exists(strFilePath) Then
            File.AppendAllText(strFilePath, strExpected)
        Else
            Directory.CreateDirectory(Path.GetDirectoryName(strFilePath))
            File.WriteAllText(strFilePath, strExpected)
        End If

        'write the actual script (script built from the R model)
        Dim strActual As String = rScript.GetAsExecutableScript()
        strFilePath = Path.Combine(strDesktopPath, "tmp", "actual.R")
        strActual = vbLf & vbLf & vbLf & strActual
        If File.Exists(strFilePath) Then
            File.AppendAllText(strFilePath, strActual)
        Else
            Directory.CreateDirectory(Path.GetDirectoryName(strFilePath))
            File.WriteAllText(strFilePath, strActual)
        End If

        'todo
        WriteUISpec()
    End Sub

    Private Sub ResetCommentToInstatOptionComment()
        If frmMain.clsInstatOptions IsNot Nothing Then
            txtComment.Text = Translations.GetTranslation(frmMain.clsInstatOptions.strComment) _
                              & " " & Translations.GetTranslation(ParentForm.Text)
        Else
            txtComment.Text = Translations.GetTranslation(ParentForm.Text)
        End If
        bCommentChangedInThisDialog = False
    End Sub

    Private Sub chkComment_CheckedChanged(sender As Object, e As EventArgs) Handles chkComment.CheckedChanged
        SetCommentEditable()
    End Sub

    Private Sub SetCommentEditable()
        txtComment.Enabled = chkComment.Checked
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        HelpContent()
    End Sub

    Private Sub HelpContent()
        If iHelpTopicID > 0 Then
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpTopicID.ToString())
        Else
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        End If
    End Sub

    Private Sub cmdLanguage_Click(sender As Object, e As EventArgs) Handles cmdLanguage.Click

        If strCurrLang <> "en-GB" Then
            strCurrLang = "en-GB"
        Else
            strCurrLang = frmMain.clsInstatOptions.strLanguageCultureCode
        End If

        Dim strConfiguredLanguage As String = frmMain.clsInstatOptions.strLanguageCultureCode
        frmMain.clsInstatOptions.strLanguageCultureCode = strCurrLang
        autoTranslate(Me.ParentForm)
        ' If the comment was not set specifically for this dialog, then translate to toggled language
        If Not bCommentChangedInThisDialog Then
            ResetCommentToInstatOptionComment()
        End If
        frmMain.clsInstatOptions.strLanguageCultureCode = strConfiguredLanguage

        If cmdLanguage.FlatStyle = FlatStyle.Popup Then
            cmdLanguage.FlatStyle = FlatStyle.Flat
        Else
            cmdLanguage.FlatStyle = FlatStyle.Popup
        End If
    End Sub

    Private Sub AddButtonInCommentTextbox()
        Dim btnMoreComment As New Button
        'add the button to the comment textbox first
        txtComment.Controls.Clear()
        txtComment.Controls.Add(btnMoreComment)

        'then set the  button properties
        btnMoreComment.Text = ":::" 'temp. This will be shown as centered ... An image as below commended code is preferred
        'btn.Image = Image.FromFile("C:\patowhiz\3dots.png")
        btnMoreComment.Size = New Size(25, txtComment.ClientSize.Height + 2)
        btnMoreComment.TextAlign = ContentAlignment.TopCenter
        btnMoreComment.FlatStyle = FlatStyle.Standard
        btnMoreComment.FlatAppearance.BorderSize = 0
        btnMoreComment.Cursor = Cursors.Default
        btnMoreComment.Dock = DockStyle.Right
        btnMoreComment.BackColor = cmdOk.BackColor
        btnMoreComment.UseVisualStyleBackColor = True

        'set the btn event handler
        AddHandler btnMoreComment.Click, Sub()
                                             'shows a popup that displays the additional comments
                                             Dim frmPopup As New Form
                                             Dim txtPopupComment As New TextBox
                                             frmPopup.ShowInTaskbar = False
                                             frmPopup.FormBorderStyle = FormBorderStyle.None
                                             frmPopup.Size = New Size(txtComment.Width, 120)
                                             frmPopup.Controls.Add(txtPopupComment)
                                             'Set the text properties
                                             txtPopupComment.Dock = DockStyle.Fill
                                             txtPopupComment.Multiline = True
                                             txtPopupComment.ScrollBars = ScrollBars.Vertical
                                             txtPopupComment.WordWrap = False

                                             AddHandler txtPopupComment.LostFocus, Sub()
                                                                                       txtComment.Text = txtPopupComment.Text
                                                                                       frmPopup.Close()
                                                                                   End Sub
                                             AddHandler txtPopupComment.KeyDown, Sub(sender As Object, e As KeyEventArgs)
                                                                                     If e.Control AndAlso e.KeyCode = Keys.Enter Then
                                                                                         txtComment.Text = txtPopupComment.Text
                                                                                         frmPopup.Close()
                                                                                     End If
                                                                                 End Sub

                                             Dim ctlpos As Point = txtComment.PointToScreen(New Point(0, 0)) 'Point.Empty is not function so use Point(0, 0)
                                             frmPopup.StartPosition = FormStartPosition.Manual 'set it to manual
                                             'if user wanted below the control. Left here for future reference
                                             'sdgComment.Location = New Point(ctlpos.X - 2, ctlpos.Y + txtComment.Height - 2) 'then locate its position
                                             frmPopup.Location = New Point(ctlpos.X - 2, ctlpos.Y - frmPopup.Height - 2) 'set location to show the form just above the examples button
                                             frmPopup.Show()
                                             txtPopupComment.Text = txtComment.Text
                                             txtPopupComment.SelectionStart = txtPopupComment.TextLength
                                         End Sub

    End Sub

    'todo reposition and review functions below

    ''' <summary>
    ''' Loads the dialog's transformation JSON, builds a UIElement tree, outputs it, and removes duplicate nodes in each branch,
    ''' but does not remove a node if it has children.
    ''' </summary>
    Private Sub WriteUISpec()
        ' Load and deserialize the transformation JSON
        Dim strDialogPathStem As String = Path.Combine(frmMain.strStaticPath & "\DialogDefinitions\Dlg" + strDialogName + "\dlg" + strDialogName)
        Dim strTransformationsRJson As String = File.ReadAllText(strDialogPathStem + ".json")
        lstTransformToScript = JsonConvert.DeserializeObject(Of List(Of clsTransformationRModel))(strTransformationsRJson)

        ' Build the initial UIElement tree
        Dim rootElement As New UIElement("Root")
        For Each model In lstTransformToScript
            Dim element = BuildUIElementTree(model)
            If element IsNot Nothing Then
                rootElement.lstChildren.Add(element)
            End If
        Next

        Dim strElementTree As String = vbLf & vbLf & "Before duplicate removal:" & vbLf & vbLf
        strElementTree += OutputUIElementTree(rootElement, 0)

        ' Remove siblings in each branch
        Dim rootElementNoDuplicateSiblings = GetUIElementNoDuplicateSiblings(rootElement)
        strElementTree += vbLf & vbLf & "After duplicate sibling removal:" & vbLf & vbLf
        strElementTree += OutputUIElementTree(rootElementNoDuplicateSiblings, 0)

        ' Remove duplicates in each branch
        Dim rootElementNoDuplicateBranches = GetUIElementNoDuplicateBranches(rootElementNoDuplicateSiblings, New HashSet(Of String)(StringComparer.OrdinalIgnoreCase))
        strElementTree += vbLf & vbLf & "After duplicate branch removal:" & vbLf & vbLf
        strElementTree += OutputUIElementTree(rootElementNoDuplicateBranches, 0)

        ' If there are duplicates in different branches, then add duplicates to LCA (Lowest Common Ancestor)
        Dim rootElementDuplicatesInLca As UIElement = GetUIElementAddDuplicatesToLca(rootElementNoDuplicateBranches) ' updated variable name here
        strElementTree += vbLf & vbLf & "After adding duplicates to Lowest Common Ancestor (LCA):" & vbLf & vbLf
        strElementTree += OutputUIElementTree(rootElementDuplicatesInLca, 0)

        ' Write the element tree to a file on the desktop
        Dim strDesktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim strFilePath As String = Path.Combine(strDesktopPath, "tmp", "elementTree.txt")
        If File.Exists(strFilePath) Then
            File.AppendAllText(strFilePath, strElementTree)
        Else
            Directory.CreateDirectory(Path.GetDirectoryName(strFilePath))
            File.WriteAllText(strFilePath, strElementTree)
        End If

    End Sub

    Private Function GetUIElementNoDuplicateSiblings(element As UIElement) As UIElement
        If element Is Nothing Then Return Nothing

        ' Process children and remove duplicates among siblings
        Dim seenSignatures As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim newChildren As New List(Of UIElement)
        For Each child In element.lstChildren
            Dim cleanedChild = GetUIElementNoDuplicateSiblings(child)
            If cleanedChild IsNot Nothing AndAlso Not seenSignatures.Contains(cleanedChild.strSignature) Then
                seenSignatures.Add(cleanedChild.strSignature)
                newChildren.Add(cleanedChild)
            End If
        Next

        ' Create a new node to avoid mutating the original
        Dim newElement As New UIElement(element.strElementName)
        newElement.lstChildren = newChildren
        Return newElement
    End Function

    Private Function GetUIElementNoDuplicateBranches(element As UIElement, signaturesInBranch As HashSet(Of String)) As UIElement
        If element Is Nothing Then Return Nothing

        ' If this strSignature has already been seen in this branch, remove this node
        If signaturesInBranch.Contains(element.strSignature) Then
            Return Nothing
        End If

        ' Add this node's strSignature to the set for this branch
        Dim newSignaturesInBranch = New HashSet(Of String)(signaturesInBranch, StringComparer.OrdinalIgnoreCase)
        newSignaturesInBranch.Add(element.strSignature)

        ' Recurse for children
        Dim newChildren As New List(Of UIElement)
        For Each child In element.lstChildren
            Dim childNoDuplicate = GetUIElementNoDuplicateBranches(child, newSignaturesInBranch)
            If childNoDuplicate IsNot Nothing Then
                newChildren.Add(childNoDuplicate)
            End If
        Next

        ' Create a new node to avoid mutating the original
        Dim newElement As New UIElement(element.strElementName)
        newElement.lstChildren = newChildren
        Return newElement
    End Function

    ''' <summary>
    ''' Returns a new UIElement tree that is the same as the input, but with extra nodes added:
    ''' For each duplicate strSignature found during traversal, the duplicate node is also added as a child of the Lowest Common Ancestor (LCA) of the two nodes.
    ''' </summary>
    Private Function GetUIElementAddDuplicatesToLca(element As UIElement) As UIElement
        If element Is Nothing Then Return Nothing

        ' Step 1: Traverse and record all paths to each strSignature
        Dim signatureToPaths As New Dictionary(Of String, List(Of List(Of UIElement)))(StringComparer.OrdinalIgnoreCase)
        RecordSignaturePaths(element, New List(Of UIElement), signatureToPaths)

        ' Step 2: Clone the tree so we can add nodes without mutating the original
        Dim cloneMap As New Dictionary(Of UIElement, UIElement)
        Dim newRoot As UIElement = CloneTree(element, cloneMap)

        ' Step 3: For each strSignature with more than one occurrence, add duplicates to the LCA
        For Each kvp In signatureToPaths
            Dim signature = kvp.Key
            Dim paths = kvp.Value
            If paths.Count > 1 Then
                ' For each pair of duplicate nodes, add the duplicate to the LCA
                For i As Integer = 0 To paths.Count - 2
                    For j As Integer = i + 1 To paths.Count - 1
                        Dim path1 = paths(i)
                        Dim path2 = paths(j)
                        Dim node1 = path1.Last()
                        Dim node2 = path2.Last()
                        Dim lca = FindLCAFromPaths(New List(Of List(Of UIElement)) From {path1, path2})
                        If lca IsNot Nothing Then
                            Dim lcaClone = FindNodeByPath(newRoot, path1, cloneMap, upToLca:=lca)
                            Dim nodeToAdd = CloneSubtree(cloneMap(node2))
                            ' Only add if not already present (by reference or by signature)
                            If Not lcaClone.lstChildren.Any(Function(child) child.strSignature = nodeToAdd.strSignature) Then
                                lcaClone.lstChildren.Add(nodeToAdd)
                            End If
                        End If
                    Next
                Next
            End If
        Next

        Return newRoot
    End Function

    ''' <summary>
    ''' Recursively records all paths to each node by strSignature.
    ''' </summary>
    Private Sub RecordSignaturePaths(node As UIElement, path As List(Of UIElement), signatureToPaths As Dictionary(Of String, List(Of List(Of UIElement))))
        If node Is Nothing Then Return
        Dim newPath = New List(Of UIElement)(path) From {node}
        If Not String.IsNullOrEmpty(node.strSignature) Then
            If Not signatureToPaths.ContainsKey(node.strSignature) Then
                signatureToPaths(node.strSignature) = New List(Of List(Of UIElement))()
            End If
            signatureToPaths(node.strSignature).Add(newPath)
        End If
        For Each child In node.lstChildren
            RecordSignaturePaths(child, newPath, signatureToPaths)
        Next
    End Sub

    ''' <summary>
    ''' Finds the LCA node in the clone tree, given a path and the original LCA node.
    ''' </summary>
    Private Function FindNodeByPath(root As UIElement, path As List(Of UIElement), cloneMap As Dictionary(Of UIElement, UIElement), Optional upToLca As UIElement = Nothing) As UIElement
        If path Is Nothing OrElse path.Count = 0 Then Return Nothing
        Dim current As UIElement = root
        For i As Integer = 1 To path.Count - 1 ' skip root (already at root)
            If upToLca IsNot Nothing AndAlso path(i - 1) Is upToLca Then
                Exit For
            End If
            Dim nextName = path(i).strElementName
            current = current.lstChildren.FirstOrDefault(Function(child) child.strElementName = nextName)
            If current Is Nothing Then Exit For
        Next
        Return current
    End Function

    ''' <summary>
    ''' Clones a subtree (deep copy) of a UIElement node.
    ''' </summary>
    Private Function CloneSubtree(node As UIElement) As UIElement
        If node Is Nothing Then Return Nothing
        Dim newNode As New UIElement(node.strElementName)
        For Each child In node.lstChildren
            Dim newChild = CloneSubtree(child)
            If newChild IsNot Nothing Then
                newNode.lstChildren.Add(newChild)
            End If
        Next
        Return newNode
    End Function

    ''' <summary>
    ''' Recursively builds a UIElement tree from a clsTransformationRModel tree.
    ''' </summary>
    Private Function BuildUIElementTree(model As clsTransformationRModel) As UIElement
        If model Is Nothing Then Return Nothing

        ' Only create a UIElement if strValueKey is not null or empty
        If String.IsNullOrEmpty(model.strValueKey) AndAlso (model.lstTransformations Is Nothing OrElse model.lstTransformations.Count = 0) Then
            Return Nothing
        End If

        Dim strElementName As String = model.strValueKey
        strElementName += If(model.enumTransformationType = clsTransformationRModel.TransformationType.ifFalseExecuteChildTransformations, " F", "")
        Dim element As New UIElement(strElementName)
        If model.lstTransformations IsNot Nothing Then
            For Each child In model.lstTransformations
                Dim childElement = BuildUIElementTree(child)
                If childElement IsNot Nothing Then
                    element.lstChildren.Add(childElement)
                End If
            Next
        End If
        Return element
    End Function

    ''' <summary>
    ''' Returns a new UIElement tree with duplicates removed. A node is considered a duplicate if:
    ''' - Its strElementName has already appeared in the current branch, and
    ''' - Its child tree is identical (structure and strElementName) to another node with the same strElementName in the same branch.
    ''' </summary>
    Private Function GetUIElementNoDuplicates(element As UIElement, elementNamesAlreadyInParentBranch As HashSet(Of String), level As Integer) As UIElement
        If element Is Nothing OrElse String.IsNullOrEmpty(element.strElementName) Then Return Nothing

        ' Track all seen nodes with the same strElementName in this branch, along with their child trees
        Static branchSeen As New Dictionary(Of Integer, Dictionary(Of String, List(Of UIElement)))
        If Not branchSeen.ContainsKey(level) Then
            branchSeen(level) = New Dictionary(Of String, List(Of UIElement))(StringComparer.OrdinalIgnoreCase)
        End If

        Dim seenAtThisLevel = branchSeen(level)
        Dim isDuplicate As Boolean = False

        If seenAtThisLevel.ContainsKey(element.strElementName) Then
            For Each seenNode In seenAtThisLevel(element.strElementName)
                If AreChildTreesIdentical(element, seenNode) Then
                    isDuplicate = True
                    Exit For
                End If
            Next
        End If

        If isDuplicate Then
            Return Nothing
        End If

        ' Add this node to the seen list for this strElementName at this level
        If Not seenAtThisLevel.ContainsKey(element.strElementName) Then
            seenAtThisLevel(element.strElementName) = New List(Of UIElement)
        End If
        seenAtThisLevel(element.strElementName).Add(element)

        ' Recurse for children
        Dim elementNamesAlreadyInCurrentBranch = New HashSet(Of String)(elementNamesAlreadyInParentBranch, StringComparer.OrdinalIgnoreCase) From {
            element.strElementName
        }

        Dim newChildren As New List(Of UIElement)
        For Each child In element.lstChildren
            Dim elementNoDuplicate = GetUIElementNoDuplicates(child, elementNamesAlreadyInCurrentBranch, level + 1)
            If elementNoDuplicate IsNot Nothing Then
                newChildren.Add(elementNoDuplicate)
            End If
        Next

        element.lstChildren = newChildren
        Return element
    End Function

    ''' <summary>
    ''' Returns True if the two UIElement trees are structurally identical and all nodes have the same strElementName.
    ''' </summary>
    Private Function AreChildTreesIdentical(node1 As UIElement, node2 As UIElement) As Boolean
        If node1 Is Nothing AndAlso node2 Is Nothing Then Return True
        If node1 Is Nothing OrElse node2 Is Nothing Then Return False
        If Not String.Equals(node1.strElementName, node2.strElementName, StringComparison.OrdinalIgnoreCase) Then Return False

        If node1.lstChildren.Count <> node2.lstChildren.Count Then Return False

        For i As Integer = 0 To node1.lstChildren.Count - 1
            If Not AreChildTreesIdentical(node1.lstChildren(i), node2.lstChildren(i)) Then
                Return False
            End If
        Next

        Return True
    End Function

    ''' <summary>
    ''' Returns a new UIElement tree where, for each strElementName that appears more than once,
    ''' all nodes with that name are moved to be direct children of their lowest common ancestor (LCA).
    ''' </summary>
    Private Function GetUIElementMoveDuplicatesToCommonParent(element As UIElement) As UIElement
        If element Is Nothing OrElse String.IsNullOrEmpty(element.strElementName) Then Return Nothing
        If element.lstChildren Is Nothing OrElse element.lstChildren.Count = 0 Then
            Return element
        End If

        ' Step 1: Traverse the tree and record all paths to each node by strElementName
        Dim nameToPaths As New Dictionary(Of String, List(Of List(Of UIElement)))(StringComparer.OrdinalIgnoreCase)
        RecordPaths(element, New List(Of UIElement), nameToPaths)

        ' Step 2: For each duplicate name, find the LCA and collect all nodes to move
        Dim nameToLca As New Dictionary(Of String, UIElement)(StringComparer.OrdinalIgnoreCase)
        For Each kvp In nameToPaths
            If kvp.Value.Count > 1 Then
                Dim lca As UIElement = FindLCAFromPaths(kvp.Value)
                nameToLca(kvp.Key) = lca
            End If
        Next

        ' Step 3: Build a new tree, moving duplicates to their LCA
        Dim nodeToParent As New Dictionary(Of UIElement, UIElement) ' For removal
        BuildParentMap(element, Nothing, nodeToParent)

        ' Collect all nodes to move for each duplicate name
        Dim nameToNodesToMove As New Dictionary(Of String, List(Of UIElement))(StringComparer.OrdinalIgnoreCase)
        For Each kvp In nameToPaths
            If kvp.Value.Count > 1 Then
                Dim nodes = kvp.Value.Select(Function(path) path.Last()).ToList()
                nameToNodesToMove(kvp.Key) = nodes
            End If
        Next

        ' Clone the tree so we don't mutate the original
        Dim cloneMap As New Dictionary(Of UIElement, UIElement)
        Dim newRoot As UIElement = CloneTree(element, cloneMap)

        ' Remove all duplicate nodes from their current parents (except the LCA)
        For Each kvp In nameToNodesToMove
            Dim name = kvp.Key
            Dim lca = If(nameToLca.ContainsKey(name), cloneMap(nameToLca(name)), Nothing)
            If lca Is Nothing Then Continue For
            Dim nodes = kvp.Value.Select(Function(n) cloneMap(n)).ToList()
            For Each node In nodes
                Dim parent = FindParent(newRoot, node)
                If parent IsNot Nothing AndAlso parent IsNot lca Then
                    parent.lstChildren.Remove(node)
                End If
            Next
            ' Add all nodes as direct children of the LCA (if not already present)
            For Each node In nodes
                If Not lca.lstChildren.Contains(node) Then
                    lca.lstChildren.Add(node)
                End If
            Next
        Next

        Return newRoot
    End Function

    ' Helper: Traverse the tree and record all paths to each node by strElementName
    Private Sub RecordPaths(node As UIElement, path As List(Of UIElement), nameToPaths As Dictionary(Of String, List(Of List(Of UIElement)))
    )
        If node Is Nothing Then Return
        Dim newPath = New List(Of UIElement)(path) From {node}
        If Not String.IsNullOrEmpty(node.strElementName) Then
            If Not nameToPaths.ContainsKey(node.strElementName) Then
                nameToPaths(node.strElementName) = New List(Of List(Of UIElement))()
            End If
            nameToPaths(node.strElementName).Add(newPath)
        End If
        For Each child In node.lstChildren
            RecordPaths(child, newPath, nameToPaths)
        Next
    End Sub

    ' Helper: Find the lowest common ancestor from a list of paths
    Private Function FindLCAFromPaths(paths As List(Of List(Of UIElement))) As UIElement
        If paths Is Nothing OrElse paths.Count = 0 Then Return Nothing
        Dim minLen = paths.Min(Function(p) p.Count)
        Dim lca As UIElement = Nothing
        For i = 0 To minLen - 1
            Dim thisNode = paths(0)(i)
            If paths.All(Function(p) p(i) Is thisNode) Then
                lca = thisNode
            Else
                Exit For
            End If
        Next
        Return lca
    End Function

    ' Helper: Build a map from node to parent
    Private Sub BuildParentMap(node As UIElement, parent As UIElement, nodeToParent As Dictionary(Of UIElement, UIElement))
        If node Is Nothing Then Return
        If parent IsNot Nothing Then
            nodeToParent(node) = parent
        End If
        For Each child In node.lstChildren
            BuildParentMap(child, node, nodeToParent)
        Next
    End Sub

    ' Helper: Clone the tree and build a map from old node to new node
    Private Function CloneTree(node As UIElement, cloneMap As Dictionary(Of UIElement, UIElement)) As UIElement
        If node Is Nothing Then Return Nothing
        Dim newNode As New UIElement(node.strElementName)
        cloneMap(node) = newNode
        For Each child In node.lstChildren
            Dim newChild = CloneTree(child, cloneMap)
            If newChild IsNot Nothing Then
                newNode.lstChildren.Add(newChild)
            End If
        Next
        Return newNode
    End Function

    ' Helper: Find the parent of a node in the tree
    Private Function FindParent(root As UIElement, target As UIElement) As UIElement
        If root Is Nothing OrElse root.lstChildren Is Nothing Then Return Nothing
        For Each child In root.lstChildren
            If child Is target Then Return root
            Dim found = FindParent(child, target)
            If found IsNot Nothing Then Return found
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' Returns a string representation of the UIElement tree structure, with indentation for each level.
    ''' </summary>
    Private Function OutputUIElementTree(element As UIElement, level As Integer) As String
        If element Is Nothing Then Return String.Empty

        Dim sb As New System.Text.StringBuilder()
        If Not String.IsNullOrEmpty(element.strElementName) Then
            sb.AppendLine($"{New String(" "c, level * 2)}Level {level}: {element.strElementName}")
        End If
        For Each child In element.lstChildren
            sb.Append(OutputUIElementTree(child, level + 1))
        Next
        Return sb.ToString()
    End Function

End Class

' todo Define the UIElement class (place this outside of ucrButtons, e.g., at the end of the file or in a separate file if preferred)
Public Class UIElement
    Public Property strElementName As String
    Public Property lstChildren As New List(Of UIElement)

    Public Sub New(strName As String)
        strElementName = strName
    End Sub

    ''' <summary>
    ''' Returns a string signature of this node and all its descendants, with each strElementName separated by ', '.
    ''' </summary>
    Public ReadOnly Property strSignature As String
        Get
            Dim names As New List(Of String) From {strElementName}
            AddChildNames(lstChildren, names)
            Return String.Join(", ", names)
        End Get
    End Property

    Private Sub AddChildNames(children As List(Of UIElement), names As List(Of String))
        For Each child In children
            names.Add(child.strElementName)
            If child.lstChildren IsNot Nothing AndAlso child.lstChildren.Count > 0 Then
                AddChildNames(child.lstChildren, names)
            End If
        Next
    End Sub
End Class

