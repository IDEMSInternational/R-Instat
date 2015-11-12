Imports instat.Translations
Public Class dlgSeasonalSummaryRain
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$seasonal_summary.rain()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgSeasonalSummaryRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class