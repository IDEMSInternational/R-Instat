Imports instat.Translations
Public Class dlgDayMonth
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$day_month()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgDayMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class