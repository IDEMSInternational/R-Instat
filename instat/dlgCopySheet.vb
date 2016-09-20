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
Public Class dlgCopySheet
    Public bFirstLoad As Boolean = True
    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 62
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrDataFrameCopySheets.cboAvailableDataFrames.Text <> "" AndAlso Not ucrNewDataFrameName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        If ucrDataFrameCopySheets.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataFrameName.SetName(ucrDataFrameCopySheets.cboAvailableDataFrames.SelectedItem & "_copy")
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$copy_data_frame")
        ucrBase.iHelpTopicID = 263
        ucrNewDataFrameName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrDataFrameCopySheets_DataFrameChanged() Handles ucrDataFrameCopySheets.DataFrameChanged
        ucrNewDataFrameName.SetName(ucrDataFrameCopySheets.cboAvailableDataFrames.SelectedItem & "_copy")
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameCopySheets.cboAvailableDataFrames.SelectedItem & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub ucrNewSheetName_NameChanged() Handles ucrNewDataFrameName.NameChanged
        ucrBase.clsRsyntax.AddParameter("new_name", Chr(34) & ucrNewDataFrameName.GetText & Chr(34))
        TestOKEnabled()
    End Sub

End Class