Public Class frmScript
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Hide()
        End If
    End Sub

    Public Sub copyText()
        txtScript.Copy()
    End Sub

    Public Sub selectAllText()
        txtScript.SelectAll()
    End Sub

    Private Sub frmScript_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewScriptWindow.Checked = Me.Visible
    End Sub
End Class
