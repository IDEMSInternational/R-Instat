Public Class ucrColumnSpanners

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseDialog()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetMeAsReceiver()
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        dataGridSpanners.Rows.Clear()

        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand("tab_spanner", clsOperator)

        For Each clsRParam As RParameter In lstRParams

            Dim clsTabSpannerRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Create a new row that represents the tab_footnote() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridSpanners)

            For Each clsTabSpannerRParam As RParameter In clsTabSpannerRFunction.clsParameters
                If clsTabSpannerRParam.strArgumentName = "id" Then
                    row.Cells(0).Value = clsTablesUtils.GetStringValue(clsTabSpannerRParam.strArgumentValue, False)
                ElseIf clsTabSpannerRParam.strArgumentName = "label" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsTabSpannerRParam.strArgumentValue, False)
                ElseIf clsTabSpannerRParam.strArgumentName = "columns" Then
                    row.Cells(2).Value = clsTablesUtils.GetStringValue(clsTabSpannerRParam.strArgumentValue, False)
                End If
            Next

            ' Tag and add the  tab_row_group() parameter function contents as a row
            row.Tag = clsRParam
            dataGridSpanners.Rows.Add(row)

        Next

    End Sub

    Private Sub btnAddColSpanner_Click(sender As Object, e As EventArgs) Handles btnAddColSpanner.Click

        Dim strSpannerLabel As String = ucrInputColSpanner.GetValue()
        Dim strSpannerId As String = strSpannerLabel.Replace(" ", String.Empty)
        Dim strSpannerColsRFunction As String = mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False)

        Dim clsTabRowGroupRFunction As New RFunction
        clsTabRowGroupRFunction.SetPackageName("gt")
        clsTabRowGroupRFunction.SetRCommand("tab_spanner")
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="label", strParamValue:=clsTablesUtils.GetStringValue(strSpannerLabel, True), iNewPosition:=0))
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=strSpannerColsRFunction, iNewPosition:=1))
        clsTabRowGroupRFunction.AddParameter(New RParameter(strParameterName:="id", strParamValue:=clsTablesUtils.GetStringValue(strSpannerId, True), iNewPosition:=2))

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_spanner_param" & (dataGridSpanners.Rows.Count + 1), strParamValue:=clsTabRowGroupRFunction, bNewIncludeArgumentName:=False)

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridSpanners)

        row.Cells(0).Value = strSpannerId
        row.Cells(1).Value = strSpannerLabel
        row.Cells(2).Value = strSpannerColsRFunction

        ' Tag and add the  tab_row_group() parameter function contents as a row
        row.Tag = clsRParam
        dataGridSpanners.Rows.Add(row)

        ' Add to parameter
        clsOperator.AddParameter(clsRParam)

        ucrReceiverMultipleCols.Clear()
        ucrInputColSpanner.SetName("")

    End Sub

    Private Sub btnClearGroups_Click(sender As Object, e As EventArgs) Handles btnClearSpanners.Click
        For index As Integer = 0 To dataGridSpanners.Rows.Count - 1
            clsOperator.RemoveParameter(dataGridSpanners.Rows(index).Tag)
        Next
        dataGridSpanners.Rows.Clear()
    End Sub


    Private Sub ucrColSpanner_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged, ucrInputColSpanner.ControlContentsChanged
        btnAddColSpanner.Enabled = Not ucrReceiverMultipleCols.IsEmpty AndAlso Not ucrInputColSpanner.IsEmpty
    End Sub

End Class
