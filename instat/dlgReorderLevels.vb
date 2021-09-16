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
    Private clsForcatsReorder As New RFunction

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
        ucrPnlOptions.AddFunctionNamesCondition(rdoProperty, "fct_inorder")
        ucrPnlOptions.AddFunctionNamesCondition(rdoVariable, "fct_reorder")

        ucrPnlOptions.AddToLinkedControls(ucrReorderFactor, {rdoHand}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkReorderOrder, ucrReceiverFactorX}, {rdoProperty}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverVariable, ucrInputOptions, ucrChkReorderVariable, ucrReceiverFactorX}, {rdoVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkReorderOrder.SetLinkedDisplayControl(grpMethods)
        ucrInputOptions.SetLinkedDisplayControl(lblOptions)
        ucrReceiverVariable.SetLinkedDisplayControl(lblVariable)
        'Set data frame paramater
        ucrSelectorFactorLevelsToReorder.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFactorLevelsToReorder.SetParameterIsString()

        'Set Receivers and column parameter
        ucrReceiverFactor.SetParameter(New RParameter("col_name", 1))
        ucrReceiverFactor.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetParameterIsString()

        'Setting receiver data types and parameters
        ucrReceiverFactorX.SetParameter(New RParameter("f", 0, bNewIncludeArgumentName:=False))
        ucrReceiverFactorX.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverFactorX.strSelectorHeading = "Factors"
        ucrReceiverFactorX.SetIncludedDataTypes({"factor"}, bStrict:=True)
        'ucrReceiverFactorX.bUseFilteredData = False
        'ucrReceiverFactorX.bForceAsDataFrame = True
        ucrReceiverFactorX.SetParameterIsRFunction()
        ucrReceiverFactorX.SetMeAsReceiver()

        'Set reorder scroll list view & datatype accepted
        ucrReorderFactor.SetParameter(New RParameter("new_level_names", 2))
        ucrReorderFactor.setReceiver(ucrReceiverFactor)
        ucrReorderFactor.setDataType("factor")

        ucrReceiverVariable.SetParameter(New RParameter(""))
        ucrReceiverVariable.Selector = ucrSelectorFactorLevelsToReorder
        ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.strSelectorHeading = "Numerics/Dates/Logical"
        ucrReceiverVariable.SetIncludedDataTypes({"numeric", "dates", "logical"})
        'ucrReceiverVariable.SetClimaticType("element")
        ucrReceiverVariable.bAutoFill = True

        ucrInputOptions.SetParameter(New RParameter(""))
        dctOptions.Add("Median", Chr(34) & "median" & Chr(34))
        dctOptions.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctOptions.Add("Max", Chr(34) & "max" & Chr(34))
        dctOptions.Add("Min", Chr(34) & "min" & Chr(34))
        dctOptions.Add("Sd", Chr(34) & "sd" & Chr(34))
        dctOptions.Add("IQR", Chr(34) & "IQR" & Chr(34))
        dctOptions.Add("Range", Chr(34) & "range" & Chr(34))
        ucrInputOptions.SetItems(dctOptions)
        ucrInputOptions.SetRDefault("median")
        ucrInputOptions.SetDropDownStyleAsNonEditable()

        ucrChkReorderOrder.SetText("Reverse Order")
        ucrChkReorderOrder.SetParameter(New RParameter(""))

        ucrChkReorderVariable.SetText("Reverse Order")
        ucrChkReorderVariable.SetParameter(New RParameter(""))

        ucrNudShift.SetParameter(New RParameter("n", 1))
        ucrNudShift.SetMinMax(-35, 50)
        ucrNudShift.SetRDefault(0)

        ucrInputPrefix.SetParameter(New RParameter("prefix", 1))

        ucrPnlProperty.AddRadioButton(rdoAsIs)
        ucrPnlProperty.AddRadioButton(rdoAppearance)
        ucrPnlProperty.AddRadioButton(rdoFrequency)
        ucrPnlProperty.AddRadioButton(rdoSequence)
        ucrPnlProperty.AddRadioButton(rdoShift)
        ucrPnlProperty.AddRadioButton(rdoShuffle)
        ucrPnlProperty.AddRadioButton(rdoAnonymise)

        ucrPnlProperty.AddFunctionNamesCondition(rdoAppearance, "fct_inorder")
        ucrPnlProperty.AddFunctionNamesCondition(rdoFrequency, "fct_infreq")
        ucrPnlProperty.AddFunctionNamesCondition(rdoSequence, "fct_inseq")
        ucrPnlProperty.AddFunctionNamesCondition(rdoShift, "fct_shift")
        ucrPnlProperty.AddFunctionNamesCondition(rdoShuffle, "fct_shuffle")
        ucrPnlProperty.AddFunctionNamesCondition(rdoAnonymise, "fct_anon")

        ucrPnlProperty.AddToLinkedControls(ucrNudShift, {rdoShift}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlProperty.AddToLinkedControls(ucrInputPrefix, {rdoAnonymise}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputPrefix.SetLinkedDisplayControl(lblPrefix)

        ucrSaveResults.SetPrefix("new_column")
        ucrSaveResults.SetSaveTypeAsColumn()
        ucrSaveResults.SetDataFrameSelector(ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames)
        ucrSaveResults.SetLabelText("New Column Name:")
        ucrSaveResults.SetIsComboBox()
        'ucrSaveResults.setLinkedReceiver(ucrReceiverFactorX)
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

        'reset
        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSaveResults.Reset()
        rdoAsIs.Checked = True
        rdoHand.Checked = True
        ucrReceiverFactor.SetMeAsReceiver()
        ' Set default function

        clsForcatsInOrder.SetPackageName("forcats")
        clsForcatsInOrder.SetRCommand("fct_inorder")

        clsForcatsInFreq.SetPackageName("forcats")
        clsForcatsInFreq.SetRCommand("fct_infreq")

        clsForcatsInSeq.SetPackageName("forcats")
        clsForcatsInSeq.SetRCommand("fct_inseq")

        clsForcatsShift.SetPackageName("forcats")
        clsForcatsShift.SetRCommand("fct_shift")

        clsForcatsShuffle.SetPackageName("forcats")
        clsForcatsShuffle.SetRCommand("fct_shuffle")

        clsForcatsAnonymise.SetPackageName("forcats")
        clsForcatsAnonymise.SetRCommand("fct_anon")

        clsForcatsReverse.SetPackageName("forcats")
        clsForcatsReverse.SetRCommand("fct_rev")

        clsForcatsReorder.SetPackageName("forcats")
        clsForcatsReorder.SetRCommand("fct_reorder")

        clsReorder.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        clsReorder.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        ucrBase.clsRsyntax.SetBaseRFunction(clsReorder)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        'ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInOrder, New RParameter("f", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInFreq, New RParameter("f", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsInSeq, New RParameter("f", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsShift, New RParameter("f", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsShuffle, New RParameter("f", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=4)
        ucrReceiverFactorX.AddAdditionalCodeParameterPair(clsForcatsAnonymise, New RParameter("f", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=5)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInOrder, iAdditionalPairNo:=1)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInFreq, iAdditionalPairNo:=2)
        ucrSaveResults.AddAdditionalRCode(clsForcatsInSeq, iAdditionalPairNo:=3)
        ucrSaveResults.AddAdditionalRCode(clsForcatsShift, iAdditionalPairNo:=4)
        ucrSaveResults.AddAdditionalRCode(clsForcatsShuffle, iAdditionalPairNo:=5)
        ucrSelectorFactorLevelsToReorder.SetRCode(clsReorder, bReset)
        ucrReceiverFactor.SetRCode(clsReorder, bReset)
        ucrReceiverFactorX.SetRCode(clsForcatsInOrder)
        ucrReorderFactor.SetRCode(clsReorder, bReset)
        ucrSaveResults.SetRCode(clsReorder, bReset)
        ucrChkReorderOrder.SetRCode(clsReorder, bReset)
        ucrInputOptions.SetRCode(clsReorder, bReset)
        ucrReceiverVariable.SetRCode(clsReorder, bReset)
        ucrChkReorderVariable.SetRCode(clsReorder, bReset)
        ucrInputPrefix.SetRCode(clsForcatsAnonymise, bReset)
        ucrNudShift.SetRCode(clsForcatsShift, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrPnlProperty.ControlValueChanged, ucrChkReorderOrder.ControlValueChanged
        If rdoAppearance.Checked Then
            clsForcatsInOrder.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInOrder)
        End If
        If rdoFrequency.Checked Then
            clsForcatsInFreq.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInFreq)
        End If
        If rdoSequence.Checked Then
            clsForcatsInSeq.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsInSeq)
        End If
        If rdoShift.Checked Then
            clsForcatsShift.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsShift)
        End If
        If rdoShuffle.Checked Then
            clsForcatsShuffle.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsShuffle)
        End If
        If rdoAnonymise.Checked Then
            clsForcatsAnonymise.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsForcatsAnonymise)
        End If
        If rdoHand.Checked Then
            clsReorder.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            ucrBase.clsRsyntax.SetBaseRFunction(clsReorder)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class