Imports instat.Translations
Public Class dlgMissingData
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$Number_missing_values()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgMissingData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class