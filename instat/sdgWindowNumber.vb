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
Public Class sdgWindowNumber
    Private bControlsInitialised As Boolean = False
    Private clsDummyFunction As New RFunction
    Public iPage As Integer
    Public iNumPage As Integer

    Private Sub sdgWindowNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not bControlsInitialised Then
            InitialiseControls()
            setRCodeForControls(True)
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim iDefaultPage As Integer = 0
        ucrNudPageNumber.SetParameter(New RParameter("num", iNewPosition:=0))
        ucrNudPageNumber.SetMinMax(1, iNumPage)
    End Sub

    Private Sub setRCodeForControls(bReset As Boolean)
        ucrNudPageNumber.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub ucrSdgPICSARainfalbuttons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgPICSARainfalbuttons.ClickReturn
        iPage = ucrNudPageNumber.GetText
    End Sub
End Class