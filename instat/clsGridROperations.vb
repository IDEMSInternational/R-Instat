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
''' This class contains methods to run R operations required in the data grids i.e. commands from the right click menus in ucrDataView and ucrColumnMetadata.
''' These methods are in a separate class since they are called from multiple places in multiple controls.
''' This ensures that R commands are separated from the user interface controls.
''' </summary>


Public Class GridROperations
    ''' <summary>
    ''' New is Private so that instances cannot be created as all members are Shared.
    ''' </summary>
    Private Sub New()

    End Sub

    Private Shared Sub RunScript(strScript As String, Optional iCallType As Integer = 0, Optional strComment As String = "", Optional bSeparateThread As Boolean = True, Optional bShowWaitDialogOverride As Nullable(Of Boolean) = Nothing)
        frmMain.clsRLink.RunScript(strScript:=strScript, iCallType:=iCallType, strComment:=strComment, bSeparateThread:=bSeparateThread, bShowWaitDialogOverride:=bShowWaitDialogOverride)
    End Sub

    Public Shared Sub ConvertToNumeric(strDataFrame As String, arrConvertCols() As String, iRowCount As Integer, Optional strComment As String = "")
        Dim expTemp As SymbolicExpression
        Dim iNonNumeric As Integer
        Dim clsConvertToNumeric As New RFunction
        Dim clsGetColumnsFromData As New RFunction
        Dim clsNNonNumeric As New RFunction

        If strComment = "" Then
            strComment = "Right click menu: Convert Column(s) To Numeric"
        End If

        clsConvertToNumeric.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertToNumeric.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)

        clsGetColumnsFromData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnsFromData.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)

        clsNNonNumeric.SetRCommand("n_non_numeric")

        clsConvertToNumeric.AddParameter("to_type", Chr(34) & "numeric" & Chr(34), iPosition:=2)
        For Each strCol As String In arrConvertCols
            clsConvertToNumeric.AddParameter("col_names", Chr(34) & strCol & Chr(34), iPosition:=1)
            clsConvertToNumeric.RemoveParameterByName("ignore_labels")

            clsGetColumnsFromData.AddParameter("col_names", Chr(34) & strCol & Chr(34), iPosition:=1)
            clsGetColumnsFromData.AddParameter("use_current_filter", "FALSE", iPosition:=4)

            clsNNonNumeric.AddParameter("x", clsRFunctionParameter:=clsGetColumnsFromData, iPosition:=0)
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsNNonNumeric.ToScript(), bSilent:=True)
            If expTemp IsNot Nothing AndAlso expTemp.Type <> Internals.SymbolicExpressionType.Null Then
                iNonNumeric = expTemp.AsNumeric(0)
                ' If all values are numeric then force ignore labels and do a "normal" convert.
                If iNonNumeric = 0 Then
                    clsConvertToNumeric.AddParameter("ignore_labels", "TRUE", iPosition:=6)
                    RunScript(clsConvertToNumeric.ToScript(), strComment:=strComment)
                    ' If all values are non-numeric then do a "labelled" convert.
                ElseIf iNonNumeric = iRowCount Then
                    RunScript(clsConvertToNumeric.ToScript(), strComment:=strComment)
                    ' If there are a mixture of numeric and non-numeric values give the user the choice.
                ElseIf iNonNumeric > 0 Then
                    frmConvertToNumeric.SetDataFrameName(strDataFrame)
                    frmConvertToNumeric.SetColumnName(strCol)
                    frmConvertToNumeric.SetNonNumeric(iNonNumeric)
                    frmConvertToNumeric.ShowDialog()
                    ' Yes for "normal" convert and No for "labelled" convert
                    If frmConvertToNumeric.DialogResult = DialogResult.Yes Then
                        clsConvertToNumeric.AddParameter("ignore_labels", "TRUE", iPosition:=6)
                        RunScript(clsConvertToNumeric.ToScript(), strComment:=strComment)
                    ElseIf frmConvertToNumeric.DialogResult = DialogResult.No Then
                        RunScript(clsConvertToNumeric.ToScript(), strComment:=strComment)
                    ElseIf frmConvertToNumeric.DialogResult = DialogResult.Cancel Then
                        Continue For
                    End If
                Else
                    RunScript(clsConvertToNumeric.ToScript(), strComment:=strComment)
                End If
            Else
                RunScript(clsConvertToNumeric.ToScript(), strComment:=strComment)
            End If
        Next
    End Sub
End Class
