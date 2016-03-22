Imports instat.Translations
Public Class dlgDisplaySpellLength
    Public bFirstLoad As Boolean = True
    Private Sub dlgDisplaySpellLength_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)


        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_spell_length()")
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class