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

Public Class ucrDataFrameLength
    Public WithEvents ucrDataFrameSelector As ucrDataFrame

    Public Sub SetDataFrameSelector(clsSelector As ucrDataFrame)
        ucrDataFrameSelector = clsSelector
        SetLength()
    End Sub

    Public Sub SetLength()
        If ucrDataFrameSelector IsNot Nothing AndAlso ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
            txtLength.Text = frmMain.clsRLink.GetDataFrameLength(ucrDataFrameSelector.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub clsDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameSelector.DataFrameChanged
        SetLength()
    End Sub

    Private Sub ucrDataFrameLength_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetLength()
    End Sub
End Class
