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
''' Holds filter information for the dataframe
''' </summary>
Public Class clsDataFrameFilterOrColumnSelection
    Protected _strDataFrameName As String
    Protected _RLink As RLink

    Protected _bFilterApplied As Boolean
    Protected _bColumnSelectionApplied As Boolean
    Protected _iFilteredRowCount As Integer
    Protected _iSelectedColumnCount As Integer
    Protected _strFilterName As String
    Protected _strSelectionName As String

    Public ReadOnly Property iFilteredRowCount As Integer
        Get
            Return _iFilteredRowCount
        End Get
    End Property

    Public ReadOnly Property iSelectedColumnCount As Integer
        Get
            Return _iSelectedColumnCount
        End Get
    End Property

    Public ReadOnly Property strName As String
        Get
            Return _strFilterName
        End Get
    End Property

    Public ReadOnly Property strSelectionName As String
        Get
            Return _strSelectionName
        End Get
    End Property

    Public ReadOnly Property bFilterApplied() As Boolean
        Get
            Return _bFilterApplied
        End Get
    End Property

    Public ReadOnly Property bColumnSelectionApplied() As Boolean
        Get
            Return _bColumnSelectionApplied
        End Get
    End Property

    Public Sub New(rLink As RLink, strDataFrameName As String)
        _strDataFrameName = strDataFrameName
        _RLink = rLink
    End Sub

    Private Function GetFilterNameFromRCommand() As String
        Dim clsGetCurrentFilterName As New RFunction
        clsGetCurrentFilterName.SetRCommand(_RLink.strInstatDataObject & "$get_current_filter_name")
        clsGetCurrentFilterName.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34), iPosition:=0)
        Return _RLink.RunInternalScriptGetValue(clsGetCurrentFilterName.ToScript(), bSilent:=True).AsCharacter(0)
    End Function

    Private Function GetSelectionNameFromRCommand() As String
        Dim clsGetCurrentFilterName As New RFunction
        clsGetCurrentFilterName.SetRCommand(_RLink.strInstatDataObject & "$get_current_column_selection")
        clsGetCurrentFilterName.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34), iPosition:=0)
        Return _RLink.RunInternalScriptGetValue(clsGetCurrentFilterName.ToScript(), bSilent:=True).AsCharacter(0)
    End Function

    Private Function GetFilterAppliedFromRCommand() As Boolean
        Dim clsFilterApplied As New RFunction
        clsFilterApplied.SetRCommand(_RLink.strInstatDataObject & "$filter_applied")
        clsFilterApplied.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        Return _RLink.RunInternalScriptGetValue(clsFilterApplied.ToScript()).AsLogical(0)
    End Function

    Private Function GetColumnSelectionAppliedFromRCommand() As Boolean
        Dim clsColumnSelectionApplied As New RFunction
        clsColumnSelectionApplied.SetRCommand(_RLink.strInstatDataObject & "$column_selection_applied")
        clsColumnSelectionApplied.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        Return _RLink.RunInternalScriptGetValue(clsColumnSelectionApplied.ToScript()).AsLogical(0)
    End Function

    Public Sub RefreshData()
        _iFilteredRowCount = _RLink.GetDataFrameLength(_strDataFrameName, True)
        _iSelectedColumnCount = _RLink.GetDataFrameColumnCount(_strDataFrameName, True)
        _bFilterApplied = GetFilterAppliedFromRCommand()
        _bColumnSelectionApplied = GetColumnSelectionAppliedFromRCommand()
        _strFilterName = GetFilterNameFromRCommand()
        _strSelectionName = GetSelectionNameFromRCommand()
    End Sub

End Class
