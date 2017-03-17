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
Public Class dlgFrequency
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        TestOkEnabled()
    End Sub
    Private Sub SetRCodeForControls()

    End Sub

    Private Sub SetDefaults()
        ucrReceiverFactors.SetMeAsReceiver()
        ucrFactorsSelector.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrSingleReceiver.Selector = ucrFactorsSelector
        ucrReceiverFactors.Selector = ucrFactorsSelector
        ucrReceiverSingle.Selector = ucrFactorsSelector
        ucrReceiverFactors.SetDataType("factor")
        ucrReceiverSingle.SetDataType("numeric")
        ucrSingleReceiver.SetDataType("factor")
        ucrchhWeights.SetText("Weights")
        ucrchkCheckDisplayMargins.SetText("Display Margins")
        ucrchkCounts.SetText("Counts")
        ucrchkOverallPercentages.SetText("Overall Percentages")
        ucrchkPercentagesOf.SetText("Percentages Of")
        ucrchkDisplay.SetText("How to Display")
        ucrchkMargins.SetText("Margins to Dispaly")
    End Sub

    Private Sub TestOkEnabled()

    End Sub

End Class