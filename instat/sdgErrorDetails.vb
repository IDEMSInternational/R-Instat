Public Class sdgErrorDetails
    Private Sub sdgErrorDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputErrorMessage.IsMultiline = True
        ucrInputErrorMessage.IsReadOnly = True
    End Sub
    Public Sub setErrorText(Message As String)
        ucrInputErrorMessage.SetText(Message)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class