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
Imports instat
Imports instat.Translations
Public Class dlgCliPlot
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgCliPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0

        'ucrChks
        ucrChkStationName.SetText("Station Name")
        ucrChkStationName.SetParameter(New RParameter("station_name"))
        ucrChkRemoveNA.SetText("Remove Missing Values")
        ucrChkRemoveNA.SetParameter(New RParameter("na.rm"))
        ucrChkInheritAES.SetText("Inherit AES")
        ucrChkInheritAES.SetParameter(New RParameter("inherit.aes"))
        ucrChkByFactor.SetText("By Factor")
        ucrChkByFactor.SetParameter(New RParameter("by_factor"))

        'ucrNud
        ucrNudLineType.SetParameter(New RParameter("linetype"))
        ucrNudSize.SetParameter(New RParameter("size"))

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

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        'Define the default RFunction
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strClimateObject & "$cliplot")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    '    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ...
    '        TestOkEnabled()
    '    End Sub

End Class