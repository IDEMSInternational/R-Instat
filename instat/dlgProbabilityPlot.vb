Public Class dlgProbabilityPlot
    Private Sub dlgProbabilityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcrReceiverSingle1.Selector = ucrAddRemove
        UcrReceiverSingle1.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("qqnorm")
        rdoNormal.Checked = True
        txtTitle.Visible = False

    End Sub
    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrBase.clsRsyntax.AddParameter("y", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)

    End Sub

    Private Sub rdoNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNormal.CheckedChanged
        If rdoNormal.Checked = True Then
            txtTitle.Text = "Normal Probability Plot of " & UcrReceiverSingle1.txtReceiverSingle.Text & ""
        End If

    End Sub

    Private Sub rdoGamma_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGamma.CheckedChanged
        If rdoGamma.Checked = True Then
            txtTitle.Text = "Gamma Probability Plot"
        End If
    End Sub

    Private Sub rdoExtrmeValue_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExtrmeValue.CheckedChanged
        If rdoExtrmeValue.Checked = True Then
            txtTitle.Text = "Extreme Value Probability Plot"
        End If
    End Sub

    Private Sub rdoEmperical_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEmperical.CheckedChanged
        If rdoEmperical.Checked = True Then
            txtTitle.Text = "Emperical Probability Plot"
        End If
    End Sub

    Private Sub rdoExponential_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExponential.CheckedChanged
        If rdoExponential.Checked = True Then
            txtTitle.Text = "Exponential Probability Plot"
        End If
    End Sub
End Class


