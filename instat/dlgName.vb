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
    Private bUseDefaultName As Boolean
    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrReceiverNames.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverNames.Selector = ucrSelectorByDataFrameAddRemove
        defaultSettings()
        'set the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        ucrReceiverNames.txtReceiverSingle.Text = frmEditor.grdData.CurrentWorksheet.ColumnHeaders(frmEditor.grdData.CurrentWorksheet.SelectionRange.Col).[Text]
    End Sub

    Private Sub defaultSettings()
        autoTranslate(Me)
        ucrReceiverNames.Clear()
        ucrReceiverNames.Enabled = False
        ucrReceiverNames.Visible = False
        ucrReceiverNames.Clear()
        ucrReceiverNames.SetMeAsReceiver()
        ucrReceiverNames.Enabled = True
        ucrReceiverNames.Visible = True
        bUseDefaultName = True
        'txtName.Text = ""
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        defaultSettings()
    End Sub

    Private Sub ucrSingle_ValueChanged(sender As Object, e As EventArgs) Handles ucrReceiverNames.ValueChanged
        If bUseDefaultName Then
            txtName.Text = ucrReceiverNames.txtReceiverSingle.Text
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        bUseDefaultName = False
    End Sub

    'Public Sub setWorksheet(strCurrentWorksheetName As String, strSelectedColumn As String)
    '    ucrAddRemove.AddVariable(strCurrentWorksheetName, strSelectedColumn)
    'End Sub

    Private Sub ucrSingle_Leave(sender As Object, e As EventArgs) Handles ucrReceiverNames.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & frmEditor.grdData.CurrentWorksheet.Name & Chr(34))
        ucrBase.clsRsyntax.AddParameter("column_name", Chr(34) & frmEditor.grdData.CurrentWorksheet.ColumnHeaders(frmEditor.grdData.CurrentWorksheet.SelectionRange.Col).[Text] & Chr(34))
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & txtName.Text & Chr(34))
    End Sub
End Class