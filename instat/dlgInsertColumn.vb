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
        Dim dctBeforeAfter As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 164

        ucrDataFramesList.SetParameter(New RParameter("data_name"))
        ucrDataFramesList.SetParameterIsString()

        ucrReceiverColumnsToInsert.SetParameter(New RParameter("adjacent_column"))
        ucrReceiverColumnsToInsert.SetParameterIsString()
        ucrReceiverColumnsToInsert.Selector = ucrSelectorInsertColumns
        ucrReceiverColumnsToInsert.SetMeAsReceiver()

        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertColumns)
        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertRows)
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertRows, frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertColumns, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")

        ucrPnlBeforeAfter.SetParameter(New RParameter("before"))
        ucrPnlBeforeAfter.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlBeforeAfter.AddRadioButton(rdoAfter, "FALSE")

        ucrNudNumberOfRows.SetParameter(New RParameter("number_rows"))
        ucrNudNumberOfRows.SetMinMax(1, Integer.MaxValue)
        ucrNudNumberOfRows.SetRDefault(1)

        ucrNudStartRow.SetParameter(New RParameter("start_row"))
        ucrNudStartRow.SetMinMax(1, Integer.MaxValue)

        ucrInputBeforeAfter.SetParameter(New RParameter("before"))
        dctBeforeAfter.Add("Before", "TRUE")
        dctBeforeAfter.Add("After", "FALSE")
        ucrInputBeforeAfter.SetItems(dctBeforeAfter)
        ucrInputBeforeAfter.SetRDefault("FALSE")

        ucrPnlInsertColumns.SetParameter(New RParameter("before"))
        ucrPnlInsertColumns.AddRadioButton(rdoAtStart, "TRUE")
        ucrPnlInsertColumns.AddRadioButton(rdoAtEnd, "FALSE")
        ucrPnlInsertColumns.AddRadioButton(rdoBeforeAfter, "TRUE")

        ucrNudNumberOfColumns.SetParameter(New RParameter("num_cols"))
        ucrNudNumberOfColumns.SetRDefault(1)
        ucrNudNumberOfColumns.SetMinMax(1, Integer.MaxValue)

        ucrInputDefaultValue.SetParameter(New RParameter("col_data"))
        ucrInputDefaultValue.SetRDefault("NA")

        ucrPnlInsertColumns.AddParameterValuesCondition(rdoAtStart, "before", "TRUE")
        ucrPnlInsertColumns.AddParameterValuesCondition(rdoAtStart, "before", "FALSE", False)
        ucrPnlInsertColumns.AddParameterPresentCondition(rdoAtStart, "adjacent_column", False)

        ucrPnlInsertColumns.AddParameterValuesCondition(rdoAtEnd, "before", "FALSE")
        ucrPnlInsertColumns.AddParameterValuesCondition(rdoAtEnd, "before", "TRUE", False)
        ucrPnlInsertColumns.AddParameterPresentCondition(rdoAtEnd, "adjacent_column", False)

        ucrPnlInsertColumns.AddParameterValuesCondition(rdoBeforeAfter, "before", "TRUE")
        ucrPnlInsertColumns.AddParameterValuesCondition(rdoBeforeAfter, "before", "FALSE")
        ucrPnlInsertColumns.AddParameterPresentCondition(rdoBeforeAfter, "adjacent_column")
        ucrPnlInsertColumns.SetRDefault("FALSE")

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlInsertColumns, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputBeforeAfter, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfColumns, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputDefaultValue, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudNumberOfColumns.SetLinkedDisplayControl(lblNumberOfColumnsToInsert)
        ucrInputDefaultValue.SetLinkedDisplayControl(lblDefaultValue)

        ucrInputPrefixForNewColumn.SetParameter(New RParameter("col_name"))
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputPrefixForNewColumn, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputPrefixForNewColumn.SetLinkedDisplayControl(lblInputColumnPrefix)
        ucrInputPrefixForNewColumn.SetPrefix("X")

        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlBeforeAfter, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfRows, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudStartRow, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlBeforeAfter.SetLinkedDisplayControl(grpOptions)
        ucrNudNumberOfRows.SetLinkedDisplayControl(lblNumberOfRowsToInsert)
        ucrNudStartRow.SetLinkedDisplayControl(lblStartPos)

        ucrPnlInsertColumns.AddToLinkedControls(ucrSelectorInsertColumns, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlInsertColumns.AddToLinkedControls(ucrInputBeforeAfter, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlInsertColumns.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrSelectorInsertColumns.SetLinkedDisplayControl(lblColumn)
        ucrPnlInsertColumns.SetLinkedDisplayControl(grpInsert)
    End Sub

    Private Sub SetDefaults()
        clsInsertColumnFunction = New RFunction
        clsInsertRowFunction = New RFunction

        ucrSelectorInsertColumns.Reset()
        ucrDataFramesList.Reset()
        ucrInputBeforeAfter.Reset()
        ucrInputDefaultValue.Reset()
        ucrInputPrefixForNewColumn.Reset()
        ucrInputPrefixForNewColumn.SetName("X")
        ucrInputDefaultValue.SetName("NA")

        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsInsertColumnFunction.AddParameter("use_col_name_as_prefix", "TRUE")
        clsInsertColumnFunction.AddParameter("before", "FALSE")

        clsInsertRowFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsInsertRowFunction.AddParameter("before", "FALSE")
        clsInsertRowFunction.AddParameter("start_row", ucrDataFramesList.iDataFrameLength)
        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrDataFramesList.AddAdditionalCodeParameterPair(clsInsertColumnFunction, ucrDataFramesList.GetParameter, iAdditionalPairNo:=1)

        ucrNudNumberOfRows.SetRCode(clsInsertRowFunction, bReset)
        ucrNudStartRow.SetRCode(clsInsertRowFunction, bReset)
        ucrDataFramesList.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlBeforeAfter.SetRCode(clsInsertRowFunction, bReset)

        ucrNudNumberOfColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputDefaultValue.SetRCode(clsInsertColumnFunction, bReset)

        ucrInputPrefixForNewColumn.SetRCode(clsInsertColumnFunction, bReset)
        ucrReceiverColumnsToInsert.SetRCode(clsInsertColumnFunction, bReset)

        ucrPnlColumnsOrRows.SetRCode(clsInsertColumnFunction, bReset)
        ucrPnlInsertColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputBeforeAfter.SetRCode(clsInsertColumnFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoInsertColumns.Checked Then
            If (rdoBeforeAfter.Checked AndAlso Not ucrInputBeforeAfter.IsEmpty AndAlso Not ucrReceiverColumnsToInsert.IsEmpty AndAlso Not ucrInputPrefixForNewColumn.IsEmpty AndAlso ucrNudNumberOfColumns.GetText <> "" AndAlso Not ucrInputDefaultValue.IsEmpty) Then
                ucrBase.OKEnabled(True)
            ElseIf ((rdoAtEnd.Checked OrElse rdoAtStart.Checked) AndAlso ucrNudNumberOfColumns.GetText <> "" AndAlso Not ucrInputDefaultValue.IsEmpty AndAlso Not ucrInputPrefixForNewColumn.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoInsertRows.Checked Then
            If (ucrNudNumberOfRows.GetText <> "" AndAlso ucrNudStartRow.GetText <> "" OrElse rdoAfter.Checked OrElse rdoBefore.Checked) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If rdoInsertColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
        ElseIf rdoInsertRows.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertRowFunction)
        End If
    End Sub

    Private Sub ucrPnlStartEnd_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlInsertColumns.ControlValueChanged
        If rdoAtEnd.Checked Then
            clsInsertColumnFunction.AddParameter("before", "FALSE")
        ElseIf rdoAtStart.Checked
            clsInsertColumnFunction.AddParameter("before", "TRUE")
        End If
    End Sub

    Private Sub ucrReceiverColumnsToInsert_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToInsert.ControlContentsChanged, ucrPnlColumnsOrRows.ControlContentsChanged, ucrPnlBeforeAfter.ControlContentsChanged, ucrPnlInsertColumns.ControlContentsChanged, ucrInputPrefixForNewColumn.ControlContentsChanged, ucrInputDefaultValue.ControlContentsChanged, ucrInputBeforeAfter.ControlContentsChanged, ucrNudNumberOfRows.ControlContentsChanged, ucrNudStartRow.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class