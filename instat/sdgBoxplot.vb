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
Public Class sdgBoxplot
    Private Sub sdgBoxplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chkGridOptions.Checked = False
        chkWrapOptions.Checked = False
        chkFreeScales.Checked = False
        rdoVertical.Visible = False
        rdoHorizontal.Visible = False
        rdoMargins.Visible = False
        lblNoOfColumns.Visible = False
        txtNoOfColumns.Visible = False
        ucrReceiveFactor1.Selector = ucrAddRemove
        ucrReceiveFactor1.SetMeAsReceiver()
        ucrReceiveFactor2.Selector = ucrAddRemove
        autoTranslate(Me)
    End Sub

    Private Sub chkGridOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkGridOptions.CheckedChanged
        If chkGridOptions.Checked = True Then
            rdoVertical.Visible = True
            rdoHorizontal.Visible = True
            rdoMargins.Visible = True
        Else
            rdoVertical.Visible = False
            rdoHorizontal.Visible = False
            rdoMargins.Visible = False
        End If
    End Sub

    Private Sub chkWrapOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkWrapOptions.CheckedChanged
        If chkWrapOptions.Checked = True Then
            lblNoOfColumns.Visible = True
            txtNoOfColumns.Visible = True
        Else
            lblNoOfColumns.Visible = False
            txtNoOfColumns.Visible = False
        End If
    End Sub

End Class