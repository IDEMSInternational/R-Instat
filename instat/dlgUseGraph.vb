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
Public Class dlgUseGraph
    Private bFirstLoad As Boolean = True
    Private Sub dlgUseGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub OpenGraphBrowser()
        Dim GraphBrowser As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String

        GraphBrowser.Title = "Open Saved Graph Dialog"
        GraphBrowser.InitialDirectory = "C:\"
        GraphBrowser.Filter = "All files (*.*)|*.*"

        If GraphBrowser.ShowDialog() = DialogResult.OK Then
            strFileName = GraphBrowser.FileName
        End If
    End Sub

    Private Sub cmdOpenGraph_Click(sender As Object, e As EventArgs) Handles cmdOpenGraph.Click
        OpenGraphBrowser()
    End Sub
End Class