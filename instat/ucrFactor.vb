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
''' <para>this control only accepts string parameter types</para> 
''' <para>this control does not yet support entry of comma separated values</para>
''' 
''' <para>in normal grid mode, if set to internally write to parameters, 
''' the parameters will have a list of the entire values of the column regardless of whether
''' the values were edit or not</para>
''' <para>Reading R parameters will fail if new level created was no submitted to R</para>
''' 
''' 
''' </summary>
Public Class ucrFactor
    Public WithEvents clsReceiver As ucrReceiverSingle
    Public WithEvents shtCurrSheet As unvell.ReoGrid.Worksheet

    Public Event SelectedLevelChanged()
    Public Event GridContentChanged()
    'Public Event GridVisibleChanged()
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
    Public bIncludeNA As Boolean
    Public strLevelsName As String
    Public strLabelsName As String
    Public strFreqName As String
    Private bDoNotUpdateCells As Boolean = False

    'this reogrid worksheet will eventually be replaced with the custom grid sheet 
    Private WithEvents _grdSheet As unvell.ReoGrid.Worksheet

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
    Private _editableColumnNames As IEnumerable(Of String) = {}

    ''' <summary>
    ''' holds column names to be hidden in the grid sheet after filling the metadata
    ''' </summary>
    Private _hiddenColumnNames As IEnumerable(Of String) = {}

    ''' <summary>
    ''' holds extra column names that will be added to the sheet after filling the metadata
    ''' </summary>
    Private _extraColumnNames As IEnumerable(Of String) = {}

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
    ''' states that the control can be used in dialogs
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
        'note an Enum would have been ideal, but VB.Net does not support String Enums

        'used to represent the ordinal column from R
        Public Const Ordinal = "Ord."
        'used to represent "Level" column name from R
        Public Const Level = "Level"
        'used to represent "Label" column name from R
        Public Const Label = "Label"
        'used to represent "Freq" column name  from R
        Public Const Freq = "Freq"
        'used to represent "Select_Level" column name (used internally by control) 
        'used only in 'selector' control state
        Public Const Select_Level = "Select Level"
    End Structure


    '----------------------
    'events

    Private Sub ucrFactor_Load(sender As Object, e As EventArgs) Handles Me.Load
        'the grid will always have 1 sheet. So no need to display the sheet tab control
        grdFactorData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
    End Sub

    Private Sub _ucrLinkedReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles _ucrLinkedReceiver.ControlValueChanged
        'todo.check if the contents of the receiver really changed before doing below
        FillGridWithNewDataSheet()
        OnControlValueChanged()
    End Sub

    Private Sub _grdSheet_BeforeCut(sender As Object, e As BeforeRangeOperationEventArgs) Handles _grdSheet.BeforeCut
        MsgBox("Cutting is currently disabled. This feature will be included in future versions." & Environment.NewLine & "Try copying and deleting from one column cells at a time.", MsgBoxStyle.Information, "Cannot cut from cells")
        e.IsCancelled = True
    End Sub

    Private Sub _grdSheet_BeforeCellKeyDown(sender As Object, e As BeforeCellKeyDownEventArgs) Handles _grdSheet.BeforeCellKeyDown
        If e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Delete OrElse e.KeyCode = unvell.ReoGrid.Interaction.KeyCode.Back Then
            MsgBox("Deleting cells is currently disabled. This feature will be included in future versions." & Environment.NewLine & "To remove a cell's value, replace the value with NA.", MsgBoxStyle.Information, "Cannot delete cells.")
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
                MsgBox("Levels must not be decimal .", MsgBoxStyle.Information, "Invalid Value")
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

    'end events
    '---------------------------------------------

    Private Sub SetupControl(enumControlState As ControlStates,
                             ucrLinkedReceiver As ucrReceiverSingle,
                            Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                             Optional hiddenColumnNames As IEnumerable(Of String) = Nothing,
                             Optional extraColumnsNames As IEnumerable(Of String) = Nothing,
                             Optional editableColumnNames As IEnumerable(Of String) = Nothing,
                                 Optional bIncludeNALevel As Boolean = False)

        _enumControlState = enumControlState
        _ucrLinkedReceiver = ucrLinkedReceiver

        'if nothing then just initialise with empty collections
        _dctParamAndColNames = If(dctParamAndColNames Is Nothing, New Dictionary(Of String, String), dctParamAndColNames)
        _hiddenColumnNames = If(hiddenColumnNames Is Nothing, {}, hiddenColumnNames)
        _extraColumnNames = If(extraColumnsNames Is Nothing, {}, extraColumnsNames)
        _editableColumnNames = If(editableColumnNames Is Nothing, {}, editableColumnNames)
        _bIncludeNALevel = bIncludeNALevel

        'by default the sheet will always be filled have the 3 columns form the data frame;
        'level, label and freq. So remove any column names that are contained in the sheet by default
        Dim lstExtraColumnNames As List(Of String) = _extraColumnNames.ToList()
        lstExtraColumnNames.RemoveAll(Function(i) {
                                          DefaultColumnNames.Ordinal,
                                          DefaultColumnNames.Level,
                                           DefaultColumnNames.Label,
                                           DefaultColumnNames.Freq,
                                           DefaultColumnNames.Select_Level}.Contains(i))
        _extraColumnNames = lstExtraColumnNames

        'todo. do further a developer check??
        'for instance  parameter column names must be in overall paremeter list
        'else throw a develper error 
        FillGridWithNewDataSheet()
        OnControlValueChanged()
    End Sub

    Public Sub SetAsNormalGridColumn(ucrLinkedReceiver As ucrReceiverSingle,
                                    Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                                     Optional hiddenColumnNames As IEnumerable(Of String) = Nothing,
                                     Optional extraColumnsNames As IEnumerable(Of String) = Nothing,
                                     Optional editableColumnNames As IEnumerable(Of String) = Nothing)

        SetupControl(ControlStates.NormalGrid, ucrLinkedReceiver, dctParamAndColNames,
                     hiddenColumnNames, extraColumnsNames, editableColumnNames)

    End Sub

    Public Sub SetAsSingleSelectorGrid(ucrLinkedReceiver As ucrReceiverSingle,
                                      Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                                       Optional hiddenColumnsNames As IEnumerable(Of String) = Nothing,
                                       Optional bIncludeNALevel As Boolean = False)
        SetupControl(ControlStates.SingleSelectorGrid, ucrLinkedReceiver, dctParamAndColNames,
                     hiddenColumnNames:=hiddenColumnsNames, bIncludeNALevel:=bIncludeNALevel)
    End Sub

    Public Sub SetAsMultipleSelectorGrid(ucrLinkedReceiver As ucrReceiverSingle,
                                        Optional dctParamAndColNames As Dictionary(Of String, String) = Nothing,
                                         Optional hiddenColumnsNames As IEnumerable(Of String) = Nothing,
                                             Optional bIncludeNALevel As Boolean = False)
        SetupControl(ControlStates.MultipleSelectorGrid, ucrLinkedReceiver, dctParamAndColNames,
                     hiddenColumnNames:=hiddenColumnsNames, bIncludeNALevel:=bIncludeNALevel)
    End Sub

    Public Sub HideColumns(hiddenColumnsNames As IEnumerable(Of String))
        If _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim lstHiddenColumnsNames As List(Of String) = _hiddenColumnNames.ToList
        lstHiddenColumnsNames.AddRange(hiddenColumnsNames)
        _hiddenColumnNames = lstHiddenColumnsNames.Distinct()

        For Each strColName As String In _hiddenColumnNames
            _grdSheet.HideColumns(GetColumnIndex(_grdSheet, strColName), 1)
        Next
    End Sub

    Public Sub ShowColumns(showColumnsNames As IEnumerable(Of String))

        If _grdSheet Is Nothing Then
            Exit Sub
        End If

        'update the list of hidden column names first
        Dim lstHiddenColumnsNames As List(Of String) = _hiddenColumnNames.ToList
        lstHiddenColumnsNames.RemoveAll(Function(i) showColumnsNames.Contains(i))
        _hiddenColumnNames = lstHiddenColumnsNames


        'then show the column names
        For Each strColName As String In showColumnsNames
            _grdSheet.ShowColumns(GetColumnIndex(_grdSheet, strColName), 1)
        Next

    End Sub

    Private Sub FillGridWithNewDataSheet()

        'check for linked receiver and empty receiver contents
        'also check column type of the receiver if it is a factor.
        'the alternative way of getting the column type is by calling (left here for later reference)
        'frmMain.clsRLink.GetColumnType(_ucrLinkedReceiver.GetDataName(), _ucrLinkedReceiver.GetVariableNames(bWithQuotes:=False))
        'Note contains() check allows ordered factors to be included
        If _ucrLinkedReceiver Is Nothing OrElse _ucrLinkedReceiver.IsEmpty() OrElse
            String.IsNullOrEmpty(_ucrLinkedReceiver.strCurrDataType) OrElse
            Not _ucrLinkedReceiver.strCurrDataType.ToLower.Contains("factor") Then
            ClearWorkSheetAndVariableName()
            Exit Sub
        End If



        'Get the R factor variable name
        Dim strNewFactorVariableName As String = _ucrLinkedReceiver.GetVariableNames(bWithQuotes:=True)

        'check if the receiver contents really changed. Some dialogs and controls implementations
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
                                     _hiddenColumnNames, _extraColumnNames,
                                     _editableColumnNames) Then
            _grdSheet = grdFactorData.CurrentWorksheet
            'show the reogrid
            grdFactorData.Visible = True
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
        'ucrFilter control implemntation forced this line addition
        'for some reason when ucrFactor.Visible = True is called when 
        '_grdSheet = Nothing, then the reogrid throws a visbility error.
        'removal of this Visibility setting can removed once ucrFilter has been fully refactored
        grdFactorData.Visible = False
    End Sub

    ''' <summary>
    ''' creates a new worksheet add adds it to the grid control
    ''' fills the new worksheet with the factor variable metadata 
    ''' applies the appropriate settings to the worksheet
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
        Dim clsConvertToCharacter As New RFunction
        Dim clsRFunctionGetFactorData As New RFunction

        clsRFunctionGetFactorData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_factor_data_frame")
        clsRFunctionGetFactorData.AddParameter("data_name", strDataFrameName)
        clsRFunctionGetFactorData.AddParameter("col_name", strFactorVariableName)
        clsRFunctionGetFactorData.AddParameter("include_NA_level", If(bIncludeNALevel, "TRUE", "FALSE"))
        clsConvertToCharacter.SetRCommand("convert_to_character_matrix")
        clsConvertToCharacter.AddParameter("data", clsRFunctionParameter:=clsRFunctionGetFactorData)
        expDataFrame = frmMain.clsRLink.RunInternalScriptGetValue(clsConvertToCharacter.ToScript(), bSilent:=True)

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

        For Each strExtraColName As String In extraColumnNames
            grdControl.CurrentWorksheet.AppendColumns(1)
            grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.ColumnCount - 1).Text = strExtraColName
            'todo. check if cell body type will be text by default
        Next

        Select Case enumControlState
            Case ControlStates.SingleSelectorGrid
                'add select level column with radiobutton as the cell body values
                grdControl.CurrentWorksheet.AppendColumns(1)
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).Text = DefaultColumnNames.Select_Level
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).DefaultCellBody = GetType(unvell.ReoGrid.CellTypes.RadioButtonCell)
                AddSelectorButtonCells(grdControl.CurrentWorksheet, grdControl.CurrentWorksheet.Columns - 1, True)
            Case ControlStates.MultipleSelectorGrid
                'add select level column with checkbox as the cell body values
                grdControl.CurrentWorksheet.AppendColumns(1)
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).Text = DefaultColumnNames.Select_Level
                grdControl.CurrentWorksheet.ColumnHeaders(grdControl.CurrentWorksheet.Columns - 1).DefaultCellBody = GetType(unvell.ReoGrid.CellTypes.CheckBoxCell)
                AddSelectorButtonCells(grdControl.CurrentWorksheet, grdControl.CurrentWorksheet.Columns - 1, False)
            Case ControlStates.NormalGrid
                'do nothing
        End Select

        'hide columns not needed. The data frame had all default factor metadata columns
        For iColIndex As Integer = 0 To grdControl.CurrentWorksheet.ColumnCount - 1

            'todo set width of level and freq??
            ' _grdSheet.ColumnHeaders(iLevelsCol).Width = 40
            '_grdSheet.ColumnHeaders(iFreqCol).Width = 40

            'hide columns set as hidden
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

        ApplyUneditibleCellSettings(_grdSheet, _editableColumnNames)
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
                Dim radioButtonCell As New unvell.ReoGrid.CellTypes.RadioButtonCell
                'setting radio button group ensures that only 1 radio button is selectable 
                radioButtonCell.RadioGroup = radioButtonGroup
                AddHandler radioButtonCell.CheckChanged, Sub()
                                                             'this will raise ControlContentsChanged event
                                                             'and also update parameter and R code with the values
                                                             OnControlValueChanged()
                                                         End Sub
                grdSheet(iRowIndex, iSelectorColIndex) = radioButtonCell
            Next
        Else
            For iRowIndex As Integer = 0 To grdSheet.Rows - 1
                Dim checkBoxCell As New unvell.ReoGrid.CellTypes.CheckBoxCell
                'grdSheet(iRowIndex, iSelectorColIndex) = checkBoxCell
                grdSheet(iRowIndex, iSelectorColIndex) = False
                grdSheet.GetCell(iRowIndex, iSelectorColIndex).Body = checkBoxCell
                AddHandler checkBoxCell.CheckChanged, Sub()
                                                          'this will raise ControlContentsChanged event
                                                          'and also update parameter and R code with the values
                                                          OnControlValueChanged()
                                                      End Sub
            Next
        End If



    End Sub

    ''' <summary>
    ''' Checks if all rows are 'selected or checked'
    ''' <para>Note. Should be used in 'MultipleSelector' state only</para>
    ''' </summary>
    ''' <returns></returns>
    Public Function IsAllGridRowsSelected() As Boolean
        'only multiple select state supports this
        If _grdSheet Is Nothing OrElse Not _enumControlState = ControlStates.MultipleSelectorGrid Then
            Return False
        End If

        Dim iSelectorColumnIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Select_Level)
        For iRowIndex = 0 To _grdSheet.Rows - 1
            If Not DirectCast(_grdSheet(iRowIndex, iSelectorColumnIndex), Boolean) Then
                Return False
            End If
        Next
        Return True
    End Function

    ''' <summary>
    ''' Checks if all rows are 'selected or checked'
    ''' <para>Note. Should be used in 'MultipleSelector or SingleSelector' state only</para>
    ''' </summary>
    ''' <returns></returns>
    Public Function IsAnyGridRowSelected() As Boolean
        'only multiple select state supports this
        If _grdSheet Is Nothing OrElse _enumControlState = ControlStates.NormalGrid Then
            Return False
        End If

        Dim iSelectorColumnIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Select_Level)
        For i = 0 To _grdSheet.Rows - 1
            If DirectCast(_grdSheet(i, iSelectorColumnIndex), Boolean) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Checks or unchecks all rows in the grid
    ''' <para>Note. Should be used in 'MultipleSelector' or 'SingleSelctor' state only</para>
    ''' </summary>
    ''' <param name="bChecked"></param>
    Public Sub SelectAllGridRows(bChecked As Boolean)
        'only multiple select state supports this
        If _grdSheet Is Nothing OrElse Not _enumControlState = ControlStates.MultipleSelectorGrid Then
            Exit Sub
        End If

        Dim iCheckedColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Select_Level)
        For iRowIndex As Integer = 0 To _grdSheet.Rows - 1
            _grdSheet(iRowIndex, iCheckedColIndex) = bChecked
        Next
    End Sub

    ''' <summary>
    ''' checks if all values in the list of columns are not empty.
    ''' </summary>
    ''' <param name="colNames"></param>
    ''' <returns>true if all values are not empty and false otherwise</returns>
    Public Function IsColumnComplete(colNames As IEnumerable(Of String)) As Boolean

        Dim _grdSheet As unvell.ReoGrid.Worksheet = Me._grdSheet

        'todo. temporary. delete this after complete testing
        If _grdSheet Is Nothing Then
            _grdSheet = shtCurrSheet
        End If

        If _grdSheet Is Nothing Then
            Return False
        End If

        For Each strColName As String In colNames
            Dim iColIndex As Integer = GetColumnIndex(_grdSheet, strColName)
            If iColIndex = -1 Then
                MsgBox("No column called " & strColName & " to select in grid.", MsgBoxStyle.Critical, "Cannot select column.")
                Return False
            End If

            For iRowIndex As Integer = 0 To _grdSheet.Rows - 1
                If _grdSheet(iRowIndex, iColIndex).ToString() = "" Then
                    Return False
                End If
            Next
        Next


        Return True

    End Function

    Public Function GetRowsCount() As Integer
        Return If(_grdSheet Is Nothing, 0, _grdSheet.Rows)
    End Function


    ''' <summary>
    ''' returns the column index of the column name passed from the sheet passed
    ''' </summary>
    ''' <param name="grdSheet"></param>
    ''' <param name="strColumnName"></param>
    ''' <returns>return -1 if column index not found</returns>
    Private Function GetColumnIndex(grdSheet As unvell.ReoGrid.Worksheet, strColumnName As String) As Integer
        For i As Integer = 0 To grdSheet.Columns - 1
            If grdSheet.ColumnHeaders(i).Text = strColumnName Then
                Return i
            End If
        Next
        Return -1
    End Function

    'used externally
    Public Function GetSelectedCellValues(strValueColName As String,
                                           bWithQuotes As Boolean) As List(Of String)
        'todo. validation of grid and columns. used externally

        If _grdSheet Is Nothing Then
            Return New List(Of String)
        End If

        Return GetSelectedCellValues(_grdSheet,
                                           GetColumnIndex(_grdSheet, DefaultColumnNames.Ordinal),
                                           GetColumnIndex(_grdSheet, DefaultColumnNames.Select_Level),
                                           GetColumnIndex(_grdSheet, strValueColName),
                                           bWithQuotes)
    End Function

    'used internally
    Private Function GetSelectedCellValues(grdSheet As unvell.ReoGrid.Worksheet,
                                           iOrdinalColIndex As Integer,
                                           iCheckedColIndex As Integer,
                                           iValueColIndex As Integer,
                                           bWithQuotes As Boolean) As List(Of String)

        Dim checked As Boolean
        Dim lstCellValues As New List(Of String)

        For iRowIndex As Integer = 0 To grdSheet.Rows - 1
            checked = DirectCast(grdSheet(iRowIndex, iCheckedColIndex), Boolean)
            If Not checked Then
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


    'used externaly
    Public Function GetCellValues(strColName As String, bWithQuotes As Boolean) As List(Of String)
        'todo. validation of grid and columns. used externally
        If _grdSheet Is Nothing Then
            Return New List(Of String)
        End If

        Return GetCellValues(_grdSheet, GetColumnIndex(_grdSheet, strColName), bWithQuotes)
    End Function



    'used internally
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
    ''' by default this is always called when subroutine OnControlValueChanged 
    ''' of this control is called
    ''' </summary>
    ''' <param name="clsTempParam"></param>
    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)

        'todo. delete later
        If shtCurrSheet IsNot Nothing Then
            UpdateParameterOLD(clsTempParam)
            Exit Sub
        End If

        If clsTempParam Is Nothing OrElse _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim strColName As String = _dctParamAndColNames.Item(clsTempParam.strArgumentName)
        Dim iValueColIndex As Integer = GetColumnIndex(_grdSheet, strColName)
        Dim strRValue As String = ""
        Select Case _enumControlState
            Case ControlStates.SingleSelectorGrid
            Case ControlStates.MultipleSelectorGrid
                Dim iOrdinalColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Ordinal)
                Dim iSelectorColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Select_Level)
                strRValue = mdlCoreControl.GetRVector(GetSelectedCellValues(_grdSheet,
                                                                            iOrdinalColIndex,
                                                                            iSelectorColIndex,
                                                                            iValueColIndex, True),
                                                      bOnlyIfMultipleElement:=(_enumControlState = ControlStates.SingleSelectorGrid))

            Case ControlStates.NormalGrid
                strRValue = mdlCoreControl.GetRVector(GetCellValues(_grdSheet, iValueColIndex, True))
        End Select

        clsTempParam.SetArgumentValue(strRValue)
    End Sub

    ''' <summary>
    ''' called when a dialog calls SetRCode for this control
    ''' </summary>
    Protected Overrides Sub SetControlValue()
        'todo. delete later
        If shtCurrSheet IsNot Nothing Then
            SetControlValueOLD()
            Exit Sub
        End If

        Dim clsTempParam As RParameter = GetParameter()
        If clsTempParam Is Nothing OrElse Not clsTempParam.bIsString OrElse _grdSheet Is Nothing Then
            Exit Sub
        End If

        Dim arrCellValues As String() = mdlCoreControl.ExtractItemsFromRList(clsTempParam.strArgumentValue)
        Dim strColName As String = _dctParamAndColNames.Item(clsTempParam.strArgumentName)
        Dim iValueColIndex As Integer = GetColumnIndex(_grdSheet, strColName)

        Select Case _enumControlState
            Case ControlStates.SingleSelectorGrid
            Case ControlStates.MultipleSelectorGrid
                Dim iSelectorColIndex As Integer = GetColumnIndex(_grdSheet, DefaultColumnNames.Select_Level)
                SetCheckedCells(_grdSheet, iSelectorColIndex, iValueColIndex, arrCellValues)
            Case ControlStates.NormalGrid
                If arrCellValues.Count <> _grdSheet.Rows Then
                    MsgBox("Developer error: Cannot set value of control " & Name & " because the list of values does not match the number of rows in the grid. check SetControl()")
                    Exit Sub
                End If
                SetCellValues(_grdSheet, iValueColIndex, arrCellValues)
        End Select
    End Sub

    ''used externally
    Public Sub SetCheckedCells(iCheckedColIndex As Integer,
                                iValueColIndex As Integer,
                                cellValues As IEnumerable(Of String), bSilent As Boolean)
        'todo. do checks like column exits etc
        SetCheckedCells(_grdSheet, iCheckedColIndex, iValueColIndex, cellValues)
    End Sub

    'used internally
    Private Sub SetCheckedCells(grdSheet As unvell.ReoGrid.Worksheet,
                                iCheckedColIndex As Integer,
                                iValueColIndex As Integer,
                                cellValues As IEnumerable(Of String))
        For iRowIndex As Integer = 0 To grdSheet.Rows - 1
            If grdSheet.Item(iRowIndex, iValueColIndex) = cellValues(iRowIndex) Then
                grdSheet(iRowIndex, iCheckedColIndex) = True
            Else
                grdSheet(iRowIndex, iCheckedColIndex) = False
            End If
        Next
    End Sub

    Private Sub SetCellValues(grdSheet As unvell.ReoGrid.Worksheet, iValueColIndex As Integer, cellValues As IEnumerable(Of String))
        For iRowIndex As Integer = 0 To grdSheet.RowCount - 1
            grdSheet(iRowIndex, iValueColIndex) = cellValues(iRowIndex)
        Next
    End Sub

    'used externally
    Public Sub SetCellValues(iValueColIndex As Integer, cellValues As IEnumerable(Of String), bSilent As Boolean)
        If cellValues.Count <> _grdSheet.Rows Then
            If Not bSilent Then
                MsgBox("Developer error: Cannot set value of control " & Name & " because the list of values does not match the number of rows in the grid.")
            End If
        ElseIf iValueColIndex < 0 OrElse iValueColIndex >= _grdSheet.Columns Then
            If Not bSilent Then
                MsgBox("Developer error: Cannot set value of control " & Name & " because there is no column at index " & iValueColIndex & " in the grid.")
            End If

        End If

        SetCellValues(_grdSheet, iValueColIndex, cellValues)
    End Sub



    '-----------------------------------------------

    'REMOVE ALL FUNCTIONS FROM HERE DOWNWARDS
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
        bIncludeNA = False
        strLevelsName = "Level"
        strLabelsName = "Label"
        strFreqName = "Freq"
    End Sub

    Public Sub UpdateParameterOLD(clsTempParam As RParameter)
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

    Protected Sub SetControlValueOLD()
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


    'todo. remove
    Public Sub SetReceiver(clsNewReceiver As ucrReceiverSingle)
        clsReceiver = clsNewReceiver
        If ucrChkLevels IsNot Nothing Then
            ucrChkLevels.Enabled = Not clsReceiver.IsEmpty
        End If
        RefreshFactorData()
    End Sub

    'todo. remove
    Public Sub AddEditableColumns(strColumns As String())
        lstEditableColumns.AddRange(strColumns)
        ApplyColumnSettings()
    End Sub

    'todo. remove
    Public Sub SetAsSingleSelector()
        bIsSelector = True
        bIsMultipleSelector = False
        bIsGridColumn = False
        RefreshFactorData()
    End Sub

    'todo. remove
    Public Sub SetAsMultipleSelector()
        bIsSelector = True
        bIsMultipleSelector = True
        bIsGridColumn = False
        RefreshFactorData()
    End Sub

    'todo. remove
    Public Sub SetIsGridColumn(strColumnName As String)
        bIsSelector = False
        bIsMultipleSelector = False
        bIsGridColumn = True
        strColumnToGet = strColumnName
        RefreshFactorData()
    End Sub

    'todo. remove
    Public Sub SetAsViewerOnly()
        bIsSelector = False
        bIsMultipleSelector = False
        RefreshFactorData()
    End Sub

    'todo. remove
    Private Sub SetEditableStatus(bEditable As Boolean)
        bIsEditable = bEditable
        If shtCurrSheet IsNot Nothing Then
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_Readonly, Not bEditable)
        End If
    End Sub

    'todo. remove
    Private Sub SetSelectorColumnName(strNewColumnName As String)
        strSelectorColumnName = strNewColumnName
        If iSelectorColumnIndex <> -1 Then
            shtCurrSheet.ColumnHeaders(iSelectorColumnIndex).Text = strSelectorColumnName
        Else
            RefreshFactorData()
        End If
    End Sub

    'todo. remove
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
        Dim expDataFrame As SymbolicExpression

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
                If bIncludeNA Then
                    clsGetFactorData.AddParameter("include_NA_level", "TRUE")
                Else
                    clsGetFactorData.AddParameter("include_NA_level", "FALSE")
                End If
                clsConvertToCharacter.SetRCommand("convert_to_character_matrix")
                clsConvertToCharacter.AddParameter("data", clsRFunctionParameter:=clsGetFactorData)
                expDataFrame = frmMain.clsRLink.RunInternalScriptGetValue(clsConvertToCharacter.ToScript(), bSilent:=True)
                If expDataFrame IsNot Nothing AndAlso expDataFrame.Type <> Internals.SymbolicExpressionType.Null Then
                    dfTemp = expDataFrame.AsDataFrame
                    frmMain.clsGrids.FillSheet(dfTemp, "Factor Data", grdFactorData)
                    shtCurrSheet = grdFactorData.CurrentWorksheet
                    shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToMoveCells, False)
                    bShowGrid = True
                    shtCurrSheet.SelectionForwardDirection = unvell.ReoGrid.SelectionForwardDirection.Down
                    iLevelsCol = GetColumnIndex(strLevelsName)
                    iLabelsCol = GetColumnIndex(strLabelsName)
                    iFreqCol = GetColumnIndex(strFreqName)
                    If bIncludeCopyOfLevels Then
                        shtCurrSheet.AppendColumns(1)
                        shtCurrSheet.ColumnHeaders(shtCurrSheet.ColumnCount - 1).Text = "New Label"
                        For i = 0 To shtCurrSheet.RowCount - 1
                            shtCurrSheet(i, shtCurrSheet.ColumnCount - 1) = shtCurrSheet(i, iLabelsCol)
                        Next
                    End If
                    If strExtraColumn <> "" Then
                        shtCurrSheet.AppendColumns(1)
                        shtCurrSheet.ColumnHeaders(shtCurrSheet.ColumnCount - 1).Text = strExtraColumn
                    End If
                    If bIsSelector Then
                        iSelectorColumnIndex = shtCurrSheet.ColumnCount
                        shtCurrSheet.AppendColumns(1)
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
            shtCurrSheet.SetSettings(unvell.ReoGrid.WorksheetSettings.Edit_DragSelectionToFillSerial, False)
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

    'todo. remove
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

    'todo. remove
    Private Sub clsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles clsReceiver.SelectionChanged
        RefreshFactorData()
    End Sub

    'todo. remove
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
                    bSelect = False
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
                    shtCurrSheet.SetRangeDataFormat(iNewRow, i, 1, 1, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)
                ElseIf shtCurrSheet.ColumnHeaders(i).Text = strLevelsName Then
                    shtCurrSheet(iNewRow, i) = ""
                    shtCurrSheet.SetRangeDataFormat(iNewRow, i, 1, 1, unvell.ReoGrid.DataFormat.CellDataFormatFlag.Text)
                ElseIf shtCurrSheet.ColumnHeaders(i).Text = strFreqName Then
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
                        'This checks if the value in the ordinal column is "-" which means it's the NA row
                        'so no quotes should be added.
                        'There could be a real factor level with the same label as (NA) so safer to check
                        'the Ordinal column which will only have "-" for the (NA) row.
                        If shtCurrSheet(i, 0) = "-" Then
                            strTemp = strTemp & shtCurrSheet(i, iLabelsCol)
                        Else
                            strTemp = strTemp & Chr(34) & shtCurrSheet(i, iLabelsCol) & Chr(34)
                        End If
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
        Dim i As Integer
        Dim iChecked As Boolean

        If Not bDoNotUpdateCells Then
            If e.Cell.Column = iSelectorColumnIndex AndAlso grdFactorData.Worksheets(0).SelectionRange.ContainsColumn(iSelectorColumnIndex) AndAlso grdFactorData.Worksheets(0).SelectionRange.Rows > 1 Then
                iChecked = DirectCast(e.Cell.Data, Boolean)
                bDoNotUpdateCells = True
                For i = grdFactorData.Worksheets(0).SelectionRange.Row To grdFactorData.Worksheets(0).SelectionRange.Row + grdFactorData.Worksheets(0).SelectionRange.Rows - 1
                    shtCurrSheet(i, iSelectorColumnIndex) = iChecked
                Next
                bDoNotUpdateCells = False
            End If
            UpdateCells(e.Cell.Column)
        End If
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

    Public Sub SetColumn(strValues As String(), iColumnIndex As Integer, Optional bSilent As Boolean = True)
        Dim i As Integer
        If shtCurrSheet IsNot Nothing Then
            If strValues.Count <> shtCurrSheet.RowCount Then
                If Not bSilent Then
                    MsgBox("Developer error: Cannot set value of control " & Name & " because the list of values does not match the number of levels.")
                End If
            ElseIf iColumnIndex < 0 OrElse iColumnIndex >= shtCurrSheet.ColumnCount Then
                If Not bSilent Then
                    MsgBox("Developer error: Cannot set value of control " & Name & " because there is no column at index " & iColumnIndex & " in the grid.")
                End If
            Else
                For i = 0 To shtCurrSheet.RowCount - 1
                    bDoNotUpdateCells = True 'my code. delete
                    shtCurrSheet(i, iColumnIndex) = strValues(i)
                    bDoNotUpdateCells = False ' my code. delete
                Next
            End If
        End If
    End Sub

    'Private Sub grdFactorData_VisibleChanged(sender As Object, e As EventArgs) Handles grdFactorData.VisibleChanged
    '    RaiseEvent GridVisibleChanged()
    'End Sub

    'Private Sub grdFactorData_Leave(sender As Object, e As EventArgs) Handles grdFactorData.Leave
    '    If shtCurrSheet IsNot Nothing AndAlso shtCurrSheet.IsEditing Then
    '        shtCurrSheet.EndEdit(unvell.ReoGrid.EndEditReason.NormalFinish)
    '    End If
    'End Sub

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
        RaiseEvent GridContentChanged()
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