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
                ' Disabled this so that you can still see files that don't exist in the list
                ' only add files that still exist...
                'If File.Exists(sPath) Then
                '    ' add to the list of recently opened files
                '    strListMRU.Add(sPath)
                'End If
                lstRecentOpenedFiles.Add(strPath)
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
            Dim clsItem As New ToolStripMenuItem(lstRecentDialogs(icounter).Text)
            'sets the tag
            clsItem.Tag = "Last"
            AddHandler clsItem.Click, AddressOf OnMnuLastRecentDialog_Click
            'insert into the dropdownitems
            'mnuTbShowLast10.DropDownItems.Insert(mnuTbShowLast10.DropDownItems.Count - 1, clsItem)
            mnuTbShowLast10.DropDownItems.Add(clsItem)
        Next
    End Sub

    ''' <summary>
    ''' updates menu toolstrip and ucrDataView to show the recent files opened
    ''' </summary>
    Public Sub UpdateRecentFilesMenuItems()
        'exit sub if file toolstrip or file icon toolstrip are not initialised
        If mnuFile Is Nothing OrElse mnuFileIcon Is Nothing Then
            Exit Sub
        End If

        Dim strPath As String
        Dim strFileName As String

        'remove all displaced recent files from the menu items
        For i As Integer = mnuFile.DropDownItems.Count - 1 To 0 Step -1
            If mnuFile.DropDownItems(i).Tag IsNot Nothing AndAlso mnuFile.DropDownItems(i).Tag.ToString().StartsWith("MRU:") Then
                mnuFile.DropDownItems.RemoveAt(i)
            End If
        Next

        For i As Integer = mnuFileIcon.DropDownItems.Count - 1 To 0 Step -1
            If mnuFileIcon.DropDownItems(i).Tag IsNot Nothing AndAlso mnuFileIcon.DropDownItems(i).Tag.ToString().StartsWith("MRU:") Then
                mnuFileIcon.DropDownItems.RemoveAt(i)
            End If
        Next

        'remove all the data view window recent file menu items
        ucrDataViewWindow.ClearRecentFileMenuItems()

        'then add and displays items (_in reverse order) for recent files 
        For iCounter As Integer = lstRecentOpenedFiles.Count - 1 To 0 Step -1
            Try
                strPath = lstRecentOpenedFiles(iCounter)
                strFileName = Path.GetFileName(strPath)
                ' create new ToolStripItem, displaying the name of the file...
                Dim clsItem As New ToolStripMenuItem(strFileName)
                Dim clsItemIcon As New ToolStripMenuItem(strFileName)
                clsItem.ToolTipText = strPath
                clsItemIcon.ToolTipText = strPath
                ' set the tag - will be used to identify the ToolStripItem as an most recent(MRU) item 
                ' and contains the full path so it can be opened later
                clsItem.Tag = "MRU:" & strPath
                clsItemIcon.Tag = "MRU:" & strPath
                ' hook into the click event handler so we can open the file later...
                AddHandler clsItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                AddHandler clsItemIcon.Click, AddressOf OnMnuRecentOpenedFile_Click
                ' insert into DropDownItems list...
                mnuFile.DropDownItems.Insert(mnuFile.DropDownItems.Count - 1, clsItem)
                mnuFileIcon.DropDownItems.Insert(mnuFileIcon.DropDownItems.Count, clsItemIcon)

                'set and insert the data view window recent files menu items
                Dim linkMenuItem As New LinkLabel
                linkMenuItem.Text = strFileName
                linkMenuItem.Tag = strPath 'path used when the link is clicked

                ucrDataViewWindow.InsertRecentFileMenuItems(linkMenuItem)

                'attach link click event handler for opening the file
                AddHandler linkMenuItem.Click, AddressOf OnMnuRecentOpenedFile_Click

                'if recent files are more than 5 then just the "more" link label and exit loop 
                If lstRecentOpenedFiles.Count - iCounter >= 5 Then
                    linkMenuItem = New LinkLabel
                    linkMenuItem.Text = "More ..."
                    linkMenuItem.Tag = ""
                    ucrDataViewWindow.InsertRecentFileMenuItems(linkMenuItem)
                    AddHandler linkMenuItem.Click, AddressOf OnMnuRecentOpenedFile_Click
                    Exit For
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
    ''' raised when menu item of recent opened file is clicked
    ''' </summary>
    ''' <param name="sender">ToolStripItem or LinkLabel only</param>
    ''' <param name="e"></param>
    Private Sub OnMnuRecentOpenedFile_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim strFilePath As String = ""

        If TypeOf sender Is ToolStripItem Then
            strFilePath = DirectCast(sender, ToolStripItem).Tag.ToString().Substring(4)
        ElseIf TypeOf sender Is LinkLabel Then
            'if tag is empty then its more link that was clicked
            strFilePath = DirectCast(sender, LinkLabel).Tag.ToString()
            If String.IsNullOrEmpty(strFilePath) Then
                ShowAllRecentFiles()
                Exit Sub
            End If
        End If

        If File.Exists(strFilePath) Then
            dlgImportDataset.strFileToOpenOn = strFilePath
            dlgImportDataset.ShowDialog()
        Else
            'removes the path to the non existent file
            If DialogResult.Yes = MessageBox.Show(frmMain, "File not accessible. It may have been renamed, moved or deleted." & Environment.NewLine & Environment.NewLine & "Would you like to remove this file from the list?", "Cannot access file", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) Then
                lstRecentOpenedFiles.Remove(strFilePath)
                'update recent file menu items controls to not show the file name and path
                UpdateRecentFilesMenuItems()
            End If
        End If
    End Sub

    ''' <summary>
    ''' raised when last dialog menu item is clicked 
    ''' </summary>
    ''' <param name="sender">ToolStripMenuItem</param>
    ''' <param name="e"></param>
    Private Sub OnMnuLastRecentDialog_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each dfTemp As Form In lstRecentDialogs
            If dfTemp.Text = DirectCast(sender, ToolStripMenuItem).Text Then
                dfTemp.ShowDialog()
                Exit Sub
            End If
        Next
    End Sub

    ''' <summary>
    ''' shows all the recent files menu items in the data view window 
    ''' </summary>
    Private Sub ShowAllRecentFiles()
        'clear all menu items previously added 
        ucrDataViewWindow.ClearRecentFileMenuItems()
        'displays items (_in reverse order) for recent files 
        Dim strPath As String
        For iCounter As Integer = lstRecentOpenedFiles.Count - 1 To 0 Step -1
            strPath = lstRecentOpenedFiles(iCounter)
            Try
                Dim linkMenuItem As New LinkLabel
                linkMenuItem.Text = Path.GetFileName(strPath)
                linkMenuItem.Tag = strPath 'path used when the link is clicked

                ucrDataViewWindow.InsertRecentFileMenuItems(linkMenuItem)

                'attach link event handler for opening the file
                AddHandler linkMenuItem.Click, AddressOf OnMnuRecentOpenedFile_Click
            Catch ex As Exception
                'TODO it would be good to remove the invalid line from the file in this case
            End Try
        Next
    End Sub
End Class
