Public Class dlgEndOfRains
    Dim sender As Object
    Dim e As EventArgs
    Private Sub UcrButtons1_clickOk(sender, e) Handles UcrButtons1.ClickOk
        Dim strScript As String
        strScript = "data_obj$add_end_of_rain();data_obj$used_data_objects$'data yearly'$data"
        frmMain.clsRInterface.climateObject()
        frmMain.clsRInterface.RunScript(strScript)
    End Sub
    Private Sub UcrButtons1_Load(sender, e) Handles UcrButtons1.Load

    End Sub
End Class