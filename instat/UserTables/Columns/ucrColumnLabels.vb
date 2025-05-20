Imports System.Reflection
Imports RDotNet

Public Class ucrColumnLabels

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True
    Private clsRenameFunction As New RFunction


    Private Sub InitialiseDialog()
        ucrReceiverSingleCol.Selector = ucrSelectorCols
        ucrReceiverSingleCol.strSelectorHeading = "Tables"
        ucrReceiverSingleCol.SetItemType(RObjectTypeLabel.Table)
        ucrReceiverSingleCol.SetMeAsReceiver()
        ucrInputColLabel.Visible = False
        lblColLabels.Visible = False

        clsRenameFunction.SetPackageName("dplyr")
        clsRenameFunction.SetRCommand("rename")
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        dataGridColLabels.Rows.Clear()

        clsRenameFunction.clsParameters.Clear()

        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"cols_label"}, clsOperator)
        If lstRParams.Count > 0 Then
            For Each clsColLabelRParam As RParameter In lstRParams(0).clsArgumentCodeStructure.clsParameters
                Dim row As New DataGridViewRow
                row.CreateCells(dataGridColLabels)
                row.Cells(0).Value = clsColLabelRParam.strArgumentName
                row.Cells(1).Value = clsTablesUtils.GetStringValue(clsColLabelRParam.strArgumentValue, False)
                row.Tag = clsColLabelRParam
                dataGridColLabels.Rows.Add(row)
            Next
        End If

    End Sub

    Private Sub btnAddLabel_Click(sender As Object, e As EventArgs) Handles btnAddLabel.Click

        Dim strColumnName As String = ucrReceiverSingleCol.GetVariableNames(bWithQuotes:=False)
        Dim strColumnLabel As String = ucrInputColLabel.GetValue()

        Dim clsRParam As New RParameter(strParameterName:=clsTablesUtils.GetStringValue(strColumnName, False), strParamValue:=clsTablesUtils.GetStringValue(strColumnLabel, True))
        Dim row As DataGridViewRow = Nothing

        ' Update column label if column exists
        For Each existingRow As DataGridViewRow In dataGridColLabels.Rows
            If existingRow.Cells(0).Value = strColumnName Then
                row = existingRow
                row.Cells(1).Value = strColumnLabel
                row.Tag = clsRParam
                Exit For
            End If
        Next

        ' If column does not exist then add new column label
        If row Is Nothing Then
            row = New DataGridViewRow
            row.CreateCells(dataGridColLabels)
            row.Cells(0).Value = strColumnName
            row.Cells(1).Value = strColumnLabel
            row.Tag = clsRParam
            dataGridColLabels.Rows.Add(row)
        End If

        ' Clear controls
        ucrReceiverSingleCol.Clear()
        ucrInputColLabel.SetName("")

    End Sub

    Private Sub btnClearLabels_Click(sender As Object, e As EventArgs) Handles btnClearLabels.Click
        dataGridColLabels.Rows.Clear()
    End Sub

    Private Sub ucrColSpanner_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleCol.ControlContentsChanged, ucrInputColLabel.ControlContentsChanged
        btnAddLabel.Enabled = Not ucrReceiverSingleCol.IsEmpty AndAlso Not ucrInputColLabel.IsEmpty
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridColLabels.CellValueChanged
        If dataGridColLabels.Rows.Count = 0 Then Exit Sub

        ' Ensure the changed cell is in the "new_name" column
        If e.ColumnIndex = dataGridColLabels.Columns("colCodnition").Index Then
            Dim rowIndex As Integer = e.RowIndex
            Dim oldName As String = dataGridColLabels.Rows(rowIndex).Cells("colLabel").Value?.ToString()
            Dim newName As String = dataGridColLabels.Rows(rowIndex).Cells("colCodnition").Value?.ToString()

            If oldName.Contains("-") Then
                oldName = "`" & oldName & "`"
            End If

            ' Ensure clsRenameFunction is cleared before adding new parameters
            clsRenameFunction.clsParameters.Clear()
            clsRenameFunction.AddParameter(strParameterName:=newName, oldName)

            ' Update the operator
            SetValuesToOperator()
        End If
    End Sub



    Public Sub SetValuesToOperator()
        ' Clear previous parameters
        clsOperator.clsParameters.Clear()

        If dataGridColLabels.Rows.Count = 0 Then Exit Sub

        ' Reset rename function
        clsRenameFunction.SetPackageName("dplyr")
        clsRenameFunction.SetRCommand("rename")

        ' Ensure rename function has correct parameters
        For Each row As DataGridViewRow In dataGridColLabels.Rows
            If row.Cells(0).Value IsNot Nothing AndAlso row.Cells(1).Value IsNot Nothing Then
                Dim oldName As String = row.Cells(0).Value.ToString()
                Dim newName As String = row.Cells(1).Value.ToString()

                If oldName.Contains("-") Then
                    oldName = "`" & oldName & "`"
                End If

                clsRenameFunction.AddParameter(strParameterName:=newName, oldName)
            End If
        Next

        ' Ensure rename is applied to last_table$`_data`
        Dim clsPipeOperator As New ROperator
        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", ucrReceiverSingleCol.GetVariableNames(False) & "$`_data`", iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsRenameFunction, iPosition:=1)

        Dim clsGtFunction As New RFunction
        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")
        clsGtFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, bIncludeArgumentName:=False)
        ' Add the final assignment to the operator
        clsOperator.AddParameter(New RParameter("rename_command", clsGtFunction, False))
    End Sub


    Private Sub ucrReceiverSingleCol_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSingleCol.ControlValueChanged
        Dim clsGetRObject As New RFunction
        Dim clsAsDataFrame As New RFunction
        clsGetRObject.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetRObject.AddParameter("data_name", Chr(34) & ucrSelectorCols.strCurrentDataFrame & Chr(34))
        clsGetRObject.AddParameter("object_name", ucrReceiverSingleCol.GetVariableNames)

        clsAsDataFrame.SetRCommand("as.data.frame")
        clsAsDataFrame.AddParameter("object", clsRFunctionParameter:=clsGetRObject, bIncludeArgumentName:=False)
        Dim strScript As String = "colnames(" & clsAsDataFrame.ToScript & ")"
        Dim lstObjectss As GenericVector
        lstObjectss = frmMain.clsRLink.RunInternalScriptGetValue(strScript).AsList

        If dataGridColLabels.Rows.Count < lstObjectss.Count Then
            dataGridColLabels.Rows.Add(lstObjectss.Count - dataGridColLabels.Rows.Count)
        End If
        For i = 0 To lstObjectss.Count - 1
            dataGridColLabels.Rows(i).Cells(0).Value = lstObjectss(i).AsCharacter(0)
        Next
        SetValuesToOperator()
    End Sub

End Class
