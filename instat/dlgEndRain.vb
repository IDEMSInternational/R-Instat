Imports instat.Translations
Public Class dlgEndRain
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$add_end_rain()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgEndRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class