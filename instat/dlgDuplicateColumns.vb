' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgDuplicateColumns
    Public bFirstLoad As Boolean = True
    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            initialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        'checks OkEnabled
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForDuplicateColumn.Reset()
        ucrInputColumnName.Reset()
        ucrInputColumnName.SetPrefix(ucrReceiverForCopyColumns.GetVariableNames(False))
    End Sub
    Private Sub initialiseDialog()
        'sets the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        ucrReceiverForCopyColumns.Selector = ucrSelectorForDuplicateColumn
        ucrReceiverForCopyColumns.SetMeAsReceiver()
        ucrInputColumnName.SetItemsTypeAsColumns()
        ucrInputColumnName.SetDefaultTypeAsColumn()
        ucrReceiverForCopyColumns.bUseFilteredData = False
        ucrInputColumnName.SetDataFrameSelector(ucrSelectorForDuplicateColumn.ucrAvailableDataFrames)
        ucrInputColumnName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForCopyColumns.IsEmpty AndAlso Not ucrInputColumnName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverForCopyColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCopyColumns.SelectionChanged
        ucrInputColumnName.SetPrefix(ucrReceiverForCopyColumns.GetVariableNames(False))
        If Not ucrReceiverForCopyColumns.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_data", clsRFunctionParameter:=ucrReceiverForCopyColumns.GetVariables)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_data")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForDuplicateColumn_DataFrameChanged() Handles ucrSelectorForDuplicateColumn.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDuplicateColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrInputColumnName_NameChanged() Handles ucrInputColumnName.NameChanged
        If Not ucrInputColumnName.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & ucrInputColumnName.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        TestOKEnabled()
    End Sub
End Class