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
Imports instat
Imports instat.Translations
Public Class dlgTransformClimatic
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsRTrasform, clsRSumFuncExpr As New RFunction
    Private clsSumFunction, clsCountFunction, clsSpellFunction, clsWaterBalanceFunction As New RFunction
    Private strCurrDataName As String = ""
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
        ucrReceiverStation.Selector = ucrSelectorTransform
        ucrReceiverYear.Selector = ucrSelectorTransform
        ucrReceiverDate.Selector = ucrSelectorTransform
        ucrReceiverDOY.Selector = ucrSelectorTransform
        ucrReceiverData.Selector = ucrSelectorTransform
        ucrReceiverDate.SetMeAsReceiver()
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDOY.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "doy" & Chr(34)})
        'this is not right
        ucrReceiverData.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "rain" & Chr(34)})
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDOY.bAutoFill = True
        ucrReceiverData.bAutoFill = True
        ucrReceiverYear.bAutoFill = True

        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.SetParameterIsString()
        ucrReceiverData.bWithQuotes = False
        ucrReceiverData.SetParameterIncludeArgumentName(False)

        'ucrSSTDataframe.SetParameter(New RParameter("data_name", 0))
        'ucrSSTDataframe.SetParameterIsrfunction()

        clsRTrasform.SetRCommand("instat_calculation$new")
        'clsRTrasform.SetAssignTo("transform_calculation")
        clsRSumFuncExpr.SetRCommand("rollapply")

        ucrPnlTransform.AddRadioButton(rdoSum)
        ucrPnlTransform.AddRadioButton(rdoCount)
        ucrPnlTransform.AddRadioButton(rdoSpell)
        ucrPnlTransform.AddRadioButton(rdoWaterBalance)

        'ucrPnlTransform.AddParameterIsRFunctionCondition(rdoSum, "clsSumFunction")

        'ucrPnlTransform.AddFunctionNamesCondition(rdoSum, "clsRSumFuncExpr")
        'ucrPnlTransform.AddFunctionNamesCondition(rdoCount, "")
        'ucrPnlTransform.AddFunctionNamesCondition(rdoSpell, "")
        'ucrPnlTransform.AddFunctionNamesCondition(rdoWaterBalance, "")

        ucrNudThreshold.SetParameter(New RParameter("threshold"))
        ucrNudThreshold.SetMinMax(0, 100)
        ucrNudThreshold.Increment = 0.01
        ucrNudThreshold.DecimalPlaces = 2
        ucrNudThreshold.SetRDefault("0.85")

        ucrInputSum.SetParameter(New RParameter("FUN"))
        dctInputSumPairs.Add("sum", "sum")
        dctInputSumPairs.Add("max", "max")
        dctInputSumPairs.Add("min", "min")
        dctInputSumPairs.Add("mean", "mean")
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

        ucrChkValuesUnderthreshold.SetParameter(New RParameter("values_under_threshold"))
        ucrChkValuesUnderthreshold.SetText("Values Under Threshold")
        ucrChkValuesUnderthreshold.SetLinkedDisplayControl(lblCountRows)

        ucrInputSpellLower.SetValidationTypeAsNumeric()
        ucrInputSpellLower.SetParameter(New RParameter("spell_lower"))
        ucrInputSpellLower.SetLinkedDisplayControl(lblValuesBetween)

        ucrInputSpellUpper.SetValidationTypeAsNumeric()
        ucrInputSpellUpper.SetParameter(New RParameter("spell_upper"))
        ucrInputSpellUpper.SetLinkedDisplayControl(lblSpellAnd)

        ucrNudWBCapacity.SetParameter(New RParameter("capacity"))
        ucrNudWBCapacity.SetMinMax(1, 366)
        ucrNudWBCapacity.Increment = 1
        ucrNudWBCapacity.SetLinkedDisplayControl(lblWBCapacity)
        'ucrNudWBCapacity.SetRDefault("60")

        ucrInputEvaporation.SetValidationTypeAsNumeric()
        ucrInputEvaporation.SetParameter(New RParameter("evaporation"))
        ucrInputEvaporation.SetLinkedDisplayControl(lblWBEvaporation)

        'ucrSaveTransform.SetParameter(New RParameter("result_name"))

        ucrInputColName.SetParameter(New RParameter("result_name"))

        'ucrInputColName.SetPrefix("sum")
        ucrInputColName.SetName("sum")

        ucrPnlTransform.AddToLinkedControls({ucrInputSum, ucrNudSumOver}, {rdoSum}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudCountOver, ucrChkValuesUnderthreshold}, {rdoCount}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrInputSpellLower, ucrInputSpellUpper}, {rdoSpell}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransform.AddToLinkedControls({ucrNudWBCapacity, ucrInputEvaporation}, {rdoWaterBalance}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsSumFunction = New RFunction
        clsCountFunction = New RFunction
        clsSpellFunction = New RFunction
        clsWaterBalanceFunction = New RFunction
        'ucrSaveTransform.Reset()
        ucrSelectorTransform.Reset()
        rdoSum.Checked = True 'this wil be fixed properly

        'Temporary disable
        rdoCount.Enabled = False
        rdoSpell.Enabled = False
        rdoWaterBalance.Enabled = False
        grpCount.Enabled = False
        grpSpells.Enabled = False
        grpWaterbalance.Enabled = False

        clsRSumFuncExpr.AddParameter("data", ucrReceiverData.GetVariableNames(bWithQuotes:=False))
        clsRSumFuncExpr.AddParameter("fill", "NA")
        clsRSumFuncExpr.AddParameter("width", 1)
        clsRSumFuncExpr.AddParameter("FUN", "sum")
        clsRSumFuncExpr.AddParameter("align", Chr(39) & "right" & Chr(39))
        clsRTrasform.AddParameter("function_exp", Chr(34) & clsRSumFuncExpr.ToScript.ToString & Chr(34))
        clsRTrasform.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsRTrasform.AddParameter("result_name", Chr(34) & "sum" & Chr(34))
        'This might not Beep right
        'clsRTrasform.AddParameter("result_name", Chr(34) & ucrSaveTransform.ucrInputTextSave.GetText & Chr(34))
        clsRTrasform.AddParameter("save", 2)
        clsSumFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        clsSumFunction.AddParameter("display", "FALSE")
        clsSumFunction.AddParameter("calc", clsRFunctionParameter:=clsRTrasform)
        ucrBase.clsRsyntax.SetBaseRFunction(clsSumFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudSumOver.SetRCode(clsRSumFuncExpr, bReset)
        ucrReceiverData.SetRCode(clsRSumFuncExpr, bReset)
        'ucrSaveTransform.SetRCode(clsRTrasform, bReset)
        ucrInputSum.SetRCode(clsRSumFuncExpr, bReset)
        ucrInputColName.SetRCode(clsRTrasform, bReset)
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
        If rdoSum.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSumFunction)
            'ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsRTrasform)
            'ucrSaveTransform.SetPrefix("Sum")
            'ucrInputColName.SetPrefix("Sum")
            ucrInputColName.SetName("Sum")
            grpTransform.Text = "Sum"
        ElseIf rdoCount.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
            'ucrSaveTransform.SetPrefix("Count")
            'ucrInputColName.SetPrefix("Count")
            ucrInputColName.SetName("Count")
            grpTransform.Text = "Count"
        ElseIf rdoSpell.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSpellFunction)
            'ucrSaveTransform.SetPrefix("Spell")
            'ucrInputColName.SetPrefix("Spell")
            ucrInputColName.SetName("Spell")
            grpTransform.Text = "Spell"
        ElseIf rdoWaterBalance.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsWaterBalanceFunction)
            'ucrSaveTransform.SetPrefix("Water_balance")
            'ucrInputColName.SetPrefix("Water_balance")
            ucrInputColName.SetName("Water_balance")
            grpTransform.Text = "Water_balance"
        End If
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged ' add more teskok controls
        TestOkEnabled()
    End Sub

    Private Sub sum_over()
        If Not ucrReceiverData.IsEmpty Then
            clsRTrasform.AddParameter("function_exp", Chr(34) & clsRSumFuncExpr.ToScript.ToString & Chr(34))
        End If
    End Sub

    Private Sub ucrSelectorTransform_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrSelectorTransform.ControlContentsChanged
        strCurrDataName = Chr(34) & ucrSelectorTransform.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34)
        clsRTrasform.AddParameter("calculated_from", " list(" & strCurrDataName & "=" & ucrReceiverData.GetVariableNames() & ")")
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged, ucrInputSum.ControlContentsChanged, ucrNudSumOver.ControlContentsChanged
        sum_over()
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlValueChanged, ucrInputSum.ControlValueChanged, ucrNudSumOver.ControlValueChanged
        sum_over()
    End Sub
End Class