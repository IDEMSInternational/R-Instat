Public Class ucrReceiverSingle
    Dim objSelected As New ListViewItem
    Public Overrides Sub AddSelected()
        Dim objItem As Object
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                objSelected = objItem
                txtReceiverSingle.Text = objItem.text
            Next

    End Sub

    Public Overrides Sub RemoveSelected()

        If txtReceiverSingle.Text <> "" Then
            txtReceiverSingle.Text = Nothing
        Else
            MsgBox("There is nothing to remove", vbInformation, "Selection message")
        End If
    End Sub

    Public Overrides Function GetVariables() As String

        Return frmMain.clsRInterface.strInstatDataObject & "$data_objects$" & objSelected.Group.ToString() & "$data$" & objSelected.Text

    End Function

End Class

