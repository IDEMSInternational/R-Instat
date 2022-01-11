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
Imports System.Runtime.InteropServices
Imports instat.Translations
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class ucrColumnMetadata
    Private _clsDataBook As clsDataBook
    Private _grid As IColumnMetaDataGrid

    Private lstNonEditableColumns As New List(Of String)

    Private strSignifFiguresLabel As String = "Signif_Figures"
    Private strNameLabel As String = "Name"
    Private strDataTypeLabel As String = "DataType"
    Private strLabelsLabel As String = "labels"
    Private strLabelsScientific As String = "Scientific"

    Public WriteOnly Property DataBook() As clsDataBook
        Set(ByVal value As clsDataBook)
            _clsDataBook = value
            _grid.DataBook = value
        End Set
    End Property

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
        mnuInsertColsAfter.Visible = False
        mnuInsertColsBefore.Visible = False
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return _clsDataBook.GetDataFrame(_grid.CurrentWorksheet.Name)
    End Function

    Private Sub RefreshWorksheet(fillWorksheet As clsWorksheetAdapter, dataFrame As clsDataFrame)
        If Not dataFrame.clsColumnMetaData.HasChanged Then
            Exit Sub
        End If

        _grid.CurrentWorksheet = fillWorksheet
        _grid.AddColumns(dataFrame.clsColumnMetaData)
        _grid.AddRowData(dataFrame.clsColumnMetaData)
        _grid.UpdateWorksheetStyle(fillWorksheet)
        dataFrame.clsColumnMetaData.HasChanged = False
    End Sub

    Private Sub AddAndUpdateWorksheets()
        Dim firstAddedWorksheet As clsWorksheetAdapter = Nothing
        For Each clsDataFrame In _clsDataBook.DataFrames
            Dim worksheet As clsWorksheetAdapter = _grid.GetWorksheet(clsDataFrame.strName)
            If worksheet Is Nothing Then
                worksheet = _grid.AddNewWorksheet(clsDataFrame.strName)
                If firstAddedWorksheet Is Nothing Then
                    firstAddedWorksheet = worksheet
                End If
            End If
            RefreshWorksheet(worksheet, clsDataFrame)
        Next
        If firstAddedWorksheet IsNot Nothing Then
            _grid.CurrentWorksheet = firstAddedWorksheet
        End If
    End Sub

    Public Sub UpdateAllWorksheetStyles()
        _grid.UpdateAllWorksheetStyles()
    End Sub

    Public Sub RefreshGridData()
        If _clsDataBook IsNot Nothing Then
            _grid.RemoveOldWorksheets()
            AddAndUpdateWorksheets()
            _grid.bVisible = _clsDataBook.DataFrames.Count > 0
        End If
    End Sub

    Private Sub loadForm()
        lstNonEditableColumns.AddRange({"class", "Is_Hidden", "Is_Key", "Is_Calculated", "Has_Dependants", "Dependent_Columns", "Calculated_By", "Dependencies", "Colour"})

        'DEBUG
        ' If True Then
        If RuntimeInformation.IsOSPlatform(OSPlatform.Linux) Then
            _grid = ucrLinuxGrid
            tlpTableContainer.ColumnStyles(0).SizeType = SizeType.Percent
            tlpTableContainer.ColumnStyles(0).Width = 100
            tlpTableContainer.ColumnStyles(1).SizeType = SizeType.Absolute
            tlpTableContainer.ColumnStyles(1).Width = 0
        Else
            _grid = ucrReoGrid
            tlpTableContainer.ColumnStyles(0).SizeType = SizeType.Absolute
            tlpTableContainer.ColumnStyles(0).Width = 0
            tlpTableContainer.ColumnStyles(1).SizeType = SizeType.Percent
            tlpTableContainer.ColumnStyles(1).Width = 100
        End If
        _grid.SetNonEditableColumns(lstNonEditableColumns)
        _grid.SetContextmenuStrips(Nothing, cellContextMenuStrip, columnContextMenuStrip, statusColumnMenu)
        AddHandler _grid.EditValue, AddressOf EditValue
        autoTranslate(Me)
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String)
        _grid.SetCurrentDataFrame(strDataName)
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        _grid.SetCurrentDataFrame(iIndex)
    End Sub

    Private Sub EditValue(iRow As Integer, strColumnName As String, strPreviousValue As String, newValue As Object)
        Dim strScript As String
        Dim strComment As String
        Dim strNameColumn As String
        Dim iTemp As Integer
        Dim strNewValue As String
        Dim strBooleanValsAllowed As String() = {"T", "TR", "TRU", "TRUE", "F", "FA", "FAL", "FALS", "FALSE"}

        strNameColumn = _grid.GetCellValue(iRow, strNameLabel)
        If strNameColumn = "" Then
            MsgBox("Developer error: Cannot find Name column in column metadata grid.", MsgBoxStyle.Critical, "Cannot find Name column")
            Exit Sub
        End If

        If strColumnName = strSignifFiguresLabel Then
            If Not (Integer.TryParse(newValue, iTemp) AndAlso iTemp >= 0 AndAlso iTemp <= 22) Then
                MsgBox("Significant Figures must be an integer between 0 and 22", MsgBoxStyle.Information, "Invalid Significant Figures")
                Exit Sub
            Else
                strNewValue = iTemp
            End If
        ElseIf strColumnName = strLabelsScientific Then
            newValue = newValue.ToString.ToUpper
            If strBooleanValsAllowed.Contains(newValue) Then
                If newValue(0) = "F" Then
                    newValue = "FALSE"
                Else
                    newValue = "TRUE"
                End If
                strNewValue = newValue
            Else
                MsgBox("Type TRUE/T to change to scientific display and FALSE/F back to numeric display", MsgBoxStyle.Information)
                Exit Sub
            End If
        Else
            If Decimal.TryParse(newValue, iTemp) Then
                strNewValue = newValue
            Else
                strNewValue = Chr(34) & newValue & Chr(34)
            End If
        End If
        If strColumnName = strNameLabel Then
            If frmMain.clsRLink.IsValidText(newValue) Then
                If frmMain.clsRLink.GetColumnNames(_grid.CurrentWorksheet.Name).Contains(newValue.ToString()) Then
                    MsgBox(newValue.ToString() & " is an existing column name.", MsgBoxStyle.Information, "Invalid Column Name")
                    Exit Sub
                Else
                    strScript = frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data(data_name =" & Chr(34) & _grid.CurrentWorksheet.Name & Chr(34) &
                                    ",column_name = " & Chr(34) & strPreviousValue & Chr(34) & ",new_val=" & strNewValue & ")"
                    strComment = "Renamed column"
                End If
            Else
                MsgBox(newValue & " is not a valid column name.", MsgBoxStyle.Information, "Invalid Column Name")
                Exit Sub
            End If
        Else
            strScript = frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata(data_name =" & Chr(34) & _grid.CurrentWorksheet.Name & Chr(34) &
                                ",col_names = " & Chr(34) & strNameColumn & Chr(34) & ",property=" & Chr(34) & strColumnName & Chr(34) & ",new_val=" & strNewValue & ")"
            strComment = "Edited variables metadata value"
        End If
        Try
            RunScriptFromColumnMetadata(strScript, strComment:=strComment)
        Catch
        End Try
    End Sub

    Public Sub CopyRange()
        Try
            _grid.CopyRange()
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    Public Sub SelectAllText()
        _grid.SelectAll()
    End Sub

    Private Sub RunScriptFromColumnMetadata(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        StartWait()
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        EndWait()
    End Sub

    Private Sub mnuConvertVariate_Click(sender As Object, e As EventArgs) Handles mnuConvertVariate.Click
        For Each strColumn In GetSelectedDataframeColumnsFromSelectedRows()
            Dim iNonNumericValues As Integer
            iNonNumericValues = GetCurrentDataFrameFocus().clsPrepareFunctions.GetAmountOfNonNumericValuesInColumn(strColumn)
            Select Case iNonNumericValues
                Case 0
                    GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, True)
                Case GetCurrentDataFrameFocus().iTotalRowCount
                    GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, False)
                Case Else
                    frmConvertToNumeric.SetDataFrameName(GetCurrentDataFrameFocus().strName)
                    frmConvertToNumeric.SetColumnName(strColumn)
                    frmConvertToNumeric.SetNonNumeric(iNonNumericValues)
                    Dim dialogResult = frmConvertToNumeric.ShowDialog()
                    ' Yes for "normal" convert and No for "labelled" convert
                    If dialogResult = DialogResult.Yes Then
                        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, True)
                    ElseIf dialogResult = DialogResult.No Then
                        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, False)
                    ElseIf dialogResult = DialogResult.Cancel Then
                        Continue For
                    End If
            End Select
        Next
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToText(GetSelectedDataframeColumnsFromSelectedRows)
        EndWait()
    End Sub

    Private Sub mnuConvertToLogical_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogical.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToLogical(GetSelectedDataframeColumnsFromSelectedRows)
        EndWait()
    End Sub

    Private Sub mnuClearColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuClearColumnFilter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub mnuSort_Click(sender As Object, e As EventArgs) Handles mnuSort.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedDataframeColumnFromSelectedRow(), _grid.CurrentWorksheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub StartWait()
        Cursor = Cursors.WaitCursor
        _grid.bEnabled = False
    End Sub

    Private Sub EndWait()
        _grid.bEnabled = True
        Cursor = Cursors.Default
    End Sub

    Private Function GetFirstSelectedDataframeColumnFromSelectedRow() As String
        Return _grid.GetCellValue(_grid.GetSelectedRows(0) - 1, strNameLabel)
    End Function

    Private Function GetSelectedDataframeColumnsFromSelectedRows() As List(Of String)
        Dim selectedDataframeColumns As New List(Of String)
        Dim selectedRows = _grid.GetSelectedRows
        For i = 0 To selectedRows.Count - 1
            selectedDataframeColumns.Add(_grid.GetCellValue(selectedRows(i) - 1, strNameLabel))
        Next
        Return selectedDataframeColumns
    End Function

    Private Function IsOnlyOneDataframeColumnSeleted() As Boolean
        Return _grid.GetSelectedRows().Count = 1
    End Function

    Private Function IsFirstSelectedDataFrameColumnAFactor() As Boolean
        Dim strType As String = GetCurrentDataFrameFocus().clsPrepareFunctions.GetColumnType(GetFirstSelectedDataframeColumnFromSelectedRow())
        Return strType.Contains("factor")
    End Function

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedDataframeColumnsFromSelectedRows)
        EndWait()
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedDataframeColumnFromSelectedRow(), _grid.CurrentWorksheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuColumnFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = _grid.CurrentWorksheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToFactor.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToFactor(GetSelectedDataframeColumnsFromSelectedRows)
        EndWait()
    End Sub


    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If _grid.GetSelectedRows.Count = GetCurrentDataFrameFocus()?.iTotalColumnCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                StartWait()
                GetCurrentDataFrameFocus().clsPrepareFunctions.DeleteColumn(GetSelectedDataframeColumnsFromSelectedRows)
                EndWait()
            End If
        End If
    End Sub
    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(GetFirstSelectedDataframeColumnFromSelectedRow(), _grid.CurrentWorksheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuConvert_Click(sender As Object, e As EventArgs)
        'TODO Selected column should automatically appear in dialog
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuLabelsLevels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        If IsFirstSelectedDataFrameColumnAFactor() Then
            dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedDataframeColumnFromSelectedRow(), GetCurrentDataFrameFocus().strName)
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub columnContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles columnContextMenuStrip.Opening
        If IsOnlyOneDataFrameColumnSeleted() Then
            mnuLevelsLabels.Enabled = IsFirstSelectedDataFrameColumnAFactor()
            mnuDeleteCol.Text = GetTranslation("Delete Column")
            mnuInsertColsBefore.Text = GetTranslation("Insert 1 Column Before")
            mnuInsertColsAfter.Text = GetTranslation("Insert 1 Column After")
        Else
            mnuLevelsLabels.Enabled = False
            mnuDeleteCol.Text = GetTranslation("Delete Columns")
            mnuInsertColsBefore.Text = "Insert " & _grid.GetSelectedColumns.Count & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & _grid.GetSelectedColumns.Count & " Columns After"
        End If
        mnuClearColumnFilter.Enabled = GetCurrentDataFrameFocus().clsFilter.bApplied
    End Sub

    Private Sub mnuReorderColumns_Click(sender As Object, e As EventArgs) Handles mnuReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub propertiesContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles propertiesContextMenuStrip.Opening
        If _grid.GetSelectedColumns(0) <> strLabelsLabel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuDeleteLabels_Click(sender As Object, e As EventArgs) Handles mnuDeleteLabels.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.AppendToVariablesMetadata(GetSelectedDataframeColumnsFromSelectedRows)
        EndWait()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "543")
    End Sub

    Private Sub deleteDataFrame_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(_grid.CurrentWorksheet.Name)
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(_grid.CurrentWorksheet.Name)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub hideSheet_Click(sender As Object, e As EventArgs) Handles hideSheet.Click
        StartWait()
        _clsDataBook.HideDataFrame(_grid.CurrentWorksheet.Name)
        EndWait()
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub copySheet_Click(sender As Object, e As EventArgs) Handles copySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(_grid.CurrentWorksheet.Name)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub viewSheet_Click(sender As Object, e As EventArgs) Handles viewSheet.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ViewDataFrame()
        EndWait()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub statusColumnMenu_Opening(sender As Object, e As CancelEventArgs) Handles statusColumnMenu.Opening
        hideSheet.Enabled = (_clsDataBook.DataFrames.Count > 1)
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=_grid.CurrentWorksheet.Name, strColumn:=GetFirstSelectedDataframeColumnFromSelectedRow())
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuBottomAddComment_Click(sender As Object, e As EventArgs) Handles mnuBottomAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=_grid.CurrentWorksheet.Name)
        dlgAddComment.ShowDialog()
    End Sub

End Class