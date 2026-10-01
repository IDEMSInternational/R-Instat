Public Class ucrColumnFootNote
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

        ' Clear and Set up the data grid with contents
        dataGrid.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_footnote"}, "locations", "cells_column_labels", clsOperator))
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

        Dim clsTabFootNoteRFunction As New RFunction
        Dim clsLocationsRFunction As New RFunction

        clsLocationsRFunction.SetPackageName("gt")
        clsLocationsRFunction.SetRCommand("cells_column_labels")
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False), iNewPosition:=0))

        clsTabFootNoteRFunction.SetPackageName("gt")
        clsTabFootNoteRFunction.SetRCommand("tab_footnote")
        clsTabFootNoteRFunction.AddParameter(strParameterName:="footnote", strParameterValue:=Chr(34) & ucrTxtFootNote.GetText & Chr(34), iPosition:=0)
        clsTabFootNoteRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsLocationsRFunction, iPosition:=1)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_footnote_columns_labels_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsTabFootNoteRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsTabFootNoteRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGrid.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
        ucrTxtFootNote.SetName("")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dataGrid.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        ' Remove any previous cell footers 
        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_footnote"}, "locations", "cells_column_labels", clsOperator)
        For Each clsRParam As RParameter In lstRParams
            clsOperator.RemoveParameter(clsRParam)
        Next

        ' Add new changes
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGrid, clsOperator)
    End Sub

End Class
