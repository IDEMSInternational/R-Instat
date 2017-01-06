' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgNewMarkovChains
    Public bFirstLoad As Boolean = True
    Private Sub dlgNewMarkovChains_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorMarkovChains = ucrReceiverStation.Selector
        ucrInputExcludeSep.SetItems({"Exclude", "Separate"})
        ucrInputMarkovType.SetItems({"Full", "Dry", "Both"})
        ucrInputInteractions.SetItems({"None", "All", "Both"})
        ucrInputOptions.SetItems({"No interactions", "Interactions", "Both"})
    End Sub

    Private Sub SetDefaults()
        ucrReceiverStation.SetMeAsReceiver()
        ucrReceiverRainfall.SetMeAsReceiver()
        ucrReceiverDOY.SetMeAsReceiver()
        ucrReceiverAdditionalVariables.SetMeAsReceiver()
        ucrReceiverDate.SetMeAsReceiver()
        nudSeasonalityFrom.Maximum = 6
        nudSeasonalityTo.Maximum = 6
        nudSeasonalityTo.Minimum = 0
        nudSeasonalityFrom.Minimum = 0
        nudSeasonalityFrom.Value = 3
        nudSeasonalityTo.Value = 3
        nudOrderTo.Minimum = 0
        nudSeasonalityFrom.Minimum = 0
        nudOrderFrom.Maximum = 10
        nudOrderTo.Maximum = 10
        nudOrderTo.Value = 2
        nudOrderTo.Value = 0
        chkSaveModel.Enabled = False
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverRainfall.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverStation_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverStation.SelectionChanged, ucrReceiverRainfall.SelectionChanged, ucrReceiverDOY.SelectionChanged, ucrReceiverDate.SelectionChanged, ucrReceiverAdditionalVariables.SelectionChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub
End Class