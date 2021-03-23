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
    ''' <summary>
    ''' stores the row indices changed in the grid 
    ''' key = grid row index, value = grid row name(which should always be a number)
    ''' </summary>
    Private dctRowsChanged As New Dictionary(Of Integer, Integer)

    'the current worksheet in the grid
    Private WithEvents grdCurrentWorkSheet As Worksheet

    ''' <summary>
    ''' returns the data changed for the passed column as an R vector string
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRowsChangedAsRVectorString(strColumnName As String, Optional strQuotes As String = "") As String
        If grdCurrentWorkSheet Is Nothing Then
            Return "c()"
        End If

        Dim strValues As String = ""
        Dim iColumnIndex As Integer = 0

        'get the column index
        For i As Integer = 0 To grdCurrentWorkSheet.ColumnCount - 1
            If grdCurrentWorkSheet.ColumnHeaders.Item(i).Text = strColumnName Then
                iColumnIndex = i
                Exit For
            End If
        Next

        'get the changed values of the column index
        For Each iRowIndex As Integer In dctRowsChanged.Keys
            If strValues = "" Then
                strValues = strQuotes & grdCurrentWorkSheet.Item(row:=iRowIndex, col:=iColumnIndex) & strQuotes
            Else
                strValues = strValues & "," & strQuotes & grdCurrentWorkSheet.Item(row:=iRowIndex, col:=iColumnIndex) & strQuotes
            End If
        Next

        Return "c(" & strValues & ")"
    End Function

    Public Function GetRowNamesChangedAsRVectorString() As String
        Return "c(" & String.Join(",", dctRowsChanged.Values.ToArray) & ")"
    End Function

    Public Function GetNumofRowsChanged() As Integer
        Return dctRowsChanged.Count
    End Function

    Public Sub Reset()
        dctRowsChanged.Clear()
        grdCurrentWorkSheet = Nothing
    End Sub

    Private Sub sdgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdDataEntry.SheetTabNewButtonVisible = False
    End Sub

    Public Sub Setup(strStationColumnName As String, strDateColumnName As String, lstElementsColumnNames As List(Of String), dataFrame As DataFrame, strDataFrameName As String)
        'clear any previous data
        grdDataEntry.Worksheets.Clear()
        dctRowsChanged.Clear()

        'create work sheet from the data frame
        grdCurrentWorkSheet = GetFilledWorkSheet(strStationColumnName, strDateColumnName, lstElementsColumnNames, dataFrame, strDataFrameName)
        'add the new worksheet to the grid
        grdDataEntry.AddWorksheet(grdCurrentWorkSheet)
    End Sub

    Private Sub grdDataEntry_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdDataEntry.CurrentWorksheetChanged, Me.Load, grdDataEntry.WorksheetInserted
        'grdCurrSheet = grdDataEntry.CurrentWorksheet
        'grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        'grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        'grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        'grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrentWorkSheet.BeforeCellEdit
        'todo. do this disabling of data entry be done when setting up the grid. Not here
        If grdCurrentWorkSheet.ColumnHeaders(e.Cell.Column).Text = "station" Then
            e.IsCancelled = True
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrentWorkSheet.AfterCellEdit
        AddChangedRow(e.Cell.Row)
    End Sub

    ''' <summary>
    ''' adds the row index changed to the list of rows changes
    ''' </summary>
    ''' <param name="iRow"></param>
    Private Sub AddChangedRow(iRow As Integer)
        'add the row index and row name to the lust of rows changed
        If Not dctRowsChanged.ContainsKey(iRow) Then
            dctRowsChanged.Add(iRow, Integer.Parse(grdCurrentWorkSheet.RowHeaders.Item(iRow).Text))
        End If
    End Sub

    Private Function GetFilledWorkSheet(strStationColumnName As String, strDateColumnName As String, lstElementsColumnNames As List(Of String), dataFrame As DataFrame, strSheetName As String) As Worksheet
        Dim grdWorkSheet As Worksheet = grdDataEntry.CreateWorksheet(strSheetName)
        Dim lstColumnHeaders As New List(Of String)

        'create the columns to be used by in worksheet; station, date and elements.station is optional
        If Not String.IsNullOrEmpty(strStationColumnName) Then
            lstColumnHeaders.Add(strStationColumnName)
        End If
        lstColumnHeaders.Add(strDateColumnName)
        lstColumnHeaders.AddRange(lstElementsColumnNames)

        'set the columns header names for the worksheet
        grdWorkSheet.Columns = lstColumnHeaders.Count
        For k = 0 To lstColumnHeaders.Count - 1
            grdWorkSheet.ColumnHeaders.Item(k).Text = lstColumnHeaders(k)
        Next

        'set the rows values and header names for the worksheet 
        grdWorkSheet.Rows = dataFrame.RowCount
        For i As Integer = 0 To dataFrame.RowCount - 1
            For j = 0 To grdWorkSheet.Columns - 1
                'todo. in future convert the R NA's to VB.NET "NA" string. 
                grdWorkSheet.Item(row:=i, col:=j) = dataFrame.Item(i, j)
            Next
            'set the row header names
            grdWorkSheet.RowHeaders.Item(i).Text = dataFrame.RowNames(i)
        Next

        grdWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdWorkSheet.Rows, grdWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)
        grdWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        Return grdWorkSheet
    End Function

End Class