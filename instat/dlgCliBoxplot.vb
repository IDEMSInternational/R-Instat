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

        ucrInputDataPeriod.SetParameter(New RParameter("data_period_label", 0))
        ucrInputDataPeriod.SetValidationTypeAsRVariable()

        ucrInputFactorLab.SetParameter(New RParameter("factor", 1))
        ucrInputFactorLab.SetValidationTypeAsRVariable()

        ucrInputWidth.SetParameter(New RParameter("width", 2))
        ucrInputWidth.SetValidationTypeAsRVariable()

        ucrInputLog.SetParameter(New RParameter("log", 3))
        ucrInputLog.SetValidationTypeAsRVariable()

        ucrInputAt.SetParameter(New RParameter("at", 4))
        ucrInputAt.SetValidationTypeAsRVariable()

        ucrInputBorder.SetParameter(New RParameter("border", 5))
        ucrInputBorder.SetValidationTypeAsRVariable()

        ucrInputPars.SetParameter(New RParameter("pars", 6))
        ucrInputPars.SetValidationTypeAsRVariable()

        ucrInputColour.SetParameter(New RParameter("col", 7))
        ucrInputColour.SetValidationTypeAsRVariable()

        ucrInputVariable.SetParameter(New RParameter("var", 8))
        ucrInputVariable.SetValidationTypeAsRVariable()

        ucrInputTitle.SetParameter(New RParameter("title", 9))
        ucrInputTitle.SetValidationTypeAsRVariable()

        ucrInputYLabel.SetParameter(New RParameter("ylab", 10))
        ucrInputYLabel.SetValidationTypeAsRVariable()

        ucrInputXLabel.SetParameter(New RParameter("xlab", 11))
        ucrInputXLabel.SetValidationTypeAsRVariable()

        ucrChkHorizontal.SetParameter(New RParameter("horizontal", 18), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkHorizontal.SetText("Horizontal")
        ucrChkHorizontal.SetRDefault("FALSE")

        ucrChkFactorLevel.SetText("Factor Level")
        ucrChkFactorLevel.SetParameter(New RParameter("factor_level", 19))

        ucrChkPlot.SetText("Plot")
        ucrChkPlot.SetParameter(New RParameter("plot", 13))

        ucrChkMonthAbbreviations.SetText("Month Abbreviations")
        ucrChkMonthAbbreviations.SetParameter(New RParameter("names", 17))

        ucrChkOutline.SetText("Outline")
        ucrChkOutline.SetParameter(New RParameter("outline", 16))

        ucrChkAdd.SetText("Add")
        ucrChkAdd.SetParameter(New RParameter("add", 12))

        ucrChkVariableWidth.SetText("Variable Width")
        ucrChkVariableWidth.SetParameter(New RParameter("varwidth", 14))

        ucrChkNotch.SetText("Notch")
        ucrChkNotch.SetParameter(New RParameter("notch", 15))

        ucrNudWhiskLineType.SetParameter(New RParameter("whisklty", 20))
        ucrNudThreshold.SetParameter(New RParameter("threshold", 21))
        ucrNudRange.SetParameter(New RParameter("range", 22))
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