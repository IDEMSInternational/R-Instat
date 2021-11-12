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
Imports unvell.ReoGrid.Events
Imports RDotNet
Imports unvell.ReoGrid

Public Class ucrColumnMetadata
    Private _clsDataBook As clsDataBook

    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String
    Private lstNonEditableColumns As New List(Of String)

    Private strSignifFiguresLabel As String = "Signif_Figures"
    Private strNameLabel As String = "Name"
    Private strDataTypeLabel As String = "DataType"
    Private strLabelsLabel As String = "labels"
    Private strLabelsScientific As String = "Scientific"

    Public WriteOnly Property DataBook() As clsDataBook
        Set(ByVal value As clsDataBook)
            _clsDataBook = value
        End Set
    End Property

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
        mnuInsertColsAfter.Visible = False
        mnuInsertColsBefore.Visible = False
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return _clsDataBook.GetDataFrame(grdCurrSheet.Name)
    End Function

    Private Function GetCurrentColumnMetaDataFrameFocus() As clsColumnMetaData
        Return _clsDataBook.GetColumnMetaData(grdCurrSheet.Name)
    End Function

    Private Sub RefreshWorksheet(fillWorksheet As Worksheet, dataFrame As clsDataFrame)
        If Not dataFrame.clsColumnMetaData.HasChanged Then
            Exit Sub
        End If
        AddColumns(dataFrame, fillWorksheet)
        AddRowData(dataFrame, fillWorksheet)
        UpdateWorksheetStyle(fillWorksheet)
        dataFrame.clsColumnMetaData.HasChanged = False
        grdVariables.CurrentWorksheet = fillWorksheet
    End Sub

    Private Sub AddColumns(dataFramePage As clsDataFrame, worksheet As Worksheet)
        worksheet.Columns = dataFramePage.clsColumnMetaData.iColumnCount
        For i = 0 To dataFramePage.clsColumnMetaData.iColumnCount - 1
            worksheet.ColumnHeaders(i).Text = dataFramePage.clsColumnMetaData.strColumnName(i)
        Next
    End Sub

    Private Sub AddAndUpdateWorksheets(grid As ReoGridControl)
        Dim firstAddedWorksheet As Worksheet = Nothing
        For Each clsDataFrame In _clsDataBook.DataFrames
            Dim fillWorksheet As Worksheet
            fillWorksheet = grid.Worksheets.Where(Function(x) x.Name = clsDataFrame.strName).FirstOrDefault
            If fillWorksheet Is Nothing Then
                fillWorksheet = grid.CreateWorksheet(clsDataFrame.strName)
                grid.AddWorksheet(fillWorksheet)
                If firstAddedWorksheet Is Nothing Then
                    firstAddedWorksheet = fillWorksheet
                End If
            End If
            RefreshWorksheet(fillWorksheet, clsDataFrame)
        Next
        If firstAddedWorksheet IsNot Nothing Then
            grid.CurrentWorksheet = firstAddedWorksheet
        End If
    End Sub

    Public Sub UpdateAllWorksheetStyles()
        For Each worksheet In grdVariables.Worksheets
            UpdateWorksheetStyle(worksheet)
        Next
    End Sub

    Private Sub UpdateWorksheetStyle(fillWorksheet As Worksheet)
        fillWorksheet.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                                .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName,
                                .TextColor = frmMain.clsInstatOptions.clrEditor,
                                .FontSize = frmMain.clsInstatOptions.fntEditor.Size,
                                .FontName = frmMain.clsInstatOptions.fntEditor.Name
                                })
    End Sub

    Private Sub AddRowData(dataFrame As clsDataFrame, worksheet As Worksheet)
        Dim rngDataRange As RangePosition

        worksheet.Rows = dataFrame.clsColumnMetaData.iRowCount
        rngDataRange = New RangePosition(0, 0, worksheet.Rows, worksheet.Columns)
        worksheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)

        For i = 0 To worksheet.Rows - 1
            For j = 0 To worksheet.Columns - 1
                worksheet(row:=i, col:=j) = dataFrame.clsColumnMetaData.Data(i, j)
            Next
            worksheet.RowHeaders.Item(i).Text = dataFrame.clsColumnMetaData.strRowName(i)
        Next
    End Sub

    Public Sub RefreshGridData()
        If _clsDataBook IsNot Nothing Then
            RemoveOldWorksheets(grdVariables)
            AddAndUpdateWorksheets(grdVariables)
            grdVariables.Visible = grdVariables.Worksheets.Count > 0
        End If
    End Sub

    Private Sub RemoveOldWorksheets(grid As ReoGridControl)
        ' Flag to say if a sheet has been deleted.
        Dim bDeleted As Boolean = False

        For i = grid.Worksheets.Count - 1 To 0 Step -1
            Dim iGridWorkheetsPosition As Integer = i 'Needed to prevent warning
            If _clsDataBook.DataFrames.Where(Function(x) x.strName = grid.Worksheets(iGridWorkheetsPosition).Name).Count = 0 Then
                grid.RemoveWorksheet(i)
                bDeleted = True
            End If
        Next
        UpdateCurrentWorksheet()
        ' Force the grid to refresh if a sheet has been deleted as there is sometimes a UI problem otherwise.
        ' There may be a better way to force a refresh. Disable/Enable is almost unnoticeable.
        ' Could investigate why this issue doesn't happen in ucrDataView.
        If bDeleted Then
            grdVariables.Enabled = False
            grdVariables.Enabled = True
        End If
    End Sub

    Private Sub AddBlankWorksheet(grid As ReoGridControl)
        'ReoGrid can not be visible if no worksheets exist
        'Therefore blank worksheet is added
        Dim fillWorksheet As Worksheet = grid.CreateWorksheet("blank")
        grid.AddWorksheet(fillWorksheet)
    End Sub

    Private Sub loadForm()
        grdVariables.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        grdVariables.SheetTabNewButtonVisible = False
        grdVariables.SheetTabWidth = 250
        lstNonEditableColumns.AddRange({"class", "Is_Hidden", "Is_Key", "Is_Calculated", "Has_Dependants", "Dependent_Columns", "Calculated_By", "Dependencies", "Colour"})
        autoTranslate(Me)
    End Sub

    Private Sub grdVariables_CurrentWorksheetChange(sender As Object, e As EventArgs) Handles grdVariables.CurrentWorksheetChanged, Me.Load, grdVariables.WorksheetInserted
        grdCurrSheet = grdVariables.CurrentWorksheet
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String)
        Dim grdWorksheet As unvell.ReoGrid.Worksheet

        If grdVariables IsNot Nothing Then
            grdWorksheet = grdVariables.GetWorksheetByName(strDataName)
            If grdWorksheet IsNot Nothing Then
                grdVariables.CurrentWorksheet = grdWorksheet
            End If
        End If
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        If grdVariables.Worksheets.Count > iIndex Then
            grdVariables.CurrentWorksheet = grdVariables.Worksheets(iIndex)
        Else
            ' Developer error?
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        Dim strScript As String = ""
        Dim strComment As String = ""
        Dim strProperty As String = grdCurrSheet.ColumnHeaders(e.Cell.Column).Text
        Dim strColumn As String
        Dim iTemp As Integer
        Dim iNameColumn As Integer = -1
        Dim strNewValue As String
        Dim strBooleanValsAllowed As String() = {"T", "TR", "TRU", "TRUE", "F", "FA", "FAL", "FALS", "FALSE"}

        If e.NewData.ToString() = strPreviousCellText Then
            e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            Exit Sub
        End If

        For i As Integer = 0 To grdCurrSheet.ColumnCount - 1
            If grdCurrSheet.ColumnHeaders(i).Text = strNameLabel Then
                iNameColumn = i
                Exit For
            End If
        Next
        If iNameColumn <> -1 Then
            strColumn = grdCurrSheet(e.Cell.Row, iNameColumn).ToString()
            If strProperty = strSignifFiguresLabel Then
                If Not (Integer.TryParse(e.NewData, iTemp) AndAlso iTemp >= 0 AndAlso iTemp <= 22) Then
                    MsgBox("Significant Figures must be an integer between 0 and 22", MsgBoxStyle.Information, "Invalid Significant Figures")
                    e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                    Exit Sub
                Else
                    strNewValue = iTemp
                End If
            ElseIf strProperty = strLabelsScientific Then

                e.NewData = e.NewData.ToString.ToUpper
                If strBooleanValsAllowed.Contains(e.NewData) Then
                    If e.NewData(0) = "F" Then
                        e.NewData = "FALSE"
                    Else
                        e.NewData = "TRUE"
                    End If
                    strNewValue = e.NewData
                Else
                    MsgBox("Type TRUE/T to change to scientific display and FALSE/F back to numeric display", MsgBoxStyle.Information)
                    e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                    Exit Sub
                End If
            Else
                If Decimal.TryParse(e.NewData, iTemp) Then
                    strNewValue = e.NewData
                Else
                    strNewValue = Chr(34) & e.NewData & Chr(34)
                End If
            End If
            If strProperty = strNameLabel Then
                If frmMain.clsRLink.IsValidText(e.NewData) Then
                    If frmMain.clsRLink.GetColumnNames(grdCurrSheet.Name).Contains(e.NewData.ToString()) Then
                        MsgBox(e.NewData.ToString() & " is an existing column name.", MsgBoxStyle.Information, "Invalid Column Name")
                        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                        Exit Sub
                    Else
                        strScript = frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data(data_name =" & Chr(34) & grdCurrSheet.Name & Chr(34) & ",column_name = " & Chr(34) & strPreviousCellText & Chr(34) & ",new_val=" & strNewValue & ")"
                        strComment = "Renamed column"
                    End If
                Else
                    MsgBox(e.NewData & " is not a valid column name.", MsgBoxStyle.Information, "Invalid Column Name")
                    e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                    Exit Sub
                End If
            Else
                strScript = frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata(data_name =" & Chr(34) & grdCurrSheet.Name & Chr(34) & ",col_names = " & Chr(34) & strColumn & Chr(34) & ",property=" & Chr(34) & strProperty & Chr(34) & ",new_val=" & strNewValue & ")"
                strComment = "Edited variables metadata value"
            End If
            Try
                RunScriptFromColumnMetadata(strScript, strComment:=strComment)
            Catch
                e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            End Try
        Else
            MsgBox("Developer error: Cannot find Name column in column metadata grid.", MsgBoxStyle.Critical, "Cannot find Name column")
        End If
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        If lstNonEditableColumns.Contains(grdCurrSheet.ColumnHeaders(e.Cell.Column).Text) Then
            e.IsCancelled = True
        Else
            strPreviousCellText = e.Cell.Data.ToString()
        End If
    End Sub

    Private Sub grdCurrSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforeCut
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforePaste
        MsgBox("Pasting multiple cells is currently disabled. This feature will be included in future versions.", MsgBoxStyle.Information, "Cannot paste")
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles grdCurrSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    Private Sub grdCurrSheet_BeforeRangeMove(sender As Object, e As BeforeCopyOrMoveRangeEventArgs) Handles grdCurrSheet.BeforeRangeMove
        e.IsCancelled = True
    End Sub

    Public Sub CopyRange()
        Try
            grdVariables.CurrentWorksheet.Copy()
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    Public Sub SelectAllText()
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.SelectAll()
        End If
    End Sub

    Private Sub RunScriptFromColumnMetadata(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        Cursor = Cursors.WaitCursor
        grdVariables.Enabled = False
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        grdVariables.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub grdVariables_VisibleChanged(sender As Object, e As EventArgs) Handles grdVariables.VisibleChanged
        If grdVariables.Visible Then
            grdVariables.SheetTabWidth = Math.Max(grdVariables.SheetTabWidth, 300)
        End If
    End Sub

    Private Sub grdVariables_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdVariables.CurrentWorksheetChanged, Me.Load, grdVariables.WorksheetInserted
        UpdateCurrentWorksheet()
    End Sub

    Public Sub UpdateCurrentWorksheet()
        grdCurrSheet = grdVariables.CurrentWorksheet
        If grdCurrSheet IsNot Nothing AndAlso frmMain.clsRLink.GetDataFrameNames().Contains(grdCurrSheet.Name) Then
            grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        End If
    End Sub

    Private Sub mnuConvertVariate_Click(sender As Object, e As EventArgs) Handles mnuConvertVariate.Click
        For Each strColumn In GetSelectedDataFrameColumnNames()
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
                    If dialogResult = dialogResult.Yes Then
                        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, True)
                    ElseIf dialogResult = dialogResult.No Then
                        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToNumeric(strColumn, False)
                    ElseIf dialogResult = dialogResult.Cancel Then
                        Continue For
                    End If
            End Select
        Next
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToText(GetSelectedDataFrameColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToLogical_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogical.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToLogical(GetSelectedDataFrameColumnNames())
        EndWait()
    End Sub

    Private Sub mnuClearColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuClearColumnFilter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub mnuSort_Click(sender As Object, e As EventArgs) Handles mnuSort.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedDataFrameColumnName(), grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub StartWait()
        Cursor = Cursors.WaitCursor
        grdVariables.Enabled = False
    End Sub

    Private Sub EndWait()
        grdVariables.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Function GetSelectedDataFrameColumnNames() As List(Of String)
        Dim lstColumns As New List(Of String)
        Dim clsGridRangePosition As RangePosition = grdVariables.CurrentWorksheet.SelectionRange
        For i As Integer = clsGridRangePosition.Row To clsGridRangePosition.Row + clsGridRangePosition.Rows - 1
            lstColumns.Add(grdVariables.CurrentWorksheet(i, 0))
        Next
        Return lstColumns
    End Function

    Private Function GetFirstSelectedDataFrameColumnName() As String
        Return GetSelectedDataFrameColumnNames()(0)
    End Function

    Private Function IsOnlyOneDataFrameColumnSeleted() As Boolean
        Return grdVariables.CurrentWorksheet.SelectionRange.Rows = 1
    End Function

    Private Function IsFirstSelectedDataFrameColumnAFactor() As Boolean
        Dim strType As String = GetCurrentDataFrameFocus().clsPrepareFunctions.GetColumnType(GetFirstSelectedDataFrameColumnName())
        Return strType.Contains("factor")
    End Function

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedDataFrameColumnNames())
        EndWait()
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedDataFrameColumnName(), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuColumnFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToFactor.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToFactor(GetSelectedDataFrameColumnNames())
        EndWait()
    End Sub


    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If grdVariables.CurrentWorksheet.SelectionRange.Rows = grdVariables.CurrentWorksheet.RowCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                StartWait()
                GetCurrentDataFrameFocus().clsPrepareFunctions.DeleteColumn(GetSelectedDataFrameColumnNames())
                EndWait()
            End If
        End If
    End Sub
    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(GetFirstSelectedDataFrameColumnName(), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuConvert_Click(sender As Object, e As EventArgs)
        'TODO Selected column should automatically appear in dialog
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuLabelsLevels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        If IsFirstSelectedDataFrameColumnAFactor() Then
            dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedDataFrameColumnName(), GetCurrentDataFrameFocus().strName)
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
            mnuInsertColsBefore.Text = "Insert " & grdVariables.CurrentWorksheet.SelectionRange.Cols & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & grdVariables.CurrentWorksheet.SelectionRange.Cols & " Columns After"
        End If
        mnuClearColumnFilter.Enabled = GetCurrentDataFrameFocus().clsFilter.bApplied
    End Sub

    Private Sub mnuReorderColumns_Click(sender As Object, e As EventArgs) Handles mnuReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub propertiesContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles propertiesContextMenuStrip.Opening
        If grdCurrSheet.ColumnHeaders(grdCurrSheet.FocusPos.Col).Text <> strLabelsLabel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub mnuDeleteLabels_Click(sender As Object, e As EventArgs) Handles mnuDeleteLabels.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.AppendToVariablesMetadata(GetSelectedDataFrameColumnNames)
        EndWait()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "543")
    End Sub

    Private Sub deleteDataFrame_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(grdCurrSheet.Name)
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub hideSheet_Click(sender As Object, e As EventArgs) Handles hideSheet.Click
        StartWait()
        _clsDataBook.HideDataFrame(grdCurrSheet.Name)
        EndWait()
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub copySheet_Click(sender As Object, e As EventArgs) Handles copySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
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
        hideSheet.Enabled = (grdVariables.Worksheets.Count > 1)
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name, strColumn:=GetFirstSelectedDataFrameColumnName())
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuBottomAddComment_Click(sender As Object, e As EventArgs) Handles mnuBottomAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name)
        dlgAddComment.ShowDialog()
    End Sub
End Class