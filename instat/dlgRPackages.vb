Imports instat
Imports RDotNet
Public Class dlgInstallRPackage
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsInstallPackage As New RFunction
    Private clsBeforeOptionsFunc As New RFunction
    Private clsAfterOptionsFunc As New RFunction

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
        ucrBase.iHelpTopicID = 592
        ucrBase.clsRsyntax.iCallType = 2
        ucrInputTextBoxRPackage.SetParameter(New RParameter("pkgs", 1))
        CheckEnable()
    End Sub

    Private Sub SetDefaults()
        clsInstallPackage = New RFunction
        clsBeforeOptionsFunc = New RFunction
        clsAfterOptionsFunc = New RFunction

        clsInstallPackage.SetRCommand("install.packages")
        clsInstallPackage.AddParameter("repos", Chr(34) & "https://cran.rstudio.com/" & Chr(34), iPosition:=1)

        clsBeforeOptionsFunc.SetRCommand("options")
        clsBeforeOptionsFunc.AddParameter(strParameterName:="warn", strParameterValue:="2")


        clsAfterOptionsFunc.SetRCommand("options")
        clsAfterOptionsFunc.AddParameter(strParameterName:="warn", strParameterValue:="0")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsBeforeOptionsFunc)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAfterOptionsFunc)
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
        ucrInputMessage.SetText("")
        ucrInputMessage.txtInput.BackColor = Color.White
        CheckEnable()
        TestOkEnabled()
    End Sub

    Private Sub Check()
        Dim clsPackageCheck As New RFunction
        Dim expOutput As SymbolicExpression
        Dim chrOutput As CharacterVector

        clsPackageCheck.SetRCommand("package_check")
        clsPackageCheck.AddParameter("package", Chr(34) & ucrInputTextBoxRPackage.GetText() & Chr(34))

        expOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsPackageCheck.ToScript(), bSilent:=True)
        If expOutput IsNot Nothing AndAlso Not expOutput.Type = Internals.SymbolicExpressionType.Null Then
            chrOutput = expOutput.AsCharacter
            If chrOutput.Count >= 1 Then
                If chrOutput(0) = "0" Then
                    ucrInputMessage.SetText("No package with this name.")
                    ucrInputMessage.txtInput.BackColor = Color.LightCoral
                ElseIf chrOutput(0) = "2" Then
                    ucrInputMessage.SetText("Package exists and not currently installed.")
                    ucrInputMessage.txtInput.BackColor = Color.LightGreen
                ElseIf chrOutput(0) = "1" Then
                    If chrOutput.Count = 4 Then
                        If chrOutput(1) = "0" Then
                            ucrInputMessage.SetText("Package is installed and up to date.")
                            ucrInputMessage.txtInput.BackColor = Color.Yellow
                        ElseIf chrOutput(1) = "-1" Then
                            ucrInputMessage.SetText("Package is installed. Newer version available: " & chrOutput(3) & " (current: " & chrOutput(2) & ").")
                        End If
                    Else
                        ucrInputMessage.SetText("Package is installed. No version information available.")
                    End If
                End If
            Else
                ucrInputMessage.SetText("Cannot get package information.")
            End If
        Else
            ucrInputMessage.SetText("Cannot get package information. Check your internet connection.")
        End If
    End Sub

    Private Sub CheckEnable()
        If Not ucrInputTextBoxRPackage.IsEmpty Then
            cmdCheck.Enabled = True
            ucrInputMessage.Enabled = True
        Else
            cmdCheck.Enabled = False
            ucrInputMessage.Enabled = False
        End If
    End Sub

    Private Sub cmdCheck_Click(sender As Object, e As EventArgs) Handles cmdCheck.Click
        check()
    End Sub
End Class