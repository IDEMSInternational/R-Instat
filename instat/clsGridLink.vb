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

Imports RDotNet
Imports unvell.ReoGrid

Public Class clsGridLink
    Public ucrDataViewer As ucrDataView
    Public grdData As ReoGridControl
    Public grdMetadata As ReoGridControl
    Public grdVariablesMetadata As ReoGridControl
    Public bGrdDataExists As Boolean
    Public bGrdMetadataExists As Boolean
    Public bGrdVariablesMetadataExists As Boolean
    Public bGrdDataChanged As Boolean
    Public bGrdMetadataChanged As Boolean
    Public bGrdVariablesMetadataChanged As Boolean
    Public iMaxRows As Integer
    Public iMaxCols As Integer
    Private strMetadata As String
    Public fntText As Font = New Font("Microsoft Sans Serif", 10, FontStyle.Regular)
    Public clrText As Color = Color.Black

    Public Sub New()
        grdData = New ReoGridControl
        grdMetadata = New ReoGridControl
        grdVariablesMetadata = New ReoGridControl
        bGrdDataExists = False
        bGrdMetadataChanged = False
        bGrdVariablesMetadataExists = False
        bGrdDataChanged = False
        bGrdMetadataChanged = False
        bGrdVariablesMetadataChanged = False
        iMaxRows = 1000
        iMaxCols = 30
    End Sub

    Public Sub UpdateGrids()
        'TODO remove this whole class if possible
        frmMain.ucrDataViewer.RefreshGridData()
        frmMain.ucrColumnMeta.RefreshGridData()
        frmMain.ucrDataFrameMeta.RefreshGridData()
    End Sub

    Public Sub SetMetadata(tmpStrMetadata As String)
        strMetadata = tmpStrMetadata
    End Sub

    Private Sub SetDataViewColumnColor(grdSheet As Worksheet, iColumn As Integer, bApplyColour As Boolean, Optional iColour As Integer = -1)
        Dim selRangeDataView As New RangePosition

        'grdSheet.SelectColumns(iColumn, 1)
        'selRangeDataView = grdSheet.SelectionRange
        'If bApplyColour AndAlso iColour >= 0 AndAlso iColour < frmMain.clsInstatOptions.lstColourPalette.Count Then
        '    grdSheet.SetRangeStyles(selRangeDataView, New WorksheetRangeStyle() With {.Flag = PlainStyleFlag.BackColor, .BackColor = frmMain.clsInstatOptions.lstColourPalette(iColour - 1)})
        'Else
        '    grdSheet.RemoveRangeStyles(selRangeDataView, PlainStyleFlag.All)
        'End If

        If iColour >= 0 AndAlso iColour < frmMain.clsInstatOptions.lstColourPalette.Count Then
            grdSheet.ColumnHeaders(iColumn).Style.BackColor = frmMain.clsInstatOptions.lstColourPalette(iColour - 1)
        ElseIf iColour = -1 Then
            grdSheet.ColumnHeaders(iColumn).Style.BackColor = Nothing
        End If
    End Sub

    Public Sub SetMetadata(grdTemp As ReoGridControl)
        grdMetadata = grdTemp
        bGrdMetadataExists = True
        bGrdMetadataChanged = True
        UpdateGrids()
    End Sub

    Public Sub SetVariablesMetadata(grdTemp As ReoGridControl)
        grdVariablesMetadata = grdTemp
        bGrdVariablesMetadataExists = True
        bGrdVariablesMetadataChanged = True
        UpdateGrids()
    End Sub

    Public Sub FillSheet(dfTemp As DataFrame, strName As String, grdCurr As ReoGridControl, Optional bInstatObjectDataFrame As Boolean = False, Optional bIncludeDataTypes As Boolean = False, Optional iNewPosition As Integer = -1, Optional bFilterApplied As Boolean = False, Optional bCheckFreezeColumns As Boolean = False, Optional iRowMax As Integer = -1, Optional iColMax As Integer = -1)
        Dim bFoundWorksheet As Boolean = False
        Dim tempWorkSheet As Worksheet
        Dim fillWorkSheet As Worksheet
        Dim rngDataRange As RangePosition
        Dim vecColumnDataTypes As CharacterVector
        Dim clsGetVarMetaFunc As New RFunction
        Dim clsIsVarMetaFunc As New RFunction
        Dim clsHasColoursFunc As New RFunction
        Dim clsGetColumnNames As New RFunction
        Dim iCurrPosition As Integer
        Dim iCount As Integer
        Dim strRowNames As String()
        Dim strColumnNames As String()
        Dim bIsFrozen As Boolean
        Dim vecColumnColours As NumericVector
        Dim bApplyColumnColours As Boolean
        Dim i, j, k As Integer
        Dim strCurrColNames As String = ""
        Dim lstColumnNames As New List(Of String)

        iCount = 0
        For Each tempWorkSheet In grdCurr.Worksheets
            If tempWorkSheet.Name = strName Then
                bFoundWorksheet = True
                iCurrPosition = iCount
                Exit For
            End If
            iCount = iCount + 1
        Next

        If bFoundWorksheet Then
            fillWorkSheet = grdCurr.GetWorksheetByName(strName)
        Else
            fillWorkSheet = grdCurr.CreateWorksheet(strName)
            grdCurr.AddWorksheet(fillWorkSheet)
            iCurrPosition = grdCurr.Worksheets.Count - 1
        End If

        If iNewPosition <> -1 AndAlso iNewPosition <> iCurrPosition AndAlso iNewPosition < grdCurr.Worksheets.Count Then
            grdCurr.MoveWorksheet(fillWorkSheet, iNewPosition)
        End If
        'replaced this to fill columns with the iMaxCols
        If iColMax <> -1 Then
            fillWorkSheet.Columns = Math.Min(iColMax, dfTemp.ColumnCount)
        Else
            fillWorkSheet.Columns = dfTemp.ColumnCount
        End If
        strColumnNames = dfTemp.ColumnNames
        If dfTemp.RowCount = 0 Then
            fillWorkSheet.Rows = 1
            For j = 0 To fillWorkSheet.Columns - 1
                fillWorkSheet(row:=0, col:=j) = ""
            Next
            fillWorkSheet.SetRowsHeight(0, 1, 0.1)
            fillWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, False)
        Else
            fillWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AllowAdjustRowHeight, True)
            If iRowMax <> -1 Then
                fillWorkSheet.Rows = Math.Min(iRowMax, dfTemp.RowCount)
            Else
                fillWorkSheet.Rows = dfTemp.RowCount
            End If
            fillWorkSheet.SetRowsHeight(0, 1, 20)
            rngDataRange = New RangePosition(0, 0, fillWorkSheet.Rows, fillWorkSheet.Columns)
            fillWorkSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)
            For i = 0 To fillWorkSheet.Rows - 1
                For j = 0 To fillWorkSheet.Columns - 1
                    fillWorkSheet(row:=i, col:=j) = dfTemp(i, j)
                Next
            Next
            strRowNames = dfTemp.RowNames
            For i = 0 To fillWorkSheet.Rows - 1
                fillWorkSheet.RowHeaders.Item(i).Text = strRowNames(i)
            Next

            If bFilterApplied Then
                For i = 0 To fillWorkSheet.Rows - 1
                    fillWorkSheet.RowHeaders(i).TextColor = Color.Red
                Next
            Else
                For i = 0 To fillWorkSheet.Rows - 1
                    fillWorkSheet.RowHeaders(i).TextColor = Color.DarkBlue
                Next
            End If
            FormatDataView(fillWorkSheet)
        End If
        Try
            lstColumnNames = strColumnNames.ToList
            strCurrColNames = frmMain.clsRLink.GetListAsRString(lstColumnNames)

            If bInstatObjectDataFrame AndAlso frmMain.clsRLink.bInstatObjectExists AndAlso bIncludeDataTypes Then
                If bInstatObjectDataFrame AndAlso frmMain.clsRLink.bInstatObjectExists Then
                    clsGetVarMetaFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_data_types")
                    clsGetVarMetaFunc.AddParameter("data_name", Chr(34) & strName & Chr(34))
                    clsGetVarMetaFunc.AddParameter("columns", strCurrColNames)
                Else
                    clsGetVarMetaFunc.SetRCommand("sapply")
                    clsGetVarMetaFunc.AddParameter("X", strName)
                    clsGetVarMetaFunc.AddParameter("FUN", Chr(34) & "class" & Chr(34))
                End If

                vecColumnDataTypes = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVarMetaFunc.ToScript()).AsCharacter

                For k = 0 To dfTemp.ColumnCount - 1
                    Dim strType As String
                    Dim clsHeader As ColumnHeader

                    strType = vecColumnDataTypes(k)
                    clsHeader = fillWorkSheet.ColumnHeaders(k)
                    clsHeader.Text = lstColumnNames(k)
                    clsHeader.TextColor = Graphics.SolidColor.DarkBlue

                    If strType.Contains("factor") AndAlso strType.Contains("ordered") Then
                        clsHeader.Text &= " (O.F)"
                        clsHeader.TextColor = Graphics.SolidColor.Blue
                    ElseIf strType.Contains("factor") Then
                        clsHeader.Text &= " (F)"
                        clsHeader.TextColor = Graphics.SolidColor.Blue
                    ElseIf strType.Contains("character") Then
                        clsHeader.Text &= " (C)"
                    ElseIf strType.Contains("Date") OrElse strType.Contains("POSIXct") OrElse strType.Contains("POSIXt") OrElse strType.Contains("hms") OrElse strType.Contains("difftime") OrElse strType.Contains("Duration") OrElse strType.Contains("Period") OrElse strType.Contains("Interval") Then
                        clsHeader.Text &= " (D)"
                    ElseIf strType.Contains("logical") Then
                        clsHeader.Text &= " (L)"
                        ' Structured columns e.g. "circular" are coded with "(S)"
                    ElseIf strType.Contains("circular") Then
                        clsHeader.Text &= " (S)"
                        ' Types of data for specific Application areas e.g. survival are coded with "(A)"
                        ' No examples implemented yet.
                        'ElseIf strType.Contains() Then
                        '    fillWorkSheet.ColumnHeaders(k).Text = strCurrHeader & " (A)"
                        '    fillWorkSheet.ColumnHeaders(k).TextColor = Graphics.SolidColor.DarkBlue
                    End If
                Next
            Else
                'worksheet columns could be less than than the data frame columns, 
                'so use worksheet ColumnCount
                For k = 0 To fillWorkSheet.ColumnCount - 1
                    fillWorkSheet.ColumnHeaders(k).Text = lstColumnNames(k)
                Next
            End If
            grdCurr.CurrentWorksheet = fillWorkSheet
            If bInstatObjectDataFrame AndAlso frmMain.clsRLink.bInstatObjectExists Then
                clsHasColoursFunc.ClearParameters()
                clsHasColoursFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$has_colours")
                clsHasColoursFunc.AddParameter("data_name", Chr(34) & strName & Chr(34))
                clsHasColoursFunc.AddParameter("columns", strCurrColNames)
                bApplyColumnColours = frmMain.clsRLink.RunInternalScriptGetValue(clsHasColoursFunc.ToScript()).AsLogical(0)
                If bApplyColumnColours Then
                    clsGetVarMetaFunc.ClearParameters()
                    clsGetVarMetaFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
                    clsGetVarMetaFunc.AddParameter("data_name", Chr(34) & strName & Chr(34))
                    clsGetVarMetaFunc.AddParameter("property", "colour_label")
                    clsGetVarMetaFunc.AddParameter("column", strCurrColNames)
                    vecColumnColours = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVarMetaFunc.ToScript()).AsNumeric
                    For k = 0 To dfTemp.ColumnCount - 1
                        SetDataViewColumnColor(grdCurr.CurrentWorksheet, k, bApplyColumnColours, vecColumnColours(k).ToString())
                    Next
                End If
            End If
        Catch ex As Exception
            'TODO what to do in this case?
        End Try
        If grdCurr.CurrentWorksheet.IsFrozen() Then
            grdCurr.CurrentWorksheet.FreezeToCell(row:=0, col:=0)
        End If
        If bCheckFreezeColumns AndAlso frmMain.clsRLink.bInstatObjectExists Then
            clsGetVarMetaFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
            clsGetVarMetaFunc.ClearParameters()
            clsGetVarMetaFunc.AddParameter("data_name", Chr(34) & strName & Chr(34))
            clsGetVarMetaFunc.AddParameter("property", "is_frozen_label")

            clsIsVarMetaFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$is_variables_metadata")
            clsIsVarMetaFunc.AddParameter("data_name", Chr(34) & strName & Chr(34))
            clsIsVarMetaFunc.AddParameter("property", "is_frozen_label")
            'TODO fix freezing bugs
            'bIsFrozen = frmMain.clsRLink.RunInternalScriptGetValue(clsIsVarMetaFunc.ToScript()).AsLogical(0)
            ' temp fix
            bIsFrozen = False
            If bIsFrozen Then
                For k = 0 To dfTemp.ColumnCount - 1
                    clsGetVarMetaFunc.AddParameter("column", Chr(34) & strColumnNames(k) & Chr(34))
                    bIsFrozen = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVarMetaFunc.ToScript()).AsLogical(0)
                    If bIsFrozen Then
                        If k = dfTemp.ColumnCount - 1 Then
                            MsgBox("Cannot freeze all columns.", Title:="Cannot freeze")
                        Else
                            grdCurr.CurrentWorksheet.FreezeToCell(row:=0, col:=k + 1)
                        End If
                        Exit For
                    End If
                Next
            End If
        End If

    End Sub

    Private Function ListAsRString(strValues As String(), Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String
        strTemp = "c("
        For i = 0 To strValues.Count - 1
            If i > 0 Then
                strTemp = strTemp & ","
            End If
            If bWithQuotes Then
                strTemp = strTemp & Chr(34) & strValues(i) & Chr(34)
            Else
                strTemp = strTemp & strValues(i)
            End If
        Next
        strTemp = strTemp & ")"
        Return strTemp
    End Function

    Public Sub SetMaxRows(iRows As Integer)
        iMaxRows = iRows
        bGrdDataChanged = True
        bGrdMetadataChanged = True
        bGrdVariablesMetadataChanged = True
        'TODO This causes the last sheet to be current sheet after running this.
        '     Need to change how this is done so that the current sheet is remembered before changing.
        If frmMain.clsRLink.bInstatObjectExists Then
            frmMain.clsRLink.RunInternalScript(frmMain.clsRLink.strInstatDataObject & "$data_objects_changed <- TRUE")
        End If
        UpdateGrids()
    End Sub

    Public Sub SetMaxCols(iCols As Integer)
        iMaxCols = iCols
        bGrdDataChanged = True
        bGrdMetadataChanged = True
        bGrdVariablesMetadataChanged = True
        'TODO This causes the last sheet to be current sheet after running this.
        '     Need to change how this is done so that the current sheet is remembered before changing.
        If frmMain.clsRLink.bInstatObjectExists Then
            frmMain.clsRLink.RunInternalScript(frmMain.clsRLink.strInstatDataObject & "$data_objects_changed <- TRUE")
        End If
        UpdateGrids()
    End Sub

    Public Sub SetFormatDataView(fntNew As Font, clrNew As Color)
        fntText = fntNew
        clrText = clrNew
        For Each tmpSheet In grdData.Worksheets
            FormatDataView(tmpSheet)
        Next
    End Sub

    Public Sub FormatDataView(shtCurrent As Worksheet)
        shtCurrent.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                                .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName, .TextColor = clrText, .FontSize = fntText.Size, .FontName = fntText.Name
                                })
        shtCurrent.SetSettings(unvell.ReoGrid.WorksheetSettings.View_AllowCellTextOverflow, False)
    End Sub
End Class