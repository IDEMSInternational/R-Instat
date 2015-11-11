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

        If lstSelectedVariables.SelectedItems.Count > 0 Then
            lstSelectedVariables.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                Selector.lstAvailableVariable.Items.Add(objItem)
                lstSelectedVariables.Items.Remove(objItem)
            Next
        Else
            MsgBox("There is nothing to remove", vbInformation, "Selection message")
        End If
    End Sub

    Public Event LeftList(sender As Object, e As EventArgs)

    Public Overrides Sub EnterReceiver()
        lstSelectedVariables.Focus()
    End Sub

    Private Sub lstSelectedVariables_Leave(sender As Object, e As EventArgs) Handles lstSelectedVariables.Leave
        RaiseEvent LeftList(sender, e)
    End Sub

End Class