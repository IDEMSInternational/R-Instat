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
    Private clsRTransform, clsRRollFuncExpr, clsMatchFun, clsTransformManipulationsFunc, clsTransfornGroupByFunc, clsReplaceNA60, clsWaterBalance60, clsSubCalcList As New RFunction
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
        ucrBase.iHelpTopicID = 358

        Dim dctInputSumPairs As New Dictionary(Of String, String)

        ' Setting receivers
        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDOY.Selector = ucrSelectorTransform

        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        'this is not right
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverYear.bAutoFill = True


        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False
        ucrReceiverData.SetParameterIncludeArgumentName(False)
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverData.bAutoFill = True

        'ucrSSTDataframe.SetParameter(New RParameter("data_name", 0))
        'ucrSSTDataframe.SetParameterIsrfunction()

        clsRTransform.SetRCommand("instat_calculation$new")
        clsRTransform.SetAssignTo("transform_calculation")
        'clsRSumFuncExpr.SetRCommand("rollapply")

        'clsMatchFun.SetRCommand("match.fun")


        ucrPnlTransform.AddRadioButton(rdoMoving)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)

        'ucrPnlTransform.AddParameterIsRFunctionCondition(rdoSum, "clsSumFunction")

        'ucrPnlTransform.AddFunctionNamesCondition(rdoSum, "clsRSumFuncExpr")
        'ucrPnlTransform.AddFunctionNamesCondition(rdoCount, "")
        'ucrPnlTransform.AddFunctionNamesCondition(rdoSpell, "")
        'ucrPnlTransform.AddFunctionNamesCondition(rdoWaterBalance, "")

        ucrInputThreshold.SetParameter(New RParameter("threshold"))
        ucrInputThreshold.SetValidationTypeAsNumeric()
        ucrInputThreshold.SetLinkedDisplayControl(lblThreshold)

        ucrInputSum.SetParameter(New RParameter("FUN"))
        dctInputSumPairs.Add("sum", Chr(39) & "sum" & Chr(39))
        dctInputSumPairs.Add("max", Chr(39) & "max" & Chr(39))
        dctInputSumPairs.Add("min", Chr(39) & "min" & Chr(39))
        dctInputSumPairs.Add("mean", Chr(39) & "mean" & Chr(39))
        ucrInputSum.SetItems(dctInputSumPairs)
        ucrInputSum.SetLinkedDisplayControl(lblSumOver)

        ucrNudSumOver.SetParameter(New RParameter("width"))
        ucrNudSumOver.SetMinMax(1, 366)
        ucrNudSumOver.Increment = 1
        ucrNudSumOver.SetLinkedDisplayControl(lblSumRows)
        'ucrNudSumOver.SetRDefault("3")

        ucrNudCountOver.SetParameter(New RParameter("count_over"))
        ucrNudCountOver.SetMinMax(1, 366)
        ucrNudCountOver.Increment = 1
        ucrNudCountOver.SetLinkedDisplayControl(lblCountOver)
        'ucrNudCountOver.SetRDefault("3")

        'ucrChkValuesUnderthreshold.SetParameter(New RParameter("values_under_threshold"))
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
        'ucrNudWBCapacity.SetRDefault("60")

        ucrInputEvaporation.SetParameter(New RParameter("evaporation"))
        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.SetLinkedDisplayControl(lblWBEvaporation)

        'ucrSaveTransform.SetParameter(New RParameter("result_name"))

        ucrInputColName.SetParameter(New RParameter("result_name"))

        clsSubCalcList.SetRCommand("list")
        'ucrInputColName.SetPrefix("sum")
        'ucrInputColName.SetName("moving")

        ucrPnlTransform.AddToLinkedControls({ucrInputSum, ucrNudSumOver}, {rdoMoving}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver, ucrChkValuesUnderThreshold}, {rdoCount}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrInputSpellLower, ucrInputSpellUpper}, {rdoSpell}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudWBCapacity, ucrInputEvaporation}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        'clsRTrasform = New RFunction
        clsRRollFuncExpr = New RFunction
        clsMatchFun = New RFunction
        clsRollFunction = New RFunction
        'clsSpellFunction = New RFunction
        ' clsWaterBalanceFunction = New RFunction
        clsTransformManipulationsFunc = New RFunction
        clsTransfornGroupByFunc = New RFunction
        'ucrSaveTransform.Reset()

        rdoMoving.Checked = True 'this wil be fixed properly
        ucrSelectorTransform.Reset()
        ucrReceiverDate.SetMeAsReceiver()
        ucrInputColName.SetName("moving")
        ucrInputThreshold.SetName(0.85)
        ucrInputEvaporation.SetName(5)
        ucrNudCountOver.Value = 1
        ucrNudWBCapacity.Value = 60
        ucrChkValuesUnderThreshold.Checked = False

        'Temporary disable
        rdoCount.Enabled = True
        rdoSpell.Enabled = True
        rdoWaterBalance.Enabled = True
        grpCount.Enabled = True
        grpSpells.Enabled = True
        grpWaterbalance.Enabled = True

        clsTransformManipulationsFunc.SetRCommand("list")
        clsTransformManipulationsFunc.AddParameter("group_by", clsRFunctionParameter:=clsTransfornGroupByFunc, bIncludeArgumentName:=False)

        clsTransfornGroupByFunc.SetRCommand("instat_calculation$new")
        clsTransfornGroupByFunc.AddParameter("type", Chr(34) & "by" & Chr(34))
        clsTransfornGroupByFunc.SetAssignTo("grouping")

        'clsRTransform.SetRCommand("instat_calculation$new")
        'clsRTransform.SetAssignTo("transform_calculation")
        clsRRollFuncExpr.SetPackageName("zoo")
        clsRRollFuncExpr.SetRCommand("rollapply")

        clsMatchFun.SetRCommand("match.fun")
        clsMatchFun.AddParameter("FUN", Chr(39) & "sum" & Chr(39))

        clsRRollFuncExpr.AddParameter("data", ucrReceiverData.GetVariableNames(bWithQuotes:=False))
        clsRRollFuncExpr.AddParameter("fill", "NA")
        clsRRollFuncExpr.AddParameter("width", 1)
        clsRRollFuncExpr.AddParameter("FUN", clsRFunctionParameter:=clsMatchFun)
        clsRRollFuncExpr.AddParameter("align", Chr(39) & "right" & Chr(39))
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34))
        clsRTransform.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRTransform.AddParameter("result_name", Chr(34) & "moving" & Chr(34))
        clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc)

        clsReplaceNA60.SetRCommand("instat_calculation$new")
        clsReplaceNA60.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsReplaceNA60.AddParameter("function_exp", Chr(34) & "replace(" & ucrReceiverData.GetVariableNames(False) & ", is.na( " & ucrReceiverData.GetVariableNames(False) & "), 60)" & Chr(34))
        clsReplaceNA60.AddParameter("result_name", Chr(34) & "Replace_NA_60" & Chr(34))
        clsReplaceNA60.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
        clsReplaceNA60.AddParameter("save", "0") ' has save = 2on rcode
        clsReplaceNA60.SetAssignTo("Replace_NA_60")

        clsWaterBalance60.SetRCommand("instat_calculation$new")
        clsWaterBalance60.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        'clsWaterBalance60.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudWBCapacity.Value & "), Replace_NA_60, accumulate=TRUE)" & Chr(34))
        'clsWaterBalance60.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & 5 & ", 0), " & 60 & "), Replace_NA_60, accumulate=TRUE)" & Chr(34))
        clsWaterBalance60.AddParameter("result_name", Chr(34) & "Water_Balance_60" & Chr(34))
        clsWaterBalance60.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList)
        clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA60)
        clsWaterBalance60.AddParameter("save", "2")
        clsWaterBalance60.SetAssignTo("Water_Balance_60")

        clsRRainday.SetRCommand("instat_calculation$new")
        clsRRainday.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        ' "match(Rain>=0.85,1, nomatch = 0)"
        clsRRainday.AddParameter("function_exp", Chr(34) & "match(" & ucrReceiverData.GetVariableNames(False) & ">=0.85, 1, nomatch = 0)" & Chr(34))
        clsRRainday.AddParameter("result_name", Chr(34) & "rain_day" & Chr(34))
        clsRRainday.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
        clsRRainday.AddParameter("save", "0") ' has save = 2on rcode
        clsRRainday.SetAssignTo("rain_day")

        'This might not Beep right
        'clsRTransform.AddParameter("result_name", Chr(34) & ucrSaveTransform.ucrInputTextSave.GetText & Chr(34))
        clsRTransform.AddParameter("save", 2)
        clsRollFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsRollFunction.AddParameter("display", "FALSE")
        clsRollFunction.AddParameter("calc", clsRFunctionParameter:=clsRTransform)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudSumOver.SetRCode(clsRRollFuncExpr, bReset)
        ucrReceiverData.SetRCode(clsRRollFuncExpr, bReset)
        'ucrSaveTransform.SetRCode(clsRTrasform, bReset)
        ucrInputSum.SetRCode(clsMatchFun, bReset)
        ucrInputColName.SetRCode(clsRTransform, bReset)
        'ucrPnlTransform.SetRCode(clsRSumFuncExpr, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlTransform_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransform.ControlContentsChanged
        If rdoMoving.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
            clsRRollFuncExpr.AddParameter("FUN", clsRFunctionParameter:=clsMatchFun)
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34))
            'ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsRTrasform)
            'ucrSaveTransform.SetPrefix("Sum")
            'ucrInputColName.SetPrefix("Sum")
            ucrInputColName.SetName("moving")
            grpTransform.Text = "Moving"
            clsRTransform.RemoveParameterByName("sub_calculations")
        ElseIf rdoCount.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
            'ucrSaveTransform.SetPrefix("Count")
            'ucrInputColName.SetPrefix("Count")
            ucrInputColName.SetName("count")
            grpTransform.Text = "Count"
            clsRRollFuncExpr.AddParameter("FUN", "function(x) length(which(x" & strValuesUnder & ucrInputThreshold.GetText() & "))")
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34))
            clsRTransform.RemoveParameterByName("sub_calculations")
        ElseIf rdoSpell.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
            'clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsWaterBalance60List)
            clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsRRainday)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList)

            clsRTransform.AddParameter("function_exp", Chr(34) & "cumsum(rain_day==0)-cummax((rain_day)*cumsum(rain_day==0))" & Chr(34))
            'ucrSaveTransform.SetPrefix("Spell")
            'ucrInputColName.SetPrefix("Spell")
            ucrInputColName.SetName("spell")
            grpTransform.Text = "Spell"
        ElseIf rdoWaterBalance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRollFunction)
            clsSubCalcList.AddParameter("sub1", clsRFunctionParameter:=clsReplaceNA60)
            clsRTransform.AddParameter("sub_calculations", clsRFunctionParameter:=clsSubCalcList)
            clsRTransform.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudWBCapacity.Value & "), Replace_NA_60, accumulate=TRUE)" & Chr(34))
            'clsWaterBalance60.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudWBCapacity.Value & "), Replace_NA_60, accumulate=TRUE)" & Chr(34))

            'clsRollFunction.AddParameter("calc", clsRFunctionParameter:=clsWaterBalance60)

            'ucrSaveTransform.SetPrefix("Water_balance")
            'ucrInputColName.SetPrefix("Water_balance")
            ucrInputColName.SetName("water_balance")
            grpTransform.Text = "Water_balance"
        End If
    End Sub

    Private Sub SumOver()
        If Not ucrReceiverData.IsEmpty Then
            'clsRSumFuncExpr.AddParameter("FUN", clsRFunctionParameter:=clsMatchFun)
            clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34))
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        'If Not ucrReceiverStation.IsEmpty Then
        '    clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc)

        '    strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        'Else
        clsRTransform.SetAssignTo("transform_calculation")
        clsWaterBalance60.SetAssignTo("water_balance_60")
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrSelectorTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsRTransform.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged, ucrInputSum.ControlContentsChanged, ucrNudSumOver.ControlContentsChanged
        SumOver()
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged, ucrInputSum.ControlValueChanged, ucrNudSumOver.ControlValueChanged
        SumOver()
    End Sub

    Private Sub ucrCountOver_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrNudCountOver.ControlContentsChanged
        clsRRollFuncExpr.AddParameter("width", ucrNudCountOver.Value)
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34))
    End Sub

    Private Sub ucrValuesUnder_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrChkValuesUnderThreshold.ControlContentsChanged, ucrInputThreshold.ControlContentsChanged
        If ucrChkValuesUnderThreshold.Checked Then
            strValuesUnder = "<"
        Else
            strValuesUnder = ">="
        End If
        clsRRollFuncExpr.AddParameter("FUN", "function(x) length(which(x" & strValuesUnder & ucrInputThreshold.GetText() & "))")
        clsRTransform.AddParameter("function_exp", Chr(34) & clsRRollFuncExpr.ToScript.ToString & Chr(34))
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged ' add more teskok controls
        TestOkEnabled()
    End Sub

    Private Sub SetGroupByFuncCalcFrom()
        Dim strCurrDataName As String = ""
        Dim strGroupByCalcFrom As String = ""

        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)

        'If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverStation.IsEmpty Then
        '    strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ", " & strCurrDataName & "=" & ucrReceiverStations.GetVariableNames() & ")"
        'ElseIf Not ucrReceiverYear.IsEmpty Then
        '    strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverYear.GetVariableNames() & ")"
        If Not ucrReceiverStation.IsEmpty Then
            clsTransfornGroupByFunc.SetAssignTo("grouping")
            clsRTransform.AddParameter("manipulations", clsRFunctionParameter:=clsTransformManipulationsFunc)

            strGroupByCalcFrom = "list(" & strCurrDataName & "=" & ucrReceiverStation.GetVariableNames() & ")"
        Else
            clsRTransform.RemoveParameterByName("manipulations")

        End If
        If strGroupByCalcFrom <> "" Then
            clsTransfornGroupByFunc.AddParameter("calculated_from", strGroupByCalcFrom)
        Else
            clsTransfornGroupByFunc.RemoveParameterByName("calculated_from")
        End If
    End Sub
    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        SetGroupByFuncCalcFrom()
    End Sub

    Private Sub ucrWBControls_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrNudWBCapacity.ControlContentsChanged, ucrInputEvaporation.ControlContentsChanged
        clsRTransform.AddParameter("function_exp", Chr(34) & "Reduce(function(x, y) pmin(pmax(x + y - " & ucrInputEvaporation.GetText() & ", 0), " & ucrNudWBCapacity.Value & "), Replace_NA_60, accumulate=TRUE)" & Chr(34))
    End Sub

End Class