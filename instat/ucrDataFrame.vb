' Instat-R
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
Imports instat.Translations

Public Class ucrDataFrame
    Public iDataFrameLength As Integer
    Public iColumnCount As Integer
    Public clsCurrDataFrame As New RFunction
    Public bFirstLoad As Boolean = True
    Public strCurrDataFrame As String = ""

    Private Sub ucrDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsRLink.FillComboDataFrames(cboAvailableDataFrames, bFirstLoad)
        If bFirstLoad Then
            bFirstLoad = False
        End If
        SetDataFrameProperties()
    End Sub

    Public Sub Reset()
        If frmMain.strDefaultDataFrame <> "" Then
            cboAvailableDataFrames.SelectedIndex = cboAvailableDataFrames.Items.IndexOf(frmMain.strDefaultDataFrame)
        Else
            cboAvailableDataFrames.SelectedIndex = cboAvailableDataFrames.Items.IndexOf(frmMain.strCurrentDataFrame)
        End If
    End Sub

    Public Event DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String)

    Private Sub cboAvailableDataFrames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvailableDataFrames.SelectedIndexChanged
        SetDataFrameProperties()
        RaiseEvent DataFrameChanged(sender, e, strCurrDataFrame)
        strCurrDataFrame = cboAvailableDataFrames.Text
    End Sub

    Public Sub SetDataFrameProperties()
        Dim clsParam As New RParameter
        If cboAvailableDataFrames.Text <> "" Then
            iDataFrameLength = frmMain.clsRLink.GetDataFrameLength(cboAvailableDataFrames.Text)
            iColumnCount = frmMain.clsRLink.GetDataFrameColumnCount(cboAvailableDataFrames.Text)
            clsCurrDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
            clsParam.SetArgumentName("data_name")
            clsParam.SetArgumentValue(Chr(34) & cboAvailableDataFrames.Text & Chr(34))
            clsCurrDataFrame.AddParameter(clsParam)
            clsCurrDataFrame.SetAssignTo(cboAvailableDataFrames.Text & "_temp")
        End If
    End Sub

End Class
