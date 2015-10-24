Imports RDotNet

Public Class ucrAvailableData
    Dim clsRInterface As New RInterface
    Private Sub btnAvailableData_Click(sender As Object, e As EventArgs) Handles btnAvailableData.Click
        If (lstAvailbaleData.SelectedItem <> "") Then
            lstAvailbaleData.Items.Add(lstAvailbaleData.SelectedItem)
            lstAvailbaleData.Items.Remove(lstAvailbaleData.SelectedItem)

        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub
    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnAvailableData.Click
        If (lstAvailbaleData.SelectedItem <> "") Then
            lstAvailbaleData.Items.Add(lstAvailbaleData.SelectedItem)
            lstAvailbaleData.Items.Remove(lstAvailbaleData.SelectedItem)
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Private Sub ucrAvailableData_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DataSet As DataFrame
        Dim i As Integer

        DataSet = clsRInterface.GetData("data")
        For i = 0 To DataSet.ColumnCount - 1
            lstAvailbaleData.Items.Add(DataSet.ColumnNames(i))
        Next
    End Sub

    Private Sub lstAvailbaleData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailbaleData.SelectedIndexChanged

    End Sub
End Class
