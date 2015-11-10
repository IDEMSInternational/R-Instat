
Public Class dlgDotPlot
    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("dotchart")
        UcrReceiverSingle1.Selector = ucrAddRemove
    End Sub

    Private Sub UcrReceiverSingle1_Load(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Enter
        UcrReceiverSingle1.SetMeAsReceiver()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub txtTittle_TextChanged(sender As Object, e As EventArgs) Handles txtTittle.TextChanged
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTittle.Text & Chr(34))
    End Sub

    Private Sub UcrReceiverSingle1_Leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
    End Sub
End Class