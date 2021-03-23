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

Imports instat.Translations
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events
Public Class sdgClimaticDataEntry

    Dim strStationColumnName As String
    Dim strDateColumnName As String
    Dim lstElementsColumnNames As List(Of String)
    Dim strStationSelected As String
    Dim startDateSelected As Date

    'stores the values changed in the grid
    Dim dataChanged As DataTable

    'stores the row indices changed in the grid
    'key = grid row number, value = dataChanged row number
    Dim rowsChanged As New Dictionary(Of Integer, Integer)

    'the current worksheet in the grid
    Dim WithEvents grdCurrentWorkSheet As unvell.ReoGrid.Worksheet

    ''' <summary>
    ''' returns the data changed as a string, in the format of a "csv"
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDataChangedAsString() As String
        If dataChanged Is Nothing Then
            Return ""
        End If

        Dim strValues As String = ""
        For Each row As DataRow In dataChanged.Rows
            If strValues = "" Then
                strValues = String.Join(",", row.ItemArray)
            Else
                strValues = strValues & Environment.NewLine & String.Join(",", row.ItemArray)
            End If
        Next
        Return strValues
    End Function

    Public Function GetRowsChangedAsRVectorString() As String
        Return "c(" & String.Join(",", rowsChanged.Keys.ToArray) & ")"
    End Function

    Public Function GetNumofRowsChanged() As Integer
        Return rowsChanged.Count
    End Function

    Private Sub sdgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdDataEntry.SheetTabNewButtonVisible = False
    End Sub

    Public Sub Setup(strStationColumnName As String, strDateColumnName As String, lstElementsColumnNames As List(Of String), strStationSelected As String, startDateSelected As Date, dataFrame As DataFrame, strSheetName As String)
        Me.strStationColumnName = strStationColumnName
        Me.strDateColumnName = strDateColumnName
        Me.lstElementsColumnNames = lstElementsColumnNames
        Me.strStationSelected = strStationSelected
        Me.startDateSelected = startDateSelected

        'clear any previous data
        grdDataEntry.Worksheets.Clear()
        rowsChanged.Clear()

        Dim dataTable As DataTable

        'create a data table from the passed data frame then create a worksheet from the data table
        dataTable = GetFilledDataTable(strStationColumnName, strDateColumnName, lstElementsColumnNames, strStationSelected, startDateSelected, dataFrame)
        grdCurrentWorkSheet = GetFilledWorkSheet(dataTable, strSheetName)
        'add the new worksheet to the grid
        grdDataEntry.AddWorksheet(grdCurrentWorkSheet)
        'create a new data changed table from the the structure of the created data table
        dataChanged = dataTable.Clone
    End Sub

    Private Sub grdDataEntry_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdDataEntry.CurrentWorksheetChanged, Me.Load, grdDataEntry.WorksheetInserted
        'grdCurrSheet = grdDataEntry.CurrentWorksheet
        'grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        'grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        'grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        'grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrentWorkSheet.BeforeCellEdit
        'todo. can this disabling of data entry be done elsewhere
        If grdCurrentWorkSheet.ColumnHeaders(e.Cell.Column).Text = "station" Then
            e.IsCancelled = True
        Else
            ' strPreviousCellText = e.Cell.Data.ToString()
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrentWorkSheet.AfterCellEdit
        AddChangedData(e.Cell.Column, e.Cell.Row, e.NewData.ToString())
    End Sub

    ''' <summary>
    ''' adds the changed data to the data structures that hold changes made on the grid
    ''' </summary>
    ''' <param name="iCol">grid column</param>
    ''' <param name="iRow">grid row</param>
    ''' <param name="strNewValue">newly typed value</param>
    Private Sub AddChangedData(iCol As Integer, iRow As Integer, strNewValue As String)
        'if the change was already added then just update it, else add the change as a new row(change)
        If rowsChanged.ContainsKey(iRow) Then
            dataChanged.Rows.Item(rowsChanged.Item(iRow)).Item(iCol) = strNewValue
        Else
            Dim dataTableRow As DataRow = dataChanged.NewRow()
            dataTableRow.Item(iCol) = strNewValue
            'add the new change
            dataChanged.Rows.Add(dataTableRow)
            'also record the row indices
            rowsChanged.Add(iRow, dataChanged.Rows.Count - 1)
        End If
    End Sub

    ''' <summary>
    ''' creates and fills a datable from the passed parameters
    ''' e.g of columns; station,date,...elements..
    ''' </summary>
    ''' <param name="strStationColumnName"></param>
    ''' <param name="strDateColumnName"></param>
    ''' <param name="lstElementsColumnNames"></param>
    ''' <param name="strStationSelected"></param>
    ''' <param name="startDateSelected"></param>
    ''' <param name="dataFrame"></param>
    ''' <returns></returns>
    Private Function GetFilledDataTable(strStationColumnName As String, strDateColumnName As String, lstElementsColumnNames As List(Of String), strStationSelected As String, startDateSelected As Date, dataFrame As DataFrame) As DataTable
        Dim dataTable As New DataTable
        Dim dataTableRow As DataRow
        Dim dataFrameCellValue As Object

        'create the columns to the data table; station, date and elements
        'station is optional
        If Not String.IsNullOrEmpty(strStationColumnName) Then
            dataTable.Columns.Add(strStationColumnName)
        End If

        dataTable.Columns.Add(strDateColumnName)
        For Each strElement As String In lstElementsColumnNames
            dataTable.Columns.Add(strElement)
        Next

        For i As Integer = 0 To dataFrame.RowCount - 1
            'create a new data table row
            dataTableRow = dataTable.NewRow()

            'fill the row with required values
            'the data frame column names should be the same as the data table column names in content
            For Each dataTableColumn As DataColumn In dataTable.Columns
                dataFrameCellValue = dataFrame.Item(i, dataTableColumn.ColumnName)
                'todo. in future convert the R NA's to VB.NET "NA" string. 
                dataTableRow.Item(dataTableColumn.ColumnName) = dataFrameCellValue
            Next
            'add the row to the datatable
            dataTable.Rows.Add(dataTableRow)
        Next
        Return dataTable
    End Function

    ''' <summary>
    ''' creates a worksheet from the passed data table
    ''' </summary>
    ''' <param name="dataTable"></param>
    ''' <param name="strSheetName"></param>
    ''' <returns></returns>
    Public Function GetFilledWorkSheet(dataTable As DataTable, strSheetName As String) As Worksheet
        Dim grdWorkSheet As Worksheet = grdDataEntry.CreateWorksheet(strSheetName)

        'create the columns and set the header names in the worksheet
        grdWorkSheet.Columns = dataTable.Columns.Count
        For k = 0 To dataTable.Columns.Count - 1
            grdWorkSheet.ColumnHeaders.Item(k).Text = dataTable.Columns.Item(k).ColumnName
        Next

        'create rows and values for the worksheet 
        grdWorkSheet.Rows = dataTable.Rows.Count
        grdWorkSheet.SetRangeData(New RangePosition(0, 0, dataTable.Rows.Count, dataTable.Columns.Count), dataTable)

        'todo. these 3 settings not important now. Left here to be done later
        'grdWorkSheet.SetSettings(WorksheetSettings.Edit_AllowAdjustRowHeight, True)
        'grdWorkSheet.SetRowsHeight(0, 1, 20)
        'grdWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdWorkSheet.Rows, grdWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)

        'todo. make the station column be uneditable, though it is an optional column 
        Return grdWorkSheet
    End Function

End Class