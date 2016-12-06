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
Public Class dlgStartofRains
    Public clsAddKey, clsAfterFifty, clsRainfallOverThreshold, clsRollingSum, clsMinimumRainfall, clsRollingofThreshold, clsXdaysRain, clsFirstDOYPerYear, clsFirstInstance, clsNoRain, clsCumulativeRain, clsDryPeriodTen, clsWithinThirtyDays As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgStartofRains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRainfall.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub grpRainParameters_Enter(sender As Object, e As EventArgs) Handles nudFrom.TextChanged, nudTo.TextChanged, nudThreshold.TextChanged, nudOverDays.TextChanged
        TestOKEnabled()
    End Sub

    Private Sub grpConditionsForSatrtofRains_Enter(sender As Object, e As EventArgs) Handles chkConsecutiveRainyDays.CheckedChanged, chkTotalRainfall.CheckedChanged, chkTotalRainfall.CheckedChanged, nudValue.TextChanged, nudMinimum.TextChanged, nudMaximumDays.TextChanged, nudLengthofTime.TextChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRainfall_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRainfall.SelectionChanged

    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged

    End Sub
End Class