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
''' Holds data for the dataframe so that it can be displayed. 
''' </summary>
Public Class clsDataFrame
    Private _clsPrepareFunctions As clsPrepareFunctionsForGrids
    Private _clsVisiblePage As clsDataFramePage
    Private _clsColumnMetaData As clsColumnMetaData
    Private _clsFilter As clsDataFrameFilter
    Private _strName As String
    Private _RLink As RLink
    Private _iTotalRowCount As Integer
    Private _iTotalColumnCount As Integer

    ''' <summary>
    ''' Filter information
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property clsFilter() As clsDataFrameFilter
        Get
            Return _clsFilter
        End Get
    End Property

    ''' <summary>
    ''' Simple R functions that can be called from the gird
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property clsPrepareFunctions As clsPrepareFunctionsForGrids
        Get
            Return _clsPrepareFunctions
        End Get
    End Property

    ''' <summary>
    ''' Column meta data for the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property clsColumnMetaData As clsColumnMetaData
        Get
            Return _clsColumnMetaData
        End Get
    End Property

    ''' <summary>
    ''' Name of the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property strName() As String
        Get
            Return _strName
        End Get
    End Property

    ''' <summary>
    ''' Returns the data in a specific cell as an object
    ''' </summary>
    ''' <param name="iRow"></param>
    ''' <param name="iColumn"></param>
    ''' <returns></returns>
    Public ReadOnly Property Data(iRow As Integer, iColumn As Integer) As Object
        Get
            Return _clsVisiblePage.Data(iRow, iColumn)
        End Get
    End Property

    ''' <summary>
    ''' Returns the row names
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property strRowNames() As String()
        Get
            Return _clsVisiblePage.RowNames()
        End Get
    End Property

    ''' <summary>
    ''' Returns how many rows are contained in the visible page 
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iDisplayedRowCount As Integer
        Get
            Return _clsVisiblePage.DisplayedRowCount
        End Get
    End Property

    ''' <summary>
    ''' Returns the total rows for the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iTotalRowCount() As Integer
        Get
            Return _iTotalRowCount
        End Get
    End Property

    ''' <summary>
    ''' Returns the total column count for the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iTotalColumnCount() As Integer
        Get
            Return _iTotalColumnCount
        End Get
    End Property

    ''' <summary>
    ''' Returns a subset of the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property clsVisiblePage() As clsDataFramePage
        Get
            Return _clsVisiblePage
        End Get
    End Property

    ''' <summary>
    ''' Creates a new dataframe from the given name
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strName"></param>
    Public Sub New(rLink As RLink, strName As String)
        _RLink = rLink
        _strName = strName
        _clsPrepareFunctions = New clsPrepareFunctionsForGrids(rLink, strName)
        _clsVisiblePage = New clsDataFramePage(rLink, strName)
        _clsFilter = New clsDataFrameFilter(rLink, strName)
        _clsColumnMetaData = New clsColumnMetaData(rLink, strName)
    End Sub

    Private Function HasDataChanged() As Boolean
        Dim clsDataChanged As New RFunction
        Dim expTemp As SymbolicExpression

        clsDataChanged.SetRCommand(_RLink.strInstatDataObject & "$get_data_changed")
        clsDataChanged.AddParameter("data_name", Chr(34) & _strName & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsDataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Updates datframe where data has changed 
    ''' </summary>
    Public Sub RefreshData()
        If HasDataChanged() Then
            If _clsVisiblePage.RefreshData() Then
                _iTotalRowCount = _RLink.GetDataFrameLength(_strName, False)
                _iTotalColumnCount = _RLink.GetDataFrameColumnCount(_strName)
                _clsFilter.RefreshData()
                If _clsFilter.bApplied Then
                    _clsVisiblePage.SetTotalRowAndColumnCounts(_iTotalColumnCount, _clsFilter.iFilteredRowCount)
                Else
                    _clsVisiblePage.SetTotalRowAndColumnCounts(_iTotalColumnCount, _iTotalRowCount)
                End If
                ResetDataFramesChanged()
            End If
        End If
        _clsColumnMetaData.RefreshData()
    End Sub

    Private Sub ResetDataFramesChanged()
        Dim clsSetDataFramesChanged As New RFunction
        clsSetDataFramesChanged.SetRCommand(_RLink.strInstatDataObject & "$set_data_frames_changed")
        clsSetDataFramesChanged.AddParameter("data_name", Chr(34) & _strName & Chr(34))
        clsSetDataFramesChanged.AddParameter("new_val", "FALSE")
        _RLink.RunInternalScript(clsSetDataFramesChanged.ToScript(), bSilent:=True)
    End Sub

End Class
