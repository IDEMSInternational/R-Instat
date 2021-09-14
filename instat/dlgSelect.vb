' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgSelect
    Private bFirstLoad As Boolean = True
    Private Sub dlgSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrInputSelectPreview.txtInput.ReadOnly = True
        ucrReceiverSelect.SetItemType("column_selection")
        ucrReceiverSelect.strSelectorHeading = "Column selections"
        ucrReceiverSelect.Selector = ucrSelectorForSelectColumns
        ucrReceiverSelect.SetMeAsReceiver()

        ucrNewDataFrameName.SetIsTextBox()
        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
        ucrNewDataFrameName.SetDataFrameSelector(ucrSelectorForSelectColumns.ucrAvailableDataFrames)
        ucrNewDataFrameName.SetLabelText("New Data Frame Name:")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForSelectColumns.Reset()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdDefineNewSelect_Click(sender As Object, e As EventArgs) Handles cmdDefineNewSelect.Click
        dlgSelectColumns.ShowDialog()
    End Sub
End Class