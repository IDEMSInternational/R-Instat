Public Class dlgMultipleRegression
    Private Sub dlgMultipleRegression_Load(sender As Object, e As EventArgs) Handles Me.Load
        UcrReceiverSingle1.Selector = UcrSelectorAddRemove1
        UcrReceiverMultiple1.Selector = UcrSelectorAddRemove1
    End Sub

    Private Sub UcrReceiverMultiple1_GotFocus(sender As Object, e As EventArgs) Handles UcrReceiverMultiple1.Enter
        UcrReceiverMultiple1.SetMeAsReceiver()
    End Sub

    Private Sub UcrReceiverSingle1_GotFocus(sender As Object, e As EventArgs) Handles UcrReceiverSingle1.Enter
        UcrReceiverSingle1.SetMeAsReceiver()
    End Sub
End Class