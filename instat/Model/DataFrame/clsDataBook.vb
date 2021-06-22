Imports RDotNet

Public Class clsDataBook
    Private _RLink As RLink
    Private _dataFrames As List(Of clsDataFrame)
    Private _clsDataFrameMetaData As clsDataFrameMetaData
    ' Protected _currentFocus As clsDataFrame

    Public Property DataFrames() As List(Of clsDataFrame)
        Get
            Return _dataFrames
        End Get
        Set(value As List(Of clsDataFrame))
            _dataFrames = value
        End Set
    End Property

    Public ReadOnly Property clsDataFrameMetaData As clsDataFrameMetaData
        Get
            Return _clsDataFrameMetaData
        End Get
    End Property

    'Public ReadOnly Property CurrentDataFrameFocus As clsDataFrame
    '    Get
    '        Return _currentFocus
    '    End Get
    'End Property

    Public Sub New(rLink As RLink)
        _RLink = rLink
        _dataFrames = New List(Of clsDataFrame)
        _clsDataFrameMetaData = New clsDataFrameMetaData(rLink)
    End Sub

    Protected Function HasDataChanged() As Boolean
        Dim clsDataChanged As New RFunction
        Dim expTemp As SymbolicExpression

        If Not _RLink.bInstatObjectExists Then
            Return False
        End If
        'TODO can this be used for individual dataframes - possibly using data_name
        clsDataChanged.SetRCommand(_RLink.strInstatDataObject & "$get_data_changed")
        expTemp = _RLink.RunInternalScriptGetValue(clsDataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            'raise error
            Return False
            'If Not bMessageShown Then
            '    MsgBox("Error: Could not retrieve data frames from R. Data displayed in spreadsheet may not be up to date." & Environment.NewLine & "We strongly suggest restarting R-Instat before continuing.", MsgBoxStyle.Exclamation, "Cannot retrieve data")
            '    bMessageShown = True
            'End If
            'bRDataChanged = False
        End If
    End Function


    Public Sub HideDataFrame(dataFrameName As String)
        Dim clsHideDataFrame As New RFunction
        clsHideDataFrame.SetRCommand(_RLink.strInstatDataObject & "$append_to_dataframe_metadata")
        clsHideDataFrame.AddParameter("data_name", Chr(34) & dataFrameName & Chr(34))
        clsHideDataFrame.AddParameter("property", "is_hidden_label")
        clsHideDataFrame.AddParameter("new_val", "TRUE")
        _RLink.RunScript(clsHideDataFrame.ToScript(), strComment:="Right click menu: Hide Data Frame")
    End Sub

    Protected Function CreateNewGridTab(strDataFrameName As String) As clsDataFrame
        Dim dataframe As New clsDataFrame(_RLink, strDataFrameName)
        _dataFrames.Add(dataframe)
        Return dataframe
    End Function

    Public Function GetDataFrame(strName As String) As clsDataFrame
        Return _dataFrames.Where(Function(x) x.Name = strName).FirstOrDefault
    End Function

    Public Function GetColumnMetaData(strName As String) As clsColumnMetaData
        Return _dataFrames.Where(Function(x) x.Name = strName).FirstOrDefault().clsColumnMetaData
    End Function


    Public Sub UpdateGrids()
        Dim listOfDataFrames As List(Of String)
        Dim dataFrame As clsDataFrame
        If HasDataChanged() Then
            listOfDataFrames = GetDataFrameNames()
            DeleteOldGridTabs(listOfDataFrames)
            For Each strDataFrameName In listOfDataFrames
                dataFrame = GetOrCreateDataFrame(strDataFrameName)
                dataFrame.RefreshData()
            Next
            _clsDataFrameMetaData.RefreshData()
        End If
    End Sub

    Protected Function GetOrCreateDataFrame(strDataFrameName As String) As clsDataFrame
        Dim dataFrame As clsDataFrame
        dataFrame = _dataFrames.Where(Function(x) x.Name = strDataFrameName).SingleOrDefault
        If dataFrame Is Nothing Then
            dataFrame = CreateNewGridTab(strDataFrameName)
        End If
        Return dataFrame
    End Function



    Private Sub DeleteOldGridTabs(currentDataFrames As List(Of String))
        Dim gridTab As clsDataFrame
        For i = _dataFrames.Count - 1 To 0 Step -1
            gridTab = _dataFrames(i)
            If Not currentDataFrames.Contains(gridTab.Name) Then
                _dataFrames.RemoveAt(i)
            End If
        Next
    End Sub

    Private Sub ReOrderGridTabs()
        'Not sure if we need this?
    End Sub




    Private Function GetDataFrameNames() As List(Of String)
        Dim clsGetDataFrameNames As New RFunction
        Dim expTemp As SymbolicExpression
        Dim listOfDataFrames As New List(Of String)

        clsGetDataFrameNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_names")
        clsGetDataFrameNames.AddParameter("include_hidden", "FALSE")

        expTemp = _RLink.RunInternalScriptGetValue(clsGetDataFrameNames.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing Then
            For i = 0 To expTemp.AsList.Length - 1
                listOfDataFrames.Add(expTemp.AsList.AsCharacter(i))
            Next
        Else
            ' raise an error here that can be displayed later 

            'If Not bMessageShown Then

            '    MsgBox("Error: Could not retrieve data frames from R. Data displayed in spreadsheet may not be up to date." & Environment.NewLine & "We strongly suggest restarting R-Instat before continuing.", MsgBoxStyle.Exclamation, "Cannot retrieve data")
            '    bMessageShown = True
            'End If
            '  lstDataNames = Nothing
        End If

        Return listOfDataFrames
    End Function

End Class

