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

Public Class dlgRegressionSimple
    Private Sub dlgRegressionSimple_Load(sender As Object, e As EventArgs) Handles Me.Load
        grpLackFit.Enabled = False
        grpLackFit.Visible = False
        autoTranslate(Me)
    End Sub

    Private Sub chkLackFit_CheckedChanged(sender As Object, e As EventArgs) Handles chkLackFit.CheckedChanged
        If chkLackFit.Checked = True Then
            grpLackFit.Enabled = True
            grpLackFit.Visible = True
        Else
            grpLackFit.Enabled = False
            grpLackFit.Visible = False
        End If
    End Sub
End Class