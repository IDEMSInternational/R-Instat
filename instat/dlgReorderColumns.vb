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
Public Class dlgReorderColumns
    Dim bFirstLoad As Boolean = True
    Private Sub dlgReorderColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            initialiseDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub initialiseDialog()
        'sets the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$reorder_columns_in_data")
        ucrReorderColumns.setDataType("column")
        ucrReorderColumns.setDataframes(ucrDataFrameSelect)
        ucrBase.iHelpTopicID = 163
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        ucrDataFrameSelect.Reset()
        TestOkEnabled()
    End Sub

    Private Sub ucrReorderColumns_OrderChanged() Handles ucrReorderColumns.OrderChanged
        If Not ucrReorderColumns.isEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_order", ucrReorderColumns.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_order")
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReorderColumns.isEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrDataFrameSelect_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameSelect.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameSelect.cboAvailableDataFrames.Text & Chr(34))
        TestOkEnabled()
    End Sub
End Class