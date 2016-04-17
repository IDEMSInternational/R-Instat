Public Class frmScript
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Private Sub txtScript_KeyUp(sender As Object, e As KeyEventArgs) Handles txtScript.KeyUp
        If e.Control And e.KeyCode = Keys.A Then
            txtScript.SelectAll()
        End If

        If e.Control And e.KeyCode = Keys.C And txtScript.SelectedText <> "" Then
            txtScript.Copy()
        End If
    End Sub
End Class