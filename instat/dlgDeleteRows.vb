Imports instat.Translations
Public Class dlgDeleteRows
    Private Sub dlgDeleteRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("subset")
        ucrBase.clsRsyntax.iCallType = 1
        ucrReceiverDeleteRows.Selector = ucrAddRemove
        ucrReceiverDeleteRows.SetMeAsReceiver()
        autoTranslate(Me)

    End Sub
    Private Sub ucrReceiverDeleteRows_Enter(sender As Object, e As EventArgs) Handles ucrReceiverDeleteRows.Enter
        ucrReceiverDeleteRows.SetMeAsReceiver()
    End Sub
    Private Sub ucrReceiverDeleteColumns_Leave(sender As Object, e As EventArgs) Handles ucrReceiverDeleteRows.Leave
        ucrBase.clsRsyntax.AddParameter("x", ucrReceiverDeleteRows.GetVariables())
    End Sub
    Private Sub lstRowsToDelete_Leave(sender As Object, e As EventArgs) Handles lstRowsToDelete.Leave
        ucrBase.clsRsyntax.AddParameter("select", Chr(34) & lstRowsToDelete.Text & Chr(34))
    End Sub
End Class