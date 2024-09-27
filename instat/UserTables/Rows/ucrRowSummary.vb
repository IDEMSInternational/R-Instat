Public Class ucrRowSummary

    Private bFirstLoad As Boolean = True
    Private clsOperator As New ROperator
    Private dctSummaryTypes, dctSides As New Dictionary(Of String, String)

    Private Sub ucrRowSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetDataType("numeric", bStrict:=True)
        ucrReceiverMultipleCols.SetMeAsReceiver()

        dctSummaryTypes.Add("Minimum", "min")
        dctSummaryTypes.Add("Maximum", "max")
        dctSummaryTypes.Add("Mean", "mean")
        dctSummaryTypes.Add("Median", "median")
        dctSummaryTypes.Add("Standard Deviation", "sd")
        dctSummaryTypes.Add("Sum", "sum")
        dctSummaryTypes.Add("Length", "length")
        ucrCboSummaryType.SetItems(dctSummaryTypes, bSetConditions:=False)
        ucrCboSummaryType.SetDropDownStyleAsNonEditable()
        ucrCboSummaryType.GetSetSelectedIndex = 0

        dctSides.Add("Bottom", "bottom")
        dctSides.Add("Top", "top")
        ucrCboSide.SetItems(dctSides, bSetConditions:=False)
        ucrCboSide.SetDropDownStyleAsNonEditable()
        ucrCboSide.GetSetSelectedIndex = 0

        btnFormat.Tag = Nothing
        btnStyle.Tag = Nothing

        ' TODO. Disabled due to error thrwon when using data book. See comments inside GetFnParameters()
        lblSummaryLabel.Enabled = False
        ucrTxtSummaryLabel.Enabled = False

        ' TODO. Disabled until R is upgraded
        lblSide.Enabled = False
        ucrCboSide.Enabled = False
        btnFormat.Enabled = False
        btnStyle.Enabled = False
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        dataGridSummaries.Rows.Clear()

        ' Note, the sequence of these 2 functions matters
        SetupSummaryRowInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"summary_rows"}, clsOperator))
        SetupSummaryRowStylesInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_summary", clsOperator))
    End Sub

    Private Sub SetupSummaryRowInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabSummaryRowRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridSummaries)
            row.Cells(0).Value = clsTabSummaryRowRFunction.Clone.ToScript

            ' TODO. In future we could get the individual parameters

            'For Each clsTabRowGroupRParam As RParameter In clsTabSummaryRowRFunction.clsParameters
            '    If clsTabRowGroupRParam.strArgumentName = "fns" Then
            '        row.Cells(0).Value = clsTablesUtils.GetStringValue(clsTabRowGroupRParam.strArgumentValue, False)
            '    ElseIf clsTabRowGroupRParam.strArgumentName = "fms" Then
            '        row.Cells(1).Value = clsTablesUtils.GetStringValue(clsTabRowGroupRParam.strArgumentValue, False)
            '    End If
            'Next
            Dim arrParams(2) As RParameter
            arrParams(0) = clsRParam
            row.Tag = arrParams
            dataGridSummaries.Rows.Add(row)
        Next
    End Sub

    Private Sub SetupSummaryRowStylesInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabStyleRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            ' Get spanner Id
            Dim iRowId As Integer
            If Not Integer.TryParse(clsTabStyleRFunction.GetParameter("locations").clsArgumentCodeStructure.GetParameter("row").strArgumentValue, iRowId) Then
                Continue For
            End If


            For index As Integer = 0 To dataGridSummaries.Rows.Count - 1
                Dim row As DataGridViewRow = dataGridSummaries.Rows(index)
                Dim lstParams() As RParameter = row.Tag

                ' As of 2024/08/07 the gt summary_rows R function doesn't have a unique identifier like row groups.
                ' So just use the data gridview index to show the style expressions
                If index + 1 = iRowId Then
                    row.Cells(1).Value = clsTabStyleRFunction.Clone().ToScript
                    lstParams(1) = clsRParam
                    row.Tag = lstParams
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        sdgCellFormatNumberOptions.ShowDialog(Me.ParentForm)
        Dim clsFormatRFunction As RFunction = sdgCellFormatNumberOptions.GetNewUserInputAsRFunction()

        If clsFormatRFunction IsNot Nothing Then
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

        If Not ucrTxtGroupId.IsEmpty Then
            clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="groups", strParamValue:=Chr(34) & ucrTxtGroupId.GetText & Chr(34), iNewPosition:=0))
        End If
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=False), iNewPosition:=1))
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="row", strParamValue:=dataGridSummaries.Rows.Count + 1, iNewPosition:=2))

        Dim clsTabStyleRFunction As RFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsLocationsRFunction)

        btnStyle.Tag = clsTabStyleRFunction
    End Sub

    Private Sub conditionValue_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged
        btnAddSummaries.Enabled = Not ucrReceiverMultipleCols.IsEmpty
    End Sub

    Private Sub btnAddSummaries_Click(sender As Object, e As EventArgs) Handles btnAddSummaries.Click
        Dim strSpannerLabel As String = ucrTxtGroupId.GetValue()
        Dim strSpannerId As String = strSpannerLabel.Replace(" ", String.Empty)
        Dim strSpannerColsRFunction As String = mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False)
        Dim strSpannerStyleExpression As String = ""

        Dim clsSummaryRowsRFunction As New RFunction
        clsSummaryRowsRFunction.SetPackageName("gt")
        clsSummaryRowsRFunction.SetRCommand("summary_rows")


        If Not ucrTxtGroupId.IsEmpty Then
            clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="groups", strParamValue:=Chr(34) & ucrTxtGroupId.GetText & Chr(34), iNewPosition:=0))
        End If

        clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="fns", strParamValue:=GetFnParameters(), iNewPosition:=1))
        clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False), iNewPosition:=2))

        If btnFormat.Tag IsNot Nothing Then
            Dim clsFormatRFunction As RFunction = btnFormat.Tag
            clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="fmt", strParamValue:=clsFormatRFunction, iNewPosition:=3))
        End If

        'TODO. Commented out until R-Instat R is upgraded 
        'clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="side", strParamValue:=Chr(34) & dctSides.Item(ucrCboSide.GetText) & Chr(34), iNewPosition:=4))

        If Not ucrTxtReplaceNa.IsEmpty Then
            clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="missing_text", strParamValue:=Chr(34) & ucrTxtReplaceNa.GetText & Chr(34), iNewPosition:=0))
        End If

        Dim arrParams(2) As RParameter

        ' Add add the spanner parameter as the first element
        arrParams(0) = New RParameter(strParameterName:="summary_rows_param" & (dataGridSummaries.Rows.Count + 1), strParamValue:=clsSummaryRowsRFunction, bNewIncludeArgumentName:=False)

        ' Add the spanner style as the second element
        If btnStyle.Tag IsNot Nothing Then
            Dim clsTabStyleRFunction As RFunction = btnStyle.Tag
            strSpannerStyleExpression = clsTabStyleRFunction.Clone.ToScript
            arrParams(1) = New RParameter(strParameterName:="tab_style_cells_summary_param" & (dataGridSummaries.Rows.Count + 1), strParamValue:=clsTabStyleRFunction, bNewIncludeArgumentName:=False)
        End If

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridSummaries)
        row.Cells(0).Value = clsSummaryRowsRFunction.Clone.ToScript
        row.Cells(1).Value = strSpannerStyleExpression
        ' Tag the array of parameters
        row.Tag = arrParams
        dataGridSummaries.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
        ucrTxtGroupId.SetName("")
        ucrTxtSummaryLabel.SetName("")
        btnFormat.Tag = Nothing
        btnStyle.Tag = Nothing
    End Sub

    Private Function GetFnParameters() As String
        ' TODO. As of 08/08/2024, GT example like list(fn = "min", label = "Minimum", id = "min") throws an error when exeuted in R-Instat
        ' TODO. Investigate why the error why is thrown when using the databook 

        Dim strFnType As String = dctSummaryTypes.Item(ucrCboSummaryType.GetText)
        Dim strFnParams As String = "id = " & Chr(34) & strFnType & Chr(34) & ", fn = " & Chr(34) & strFnType & Chr(34)
        If Not ucrTxtSummaryLabel.IsEmpty Then
            strFnParams = strFnParams & ", label = " & Chr(34) & ucrCboSummaryType.GetText & Chr(34)
        End If
        ' TODO. Commented out due to error thrown
        'Return "list(" & strFnParams & ")"
        Return Chr(34) & strFnType & Chr(34)
    End Function

    Private Sub btnClearSummaries_Click(sender As Object, e As EventArgs) Handles btnClearSummaries.Click
        dataGridSummaries.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRCommand({"summary_rows"}, clsOperator), clsOperator)
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRParamValue({"tab_style"}, "locations", "cells_summary", clsOperator), clsOperator)

        For index As Integer = 0 To dataGridSummaries.Rows.Count - 1
            Dim lstParams() As RParameter = dataGridSummaries.Rows(index).Tag
            clsOperator.AddParameter(lstParams(0))
            If lstParams(1) IsNot Nothing Then
                clsOperator.AddParameter(lstParams(1))
            End If
        Next
    End Sub
End Class
