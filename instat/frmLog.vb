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

    Private Sub txtLog_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLog.KeyDown
        If e.Control And Keys.A Then
            selectAllText()
        End If

        If e.Control And Keys.C Then
            copyText()
        End If
    End Sub
End Class
