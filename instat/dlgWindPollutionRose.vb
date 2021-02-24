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

Public Class dlgWindPollutionRose
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'Functions 
    Private clsPollutionRoseFunction As RFunction

    Private Sub dlgPollutionRose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorWindPollutionRose.SetParameter(New RParameter("mydata", 0))
        ucrSelectorWindPollutionRose.SetParameterIsrfunction()

        ucrReceiverPollutant.SetParameter(New RParameter("pollutant", 1))
        ucrReceiverPollutant.Selector = ucrSelectorWindPollutionRose
        ucrReceiverPollutant.SetParameterIsString()

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws", 2))
        ucrReceiverWindSpeed.Selector = ucrSelectorWindPollutionRose
        ucrReceiverWindSpeed.SetParameterIsString()

        ucrReceiverWindDirection.SetParameter(New RParameter("wd", 3))
        ucrReceiverWindDirection.Selector = ucrSelectorWindPollutionRose
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverWindSpeed2.SetParameter(New RParameter("ws2", 4))
        ucrReceiverWindSpeed2.Selector = ucrSelectorWindPollutionRose
        ucrReceiverWindSpeed2.SetParameterIsString()

        ucrReceiverWindDirection2.SetParameter(New RParameter("wd2", 5))
        ucrReceiverWindDirection2.Selector = ucrSelectorWindPollutionRose
        ucrReceiverWindDirection2.SetParameterIsString()

        ucrReceiverDate.SetParameter(New RParameter("date_name", 6))
        ucrReceiverDate.Selector = ucrSelectorWindPollutionRose
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.SetClimaticType("date")

        ucrChkCompare.SetText("Compare")
        ucrChkCompare.AddToLinkedControls(ucrReceiverWindSpeed2, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverWindSpeed2.SetLinkedDisplayControl(lblWindSpeed2)
        ucrChkCompare.AddToLinkedControls(ucrReceiverWindDirection2, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverWindDirection2.SetLinkedDisplayControl(lblWindDirection2)

        ucrChkIncludePollutant.SetText("Include Pollutant")
        ucrChkIncludePollutant.SetParameter(New RParameter("include_pollutant", 7))
        ucrChkIncludePollutant.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkIncludePollutant.AddToLinkedControls(ucrReceiverPollutant, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverPollutant.SetLinkedDisplayControl(lblPollutant)

        ucrChkPaddle.SetText("Paddle")
        ucrChkPaddle.SetParameter(New RParameter("paddle", 8))
        ucrChkPaddle.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputType.SetParameter(New RParameter("type", 9))
        dctType.Add("Default", Chr(34) & "default" & Chr(34))
        dctType.Add("Station", Chr(34) & "station" & Chr(34))
        dctType.Add("Year", Chr(34) & "year" & Chr(34))
        dctType.Add("Hour", Chr(34) & "hour" & Chr(34))
        dctType.Add("Month", Chr(34) & "month" & Chr(34))
        dctType.Add("Season", Chr(34) & "season" & Chr(34))
        dctType.Add("Weekday", Chr(34) & "weekday" & Chr(34))
        dctType.Add("Site", Chr(34) & "site" & Chr(34))
        dctType.Add("Weekend", Chr(34) & "weekend" & Chr(34))
        dctType.Add("Monthyear", Chr(34) & "monthyear" & Chr(34))
        dctType.Add("Daylight", Chr(34) & "daylight" & Chr(34))
        dctType.Add("DST", Chr(34) & "dst" & Chr(34))
        ucrInputType.SetItems(dctType)
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrInputKeyPosition.SetParameter(New RParameter("key.position", 10))
        dctPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctPosition.Add("Left", Chr(34) & "left" & Chr(34))
        ucrInputKeyPosition.SetItems(dctPosition)
        ucrInputKeyPosition.SetDropDownStyleAsNonEditable()

        ucrInputStatistic.SetParameter(New RParameter("statistic", 11))
        dctStatistic.Add("prop.count", Chr(34) & "prop.count" & Chr(34))
        dctStatistic.Add("prop.mean", Chr(34) & "prop.mean" & Chr(34))
        dctStatistic.Add("abs.count", Chr(34) & "abs.count" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("cols", 12))
        dctColor.Add(“Default”, Chr(34) & "default" & Chr(34))
        dctColor.Add(“Increment”, Chr(34) & "increment" & Chr(34))
        dctColor.Add(“Heat”, Chr(34) & "heat" & Chr(34))
        dctColor.Add(“Jet”, Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        UcrReceiverStation.SetParameter(New RParameter("station", 13))
        UcrReceiverStation.Selector = ucrSelectorWindPollutionRose
        UcrReceiverStation.SetParameterIsString()
        UcrReceiverStation.bExcludeFromSelector = True
        UcrReceiverStation.SetClimaticType("station")
        UcrReceiverStation.bAutoFill = True

        ucrSaveGraph.SetPrefix("wind_pollution_rose")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorWindPollutionRose.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsPollutionRoseFunction = New RFunction
        clsPollutionRoseFunction.SetRCommand("pollution_rose")

        clsPollutionRoseFunction.AddParameter("include_pollutant", "FALSE", iPosition:=7)
        clsPollutionRoseFunction.AddParameter("paddle", "FALSE", iPosition:=8)
        clsPollutionRoseFunction.AddParameter("type", Chr(34) & "default" & Chr(34), iPosition:=9)
        clsPollutionRoseFunction.AddParameter("key.position", Chr(34) & "right" & Chr(34), iPosition:=10)
        clsPollutionRoseFunction.AddParameter("statistic", Chr(34) & "prop.count" & Chr(34), iPosition:=11)
        clsPollutionRoseFunction.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=12)

        ucrSelectorWindPollutionRose.Reset()
        ucrReceiverWindSpeed.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetBaseRFunction(clsPollutionRoseFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverWindDirection.IsEmpty OrElse ucrReceiverDate.IsEmpty OrElse (ucrChkIncludePollutant.Checked AndAlso ucrReceiverPollutant.IsEmpty) OrElse (ucrChkCompare.Checked AndAlso (ucrReceiverWindDirection2.IsEmpty OrElse ucrReceiverWindSpeed2.IsEmpty)) OrElse Not ucrSaveGraph.IsComplete Then
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

    Private Sub ucrReceiverWindDirection_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindDirection.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrReceiverWindDirection2.ControlContentsChanged, ucrReceiverWindSpeed2.ControlContentsChanged, ucrReceiverPollutant.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrChkCompare.ControlContentsChanged, ucrChkIncludePollutant.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkIncludePollutant_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludePollutant.ControlValueChanged
        If Not ucrChkIncludePollutant.Checked Then
            clsPollutionRoseFunction.AddParameter("include_pollutant", "FALSE", iPosition:=7)
        Else
            clsPollutionRoseFunction.AddParameter("include_pollutant", "TRUE", iPosition:=7)
        End If
    End Sub
End Class