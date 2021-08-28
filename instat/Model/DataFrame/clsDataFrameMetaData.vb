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
    Private _RLink As RLink
    Private _dataFrame As DataFrame


    Public ReadOnly Property Data(row As Integer, column As Integer) As Object
        Get
            Return If(_dataFrame IsNot Nothing AndAlso _dataFrame.RowCount > 0, _dataFrame(row, column), 0)
        End Get
    End Property
    Public ReadOnly Property RowName(row As Integer) As String
        Get
            Return If(_dataFrame IsNot Nothing, _dataFrame.RowNames(row), "")
        End Get
    End Property
    Public ReadOnly Property RowCount As Integer
        Get
            Return If(_dataFrame IsNot Nothing, _dataFrame.RowCount, 0)
        End Get
    End Property

    Public ReadOnly Property ColumnName(column As Integer) As String
        Get
            Return If(_dataFrame IsNot Nothing, _dataFrame.ColumnNames(column), "")
        End Get
    End Property
    Public ReadOnly Property ColumnCount As Integer
        Get
            Return If(_dataFrame IsNot Nothing, _dataFrame.ColumnCount, 0)
        End Get
    End Property


    Public Sub New(rLink As RLink)
        _RLink = rLink
    End Sub




    Private Function HasDataChanged() As Boolean
        Dim clsMetadataChanged As New RFunction
        Dim expTemp As SymbolicExpression
        clsMetadataChanged.SetRCommand(_RLink.strInstatDataObject & "$get_metadata_changed")
        expTemp = _RLink.RunInternalScriptGetValue(clsMetadataChanged.ToScript())
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
        Dim clsGetCombinedMetadata As New RFunction
        Dim expTemp As SymbolicExpression

        clsGetCombinedMetadata.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_combined_metadata")
        clsGetCombinedMetadata.AddParameter("convert_to_character", "TRUE")
        expTemp = _RLink.RunInternalScriptGetValue(clsGetCombinedMetadata.ToScript(), bSilent:=True)
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
        _RLink.RunInternalScript(clsSetMetadataChanged.ToScript(), bSilent:=True)
    End Sub
End Class
