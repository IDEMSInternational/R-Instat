Imports instat.Translations
Public Class dlgWindPollutionRose
    Private bFirstLoad As Boolean = True
    Private Sub dlgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrChkCompare.SetText("Compare")
        ucrChkNormalise.SetText("Normalise")
        ucrChkPaddle.SetText("Paddle")
    End Sub

End Class