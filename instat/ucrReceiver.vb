Imports instat.Translations
Public Class ucrReceiver
    Public Selector As ucrSelector

    Public Sub AddSelected()

    End Sub

    Private Sub ucrReceiver_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Selector.SetCurrentReciever(Me)
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)

    End Sub
End Class
