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
Public Class dlgUnstack
    Private Sub dlgUnstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction("unstack")
        ucrBase.clsRsyntax.iCallType = 1
        ucrReceiverColumns.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverFactors.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverFactors.SetMeAsReceiver()

        autoTranslate(Me)
        lblSheetName.Visible = False
        txtSheetName.Visible = False
    End Sub

    Private Sub rdoNewWorksheet_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNewWorksheet.CheckedChanged
        If rdoNewWorksheet.Checked = True Then
            lblSheetName.Visible = True
            txtSheetName.Visible = True
        Else
            lblSheetName.Visible = False
            txtSheetName.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverColumns_Enter(sender As Object, e As EventArgs) Handles ucrReceiverColumns.Enter
        ucrReceiverColumns.SetMeAsReceiver()
    End Sub
End Class