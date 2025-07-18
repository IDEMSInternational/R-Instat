Public Class ucrColumnNanoPlots
    Private bFirstLoad As Boolean = True
    Private clsOperator As New ROperator
    Private dctPlotTypes, dctMissingVals As New Dictionary(Of String, String)

    Private Sub InitialiseControl()
        ucrReceiverMultipleCols.SetDataType("numeric", bStrict:=True)

        dctPlotTypes.Add("Line", "line")
        dctPlotTypes.Add("Bar", "bar")
        dctPlotTypes.Add("Boxplot", "boxplot")
        ucrCboPlotType.SetItems(dctPlotTypes, bSetConditions:=False)
        ucrCboPlotType.SetDropDownStyleAsNonEditable()
        ucrCboPlotType.GetSetSelectedIndex = 0

        dctMissingVals.Add("Gap", "gap")
        dctMissingVals.Add("Marker", "marker")
        dctMissingVals.Add("Zero", "zero")
        dctMissingVals.Add("Remove", "remove")
        ucrCboMissingValues.SetItems(dctMissingVals, bSetConditions:=False)
        ucrCboMissingValues.SetDropDownStyleAsNonEditable()
        ucrCboMissingValues.GetSetSelectedIndex = 0

        ucrNudPlotHeight.Value = 2
        ucrChkAutoHideCols.SetText("Hide Selected Nano Plot Columns")
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If

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

        dataGrid.Rows.Clear()
        ucrNudPlotHeight.Value = 2
        ucrChkAutoHideCols.Checked = True
        btnAddNanoplot.Enabled = False

        SetupNanoplotsInDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"cols_nanoplot"}, clsOperator))
    End Sub

    Private Sub SetupNanoplotsInDataGrid(lstRParams As List(Of RParameter))
        For Each clsRParam As RParameter In lstRParams
            Dim clsTabSummaryRowRFunction As RFunction = clsRParam.clsArgumentCodeStructure
            Dim row As New DataGridViewRow
            row.CreateCells(dataGrid)
            row.Cells(0).Value = clsTabSummaryRowRFunction.Clone.ToScript
            row.Tag = clsRParam
            dataGrid.Rows.Add(row)
        Next
    End Sub

    Private Sub conditionValue_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged, ucrTxtColumnLabel.ControlContentsChanged
        btnAddNanoplot.Enabled = Not ucrReceiverMultipleCols.IsEmpty AndAlso Not ucrTxtColumnLabel.IsEmpty
    End Sub

    Private Sub btnAddNanoplot_Click(sender As Object, e As EventArgs) Handles btnAddNanoplot.Click
        Dim strColLabel As String = ucrTxtColumnLabel.GetText
        Dim strColName As String = strColLabel.Replace(" ", "")
        Dim clsNanoPlotsRFunction As New RFunction
        clsNanoPlotsRFunction.SetPackageName("gt")
        clsNanoPlotsRFunction.SetRCommand("cols_nanoplot")

        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=mdlCoreControl.GetRVector(ucrReceiverMultipleCols.GetVariableNamesList(bWithQuotes:=False), bOnlyIfMultipleElement:=False), iNewPosition:=0))
        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="plot_type", strParamValue:=Chr(34) & dctPlotTypes.Item(ucrCboPlotType.GetText) & Chr(34), iNewPosition:=1))
        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="plot_height", strParamValue:=Chr(34) & ucrNudPlotHeight.Value & "em" & Chr(34), iNewPosition:=2))
        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="missing_vals", strParamValue:=Chr(34) & dctMissingVals.Item(ucrCboMissingValues.GetText) & Chr(34), iNewPosition:=3))
        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="autohide", ucrChkAutoHideCols.Checked.ToString().ToUpper(), iNewPosition:=4))
        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="new_col_name", strParamValue:=Chr(34) & strColName & Chr(34), iNewPosition:=5))
        clsNanoPlotsRFunction.AddParameter(New RParameter(strParameterName:="new_col_label", strParamValue:=Chr(34) & strColLabel & Chr(34), iNewPosition:=6))

        Dim clsParam As RParameter = New RParameter(strParameterName:="cols_nanoplot_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsNanoPlotsRFunction, bNewIncludeArgumentName:=False)

        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsNanoPlotsRFunction.Clone.ToScript
        ' Tag the array of parameters
        row.Tag = clsParam
        dataGrid.Rows.Add(row)

        ucrReceiverMultipleCols.Clear()
        ucrTxtColumnLabel.SetName("")
    End Sub

    Private Sub btnClearSummaries_Click(sender As Object, e As EventArgs) Handles btnClearSummaries.Click
        dataGrid.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRParams(clsTablesUtils.FindRFunctionsParamsWithRCommand({"cols_nanoplot"}, clsOperator), clsOperator)

        For index As Integer = 0 To dataGrid.Rows.Count - 1
            clsOperator.AddParameter(dataGrid.Rows(index).Tag)
        Next
    End Sub
End Class
