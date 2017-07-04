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

Public Class dlgAutoSaveRecovery
    Private strScript As String
    Public strAutoSavedLogScript As String
    Private strLoadDateFilePath As String
    Public strAutoSavedDataFilePaths() As String
    Public strAutoSavedLogFilePaths() As String
    Public strAutoSavedInternalLogFilePaths() As String
    Private bUserClose As Boolean = True

    Private Sub dlgAutoSaveRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'temporary - not yet implemented
        ucrChkSendInternalLog.Visible = False

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
            ucrChkSendInternalLog.Visible = True
            ucrChkSendInternalLog.Checked = True
        Else
            lblBackupInternalLogDetected.Text = "No Backup Debugging Log File Detected"
            cmdSaveInternalLog.Enabled = False
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        End If
        ucrInputSavedPathData.IsReadOnly = True
        ucrInputSavedPathInternalLog.IsReadOnly = True
        ucrInputSavedPathLog.IsReadOnly = True

        cmdNewSession.Enabled = True
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
        If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost." & Environment.NewLine & "Warning: running the log file can fail if files have been moved.", MessageBoxButtons.YesNo, "Are you sure you are finished?") = MsgBoxResult.Yes Then
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
        End If
    End Sub

    Private Sub cmdLoadData_Click(sender As Object, e As EventArgs) Handles cmdLoadData.Click
        If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost.", MessageBoxButtons.YesNo, "Are you finished?") = MsgBoxResult.Yes Then
            SaveFiles()
            strLoadDateFilePath = strAutoSavedDataFilePaths(0)
            bUserClose = False
            Close()
        End If
    End Sub

    Private Sub cmdNewSession_Click(sender As Object, e As EventArgs) Handles cmdNewSession.Click
        If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost.", MessageBoxButtons.YesNo, "Are you finished?") = MsgBoxResult.Yes Then
            SaveFiles()
            bUserClose = False
            Close()
        End If
    End Sub

    Private Sub dlgAutoSaveRecovery_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If bUserClose Then
            If MsgBox("Are you sure you are finished?" & Environment.NewLine & "You cannot return to this dialog after leaving and any unsaved recovered files will be lost.", MessageBoxButtons.YesNo, "Are you finished?") = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
        DeleteTempFiles()
    End Sub

    Private Sub DeleteTempFiles()
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedInternalLogFilePaths(0)) Then
            File.Delete(strAutoSavedInternalLogFilePaths(0))
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedLogFilePaths(0)) Then
            File.Delete(strAutoSavedLogFilePaths(0))
        End If
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedDataFilePaths(0)) Then
            File.Delete(strAutoSavedDataFilePaths(0))
        End If
    End Sub
End Class