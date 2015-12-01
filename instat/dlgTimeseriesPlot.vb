Imports instat.Translations
Public Class dlgTimeseriesPlot

    Private Sub dlgTimeseriesPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$timeseries")
        ucrBase.clsRsyntax.iCallType = 0

    End Sub
End Class