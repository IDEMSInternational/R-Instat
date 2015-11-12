Imports instat.Translations
Public Class dlgExportforPICSA
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$export_for_PICSA()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgExportforPICSA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class