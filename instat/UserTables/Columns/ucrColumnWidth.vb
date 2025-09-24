Imports RDotNet

Public Class ucrColumnWidth

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub ucrColumnWidth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseControl()
        ucrReceiverSingleCol.Selector = ucrSelectorCols
        ucrReceiverSingleCol.strSelectorHeading = "Tables"
        ucrReceiverSingleCol.SetItemType(RObjectTypeLabel.Table)
        ucrReceiverSingleCol.SetMeAsReceiver()

        ucrNudWidth.Minimum = 0
        ucrNudWidth.Maximum = Decimal.MaxValue
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)

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

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore)
        btnAdd.Enabled = Not ucrReceiverSingleCol.IsEmpty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddRemoveColumns()
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

    Private Sub AddRemoveColumns()
        Dim clsGetRObjectFunction As New RFunction
        Dim clsAsDataFrameFunction As New RFunction
        clsGetRObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetRObjectFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.strCurrentDataFrame & Chr(34))
        clsGetRObjectFunction.AddParameter("object_name", ucrReceiverSingleCol.GetVariableNames)

        clsAsDataFrameFunction.SetRCommand("as.data.frame")
        clsAsDataFrameFunction.AddParameter("object", clsRFunctionParameter:=clsGetRObjectFunction, bIncludeArgumentName:=False)
        Dim strScript As String = "colnames(" & clsAsDataFrameFunction.ToScript & ")"
        Dim lstObjectss As GenericVector
        lstObjectss = frmMain.clsRLink.RunInternalScriptGetValue(strScript).AsList

        Dim strAllNames As String = "c(" & String.Join(", ", lstObjectss.Select(Function(x) """" & x.AsCharacter(0) & """")) & ")"

        Dim clsColWidthRFunction As New RFunction
        clsColWidthRFunction.SetPackageName("gt")
        clsColWidthRFunction.SetRCommand("cols_width")
        clsColWidthRFunction.AddParameter(strParameterName:="column_param", strParameterValue:=strAllNames & " ~ px(" & ucrNudWidth.Value & ")", iPosition:=0, bIncludeArgumentName:=False)

        Dim clsPipeOperator As New ROperator
        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", "last_table", iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsColWidthRFunction, iPosition:=1)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_col_width_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsPipeOperator, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsPipeOperator.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGrid.Rows.Add(row)
    End Sub
End Class
