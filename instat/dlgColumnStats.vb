﻿' R- Instat
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
Public Class dlgColumnStats
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction, clsConcFunction As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultVariables() As String
    Public strDefaultFactors() As String

    Private Sub dlgColumnStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultColumns()
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 64

        ucrChkDropUnusedLevels.Enabled = False ' removed this functionality so this is disabled

        ucrSelectorForColumnStatistics.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForColumnStatistics.SetParameterIsString()

        ' only allow numeric variables in the first receiver, this will change once freq. tables is added
        ucrReceiverSelectedVariables.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverSelectedVariables.SetParameterIsString()
        ucrReceiverSelectedVariables.Selector = ucrSelectorForColumnStatistics

        ucrReceiverByFactor.SetParameter(New RParameter("factors", 2))
        ucrReceiverByFactor.Selector = ucrSelectorForColumnStatistics
        ucrReceiverByFactor.SetExcludedDataTypes({"numeric"})
        ucrReceiverByFactor.strSelectorHeading = "Non-numeric(s)"
        ucrReceiverByFactor.SetParameterIsString()

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 3))
        ucrChkStoreResults.SetText("Store Results")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkOriginalLevel.SetParameter(New RParameter("original_level", 7))
        ucrChkOriginalLevel.SetText("Original Level")
        ucrChkOriginalLevel.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOriginalLevel.SetRDefault("FALSE")

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

        'linking
        ucrChkStoreResults.AddToLinkedControls(ucrChkOriginalLevel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsConcFunction = New RFunction

        ucrSelectorForColumnStatistics.Reset()
        sdgProportionsPercentages.ucrSelectorProportionsPercentiles.Reset()
        ucrReceiverSelectedVariables.SetMeAsReceiver()

        clsConcFunction.SetRCommand("c")

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_count_non_missing", Chr(34) & "summary_count_non_missing" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_count", Chr(34) & "summary_count" & Chr(34), bIncludeArgumentName:=False)
        clsSummariesList.AddParameter("summary_sum", Chr(34) & "summary_sum" & Chr(34), bIncludeArgumentName:=False)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$calculate_summary")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList)
        'Prevents an error if user chooses non count summaries with no columns to summarise
        clsDefaultFunction.AddParameter("silent", "TRUE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub SetDefaultColumns()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForColumnStatistics.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultVariables IsNot Nothing AndAlso strDefaultVariables.Count > 0 Then
            ucrReceiverSelectedVariables.Clear()
            For Each strVar As String In strDefaultVariables
                ucrReceiverSelectedVariables.Add(strVar, strDefaultDataFrame)
            Next
        End If
        If strDefaultFactors IsNot Nothing AndAlso strDefaultFactors.Count > 0 Then
            ucrReceiverByFactor.Clear()
            For Each strVar As String In strDefaultFactors
                ucrReceiverByFactor.Add(strVar, strDefaultDataFrame)
            Next
        End If
        strDefaultDataFrame = ""
        strDefaultVariables = Nothing
        strDefaultFactors = Nothing
    End Sub

    Public Sub TestOKEnabled()
        If ((ucrChkStoreResults.Checked OrElse ucrChkPrintOutput.Checked) AndAlso Not clsSummariesList.clsParameters.Count = 0) AndAlso sdgSummaries.bOkEnabled Then
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
        sdgSummaries.SetRFunction(clsSummariesList, clsDefaultFunction, clsConcFunction, ucrSelectorForColumnStatistics, bResetSubdialog)
        sdgSummaries.ShowDialog()
        bResetSubdialog = False
        TestOKEnabled()
    End Sub

    Private Sub cmdProportionsPercentages_Click(sender As Object, e As EventArgs) Handles cmdProportionsPercentages.Click
        sdgProportionsPercentages.SetRFunction(clsDefaultFunction, bResetSubdialog)
        sdgProportionsPercentages.ShowDialog()
        bResetSubdialog = False
        TestOKEnabled()
    End Sub

    Private Sub ucrChkOmitMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissing.ControlValueChanged
        If clsSummariesList.ContainsParameter("summary_cor") OrElse clsSummariesList.ContainsParameter("summary_cov") Then
            clsDefaultFunction.AddParameter("use", Chr(34) & "'na.or.complete'" & Chr(34))
        Else
            clsDefaultFunction.RemoveParameterByName("use")
        End If
    End Sub

    Private Sub ucrChkPrintOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintOutput.ControlValueChanged
        If ucrChkPrintOutput.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
        Else
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkPrintOutput.ControlContentsChanged, ucrChkStoreResults.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class