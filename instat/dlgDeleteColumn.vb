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
Public Class dlgDeleteColumn
    Private Sub dlgDeleteColumn_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrReceiverColumnsToDelete.Selector = ucrDataFrameAddRemove
        ucrReceiverColumnsToDelete.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
        autoTranslate(Me)
    End Sub

    Private Sub ucrDataFrameAddRemove_Leave(sender As Object, e As EventArgs) Handles ucrDataFrameAddRemove.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverColumnsToDelete_Leave(sender As Object, e As EventArgs) Handles ucrReceiverColumnsToDelete.Leave
        ucrBase.clsRsyntax.AddParameter("cols", ucrReceiverColumnsToDelete.GetVariableNames)
    End Sub
End Class