Public Class ucrReceiverSingle
    Dim objSelected As New ListViewItem
    Dim bSelected As Boolean = False
    Public Overrides Sub AddSelected()
        Dim objItem As Object
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                objSelected = objItem
            bSelected = True
            txtReceiverSingle.Text = objItem.text
        Next

    End Sub

    Public Overrides Sub RemoveSelected()

        If txtReceiverSingle.Text <> "" Then
            bSelected = False
            txtReceiverSingle.Text = Nothing
        Else
            MsgBox("There is nothing to remove", vbInformation, "Selection message")
        End If
    End Sub

    Public Overrides Function GetVariables() As String
        If bSelected Then
            Return frmMain.clsRInterface.strInstatDataObject & "$data_objects$" & objSelected.Group.ToString() & "$data$" & objSelected.Text
        Else
            Return ""
        End If
    End Function

End Class

