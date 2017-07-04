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
Imports System.Text.RegularExpressions

Public Class dlgDefineCorruption
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim clsTypesFunction As New RFunction
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))
    Private bResetSubdialog As Boolean = False

    Private Sub dlgDefineCorruption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
        AutoFillReceivers()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 499

        Dim kvpCountry As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("country", {"country"}.ToList())
        Dim kvpRegion As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("region", {"region"}.ToList())
        Dim kvpProcuringAuthority As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procuring_authority", {"anb_name"}.ToList())
        Dim kvpAwardDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("award_date", {"award_date"}.ToList())
        Dim kvpSignatureDate As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("signature_date", {"sign_date"}.ToList())
        Dim kvpContractTitle As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("contract_title", {"ca_title"}.ToList())
        Dim kvpContractSector As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("contract_sector", {"cft_sector"}.ToList())
        Dim kvpProcurementCategory As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procurement_category", {"ca_type"}.ToList())
        Dim kvpNoBidsReceived As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("no_bids_received", {"ca_nrbidsrec"}.ToList())
        Dim kvpNoBidsConsidered As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("no_bids_considered", {"ca_nrbidscons"}.ToList())
        Dim kvpProcedureType As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("method_type", {"cft_methodtype"}.ToList())
        Dim kvpWinnerName As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("winner_name", {"w_name"}.ToList())
        Dim kvpWinnerCountry As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("winner_country", {"w_country"}.ToList())
        Dim kvpContractValue As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("original_contract_value", {"ca_contract_value"}.ToList())
        Dim kvpFiscalYear As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("fiscal_year", {"fyear"}.ToList())

        lstRecognisedTypes.AddRange({kvpCountry, kvpRegion, kvpProcuringAuthority, kvpAwardDate, kvpSignatureDate, kvpContractTitle, kvpContractSector, kvpProcurementCategory, kvpNoBidsReceived, kvpNoBidsConsidered, kvpProcedureType, kvpWinnerName, kvpWinnerCountry, kvpContractValue, kvpFiscalYear})
        lstReceivers.AddRange({ucrReceiverCountry, ucrReceiverRegion, ucrReceiverProcuringAuthority, ucrReceiverAwardDate, ucrReceiverSignatureDate, ucrReceiverContractTitle, ucrReceiverContractSector,
                              ucrReceiverProcurementCategory, ucrReceiverNoBids, ucrReceiverNoConsideredBids, ucrReceiverProcedureType, ucrReceiverWinnerName, ucrReceiverWinnerCountry, ucrReceiverContractValue, ucrReceiverFiscalYear})

        ucrDefineCorruptionSelector.SetParameter(New RParameter("data_name", 0))
        ucrDefineCorruptionSelector.SetParameterIsString()

        ucrReceiverCountry.Tag = "country"
        ucrReceiverRegion.Tag = "region"
        ucrReceiverProcuringAuthority.Tag = "procuring_authority"
        ucrReceiverAwardDate.Tag = "award_date"
        ucrReceiverSignatureDate.Tag = "signature_date"
        ucrReceiverContractTitle.Tag = "contract_title"
        ucrReceiverContractSector.Tag = "contract_sector"
        ucrReceiverProcurementCategory.Tag = "procurement_category"
        ucrReceiverNoBids.Tag = "no_bids_received"
        ucrReceiverNoConsideredBids.Tag = "no_bids_considered"
        ucrReceiverProcedureType.Tag = "method_type"
        ucrReceiverWinnerName.Tag = "winner_name"
        ucrReceiverWinnerCountry.Tag = "winner_country"
        ucrReceiverContractValue.Tag = "original_contract_value"
        ucrReceiverFiscalYear.Tag = "fiscal_year"

        'ucrChk
        ucrChkAutoGenerate.SetText("Auto-Generate")
        ucrChkAutoGenerate.SetParameter(New RParameter("auto_generate", 1))
        ucrChkAutoGenerate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        sdgCorruptionCountryLevelColumns.ucrCountryLevelSelector.SetDataframe(ucrDefineCorruptionSelector.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
        sdgCorruptionCalculatedColumns.ucrCalculatedColumnsSelector.SetDataframe(ucrDefineCorruptionSelector.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
        SetRSelector()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrDefineCorruptionSelector.Reset()
        ucrReceiverCountry.SetMeAsReceiver()
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_corruption")
        clsDefaultFunction.AddParameter("auto_generate", "TRUE")
        clsTypesFunction.SetRCommand("c")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrBase.clsRsyntax.AddParameter("country_types", clsRFunctionParameter:=clsTypesFunction)

        bResetSubdialog = True
        AutoFillReceivers()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrDefineCorruptionSelector.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        sdgCorruptionCountryLevelColumns.ucrCountryLevelSelector.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        sdgCorruptionCalculatedColumns.ucrCalculatedColumnsSelector.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkAutoGenerate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        SetRCodesforReceivers(bReset)
    End Sub

    Private Sub SetRCodesforReceivers(bReset As Boolean)
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetRCode(clsTypesFunction, bReset)
        Next
    End Sub

    Private Sub SetRSelector()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = ucrDefineCorruptionSelector
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub TestOkEnabled()
        'What are the conditons for the teskok enabled here? Country not filled in?
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrDefineCorruptionSelector.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrDefineCorruptionSelector.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrDefineCorruptionSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    '    Private Sub Receiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlContentsChanged
    '        TestOkEnabled()
    '    End Sub

    Private Sub ucrDefineCorruptionSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDefineCorruptionSelector.ControlValueChanged
        AutoFillReceivers()
    End Sub

    'Private Sub cmdCountryLevel_Click(sender As Object, e As EventArgs) Handles cmdCountryLevel.Click
    '    sdgCorruptionCountryLevelColumns.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
    '    bResetSubdialog = False
    '    sdgCorruptionCountryLevelColumns.ShowDialog()
    'End Sub

    'Private Sub cmdCalculatedColumns_Click(sender As Object, e As EventArgs) Handles cmdCalculatedColumns.Click
    '    sdgCorruptionCalculatedColumns.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
    '    bResetSubdialog = False
    '    sdgCorruptionCalculatedColumns.ShowDialog()
    'End Sub
End Class