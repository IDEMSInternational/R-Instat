' Instat+R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class ucrSelectorByDataFrame
    Private Sub ucrSelectorByDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    'Private Sub ucrAvailableDataFrames_Load(sender As Object, e As EventArgs) Handles ucrAvailableDataFrames.DataFrameChanged
    '    LoadList()
    'End Sub
    Private Sub ucrAvailableDataFrames_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrAvailableDataFrames.DataFrameChanged
        LoadList()
        If strPrevDataFrame <> ucrAvailableDataFrames.cboAvailableDataFrames.Text Then
            OnDataFrameChanged()
        End If
    End Sub

    Public Overrides Sub LoadList()
        Dim strPrevDataFrame As String
        strPrevDataFrame = ucrAvailableDataFrames.cboAvailableDataFrames.Text
        If ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            frmMain.clsRLink.FillListView(lstAvailableVariable, strDataType:=CurrentReceiver.strDataType, strDataFrameName:=ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub
End Class
