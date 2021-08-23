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
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Public strSelectedDataFrame As String = ""
    Private clsDefaultFunction As New RFunction

    Private Sub dlgConvertColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        ReopenDialog()
        TestOKEnabled()
        autoTranslate(Me)
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

        ucrSelectorDataFrameColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDataFrameColumns.SetParameterIsString()

        ucrReceiverColumnsToConvert.SetParameter(New RParameter("col_names", 1))
        ucrReceiverColumnsToConvert.Selector = ucrSelectorDataFrameColumns
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        ucrReceiverColumnsToConvert.SetParameterIsString()

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
        ucrChkSpecifyDecimalsToDisplay.SetText("Specify Decimals (if Numeric)")
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

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorDataFrameColumns.Reset()
        SetToFactorStatus(bToFactorOnly)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsDefaultFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorDataFrameColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverColumnsToConvert.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
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
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetToFactorStatus(bToFactorOnly As Boolean)
        If bToFactorOnly Then
            rdoFactor.Checked = True
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

    Private Sub ucrChkSpecifyDecimalsToDisplay_Load(sender As Object, e As EventArgs) Handles ucrChkSpecifyDecimalsToDisplay.Load

    End Sub
End Class