


Public Class ucrButtons
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        'Gets the current active window 
        Dim ActiveWindow As Form = Form.ActiveForm
        ActiveWindow.Close()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click

    End Sub

    Public Event ClickOk(sender As Object, e As EventArgs)

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        RaiseEvent ClickOk(sender, e)
    End Sub

    Private Sub ucrButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
