Public Class ucrRows

    Private bFirstload As Boolean = True

    Private Sub ucrRows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlRows.AddRadioButton(rdoRowsGroups)
        ucrPnlRows.AddRadioButton(rdoRowsSummaries)
        rdoRowsGroups.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        ucrRowGroups.Setup(strDataFrameName, clsOperator)
        ucrRowSummary.Setup(strDataFrameName, clsOperator)
    End Sub

    Private Sub ucrPnlRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRows.ControlValueChanged
        ucrRowGroups.Visible = rdoRowsGroups.Checked
        ucrRowSummary.Visible = rdoRowsSummaries.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrRowGroups.SetValuesToOperator()
        ucrRowSummary.SetValuesToOperator()
    End Sub


End Class
