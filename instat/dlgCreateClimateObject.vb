Imports instat.Translations
Public Class dlgCreateClimateObject

    Private Sub UcrButtons1_clickOk(sender As Object, e As EventArgs) Handles UcrButtons1.ClickOk
        frmMain.clsRInterface.climateObject()
        Me.Hide()
    End Sub

    Private Sub dlgCreateClimateObject_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        UcrButtons1.clsRsyntax.iCalltype = -1
    End Sub

End Class