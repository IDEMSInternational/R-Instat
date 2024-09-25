Public Class ucrCells

    Private bFirstload As Boolean = True
    Private Sub InitialiseDialog()
        ucrPnlCells.AddRadioButton(rdoFormat)
        ucrPnlCells.AddRadioButton(rdoFootNotes)
        ucrPnlCells.AddRadioButton(rdoStyles)
        rdoFormat.Checked = True
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        ucrCellFormats.Setup(strDataFrameName, clsOperator)
        ucrCellsFootNotes.Setup(strDataFrameName, clsOperator)
        ucrCellStyles.Setup(strDataFrameName, clsOperator)

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
