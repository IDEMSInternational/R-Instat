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

Public Class dlgTransform
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRankFunction As RFunction
    Private clsSortFunction As RFunction
    Private clsRoundFunction As RFunction
    Private clsSignifFunction As RFunction
    Private clsLagFunction As RFunction
    Private clsLeadFunction As RFunction
    Private clsDiffFunction As RFunction
    Private clsConcDiffFunction As RFunction
    Private clsReplicateFunction As RFunction
    Private clsMeanFunction As RFunction
    Private clsStandardDevFunction As RFunction
    Private clsSubtractOperator As ROperator
    Private clsDivisionOperator As ROperator
    Private clsSquarerootFunction As RFunction
    Private clsAddConstantOperator As ROperator
    Private clsNaturalLogFunction As RFunction
    Private clsLogBase10Function As RFunction
    Private clsPowerOperator As ROperator
    Private clsScaleSubtractOperator As ROperator
    Private clsScaleMultiplyOperator As ROperator
    Private clsScaleDivideOperator As ROperator
    Private clsScaleAddOperator As ROperator
    Private clsScaleMeanFunction As RFunction
    Private clsScaleMinFunction As RFunction
    Private clsPreviewOperator As ROperator
    Private clsDummyTransformFunction As RFunction
    Private clsConstantDummyFunction As New RFunction
    Private clsNumericDummyFunction As RFunction
    Private clsNonNegativeDummyFunction As RFunction
    Private clsPreviewTextFunction As New RCodeStructure
    Private bResetRCode As Boolean = True

    Private Sub dlgRank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 25

        Dim dctSubtractValues As New Dictionary(Of String, String)
        Dim dctMultiplyValues As New Dictionary(Of String, String)
        Dim dctDivideValues As New Dictionary(Of String, String)
        Dim dctAddValues As New Dictionary(Of String, String)
        Dim dctPowerValues As New Dictionary(Of String, String)

        ucrPnlTransformOptions.AddRadioButton(rdoRank)
        ucrPnlTransformOptions.AddRadioButton(rdoNumeric)
        ucrPnlTransformOptions.AddRadioButton(rdoSort)
        ucrPnlTransformOptions.AddRadioButton(rdoNonNegative)
        ucrPnlTransformOptions.AddRadioButton(rdoScale)

        ucrPnlTransformOptions.AddParameterValuesCondition(rdoRank, "check", "rank")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoNumeric, "check", "numeric")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoSort, "check", "sort")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoNonNegative, "check", "non-negative")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoScale, "check", "scale")

        ucrReceiverRank.SetParameter(New RParameter("x", 0))
        ucrReceiverRank.Selector = ucrSelectorForRank
        ucrReceiverRank.SetMeAsReceiver()
        ucrReceiverRank.bUseFilteredData = False
        ucrReceiverRank.SetParameterIsRFunction()
        ucrReceiverRank.SetDataType("numeric")
        ucrReceiverRank.strSelectorHeading = "Numerics"

        ucrPnlMissingValues.SetParameter(New RParameter("na.last", 2))
        ucrPnlMissingValues.AddRadioButton(rdoKeptAsMissing, Chr(34) & "keep" & Chr(34))
        ucrPnlMissingValues.AddRadioButton(rdoFirstMissingValues, "FALSE")
        ucrPnlMissingValues.AddRadioButton(rdoLast, "TRUE")
        ucrPnlMissingValues.SetRDefault("TRUE")

        ucrPnlMissingValues.AddParameterValuesCondition(rdoKeptAsMissing, "na.last", Chr(34) & "keep" & Chr(34))
        ucrPnlMissingValues.AddParameterValuesCondition(rdoFirstMissingValues, "na.last", "FALSE")
        ucrPnlMissingValues.AddParameterValuesCondition(rdoLast, "na.last", "TRUE")

        ucrPnlTies.SetParameter(New RParameter("ties.method", 3))
        ucrPnlTies.AddRadioButton(rdoAverage, Chr(34) & "average" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoMinimum, Chr(34) & "min" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoMaximum, Chr(34) & "max" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoFirst, Chr(34) & "first" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoRandom, Chr(34) & "random" & Chr(34))
        ucrPnlTies.SetRDefault(Chr(34) & "average" & Chr(34))

        ucrPnlTies.AddParameterValuesCondition(rdoAverage, "ties.method", Chr(34) & "average" & Chr(34))
        ucrPnlTies.AddParameterValuesCondition(rdoMinimum, "ties.method", Chr(34) & "min" & Chr(34))
        ucrPnlTies.AddParameterValuesCondition(rdoMaximum, "ties.method", Chr(34) & "max" & Chr(34))
        ucrPnlTies.AddParameterValuesCondition(rdoFirst, "ties.method", Chr(34) & "first" & Chr(34))
        ucrPnlTies.AddParameterValuesCondition(rdoRandom, "ties.method", Chr(34) & "random" & Chr(34))

        ucrPnlNumericOptions.AddRadioButton(rdoRoundOf)
        ucrPnlNumericOptions.AddRadioButton(rdoSignificantDigits)
        ucrPnlNumericOptions.AddRadioButton(rdoStandardize)
        ucrPnlNumericOptions.AddRadioButton(rdoLag)
        ucrPnlNumericOptions.AddRadioButton(rdoLead)
        ucrPnlNumericOptions.AddRadioButton(rdoDifference)

        ucrPnlNumericOptions.AddParameterValuesCondition(rdoRoundOf, "check", "round")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoSignificantDigits, "check", "signif")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoStandardize, "check", "standardise")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoLag, "check", "lag")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoLead, "check", "lead")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoDifference, "check", "diff")

        ucrPnlNonNegative.AddRadioButton(rdoSquareRoot)
        ucrPnlNonNegative.AddRadioButton(rdoLogToBase10)
        ucrPnlNonNegative.AddRadioButton(rdoNaturalLog)
        ucrPnlNonNegative.AddRadioButton(rdoPower)

        ucrPnlNonNegative.AddParameterValuesCondition(rdoSquareRoot, "check", "sqrt")
        ucrPnlNonNegative.AddParameterValuesCondition(rdoLogToBase10, "check", "log10")
        ucrPnlNonNegative.AddParameterValuesCondition(rdoNaturalLog, "check", "log")
        ucrPnlNonNegative.AddParameterValuesCondition(rdoPower, "check", "power")

        ucrPnlNumericOptions.AddToLinkedControls(ucrNudSignifDigits, {rdoSignificantDigits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudRoundOfDigits, {rdoRoundOf}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudLagLeadPosition, {rdoLead}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudDiffLag, {rdoDifference}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudLagPosition, {rdoLag}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrChkOmitNA, {rdoStandardize}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNonNegative.AddToLinkedControls(ucrInputPower, {rdoPower}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrPnlMissingValues, {rdoRank}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrPnlTies, {rdoRank}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrChkDecreasing, {rdoSort}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrChkMissingLast, {rdoSort}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrPnlNumericOptions, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls({ucrPnlNonNegative, ucrChkAddConstant}, {rdoNonNegative}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls({ucrChkSubtract, ucrChkMultiply, ucrChkDivide, ucrChkAdd}, {rdoScale}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddConstant.AddToLinkedControls(ucrInputConstant, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0")
        ucrChkSubtract.AddToLinkedControls(ucrInputSubtract, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0")
        ucrChkMultiply.AddToLinkedControls(ucrInputMultiply, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="1")
        ucrChkDivide.AddToLinkedControls(ucrInputDivide, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="1")
        ucrChkAdd.AddToLinkedControls(ucrInputAdd, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0")
        ucrChkPreview.AddToLinkedControls({ucrInputPreview, ucrChkEditPreview}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudSignifDigits.SetLinkedDisplayControl(lblDigits)
        ucrNudRoundOfDigits.SetLinkedDisplayControl(lblRoundofDigits)
        ucrNudLagLeadPosition.SetLinkedDisplayControl(lblLagLeadPosition)
        ucrNudDiffLag.SetLinkedDisplayControl(lblDiffLag)
        ucrPnlNumericOptions.SetLinkedDisplayControl(grpNumericOptions)
        ucrNudLagPosition.SetLinkedDisplayControl(lblLagPosition)
        ucrReceiverRank.SetLinkedDisplayControl(lblSelectColumns)
        ucrPnlMissingValues.SetLinkedDisplayControl(grpMissingValues)
        ucrPnlTies.SetLinkedDisplayControl(grpTies)
        ucrPnlNonNegative.SetLinkedDisplayControl(grpNonNegative)
        ucrInputPreview.SetLinkedDisplayControl(cmdUpdatePreview)

        ucrNudSignifDigits.SetParameter(New RParameter("digits", 1))
        ucrNudSignifDigits.SetMinMax(iNewMin:=0, iNewMax:=22)
        ucrNudSignifDigits.SetRDefault(6)

        ucrNudRoundOfDigits.SetParameter(New RParameter("digits", 1))
        ucrNudRoundOfDigits.SetMinMax(iNewMin:=Integer.MinValue, iNewMax:=Integer.MaxValue)
        ucrNudRoundOfDigits.SetRDefault(0)

        ucrNudLagLeadPosition.SetParameter(New RParameter("n", 1))
        ucrNudLagLeadPosition.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)
        ucrNudLagLeadPosition.SetRDefault(1)

        ucrNudDiffLag.SetParameter(New RParameter("lag", 1))
        ucrNudDiffLag.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)
        ucrNudDiffLag.SetRDefault(1)

        ucrNudLagPosition.SetParameter(New RParameter("lag", 1))
        ucrNudLagPosition.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)

        ucrInputPower.SetParameter(New RParameter("y", 1))
        dctPowerValues.Add("1", "1")
        dctPowerValues.Add("2", "2")
        dctPowerValues.Add("0", "0")
        dctPowerValues.Add("-5", "-5")
        dctPowerValues.Add("0.5", "0.5")
        ucrInputPower.SetItems(dctPowerValues)
        ucrInputPower.AddQuotesIfUnrecognised = False
        ucrInputPower.bAllowNonConditionValues = True

        ucrInputConstant.SetParameter(New RParameter("c", 1))
        ucrInputConstant.SetItems(dctPowerValues)
        ucrInputConstant.AddQuotesIfUnrecognised = False

        ucrChkAddConstant.SetText("Add Constant")
        ucrChkAddConstant.AddParameterValuesCondition(True, "checked", "TRUE")
        ucrChkAddConstant.AddParameterValuesCondition(False, "checked", "FALSE")

        ucrSaveNew.SetSaveTypeAsColumn()
        ucrSaveNew.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrSaveNew.SetLabelText("New Column Name:")
        ucrSaveNew.SetIsComboBox()
        ucrSaveNew.setLinkedReceiver(ucrReceiverRank)

        ucrChkDecreasing.SetText("Decreasing")
        ucrChkDecreasing.SetParameter(New RParameter("decreasing", 2))
        ucrChkDecreasing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDecreasing.SetRDefault("FALSE")

        ucrChkMissingLast.SetText("Missing Last")
        ucrChkMissingLast.SetParameter(New RParameter("na.last"))
        ucrChkMissingLast.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMissingLast.SetRDefault("FALSE")

        ucrInputSubtract.SetParameter(New RParameter("u", 1))
        dctSubtractValues.Add("0", "0")
        dctSubtractValues.Add("32", "32")
        dctSubtractValues.Add("1970", "1970")
        ucrInputSubtract.SetItems(dctSubtractValues)
        ucrInputSubtract.AddQuotesIfUnrecognised = False

        ucrChkSubtract.SetText("Subtract")

        ucrInputMultiply.SetParameter(New RParameter("y", 1))
        dctMultiplyValues.Add("1", "1")
        dctMultiplyValues.Add("0.6214", "0.6214")
        dctMultiplyValues.Add("5", "5")
        dctMultiplyValues.Add("9", "9")
        dctMultiplyValues.Add("24", "24")
        dctMultiplyValues.Add("25.4", "25.4")
        dctMultiplyValues.Add("1440", "1440")
        ucrInputMultiply.SetItems(dctMultiplyValues)
        ucrInputMultiply.AddQuotesIfUnrecognised = False

        ucrChkMultiply.SetText("Multiply")

        ucrInputDivide.SetParameter(New RParameter("z", 1))
        dctDivideValues.Add("1", "1")
        dctDivideValues.Add("5", "5")
        dctDivideValues.Add("9", "9")
        dctDivideValues.Add("25.4", "25.4")
        dctDivideValues.Add("365.25", "365.25")
        dctDivideValues.Add("1440", "1440")
        ucrInputDivide.SetItems(dctDivideValues)
        ucrInputDivide.AddQuotesIfUnrecognised = False

        ucrChkDivide.SetText("Divide")

        ucrInputAdd.SetParameter(New RParameter("v", 1))
        dctAddValues.Add("0", "0")
        dctAddValues.Add("32", "32")
        dctAddValues.Add("273.15", "273.15")
        ucrInputAdd.SetItems(dctAddValues)
        ucrInputAdd.AddQuotesIfUnrecognised = False

        ucrChkAdd.SetText("Add")

        ucrChkPreview.SetText("Preview")
        ucrChkPreview.AddParameterValuesCondition(True, "preview", "FALSE")
        ucrChkPreview.AddParameterValuesCondition(False, "preview", "TRUE")


        ucrChkOmitNA.SetText("Omit NA")
        ucrChkOmitNA.SetParameter(New RParameter("na.rm", 1))
        ucrChkOmitNA.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkEditPreview.SetText("Edit")

        ttEditPreview.SetToolTip(ucrChkEditPreview.chkCheck, "Use(Slightly) at your peril.")
    End Sub

    Private Sub SetDefaults()
        clsRankFunction = New RFunction
        clsSortFunction = New RFunction
        clsRoundFunction = New RFunction
        clsSignifFunction = New RFunction
        clsLagFunction = New RFunction
        clsLeadFunction = New RFunction
        clsDiffFunction = New RFunction
        clsConcDiffFunction = New RFunction
        clsReplicateFunction = New RFunction
        clsMeanFunction = New RFunction
        clsStandardDevFunction = New RFunction
        clsSubtractOperator = New ROperator
        clsDivisionOperator = New ROperator
        clsSquarerootFunction = New RFunction
        clsAddConstantOperator = New ROperator
        clsNaturalLogFunction = New RFunction
        clsLogBase10Function = New RFunction
        clsPowerOperator = New ROperator
        clsScaleAddOperator = New ROperator
        clsScaleDivideOperator = New ROperator
        clsScaleMultiplyOperator = New ROperator
        clsScaleSubtractOperator = New ROperator
        clsPreviewOperator = New ROperator
        clsScaleMeanFunction = New RFunction
        clsScaleMinFunction = New RFunction
        clsDummyTransformFunction = New RFunction
        clsConstantDummyFunction = New RFunction
        clsNumericDummyFunction = New RFunction
        clsNonNegativeDummyFunction = New RFunction
        clsPreviewTextFunction = New RCodeStructure

        ucrSelectorForRank.Reset()
        ucrReceiverRank.SetMeAsReceiver()
        ucrSaveNew.Reset()

        clsConstantDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
        clsConstantDummyFunction.AddParameter("preview", "TRUE", iPosition:=1)

        clsRankFunction.SetRCommand("rank")
        clsRankFunction.AddParameter("na.last", Chr(34) & "keep" & Chr(34), iPosition:=2)
        clsRankFunction.AddParameter("ties.method", Chr(34) & "average" & Chr(34), iPosition:=3)

        clsSortFunction.SetRCommand("sort")
        clsSortFunction.AddParameter("decreasing", "TRUE", iPosition:=1)
        clsSortFunction.AddParameter("na.last", "TRUE", iPosition:=2)

        clsRoundFunction.SetRCommand("round")

        clsSignifFunction.SetRCommand("signif")

        clsLagFunction.SetPackageName("dplyr")
        clsLagFunction.SetRCommand("lag")

        clsLeadFunction.SetPackageName("dplyr")
        clsLeadFunction.SetRCommand("lead")

        clsDiffFunction.SetRCommand("diff")
        clsDiffFunction.AddParameter("lag", "1", iPosition:=1)

        clsReplicateFunction.SetRCommand("rep")
        clsReplicateFunction.AddParameter("x", "NA", iPosition:=0)

        clsConcDiffFunction.SetRCommand("c")
        clsConcDiffFunction.AddParameter("y", clsRFunctionParameter:=clsReplicateFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsConcDiffFunction.AddParameter("x", clsRFunctionParameter:=clsDiffFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsStandardDevFunction.SetRCommand("sd")
        clsStandardDevFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsSubtractOperator.SetOperation("-")
        clsSubtractOperator.AddParameter("y", clsRFunctionParameter:=clsMeanFunction, iPosition:=1)

        clsDivisionOperator.SetOperation("/")
        clsDivisionOperator.AddParameter("x", clsROperatorParameter:=clsSubtractOperator, iPosition:=0)
        clsDivisionOperator.AddParameter("y", clsRFunctionParameter:=clsStandardDevFunction, iPosition:=1)

        clsSquarerootFunction.SetRCommand("sqrt")

        clsAddConstantOperator.SetOperation("+")
        clsAddConstantOperator.AddParameter("c", "0", iPosition:=1)

        clsNaturalLogFunction.SetRCommand("log")

        clsLogBase10Function.SetRCommand("log10")

        clsPowerOperator.SetOperation("^")
        clsPowerOperator.AddParameter("y", "1", iPosition:=1)
        clsPowerOperator.bSpaceAroundOperation = False

        clsScaleMeanFunction.SetRCommand("mean")
        clsScaleMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsScaleMinFunction.SetRCommand("min")
        clsScaleMinFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsScaleSubtractOperator.SetOperation("-")
        clsScaleSubtractOperator.AddParameter("u", "0", iPosition:=1)

        clsScaleMultiplyOperator.SetOperation("*")
        clsScaleMultiplyOperator.AddParameter("x", clsROperatorParameter:=clsScaleSubtractOperator, iPosition:=0)
        clsScaleMultiplyOperator.AddParameter("y", "1", iPosition:=1)

        clsScaleDivideOperator.SetOperation("/")
        clsScaleDivideOperator.AddParameter("x", clsROperatorParameter:=clsScaleMultiplyOperator, iPosition:=0)
        clsScaleDivideOperator.AddParameter("z", "1", iPosition:=1)
        clsScaleDivideOperator.bBrackets = False

        clsScaleAddOperator.SetOperation("+")
        clsScaleAddOperator.AddParameter("x", clsROperatorParameter:=clsScaleDivideOperator, iPosition:=0)
        clsScaleAddOperator.AddParameter("v", "0", iPosition:=1)
        clsScaleAddOperator.bBrackets = False

        clsPreviewOperator.bBrackets = False
        clsPreviewOperator.bToScriptAsRString = False

        clsDummyTransformFunction.AddParameter("check", "numeric", iPosition:=0)
        clsNumericDummyFunction.AddParameter("check", "round", iPosition:=0)
        clsNonNegativeDummyFunction.AddParameter("check", "sqrt", iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsRoundFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bResetRCode = False
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSortFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsRoundFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSignifFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=3)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLagFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=4)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLeadFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=5)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsDiffFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=6)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=7)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSubtractOperator, New RParameter("x", 0), iAdditionalPairNo:=8)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsStandardDevFunction, New RParameter("x", 0), iAdditionalPairNo:=9)
        ucrNudDiffLag.AddAdditionalCodeParameterPair(clsReplicateFunction, New RParameter("times", 1), iAdditionalPairNo:=1)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsAddConstantOperator, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=10)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleSubtractOperator, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=12)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleMinFunction, New RParameter("x", 0), iAdditionalPairNo:=13)
        ucrChkOmitNA.AddAdditionalCodeParameterPair(clsStandardDevFunction, ucrChkOmitNA.GetParameter(), iAdditionalPairNo:=1)

        ucrSaveNew.AddAdditionalRCode(clsLeadFunction, iAdditionalPairNo:=1)
        ucrSaveNew.AddAdditionalRCode(clsLagFunction, iAdditionalPairNo:=2)
        ucrSaveNew.AddAdditionalRCode(clsSignifFunction, iAdditionalPairNo:=3)
        ucrSaveNew.AddAdditionalRCode(clsConcDiffFunction, iAdditionalPairNo:=4)
        ucrSaveNew.AddAdditionalRCode(clsRankFunction, iAdditionalPairNo:=5)
        ucrSaveNew.AddAdditionalRCode(clsSortFunction, iAdditionalPairNo:=6)
        ucrSaveNew.AddAdditionalRCode(clsDivisionOperator, iAdditionalPairNo:=7)
        ucrSaveNew.AddAdditionalRCode(clsSquarerootFunction, iAdditionalPairNo:=8)
        ucrSaveNew.AddAdditionalRCode(clsLogBase10Function, iAdditionalPairNo:=9)
        ucrSaveNew.AddAdditionalRCode(clsNaturalLogFunction, iAdditionalPairNo:=10)
        ucrSaveNew.AddAdditionalRCode(clsPowerOperator, iAdditionalPairNo:=11)
        ucrSaveNew.AddAdditionalRCode(clsScaleAddOperator, iAdditionalPairNo:=12)
        ucrSaveNew.AddAdditionalRCode(clsPreviewOperator, iAdditionalPairNo:=13)

        ucrPnlTransformOptions.SetRCode(clsDummyTransformFunction, bReset)
        ucrReceiverRank.SetRCode(clsRankFunction, bReset)
        ucrChkDecreasing.SetRCode(clsSortFunction, bReset)
        ucrChkMissingLast.SetRCode(clsSortFunction, bReset)
        ucrSaveNew.SetRCode(clsRoundFunction, bReset)
        ucrPnlTies.SetRCode(clsRankFunction, bReset)
        ucrPnlMissingValues.SetRCode(clsRankFunction, bReset)
        ucrNudRoundOfDigits.SetRCode(clsRoundFunction, bReset)
        ucrNudSignifDigits.SetRCode(clsSignifFunction, bReset)
        ucrNudLagLeadPosition.SetRCode(clsLeadFunction, bReset)
        ucrNudDiffLag.SetRCode(clsDiffFunction, bReset)
        ucrNudLagPosition.SetRCode(clsLagFunction, bReset)
        ucrInputPower.SetRCode(clsPowerOperator, bReset)
        ucrInputConstant.SetRCode(clsAddConstantOperator, bReset)
        ucrInputSubtract.SetRCode(clsScaleSubtractOperator, bReset)
        ucrInputAdd.SetRCode(clsScaleAddOperator, bReset)
        ucrInputDivide.SetRCode(clsScaleDivideOperator, bReset)
        ucrInputMultiply.SetRCode(clsScaleMultiplyOperator, bReset)
        ucrChkAddConstant.SetRCode(clsConstantDummyFunction, bReset)
        ucrPnlNumericOptions.SetRCode(clsNumericDummyFunction, bReset)
        ucrPnlNonNegative.SetRCode(clsNonNegativeDummyFunction, bReset)
        ucrChkOmitNA.SetRCode(clsMeanFunction, bReset)
        ucrChkPreview.SetRCode(clsConstantDummyFunction, bReset)
        bResetRCode = True
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverRank.IsEmpty() AndAlso ucrSaveNew.IsComplete)
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrSaveNew.bUserTyped) AndAlso Not ucrReceiverRank.IsEmpty Then
            ucrSaveNew.SetPrefix(ucrReceiverRank.GetVariableNames(bWithQuotes:=False))
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
        ucrChkEditPreview.Checked = False
    End Sub

    Private Sub ucrPnlTransformOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransformOptions.ControlValueChanged, ucrPnlNumericOptions.ControlValueChanged,
        ucrPnlNonNegative.ControlValueChanged, ucrReceiverRank.ControlValueChanged, ucrNudRoundOfDigits.ControlValueChanged, ucrNudSignifDigits.ControlValueChanged, ucrNudLagPosition.ControlValueChanged,
        ucrNudLagLeadPosition.ControlValueChanged, ucrNudDiffLag.ControlValueChanged, ucrPnlMissingValues.ControlValueChanged, ucrChkDecreasing.ControlValueChanged, ucrChkMissingLast.ControlValueChanged,
        ucrChkAddConstant.ControlValueChanged, ucrChkMissingLast.ControlValueChanged, ucrPnlTies.ControlValueChanged, ucrInputPower.ControlValueChanged, ucrInputConstant.ControlValueChanged,
        ucrInputAdd.ControlValueChanged, ucrInputDivide.ControlValueChanged, ucrInputMultiply.ControlValueChanged, ucrInputSubtract.ControlValueChanged, ucrChkAdd.ControlValueChanged,
        ucrChkMultiply.ControlValueChanged, ucrChkSubtract.ControlValueChanged, ucrChkDivide.ControlValueChanged, ucrChkOmitNA.ControlValueChanged, ucrChkPreview.ControlValueChanged
        ucrBase.clsRsyntax.ClearCodes()
        If rdoRank.Checked Then
            clsPreviewTextFunction = clsRankFunction.Clone
            clsDummyTransformFunction.AddParameter("check", "rank", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsRankFunction)
        ElseIf rdoSort.Checked Then
            clsPreviewTextFunction = clsSortFunction.Clone
            clsDummyTransformFunction.AddParameter("check", "sort", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsSortFunction)
        ElseIf rdoNumeric.Checked Then
            clsDummyTransformFunction.AddParameter("check", "numeric", iPosition:=0)
            If rdoRoundOf.Checked Then
                clsPreviewTextFunction = clsRoundFunction.Clone
                clsNumericDummyFunction.AddParameter("check", "round", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsRoundFunction)
            ElseIf rdoSignificantDigits.Checked Then
                clsPreviewTextFunction = clsSignifFunction.Clone
                clsNumericDummyFunction.AddParameter("check", "signif", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsSignifFunction)
            ElseIf rdoLag.Checked Then
                clsPreviewTextFunction = clsLagFunction.Clone
                clsNumericDummyFunction.AddParameter("check", "lag", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsLagFunction)
            ElseIf rdoLead.Checked Then
                clsPreviewTextFunction = clsLeadFunction.Clone
                clsNumericDummyFunction.AddParameter("check", "lead", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsLeadFunction)
            ElseIf rdoDifference.Checked Then
                clsPreviewTextFunction = clsConcDiffFunction.Clone
                clsNumericDummyFunction.AddParameter("check", "diff", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsConcDiffFunction)
            ElseIf rdoStandardize.Checked Then
                clsPreviewTextFunction = clsDivisionOperator.Clone
                clsNumericDummyFunction.AddParameter("check", "standardise", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseROperator(clsDivisionOperator)
            End If
        ElseIf rdoNonNegative.Checked Then
            UpdateConstantParameter()
            clsDummyTransformFunction.AddParameter("check", "non-negative", iPosition:=0)
            If rdoSquareRoot.Checked Then
                clsPreviewTextFunction = clsSquarerootFunction.Clone
                ucrBase.clsRsyntax.SetBaseRFunction(clsSquarerootFunction)
                clsNonNegativeDummyFunction.AddParameter("check", "sqrt", iPosition:=0)
            ElseIf rdoPower.Checked Then
                clsPreviewTextFunction = clsPowerOperator.Clone
                clsNonNegativeDummyFunction.AddParameter("check", "power", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseROperator(clsPowerOperator)
            ElseIf rdoLogToBase10.Checked Then
                clsPreviewTextFunction = clsLogBase10Function.Clone
                clsNonNegativeDummyFunction.AddParameter("check", "log10", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsLogBase10Function)
            ElseIf rdoNaturalLog.Checked Then
                clsPreviewTextFunction = clsNaturalLogFunction.Clone
                clsNonNegativeDummyFunction.AddParameter("check", "log", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsNaturalLogFunction)
            End If
        ElseIf rdoScale.Checked Then
            clsDummyTransformFunction.AddParameter("check", "scale", iPosition:=0)
            clsPreviewTextFunction = clsScaleAddOperator.Clone
            ucrBase.clsRsyntax.SetBaseROperator(clsScaleAddOperator)
        End If
        clsPreviewTextFunction.RemoveAssignTo()
        If Not ucrReceiverRank.IsEmpty Then
            ucrInputPreview.SetText(clsPreviewTextFunction.ToScript)
        Else
            ucrInputPreview.SetText("")
        End If
        NewDefaultName()
        ResetPreview()
    End Sub

    Private Sub ucrReceiverRank_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRank.ControlValueChanged
        If Not ucrReceiverRank.IsEmpty Then
            clsSquarerootFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverRank.GetVariables, iPosition:=0)
            clsNaturalLogFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverRank.GetVariables, iPosition:=0)
            clsLogBase10Function.AddParameter("x", clsRFunctionParameter:=ucrReceiverRank.GetVariables, iPosition:=0)
            clsPowerOperator.AddParameter("x", clsRFunctionParameter:=ucrReceiverRank.GetVariables, iPosition:=0)
        Else
            clsSquarerootFunction.RemoveParameterByName("x")
            clsNaturalLogFunction.RemoveParameterByName("x")
            clsLogBase10Function.RemoveParameterByName("x")
            clsPowerOperator.RemoveParameterByName("x")
        End If
    End Sub

    Private Sub UpdateConstantParameter()
        If ucrChkAddConstant.Checked Then
            clsSquarerootFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
            clsPowerOperator.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
            clsLogBase10Function.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
            clsNaturalLogFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
        End If
        If bResetRCode Then
            If ucrChkAddConstant.Checked Then
                clsConstantDummyFunction.AddParameter("checked", "TRUE", iPosition:=0)
            Else
                clsConstantDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
            End If
        End If
    End Sub

    Private Sub ucrChkAddConstant_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddConstant.ControlValueChanged, ucrPnlNonNegative.ControlValueChanged, ucrInputConstant.ControlValueChanged, ucrInputPreview.ControlValueChanged
        UpdateConstantParameter()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRank.ControlContentsChanged, ucrSaveNew.ControlContentsChanged, ucrPnlTransformOptions.ControlContentsChanged, ucrPnlNumericOptions.ControlContentsChanged, ucrPnlNonNegative.ControlContentsChanged, ucrChkDivide.ControlContentsChanged,
    ucrChkMultiply.ControlContentsChanged, ucrChkSubtract.ControlContentsChanged, ucrChkAdd.ControlContentsChanged, ucrChkPreview.ControlContentsChanged, ucrChkAddConstant.ControlContentsChanged, ucrInputPower.ControlContentsChanged, ucrInputPreview.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ResetPreview()
        If Not bResetRCode Then
            Exit Sub
        End If
        If ucrChkPreview.Checked Then
            clsConstantDummyFunction.AddParameter("preview", "FALSE", iPosition:=1)
            ucrInputPreview.IsReadOnly = Not ucrChkEditPreview.Checked
        Else
            clsConstantDummyFunction.AddParameter("preview", "TRUE", iPosition:=1)
        End If
    End Sub

    Private Sub ucrChkEditPreview_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkEditPreview.ControlValueChanged
        ResetPreview()
    End Sub

    Private Sub ucrInputPreview_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputPreview.ControlValueChanged
        Dim clsGetVariablesFunc As RFunction = ucrReceiverRank.GetVariables
        If ucrChkEditPreview.Checked Then
            clsPreviewOperator.AddParameter("left", ucrInputPreview.GetValue, iPosition:=0)
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetVariablesFunc, 0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsPreviewOperator, 1)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetVariablesFunc)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsPreviewOperator)
        End If
    End Sub
End Class
