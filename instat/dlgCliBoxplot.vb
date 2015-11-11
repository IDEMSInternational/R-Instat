Imports instat.Translations
Public Class dlgCliBoxplot

    Private Sub dlgCliBoxplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$cliboxplot")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

End Class