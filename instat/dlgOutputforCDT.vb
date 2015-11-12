Imports instat.Translations
Public Class dlgOutputforCDT
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$output_for_CDT()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgOutputforCDT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class