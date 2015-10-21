Public Class ucrButtons
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        'Gets the current active window 
        Dim ActiveWindow As Form = Form.ActiveForm
        ActiveWindow.Close()
    End Sub
End Class
