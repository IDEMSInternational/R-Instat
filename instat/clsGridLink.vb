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
    Public bGrdDataExisits As Boolean = False
    Public bGrdMetadataExisits As Boolean = False
    Public bGrdVariablesMetadataExisits As Boolean = False
    Public bGrdDataChanged As Boolean = False
    Public bGrdMetadataChanged As Boolean = False
    Public bGrdVariablesMetadataChanged As Boolean = False

    Public Sub UpdateGrids()
        Dim bRDataChanged As Boolean
        Dim bRMetadataChanged As Boolean
        Dim bRVariablesMetadataChanged As Boolean
        Dim lstDataNames As GenericVector
        Dim i As Integer
        Dim dfTemp As DataFrame
        Dim strDataName As String
        Dim shtTemp As Worksheet

        bRDataChanged = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_data_changed()").AsLogical(0)
        bRMetadataChanged = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_metadata_changed()").AsLogical(0)
        bRVariablesMetadataChanged = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_variables_metadata_changed()").AsLogical(0)

        If (bGrdDataExisits And (bGrdDataChanged Or bRDataChanged)) Or (bGrdVariablesMetadataExisits And (bGrdVariablesMetadataChanged Or bRVariablesMetadataChanged)) Then
            lstDataNames = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_data_names()")
            For i = 0 To lstDataNames.Length - 1
                strDataName = lstDataNames(i).ToString
                If (bGrdDataExisits And frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_data_changed(" & strDataName & ")").AsLogical(0)) Then
                    dfTemp = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_data_frames(" & strDataName & ")").AsDataFrame
                    FillSheet(dfTemp, strDataName, grdData)
                    frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$set_data_changed(" & strDataName & ", FALSE)")
                End If
                If (bGrdVariablesMetadataExisits And frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_variables_metadata_changed(" & strDataName & ")").AsLogical(0)) Then
                    dfTemp = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$get_data_frames(" & strDataName & ")").AsDataFrame
                    FillSheet(dfTemp, strDataName, grdData)
                    frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "$set_variables_metadata_changed(" & strDataName & ", FALSE)")
                End If

            Next
            'delete old sheets
            If bGrdDataExisits Then
                For i = 0 To grdData.Worksheets.Count - 1
                    ' look up convert genericvector to string list to avoid this loop
                    For j = 0 To lstDataNames.Length - 1
                        If Not lstDataNames(j).ToString = grdData.Worksheets(i).Name Then
                            shtTemp = grdData.Worksheets(j)
                            grdData.Worksheets.Remove(shtTemp)
                        End If
                    Next
                Next
            End If

            If bGrdVariablesMetadataExisits Then
                For i = 0 To grdVariablesMetadata.Worksheets.Count - 1
                    ' look up convert genericvector to string list to avoid this loop
                    For j = 0 To lstDataNames.Length - 1
                        If Not lstDataNames(j).ToString = grdVariablesMetadata.Worksheets(i).Name Then
                            shtTemp = grdVariablesMetadata.Worksheets(j)
                            grdVariablesMetadata.Worksheets.Remove(shtTemp)
                        End If
                    Next
                Next
            End If



        End If

        If bGrdMetadataExisits And (bGrdMetadataChanged Or bRMetadataChanged) Then
            dfTemp = frmMain.clsRInterface.clsEngine.Evaluate(frmMain.clsRInterface.strInstatDataObject & "get_combined_metadata()").AsDataFrame
            FillSheet(dfTemp, "metadata", grdMetadata)
        End If

    End Sub

    Public Sub SetData(grdTemp As ReoGridControl)
        grdData = grdTemp
        bGrdDataExisits = True
        bGrdDataChanged = True
        UpdateGrids()
    End Sub

    Public Sub SetMetadata(grdTemp As ReoGridControl)
        grdMetadata = grdTemp
        bGrdMetadataExisits = True
        bGrdMetadataChanged = True
        UpdateGrids()
    End Sub

    Public Sub SetVariablesMetadata(grdTemp As ReoGridControl)
        grdVariablesMetadata = grdTemp
        bGrdVariablesMetadataExisits = True
        bGrdVariablesMetadataChanged = True
        UpdateGrids()
    End Sub

    Public Sub FillSheet(dfTemp As DataFrame, strName As String, grdCurr As ReoGridControl)
        Dim bFoundWorksheet As Boolean = False
        Dim tempWorkSheet
        Dim fillWorkSheet

        For Each tempWorkSheet In grdCurr.Worksheets
            If tempWorkSheet.Name = strName Then
                fillWorkSheet = grdCurr.GetWorksheetByName(strName)
                bFoundWorksheet = True
            End If
        Next

        If Not bFoundWorksheet Then
            fillWorkSheet = grdCurr.CreateWorksheet(strName)
            grdCurr.AddWorksheet(fillWorkSheet)
        End If

        fillWorkSheet.Reset()
        fillWorkSheet.Rows = dfTemp.RowCount
        fillWorkSheet.Columns = dfTemp.ColumnCount
        For i As Integer = 0 To dfTemp.RowCount - 1
            For j As Integer = 0 To dfTemp.ColumnCount - 1
                fillWorkSheet.ColumnHeaders(j).Text = dfTemp.ColumnNames(j)
                fillWorkSheet(row:=i, col:=j) = dfTemp(i, j)
            Next
        Next
        grdCurr.CurrentWorksheet = fillWorkSheet
    End Sub

    Public Sub LoadData(strDataName As String, strScript As String)
        RunScript(strDataName & " < -" & strScript)
        If Not bInstatObjectExists Then
            RunScript(strInstatDataObject & " < -instat_obj$New() Then")
            bInstatObjectExists = True
        End If
        RunScript(strInstatDataObject & "$import_data(data_tables=list(" & strDataName & "=" & strDataName & "))")

    End Sub

    Public Sub FillDataObjectData(grdData As ReoGridControl)
        Dim dfTemp As DataFrame
        Dim dfList As GenericVector
        Dim i As Integer
        If bInstatObjectExists Then
            dfList = clsEngine.Evaluate(strInstatDataObject & "$get_data_list()").AsList
            For i = 0 To dfList.Count - 1
                dfTemp = dfList(i).AsDataFrame()
                FillData(dfTemp, dfList.Names(i), grdData)
            Next

        End If

    End Sub

    Public Sub FillDataObjectVariables(grdData As ReoGridControl)
        Dim dfList As GenericVector
        Dim dfTemp As DataFrame
        Dim i As Integer
        If bInstatObjectExists Then
            dfList = clsEngine.Evaluate(strInstatDataObject & "$get_variable_info()").AsList
            For i = 0 To dfList.Count - 1
                dfTemp = dfList(i).AsDataFrame()
                FillData(dfTemp, dfList.Names(i), grdData)
            Next
        End If
    End Sub

    Public Sub FillListView(lstView As ListView)
        Dim dfList As GenericVector
        Dim dfTemp As DataFrame
        Dim i As Integer
        Dim grps As New ListViewGroup
        If bInstatObjectExists Then
            lstView.Columns.Add("Available Data", width:=100)
            dfList = clsEngine.Evaluate(strInstatDataObject & "$get_variable_info()").AsList
            For i = 0 To dfList.Count - 1
                grps = New ListViewGroup(dfList.Names(i), HorizontalAlignment.Left)
                If Not lstView.Groups.Contains(grps) Then
                    lstView.Groups.Add(grps)
                End If
                dfTemp = dfList(i).AsDataFrame()
                For j = 0 To dfTemp.RowCount - 1
                    lstView.Items.Add(dfTemp(j, 0)).Group = lstView.Groups(i)
                Next
            Next
        End If
    End Sub

    Public Sub FillDataObjectMetadata(grdData As ReoGridControl)
        Dim dfTemp As DataFrame
        If bInstatObjectExists Then
            dfTemp = GetData(strInstatDataObject & "$get_metadata()").AsDataFrame()
            FillData(dfTemp, "metadata", grdData)
        End If
    End Sub



End Class
