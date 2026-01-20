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
    Private clsRankFunction As New RFunction
    Private clsSortFunction As New RFunction
    Private clsRoundFunction As New RFunction
    Private clsSignifFunction As New RFunction
    Private clsLagFunction As New RFunction
    Private clsLeadFunction As New RFunction
    Private clsDiffFunction As New RFunction
    Private clsConcDiffFunction As New RFunction
    Private clsReplicateFunction As New RFunction
    Private clsMeanFunction As New RFunction
    Private clsStandardDevFunction As New RFunction
    Private clsSubtractOperator As New ROperator
    Private clsDivisionOperator As New ROperator
    Private clsDescToolsFormatFunction As New RFunction

    Private clsDivisionColsOperator As New ROperator
    Private clsSquarerootFunction As New RFunction
    Private clsSubtractColsOperator As New ROperator
    Private clsSquarerootColsFunction As New RFunction
    Private clsAddConstantOperator As New ROperator
    Private clsAddConstantColsOperator As New ROperator
    Private clsNaturalLogFunction As New RFunction
    Private clsNaturalLogColsFunction As New RFunction
    Private clsLagColsFunction As New RFunction
    Private clsRankColsFunction As New RFunction
    Private clsLogBase10Function As New RFunction
    Private clsLogBase10ColsFunction As New RFunction
    Private clsStandardDevColsFunction As New RFunction
    Private clsSymbolOperator As New ROperator
    Private clsSymbolOperator2 As New ROperator
    Private clsMeanColsFunction As New RFunction
    Private clsReplicateColsFunction As New RFunction
    Private clsConcDiffColsFunction As New RFunction
    Private clsDiffColsFunction As New RFunction
    Private clsLeadColsFunction As New RFunction
    Private clsSignifColsFunction As New RFunction
    Private clsRoundColsFunction As New RFunction
    Private clsSortColsFunction As New RFunction
    Private clsPowerColsOperator As New ROperator
    Private clsScaleSubtractColsOperator As New ROperator
    Private clsScaleAddColsOperator As New ROperator
    Private clsScaleMeanColsFunction As New RFunction
    Private clsScaleMinColsFunction As New RFunction

    Private clsRemoveLabelsFunction As New RFunction
    Private clsPowerOperator As New ROperator
    Private clsScaleSubtractOperator As New ROperator
    Private clsScaleMultiplyOperator As New ROperator
    Private clsScaleMultiplyColsOperator As New ROperator
    Private clsScaleDivideOperator As New ROperator
    Private clsScaleDivideColsOperator As New ROperator
    Private clsScaleAddOperator As New ROperator
    Private clsScaleMeanFunction As New RFunction
    Private clsScaleMinFunction As New RFunction

    Private clsPreviewOperator As New ROperator
    Private clsDummyTransformFunction As New RFunction
    Private clsConstantDummyFunction As New RFunction
    Private clsNumericDummyFunction As New RFunction
    Private clsNonNegativeDummyFunction As New RFunction
    Private clsGetColSelectionNamesFunction As New RFunction
    Private clsPreviewTextFunction As New RCodeStructure
    Private clsBooleanOperator As New ROperator
    Private clsBooleanColsOperator As New ROperator
    Private clsAddColumnsFunction As New RFunction
    Private clsIsNAFunction As New RFunction
    Private clsIsNAColsFunction As New RFunction
    Private clsFormatFunction As New RFunction
    Private clsBaseFunction As New RFunction
    Private clsGetDataFrameFunction As New RFunction
    Private clsColumnsFunction As New RFunction
    Private clsPasteFunction As New RFunction
    Private clsMutateFunction As New RFunction
    Private clsAcrossFunction As New RFunction
    Private clsEverythingFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsTildaOperator As New ROperator
    Private clsAssignOperator As New ROperator
    Private bResetRCode As Boolean = True

    Private ReadOnly strDot As String = "."
    Private ReadOnly strE As String = "e"
    Private ReadOnly strLeft As String = "l"
    Private ReadOnly strCentre As String = "c"
    Private ReadOnly strRight As String = "r"
    Private ReadOnly strNa As String = "NA"
    Private ReadOnly strHyphen As String = "-"
    Private ReadOnly strMissing As String = "Missing"
    Private ReadOnly strZero As String = "0"
    Private ReadOnly strDott As String = "dot"
    Private ReadOnly strStar As String = "*"
    Private ReadOnly strP As String = "P*"
    Private ReadOnly strPvalue As String = "p"
    Private ReadOnly strPercent As String = "%"

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

        Dim dctSubtractValues As New Dictionary(Of String, String)
        Dim dctMultiplyValues As New Dictionary(Of String, String)
        Dim dctDivideValues As New Dictionary(Of String, String)
        Dim dctAddValues As New Dictionary(Of String, String)
        Dim dctPowerValues As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 42

        ucrPnlTransformOptions.AddRadioButton(rdoRank)
        ucrPnlTransformOptions.AddRadioButton(rdoNumeric)
        ucrPnlTransformOptions.AddRadioButton(rdoSort)
        ucrPnlTransformOptions.AddRadioButton(rdoNonNegative)
        ucrPnlTransformOptions.AddRadioButton(rdoScale)
        ucrPnlTransformOptions.AddRadioButton(rdoFormat)

        ucrPnlColumnSelectOptions.AddRadioButton(rdoSingle)
        ucrPnlColumnSelectOptions.AddRadioButton(rdoMultiple)

        ucrPnlTransformOptions.AddParameterValuesCondition(rdoRank, "check", "rank")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoNumeric, "check", "numeric")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoSort, "check", "sort")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoNonNegative, "check", "non-negative")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoScale, "check", "scale")
        ucrPnlTransformOptions.AddParameterValuesCondition(rdoFormat, "check", "format")

        ucrPnlColumnSelectOptions.AddParameterValuesCondition(rdoSingle, "col", "single")
        ucrPnlColumnSelectOptions.AddParameterValuesCondition(rdoMultiple, "col", "multiple")

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
        ucrPnlNumericOptions.AddRadioButton(rdoLogical)

        ucrPnlNumericOptions.AddParameterValuesCondition(rdoRoundOf, "check", "round")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoSignificantDigits, "check", "signif")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoStandardize, "check", "standardise")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoLag, "check", "lag")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoLead, "check", "lead")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoDifference, "check", "diff")
        ucrPnlNumericOptions.AddParameterValuesCondition(rdoLogical, "check", "logical")

        ucrPnlFormatOptions.AddRadioButton(rdoDecimalFormat)
        ucrPnlFormatOptions.AddRadioButton(rdoScientific)
        ucrPnlFormatOptions.AddRadioButton(rdoPercent)
        ucrPnlFormatOptions.AddRadioButton(rdoNA)
        ucrPnlFormatOptions.AddRadioButton(rdoZero)
        ucrPnlFormatOptions.AddRadioButton(rdoPvalue)
        ucrPnlFormatOptions.AddRadioButton(rdoFraction)
        ucrPnlFormatOptions.AddRadioButton(rdoAlign)

        ucrPnlFormatOptions.AddParameterValuesCondition(rdoDecimalFormat, "check", "DecimalFormat")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoScientific, "check", "Scientific")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoPercent, "check", "Percent")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoNA, "check", "NA")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoZero, "check", "Zero")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoPvalue, "check", "Pvalue")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoFraction, "check", "Fraction")
        ucrPnlFormatOptions.AddParameterValuesCondition(rdoAlign, "check", "Align")

        ucrPnlNonNegative.AddRadioButton(rdoSquareRoot)
        ucrPnlNonNegative.AddRadioButton(rdoLogToBase10)
        ucrPnlNonNegative.AddRadioButton(rdoNaturalLog)
        ucrPnlNonNegative.AddRadioButton(rdoPower)

        UcrInputAlignOperations.SetItems({strDot, strE, strLeft, strCentre, strRight})
        UcrInputAlignOperations.SetDropDownStyleAsNonEditable()

        UcrInputNAOperations.SetItems({strNa, strDot, strHyphen, strMissing})
        UcrInputNAOperations.SetDropDownStyleAsNonEditable()

        UcrInputZeroOperations.SetItems({strZero, strDott, strDot, strHyphen})
        UcrInputZeroOperations.SetDropDownStyleAsNonEditable()

        UcrInputPvalue.SetItems({strStar, strP, strPvalue})
        UcrInputPvalue.SetDropDownStyleAsNonEditable()

        ucrPnlNonNegative.AddParameterValuesCondition(rdoSquareRoot, "check", "sqrt")
        ucrPnlNonNegative.AddParameterValuesCondition(rdoLogToBase10, "check", "log10")
        ucrPnlNonNegative.AddParameterValuesCondition(rdoNaturalLog, "check", "log")
        ucrPnlNonNegative.AddParameterValuesCondition(rdoPower, "check", "power")

        ucrPnlColumnSelectOptions.AddToLinkedControls(ucrChkPreview, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudSignifDigits, {rdoSignificantDigits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudRoundOfDigits, {rdoRoundOf}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudLagLeadPosition, {rdoLead}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudDiffLag, {rdoDifference}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudLagPosition, {rdoLag}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrChkOmitNA, {rdoStandardize}, bNewLinkedAddRemoveParameter:=True)
        ucrPnlNumericOptions.AddToLinkedControls({ucrInputLogicOperations}, {rdoLogical}, bNewLinkedAddRemoveParameter:=True)

        ucrPnlFormatOptions.AddToLinkedControls(ucrNudDecimalPlaces, {rdoDecimalFormat}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls(ucrNudScientific, {rdoScientific}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls(ucrNudPercent, {rdoPercent}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls(UcrNudFraction, {rdoFraction}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls({UcrInputNAOperations, UcrInputNAvalues}, {rdoNA}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls({UcrInputZeroOperations, UcrInputZeroValues}, {rdoZero}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls(UcrInputPvalue, {rdoPvalue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFormatOptions.AddToLinkedControls({UcrInputAlignOperations, UcrInputAlignValues}, {rdoAlign}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlNonNegative.AddToLinkedControls(ucrInputPower, {rdoPower}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrPnlFormatOptions, {rdoFormat}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        ucrInputLogicOperations.AddToLinkedControls({ucrInputLogicalValues}, {"==", "<", "<=", ">", ">=", "!=", "%in%"}, bNewLinkedHideIfParameterMissing:=True)

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
        ucrPnlFormatOptions.SetLinkedDisplayControl(grpFormatOptions)
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

        ucrInputLogicalValues.SetParameter(New RParameter("x", 1))
        ucrInputLogicalValues.AddQuotesIfUnrecognised = False
        ucrInputLogicalValues.SetValidationTypeAsNumeric()

        ucrInputLogicOperations.SetItems({"==", "<", "<=", ">", ">=", "!=", "%in%", "is.na", "!is.na"})
        ucrInputLogicOperations.SetDropDownStyleAsNonEditable()


        ucrNudDecimalPlaces.SetParameter(New RParameter("digits", 0))
        ucrNudDecimalPlaces.SetMinMax(iNewMin:=0, iNewMax:=22)
        ucrNudDecimalPlaces.SetRDefault(3)

        ucrNudScientific.SetParameter(New RParameter("sci", 0))
        ucrNudScientific.SetMinMax(iNewMin:=0, iNewMax:=22)
        ucrNudScientific.SetRDefault(4)

        ucrNudPercent.SetParameter(New RParameter("digits", 0))
        ucrNudPercent.SetMinMax(iNewMin:=0, iNewMax:=22)
        ucrNudPercent.SetRDefault(2)

        UcrNudFraction.SetParameter(New RParameter("digits", 0))
        UcrNudFraction.SetMinMax(iNewMin:=0, iNewMax:=22)
        UcrNudFraction.SetRDefault(10)

        UcrInputNAOperations.SetParameter(New RParameter("na.form", 0))
        UcrInputNAOperations.SetRDefault(Chr(34) & "missing" & Chr(34))

        UcrInputZeroOperations.SetParameter(New RParameter("zero.form", 0))
        UcrInputZeroOperations.SetRDefault(Chr(34) & "." & Chr(34))

        UcrInputPvalue.SetParameter(New RParameter("fmt", 0))
        UcrInputPvalue.SetRDefault(Chr(34) & "p" & Chr(34))

        UcrInputAlignOperations.SetParameter(New RParameter("align", 0))
        UcrInputAlignOperations.SetRDefault(Chr(34) & "." & Chr(34))

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
        ucrChkSubtract.AddParameterValuesCondition(True, "subtract", "True")
        ucrChkSubtract.AddParameterValuesCondition(False, "subtract", "False")

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
        ucrChkMultiply.AddParameterValuesCondition(True, "multiple", "True")
        ucrChkMultiply.AddParameterValuesCondition(False, "multiple", "False")

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
        ucrChkDivide.AddParameterValuesCondition(True, "divide", "True")
        ucrChkDivide.AddParameterValuesCondition(False, "divide", "False")

        ucrInputAdd.SetParameter(New RParameter("v", 1))
        dctAddValues.Add("0", "0")
        dctAddValues.Add("32", "32")
        dctAddValues.Add("273.15", "273.15")
        ucrInputAdd.SetItems(dctAddValues)
        ucrInputAdd.AddQuotesIfUnrecognised = False

        ucrChkAdd.SetText("Add")
        ucrChkAdd.AddParameterValuesCondition(True, "add", "True")
        ucrChkAdd.AddParameterValuesCondition(False, "add", "False")

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
        clsAddConstantColsOperator = New ROperator
        clsNaturalLogFunction = New RFunction
        clsLogBase10Function = New RFunction
        clsPowerOperator = New ROperator
        clsScaleAddOperator = New ROperator
        clsScaleDivideOperator = New ROperator
        clsScaleMultiplyOperator = New ROperator
        clsScaleMultiplyColsOperator = New ROperator
        clsScaleSubtractOperator = New ROperator
        clsPreviewOperator = New ROperator
        clsScaleMeanFunction = New RFunction
        clsScaleMinFunction = New RFunction
        clsDummyTransformFunction = New RFunction
        clsConstantDummyFunction = New RFunction
        clsNumericDummyFunction = New RFunction
        clsNonNegativeDummyFunction = New RFunction
        clsPreviewTextFunction = New RCodeStructure
        clsBooleanOperator = New ROperator
        clsIsNAFunction = New RFunction
        clsRemoveLabelsFunction = New RFunction
        clsGetColSelectionNamesFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsMutateFunction = New RFunction
        clsAcrossFunction = New RFunction
        clsEverythingFunction = New RFunction
        clsPipeOperator = New ROperator
        clsTildaOperator = New ROperator
        clsRoundColsFunction = New RFunction
        clsRankColsFunction = New RFunction
        clsSortColsFunction = New RFunction
        clsSignifColsFunction = New RFunction
        clsLagColsFunction = New RFunction
        clsLeadColsFunction = New RFunction
        clsLeadColsFunction = New RFunction
        clsConcDiffColsFunction = New RFunction
        clsReplicateColsFunction = New RFunction
        clsStandardDevColsFunction = New RFunction
        clsSymbolOperator = New ROperator
        clsSymbolOperator2 = New ROperator
        clsBooleanColsOperator = New ROperator
        clsAddColumnsFunction = New RFunction
        clsPasteFunction = New RFunction
        clsColumnsFunction = New RFunction
        clsAssignOperator = New ROperator
        clsIsNAColsFunction = New RFunction
        clsDescToolsFormatFunction = New RFunction

        ucrSelectorForRank.Reset()
        ucrReceiverRank.SetMeAsReceiver()
        ucrSaveNew.Reset()
        ucrSaveNew.SetName("")
        ucrInputLogicOperations.SetText("==")

        clsConstantDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
        clsConstantDummyFunction.AddParameter("preview", "TRUE", iPosition:=1)

        clsRankFunction.SetRCommand("rank")
        clsRankFunction.AddParameter("na.last", Chr(34) & "keep" & Chr(34), iPosition:=2)
        clsRankFunction.AddParameter("ties.method", Chr(34) & "average" & Chr(34), iPosition:=3)

        clsSortFunction.SetRCommand("sort")
        clsSortFunction.AddParameter("decreasing", "TRUE", iPosition:=1)
        clsSortFunction.AddParameter("na.last", "TRUE", iPosition:=2)

        clsGetColSelectionNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_selected_column_names")

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

        clsBooleanOperator.SetOperation("==")
        clsIsNAFunction.SetRCommand("is.na")

        clsRankColsFunction.SetRCommand("~rank")
        clsRankColsFunction.AddParameter("na.last", Chr(34) & "keep" & Chr(34), iPosition:=2)
        clsRankColsFunction.AddParameter("ties.method", Chr(34) & "average" & Chr(34), iPosition:=3)

        clsSortColsFunction.SetRCommand("~sort")
        clsSortColsFunction.AddParameter("decreasing", "TRUE", iPosition:=1)
        clsSortColsFunction.AddParameter("na.last", "TRUE", iPosition:=2)

        clsRoundColsFunction.SetRCommand("~round")

        clsSignifColsFunction.SetRCommand("~signif")

        clsLagColsFunction.SetPackageName("~dplyr")
        clsLagColsFunction.SetRCommand("lag")

        clsLeadColsFunction.SetPackageName("~dplyr")
        clsLeadColsFunction.SetRCommand("lead")

        clsDiffColsFunction.SetRCommand("diff")
        clsDiffColsFunction.AddParameter("lag", "1", iPosition:=1)

        clsReplicateColsFunction.SetRCommand("rep")
        clsReplicateColsFunction.AddParameter("x", "NA", iPosition:=0)

        clsConcDiffColsFunction.SetRCommand("~c")
        clsConcDiffColsFunction.AddParameter("y", clsRFunctionParameter:=clsReplicateColsFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsConcDiffColsFunction.AddParameter("x", clsRFunctionParameter:=clsDiffColsFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsMeanColsFunction.SetRCommand("mean")
        clsMeanColsFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsStandardDevColsFunction.SetRCommand("sd")
        clsStandardDevColsFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsSubtractColsOperator.SetOperation("-")
        clsSubtractColsOperator.AddParameter("left", ".x", iPosition:=0)
        clsSubtractColsOperator.AddParameter("y", clsRFunctionParameter:=clsMeanColsFunction, iPosition:=1)

        clsDivisionColsOperator.SetOperation("/")
        clsDivisionColsOperator.AddParameter("x", clsROperatorParameter:=clsSubtractColsOperator, iPosition:=0)
        clsDivisionColsOperator.AddParameter("y", clsRFunctionParameter:=clsStandardDevColsFunction, iPosition:=1)

        clsSymbolOperator.AddParameter("left", "~", iPosition:=0, bIncludeArgumentName:=False)
        clsSymbolOperator.AddParameter("right", clsROperatorParameter:=clsDivisionColsOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsSymbolOperator.bBrackets = False

        clsSquarerootColsFunction.SetRCommand("~sqrt")

        clsAddConstantColsOperator.SetOperation("+")
        clsAddConstantColsOperator.AddParameter("c", "0", iPosition:=1)

        clsNaturalLogColsFunction.SetRCommand("~log")

        clsLogBase10ColsFunction.SetRCommand("~log10")

        clsPowerColsOperator.SetOperation("^")
        clsPowerColsOperator.bSpaceAroundOperation = False

        clsScaleMeanColsFunction.SetRCommand("~mean")
        clsScaleMeanColsFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsScaleMinColsFunction.SetRCommand("~min")
        clsScaleMinColsFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsScaleSubtractColsOperator.SetOperation("-")
        clsScaleSubtractColsOperator.AddParameter("u", "0", iPosition:=1)

        clsScaleMultiplyColsOperator.SetOperation("*")
        clsScaleMultiplyColsOperator.AddParameter("x", clsROperatorParameter:=clsScaleSubtractColsOperator, iPosition:=0)
        clsScaleMultiplyColsOperator.AddParameter("y", "1", iPosition:=1)

        clsScaleDivideColsOperator.SetOperation("/")
        clsScaleDivideColsOperator.AddParameter("x", clsROperatorParameter:=clsSymbolOperator2, iPosition:=0)
        clsScaleDivideColsOperator.AddParameter("z", "1", iPosition:=1)
        clsScaleDivideColsOperator.bBrackets = False

        clsScaleAddColsOperator.SetOperation("+")
        clsScaleAddColsOperator.AddParameter("x", clsROperatorParameter:=clsScaleDivideColsOperator, iPosition:=0)
        clsScaleAddColsOperator.AddParameter("v", "0", iPosition:=1)
        clsScaleAddColsOperator.bBrackets = False

        clsSymbolOperator2.AddParameter("left", "~", iPosition:=0, bIncludeArgumentName:=False)
        clsSymbolOperator2.AddParameter("right", clsROperatorParameter:=clsScaleMultiplyColsOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsSymbolOperator2.bBrackets = False

        clsBooleanColsOperator.SetOperation("==")
        clsIsNAColsFunction.SetRCommand("is.na")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsEverythingFunction.SetRCommand("everything")
        clsEverythingFunction.AddParameter("dot", ".", bIncludeArgumentName:=False, iPosition:=0)

        clsAcrossFunction.SetPackageName("dplyr")
        clsAcrossFunction.SetRCommand("across")
        clsAcrossFunction.AddParameter("every", clsRFunctionParameter:=clsEverythingFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsTildaOperator.SetOperation("~")

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
        clsPipeOperator.SetAssignTo("col")

        clsRemoveLabelsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsRemoveLabelsFunction.AddParameter("property", Chr(34) & "labels" & Chr(34), iPosition:=2)
        clsRemoveLabelsFunction.AddParameter("new_val", Chr(34) & Chr(34), iPosition:=3)

        clsDummyTransformFunction.AddParameter("check", "numeric", iPosition:=0)
        clsDummyTransformFunction.AddParameter("col", "single", iPosition:=1)

        clsNumericDummyFunction.AddParameter("check", "round", iPosition:=0)
        clsNumericDummyFunction.AddParameter("multiple", "False", iPosition:=1)
        clsNumericDummyFunction.AddParameter("divide", "False", iPosition:=2)
        clsNumericDummyFunction.AddParameter("add", "False", iPosition:=3)
        clsNumericDummyFunction.AddParameter("subtract", "False", iPosition:=4)

        clsDescToolsFormatFunction.SetPackageName("DescTools")
        clsDescToolsFormatFunction.SetRCommand("Format")
        clsDescToolsFormatFunction.AddParameter("check", "DecimalFormat", iPosition:=0)

        clsNonNegativeDummyFunction.AddParameter("check", "sqrt", iPosition:=0)

        clsFormatFunction.AddParameter("fmt", "fmt_trace", bIncludeArgumentName:=True)


        clsColumnsFunction.SetRCommand("colnames")
        clsColumnsFunction.AddParameter("col_data", "col",, bIncludeArgumentName:=False)

        clsPasteFunction.SetRCommand("paste0")
        clsPasteFunction.AddParameter("data", clsRFunctionParameter:=clsColumnsFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", clsRFunctionParameter:=clsColumnsFunction, iPosition:=0)
        clsAssignOperator.AddParameter("right", clsRFunctionParameter:=clsPasteFunction, iPosition:=1)

        clsAddColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsAddColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsAddColumnsFunction.AddParameter("before", "FALSE", iPosition:=2)
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
        ucrNudDiffLag.AddAdditionalCodeParameterPair(clsReplicateColsFunction, New RParameter("times", 1), iAdditionalPairNo:=2)
        ucrNudDiffLag.AddAdditionalCodeParameterPair(clsDiffColsFunction, New RParameter("lag", 1), iAdditionalPairNo:=3)
        ucrNudLagLeadPosition.AddAdditionalCodeParameterPair(clsLeadColsFunction, New RParameter("n", 1), iAdditionalPairNo:=1)
        ucrNudLagPosition.AddAdditionalCodeParameterPair(clsLagColsFunction, New RParameter("lag", 1), iAdditionalPairNo:=1)
        ucrNudSignifDigits.AddAdditionalCodeParameterPair(clsSignifColsFunction, New RParameter("digits", 1), iAdditionalPairNo:=1)
        ucrInputPower.AddAdditionalCodeParameterPair(clsPowerColsOperator, New RParameter("y", 1), iAdditionalPairNo:=1)
        ucrNudDecimalPlaces.AddAdditionalCodeParameterPair(clsDescToolsFormatFunction, New RParameter("digits", 1), iAdditionalPairNo:=1)
        ucrNudScientific.AddAdditionalCodeParameterPair(clsDescToolsFormatFunction, New RParameter("digits", 1), iAdditionalPairNo:=1)
        ucrNudPercent.AddAdditionalCodeParameterPair(clsDescToolsFormatFunction, New RParameter("digits", 1), iAdditionalPairNo:=1)
        UcrNudFraction.AddAdditionalCodeParameterPair(clsDescToolsFormatFunction, New RParameter("fmt", 2), iAdditionalPairNo:=1)
        ucrSaveNew.AddAdditionalRCode(clsDescToolsFormatFunction, iAdditionalPairNo:=0)

        ucrReceiverRank.AddAdditionalCodeParameterPair(clsAddConstantOperator, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=10)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleSubtractOperator, New RParameter("x", 0), iAdditionalPairNo:=11)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=12)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleMinFunction, New RParameter("x", 0), iAdditionalPairNo:=13)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsBooleanOperator, New RParameter("x", 0), iAdditionalPairNo:=14)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsIsNAFunction, New RParameter("x", 0), iAdditionalPairNo:=15)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsGetColSelectionNamesFunction, New RParameter("x", 0), iAdditionalPairNo:=16)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLeadColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=17)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSortColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=18)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsRoundColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=19)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSignifColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=20)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLagColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=21)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLeadColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=22)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsDiffColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=23)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsMeanColsFunction, New RParameter("x", 0), iAdditionalPairNo:=24)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsStandardDevColsFunction, New RParameter("x", 0), iAdditionalPairNo:=25)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsRankColsFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=26)

        ucrReceiverRank.AddAdditionalCodeParameterPair(clsAddConstantColsOperator, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=27)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleMeanColsFunction, New RParameter("x", 0), iAdditionalPairNo:=28)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsScaleMinColsFunction, New RParameter("x", 0), iAdditionalPairNo:=29)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsBooleanColsOperator, New RParameter("x", 0), iAdditionalPairNo:=30)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsIsNAColsFunction, New RParameter("x", 0), iAdditionalPairNo:=31)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsDescToolsFormatFunction, New RParameter("x", 0), iAdditionalPairNo:=32)

        ucrChkOmitNA.AddAdditionalCodeParameterPair(clsStandardDevFunction, ucrChkOmitNA.GetParameter(), iAdditionalPairNo:=1)
        ucrSelectorForRank.AddAdditionalCodeParameterPair(clsGetColSelectionNamesFunction, ucrSelectorForRank.GetParameter, iAdditionalPairNo:=1)
        ucrNudRoundOfDigits.AddAdditionalCodeParameterPair(clsRoundColsFunction, New RParameter("digits", 1), iAdditionalPairNo:=1)
        ucrChkOmitNA.AddAdditionalCodeParameterPair(clsMeanColsFunction, ucrChkOmitNA.GetParameter(), iAdditionalPairNo:=2)
        ucrChkOmitNA.AddAdditionalCodeParameterPair(clsStandardDevColsFunction, ucrChkOmitNA.GetParameter(), iAdditionalPairNo:=3)
        ucrPnlTies.AddAdditionalCodeParameterPair(clsRankColsFunction, New RParameter("ties.method", 1), iAdditionalPairNo:=1)
        ucrPnlMissingValues.AddAdditionalCodeParameterPair(clsRankColsFunction, New RParameter("na.last", 2), iAdditionalPairNo:=1)
        ucrChkMissingLast.AddAdditionalCodeParameterPair(clsSortColsFunction, New RParameter("na.last", 1), iAdditionalPairNo:=1)
        ucrChkDecreasing.AddAdditionalCodeParameterPair(clsSortColsFunction, New RParameter("decreasing", 2), iAdditionalPairNo:=1)
        ucrInputMultiply.AddAdditionalCodeParameterPair(clsScaleMultiplyColsOperator, New RParameter("y", 1), iAdditionalPairNo:=1)
        ucrInputDivide.AddAdditionalCodeParameterPair(clsScaleDivideColsOperator, New RParameter("z", 1), iAdditionalPairNo:=1)
        ucrInputAdd.AddAdditionalCodeParameterPair(clsScaleAddColsOperator, New RParameter("v", 1), iAdditionalPairNo:=1)
        ucrInputSubtract.AddAdditionalCodeParameterPair(clsScaleSubtractColsOperator, New RParameter("u", 1), iAdditionalPairNo:=1)
        ucrInputConstant.AddAdditionalCodeParameterPair(clsAddConstantColsOperator, New RParameter("c", 1), iAdditionalPairNo:=1)

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
        ucrSaveNew.AddAdditionalRCode(clsBooleanOperator, iAdditionalPairNo:=14)
        ucrSaveNew.AddAdditionalRCode(clsIsNAFunction, iAdditionalPairNo:=15)
        ucrSaveNew.AddAdditionalRCode(clsDescToolsFormatFunction, iAdditionalPairNo:=16)

        ucrPnlTransformOptions.SetRCode(clsDummyTransformFunction, bReset)
        ucrPnlColumnSelectOptions.SetRCode(clsDummyTransformFunction, bReset)
        ucrChkDecreasing.SetRCode(clsSortFunction, bReset)
        ucrChkMissingLast.SetRCode(clsSortFunction, bReset)

        ucrPnlTies.SetRCode(clsRankFunction, bReset)
        ucrPnlMissingValues.SetRCode(clsRankFunction, bReset)
        ucrNudRoundOfDigits.SetRCode(clsRoundFunction, bReset)
        ucrNudSignifDigits.SetRCode(clsSignifFunction, bReset)
        ucrNudLagLeadPosition.SetRCode(clsLeadFunction, bReset)
        ucrNudDecimalPlaces.SetRCode(clsDescToolsFormatFunction, bReset)
        ucrNudScientific.SetRCode(clsDescToolsFormatFunction, bReset)
        ucrNudPercent.SetRCode(clsDescToolsFormatFunction, bReset)
        UcrNudFraction.SetRCode(clsDescToolsFormatFunction, bReset)
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
        ucrPnlFormatOptions.SetRCode(clsDescToolsFormatFunction, bReset)
        ucrPnlNonNegative.SetRCode(clsNonNegativeDummyFunction, bReset)
        ucrChkOmitNA.SetRCode(clsMeanFunction, bReset)
        ucrChkPreview.SetRCode(clsConstantDummyFunction, bReset)

        If bReset Then
            ucrReceiverRank.SetRCode(clsRankFunction, bReset)
            ucrChkDivide.SetRCode(clsNumericDummyFunction, bReset)
            ucrChkAdd.SetRCode(clsNumericDummyFunction, bReset)
            ucrChkMultiply.SetRCode(clsNumericDummyFunction, bReset)
            ucrChkSubtract.SetRCode(clsNumericDummyFunction, bReset)
            ucrSaveNew.SetRCode(clsRoundFunction, bReset)
            ucrNudDecimalPlaces.SetRCode(clsDescToolsFormatFunction, bReset)
            ucrNudScientific.SetRCode(clsDescToolsFormatFunction, bReset)
            ucrNudPercent.SetRCode(clsDescToolsFormatFunction, bReset)
            UcrNudFraction.SetRCode(clsDescToolsFormatFunction, bReset)
        End If
        bResetRCode = True
    End Sub

    Private Sub TestOKEnabled()
        If rdoNumeric.Checked AndAlso rdoLogical.Checked Then
            If Not ucrInputLogicOperations.GetText = "is.na" AndAlso Not ucrInputLogicOperations.GetText = "!is.na" Then
                ucrBase.OKEnabled(Not ucrReceiverRank.IsEmpty() AndAlso ucrSaveNew.IsComplete AndAlso Not ucrInputLogicalValues.IsEmpty)
            Else
                ucrBase.OKEnabled(Not ucrReceiverRank.IsEmpty() AndAlso ucrSaveNew.IsComplete)
            End If

        Else
            ucrBase.OKEnabled(Not ucrReceiverRank.IsEmpty())
        End If
    End Sub

    Private Sub NewDefaultName()
        If rdoSingle.Checked Then
            ucrSaveNew.SetLabelText("New Column Name:")
            ' Only set prefix if the control is empty or hasn't been user-modified
            If Not ucrSaveNew.bUserTyped AndAlso Not ucrReceiverRank.IsEmpty AndAlso String.IsNullOrEmpty(ucrSaveNew.GetText()) Then
                ucrSaveNew.SetPrefix(ucrReceiverRank.GetVariableNames(bWithQuotes:=False))
            End If
        ElseIf rdoMultiple.Checked Then
            ucrSaveNew.SetLabelText("Suffix Name:")
            ucrSaveNew.btnColumnPosition.Visible = False
            If Not ucrReceiverRank.IsEmpty AndAlso (Not ucrSaveNew.bUserTyped) Then
                clsAddColumnsFunction.AddParameter("col_data", "col", iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
        ucrChkEditPreview.Checked = False
    End Sub

    Private Function GetParamValue(ucrDropdown As ucrInput, Optional ucrTextbox As ucrInput = Nothing) As String
        Dim strValue As String = ucrDropdown.GetText()
        If ucrTextbox IsNot Nothing AndAlso Not String.IsNullOrEmpty(ucrTextbox.GetText()) Then
            strValue = ucrTextbox.GetText()
        End If
        Return strValue
    End Function


    Private Sub ucrPnlTransformOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransformOptions.ControlValueChanged, ucrPnlNumericOptions.ControlValueChanged, ucrPnlFormatOptions.ControlValueChanged, ucrInputLogicalValues.ControlValueChanged,
        ucrPnlNonNegative.ControlValueChanged, ucrPnlMissingValues.ControlValueChanged, ucrPnlTies.ControlValueChanged, ucrChkPreview.ControlValueChanged, ucrReceiverRank.ControlValueChanged, ucrNudDiffLag.ControlValueChanged, ucrNudLagLeadPosition.ControlValueChanged,
        ucrNudLagPosition.ControlValueChanged, ucrNudRoundOfDigits.ControlValueChanged, ucrNudSignifDigits.ControlValueChanged, ucrInputPower.ControlValueChanged, ucrInputMultiply.ControlValueChanged, ucrPnlColumnSelectOptions.ControlValueChanged,
        ucrInputDivide.ControlValueChanged, ucrInputConstant.ControlValueChanged, ucrInputAdd.ControlValueChanged, ucrChkOmitNA.ControlValueChanged, ucrInputLogicOperations.ControlValueChanged, ucrChkAddConstant.ControlValueChanged,
        ucrChkMissingLast.ControlValueChanged, ucrChkDecreasing.ControlValueChanged, ucrChkDivide.ControlValueChanged, ucrChkAdd.ControlValueChanged, ucrChkMultiply.ControlValueChanged, ucrChkSubtract.ControlValueChanged
        UpdateControlStates()
        ucrBase.clsRsyntax.ClearCodes()
        If rdoSingle.Checked Then
            If rdoRank.Checked Then
                clsPreviewTextFunction = clsRankFunction.Clone
                clsDummyTransformFunction.AddParameter("check", "rank", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsRankFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRemoveLabelsFunction)
            ElseIf rdoSort.Checked Then
                clsPreviewTextFunction = clsSortFunction.Clone
                clsDummyTransformFunction.AddParameter("check", "sort", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsSortFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRemoveLabelsFunction)
            ElseIf rdoFormat.Checked Then
                clsPreviewTextFunction = clsDescToolsFormatFunction.Clone
                ucrBase.clsRsyntax.SetBaseRFunction(clsDescToolsFormatFunction)
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRemoveLabelsFunction)
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
                ElseIf rdoLogical.Checked Then
                    clsNumericDummyFunction.AddParameter("check", "logical", iPosition:=0)
                    clsPreviewTextFunction = clsBooleanOperator.Clone
                    ucrBase.clsRsyntax.SetBaseROperator(clsBooleanOperator)
                    Select Case ucrInputLogicOperations.GetText
                        Case "=="
                            clsBooleanOperator.SetOperation("==")
                        Case "<"
                            clsBooleanOperator.SetOperation("<")
                        Case "<="
                            clsBooleanOperator.SetOperation("<=")
                        Case ">"
                            clsBooleanOperator.SetOperation(">")
                        Case ">="
                            clsBooleanOperator.SetOperation(">=")
                        Case "!="
                            clsBooleanOperator.SetOperation("!=")
                        Case "%in%"
                            clsBooleanOperator.SetOperation("%in%")
                        Case "is.na"
                            clsIsNAFunction.SetRCommand("is.na")
                            clsPreviewTextFunction = clsIsNAFunction.Clone
                            ucrBase.clsRsyntax.SetBaseRFunction(clsIsNAFunction)
                        Case "!is.na"
                            clsIsNAFunction.SetRCommand("!is.na")
                            clsPreviewTextFunction = clsIsNAFunction.Clone
                            ucrBase.clsRsyntax.SetBaseRFunction(clsIsNAFunction)
                    End Select
                End If
                ucrBase.clsRsyntax.AddToAfterCodes(clsRemoveLabelsFunction)
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
                ucrBase.clsRsyntax.AddToAfterCodes(clsRemoveLabelsFunction)
            ElseIf rdoScale.Checked Then
                clsDummyTransformFunction.AddParameter("check", "scale", iPosition:=0)
                clsPreviewTextFunction = clsScaleAddOperator.Clone
                ucrBase.clsRsyntax.SetBaseROperator(clsScaleAddOperator)
                ucrBase.clsRsyntax.AddToAfterCodes(clsRemoveLabelsFunction)
            End If

            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAssignOperator)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddColumnsFunction)
        Else
            UpdateLoopParameters()
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.SetAssignTo("col")
            ucrBase.clsRsyntax.AddToAfterCodes(clsPipeOperator, 0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAssignOperator, 1)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAddColumnsFunction, 2)

        End If
        AddFormatParameters()
        SetPreviewText()
        UpdateNonNegativeParameters()
        NewDefaultName()
        ResetPreview()
        AddRemoveLogicalValues()
    End Sub

    Private Sub UpdateLoopParameters()
        If rdoRank.Checked Then
            clsDummyTransformFunction.AddParameter("check", "rank", iPosition:=0)
            clsPreviewTextFunction = clsRankColsFunction.Clone
            clsRankColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
            clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsRankColsFunction, bIncludeArgumentName:=False, iPosition:=1)
        ElseIf rdoSort.Checked Then
            clsDummyTransformFunction.AddParameter("check", "sort", iPosition:=0)
            clsPreviewTextFunction = clsSortColsFunction.Clone
            clsSortColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
            clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsSortColsFunction, bIncludeArgumentName:=False, iPosition:=1)
        ElseIf rdoNumeric.Checked Then
            clsDummyTransformFunction.AddParameter("check", "numeric", iPosition:=0)
            If rdoRoundOf.Checked Then
                clsNumericDummyFunction.AddParameter("check", "round", iPosition:=0)
                clsRoundColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsRoundColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoSignificantDigits.Checked Then
                clsNumericDummyFunction.AddParameter("check", "signif", iPosition:=0)
                clsSignifColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsSignifColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoLag.Checked Then
                clsNumericDummyFunction.AddParameter("check", "lag", iPosition:=0)
                clsLagColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsLagColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoLead.Checked Then
                clsNumericDummyFunction.AddParameter("check", "lead", iPosition:=0)
                clsLeadColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsLeadColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoDifference.Checked Then
                clsNumericDummyFunction.AddParameter("check", "diff", iPosition:=0)
                clsDiffColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsConcDiffColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoStandardize.Checked Then
                clsNumericDummyFunction.AddParameter("check", "standardise", iPosition:=0)
                clsMeanColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsStandardDevColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsROperatorParameter:=clsSymbolOperator, bIncludeArgumentName:=False)
            ElseIf rdoLogical.Checked Then
                clsNumericDummyFunction.AddParameter("check", "logical", iPosition:=0)
                clsBooleanColsOperator.AddParameter("x", "~.x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsROperatorParameter:=clsBooleanColsOperator, bIncludeArgumentName:=False)
                Select Case ucrInputLogicOperations.GetText
                    Case "=="
                        clsBooleanColsOperator.SetOperation("==")
                    Case "<"
                        clsBooleanColsOperator.SetOperation("<")
                    Case "<="
                        clsBooleanColsOperator.SetOperation("<=")
                    Case ">"
                        clsBooleanColsOperator.SetOperation(">")
                    Case ">="
                        clsBooleanColsOperator.SetOperation(">=")
                    Case "!="
                        clsBooleanColsOperator.SetOperation("!=")
                    Case "%in%"
                        clsBooleanColsOperator.SetOperation("%in%")
                    Case "is.na"
                        clsIsNAColsFunction.SetRCommand("is.na")
                        clsPreviewTextFunction = clsIsNAFunction.Clone
                        ucrBase.clsRsyntax.SetBaseRFunction(clsIsNAFunction)
                    Case "!is.na"
                        clsIsNAFunction.SetRCommand("!is.na")
                        clsPreviewTextFunction = clsIsNAFunction.Clone
                        ucrBase.clsRsyntax.SetBaseRFunction(clsIsNAFunction)
                End Select
            End If
            ucrBase.clsRsyntax.AddToAfterCodes(clsRemoveLabelsFunction)
        ElseIf rdoFormat.Checked Then
            If rdoDecimalFormat.Checked Then
            ElseIf rdoScientific.Checked Then
            ElseIf rdoPercent.Checked Then
            ElseIf rdoNA.Checked Then
            ElseIf rdoZero.Checked Then
            ElseIf rdoPvalue.Checked Then
            ElseIf rdoFraction.Checked Then
            ElseIf rdoAlign.Checked Then
            End If
        ElseIf rdoNonNegative.Checked Then
            clsDummyTransformFunction.AddParameter("check", "non-negative", iPosition:=0)
            If rdoSquareRoot.Checked Then
                clsNonNegativeDummyFunction.AddParameter("check", "sqrt", iPosition:=0)
                clsSquarerootColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsSquarerootColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoPower.Checked Then
                clsNonNegativeDummyFunction.AddParameter("check", "power", iPosition:=0)
                clsPowerColsOperator.AddParameter("y", ucrInputPower.GetText, iPosition:=1)
                clsPowerColsOperator.AddParameter("x", "~.", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsROperatorParameter:=clsPowerColsOperator, bIncludeArgumentName:=False)
            ElseIf rdoLogToBase10.Checked Then
                clsNonNegativeDummyFunction.AddParameter("check", "log10", iPosition:=0)
                clsLogBase10ColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsLogBase10ColsFunction, bIncludeArgumentName:=False)
            ElseIf rdoNaturalLog.Checked Then
                clsNonNegativeDummyFunction.AddParameter("check", "log", iPosition:=0)
                clsNaturalLogColsFunction.AddParameter("x", ".x", bIncludeArgumentName:=False, iPosition:=0)
                clsAcrossFunction.AddParameter("operator", clsRFunctionParameter:=clsNaturalLogColsFunction, bIncludeArgumentName:=False)
            End If
        ElseIf rdoScale.Checked Then
            clsDummyTransformFunction.AddParameter("check", "scale", iPosition:=0)
            clsScaleSubtractColsOperator.AddParameter("left", ".x", iPosition:=0)
            clsAcrossFunction.AddParameter("operator", clsROperatorParameter:=clsScaleAddColsOperator, bIncludeArgumentName:=False)
        End If

        clsMutateFunction.AddParameter("var", clsRFunctionParameter:=clsAcrossFunction, bIncludeArgumentName:=False, iPosition:=0)
    End Sub

    Private Sub SetPreviewText()
        clsPreviewTextFunction.RemoveAssignTo()
        If Not ucrReceiverRank.IsEmpty Then
            ucrInputPreview.SetText(clsPreviewTextFunction.ToScript())
        Else
            ucrInputPreview.SetText("")
        End If
    End Sub

    Private Sub UpdateNonNegativeParameters()
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
            If rdoSingle.Checked Then
                clsSquarerootFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
                clsPowerOperator.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
                clsLogBase10Function.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
                clsNaturalLogFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantOperator, iPosition:=0)
            Else
                clsSquarerootColsFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantColsOperator, iPosition:=0)
                clsPowerColsOperator.AddParameter("x", clsROperatorParameter:=clsAddConstantColsOperator, iPosition:=0)
                clsLogBase10ColsFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantColsOperator, iPosition:=0)
                clsNaturalLogColsFunction.AddParameter("x", clsROperatorParameter:=clsAddConstantColsOperator, iPosition:=0)
            End If

        End If
        If bResetRCode Then
            If ucrChkAddConstant.Checked Then
                clsConstantDummyFunction.AddParameter("checked", "TRUE", iPosition:=0)
            Else
                clsConstantDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
            End If
        End If
    End Sub

    Private Sub AddFormatParameters()
        If rdoDecimalFormat.Checked Then
            clsDescToolsFormatFunction.AddParameter("digits", ucrNudDecimalPlaces.GetText)

        ElseIf rdoScientific.Checked Then
            clsDescToolsFormatFunction.AddParameter("digits", ucrNudScientific.GetText)
            clsDescToolsFormatFunction.AddParameter("fmt", Chr(34) & "%" & Chr(34))

        ElseIf rdoPercent.Checked Then
            clsDescToolsFormatFunction.AddParameter("digits", ucrNudPercent.GetText)
            clsDescToolsFormatFunction.AddParameter("fmt", Chr(34) & "%" & Chr(34))

        ElseIf rdoNA.Checked Then
            clsDescToolsFormatFunction.AddParameter("na.form", Chr(34) & UcrInputNAOperations.GetText & Chr(34))

        ElseIf rdoZero.Checked Then
            clsDescToolsFormatFunction.AddParameter("zero.form", Chr(34) & UcrInputZeroOperations.GetText & Chr(34))

        ElseIf rdoPvalue.Checked Then
            clsDescToolsFormatFunction.AddParameter("fmt", Chr(34) & UcrInputPvalue.GetText & Chr(34))

        ElseIf rdoFraction.Checked Then
            clsDescToolsFormatFunction.AddParameter("frac", UcrNudFraction.GetText)

        ElseIf rdoAlign.Checked Then
            clsDescToolsFormatFunction.AddParameter("align", Chr(34) & UcrInputAlignOperations.GetText & Chr(34))

        End If
    End Sub

    Private Sub UpdateControlStates()

        ucrNudDecimalPlaces.Enabled = False
        ucrNudScientific.Enabled = False
        ucrNudPercent.Enabled = False
        UcrNudFraction.Enabled = False

        UcrInputNAOperations.Enabled = False
        UcrInputNAvalues.Enabled = False

        UcrInputZeroOperations.Enabled = False
        UcrInputZeroValues.Enabled = False

        UcrInputPvalue.Enabled = False
        UcrInputAlignOperations.Enabled = False
        UcrInputAlignValues.Enabled = False


        If rdoDecimalFormat.Checked Then
            ucrNudDecimalPlaces.Enabled = True

        ElseIf rdoScientific.Checked Then
            ucrNudScientific.Enabled = True

        ElseIf rdoPercent.Checked Then
            ucrNudPercent.Enabled = True

        ElseIf rdoFraction.Checked Then
            UcrNudFraction.Enabled = True

        ElseIf rdoNA.Checked Then
            UcrInputNAOperations.Enabled = True
            UcrInputNAvalues.Enabled = True

        ElseIf rdoZero.Checked Then
            UcrInputZeroOperations.Enabled = True
            UcrInputZeroValues.Enabled = True

        ElseIf rdoPvalue.Checked Then
            UcrInputPvalue.Enabled = True

        ElseIf rdoAlign.Checked Then
            UcrInputAlignOperations.Enabled = True
            UcrInputAlignValues.Enabled = True
        End If
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

    Private Sub ucrInputLogicalValues_TextChanged(sender As Object, e As EventArgs) Handles ucrInputLogicalValues.TextChanged
        SetPreviewText()
        AddRemoveLogicalValues()
    End Sub

    Private Sub ucrInputLogicalValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLogicalValues.ControlValueChanged
        AddRemoveLogicalValues()
    End Sub

    Private Sub AddRemoveLogicalValues()
        If rdoSingle.Checked Then
            If Not ucrInputLogicalValues.IsEmpty Then
                clsBooleanOperator.AddParameter("right", ucrInputLogicalValues.GetText, iPosition:=1)
            Else
                clsBooleanOperator.RemoveParameterByName("right")
            End If
            clsBooleanColsOperator.RemoveParameterByName("right")

        ElseIf rdoMultiple.Checked Then
            If Not ucrInputLogicalValues.IsEmpty Then
                clsBooleanColsOperator.AddParameter("right", ucrInputLogicalValues.GetText, iPosition:=1)
            Else
                clsBooleanColsOperator.RemoveParameterByName("right")
            End If
            clsBooleanOperator.RemoveParameterByName("right")

        End If
    End Sub

    Private Sub ucrSelectorForRank_DataFrameChanged() Handles ucrSelectorForRank.DataFrameChanged
        clsRemoveLabelsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForRank.strCurrentDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrSaveNew_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveNew.ControlValueChanged
        If ucrSaveNew.GetText <> "" AndAlso ucrSaveNew.IsComplete() Then
            clsRemoveLabelsFunction.AddParameter("col_names", Chr(34) & ucrSaveNew.GetText & Chr(34), iPosition:=1)
            clsPasteFunction.AddParameter("col_data", Chr(34) & "_" & ucrSaveNew.GetText & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRank.ControlContentsChanged, ucrSaveNew.ControlContentsChanged,
        ucrPnlTransformOptions.ControlContentsChanged, ucrPnlNumericOptions.ControlContentsChanged, ucrPnlColumnSelectOptions.ControlContentsChanged, ucrPnlNonNegative.ControlContentsChanged, ucrChkDivide.ControlContentsChanged,
        ucrChkMultiply.ControlContentsChanged, ucrChkSubtract.ControlContentsChanged, ucrChkAdd.ControlContentsChanged, ucrChkPreview.ControlContentsChanged,
        ucrChkAddConstant.ControlContentsChanged, ucrInputPower.ControlContentsChanged, ucrInputPreview.ControlContentsChanged, ucrInputLogicalValues.ControlContentsChanged, ucrInputLogicOperations.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumnSelectOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnSelectOptions.ControlValueChanged, ucrReceiverRank.ControlValueChanged, ucrSelectorForRank.ControlValueChanged
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrSelectorForRank.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameFunction.AddParameter("column_selection_name ", ucrReceiverRank.GetVariableNames, iPosition:=1)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsAddColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        If rdoMultiple.Checked Then
            clsDummyTransformFunction.AddParameter("col", "multiple", iPosition:=0)
            ucrSelectorForRank.SetItemType("column_selection")
            ucrReceiverRank.strSelectorHeading = "Column selections"
            lblSelectColumns.Text = "Select:"
        ElseIf rdoSingle.Checked Then
            clsDummyTransformFunction.AddParameter("col", "single", iPosition:=0)
            ucrSelectorForRank.SetItemType("column")
            ucrReceiverRank.strSelectorHeading = "Numerics"
            lblSelectColumns.Text = "Column:"
        End If
        AddRemoveLogicalValues()
    End Sub

    Private Sub ucrChkMultiply_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMultiply.ControlValueChanged, ucrInputMultiply.ControlValueChanged
        If ucrChkMultiply.Checked AndAlso Not ucrInputMultiply.IsEmpty Then
            clsScaleMultiplyColsOperator.AddParameter("y", ucrInputMultiply.GetText, iPosition:=1)
        Else
            clsScaleMultiplyColsOperator.RemoveParameterByName("y")
        End If
    End Sub

    Private Sub ucrChkAdd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAdd.ControlValueChanged, ucrInputAdd.ControlValueChanged
        If ucrChkAdd.Checked AndAlso Not ucrInputAdd.IsEmpty Then
            clsScaleAddColsOperator.AddParameter("v", ucrInputAdd.GetText, iPosition:=1)
        Else
            clsScaleAddColsOperator.RemoveParameterByName("v")
        End If
    End Sub

    Private Sub ucrChkSubtract_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSubtract.ControlValueChanged, ucrInputSubtract.ControlValueChanged
        If ucrChkSubtract.Checked AndAlso Not ucrInputSubtract.IsEmpty Then
            clsScaleSubtractColsOperator.AddParameter("u", ucrInputSubtract.GetText, iPosition:=1)
        Else
            clsScaleSubtractColsOperator.RemoveParameterByName("u")
        End If
    End Sub

    Private Sub ucrChkDivide_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDivide.ControlValueChanged, ucrInputDivide.ControlValueChanged
        If ucrChkDivide.Checked AndAlso Not ucrInputDivide.IsEmpty Then
            clsScaleDivideColsOperator.AddParameter("z", ucrInputDivide.GetText, iPosition:=1)
        Else
            clsScaleDivideColsOperator.RemoveParameterByName("z")
        End If
    End Sub

End Class