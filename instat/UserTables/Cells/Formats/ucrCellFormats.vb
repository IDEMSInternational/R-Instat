Public Class ucrCellFormats
    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrReceiverMultipleCols.Selector = ucrSelectorByDF
        ucrReceiverMultipleCols.SetMeAsReceiver()

        cboSelectFormat.SelectedIndex = 0
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If

        ' Set up the selector and receiver
        ucrReceiverMultipleCols.strObjectName = strTableName
        If String.IsNullOrEmpty(strTableName) Then
            ucrSelectorByDF.Visible = True
            ucrSelectorByTableDF.Visible = False
            ucrSelectorByDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
            ucrReceiverMultipleCols.Selector = ucrSelectorByDF
        Else
            ucrSelectorByDF.Visible = False
            ucrSelectorByTableDF.Visible = True
            ucrSelectorByTableDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
            ucrReceiverMultipleCols.Selector = ucrSelectorByTableDF
        End If
        ucrReceiverMultipleCols.SetMeAsReceiver()
        ucrReceiverMultipleCols.Clear()

        Me.clsOperator = clsOperator

        ucrRowExpression.Setup(strDataFrameName)

        ' Clear and Set up the data grid with contents
        dataGridFormats.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator))

    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))

        For Each clsRParam As RParameter In lstRParams

            Dim clsFormatRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Create a new row that represents the tab_row_group() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridFormats)

            ' Set the function name
            row.Cells(0).Value = clsFormatRFunction.strRCommand

            For Each clsRowGroupRParam As RParameter In clsFormatRFunction.clsParameters
                If clsRowGroupRParam.strArgumentName = "columns" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                ElseIf clsRowGroupRParam.strArgumentName = "rows" Then
                    row.Cells(2).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                End If
            Next

            ' Tag and add the  tab_row_group() parameter function contents as a row
            row.Tag = clsRParam
            dataGridFormats.Rows.Add(row)

        Next
    End Sub

    Private Sub ucrReceiverMultipleCols_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged
        btnEnterFormat.Enabled = Not ucrReceiverMultipleCols.IsEmpty
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnterFormat.Click
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

        AddFormatParameterToGrid(clsFormatRFunction)
        ucrReceiverMultipleCols.Clear()
        ucrRowExpression.Clear()
    End Sub

    Private Sub AddFormatParameterToGrid(clsFormatRFunction As RFunction)

        Dim strColumnsExpression As String = ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=True, strQuotes:="`")
        Dim strRowsExpression As String = ucrRowExpression.GetText

        ' Add columns parameter
        clsFormatRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=strColumnsExpression, iNewPosition:=0))

        ' Add rows as paramater if present
        If Not ucrRowExpression.IsEmpty Then
            clsFormatRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=strRowsExpression, iNewPosition:=1))
        End If

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="fmt_param" & (dataGridFormats.Rows.Count + 1), strParamValue:=clsFormatRFunction, bNewIncludeArgumentName:=False)

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

    Private Sub cboSelectFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectFormat.TextChanged
        If cboSelectFormat.Text = "Text" OrElse cboSelectFormat.Text = "Missing" Then
            'ucrReceiverMultipleCols.SetIncludedDataTypes({})
            ucrReceiverMultipleCols.strSelectorHeading = "Select Columns"
        ElseIf cboSelectFormat.Text = "Number" Then
            'ucrReceiverMultipleCols.SetIncludedDataTypes({"numeric"})
            ucrReceiverMultipleCols.strSelectorHeading = "Select Numerics"
        ElseIf cboSelectFormat.Text = "Date" Then
            'ucrReceiverMultipleCols.SetIncludedDataTypes({"date"})
            ucrReceiverMultipleCols.strSelectorHeading = "Select Dates"
        End If

        ucrReceiverMultipleCols.SetMeAsReceiver()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFormats, clsOperator)
    End Sub
End Class
