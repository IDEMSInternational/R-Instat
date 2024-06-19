
Public Class ucrSourceNotes

    Private clsOperator As New ROperator

    Public Sub Setup(clsOperator As ROperator)

        Me.clsOperator = clsOperator
        dataGridSourceNotes.Rows.Clear()

        Dim lstsourceNotesRFunctions As List(Of RFunction) = clsTablesUtils.FindRFunctionsWithRCommand("tab_source_note", clsOperator)

        For Each clsSourceNoteRFunct As RFunction In lstsourceNotesRFunctions

            ' Create a new row that represents the tab_footnote() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridSourceNotes)

            For Each clsFootNoteRParam As RParameter In clsSourceNoteRFunct.clsParameters
                If clsFootNoteRParam.strArgumentName = "source_note" Then
                    ' Set the foot note text
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsFootNoteRParam.clsArgumentCodeStructure.clsParameters(0).strArgumentValue, False)
                End If
            Next

            ' Tag and add the tab_footnote() function contents as a row
            row.Tag = clsSourceNoteRFunct
            dataGridSourceNotes.Rows.Add(row)

        Next

        ' Always add a place holder row for new foot note
        dataGridSourceNotes.Rows.Add()

    End Sub

    Private Sub dataGridNotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridSourceNotes.CellClick

        ' Ignore clicks that are not from button cells. 
        If e.ColumnIndex <> 1 Then
            Exit Sub
        End If

        Dim clsNoteRFunction As RFunction = dataGridSourceNotes.Rows.Item(e.RowIndex).Tag
        If clsNoteRFunction IsNot Nothing Then
            clsTablesUtils.ShowTextFormatSubDialog(Me.ParentForm, clsNoteRFunction.GetParameter("source_note").clsArgumentCodeStructure)
        End If

    End Sub

    Private Sub dataGridNotes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridSourceNotes.CellEndEdit

        Dim row As DataGridViewRow = dataGridSourceNotes.Rows.Item(e.RowIndex)
        Dim strNoteTextValue As String = row.Cells(0).Value

        ' If no foot note typed by user then just exit the sub
        If String.IsNullOrEmpty(strNoteTextValue) Then
            Exit Sub
        End If

        ' Get existing note function if it exists
        Dim clsNoteRFunction As RFunction = row.Tag

        ' Get the prevous style parameter to retain any format options previously done
        Dim clsStyleParam As RParameter = Nothing
        If clsNoteRFunction IsNot Nothing Then
            clsStyleParam = clsNoteRFunction.GetParameter("source_note").clsArgumentCodeStructure.GetParameter("style")
        End If

        '--------------------------------------
        ' Recreate the footer function
        Dim clsNewNoteRFunction As New RFunction
        clsNewNoteRFunction.SetPackageName("gt")
        clsNewNoteRFunction.SetRCommand("tab_source_note")

        Dim clsNoteTextRFunction As RFunction = clsTablesUtils.GetNewHtmlSpanRFunction()
        clsNoteTextRFunction.AddParameter(New RParameter(strParameterName:="", strParamValue:=clsTablesUtils.GetStringValue(strNoteTextValue, True), iNewPosition:=0, bNewIncludeArgumentName:=False))

        ' Add the previous style if it exists 
        If clsStyleParam IsNot Nothing Then
            clsNoteTextRFunction.AddParameter(clsStyleParam)
        End If

        ' Add the foot note text parameter to the footer R function
        clsNewNoteRFunction.AddParameter(New RParameter(strParameterName:="source_note", strParamValue:=clsNoteTextRFunction, iNewPosition:=0))
        '--------------------------------------

        ' Overwrite the tag with the new foot function
        row.Tag = clsNewNoteRFunction

        ' Remove all the tab source notes R Functions
        clsTablesUtils.RemoveParameterFromOperator({"tab_source_note"}, clsOperator)

        ' Add all the tab source note RFunctions
        clsTablesUtils.SetGridTagsInOperator(dataGridSourceNotes, "tab_source_note", clsOperator)

        ' If last row then add new empty row
        If e.RowIndex = dataGridSourceNotes.Rows.Count - 1 Then
            dataGridSourceNotes.Rows.Add()
        End If
    End Sub

End Class
