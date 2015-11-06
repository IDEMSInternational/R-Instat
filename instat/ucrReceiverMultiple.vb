Public Class ucrReceiverMultiple
    Public Overrides Sub AddSelected()
        Dim objItem As Object
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            lstSelectedVariables.Items.Add(objItem)
            Selector.lstAvailableVariable.Items.Remove(objItem)
        Next
    End Sub

    Public Overrides Sub RemoveSelected()
        Dim objItem As Object
        Dim tempObjects(lstSelectedVariables.SelectedItems.Count - 1) As Object

        lstSelectedVariables.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            Selector.lstAvailableVariable.Items.Add(objItem)
            lstSelectedVariables.Items.Remove(objItem)
        Next
    End Sub

End Class