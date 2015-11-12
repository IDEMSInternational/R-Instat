Imports instat.Translations
Public Class dlgMissingDataTable
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$missing_data_table()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgMissingDataTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class