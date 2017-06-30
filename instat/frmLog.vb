Imports RDotNet
Public Class frmLog
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Public Sub copyText()
        txtLog.Copy()
    End Sub

    Public Sub selectAllText()
        txtLog.SelectAll()
    End Sub

    Private Sub frmLog_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewLog.Checked = Me.Visible
    End Sub

    Private Sub mnuOpenLogFile_Click(sender As Object, e As EventArgs) Handles mnuOpenLogFile.Click
        Dim clsProcessStart As New RFunction
        Dim strLogFilename As String = ""
        Dim dlgOpenLogFile As New OpenFileDialog
        clsProcessStart.SetRCommand("Process.Start")
        dlgOpenLogFile.Filter = "All R files|*.R;|All files|*.*;"
        dlgOpenLogFile.Title = "load Log File"
        dlgOpenLogFile.Title = "load Log from file"
        If dlgOpenLogFile.ShowDialog() = DialogResult.OK Then
            If dlgOpenLogFile.FileName <> "" Then
                strLogFilename = dlgOpenLogFile.FileName
            End If
        End If
        clsProcessStart.AddParameter("filename", strLogFilename, bIncludeArgumentName:=False)
        frmMain.clsRLink.RunScript(clsProcessStart.ToScript, strComment:="Loading Script")
    End Sub
End Class
