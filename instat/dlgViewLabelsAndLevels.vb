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

Imports RDotNet
Imports instat.Translations
Public Class dlgViewFactorLabels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strCurrDataFrame As String
    Private clsViewFunction, clsSelectFunction, clsDeleteLabelsFunction As New RFunction
    Private clsDummyDataFunction As New RFunction

    Private Sub dlgLabelAndLevels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        SetReceiverVariableVisible()
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim lstOfControls As New List(Of Control)

        ucrBase.iHelpTopicID = 517
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverVariables.SetParameter(New RParameter("col_names", 1))
        ucrReceiverVariables.SetParameterIsString()
        ucrReceiverVariables.SetParameterIncludeArgumentName(False)
        ucrReceiverVariables.Selector = ucrSelectorViewLabelsAndLevels
        ucrReceiverVariables.SetMeAsReceiver()

        ucrSelectorViewLabelsAndLevels.SetParameter(New RParameter("data_name", 0))
        ucrSelectorViewLabelsAndLevels.SetParameterIsrfunction()

        ucrChkShowLabels.SetParameter(New RParameter("show.labels", 1))
        ucrChkShowLabels.SetText("Show Variable Labels")
        ucrChkShowLabels.SetRDefault("TRUE")

        ucrChkShowType.SetParameter(New RParameter("show.type", 2))
        ucrChkShowType.SetText("Show Column Types")
        ucrChkShowType.SetRDefault("FALSE")

        ucrChkShowValues.SetParameter(New RParameter("show.values", 3))
        ucrChkShowValues.SetText("Show Numeric Values")
        ucrChkShowValues.SetRDefault("TRUE")

        ucrChkShowMissingValues.SetParameter(New RParameter("show.na", 4))
        ucrChkShowMissingValues.SetText("Show Missing Values")
        ucrChkShowMissingValues.SetRDefault("FALSE")

        ucrChkShowId.SetParameter(New RParameter("show.id", 5))
        ucrChkShowId.SetText("Show ID")
        ucrChkShowId.SetRDefault("TRUE")

        ucrChkShowPercentage.SetParameter(New RParameter("show.prc", 6))
        ucrChkShowPercentage.SetText("Show Percentages")
        ucrChkShowPercentage.SetRDefault("FALSE")

        ucrChkShowFrequencies.SetParameter(New RParameter("show.frq", 7))
        ucrChkShowFrequencies.SetText("Show Frequencies")
        ucrChkShowFrequencies.SetRDefault("FALSE")

        ucrChkAlternateColour.SetParameter(New RParameter("altr.row.col", 8))
        ucrChkAlternateColour.SetText("Highlight Alternate Rows")
        ucrChkAlternateColour.SetRDefault("TRUE")

        ucrChkSortByName.SetParameter(New RParameter("sort.by.name", 9))
        ucrChkSortByName.SetText("Sort by Name")
        ucrChkSortByName.SetRDefault("FALSE")

        ucrChkMaxLabels.SetText("Max Labels")
        ucrChkMaxLabels.SetParameter(New RParameter("check", 1))
        ucrChkMaxLabels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkMaxLabels.AddToLinkedControls({ucrNudMaxLength}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="15")

        ucrNudMaxLength.SetParameter(New RParameter("max.len", 10))
        ucrNudMaxLength.Increment = 1
        ucrNudMaxLength.Minimum = 1

        ucrPnlSelectData.SetParameter(New RParameter("checked", 0))
        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame, "data")
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn, "column")

        ucrPnlOptions.AddRadioButton(rdoViewLabels)
        ucrPnlOptions.AddRadioButton(rdoDeleteValueLabels)
        ucrPnlOptions.AddFunctionNamesCondition(rdoViewLabels, "view_df")
        ucrPnlOptions.AddFunctionNamesCondition(rdoDeleteValueLabels, frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        ucrPnlOptions.AddToLinkedControls(ucrChkShowValues, {rdoViewLabels}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverVariables, {rdoViewLabels, rdoDeleteValueLabels}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlSelectData, {rdoDeleteValueLabels}, bNewLinkedHideIfParameterMissing:=True)
        lstOfControls.AddRange({grpDisplayOptions, grpLabels, grpSummaryStatistics, lblFactorColumns})
        ucrChkShowValues.SetLinkedDisplayControl(lstOfControls)
    End Sub

    Private Sub SetDefaults()
        clsViewFunction = New RFunction
        clsSelectFunction = New RFunction
        clsDeleteLabelsFunction = New RFunction
        clsDummyDataFunction = New RFunction

        'Reset
        ucrSelectorViewLabelsAndLevels.Reset()
        'Defining the function
        clsViewFunction.SetPackageName("sjPlot")
        clsViewFunction.SetRCommand("view_df")

        clsDummyDataFunction.AddParameter("checked", "data", iPosition:=0)
        clsDummyDataFunction.AddParameter("check", "FALSE", iPosition:=1)

        clsSelectFunction.SetAssignTo("selected_variables")

        clsDeleteLabelsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsDeleteLabelsFunction.AddParameter("property", Chr(34) & "labels" & Chr(34), iPosition:=2)
        clsDeleteLabelsFunction.AddParameter("new_val", Chr(34) & Chr(34), iPosition:=3)

        clsViewFunction.AddParameter("x", "selected_variables", iPosition:=0)
        clsViewFunction.AddParameter("show.frq", "TRUE")
        clsViewFunction.AddParameter("show.id", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverVariables.AddAdditionalCodeParameterPair(clsDeleteLabelsFunction, New RParameter("col_names", 1), iAdditionalPairNo:=1)

        ucrChkAlternateColour.SetRCode(clsViewFunction, bReset)
        ucrChkShowFrequencies.SetRCode(clsViewFunction, bReset)
        ucrChkShowId.SetRCode(clsViewFunction, bReset)
        ucrChkShowLabels.SetRCode(clsViewFunction, bReset)
        ucrChkShowMissingValues.SetRCode(clsViewFunction, bReset)
        ucrChkSortByName.SetRCode(clsViewFunction, bReset)
        ucrChkShowPercentage.SetRCode(clsViewFunction, bReset)
        ucrChkShowType.SetRCode(clsViewFunction, bReset)
        ucrChkShowValues.SetRCode(clsViewFunction, bReset)
        ucrChkMaxLabels.SetRCode(clsDummyDataFunction, bReset)
        ucrNudMaxLength.SetRCode(clsViewFunction, bReset)
        ucrReceiverVariables.SetRCode(clsSelectFunction, bReset)
        ucrPnlSelectData.SetRCode(clsDummyDataFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoViewLabels.Checked Then
            If Not ucrReceiverVariables.IsEmpty AndAlso (ucrChkShowLabels.Checked OrElse ucrChkShowType.Checked OrElse
                ucrChkShowValues.Checked OrElse ucrChkShowFrequencies.Checked OrElse ucrChkShowPercentage.Checked) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If rdoWholeDataFrame.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoSelectedColumn.Checked AndAlso Not ucrReceiverVariables.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetReceiverVariableVisible()
        If rdoDeleteValueLabels.Checked Then
            ucrReceiverVariables.Visible = rdoSelectedColumn.Checked
        End If
    End Sub

    Private Sub ucrPnlSelectData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged, ucrPnlOptions.ControlValueChanged, ucrReceiverVariables.ControlValueChanged
        SetReceiverVariableVisible()
        If rdoViewLabels.Checked Then
            ucrReceiverVariables.SetParameterIsRFunction()
            ucrReceiverVariables.Location = New System.Drawing.Point(295, 84)
            ucrSelectorViewLabelsAndLevels.HideShowAddOrDataOptionsOrListView(True, True, True)
            ucrReceiverVariables.bWithQuotes = False
            ucrBase.clsRsyntax.AddToBeforeCodes(clsSelectFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsViewFunction)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSelectFunction)
            ucrReceiverVariables.Location = New System.Drawing.Point(302, 109)
            ucrReceiverVariables.bWithQuotes = True
            strCurrDataFrame = ucrSelectorViewLabelsAndLevels.ucrAvailableDataFrames.strCurrDataFrame
            clsDeleteLabelsFunction.AddParameter("data_name", Chr(34) & strCurrDataFrame & Chr(34), iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteLabelsFunction)
            If rdoWholeDataFrame.Checked Then
                ucrSelectorViewLabelsAndLevels.HideShowAddOrDataOptionsOrListView(False, False, False)
                clsDeleteLabelsFunction.RemoveParameterByName("col_names")
            ElseIf rdoSelectedColumn.Checked Then
                ucrSelectorViewLabelsAndLevels.HideShowAddOrDataOptionsOrListView(True, True, True)
                clsDeleteLabelsFunction.AddParameter("col_names", ucrReceiverVariables.GetVariableNames(bWithQuotes:=True), iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrReceiverFactorColumns_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariables.ControlContentsChanged,
        ucrChkShowFrequencies.ControlContentsChanged, ucrChkShowLabels.ControlContentsChanged, ucrChkShowPercentage.ControlContentsChanged,
        ucrChkShowType.ControlContentsChanged, ucrChkShowValues.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class