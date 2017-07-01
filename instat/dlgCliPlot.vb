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
Public Class dlgCliPlot

    Private Sub dlgCliPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$cliplot")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub



    Private Sub chkStationName_Leave(sender As Object, e As EventArgs) Handles chkStationName.Leave
        If chkStationName.Checked Then
            ucrBase.clsRsyntax.AddParameter("station_name", chkStationName.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkRemoveNA_Leave(sender As Object, e As EventArgs) Handles chkRemoveNA.Leave
        If chkRemoveNA.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.rm", chkRemoveNA.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkByfactor_Leave(sender As Object, e As EventArgs) Handles chkByfactor.Leave
        If chkByfactor.Checked Then
            ucrBase.clsRsyntax.AddParameter("by_factor", chkByfactor.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkInheritAES_Leave(sender As Object, e As EventArgs) Handles chkInheritAES.Leave
        If chkInheritAES.Checked Then
            ucrBase.clsRsyntax.AddParameter("inherit.aes", chkInheritAES.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub nudSize_Leave(sender As Object, e As EventArgs) Handles nudSize.Leave
        ucrBase.clsRsyntax.AddParameter("size", nudSize.Value.ToString())

    End Sub

    Private Sub nudLineType_Leave(sender As Object, e As EventArgs) Handles nudLineType.Leave
        ucrBase.clsRsyntax.AddParameter("linetype", nudLineType.Value.ToString())

    End Sub

    Private Sub txtShowLegend_Leave(sender As Object, e As EventArgs) Handles txtShowLegend.Leave
        ucrBase.clsRsyntax.AddParameter("show.legend", Chr(34) & txtShowLegend.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtFactorVariable_Leave(sender As Object, e As EventArgs) Handles txtFactorVariable.Leave
        ucrBase.clsRsyntax.AddParameter("factor_var", Chr(34) & txtFactorVariable.Text.ToString() & Chr(34))


    End Sub

    Private Sub txtXAxis_Leave(sender As Object, e As EventArgs) Handles txtXAxis.Leave
        ucrBase.clsRsyntax.AddParameter("x_axis_label", Chr(34) & txtXAxis.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtYAxis_Leave(sender As Object, e As EventArgs) Handles txtYAxis.Leave
        ucrBase.clsRsyntax.AddParameter("y_axis_label", Chr(34) & txtXAxis.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtColour_Leave(sender As Object, e As EventArgs) Handles txtColour.Leave
        ucrBase.clsRsyntax.AddParameter("col", Chr(34) & txtColour.Text.ToString() & Chr(34)) ' a vector

    End Sub

    Private Sub txtDataperiodLabel_Leave(sender As Object, e As EventArgs) Handles txtDataperiodLabel.Leave
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & txtDataperiodLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtXLim_Leave(sender As Object, e As EventArgs) Handles txtXLim.Leave
        ucrBase.clsRsyntax.AddParameter("xlim", Chr(34) & txtXAxis.Text.ToString() & Chr(34)) ' numeric vector

    End Sub

    Private Sub txtYLim_Leave(sender As Object, e As EventArgs) Handles txtYLim.Leave
        ucrBase.clsRsyntax.AddParameter("ylim", Chr(34) & txtYAxis.Text.ToString() & Chr(34)) ' numeric vector

    End Sub

    Private Sub txtStat_Leave(sender As Object, e As EventArgs) Handles txtStat.Leave
        ucrBase.clsRsyntax.AddParameter("stat", Chr(34) & txtStat.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtVariableY_Leave(sender As Object, e As EventArgs) Handles txtVariableY.Leave
        ucrBase.clsRsyntax.AddParameter("var_y", Chr(34) & txtVariableY.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtVariableX_Leave(sender As Object, e As EventArgs) Handles txtVariableX.Leave
        ucrBase.clsRsyntax.AddParameter("var_x", Chr(34) & txtVariableX.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("main_title", Chr(34) & txtTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtVariableName_TextTe(sender As Object, e As EventArgs) Handles txtVariableName.Leave
        ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & txtVariableName.Text.ToString() & Chr(34))

    End Sub
End Class