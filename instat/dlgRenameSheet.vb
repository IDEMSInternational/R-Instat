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
    Public bFirstLoad As Boolean = True
    Private Sub dlgRenameSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_dataframe")
        ucrBase.iHelpTopicID = 61
    End Sub

    Private Sub SetDefaults()
        ucrInputNewName.SetName(ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem)
        ucrInputNewName.Focus()
        ucrInputNewName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputNewName_NameChanged() Handles ucrInputNewName.NameChanged
        If ucrInputNewName.txtInput.Text <> "" Then
            ucrBase.clsRsyntax.AddParameter("new_value", Chr(34) & ucrInputNewName.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_value")
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputNewName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrDataFrameToRename_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameToRename.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem & Chr(34))
        ucrInputNewName.SetName(ucrDataFrameToRename.cboAvailableDataFrames.SelectedItem)
        ucrInputNewName.Focus()
        TestOKEnabled()
    End Sub
End Class