Imports instat.Translations
Public Class dlgCliPlot

    Private Sub dlgCliPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$cliplot")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

End Class