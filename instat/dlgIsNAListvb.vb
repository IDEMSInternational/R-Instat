Imports instat.Translations
Public Class dlgIsNAList
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$isna.list()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgIsNAList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class