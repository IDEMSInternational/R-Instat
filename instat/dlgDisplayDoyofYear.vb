Imports instat.Translations
Public Class dlgDisplayDOYofYear
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_doy()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgDisplayDoyofYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class