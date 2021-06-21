Imports RDotNet

Public Class clsColumnMetaData
    Private _name As String
    Private _RLink As RLink
    Private _dataFrame As DataFrame


    Public ReadOnly Property Data(row As Integer, column As Integer) As Object
        Get
            Return _dataFrame(row, column)
        End Get
    End Property
    Public ReadOnly Property RowName(row As Integer) As String
        Get
            Return _dataFrame.RowNames(row)
        End Get
    End Property
    Public ReadOnly Property RowCount As Integer
        Get
            Return _dataFrame.RowCount
        End Get
    End Property

    Public ReadOnly Property ColumnName(column As Integer) As String
        Get
            Return _dataFrame.ColumnNames(column)
        End Get
    End Property
    Public ReadOnly Property ColumnCount As Integer
        Get
            Return _dataFrame.ColumnCount
        End Get
    End Property


    Public Sub New(rLink As RLink, name As String)
        _RLink = rLink
        _name = name
    End Sub




    Private Function HasDataChanged() As Boolean
        Dim clsVariablesMetadataChanged As New RFunction
        Dim expTemp As SymbolicExpression
        clsVariablesMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_variables_metadata_changed")
        clsVariablesMetadataChanged.AddParameter("data_name", Chr(34) & _name & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsVariablesMetadataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    Public Sub RefreshData()
        If HasDataChanged() Then
            _dataFrame = GetDataFrameFromRCommand()
            ResetDataFramesChanged()
        End If
    End Sub



    Private Function GetDataFrameFromRCommand() As DataFrame
        Dim clsGetVariablesMetadata As New RFunction
        Dim expTemp As SymbolicExpression

        clsGetVariablesMetadata.SetRCommand(_RLink.strInstatDataObject & "$get_variables_metadata")
        clsGetVariablesMetadata.AddParameter("convert_to_character", "TRUE")
        clsGetVariablesMetadata.AddParameter("data_name", Chr(34) & _name & Chr(34))
        expTemp = _RLink.RunInternalScriptGetValue(clsGetVariablesMetadata.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsDataFrame
        Else
            Return Nothing
        End If
    End Function
    Private Sub ResetDataFramesChanged()
        Dim clsSetVariablesMetadataChanged As New RFunction
        clsSetVariablesMetadataChanged.SetRCommand(_RLink.strInstatDataObject & "$set_variables_metadata_changed")
        clsSetVariablesMetadataChanged.AddParameter("data_name", Chr(34) & _name & Chr(34))
        clsSetVariablesMetadataChanged.AddParameter("new_val", "FALSE")
        _RLink.RunInternalScript(clsSetVariablesMetadataChanged.ToScript(), bSilent:=True)
    End Sub
End Class

