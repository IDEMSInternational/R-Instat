Public Class dlgHistogram
    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcrBase.clsRsyntax.SetFunction("hist")
        UcrReceiverSingle1.Selector = UcrSelectorAddRemove1
    End Sub

    Private Sub UcrReceiverSingle1_Enter(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Enter
        UcrReceiverSingle1.SetMeAsReceiver()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        frmMain.clsRInterface.RunScript(UcrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub UcrReceiverSingle1_Leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Leave
        UcrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
    End Sub

    Private Sub txtHistogramTitle_TextChanged(sender As Object, e As EventArgs) Handles txtHistogramTitle.TextChanged
        UcrBase.clsRsyntax.AddParameter("main", Chr(34) & txtHistogramTitle.Text & Chr(34))
    End Sub
End Class