Public Class ucrRowGroup

    Private clsOperator As New ROperator

    Private bFirstload As Boolean = True

    Public Sub Setup(clsOperator As ROperator)
        Me.clsOperator = clsOperator
        dataGridGroups.Rows.Clear()

        Dim lstsourceNotesRFunctions As List(Of RFunction) = clsTablesUtils.FindRFunctionsWithRCommand("tab_source_note", clsOperator)

        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand("tab_row_group", clsOperator)



        For Each clsRParam As RParameter In lstRParams

            Dim clsTabSourceNoteRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Create a new row that represents the tab_footnote() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridGroups)

            For Each clsRowGroupRParam As RParameter In clsTabSourceNoteRFunction.clsParameters
                If clsRowGroupRParam.strArgumentName = "label" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.clsArgumentCodeStructure.clsParameters(0).strArgumentValue, False)
                End If
            Next

            ' Tag and add the tab_footnote() function contents as a row
            'row.Tag = clsSourceNoteRFunct
            dataGridGroups.Rows.Add(row)

        Next

        ' Always add a place holder row for new foot note
        dataGridGroups.Rows.Add()
    End Sub

End Class
