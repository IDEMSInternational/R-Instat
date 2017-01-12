Public Class frmGraphDisplay
    Private Sub frmGraphDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetImageFromFile(strFilePath As String)
        pctGraph.Image = Image.FromFile(strFilePath)
    End Sub
End Class