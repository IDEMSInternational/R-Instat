﻿' R- Instat
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

Public Class dlgCircular
    Private bFirstLoad As Boolean = True
    Private bRest As Boolean = True
    Private clsCircularFunction As New RFunction

    Private Sub dlgCircular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bRest Then
            SetDefaults()
        End If

        SetRCodeForControls(bRest)
        bRest = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
    End Sub

    Private Sub SetDefaults()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
    End Sub

    Private Sub TestOkEnabled()
    End Sub
End Class