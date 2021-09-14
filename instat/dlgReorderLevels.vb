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
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition({rdoHand, rdoProperty, rdoVariable}, {frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels"})

        ucrPnlOptions.AddToLinkedControls(ucrReorderFactor, {rdoHand}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrPnlProperty, ucrInputPrefix, ucrNudShift}, {rdoProperty}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverVariable, ucrInputOptions, ucrChkReorderVariable}, {rdoVariable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlProperty.SetLinkedDisplayControl(ucrChkReorderOrder)
        ucrInputPrefix.SetLinkedDisplayControl(lblPrefix)
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

        ucrChkReorderVariable.SetText("Reverse Order")

        ucrPnlProperty.AddRadioButton(rdoAsIs)
        ucrPnlProperty.AddRadioButton(rdoAppearance)
        ucrPnlProperty.AddRadioButton(rdoFrequency)
        ucrPnlProperty.AddRadioButton(rdoSequence)
        ucrPnlProperty.AddRadioButton(rdoShift)
        ucrPnlProperty.AddRadioButton(rdoShuffle)
        ucrPnlProperty.AddRadioButton(rdoAnonymise)

        ucrSaveResults.SetPrefix("row_summary")
        ucrSaveResults.SetSaveTypeAsColumn()
        ucrSaveResults.SetDataFrameSelector(ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames)
        ucrSaveResults.SetLabelText("Save As:")
        ucrSaveResults.SetIsComboBox()
        'ucrSaveResults.setLinkedReceiver(ucrReceiverForRowSummaries)
    End Sub

    Private Sub SetDefaults()
        clsReorder = New RFunction
        'reset
        ucrSelectorFactorLevelsToReorder.Reset()
        ucrSaveResults.Reset()
        rdoHand.Checked = True
        ucrReceiverFactor.SetMeAsReceiver()
        ' Set default function
        clsReorder.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_factor_levels")
        clsReorder.SetAssignTo(ucrSaveResults.GetText, strTempDataframe:=ucrSelectorFactorLevelsToReorder.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        ucrBase.clsRsyntax.SetBaseRFunction(clsReorder)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSelectorFactorLevelsToReorder.SetRCode(clsReorder, bReset)
        ucrReceiverFactor.SetRCode(clsReorder, bReset)
        ucrReorderFactor.SetRCode(clsReorder, bReset)
        ucrSaveResults.SetRCode(clsReorder, bReset)
        ucrChkReorderOrder.SetRCode(clsReorder, bReset)
        ucrInputOptions.SetRCode(clsReorder, bReset)
        ucrReceiverVariable.SetRCode(clsReorder, bReset)
        ucrChkReorderVariable.SetRCode(clsReorder, bReset)
        ' ucrPnlProperty.SetRCode(clsReorder)
        ucrPnlOptions.SetRSyntax(ucrBase.clsRsyntax, bReset)
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

    Private Sub ucrPnlProperty_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlProperty.ControlValueChanged
        ucrNudShift.Visible = If(rdoShift.Checked, True, False)
        ucrInputPrefix.Visible = If(rdoAnonymise.Checked, True, False)

    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class