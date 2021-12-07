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

Imports System.ComponentModel

Public Class ucrDataViewLinuxGrid
    Implements IDataViewGrid

    Private _currentDataFrame As clsDataFrame 'Do not use anywhere other than GetCurrentDataFrameFocus()

    Public Event CellDataChanged() Implements IDataViewGrid.CellDataChanged

    Public Event IDataViewGrid_ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String) Implements IDataViewGrid.ReplaceValueInData

    Public Event PasteValuesToDataframe() Implements IDataViewGrid.PasteValuesToDataframe

    Public Event WorksheetChanged() Implements IDataViewGrid.WorksheetChanged

    Public Event WorksheetRemoved(worksheet As clsWorksheetAdapter) Implements IDataViewGrid.WorksheetRemoved

    Public Sub AddColumns(visiblePage As clsDataFramePage) Implements IDataViewGrid.AddColumns
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        dataGrid.ClearSelection()
        dataGrid.Columns.Clear()
        For i = 0 To visiblePage.lstColumns.Count - 1
            Dim dataGridColumn As DataGridViewColumn = New DataGridViewColumn
            dataGridColumn.Name = visiblePage.lstColumns(i).strDisplayName
            dataGridColumn.CellTemplate = New DataGridViewTextBoxCell()
            dataGrid.Columns.Add(dataGridColumn)
        Next
    End Sub

    Public Sub AddRowData(dataFrame As clsDataFrame) Implements IDataViewGrid.AddRowData
        Dim dataGrid = GetDataGridFromSelectedTab()

        If dataFrame.clsFilter.bApplied Then
            dataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Red
        Else
            dataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.DarkBlue
        End If

        Dim strRowNames = dataFrame.strRowNames()
        dataGrid.Rows.Clear()
        For i = 0 To dataFrame.iDisplayedRowCount - 1
            dataGrid.Rows.Add()
            dataGrid.Rows(i).HeaderCell.Value = strRowNames(i)
            For j = 0 To dataGrid.ColumnCount - 1
                dataGrid.Rows(i).Cells(j).Value = dataFrame.Data(i, j)
            Next
        Next
    End Sub

    Public Function SelectedTab() As String
        If tcTabs.SelectedTab Is Nothing Then
            Return ""
        End If
        Return tcTabs.SelectedTab.Text
    End Function

    Public Function GetWorksheetCount() As Integer Implements IDataViewGrid.GetWorksheetCount
        Return tcTabs.TabPages.Count()
    End Function

    Protected Overrides Sub AttachEventsToWorksheet(dataGrid As DataGridView)
        'ToDo Editing disabled so edit events wont work
        ' AddHandler dataGrid.CellEndEdit, AddressOf DataGridView_CellEndEdit
        ' AddHandler dataGrid.CellValueChanged, AddressOf DataGridView_CellValueChanged
        AddHandler dataGrid.KeyDown, AddressOf DataGridView_KeyDown
    End Sub

    Private Sub contextMenuStrip1_Opening(sender As Object, e As CancelEventArgs)
        Dim p = tcTabs.PointToClient(Cursor.Position)
        For i As Integer = 0 To tcTabs.TabCount - 1
            Dim r As Rectangle = tcTabs.GetTabRect(i)
            If r.Contains(p) Then
                tcTabs.SelectedIndex = i ' i is the index of tab under cursor
                Return
            End If
        Next
        e.Cancel = True
    End Sub

    'ToDo allow editing
    Private Sub DataGridView_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        Dim dataGrid = GetDataGridFromSelectedTab()
        RaiseEvent IDataViewGrid_ReplaceValueInData(dataGrid.CurrentCell.Value.ToString(),
                        GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(dataGrid.CurrentCell.ColumnIndex).strName,
                        GetCurrentDataFrameFocus().clsVisiblePage.RowNames()(dataGrid.CurrentCell.RowIndex))
    End Sub

    'ToDo allow editing
    Private Sub DataGridView_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        RaiseEvent CellDataChanged()
    End Sub

    Private Sub DataGridView_KeyDown(sender As Object, e As KeyEventArgs)
        Dim ctrlV As Boolean = e.Modifiers = Keys.Control And e.KeyCode = Keys.V
        Dim shiftIns As Boolean = e.Modifiers = Keys.Shift And e.KeyCode = Keys.Insert
        If ctrlV Or shiftIns Then
            RaiseEvent PasteValuesToDataframe()
        End If
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        If _currentDataFrame Is Nothing Then
            _currentDataFrame = _clsDataBook.GetDataFrame(SelectedTab)
        ElseIf _currentDataFrame.strName IsNot SelectedTab() Then
            _currentDataFrame = _clsDataBook.GetDataFrame(SelectedTab)
        End If
        Return _currentDataFrame
    End Function

    Private Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay) Implements IDataViewGrid.GetSelectedColumns
        Dim lstColumns As New List(Of clsColumnHeaderDisplay)
        Dim dataGrid = GetGrid(tcTabs.SelectedTab)
        Dim selectedColumns As New List(Of Integer)
        For Each cell In dataGrid.SelectedCells
            If Not selectedColumns.Contains(cell.columnIndex) Then
                selectedColumns.Add(cell.columnIndex)
            End If
        Next
        For Each columnIndex In selectedColumns
            lstColumns.Add(GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(columnIndex))
        Next
        Return lstColumns
    End Function

    Private Sub tcTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tcTabs.SelectedIndexChanged
        RaiseEvent WorksheetChanged()
    End Sub

End Class