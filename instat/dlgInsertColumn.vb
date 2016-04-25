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
            setDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If rdoInsertColumns.Checked Then
            If ((nudNumCols.Text <> "") And (nudPos.Text <> "") And Not ucrInputDefaultData.IsEmpty) Then
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

    End Sub

    Private Sub setDefaults()
        rdoInsertColumns.Checked = True
        ucrInputDefaultData.SetName("NA")
        ucrDataFramesList.Reset()
        RowsOrColumns()
        ucrInputDefaultData.Reset()
    End Sub

    Private Sub nudPos_TextChanged(sender As Object, e As EventArgs) Handles nudPos.TextChanged
        If rdoInsertColumns.Checked Then
            If Not nudPos.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("start_pos", nudPos.Value)
            End If
        ElseIf rdoInsertRows.Checked Then
            ucrBase.clsRsyntax.AddParameter("start_pos", nudPos.Value)
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
            If Not nudNumCols.Text = "" Then
                ucrBase.clsRsyntax.AddParameter("number_cols", nudNumCols.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("number_cols")
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
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & Chr(34))
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
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_column_in_data")
            lblNumberCols.Visible = True
            lblNumberOfRowsToInsert.Visible = False
            NumberofColumnsOrRows()
            ucrBase.clsRsyntax.AddParameter("start_pos", nudPos.Value)
            nudPos.Value = ucrDataFramesList.iColumnCount + 1
            ucrBase.clsRsyntax.RemoveParameter("row_data")
            ucrBase.clsRsyntax.RemoveParameter("col_rows")
            nudNumCols.Maximum = 100
            ucrBase.clsRsyntax.RemoveParameter("number_rows")
            lblDefaultValues.Visible = True
            ucrInputDefaultData.Visible = True

        Else
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
            lblNumberCols.Visible = False
            lblNumberOfRowsToInsert.Visible = True
            NumberofColumnsOrRows()
            nudPos.Value = ucrDataFramesList.iDataFrameLength + 1
            ucrBase.clsRsyntax.AddParameter("start_pos", nudPos.Value)
            ucrBase.clsRsyntax.RemoveParameter("col_data")
            ucrBase.clsRsyntax.RemoveParameter("number_cols")
            nudNumCols.Maximum = 1000
            ucrInputDefaultData.Visible = False
            lblDefaultValues.Visible = False
        End If

    End Sub

    Private Sub ucrInputDefaultData_Namechanged() Handles ucrInputDefaultData.NameChanged
        ucrInputDeDataValues()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputDeDataValues()

        If rdoInsertColumns.Checked Then
            If Not ucrInputDefaultData.IsEmpty Then
                If (ucrInputDefaultData.GetText.ToLower()) = "true" Then
                    ucrBase.clsRsyntax.AddParameter("col_data", "TRUE")
                ElseIf (ucrInputDefaultData.GetText.ToLower()) = "false" Then
                    ucrBase.clsRsyntax.AddParameter("col_data", "FALSE")
                ElseIf (ucrInputDefaultData.GetText.ToLower()) = "na"
                    ucrBase.clsRsyntax.AddParameter("col_data", "NA")
                ElseIf IsNumeric(ucrInputDefaultData.GetText) Then
                    ucrBase.clsRsyntax.AddParameter("col_data", ucrInputDefaultData.GetText)
                Else
                    ucrBase.clsRsyntax.AddParameter("col_data", Chr(34) & ucrInputDefaultData.GetText & Chr(34))
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("col_data")
            End If
        End If
    End Sub
End Class
