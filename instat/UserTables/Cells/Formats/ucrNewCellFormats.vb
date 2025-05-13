Public Class ucrNewCellFormats
    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private ReadOnly strZero As String = "0"
    Private ReadOnly strMultipleDashes As String = "...."
    Private ReadOnly strMissing As String = "missing"
    Private ReadOnly strStar As String = "***"

    Private Sub InitialiseControl()
        ucrChkDataFormat.SetText("Specify the Data Format")
        ucrChkMissingValues.SetText("Replace NA")

        grpFormatData.Visible = False
        grpMissingValues.Visible = False
        btnNumberFormat.Visible = False
        btnDateFormat.Visible = False
        btnTextFormat.Visible = False
        btnClearFormats.Visible = False
        btnClear.Visible = False
        dataGridFormats.Visible = False
        dataGrid.Visible = False
        lblMissingTexts.Visible = False
        lblFormats.Visible = False

        ucrPnlFormat.AddRadioButton(rdoNumber)
        ucrPnlFormat.AddRadioButton(rdoDate)
        ucrPnlFormat.AddRadioButton(rdoText)

        ucrTxtMissingText.SetItems({strZero, strMultipleDashes, strMissing, strStar})
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ' Clear and Set up the data grid with contents
        dataGridFormats.Rows.Clear()
        SetupDataFormatGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator))

        dataGrid.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRCommand({"sub_missing"}, clsOperator))
    End Sub

    Private Sub SetupDataFormatGrid(lstRParams As List(Of RParameter))

        For Each clsRParam As RParameter In lstRParams

            Dim clsFormatRFunction As RFunction = clsRParam.clsArgumentCodeStructure

            ' Create a new row that represents the tab_row_group() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridFormats)

            ' Set the function name
            row.Cells(0).Value = clsFormatRFunction.strRCommand

            For Each clsRowGroupRParam As RParameter In clsFormatRFunction.clsParameters
                If clsRowGroupRParam.strArgumentName = "columns" Then
                    row.Cells(1).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                ElseIf clsRowGroupRParam.strArgumentName = "rows" Then
                    row.Cells(2).Value = clsTablesUtils.GetStringValue(clsRowGroupRParam.strArgumentValue, False)
                End If
            Next

            ' Tag and add the  tab_row_group() parameter function contents as a row
            row.Tag = clsRParam
            dataGridFormats.Rows.Add(row)

        Next
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

    Private Sub btnTextFormat_Click(sender As Object, e As EventArgs) Handles btnTextFormat.Click
        Dim clsFormatRFunction As RFunction = Nothing
        sdgCellFormatTextOptions.ShowDialog(Me.ParentForm)
        clsFormatRFunction = sdgCellFormatTextOptions.GetNewUserInputAsRFunction()
        If clsFormatRFunction Is Nothing Then
            Exit Sub
        End If
        AddFormatParameterToGrid(clsFormatRFunction)
    End Sub


    Private Sub AddFormatParameterToGrid(clsFormatRFunction As RFunction)
        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="fmt_param" & (dataGridFormats.Rows.Count + 1), strParamValue:=clsFormatRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGridFormats)
        row.Cells(0).Value = clsFormatRFunction.strRCommand

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGridFormats.Rows.Add(row)

    End Sub

    Private Sub btnClearFormats_Click(sender As Object, e As EventArgs) Handles btnClearFormats.Click
        dataGridFormats.Rows.Clear()
    End Sub

    Public Sub SetValuesToOperator()
        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"fmt", "fmt_units", "fmt_number", "fmt_currency"}, clsOperator)
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFormats, clsOperator)
    End Sub

    Private Sub btnDateFormat_Click(sender As Object, e As EventArgs) Handles btnDateFormat.Click
        Dim clsFormatRFunction As RFunction = Nothing
        sdgCellFormatDateOptions.ShowDialog(Me.ParentForm)
        clsFormatRFunction = sdgCellFormatDateOptions.GetNewUserInputAsRFunction()
        If clsFormatRFunction Is Nothing Then
            Exit Sub
        End If

        AddFormatParameterToGrid(clsFormatRFunction)
    End Sub

    Private Sub btnNumberFormat_Click(sender As Object, e As EventArgs) Handles btnNumberFormat.Click
        Dim clsFormatRFunction As RFunction = Nothing

        sdgCellFormatNumberOptions.ShowDialog(Me.ParentForm)
            clsFormatRFunction = sdgCellFormatNumberOptions.GetNewUserInputAsRFunction()

        If clsFormatRFunction Is Nothing Then
            Exit Sub
        End If

        AddFormatParameterToGrid(clsFormatRFunction)
    End Sub

    Private Sub ucrChkDataFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDataFormat.ControlValueChanged
        If ucrChkDataFormat.Checked Then
            grpFormatData.Visible = True
            btnClearFormats.Visible = True
            dataGridFormats.Visible = True
            lblFormats.Visible = True
        Else
            grpFormatData.Visible = False
            btnClearFormats.Visible = False
            dataGridFormats.Visible = False
            lblFormats.Visible = False
        End If

    End Sub

    Private Sub ucrChkMissingValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMissingValues.ControlValueChanged
        If ucrChkMissingValues.Checked Then
            grpMissingValues.Visible = True
            btnClear.Visible = True
            dataGrid.Visible = True
            lblMissingTexts.Visible = True
        Else
            grpMissingValues.Visible = False
            btnClear.Visible = False
            dataGrid.Visible = False
            lblMissingTexts.Visible = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dataGrid.Rows.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim clsSubMissingRFunction As New RFunction

        clsSubMissingRFunction.SetPackageName("gt")
        clsSubMissingRFunction.SetRCommand("sub_missing")
        clsSubMissingRFunction.AddParameter(strParameterName:="missing_text", strParameterValue:=Chr(34) & ucrTxtMissingText.GetText & Chr(34), iPosition:=1)

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="sub_missing_param" & (dataGrid.Rows.Count + 1), strParamValue:=clsSubMissingRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGrid)
        row.Cells(0).Value = clsSubMissingRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGrid.Rows.Add(row)

        ucrTxtMissingText.SetName("")
    End Sub

    Private Sub ucrPnlFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFormat.ControlValueChanged
        If rdoNumber.Checked Then
            btnNumberFormat.Visible = True
        Else
            btnNumberFormat.Visible = False
        End If
        If rdoDate.Checked Then
            btnDateFormat.Visible = True
        Else
            btnDateFormat.Visible = False
        End If
        If rdoText.Checked Then
            btnTextFormat.Visible = True
        Else
            btnTextFormat.Visible = False
        End If
    End Sub
End Class
