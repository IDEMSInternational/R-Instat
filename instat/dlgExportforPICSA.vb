Imports instat.Translations
Public Class dlgExportforPICSA
    Public bFirstLoad As Boolean = True

    Private Sub dlgExportforPICSA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.clsRsyntax.SetFunction("climate_obj$export_for_PICSA()")
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    End Class