' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports RDotNet
Imports unvell.ReoGrid.CellTypes
Imports unvell.ReoGrid.Events

Public Class ucrFactor
    Public Event SelectedLevelChanged()
    Public Event GridContentChanged()
    Public WithEvents clsReceiver As ucrReceiverSingle
    Public WithEvents shtCurrSheet As unvell.ReoGrid.Worksheet
    Public bIsSelector As Boolean = False
    Public bIsMultipleSelector As Boolean = False
    Public iSelectorColumnIndex As Integer = -1
    Public strSelectorColumnName As String = "Select Level"
    Private bIsEditable As Boolean = False
    Private lstEditableColumns As List(Of String)

    Private Sub ucrFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdFactorData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        RefreshFactorData()
    End Sub

    Public Sub SetReceiver(clsNewReceiver As ucrReceiverSingle)
        clsReceiver = clsNewReceiver
        RefreshFactorData()
    End Sub

    Public Sub AddEditableColumns(strColumns As String())
        If lstEditableColumns Is Nothing Then
            lstEditableColumns = New List(Of String)
        End If
        lstEditableColumns.AddRange(strColumns)
        ApplyColumnSettings()
    End Sub

    Public Sub SetAsSingleSelector()
        bIsSelector = True
        bIsMultipleSelector = False
        RefreshFactorData()
    End Sub

    Public Sub SetAsMultipleSelector()
        bIsSelector = True
        bIsMultipleSelector = True
        RefreshFactorData()
    End Sub

    Public Sub SetAsViewerOnly()
        bIsSelector = False
        bIsMultipleSelector = False
        RefreshFactorData()
    End Sub

    Public Sub SetEditableStatus(bEditable As Boolean)
        bIsEditable = bEditable
        If shtCurrSheet IsNot Nothing Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, Not bEditable)
        End If
    End Sub

    Public Sub SetSelectorColumnName(strNewColumnName As String)
        strSelectorColumnName = strNewColumnName
        If iSelectorColumnIndex <> -1 Then
            shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
        Else
            RefreshFactorData()
        End If
    End Sub

    Private Sub RefreshFactorData()
        Dim dfTemp As CharacterMatrix
        Dim bShowGrid As Boolean = False
        grdFactorData.Worksheets.Clear()
        If clsReceiver IsNot Nothing AndAlso Not clsReceiver.IsEmpty() AndAlso clsReceiver.strCurrDataType = "factor" Then
            dfTemp = frmMain.clsRLink.GetData(frmMain.clsRLink.strInstatDataObject & "$get_factor_data_frame(data_name = " & Chr(34) & clsReceiver.GetDataName() & Chr(34) & ", col_name = " & clsReceiver.GetVariableNames() & ")")
            frmMain.clsGrids.FillSheet(dfTemp, "Factor Data", grdFactorData)
            shtCurrSheet = grdFactorData.CurrentWorksheet
            bShowGrid = True
            If bIsSelector Then
                iSelectorColumnIndex = shtCurrSheet.ColumnCount
                shtCurrSheet.AppendCols(1)
                If bIsMultipleSelector Then
                    shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).DefaultCellBody = GetType(CheckBoxCell)
                    shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
                    InitialiseSelected()
                Else
                    shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
                    shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).DefaultCellBody = GetType(RadioButtonCell)
                    InitialiseSelected()
                    Dim rgpselectcolumn As New RadioButtonGroup
                    For i = 0 To shtCurrSheet.RowCount - 1
                        Dim rdotemp As New RadioButtonCell
                        rdotemp.RadioGroup = rgpselectcolumn
                        shtCurrSheet(i, iSelectorColumnIndex) = rdotemp
                    Next
                End If
            End If
        Else
            shtCurrSheet = Nothing
            iSelectorColumnIndex = -1
        End If
        grdFactorData.Visible = bShowGrid
        If shtCurrSheet IsNot Nothing Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, Not bIsEditable)
            ApplyColumnSettings()
        End If
    End Sub

    Private Sub ApplyColumnSettings()
        Dim lstColNumber As New List(Of Integer)

        If shtCurrSheet IsNot Nothing AndAlso lstEditableColumns IsNot Nothing AndAlso lstEditableColumns.Count > 0 Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, False)
            For i = 0 To shtCurrSheet.ColumnCount - 1
                If Not lstEditableColumns.Contains(shtCurrSheet.ColumnHeaders(i).Text) Then
                    For j = 0 To shtCurrSheet.RowCount - 1
                        shtCurrSheet.Cells(j, i).IsReadOnly = True
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub clsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles clsReceiver.SelectionChanged
        RefreshFactorData()
    End Sub

    Private Sub InitialiseSelected()
        'sets the default as the reference level (always first level)
        'TODO are there other initial selections needed?
        Dim i As Integer
        If iSelectorColumnIndex <> -1 Then
            For i = 0 To shtCurrSheet.RowCount - 1
                If i = 0 Then
                    shtCurrSheet(i, iSelectorColumnIndex) = True
                Else
                    shtCurrSheet(i, iSelectorColumnIndex) = False
                End If
            Next
        End If
    End Sub

    Public Function GetSelectedLevels() As String
        Dim strTemp As String = ""
        Dim i As Integer
        Dim checked As Boolean
        Dim iCount As Integer = 0
        If grdFactorData.CurrentWorksheet IsNot Nothing Then
            For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
                If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                    checked = DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean)
                    If checked Then
                        If iCount = 1 Then
                            strTemp = "c(" & strTemp & ","
                        ElseIf iCount > 1 Then
                            strTemp = strTemp & ","
                        End If
                        strTemp = strTemp & Chr(34) & shtCurrSheet(i, 0) & Chr(34)
                        iCount = iCount + 1
                    End If
                End If
            Next
            If iCount > 1 Then
                strTemp = strTemp & ")"
            End If
        End If
        Return strTemp
    End Function

    Public Function IsAllSelected() As Boolean
        For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
            If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                If Not DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean) Then
                    Return False
                End If
            Else
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub shtcurrsheet_celldatachanged(sender As Object, e As CellEventArgs) Handles shtCurrSheet.CellDataChanged
        Dim i As Integer
        Dim iSelected As Boolean
        If e.Cell.Column = iSelectorColumnIndex Then
            For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
                If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                    iSelected = DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean)
                    If iSelected Then
                        shtCurrSheet.RowHeaders(i).Style.BackColor = Color.Gold
                    Else
                        shtCurrSheet.RowHeaders(i).Style.BackColor = Color.White
                    End If
                End If
            Next
            RaiseEvent SelectedLevelChanged()
        Else
            RaiseEvent GridContentChanged()
        End If
    End Sub

    Public Function GetColumnInFactorSheet(iColumn As Integer, Optional bWithQuotes As Boolean = True)
        Dim strTemp As String = ""

        If shtCurrSheet IsNot Nothing Then
            If shtCurrSheet.RowCount = 1 Then
                If bWithQuotes Then
                    strTemp = Chr(34) & shtCurrSheet(0, iColumn).ToString & Chr(34)
                Else
                    strTemp = shtCurrSheet(0, iColumn).ToString
                End If
            ElseIf shtCurrSheet.RowCount > 1 Then
                strTemp = "c("
                For i = 0 To shtCurrSheet.RowCount - 1
                    If i > 0 Then
                        strTemp = strTemp & ","
                    End If
                    If shtCurrSheet(i, iColumn).ToString <> "" Then
                        If bWithQuotes Then
                            strTemp = strTemp & Chr(34) & shtCurrSheet(i, iColumn).ToString & Chr(34)
                        Else
                            strTemp = strTemp & shtCurrSheet(i, iColumn).ToString
                        End If
                    End If
                Next
                strTemp = strTemp & ")"
            End If
        End If

        Return strTemp
    End Function

    Public Function GetColumnInFactorSheet(strColumn As String, Optional bWithQuotes As Boolean = True)
        Dim i As Integer
        Dim iCol As Integer = -1
        Dim strTemp As String = ""

        If shtCurrSheet IsNot Nothing Then
            For i = 0 To shtCurrSheet.ColumnCount - 1
                If shtCurrSheet.ColumnHeaders(i).Text = strColumn Then
                    iCol = i
                    Exit For
                End If
            Next
            If iCol <> -1 Then strTemp = GetColumnInFactorSheet(iCol, bWithQuotes)
        End If
        Return strTemp
    End Function

    Public Sub SetSelectionAllLevels(bSelect As Boolean)
        Dim i As Integer
        If iSelectorColumnIndex <> -1 AndAlso bIsMultipleSelector = True Then
            For i = 0 To shtCurrSheet.RowCount - 1
                shtCurrSheet(i, iSelectorColumnIndex) = bSelect
            Next
        End If
    End Sub

End Class
