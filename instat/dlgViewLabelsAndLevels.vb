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
Public Class dlgViewFactorLabels
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim strCurrDataFrame As String
    Private clsViewFunction, clsSelectFunction, clsDeleteLabelsFunction As RFunction
    Private clsDummyFunction, clsDummyDataFunction As New RFunction
    Private iXReceiverLocation, iYReceiverLoaction, iXLabelLocation, iYLabelLoaction As Integer

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

        iXReceiverLocation = ucrReceiverVariables.Location.X
        iYReceiverLoaction = ucrReceiverVariables.Location.Y
        iXLabelLocation = lblFactorColumns.Location.X
        iYLabelLoaction = lblFactorColumns.Location.Y

        ucrBase.iHelpTopicID = 517
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverVariables.SetParameter(New RParameter("x", 1))
        ucrReceiverVariables.SetParameterIsString()
        ucrReceiverVariables.SetParameterIncludeArgumentName(False)
        ucrReceiverVariables.SetIncludedDataTypes({"factor", "numeric"})
        ucrReceiverVariables.Selector = ucrSelectorViewLabelsAndLevels
        ucrReceiverVariables.SetMeAsReceiver()

        ucrSelectorViewLabelsAndLevels.SetParameter(New RParameter(".data", 0))
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

        ucrPnlSelectData.SetParameter(New RParameter("checked", 0))
        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame, "data")
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn, "column")

        ucrPnlOptions.SetParameter(New RParameter("checked", 0))
        ucrPnlOptions.AddRadioButton(rdoViewLabels, "labels")
        ucrPnlOptions.AddRadioButton(rdoDeleteValueLabels, "delete")
        ucrPnlOptions.AddToLinkedControls(ucrChkShowValues, {rdoViewLabels}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverVariables, {rdoViewLabels, rdoDeleteValueLabels}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrPnlSelectData, {rdoDeleteValueLabels}, bNewLinkedHideIfParameterMissing:=True)
        lstOfControls.Add(grpDisplayOptions)
        lstOfControls.Add(grpLabels)
        lstOfControls.Add(grpSummaryStatistics)
        ucrChkShowValues.SetLinkedDisplayControl(lstOfControls)
        ucrReceiverVariables.SetLinkedDisplayControl(lblFactorColumns)

    End Sub

    Private Sub SetDefaults()
        clsViewFunction = New RFunction
        clsSelectFunction = New RFunction
        clsDeleteLabelsFunction = New RFunction
        clsDummyFunction = New RFunction
        clsDummyDataFunction = New RFunction

        'Reset
        ucrSelectorViewLabelsAndLevels.Reset()
        'Defining the function
        clsViewFunction.SetPackageName("sjPlot")
        clsViewFunction.SetRCommand("view_df")

        clsDummyFunction.AddParameter("checked", "labels", iPosition:=0)

        clsDummyDataFunction.AddParameter("checked", "data", iPosition:=0)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")

        clsDeleteLabelsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$append_to_variables_metadata")
        clsDeleteLabelsFunction.AddParameter("property", Chr(34) & "labels" & Chr(34), iPosition:=2)
        clsDeleteLabelsFunction.AddParameter("new_val", Chr(34) & "NA" & Chr(34), iPosition:=3)

        clsViewFunction.AddParameter("x", clsRFunctionParameter:=clsSelectFunction)
        clsViewFunction.AddParameter("show.frq", "TRUE")
        clsViewFunction.AddParameter("show.id", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsViewFunction)
    End Sub

    Private Sub ucrReceiverVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariables.ControlValueChanged
        If rdoDeleteValueLabels.Checked Then
            strCurrDataFrame = ucrSelectorViewLabelsAndLevels.ucrAvailableDataFrames.strCurrDataFrame
            clsDeleteLabelsFunction.AddParameter("data_name", Chr(34) & strCurrDataFrame & Chr(34), iPosition:=0)
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
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
        ucrReceiverVariables.SetRCode(clsSelectFunction, bReset)
        ucrSelectorViewLabelsAndLevels.SetRCode(clsSelectFunction, bReset)
        ucrPnlSelectData.SetRCode(clsDummyDataFunction, bReset)
        ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoSelectedColumn.Checked Then
            If (Not (ucrReceiverVariables.IsEmpty) AndAlso (ucrChkShowLabels.Checked OrElse ucrChkShowType.Checked OrElse ucrChkShowValues.Checked OrElse ucrChkShowFrequencies.Checked OrElse ucrChkShowPercentage.Checked)) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If rdoWholeDataFrame.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoSelectedColumn.Checked AndAlso Not (ucrReceiverVariables.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Function GetColumns() As List(Of String)
        Dim lstColumns As List(Of String)
        Dim chrCurrColumns As 
            Dim expItems As
        Dim clsGetColumns As New RFunction

        If rdoWholeDataFrame IsNot Nothing Then
            clsGetColumns.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_names")
            clsGetColumns.AddParameter("data_name", Chr(34) & strCurrDataFrame& Chr(34), iPosition:=0)
            clsGetColumns.AddParameter("as_list", "TRUE")
            expItems = frmMain.clsRLink.RunInternalScriptGetValue(clsGetColumns.ToScript(), bSilent:=True)
            If expItems IsNot Nothing AndAlso Not expItems.Type = Internals.SymbolicExpressionType.Null Then
                vecColumns = expItems.AsList
                For i As Integer = 0 To vecColumns.Count - 1
                    chrCurrColumns = vecColumns(i).AsCharacter
                    Dim strText As String = vecColumns.Names(i)

                    If chrCurrColumns IsNot Nothing Then
                        grdCurrentWorkSheet.RowCount = chrCurrColumns.Count
                        For j As Integer = 0 To chrCurrColumns.Count - 1
                            grdCurrentWorkSheet.Item(row:=j, col:=0) = chrCurrColumns(j)
                            grdCurrentWorkSheet.GetCell(row:=j, col:=0).IsReadOnly = True
                            grdCurrentWorkSheet.Item(row:=j, col:=1) = chrCurrColumns(j)
                        Next
    End Function

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetReceiverVariableVisible()
        If rdoDeleteValueLabels.Checked Then
            ucrReceiverVariables.Visible = If(rdoSelectedColumn.Checked, True, False)
        End If
    End Sub

    Private Sub ucrPnlSelectData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        SetReceiverVariableVisible()
        If rdoViewLabels.Checked Then
            lblFactorColumns.Location = New System.Drawing.Point(iXLabelLocation, iYLabelLoaction)
            ucrReceiverVariables.Location = New System.Drawing.Point(iXReceiverLocation, iYReceiverLoaction)
            ucrSelectorViewLabelsAndLevels.lstAvailableVariable.Visible = True
            ucrSelectorViewLabelsAndLevels.btnAdd.Visible = True
            ucrSelectorViewLabelsAndLevels.btnDataOptions.Visible = True
            ucrReceiverVariables.bWithQuotes = False
            ucrBase.clsRsyntax.SetBaseRFunction(clsViewFunction)
        Else
            lblFactorColumns.Location = New System.Drawing.Point(300, 114)
            ucrReceiverVariables.Location = New System.Drawing.Point(300, 131)
            ucrReceiverVariables.bWithQuotes = True
            ucrBase.clsRsyntax.SetBaseRFunction(clsDeleteLabelsFunction)
            If rdoWholeDataFrame.Checked Then
                ucrSelectorViewLabelsAndLevels.lstAvailableVariable.Visible = False
                ucrSelectorViewLabelsAndLevels.btnAdd.Visible = False
                ucrSelectorViewLabelsAndLevels.btnDataOptions.Visible = False
            ElseIf rdoSelectedColumn.Checked Then
                ucrSelectorViewLabelsAndLevels.lstAvailableVariable.Visible = True
                ucrSelectorViewLabelsAndLevels.btnAdd.Visible = True
                ucrSelectorViewLabelsAndLevels.btnDataOptions.Visible = True
            End If
        End If
    End Sub

    Private Sub ucrReceiverFactorColumns_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVariables.ControlContentsChanged, ucrChkShowFrequencies.ControlContentsChanged, ucrChkShowLabels.ControlContentsChanged, ucrChkShowPercentage.ControlContentsChanged, ucrChkShowType.ControlContentsChanged, ucrChkShowValues.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class