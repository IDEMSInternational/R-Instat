Public Class ucrColumns

    Private bFirstload As Boolean = True
    Private Sub InitialiseDialog()
        ucrPnlCols.AddRadioButton(rdoColLabel)
        ucrPnlCols.AddRadioButton(rdoColSpanners)
        rdoColLabel.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        ucrColumnLabels.Setup(strDataFrameName, clsOperator)
        ucrColumnSpanners.Setup(strDataFrameName, clsOperator)
    End Sub


    Private Sub ucrPnlCols_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCols.ControlValueChanged
        ucrColumnLabels.Visible = rdoColLabel.Checked
        ucrColumnSpanners.Visible = rdoColSpanners.Checked
    End Sub


End Class
