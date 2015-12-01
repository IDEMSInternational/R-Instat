Public Class dlgBoxPlot
    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("boxplot")
        ucrBase.clsRsyntax.iCallType = 0
        ucrReceiveBoxplotVariable.Selector = UcrAddRemove
        ucrReceiveBoxplotVariable.SetMeAsReceiver()
    End Sub

    Private Sub ucrReceiveBoxplotVariable_Enter(sender As Object, e As EventArgs) Handles ucrReceiveBoxplotVariable.Enter
        ucrReceiveBoxplotVariable.SetMeAsReceiver()
    End Sub

    Private Sub UcrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.clsRInterface.RunScript(ucrBase.clsRsyntax.GetScript(), 0)
    End Sub

    Private Sub ucrReceiveBoxplotVariable_leave(sender As Object, e As EventArgs) Handles ucrReceiveBoxplotVariable.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiveBoxplotVariable.GetVariables())

    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main", Chr(34) & txtTitle.Text & Chr(34))
    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text & Chr(34))
    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text & Chr(34))
    End Sub
End Class