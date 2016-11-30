Imports instat.Translations
Public Class dlgDisplayDOYofYear
    Public bFirstLoad As Boolean = True
    Private Sub dlgDisplayDOYofYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)



        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("climate_obj$display_doy()")
    End Sub
    Private Sub SetDefaults()

    End Sub
    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOKEnabled()

    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub


End Class