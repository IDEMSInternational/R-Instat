Public Class ucrRowSummary

    Private bFirstLoad As Boolean = True
    Private dctSummaryTypes, dctSides As New Dictionary(Of String, String)

    Private Sub ucrRowSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        dctSummaryTypes.Add("Minimum", "min")
        dctSummaryTypes.Add("Maximum", "max")
        dctSummaryTypes.Add("Mean", "mean")
        dctSummaryTypes.Add("Median", "median")
        dctSummaryTypes.Add("Standard Deviation", "sd")
        dctSummaryTypes.Add("Sum", "sum")
        ucrCboSummaryType.SetItems(dctSummaryTypes, bSetConditions:=False)
        ucrCboSummaryType.SetDropDownStyleAsNonEditable()

    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetValuesToOperator()

    End Sub

    Private Sub btnAddSummaries_Click(sender As Object, e As EventArgs) Handles btnAddSummaries.Click
        Dim strSpannerLabel As String = ucrTxtGroupId.GetValue()
        Dim strSpannerId As String = strSpannerLabel.Replace(" ", String.Empty)
        Dim strSpannerColsRFunction As String = mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False)
        Dim strSpannerStyleExpression As String = ""

        Dim clsTabSpannerRFunction As New RFunction
        clsTabSpannerRFunction.SetPackageName("gt")
        clsTabSpannerRFunction.SetRCommand("summary_rows")

        If Not ucrTxtGroupId.IsEmpty Then
            clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="groups", strParamValue:=clsTablesUtils.GetStringValue(ucrTxtGroupId.GetText, True), iNewPosition:=0))
        End If

        clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False), iNewPosition:=1))

        clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="fns", strParamValue:=clsTablesUtils.GetStringValue(strSpannerLabel, True), iNewPosition:=0))

        clsTabSpannerRFunction.AddParameter(New RParameter(strParameterName:="id", strParamValue:=clsTablesUtils.GetStringValue(strSpannerId, True), iNewPosition:=2))

        Dim arrParams(2) As RParameter

        ' Add add the spanner parameter as the first element
        arrParams(0) = New RParameter(strParameterName:="tab_column_spanner_param" & (dataGridSummaries.Rows.Count + 1), strParamValue:=clsTabSpannerRFunction, bNewIncludeArgumentName:=False)

        ' Add the spanner style as the second element
        If btnStyle.Tag IsNot Nothing Then
            Dim clsLocationsRFunction As New RFunction
            clsLocationsRFunction.SetPackageName("gt")
            clsLocationsRFunction.SetRCommand("cells_column_spanners")
            clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="spanners", strParamValue:=clsTablesUtils.GetStringValue(strSpannerId, True), iNewPosition:=0))

            Dim clsListStyleRFunction As RFunction = btnStyle.Tag
            Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

            strSpannerStyleExpression = clsTabStyleRFunction.Clone.ToScript

            arrParams(1) = New RParameter(strParameterName:="tab_style_cells_column_spanner_param" & (dataGridSummaries.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)
        End If

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridSummaries)
        row.Cells(0).Value = strSpannerLabel
        row.Cells(1).Value = strSpannerColsRFunction
        row.Cells(2).Value = strSpannerStyleExpression
        ' Tag the array of parameters
        row.Tag = arrParams
        dataGridSummaries.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
        'ucrInputColSpanner.SetName("")
        ' ucrInputColSpanner.Tag = Nothing
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        sdgCellFormatNumberOptions.ShowDialog(Me.ParentForm)
        Dim clsFormatRFunction As RFunction = sdgCellFormatNumberOptions.GetNewUserInputAsRFunction()

        If clsFormatRFunction Is Nothing Then
            btnFormat.Tag = clsFormatRFunction
        End If

    End Sub

    Private Sub btnStyle_Click(sender As Object, e As EventArgs) Handles btnStyle.Click
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        Dim clsLocationsRFunction As New RFunction
        clsLocationsRFunction.SetPackageName("gt")
        clsLocationsRFunction.SetRCommand("cells_summary")
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False), iNewPosition:=0))
        'If Not ucrRowExpression.IsEmpty Then
        '    clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=ucrRowExpression.GetText(), iNewPosition:=1))
        'End If

        Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

        btnStyle.Tag = clsTabStyleRFunction


    End Sub

    Private Sub btnClearSummaries_Click(sender As Object, e As EventArgs) Handles btnClearSummaries.Click
        dataGridSummaries.Rows.Clear()
    End Sub
End Class
