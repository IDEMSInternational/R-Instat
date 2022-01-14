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
Imports instat.Translations

Public Class clsRecentFiles
    Public lstRecentDialogs As New List(Of Form)
    Private strRecentFilesPath As String
    Private mnuTbShowLast10 As ToolStripDropDownItem
    Private mnuFile As ToolStripMenuItem
    Private mnuFileIcon As ToolStripSplitButton
    Private sepStart As ToolStripSeparator
    Private sepEnd As ToolStripSeparator
    ' declare a variable to contain the most recent opened items
    Private lstRecentOpenedFiles As New List(Of String)

    ''' <summary>
    ''' stores reference to the  the data view window used in frmMain. 
    ''' will be used to add recent files menu items to it.
    ''' </summary>
    Private ucrDataViewWindow As ucrDataView

    Public Sub New(strAppDataPath As String)
        strRecentFilesPath = Path.Combine(strAppDataPath, "recent.mru")
    End Sub

    Public Sub setToolStripItems(dfMnuFile As ToolStripMenuItem, dfMnuFileIcon As ToolStripSplitButton, dfMnuToolStripDropdown As ToolStripDropDownItem, dfSepStart As ToolStripSeparator, dfSepEnd As ToolStripSeparator)
        mnuFile = dfMnuFile
        mnuFileIcon = dfMnuFileIcon
        mnuTbShowLast10 = dfMnuToolStripDropdown
        sepStart = dfSepStart
        sepEnd = dfSepEnd
        sepStart.Visible = False
        sepEnd.Visible = False
    End Sub

    Public Sub SetDataViewWindow(ucrDataViewWindow As ucrDataView)
        Me.ucrDataViewWindow = ucrDataViewWindow
    End Sub

    ''' <summary>
    ''' loads the list of last saved recent opened files 
    ''' </summary>
    Public Sub checkOnLoad()
        'checks for the existence of the file path
        If Not File.Exists(strRecentFilesPath) Then
            Exit Sub
        End If

        'read file contents
        Dim arrStrPaths() As String = File.ReadAllLines(strRecentFilesPath)
        For Each strPath As String In arrStrPaths
            If Not String.IsNullOrEmpty(strPath) Then
                lstRecentOpenedFiles.Add(strPath.Replace("\", "/"))
            End If
        Next
        'display the recently opened files if there are any items to display in the file
        UpdateRecentFilesMenuItems()
    End Sub

    ''' <summary>
    ''' saves the list of recent opened files on form close
    ''' </summary>
    Public Sub saveOnClose()
        'overwite any existing contents of the file
        File.WriteAllText(strRecentFilesPath, "")
        'write each item to the file...
        For Each strPath As String In lstRecentOpenedFiles
            File.AppendAllText(strRecentFilesPath, strPath & Environment.NewLine)
        Next
    End Sub

    ''' <summary>
    ''' adds the form to menu items
    ''' </summary>
    ''' <param name="frmDialog">form to add to menu items</param>
    Public Sub addToMenu(frmDialog As Form)
        'Checks for existance, else add it to the beginning
        If lstRecentDialogs.Contains(frmDialog) Then lstRecentDialogs.Remove(frmDialog)
        'adds to the list
        lstRecentDialogs.Add(frmDialog)
        'checks that only 10 items are allowed
        If lstRecentDialogs.Count > 10 Then
            lstRecentDialogs.RemoveAt(0)
        End If
        'update recent dialogs menu items
        UpdateRecentDialogsMenuItems()
    End Sub

    ''' <summary>
    ''' adds the file path to menu items
    ''' </summary>
    ''' <param name="strFilePath">file path to add to menu items</param>
    Public Sub addToMenu(strFilePath As String)
        'remove file if it exists(helps with making sure displayed file names are rearranged)
        lstRecentOpenedFiles.Remove(strFilePath)
        'add to recent opened files list..
        strFilePath = strFilePath.Replace("\", "/")
        lstRecentOpenedFiles.Add(strFilePath)
        'make sure there are only ever 30 items...
        'todo. add this to the general options on the number of recently files to show
        While lstRecentOpenedFiles.Count > 30
            lstRecentOpenedFiles.RemoveAt(0)
        End While
        'update recent files menu items
        UpdateRecentFilesMenuItems()
    End Sub

    ''' <summary>
    ''' updates the menu toolstrip to show the last 10 opened dialogs
    ''' </summary>
    Public Sub UpdateRecentDialogsMenuItems()
        'exit sub if last 10 toolstrip or list of last 10 dialogs are not initialised
        If mnuTbShowLast10 Is Nothing Then
            Exit Sub
        End If

        'remove the menu items of recent opened dialogs
        For i As Integer = mnuTbShowLast10.DropDownItems.Count - 1 To 0 Step -1
            If mnuTbShowLast10.DropDownItems(i).Tag IsNot Nothing AndAlso mnuTbShowLast10.DropDownItems(i).Tag.ToString().StartsWith("Last") Then
                mnuTbShowLast10.DropDownItems.RemoveAt(i)
            End If
        Next

        'then add and display menu items (in reverse order) for dialogs
        For icounter As Integer = lstRecentDialogs.Count - 1 To 0 Step -1
            'creates new toolstripitem, displaying name of the dialog
            Dim clsItem As New ToolStripMenuItem(GetTranslation(lstRecentDialogs(icounter).Text))
            'sets the tag
            clsItem.Tag = "Last"
            AddHandler clsItem.Click, AddressOf OnMnuLastRecentDialog_Click
            'insert into the dropdownitems
            'mnuTbShowLast10.DropDownItems.Insert(mnuTbShowLast10.DropDownItems.Count - 1, clsItem)
            mnuTbShowLast10.DropDownItems.Add(clsItem)
        Next
    End Sub


    ''' <summary>
    ''' raised when menu item of recent opened file is clicked
    ''' </summary>
    ''' <param name="sender">ToolStripItem or LinkLabel only</param>
    ''' <param name="e"></param>
    Private Sub OnMnuRecentOpenedFile_Click(sender As Object, e As EventArgs)
        Dim strFilePath As String = ""
        'if tag is "more" then its more link that was clicked so exit sub
        If TypeOf sender Is ToolStripItem Then
            Dim bIsMoreLink As Boolean
            Dim toolStripItem As ToolStripItem = DirectCast(sender, ToolStripItem)
            strFilePath = toolStripItem.Tag.ToString()
            bIsMoreLink = (strFilePath = "MRU:more")
            If toolStripItem.OwnerItem Is mnuFile Then
                If bIsMoreLink Then
                    UpdateRecentFilesMenuItems(True, mnuFile:=mnuFile)
                    mnuFile.ShowDropDown()
                    AddHandler mnuFile.DropDownClosed, AddressOf MenuDropDownClosedAfterMoreClicked
                    Exit Sub
                End If
            ElseIf toolStripItem.OwnerItem Is mnuFileIcon Then
                If bIsMoreLink Then
                    UpdateRecentFilesMenuItems(True, mnuFileIcon:=mnuFileIcon)
                    mnuFileIcon.ShowDropDown()
                    AddHandler mnuFileIcon.DropDownClosed, AddressOf MenuDropDownClosedAfterMoreClicked
                    Exit Sub
                End If
            End If
        ElseIf TypeOf sender Is LinkLabel Then
            strFilePath = DirectCast(sender, LinkLabel).Tag.ToString()
            If strFilePath = "more" Then
                UpdateRecentFilesMenuItems(True, ucrDataViewWindow:=ucrDataViewWindow)
                Exit Sub
            End If
        End If

        Dim strFilePathTmp As String = strFilePath.Replace("MRU:", "")
        strFilePathTmp = strFilePathTmp.Replace("\", "/")
        If File.Exists(strFilePathTmp) Then
            dlgImportDataset.strFileToOpenOn = strFilePathTmp
            dlgImportDataset.ShowDialog()
        ElseIf DialogResult.Yes = MessageBox.Show(    'else allow the user to remove file from list
                    frmMain, "File not accessible. It may have been renamed, moved or deleted." &
                    Environment.NewLine & Environment.NewLine &
                    "Would you like to remove this file from the list?", "Cannot access file",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) Then
            lstRecentOpenedFiles.Remove(strFilePathTmp)
            'update recent file menu items controls to not show the file name and path
            UpdateRecentFilesMenuItems()
        End If
    End Sub

    ''' <summary>
    ''' raised when last dialog menu item is clicked 
    ''' </summary>
    ''' <param name="sender">ToolStripMenuItem</param>
    ''' <param name="e"></param>
    Private Sub OnMnuLastRecentDialog_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each dfTemp As Form In lstRecentDialogs
            'Note: Translate both sides of the comparison in case the 2 sides are in different languages.
            '      This is possible if the language was recently changed.
            If GetTranslation(dfTemp.Text) = GetTranslation(DirectCast(sender, ToolStripMenuItem).Text) Then
                dfTemp.ShowDialog()
                Exit Sub
            End If
        Next
    End Sub


    ''' <summary>
    ''' updates menu toolstrip and ucrDataView to show the recent files opened
    ''' </summary>
    ''' <param name="bShowAll"></param>
    ''' <param name="mnuFile"> file menuToolStripMenuItem that will be updated with the list of recent files opened</param>
    ''' <param name="mnuFileIcon">file ToolStripSplitButton that will be updated with the list of recent files opened</param>
    ''' <param name="ucrDataViewWindow">ucrDataView that will be updated with the list of recent files opened</param>
    Public Sub UpdateRecentFilesMenuItems(bShowAll As Boolean, Optional mnuFile As ToolStripMenuItem = Nothing,
                                          Optional mnuFileIcon As ToolStripSplitButton = Nothing,
                                          Optional ucrDataViewWindow As ucrDataView = Nothing)
        'exit sub if file toolstrip, file icon toolstrip and data view are not initialised
        If mnuFile Is Nothing AndAlso mnuFileIcon Is Nothing AndAlso ucrDataViewWindow Is Nothing Then
            Exit Sub
        End If

        If mnuFile IsNot Nothing Then
            'remove all recent files from the menu items
            For i As Integer = mnuFile.DropDownItems.Count - 1 To 0 Step -1
                If mnuFile.DropDownItems(i).Tag IsNot Nothing AndAlso mnuFile.DropDownItems(i).Tag.ToString().StartsWith("MRU:") Then
                    mnuFile.DropDownItems.RemoveAt(i)
                End If
            Next
        End If

        If mnuFileIcon IsNot Nothing Then
            For i As Integer = mnuFileIcon.DropDownItems.Count - 1 To 0 Step -1
                If mnuFileIcon.DropDownItems(i).Tag IsNot Nothing AndAlso mnuFileIcon.DropDownItems(i).Tag.ToString().StartsWith("MRU:") Then
                    mnuFileIcon.DropDownItems.RemoveAt(i)
                End If
            Next
        End If

        If ucrDataViewWindow IsNot Nothing Then
            'remove all the data view window recent file menu items
            ucrDataViewWindow.ClearRecentFileMenuItems()
        End If

        'then add and display items (in reverse order) for recent files
        For iCounter As Integer = lstRecentOpenedFiles.Count - 1 To 0 Step -1
            Try
                Dim strPath As String = lstRecentOpenedFiles(iCounter)
                Dim strFileName As String = Path.GetFileName(strPath)

                'create new ToolStripItem, displaying the name of the file...
                If mnuFile IsNot Nothing Then
                    Dim clsItem As ToolStripMenuItem = New ToolStripMenuItem(strFileName)
                    clsItem.ToolTipText = strPath
                    'set the tag - will be used to identify the ToolStripItem as a most recent(MRU) item 
                    'and contains the full path so it can be opened later
                    clsItem.Tag = "MRU:" & strPath
                    'hook into the click event handler so we can open the file later...
                    AddHandler clsItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                    'insert into DropDownItems list...
                    mnuFile.DropDownItems.Insert(mnuFile.DropDownItems.Count - 1, clsItem)
                End If

                If mnuFileIcon IsNot Nothing Then
                    Dim clsItem As ToolStripMenuItem = New ToolStripMenuItem(strFileName)
                    clsItem.ToolTipText = strPath
                    clsItem.Tag = "MRU:" & strPath
                    AddHandler clsItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                    mnuFileIcon.DropDownItems.Insert(mnuFileIcon.DropDownItems.Count, clsItem)
                End If

                If ucrDataViewWindow IsNot Nothing Then
                    'set and insert the data view window recent files menu items
                    Dim linkMenuItem As LinkLabel = New LinkLabel
                    linkMenuItem.Text = strFileName
                    linkMenuItem.Tag = strPath 'path used when the link is clicked
                    'attach link click event handler for opening the file
                    AddHandler linkMenuItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                    ucrDataViewWindow.InsertRecentFileMenuItems(linkMenuItem)
                End If

                If Not bShowAll Then
                    'if recent files are more than 5 then display the "more" link label and exit loop 

                    If lstRecentOpenedFiles.Count - iCounter >= 5 Then
                        If mnuFile IsNot Nothing Then
                            Dim clsItem As ToolStripMenuItem = New ToolStripMenuItem(GetTranslation("More ..."))
                            clsItem.ToolTipText = GetTranslation("More ...")
                            clsItem.Tag = "MRU:more"
                            AddHandler clsItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                            mnuFile.DropDownItems.Insert(mnuFile.DropDownItems.Count - 1, clsItem)
                        End If

                        If mnuFileIcon IsNot Nothing Then
                            Dim clsItem As ToolStripMenuItem = New ToolStripMenuItem(GetTranslation("More ..."))
                            clsItem.ToolTipText = GetTranslation("More ...")
                            clsItem.Tag = "MRU:more"
                            AddHandler clsItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                            mnuFileIcon.DropDownItems.Insert(mnuFileIcon.DropDownItems.Count, clsItem)
                        End If

                        If ucrDataViewWindow IsNot Nothing Then
                            Dim linkMenuItem As LinkLabel = New LinkLabel
                            linkMenuItem.Text = GetTranslation("More ...")
                            linkMenuItem.Tag = "more"
                            AddHandler linkMenuItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                            ucrDataViewWindow.InsertRecentFileMenuItems(linkMenuItem)
                        End If

                        Exit For

                    End If
                End If

            Catch ex As Exception
                'TODO it would be good to remove the invalid line from the file in this case
            End Try
        Next

        'show separator
        If lstRecentOpenedFiles.Count > 0 Then
            sepStart.Visible = True
            sepEnd.Visible = True
        Else
            sepStart.Visible = False
            sepEnd.Visible = False
        End If

    End Sub

    ''' <summary>
    ''' updates menu toolstrip and ucrDataView to show the recent files opened
    ''' </summary>
    Public Sub UpdateRecentFilesMenuItems()
        UpdateRecentFilesMenuItems(bShowAll:=False, mnuFile:=mnuFile, mnuFileIcon:=mnuFileIcon, ucrDataViewWindow:=ucrDataViewWindow)
    End Sub

    ''' <summary>
    ''' event used to restore the more option when the menu is closed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MenuDropDownClosedAfterMoreClicked(sender As Object, e As EventArgs)
        If sender Is mnuFile Then
            RemoveHandler mnuFile.DropDownClosed, AddressOf MenuDropDownClosedAfterMoreClicked
            UpdateRecentFilesMenuItems(False, mnuFile:=mnuFile)
        ElseIf sender Is mnuFileIcon Then
            RemoveHandler mnuFileIcon.DropDownClosed, AddressOf MenuDropDownClosedAfterMoreClicked
            UpdateRecentFilesMenuItems(False, mnuFileIcon:=mnuFileIcon)
        End If
    End Sub

End Class
