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
Imports System.IO
Imports System.Globalization
Imports System.Threading
Imports instat.Translations
Imports unvell.ReoGrid.Events
Imports System.ComponentModel
Imports unvell.ReoGrid

Public Class ucrDataView
    'Public clearFilter As unvell.ReoGrid.Data.AutoColumnFilter
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet

    'should not be public - testing only
    Public DataBook As clsDataBook

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub RefreshWorksheet(fillWorkSheet As Worksheet, dataFrame As clsDataFrame)
        AddColumns(dataFrame.VisiblePage, fillWorkSheet)
        AddRowData(dataFrame, fillWorkSheet)
        UpdateNavigationButtons()
    End Sub

    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return DataBook.GetDataFrame(grdCurrSheet.Name)
    End Function

    Private Sub UpdateNavigationButtons()
        lblColBack.Enabled = If(GetCurrentDataFrameFocus()?.VisiblePage?.CanLoadPreviousColumnPage(), False)
        lblColNext.Enabled = If(GetCurrentDataFrameFocus()?.VisiblePage?.CanLoadNextColumnPage(), False)
        lblRowBack.Enabled = If(GetCurrentDataFrameFocus()?.VisiblePage?.CanLoadPreviousRowPage(), False)
        lblRowNext.Enabled = If(GetCurrentDataFrameFocus()?.VisiblePage?.CanLoadNextRowPage(), False)
    End Sub

    Private Sub AddAndUpdateWorksheets(grid As ReoGridControl)
        'This should use existing worksheets rather than re adding
        Dim fillWorkSheet As Worksheet
        ' grid.Worksheets.Clear()
        For Each clsDataFrame In DataBook.DataFrames
            fillWorkSheet = grid.Worksheets.Where(Function(x) x.Name = clsDataFrame.Name).FirstOrDefault
            If fillWorkSheet Is Nothing Then
                fillWorkSheet = grid.CreateWorksheet(clsDataFrame.Name)
                grid.AddWorksheet(fillWorkSheet)
            End If
            RefreshWorksheet(fillWorkSheet, clsDataFrame)
        Next

    End Sub

    Private Sub RemoveOldWorksheets(grid As ReoGridControl)
        For i = grid.Worksheets.Count - 1 To 0 Step -1
            If DataBook.DataFrames.Where(Function(x) x.Name = grid.Worksheets(i).Name).Count = 0 Then
                grid.RemoveWorksheet(i)
            End If
        Next
    End Sub

    Private Sub AddColumns(dataFramePage As clsDataFramePage, workSheet As Worksheet)
        Dim workSheetColumnHeader As ColumnHeader
        workSheet.Columns = dataFramePage.lstColumns.Count
        For i = 0 To dataFramePage.lstColumns.Count - 1
            workSheetColumnHeader = workSheet.ColumnHeaders(i)
            workSheetColumnHeader.Text = dataFramePage.lstColumns(i).Name
            workSheetColumnHeader.TextColor = dataFramePage.lstColumns(i).Colour
            workSheetColumnHeader.Style.BackColor = dataFramePage.lstColumns(i).BackGroundColour
        Next
    End Sub

    Private Sub AddRowData(dataFrame As clsDataFrame, workSheet As Worksheet)
        Dim textColour As Color
        Dim rngDataRange As RangePosition

        workSheet.Rows = dataFrame.DisplayedRowCount

        rngDataRange = New RangePosition(0, 0, workSheet.Rows, workSheet.Columns)
        workSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)

        If dataFrame.Filter.bApplied Then
            textColour = Color.Red
        Else
            textColour = Color.DarkBlue
        End If

        For i = 0 To workSheet.Rows - 1
            For j = 0 To workSheet.Columns - 1
                workSheet(row:=i, col:=j) = dataFrame.Data(i, j)
            Next
            workSheet.RowHeaders.Item(i).Text = dataFrame.RowName(i)
            workSheet.RowHeaders(i).TextColor = textColour
        Next
    End Sub

    Public Sub RefreshGridData()
        If DataBook IsNot Nothing Then
            DataBook.UpdateGrids()
            AddAndUpdateWorksheets(grdData)
            RemoveOldWorksheets(grdData)
            grdData.Visible = Not grdData.Worksheets.Count = 0
        End If
    End Sub

    Private Sub ucrDataView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdData.Visible = False
        mnuInsertColsBefore.Visible = False
        mnuInsertColsAfter.Visible = False
        autoTranslate(Me)
        'Disable Autoformat cell
        'This needs to be added at the part when we are writing data to the grid, not here
        'Needs discussion, with this the grid can show NA's
        grdData.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_AutoFormatCell, False)
        grdData.SheetTabWidth = 450
    End Sub

    ''' <summary>
    ''' Run any R operation/command from the grid by passing a Function which will run the R operation/command.
    ''' This wrapper ensures consistency in what is done before and after running an R command.
    ''' </summary>
    ''' <param name="action">A function that will run an R operation/command, usually from GridROperations.</param>
    Private Sub RunRCommand(action As Action)
        Cursor = Cursors.WaitCursor
        grdData.Enabled = False
        action()
        grdData.Enabled = True
        Cursor = Cursors.Default
    End Sub


    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If grdData.CurrentWorksheet.SelectionRange.Cols = grdData.CurrentWorksheet.ColumnCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                StartWait()
                GetCurrentDataFrameFocus().clsPrepareFunctions.DeleteColumn(GetSelectedColumnNames())
                EndWait()
            End If
        End If
    End Sub

    Private Sub mnuInsertRowsAfter_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsAfter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.InsertRows(grdData.CurrentWorksheet.SelectionRange.Rows, grdCurrSheet.RowHeaders(grdCurrSheet.SelectionRange.EndRow).Text, False)
        EndWait()
    End Sub

    Private Sub mnuInsertRowsBefore_Click(sender As Object, e As EventArgs) Handles mnuInsertRowsBefore.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.InsertRows(grdData.CurrentWorksheet.SelectionRange.Rows, grdCurrSheet.RowHeaders(grdCurrSheet.SelectionRange.EndRow).Text, True)
        EndWait()
    End Sub

    Private Sub mnuDeleteRows_Click(sender As Object, e As EventArgs) Handles mnuDeleteRows.Click

        Dim Delete = MsgBox("Are you sure you want to delete these row(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Row(s)")
        If Delete = DialogResult.Yes Then
            Dim lstSelectedRows As New List(Of String)
            For i As Integer = grdData.CurrentWorksheet.SelectionRange.Row To grdData.CurrentWorksheet.SelectionRange.Row + grdData.CurrentWorksheet.SelectionRange.Rows - 1
                lstSelectedRows.Add(grdCurrSheet.RowHeaders.Item(i).Text)
            Next
            StartWait()
            GetCurrentDataFrameFocus().clsPrepareFunctions.DeleteRows(lstSelectedRows)
            EndWait()
        End If
    End Sub

    Public Sub CopyRange()
        Try
            grdData.CurrentWorksheet.Copy()
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    Public Sub SelectAllText()
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.SelectAll()
        End If
    End Sub

    Private Sub deleteSheet_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(grdCurrSheet.Name)
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Private Sub grdData_WorksheetRemoved(sender As Object, e As WorksheetRemovedEventArgs) Handles grdData.WorksheetRemoved
        If grdData.Worksheets.Count < 1 Then
            grdData.Hide()
        ElseIf grdCurrSheet.Equals(e.Worksheet) Then
            UpdateCurrentWorksheet()
            grdData.Refresh()
        End If
    End Sub

    Private Sub mnuColumnRename_Click(sender As Object, e As EventArgs) Handles mnuColumnRename.Click
        dlgName.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub grdData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdData.CurrentWorksheetChanged, Me.Load, grdData.WorksheetInserted
        UpdateCurrentWorksheet()
    End Sub

    Public Sub UpdateCurrentWorksheet()
        grdCurrSheet = grdData.CurrentWorksheet
        If grdCurrSheet IsNot Nothing AndAlso DataBook IsNot Nothing AndAlso GetCurrentDataFrameFocus() IsNot Nothing Then
            frmMain.strCurrentDataFrame = grdCurrSheet.Name
            frmMain.tstatus.Text = grdCurrSheet.Name
            grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
            SetDisplayLabels()
            UpdateNavigationButtons()
            'hide startup menu items
            panelSectionsAll.Visible = False
        Else
            frmMain.tstatus.Text = GetTranslation("No data loaded")
            lblRowDisplay.Text = ""
            'show startup menu items
            panelSectionsAll.Visible = True
        End If
    End Sub

    Private Sub SetDisplayLabels()
        If GetCurrentDataFrameFocus().Filter.bApplied Then
            lblRowDisplay.Text = "Showing rows " & GetCurrentDataFrameFocus().VisiblePage.intStartRow & " to " & GetCurrentDataFrameFocus().VisiblePage.intEndRow &
                                 " of " & GetCurrentDataFrameFocus().Filter.intFilteredRowCount & " rows" &
                                 " (" & GetCurrentDataFrameFocus().TotalRowCount & ")" & " | Active filter: " & GetCurrentDataFrameFocus().Filter.strName
        Else
            lblRowDisplay.Text = "Showing rows " & GetCurrentDataFrameFocus().VisiblePage.intStartRow & " to " & GetCurrentDataFrameFocus().VisiblePage.intEndRow &
                                 " of " & GetCurrentDataFrameFocus().TotalRowCount & " rows"
        End If
        lblColDisplay.Text = "columns " & GetCurrentDataFrameFocus().VisiblePage.intStartColumn & " to " & GetCurrentDataFrameFocus().VisiblePage.intEndColumn &
                            " of " & GetCurrentDataFrameFocus().TotalColumnCount & " columns"

    End Sub


    'TODO discuss validation for cell editing
    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        'temporary disabled editing
        'e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        ReplaceValueInData(e.NewData.ToString(), e.Cell.Row, e.Cell.Column)
        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
    End Sub

    Private Sub ReplaceValueInData(strNewValue As String, iRow As Integer, iCol As Integer)
        Dim strReturnMessage As String = ""
        Dim bSuccess As Boolean
        StartWait()
        bSuccess = GetCurrentDataFrameFocus().clsPrepareFunctions.ReplaceValueInData(strNewValue, iRow, grdCurrSheet.RowHeaders.Item(iRow).Text, strReturnMessage)
        EndWait()
        If Not bSuccess Then
            MsgBox(strReturnMessage, MsgBoxStyle.Exclamation, "Invalid Value")
        End If

    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub MoveOrCopySheet_Click(sender As Object, e As EventArgs) Handles CopySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(grdCurrSheet.Name)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub mnuLevelsLabels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        If IsOnlyOneColumnSeleted() Then
            If IsFirstSelectedColumnAFactor() Then
                dlgLabelsLevels.SetCurrentColumn(GetCurrentDataFrameFocus().VisiblePage.lstColumns(0).Name, grdCurrSheet.Name)
            End If
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Function GetSelectedColumns() As List(Of clsColumnHeaderDisplay)
        Dim lstColumns As List(Of clsColumnHeaderDisplay) = New List(Of clsColumnHeaderDisplay)
        'TODO paging - may need to know start column
        For i As Integer = grdData.CurrentWorksheet.SelectionRange.Col To grdData.CurrentWorksheet.SelectionRange.Col + grdData.CurrentWorksheet.SelectionRange.Cols - 1
            lstColumns.Add(GetCurrentDataFrameFocus().VisiblePage.lstColumns(i))
        Next
        Return lstColumns
    End Function
    Private Function GetSelectedColumnNames() As List(Of String)
        Return GetSelectedColumns().Select(Function(x) x.Name).ToList()
    End Function

    Private Function GetFirstSelectedColumnName() As String
        Return GetSelectedColumns().FirstOrDefault().Name
    End Function

    Private Function GetLastSelectedColumnName() As String
        Return GetSelectedColumns().LastOrDefault().Name
    End Function

    Private Function IsOnlyOneColumnSeleted() As Boolean
        Return grdData.CurrentWorksheet.SelectionRange.Cols = 1
    End Function
    Private Function IsFirstSelectedColumnAFactor() As Boolean
        Return GetSelectedColumns().FirstOrDefault().IsFactor
    End Function

    Private Sub StartWait()
        Cursor = Cursors.WaitCursor
        grdData.Enabled = False
    End Sub
    Private Sub EndWait()
        grdData.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToText(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToLogical_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogical.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToLogical(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToFactor.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuColumnFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub mnuFilter_Click(sender As Object, e As EventArgs) Handles mnuFilter.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilter_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub mnuClearColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuClearColumnFilter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub mnuSort_Click(sender As Object, e As EventArgs) Handles mnuSort.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFreezeToHere_Click(sender As Object, e As EventArgs)
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.FreezeColumns(GetLastSelectedColumnName)
        EndWait()
    End Sub

    Private Sub mnuUnfreeze_Click(sender As Object, e As EventArgs)
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.UnFreezeColumns()
        EndWait()
    End Sub

    Private Sub grdCurrSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforeCut
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrSheet.BeforePaste
        e.IsCancelled = True 'prevents pasted data from being added directly into the data view 
        '    Dim arrAllCurrentColumns As String()
        Dim lstSelectedColumnNames As New List(Of String)
        Dim iStartRowPos As Integer
        'get all columns of current selected data frame
        '      arrAllCurrentColumns = GetCurrentWorkSheetColumnNames()
        'validate columns
        If e.Range.EndCol >= GetCurrentDataFrameFocus().VisiblePage.lstColumns.Count Then
            'this happens when Ctrl + V is pressed and the data to be pasted has more columns
            'than columns between start and end column 
            MsgBox("Columns copied are more than the current data frame columns.", MsgBoxStyle.Critical, "Excess Columns")
            Exit Sub
        End If
        'get selected columns
        'For colIndex As Integer = e.Range.Col To e.Range.EndCol
        '    lstSelectedColumnNames.Add(arrAllCurrentColumns(colIndex))
        'Next


        'TODO check see if pasted range is same as selected



        'get starting row position then paste clipboard values
        iStartRowPos = Integer.Parse(grdData.CurrentWorksheet.RowHeaders.Item(e.Range.Row).Text)
        PasteValuesToDataFrame(GetSelectedColumnNames(), iStartRowPos, False)
    End Sub

    ' Not currently working. Bug with reogrid reported here:
    ' https://reogrid.net/forum/viewtopic.php?id=350
    Private Sub grdCurrSheet_BeforeRangeMove(sender As Object, e As BeforeCopyOrMoveRangeEventArgs) Handles grdCurrSheet.BeforeRangeMove
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles grdCurrSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    Private Sub ViewSheet_Click(sender As Object, e As EventArgs) Handles ViewSheet.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ViewDataFrame()
        EndWait()
    End Sub

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Function GetFirstSelectedRow() As String
        Return grdCurrSheet.RowHeaders.Item(grdData.CurrentWorksheet.SelectionRange.Row).Text
    End Function

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(grdCurrSheet.Name, GetFirstSelectedRow())
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuComment_Click(sender As Object, e As EventArgs) Handles mnuComment.Click
        dlgAddComment.SetPosition(grdCurrSheet.Name, GetFirstSelectedRow(), GetFirstSelectedColumnName())
        dlgAddComment.ShowDialog()
    End Sub

    Public Sub SetCurrentDataFrame(strDataName As String)
        Dim grdWorksheet As unvell.ReoGrid.Worksheet

        If grdData IsNot Nothing Then
            grdWorksheet = grdData.GetWorksheetByName(strDataName)
            If grdWorksheet IsNot Nothing Then
                grdData.CurrentWorksheet = grdWorksheet
            End If
        End If
    End Sub

    Public Sub SetCurrentDataFrame(iIndex As Integer)
        If grdData IsNot Nothing Then
            If grdData.Worksheets.Count > iIndex Then
                grdData.CurrentWorksheet = grdData.Worksheets(iIndex)
            Else
                ' Developer error?
            End If
        End If
    End Sub

    Private Sub RunScriptFromDataView(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        Cursor = Cursors.WaitCursor
        grdData.Enabled = False
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        grdData.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub columnContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles columnContextMenuStrip.Opening
        If IsOnlyOneColumnSeleted() Then
            mnuLevelsLabels.Enabled = IsFirstSelectedColumnAFactor()
            mnuDeleteCol.Text = GetTranslation("Delete Column")
            mnuInsertColsBefore.Text = GetTranslation("Insert 1 Column Before")
            mnuInsertColsAfter.Text = GetTranslation("Insert 1 Column After")
        Else
            mnuLevelsLabels.Enabled = False
            mnuDeleteCol.Text = GetTranslation("Delete Columns")
            mnuInsertColsBefore.Text = "Insert " & grdData.CurrentWorksheet.SelectionRange.Cols & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & grdData.CurrentWorksheet.SelectionRange.Cols & " Columns After"
        End If
        mnuClearColumnFilter.Enabled = GetCurrentDataFrameFocus().Filter.bApplied
    End Sub

    Private Sub HideSheet_Click(sender As Object, e As EventArgs) Handles HideSheet.Click
        StartWait()
        DataBook.HideDataFrame(grdCurrSheet.Name)
        EndWait()
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub statusColumnMenu_Opening(sender As Object, e As CancelEventArgs) Handles statusColumnMenu.Opening
        HideSheet.Enabled = (grdData.Worksheets.Count > 1)
    End Sub

    Private Sub mnuReorderColumns_Click(sender As Object, e As EventArgs) Handles mnuReorderColumns.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuRenameColumn_Click(sender As Object, e As EventArgs) Handles mnuRenameColumn.Click
        dlgName.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuDuplColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetFirstSelectedColumnName(), grdCurrSheet.Name)
        dlgDuplicateColumns.ShowDialog()
    End Sub

    Private Sub mnuReorderColumn_Click(sender As Object, e As EventArgs) Handles mnuReorderColumn.Click
        dlgReorderColumns.ShowDialog()
    End Sub

    Private Sub mnuConvertToFact_Click(sender As Object, e As EventArgs) Handles mnuConvertToFact.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToOrderedFactor_Click(sender As Object, e As EventArgs) Handles mnuConvertToOrderedFactor.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToCharacter_Click(sender As Object, e As EventArgs) Handles mnuConvertToCharacter.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToCharacter(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToLogic_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogic.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToLogical(GetSelectedColumnNames())
        EndWait()
    End Sub

    Private Sub mnuConvertToNumeric_Click(sender As Object, e As EventArgs) Handles mnuConvertToNumeric.Click, mnuConvertVariate.Click
        'TODO Move this command from GridOperations 
        RunRCommand(Sub() GridROperations.ConvertToNumeric(grdCurrSheet.Name, GetSelectedColumns().Select(Function(x) x.Name), GetCurrentDataFrameFocus().TotalRowCount))
    End Sub

    Private Sub mnuLebelsLevel_Click(sender As Object, e As EventArgs) Handles mnuLebelsLevel.Click
        If IsOnlyOneColumnSeleted() Then
            If IsFirstSelectedColumnAFactor() Then
                dlgLabelsLevels.SetCurrentColumn(GetFirstSelectedColumnName, grdCurrSheet.Name)
            End If
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub mnuSorts_Click(sender As Object, e As EventArgs) Handles mnuSorts.Click
        dlgSort.SetCurrentColumn(GetFirstSelectedColumnName, grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    Private Sub mnuFilters_Click(sender As Object, e As EventArgs) Handles mnuFilters.Click
        dlgRestrict.bIsSubsetDialog = False
        dlgRestrict.strDefaultDataframe = grdCurrSheet.Name
        dlgRestrict.ShowDialog()
    End Sub

    Private Sub mnuRemoveCurrentFilters_Click(sender As Object, e As EventArgs) Handles mnuRemoveCurrentFilters.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.RemoveCurrentFilter()
        EndWait()
    End Sub

    Private Sub grdCurrSheet_CellDataChanged(sender As Object, e As CellEventArgs) Handles grdCurrSheet.CellDataChanged
        frmMain.bDataSaved = False
    End Sub

    Private Sub linkNewDataFrame_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartNewDataFrame.LinkClicked
        dlgNewDataFrame.ShowDialog()
    End Sub

    Private Sub linkOpenFile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartOpenFile.LinkClicked
        dlgImportDataset.ShowDialog()
    End Sub

    Private Sub linkOpenLibrary_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkStartOpenLibrary.LinkClicked
        dlgFromLibrary.ShowDialog()
    End Sub

    ''' <summary>
    ''' clears all the added links label menu items from the recents panel of the data view
    ''' </summary>
    Public Sub ClearRecentFileMenuItems()
        panelRecentMenuItems.Controls.Clear()
        HideOrShowRecentSection()
    End Sub

    ''' <summary>
    ''' adds the link label as a menu item to the recents panel of the data view
    ''' </summary>
    ''' <param name="linkMenuItem">link label with file path set as its tag</param>
    Public Sub InsertRecentFileMenuItems(linkMenuItem As LinkLabel)
        'label used to display the path to the user
        Dim lblMenuItemPath As New Label
        Dim position As Integer = 1

        'add subsequent links after each other, separating them by 19 pixels on the Y axis
        If panelRecentMenuItems.Controls.Count > 0 Then
            'get Y axis position of last control then add 19 pixels to be used as the new Y axis position.
            position = panelRecentMenuItems.Controls.Item(panelRecentMenuItems.Controls.Count - 1).Location.Y
            position = position + 19
        End If

        linkMenuItem.Location = New Point(0, position)
        linkMenuItem.Height = 13
        linkMenuItem.LinkBehavior = LinkBehavior.NeverUnderline
        linkMenuItem.AutoSize = True

        'add the link control. 
        panelRecentMenuItems.Controls.Add(linkMenuItem)

        'add the label control. will be besides each other on the same Y axis
        lblMenuItemPath.Text = If(String.IsNullOrEmpty(linkMenuItem.Tag), "", Path.GetDirectoryName(linkMenuItem.Tag))
        lblMenuItemPath.Location = New Point(linkMenuItem.Width + 10, position)
        lblMenuItemPath.Height = 13
        lblMenuItemPath.AutoSize = True
        panelRecentMenuItems.Controls.Add(lblMenuItemPath)
        HideOrShowRecentSection()
    End Sub

    ''' <summary>
    ''' toggles startup menu items visibility
    ''' </summary>
    ''' <param name="bVisibility"></param>
    Public Sub StartupMenuItemsVisibility(bVisibility As Boolean)
        panelSectionStart.Visible = bVisibility
        panelSectionHelp.Visible = bVisibility
        If bVisibility Then
            HideOrShowRecentSection()
        Else
            panelSectionRecent.Visible = False
        End If
    End Sub

    Private Sub HideOrShowRecentSection()
        panelSectionRecent.Visible = panelRecentMenuItems.Controls.Count > 0
    End Sub

    Private Sub linkHelpIntroduction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHelpIntroduction.LinkClicked
        Help.ShowHelp(frmMain, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "0")
    End Sub

    Private Sub linkHelpRpackages_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHelpRpackages.LinkClicked
        dlgHelpVignettes.ShowDialog()
    End Sub

    Private Sub linkHelpRInstatWebsite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkHelpRInstatWebsite.LinkClicked
        Process.Start("http://r-instat.org/")
    End Sub

    Private Sub rowContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles rowContextMenuStrip.Opening
        mnuRemoveCurrentFilter.Enabled = GetCurrentDataFrameFocus().Filter.bApplied
    End Sub

    Private Sub cellContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles cellContextMenuStrip.Opening
        mnuLebelsLevel.Enabled = IsOnlyOneColumnSeleted() AndAlso IsOnlyOneColumnSeleted()
        mnuRemoveCurrentFilters.Enabled = GetCurrentDataFrameFocus().Filter.bApplied
    End Sub

    Private Sub mnuColumnAddComment_Click(sender As Object, e As EventArgs) Handles mnuColumnAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name, strColumn:=GetFirstSelectedColumnName)
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuBottomAddComment_Click(sender As Object, e As EventArgs) Handles mnuBottomAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name)
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        PasteValuesToDataFrame(GetSelectedColumns().Select(Function(x) x.Name), 1, False)
    End Sub

    '''' <summary>
    '''' event raised on menu toolstrip click
    '''' paste data starting from selected cells
    '''' </summary>
    '''' <param name="sender"></param>
    '''' <param name="e"></param>
    Private Sub mnuCellPasteRange_Click(sender As Object, e As EventArgs) Handles mnuCellPasteRange.Click
        '  Dim arrAllCurrentColumns As String()
        '  Dim lstSelectedColumnNames As New List(Of String)
        Dim iStartRowPos As Integer
        'get all columns of current selected data frame
        'arrAllCurrentColumns = GetCurrentWorkSheetColumnNames()
        ''get columns selected
        'For colIndex As Integer = grdData.CurrentWorksheet.SelectionRange.Col To grdData.CurrentWorksheet.SelectionRange.EndCol
        '    lstSelectedColumnNames.Add(arrAllCurrentColumns(colIndex))
        'Next
        'get starting row position then paste clipboard values
        iStartRowPos = Integer.Parse(grdData.CurrentWorksheet.RowHeaders.Item(grdData.CurrentWorksheet.SelectionRange.Row).Text)
        PasteValuesToDataFrame(GetSelectedColumnNames, iStartRowPos, False)
    End Sub

    ''' <summary>
    ''' pastes data from clipboard to data view
    ''' </summary>
    ''' <param name="lstColumnNames">column names to paste data into</param>
    ''' <param name="startRowPos">starting row position. This starts at postion 1</param>
    ''' <param name="firstClipRowHeader">flag indicating whether first row of clipboard data is a header</param>
    Private Sub PasteValuesToDataFrame(lstColumnNames As IEnumerable(Of String), startRowPos As String, firstClipRowHeader As Boolean)
        Dim clsPasteValues As New RFunction
        Dim strColNamesVec As String = ""
        Dim strClipBoardText As String = My.Computer.Clipboard.GetText

        If String.IsNullOrEmpty(strClipBoardText) Then
            MsgBox("No data available for pasting.", MsgBoxStyle.Information, "No Data")
            Exit Sub
        End If
        'warn user action cannot be undone
        If DialogResult.No = MsgBox("Are you sure you want to paste to these column(s)?" & Environment.NewLine &
                            "This action cannot be undone.", MessageBoxButtons.YesNo, "Paste Data") Then
            Exit Sub
        End If

        'construct R vector command for new row values
        For i As Integer = 0 To lstColumnNames.Count - 1
            strColNamesVec = strColNamesVec & Chr(34) & lstColumnNames(i) & Chr(34)
            If i = lstColumnNames.Count - 1 Then
                Exit For
            End If
            strColNamesVec = strColNamesVec & ", "
        Next
        strColNamesVec = "c(" & strColNamesVec & ")"

        'add R parameters and run the command
        clsPasteValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$paste_from_clipboard")
        clsPasteValues.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
        clsPasteValues.AddParameter("col_names", strColNamesVec)
        clsPasteValues.AddParameter("start_row_pos", startRowPos)
        clsPasteValues.AddParameter("first_clip_row_is_header", If(firstClipRowHeader, "TRUE", "FALSE"))
        clsPasteValues.AddParameter("clip_board_text", Chr(34) & strClipBoardText & Chr(34))
        RunScriptFromDataView(clsPasteValues.ToScript(), strComment:="Paste values in Data")
    End Sub

    Private Sub lblRowFirst_Click(sender As Object, e As EventArgs) Handles lblRowFirst.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadFirstRowPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowBack_Click(sender As Object, e As EventArgs) Handles lblRowBack.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadPreviousRowPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowNext_Click(sender As Object, e As EventArgs) Handles lblRowNext.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadNextRowPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblRowLast_Click(sender As Object, e As EventArgs) Handles lblRowLast.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadLastRowPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColFirst_Click(sender As Object, e As EventArgs) Handles lblColFirst.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadFirstColumnPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColBack_Click(sender As Object, e As EventArgs) Handles lblColBack.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadPreviousColumnPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub


    Private Sub lblColNext_Click(sender As Object, e As EventArgs) Handles lblColNext.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadNextColumnPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub

    Private Sub lblColLast_Click(sender As Object, e As EventArgs) Handles lblColLast.Click
        GetCurrentDataFrameFocus().VisiblePage.LoadLastColumnPage()
        UpdateCurrentWorksheet()
        RefreshWorksheet(grdData.CurrentWorksheet, GetCurrentDataFrameFocus())
    End Sub
    ''' <summary>
    ''' gets column names of current worksheet
    ''' </summary>
    ''' <returns>array of column names</returns>
    'Private Function GetCurrentWorkSheetColumnNames() As String()
    '    'get all columns of current selected data frame
    '    Return lstColumnNames.Find(Function(x) x.Key = grdData.CurrentWorksheet.Name).Value
    'End Function
End Class
