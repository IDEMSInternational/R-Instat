Imports instat

Public Class dlgRPackages
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsInstallPackage As New RFunction
    Private Sub dlgRPackages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrInputTextBoxRPackage.SetParameter(New RParameter("package", 1))

    End Sub

    Private Sub SetDefaults()
        clsInstallPackage = New RFunction
        clsInstallPackage.SetRCommand("install.packages")
        ucrBase.clsRsyntax.SetBaseRFunction(clsInstallPackage)
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputTextBoxRPackage.SetRCode(clsInstallPackage, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrInputTextBoxRPackage.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrInputTextBoxRPackage_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputTextBoxRPackage.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class