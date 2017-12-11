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
    Private clsGroupByFunc, clsListFunc, clsTempFilterFunc, clsRunCalcFunc As New RFunction
    'Range
    Private clsLessOperator, clsGreaterOperator, clsRangeOrOpertor, clsRangeAndOperator, clsRangeOr2Opertor, clsLess2Operator, clsGreater2Operator, clsRangeAnd2Operator As New ROperator
    'Jump
    Private clsConcFunc, clsDiffFunc, clsAbsFunc As RFunction
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
        ucrReceiverDay.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
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
        ucrChkRange.SetParameter(New RParameter("range", clsRangeAndOperator, 1), bNewChangeParameterValue:=False)
        ucrChkRange.SetText("Range(Element1)")

        ucrChkRange2.SetParameter(New RParameter("range2", clsRangeAnd2Operator, 1), bNewChangeParameterValue:=False)
        ucrChkRange2.SetText("Range(Element2)")

        'Linking controls
        ucrChkRange.AddToLinkedControls(ucrNudRangeElement1Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)
        ucrChkRange.AddToLinkedControls(ucrNudRangeElement1Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=50)
        ucrChkRange2.AddToLinkedControls(ucrNudRangeElement2Min, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrChkRange2.AddToLinkedControls(ucrNudRangeElement2Max, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=30)
        ucrNudRangeElement2Min.SetLinkedDisplayControl(lblNudRangeElement2Min)
        ucrNudRangeElement2Max.SetLinkedDisplayControl(lblNudRangeElement2Max)
        ucrNudRangeElement1Max.SetLinkedDisplayControl(lblNudRangeElement1Max)
        ucrNudRangeElement1Min.SetLinkedDisplayControl(lblNudRangeElement1Min)
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
        ucrNudRangeElement1Min.SetMinMax(-50, 65)


        ucrNudRangeElement1Max.SetParameter(New RParameter("To", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement1Max.SetMinMax(-50, 65)


        ucrNudRangeElement2Min.SetParameter(New RParameter("from", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement2Min.SetMinMax(-50, 50)
        ucrNudRangeElement2Max.SetParameter(New RParameter("from", 1, bNewIncludeArgumentName:=False))
        ucrNudRangeElement2Max.SetMinMax(-50, 50)

        'Same Option
        ucrNudSame.SetParameter(New RParameter("n", 1, bNewIncludeArgumentName:=False))
        ucrNudSame.SetMinMax(2, 366)


        'Jump Option
        ucrNudJump.SetParameter(New RParameter("from", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudJump.SetMinMax(1, 25)


        'Difference Option
        ucrNudDifference.SetParameter(New RParameter("n", iNewPosition:=1, bNewIncludeArgumentName:=False))
        ucrNudDifference.SetMinMax(-5, 5)
        ucrChkDifference.AddToLinkedControls(ucrNudDifference, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        'outliers Option
        ucrChkOutlier.AddToLinkedControls(ucrNudOutlier, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2.5)
        ttOutliers.SetToolTip(ucrChkOutlier, "Values that are further than this number of IQRs from the corresponding quartile.")
    End Sub

    Private Sub SetDefaults()
        Dim strLengths As String = "lengths"

        clsGroupByFunc = New RFunction
        clsListFunc = New RFunction
        clsTempFilterFunc = New RFunction
        clsRunCalcFunc = New RFunction
        clsLessOperator = New ROperator
        clsGreaterOperator = New ROperator
        clsConcFunc = New RFunction
        clsDiffFunc = New RFunction
        clsAbsFunc = New RFunction
        clsDiffOperator = New ROperator
        clsRepFunc = New RFunction
        clsRleFunc = New RFunction
        clsAsNumFunc = New RFunction
        clsDollarOperator = New ROperator
        clsOrOperator = New ROperator
        clsLess2Operator = New ROperator
        clsGreater2Operator = New ROperator

        clsRangeAndOperator.Clear()
        clsRangeAnd2Operator.Clear()
        clsSameGreaterOperator.Clear()
        clsJumpGreaterOperator.Clear()
        clsLessDiffOperator.Clear()

        ucrSelectorTemperature.Reset()
        ucrReceiverStation.SetMeAsReceiver()

        'GroupBy
        clsGroupByFunc.SetRCommand("instat_calculation$new")
        clsGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupByFunc.SetAssignTo("grouping")
        clsListFunc.SetRCommand("list")
        clsListFunc.AddParameter("list", bIncludeArgumentName:=False, clsRFunctionParameter:=clsGroupByFunc, iPosition:=0)

        'Range
        clsLessOperator.SetOperation("<")
        clsGreaterOperator.SetOperation(">")
        clsGreaterOperator.AddParameter("from", "0", bIncludeArgumentName:=False, iPosition:=1)
        clsRangeAndOperator.SetOperation("&")
        clsRangeOrOpertor.bBrackets = False
        clsRangeAndOperator.AddParameter("left", clsROperatorParameter:=clsGreaterOperator, iPosition:=0, bIncludeArgumentName:=False)
        clsRangeAndOperator.AddParameter("right", clsROperatorParameter:=clsLessOperator, iPosition:=1, bIncludeArgumentName:=False)
        clsRangeAnd2Operator.SetOperation("&")
        clsLess2Operator.SetOperation("<")
        clsGreater2Operator.SetOperation(">")
        clsGreater2Operator.AddParameter("from", "0", bIncludeArgumentName:=False, iPosition:=1)
        clsRangeAnd2Operator.AddParameter("left", bIncludeArgumentName:=False, clsROperatorParameter:=clsGreater2Operator, iPosition:=0)
        clsRangeAnd2Operator.AddParameter("right", bIncludeArgumentName:=False, clsROperatorParameter:=clsLess2Operator, iPosition:=1)

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

        'Main Filter
        clsTempFilterFunc.SetRCommand("instat_calculation$new")
        clsTempFilterFunc.AddParameter("type", Chr(34) & "filter" & Chr(34), iPosition:=0)
        clsTempFilterFunc.AddParameter("save", "2", iPosition:=4)
        clsTempFilterFunc.AddParameter("result_data_frame", Chr(34) & "Temperature_Filter" & Chr(34), iPosition:=5)
        clsTempFilterFunc.SetAssignTo("temp_filter")
        clsTempFilterFunc.AddParameter("function_exp", clsROperatorParameter:=clsOrOperator, iPosition:=1)

        'Combined
        clsOrOperator.SetOperation("|")
        clsOrOperator.bBrackets = False
        clsOrOperator.bToScriptAsRString = True

        clsRunCalcFunc.SetRCommand("InstatDataObject$run_instat_calculation")
        clsRunCalcFunc.AddParameter("calc", clsRFunctionParameter:=clsTempFilterFunc, iPosition:=0)
        clsRunCalcFunc.AddParameter("display", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRunCalcFunc)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsLessOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffFunc, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsDiffOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverElement1.AddAdditionalCodeParameterPair(clsAsNumFunc, New RParameter("x", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsGreater2Operator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverElement2.AddAdditionalCodeParameterPair(clsLess2Operator, New RParameter("left", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)

        ucrNudRangeElement2Max.SetRCode(clsLess2Operator, bReset)
        ucrNudRangeElement2Min.SetRCode(clsGreater2Operator, bReset)
        ucrReceiverElement1.SetRCode(clsGreaterOperator, bReset)
        ucrNudRangeElement1Min.SetRCode(clsGreaterOperator, bReset)
        ucrNudRangeElement1Max.SetRCode(clsLessOperator, bReset)
        ucrNudJump.SetRCode(clsJumpGreaterOperator, bReset)
        ucrReceiverElement2.SetRCode(clsDiffOperator, bReset)
        ucrNudDifference.SetRCode(clsLessDiffOperator, bReset)
        ucrNudSame.SetRCode(clsSameGreaterOperator, bReset)
        ucrChkDifference.SetRCode(clsOrOperator, bReset)
        ucrChkRange.SetRCode(clsOrOperator, bReset)
        ucrChkRange2.SetRCode(clsOrOperator, bReset)
        ucrChkSame.SetRCode(clsOrOperator, bReset)
        ucrChkJump.SetRCode(clsOrOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrChkRange.Checked AndAlso Not ucrReceiverElement1.IsEmpty() AndAlso ucrNudRangeElement1Min.GetText <> "" AndAlso ucrNudRangeElement1Max.GetText <> "" Then
            ucrBase.OKEnabled(True)
        ElseIf ucrChkRange2.Checked AndAlso Not ucrReceiverElement2.IsEmpty() AndAlso ucrNudRangeElement2Min.GetText <> "" AndAlso ucrNudRangeElement2Max.GetText <> "" Then
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
            clsTempFilterFunc.AddParameter("manipulations", clsRFunctionParameter:=clsListFunc, iPosition:=3)
        Else
            clsTempFilterFunc.RemoveParameterByName("manipulations")
        End If
    End Sub

    Private Sub FilterFunc()
        clsTempFilterFunc.AddParameter("calculated_from", "list(" & strCurrDataFrame & "=" & ucrReceiverElement1.GetVariableNames & ")", iPosition:=2)
    End Sub

    Private Sub ucrSelectorTemperature_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTemperature.ControlValueChanged
        strCurrDataFrame = Chr(34) & ucrSelectorTemperature.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverElement_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlValueChanged
        FilterFunc()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlContentsChanged, ucrReceiverElement2.ControlContentsChanged, ucrNudSame.ControlContentsChanged, ucrNudRangeElement1Min.ControlContentsChanged, ucrNudRangeElement1Max.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudJump.ControlContentsChanged, ucrNudRangeElement2Min.ControlContentsChanged, ucrNudRangeElement2Max.ControlContentsChanged, ucrNudDifference.ControlContentsChanged, ucrChkRange.ControlContentsChanged, ucrChkRange2.ControlContentsChanged, ucrChkJump.ControlContentsChanged, ucrChkDifference.ControlContentsChanged, ucrChkSame.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class