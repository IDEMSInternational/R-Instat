
Public Class ucrSourceNotes

    Private clsOperator As ROperator

    Public Sub Setup(clsOperator As ROperator)
        Me.clsOperator = clsOperator
        dataGridSourceNotes.Rows.Clear()

        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_source_note"}, clsOperator)
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabSourceNotesRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridSourceNotes)
            For Each clsTabSourceNoteRParam As RParameter In clsTabSourceNotesRFunction.clsParameters
                If clsTabSourceNoteRParam.strArgumentName = "source_note" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsTabSourceNoteRParam.strArgumentValue, False)
                End If
            Next
            row.Tag = clsRParam
            dataGridSourceNotes.Rows.Add(row)
        Next

        ' Always add a place holder row for new foot note
        dataGridSourceNotes.Rows.Add()
    End Sub

    Private Sub btnClearNotes_Click(sender As Object, e As EventArgs) Handles btnClearNotes.Click
        dataGridSourceNotes.Rows.Clear()
        dataGridSourceNotes.Rows.Add()
    End Sub

    Private Sub dataGridNotes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridSourceNotes.CellEndEdit

        Dim row As DataGridViewRow = dataGridSourceNotes.Rows.Item(e.RowIndex)
        Dim strNoteTextValue As String = row.Cells(0).Value

        ' If no foot note typed by user then just exit the sub
        If String.IsNullOrEmpty(strNoteTextValue) Then
            Exit Sub
        End If

        Dim clsTabSourceNoteRParam As New RFunction
        clsTabSourceNoteRParam.SetPackageName("gt")
        clsTabSourceNoteRParam.SetRCommand("tab_source_note")
        clsTabSourceNoteRParam.AddParameter(New RParameter(strParameterName:="source_note", strParamValue:=clsTablesUtils.GetStringValue(strNoteTextValue, True), iNewPosition:=0))

        ' Overwrite the tag with the new unique parameter
        row.Tag = New RParameter(strParameterName:="tab_source_note_param" & (dataGridSourceNotes.Rows.Count + 1), strParamValue:=clsTabSourceNoteRParam, bNewIncludeArgumentName:=False)

        ' If last row then add new empty row
        If e.RowIndex = dataGridSourceNotes.Rows.Count - 1 Then
            dataGridSourceNotes.Rows.Add()
        End If
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_source_note"}, clsOperator), clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridSourceNotes, clsOperator)
    End Sub
End Class
