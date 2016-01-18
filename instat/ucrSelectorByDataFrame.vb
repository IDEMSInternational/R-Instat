Public Class ucrSelectorByDataFrame
    Private Sub ucrSelectorByDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Public Overrides Sub LoadList()
        frmMain.clsRLink.FillColumnNames(ucrAvailableDataFrames.cboAvailableDataFrames.Text, lstColumns:=lstAvailableVariable)
    End Sub

    Private Sub ucrAvailableDataFrames_Load(sender As Object, e As EventArgs) Handles ucrAvailableDataFrames.DataFrameChanged
        LoadList()
    End Sub
End Class
