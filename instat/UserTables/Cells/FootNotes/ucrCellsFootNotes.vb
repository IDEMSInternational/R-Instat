Public Class ucrCellsFootNotes


    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator)
    End Sub




    Private Sub SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator As ROperator)
        'SetFooterGridContents(clsOperator, dataGridHeaderFooterNotes)
        SetFooterGridContents(clsOperator, dataGridCellFooterNotes)
    End Sub

    Private Sub SetFooterGridContents(clsOperator As ROperator, dataGridFooterNotes As DataGridView)
        dataGridFooterNotes.Rows.Clear()

        For Each clsFootNoteFunctRParam As RParameter In clsOperator.clsParameters
            If clsFootNoteFunctRParam.strArgumentName.Contains("tab_footnote") Then
                ' Create a new row that represents the tab_footnote() parameters 
                Dim row As New DataGridViewRow
                row.CreateCells(dataGridFooterNotes)

                Dim clsFooterRFunction As RFunction = clsFootNoteFunctRParam.clsArgumentCodeStructure

                For Each clsFootNoteRParam As RParameter In clsFooterRFunction.clsParameters

                    If clsFootNoteRParam.strArgumentName = "footnote" Then
                        ' Set the foot note text
                        row.Cells(0).Value = clsTablesUtils.GetStringValue(clsFootNoteRParam.clsArgumentCodeStructure.clsParameters(0).strArgumentValue, False)
                    ElseIf clsFootNoteRParam.strArgumentName = "locations" Then
                        ' todo go through the location function
                        Dim clsFooterLocationNoteRFunction As RFunction = clsFootNoteRParam.clsArgumentCodeStructure

                        If clsFooterLocationNoteRFunction.strRCommand = "cells_body" AndAlso dataGridFooterNotes Is dataGridCellFooterNotes Then
                            For Each clsFootNoteLocationRParam As RParameter In clsFooterLocationNoteRFunction.clsParameters
                                If clsFootNoteLocationRParam.strArgumentName = "columns" Then
                                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                                ElseIf clsFootNoteLocationRParam.strArgumentName = "rows" Then
                                    row.Cells(2).Value = clsTablesUtils.GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                                End If
                            Next
                        End If
                    End If

                    ' Tag and add the tab_footnote() function contents as a row
                    ' Check if second cell has a value
                    If row.Cells(1).Value IsNot Nothing Then
                        row.Tag = clsFooterRFunction
                        dataGridFooterNotes.Rows.Add(row)
                    End If


                Next

            End If
        Next

        ' Always add a place holder row for new foot note
        dataGridFooterNotes.Rows.Add()

    End Sub


    Private Sub dataGridNotes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCellFooterNotes.CellEndEdit
        Dim dataGrid As DataGridView = sender
        Dim row As DataGridViewRow = dataGrid.Rows.Item(e.RowIndex)
        Dim strNoteTextValue As String = row.Cells(0).Value

        ' If no foot note typed by user then just exit the sub
        If String.IsNullOrEmpty(strNoteTextValue) Then
            Exit Sub
        End If

        Dim clsNoteRFunction As RFunction = Nothing

        If dataGrid Is dataGridCellFooterNotes Then

            clsNoteRFunction = SetupAndGetNewNoteRFunction(row.Tag, "tab_footnote", "footnote", strNoteTextValue)

            ' Add column and row expressions as paramters if user has typed them
            If Not String.IsNullOrEmpty(row.Cells(1).Value) AndAlso Not String.IsNullOrEmpty(row.Cells(2).Value) Then
                Dim clsFooterLocationNoteRFunction As New RFunction
                clsFooterLocationNoteRFunction.SetPackageName("gt")
                clsFooterLocationNoteRFunction.SetRCommand("cells_body")
                clsFooterLocationNoteRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=clsTablesUtils.GetStringValue(row.Cells(1).Value, False)))
                clsFooterLocationNoteRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=clsTablesUtils.GetStringValue(row.Cells(2).Value, False)))
                clsNoteRFunction.AddParameter(New RParameter(strParameterName:="locations", strParamValue:=clsFooterLocationNoteRFunction, iNewPosition:=1))
            End If

        End If

        ' Overwrite the tag with the new foot function
        row.Tag = clsNoteRFunction

        ' If last row then add new empty row
        If e.RowIndex = dataGrid.Rows.Count - 1 Then
            dataGrid.Rows.Add()
        End If
    End Sub


    Private Sub dataGridNotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCellFooterNotes.CellClick

        Dim dataGrid As DataGridView = sender
        Dim clsNoteRFunction As RFunction = dataGrid.Rows.Item(e.RowIndex).Tag
        Dim strParameterName As String = Nothing

        '---------------------------
        ' Ignore clicks that are not from button cells. 
        If dataGrid Is dataGridCellFooterNotes Then
            strParameterName = "footnote"
            If e.ColumnIndex <> 3 Then
                Exit Sub
            End If
        End If
        '---------------------------

        If clsNoteRFunction IsNot Nothing AndAlso strParameterName IsNot Nothing Then
            sdgTableOptionsTextFormat.Setup(clsNoteRFunction.GetParameter(strParameterName).clsArgumentCodeStructure.GetParameter("style").clsArgumentCodeStructure)
            sdgTableOptionsTextFormat.Show(Me)
        End If

    End Sub


    Private Function SetupAndGetNewNoteRFunction(clsPossibleNoteRFunction As RFunction, strNoteRCommand As String, strRNoteTextParameterName As String, strNoteTextValue As String) As RFunction
        Dim clsNewNoteRFunction As RFunction = clsPossibleNoteRFunction
        ' Get the prevous style parameter to retain any format options previously done
        Dim clsStyleParam As RParameter
        If clsNewNoteRFunction IsNot Nothing Then
            clsStyleParam = clsNewNoteRFunction.GetParameter(strRNoteTextParameterName).clsArgumentCodeStructure.GetParameter("style")
        Else
            clsStyleParam = New RParameter(strParameterName:="style", strParamValue:=clsTablesUtils.GetNewHtmlStyleRFunction(), iNewPosition:=1)
        End If


        ' Recreate the footer function
        clsNewNoteRFunction = New RFunction
        clsNewNoteRFunction.SetPackageName("gt")
        clsNewNoteRFunction.SetRCommand(strNoteRCommand)

        Dim clsNoteTextRFunction As RFunction = clsTablesUtils.GetNewHtmlSpanRFunction()
        clsNoteTextRFunction.AddParameter(New RParameter(strParameterName:="", strParamValue:=clsTablesUtils.GetStringValue(strNoteTextValue, True), iNewPosition:=0, bNewIncludeArgumentName:=False))
        clsNoteTextRFunction.AddParameter(clsStyleParam) ' Add the style parameter for formating

        ' Add the foot note text parameter to the footer R function
        clsNewNoteRFunction.AddParameter(New RParameter(strParameterName:=strRNoteTextParameterName, strParamValue:=clsNoteTextRFunction, iNewPosition:=0))
        Return clsNewNoteRFunction
    End Function


    Private Sub SetFooterGridContents1(clsOperator As ROperator, dataGridFooterNotes As DataGridView)
        dataGridFooterNotes.Rows.Clear()

        For Each clsFootNoteFunctRParam As RParameter In clsOperator.clsParameters
            If clsFootNoteFunctRParam.strArgumentName.Contains("tab_footnote") Then
                ' Create a new row that represents the tab_footnote() parameters 
                Dim row As New DataGridViewRow
                row.CreateCells(dataGridFooterNotes)

                Dim clsFooterRFunction As RFunction = clsFootNoteFunctRParam.clsArgumentCodeStructure

                For Each clsFootNoteRParam As RParameter In clsFooterRFunction.clsParameters

                    If clsFootNoteRParam.strArgumentName = "footnote" Then
                        ' Set the foot note text
                        row.Cells(0).Value = clsTablesUtils.GetStringValue(clsFootNoteRParam.clsArgumentCodeStructure.clsParameters(0).strArgumentValue, False)
                    ElseIf clsFootNoteRParam.strArgumentName = "locations" Then
                        ' todo go through the location function
                        Dim clsFooterLocationNoteRFunction As RFunction = clsFootNoteRParam.clsArgumentCodeStructure

                        If clsFooterLocationNoteRFunction.strRCommand = "cells_body" AndAlso dataGridFooterNotes Is dataGridCellFooterNotes Then
                            For Each clsFootNoteLocationRParam As RParameter In clsFooterLocationNoteRFunction.clsParameters
                                If clsFootNoteLocationRParam.strArgumentName = "columns" Then
                                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                                ElseIf clsFootNoteLocationRParam.strArgumentName = "rows" Then
                                    row.Cells(2).Value = clsTablesUtils.GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                                End If
                            Next
                        End If
                    End If

                    ' Tag and add the tab_footnote() function contents as a row
                    ' Check if second cell has a value
                    If row.Cells(1).Value IsNot Nothing Then
                        row.Tag = clsFooterRFunction
                        dataGridFooterNotes.Rows.Add(row)
                    End If


                Next

            End If
        Next

        ' Always add a place holder row for new foot note
        dataGridFooterNotes.Rows.Add()

    End Sub
End Class
