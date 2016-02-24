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

    Private Sub chkPos_CheckStateChanged(sender As Object, e As EventArgs) Handles chkPos.CheckStateChanged
        If chkPos.Checked = True Then
            nudPos.Enabled = True
            txtStartPos.Enabled = False
        Else
            ucrBase.clsRsyntax.AddParameter("start_pos", iCountVariables + 1)
            nudPos.Enabled = False
            txtStartPos.Enabled = True
        End If
    End Sub

    Private Sub dlgInsertColumn_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            setDefaultValues()
            bFirstLoad = False
        End If
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$insert_column_in_data")
    End Sub

    Private Sub setDefaultValues()
        txtDefaultData.Text = "NA"
        ucrBase.clsRsyntax.AddParameter("col_data", "c()")
        txtStartPos.Text = "At the end."
        ucrBase.clsRsyntax.AddParameter("start_pos", iCountVariables + 1)
        nudNumCols.Value = 1
        nudPos.Value = iCountVariables
        nudPos.Enabled = False
        ucrDataFramesList.Reset()
    End Sub

    Private Sub nudPos_ValueChanged(sender As Object, e As EventArgs) Handles nudPos.ValueChanged
        ucrBase.clsRsyntax.AddParameter("start_pos", nudPos.Value)
    End Sub

    Private Sub nudNumCols_ValueChanged(sender As Object, e As EventArgs) Handles nudNumCols.ValueChanged
        ucrBase.clsRsyntax.AddParameter("number_cols", nudNumCols.Value)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaultValues()
    End Sub

    Private Sub ucrDataFramesList_Leave(sender As Object, e As EventArgs) Handles ucrDataFramesList.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrDataFramesList_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFramesList.DataFrameChanged
        iCountVariables = frmEditor.grdData.GetWorksheetByName(ucrDataFramesList.cboAvailableDataFrames.SelectedItem).ColumnCount
        nudPos.Maximum = iCountVariables + 1
        nudPos.Value = iCountVariables
    End Sub
End Class
