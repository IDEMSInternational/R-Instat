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
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        Dim dctStatistic As New Dictionary(Of String, String)
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

        ucrChkCompareTwoSets.SetText("Compare two sets")
        ucrChkCompareTwoSets.AddParameterPresentCondition(True, "wd2")

        ucrChkPaddle.SetText("Paddle")
        ucrChkPaddle.SetParameter(New RParameter("paddle", 7))
        ucrChkPaddle.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputStatistic.SetParameter(New RParameter("statistic", 8))
        dctStatistic.Add("Proportion count", Chr(34) & "prop.count" & Chr(34))
        dctStatistic.Add("Proportion mean", Chr(34) & "prop.mean" & Chr(34))
        dctStatistic.Add("Absolute count", Chr(34) & "abs.count" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("cols", 9))
        dctColor.Add("Default", Chr(34) & "default" & Chr(34))
        dctColor.Add("Increment", Chr(34) & "increment" & Chr(34))
        dctColor.Add("Heat", Chr(34) & "heat" & Chr(34))
        dctColor.Add("Jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrReceiverFacetOne.SetParameter(New RParameter("type1", 10))
        ucrReceiverFacetOne.Selector = ucrSelectorWindPollutionRose
        ucrReceiverFacetOne.SetParameterIsString()

        ucrReceiverFacetTwo.SetParameter(New RParameter("type2", 11))
        ucrReceiverFacetTwo.Selector = ucrSelectorWindPollutionRose
        ucrReceiverFacetTwo.SetParameterIsString()

        ucrReceiverWindDirection2.SetLinkedDisplayControl(lblWindDirection2)
        ucrReceiverWindSpeed2.SetLinkedDisplayControl(lblWindSpeed2)
        ucrChkCompareTwoSets.AddToLinkedControls({ucrReceiverWindDirection2, ucrReceiverWindSpeed2}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetPrefix("pollution_rose_plot")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorWindPollutionRose.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsPollutionRoseFunction = New RFunction
        
        ucrSelectorWindPollutionRose.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        
        clsPollutionRoseFunction.SetRCommand("wind_pollution_rose")
        clsPollutionRoseFunction.AddParameter("paddle", "FALSE", iPosition:=7)
        clsPollutionRoseFunction.AddParameter("statistic", Chr(34) & "prop.count" & Chr(34), iPosition:=8)
        clsPollutionRoseFunction.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=9)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPollutionRoseFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverWindDirection.IsEmpty OrElse ucrReceiverWindSpeed.IsEmpty OrElse ucrReceiverDate.IsEmpty OrElse (ucrChkCompareTwoSets.Checked AndAlso (ucrReceiverWindDirection2.IsEmpty OrElse ucrReceiverWindSpeed2.IsEmpty)) OrElse Not ucrSaveGraph.IsComplete Then
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

    Private Sub ucrReceiverWindDirection_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverWindDirection.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrReceiverWindDirection2.ControlContentsChanged, ucrReceiverWindSpeed2.ControlContentsChanged, ucrReceiverPollutant.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrChkCompareTwoSets.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class
