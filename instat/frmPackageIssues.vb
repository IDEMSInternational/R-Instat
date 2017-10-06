Public Class frmPackageIssues
    Private bFirstLoad As Boolean = True
    Private strMissingPackages() As String
    Private clsInstallPackages As New RFunction

    Private Sub frmPackageIssues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrInputPackageNames.txtInput.Multiline = True
        ucrInputPackageNames.IsReadOnly = True
    End Sub

    Public Sub SetMissingPackages(strMissing() As String)
        Dim clsPackageList As New RFunction

        clsInstallPackages = New RFunction

        strMissingPackages = strMissing
        ucrInputPackageNames.SetName(String.Join(", ", strMissingPackages))
        clsInstallPackages.SetRCommand("install.packages")
        clsPackageList.SetRCommand("c")
        For i As Integer = 0 To strMissingPackages.Count - 1
            clsPackageList.AddParameter(i, Chr(34) & strMissingPackages(i) & Chr(34), iPosition:=i, bIncludeArgumentName:=False)
        Next
        clsInstallPackages.AddParameter("pkgs", clsRFunctionParameter:=clsPackageList, iPosition:=0)
        clsInstallPackages.AddParameter("repos", Chr(34) & "https://cran.rstudio.com/" & Chr(34))
    End Sub

    Private Sub cmdInstallPackages_Click(sender As Object, e As EventArgs) Handles cmdInstallPackages.Click
        Dim strCurrentMissingPackages() As String

        Cursor = Cursors.WaitCursor
        Me.Enabled = False
        frmMain.clsRLink.RunInternalScript(clsInstallPackages.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False)
        strCurrentMissingPackages = frmMain.clsRLink.GetPackagesNotInstalled()
        If strCurrentMissingPackages IsNot Nothing AndAlso strCurrentMissingPackages.Length > 0 Then
            MsgBox("Some packages could still not be installed. Try the alternative suggestions or contact the R-Instat help team." & vbNewLine & "You can continue to use R-Instat, however some functionality may be unavailable." & vbNewLine & "Click OK to see the packages still missing.", MsgBoxStyle.Information, Title:="Some packages still missing")
            SetMissingPackages(strCurrentMissingPackages)
        Else
            MsgBox("Congratulations! All missing packages were successfully installed. You can now continue using R-Instat.", MsgBoxStyle.Information, Title:="Missing packages successfully installed")
            frmMain.clsRLink.RunInternalScript(clsInstallPackages.ToScript(), bSeparateThread:=False, bShowWaitDialogOverride:=False, bSilent:=True)
            frmMain.clsRLink.LoadedRequiredPackages(bSilent:=True)
            Me.Close()
        End If
        Me.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class