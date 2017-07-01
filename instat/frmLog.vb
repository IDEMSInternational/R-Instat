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


End Class
