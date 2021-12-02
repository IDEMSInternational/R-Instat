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

Public Class ucrDataViewReoGrid
    Implements IDataViewGrid

    Public Event CellDataChanged() Implements IDataViewGrid.CellDataChanged

    Public Event PasteValuesToDataframe() Implements IDataViewGrid.PasteValuesToDataframe

    Public Event ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String) Implements IDataViewGrid.ReplaceValueInData

    Public Event WorksheetChanged() Implements IDataViewGrid.WorksheetChanged

    Public Event WorksheetRemoved(worksheet As clsWorksheetAdapter) Implements IDataViewGrid.WorksheetRemoved
    Public Sub AddColumns(visiblePage As clsDataFramePage) Implements IDataViewGrid.AddColumns
        Dim workSheetColumnHeader As ColumnHeader
        grdData.CurrentWorksheet.Columns = visiblePage.lstColumns.Count
        For i = 0 To visiblePage.lstColumns.Count - 1
            workSheetColumnHeader = grdData.CurrentWorksheet.ColumnHeaders(i)
            workSheetColumnHeader.Text = visiblePage.lstColumns(i).strDisplayName
            workSheetColumnHeader.TextColor = visiblePage.lstColumns(i).clsColour
            workSheetColumnHeader.Style.BackColor = visiblePage.lstColumns(i).clsBackGroundColour
        Next
    End Sub

    Public Sub AddRowData(dataFrame As clsDataFrame) Implements IDataViewGrid.AddRowData
        Dim textColour As Color
        Dim strRowNames As String()

        If dataFrame.iDisplayedRowCount = 0 Then
            AddBlankRow(grdData.CurrentWorksheet)
            Exit Sub
        End If
        grdData.CurrentWorksheet.Rows = dataFrame.iDisplayedRowCount
        UpdateWorksheetSettings(grdData.CurrentWorksheet)

        If dataFrame.clsFilter.bApplied Then
            textColour = Color.Red
        Else
            textColour = Color.DarkBlue
        End If

        strRowNames = dataFrame.strRowNames()
        For i = 0 To grdData.CurrentWorksheet.Rows - 1
            For j = 0 To grdData.CurrentWorksheet.Columns - 1
                grdData.CurrentWorksheet(row:=i, col:=j) = dataFrame.Data(i, j)
            Next
            grdData.CurrentWorksheet.RowHeaders.Item(i).Text = strRowNames(i)
            grdData.CurrentWorksheet.RowHeaders(i).TextColor = textColour
        Next
    End Sub

    Public Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay) Implements IDataViewGrid.GetSelectedColumns
        Dim lstColumns As New List(Of clsColumnHeaderDisplay)
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Col To grdData.CurrentWorksheet.SelectionRange.Col + grdData.CurrentWorksheet.SelectionRange.Cols - 1
            lstColumns.Add(GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(i))
        Next
        Return lstColumns
    End Function

    Public Function GetWorksheetCount() As Integer Implements IDataViewGrid.GetWorksheetCount
        Return grdData.Worksheets.Count
    End Function

    Protected Overrides Sub AttachEventsToWorksheet(worksheet As Worksheet)
        AddHandler worksheet.AfterCellEdit, AddressOf Worksheet_AfterCellEdit
        AddHandler worksheet.BeforeCut, AddressOf Worksheet_BeforeCut
        AddHandler worksheet.BeforePaste, AddressOf Worksheet_BeforePaste
        AddHandler worksheet.BeforeRangeMove, AddressOf Worksheet_BeforeRangeMove
        AddHandler worksheet.BeforeCellKeyDown, AddressOf Worksheet_BeforeCellKeyDown
        AddHandler worksheet.CellDataChanged, AddressOf Worksheet_CellDataChanged
    End Sub

    Private Sub AddBlankRow(workSheet As Worksheet)
        workSheet.Rows = 1
        For i = 0 To workSheet.Columns - 1
            workSheet(0, col:=i) = ""
        Next
        workSheet.SetRowsHeight(0, 1, 0.1)
        workSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, False)
        Exit Sub
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return _clsDataBook.GetDataFrame(grdData.CurrentWorksheet.Name)
    End Function

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, grdData.WorksheetInserted
        RaiseEvent WorksheetChanged()
    End Sub

    Private Sub grdData_WorksheetRemoved(sender As Object, e As WorksheetRemovedEventArgs) Handles grdData.WorksheetRemoved
        RaiseEvent WorksheetRemoved(New clsWorksheetAdapter(e.Worksheet))
    End Sub

    Private Sub ucrDataViewReoGrid_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        grdData.SheetTabWidth = 450
    End Sub

    Private Sub UpdateWorksheetSettings(workSheet As Worksheet)
        workSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, True)
        workSheet.SetRowsHeight(0, 1, 20)
        Dim rngDataRange As New RangePosition(0, 0, workSheet.Rows, workSheet.Columns)
        workSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)
    End Sub

    Private Sub Worksheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs)
        RaiseEvent ReplaceValueInData(e.NewData.ToString(),
                           GetCurrentDataFrameFocus().clsVisiblePage.lstColumns(e.Cell.Column).strName,
                           GetCurrentDataFrameFocus().clsVisiblePage.RowNames()(e.Cell.Row))
        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
    End Sub


    Private Sub Worksheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs)
        e.IsCancelled = True 'prevents pasted data from being added directly into the data view
        'validate columns
        If e.Range.EndCol >= GetCurrentDataFrameFocus().clsVisiblePage.lstColumns.Count Then
            'this happens when Ctrl + V is pressed and the data to be pasted has more columns
            'than columns between start and end column
            MsgBox("Columns copied are more than the current data frame columns.", MsgBoxStyle.Critical, "Excess Columns")
            Exit Sub
        End If
        'TODO check see if pasted range is same as selected
        RaiseEvent PasteValuesToDataframe()
    End Sub

    Private Sub Worksheet_CellDataChanged(sender As Object, e As CellEventArgs)
        RaiseEvent CellDataChanged()
    End Sub
End Class
