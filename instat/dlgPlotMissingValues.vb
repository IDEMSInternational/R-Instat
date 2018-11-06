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
Public Class dlgPlotMissingValues
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsPlotMissingValues As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing
    Private Sub dlgPlotMissingValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultColumn()
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

    End Sub

    Private Sub SetDefaults()

    End Sub
    Private Sub SetRCodeForControls(bReset)

    End Sub

    Public Sub TestOkEnabled()

    End Sub
    Private Sub UcrSelector1_Load(sender As Object, e As EventArgs) Handles UcrSelector1.Load

    End Sub

    Private Sub rdoVisGuess_Load(sender As Object, e As EventArgs) Handles rdoVisGuess.Load

    End Sub
End Class