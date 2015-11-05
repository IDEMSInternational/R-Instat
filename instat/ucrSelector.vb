Imports RDotNet
Public Class ucrSelector
    Friend Shared Event getSelectedItem(ByVal myString As String)
    Public Sub removeValues(ByVal myString As String)
        lstAvailableVariable.Items.Add(myString)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        RaiseEvent getSelectedItem(lstAvailableVariable.SelectedItem)
        lstAvailableVariable.Items.Remove(lstAvailableVariable.SelectedItem)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler ucrReceiverMultiple.removeSelectedItem, AddressOf removeValues

    End Sub
End Class