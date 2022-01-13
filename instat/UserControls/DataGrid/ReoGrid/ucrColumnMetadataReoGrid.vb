' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class ucrColumnMetadataReoGrid
    Implements IColumnMetaDataGrid

    Private _lstNonEditableColumns As New List(Of String)
    Private strPreviousCellText As String

    Public Event EditValue(iRow As Integer, strColumnName As String, strPreviousValue As String, newValue As Object) Implements IColumnMetaDataGrid.EditValue

    Public Sub AddColumns(columnMetaData As clsColumnMetaData) Implements IColumnMetaDataGrid.AddColumns
        grdData.CurrentWorksheet.Columns = columnMetaData.iColumnCount
        For i = 0 To columnMetaData.iColumnCount - 1
            grdData.CurrentWorksheet.ColumnHeaders(i).Text = columnMetaData.strColumnName(i)
        Next
    End Sub

    Public Sub AddRowData(columnMetaData As clsColumnMetaData) Implements IColumnMetaDataGrid.AddRowData
        Dim rngDataRange As RangePosition

        grdData.CurrentWorksheet.Rows = columnMetaData.iRowCount
        rngDataRange = New RangePosition(0, 0, grdData.CurrentWorksheet.Rows, grdData.CurrentWorksheet.Columns)
        grdData.CurrentWorksheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)

        For i = 0 To grdData.CurrentWorksheet.Rows - 1
            For j = 0 To grdData.CurrentWorksheet.Columns - 1
                grdData.CurrentWorksheet(row:=i, col:=j) = columnMetaData.Data(i, j)
            Next
            grdData.CurrentWorksheet.RowHeaders.Item(i).Text = columnMetaData.strRowName(i)
        Next
    End Sub

    Public Function GetSelectedColumns() As List(Of String) Implements IColumnMetaDataGrid.GetSelectedColumns
        Dim lstColumns As New List(Of String)
        Dim clsGridRangePosition As RangePosition = grdData.CurrentWorksheet.SelectionRange
        For i As Integer = clsGridRangePosition.Row To clsGridRangePosition.Row + clsGridRangePosition.Rows - 1
            lstColumns.Add(grdData.CurrentWorksheet(i, 0))
        Next
        Return lstColumns
    End Function

    Public Sub SetNonEditableColumns(lstNonEditableColumns As List(Of String)) Implements IColumnMetaDataGrid.SetNonEditableColumns
        _lstNonEditableColumns = lstNonEditableColumns
    End Sub

    Protected Overrides Sub AttachEventsToWorksheet(worksheet As Worksheet)
        AddHandler worksheet.AfterCellEdit, AddressOf Worksheet_AfterCellEdit
        AddHandler worksheet.BeforeCellEdit, AddressOf Worksheet_BeforeCellEdit
        AddHandler worksheet.BeforeCut, AddressOf Worksheet_BeforeCut
        AddHandler worksheet.BeforePaste, AddressOf Worksheet_BeforePaste
        AddHandler worksheet.BeforeRangeMove, AddressOf Worksheet_BeforeRangeMove
        AddHandler worksheet.BeforeCellKeyDown, AddressOf Worksheet_BeforeCellKeyDown
    End Sub

    Private Sub Worksheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs)
        If e.NewData.ToString() = strPreviousCellText Then
            e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            Exit Sub
        End If
        RaiseEvent EditValue(e.Cell.Row, grdData.CurrentWorksheet.ColumnHeaders(e.Cell.Column).Text, strPreviousCellText, e.NewData)
        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
    End Sub

    Private Sub Worksheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs)
        If _lstNonEditableColumns.Contains(grdData.CurrentWorksheet.ColumnHeaders(e.Cell.Column).Text) Then
            e.IsCancelled = True
        Else
            strPreviousCellText = e.Cell.Data.ToString()
        End If
    End Sub

    Private Sub Worksheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs)
        MsgBox("Pasting multiple cells is currently disabled. This feature will be included in future versions.", MsgBoxStyle.Information, "Cannot paste")
        e.IsCancelled = True
    End Sub

End Class