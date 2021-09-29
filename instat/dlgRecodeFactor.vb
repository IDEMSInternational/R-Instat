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

Imports instat
Imports instat.Translations

Public Class dlgRecodeFactor
    Private bFirstLoad As Boolean = True
    Private clsFctRecodeFunction, clsFctOtherFunction As New RFunction
    Private clsFctLowFreqFunction, clsFctLumpPropFunction, clsFctLumpMinFunction, clsFctLumpnFunction As New RFunction
    Private clsCFunction As New RFunction
    Private clsOtherDummyFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private bReset As Boolean = True
    Private Sub dlgRecodeFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 37

        ucrPnlOptions.AddRadioButton(rdoRecode)
        ucrPnlOptions.AddRadioButton(rdoOther)
        ucrPnlOptions.AddRadioButton(rdoLump)

        ucrPnlOptions.AddFunctionNamesCondition(rdoRecode, "fct_recode")
        ucrPnlOptions.AddFunctionNamesCondition(rdoOther, "fct_other")
        ucrPnlOptions.AddFunctionNamesCondition(rdoLump, "fct_lump")

        ucrPnlMethods.AddRadioButton(rdoKeep)
        ucrPnlMethods.AddRadioButton(rdoDrop)

        ucrPnlMethods.AddParameterValuesCondition(rdoKeep, "checked", "keep")
        ucrPnlMethods.AddParameterValuesCondition(rdoDrop, "checked", "drop")

        ucrPnlKeep.AddRadioButton(rdoLevels)
        ucrPnlKeep.AddRadioButton(rdoCommonValues)
        ucrPnlKeep.AddRadioButton(rdoFrequentValues)
        ucrPnlKeep.AddRadioButton(rdoMore)

        ucrPnlKeep.AddParameterValuesCondition(rdoLevels, "checked", "levels")
        ucrPnlKeep.AddParameterValuesCondition(rdoCommonValues, "checked", "lumpn")
        ucrPnlKeep.AddParameterValuesCondition(rdoFrequentValues, "checked", "prop")
        ucrPnlKeep.AddParameterValuesCondition(rdoMore, "checked", "low")

        ucrNudLevels.SetParameter(New RParameter("min", 1))
        ucrNudLevels.SetMinMax(0, Integer.MaxValue)
        ucrNudLevels.Increment = 1

        ucrNudCommonValues.SetParameter(New RParameter("n", 1))
        ucrNudCommonValues.SetMinMax(Integer.MinValue, Integer.MaxValue)

        ucrNudFrequentValues.SetParameter(New RParameter("prop", 1))
        ucrNudFrequentValues.SetMinMax(-1, 1)
        ucrNudFrequentValues.Increment = 0.01
        ucrNudFrequentValues.DecimalPlaces = 2

        ucrReceiverFactor.SetParameter(New RParameter(".f", 0))
        ucrReceiverFactor.Selector = ucrSelectorForRecode
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetParameterIsRFunction()
        ucrReceiverFactor.bUseFilteredData = False

        ucrFactorGrid.SetReceiver(ucrReceiverFactor)
        ucrFactorGrid.SetAsViewerOnly()
        ucrFactorGrid.bIncludeCopyOfLevels = True
        ucrFactorGrid.AddEditableColumns({"New Label"})

        ucrFactorLevels.SetAsMultipleSelector()
        ucrFactorLevels.SetReceiver(ucrReceiverFactor)
        ucrFactorLevels.SetIncludeLevels(False)
        ucrFactorLevels.bIncludeNA = True

        ucrInputOther.SetText("Other")

        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveNewColumn.SetIsComboBox()
        ucrSaveNewColumn.SetLabelText("New Column Name:")
        ucrSaveNewColumn.setLinkedReceiver(ucrReceiverFactor)

        ucrPnlKeep.AddToLinkedControls(ucrNudLevels, {rdoLevels}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlKeep.AddToLinkedControls(ucrNudCommonValues, {rdoCommonValues}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlKeep.AddToLinkedControls(ucrNudFrequentValues, {rdoFrequentValues}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddToLinkedControls({ucrFactorLevels, ucrPnlMethods}, {rdoOther}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrFactorGrid}, {rdoRecode}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrInputOther}, {rdoOther, rdoLump}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlKeep, {rdoLump}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMethods.SetLinkedDisplayControl(grpSelectedValues)
        ucrPnlKeep.SetLinkedDisplayControl(grpKeep)
        ucrInputOther.SetLinkedDisplayControl(lblOther)
    End Sub

    Private Sub SetDefaults()
        clsFctRecodeFunction = New RFunction
        clsFctOtherFunction = New RFunction
        clsFctLowFreqFunction = New RFunction
        clsFctLumpPropFunction = New RFunction
        clsFctLumpMinFunction = New RFunction
        clsFctLumpnFunction = New RFunction
        clsCFunction = New RFunction
        clsDummyFunction = New RFunction
        clsOtherDummyFunction = New RFunction

        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrFactorGrid.ResetText()
        ucrSaveNewColumn.Reset()

        clsDummyFunction.AddParameter("checked", "levels", iPosition:=0)

        clsOtherDummyFunction.AddParameter("checked", "keep", iPosition:=0)

        clsCFunction.SetRCommand("c")

        clsFctLumpMinFunction.SetPackageName("forcats")
        clsFctLumpMinFunction.SetRCommand("fct_lump_min")
        clsFctLumpMinFunction.AddParameter("min", "1", iPosition:=1)

        clsFctLumpnFunction.SetPackageName("forcats")
        clsFctLumpnFunction.SetRCommand("fct_lump_n")
        clsFctLumpnFunction.AddParameter("n", "5", iPosition:=1)

        clsFctLumpPropFunction.SetPackageName("forcats")
        clsFctLumpPropFunction.SetRCommand("fct_lump_prop")
        clsFctLumpPropFunction.AddParameter("prop", "0.1", iPosition:=1)

        clsFctLowFreqFunction.SetPackageName("forcats")
        clsFctLowFreqFunction.SetRCommand("fct_lump_lowfreq")

        clsFctOtherFunction.SetPackageName("forcats")
        clsFctOtherFunction.SetRCommand("fct_other")

        clsFctRecodeFunction.SetPackageName("forcats")
        clsFctRecodeFunction.SetRCommand("fct_recode")
        clsFctRecodeFunction.SetAssignTo(strTemp:=ucrSaveNewColumn.GetText(), strTempDataframe:=ucrSelectorForRecode.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveNewColumn.GetText())

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsFctRecodeFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverFactor.AddAdditionalCodeParameterPair(clsFctOtherFunction, New RParameter("f", 0), iAdditionalPairNo:=1)
        ucrReceiverFactor.AddAdditionalCodeParameterPair(clsFctLumpPropFunction, New RParameter("f", 0), iAdditionalPairNo:=2)
        ucrReceiverFactor.AddAdditionalCodeParameterPair(clsFctLowFreqFunction, New RParameter("f", 0), iAdditionalPairNo:=3)
        ucrReceiverFactor.AddAdditionalCodeParameterPair(clsFctLumpnFunction, New RParameter("f", 0), iAdditionalPairNo:=4)
        ucrReceiverFactor.AddAdditionalCodeParameterPair(clsFctLumpMinFunction, New RParameter("f", 0), iAdditionalPairNo:=5)
        ucrSaveNewColumn.AddAdditionalRCode(clsFctLumpPropFunction, iAdditionalPairNo:=1)
        ucrSaveNewColumn.AddAdditionalRCode(clsFctLowFreqFunction, iAdditionalPairNo:=2)
        ucrSaveNewColumn.AddAdditionalRCode(clsFctLumpMinFunction, iAdditionalPairNo:=3)
        ucrSaveNewColumn.AddAdditionalRCode(clsFctLumpnFunction, iAdditionalPairNo:=4)
        ucrSaveNewColumn.AddAdditionalRCode(clsFctOtherFunction, bReset)
        ucrReceiverFactor.SetRCode(clsFctRecodeFunction, bReset)
        ucrSaveNewColumn.SetRCode(clsFctRecodeFunction, bReset)
        ucrNudFrequentValues.SetRCode(clsFctLumpPropFunction, bReset)
        ucrNudCommonValues.SetRCode(clsFctLumpnFunction, bReset)
        ucrNudLevels.SetRCode(clsFctLumpMinFunction, bReset)
        ucrPnlMethods.SetRCode(clsOtherDummyFunction, bReset)
        ucrPnlKeep.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoRecode.Checked Then
            If Not ucrReceiverFactor.IsEmpty AndAlso ucrSaveNewColumn.IsComplete AndAlso ucrFactorGrid.IsColumnComplete("New Label") Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoOther.Checked Then
            If Not ucrReceiverFactor.IsEmpty AndAlso ucrSaveNewColumn.IsComplete AndAlso Not String.IsNullOrEmpty(ucrFactorLevels.GetSelectedLevels()) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoLump.Checked Then
            If Not ucrReceiverFactor.IsEmpty AndAlso ucrSaveNewColumn.IsComplete Then
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

    Private Sub DefaultNewName()
        If ((Not ucrSaveNewColumn.bUserTyped) AndAlso (Not ucrReceiverFactor.IsEmpty)) Then
            ucrSaveNewColumn.SetPrefix(ucrReceiverFactor.GetVariableNames(bWithQuotes:=False) & "_recoded")
        End If
    End Sub

    Private Sub ucrFactorGrid_GridContentChanged() Handles ucrFactorGrid.GridContentChanged
        Dim strCurrentLabels As List(Of String)
        Dim strNewLabels As List(Of String)

        strCurrentLabels = ucrFactorGrid.GetColumnAsList(ucrFactorGrid.strLabelsName, False)
        strNewLabels = ucrFactorGrid.GetColumnAsList("New Label", True)

        If ucrFactorGrid.IsColumnComplete("New Label") AndAlso strCurrentLabels.Count = strNewLabels.Count Then
            For i = 0 To strCurrentLabels.Count - 1
                ' Backtick needed for names of the vector incase the levels are not valid R names
                clsFctRecodeFunction.AddParameter(Chr(96) & strCurrentLabels(i) & Chr(96), strNewLabels(i))
            Next
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrPnlMethods.ControlValueChanged, ucrPnlKeep.ControlValueChanged, ucrInputOther.ControlValueChanged, ucrNudLevels.ControlValueChanged, ucrNudCommonValues.ControlValueChanged, ucrNudFrequentValues.ControlValueChanged, ucrFactorLevels.ControlValueChanged
        If rdoRecode.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsFctRecodeFunction)
        ElseIf rdoOther.Checked OrElse rdoLump.Checked Then
            If ucrInputOther.IsEmpty OrElse ucrInputOther.GetText = "Other" Then
                clsFctOtherFunction.AddParameter("other_level", Chr(34) & "Other" & Chr(34), iPosition:=2)
                clsFctLowFreqFunction.AddParameter("other_level", Chr(34) & "Other" & Chr(34), iPosition:=2)
                clsFctLumpPropFunction.AddParameter("other_level", Chr(34) & "Other" & Chr(34), iPosition:=2)
                clsFctLumpMinFunction.AddParameter("other_level", Chr(34) & "Other" & Chr(34), iPosition:=2)
                clsFctLumpnFunction.AddParameter("other_level", Chr(34) & "Other" & Chr(34), iPosition:=2)
            Else
                clsFctOtherFunction.AddParameter("other_level", Chr(34) & ucrInputOther.GetText() & Chr(34), iPosition:=2)
                clsFctLowFreqFunction.AddParameter("other_level", Chr(34) & ucrInputOther.GetText() & Chr(34), iPosition:=2)
                clsFctLumpPropFunction.AddParameter("other_level", Chr(34) & ucrInputOther.GetText() & Chr(34), iPosition:=2)
                clsFctLumpMinFunction.AddParameter("other_level", Chr(34) & ucrInputOther.GetText() & Chr(34), iPosition:=2)
                clsFctLumpnFunction.AddParameter("other_level", Chr(34) & ucrInputOther.GetText() & Chr(34), iPosition:=2)
            End If
            If rdoOther.Checked Then
                clsFctOtherFunction.RemoveParameterByName("keep")
                clsFctOtherFunction.RemoveParameterByName("drop")
                If rdoKeep.Checked Then
                    clsFctOtherFunction.AddParameter("keep", ucrFactorLevels.GetSelectedLevels(), iPosition:=1)
                    clsOtherDummyFunction.AddParameter("checked", "keep", iPosition:=0)
                ElseIf rdoDrop.Checked Then
                    clsFctOtherFunction.AddParameter("drop", ucrFactorLevels.GetSelectedLevels(), iPosition:=1)
                    clsOtherDummyFunction.AddParameter("checked", "drop", iPosition:=0)
                End If
                ucrBase.clsRsyntax.SetBaseRFunction(clsFctOtherFunction)
            ElseIf rdoLump.Checked Then
                If rdoFrequentValues.Checked Then
                    clsDummyFunction.AddParameter("checked", "prop", iPosition:=0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFctLumpPropFunction)
                ElseIf rdoMore.Checked Then
                    clsDummyFunction.AddParameter("checked", "low", iPosition:=0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFctLowFreqFunction)
                ElseIf rdoLevels.Checked Then
                    clsDummyFunction.AddParameter("checked", "levels", iPosition:=0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFctLumpMinFunction)
                ElseIf rdoCommonValues.Checked Then
                    clsDummyFunction.AddParameter("checked", "lumpn", iPosition:=0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsFctLumpnFunction)
                End If
            End If
        End If
    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        DefaultNewName()
    End Sub

    Private Sub ucrReceiverFactor_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrSaveNewColumn.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrFactorLevels.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class