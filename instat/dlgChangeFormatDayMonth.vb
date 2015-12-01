Imports instat.Translations
Public Class dlgChangeFormatDayMonth
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$change_format_day_month()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgChangeFormatDayMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class