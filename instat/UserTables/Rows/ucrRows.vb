Public Class ucrRows

    Private bFirstload As Boolean = True

    Private Sub ucrRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlRows.AddRadioButton(rdoGrandSummaries)
        ucrPnlRows.AddRadioButton(rdoRowsGroups)
        ucrPnlRows.AddRadioButton(rdoRowsGroupSummaries)
        rdoGrandSummaries.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        ucrRowsGrandSummary.Setup(strDataFrameName, clsOperator)
        ucrRowGroups.Setup(strDataFrameName, clsOperator)
        ucrRowSummary.Setup(strDataFrameName, clsOperator)
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
