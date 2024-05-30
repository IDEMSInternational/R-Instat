Imports System.Reflection

Public Class ucrColumnLabels

    Private clsOperator As New ROperator
    Private clsColsLabelRParameter As New RParameter
    Private bFirstload As Boolean = True

    Private Sub InitialiseDialog()
        ucrReceiverSingleCol.Selector = ucrSelectorCols
        ucrReceiverSingleCol.SetMeAsReceiver()
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        dataGridColLabels.Rows.Clear()


        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand("cols_label", clsOperator)
        If lstRParams.Count > 0 Then
            clsColsLabelRParameter = lstRParams(0)
        Else
            Dim clsColsLabelRFunction As New RFunction
            clsColsLabelRFunction.SetPackageName("gt")
            clsColsLabelRFunction.SetRCommand("cols_label")
            clsColsLabelRParameter = New RParameter(strParameterName:="cols_label_param", strParamValue:=clsColsLabelRFunction, bNewIncludeArgumentName:=False)
        End If

        For Each clsColLabelRParam As RParameter In clsColsLabelRParameter.clsArgumentCodeStructure.clsParameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridColLabels)
            row.Cells(0).Value = clsColLabelRParam.strArgumentName
            row.Cells(1).Value = clsTablesUtils.GetStringValue(clsColLabelRParam.strArgumentValue, False)
            row.Tag = clsColLabelRParam
            dataGridColLabels.Rows.Add(row)
        Next

    End Sub

    Private Sub btnAddLabel_Click(sender As Object, e As EventArgs) Handles btnAddLabel.Click

        Dim strColumnName As String = ucrReceiverSingleCol.GetVariableNames(bWithQuotes:=False)
        Dim strColumnLabel As String = ucrInputColLabel.GetValue()

        Dim clsRParam As New RParameter(strParameterName:=clsTablesUtils.GetStringValue(strColumnName, False), strParamValue:=clsTablesUtils.GetStringValue(strColumnLabel, True), iNewPosition:=0)

        clsColsLabelRParameter.clsArgumentCodeStructure.AddParameter(clsRParam)

        Dim row As DataGridViewRow = Nothing
        For Each existingRow As DataGridViewRow In dataGridColLabels.Rows
            If existingRow.Cells(0).Value = strColumnName Then
                row = existingRow
                row.Cells(0).Value = strColumnName
                row.Cells(1).Value = strColumnLabel
                row.Tag = clsRParam
            End If
        Next


        If row Is Nothing Then
            row = New DataGridViewRow
            row.CreateCells(dataGridColLabels)
            row.Cells(0).Value = strColumnName
            row.Cells(1).Value = strColumnLabel
            row.Tag = clsRParam
            dataGridColLabels.Rows.Add(row)
        End If


        ' Add/update cols label parameter to the operator
        clsOperator.AddParameter(clsColsLabelRParameter)

        ' Clear controls
        ucrReceiverSingleCol.Clear()
        ucrInputColLabel.SetName("")

    End Sub

    Private Sub btnClearLabels_Click(sender As Object, e As EventArgs) Handles btnClearLabels.Click
        clsOperator.RemoveParameter(clsColsLabelRParameter)
        dataGridColLabels.Rows.Clear()
    End Sub


    Private Sub ucrColSpanner_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleCol.ControlContentsChanged, ucrInputColLabel.ControlContentsChanged
        btnAddLabel.Enabled = Not ucrReceiverSingleCol.IsEmpty AndAlso Not ucrInputColLabel.IsEmpty
    End Sub

End Class
