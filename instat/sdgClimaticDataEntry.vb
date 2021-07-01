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
Imports RDotNet
Imports unvell.ReoGrid
Imports unvell.ReoGrid.Events

Public Class sdgClimaticDataEntry
    'Private lstColumnNames As New List(Of KeyValuePair(Of String, String()))

    ''' <summary>
    ''' stores the row indices changed in the grid 
    ''' key = grid row index, value = grid row name (which should always be a number)
    ''' </summary>
    Private dctRowsChanged As New Dictionary(Of Integer, Integer)

    'the current worksheet in the grid
    Private WithEvents grdCurrentWorkSheet As Worksheet

    Private lstNonEditableColumns As New List(Of String)

    Private strDataFrameName As String
    Private clsSaveDataEntryFunction As RFunction
    Private clsEditDataFrameFunction As RFunction
    Private clsGetKeyFunction As RFunction
    Private clsCommentsListFunction As RFunction
    Private clsListFunction As RFunction
    Private dfEditData As DataFrame
    Private strDateName As String
    Private strDateNameToBeRemoved As String
    Private lstElementsNames As List(Of String)
    Private lstElementsNamesToBeRemoved As New List(Of String)
    Private lstViewVariablesNames As List(Of String)
    Private strStationColumnName As String
    Private bNoDecimal As Boolean
    Private bAllowTrace As Boolean
    Private bTransform As Boolean
    Private dTranformValue As Double
    Private bFirstLoad As Boolean = True
    'used to check if current options allow the grid to be editable
    Private bAllowEdits As Boolean = True
    Private bResetCommentsSubdialog As Boolean
    Private strEntryType As String = ""
    Private iMonthlyTotalsColIndex As Integer
    Private ucrBaseSelector As ucrSelector
    Private strValueTypeToCalculate As String = "sum"
    Private strDefaultValue As String = "NA"
    Private bEditNewDataOnly As Boolean = False

    Private Sub sdgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControls()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkAddFlagFieldData.SetParameter(New RParameter("add_flags", 2))
        ucrChkAddFlagFieldData.SetText("Add flag fields")
        ucrChkAddFlagFieldData.SetRDefault("FALSE")
    End Sub

    ''' <summary>
    ''' returns the data changed for the passed column as an R vector string
    ''' </summary>
    ''' <returns></returns>
    Public Function GetRowsChangedAsRVectorString(strColumnName As String, Optional strQuotes As String = "") As String
        Dim strValues As String = ""
        Dim iColumnIndex As Integer = 0
        Dim bEditableColumn As Boolean
        Dim newValue As String

        If grdCurrentWorkSheet Is Nothing Then
            Return "c()"
        End If

        For i As Integer = 0 To grdCurrentWorkSheet.ColumnCount - 1
            If grdCurrentWorkSheet.ColumnHeaders.Item(i).Text = strColumnName Then
                iColumnIndex = i
                Exit For
            End If
        Next

        bEditableColumn = Not lstNonEditableColumns.Contains(strColumnName)

        For Each iRowIndex As Integer In dctRowsChanged.Keys
            newValue = grdCurrentWorkSheet.Item(row:=iRowIndex, col:=iColumnIndex)
            'for editable columns
            If bEditableColumn Then
                If newValue = "" Then
                    newValue = "NA"
                ElseIf bAllowTrace AndAlso newValue.ToUpper = "T" Then
                    'assume trace values to be 0.03 (for R-Instat uses) here
                    newValue = 0.03
                ElseIf bTransform And IsNumeric(newValue) Then
                    newValue = newValue * dTranformValue
                End If
            End If

            If strValues = "" Then
                strValues = strQuotes & newValue & strQuotes
            Else
                strValues = strValues & "," & strQuotes & newValue & strQuotes
            End If
        Next

        Return "c(" & strValues & ")"
    End Function

    Public Function GetRowNamesChangedAsRVectorString() As String
        Return "c(" & String.Join(",", dctRowsChanged.Values.ToArray) & ")"
    End Function

    Public Function NRowsChanged() As Integer
        Return dctRowsChanged.Count
    End Function

    Public Sub Reset()
        dctRowsChanged.Clear()
        grdCurrentWorkSheet = Nothing
    End Sub

    Public Sub Setup(dfEditData As DataFrame, strDataFrameName As String, clsSaveDataEntry As RFunction,
                     clsEditDataFrame As RFunction, clsNewGetKey As RFunction, clsNewCommentsList As RFunction, clsNewList As RFunction,
                     strDateName As String, lstElementsNames As List(Of String),
                     strEntryType As String, strDefaultValue As String,
                     bEditNewDataOnly As Boolean,
                    Optional bTransform As Boolean = False, Optional dTranformValue As Double = 1,
                     Optional lstViewVariablesNames As List(Of String) = Nothing,
                     Optional strStationColumnName As String = "",
                     Optional bNoDecimal As Boolean = False,
                     Optional bAllowTrace As Boolean = False,
                     Optional ucrNewBaseSelector As ucrSelector = Nothing,
                     Optional bReset As Boolean = False)

        Dim arrColumnHeaders As String()
        clsGetKeyFunction = clsNewGetKey
        clsCommentsListFunction = clsNewCommentsList
        clsListFunction = clsNewList

        grdDataEntry.Worksheets.Clear()
        dctRowsChanged.Clear()
        lstNonEditableColumns.Clear()
        bResetCommentsSubdialog = bReset
        ucrBaseSelector = ucrNewBaseSelector

        Me.strDataFrameName = strDataFrameName
        Me.clsSaveDataEntryFunction = clsSaveDataEntry
        Me.clsEditDataFrameFunction = clsEditDataFrame
        Me.dfEditData = dfEditData
        Me.strDateName = strDateName
        Me.lstElementsNames = lstElementsNames
        Me.lstViewVariablesNames = lstViewVariablesNames
        Me.strStationColumnName = strStationColumnName
        Me.strDefaultValue = strDefaultValue
        Me.bNoDecimal = bNoDecimal
        Me.bAllowTrace = bAllowTrace
        Me.bTransform = bTransform
        Me.dTranformValue = dTranformValue
        Me.strEntryType = strEntryType
        Me.bEditNewDataOnly = bEditNewDataOnly


        ucrChkAddFlagFieldData.SetRCode(clsSaveDataEntryFunction, bReset, bCloneIfNeeded:=True)

        bAllowEdits = True
        'cmdTransform.Text = "Transform"
        'cmdTransform.Enabled = bTransform
        cmdTransform.Enabled = False

        If Not strStationColumnName = "" Then
            lstNonEditableColumns.Add(strStationColumnName)
        End If
        lstNonEditableColumns.Add(strDateName)
        If lstViewVariablesNames IsNot Nothing Then
            For Each strVar In lstViewVariablesNames
                ' Note this is the format used in get_data_entry_data R method
                lstNonEditableColumns.Add(strVar & " (view)")
            Next
        End If

        grdCurrentWorkSheet = grdDataEntry.CreateWorksheet(strDataFrameName)
        arrColumnHeaders = dfEditData.ColumnNames

        grdCurrentWorkSheet.Columns = arrColumnHeaders.Count
        For k = 0 To arrColumnHeaders.Count - 1
            grdCurrentWorkSheet.ColumnHeaders.Item(k).Text = arrColumnHeaders(k)
            If Not lstElementsNames.Contains(arrColumnHeaders(k)) Then
                grdCurrentWorkSheet.ColumnHeaders(k).TextColor = Graphics.SolidColor.Black
            End If
        Next

        Dim dfValue As String
        Dim bNonEditableCell As Boolean
        Dim bChangedToDefaultValue As Boolean

        'set grid rows
        grdCurrentWorkSheet.Rows = dfEditData.RowCount
        For i As Integer = 0 To dfEditData.RowCount - 1
            'set the grid row header 
            grdCurrentWorkSheet.RowHeaders.Item(i).Text = dfEditData.RowNames(i)
            For j = 0 To grdCurrentWorkSheet.Columns - 1
                bNonEditableCell = lstNonEditableColumns.Contains(arrColumnHeaders(j))
                dfValue = dfEditData.Item(i, j)
                bChangedToDefaultValue = False

                'convert all "NaN" to R "NA" or set default
                If dfValue = "NaN" Then
                    If bNonEditableCell Then
                        dfValue = "NA"
                    Else
                        dfValue = strDefaultValue
                        'blank default is interpreted as NA in R
                        If Not (strDefaultValue = "NA" OrElse strDefaultValue = "") Then
                            bChangedToDefaultValue = True
                        End If

                    End If
                End If

                grdCurrentWorkSheet.Item(row:=i, col:=j) = dfValue

                'tag and change color for editable cells that have been set with default value
                If Not bNonEditableCell AndAlso bChangedToDefaultValue Then
                    grdCurrentWorkSheet.GetCell(i, j).Style.BackColor = Color.LightYellow
                    AddChangedRow(i) 'add to the list of changed rows
                End If

                'set non editable cells to read only
                If bNonEditableCell Then
                    grdCurrentWorkSheet.GetCell(i, j).IsReadOnly = True
                Else
                    If dfValue = "NA" OrElse dfValue = "" Then
                        grdCurrentWorkSheet.GetCell(row:=i, col:=j).Tag = "new"
                    End If
                End If
            Next

        Next

        'if entry by month then, add the monthly totals rows and set the calculated totals
        If Me.strEntryType = "Month" Then
            'for monthly entry add 3 extra rows for; sum, calculated and difference
            grdCurrentWorkSheet.AppendRows(3)

            Dim iLastRowIndex As Integer = grdCurrentWorkSheet.Rows - 1
            'set the non editable cells for the added 3 rows
            For i As Integer = iLastRowIndex - 2 To iLastRowIndex
                For j = 0 To grdCurrentWorkSheet.Columns - 1
                    'create the cell by setting the value if it does not exist
                    If grdCurrentWorkSheet.GetCell(row:=i, col:=j) Is Nothing Then
                        grdCurrentWorkSheet.Item(row:=i, col:=j) = ""
                    End If

                    'all calculated and difference cells should be uneditable
                    If i = iLastRowIndex - 1 OrElse i = iLastRowIndex Then
                        grdCurrentWorkSheet.GetCell(row:=i, col:=j).IsReadOnly = True
                        Continue For
                    End If

                    If lstNonEditableColumns.Contains(arrColumnHeaders(j)) Then
                        grdCurrentWorkSheet.GetCell(row:=i, col:=j).IsReadOnly = True
                    End If
                Next
            Next

            iMonthlyTotalsColIndex = Array.IndexOf(arrColumnHeaders, Me.strDateName)
            Dim dropDown As New CellTypes.DropdownListCell("Sum", "Mean", "Count", "Count > 0")
            AddHandler dropDown.SelectedItemChanged, Sub()
                                                         strValueTypeToCalculate = dropDown.SelectedItem.ToString.ToLower
                                                         ComputeAndSetMonthlyTotalsForAllColumns()
                                                     End Sub

            'set the Sum cell drop down and make it editable
            grdCurrentWorkSheet.Item(row:=iLastRowIndex - 2, col:=iMonthlyTotalsColIndex) = dropDown
            grdCurrentWorkSheet.Item(row:=iLastRowIndex - 2, col:=iMonthlyTotalsColIndex) = "Sum"
            Me.strValueTypeToCalculate = "sum"
            grdCurrentWorkSheet.GetCell(row:=iLastRowIndex - 2, col:=iMonthlyTotalsColIndex).IsReadOnly = False
            grdCurrentWorkSheet.GetCell(row:=iLastRowIndex - 2, col:=iMonthlyTotalsColIndex).Tag = "summary"

            grdCurrentWorkSheet.Item(row:=iLastRowIndex - 1, col:=iMonthlyTotalsColIndex) = "Calculated"
            grdCurrentWorkSheet.Item(row:=iLastRowIndex, col:=iMonthlyTotalsColIndex) = "Difference"

            'set the monthly totals from the set rows
            ComputeAndSetMonthlyTotalsForAllColumns()
        End If

        grdCurrentWorkSheet.SetRangeDataFormat(New RangePosition(0, 0, grdCurrentWorkSheet.Rows, grdCurrentWorkSheet.Columns), DataFormat.CellDataFormatFlag.Text)
        grdCurrentWorkSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdCurrentWorkSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)

        grdDataEntry.AddWorksheet(grdCurrentWorkSheet)
        grdDataEntry.SheetTabNewButtonVisible = False

    End Sub

    Private Sub cellContextMenuStrip_Opening(sender As Object, e As CancelEventArgs) Handles cellContextMenuStrip.Opening
        mnuPaste.Enabled = Not String.IsNullOrEmpty(My.Computer.Clipboard.GetText)
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        grdCurrentWorkSheet.Copy()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        Dim arrPasteValues As String()
        Dim strClipBoardText As String = My.Computer.Clipboard.GetText
        Dim iColumnIndex As Integer = grdCurrentWorkSheet.SelectionRange.Col
        Dim iStartRowIndex As Integer = grdCurrentWorkSheet.SelectionRange.Row
        Dim iLastEditableRowIndex As Integer
        Dim strNewValue As String

        If grdCurrentWorkSheet.SelectionRange.Cols > 1 Then
            MsgBox("Pasting into cells in different columns is currently disabled. This feature will be included in future versions." & Environment.NewLine & "Try pasting into one column cells at a time.", MsgBoxStyle.Information, "Cannot paste into multiple cells in different columns")
            Exit Sub
        End If

        If String.IsNullOrEmpty(strClipBoardText) Then
            Exit Sub
        End If

        If lstNonEditableColumns.Contains(grdCurrentWorkSheet.ColumnHeaders.Item(iColumnIndex).Text) Then
            MsgBox("Pasting into uneditable cells is currently disabled." & Environment.NewLine & "Try pasting into one cell at a time.", MsgBoxStyle.Information, "Cannot paste into uneditable cells")
            Exit Sub
        End If

        'split the text to be pasted into multiple lines and remove empty entries cause by the return line
        'try carriage return–linefeed combination
        arrPasteValues = strClipBoardText.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

        'try line feed only
        If arrPasteValues.Length = 1 Then
            arrPasteValues = strClipBoardText.Split({vbLf}, StringSplitOptions.RemoveEmptyEntries)
        End If

        'try carriage return only
        If arrPasteValues.Length = 1 Then
            arrPasteValues = strClipBoardText.Split({vbCr}, StringSplitOptions.RemoveEmptyEntries)
        End If

        'exclude calculated and difference row if entry type is monthly
        iLastEditableRowIndex = If(strEntryType = "Month", grdCurrentWorkSheet.Rows - 3, grdCurrentWorkSheet.Rows - 1)

        iStartRowIndex = grdCurrentWorkSheet.SelectionRange.Row

        'validate all the values first
        For index As Integer = 0 To arrPasteValues.Length - 1
            'abort entry when the value is not valid
            If Not ValidateValue(arrPasteValues(index).Trim, grdCurrentWorkSheet.GetCell(iStartRowIndex, iColumnIndex)) Then
                Exit Sub
            End If
            'abort entry if pasted rows are more than editable rows
            If iStartRowIndex >= iLastEditableRowIndex Then
                Exit For
            End If
            iStartRowIndex += 1
        Next

        iStartRowIndex = grdCurrentWorkSheet.SelectionRange.Row
        'then save the values if all are valid
        For index As Integer = 0 To arrPasteValues.Length - 1
            strNewValue = arrPasteValues(index).Trim
            If ValidateAndSaveValueChanged(iStartRowIndex, iColumnIndex, strNewValue) Then
                grdCurrentWorkSheet.GetCell(iStartRowIndex, iColumnIndex).Data = strNewValue
            End If
            'abort entry if pasted rows are more than editable rows
            If iStartRowIndex >= iLastEditableRowIndex Then
                Exit For
            End If
            iStartRowIndex += 1
        Next

    End Sub

    Private Sub grdCurrentWorkSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles grdCurrentWorkSheet.BeforeCut
        MsgBox("Cutting is currently disabled. This feature will be included in future versions." & Environment.NewLine & "Try copying and deleting from one column cells at a time.", MsgBoxStyle.Information, "Cannot cut from cells")
        e.IsCancelled = True
    End Sub

    Private Sub grdCurrSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles grdCurrentWorkSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then

            If grdCurrentWorkSheet.SelectionRange.Cols > 1 Then
                MsgBox("Deleting cells in multiple columns is currently disabled. This feature will be included in future versions." & Environment.NewLine & "Try deleting from one column cells at a time.", MsgBoxStyle.Information, "Cannot delete cells in multiple columns")
                e.IsCancelled = True
                Exit Sub
            End If

            If e.Cell.IsReadOnly Then
                MsgBox("Deleting read only cells is currently disabled.", MsgBoxStyle.Information, "Cannot delete read only cells")
                e.IsCancelled = True
                Exit Sub
            End If

            'delete operation applies to all selected cells for the column
            Dim iEndRow As Integer = grdCurrentWorkSheet.SelectionRange.EndRow

            If strEntryType = "Month" AndAlso grdCurrentWorkSheet.SelectionRange.EndRow = grdCurrentWorkSheet.Rows - 1 Then
                'exclude calculated and difference 
                iEndRow = iEndRow - 2
            End If

            'validate new delete entries to all cells first
            For iRowIndex As Integer = grdCurrentWorkSheet.SelectionRange.Row To iEndRow
                If Not ValidateValue("", grdCurrentWorkSheet.GetCell(row:=iRowIndex, col:=e.Cell.Column)) Then
                    e.IsCancelled = True
                    Exit Sub
                End If
            Next

            'if all valid then proceed with saving NA's as the change
            For iRowIndex As Integer = grdCurrentWorkSheet.SelectionRange.Row To iEndRow
                'forces the cell to have blank data values 
                grdCurrentWorkSheet.Item(row:=iRowIndex, col:=e.Cell.Column) = ""
                ValidateAndSaveValueChanged(iRowIndex, e.Cell.Column, "NA")
            Next

        End If
    End Sub

    Private Sub grdCurrSheet_BeforeCellEdit(sender As Object, e As CellBeforeEditEventArgs) Handles grdCurrentWorkSheet.BeforeCellEdit
        ''todo. do this disabling of data entry be done when setting up the grid. Not here
        'If lstNonEditableColumns.Contains(grdCurrentWorkSheet.ColumnHeaders(e.Cell.Column).Text) Then
        '    e.IsCancelled = True
        'End If
        'If InStr(grdCurrentWorkSheet.ColumnHeaders(e.Cell.Column).Text, "(view)") Then
        '    e.IsCancelled = True
        'End If
    End Sub

    Private Sub grdCurrSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles grdCurrentWorkSheet.AfterCellEdit
        'If Not bAllowEdits Then
        '    'todo. set a better feedback message 
        '    MsgBox("Edits not allowed", MsgBoxStyle.Information, "No edits allowed.")
        '    e.EndReason = EndEditReason.Cancel
        '    Exit Sub
        'End If

        If Not ValidateAndSaveValueChanged(e.Cell, If(e.NewData = "", "NA", e.NewData)) Then
            e.EndReason = EndEditReason.Cancel
            'grdCurrentWorkSheet.FocusPos = New CellPosition(e.Cell.Address)
        End If
    End Sub

    Private Function ValidateAndSaveValueChanged(cell As Cell, newValue As String) As Boolean
        If ValidateValue(newValue, cell) Then
            'dont add any change in the last 3 rows if entry is by "Month"
            If Not (strEntryType = "Month" AndAlso cell.Row >= grdCurrentWorkSheet.Rows - 3) Then
                AddChangedRow(cell.Row)
            End If
            ComputeAndSetMonthlyTotalsForColumn(iColIndex:=cell.Column, iRowIndex:=cell.Row, newValue)

            cell.Style.BackColor = Color.Yellow

            Return True
        Else
            Return False
        End If


    End Function

    Private Function ValidateAndSaveValueChanged(iRow As Integer, iColumn As Integer, newValue As String) As Boolean
        Return ValidateAndSaveValueChanged(grdCurrentWorkSheet.GetCell(row:=iRow, col:=iColumn), newValue)
    End Function

    Private Function ValidateValue(newValue As String, Optional grdCell As Cell = Nothing) As Boolean

        'if only NAs allowed then check if cell is allowed to have new value (except summary cells)
        If grdCell IsNot Nothing AndAlso bEditNewDataOnly AndAlso grdCell.Tag <> "new" AndAlso grdCell.Tag <> "summary" Then
            MsgBox("Previously existing data cannot be changed with the Add/Edit new data only option selected in the options subdialog.", MsgBoxStyle.Information, "Not new value.")
            Return False
        End If

        If Not IsNumeric(newValue) AndAlso Not newValue = "NA" AndAlso Not newValue = "" Then
            If Not (bAllowTrace AndAlso newValue.ToUpper = "T") Then
                MsgBox("Value is not numeric or NA.", MsgBoxStyle.Information, "Not numeric.")
                Return False
            End If
        ElseIf bNoDecimal AndAlso newValue.Contains(".") Then
            MsgBox("Value should not be decimal otherwise uncheck No Decimal.", MsgBoxStyle.Information, "Not decimal Allowed.")
            Return False
        End If

        Return True
    End Function


    ''' <summary>
    ''' adds the row index changed to the list of rows changes
    ''' </summary>
    ''' <param name="iRow"> row index</param>
    Private Sub AddChangedRow(iRow As Integer)
        'add the row index and row name to the last of rows changed
        If Not dctRowsChanged.ContainsKey(iRow) Then
            dctRowsChanged.Add(iRow, Integer.Parse(grdCurrentWorkSheet.RowHeaders.Item(iRow).Text))
        End If
    End Sub

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        If MsgBox("All data entry will be lost. Are you sure you want to continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            clsSaveDataEntryFunction.RemoveParameterByName("rows_changed")

            Setup(dfEditData:=dfEditData, strDataFrameName:=strDataFrameName, clsSaveDataEntry:=clsSaveDataEntryFunction,
                             clsEditDataFrame:=clsEditDataFrameFunction, clsNewGetKey:=clsGetKeyFunction,
                             clsNewCommentsList:=clsCommentsListFunction, clsNewList:=clsListFunction,
                             strDateName:=strDateName, lstElementsNames:=lstElementsNames, lstViewVariablesNames:=lstViewVariablesNames,
                             strStationColumnName:=strStationColumnName,
                             bEditNewDataOnly:=bEditNewDataOnly,
                             strDefaultValue:=sdgClimaticDataEntryOptions.GetSetDefaultValue,
                               bNoDecimal:=sdgClimaticDataEntryOptions.GetSetNoDecimals,
                               bAllowTrace:=sdgClimaticDataEntryOptions.GetSetAllowTrace,
                               bTransform:=sdgClimaticDataEntryOptions.GetSetTransform,
                               dTranformValue:=sdgClimaticDataEntryOptions.GetSetTransformValue,
                               strEntryType:=strEntryType, ucrNewBaseSelector:=ucrBaseSelector, bReset:=True)
        End If
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        Dim i As Integer

        clsEditDataFrameFunction.RemoveParameterByName(strDateNameToBeRemoved)
        For Each strElementName As String In lstElementsNamesToBeRemoved
            clsEditDataFrameFunction.RemoveParameterByName(strElementName)
        Next

        If NRowsChanged() > 0 Then
            strDateNameToBeRemoved = strDateName
            lstElementsNamesToBeRemoved = lstElementsNames
            clsEditDataFrameFunction.AddParameter(strDateName, "as.Date(" & GetRowsChangedAsRVectorString(strDateName, Chr(34)) & ")", iPosition:=1)
            i = 2
            For Each strElementName As String In lstElementsNames
                clsEditDataFrameFunction.AddParameter(strElementName, GetRowsChangedAsRVectorString(strElementName), iPosition:=i)
                i = i + 1
            Next
            clsSaveDataEntryFunction.AddParameter("rows_changed", GetRowNamesChangedAsRVectorString(), iPosition:=2)
            clsSaveDataEntryFunction.AddParameter("comments_list", clsRFunctionParameter:=clsListFunction, iPosition:=3)
        Else
            clsSaveDataEntryFunction.RemoveParameterByName("rows_changed")
            clsSaveDataEntryFunction.RemoveParameterByName("comments_list")
        End If
    End Sub

    Private Sub cmdTransform_Click(sender As Object, e As EventArgs) Handles cmdTransform.Click
        'todo. check how translation will affect this, possibly use 2 buttons instead of one ?
        If cmdTransform.Text = "Transform" Then
            cmdTransform.Text = "UnTransform"
            bAllowEdits = False
        Else
            cmdTransform.Text = "Transform"
            bAllowEdits = True
        End If
    End Sub

    Private Sub comment_Click(sender As Object, e As EventArgs) Handles cmdComment.Click, mnuComment.Click
        Dim selectedRowheaderText As String = grdCurrentWorkSheet.RowHeaders.Item(grdDataEntry.CurrentWorksheet.SelectionRange.Row).Text
        Dim selectedColumnHeaderText As String = grdCurrentWorkSheet.ColumnHeaders.Item(grdDataEntry.CurrentWorksheet.SelectionRange.Col).Text

        sdgCommentForDataEntry.SetUpCommentsSubdialog(
                      clsNewSaveDataEntry:=clsSaveDataEntryFunction, clsNewGetKey:=clsGetKeyFunction,
                      clsNewCommentsList:=clsCommentsListFunction,
                      clsNewList:=clsListFunction, strDataFrame:=grdCurrentWorkSheet.Name,
                      strRow:=selectedRowheaderText, strColumn:=selectedColumnHeaderText,
                      ucrNewBaseSelector:=ucrBaseSelector, bReset:=bResetCommentsSubdialog)
        sdgCommentForDataEntry.ShowDialog()
        bResetCommentsSubdialog = False
    End Sub

    ''' <summary>
    ''' calculates the monthly totals for all columns
    ''' </summary>
    Private Sub ComputeAndSetMonthlyTotalsForAllColumns()
        'set the monthly totals for all editable columns
        For j = iMonthlyTotalsColIndex + 1 To grdCurrentWorkSheet.Columns - 1
            'dont set totals for non editable columns
            If Not lstNonEditableColumns.Contains(grdCurrentWorkSheet.ColumnHeaders.Item(j).Text) Then
                ComputeAndSetMonthlyTotalsForColumn(j)
            End If
        Next
    End Sub

    ''' <summary>
    ''' sets the calculated monthly totals for a column; the last 2 rows in the grid
    ''' </summary>
    ''' <param name="iColIndex"></param>
    ''' <param name="iRowIndex"></param>
    ''' <param name="strNewValue"></param>
    Private Sub ComputeAndSetMonthlyTotalsForColumn(iColIndex As Integer, Optional iRowIndex As Integer = -1, Optional strNewValue As String = Nothing)
        Dim iLastRowIndex As Integer = grdCurrentWorkSheet.Rows - 1
        Dim strTotalUserInputValue As String
        Dim strValue As String
        Dim dTotalCalculatedValue As Double
        Dim dDifferenceValue As Double
        Dim iAllValuesCount As Integer = 0
        Dim dSumValue As Double
        Dim iValuesGreaterThan0Count As Integer = 0
        Dim dValue As Double

        'only do monthly totals for columns after the monthly total column
        If Me.strEntryType <> "Month" OrElse iColIndex <= iMonthlyTotalsColIndex Then
            Exit Sub
        End If

        'get user input monthly total value, if the new value is a "sum" value then just use the new value
        If iRowIndex = iLastRowIndex - 2 AndAlso strNewValue IsNot Nothing Then
            strTotalUserInputValue = strNewValue
        Else
            strTotalUserInputValue = grdCurrentWorkSheet.Item(row:=iLastRowIndex - 2, col:=iColIndex)
        End If

        'calculate the different "calculated" values.
        For i As Integer = 0 To iLastRowIndex - 3 'exclude the 3 rows; sum, calculated and difference
            'if new value of the current cell row item is there
            'then just use the new value to get the calculated value
            If iRowIndex = i AndAlso strNewValue IsNot Nothing Then
                strValue = strNewValue
            Else
                strValue = grdCurrentWorkSheet.Item(row:=i, col:=iColIndex)
            End If

            'assume trace values to be 0 (for data entry uses) here
            If strValue.ToUpper = "T" Then
                strValue = "0"
            End If

            If IsNumeric(strValue) Then
                dValue = Double.Parse(strValue)
                dSumValue = dSumValue + dValue
                iAllValuesCount = iAllValuesCount + 1
                If dValue > 0 Then
                    iValuesGreaterThan0Count = iValuesGreaterThan0Count + 1
                End If
            End If

        Next

        'set the required calculated value
        Select Case strValueTypeToCalculate
            Case "sum"
                dTotalCalculatedValue = dSumValue
            Case "mean"
                'only calculate mean if changed values > 0
                dTotalCalculatedValue = If(iAllValuesCount > 0, dSumValue / iAllValuesCount, 0)
            Case "count"
                dTotalCalculatedValue = iAllValuesCount
            Case "count > 0"
                dTotalCalculatedValue = iValuesGreaterThan0Count
            Case Else
                'todo. developer error?? 
                dTotalCalculatedValue = 0
        End Select

        'set the calculated value and round of to 2 d.p
        dTotalCalculatedValue = Math.Round(dTotalCalculatedValue, 2)
        grdCurrentWorkSheet.Item(row:=iLastRowIndex - 1, col:=iColIndex) = dTotalCalculatedValue
        'grdCurrentWorkSheet.GetCell(row:=iLastRowIndex - 1, col:=iColIndex).Data = dTotalCalculatedValue
        'set difference value, only when there is a sum value else remove the difference
        If IsNumeric(strTotalUserInputValue) Then
            dDifferenceValue = Math.Round(Double.Parse(strTotalUserInputValue) - dTotalCalculatedValue, 2)
            grdCurrentWorkSheet.Item(row:=iLastRowIndex, col:=iColIndex) = dDifferenceValue
            'grdCurrentWorkSheet.GetCell(row:=iLastRowIndex, col:=iColIndexSelected).Style.BackColor = If(dDifferenceValue = 0, Color.LightGreen, Color.White)
        Else
            grdCurrentWorkSheet.Item(row:=iLastRowIndex, col:=iColIndex) = ""
            'grdCurrentWorkSheet.GetCell(row:=iLastRowIndex, col:=iColIndexSelected).Style.BackColor = Color.White
        End If

    End Sub


End Class