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

Public Class frmMetaData
    Public context As New frmEditor
    Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String

    Private Sub frmMetaData_Load(sender As Object, e As EventArgs) Handles Me.Load
        grdMetaData.Worksheets(0).Name = "metadata"
        frmMain.clsGrids.SetMetadata(grdMetaData)
        Me.SizeGripStyle = SizeGripStyle.Auto
        loadForm()
        autoTranslate(Me)
    End Sub

    ' TODO this needs tidying up
    Private Sub loadForm()
        grdMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        grdMetaData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowHorScroll, False)
        grdMetaData.SheetTabNewButtonVisible = False
        grdMetaData.ColumnHeaderContextMenuStrip = context.grdData.ColumnHeaderContextMenuStrip
        grdMetaData.ContextMenuStrip = context.grdData.ContextMenuStrip
        grdMetaData.RowHeaderContextMenuStrip = context.grdData.RowHeaderContextMenuStrip
    End Sub

    'TODO interesting code here - should be discussed and possibly used elsewhere
    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)
        If Not e.Cancel AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Me.Close()
        End If
    End Sub

    Private Sub grdMetaData_CurrentWorksheetChanged(sender As Object, e As EventArgs) Handles grdMetaData.CurrentWorksheetChanged, Me.Load, grdMetaData.WorksheetInserted
        grdCurrSheet = grdMetaData.CurrentWorksheet
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        grdCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrSheet.BeforeCellEdit
        'strPreviousCellText = e.Cell.Data.ToString()
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrSheet.AfterCellEdit
        Dim strScript As String = ""
        Dim strComment As String = ""
        Dim bRunScript As Boolean = False

        If e.Cell.Column = 0 Then
            'TODO fix bug with this not updating grid correctly after renaming
            'strScript = frmMain.clsRLink.strInstatDataObject & "$rename_dataframe(data_name =" & Chr(34) & strPreviousCellText & Chr(34) & ", new_val = " & Chr(34) & e.NewData & Chr(34) & ")"
            'strComment = "Renamed sheet"
        Else
            strScript = frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata(data_name =" & Chr(34) & grdCurrSheet(e.Cell.Row, 0).ToString() & Chr(34) & ", property = " & Chr(34) & grdCurrSheet.ColumnHeaders(e.Cell.Column).Text & "new_value = " & Chr(34) & e.NewData & Chr(34) & ")"
            strComment = "Changed metadata value"
            bRunScript = True
        End If
        If bRunScript Then
            Try
                frmMain.clsRLink.RunScript(strScript, strComment:=strComment)
            Catch
                e.EndReason = unvell.ReoGrid.EndEditReason.Cancel
            End Try
        End If
    End Sub

    Private Sub frmMetaData_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        frmMain.mnuViewDataFrameMetadata.Checked = Me.Visible
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