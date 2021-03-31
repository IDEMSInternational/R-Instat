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
Imports instat.Translations
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class sdgClimaticDataEntry
    ''' <summary>
    ''' stores the row indices changed in the grid 
    ''' key = grid row index, value = grid row name (which should always be a number)
    ''' </summary>
    Private dctRowsChanged As New Dictionary(Of Integer, Integer)

    'the current worksheet in the grid
    Private WithEvents grdCurrentWorkSheet As Worksheet

    Private lstNonEditableColumns As New List(Of String)

    Private strDataFrameName As String
    Private clsSaveDataEntry As RFunction
    Private clsEditDataFrame As RFunction
    Private dfEditData As DataFrame
    Private strDateName As String
    Private lstElementsNames As List(Of String)
    Private lstViewVariablesNames As List(Of String)
    Private strStationColumnName As String
    Private strDefaultValue As String
    Private bNoDecimal As Boolean
    Private bAllowTrace As Boolean


    ''' <summary>
    ''' returns the data changed for the passed column as an R vector string
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRowsChangedAsRVectorString(strColumnName As String, Optional strQuotes As String = "") As String
        Dim strValues As String = ""
        Dim iColumnIndex As Integer = 0

        If grdCurrentWorkSheet Is Nothing Then
            Return "c()"
        End If

        For i As Integer = 0 To grdCurrentWorkSheet.ColumnCount - 1
            If grdCurrentWorkSheet.ColumnHeaders.Item(i).Text = strColumnName Then
                iColumnIndex = i
                Exit For
            End If
        Next

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

    Public Function NRowsChanged() As Integer
        Return dctRowsChanged.Count
    End Function

    Public Sub Reset()
        dctRowsChanged.Clear()
        grdCurrentWorkSheet = Nothing
    End Sub

    Public Sub Setup(dfEditData As DataFrame, strDataFrameName As String, clsSaveDataEntry As RFunction, clsEditDataFrame As RFunction, strDateName As String, lstElementsNames As List(Of String), Optional lstViewVariablesNames As List(Of String) = Nothing, Optional strStationColumnName As String = "", Optional bDefaultValue As Boolean = False, Optional strDefaultValue As String = "", Optional bNoDecimal As Boolean = False, Optional bAllowTrace As Boolean = False)
        Dim lstColumnHeaders As String()

        grdDataEntry.Worksheets.Clear()
        dctRowsChanged.Clear()
        lstNonEditableColumns.Clear()

        Me.strDataFrameName = strDataFrameName
        Me.clsSaveDataEntry = clsSaveDataEntry
        Me.clsEditDataFrame = clsEditDataFrame
        Me.dfEditData = dfEditData
        Me.strDateName = strDateName
        Me.lstElementsNames = lstElementsNames
        Me.lstViewVariablesNames = lstViewVariablesNames
        Me.strStationColumnName = strStationColumnName
        Me.strDefaultValue = strDefaultValue
        Me.bNoDecimal = bNoDecimal
        Me.bAllowTrace = bAllowTrace

        If Not strStationColumnName = "" Then
            lstNonEditableColumns.Add(strStationColumnName)
        End If
        lstNonEditableColumns.Add(strDateName)
        If lstViewVariablesNames IsNot Nothing Then
            For Each strVar In lstViewVariablesNames
                ' Note this is the format used in get_data_entry_data R method
                lstNonEditableColumns.Add(strVar & " (view)")
            Next
        End If

        grdCurrentWorkSheet = grdDataEntry.CreateWorksheet(strDataFrameName)
        lstColumnHeaders = dfEditData.ColumnNames

        grdCurrentWorkSheet.Columns = lstColumnHeaders.Count
        For k = 0 To lstColumnHeaders.Count - 1
            grdCurrentWorkSheet.ColumnHeaders.Item(k).Text = lstColumnHeaders(k)
            If Not lstElementsNames.Contains(lstColumnHeaders(k)) Then
                grdCurrentWorkSheet.ColumnHeaders(k).TextColor = Graphics.SolidColor.Black
            End If
        Next

        grdCurrentWorkSheet.Rows = dfEditData.RowCount
        For i As Integer = 0 To dfEditData.RowCount - 1
            For j = 0 To grdCurrentWorkSheet.Columns - 1
                'TODO Convert the R NAs to VB.NET "NA" string.
                grdCurrentWorkSheet.Item(row:=i, col:=j) = dfEditData.Item(i, j)
                If grdCurrentWorkSheet.Item(row:=i, col:=j).ToString() = "NaN" Then
                    grdCurrentWorkSheet.Item(row:=i, col:=j) = "NA"
                End If
                If Not lstNonEditableColumns.Contains(lstColumnHeaders(j)) AndAlso bDefaultValue AndAlso grdCurrentWorkSheet.Item(row:=i, col:=j).ToString() = "NA" Then
                    grdCurrentWorkSheet.Item(row:=i, col:=j) = strDefaultValue
                End If
                If lstNonEditableColumns.Contains(lstColumnHeaders(j)) Then
                    grdCurrentWorkSheet.GetCell(i, j).IsReadOnly = True
                End If
            Next
            grdCurrentWorkSheet.RowHeaders.Item(i).Text = dfEditData.RowNames(i)
        Next
        grdCurrentWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdCurrentWorkSheet.Rows, grdCurrentWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)
        grdCurrentWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)

        grdDataEntry.AddWorksheet(grdCurrentWorkSheet)
        grdDataEntry.SheetTabNewButtonVisible = False

        ttCmdReset.SetToolTip(cmdReset, "Clears all data entry.")
        ttCmdTransformButton.SetToolTip(cmdTransform, "When implemented, this is an option to show the transformed data.")
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrentWorkSheet.BeforeCellEdit
        ''todo. do this disabling of data entry be done when setting up the grid. Not here
        'If lstNonEditableColumns.Contains(grdCurrentWorkSheet.ColumnHeaders(e.Cell.Column).Text) Then
        '    e.IsCancelled = True
        'End If
        'If InStr(grdCurrentWorkSheet.ColumnHeaders(e.Cell.Column).Text, "(view)") Then
        '    e.IsCancelled = True
        'End If
    End Sub

    Private Sub grdCurrSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles grdCurrentWorkSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is disabled." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    Private Sub grdCurrentWorkSheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrentWorkSheet.BeforePaste
        MsgBox("Pasting not yet implemented.", MsgBoxStyle.Information, "Pasting not implemented.")
        e.IsCancelled = True
    End Sub
    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrentWorkSheet.AfterCellEdit
        Dim strtTraceAllowed As String() = {"t", "T"}
        If (Not IsNumeric(e.NewData) AndAlso Not e.NewData.ToString() = "NA") OrElse ((InStr(e.NewData, "t") OrElse InStr(e.NewData, "T")) AndAlso Not bAllowTrace) Then
            MsgBox("Value is not numeric or NA.", MsgBoxStyle.Information, "Not numeric.")
            e.EndReason = EndEditReason.Cancel
        ElseIf InStr(e.NewData, ".") AndAlso bNoDecimal Then
            MsgBox("Value should not be decimal otherwise uncheck No Decimal.", MsgBoxStyle.Information, "Not decimal Allowed.")
            e.EndReason = EndEditReason.Cancel
        Else
            AddChangedRow(e.Cell.Row)
            grdCurrentWorkSheet.GetCell(e.Cell.Row, e.Cell.Column).Style.BackColor = Color.Yellow
        End If
        'If InStr(e.NewData, ".") AndAlso bNoDecimal Then
        '    MsgBox("Value should not be decimal otherwise uncheck No Decimal.", MsgBoxStyle.Information, "Not decimal Allowed.")
        '    e.EndReason = EndEditReason.Cancel
        'End If
    End Sub

    ''' <summary>
    ''' adds the row index changed to the list of rows changes
    ''' </summary>
    ''' <param name="iRow"> row index</param>
    Private Sub AddChangedRow(iRow As Integer)
        'add the row index and row name to the last of rows changed
        If Not dctRowsChanged.ContainsKey(iRow) Then
            dctRowsChanged.Add(iRow, Integer.Parse(grdCurrentWorkSheet.RowHeaders.Item(iRow).Text))
        End If
    End Sub

    Private Sub cmdRefress_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        If MsgBox("All data entry will be lost. Are you sure you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clsSaveDataEntry.RemoveParameterByName("rows_changed")
            Setup(dfEditData, strDataFrameName, clsSaveDataEntry, clsEditDataFrame, strDateName, lstElementsNames, lstViewVariablesNames, strStationColumnName, bDefaultValue:=False, strDefaultValue, bNoDecimal, bAllowTrace)
        End If
    End Sub

    Private Sub sdgClimaticDataEntry_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim i As Integer

        If NRowsChanged() > 0 Then
            clsEditDataFrame.AddParameter(strDateName, "as.Date(" & GetRowsChangedAsRVectorString(strDateName, Chr(34)) & ")", iPosition:=1)
            i = 2
            For Each strElementName As String In lstElementsNames
                clsEditDataFrame.AddParameter(strElementName, GetRowsChangedAsRVectorString(strElementName), iPosition:=i)
                i = i + 1
            Next
            clsSaveDataEntry.AddParameter("rows_changed", GetRowNamesChangedAsRVectorString(), iPosition:=2)
        Else
            clsSaveDataEntry.RemoveParameterByName("rows_changed")
        End If
    End Sub
End Class