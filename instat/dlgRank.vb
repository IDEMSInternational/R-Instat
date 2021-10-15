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

Public Class dlgRank
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRankFunction As New RFunction
    Private clsSortFunction As New RFunction
    Private clsRoundFunction As New RFunction
    Private clsSignifFunction As New RFunction
    Private clsLagFunction As New RFunction
    Private clsLeadFunction As New RFunction
    Private clsDiffFunction As New RFunction
    Private clsCallDiffFunction As New RFunction
    Private clsScaleFunction As New RFunction
    Private clsReplicateFunction As New RFunction
    Private clsMeanFunction As New RFunction
    Private clsStandardDevFunction As New RFunction
    Private clsDeviationFunction As New RFunction
    Private clsSubtractOperator As New ROperator
    Private clsDivisionOperator As New ROperator

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
        ucrBase.iHelpTopicID = 25

        ucrPnlTransformOptions.AddRadioButton(rdoRank)
        ucrPnlTransformOptions.AddRadioButton(rdoNumeric)
        ucrPnlTransformOptions.AddRadioButton(rdoSort)
        'ucrPnlTransformOptions.AddRadioButton(rdoNonNegative)

        ucrPnlTransformOptions.AddFunctionNamesCondition(rdoRank, "rank")
        ucrPnlTransformOptions.AddFunctionNamesCondition(rdoNumeric, {"round", "signif", "lag", "lead", "c", "scale"})
        ucrPnlTransformOptions.AddFunctionNamesCondition(rdoSort, "sort")

        ucrPnlTransformOptions.AddToLinkedControls({ucrPnlTies, ucrPnlMissingValues}, {rdoRank}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls({ucrChkDecreasing, ucrChkMissingLast}, {rdoSort}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTransformOptions.AddToLinkedControls(ucrPnlNumericOptions, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Setting Parameters and Data types allowed
        ucrReceiverRank.SetParameter(New RParameter("x", 0))
        ucrReceiverRank.Selector = ucrSelectorForRank
        ucrReceiverRank.SetMeAsReceiver()
        ucrReceiverRank.bUseFilteredData = False
        ucrReceiverRank.SetParameterIsRFunction()
        ucrReceiverRank.SetLinkedDisplayControl(lblSelectColumns)

        ucrPnlMissingValues.SetParameter(New RParameter("na.last", 1))
        ucrPnlMissingValues.AddRadioButton(rdoKeptAsMissing, Chr(34) & "keep" & Chr(34))
        ucrPnlMissingValues.AddRadioButton(rdoFirstMissingValues, "FALSE")
        ucrPnlMissingValues.AddRadioButton(rdoLast, "TRUE")
        ucrPnlMissingValues.SetRDefault("TRUE")
        ucrPnlMissingValues.SetLinkedDisplayControl(grpMissingValues)

        'Setting Parameters for the respective radio buttons
        ucrPnlTies.SetParameter(New RParameter("ties.method", 2))
        ucrPnlTies.AddRadioButton(rdoAverage, Chr(34) & "average" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoMinimum, Chr(34) & "min" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoMaximum, Chr(34) & "max" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoFirst, Chr(34) & "first" & Chr(34))
        ucrPnlTies.AddRadioButton(rdoRandom, Chr(34) & "random" & Chr(34))
        ucrPnlTies.SetRDefault(Chr(34) & "average" & Chr(34))
        ucrPnlTies.SetLinkedDisplayControl(grpTies)

        ucrPnlNumericOptions.AddRadioButton(rdoRoundOf)
        ucrPnlNumericOptions.AddRadioButton(rdoSignificantDigits)
        ucrPnlNumericOptions.AddRadioButton(rdoScale)
        ucrPnlNumericOptions.AddRadioButton(rdoLag)
        ucrPnlNumericOptions.AddRadioButton(rdoLead)
        ucrPnlNumericOptions.AddRadioButton(rdoDifference)

        ucrPnlNumericOptions.AddFunctionNamesCondition(rdoRoundOf, "round")
        ucrPnlNumericOptions.AddFunctionNamesCondition(rdoSignificantDigits, "signif")
        ucrPnlNumericOptions.AddFunctionNamesCondition(rdoScale, "scale")
        ucrPnlNumericOptions.AddFunctionNamesCondition(rdoLag, "lag")
        ucrPnlNumericOptions.AddFunctionNamesCondition(rdoLead, "lead")
        ucrPnlNumericOptions.AddFunctionNamesCondition(rdoDifference, "c")

        ucrPnlNumericOptions.AddToLinkedControls(ucrNudSignifDigits, {rdoSignificantDigits}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudRoundOfDigits, {rdoRoundOf}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls(ucrNudLagLeadPosition, {rdoLag, rdoLead}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNumericOptions.AddToLinkedControls({ucrNudDiffLag}, {rdoDifference}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudSignifDigits.SetLinkedDisplayControl(lblDigits)
        ucrNudRoundOfDigits.SetLinkedDisplayControl(lblRoundofDigits)
        ucrNudLagLeadPosition.SetLinkedDisplayControl(lblLagLeadPosition)
        ucrNudDiffLag.SetLinkedDisplayControl(lblDiffLag)
        ucrPnlNumericOptions.SetLinkedDisplayControl(grpNumericOptions)

        ucrNudSignifDigits.SetParameter(New RParameter("digits", 1))
        ucrNudSignifDigits.SetMinMax(iNewMin:=0, iNewMax:=22)
        ucrNudSignifDigits.Increment = 1
        ucrNudSignifDigits.SetRDefault(6)

        ucrNudRoundOfDigits.SetParameter(New RParameter("digits", 1))
        ucrNudRoundOfDigits.Increment = 1
        ucrNudRoundOfDigits.SetMinMax(iNewMax:=Integer.MaxValue)
        ucrNudRoundOfDigits.SetRDefault(0)

        ucrNudLagLeadPosition.SetParameter(New RParameter("n", 1))
        ucrNudLagLeadPosition.SetMinMax(iNewMin:=1)
        ucrNudLagLeadPosition.Increment = 1
        ucrNudLagLeadPosition.SetRDefault(1)

        ucrNudDiffLag.SetParameter(New RParameter("lag", 1))
        ucrNudDiffLag.SetMinMax(iNewMin:=1)
        ucrNudDiffLag.Increment = 1
        ucrNudDiffLag.SetRDefault(1)

        ucrSaveNew.SetPrefix("rank")
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

    End Sub

    ' Sub that runs only the first time the dialog loads it sets default RFunction as the base function
    Private Sub SetDefaults()

        clsRankFunction = New RFunction
        clsSortFunction = New RFunction
        clsRoundFunction = New RFunction
        clsSignifFunction = New RFunction
        clsLagFunction = New RFunction
        clsLeadFunction = New RFunction
        clsDiffFunction = New RFunction
        clsCallDiffFunction = New RFunction
        clsScaleFunction = New RFunction
        clsReplicateFunction = New RFunction
        clsMeanFunction = New RFunction
        clsStandardDevFunction = New RFunction
        clsDeviationFunction = New RFunction
        clsSubtractOperator = New ROperator
        clsDivisionOperator = New ROperator

        ucrSelectorForRank.Reset()
        ucrReceiverRank.SetMeAsReceiver()
        ucrSaveNew.Reset()

        'Setting default parameters for the base function
        clsRankFunction.SetRCommand("rank")
        clsRankFunction.AddParameter("na.last", Chr(34) & "keep" & Chr(34))

        clsSortFunction.SetRCommand("sort")
        clsSortFunction.AddParameter("decreasing", "TRUE", iPosition:=1)
        clsSortFunction.AddParameter("na.last", "TRUE", iPosition:=2)

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

        clsCallDiffFunction.SetRCommand("c")
        clsCallDiffFunction.AddParameter("y", clsRFunctionParameter:=clsReplicateFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsCallDiffFunction.AddParameter("x", clsRFunctionParameter:=clsDiffFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsStandardDevFunction.SetRCommand("sd")
        clsStandardDevFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        clsDeviationFunction.SetRCommand("c")
        clsDeviationFunction.AddParameter("x", clsROperatorParameter:=clsSubtractOperator, bIncludeArgumentName:=False)

        clsSubtractOperator.SetOperation("-")
        clsSubtractOperator.AddParameter("y", clsRFunctionParameter:=clsMeanFunction, iPosition:=1)

        clsDivisionOperator.SetOperation("/")
        clsDivisionOperator.AddParameter("x", clsRFunctionParameter:=clsDeviationFunction, iPosition:=0)
        clsDivisionOperator.AddParameter("y", clsRFunctionParameter:=clsStandardDevFunction, iPosition:=1)

        clsScaleFunction.SetRCommand("scale")
        clsScaleFunction.AddParameter("x", clsROperatorParameter:=clsDivisionOperator, iPosition:=0, bIncludeArgumentName:=False)

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsRoundFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSortFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsRoundFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSignifFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=3)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLagFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=4)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsLeadFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=5)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsDiffFunction, ucrReceiverRank.GetParameter(), iAdditionalPairNo:=6)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsMeanFunction, New RParameter("x", 0), iAdditionalPairNo:=7)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsSubtractOperator, New RParameter("x", 0), iAdditionalPairNo:=8)
        ucrReceiverRank.AddAdditionalCodeParameterPair(clsStandardDevFunction, New RParameter("x", 0), iAdditionalPairNo:=9)
        ucrNudLagLeadPosition.AddAdditionalCodeParameterPair(clsLeadFunction, New RParameter("n", 1), iAdditionalPairNo:=1)
        ucrNudDiffLag.AddAdditionalCodeParameterPair(clsReplicateFunction, New RParameter("times", 1), iAdditionalPairNo:=1)
        ucrSaveNew.AddAdditionalRCode(clsLeadFunction, iAdditionalPairNo:=1)
        ucrSaveNew.AddAdditionalRCode(clsLagFunction, iAdditionalPairNo:=2)
        ucrSaveNew.AddAdditionalRCode(clsSignifFunction, iAdditionalPairNo:=3)
        ucrSaveNew.AddAdditionalRCode(clsCallDiffFunction, iAdditionalPairNo:=4)
        ucrSaveNew.AddAdditionalRCode(clsRankFunction, iAdditionalPairNo:=5)
        ucrSaveNew.AddAdditionalRCode(clsSortFunction, iAdditionalPairNo:=6)
        ucrSaveNew.AddAdditionalRCode(clsScaleFunction, iAdditionalPairNo:=7)

        ucrPnlTransformOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverRank.SetRCode(clsRankFunction, bReset)
        ucrChkDecreasing.SetRCode(clsSortFunction, bReset)
        ucrChkMissingLast.SetRCode(clsSortFunction, bReset)
        ucrSaveNew.SetRCode(clsRoundFunction, bReset)
        ucrPnlTies.SetRCode(clsRankFunction, bReset)
        ucrPnlMissingValues.SetRCode(clsRankFunction, bReset)
        ucrNudRoundOfDigits.SetRCode(clsRoundFunction, bReset)
        ucrNudSignifDigits.SetRCode(clsSignifFunction, bReset)
        ucrNudLagLeadPosition.SetRCode(clsLagFunction, bReset)
        ucrNudDiffLag.SetRCode(clsDiffFunction, bReset)
        ucrPnlNumericOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    'Testing when to Enable the OK button
    Private Sub TestOKEnabled()
        If Not ucrReceiverRank.IsEmpty() AndAlso ucrSaveNew.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlTransformOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlTransformOptions.ControlContentsChanged, ucrPnlNumericOptions.ControlContentsChanged
        If rdoRank.Checked = True Then
            ucrSaveNew.SetPrefix("rank")
            ucrBase.clsRsyntax.SetBaseRFunction(clsRankFunction)
        ElseIf rdoSort.Checked = True Then
            ucrSaveNew.SetPrefix("sort")
            ucrBase.clsRsyntax.SetBaseRFunction(clsSortFunction)
        ElseIf rdoNumeric.Checked Then
            If rdoRoundOf.Checked Then
                ucrSaveNew.SetPrefix("round")
                ucrBase.clsRsyntax.SetBaseRFunction(clsRoundFunction)
            ElseIf rdoSignificantDigits.Checked Then
                ucrSaveNew.SetPrefix("significant")
                ucrBase.clsRsyntax.SetBaseRFunction(clsSignifFunction)
            ElseIf rdoLag.Checked Then
                ucrSaveNew.SetPrefix("lag")
                ucrBase.clsRsyntax.SetBaseRFunction(clsLagFunction)
            ElseIf rdoLead.Checked Then
                ucrSaveNew.SetPrefix("lead")
                ucrBase.clsRsyntax.SetBaseRFunction(clsLeadFunction)
            ElseIf rdoDifference.Checked Then
                ucrSaveNew.SetPrefix("difference")
                ucrBase.clsRsyntax.SetBaseRFunction(clsCallDiffFunction)
            ElseIf rdoScale.Checked Then
                ucrSaveNew.SetPrefix("scale")
                ucrBase.clsRsyntax.SetBaseRFunction(clsScaleFunction)
            End If
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRank.ControlContentsChanged, ucrSaveNew.ControlContentsChanged, ucrPnlTransformOptions.ControlContentsChanged, ucrPnlNumericOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
