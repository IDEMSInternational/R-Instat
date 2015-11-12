Imports instat.Translations
Public Class dlgDisplayRainRunningTotal
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_rain_running_total()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgDisplayRainRunningTotal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class