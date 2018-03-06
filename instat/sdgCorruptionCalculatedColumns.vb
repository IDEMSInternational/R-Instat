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

Public Class sdgCorruptionCalculatedColumns
    Public bControlsInitialised As Boolean = False
    Public clsCalculatedColumns As New RFunction
    Dim lstReceivers As New List(Of ucrReceiverSingle)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub sdgCorruptionCalculatedLevels_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        AutoFillReceivers()
    End Sub

    Public Sub InitialiseControls()

        Dim kvpAwardYear As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("award_year", {"year"}.ToList())
        Dim kvpProcedureType As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procedure_type", {"procedure_type"}.ToList())
        Dim kvpProcuringAuthorityID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procuring_authority_id", {"anb_id"}.ToList())
        Dim kvpWinnerID As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("winner_id", {"w_id"}.ToList())
        Dim kvpForeignWinner As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("foreign_winner", {"fsuppl"}.ToList())
        Dim kvpContractValueCategories As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("contr_value_cats", {"ca_contract_valuec"}.ToList())
        Dim kvpProcurementTypeCategories As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procurement_type_cats", {"ca_procedure"}.ToList())
        Dim kvpProcurementType2 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procurement_type2", {"corr_proc"}.ToList())
        Dim kvpProcurementType3 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("procurement_type3", {"corr_proc3"}.ToList())
        Dim kvpSignaturePeriod As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("signature_period", {"ca_signper"}.ToList())
        Dim kvpSignaturePeriodCorrected As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("signature_period_corrected", {"ca_signper_corr"}.ToList())
        Dim kvpSignaturePeriod5 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("signature_period5Q", {"ca_signper_corr5"}.ToList())
        Dim kvpSignaturePeriod25 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("signature_period25Q", {"ca_signper_corr25"}.ToList())
        Dim kvpSignaturePeriodCat As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("signature_period_cats", {"corr_signp"}.ToList())
        Dim kvpRollNumberWinner As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("roll_num_winner", {"nr_c_iw_sum12"}.ToList())
        Dim kvpRollNumberIssuer As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("roll_num_issuer", {"spendconc_nr"}.ToList())
        Dim kvpRollSumWinner As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("roll_sum_winner", {"sz_s_iw_sum12"}.ToList())
        Dim kvpRollSumIssuer As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("roll_sum_issuer", {"sz_s_i_sum12"}.ToList())
        Dim kvpRollShareWinner As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("roll_share_winner", {"corr_spendc"}.ToList())
        Dim kvpSingleBidder As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("single_bidder", {"singleb"}.ToList())
        Dim kvpContractValueShareThreshold As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("contract_value_share_over_threshold", {"corr_spendc2"}.ToList())
        Dim kvpCountryISO2 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("iso2", {"iso2"}.ToList())
        Dim kvpCountryISO3 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("iso3", {"iso3"}.ToList())
        Dim kvpAllBids As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("all_bids", {"ca_bids_all"}.ToList())
        Dim kvpAllBidsTrimmed As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("all_bids_trimmed", {"ca_bids"}.ToList())
        Dim kvpWinnerCountryISO2 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("w_country_iso2", {"w_country_iso2"}.ToList())
        Dim kvpWinnerCountryISO3 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("w_country_iso3", {"w_country_iso3"}.ToList())
        Dim kvpWBPPP As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("ppp_conversion_rate", {"ppp"}.ToList())
        Dim kvpPPPAdjustedContractValue As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("ppp_adjusted_contr_value", {"ca_contract_value"}.ToList())
        Dim kvpSecrecyScore As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("secrecy_score", {"sec_score"}.ToList())
        Dim kvpTaxHaven As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("tax_haven", {"taxhav"}.ToList())
        Dim kvpTaxHaven2 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("tax_haven2", {"taxhav2"}.ToList())
        Dim kvpTaxHaven3 As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("tax_haven3", {"taxhav3"}.ToList())
        Dim kvpTaxHaven3bi As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("tax_haven3bi", {"taxhav3bi"}.ToList())

        lstRecognisedTypes.AddRange({kvpAwardYear, kvpProcedureType, kvpProcuringAuthorityID, kvpWinnerID, kvpForeignWinner, kvpContractValueCategories, kvpProcurementTypeCategories, kvpProcurementType2, kvpProcurementType3, kvpSignaturePeriod,
                                    kvpSignaturePeriodCorrected, kvpSignaturePeriod5, kvpSignaturePeriod25, kvpSignaturePeriodCat, kvpRollNumberWinner, kvpRollNumberIssuer, kvpRollSumWinner, kvpRollSumIssuer, kvpRollShareWinner, kvpSingleBidder, kvpContractValueShareThreshold, kvpCountryISO2, kvpCountryISO3,
                                    kvpAllBids, kvpAllBidsTrimmed, kvpWinnerCountryISO2, kvpWinnerCountryISO3, kvpWBPPP, kvpPPPAdjustedContractValue, kvpSecrecyScore, kvpTaxHaven, kvpTaxHaven2, kvpTaxHaven3, kvpTaxHaven3bi})

        lstReceivers.AddRange({ucrReceiverAwardYear, ucrReceiverProcedureType, ucrReceiverProcuringAuthority, ucrReceiverWinnerID, ucrReceiverForeignWinner, ucrReceiverContractValueCategories, ucrReceiverProcurementTypeCat, ucrReceiverProcurementType2, ucrReceiverProcurementType3, ucrReceiverSignaturePeriod,
                              ucrReceiverSignaturePeriodCorrected, ucrReceiverPeriod5, ucrReceiverPeriod25, ucrReceiverPeriodCat, ucrReceiverRollingNumberWinner, ucrReceiverRollingNumberIssuer, ucrReceiverValueSumWinner, ucrReceiverValueSumIssuer, ucrReceiverValueShareWinner, ucrReceiverSingleBidder, ucrReceiverContractShareThreshold, ucrReceiverCountryISO2, ucrReceiverCountryISO3,
                              ucrReceiverAllBids, ucrReceiverAllBidsTrimmed, ucrReceiverWinnerCountryISO2, ucrReceiverWinnerCountryISO3, ucrReceiverWBPPP, ucrReceiverPPPAdjustedContractValue, ucrReceiverSecrecyScore, ucrReceiverTaxHaven, ucrReceiverTaxHaven2, ucrReceiverTaxHaven3, ucrReceiverTaxHaven3bi})

        ucrReceiverAwardYear.Tag = "award_year"
        ucrReceiverProcedureType.Tag = "procedure_type"
        ucrReceiverProcuringAuthority.Tag = "procuring_authority_id"
        ucrReceiverWinnerID.Tag = "winner_id"
        ucrReceiverForeignWinner.Tag = "foreign_winner"
        ucrReceiverContractValueCategories.Tag = "contr_value_cats"
        ucrReceiverProcurementTypeCat.Tag = "procurement_type_cats"
        ucrReceiverProcurementType2.Tag = "procurement_type2"
        ucrReceiverProcurementType3.Tag = "procurement_type3"
        ucrReceiverSignaturePeriod.Tag = "signature_period"
        ucrReceiverSignaturePeriodCorrected.Tag = "signature_period_corrected"
        ucrReceiverPeriod5.Tag = "signature_period5Q"
        ucrReceiverPeriod25.Tag = "signature_period25Q"
        ucrReceiverPeriodCat.Tag = "signature_period_cats"
        ucrReceiverRollingNumberWinner.Tag = "roll_num_winner"
        ucrReceiverRollingNumberIssuer.Tag = "roll_num_issuer"
        ucrReceiverValueSumWinner.Tag = "roll_sum_winner"
        ucrReceiverValueSumIssuer.Tag = "roll_sum_issuer"
        ucrReceiverValueShareWinner.Tag = "roll_share_winner"
        ucrReceiverSingleBidder.Tag = "single_bidder"
        ucrReceiverContractShareThreshold.Tag = "contract_value_share_over_threshold"
        ucrReceiverCountryISO2.Tag = "iso2"
        ucrReceiverCountryISO3.Tag = "iso3"
        ucrReceiverAllBids.Tag = "all_bids"
        ucrReceiverAllBidsTrimmed.Tag = "all_bids_trimmed"
        ucrReceiverWinnerCountryISO2.Tag = "w_country_iso2"
        ucrReceiverWinnerCountryISO3.Tag = "w_country_iso3"
        ucrReceiverWBPPP.Tag = "ppp_conversion_rate"
        ucrReceiverPPPAdjustedContractValue.Tag = "ppp_adjusted_contr_value"
        ucrReceiverSecrecyScore.Tag = "secrecy_score"
        ucrReceiverTaxHaven.Tag = "tax_haven"
        ucrReceiverTaxHaven.Tag = "tax_haven2"
        ucrReceiverTaxHaven.Tag = "tax_haven3"
        ucrReceiverTaxHaven.Tag = "tax_haven3bi"
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsCalculatedColumns = clsNewRFunction
        SetRCode(Me, clsCalculatedColumns, bReset)
    End Sub

    Private Sub SetRSelector()
        Dim ucrTempReceiver As ucrReceiver
        For Each ucrTempReceiver In lstReceivers
            ucrTempReceiver.SetParameter(New RParameter(ucrTempReceiver.Tag))
            ucrTempReceiver.Selector = ucrCalculatedColumnsSelector
            ucrTempReceiver.SetParameterIsString()
            ucrTempReceiver.bExcludeFromSelector = True
        Next
    End Sub

    Private Sub AutoFillReceivers()
        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrCalculatedColumnsSelector.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrCalculatedColumnsSelector.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        'If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]|_", String.Empty).Contains(strValue) Then
                        '    ucrTempReceiver.Add(lviTempVariable.Text, ucrCalculatedColumnsSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                        '    bFound = True
                        '    Exit For
                        'End If
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

    Private Sub ucrCalculatedColumnsSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCalculatedColumnsSelector.ControlValueChanged
        AutoFillReceivers()
    End Sub
End Class