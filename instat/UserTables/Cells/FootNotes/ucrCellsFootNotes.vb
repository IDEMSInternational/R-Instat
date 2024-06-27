Public Class ucrCellsFootNotes

    Private clsOperator As New ROperator
    Private bFirstload As Boolean = True

    Private Sub InitialiseControl()
        ucrReceiverSingleCol.Selector = ucrSelectorCols
        ucrReceiverSingleCol.SetMeAsReceiver()

        cboPlacement.SelectedIndex = 0
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)
        If bFirstload Then
            InitialiseControl()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ' Set up the selector
        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)

        ' Clear and Set up the data grid with contents
        dataGridFootNotes.Rows.Clear()
        SetupDataGrid(clsTablesUtils.FindRFunctionsParamsWithRParamValue("tab_footnote", "locations", "cells_body", clsOperator))

    End Sub

    Public Sub SetValuesToOperator()
        ' Remove any previous cell footers 
        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRParamValue("tab_footnote", "locations", "cells_body", clsOperator)
        For Each clsRParam As RParameter In lstRParams
            clsOperator.RemoveParameter(clsRParam)
        Next

        ' Add new changes
        clsTablesUtils.AddGridRowTagsRParamsToROperator(dataGridFootNotes, clsOperator)
    End Sub

    Private Sub SetupDataGrid(lstRParams As List(Of RParameter))

        For Each clsRParam As RParameter In lstRParams

            ' Create a new row that represents the tab_style() parameters
            Dim row As New DataGridViewRow
            row.CreateCells(dataGridFootNotes)
            row.Cells(0).Value = clsRParam.clsArgumentCodeStructure.Clone.ToScript

            ' Tag and add the tab_style() parameter function contents as a row
            row.Tag = clsRParam
            dataGridFootNotes.Rows.Add(row)

        Next
    End Sub

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputRows.ControlContentsChanged, ucrReceiverSingleCol.ControlContentsChanged
        btnAdd.Enabled = Not ucrReceiverSingleCol.IsEmpty AndAlso Not ucrInputRows.IsEmpty
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim clsTabFootNoteRFunction As New RFunction
        Dim clsLocationsRFunction As New RFunction


        clsLocationsRFunction.SetPackageName("gt")
        clsLocationsRFunction.SetRCommand("cells_body")
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=ucrReceiverSingleCol.GetVariableNames(bWithQuotes:=False), iNewPosition:=0))
        clsLocationsRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=ucrInputRows.GetText, iNewPosition:=1))

        clsTabFootNoteRFunction.SetPackageName("gt")
        clsTabFootNoteRFunction.SetRCommand("tab_footnote")
        clsTabFootNoteRFunction.AddParameter(strParameterName:="footnote", strParameterValue:=Chr(34) & ucrTxtFootNote.GetText & Chr(34), iPosition:=0)
        clsTabFootNoteRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsLocationsRFunction, iPosition:=1)
        If cboPlacement.Text.ToLower <> "auto" Then
            clsTabFootNoteRFunction.AddParameter(strParameterName:="placement", strParameterValue:=Chr(34) & cboPlacement.Text.ToLower & Chr(34), iPosition:=2)
        End If

        ' Create parameter with unique name
        Dim clsRParam As New RParameter(strParameterName:="tab_footnote_cells_param" & (dataGridFootNotes.Rows.Count + 1), strParamValue:=clsTabFootNoteRFunction, bNewIncludeArgumentName:=False)

        ' Create row and its cells
        Dim row As New DataGridViewRow
        row.CreateCells(dataGridFootNotes)
        row.Cells(0).Value = clsTabFootNoteRFunction.Clone.ToScript

        ' Tag the row with the parameter 
        row.Tag = clsRParam

        ' Add it to grid
        dataGridFootNotes.Rows.Add(row)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dataGridFootNotes.Rows.Clear()
    End Sub

End Class
