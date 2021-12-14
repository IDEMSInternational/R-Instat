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

Public Class ucrColumnMetadataLinuxGrid
    Implements IColumnMetaDataGrid

    Private _lstNonEditableColumns As New List(Of String)

    Public Event EditValue(iRow As Integer, strColumnName As String, strPreviousValue As String, newValue As Object) Implements IColumnMetaDataGrid.EditValue

    Public Sub AddColumns(columnMetaData As clsColumnMetaData) Implements IColumnMetaDataGrid.AddColumns
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        dataGrid.Columns.Clear()
        For i = 0 To columnMetaData.iColumnCount - 1
            Dim dataGridColumn As DataGridViewColumn = New DataGridViewColumn
            dataGridColumn.Name = columnMetaData.strColumnName(i)
            dataGridColumn.CellTemplate = New DataGridViewTextBoxCell()
            dataGrid.Columns.Add(dataGridColumn)
        Next
    End Sub

    Public Sub AddRowData(columnMetaData As clsColumnMetaData) Implements IColumnMetaDataGrid.AddRowData
        Dim dataGrid = GetDataGridFromSelectedTab()
        dataGrid.Rows.Clear()
        For i = 0 To columnMetaData.iRowCount - 1
            dataGrid.Rows.Add()
            dataGrid.Rows(i).HeaderCell.Value = columnMetaData.strRowName(i)
            For j = 0 To dataGrid.ColumnCount - 1
                dataGrid.Rows(i).Cells(j).Value = columnMetaData.Data(i, j)
            Next
        Next
    End Sub

    Public Function GetSelectedColumns() As List(Of String) Implements IColumnMetaDataGrid.GetSelectedColumns
        Dim lstColumns As New List(Of String)
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        Dim selectedColumns As New List(Of Integer)
        For Each cell In dataGrid.SelectedCells
            If Not selectedColumns.Contains(cell.columnIndex) Then
                selectedColumns.Add(cell.columnIndex)
            End If
        Next
        For Each columnIndex In selectedColumns
            lstColumns.Add(dataGrid.Columns(columnIndex).Name)
        Next
        Return lstColumns
    End Function

    Public Sub SetNonEditableColumns(lstNonEditableColumns As List(Of String)) Implements IColumnMetaDataGrid.SetNonEditableColumns
        _lstNonEditableColumns = lstNonEditableColumns
    End Sub

    Protected Overrides Sub AttachEventsToWorksheet(dataGrid As DataGridView)
        'ToDo Attach events
    End Sub

End Class