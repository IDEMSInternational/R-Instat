' Instat-R
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

Imports instat
Imports RDotNet
Imports unvell.ReoGrid.CellTypes
Imports unvell.ReoGrid.Events
Imports unvell.ReoGrid

Public Class ucrFactor
    Public Event SelectedLevelChanged()
    Public Event GridContentChanged()
    Public Event GridVisibleChanged()
    Public WithEvents clsReceiver As ucrReceiverSingle
    Public WithEvents shtCurrSheet As unvell.ReoGrid.Worksheet
    Public bIsSelector As Boolean
    Public bIsMultipleSelector As Boolean
    Public bIsGridColumn As Boolean
    Public strColumnToGet As String
    Public iSelectorColumnIndex As Integer
    Public strSelectorColumnName As String
    Private bIsEditable As Boolean
    Private lstEditableColumns As List(Of String)
    Public bIncludeCopyOfLevels As Boolean
    Public strExtraColumn As String = ""
    Public strSelectedLevels As String()
    Public WithEvents ucrChkLevels As ucrCheck
    Public bForceShowLevels As Boolean
    Public bIncludeLevels As Boolean
    Public strLevelsName As String
    Public strLabelsName As String
    Public strFreqName As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bIsSelector = False
        bIsMultipleSelector = False
        bIsGridColumn = False
        strColumnToGet = ""
        iSelectorColumnIndex = -1
        strSelectorColumnName = "Select Level"
        bIsEditable = False
        lstEditableColumns = New List(Of String)
        bIncludeCopyOfLevels = False
        bForceShowLevels = False
        bIncludeLevels = True
        strLevelsName = "Level"
        strLabelsName = "Label"
        strFreqName = "Freq"
    End Sub

    Private Sub ucrFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdFactorData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
        RefreshFactorData()
    End Sub

    Public Sub SetReceiver(clsNewReceiver As ucrReceiverSingle)
        clsReceiver = clsNewReceiver
        If ucrChkLevels IsNot Nothing Then
            ucrChkLevels.Enabled = Not clsReceiver.IsEmpty
        End If
        RefreshFactorData()
    End Sub

    Public Sub AddEditableColumns(strColumns As String())
        lstEditableColumns.AddRange(strColumns)
        ApplyColumnSettings()
    End Sub

    Public Sub SetAsSingleSelector()
        bIsSelector = True
        bIsMultipleSelector = False
        bIsGridColumn = False
        RefreshFactorData()
    End Sub

    Public Sub SetAsMultipleSelector()
        bIsSelector = True
        bIsMultipleSelector = True
        bIsGridColumn = False
        RefreshFactorData()
    End Sub

    Public Sub SetIsGridColumn(strColumnName As String)
        bIsSelector = False
        bIsMultipleSelector = False
        bIsGridColumn = True
        strColumnToGet = strColumnName
        RefreshFactorData()
    End Sub

    Public Sub SetAsViewerOnly()
        bIsSelector = False
        bIsMultipleSelector = False
        RefreshFactorData()
    End Sub

    Public Sub SetEditableStatus(bEditable As Boolean)
        bIsEditable = bEditable
        If shtCurrSheet IsNot Nothing Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, Not bEditable)
        End If
    End Sub

    Public Sub SetSelectorColumnName(strNewColumnName As String)
        strSelectorColumnName = strNewColumnName
        If iSelectorColumnIndex <> -1 Then
            shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
        Else
            RefreshFactorData()
        End If
    End Sub

    Private Sub RefreshFactorData()
        Dim dfTemp As DataFrame
        Dim bShowGrid As Boolean = False
        Dim clsGetFactorData As New RFunction
        Dim clsConvertToCharacter As New RFunction
        Dim bHasLevels As Boolean
        Dim iLevelsCol As Integer
        Dim iLabelsCol As Integer
        Dim iFreqCol As Integer
        Dim strColType As String

        grdFactorData.Worksheets.Clear()
        ' Contains allows ordered factors to be included
        If clsReceiver IsNot Nothing AndAlso Not clsReceiver.IsEmpty() Then
            strColType = frmMain.clsRLink.GetColumnType(clsReceiver.GetDataName(), clsReceiver.GetVariableNames(False))
            If strColType = "" Then
                clsReceiver.Clear()
            ElseIf strColType.Contains("factor") Then
                clsGetFactorData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_factor_data_frame")
                clsGetFactorData.AddParameter("data_name", Chr(34) & clsReceiver.GetDataName() & Chr(34))
                clsGetFactorData.AddParameter("col_name", clsReceiver.GetVariableNames())
                If bIncludeLevels Then
                    clsGetFactorData.AddParameter("include_levels", "TRUE")
                Else
                    clsGetFactorData.AddParameter("include_levels", "FALSE")
                End If
                clsConvertToCharacter.SetRCommand("convert_to_character_matrix")
                clsConvertToCharacter.AddParameter("data", clsRFunctionParameter:=clsGetFactorData)
                dfTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsConvertToCharacter.ToScript()).AsDataFrame
                frmMain.clsGrids.FillSheet(dfTemp, "Factor Data", grdFactorData)
                shtCurrSheet = grdFactorData.CurrentWorksheet
                shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
                bShowGrid = True
                shtCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
                iLevelsCol = GetColumnIndex(strLevelsName)
                iLabelsCol = GetColumnIndex(strLabelsName)
                iFreqCol = GetColumnIndex(strFreqName)
                If bIncludeCopyOfLevels Then
                    shtCurrSheet.AppendCols(1)
                    shtCurrSheet.ColumnHeaders(shtCurrSheet.ColumnCount - 1).Text = "New Label"
                    For i = 0 To shtCurrSheet.RowCount - 1
                        shtCurrSheet(i, shtCurrSheet.ColumnCount - 1) = shtCurrSheet(i, iLabelsCol)
                    Next
                End If
                If strExtraColumn <> "" Then
                    shtCurrSheet.AppendCols(1)
                    shtCurrSheet.ColumnHeaders(shtCurrSheet.ColumnCount - 1).Text = strExtraColumn
                End If
                If bIsSelector Then
                    iSelectorColumnIndex = shtCurrSheet.ColumnCount
                    shtCurrSheet.AppendCols(1)
                    If bIsMultipleSelector Then
                        shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).DefaultCellBody = GetType(CheckBoxCell)
                        shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
                        InitialiseSelected()
                    Else
                        shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
                        shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).DefaultCellBody = GetType(RadioButtonCell)
                        InitialiseSelected()
                        Dim rgpselectcolumn As New RadioButtonGroup
                        For i = 0 To shtCurrSheet.RowCount - 1
                            Dim rdotemp As New RadioButtonCell
                            rdotemp.RadioGroup = rgpselectcolumn
                            shtCurrSheet(i, iSelectorColumnIndex) = rdotemp
                        Next
                    End If
                End If
            End If
        Else
            shtCurrSheet = Nothing
            iSelectorColumnIndex = -1
        End If
        grdFactorData.Visible = bShowGrid
        If shtCurrSheet IsNot Nothing Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, Not bIsEditable)
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.View_ShowRowHeader, False)
            shtCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
            shtCurrSheet.ColumnHeaders(0).Width = 30
            If iLevelsCol <> -1 Then
                shtCurrSheet.ColumnHeaders(iLevelsCol).Width = 40
            End If
            If iFreqCol <> -1 Then
                shtCurrSheet.ColumnHeaders(iFreqCol).Width = 40
            End If
            ApplyColumnSettings()
            RaiseEvent GridContentChanged()
            If ucrChkLevels IsNot Nothing Then
                ucrChkLevels.Enabled = True
                ucrChkLevels.Checked = False
            End If
            If Not bForceShowLevels Then
                If iLevelsCol <> -1 Then
                    bHasLevels = frmMain.clsRLink.IsVariablesMetadata(clsReceiver.GetDataName(), "labels", clsReceiver.GetVariableNames(False))
                    If bHasLevels Then
                        If ucrChkLevels IsNot Nothing Then
                            ucrChkLevels.Enabled = False
                            ucrChkLevels.Checked = True
                        End If
                    Else
                        shtCurrSheet.HideColumns(iLevelsCol, 1)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ApplyColumnSettings()
        Dim lstColNumber As New List(Of Integer)
        Dim bIsReadOnly As Boolean

        If shtCurrSheet IsNot Nothing AndAlso lstEditableColumns IsNot Nothing AndAlso lstEditableColumns.Count > 0 Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, False)
            For i = 0 To shtCurrSheet.ColumnCount - 1
                bIsReadOnly = Not lstEditableColumns.Contains(shtCurrSheet.ColumnHeaders(i).Text)
                For j = 0 To shtCurrSheet.RowCount - 1
                    shtCurrSheet.Cells(j, i).IsReadOnly = bIsReadOnly
                Next
            Next
        End If
    End Sub

    Private Sub clsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles clsReceiver.SelectionChanged
        RefreshFactorData()
    End Sub

    Private Sub InitialiseSelected()
        'sets the default as the reference level (always first level)
        'TODO are there other initial selections needed?
        Dim i As Integer
        Dim bSelect As Boolean

        If iSelectorColumnIndex <> -1 Then
            For i = 0 To shtCurrSheet.RowCount - 1
                If strSelectedLevels IsNot Nothing AndAlso strSelectedLevels.Count > 0 Then
                    bSelect = strSelectedLevels.Contains(shtCurrSheet(i, 0))
                Else
                    bSelect = (i = 0)
                End If
                shtCurrSheet(i, iSelectorColumnIndex) = bSelect
            Next
        End If
        strSelectedLevels = Nothing
    End Sub

    Public Sub AddLevel()
        Dim i As Integer
        Dim iNewRow As Integer

        If grdFactorData.CurrentWorksheet IsNot Nothing AndAlso shtCurrSheet IsNot Nothing Then
            shtCurrSheet.AppendRows(1)
            iNewRow = shtCurrSheet.RowCount - 1
            For i = 0 To shtCurrSheet.ColumnCount - 1
                If shtCurrSheet.ColumnHeaders(i).Text = "Ord." Then
                    shtCurrSheet(iNewRow, i) = shtCurrSheet.RowCount
                    shtCurrSheet.SetRangeDataFormat(iNewRow, i, 1, 1, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)
                ElseIf shtCurrSheet.ColumnHeaders(i).Text = strLabelsName Then
                    shtCurrSheet(iNewRow, i) = ""
                ElseIf shtCurrSheet.ColumnHeaders(i).Text = strLevelsName Then
                    shtCurrSheet(iNewRow, i) = ""
                    shtCurrSheet.SetRangeDataFormat(iNewRow, i, 1, 1, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)
                ElseIf shtCurrSheet.ColumnHeaders(i).Text = "Counts" Then
                    'TODO Fix this formatting issue with a grid user control
                    shtCurrSheet.SetRangeDataFormat(iNewRow, i, 1, 1, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)
                    shtCurrSheet(iNewRow, i) = 0
                End If
            Next
        End If
        ApplyColumnSettings()
    End Sub

    Public Function GetSelectedLevels() As String
        Dim strTemp As String = ""
        Dim i As Integer
        Dim checked As Boolean
        Dim iCount As Integer = 0
        Dim iLabelsCol As Integer

        If grdFactorData.CurrentWorksheet IsNot Nothing Then
            iLabelsCol = GetColumnIndex(strLabelsName)
            For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
                If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                    checked = DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean)
                    If checked Then
                        If iCount = 1 Then
                            strTemp = "c(" & strTemp & ","
                        ElseIf iCount > 1 Then
                            strTemp = strTemp & ","
                        End If
                        strTemp = strTemp & Chr(34) & shtCurrSheet(i, iLabelsCol) & Chr(34)
                        iCount = iCount + 1
                    End If
                End If
            Next
            If iCount > 1 Then
                strTemp = strTemp & ")"
            End If
        End If
        Return strTemp
    End Function

    Public Function IsAllSelected() As Boolean
        If grdFactorData.CurrentWorksheet IsNot Nothing Then
            For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
                If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                    If Not DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean) Then
                        Return False
                    End If
                Else
                    Return False
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub shtcurrsheet_celldatachanged(sender As Object, e As CellEventArgs) Handles shtCurrSheet.CellDataChanged
        UpdateCells(e.Cell.Column)
    End Sub

    Private Sub UpdateCells(Optional iColumn As Integer = -2)
        Dim i As Integer
        Dim iSelected As Boolean
        If iColumn = iSelectorColumnIndex Then
            For i = 0 To grdFactorData.CurrentWorksheet.RowCount - 1
                If shtCurrSheet(i, iSelectorColumnIndex) IsNot Nothing Then
                    iSelected = DirectCast(shtCurrSheet(i, iSelectorColumnIndex), Boolean)
                    If iSelected Then
                        shtCurrSheet.RowHeaders(i).Style.BackColor = Color.Gold
                    Else
                        shtCurrSheet.RowHeaders(i).Style.BackColor = Color.White
                    End If
                End If
            Next
            RaiseEvent SelectedLevelChanged()
        Else
            RaiseEvent GridContentChanged()
        End If
    End Sub

    Public Function GetColumnInFactorSheet(iColumn As Integer, Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""

        If shtCurrSheet IsNot Nothing Then
            If shtCurrSheet.RowCount = 1 Then
                If bWithQuotes Then
                    strTemp = Chr(34) & shtCurrSheet(0, iColumn).ToString & Chr(34)
                Else
                    strTemp = shtCurrSheet(0, iColumn).ToString
                End If
            ElseIf shtCurrSheet.RowCount > 1 Then
                strTemp = "c("
                For i = 0 To shtCurrSheet.RowCount - 1
                    If i > 0 Then
                        strTemp = strTemp & ","
                    End If
                    If shtCurrSheet(i, iColumn) IsNot Nothing Then
                        If bWithQuotes Then
                            strTemp = strTemp & Chr(34) & shtCurrSheet(i, iColumn).ToString & Chr(34)
                        Else
                            strTemp = strTemp & shtCurrSheet(i, iColumn).ToString
                        End If
                    End If
                Next
                strTemp = strTemp & ")"
            End If
        End If

        Return strTemp
    End Function

    Public Function GetColumnInFactorSheet(strColumn As String, Optional bWithQuotes As Boolean = True) As String
        Dim i As Integer
        Dim iCol As Integer = -1
        Dim strTemp As String = ""

        If shtCurrSheet IsNot Nothing Then
            For i = 0 To shtCurrSheet.ColumnCount - 1
                If shtCurrSheet.ColumnHeaders(i).Text = strColumn Then
                    iCol = i
                    Exit For
                End If
            Next
            If iCol <> -1 Then strTemp = GetColumnInFactorSheet(iCol, bWithQuotes)
        End If
        Return strTemp
    End Function

    Public Function GetColumnAsList(iColumn As Integer, Optional bWithQuotes As Boolean = True) As List(Of String)
        Dim strTemp As New List(Of String)

        If shtCurrSheet IsNot Nothing Then
            If iColumn >= shtCurrSheet.ColumnCount OrElse iColumn < 0 Then
                MsgBox("Developer error: Cannot get column at index: " & iColumn & " index out of bounds")
            Else
                For i = 0 To shtCurrSheet.RowCount - 1
                    If shtCurrSheet(i, iColumn) IsNot Nothing Then
                        If bWithQuotes Then
                            strTemp.Add(Chr(34) & shtCurrSheet(i, iColumn).ToString & Chr(34))
                        Else
                            strTemp.Add(shtCurrSheet(i, iColumn).ToString)
                        End If
                    Else
                        strTemp.Add(Nothing)
                    End If
                Next
            End If
        End If
        Return strTemp
    End Function

    Public Function GetColumnAsList(strColumn As String, Optional bWithQuotes As Boolean = True) As List(Of String)
        Dim iColumn As Integer

        iColumn = GetColumnIndex(strColumn)
        Return GetColumnAsList(iColumn, bWithQuotes)
    End Function

    Public Sub SetSelectionAllLevels(bSelect As Boolean)
        Dim i As Integer
        If iSelectorColumnIndex <> -1 AndAlso bIsMultipleSelector = True Then
            For i = 0 To shtCurrSheet.RowCount - 1
                shtCurrSheet(i, iSelectorColumnIndex) = bSelect
            Next
        End If
    End Sub

    Public Sub SetColumn(strValues As String(), iColumnIndex As Integer)
        Dim i As Integer
        If shtCurrSheet IsNot Nothing Then
            If strValues.Count <> shtCurrSheet.RowCount Then
                MsgBox("Developer error: Cannot set value of control " & Name & " because the list of values does not match the number of levels.")
            ElseIf iColumnIndex < 0 OrElse iColumnIndex >= shtCurrSheet.ColumnCount Then
                MsgBox("Developer error: Cannot set value of control " & Name & " because there is no column at index " & iColumnIndex & " in the grid.")
            Else
                For i = 0 To shtCurrSheet.RowCount - 1
                    shtCurrSheet(i, iColumnIndex) = strValues(i)
                Next
            End If
        End If
    End Sub

    Private Sub grdFactorData_VisibleChanged(sender As Object, e As EventArgs) Handles grdFactorData.VisibleChanged
        RaiseEvent GridVisibleChanged()
    End Sub

    Private Sub grdFactorData_Leave(sender As Object, e As EventArgs) Handles grdFactorData.Leave
        If shtCurrSheet IsNot Nothing AndAlso shtCurrSheet.IsEditing Then
            shtCurrSheet.EndEdit(unvell.ReoGrid.EndEditReason.NormalFinish)
        End If
    End Sub

    Public Function IsColumnComplete(strColumn As String) As Boolean
        Dim iColumn As Integer = -1

        If shtCurrSheet IsNot Nothing Then
            iColumn = GetColumnIndex(strColumn)
            If iColumn = -1 Then
                MsgBox("No column called " & strColumn & " to select in grid.", MsgBoxStyle.Critical, "Cannot select column.")
                Return False
            Else
                For i As Integer = 0 To shtCurrSheet.RowCount - 1
                    If shtCurrSheet(i, iColumn) Is Nothing OrElse shtCurrSheet(i, iColumn).ToString() = "" Then
                        Return False
                    End If
                Next
                Return True
            End If
        Else
            Return False
        End If
    End Function

    Private Sub shtCurrSheet_RangeDataChanged(sender As Object, e As RangeEventArgs) Handles shtCurrSheet.RangeDataChanged
        UpdateCells(e.Range.Col)
    End Sub

    Private Sub shtCurrSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles shtCurrSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    Private Sub shtCurrSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles shtCurrSheet.BeforeCut
        e.IsCancelled = True
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If clsTempParam IsNot Nothing Then
            If bIsSelector Then
                clsTempParam.SetArgumentValue(GetSelectedLevels())
            ElseIf bIsGridColumn Then
                If IsColumnComplete(strColumnToGet) Then
                    clsTempParam.SetArgumentValue(GetColumnInFactorSheet(strColumn:=strColumnToGet))
                End If
            End If
        End If
    End Sub

    Protected Overrides Sub SetControlValue()
        Dim lstCurrentValues As String() = Nothing
        Dim clsTempParameter As RParameter

        clsTempParameter = GetParameter()
        If clsTempParameter IsNot Nothing AndAlso clsTempParameter.bIsString Then
            lstCurrentValues = ExtractItemsFromRList(clsTempParameter.strArgumentValue)
            If bIsSelector Then
                strSelectedLevels = lstCurrentValues
                RefreshFactorData()
            ElseIf bIsGridColumn Then
                RefreshFactorData()
                SetColumn(lstCurrentValues, GetColumnIndex(strColumnToGet))
            End If
        End If
    End Sub

    Private Sub ucrFactor_GridContentChanged() Handles Me.GridContentChanged, Me.SelectedLevelChanged
        OnControlValueChanged()
    End Sub

    Private Sub shtCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles shtCurrSheet.AfterCellEdit
        If shtCurrSheet.ColumnHeaders(e.Cell.Column).Text = strLevelsName AndAlso e.NewData.ToString() <> "" Then
            If Not IsNumeric(e.NewData) Then
                MsgBox("Invalid value: " & e.NewData.ToString() & Environment.NewLine & "Levels must be numeric values.", MsgBoxStyle.Exclamation, "Invalid Value")
                e.EndReason = EndEditReason.Cancel
            End If
        End If
    End Sub

    Public Function GetColumnIndex(strColumn As String) As Integer
        If shtCurrSheet IsNot Nothing Then
            For i As Integer = 0 To shtCurrSheet.ColumnCount - 1
                If shtCurrSheet.ColumnHeaders(i).Text = strColumn Then
                    Return i
                End If
            Next
        End If
        Return -1
    End Function

    'These checks should be done by reogrid control: https://reogrid.net/document/cell-edit/
    '"paste operation will also be aborted if target range including any read-only cells"
    Private Sub shtCurrSheet_BeforePaste(sender As Object, e As BeforeRangeOperationEventArgs) Handles shtCurrSheet.BeforePaste
        For i As Integer = e.Range.Col To e.Range.EndCol
            If shtCurrSheet.Cells(0, i).IsReadOnly Then
                e.IsCancelled = True
            End If
        Next
    End Sub

    Private Sub shtCurrSheet_AfterPaste(sender As Object, e As RangeEventArgs) Handles shtCurrSheet.AfterPaste
        'This is needed because pasting carries cell properties e.g. overrides readonly properties
        ApplyColumnSettings()
    End Sub

    Public Sub SetLevelsCheckbox(ucrChkAddLevels As ucrCheck)
        ucrChkLevels = ucrChkAddLevels
        If clsReceiver IsNot Nothing Then
            ucrChkLevels.Enabled = Not clsReceiver.IsEmpty
        End If
    End Sub

    Private Sub ucrChkLevels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLevels.ControlValueChanged
        Dim iLevelsCol As Integer

        If shtCurrSheet IsNot Nothing Then
            iLevelsCol = GetColumnIndex(strLevelsName)
            If iLevelsCol <> -1 Then
                If ucrChkLevels.Checked Then
                    shtCurrSheet.ShowColumns(iLevelsCol, 1)
                Else
                    shtCurrSheet.HideColumns(iLevelsCol, 1)
                End If
            End If
        End If
    End Sub

    Private Sub clsReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles clsReceiver.ControlValueChanged
        If ucrChkLevels IsNot Nothing AndAlso clsReceiver.IsEmpty Then
            ucrChkLevels.Enabled = False
        End If
    End Sub

    Public Sub SetIncludeLevels(bInclude As Boolean)
        bIncludeLevels = bInclude
        RefreshFactorData()
    End Sub
End Class