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
Public Class dlgDisplayRainRunningTotal
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True

    Private Sub dlgDisplayRainRunningTotal_(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 
        ucrBase.OKEnabled(False)

        'ucrNudDecimalPlaces.SetParameter(New RParameter(" ", ))
        'ucrNudThreshold.SetParameter(New RParameter(" ", ))
        'ucrNudTotalDays.SetParameter(New RParameter(" ", ))

        'ucrChkMonthList.SetParameter(New RParameter("", 0))
        ucrChkMonthList.SetText("Month List")
        'ucrChkMonthList.SetRDefault(" ")

        'ucrChkRemoveMissingValues.SetParameter(New RParameter("", 2))
        ucrChkRemoveMissingValues.SetText("Remove Missing Values")
        'ucrChkRemoveMissingValues.SetRDefault(" ")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        clsDefaultFunction.SetRCommand("climate_obj$display_rain_running_total()")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOKEnabled()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'ControlContentsChanged for TestOKEnabled()
End Class