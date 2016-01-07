Public Class ucrDataFrame
    Private Sub ucrDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsRInterface.FillComboDataFrames(cboAvailableDataFrames)
    End Sub
End Class
