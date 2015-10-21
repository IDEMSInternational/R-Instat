Public Class ucrDataSelection
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (lstAvailableVariable.SelectedItem <> "") Then
            lstSelectedVariables.Items.Add(lstAvailableVariable.SelectedItem)
            lstAvailableVariable.Items.Remove(lstAvailableVariable.SelectedItem)

        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If (lstSelectedVariables.SelectedItem <> "") Then
            lstAvailableVariable.Items.Add(lstSelectedVariables.SelectedItem)
            lstSelectedVariables.Items.Remove(lstSelectedVariables.SelectedItem)
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub
End Class
