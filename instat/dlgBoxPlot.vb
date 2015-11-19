Public Class dlgBoxPlot
    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("boxplot")
        ucrBase.clsRsyntax.iCallType = 0
        UcrReceiverSingle.Selector = UcrAddRemove
        UcrReceiverSingle.SetMeAsReceiver()
    End Sub

    Private Sub UcrReceiverSingle1_Enter(sender As Object, e As EventArgs) Handles UcrReceiverSingle.Enter
        UcrReceiverSingle.SetMeAsReceiver()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub ucrReceiverSingle_leave(sender As Object, e As EventArgs) Handles UcrReceiverSingle.Leave
        ucrBase.clsRsyntax.AddParameter("x", UcrReceiverSingle.GetVariables())

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTittle.TextChanged
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTittle.Text & Chr(34))
    End Sub
    Private Sub txtXLabel_TextChanged(sender As Object, e As EventArgs) Handles txtXLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text & Chr(34))
    End Sub
    Private Sub txtYLabel_TextChanged(sender As Object, e As EventArgs) Handles txtYLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text & Chr(34))
    End Sub


End Class