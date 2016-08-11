' Instat+R
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
Imports unvell.ReoGrid

Public Class clsGridLink
    Public grdData As ReoGridControl
    Public grdMetadata As ReoGridControl
    Public grdVariablesMetadata As ReoGridControl
    Public bGrdDataExists As Boolean
    Public bGrdMetadataExists As Boolean
    Public bGrdVariablesMetadataExists As Boolean
    Public bGrdDataChanged As Boolean
    Public bGrdMetadataChanged As Boolean
    Public bGrdVariablesMetadataChanged As Boolean
    Public bGrdViewDataByMetadata As Boolean
    Public iMaxRows As Integer
    Private strMetadata As String
    Dim lstColors As New List(Of Color)
    Dim colColors As IEnumerable(Of Color) = {Color.Aqua, Color.Gray, Color.LightGreen, Color.AliceBlue, Color.Maroon, Color.Green, Color.LightPink, Color.LightSkyBlue, Color.Brown, Color.MediumPurple, Color.White}


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
        bGrdViewDataByMetadata = False
        iMaxRows = 1000
        lstColors.AddRange(colColors)
    End Sub

    Public Sub UpdateGrids()
        Dim bRDataChanged As Boolean
        Dim bRMetadataChanged As Boolean
        Dim bRVariablesMetadataChanged As Boolean
        Dim bFoundName As Boolean
        Dim lstDataNames As GenericVector
        Dim i As Integer
        Dim j As Integer
        Dim k As Integer
        Dim dfTemp As CharacterMatrix
        Dim strDataName As String
        Dim shtTemp As Worksheet
        Dim clsDataChanged As New RFunction
        Dim clsMetadataChanged As New RFunction
        Dim clsVariablesMetadataChanged As New RFunction
        Dim clsGetDataNames As New RFunction
        Dim clsGetDataFrame As New RFunction
        Dim clsFilterApplied As New RFunction
        Dim clsSetDataFramesChanged As New RFunction
        Dim clsGetVariablesMetadata As New RFunction
        Dim clsSetVariablesMetadataChanged As New RFunction
        Dim clsGetCombinedMetadata As New RFunction
        Dim clsSetMetadataChanged As New RFunction

        clsDataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_changed")
        clsMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_metadata_changed")
        clsVariablesMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata_changed")
        clsGetDataNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")
        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrame.AddParameter("convert_to_character", "TRUE")
        clsGetDataFrame.AddParameter("include_hidden_columns", "FALSE")
        clsGetDataFrame.AddParameter("use_current_filter", "TRUE")
        clsFilterApplied.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_applied")
        clsSetDataFramesChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_data_frames_changed")
        clsGetVariablesMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("convert_to_character", "TRUE")
        clsSetVariablesMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_variables_metadata_changed")
        clsGetCombinedMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_combined_metadata")
        clsSetMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_metadata_changed")

        If Not frmMain.clsRLink.bInstatObjectExists Then Exit Sub

        bRDataChanged = frmMain.clsRLink.RunInternalScriptGetValue(clsDataChanged.ToScript()).AsLogical(0)
        bRMetadataChanged = frmMain.clsRLink.RunInternalScriptGetValue(clsMetadataChanged.ToScript()).AsLogical(0)
        bRVariablesMetadataChanged = frmMain.clsRLink.RunInternalScriptGetValue(clsVariablesMetadataChanged.ToScript()).AsLogical(0)

        If (bGrdDataExists And (bGrdDataChanged Or bRDataChanged)) Or (bGrdVariablesMetadataExists And (bGrdVariablesMetadataChanged Or bRVariablesMetadataChanged)) Then
            lstDataNames = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataNames.ToScript()).AsList
            For i = 0 To lstDataNames.Length - 1
                strDataName = lstDataNames.AsCharacter(i)
                clsDataChanged.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                If (bGrdDataExists AndAlso frmMain.clsRLink.RunInternalScriptGetValue(clsDataChanged.ToScript()).AsLogical(0)) Then
                    clsGetDataFrame.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                    dfTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataFrame.ToScript()).AsCharacterMatrix
                    clsFilterApplied.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                    If frmMain.clsRLink.RunInternalScriptGetValue(clsFilterApplied.ToScript()).AsLogical(0) Then
                        FillSheet(dfTemp, strDataName, grdData, bInstatObjectDataFrame:=True, bIncludeDataTypes:=True, iNewPosition:=i, bFilterApplied:=True, bCheckFreezeColumns:=True)
                    Else
                        FillSheet(dfTemp, strDataName, grdData, bInstatObjectDataFrame:=True, bIncludeDataTypes:=True, iNewPosition:=i, bFilterApplied:=False, bCheckFreezeColumns:=True)
                    End If
                    frmEditor.SetColumnNames(strDataName, dfTemp.ColumnNames())
                    clsSetDataFramesChanged.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                    clsSetDataFramesChanged.AddParameter("new_val", "FALSE")
                    frmMain.clsRLink.RunInternalScript(clsSetDataFramesChanged.ToScript())
                End If
                clsVariablesMetadataChanged.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                If (bGrdVariablesMetadataExists AndAlso frmMain.clsRLink.RunInternalScriptGetValue(clsVariablesMetadataChanged.ToScript()).AsLogical(0)) Then
                    clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                    dfTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVariablesMetadata.ToScript()).AsCharacterMatrix()
                    FillSheet(dfTemp, strDataName, grdVariablesMetadata)
                    clsSetVariablesMetadataChanged.AddParameter("data_name", Chr(34) & strDataName & Chr(34))
                    clsSetVariablesMetadataChanged.AddParameter("new_val", "TRUE")
                    frmMain.clsRLink.RunInternalScript(clsSetVariablesMetadataChanged.ToScript())
                End If
            Next
            'delete old sheets
            'TODO look at this code to improve it (simplify)
            If bGrdDataExists Then
                k = 0
                For i = 0 To grdData.Worksheets.Count - 1
                    ' look up convert genericvector to string list to avoid this loop
                    bFoundName = False
                    For j = 0 To lstDataNames.Length - 1
                        strDataName = lstDataNames.AsCharacter(j)
                        If strDataName = grdData.Worksheets(i - k).Name Then
                            bFoundName = True
                            Exit For
                        End If
                    Next
                    If Not bFoundName Then
                        shtTemp = grdData.Worksheets(i - k)
                        grdData.Worksheets.Remove(shtTemp)
                        k = k + 1
                    End If
                Next
            End If

            If bGrdVariablesMetadataExists Then
                k = 0
                For i = 0 To grdVariablesMetadata.Worksheets.Count - 1
                    ' look up convert genericvector to string list to avoid this loop
                    bFoundName = False
                    For j = 0 To lstDataNames.Length - 1
                        strDataName = lstDataNames.AsCharacter(j)
                        If strDataName = grdVariablesMetadata.Worksheets(i - k).Name Then
                            bFoundName = True
                            Exit For
                        End If
                    Next
                    If Not bFoundName Then
                        shtTemp = grdVariablesMetadata.Worksheets(i - k)
                        grdVariablesMetadata.Worksheets.Remove(shtTemp)
                        k = k + 1
                    End If
                Next
            End If
        End If

        If bGrdMetadataExists And (bGrdMetadataChanged Or bRMetadataChanged) Then
            clsGetCombinedMetadata.AddParameter("convert_to_character", "TRUE")
            dfTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetCombinedMetadata.ToScript()).AsCharacterMatrix()
            FillSheet(dfTemp, "metadata", grdMetadata)
            clsSetMetadataChanged.AddParameter("new_val", "TRUE")
            frmMain.clsRLink.RunInternalScript(clsSetMetadataChanged.ToScript())
        End If

        frmMain.clsRLink.RunInternalScript(frmMain.clsRLink.strInstatDataObject & "$data_objects_changed <- FALSE")

        If grdData.Worksheets.Count = 0 Then
            grdData.Visible = False
            grdVariablesMetadata.Visible = False
            grdMetadata.Visible = False
        Else
            grdData.Visible = True
            grdVariablesMetadata.Visible = True
            grdMetadata.Visible = True
        End If

        If bGrdViewDataByMetadata Then
            SetViewColumnsByMetadata()
            bGrdViewDataByMetadata = False
        End If
    End Sub

    Public Sub SetMetadata(tmpStrMetadata As String)
        strMetadata = tmpStrMetadata
    End Sub
    Private Sub SetViewColumnsByMetadata()
        Dim currSheet As Worksheet
        Dim selRange As New RangePosition
        For Each currSheet In grdData.Worksheets
            If grdData.CurrentWorksheet.Name = currSheet.Name And grdVariablesMetadata.CurrentWorksheet.Name = currSheet.Name Then
                For i As Integer = 0 To grdVariablesMetadata.CurrentWorksheet.ColumnCount - 1
                    If grdVariablesMetadata.CurrentWorksheet.ColumnHeaders.Item(i).Text = strMetadata Then
                        Select Case strMetadata
                            Case "Display_Decimal"
                                grdVariablesMetadata.CurrentWorksheet.SelectColumns(i, 1)
                                selRange = grdVariablesMetadata.CurrentWorksheet.SelectionRange
                                grdVariablesMetadata.CurrentWorksheet.IterateCells(selRange, Function(row, col, cell)
                                                                                                 If cell.Data = "NA" Then
                                                                                                     SetDataViewColumnColor(row, 0)
                                                                                                 Else
                                                                                                     SetDataViewColumnColor(row, 1)
                                                                                                 End If

                                                                                                 Return True
                                                                                             End Function)
                            Case "Is_Hidden"
                                grdVariablesMetadata.CurrentWorksheet.SelectColumns(i, 1)
                                selRange = grdVariablesMetadata.CurrentWorksheet.SelectionRange
                                grdVariablesMetadata.CurrentWorksheet.IterateCells(selRange, Function(row, col, cell)
                                                                                                 Select Case cell.Data

                                                                                                     Case "TRUE"
                                                                                                         SetDataViewColumnColor(row, 0)
                                                                                                     Case "FALSE"
                                                                                                         SetDataViewColumnColor(row, 1)
                                                                                                 End Select
                                                                                                 Return True
                                                                                             End Function)
                            Case "Data_Type"
                                grdVariablesMetadata.CurrentWorksheet.SelectColumns(i, 1)
                                selRange = grdVariablesMetadata.CurrentWorksheet.SelectionRange
                                grdVariablesMetadata.CurrentWorksheet.IterateCells(selRange, Function(row, col, cell)
                                                                                                 Select Case cell.Data

                                                                                                     Case "integer"
                                                                                                         SetDataViewColumnColor(row, 0)
                                                                                                     Case "character"
                                                                                                         SetDataViewColumnColor(row, 1)
                                                                                                     Case "numeric"
                                                                                                         SetDataViewColumnColor(row, 2)
                                                                                                     Case "Date"
                                                                                                         SetDataViewColumnColor(row, 3)
                                                                                                     Case "factor"
                                                                                                         SetDataViewColumnColor(row, 4)
                                                                                                 End Select
                                                                                                 Return True
                                                                                             End Function)
                            Case "Name"
                                grdVariablesMetadata.CurrentWorksheet.SelectColumns(i, 1)
                                selRange = grdVariablesMetadata.CurrentWorksheet.SelectionRange
                                grdVariablesMetadata.CurrentWorksheet.IterateCells(selRange, Function(row, col, cell)
                                                                                                 SetDataViewColumnColor(row, 10, True)
                                                                                                 Return True
                                                                                             End Function)
                        End Select
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub SetDataViewColumnColor(selCol As Integer, selColor As Integer, Optional bRevert As Boolean = False)
        Dim selRangeDataView As New RangePosition
        grdData.CurrentWorksheet.SelectColumns(selCol, 1)
        selRangeDataView = grdData.CurrentWorksheet.SelectionRange
        If bRevert Then
            grdData.CurrentWorksheet.RemoveRangeStyles(selRangeDataView, PlainStyleFlag.All)
        Else
            grdData.CurrentWorksheet.SetRangeStyles(selRangeDataView, New WorksheetRangeStyle() With {.Flag = PlainStyleFlag.BackColor, .BackColor = lstColors.Item(selColor)})
        End If

    End Sub
    Public Sub SetData(grdTemp As ReoGridControl)
        grdData = grdTemp
        bGrdDataExists = True
        bGrdDataChanged = True
        UpdateGrids()
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

    Public Sub FillSheet(dfTemp As CharacterMatrix, strName As String, grdCurr As ReoGridControl, Optional bInstatObjectDataFrame As Boolean = False, Optional bIncludeDataTypes As Boolean = False, Optional iNewPosition As Integer = -1, Optional bFilterApplied As Boolean = False, Optional bCheckFreezeColumns As Boolean = False)
        Dim bFoundWorksheet As Boolean = False
        Dim tempWorkSheet As Worksheet
        Dim fillWorkSheet As Worksheet
        Dim rngDataRange As RangePosition
        Dim vecColumnDataTypes As CharacterVector
        Dim clsGetVarMetaFunc As New RFunction
        Dim clsIsVarMetaFunc As New RFunction
        Dim iCurrPosition As Integer
        Dim iCount As Integer
        Dim strRowNames As String()
        Dim strColumnNames As String()
        Dim bIsFrozen As Boolean

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
        fillWorkSheet.Rows = Math.Min(iMaxRows, dfTemp.RowCount)
        fillWorkSheet.Columns = dfTemp.ColumnCount
        rngDataRange = New RangePosition(0, 0, fillWorkSheet.Rows, fillWorkSheet.Columns)
        fillWorkSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)
        For i As Integer = 0 To fillWorkSheet.Rows - 1
            For j As Integer = 0 To fillWorkSheet.Columns - 1
                fillWorkSheet(row:=i, col:=j) = dfTemp(i, j)
            Next
        Next
        strRowNames = dfTemp.RowNames
        For i As Integer = 0 To fillWorkSheet.Rows - 1
            fillWorkSheet.RowHeaders.Item(i).Text = strRowNames(i)
        Next

        If bFilterApplied Then
            For i As Integer = 0 To fillWorkSheet.Rows - 1
                fillWorkSheet.RowHeaders(i).TextColor = Color.Red
            Next
        Else
            For i As Integer = 0 To fillWorkSheet.Rows - 1
                fillWorkSheet.RowHeaders(i).TextColor = Color.DarkBlue
            Next
        End If
        strColumnNames = dfTemp.ColumnNames
        Try
            If bIncludeDataTypes Then
                If bInstatObjectDataFrame AndAlso frmMain.clsRLink.bInstatObjectExists Then
                    clsGetVarMetaFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
                    clsGetVarMetaFunc.AddParameter("data_name", Chr(34) & strName & Chr(34))
                    clsGetVarMetaFunc.AddParameter("property", "data_type_label")
                    clsGetVarMetaFunc.AddParameter("column", ListAsRString(dfTemp.ColumnNames()))
                Else
                    clsGetVarMetaFunc.SetRCommand("sapply")
                    clsGetVarMetaFunc.AddParameter("X", strName)
                    clsGetVarMetaFunc.AddParameter("FUN", Chr(34) & "class" & Chr(34))
                End If

                vecColumnDataTypes = frmMain.clsRLink.RunInternalScriptGetValue(clsGetVarMetaFunc.ToScript()).AsCharacter

                For k As Integer = 0 To dfTemp.ColumnCount - 1
                    Select Case vecColumnDataTypes(k)
                        Case "factor"
                            fillWorkSheet.ColumnHeaders(k).Text = strColumnNames(k) & " (f)"
                        Case "character"
                            fillWorkSheet.ColumnHeaders(k).Text = strColumnNames(k) & " (c)"
                        Case "Date"
                            fillWorkSheet.ColumnHeaders(k).Text = strColumnNames(k) & " (D)"
                        Case Else
                            fillWorkSheet.ColumnHeaders(k).Text = strColumnNames(k)
                    End Select
                Next
            Else
                For k As Integer = 0 To dfTemp.ColumnCount - 1
                    fillWorkSheet.ColumnHeaders(k).Text = strColumnNames(k)
                Next
            End If
            grdCurr.CurrentWorksheet = fillWorkSheet
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

            bIsFrozen = frmMain.clsRLink.RunInternalScriptGetValue(clsIsVarMetaFunc.ToScript()).AsLogical(0)
            If bIsFrozen Then
                For k As Integer = 0 To dfTemp.ColumnCount - 1
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
        If frmMain.clsRLink.bInstatObjectExists Then
            frmMain.clsRLink.RunInternalScript(frmMain.clsRLink.strInstatDataObject & "$data_objects_changed <- TRUE")
        End If
        UpdateGrids()
    End Sub

    Public Sub FormatDataVIew(fntNew As Font, clrNew As Color)
        Dim tmpSheets As Worksheet
        For Each tmpSheets In frmMain.clsGrids.grdData.Worksheets
            tmpSheets.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                             .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName, .TextColor = clrNew, .FontSize = fntNew.Size, .FontName = fntNew.Name})

        Next
    End Sub
End Class