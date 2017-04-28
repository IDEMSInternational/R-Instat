Public Class ucrDataFrameLength
    Public WithEvents ucrDataFrameSelector As ucrDataFrame

    Public Sub SetDataFrameSelector(clsSelector As ucrDataFrame)
        ucrDataFrameSelector = clsSelector
        SetLength()
    End Sub

    Public Sub SetLength()
        If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
            txtLength.Text = frmMain.clsRLink.GetDataFrameLength(ucrDataFrameSelector.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub clsDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameSelector.DataFrameChanged
        SetLength()
    End Sub

    Private Sub ucrDataFrameLength_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetLength()
    End Sub
End Class
