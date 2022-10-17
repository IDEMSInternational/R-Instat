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
    Public iPage As Integer
    Public iNumPage, iStart, iEnd As Integer

    Public enumWINNUMBERMode As WINNUMBERMode = WINNUMBERMode.Row
    Public Enum WINNUMBERMode
        Row
        Col
    End Enum

    Private Sub sdgWindowNumber_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiseControls()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dMax As Double
        Dim iDefault As Integer
        Dim iMaxRows As Integer = frmMain.clsInstatOptions.iMaxRows
        Dim iMaxCols As Integer = frmMain.clsInstatOptions.iMaxCols

        Select Case enumWINNUMBERMode
            Case WINNUMBERMode.Row
                dMax = iNumPage / iMaxRows
                iDefault = Math.Round(iEnd / iMaxRows)
            Case WINNUMBERMode.Col
                dMax = iNumPage / iMaxCols
                iDefault = Math.Round(iEnd / iMaxCols)
        End Select
        Dim iRowOrColMaxPages = Math.Floor(dMax)
        If Not iRowOrColMaxPages = dMax Then
            iRowOrColMaxPages = iRowOrColMaxPages + 1
        End If
        If iNumPage = iEnd Then
            iDefault = iRowOrColMaxPages
        ElseIf iStart = 1 Then
            iDefault = Math.Round(iRowOrColMaxPages / 2)
        End If

        ucrNudPageNumber.SetMinMax(1, iRowOrColMaxPages)
        ucrNudPageNumber.SetText(iDefault)
        lblPages.Text = "1-" & iRowOrColMaxPages & ":"
    End Sub

    Private Sub ucrSdgPICSARainfalbuttons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgPICSARainfalbuttons.ClickReturn
        iPage = ucrNudPageNumber.GetText()
    End Sub
End Class