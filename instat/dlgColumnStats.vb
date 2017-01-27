
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
Public Class dlgColumnStats
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction

    Private Sub dlgColumnStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        ' TestOKEnabled()
    End Sub

    Public Sub TestOKEnabled()
        If (Not ucrReceiverSelectedVariables.IsEmpty() AndAlso Not sdgSummaries.strSummariesParameter = "c()") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorForColumnStatistics.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ucrReceiverSelectedVariables.SetMeAsReceiver()
        'TODO get the subdilog stuff working
        ' TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 64

        ucrReceiverSelectedVariables.Selector = ucrSelectorForColumnStatistics
        ' only allow numeric variables in the first receiver? 
        ucrReceiverSelectedVariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelectedVariables.SetParameter(New RParameter("columns_to_summarise"))
        ucrReceiverSelectedVariables.SetParameterIsString()

        ucrReceiverByFactor.Selector = ucrSelectorForColumnStatistics
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"}) 'This needs to change
        ucrReceiverByFactor.SetParameter(New RParameter("factors"))
        ucrReceiverByFactor.SetParameterIsString()

        ucrSelectorForColumnStatistics.SetParameter(New RParameter("data_name"))
        ucrSelectorForColumnStatistics.SetParameterIsString()

        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetParameter(New RParameter("store_results"))
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")


        ucrChkPrintOutput.SetText("Print Results to Output Window")
        ucrChkPrintOutput.SetParameter(New RParameter("return_output"))
        ucrChkPrintOutput.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkdropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkdropUnusedLevels.SetParameter(New RParameter("drop"))
        ucrChkdropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")


        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm"))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")


        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")

        'i leave the subdialog stuff for now
        'sdgSummaries.SetMyRFunction(clsDefaultFunction)
        'ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        'SetDefaults()
        'TestOKEnabled()
    End Sub
    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        'sdgSummaries.ShowDialog()
        'sdgSummaries.TestSummaries()
        'TestOKEnabled()
    End Sub


End Class