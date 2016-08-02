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
Public Class dlgHideShowColumns
    Public bFirstLoad As Boolean = True
    Private Sub dlgHideShowColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            TestOKEnabled()
            bFirstLoad = False
        End If
        SetHiddenColumnsInReceiver()
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverHiddenColumns.IsEmpty = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 167
        ucrReceiverHiddenColumns.Selector = ucrSelectorForHiddenColumns
        ucrReceiverHiddenColumns.SetMeAsReceiver()
        ucrReceiverHiddenColumns.bExcludeFromSelector = True
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_hidden_columns")
        ucrSelectorForHiddenColumns.bShowHiddenColumns = True
    End Sub

    Private Sub SetHiddenColumnsInReceiver()
        ucrReceiverHiddenColumns.AddItemsWithMetadataProperty(ucrSelectorForHiddenColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Is_Hidden", {"TRUE"})
    End Sub

    Private Sub SetDefaults()
        SetHiddenColumnsInReceiver()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetHiddenColumnsInReceiver()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForHiddenColumns_DataFrameChanged() Handles ucrSelectorForHiddenColumns.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForHiddenColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        SetHiddenColumnsInReceiver()
    End Sub

    Private Sub ucrReceiverHiddenColumns_SelectionChanged() Handles ucrReceiverHiddenColumns.SelectionChanged
        If Not ucrReceiverHiddenColumns.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiverHiddenColumns.GetVariableNames())
        Else
            ucrBase.clsRsyntax.AddParameter("col_names", "c()")
        End If
        TestOKEnabled()
    End Sub

End Class