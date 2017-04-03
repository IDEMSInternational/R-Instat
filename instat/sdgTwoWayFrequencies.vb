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
Public Class sdgTwoWayFrequencies
    Public bFirstload As Boolean = True
    Public bReset As Boolean = True
    Private Sub sdgTwoWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstload Then
            initialiseDialog()
            bFirstload = False
            If bReset Then
                setDefaults()
            End If
            SetRCodeForControls(bReset)
            bReset = False
            TestOkEnabled()
            autoTranslate(Me)

        End If
    End Sub

    Private Sub initialiseDialog()

    End Sub
    Private Sub SetDefaults()

    End Sub
    Private Sub TestOkEnabled()

    End Sub
    Private Sub SetRcodeForControls(bReset As Boolean)

    End Sub

    Private Sub UcrBase_Load(sender As Object, e As EventArgs) Handles UcrBase.Load
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub
End Class