
Public Class dlgDotPlot
    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("dotchart")
        UcrReceiverSingle1.Selector = ucrAddRemove
        UcrReceiverSingle1.SetMeAsReceiver()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrBase.clsRsyntax.AddParameter("x", "data$" & UcrReceiverSingle1.txtReceiverSingle.Text & "")
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTittle.Text & Chr(34))
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)
    End Sub
End Class