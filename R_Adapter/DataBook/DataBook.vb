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

Imports System.Drawing
Imports R_Adapter2.R_Adapter.Constant
Imports R_Adapter2.R_Adapter.RLink

''' <summary>
''' Holds the dataframes and metadata.
''' </summary>
'''
Namespace R_Adapter.DataBook

    Public Class DataBook
        Private _scriptRunner As ScriptRunner = ScriptRunner.SingletonInstance()
        Private _lstDataFrames As List(Of DataFrame)
        Private _lstAllDataFrames As New List(Of DataFrame)
        Private _clsDataFrameMetaData As DataFrameMetaData
        Private _maxRowsDisplayed As Integer
        Private _maxColumnsDisplayed As Integer

        'ToDo the colourPalette should not be passed like this
        Private _colourPalette As List(Of Color)

        ''' <summary>
        ''' Holds all the dataframes within the databook
        ''' </summary>
        ''' <returns></returns>
        Public Property DataFrames() As List(Of DataFrame)
            Get
                Return _lstDataFrames
            End Get
            Set(value As List(Of DataFrame))
                _lstDataFrames = value
            End Set
        End Property

        ''' <summary>
        ''' Holds the MetaData at a dataframe level.
        ''' Use the metadata at a dataframe level for any column metadata
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property clsDataFrameMetaData As DataFrameMetaData
            Get
                Return _clsDataFrameMetaData
            End Get
        End Property

        ''' <summary>
        ''' Creates a new instance. RLink must be passed to make sure R-commands can be run
        ''' </summary>
        ''' <param name="rLink"></param>
        Public Sub New(colourPalette As List(Of Color))
            _lstDataFrames = New List(Of DataFrame)
            _clsDataFrameMetaData = New DataFrameMetaData()
            _colourPalette = colourPalette
        End Sub

        Private Function HasDataChanged() As Boolean
            Dim clsDataChanged As New RFunction

            'ToDo This should check if there is a databook but can't understand how it works
            'If Not _RLink.bInstatObjectExists Then
            ' Return False
            'End If
            clsDataChanged.SetRCommand(RCodeConstant.DataBookName & "$get_data_changed")
            Return _scriptRunner.RunInternalScriptGetBoolean(clsDataChanged.ToScript())
        End Function

        ''' <summary>
        ''' Runs the R command to hide a dataframe of the given name
        ''' </summary>
        ''' <param name="strDataFrameName"></param>
        Public Sub HideDataFrame(strDataFrameName As String)
            Dim clsHideDataFrame As New RFunction
            clsHideDataFrame.SetRCommand(RCodeConstant.DataBookName & "$append_to_dataframe_metadata")
            clsHideDataFrame.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            clsHideDataFrame.AddParameter("property", "is_hidden_label")
            clsHideDataFrame.AddParameter("new_val", "TRUE")
            _scriptRunner.RunScript(clsHideDataFrame.ToScript(), strComment:="Right click menu: Hide Data Frame")
        End Sub

        ''' <summary>
        ''' Gets the dataframe within the databook corresponding to the given name
        ''' </summary>
        ''' <param name="strName"></param>
        ''' <returns></returns>
        Public Function GetDataFrame(strName As String) As DataFrame
            Return _lstDataFrames.Where(Function(x) x.strName = strName).FirstOrDefault
        End Function

        Public Function GetAllDataFrame(strName As String) As DataFrame
            Return _lstAllDataFrames.Where(Function(x) x.strName = strName).FirstOrDefault
        End Function

        ''' <summary>
        ''' Gets the Column Metadata for the dataframe name given
        ''' </summary>
        ''' <param name="strName"></param>
        ''' <returns></returns>
        Public Function GetColumnMetaData(strName As String) As ColumnMetaData
            Return _lstDataFrames.Where(Function(x) x.strName = strName).FirstOrDefault().clsColumnMetaData
        End Function

        ''' <summary>
        ''' Updates all the dataframes and metadata where the data has changed
        ''' </summary>
        Public Sub RefreshData(Optional maxRowsDisplayed As Integer = DisplayConstant.MaxRowsDisplayed, Optional maxColumnsDisplayed As Integer = DisplayConstant.maxColumnsDisplayed)
            _maxRowsDisplayed = maxRowsDisplayed
            _maxColumnsDisplayed = maxColumnsDisplayed
            'if no R Instat object exists then just clear all data frames in the databook
            'and refresh the data frame metadata from R
            'ToDo This should check if there is a databook but can't understand how it works
            'If Not _RLink.bInstatObjectExists Then
            '    _lstDataFrames.Clear()
            '    _lstAllDataFrames.Clear()
            '    _clsDataFrameMetaData = New clsDataFrameMetaData()
            '    Exit Sub
            'End If

            'else if the R Instat object data has changed
            'refresh data frames data and metadata
            If HasDataChanged() Then
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
            Dim dataFrame As DataFrame
            For Each strDataFrameName In lstOfCurrentRDataFrameNames
                dataFrame = _lstDataFrames.Where(Function(x) x.strName = strDataFrameName).SingleOrDefault
                If dataFrame Is Nothing Then
                    dataFrame = New DataFrame(strDataFrameName, _colourPalette)
                    _lstDataFrames.Add(dataFrame)
                End If
                'if data not refreshed successfully, remove the data frame from the data book
                If Not dataFrame.RefreshData(_maxRowsDisplayed, _maxColumnsDisplayed) Then
                    'ToDo Error Handling
                    'MessageBox.Show("Error: Could not retrieve data frame:" & strDataFrameName & " from R" &
                    '                Environment.NewLine & "Data displayed in spreadsheet may not be up to date." &
                    '                Environment.NewLine & "We strongly suggest restarting R-Instat before continuing.",
                    '                "Cannot retrieve data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    _lstDataFrames.Remove(dataFrame)
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
            Dim dataframeNames As String()
            Dim listOfDataFrames As New List(Of String)

            clsGetDataFrameNames.SetRCommand(RCodeConstant.DataBookName & "$get_data_names")
            clsGetDataFrameNames.AddParameter("include_hidden", "FALSE")

            dataframeNames = _scriptRunner.RunInternalScriptGetStringArray(clsGetDataFrameNames.ToScript())
            If dataframeNames IsNot Nothing Then
                For i = 0 To dataframeNames.Length - 1
                    listOfDataFrames.Add(dataframeNames(i))
                Next
            End If
            Return listOfDataFrames
        End Function

    End Class

End Namespace