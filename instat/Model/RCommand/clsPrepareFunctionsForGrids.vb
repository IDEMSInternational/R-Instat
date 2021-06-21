Imports RDotNet

Public Class clsPrepareFunctionsForGrids
    'should inherit from clsFunctionRunner

    Private _RLink As RLink
    Private _strDataFrame As String

    'This should be passed as an interface
    Public Sub New(rLink As RLink, strDataFrame As String)
        _RLink = rLink
        _strDataFrame = strDataFrame
    End Sub



    'This could be a function and return a pass fail
    Public Sub ConvertColumnTypeToFactor(lstColumnNames As List(Of String))
        'TODO This looks like it doesnt work
        '  Dim clsConvertTo As New clsRFunctionConvertColumnType
        ' clsConvertTo.AddAllParameters("1", "2", "3")
        ' _RLink.RunScript(clsConvertTo.ToScript, strComment:="Right click menu: Convert to Ordered Factor")
    End Sub


    Public Sub DeleteColumn(lstColumnNames As List(Of String))
        Dim clsDeleteColumns As New RFunction
        clsDeleteColumns.SetRCommand(_RLink.strInstatDataObject & "$remove_columns_in_data")
        clsDeleteColumns.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsDeleteColumns.AddParameter("cols", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        _RLink.RunScript(clsDeleteColumns.ToScript(), "Right click menu: Delete Column(s)")
    End Sub

    Public Sub ConvertToText(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

    Public Sub ConvertToLogical(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "logical" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Logical")
    End Sub

    Public Sub ConvertToFactor(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Factor")
    End Sub

    Public Sub ConvertToOrderedFactor(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "ordered_factor" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript, strComment:="Right click menu: Convert to Ordered Factor")
    End Sub

    Public Sub ConvertToCharacter(lstColumnNames As List(Of String))
        Dim clsConvertTo As New RFunction
        clsConvertTo.SetRCommand(_RLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertTo.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsConvertTo.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames), iPosition:=1)
        clsConvertTo.AddParameter("to_type", Chr(34) & "character" & Chr(34), iPosition:=2)
        _RLink.RunScript(clsConvertTo.ToScript(), strComment:="Right click menu: Convert Column(s) To Character")
    End Sub

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

    Public Sub InsertRows(noOfRowsToAdd As Integer, currentRowHeader As String, bBefore As Boolean)
        Dim clsInsertRows As New RFunction
        clsInsertRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsInsertRows.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsInsertRows.AddParameter("start_row", currentRowHeader)
        clsInsertRows.AddParameter("number_rows", noOfRowsToAdd)
        If bBefore Then
            clsInsertRows.AddParameter("before", "TRUE")
            _RLink.RunScript(clsInsertRows.ToScript(), strComment:="Right click menu: Insert row(s) Before")
        Else
            clsInsertRows.AddParameter("before", "FALSE")
            _RLink.RunScript(clsInsertRows.ToScript(), strComment:="Right click menu: Insert row(s) After")
        End If
    End Sub

    Public Sub DeleteRows(lstColumnNames As List(Of String))
        Dim clsDeleteRows As New RFunction
        clsDeleteRows.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_rows_in_data")
        clsDeleteRows.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsDeleteRows.AddParameter("row_names", _RLink.GetListAsRString(lstColumnNames))
        _RLink.RunScript(clsDeleteRows.ToScript(), strComment:="Right click menu: Delete row(s)")

    End Sub

    Public Sub RemoveCurrentFilter()
        Dim clsRemoveFilter As New RFunction
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsRemoveFilter.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        _RLink.RunScript(clsRemoveFilter.ToScript(), strComment:="Right click menu: Remove Current Filter")
    End Sub

    Public Sub FreezeColumns(strLastSelectedColumn As String)
        Dim clsFreezeColumns As New RFunction
        clsFreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$freeze_columns")
        clsFreezeColumns.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsFreezeColumns.AddParameter("column", Chr(34) & strLastSelectedColumn & Chr(34))
        _RLink.RunScript(clsFreezeColumns.ToScript(), strComment:="Right click menu: Freeze columns")
    End Sub

    Public Sub UnFreezeColumns()
        Dim clsUnfreezeColumns As New RFunction
        clsUnfreezeColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$unfreeze_columns")
        clsUnfreezeColumns.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        _RLink.RunScript(clsUnfreezeColumns.ToScript(), strComment:="Right click menu: Freeze columns")
    End Sub

    Public Sub AppendToVariablesMetadata(lstColumnNames As List(Of String))
        Dim clsAppendVariablesMetaData As New RFunction
        clsAppendVariablesMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsAppendVariablesMetaData.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34), iPosition:=0)
        clsAppendVariablesMetaData.AddParameter("col_names", _RLink.GetListAsRString(lstColumnNames))
        clsAppendVariablesMetaData.AddParameter("property", "labels_label")
        clsAppendVariablesMetaData.AddParameter("new_val", "NULL")
        _RLink.RunScript(clsAppendVariablesMetaData.ToScript(), strComment:="Removed value labels")
    End Sub


    'Private Function ConvertNamesToRParameterString(lstNames As List(Of String)) As String
    '    Dim strCols As String
    '    strCols = "c("
    '    For j As Integer = 0 To lstNames.Count - 1
    '        If j > 0 Then
    '            strCols &= ","
    '        End If
    '        strCols = strCols & Chr(34) & lstNames(j) & Chr(34)

    '    Next
    '    strCols &= ")"
    '    Return strCols
    'End Function

    Public Function ReplaceValueInData(strNewValue As String, strRowText As String, iCol As Integer, ByRef strReturnMessage As String) As Boolean
        Dim dblValue As Double
        Dim iValue As Integer
        Dim clsGetVariablesMetadata As New RFunction
        Dim clsGetFactorLevels As New RFunction
        Dim clsReplaceValue As New RFunction
        Dim strCellDataType As String
        Dim chrCurrentFactorLevels As CharacterVector
        Dim bValid As Boolean = False

        'trim white space from ends of value
        strNewValue = strNewValue.Trim()

        clsGetFactorLevels.SetRCommand(_RLink.strInstatDataObject & "$get_column_factor_levels")
        clsGetFactorLevels.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))

        clsGetVariablesMetadata.SetRCommand(_RLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & _strDataFrame & Chr(34))
        clsGetVariablesMetadata.AddParameter("property", "data_type_label")

        'TODO remove comments from code - sort out column headers
        'clsGetVariablesMetadata.AddParameter("column", Chr(34) & _columnHeaders(iCol).Name & Chr(34))
        'clsGetFactorLevels.AddParameter("col_name", Chr(34) & _columnHeaders(iCol).Name & Chr(34))
        strCellDataType = _RLink.RunInternalScriptGetValue(clsGetVariablesMetadata.ToScript()).AsCharacter(0)


        'clsReplaceValue.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$replace_value_in_data")
        'clsReplaceValue.AddParameter("col_name", Chr(34) & _columnHeaders(iCol).Name & Chr(34))
        'clsReplaceValue.AddParameter("rows", Chr(34) & strRowText & Chr(34))

        If strNewValue = "NA" Then
            clsReplaceValue.AddParameter("new_value", strNewValue)
            bValid = True
        Else
            Select Case strCellDataType
                Case "factor"
                    chrCurrentFactorLevels = frmMain.clsRLink.RunInternalScriptGetValue(clsGetFactorLevels.ToScript()).AsCharacter
                    If Not chrCurrentFactorLevels.Contains(strNewValue) Then
                        strReturnMessage = "Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: factor. Values must be an existing level of this factor column."
                    Else
                        clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
                        bValid = True
                    End If
                Case "numeric"
                    If Double.TryParse(strNewValue, dblValue) Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                        bValid = True
                    Else
                        strReturnMessage = "Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: numeric. Values must be numeric."
                    End If
                Case "integer"
                    If Integer.TryParse(strNewValue, iValue) Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                        bValid = True
                    Else
                        strReturnMessage = "Invalid value: '" & strNewValue & "'" & Environment.NewLine & "This column is: integer. Values must be integer."
                    End If
                Case Else
                    If Double.TryParse(strNewValue, dblValue) OrElse strNewValue = "TRUE" OrElse strNewValue = "FALSE" Then
                        clsReplaceValue.AddParameter("new_value", strNewValue)
                    Else
                        clsReplaceValue.AddParameter("new_value", Chr(34) & strNewValue & Chr(34))
                    End If
                    bValid = True
            End Select
        End If

        If bValid Then
            _RLink.RunScript(clsReplaceValue.ToScript(), strComment:="Replace Value in Data")
        End If
        Return bValid
    End Function

End Class

