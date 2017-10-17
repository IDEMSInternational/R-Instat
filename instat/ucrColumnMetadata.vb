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

Public Class ucrColumnMetadata
    Private clsUnhideAllColumns As New RFunction
    Private clsInsertColumns As New RFunction
    Private clsColumnNames As New RFunction
    Public lstColumnNames As New List(Of KeyValuePair(Of String, String()))
    Private clsDeleteColumns As New RFunction
    Private clsConvertTo As New RFunction
    Public lstRowsNames As New List(Of KeyValuePair(Of String, String()))
    Private clsRemoveFilter As New RFunction
    Private clsFreezeColumns As New RFunction
    Private clsUnfreezeColumns As New RFunction
    Private clsConvertOrderedFactor As New RFunction
    Private clsAppendVariablesMetaData As New RFunction
    'Public context As New frmEditor
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String
    Private lstNonEditableColumns As New List(Of String)

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
        SetRFunctions()
        mnuFreezeToHere.Enabled = False
        mnuUnfreeze.Enabled = False
        mnuInsertColsAfter.Enabled = False
        mnuInsertColsBefore.Enabled = False
        '  grdVariables.RowHeaderContextMenuStrip = frmMain.ucrDataViewer.grdData.ColumnHeaderContextMenuStrip
    End Sub

    Private Sub SetRFunctions()
        clsAppendVariablesMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsColumnNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
        clsInsertColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsDeleteColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
        clsConvertTo.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsUnhideAllColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$unhide_all_columns")
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsFreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$freeze_columns")
        clsUnfreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$unfreeze_columns")
        clsConvertOrderedFactor.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
    End Sub


    Private Sub loadForm()
        grdVariables.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        grdVariables.SheetTabNewButtonVisible = False
        grdVariables.SheetTabWidth = 250
        lstNonEditableColumns.AddRange({"class", "Is_Hidden", "Is_Key", "Is_Calculated", "Has_Dependants", "Dependent_Columns", "Calculated_By", "Dependencies", "Colour", "Scientific"})
        'grdVariables.CurrentWorksheet.Resize(5, 5)
        'grdVariables.ColumnHeaderContextMenuStrip = context.grdData.ColumnHeaderContextMenuStrip
        'grdVariables.RowHeaderContextMenuStrip = context.grdData.RowHeaderContextMenuStrip
        'grdVariables.ContextMenuStrip = context.grdData.ContextMenuStrip
        'autoTranslate(Me)
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
        Dim strSignifFiguresLabel As String = "Signif_Figures"
        Dim strNameLabel As String = "Name"
        Dim strDataTypeLabel As String = "DataType"
        Dim strProperty As String = grdCurrSheet.ColumnHeaders(e.Cell.Column).Text
        Dim strColumn As String
        Dim iTemp As Integer
        Dim iNameColumn As Integer = -1
        Dim strNewValue As String

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
            MsgBox("Developer error: Cannot find Name column in column metadata grid.", MsgBoxStyle.Critical, "Canont find Name column")
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
            UpdateRFunctionDataFrameParameters()
            grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        End If
    End Sub

    Private Sub mnuConvertVariate_Click(sender As Object, e As EventArgs) Handles mnuConvertVariate.Click
        clsConvertTo.AddParameter("to_type", Chr(34) & "numeric" & Chr(34))
        clsConvertTo.AddParameter("col_names", GetSelectedVariableNames())
        RunScriptFromColumnMetadata(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Numeric")
    End Sub

    Private Sub mnuConvertText_Click(sender As Object, e As EventArgs) Handles mnuConvertText.Click
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34))
        clsConvertTo.AddParameter("col_names", GetSelectedVariableNames())
        RunScriptFromColumnMetadata(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    Private Sub mnuConvertToLogical_Click(sender As Object, e As EventArgs) Handles mnuConvertToLogical.Click
        clsConvertTo.AddParameter("to_type", Chr(34) & "logical" & Chr(34))
        clsConvertTo.AddParameter("col_names", GetSelectedVariableNames())
        RunScriptFromColumnMetadata(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Logical")
    End Sub

    Private Sub mnuClearColumnFilter_Click(sender As Object, e As EventArgs) Handles mnuClearColumnFilter.Click
        RunScriptFromColumnMetadata(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Private Sub mnuSort_Click(sender As Object, e As EventArgs) Handles mnuSort.Click
        dlgSort.SetCurrentColumn(GetSelectedVariableNamesAsArray()(0), grdCurrSheet.Name)
        dlgSort.ShowDialog()
    End Sub

    'Private Sub mnuConvertDate_Click(sender As Object, e As EventArgs)
    '    dlgMakeDate.SetCurrentColumn(GetSelectedVariableNamesAsArray()(0), grdCurrSheet.Name)
    '    dlgMakeDate.ShowDialog()
    'End Sub

    Private Sub mnuCovertToOrderedFactors_Click(sender As Object, e As EventArgs) Handles mnuCovertToOrderedFactors.Click
        clsConvertOrderedFactor.AddParameter("col_names", GetSelectedVariableNames())
        clsConvertOrderedFactor.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34))
        RunScriptFromColumnMetadata(clsConvertOrderedFactor.ToScript, strComment:="Right Click Menu: Convert to Ordered Factor")
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
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
        clsConvertTo.AddParameter("col_names", GetSelectedVariableNames())
        RunScriptFromColumnMetadata(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Factor")
    End Sub

    'Private Sub mnuUnhideAllColumns_Click(sender As Object, e As EventArgs)
    '    RunScriptFromColumnMetadata(clsUnhideAllColumns.ToScript(), strComment:="Right click menu: Unhide all columns")
    'End Sub

    'Private Sub mnuUnhideColumns_Click(sender As Object, e As EventArgs)
    '    dlgHideShowColumns.ShowDialog()
    '    'grdData.DoAction(New unvell.ReoGrid.Actions.UnhideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    'End Sub

    'Private Sub mnuHideColumns_Click(sender As Object, e As EventArgs)
    '    clsAppendVariablesMetaData.AddParameter("col_names", GetSelectedVariableNames())
    '    clsAppendVariablesMetaData.AddParameter("property", "is_hidden_label")
    '    clsAppendVariablesMetaData.AddParameter("new_val", "TRUE")
    '    RunScriptFromColumnMetadata(clsAppendVariablesMetaData.ToScript(), strComment:="Right click menu: Hide column(s)" & GetSelectedVariableNames())
    '    'grdData.DoAction(New unvell.ReoGrid.Actions.HideColumnsAction(grdData.CurrentWorksheet.SelectionRange.Col, grdData.CurrentWorksheet.SelectionRange.Cols))
    'End Sub

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

    Private Sub UpdateRFunctionDataFrameParameters()
        If grdCurrSheet IsNot Nothing Then
            clsAppendVariablesMetaData.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsColumnNames.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsInsertColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsDeleteColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsConvertTo.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsUnhideAllColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsRemoveFilter.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsFreezeColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsUnfreezeColumns.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            'clsGetDataFrame.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
            clsConvertOrderedFactor.AddParameter("data_name", Chr(34) & grdCurrSheet.Name & Chr(34))
        End If
    End Sub

    Private Function SelectedRowsAsArray() As String()
        Dim strSelectedRows As String()
        Dim lstCurrentDataRows As String()

        lstCurrentDataRows = lstRowsNames.Find(Function(x) x.Key = grdVariables.CurrentWorksheet.Name).Value

        If lstRowsNames IsNot Nothing AndAlso lstRowsNames.Count > 0 Then
            strSelectedRows = New String(grdVariables.CurrentWorksheet.SelectionRange.Rows - 1) {}
            For i As Integer = 0 To grdVariables.CurrentWorksheet.SelectionRange.Rows - 1
                strSelectedRows(i) = lstCurrentDataRows(i + grdVariables.CurrentWorksheet.SelectionRange.Col)
            Next
            Return strSelectedRows
        Else
            strSelectedRows = New String() {}
        End If
        Return strSelectedRows
    End Function

    Private Sub mnuDeleteCol_Click(sender As Object, e As EventArgs) Handles mnuDeleteCol.Click
        If grdVariables.CurrentWorksheet.SelectionRange.Rows = grdVariables.CurrentWorksheet.RowCount Then
            MsgBox("Cannot delete all visible columns." & Environment.NewLine & "Use Prepare > Data Object > Delete Data Frame if you wish to delete the data.", MsgBoxStyle.Information, "Cannot Delete All Columns")
        Else
            Dim deleteCol = MsgBox("Are you sure you want to delete these column(s)?" & Environment.NewLine & "This action cannot be undone.", MessageBoxButtons.YesNo, "Delete Column")
            If deleteCol = DialogResult.Yes Then
                clsDeleteColumns.AddParameter("cols", GetSelectedVariableNames())
                RunScriptFromColumnMetadata(clsDeleteColumns.ToScript(), strComment:="Right click menu: Delete Column(s)")
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
        Dim iSelectedCols As Integer
        Dim strType As String
        Dim strColumns() As String

        iSelectedCols = grdVariables.CurrentWorksheet.SelectionRange.Rows
        strColumns = GetSelectedVariableNamesAsArray()

        If iSelectedCols = 1 Then
            strType = frmMain.clsRLink.GetColumnType(grdCurrSheet.Name, strColumns(0))
            mnuLevelsLabels.Enabled = (strType.Contains("factor"))
            mnuDeleteCol.Text = "Delete Column"
            mnuInsertColsBefore.Text = "Insert 1 Column Before"
            mnuInsertColsAfter.Text = "Insert 1 Column After"
        Else
            mnuLevelsLabels.Enabled = False
            mnuDeleteCol.Text = "Delete Columns"
            mnuInsertColsBefore.Text = "Insert " & iSelectedCols & " Columns Before"
            mnuInsertColsAfter.Text = "Insert " & iSelectedCols & " Columns After"
        End If
    End Sub
End Class