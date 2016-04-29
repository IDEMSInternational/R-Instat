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
        'lstAvailableVariable.HeaderStyle = ColumnHeaderStyle.None

    End Sub

    Public Event DataFrameChanged()
    Private Sub ucrAvailableDataFrames_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrAvailableDataFrames.DataFrameChanged
        LoadList()
        If strPrevDataFrame <> ucrAvailableDataFrames.cboAvailableDataFrames.Text Then
            RaiseEvent DataFrameChanged()
            OnResetReceivers()
        End If
    End Sub

    Public Overrides Sub LoadList()

        If ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            If CurrentReceiver IsNot Nothing Then
                If CurrentReceiver.lstIncludedDataTypes.Count > 0 Then
                    frmMain.clsRLink.FillListView(lstAvailableVariable, lstIncludedDataTypes:=CurrentReceiver.lstIncludedDataTypes, strDataFrameName:=ucrAvailableDataFrames.cboAvailableDataFrames.Text, strHeading:=CurrentReceiver.strSelectorHeading)
                ElseIf CurrentReceiver.lstExcludedDataTypes.Count > 0 Then
                    frmMain.clsRLink.FillListView(lstAvailableVariable, lstExcludedDataTypes:=CurrentReceiver.lstExcludedDataTypes, strDataFrameName:=ucrAvailableDataFrames.cboAvailableDataFrames.Text, strHeading:=CurrentReceiver.strSelectorHeading)
                Else
                    frmMain.clsRLink.FillListView(lstAvailableVariable, strDataFrameName:=ucrAvailableDataFrames.cboAvailableDataFrames.Text, strHeading:=CurrentReceiver.strSelectorHeading)
                End If
            End If
        End If
    End Sub
    Public Overrides Sub Reset()
        ucrAvailableDataFrames.Reset()
        MyBase.Reset()
    End Sub

    Private Sub ucrSelectorByDataFrame_DataFrameChanged() Handles Me.DataFrameChanged
        LoadList()
    End Sub
End Class
