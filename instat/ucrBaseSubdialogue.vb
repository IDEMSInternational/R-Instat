Public Class ucrBaseSubdialogue
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Dim ActiveWindow As Form = Form.ActiveForm
        ActiveWindow.Close()
    End Sub
End Class
