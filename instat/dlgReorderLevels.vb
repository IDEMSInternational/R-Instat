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
    Private clsReorder As New RFunction
    Private clsForcatsInOrder As New RFunction
    Private clsForcatsInFreq As New RFunction
    Private clsForcatsInSeq As New RFunction
    Private clsForcatsShift As New RFunction
    Private clsForcatsShuffle As New RFunction
    Private clsForcatsAnonymise As New RFunction
    Private clsForcatsReverse As New RFunction
    Private clsForcatsRevFunction As New RFunction
    Private clsForcatsReorder As New RFunction
    Private clsForcatsInFreqFunction As New RFunction
    Private clsForcatsRelevel As New RFunction

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
        SetRCodeforControls(bReset)
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
        ucrPnlOptions.AddFunctionNamesCondition(rdoProperty, "fct_rev")
        ucrPnlOptions.AddFunctionNamesCondition(rdoVariable, "fct_reorder")

        ucrPnlOptions.AddToLinkedControls({ucrReorderFactor, ucrReceiverFactor}, {rdoHand}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrPnlProperty}, {rdoProperty}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverVariable, ucrInputOptions, ucrChkReverseVariable}, {rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverFactorX, {rdoProperty, rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlProperty.SetLinkedDisplayControl(grpMethods)
        ucrInputOptions.SetLinkedDisplayControl(lblOptions)
        ucrReceiverVariable.SetLinkedDisplayControl(lblVariable)
        'Set data frame paramater
        ucrSelectorFactorLevelsToReorder.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorLevelsToReorder.SetParameterIsString()

        'Setting receiver data types and parameters
        ucrReceiverFactor.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetParameterIsString()

        ucrReceiverFactorX.SetParameter(New RParameter(".f", 0))
        ucrReceiverFactorX.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactorX.strSelectorHeading = "Factors"
        ucrReceiverFactorX.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactorX.SetParameterIsRFunction()
        ucrReceiverFactorX.SetMeAsReceiver()
        ucrReceiverFactorX.bAutoFill = True

        'Set reorder scroll list view & datatype accepted
        ucrReorderFactor.SetParameter(New RParameter("new_level_names", 2))
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")

        ucrReceiverVariable.SetParameter(New RParameter(".x", 1))
        ucrReceiverVariable.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverVariable.SetParameterIsRFunction()
        ucrReceiverVariable.strSelectorHeading = "Numerics/Dates/Logical"
        ucrReceiverVariable.SetIncludedDataTypes({"numeric", "dates", "logical"})
        ucrReceiverVariable.bAutoFill = True

        ucrInputOptions.SetParameter(New RParameter(".fun", 2))
        dctOptions.Add("Median", "median")
        dctOptions.Add("Mean", "mean")
        dctOptions.Add("Max", "max")
        dctOptions.Add("Min", "min")
        dctOptions.Add("Sd", "sd")
        dctOptions.Add("IQR", "IQR")
        dctOptions.Add("Range", "range")
        ucrInputOptions.SetItems(dctOptions)
        ucrInputOptions.SetDropDownStyleAsNonEditable()

        ucrChkReverseVariable.SetText("Ascending")
        ucrChkReverseVariable.SetParameter(New RParameter(".desc", 3))
        ucrChkReverseVariable.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

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

        ucrPnlProperty.AddFunctionNamesCondition(rdoAppearance, "fct_inorder")
        ucrPnlProperty.AddFunctionNamesCondition(rdoFrequency, "fct_infreq")
        ucrPnlProperty.AddFunctionNamesCondition(rdoSequence, "fct_inseq")
        ucrPnlProperty.AddFunctionNamesCondition(rdoShift, "fct_shift")
        ucrPnlProperty.AddFunctionNamesCondition(rdoShuffle, "fct_shuffle")
        ucrPnlProperty.AddFunctionNamesCondition(rdoAnonymise, "fct_anon")
        ucrPnlProperty.AddFunctionNamesCondition(rdoAlphabetical, "fct_relevel")

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
        ucrSaveResults.bAddRemoveParameter = True

        ttAsIs.SetToolTip(rdoReverseLevels, "Keep the current order of levels and labels.  Use Reverse checkbox to invert the order.")
        ttAppearance.SetToolTip(rdoAppearance, "The order that each level appears in the data frame.")
        ttFrequency.SetToolTip(rdoFrequency, "In the order of the relative frequencies of each level.")
        ttSequence.SetToolTip(rdoSequence, "In numerical order of the levels (At least one level must be numerical.)")
        ttShift.SetToolTip(rdoShift, "Move the levels down: Example:  If 1, levels a, b, c, become b, c, a.  Use -1 to move up.")
        ttShuffle.SetToolTip(rdoShuffle, "Change into random order.")
        ttAnonymise.SetToolTip(rdoAnonymise, "Replace factor levels with arbitrary numeric identifiers.")
    End Sub

    Private Sub SetDefaults()
        clsReorder = New RFunction
        clsForcatsInOrder = New RFunction
        clsForcatsInFreq = New RFunction
        clsForcatsInSeq = New RFunction
        clsForcatsShift = New RFunction
        clsForcatsShuffle = New RFunction
        clsForcatsAnonymise = New RFunction
        clsForcatsReverse = New RFunction
        clsForcatsReorder = New RFunction
        clsForcatsRevFunction = New RFunction
        clsForcatsInFreqFunction = New RFunction
        clsForcatsRelevel = New RFunction

        'Reset
        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSaveResults.Reset()
        rdoReverseLevels.Checked = True
        rdoHand.Checked = True
        ucrReceiverFactor.SetMeAsReceiver()

        ucrInputOrder.SetText(strAscending)

        'Set default function
        clsForcatsInOrder.SetPackageName("forcats")
        clsForcatsInOrder.SetRCommand("fct_inorder")
        clsForcatsInOrder.AddParameter("ordered", "NA", iPosition:=1)

        clsForcatsInFreq.SetPackageName("forcats")
        clsForcatsInFreq.SetRCommand("fct_infreq")

        clsForcatsInFreqFunction.SetPackageName("forcats")
        clsForcatsInFreqFunction.SetRCommand("fct_infreq")

        clsForcatsInSeq.SetPackageName("forcats")
        clsForcatsInSeq.SetRCommand("fct_inseq")
        clsForcatsInSeq.AddParameter("ordered", "NA", iPosition:=1)

        clsForcatsShift.SetPackageName("forcats")
        clsForcatsShift.SetRCommand("fct_shift")
        clsForcatsShift.AddParameter("n", 1, iPosition:=1)

        clsForcatsShuffle.SetPackageName("forcats")
        clsForcatsShuffle.SetRCommand("fct_shuffle")

        clsForcatsAnonymise.SetPackageName("forcats")
        clsForcatsAnonymise.SetRCommand("fct_anon")

        clsForcatsReverse.SetPackageName("forcats")
        clsForcatsReverse.SetRCommand("fct_rev")

        clsForcatsRevFunction.SetPackageName("forcats")
        clsForcatsRevFunction.SetRCommand("fct_rev")
        clsForcatsRevFunction.AddParameter("f", clsRFunctionParameter:=clsForcatsInFreqFunction, iPosition:=0)

        clsForcatsRelevel.SetPackageName("forcats")
        clsForcatsRelevel.SetRCommand("fct_relevel")

        clsForcatsReorder.SetPackageName("forcats")
        clsForcatsReorder.SetRCommand("fct_reorder")
        clsForcatsReorder.AddParameter(".fun", "median", iPosition:=2)
        clsForcatsReorder.AddParameter(".desc", "FALSE", iPosition:=3)

        clsReorder.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        clsReorder.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        ucrBase.clsRsyntax.SetBaseRFunction(clsReorder)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInFreq, New RParameter("f", 0), iAdditionalPairNo:=1)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInSeq, New RParameter("f", 0), iAdditionalPairNo:=2)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsShift, New RParameter("f", 0), iAdditionalPairNo:=3)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsShuffle, New RParameter("f", 0), iAdditionalPairNo:=4)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsAnonymise, New RParameter("f", 0), iAdditionalPairNo:=5)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsReverse, New RParameter("f", 0), iAdditionalPairNo:=6)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInOrder, New RParameter("f", 0), iAdditionalPairNo:=7)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInFreqFunction, New RParameter("f", 0), iAdditionalPairNo:=8)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsRelevel, New RParameter(".f", 0), iAdditionalPairNo:=9)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInOrder, iAdditionalPairNo:=1)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInFreq, iAdditionalPairNo:=2)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInSeq, iAdditionalPairNo:=3)
        ucrSaveResults.AddAdditionalRCode(clsForcatsShift, iAdditionalPairNo:=4)
        ucrSaveResults.AddAdditionalRCode(clsForcatsShuffle, iAdditionalPairNo:=5)
        ucrSaveResults.AddAdditionalRCode(clsForcatsAnonymise, iAdditionalPairNo:=6)
        ucrSaveResults.AddAdditionalRCode(clsForcatsReorder, iAdditionalPairNo:=7)
        ucrSaveResults.AddAdditionalRCode(clsForcatsReverse, iAdditionalPairNo:=8)
        ucrSaveResults.AddAdditionalRCode(clsForcatsRevFunction, iAdditionalPairNo:=9)
        ucrSaveResults.AddAdditionalRCode(clsForcatsRelevel, iAdditionalPairNo:=10)
        ucrSelectorFactorLevelsToReorder.SetRCode(clsReorder, bReset)
        ucrReceiverFactor.SetRCode(clsReorder, bReset)
        ucrReceiverFactorX.SetRCode(clsForcatsReorder, bReset)
        ucrReorderFactor.SetRCode(clsReorder, bReset)
        ucrSaveResults.SetRCode(clsReorder, bReset)
        ucrInputOptions.SetRCode(clsForcatsReorder, bReset)
        ucrReceiverVariable.SetRCode(clsForcatsReorder, bReset)
        ucrChkReverseVariable.SetRCode(clsForcatsReorder, bReset)
        ucrInputPrefix.SetRCode(clsForcatsAnonymise, bReset)
        ucrNudShift.SetRCode(clsForcatsShift, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoHand.Checked Then
            If Not ucrReceiverFactor.IsEmpty AndAlso ucrSaveResults.IsComplete Then
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
            If (Not ucrReceiverFactorX.IsEmpty OrElse Not ucrReceiverVariable.IsEmpty) AndAlso ucrSaveResults.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrPnlProperty.ControlValueChanged, ucrReceiverVariable.ControlValueChanged, ucrChkReverseVariable.ControlValueChanged, ucrInputOptions.ControlValueChanged, ucrReceiverFactorX.ControlValueChanged, ucrInputOrder.ControlValueChanged
        If rdoProperty.Checked Then
            ucrReceiverFactorX.SetMeAsReceiver()
            If rdoReverseLevels.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsReverse)
            End If
            If rdoAppearance.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInOrder)
            End If
            If rdoFrequency.Checked Then
                Select Case ucrInputOrder.GetText()
                    Case strAscending
                        ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsRevFunction)
                    Case strDescending
                        ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInFreq)
                End Select
            End If
            If rdoSequence.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInSeq)
            End If
            If rdoAlphabetical.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsRelevel)
            End If
            If rdoShift.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsShift)
            End If
            If rdoShuffle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsShuffle)
            End If
            If rdoAnonymise.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsAnonymise)
            End If
        ElseIf rdoHand.Checked Then
            ucrReceiverFactor.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseRFunction(clsReorder)
        ElseIf rdoVariable.Checked Then
            ucrReceiverFactorX.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsReorder)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrReceiverVariable.ControlContentsChanged, ucrSaveResults.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrPnlProperty.ControlContentsChanged, ucrReceiverFactorX.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class