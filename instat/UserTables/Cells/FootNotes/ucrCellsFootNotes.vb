Public Class ucrCellsFootNotes

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrReceiverSingleCol.Selector = ucrSelectorCols
        ucrReceiverSingleCol.SetMeAsReceiver()


        '-----------------
        Dim dctPlacement As New Dictionary(Of String, String) From {
            {"Default", "auto"},
            {"Auto", Chr(34) & "auto" & Chr(34)},
            {"Left", Chr(34) & "left" & Chr(34)},
            {"Right", Chr(34) & "right" & Chr(34)}
        }
        ucrCboPlacement.SetDropDownStyleAsNonEditable()
        ucrCboPlacement.SetParameter(New RParameter("placement", iNewPosition:=1))
        ucrCboPlacement.SetItems(dctPlacement)
        ucrCboPlacement.SetRDefault("auto")
        '-----------------
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)

        ' Clear and Set up the data grid with contents
        dataGridFootNotes.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue("tab_footnote", "locations", "cells_body", clsOperator))

    End Sub

    Public Sub SetValuesToOperator()

        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRParamValue("tab_footnote", "locations", "cells_body", clsOperator)
        For Each clsRParam As RParameter In lstRParams
            clsOperator.RemoveParameter(clsRParam)
        Next

        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFootNotes, clsOperator)
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))

        For Each clsRParam As RParameter In lstRParams

            ' Create a new row that represents the tab_style() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridFootNotes)
            row.Cells(0).Value = clsRParam.clsArgumentCodeStructure.Clone.ToScript

            ' Tag and add the tab_style() parameter function contents as a row
            row.Tag = clsRParam
            dataGridFootNotes.Rows.Add(row)

        Next
    End Sub

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputRows.ControlContentsChanged, ucrReceiverSingleCol.ControlContentsChanged
        btnAdd.Enabled = Not ucrReceiverSingleCol.IsEmpty AndAlso Not ucrInputRows.IsEmpty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        sdgTableStyles.ShowDialog(Me.ParentForm)
        Dim clsListStyleRFunction As RFunction = sdgTableStyles.GetNewUserInputAsRFunction()

        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        AddFormatParameterToGrid(clsListStyleRFunction)

    End Sub


    Private Sub AddFormatParameterToGrid(clsListStyleRFunction As RFunction)

        Dim clsTabFootNoteRFunction As New RFunction

        Dim clsLocationsRFunction As New RFunction

        Dim strColumnsExpression As String = ucrReceiverSingleCol.GetVariableNames(bWithQuotes:=False)
        Dim strRowsExpression As String = ucrInputRows.GetText
        Dim strFootNoteText As String = ucrTxtFootNote.GetText

        clsLocationsRFunction.SetPackageName("gt")
        clsLocationsRFunction.SetRCommand("cells_body")

        ' Add columns parameter
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=strColumnsExpression, iNewPosition:=0))

        ' Add rows as paramater if present
        If Not ucrInputRows.IsEmpty Then
            clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=strRowsExpression, iNewPosition:=1))
        End If

        clsTabFootNoteRFunction.SetPackageName("gt")
        clsTabFootNoteRFunction.SetRCommand("tab_footnote")
        clsTabFootNoteRFunction.AddParameter(strParameterName:="footnote", strParameterValue:=strFootNoteText, iPosition:=1)
        clsTabFootNoteRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsLocationsRFunction, iPosition:=1)
        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_footnote_cells_param" & (dataGridFootNotes.Rows.Count + 1), strParamValue:=clsTabFootNoteRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGridFootNotes)
        row.Cells(0).Value = clsTabFootNoteRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGridFootNotes.Rows.Add(row)

    End Sub

    Private Sub btnClearFormats_Click(sender As Object, e As EventArgs) Handles btnClearFormats.Click
        dataGridFootNotes.Rows.Clear()
    End Sub



    '---------------------------------------------------------------------------------------
    'Preevious code

    Public Sub Setup2(strDataFrameName As String, clsOperator As ROperator)
        SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator)
    End Sub




    Private Sub SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator As ROperator)

        'SetFooterGridContents(clsOperator, dataGridCellFooterNotes)
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

                        If clsFooterLocationNoteRFunction.strRCommand = "cells_body" Then
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


    Private Sub dataGridNotes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Dim dataGrid As DataGridView = sender
        Dim row As DataGridViewRow = dataGrid.Rows.Item(e.RowIndex)
        Dim strNoteTextValue As String = row.Cells(0).Value

        ' If no foot note typed by user then just exit the sub
        If String.IsNullOrEmpty(strNoteTextValue) Then
            Exit Sub
        End If

        Dim clsNoteRFunction As RFunction = Nothing


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


            ' Overwrite the tag with the new foot function
            row.Tag = clsNoteRFunction

        ' If last row then add new empty row
        If e.RowIndex = dataGrid.Rows.Count - 1 Then
            dataGrid.Rows.Add()
        End If
    End Sub


    'Private Sub dataGridNotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridCellFooterNotes.CellClick

    '    Dim dataGrid As DataGridView = sender
    '    Dim clsNoteRFunction As RFunction = dataGrid.Rows.Item(e.RowIndex).Tag
    '    Dim strParameterName As String = Nothing

    '    '---------------------------
    '    ' Ignore clicks that are not from button cells. 
    '    If dataGrid Is dataGridCellFooterNotes Then
    '        strParameterName = "footnote"
    '        If e.ColumnIndex <> 3 Then
    '            Exit Sub
    '        End If
    '    End If
    '    '---------------------------

    '    If clsNoteRFunction IsNot Nothing AndAlso strParameterName IsNot Nothing Then
    '        sdgTableOptionsTextFormat.Setup(clsNoteRFunction.GetParameter(strParameterName).clsArgumentCodeStructure.GetParameter("style").clsArgumentCodeStructure)
    '        sdgTableOptionsTextFormat.Show(Me)
    '    End If

    'End Sub


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

                        If clsFooterLocationNoteRFunction.strRCommand = "cells_body" Then
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
