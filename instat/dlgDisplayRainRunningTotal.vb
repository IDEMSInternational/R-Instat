Imports instat.Translations
Public Class dlgDisplayRainRunningTotal
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True

    Private Sub dlgDisplayRainRunningTotal_(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 
        ucrBase.OKEnabled(False)

        'ucrNudDecimalPlaces.SetParameter(New RParameter(" ", ))
        'ucrNudThreshold.SetParameter(New RParameter(" ", ))
        'ucrNudTotalDays.SetParameter(New RParameter(" ", ))

        'ucrChkMonthList.SetParameter(New RParameter("", 0))
        ucrChkMonthList.SetText("Month List")
        'ucrChkMonthList.SetRDefault(" ")

        'ucrChkRemoveMissingValues.SetParameter(New RParameter("", 2))
        ucrChkRemoveMissingValues.SetText("Remove Missing Values")
        'ucrChkRemoveMissingValues.SetRDefault(" ")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        clsDefaultFunction.SetRCommand("climate_obj$display_rain_running_total()")
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOKEnabled()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'ControlContentsChanged for TestOKEnabled()
End Class