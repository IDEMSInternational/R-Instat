Public Class ucrColumns

    Private bFirstload As Boolean = True



    Private Sub ucrColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlCols.AddRadioButton(rdoColLabel)
        ucrPnlCols.AddRadioButton(rdoColStyles)
        ucrPnlCols.AddRadioButton(rdoColWidth)
        ucrPnlCols.AddRadioButton(rdoColFootNotes)
        ucrPnlCols.AddRadioButton(rdoColSpanners)

        ' TODO. Nonplots disabled until R is upgraded
        'ucrPnlCols.AddRadioButton(rdoColNanoPlot)
        rdoColNanoPlot.Enabled = False

        rdoColLabel.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        ucrColumnLabels.Setup(strDataFrameName, clsOperator)
        ucrColumnStyles.Setup(strDataFrameName, clsOperator)
        ucrColumnWidth.Setup(strDataFrameName, clsOperator)
        ucrColumnFootNote.Setup(strDataFrameName, clsOperator)
        ucrColumnSpanners.Setup(strDataFrameName, clsOperator)
        ucrColumnNanoPlots.Setup(strDataFrameName, clsOperator)
    End Sub

    Private Sub ucrPnlCols_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCols.ControlValueChanged
        ucrColumnLabels.Visible = rdoColLabel.Checked
        ucrColumnStyles.Visible = rdoColStyles.Checked
        ucrColumnWidth.Visible = rdoColWidth.Checked
        ucrColumnFootNote.Visible = rdoColFootNotes.Checked
        ucrColumnSpanners.Visible = rdoColSpanners.Checked
        ucrColumnNanoPlots.Visible = rdoColNanoPlot.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrColumnLabels.SetValuesToOperator()
        ucrColumnStyles.SetValuesToOperator()
        ucrColumnWidth.SetValuesToOperator()
        ucrColumnFootNote.SetValuesToOperator()
        ucrColumnSpanners.SetValuesToOperator()
        ucrColumnNanoPlots.SetValuesToOperator()
    End Sub

End Class
