Imports instat.Translations
Imports RDotNet
Public Class dlgDisplayDaily
    Private Sub dlgDisplayDaily_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcrBase.clsRsyntax.SetFunction("summary")
        grpsummary.Visible = False
    End Sub

    Private Sub chkSummary_CheckedChanged(sender As Object, e As EventArgs) Handles chkSummary.CheckedChanged
        If chkSummary.Checked = True Then
            grpsummary.Visible = True
        Else
            grpsummary.Visible = False
        End If
    End Sub
    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        frmMain.clsRInterface.RunScript(UcrBase.clsRsyntax.GetScript(), 1)
        'If chkMean.Checked = True Then
        'meanscript
        'End If
        frmMain.clsRInterface.RunScript(UcrBase.clsRsyntax.GetScript(), 2)
    End Sub

    Private Sub UcrBase_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub UcrSelector1_Load(sender As Object, e As EventArgs) Handles UcrSelector1.Load

    End Sub
End Class