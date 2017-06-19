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
    Private clsDefaultFunction As New RFunction

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

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 64
        ucrChkDropUnusedLevels.Enabled = False ' removed this functionality so this is disabled

        ucrSelectorForColumnStatistics.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForColumnStatistics.SetParameterIsString()

        ' only allow numeric variables in the first receiver, this will change once freq. tables is added
        ucrReceiverSelectedVariables.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSelectedVariables.SetParameterIsString()
        ucrReceiverSelectedVariables.SetIncludedDataTypes({"numeric"})
        ucrReceiverSelectedVariables.strSelectorHeading = "Numerics"
        ucrReceiverSelectedVariables.Selector = ucrSelectorForColumnStatistics

        ucrReceiverByFactor.SetParameter(New RParameter("factors", 2))
        ucrReceiverByFactor.Selector = ucrSelectorForColumnStatistics
        ucrReceiverByFactor.SetIncludedDataTypes({"factor"}) 'This needs to change
        ucrReceiverByFactor.strSelectorHeading = "Factors"
        ucrReceiverByFactor.SetParameterIsString()

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 3))
        ucrChkStoreResults.SetText("Store Results in Data Frame")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 4))
        ucrChkPrintOutput.SetText("Print Results to Output Window")
        ucrChkPrintOutput.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkDropUnusedLevels.SetParameter(New RParameter("drop", 5))
        ucrChkDropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkDropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropUnusedLevels.SetRDefault("FALSE")

        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction

        ucrSelectorForColumnStatistics.Reset()
        ucrReceiverSelectedVariables.SetMeAsReceiver()

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub TestOKEnabled()
        If Not ucrReceiverSelectedVariables.IsEmpty AndAlso Not ucrReceiverByFactor.IsEmpty AndAlso Not clsSummariesList.clsParameters.Count = 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
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

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSelectedVariables.ControlContentsChanged, ucrReceiverByFactor.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class