Public Class ucrReceiverSingle
    Public Overrides Sub AddSelected()
        Dim objItem As Object
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            txtReceiverSingle.Text = objItem
            Selector.lstAvailableVariable.Items.Remove(objItem)
        Next
    End Sub

    Public Overrides Sub RemoveSelected()
        Dim objItem As Object
        Dim tempObjects(0) As Object
        If txtReceiverSingle.Text <> "" Then
            tempObjects(0) = txtReceiverSingle.Text
            For Each objItem In tempObjects
                Selector.lstAvailableVariable.Items.Add(objItem)
                txtReceiverSingle.Text = Nothing
            Next
        End If
    End Sub
End Class
