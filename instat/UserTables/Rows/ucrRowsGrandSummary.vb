Imports CefSharp.DevTools.Overlay

Public Class ucrRowsGrandSummary
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
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        ucrReceiverMultipleCols.Clear()
        dataGridSummaries.Rows.Clear()
        btnAddSummaries.Enabled = False

        SetupSummaryRowInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"grand_summary_rows"}, clsOperator))
    End Sub

    Private Sub SetupSummaryRowInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabSummaryRowRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridSummaries)
            row.Cells(0).Value = clsTabSummaryRowRFunction.Clone.ToScript
            row.Tag = clsRParam
            dataGridSummaries.Rows.Add(row)
        Next
    End Sub

    Private Sub btnFormat_Click(sender As Object, e As EventArgs) Handles btnFormat.Click
        sdgCellFormatNumberOptions.ShowDialog(Me.ParentForm)
        Dim clsFormatRFunction As RFunction = sdgCellFormatNumberOptions.GetNewUserInputAsRFunction()

        If clsFormatRFunction IsNot Nothing Then
            btnFormat.Tag = clsFormatRFunction
        End If
    End Sub

    Private Sub conditionValue_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged
        btnAddSummaries.Enabled = Not ucrReceiverMultipleCols.IsEmpty
    End Sub

    Private Sub btnAddSummaries_Click(sender As Object, e As EventArgs) Handles btnAddSummaries.Click
        Dim clsSummaryRowsRFunction As New RFunction
        clsSummaryRowsRFunction.SetPackageName("gt")
        clsSummaryRowsRFunction.SetRCommand("grand_summary_rows")

        clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="fns", strParamValue:=GetFnParameters(), iNewPosition:=1))
        clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False), iNewPosition:=2))

        If btnFormat.Tag IsNot Nothing Then
            Dim clsFormatRFunction As RFunction = btnFormat.Tag
            clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="fmt", strParamValue:=clsFormatRFunction, iNewPosition:=3))
        End If

        clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="side", strParamValue:=Chr(34) & dctSides.Item(ucrCboSide.GetText) & Chr(34), iNewPosition:=4))

        If Not ucrTxtReplaceNa.IsEmpty Then
            clsSummaryRowsRFunction.AddParameter(New RParameter(strParameterName:="missing_text", strParamValue:=Chr(34) & ucrTxtReplaceNa.GetText & Chr(34), iNewPosition:=0))
        End If

        Dim clsParam As RParameter = New RParameter(strParameterName:="grand_summary_rows_param" & (dataGridSummaries.Rows.Count + 1), strParamValue:=clsSummaryRowsRFunction, bNewIncludeArgumentName:=False)

        Dim row As New DataGridViewRow
        row.CreateCells(dataGridSummaries)
        row.Cells(0).Value = clsSummaryRowsRFunction.Clone.ToScript
        ' Tag the array of parameters
        row.Tag = clsParam
        dataGridSummaries.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
        ucrTxtSummaryLabel.SetName("")
        btnFormat.Tag = Nothing
    End Sub

    Private Function GetFnParameters() As String
        Dim strFnType As String = dctSummaryTypes.Item(ucrCboSummaryType.GetText)
        Dim strFnParams As String = "id = " & Chr(34) & strFnType & Chr(34) & ", fn = " & Chr(34) & strFnType & Chr(34)
        Dim strSummaryLabel As String = If(Not ucrTxtSummaryLabel.IsEmpty, ucrTxtSummaryLabel.GetText, ucrCboSummaryType.GetText)
        strFnParams = strFnParams & ", label = " & Chr(34) & strSummaryLabel & Chr(34)
        Return "list(" & strFnParams & ")"
    End Function

    Private Sub btnClearSummaries_Click(sender As Object, e As EventArgs) Handles btnClearSummaries.Click
        dataGridSummaries.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRCommand({"grand_summary_rows"}, clsOperator), clsOperator)

        For index As Integer = 0 To dataGridSummaries.Rows.Count - 1
            clsOperator.AddParameter(dataGridSummaries.Rows(index).Tag)
        Next
    End Sub
End Class
