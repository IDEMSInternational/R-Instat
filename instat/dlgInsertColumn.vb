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
    'stores the number of variables for the selected data frame.
    Private iCountVariables As Integer

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
        If nudNumCols.Text <> "" Then
            If nudPos.Text <> "" Then
                If Not ucrInputDefaultData.IsEmpty Then
                    ucrBase.OKEnabled(True)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub setDefaults()
        rdoInsertColumns.Checked = True
        ucrInputDefaultData.SetName("NA")
        nudPos.Value = ucrDataFramesList.iColumnCount
        nudNumCols.Value = 1
        NumberofColumnsOrRows()
        nudNumCols.Minimum = 1
        lblDefaultValues.Enabled = True
        ucrInputDefaultData.Enabled = True
        ucrDataFramesList.Reset()
        ucrInputDefaultData.Reset()
    End Sub

    Private Sub nudPos_TextChanged(sender As Object, e As EventArgs) Handles nudPos.TextChanged
        If Not nudPos.Text = "" Then
            ucrBase.clsRsyntax.AddParameter("start_pos", iCountVariables + 1)
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

    Private Sub ucrDataFramesList_Leave(sender As Object, e As EventArgs) Handles ucrDataFramesList.Leave
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

    Private Sub grpRowsOrColumns_CheckedChanged(sender As Object, e As EventArgs) Handles rdoInsertColumns.CheckedChanged, rdoInsertRows.CheckedChanged
        RowsOrColumns()

    End Sub

    Private Sub RowsOrColumns()
        If rdoInsertColumns.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_column_in_data")
            lblNumberCols.Visible = True
            lblNumberOfRowsToInsert.Visible = False
            NumberofColumnsOrRows()
            ucrBase.clsRsyntax.AddParameter("start_pos", iCountVariables + 1)
            nudPos.Value = ucrDataFramesList.iColumnCount
            ucrBase.clsRsyntax.RemoveParameter("row_data")
            ucrBase.clsRsyntax.RemoveParameter("col_rows")
            nudNumCols.Maximum = 100
            ucrBase.clsRsyntax.RemoveParameter("number_rows")
            lblDefaultValues.Enabled = True
            ucrInputDefaultData.Enabled = True

        Else
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_row_in_data")
            lblNumberCols.Visible = False
            lblNumberOfRowsToInsert.Visible = True
            NumberofColumnsOrRows()
            ucrBase.clsRsyntax.AddParameter("start_pos", ucrDataFramesList.iDataFrameLength + 1)
            nudPos.Value = ucrDataFramesList.iDataFrameLength
            ucrBase.clsRsyntax.RemoveParameter("col_data")
            ucrBase.clsRsyntax.RemoveParameter("number_cols")
            nudNumCols.Maximum = 1000
            ucrInputDefaultData.Enabled = False
            lblDefaultValues.Enabled = False
        End If

    End Sub

    Private Sub ucrInputDefaultData_Namechanged() Handles ucrInputDefaultData.NameChanged
        ucrInputDeDataValues()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputDeDataValues()
        If rdoInsertColumns.Checked Then
            If Not ucrInputDefaultData.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("col_data", ucrInputDefaultData.GetText)
            Else
                ucrBase.clsRsyntax.RemoveParameter("col_data")
            End If
        Else

        End If
    End Sub
End Class
