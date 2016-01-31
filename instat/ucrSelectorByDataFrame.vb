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
    Public Event DataFrameChanged(sender As Object, e As EventArgs)
    Private Sub ucrAvailableDataFrames_Load(sender As Object, e As EventArgs) Handles ucrAvailableDataFrames.DataFrameChanged
        LoadList()
        RaiseEvent DataFrameChanged(sender, e)
    End Sub

    Public Overrides Sub LoadList(Optional strDataType As String = "all")
        frmMain.clsRLink.FillColumnNames(ucrAvailableDataFrames.cboAvailableDataFrames.Text, lstColumns:=lstAvailableVariable)
    End Sub

End Class
