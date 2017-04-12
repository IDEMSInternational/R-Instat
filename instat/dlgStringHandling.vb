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

Public Class dlgStringHandling
    Private bFirstload = False
    Private bReset = False
    Private Sub dlgStringHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialogue()
            bFirstload = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub
    Private Sub InitialiseDialogue()

    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub UcrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub UcrReceiverString_Load(sender As Object, e As EventArgs) Handles ucrReceiverStringHandling.Load

    End Sub
End Class