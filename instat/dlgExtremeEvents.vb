
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
Public Class dlgExtremeEvents

    Private Sub dlgExtremeEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$()")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub txtColumnNameExtreme_Leave(sender As Object, e As EventArgs) Handles txtColumNameExtremeEvent.Leave
        ucrBase.clsRsyntax.AddParameter("col_names", Chr(34) & txtColumNameExtremeEvent.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("col_names", Chr(34) & txtColumnNameEventDay.Text & Chr(34)) ' this is not quite right the col_names is a vector that takes to parameters; is of the form col_names=c(par1,par2). Not sure of a way to proceed, could use some help
    End Sub
    Private Sub nudStartDay_Leave(sender As Object, e As EventArgs) Handles nudStartDay.Leave
        ucrBase.clsRsyntax.AddParameter("start_day", nudStartDay.Value.ToString())
    End Sub

    Private Sub nudEndDay_Leave(sender As Object, e As EventArgs) Handles nudEndDay.Leave
        ucrBase.clsRsyntax.AddParameter("end_day", nudEndDay.Value.ToString())
    End Sub

    Private Sub nudTotalDays_Leave(sender As Object, e As EventArgs) Handles nudTotalDays.Leave
        ucrBase.clsRsyntax.AddParameter("total_days", nudTotalDays.Value.ToString())
    End Sub
    Private Sub chkThresholdValue_Leave(sender As Object, e As EventArgs) Handles chkThresholdValue.Leave
        ucrBase.clsRsyntax.AddParameter("val_threshold", chkThresholdValue.Checked.ToString().ToUpper())
    End Sub


    Private Sub chkRemoveNA_Leave(sender As Object, e As EventArgs) Handles chkRemoveNA.Leave
        ucrBase.clsRsyntax.AddParameter("na.rm", chkRemoveNA.Checked.ToString().ToUpper())
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles nudThreshold.Leave
        If chkThresholdValue.Checked Then
            ucrBase.clsRsyntax.AddParameter(" threshold_value", nudThreshold.Value.ToString())
        End If
    End Sub

    Private Sub chkExtremeMax_Leave(sender As Object, e As EventArgs) Handles chkExtremeMax.Leave
        If chkExtremeMax.Checked Then
            ucrBase.clsRsyntax.AddParameter("extreme_max", chkExtremeMax.Checked.ToString().ToUpper())
        End If
    End Sub

    Private Sub chkExtremeMin_Leave(sender As Object, e As EventArgs) Handles chkExtremeMin.Leave
        If chkExtremeMin.Checked Then
            ucrBase.clsRsyntax.AddParameter("extreme_min", chkExtremeMin.Checked.ToString().ToUpper())
        End If
    End Sub
    'Reserved for two parameters that are not implemented well in the method namely upper_lim, and lower_lim.
    ' Private Sub chk_Leave(sender As Object, e As EventArgs) Handles chkThresholdValue.Leave
    '    ucrBase.clsRsyntax.AddParameter("val_threshold", chkThresholdValue.Checked.ToString().ToUpper())
    'End Sub

    'Private Sub chkThresholdValue_Leave(sender As Object, e As EventArgs) Handles chkThresholdValue.Leave
    '   ucrBase.clsRsyntax.AddParameter("val_threshold", chkThresholdValue.Checked.ToString().ToUpper())
    'End Sub




End Class