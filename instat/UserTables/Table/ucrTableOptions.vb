Public Class ucrTableOptions

    Private clsOperator As New ROperator

    Private Sub ucrTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Setup(clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ' Clear and Set up the data grid with contents
        dataGrid.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"sub_missing"}, clsOperator))
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            ' Create a new row that represents the tab_style() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGrid)
            row.Cells(0).Value = clsRParam.clsArgumentCodeStructure.Clone.ToScript

            ' Tag and add the tab_style() parameter function contents as a row
            row.Tag = clsRParam
            dataGrid.Rows.Add(row)
        Next
    End Sub

    Private Sub btnAddReplaceNaExpression_Click(sender As Object, e As EventArgs) Handles btnAddReplaceNaExpression.Click
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
