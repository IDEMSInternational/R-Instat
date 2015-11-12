Imports instat.Translations
Public Class dlgRainStats
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$rain_stats()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgRainStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class