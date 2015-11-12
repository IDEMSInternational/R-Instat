Imports instat.Translations
Public Class dlgDisplaySpellLength
    Private Sub UcrButtons1_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_spell_length()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub dlgDisplaySpellLength_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        End Sub
    End Class