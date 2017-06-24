' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports System.IO

Public Class dlgAutoSaveRecovery
    Private strScript As String
    Private strLoadDateFilePath As String
    Public strAutoSavedDataFilePaths() As String
    Public strAutoSavedLogFilePaths() As String
    Public strAutoSavedDebuggingLogFilePaths() As String

    Private Sub dlgAutoSaveRecovery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrChkSendDebuggingLog.SetText("Send Debugging Log to R-Instat Team")
        strScript = ""
        strLoadDateFilePath = ""
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 Then
            lblBackupDataDetected.Text = "Backup Data File Detected"
            cmdSaveData.Enabled = True
        Else
            lblBackupDataDetected.Text = "No Backup Data File Detected"
            cmdSaveData.Enabled = False
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 Then
            lblBackupLogDetected.Text = "Backup Log File Detected"
            cmdSaveLog.Enabled = True
        Else
            lblBackupLogDetected.Text = "No Backup Log File Detected"
            cmdSaveLog.Enabled = False
        End If
        If strAutoSavedDebuggingLogFilePaths IsNot Nothing AndAlso strAutoSavedDebuggingLogFilePaths.Count > 0 Then
            lblBackupDebuggingLogDetected.Text = "Backup Debugging Log File Detected"
            cmdSaveDebuggingLog.Enabled = True
            ucrChkSendDebuggingLog.Visible = True
            ucrChkSendDebuggingLog.Checked = True
        Else
            lblBackupDebuggingLogDetected.Text = "No Backup Debugging Log File Detected"
            cmdSaveDebuggingLog.Enabled = False
            ucrChkSendDebuggingLog.Visible = False
            ucrChkSendDebuggingLog.Checked = False
        End If
        ucrInputSavedPathData.IsReadOnly = True
        ucrInputSavedPathDebuggingLog.IsReadOnly = True
        ucrInputSavedPathLog.IsReadOnly = True

        cmdRunLog.Enabled = False
        cmdLoadData.Enabled = False
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
                strLoadDateFilePath = dlgSave.FileName
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

    Private Sub cmdSaveDebuggingLog_Click(sender As Object, e As EventArgs) Handles cmdSaveDebuggingLog.Click
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Debugging Log File"
            dlgSave.Filter = "R script file (*.R)|*.R"
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputSavedPathDebuggingLog.SetName(dlgSave.FileName)
            Else
                ucrInputSavedPathDebuggingLog.SetName("")
            End If
        End Using
    End Sub

    Private Sub cmdRunLog_Click(sender As Object, e As EventArgs) Handles cmdRunLog.Click
        If MsgBox("Are you sure you are finished? You cannot return to this dialog after leaving and any unsaved recovered files will be lost." & Environment.NewLine & "Warning: running the log file can fail if files have been moved.", MessageBoxButtons.YesNo, "Are you sure you are finished?") Then
            Close()
        End If
    End Sub

    Private Sub SaveFiles()
        If Not ucrInputSavedPathData.IsEmpty Then
            If File.Exists(strAutoSavedDataFilePaths(0)) Then
                Try
                    File.Copy(strAutoSavedDataFilePaths(0), ucrInputSavedPathData.GetText())
                Catch ex As Exception
                    MsgBox("Could not copy data file from: " & strAutoSavedDataFilePaths(0) & " to: " & ucrInputSavedPathLog.GetText() & Environment.NewLine & ex.Message)
                End Try
            End If
        End If
        If Not ucrInputSavedPathLog.IsEmpty Then
            If File.Exists(strAutoSavedLogFilePaths(0)) Then
                Try
                    File.Copy(strAutoSavedLogFilePaths(0), ucrInputSavedPathLog.GetText())
                Catch ex As Exception
                    MsgBox("Could not copy log file from: " & strAutoSavedLogFilePaths(0) & " to: " & ucrInputSavedPathLog.GetText() & Environment.NewLine & ex.Message)
                End Try
            End If
        End If

    End Sub
End Class