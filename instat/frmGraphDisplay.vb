Public Class frmGraphDisplay
    Private Sub frmGraphDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetImageFromFile(strFilePath As String)
        Dim fsTemp As System.IO.FileStream
        Dim imgTemp As Image

        fsTemp = New System.IO.FileStream(strFilePath, IO.FileMode.Open, IO.FileAccess.Read)
        imgTemp = System.Drawing.Image.FromStream(fsTemp)
        pctGraph.Image = imgTemp
        fsTemp.Close()
    End Sub
End Class