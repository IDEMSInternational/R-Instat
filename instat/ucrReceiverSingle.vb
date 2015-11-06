Public Class ucrReceiverSingle
    Public Overloads Sub AddSelected()
        txtReceiverSingle.Text = Selector.lstAvailableVariable.SelectedItem
    End Sub

    Private Sub txtReceiverSingle_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverSingle.TextChanged

    End Sub
End Class
