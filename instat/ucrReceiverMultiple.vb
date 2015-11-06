Public Class ucrReceiverMultiple
    Public Overloads Sub AddSelected()
        lstSelectedVariables.Items.Add(Selector.lstAvailableVariable.SelectedItem)
    End Sub
End Class