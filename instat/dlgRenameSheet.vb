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
Public Class dlgRenameSheet
    Private Sub dlgRenameSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        'set the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_dataframe")
    End Sub

    Private Sub txtNewName_Leave(sender As Object, e As EventArgs) Handles txtNewName.Leave
        If txtNewName.Text <> "" Then
            ucrBase.clsRsyntax.AddParameter("new_value", Chr(34) & txtNewName.Text & Chr(34))
        End If
    End Sub

    Private Sub ucrDataFrameToRename_Leave(sender As Object, e As EventArgs) Handles ucrDataFrameToRename.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class