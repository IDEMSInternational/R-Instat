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
Public Class dlgBoxplotMethod
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
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

        'ucrChk
        ucrChkConvert.SetText("Convert")
        ucrChkConvert.SetParameter(New RParameter("convert"))
        'ucrChk
        ucrChkConvert.SetText("Horizontal")
        ucrChkHorizontal.SetParameter(New RParameter("horizontal"))
        'ucrNud
        ucrNudWhiskerLty.SetParameter(New RParameter("whisklty"))
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strClimateObject & "$boxplot_method")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub txtDataPeriodLabel_Leave(sender As Object, e As EventArgs) Handles txtDataPeriodLabel.Leave
        ucrBase.clsRsyntax.AddParameter("data_period_label", Chr(34) & txtDataPeriodLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtInterestedVariable_Leave(sender As Object, e As EventArgs) Handles txtInterestedVariable.Leave
        ucrBase.clsRsyntax.AddParameter("interested_var", Chr(34) & txtInterestedVariable.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtFactor_Leave(sender As Object, e As EventArgs) Handles txtFactor.Leave
        ucrBase.clsRsyntax.AddParameter("factor", Chr(34) & txtFactor.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtXLabel_Leave(sender As Object, e As EventArgs) Handles txtXLabel.Leave
        ucrBase.clsRsyntax.AddParameter("xlabel", Chr(34) & txtXLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtYLabel_Leave(sender As Object, e As EventArgs) Handles txtYLabel.Leave
        ucrBase.clsRsyntax.AddParameter("ylabel", Chr(34) & txtYLabel.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtFillColour_Leave(sender As Object, e As EventArgs) Handles txtFillColour.Leave
        ucrBase.clsRsyntax.AddParameter("fill_col", Chr(34) & txtFillColour.Text.ToString() & Chr(34))
    End Sub

    Private Sub txtTitle_Leave(sender As Object, e As EventArgs) Handles txtTitle.Leave
        ucrBase.clsRsyntax.AddParameter("title", Chr(34) & txtTitle.Text.ToString() & Chr(34))
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub ReOpenDialog()
    End Sub
End Class