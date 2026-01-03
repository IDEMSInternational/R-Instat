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

Imports instat.Translations
Imports RDotNet

' Used when user wants to use an R-Instat data frame to select the stations
Public Class sdgClimsoftFilter
    ' Is set to true when return button is clicked. False when otherwise
    Private bReturnClicked As Boolean = False

    Private strDFColumnToUse As String = "station_id"

    Private Sub sdgClimsoftFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bReturnClicked = False
        autoTranslate(Me)
    End Sub

    Public Sub setup(strNewDFColumnToUse As String)
        Me.strDFColumnToUse = strNewDFColumnToUse
    End Sub

    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        bReturnClicked = True
    End Sub

    ''' <summary>
    ''' Returns the contents of the set up column of the selected data frame using the current filter applied to the data frame
    ''' </summary>
    ''' <returns></returns>
    Public Function getSelections() As String()
        If bReturnClicked AndAlso Not String.IsNullOrEmpty(ucrDataFrameCopySheets.strCurrDataFrame) Then
            Dim clsGetStationIds As New RFunction
            clsGetStationIds.SetRCommand("data_book$get_columns_from_data")
            clsGetStationIds.AddParameter(strParameterName:="data_name", strParameterValue:=Chr(34) & ucrDataFrameCopySheets.strCurrDataFrame & Chr(34), iPosition:=0)
            clsGetStationIds.AddParameter(strParameterName:="col_names", strParameterValue:=Chr(34) & strDFColumnToUse & Chr(34), iPosition:=1)
            clsGetStationIds.AddParameter(strParameterName:="use_current_filter", strParameterValue:="TRUE", iPosition:=2)
            Try
                Dim expTemp As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsGetStationIds.ToScript(), bSilent:=True)
                Return expTemp.AsCharacter().Cast(Of String).ToArray()
            Catch ex As Exception
                MsgBoxTranslate("Station Ids could not be retrieved from selected data frame")
            End Try
        End If

        Return Nothing
    End Function
End Class