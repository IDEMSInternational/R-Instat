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

Public Class dlgRestoreBackup
    Private strScript As String
    Public strAutoSavedLogScript As String
    Private strLoadDateFilePath As String
    Public strAutoSavedDataFilePaths() As String
    Public strAutoSavedLogFilePaths() As String
    Public strAutoSavedInternalLogFilePaths() As String
    Private bUserClose As Boolean = True
    Public strAutoSaveDataFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_data_auto_save")
    Public strAutoSaveLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_log_auto_save")
    Public strAutoSaveInternalLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_debug_log_auto_save")


    Private Sub dlgRestoreBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.iHelpTopicID = 411
        'temporary - not yet implemented
        ucrChkSendInternalLog.Visible = False
        ucrInputSavedPathData.Visible = ucrChkShowDataFile.Checked
        ucrInputSavedPathLog.Visible = ucrChkShowLogFile.Checked
        ucrInputSavedPathInternalLog.Visible = ucrChkShowInternalLogFile.Checked
        rdoNeither.Checked = True

        If (Directory.Exists(strAutoSaveLogFolderPath)) Then
            strAutoSavedLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveLogFolderPath).ToArray
        End If
        If Directory.Exists(strAutoSaveDataFolderPath) Then
            strAutoSavedDataFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveDataFolderPath).ToArray
        End If
        If (Directory.Exists(strAutoSaveInternalLogFolderPath)) Then
            strAutoSavedInternalLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveInternalLogFolderPath).ToArray
        End If

        ucrBase.contextMenuStripToScript.Enabled = False

        ucrChkSendInternalLog.SetText("Send Debugging Log to R-Instat Team")

        strScript = ""
        strLoadDateFilePath = ""
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 Then
            ucrChkShowDataFile.SetText("Backup Data File Detected")
            rdoLoadBackupData.Enabled = True
        Else
            ucrChkShowDataFile.SetText("No Backup Data File Detected")
            rdoLoadBackupData.Enabled = False
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 Then
            ucrChkShowLogFile.SetText("Backup Log File Detected")
            rdoRunBackupLog.Enabled = True
        Else
            ucrChkShowLogFile.SetText("No Backup Log File Detected")
            rdoRunBackupLog.Enabled = False
        End If
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 Then
            ucrChkShowInternalLogFile.SetText("Backup Debugging Log File Detected")
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        Else
            ucrChkShowInternalLogFile.SetText("No Backup Debugging Log File Detected")
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        End If

        rdoNeither.Enabled = True
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Public Function GetScript() As String
        Return strScript
    End Function

    Public Function GetDataFilePath() As String
        Return strLoadDateFilePath
    End Function

    Private Sub SaveFiles()
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedDataFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathData.IsEmpty() Then
                    File.Copy(strAutoSavedDataFilePaths(0), ucrInputSavedPathData.FilePath(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete data file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedLogFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathLog.IsEmpty() Then
                    File.Copy(strAutoSavedLogFilePaths(0), ucrInputSavedPathLog.FilePath(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete log file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedInternalLogFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathInternalLog.IsEmpty() Then
                    File.Copy(strAutoSavedInternalLogFilePaths(0), ucrInputSavedPathInternalLog.FilePath(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete internal log file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoRunBackupLog.Checked OrElse rdoLoadBackupData.Checked OrElse rdoNeither.Checked Then
            ucrBase.OKEnabled(True)
            bUserClose = False
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrChkShowDataFile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowDataFile.ControlValueChanged, ucrChkShowInternalLogFile.ControlValueChanged, ucrChkShowLogFile.ControlValueChanged
        ucrInputSavedPathData.Visible = ucrChkShowDataFile.Checked
        ucrInputSavedPathLog.Visible = ucrChkShowLogFile.Checked
        ucrInputSavedPathInternalLog.Visible = ucrChkShowInternalLogFile.Checked
    End Sub

    Private Sub rdoRunBackupLog_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRunBackupLog.CheckedChanged
        If rdoRunBackupLog.Checked Then
            SaveFiles()
            If File.Exists(strAutoSavedLogFilePaths(0)) Then
                Try
                    strScript = File.ReadAllText(strAutoSavedLogFilePaths(0))
                Catch ex As Exception
                    MsgBox("Could not read log file." & Environment.NewLine & ex.Message, "Cannot read file")
                    strScript = ""
                End Try
            End If
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoLoadBackupData_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLoadBackupData.CheckedChanged
        If rdoLoadBackupData.Checked Then
            SaveFiles()
            strLoadDateFilePath = strAutoSavedDataFilePaths(0)
            bUserClose = False
        End If
        TestOKEnabled()
    End Sub

End Class