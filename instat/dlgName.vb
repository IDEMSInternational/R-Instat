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
Public Class dlgName
    Dim bFirstLoad As Boolean = True
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""

    Private Sub dlgName_Load(sender As Object, e As EventArgs) Handles Me.Load
        ucrBase.iHelpTopicID = 33
        autoTranslate(Me)
        'set the function
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$rename_column_in_data")
        If bFirstLoad Then
            SetDefaults()
        End If
        TestOKEnabled()
    End Sub

    Public Sub SetDefaults()
        ucrSelectVariables.Reset()
        ucrReceiverName.Selector = ucrSelectVariables
        ucrReceiverName.SetMeAsReceiver()
        If strSelectedColumn <> "" AndAlso strSelectedDataFrame <> "" Then
            ucrSelectVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
            ucrReceiverName.SetSelected(strSelectedColumn, strSelectedDataFrame)
            strSelectedColumn = ""
            strSelectedDataFrame = ""
        End If
        bFirstLoad = False
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverName_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverName.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("column_name", ucrReceiverName.GetVariableNames)
        txtName.Text = ucrReceiverName.GetVariableNames
        TestOKEnabled()
    End Sub

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        ucrBase.clsRsyntax.AddParameter("new_val", Chr(34) & txtName.Text & Chr(34))
        TestOKEnabled()
    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReceiverName.IsEmpty() And txtName.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectVariables_DataFrameChanged() Handles ucrSelectVariables.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", ucrSelectVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
    End Sub

End Class
