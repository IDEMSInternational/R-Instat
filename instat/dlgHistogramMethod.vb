Imports instat.Translations
Public Class dlgHistogramMethod
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$histogram")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub
End Class