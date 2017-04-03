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
Public Class dlgViewAndRemoveKeys
    Public bFirstLoad As Boolean = True
    Private Sub dlgViewAndRemoveKeys_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_key")
        ucrSelectorKeys.SetItemType("key")
        ucrReceiverSelectedKey.Selector = ucrSelectorKeys
        ucrReceiverSelectedKey.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 505
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSelectedKey.IsEmpty AndAlso chkRemoveKey.Checked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSelectorKeys.Reset()
        chkRemoveKey.Checked = False
    End Sub

    Private Sub ucrReceiverSelectedKey_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSelectedKey.SelectionChanged
        If Not ucrReceiverSelectedKey.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("key_name", ucrReceiverSelectedKey.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("key_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub chkRemoveKey_CheckedChanged(sender As Object, e As EventArgs) Handles chkRemoveKey.CheckedChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorKeys_DataFrameChanged() Handles ucrSelectorKeys.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorKeys.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class