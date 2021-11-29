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

Public Class ucrDataframeMetadataReoGrid
    Implements IDataframeMetaDataGrid
    Private lstNonEditableColumns As New List(Of String)
    Private strPreviousCellText As String

    Public Event EditValue(iRow As Integer, strColumnName As String, strPreviousValue As String, newValue As Object) Implements IDataframeMetaDataGrid.EditValue

    Public Sub AddColumns() Implements IDataframeMetaDataGrid.AddColumns
        grdData.CurrentWorksheet.Columns = _clsDataBook.clsDataFrameMetaData.ColumnCount
        For i = 0 To _clsDataBook.clsDataFrameMetaData.ColumnCount - 1
            grdData.CurrentWorksheet.ColumnHeaders(i).Text = _clsDataBook.clsDataFrameMetaData.ColumnName(i)
        Next
    End Sub

    Public Sub AddRowData() Implements IDataframeMetaDataGrid.AddRowData
        Dim rngDataRange As RangePosition

        grdData.CurrentWorksheet.Rows = _clsDataBook.clsDataFrameMetaData.RowCount
        rngDataRange = New RangePosition(0, 0, grdData.CurrentWorksheet.Rows, grdData.CurrentWorksheet.Columns)
        grdData.CurrentWorksheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)

        For i = 0 To _clsDataBook.clsDataFrameMetaData.RowCount - 1
            For j = 0 To grdData.CurrentWorksheet.Columns - 1
                grdData.CurrentWorksheet(row:=i, col:=j) = _clsDataBook.clsDataFrameMetaData.Data(i, j)
            Next
            grdData.CurrentWorksheet.RowHeaders.Item(i).Text = _clsDataBook.clsDataFrameMetaData.RowName(i)
        Next
    End Sub

    Public Sub SetupMainWorksheet(strWorksheetName As String) Implements IDataframeMetaDataGrid.SetupMainWorksheet
        grdData.Worksheets(0).Name = strWorksheetName
        grdData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, True)
        grdData.Worksheets(0).SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdData.Worksheets(0).SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdData.Worksheets(0).SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdData.Worksheets(0).SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        grdData.SheetTabNewButtonVisible = False
        AttachEventsToWorksheet(grdData.Worksheets(0))
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
        If lstNonEditableColumns.Contains(grdData.CurrentWorksheet.ColumnHeaders(e.Cell.Column).Text) Then
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