Imports instat.Translations
Imports RDotNet
Public Class dlgInstallRPackage
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private bUniqueChecked As Boolean = False
    Private clsInstallPackage As New RFunction
    Private clsRepositoryFunction As New RFunction
    Private clsBeforeOptionsFunc As New RFunction
    Private clsAfterOptionsFunc As New RFunction
    Private clsDummyFunction As New RFunction

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
        bUniqueChecked = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 592
        ucrBase.clsRsyntax.iCallType = 2
        ucrInputTextBoxRPackage.SetParameter(New RParameter("pkgs", 1))
        ucrPnlRPackages.AddRadioButton(rdoCRAN)
        ucrPnlRPackages.AddRadioButton(rdoRPackage)

        ucrInputRepositoryName.SetLinkedDisplayControl(lblRepository)

        ucrPnlRPackages.AddParameterValuesCondition(rdoCRAN, "checked", "cran")
        ucrPnlRPackages.AddParameterValuesCondition(rdoRPackage, "checked", "rpackage")

        ucrInputMessage.SetLinkedDisplayControl(cmdCheck)

        ucrPnlRPackages.AddToLinkedControls(ucrInputRepositoryName, {rdoRPackage}, bNewLinkedHideIfParameterMissing:=True)

        CheckEnable()
    End Sub

    Private Sub SetDefaults()
        clsInstallPackage = New RFunction
        clsBeforeOptionsFunc = New RFunction
        clsAfterOptionsFunc = New RFunction
        clsRepositoryFunction = New RFunction
        clsDummyFunction = New RFunction
        bUniqueChecked = False

        clsDummyFunction.AddParameter("checked", "cran", iPosition:=1)

        clsInstallPackage.SetRCommand("install.packages")
        clsInstallPackage.AddParameter("repos", Chr(34) & "https://cran.rstudio.com/" & Chr(34), iPosition:=1)

        clsBeforeOptionsFunc.SetRCommand("options")
        clsBeforeOptionsFunc.AddParameter(strParameterName:="warn", strParameterValue:="2")

        clsRepositoryFunction.SetRCommand("install_github")
        clsRepositoryFunction.SetPackageName("devtools")

        clsAfterOptionsFunc.SetRCommand("options")
        clsAfterOptionsFunc.AddParameter(strParameterName:="warn", strParameterValue:="0")

        ucrBase.clsRsyntax.SetBaseRFunction(clsInstallPackage)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputTextBoxRPackage.SetRCode(clsInstallPackage, bReset)
        If bReset Then
            ucrPnlRPackages.SetRCode(clsDummyFunction, bReset)
            ucrInputRepositoryName.SetRCode(clsRepositoryFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If rdoCRAN.Checked Then
            ucrBase.OKEnabled(Not ucrInputTextBoxRPackage.IsEmpty)
        ElseIf rdoRPackage.Checked Then
            ucrBase.OKEnabled(Not ucrInputRepositoryName.IsEmpty AndAlso Not ucrInputTextBoxRPackage.IsEmpty AndAlso bUniqueChecked)
        End If
    End Sub

    Private Sub ucrInputTextBoxRPackage_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputTextBoxRPackage.ControlContentsChanged
        bUniqueChecked = False
        ucrInputMessage.SetText("")
        ucrInputMessage.txtInput.BackColor = Color.White
        CheckEnable()
        TestOkEnabled()
        GithubOption()
    End Sub

    Private Sub Check()
        Dim clsPackageCheck As New RFunction
        Dim expOutput As SymbolicExpression
        Dim chrOutput As CharacterVector

        If rdoCRAN.Checked Then
            clsPackageCheck.SetRCommand("package_check")
            clsPackageCheck.AddParameter("package", Chr(34) & ucrInputTextBoxRPackage.GetText() & Chr(34))
        ElseIf rdoRPackage.Checked Then
            clsPackageCheck.SetRCommand("check_github_repo")
            clsPackageCheck.AddParameter("repo", Chr(34) & ucrInputTextBoxRPackage.GetText() & Chr(34))
            clsPackageCheck.AddParameter("owner", Chr(34) & ucrInputRepositoryName.GetText() & Chr(34))
        End If
        expOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsPackageCheck.ToScript(), bSilent:=True)
        If expOutput Is Nothing OrElse expOutput.Type = Internals.SymbolicExpressionType.Null Then
            ucrInputMessage.SetText("Cannot get package information.")
            Exit Sub
        End If

        chrOutput = expOutput.AsCharacter
        If chrOutput.Count < 1 Then
            ucrInputMessage.SetText("Cannot get package information.")
            Exit Sub
        End If
        Select Case chrOutput(0)
            Case "1"
                bUniqueChecked = True
                If rdoCRAN.Checked Then
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
                ElseIf rdoRPackage.Checked Then
                    ucrInputMessage.SetText("Package exists in the repo and is ready for installation")
                    ucrInputMessage.txtInput.BackColor = Color.LightGreen
                End If
            Case "2"
                If rdoCRAN.Checked Then
                    ucrInputMessage.SetText("Package exists and not currently installed.")
                    ucrInputMessage.txtInput.BackColor = Color.LightGreen
                ElseIf rdoRPackage.Checked Then
                    ucrInputMessage.SetText("Package exists in the repo but is not in the R language")
                    ucrInputMessage.txtInput.BackColor = Color.LightGreen
                End If
            Case "3"
                If rdoCRAN.Checked Then
                    ucrInputMessage.SetText("Package is installed but not a current CRAN package")
                    ucrInputMessage.txtInput.BackColor = Color.LightBlue
                ElseIf rdoRPackage.Checked Then
                    ucrInputMessage.SetText("Not a package in the given repo. Perhaps spelled wrongly?")
                    ucrInputMessage.txtInput.BackColor = Color.LightCoral
                    bUniqueChecked = False
                End If
            Case "4"
                ucrInputMessage.SetText("Not a current CRAN package. Perhaps spelled wrongly, or archived?")
                ucrInputMessage.txtInput.BackColor = Color.LightSkyBlue
                bUniqueChecked = False
            Case "5"
                ucrInputMessage.SetText("No internet connection.Try reconnecting")
                ucrInputMessage.txtInput.BackColor = Color.LightCoral
                bUniqueChecked = False
        End Select
        TestOkEnabled()
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

    Private Sub ucrPnlRPackages_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRPackages.ControlValueChanged
        If rdoCRAN.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInstallPackage)
            ucrBase.clsRsyntax.AddToBeforeCodes(clsBeforeOptionsFunc)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAfterOptionsFunc)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsRepositoryFunction)
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsBeforeOptionsFunc)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAfterOptionsFunc)
        End If
        ucrInputTextBoxRPackage.txtInput.Clear()
    End Sub

    Private Sub ucrInputRepositoryName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputRepositoryName.ControlContentsChanged
        TestOkEnabled()
        GithubOption()
        bUniqueChecked = False
    End Sub

    Private Sub GithubOption()
        If Not (ucrInputTextBoxRPackage.IsEmpty AndAlso ucrInputRepositoryName.IsEmpty) Then
            clsRepositoryFunction.AddParameter("paste", Chr(34) & ucrInputRepositoryName.GetText & "/" & ucrInputTextBoxRPackage.GetText & Chr(34), bIncludeArgumentName:=False)
        Else
            clsRepositoryFunction.RemoveParameterByName("paste")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
End Class