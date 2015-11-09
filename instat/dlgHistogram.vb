Public Class dlgHistogram
    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UcrBase.clsRsyntax.SetFunction("hist")
        UcrSingleReceiver.Selector = UcrAddRemove
    End Sub

    Private Sub UcrReceiverSingle1_Enter(sender As Object, e As EventArgs) Handles UcrSingleReceiver.Enter
        UcrSingleReceiver.SetMeAsReceiver()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles UcrBase.ClickOk
        frmMain.clsRInterface.RunScript(UcrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub UcrReceiverSingle_Leave(sender As Object, e As EventArgs) Handles UcrSingleReceiver.Leave
        UcrBase.clsRsyntax.AddParameter("x", "data$" & UcrSingleReceiver.txtReceiverSingle.Text & "")
    End Sub

    Private Sub txtHistogramTitle_TextChanged(sender As Object, e As EventArgs) Handles txtHistogramTitle.TextChanged
        UcrBase.clsRsyntax.AddParameter("main", Chr(34) & txtHistogramTitle.Text & Chr(34))
    End Sub

    Private Sub UcrAddRemove_Load(sender As Object, e As EventArgs) Handles UcrAddRemove.Load

    End Sub
End Class