Public Class ucrCellStyles
    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetMeAsReceiver()
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
        dataGridFormats.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue("tab_style", "locations", "cells_body", clsOperator))

    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFormats, clsOperator)
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))

        For Each clsRParam As RParameter In lstRParams

            Dim clsFormatRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Create a new row that represents the tab_style() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridFormats)

            For Each clsRowGroupRParam As RParameter In clsFormatRFunction.clsParameters
                If clsRowGroupRParam.strArgumentName = "style" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                ElseIf clsRowGroupRParam.strArgumentName = "locations" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                End If
            Next

            ' Tag and add the tab_style() parameter function contents as a row
            row.Tag = clsRParam
            dataGridFormats.Rows.Add(row)

        Next
    End Sub

    Private Sub ucrReceiverMultipleCols_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlValueChanged, ucrInputRows.ControlValueChanged
        btnEnterStyle.Enabled = Not ucrReceiverMultipleCols.IsEmpty AndAlso Not ucrInputRows.IsEmpty
    End Sub

    Private Sub btnEnterStyle_Click(sender As Object, e As EventArgs) Handles btnEnterStyle.Click
        Dim clsFormatRFunction As RFunction = Nothing
        sdgTableStyles.Setup()
        sdgTableStyles.ShowDialog(Me.ParentForm)
        'clsFormatRFunction = sdgCellFormatTextOptions.GetNewUserInputAsRFunction()

        'If clsFormatRFunction Is Nothing Then
        '    Exit Sub
        'End If

        'AddFormatParameterToGrid(clsFormatRFunction)
        'ucrReceiverMultipleCols.Clear()
        'ucrInputRows.SetName("")

    End Sub


    Private Sub AddFormatParameterToGrid(clsFormatRFunction As RFunction)

        Dim strColumnsExpression As String = ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False)
        Dim strRowsExpression As String = ucrInputRows.GetText

        ' Add columns parameter
        clsFormatRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=strColumnsExpression, iNewPosition:=0))

        ' Add rows as paramater if present
        If Not ucrInputRows.IsEmpty Then
            clsFormatRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=strRowsExpression, iNewPosition:=1))
        End If

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_style_cells_param" & (dataGridFormats.Rows.Count + 1), strParamValue:=clsFormatRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGridFormats)
        row.Cells(0).Value = clsFormatRFunction.strRCommand
        row.Cells(1).Value = strColumnsExpression
        row.Cells(2).Value = strRowsExpression


        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGridFormats.Rows.Add(row)

    End Sub

    Private Sub btnClearFormats_Click(sender As Object, e As EventArgs) Handles btnClearFormats.Click
        dataGridFormats.Rows.Clear()
    End Sub


End Class
