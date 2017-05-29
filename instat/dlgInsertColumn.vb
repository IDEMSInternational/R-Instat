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
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertRows, frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertColumns, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")

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

        ucrPnlStartEnd.SetParameter(New RParameter("before"))
        ucrPnlStartEnd.AddRadioButton(rdoAtStart, "TRUE")
        ucrPnlStartEnd.AddRadioButton(rdoAtEnd, "FALSE")
        ucrPnlStartEnd.AddRadioButton(rdoBeforeAfter)
        'ucrPnlStartEnd.AddRadioButton(rdoBeforeAfter, "FALSE")
        ucrPnlStartEnd.bAllowNonConditionValues = True

        ucrNudNumberOfColumns.SetParameter(New RParameter("num_cols"))
        ucrInputDefaultValue.SetParameter(New RParameter("col_data"))
        ucrInputPrefixForNewColumn.SetParameter(New RParameter("col_name"))
        ucrInputDefaultValue.SetName("NA")

        ucrPnlStartEnd.AddParameterValuesCondition(rdoAtStart, "before", "FALSE")
        ucrPnlStartEnd.AddParameterValuesCondition(rdoAtStart, "before", "TRUE", False)
        ucrPnlStartEnd.AddParameterPresentCondition(rdoAtStart, "adjacent", False)

        ucrPnlStartEnd.AddParameterValuesCondition(rdoAtEnd, "before", "TRUE")
        ucrPnlStartEnd.AddParameterValuesCondition(rdoAtEnd, "before", "FALSE", False)
        ucrPnlStartEnd.AddParameterPresentCondition(rdoAtEnd, "adjacent", False)

        ucrPnlStartEnd.AddParameterValuesCondition(rdoBeforeAfter, "before", {"TRUE", "FALSE"})
        ucrPnlStartEnd.AddParameterPresentCondition(rdoBeforeAfter, "adjacent")

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlStartEnd, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputBeforeAfter, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfColumns, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputDefaultValue, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputPrefixForNewColumn, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlBeforeAfter, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfRows, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudStartRow, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.AddToLinkedControls(ucrSelectorInsertColumns, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlBeforeAfter.SetLinkedDisplayControl(grpOPtions)
        ucrPnlStartEnd.AddToLinkedControls(ucrInputBeforeAfter, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.SetLinkedDisplayControl(grpInsert)
        ucrNudNumberOfColumns.SetLinkedDisplayControl(lblNumberOfColumnsToInsert)
        ucrInputDefaultValue.SetLinkedDisplayControl(lblDefaultValue)
        ucrNudNumberOfRows.SetLinkedDisplayControl(lblNumberOfRowsToInsert)
        ucrNudStartRow.SetLinkedDisplayControl(lblStartPos)
        ucrInputPrefixForNewColumn.SetPrefix("X")

    End Sub

    Private Sub SetDefaults()
        clsInsertColumnFunction = New RFunction
        clsInsertRowFunction = New RFunction

        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsInsertRowFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")

        ucrSelectorInsertColumns.Reset()
        ucrDataFramesList.Reset()
        ucrInputBeforeAfter.Reset()
        ucrInputDefaultValue.Reset()
        ucrInputPrefixForNewColumn.Reset()
        ucrInputPrefixForNewColumn.SetName("X")
        ucrInputDefaultValue.SetName("NA")

        clsInsertColumnFunction.AddParameter("use_col_name_as_prefix", "TRUE")
        clsInsertColumnFunction.AddParameter("before", "FALSE")
        'clsInsertColumnFunction.AddParameter("before", "TRUE")
        clsInsertRowFunction.AddParameter("before", "FALSE")
        clsInsertRowFunction.AddParameter("start_row", ucrDataFramesList.iDataFrameLength)
        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrDataFramesList.AddAdditionalCodeParameterPair(clsInsertColumnFunction, New RParameter("data_name"), iAdditionalPairNo:=1)
        ucrDataFramesList.SetParameterIsString()

        ucrNudNumberOfRows.SetRCode(clsInsertRowFunction, bReset)
        ucrNudStartRow.SetRCode(clsInsertRowFunction, bReset)
        ucrDataFramesList.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlBeforeAfter.SetRCode(clsInsertRowFunction, bReset)

        ucrNudNumberOfColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputDefaultValue.SetRCode(clsInsertColumnFunction, bReset)

        ucrInputPrefixForNewColumn.SetRCode(clsInsertColumnFunction, bReset)
        ucrReceiverColumnsToInsert.SetRCode(clsInsertColumnFunction, bReset)
        ucrDataFramesList.SetRCode(clsInsertColumnFunction, bReset)
        ucrPnlColumnsOrRows.SetRCode(clsInsertColumnFunction, bReset)
        ucrPnlStartEnd.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputBeforeAfter.SetRCode(clsInsertColumnFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ((rdoInsertColumns.Checked AndAlso (rdoAtEnd.Checked OrElse rdoAtStart.Checked)) AndAlso ucrNudNumberOfColumns.GetText <> "" AndAlso Not ucrInputDefaultValue.IsEmpty AndAlso Not ucrInputPrefixForNewColumn.IsEmpty) Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoInsertColumns.Checked AndAlso rdoBeforeAfter.Checked AndAlso Not ucrInputBeforeAfter.IsEmpty AndAlso Not ucrReceiverColumnsToInsert.IsEmpty AndAlso Not ucrInputPrefixForNewColumn.IsEmpty AndAlso Not ucrNudNumberOfColumns.Text <> "" AndAlso Not ucrInputDefaultValue.IsEmpty)
            ucrBase.OKEnabled(True)
        ElseIf (rdoInsertRows.Checked AndAlso ucrNudNumberOfRows.Text <> "" AndAlso ucrNudStartRow.Text <> "" OrElse rdoAfter.Checked OrElse rdoBefore.Checked) Then
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

    Private Sub ucrPnlColumnsOrRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnsOrRows.ControlValueChanged
        If rdoInsertColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
        ElseIf rdoInsertRows.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertRowFunction)
        End If
    End Sub

    Private Sub ucrReceiverColumnsToInsert_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToInsert.ControlContentsChanged, ucrPnlColumnsOrRows.ControlContentsChanged, ucrPnlBeforeAfter.ControlContentsChanged, ucrPnlStartEnd.ControlContentsChanged, ucrInputPrefixForNewColumn.ControlContentsChanged, ucrInputDefaultValue.ControlContentsChanged, ucrInputBeforeAfter.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class