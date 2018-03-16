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
Public Class sdgRestrict
    Private Sub dlgControlOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiver.Selector = ucrSelector
        ucrReceiver.SetMeAsReceiver()
        txtLessThan.Visible = False
        txtEqualTo.Visible = False
        txtGreaterThan.Visible = False
        autoTranslate(Me)
    End Sub

    Private Sub rdoLessThan_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLessThan.CheckedChanged
        If rdoLessThan.Checked = True Then
            txtLessThan.Visible = True
        Else
            txtLessThan.Visible = False

        End If
    End Sub

    Private Sub rdoEqualTo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoEqualTo.CheckedChanged
        If rdoEqualTo.Checked = True Then
            txtEqualTo.Visible = True
        Else
            txtEqualTo.Visible = False
        End If


    End Sub

    Private Sub rdoGreaterThan_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGreaterThan.CheckedChanged
        If rdoGreaterThan.Checked = True Then
            txtGreaterThan.Visible = True
        Else
            txtGreaterThan.Visible = False
        End If
    End Sub
End Class