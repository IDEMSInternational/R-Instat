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
    Private bReset As Boolean = True

    'R function
    Private clsOtherRosePlots As New RFunction

    Private Sub dlgOtherRosePlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitiliseDialog()
        Dim dctMethod As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorOtherRosePlots.SetParameter(New RParameter("data", 0))
        ucrSelectorOtherRosePlots.SetParameterIsrfunction()

        ucrReceiverDate.Selector = ucrSelectorOtherRosePlots
        ucrReceiverDate.SetParameter(New RParameter("date_col_name", 1))
        ucrReceiverDate.SetParameterIsString()

        ucrReceiverWindDirection.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindDirection.SetParameter(New RParameter("wd_col_name", 2))
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws_col_name", 3))
        ucrReceiverWindSpeed.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindSpeed.SetParameterIsString()

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

        ucrReceiverPollutant.SetParameter(New RParameter("single_pollutant", 6))
        ucrReceiverPollutant.Selector = ucrSelectorOtherRosePlots
        ucrReceiverPollutant.SetParameterIsString()

        ucrReceiverMultiplePollutants.SetParameter(New RParameter("multiple_pollutant", 7))
        ucrReceiverMultiplePollutants.Selector = ucrSelectorOtherRosePlots
        ucrReceiverMultiplePollutants.SetIncludedDataTypes({"numeric"})
        ucrReceiverMultiplePollutants.strSelectorHeading = "Numerics"
        ucrReceiverMultiplePollutants.SetParameterIsString()

        ucrPnlOptions.AddToLinkedControls({ucrChkNormalise}, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkTransform}, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverX, {rdoPolarPlot, rdoPolarCluster}, bNewLinkedUpdateFunction:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverWindSpeed, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverPollutant, {rdoPolarCluster, rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverMultiplePollutants, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputMethod, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrPnlOptions.AddToLinkedControls(ucrInputColor, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrPnlOptions.AddToLinkedControls({ucrChkSmooth, ucrNudPercentile}, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputStatistic, {rdoPolarFrequency, rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="frequency")
        ucrPnlOptions.AddToLinkedControls(ucrChkForcePositive, {rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkExcludeMissing, ucrChkPadDate}, {rdoPolarAnnulus}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrNudNmberOfClusters, {rdoPolarCluster}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverFacetOne, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverFacetTwo, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputStatistic.SetLinkedDisplayControl(lblStatistic)
        ucrNudPercentile.SetLinkedDisplayControl(lblPercentile)
        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrInputColor.SetLinkedDisplayControl(lblColor)
        ucrNudNmberOfClusters.SetLinkedDisplayControl(lblNoOfClusters)
        ucrReceiverFacetOne.SetLinkedDisplayControl(lblFacetOne)
        ucrReceiverFacetTwo.SetLinkedDisplayControl(lblFacetTwo)

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 9))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkTransform.SetRDefault("TRUE")

        ucrInputColor.SetItems({"default", "increment", "heat", "jet"})
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

        ucrReceiverFacetOne.SetParameter(New RParameter("type1", 20))
        ucrReceiverFacetOne.Selector = ucrSelectorOtherRosePlots
        ucrReceiverFacetOne.SetParameterIsString()

        ucrReceiverFacetTwo.SetParameter(New RParameter("type2", 21))
        ucrReceiverFacetTwo.Selector = ucrSelectorOtherRosePlots
        ucrReceiverFacetTwo.SetParameterIsString()

        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOtherRosePlots.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsOtherRosePlots = New RFunction

        ucrSelectorOtherRosePlots.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        ucrInputStatistic.SetName("mean")

        clsOtherRosePlots.SetRCommand("other_rose_plots")

        clsOtherRosePlots.AddParameter("trans", "TRUE", iPosition:=9)
        clsOtherRosePlots.AddParameter("main_method", Chr(34) & "polar_frequency" & Chr(34), iPosition:=5)
        clsOtherRosePlots.AddParameter("statistic", Chr(34) & "mean" & Chr(34), iPosition:=11)
        clsOtherRosePlots.AddParameter("exclude.missing", "FALSE", iPosition:=14)

        ucrBase.clsRsyntax.SetBaseRFunction(clsOtherRosePlots)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverWindDirection.IsEmpty OrElse Not ucrReceiverDate.IsEmpty OrElse ucrSaveGraph.IsComplete Then
            If rdoPolarFrequency.Checked Then
                If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverPollutant.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoPercentileRose.Checked Then
                If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverMultiplePollutants.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoPolarPlot.Checked Then
                If Not ucrReceiverX.IsEmpty AndAlso Not ucrReceiverMultiplePollutants.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoPolarAnnulus.Checked Then
                If Not ucrReceiverWindSpeed.IsEmpty AndAlso Not ucrReceiverMultiplePollutants.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoPolarCluster.Checked Then
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
        Else
            clsOtherRosePlots.RemoveParameterByName("statistic")
        End If
    End Sub

    Private Sub ucrReceiverPollutant_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPollutant.ControlValueChanged, ucrInputStatistic.ControlValueChanged
        AddRemoveStatistic()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        ucrReceiverDate.SetMeAsReceiver()
        If rdoPolarAnnulus.Checked Then
            ucrSaveGraph.SetPrefix("polar_annulus_plot")
        ElseIf rdoPolarPlot.Checked Then
            ucrSaveGraph.SetPrefix("polar_plot")
        ElseIf rdoPolarCluster.Checked Then
            ucrSaveGraph.SetPrefix("polar_cluster_plot")
        ElseIf rdoPolarFrequency.Checked Then
            ucrSaveGraph.SetPrefix("polar_freq_plot")
        ElseIf rdoPercentileRose.Checked Then
            ucrSaveGraph.SetPrefix("percentile_rose_plot")
        End If
        AddRemoveStatistic()
    End Sub
End Class