'' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsRTransform, clsRRollFuncExpr, clsMatchFun, clsTransformManipulationsFunc, clsTransformGroupByFunc, clsReplaceNA, clsWaterBalance60, clsSubCalcList As New RFunction
    Private clsRollFunction, clsRRainday As New RFunction
    Private strCurrDataName As String = ""
    Private strValuesUnder As String = ">="
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

        ' Setting receivers
        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False
        ucrReceiverData.SetParameterIncludeArgumentName(False)
        ucrReceiverData.Selector = ucrSelectorTransform

        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True

        ucrReceiverDOY.Selector = ucrSelectorTransform
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        ucrReceiverDOY.bAutoFill = True

        'clsRTransform.SetRCommand("instat_calculation$new")
        'clsRTransform.SetAssignTo("transform_calculation")

        ucrInputThreshold.SetParameter(New RParameter("threshold", 1))
        ucrInputThreshold.SetValidationTypeAsNumeric()
        ucrInputThreshold.SetLinkedDisplayControl(lblThreshold)

        ucrInputSum.SetParameter(New RParameter("FUN", 0))
        dctInputSumPairs.Add("sum", Chr(39) & "sum" & Chr(39))
        dctInputSumPairs.Add("max", Chr(39) & "max" & Chr(39))
        dctInputSumPairs.Add("min", Chr(39) & "min" & Chr(39))
        dctInputSumPairs.Add("mean", Chr(39) & "mean" & Chr(39))
        ucrInputSum.SetItems(dctInputSumPairs)
        ucrInputSum.SetLinkedDisplayControl(lblSumOver)
        ucrInputSum.SetDropDownStyleAsNonEditable()

        ucrNudSumOver.SetParameter(New RParameter("width", 2))
        ucrNudSumOver.SetMinMax(1, 366)
        ucrNudSumOver.Increment = 1
        ucrNudSumOver.SetLinkedDisplayControl(lblSumRows)

        ucrNudCountOver.SetParameter(New RParameter("count_over"))
        ucrNudCountOver.SetMinMax(1, 366)
        ucrNudCountOver.Increment = 1
        ucrNudCountOver.SetLinkedDisplayControl(lblCountOver)

        ucrChkValuesUnderThreshold.SetText("Values Under Threshold")
        ucrChkValuesUnderThreshold.SetLinkedDisplayControl(lblCountRows)

        ucrInputSpellLower.SetParameter(New RParameter("spell_lower"))
        ucrInputSpellLower.SetValidationTypeAsNumeric()
        ucrInputSpellLower.SetLinkedDisplayControl(lblValuesBetween)

        ucrInputSpellUpper.SetParameter(New RParameter("spell_upper"))
        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.SetLinkedDisplayControl(lblSpellAnd)

        ucrNudWBCapacity.SetParameter(New RParameter("capacity"))
        ucrNudWBCapacity.SetMinMax(1, Integer.MaxValue)
        ucrNudWBCapacity.Increment = 1
        ucrNudWBCapacity.SetLinkedDisplayControl(lblWBCapacity)

        ucrInputEvaporation.SetParameter(New RParameter("evaporation"))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.SetLinkedDisplayControl(lblWBEvaporation)

        ucrInputColName.SetParameter(New RParameter("result_name", 4))
        ucrInputColName.SetName("moving_" & ucrInputSum.cboInput.SelectedItem)
        ucrInputColName.bUserTyped = False

        clsSubCalcList.SetRCommand("list")

        ucrPnlTransform.AddRadioButton(rdoMoving)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)

        ucrPnlTransform.AddParameterValuesCondition(rdoMoving, "FUN", Chr(39) & "sum" & Chr(39))
        ucrPnlTransform.AddParameterValuesCondition(rdoCount, "FUN", Chr(39) & "sum" & Chr(39), False)
        ucrPnlTransform.AddParameterValuesCondition(rdoSpell, "FUN", Chr(39) & "sum" & Chr(39), False)
        ucrPnlTransform.AddParameterValuesCondition(rdoWaterBalance, "FUN", Chr(39) & "sum" & Chr(39), False)
        ucrPnlTransform.bAllowNonConditionValues = True

        ucrPnlTransform.AddToLinkedControls({ucrInputSum, ucrNudSumOver}, {rdoMoving}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver, ucrChkValuesUnderThreshold}, {rdoCount}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrInputSpellLower, ucrInputSpellUpper}, {rdoSpell}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudWBCapacity, ucrInputEvaporation}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsRRollFuncExpr = New RFunction
        clsRTransform = New RFunction
        clsMatchFun = New RFunction
        clsRollFunction = New RFunction
        clsTransformManipulationsFunc = New RFunction
        clsTransformGroupByFunc = New RFunction

        rdoMoving.Checked = True ' this is a temporary fix to reset problem

        ucrSelectorTransform.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrInputThreshold.SetName(0.85)
        ucrInputEvaporation.SetName(5)
        ucrNudCountOver.Value = 1
        ucrNudWBCapacity.Value = 60
        ucrChkValuesUnderThreshold.Checked = False
        ucrInputSpellLower.SetName(0)
        ucrInputSpellUpper.SetName(0.85)
        ucrInputColName.bUserTyped = False
        ' RDO1
        clsTransformGroupByFunc.SetRCommand("instat_calculation$new")
        clsTransformGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34), iPosition:=2)
        clsTransformGroupByFunc.SetAssignTo("grouping")


        ' RDO2
        clsMatchFun.SetRCommand("match.fun")
        clsMatchFun.AddParameter("FUN", Chr(39) & "sum" & Chr(39), iPosition:=0)

        clsRRollFuncExpr.SetPackageName("zoo")
        clsRRollFuncExpr.SetRCommand("rollapply")
        clsRRollFuncExpr.AddParameter("data", ucrReceiverData.GetVariableNames(bWithQuotes:=False), iPosition:=0)
        clsRRollFuncExpr.AddParameter("fill", "NA", iPosition:=3)
        clsRRollFuncExpr.AddParameter("width", 1, iPosition:=2)
        clsRRollFuncExpr.AddParameter("FUN", clsRFunctionParameter:=clsMatchFun, iPosition:=1)
        clsRRollFuncExpr.AddParameter("align", Chr(39) & "right" & Chr(39), iPosition:=4)

        'RDO 3
        clsReplaceNA.SetRCommand("instat_calculation$new")
        clsReplaceNA.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverData.GetVariableNames(False) & ", is.na(" & ucrReceiverData.GetVariableNames(False) & ")," & ucrNudWBCapacity.Value & ")" & Chr(34), iPosition:=2)
        clsReplaceNA.AddParameter("result_name", Chr(34) & "replace_NA" & Chr(34), iPosition:=3)
        clsReplaceNA.AddParameter("calculated_from", " list(" & strCurrDataName & "= " & ucrReceiverData.GetVariableNames() & ")", iPosition:=0)
        clsReplaceNA.AddParameter("save", "0", iPosition:=4)
        clsReplaceNA.SetAssignTo("replace_NA")

        clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA, iPosition:=0)

        clsWaterBalance60.SetRCommand("instat_calculation$new")
        clsWaterBalance60.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsWaterBalance60.AddParameter("result_name", Chr(34) & "Water_Balance_60" & Chr(34), iPosition:=3)
        clsWaterBalance60.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=5)
        clsWaterBalance60.AddParameter("save", "2", iPosition:=4)
        clsWaterBalance60.SetAssignTo("Water_Balance_60")

        ' RDO4
        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)

        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverData.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverData.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0,1)" & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34), iPosition:=3)
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")", iPosition:=0)
        clsRRainday.AddParameter("save", "0", iPosition:=4)
        clsRRainday.SetAssignTo("rain_day")

        ' Base
        clsTransformManipulationsFunc.SetRCommand("list")
        clsTransformManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsTransformGroupByFunc, bIncludeArgumentName:=False, iPosition:=0)

        clsRTransform.SetRCommand("instat_calculation$new")
        clsRTransform.SetAssignTo("transform_calculation")
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34), iPosition:=1)
        clsRTransform.AddParameter("result_name", Chr(34) & "moving_sum" & Chr(34), iPosition:=3)
        clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=4)
        clsRTransform.AddParameter("save", 2, iPosition:=4)

        clsRollFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRollFunction.AddParameter("display", "FALSE", iPosition:=1)
        clsRollFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform, iPosition:=0)

        'Base Function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlTransform.SetRCode(clsMatchFun, bReset)
        ucrNudSumOver.SetRCode(clsRRollFuncExpr, bReset)
        ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        ucrInputSum.SetRCode(clsMatchFun, bReset)
        ucrInputColName.SetRCode(clsRTransform, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverDOY.IsEmpty AndAlso Not ucrReceiverData.IsEmpty AndAlso ((rdoMoving.Checked AndAlso Not ucrInputSum.IsEmpty AndAlso ucrNudSumOver.GetText <> "") OrElse (rdoCount.Checked AndAlso ucrNudCountOver.GetText <> "") OrElse (rdoSpell.Checked AndAlso Not ucrInputSpellLower.IsEmpty AndAlso Not ucrInputSpellUpper.IsEmpty) OrElse (rdoWaterBalance.Checked AndAlso Not ucrInputEvaporation.IsEmpty AndAlso ucrNudWBCapacity.GetText <> "")) Then
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

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        clsRTransform.SetAssignTo("transform_calculation")
        clsWaterBalance60.SetAssignTo("water_balance_60")
        clsReplaceNA.SetAssignTo("replace_NA")
        clsRRainday.SetAssignTo("rain_day")
        SetGroupByFuncCalcFrom()
        If rdoMoving.Checked Then
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        ElseIf rdoCount.Checked Then
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        ElseIf rdoSpell.Checked Then
            clsRTransform.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34), iPosition:=2)
        ElseIf rdoWaterBalance.Checked Then
            clsRTransform.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudWBCapacity.Value & "), replace_NA, accumulate=TRUE)" & Chr(34), iPosition:=2)
        End If
        clsRollFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
    End Sub

    Private Sub SumOver()
        If Not ucrReceiverData.IsEmpty Then
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        End If
    End Sub

    Private Sub ucrPnlTransform_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlValueChanged, ucrPnlTransform.ControlContentsChanged
        Dim bRain As Boolean = False
        If rdoMoving.Checked Then
            clsRRollFuncExpr.AddParameter("width", ucrNudSumOver.Value)
            clsRRollFuncExpr.AddParameter("FUN", clsRFunctionParameter:=clsMatchFun)
            clsRTransform.RemoveParameterByName("sub_calculations")
            grpTransform.Text = "Moving"
        ElseIf rdoCount.Checked Then
            clsRRollFuncExpr.AddParameter("width", ucrNudCountOver.Value)
            clsRRollFuncExpr.AddParameter("FUN", "function(x) length(which(x" & strValuesUnder & ucrInputThreshold.GetText() & "))")
            clsRTransform.RemoveParameterByName("sub_calculations")
            grpTransform.Text = "Count"
        ElseIf rdoSpell.Checked Then
            clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverData.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverData.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0, 1)" & Chr(34))
            clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=6)
            grpTransform.Text = "Spell"
        ElseIf rdoWaterBalance.Checked Then
            bRain = True
            clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverData.GetVariableNames(False) & ", is.na(" & ucrReceiverData.GetVariableNames(False) & ")," & ucrNudWBCapacity.Value & ")" & Chr(34))
            clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=6)
            grpTransform.Text = "Water Balance"
        End If
        SetAssignName()
        If bRain Then
            ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
            ucrReceiverData.bAutoFill = True
        Else
            ucrReceiverData.RemoveIncludedMetadataProperty("Climatic_Type")
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

    Private Sub ucrSelectorTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlContentsChanged, ucrReceiverData.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverData.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverData.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0, 1)" & Chr(34), iPosition:=2)
        clsReplaceNA.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverData.GetVariableNames(False) & ", is.na(" & ucrReceiverData.GetVariableNames(False) & ")," & ucrNudWBCapacity.Value & ")" & Chr(34), iPosition:=2)
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")", iPosition:=0)
        clsRTransform.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")", iPosition:=0)
        clsReplaceNA.AddParameter("calculated_from", " list(" & strCurrDataName & "= " & ucrReceiverData.GetVariableNames() & ")", iPosition:=0)
    End Sub

    Private Sub ucrCountOver_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrNudCountOver.ControlContentsChanged
        clsRRollFuncExpr.AddParameter("width", ucrNudCountOver.Value)
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
        TestOkEnabled()
    End Sub

    Private Sub ucrValuesUnder_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrChkValuesUnderThreshold.ControlContentsChanged, ucrInputThreshold.ControlContentsChanged
        If ucrChkValuesUnderThreshold.Checked Then
            strValuesUnder = "<"
        Else
            strValuesUnder = ">="
        End If
        clsRRollFuncExpr.AddParameter("FUN", "function(x) length(which(x" & strValuesUnder & ucrInputThreshold.GetText() & "))", iPosition:=0)
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34), iPosition:=2)
    End Sub

    Private Sub SetGroupByFuncCalcFrom()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        If Not ucrReceiverStation.IsEmpty Then
            clsTransformGroupByFunc.SetAssignTo("grouping")
            clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc, iPosition:=4)

            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        Else
            clsRTransform.RemoveParameterByName("manipulations")

        End If
        If strGroupByCalcFrom <> "" Then
            clsTransformGroupByFunc.AddParameter("calculated_from", strGroupByCalcFrom, iPosition:=0)
        Else
            clsTransformGroupByFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub

    Private Sub ucrWBControls_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrNudWBCapacity.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged
        clsRTransform.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudWBCapacity.Value & "), replace_NA, accumulate=TRUE)" & Chr(34), iPosition:=2)
        TestOkEnabled()
    End Sub

    Private Sub ucrSpellBetween_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputSpellLower.ControlContentsChanged, ucrInputSpellUpper.ControlContentsChanged
        clsRRainday.AddParameter("function_exp", Chr(34) & "ifelse(" & ucrReceiverData.GetVariableNames(False) & " >= " & ucrInputSpellLower.GetText() & " & " & ucrReceiverData.GetVariableNames(False) & " <= " & ucrInputSpellUpper.GetText() & ", 0, 1)" & Chr(34), iPosition:=2)
        clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday, iPosition:=0)
        clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList, iPosition:=7)
        clsRTransform.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34), iPosition:=2)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged, ucrInputSum.ControlValueChanged, ucrNudSumOver.ControlValueChanged
        SumOver()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputSum_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrInputSum.ControlContentsChanged
        SumOver()
        MovingColNames()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverDOY.ControlContentsChanged, ucrReceiverData.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class