'R-Instat
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
Public Class dlgPolarAnnulus
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'Functions 
    Private clsPolarAnnulusFunction As RFunction
    Private Sub dlgPolarAnnulus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        Dim dctStatistic As New Dictionary(Of String, String)
        Dim dctType As New Dictionary(Of String, String)
        Dim dctPosition As New Dictionary(Of String, String)
        Dim dctColor As New Dictionary(Of String, String)
        Dim dctPercentile As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPolarAnnulus.SetParameter(New RParameter("mydata", 0))
        ucrSelectorPolarAnnulus.SetParameterIsrfunction()

        ucrReceiverMultiplePollutant.SetParameter(New RParameter("pollutant", 1))
        ucrReceiverMultiplePollutant.Selector = ucrSelectorPolarAnnulus
        ucrReceiverMultiplePollutant.SetParameterIsString()

        ucrReceiverSinglePollutant.SetParameter(New RParameter("pollutant", 2))
        ucrReceiverSinglePollutant.Selector = ucrSelectorPolarAnnulus
        ucrReceiverSinglePollutant.SetParameterIsString()

        ucrReceiverWindDirection.SetParameter(New RParameter("wd", 3))
        ucrReceiverWindDirection.Selector = ucrSelectorPolarAnnulus
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverDate.SetParameter(New RParameter("date", 4))
        ucrReceiverDate.Selector = ucrSelectorPolarAnnulus
        ucrReceiverDate.SetParameterIsString()

        ucrChckExcludeMissing.SetText("Exclude Missing")
        ucrChckExcludeMissing.SetParameter(New RParameter("exclude.missing", 5))
        ucrChckExcludeMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChckPadDate.SetText("Pad Date")
        ucrChckPadDate.SetParameter(New RParameter("date.pad", 6))
        ucrChckPadDate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputType.SetParameter(New RParameter("type", 7))
        dctType.Add("Default", Chr(34) & "default" & Chr(34))
        dctType.Add("Year", Chr(34) & "year" & Chr(34))
        dctType.Add("Month", Chr(34) & "month" & Chr(34))
        dctType.Add("Season", Chr(34) & "season" & Chr(34))
        dctType.Add("Weekday", Chr(34) & "weekday" & Chr(34))
        dctType.Add("Weekend", Chr(34) & "weekend" & Chr(34))
        dctType.Add("DST", Chr(34) & "dst" & Chr(34))
        ucrInputType.SetItems(dctType)
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrInputKeyPosition.SetParameter(New RParameter("key.position", 8))
        dctPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctPosition.Add("Tight", Chr(34) & "right" & Chr(34))
        dctPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctPosition.Add("Left", Chr(34) & "left" & Chr(34))
        ucrInputKeyPosition.SetItems(dctPosition)
        ucrInputKeyPosition.SetDropDownStyleAsNonEditable()

        ucrInputStatistic.SetParameter(New RParameter("statistic", 9))
        dctStatistic.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatistic.Add("Percentile", Chr(34) & "percentile" & Chr(34))
        dctStatistic.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatistic.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatistic.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatistic.Add("Standard deviation", Chr(34) & "stdev" & Chr(34))
        dctStatistic.Add("Weighted Mean", Chr(34) & "weighted.mean" & Chr(34))
        dctStatistic.Add("CPF", Chr(34) & "cpf" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputStatistic.AddToLinkedControls(ucrNudPercentile, {"Percentile", "CPF"}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPercentile.SetLinkedDisplayControl(lblPercentile)

        ucrChkMultiplePollutants.SetText("Multiple Pollutants")
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverMultiplePollutant, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultiplePollutant.SetLinkedDisplayControl(lblMultiplePollutant)
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverSinglePollutant, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverSinglePollutant.SetLinkedDisplayControl(lblSinglePollutant)
        ucrChkMultiplePollutants.AddToLinkedControls(ucrChkNormalize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputColor.SetParameter(New RParameter("cols", 10))
        dctColor.Add("Default", Chr(34) & "default" & Chr(34))
        dctColor.Add("Increment", Chr(34) & "increment" & Chr(34))
        dctColor.Add("Heat", Chr(34) & "heat" & Chr(34))
        dctColor.Add("Jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrNudMinimumBins.SetParameter(New RParameter("min.bin", 11))
        ucrNudMinimumBins.Minimum = 1

        ucrNudPercentile.SetParameter(New RParameter("percentile", 12))
        ucrNudPercentile.Minimum = 1

        ucrChkNormalize.SetText("Normalise")
        ucrChkNormalize.SetParameter(New RParameter("normalise", 13))
        ucrChkNormalize.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub SetDefaults()
        clsPolarAnnulusFunction = New RFunction

        clsPolarAnnulusFunction.AddParameter("exclude.missing", "TRUE", iPosition:=5)
        clsPolarAnnulusFunction.AddParameter("date.pad", "TRUE", iPosition:=6)
        clsPolarAnnulusFunction.AddParameter("type", Chr(34) & "default" & Chr(34), iPosition:=7)
        clsPolarAnnulusFunction.AddParameter("key.position", Chr(34) & "right" & Chr(34), iPosition:=8)
        clsPolarAnnulusFunction.AddParameter("statistic", Chr(34) & "mean" & Chr(34), iPosition:=9)
        clsPolarAnnulusFunction.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=10)
        clsPolarAnnulusFunction.AddParameter("min.bin", "2", iPosition:=11)
        clsPolarAnnulusFunction.AddParameter("percentile", "80", iPosition:=12)
        clsPolarAnnulusFunction.AddParameter("normalise", "TRUE", iPosition:=13)

        ucrSelectorPolarAnnulus.Reset()
        ucrReceiverMultiplePollutant.SetMeAsReceiver()

        clsPolarAnnulusFunction.SetPackageName("openair")
        clsPolarAnnulusFunction.SetRCommand("polarAnnulus")

        ucrBase.clsRsyntax.SetBaseRFunction(clsPolarAnnulusFunction)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverMultiplePollutant.IsEmpty OrElse ucrReceiverWindDirection.IsEmpty OrElse ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverPollutant_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindDirection.ControlValueChanged, ucrReceiverDate.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class