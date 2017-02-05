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
Public Class dlgSeasonalSummaryRain
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgSeasonalSummaryRain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 1

        'ucrNuds
        ucrNudStartMonth.SetParameter(New RParameter("month_start", ))
        ucrNudNosOfMonths.SetParameter(New RParameter("number_month", ))
        ucrNudThreshold.SetParameter(New RParameter("threshold", ))

        'ucrChks
        ucrChkCountLabel.SetParameter(New RParameter("summaries", ))
        ucrChkCountLabel.SetText("Count Label")
        'ucrChkCountLabel.SetRDefault(" ")

        ucrChkSumLabel.SetParameter(New RParameter("summaries", ))
        ucrChkSumLabel.SetText("Sum Label")
        'ucrChkSumLabel.SetRDefault(" ")

        ucrChkMean.SetParameter(New RParameter("summaries", ))
        ucrChkMean.SetText("Mean")
        'ucrChkMean.SetRDefault(" ")

        ucrChkLongestDrySpellName.SetText("Longest Dry Spell Name")
        ucrChkRemoveNA.SetText("Remove Missing Values")
        ucrChkReplace.SetText("Replace")
        ucrChkStrictThreshold.SetText("Strict Threshold")
    End Sub


    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        'resets
        clsDefaultFunction.SetRCommand("climate_obj$seasonal_summary.rain()")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub txtTotal_Leave(sender As Object, e As EventArgs) Handles txtTotal.Leave
        'ucrBase.clsRsyntax.AddParameter("summary_col_names", Chr(34) & txtTotal.Text & Chr(34))
        'Not sure what we want from this in the future - ucr/txt/save control/etc, so left it as it is
    End Sub

    Private Sub txtCount_Leave(sender As Object, e As EventArgs) Handles txtCount.Leave
        'ucrBase.clsRsyntax.AddParameter("summary_col_names", Chr(34) & txtCount.Text & Chr(34))
        'Not sure what we want from this in the future - ucr/txt/save control/etc, so left it as it is
    End Sub

    Private Sub txtMean_Leave(sender As Object, e As EventArgs) Handles txtMean.Leave
        'ucrBase.clsRsyntax.AddParameter("summary_col_names", Chr(34) & txtMean.Text & Chr(34))
        'Not sure what we want from this in the future - ucr/txt/save control/etc, so left it as it is
    End Sub

    Private Sub txtLongDrySpellName_Leave(sender As Object, e As EventArgs) Handles txtLongDrySpellName.Leave
        'ucrBase.clsRsyntax.AddParameter("longest_dry_spell_name", Chr(34) & txtLongDrySpellName.Text & Chr(34))
        'Not sure what we want from this in the future - ucr/txt/save control/etc, so left it as it is
    End Sub

    Private Sub txtSpellLengthName_Leave(sender As Object, e As EventArgs) Handles txtSpellLengthName.Leave
        'ucrBase.clsRsyntax.AddParameter("spell_length_name", Chr(34) & txtSpellLengthName.Text & Chr(34))
        'Not sure what we want from this in the future - ucr/txt/save control/etc, so left it as it is
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'ControlContentsChanged for TestOKEnabled()
End Class