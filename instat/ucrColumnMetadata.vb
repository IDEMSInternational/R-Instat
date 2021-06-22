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

    'should not be public - testing only
    Public DataBook As clsDataBook

    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String
    Private lstNonEditableColumns As New List(Of String)

    Private strSignifFiguresLabel As String = "Signif_Figures"
    Private strNameLabel As String = "Name"
    Private strDataTypeLabel As String = "DataType"
    Private strLabelsLabel As String = "labels"
    Private strLabelsScientific As String = "Scientific"

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
        mnuInsertColsAfter.Visible = False
        mnuInsertColsBefore.Visible = False
    End Sub


    Private Function GetCurrentDataFrameFocus() As clsDataFrame
        Return DataBook.GetDataFrame(grdCurrSheet.Name)
    End Function

    Private Function GetCurrentColumnMetaDataFrameFocus() As clsColumnMetaData
        Return DataBook.GetColumnMetaData(grdCurrSheet.Name)
    End Function

    ''' <summary>
    ''' Run any R operation/command from the grid by passing a Function which will run the R operation/command.
    ''' This wrapper ensures consistency in what is done before and after running an R command.
    ''' </summary>
    ''' <param name="action">A function that will run an R operation/command, usually from GridROperations.</param>
    Private Sub RunRCommand(action As Action)
        Cursor = Cursors.WaitCursor
        grdVariables.Enabled = False
        action()
        grdVariables.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub RefreshWorksheet(fillWorkSheet As Worksheet, dataFrame As clsDataFrame)
        AddColumns(dataFrame, fillWorkSheet)
        AddRowData(dataFrame, fillWorkSheet)
        UpdateWorksheetStyle(fillWorkSheet)
    End Sub

    Private Sub AddColumns(dataFramePage As clsDataFrame, workSheet As Worksheet)
        Dim workSheetColumnHeader As ColumnHeader
        workSheet.Columns = dataFramePage.clsColumnMetaData.ColumnCount
        For i = 0 To dataFramePage.clsColumnMetaData.ColumnCount - 1
            workSheetColumnHeader = workSheet.ColumnHeaders(i)
            workSheetColumnHeader.Text = dataFramePage.clsColumnMetaData.ColumnName(i)
        Next
    End Sub

    Private Sub AddAndUpdateWorksheets(grid As ReoGridControl)
        Dim fillWorkSheet As Worksheet
        For Each clsDataFrame In DataBook.DataFrames
            fillWorkSheet = grid.Worksheets.Where(Function(x) x.Name = clsDataFrame.Name).FirstOrDefault
            If fillWorkSheet Is Nothing Then
                fillWorkSheet = grid.CreateWorksheet(clsDataFrame.Name)
                grid.AddWorksheet(fillWorkSheet)
            End If
            RefreshWorksheet(fillWorkSheet, clsDataFrame)
        Next

    End Sub

    Public Sub UpdateAllWorksheetStyles()
        For Each worksheet In grdVariables.Worksheets
            UpdateWorksheetStyle(worksheet)
        Next
    End Sub

    Private Sub UpdateWorksheetStyle(fillWorkSheet As Worksheet)
        fillWorkSheet.SetRangeStyles(RangePosition.EntireRange, New WorksheetRangeStyle() With {
                                .Flag = PlainStyleFlag.TextColor Or PlainStyleFlag.FontSize Or PlainStyleFlag.FontName,
                                .TextColor = frmMain.clsInstatOptions.clrEditor,
                                .FontSize = frmMain.clsInstatOptions.fntEditor.Size,
                                .FontName = frmMain.clsInstatOptions.fntEditor.Name
                                })
    End Sub

    Private Sub AddRowData(dataFrame As clsDataFrame, workSheet As Worksheet)
        Dim rngDataRange As RangePosition

        workSheet.Rows = dataFrame.clsColumnMetaData.RowCount
        rngDataRange = New RangePosition(0, 0, workSheet.Rows, workSheet.Columns)
        workSheet.SetRangeDataFormat(rngDataRange, DataFormat.CellDataFormatFlag.Text)

        For i = 0 To workSheet.Rows - 1
            For j = 0 To workSheet.Columns - 1
                workSheet(row:=i, col:=j) = dataFrame.clsColumnMetaData.Data(i, j)
            Next
            workSheet.RowHeaders.Item(i).Text = dataFrame.clsColumnMetaData.RowName(i)
        Next
    End Sub

    Public Sub RefreshGridData()
        If DataBook IsNot Nothing Then
            AddAndUpdateWorksheets(grdVariables)
            RemoveOldWorksheets(grdVariables)
        End If
    End Sub

    Private Sub RemoveOldWorksheets(grid As ReoGridControl)
        For i = grid.Worksheets.Count - 1 To 0 Step -1
            If DataBook.DataFrames.Where(Function(x) x.Name = grid.Worksheets(i).Name).Count = 0 Then
                grid.RemoveWorksheet(i)
            End If
        Next
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
        RunRCommand(Sub() GridROperations.ConvertToNumeric(grdCurrSheet.Name, GetSelectedVariableNamesAsArray, frmMain.clsRLink.GetDataFrameLength(grdCurrSheet.Name, False)))
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
        dlgSort.SetCurrentColumn(GetSelectedVariableNamesAsArray()(0), grdCurrSheet.Name)
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

    'Private Function GetSelectedDataFrameColumns() As List(Of clsColumnHeaderDisplay)
    '    Dim lstColumns As List(Of clsColumnHeaderDisplay) = New List(Of clsColumnHeaderDisplay)
    '    For i As Integer = grdVariables.CurrentWorksheet.SelectionRange.Col To grdVariables.CurrentWorksheet.SelectionRange.Col + grdVariables.CurrentWorksheet.SelectionRange.Cols - 1
    '        lstColumns.Add(GetCurrentDataFrameFocus().clsColumnMetaData..VisiblePage.lstColumns(i))
    '    Next
    '    Return lstColumns

    '    Dim lstSelectedVars As New List(Of String)

    '    For i As Integer = grdVariables.CurrentWorksheet.SelectionRange.Row To grdVariables.CurrentWorksheet.SelectionRange.Row + grdVariables.CurrentWorksheet.SelectionRange.Rows - 1
    '        lstSelectedVars.Add(grdVariables.CurrentWorksheet(i, 0))
    '    Next
    '    Return lstSelectedVars.ToArray

    'End Function
    Private Function GetSelectedDataFrameColumnNames() As List(Of String)
        Dim lstColumns As List(Of String) = New List(Of String)
        For i As Integer = grdVariables.CurrentWorksheet.SelectionRange.Row To grdVariables.CurrentWorksheet.SelectionRange.Row + grdVariables.CurrentWorksheet.SelectionRange.Rows - 1
            lstColumns.Add(grdVariables.CurrentWorksheet(i, 0))
        Next
        Return lstColumns

        '  Return GetSelectedDataFrameColumns().Select(Function(x) x.Name).ToList()
    End Function

    'Private Function GetFirstSelectedDataFrameColumnName() As String
    '    Return GetSelectedDataFrameColumns().FirstOrDefault().Name
    'End Function

    'Private Function GetLastSelectedDataFrameColumnName() As String
    '    Return GetSelectedDataFrameColumns().LastOrDefault().Name
    'End Function

    Private Function IsOnlyOneColumnSeleted() As Boolean
        Return grdVariables.CurrentWorksheet.SelectionRange.Cols = 1
    End Function
    Private Function IsFirstSelectedDataFrameColumnAFactor() As Boolean
        Return False 'GetSelectedDataFrameColumns().FirstOrDefault().IsFactor
    End Function


    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        StartWait()
        GetCurrentDataFrameFocus().clsPrepareFunctions.ConvertToOrderedFactor(GetSelectedDataFrameColumnNames())
        EndWait()
    End Sub

    Private Sub mnuDuplicateColumn_Click(sender As Object, e As EventArgs) Handles mnuDuplicateColumn.Click
        dlgDuplicateColumns.SetCurrentColumn(GetSelectedVariableNamesAsArray()(0), grdCurrSheet.Name)
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

    Private Function GetSelectedVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim lstSelectedVars As New List(Of String)
        Dim strVars As String
        Dim strRows As String = ""

        For i As Integer = grdVariables.CurrentWorksheet.SelectionRange.Row To grdVariables.CurrentWorksheet.SelectionRange.Row + grdVariables.CurrentWorksheet.SelectionRange.Rows - 1
            If bWithQuotes Then
                lstSelectedVars.Add(Chr(34) & grdVariables.CurrentWorksheet(i, 0) & Chr(34))
            Else
                lstSelectedVars.Add(grdVariables.CurrentWorksheet(i, 0))
            End If
        Next
        If lstSelectedVars.Count = 1 Then
            strVars = lstSelectedVars(0)
        Else
            strVars = "c(" & Join(lstSelectedVars.ToArray, ",") & ")"
        End If
        Return strVars
    End Function

    Private Function GetSelectedVariableNamesAsArray() As String()
        Dim lstSelectedVars As New List(Of String)

        For i As Integer = grdVariables.CurrentWorksheet.SelectionRange.Row To grdVariables.CurrentWorksheet.SelectionRange.Row + grdVariables.CurrentWorksheet.SelectionRange.Rows - 1
            lstSelectedVars.Add(grdVariables.CurrentWorksheet(i, 0))
        Next
        Return lstSelectedVars.ToArray
    End Function

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
        dlgName.SetCurrentColumn(GetSelectedVariableNamesAsArray()(0), grdCurrSheet.Name)
        dlgName.ShowDialog()
    End Sub

    Private Sub mnuConvert_Click(sender As Object, e As EventArgs)
        'TODO Selected column should automatically appear in dialog
        dlgConvertColumns.ShowDialog()
    End Sub

    Private Sub mnuLabelsLevels_Click(sender As Object, e As EventArgs) Handles mnuLevelsLabels.Click
        Dim strType As String
        Dim strColumns() As String

        strColumns = GetSelectedVariableNamesAsArray()
        If strColumns.Count = 1 Then
            strType = frmMain.clsRLink.GetColumnType(grdCurrSheet.Name, strColumns(0))
            If strType.Contains("factor") Then
                dlgLabelsLevels.SetCurrentColumn(strColumns(0), grdCurrSheet.Name)
            End If
        End If
        dlgLabelsLevels.ShowDialog()
    End Sub

    Private Sub columnContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles columnContextMenuStrip.Opening
        If IsOnlyOneColumnSeleted() Then
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
        mnuClearColumnFilter.Enabled = GetCurrentDataFrameFocus().Filter.bApplied
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
        DataBook.DataFrames.Where(Function(x) x.Name = grdCurrSheet.Name).FirstOrDefault.clsPrepareFunctions.AppendToVariablesMetadata(GetSelectedDataFrameColumnNames)
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
        DataBook.HideDataFrame(grdCurrSheet.Name)
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
        DataBook.DataFrames.Where(Function(x) x.Name = grdCurrSheet.Name).FirstOrDefault.clsPrepareFunctions.ViewDataFrame()
        EndWait()
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub statusColumnMenu_Opening(sender As Object, e As CancelEventArgs) Handles statusColumnMenu.Opening
        hideSheet.Enabled = (grdVariables.Worksheets.Count > 1)
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name, strColumn:=GetSelectedVariableNamesAsArray()(0))
        dlgAddComment.ShowDialog()
    End Sub

    Private Sub mnuBottomAddComment_Click(sender As Object, e As EventArgs) Handles mnuBottomAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name)
        dlgAddComment.ShowDialog()
    End Sub
End Class