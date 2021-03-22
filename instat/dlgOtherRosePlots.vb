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
Public Class dlgOtherRosePlots
    Private bFirstLoad As Boolean = True
    Private bRcodeSet As Boolean = False
    Private bReset As Boolean = True

    'R function
    Private clsOtherRosePlots, clsCombineValues As New RFunction

    Private Sub dlgOtherRosePlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        Dim dctMethod As New Dictionary(Of String, String)
        Dim dctcolor As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorOtherRosePlots.SetParameter(New RParameter("data", 0))
        ucrSelectorOtherRosePlots.SetParameterIsrfunction()

        ucrReceiverDate.Selector = ucrSelectorOtherRosePlots
        ucrReceiverDate.SetParameter(New RParameter("date_col_name", 1))
        ucrReceiverDate.SetParameterIsString()
        'UcrReceiverDate.SetIncludedDataTypes({"Date"})
        'UcrReceiverDate.SetClimaticType("date")
        'UcrReceiverDate.bAutoFill = True

        ucrReceiverWindDirection.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindDirection.SetParameter(New RParameter("wd_col_name", 2))
        ucrReceiverWindDirection.SetParameterIsString()
        'ucrReceiverWindDirection.SetClimaticType("wind_direction")
        'ucrReceiverWindDirection.bAutoFill = True

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws_col_name", 3))
        ucrReceiverWindSpeed.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindSpeed.SetParameterIsString()
        'ucrReceiverWindSpeed.SetClimaticType("wind_speed")
        'ucrReceiverWindSpeed.bAutoFill = True

        ucrReceiverX.SetParameter(New RParameter("x", 4))
        ucrReceiverX.Selector = ucrSelectorOtherRosePlots
        ucrReceiverX.SetParameterIsString()

        ucrPnlOptions.SetParameter(New RParameter("main_method", 5))
        ucrPnlOptions.AddRadioButton(rdoPercentileRose, Chr(34) & "percentile_rose" & Chr(34))
        ucrPnlOptions.AddRadioButton(rdoPolarCluster, Chr(34) & "polar_cluster" & Chr(34))
        ucrPnlOptions.AddRadioButton(rdoPolarFrequency, Chr(34) & "polar_frequency" & Chr(34))
        ucrPnlOptions.AddRadioButton(rdoPolarPlot, Chr(34) & "polar_plot" & Chr(34))
        ucrPnlOptions.AddRadioButton(rdoPolarAnnulus, Chr(34) & "polar_annulus" & Chr(34))

        ucrPnlOptions.AddParameterValuesCondition(rdoPercentileRose, "main_method", Chr(34) & "percentile_rose" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarCluster, "main_method", Chr(34) & "polar_cluster" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarFrequency, "main_method", Chr(34) & "polar_frequency" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarPlot, "main_method", Chr(34) & "polar_plot" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarAnnulus, "main_method", Chr(34) & "polar_annulus" & Chr(34))

        ucrReceiverPollutant.SetParameter(New RParameter("pollutant", 6))
        ucrReceiverPollutant.Selector = ucrSelectorOtherRosePlots
        ucrReceiverPollutant.SetParameterIsString()

        ucrReceiverMultiplePollutants.SetParameter(New RParameter("pollutant", 7))
        ucrReceiverMultiplePollutants.Selector = ucrSelectorOtherRosePlots
        ucrReceiverMultiplePollutants.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultiplePollutants.strSelectorHeading = "Numerics"
        ucrReceiverMultiplePollutants.SetParameterIsString()

        ucrPnlOptions.AddToLinkedControls({ucrChkNormalise}, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkTransform}, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverX, {rdoPolarCluster, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverWindSpeed, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverPollutant, {rdoPolarCluster, rdoPolarFrequency}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverMultiplePollutants, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputMethod, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrPnlOptions.AddToLinkedControls(ucrInputColor, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrPnlOptions.AddToLinkedControls({ucrChkSmooth, ucrNudPercentile}, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputStatistic, {rdoPolarFrequency, rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="frequency")
        ucrPnlOptions.AddToLinkedControls(ucrChkForcePositive, {rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkExcludeMissing, ucrChkPadDate}, {rdoPolarAnnulus}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrNudNmberOfClusters, {rdoPolarCluster}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlOptions.AddToLinkedControls(ucrInputStationFacet, {rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot, rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")

        ucrInputStatistic.SetLinkedDisplayControl(lblStatistic)
        'ucrInputStationFacet.SetLinkedDisplayControl(lblType)
        ucrReceiverX.SetLinkedDisplayControl(lblVariableToPlotAgainst)
        ucrReceiverWindSpeed.SetLinkedDisplayControl(lblWindSpeed)
        ucrNudPercentile.SetLinkedDisplayControl(lblPercentile)
        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrInputColor.SetLinkedDisplayControl(lblColor)
        ucrNudNmberOfClusters.SetLinkedDisplayControl(lblNoOfClusters)

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 9))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTransform.SetRDefault("TRUE")

        ucrInputColor.SetParameter(New RParameter("cols", 10))
        dctcolor.Add("Default", Chr(34) & "default" & Chr(34))
        dctcolor.Add("increment", Chr(34) & "increment" & Chr(34))
        dctcolor.Add("heat", Chr(34) & "heat" & Chr(34))
        dctcolor.Add("jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctcolor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrInputStatistic.SetItems({"frequency", "mean", "median", "max", "stdev", "weighted.mean"})
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrNudNmberOfClusters.SetParameter(New RParameter("n.clusters", 12))
        ucrNudNmberOfClusters.Minimum = 2
        ucrNudNmberOfClusters.SetRDefault(6)

        ucrChkPadDate.SetText("Pad Date")
        ucrChkPadDate.SetParameter(New RParameter("date.pad", 13))
        ucrChkPadDate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPadDate.SetRDefault("FALSE")

        ucrChkExcludeMissing.SetText("Exclude Missing")
        ucrChkExcludeMissing.SetParameter(New RParameter("exclude.missing", 14))
        ucrChkExcludeMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkExcludeMissing.SetRDefault("TRUE")

        ucrChkNormalise.SetText("Normalise")
        ucrChkNormalise.SetParameter(New RParameter("normalise", 15))
        ucrChkNormalise.SetRDefault("FALSE")

        ucrChkForcePositive.SetText("Force positive")
        ucrChkForcePositive.SetParameter(New RParameter("force.positive", 16))
        ucrChkForcePositive.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkForcePositive.SetRDefault("TRUE")

        ucrInputMethod.SetParameter(New RParameter("method", 17))
        dctMethod.Add("Default", Chr(34) & "default" & Chr(34))
        dctMethod.Add("CPF", Chr(34) & "cpf" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetDropDownStyleAsNonEditable()

        ucrChkSmooth.SetText("Smooth")
        ucrChkSmooth.SetParameter(New RParameter("smooth", 18))
        ucrChkSmooth.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSmooth.SetRDefault("FALSE")

        ucrNudPercentile.SetParameter(New RParameter("percentile", 19))
        ucrNudPercentile.Minimum = 2
        ucrNudPercentile.SetRDefault(90)
        ucrNudPercentile.SetMinMax(0, 100)

        ucrReceiverStation.SetParameter(New RParameter(""))
        ucrReceiverStation.Selector = ucrSelectorOtherRosePlots
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bExcludeFromSelector = True
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrInputStationFacet.SetItems({"NONE", "FACET 1", "FACET 2"})
        ucrInputStationFacet.SetDropDownStyleAsNonEditable()

        ucrInputFacet.SetParameter(New RParameter(""))
        ucrInputFacet.SetItems({"default", "station", "year", "hour", "month", "season", "weekday", "site", "weekend", "monthyear", "daylight", "dst"})
        ucrInputFacet.SetDropDownStyleAsEditable(True)

        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOtherRosePlots.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsOtherRosePlots = New RFunction
        clsCombineValues = New RFunction

        ucrInputStationFacet.SetText("NONE")
        ucrInputFacet.SetText("default")

        ucrSelectorOtherRosePlots.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        ucrInputStatistic.SetName("mean")

        clsOtherRosePlots.SetRCommand("other_rose_plots")
        clsCombineValues.SetRCommand("c")

        clsCombineValues.AddParameter("type1", Chr(34) & "default" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)

        clsOtherRosePlots.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=10)
        clsOtherRosePlots.AddParameter("exclude.missing", "FALSE")
        clsOtherRosePlots.AddParameter("trans", "TRUE")
        'clsOtherRosePlots.AddParameter("force.positive", "TRUE")
        clsOtherRosePlots.AddParameter("main_method", Chr(34) & "polar_frequency" & Chr(34), iPosition:=5)
        clsOtherRosePlots.AddParameter("statistic", Chr(34) & "mean" & Chr(34), iPosition:=11)
        clsOtherRosePlots.AddParameter("type", clsRFunctionParameter:=clsCombineValues, bIncludeArgumentName:=True, iPosition:=9)

        'AddRemoveStatistic()

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsOtherRosePlots)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRcodeSet = False
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSelectorOtherRosePlots.SetRCode(clsOtherRosePlots, bReset)

        ucrReceiverDate.SetRCode(clsOtherRosePlots, bReset)
        ucrReceiverWindSpeed.SetRCode(clsOtherRosePlots, bReset)
        ucrReceiverWindDirection.SetRCode(clsOtherRosePlots, bReset)
        ucrReceiverMultiplePollutants.SetRCode(clsOtherRosePlots, bReset)
        ucrReceiverX.SetRCode(clsOtherRosePlots, bReset)
        ucrReceiverPollutant.SetRCode(clsOtherRosePlots, bReset)

        ucrInputColor.SetRCode(clsOtherRosePlots, bReset)
        ucrInputStatistic.SetRCode(clsOtherRosePlots, bReset)
        ucrInputStatistic.SetRCode(clsOtherRosePlots, bReset)
        ucrInputMethod.SetRCode(clsOtherRosePlots, bReset)
        'ucrInputFacet.SetRCode(clsOtherRosePlots, bReset)
        'ucrInputStationFacet.SetRCode(clsOtherRosePlots, bReset)

        ucrChkForcePositive.SetRCode(clsOtherRosePlots, bReset)
        ucrChkExcludeMissing.SetRCode(clsOtherRosePlots, bReset)
        ucrChkNormalise.SetRCode(clsOtherRosePlots, bReset)
        ucrChkPadDate.SetRCode(clsOtherRosePlots, bReset)
        ucrChkSmooth.SetRCode(clsOtherRosePlots, bReset)
        ucrChkTransform.SetRCode(clsOtherRosePlots, bReset)

        ucrNudPercentile.SetRCode(clsOtherRosePlots, bReset)
        ucrNudNmberOfClusters.SetRCode(clsOtherRosePlots, bReset)

        bRcodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverWindDirection.IsEmpty OrElse Not ucrReceiverDate.IsEmpty OrElse ucrSaveGraph.IsComplete Then
            If rdoPolarFrequency.Checked Then
                If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverPollutant.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            If rdoPercentileRose.Checked Then
                If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverMultiplePollutants.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            If rdoPolarPlot.Checked Then
                If Not ucrReceiverX.IsEmpty AndAlso Not ucrReceiverMultiplePollutants.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            If rdoPolarAnnulus.Checked Then
                If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverMultiplePollutants.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            If rdoPolarCluster.Checked Then
                If Not ucrReceiverX.IsEmpty AndAlso Not ucrReceiverPollutant.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
        ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub UcrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrReceiverWindDirection.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrReceiverPollutant.ControlContentsChanged, ucrReceiverX.ControlContentsChanged, ucrReceiverMultiplePollutants.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AddRemoveStatistic()

        If rdoPolarFrequency.Checked Then
            If Not ucrReceiverPollutant.IsEmpty Then
                clsOtherRosePlots.AddParameter("statistic", Chr(34) & ucrInputStatistic.GetText & Chr(34), iPosition:=11)
                ucrInputStatistic.Visible = True
                lblStatistic.Visible = True
            Else
                clsOtherRosePlots.RemoveParameterByName("statistic")
                ucrInputStatistic.Visible = False
                lblStatistic.Visible = False
            End If
        ElseIf rdoPolarAnnulus.Checked OrElse rdoPolarPlot.Checked Then
            clsOtherRosePlots.AddParameter("statistic", Chr(34) & ucrInputStatistic.GetText & Chr(34), iPosition:=11)
        ElseIf rdoPolarCluster.Checked OrElse rdoPercentileRose.Checked Then
            clsOtherRosePlots.RemoveParameterByName("statistic")
        End If
    End Sub

    Private Sub ucrReceiverPollutant_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPollutant.ControlValueChanged, ucrInputStatistic.ControlValueChanged
        AddRemoveStatistic()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoPolarAnnulus.Checked Then
            ucrSaveGraph.SetPrefix("Polar_Annulus")
        ElseIf rdoPolarPlot.Checked Then
            ucrSaveGraph.SetPrefix("Polar_Plot")
        ElseIf rdoPolarCluster.Checked Then
            ucrSaveGraph.SetPrefix("Polar_Cluster")
        ElseIf rdoPolarFrequency.Checked Then
            ucrSaveGraph.SetPrefix("Polar_Frequency")
        ElseIf rdoPercentileRose.Checked Then
            ucrSaveGraph.SetPrefix("Percentile_Rose")
        End If
        AddRemoveStatistic()
    End Sub

    Private Sub ucrInputStationFacet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStationFacet.ControlValueChanged, ucrReceiverStation.ControlValueChanged, ucrInputFacet.ControlValueChanged
        If bRcodeSet Then
            Select Case ucrInputStationFacet.GetText
                Case "NONE"
                    clsCombineValues.RemoveParameterByName("type2")
                    Select Case ucrInputFacet.GetText
                        Case "default"
                            clsCombineValues.AddParameter("type1", Chr(34) & "default" & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
                        Case Else
                            clsCombineValues.AddParameter("type1", Chr(34) & ucrInputFacet.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
                    End Select
                Case "FACET 1"
                    Select Case ucrInputFacet.GetText
                        Case "default"
                            clsCombineValues.RemoveParameterByName("type2")
                            clsCombineValues.AddParameter("type1", ucrReceiverStation.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=0)
                        Case Else
                            clsCombineValues.AddParameter("type1", ucrReceiverStation.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=0)
                            clsCombineValues.AddParameter("type2", Chr(34) & ucrInputFacet.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
                    End Select
                Case "FACET 2"
                    Select Case ucrInputFacet.GetText
                        Case "default"
                            clsCombineValues.RemoveParameterByName("type2")
                            clsCombineValues.AddParameter("type1", ucrReceiverStation.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=0)
                        Case Else
                            clsCombineValues.AddParameter("type1", Chr(34) & ucrInputFacet.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
                            clsCombineValues.AddParameter("type2", ucrReceiverStation.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=1)
                    End Select
            End Select
        End If
    End Sub
End Class