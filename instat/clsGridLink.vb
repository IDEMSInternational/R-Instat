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
    Public iMaxRows As Integer

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

        If Not frmMain.clsRLink.bInstatObjectExists Then Exit Sub

        bRDataChanged = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_data_changed()").AsLogical(0)
        bRMetadataChanged = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_metadata_changed()").AsLogical(0)
        bRVariablesMetadataChanged = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata_changed()").AsLogical(0)

        If (bGrdDataExists And (bGrdDataChanged Or bRDataChanged)) Or (bGrdVariablesMetadataExists And (bGrdVariablesMetadataChanged Or bRVariablesMetadataChanged)) Then
            lstDataNames = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_data_names()").AsList
            For i = 0 To lstDataNames.Length - 1
                strDataName = lstDataNames.AsCharacter(i)
                If (bGrdDataExists And frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_data_changed(data_name = " & Chr(34) & strDataName & Chr(34) & ")").AsLogical(0)) Then
                    frmMain.clsRLink.clsEngine.Evaluate(strDataName & "<-" & frmMain.clsRLink.strInstatDataObject & "$get_data_frame(" & Chr(34) & strDataName & Chr(34) & ", convert_to_character = TRUE, include_hidden_columns = FALSE, use_current_filter = TRUE)")
                    dfTemp = frmMain.clsRLink.clsEngine.GetSymbol(strDataName).AsCharacterMatrix()
                    If frmMain.clsRLink.RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$filter_applied(data_name = " & Chr(34) & strDataName & Chr(34) & ")").AsLogical(0) Then
                        FillSheet(dfTemp, strDataName, grdData, bInstatObjectDataFrame:=True, bIncludeDataTypes:=True, iNewPosition:=i, bFilterApplied:=True)
                    Else
                        FillSheet(dfTemp, strDataName, grdData, bInstatObjectDataFrame:=True, bIncludeDataTypes:=True, iNewPosition:=i)
                    End If
                    frmEditor.SetColumnNames(strDataName, dfTemp.ColumnNames())
                    frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$set_data_frames_changed(" & Chr(34) & strDataName & Chr(34) & ", FALSE)")
                    End If
                    If (bGrdVariablesMetadataExists And frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata_changed(" & Chr(34) & strDataName & Chr(34) & ")").AsLogical(0)) Then
                    dfTemp = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata(" & Chr(34) & strDataName & Chr(34) & ", convert_to_character = TRUE)").AsCharacterMatrix()
                    FillSheet(dfTemp, strDataName, grdVariablesMetadata)
                    frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$set_variables_metadata_changed(" & Chr(34) & strDataName & Chr(34) & ", FALSE)")
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
            dfTemp = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$get_combined_metadata(convert_to_character = TRUE)").AsCharacterMatrix()
            FillSheet(dfTemp, "metadata", grdMetadata)
            frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$set_metadata_changed(new_val = FALSE)")
        End If

        frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$data_objects_changed <- FALSE")

        If grdData.Worksheets.Count = 0 Then
            grdData.Visible = False
            grdVariablesMetadata.Visible = False
            grdMetadata.Visible = False
        Else
            grdData.Visible = True
            grdVariablesMetadata.Visible = True
            grdMetadata.Visible = True
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

    Public Sub FillSheet(dfTemp As CharacterMatrix, strName As String, grdCurr As ReoGridControl, Optional bInstatObjectDataFrame As Boolean = False, Optional bIncludeDataTypes As Boolean = False, Optional iNewPosition As Integer = -1, Optional bFilterApplied As Boolean = False)
        Dim bFoundWorksheet As Boolean = False
        Dim tempWorkSheet As Worksheet
        Dim fillWorkSheet As Worksheet
        Dim rngDataRange As RangePosition
        Dim vecColumnDataTypes As CharacterVector
        Dim clsGetVarMetaFunc As New RFunction
        Dim iCurrPosition As Integer
        Dim iCount As Integer
        Dim strRowNames As String()
        Dim strColumnNames As String()

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

End Class