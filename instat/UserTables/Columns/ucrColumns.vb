Public Class ucrColumns
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrPnlCols.AddRadioButton(rdoColLabel)
        ucrPnlCols.AddRadioButton(rdoColStyles)
        ucrPnlCols.AddRadioButton(rdoColWidth)
        ucrPnlCols.AddRadioButton(rdoColFootNotes)
        ucrPnlCols.AddRadioButton(rdoColSpanners)
        ucrPnlCols.AddRadioButton(rdoColHide)
        ucrPnlCols.AddRadioButton(rdoColMissing)
        ucrPnlCols.AddRadioButton(rdoColNanoPlot)

        rdoColLabel.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If
        ucrColumnLabels.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnStyles.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnWidth.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnFootNote.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnSpanners.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnHide.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnMissingTexts.Setup(strDataFrameName, clsOperator, strTableName)
        ucrColumnNanoPlots.Setup(strDataFrameName, clsOperator, strTableName)
    End Sub

    Private Sub ucrPnlCols_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCols.ControlValueChanged
        ucrColumnLabels.Visible = rdoColLabel.Checked
        ucrColumnStyles.Visible = rdoColStyles.Checked
        ucrColumnWidth.Visible = rdoColWidth.Checked
        ucrColumnFootNote.Visible = rdoColFootNotes.Checked
        ucrColumnSpanners.Visible = rdoColSpanners.Checked
        ucrColumnHide.Visible = rdoColHide.Checked
        ucrColumnMissingTexts.Visible = rdoColMissing.Checked
        ucrColumnNanoPlots.Visible = rdoColNanoPlot.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrColumnLabels.SetValuesToOperator()
        ucrColumnStyles.SetValuesToOperator()
        ucrColumnWidth.SetValuesToOperator()
        ucrColumnFootNote.SetValuesToOperator()
        ucrColumnSpanners.SetValuesToOperator()
        ucrColumnHide.SetValuesToOperator()
        ucrColumnMissingTexts.SetValuesToOperator()
        ucrColumnNanoPlots.SetValuesToOperator()
    End Sub

End Class
