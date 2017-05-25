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
        'ucrInputBeforeAfter.SetItems({"Before", "After"})
        'ucrInputPrefixForInsertedColumns.SetValidationTypeAsRVariable()

        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertColumns)
        ucrPnlColumnsOrRows.AddRadioButton(rdoInsertRows)

        ucrPnlBeforeAfter.SetParameter(New RParameter("before"))
        ucrPnlBeforeAfter.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlBeforeAfter.AddRadioButton(rdoAfter, "FALSE")

        ucrDataFramesList.SetParameter(New RParameter("data_name"))
        ucrDataFramesList.SetParameterIsString()
        ucrNudNumberOfRows.SetParameter(New RParameter("number_rows"))
        ucrNudStartRow.SetParameter(New RParameter("start_row"))
        ucrNudNumberOfRows.SetRDefault(1)
        ucrNudNumberOfColumns.SetRDefault(1)

        ucrPnlStartEnd.SetParameter(New RParameter("before"))
        ucrPnlStartEnd.AddRadioButton(rdoAtEnd, "TRUE")
        ucrPnlStartEnd.AddRadioButton(rdoAtStart, "FALSE")
        ucrPnlStartEnd.AddRadioButton(rdoBeforeAfter, "FALSE")

        ucrReceiverColumnsToInsert.SetParameter(New RParameter("adjacent_column"))
        ucrNudNumberOfColumns.SetParameter(New RParameter("num_cols"))
        ucrInputDefaultValue.SetParameter(New RParameter("col_data"))
        ucrSaveInsertColumn.SetParameter(New RParameter("col_name"))
        ucrInputDefaultValue.SetRDefault("NA")

        Dim dctBeforeAfter As New Dictionary(Of String, String)
        ucrInputBeforeAfter.SetParameter(New RParameter("before"))
        dctBeforeAfter.Add("Before", "TRUE")
        dctBeforeAfter.Add("After", "FALSE")
        ucrInputBeforeAfter.SetItems(dctBeforeAfter)
        ucrInputBeforeAfter.SetRDefault("FALSE")

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

        ucrPnlStartEnd.AddToLinkedControls(ucrInputBeforeAfter, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStartEnd.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoBeforeAfter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

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

    'Private Sub reopendialog()
    '    ucrDataFramesList.Reset()
    '    If rdoInsertRows.Checked Then
    '        If nudpos.value = ucrDataFramesList.iDataFrameLength Then
    '            nudpos.value = ucrDataFramesList.iDataFrameLength
    '            ucrBase.clsRsyntax.AddParameter("number_rows", nudnumcols.value)
    '        End If
    '    Else
    '    End If
    'End Sub

    Private Sub SetDefaults()
        clsInsertColumnFunction = New RFunction
        clsInsertRowFunction = New RFunction
        ucrSelectorInsertColumns.Reset()
        ucrDataFramesList.Reset()

        clsInsertColumnFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsInsertRowFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
        clsInsertRowFunction.AddParameter("start_row", ucrDataFramesList.iDataFrameLength)

        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)

        'rdoInsertColumns.Checked = True
        'ucrInputPrefixForInsertedColumns.SetName("X")
        'ucrInputDefaultValue.SetName("NA")
        'RowsOrColumns()
        'rdoAtEnd.Checked = True
        'rdoAfter.Checked = True
        'ucrInputBeforeAfter.SetName("After")
        ''If ucrDataFramesList.iDataFrameLength >= nudPos.Minimum AndAlso ucrDataFramesList.iDataFrameLength <= nudPos.Maximum Then
        ''    nudPos.Value = ucrDataFramesList.iDataFrameLength
        ''Else
        ''    nudPos.Value = 1
        'End If
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrNudNumberOfRows.SetRCode(clsInsertRowFunction, bReset)
        ucrNudStartRow.SetRCode(clsInsertRowFunction, bReset)
        ucrDataFramesList.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlBeforeAfter.SetRCode(clsInsertRowFunction, bReset)
        ucrPnlStartEnd.SetRCode(clsInsertColumnFunction, bReset)
        ucrNudNumberOfColumns.SetRCode(clsInsertColumnFunction, bReset)
        ucrInputDefaultValue.SetRCode(clsInsertColumnFunction, bReset)
        ucrSaveInsertColumn.SetRCode(clsInsertColumnFunction, bReset)
        ucrReceiverColumnsToInsert.SetRCode(clsInsertColumnFunction, bReset)
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

    'Private Sub nudPos_TextChanged(sender As Object, e As EventArgs)
    '    startpo()
    'End Sub

    'Private Sub startpo()
    '    If rdoInsertRows.Checked Then
    '        If Not nudPos.Text = "" Then
    '            ucrBase.clsRsyntax.AddParameter("start_row", nudPos.Value)
    '        Else
    '            ucrBase.clsRsyntax.RemoveParameter("start_row")
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("start_row")
    '    End If
    'End Sub

    'Private Sub nudNumCols_TextChanged(sender As Object, e As EventArgs)
    '    NumberofColumnsOrRows()
    '    TestOKEnabled()
    'End Sub

    'Private Sub numberofcolumnsorrows()
    '    If rdoInsertRows.Checked Then
    '        If Not nudnumcols.text = "" Then
    '            ucrBase.clsRsyntax.AddParameter("number_rows", nudnumcols.value)
    '        Else
    '            ucrBase.clsRsyntax.RemoveParameter("number_rows")
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("number_rows")
    '    End If
    'End Sub

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

    'Private Sub ucrDataFramesList_DataFrameChanged() Handles ucrDataFramesList.DataFrameChanged
    'ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & Chr(34))
    'ucrSelectorInsertColumns.strCurrentDataFrame = ucrDataFramesList.cboAvailableDataFrames.SelectedItem
    'ucrSelectorInsertColumns.LoadList()
    'TestOKEnabled()
    'End Sub


    'Private Sub ucrDataFramesList_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFramesList.DataFrameChanged
    '    dataFrameListMaxMinPos()
    'End Sub

    'Private Sub dataFrameListMaxMinPos()
    '    If rdoInsertRows.Checked Then
    '        nudPos.Maximum = ucrDataFramesList.iDataFrameLength
    '        nudPos.Value = ucrDataFramesList.iDataFrameLength
    '    Else
    '    End If
    'End Sub

    'Private Sub RowsOrColumns_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInsertColumns.CheckedChanged, rdoInsertRows.CheckedChanged
    '    RowsOrColumns()
    'End Sub

    'Private Sub grpOPtions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBefore.CheckedChanged, rdoAfter.CheckedChanged
    '    OPtionstoInsert()
    'End Sub

    'Private Sub OPtionstoInsert()
    '    If rdoInsertRows.Checked Then
    '        If rdoAfter.Checked Then
    '            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
    '        ElseIf rdoBefore.Checked Then
    '            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
    '        End If
    '    End If
    'End Sub

    'Private Sub RowsOrColumns()
    '    If rdoInsertColumns.Checked Then
    '        'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
    '        ucrBase.clsRsyntax.AddParameter("use_col_name_as_prefix", "TRUE")
    '        BeforeAfterPara()
    '        InsertParam()
    '        ucrBase.clsRsyntax.RemoveParameter("number_rows")
    '        'nudInsertColumns.Value = 1
    '        'NumberofColumnsOrRows()
    '        'dataFrameListMaxMinPos()
    '        'ColName()
    '        'grpInsert.Visible = True
    '        'grpOPtions.Visible = False
    '        'nudInsertColumns.Maximum = 100
    '        'nudNumCols.Visible = False
    '        'nudPos.Visible = False
    '        addColumData()
    '        ColsToInsert()
    '        OPtionstoInsert()
    '        'startpo()
    '        BeforeParameter()
    '        'lblPrefixforInsertedColumns.Visible = True
    '        'lblDefaultValue.Visible = True
    '        'ucrInputPrefixForInsertedColumns.Visible = True
    '        'ucrInputDefaultValue.Visible = True
    '        'lblNumberOfColumnsToInsert.Visible = True
    '        'nudInsertColumns.Visible = True
    '        'lblNumberOfRowsToInsert.Visible = False
    '        'lblStartPos.Visible = False
    '        'nudNumCols.Focus()
    '        'nudPos.Focus()
    '    ElseIf rdoInsertRows.Checked Then
    '        'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
    '        lblNumberOfRowsToInsert.Visible = True
    '        ucrBase.clsRsyntax.RemoveParameter("num_cols")
    '        ucrBase.clsRsyntax.RemoveParameter("use_col_name_as_prefix")
    '        nudNumCols.Value = 1
    '        NumberofColumnsOrRows()
    '        dataFrameListMaxMinPos()
    '        'startpo()
    '        nudNumCols.Maximum = 1000
    '        addColumData()
    '        InsertParam()
    '        BeforeAfterPara()
    '        OPtionstoInsert()
    '        ColsToInsert()
    '        ColName()
    '        BeforeParameter()
    '        ucrSelectorInsertColumns.Visible = False
    '        nudNumCols.Visible = True
    '        nudPos.Visible = True
    '        lblStartPos.Visible = True
    '        lblPrefixforInsertedColumns.Visible = False
    '        lblDefaultValue.Visible = False
    '        ucrInputPrefixForInsertedColumns.Visible = False
    '        ucrInputDefaultValue.Visible = False
    '        lblNumberOfColumnsToInsert.Visible = False
    '        nudInsertColumns.Visible = False
    '        ucrReceiverColumnsToInsert.Visible = False
    '        nudInsertColumns.Focus()
    '        grpInsert.Visible = False
    '        grpOPtions.Visible = True

    '    End If

    'End Sub

    'Private Sub grpInsert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAtEnd.CheckedChanged, rdoAtStart.CheckedChanged, rdoBeforeAfter.CheckedChanged
    '    InsertParam()
    'End Sub

    'Private Sub InsertParam()
    '    If rdoAtEnd.Checked Then
    '        ucrBase.clsRsyntax.AddParameter("before", "FALSE")
    '        ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
    '        ucrReceiverColumnsToInsert.Visible = False
    '        ucrSelectorInsertColumns.Visible = False
    '    ElseIf rdoAtStart.Checked Then
    '        ucrBase.clsRsyntax.AddParameter("before", "TRUE")
    '        ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
    '        ucrReceiverColumnsToInsert.Visible = False
    '        ucrSelectorInsertColumns.Visible = False
    '    Else
    '        ucrReceiverColumnsToInsert.Visible = True
    '        ucrSelectorInsertColumns.Visible = True
    '    End If
    '    If rdoBeforeAfter.Checked Then
    '        ucrInputBeforeAfter.Enabled = True
    '    Else
    '        ucrInputBeforeAfter.Enabled = False
    '        ucrReceiverColumnsToInsert.Clear()
    '    End If
    '    BeforeParameter()
    'End Sub

    'Private Sub ucrInputBeforeAfter_NameChanged() Handles ucrInputBeforeAfter.NameChanged
    '    BeforeParameter()
    'End Sub

    'Private Sub BeforeParameter()
    '    If rdoInsertColumns.Checked Then
    '        If rdoBeforeAfter.Checked Then
    '            Select Case ucrInputBeforeAfter.GetText
    '                Case "Before"
    '                    ucrBase.clsRsyntax.AddParameter("before", "TRUE")
    '                Case Else
    '                    ucrBase.clsRsyntax.AddParameter("before", "FALSE")
    '            End Select
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("before")
    '    End If
    'End Sub

    'Private Sub ucrReceiverColumnsToInsert_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverColumnsToInsert.SelectionChanged
    '    BeforeAfterPara()
    '    TestOKEnabled()
    'End Sub

    'Private Sub BeforeAfterPara()
    '    If rdoInsertColumns.Checked Then
    '        If rdoBeforeAfter.Checked Then
    '            If Not ucrReceiverColumnsToInsert.IsEmpty Then
    '                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverColumnsToInsert.GetVariableNames())
    '            Else
    '                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
    '            End If
    '        Else
    '            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
    '    End If
    'End Sub

    'Private Sub ucrInputDefaultValue_NameChanged() Handles ucrInputDefaultValue.NameChanged
    '    addColumData()
    '    TestOKEnabled()
    'End Sub

    'Private Sub addColumData()
    '    If rdoInsertColumns.Checked Then
    '        If Not ucrInputDefaultValue.IsEmpty Then
    '            If (ucrInputDefaultValue.GetText.ToLower()) = "true" Then
    '                ucrBase.clsRsyntax.AddParameter("col_data", "TRUE")
    '            ElseIf (ucrInputDefaultValue.GetText.ToLower()) = "false" Then
    '                ucrBase.clsRsyntax.AddParameter("col_data", "FALSE")
    '            ElseIf (ucrInputDefaultValue.GetText.ToLower()) = "na"
    '                ucrBase.clsRsyntax.AddParameter("col_data", "NA")
    '            ElseIf IsNumeric(ucrInputDefaultValue.GetText) Then
    '                ucrBase.clsRsyntax.AddParameter("col_data", ucrInputDefaultValue.GetText)
    '            Else
    '                ucrBase.clsRsyntax.AddParameter("col_data", Chr(34) & ucrInputDefaultValue.GetText & Chr(34))
    '            End If
    '        Else
    '            ucrBase.clsRsyntax.RemoveParameter("col_data")
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("col_data")
    '    End If
    'End Sub

    'Private Sub ucrInputPrefixForInsertedColumns_NameChanged() Handles ucrInputPrefixForInsertedColumns.NameChanged
    '    ColName()
    '    TestOKEnabled()
    'End Sub

    'Private Sub ColName()
    '    If rdoInsertColumns.Checked Then
    '        If Not ucrInputPrefixForInsertedColumns.IsEmpty Then
    '            ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & ucrInputPrefixForInsertedColumns.GetText & Chr(34))
    '        Else
    '            ucrBase.clsRsyntax.RemoveParameter("col_name")
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("col_name")
    '    End If
    'End Sub

    'Private Sub nudInsertColumns_TextChanged(sender As Object, e As EventArgs)
    '    ColsToInsert()
    '    TestOKEnabled()
    'End Sub

    'Private Sub ColsToInsert()
    '    If rdoInsertColumns.Checked Then
    '        If Not nudInsertColumns.Text = "" Then
    '            ucrBase.clsRsyntax.AddParameter("num_cols", nudInsertColumns.Value)
    '        Else
    '            ucrBase.clsRsyntax.RemoveParameter("num_cols")
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveParameter("num_cols")
    '    End If
    'End Sub

End Class