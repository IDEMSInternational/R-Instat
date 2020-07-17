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
    Private clsApproximateFunction, clsAggregateFunction, clsNaLocfFunction, clsSplineFunction, clsNaFillFunction, clsStructTSFunction, clsZooRegFunction As New RFunction
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
        ucrPnlOptions.AddFunctionNamesCondition(rdoSingle, {"na.approx", "na.aggregate", "na.fill", "na.locf", "na.StructTS", "na.spline"})

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

        ucrPnlStartEnd.SetParameter(New RParameter("fill", 1))
        ucrPnlStartEnd.AddRadioButton(rdoLeaveAsMissing, "list(NA, ""extend"", NA)")
        ucrPnlStartEnd.AddRadioButton(rdoExtendFill, Chr(34) & "extend" & Chr(34))
        ucrPnlStartEnd.AddRadioButton(rdoInsertConstant)
        ucrPnlStartEnd.AddParameterValuesCondition(rdoLeaveAsMissing, "fill", "list(NA, ""extend"", NA)")
        ucrPnlStartEnd.AddParameterValuesCondition(rdoExtendFill, "fill", Chr(34) & "extend" & Chr(34))
        ucrPnlStartEnd.AddParameterValuesCondition(rdoInsertConstant, "fill", {"list(NA, ""extend"", NA)", Chr(34) & "extend" & Chr(34)}, False)

        ucrReceiverElement.SetParameter(New RParameter("object", 0))
        ucrReceiverElement.Selector = ucrSelectorInfillMissing
        ucrReceiverElement.SetParameterIsRFunction()
        ucrReceiverElement.bUseFilteredData = False

        ucrInputConstant.SetValidationTypeAsNumeric()
        ucrInputConstant.AddQuotesIfUnrecognised = False

        ucrInputComboFunction.SetParameter(New RParameter("FUN", 2))
        dctFunctionNames.Add("Mean", "mean")
        dctFunctionNames.Add("Median", "median")
        ucrInputComboFunction.SetItems(dctFunctionNames)
        ucrInputComboFunction.SetDropDownStyleAsNonEditable()
        ucrInputComboFunction.SetRDefault("mean")

        ucrChkCopyFromAbove.SetParameter(New RParameter("fromLast", 1))
        ucrChkCopyFromAbove.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkCopyFromAbove.SetText("Copy from Above")
        ucrChkCopyFromAbove.SetRDefault("FALSE")

        ucrChkBy.SetText("By:")
        ucrChkBy.AddParameterPresentCondition(True, "by")
        ucrChkBy.AddParameterPresentCondition(False, "by", False)

        ucrChkMaxGap.SetText("Max Gap:")
        ucrChkMaxGap.AddParameterPresentCondition(True, "maxgap")
        ucrChkMaxGap.AddParameterPresentCondition(False, "maxgap", False)

        ucrReceiverByFactor.SetParameter(New RParameter("by", 1))
        ucrReceiverByFactor.Selector = ucrSelectorInfillMissing
        ucrReceiverByFactor.SetParameterIsRFunction()
        ucrReceiverByFactor.SetIncludedDataTypes({"factor", "character"}, bStrict:=True)
        ucrReceiverByFactor.strSelectorHeading = "Factors"
        ucrReceiverByFactor.SetClimaticType("month")
        ucrReceiverByFactor.bAutoFill = True

        ucrNudMaximum.SetParameter(New RParameter("maxgap", 5))
        ucrNudMaximum.SetMinMax(iNewMin:=1, iNewMax:=Integer.MaxValue)

        ucrPnlStartEnd.AddToLinkedControls(ucrInputConstant, {rdoInsertConstant}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)
        ucrPnlMethods.AddToLinkedControls(ucrInputComboFunction, {rdoNaAggregate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrPnlStartEnd, {rdoNaFill}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrChkCopyFromAbove, {rdoNaLocf}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.AddToLinkedControls(ucrChkBy, {rdoNaAggregate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBy.AddToLinkedControls(ucrReceiverByFactor, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMaxGap.AddToLinkedControls(ucrNudMaximum, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrInputComboFunction.SetLinkedDisplayControl(lblFunction)
        ucrPnlStartEnd.SetLinkedDisplayControl(grpStartEnd)
        ucrNudMaximum.SetLinkedDisplayControl(lblRows)
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

        ucrSelectorInfillMissing.Reset()
        ucrReceiverElement.SetMeAsReceiver()
        ucrSaveNewColumn.Reset()
        'Temp fix: Set panel conditions properly!
        rdoLeaveAsMissing.Checked = True

        clsApproximateFunction.SetPackageName("zoo")
        clsApproximateFunction.SetRCommand("na.approx")
        clsApproximateFunction.AddParameter("rule", 2, iPosition:=1)

        clsAggregateFunction.SetPackageName("zoo")
        clsAggregateFunction.SetRCommand("na.aggregate")

        clsNaLocfFunction.SetPackageName("zoo")
        clsNaLocfFunction.SetRCommand("na.locf")

        clsSplineFunction.SetPackageName("zoo")
        clsSplineFunction.SetRCommand("na.spline")

        clsNaFillFunction.SetPackageName("zoo")
        clsNaFillFunction.SetRCommand("na.fill")
        clsNaFillFunction.AddParameter("fill", "list(NA, ""extend"", NA)", iPosition:=1)

        clsStructTSFunction.SetPackageName("zoo")
        clsStructTSFunction.SetRCommand("na.StructTS")
        clsStructTSFunction.AddParameter("object", clsRFunctionParameter:=clsZooRegFunction, iPosition:=1)

        clsZooRegFunction.SetPackageName("zoo")
        clsZooRegFunction.SetRCommand("zooreg")
        clsZooRegFunction.AddParameter("frequency", 2, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsApproximateFunction)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsAggregateFunction, ucrReceiverElement.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsSplineFunction, ucrReceiverElement.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsNaLocfFunction, ucrReceiverElement.GetParameter(), iAdditionalPairNo:=3)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsNaFillFunction, ucrReceiverElement.GetParameter(), iAdditionalPairNo:=4)
        ucrReceiverElement.AddAdditionalCodeParameterPair(clsZooRegFunction, New RParameter("data", 0), iAdditionalPairNo:=5)

        ucrNudMaximum.AddAdditionalCodeParameterPair(clsAggregateFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=1)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsSplineFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=2)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsNaLocfFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=3)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsNaFillFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=4)
        ucrNudMaximum.AddAdditionalCodeParameterPair(clsStructTSFunction, ucrNudMaximum.GetParameter(), iAdditionalPairNo:=5)

        ucrReceiverElement.SetRCode(clsApproximateFunction, bReset)
        ucrReceiverByFactor.SetRCode(clsAggregateFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlMethods.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputComboFunction.SetRCode(clsAggregateFunction, bReset)
        ucrChkCopyFromAbove.SetRCode(clsNaLocfFunction, bReset)
        ucrPnlStartEnd.SetRCode(clsNaFillFunction, bReset)
        ucrChkBy.SetRCode(clsAggregateFunction, bReset)
        ucrNudMaximum.SetRCode(clsApproximateFunction, bReset)
        ucrChkMaxGap.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrSaveNewColumn.AddAdditionalRCode(clsAggregateFunction, iAdditionalPairNo:=1)
        ucrSaveNewColumn.AddAdditionalRCode(clsSplineFunction, iAdditionalPairNo:=2)
        ucrSaveNewColumn.AddAdditionalRCode(clsNaLocfFunction, iAdditionalPairNo:=3)
        ucrSaveNewColumn.AddAdditionalRCode(clsNaFillFunction, iAdditionalPairNo:=4)
        ucrSaveNewColumn.AddAdditionalRCode(clsStructTSFunction, iAdditionalPairNo:=5)

        ucrSaveNewColumn.SetRCode(clsApproximateFunction, bReset)
    End Sub

    Private Sub ucrPnlMethods_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMethods.ControlValueChanged, ucrReceiverElement.ControlValueChanged
        If rdoNaApproximate.Checked Then
            ucrSaveNewColumn.SetPrefix("Int_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsApproximateFunction)
        ElseIf rdoNaAggregate.Checked Then
            ucrSaveNewColumn.SetPrefix("Ave_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsAggregateFunction)
        ElseIf rdoNaFill.Checked Then
            ucrSaveNewColumn.SetPrefix("Con_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsNaFillFunction)
        ElseIf rdoNaStructTS.Checked Then
            ucrSaveNewColumn.SetPrefix("Str_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsStructTSFunction)
        ElseIf rdoNaSpline.Checked Then
            ucrSaveNewColumn.SetPrefix("Spl_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsSplineFunction)
        ElseIf rdoNaLocf.Checked Then
            ucrSaveNewColumn.SetPrefix("Cop_" & ucrReceiverElement.GetVariableNames(False))
            ucrBase.clsRsyntax.SetBaseRFunction(clsNaLocfFunction)
        End If
    End Sub

    Private Sub ucrPnlStartEnd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStartEnd.ControlValueChanged, ucrInputConstant.ControlValueChanged
        If rdoInsertConstant.Checked Then
            clsNaFillFunction.AddParameter("fill", ucrInputConstant.GetText(), iPosition:=1)
        End If
    End Sub

    Private Sub ucrChkBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBy.ControlValueChanged
        If ucrChkBy.Checked Then
            ucrReceiverByFactor.SetMeAsReceiver()
        Else
            ucrReceiverElement.SetMeAsReceiver()
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverElement.IsEmpty OrElse Not ucrSaveNewColumn.IsComplete Then
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

    Private Sub ucrReceiverElement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrSaveNewColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class