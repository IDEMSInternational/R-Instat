Imports instat.Translations
'Public MustInherit Class ucrReceiver
Public Class ucrReceiver
    Public Selector As ucrSelector

    Public Overridable Sub AddSelected()

    End Sub

    Public Overridable Sub RemoveSelected()

    End Sub

    Public Overridable Function GetVariables() As String

    End Function

    Public Sub SetMeAsReceiver()
        Selector.SetCurrentReciever(Me)
    End Sub

    Private Sub ucrReceiver_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
    End Sub

    Private Sub ucrReceiver_Enter(sender As Object, e As EventArgs) Handles Me.Enter
        SetMeAsReceiver()
    End Sub
End Class
