Imports instat.Translations
Public Class dlgAnnualRaintotal
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$annual_rain_total")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub
End Class