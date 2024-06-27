Public Class ucrColumns

    Private bFirstload As Boolean = True
    Private Sub InitialiseDialog()
        ucrPnlCols.AddRadioButton(rdoColLabel)
        ucrPnlCols.AddRadioButton(rdoColWidth)
        ucrPnlCols.AddRadioButton(rdoColHide)
        ucrPnlCols.AddRadioButton(rdoColNanoPlot)
        ucrPnlCols.AddRadioButton(rdoColFootNotes)
        ucrPnlCols.AddRadioButton(rdoColStyle)
        ucrPnlCols.AddRadioButton(rdoColSpanners)
        rdoColLabel.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        ucrColumnLabels.Setup(strDataFrameName, clsOperator)
        ucrColumnWidth.Setup(strDataFrameName, clsOperator)
        ucrColumnFootNote.Setup(strDataFrameName, clsOperator)
        ucrColumnSpanners.Setup(strDataFrameName, clsOperator)
    End Sub

    Private Sub ucrPnlCols_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCols.ControlValueChanged
        ucrColumnLabels.Visible = rdoColLabel.Checked
        ucrColumnWidth.Visible = rdoColWidth.Checked
        ucrColumnFootNote.Visible = rdoColFootNotes.Checked
        ucrColumnSpanners.Visible = rdoColSpanners.Checked
    End Sub

    Public Sub SetValuesToOperator()
        'ucrColumnLabels.SetValuesToOperator()
        ucrColumnWidth.SetValuesToOperator()
        ucrColumnFootNote.SetValuesToOperator()
        'ucrColumnSpanners.SetValuesToOperator()
    End Sub

End Class
