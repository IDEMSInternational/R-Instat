Public Class ucrDataFrameLength
    Public WithEvents clsDataFrameSelector As ucrDataFrame

    Public Sub SetDataFrameSelector(clsSelector As ucrDataFrame)
        clsDataFrameSelector = clsSelector
        SetLength()
    End Sub

    Public Sub SetLength()
        If clsDataFrameSelector IsNot Nothing Then
            txtLength.Text = clsDataFrameSelector.iDataFrameLength
        End If
    End Sub

    Private Sub clsDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles clsDataFrameSelector.DataFrameChanged
        SetLength()
    End Sub
End Class
