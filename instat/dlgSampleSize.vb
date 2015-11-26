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
Public Class dlgSampleSize
    Private Sub dlgSampleSize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSave.Visible = False
        autoTranslate(Me)
    End Sub

    Private Sub chkSaveResults_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResults.CheckedChanged
        If chkSaveResults.Checked = True Then
            cboSave.Visible = True
        Else
            cboSave.Visible = False
        End If
    End Sub

    Private Sub rdoMeans_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMeans.CheckedChanged
        If rdoMeans.Checked = True Then
            txtPower.Visible = True
            txtDifference.Visible = True
        Else
            txtPower.Visible = False
            txtDifference.Visible = False

        End If
    End Sub

    Private Sub rdoProportions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoProportions.CheckedChanged
        If rdoProportions.Checked = True Then
            txtProportion2.Visible = True
            txtRelativeRisk.Visible = True
        Else
            txtProportion2.Visible = False
            txtRelativeRisk.Visible = False
        End If
    End Sub

    Private Sub rdoPower_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPower.CheckedChanged
        If rdoPower.Checked = True Then
            txtDifference.Visible = False
            txtPower.Visible = False
            txtProportion2.Visible = True
            txtRelativeRisk.Visible = True
        End If
    End Sub
End Class