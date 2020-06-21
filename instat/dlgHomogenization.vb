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

Public Class dlgHomogenization
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCptMeanFunction, clsCptVarianceFunction, clsCptMeanVarianceFunction, clsExcludeNAFunction, clsPlotFunction, clsSummaryFunction, clsSnhtFunction, clsPettittFunction, clsBuishandFunction As New RFunction
    Private Sub dlgHomogenization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPenaltyOptions As New Dictionary(Of String, String)
        Dim dctMethodOptions As New Dictionary(Of String, String)
        Dim dctMeanDistribution As New Dictionary(Of String, String)
        Dim dctVarDistribution As New Dictionary(Of String, String)
        Dim dctMeanVarDistribution As New Dictionary(Of String, String)

        ucrReceiverElement.Selector = ucrSelectorHomogenization
        'ucrBase.clsRsyntax.iCallType = 2

        ucrReceiverElement.SetParameter(New RParameter("object", 0))
        ucrReceiverElement.SetMeAsReceiver()
        ucrReceiverElement.SetParameterIsRFunction()

        ucrPnlMethods.AddRadioButton(rdoCptMean)
        ucrPnlMethods.AddRadioButton(rdoCptVariance)
        ucrPnlMethods.AddRadioButton(rdoCptMeanVariance)
        ucrPnlMethods.AddRadioButton(rdoSnht)
        ucrPnlMethods.AddRadioButton(rdoPettitt)
        ucrPnlMethods.AddRadioButton(rdoBuishand)
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptMean, "cpt.mean")
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptVariance, "cpt.var")
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptMeanVariance, "cpt.meanvar")
        ucrPnlMethods.AddFunctionNamesCondition(rdoSnht, "snht")
        ucrPnlMethods.AddFunctionNamesCondition(rdoPettitt, "pettitt.test")
        ucrPnlMethods.AddFunctionNamesCondition(rdoBuishand, "br.test")
        ttOptions.SetToolTip(rdoSnht, "Performs a standard normal homogeneity test on the data supplied. This test searches the data for potential changepoints.")
        ttOptions.SetToolTip(rdoPettitt, "Performes a non-parametric test after Pettitt in order to test for a shift in the central tendency of a time series. The H0-hypothesis, no change, is tested against the HA-Hypothesis, change")
        ttOptions.SetToolTip(rdoBuishand, "Performes the Buishand range test for change-point detection of a normal variate.")

        ucrPnlOptions.AddRadioButton(rdoSingle)
        ucrPnlOptions.AddRadioButton(rdoNeighbouring)
        ucrPnlOptions.AddRadioButton(rdoMultiple)
        ucrPnlOptions.AddFunctionNamesCondition(rdoSingle, {"cpt.mean", "cpt.var", "cpt.meanvar", "snht", "pettitt.test", "br.test"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoNeighbouring, {"cpt.mean", "cpt.var", "cpt.meanvar", "snht", "pettitt.test", "br.test"}, False)
        ucrPnlOptions.AddFunctionNamesCondition(rdoMultiple, {"cpt.mean", "cpt.var", "cpt.meanvar", "snht", "pettitt.test", "br.test"}, False)

        ucrChkPlot.SetText("Plot")
        ucrChkPlot.AddRSyntaxContainsFunctionNamesCondition(True, {"plot"})
        ucrChkPlot.AddRSyntaxContainsFunctionNamesCondition(False, {"plot"}, False)

        ucrChkSummary.SetText("Summary")
        ucrChkSummary.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"})
        ucrChkSummary.AddRSyntaxContainsFunctionNamesCondition(False, {"summary"}, False)

        ucrInputComboPenalty.SetParameter(New RParameter("penalty", 1))
        dctPenaltyOptions.Add("None", Chr(34) & "None" & Chr(34))
        dctPenaltyOptions.Add("SIC", Chr(34) & "SIC" & Chr(34))
        dctPenaltyOptions.Add("BIC", Chr(34) & "BIC" & Chr(34))
        dctPenaltyOptions.Add("MBIC", Chr(34) & "MBIC" & Chr(34))
        dctPenaltyOptions.Add("AIC", Chr(34) & "AIC" & Chr(34))
        dctPenaltyOptions.Add("Hannan-Quinn", Chr(34) & "Hannan-Quinn" & Chr(34))
        dctPenaltyOptions.Add("Asymptotic", Chr(34) & "Asymptotic" & Chr(34))
        dctPenaltyOptions.Add("Manual", Chr(34) & "Manual" & Chr(34))
        dctPenaltyOptions.Add("CROPS", Chr(34) & "CROPS" & Chr(34))
        ucrInputComboPenalty.SetItems(dctPenaltyOptions)
        ucrInputComboPenalty.SetDropDownStyleAsNonEditable()

        ucrInputComboMethod.SetParameter(New RParameter("method", 2))
        dctMethodOptions.Add("AMOC", Chr(34) & "AMOC" & Chr(34))
        dctMethodOptions.Add("PELT", Chr(34) & "PELT" & Chr(34))
        dctMethodOptions.Add("SegNeigh", Chr(34) & "SegNeigh" & Chr(34))
        dctMethodOptions.Add("BinSeg", Chr(34) & "BinSeg" & Chr(34))
        ucrInputComboMethod.SetItems(dctMethodOptions)
        ucrInputComboMethod.SetDropDownStyleAsNonEditable()

        ucrInputComboMeanDistribution.SetParameter(New RParameter("test.stat", 3))
        dctMeanDistribution.Add("Normal", Chr(34) & "Normal" & Chr(34))
        dctMeanDistribution.Add("CUSUM", Chr(34) & "CUSUM" & Chr(34))
        ucrInputComboMeanDistribution.SetItems(dctMeanDistribution)
        ucrInputComboMeanDistribution.SetDropDownStyleAsNonEditable()
        ucrInputComboMeanDistribution.SetRDefault(Chr(34) & "Normal" & Chr(34))

        ucrInputComboVarDistribution.SetParameter(New RParameter("test.stat", 3))
        dctVarDistribution.Add("Normal", Chr(34) & "Normal" & Chr(34))
        dctVarDistribution.Add("CSS", Chr(34) & "CSS" & Chr(34))
        ucrInputComboVarDistribution.SetItems(dctVarDistribution)
        ucrInputComboVarDistribution.SetDropDownStyleAsNonEditable()
        ucrInputComboVarDistribution.SetRDefault(Chr(34) & "Normal" & Chr(34))

        ucrInputComboMeanVarDistribution.SetParameter(New RParameter("test.stat", 3))
        dctMeanVarDistribution.Add("Normal", Chr(34) & "Normal" & Chr(34))
        dctMeanVarDistribution.Add("Gamma", Chr(34) & "Gamma" & Chr(34))
        dctMeanVarDistribution.Add("Exponential", Chr(34) & "Exponential" & Chr(34))
        dctMeanVarDistribution.Add("Poisson", Chr(34) & "Poisson" & Chr(34))
        ucrInputComboMeanVarDistribution.SetItems(dctMeanVarDistribution)
        ucrInputComboMeanVarDistribution.SetDropDownStyleAsNonEditable()
        ucrInputComboMeanVarDistribution.SetRDefault(Chr(34) & "Normal" & Chr(34))

        ucrNudMinSegLen.SetParameter(New RParameter("minseglen", 4))
        ucrNudMinSegLen.SetRDefault(1)
        ucrNudMinSegLen.SetMinMax(0, Integer.MaxValue)
        ttOptions.SetToolTip(ucrNudMinSegLen.nudUpDown, "Positive integer giving the minimum segment length (no. of observations between changes), default is the minimum allowed by theory.")

        ucrInputQ.SetParameter(New RParameter("Q", 5))
        ucrInputQ.AddQuotesIfUnrecognised = False
        ucrInputQ.SetValidationTypeAsNumeric()
        ttOptions.SetToolTip(ucrInputQ.txtInput, "The maximum number of changepoints to search for using the BinSeg method")

        ucrInputPenValue.SetParameter(New RParameter("pen.value", 6))
        ucrInputPenValue.AddQuotesIfUnrecognised = False
        ucrInputPenValue.SetValidationTypeAsNumeric()
        ttOptions.SetToolTip(ucrInputPenValue.txtInput, "The theoretical type I error e.g.0.05 when using the Asymptotic penalty. A vector of length 2 (min,max) if using the CROPS penalty")

        ucrSaveResult.SetDataFrameSelector(ucrSelectorHomogenization.ucrAvailableDataFrames)

        ucrInputComboPenalty.AddToLinkedControls(ucrInputPenValue, {"Asymptotic", "CROPS"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrInputComboMethod.AddToLinkedControls(ucrInputQ, {"SegNeigh", "BinSeg"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverNeighbour, {rdoNeighbouring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMeanDistribution, {rdoCptMean}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboVarDistribution, {rdoCptVariance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMeanVarDistribution, {rdoCptMeanVariance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrNudPeriod, {rdoSnht}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMethod, {rdoCptMean, rdoCptVariance, rdoCptMeanVariance}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboMethod.SetLinkedDisplayControl(grpCptOptions)
        ucrNudPeriod.SetLinkedDisplayControl(grpSnhtOptions)
        ucrReceiverNeighbour.SetLinkedDisplayControl(lblNeighbouring)
        ucrInputPenValue.SetLinkedDisplayControl(lblPenaltyValue)
        ucrInputQ.SetLinkedDisplayControl(lblQ)

        ucrNudPeriod.SetParameter(New RParameter("period", 1))
        ucrNudPeriod.SetMinMax(1, Integer.MaxValue)

        ucrChkRobust.SetParameter(New RParameter("robust", 2))
        ucrChkRobust.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkRobust.SetRDefault("FALSE")
        ucrChkRobust.SetText("Robust")

        ucrChkScaled.SetParameter(New RParameter("scaled", 3))
        ucrChkScaled.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaled.SetRDefault("TRUE")
        ucrChkScaled.SetText("Scaled")

        'Not yet working!
        rdoMultiple.Enabled = False
        rdoNeighbouring.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsCptMeanFunction = New RFunction
        clsCptVarianceFunction = New RFunction
        clsCptMeanVarianceFunction = New RFunction
        clsExcludeNAFunction = New RFunction
        clsPlotFunction = New RFunction
        clsSummaryFunction = New RFunction
        clsSnhtFunction = New RFunction
        clsPettittFunction = New RFunction
        clsBuishandFunction = New RFunction

        ucrSelectorHomogenization.Reset()
        ucrSaveResult.Reset()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        clsCptMeanFunction.SetPackageName("changepoint")
        clsCptMeanFunction.SetRCommand("cpt.mean")
        clsCptMeanFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
        clsCptMeanFunction.AddParameter("Q", 5, iPosition:=5)
        clsCptMeanFunction.AddParameter("pen.value", 0, iPosition:=6)
        clsCptMeanFunction.AddParameter("penalty", Chr(34) & "None" & Chr(34), iPosition:=1)
        clsCptMeanFunction.AddParameter("method", Chr(34) & "BinSeg" & Chr(34), iPosition:=2)

        clsCptVarianceFunction.SetPackageName("changepoint")
        clsCptVarianceFunction.SetRCommand("cpt.var")
        clsCptVarianceFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)

        clsCptMeanVarianceFunction.SetPackageName("changepoint")
        clsCptMeanVarianceFunction.SetRCommand("cpt.meanvar")
        clsCptMeanVarianceFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)

        clsExcludeNAFunction.SetRCommand("na.exclude")

        clsPlotFunction.SetRCommand("plot")

        clsSummaryFunction.SetRCommand("summary")

        clsSnhtFunction.SetPackageName("snht")
        clsSnhtFunction.SetRCommand("snht")
        clsSnhtFunction.AddParameter("period", 10, iPosition:=1)

        clsPettittFunction.SetPackageName("trend")
        clsPettittFunction.SetRCommand("pettitt.test")
        clsPettittFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)

        clsBuishandFunction.SetPackageName("trend")
        clsBuishandFunction.SetRCommand("br.test")
        clsBuishandFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)

        ucrBase.clsRsyntax.ClearCodes()
        AddPlotSummaryParameters()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsSnhtFunction, New RParameter("data", 0), iAdditionalPairNo:=1)
        ucrReceiverElement.SetRCode(clsExcludeNAFunction, bReset)

        ucrInputComboPenalty.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputComboPenalty.GetParameter, iAdditionalPairNo:=1)
        ucrInputComboPenalty.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputComboPenalty.GetParameter, iAdditionalPairNo:=2)
        ucrInputComboPenalty.SetRCode(clsCptMeanFunction, bReset)

        ucrInputComboMethod.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputComboMethod.GetParameter, iAdditionalPairNo:=1)
        ucrInputComboMethod.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputComboMethod.GetParameter, iAdditionalPairNo:=2)
        ucrInputComboMethod.SetRCode(clsCptMeanFunction, bReset)

        ucrInputComboMeanDistribution.SetRCode(clsCptMeanFunction, bReset)
        ucrInputComboVarDistribution.SetRCode(clsCptVarianceFunction, bReset)
        ucrInputComboMeanVarDistribution.SetRCode(clsCptMeanVarianceFunction, bReset)

        ucrNudMinSegLen.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrNudMinSegLen.GetParameter, iAdditionalPairNo:=1)
        ucrNudMinSegLen.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrNudMinSegLen.GetParameter, iAdditionalPairNo:=2)
        ucrNudMinSegLen.SetRCode(clsCptMeanFunction, bReset)

        ucrInputQ.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputQ.GetParameter, iAdditionalPairNo:=1)
        ucrInputQ.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputQ.GetParameter, iAdditionalPairNo:=2)
        ucrInputQ.SetRCode(clsCptMeanFunction, bReset)

        ucrInputPenValue.AddAdditionalCodeParameterPair(clsCptVarianceFunction, ucrInputPenValue.GetParameter, iAdditionalPairNo:=1)
        ucrInputPenValue.AddAdditionalCodeParameterPair(clsCptMeanVarianceFunction, ucrInputPenValue.GetParameter, iAdditionalPairNo:=2)
        ucrInputPenValue.SetRCode(clsCptMeanFunction, bReset)

        ucrPnlMethods.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrSaveResult.AddAdditionalRCode(clsCptVarianceFunction, iAdditionalPairNo:=1)
        ucrSaveResult.AddAdditionalRCode(clsCptMeanVarianceFunction, iAdditionalPairNo:=2)
        ucrSaveResult.SetRCode(clsCptMeanFunction, bReset)

        ucrChkPlot.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)

        ucrNudPeriod.SetRCode(clsSnhtFunction, bReset)
        ucrChkScaled.SetRCode(clsSnhtFunction, bReset)
        ucrChkRobust.SetRCode(clsSnhtFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverElement.IsEmpty OrElse Not ucrSaveResult.IsComplete OrElse (ucrInputComboMethod.GetText = "BinSeg" AndAlso ucrInputQ.IsEmpty) OrElse (ucrInputComboPenalty.GetText = "Asymptotic" AndAlso ucrInputPenValue.IsEmpty) OrElse ucrNudMinSegLen.GetText = "" Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrPnlMethods_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethods.ControlValueChanged
        If rdoCptMean.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptMeanFunction)
        ElseIf rdoCptVariance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptVarianceFunction)
        ElseIf rdoCptMeanVariance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptMeanVarianceFunction)
        ElseIf rdoSnht.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
        ElseIf rdoPettitt.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPettittFunction)
        ElseIf rdoBuishand.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsBuishandFunction)
        End If
        AddPlotSummaryParameters()
        ChangeSaveType()
    End Sub

    Private Sub AddPlotSummaryParameters()
        If rdoCptMean.Checked Then
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsCptMeanFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsCptMeanFunction, iPosition:=0)
        ElseIf rdoCptVariance.Checked Then
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsCptVarianceFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsCptVarianceFunction, iPosition:=0)
        ElseIf rdoCptMeanVariance.Checked Then
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsCptMeanVarianceFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsCptMeanVarianceFunction, iPosition:=0)
        ElseIf rdoSnht.Checked Then
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsSnhtFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsSnhtFunction, iPosition:=0)
        ElseIf rdoPettitt.Checked Then
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsPettittFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsPettittFunction, iPosition:=0)
        ElseIf rdoBuishand.Checked Then
            clsPlotFunction.AddParameter("x", clsRFunctionParameter:=clsBuishandFunction, iPosition:=0)
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsBuishandFunction, iPosition:=0)
        End If
    End Sub

    Private Sub ChangeSaveType()
        If rdoCptMean.Checked OrElse rdoCptVariance.Checked OrElse rdoCptMeanVariance.Checked OrElse rdoPettitt.Checked OrElse rdoBuishand.Checked Then
            ucrSaveResult.SetCheckBoxText("Save Result:")
            ucrSaveResult.SetSaveTypeAsModel()
            ucrSaveResult.SetIsComboBox()
            ucrSaveResult.SetPrefix("Result")
            ucrSaveResult.SetAssignToIfUncheckedValue("last_result")
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrSaveResult.SetLabelText("New Dataframe Name:")
            ucrSaveResult.SetSaveTypeAsDataFrame()
            ucrSaveResult.SetIsTextBox()
            ucrSaveResult.SetPrefix("Snht_dataframe")
            ucrBase.clsRsyntax.iCallType = 0
            clsSnhtFunction.SetAssignTo(strTemp:=ucrSelectorHomogenization.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempDataframe:=ucrSaveResult.GetText)
        End If
    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
            clsSummaryFunction.iCallType = 2
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPlot.ControlValueChanged
        If ucrChkPlot.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsPlotFunction, iPosition:=1)
            clsPlotFunction.iCallType = 3
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsPlotFunction)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSaveResult.ControlContentsChanged, ucrInputQ.ControlContentsChanged, ucrInputPenValue.ControlContentsChanged, ucrNudMinSegLen.ControlContentsChanged, ucrInputComboMethod.ControlContentsChanged, ucrInputComboPenalty.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class