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
''' <summary>
''' Class for holding any prepare functions that can be called from within the dataview grid, column metadata grid
''' and, meta data grid. 
''' </summary>
Public Class clsPrepareFunctionsForGrids
    Private ReadOnly _RLink As RLink
    Private ReadOnly _strDataFrame As String

    ''' <summary>
    ''' Create a new instance of prepare functions for an indivdual dataframe
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strDataFrame"></param>
    Public Sub New(rLink As RLink, strDataFrame As String)
        _RLink = rLink
        _strDataFrame = strDataFrame
    End Sub

    ''' <summary>
    ''' Delete one or many columns
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub DeleteColumn(lstColumnNames As List(Of String))
        Dim clsDeleteColumns As New RFunction
        clsDeleteColumns.SetRCommand(_RLink.strInstatDataObject & "$remove_columns_in_data")
        clsDeleteColumns.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))
        clsDeleteColumns.AddParameter("cols", _RLink.GetListAsRString(lstColumnNames))
        _RLink.RunScript(clsDeleteColumns.ToScript(), strComment:="Right click menu: Delete Column(s)")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to text type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToText(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to logical type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToLogical(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "logical" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Logical")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to factor type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToFactor(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Factor")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to ordered factor type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToOrderedFactor(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript, strComment:="Right click menu: Convert to Ordered Factor")
    End Sub

    ''' <summary>
    ''' Convert one or many columns to character type
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub ConvertToCharacter(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    ''' <summary>
    ''' Get the number of non numeric values within a column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetAmountOfNonNumericValuesInColumn(strColumnName As String) As Integer
        Dim expTemp As SymbolicExpression
        Dim clsGetColumnsFromData As New RFunction
        Dim clsNNonNumeric As New RFunction

        clsGetColumnsFromData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnsFromData.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsGetColumnsFromData.AddParameter("col_names", Chr(34) & strColumnName & Chr(34), iPosition:=1)
        clsGetColumnsFromData.AddParameter("use_current_filter", "FALSE", iPosition:=2)

        clsNNonNumeric.SetRCommand("n_non_numeric")
        clsNNonNumeric.AddParameter("x", clsRFunctionParameter:=clsGetColumnsFromData, iPosition:=0)
        expTemp = _RLink.RunInternalScriptGetValue(clsNNonNumeric.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsNumeric(0)
        Else
            Return 0 'Defaults to 0 if value cannot be got
        End If
    End Function

    ''' <summary>
    ''' Converts given column to numeric. 
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <param name="bIgnoreLabels"></param>
    Public Sub ConvertToNumeric(strColumnName As String, bIgnoreLabels As Boolean)
        Dim clsConvertToNumeric As New RFunction
        clsConvertToNumeric.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertToNumeric.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertToNumeric.AddParameter("col_names", Chr(34) & strColumnName & Chr(34), iPosition:=1)
        clsConvertToNumeric.AddParameter("to_type", Chr(34) & "numeric" & Chr(34), iPosition:=2)
        If bIgnoreLabels Then
            clsConvertToNumeric.AddParameter("ignore_labels", "TRUE", iPosition:=3)
        End If
        _RLink.RunScript(clsConvertToNumeric.ToScript(), strComment:="Right click menu: Convert Column(s) To Numeric")
    End Sub
    ''' <summary>
    ''' View dataframe the whole dataframe within a pop up
    ''' </summary>
    Public Sub ViewDataFrame()
        Dim clsGetDataFrame As New RFunction
        Dim clsViewDataFrame As New RFunction
        Dim strScript As String = ""
        Dim strTemp As String
        clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrame.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsViewDataFrame.SetRCommand("View")
        clsViewDataFrame.AddParameter("x", clsRFunctionParameter:=clsGetDataFrame)
        clsGetDataFrame.SetAssignTo(_strDataFrame)
        strTemp = clsViewDataFrame.ToScript(strScript)
        _RLink.RunScript(strScript & strTemp, strComment:="Right click menu: View R Data Frame", bSeparateThread:=False)
    End Sub
    ''' <summary>
    ''' insert new rows
    ''' </summary>
    ''' <param name="noOfRowsToAdd"></param>
    ''' <param name="currentRowHeader"></param>
    ''' <param name="bBefore"></param>
    Public Sub InsertRows(noOfRowsToAdd As Integer, currentRowHeader As String, bBefore As Boolean)
        Dim clsInsertRows As New RFunction
        clsInsertRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsInsertRows.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsInsertRows.AddParameter("start_row", currentRowHeader)
        clsInsertRows.AddParameter("number_rows", noOfRowsToAdd)
        If bBefore Then
            clsInsertRows.AddParameter("before", "TRUE")
            _RLink.RunScript(clsInsertRows.ToScript(), strComment:="Right click menu: Insert Row(s) Before")
        Else
            clsInsertRows.AddParameter("before", "FALSE")
            _RLink.RunScript(clsInsertRows.ToScript(), strComment:="Right click menu: Insert Row(s) After")
        End If
    End Sub
    ''' <summary>
    ''' deletes given rows
    ''' </summary>
    ''' <param name="lstRowNames"></param>
    Public Sub DeleteRows(lstRowNames As List(Of String))
        Dim clsDeleteRows As New RFunction
        clsDeleteRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
        clsDeleteRows.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsDeleteRows.AddParameter("row_names", _RLink.GetListAsRString(lstRowNames))
        _RLink.RunScript(clsDeleteRows.ToScript(), strComment:="Right click menu: Delete Row(s)")

    End Sub
    ''' <summary>
    ''' Removes current filter
    ''' </summary>
    Public Sub RemoveCurrentFilter()
        Dim clsRemoveFilter As New RFunction
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsRemoveFilter.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        _RLink.RunScript(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub
    ''' <summary>
    ''' Freeze selected columns
    ''' </summary>
    ''' <param name="strLastSelectedColumn"></param>
    Public Sub FreezeColumns(strLastSelectedColumn As String)
        Dim clsFreezeColumns As New RFunction
        clsFreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$freeze_columns")
        clsFreezeColumns.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsFreezeColumns.AddParameter("column", Chr(34) & strLastSelectedColumn & Chr(34))
        _RLink.RunScript(clsFreezeColumns.ToScript(), strComment:="Right click menu: Freeze Columns")
    End Sub
    ''' <summary>
    ''' UnFreeze selected columns
    ''' </summary>
    Public Sub UnFreezeColumns()
        Dim clsUnfreezeColumns As New RFunction
        clsUnfreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$unfreeze_columns")
        clsUnfreezeColumns.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        _RLink.RunScript(clsUnfreezeColumns.ToScript(), strComment:="Right click menu: Unfreeze Columns")
    End Sub
    ''' <summary>
    ''' Appends variables to Metadata
    ''' </summary>
    ''' <param name="lstColumnNames"></param>
    Public Sub AppendToVariablesMetadata(lstColumnNames As List(Of String))
        Dim clsAppendVariablesMetaData As New RFunction
        clsAppendVariablesMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsAppendVariablesMetaData.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsAppendVariablesMetaData.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames))
        clsAppendVariablesMetaData.AddParameter("property", "labels_label")
        clsAppendVariablesMetaData.AddParameter("new_val", "NULL")
        _RLink.RunScript(clsAppendVariablesMetaData.ToScript(), strComment:="Removed value labels")
    End Sub
    ''' <summary>
    ''' Paste values directly into the dataframe. Columns and start row given
    ''' </summary>
    ''' <param name="strClipBoardText"></param>
    ''' <param name="lstColumnNames"></param>
    ''' <param name="strStartRow"></param>
    Public Sub PasteValues(strClipBoardText As String, lstColumnNames As List(Of String), strStartRow As String)
        Dim clsPasteValues As New RFunction
        clsPasteValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$paste_from_clipboard")
        clsPasteValues.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))
        clsPasteValues.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames))
        clsPasteValues.AddParameter("start_row_pos", strStartRow)
        clsPasteValues.AddParameter("first_clip_row_is_header", "FALSE")
        clsPasteValues.AddParameter("clip_board_text", Chr(34) & strClipBoardText & Chr(34))
        _RLink.RunScript(clsPasteValues.ToScript(), strComment:="Paste Values In Data")
    End Sub
    ''' <summary>
    ''' Get data type label for a given column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetDataTypeLabel(strColumnName As String) As String
        Dim clsGetVariablesMetadata As New RFunction
        clsGetVariablesMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))
        clsGetVariablesMetadata.AddParameter("property", "data_type_label")
        clsGetVariablesMetadata.AddParameter("column", Chr(34) & strColumnName & Chr(34))
        Return _RLink.RunInternalScriptGetValue(clsGetVariablesMetadata.ToScript()).AsCharacter(0)
    End Function
    ''' <summary>
    ''' Get factor levels for a given column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetColumnFactorLevels(strColumnName As String) As CharacterVector
        Dim clsGetFactorLevels As New RFunction
        clsGetFactorLevels.SetRCommand(_RLink.strInstatDataObject & "$get_column_factor_levels")
        clsGetFactorLevels.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))
        clsGetFactorLevels.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        Return _RLink.RunInternalScriptGetValue(clsGetFactorLevels.ToScript()).AsCharacter
    End Function
    ''' <summary>
    ''' Replace value in given cell
    ''' </summary>
    ''' <param name="strNewValue"></param>
    ''' <param name="strColumnName"></param>
    ''' <param name="strRowText"></param>
    ''' <param name="bWithQuotes"></param>
    Public Sub ReplaceValueInData(strNewValue As String, strColumnName As String, strRowText As String, bWithQuotes As Boolean)
        Dim clsReplaceValue As New RFunction
        'trim white space from ends of value
        strNewValue = strNewValue.Trim()
        clsReplaceValue.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        clsReplaceValue.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))
        clsReplaceValue.AddParameter("col_name", Chr(34) & strColumnName & Chr(34))
        clsReplaceValue.AddParameter("rows", Chr(34) & strRowText & Chr(34))
        If bWithQuotes Then
            clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
        Else
            clsReplaceValue.AddParameter("new_value", strNewValue)
        End If
        _RLink.RunScript(clsReplaceValue.ToScript(), strComment:="Replace Value In Data")
    End Sub
    ''' <summary>
    ''' Get the column type for a given column
    ''' </summary>
    ''' <param name="strColumnName"></param>
    ''' <returns></returns>
    Public Function GetColumnType(strColumnName As String) As String
        Return _RLink.GetColumnType(_strDataFrame, strColumnName)
    End Function

End Class

