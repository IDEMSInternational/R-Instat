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
Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        'set the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        ucrReceiverName.Selector = ucrSelectVariables
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        txtName.Text = ""
        ucrReceiverName.SetMeAsReceiver()
        ucrSelectVariables.Reset()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverName_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverName.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("column_name", Chr(34) & ucrReceiverName.txtReceiverSingle.Text & Chr(34))
        txtName.Text = ucrReceiverName.txtReceiverSingle.Text
        TestOKEnabled()
    End Sub

    Public Sub setSettings(strCurrentWorksheetName As String, strSelectedColumn As String)
        'sets the defaults when calling the dialog
        ucrReceiverName.txtReceiverSingle.Text = strSelectedColumn
        ucrSelectVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strCurrentWorksheetName
        txtName.Text = strSelectedColumn
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & txtName.Text & Chr(34))
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverName.IsEmpty() And txtName.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectVariables_DataFrameChanged() Handles ucrSelectVariables.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & frmEditor.grdData.CurrentWorksheet.Name & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        TestOKEnabled()
    End Sub

End Class
