Public Class ucrRows

    Private bFirstload As Boolean = True
    Private Sub InitialiseDialog()
        ucrPnlRows.AddRadioButton(rdoRowsGroups)
        ucrPnlRows.AddRadioButton(rdoRowsSummaries)
        rdoRowsGroups.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        ucrRowGroups.Setup(strDataFrameName, clsOperator)
    End Sub

    Private Sub ucrPnlRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRows.ControlValueChanged
        ucrRowGroups.Visible = rdoRowsGroups.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrRowGroups.SetValuesToOperator()
    End Sub

End Class
