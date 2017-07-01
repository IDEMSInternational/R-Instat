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
Public Class dlgImportFromDatabases
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgImportFromCSPRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            initialiseDialog()
            bFirstLoad = False
            If bReset Then
                SetDefaults()
            End If
            SetRcodeForControls(bReset)
            bReset = False
            TestOkEnabled()
            autoTranslate(Me)
        End If
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub initialiseDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
End Class