Public Class ucrReceiver
    Public Selector As ucrSelector

    Public Sub AddSelected()

    End Sub

    Private Sub ucrReceiver_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Selector.SetCurrentReciever(Me)
    End Sub

End Class
