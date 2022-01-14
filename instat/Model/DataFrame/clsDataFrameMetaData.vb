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

Public Class clsDataFrameMetaData
    Private _clsRLink As RLink
    Private _clsDataFrame As DataFrame

    Public ReadOnly Property Data(iRow As Integer, iColumn As Integer) As Object
        Get
            Return If(_clsDataFrame IsNot Nothing AndAlso _clsDataFrame.RowCount > 0, _clsDataFrame(iRow, iColumn), 0)
        End Get
    End Property

    Public ReadOnly Property RowName(iRow As Integer) As String
        Get
            Return If(_clsDataFrame IsNot Nothing, _clsDataFrame.RowNames(iRow), "")
        End Get
    End Property

    Public ReadOnly Property RowCount As Integer
        Get
            Return If(_clsDataFrame IsNot Nothing, _clsDataFrame.RowCount, 0)
        End Get
    End Property

    Public ReadOnly Property ColumnName(iColumn As Integer) As String
        Get
            Return If(_clsDataFrame IsNot Nothing, _clsDataFrame.ColumnNames(iColumn), "")
        End Get
    End Property

    Public ReadOnly Property ColumnCount As Integer
        Get
            Return If(_clsDataFrame IsNot Nothing, _clsDataFrame.ColumnCount, 0)
        End Get
    End Property

    Public Sub New(rLink As RLink)
        _clsRLink = rLink
    End Sub

    Private Function HasDataChanged() As Boolean
        Dim clsMetadataChanged As New RFunction
        Dim expTemp As SymbolicExpression
        clsMetadataChanged.SetRCommand(_clsRLink.strInstatDataObject & "$get_metadata_changed")
        expTemp = _clsRLink.RunInternalScriptGetValue(clsMetadataChanged.ToScript())
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsLogical(0)
        Else
            Return False
        End If
    End Function

    Public Sub RefreshData()
        If HasDataChanged() Then
            _clsDataFrame = GetDataFrameFromRCommand()
            ResetDataFramesChanged()
        End If
    End Sub

    Private Function GetDataFrameFromRCommand() As DataFrame
        Dim clsGetCombinedMetadata As New RFunction
        Dim expTemp As SymbolicExpression

        clsGetCombinedMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_combined_metadata")
        clsGetCombinedMetadata.AddParameter("convert_to_character", "TRUE")
        expTemp = _clsRLink.RunInternalScriptGetValue(clsGetCombinedMetadata.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
            Return expTemp.AsDataFrame
        Else
            Return Nothing
        End If
    End Function

    Private Sub ResetDataFramesChanged()
        Dim clsSetMetadataChanged As New RFunction
        clsSetMetadataChanged.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_metadata_changed")
        clsSetMetadataChanged.AddParameter("new_val", "FALSE")
        _clsRLink.RunInternalScript(clsSetMetadataChanged.ToScript(), bSilent:=True)
    End Sub

End Class
