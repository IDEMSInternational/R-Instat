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
Public Class sdgClimaticDataEntry

    Dim strStationColumnName As String
    Dim strDateColumnName As String
    Dim lstElementsColumnNames As List(Of String)
    Dim strStationSelected As String
    Dim startDateSelected As Date
    Dim dataTable As DataTable

    Private Sub sdgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Setup(strStationColumnName As String, strDateColumnName As String, lstElementsColumnNames As List(Of String), strStationSelected As String, startDateSelected As Date, dataFrameSelected As DataFrame)
        Me.strStationColumnName = strStationColumnName
        Me.strDateColumnName = strDateColumnName
        Me.lstElementsColumnNames = lstElementsColumnNames
        Me.strStationSelected = strStationSelected
        Me.startDateSelected = startDateSelected
        grdDataEntry.Worksheets.Clear()
        Me.dataTable = GetFilledDataTable(strStationColumnName, strDateColumnName, lstElementsColumnNames, strStationSelected, startDateSelected, dataFrameSelected)

        Dim currentWorkSheet As Worksheet = GetFilledWorkSheet(dataTable)
        grdDataEntry.AddWorksheet(currentWorkSheet)

        grdDataEntry.CurrentWorksheet = currentWorkSheet
    End Sub

    Private Function GetFilledDataTable(strStationColumnName As String, strDateColumnName As String, lstElementsColumnNames As List(Of String), strStationSelected As String, startDateSelected As Date, dataFrameSelected As DataFrame) As DataTable
        Dim dataTable As New DataTable
        Dim dataTableRow As DataRow
        Dim dataFrameCellValue As Object
        Dim bAddRow As Boolean

        'create the columns to the data table; station, date and elements
        dataTable.Columns.Add(strStationColumnName)
        dataTable.Columns.Add(strDateColumnName)
        For Each strElement As String In lstElementsColumnNames
            dataTable.Columns.Add(strElement)
        Next

        For i As Integer = 0 To dataFrameSelected.RowCount - 1
            bAddRow = True
            'create a new data table row
            dataTableRow = dataTable.NewRow()

            'fill the row with required values
            'the data frame column names should be the same as the data table column names in content
            For Each dataTableColumn As DataColumn In dataTable.Columns
                dataFrameCellValue = dataFrameSelected.Item(i, dataTableColumn.ColumnName)
                'Only add rows of the station selected and from the starting date
                'If strColumnName = strStationColumnName AndAlso dataFrameCellValue.ToString <> strStationSelected Then
                '    'bAddRow = False
                '    'Exit For
                'ElseIf strColumnName = strDateColumnName Then
                '    'todo. validate the date and compare, if > starting date then bAddRow = False
                '    'bAddRow = False
                '    'Exit For
                'End If

                dataTableRow.Item(dataTableColumn.ColumnName) = dataFrameCellValue
            Next

            If bAddRow Then
                'add the row to the datatable
                dataTable.Rows.Add(dataTableRow)
            End If

        Next
        Return dataTable
    End Function

    Public Function GetFilledWorkSheet(dataTable As DataTable) As Worksheet
        Dim grdWorkSheet As Worksheet = grdDataEntry.CreateWorksheet("dataentry")

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

        'todo. make the station column be uneditable 
        Return grdWorkSheet
    End Function
End Class