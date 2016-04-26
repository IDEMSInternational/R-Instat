Public Class frmLog
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub txtLog_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLog.KeyDown
        If e.Control And e.KeyCode = Keys.A Then
            txtLog.SelectAll()
        End If

        If e.Control And e.KeyCode = Keys.C And txtLog.SelectedText <> "" Then
            txtLog.Copy()
        End If
    End Sub
End Class
