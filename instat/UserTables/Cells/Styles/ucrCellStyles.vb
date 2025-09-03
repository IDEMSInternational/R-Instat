Public Class ucrCellStyles
    Private clsOperator As New ROperator

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
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

        ' Set up the selector
        ucrSelectorByDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        ucrRowExpression.Setup(strDataFrameName)

        ' Clear and Set up the data grid with contents
        dataGridFormats.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_body", clsOperator))
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            ' Create a new row that represents the tab_style() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridFormats)
            row.Cells(0).Value = clsRParam.clsArgumentCodeStructure.Clone.ToScript

            ' Tag and add the tab_style() parameter function contents as a row
            row.Tag = clsRParam
            dataGridFormats.Rows.Add(row)
        Next
    End Sub

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged
        btnEnterStyle.Enabled = Not ucrReceiverMultipleCols.IsEmpty
    End Sub

    Private Sub btnEnterStyle_Click(sender As Object, e As EventArgs) Handles btnEnterStyle.Click
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        Dim clsLocationsRFunction As New RFunction
        clsLocationsRFunction.SetPackageName("gt")
        clsLocationsRFunction.SetRCommand("cells_body")
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False), iNewPosition:=0))
        If Not ucrRowExpression.IsEmpty Then
            clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=ucrRowExpression.GetText(), iNewPosition:=1))
        End If

        Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGridFormats)
        row.Cells(0).Value = clsTabStyleRFunction.Clone.ToScript

        ' Create parameter with unique name and tag the row with the parameter 
        row.Tag = New RParameter(strParameterName:="tab_style_cells_body_param" & (dataGridFormats.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)

        ' Add it to grid
        dataGridFormats.Rows.Add(row)
    End Sub

    Private Sub btnClearFormats_Click(sender As Object, e As EventArgs) Handles btnClearFormats.Click
        dataGridFormats.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_body", clsOperator), clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFormats, clsOperator)
    End Sub

End Class
