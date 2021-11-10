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
''' Holds the dataframes and metadata.
''' </summary>
Public Class clsDataBook
    Private _RLink As RLink
    Private _dataFrames As List(Of clsDataFrame)
    Private _clsDataFrameMetaData As clsDataFrameMetaData

    ''' <summary>
    ''' Holds all the dataframes within the databook
    ''' </summary>
    ''' <returns></returns>
    Public Property DataFrames() As List(Of clsDataFrame)
        Get
            Return _dataFrames
        End Get
        Set(value As List(Of clsDataFrame))
            _dataFrames = value
        End Set
    End Property
    ''' <summary>
    ''' Holds the MetaData at a dataframe level. 
    ''' Use the metadata at a dataframe level for any column metadata
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property clsDataFrameMetaData As clsDataFrameMetaData
        Get
            Return _clsDataFrameMetaData
        End Get
    End Property

    ''' <summary>
    ''' Creates a new instance. RLink must be passed to make sure R-commands can be run
    ''' </summary>
    ''' <param name="rLink"></param>
    Public Sub New(rLink As RLink)
        _RLink = rLink
        _dataFrames = New List(Of clsDataFrame)
        _clsDataFrameMetaData = New clsDataFrameMetaData(rLink)
    End Sub

    Private Function HasDataChanged() As Boolean
        Dim clsDataChanged As New RFunction
        Dim expTemp As SymbolicExpression

        If Not _RLink.bInstatObjectExists Then
            Return False
        End If
        clsDataChanged.SetRCommand(_RLink.strInstatDataObject & "$get_data_changed")
        expTemp = _RLink.RunInternalScriptGetValue(clsDataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' Runs the R command to hide a dataframe of the given name
    ''' </summary>
    ''' <param name="strDataFrameName"></param>
    Public Sub HideDataFrame(strDataFrameName As String)
        Dim clsHideDataFrame As New RFunction
        clsHideDataFrame.SetRCommand(_RLink.strInstatDataObject & "$append_to_dataframe_metadata")
        clsHideDataFrame.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
        clsHideDataFrame.AddParameter("property", "is_hidden_label")
        clsHideDataFrame.AddParameter("new_val", "TRUE")
        _RLink.RunScript(clsHideDataFrame.ToScript(), strComment:="Right click menu: Hide Data Frame")
    End Sub

    Private Function CreateNewGridTab(strDataFrameName As String) As clsDataFrame
        Dim dataframe As New clsDataFrame(_RLink, strDataFrameName)
        _dataFrames.Add(dataframe)
        Return dataframe
    End Function

    ''' <summary>
    ''' Gets the dataframe within the databook corresponding to the given name
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <returns></returns>
    Public Function GetDataFrame(strName As String) As clsDataFrame
        Return _dataFrames.Where(Function(x) x.strName = strName).FirstOrDefault
    End Function
    ''' <summary>
    ''' Gets the Column Metadata for the dataframe name given
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <returns></returns>
    Public Function GetColumnMetaData(strName As String) As clsColumnMetaData
        Return _dataFrames.Where(Function(x) x.strName = strName).FirstOrDefault().clsColumnMetaData
    End Function

    ''' <summary>
    ''' Updates all the dataframes and metadata where the data has changed
    ''' </summary>
    Public Sub RefreshData()
        If Not _RLink.bInstatObjectExists Then
            DeleteAllDataFrames()
            _clsDataFrameMetaData = New clsDataFrameMetaData(_RLink)
            Exit Sub
        End If
        If HasDataChanged() Then
            Dim listOfDataFrames As List(Of String) = GetDataFrameNames()
            DeleteOldDataFrames(listOfDataFrames)
            For Each strDataFrameName In listOfDataFrames
                Dim dataFrame As clsDataFrame = GetOrCreateDataFrame(strDataFrameName)
                dataFrame.RefreshData()
            Next
            _clsDataFrameMetaData.RefreshData()
        End If
    End Sub

    Private Sub DeleteAllDataFrames()
        Dim listOfDataFrames As New List(Of String)
        DeleteOldDataFrames(listOfDataFrames)
    End Sub

    Private Function GetOrCreateDataFrame(strDataFrameName As String) As clsDataFrame
        Dim dataFrame As clsDataFrame
        dataFrame = _dataFrames.Where(Function(x) x.strName = strDataFrameName).SingleOrDefault
        If dataFrame Is Nothing Then
            dataFrame = CreateNewGridTab(strDataFrameName)
        End If
        Return dataFrame
    End Function

    Private Sub DeleteOldDataFrames(currentDataFrames As List(Of String))
        Dim gridTab As clsDataFrame
        For i = _dataFrames.Count - 1 To 0 Step -1
            gridTab = _dataFrames(i)
            If Not currentDataFrames.Contains(gridTab.strName) Then
                _dataFrames.RemoveAt(i)
            End If
        Next
    End Sub

    Private Function GetDataFrameNames() As List(Of String)
        Dim clsGetDataFrameNames As New RFunction
        Dim expTemp As SymbolicExpression
        Dim listOfDataFrames As New List(Of String)

        clsGetDataFrameNames.SetRCommand(_RLink.strInstatDataObject & "$get_data_names")
        clsGetDataFrameNames.AddParameter("include_hidden", "FALSE")

        expTemp = _RLink.RunInternalScriptGetValue(clsGetDataFrameNames.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing Then
            For i = 0 To expTemp.AsList.Length - 1
                listOfDataFrames.Add(expTemp.AsList.AsCharacter(i))
            Next
        End If
        Return listOfDataFrames
    End Function

End Class

