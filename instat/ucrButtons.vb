Imports instat.Translations
Public Class ucrButtons
    Public clsRsyntax As New RSyntax

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.ParentForm.Hide()
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        RaiseEvent ClickReset(sender, e)
    End Sub

    Public Event ClickOk(sender As Object, e As EventArgs)
    Public Event ClickReset(sender As Object, e As EventArgs)

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click
        frmMain.clsRLink.RunScript(clsRsyntax.GetScript(), clsRsyntax.iCallType)
        RaiseEvent ClickOk(sender, e)

        Me.ParentForm.Hide()
    End Sub

    Public Sub OKEnabled(bEnabled As Boolean)
        cmdOk.Enabled = bEnabled
        cmdPaste.Enabled = bEnabled
    End Sub

    Private Sub ucrButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        translateEach(Controls)
    End Sub

    Private Sub cmdPaste_Click(sender As Object, e As EventArgs) Handles cmdPaste.Click
        frmScript.txtScript.Text = frmScript.txtScript.Text & vbCrLf & clsRsyntax.GetScript()
    End Sub

End Class
