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
Public Class dlgCliBoxplot

    Private Sub dlgCliBoxplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$cliboxplot")
        ucrBase.clsRsyntax.iCallType = 0
    End Sub


    Private Sub chkHorizontal_Leave(sender As Object, e As EventArgs) Handles chkHorizontal.Leave
        If chkHorizontal.Checked Then
            ucrBase.clsRsyntax.AddParameter("horizontal", chkHorizontal.Checked.ToString().ToUpper())
        End If
    End Sub

    Private Sub chkMonthAbbreviations_Leave(sender As Object, e As EventArgs) Handles chkMonthAbbreviations.Leave
        If chkHorizontal.Checked Then
            ucrBase.clsRsyntax.AddParameter("names", chkMonthAbbreviations.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkFactorLevel_Leave(sender As Object, e As EventArgs) Handles chkFactorLevel.Leave
        If chkFactorLevel.Checked Then
            ucrBase.clsRsyntax.AddParameter("factor_level", chkFactorLevel.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkPlot_Leave(sender As Object, e As EventArgs) Handles chkPlot.Leave
        If chkPlot.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot", chkPlot.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkOutline_Leave(sender As Object, e As EventArgs) Handles chkOutline.Leave
        If chkOutline.Checked Then
            ucrBase.clsRsyntax.AddParameter("outline", chkOutline.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkAdd_Leave(sender As Object, e As EventArgs) Handles chkAdd.Leave
        If chkAdd.Checked Then
            ucrBase.clsRsyntax.AddParameter("add", chkAdd.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkVarwidth_Leave(sender As Object, e As EventArgs) Handles chkVarwidth.Leave
        If chkVarwidth.Checked Then
            ucrBase.clsRsyntax.AddParameter("varwidth", chkVarwidth.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub nudRange_Leave(sender As Object, e As EventArgs) Handles nudRange.Leave
        ucrBase.clsRsyntax.AddParameter("range", nudRange.Value.ToString())

    End Sub

    Private Sub nudThreshold_Leave(sender As Object, e As EventArgs) Handles nudThreshold.Leave
        ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value.ToString())

    End Sub

    Private Sub nudWhisklty_Leave(sender As Object, e As EventArgs) Handles nudWhisklty.Leave
        ucrBase.clsRsyntax.AddParameter("whisklty", nudWhisklty.Value.ToString())

    End Sub

    Private Sub txtColour_TextChanged(sender As Object, e As EventArgs) Handles txtColour.TextChanged
        ucrBase.clsRsyntax.AddParameter("col", Chr(34) & txtColour.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & txtTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtVariable_TextChanged(sender As Object, e As EventArgs) Handles txtVariable.TextChanged
        ucrBase.clsRsyntax.AddParameter("var", Chr(34) & txtVariable.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtYLabel_TextChanged(sender As Object, e As EventArgs) Handles txtYLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & txtYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtXLabel_TextChanged(sender As Object, e As EventArgs) Handles txtXLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & txtXLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtDataPeriodLabel_TextChanged(sender As Object, e As EventArgs) Handles txtDataPeriodLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & txtDataPeriodLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtFactor_TextChanged(sender As Object, e As EventArgs) Handles txtFactor.TextChanged
        ucrBase.clsRsyntax.AddParameter("factor", Chr(34) & txtFactor.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtWidth_TextChanged(sender As Object, e As EventArgs) Handles txtWidth.TextChanged
        ucrBase.clsRsyntax.AddParameter("width", Chr(34) & txtWidth.Text.ToString() & Chr(34)) ' is a vector

    End Sub

    Private Sub txtLog_TextChanged(sender As Object, e As EventArgs) Handles txtLog.TextChanged
        ucrBase.clsRsyntax.AddParameter("log", Chr(34) & txtLog.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtAT_TextChanged(sender As Object, e As EventArgs) Handles txtAT.TextChanged
        ucrBase.clsRsyntax.AddParameter("at", Chr(34) & txtAT.Text.ToString() & Chr(34))

    End Sub

    Private Sub txtBorder_TextChanged(sender As Object, e As EventArgs) Handles txtBorder.TextChanged
        ucrBase.clsRsyntax.AddParameter("border", Chr(34) & txtBorder.Text.ToString() & Chr(34)) ' is a par("fg")

    End Sub

    Private Sub txtPARS_TextChanged(sender As Object, e As EventArgs) Handles txtPARS.TextChanged
        ucrBase.clsRsyntax.AddParameter("pars", Chr(34) & txtColour.Text.ToString() & Chr(34)) ' is a vector

    End Sub
End Class