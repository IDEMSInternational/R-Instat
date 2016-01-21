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

Imports System.Globalization
Imports System.Threading
Imports instat.Translations

Public Class dlgOptions
    Private Sub dlgOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub rdoKiswahili_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKiswahili.CheckedChanged
        If rdoKiswahili.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("sw-KE")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("sw-KE")
            autoTranslate(frmMain)
            autoTranslate(Me)
        End If
    End Sub

    Private Sub rdoFrench_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFrench.CheckedChanged
        If rdoFrench.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("fr-FR")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("fr-FR")
            autoTranslate(frmMain)
            autoTranslate(Me)

        End If
    End Sub

    Private Sub rdoEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEnglish.CheckedChanged
        If rdoEnglish.Checked = True Then
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-US")
            Thread.CurrentThread.CurrentUICulture = New CultureInfo("en-US")
            autoTranslate(frmMain)
            autoTranslate(Me)
        End If
    End Sub
End Class