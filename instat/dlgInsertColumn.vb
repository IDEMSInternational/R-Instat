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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgInsertColumn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        If bReset Then
            setDefaults()
        End If
        SetRCodeForControls(bReset)

        bReset = False
        TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 164
        ucrReceiverColumnsToInsert.Selector = ucrSelectorInseertColumns

        ucrDataFramesList.SetParameter(New RParameter("data_name", 0))
        ucrDataFramesList.SetParameterIsString()

        ucrReceiverColumnsToInsert.SetParameter(New RParameter("adjacent_column"))
        ucrReceiverColumnsToInsert.SetParameterIsString()
        ucrReceiverColumnsToInsert.SetMeAsReceiver()

        ucrPnlColRows.AddRadioButton(rdoColumns)
        ucrPnlColRows.AddRadioButton(rdoRows)

        ucrPnlOptions.SetParameter(New RParameter(""))
        ucrPnlOptions.AddRadioButton(rdoAfter)
        ucrPnlOptions.AddRadioButton(rdoBefore)

        ucrNudInsertColumns.SetParameter(New RParameter("num_cols"))
        ucrNudInsertColumns.SetLinkedDisplayControl(lblNumberOfColumnsToInsert)

        UcrNudNumCols.SetParameter(New RParameter("number_rows"))
        UcrNudNumCols.SetLinkedDisplayControl(lblNumberOfRowsToInsert)

        ucrNudPos.SetParameter(New RParameter("start_row"))
        ucrNudPos.SetLinkedDisplayControl(lblStartPos)

        ucrInputPrefixForInsertedColumns.SetParameter(New RParameter("col_name"))
        ucrInputDefaultValue.SetParameter(New RParameter("col_data"))
        ucrInputDefaultValue.SetLinkedDisplayControl(lblDefaultValue)
        ucrInputBeforeAfter.SetParameter(New RParameter("before"))


        ucrPnlColRows.AddFunctionNamesCondition(rdoColumns, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        ucrPnlColRows.AddFunctionNamesCondition(rdoRows, frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")

        ucrPnlColRows.AddToLinkedControls(ucrDataFramesList, {rdoColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColRows.AddToLinkedControls(ucrNudInsertColumns, {rdoColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColRows.AddToLinkedControls(ucrInputDefaultValue, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColRows.AddToLinkedControls(ucrNudPos, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColRows.AddToLinkedControls(UcrNudNumCols, {rdoRows}, bNewLinkedHideIfParameterMissing:=True)

        ' temporary fix to show groupboxes 
        ucrPnlColRows.AddToLinkedControls(ucrPnlOptions, {rdoRows})
        ucrPnlOptions.SetLinkedDisplayControl(grpOptions)

        ucrPnlInsert.AddToLinkedControls(ucrSelectorInseertColumns, {rdoAfter}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlInsert.AddToLinkedControls(ucrReceiverColumnsToInsert, {rdoAfter}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputBeforeAfter.SetItems({"Before", "After"})
        ucrInputPrefixForInsertedColumns.SetValidationTypeAsRVariable()
    End Sub

    Private Sub TestOKEnabled()
        If rdoColumns.Checked Then
            If ((ucrNudInsertColumns.Text <> "") And (Not ucrInputDefaultValue.IsEmpty) And (Not ucrInputPrefixForInsertedColumns.IsEmpty) And (ucrDataFramesList.cboAvailableDataFrames.Text <> "")) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)

            End If
        ElseIf rdoRows.Checked Then
            If ((UcrNudNumCols.Text <> "") And (ucrNudPos.Text <> "") And (ucrDataFramesList.cboAvailableDataFrames.Text <> "")) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        ucrDataFramesList.Reset()
        If rdoRows.Checked Then
            If ucrNudPos.Value = ucrDataFramesList.iDataFrameLength Then
                ucrNudPos.Value = ucrDataFramesList.iDataFrameLength
                ucrBase.clsRsyntax.AddParameter("number_rows", UcrNudNumCols.Value)
            End If
        Else
        End If
    End Sub

    Private Sub setDefaults()

        Dim clsDefaultFunction As New RFunction


        ucrInputPrefixForInsertedColumns.SetName("X")
        ucrInputDefaultValue.SetName("NA")
        ucrDataFramesList.Reset()
        RowsOrColumns()
        ucrInputBeforeAfter.SetName("After")
        If ucrDataFramesList.iDataFrameLength >= ucrNudPos.Minimum AndAlso ucrDataFramesList.iDataFrameLength <= ucrNudPos.Maximum Then
            ucrNudPos.Value = ucrDataFramesList.iDataFrameLength
        Else
            ucrNudPos.Value = 1
        End If


        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ucrNudPos_TextChanged(sender As Object, e As EventArgs)
        startpo()
    End Sub

    Private Sub startpo()
        If rdoRows.Checked Then
            If Not ucrNudPos.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("start_row", ucrNudPos.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("start_row")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("start_row")
        End If
    End Sub

    Private Sub UcrNudNumCols_TextChanged(sender As Object, e As EventArgs)
        NumberofColumnsOrRows()
        TestOKEnabled()
    End Sub

    Private Sub NumberofColumnsOrRows()
        If rdoRows.Checked Then
            If Not UcrNudNumCols.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("number_rows", UcrNudNumCols.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("number_rows")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("number_rows")
        End If
    End Sub



    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFramesList_DataFrameChanged() Handles ucrDataFramesList.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & Chr(34))
        ucrSelectorInseertColumns.strCurrentDataFrame = ucrDataFramesList.cboAvailableDataFrames.SelectedItem
        ucrSelectorInseertColumns.LoadList()
        TestOKEnabled()
    End Sub


    Private Sub ucrDataFramesList_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFramesList.DataFrameChanged
        dataFrameListMaxMinPos()
    End Sub

    Private Sub dataFrameListMaxMinPos()
        If rdoRows.Checked Then
            ucrNudPos.Maximum = ucrDataFramesList.iDataFrameLength
            ucrNudPos.Value = ucrDataFramesList.iDataFrameLength
        Else
        End If
    End Sub

    Private Sub RowsOrColumns_CheckedChanged(sender As Object, e As EventArgs)
        RowsOrColumns()

    End Sub
    Private Sub grpOPtions_CheckedChanged(sender As Object, e As EventArgs)
        OPtionstoInsert()
    End Sub

    Private Sub OPtionstoInsert()
        If rdoRows.Checked Then
            If rdoAfter.Checked Then
                ucrBase.clsRsyntax.AddParameter("before", "FALSE")
            ElseIf rdoBefore.Checked Then
                ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            End If
        End If
    End Sub

    Private Sub RowsOrColumns()
        If rdoColumns.Checked Then
            ucrBase.clsRsyntax.AddParameter("use_col_name_as_prefix", "TRUE")
            BeforeAfterPara()
            InsertParam()
            ucrBase.clsRsyntax.RemoveParameter("number_rows")
            ucrNudInsertColumns.Value = 1
            NumberofColumnsOrRows()
            dataFrameListMaxMinPos()
            ColName()

            grpOptions.Visible = False
            ucrNudInsertColumns.Maximum = 100
            UcrNudNumCols.Visible = False
            ucrNudPos.Visible = False
            addColumData()
            ColsToInsert()
            OPtionstoInsert()
            startpo()
            BeforeParameter()
            lblPrefixforInsertedColumns.Visible = True
            lblDefaultValue.Visible = True
            ucrInputPrefixForInsertedColumns.Visible = True
            ucrInputDefaultValue.Visible = True
            lblNumberOfColumnsToInsert.Visible = True
            ucrNudInsertColumns.Visible = True
            lblNumberOfRowsToInsert.Visible = False
            lblStartPos.Visible = False
            UcrNudNumCols.Focus()
            ucrNudPos.Focus()
        ElseIf rdoRows.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
            lblNumberOfRowsToInsert.Visible = True
            ucrBase.clsRsyntax.RemoveParameter("num_cols")
            ucrBase.clsRsyntax.RemoveParameter("use_col_name_as_prefix")
            UcrNudNumCols.Value = 1
            NumberofColumnsOrRows()
            dataFrameListMaxMinPos()
            startpo()
            UcrNudNumCols.Maximum = 1000
            addColumData()
            InsertParam()
            BeforeAfterPara()
            OPtionstoInsert()
            ColsToInsert()
            ColName()
            BeforeParameter()
            ucrSelectorInseertColumns.Visible = False
            UcrNudNumCols.Visible = True
            ucrNudPos.Visible = True
            lblStartPos.Visible = True
            lblPrefixforInsertedColumns.Visible = False
            lblDefaultValue.Visible = False
            ucrInputPrefixForInsertedColumns.Visible = False
            ucrInputDefaultValue.Visible = False
            lblNumberOfColumnsToInsert.Visible = False
            ucrNudInsertColumns.Visible = False
            ucrReceiverColumnsToInsert.Visible = False
            ucrNudInsertColumns.Focus()
            grpOptions.Visible = True

        End If

    End Sub

    Private Sub grpInsert_CheckedChanged(sender As Object, e As EventArgs)
        InsertParam()
    End Sub

    Private Sub InsertParam()
        If rdoAtEnd.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            ucrReceiverColumnsToInsert.Visible = False
            ucrSelectorInseertColumns.Visible = False
        ElseIf rdoAtStart.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            ucrReceiverColumnsToInsert.Visible = False
            ucrSelectorInseertColumns.Visible = False
        Else
            ucrReceiverColumnsToInsert.Visible = True
            ucrSelectorInseertColumns.Visible = True
        End If
        If rdoBeforeAfter.Checked Then
            ucrInputBeforeAfter.Enabled = True
        Else
            ucrInputBeforeAfter.Enabled = False
            ucrReceiverColumnsToInsert.Clear()
        End If
        BeforeParameter()
    End Sub

    Private Sub ucrInputBeforeAfter_NameChanged()
        BeforeParameter()
    End Sub

    Private Sub BeforeParameter()
        If rdoColumns.Checked Then
            If rdoBeforeAfter.Checked Then
                Select Case ucrInputBeforeAfter.GetText
                    Case "Before"
                        ucrBase.clsRsyntax.AddParameter("before", "TRUE")
                    Case Else
                        ucrBase.clsRsyntax.AddParameter("before", "FALSE")
                End Select
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("before")
        End If
    End Sub

    Private Sub ucrReceiverColumnsToInsert_SelectionChanged(sender As Object, e As EventArgs)
        BeforeAfterPara()
        TestOKEnabled()
    End Sub

    Private Sub BeforeAfterPara()
        If rdoColumns.Checked Then
            If rdoBeforeAfter.Checked Then
                If Not ucrReceiverColumnsToInsert.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverColumnsToInsert.GetVariableNames())
                Else
                    ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
        End If
    End Sub

    Private Sub ucrInputDefaultValue_NameChanged() Handles ucrInputDefaultValue.ControlContentsChanged
        addColumData()
        TestOKEnabled()
    End Sub

    Private Sub addColumData()
        If rdoColumns.Checked Then
            If Not ucrInputDefaultValue.IsEmpty Then
                If (ucrInputDefaultValue.GetText.ToLower()) = "true" Then
                    ucrBase.clsRsyntax.AddParameter("col_data", "TRUE")
                ElseIf (ucrInputDefaultValue.GetText.ToLower()) = "false" Then
                    ucrBase.clsRsyntax.AddParameter("col_data", "FALSE")
                ElseIf (ucrInputDefaultValue.GetText.ToLower()) = "na"
                    ucrBase.clsRsyntax.AddParameter("col_data", "NA")
                ElseIf IsNumeric(ucrInputDefaultValue.GetText) Then
                    ucrBase.clsRsyntax.AddParameter("col_data", ucrInputDefaultValue.GetText)
                Else
                    ucrBase.clsRsyntax.AddParameter("col_data", Chr(34) & ucrInputDefaultValue.GetText & Chr(34))
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("col_data")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_data")
        End If
    End Sub

    Private Sub ucrInputPrefixForInsertedColumns_NameChanged() Handles ucrInputPrefixForInsertedColumns.NameChanged
        ColName()
        TestOKEnabled()
    End Sub

    Private Sub ColName()
        '    If rdoInsertColumns.Checked Then
        '        If Not ucrInputPrefixForInsertedColumns.IsEmpty Then
        '            ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & ucrInputPrefixForInsertedColumns.GetText & Chr(34))
        '        Else
        '            ucrBase.clsRsyntax.RemoveParameter("col_name")
        '        End If
        '    Else
        '        ucrBase.clsRsyntax.RemoveParameter("col_name")
        '    End If
    End Sub

    'Private Sub nudInsertColumns_TextChanged(sender As Object, e As EventArgs)
    '    ColsToInsert()
    '    TestOKEnabled()
    'End Sub

    Private Sub ColsToInsert()
        '    If rdoInsertColumns.Checked Then
        '        If Not ucrNudInsertColumns.Text = "" Then
        '            ucrBase.clsRsyntax.AddParameter("num_cols", ucrNudInsertColumns.Value)
        '        Else
        '            ucrBase.clsRsyntax.RemoveParameter("num_cols")
        '        End If
        '    Else
        '        ucrBase.clsRsyntax.RemoveParameter("num_cols")
        '    End If

    End Sub

    Private Sub ucrInputDefaultValue_NameChanged(ucrChangedControl As ucrCore) Handles ucrInputDefaultValue.ControlContentsChanged

    End Sub
End Class