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
Public Class dlgClimaticCheckDataTemperature
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataFrame As String
    Private clsGroupByFunc, clsGroupingListFunc, clsCalcFilterFunc, clsRunCalcFunc As New RFunction
    'logical columns
    Private clsFilterListFunc, clsFilterFunc As New RFunction
    'Jump
    Private clsJumpCodeElement1, clsJumpCodeElement2 As New clsQCJumpRCode
    Private clsJumpOp, clsJumpListSubCalc As New ROperator
    'Range
    Private clsQCAcceptableRangeElement1, clsQCAcceptableRangeElement2 As New clsQCAcceptableRange
    Private clsRangeOrOp, clsRange2OrOp, clsRangeListSubCalc As New ROperator
    'Same
    Private clsSameCodeElement1, clsSameCodeElement2 As New clsQCSameRCode
    Private clsSameOp, clsSameListSubCalc As New ROperator
    'Difference
    Private clsQCDifferenceRCode As New clsQCDifferenceRCode
    Private clsDiffOp, clsDiffListSubCalc As New ROperator
    'Combined
    Private clsOrOperator As New ROperator
    Private clsListSubCalc As New RFunction
    'outliers
    Private clsOutliersElement1, clsOutliersElement2 As New clsQcOutliers
    Private clsGroupByMonth, clsListForOutlierManipulations As New RFunction
    Private clsOutlierListSubCalc, clsOutlierCombinedOperator As New ROperator

    Private Sub dlgClimaticCheckDataTemperature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 559
        'TODO: Not yet implemented.
        rdoMultiple.Enabled = False
        rdoIndividual.Checked = True

        Dim lstLabels As New List(Of Control)
        lstLabels.AddRange({lblRangeElement1to, lblNudRangeElement1Min, lblNudRangeElement1Max})

        Dim lstLabels2 As New List(Of Control)
        lstLabels2.AddRange({lblNudRangeElement2Min, lblRangeElement2to, lblNudRangeElement2Max})

        'Station Receiver
        ucrReceiverStation.Selector = ucrSelectorTemperature
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        'Date Receiver
        ucrReceiverDate.Selector = ucrSelectorTemperature
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        'Year Receiver
        ucrReceiverYear.Selector = ucrSelectorTemperature
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Month Receiver
        ucrReceiverMonth.Selector = ucrSelectorTemperature
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorTemperature
        ucrReceiverDay.SetParameter(New RParameter("day", 0))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.bWithQuotes = False
        ucrReceiverDay.bAutoFill = True
        ucrReceiverDay.SetClimaticType("doy")
        ucrReceiverDay.strSelectorHeading = "Day Variables"

        'Element Receiver
        ucrReceiverElement1.Selector = ucrSelectorTemperature
        ucrReceiverElement1.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverElement1.SetParameterIsString()
        ucrReceiverElement1.bWithQuotes = False
        ucrReceiverElement1.SetClimaticType("temp_max")
        ucrReceiverElement1.bAutoFill = True
        ucrReceiverElement1.SetMeAsReceiver()

        ucrReceiverElement2.Selector = ucrSelectorTemperature
        ucrReceiverElement2.SetParameter(New RParameter("x", 1, bNewIncludeArgumentName:=False))
        ucrReceiverElement2.SetParameterIsString()
        ucrReceiverElement2.SetClimaticType("temp_min")
        ucrReceiverElement2.bAutoFill = True
        ucrReceiverElement2.bWithQuotes = False

        'Checkboxes for options
        ucrChkRangeElement1.SetParameter(New RParameter("range1", clsRangeOrOp, 1), bNewChangeParameterValue:=False)
        ucrChkRangeElement1.SetText("Acceptable Range (Element1)")

        ucrChkRangeElement2.SetParameter(New RParameter("range2", clsRange2OrOp, 1), bNewChangeParameterValue:=False)
        ucrChkRangeElement2.SetText("Acceptable Range (Element2)")

        'Linking controls
        ucrChkRangeElement1.AddToLinkedControls(ucrNudRangeElement1Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkRangeElement1.AddToLinkedControls(ucrNudRangeElement1Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=50)
        ucrChkRangeElement2.AddToLinkedControls(ucrNudRangeElement2Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkRangeElement2.AddToLinkedControls(ucrNudRangeElement2Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)
        ucrChkOutlier.AddToLinkedControls(ucrNudCoeff, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1.5)
        ucrNudRangeElement2Min.SetLinkedDisplayControl(lstLabels2)
        ucrNudRangeElement1Min.SetLinkedDisplayControl(lstLabels)
        ucrNudJump.SetLinkedDisplayControl(lblNudJump)
        ucrNudSame.SetLinkedDisplayControl(lblNudSame)
        ucrNudDifference.SetLinkedDisplayControl(lblNudDiff)
        ucrReceiverElement2.SetLinkedDisplayControl(lblElement2)
        ucrNudCoeff.SetLinkedDisplayControl(lblCoeff)

        ucrChkSame.SetParameter(New RParameter("same", clsSameOp, 1), bNewChangeParameterValue:=False)
        ucrChkSame.SetText("Same (Element1)")
        ucrChkSame.AddToLinkedControls(ucrNudSame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4)

        ucrChkJump.SetParameter(New RParameter("jump", clsJumpOp, 1), bNewChangeParameterValue:=False)
        ucrChkJump.SetText("Jump (Element1)")
        ucrChkJump.AddToLinkedControls(ucrNudJump, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrChkDifference.SetParameter(New RParameter("diff", clsDiffOp, 1), bNewChangeParameterValue:=False)
        ucrChkDifference.SetText("Difference")

        ucrChkOutlier.SetParameter(New RParameter("Combined_outlier", clsOutlierCombinedOperator, 1), bNewChangeParameterValue:=False)
        ucrChkOutlier.SetText("Outlier")

        ucrNudCoeff.SetParameter(New RParameter("coef"))
        ucrNudCoeff.DecimalPlaces = 1
        ucrNudCoeff.Increment = 0.1

        'Nuds for the respective options
        'Range Option
        ucrNudRangeElement1Min.SetParameter(New RParameter("from", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Min.SetMinMax(-35, 65)
        ucrNudRangeElement1Min.DecimalPlaces = 1
        ucrNudRangeElement1Min.Increment = 0.1

        ucrNudRangeElement1Max.SetParameter(New RParameter("To", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Max.SetMinMax(-35, 65)
        ucrNudRangeElement1Max.DecimalPlaces = 1
        ucrNudRangeElement1Max.Increment = 0.1

        ucrNudRangeElement2Min.SetParameter(New RParameter("from", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement2Min.SetMinMax(-50, 40)
        ucrNudRangeElement2Min.DecimalPlaces = 1
        ucrNudRangeElement2Min.Increment = 0.1

        ucrNudRangeElement2Max.SetParameter(New RParameter("To", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement2Max.SetMinMax(-50, 40)
        ucrNudRangeElement2Max.DecimalPlaces = 1
        ucrNudRangeElement2Max.Increment = 0.1

        'Same Option
        ucrNudSame.SetParameter(New RParameter("n", 1, bNewIncludeArgumentName:=False))
        ucrNudSame.SetMinMax(2, 366)

        'Jump Option
        ucrNudJump.SetParameter(New RParameter("right", 1, bNewIncludeArgumentName:=False))
        ucrNudJump.SetMinMax(1, 25)
        ucrNudJump.DecimalPlaces = 1
        ucrNudJump.Increment = 0.1

        'Difference Option
        ucrNudDifference.SetParameter(New RParameter("n", 1, bNewIncludeArgumentName:=False))
        ucrNudDifference.SetMinMax(-10, 10)
        ucrNudDifference.DecimalPlaces = 1
        ucrNudDifference.Increment = 0.1
        ucrChkDifference.AddToLinkedControls(ucrNudDifference, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrChkIncludeCalculatedColumns.SetText("Calculated columns")
        ucrChkIncludeCalculatedColumns.SetParameter(New RParameter("save", 5))
        ucrChkIncludeCalculatedColumns.SetValuesCheckedAndUnchecked("2", "0")

        ucrChkIncludeLogicalColumns.SetText("Logical columns")
        ucrChkIncludeLogicalColumns.SetParameter(New RParameter("save", 4))
        ucrChkIncludeLogicalColumns.SetValuesCheckedAndUnchecked("2", "0")


        ttOutliers.SetToolTip(ucrChkOutlier, "Values that are further than this number of IQRs from the corresponding quartile.")
        ttMultiple.Show("Not yet implemented.", rdoMultiple)
    End Sub

    Private Sub SetDefaults()
        clsGroupByFunc = New RFunction
        clsGroupingListFunc = New RFunction
        clsCalcFilterFunc = New RFunction
        clsFilterFunc = New RFunction
        clsFilterListFunc = New RFunction
        clsRunCalcFunc = New RFunction

        clsOrOperator = New ROperator

        ucrSelectorTemperature.Reset()
        ucrReceiverElement1.SetMeAsReceiver()

        'GroupBy
        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunc.SetAssignTo("grouping")
        clsGroupingListFunc.SetRCommand("list")
        clsGroupingListFunc.AddParameter("list", bIncludeArgumentName:=False, clsRFunctionParameter:=clsGroupByFunc, iPosition:=0)

        'Range
        clsQCAcceptableRangeElement1.SetDefaults("_tmax")
        clsQCAcceptableRangeElement2.SetDefaults("_tmin")

        clsRangeOrOp.SetOperation("|")
        clsRange2OrOp.SetOperation("|")

        'Same
        clsSameCodeElement1.SetDefaults("_tmax")
        clsSameCodeElement2.SetDefaults("_tmin")

        clsSameOp.SetOperation("|")

        'Jump
        clsJumpCodeElement1.SetDefaults("_tmax")
        clsJumpCodeElement2.SetDefaults("_tmin")

        clsJumpOp.SetOperation("|")

        'Difference
        clsQCDifferenceRCode.SetDefaults()

        clsDiffOp.SetOperation("|")

        'Group By Month for Outliers 
        clsGroupByMonth.SetRCommand("instat_calculation$new")
        clsGroupByMonth.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByMonth.SetAssignTo("grouping_month")

        clsListForOutlierManipulations.SetRCommand("list")
        clsListForOutlierManipulations.AddParameter("sub1", clsRFunctionParameter:=clsGroupByMonth, bIncludeArgumentName:=False, iPosition:=0)

        'Outliers
        clsOutliersElement1.SetDefaults("_tmax")
        clsOutliersElement2.SetDefaults("_tmin")

        clsOutlierCombinedOperator.SetOperation("|")
        clsOutlierCombinedOperator.bBrackets = False

        'Sub Calculations List for temp_filter
        clsListSubCalc.SetRCommand("list")
        clsOutlierListSubCalc.SetOperation(",")
        clsJumpListSubCalc.SetOperation(",")
        clsRangeListSubCalc.SetOperation(",")
        clsSameListSubCalc.SetOperation(",")
        clsDiffListSubCalc.SetOperation(",")


        'Main calculation filter
        clsCalcFilterFunc.SetRCommand("instat_calculation$new")
        clsCalcFilterFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcFilterFunc.AddParameter("result_name", Chr(34) & "QC" & Chr(34))
        clsCalcFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator, iPosition:=1)
        clsCalcFilterFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsListSubCalc, iPosition:=3)
        clsCalcFilterFunc.SetAssignTo("filter_calculation")

        'Logical columns 
        clsFilterFunc.SetRCommand("instat_calculation$new")
        clsFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsFilterFunc.AddParameter("function_exp", strParameterValue:=Chr(34) & "QC" & Chr(34), iPosition:=1)
        clsFilterFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsFilterListFunc, iPosition:=2)
        clsFilterFunc.AddParameter("save", "2", iPosition:=3)
        clsFilterFunc.AddParameter("result_data_frame", Chr(34) & "qcTemp" & Chr(34), iPosition:=4)
        clsFilterFunc.SetAssignTo("filtered_data")

        clsFilterListFunc.SetRCommand("list")
        clsFilterListFunc.AddParameter("sub", clsRFunctionParameter:=clsCalcFilterFunc, bIncludeArgumentName:=False)

        'Combined
        clsOrOperator.SetOperation("|")
        clsOrOperator.bBrackets = False
        clsOrOperator.bToScriptAsRString = True

        clsRunCalcFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsFilterFunc, iPosition:=0)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        clsQCAcceptableRangeElement1.SetElementParameters(ucrReceiverElement1, iAdditionalPairNo:=1)
        clsQCDifferenceRCode.SetElementParameters(ucrReceiverElement1, iAdditionalPairNo:=2)
        clsSameCodeElement1.SetElementParameters(ucrReceiverElement1, iAdditionalPairNo:=3)
        clsOutliersElement1.SetElementParameters(ucrReceiverElement1, iAdditionalPairNo:=4, iAdditionalPairNo1:=5, iAdditionalPairNo2:=6, iAdditionalPairNo3:=7)
        clsJumpCodeElement1.SetElementParameters(ucrReceiverElement1, iAdditionalPairNo1:=8, iAdditionalPairNo2:=9, iAdditionalPairNo3:=10, iAdditionalPairNo4:=11)

        clsQCAcceptableRangeElement2.SetElementParameters(ucrReceiverElement2, iAdditionalPairNo:=1)
        clsSameCodeElement2.SetElementParameters(ucrReceiverElement2, iAdditionalPairNo:=2)
        clsJumpCodeElement2.SetElementParameters(ucrReceiverElement2, iAdditionalPairNo1:=3, iAdditionalPairNo2:=4, iAdditionalPairNo3:=5, iAdditionalPairNo4:=6)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsQCAcceptableRangeElement2.clsLessEqualToOperator, New RParameter("x", 0), iAdditionalPairNo:=7)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierLowerLimitFunc, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=8)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierUpperLimitFunc, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=9)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierUpperOperator, New RParameter("x", 0), iAdditionalPairNo:=10)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierLowerOperator, New RParameter("x", 0), iAdditionalPairNo:=11)

        ucrChkRangeElement1.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("range1", strParamValue:=clsQCAcceptableRangeElement1.clsAcceptableRangeTestFunc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkRangeElement2.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("range2", strParamValue:=clsQCAcceptableRangeElement2.clsAcceptableRangeTestFunc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkOutlier.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("outliers", strParamValue:=clsOutlierListSubCalc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkJump.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("jump", strParamValue:=clsJumpListSubCalc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkSame.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("same", strParamValue:=clsSameListSubCalc, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkDifference.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("diff", strParamValue:=clsQCDifferenceRCode.clsDiffTestFunction, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrChkDifference.AddAdditionalCodeParameterPair(clsListSubCalc, New RParameter("Diff", strParamValue:=clsQCDifferenceRCode.clsDiffCalcFunction, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

        ucrNudCoeff.AddAdditionalCodeParameterPair(clsOutliersElement1.clsOutlierLowerLimitFunc, New RParameter("coef"), iAdditionalPairNo:=1)
        ucrNudCoeff.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierLowerLimitFunc, New RParameter("coef"), iAdditionalPairNo:=2)
        ucrNudCoeff.AddAdditionalCodeParameterPair(clsOutliersElement1.clsOutlierUpperLimitFunc, New RParameter("coef"), iAdditionalPairNo:=3)
        ucrNudCoeff.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierUpperLimitFunc, New RParameter("coef"), iAdditionalPairNo:=3)

        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsJumpCodeElement1.clsJumpTestFunction, New RParameter("save"), iAdditionalPairNo:=1)
        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsJumpCodeElement2.clsJumpTestFunction, New RParameter("save"), iAdditionalPairNo:=2)

        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsSameCodeElement1.clsSameTestFunction, New RParameter("save"), iAdditionalPairNo:=3)
        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsSameCodeElement2.clsSameTestFunction, New RParameter("save"), iAdditionalPairNo:=4)

        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsQCDifferenceRCode.clsDiffTestFunction, New RParameter("save"), iAdditionalPairNo:=5)

        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsQCAcceptableRangeElement1.clsAcceptableRangeTestFunc, New RParameter("save"), iAdditionalPairNo:=6)
        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsQCAcceptableRangeElement2.clsAcceptableRangeTestFunc, New RParameter("save"), iAdditionalPairNo:=7)

        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsOutliersElement1.clsOutlierUpperLimitTestCalc, New RParameter("save"), iAdditionalPairNo:=8)
        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsOutliersElement1.clsOutlierLowerLimitTestCalc, New RParameter("save"), iAdditionalPairNo:=9)

        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierUpperLimitTestCalc, New RParameter("save"), iAdditionalPairNo:=10)
        ucrChkIncludeLogicalColumns.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierLowerLimitTestCalc, New RParameter("save"), iAdditionalPairNo:=11)

        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsJumpCodeElement2.clsJumpCalcFunction, New RParameter("save"), iAdditionalPairNo:=1)

        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsSameCodeElement1.clsSameCalcFunction, New RParameter("save"), iAdditionalPairNo:=2)
        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsSameCodeElement2.clsSameCalcFunction, New RParameter("save"), iAdditionalPairNo:=3)

        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsQCDifferenceRCode.clsDiffCalcFunction, New RParameter("save"), iAdditionalPairNo:=4)

        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsOutliersElement1.clsOutlierUpperLimitCalc, New RParameter("save"), iAdditionalPairNo:=5)
        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsOutliersElement1.clsOutlierLowerLimitCalc, New RParameter("save"), iAdditionalPairNo:=6)

        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierUpperLimitCalc, New RParameter("save"), iAdditionalPairNo:=7)
        ucrChkIncludeCalculatedColumns.AddAdditionalCodeParameterPair(clsOutliersElement2.clsOutlierLowerLimitCalc, New RParameter("save"), iAdditionalPairNo:=8)

        ucrNudJump.AddAdditionalCodeParameterPair(clsJumpCodeElement2.clsGreaterJumpOperator, (New RParameter("n", 1, bNewIncludeArgumentName:=False)))
        ucrNudSame.AddAdditionalCodeParameterPair(clsSameCodeElement2.clsSameGreaterOperator, (New RParameter("n", 1, bNewIncludeArgumentName:=False)))

        ucrNudRangeElement2Max.SetRCode(clsQCAcceptableRangeElement2.clsGreaterEqualToOperator, bReset)
        ucrNudRangeElement2Min.SetRCode(clsQCAcceptableRangeElement2.clsLessEqualToOperator, bReset)
        ucrReceiverElement1.SetRCode(clsQCAcceptableRangeElement1.clsLessEqualToOperator, bReset)
        ucrNudRangeElement1Min.SetRCode(clsQCAcceptableRangeElement1.clsLessEqualToOperator, bReset)
        ucrNudRangeElement1Max.SetRCode(clsQCAcceptableRangeElement1.clsGreaterEqualToOperator, bReset)
        ucrNudJump.SetRCode(clsJumpCodeElement1.clsGreaterJumpOperator, bReset)
        ucrReceiverElement2.SetRCode(clsQCDifferenceRCode.clsDiffOperator, bReset)
        ucrNudDifference.SetRCode(clsQCDifferenceRCode.clsLessDiffOperator, bReset)
        ucrNudSame.SetRCode(clsSameCodeElement1.clsSameGreaterOperator, bReset)
        ucrChkDifference.SetRCode(clsOrOperator, bReset)
        ucrChkRangeElement1.SetRCode(clsOrOperator, bReset)
        ucrChkRangeElement2.SetRCode(clsOrOperator, bReset)
        ucrChkSame.SetRCode(clsOrOperator, bReset)
        ucrChkJump.SetRCode(clsOrOperator, bReset)
        ucrChkIncludeLogicalColumns.SetRCode(clsCalcFilterFunc, bReset)
        ucrChkIncludeCalculatedColumns.SetRCode(clsJumpCodeElement1.clsJumpCalcFunction, bReset)
        ucrChkOutlier.SetRCode(clsOrOperator, bReset)
        ucrNudCoeff.SetRCode(clsOutliersElement1.clsOutlierUpperLimitFunc)
    End Sub

    Private Sub TestOkEnabled()

        Dim bEnable As Boolean = False

        If ucrReceiverElement1.IsEmpty() AndAlso ucrReceiverElement2.IsEmpty() Then
            ucrBase.OKEnabled(False)
            Exit Sub
        ElseIf (ucrReceiverElement1.IsEmpty() OrElse ucrReceiverElement2.IsEmpty()) AndAlso ucrChkDifference.Checked Then
            ucrBase.OKEnabled(False)
            Exit Sub
        ElseIf ucrReceiverElement1.IsEmpty() AndAlso ucrChkRangeElement1.Checked Then
            ucrBase.OKEnabled(False)
            Exit Sub
        ElseIf ucrReceiverElement2.IsEmpty() AndAlso ucrChkRangeElement2.Checked Then
            ucrBase.OKEnabled(False)
            Exit Sub
        End If

        If ucrChkRangeElement1.Checked Then
            If ucrNudRangeElement1Min.GetText <> "" AndAlso ucrNudRangeElement1Max.GetText <> "" Then
                bEnable = True
            Else
                ucrBase.OKEnabled(False)
                Exit Sub
            End If
        End If
        If ucrChkRangeElement2.Checked Then
            If ucrNudRangeElement2Min.GetText <> "" AndAlso ucrNudRangeElement2Max.GetText <> "" Then
                bEnable = True
            Else
                ucrBase.OKEnabled(False)
                Exit Sub
            End If
        End If
        If ucrChkSame.Checked Then
            If ucrNudSame.GetText <> "" Then
                bEnable = True
            Else
                ucrBase.OKEnabled(False)
                Exit Sub
            End If
        End If
        If ucrChkJump.Checked Then
            If ucrNudJump.GetText <> "" Then
                bEnable = True
            Else
                ucrBase.OKEnabled(False)
                Exit Sub
            End If
        End If
        If ucrChkDifference.Checked Then
            If ucrNudDifference.GetText <> "" Then
                bEnable = True
            Else
                ucrBase.OKEnabled(False)
                Exit Sub
            End If

        End If
        If ucrChkOutlier.Checked Then
            If ucrNudCoeff.GetText <> "" Then
                bEnable = True
            Else
                ucrBase.OKEnabled(False)
                Exit Sub
            End If
        End If

        ucrBase.OKEnabled(bEnable)

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
            clsCalcFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsGroupingListFunc, iPosition:=2)
            clsFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsGroupingListFunc, iPosition:=3)
        Else
            clsCalcFilterFunc.RemoveParameterByName("manipulations")
            clsFilterFunc.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub GroupByMonth()
        If Not ucrReceiverMonth.IsEmpty Then
            clsGroupByMonth.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverMonth.GetVariableNames & ")", iPosition:=1)
            If Not ucrReceiverElement1.IsEmpty() Then
                clsOutliersElement1.clsOutlierUpperLimitCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
                clsOutliersElement1.clsOutlierUpperLimitTestCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
                clsOutliersElement1.clsOutlierLowerLimitCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
                clsOutliersElement1.clsOutlierLowerLimitTestCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
            ElseIf ucrReceiverElement1.IsEmpty() Then
                clsOutliersElement1.clsOutlierUpperLimitCalc.RemoveParameterByName("manipulations")
                clsOutliersElement1.clsOutlierUpperLimitTestCalc.RemoveParameterByName("manipulations")
                clsOutliersElement1.clsOutlierLowerLimitCalc.RemoveParameterByName("manipulations")
                clsOutliersElement1.clsOutlierLowerLimitTestCalc.RemoveParameterByName("manipulations")
            End If
            If Not ucrReceiverElement2.IsEmpty() Then
                clsOutliersElement2.clsOutlierUpperLimitCalc.RemoveParameterByName("manipulations")
                clsOutliersElement2.clsOutlierUpperLimitCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
                clsOutliersElement2.clsOutlierUpperLimitTestCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
                clsOutliersElement2.clsOutlierLowerLimitCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
                clsOutliersElement2.clsOutlierLowerLimitTestCalc.AddParameter("manipulations", clsRFunctionParameter:=clsListForOutlierManipulations, iPosition:=3)
            ElseIf ucrReceiverElement2.IsEmpty Then
                clsOutliersElement2.clsOutlierUpperLimitCalc.RemoveParameterByName("manipulations")
                clsOutliersElement2.clsOutlierUpperLimitTestCalc.RemoveParameterByName("manipulations")
                clsOutliersElement2.clsOutlierLowerLimitCalc.RemoveParameterByName("manipulations")
                clsOutliersElement2.clsOutlierLowerLimitTestCalc.RemoveParameterByName("manipulations")
            End If
        Else
            clsOutliersElement1.clsOutlierUpperLimitCalc.RemoveParameterByName("manipulations")
            clsOutliersElement2.clsOutlierUpperLimitCalc.RemoveParameterByName("manipulations")
            clsOutliersElement1.clsOutlierUpperLimitTestCalc.RemoveParameterByName("manipulations")
            clsOutliersElement2.clsOutlierUpperLimitTestCalc.RemoveParameterByName("manipulations")
            clsOutliersElement1.clsOutlierLowerLimitCalc.RemoveParameterByName("manipulations")
            clsOutliersElement2.clsOutlierLowerLimitCalc.RemoveParameterByName("manipulations")
            clsOutliersElement1.clsOutlierLowerLimitTestCalc.RemoveParameterByName("manipulations")
            clsOutliersElement2.clsOutlierLowerLimitTestCalc.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub FilterFunc()
        If Not ucrReceiverElement1.IsEmpty Then
            clsSameOp.AddParameter("same1", strParameterValue:=clsSameCodeElement1.strTestName, bIncludeArgumentName:=False)
            clsSameListSubCalc.AddParameter("same1test", clsRFunctionParameter:=clsSameCodeElement1.clsSameTestFunction, bIncludeArgumentName:=False)
            clsSameListSubCalc.AddParameter("same1calc", clsRFunctionParameter:=clsSameCodeElement1.clsSameCalcFunction, bIncludeArgumentName:=False)
            clsJumpOp.AddParameter("jump1", strParameterValue:=clsJumpCodeElement1.strTestName, bIncludeArgumentName:=False)
            clsJumpListSubCalc.AddParameter("jump1test", clsRFunctionParameter:=clsJumpCodeElement1.clsJumpTestFunction, bIncludeArgumentName:=False)
            clsJumpListSubCalc.AddParameter("jump1calc", clsRFunctionParameter:=clsJumpCodeElement1.clsJumpCalcFunction, bIncludeArgumentName:=False)
            clsRangeOrOp.AddParameter("range1", strParameterValue:=clsQCAcceptableRangeElement1.strTestName, bIncludeArgumentName:=False)
            clsRangeListSubCalc.AddParameter("range1", clsROperatorParameter:=clsQCAcceptableRangeElement1.clsRangeOrOperator, bIncludeArgumentName:=False)
            clsOutlierListSubCalc.AddParameter("upperOutlierCalc1", clsRFunctionParameter:=clsOutliersElement1.clsOutlierUpperLimitTestCalc, bIncludeArgumentName:=False, iPosition:=0)
            clsOutlierListSubCalc.AddParameter("upperOutlierTest1", clsRFunctionParameter:=clsOutliersElement1.clsOutlierUpperLimitCalc, bIncludeArgumentName:=False, iPosition:=1)
            clsOutlierListSubCalc.AddParameter("lowerOutlierCalc1", clsRFunctionParameter:=clsOutliersElement1.clsOutlierLowerLimitTestCalc, bIncludeArgumentName:=False, iPosition:=3)
            clsOutlierListSubCalc.AddParameter("lowerOutlierTest1", clsRFunctionParameter:=clsOutliersElement1.clsOutlierLowerLimitCalc, bIncludeArgumentName:=False, iPosition:=4)
            clsOutlierCombinedOperator.AddParameter("upperOutlierTest1", strParameterValue:=clsOutliersElement1.strUpperTestName, bIncludeArgumentName:=False, iPosition:=0)
            clsOutlierCombinedOperator.AddParameter("lowerOutlierTest1", strParameterValue:=clsOutliersElement1.strLowerTestName, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsSameOp.RemoveParameterByName("same1")
            clsSameListSubCalc.RemoveParameterByName("same1test")
            clsSameListSubCalc.RemoveParameterByName("same1calc")
            clsJumpOp.RemoveParameterByName("jump1")
            clsJumpListSubCalc.RemoveParameterByName("jump1test")
            clsJumpListSubCalc.RemoveParameterByName("jump1calc")
            clsRangeOrOp.RemoveParameterByName("range1")
            clsRangeListSubCalc.RemoveParameterByName("sub1")
            clsOutlierListSubCalc.RemoveParameterByName("upperOutlierCalc1")
            clsOutlierListSubCalc.RemoveParameterByName("upperOutlierTest1")
            clsOutlierListSubCalc.RemoveParameterByName("lowerOutlierCalc1")
            clsOutlierListSubCalc.RemoveParameterByName("lowerOutlierTest1")
            clsOutlierCombinedOperator.RemoveParameterByName("upperOutlierTest1")
            clsOutlierCombinedOperator.RemoveParameterByName("lowerOutlierTest1")
        End If

        If Not ucrReceiverElement2.IsEmpty Then
            clsSameOp.AddParameter("same2", strParameterValue:=clsSameCodeElement2.strTestName, bIncludeArgumentName:=False)
            clsSameListSubCalc.AddParameter("same2test", clsRFunctionParameter:=clsSameCodeElement2.clsSameTestFunction, bIncludeArgumentName:=False)
            clsSameListSubCalc.AddParameter("same2calc", clsRFunctionParameter:=clsSameCodeElement2.clsSameCalcFunction, bIncludeArgumentName:=False)
            clsJumpOp.AddParameter("jump2", strParameterValue:=clsJumpCodeElement2.strTestName, bIncludeArgumentName:=False)
            clsJumpListSubCalc.AddParameter("jump2test", clsRFunctionParameter:=clsJumpCodeElement2.clsJumpTestFunction, bIncludeArgumentName:=False)
            clsJumpListSubCalc.AddParameter("jump2calc", clsRFunctionParameter:=clsJumpCodeElement2.clsJumpCalcFunction, bIncludeArgumentName:=False)
            clsRange2OrOp.AddParameter("range2", strParameterValue:=clsQCAcceptableRangeElement2.strTestName, bIncludeArgumentName:=False)
            clsRangeListSubCalc.AddParameter("range2", clsROperatorParameter:=clsQCAcceptableRangeElement2.clsRangeOrOperator, bIncludeArgumentName:=False)
            clsOutlierListSubCalc.AddParameter("lowerOutlierCalc2", clsRFunctionParameter:=clsOutliersElement2.clsOutlierLowerLimitTestCalc, bIncludeArgumentName:=False, iPosition:=1)
            clsOutlierListSubCalc.AddParameter("lowerOutlierTest2", clsRFunctionParameter:=clsOutliersElement2.clsOutlierLowerLimitCalc, bIncludeArgumentName:=False, iPosition:=2)
            clsOutlierListSubCalc.AddParameter("upperOutlierCalc2", clsRFunctionParameter:=clsOutliersElement2.clsOutlierUpperLimitTestCalc, bIncludeArgumentName:=False, iPosition:=4)
            clsOutlierListSubCalc.AddParameter("upperOutlierTest2", clsRFunctionParameter:=clsOutliersElement2.clsOutlierUpperLimitCalc, bIncludeArgumentName:=False, iPosition:=5)
            clsOutlierCombinedOperator.AddParameter("upperOutlierTest2", clsOutliersElement2.strUpperTestName, bIncludeArgumentName:=False, iPosition:=2)
            clsOutlierCombinedOperator.AddParameter("lowerOutlierTest2", clsOutliersElement2.strLowerTestName, bIncludeArgumentName:=False, iPosition:=3)
        Else
            clsSameOp.RemoveParameterByName("same2")
            clsSameListSubCalc.RemoveParameterByName("same2test")
            clsSameListSubCalc.RemoveParameterByName("same2calc")
            clsJumpOp.RemoveParameterByName("jump2")
            clsJumpListSubCalc.RemoveParameterByName("jump2test")
            clsJumpListSubCalc.RemoveParameterByName("jump2calc")
            clsRange2OrOp.RemoveParameterByName("range2")
            clsRangeListSubCalc.RemoveParameterByName("range2")
            clsOutlierListSubCalc.RemoveParameterByName("lowerOutlierCalc2")
            clsOutlierListSubCalc.RemoveParameterByName("lowerOutlierTest2")
            clsOutlierListSubCalc.RemoveParameterByName("upperOutlierCalc2")
            clsOutlierListSubCalc.RemoveParameterByName("upperOutlierTest2")
            clsOutlierCombinedOperator.RemoveParameterByName("upperOutlierTest2")
            clsOutlierCombinedOperator.RemoveParameterByName("lowerOutlierTest2")
        End If

        If Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty Then
            clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsQCDifferenceRCode.clsDiffCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsDiffOp.AddParameter("diff", strParameterValue:=clsQCDifferenceRCode.strTestName, bIncludeArgumentName:=False)
            clsJumpCodeElement1.clsJumpCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsJumpCodeElement2.clsJumpCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsSameCodeElement1.clsSameCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsSameCodeElement2.clsSameCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsQCAcceptableRangeElement1.clsAcceptableRangeTestFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsQCAcceptableRangeElement2.clsAcceptableRangeTestFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
        ElseIf Not ucrReceiverElement1.IsEmpty Then
            clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsJumpCodeElement1.clsJumpCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsJumpCodeElement2.clsJumpCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsSameCodeElement1.clsSameCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsSameCodeElement2.clsSameCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsQCAcceptableRangeElement1.clsAcceptableRangeTestFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsQCAcceptableRangeElement2.clsAcceptableRangeTestFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsOutliersElement1.clsOutlierUpperLimitCalc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsOutliersElement1.clsOutlierLowerLimitCalc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
        ElseIf Not ucrReceiverElement2.IsEmpty Then
            clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsJumpCodeElement1.clsJumpCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsJumpCodeElement2.clsJumpCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsSameCodeElement1.clsSameCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsSameCodeElement2.clsSameCalcFunction.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsQCAcceptableRangeElement1.clsAcceptableRangeTestFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsQCAcceptableRangeElement2.clsAcceptableRangeTestFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsOutliersElement2.clsOutlierUpperLimitCalc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            clsOutliersElement2.clsOutlierLowerLimitCalc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
        End If
    End Sub

    Private Sub EnableOrDisableDifferenceControls()
        If ucrReceiverElement1.IsEmpty OrElse ucrReceiverElement2.IsEmpty Then
            ucrChkDifference.Enabled = False
            ucrNudDifference.Enabled = False
            ucrChkDifference.Checked = False
        Else
            ucrChkDifference.Enabled = True
            ucrNudDifference.Enabled = True
        End If
    End Sub

    Private Sub ucrReceiverMonth_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonth.ControlValueChanged, ucrReceiverElement1.ControlValueChanged, ucrReceiverElement2.ControlValueChanged
        GroupByMonth()
    End Sub

    Private Sub ucrSelectorTemperature_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTemperature.ControlValueChanged
        strCurrDataFrame = Chr(34) & ucrSelectorTemperature.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupByOptions()
        FilterFunc()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverElement1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlValueChanged, ucrReceiverElement2.ControlValueChanged
        FilterFunc()
        EnableOrDisableDifferenceControls()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlContentsChanged, ucrReceiverElement2.ControlContentsChanged, ucrNudSame.ControlContentsChanged, ucrNudRangeElement1Min.ControlContentsChanged, ucrNudRangeElement1Max.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudJump.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudDifference.ControlContentsChanged, ucrChkRangeElement1.ControlContentsChanged, ucrChkRangeElement2.ControlContentsChanged, ucrChkJump.ControlContentsChanged, ucrChkDifference.ControlContentsChanged, ucrChkSame.ControlContentsChanged, ucrChkOutlier.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
