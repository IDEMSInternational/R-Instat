Public Class dlgProbabilityPlot
    Private Sub dlgProbabilityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("qqnorm")
        UcrReceiverSingle1.Selector = ucrAddRemove
        UcrReceiverSingle1.SetMeAsReceiver()
        rdoNormal.Checked = True
        txtTitle.Visible = False

    End Sub
    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub rdoNormal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNormal.CheckedChanged
        If rdoNormal.Checked = True Then
            txtTitle.Text = "Normal Probability Plof of"
        End If
    End Sub
End Class


