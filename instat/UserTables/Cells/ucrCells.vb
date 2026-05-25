Public Class ucrCells
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrPnlCells.AddRadioButton(rdoFormat)
        ucrPnlCells.AddRadioButton(rdoFootNotes)
        ucrPnlCells.AddRadioButton(rdoStyles)
        rdoFormat.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If

        ucrCellFormats.Setup(strDataFrameName, clsOperator, strTableName)
        ucrCellsFootNotes.Setup(strDataFrameName, clsOperator, strTableName)
        ucrCellStyles.Setup(strDataFrameName, clsOperator, strTableName)

    End Sub

    Private Sub ucrPnlRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCells.ControlValueChanged
        ucrCellFormats.Visible = rdoFormat.Checked
        ucrCellsFootNotes.Visible = rdoFootNotes.Checked
        ucrCellStyles.Visible = rdoStyles.Checked
    End Sub

    Public Sub SetValuesToOperator()
        ucrCellFormats.SetValuesToOperator()
        ucrCellsFootNotes.SetValuesToOperator()
        ucrCellStyles.SetValuesToOperator()
    End Sub

End Class
