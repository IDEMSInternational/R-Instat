Imports unvell.ReoGrid.IO.OpenXML.Schema

Public Class ucrColumnSpanners
    Private clsOperator As ROperator

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

        dataGridColSpanners.Rows.Clear()

        ' Note, the sequence of these 2 functions matters
        SetupTabSpannersInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_spanner"}, clsOperator))
        SetupTabSpannersStylesInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_column_spanners", clsOperator))
    End Sub

    Private Sub SetupTabSpannersInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabSpannerRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridColSpanners)
            For Each clsTabSpannerRParam As RParameter In clsTabSpannerRFunction.clsParameters
                If clsTabSpannerRParam.strArgumentName = "label" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsTabSpannerRParam.strArgumentValue, False)
                ElseIf clsTabSpannerRParam.strArgumentName = "columns" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsTabSpannerRParam.strArgumentValue, False)
                End If
            Next
            Dim arrParams(2) As RParameter
            arrParams(0) = clsRParam
            row.Tag = arrParams
            dataGridColSpanners.Rows.Add(row)
        Next
    End Sub

    Private Sub SetupTabSpannersStylesInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabStyleRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            ' Get spanner Id
            Dim strArgumentValueSpannerId As String = clsTabStyleRFunction.GetParameter("locations").clsArgumentCodeStructure.GetParameter("spanners").strArgumentValue
            For index As Integer = 0 To dataGridColSpanners.Rows.Count - 1
                Dim row As DataGridViewRow = dataGridColSpanners.Rows(index)
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
        ucrInputColSpanner.Tag = clsListStyleRFunction
    End Sub

    Private Sub btnAddColSpanner_Click(sender As Object, e As EventArgs) Handles btnAddColSpanner.Click
        Dim strSpannerLabel As String = ucrInputColSpanner.GetText()
        Dim strSpannerId As String = strSpannerLabel.Replace(" ", String.Empty)
        Dim strSpannerColsRFunction As String = mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False)
        Dim strSpannerStyleExpression As String = ""

        Dim clsTabSpannerRFunction As New RFunction
        clsTabSpannerRFunction.SetPackageName("gt")
        clsTabSpannerRFunction.SetRCommand("tab_spanner")
        clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="label", strParamValue:=clsTablesUtils.GetStringValue(strSpannerLabel, True), iNewPosition:=0))
        clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=strSpannerColsRFunction, iNewPosition:=1))
        clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="id", strParamValue:=clsTablesUtils.GetStringValue(strSpannerId, True), iNewPosition:=2))

        Dim arrParams(2) As RParameter

        ' Add add the spanner parameter as the first element
        arrParams(0) = New RParameter(strParameterName:="tab_column_spanner_param" & (dataGridColSpanners.Rows.Count + 1), strParamValue:=clsTabSpannerRFunction, bNewIncludeArgumentName:=False)

        ' Add the spanner style as the second element
        If ucrInputColSpanner.Tag IsNot Nothing Then
            Dim clsLocationsRFunction As New RFunction
            clsLocationsRFunction.SetPackageName("gt")
            clsLocationsRFunction.SetRCommand("cells_column_spanners")
            clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="spanners", strParamValue:=clsTablesUtils.GetStringValue(strSpannerId, True), iNewPosition:=0))

            Dim clsListStyleRFunction As RFunction = ucrInputColSpanner.Tag
            Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

            strSpannerStyleExpression = clsTabStyleRFunction.Clone.ToScript

            arrParams(1) = New RParameter(strParameterName:="tab_style_cells_column_spanner_param" & (dataGridColSpanners.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)
        End If

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridColSpanners)
        row.Cells(0).Value = strSpannerLabel
        row.Cells(1).Value = strSpannerColsRFunction
        row.Cells(2).Value = strSpannerStyleExpression
        ' Tag the array of parameters
        row.Tag = arrParams
        dataGridColSpanners.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
        ucrInputColSpanner.SetName("")
        ucrInputColSpanner.Tag = Nothing
    End Sub

    Private Sub ucrColSpanner_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged, ucrInputColSpanner.ControlContentsChanged
        btnAddColSpanner.Enabled = Not ucrReceiverMultipleCols.IsEmpty AndAlso Not ucrInputColSpanner.IsEmpty
    End Sub

    Private Sub btnClearSpanners_Click(sender As Object, e As EventArgs) Handles btnClearSpanners.Click
        dataGridColSpanners.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_spanner"}, clsOperator), clsOperator)
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_column_spanners", clsOperator), clsOperator)

        For index As Integer = 0 To dataGridColSpanners.Rows.Count - 1
            Dim lstParams() As RParameter = dataGridColSpanners.Rows(index).Tag
            clsOperator.AddParameter(lstParams(0))
            If lstParams(1) IsNot Nothing Then
                clsOperator.AddParameter(lstParams(1))
            End If
        Next
    End Sub
End Class
