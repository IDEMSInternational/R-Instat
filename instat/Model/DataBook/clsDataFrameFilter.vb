Imports RDotNet

Public Class clsDataFrameFilter
    Protected _name As String
    Protected _RLink As RLink

    Protected _bApplied As Boolean
    Protected _intFilteredRowCount As Integer
    Protected _strName As String

    Public ReadOnly Property intFilteredRowCount As Integer
        Get
            Return _intFilteredRowCount
        End Get
    End Property

    Public ReadOnly Property strName As String
        Get
            Return _strName
        End Get
    End Property

    Public ReadOnly Property bApplied() As Boolean
        Get
            Return _bApplied
        End Get
    End Property

    Public Sub New(rLink As RLink, name As String)
        _name = name
        _RLink = rLink
    End Sub

    Private Function GetFilterNameFromRCommand() As String
        Dim clsGetCurrentFilterName As New RFunction
        clsGetCurrentFilterName.SetRCommand(_RLink.strInstatDataObject & "$get_current_filter_name")
        clsGetCurrentFilterName.AddParameter("data_name", Chr(34) & _name & Chr(34), iPosition:=0)
        Return _RLink.RunInternalScriptGetValue(clsGetCurrentFilterName.ToScript(), bSilent:=True).AsCharacter(0)
    End Function

    Private Function GetFilterAppliedFromRCommand() As Boolean
        Dim clsFilterApplied As New RFunction
        clsFilterApplied.SetRCommand(_RLink.strInstatDataObject & "$filter_applied")
        clsFilterApplied.AddParameter("data_name", Chr(34) & _name & Chr(34))
        Return _RLink.RunInternalScriptGetValue(clsFilterApplied.ToScript()).AsLogical(0)
    End Function

    Public Sub RefreshData()
        _intFilteredRowCount = _RLink.GetDataFrameLength(_name, True)
        _bApplied = GetFilterAppliedFromRCommand()
        _strName = GetFilterNameFromRCommand()
    End Sub

End Class

