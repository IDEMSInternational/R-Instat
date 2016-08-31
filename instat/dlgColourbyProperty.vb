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
Public Class dlgColourbyProperty
    Public bFirstLoad As Boolean = True
    Private Sub dlgColourbyProperty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            TestOKEnabled()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverMetadataProperty.Selector = ucrSelectorColourByMetadata
        ucrReceiverMetadataProperty.SetMeAsReceiver()
        ucrReceiverMetadataProperty.SetItemType("metadata")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_column_colours_by_metadata")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorColourByMetadata.Reset()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverMetadataProperty.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorColourByMetadata_DataframeChanged() Handles ucrSelectorColourByMetadata.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorColourByMetadata.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverMetadataProperty_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMetadataProperty.SelectionChanged
        If Not ucrReceiverMetadataProperty.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("property", ucrReceiverMetadataProperty.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("property")
        End If
        TestOKEnabled()
    End Sub
End Class