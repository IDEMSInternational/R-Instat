Imports instat.Translations
Public Class dlgCPTtoTabularData
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$SST_domain()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgCPTtoTabularData_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


End Class