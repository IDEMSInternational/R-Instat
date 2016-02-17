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

    Private Sub chkPos_CheckStateChanged(sender As Object, e As EventArgs) Handles chkPos.CheckStateChanged
        If chkPos.Checked = True Then
            nudPos.Enabled = True
            txtStartPos.Enabled = False
        Else
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
        txtStartPos.Text = "At the end."
        ucrBase.clsRsyntax.AddParameter("start_pos ", "length(" & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & ")")
        nudPos.Enabled = False
    End Sub

    Private Sub ucrDataFramesList_Leave(sender As Object, e As EventArgs) Handles ucrDataFramesList.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub txtDefaultData_Leave(sender As Object, e As EventArgs) Handles txtDefaultData.Leave
        ucrBase.clsRsyntax.AddParameter("col_data ", "c(" & txtDefaultData.Text & ")")
    End Sub

    Private Sub nudPos_ValueChanged(sender As Object, e As EventArgs) Handles nudPos.ValueChanged
        ucrBase.clsRsyntax.AddParameter("start_pos ", nudPos.Value)
    End Sub

    Private Sub nudNumCols_ValueChanged(sender As Object, e As EventArgs) Handles nudNumCols.ValueChanged
        ucrBase.clsRsyntax.AddParameter("number_cols", nudNumCols.Value)
    End Sub

    Private Sub txtStartPos_Leave(sender As Object, e As EventArgs) Handles txtStartPos.Leave
        ucrBase.clsRsyntax.AddParameter("start_pos ", "length(" & ucrDataFramesList.cboAvailableDataFrames.SelectedItem & ")")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaultValues()
    End Sub
End Class