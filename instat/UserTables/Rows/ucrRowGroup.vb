Public Class ucrRowGroup

    Private bFirstLoad As Boolean = True
    Private clsOperator As New ROperator

    Private Sub ucrRowGroup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        btnStyle.Tag = Nothing
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ucrRowExpression.Setup(strDataFrameName)
        dataGridGroups.Rows.Clear()

        ' Note, the sequence of these 2 functions matters
        SetupTabRowGroupInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_row_group"}, clsOperator))
        SetupTabRowGroupStylesInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_row_groups", clsOperator))
    End Sub

    Private Sub SetupTabRowGroupInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabRowGroupRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridGroups)
            For Each clsTabRowGroupRParam As RParameter In clsTabRowGroupRFunction.clsParameters
                If clsTabRowGroupRParam.strArgumentName = "id" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsTabRowGroupRParam.strArgumentValue, False)
                ElseIf clsTabRowGroupRParam.strArgumentName = "label" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsTabRowGroupRParam.strArgumentValue, False)
                ElseIf clsTabRowGroupRParam.strArgumentName = "rows" Then
                    row.Cells(2).Value = clsTablesUtils.GetStringValue(clsTabRowGroupRParam.strArgumentValue, False)
                End If
            Next
            Dim arrParams(2) As RParameter
            arrParams(0) = clsRParam
            row.Tag = arrParams
            dataGridGroups.Rows.Add(row)
        Next
    End Sub

    Private Sub SetupTabRowGroupStylesInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabStyleRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            ' Get spanner Id
            Dim strArgumentValueSpannerId As String = clsTabStyleRFunction.GetParameter("locations").clsArgumentCodeStructure.GetParameter("groups").strArgumentValue
            For index As Integer = 0 To dataGridGroups.Rows.Count - 1
                Dim row As DataGridViewRow = dataGridGroups.Rows(index)
                Dim lstParams() As RParameter = row.Tag
                If strArgumentValueSpannerId = lstParams(0).clsArgumentCodeStructure.GetParameter("id").strArgumentValue Then
                    row.Cells(2).Value = clsTabStyleRFunction.Clone().ToScript
                    lstParams(1) = clsRParam
                    row.Tag = lstParams
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub btnStyle_Click(sender As Object, e As EventArgs) Handles btnStyle.Click
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If
        btnStyle.Tag = clsListStyleRFunction
    End Sub

    Private Sub btnAddCondition_Click(sender As Object, e As EventArgs) Handles btnAddCondition.Click
        Dim strGroupId As String = ucrInputGroupLabel.GetText().Replace(" ", String.Empty)
        Dim strGroupStyleExpression As String = ""

        Dim clsTabRowGroupRFunction As New RFunction
        clsTabRowGroupRFunction.SetPackageName("gt")
        clsTabRowGroupRFunction.SetRCommand("tab_row_group")
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="label", strParamValue:=clsTablesUtils.GetStringValue(ucrInputGroupLabel.GetText(), True), iNewPosition:=0))
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=ucrRowExpression.GetText(), iNewPosition:=1))
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="id", strParamValue:=clsTablesUtils.GetStringValue(strGroupId, True), iNewPosition:=2))

        Dim arrParams(2) As RParameter

        ' Add add the group parameter as the first element
        arrParams(0) = New RParameter(strParameterName:="tab_row_group_param" & (dataGridGroups.Rows.Count + 1), strParamValue:=clsTabRowGroupRFunction, bNewIncludeArgumentName:=False)

        ' Add the group style as the second element
        If btnStyle.Tag IsNot Nothing Then
            Dim clsLocationsRFunction As New RFunction
            clsLocationsRFunction.SetPackageName("gt")
            clsLocationsRFunction.SetRCommand("cells_row_groups")
            clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="groups", strParamValue:=clsTablesUtils.GetStringValue(strGroupId, True), iNewPosition:=0))

            Dim clsListStyleRFunction As RFunction = btnStyle.Tag
            Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

            strGroupStyleExpression = clsTabStyleRFunction.Clone.ToScript

            arrParams(1) = New RParameter(strParameterName:="tab_style_cells_row_groups_param" & (dataGridGroups.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)
        End If

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridGroups)
        row.Cells(0).Value = strGroupId
        row.Cells(1).Value = ucrInputGroupLabel.GetText()
        row.Cells(2).Value = ucrRowExpression.GetText()
        row.Cells(3).Value = strGroupStyleExpression
        ' Tag the array of parameters
        row.Tag = arrParams
        dataGridGroups.Rows.Add(row)

        ucrInputGroupLabel.SetName("")
        ucrRowExpression.Clear()
        btnStyle.Tag = Nothing
    End Sub

    Private Sub conditionValue_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrRowExpression.ControlContentsChanged, ucrInputGroupLabel.ControlContentsChanged
        btnAddCondition.Enabled = Not ucrRowExpression.IsEmpty AndAlso Not ucrInputGroupLabel.IsEmpty
        btnStyle.Enabled = btnAddCondition.Enabled
    End Sub

    Private Sub btnClearGroups_Click(sender As Object, e As EventArgs) Handles btnClearGroups.Click
        dataGridGroups.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_row_group"}, clsOperator), clsOperator)
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_row_groups", clsOperator), clsOperator)

        For index As Integer = 0 To dataGridGroups.Rows.Count - 1
            Dim lstParams() As RParameter = dataGridGroups.Rows(index).Tag
            clsOperator.AddParameter(lstParams(0))
            If lstParams(1) IsNot Nothing Then
                clsOperator.AddParameter(lstParams(1))
            End If
        Next
    End Sub
End Class
