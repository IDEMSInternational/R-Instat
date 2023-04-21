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
Imports R_Adapter2.R_Adapter.Constant
Imports R_Adapter2.R_Adapter.RLink
''' <summary>
''' Class for holding any prepare functions that can be called from within the dataview grid, column metadata grid
''' and, meta data grid. 
''' </summary>
Public Class clsPrepareFunctionsForGrids
    'Private ReadOnly _RLink As RLink
    Private ReadOnly _scriptRunner As ScriptRunner = ScriptRunner.SingletonInstance()
    ' Private ReadOnly _strDataFrame As String

    ''' <summary>
    ''' Create a new instance of prepare functions for an indivdual dataframe
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strDataFrame"></param>
    ''' ToDo Remove strDataFrame
    Public Sub New()
        '_RLink = RLink
        ' _strDataFrame = strDataFrame
    End Sub

    ''' <summary>
    ''' Delete one or many columns
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub DeleteColumn(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsDeleteColumns As New RFunction
        clsDeleteColumns.SetRCommand(RCodeConstant.DataBookName & "$remove_columns_in_data")
        clsDeleteColumns.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsDeleteColumns.AddParameter("cols", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames))
        _scriptRunner.RunScriptNoResult(clsDeleteColumns.ToScript(), "Right click menu: Delete Column(s)")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to text type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToText(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(RCodeConstant.DataBookName & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        _scriptRunner.RunScriptNoResult(clsConvertTo.ToScript(), "Right click menu: Convert Column(s) To Character")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to logical type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToLogical(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(RCodeConstant.DataBookName & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "logical" & Chr(34), iPosition:=2)
        _scriptRunner.RunScriptNoResult(clsConvertTo.ToScript(), "Right click menu: Convert Column(s) To Logical")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to factor type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToFactor(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(RCodeConstant.DataBookName & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)
        _scriptRunner.RunScriptNoResult(clsConvertTo.ToScript(), "Right click menu: Convert Column(s) To Factor")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to ordered factor type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToOrderedFactor(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(RCodeConstant.DataBookName & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34), iPosition:=2)
        _scriptRunner.RunScriptNoResult(clsConvertTo.ToScript, "Right click menu: Convert to Ordered Factor")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to character type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToCharacter(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(RCodeConstant.DataBookName & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        _scriptRunner.RunScriptNoResult(clsConvertTo.ToScript(), "Right click menu: Convert Column(s) To Character")
    End Sub

    ''' <summary>
    ''' Get the number of non numeric values within a column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetAmountOfNonNumericValuesInColumn(strDataFrame As String, strColumnName As String) As Integer
        Dim clsGetColumnsFromData As New RFunction
        Dim clsNNonNumeric As New RFunction

        clsGetColumnsFromData.SetRCommand(RCodeConstant.DataBookName & "$get_columns_from_data")
        clsGetColumnsFromData.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsGetColumnsFromData.AddParameter("col_names", Chr(34) & strColumnName & Chr(34), iPosition:=1)
        clsGetColumnsFromData.AddParameter("use_current_filter", "FALSE", iPosition:=2)

        clsNNonNumeric.SetRCommand("n_non_numeric")
        clsNNonNumeric.AddParameter("x", clsRFunctionParameter:=clsGetColumnsFromData, iPosition:=0)
        Return _scriptRunner.RunInternalScriptGetInteger(clsNNonNumeric.ToScript())
    End Function

    ''' <summary>
    ''' Converts given column to numeric. 
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <param name="bIgnoreLabels"></param>
    Public Sub ConvertToNumeric(strDataFrame As String, strColumnName As String, bIgnoreLabels As Boolean)
        Dim clsConvertToNumeric As New RFunction
        clsConvertToNumeric.SetRCommand(RCodeConstant.DataBookName & "$convert_column_to_type")
        clsConvertToNumeric.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsConvertToNumeric.AddParameter("col_names", Chr(34) & strColumnName & Chr(34), iPosition:=1)
        clsConvertToNumeric.AddParameter("to_type", Chr(34) & "numeric" & Chr(34), iPosition:=2)
        If bIgnoreLabels Then
            clsConvertToNumeric.AddParameter("ignore_labels", "TRUE", iPosition:=3)
        End If
        _scriptRunner.RunScriptNoResult(clsConvertToNumeric.ToScript(), "Right click menu: Convert Column(s) To Numeric")
    End Sub

    ''' <summary>
    '''  Check if the column factor contains labels.
    ''' </summary>
    Public Function CheckHasLabels(strDataFrame As String, strColumnName As String) As Boolean
        Dim clsColmnLabelsRFunction = New RFunction
        Dim clsGetColumnsFromData As New RFunction

        clsGetColumnsFromData.SetRCommand(RCodeConstant.DataBookName & "$get_columns_from_data")
        clsGetColumnsFromData.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsGetColumnsFromData.AddParameter("col_names", Chr(34) & strColumnName & Chr(34), iPosition:=1)
        clsGetColumnsFromData.AddParameter("use_current_filter", "FALSE", iPosition:=2)

        clsColmnLabelsRFunction.SetRCommand(RCodeConstant.DataBookName & "$has_labels")
        clsColmnLabelsRFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsColmnLabelsRFunction.AddParameter("col_names", clsRFunctionParameter:=clsGetColumnsFromData, iPosition:=1)

        Return _scriptRunner.RunInternalScriptGetBoolean(clsColmnLabelsRFunction.ToScript())
    End Function

    ''' <summary>
    ''' View dataframe the whole dataframe within a pop up
    ''' </summary>
    Public Sub ViewDataFrame(strDataFrame As String)
        Dim clsGetDataFrame As New RFunction
        Dim clsViewDataFrame As New RFunction
        Dim strScript As String = ""
        Dim strTemp As String
        clsGetDataFrame.SetRCommand(RCodeConstant.DataBookName & "$get_data_frame")
        clsGetDataFrame.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsViewDataFrame.SetRCommand("View")
        clsViewDataFrame.AddParameter("x", clsRFunctionParameter:=clsGetDataFrame)
        clsGetDataFrame.SetAssignTo(strDataFrame)
        strTemp = clsViewDataFrame.ToScript(strScript)
        'Although this shows the grid in a new window we don't need to process the result
        _scriptRunner.RunScriptNoResult(strScript & strTemp, "Right click menu: View R Data Frame")
    End Sub
    ''' <summary>
    ''' insert new rows
    ''' </summary>
    ''' <param name="noOfRowsToAdd"></param>
    ''' <param name="currentRowHeader"></param>
    ''' <param name="bBefore"></param>
    Public Sub InsertRows(strDataFrame As String, noOfRowsToAdd As Integer, currentRowHeader As String, bBefore As Boolean)
        Dim clsInsertRows As New RFunction
        clsInsertRows.SetRCommand(RCodeConstant.DataBookName & "$insert_row_in_data")
        clsInsertRows.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsInsertRows.AddParameter("start_row", currentRowHeader)
        clsInsertRows.AddParameter("number_rows", noOfRowsToAdd)
        If bBefore Then
            clsInsertRows.AddParameter("before", "TRUE")
            _scriptRunner.RunScriptNoResult(clsInsertRows.ToScript(), "Right click menu: Insert Row(s) Before")
        Else
            clsInsertRows.AddParameter("before", "FALSE")
            _scriptRunner.RunScriptNoResult(clsInsertRows.ToScript(), "Right click menu: Insert Row(s) After")
        End If
    End Sub
    ''' <summary>
    ''' deletes given rows
    ''' </summary>
    ''' <param name="lstRowNames"></param>
    Public Sub DeleteRows(strDataFrame As String, lstRowNames As List(Of String))
        Dim clsDeleteRows As New RFunction
        clsDeleteRows.SetRCommand(RCodeConstant.DataBookName & "$remove_rows_in_data")
        clsDeleteRows.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsDeleteRows.AddParameter("row_names", _scriptRunner.HelperFunctions.GetListAsRString(lstRowNames))
        _scriptRunner.RunScriptNoResult(clsDeleteRows.ToScript(), "Right click menu: Delete Row(s)")

    End Sub
    ''' <summary>
    ''' Removes current filter
    ''' </summary>
    Public Sub RemoveCurrentFilter(strDataFrame As String)
        Dim clsRemoveFilter As New RFunction
        clsRemoveFilter.SetRCommand(RCodeConstant.DataBookName & "$remove_current_filter")
        clsRemoveFilter.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        _scriptRunner.RunScriptNoResult(clsRemoveFilter.ToScript(), "Right click menu: Remove Current Filter")
    End Sub
    ''' <summary>
    ''' Removes current column selection
    ''' </summary>
    Public Sub RemoveCurrentColumnSelection(strDataFrame As String)
        Dim clsRemoveCurrentColumnSelection As New RFunction
        clsRemoveCurrentColumnSelection.SetRCommand(RCodeConstant.DataBookName & "$remove_current_column_selection")
        clsRemoveCurrentColumnSelection.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        _scriptRunner.RunScriptNoResult(clsRemoveCurrentColumnSelection.ToScript(), "Right click menu: Remove Current Column Selection")
    End Sub
    ''' <summary>
    ''' Freeze selected columns
    ''' </summary>
    ''' <param name="strLastSelectedColumn"></param>
    Public Sub FreezeColumns(strDataFrame As String, strLastSelectedColumn As String)
        Dim clsFreezeColumns As New RFunction
        clsFreezeColumns.SetRCommand(RCodeConstant.DataBookName & "$freeze_columns")
        clsFreezeColumns.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsFreezeColumns.AddParameter("column", Chr(34) & strLastSelectedColumn & Chr(34))
        _scriptRunner.RunScriptNoResult(clsFreezeColumns.ToScript(), "Right click menu: Freeze Columns")
    End Sub
    ''' <summary>
    ''' UnFreeze selected columns
    ''' </summary>
    Public Sub UnFreezeColumns(strDataFrame As String)
        Dim clsUnfreezeColumns As New RFunction
        clsUnfreezeColumns.SetRCommand(RCodeConstant.DataBookName & "$unfreeze_columns")
        clsUnfreezeColumns.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        _scriptRunner.RunScriptNoResult(clsUnfreezeColumns.ToScript(), "Right click menu: Unfreeze Columns")
    End Sub
    ''' <summary>
    ''' Appends variables to Metadata
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub AppendToVariablesMetadata(strDataFrame As String, lstColumnNames As List(Of String))
        Dim clsAppendVariablesMetaData As New RFunction
        clsAppendVariablesMetaData.SetRCommand(RCodeConstant.DataBookName & "$append_to_variables_metadata")
        clsAppendVariablesMetaData.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        clsAppendVariablesMetaData.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames))
        clsAppendVariablesMetaData.AddParameter("property", "labels_label")
        clsAppendVariablesMetaData.AddParameter("new_val", "NULL")
        _scriptRunner.RunScriptNoResult(clsAppendVariablesMetaData.ToScript(), "Removed value labels")
    End Sub
    ''' <summary>
    ''' Paste values directly into the dataframe. Columns and start row given
    ''' </summary>
    ''' <param name="strClipBoardText"></param>
    ''' <param name="lstColumnNames"></param>
    ''' <param name="strStartRow"></param>
    Public Sub PasteValues(strDataFrame As String, strClipBoardText As String, lstColumnNames As List(Of String), strStartRow As String)
        Dim clsPasteValues As New RFunction
        clsPasteValues.SetRCommand(RCodeConstant.DataBookName & "$paste_from_clipboard")
        clsPasteValues.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsPasteValues.AddParameter("col_names", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames))
        clsPasteValues.AddParameter("start_row_pos", strStartRow)
        clsPasteValues.AddParameter("first_clip_row_is_header", "FALSE")
        clsPasteValues.AddParameter("clip_board_text", Chr(34) & strClipBoardText & Chr(34))
        _scriptRunner.RunScriptNoResult(clsPasteValues.ToScript(), "Paste Values In Data")
    End Sub
    ''' <summary>
    ''' Get data type label for a given column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetDataTypeLabel(strDataFrame As String, strColumnName As String) As String
        Dim clsGetVariablesMetadata As New RFunction
        clsGetVariablesMetadata.SetRCommand(RCodeConstant.DataBookName & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsGetVariablesMetadata.AddParameter("property", "data_type_label")
        clsGetVariablesMetadata.AddParameter("column", Chr(34) & strColumnName & Chr(34))
        Return _scriptRunner.RunInternalScriptGetString(clsGetVariablesMetadata.ToScript())
    End Function
    ''' <summary>
    ''' Get factor levels for a given column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetColumnFactorLevels(strDataFrame As String, strColumnName As String) As String()
        Dim clsGetFactorLevels As New RFunction
        clsGetFactorLevels.SetRCommand(RCodeConstant.DataBookName & "$get_column_factor_levels")
        clsGetFactorLevels.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsGetFactorLevels.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        Return _scriptRunner.RunInternalScriptGetStringArray(clsGetFactorLevels.ToScript())
    End Function
    ''' <summary>
    ''' Replace value in given cell
    ''' </summary>
    ''' <param name="strNewValue"></param>
    ''' <param name="strColumnName"></param>
    ''' <param name="strRowText"></param>
    ''' <param name="bWithQuotes"></param>
    ''' <param name="bListOfVector"></param>
    Public Sub ReplaceValueInData(strDataFrame As String, strNewValue As String, strColumnName As String, strRowText As String, bWithQuotes As Boolean, Optional bListOfVector As Boolean = False, Optional bAddOutputInInternalViewer As Boolean = True)
        Dim clsReplaceValue As New RFunction
        'trim white space from ends of value
        strNewValue = strNewValue.Trim()
        clsReplaceValue.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsReplaceValue.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsReplaceValue.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        clsReplaceValue.AddParameter("rows", Chr(34) & strRowText & Chr(34))
        If bListOfVector Then
            strNewValue = "list(c(" & strNewValue & "))"
        End If
        If bWithQuotes Then
            clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
        Else
            clsReplaceValue.AddParameter("new_value", strNewValue)
        End If
        _scriptRunner.RunScriptNoResult(clsReplaceValue.ToScript(), "Replace Value In Data")
    End Sub

    ''' <summary>
    ''' Get the column type for a given column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetColumnType(strDataFrame As String, strColumnName As String) As String
        Return _scriptRunner.GetColumnType(strDataFrame, strColumnName)
    End Function

    ''' <summary>
    '''  Description: To Delete one or many cells 
    ''' the delete cell function is to be used to Replace selected values with NA 
    ''' in the dataframe.
    '''</summary>
    ''' <param name="lstColumnNames"></param>
    ''' <param name="lstRowNames"></param>
    Public Sub DeleteCells(strDataFrame As String, lstRowNames As List(Of String), lstColumnNames As List(Of String))
        Dim clsDeleteCells As New RFunction
        clsDeleteCells.SetRCommand(RCodeConstant.DataBookName & "$replace_values_with_NA")
        clsDeleteCells.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34))
        clsDeleteCells.AddParameter("column_index", _scriptRunner.HelperFunctions.GetListAsRString(lstColumnNames, bWithQuotes:=False))
        clsDeleteCells.AddParameter("row_index", _scriptRunner.HelperFunctions.GetListAsRString(lstRowNames, bWithQuotes:=False))
        _scriptRunner.RunScriptNoResult(clsDeleteCells.ToScript(), "Right click menu: Delete Cell(s)")
    End Sub
End Class

