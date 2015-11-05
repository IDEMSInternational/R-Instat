Public Class ucrReceiverMultiple
    Friend Shared Event removeSelectedItem(ByVal myString As String)

    Public Sub setValues(ByVal myString As String)
        lstSelectedVariables.Items.Add(myString)
    End Sub
    Public Sub removeValues(ByVal myString As String)
        lstSelectedVariables.Items.Remove(myString)
    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        AddHandler ucrSelector.getSelectedItem, AddressOf setValues

    End Sub
End Class