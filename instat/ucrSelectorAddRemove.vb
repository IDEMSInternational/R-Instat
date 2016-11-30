

Public Class ucrSelectorAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'call 
        ShowDataOptionsDialog()
    End Sub

    Private Sub ucrSelectorAddRemove_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
