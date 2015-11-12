Imports instat.Translations
Public Class dlgDisplayDaily
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_daily_rain()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgDisplayDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class