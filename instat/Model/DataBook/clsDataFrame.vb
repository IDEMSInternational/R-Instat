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
    Private _intTotalRowCount As Integer
    Private _intTotalColumnCount As Integer
    ''' <summary>
    ''' Filter information
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Filter() As clsDataFrameFilter
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
    Public ReadOnly Property Name() As String
        Get
            Return _strName
        End Get
    End Property
    ''' <summary>
    ''' Returns the data in a specific cell as an object
    ''' </summary>
    ''' <param name="row"></param>
    ''' <param name="column"></param>
    ''' <returns></returns>
    Public ReadOnly Property Data(row As Integer, column As Integer) As Object
        Get
            Return _clsVisiblePage.Data(row, column)
        End Get
    End Property
    ''' <summary>
    ''' Returns the row name for a specific row
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    Public ReadOnly Property RowName(row As Integer) As String
        Get
            Return _clsVisiblePage.RowName(row)
        End Get
    End Property
    ''' <summary>
    ''' Returns how many rows are contained in the visible page 
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DisplayedRowCount As Integer
        Get
            Return _clsVisiblePage.DisplayedRowCount
        End Get
    End Property
    ''' <summary>
    ''' Returns the total rows for the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property TotalRowCount() As Integer
        Get
            Return _intTotalRowCount
        End Get
    End Property
    ''' <summary>
    ''' Returns the total column count for the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property TotalColumnCount() As Integer
        Get
            Return _intTotalColumnCount
        End Get
    End Property
    ''' <summary>
    ''' Returns a subset of the dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property VisiblePage() As clsDataFramePage
        Get
            Return _clsVisiblePage
        End Get
    End Property

    ''' <summary>
    ''' Creates a new dataframe from the given name
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="name"></param>
    Public Sub New(rLink As RLink, name As String)
        _RLink = rLink
        _strName = name
        _clsPrepareFunctions = New clsPrepareFunctionsForGrids(rLink, name)
        _clsVisiblePage = New clsDataFramePage(rLink, name)
        _clsFilter = New clsDataFrameFilter(rLink, name)
        _clsColumnMetaData = New clsColumnMetaData(rLink, name)
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
                _intTotalRowCount = _RLink.GetDataFrameLength(_strName, False)
                _intTotalColumnCount = _RLink.GetDataFrameColumnCount(_strName)
                _clsVisiblePage.SetTotalRowAndColumnCounts(_intTotalColumnCount, _intTotalRowCount)
                _clsFilter.RefreshData()
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
