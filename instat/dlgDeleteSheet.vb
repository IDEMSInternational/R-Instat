﻿' Instat-R
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
    Public bFirstLoad As Boolean = True
    Private Sub dlgDeleteSheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.iHelpTopicID = 63
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$delete_dataframe")
    End Sub

    Private Sub SetDefaults()
        ucrDataFrameToDelete.Focus()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrDataFrameToDelete_DataFrameChanged() Handles ucrDataFrameToDelete.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameToDelete.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class