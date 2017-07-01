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

Public Class frmGraphDisplay
    Private Sub frmGraphDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub SetImageFromFile(strFilePath As String)
        Dim fsTemp As System.IO.FileStream
        Dim imgTemp As Image

        fsTemp = New System.IO.FileStream(strFilePath, IO.FileMode.Open, IO.FileAccess.Read)
        imgTemp = System.Drawing.Image.FromStream(fsTemp)
        pctGraph.Image = imgTemp
        fsTemp.Close()
    End Sub
End Class