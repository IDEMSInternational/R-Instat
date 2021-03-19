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
Public Class dlgClimaticDataEntry
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iBasicWidth As Integer
    Private Sub dlgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            iBasicWidth = Me.Width
            bFirstLoad = False
        End If
        If bReset Then
            'SetDefaults()
        End If
        'SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 359

        ucrSelectorClimaticDataEntry.SetParameter(New RParameter("data_name", 0))
        ucrSelectorClimaticDataEntry.SetParameterIsString()

        ucrReceiverStation.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameter(New RParameter("station_col", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrInputFactorLevels.SetParameter(New RParameter("", 2))
        ucrInputFactorLevels.SetFactorReceiver(ucrReceiverStation)
        'ucrInputFactorLevels.AddQuotesIfUnrecognised = False
        'ucrInputFactorLevels.strQuotes = "`"

        ucrReceiverDate.SetParameter(New RParameter("date_col", 3))
        ucrReceiverDate.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.strSelectorHeading = "Date"

        ucrReceiverElements.SetParameter(New RParameter("element_cols", 4))
        ucrReceiverElements.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.strSelectorHeading = "Numerics"
        ucrReceiverElements.SetIncludedDataTypes({"numeric"})
        ucrReceiverElements.SetClimaticType("element")
        ucrReceiverElements.bAutoFill = True

        ucrPnlOptions.AddRadioButton(rdoDaily)
        ucrPnlOptions.AddRadioButton(rdoMonthly)

    End Sub

    Private Sub SetDefaults()

    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub
    Private Sub TestOkEnabled()
        If (Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputFactorLevels.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdEnterData_Click(sender As Object, e As EventArgs) Handles cmdEnterData.Click
        sdgClimaticDataEntry.ShowDialog()
    End Sub

    Public Function GetFilledDataTable(dataFrame As DataFrame) As DataTable
        Dim dataTable As New DataTable
        Dim dataRow As DataRow
        Dim bAddRow As Boolean
        Dim strStationColumnName As String = ucrInputFactorLevels.GetValue()
        Dim strDateColumnName As String = ucrInputFactorLevels.GetValue()
        Dim lstElementsColumnNames As List(Of String) = ucrReceiverElements.GetVariableNamesAsList
        Dim dateFrom As Date = ucrDateTimePickerFrom.DateValue

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
        Dim grdWorkSheet As Worksheet = New ReoGridControl().CreateWorksheet("dateentry")

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