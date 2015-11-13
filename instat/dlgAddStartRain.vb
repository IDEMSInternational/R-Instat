Imports instat.Translations
Public Class dlgAddStartRain
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$add_start_of_rain()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgAddStartRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class