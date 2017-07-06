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
Public Class dlgCliBoxplot
    Public bFirstLoad As Boolean = True
    Private Sub dlgCliBoxplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()

    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$cliboxplot")
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()

    End Sub


    Private Sub chkHorizontal_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontal.CheckedChanged
        If chkHorizontal.Checked Then
            ucrBase.clsRsyntax.AddParameter("horizontal", chkHorizontal.Checked.ToString().ToUpper())
        End If
    End Sub

    Private Sub chkMonthAbbreviations_CheckedChanged(sender As Object, e As EventArgs) Handles chkMonthAbbreviations.CheckedChanged
        If chkHorizontal.Checked Then
            ucrBase.clsRsyntax.AddParameter("names", chkMonthAbbreviations.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkFactorLevel_CheckedChanged(sender As Object, e As EventArgs) Handles chkFactorLevel.CheckedChanged
        If chkFactorLevel.Checked Then
            ucrBase.clsRsyntax.AddParameter("factor_level", chkFactorLevel.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkPlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkPlot.CheckedChanged
        If chkPlot.Checked Then
            ucrBase.clsRsyntax.AddParameter("plot", chkPlot.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkOutline_CheckedChanged(sender As Object, e As EventArgs) Handles chkOutline.CheckedChanged
        If chkOutline.Checked Then
            ucrBase.clsRsyntax.AddParameter("outline", chkOutline.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkAdd_CheckedChanged(sender As Object, e As EventArgs) Handles chkAdd.CheckedChanged
        If chkAdd.Checked Then
            ucrBase.clsRsyntax.AddParameter("add", chkAdd.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub chkVarwidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkVarwidth.CheckedChanged
        If chkVarwidth.Checked Then
            ucrBase.clsRsyntax.AddParameter("varwidth", chkVarwidth.Checked.ToString().ToUpper())
        End If

    End Sub

    Private Sub nudRange_ValueChanged(sender As Object, e As EventArgs) Handles nudRange.ValueChanged
        ucrBase.clsRsyntax.AddParameter("range", nudRange.Value.ToString())

    End Sub

    Private Sub nudThreshold_ValueChanged(sender As Object, e As EventArgs) Handles nudThreshold.ValueChanged
        ucrBase.clsRsyntax.AddParameter("threshold", nudThreshold.Value.ToString())

    End Sub

    Private Sub nudWhisklty_ValueChanged(sender As Object, e As EventArgs) Handles nudWhisklty.ValueChanged
        ucrBase.clsRsyntax.AddParameter("whisklty", nudWhisklty.Value.ToString())

    End Sub

    Private Sub ucrInputColour_TextChanged(sender As Object, e As EventArgs) Handles ucrInputColour.TextChanged
        ucrBase.clsRsyntax.AddParameter("col", Chr(34) & ucrInputColour.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputTitle_TextChanged(sender As Object, e As EventArgs) Handles ucrInputTitle.TextChanged
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & ucrInputTitle.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputVariable_TextChanged(sender As Object, e As EventArgs) Handles ucrInputVariable.TextChanged
        ucrBase.clsRsyntax.AddParameter("var", Chr(34) & ucrInputVariable.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputYLabel_TextChanged(sender As Object, e As EventArgs) Handles ucrInputYLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("ylab", Chr(34) & ucrInputYLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputXLabel_TextChanged(sender As Object, e As EventArgs) Handles ucrInputXLabel.TextChanged
        ucrBase.clsRsyntax.AddParameter("xlab", Chr(34) & ucrInputXLabel.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputDataPeriod_TextChanged(sender As Object, e As EventArgs) Handles ucrInputDataPeriod.TextChanged
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & ucrInputDataPeriod.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputFactorLab_TextChanged(sender As Object, e As EventArgs) Handles ucrInputFactorLab.TextChanged
        ucrBase.clsRsyntax.AddParameter("factor", Chr(34) & ucrInputFactorLab.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputWidth_TextChanged(sender As Object, e As EventArgs) Handles ucrInputWidth.TextChanged
        ucrBase.clsRsyntax.AddParameter("width", Chr(34) & ucrInputWidth.Text.ToString() & Chr(34)) ' is a vector

    End Sub

    Private Sub ucrInputLog_TextChanged(sender As Object, e As EventArgs) Handles ucrInputLog.TextChanged
        ucrBase.clsRsyntax.AddParameter("log", Chr(34) & ucrInputLog.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputAT_TextChanged(sender As Object, e As EventArgs) Handles ucrInputAt.TextChanged
        ucrBase.clsRsyntax.AddParameter("at", Chr(34) & ucrInputAt.Text.ToString() & Chr(34))

    End Sub

    Private Sub ucrInputBorder_TextChanged(sender As Object, e As EventArgs) Handles ucrInputBorder.TextChanged
        ucrBase.clsRsyntax.AddParameter("border", Chr(34) & ucrInputBorder.Text.ToString() & Chr(34)) ' is a par("fg")

    End Sub

    Private Sub ucrInputPars_TextChanged(sender As Object, e As EventArgs) Handles ucrInputPars.TextChanged
        ucrBase.clsRsyntax.AddParameter("pars", Chr(34) & ucrInputColour.Text.ToString() & Chr(34)) ' is a vector

    End Sub
End Class