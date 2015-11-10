Public Class dlgBoxPlot


    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("boxplot")
        UcrReceiverSingle1.Selector = UcrAddRemove
    End Sub

    Private Sub UcrReceiverSingle1_Enter(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Enter
        UcrReceiverSingle1.SetMeAsReceiver()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub ucrreceiversingle1_leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Leave
        ucrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTittle.TextChanged
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTittle.Text & Chr(34))
    End Sub

    Private Sub UcrAddRemove_Load(sender As Object, e As EventArgs) Handles UcrAddRemove.Load

    End Sub
End Class