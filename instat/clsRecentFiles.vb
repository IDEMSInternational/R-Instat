Imports System.IO
Public Class clsRecentFiles
    Public mnuItems As New List(Of Form)
    Dim strRecentFiles As String = "Recent_Files\recent.mru"
    Dim mnuTbShowLast10 As ToolStripDropDownItem
    Dim mnuFile As ToolStripMenuItem
    Dim sepStart As ToolStripSeparator
    Dim sepEnd As ToolStripSeparator

    ' declare a variable to contain the most recent opened items
    Private strListMRU As New List(Of String)

    Public Sub setToolStripItems(dfMnuFile As ToolStripMenuItem, dfMnuToolStripDropdown As ToolStripDropDownItem, dfSepStart As ToolStripSeparator, dfSepEnd As ToolStripSeparator)
        mnuFile = dfMnuFile
        mnuTbShowLast10 = dfMnuToolStripDropdown
        sepStart = dfSepStart
        sepEnd = dfSepEnd
        sepStart.Visible = False
        sepEnd.Visible = False
    End Sub

    Private ReadOnly Property MRUPath() As String
        'Reads the path where the list of MRU are stored
        Get
            ' returns a path in the static folder, but with a '.mru' extension
            Return Path.GetFullPath(frmMain.strStaticPath & "\" & strRecentFiles)
        End Get
    End Property

    Public Sub checkOnLoad()
        'Checks for the existe3nce of the file on form load
        ' load recently opened files
        If (File.Exists(MRUPath)) Then
            ' read file
            Dim sPaths() As String = File.ReadAllLines(MRUPath)
            For Each sPath As String In sPaths
                If Not String.IsNullOrEmpty(sPath) Then
                    ' only add files that still exist...
                    'If File.Exists(sPath) Then
                    '    ' add to the list of recently opened files
                    '    strListMRU.Add(sPath)
                    'End If
                    strListMRU.Add(sPath)
                End If
            Next
        End If
        ' display the recently opened files if there are any items to display in the file
        If strListMRU.Count > 0 Then UpdateItemsMenu()
    End Sub

    Public Sub saveOnClose()
        ' temp disabled to prevent error accessing file
        ' TODO look up app config and Setting file as alternatives

        'saves the list of opened files on form close
        ' save MRU - delete existing files first
        'If File.Exists(MRUPath) Then
        'File.WriteAllText(MRUPath, "")
        'End If
        ' write each item to the file...
        'For Each sPath As String In strListMRU
        'File.AppendAllText(MRUPath, sPath & vbCrLf)
        'Next
    End Sub

    Public Sub addToMenu(ByVal tempObj As Object)
        Dim dialog As Form 'store reccently opened dialogs
        Dim path As String 'to store recently opened files
        If TypeOf (tempObj) Is Form AndAlso mnuItems IsNot Nothing Then
            dialog = tempObj
            'Checks for existance, else add it to the beginning
            If mnuItems.Contains(dialog) Then mnuItems.Remove(dialog)
            'adds to the list
            mnuItems.Add(dialog)
            'checks that only 1o items are allowed
            While mnuItems.Count > 10
                mnuItems.RemoveAt(0)
            End While
        Else
            path = tempObj
            If strListMRU.Contains(path) Then strListMRU.Remove(path)
            ' add to MRU list..
            strListMRU.Add(path)
            ' make sure there are only ever 5 items...
            'To add this to the general options on the number of recently files to show
            While strListMRU.Count > 5
                strListMRU.RemoveAt(0)
            End While
        End If

        'updates the interfaces
        UpdateItemsMenu()

    End Sub

    Private Sub UpdateItemsMenu()
        'clears the menu items first
        Dim clsItems As New List(Of ToolStripItem)
        If mnuTbShowLast10 IsNot Nothing AndAlso mnuFile IsNot Nothing AndAlso clsItems IsNot Nothing AndAlso mnuItems IsNot Nothing AndAlso strListMRU IsNot Nothing Then
            'temp collection for recent dialogs
            For Each clsMenu As ToolStripItem In mnuTbShowLast10.DropDownItems
                If Not clsMenu.Tag Is Nothing Then
                    If (clsMenu.Tag.ToString().StartsWith("Last")) Then
                        clsItems.Add(clsMenu)
                    End If
                End If
            Next
            'temp collection for recent files
            For Each clsMenu As ToolStripItem In mnuFile.DropDownItems
                If Not clsMenu.Tag Is Nothing Then
                    If (clsMenu.Tag.ToString().StartsWith("MRU:")) Then
                        clsItems.Add(clsMenu)
                    End If
                End If
            Next
            'go through the list and remove each from the menu
            For Each clsMenu As ToolStripItem In clsItems
                mnuTbShowLast10.DropDownItems.Remove(clsMenu)
                mnuFile.DropDownItems.Remove(clsMenu)
            Next

            'displays items (_in reverse order) for dialogs
            For icounter As Integer = mnuItems.Count - 1 To 0 Step -1
                Dim dialog As Form = mnuItems(icounter)
                'creates new toolstripitem, displaying name of the dialog
                Dim clsItem As New ToolStripMenuItem(dialog.Text)
                'sets the tag
                clsItem.Tag = "Last"
                AddHandler clsItem.Click, AddressOf mnuFile_Click
                'insert into the dropdownitems
                mnuTbShowLast10.DropDownItems.Insert(mnuTbShowLast10.DropDownItems.Count - 1, clsItem)
            Next

            'displays items (_in reverse order) for recent files
            For iCounter As Integer = strListMRU.Count - 1 To 0 Step -1
                Dim sPath As String = strListMRU(iCounter)
                ' create new ToolStripItem, displaying the name of the file...
                Dim clsItem As New ToolStripMenuItem(Path.GetFileName(sPath))
                ' set the tag - identifies the ToolStripItem as an MRU item and 
                ' contains the full path so it can be opened later...
                clsItem.Tag = "MRU:" & sPath
                ' hook into the click event handler so we can open the file later...
                AddHandler clsItem.Click, AddressOf mnuFileMRU_Click
                ' insert into DropDownItems list...
                mnuFile.DropDownItems.Insert(mnuFile.DropDownItems.Count - 2, clsItem)
            Next

            ' show separator
            frmMain.sepEndMRU.Visible = True
            sepStart.Visible = True
            sepEnd.Visible = True
        End If
    End Sub

    Private Sub mnuFileMRU_Click(ByVal sender As Object, ByVal e As EventArgs)
        If File.Exists(DirectCast(sender, ToolStripItem).Tag.ToString().Substring(4)) Then
            'dlgImportDataset.SetFilePath(DirectCast(sender, ToolStripItem).Tag.ToString().Substring(4))
            'dlgImportDataset.SetDataName(Path.GetFileNameWithoutExtension(sender.ToString))
            'Not working as I would like because of the changes made to the Import Dataset
            dlgImportDataset.ShowDialog()

        Else
            MessageBox.Show(frmMain, "The file has either been moved or deleted", "Error trying to open file")
            'removes the path to the non existent file
            strListMRU.RemoveAt(strListMRU.FindLastIndex(Function(value As String)
                                                             Return value.Contains(sender.ToString)
                                                         End Function))
            'updates the interfaces
            UpdateItemsMenu()
        End If
    End Sub

    Private Sub mnuFile_Click(ByVal sender As Object, ByVal e As EventArgs)
        For Each dfTemp As Form In mnuItems
            If dfTemp.Text = sender.ToString Then
                dfTemp.ShowDialog()
                Exit Sub
            End If
        Next
    End Sub

End Class
