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
Imports System.Globalization
Imports System.Threading
Imports instat.Translations
Imports System.IO
Imports instat

Public Class dlgOptions
    Public strCurrLanguageCulture As String
    Public strPrevLanguageCulture As String
    Public strOutputWindowDisplay As String
    Public strWorkingDirectory As String
    Private strGraphDisplayOption As String
    Private Panels As New List(Of Panel)()
    Private VisiblePanel As Panel = Nothing
    Private strCurrLang As String
    'Define the Fonts dialog (only one)
    Dim dlgFont As New FontDialog
    Dim bFirstLoad As Boolean = True
    Dim fntOutput, fntCommand, fntComment, fntEditor As Font
    Dim clrOutput, clrCommand, clrComment, clrEditor As Color

    Private Sub dlgOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        LoadInstatOptions()
        ApplyEnabled(False)
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 336
        Dim strPreviewText As String
        ucrNudMaxRows.Maximum = Integer.MaxValue
        ucrNudMaxRows.Increment = 10
        ucrNudMaxCols.Maximum = Integer.MaxValue
        ucrNudMaxCols.Increment = 1
        ucrNudAutoSaveMinutes.Maximum = Integer.MaxValue
        ucrNudAutoSaveMinutes.Increment = 1
        ucrNudAutoSaveMinutes.Minimum = 1
        ucrNudWaitSeconds.Minimum = 1
        ucrNudWaitSeconds.Maximum = Integer.MaxValue
        ucrNudWaitSeconds.Increment = 0.5

        strPreviewText = "R-Instat 2017"
        rtbCommandPreview.Text = strPreviewText
        rtbCommentPreview.Text = strPreviewText
        rtbOutputPreview.Text = strPreviewText
        SetView()

        ucrNudDigits.SetMinMax(0, 22)
        ucrChkIncludeCommentsbyDefault.SetText("Include Comments by Default")
        ucrChkViewStructuredMenu.SetText("Show Structured Menu")
        ucrChkViewClimaticMenu.SetText("Show Climatic Menu")
        ucrChkViewProcurementMenu.SetText("Show Procurement Menu")
        ucrChkViewOptionsByContextMenu.SetText("Show Options By Context Menu")
        ucrChkShowRCommandsinOutputWindow.SetText(" Show R Commands in Output Window")
        ucrChkShowSignifStars.SetText("Show stars on summary tables for coefficients")
        ucrChkShowDataonGrid.SetText("Display dialog's selected data frame in grid")
        ucrChkIncludeDefaultParams.SetText("Include Default Parameter Values in R Commands")
        ucrChkAutoSave.SetText("Auto save a backup of data")
        ucrChkShowWaitDialog.SetText("Show waiting dialog when command takes longer than")
        ucrChkAutoSave.AddToLinkedControls(ucrNudAutoSaveMinutes, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudAutoSaveMinutes.SetLinkedDisplayControl(lblMinutes)
        ucrPnlGraphDisplay.AddRadioButton(rdoDisplayinOutputWindow)
        ucrPnlGraphDisplay.AddRadioButton(rdoDisplayinRViewer)
        ucrPnlGraphDisplay.AddRadioButton(rdoDisplayinSeparateWindows)
        ucrInputLanguage.SetLinkedDisplayControl(lblLanguage)
        ucrInputLanguage.SetItems({"English", "French", "Portuguese", "Kiswahili"})
        ucrInputLanguage.SetDropDownStyleAsNonEditable()

        SetVisibleLanButton()
    End Sub

     Private Sub LoadInstatOptions()
        ucrChkIncludeDefaultParams.Checked = frmMain.clsInstatOptions.bIncludeRDefaultParameters
        ucrChkAutoSave.Checked = frmMain.clsInstatOptions.bAutoSaveData
        SetOutputFont(frmMain.clsInstatOptions.fntOutput, frmMain.clsInstatOptions.clrOutput)
        SetCommandFont(frmMain.clsInstatOptions.fntScript, frmMain.clsInstatOptions.clrScript)
        SetCommentFont(frmMain.clsInstatOptions.fntComment, frmMain.clsInstatOptions.clrComment)
        SetEditorFont(frmMain.clsInstatOptions.fntEditor, frmMain.clsInstatOptions.clrEditor)
        ucrNudMaxRows.Value = frmMain.clsInstatOptions.iMaxRows
        ucrNudMaxCols.Value = frmMain.clsInstatOptions.iMaxCols
        ucrNudAutoSaveMinutes.Value = frmMain.clsInstatOptions.iAutoSaveDataMinutes
        ucrNudPreviewRows.Value = frmMain.clsInstatOptions.iPreviewRows
        ucrInputComment.SetName(frmMain.clsInstatOptions.strComment)
        ucrWorkingDirectory.SetName(frmMain.clsInstatOptions.strWorkingDirectory)
        ucrChkIncludeCommentsbyDefault.Checked = frmMain.clsInstatOptions.bIncludeCommentDefault
        ucrChkViewOptionsByContextMenu.Checked = frmMain.clsInstatOptions.bShowOptionsByContextMenu
        ucrChkViewProcurementMenu.Checked = frmMain.clsInstatOptions.bShowProcurementMenu
        ucrChkViewStructuredMenu.Checked = frmMain.clsInstatOptions.bShowStructuredMenu
        ucrChkViewClimaticMenu.Checked = frmMain.clsInstatOptions.bShowClimaticMenu
        ucrChkShowRCommandsinOutputWindow.Checked = frmMain.clsInstatOptions.bCommandsinOutput
        ucrNudDigits.Value = frmMain.clsInstatOptions.iDigits
        ucrChkShowSignifStars.Checked = frmMain.clsInstatOptions.bShowSignifStars
        ucrChkShowDataonGrid.Checked = frmMain.clsInstatOptions.bChangeDataFrame
        ucrChkShowWaitDialog.Checked = frmMain.clsInstatOptions.bShowWaitDialog
        ucrNudWaitSeconds.Value = frmMain.clsInstatOptions.iWaitTimeDelaySeconds
        ucrInputDatabaseName.SetName(frmMain.clsInstatOptions.strClimsoftDatabaseName)
        ucrInputHost.SetName(frmMain.clsInstatOptions.strClimsoftHost)
        ucrInputPort.SetName(frmMain.clsInstatOptions.strClimsoftPort)
        ucrInputUserName.SetName(frmMain.clsInstatOptions.strClimsoftUsername)
        Select Case frmMain.clsInstatOptions.strLanguageCultureCode
            Case "en-GB"
                ucrInputLanguage.SetText("English")
            Case "fr-FR"
                ucrInputLanguage.SetText("French")
            Case "pt-PT"
                ucrInputLanguage.SetText("Portuguese")
            Case "sw-KE"
                ucrInputLanguage.SetText("Kiswahili")
        End Select

        strPrevLanguageCulture = frmMain.clsInstatOptions.strLanguageCultureCode

        If frmMain.clsInstatOptions.strGraphDisplayOption = "view_output_window" Then
            rdoDisplayinOutputWindow.Checked = True
        ElseIf frmMain.clsInstatOptions.strGraphDisplayOption = "view_separate_window" Then
            rdoDisplayinSeparateWindows.Checked = True
        ElseIf frmMain.clsInstatOptions.strGraphDisplayOption = "view_R_viewer" Then
            rdoDisplayinRViewer.Checked = True
        End If
    End Sub

    Private Sub SetInstatOptions()
        frmMain.clsInstatOptions.bIncludeRDefaultParameters = ucrChkIncludeDefaultParams.Checked
        frmMain.clsInstatOptions.SetFormatOutput(fntOutput, clrOutput)
        frmMain.clsInstatOptions.SetFormatComment(fntComment, clrComment)
        frmMain.clsInstatOptions.SetFormatScript(fntCommand, clrCommand)
        frmMain.clsInstatOptions.SetFormatEditor(fntEditor, clrEditor)
        frmMain.clsInstatOptions.SetComment(ucrInputComment.GetText)
        frmMain.clsInstatOptions.SetPreviewRows(ucrNudPreviewRows.Value)
        frmMain.clsInstatOptions.SetMaxRows(ucrNudMaxRows.Value)
        frmMain.clsInstatOptions.SetMaxCols(ucrNudMaxCols.Value)
        frmMain.clsInstatOptions.SetAutoSaveData(ucrChkAutoSave.Checked)
        frmMain.clsInstatOptions.SetAutoSaveDataMinutes(ucrNudAutoSaveMinutes.Value)
        frmMain.clsInstatOptions.SetLanguageCultureCode(strCurrLanguageCulture)
        frmMain.clsInstatOptions.SetWorkingDirectory(strWorkingDirectory)
        frmMain.clsInstatOptions.SetGraphDisplayOption(strGraphDisplayOption)
        frmMain.clsInstatOptions.bIncludeCommentDefault = ucrChkIncludeCommentsbyDefault.Checked
        frmMain.clsInstatOptions.SetShowOptionsByContextMenu(ucrChkViewOptionsByContextMenu.Checked)
        frmMain.clsInstatOptions.SetShowProcurementMenu(ucrChkViewProcurementMenu.Checked)
        frmMain.clsInstatOptions.SetShowStructuredMenu(ucrChkViewStructuredMenu.Checked)
        frmMain.clsInstatOptions.SetShowClimaticMenu(ucrChkViewClimaticMenu.Checked)
        frmMain.clsInstatOptions.SetCommandInOutpt(ucrChkShowRCommandsinOutputWindow.Checked)
        frmMain.clsInstatOptions.SetDigits(ucrNudDigits.Value)
        frmMain.clsInstatOptions.SetSignifStars(ucrChkShowSignifStars.Checked)
        frmMain.clsInstatOptions.SetChangeDataFrame(ucrChkShowDataonGrid.Checked)
        frmMain.clsInstatOptions.SetShowWaitDialog(ucrChkShowWaitDialog.Checked)
        frmMain.clsInstatOptions.SetWaitTimeDelaySeconds(ucrNudWaitSeconds.Value)
        frmMain.clsInstatOptions.SetClimsoftDatabaseName(ucrInputDatabaseName.GetText())
        frmMain.clsInstatOptions.SetClimsoftHost(ucrInputHost.GetText())
        frmMain.clsInstatOptions.SetClimsoftPort(ucrInputPort.GetText())
        frmMain.clsInstatOptions.SetClimsoftUsername(ucrInputUserName.GetText())
    End Sub

    Private Sub SetView()
        Dim tbpPage As TabPage
        trOptions.Nodes.Clear()
        For Each tbpPage In tbcOptions.TabPages
            trOptions.Nodes.Add(tbpPage.Name, tbpPage.Text)
        Next
        ' Expand all tree nodes.
        trOptions.ExpandAll()
        '' Move the Panels out of the TabControl.
        'tbcOptions.Visible = False
        'For Each page As TabPage In tbcOptions.TabPages
        '    ' Add the Panel to the list.
        '    Dim the_panel As Panel = DirectCast(page.Controls(0), Panel)
        '    Panels.Add(the_panel)

        '    ' Reparent and move the Panel.
        '    the_panel.Parent = tbcOptions.Parent
        '    the_panel.Location = tbcOptions.Location
        '    the_panel.Visible = False
        'Next page

        '' Display the first panel.
        'DisplayPanel(0)
    End Sub

    ' Display the appropriate Panel.
    Private Sub DisplayPanel(iPage As Integer)
        tbcOptions.SelectedIndex = iPage
        'removed temporarily to also show tabs
        'If (Panels.Count < 1) Then Return

        '' If this is the same Panel, do nothing.
        'If (VisiblePanel Is Panels(Index)) Then Return

        '' Hide the previously visible Panel.
        'If (VisiblePanel IsNot Nothing) Then VisiblePanel.Visible = False

        '' Display the appropriate Panel.
        'Panels(Index).Visible = True
        'VisiblePanel = Panels(Index)
    End Sub

    'Handles click of the tree node
    Private Sub trOptions_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles trOptions.AfterSelect
        DisplayPanel(e.Node.Index)
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        cmdApply_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles cmdApply.Click
        Cursor = Cursors.WaitCursor
        cmdApply.Enabled = False
        cmdOk.Enabled = False
        cmdCancel.Enabled = False
        cmdHelp.Enabled = False
        SetInstatOptions()
        autoTranslate(Me)
        SetView() 'needed to ensure that the tree view in the left panel correctly displays translated text

        If frmMain.Visible AndAlso strCurrLanguageCulture <> strPrevLanguageCulture Then
            frmMain.TranslateFrmMainMenu()
        End If
        strPrevLanguageCulture = strCurrLanguageCulture

        frmMain.SetLanButtonVisibility(frmMain.clsInstatOptions.strLanguageCultureCode <> "en-GB")

        'disables the command after running it
        cmdApply.Enabled = True
        cmdOk.Enabled = True
        cmdCancel.Enabled = True
        cmdHelp.Enabled = True
        ApplyEnabled(False)
        SetVisibleLanButton()
        Cursor = Cursors.Default
    End Sub

    Private Sub ucrInputLanguage_ControlValueChanged() Handles ucrInputLanguage.ControlValueChanged
        Select Case ucrInputLanguage.GetText
            Case "English"
                strCurrLanguageCulture = "en-GB"
            Case "French"
                strCurrLanguageCulture = "fr-FR"
            Case "Portuguese"
                strCurrLanguageCulture = "pt-PT"
            Case "Kiswahili"
                strCurrLanguageCulture = "sw-KE"
        End Select
        ApplyEnabled(True)
    End Sub
  
    Private Sub cmdScriptChange_Click(sender As Object, e As EventArgs) Handles cmdCommandFormat.Click
        dlgFont.ShowColor = True
        dlgFont.MaxSize = 50
        dlgFont.MinSize = 8
        dlgFont.Font = fntCommand
        dlgFont.Color = clrCommand
        If dlgFont.ShowDialog = DialogResult.OK Then
            SetCommandFont(dlgFont.Font, dlgFont.Color)
            ApplyEnabled(True)
            dlgFont.Reset()
        End If
    End Sub

    Private Sub cmdOutputChange_Click(sender As Object, e As EventArgs) Handles cmdOutputFormat.Click
        dlgFont.ShowColor = True
        dlgFont.MaxSize = 50
        dlgFont.MinSize = 8
        dlgFont.Font = fntOutput
        dlgFont.Color = clrOutput
        If dlgFont.ShowDialog = DialogResult.OK Then
            SetOutputFont(dlgFont.Font, dlgFont.Color)
            ApplyEnabled(True)
            dlgFont.Reset()
        End If
    End Sub

    Private Sub cmdCommentsChange_Click(sender As Object, e As EventArgs) Handles cmdCommentFormat.Click
        dlgFont.ShowColor = True
        dlgFont.MaxSize = 50
        dlgFont.MinSize = 8
        dlgFont.Font = fntComment
        dlgFont.Color = clrComment
        If dlgFont.ShowDialog = DialogResult.OK Then
            SetCommentFont(dlgFont.Font, dlgFont.Color)
            ApplyEnabled(True)
            dlgFont.Reset()
        End If
    End Sub

    Private Sub cmdEditorFont_Click(sender As Object, e As EventArgs) Handles cmdEditorFont.Click
        dlgFont.ShowColor = True
        'dlgFont.ShowEffects = False
        dlgFont.MaxSize = 50
        dlgFont.MinSize = 8
        dlgFont.Font = fntEditor
        dlgFont.Color = clrEditor
        If dlgFont.ShowDialog = DialogResult.OK Then
            SetEditorFont(dlgFont.Font, dlgFont.Color)
            ApplyEnabled(True)
            dlgFont.Reset()
        End If

    End Sub

    Private Sub AllControls_ControlValueChanged() Handles ucrNudMaxCols.ControlValueChanged, ucrNudAutoSaveMinutes.ControlValueChanged, ucrNudPreviewRows.ControlValueChanged, ucrInputComment.ControlContentsChanged, ucrChkIncludeCommentsbyDefault.ControlValueChanged, ucrNudMaxRows.ControlValueChanged, ucrChkIncludeDefaultParams.ControlValueChanged, ucrChkShowRCommandsinOutputWindow.ControlValueChanged, ucrNudDigits.ControlValueChanged, ucrChkShowSignifStars.ControlValueChanged, ucrChkShowDataonGrid.ControlValueChanged, ucrChkAutoSave.ControlValueChanged, ucrChkShowWaitDialog.ControlValueChanged, ucrNudWaitSeconds.ControlValueChanged, ucrChkViewClimaticMenu.ControlValueChanged, ucrChkViewStructuredMenu.ControlValueChanged, ucrChkViewProcurementMenu.ControlValueChanged, ucrChkViewOptionsByContextMenu.ControlValueChanged, ucrInputDatabaseName.ControlValueChanged, ucrInputHost.ControlValueChanged, ucrInputPort.ControlValueChanged, ucrInputUserName.ControlValueChanged
        ApplyEnabled(True)
    End Sub

    Private Sub ApplyEnabled(bEnable As Boolean)
        cmdApply.Enabled = bEnable
        cmdOk.Enabled = bEnable
    End Sub

    Private Sub SetOutputFont(fntNew As Font, clrNew As Color)
        fntOutput = fntNew
        clrOutput = clrNew
        rtbOutputPreview.SelectAll()
        rtbOutputPreview.Font = fntOutput
        rtbOutputPreview.SelectionColor = clrOutput
        rtbOutputPreview.SelectionLength = 0
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "336")
    End Sub

    Private Sub ucrChkAutoSave_ControlValueChanged() Handles ucrChkAutoSave.ControlValueChanged
        If ucrChkAutoSave.Checked Then
            lblEvery.Visible = True
        Else
            lblEvery.Visible = False
        End If
    End Sub

    Private Sub cmdFactoryReset_Click(sender As Object, e As EventArgs) Handles cmdFactoryReset.Click
        Dim msgFactoryReset = MsgBox("Are you sure you want to reset to factory defaults?", MessageBoxButtons.YesNo, "Factory Reset")
        If msgFactoryReset = DialogResult.Yes Then
            frmMain.clsInstatOptions = New InstatOptions(False)
            LoadInstatOptions()
            ApplyEnabled(True)
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
        autoTranslate(Me)
        SetView()
        frmMain.clsInstatOptions.strLanguageCultureCode = strConfiguredLanguage
    End Sub

    Private Sub ucrPnlGraphDisplay_ControlValueChanged() Handles ucrPnlGraphDisplay.ControlValueChanged
        If rdoDisplayinOutputWindow.Checked Then
            strGraphDisplayOption = "view_output_window"
        ElseIf rdoDisplayinSeparateWindows.Checked Then
            strGraphDisplayOption = "view_separate_window"
        ElseIf rdoDisplayinRViewer.Checked Then
            strGraphDisplayOption = "view_R_viewer"
        End If
        ApplyEnabled(True)
    End Sub

    Private Sub SetVisibleLanButton()
        If frmMain.clsInstatOptions IsNot Nothing Then
            If frmMain.clsInstatOptions.strLanguageCultureCode <> "en-GB" Then
                cmdLanguage.Visible = True
            Else
                cmdLanguage.Visible = False
            End If
            strCurrLang = frmMain.clsInstatOptions.strLanguageCultureCode
        End If
    End Sub

    Private Sub SetCommandFont(fntNew As Font, clrNew As Color)
        fntCommand = fntNew
        clrCommand = clrNew
        rtbCommandPreview.SelectAll()
        rtbCommandPreview.Font = fntCommand
        rtbCommandPreview.SelectionColor = clrCommand
        rtbCommandPreview.SelectionLength = 0
    End Sub

    Private Sub SetCommentFont(fntNew As Font, clrNew As Color)
        fntComment = fntNew
        clrComment = clrNew
        rtbCommentPreview.SelectAll()
        rtbCommentPreview.Font = fntComment
        rtbCommentPreview.SelectionColor = clrComment
        rtbCommandPreview.SelectionLength = 0
    End Sub

    Private Sub SetEditorFont(fntNew As Font, clrNew As Color)
        fntEditor = fntNew
        clrEditor = clrNew
    End Sub

    Private Sub cmdWorkingDirectory_Click(sender As Object, e As EventArgs) Handles cmdWorkingDirectory.Click
        Dim dlgWorkingDirectory As New FolderBrowserDialog
        If dlgWorkingDirectory.ShowDialog = DialogResult.OK Then
            strWorkingDirectory = (dlgWorkingDirectory.SelectedPath).Replace("\", "/")
            ucrWorkingDirectory.SetName(strWorkingDirectory)
            ApplyEnabled(True)
        End If
    End Sub

    Private Sub ucrChkShowWaitDialog_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowWaitDialog.ControlValueChanged
        ucrNudWaitSeconds.Enabled = ucrChkShowWaitDialog.Checked
        lblWaitSeconds.Enabled = ucrChkShowWaitDialog.Checked
    End Sub
End Class
