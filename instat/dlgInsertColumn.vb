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

Imports instat
Imports instat.Translations
Public Class dlgInsertColumn
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsInsertRowFunction, clsInsertColumnFunction As New RFunction
    Private Sub dlgInsertColumn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
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
        ucrBase.iHelpTopicID = 164

        ucrReceiverColumnsToInsert.Selector = ucrSelectorInsertColumns
        ucrReceiverColumnsToInsert.SetMeAsReceiver()
        ucrReceiverColumnsToInsert.SetParameter(New RParameter("adjacent_column"))
        ucrReceiverColumnsToInsert.SetParameterIsString()

        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertColumns)
        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertRows)

        ucrPnlBeforeAfter.SetParameter(New RParameter("before"))
        ucrPnlBeforeAfter.AddRadioButton(rdoBefore, "FALSE")
        ucrPnlBeforeAfter.AddRadioButton(rdoAfter, "TRUE")

        ucrDataFramesList.SetParameter(New RParameter("data_name"))
        ucrDataFramesList.SetParameterIsString()
        ucrNudNumberOfRows.SetParameter(New RParameter("number_rows"))
        ucrNudStartRow.SetParameter(New RParameter("start_row"))
        ucrNudNumberOfRows.SetRDefault(1)
        ucrNudNumberOfColumns.SetRDefault(1)


        Dim dctBeforeAfter As New Dictionary(Of String, String)
        ucrInputBeforeAfter.SetParameter(New RParameter("before"))
        dctBeforeAfter.Add("Before", "FALSE")
        dctBeforeAfter.Add("After", "TRUE")
        ucrInputBeforeAfter.SetItems(dctBeforeAfter)
        ucrInputBeforeAfter.SetRDefault("FALSE")


        ucrPnlStartEnd.SetParameter(ucrInputBeforeAfter.GetParameter)
        ucrPnlStartEnd.AddRadioButton(rdoAtEnd, "FALSE")
        ucrPnlStartEnd.AddRadioButton(rdoAtStart, "TRUE")
        ucrPnlStartEnd.AddRadioButton(rdoBeforeAfter, "FALSE")

        ucrNudNumberOfColumns.SetParameter(New RParameter("num_cols"))
        ucrInputDefaultValue.SetParameter(New RParameter("col_data"))
        ucrSaveInsertColumn.SetParameter(New RParameter("col_name"))
        ucrInputDefaultValue.SetRDefault("NA")

        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertRows, frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertColumns, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        'Setting Display of the group boxes in the dialog
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlStartEnd, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputBeforeAfter, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfColumns, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputDefaultValue, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrSaveInsertColumn, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlBeforeAfter, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfRows, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudStartRow, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.AddToLinkedControls(ucrSelectorInsertColumns, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlBeforeAfter.SetLinkedDisplayControl(grpOPtions)
        ucrPnlStartEnd.AddToLinkedControls(ucrInputBeforeAfter, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.SetLinkedDisplayControl(grpInsert)
        'ucrSelectorInsertColumns.AddToLinkedControls(ucrNudStartRow, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudNumberOfColumns.SetLinkedDisplayControl(lblNumberOfColumnsToInsert)
        ucrInputDefaultValue.SetLinkedDisplayControl(lblDefaultValue)
        ucrNudNumberOfRows.SetLinkedDisplayControl(lblNumberOfRowsToInsert)
        ucrNudStartRow.SetLinkedDisplayControl(lblStartPos)

        ucrSaveInsertColumn.SetPrefix("X")
        ucrSaveInsertColumn.SetSaveTypeAsColumn()
        ucrSaveInsertColumn.SetIsTextBox()
        ucrSaveInsertColumn.SetLabelText("Prefix For New Column:")

    End Sub

    Private Sub SetDefaults()
        clsInsertColumnFunction = New RFunction
        clsInsertRowFunction = New RFunction
        ucrSelectorInsertColumns.Reset()
        ucrDataFramesList.Reset()

        clsInsertColumnFunction.AddParameter("before", "FALSE")
        clsInsertRowFunction.AddParameter("before", "FALSE")
        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsInsertRowFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsInsertRowFunction.AddParameter("start_row", ucrDataFramesList.iDataFrameLength)

        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertRowFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrDataFramesList.AddAdditionalCodeParameterPair(clsInsertColumnFunction, New RParameter("data_name"), iAdditionalPairNo:=1)

        ucrPnlStartEnd.AddAdditionalCodeParameterPair(clsInsertColumnFunction, New RParameter("before"), iAdditionalPairNo:=1)
        ucrDataFramesList.SetParameterIsString()

        ucrNudNumberOfRows.SetRCode(clsInsertRowFunction, bReset)
        ucrNudStartRow.SetRCode(clsInsertRowFunction, bReset)
        ucrDataFramesList.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlBeforeAfter.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlStartEnd.SetRCode(clsInsertColumnFunction, bReset)
        ucrNudNumberOfColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputDefaultValue.SetRCode(clsInsertColumnFunction, bReset)
        ucrSaveInsertColumn.SetRCode(clsInsertColumnFunction, bReset)
        ucrReceiverColumnsToInsert.SetRCode(clsInsertColumnFunction, bReset)
        ucrDataFramesList.SetRCode(clsInsertColumnFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'If rdoInsertColumns.Checked Then
        '    If ((ucrNudNumberOfColumns.Text <> "") And (Not ucrInputDefaultValue.IsEmpty) And (Not ucrInputPrefixForInsertedColumns.IsEmpty) And (ucrDataFramesList.cboAvailableDataFrames.Text <> "")) Then
        '        ucrBase.OKEnabled(True)
        '    Else
        '        ucrBase.OKEnabled(False)

        '    End If
        'ElseIf rdoInsertRows.Checked Then
        '    If ((ucrNudNumberOfRows.Text <> "") And (ucrNudStartRow.Text <> "") And (ucrDataFramesList.cboAvailableDataFrames.Text <> "")) Then
        '        ucrBase.OKEnabled(True)
        '    Else
        '        ucrBase.OKEnabled(False)
        '    End If
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
        ucrBase.OKEnabled(True)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumnsOrRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnsOrRows.ControlValueChanged
        If rdoInsertColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
        ElseIf rdoInsertRows.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertRowFunction)
        End If
    End Sub
End Class