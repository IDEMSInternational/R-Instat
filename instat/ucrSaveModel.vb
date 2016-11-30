Public Class ucrSaveModel
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ucrInputModelName.SetDefaultTypeAsModel()
        ucrInputModelName.SetItemsTypeAsModels()
    End Sub

    Public Event CheckedChanged(bChecked As Boolean)
    Private Sub chkSaveModel_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveModel.CheckedChanged
        If chkSaveModel.Checked Then
            ucrInputModelName.Visible = True
        Else
            ucrInputModelName.Visible = False
        End If
        RaiseEvent CheckedChanged(chkSaveModel.Checked)
    End Sub
End Class
