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
    Private clsCptMeanFunction, clsCptVarianceFunction, clsCptMeanVarianceFunction, clsExcludeNAFunction, clsPlotFunction, clsSummaryFunction, clsSnhtFunction, clsPettittFunction, clsBuishandFunction, clsTapplyFunction, clsCompleteCasesFunction As New RFunction
    Private clsBracketsOperator, clsLeftBracketOperator, clsRightBracketOperator As New ROperator
    Private Sub dlgHomogenization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
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

    Private Sub InitialiseDialog()
        Dim dctPenaltyOptions As New Dictionary(Of String, String)
        Dim dctMethodOptions As New Dictionary(Of String, String)
        Dim dctMeanDistribution As New Dictionary(Of String, String)
        Dim dctVarDistribution As New Dictionary(Of String, String)
        Dim dctMeanVarDistribution As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrReceiverStation.SetParameter(New RParameter("station", 0))
        ucrReceiverStation.Selector = ucrSelectorHomogenization
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverElement.SetParameter(New RParameter("object", 0))
        ucrReceiverElement.Selector = ucrSelectorHomogenization
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.SetDataType("numeric", bStrict:=True)
        ucrReceiverElement.strSelectorHeading = "Numerics"

        ucrPnlMethods.AddRadioButton(rdoCptMean)
        ucrPnlMethods.AddRadioButton(rdoCptVariance)
        ucrPnlMethods.AddRadioButton(rdoCptMeanVariance)
        ucrPnlMethods.AddRadioButton(rdoSnht)
        ucrPnlMethods.AddRadioButton(rdoPettitt)
        ucrPnlMethods.AddRadioButton(rdoBuishand)
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptMean, "cpt.mean")
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptVariance, "cpt.var")
        ucrPnlMethods.AddFunctionNamesCondition(rdoCptMeanVariance, "cpt.meanvar")
        ucrPnlMethods.AddFunctionNamesCondition(rdoSnht, "snh.test")
        ucrPnlMethods.AddFunctionNamesCondition(rdoPettitt, "pettitt.test")
        ucrPnlMethods.AddFunctionNamesCondition(rdoBuishand, "br.test")
        ttOptions.SetToolTip(rdoSnht, "Performes the Standard Normal Homogeinity Test (SNHT) for change-point detection of a normal variate.")
        ttOptions.SetToolTip(rdoPettitt, "Performes a non-parametric test after Pettitt in order to test for a shift in the central tendency of a time series. The H0-hypothesis, no change, is tested against the HA-Hypothesis, change")
        ttOptions.SetToolTip(rdoBuishand, "Performes the Buishand range test for change-point detection of a normal variate.")

        ucrPnlOptions.AddRadioButton(rdoSingle)
        ucrPnlOptions.AddRadioButton(rdoNeighbouring)
        ucrPnlOptions.AddRadioButton(rdoMultiple)
        ucrPnlOptions.AddFunctionNamesCondition(rdoSingle, {"cpt.mean", "cpt.var", "cpt.meanvar", "snh.test", "pettitt.test", "br.test", "tapply"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoNeighbouring, {"cpt.mean", "cpt.var", "cpt.meanvar", "snh.test", "pettitt.test", "br.test", "tapply"}, False)
        ucrPnlOptions.AddFunctionNamesCondition(rdoMultiple, {"cpt.mean", "cpt.var", "cpt.meanvar", "snh.test", "pettitt.test", "br.test", "tapply"}, False)

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

        'ucrSaveResult.SetDataFrameSelector(ucrSelectorHomogenization.ucrAvailableDataFrames)
        ucrSaveResult.SetCheckBoxText("Save Test Object:")
        'ucrSaveResult.SetSaveTypeAsModel()
        'ucrSaveResult.SetIsComboBox()
        'ucrSaveResult.SetPrefix("Test")
        'ucrSaveResult.SetAssignToIfUncheckedValue("last_model")

        ucrInputComboPenalty.AddToLinkedControls(ucrInputPenValue, {"Asymptotic", "CROPS"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrInputComboMethod.AddToLinkedControls(ucrInputQ, {"SegNeigh", "BinSeg"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverNeighbour, {rdoNeighbouring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMeanDistribution, {rdoCptMean}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboVarDistribution, {rdoCptVariance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMeanVarDistribution, {rdoCptMeanVariance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboMethod, {rdoCptMean, rdoCptVariance, rdoCptMeanVariance}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboMethod.SetLinkedDisplayControl(grpCptOptions)
        ucrReceiverNeighbour.SetLinkedDisplayControl(lblNeighbouring)
        ucrInputPenValue.SetLinkedDisplayControl(lblPenaltyValue)
        ucrInputQ.SetLinkedDisplayControl(lblQ)

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
        clsCompleteCasesFunction = New RFunction

        clsBracketsOperator = New ROperator
        clsLeftBracketOperator = New ROperator
        clsRightBracketOperator = New ROperator

        ucrSelectorHomogenization.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        'ucrSaveResult.Reset()
        'TODO: Set conditions properly!
        rdoSnht.Checked = True

        clsCptMeanFunction.SetPackageName("changepoint")
        clsCptMeanFunction.SetRCommand("cpt.mean")
        clsCptMeanFunction.AddParameter("Q", 5, iPosition:=5)
        clsCptMeanFunction.AddParameter("pen.value", 0, iPosition:=6)
        clsCptMeanFunction.AddParameter("penalty", Chr(34) & "None" & Chr(34), iPosition:=1)
        clsCptMeanFunction.AddParameter("method", Chr(34) & "BinSeg" & Chr(34), iPosition:=2)

        clsCptVarianceFunction.SetPackageName("changepoint")
        clsCptVarianceFunction.SetRCommand("cpt.var")

        clsCptMeanVarianceFunction.SetPackageName("changepoint")
        clsCptMeanVarianceFunction.SetRCommand("cpt.meanvar")

        clsExcludeNAFunction.SetRCommand("na.exclude")

        clsPlotFunction.SetRCommand("plot")
        clsPlotFunction.iCallType = 3

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.iCallType = 2

        clsSnhtFunction.SetPackageName("trend")
        clsSnhtFunction.SetRCommand("snh.test")
        clsSnhtFunction.AddParameter("m", 5, iPosition:=1)

        clsPettittFunction.SetPackageName("trend")
        clsPettittFunction.SetRCommand("pettitt.test")

        clsBuishandFunction.SetPackageName("trend")
        clsBuishandFunction.SetRCommand("br.test")
        clsBuishandFunction.AddParameter("m", 5, iPosition:=1)

        clsTapplyFunction.SetRCommand("tapply")
        clsTapplyFunction.AddParameter("X", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
        clsTapplyFunction.AddParameter("INDEX", clsROperatorParameter:=clsRightBracketOperator, iPosition:=1)
        clsTapplyFunction.AddParameter("FUN", clsROperatorParameter:=clsBracketsOperator, iPosition:=2)

        clsBracketsOperator.SetOperation(") ")
        clsBracketsOperator.AddParameter("left", "function(X", iPosition:=0)
        clsBracketsOperator.bSpaceAroundOperation = False

        clsCompleteCasesFunction.SetRCommand("complete.cases")

        clsLeftBracketOperator.SetOperation("[")
        clsLeftBracketOperator.AddParameter("right", clsRFunctionParameter:=clsCompleteCasesFunction, iPosition:=1)
        clsLeftBracketOperator.bSpaceAroundOperation = False
        clsLeftBracketOperator.bBrackets = False

        clsRightBracketOperator.SetOperation("]")
        clsRightBracketOperator.AddParameter("left", clsROperatorParameter:=clsLeftBracketOperator, iPosition:=0)
        clsRightBracketOperator.AddParameter("right", "", iPosition:=1)
        clsRightBracketOperator.bSpaceAroundOperation = False
        clsRightBracketOperator.bBrackets = False

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
        AddPlotSummaryParameters()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsCompleteCasesFunction, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
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

        ucrReceiverStation.SetRCode(clsLeftBracketOperator, bReset)

        'ucrPnlMethods.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        'ucrSaveResult.AddAdditionalRCode(clsCptVarianceFunction, iAdditionalPairNo:=1)
        'ucrSaveResult.AddAdditionalRCode(clsCptMeanVarianceFunction, iAdditionalPairNo:=2)
        'ucrSaveResult.AddAdditionalRCode(clsPettittFunction, iAdditionalPairNo:=3)
        'ucrSaveResult.AddAdditionalRCode(clsSnhtFunction, iAdditionalPairNo:=4)
        'ucrSaveResult.AddAdditionalRCode(clsBuishandFunction, iAdditionalPairNo:=5)

        'ucrSaveResult.SetRCode(clsCptMeanFunction, bReset)

        ucrChkPlot.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrChkSummary.SetRSyntax(ucrBase.clsRsyntax, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverElement.IsEmpty OrElse Not ucrSaveResult.IsComplete OrElse (ucrInputComboMethod.GetText = "BinSeg" AndAlso ucrInputQ.IsEmpty) OrElse (ucrInputComboPenalty.GetText = "Asymptotic" AndAlso ucrInputPenValue.IsEmpty) OrElse ucrNudMinSegLen.GetText = "" Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrPnlMethods_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethods.ControlValueChanged
        AddPlotSummaryParameters()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrPnlMethods.ControlValueChanged
        If rdoCptMean.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptMeanFunction)
            clsCptMeanFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsCptMeanFunction, iPosition:=1)
        ElseIf rdoCptVariance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptVarianceFunction)
            clsCptVarianceFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsCptVarianceFunction, iPosition:=1)
        ElseIf rdoCptMeanVariance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCptMeanVarianceFunction)
            clsCptMeanVarianceFunction.AddParameter("data", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsCptMeanVarianceFunction, iPosition:=1)
        ElseIf rdoSnht.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSnhtFunction)
            clsSnhtFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsSnhtFunction, iPosition:=1)
        ElseIf rdoPettitt.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPettittFunction)
            clsPettittFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsPettittFunction, iPosition:=1)
        ElseIf rdoBuishand.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsBuishandFunction)
            clsBuishandFunction.AddParameter("x", clsRFunctionParameter:=clsExcludeNAFunction, iPosition:=0)
            clsBracketsOperator.AddParameter("right", clsRFunctionParameter:=clsBuishandFunction, iPosition:=1)
        End If
        If Not ucrReceiverStation.IsEmpty Then
            clsSnhtFunction.RemoveParameterByName("x")
            clsPettittFunction.RemoveParameterByName("x")
            clsBuishandFunction.RemoveParameterByName("x")
            clsCptMeanFunction.RemoveParameterByName("data")
            clsCptVarianceFunction.RemoveParameterByName("data")
            clsCptMeanVarianceFunction.RemoveParameterByName("data")
            clsCptMeanFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsCptVarianceFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsCptMeanVarianceFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsSnhtFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsPettittFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            clsBuishandFunction.AddParameter("X", "X", iPosition:=0, bIncludeArgumentName:=False)
            ucrBase.clsRsyntax.SetBaseRFunction(clsTapplyFunction)
        Else
            clsCptMeanFunction.RemoveParameterByName("X")
            clsCptVarianceFunction.RemoveParameterByName("X")
            clsCptMeanVarianceFunction.RemoveParameterByName("X")
            clsSnhtFunction.RemoveParameterByName("X")
            clsPettittFunction.RemoveParameterByName("X")
            clsBuishandFunction.RemoveParameterByName("X")
        End If
    End Sub

    Private Sub AddPlotSummaryParameters()
        clsPlotFunction.AddParameter("x", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction, iPosition:=0)
    End Sub

    Private Sub ucrChkSummary_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummary.ControlValueChanged
        If ucrChkSummary.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummaryFunction)
        End If
    End Sub

    Private Sub ucrChkPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPlot.ControlValueChanged
        If ucrChkPlot.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsPlotFunction, iPosition:=1)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsPlotFunction)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSaveResult.ControlContentsChanged, ucrInputQ.ControlContentsChanged, ucrInputPenValue.ControlContentsChanged, ucrNudMinSegLen.ControlContentsChanged, ucrInputComboMethod.ControlContentsChanged, ucrInputComboPenalty.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class