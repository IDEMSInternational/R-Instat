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
Public Class dlgReorderLevels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsReorderFunction As New RFunction
    Private clsForcatsInOrderFunction As New RFunction
    Private clsForcatInFreqFunction As New RFunction
    Private clsForcatsInSeqFunction As New RFunction
    Private clsForcatsShiftFunction As New RFunction
    Private clsForcatsShuffleFunction As New RFunction
    Private clsForcatsAnonymiseFunction As New RFunction
    Private clsForcatsReverseFunction As New RFunction
    Private clsForcatsRevFunction As New RFunction
    Private clsForcatsReorderFunction As New RFunction
    Private clsForcatsInFreqFunction As New RFunction
    Private clsForcatsRelevelFunction As New RFunction
    Private clsDummyFunction As New RFunction

    Private ReadOnly strAscending As String = "Ascending"
    Private ReadOnly strDescending As String = "Descending"

    Private Sub dlgReorderLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctOptions As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 36

        ucrPnlOptions.AddRadioButton(rdoHand)
        ucrPnlOptions.AddRadioButton(rdoProperty)
        ucrPnlOptions.AddRadioButton(rdoVariable)

        ucrPnlOptions.AddFunctionNamesCondition(rdoHand, frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        ucrPnlOptions.AddFunctionNamesCondition(rdoProperty, {"fct_rev", "fct_inorder", "fct_infreq", "fct_inseq", "fct_shift",
                                                "fct_shuffle", "fct_anon", "fct_relevel"})
        ucrPnlOptions.AddFunctionNamesCondition(rdoVariable, "fct_reorder")

        ucrPnlOptions.AddToLinkedControls({ucrReorderFactor, ucrReceiverFactor}, {rdoHand}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrPnlProperty}, {rdoProperty}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverVariable, ucrInputOptions, ucrChkReverseVariable}, {rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverFactorX, ucrSaveResults}, {rdoProperty, rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlProperty.SetLinkedDisplayControl(grpMethods)
        ucrInputOptions.SetLinkedDisplayControl(lblOptions)
        ucrReceiverVariable.SetLinkedDisplayControl(lblVariable)

        ucrSelectorFactorLevelsToReorder.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorLevelsToReorder.SetParameterIsString()

        ucrReceiverFactor.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetParameterIsString()

        ucrReceiverFactorX.SetParameter(New RParameter(".f", 0))
        ucrReceiverFactorX.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactorX.strSelectorHeading = "Factors"
        ucrReceiverFactorX.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactorX.SetParameterIsRFunction()

        ucrReorderFactor.SetParameter(New RParameter("new_level_names", 2))
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")

        ucrReceiverVariable.SetParameter(New RParameter(".x", 1))
        ucrReceiverVariable.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverVariable.SetParameterIsRFunction()
        ucrReceiverVariable.strSelectorHeading = "Numerics/Dates/Logical"
        ucrReceiverVariable.SetIncludedDataTypes({"numeric", "dates", "logical"})

        ucrInputOptions.SetParameter(New RParameter(".fun", 2))
        dctOptions.Add("Median", "median")
        dctOptions.Add("Mean", "mean")
        dctOptions.Add("Maximum", "max")
        dctOptions.Add("Minimum", "min")
        dctOptions.Add("Sd", "sd")
        dctOptions.Add("IQR", "IQR")
        dctOptions.Add("Range", "range")
        ucrInputOptions.SetItems(dctOptions)
        ucrInputOptions.SetDropDownStyleAsNonEditable()

        ucrChkReverseVariable.SetText("Ascending")
        ucrChkReverseVariable.SetParameter(New RParameter(".desc", 3))
        ucrChkReverseVariable.SetValuesCheckedAndUnchecked("FALSE", "TRUE")

        ucrNudShift.SetParameter(New RParameter("n", 1))
        ucrNudShift.SetMinMax(-35, 50)

        ucrInputPrefix.SetParameter(New RParameter("prefix", 1))

        ucrInputOrder.SetItems({strAscending, strDescending})
        ucrInputOrder.SetDropDownStyleAsNonEditable()

        ucrPnlProperty.AddRadioButton(rdoReverseLevels)
        ucrPnlProperty.AddRadioButton(rdoAppearance)
        ucrPnlProperty.AddRadioButton(rdoFrequency)
        ucrPnlProperty.AddRadioButton(rdoSequence)
        ucrPnlProperty.AddRadioButton(rdoShift)
        ucrPnlProperty.AddRadioButton(rdoShuffle)
        ucrPnlProperty.AddRadioButton(rdoAnonymise)
        ucrPnlProperty.AddRadioButton(rdoAlphabetical)

        ucrPnlProperty.AddParameterValuesCondition(rdoReverseLevels, "checked", "reverse")
        ucrPnlProperty.AddParameterValuesCondition(rdoAppearance, "checked", "appearance")
        ucrPnlProperty.AddParameterValuesCondition(rdoFrequency, "checked", "frequency")
        ucrPnlProperty.AddParameterValuesCondition(rdoSequence, "checked", "sequence")
        ucrPnlProperty.AddParameterValuesCondition(rdoShift, "checked", "shift")
        ucrPnlProperty.AddParameterValuesCondition(rdoShuffle, "checked", "shuffle")
        ucrPnlProperty.AddParameterValuesCondition(rdoAnonymise, "checked", "anonymise")
        ucrPnlProperty.AddParameterValuesCondition(rdoAlphabetical, "checked", "alphabetic")

        ucrPnlProperty.AddToLinkedControls(ucrNudShift, {rdoShift}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeParameterValue:=True, objNewDefaultState:=1)
        ucrPnlProperty.AddToLinkedControls(ucrInputPrefix, {rdoAnonymise}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlProperty.AddToLinkedControls(ucrInputOrder, {rdoFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputPrefix.SetLinkedDisplayControl(lblPrefix)
        ucrInputOrder.SetLinkedDisplayControl(lblOrder)

        ucrSaveResults.SetPrefix("new_column")
        ucrSaveResults.SetSaveTypeAsColumn()
        ucrSaveResults.SetDataFrameSelector(ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames)
        ucrSaveResults.SetLabelText("Save As:")
        ucrSaveResults.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsReorderFunction = New RFunction
        clsForcatsInOrderFunction = New RFunction
        clsForcatInFreqFunction = New RFunction
        clsForcatsInSeqFunction = New RFunction
        clsForcatsShiftFunction = New RFunction
        clsForcatsShuffleFunction = New RFunction
        clsForcatsAnonymiseFunction = New RFunction
        clsForcatsReverseFunction = New RFunction
        clsForcatsReorderFunction = New RFunction
        clsForcatsRevFunction = New RFunction
        clsForcatsInFreqFunction = New RFunction
        clsForcatsRelevelFunction = New RFunction
        clsDummyFunction = New RFunction

        'Reset
        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSaveResults.Reset()
        ucrReceiverFactor.SetMeAsReceiver()

        ucrInputOrder.SetText(strAscending)

        clsDummyFunction.AddParameter("checked", "reverse", iPosition:=0)

        'Set default function
        clsForcatsInOrderFunction.SetPackageName("forcats")
        clsForcatsInOrderFunction.SetRCommand("fct_inorder")
        clsForcatsInOrderFunction.AddParameter("ordered", "NA", iPosition:=1)

        clsForcatInFreqFunction.SetPackageName("forcats")
        clsForcatInFreqFunction.SetRCommand("fct_infreq")

        clsForcatsInFreqFunction.SetPackageName("forcats")
        clsForcatsInFreqFunction.SetRCommand("fct_infreq")

        clsForcatsInSeqFunction.SetPackageName("forcats")
        clsForcatsInSeqFunction.SetRCommand("fct_inseq")
        clsForcatsInSeqFunction.AddParameter("ordered", "NA", iPosition:=1)

        clsForcatsShiftFunction.SetPackageName("forcats")
        clsForcatsShiftFunction.SetRCommand("fct_shift")
        clsForcatsShiftFunction.AddParameter("n", 1, iPosition:=1)

        clsForcatsShuffleFunction.SetPackageName("forcats")
        clsForcatsShuffleFunction.SetRCommand("fct_shuffle")

        clsForcatsAnonymiseFunction.SetPackageName("forcats")
        clsForcatsAnonymiseFunction.SetRCommand("fct_anon")

        clsForcatsReverseFunction.SetPackageName("forcats")
        clsForcatsReverseFunction.SetRCommand("fct_rev")

        clsForcatsRevFunction.SetPackageName("forcats")
        clsForcatsRevFunction.SetRCommand("fct_rev")
        clsForcatsRevFunction.AddParameter("f", clsRFunctionParameter:=clsForcatsInFreqFunction, iPosition:=0)

        clsForcatsRelevelFunction.SetPackageName("forcats")
        clsForcatsRelevelFunction.SetRCommand("fct_relevel")
        clsForcatsRelevelFunction.AddParameter("sort", "sort", iPosition:=1)

        clsForcatsReorderFunction.SetPackageName("forcats")
        clsForcatsReorderFunction.SetRCommand("fct_reorder")
        clsForcatsReorderFunction.AddParameter(".fun", "median", iPosition:=2)
        clsForcatsReorderFunction.AddParameter(".desc", "TRUE", iPosition:=3)

        clsReorderFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        ucrBase.clsRsyntax.SetBaseRFunction(clsReorderFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatInFreqFunction, New RParameter("f", 0), iAdditionalPairNo:=1)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInSeqFunction, New RParameter("f", 0), iAdditionalPairNo:=2)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsShiftFunction, New RParameter("f", 0), iAdditionalPairNo:=3)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsShuffleFunction, New RParameter("f", 0), iAdditionalPairNo:=4)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsAnonymiseFunction, New RParameter("f", 0), iAdditionalPairNo:=5)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsReverseFunction, New RParameter("f", 0), iAdditionalPairNo:=6)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInOrderFunction, New RParameter("f", 0), iAdditionalPairNo:=7)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInFreqFunction, New RParameter("f", 0), iAdditionalPairNo:=8)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsRelevelFunction, ucrReceiverFactorX.GetParameter(), iAdditionalPairNo:=9)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInOrderFunction, iAdditionalPairNo:=1)
        ucrSaveResults.AddAdditionalRCode(clsForcatInFreqFunction, iAdditionalPairNo:=2)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInSeqFunction, iAdditionalPairNo:=3)
        ucrSaveResults.AddAdditionalRCode(clsForcatsShiftFunction, iAdditionalPairNo:=4)
        ucrSaveResults.AddAdditionalRCode(clsForcatsShuffleFunction, iAdditionalPairNo:=5)
        ucrSaveResults.AddAdditionalRCode(clsForcatsAnonymiseFunction, iAdditionalPairNo:=6)
        ucrSaveResults.AddAdditionalRCode(clsForcatsReorderFunction, iAdditionalPairNo:=7)
        ucrSaveResults.AddAdditionalRCode(clsForcatsReverseFunction, iAdditionalPairNo:=8)
        ucrSaveResults.AddAdditionalRCode(clsForcatsRevFunction, iAdditionalPairNo:=9)
        ucrSelectorFactorLevelsToReorder.SetRCode(clsReorderFunction, bReset)
        ucrReceiverFactor.SetRCode(clsReorderFunction, bReset)
        ucrReceiverFactorX.SetRCode(clsForcatsReorderFunction, bReset)
        ucrReorderFactor.SetRCode(clsReorderFunction, bReset)
        ucrSaveResults.SetRCode(clsForcatsRelevelFunction, bReset)
        ucrInputOptions.SetRCode(clsForcatsReorderFunction, bReset)
        ucrReceiverVariable.SetRCode(clsForcatsReorderFunction, bReset)
        ucrChkReverseVariable.SetRCode(clsForcatsReorderFunction, bReset)
        ucrInputPrefix.SetRCode(clsForcatsAnonymiseFunction, bReset)
        ucrNudShift.SetRCode(clsForcatsShiftFunction, bReset)
        ucrPnlProperty.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoHand.Checked Then
            If Not ucrReceiverFactor.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoProperty.Checked Then
            If Not ucrReceiverFactorX.IsEmpty AndAlso ucrSaveResults.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoVariable.Checked Then
            If Not ucrReceiverFactorX.IsEmpty AndAlso Not ucrReceiverVariable.IsEmpty AndAlso ucrSaveResults.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrPnlProperty.ControlValueChanged, ucrReceiverVariable.ControlValueChanged, ucrChkReverseVariable.ControlValueChanged, ucrInputOptions.ControlValueChanged, ucrReceiverFactorX.ControlValueChanged, ucrInputOrder.ControlValueChanged
        If rdoHand.Checked Then
            ucrReceiverFactor.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseRFunction(clsReorderFunction)
        ElseIf rdoProperty.Checked OrElse rdoVariable.Checked Then
            ucrReceiverFactorX.SetMeAsReceiver()
            ucrSaveResults.setLinkedReceiver(ucrReceiverFactorX)
            If rdoProperty.Checked Then
                If rdoReverseLevels.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsReverseFunction)
                    clsDummyFunction.AddParameter("checked", "reverse", iPosition:=0)
                End If
                If rdoAppearance.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInOrderFunction)
                    clsDummyFunction.AddParameter("checked", "appearance", iPosition:=0)
                ElseIf rdoFrequency.Checked Then
                    Select Case ucrInputOrder.GetText()
                        Case strAscending
                            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsRevFunction)
                        Case strDescending
                            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatInFreqFunction)
                    End Select
                    clsDummyFunction.AddParameter("checked", "frequency", iPosition:=0)
                ElseIf rdoSequence.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInSeqFunction)
                    clsDummyFunction.AddParameter("checked", "sequence", iPosition:=0)
                ElseIf rdoAlphabetical.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsRelevelFunction)
                    clsDummyFunction.AddParameter("checked", "alphabetic", iPosition:=0)
                ElseIf rdoShift.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsShiftFunction)
                    clsDummyFunction.AddParameter("checked", "shift", iPosition:=0)
                ElseIf rdoShuffle.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsShuffleFunction)
                    clsDummyFunction.AddParameter("checked", "shuffle", iPosition:=0)
                ElseIf rdoAnonymise.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsAnonymiseFunction)
                    clsDummyFunction.AddParameter("checked", "anonymise", iPosition:=0)
                End If
            ElseIf rdoVariable.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsReorderFunction)
            End If
        End If
    End Sub

    Private Sub rdoAppearance_MouseHover(sender As Object, e As EventArgs) Handles rdoAppearance.MouseHover
        ttMethods.SetToolTip(rdoAppearance, "The order that each level appears in the data frame.")
    End Sub

    Private Sub rdoFrequency_MouseHover(sender As Object, e As EventArgs) Handles rdoFrequency.MouseHover
        ttMethods.SetToolTip(rdoFrequency, "In the order of the relative frequencies of each level.")
    End Sub

    Private Sub rdoSequence_MouseHover(sender As Object, e As EventArgs) Handles rdoSequence.MouseHover
        ttMethods.SetToolTip(rdoSequence, "In numerical order of the levels (At least one level must be numerical.)")
    End Sub

    Private Sub rdoAlphabetical_MouseHover(sender As Object, e As EventArgs) Handles rdoAlphabetical.MouseHover
        ttMethods.SetToolTip(rdoAlphabetical, "Change the levels into to alphabetical order.")
    End Sub

    Private Sub rdoShift_MouseHover(sender As Object, e As EventArgs) Handles rdoShift.MouseHover
        ttMethods.SetToolTip(rdoShift, "Move the levels down: Example:  If 1, levels a, b, c, become b, c, a.  Use -1 to move up.")
    End Sub

    Private Sub rdoShuffle_MouseHover(sender As Object, e As EventArgs) Handles rdoShuffle.MouseHover
        ttMethods.SetToolTip(rdoShuffle, "Change into random order.")
    End Sub

    Private Sub rdoAnonymise_MouseHover(sender As Object, e As EventArgs) Handles rdoAnonymise.MouseHover
        ttMethods.SetToolTip(rdoAnonymise, "Replace factor levels with arbitrary numeric identifiers.")
    End Sub

    Private Sub rdoReverseLevels_MouseHover(sender As Object, e As EventArgs) Handles rdoReverseLevels.MouseHover
        ttMethods.SetToolTip(rdoReverseLevels, "Keep the current order of levels and labels.  Use Reverse checkbox to invert the order.")
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrReceiverVariable.ControlContentsChanged, ucrSaveResults.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrPnlProperty.ControlContentsChanged, ucrReceiverFactorX.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class