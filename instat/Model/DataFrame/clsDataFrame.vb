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
    Private _clsVisibleDataFramePage As clsDataFramePage
    Private _clsColumnMetaData As clsColumnMetaData
    Private _clsFilterOrColumnSelection As clsDataFrameFilterOrColumnSelection
    Private _strDataFrameName As String
    Private _RLink As RLink
    Private _iTotalRowCount As Integer
    Private _iTotalColumnCount As Integer

    ''' <summary>
    ''' Filter or column selection information
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property clsFilterOrColumnSelection() As clsDataFrameFilterOrColumnSelection
        Get
            Return _clsFilterOrColumnSelection
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
    ''' Column metadata for the dataframe
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
            Return _strDataFrameName
        End Get
    End Property

    ''' <summary>
    ''' Returns the data in a specific cell as an object
    ''' </summary>
    ''' <param name="iRow">Row index. Should be within the range of the visible data frame subset</param>
    ''' <param name="iColumn">Column index. Should be within the range of the visible data frame subset</param>
    ''' <returns></returns>
    Public ReadOnly Property DisplayedData(iRow As Integer, iColumn As Integer) As Object
        Get
            Return _clsVisibleDataFramePage.Data(iRow, iColumn)
        End Get
    End Property

    ''' <summary>
    ''' Returns an array of row names of the visible data frame subset
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property DisplayedRowNames() As String()
        Get
            Return _clsVisibleDataFramePage.RowNames()
        End Get
    End Property

    ''' <summary>
    ''' Returns how many rows are contained in the visible page 
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iDisplayedRowCount As Integer
        Get
            Return _clsVisibleDataFramePage.DisplayedRowCount
        End Get
    End Property

    ''' <summary>
    ''' Returns the total rows for the entire dataframe
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property iTotalRowCount() As Integer
        Get
            Return _iTotalRowCount
        End Get
    End Property

    ''' <summary>
    ''' Returns the total column count for entire the dataframe
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
    Public ReadOnly Property clsVisibleDataFramePage() As clsDataFramePage
        Get
            Return _clsVisibleDataFramePage
        End Get
    End Property

    ''' <summary>
    ''' Creates a new dataframe from the given name
    ''' </summary>
    ''' <param name="rLink"></param>
    ''' <param name="strDataFrameName"></param>
    Public Sub New(rLink As RLink, strDataFrameName As String)
        _RLink = rLink
        _strDataFrameName = strDataFrameName
        _clsPrepareFunctions = New clsPrepareFunctionsForGrids(rLink, strDataFrameName)
        _clsVisibleDataFramePage = New clsDataFramePage(rLink, strDataFrameName)
        _clsFilterOrColumnSelection = New clsDataFrameFilterOrColumnSelection(rLink, strDataFrameName)
        _clsColumnMetaData = New clsColumnMetaData(rLink, strDataFrameName)
    End Sub

    Private Function HasDataChanged() As Boolean
        Dim clsDataChanged As New RFunction
        Dim expTemp As SymbolicExpression

        clsDataChanged.SetRCommand(_RLink.strInstatDataObject & "$get_data_changed")
        clsDataChanged.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsDataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Updates dataframe where data has changed 
    ''' </summary>
    ''' <returns>Returns true if data frame is succesfully refeshed from R, false if otherwise</returns>
    Public Function RefreshData() As Boolean
        Dim bRefreshed As Boolean = True
        If HasDataChanged() Then
            'check if succesfully 'refreshed', that is, data frame was successfully set up from R
            If _clsVisibleDataFramePage.RefreshData() Then
                _iTotalRowCount = _RLink.GetDataFrameLength(_strDataFrameName, False)
                _iTotalColumnCount = _RLink.GetDataFrameColumnCount(_strDataFrameName)
                _clsFilterOrColumnSelection.RefreshData()
                If _clsFilterOrColumnSelection.bFilterApplied Then
                    _clsVisibleDataFramePage.SetTotalRowAndColumnCounts(_iTotalColumnCount, _clsFilterOrColumnSelection.iFilteredRowCount)
                Else
                    _clsVisibleDataFramePage.SetTotalRowAndColumnCounts(_iTotalColumnCount, _iTotalRowCount)
                End If
                ResetDataFramesChanged()
            Else
                bRefreshed = False
            End If
        End If
        _clsColumnMetaData.RefreshData()
        Return bRefreshed
    End Function

    Private Sub ResetDataFramesChanged()
        Dim clsSetDataFramesChanged As New RFunction
        clsSetDataFramesChanged.SetRCommand(_RLink.strInstatDataObject & "$set_data_frames_changed")
        clsSetDataFramesChanged.AddParameter("data_name", Chr(34) & _strDataFrameName & Chr(34))
        clsSetDataFramesChanged.AddParameter("new_val", "FALSE")
        _RLink.RunInternalScript(clsSetDataFramesChanged.ToScript(), bSilent:=True)
    End Sub

End Class
