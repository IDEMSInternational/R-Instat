Public Class ucrSaveModel
    Public Event CheckedChanged(bChecked As Boolean)
    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrInputModelName.Visible = True
        Else
            ucrInputModelName.Visible = False
        End If
        RaiseEvent CheckedChanged(chkSaveModel.Checked)
    End Sub

    Private Sub ucrSaveModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputModelName.SetDefaultTypeAsModel()
        ucrInputModelName.SetItemsTypeAsModels()
    End Sub
End Class
