﻿'Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations

Public Class dlgConvertColumns
    Public bFirstLoad As Boolean = True
    Public bToFactorOnly As Boolean = False
    Private bReset As Boolean = True

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
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
        SetToFactorStatus(bToFactorOnly)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 67

        ucrPnlConvertTo.SetParameter(New RParameter("to_type", 2))
        ucrPnlConvertTo.AddRadioButton(rdoFactor, Chr(34) & "factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoOrderedFactor, Chr(34) & "ordered_factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoNumeric, Chr(34) & "numeric" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoCharacter, Chr(34) & "character" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoInteger, Chr(34) & "integer" & Chr(34))

        ucrPnlConvertTo.AddToLinkedControls(ucrChkSpecifyDecimalsToDisplay, {rdoFactor, rdoOrderedFactor}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlFactorToNumericOptions.SetParameter(New RParameter("factor_numeric", 3))
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoConvertLevels, Chr(34) & "by_levels" & Chr(34))
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoConvertOrdinals, Chr(34) & "by_ordinals" & Chr(34))
        ucrPnlFactorToNumericOptions.SetRDefault(Chr(34) & "by_levels" & Chr(34))
        ucrPnlFactorToNumericOptions.SetLinkedDisplayControl(grpFactorToNumericOptions)

        ucrPnlConvertTo.AddToLinkedControls(ucrPnlFactorToNumericOptions, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorDataFrameColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDataFrameColumns.SetParameterIsString()

        ucrReceiverColumnsToConvert.Selector = ucrSelectorDataFrameColumns
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        ucrReceiverColumnsToConvert.SetParameter(New RParameter("col_names", 1))
        ucrReceiverColumnsToConvert.SetParameterIsString()

        ucrChkSpecifyDecimalsToDisplay.SetText("Specify Decimals (from Numeric)")
        ucrChkSpecifyDecimalsToDisplay.SetParameter(New RParameter("set_digits", 4))
        ucrChkSpecifyDecimalsToDisplay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSpecifyDecimalsToDisplay.SetRDefault("FALSE")
        ucrChkSpecifyDecimalsToDisplay.AddToLinkedControls(ucrLinked:=ucrNudDisplayDecimals, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudDisplayDecimals.SetParameter(New RParameter("set_decimals", 5))
        ucrNudDisplayDecimals.Minimum = 1
        ucrNudDisplayDecimals.Increment = 1
        ucrNudDisplayDecimals.SetRDefault("4")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorDataFrameColumns.Reset()
        SetToFactorStatus(bToFactorOnly)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsDefaultFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverColumnsToConvert.IsEmpty() Then
            If (rdoFactor.Checked OrElse rdoOrderedFactor.Checked) AndAlso ucrChkSpecifyDecimalsToDisplay.Checked AndAlso ucrNudDisplayDecimals.GetText() = "" Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged() Handles ucrReceiverColumnsToConvert.ControlContentsChanged, ucrPnlConvertTo.ControlContentsChanged, ucrChkSpecifyDecimalsToDisplay.ControlContentsChanged, ucrNudDisplayDecimals.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class