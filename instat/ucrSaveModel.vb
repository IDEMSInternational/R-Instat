Public Class ucrSaveModel
    Public Event CheckedChanged()
    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        ucrInputModelName.Enabled = False
        RaiseEvent CheckedChanged()
    End Sub

    Private Sub ucrSaveModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrInputModelName.SetDefaultTypeAsModel()
        ucrInputModelName.SetItemsTypeAsModels()
    End Sub
End Class
