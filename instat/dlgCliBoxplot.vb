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
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Private Sub dlgCliBoxplot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub


    Private Sub TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrInputDataPeriod.SetParameter(New RParameter("data_period_label", 1))
        ucrInputDataPeriod.SetValidationTypeAsRVariable()

        ucrInputFactorLab.SetParameter(New RParameter("factor", 2))
        ucrInputFactorLab.SetValidationTypeAsRVariable()

        ucrInputWidth.SetParameter(New RParameter("width", 3))
        ucrInputWidth.SetValidationTypeAsRVariable()

        ucrInputLog.SetParameter(New RParameter("log", 4))
        ucrInputLog.SetValidationTypeAsRVariable()

        ucrInputAt.SetParameter(New RParameter("at", 5))
        ucrInputAt.SetValidationTypeAsRVariable()


        ucrInputBorder.SetParameter(New RParameter("border", 6))
        ucrInputBorder.SetValidationTypeAsRVariable()

        '  ucrInputColour.SetParameter(New RParameter("pars", 7))
        ' ucrInputColour.SetValidationTypeAsRVariable()

        ucrInputColour.SetParameter(New RParameter("col", 8))
        ucrInputColour.SetValidationTypeAsRVariable()

        ucrInputTitle.SetParameter(New RParameter("title", 9))
        ucrInputTitle.SetValidationTypeAsRVariable()

        ucrInputVariable.SetParameter(New RParameter("var", 10))
        ucrInputVariable.SetValidationTypeAsRVariable()

        ucrInputYLabel.SetParameter(New RParameter("ylab", 11))
        ucrInputYLabel.SetValidationTypeAsRVariable()

        ucrInputXLabel.SetParameter(New RParameter("xlab", 0))
        ucrInputXLabel.SetValidationTypeAsRVariable()


        ucrchkHorizontal.SetText("Horizaontal")
        ucrchkHorizontal.SetParameter(New RParameter("horizontal"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrchkHorizontal.SetRDefault("FALSE")


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


    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        'reset

        'Define the default RFunction
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strClimateObject & "$cliboxplot")

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub
End Class