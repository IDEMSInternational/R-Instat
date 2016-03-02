﻿' Instat-R
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
    Public WithEvents clsReceiver As ucrReceiverSingle
    Public WithEvents shtCurrSheet As unvell.ReoGrid.Worksheet
    Public clsRSyntax As New RSyntax
    Public bIsSelector As Boolean = False
    Public bIsMultipleSelector As Boolean = False
    Public iSelectorColumnIndex As Integer = -1
    Public strSelectorColumnName As String = "Select Level"

    Private Sub ucrFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdFactorData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
    End Sub

    Public Sub SetReceiver(clsNewReceiver As ucrReceiverSingle)
        clsReceiver = clsNewReceiver
        RefreshFactorData()
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
        If clsReceiver IsNot Nothing AndAlso clsReceiver.strDataType = "factor" AndAlso clsReceiver.GetVariableNames <> "" Then
            dfTemp = frmMain.clsRLink.GetData(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels(data_name = " & Chr(34) & clsReceiver.GetDataName() & Chr(34) & ", col_name = " & clsReceiver.GetVariableNames() & ")")
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
            iSelectorColumnIndex = -1
        End If
        grdFactorData.Visible = bShowGrid
    End Sub

    Private Sub clsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles clsReceiver.SelectionChanged
        RefreshFactorData()
    End Sub

    Private Sub InitialiseSelected()
        'sets the Default As unchecked, cells may be blank otherwise
        Dim i As Integer
        If iSelectorColumnIndex <> -1 Then
            For i = 0 To shtCurrSheet.RowCount - 1
                shtCurrSheet(i, iSelectorColumnIndex) = True
            Next
        End If
    End Sub

    Public Function GetSelectedLevels() As String
        Dim strTemp As String = ""
        Dim i As Integer
        Dim checked As Boolean
        Dim iCount As Integer = 0
        For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
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
        Next
        If iCount > 1 Then
            strTemp = strTemp & ")"
        End If
        Return strTemp
    End Function

    Private Sub shtcurrsheet_celldatachanged(sender As Object, e As CellEventArgs) Handles shtCurrSheet.CellDataChanged
        Dim i As Integer
        Dim checked As Boolean
        For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
            If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                checked = DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean)
                If checked Then
                    shtCurrSheet.RowHeaders(i).Style.BackColor = Color.Blue
                Else
                    shtCurrSheet.RowHeaders(i).Style.BackColor = Color.White
                End If
            End If
        Next
    End Sub
End Class
