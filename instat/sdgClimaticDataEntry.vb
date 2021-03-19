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
    Private Sub sdgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdDataEntry.CurrentWorksheet = GetFilledWorkSheet(GetFilledDataTable(dlgClimaticDataEntry.dfTemp))
    End Sub
    Public Function GetFilledDataTable(dataFrame As DataFrame) As DataTable
        Dim dataTable As New DataTable
        Dim dataRow As DataRow
        Dim bAddRow As Boolean
        Dim strStationColumnName As String = dlgClimaticDataEntry.ucrReceiverStation.GetVariableNames
        ' Dim strDateColumnName As String = dlgClimaticDataEntry.ucrInputFactorLevels.GetValue()
        Dim strDateColumnName As String = dlgClimaticDataEntry.ucrReceiverDate.GetVariableNames
        Dim lstElementsColumnNames As List(Of String) = dlgClimaticDataEntry.ucrReceiverElements.GetVariableNamesAsList
        Dim dateFrom As Date = dlgClimaticDataEntry.ucrDateTimePickerFrom.DateValue

        'create the columns to the data table; station, date and elements
        dataTable.Columns.Add(strStationColumnName)
        dataTable.Columns.Add(strDateColumnName)
        For Each strElement As String In lstElementsColumnNames
            dataTable.Columns.Add(strElement)
        Next

        For i As Integer = 0 To dataFrame.RowCount - 1
            bAddRow = True
            'create a new data table row
            dataRow = dataTable.NewRow()

            'fill the row with required values
            'the data frame column names should be the same as the data table column names in content
            For Each strDataFrameColumnName As String In dataFrame.ColumnNames
                If strDataFrameColumnName = strDateColumnName Then
                    'todo. validate the date and compare, if > starting date then bAddRow = False
                End If
                dataRow.Item(strDataFrameColumnName) = dataFrame.Item(i, strDataFrameColumnName)
            Next

            If bAddRow Then
                'add the row to the datatable
                dataTable.Rows.Add(dataRow)
            End If

        Next
        Return dataTable
    End Function

    Public Function GetFilledWorkSheet(dataTable As DataTable) As Worksheet
        Dim grdWorkSheet As Worksheet = New ReoGridControl().CreateWorksheet("dataentry")

        'create the columns and set the header names in the worksheet
        grdWorkSheet.Columns = dataTable.Columns.Count
        For k = 0 To dataTable.Columns.Count - 1
            grdWorkSheet.ColumnHeaders.Item(k).Text = dataTable.Columns.Item(k).ColumnName
        Next

        'create rows and values for the worksheet 
        grdWorkSheet.SetRangeData(New RangePosition(0, 0, dataTable.Rows.Count, dataTable.Columns.Count), dataTable)

        'todo. these 3 settings not important now. Left here to be done later
        'grdWorkSheet.SetSettings(WorksheetSettings.Edit_AllowAdjustRowHeight, True)
        'grdWorkSheet.SetRowsHeight(0, 1, 20)
        'grdWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdWorkSheet.Rows, grdWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)

        Return grdWorkSheet
    End Function
End Class