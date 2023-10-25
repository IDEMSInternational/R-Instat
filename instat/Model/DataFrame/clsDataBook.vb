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
    Private _lstDataFrames As List(Of clsDataFrame)
    Private _lstAllDataFrames As New List(Of clsDataFrame)
    Private _clsDataFrameMetaData As clsDataFrameMetaData

    ''' <summary>
    ''' Holds all the dataframes within the databook
    ''' </summary>
    ''' <returns></returns>
    Public Property DataFrames() As List(Of clsDataFrame)
        Get
            Return _lstDataFrames
        End Get
        Set(value As List(Of clsDataFrame))
            _lstDataFrames = value
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
        _lstDataFrames = New List(Of clsDataFrame)
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

    ''' <summary>
    ''' Gets the dataframe within the databook corresponding to the given name
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <returns></returns>
    Public Function GetDataFrame(strName As String) As clsDataFrame
        Return _lstDataFrames.Where(Function(x) x.strName = strName).FirstOrDefault
    End Function

    Public Function GetAllDataFrame(strName As String) As clsDataFrame
        Return _lstAllDataFrames.Where(Function(x) x.strName = strName).FirstOrDefault
    End Function

    ''' <summary>
    ''' Gets the Column Metadata for the dataframe name given
    ''' </summary>
    ''' <param name="strName"></param>
    ''' <returns></returns>
    Public Function GetColumnMetaData(strName As String) As clsColumnMetaData
        Return _lstDataFrames.Where(Function(x) x.strName = strName).FirstOrDefault().clsColumnMetaData
    End Function

    ''' <summary>
    ''' Updates all the dataframes and metadata where the data has changed
    ''' </summary>
    Public Sub RefreshData()
        'if no R Instat object exists then just clear all data frames in the databook
        'and refresh the data frame metadata from R
        If Not _RLink.bInstatObjectExists Then
            _lstDataFrames.Clear()
            _lstAllDataFrames.Clear()
            _clsDataFrameMetaData = New clsDataFrameMetaData(_RLink)
        ElseIf HasDataChanged() Then
            'else if the R Instat object data has changed
            'refresh data frames data and metadata 
            RefreshDataFrames()
            _clsDataFrameMetaData.RefreshData()
        End If
    End Sub

    ''' <summary>
    ''' refreshes data book with recent R data frames and the data frames with their recent R data
    ''' </summary>
    Private Sub RefreshDataFrames()
        'get the recent list of data frame names from R Instant
        Dim lstOfCurrentRDataFrameNames As List(Of String) = GetDataFrameNamesFromR()

        'add any data frames from this data book before removing them if not the R Instat object
        For Each clsDataframe In _lstDataFrames
            If Not _lstAllDataFrames.Contains(clsDataframe) Then
                _lstAllDataFrames.Add(clsDataframe)
            End If
        Next

        'remove any data frames from this data book that are not in the R Instat object
        _lstDataFrames.RemoveAll(Function(x) Not lstOfCurrentRDataFrameNames.Contains(x.strName))

        'add any R Instat object data frames missing in the data book
        'and also refresh data of the data book data frames 
        Dim dataFrame As clsDataFrame
        For Each strDataFrameName In lstOfCurrentRDataFrameNames
            dataFrame = _lstDataFrames.Where(Function(x) x.strName = strDataFrameName).SingleOrDefault
            If dataFrame Is Nothing Then
                dataFrame = New clsDataFrame(_RLink, strDataFrameName)
                _lstDataFrames.Add(dataFrame)
            End If
            'if data not refreshed successfully, remove the data frame from the data book
            If Not dataFrame.RefreshData() Then
                MessageBox.Show("Error: Sorry R-Instat can not retrieve the: " & strDataFrameName & " data from R.",
                                "Cannot retrieve data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                _lstDataFrames.Remove(dataFrame)
                DeleteDataFrames(strDataFrameName)
            End If
        Next
        If lstOfCurrentRDataFrameNames.Count = _lstDataFrames.Count Then
            _lstDataFrames = _lstDataFrames.OrderBy(Function(x) lstOfCurrentRDataFrameNames.IndexOf(x.strName)).ToList()
        End If
    End Sub


    ''' <summary>
    ''' Gets current data frame names from R (the R Instant object).
    ''' </summary>
    ''' <returns>list of data frame names. If no data frame names found, an empty list is returned</returns>
    Private Function GetDataFrameNamesFromR() As List(Of String)
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

    Private Sub DeleteDataFrames(strDataName As String)
        Dim clsDeleteFunction As New RFunction
        clsDeleteFunction.SetRCommand(_RLink.strInstatDataObject & "$delete_dataframes")
        clsDeleteFunction.AddParameter("data_names", Chr(34) & strDataName & Chr(34))
        _RLink.RunScript(clsDeleteFunction.ToScript(), strComment:="Delete DataFrame(s)")
    End Sub

End Class

