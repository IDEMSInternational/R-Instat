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
Public Class dlgDefineCorruption
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

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
    End Sub
    Private Sub InitialiseDialog()
        Dim dctRecognisedCorruptionTypes As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = ""

        dctRecognisedCorruptionTypes.Add("Country", "")
        dctRecognisedCorruptionTypes.Add("Procuring Authority", "")
        dctRecognisedCorruptionTypes.Add("Procuring Authority ID", "")
        dctRecognisedCorruptionTypes.Add("Award Date", "")
        dctRecognisedCorruptionTypes.Add("Signature Date", "")
        dctRecognisedCorruptionTypes.Add("Contract Name", "")
        dctRecognisedCorruptionTypes.Add("Sector", "")
        dctRecognisedCorruptionTypes.Add("Procurement Category", "")
        dctRecognisedCorruptionTypes.Add("Winner Name", "")
        dctRecognisedCorruptionTypes.Add("Winner ID", "")
        dctRecognisedCorruptionTypes.Add("Winner Country", "")
        dctRecognisedCorruptionTypes.Add("Original Contract Value", "")
        dctRecognisedCorruptionTypes.Add("Procedure Type", "")
        dctRecognisedCorruptionTypes.Add("No Bids", "")
        dctRecognisedCorruptionTypes.Add("No Considered Bids", "")
        dctRecognisedCorruptionTypes.Add("Country ISO", "")
        dctRecognisedCorruptionTypes.Add("Foreign Winner", "")
        dctRecognisedCorruptionTypes.Add("PPP Conversion Rate", "")


        ucrDefineCorruptionSelector.SetParameter(New RParameter("data_name", 0))
        ucrDefineCorruptionSelector.SetParameterIsString()

        ucrReceiverCountry.Selector = ucrDefineCorruptionSelector
        ucrReceiverCountry.SetParameter(New RParameter(""))

        ucrReceiverProcuringAuthority.Selector = ucrDefineCorruptionSelector
        ucrReceiverProcuringAuthority.SetParameter(New RParameter(""))

        ucrReceiverProcuringAuthorityID.Selector = ucrDefineCorruptionSelector
        ucrReceiverProcuringAuthorityID.SetParameter(New RParameter(""))

        ucrReceiverAwardDate.Selector = ucrDefineCorruptionSelector
        ucrReceiverAwardDate.SetParameter(New RParameter(""))

        ucrReceiverSignatureDate.Selector = ucrDefineCorruptionSelector
        ucrReceiverSignatureDate.SetParameter(New RParameter(""))

        ucrReceiverContractName.Selector = ucrDefineCorruptionSelector
        ucrReceiverContractName.SetParameter(New RParameter(""))

        ucrReceiverProcurementCategory.Selector = ucrDefineCorruptionSelector
        ucrReceiverProcurementCategory.SetParameter(New RParameter(""))

        ucrReceiverWinnerName.Selector = ucrDefineCorruptionSelector
        ucrReceiverWinnerName.SetParameter(New RParameter(""))

        ucrReceiverWinnerID.Selector = ucrDefineCorruptionSelector
        ucrReceiverWinnerID.SetParameter(New RParameter(""))

        ucrReceiverWinnerCountry.Selector = ucrDefineCorruptionSelector
        ucrReceiverWinnerCountry.SetParameter(New RParameter(""))

        ucrReceiverOriginalContractValue.Selector = ucrDefineCorruptionSelector
        ucrReceiverOriginalContractValue.SetParameter(New RParameter(""))

        ucrReceiverProcedureType.Selector = ucrDefineCorruptionSelector
        ucrReceiverProcedureType.SetParameter(New RParameter(""))

        ucrReceiverNoBids.Selector = ucrDefineCorruptionSelector
        ucrReceiverNoBids.SetParameter(New RParameter(""))

        ucrReceiverNoConsideredBids.Selector = ucrDefineCorruptionSelector
        ucrReceiverNoConsideredBids.SetParameter(New RParameter(""))

        ucrReceiverCountryISO.Selector = ucrDefineCorruptionSelector
        ucrReceiverCountryISO.SetParameter(New RParameter(""))

        ucrReceiverForeignWinner.Selector = ucrDefineCorruptionSelector
        ucrReceiverForeignWinner.SetParameter(New RParameter(""))

        ucrReceiverPPPConversionRate.Selector = ucrDefineCorruptionSelector
        ucrReceiverPPPConversionRate.SetParameter(New RParameter(""))

        ucrReceiverCountry.SetMeAsReceiver()

    End Sub

    Private Sub SetDefaults()
        Dim ClsDefaultFunction As New RFunction

        ucrDefineCorruptionSelector.Reset()
        ClsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "")
        ucrBase.clsRsyntax.SetBaseRFunction(ClsDefaultFunction.Clone)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub
    Private Sub TestOkEnabled()
        'What are the conditons for the teskok enabed here?
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class