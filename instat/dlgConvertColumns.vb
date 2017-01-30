'Instat-R
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
    Private clsDefaultFunction As New RFunction

    Private Sub dlgConvertColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 67

        ucrPnlConvertTo.SetParameter(New RParameter("to_type"))
        ucrPnlConvertTo.AddRadioButton(rdoFactor, Chr(34) & "factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoOrderedFactor, Chr(34) & "ordered_factor" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoNumeric, Chr(34) & "numeric" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoCharacter, Chr(34) & "character" & Chr(34))
        ucrPnlConvertTo.AddRadioButton(rdoInteger, Chr(34) & "integer" & Chr(34))
        ucrPnlConvertTo.SetRDefault(Chr(34) & "factor" & Chr(34))

        ucrPnlFactorToNumericOptions.SetParameter(New RParameter("factor_numeric"))
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoConvertLevels, Chr(34) & "by_levels" & Chr(34))
        ucrPnlFactorToNumericOptions.AddRadioButton(rdoConvertOrdinals, Chr(34) & "by_ordinals" & Chr(34))
        ucrPnlFactorToNumericOptions.SetRDefault(Chr(34) & "by_levels" & Chr(34))


        ucrSelectorDataFrameColumns.SetParameter(New RParameter("data_name"))
        ucrSelectorDataFrameColumns.SetParameterIsString()

        ucrReceiverColumnsToConvert.Selector = ucrSelectorDataFrameColumns
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        ucrReceiverColumnsToConvert.SetParameter(New RParameter("col_names"))
        ucrReceiverColumnsToConvert.SetParameterIsString()

        ucrChkSpecifyDecimalsToDisplay.SetText("SpecifyDecimalsToDisplay")
        ucrChkSpecifyDecimalsToDisplay.SetParameter(New RParameter("set_digits"))
        ucrChkSpecifyDecimalsToDisplay.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSpecifyDecimalsToDisplay.SetRDefault("FALSE")
        ucrChkSpecifyDecimalsToDisplay.AddToLinkedControls(ucrLinked:=ucrNudDisplayDecimals, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudDisplayDecimals.SetParameter(New RParameter("set_decimals"))
        ucrNudDisplayDecimals.Minimum = 1
        ucrNudDisplayDecimals.Increment = 1
        ucrNudDisplayDecimals.SetRDefault("4")

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsDefaultFunction.AddParameter("to_type", Chr(34) & "factor" & Chr(34))
        clsDefaultFunction.AddParameter("factor_numeric", Chr(34) & "by_levels" & Chr(34))
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorDataFrameColumns.Reset()
        ucrSelectorDataFrameColumns.Focus()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ConvertTo()
        TestOKEnabled()
    End Sub
    Private Sub ucrPnlConvertTo_RdosCheckedChanged() Handles ucrPnlConvertTo.ControlContentsChanged
        ConvertTo()
    End Sub

    Private Sub ConvertTo()
        If rdoFactor.Checked Then
            ucrReceiverColumnsToConvert.SetExcludedDataTypes({"factor"})
        ElseIf rdoNumeric.Checked Then
            ucrReceiverColumnsToConvert.SetExcludedDataTypes({"numeric"})
        ElseIf rdoCharacter.Checked Then
            ucrReceiverColumnsToConvert.SetExcludedDataTypes({"character"})
        ElseIf rdoInteger.Checked Then
            ucrReceiverColumnsToConvert.SetExcludedDataTypes({"integer"})
        ElseIf rdoOrderedFactor.Checked Then
            ucrReceiverColumnsToConvert.SetExcludedDataTypes({"factor"})
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverColumnsToConvert.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged() Handles ucrSelectorDataFrameColumns.ControlContentsChanged, ucrReceiverColumnsToConvert.ControlContentsChanged, ucrChkSpecifyDecimalsToDisplay.ControlContentsChanged, ucrNudDisplayDecimals.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class