Public Class ucrRowGroup

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseDialog()
        ucrReceiverSingleCol.Selector = ucrSelectorCols
        ucrReceiverSingleCol.SetMeAsReceiver()
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        dataGridGroups.Rows.Clear()


        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_row_group"}, clsOperator)

        For Each clsRParam As RParameter In lstRParams

            Dim clsTabRowGroupRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Create a new row that represents the tab_footnote() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridGroups)

            For Each clsRowGroupRParam As RParameter In clsTabRowGroupRFunction.clsParameters
                If clsRowGroupRParam.strArgumentName = "label" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                ElseIf clsRowGroupRParam.strArgumentName = "rows" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                End If
            Next

            ' Tag and add the  tab_row_group() parameter function contents as a row
            row.Tag = clsRParam
            dataGridGroups.Rows.Add(row)

        Next

    End Sub

    Private Sub btnAddCondition_Click(sender As Object, e As EventArgs) Handles btnAddCondition.Click

        Dim strGroupLabel As String = ucrInputGroupLabel.GetValue()
        Dim strConditionValue As String = If(cboConditionOperator.Text <> "Expression" AndAlso Not IsNumeric(cboConditionValue.Text), clsTablesUtils.GetStringValue(cboConditionValue.Text, True), cboConditionValue.Text)
        Dim strCondition As String = ucrReceiverSingleCol.GetVariableNames(bWithQuotes:=False) & " " & cboConditionOperator.Text & " " & strConditionValue

        Dim clsTabRowGroupRFunction As New RFunction
        clsTabRowGroupRFunction.SetPackageName("gt")
        clsTabRowGroupRFunction.SetRCommand("tab_row_group")
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="label", strParamValue:=clsTablesUtils.GetStringValue(strGroupLabel, True), iNewPosition:=0))
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=strCondition, iNewPosition:=1))
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="id", strParamValue:=clsTablesUtils.GetStringValue(strGroupLabel.Replace(" ", String.Empty), True), iNewPosition:=2))

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_row_group_param" & (dataGridGroups.Rows.Count + 1), strParamValue:=clsTabRowGroupRFunction, bNewIncludeArgumentName:=False)

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridGroups)

        row.Cells(0).Value = strGroupLabel
        row.Cells(1).Value = strCondition

        ' Tag and add the  tab_row_group() parameter function contents as a row
        row.Tag = clsRParam
        dataGridGroups.Rows.Add(row)

        ' Add to parameter
        clsOperator.AddParameter(clsRParam)

        ucrReceiverSingleCol.Clear()
        ucrInputGroupLabel.SetName("")
        cboConditionValue.Text = ""

    End Sub

    Private Sub conditionValue_TextChanged(sender As Object, e As EventArgs) Handles cboConditionValue.TextChanged, cboConditionOperator.TextChanged
        EnableDisableAddConditionButton()
    End Sub

    Private Sub conditionValue_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleCol.ControlContentsChanged, ucrInputGroupLabel.ControlContentsChanged
        EnableDisableAddConditionButton()
    End Sub

    Private Sub EnableDisableAddConditionButton()
        btnAddCondition.Enabled = Not ucrReceiverSingleCol.IsEmpty AndAlso Not ucrInputGroupLabel.IsEmpty AndAlso Not String.IsNullOrWhiteSpace(cboConditionValue.Text) AndAlso Not String.IsNullOrWhiteSpace(cboConditionOperator.Text)
    End Sub

    Private Sub btnClearGroups_Click(sender As Object, e As EventArgs) Handles btnClearGroups.Click
        For index As Integer = 0 To dataGridGroups.Rows.Count - 1
            clsOperator.RemoveParameter(dataGridGroups.Rows(index).Tag)
        Next
        dataGridGroups.Rows.Clear()
    End Sub

    Private Sub dataGridGroups_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridGroups.CellClick
        If 1 = 1 Then
            Exit Sub
        End If

        ' Ignore clicks that are not from button cells. 
        If e.ColumnIndex <> 1 Then
            Exit Sub
        End If


    End Sub

End Class
