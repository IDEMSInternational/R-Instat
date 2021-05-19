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

Public Class dlgConvertColumns
    Public bFirstLoad As Boolean = True
    Public bToFactorOnly As Boolean = False
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private lstRCodeStructure As List(Of RCodeStructure)
    Private Sub dlgConvertColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        SetToFactorStatus(bToFactorOnly)
        If rdoNumeric.Checked Then
            grpFactorToNumericOptions.Visible = True
        Else
            grpFactorToNumericOptions.Visible = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 67

        ucrReceiverColumnsToConvert.SetParameter(New RParameter("col_names", 1))
        ucrReceiverColumnsToConvert.Selector = ucrSelectorDataFrameColumns
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        ucrReceiverColumnsToConvert.SetParameterIsString()

        ucrSelectorDataFrameColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDataFrameColumns.SetParameterIsString()


        ucrPnlConvertTo.SetParameter(New RParameter("to_type", 2))
        ucrPnlConvertTo.AddRadioButton(rdoFactor, Chr(34) & "factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoOrderedFactor, Chr(34) & "ordered_factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoNumeric, Chr(34) & "numeric" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoCharacter, Chr(34) & "character" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoInteger, Chr(34) & "integer" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoLogical, Chr(34) & "logical" & Chr(34))
        ucrPnlConvertTo.AddToLinkedControls(ucrChkSpecifyDecimalsToDisplay, {rdoFactor, rdoOrderedFactor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlConvertTo.AddToLinkedControls(ucrPnlFactorToNumericOptions, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoDefault)

        ucrPnlFactorToNumericOptions.SetParameter(New RParameter("factor_values", 3))
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoDefault, "NULL")
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoConvertLevels, Chr(34) & "force_values" & Chr(34))
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoConvertOrdinals, Chr(34) & "force_ordinals" & Chr(34))
        ucrPnlFactorToNumericOptions.SetRDefault("NULL")
        ucrPnlFactorToNumericOptions.SetLinkedDisplayControl(grpFactorToNumericOptions)

        ucrChkSpecifyDecimalsToDisplay.SetParameter(New RParameter("set_digits", 4))
        ucrChkSpecifyDecimalsToDisplay.SetText("Specify Decimals (from Numeric)")
        ucrChkSpecifyDecimalsToDisplay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSpecifyDecimalsToDisplay.SetRDefault("FALSE")
        ucrChkSpecifyDecimalsToDisplay.AddToLinkedControls(ucrLinked:=ucrNudDisplayDecimals, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudDisplayDecimals.SetParameter(New RParameter("set_decimals", 5))
        ucrNudDisplayDecimals.Minimum = 1
        ucrNudDisplayDecimals.Increment = 1
        ucrNudDisplayDecimals.SetRDefault("4")

        ucrChkKeepAttributes.SetParameter(New RParameter("keep_attr", 6))
        ucrChkKeepAttributes.SetText("Keep Attributes")
        ucrChkKeepAttributes.SetRDefault("TRUE")

        ucrPnlConvertTo.AddToLinkedControls(ucrChkIgnoreLabels, {rdoNumeric, rdoFactor, rdoOrderedFactor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkIgnoreLabels.SetParameter(New RParameter("ignore_labels", 7))
        ucrChkIgnoreLabels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIgnoreLabels.SetRDefault("FALSE")
        ucrChkIgnoreLabels.AddToLinkedControls(ucrChkCreateLabels, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkCreateLabels.SetParameter(New RParameter("keep.labels", 8))
        ucrChkCreateLabels.SetText("Create Labels")
        ucrChkCreateLabels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCreateLabels.SetRDefault("TRUE")

    End Sub

    Private Sub SetRFunctionDefaultParameters()
        clsDefaultFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub ResetFunction()
        clsDefaultFunction = New RFunction
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
    End Sub


    Private Sub SetDefaults()
        ResetFunction()
        ucrSelectorDataFrameColumns.Reset()

        If IsNothing(lstRCodeStructure) Then
            SetRFunctionDefaultParameters()
        ElseIf lstRCodeStructure.count > 1 Then
            SetRFunctionDefaultParameters()
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf lstRCodeStructure.count = 1 Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If (TryCast(lstRCodeStructure(0), RFunction).strRCommand) = clsDefaultFunction.strRCommand Then
                    clsDefaultFunction = lstRCodeStructure(0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
                Else
                    SetRFunctionDefaultParameters()
                    MsgBox("Developer error: This dialogue requires An RFunction whose command is" & clsDefaultFunction.strRCommand)
                End If
            End If
        End If
        lstRCodeStructure = Nothing
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverColumnsToConvert.IsEmpty() Then
            If (rdoFactor.Checked OrElse rdoOrderedFactor.Checked) AndAlso ucrChkSpecifyDecimalsToDisplay.Checked AndAlso ucrNudDisplayDecimals.GetText = "" Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetToFactorStatus(bToFactorOnly)
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetToFactorStatus(bToFactorOnly As Boolean)
        If bToFactorOnly Then
            If Not rdoFactor.Checked AndAlso Not rdoOrderedFactor.Checked Then
                rdoFactor.Checked = True
            End If
            rdoCharacter.Enabled = False
            rdoInteger.Enabled = False
            rdoNumeric.Enabled = False
        Else
            rdoCharacter.Enabled = True
            rdoInteger.Enabled = True
            rdoNumeric.Enabled = True
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToConvert.ControlContentsChanged, ucrPnlConvertTo.ControlContentsChanged, ucrNudDisplayDecimals.ControlContentsChanged, ucrChkSpecifyDecimalsToDisplay.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlConvertTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlConvertTo.ControlValueChanged
        If rdoNumeric.Checked Then
            ucrChkIgnoreLabels.SetText("Simple Convert")
        ElseIf rdoFactor.Checked OrElse rdoOrderedFactor.Checked Then
            ucrChkIgnoreLabels.SetText("Ignore Labels")
        End If
    End Sub
    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property

End Class