
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
Public Class dlgBoxplotCountVariable
    Private Sub dlgBoxplotCountVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("climate_obj$boxplot_method")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub

    Private Sub chkVarwidth_Leave(sender As Object, e As EventArgs) Handles chkVarwidth.Leave
        If chkVarwidth.Checked Then
            ucrBase.clsRsyntax.AddParameter("varwidth", chkVarwidth.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & txtTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtVariableLabel_Leave(sender As Object, e As EventArgs) Handles txtVariableLabel.Leave
        ucrBase.clsRsyntax.AddParameter("var_label", Chr(34) & txtVariableLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtFillColour_Leave(sender As Object, e As EventArgs) Handles txtFillColour.Leave
        ucrBase.clsRsyntax.AddParameter("fill_col", Chr(34) & txtFillColour.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtWhiskerColour_Leave(sender As Object, e As EventArgs) Handles txtWhiskerColour.Leave
        ucrBase.clsRsyntax.AddParameter("whisker_col", Chr(34) & txtWhiskerColour.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtTimeperiod_Leave(sender As Object, e As EventArgs) Handles txtTimeperiod.Leave
        ucrBase.clsRsyntax.AddParameter("time_period", Chr(34) & txtTimeperiod.Text.ToString() & Chr(34))

    End Sub

    Private Sub nudWhiskLineType_Leave(sender As Object, e As EventArgs) Handles nudWhiskLineType.Leave
        ucrBase.clsRsyntax.AddParameter("whiskerlty", nudWhiskLineType.Value.ToString())

    End Sub
End Class