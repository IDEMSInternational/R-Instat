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
        'temporary - not yet implemented
        ucrChkSendInternalLog.Visible = False

        If (Directory.Exists(strAutoSaveLogFolderPath)) Then
            strAutoSavedLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveLogFolderPath).ToArray
        End If
        If Directory.Exists(strAutoSaveDataFolderPath) Then
            strAutoSavedDataFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveDataFolderPath).ToArray
        End If
        If (Directory.Exists(strAutoSaveInternalLogFolderPath)) Then
            strAutoSavedInternalLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveInternalLogFolderPath).ToArray
        End If

        ucrBase.OKEnabled(False)
        ucrBase.contextMenuStripToScript.Enabled = False

        ucrChkSendInternalLog.SetText("Send Debugging Log to R-Instat Team")
        strScript = ""
        strLoadDateFilePath = ""
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 Then
            lblBackupDataDetected.Text = "Backup Data File Detected"
            cmdSaveData.Enabled = True
            cmdLoadData.Enabled = True
        Else
            lblBackupDataDetected.Text = "No Backup Data File Detected"
            cmdSaveData.Enabled = False
            cmdLoadData.Enabled = False
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 Then
            lblBackupLogDetected.Text = "Backup Log File Detected"
            cmdSaveLog.Enabled = True
            cmdRunLog.Enabled = True
        Else
            lblBackupLogDetected.Text = "No Backup Log File Detected"
            cmdSaveLog.Enabled = False
            cmdRunLog.Enabled = False
        End If
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 Then
            lblBackupInternalLogDetected.Text = "Backup Debugging Log File Detected"
            cmdSaveInternalLog.Enabled = True
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        Else
            lblBackupInternalLogDetected.Text = "No Backup Debugging Log File Detected"
            cmdSaveInternalLog.Enabled = False
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        End If
        ucrInputSavedPathData.IsReadOnly = True
        ucrInputSavedPathInternalLog.IsReadOnly = True
        ucrInputSavedPathLog.IsReadOnly = True

        cmdCloseSession.Enabled = True
        autoTranslate(Me)
    End Sub

    Public Function GetScript() As String
        Return strScript
    End Function

    Public Function GetDataFilePath() As String
        Return strLoadDateFilePath
    End Function

    Private Sub cmdSaveData_Click(sender As Object, e As EventArgs) Handles cmdSaveData.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Data File"
            dlgSave.Filter = "RDS Data file (*.RDS)|*.RDS"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputSavedPathData.SetName(dlgSave.FileName)
            Else
                ucrInputSavedPathData.SetName("")
            End If
        End Using
    End Sub

    Private Sub cmdSaveLog_Click(sender As Object, e As EventArgs) Handles cmdSaveLog.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Log File"
            dlgSave.Filter = "R script file (*.R)|*.R"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputSavedPathLog.SetName(dlgSave.FileName)
            Else
                ucrInputSavedPathLog.SetName("")
            End If
        End Using
    End Sub

    Private Sub cmdSaveDebuggingLog_Click(sender As Object, e As EventArgs) Handles cmdSaveInternalLog.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Debugging Log File"
            dlgSave.Filter = "R script file (*.R)|*.R"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputSavedPathInternalLog.SetName(dlgSave.FileName)
            Else
                ucrInputSavedPathInternalLog.SetName("")
            End If
        End Using
    End Sub

    Private Sub SaveFiles()
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedDataFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathData.IsEmpty() Then
                    File.Copy(strAutoSavedDataFilePaths(0), ucrInputSavedPathData.GetText(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete data file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedLogFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathLog.IsEmpty() Then
                    File.Copy(strAutoSavedLogFilePaths(0), ucrInputSavedPathLog.GetText(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete log file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedInternalLogFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathInternalLog.IsEmpty() Then
                    File.Copy(strAutoSavedInternalLogFilePaths(0), ucrInputSavedPathInternalLog.GetText(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete internal log file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
    End Sub

    Private Sub cmdRunLog_Click(sender As Object, e As EventArgs) Handles cmdRunLog.Click
        SaveFiles()
        If File.Exists(strAutoSavedLogFilePaths(0)) Then
                Try
                    strScript = File.ReadAllText(strAutoSavedLogFilePaths(0))
                Catch ex As Exception
                    MsgBox("Could not read log file." & Environment.NewLine & ex.Message, "Cannot read file")
                    strScript = ""
                End Try
            End If
            bUserClose = False
            Close()

    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost.", MessageBoxButtons.YesNo, "Are you finished?") = MsgBoxResult.Yes Then
            SaveFiles()
            strLoadDateFilePath = strAutoSavedDataFilePaths(0)
            bUserClose = False
            Close()
        End If
    End Sub

    Private Sub cmdCloseSession_Click(sender As Object, e As EventArgs) Handles cmdCloseSession.Click
        If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost.", MessageBoxButtons.YesNo, "Are you finished?") = MsgBoxResult.Yes Then
            SaveFiles()
            bUserClose = False
            Close()
        End If
    End Sub

    Private Sub dlgRestoreBackup_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bUserClose Then
            If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost.", MessageBoxButtons.YesNo, "Are you finished?") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
        DeleteTempFiles()
    End Sub

    Private Sub DeleteTempFiles()
        ' No longer needed as now done after closing
        'If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedInternalLogFilePaths(0)) Then
        '    File.Delete(strAutoSavedInternalLogFilePaths(0))
        'End If
        'If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedLogFilePaths(0)) Then
        '    File.Delete(strAutoSavedLogFilePaths(0))
        'End If
        'If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedDataFilePaths(0)) Then
        '    File.Delete(strAutoSavedDataFilePaths(0))
        'End If
    End Sub
End Class