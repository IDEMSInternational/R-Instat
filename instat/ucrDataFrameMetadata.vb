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

Imports instat.Translations
Imports unvell.ReoGrid.Events

Public Class ucrDataFrameMetadata
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String
    Private lstNonEditableColumns As New List(Of String)
    Private clsHideDataFrame As New RFunction
    Private clsViewDataFrame As New RFunction
    Private clsGetDataFrame As New RFunction

    Private Sub frmMetaData_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadForm()
        clsViewDataFrame.SetRCommand("View")
        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsHideDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata")
    End Sub

    ' TODO this needs tidying up
    Private Sub LoadForm()
        lstNonEditableColumns.AddRange({"class", "Is_Hidden", "Row_Count", "Column_Count", "Is_Linkable", "Is_Calculated"})
        grdMetaData.Worksheets(0).Name = "metadata"
        grdMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, True)
        grdMetaData.SheetTabNewButtonVisible = False
    End Sub

    Private Sub grdMetaData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdMetaData.CurrentWorksheetChanged, Me.Load, grdMetaData.WorksheetInserted
        grdCurrSheet = grdMetaData.CurrentWorksheet
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        If lstNonEditableColumns.Contains(grdCurrSheet.ColumnHeaders(e.Cell.Column).Text) OrElse grdCurrSheet.ColumnHeaders(e.Cell.Column).Text.Substring(0, 3) = "key" Then
            e.IsCancelled = True
        Else
            strPreviousCellText = e.Cell.Data.ToString()
        End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        Dim strScript As String = ""
        Dim strComment As String = ""
        Dim strSignifFiguresLabel As String = "Signif_Figures"
        Dim strNameLabel As String = "data_name"
        Dim strDataTypeLabel As String = "DataType"
        Dim strProperty As String = grdCurrSheet.ColumnHeaders(e.Cell.Column).Text
        Dim strDataName As String
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
            strDataName = grdCurrSheet(e.Cell.Row, iNameColumn).ToString()
            If Decimal.TryParse(e.NewData, iTemp) Then
                strNewValue = e.NewData
            Else
                strNewValue = Chr(34) & e.NewData & Chr(34)
            End If
            If strProperty = strNameLabel Then
                If frmMain.clsRLink.IsValidText(e.NewData) Then
                    If frmMain.clsRLink.GetDataFrameNames().Contains(e.NewData.ToString()) Then
                        MsgBox(e.NewData.ToString() & " is an existing data frame name.", MsgBoxStyle.Information, "Invalid Data Frame Name")
                        e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                        Exit Sub
                    Else
                        strScript = frmMain.clsRLink.strInstatDataObject & "$rename_dataframe(data_name =" & Chr(34) & strPreviousCellText & Chr(34) & ", new_val = " & strNewValue & ")"
                        strComment = "Renamed data frame"
                    End If
                Else
                    MsgBox(e.NewData & " is not a valid data frame name.", MsgBoxStyle.Information, "Invalid Data Frame Name")
                    e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
                    Exit Sub
                End If
            Else
                strScript = frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata(data_name =" & Chr(34) & strDataName & Chr(34) & ", property = " & Chr(34) & strProperty & Chr(34) & ", new_val = " & strNewValue & ")"
                strComment = "Edited data frame metadata value"
            End If
            Try
                RunScriptFromDataFrameMetadata(strScript, strComment:=strComment)
            Catch
                e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            End Try
        Else
            MsgBox("Developer error: Cannot find Name column in data frame metadata grid.", MsgBoxStyle.Critical, "Canont find Name column")
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
            grdMetaData.CurrentWorksheet.Copy()

            Dim clsCopyValues As New RFunction
            Dim strAllContent As String = ""
            Dim iEndRow As Integer = grdMetaData.CurrentWorksheet.SelectionRange.EndRow
            Dim iEndCol As Integer = grdMetaData.CurrentWorksheet.SelectionRange.EndCol
            Dim iStartCol As Integer = grdMetaData.CurrentWorksheet.SelectionRange.Col

            'construct the copied range data
            For iRowIndex As Integer = grdMetaData.CurrentWorksheet.SelectionRange.Row To iEndRow
                Dim strRowContent As String = ""
                For iColIndex As Integer = iStartCol To iEndCol
                    Dim strCellContent As String = grdMetaData.CurrentWorksheet.GetCell(row:=iRowIndex, col:=iColIndex).DisplayText
                    If strCellContent = "NA" Then
                        strCellContent = ""
                    End If
                    If iColIndex = iStartCol Then
                        strRowContent = strCellContent
                    Else
                        strRowContent &= vbTab & strCellContent
                    End If
                Next
                strAllContent &= strRowContent
                If iRowIndex < iEndRow Then
                    strAllContent &= Environment.NewLine
                End If
            Next

            clsCopyValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$copy_to_clipboard")
            clsCopyValues.AddParameter("content", Chr(34) & strAllContent & Chr(34), iPosition:=0)
            RunScriptFromDataFrameMetadata(clsCopyValues.ToScript(), strComment:="Copy data frame metadata values to clipboard")
        Catch
            MessageBox.Show("Cannot copy the current selection.")
        End Try
    End Sub

    Public Sub SelectAllText()
        If grdCurrSheet IsNot Nothing Then
            grdCurrSheet.SelectAll()
        End If
    End Sub

    Private Sub RunScriptFromDataFrameMetadata(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        Cursor = Cursors.WaitCursor
        grdMetaData.Enabled = False
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        grdMetaData.Enabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "544")
    End Sub

    Private Function GetSelectedVariableNamesAsArray() As String()
        Dim arrSelectedVars(grdMetaData.CurrentWorksheet.SelectionRange.Rows - 1) As String

        For i As Integer = grdMetaData.CurrentWorksheet.SelectionRange.Row To grdMetaData.CurrentWorksheet.SelectionRange.Row + grdMetaData.CurrentWorksheet.SelectionRange.Rows - 1
            arrSelectedVars(i - grdMetaData.CurrentWorksheet.SelectionRange.Row) = grdMetaData.CurrentWorksheet(i, 0)
        Next
        Return arrSelectedVars
    End Function

    Private Sub deleteDataFrame_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(GetSelectedVariableNamesAsArray(0))
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(GetSelectedVariableNamesAsArray(0))
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub hideSheet_Click(sender As Object, e As EventArgs) Handles hideSheet.Click
        clsHideDataFrame.AddParameter("data_name", Chr(34) & GetSelectedVariableNamesAsArray(0) & Chr(34), iPosition:=0)
        clsHideDataFrame.AddParameter("property", "is_hidden_label", iPosition:=1)
        clsHideDataFrame.AddParameter("new_val", "TRUE", iPosition:=2)
        RunScriptFromDataFrameMetadata(clsHideDataFrame.ToScript(), strComment:="Right click menu: Hide Data Frame")
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub copySheet_Click(sender As Object, e As EventArgs) Handles copySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(GetSelectedVariableNamesAsArray(0))
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub viewSheet_Click(sender As Object, e As EventArgs) Handles viewSheet.Click
        Dim strScript As String = ""
        Dim strTemp As String
        clsGetDataFrame.AddParameter("data_name", Chr(34) & GetSelectedVariableNamesAsArray(0) & Chr(34), iPosition:=0)
        clsViewDataFrame.AddParameter("x", clsRFunctionParameter:=clsGetDataFrame, iPosition:=0)
        clsGetDataFrame.SetAssignTo(GetSelectedVariableNamesAsArray(0))
        strTemp = clsViewDataFrame.ToScript(strScript)
        RunScriptFromDataFrameMetadata(strScript & strTemp, strComment:="Right click menu: View R Data Frame", bSeparateThread:=False)
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub rowRightClickMenu_Opening(sender As Object, e As EventArgs) Handles rowRightClickMenu.Opening
        hideSheet.Enabled = (grdMetaData.CurrentWorksheet.RowCount > 1)
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=grdCurrSheet.Name)
        dlgAddComment.ShowDialog()
    End Sub
End Class