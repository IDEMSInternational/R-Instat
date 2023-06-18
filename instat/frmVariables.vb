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

Public Class frmVariables
    'Public context As New frmEditor
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Close()
        End If
    End Sub

    Private Sub frmVariables_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadForm()
        frmMain.clsGrids.SetVariablesMetadata(grdVariables)
    End Sub

    Private Sub loadForm()
        grdVariables.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        'gridVariables.SheetTabNewButtonVisible = False
        'gridVariables.SheetTabControlNewButtonVisible = False
        'grdVariables.CurrentWorksheet.Resize(5, 5)
        'grdVariables.ColumnHeaderContextMenuStrip = context.grdData.ColumnHeaderContextMenuStrip
        'grdVariables.RowHeaderContextMenuStrip = context.grdData.RowHeaderContextMenuStrip
        'grdVariables.ContextMenuStrip = context.grdData.ContextMenuStrip
        autoTranslate(Me)
    End Sub

    Private Sub grdVariables_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdVariables.CurrentWorksheetChanged, Me.Load, grdVariables.WorksheetInserted
        grdCurrSheet = grdVariables.CurrentWorksheet
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        Dim strScript As String = ""
        Dim strComment As String = ""
        Dim strDecimalLabel As String = "DisplayDecimal"
        Dim strNameLabel As String = "Name"
        Dim strDataTypeLabel As String = "DataType"
        Dim strColumn = grdCurrSheet(e.Cell.Row, 0).ToString()
        Dim bRunScript As Boolean = False

        If grdCurrSheet.ColumnHeaders(e.Cell.Column).Text = strNameLabel Then
            strScript = frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data(data_name =" & Chr(34) & grdCurrSheet.Name & Chr(34) & ",column_name = " & Chr(34) & strPreviousCellText & Chr(34) & ",new_val=" & Chr(34) & e.NewData & Chr(34) & ")"
            strComment = "Renamed column"
            bRunScript = True
        ElseIf grdCurrSheet.ColumnHeaders(e.Cell.Column).Text = strDataTypeLabel Then
            If e.NewData.ToString() <> "factor" AndAlso e.NewData.ToString() <> "numeric" AndAlso e.NewData.ToString() <> "character" Then
                e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            Else
                strScript = frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type(data_name =" & Chr(34) & grdCurrSheet.Name & Chr(34) & ",col_names = " & Chr(34) & strColumn & Chr(34) & ",to_type=" & Chr(34) & e.NewData & Chr(34) & ")"
                strComment = "Converted column type"
                bRunScript = True
            End If
        ElseIf grdCurrSheet.ColumnHeaders(e.Cell.Column).Text = strDecimalLabel Then
            If Integer.TryParse(e.NewData, 0) AndAlso e.NewData >= 0 Then
                strScript = frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata(data_name =" & Chr(34) & grdCurrSheet.Name & Chr(34) & ",col_names = " & Chr(34) & strColumn & Chr(34) & ",property=" & Chr(34) & strDecimalLabel & Chr(34) & ",new_val=" & e.NewData & ")"
                strComment = "Edited variables metadata value"
                bRunScript = True
            Else
                e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            End If
        End If
        Try
            frmMain.clsRLink.RunScript(strScript, strComment:=strComment)
        Catch
            e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
        End Try
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        strPreviousCellText = e.Cell.Data.ToString()
    End Sub

    Private Sub frmVariables_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewColumnMetadata.Checked = Me.Visible
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

End Class