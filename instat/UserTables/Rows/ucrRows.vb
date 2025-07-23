Public Class ucrRows
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrPnlRows.AddRadioButton(rdoGrandSummaries)
        ucrPnlRows.AddRadioButton(rdoRowsGroups)
        ucrPnlRows.AddRadioButton(rdoRowsGroupSummaries)
        rdoGrandSummaries.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If
        ucrRowsGrandSummary.Setup(strDataFrameName, clsOperator, strTableName)
        ucrRowGroups.Setup(strDataFrameName, clsOperator)
        ucrRowSummary.Setup(strDataFrameName, clsOperator, strTableName)
    End Sub

    Private Sub ucrPnlRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRows.ControlValueChanged
        ucrRowsGrandSummary.Visible = rdoGrandSummaries.Checked
        ucrRowGroups.Visible = rdoRowsGroups.Checked
        ucrRowSummary.Visible = rdoRowsGroupSummaries.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrRowsGrandSummary.SetValuesToOperator()
        ucrRowGroups.SetValuesToOperator()
        ucrRowSummary.SetValuesToOperator()
    End Sub


End Class
