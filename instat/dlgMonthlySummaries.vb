Imports instat.Translations
Public Class dlgMonthlySummaries
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$monthly_summary()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgMonthlySummaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class