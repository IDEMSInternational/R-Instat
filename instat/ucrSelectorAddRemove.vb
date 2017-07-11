Public Class ucrSelectorAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        'call 
        ShowDataOptionsDialog()
    End Sub

    Public Overrides Sub EnableDataOptions(strCurrentType As String)
        If strCurrentType = "column" Then
            cmdOptions.Enabled = True
        Else
            cmdOptions.Enabled = False
        End If
    End Sub
End Class
