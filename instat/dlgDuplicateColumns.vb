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
            bFirstLoad = False
        End If
        'checks OkEnabled
        TestOKEnabled()
    End Sub

    Private Sub initialiseDialog()
        'sets the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$copy_columns")
        ucrReceiveColumns.Selector = ucrSelectColumnstoCopy
        ucrReceiveColumns.SetMeAsReceiver()
        'ucrBase.iHelpTopicID = 
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        ucrSelectColumnstoCopy.Reset()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiveColumns.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiveColumns_SelectionChanged() Handles ucrReceiveColumns.SelectionChanged
        If Not ucrReceiveColumns.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiveColumns.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_names")
        End If
        'Test ok enabled
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectColumnstoCopy_DataFrameChanged() Handles ucrSelectColumnstoCopy.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectColumnstoCopy.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub
End Class