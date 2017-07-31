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
Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsRTransform, clsRSpellFunction, clsRWaterBalanceFunction, clsTransformManipulationsFunc, clsRTransformCountSpellSub, clsGroupBy, clsReplaceNA, clsReplaceNAFunction, clsReplaceNAasElement, clsWaterBalance60, clsSubCalcList As New RFunction

    'Moving
    Private clsRMovingFunction As New RFunction

    'Count
    Private clsRRaindayMatch, clsRCountFunction As New RFunction
    Private clsRRaindayAndOperator, clsRRaindayLowerOperator, clsRRaindayUpperOperator, clsRCountOperator As New ROperator

    ' Water Balance
    Private clsPMinFunctionMax, clsPMaxFunctionMax As New RFunction
    Private clsPMaxOperatorMax As New ROperator

    Private clsOverallTransformFunction, clsRRainday As New RFunction
    Private strCurrDataName As String = ""
    Private strValuesUnder As String = ">="
    Private strRainDay As String = "rain_day"

    Private Sub dlgTransformClimatic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctInputSumPairs As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 358

        'Overall Panel
        ucrPnlTransform.SetParameter(New RParameter("function_exp", 1))
        ucrPnlTransform.AddRadioButton(rdoMoving, "rollapply")
        ucrPnlTransform.AddRadioButton(rdoCount, "rollapply")
        ucrPnlTransform.AddRadioButton(rdoSpell, Chr(34) & "cumsum(" & strRainDay & ")-cummax((" & strRainDay & "==0)*cumsum(" & strRainDay & "))" & Chr(34))
        ucrPnlTransform.AddRadioButton(rdoWaterBalance, "Reduce")

        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoMoving, "sub1", "instat_calculation$new", False) ' clsRRainday
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoCount, "sub1", "instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoSpell, "sub1", "instat_calculation$new")
        'ucrPnlTransform.AddParameterValueFunctionNamesCondition(rdoWaterBalance, "sub1", "instat_calculation$new", False)

        ' Setting receivers
        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False
        ucrReceiverData.SetParameterIncludeArgumentName(False)
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverData.strSelectorHeading = "Numerics"

        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ' What is this used for? I don't think this requires a key.
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ' What is this used for? We don't specify days of interest (yet?)
        ucrReceiverDOY.Selector = ucrSelectorTransform
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverDOY.strSelectorHeading = "Day Variables"

        ' Moving
        ucrInputSum.SetParameter(New RParameter("FUN", 0))
        dctInputSumPairs.Add("Sum", "sum")
        dctInputSumPairs.Add("Maximum", "max")
        dctInputSumPairs.Add("Minimum", "min")
        dctInputSumPairs.Add("Mean", "mean")
        ucrInputSum.SetItems(dctInputSumPairs)
        ucrInputSum.SetDropDownStyleAsNonEditable()
        ucrInputSum.SetLinkedDisplayControl(lblSumOver)

        ucrNudSumOver.SetParameter(New RParameter("width", 1))
        ucrNudSumOver.SetMinMax(1, 366)
        ucrNudSumOver.Increment = 1
        ucrNudSumOver.SetLinkedDisplayControl(lblSumRows)

        ' Count
        ucrNudCountOver.SetParameter(New RParameter("width", 1))
        ucrNudCountOver.SetMinMax(1, 366)
        ucrNudCountOver.Increment = 1
        ucrNudCountOver.SetLinkedDisplayControl(lblCountOver)

        ' Count and Spell
        ucrInputCondition.SetItems({"<= Amount of Rain", "Between", ">= Amount of Rain"})
        ucrInputCondition.SetDropDownStyleAsNonEditable()

        ucrInputSpellLower.SetParameter(New RParameter("min", 1))
        ucrInputSpellLower.SetValidationTypeAsNumeric()
        ucrInputSpellLower.AddQuotesIfUnrecognised = False
        ucrInputSpellLower.SetLinkedDisplayControl(lblCondition)

        ucrInputSpellUpper.SetParameter(New RParameter("max", 1))
        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.AddQuotesIfUnrecognised = False

        ' Water Balance
        ucrNudWBCapacity.SetParameter(New RParameter("capacity", 1), False)
        ucrNudWBCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudWBCapacity.Increment = 10
        ucrNudWBCapacity.SetLinkedDisplayControl(lblWBCapacity)

        ucrInputEvaporation.SetParameter(New RParameter("evaporation", 1), False)
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.AddQuotesIfUnrecognised = False
        ucrInputEvaporation.SetLinkedDisplayControl(lblWBEvaporation)

        ' Save Options
        ucrInputColName.SetParameter(New RParameter("result_name", 4))
        ucrInputColName.SetName("moving_" & ucrInputSum.cboInput.SelectedItem)

        ucrPnlTransform.AddToLinkedControls(ucrInputSum, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Sum")
        ucrPnlTransform.AddToLinkedControls(ucrNudSumOver, {rdoMoving}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)

        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver}, {rdoCount}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlTransform.AddToLinkedControls({ucrInputCondition}, {rdoCount, rdoSpell}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Between")
        ucrPnlTransform.AddToLinkedControls({ucrInputSpellLower}, {rdoCount, rdoSpell}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrPnlTransform.AddToLinkedControls({ucrInputSpellUpper}, {rdoCount, rdoSpell}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)

        ucrPnlTransform.AddToLinkedControls(ucrInputEvaporation, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrPnlTransform.AddToLinkedControls(ucrNudWBCapacity, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=60)
    End Sub

    Private Sub SetDefaults()
        clsRTransform = New RFunction
        clsOverallTransformFunction = New RFunction
        clsTransformManipulationsFunc = New RFunction
        clsRTransformCountSpellSub = New RFunction

        clsRMovingFunction.Clear()
        clsGroupBy.Clear()
        clsReplaceNAFunction.Clear()
        clsReplaceNAasElement.Clear()
        clsRCountFunction.Clear()
        clsRSpellFunction.Clear()
        clsRWaterBalanceFunction.Clear()

        clsRRaindayMatch.Clear()
        clsRCountFunction.Clear()
        clsRRaindayAndOperator.Clear()
        clsRRaindayLowerOperator.Clear()
        clsRRaindayUpperOperator.Clear()
        clsRCountOperator.Clear()

        clsPMinFunctionMax.Clear()
        clsPMaxFunctionMax.Clear()
        clsPMaxOperatorMax.Clear()

        ucrSelectorTransform.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrInputColName.bUserTyped = False

        ' Moving
        clsRMovingFunction.bToScriptAsRString = True
        clsRMovingFunction.SetPackageName("zoo")
        clsRMovingFunction.SetRCommand("rollapply")
        clsRMovingFunction.AddParameter("width", 2, iPosition:=1)
        clsRMovingFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsRMovingFunction.AddParameter("fill", "NA", iPosition:=3)
        clsRMovingFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)

        ' Count and Spells: Rainday
        clsRRaindayMatch.bToScriptAsRString = True
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRRainday.AddParameter("result_name", Chr(34) & strRainDay & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("save", "0", iPosition:=6)
        clsRRainday.AddParameter("function_exp", clsRFunctionParameter:=clsRRaindayMatch, iPosition:=1)
        clsRRainday.SetAssignTo("rain_day")

        clsRRaindayMatch.SetRCommand("match")
        clsRRaindayMatch.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator)
        clsRRaindayAndOperator.SetOperation("&")
        clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
        clsRRaindayLowerOperator.SetOperation(">=")
        clsRRaindayLowerOperator.AddParameter("min", 0, iPosition:=1)
        clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        clsRRaindayUpperOperator.SetOperation("<=")
        clsRRaindayUpperOperator.AddParameter("max", 0.85, iPosition:=1)
        clsRRaindayMatch.AddParameter("table", "1", iPosition:=1)
        clsRRaindayMatch.AddParameter("nomatch", "0", iPosition:=2)

        ' Count
        clsRCountFunction.bToScriptAsRString = True
        clsRCountFunction.SetPackageName("zoo")
        clsRCountFunction.SetRCommand("rollapply")
        clsRCountFunction.AddParameter("data", strRainDay, iPosition:=0)
        clsRCountFunction.AddParameter("width", 2, iPosition:=1)
        clsRCountFunction.AddParameter("FUN", "sum", iPosition:=2)
        clsRCountFunction.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)
        clsRCountFunction.AddParameter("fill", "NA", iPosition:=5)

        ' Spell
        ' this is run as a string Chr(34) & "cumsum(" & strRainDay & ")-cummax((" & strRainDay & "==0)*cumsum(" & strRainDay & "))" & Chr(34))

        ' Water Balance
        clsRWaterBalanceFunction.bToScriptAsRString = True
        clsRWaterBalanceFunction.SetRCommand("Reduce")
        clsRWaterBalanceFunction.AddParameter("x", clsRFunctionParameter:=clsPMinFunctionMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMinFunctionMax.SetRCommand("function(x, y) pmin")
        clsPMinFunctionMax.AddParameter("pmax", clsRFunctionParameter:=clsPMaxFunctionMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.SetRCommand("pmax")
        clsPMaxFunctionMax.AddParameter("calculation", clsROperatorParameter:=clsPMaxOperatorMax, iPosition:=0, bIncludeArgumentName:=False)
        clsPMaxOperatorMax.SetOperation("-")
        clsPMaxOperatorMax.AddParameter("first", "x + y", iPosition:=0)
        clsPMaxOperatorMax.AddParameter("evaporation", 5, iPosition:=1, bIncludeArgumentName:=False)
        clsPMaxFunctionMax.AddParameter("0", 0, iPosition:=1, bIncludeArgumentName:=False)
        clsPMinFunctionMax.AddParameter("capacity", 60, iPosition:=1, bIncludeArgumentName:=False)
        clsRWaterBalanceFunction.AddParameter("replace_na", iPosition:=1, bIncludeArgumentName:=False)
        clsRWaterBalanceFunction.AddParameter("accumulate", "TRUE", iPosition:=2)
        '"Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText & ", 0), " & ucrNudCapacity.Value & "), Rain, accumulate=TRUE)" & Chr(34))

        ' Overall Function
        clsRTransformCountSpellSub.SetRCommand("list")

        clsGroupBy.SetRCommand("instat_calculation$new")
        clsGroupBy.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=0)
        clsGroupBy.SetAssignTo("grouping")

        clsTransformManipulationsFunc.SetRCommand("list")
        clsTransformManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsGroupBy, bIncludeArgumentName:=False, iPosition:=0)

        clsRTransform.SetRCommand("instat_calculation$new")
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=0)
        clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRMovingFunction, iPosition:=1) ' changes depending on the rdo
        clsRTransform.AddParameter("result_name", Chr(34) & "moving_sum" & Chr(34), iPosition:=2)
        clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=3)
        clsRTransform.AddParameter("save", 2, iPosition:=4)
        clsRTransform.SetAssignTo("transform_calculation")

        clsOverallTransformFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsOverallTransformFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform, iPosition:=0)
        clsOverallTransformFunction.AddParameter("display", "FALSE", iPosition:=1)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsOverallTransformFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsReplaceNAasElement, New RParameter("element", 0, False), iAdditionalPairNo:=1)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRRaindayLowerOperator, New RParameter("rain", 0), iAdditionalPairNo:=2)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRRaindayUpperOperator, New RParameter("rain", 0), iAdditionalPairNo:=3)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsRWaterBalanceFunction, New RParameter("replace_na", 1, False), iAdditionalPairNo:=4)

        ' Moving
        ucrPnlTransform.SetRCode(clsRTransform, bReset)
        ucrNudSumOver.SetRCode(clsRMovingFunction, bReset)
        ucrInputSum.SetRCode(clsRMovingFunction, bReset)
        ucrReceiverData.SetRCode(clsRMovingFunction, bReset)

        ' Count
        ucrNudCountOver.SetRCode(clsRCountFunction, bReset)
        ucrInputSpellLower.SetRCode(clsRRaindayLowerOperator, bReset)
        ucrInputSpellUpper.SetRCode(clsRRaindayUpperOperator, bReset)

        ' Water Balance
        ucrInputEvaporation.SetRCode(clsPMaxOperatorMax, bReset)
        ucrNudWBCapacity.SetRCode(clsPMinFunctionMax, bReset)

        ucrInputColName.SetRCode(clsRTransform, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverData.IsEmpty AndAlso Not ucrInputColName.IsEmpty AndAlso ((rdoMoving.Checked AndAlso Not ucrInputSum.IsEmpty AndAlso ucrNudSumOver.GetText <> "") OrElse (rdoCount.Checked AndAlso ucrNudCountOver.GetText <> "" AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty AndAlso Not ucrInputCondition.IsEmpty) OrElse (rdoSpell.Checked AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty AndAlso Not ucrInputCondition.IsEmpty) OrElse (rdoWaterBalance.Checked AndAlso Not ucrInputEvaporation.IsEmpty AndAlso ucrNudWBCapacity.GetText <> "")) Then
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

    Private Sub ucrInputSpellLower_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpellLower.ControlValueChanged, ucrInputSpellUpper.ControlValueChanged, ucrInputCondition.ControlValueChanged
        Select Case ucrInputCondition.GetText
            Case "<= Amount of Rain"
                ucrInputSpellUpper.Visible = False
                clsRRaindayAndOperator.RemoveParameterByName("upper")
                clsRRaindayUpperOperator.RemoveParameterByName("max")
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
            Case "Between" ' match(Rain>=LEFT & Rain<=RIGHT, 1, nomatch = 0)
                ucrInputSpellUpper.Visible = True
                clsRRaindayAndOperator.AddParameter("lower", clsROperatorParameter:=clsRRaindayLowerOperator, iPosition:=0)
                clsRRaindayLowerOperator.AddParameter("min", ucrInputSpellLower.GetText, iPosition:=1)
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellUpper.GetText, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayAndOperator, iPosition:=0)
            Case Else
                ucrInputSpellUpper.Visible = False
                clsRRaindayAndOperator.RemoveParameterByName("lower")
                clsRRaindayLowerOperator.RemoveParameterByName("min")
                clsRRaindayAndOperator.AddParameter("upper", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
                clsRRaindayUpperOperator.AddParameter("max", ucrInputSpellLower.GetText, iPosition:=1)
                clsRCountOperator.AddParameter("x", clsROperatorParameter:=clsRRaindayUpperOperator, iPosition:=0)
        End Select
    End Sub

    Private Sub ucrPnlTransform_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlValueChanged
        If rdoMoving.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRMovingFunction, iPosition:=1)
            clsRTransform.RemoveParameterByName("sub_calculations")
        ElseIf rdoCount.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRCountFunction, iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub)
            clsRTransformCountSpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False, iPosition:=0)
        ElseIf rdoSpell.Checked Then
            clsRTransform.AddParameter("function_exp", Chr(34) & "cumsum(" & strRainDay & ")-cummax((" & strRainDay & "==0)*cumsum(" & strRainDay & "))" & Chr(34), iPosition:=1)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsRTransformCountSpellSub)
            clsRTransformCountSpellSub.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, bIncludeArgumentName:=False, iPosition:=0)
        ElseIf rdoWaterBalance.Checked Then
            clsRTransform.AddParameter("function_exp", clsRFunctionParameter:=clsRWaterBalanceFunction, iPosition:=1)
            clsRTransform.RemoveParameterByName("sub_calculations")
        End If
    End Sub

    Private Sub SetAssignName()
        If Not ucrInputColName.bUserTyped Then
            If rdoMoving.Checked Then
                MovingColNames()
            ElseIf rdoCount.Checked Then
                ucrInputColName.SetName("count")
            ElseIf rdoSpell.Checked Then
                ucrInputColName.SetName("spell")
            ElseIf rdoWaterBalance.Checked Then
                ucrInputColName.SetName("water_balance")
            End If
        End If
    End Sub

    Private Sub MovingColNames()
        If ucrInputSum.cboInput.SelectedItem <> Nothing Then
            ucrInputColName.SetName("moving_" & ucrInputSum.cboInput.SelectedItem)
        End If
    End Sub

    Private Sub GroupByOptions()
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & "," & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames & ")")
        Else
            clsGroupBy.AddParameter("calculated_from", "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames & ")")
        End If
    End Sub

    Private Sub RainDays()
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")", iPosition:=0)
    End Sub

    Private Sub ucrSelectorTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        RainDays()
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged
        RainDays()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrReceiverYear_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYear.ControlValueChanged
        GroupByOptions()
    End Sub

    Private Sub ucrPnlTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrPnlTransform.ControlContentsChanged
        SetAssignName()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputSum_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputSum.ControlContentsChanged
        MovingColNames()
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverData.ControlContentsChanged, ucrNudSumOver.ControlContentsChanged, ucrNudCountOver.ControlContentsChanged, ucrInputSpellLower.ControlContentsChanged, ucrInputSpellUpper.ControlContentsChanged, ucrInputCondition.ControlContentsChanged, ucrInputColName.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged, ucrNudWBCapacity.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class