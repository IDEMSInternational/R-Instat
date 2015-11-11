Imports instat.Translations
Public Class dlgLines
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$plot_multiple_lines")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub
End Class