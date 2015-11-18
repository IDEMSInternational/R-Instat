Public Class ucrReceiverMultiple
    Dim objSelected As New List(Of ListViewItem)
    Public Overrides Sub AddSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            If Not objSelected.Contains(objItem) Then
                objSelected.Add(objItem)
                lstSelectedVariables.Items.Add(objItem.Text)
            End If
        Next

    End Sub

    Public Overrides Sub RemoveSelected()
        Dim objItem As Object
        Dim tempObjects(lstSelectedVariables.SelectedItems.Count - 1) As Object

        If lstSelectedVariables.SelectedItems.Count > 0 Then
            lstSelectedVariables.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                lstSelectedVariables.Items.Remove(objItem)
                'to do                objSelected.Remove()
            Next
        Else
            MsgBox("There is nothing to remove", vbInformation, "Selection message")
        End If
    End Sub

    Public Overrides Function GetVariables() As String
        Return "To do"
    End Function

End Class