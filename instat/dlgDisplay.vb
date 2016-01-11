
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
Public Class dlgDisplay
    Private Sub dlgDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSeparatedby.Visible = False
        lblLines.Visible = False
        txtSeparator.Visible = False
        txtNoofSigFigures.Visible = False
        txtDecimalPlaces.Visible = False
        grpDataOptions.Visible = False
        grpLayoutOptions.Visible = False
        autoTranslate(Me)
    End Sub

    Private Sub lstConstants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConstants.SelectedIndexChanged, lstStrings.SelectedIndexChanged, lstLabels.SelectedIndexChanged

    End Sub

    Private Sub chkDisplaySerially_CheckedChanged(sender As Object, e As EventArgs) Handles chkDisplaySerially.CheckedChanged
        If chkDisplaySerially.Checked = True Then
            lblSeparatedby.Visible = True
            lblLines.Visible = True
            txtSeparator.Visible = True
        End If
    End Sub

    Private Sub chkNoOfDecimalPlaces_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoOfDecimalPlaces.CheckedChanged
        If chkNoOfDecimalPlaces.Checked = True Then
            txtDecimalPlaces.Visible = True
            chkNoofSigFigures.Checked = False
        Else
            txtDecimalPlaces.Visible = False
        End If
    End Sub

    Private Sub chkNoofSigFigures_CheckedChanged(sender As Object, e As EventArgs) Handles chkNoofSigFigures.CheckedChanged
        If chkNoofSigFigures.Checked = True Then
            txtNoofSigFigures.Visible = True
        End If
    End Sub

    Private Sub chkDataOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkDataOptions.CheckedChanged
        If chkDataOptions.Checked = True Then
            grpDataOptions.Visible = True
        Else
            grpDataOptions.Visible = False

        End If
    End Sub

    Private Sub chkLayoutOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkLayoutOptions.CheckedChanged
        If chkLayoutOptions.Checked = True Then
            grpLayoutOptions.Visible = True
        End If
    End Sub
End Class