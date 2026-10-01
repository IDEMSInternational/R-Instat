Public Class ucrTableOptions
    Private clsOperator As New ROperator

    Public Sub Setup(clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ' Clear and Set up the data grid with contents
        dataGrid.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"sub_missing", "fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator))
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams

            Dim clsRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Only use functions that affect the whole table. 
            If clsRFunction.ContainsParameter("columns") OrElse clsRFunction.ContainsParameter("rows") Then
                Continue For
            End If

            Dim row As New DataGridViewRow
            row.CreateCells(dataGrid)
            row.Cells(0).Value = clsRFunction.Clone.ToScript

            row.Tag = clsRParam
            dataGrid.Rows.Add(row)
        Next
    End Sub

    Private Sub btnAddReplaceNaExpression_Click(sender As Object, e As EventArgs) Handles btnAddReplaceNaExpression.Click
        If ucrTxtMissingText.IsEmpty Then
            Exit Sub
        End If

        Dim clsSubMissingRFunction As New RFunction

        clsSubMissingRFunction.SetPackageName("gt")
        clsSubMissingRFunction.SetRCommand("sub_missing")
        clsSubMissingRFunction.AddParameter(strParameterName:="missing_text", strParameterValue:=Chr(34) & ucrTxtMissingText.GetText & Chr(34), iPosition:=0)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="all_sub_missing_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsSubMissingRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsSubMissingRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGrid.Rows.Add(row)

        ucrTxtMissingText.SetName("")
    End Sub

    Private Sub btnAddFormatExpression_Click(sender As Object, e As EventArgs) Handles btnAddFormatExpression.Click
        Dim clsFormatRFunction As RFunction = Nothing
        If cboSelectFormat.Text = "Text" Then
            sdgCellFormatTextOptions.ShowDialog(Me.ParentForm)
            clsFormatRFunction = sdgCellFormatTextOptions.GetNewUserInputAsRFunction()
        ElseIf cboSelectFormat.Text = "Number" Then
            sdgCellFormatNumberOptions.ShowDialog(Me.ParentForm)
            clsFormatRFunction = sdgCellFormatNumberOptions.GetNewUserInputAsRFunction()
        ElseIf cboSelectFormat.Text = "Date" Then
            sdgCellFormatDateOptions.ShowDialog(Me.ParentForm)
            clsFormatRFunction = sdgCellFormatDateOptions.GetNewUserInputAsRFunction()
        End If

        If clsFormatRFunction Is Nothing Then
            Exit Sub
        End If

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="all_fmt_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsFormatRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsFormatRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGrid.Rows.Add(row)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dataGrid.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        ' Remove any previous cell footers 
        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"sub_missing"}, clsOperator)
        For Each clsRParam As RParameter In lstRParams
            clsOperator.RemoveParameter(clsRParam)
        Next

        ' Add new changes
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGrid, clsOperator)
    End Sub
End Class
