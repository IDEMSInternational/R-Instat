Public Class ucrColors
    Private Sub ucrColors_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.AddItems({"Pick Colour", "black", "white", "blue", "red", "yellow", "purple", "green", "orange", "grey", "brown", "pink", "NULL"})
    End Sub

    Private Sub ucrColors_NameChanged() Handles Me.NameChanged
        Dim dlgColour As New ColorDialog
        If Me.cboInput.Text = "Pick Colour" Then
            dlgColour.ShowDialog()
            SetName(dlgColour.Color.Name)
        End If
    End Sub
End Class
