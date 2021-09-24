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

Imports instat.Translations
Imports System.IO
Public Class dlgBackupManager
    Private strAutoSaveDataFolderPath As String 'holds the folder path for data files. Set by the parent form
    Private strAutoSavedDataFilePaths As List(Of String) 'holds the file paths including the file name
    Private strSelectedDataFilePath As String 'holds the selected file path

    Private Sub dlgBackupManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get the default Auto save Data Folder
        strAutoSaveDataFolderPath = frmMain.strAutoSaveDataFolderPath
        'set selected data file path to empty string
        strSelectedDataFilePath = ""
        LoadFilesInfo()
        SetButtonStates(False)
        'add to the list of last loaded forms
        frmMain.clsRecentItems.addToMenu(Me)
        autoTranslate(Me)
    End Sub

    'loads the files info's into the listview
    Private Sub LoadFilesInfo()
        'clear any previous items
        ctrLstViewDataBackups.Items.Clear()

        'countercheck if the folder really exists then get all the file paths inside the folder
        If Directory.Exists(strAutoSaveDataFolderPath) Then
            strAutoSavedDataFilePaths = My.Computer.FileSystem.GetFiles(frmMain.strAutoSaveDataFolderPath).ToList
        End If

        'if there are files then loop thro to get their info
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 Then
            Dim autoSavedFileInfo As FileInfo
            'Iterate through the path list add the file infos to the listview
            For Each filePath As String In strAutoSavedDataFilePaths
                'create a file info object from the file path, to get file information
                autoSavedFileInfo = New FileInfo(filePath)
                ' Create the listviewitem and initialise it with values for the 3 columns add it to the listview 
                With autoSavedFileInfo
                    ctrLstViewDataBackups.Items.Add(New ListViewItem(New String() { .Name, .LastWriteTime.ToString, GetConvertedFileSize(.Length)}))
                End With
            Next
        End If
    End Sub

    Private Sub ctrLstViewDataBackups_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ctrLstViewDataBackups.ItemSelectionChanged
        TestOk()
    End Sub

    Private Sub cmdOpen_Click(sender As Object, e As EventArgs) Handles cmdOpen.Click
        If (Not TestOk()) Then
            MsgBox("Select the file to open")
            Return
        End If

        If MsgBox("Are you sure you want to open this data file?" & Environment.NewLine & "This will replace the current data.", MessageBoxButtons.YesNo, "Back up Manager") = MsgBoxResult.No Then
            Return
        End If

        'get the selected file path. To be used in opening the file name in form Main
        strSelectedDataFilePath = strAutoSavedDataFilePaths(ctrLstViewDataBackups.SelectedIndices(0))
        If strSelectedDataFilePath <> "" Then
            'pass the selected file to the sub which will load the file to the instant object
            frmMain.clsRLink.LoadInstatDataObjectFromFile(strSelectedDataFilePath, strComment:="Loading auto recovered data file")
        End If

        SetButtonStates(False)
        Close()
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        If (Not TestOk()) Then
            MsgBox("Select the file to save")
            Return
        End If

        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Data File"
            dlgSave.Filter = "RDS Data file (*.RDS)|*.RDS"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                'save the selected file
                SaveFile(strAutoSavedDataFilePaths(ctrLstViewDataBackups.SelectedIndices(0)), dlgSave.FileName)
                'display success message
                MsgBox("Data file successfully saved to " & dlgSave.FileName)
            End If
        End Using
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If (Not TestOk()) Then
            MsgBox("Select the file to delete")
            Return
        End If

        If MsgBox("Are you sure you want to delete this file?" & Environment.NewLine & "You cannot undo this action and all its data will be lost.", MessageBoxButtons.YesNo, "Back up Manager") = MsgBoxResult.No Then
            Return
        End If

        'loop thro deleting the selected files
        For i As Integer = 0 To ctrLstViewDataBackups.SelectedIndices.Count - 1
            'delete the file
            File.Delete(strAutoSavedDataFilePaths(ctrLstViewDataBackups.SelectedIndices(i)))
        Next

        'then reload file info's
        LoadFilesInfo()
        'set the button states accordingly
        TestOk()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        'the help Id for this dialog is not yet known. This is temporary
        Dim iHelpTopicID As Integer = 0
        If iHelpTopicID > 0 Then
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, iHelpTopicID.ToString())
        Else
            Help.ShowHelp(Me.Parent, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TableOfContents)
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        strSelectedDataFilePath = ""
        Close()
    End Sub

    'function to return bytes as KB,MB,GB,TB in a 2 dp string format
    Public Function GetConvertedFileSize(lFileSize As ULong) As String
        Try
            'to hold the division result as a double for formatting
            Dim doubleBytes As Double
            Select Case lFileSize
                Case Is >= 1099511627776
                    doubleBytes = lFileSize / 1099511627776 'TB
                    Return FormatNumber(doubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    doubleBytes = lFileSize / 1073741824 'GB
                    Return FormatNumber(doubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    doubleBytes = lFileSize / 1048576 'MB
                    Return FormatNumber(doubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    doubleBytes = lFileSize / 1024 'KB
                    Return FormatNumber(doubleBytes, 2) & " KB"
                Case 0 To 1023
                    doubleBytes = lFileSize ' bytes
                    Return FormatNumber(doubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch ex As Exception
            Return ""
        End Try
    End Function

    'serves 2 purposes. checks whether the open,save,delete operation are allowed and also sets the controls states
    Private Function TestOk() As Boolean
        If (ctrLstViewDataBackups.Items.Count > 0 AndAlso ctrLstViewDataBackups.SelectedIndices.Count > 0) Then
            SetButtonStates(True, iSelectedIndices:=ctrLstViewDataBackups.SelectedIndices.Count)
            Return True
        Else
            SetButtonStates(False, iSelectedIndices:=ctrLstViewDataBackups.SelectedIndices.Count)
            Return False
        End If
    End Function

    Private Sub SetButtonStates(bState As Boolean, Optional iSelectedIndices As Integer = 0)
        'this is meant to restrict a user from attempting to open or save more than 1 file. Delete is allowed
        If bState AndAlso iSelectedIndices > 1 Then
            cmdOpen.Enabled = False
            cmdSave.Enabled = False
            cmdDelete.Enabled = bState
        Else
            cmdOpen.Enabled = bState
            cmdSave.Enabled = bState
            cmdDelete.Enabled = bState
        End If

    End Sub

    'copies the file to the user destination location
    Private Sub SaveFile(strSourceFileName As String, strDestFilename As String)
        Try
            File.Copy(strSourceFileName, strDestFilename, True)
        Catch ex As Exception
            MsgBox("Could not copy and/or delete data file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
        End Try
    End Sub


End Class