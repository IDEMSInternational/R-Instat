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

Public Class dlgInfillMissingValues
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsApproximateFunction, clsAggregateFunction, clsNaLocfFunction, clsSplineFunction, clsNaFillFunction, clsStructTSFunction, clsZooRegFunction, clsSetSeedFunction, clsAveFunction As New RFunction
    Private clsBracketOperator As New ROperator
    Private clsNewObject As New RCodeStructure
    Private Sub dlgInfillMissingValues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctFunctionNames As New Dictionary(Of String, String)

        rdoNeighbouring.Enabled = False
        rdoMultiple.Enabled = False
        ucrPnlOptions.AddRadioButton(rdoSingle)
        ucrPnlOptions.AddFunctionNamesCondition(rdoSingle, {"ave", "na.aggregate"})

        ucrPnlMethods.AddRadioButton(rdoNaAggregate)
        ucrPnlMethods.AddRadioButton(rdoNaApproximate)
        ucrPnlMethods.AddRadioButton(rdoNaFill)
        ucrPnlMethods.AddRadioButton(rdoNaLocf)
        ucrPnlMethods.AddRadioButton(rdoNaStructTS)
        ucrPnlMethods.AddRadioButton(rdoNaSpline)

        ucrPnlMethods.AddFunctionNamesCondition(rdoNaApproximate, "na.approx")
        ucrPnlMethods.AddFunctionNamesCondition(rdoNaAggregate, "na.aggregate")
        ucrPnlMethods.AddFunctionNamesCondition(rdoNaFill, "na.fill")
        ucrPnlMethods.AddFunctionNamesCondition(rdoNaLocf, "na.locf")
        ucrPnlMethods.AddFunctionNamesCondition(rdoNaStructTS, "na.StructTS")
        ucrPnlMethods.AddFunctionNamesCondition(rdoNaSpline, "na.spline")

        ucrPnlStartEnd.AddRadioButton(rdoLeaveAsMissing)
        ucrPnlStartEnd.AddRadioButton(rdoExtendFill)

        ucrReceiverElement.SetParameter(New RParameter("x", 0))
        ucrReceiverElement.Selector = ucrSelectorInfillMissing
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.bUseFilteredData = False

        ucrReceiverStation.SetParameter(New RParameter("factor", 1, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorInfillMissing
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bUseFilteredData = False
        ucrReceiverStation.bAutoFill = True

        ucrInputConstant.SetValidationTypeAsNumeric()
        ucrInputConstant.AddQuotesIfUnrecognised = False

        ucrInputComboFunction.SetParameter(New RParameter("FUN", 2))
        dctFunctionNames.Add("Mean", "summary_mean")
        dctFunctionNames.Add("Median", "summary_median")
        dctFunctionNames.Add("Sample", "summary_sample")
        ucrInputComboFunction.SetItems(dctFunctionNames)
        ucrInputComboFunction.SetDropDownStyleAsNonEditable()

        ucrChkCopyFromBelow.SetParameter(New RParameter("fromLast", 1))
        ucrChkCopyFromBelow.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCopyFromBelow.SetText("Copy from Below")
        ucrChkCopyFromBelow.SetRDefault("FALSE")

        ucrChkBy.SetText("By:")
        ucrChkBy.AddParameterPresentCondition(True, "by")
        ucrChkBy.AddParameterPresentCondition(False, "by", False)

        ucrChkMaxGap.SetText("Max Gap:")
        ucrChkMaxGap.AddParameterPresentCondition(True, "maxgap")
        ucrChkMaxGap.AddParameterPresentCondition(False, "maxgap", False)

        ucrReceiverByFactor.SetParameter(New RParameter("by", 1, bNewIncludeArgumentName:=False))
        ucrReceiverByFactor.Selector = ucrSelectorInfillMissing
        ucrReceiverByFactor.SetParameterIsRFunction()
        ucrReceiverByFactor.SetIncludedDataTypes({"factor", "character"}, bStrict:=True)
        ucrReceiverByFactor.strSelectorHeading = "Factors and Characters"
        ucrReceiverByFactor.SetClimaticType("month")
        ucrReceiverByFactor.bAutoFill = True

        ucrNudMaximum.SetParameter(New RParameter("maxgap", 5))
        ucrNudMaximum.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)

        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))

        ucrChkSetSeed.SetText("Set Seed:")
        ucrChkSetSeed.AddRSyntaxContainsFunctionNamesCondition(True, {"set.seed"})
        ucrChkSetSeed.AddRSyntaxContainsFunctionNamesCondition(False, {"set.seed"}, False)

        ucrPnlStartEnd.AddToLinkedControls(ucrInputConstant, {rdoLeaveAsMissing, rdoExtendFill}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboFunction, {rdoNaAggregate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrReceiverStation, {rdoNaApproximate, rdoNaFill, rdoNaSpline, rdoNaLocf, rdoNaStructTS}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrPnlStartEnd, {rdoNaFill}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrChkCopyFromBelow, {rdoNaLocf}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrChkBy, {rdoNaAggregate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBy.AddToLinkedControls(ucrReceiverByFactor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMaxGap.AddToLinkedControls(ucrNudMaximum, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrInputComboFunction.AddToLinkedControls(ucrChkSetSeed, {"Sample"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSetSeed.AddToLinkedControls(ucrNudSetSeed, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrInputComboFunction.SetLinkedDisplayControl(lblFunction)
        ucrPnlStartEnd.SetLinkedDisplayControl(grpStartEnd)
        ucrNudMaximum.SetLinkedDisplayControl(lblRows)
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrInputConstant.SetLinkedDisplayControl(lblValue)
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorInfillMissing.ucrAvailableDataFrames)
        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetIsComboBox()
        ucrSaveNewColumn.SetLabelText("New Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsApproximateFunction = New RFunction
        clsAggregateFunction = New RFunction
        clsNaLocfFunction = New RFunction
        clsSplineFunction = New RFunction
        clsNaFillFunction = New RFunction
        clsStructTSFunction = New RFunction
        clsZooRegFunction = New RFunction
        clsSetSeedFunction = New RFunction
        clsAveFunction = New RFunction

        clsBracketOperator = New ROperator

        ucrSelectorInfillMissing.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        ucrSaveNewColumn.Reset()
        'Temp fix: Set panel conditions properly!
        rdoLeaveAsMissing.Checked = True
        rdoNaApproximate.Checked = True
        ucrInputConstant.SetName("0")

        clsApproximateFunction.SetPackageName("zoo")
        clsApproximateFunction.SetRCommand("na.approx")
        clsApproximateFunction.AddParameter("x", "x", iPosition:=0, bIncludeArgumentName:=False)
        clsApproximateFunction.AddParameter("rule", 2, iPosition:=1)

        clsAggregateFunction.SetPackageName("zoo")
        clsAggregateFunction.SetRCommand("na.aggregate")
        clsAggregateFunction.AddParameter("FUN", "summary_mean", iPosition:=2)

        clsSetSeedFunction.SetRCommand("set.seed")

        clsNaLocfFunction.SetPackageName("zoo")
        clsNaLocfFunction.SetRCommand("na.locf0")
        clsNaLocfFunction.AddParameter("x", "x", iPosition:=0, bIncludeArgumentName:=False)

        clsSplineFunction.SetPackageName("zoo")
        clsSplineFunction.SetRCommand("na.spline")
        clsSplineFunction.AddParameter("x", "x", iPosition:=0, bIncludeArgumentName:=False)

        clsNaFillFunction.SetPackageName("zoo")
        clsNaFillFunction.SetRCommand("na.fill")
        clsNaFillFunction.AddParameter("x", "x", iPosition:=0, bIncludeArgumentName:=False)

        clsStructTSFunction.SetPackageName("zoo")
        clsStructTSFunction.SetRCommand("na.StructTS")
        clsStructTSFunction.AddParameter("object", clsRFunctionParameter:=clsZooRegFunction, iPosition:=1)

        clsZooRegFunction.SetPackageName("zoo")
        clsZooRegFunction.SetRCommand("zooreg")
        clsZooRegFunction.AddParameter("frequency", 2, iPosition:=0)
        clsZooRegFunction.AddParameter("x", "x", iPosition:=0, bIncludeArgumentName:=False)

        clsAveFunction.SetPackageName("stats")
        clsAveFunction.SetRCommand("ave")

        clsBracketOperator.SetOperation(")")
        clsBracketOperator.AddParameter("left", "function(x", iPosition:=0)
        clsBracketOperator.bBrackets = False
        clsBracketOperator.bSpaceAroundOperation = False

        ucrBase.clsRsyntax.ClearCodes()
        clsNewObject = clsAggregateFunction
        ucrBase.clsRsyntax.SetBaseRFunction(clsAveFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsAggregateFunction, New RParameter("object", 0), iAdditionalPairNo:=1)

        ucrNudMaximum.AddAdditionalCodeParameterPair(clsAggregateFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=1)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsSplineFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=2)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsNaLocfFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=3)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsNaFillFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=4)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsStructTSFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=5)

        ucrReceiverElement.SetRCode(clsAveFunction, bReset)
        ucrReceiverStation.SetRCode(clsAveFunction, bReset)
        ucrReceiverByFactor.SetRCode(clsAggregateFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        'ucrPnlMethods.SetRCode(clsNewObject, bReset)
        ucrInputComboFunction.SetRCode(clsAggregateFunction, bReset)
        ucrChkCopyFromBelow.SetRCode(clsNaLocfFunction, bReset)
        ucrChkBy.SetRCode(clsAggregateFunction, bReset)
        ucrNudMaximum.SetRCode(clsApproximateFunction, bReset)
        ucrChkMaxGap.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeedFunction, bReset)
        ucrChkSetSeed.SetRSyntax(ucrBase.clsRsyntax, bReset)

        ucrSaveNewColumn.AddAdditionalRCode(clsAggregateFunction, iAdditionalPairNo:=1)

        ucrSaveNewColumn.SetRCode(clsAveFunction, bReset)
    End Sub

    Private Sub ucrPnlMethods_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethods.ControlValueChanged, ucrReceiverElement.ControlValueChanged
        ucrBase.clsRsyntax.SetBaseRFunction(clsAveFunction)
        clsNewObject = clsBracketOperator
        If rdoNaApproximate.Checked Then
            ucrSaveNewColumn.SetPrefix("Int_" & ucrReceiverElement.GetVariableNames(False))
            clsBracketOperator.AddParameter("right", clsRFunctionParameter:=clsApproximateFunction, iPosition:=1)
        ElseIf rdoNaAggregate.Checked Then
            ucrReceiverElement.SetMeAsReceiver()
            ucrSaveNewColumn.SetPrefix("Typ_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsAggregateFunction)
            clsNewObject = clsAggregateFunction
        ElseIf rdoNaFill.Checked Then
            ucrSaveNewColumn.SetPrefix("Con_" & ucrReceiverElement.GetVariableNames(False))
            clsBracketOperator.AddParameter("right", clsRFunctionParameter:=clsNaFillFunction, iPosition:=1)
        ElseIf rdoNaStructTS.Checked Then
            ucrSaveNewColumn.SetPrefix("Str_" & ucrReceiverElement.GetVariableNames(False))
            clsBracketOperator.AddParameter("right", clsRFunctionParameter:=clsStructTSFunction, iPosition:=1)
        ElseIf rdoNaSpline.Checked Then
            ucrSaveNewColumn.SetPrefix("Spl_" & ucrReceiverElement.GetVariableNames(False))
            clsBracketOperator.AddParameter("right", clsRFunctionParameter:=clsSplineFunction, iPosition:=1)
        ElseIf rdoNaLocf.Checked Then
            ucrSaveNewColumn.SetPrefix("Cop_" & ucrReceiverElement.GetVariableNames(False))
            clsBracketOperator.AddParameter("right", clsRFunctionParameter:=clsNaLocfFunction, iPosition:=1)
        End If
        clsAveFunction.AddParameter("FUN", clsROperatorParameter:=clsBracketOperator, iPosition:=2)
    End Sub

    Private Sub ucrPnlStartEnd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStartEnd.ControlValueChanged, ucrInputConstant.ControlValueChanged
        If rdoLeaveAsMissing.Checked Then
            clsNaFillFunction.AddParameter("fill", "list(" & "NA," & ucrInputConstant.GetValue() & ",NA" & ")", iPosition:=1)
        ElseIf rdoExtendFill.Checked Then
            clsNaFillFunction.AddParameter("fill", "list(" & Chr(34) & "extend" & Chr(34) & "," & ucrInputConstant.GetValue() & "," & Chr(34) & "extend" & Chr(34) & ")", iPosition:=1)
        Else
            clsNaFillFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub ucrChkBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBy.ControlValueChanged
        If ucrChkBy.Checked Then
            ucrReceiverByFactor.SetMeAsReceiver()
        Else
            ucrReceiverElement.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrInputComboFunction_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboFunction.ControlValueChanged, ucrPnlMethods.ControlValueChanged, ucrChkSetSeed.ControlValueChanged
        If rdoNaAggregate.Checked Then
            If ucrChkSetSeed.Checked Then
                Select Case ucrInputComboFunction.GetValue()
                    Case "Sample"
                        ucrBase.clsRsyntax.AddToBeforeCodes(clsSetSeedFunction, 0)
                    Case Else
                        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSetSeedFunction)
                End Select
            Else
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSetSeedFunction)
            End If
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSetSeedFunction)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverElement.IsEmpty OrElse Not ucrSaveNewColumn.IsComplete OrElse (rdoNaFill.Checked AndAlso ((rdoLeaveAsMissing.Checked OrElse rdoExtendFill.Checked) AndAlso ucrInputConstant.IsEmpty)) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSaveNewColumn.ControlContentsChanged, ucrPnlStartEnd.ControlContentsChanged, ucrInputConstant.ControlContentsChanged, ucrPnlMethods.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class