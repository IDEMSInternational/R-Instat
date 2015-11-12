Imports instat.Translations
Public Class dlgBoxplotCountVariable
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$boxplot_method()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgBoxplotCountVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class