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

Public Class dlgFreezeColumns
    Public bFirstLoad As Boolean = True


    Private Sub dlgFreezeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False

        End If

    End Sub

    Private Sub SetDefaults()
        ucrSelectorByDataFrameAddRemoveforFreezeColumns.Reset()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseforFreezeColumns.iHelpTopicID = 444
        ucrReceiverMultipleforFreezeColumns.Selector = ucrSelectorByDataFrameAddRemoveforFreezeColumns
        ucrReceiverMultipleforFreezeColumns.SetMeAsReceiver()
        ucrBaseforFreezeColumns.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_freeze_columns")

    End Sub

    Private Sub ucrBaseforFreezeColumns_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseforFreezeColumns.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrSelectorByDataframeAddRemoveforFreezeColumns_DataFrameChanged() Handles ucrSelectorByDataFrameAddRemoveforFreezeColumns.DataFrameChanged
        ucrBaseforFreezeColumns.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforFreezeColumns.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrReceiverHiddenColumns_SelectionChanged() Handles ucrReceiverMultipleforFreezeColumns.SelectionChanged
        If Not ucrReceiverMultipleforFreezeColumns.IsEmpty Then
            ucrBaseforFreezeColumns.clsRsyntax.AddParameter("col_names", ucrReceiverMultipleforFreezeColumns.GetVariableNames())
        Else
            ucrBaseforFreezeColumns.clsRsyntax.AddParameter("col_names", "c()")
        End If
    End Sub

    Private Sub ucrSelectorByDataFrameAddRemoveforFreezeColumns_Load(sender As Object, e As EventArgs) Handles ucrSelectorByDataFrameAddRemoveforFreezeColumns.Load

    End Sub


End Class