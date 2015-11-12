Imports instat.Translations
Public Class dlgDisplayDailyDataRain
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_daily_rain()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgDisplayDailyDataRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class