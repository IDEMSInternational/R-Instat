﻿Public Class ucrColumnStyles

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub ucrColumnStyles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If
    End Sub

    Private Sub InitialiseControl()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetMeAsReceiver()
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)


        Me.clsOperator = clsOperator

        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)

        ' Clear and Set up the data grid with contents
        dataGridFormats.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_column_labels", clsOperator))

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
        clsLocationsRFunction.SetRCommand("cells_column_labels")
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False), iNewPosition:=0))

        Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_style_column_label_param" & (dataGridFormats.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGridFormats)
        row.Cells(0).Value = clsTabStyleRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGridFormats.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
    End Sub

    Private Sub btnClearFormats_Click(sender As Object, e As EventArgs) Handles btnClearFormats.Click
        dataGridFormats.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_column_labels", clsOperator), clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFormats, clsOperator)
    End Sub


End Class
