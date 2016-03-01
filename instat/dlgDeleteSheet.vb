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
Public Class dlgDeleteSheet
    Private Sub dlgDeleteSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.iHelpTopicID = 63
        'set the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$delete_dataframe")
        ucrDataFrameToDelete.Focus()
        autoTranslate(Me)
    End Sub

    Private Sub ucrDataFrameToDelete_Leave(sender As Object, e As EventArgs) Handles ucrDataFrameToDelete.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameToDelete.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class