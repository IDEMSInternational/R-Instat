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
    ''' <summary>
    ''' Number of the page to display
    ''' </summary>
    Public iPage As Integer

    ''' <summary>
    ''' iTotalRowOrColumn total number or rows or columns of a data frame depending on the mode i.e Row or Column
    ''' iStartRowOrColumn value of starting a row or column depending on the mode i.e Row or Column
    ''' iEndRowOrColumn number of rows or columns displayed in a specific window depending on the mode i.e Row or Column
    ''' </summary>
    Public iTotalRowOrColumn, iStartRowOrColumn, iEndRowOrColumn As Integer

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
        ' the maximum number of rows/columns to display
        Dim iMaxRowsCols = If(enumWINNUMBERMode = WINNUMBERMode.Row,
                frmMain.clsInstatOptions.iMaxRows, frmMain.clsInstatOptions.iMaxCols)

        ' the current page number displayed
        Dim iDefaultPage As Integer = Math.Ceiling(CDbl(iEndRowOrColumn / iMaxRowsCols))

        ' the maximum number of row/col pages 
        Dim iRowOrColMaxPages As Integer = Math.Ceiling(CDbl(iTotalRowOrColumn / iMaxRowsCols))

        If iStartRowOrColumn = 1 Then
            iDefaultPage = iRowOrColMaxPages / 2
        End If

        ucrNudPageNumber.SetMinMax(1, iRowOrColMaxPages)
        ucrNudPageNumber.SetText(iDefaultPage)
        lblPages.Text = "1-" & iRowOrColMaxPages & ":"
    End Sub

    Private Sub ucrSdgPICSARainfalbuttons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgPICSARainfalbuttons.ClickReturn
        iPage = ucrNudPageNumber.GetText()
    End Sub
End Class