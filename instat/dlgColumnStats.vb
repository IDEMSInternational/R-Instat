
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
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private Sub dlgColumnStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub


    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverSelectedVariables.IsEmpty() Then ' AndAlso Not sdgSummaries.strSummariesParameter = "c()") 
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        clsSummariesList = New RFunction

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        ucrSelectorForColumnStatistics.Reset()
        ucrReceiverSelectedVariables.SetMeAsReceiver()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        bResetSubdialog = True
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 64

        ucrReceiverSelectedVariables.Selector = ucrSelectorForColumnStatistics
        ' only allow numeric variables in the first receiver? 
        ucrReceiverSelectedVariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelectedVariables.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSelectedVariables.SetParameterIsString()

        ucrReceiverByFactor.Selector = ucrSelectorForColumnStatistics
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"}) 'This needs to change
        ucrReceiverByFactor.SetParameter(New RParameter("factors", 2))
        ucrReceiverByFactor.SetParameterIsString()

        ucrSelectorForColumnStatistics.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForColumnStatistics.SetParameterIsString()

        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetParameter(New RParameter("store_results", 3))
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkPrintOutput.SetText("Print Results to Output Window")
        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 4))
        ucrChkPrintOutput.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkdropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkdropUnusedLevels.SetParameter(New RParameter("drop", 5))
        ucrChkdropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkdropUnusedLevels.SetRDefault("FALSE")

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub
    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedVariables.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class