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

Imports instat
Imports instat.Translations
Public Class dlgClimaticCheckDataTemperature
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataFrame As String
    Private clsGroupByFunc, clsGroupingListFunc, clsCalcFilterFunc, clsRawFilterFunc, clsRunCalcFunc As New RFunction
    'logical columns
    Private clsFilterListFunc, clsFilterFunc As New RFunction
    'calculated columns
    Private clsJumpDiffCalcFunc, clsDiffCalcFunc, clsListDiffFunc As New RFunction
    Private clsDiffTempOperator As New ROperator

    Private clsDummyFunc As New RFunction
    'Range
    Private clsGreaterEqualToOperator, clsLessEqualToOperator, clsRangeOrOperator, clsRangeOr2Opertor, clsGreaterEqualTo2Operator, clsLessEqualTo2Operator, clsRange2OrOperator As New ROperator
    'Jump
    Private clsConcFunc, clsDiffFunc, clsAbsFunc As New RFunction
    Private clsJumpGreaterOperator As New ROperator
    'Same
    Private clsRepFunc, clsRleFunc, clsAsNumFunc As New RFunction
    Private clsDollarOperator, clsSameGreaterOperator As New ROperator
    'Difference
    Private clsDiffOperator, clsLessDiffOperator As New ROperator
    'Combined
    Private clsOrOperator As New ROperator

    Private Sub dlgClimaticCheckDataTemperature_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            RangeDifference()
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
        'TODO: Not yet implemented.
        rdoMultiple.Enabled = False
        rdoSatelite.Enabled = False
        rdoIndividual.Checked = True

        ucrChkOutlier.Enabled = False
        ucrNudOutlier.Enabled = False
        lblNudOutlier.Enabled = False
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
        ucrReceiverDate.SetMeAsReceiver()
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

        ucrReceiverElement2.Selector = ucrSelectorTemperature
        ucrReceiverElement2.SetParameter(New RParameter("x", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrReceiverElement2.SetParameterIsString()
        ucrReceiverElement2.bWithQuotes = False

        'Checkboxes for options
        ucrChkRangeElement1.SetParameter(New RParameter("range", clsRangeOrOperator, 1), bNewChangeParameterValue:=False)
        ucrChkRangeElement1.SetText("Acceptable Range(Element1)")

        ucrChkRangeElement2.SetParameter(New RParameter("range2", clsRange2OrOperator, 1), bNewChangeParameterValue:=False)
        ucrChkRangeElement2.SetText("Acceptable Range(Element2)")

        'Linking controls
        ucrChkRangeElement1.AddToLinkedControls(ucrNudRangeElement1Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkRangeElement1.AddToLinkedControls(ucrNudRangeElement1Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=50)
        ucrChkRangeElement2.AddToLinkedControls(ucrNudRangeElement2Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkRangeElement2.AddToLinkedControls(ucrNudRangeElement2Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)
        ucrNudRangeElement2Min.SetLinkedDisplayControl(lstLabels2)
        ucrNudRangeElement1Min.SetLinkedDisplayControl(lstLabels)
        ucrNudJump.SetLinkedDisplayControl(lblNudJump)
        ucrNudSame.SetLinkedDisplayControl(lblNudSame)
        ucrNudDifference.SetLinkedDisplayControl(lblNudDiff)
        ucrReceiverElement2.SetLinkedDisplayControl(lblElement2)

        ucrChkSame.SetParameter(New RParameter("same", clsSameGreaterOperator, 1), bNewChangeParameterValue:=False)
        ucrChkSame.SetText("Same")
        ucrChkSame.AddToLinkedControls(ucrNudSame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4)

        ucrChkJump.SetParameter(New RParameter("jump", clsJumpGreaterOperator, 1), bNewChangeParameterValue:=False)
        ucrChkJump.SetText("Jump")
        ucrChkJump.AddToLinkedControls(ucrNudJump, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrChkDifference.SetParameter(New RParameter("diff", clsLessDiffOperator, 1), bNewChangeParameterValue:=False)
        ucrChkDifference.SetText("Difference")

        ucrChkOutlier.SetText("Outlier")

        'Nuds for the respective options
        'Range Option
        ucrNudRangeElement1Min.SetParameter(New RParameter("from", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Min.SetMinMax(-35, 65)

        ucrNudRangeElement1Max.SetParameter(New RParameter("To", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Max.SetMinMax(-35, 65)

        ucrNudRangeElement2Min.SetParameter(New RParameter("from", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement2Min.SetMinMax(-50, 40)
        ucrNudRangeElement2Max.SetParameter(New RParameter("from", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement2Max.SetMinMax(-50, 40)

        'Same Option
        ucrNudSame.SetParameter(New RParameter("n", 1, bNewIncludeArgumentName:=False))
        ucrNudSame.SetMinMax(2, 366)

        'Jump Option
        ucrNudJump.SetParameter(New RParameter("from", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudJump.SetMinMax(1, 25)
        ucrNudJump.DecimalPlaces = 1
        ucrNudJump.Increment = 0.1

        'Difference Option
        ucrNudDifference.SetParameter(New RParameter("n", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudDifference.SetMinMax(-10, 10)
        ucrNudDifference.DecimalPlaces = 1
        ucrNudDifference.Increment = 0.1
        ucrChkDifference.AddToLinkedControls(ucrNudDifference, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        ucrChkIncludeCalculatedColumns.SetText("Include calculated columns")
        ucrChkIncludeCalculatedColumns.AddParameterPresentCondition(True, "sub1", True)
        ucrChkIncludeCalculatedColumns.AddParameterPresentCondition(False, "sub1", False)

        ucrChkIncludeLogicalColumns.SetText("Include logical columns")
        ucrChkIncludeLogicalColumns.AddParameterPresentCondition(True, "sub", True)
        ucrChkIncludeLogicalColumns.AddParameterPresentCondition(False, "sub", False)

        'ucrChkIncludeLogicalColumns.AddToLinkedControls(ucrInputNewColumnName, {True}, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputNewColumnName.SetLinkedDisplayControl(lblNewColumnName)

        'TODO:To be added in future.
        'save
        'ucrInputNewColumnName.SetParameter(New RParameter("result_name", 2))
        'ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorTemperature.ucrAvailableDataFrames)
        'ucrInputNewColumnName.SetName("Qc")

        'outliers Option
        ucrChkOutlier.AddToLinkedControls(ucrNudOutlier, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2.5)
        ttOutliers.SetToolTip(ucrChkOutlier, "Values that are further than this number of IQRs from the corresponding quartile.")
    End Sub

    Private Sub SetDefaults()
        Dim strLengths As String = "lengths"

        clsGroupByFunc = New RFunction
        clsGroupingListFunc = New RFunction
        clsCalcFilterFunc = New RFunction
        clsFilterFunc = New RFunction
        clsFilterListFunc = New RFunction
        clsRawFilterFunc = New RFunction
        clsRunCalcFunc = New RFunction
        clsGreaterEqualToOperator = New ROperator
        clsLessEqualToOperator = New ROperator
        clsConcFunc = New RFunction
        clsDiffFunc = New RFunction
        clsAbsFunc = New RFunction
        clsDiffOperator = New ROperator
        clsRepFunc = New RFunction
        clsRleFunc = New RFunction
        clsAsNumFunc = New RFunction
        clsDollarOperator = New ROperator
        clsOrOperator = New ROperator
        clsLessEqualTo2Operator = New ROperator
        clsGreaterEqualTo2Operator = New ROperator


        clsRangeOrOperator.Clear()
        clsRange2OrOperator.Clear()
        clsSameGreaterOperator.Clear()
        clsJumpGreaterOperator.Clear()
        clsLessDiffOperator.Clear()

        ucrSelectorTemperature.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        'GroupBy
        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunc.SetAssignTo("grouping")
        clsGroupingListFunc.SetRCommand("list")
        clsGroupingListFunc.AddParameter("list", bIncludeArgumentName:=False, clsRFunctionParameter:=clsGroupByFunc, iPosition:=0)

        'Range
        clsGreaterEqualToOperator.SetOperation(">=")
        clsLessEqualToOperator.SetOperation("<=")
        clsRangeOrOperator.SetOperation("|")
        clsRangeOrOperator.bBrackets = False
        clsRangeOrOperator.AddParameter("left", clsROperatorParameter:=clsLessEqualToOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsRangeOrOperator.AddParameter("right", clsROperatorParameter:=clsGreaterEqualToOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsRange2OrOperator.SetOperation("|")
        clsRange2OrOperator.bBrackets = False
        clsGreaterEqualTo2Operator.SetOperation(">=")
        clsLessEqualTo2Operator.SetOperation("<=")
        clsLessEqualTo2Operator.AddParameter("from", "0", bIncludeArgumentName:=False, iPosition:=1)
        clsRange2OrOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsLessEqualTo2Operator, iPosition:=0)
        clsRange2OrOperator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreaterEqualTo2Operator, iPosition:=1)

        'Same
        clsSameGreaterOperator.SetOperation(">=")
        clsSameGreaterOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRepFunc, iPosition:=0)
        clsRepFunc.SetRCommand("rep")
        clsRepFunc.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=0)
        clsRepFunc.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsDollarOperator, iPosition:=1)
        clsAsNumFunc.SetRCommand("as.numeric")
        clsRleFunc.SetRCommand("rle")
        clsRleFunc.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAsNumFunc, iPosition:=0)
        clsDollarOperator.SetOperation("$")
        clsDollarOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsRleFunc, iPosition:=0)
        clsDollarOperator.AddParameter("right", strParameterValue:=strLengths, bIncludeArgumentName:=False, iPosition:=1)

        'Jump
        clsConcFunc.SetRCommand("c")
        clsConcFunc.AddParameter("left", "NA", bIncludeArgumentName:=False, iPosition:=0)
        clsConcFunc.AddParameter("right", bIncludeArgumentName:=False, clsRFunctionParameter:=clsDiffFunc, iPosition:=1)
        clsAbsFunc.SetRCommand("abs")
        clsAbsFunc.AddParameter("diff", bIncludeArgumentName:=False, clsRFunctionParameter:=clsConcFunc, iPosition:=0)
        clsDiffFunc.SetRCommand("diff")
        clsJumpGreaterOperator.SetOperation(">")
        clsJumpGreaterOperator.AddParameter("left", bIncludeArgumentName:=False, clsRFunctionParameter:=clsAbsFunc, iPosition:=0)

        'Difference
        clsLessDiffOperator.SetOperation("<")
        clsLessDiffOperator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsDiffOperator, iPosition:=0)
        clsDiffOperator.SetOperation("-")

        'Main calculation filter
        clsCalcFilterFunc.SetRCommand("instat_calculation$new")
        clsCalcFilterFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsCalcFilterFunc.AddParameter("save", "2", iPosition:=4)
        clsCalcFilterFunc.AddParameter("result_name", Chr(34) & "Qc" & Chr(34))
        clsCalcFilterFunc.SetAssignTo("Filter_Calculation")
        clsCalcFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator, iPosition:=1)

        'Logical columns 
        clsFilterFunc.SetRCommand("instat_calculation$new")
        clsFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator, iPosition:=1)
        clsFilterFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsFilterListFunc, iPosition:=2)
        clsFilterFunc.AddParameter("save", "2", iPosition:=3)
        clsFilterFunc.AddParameter("result_data_frame", Chr(34) & "Filter" & Chr(34), iPosition:=4)
        clsFilterFunc.SetAssignTo("filtered_data")

        'Raw filter
        clsRawFilterFunc.SetRCommand("instat_calculation$new")
        clsRawFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsRawFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator, iPosition:=1)
        clsRawFilterFunc.AddParameter("save", "2", iPosition:=3)
        clsRawFilterFunc.AddParameter("result_data_frame", Chr(34) & "Raw_Filter" & Chr(34), iPosition:=4)
        clsRawFilterFunc.SetAssignTo("Raw_Filter")

        clsFilterListFunc.SetRCommand("list")
        clsFilterListFunc.AddParameter("sub", clsRFunctionParameter:=clsCalcFilterFunc, bIncludeArgumentName:=False)

        'calculated columns
        clsJumpDiffCalcFunc.SetRCommand("instat_calculation$new")
        clsJumpDiffCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsJumpDiffCalcFunc.AddParameter("function_exp", Chr(34) & "c(diff(Tx),NA)" & Chr(34), iPosition:=1)
        clsJumpDiffCalcFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsFilterListFunc, iPosition:=2)
        clsJumpDiffCalcFunc.AddParameter("save", "2", iPosition:=3)
        clsJumpDiffCalcFunc.AddParameter("result_name", Chr(34) & "jump" & Chr(34), iPosition:=4)
        clsJumpDiffCalcFunc.SetAssignTo("jump_diff_calculation")

        clsDiffCalcFunc.SetRCommand("instat_calculation$new")
        clsDiffCalcFunc.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsDiffCalcFunc.AddParameter("function_exp", clsROperatorParameter:=clsDiffTempOperator, iPosition:=1)
        clsDiffCalcFunc.AddParameter("sub_calculations", clsRFunctionParameter:=clsListDiffFunc, iPosition:=2)
        clsDiffCalcFunc.AddParameter("save", "2", iPosition:=3)
        clsDiffCalcFunc.AddParameter("result_name", Chr(34) & "diff" & Chr(34), iPosition:=4)
        clsDiffCalcFunc.SetAssignTo("diff_calculation")

        clsListDiffFunc.SetRCommand("list")
        clsListDiffFunc.AddParameter("sub1", clsRFunctionParameter:=clsCalcFilterFunc, bIncludeArgumentName:=False, iPosition:=0)
        clsListDiffFunc.AddParameter("sub2", clsRFunctionParameter:=clsJumpDiffCalcFunc, bIncludeArgumentName:=False, iPosition:=1)
        clsDiffTempOperator.SetOperation("-")
        clsDiffTempOperator.bToScriptAsRString = True

        clsFilterFunc.SetAssignTo("filtered_data")
        'Combined
        clsOrOperator.SetOperation("|")
        clsOrOperator.bBrackets = False
        clsOrOperator.bToScriptAsRString = True

        clsDummyFunc = clsRawFilterFunc

        clsRunCalcFunc.SetRCommand("InstatDataObject$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsDummyFunc, iPosition:=0)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsGreaterEqualToOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffFunc, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsAsNumFunc, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffTempOperator, New RParameter("tmax", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsGreaterEqualTo2Operator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsLessEqualTo2Operator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsDiffTempOperator, New RParameter("tmin", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)

        ucrNudRangeElement2Max.SetRCode(clsGreaterEqualTo2Operator, bReset)
        ucrNudRangeElement2Min.SetRCode(clsLessEqualTo2Operator, bReset)
        ucrReceiverElement1.SetRCode(clsLessEqualToOperator, bReset)
        ucrNudRangeElement1Min.SetRCode(clsLessEqualToOperator, bReset)
        ucrNudRangeElement1Max.SetRCode(clsGreaterEqualToOperator, bReset)
        ucrNudJump.SetRCode(clsJumpGreaterOperator, bReset)
        ucrReceiverElement2.SetRCode(clsDiffOperator, bReset)
        ucrNudDifference.SetRCode(clsLessDiffOperator, bReset)
        ucrNudSame.SetRCode(clsSameGreaterOperator, bReset)
        ucrChkDifference.SetRCode(clsOrOperator, bReset)
        ucrChkRangeElement1.SetRCode(clsOrOperator, bReset)
        ucrChkRangeElement2.SetRCode(clsOrOperator, bReset)
        ucrChkSame.SetRCode(clsOrOperator, bReset)
        ucrChkJump.SetRCode(clsOrOperator, bReset)
        ucrChkIncludeCalculatedColumns.SetRCode(clsListDiffFunc, bReset)
        ucrChkIncludeLogicalColumns.SetRCode(clsFilterListFunc, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrChkRangeElement1.Checked AndAlso Not ucrReceiverElement1.IsEmpty() AndAlso ucrNudRangeElement1Min.GetText <> "" AndAlso ucrNudRangeElement1Max.GetText <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf ucrChkRangeElement2.Checked AndAlso Not ucrReceiverElement2.IsEmpty() AndAlso ucrNudRangeElement2Min.GetText <> "" AndAlso ucrNudRangeElement2Max.GetText <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf Not ucrReceiverElement1.IsEmpty AndAlso ucrChkSame.Checked AndAlso ucrNudSame.GetText <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf Not ucrReceiverElement1.IsEmpty AndAlso ucrChkJump.Checked AndAlso ucrNudJump.GetText <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf ucrChkDifference.Checked AndAlso ucrNudDifference.GetText <> "" AndAlso Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty Then
            clsGroupByFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverStation.GetVariableNames & ")", iPosition:=1)
            clsCalcFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsGroupingListFunc, iPosition:=3)
            clsRawFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsGroupingListFunc, iPosition:=3)
            clsJumpDiffCalcFunc.AddParameter("manipulations", clsRFunctionParameter:=clsGroupingListFunc, iPosition:=3)
            clsDiffCalcFunc.AddParameter("manipulations", clsRFunctionParameter:=clsGroupingListFunc, iPosition:=3)
        Else
            clsCalcFilterFunc.RemoveParameterByName("manipulations")
            clsRawFilterFunc.RemoveParameterByName("manipulations")
            clsJumpDiffCalcFunc.RemoveParameterByName("manipulations")
            clsDiffCalcFunc.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub FilterFunc()
        If ucrChkRangeElement1.Checked Then
            If Not ucrReceiverElement1.IsEmpty Then
                clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
                clsRawFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            End If
        ElseIf ucrChkRangeElement2.Checked Then
            If Not ucrReceiverElement2.IsEmpty Then
                clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
                clsRawFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            End If
        Else
            clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
            clsRawFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
        End If
        If ucrChkRangeElement1.Checked AndAlso ucrChkRangeElement2.Checked OrElse ucrChkDifference.Checked Then
            If Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty Then
                clsCalcFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
                clsRawFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & "," & strCurrDataFrame & "=" & ucrReceiverElement2.GetVariableNames & ")", iPosition:=2)
            End If
        End If
    End Sub

    Private Sub ucrSelectorTemperature_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTemperature.ControlValueChanged
        strCurrDataFrame = Chr(34) & ucrSelectorTemperature.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub RangeDifference()
        If Not ucrReceiverElement2.IsEmpty Then
            ucrChkRangeElement2.Enabled = True
        Else
            ucrChkRangeElement2.Enabled = False
        End If
        If Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty Then
            ucrChkDifference.Enabled = True
        Else
            ucrChkDifference.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlValueChanged, ucrReceiverElement2.ControlValueChanged, ucrChkRangeElement1.ControlValueChanged, ucrChkRangeElement2.ControlValueChanged, ucrChkDifference.ControlValueChanged
        FilterFunc()
        RangeDifference()
    End Sub

    Private Sub ucrChkIncludeLogicalColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeLogicalColumns.ControlValueChanged, ucrChkIncludeCalculatedColumns.ControlValueChanged, ucrReceiverElement1.ControlValueChanged, ucrReceiverElement2.ControlValueChanged
        If ucrChkIncludeLogicalColumns.Checked Then
            clsFilterListFunc.AddParameter("sub", clsRFunctionParameter:=clsCalcFilterFunc, bIncludeArgumentName:=False)
            clsDummyFunc = clsFilterFunc
        Else
            clsFilterListFunc.RemoveParameterByName("sub")
            clsDummyFunc = clsRawFilterFunc
        End If
        If ucrChkIncludeCalculatedColumns.Checked Then
            If Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty Then
                clsListDiffFunc.AddParameter("sub1", clsRFunctionParameter:=clsCalcFilterFunc, bIncludeArgumentName:=False, iPosition:=0)
                clsListDiffFunc.AddParameter("sub2", clsRFunctionParameter:=clsJumpDiffCalcFunc, bIncludeArgumentName:=False, iPosition:=1)
                clsDummyFunc = clsDiffCalcFunc
            Else
                clsDummyFunc = clsJumpDiffCalcFunc
            End If
        Else
            clsListDiffFunc.RemoveParameterByName("sub1")
            clsListDiffFunc.RemoveParameterByName("sub2")
        End If
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsDummyFunc, iPosition:=0)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlContentsChanged, ucrReceiverElement2.ControlContentsChanged, ucrNudSame.ControlContentsChanged, ucrNudRangeElement1Min.ControlContentsChanged, ucrNudRangeElement1Max.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudJump.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudDifference.ControlContentsChanged, ucrChkRangeElement1.ControlContentsChanged, ucrChkRangeElement2.ControlContentsChanged, ucrChkJump.ControlContentsChanged, ucrChkDifference.ControlContentsChanged, ucrChkSame.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class