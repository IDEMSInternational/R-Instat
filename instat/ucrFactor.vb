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
Imports unvell.ReoGrid
Imports unvell.ReoGrid.CellTypes
Imports unvell.ReoGrid.Events

''' <summary>
''' <para>This control only accepts string parameter types</para> 
''' <para>It does not yet support entry of comma separated values</para>
''' <para>It can only be used in either of the following states; NormalGrid, SingleSelectorGrid, MultipleSelectorGrid </para>
''' <para>In  NormalGrid normal state, if set to internally write to parameters, 
''' the parameters will have a list of the entire values of the column regardless of whether
''' the values were edit or not.
''' Reading R parameters will fail if any new levels created were not submitted to R</para>
''' <para>In Selector state mode, if set to internally write to parameters, 
''' the parameters will have a list of the selected values</para>
''' </summary>
Public Class ucrFactor

    'this reogrid worksheet will eventually be replaced with the custom grid sheet 
    Private WithEvents _grdSheet As unvell.ReoGrid.Worksheet

    ''' <summary>
    ''' raised when the grid content has been refilled from R.
    ''' For instance when a factor variable is changed, it's default metadata is refilled from R
    ''' </summary>
    Public Event GridContentReFilledFromR()

    ''' <summary>
    ''' the receiver linked to this control.
    ''' will be used to display the factor metadata of the variable contained in it
    ''' <para>The receiver should contain a factor variable</para>
    ''' </summary>
    Private WithEvents _ucrLinkedReceiver As ucrReceiverSingle

    'Note. This will be initialised once in this object scope.

    ''' <summary>
    ''' used as a cache of the receiver's contents
    ''' </summary>
    Private strCurrFactorVariableName As String = ""

    ''' <summary>
    ''' used to determine whether to include NA factor level, if available, 
    ''' as part of the metadata filled in the grid sheet
    ''' </summary>
    Private _bIncludeNALevel As Boolean = False

    ''' <summary>
    ''' holds all column names to be set as editable in the grid sheet after filling the metadata
    ''' </summary>
    Private _editableColNames As New HashSet(Of String)

    ''' <summary>
    ''' holds column names to be hidden in the grid sheet after filling the metadata
    ''' </summary>
    Private _hiddenColNames As New HashSet(Of String)

    ''' <summary>
    ''' holds extra column names that will be added to the sheet after filling the metadata
    ''' </summary>
    Private _extraColNames As New HashSet(Of String)

    ''' <summary>
    ''' holds parameter names and column names associated with them
    ''' used in writing the contents of the columns in to the parameters
    ''' </summary>
    Private _dctParamAndColNames As New Dictionary(Of String, String)

    ''' <summary>
    ''' holds the state of the control
    ''' </summary>
    Private _enumControlState As ControlStates = ControlStates.NormalGrid

    ''' <summary>
    ''' the control's valid states
    ''' </summary>
    Private Enum ControlStates
        'can contain editable columns. no row selection is internally supported 
        NormalGrid
        'cannot contain editable columns and also single selection of grid rows
        SingleSelectorGrid
        'cannot contain editable columns and also allows multiple selection of grid rows
        MultipleSelectorGrid
    End Enum

    ''' <summary>
    ''' represents column names internally supported by this control
    ''' </summary>
    Public Structure DefaultColumnNames
        '-------------------
        'note an Enum would have been ideal, but VB.Net does not support String Enums
        '------------------

        ''' <summary>
        ''' <par>Used to represent the ordinal column name from R.</par>
        ''' <par>It's always added in the grid</par> 
        ''' </summary>
        Public Const Ordinal As String = "Ord."
        ''' <summary>
        ''' used to represent "Level" column name from R
        ''' <par>It's always added in the grid</par>
        ''' </summary>
        Public Const Level As String = "Level"
        ''' <summary>
        ''' used to represent "Label" column name from R
        ''' <par>It's always added in the grid</par>
        ''' </summary>
        Public Const Label As String = "Label"
        ''' <summary>
        ''' used to represent "Freq" column name from R
        ''' <par>It's always added in the grid</par>
        ''' </summary>
        Public Const Freq As String = "Freq"

        ''' <summary>
        ''' used to represent "Selector" column name 
        ''' this column is added internally when the control is used as a 'selector' 
        ''' it does not come from R. 
        ''' <par>It's added in the grid if the control is used as a selector</par>
        ''' </summary>
        Public Const SelectorColumn As String = "Select"
    End Structure


    Private Sub ucrFactor_Load(sender As Object, e As EventArgs) Handles Me.Load
        'the grid will always have 1 sheet. So no need to display the sheet tab control
        grdFactorData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
    End Sub

    Private Sub _ucrLinkedReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles _ucrLinkedReceiver.ControlValueChanged
        'Calling this subroutine here is necessary.
        'However when reloading a dialog, the receiver always clears it's contents first before
        'restoring the previous selected variable.
        'This forces this control to never retain what was previously selected despite it's inbuilt ability to do so
        'todo Once the receiver is refactored this comment can be removed.

        FillGridWithNewDataSheet()
    End Sub

    Private Sub _grdSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles _grdSheet.BeforeCut
        MsgBox("Cutting is currently disabled. This feature will be included in future versions." &
               Environment.NewLine & "Try copying and deleting from one column cells at a time.",
               MsgBoxStyle.Information, "Cannot cut from cells")
        e.IsCancelled = True
    End Sub

    Private Sub _grdSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles _grdSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. " &
                   "This feature will be included in future versions." &
                   Environment.NewLine & "To remove a cell's value, replace the value with NA.",
                   MsgBoxStyle.Information, "Cannot delete cells.")
            e.IsCancelled = True
        End If
    End Sub

    ''' <summary>
    ''' raised when user types in the cell.
    ''' does not apply to checkbox and radiobutton cells
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub _grdSheet_AfterCellEdit(sender As Object, e As CellAfterEditEventArgs) Handles _grdSheet.AfterCellEdit

        Dim bValid As Boolean = True
        'do levels entry validation
        If _grdSheet.ColumnHeaders(e.Cell.Column).Text = DefaultColumnNames.Level Then
            If Not IsNumeric(e.NewData) Then
                MsgBox("Levels must be numeric values", MsgBoxStyle.Information, "Invalid Value")
                bValid = False
            ElseIf e.NewData.Contains(".") Then
                MsgBox("Levels must not be decimal", MsgBoxStyle.Information, "Invalid Value")

                bValid = False
            End If
        End If

        If bValid Then
            'set the new data before calling OnControlValueChanged
            'very important especially when writing to the parameter value
            _grdSheet(e.Cell.Row, e.Cell.Column) = e.NewData
            'this will raise ControlContentsChanged event
            'and also update parameter and R code with the values
            OnControlValueChanged()
            e.Cell.Style.BackColor = Color.Gold
        Else
            e.EndReason = EndEditReason.Cancel
        End If

    End Sub


    ''' <summary>
    ''' sets the state of the control, linked receiver and grid properties
    ''' </summary>
    ''' <param name="enumControlState"></param>
    ''' <param name="ucrLinkedReceiver"></param>
    ''' <param name="dctParamAndColNames"></param>
    ''' <param name="hiddenColNames"></param>
    ''' <param name="extraColNames"></param>
    ''' <param name="editableColNames"></param>
    ''' <param name="bIncludeNALevel"></param>
    Private Sub SetupControl(enumControlState As ControlStates,
                             ucrLinkedReceiver As ucrReceiverSingle,
                             Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                             Optional hiddenColNames As IEnumerable(Of String) = Nothing,
                             Optional extraColNames As IEnumerable(Of String) = Nothing,
                             Optional editableColNames As IEnumerable(Of String) = Nothing,
                             Optional bIncludeNALevel As Boolean = False)

        _enumControlState = enumControlState
        _ucrLinkedReceiver = ucrLinkedReceiver

        'if nothing then just initialise with empty collections
        _dctParamAndColNames = If(dctParamAndColNames, New Dictionary(Of String, String))
        _hiddenColNames = New HashSet(Of String)(If(hiddenColNames, {}))
        _extraColNames = New HashSet(Of String)(If(extraColNames, {}))
        _editableColNames = New HashSet(Of String)(If(editableColNames, {}))
        _bIncludeNALevel = bIncludeNALevel
        FillGridWithNewDataSheet()
    End Sub

    Public Sub SetAsNormalGridColumn(ucrLinkedReceiver As ucrReceiverSingle,
                                    Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                                     Optional hiddenColNames As IEnumerable(Of String) = Nothing,
                                     Optional extraColNames As IEnumerable(Of String) = Nothing,
                                     Optional editableColNames As IEnumerable(Of String) = Nothing)

        SetupControl(ControlStates.NormalGrid, ucrLinkedReceiver, dctParamAndColNames,
                     hiddenColNames, extraColNames, editableColNames, bIncludeNALevel:=False)

    End Sub

    Public Sub SetAsSingleSelectorGrid(ucrLinkedReceiver As ucrReceiverSingle,
                                      Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                                       Optional hiddenColNames As IEnumerable(Of String) = Nothing,
                                       Optional bIncludeNALevel As Boolean = False)
        SetupControl(ControlStates.SingleSelectorGrid, ucrLinkedReceiver, dctParamAndColNames,
                     hiddenColNames:=hiddenColNames, bIncludeNALevel:=bIncludeNALevel)
    End Sub

    Public Sub SetAsMultipleSelectorGrid(ucrLinkedReceiver As ucrReceiverSingle,
                                        Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                                         Optional hiddenColNames As IEnumerable(Of String) = Nothing,
                                             Optional bIncludeNALevel As Boolean = False)
        SetupControl(ControlStates.MultipleSelectorGrid, ucrLinkedReceiver, dctParamAndColNames,
                     hiddenColNames:=hiddenColNames, bIncludeNALevel:=bIncludeNALevel)
    End Sub

    ''' <summary>
    ''' hides the columns
    ''' </summary>
    ''' <param name="hiddenColNames"></param>
    Public Sub HideColumns(hiddenColNames As IEnumerable(Of String))
        If _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim lstHiddenColumnsNames As List(Of String) = _hiddenColNames.ToList
        lstHiddenColumnsNames.AddRange(hiddenColNames)
        _hiddenColNames = New HashSet(Of String)(lstHiddenColumnsNames)

        For Each strColName As String In _hiddenColNames
            _grdSheet.HideColumns(GetColumnIndex(_grdSheet, strColName), 1)
        Next
    End Sub

    ''' <summary>
    ''' shows the columns if they exist
    ''' </summary>
    ''' <param name="showColNames"></param>
    Public Sub ShowColumns(showColNames As IEnumerable(Of String))

        If _grdSheet Is Nothing Then
            Exit Sub
        End If

        'update the list of hidden column names first
        Dim lstHiddenColumnsNames As List(Of String) = _hiddenColNames.ToList
        lstHiddenColumnsNames.RemoveAll(Function(i) showColNames.Contains(i))
        _hiddenColNames = New HashSet(Of String)(lstHiddenColumnsNames)

        'then show the column names
        For Each strColName As String In showColNames
            _grdSheet.ShowColumns(GetColumnIndex(_grdSheet, strColName), 1)
        Next
    End Sub

    Private Sub FillGridWithNewDataSheet()
        'check for linked receiver and empty receiver contents
        'also check column type of the receiver if it is a factor.
        'the alternative way of getting the column type is by calling (todo left here for later reference)
        'frmMain.clsRLink.GetColumnType(_ucrLinkedReceiver.GetDataName(), _ucrLinkedReceiver.GetVariableNames(bWithQuotes:=False))
        'Note contains() check allows ordered factors to be included
        If _ucrLinkedReceiver Is Nothing OrElse _ucrLinkedReceiver.IsEmpty() OrElse
            String.IsNullOrEmpty(_ucrLinkedReceiver.strCurrDataType) OrElse
            Not _ucrLinkedReceiver.strCurrDataType.ToLower.Contains("factor") Then
            ClearWorkSheetAndVariableName()
            OnControlValueChanged()
            Exit Sub
        End If


        'Get the R factor variable name
        Dim strNewFactorVariableName As String = _ucrLinkedReceiver.GetVariableNames(bWithQuotes:=True)

        'check if the receiver contents really changed.
        'Some dialogs and controls implementations
        'may indirectly call this function multiple times unnecessary.
        'adding this checks helps with performance efficiency.  
        If strCurrFactorVariableName = strNewFactorVariableName Then
            Exit Sub
        End If
        'set the new factor varible as the current cached variable
        strCurrFactorVariableName = strNewFactorVariableName
        If CreateAndFillNewDataSheet(grdFactorData,
                                      Chr(34) & _ucrLinkedReceiver.GetDataName() & Chr(34),
                                      strNewFactorVariableName,
                                     _enumControlState, _bIncludeNALevel,
                                     _hiddenColNames, _extraColNames,
                                     _editableColNames) Then
            _grdSheet = grdFactorData.CurrentWorksheet
            'show the reogrid
            grdFactorData.Visible = True
            RaiseEvent GridContentReFilledFromR()
            OnControlValueChanged()
        End If
    End Sub

    ''' <summary>
    ''' clears all grid worksheets and resets the cached factor variable name
    ''' also hides the grid
    ''' </summary>
    Private Sub ClearWorkSheetAndVariableName()
        'clear any worksheets from the grid
        _grdSheet = Nothing
        grdFactorData.Worksheets.Clear()
        'clear the cached varible name too.
        'An important step to do incase variable data type has been changed 
        strCurrFactorVariableName = ""


        'important
        'ucrFilter control implementation forced this line addition
        'for some reason when ucrFactor.Visible = True is called when 
        '_grdSheet = Nothing, then the reogrid throws a visbility error.
        'todo removal of this Visibility setting can removed once ucrFilter has been fully refactored
        'see issue #7408  comments
        grdFactorData.Visible = False
    End Sub

    ''' <summary>
    ''' <para>Creates a new worksheet add adds it to the grid control</para>
    ''' <para>Fills the new worksheet with the factor variable metadata</para> 
    ''' <para>Applies the appropriate settings to the worksheet</para>
    ''' </summary>
    ''' <param name="grdControl"></param>
    ''' <param name="strDataFrameName"></param>
    ''' <param name="strFactorVariableName"></param>
    ''' <param name="enumControlState"></param>
    ''' <param name="bIncludeNALevel"></param>
    ''' <param name="hiddenColumnNames"></param>
    ''' <param name="extraColumnNames"></param>
    ''' <param name="editableColumnNames"></param>
    ''' <returns></returns>
    Private Function CreateAndFillNewDataSheet(grdControl As unvell.ReoGrid.ReoGridControl,
                                                strDataFrameName As String,
                                                strFactorVariableName As String,
                                                enumControlState As ControlStates,
                                                bIncludeNALevel As Boolean,
                                                hiddenColumnNames As IEnumerable(Of String),
                                                extraColumnNames As IEnumerable(Of String),
                                                editableColumnNames As IEnumerable(Of String)) As Boolean


        'get the factor metadata from R
        Dim expDataFrame As SymbolicExpression
        Dim clsConvertToCharFunction As New RFunction
        Dim clsGetFactorDataFunction As New RFunction

        clsGetFactorDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_factor_data_frame")
        clsGetFactorDataFunction.AddParameter("data_name", strDataFrameName)
        clsGetFactorDataFunction.AddParameter("col_name", strFactorVariableName)
        clsGetFactorDataFunction.AddParameter("include_NA_level", If(bIncludeNALevel, "TRUE", "FALSE"))
        clsConvertToCharFunction.SetRCommand("convert_to_character_matrix")
        clsConvertToCharFunction.AddParameter("data", clsRFunctionParameter:=clsGetFactorDataFunction)
        expDataFrame = frmMain.clsRLink.RunInternalScriptGetValue(clsConvertToCharFunction.ToScript(), bSilent:=True)

        If expDataFrame Is Nothing OrElse expDataFrame.Type = Internals.SymbolicExpressionType.Null Then
            Return False
        End If
        'Below function will create a new worksheet and fill it with factor metadata from the data frame
        frmMain.clsGrids.FillSheet(expDataFrame.AsDataFrame, "Factor Data", grdControl)

        grdControl.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
        grdControl.CurrentWorksheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
        grdControl.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.View_ShowRowHeader, False)
        grdControl.CurrentWorksheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
        'set the ordinal column width size
        grdControl.CurrentWorksheet.ColumnHeaders(0).Width = 30

        'create the extra columns and their default cell values
        For Each strExtraColName As String In extraColumnNames
            grdControl.CurrentWorksheet.AppendColumns(1)
            grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).Text = strExtraColName
            'create the cells by setting its value.
            'very important, without setting the value GetCell and cell value will be nothing
            For iRowIndex As Integer = 0 To grdControl.CurrentWorksheet.Rows - 1
                grdControl.CurrentWorksheet(iRowIndex, grdControl.CurrentWorksheet.Columns - 1) = ""
            Next
        Next

        Select Case enumControlState
            Case ControlStates.SingleSelectorGrid
                'add select level column with radiobutton as the cell body values
                grdControl.CurrentWorksheet.AppendColumns(1)
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).Text = DefaultColumnNames.SelectorColumn
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).DefaultCellBody = GetType(unvell.ReoGrid.CellTypes.RadioButtonCell)
                AddSelectorButtonCells(grdControl.CurrentWorksheet, grdControl.CurrentWorksheet.Columns - 1, True)
            Case ControlStates.MultipleSelectorGrid
                'add select level column with checkbox as the cell body values
                grdControl.CurrentWorksheet.AppendColumns(1)
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).Text = DefaultColumnNames.SelectorColumn
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).DefaultCellBody = GetType(unvell.ReoGrid.CellTypes.CheckBoxCell)
                AddSelectorButtonCells(grdControl.CurrentWorksheet, grdControl.CurrentWorksheet.Columns - 1, False)
            Case ControlStates.NormalGrid
                'do nothing
        End Select

        'hide columns not needed. The data frame had all default factor metadata columns
        For iColIndex As Integer = 0 To grdControl.CurrentWorksheet.ColumnCount - 1
            If hiddenColumnNames.Contains(grdControl.CurrentWorksheet.ColumnHeaders(iColIndex).Text) Then
                grdControl.CurrentWorksheet.HideColumns(iColIndex, 1)
            End If
        Next

        ApplyUneditibleCellSettings(grdControl.CurrentWorksheet, editableColumnNames)
        Return True
    End Function

    ''' <summary>
    ''' used to add a new row in the grid
    ''' <parm>note. calling this method when the control is in 'Selector' state will not add a new row</parm>
    ''' </summary>
    Public Sub AddNewRowInGrid()
        'if no sheet is set or control is used as a selector then adding new rows is not allowed
        If _grdSheet Is Nothing OrElse Not _enumControlState = ControlStates.NormalGrid Then
            Exit Sub
        End If

        'add new row and set it's cells data format to text
        _grdSheet.AppendRows(1)
        _grdSheet.SetRangeDataFormat(_grdSheet.Rows - 1, 0, 1, _grdSheet.Columns, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)
        For iColIndex As Integer = 0 To _grdSheet.Columns - 1
            Select Case _grdSheet.ColumnHeaders(iColIndex).Text
                Case DefaultColumnNames.Ordinal
                    _grdSheet(_grdSheet.Rows - 1, iColIndex) = _grdSheet.Rows
                Case DefaultColumnNames.Freq
                    _grdSheet(_grdSheet.Rows - 1, iColIndex) = 0
                Case Else
                    _grdSheet(_grdSheet.Rows - 1, iColIndex) = ""
            End Select
        Next

        ApplyUneditibleCellSettings(_grdSheet, _editableColNames)
        'to update parameters and call parent dialog validations
        OnControlValueChanged()
    End Sub

    Private Sub ApplyUneditibleCellSettings(grdSheet As unvell.ReoGrid.Worksheet,
                                            editableColumnNames As IEnumerable(Of String))
        If editableColumnNames.Count = 0 Then
            'just set whole sheet as none editable.
            'note. the grid in 'selector' state will always be read only
            grdSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, True)
        Else
            'unfortunately we don't have a way of setting a whole column as read only.
            'so set the cells of the uneditable columns as read only
            Dim bIsNotEditable As Boolean
            grdSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, False)
            For iColIndex As Integer = 0 To grdSheet.Columns - 1
                bIsNotEditable = Not editableColumnNames.Contains(grdSheet.ColumnHeaders(iColIndex).Text)
                For iRowIndex As Integer = 0 To grdSheet.Rows - 1
                    grdSheet.GetCell(iRowIndex, iColIndex).IsReadOnly = bIsNotEditable
                Next
            Next
        End If
    End Sub

    Private Sub AddSelectorButtonCells(grdSheet As unvell.ReoGrid.Worksheet,
                                              iSelectorColIndex As Integer,
                                              bSingleSelection As Boolean)

        If bSingleSelection Then
            Dim radioButtonGroup As New unvell.ReoGrid.CellTypes.RadioButtonGroup
            For iRowIndex As Integer = 0 To grdSheet.Rows - 1
                'create the cell first by setting its value
                grdSheet(iRowIndex, iSelectorColIndex) = False
                'then set the body to be a radio button 
                Dim radioButtonCell As New unvell.ReoGrid.CellTypes.RadioButtonCell
                'setting radio button group ensures that only 1 radio button is selectable 
                radioButtonCell.RadioGroup = radioButtonGroup
                grdSheet.GetCell(iRowIndex, iSelectorColIndex).Body = radioButtonCell
                'attach the event handler to the cell body
                AddHandler radioButtonCell.Click, Sub()
                                                      'this will raise ControlContentsChanged event
                                                      'and also update parameter and R code with the values
                                                      OnControlValueChanged()
                                                  End Sub

            Next
        Else
            For iRowIndex As Integer = 0 To grdSheet.Rows - 1
                'create the cell first by setting its value
                grdSheet(iRowIndex, iSelectorColIndex) = False
                'then cet the body to be a check box
                Dim checkBoxCell As New unvell.ReoGrid.CellTypes.CheckBoxCell
                grdSheet.GetCell(iRowIndex, iSelectorColIndex).Body = checkBoxCell
                'attach the event handler to the cell body
                AddHandler checkBoxCell.Click, Sub()
                                                   'this will raise ControlContentsChanged event
                                                   'and also update parameter and R code with the values
                                                   OnControlValueChanged()
                                               End Sub
            Next
        End If
    End Sub


    ''' <summary>
    ''' checks if all values in the list of columns are not empty.
    ''' column names must exist in the grid 
    ''' </summary>
    ''' <param name="colNames"></param>
    ''' <returns>true if all values are not empty and false otherwise</returns>
    Public Function IsColumnComplete(colNames As IEnumerable(Of String)) As Boolean

        If _grdSheet Is Nothing Then
            Return False
        End If

        For Each strColName As String In colNames
            Dim iColIndex As Integer = GetColumnIndex(_grdSheet, strColName)
            For iRowIndex As Integer = 0 To _grdSheet.Rows - 1
                If _grdSheet(iRowIndex, iColIndex).ToString() = "" Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    ''' <summary>
    ''' gets the row count of the grid.
    ''' </summary>
    ''' <returns>row count of the grid. If the grid sheet has not been set, returns 0</returns>
    Public ReadOnly Property RowCount() As Integer
        Get
            Return If(_grdSheet Is Nothing, 0, _grdSheet.Rows)
        End Get
    End Property

    ''' <summary>
    ''' gets the grid sheet
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property GridSheet() As unvell.ReoGrid.Worksheet
        Get
            Return _grdSheet
        End Get
    End Property

    ''' <summary>
    ''' returns the column index of the column name passed from the grid sheet 
    ''' </summary> 
    ''' <param name="strColName"></param>
    ''' <returns>return -1 if column index not found</returns>
    Public Function GetColumnIndex(strColName As String) As Integer
        Return If(_grdSheet Is Nothing, -1, GetColumnIndex(_grdSheet, strColName))
    End Function

    Private Function GetColumnIndex(grdSheet As unvell.ReoGrid.Worksheet, strColName As String) As Integer
        For i As Integer = 0 To grdSheet.Columns - 1
            If grdSheet.ColumnHeaders(i).Text = strColName Then
                Return i
            End If
        Next
        Return -1
    End Function

    ''' <summary>
    ''' gets cell values of the requested column from the selected or checked rows
    ''' <para>the column name must exist in the grid</para>
    ''' </summary>
    ''' <param name="strValueColName">column name of the cell values</param>
    ''' <param name="bWithQuotes">Add double quotes for R or not </param>
    ''' <returns>cell values from selected rows of the column requested. 
    ''' If no rows selected an empty list is returned</returns>
    Public Function GetSelectedCellValues(strValueColName As String,
                                           bWithQuotes As Boolean) As List(Of String)

        If _grdSheet Is Nothing Then
            Return New List(Of String)
        End If

        Return GetSelectedCellValues(_grdSheet,
                                           GetColumnIndex(_grdSheet, DefaultColumnNames.Ordinal),
                                           GetColumnIndex(_grdSheet, DefaultColumnNames.SelectorColumn),
                                           GetColumnIndex(_grdSheet, strValueColName),
                                           bWithQuotes)
    End Function

    'used internally
    Private Function GetSelectedCellValues(grdSheet As unvell.ReoGrid.Worksheet,
                                           iOrdinalColIndex As Integer,
                                           iSelectedColIndex As Integer,
                                           iValueColIndex As Integer,
                                           bWithQuotes As Boolean) As List(Of String)

        Dim lstCellValues As New List(Of String)

        For iRowIndex As Integer = 0 To grdSheet.Rows - 1
            If Not DirectCast(grdSheet(iRowIndex, iSelectedColIndex), Boolean) Then
                Continue For
            End If


            'This checks if the value in the ordinal column is "-" which means it's the NA row
            'so no quotes should be added.
            'There could be a real factor level with the same label as (NA) so safer to check
            'the ordinal column which will only have "-" for the (NA) row.
            If grdSheet(iRowIndex, iOrdinalColIndex) = "-" Then
                lstCellValues.Add(grdSheet(iRowIndex, iValueColIndex))
            ElseIf bWithQuotes Then
                lstCellValues.Add(Chr(34) & grdSheet(iRowIndex, iValueColIndex) & Chr(34))
            Else
                lstCellValues.Add(grdSheet(iRowIndex, iValueColIndex))
            End If

        Next

        Return lstCellValues
    End Function


    ''' <summary>
    ''' gets cell values of the requested column from the grid rows
    ''' <para>the column name must exist in the grid.</para>
    ''' </summary>
    ''' <param name="strValueColName">column name of the cell values</param>
    ''' <param name="bWithQuotes">Add double quotes for R or not </param>
    ''' <returns>cell values from selected rows of the column requested. 
    ''' If no rows selected an empty list is returned</returns>
    Public Function GetCellValues(strValueColName As String, bWithQuotes As Boolean) As List(Of String)
        'todo. validation of grid and columns. used externally
        If _grdSheet Is Nothing Then
            Return New List(Of String)
        End If

        Return GetCellValues(_grdSheet, GetColumnIndex(_grdSheet, strValueColName), bWithQuotes)
    End Function

    Private Function GetCellValues(grdSheet As unvell.ReoGrid.Worksheet,
                                   iValueColIndex As Integer, bWithQuotes As Boolean) As List(Of String)
        Dim lstCellValues As New List(Of String)
        For i = 0 To grdSheet.RowCount - 1
            If bWithQuotes Then
                lstCellValues.Add(Chr(34) & grdSheet(i, iValueColIndex) & Chr(34))
            Else
                lstCellValues.Add(grdSheet(i, iValueColIndex))
            End If
        Next
        Return lstCellValues
    End Function

    ''' <summary>
    ''' Checks if all rows are 'selected or checked'
    ''' <para>Note. Should be used in 'MultipleSelector or SingleSelector' state only</para>
    ''' </summary>
    ''' <returns>true if any row is 'selected', false otherwise</returns>
    Public Function IsAnyGridRowSelected() As Boolean
        'only multiple select state supports this
        If _grdSheet Is Nothing OrElse _enumControlState = ControlStates.NormalGrid Then
            Return False
        End If

        Dim iSelectorColumnIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.SelectorColumn)
        For i = 0 To _grdSheet.Rows - 1
            If DirectCast(_grdSheet(i, iSelectorColumnIndex), Boolean) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Checks if all rows are 'selected or checked'
    ''' <para>Note. Should be used in 'MultipleSelector' state only</para>
    ''' </summary>
    ''' <returns>true if all rows are 'selected', false otherwise</returns>
    Public Function IsAllGridRowsSelected() As Boolean
        'only multiple select state supports this
        If _grdSheet Is Nothing OrElse Not _enumControlState = ControlStates.MultipleSelectorGrid Then
            Return False
        End If

        Dim iSelectorColumnIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.SelectorColumn)
        For iRowIndex = 0 To _grdSheet.Rows - 1
            If Not DirectCast(_grdSheet(iRowIndex, iSelectorColumnIndex), Boolean) Then
                Return False
            End If
        Next
        Return True
    End Function

    ''' <summary>
    ''' Checks or unchecks all rows in the grid
    ''' <para>Note. Should be used in 'MultipleSelector' or 'SingleSelctor' state only</para>
    ''' </summary>
    ''' <param name="bChecked"></param>
    ''' <param name="bRaisedControlValueChangedEvent">if set to true, will raise ConroValueChanged of this control</param>
    Public Sub SelectAllGridRows(bChecked As Boolean, Optional bRaisedControlValueChangedEvent As Boolean = True)
        'only multiple select state supports this
        If _grdSheet Is Nothing OrElse Not _enumControlState = ControlStates.MultipleSelectorGrid Then
            Exit Sub
        End If

        Dim iCheckedColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.SelectorColumn)
        Dim bChangeDetected As Boolean = False
        For iRowIndex As Integer = 0 To _grdSheet.Rows - 1
            If _grdSheet(iRowIndex, iCheckedColIndex) <> bChecked Then
                _grdSheet(iRowIndex, iCheckedColIndex) = bChecked
                bChangeDetected = True
            End If
        Next
        'only raise control value changed if a change was detected
        If bChangeDetected AndAlso bRaisedControlValueChangedEvent Then
            OnControlValueChanged()
        End If
    End Sub


    'used internally when reading data from parameter
    Private Sub SetSelectedRows(grdSheet As unvell.ReoGrid.Worksheet,
                                iSelectedColIndex As Integer,
                                iValueColIndex As Integer,
                                cellValues As IEnumerable(Of String),
                                bRaisedControlValueChangedEvent As Boolean)

        'reset all selection
        For iRowIndex As Integer = 0 To grdSheet.Rows - 1
            grdSheet(iRowIndex, iSelectedColIndex) = False
        Next

        'then set the selected rows
        For iValueIndex As Integer = 0 To cellValues.Count - 1
            For iRowIndex As Integer = 0 To grdSheet.Rows - 1
                If cellValues(iValueIndex) = grdSheet(iRowIndex, iValueColIndex) Then
                    grdSheet(iRowIndex, iSelectedColIndex) = True
                End If
            Next
        Next

        If bRaisedControlValueChangedEvent Then
            OnControlValueChanged()
        End If
    End Sub

    ''' <summary>
    ''' sets all the cell values of the column name passed
    ''' <para>the column must exist and the cell values count = grid row count</para>
    ''' </summary>
    ''' <param name="strValueColName">column name</param>
    ''' <param name="cellValues">cell values to be set</param>
    ''' <param name="bRaisedControlValueChangedEvent">if set to true, will raise ConroValueChanged of this control</param>
    ''' <param name="bSilent">if true, a developer message box will be displayed, false otherwise</param>
    Public Sub SetCellValues(strValueColName As String, cellValues As IEnumerable(Of String),
                           Optional bRaisedControlValueChangedEvent As Boolean = True,
                             Optional bSilent As Boolean = False)

        If _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim iValueColIndex As Integer = GetColumnIndex(_grdSheet, strValueColName)
        'to enforce developers use this control correctly do the following checks
        If iValueColIndex < 0 Then
            If Not bSilent Then
                MsgBox("Developer error: Cannot set value of control " & Name & " because there is no column at index " & iValueColIndex & " in the grid.")
            End If
            Exit Sub
        End If

        If cellValues.Count <> _grdSheet.Rows Then
            If Not bSilent Then
                MsgBox("Developer error: Cannot set value of control " & Name & " because the list of values does not match the number of rows in the grid.")
            End If
            Exit Sub
        End If

        SetCellValues(_grdSheet, iValueColIndex, cellValues, bRaisedControlValueChangedEvent)
    End Sub

    'used internally
    Private Sub SetCellValues(grdSheet As unvell.ReoGrid.Worksheet, iValueColIndex As Integer, cellValues As IEnumerable(Of String), bRaisedControlValueChangedEvent As Boolean)
        For iRowIndex As Integer = 0 To grdSheet.RowCount - 1
            grdSheet(iRowIndex, iValueColIndex) = cellValues(iRowIndex)
        Next
        If bRaisedControlValueChangedEvent Then
            OnControlValueChanged()
        End If
    End Sub

    ''' <summary>
    ''' by default this is always called when subroutine OnControlValueChanged 
    ''' of this control is called
    ''' </summary>
    ''' <param name="clsTempParam"></param>
    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)

        If clsTempParam Is Nothing OrElse _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim strColName As String = _dctParamAndColNames.Item(clsTempParam.strArgumentName)
        Dim iValueColIndex As Integer = GetColumnIndex(_grdSheet, strColName)
        Dim strRValue As String = ""
        Select Case _enumControlState
            Case ControlStates.SingleSelectorGrid, ControlStates.MultipleSelectorGrid
                Dim iOrdinalColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Ordinal)
                Dim iSelectorColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.SelectorColumn)
                strRValue = mdlCoreControl.GetRVector(GetSelectedCellValues(_grdSheet,
                                                                            iOrdinalColIndex, iSelectorColIndex, iValueColIndex, True),
                                                      bOnlyIfMultipleElement:=(_enumControlState = ControlStates.SingleSelectorGrid))

            Case ControlStates.NormalGrid
                strRValue = mdlCoreControl.GetRVector(GetCellValues(_grdSheet, iValueColIndex, True))
        End Select

        clsTempParam.SetArgumentValue(strRValue)
    End Sub

    ''' <summary>
    ''' called at ucrCore level when a dialog calls SetRCode for this control.
    ''' this sets the control values from it's parameter objects 
    ''' </summary>
    Protected Overrides Sub SetControlValue()
        Dim clsTempParam As RParameter = GetParameter()
        If clsTempParam Is Nothing OrElse Not clsTempParam.bIsString OrElse _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim arrCellValues As String() = mdlCoreControl.ExtractItemsFromRList(clsTempParam.strArgumentValue)
        Dim strColName As String = _dctParamAndColNames.Item(clsTempParam.strArgumentName)
        Dim iValueColIndex As Integer = GetColumnIndex(_grdSheet, strColName)

        Select Case _enumControlState
            Case ControlStates.SingleSelectorGrid, ControlStates.MultipleSelectorGrid
                Dim iSelectorColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.SelectorColumn)
                SetSelectedRows(_grdSheet, iSelectorColIndex, iValueColIndex, arrCellValues, False)
            Case ControlStates.NormalGrid
                If arrCellValues.Count <> _grdSheet.Rows Then
                    MsgBox("Developer error: Cannot set value of control " & Name & " because the list of values does not match the number of rows in the grid. check SetControl()")
                    Exit Sub
                End If
                SetCellValues(_grdSheet, iValueColIndex, arrCellValues, False)
        End Select
    End Sub

End Class