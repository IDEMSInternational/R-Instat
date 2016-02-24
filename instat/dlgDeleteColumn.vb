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
Public Class dlgDeleteColumn
    Public bFirstLoad As Boolean = True
    Private Sub dlgDeleteColumn_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.iHelpTopicID = 53
        ucrReceiveColumnsToDelete.Selector = ucrSelectColumnsToDelete
        ucrReceiveColumnsToDelete.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
        autoTranslate(Me)
        If bFirstLoad Then
            setDefaults()
        End If
        TestOKEnabled()
    End Sub

    Private Sub setDefaults()
        ucrReceiveColumnsToDelete.Clear()
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiveColumnsToDelete.GetVariableNames <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        setDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiveColumnsToDelete_SelectionChanged() Handles ucrReceiveColumnsToDelete.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("cols", ucrReceiveColumnsToDelete.GetVariableNames)
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectColumnsToDelete_DataFrameChanged() Handles ucrSelectColumnsToDelete.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectColumnsToDelete.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        TestOKEnabled()
    End Sub
End Class