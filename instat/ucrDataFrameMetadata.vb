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

Imports System.Runtime.InteropServices
Imports instat.Translations
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class ucrDataFrameMetadata
    Private _clsDataBook As clsDataBook
    Private _grid As IDataframeMetaDataGrid
    Dim _strNameLabel As String = "data_name"

    '  Public WithEvents grdCurrSheet As unvell.ReoGrid.Worksheet
    Public strPreviousCellText As String
    Private lstNonEditableColumns As New List(Of String)
    Private clsHideDataFrame As New RFunction
    Private clsViewDataFrame As New RFunction
    Private clsGetDataFrame As New RFunction

    Public WriteOnly Property DataBook() As clsDataBook
        Set(ByVal value As clsDataBook)
            _clsDataBook = value
            _grid.DataBook = value
        End Set
    End Property

    Private Sub frmMetaData_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadForm()
        clsViewDataFrame.SetRCommand("View")
        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsHideDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata")
    End Sub

    Private Sub LoadForm()
        lstNonEditableColumns.AddRange({"class", "Is_Hidden", "Row_Count", "Column_Count", "Is_Linkable", "Is_Calculated"})

        'Debug
        'If True Then
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
        AddHandler _grid.EditValue, AddressOf EditValue

        _grid.SetContextmenuStrips(Nothing, cellContextMenuStrip, rowRightClickMenu, Nothing)
        _grid.SetupMainWorksheet("metadata")
    End Sub

    Private Sub StartWait()
        Cursor = Cursors.WaitCursor
        _grid.bEnabled = False
    End Sub

    Private Sub EndWait()
        _grid.bEnabled = True
        Cursor = Cursors.Default
    End Sub

    Private Sub RefreshWorksheet()
        If _clsDataBook Is Nothing Or _clsDataBook.DataFrames.Count = 0 Then
            Exit Sub
        End If
        _grid.AddColumns()
        _grid.AddRowData()
        _grid.UpdateAllWorksheetStyles()
    End Sub

    Public Sub RefreshGridData()
        If _clsDataBook?.clsDataFrameMetaData IsNot Nothing Then
            RefreshWorksheet()
            _grid.bVisible = _clsDataBook?.clsDataFrameMetaData.RowCount > 0
        End If
    End Sub

    Public Sub UpdateAllWorksheetStyles()
        _grid.UpdateAllWorksheetStyles()
    End Sub

    Private Sub EditValue(iRow As Integer, strColumnName As String, strPreviousValue As String, newValue As Object)
        Dim StrDataframeName As String
        Dim strScript As String
        Dim strComment As String
        Dim iTemp As Integer
        Dim strNewValue As String
        Dim strBooleanValsAllowed As String() = {"T", "TR", "TRU", "TRUE", "F", "FA", "FAL", "FALS", "FALSE"}

        StrDataframeName = _grid.GetCellValue(iRow, _strNameLabel)
        If StrDataframeName = "" Then
            MsgBox("Developer error: Cannot find Name column in column metadata grid.", MsgBoxStyle.Critical, "Cannot find Name column")
            Exit Sub
        End If
        If Decimal.TryParse(newValue, iTemp) Then
            strNewValue = newValue
        Else
            strNewValue = Chr(34) & newValue & Chr(34)
        End If

        If strColumnName = _strNameLabel Then
            If frmMain.clsRLink.IsValidText(newValue) Then
                If frmMain.clsRLink.GetDataFrameNames().Contains(newValue.ToString()) Then
                    MsgBox(newValue.ToString() & " is an existing data frame name.", MsgBoxStyle.Information, "Invalid Data Frame Name")
                    Exit Sub
                Else
                    strScript = frmMain.clsRLink.strInstatDataObject & "$rename_dataframe(data_name =" & Chr(34) & strPreviousCellText & Chr(34) &
                                    ", new_val = " & strNewValue & ")"
                    strComment = "Renamed data frame"
                End If
            Else
                MsgBox(newValue & " is not a valid data frame name.", MsgBoxStyle.Information, "Invalid Data Frame Name")
                Exit Sub
            End If
        Else
            strScript = frmMain.clsRLink.strInstatDataObject & "$append_to_dataframe_metadata(data_name =" & Chr(34) & StrDataframeName &
                                        Chr(34) & ", property = " & Chr(34) & strColumnName & Chr(34) & ", new_val = " & strNewValue & ")"
            strComment = "Edited data frame metadata value"
        End If
        Try
            RunScriptFromDataFrameMetadata(strScript, strComment:=strComment)
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

    Private Sub RunScriptFromDataFrameMetadata(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        StartWait()
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
        EndWait()
    End Sub

    Private Sub mnuHelp_Click(sender As Object, e As EventArgs) Handles mnuHelp.Click
        Help.ShowHelp(Me, frmMain.strStaticPath & "\" & frmMain.strHelpFilePath, HelpNavigator.TopicId, "544")
    End Sub

    Private Function GetSelectedDataframeNameFromSelectedRow() As String
        Return _grid.GetCellValue(_grid.GetSelectedRows(0) - 1, _strNameLabel)
    End Function

    Private Sub deleteDataFrame_Click(sender As Object, e As EventArgs) Handles deleteDataFrame.Click
        dlgDeleteDataFrames.SetDataFrameToAdd(GetSelectedDataframeNameFromSelectedRow)
        dlgDeleteDataFrames.ShowDialog()
    End Sub

    Private Sub renameSheet_Click(sender As Object, e As EventArgs) Handles renameSheet.Click
        dlgRenameDataFrame.SetCurrentDataframe(GetSelectedDataframeNameFromSelectedRow)
        dlgRenameDataFrame.ShowDialog()
    End Sub

    Private Sub hideSheet_Click(sender As Object, e As EventArgs) Handles hideSheet.Click
        clsHideDataFrame.AddParameter("data_name", Chr(34) & GetSelectedDataframeNameFromSelectedRow() & Chr(34), iPosition:=0)
        clsHideDataFrame.AddParameter("property", "is_hidden_label", iPosition:=1)
        clsHideDataFrame.AddParameter("new_val", "TRUE", iPosition:=2)
        RunScriptFromDataFrameMetadata(clsHideDataFrame.ToScript(), strComment:="Right click menu: Hide Data Frame")
    End Sub

    Private Sub unhideSheet_Click(sender As Object, e As EventArgs) Handles unhideSheet.Click
        dlgHideDataframes.ShowDialog()
    End Sub

    Private Sub copySheet_Click(sender As Object, e As EventArgs) Handles copySheet.Click
        dlgCopyDataFrame.SetCurrentDataframe(GetSelectedDataframeNameFromSelectedRow)
        dlgCopyDataFrame.ShowDialog()
    End Sub

    Private Sub viewSheet_Click(sender As Object, e As EventArgs) Handles viewSheet.Click
        Dim strScript As String = ""
        Dim strTemp As String
        clsGetDataFrame.AddParameter("data_name", Chr(34) & GetSelectedDataframeNameFromSelectedRow() & Chr(34), iPosition:=0)
        clsViewDataFrame.AddParameter("x", clsRFunctionParameter:=clsGetDataFrame, iPosition:=0)
        clsGetDataFrame.SetAssignTo(GetSelectedDataframeNameFromSelectedRow)
        strTemp = clsViewDataFrame.ToScript(strScript)
        RunScriptFromDataFrameMetadata(strScript & strTemp, strComment:="Right click menu: View R Data Frame", bSeparateThread:=False)
    End Sub

    Private Sub reorderSheet_Click(sender As Object, e As EventArgs) Handles reorderSheet.Click
        dlgReorderDataFrame.ShowDialog()
    End Sub

    Private Sub rowRightClickMenu_Opening(sender As Object, e As EventArgs) Handles rowRightClickMenu.Opening
        hideSheet.Enabled = (_clsDataBook.DataFrames.Count > 1)
    End Sub

    Private Sub mnuAddComment_Click(sender As Object, e As EventArgs) Handles mnuAddComment.Click
        dlgAddComment.SetPosition(strDataFrame:=_grid.CurrentWorksheet.Name)
        dlgAddComment.ShowDialog()
    End Sub
End Class