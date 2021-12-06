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

Public Class ucrDataframeMetadataLinuxGrid
    Implements IDataframeMetaDataGrid

    Public Event EditValue(iRow As Integer, strColumnName As String, strPreviousValue As String, newValue As Object) Implements IDataframeMetaDataGrid.EditValue

    Public Sub AddColumns() Implements IDataframeMetaDataGrid.AddColumns
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        dataGrid.Columns.Clear()
        For i = 0 To _clsDataBook.clsDataFrameMetaData.ColumnCount - 1
            Dim dataGridColumn As DataGridViewColumn = New DataGridViewColumn
            dataGridColumn.Name = _clsDataBook.clsDataFrameMetaData.ColumnName(i)
            dataGridColumn.CellTemplate = New DataGridViewTextBoxCell()
            dataGrid.Columns.Add(dataGridColumn)
        Next
    End Sub

    Public Sub AddRowData() Implements IDataframeMetaDataGrid.AddRowData
        Dim dataGrid = GetDataGridFromSelectedTab()
        dataGrid.Rows.Clear()
        For i = 0 To _clsDataBook.clsDataFrameMetaData.RowCount - 1
            dataGrid.Rows.Add()
            dataGrid.Rows(i).HeaderCell.Value = _clsDataBook.clsDataFrameMetaData.RowName(i)
            For j = 0 To dataGrid.ColumnCount - 1
                dataGrid.Rows(i).Cells(j).Value = _clsDataBook.clsDataFrameMetaData.Data(i, j)
            Next
        Next
    End Sub

    Public Sub SetupMainWorksheet(strWorksheetName As String) Implements IDataframeMetaDataGrid.SetupMainWorksheet
        tcTabs.TabPages.Clear()
        AddNewWorksheet(strWorksheetName)
    End Sub

    Protected Overrides Sub AttachEventsToWorksheet(dataGrid As DataGridView)
        'ToDo Attach events
    End Sub

End Class