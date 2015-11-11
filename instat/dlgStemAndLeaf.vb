Public Class dlgStemAndLeaf
    Private Sub dlgStemAndLeaf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("stem")
        UcrReceiverSingle1.Selector = UcrAddRemove
        UcrReceiverSingle1.SetMeAsReceiver()
    End Sub

    Private Sub UcrReceiverSingle1_Enter(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Enter

    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 2)
    End Sub

    Private Sub ucrreceiversingle1_leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Leave

    End Sub

End Class