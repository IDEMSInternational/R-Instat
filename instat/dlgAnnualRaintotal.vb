Imports instat.Translations
Public Class dlgAnnualRaintotal
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$plot_annual_rain_total")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub
End Class