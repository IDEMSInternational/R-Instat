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
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctBeforeAfter As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 164

        ucrSelectorInsertColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorInsertColumns.SetParameterIsString()

        ucrReceiverColumnsToInsert.SetParameter(New RParameter("adjacent_column", 1))
        ucrReceiverColumnsToInsert.SetParameterIsString()
        ucrReceiverColumnsToInsert.Selector = ucrSelectorInsertColumns
        ucrReceiverColumnsToInsert.SetMeAsReceiver()

        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertColumns)
        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertRows)
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertRows, frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        ucrPnlColumnsOrRows.AddFunctionNamesCondition(rdoInsertColumns, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")

        ucrPnlBeforeAfter.SetParameter(New RParameter("before", 1))
        ucrPnlBeforeAfter.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlBeforeAfter.AddRadioButton(rdoAfter, "FALSE")
        ucrPnlBeforeAfter.AddParameterValuesCondition(rdoBefore, "before", "TRUE")
        ucrPnlBeforeAfter.AddParameterValuesCondition(rdoAfter, "before", "FALSE")
        ucrPnlBeforeAfter.SetRDefault("FALSE")

        ucrNudNumberOfRows.SetParameter(New RParameter("number_rows", 2))
        ucrNudNumberOfRows.SetMinMax(1, Integer.MaxValue)
        ucrNudNumberOfRows.SetRDefault(1)

        ucrNudStartRow.SetParameter(New RParameter("start_row", 3))

        ucrInputBeforeAfter.SetParameter(New RParameter("before", 2))
        dctBeforeAfter.Add("Before", "TRUE")
        dctBeforeAfter.Add("After", "FALSE")
        ucrInputBeforeAfter.SetItems(dctBeforeAfter)
        ucrInputBeforeAfter.SetRDefault("FALSE")
        ucrInputBeforeAfter.SetDropDownStyleAsNonEditable()

        ucrPnlInsertColumns.SetParameter(New RParameter("before", 3))
        ucrPnlInsertColumns.AddRadioButton(rdoAtStart, "TRUE")
        ucrPnlInsertColumns.AddRadioButton(rdoAtEnd, "FALSE")
        ucrPnlInsertColumns.AddRadioButton(rdoBeforeAfter, "TRUE")

        ucrNudNumberOfColumns.SetParameter(New RParameter("num_cols", 4))
        ucrNudNumberOfColumns.SetRDefault(1)
        ucrNudNumberOfColumns.SetMinMax(1, Integer.MaxValue)

        ucrInputDefaultValue.SetParameter(New RParameter("col_data", 5))
        ucrInputDefaultValue.SetRDefault("NA")

        ucrPnlInsertColumns.AddParameterValuesCondition(rdoAtStart, "before", "TRUE")
        ucrPnlInsertColumns.AddParameterValuesCondition(rdoAtEnd, "before", "FALSE")
        ucrPnlInsertColumns.AddParameterPresentCondition(rdoBeforeAfter, "adjacent_column")
        ucrPnlInsertColumns.SetRDefault("FALSE")
        'temp fix
        ucrPnlInsertColumns.bAllowNonConditionValues = True
        ucrPnlInsertColumns.AddToLinkedControls(ucrInputBeforeAfter, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlInsertColumns.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlInsertColumns, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfColumns, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputDefaultValue, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrInputPrefixForNewColumn, {rdoInsertColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrPnlBeforeAfter, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudNumberOfRows, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumnsOrRows.AddToLinkedControls(ucrNudStartRow, {rdoInsertRows}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudNumberOfColumns.SetLinkedDisplayControl(lblNumberOfColumnsToInsert)
        ucrInputDefaultValue.SetLinkedDisplayControl(lblDefaultValue)

        ucrInputPrefixForNewColumn.SetParameter(New RParameter("col_name", 6))
        ucrInputPrefixForNewColumn.SetLinkedDisplayControl(lblInputColumnPrefix)

        ucrPnlBeforeAfter.SetLinkedDisplayControl(grpOptions)
        ucrNudNumberOfRows.SetLinkedDisplayControl(lblNumberOfRowsToInsert)
        ucrNudStartRow.SetLinkedDisplayControl(lblStartPos)
        ucrPnlInsertColumns.SetLinkedDisplayControl(grpInsert)
        ucrReceiverColumnsToInsert.SetLinkedDisplayControl(lblColumn)
    End Sub

    Private Sub SetDefaults()
        clsInsertColumnFunction = New RFunction
        clsInsertRowFunction = New RFunction

        ucrSelectorInsertColumns.Reset()
        ucrInputBeforeAfter.Reset()
        ucrInputDefaultValue.Reset()
        ucrInputPrefixForNewColumn.Reset()
        clsInsertColumnFunction.AddParameter("col_data", "NA")
        clsInsertColumnFunction.AddParameter("col_name", "X")

        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsInsertColumnFunction.AddParameter("use_col_name_as_prefix", "TRUE")
        clsInsertColumnFunction.AddParameter("before", "FALSE")

        clsInsertRowFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsInsertRowFunction.AddParameter("before", "FALSE")
        clsInsertRowFunction.AddParameter("start_row", ucrSelectorInsertColumns.ucrAvailableDataFrames.iDataFrameLength)
        ucrNudStartRow.SetMinMax(1, ucrSelectorInsertColumns.ucrAvailableDataFrames.iDataFrameLength)
        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
    End Sub

    Private Sub ReopenDialog()
        If rdoInsertColumns.Checked Then
            grpInsert.Visible = True
        ElseIf rdoInsertRows.Checked Then
            grpOptions.Visible = True
        End If
        ucrSelectorInsertColumns.Reset()
        ucrNudStartRow.SetMinMax(1, ucrSelectorInsertColumns.ucrAvailableDataFrames.iDataFrameLength)
        If ucrSelectorInsertColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNudStartRow.Value = ucrSelectorInsertColumns.ucrAvailableDataFrames.iDataFrameLength
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorInsertColumns.AddAdditionalCodeParameterPair(clsInsertRowFunction, ucrSelectorInsertColumns.GetParameter, iAdditionalPairNo:=1)
        ucrNudNumberOfRows.SetRCode(clsInsertRowFunction, bReset)
        ucrNudStartRow.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlBeforeAfter.SetRCode(clsInsertRowFunction, bReset)

        ucrNudNumberOfColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputDefaultValue.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputPrefixForNewColumn.SetRCode(clsInsertColumnFunction, bReset)
        ucrReceiverColumnsToInsert.SetRCode(clsInsertColumnFunction, bReset)
        ucrSelectorInsertColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrPnlColumnsOrRows.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
            If (ucrNudNumberOfRows.GetText <> "" AndAlso ucrNudStartRow.GetText <> "") Then
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

    Private Sub ucrSelectorInsertColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorInsertColumns.ControlValueChanged
        ucrNudStartRow.SetMinMax(1, ucrSelectorInsertColumns.ucrAvailableDataFrames.iDataFrameLength)
        ucrNudStartRow.Value = ucrSelectorInsertColumns.ucrAvailableDataFrames.iDataFrameLength
    End Sub

    Private Sub ucrReceiverColumnsToInsert_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToInsert.ControlContentsChanged, ucrPnlColumnsOrRows.ControlContentsChanged, ucrPnlBeforeAfter.ControlContentsChanged, ucrPnlInsertColumns.ControlContentsChanged, ucrInputPrefixForNewColumn.ControlContentsChanged, ucrInputDefaultValue.ControlContentsChanged, ucrInputBeforeAfter.ControlContentsChanged, ucrNudNumberOfRows.ControlContentsChanged, ucrNudStartRow.ControlContentsChanged, ucrNudNumberOfColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumnsOrRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnsOrRows.ControlValueChanged, ucrPnlInsertColumns.ControlValueChanged
        If rdoInsertColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
            If rdoAtEnd.Checked OrElse rdoAtStart.Checked Then
                ucrSelectorInsertColumns.SetVariablesVisible(False)
            ElseIf rdoBeforeAfter.Checked
                ucrSelectorInsertColumns.SetVariablesVisible(True)
            End If
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsInsertRowFunction)
            ucrSelectorInsertColumns.SetVariablesVisible(False)
        End If
    End Sub
End Class