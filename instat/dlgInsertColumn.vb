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
    Dim bFirstLoad As Boolean = True

    Private Sub dlgInsertColumn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.iHelpTopicID = 52
        If bFirstLoad Then
            InitialiseDialog
            setDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverColumnsToInsert.Selector = ucrSelectorInseertColumns
        ucrReceiverColumnsToInsert.SetMeAsReceiver()
        ucrInputPrefixForInsertedColumns.SetItemsTypeAsColumns()
        ucrInputPrefixForInsertedColumns.SetDefaultTypeAsColumn()
        ucrInputPrefixForInsertedColumns.SetDataFrameSelector(ucrDataFramesList)
        ucrInputBeforeAfter.cboInput.Items.Add("Before")
        ucrInputBeforeAfter.cboInput.Items.Add("After")

    End Sub

    Private Sub TestOKEnabled()
        If rdoInsertColumns.Checked Then
            If ((nudInsertColumns.Text <> "") And (Not ucrInputDefaultValue.IsEmpty) And (Not ucrInputPrefixForInsertedColumns.IsEmpty)) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)

            End If
        ElseIf rdoInsertRows.Checked Then
            If ((nudNumCols.Text <> "") And (nudPos.Text <> "")) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ReopenDialog()
        ucrDataFramesList.Reset()
        If rdoInsertColumns.Checked Then
            If nudPos.Value > ucrDataFramesList.iColumnCount + 1 Then
                nudPos.Value = ucrDataFramesList.iColumnCount + 1
                ucrBase.clsRsyntax.AddParameter("num_cols", nudNumCols.Value)
            End If
        ElseIf rdoInsertRows.Checked Then
            If nudPos.Value > ucrDataFramesList.iDataFrameLength + 1 Then
                nudPos.Value = ucrDataFramesList.iDataFrameLength + 1
                ucrBase.clsRsyntax.AddParameter("num_cols", nudNumCols.Value)
            End If
        End If
    End Sub

    Private Sub setDefaults()
        rdoInsertColumns.Checked = True
        rdoAtEnd.Checked = True
        RowsOrColumns()
        ucrDataFramesList.Reset()

    End Sub

    Private Sub nudPos_TextChanged(sender As Object, e As EventArgs) Handles nudPos.TextChanged
        If rdoInsertRows.Checked Then
            If Not nudPos.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("start_pos", nudPos.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("start_pos")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("start_pos")
        End If
    End Sub

    Private Sub nudNumCols_TextChanged(sender As Object, e As EventArgs) Handles nudNumCols.TextChanged
        NumberofColumnsOrRows()
        TestOKEnabled()
    End Sub

    Private Sub NumberofColumnsOrRows()
        If rdoInsertColumns.Checked Then
            If Not nudInsertColumns.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("num_cols", nudNumCols.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("num_cols")
            End If

        ElseIf rdoInsertRows.Checked Then
            If Not nudNumCols.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("number_rows", nudNumCols.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("number_rows")
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFramesList_DataFrameChanged() Handles ucrDataFramesList.DataFrameChanged
        If rdoInsertRows.Checked Then
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & Chr(34))
        Else
            ucrSelectorInseertColumns.strCurrentDataFrame = ucrDataFramesList.cboAvailableDataFrames.SelectedItem
            ucrSelectorInseertColumns.LoadList()
            ucrBase.clsRsyntax.RemoveParameter("data_name")
        End If
    End Sub


    Private Sub ucrDataFramesList_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFramesList.DataFrameChanged
        dataFrameListMaxMinPos()
    End Sub

    Private Sub dataFrameListMaxMinPos()
        If rdoInsertColumns.Checked Then
            nudPos.Maximum = ucrDataFramesList.iColumnCount + 1
            nudPos.Value = ucrDataFramesList.iColumnCount + 1

        Else
            nudPos.Maximum = ucrDataFramesList.iDataFrameLength + 1
            nudPos.Value = ucrDataFramesList.iDataFrameLength + 1
        End If
    End Sub

    Private Sub RowsOrColumns_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInsertColumns.CheckedChanged, rdoInsertRows.CheckedChanged
        RowsOrColumns()

    End Sub

    Private Sub RowsOrColumns()
        If rdoInsertColumns.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
            InsertParam()
            ucrBase.clsRsyntax.RemoveParameter("number_rows")
            nudInsertColumns.Value = 1
            ucrInputPrefixForInsertedColumns.SetPrefix("X")
            ucrInputDefaultValue.SetName("NA")
            NumberofColumnsOrRows()
            dataFrameListMaxMinPos()
            grpInsert.Visible = True
            ucrSelectorInseertColumns.Visible = True
            ucrDataFramesList.Visible = False
            nudInsertColumns.Maximum = 100
            nudNumCols.Visible = False
            nudPos.Visible = False
            lblDataFrame.Visible = True
            addColumData()
            BeforeAfterPara()
            lblPrefixforInsertedColumns.Visible = True
            lblDefaultValue.Visible = True
            ucrInputPrefixForInsertedColumns.Visible = True
            ucrInputDefaultValue.Visible = True

        Else
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
            lblNumberOfRowsToInsert.Visible = True
            ucrBase.clsRsyntax.RemoveParameter("num_cols")
            nudNumCols.Value = 1
            NumberofColumnsOrRows()
            dataFrameListMaxMinPos()
            nudNumCols.Maximum = 1000
            grpInsert.Visible = False
            addColumData()
            InsertParam()
            BeforeAfterPara()
            ucrSelectorInseertColumns.Visible = False
            ucrDataFramesList.Visible = True
            nudNumCols.Visible = True
            nudPos.Visible = True
            lblDataFrame.Visible = False
            lblPrefixforInsertedColumns.Visible = False
            lblDefaultValue.Visible = False
            ucrInputPrefixForInsertedColumns.Visible = False
            ucrInputDefaultValue.Visible = False
        End If

    End Sub

    Private Sub grpInsert_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAtEnd.CheckedChanged, rdoAtStart.CheckedChanged, rdoBeforeAfter.CheckedChanged
        InsertParam()
    End Sub

    Private Sub InsertParam()
        If rdoAtEnd.Checked Then
            ucrBase.clsRsyntax.AddOperatorParameter("before", "FALSE")
            ucrReceiverColumnsToInsert.Visible = False
            lblNumberOfColumnsToInsert.Visible = False
            nudInsertColumns.Visible = False
            lblColumnsToInsert.Visible = False
        ElseIf rdoAtStart.Checked Then
            ucrBase.clsRsyntax.AddOperatorParameter("before", "TRUE")
            ucrReceiverColumnsToInsert.Visible = False
            lblNumberOfColumnsToInsert.Visible = False
            nudInsertColumns.Visible = False
            lblColumnsToInsert.Visible = False
        Else
            ucrReceiverColumnsToInsert.Visible = True
            lblNumberOfColumnsToInsert.Visible = True
            nudInsertColumns.Visible = True
            lblColumnsToInsert.Visible = True
        End If
    End Sub

    Private Sub ucrInputBeforeAfter_NameChanged() Handles ucrInputBeforeAfter.NameChanged
        If rdoBeforeAfter.Checked = True Then
            If Not ucrInputBeforeAfter.IsEmpty Then
                Select Case ucrInputBeforeAfter.GetText
                    Case "Before"
                        ucrBase.clsRsyntax.AddParameter("before", "TRUE")
                    Case "After"
                        ucrBase.clsRsyntax.AddParameter("before", "FALSE")

                End Select
            Else
                ucrBase.clsRsyntax.RemoveParameter("before")
            End If
        End If

    End Sub

    Private Sub ucrReceiverColumnsToInsert_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverColumnsToInsert.SelectionChanged
        BeforeAfterPara()
        TestOKEnabled()
    End Sub

    Private Sub BeforeAfterPara()
        If rdoBeforeAfter.Checked Then
            If Not ucrReceiverColumnsToInsert.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", clsRFunctionParameter:=ucrReceiverColumnsToInsert.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
        End If
    End Sub

    Private Sub ucrInputDefaultValue_NameChanged() Handles ucrInputDefaultValue.NameChanged
        addColumData()
        TestOKEnabled()
    End Sub

    Private Sub addColumData()
        If rdoInsertColumns.Checked Then
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
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputPrefixForInsertedColumns.GetText, strTempDataframe:=ucrDataFramesList.cboAvailableDataFrames.Text, strTempColumn:=ucrInputPrefixForInsertedColumns.GetText, bAssignToIsPrefix:=True)
    End Sub
End Class