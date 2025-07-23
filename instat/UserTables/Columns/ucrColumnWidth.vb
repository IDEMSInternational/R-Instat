Public Class ucrColumnWidth
    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrNudWidth.Minimum = 0
        ucrNudWidth.Maximum = Decimal.MaxValue
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

        ' Clear and Set up the data grid with contents
        dataGrid.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"cols_width"}, clsOperator))
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

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged
        btnAdd.Enabled = Not ucrReceiverMultipleCols.IsEmpty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim clsColWidthRFunction As New RFunction
        clsColWidthRFunction.SetPackageName("gt")
        clsColWidthRFunction.SetRCommand("cols_width")
        clsColWidthRFunction.AddParameter(strParameterName:="column_param", strParameterValue:=ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False) & " ~ px(" & ucrNudWidth.Value & ")", iPosition:=0, bIncludeArgumentName:=False)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_col_width_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsColWidthRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsColWidthRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGrid.Rows.Add(row)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dataGrid.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        ' Remove any previous col widths
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"cols_width"}, clsOperator)

        ' Add new changes
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGrid, clsOperator)
    End Sub
End Class
