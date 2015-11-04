Imports instat.Translations

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
        translateEach(Controls)
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click

    End Sub
End Class
