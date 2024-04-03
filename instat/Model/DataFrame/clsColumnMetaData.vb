﻿' R- Instat
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
''' Holds Column Meta Data for a single dataframe
''' </summary>
Public Class clsColumnMetaData
    Private _strDataFrameName As String
    Private _RLink As RLink
    Private Property _clsColsMetadataDataFrame As DataFrame
    Private _hasChanged As Boolean

    Private _useColumnSelectionInMetaData As Boolean

    ''' <summary>
    ''' holds the metadata change audit id
    ''' </summary> 
    Public Property MetadataChangeAuditId As Integer

    ''' <summary>
    ''' Returns data for a given cell within the Column Meta data table
    ''' </summary>
    ''' <param name="iRowIndex"></param>
    ''' <param name="iColumnIndex"></param>
    ''' <returns></returns>
    Public ReadOnly Property Data(iRowIndex As Integer, iColumnIndex As Integer) As Object
        Get
            Return _clsColsMetadataDataFrame.Item(iRowIndex, iColumnIndex)
        End Get
    End Property

    ''' <summary>
    ''' Returns row name of a given row
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    Public ReadOnly Property strRowName(row As Integer) As String
        Get
            Return _clsColsMetadataDataFrame.RowNames(row)
        End Get
    End Property

    ''' <summary>
    ''' Returns total number of rows within the column metadata table
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iRowCount As Integer
        Get
            Return _clsColsMetadataDataFrame.RowCount
        End Get
    End Property

    ''' <summary>
    ''' Returns the column name of a given column
    ''' </summary>
    ''' <param name="column"></param>
    ''' <returns></returns>
    Public ReadOnly Property strColumnName(column As Integer) As String
        Get
            Return _clsColsMetadataDataFrame.ColumnNames(column)
        End Get
    End Property

    ''' <summary>
    ''' Returns total number of columns within the column metadata table
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iColumnCount As Integer
        Get
            Return _clsColsMetadataDataFrame.ColumnCount
        End Get
    End Property

    ''' <summary>
    ''' holds whether the dataframe is different from visual grid component
    ''' ToDo This is more ViewModel level not here where its stored
    ''' </summary>
    ''' <returns></returns>
    Public Property HasChanged() As Boolean
        Get
            Return _hasChanged
        End Get
        Set(value As Boolean)
            _hasChanged = value
        End Set
    End Property

    ''' <summary>
    ''' Creates new instance of a column metadata class
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strName"></param>
    Public Sub New(rLink As RLink, strName As String)
        _RLink = rLink
        _strDataFrameName = strName
        _hasChanged = True
        _useColumnSelectionInMetaData = True
    End Sub

    Public Property UseColumnSelectionInMetaData() As Boolean
        Get
            Return _useColumnSelectionInMetaData
        End Get
        Set(value As Boolean)
            _useColumnSelectionInMetaData = value
        End Set
    End Property

    Private Function HasDataChanged() As Boolean
        Dim clsVariablesMetadataChanged As New RFunction
        Dim expTemp As SymbolicExpression
        clsVariablesMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata_changed")
        clsVariablesMetadataChanged.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsVariablesMetadataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Updates column Meta Data if data has changed
    ''' </summary>
    Public Sub RefreshData()
        'Need to check to see if dataframe exists due to the column meta data not changing when sheets are un-hidden 
        If _clsColsMetadataDataFrame Is Nothing OrElse HasDataChanged() Then
            _clsColsMetadataDataFrame = GetColsMetadataFromRCommand()
            SetColsMetadataToNotChangedInR()

            'this change number should eventually come from R
            'once that is done;
            'HasDataChanged() should be re-implemeted
            'HasChanged property can be deleted
            'SetColsMetadataToNotChangedInR() can be deleted
            MetadataChangeAuditId += 1
        End If
    End Sub

    Private Function GetColsMetadataFromRCommand() As DataFrame
        Dim clsGetVariablesMetadata As New RFunction
        Dim expTemp As SymbolicExpression
        _hasChanged = True
        clsGetVariablesMetadata.SetRCommand(_RLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("convert_to_character", "TRUE")
        clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        'TODO. why not apply or not the column selection at the R level.
        clsGetVariablesMetadata.AddParameter("use_column_selection", If(UseColumnSelectionInMetaData, "TRUE", "FALSE"))
        expTemp = _RLink.RunInternalScriptGetValue(clsGetVariablesMetadata.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsDataFrame
        Else
            Return Nothing
        End If
    End Function

    Private Sub SetColsMetadataToNotChangedInR()
        Dim clsSetVariablesMetadataChanged As New RFunction
        clsSetVariablesMetadataChanged.SetRCommand(_RLink.strInstatDataObject & "$set_variables_metadata_changed")
        clsSetVariablesMetadataChanged.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsSetVariablesMetadataChanged.AddParameter("new_val", "FALSE")
        _RLink.RunInternalScript(clsSetVariablesMetadataChanged.ToScript(), bSilent:=True)
    End Sub
End Class

