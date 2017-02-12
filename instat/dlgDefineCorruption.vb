' Instat-R
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
Imports System.Text.RegularExpressions
Imports instat

Public Class dlgDefineCorruption
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstReceivers As New List(Of ucrReceiverSingle)
    Private dctRecognisedCorruptionTypes As New Dictionary(Of String, String())
    Private clsTypesFunction As New RFunction

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
        autoTranslate(Me)
        AutoFillReceivers()
    End Sub

    Private Sub InitialiseDialog()
        Dim tmpReceiver As ucrReceiver

        'ucrBase.iHelpTopicID = ""

        dctRecognisedCorruptionTypes.Add("country", {"country"})
        dctRecognisedCorruptionTypes.Add("procuring_authority", {"anb_name"})
        dctRecognisedCorruptionTypes.Add("procuring_authority_id", {"anb_id"})
        dctRecognisedCorruptionTypes.Add("award_date", {"award_date"})
        dctRecognisedCorruptionTypes.Add("signature_date", {"sign_date"})
        dctRecognisedCorruptionTypes.Add("contract_name", {"ca_title"})
        dctRecognisedCorruptionTypes.Add("sector", {"cft_sector"})
        dctRecognisedCorruptionTypes.Add("procurement_category", {"ca_type"})
        dctRecognisedCorruptionTypes.Add("winner_name", {"w_name"})
        dctRecognisedCorruptionTypes.Add("winner_id", {"w_id"})
        dctRecognisedCorruptionTypes.Add("winner_country", {"w_country"})
        dctRecognisedCorruptionTypes.Add("original_contract_value", {"ca_contract_amount"})
        dctRecognisedCorruptionTypes.Add("procedure_type", {"ctf_methodtype"})
        dctRecognisedCorruptionTypes.Add("no_bids", {"ca_nrbidsrec"})
        dctRecognisedCorruptionTypes.Add("no_considered_bids", {"ca_nrbidscons"})
        dctRecognisedCorruptionTypes.Add("country_iso", {"iso"})
        dctRecognisedCorruptionTypes.Add("foreign_winner", {"f_winner"})
        dctRecognisedCorruptionTypes.Add("ppp_conversion_rate", {"ppp"})

        ucrDefineCorruptionSelector.SetParameter(New RParameter("data_name", 0))
        ucrDefineCorruptionSelector.SetParameterIsString()

        ucrReceiverCountry.SetParameter(New RParameter("country"))
        ucrReceiverProcuringAuthority.SetParameter(New RParameter("procuring_authority"))
        ucrReceiverProcuringAuthorityID.SetParameter(New RParameter("procuring_authority_id"))
        ucrReceiverAwardDate.SetParameter(New RParameter("award_date"))
        ucrReceiverSignatureDate.SetParameter(New RParameter("signature_date"))
        ucrReceiverContractName.SetParameter(New RParameter("contract_name"))
        ucrReceiverSector.SetParameter(New RParameter("sector"))
        ucrReceiverProcurementCategory.SetParameter(New RParameter("procurement_category"))
        ucrReceiverWinnerName.SetParameter(New RParameter("winner_name"))
        ucrReceiverWinnerID.SetParameter(New RParameter("winner_id"))
        ucrReceiverWinnerCountry.SetParameter(New RParameter("winner_country"))
        ucrReceiverOriginalContractValue.SetParameter(New RParameter("original_contract_value"))
        ucrReceiverProcedureType.SetParameter(New RParameter("procedure_type"))
        ucrReceiverNoBids.SetParameter(New RParameter("no_bids"))
        ucrReceiverNoConsideredBids.SetParameter(New RParameter("no_considered_bids"))
        ucrReceiverCountryISO.SetParameter(New RParameter("country_iso"))
        ucrReceiverForeignWinner.SetParameter(New RParameter("foreign_winner"))
        ucrReceiverPPPConversionRate.SetParameter(New RParameter("ppp_conversion_rate"))

        For Each tmpControl As Control In panClimateType.Controls
            If TypeOf tmpControl Is ucrReceiver Then
                tmpReceiver = DirectCast(tmpControl, ucrReceiver)
                tmpReceiver.Selector = ucrDefineCorruptionSelector
                tmpReceiver.SetParameterIsString()
                tmpReceiver.Tag = tmpReceiver.GetParameter().strArgumentName
                tmpReceiver.bExcludeFromSelector = True
                lstReceivers.Add(tmpReceiver)
            End If
        Next
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        Dim clsDefaultTypesFunction As New RFunction

        ucrDefineCorruptionSelector.Reset()
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$define_as_corruption")
        clsDefaultTypesFunction.SetRCommand("c")
        clsTypesFunction = clsDefaultTypesFunction.Clone()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrBase.clsRsyntax.AddParameter("types", clsRFunctionParameter:=clsTypesFunction)
        ucrReceiverCountry.SetMeAsReceiver()
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        For Each tmpReceiver In lstReceivers
            tmpReceiver.SetRCode(clsTypesFunction)
        Next
        ucrDefineCorruptionSelector.SetRCode(ucrBase.clsRsyntax.clsBaseFunction)
    End Sub

    Private Sub TestOkEnabled()
        'What are the conditons for the teskok enabed here?
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As String()
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrDefineCorruptionSelector.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = dctRecognisedCorruptionTypes(ucrTempReceiver.Tag.ToString())

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrDefineCorruptionSelector.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|", String.Empty).Contains(strValue) Then
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

    Private Sub ucrDefineCorruptionSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDefineCorruptionSelector.ControlValueChanged
        AutoFillReceivers()
    End Sub
End Class