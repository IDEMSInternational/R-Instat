Imports instat.Translations
Public Class ucrReceiver
    Public Selector As ucrSelector

    Public Overridable Sub AddSelected()

    End Sub

    Public Overridable Sub RemoveSelected()

    End Sub

    Public Sub SetMeAsReceiver()
        Selector.SetCurrentReciever(Me)
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
    End Sub
End Class
